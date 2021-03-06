﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmberKernel
{
    public interface IScopeBilder
    {
        void BuildScope(ContainerBuilder builder);
        Task Run(ILifetimeScope scope);
    }
}
