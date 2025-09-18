using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atendimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 15;
            paciente[] paciente = new paciente[tamanho];
            string escolha;

            Console.Clear();
            Console.WriteLine("Bem-vindo ao cadastro de paciente\n");
            Console.WriteLine("1 - Cadastro\n2 - Lista\n3 - Atender\n4 - Alterar\nQ - Sair\n");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    TelaCadastro();
                    break;

                case "2":
                    TelaLista();
                    break;

                case "3":
                    TelaAtender();
                    break;

                case "4":
                    TelaAlterar();
                    break;
                case "Q":
                    Sair();
                    break;
                default:
                    
                    break;

            }
        }
        static void TelaCadastro()
        {
            Console.WriteLine("\nÁrea de Cadastro\n");
        }
        static void TelaLista()
        {
            Console.WriteLine("\nLista de Pacientes\n");
        }
        static void TelaAtender()
        {
            Console.WriteLine("\nLista de Antendimento\n");
        }
        static void TelaAlterar()
        {
            Console.WriteLine("\nAlteração de Dados\n");
        }
        static void Sair()
        {
            
        }
    }
}
