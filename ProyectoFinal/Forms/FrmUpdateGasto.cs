using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmUpdateGasto : Form
    {
        private IGastosServices GastosServices;
        private int id;

        public FrmUpdateGasto(IGastosServices GastosServices, int id)
        {
            this.id = id;
            this.GastosServices = GastosServices;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbCategoria.SelectedIndex < 1)
                {
                    throw new Exception("Selecciona la categoria");
                }

                if (txtIngreso.Text == string.Empty || txtIngreso.Text == string.Empty)
                {
                    throw new Exception("Por favor rellene los campos necesarios");
                }

                Gastos gasto = new Gastos()
                {
                    Id = this.id,
                    Name = txtNombre.Text,
                    Description = txtDescription.Text,
                    Gasto = decimal.Parse(txtIngreso.Text),
                    CategoryExpense = (CategoriaGastos)cmbCategoria.SelectedItem,
                };

                GastosServices.Update(gasto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUpdateGasto_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(CategoriaGastos)).Cast<object>().ToArray());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
