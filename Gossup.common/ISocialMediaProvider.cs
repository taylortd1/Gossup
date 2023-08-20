namespace Gossup.Common;

public interface ISocialMediaProvider
{
    /// <summary>
    /// unique id for provider
    /// </summary>
    string Id { get; }
    /// <summary>
    /// display name for provideer
    /// </summary>
    string DisplayName { get; }

    /// <summary>
    ///collection of content for given tag
    /// </summary>
    /// <param name="tag">tag search</param>
    /// <param name="sinceDate">stamp to search back in time</param>
    /// <returns></returns>
    public Task<IEnumerable<LoginStatus>> AccountLogin(string client_id, Uri request_uri, string state);
}
