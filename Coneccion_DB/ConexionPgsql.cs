﻿using System;
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
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = suco1994; Database = Banco;");
       
        public DataTable Consultar()
        {
            string query = "SELECT nro_cuenta,cedula,nombre,saldo FROM Transacciones.cuentas WHERE estado = true ";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }



        public DataTable Ingresar_Modificar_Eliminar_Cuenta(int p_opcion, string p_nro_cuenta, string p_cedula, string p_nombre, decimal p_saldo)
        {
            string query1 = $"SELECT * FROM  Transacciones.sp_cuenta_guardar_eliminar_modificar({p_opcion},'{p_nro_cuenta}','{p_cedula}','{p_nombre}',{p_saldo});";
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
              
                string query2 = $"UPDATE Transacciones.cuentas SET saldo = saldo - { textBox3 } WHERE nro_cuenta = '{ textBox1 }'  and saldo >= { textBox3 }";
                NpgsqlCommand ejecutor2 = new NpgsqlCommand(query2, conn);
                var e= ejecutor2.ExecuteNonQuery();
                //MessageBox.Show(e+"");

                string query3 = $"UPDATE Transacciones.cuentas SET saldo = saldo + { textBox3 } WHERE nro_cuenta = '{ textBox2 }'";
                NpgsqlCommand ejecutor3 = new NpgsqlCommand(query3, conn);
                var f=ejecutor3.ExecuteNonQuery();
                //MessageBox.Show(f + "");

                if (f == 1 && e == 1)
                {
                    //MessageBox.Show(e + "e" + f + "f");
                    string query4 = "COMMIT";
                    NpgsqlCommand ejecutor4 = new NpgsqlCommand(query4, conn);
                    ejecutor4.ExecuteNonQuery();
                    string query5 = $"INSERT INTO Transacciones.transacciones(fecha, monto, tipo_transaccion, nro_cuenta, descripcion) VALUES(current_timestamp, { textBox3 }, 1 , '{ textBox1 }', '{ textBox5 }');";
                    NpgsqlCommand ejecutor5 = new NpgsqlCommand(query5, conn);
                    ejecutor5.ExecuteNonQuery();
                    MessageBox.Show(textBox1);
                    string query6 = $"INSERT INTO Transacciones.transacciones(fecha, monto, tipo_transaccion, nro_cuenta, descripcion) VALUES(current_timestamp, { textBox3 }, 2 , '{ textBox2 }', '{ textBox5 }'); ";
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
            string query1 = $"Select * FROM Transacciones.moviemientos_cuenta WHERE nro_cuenta = '{ p_nro_cuenta }'";
            NpgsqlCommand ejecutor1 = new NpgsqlCommand(query1, conn);
            NpgsqlDataAdapter datos1 = new NpgsqlDataAdapter(ejecutor1);
            DataTable tabla1 = new DataTable();
            datos1.Fill(tabla1);
            return tabla1;
        }

        public void CargarDB()
        {
            try
            {
                conn.Open();
                string query11 = "SELECT Transacciones.cargar_cuentasDB()";
                string query12 = "SELECT Transacciones.realizar_transacciones() FROM generate_series(1,2)";
                string query13 = "SELECT Transacciones.cargar_descripcionesDB()";
                NpgsqlCommand ejecutor11 = new NpgsqlCommand(query11, conn);
                NpgsqlCommand ejecutor12 = new NpgsqlCommand(query12, conn);
                NpgsqlCommand ejecutor13 = new NpgsqlCommand(query13, conn);
                ejecutor11.ExecuteNonQuery();
                ejecutor12.ExecuteNonQuery();
                ejecutor13.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("DB Cargada.");
            }
            catch (Exception)
            {

                MessageBox.Show("DB No Cargada.");
            }
              
        }
    }
}
