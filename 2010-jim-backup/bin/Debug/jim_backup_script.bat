echo off
:LoopStart
taskkill /im "outlook.exe" 2> "F:\Documents and Settings\Janis\My Documents\Visual Studio 2005\Projects\jim_backup_20100705_2\jim_backup_20100705_2\bin\Debug\outlook_status.txt"
find c:\outlook_status.txt "not found">nul
goto :%errorlevel%
:1
echo "OL ir ON"
goto:Loopstart
:0
echo "OL ir OFF"
"F:\Documents and Settings\Janis\My Documents\Visual Studio 2005\Projects\jim_backup_20100705_2\jim_backup_20100705_2\bin\Debug\robocopy" "C:\Backup\100_FUJI" "H:\20100706\1-XP\Janis\mail" /ZB /V /TBD /E /FP /NP /LOG+:H:\20100706\1-XP\Janis\jim_backup_log.txt
echo ol_done
"F:\Documents and Settings\Janis\My Documents\Visual Studio 2005\Projects\jim_backup_20100705_2\jim_backup_20100705_2\bin\Debug\robocopy" "C:\Backup\100_FUJI" "H:\20100706\1-XP\Janis\docs" /ZB /V /TBD /E /FP /NP /LOG+:H:\20100706\1-XP\Janis\jim_backup_log.txt
echo backup_done
del "F:\Documents and Settings\Janis\My Documents\Visual Studio 2005\Projects\jim_backup_20100705_2\jim_backup_20100705_2\bin\Debug\outlook_status.txt" /f /q
goto:eof
