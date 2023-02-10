using System.IO;
using System.IO.Compression;

namespace WindowsLoader;

internal delegate DeflateStream MenuLayout(Stream, CompressionMode);
