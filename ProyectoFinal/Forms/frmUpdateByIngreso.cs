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
    public partial class frmUpdateByIngreso : Form
    {
        private IIngresosServices ingresosServices;
        private int Id;

        public frmUpdateByIngreso(IIngresosServices ingresosServices, int id)
        {
            this.Id = id;
            this.ingresosServices = ingresosServices;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtIngreso.Text == string.Empty)
                {
                    throw new Exception("Por favor rellene campos necesarios");
                }

                if (decimal.Parse(txtIngreso.Text) < 0)
                {
                    throw new Exception("Por favor ingrese una cantidad positiva");
                }

                if (cmbCategoria.SelectedIndex < 0)
                {
                    throw new Exception("Seleccione una categoria");
                }

                Ingresos ingreso = new Ingresos()
                {
                    Id = this.Id,
                    Name = txtNombre.Text,
                    Description = txtDescription.Text,
                    Ingreso = decimal.Parse(txtIngreso.Text),
                    CategoryExpense = (CategoriaIngresos)cmbCategoria.SelectedItem,
                };

                ingresosServices.Update(ingreso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateByIngreso_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(CategoriaIngresos)).Cast<object>().ToArray());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
