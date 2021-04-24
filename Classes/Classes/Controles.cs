using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Controles
    {
        public int vida, idade;
        public string nome, qualidade;


        public void Vida(int vida)
        {
            this.vida = vida;
        }
        public void Idade(int idade)
        {
            this.idade = idade;
        }
        public void Nome(string nome)
        {
            this.nome = nome;
        }
        public void Qualidade(string qualidade)
        {
            this.qualidade = qualidade;
        }
        public void Ataque(int ataque)
        {
            this.vida = this.vida - ataque;
        }
        public void Recuperar(int recupera)
        {
            this.vida = this.vida + recupera;
        }
    }
}
