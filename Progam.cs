using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    static void Main()
    {
        // CONFIGURAÇÃO INICIAL
        Console.Title = "MINECRAFT ULTIMATE LAUNCHER - SEM PIRATARIA";
        
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================================");
            Console.WriteLine("      LAUNCHER OFICIAL: JAVA & BEDROCK           ");
            Console.WriteLine("      COMPATIBILIDADE: 32 BITS / 64 BITS         ");
            Console.WriteLine("==================================================");
            Console.ResetColor();
            
            Console.WriteLine("\n[1] INICIAR MINECRAFT BEDROCK");
            Console.WriteLine("[2] INICIAR MINECRAFT JAVA (LAUNCHER)");
            Console.WriteLine("[3] VERIFICAR ESPECIFICAÇÕES DO PC");
            Console.WriteLine("[4] SAIR");
            
            Console.Write("\nESCOLHA UMA OPÇÃO: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    AbrirJogo("explorer.exe", "shell:AppsFolder\\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App", "Bedrock");
                    break;
                case "2":
                    AbrirJogo("minecraftlauncher.exe", "", "Java");
                    break;
                case "3":
                    MostrarInfo();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    static void AbrirJogo(string comando, string argumentos, string nome)
    {
        try
        {
            Console.WriteLine($"\nIniciando {nome}...");
            Process.Start(new ProcessStartInfo { FileName = comando, Arguments = argumentos, UseShellExecute = true });
            Thread.Sleep(2000);
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[!] Erro: {nome} não encontrado. Certifique-se de que o jogo está instalado oficialmente.");
            Console.ResetColor();
            Thread.Sleep(3000);
        }
    }

    static void MostrarInfo()
    {
        Console.Clear();
        Console.WriteLine("--- INFORMAÇÕES DO SISTEMA ---");
        Console.WriteLine($"Sistema: {RuntimeInformation.OSDescription}");
        Console.WriteLine($"Arquitetura: {RuntimeInformation.OSArchitecture}");
        Console.WriteLine($"Processadores: {Environment.ProcessorCount} núcleos");
        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}
