using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_PadraoState
{
    public class Chamados
    {
        private ISuporteTecnico _suporteTecnico;

        public Chamados()
        {
            _suporteTecnico = new EmAberto();

        }

        public void AlterarStatusChamado(ISuporteTecnico suporteTecnico)
        {
            _suporteTecnico = suporteTecnico;

        }


        public void ChamadoProcessar()
        {
            _suporteTecnico.Chamados();
        }
    }
}
