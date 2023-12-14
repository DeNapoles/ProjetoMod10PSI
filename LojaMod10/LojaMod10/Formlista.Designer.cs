namespace LojaMod10
{
    partial class Formlista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlista));
            this.btnfecharlista = new System.Windows.Forms.Button();
            this.btnnovoprod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnaddproduto = new System.Windows.Forms.Button();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldesig = new System.Windows.Forms.Label();
            this.textBoxdesig = new System.Windows.Forms.TextBox();
            this.labelcatg = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.textBoxpreco = new System.Windows.Forms.TextBox();
            this.comboBoxcatg = new System.Windows.Forms.ComboBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfecharlista
            // 
            this.btnfecharlista.BackColor = System.Drawing.Color.DarkOrange;
            this.btnfecharlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfecharlista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharlista.Location = new System.Drawing.Point(633, 423);
            this.btnfecharlista.Name = "btnfecharlista";
            this.btnfecharlista.Size = new System.Drawing.Size(133, 35);
            this.btnfecharlista.TabIndex = 9;
            this.btnfecharlista.Text = "Guardar e Fechar";
            this.btnfecharlista.UseVisualStyleBackColor = false;
            this.btnfecharlista.Click += new System.EventHandler(this.btnfecharlista_Click);
            // 
            // btnnovoprod
            // 
            this.btnnovoprod.BackColor = System.Drawing.Color.DarkOrange;
            this.btnnovoprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovoprod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovoprod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnnovoprod.Location = new System.Drawing.Point(580, 304);
            this.btnnovoprod.Name = "btnnovoprod";
            this.btnnovoprod.Size = new System.Drawing.Size(186, 35);
            this.btnnovoprod.TabIndex = 7;
            this.btnnovoprod.Text = "Adicionar ao Carrinho";
            this.btnnovoprod.UseVisualStyleBackColor = false;
            this.btnnovoprod.Click += new System.EventHandler(this.btnnovoprod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Produtos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(730, 251);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnaddproduto
            // 
            this.btnaddproduto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnaddproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddproduto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnaddproduto.Location = new System.Drawing.Point(36, 423);
            this.btnaddproduto.Name = "btnaddproduto";
            this.btnaddproduto.Size = new System.Drawing.Size(89, 35);
            this.btnaddproduto.TabIndex = 10;
            this.btnaddproduto.Text = "Novo ";
            this.btnaddproduto.UseVisualStyleBackColor = false;
            this.btnaddproduto.Click += new System.EventHandler(this.btnaddproduto_Click);
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(113, 313);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(115, 20);
            this.textBoxcodigo.TabIndex = 11;
            this.textBoxcodigo.Visible = false;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(61, 316);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 12;
            this.lblcodigo.Text = "Código:";
            this.lblcodigo.Visible = false;
            // 
            // lbldesig
            // 
            this.lbldesig.AutoSize = true;
            this.lbldesig.Location = new System.Drawing.Point(37, 342);
            this.lbldesig.Name = "lbldesig";
            this.lbldesig.Size = new System.Drawing.Size(67, 13);
            this.lbldesig.TabIndex = 14;
            this.lbldesig.Text = "Designação:";
            this.lbldesig.Visible = false;
            // 
            // textBoxdesig
            // 
            this.textBoxdesig.Location = new System.Drawing.Point(113, 339);
            this.textBoxdesig.Name = "textBoxdesig";
            this.textBoxdesig.Size = new System.Drawing.Size(255, 20);
            this.textBoxdesig.TabIndex = 13;
            this.textBoxdesig.Visible = false;
            // 
            // labelcatg
            // 
            this.labelcatg.AutoSize = true;
            this.labelcatg.Location = new System.Drawing.Point(47, 368);
            this.labelcatg.Name = "labelcatg";
            this.labelcatg.Size = new System.Drawing.Size(55, 13);
            this.labelcatg.TabIndex = 16;
            this.labelcatg.Text = "Categoria:";
            this.labelcatg.Visible = false;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(64, 395);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(38, 13);
            this.lblpreco.TabIndex = 18;
            this.lblpreco.Text = "Preço:";
            this.lblpreco.Visible = false;
            // 
            // textBoxpreco
            // 
            this.textBoxpreco.Location = new System.Drawing.Point(113, 392);
            this.textBoxpreco.Name = "textBoxpreco";
            this.textBoxpreco.Size = new System.Drawing.Size(115, 20);
            this.textBoxpreco.TabIndex = 17;
            this.textBoxpreco.Visible = false;
            // 
            // comboBoxcatg
            // 
            this.comboBoxcatg.FormattingEnabled = true;
            this.comboBoxcatg.Location = new System.Drawing.Point(113, 365);
            this.comboBoxcatg.Name = "comboBoxcatg";
            this.comboBoxcatg.Size = new System.Drawing.Size(255, 21);
            this.comboBoxcatg.TabIndex = 19;
            this.comboBoxcatg.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(323, 423);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(89, 35);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(226, 423);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(89, 35);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(131, 423);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(89, 35);
            this.btnatualizar.TabIndex = 22;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            // 
            // Formlista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 489);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.comboBoxcatg);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.textBoxpreco);
            this.Controls.Add(this.labelcatg);
            this.Controls.Add(this.lbldesig);
            this.Controls.Add(this.textBoxdesig);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.btnaddproduto);
            this.Controls.Add(this.btnfecharlista);
            this.Controls.Add(this.btnnovoprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formlista";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Formlista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfecharlista;
        private System.Windows.Forms.Button btnnovoprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnaddproduto;
        private System.Windows.Forms.TextBox textBoxcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldesig;
        private System.Windows.Forms.TextBox textBoxdesig;
        private System.Windows.Forms.Label labelcatg;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox textBoxpreco;
        private System.Windows.Forms.ComboBox comboBoxcatg;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnatualizar;
    }
}