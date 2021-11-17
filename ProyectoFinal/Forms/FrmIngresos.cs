using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using ProyectoFinal.UsersC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmIngresos : Form
    {
        private IIngresosServices ingresosServices;
        private ISaldoServices saldoServices;

        int month, year;

        public FrmIngresos(IIngresosServices ingresosServices, ISaldoServices saldoServices)
        {
            this.saldoServices = saldoServices;
            this.ingresosServices = ingresosServices;
            InitializeComponent();
        }

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            DisplaysDays();
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMotnh.Text = monthname + " " + year;
            lblMotnh.Text = monthname;
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(CategoriaIngresos)).Cast<object>().ToArray());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            month++;

            if (month > 12)
            {
                year++;
                month = 1;
            }

            DateTime now = DateTime.Now;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMotnh.Text = monthname + " " + year;
            //Lets get the first day of the month 

            DateTime startMonth = new DateTime(year, month, 1);

            // Get the count of days of the months

            int day = DateTime.DaysInMonth(year, month);

            // Convert the startofmonth 

            int dayofTheweek = int.Parse(startMonth.DayOfWeek.ToString("d"));

            // Firts lets creat a blank usercontrol 

            for (int i = 0; i < dayofTheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            //now lets create usercontrol of day

            for (int i = 1; i < day; i++)
            {
                UserControlDays userControl = new UserControlDays(this.ingresosServices, this.saldoServices);

                userControl.days(i);

                daycontainer.Controls.Add(userControl);
            }
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMotnh.Text = monthname + " " + year;

            DateTime now = DateTime.Now;

            //Lets get the first day of the month 

            DateTime startMonth = new DateTime(year, month, 1);

            // Get the count of days of the months

            int day = DateTime.DaysInMonth(year, month);

            // Convert the startofmonth 

            int dayofTheweek = int.Parse(startMonth.DayOfWeek.ToString("d"));

            // Firts lets creat a blank usercontrol 

            for (int i = 0; i < dayofTheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            //now lets create usercontrol of day

            for (int i = 1; i < day; i++)
            {
                UserControlDays userControl = new UserControlDays(this.ingresosServices, this.saldoServices);

                userControl.days(i);

                daycontainer.Controls.Add(userControl);
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FrmCalculadora frmCalculadora = new FrmCalculadora();

            frmCalculadora.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnImage_Click(object sender, EventArgs e)
        {
            CargarImagen(btnImage);
        }

        private OpenFileDialog fd = new OpenFileDialog();

        private void CargarImagen(PictureBox pictureBox)
        {
            //Establecer la propiedad de WaitOnLoad a true significa que la imagen
            //se carga de forma sincrónica
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }
        private void DisplaysDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;
            //Lets get the first day of the month 

            //String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            //lblMotnh.Text = monthname + " " + year;

            DateTime startMonth = new DateTime(year, month, 1);

            // Get the count of days of the months

            int day = DateTime.DaysInMonth(year, month);

            // Convert the startofmonth 

            int dayofTheweek = int.Parse(startMonth.DayOfWeek.ToString("d"));

            // Firts lets creat a blank usercontrol 

            for (int i = 0; i < dayofTheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            //now lets create usercontrol of day

            for (int i = 1; i < day; i++)
            {
                UserControlDays userControl = new UserControlDays(this.ingresosServices, this.saldoServices);

                userControl.days(i);

                daycontainer.Controls.Add(userControl);
            }
        }
    }
}
