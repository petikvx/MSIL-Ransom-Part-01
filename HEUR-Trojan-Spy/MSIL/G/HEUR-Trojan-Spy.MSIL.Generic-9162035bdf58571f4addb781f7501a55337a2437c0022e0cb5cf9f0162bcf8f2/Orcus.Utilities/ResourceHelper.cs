using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace Orcus.Utilities;

public static class ResourceHelper
{
	public static void WriteGZippedResourceToFile(string filename, string resourceName)
	{
		Stream manifestResourceStream = Assembly.GetEntryAssembly()!.GetManifestResourceStream(resourceName);
		if (manifestResourceStream == null)
		{
			throw new FileNotFoundException();
		}
		using (manifestResourceStream)
		{
			using FileStream fileStream = new FileStream(filename, FileMode.Create);
			using GZipStream gZipStream = new GZipStream(manifestResourceStream, CompressionMode.Decompress);
			byte[] array = new byte[4096];
			int count;
			while ((count = gZipStream.Read(array, 0, array.Length)) > 0)
			{
				fileStream.Write(array, 0, count);
			}
		}
	}
}
