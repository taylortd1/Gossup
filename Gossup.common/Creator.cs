namespace Gossup.Common;

public class Creator
{
    /// <summary>
    /// provider the content creator orignated from
    /// </summary>
    public required string ProviderId { get; set; }

    /// <summary>
    /// Content creator name
    /// </summary>
    public required string CreatorName { get; set; }

    /// <summary>
    /// source url for content creator profile
    /// </summary>
    public required Uri ProfileUrl { get; set; }

    /// <summary>
    /// source url for content creator profile image
    /// </summary>
    public required Uri ProfileImageUrl { get; set; }

}


