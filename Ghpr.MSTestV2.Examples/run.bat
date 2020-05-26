.\packages\Microsoft.TestPlatform.16.6.1\tools\net451\Common7\IDE\Extensions\TestPlatform\vstest.console.exe .\bin\debug\Ghpr.MSTestV2.Examples.dll /Logger:trx
@ECHO OFF
FOR /F "DELIMS=" %%F IN ('DIR /B /A-D /OD /TW .\TestResults\*.trx') DO (SET FILE=%%F)
@ECHO OFF
ECHO Most recently modified file is:
ECHO %FILE%

.\bin\debug\Ghpr.Console.exe .\TestResults\%FILE%