﻿namespace Fooidity.AutofacIntegration
{
    using Autofac;


    public interface FooIdContainer<TFoo> :
        IContainer
        where TFoo : struct, ICodeFeature
    {
        ILifetimeScope EnabledLifetimeScope { get; }

        ILifetimeScope DisabledLifetimeScope { get; }
        ILifetimeScope ParentLifetimeScope { get; }
    }
}