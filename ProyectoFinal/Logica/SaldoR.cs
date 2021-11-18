using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    public class SaldoR : ConexionDB, ISaldo
    {
        public bool Add(Resumen t)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "insert into TSaldo(Ingreso, Gasto, SaldoTotal) values (@Ingreso, @Gasto, @SaldoTotal)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@Ingreso", t.Ingreso));
                cmd.Parameters.Add(new SQLiteParameter("@Gasto", t.Gasto));
                cmd.Parameters.Add(new SQLiteParameter("@SaldoTotal", t.Total));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
                //conexion.Close();
            }

            return respuesta;
        }

        public List<Resumen> FindAll()
        {
            List<Resumen> saldos = new List<Resumen>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "select * from TSaldo";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        saldos.Add(new Resumen()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            Ingreso = decimal.Parse(dr["Ingreso"].ToString()),
                            Gasto = decimal.Parse(dr["Gasto"].ToString()),
                            Total = decimal.Parse(dr["SaldoTotal"].ToString()),
                        });
                    }
                }
                //conexion.Close();
            }

            return saldos;
        }
    }
}
