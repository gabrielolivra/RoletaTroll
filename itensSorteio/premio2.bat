@echo off

set "caminhoImagem=C:\Users\Gabriel\source\repos\RoletaTroll\RoletaTroll\itensSorteio\1283a5e54f0f814fcc02eee69fe9a09368319332r1-529-278v2_uhq.jpg"

if not exist "%caminhoImagem%" (
    echo Arquivo de imagem não encontrado.
    exit /b
)

reg add "HKEY_CURRENT_USER\Control Panel\Desktop" /v Wallpaper /t REG_SZ /d "%caminhoImagem%" /f


timeout /t 2 /nobreak > NUL

RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters


timeout /t 2 /nobreak > NUL

RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters


