@echo off

set "caminhoImagem=C:\Users\Gabriel\source\repos\RoletaTroll\RoletaTroll\itensSorteio\1283a5e54f0f814fcc02eee69fe9a09368319332r1-529-278v2_uhq.jpg"

rem Verifica se o arquivo de imagem existe
if not exist "%caminhoImagem%" (
    echo Arquivo de imagem não encontrado.
    exit /b
)

rem Define o valor no registro para o papel de parede
reg add "HKEY_CURRENT_USER\Control Panel\Desktop" /v Wallpaper /t REG_SZ /d "%caminhoImagem%" /f

rem Aguarda 2 segundos (ajuste conforme necessário)
timeout /t 2 /nobreak > NUL

rem Atualiza as configurações do papel de parede do desktop
RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters

rem Aguarda 2 segundos novamente (ajuste conforme necessário)
timeout /t 2 /nobreak > NUL

rem Força uma atualização adicional das configurações do papel de parede
RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters

echo Papel de parede alterado com sucesso.
