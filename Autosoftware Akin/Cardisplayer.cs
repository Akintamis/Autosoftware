using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosoftware_Akin
{
    public partial class Cardisplayer : Form
    {
        int id_marke;
        string marke;
        Image bild_marke;
        DataSet dataSet;
        MySqlDataAdapter dataAdapter;

        public Cardisplayer(int id_marke, string marke, Image bild)
        {
            InitializeComponent();
            this.id_marke = id_marke;
            this.marke = marke;
            this.bild_marke = bild;
        }

        private void Cardisplayer_Load(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM autos WHERE id_marke=" + id_marke + ";", Datenbank.connection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.Name != "bild" && col.Name != "name")
                {
                    col.Visible = false;
                }
            }

            //dataGridView2.Columns["id"].Visible = false;
            //dataGridView2.Columns["id_marke"].Visible = false;

            // Removes the "x" image from new row
            dataGridView2.Columns["bild"].DefaultCellStyle.NullValue = null;
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[dataGridView2.Columns["bild"].Index].Value = new Bitmap(1, 1);

            // setze attribut image von picturebox auf korrektes bild
            pictureBox1.Image = bild_marke;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Cardisplayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveAttributesToDataSource();

            MySqlCommandBuilder com = new MySqlCommandBuilder(dataAdapter);
            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                if (dr.RowState != DataRowState.Deleted)
                {
                    dr["id_marke"] = id_marke;
                }
            }

            dataAdapter.Update(dataSet);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            
            if (e.RowIndex >= dataGridView2.Rows.Count)
            {
                return;
            }

            saveAttributesToDataSource();

            dataGridView1.Rows.Clear();

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            byte[] buffer = row.Cells["bild"].Value as byte[];
            if(buffer != null)
            {
                Image img = Image.FromStream(new MemoryStream(buffer));
                pictureBox1.Image = img;
            }
            else
            {
                pictureBox1.Image = bild_marke;
            }

            dataGridView1.Tag = row;

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.Name != "bild" && col.Name != "name" && col.Name != "id" && col.Name != "id_marke")
                {
                    //row.Cells[col.Name].Value
                    var detailRow = new DataGridViewRow();

                    var keyCell = new DataGridViewTextBoxCell();
                    keyCell.Value = col.Name;
                    detailRow.Cells.Add(keyCell);

                    var valueCell = new DataGridViewTextBoxCell();
                    valueCell.Value = row.Cells[col.Name].Value;
                    detailRow.Cells.Add(valueCell);

                    dataGridView1.Rows.Add(detailRow);
                }
            }

        }

        private void saveAttributesToDataSource()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataTable table = (DataTable)dataGridView2.DataSource;
                DataGridViewRow oldRow = dataGridView1.Tag as DataGridViewRow;

                if (oldRow != null)
                {
                    DataRow drw = table.Rows[oldRow.Index];

                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        string key = r.Cells["key"].Value.ToString();
                        object value = r.Cells["value"].Value;
                        drw[key] = value;
                    }
                }
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;


            if (dataGridView2.Columns[e.ColumnIndex].Name == "bild")
            {
                DialogResult result = openFileDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    dataGridView2.Rows[e.RowIndex].Cells["bild"].Value = Image.FromFile(openFileDialog1.FileName);
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
