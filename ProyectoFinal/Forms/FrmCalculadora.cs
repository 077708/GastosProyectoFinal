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
    public partial class FrmCalculadora : Form
    {
        string operador;
        double segundo;
        double primero;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 1)
                txtScreen.Text = "0";
            else
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
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

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "9";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "6";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "3";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtScreen.Text);
            txtResultado.Text = txtResultado.Text + txtScreen.Text + "+";
            txtScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtScreen.Text);
            txtResultado.Text = txtResultado.Text + txtScreen.Text + "-";
            txtScreen.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtScreen.Text);
            txtResultado.Text = txtResultado.Text + txtScreen.Text + "/";
            txtScreen.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtScreen.Text);
            txtResultado.Text = txtResultado.Text + txtScreen.Text + "x";
            txtScreen.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operador = "√";
            primero = double.Parse(txtScreen.Text);
            txtResultado.Text = txtResultado.Text + txtScreen.Text + "√";
            txtScreen.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                segundo = double.Parse(txtScreen.Text);

                double Sum;
                double Res;
                double Mul;
                double Div;

                switch (operador)
                {
                    case "+":
                        Sum = (primero + segundo);
                        txtResultado.Text = txtResultado.Text + txtScreen.Text;
                        txtScreen.Text = Sum.ToString();
                        break;
                    case "-":
                        Res = primero - segundo;
                        txtResultado.Text = txtResultado.Text + txtScreen.Text;
                        txtScreen.Text = Res.ToString();
                        break;
                    case "*":
                        Mul = primero * segundo;
                        txtResultado.Text = txtResultado.Text + txtScreen.Text;
                        txtScreen.Text = Mul.ToString();
                        break;
                    case "/":
                        Div = primero / segundo;
                        txtResultado.Text = txtResultado.Text + txtScreen.Text;
                        txtScreen.Text = Div.ToString();
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            txtScreen.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
