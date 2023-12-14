namespace LojaMod10
{
    partial class FormLogin
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbltitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitulo.Location = new System.Drawing.Point(264, 103);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(82, 31);
            this.lbltitulo.TabIndex = 24;
            this.lbltitulo.Text = "Login";
            // 
            // tbpass
            // 
            this.tbpass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(285, 257);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(176, 21);
            this.tbpass.TabIndex = 23;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(285, 239);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(46, 16);
            this.lblpass.TabIndex = 20;
            this.lblpass.Text = "Senha";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(285, 294);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(176, 26);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(253, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 253);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbnome
            // 
            this.tbnome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnome.Location = new System.Drawing.Point(285, 165);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(176, 21);
            this.tbnome.TabIndex = 26;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(282, 146);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(44, 16);
            this.lblnome.TabIndex = 25;
            this.lblnome.Text = "Nome";
            // 
            // tbuser
            // 
            this.tbuser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(285, 211);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(176, 21);
            this.tbuser.TabIndex = 22;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(285, 193);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(63, 16);
            this.lbluser.TabIndex = 19;
            this.lbluser.Text = "Utilizador";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.listView1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label lbluser;
    }
}