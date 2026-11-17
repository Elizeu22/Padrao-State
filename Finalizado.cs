using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_PadraoState
{
    public class Finalizado:ISuporteTecnico
    {
        public void Chamados()
        {
            Console.WriteLine("Chamado finalizado ...");
        }
    }
}
