using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Ioc
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
