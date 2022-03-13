namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetCity
    {
        public SetCity(string city)
        {
            City = city;
        }

        public string City { get; set; }
    }
}
