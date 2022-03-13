using BlazorScenarioTests.Client.Pages.AddUser.Actions;
using Fluxor;

namespace BlazorScenarioTests.Client.Pages.AddUser.Reducers
{
    public class SetContactCountryReducer : Reducer<AddUserState, SetContactCountry>
    {

        public override AddUserState Reduce(AddUserState state, SetContactCountry action)
        {
            return state with {ContactAddress = state.ContactAddress with {Country = action.Country}};
        }
    }
}
