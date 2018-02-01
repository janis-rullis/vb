Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Dim dbDSet As DataSet
    Dim typdDSet As typedDataSet
    Dim worker As Data.DataTable
    Dim boss As Data.DataTable
    Dim job As Data.DataTable
    Dim dv As DataView
    Dim row As Data.DataRow
    Dim connStr As String
    Dim insertColArray(3) As TextBox
    Dim conn As SqlConnection


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        insertColArray(0) = insertCol0Box
        insertColArray(1) = insertCol1Box
        insertColArray(2) = insertCol2Box
        insertColArray(3) = insertCol3Box
    End Sub

    'dSetSource on change
    Private Sub dSetSourceBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dSetSourceBox.TextChanged
        If dSetSourceBox.Text = "datu bâze" Then
            changeTabItems("datu bâze")
        ElseIf dSetSourceBox.Text = "typed data set" Then
            changeTabItems("typed data set")
        End If
    End Sub

    'DB create set button click
    Private Sub createDbSetBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles createDbSetBtn.Click
        'palaiz procedutu, kura piesledzas pie db un izveido data setu
        If dSetSourceBox.Text = "datu bâze" Then
            createDbSet()
        ElseIf dSetSourceBox.Text = "typed data set" Then

            createTypedSet()
        End If

    End Sub

    'DB show button click
    Private Sub showDbBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showDbBtn.Click
        'palaiþ procedûru, kas parada DataGridView1'â db data set'u
        If dSetSourceBox.Text = "datu bâze" Then
            showDbDataSet()
        ElseIf dSetSourceBox.Text = "typed data set" Then
            showTypedDataSet()
        End If
    End Sub

    ' save button click
    Private Sub saveBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveBtn.Click

        Dim saveTypeStr As String = "0"
        If saveBox.Text = "shema" Then
            saveTypeStr = "shema"
        ElseIf saveBox.Text = "data" Then
            saveTypeStr = "data"
        ElseIf saveBox.Text = "data" Then
            saveTypeStr = "diff"
        End If

        If dSetSourceBox.Text = "datu bâze" Then
            saveDbDataSet(saveTypeStr)
        ElseIf dSetSourceBox.Text = "typed data set" Then
            saveTypedDataSet(saveTypeStr)
        End If

        
    End Sub

    'read button click
    Private Sub readBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readBtn.Click

        Dim readTypeStr As String = "0"
        If readBox.Text = "data" Then
            readTypeStr = "data"
        ElseIf readBox.Text = "shema" Then
            readTypeStr = "shema"
        End If

        If dSetSourceBox.Text = "datu bâze" Then
            readDbDataSet(readTypeStr)
            showDbDataSet()
        ElseIf dSetSourceBox.Text = "typed data set" Then
            readTypedDataSet(readTypeStr)
            showTypedDataSet()
        End If
    End Sub

    'insert button click
    Private Sub insertBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertBtn.Click
        'izsauc procedûru, kura ievieto dataseta jaunu rindu
        If dSetSourceBox.Text = "datu bâze" Then
            insertDbDset()
        ElseIf dSetSourceBox.Text = "typed data set" Then
            insertTypedDset()
        End If
    End Sub

    'update button click
    Private Sub updateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateBtn.Click
        If dSetSourceBox.Text = "datu bâze" Then
            updateDbDset()
        ElseIf dSetSourceBox.Text = "typed data set" Then
            updateTypedDset()
        End If
    End Sub

    'sort button click
    Private Sub sortBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sortBtn.Click
        'palaiþ procedûra, kura sakârto datus gridviewâ
        sortDataSet()
    End Sub

    'delete button click
    Private Sub delBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delBtn.Click
        'izsauc procedûru, kura atjauno dataseta info
        If dSetSourceBox.Text = "datu bâze" Then
            deleteDbRow()
        ElseIf dSetSourceBox.Text = "typed data set" Then
            deleteTypDsetRow()
        End If
    End Sub

    '---------------

    'procedura, kura izveido typed data set
    Private Sub createTypedSet()
        typdDSet = New typedDataSet
        worker = New Data.DataTable
        boss = New Data.DataTable
        job = New Data.DataTable

        worker = typdDSet.Tables.Add("worker") ' izveido data seta tab
        boss = typdDSet.Tables.Add("boss")
        job = typdDSet.Tables.Add("job")

        With worker
            .Columns.Add("workerID", Type.GetType("System.Int32")) 'id = primary key
            .PrimaryKey = New DataColumn() {.Columns("id")}
            .Columns.Add("vards", Type.GetType("System.String"))
            .Columns.Add("uzvards", Type.GetType("System.String"))
        End With

        'izveido rindas
        '----------------
        '1)saliek rindas info mainigaja row
        row = worker.NewRow()
        row("workerID") = 1
        row("vards") = "janis"
        row("uzvards") = "rullis"

        '2)mainigo row ievieto tabula
        Try
            worker.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show("Insert Row into Worker table Error")
        End Try

        row = worker.NewRow()
        row("workerID") = 2
        row("vards") = "peek"
        row("uzvards") = ":)"

        '2)mainigo row ievieto tabula
        Try
            worker.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show("Insert Row Worker table Error")
        End Try
        'izveido, konfigure d.seta teacher tab 
        '---------------------------------------
        With boss
            .Columns.Add("bossID", Type.GetType("System.Int32"))
            'id = primary key
            .PrimaryKey = New DataColumn() {.Columns("id")}
            .Columns.Add("vards", Type.GetType("System.String"))
            .Columns.Add("uzvards", Type.GetType("System.String"))
        End With

        row = boss.NewRow()
        row("bossID") = 10
        row("vards") = "guntis"
        row("uzvards") = "guntis"

        Try
            boss.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show("Insert Row into Boss table Error")
        End Try

        'izveido, konfigure d.seta course tab 
        '---------------------------------------
        With job
            .Columns.Add("jobID", Type.GetType("System.Int32"))
            'id = primary key
            .PrimaryKey = New DataColumn() {.Columns("id")}
            .Columns.Add("nosaukums", Type.GetType("System.String"))
            .Columns.Add("workerID", Type.GetType("System.Int32"))
            .Columns.Add("bossID", Type.GetType("System.Int32"))
            ' fk relacija uz skolotaja tab
            .Constraints.Add("fk", boss.Columns("bossID"), .Columns("bossID"))
            .Columns.Add("workerID + bossID", Type.GetType("System.Int32"))
        End With

        row = job.NewRow()
        row("jobID") = 20
        row("nosaukums") = "Dspa"
        row("bossID") = 10
        row("workerID") = 1
        'expression
        row("workerID + bossID") = row("workerID") + row("bossID")

        Try
            job.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.ToString) 'pazino kludu
        End Try

        'izveido jaunu data view
        Dim dt As New DataTable
        Dim atlasDsetBoxStr = tabComboBox.Text
        dt = typdDSet.Tables(atlasDsetBoxStr)
        'izsauc proceduru, kura izveido Comboxu itemus
        comboxItemUpdate("sort") ' ,typdDSet.DataSetName
        comboxItemUpdate("update")
        comboxItemUpdate("where")
        insertBoxCheck("typed data set")
        MessageBox.Show("Ir ielasits typed data set")

    End Sub

    Private Sub dbConnection()
        'db conn strings
        connStr = "Data Source=" & Form2.dSourceTxtBox.Text & ";Initial Catalog=" & Form2.initCatTxtBox.Text & ";Integrated Security=" & Form2.integrSecComboBox.Text
        'izveido db konekcijas mobj
        conn = New SqlConnection(connStr)
        'atver konekciju
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("connection failed")
        End Try
    End Sub

    'procedura, kura ielasa datus no db data setâ
    Private Sub createDbSet()

        dbConnection()
        'izveido data setu
        dbDSet = New DataSet
        'izveido sql komandas objektu
        Dim cmdStr As String
        cmdStr = "select * from " & tabComboBox.Text
        'Dim sqlCmd As New SqlCommand(cmdStr, conn)

        dbDSet.DataSetName = tabComboBox.Text

        'sasaista data adapteri ar data setu
        'izveido data apadpteri
        Dim dAdapt As New SqlDataAdapter(cmdStr, conn)

        Try
            dAdapt.Fill(dbDSet)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        conn.Close()
        MessageBox.Show("Ir ielasits db data set")

        'izsauc proceduru, kura izveido Comboxu itemus
        comboxItemUpdate("sort") ' ,typdDSet.DataSetName
        comboxItemUpdate("update")
        comboxItemUpdate("where")
        insertBoxCheck("datu bâze")

    End Sub

    'procedura, kura  saglaba xml failâ  db datasetu, shemu, diffgram
    Private Sub saveDbDataSet(ByVal saveTypeStr As String)
        Dim ds As New DataSet
        If dbDSet Is Nothing Then
            MessageBox.Show("Nav ielasits db data set")
            Exit Sub
        End If
        Try
            If saveTypeStr = "shema" Then
                dbDSet.WriteXml("C:\xml\shema.xml")
            ElseIf saveTypeStr = "data" Then
                dbDSet.WriteXml("C:\xml\dati.xml")
            ElseIf saveTypeStr = "diff" Then
                dbDSet.WriteXml("C:\xml\diff.xml", XmlWriteMode.DiffGram)
            ElseIf saveTypeStr = "0" Then
                MessageBox.Show("glabasanas kluda")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    'procedura, kura  saglaba xml failâ  typed datasetu, shemu, diffgram
    Private Sub saveTypedDataSet(ByVal saveTypeStr As String)
        If typdDSet Is Nothing Then
            MessageBox.Show("Nav ielasits db data set")
            Exit Sub
        End If
        Try
            If saveTypeStr = "shema" Then
                typdDSet.WriteXml("C:\xml\shema.xml")
            ElseIf saveTypeStr = "data" Then
                typdDSet.WriteXml("C:\xml\dati.xml")
            ElseIf saveTypeStr = "diff" Then
                typdDSet.WriteXml("C:\xml\diff.xml", XmlWriteMode.DiffGram)
            ElseIf saveTypeStr = "0" Then
                MessageBox.Show("glabasanas kluda")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    'procedura, kura ielasa db data setu no XML faila
    Private Sub readDbDataSet(ByVal dsType As String)
        dbDSet = New DataSet
        Try
            If dsType = "shema" Then
                dbDSet.ReadXmlSchema("C:\xml\shema.xml")
            ElseIf dsType = "data" Then
                dbDSet.ReadXml("C:\xml\dati.xml")
            ElseIf dsType = "0" Then
                MessageBox.Show("Lasîðanas kïûda")
                Exit Sub
            End If
            MessageBox.Show("Ir ielasîts data set no XML")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    'procedura, kura ielasa typed data setu no XML faila
    Private Sub readTypedDataSet(ByVal readTypeStr As String)
        typdDSet = New typedDataSet
        Try
            If readTypeStr = "shema" Then
                typdDSet.ReadXmlSchema("C:\xml\shema.xml")
            ElseIf readTypeStr = "data" Then
                typdDSet.ReadXml("C:\xml\dati.xml")
            ElseIf readTypeStr = "0" Then
                MessageBox.Show("Lasîðanas kïûda")
                Exit Sub
            End If
            MessageBox.Show("Ir ielasîts data set no XML")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    'procedura, kura parada DataGridView1'â db data set'u
    Private Sub showDbDataSet()
        'izveido jaunu data seta skatu
        ' dv = New DataView
        If dbDSet Is Nothing Then
            MessageBox.Show("Nav ielasits db data set")
            Exit Sub
        End If
        dv = dbDSet.Tables(0).DefaultView
        DataGridView1.DataSource = dv
    End Sub

    'procedura, kura parada DataGridView1'â typed data set'u
    Private Sub showTypedDataSet()
        'dv = New DataView
        If typdDSet Is Nothing Then
            MessageBox.Show("Nav ielasits typed data set")
            Exit Sub
        Else
            dv = typdDSet.Tables(tabComboBox.Text).DefaultView
            DataGridView1.DataSource = dv
        End If
    End Sub

    Private Sub changeTabItems(ByVal dsSourceType As String)
        If dsSourceType = "datu bâze" Then
            tabComboBox.Items.Clear()
            tabComboBox.Items.Add("teacher")
            tabComboBox.Items.Add("student")
            tabComboBox.Items.Add("course")
            tabComboBox.Text = "teacher"
        ElseIf dsSourceType = "typed data set" Then
            tabComboBox.Items.Clear()
            tabComboBox.Items.Add("worker")
            tabComboBox.Items.Add("boss")
            tabComboBox.Items.Add("job")
            tabComboBox.Text = "worker"
        End If
    End Sub

    'procedura, kura izveido combobox itemus
    Private Sub comboxItemUpdate(ByVal comboBoxName As String) ', ByVal dsSourceType As String

        Dim ComboItemUpdBox As New ComboBox
        If comboBoxName = "sort" Then
            ComboItemUpdBox = sortBox
        ElseIf comboBoxName = "update" Then
            ComboItemUpdBox = UpdColComboBox
        ElseIf comboBoxName = "where" Then
            ComboItemUpdBox = whereColBox
        End If

        If tabComboBox.Text = "teacher" Then
            ComboItemUpdBox.Items.Clear()
            ComboItemUpdBox.Items.Add("teacher_id")
            delWhereLab.Text = "teacher_id"
            ComboItemUpdBox.Items.Add("name")
            ComboItemUpdBox.Items.Add("surname")
            ComboItemUpdBox.Text = "teacher_id"
        ElseIf tabComboBox.Text = "student" Then
            ComboItemUpdBox.Items.Clear()
            ComboItemUpdBox.Items.Add("student_id")
            delWhereLab.Text = "student_id"
            ComboItemUpdBox.Items.Add("name")
            ComboItemUpdBox.Items.Add("surname")
            ComboItemUpdBox.Text = "student_id"
        ElseIf tabComboBox.Text = "course" Then
            ComboItemUpdBox.Items.Clear()
            ComboItemUpdBox.Items.Add("course_id")
            delWhereLab.Text = "course_id"
            ComboItemUpdBox.Items.Add("name")
            ComboItemUpdBox.Text = "course_id"
        ElseIf tabComboBox.Text = "worker" Then
            ComboItemUpdBox.Items.Clear()
            ComboItemUpdBox.Items.Add("workerID")
            delWhereLab.Text = "workerID"
            ComboItemUpdBox.Items.Add("vards")
            ComboItemUpdBox.Items.Add("uzvards")
            ComboItemUpdBox.Text = "workerID"
        ElseIf tabComboBox.Text = "boss" Then
            ComboItemUpdBox.Items.Clear()
            ComboItemUpdBox.Items.Add("bossID")
            delWhereLab.Text = "bossID"
            ComboItemUpdBox.Items.Add("vards")
            ComboItemUpdBox.Items.Add("uzvards")
            ComboItemUpdBox.Text = "bossID"
        ElseIf tabComboBox.Text = "job" Then
            ComboItemUpdBox.Items.Clear()
            ComboItemUpdBox.Items.Add("jobID")
            delWhereLab.Text = "jobID"
            ComboItemUpdBox.Items.Add("nosaukums")
            ComboItemUpdBox.Text = "jobID"
        End If

    End Sub

    'procedura, kura sakarto datus DataGridView1'â 
    Private Sub sortDataSet()
        dv = DataGridView1.DataSource
        If sortBox.Text.Length > 0 Then
            If filterBox.Text.Length > 0 Then
                Try
                    dv.RowFilter = sortBox.Text & " like '" & filterBox.Text & "%'"
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    Exit Sub
                End Try
            End If
            dv.Sort = sortBox.Text
        End If

    End Sub

    'procedûru, kura veic izmaiòas db datasetâ
    Private Sub updateDbDset()
        dv = DataGridView1.DataSource
        If dv Is Nothing Then
            MessageBox.Show("Vispirms ielasiet dataset")
            Exit Sub
        Else
            Dim conn As New SqlConnection(connStr)
            Try
                dbDSet.Tables(0).Rows(0).Item(UpdColComboBox.Text) = updateBox.Text
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try


            'ja ir kâds where nosacîjums, tad ievieto to komandâ
            Dim whereStr As String = ""
            Dim sqlCmd As SqlCommand

            If whereBox.Text.Length > 0 Then
                sqlCmd = New SqlCommand("update " & tabComboBox.Text & " set " & UpdColComboBox.Text & " ='" & updateBox.Text & "' where " & whereColBox.Text & " = '" & whereBox.Text & "'", conn)
            Else
                sqlCmd = New SqlCommand("update " & tabComboBox.Text & " set " & UpdColComboBox.Text & " ='" & updateBox.Text & "'", conn)
            End If

            Dim das As New SqlDataAdapter
            das.UpdateCommand = sqlCmd
            Try
                das.Update(dbDSet)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
            'refresh un ielasa db ar jaunajam izmainam
            dbDSet.Clear()
            sqlCmd.CommandText = "select * from " & tabComboBox.Text
            das.SelectCommand = sqlCmd
            das.Fill(dbDSet)
            DataGridView1.Refresh()
        End If
    End Sub

    'procedûru, kura veic izmaiòas typed datasetâ
    Private Sub updateTypedDset()
        dv = DataGridView1.DataSource
        If dv Is Nothing Then
            MessageBox.Show("Vispirms ielasiet dataset")
            Exit Sub
        End If
        Try
            typdDSet.Tables(tabComboBox.Text).Rows(0).Item(UpdColComboBox.Text) = updateBox.Text
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    'procedûra, kura ievieto db datasetâ jaunu rindu
    Private Sub insertDbDset()

        'ja ir kâds where nosacîjums, tad ievieto to komandâ
        Dim sqlCmd As SqlCommand

        dbConnection() ' strâdâ

        Dim row As DataRow
        Dim insertTab As New DataTable
        insertTab = dbDSet.Tables(0)
        ' Dim dbSet As New DataSet
        row = insertTab.NewRow()
        'noskaidro cik kolonnas ir attiecigajai tab
        Dim a As Integer = insertTab.Columns.Count
        'saliek row mmainigajâ insert textboxu saturu
        Dim i As Integer
        For i = 0 To insertTab.Columns.Count - 1
            Try
                row(i) = insertColArray(i).Text
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try

        Next
        'ievieto tabula jauno rindu
        Try
            insertTab.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show("Insert Row Worker table Error")
        End Try

        '!!!!!   jasaskano ar dataseta ievadito rindu
        Dim insertStr As String = "insert " & tabComboBox.Text & " values ("
        For i = 0 To insertTab.Columns.Count - 1
            If IsNumeric(insertColArray(i).Text) Then
                insertStr = insertStr & "" & insertColArray(i).Text & ","
            Else : insertStr = insertStr & "'" & insertColArray(i).Text & "',"

            End If

        Next
        'nonem beigu komatu
        insertStr = insertStr.Substring(0, insertStr.Length - 1)

        insertStr = insertStr & ")"

        sqlCmd = New SqlCommand(insertStr, conn)
        Dim dAdapt As New SqlDataAdapter
        dAdapt.InsertCommand = sqlCmd
        Try
            dAdapt.Update(dbDSet)
            MessageBox.Show("insert sucessfull")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        sqlCmd.CommandText = "select * from " & tabComboBox.Text
        dAdapt.SelectCommand = sqlCmd
        'dAdapt.Fill(dbDSet)
        conn.Close()
        DataGridView1.DataSource = dbDSet.Tables(0).DefaultView
        MessageBox.Show("Ir ielasits db data set")

    End Sub

    'procedûra, kura ievieto typed datasetâ jaunu rindu
    Private Sub insertTypedDset()
        dv = DataGridView1.DataSource
        If dv Is Nothing Then
            MessageBox.Show("Vispirms ielasiet dataset")
            Exit Sub
        End If
        Dim row As DataRow
        Dim insertTab As New Data.DataTable
        If tabComboBox.Text = "worker" Then
            insertTab = typdDSet.Tables("worker")
        ElseIf tabComboBox.Text = "boss" Then
            insertTab = typdDSet.Tables("boss")
        ElseIf tabComboBox.Text = "job" Then
            insertTab = typdDSet.Tables("job")
        End If

        row = insertTab.NewRow()
        'noskaidro cik kolonnas ir attiecigajai tab
        Dim a As Integer = insertTab.Columns.Count
        'saliek row mmainigajâ insert textboxu saturu
        Dim i As Integer
        For i = 0 To insertTab.Columns.Count - 1
            row(i) = insertColArray(i).Text
        Next
        'ievieto tabula jauno rindu
        Try
            insertTab.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show("Insert Row Worker table Error")
        End Try

    End Sub

    'procedûra, kura liekos textboxus uztaisa par readonly
    Private Sub insertBoxCheck(ByVal dataSetTypeStr As String)
        Dim inserTab As New DataTable
        If dataSetTypeStr = "datu bâze" Then
            inserTab = dbDSet.Tables(0)
            'MessageBox.Show(dbDSet.Tables(0).Columns.Count)
        ElseIf dataSetTypeStr = "typed data set" Then
            inserTab = typdDSet.Tables(tabComboBox.Text)
        End If
        Dim i As Integer = 3
        'regule to lai varetu rakstit insert datus tik textboxos cik ir kolonnas
        While i > 0 And i > inserTab.Columns.Count - 1
            insertColArray(i).ReadOnly = True
            i = i - 1
        End While
        i = 0
        While i < inserTab.Columns.Count - 1
            insertColArray(i).ReadOnly = False
            i = i + 1
        End While


    End Sub

    Public Sub deleteDbRow()
        'dbDSet.Tables.Item
        Dim delRow() As DataRow
        delRow = dbDSet.Tables(0).Select(delWhereLab.Text & " = '" & delWhereBox.Text & "'")
        Try
            delRow(0).Delete()
            dbDSet.AcceptChanges()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        dbConnection()

        Dim dAdapt As New SqlDataAdapter
        Dim delStr As String = "delete from " & tabComboBox.Text & " where " & delWhereLab.Text & " = " & delWhereBox.Text
        Dim sqlCmd As New SqlCommand(delStr, conn)
        dAdapt.DeleteCommand = sqlCmd

        Try
            dAdapt.Update(dbDSet)
            MessageBox.Show("delete sucessfull")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        

        conn.Close()
    End Sub

    Public Sub deleteTypDsetRow()
        Dim delRow() As DataRow
        delRow = typdDSet.Tables(tabComboBox.Text).Select(delWhereLab.Text & " = '" & delWhereBox.Text & "'")
        delRow(0).Delete()
        typdDSet.AcceptChanges()
        
    End Sub

    
End Class
