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



        public DataTable Ingresar_Modificar_Eliminar_Cuenta(int p_opcion, string p_nro_cuenta, string p_cedula, decimal p_saldo)
        {
            string query1 = $"SELECT * FROM sp_cuenta_guardar_eliminar_modificar({p_opcion},'{p_nro_cuenta}','{p_cedula}',{ p_saldo});";
            NpgsqlCommand ejecutor1 = new NpgsqlCommand(query1, conn);
            NpgsqlDataAdapter datos1 = new NpgsqlDataAdapter(ejecutor1);
            DataTable tabla1 = new DataTable();
            datos1.Fill(tabla1);
            return tabla1;
            
        }




        public void Tranferir(string textBox1, string textBox2, decimal textBox3, string textBox5)
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
                    string query5 = $"INSERT INTO transacciones(fecha, monto, tipo_transaccion, nro_cuenta, descripcion) VALUES(current_timestamp, { textBox3 }, 1 , '{ textBox1 }', 'Se le debita por: { textBox5 }');";
                    NpgsqlCommand ejecutor5 = new NpgsqlCommand(query5, conn);
                    ejecutor5.ExecuteNonQuery();
                    MessageBox.Show(textBox1);
                    string query6 = $"INSERT INTO transacciones(fecha, monto, tipo_transaccion, nro_cuenta, descripcion) VALUES(current_timestamp, { textBox3 }, 2 , '{ textBox2 }', 'Se le acredita por: { textBox5 }'); ";
                    NpgsqlCommand ejecutor6 = new NpgsqlCommand(query6, conn);
                    ejecutor6.ExecuteNonQuery();
                    MessageBox.Show(textBox2);
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
            }
           
        }
        public DataTable verTransacciones(string p_nro_cuenta)
        {
            string query1 = $"Select * FROM moviemientos_cuenta WHERE nro_cuenta = '{ p_nro_cuenta }'";
            NpgsqlCommand ejecutor1 = new NpgsqlCommand(query1, conn);
            NpgsqlDataAdapter datos1 = new NpgsqlDataAdapter(ejecutor1);
            DataTable tabla1 = new DataTable();
            datos1.Fill(tabla1);
            return tabla1;
        }

    }
}
