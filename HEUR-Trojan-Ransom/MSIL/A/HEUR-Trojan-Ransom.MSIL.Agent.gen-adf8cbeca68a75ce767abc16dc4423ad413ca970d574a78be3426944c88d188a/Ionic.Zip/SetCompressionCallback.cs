using Ionic.Zlib;

namespace Ionic.Zip;

public delegate CompressionLevel SetCompressionCallback(string localFileName, string fileNameInArchive);
