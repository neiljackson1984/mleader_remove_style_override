@echo off
if "%1" == "" goto usage
:normal
for %%i IN (*.exe *.dll *.arx *.dbx *.ocx *.ddf) DO dumpbin /exports %%i | findstr "%%i %1"
goto end
:usage
echo findapi "function name"
:end