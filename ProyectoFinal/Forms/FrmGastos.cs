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
    public partial class FrmGastos : Form
    {
        private IGastosServices gastosServices;
        private ISaldoServices saldoServices;
        private IIngresosServices ingresosServices;

        public FrmGastos(IGastosServices gastosServices, ISaldoServices saldoServices, IIngresosServices ingresosServices)
        {
            this.ingresosServices = ingresosServices;
            this.saldoServices = saldoServices;
            this.gastosServices = gastosServices;
            InitializeComponent();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Gastos g = new Gastos()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Date = DtDate.Value,
                    Gasto = decimal.Parse(txtGasto.Text),
                    //Imagen = ImageToByte(btnImage.Image),

                    CategoryExpense = (CategoriaGastos)cmbCategoria.SelectedItem,
                };

                gastosServices.Add(g);

                Saldo saldo = new Saldo()
                {
                    Ingreso = 0,
                    Gasto = g.Gasto,
                    Total = ingresosServices.FindAll().Sum(item => item.Ingreso) - gastosServices.FindAll().Sum(item => item.Gasto),
                };

                saldoServices.Add(saldo);
                dtgvData.DataSource = gastosServices.FindAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error, ingrese solo numeros", ex.Message);
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void FrmGastos_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(Enum.GetValues(typeof(CategoriaGastos)).Cast<object>().ToArray());
            dtgvData.DataSource = gastosServices.FindAll();
        }

        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
