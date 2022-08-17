using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Herança_Gráfico
{
    public class Estudante : Pessoa 
    {
        private string curso;
        public Estudante()
        {
            this.curso = null;
        }
        public Estudante(string nome, int idade, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
        }

        public string Curso { get; set; }
        
    }
}
