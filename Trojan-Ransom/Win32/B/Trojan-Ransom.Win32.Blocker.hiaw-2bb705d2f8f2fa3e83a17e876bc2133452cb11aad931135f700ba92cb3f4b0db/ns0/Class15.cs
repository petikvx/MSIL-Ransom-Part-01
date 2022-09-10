using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace ns0;

internal sealed class Class15
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct3
	{
	}

	internal sealed class Class16
	{
		internal static AppDomain smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return AppDomain.CurrentDomain;
				case 67:
					return AppDomain.CurrentDomain;
				}
			}
		}

		internal static long smethod_1(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 51:
					return stream_0.Length;
				case 52:
					return stream_0.Length;
				}
			}
		}

		internal static byte[] smethod_2(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 72:
					return memoryStream_0.ToArray();
				case 73:
					return memoryStream_0.ToArray();
				}
			}
		}

		internal static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 12:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
			}
		}

		internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
			}
		}

		internal static string smethod_5(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					return resolveEventArgs_0.Name;
				}
			}
		}

		internal static string smethod_6(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 49:
					return assembly_0.Location;
				}
			}
		}
	}

	internal sealed class Class17
	{
		internal static Assembly smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 42:
					return Assembly.GetExecutingAssembly();
				case 43:
					return Assembly.GetExecutingAssembly();
				}
			}
		}

		internal static Stream smethod_1(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					return assembly_0.GetManifestResourceStream(string_0);
				case 99:
					return assembly_0.GetManifestResourceStream(string_0);
				}
			}
		}

		internal static void smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 6:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				case 7:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}

		internal static Assembly smethod_3(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 64:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				case 65:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}

		internal static void smethod_4(string string_0, byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 62:
					File.WriteAllBytes(string_0, byte_0);
					return;
				}
			}
		}

		internal static void smethod_5(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 61:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		internal static string smethod_6(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 88:
					return string_0 + string_1;
				}
			}
		}

		internal static Encoding smethod_7(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return Encoding.Default;
				case 111:
					return Encoding.ASCII;
				}
			}
		}

		internal static string smethod_8(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 84:
					return object_0.ToString();
				}
			}
		}

		internal static Type[] smethod_9(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return assembly_0.GetTypes();
				}
			}
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = "EEE2862BAA6DD389A3DE63CF51F2AC6CC49BE033";
		string text2 = text;
		string text3 = Class18.smethod_0(text2, '1', 167, 173);
		AppDomain appDomain = Class16.smethod_0(944, 1010);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class18.Class19.smethod_0(appDomain, text3, 948, 957);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Class18.smethod_1(appDomain, text3, dictionary, 197, 167);
			Assembly assembly_ = Class17.smethod_0(32, 10);
			Stream stream = Class17.smethod_1(assembly_, text, 1021, 927);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[Class16.smethod_1(stream, 373, 326) - 1L];
			int num = smethod_1(stream, 422, 466);
			smethod_2(stream, array, 0, array.Length, 741, 739);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = smethod_2(stream_, array2, 0, array2.Length, 698, 701)) > 0)
				{
					Class17.smethod_2(memoryStream, array2, 0, int_, 460, 458);
				}
			}
			assembly = Class17.smethod_3(Class16.smethod_2(memoryStream, 691, 763), null, smethod_3(assembly_, 644, 761), 90, 26);
			appDomain.SetData(text2, assembly);
			string[] manifestResourceNames = assembly.GetManifestResourceNames();
			foreach (string text4 in manifestResourceNames)
			{
				dictionary[text4] = text4;
			}
		}
		else
		{
			assembly = (Assembly)appDomain.GetData(text2);
		}
		if (dictionary.ContainsKey(resolveEventArgs_0.Name))
		{
			return assembly;
		}
		return null;
	}

	static Class15()
	{
		smethod_6();
		char_1 = new char[43];
		char[] array = new char[8];
		array[2] = '℅';
		array[6] = '㣰';
		array[0] = '㛺';
		array[1] = '\u0f94';
		array[4] = '㣿';
		array[7] = 'ᴈ';
		array[3] = '\u2e72';
		array[5] = 'ይ';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static int smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				return stream_0.ReadByte();
			case 117:
				return stream_0.ReadByte();
			}
		}
	}

	internal static int smethod_2(Stream stream_0, byte[] byte_1, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 6:
				return stream_0.Read(byte_1, int_0, int_1);
			case 7:
				return stream_0.Read(byte_1, int_0, int_1);
			case 8:
				return stream_0.Read(byte_1, int_0, int_1);
			}
		}
	}

	internal static Evidence smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return assembly_0.get_Evidence();
			case 126:
				return assembly_0.get_Evidence();
			}
		}
	}

	internal static MethodInfo[] smethod_4(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return type_0.GetMethods();
			}
		}
	}

	internal static string smethod_5(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Environment.GetFolderPath(specialFolder_0);
			}
		}
	}

	internal static void smethod_6()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class15))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += smethod_0;
			}
		}
	}
}
