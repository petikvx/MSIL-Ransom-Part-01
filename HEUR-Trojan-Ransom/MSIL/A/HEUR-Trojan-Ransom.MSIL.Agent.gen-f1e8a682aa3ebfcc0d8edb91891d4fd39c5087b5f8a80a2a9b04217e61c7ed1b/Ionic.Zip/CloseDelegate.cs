using System.IO;

namespace Ionic.Zip;

public delegate void CloseDelegate(string entryName, Stream stream);
