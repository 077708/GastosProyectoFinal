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
    public class IngresoR : ConexionDB, IIngresos
    {
        public bool Add(Ingresos t)
        {
            bool respuesta = true;
            
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "insert into IngresosDB(Name, Description, Date, Ingreso, Categoria) value (@name, @description, @Date, @Ingreso, @categoria)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@name", t.Name));
                cmd.Parameters.Add(new SQLiteParameter("@description", t.Description));
                cmd.Parameters.Add(new SQLiteParameter("@Date", t.Date));
                cmd.Parameters.Add(new SQLiteParameter("@Ingreso", t.Expenditure));
                cmd.Parameters.Add(new SQLiteParameter("@categoria", t.CategoryExpense));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

                conexion.Close();
            }

            return respuesta;
        }

        public bool Delete(Ingresos t)
        {
            throw new NotImplementedException();
        }

        public List<Ingresos> FindAll()
        {
            List<Ingresos> ingresos = new List<Ingresos>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "select * from IngresosDB";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        ingresos.Add(new Ingresos()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            Name = dr["Name"].ToString(),
                            Description = dr["Description"].ToString(),
                            Date = DateTime.Now,
                            Expenditure = decimal.Parse(dr["Gasto"].ToString()),
                        });
                    }
                }
            }

            return ingresos;
        }

        public bool Update(Ingresos t)
        {
            throw new NotImplementedException();
        }
    }
}
