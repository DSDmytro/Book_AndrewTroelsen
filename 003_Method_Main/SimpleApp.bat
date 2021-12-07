@echo off

rem
rem

SimpleApp
@if "%ERRORLEVEL%" == "0" goto success

:fail
echo This application has failed!
rem
echo return value = %ERRORLEVEL%
goto end
:success
echo This application has succeeded!
rem
echo return value = %ERRORLEVEL%
goto end
:end
echo All Done
rem Done