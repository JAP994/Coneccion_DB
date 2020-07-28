using System;
using System.Windows.Forms;

namespace Coneccion_DB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        ConexionPgsql conectandose = new ConexionPgsql();
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = conectandose.Ingresar_Modificar_Eliminar_Cuenta(Convert.ToInt32(textBox7.Text), textBox4.Text, textBox5.Text, textBox1.Text, Convert.ToDecimal(textBox6.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar los datos correctamente.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
