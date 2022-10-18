using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva_DesafioDeProjeto
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string sobrenome, string nome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}
