namespace Gossup.Common;

public partial class Content
{
    /// <summary>
    /// Display id for Content
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// The string associated with the content
    /// </summary>
    public required string Text { set; get; }
    
    /// <summary>
    /// pPovider of content
    /// </summary>
    public required string ProviderId { get; set; }

    /// <summary>
    /// Type of content provided
    /// </summary>
    public ContentType Type { get; set; } = ContentType.Message;

    /// <summary>
    /// source url
    /// </summary>
    public required Uri SourceUrl { get; set; }
    
    /// <summary>
    ///date/time content posted 
    /// </summary>
    public required DateTimeOffset stamp { get; set; }
    
    /// <summary>
    /// account associated with the content provided
    /// </summary>
    public required Creator ContentCreator { get; set; }

    

}
