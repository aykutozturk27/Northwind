using Autofac;
using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.DependencyResolvers.Autofac
{
    public class ValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductValidator>().As<IValidator<Product>>().SingleInstance();
        }
    }
}
