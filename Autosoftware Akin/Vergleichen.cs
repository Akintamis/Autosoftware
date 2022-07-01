using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Autosoftware_Akin
{
    public partial class Vergleichen : Form
    {
        MySqlDataAdapter da;
        DataSet dataSet1, dataSet2;

        public Vergleichen()
        {
            InitializeComponent();
        }

        private void Vergleichen_Load(object sender, EventArgs e)
        {
            da = new MySqlDataAdapter("SELECT id, name, bild, ps, baujahre, motor, getriebe, antrieb, vmax, nullbishundert, neupreis FROM autos;", Datenbank.connection);
            dataSet1 = new DataSet();
            dataSet2 = new DataSet();
            da.Fill(dataSet1);
            da.Fill(dataSet2);

            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = dataSet1.Tables[0];
            comboBox1.SelectedIndex = 0;

            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "name";
            comboBox2.DataSource = dataSet2.Tables[0];
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateSelectedCarDetails(comboBox1, dataGridView1, pictureBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateSelectedCarDetails(comboBox2, dataGridView2, pictureBox2);
        }

        private void populateSelectedCarDetails(ComboBox comboBox, DataGridView dataGridView, PictureBox pictureBox)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM autos WHERE id=" + comboBox.SelectedValue + ";", Datenbank.connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataRow row = dataSet.Tables[0].Rows[0];

            // Empty the grid before displaying selected car
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            byte[] buffer = row["bild"] as byte[];
            if (buffer != null)
            {
                Image img = Image.FromStream(new MemoryStream(buffer));
                pictureBox.Image = img;
            }

            // Manually fill grid with car details
            foreach (DataColumn col in dataSet.Tables[0].Columns)
            {
                // Console.Out.WriteLine(row.Field<string>("name"));
                if (col.ColumnName != "bild" && col.ColumnName != "id" && col.ColumnName != "id_marke")
                {
                    var detailRow = new DataGridViewRow();
                    var keyCell = new DataGridViewTextBoxCell();
                    var valueCell = new DataGridViewTextBoxCell();

                    keyCell.Value = col.ColumnName;
                    detailRow.Cells.Add(keyCell);
                    Console.Out.WriteLine("keyCell: " + keyCell.Value);

                    valueCell.Value = row[col.ColumnName];
                    detailRow.Cells.Add(valueCell);
                    Console.Out.WriteLine("valueCell: " + valueCell.Value);

                    //// Get Value from datagridview: dataGridView.Rows[rowIndex].Cells[colIndex].Value.ToString()
                    //// Get current cell value by key and compare value to same cell key value on other datagridview
                    //if (row[col.ColumnName] >= dataGridView2.Rows[rowIndex].Cells[colIndex].Value.ToString())
                    //{
                    //    // Color cell red or green 
                    //    dataGridView1.Rows[1].Cells[1].Style.BackColor = Color.Red;
                    //}

                    dataGridView.Rows.Add(detailRow);
                }
            }

            updateComparison("ps", "vmax", "nullbishundert", "neupreis");
        }

        private void updateComparison(params string[] attributes)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewRow otherRow = null;
                if (row.Index < dataGridView2.Rows.Count)
                {
                    otherRow = dataGridView2.Rows[row.Index];
                }


                if (attributes.Contains(row.Cells[0].Value.ToString()))
                {
                    if (otherRow != null)
                    {
                        if(row.Cells[1].Value is DBNull || otherRow.Cells[1].Value is DBNull)
                        {
                            row.Cells[1].Style.BackColor = Color.White;
                            otherRow.Cells[1].Style.BackColor = Color.White;
                            continue;
                        }
                        
                        float value1 = (float)row.Cells[1].Value;
                        float value2 = (float)otherRow.Cells[1].Value;
                        
                        if (Math.Abs(value1 - value2) < 0.001f)
                        {
                            row.Cells[1].Style.BackColor = Color.Green;
                            otherRow.Cells[1].Style.BackColor = Color.Green;
                        }
                        else if (value1 > value2)
                        {
                            row.Cells[1].Style.BackColor = Color.Green;
                            otherRow.Cells[1].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            row.Cells[1].Style.BackColor = Color.Red;
                            otherRow.Cells[1].Style.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        row.Cells[1].Style.BackColor = Color.White;
                    }
                }
                else
                {
                    row.Cells[1].Style.BackColor = Color.White;
                    if(otherRow != null)
                        otherRow.Cells[1].Style.BackColor = Color.White;
                }
            }
        }
    }
}