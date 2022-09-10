using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using ns5;

namespace ns2;

internal sealed class Class7
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
	private struct Struct15
	{
		static Struct15()
		{
			Class12.Class13.Class14.smethod_1();
		}
	}

	internal sealed class Class8
	{
		internal static void smethod_0(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 11:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}

		internal static byte[] smethod_1(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					return memoryStream_0.ToArray();
				}
			}
		}

		internal static Evidence smethod_2(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 82:
					return assembly_0.get_Evidence();
				}
			}
		}

		internal static Assembly smethod_3(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 51:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				case 52:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}

		internal static void smethod_4(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 64:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
			}
		}

		internal static string smethod_5(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 63:
					return process_0.MainWindowTitle;
				}
			}
		}

		internal static string smethod_6(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return encoding_0.GetString(byte_0);
				}
			}
		}

		internal static string smethod_7(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 99:
					return string_0.ToLower();
				}
			}
		}

		internal static void smethod_8(int int_0, int int_1, int int_2)
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 34:
					Thread.Sleep(int_0);
					return;
				}
			}
		}

		internal static object smethod_9(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return methodBase_0.Invoke(object_0, object_1);
				}
			}
		}

		internal static string smethod_10(string string_0, string string_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					return string_0 + string_1;
				}
			}
		}

		internal static bool smethod_11(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 3:
					return object.ReferenceEquals(object_0, object_1);
				}
			}
		}

		internal static void smethod_12(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				}
			}
		}

		static Class8()
		{
			Class12.Class13.Class14.smethod_1();
		}
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = "FD7F5A8C002FC32EE47A6D4F0692009D8056ACD9";
		string text2 = text;
		string text3 = smethod_1(text2, '1', 287, 368);
		AppDomain appDomain = Class9.Class10.Class11.smethod_0(49, 112);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class9.Class10.Class11.smethod_1(appDomain, text3, 342, 346);
		Assembly assembly;
		if (dictionary == null)
		{
			dictionary = new Dictionary<string, string>();
			Class9.Class10.Class11.smethod_2(appDomain, text3, dictionary, 916, 974);
			Assembly assembly_ = Class9.Class10.smethod_0(720, 670);
			Stream stream = Class9.Class10.Class11.smethod_3(assembly_, text, 397, 484);
			if (stream == null)
			{
				return null;
			}
			byte[] array = new byte[smethod_2(stream, 788, 805) - 1L];
			int num = Class9.smethod_0(stream, 641, 758);
			smethod_3(stream, array, 0, array.Length, 156, 228);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)((i + num) & 0xFF);
			}
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream stream_ = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
			{
				byte[] array2 = new byte[1024];
				int int_;
				while ((int_ = smethod_3(stream_, array2, 0, array2.Length, 482, 411)) > 0)
				{
					Class8.smethod_0(memoryStream, array2, 0, int_, 804, 815);
				}
			}
			assembly = Class8.smethod_3(Class8.smethod_1(memoryStream, 379, 319), null, Class8.smethod_2(assembly_, 223, 141), 348, 367);
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

	static Class7()
	{
		Class12.Class13.Class14.smethod_1();
		smethod_15();
		char_1 = new char[43];
		char[] array = new char[8];
		array[0] = '㦥';
		array[2] = '⟘';
		array[1] = '⫹';
		array[6] = 'ῤ';
		array[7] = '㸷';
		array[4] = '↞';
		array[3] = '㇙';
		array[5] = '◝';
		string_0 = new string[1];
		char_0 = array;
	}

	internal static string smethod_1(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 111:
				return string.Concat(object_0, object_1);
			case 112:
				return string.Concat(object_0, object_1);
			}
		}
	}

	internal static long smethod_2(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 49:
				return stream_0.Length;
			case 50:
				return stream_0.Length;
			}
		}
	}

	internal static int smethod_3(Stream stream_0, byte[] byte_1, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 120:
				return stream_0.Read(byte_1, int_0, int_1);
			case 121:
				return stream_0.Read(byte_1, int_0, int_1);
			case 122:
				return stream_0.Read(byte_1, int_0, int_1);
			}
		}
	}

	internal static long smethod_4(Stream stream_0, long long_0, SeekOrigin seekOrigin_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return stream_0.Seek(long_0, seekOrigin_0);
			}
		}
	}

	internal static void smethod_5(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				stream_0.Close();
				return;
			}
		}
	}

	internal static string smethod_6(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 30:
				return resolveEventArgs_0.Name;
			}
		}
	}

	internal static int smethod_7(string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				return string_1.Length;
			}
		}
	}

	internal static IntPtr smethod_8(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 58:
				return gchandle_0.AddrOfPinnedObject();
			}
		}
	}

	internal static string smethod_9(string string_1, string string_2, string string_3, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 30:
				return string_1.Replace(string_2, string_3);
			}
		}
	}

	internal static void smethod_10(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 95:
				appDomain_0.AssemblyResolve += resolveEventHandler_0;
				return;
			}
		}
	}

	internal static bool smethod_11(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 98:
				return process_0.CloseMainWindow();
			}
		}
	}

	internal static Process[] smethod_12(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				return Process.GetProcesses();
			}
		}
	}

	internal static int smethod_13(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				return stream_0.ReadByte();
			}
		}
	}

	internal static uint smethod_14(uint uint_0, uint uint_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 37:
				return Math.Max(uint_0, uint_1);
			case 38:
				return Math.Min(uint_0, uint_1);
			}
		}
	}

	internal static void smethod_15()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class7))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += smethod_0;
			}
		}
	}
}
