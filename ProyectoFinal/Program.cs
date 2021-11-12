using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using ProyectoFinal.Forms;
using Repository.LogicaApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GastoServices>().As<IGastosServices>();
            builder.RegisterType<IngresoServices>().As<IIngresosServices>();

            builder.RegisterType<SaldoServices>().As<ISaldoServices>();
            builder.RegisterType<GastoRepository>().As<IGastos>();

            builder.RegisterType<IngresoRepository>().As<IIngresos>();
            builder.RegisterType<SaldoRepository>().As<ISaldo>();

            var container = builder.Build();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPresentation());
        }
    }
}
