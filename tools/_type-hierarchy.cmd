@echo off

set _msbuildPath="C:\Program Files\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin"

%_msbuildPath%\msbuild "..\src\CommandLine.sln" /t:Build /p:Configuration=Debug /v:m /m

"..\src\CommandLine\bin\Debug\net461\roslynator" type-hierarchy "..\src\Core.sln" ^
 --msbuild-path %_msbuildPath% ^
 --visibility public ^
 --references ^
    Microsoft.CodeAnalysis.dll ^
    Microsoft.CodeAnalysis.CSharp.dll ^
    Microsoft.CodeAnalysis.Workspaces.dll ^
    Microsoft.CodeAnalysis.CSharp.Workspaces.dll ^
 --omit-containing-namespace ^
 --output "roslyn.txt" ^
 --verbosity n ^
 --file-log "roslynator.log" ^
 --file-log-verbosity diag

pause
