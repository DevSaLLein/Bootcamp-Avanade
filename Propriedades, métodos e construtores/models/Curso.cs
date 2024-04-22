using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Propriedades_métodos_e_construtores.models;

namespace Propriedades__métodos_e_construtores.models
{ 
    public class Curso(string NomeDoCurso)
    {
        public string? NomeDoCurso { get; set; } = NomeDoCurso;
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public string AdicionarAluno(Pessoa pessoa)
        {
            Alunos.Add(pessoa);
            return $"O aluno {pessoa.Nome} foi adicionado com sucesso.";
        }

        public string RemoverAluno(Pessoa pessoa)
        {
            Alunos.Remove(pessoa);
            return $"O aluno {pessoa.Nome} foi removido com sucesso.";
        }

        public void listarAlunos() 
        {
            Console.WriteLine($"Lista de Alunos do curso {NomeDoCurso}");
            Alunos.ForEach(aluno => Console.WriteLine($"{aluno.NomeCompleto}"));
        }

        public int QuantidadeDeAlunos() 
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }
    }
}