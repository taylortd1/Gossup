using Gossup.Common;
namespace Gossup.Providers.Facebook;

public class LoginStatus
{
    public required string client_id { get; set; }
    
    
    public required Uri redirect_uri { get; set; }
    
    
    public required string state { get; set; }
    
    
    /// <summary>
    /// List of optioional parameters
    /// </summary>
    
    public required string client_secret { get; set; }



}