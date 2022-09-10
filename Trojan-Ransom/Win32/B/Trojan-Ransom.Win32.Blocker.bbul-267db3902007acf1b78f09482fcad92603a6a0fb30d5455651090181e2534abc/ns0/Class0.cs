using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal static class Class0
{
	[STAThread]
	public static int Main(string[] args)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += smethod_0;
		int result = currentDomain.ExecuteAssemblyByName(new AssemblyName("w, version=0.0.0.0, culture=neutral, publickeytoken=null"), (Evidence)null, args);
		Class4.Class5.Class6.smethod_3();
		return result;
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly result = smethod_1(Convert.ToBase64String(Encoding.Default.GetBytes(resolveEventArgs_0.Name.ToLowerInvariant())));
		Class4.Class5.smethod_12();
		return result;
	}

	public static Assembly smethod_1(string string_0)
	{
		Assembly assembly;
		using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0))
		{
			if (stream != null)
			{
				int count = new BinaryReader(stream).ReadInt32();
				using DeflateStream input = new DeflateStream(stream, CompressionMode.Decompress);
				assembly = Assembly.Load(new BinaryReader(input).ReadBytes(count));
			}
			else
			{
				assembly = null;
			}
		}
		Assembly result = assembly;
		Class4.smethod_4();
		return result;
	}
}
