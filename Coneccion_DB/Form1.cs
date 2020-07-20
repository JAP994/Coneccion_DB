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
                conectandose.Tranferir(textBox1.Text, textBox2.Text, Convert.ToDecimal(textBox3.Text));
                dataGridView1.DataSource = conectandose.Consultar();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox7.Text)==1)
                {
                    dataGridView2.DataSource = conectandose.Ingresar_Modificar_Eliminar_Cuenta(Convert.ToInt32(textBox7.Text), textBox4.Text, textBox5.Text, Convert.ToDecimal(textBox6.Text));
                    dataGridView1.DataSource = conectandose.Consultar();
                }
                else if (Convert.ToInt32(textBox7.Text) == 2 && textBox5.Text != "")
                {
                    dataGridView2.DataSource = conectandose.Ingresar_Modificar_Eliminar_Cuenta(Convert.ToInt32(textBox7.Text), textBox4.Text, textBox5.Text, Convert.ToDecimal(textBox6.Text));
                    dataGridView1.DataSource = conectandose.Consultar();
                }
                else if (Convert.ToInt32(textBox7.Text) == 3)
                {
                    dataGridView2.DataSource = conectandose.Ingresar_Modificar_Eliminar_Cuenta(Convert.ToInt32(textBox7.Text), textBox4.Text, "", 0);
                    dataGridView1.DataSource = conectandose.Consultar();
                }
                else
                {
                    MessageBox.Show("Debe ingresar los datos correctamente.");
                    dataGridView2.DataSource = "";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }
    }
}
