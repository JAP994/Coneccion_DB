using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coneccion_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConexionPgsql conectandose = new ConexionPgsql();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.Tranferir(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                dataGridView1.DataSource = conectandose.Consultar();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }
    }
}
