using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser
{
    public class AddUserFeature : Feature<AddUserState>
    {
        public override string GetName() => nameof(AddUserState);

        protected override AddUserState GetInitialState()
        {
            return new AddUserState
            {
                Address = new AddressData(),
                ContactAddress = new AddressData(),
            };
        }
    }
}
