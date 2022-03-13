using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetStreetReducer : Reducer<AddUserState, SetStreet>
    {
        public override AddUserState Reduce(AddUserState state, SetStreet action)
        {
            return state with {Address = state.Address with {Street = action.Street}};
        }
    }
}
