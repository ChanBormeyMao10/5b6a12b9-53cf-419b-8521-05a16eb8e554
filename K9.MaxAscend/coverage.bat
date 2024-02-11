.\packages\OpenCover.4.7.1221\tools\OpenCover.Console.exe  "-target:.\packages\NUnit.ConsoleRunner.3.17.0\tools\nunit3-console.exe" "-targetargs: .\K9.MaxAscend.Test\bin\Debug\K9.MaxAscend.Test.dll" -filter:"+[*]* -[*Test]*" -register:user

.\packages\ReportGenerator.5.2.1\tools\net47\ReportGenerator.exe "-reports:results.xml" "-targetdir:.\coverage"

pause
