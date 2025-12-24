using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Osoba
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Unesite E-Mail i lozinku");
            }
            else
            {
                try
                {
                    SqlConnection conn = Konekcija.Konektuj();
                    string query = "SELECT * FROM Osoba WHERE email=@username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                       if (String.Compare(tabela.Rows[0]["pass"].ToString(), txt_password.Text)==0)
                        {
                            MessageBox.Show("Uspešno logovanje");
                            this.Hide();
                            Meni frm_meni = new Meni();
                            frm_meni.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeći E'Mail");
                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show("Greska prilikom prijave: " + greska.Message);
                }
            }
        }
    }
}
