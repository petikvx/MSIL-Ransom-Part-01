using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Policy;
using System.Text;

internal static class Class0
{
	[STAThread]
	public static int Main(string[] args)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += smethod_0;
		return currentDomain.ExecuteAssemblyByName(new AssemblyName("cqqjg5ic, version=0.0.0.0, culture=neutral, publickeytoken=null"), (Evidence)null, args);
	}

	public static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_1(Convert.ToBase64String(Encoding.Default.GetBytes(resolveEventArgs_0.Name.ToLowerInvariant())));
	}

	public static Assembly smethod_1(string string_0)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0);
		if (stream != null)
		{
			int count = new BinaryReader(stream).ReadInt32();
			using DeflateStream input = new DeflateStream(stream, CompressionMode.Decompress);
			return Assembly.Load(new BinaryReader(input).ReadBytes(count));
		}
		return null;
	}
}
