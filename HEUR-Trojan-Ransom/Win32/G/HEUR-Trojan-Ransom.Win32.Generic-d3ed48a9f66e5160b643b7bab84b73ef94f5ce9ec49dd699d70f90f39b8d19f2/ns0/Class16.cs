using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns0;

[CompilerGenerated]
internal static class Class16
{
	private static readonly Dictionary<string, bool> dictionary_0 = Delegate161.smethod_0();

	private static readonly Dictionary<string, string> dictionary_1 = Delegate87.smethod_0();

	private static readonly Dictionary<string, string> dictionary_2 = Delegate87.smethod_0();

	private static ResolveEventHandler resolveEventHandler_0;

	static Class16()
	{
		Delegate164.smethod_0(dictionary_1, "newtonsoft.json", "costura.newtonsoft.json.dll.zip");
	}

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return Delegate231.smethod_0(cultureInfo_0);
	}

	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain object_ = Delegate238.smethod_0();
		Assembly[] array = Delegate93.smethod_0(object_);
		Assembly[] array2 = array;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array2.Length)
			{
				assembly = array2[num];
				AssemblyName object_2 = Delegate7.smethod_0(assembly);
				if (Delegate109.smethod_0(Delegate139.smethod_0(object_2), Delegate139.smethod_0(assemblyName_0), StringComparison.InvariantCultureIgnoreCase) && Delegate109.smethod_0(smethod_0(Delegate230.smethod_0(object_2)), smethod_0(Delegate230.smethod_0(assemblyName_0)), StringComparison.InvariantCultureIgnoreCase))
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
		int int_;
		while ((int_ = Delegate9.smethod_0(stream_0, array, 0, array.Length)) != 0)
		{
			Delegate70.smethod_0(stream_1, array, 0, int_);
		}
	}

	private static Stream smethod_3(string string_0)
	{
		Assembly object_ = Delegate214.smethod_0();
		if (Delegate185.smethod_0(string_0, ".zip"))
		{
			Stream stream = Delegate228.smethod_0(object_, string_0);
			try
			{
				DeflateStream deflateStream = Delegate75.smethod_0(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = Delegate224.smethod_0();
					smethod_2(deflateStream, memoryStream);
					Delegate57.smethod_0(memoryStream, 0L);
					return memoryStream;
				}
				finally
				{
					if (deflateStream != null)
					{
						Delegate133.smethod_0(deflateStream);
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					Delegate133.smethod_0(stream);
				}
			}
		}
		return Delegate228.smethod_0(object_, string_0);
	}

	private static Stream smethod_4(Dictionary<string, string> dictionary_3, string string_0)
	{
		string string_ = default(string);
		if (Delegate163.smethod_0(dictionary_3, string_0, ref string_))
		{
			return smethod_3(string_);
		}
		return null;
	}

	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[Delegate104.smethod_0(stream_0)];
		Delegate9.smethod_0(stream_0, array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_6(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string text = Delegate64.smethod_0(Delegate139.smethod_0(assemblyName_0));
		if (Delegate230.smethod_0(assemblyName_0) != null && !Delegate108.smethod_0(Delegate231.smethod_0(Delegate230.smethod_0(assemblyName_0))))
		{
			text = Delegate234.smethod_0("{0}.{1}", Delegate231.smethod_0(Delegate230.smethod_0(assemblyName_0)), text);
		}
		Stream stream = smethod_4(dictionary_3, text);
		byte[] byte_;
		try
		{
			if (stream == null)
			{
				return null;
			}
			byte_ = smethod_5(stream);
		}
		finally
		{
			if (stream != null)
			{
				Delegate133.smethod_0(stream);
			}
		}
		Stream stream2 = smethod_4(dictionary_4, text);
		try
		{
			if (stream2 != null)
			{
				byte[] byte_2 = smethod_5(stream2);
				return Delegate187.smethod_0(byte_, byte_2);
			}
		}
		finally
		{
			if (stream2 != null)
			{
				Delegate133.smethod_0(stream2);
			}
		}
		return Delegate178.smethod_0(byte_);
	}

	public static Assembly smethod_7(string string_0)
	{
		if (Delegate18.smethod_0(dictionary_0, string_0))
		{
			return null;
		}
		AssemblyName assemblyName = Delegate32.smethod_0(string_0);
		Assembly assembly = smethod_1(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_6(dictionary_1, dictionary_2, assemblyName);
		if ((object)assembly == null)
		{
			Delegate148.smethod_0(dictionary_0, string_0, bool_0: true);
			if (Delegate122.smethod_0(assemblyName) == AssemblyNameFlags.Retargetable)
			{
				assembly = Delegate58.smethod_0(assemblyName);
			}
		}
		return assembly;
	}

	private static Assembly smethod_8(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_7(Delegate183.smethod_0(resolveEventArgs_0));
	}

	public static void smethod_9()
	{
		AppDomain object_ = Delegate238.smethod_0();
		Delegate151.smethod_0(object_, (object object_0, ResolveEventArgs resolveEventArgs_0) => smethod_7(Delegate183.smethod_0(resolveEventArgs_0)));
	}
}
