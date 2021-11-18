using AppCore.IServices;
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
    public partial class FrmResumen : Form
    {
        private IIngresosServices ingresoServices;
        private ISaldoServices saldoServices;
        private IGastosServices gastosServices;

        public FrmResumen(IIngresosServices ingresosServices, IGastosServices gastosServices, ISaldoServices saldoServices)
        {
            this.saldoServices = saldoServices;
            this.gastosServices = gastosServices;
            this.ingresoServices = ingresosServices;
            InitializeComponent();
        }

        private void FrmSaldos_Load(object sender, EventArgs e)
        {
            dtgvData.DataSource = saldoServices.FindAll();
          // dtgDataa.DataSource = saldoServices.FindAll();
            cmbFrom.Items.AddRange(Enum.GetValues(typeof(From)).Cast<object>().ToArray());
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }

            int id = (int)dtgvData.Rows[dtgvData.CurrentRow.Index].Cells[0].Value;

            if (cmbFrom.SelectedItem is From.Ingresos)
            {
                frmUpdateByIngreso frmUpdateByIngreso = new frmUpdateByIngreso(this.ingresoServices, id);
          
                frmUpdateByIngreso.ShowDialog();
            }
            else if (cmbFrom.SelectedItem is From.Gastos)
            {
                FrmUpdateGasto frmUpdateGasto = new FrmUpdateGasto(this.gastosServices, id);
                frmUpdateGasto.ShowDialog();
            }
            else if (cmbFrom.SelectedItem is From.History)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                return;
            }

            int id = (int)dtgvData.Rows[dtgvData.CurrentRow.Index].Cells[0].Value;

            if (cmbFrom.SelectedItem is From.Ingresos)
            {
                ingresoServices.Delete(id);
                dtgvData.DataSource = ingresoServices.FindAll();

            }
            else if( cmbFrom.SelectedItem is From.Gastos)
            {
                gastosServices.Delete(id);
                dtgvData.DataSource = gastosServices.FindAll();

            }
            else if (cmbFrom.SelectedItem is From.History)
            {
                return;
            }
        }

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFrom.SelectedItem is From.Gastos)
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                dtgvData.DataSource = gastosServices.FindAll();
                dtgvData.Size = new Size(655, 290);

            }
            else if (cmbFrom.SelectedItem is From.Ingresos)
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                dtgvData.DataSource = ingresoServices.FindAll();
                dtgvData.Size = new Size(655, 290);

            }
            else
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                dtgvData.Size = new Size(803, 290);

            }
        }
    }
}
