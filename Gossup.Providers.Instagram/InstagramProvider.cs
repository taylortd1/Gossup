namespace Gossup.Providers.Instagram;

internal class InstagramProvider : ISocialMediaProvider
{
    public string Id => "INSTAGRAM";
    public string DisplayName => "Instagram";
    
    Task<IEnumerable<Common.LoginStatus>> ISocialMediaProvider.AccountLogin(string client_id, Uri request_uri, string state)
    {
        throw new NotImplementedException();
    }
}
