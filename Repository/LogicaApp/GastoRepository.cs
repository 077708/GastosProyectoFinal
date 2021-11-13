using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Repository.LogicaApp
{
    public class GastoRepository : IGastos
    {
        public bool Add(Gastos t)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                //Abrimos conexion
                conexion.Open();
                //Hacemos una consulta de insert a la tabla personas
                string query = "insert into TBGastos(Name, Description, Fecha, Gasto, Categoria, Image) " +
                            " values (@name, @description, @fecha, @gasto, @categoria, @image)";

                //Luego de eso tenemos que agregarle datos con sqliteCOmmand
                //Este recibe una consulta y una conexion
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@name", t.Name));
                cmd.Parameters.Add(new SQLiteParameter("@description", t.Description));
                cmd.Parameters.Add(new SQLiteParameter("@fecha", t.Date));
                cmd.Parameters.Add(new SQLiteParameter("@gasto", t.Expenditure));
                cmd.Parameters.Add(new SQLiteParameter("@categoria", t.CategoryExpense));
                cmd.Parameters.Add(new SQLiteParameter("@image", t.Imagen));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

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

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                //Abrimos conexion
                conexion.Open();
                //Hacemos una consulta de insert a la tabla personas
                string query = "select * from People";

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
                            Date = (DateTime)dr["Fecha"],
                            Expenditure = decimal.Parse(dr["Gasto"].ToString()),
                            CategoryExpense = (CategoriaGastos)dr["Categoria"],
                            Imagen = (byte[])dr["Image"],
                        });
                    }
                }
            }


            return gastos;
        }

        public bool Update(Gastos t)
        {
            throw new NotImplementedException();
        }
    }
}
