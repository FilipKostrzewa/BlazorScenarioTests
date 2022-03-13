namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetContactCountry
    {
        public SetContactCountry(string country)
        {
            Country = country;
        }

        public string Country { get; set; }
    }
}
