namespace WebBankSP
{
    public interface IAuthentication
    {
        bool Verify(string id, string password);
    }
}