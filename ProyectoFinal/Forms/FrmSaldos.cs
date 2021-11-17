using AppCore.IServices;
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
    public partial class FrmSaldos : Form
    {
        private IIngresosServices ingresoServices;
        private ISaldoServices saldoServices;
        private IGastosServices gastosServices;

        public FrmSaldos(IIngresosServices ingresosServices, IGastosServices gastosServices, ISaldoServices saldoServices)
        {
            this.saldoServices = saldoServices;
            this.gastosServices = gastosServices;
            this.ingresoServices = ingresosServices;
            InitializeComponent();
        }

        private void FrmSaldos_Load(object sender, EventArgs e)
        {
            dtgvData.DataSource = saldoServices.FindAll();
        }
    }
}
