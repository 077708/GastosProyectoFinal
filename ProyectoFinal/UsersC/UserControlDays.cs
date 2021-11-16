﻿using AppCore.IServices;
using ProyectoFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UsersC
{
    public partial class UserControlDays : UserControl
    {
        private IIngresosServices ingreso;
        private ISaldoServices SaldoServices;

        public UserControlDays(IIngresosServices ingreso, ISaldoServices SaldoServices)
        {
            this.SaldoServices = SaldoServices;
            this.ingreso = ingreso;
            InitializeComponent();
        }

        public void days(int numday)
        {
            lblDays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            FrmControlEvent frmControlEvent = new FrmControlEvent(this.ingreso, this.SaldoServices);
            frmControlEvent.Show();
        }
    }
}
