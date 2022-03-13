namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetEmail
    {
        public SetEmail(string email)
        {
            Email = email;
        }

        public string Email { get; set; }
    }
}
