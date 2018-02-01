echo off
:LoopStart
taskkill /im "outlook.exe" 2> "J:\jim_backup_20101014_14-17\outlook_status.txt"
find "not found" "J:\jim_backup_20101014_14-17\outlook_status.txt">nul
goto :%errorlevel%
:1
echo "OL ir ON"
goto:Loopstart
:0
echo "OL ir OFF"
"J:\jim_backup_20101014_14-17\robocopy" "D:\Backup_JB\20100706\1-7\citi\mail1" "\\192.168.1.100\Backup_JB\20100706\4-7\cat\mail1" /MIR /XJ /LOG+:"\\192.168.1.100\Backup_JB\20100706\4-7\cat\jim_backup.log"
echo ol_done
del "J:\jim_backup_20101014_14-17\outlook_status.txt" /f /q
"J:\jim_backup_20101014_14-17\robocopy" "D:\Backup_JB\20100706\1-7\citi\d2" "\\192.168.1.100\Backup_JB\20100706\4-7\cat\docs1" /MIR /XJ /LOG+:"\\192.168.1.100\Backup_JB\20100706\4-7\cat\jim_backup.log"
"J:\jim_backup_20101014_14-17\robocopy" "D:\Backup_JB\20100706\1-7\citi\d2" "\\192.168.1.100\Backup_JB\20100706\4-7\cat\docs12" /MIR /XJ /LOG+:"\\192.168.1.100\Backup_JB\20100706\4-7\cat\jim_backup.log"
echo backup_done
goto:eof
