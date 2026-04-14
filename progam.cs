using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MeuBedrockLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Meu Bedrock Launcher";
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            string arq = Environment.Is64BitOperatingSystem ? "64-bits" : "32-bits";
            Console.WriteLine($"Detectado sistema de {arq}...");
            Console.WriteLine("Iniciando Minecraft Bedrock Edition...");

            try
            {
                // Comando para abrir o App do Minecraft Bedrock (UWP)
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = "shell:AppsFolder\\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App",
                    UseShellExecute = true
                };

                Process.Start(psi);
                Console.WriteLine("Sucesso! O jogo está abrindo.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao abrir o jogo: " + ex.Message);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
