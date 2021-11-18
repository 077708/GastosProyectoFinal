using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using ProyectoFinal.UsersC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmControlEvent : Form
    {
        private IIngresosServices ingresosServices;
        private ISaldoServices saldoServices;

        public FrmControlEvent(IIngresosServices ingresosServices, ISaldoServices saldoServices)
        {
            this.saldoServices = saldoServices;
            this.ingresosServices = ingresosServices;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedIndex < 0)
                {
                    throw new Exception("Selecciona la categoria");
                }

                if (txtIngreso.Text == string.Empty || txtName.Text == string.Empty)
                {
                    throw new Exception("Por favor rellene los campos necesarios");
                }

                Ingresos ingreso = new Ingresos()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                   /// Date = new DateTime(2021, int.Parse(UserControlDays.static_day), int.Parse(FrmIngresos.static_Mes)),
                    Ingreso = decimal.Parse(txtIngreso.Text),
                    CategoryExpense = (CategoriaIngresos)cmbCategoria.SelectedItem,
                };

                ingresosServices.Add(ingreso);

                Resumen saldo = new Resumen()
                {
                    Ingreso = ingresosServices.FindAll()[ingresosServices.FindAll().Count - 1].Ingreso,
                    Gasto = 0,
                    //Total = saldoServices.FindAll().Sum(item => item.Ingreso) - saldoServices.FindAll().Sum(item => item.Gasto),
                };

                if (ingresosServices.FindAll().Count == 1)
                {
                    saldo.Total = ingreso.Ingreso;
                }
                else
                {
                    saldo.Total = saldoServices.FindAll().Sum(item => item.Ingreso) - saldoServices.FindAll().Sum(item => item.Gasto)
                       + ingresosServices.FindAll()[0].Ingreso;
                }

                saldoServices.Add(saldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmControlEvent_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(CategoriaIngresos)).Cast<Object>().ToArray());
            lblSelectedDate.Text = UserControlDays.static_day +" "+ FrmIngresos.static_Mes;
        }
    }
}
