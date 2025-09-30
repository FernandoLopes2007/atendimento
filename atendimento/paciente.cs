using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atendimento
{
    internal class paciente
    {
        public string Nome;
        public int Prioridade; //0 - Baixo, 1 - Médio 2 - Alto
        public int CdPaciente;

        public void CadastrarPaciente()
        {
            Console.WriteLine("Digite o nome do paciente");
            Nome = Console.ReadLine();
            do
            {
                Console.WriteLine("Digite o nível de prioridade do paciente");
                Console.WriteLine("0 - Baixo\n1 - Médio\n2 - Alto");
                Prioridade = int.Parse(Console.ReadLine());
                if (Prioridade > 3) 
                {
                    Console.WriteLine("\nDigite um valor valido\n");
                }
            } while (Prioridade > 3);
        }
        public void ListarDados()
        {
            Console.WriteLine("Nível de Prioridade: {1}, {0} ",Prioridade, Nome);
        }
    }
}
