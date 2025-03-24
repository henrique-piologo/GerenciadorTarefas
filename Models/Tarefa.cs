using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorTarefas.Models
{
    public class Tarefa
    {
        private string Nome {get; set;}
        private string Descricao {get; set;}
        private bool Concluida {get; set;}

        public Tarefa(string nome, string descricao) {
            Nome = nome;
            Descricao = descricao;
            Concluida = false;
        }

        public override string ToString()
        {
            
            return $"{Nome} - {Descricao}";
        }

    }
}