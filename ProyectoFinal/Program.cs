using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using ProyectoFinal.Forms;
using ProyectoFinal.Logica;
using Repository.LogicaDB;
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

            //Inyeccion de dependencias de Gastos
            builder.RegisterType<GastoServices>().As<IGastosServices>();
            builder.RegisterType<GastoR>().As<IGastos>();

            //Inyeccion de dependencias de ingresos
            builder.RegisterType<IngresoServices>().As<IIngresosServices>();
            builder.RegisterType<IngresoR>().As<IIngresos>();

            //inyeccion de dependencia de querys
            builder.RegisterType<GastosRepository>().As<IQueryGastos>();
            builder.RegisterType<QueryGastosServices>().As<IQueryGastosServices>();

            builder.RegisterType<IngresosRepository>().As<IQueryIngresos>();
            builder.RegisterType<QueryServicesIngresos>().As<IQueryIngresosServices>();

            //Inyeccion de dependencia de saldo
            builder.RegisterType<SaldoR>().As<ISaldo>();
            builder.RegisterType<SaldoServices>().As<ISaldoServices>();
            var container = builder.Build();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPresentation(container.Resolve<IGastosServices>(), 
                container.Resolve<IIngresosServices>(), 
                container.Resolve<IQueryIngresosServices>(),
                container.Resolve<IQueryGastosServices>(),
                container.Resolve<ISaldoServices>()));
        }
    }
}
