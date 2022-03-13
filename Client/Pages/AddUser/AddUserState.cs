namespace BlazorScenarioTests.Client.Pages.AddUser
{
    public record AddUserState
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public AddressData Address { get; set; }
        public AddressData ContactAddress { get; set; }
    }

    public record AddressData
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
