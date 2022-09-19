using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B53EE5BDF_002DC925_002D45D0_002DBB4F_002D1DE255E331E5_007D;

namespace ns0;

[CompilerGenerated]
internal static class Class10
{
	private static object object_0 = new object();

	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	private static int int_0;

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_92();
		}
		return cultureInfo_0.Name;
	}

	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < assemblies.Length)
			{
				assembly = assemblies[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(smethod_0(name.CultureInfo), smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	private static Stream smethod_3(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_0.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_367()))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(string_0))
			{
				using DeflateStream stream_ = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				smethod_2(stream_, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(string_0);
	}

	private static Stream smethod_4(Dictionary<string, string> dictionary_3, string string_0)
	{
		if (dictionary_3.TryGetValue(string_0, out var value))
		{
			return smethod_3(value);
		}
		return null;
	}

	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_6(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name!.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo!.Name))
		{
			text = assemblyName_0.CultureInfo!.Name + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_368() + text;
		}
		byte[] rawAssembly;
		using (Stream stream = smethod_4(dictionary_3, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_5(stream);
		}
		using (Stream stream2 = smethod_4(dictionary_4, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_5(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly smethod_7(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		lock (object_0)
		{
			if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = smethod_1(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = smethod_6(dictionary_1, dictionary_2, assemblyName);
		if (assembly == null)
		{
			lock (object_0)
			{
				dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static Class10()
	{
		dictionary_1.Add(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_369(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_370());
		dictionary_1.Add(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_371(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_372());
	}

	public static void smethod_8()
	{
		if (Interlocked.Exchange(ref int_0, 1) == 1)
		{
			return;
		}
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_1, ResolveEventArgs resolveEventArgs_0)
		{
			lock (object_0)
			{
				if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
			Assembly assembly = smethod_1(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = smethod_6(dictionary_1, dictionary_2, assemblyName);
			if (assembly == null)
			{
				lock (object_0)
				{
					dictionary_0[resolveEventArgs_0.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		};
	}
}
