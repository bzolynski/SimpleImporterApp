using App.Library.Data;
using App.Library.Data.DataAccess;
using App.Library.Interfaces;
using App.Library.Models;
using App.UI.Interfaces;
using Autofac;
using Autofac.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI
{
    public static class DependencyInjection
    {
        public static IContainer Initialize()
        {

            var builder = new ContainerBuilder();

            builder.RegisterType<Startup>().As<IStartup>();
            builder.RegisterType<TakeInput>().As<ITakeInput>();

            builder.RegisterType<SampleData>().As<ISampleData>();
            builder.RegisterType<Database>().As<IDatabase>().SingleInstance();

            builder.RegisterType<CompanyRepository>().As<IRepository<CompanyModel>>();
            builder.RegisterType<OrderRepository>().As<IRepository<OrderModel>>();
            builder.RegisterType<ProductRepository>().As<IRepository<ProductModel>>();
            builder.RegisterType<SellerRepository>().As<IRepository<SellerModel>>();


            return builder.Build();

        }
    }
}
