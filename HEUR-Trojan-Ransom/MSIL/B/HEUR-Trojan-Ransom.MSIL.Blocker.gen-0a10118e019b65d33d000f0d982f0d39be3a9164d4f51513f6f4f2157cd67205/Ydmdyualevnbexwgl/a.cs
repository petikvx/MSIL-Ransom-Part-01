using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;

namespace Ydmdyualevnbexwgl;

internal static class a
{
	private static object m_a = new object();

	private static Dictionary<string, bool> b = new Dictionary<string, bool>();

	private static Dictionary<string, string> c;

	private static Dictionary<string, string> d;

	private static int e;

	private static a PatchException;

	static a()
	{
		while (true)
		{
			c = new Dictionary<string, string>();
			while (true)
			{
				d = new Dictionary<string, string>();
				c.Add("api", "costura.api.dll.compressed");
				while (true)
				{
					c.Add("costura", "costura.costura.dll.compressed");
					if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_367fd2cd69d548c7aad516ce908e3f8b == 0)
					{
						switch (1)
						{
						case 2:
							break;
						case 3:
							goto end_IL_0016;
						default:
							goto end_IL_004d;
						case 1:
							return;
						}
						continue;
					}
					return;
					continue;
					end_IL_0016:
					break;
				}
				continue;
				end_IL_004d:
				break;
			}
		}
	}

	private static string a(CultureInfo a)
	{
		if (a != null)
		{
			return a.Name;
		}
		return "";
	}

	private static Assembly a(AssemblyName a)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		Assembly assembly = default(Assembly);
		AssemblyName name = default(AssemblyName);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_17b16e782a9841fd844ed4e3fe44c70c == 0)
			{
				goto IL_0011;
			}
			goto IL_0084;
			IL_0084:
			switch (num2)
			{
			case 2:
				break;
			case 1:
				goto IL_0030;
			default:
				goto IL_005b;
			case 3:
			case 4:
				goto IL_0063;
			case 5:
				continue;
			}
			goto IL_0011;
			IL_0011:
			if (num >= assemblies.Length)
			{
				break;
			}
			assembly = assemblies[num];
			num2 = 1;
			if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_2baf2e72ee604324a183021e06625189 == 0)
			{
				goto IL_0030;
			}
			goto IL_0084;
			IL_005b:
			num++;
			goto IL_0011;
			IL_0030:
			name = assembly.GetName();
			if (string.Equals(name.Name, a.Name, StringComparison.InvariantCultureIgnoreCase))
			{
				goto IL_0063;
			}
			num2 = 0;
			if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_d99ccca5fe15447691b955ab14b23f77 == 0)
			{
				goto IL_005b;
			}
			goto IL_0084;
			IL_0063:
			if (string.Equals(Ydmdyualevnbexwgl.a.a(name.CultureInfo), Ydmdyualevnbexwgl.a.a((CultureInfo)DeleteException(a)), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
			goto IL_005b;
		}
		return null;
	}

	private static void a(Stream a, Stream b)
	{
		byte[] array = new byte[81920];
		int num = 1;
		if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_bd782dd6a5a746a3baf4a9dff57f3302 != 0)
		{
			goto IL_0033;
		}
		goto IL_0047;
		IL_0047:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_0033;
		}
		goto IL_001b;
		IL_0033:
		int count = default(int);
		if ((count = a.Read(array, 0, array.Length)) != 0)
		{
			goto IL_001b;
		}
		return;
		IL_001b:
		b.Write(array, 0, count);
		num = 0;
		if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_17b16e782a9841fd844ed4e3fe44c70c == 0)
		{
			goto IL_0033;
		}
		goto IL_0047;
	}

	private static Stream a(string a)
	{
		Assembly assembly = (Assembly)TestException();
		if (a.EndsWith(".compressed"))
		{
			using (Stream stream = assembly.GetManifestResourceStream(a))
			{
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_3aa42832d1be4608bd8b97315a2ff44b == 0)
					{
						switch (0)
						{
						}
					}
					ConcatException(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					return memoryStream;
				}
				finally
				{
					((IDisposable)deflateStream).Dispose();
				}
			}
		}
		return assembly.GetManifestResourceStream(a);
	}

	private static Stream a(Dictionary<string, string> a, string b)
	{
		if (a.TryGetValue(b, out var value))
		{
			return Ydmdyualevnbexwgl.a.a(value);
		}
		return null;
	}

	private static byte[] a(Stream a)
	{
		byte[] array = new byte[a.Length];
		a.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly a(Dictionary<string, string> a, Dictionary<string, string> b, AssemblyName c)
	{
		string text = c.Name!.ToLowerInvariant();
		if (c.CultureInfo != null && !string.IsNullOrEmpty(c.CultureInfo!.Name))
		{
			text = c.CultureInfo!.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = Ydmdyualevnbexwgl.a.a(a, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = Ydmdyualevnbexwgl.a.a(stream);
		}
		using (Stream stream2 = Ydmdyualevnbexwgl.a.a(b, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = Ydmdyualevnbexwgl.a.a(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly a(object a, ResolveEventArgs b)
	{
		object obj = Ydmdyualevnbexwgl.a.m_a;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			if (Ydmdyualevnbexwgl.a.b.ContainsKey(b.Name))
			{
				Assembly result = null;
				if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_0b7ce6d80b0c476fbafa1356bdc8cadb != 0)
				{
					return result;
				}
				switch (0)
				{
				case 1:
					break;
				default:
					return result;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				ResetException(obj);
			}
		}
		AssemblyName assemblyName = new AssemblyName((string)CallException(b));
		Assembly assembly = Ydmdyualevnbexwgl.a.a(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = Ydmdyualevnbexwgl.a.a(c, d, assemblyName);
		if (assembly == null)
		{
			lock (Ydmdyualevnbexwgl.a.m_a)
			{
				Ydmdyualevnbexwgl.a.b[b.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	public static void a()
	{
		if (Interlocked.Exchange(ref e, 1) != 1)
		{
			AppDomain.CurrentDomain.AssemblyResolve += a;
		}
	}

	internal static bool IncludeException()
	{
		return PatchException == null;
	}

	internal static a CountException()
	{
		return PatchException;
	}

	internal static object DeleteException(object object_0)
	{
		return ((AssemblyName)object_0).CultureInfo;
	}

	internal static object TestException()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static void ConcatException(object object_0, object object_1)
	{
		a((Stream)object_0, (Stream)object_1);
	}

	internal static void ResetException(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static object CallException(object object_0)
	{
		return ((ResolveEventArgs)object_0).Name;
	}
}
