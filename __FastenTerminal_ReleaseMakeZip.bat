cd "bin"

mkdir "CreateZip\FastenTerminal"

xcopy /S /Y "Debug\Images" "CreateZip\FastenTerminal\Images\"
xcopy /S /Y "Debug\Sounds" "CreateZip\FastenTerminal\Sounds\"
copy "Debug\DefaultCommandConfigs.xml" "CreateZip\FastenTerminal\CommandConfigs.xml"
copy "Debug\FastenTerminal.exe" "CreateZip\FastenTerminal\FastenTerminal.exe"
copy "Debug\FastenTerminalConfigs.xml" "CreateZip\FastenTerminal\FastenTerminalConfigs.xml"

mkdir "CreateZip\FastenTerminal\LOG"


REM for /d %%a in (CreateZip) do (ECHO zip -r -p "%%~na.zip" ".\%%a\*")
REM for /d %%a in (CreateZip) do (zip -r -p "CreateZip\FastenTerminal_v2018.02.10.zip" ".\%%a\*")
REM for /d %%a in (CreateZip) do (zip -r -p "%%~na.zip" ".\%%a\*")
cd "CreateZip"

REM Date format: "2018.02.10." (end of point is necessary for us)
set "zipFileName=FastenTerminal_v%date%zip"

REM set "zipStart=FastenTerminal_v"
REM set "zipEnd=.zip"
REM set "zipFileName=%zipStart%%datestr%%zipEnd%

for /d %%X in (*) do (for /d %%a in (%%X) do ( "c:\Program Files\7-Zip\7z.exe" a -tzip %zipFileName% ".\%%a\" ))

echo Zip file name: %zipFileName%
echo Date: %date%

cd ..
cd ..
