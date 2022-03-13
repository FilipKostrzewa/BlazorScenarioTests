namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetCountry
    {
        public SetCountry(string country)
        {
            Country = country;
        }

        public string Country { get; set; }
    }
}
