using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock = new object();

	private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

	private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

	private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

	private static int isAttached;

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

	private static Stream LoadStream(string fullName)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (fullName.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(fullName))
			{
				using DeflateStream source = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				CopyTo(source, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(fullName);
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
			text = requestedAssemblyName.CultureInfo!.Name + "." + text;
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

	public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
		lock (nullCacheLock)
		{
			if (nullCache.ContainsKey(e.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(e.Name);
		Assembly assembly = ReadExistingAssembly(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
		if ((object)assembly == null)
		{
			lock (nullCacheLock)
			{
				nullCache[e.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static AssemblyLoader()
	{
		assemblyNames.Add("costura", "costura.costura.dll.compressed");
		symbolNames.Add("costura", "costura.costura.pdb.compressed");
		assemblyNames.Add("discord-webhook-client", "costura.discord-webhook-client.dll.compressed");
		assemblyNames.Add("dotnetzip", "costura.dotnetzip.dll.compressed");
		symbolNames.Add("dotnetzip", "costura.dotnetzip.pdb.compressed");
		assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		assemblyNames.Add("notifique-me", "costura.notifique-me.dll.compressed");
		assemblyNames.Add("passwordgenerator", "costura.passwordgenerator.dll.compressed");
		assemblyNames.Add("polly", "costura.polly.dll.compressed");
		symbolNames.Add("polly", "costura.polly.pdb.compressed");
		assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
		assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
		assemblyNames.Add("system.net.http.formatting", "costura.system.net.http.formatting.dll.compressed");
		assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
	}

	public static void Attach()
	{
		if (Interlocked.Exchange(ref isAttached, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs e)
		{
			lock (nullCacheLock)
			{
				if (nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = ReadExistingAssembly(assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
			if ((object)assembly == null)
			{
				lock (nullCacheLock)
				{
					nullCache[e.Name] = true;
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
