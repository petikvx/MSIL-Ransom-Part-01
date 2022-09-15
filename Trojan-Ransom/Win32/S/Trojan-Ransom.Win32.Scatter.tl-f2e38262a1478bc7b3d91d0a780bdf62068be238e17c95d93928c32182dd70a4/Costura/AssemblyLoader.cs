using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static readonly Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

	private static readonly Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

	private static readonly Dictionary<string, string> symbolNames = new Dictionary<string, string>();

	private static ResolveEventHandler CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	private static string CultureToString(CultureInfo culture)
	{
		if (culture == null)
		{
			return "";
		}
		return culture.Name;
	}

	private static Assembly ReadExistingAssembly(AssemblyName name)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(CultureToString(name2.CultureInfo), CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
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

	private static void CopyTo(Stream source, Stream destination)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = source.Read(array, 0, array.Length)) != 0)
		{
			destination.Write(array, 0, count);
		}
	}

	private static Stream LoadStream(string fullname)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (fullname.EndsWith(".zip"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(fullname))
			{
				using DeflateStream source = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				CopyTo(source, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(fullname);
	}

	private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
	{
		if (resourceNames.TryGetValue(name, out var value))
		{
			return LoadStream(value);
		}
		return null;
	}

	private static byte[] ReadStream(Stream stream)
	{
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
	{
		string text = requestedAssemblyName.Name!.ToLowerInvariant();
		if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo!.Name))
		{
			text = $"{requestedAssemblyName.CultureInfo!.Name}.{text}";
		}
		byte[] rawAssembly;
		using (Stream stream = LoadStream(assemblyNames, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = ReadStream(stream);
		}
		using (Stream stream2 = LoadStream(symbolNames, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = ReadStream(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly ResolveAssembly(string assemblyName)
	{
		if (nullCache.ContainsKey(assemblyName))
		{
			return null;
		}
		AssemblyName assemblyName2 = new AssemblyName(assemblyName);
		Assembly assembly = ReadExistingAssembly(assemblyName2);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName2);
		if ((object)assembly == null)
		{
			nullCache.Add(assemblyName, value: true);
			if (assemblyName2.Flags == AssemblyNameFlags.Retargetable)
			{
				assembly = Assembly.Load(assemblyName2);
			}
		}
		return assembly;
	}

	static AssemblyLoader()
	{
		assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.zip");
		assemblyNames.Add("websocket-sharp", "costura.websocket-sharp.dll.zip");
	}

	private static Assembly _003CAttach_003Eb__0(object s, ResolveEventArgs e)
	{
		return ResolveAssembly(e.Name);
	}

	public static void Attach()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += (object s, ResolveEventArgs e) => ResolveAssembly(e.Name);
	}
}
