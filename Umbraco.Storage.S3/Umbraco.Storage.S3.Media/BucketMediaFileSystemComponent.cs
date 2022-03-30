using Umbraco.Core.Composing;
using Umbraco.Core.IO;

namespace Umbraco.Storage.S3.Media
{
    public class BucketMediaFileSystemComponent : IComponent
    {
        private readonly SupportingFileSystems supportingFileSystems;
        private readonly BucketFileSystemConfig config;

        public BucketMediaFileSystemComponent(SupportingFileSystems supportingFileSystems, BucketFileSystemConfig config)
        {
            this.supportingFileSystems = supportingFileSystems;
            this.config = config;
        }

        public void Initialize()
        {
            var fs = supportingFileSystems.For<IMediaFileSystem>() as BucketFileSystem;
            if (config.VirtualPathProviderMode == VirtualPathProviderMode.Enabled && fs != null)
            {
                FileSystemVirtualPathProvider.ConfigureMedia();
            }
        }

        public void Terminate()
        {

        }
    }
}
