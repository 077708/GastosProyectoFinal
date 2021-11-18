using AppCore.IServices;
using Domain.Enums;
using Guna.Charts.WinForms;
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
    public partial class FrmDashBoard : Form
    {

        private ISaldoServices saldoServices;
        private IGastosServices gastosServices;
        private IIngresosServices ingresos;
        private IQueryGastosServices queryGastosServices;

        int year;

        public FrmDashBoard(ISaldoServices saldoServices, IGastosServices gastosServices, IIngresosServices ingresosServices, IQueryGastosServices queryGastosServices)
        {
            this.queryGastosServices = queryGastosServices;
            this.gastosServices = gastosServices;
            this.ingresos = ingresosServices;
            this.saldoServices = saldoServices;
            InitializeComponent();
            cmbView.Items.AddRange(Enum.GetValues(typeof(From)).Cast<object>().ToArray());
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            dtgvData.DataSource = saldoServices.FindAll();
            lblMovGasto.Text = gastosServices.FindAll().Count + "";
            lblMovIngreso.Text = ingresos.FindAll().Count + "";
            lblSaldomov.Text = saldoServices.FindAll().Count + "";

            lblSaldoTotal.Text = (saldoServices.FindAll().Sum(item => item.Ingreso) - saldoServices.FindAll().Sum(item => item.Gasto)) +"";
            lbltotalIngreso.Text = saldoServices.FindAll().Sum(item => item.Ingreso) + "";
            lblTotalGasto.Text = saldoServices.FindAll().Sum(item => item.Gasto) + "";

            lblYear.Text = DateTime.Now.Year + "";
            year = DateTime.Now.Year;



        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbView.SelectedItem is From.Gastos)
            {
                // Example(chart);
                //Example(chart, 1, year);

            }
            else if (cmbView.SelectedItem is From.Ingresos)
            {
               // Example1(chart);

            }
            else if (cmbView.SelectedItem is From.Saldo)
            {
             //   Example2(chart);

            }
            else
            {

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            year++;

            lblYear.Text = $"{year}";
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            year--;

            lblYear.Text = $"{year}";
            
        }
    }
}
