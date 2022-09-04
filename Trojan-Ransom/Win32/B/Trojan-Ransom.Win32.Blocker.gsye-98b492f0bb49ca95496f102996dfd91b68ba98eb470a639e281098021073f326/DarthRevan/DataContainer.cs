using System.IO;
using System.Runtime.InteropServices;

namespace DarthRevan;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct DataContainer
{
	public static byte[] Data = null;

	public static MemoryStream MS = new MemoryStream();
}
