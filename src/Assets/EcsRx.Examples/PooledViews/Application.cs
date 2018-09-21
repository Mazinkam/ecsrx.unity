﻿using EcsRx.Infrastructure.Extensions;
using EcsRx.Zenject;

namespace EcsRx.Examples.PooledViews
{
    public class Application : EcsRxApplicationBehaviour
    {
        protected override void ApplicationStarting()
        {
            this.BindAllSystemsWithinApplicationScope();
        }

        protected override void ApplicationStarted()
        {
            this.RegisterAllBoundSystems();
        }
    }
}
