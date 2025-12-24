namespace Osoba
{
    partial class Osoba
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_alter = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_adersa = new System.Windows.Forms.Label();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(31, 534);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(134, 534);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(235, 534);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(441, 534);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_alter
            // 
            this.btn_alter.Location = new System.Drawing.Point(338, 534);
            this.btn_alter.Name = "btn_alter";
            this.btn_alter.Size = new System.Drawing.Size(75, 23);
            this.btn_alter.TabIndex = 4;
            this.btn_alter.Text = "ALTER";
            this.btn_alter.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(646, 534);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 6;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(543, 534);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(309, 53);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(224, 20);
            this.txt_id.TabIndex = 8;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(309, 79);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(224, 20);
            this.txt_ime.TabIndex = 9;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(309, 105);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(224, 20);
            this.txt_prezime.TabIndex = 10;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(309, 131);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(224, 20);
            this.txt_adresa.TabIndex = 11;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Location = new System.Drawing.Point(309, 235);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(224, 20);
            this.txt_uloga.TabIndex = 12;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Location = new System.Drawing.Point(309, 157);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(224, 20);
            this.txt_jmbg.TabIndex = 13;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(309, 209);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(224, 20);
            this.txt_pass.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(309, 183);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(224, 20);
            this.txt_email.TabIndex = 15;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(257, 60);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(257, 86);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(24, 13);
            this.lbl_ime.TabIndex = 17;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(257, 112);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(44, 13);
            this.lbl_prezime.TabIndex = 18;
            this.lbl_prezime.Text = "Prezime";
            // 
            // lbl_adersa
            // 
            this.lbl_adersa.AutoSize = true;
            this.lbl_adersa.Location = new System.Drawing.Point(257, 138);
            this.lbl_adersa.Name = "lbl_adersa";
            this.lbl_adersa.Size = new System.Drawing.Size(40, 13);
            this.lbl_adersa.TabIndex = 19;
            this.lbl_adersa.Text = "Adresa";
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Location = new System.Drawing.Point(257, 164);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(36, 13);
            this.lbl_jmbg.TabIndex = 20;
            this.lbl_jmbg.Text = "JMBG";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(257, 190);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 13);
            this.lbl_email.TabIndex = 21;
            this.lbl_email.Text = "E-Mail";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(257, 216);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 22;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Location = new System.Drawing.Point(257, 242);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(35, 13);
            this.lbl_uloga.TabIndex = 23;
            this.lbl_uloga.Text = "Uloga";
            // 
            // Osoba
            // 
            this.ClientSize = new System.Drawing.Size(742, 593);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_jmbg);
            this.Controls.Add(this.lbl_adersa);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_alter);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Osoba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_alter;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_adersa;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_uloga;
    }
}

