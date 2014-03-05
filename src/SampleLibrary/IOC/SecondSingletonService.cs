﻿using System;
using LinFu.IoC.Configuration;

namespace SampleLibrary
{
    [Implements(typeof (ISampleService), LifecycleType.Singleton, ServiceName = "Second")]
    public class SecondSingletonService : ISampleService
    {
        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}