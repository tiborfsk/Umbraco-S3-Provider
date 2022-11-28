using Amazon.S3;

namespace Umbraco.Storage.S3
{
    public enum VirtualPathProviderMode
    {
        Enabled,
        Disabled,
        Manual
    }

    public class BucketFileSystemConfig
    {
        public string BucketName { get; set; }

        public string BucketHostName { get; set; }

        public string BucketPrefix { get; set; }

        public string Region { get; set; }

        public S3CannedACL CannedACL { get; set; }

        public ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }

        public VirtualPathProviderMode VirtualPathProviderMode { get; set; }
    }
}
