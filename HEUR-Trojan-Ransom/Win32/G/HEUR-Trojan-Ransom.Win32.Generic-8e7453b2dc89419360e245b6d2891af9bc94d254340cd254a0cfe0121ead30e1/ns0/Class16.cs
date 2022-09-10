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
	private static readonly Dictionary<string, bool> dictionary_0 = Delegate190.smethod_0();

	private static readonly Dictionary<string, string> dictionary_1 = Delegate218.smethod_0();

	private static readonly Dictionary<string, string> dictionary_2 = Delegate218.smethod_0();

	private static ResolveEventHandler resolveEventHandler_0;

	static Class16()
	{
		Delegate121.smethod_0(dictionary_1, "newtonsoft.json", "costura.newtonsoft.json.dll.zip");
	}

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return Delegate187.smethod_0(cultureInfo_0);
	}

	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain object_ = Delegate106.smethod_0();
		Assembly[] array = Delegate98.smethod_0(object_);
		Assembly[] array2 = array;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array2.Length)
			{
				assembly = array2[num];
				AssemblyName object_2 = Delegate119.smethod_0(assembly);
				if (Delegate68.smethod_0(Delegate130.smethod_0(object_2), Delegate130.smethod_0(assemblyName_0), StringComparison.InvariantCultureIgnoreCase) && Delegate68.smethod_0(smethod_0(Delegate170.smethod_0(object_2)), smethod_0(Delegate170.smethod_0(assemblyName_0)), StringComparison.InvariantCultureIgnoreCase))
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
		while ((int_ = Delegate150.smethod_0(stream_0, array, 0, array.Length)) != 0)
		{
			Delegate163.smethod_0(stream_1, array, 0, int_);
		}
	}

	private static Stream smethod_3(string string_0)
	{
		Assembly object_ = Delegate125.smethod_0();
		if (Delegate13.smethod_0(string_0, ".zip"))
		{
			Stream stream = Delegate164.smethod_0(object_, string_0);
			try
			{
				DeflateStream deflateStream = Delegate193.smethod_0(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = Delegate120.smethod_0();
					smethod_2(deflateStream, memoryStream);
					Delegate53.smethod_0(memoryStream, 0L);
					return memoryStream;
				}
				finally
				{
					if (deflateStream != null)
					{
						Delegate27.smethod_0(deflateStream);
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					Delegate27.smethod_0(stream);
				}
			}
		}
		return Delegate164.smethod_0(object_, string_0);
	}

	private static Stream smethod_4(Dictionary<string, string> dictionary_3, string string_0)
	{
		string string_ = default(string);
		if (Delegate36.smethod_0(dictionary_3, string_0, ref string_))
		{
			return smethod_3(string_);
		}
		return null;
	}

	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[Delegate157.smethod_0(stream_0)];
		Delegate150.smethod_0(stream_0, array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_6(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string text = Delegate32.smethod_0(Delegate130.smethod_0(assemblyName_0));
		if (Delegate170.smethod_0(assemblyName_0) != null && !Delegate19.smethod_0(Delegate187.smethod_0(Delegate170.smethod_0(assemblyName_0))))
		{
			text = Delegate21.smethod_0("{0}.{1}", Delegate187.smethod_0(Delegate170.smethod_0(assemblyName_0)), text);
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
				Delegate27.smethod_0(stream);
			}
		}
		Stream stream2 = smethod_4(dictionary_4, text);
		try
		{
			if (stream2 != null)
			{
				byte[] byte_2 = smethod_5(stream2);
				return Delegate167.smethod_0(byte_, byte_2);
			}
		}
		finally
		{
			if (stream2 != null)
			{
				Delegate27.smethod_0(stream2);
			}
		}
		return Delegate203.smethod_0(byte_);
	}

	public static Assembly smethod_7(string string_0)
	{
		if (Delegate238.smethod_0(dictionary_0, string_0))
		{
			return null;
		}
		AssemblyName assemblyName = Delegate137.smethod_0(string_0);
		Assembly assembly = smethod_1(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_6(dictionary_1, dictionary_2, assemblyName);
		if ((object)assembly == null)
		{
			Delegate28.smethod_0(dictionary_0, string_0, bool_0: true);
			if (Delegate87.smethod_0(assemblyName) == AssemblyNameFlags.Retargetable)
			{
				assembly = Delegate240.smethod_0(assemblyName);
			}
		}
		return assembly;
	}

	private static Assembly smethod_8(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_7(Delegate46.smethod_0(resolveEventArgs_0));
	}

	public static void smethod_9()
	{
		AppDomain object_ = Delegate106.smethod_0();
		Delegate8.smethod_0(object_, (object object_0, ResolveEventArgs resolveEventArgs_0) => smethod_7(Delegate46.smethod_0(resolveEventArgs_0)));
	}
}
