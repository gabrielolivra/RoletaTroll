using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoletaTroll
{
     class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine(" ██▀███      ▒█████      ██▓       ▓█████    ▄▄▄█████▓    ▄▄▄               ▄▄▄█████▓    ██▀███      ▒█████      ██▓        ██▓    \r\n▓██ ▒ ██▒   ▒██▒  ██▒   ▓██▒       ▓█   ▀    ▓  ██▒ ▓▒   ▒████▄             ▓  ██▒ ▓▒   ▓██ ▒ ██▒   ▒██▒  ██▒   ▓██▒       ▓██▒    \r\n▓██ ░▄█ ▒   ▒██░  ██▒   ▒██░       ▒███      ▒ ▓██░ ▒░   ▒██  ▀█▄           ▒ ▓██░ ▒░   ▓██ ░▄█ ▒   ▒██░  ██▒   ▒██░       ▒██░    \r\n▒██▀▀█▄     ▒██   ██░   ▒██░       ▒▓█  ▄    ░ ▓██▓ ░    ░██▄▄▄▄██          ░ ▓██▓ ░    ▒██▀▀█▄     ▒██   ██░   ▒██░       ▒██░    \r\n░██▓ ▒██▒   ░ ████▓▒░   ░██████▒   ░▒████▒     ▒██▒ ░     ▓█   ▓██▒           ▒██▒ ░    ░██▓ ▒██▒   ░ ████▓▒░   ░██████▒   ░██████▒\r\n░ ▒▓ ░▒▓░   ░ ▒░▒░▒░    ░ ▒░▓  ░   ░░ ▒░ ░     ▒ ░░       ▒▒   ▓▒█░           ▒ ░░      ░ ▒▓ ░▒▓░   ░ ▒░▒░▒░    ░ ▒░▓  ░   ░ ▒░▓  ░\r\n  ░▒ ░ ▒░     ░ ▒ ▒░    ░ ░ ▒  ░    ░ ░  ░       ░         ▒   ▒▒ ░             ░         ░▒ ░ ▒░     ░ ▒ ▒░    ░ ░ ▒  ░   ░ ░ ▒  ░\r\n  ░░   ░    ░ ░ ░ ▒       ░ ░         ░        ░           ░   ▒              ░           ░░   ░    ░ ░ ░ ▒       ░ ░        ░ ░   \r\n   ░            ░ ░         ░  ░      ░  ░                     ░  ░                        ░            ░ ░         ░  ░       ░  ░\r\n                                                                                                                                   ");
            Console.WriteLine(" ██▒   █▓    ▄▄▄          ███▄ ▄███▓    ▒█████       ██████           ▄████▄      ▒█████      ███▄ ▄███▓   ▓█████     ▄████▄      ▄▄▄          ██▀███  \r\n▓██░   █▒   ▒████▄       ▓██▒▀█▀ ██▒   ▒██▒  ██▒   ▒██    ▒          ▒██▀ ▀█     ▒██▒  ██▒   ▓██▒▀█▀ ██▒   ▓█   ▀    ▒██▀ ▀█     ▒████▄       ▓██ ▒ ██▒\r\n ▓██  █▒░   ▒██  ▀█▄     ▓██    ▓██░   ▒██░  ██▒   ░ ▓██▄            ▒▓█    ▄    ▒██░  ██▒   ▓██    ▓██░   ▒███      ▒▓█    ▄    ▒██  ▀█▄     ▓██ ░▄█ ▒\r\n  ▒██ █░░   ░██▄▄▄▄██    ▒██    ▒██    ▒██   ██░     ▒   ██▒         ▒▓▓▄ ▄██▒   ▒██   ██░   ▒██    ▒██    ▒▓█  ▄    ▒▓▓▄ ▄██▒   ░██▄▄▄▄██    ▒██▀▀█▄  \r\n   ▒▀█░      ▓█   ▓██▒   ▒██▒   ░██▒   ░ ████▓▒░   ▒██████▒▒         ▒ ▓███▀ ░   ░ ████▓▒░   ▒██▒   ░██▒   ░▒████▒   ▒ ▓███▀ ░    ▓█   ▓██▒   ░██▓ ▒██▒\r\n   ░ ▐░      ▒▒   ▓▒█░   ░ ▒░   ░  ░   ░ ▒░▒░▒░    ▒ ▒▓▒ ▒ ░         ░ ░▒ ▒  ░   ░ ▒░▒░▒░    ░ ▒░   ░  ░   ░░ ▒░ ░   ░ ░▒ ▒  ░    ▒▒   ▓▒█░   ░ ▒▓ ░▒▓░\r\n   ░ ░░       ▒   ▒▒ ░   ░  ░      ░     ░ ▒ ▒░    ░ ░▒  ░ ░           ░  ▒        ░ ▒ ▒░    ░  ░      ░    ░ ░  ░     ░  ▒        ▒   ▒▒ ░     ░▒ ░ ▒░\r\n     ░░       ░   ▒      ░      ░      ░ ░ ░ ▒     ░  ░  ░           ░           ░ ░ ░ ▒     ░      ░         ░      ░             ░   ▒        ░░   ░ \r\n      ░           ░  ░          ░          ░ ░           ░           ░ ░             ░ ░            ░         ░  ░   ░ ░               ░  ░      ░     \r\n     ░                                                               ░                                               ░                                 ");
            Console.WriteLine("\n\nDigite 1 - Para iniciar \n\nDigite 2 - Para sair");
            int resposta = Convert.ToInt32(Console.ReadLine());
            switch (resposta)
            {
                case 1: Sorteio(); break;
                case 2: Environment.Exit(0); break;
                default: Menu();break;
            }

        }

        static void Sorteio()
        {
            Random random = new Random();
            int PremioSelecionado = random.Next(1, 4); 

            Action[] Premios = { Premio1, Premio2, Premio3 };

            if (PremioSelecionado >= 1 && PremioSelecionado <= Premios.Length)
            {
                Action selectedFunction = Premios[PremioSelecionado - 1];
                selectedFunction.Invoke();
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static void Contador()
        {
            int ValorFinal = 4;
            int ValorInicial = 1;
            
            while (ValorFinal != ValorInicial)
            {
                Console.Clear();
                ValorFinal--;
                Console.WriteLine($"Sorteio em: {ValorFinal}");
                Thread.Sleep(1000);
            }
        }
        static void Premio1()
        {
            Contador();
            Console.WriteLine("Você perdeu todos arquivos abertos :)");
            Thread.Sleep(3000);
            try
            {

                string batFilePath = @"C:\Users\Gabriel\source\repos\RoletaTroll\RoletaTroll\itensSorteio\premio.bat";


                if (!System.IO.File.Exists(batFilePath))
                {
                    Console.WriteLine("Arquivo .bat não encontrado.");
                    return;
                }


                ProcessStartInfo processInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + batFilePath,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();


                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();


                    process.WaitForExit();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        static void Premio2()
        {
            Contador();
            Console.WriteLine("Voce ganhou um novo papel de parede :)");
        
            try
            {

                string batFilePath = @"C:\Users\Gabriel\source\repos\RoletaTroll\RoletaTroll\itensSorteio\premio2.bat";


                if (!System.IO.File.Exists(batFilePath))
                {
                    Console.WriteLine("Arquivo .bat não encontrado.");
                    return;
                }


                ProcessStartInfo processInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + batFilePath,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();


                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();


                    process.WaitForExit();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        static void Premio3()
        {
            Contador();
            Console.WriteLine("Seu computador está cansado! Agora ele vai descansar :)");
            Thread.Sleep(3000);
            try
            {

                string batFilePath = @"C:\Users\Gabriel\source\repos\RoletaTroll\RoletaTroll\itensSorteio\premio3.bat";


                if (!System.IO.File.Exists(batFilePath))
                {
                    Console.WriteLine("Arquivo .bat não encontrado.");
                    return;
                }


                ProcessStartInfo processInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + batFilePath,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();


                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();


                    process.WaitForExit();



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }




    }
}
