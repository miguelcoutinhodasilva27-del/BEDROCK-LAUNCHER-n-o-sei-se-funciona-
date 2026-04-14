using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MinecraftLauncher
{
    class Program
    {
        static void Main()
        {
            Console.Title = "LAUNCHER COMPATÍVEL 32/64 BITS";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================");
            Console.WriteLine("   MINECRAFT LAUNCHER (JAVA & BEDROCK)   ");
            Console.WriteLine("=========================================");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[1] ABRIR BEDROCK EDITION");
            Console.WriteLine("[2] ABRIR JAVA EDITION");
            Console.WriteLine("[3] SAIR");
            
            Console.Write("\nOPÇÃO: ");
            string op = Console.ReadLine();

            try {
                if (op == "1") {
                    Process.Start(new ProcessStartInfo { 
                        FileName = "explorer.exe", 
                        Arguments = "shell:AppsFolder\\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App", 
                        UseShellExecute = true 
                    });
                } else if (op == "2") {
                    Process.Start(new ProcessStartInfo { 
                        FileName = "minecraftlauncher.exe", 
                        UseShellExecute = true 
                    });
                }
            } catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[!] Erro: Jogo não encontrado no sistema.");
                Console.ReadKey();
            }
        }
    }
}
