@echo off

set _msbuildPath="C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin"

%_msbuildPath%\msbuild "..\src\CommandLine.sln" /t:Build /p:Configuration=Debug /v:m /m

"..\src\CommandLine\bin\Debug\net461\roslynator" list-symbols "..\src\Core.sln" ^
 --msbuild-path %_msbuildPath% ^
 --projects "Core" ^
 --visibility public ^
 --depth type ^
 --omit-containing-namespace ^
 --output "..\src\Core\README.md" ^
 --root-directory-url "../../docs/api/" ^
 --verbosity n ^
 --file-log "roslynator.log" ^
 --file-log-verbosity diag

pause
