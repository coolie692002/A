﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace A.SharedKernel.DependencyInjection;

public interface IConventionalRegistrar
{
    void AddAssembly(IServiceCollection services, Assembly assembly);

    void AddTypes(IServiceCollection services, params Type[] types);

    void AddType(IServiceCollection services, Type type);
}
