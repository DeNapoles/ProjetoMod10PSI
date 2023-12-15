using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaMod10
{
    public partial class FormLogin : Form
    {
        public string NomeUtilizador { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Verificar as credenciais (usando valores fixos para este exemplo)
            string user = tbuser.Text;
            string pass = tbpass.Text;
            string nome = tbnome.Text;

            if (user == "Admin" && pass == "dor" && nome == "Paulo Barreira")
            {
                NomeUtilizador = "PauloBarreira"; // Substitua por seu método de obter o nome do usuário
                DialogResult = DialogResult.OK; // Indica que o login foi bem-sucedido
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciais incorretas. Tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
