namespace SimpleProductInventoryManagement.PLEASE.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string email, string password);

        Task Logout();
    }
}
