namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetContactCity
    {
        public SetContactCity(string city)
        {
            City = city;
        }

        public string City { get; set; }
    }
}
