using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Herança_Gráfico
{
    public class Prof : Pessoa
    {
        private string titulacao;

        public Prof()
        {
            this.titulacao = null;
        }
        public Prof(string nome, int idade, string titulacao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Titulacao = titulacao;

        }
        public string Titulacao
        {
            get { return this.Titulacao; }  
            set { this.Titulacao = value; }
        }
        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, "", this.Idade.ToString(), "", this.Titulacao);
            return s;
                
        }
    }
}
