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
    public partial class Osoba : Form
    {
        int index = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            SqlConnection conn = Konekcija.Konektuj();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Osoba", conn);
            tabela = new DataTable();
            da.Fill(tabela);
        }
        private void PrikaziPodatke()
        {
            if (tabela.Rows.Count == 0)
            {
                ;
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
                btn_del.Enabled = false;
                return;
            }
            else
            {
                DataRow row = tabela.Rows[index];
                txt_id.Text = row["ID"].ToString();
                txt_ime.Text = row["Ime"].ToString();
                txt_prezime.Text = row["Prezime"].ToString();
                txt_adresa.Text = row["Adresa"].ToString();
                txt_jmbg.Text = row["JMBG"].ToString();
                txt_email.Text = row["Email"].ToString();
                txt_pass.Text = row["Pass"].ToString();
                txt_uloga.Text = row["Uloga"].ToString();
                btn_del.Enabled = true;
            }
            if (index == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }
            if (index == tabela.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            LoadData();
            PrikaziPodatke();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            index = 0;
            PrikaziPodatke();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            index--;
            PrikaziPodatke();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            index++;
            PrikaziPodatke();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            index = tabela.Rows.Count - 1;
            PrikaziPodatke();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO OSOBA (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES ('");
            Naredba.Append(txt_ime.Text + "', '");
            Naredba.Append(txt_prezime.Text + "', '");
            Naredba.Append(txt_adresa.Text + "', '");
            Naredba.Append(txt_jmbg.Text + "', '");
            Naredba.Append(txt_email.Text + "', '");
            Naredba.Append(txt_pass.Text + "', '");
            Naredba.Append(txt_uloga.Text + "')");
            SqlConnection veza = Konekcija.Konektuj();
            SqlCommand cmd = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                cmd.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            LoadData();
            index = tabela.Rows.Count - 1;
            PrikaziPodatke();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE OSOBA SET ");
            Naredba.Append("ime='" + txt_ime.Text + "', ");
            Naredba.Append("prezime='" + txt_prezime.Text + "', ");
            Naredba.Append("adresa='" + txt_adresa.Text + "', ");
            Naredba.Append("jmbg='" + txt_jmbg.Text + "', ");
            Naredba.Append("email='" + txt_email.Text + "', ");
            Naredba.Append("pass='" + txt_pass.Text + "', ");
            Naredba.Append("uloga='" + txt_uloga.Text + "' ");
            Naredba.Append("WHERE ID=" + txt_id.Text);
            SqlConnection veza = Konekcija.Konektuj();
            SqlCommand cmd = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                cmd.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            LoadData();
            PrikaziPodatke();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("DELETE FROM OSOBA WHERE ID=" + txt_id.Text);
            SqlConnection veza = Konekcija.Konektuj();
            SqlCommand cmd = new SqlCommand(Naredba.ToString(), veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                cmd.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisano)
            {
                LoadData();
                if (index > 0) index--;
                PrikaziPodatke();
            }
            if (index >= tabela.Rows.Count)
            {
                index = tabela.Rows.Count - 1;
            }
            PrikaziPodatke();
        }
    }
}
