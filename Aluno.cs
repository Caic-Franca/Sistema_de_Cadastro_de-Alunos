using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lista
{
    internal class Aluno
    {
        public string Nome;
        public string Matricula;
        public Curso Curso;
        public string Email;
       
        public Aluno(string nome, string matricula, Curso curso, string email)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
            Email = email;
           
        }

    }
}