echo %1
echo %2
echo %3
echo %4


set directory=%2
for /f "useback tokens=*" %%a in ('%directory%') do set directory=%%~a

set fileName=%3
for /f "useback tokens=*" %%a in ('%fileName%') do set fileName=%%~a

set extension=%4
for /f "useback tokens=*" %%a in ('%extension%') do set extension=%%~a

echo %directory%\%fileName%%extension%


timeout 10
