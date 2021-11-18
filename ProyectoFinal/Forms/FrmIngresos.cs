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
        public static string static_Mes;
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

            static_Mes = lblMotnh.Text;
            
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

            static_Mes = lblMotnh.Text;

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
            try
            {
                if (cmbCategoria.SelectedIndex < 1)
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
                    Ingreso = decimal.Parse(txtIngreso.Text),
                    Date = DateTime.Now,
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
