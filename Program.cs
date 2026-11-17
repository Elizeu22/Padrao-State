

using Exercicio_PadraoState;


Chamados chamados = new Chamados();

chamados.ChamadoProcessar();

chamados.AlterarStatusChamado(new EmAtendimento());

chamados.ChamadoProcessar();

chamados.AlterarStatusChamado(new AguardandoCliente());

chamados.ChamadoProcessar();


chamados.AlterarStatusChamado(new AtendendoCliente());

chamados.ChamadoProcessar();


chamados.AlterarStatusChamado(new Resolvido());

chamados.ChamadoProcessar();

chamados.AlterarStatusChamado(new Finalizado());






