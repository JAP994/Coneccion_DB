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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ConexionPgsql conectandose = new ConexionPgsql();
        private void btnCuenta_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if (activeForm!=null)
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelCuentaHijo.Controls.Add(childForm);
                panelCuentaHijo.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectandose.CargarDB();
        }
    }
}
