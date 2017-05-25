using Autofac;
using NUnitResearch.Shared.BC;
using NUnitResearch.Shared.DAC.InMemory;
using NUnitResearch.Shared.Interfaces;
using NUnitResearch.Shared.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<StateInMemoryRepository>().As<IStateRepository>();
            builder.RegisterType<LocalStateData>().As<ILocalStateData>();
            Container = builder.Build();

            GetState();
            GetStateWithoutAutofac();
        }

        private static void GetStateWithoutAutofac()
        {
            var stateFacade = new StateFacade(new StateInMemoryRepository(new LocalStateData()));
            stateFacade.StateExists("GA");
        }

        private static void GetState()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var stateFacade = new StateFacade(scope.Resolve<IStateRepository>());
                stateFacade.StateExists("GA");
            }
        }
    }
}
