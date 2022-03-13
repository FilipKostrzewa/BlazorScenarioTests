namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetStreet
    {
        public SetStreet(string street)
        {
            Street = street;
        }

        public string Street { get; set; }
    }
}
