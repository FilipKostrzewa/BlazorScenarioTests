using System;
using BlazorScenarioTests.Client.Pages.AddUser;
using BlazorScenarioTests.Client.Pages.AddUser.Reducers;
using Fluxor;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorScenarioTests.Client.Tests.Pages
{
    public partial class AddUserTests
    {
        private readonly IServiceProvider ServiceProvider;
        private readonly IStore Store;
        private readonly IState<AddUserState> State;
        public AddUserTests()
        {
            var services = new ServiceCollection();
            services.AddFluxor(x =>
                x
                    .ScanAssemblies(GetType().Assembly)
                    .ScanTypes(typeof(AddUserState), typeof(CopyAddressReducer)));

            ServiceProvider = services.BuildServiceProvider();
            Store = ServiceProvider.GetRequiredService<IStore>();
            State = ServiceProvider.GetRequiredService<IState<AddUserState>>();
            Store.InitializeAsync().Wait();
        }
    }
}
