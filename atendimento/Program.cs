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

            Console.WriteLine("Bem-vindo ao cadastro de paciente\n");
            Console.WriteLine("1 - Cadastro\n2 - Lista\n3 - Atender\n4 - Alterar\nQ - Sair");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Cadastro();
                    break;

                case "2":
                    Lista();
                    break;
            }
        }
        static void Cadastro()
        {
            Console.WriteLine("\nÁrea de Cadastro\n");
        }
        static void Lista()
        {
            Console.WriteLine("\nLista de pacientes\n");
        }
    }
}
