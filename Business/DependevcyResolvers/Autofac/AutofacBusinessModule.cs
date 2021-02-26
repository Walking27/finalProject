using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrate;
using Castle.DynamicProxy;
using Core.Utilites.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependevcyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance(); 
        }
    }
}
