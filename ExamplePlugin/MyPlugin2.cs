﻿using Autofac;
using EmberKernel;
using EmberKernel.Plugins;
using EmberKernel.Plugins.Attributes;
using EmberKernel.Plugins.Components;
using EmberKernel.Services.Command.Attributes;
using EmberKernel.Services.Command.Components;
using ExamplePlugin.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlugin
{
    [EmberPlugin(Author = "ZeroAsh", Name = "ExamplePlugin - 2", Version = "1.0")]
    public class MyPlugin2 : Plugin
    {
        public override void BuildComponents(IComponentBuilder builder)
        {
            builder.ConfigureCommandContainer<PluginControlCommand>();
        }

        public override Task Initialize(ILifetimeScope scope)
        {
            scope.UseCommandContainer<PluginControlCommand>();
            return Task.CompletedTask;
        }

        public override Task Uninitialize(ILifetimeScope scope)
        {
            scope.RemoveCommandContainer<PluginControlCommand>();
            return Task.CompletedTask;
        }
    }
}
