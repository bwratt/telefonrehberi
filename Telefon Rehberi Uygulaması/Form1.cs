﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Telefon_Rehberi_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=telefonrehberi.mdb");
        OleDbCommand komut = new OleDbCommand();

        DataTable veritablosu = new DataTable();

        public void listele()
        {
            try
            {
                veritablosu.Clear();
                OleDbDataAdapter siringa = new OleDbDataAdapter("select * from Tablo1", bag);
                siringa.Fill(veritablosu);
                dataGridView1.DataSource = veritablosu;


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
