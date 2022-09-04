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
		if (DateTime.Now > new DateTime(635217852116139784L))
		{
			throw new Exception();
		}
		if (DateTime.Now > new DateTime(635217525609146932L))
		{
			throw new Exception();
		}
		if (DateTime.Now > new DateTime(635217597534297324L))
		{
			throw new Exception();
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += smethod_0;
		return currentDomain.ExecuteAssemblyByName(new AssemblyName(Class1.smethod_0(Class3.smethod_0(Class5.smethod_0("\ue1c5\ue19e\ue192\ue1c4\ue1d7\ue1c0\ue1c1\ue1db\ue1dd\ue1dc\ue18f\ue182\ue19c\ue182\ue19c\ue182\ue19c\ue182\ue19e\ue192\ue1d1\ue1c7\ue1de\ue1c6\ue1c7\ue1c0\ue1d7\ue18f\ue1dc\ue1d7\ue1c7\ue1c6\ue1c0\ue1d3\ue1de\ue19e\ue192\ue1c2\ue1c7\ue1d0\ue1de\ue1db\ue1d1\ue1d9\ue1d7\ue1cb\ue1c6\ue1dd\ue1d9\ue1d7\ue1dc\ue18f\ue1dc\ue1c7\ue1de\ue1de", 58493), 61872), 62677)), (Evidence)null, args);
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
