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
        public bool Add(Saldo t)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "insert into TBSaldo(Ingreso, Gasto, SaldoTotal) values (@Ingreso, @Gasto, @SaldoTotal)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@Ingreso", t.Ingresos.Ingreso));
                cmd.Parameters.Add(new SQLiteParameter("@Gasto", t.Gastos.Gasto));
                cmd.Parameters.Add(new SQLiteParameter("SaldoTotal", t.SaldoTotal));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
                conexion.Close();
            }

            return respuesta;
        }

        public List<Saldo> FindAll()
        {
            List<Saldo> saldos = new List<Saldo>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "from * select TBSaldo";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        saldos.Add(new Saldo()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            ingresos = decimal.Parse(dr["Ingreso"].ToString()),
                            gastos = decimal.Parse(dr["Gasto"].ToString()),
                            total = decimal.Parse(dr["SaldoTotal"].ToString()),
                        });
                    }
                }
                conexion.Close();
            }

            return saldos;
        }
    }
}
