using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje_Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccessDB adb = new AccessDB();
        
        void List()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Tbl_Kitaplar",adb.connection());
            da.Fill(dt);
            dtBooks.DataSource = dt;
            adb.connection().Close();
        }

        void Clear()
        {
            txtAuthorName.Text = "";
            txtBookID.Text = "";
            txtBookName.Text = "";
            txtBookPage.Text = "";
            cmbBookType.Text = "";
            rdNew.Checked = false;
            rdOld.Checked = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("Insert into Tbl_Kitaplar (KitapAdi, KitapYazar, KitapTur, KitapSayfa, Durum) values (@p1, @p2, @p3, @p4, @p5)",adb.connection());
            command.Parameters.AddWithValue("@p1", txtBookName.Text);
            command.Parameters.AddWithValue("@p1", txtAuthorName.Text);
            command.Parameters.AddWithValue("@p1", cmbBookType.Text);
            command.Parameters.AddWithValue("@p1", txtBookPage.Text);
            command.Parameters.AddWithValue("@p1", lblDurum.Text);
            command.ExecuteNonQuery();
            adb.connection().Close();
            MessageBox.Show("Kitap eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clear();
            List();
        }

        private void rdNew_CheckedChanged(object sender, EventArgs e)
        {
            lblDurum.Text = "1";
        }

        private void rdOld_CheckedChanged(object sender, EventArgs e)
        {
            lblDurum.Text = "0";
        }

        private void dtBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dtBooks.SelectedCells[0].RowIndex;
            txtBookID.Text = dtBooks.Rows[chosen].Cells[0].Value.ToString();
            txtBookName.Text = dtBooks.Rows[chosen].Cells[1].Value.ToString();
            txtAuthorName.Text = dtBooks.Rows[chosen].Cells[2].Value.ToString();
            cmbBookType.Text = dtBooks.Rows[chosen].Cells[3].Value.ToString();
            txtBookPage.Text = dtBooks.Rows[chosen].Cells[4].Value.ToString();

            if (dtBooks.Rows[chosen].Cells[5].Value.ToString()=="True")
            {
                rdNew.Checked = true;
            }
            else
            {
                rdOld.Checked = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("Delete from Tbl_Kitaplar where KitapID = @p1",adb.connection());
            command.Parameters.AddWithValue("@p1",txtBookID.Text);
            command.ExecuteNonQuery();
            adb.connection().Close();
            MessageBox.Show("Kitap silindi.");
            List();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("Update Tbl_Kitaplar set KitapAdi = @p1, KitapYazar = @p2, KitapTur = @p3, KitapSayfa = @p4, Durum = @p5 where KitapID = @p6",adb.connection());
            command.Parameters.AddWithValue("@p1", txtBookName.Text);
            command.Parameters.AddWithValue("@p2", txtAuthorName.Text);
            command.Parameters.AddWithValue("@p3", cmbBookType.Text);
            command.Parameters.AddWithValue("@p4", txtBookPage.Text);
            command.Parameters.AddWithValue("@p5", lblDurum.Text);
            command.Parameters.AddWithValue("@p6", txtBookID.Text);
            command.ExecuteNonQuery();
            adb.connection().Close();
            MessageBox.Show("Kitap güncellendi.");
            List();
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("Select * from Tbl_Kitaplar where KitapAdi like '%"+ txtSearch.Text +"%'",adb.connection());
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dtBooks.DataSource = dt;
        }
    }
}
