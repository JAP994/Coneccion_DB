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
                if (Convert.ToInt32(textBox7.Text) == 1)
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
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
