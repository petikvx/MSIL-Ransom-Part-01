using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;

namespace CompressedApp;

internal class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		ResourceManager resourceManager = new ResourceManager("resource", Assembly.GetExecutingAssembly());
		byte[] buffer = (byte[])resourceManager.GetObject("app");
		MemoryStream memoryStream = new MemoryStream(buffer);
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array = new byte[20480];
		gZipStream.Read(array, 0, 20480);
		memoryStream.Close();
		gZipStream.Close();
		Assembly assembly = Assembly.Load(array);
		array = null;
		GC.Collect();
		try
		{
			assembly.EntryPoint!.Invoke(null, new object[1] { args });
		}
		catch (Exception)
		{
			assembly.EntryPoint!.Invoke(null, new object[0]);
		}
	}
}
