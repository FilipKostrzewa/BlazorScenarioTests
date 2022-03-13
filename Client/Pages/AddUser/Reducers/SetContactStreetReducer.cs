using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetContactStreetReducer : Reducer<AddUserState, SetContactStreet>
    {
        public override AddUserState Reduce(AddUserState state, SetContactStreet action)
        {
            return state with {ContactAddress = state.ContactAddress with {Street = action.Street}};
        }
    }
}
