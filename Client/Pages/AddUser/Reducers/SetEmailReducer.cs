using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetEmailReducer : Reducer<AddUserState, SetEmail>
    {
        public override AddUserState Reduce(AddUserState state, SetEmail action)
        {
            return state with {Email = action.Email};
        }
    }
}
