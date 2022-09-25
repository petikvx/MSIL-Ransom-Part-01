using System.IO;

namespace Ionic.Zip;

public delegate void WriteDelegate(string entryName, Stream stream);
