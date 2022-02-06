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

namespace ResimEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B83TJ29;Initial Catalog=FilmArsiv;Integrated Security=True");
        private void btnArana_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ResimBox.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_filmler (FilmAd,FilmTur,FilmPuan,FilmKategori,FilmResim) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1",txtFilmAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtFilmTürü.Text);
            komut.Parameters.AddWithValue("@p3", float.Parse(txtFilmPuan.Text));
            komut.Parameters.AddWithValue("@p4", txtFilmKategori.Text);
            komut.Parameters.AddWithValue("@p5", txtResim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmArsivDataSet.Tbl_Filmler' table. You can move, or remove it, as needed.
            this.tbl_FilmlerTableAdapter.Fill(this.filmArsivDataSet.Tbl_Filmler);

        }

        private void dgwGöster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen  = dgwGöster.SelectedCells[0].RowIndex;
            txtFilmId.Text = dgwGöster.Rows[secilen].Cells[0].Value.ToString();
            txtFilmAdı.Text = dgwGöster.Rows[secilen].Cells[1].Value.ToString();
            txtFilmTürü.Text = dgwGöster.Rows[secilen].Cells[2].Value.ToString();
            txtFilmPuan.Text = dgwGöster.Rows[secilen].Cells[3].Value.ToString();
            txtFilmKategori.Text = dgwGöster.Rows[secilen].Cells[4].Value.ToString();
            txtResim.Text = dgwGöster.Rows[secilen].Cells[5].Value.ToString();
            ResimBox.ImageLocation = dgwGöster.Rows[secilen].Cells[5].Value.ToString();


        }
    }
}
