using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisu_sistema.DAL
{
    public class AlunoDAO
    {
        string endereçoArquivo;
        private Stream enderecoArquivo;

        public AlunoDAO()
        {
            endereçoArquivo = "Aluno.txt";
        }

        public void Inserir(aluno Aluno)
        {

        }
        public List<Aluno> getTodosAlunos()
        {
            List<Aluno> novaLista = new List<Aluno>();
            StreamReader sr = new StreamReader(enderecoArquivo);
            string linha = sr.ReadLine();
            while (linha != null)
            {
                Aluno novoAluno = new Aluno();
                string[] dados = linha.Split("|");
                novoAluno.Nome = dados[0];
                novoAluno.Idade = Convert.ToInt32(dados[1]);

                novaLista.Add(novoAluno);
                linha = sr.ReadLine();
            }
            sr.Close();
            return novaLista;



    }   }

    internal class Aluno
    {
    }
}
