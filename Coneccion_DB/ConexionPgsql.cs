using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Coneccion_DB
{
    class ConexionPgsql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = suco1994; Database = postgres;");

        public DataTable Consultar()
        {
            string query = "SELECT * FROM cuentas";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public void Tranferir(string textBox1, string textBox2, int textBox3)
        {
            try
            {
                conn.Open();
                string query1 = "BEGIN";
                NpgsqlCommand ejecutor1 = new NpgsqlCommand(query1, conn);
                ejecutor1.ExecuteNonQuery();
              
                string query2 = $"UPDATE cuentas SET saldo = saldo - { textBox3 } WHERE nro_cuenta = '{ textBox1 }' and saldo >0 and saldo >= { textBox3 }";
                NpgsqlCommand ejecutor2 = new NpgsqlCommand(query2, conn);
                var e= ejecutor2.ExecuteNonQuery();
                //MessageBox.Show(e+"");

                string query3 = $"UPDATE cuentas SET saldo = saldo + { textBox3 } WHERE nro_cuenta = '{ textBox2 }'";
                NpgsqlCommand ejecutor3 = new NpgsqlCommand(query3, conn);
                var f=ejecutor3.ExecuteNonQuery();
                //MessageBox.Show(f + "");
                if (f == 1 && e == 1)
                {
                    //MessageBox.Show(e + "e" + f + "f");
                    string query4 = "COMMIT";
                    NpgsqlCommand ejecutor4 = new NpgsqlCommand(query4, conn);
                    ejecutor4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Transacción realizada con éxito.");
                }
                else
                {
                   // MessageBox.Show(e + "e" + f + "f");
                    string query4 = "ROLLBACK";
                    NpgsqlCommand ejecutor4 = new NpgsqlCommand(query4, conn);
                    ejecutor4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("La transacción no pudo ser realizada.");
                }
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("La transacción no pudo ser realizada.");
                throw;
            }
           
        }
    }
}
