namespace Gossup.Providers.Facebook;

public class FacebookProvider : ISocialMediaProvider
{
    
    public string Id => "facebook";

    public string DisplayName => "Facebook";

    Task<IEnumerable<Common.LoginStatus>> ISocialMediaProvider.AccountLogin(string client_id, Uri request_uri, string state)
    {
        throw new NotImplementedException();
    }
}