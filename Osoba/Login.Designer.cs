namespace Osoba
{
    partial class Login
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_opis = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(308, 142);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(308, 184);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(169, 20);
            this.txt_password.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(263, 145);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "E-Mail:";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(255, 191);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(47, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Lozinka:";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_opis
            // 
            this.lbl_opis.AutoSize = true;
            this.lbl_opis.Location = new System.Drawing.Point(255, 87);
            this.lbl_opis.Name = "lbl_opis";
            this.lbl_opis.Size = new System.Drawing.Size(222, 13);
            this.lbl_opis.TabIndex = 4;
            this.lbl_opis.Text = "Da bi se ulogovali unesite Vaš E-Mail i lozinku";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(344, 299);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(84, 22);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_opis);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_opis;
        private System.Windows.Forms.Button btn_login;
    }
}