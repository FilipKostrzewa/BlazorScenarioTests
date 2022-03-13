using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class CopyAddressReducer : Reducer<AddUserState, CopyAddress>
    {
        public override AddUserState Reduce(AddUserState state, CopyAddress action)
        {
            return state with {ContactAddress = state.Address};
        }
    }
}
