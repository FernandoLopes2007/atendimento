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
            paciente[] Paciente = new paciente[15];
            string escolha;
            int aux = 0;


            while (true)
            {
                Console.WriteLine("\nBem-vindo ao cadastro de paciente\n");
                Console.WriteLine("1 - Cadastro\n2 - Lista\n3 - Atender\n4 - Alterar\nQ - Sair\n");
                escolha = Console.ReadLine();

                switch (escolha)
                {

                    case "1":
                        if (aux < 15)
                        {
                            Console.WriteLine("\nÁrea de Cadastro\n");
                            {
                                paciente novoPaciente = new paciente();
                                novoPaciente.CadastrarPaciente();
                                novoPaciente.CdPaciente = aux + 1;
                                if (novoPaciente.Prioridade == 2)
                                {
                                    for (int i = aux; i > 0; i--)
                                    {
                                        Paciente[i] = Paciente[i - 1];
                                    }
                                    Paciente[0] = novoPaciente;
                                }
                                else
                                {
                                    Paciente[aux] = novoPaciente;
                                }
                                aux++;
                                Console.WriteLine("\nPaciente Cadastrado\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nFila cheia.\n");
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nLista de Pacientes\n");
                        for (int i = 0; i < aux; i++)
                        {
                            Console.Write(i + 1 + " - " );
                            Paciente[i].ListarDados();
                        }

                        break;

                    case "3":
                        Console.WriteLine("\nAtender Pacientes\n");
                        for(int i = 0; i < aux - 1; i++)
                        {
                            Paciente[i] = Paciente[i + 1];
                           
                        }
                        Paciente[aux - 1] = null; aux--;
                        break;

                    case "4":
                        Console.WriteLine("\nAlterar Dados\n");

                        break;
                    case "q":
                        if (escolha == "q" || escolha == "Q")
                        {
                            Console.WriteLine("\nPrograma encerrado");
                        }
                        return;
                        
                    default:
                            Console.WriteLine("\nOpção Incorreta"); 
                        break;
                }
            }
        }
    }
}
