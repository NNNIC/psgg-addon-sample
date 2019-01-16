@echo off
cd /d %~dp0
echo : 
echo : copy addon_sample.dll to APPDATA\LOCAL\psgg
echo :
pause
robocopy bin\Debug "%USERPROFILE%\AppDate\Local\psgg" *.*
pause