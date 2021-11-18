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
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            dtgvData.DataSource = ingresos.FindAll();
            lblMovGasto.Text = gastosServices.FindAll().Count + "";
            lblMovIngreso.Text = ingresos.FindAll().Count + "";
            lblSaldomov.Text = saldoServices.FindAll().Count + "";

            lblSaldoTotal.Text = (ingresos.FindAll().Sum(item => item.Ingreso) - gastosServices.FindAll().Sum(item => item.Gasto)) + "";
            lbltotalIngreso.Text = ingresos.FindAll().Sum(item => item.Ingreso) + "";
            lblTotalGasto.Text = gastosServices.FindAll().Sum(item => item.Gasto) + "";

            lblYear.Text = DateTime.Now.Year + "";
            year = DateTime.Now.Year;
            cmbView.Items.AddRange(Enum.GetValues(typeof(From)).Cast<object>().ToArray());
            Example(ImageChart);
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

        public static void Example(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July" , "August", "September", "October", "November", "December"};

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(months[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
