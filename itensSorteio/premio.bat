@echo off
echo Desligando o computador em 30 segundos. Pressione CTRL+C para cancelar.
ping 127.0.0.1 -n 30 > nul
shutdown /s /f /t 0
