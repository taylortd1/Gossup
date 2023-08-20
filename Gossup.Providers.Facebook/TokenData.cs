namespace Gossup.Providers.Facebook;

public class TokenData
{

    public class RootData
    {
        public required Data data { get; set; }
    }

    public class Data
    {
        public long app_id { get; set; }
        public required string type { get; set; }
        public required string application { get; set; }
        public int expires_at { get; set; }
        public bool is_valid { get; set; }
        public int issued_at { get; set; }
        public required Metadata metadata { get; set; }
        public required string[] scopes { get; set; }
        public required string user_id { get; set; }
    }

    public class Metadata
    {
        public required string sso { get; set; }
    }

}
