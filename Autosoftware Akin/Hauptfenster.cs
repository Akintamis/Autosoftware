using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Autosoftware_Akin
{
    public partial class Hauptfenster : Form
    {
        DataSet ds;
        MySqlDataAdapter da;

        public Hauptfenster()
        {
            InitializeComponent();
            new Datenbank();
            ds = new DataSet();
        }

        //private void combobox1_selectedindexchanged(object sender, eventargs e)
        //{
        //    if (autodrop.selecteditem != null)
        //    {
        //        datarowview drv = autodrop.selecteditem as datarowview;
        //        int id = convert.toint16(drv.row["id"]);
        //        string marke = drv.row["marke"].tostring();
        //        string bild = drv.row["bild"].tostring();

        //        debug.writeline("id : " + id.tostring());
        //        debug.writeline("drop selected value: " + autodrop.selectedvalue.tostring());
        //        debug.writeline("marke: " + marke);
        //        debug.writeline("bild: " + bild);

        //        // bitte auswählen selected...
        //        if (id != 0)
        //        {
        //            cardisplayer cardisplayer = new cardisplayer(id, marke, bild);
        //            cardisplayer.show();
        //        }
        //    }
        //}

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            da = new MySqlDataAdapter("select * from marke", Datenbank.connection);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;

            // Removes the "x" image from new row
            dataGridView1.Columns["bild"].DefaultCellStyle.NullValue = null;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[dataGridView1.Columns["bild"].Index].Value = new Bitmap(1, 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySqlCommandBuilder com = new MySqlCommandBuilder(da);
            da.Update(ds);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            if (row.Index + 1 >= dataGridView1.Rows.Count)
            {
                return;
            }

            MySqlCommandBuilder com = new MySqlCommandBuilder(da);
            da.Update(ds);

            DataRowView drv = row.DataBoundItem as DataRowView;
            int id = Convert.ToInt32(drv.Row["id"]);
            string marke = drv.Row["marke"].ToString();
            byte[] bild = drv.Row["bild"] as byte[];

            Cardisplayer cardisplayer = new Cardisplayer(id, marke, Image.FromStream(new MemoryStream(bild)));
            cardisplayer.ShowDialog(this);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }
            Debug.WriteLine("Cell Content Clicked...");
            if (dataGridView1.Columns[e.ColumnIndex].Name == "bild")
            {
                DialogResult result = openFileDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["bild"].Value = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }
    }
}
