using LojaMod10;
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
    public partial class FormCarrinho : Form
    {
        public FormCarrinho()
        {
            InitializeComponent();
        }
        private void FormCarrinho_Load(object sender, EventArgs e)
        {

        }
        public void AdicionarProdutoAoCarrinho(string produto)
        {
            listboxcarrinho.Items.Add(produto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listboxcarrinho.SelectedIndex != -1)
            {
                listboxcarrinho.Items.RemoveAt(listboxcarrinho.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPagamento formPagamento = new FormPagamento();

            // Obtém a lista de produtos do carrinho
            List<string> produtos = new List<string>();
            foreach (var item in listboxcarrinho.Items)
            {
                produtos.Add(item.ToString());
            }

            // Chama o método ExibirProdutosNaListBox do FormPagamento
            formPagamento.ExibirProdutosNaListBox(produtos);

            formPagamento.ShowDialog();//se escreve-se só Show eu podia minimizar o pagamento e continuar a usar o programa,
                                       //assim não, tenho que pagar e depois voltar ao programa
        }

    }
}