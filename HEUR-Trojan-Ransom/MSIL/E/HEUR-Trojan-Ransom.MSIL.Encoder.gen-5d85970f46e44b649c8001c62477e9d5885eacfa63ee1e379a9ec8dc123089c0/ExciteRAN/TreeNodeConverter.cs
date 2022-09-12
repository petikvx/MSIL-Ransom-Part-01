using System.IO;
using System.IO.Compression;

namespace ExciteRAN;

internal delegate DeflateStream TreeNodeConverter(Stream, CompressionMode);
