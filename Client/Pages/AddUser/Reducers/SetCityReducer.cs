using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetCityReducer : Reducer<AddUserState, SetCity>
    {
        public override AddUserState Reduce(AddUserState state, SetCity action)
        {
            return state with {Address = state.Address with {City = action.City}};
        }
    }
}
