namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetContactStreet
    {
        public SetContactStreet(string street)
        {
            Street = street;
        }

        public string Street { get; set; }
    }
}
