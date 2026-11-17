Padrão de Projeto State (Estado)

Sobre o projeto

Este projeto tem como objetivo estudar e praticar o padrão de projeto State, utilizando C# e Programação Orientada a Objetos (POO).

O exemplo desenvolvido simula um sistema de gerenciamento de chamados de suporte técnico, no qual o comportamento de um chamado muda
conforme seu estado atual.

O que é o padrão State?

O State é um padrão de projeto comportamental que permite que um objeto altere seu comportamento dependendo do seu estado interno.

Em vez de concentrar várias condições (if, else ou switch) em uma única classe, cada estado é representado por uma classe própria.

Exemplo utilizado

O sistema simula o ciclo de vida de um chamado de suporte técnico.

Estados do chamado

Aberto: chamado registrado pelo cliente.

Em Atendimento: técnico iniciou a análise do problema.

Aguardando Cliente: técnico precisa de informações adicionais.

Resolvido: problema solucionado.

Fechado: atendimento encerrado.

Estrutura do projeto

State/
│
├── Interfaces/
│   └── IChamadoState.cs
│
├── Estados/
│   ├── ChamadoAberto.cs
│   ├── ChamadoEmAtendimento.cs
│   ├── ChamadoAguardandoCliente.cs
│   ├── ChamadoResolvido.cs
│   └── ChamadoFechado.cs
│
├── Models/
│   └── Chamado.cs
│
└── Program.cs

Conceitos praticados

Programação Orientada a Objetos (POO).

Interfaces.

Encapsulamento.

Composição.

Polimorfismo.

Padrão de projeto State.

Separação de responsabilidades.

Tecnologias utilizadas

C#

.NET

Visual Studio