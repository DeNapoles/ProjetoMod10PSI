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

namespace LojaMod10
{
    public partial class FormPagamento : Form
    {
        private FormCarrinho formCarrinho;
        public string UsuarioLogado { get; set; }
        public FormPagamento()
        {
            InitializeComponent();
        }
        public FormPagamento(FormCarrinho carrinho)
        {
            InitializeComponent();
            this.formCarrinho = carrinho;
        }
        private void FormPagamento_Load(object sender, EventArgs e)
        {

        }
        public void ExibirProdutosNaListBox(List<string> produtos)
        {
            foreach (var produto in produtos)
            {
                listBoxprodutos.Items.Add(produto);
            }
        }
        private void checkBoxMetodoPagamento_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnpagar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
            {
                // Habilita o botão de pagamento se pelo menos uma CheckBox estiver marcada
                MessageBox.Show("Pagamento realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um método de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
                {
                    if (checkBox1.Checked)
                    {
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                    }
                }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                checkBox5.Checked = false;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
