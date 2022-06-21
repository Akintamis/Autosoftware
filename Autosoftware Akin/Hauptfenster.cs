using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosoftware_Akin
{
    public partial class Hauptfenster : Form
    {
        DataSet ds;

        public Hauptfenster()
        {
            InitializeComponent();
            new Datenbank();
            ds = new DataSet();
            PopulateCarDropdown();
        }

        private void PopulateCarDropdown()
        {
            string query = "select id, marke, bild from marke";
            MySqlDataAdapter da = new MySqlDataAdapter(query, Datenbank.connection);
            da.Fill(ds, "marke");
            autodrop.DisplayMember = "marke";
            autodrop.ValueMember = "id";
            autodrop.DataSource = ds.Tables["marke"];
        }



        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Autoshintergrund.Height += 10;
                if (Autoshintergrund.Size == Autoshintergrund.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Autoshintergrund.Height -= 10;
                if (Autoshintergrund.Size == Autoshintergrund.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }

        }

        private void Autosknopf_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Audiknopf_Click(object sender, EventArgs e)
        {
            Audi audi = new Audi();
            audi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmw bmw = new bmw();
            bmw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            benz benz = new benz();
            benz.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vw vw = new vw();
            vw.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (autodrop.SelectedItem != null)
            {
                DataRowView drv = autodrop.SelectedItem as DataRowView;

                Debug.WriteLine("Item: " + drv.Row["marke"].ToString());
                Debug.WriteLine("Value: " + drv.Row["id"].ToString());
                Debug.WriteLine("Value: " + autodrop.SelectedValue.ToString());
                
                int id = Convert.ToInt16(drv.Row["id"]);

                if (id != 1)
                {
                    Cardisplayer carDisplayer = new Cardisplayer(id, drv.Row["marke"].ToString(), );
                    carDisplayer.Show();
                }
            }
        }
    }
}


