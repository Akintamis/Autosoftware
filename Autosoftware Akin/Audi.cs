﻿using MySql.Data.MySqlClient;
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
    public partial class Audi : Form
    {
        public Audi()
        {
            InitializeComponent();
        }

        private void Audi_Load(object sender, EventArgs e)
        {
            var DataAdapter = new MySqlDataAdapter("SELECT * FROM autos WHERE id=2;", Datenbank.connection);
            var CommandBuilder = new MySqlCommandBuilder();
            var Ds = new DataSet();
            DataAdapter.Fill(Ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = Ds.Tables[0];

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}