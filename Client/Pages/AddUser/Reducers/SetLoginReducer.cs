using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetLoginReducer : Reducer<AddUserState, SetLogin>
    {
        public override AddUserState Reduce(AddUserState state, SetLogin action)
        {
            return state with {Login = action.Login};
        }
    }
}
