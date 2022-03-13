using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetContactCityReducer : Reducer<AddUserState, SetContactCity>
    {
        public override AddUserState Reduce(AddUserState state, SetContactCity action)
        {
            return state with {ContactAddress = state.ContactAddress with {City = action.City}};
        }
    }
}
