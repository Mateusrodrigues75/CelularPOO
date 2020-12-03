using System;
using CelularPOO.classes;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular asus = new Celular();
            Console.WriteLine("Digite o modelo do Celular: ");
            asus.modelo = Console.ReadLine();
            
            Console.WriteLine("Digite a cor do Celular: ");
            asus.cor = Console.ReadLine();
            
            Console.WriteLine("Digite o tamanho do display do Celular: ");
            asus.tamanho = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Deseja ligar o dispositivo ? s/n");//exibição da mensagem
            string resposta = Console.ReadLine();

            if(resposta == "s")
            {
                asus.ligado = true;
                Console.WriteLine(asus.Ligar());
                Console.Clear();

                int opcao = 0;
                 
                do
                {   
                    Console.WriteLine("---Menu---");
                    Console.WriteLine("Selecione uma opção ");
                    Console.WriteLine("[1] - Realizar uma ligação");
                    Console.WriteLine("[2] - Enviar mensagem de texto");
                    Console.WriteLine("[3] - Desligar o dispositivo");
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite o número: ");
                            string numeroLigacao = Console.ReadLine();
                            Console.WriteLine(asus.Ligacao());
                        break;

                        case 2:
                            Console.Write("Digite o número: ");
                            numeroLigacao = Console.ReadLine();
                            Console.Write("Digite a mensagem: ");
                            string mensagem = Console.ReadLine();
                            Console.WriteLine(asus.EnviarMensagem());
                        break;

                        case 3:
                            Console.WriteLine(asus.Desligar());
                        break;

                        default:
                            Console.WriteLine("Opção Inválida");
                        break;
                    }

                } while (opcao != 3);

            }else
            { 
                Console.WriteLine("Tchau :)");
            }
        }
    }
}
