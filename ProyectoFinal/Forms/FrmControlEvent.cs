using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
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
            Ingresos ingreso = new Ingresos()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Ingreso = decimal.Parse(txtIngreso.Text),
                CategoryExpense = (CategoriaIngresos)cmbCategoria.SelectedItem,
            };

            ingresosServices.Add(ingreso);

            Saldo saldo = new Saldo()
            {
                Ingreso = ingreso.Ingreso,
                Gasto = 0,
                Total = saldoServices.FindAll().Sum(item => item.Ingreso) - saldoServices.FindAll().Sum(item => item.Gasto),
            };

            saldoServices.Add(saldo);
        }

        private void FrmControlEvent_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(CategoriaIngresos)).Cast<Object>().ToArray());
        }
    }
}
