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
        BindingSource source;

        public Hauptfenster()
        {
            InitializeComponent();
            new Datenbank();
            ds = new DataSet();
            source = new BindingSource();
            da = new MySqlDataAdapter("select * from marke", Datenbank.connection);
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            da.Fill(ds);
            source.DataSource = ds.Tables[0];
            dataGridView1.DataSource = source;

            dataGridView1.Columns["id"].Visible = false;

            // Removes the "x" image from new row
            dataGridView1.Columns["bild"].DefaultCellStyle.NullValue = null;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[dataGridView1.Columns["bild"].Index].Value = new Bitmap(1, 1);
        }
          
        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.EndEdit();
            dataGridView1.CurrentCell = null;
            updateDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                return;
            }

            update();

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            if (row.Index + 1 >= dataGridView1.Rows.Count)
            {
                return;
            }

            DataRowView drv = row.DataBoundItem as DataRowView;

            int id = Convert.ToInt32(drv.Row["id"]);
            string marke = drv.Row["marke"].ToString();
            byte[] bild = drv.Row["bild"] as byte[];

            Image img = null;
            if (bild != null)
            {
                img = Image.FromStream(new MemoryStream(bild));
            }

            Cardisplayer cardisplayer = new Cardisplayer(id, marke, img);
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

        private void update()
        {
            updateDatabase();
            updateDataSet();
        }

        private void updateDatabase()
        {
            MySqlCommandBuilder com = new MySqlCommandBuilder(da);
            da.Update(ds);
        }
        
        private void updateDataSet()
        {
            int index = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                index = dataGridView1.SelectedRows[0].Index;
            }

            ds.Tables[0].Clear();
            da.Fill(ds);
            
            if (index < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[index].Selected = true;
            }
        }
    }
}
