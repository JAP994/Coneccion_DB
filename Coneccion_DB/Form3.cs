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
namespace Coneccion_DB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ConexionPgsql conectandose = new ConexionPgsql();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.verTransacciones(textBox1.Text);
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Users\sawme\Downloads\reportecuenta1111.pdf";
            proceso.Start();
        }
    }
}
