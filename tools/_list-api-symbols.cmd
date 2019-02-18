@echo off

set _msbuildPath="C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin"

%_msbuildPath%\msbuild "..\src\CommandLine.sln" /t:Build /p:Configuration=Debug /v:m /m

"..\src\CommandLine\bin\Debug\net461\roslynator" list-symbols "..\src\Core.sln" ^
 --msbuild-path %_msbuildPath% ^
 --visibility public ^
 --depth member ^
 --omit-containing-namespace ^
 --include-documentation --include-attributes --include-attribute-arguments ^
 --output "api.txt" "api.xml" "api.md" ^
 --verbosity n ^
 --file-log "roslynator.log" ^
 --file-log-verbosity diag

pause
