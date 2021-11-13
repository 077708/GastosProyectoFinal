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

        public FrmGastos(IGastosServices gastosServices)
        {
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
            Gastos g = new Gastos()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Date = DtDate.Value,
                Expenditure = decimal.Parse(txtGasto.Text),
                //Imagen = ImageToByte(btnImage.Image),
                CategoryExpense = (CategoriaGastos)cmbCategoria.SelectedItem,
            };

            gastosServices.Add(g);
            dtgvData.DataSource = gastosServices.FindAll();
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
    }
}
