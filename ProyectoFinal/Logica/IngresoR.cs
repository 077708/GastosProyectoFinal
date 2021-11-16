using Domain.Entities;
using Domain.Enums;
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

                string query = "insert into TBIngresoS(Name, Description, Date, Ingreso, Categoria)" +
                    " values (@name, @description, @date, @ingreso, @categoria)";

                SQLiteCommand cmd2 = new SQLiteCommand(query, conexion);

                cmd2.Parameters.Add(new SQLiteParameter("@name", t.Name));
                cmd2.Parameters.Add(new SQLiteParameter("@description", t.Description));
                cmd2.Parameters.Add(new SQLiteParameter("@date", t.Date));
                cmd2.Parameters.Add(new SQLiteParameter("@ingreso", t.Ingreso));
                cmd2.Parameters.Add(new SQLiteParameter("@categoria", (CategoriaIngresos)t.CategoryExpense));

                cmd2.CommandType = System.Data.CommandType.Text;

                if (cmd2.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
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
                            Date = DateTime.Parse(dr["Date"].ToString()),
                            Ingreso = decimal.Parse(dr["Gasto"].ToString()),
                            CategoryExpense = (CategoriaIngresos)Enum.Parse(typeof(CategoriaIngresos), dr["Categoria"].ToString()),
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
