using AppCore.IServices;
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
    public partial class FrmPresentation : Form
    {
        private IGastosServices gastosServices;
        private IIngresosServices ingresos;
        private IQueryIngresosServices queryIngresosServices;
        private IQueryGastosServices queryGastosServices;
        private ISaldoServices SaldoServices;

        public FrmPresentation(IGastosServices gastosServices, IIngresosServices ingresos
                              , IQueryIngresosServices queryIngresosServices, IQueryGastosServices queryGastosServices, 
                                ISaldoServices SaldoServices)
        {

            this.queryIngresosServices = queryIngresosServices;
            this.queryGastosServices = queryGastosServices;
            this.SaldoServices = SaldoServices;
            this.gastosServices = gastosServices;
            this.ingresos = ingresos;
            InitializeComponent();
        }

        private void btnBarra_Click(object sender, EventArgs e)
        {
            if (panelButtons.Width == 55)
            {
                panelButtons.Width = 230;
                btnBarra.Location = new Point(195, 0);
            }
            else
            {
                panelButtons.Width = 55;
                btnBarra.Location = new Point(12, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            CargarImagen(rjCircularPictureBox1);
        }

        private void dtTIme_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            FrmIngresos frmIngresos = new FrmIngresos(this.ingresos, this.SaldoServices);
            //AbrirFormulario<FrmIngresos>();
            AbrirFormEnPanel(frmIngresos);
            //btnIngresos.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashBoard frmDashBoard = new FrmDashBoard();
            AbrirFormEnPanel(frmDashBoard);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            FrmGastos frmGastos = new FrmGastos(this.gastosServices, this.SaldoServices);

            AbrirFormEnPanel(frmGastos);
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            FrmSaldos frmSaldos = new FrmSaldos(this.ingresos, this.gastosServices, this.SaldoServices);
            AbrirFormEnPanel(frmSaldos);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            AbrirFormEnPanel(frmReportes);
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
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
    }
}
