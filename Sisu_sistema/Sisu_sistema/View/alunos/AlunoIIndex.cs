using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Sisu_sistema.View.Aluno
{
    public partial class AlunoIIndex : Form
    {
        private object listaAlunos;
        private object txtIdade;
        private object txtNome;

        public AlunoIIndex()
        {
            InitializeComponent();
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if ((txtNome.Text != "") & (txtIdade.Text != ""))
            {
                listaAlunos.Items.Add(txtNome.Text + " | " + txtIdade.Text);
                txtNom
                if (txtNome.Text != "")
                {
                }
                else
                {
                    MessageBox.Show("Nome é obrigatório.");
                    txtNome.BackColor = Color.Red;
                }
                if (txtIdade.Text == "")
                {
                    MessageBox.Show("Idade é obrigatório.");
                    txtIdade.BackColor = Color.Red;
                }
                if ((txtNome.Text != "") & (txtIdade.Text != ""))
                {
                    listaAlunos.Items.Add(txtNome.Text + " | " + txtIdade.Text);
                    txtNome.BackColor = Color.White;
                    txtIdade.BackColor = Color.White;
                }
            }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");

            foreach (ListViewItem item in listaAlunos.Itens)
            {
                sw.WriteLine(Item.text);
            }
            sw.Close();


            private void button1_Click(objetc sender, EventArgs e)
            {
                //System.IO.FilenotFoundException
                StreamWriter sw = new StreamWriter("aluno.txt");
                sw.Flush();
                sw.Close();
                listaAlunos.Clear();
            }

            private void AlunoIndex_load(object sender, EventArgs e)
            {
                try
                {
                    Stream sr = new StreamReader("aluno.Txt");
                    string linha = sr.Readline();
                    while (linha != null)
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    MessageBox.Show("Erro de leitura de arquivo");
                }
               
            }


        



            
        }

       
        private void SALVAR_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");

            foreach (ListView item in listaAlunos.Itens)
            {
                sw.WriteLine(intem.text);
            }
            {

            }
        }
    }
}
