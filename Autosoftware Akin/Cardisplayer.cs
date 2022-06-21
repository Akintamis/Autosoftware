using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string bild_marke;

        public Cardisplayer(int id_marke, string marke)
        {
            InitializeComponent();
            this.id_marke = id_marke;
            this.marke = marke;
        }

        private void Cardisplayer_Load(object sender, EventArgs e)
        {

            var DataAdapter = new MySqlDataAdapter("SELECT * FROM autos WHERE id=2;", Datenbank.connection);
            var CommandBuilder = new MySqlCommandBuilder();
            var Ds = new DataSet();
            DataAdapter.Fill(Ds);
            //dataGridView1.ReadOnly = true;
            //dataGridView1.DataSource = Ds.Tables[0];

            // setze attribut image von picturebox auf korrektes bild
            pictureBox1.Image = GetImageByMarke(bild_marke);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        static Bitmap GetImageByMarke(string marke_bild)
        {
            object obj = Autosoftware_Akin.Properties.Resources.ResourceManager.GetObject(marke_bild, Properties.Resources.Culture);
            return ((Bitmap)(obj));
        }

    }
}
