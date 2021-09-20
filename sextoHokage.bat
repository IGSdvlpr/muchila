@ECHO off 
color 0a

MODE CON COLS=64 LINES=34

:: "START /?>D:\ismael.gaete/Desktop/uso-powercfg.txt "  (averiguar las funcionalidades de un comando)

:INICIO


CLS
:://convertir en un objeto?
CLS
echo  ..............................................................
echo  ..............................................................
echo  .................... BUENOS DIAS ISMAEL ......................
echo  ..............................................................
echo  ..............................................................
echo.
echo.
echo.
echo.

:://convertir en un objeto?

timeout /t 1 /nobreak > NUL

set ACCION=
echo              ...................................
echo              ..........-SELECCIONE-............
echo              ...................................
	  	           
echo.                   
echo              (1) - TODOS
echo.                   
echo              (2) - GMAIL
echo.                   
echo              (3) - CORREO
echo.  
echo              (4) - NOTEPAD++
echo.                  
echo              (S) - SALIR		
echo.                   
echo              INGRESE UNA OPCION:

set /p ACCION= 

IF %ACCION%==1 GOTO TODOS
IF %ACCION%==2 GOTO G
IF %ACCION%==3 GOTO CORREO
IF %ACCION%==4 GOTO NOTEP

IF %ACCION%==S GOTO SALIR
IF %ACCION%==s GOTO SALIR


GOTO Error

:TODOS

::1
echo Abriendo MUCHILA...
timeout /t 3 /nobreak > NUL
start  C:\Users\xmael\Desktop\MUCHILA
echo.

::2
echo Abriendo Capturador de Pantalla...
timeout /t 2 /nobreak > NUL
start  C:\Users\xmael\Desktop\PORTABLEs\FSCapture85\FSCapture.exe
echo.
CLS


::3
echo Abriendo navegador.../
start /MIN chrome.exe
timeout /t 4 /nobreak > NUL
echo.
CLS
goto INICIO


::4
:CORREO
echo Abriendo correo OFICCE...
cd "C:\Program Files\Microsoft Office\Office14\"
START /MIN OUTLOOK.EXE
timeout /t 4 /nobreak > NUL
echo.
echo Terminado...

::5
:G

echo Abriendo G MAIL...
START  https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox
timeout /t 4 /nobreak > NUL
echo.
echo Terminado...

CLS
goto INICIO

:NOTEP

echo Abriendo NOTEPAD + + ...

Start C:\ProgramData\Microsoft\Windows\"Start Menu"\Programs\Notepad++.lnk
timeout /t 4 /nobreak > NUL
echo.
echo Terminado...

CLS
goto INICIO



:: AT 11:30 /EVERY:m,t,w,th,f,s,su (para ejecutar una tarea programada:AT 11:30, especifica hora /EVERY: especificar dias

::limpiar cache




  
:SALIR

COLOR 0F

CLS
echo.
echo.
echo.
echo.
echo           ...........cerrando............
echo.
echo.
echo            _______________________________
echo           /\                              \
echo          /@@\    __________________________\
echo          \@@@\   \ 000000000000000000000000/
echo           \@@@\   \___________________ 000/
echo            \@@@\   \             /@@@/000/
echo             \@@@\   \           /@@@/000/
echo              \@@@\   \         /@@@/000/
echo               \@@@\   \       /@@@/000/
echo                \@@@\   \     /@@@/000/
echo                 \@@@\   \   /@@@/000/
echo                  \@@@\   \ /@@@/000/
echo                   \@@@\   /@@@/000/
echo                    \@@@\ /@@@/000/
echo                     \@@@@@@@/000/
echo                      \@@@@@/000/
echo                       \@@@/000/
echo                        \@/___/ 


   
timeout /t 2 /nobreak > NUL

CLS
exit
exit




:Error

CLS
echo.
echo.   Opcion incorrecta...
echo.
echo                  uuuuuuu
echo              uu$$$$$$$$$$$uu
echo           uu$$$$$$$$$$$$$$$$$uu
echo          u$$$$$$$$$$$$$$$$$$$$$u
echo         u$$$$$$$$$$$$$$$$$$$$$$$u
echo        u$$$$$$$$$$$$$$$$$$$$$$$$$u
echo        u$$$$$$$$$$$$$$$$$$$$$$$$$u
echo        u$$$$$$"   "$$$"   "$$$$$$u
echo        "$$$$"      u$u       $$$$"
echo         $$$u       u$u       u$$$
echo         $$$u      u$$$u      u$$$
echo          "$$$$uu$$$   $$$uu$$$$"
echo           "$$$$$$$"   "$$$$$$$"
echo             u$$$$$$$u$$$$$$$u
echo              u$"$"$"$"$"$"$u
echo   uuu        $$u$ $ $ $ $u$$       uuu
echo  u$$$$        $$$$$u$u$u$$$       u$$$$
echo   $$$$$uu      "$$$$$$$$$"     uu$$$$$$
echo u$$$$$$$$$$$uu    """""    uuuu$$$$$$$$$$
echo $$$$"""$$$$$$$$$$uuu   uu$$$$$$$$$"""$$$"
echo  """      ""$$$$$$$$$$$uu ""$"""
echo            uuuu ""$$$$$$$$$$uuu
echo   u$$$uuu$$$$$$$$$uu ""$$$$$$$$$$$uuu$$$
echo   $$$$$$$$$$""""           ""$$$$$$$$$$$"
echo    "$$$$$"                      ""$$$$""
echo      $$$"                         $$$$

timeout /t 2 /nobreak > NUL
CLS
goto INICIO







