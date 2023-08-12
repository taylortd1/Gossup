namespace Gossup.common;

public interface ISocialMediaProvider
{
    /// <summary>
    /// unique id for provider
    /// </summary>
    string Id { get; set; }
    /// <summary>
    /// display name for provideer
    /// </summary>
    string DisplayName { get; set; }

    /// <summary>
    ///collection of content for given tag
    /// </summary>
    /// <param name="tag">tag search</param>
    /// <param name="sinceDate">stamp to search back in time</param>
    /// <returns></returns>
    Task<IEnumerable<ContentKeyword>> GetContentForKeyword(ContentKeyword tag, DateTimeOffset sinceDate);
}
