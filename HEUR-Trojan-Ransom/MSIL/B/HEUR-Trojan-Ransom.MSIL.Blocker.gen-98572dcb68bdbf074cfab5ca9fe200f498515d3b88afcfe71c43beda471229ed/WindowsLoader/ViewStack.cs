using System.IO;

namespace WindowsLoader;

internal delegate FileStream ViewStack(string, FileMode, FileAccess);
