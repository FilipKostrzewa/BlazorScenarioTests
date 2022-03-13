using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetCountryReducer : Reducer<AddUserState, SetCountry>
    {
        public override AddUserState Reduce(AddUserState state, SetCountry action)
        {
            return state with {Address = state.Address with {Country = action.Country}};
        }
    }
}
