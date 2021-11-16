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
    public class GastoR : ConexionDB, IGastos
    {
        public bool Add(Gastos t)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(ConexionDB.cadena))
            {
                //Abrimos conexion
                conexion.Open();
                //Hacemos una consulta de insert a la tabla personas
                string query = "insert into TBGastos(Name, Description, Fecha, Gasto, Categoria) " +
                            " values (@name, @description, @fecha, @gasto, @categoria)";

                //Luego de eso tenemos que agregarle datos con sqliteCOmmand
                //Este recibe una consulta y una conexion
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@name", t.Name));
                cmd.Parameters.Add(new SQLiteParameter("@description", t.Description));
                cmd.Parameters.Add(new SQLiteParameter("@fecha", t.Date));
                cmd.Parameters.Add(new SQLiteParameter("@gasto", t.Gasto));
                cmd.Parameters.Add(new SQLiteParameter("@categoria", (CategoriaGastos)t.CategoryExpense));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

                conexion.Close();

                return respuesta;
            }
        }

        public bool Delete(Gastos t)
        {
            throw new NotImplementedException();
        }

        public List<Gastos> FindAll()
        {
            List<Gastos> gastos = new List<Gastos>();

            using (SQLiteConnection conexion = new SQLiteConnection(ConexionDB.cadena))
            {
                //Abrimos conexion
                conexion.Open();
                //Hacemos una consulta de insert a la tabla personas
                string query = "select * from TBGastos";

                //Luego de eso tenemos que agregarle datos con sqliteCOmmand
                //Este recibe una consulta y una conexion
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        gastos.Add(new Gastos()
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            Name = dr["Name"].ToString(),
                            Description = dr["Description"].ToString(),
                            Date = DateTime.Parse(dr["Fecha"].ToString()),
                            Gasto = decimal.Parse(dr["Gasto"].ToString()),
                            CategoryExpense = (CategoriaGastos)Enum.Parse(typeof(CategoriaGastos), dr["Categoria"].ToString()),
                        });
                    }
                }

                conexion.Close();
            }


            return gastos;
        }

        public bool Update(Gastos t)
        {
            throw new NotImplementedException();
        }
    }
}
