using System;
using System.IO;
using System.Web.Hosting;

namespace Umbraco.Storage.S3.Media
{
    internal class FileSystemVirtualFile : VirtualFile
    {
        private readonly Func<Stream> _stream;

        public FileSystemVirtualFile(string virtualPath, Func<Stream> stream) : base(virtualPath)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            _stream = stream;
        }

        public override Stream Open()
        {
            return _stream();
        }

        public override bool IsDirectory
        {
            get { return false; }
        }
    }
}
