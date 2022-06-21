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
    public partial class bmw : Form
    {
        public bmw()
        {
            InitializeComponent();
        }

        private void bmw_Load(object sender, EventArgs e)
        {
            var DataAdapter = new MySqlDataAdapter("SELECT * FROM autos WHERE id=3;", Datenbank.connection);
            var CommandBuilder = new MySqlCommandBuilder();
            var Ds = new DataSet();
            DataAdapter.Fill(Ds);
            bmwgrid.ReadOnly = true;
            bmwgrid.DataSource = Ds.Tables[0];

        }

        
    }
}
