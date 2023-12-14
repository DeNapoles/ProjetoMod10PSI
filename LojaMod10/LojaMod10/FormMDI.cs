using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LojaMod10
{
    public partial class FormMDI : Form
    {
        private string nomeUsuario;

        public FormMDI()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();

            lbllogin.Click += (sender, e) => ExibirFormLogin();
        }
        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Atualize a label com o tempo atual no formato hh:mm
            lbltime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void GerenciarCliqueLabel()                                                //GerenciarCliqueLabel
        {
            if (string.IsNullOrEmpty(nomeUsuario))
            {
                // Se não houver usuário logado, exiba o FormLogin
                ExibirFormLogin();
            }
            else
            {
                // Se já estiver logado, pergunte se deseja encerrar a sessão
                DialogResult resultado = MessageBox.Show("Deseja encerrar a sessão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    nomeUsuario = null; // Limpe as credenciais
                    AtualizarLabellogin2();
                }
            }
        }
        private void ExibirFormLogin()                                               //ExibirFormLogin
        {
            using (FormLogin formLogin = new FormLogin())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    // Se o login for bem-sucedido, armazene o nome do usuário
                    nomeUsuario = formLogin.NomeUsuario;
                    AtualizarLabels();
                }
            }
        }
        private void AtualizarLabellogin2()                                              //AtualizarLabelUsuario
        {
            // Atualize a Label com o nome do usuário ou o texto de login, dependendo do estado
            lbllogin.Text = string.IsNullOrEmpty(nomeUsuario) ? "Clique para fazer login" : "Olá, " + "Paulo Barreira";

            // Associe novamente o evento de clique da label
            lbllogin.Click -= (sender, e) => GerenciarCliqueLabel();
            lbllogin.Click += (sender, e) => GerenciarCliqueLabel();
        }
        private void AtualizarLabels()
        {
            // Atualize as labels com o nome do usuário ou o texto de login, dependendo do estado
            lbllogin.Visible = string.IsNullOrEmpty(nomeUsuario);
            lbllogin2.Visible = !string.IsNullOrEmpty(nomeUsuario);
            lbllogin2.Text = string.IsNullOrEmpty(nomeUsuario) ? "" : "Olá, " + "Paulo Barreira";

            menuStrip1.Enabled = !string.IsNullOrEmpty(nomeUsuario);
            toolStrip1.Enabled = !string.IsNullOrEmpty(nomeUsuario);
        }
        private void lbllogin_Click(object sender, EventArgs e)
        {
                // Se não houver usuário logado, exiba o FormLogin
                ExibirFormLogin();

        }
        private void lbllogin2_Click(object sender, EventArgs e)
        {
            // Se clicar na label de usuário, pergunte se deseja encerrar a sessão
            DialogResult resultado = MessageBox.Show("Deseja encerrar a sessão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                nomeUsuario = null; // Limpe as credenciais
                AtualizarLabels();
            }
        }


        //FICHEIRO
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //PRODUTO
        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Formlista form1 = new Formlista();
                form1.MdiParent = this; // Define o formulário principal MDI como pai do FormLista
                form1.Show();

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarrinho form1 = new FormCarrinho();
            form1.MdiParent = this;//Define o formulário principal MDI como pai do Form1
            form1.Location = new Point(this.Right + 10, this.Top);
            form1.Show();
        }

        //VENDAS
        private void registarToolStripMenuItem_Click(object sender, EventArgs e)//consultar
        {

        }

        private void vendasMensaisToolStripMenuItem_Click(object sender, EventArgs e)//vendas mensais
        {

        }

        //REPARAÇÕES
        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)//registo de avarias
        {
            FormAvarias form1 = new FormAvarias();

            form1.MdiParent = this;// Define o formulário principal MDI como pai do Form1
            form1.Show();
        }

        private void consultaGeralToolStripMenuItem_Click(object sender, EventArgs e)//agendar reparação
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Formlista form1 = new Formlista();

            form1.MdiParent = this;// Define o formulário principal MDI como pai do Form1
            form1.Show();
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
