namespace Azure.Maps.TimeZone
{
    public partial class TimeZoneClient
    {
        protected TimeZoneClient() { }
        public TimeZoneClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Maps.TimeZone.TimeZoneClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class TimeZoneClientOptions : Azure.Core.ClientOptions
    {
        public TimeZoneClientOptions(Azure.Maps.TimeZone.Generated.TimeZoneClientOptions.ServiceVersion version = Azure.Maps.TimeZone.Generated.TimeZoneClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}