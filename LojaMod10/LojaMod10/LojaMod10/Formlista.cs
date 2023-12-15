using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LojaMod10.Formlista;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LojaMod10
{
    public partial class Formlista : Form
    {
        private Dictionary<string, double> Prod = new Dictionary<string, double>
        {
            { "Monitor LG 75Hz - 99.90€", 99.90},
            { "Headset HyperX Cloud II 7.1 - 79.90€", 79.90},
            { "Teclado Mecânico Krom Kernel - 39.90€", 39.90},
            { "Pen Drive Kingston DataTraveler - 19.10€", 19.10}
        };
        public class Produtos
        {
            public string Produto;
        }
        public Formlista()
        {
            InitializeComponent();
            listBox1.Items.Add("Monitor LG 75Hz - 99.90€");
            listBox1.Items.Add("Headset HyperX Cloud II 7.1 - 79.90€");
            listBox1.Items.Add("Teclado Mecânico Krom Kernel - 39.90€");
            listBox1.Items.Add("Pen Drive Kingston DataTraveler - 19.10€");
        }

        private void Formlista_Load(object sender, EventArgs e)
        {

        }

        public List<string> ObterListaDeProdutos()
        {
            List<string> listaProdutos = new List<string>();

            foreach (var item in listBox1.Items)
            {
                listaProdutos.Add(item.ToString());
            }

            return listaProdutos;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnnovoprod.Enabled = (listBox1.SelectedIndex != -1);
        }

        private void btnnovoprod_Click(object sender, EventArgs e)
        {
            //Verifica se o FormCarrinho já está aberto
            FormCarrinho formCarrinho = Application.OpenForms.OfType<FormCarrinho>().FirstOrDefault();

            if (formCarrinho == null)
            {
                //Se não estiver aberto, cria uma instância e configura como MDI Child ao lado do Formlista
                formCarrinho = new FormCarrinho();
                formCarrinho.MdiParent = this.MdiParent;
                formCarrinho.Location = new Point(this.Right + 10, this.Top);
                formCarrinho.Show();
            }
            else
            {
                //Se já estiver aberto, traz para a frente
                formCarrinho.BringToFront();
            }
            string produtoSelecionado = listBox1.SelectedItem.ToString();
            formCarrinho.AdicionarProdutoAoCarrinho(produtoSelecionado);
        }

        private void btnfecharlista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncarrinho_Click(object sender, EventArgs e)
        {

        }

        private void btnaddproduto_Click(object sender, EventArgs e)
        {
            lblcodigo.Visible = true;
            textBoxcodigo.Visible = true;
            lbldesig.Visible = true;
            textBoxdesig.Visible = true;
            labelcatg.Visible = true;
            comboBoxcatg.Visible = true;
            lblpreco.Visible = true;
            textBoxpreco.Visible = true;
        }
    }
}
