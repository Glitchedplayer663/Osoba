namespace Osoba
{
    partial class Meni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jednaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBezFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izveštajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jednaToolStripMenuItem,
            this.jedanSaToolStripMenuItem,
            this.tabelaBezFKToolStripMenuItem,
            this.tabelaSaFKToolStripMenuItem,
            this.izveštajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jednaToolStripMenuItem
            // 
            this.jednaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem});
            this.jednaToolStripMenuItem.Name = "jednaToolStripMenuItem";
            this.jednaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.jednaToolStripMenuItem.Text = "Jedan bez FK";
            this.jednaToolStripMenuItem.Click += new System.EventHandler(this.jednaToolStripMenuItem_Click);
            // 
            // jedanSaToolStripMenuItem
            // 
            this.jedanSaToolStripMenuItem.Name = "jedanSaToolStripMenuItem";
            this.jedanSaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.jedanSaToolStripMenuItem.Text = "Jedan sa FK";
            // 
            // tabelaBezFKToolStripMenuItem
            // 
            this.tabelaBezFKToolStripMenuItem.Name = "tabelaBezFKToolStripMenuItem";
            this.tabelaBezFKToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tabelaBezFKToolStripMenuItem.Text = "Tabela bez FK";
            // 
            // tabelaSaFKToolStripMenuItem
            // 
            this.tabelaSaFKToolStripMenuItem.Name = "tabelaSaFKToolStripMenuItem";
            this.tabelaSaFKToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tabelaSaFKToolStripMenuItem.Text = "Tabela sa FK";
            // 
            // izveštajToolStripMenuItem
            // 
            this.izveštajToolStripMenuItem.Name = "izveštajToolStripMenuItem";
            this.izveštajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izveštajToolStripMenuItem.Text = "Izveštaji";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem.Text = "Osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Meni";
            this.Text = "Meni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jednaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBezFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveštajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
    }
}