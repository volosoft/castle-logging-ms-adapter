REM "..\tools\gitlink\GitLink.exe" ..\ -u https://github.com/aspnetboilerplate/aspnetboilerplate -c release

@ECHO OFF
SET /P VERSION_SUFFIX=Please enter version-suffix (can be left empty): 

dotnet "pack" "..\src\Castle.LoggingFacility.MsLogging" -c "Release" -o "." --version-suffix "%VERSION_SUFFIX%"

pause
