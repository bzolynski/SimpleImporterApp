﻿using App.Library.Data;
using App.Library.Data.DataAccess;
using App.Library.Interfaces;
using App.Library.Interfaces.Repository;
using App.Library.Models;
using App.UI.Interfaces;
using App.UI.Menu;
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

            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<SellerRepository>().As<ISellerRepository>();

            builder.RegisterType<CompanyMenu>().AsSelf();
            builder.RegisterType<MainMenu>().AsSelf();
            builder.RegisterType<OrderMenu>().AsSelf();
            builder.RegisterType<ProductMenu>().AsSelf();
            builder.RegisterType<SellerMenu>().AsSelf();

            return builder.Build();

        }
    }
}
