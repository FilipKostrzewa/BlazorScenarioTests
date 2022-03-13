namespace BlazorScenarioTests.Client.Pages.AddUser.Actions
{
    public class SetLogin
    {
        public SetLogin(string login)
        {
            Login = login;
        }

        public string Login { get; set; }
    }
}
