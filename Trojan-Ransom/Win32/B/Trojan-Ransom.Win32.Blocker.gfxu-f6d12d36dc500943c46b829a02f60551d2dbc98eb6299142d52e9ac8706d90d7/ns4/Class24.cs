using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns5;
using ns6;

namespace ns4;

internal class Class24
{
	static int smethod_0(Class17.Class19 class19_0, int int_0)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (int_0 >= 4)
			{
				num += 2;
				int_0 >>= 1;
			}
			return num + int_0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)class19_0, (object)int_0);
			throw;
		}
	}

	static string smethod_1(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					num = 6;
					return Path.GetTempPath();
				}
				num = 0;
				num = 4;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static Encoding smethod_2(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 96:
					num = 3;
					return Encoding.UTF8;
				}
				num = 7;
				num = 0;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static Assembly smethod_3(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 7;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 68:
					num = 5;
					num2 = 2;
					break;
				default:
					num = 0;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 11;
				switch (num3)
				{
				default:
					num = 12;
					goto IL_003a;
				case 1:
					num = 12;
					goto IL_003a;
				case 4:
					num = 2;
					num3 = 3;
					num = 11;
					goto IL_0051;
				case 6:
					num = 3;
					num3 = 3;
					num = 11;
					goto IL_0051;
				case 3:
					goto IL_0051;
				case 0:
					num = 4;
					break;
				case 2:
					num = 4;
					break;
				case 5:
					num = 4;
					break;
				case 7:
					{
						num = 4;
						break;
					}
					IL_003a:
					num3 = 3;
					num = 11;
					goto IL_0051;
				}
				break;
				IL_0051:
				num = 7;
			}
			return Class24.smethod_47(byte_0, byte_1, evidence_0, 132, 157);
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num3, (object)num, (object)byte_0, (object)byte_1, (object)evidence_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_4(Class17.Class19.Class20 class20_0, Class17.Class19.Class20 class20_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			num = -1;
			num2 = 0;
			while (num2 < class20_0.int_1)
			{
				num3 = 1;
				num4 = class20_0.byte_0[num2];
				if (num4 == 0)
				{
					num5 = 138;
					num6 = 3;
				}
				else
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						class20_1.short_0[num4]++;
						num3 = 0;
					}
				}
				num = num4;
				num2++;
				while (num2 < class20_0.int_1 && num == class20_0.byte_0[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					class20_1.short_0[num] += (short)num3;
				}
				else if (num != 0)
				{
					class20_1.short_0[16]++;
				}
				else if (num3 <= 10)
				{
					class20_1.short_0[17]++;
				}
				else
				{
					class20_1.short_0[18]++;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_70(exception_, (object)num5, (object)num6, (object)num3, (object)num, (object)num2, (object)num4, (object)class20_0, (object)class20_1);
			throw;
		}
	}

	static byte[] smethod_5(int int_0, byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		Class17.Stream0 stream = default(Class17.Stream0);
		Class17.Class18 class2 = default(Class17.Class18);
		DateTime now = default(DateTime);
		long num3 = default(long);
		uint[] array8 = default(uint[]);
		uint num4 = default(uint);
		uint num5 = default(uint);
		int num6 = default(int);
		int num7 = default(int);
		long position3 = default(long);
		byte[] bytes = default(byte[]);
		byte[] array9 = default(byte[]);
		int num8 = default(int);
		byte[] array10 = default(byte[]);
		int num9 = default(int);
		long num10 = default(long);
		int i = default(int);
		byte[] array5 = default(byte[]);
		long position = default(long);
		Class17.Class18 @class = default(Class17.Class18);
		byte[] array6 = default(byte[]);
		int num = default(int);
		byte[] array7 = default(byte[]);
		int num2 = default(int);
		long position2 = default(long);
		byte[] array3 = default(byte[]);
		ICryptoTransform cryptoTransform2 = default(ICryptoTransform);
		byte[] array4 = default(byte[]);
		byte[] array = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		byte[] array2 = default(byte[]);
		byte[] array11 = default(byte[]);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				stream = new Class17.Stream0();
				switch (int_0)
				{
				case 0:
					class2 = new Class17.Class18();
					now = DateTime.Now;
					num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
					array8 = new uint[256]
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
					num4 = uint.MaxValue;
					num5 = uint.MaxValue;
					num6 = 0;
					num7 = byte_2.Length;
					while (--num7 >= 0)
					{
						num5 = array8[(num5 ^ byte_2[num6++]) & 0xFF] ^ (num5 >> 8);
					}
					num5 ^= num4;
					Class24.smethod_98(stream, 67324752);
					Class24.smethod_178(stream, 20);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 8);
					Class24.smethod_98(stream, (int)num3);
					Class24.smethod_98(stream, (int)num5);
					position3 = stream.Position;
					Class24.smethod_98(stream, 0);
					Class24.smethod_98(stream, byte_2.Length);
					bytes = Encoding.UTF8.GetBytes("{data}");
					Class24.smethod_178(stream, bytes.Length);
					Class24.smethod_178(stream, 0);
					stream.Write(bytes, 0, bytes.Length);
					Class24.smethod_45(class2, byte_2);
					while (!Class24.smethod_85(class2))
					{
						array9 = new byte[512];
						num8 = Class24.smethod_170(array9, class2);
						if (num8 <= 0)
						{
							break;
						}
						stream.Write(array9, 0, num8);
					}
					Class24.smethod_166(class2);
					while (!Class24.smethod_13(class2))
					{
						array10 = new byte[512];
						num9 = Class24.smethod_170(array10, class2);
						if (num9 <= 0)
						{
							break;
						}
						stream.Write(array10, 0, num9);
					}
					num10 = Class24.smethod_52(class2);
					Class24.smethod_98(stream, 33639248);
					Class24.smethod_178(stream, 20);
					Class24.smethod_178(stream, 20);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 8);
					Class24.smethod_98(stream, (int)num3);
					Class24.smethod_98(stream, (int)num5);
					Class24.smethod_98(stream, (int)num10);
					Class24.smethod_98(stream, byte_2.Length);
					Class24.smethod_178(stream, bytes.Length);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 0);
					Class24.smethod_98(stream, 0);
					Class24.smethod_98(stream, 0);
					stream.Write(bytes, 0, bytes.Length);
					Class24.smethod_98(stream, 101010256);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 0);
					Class24.smethod_178(stream, 1);
					Class24.smethod_178(stream, 1);
					Class24.smethod_98(stream, 46 + bytes.Length);
					Class24.smethod_98(stream, (int)(30 + bytes.Length + num10));
					Class24.smethod_178(stream, 0);
					stream.Seek(position3, SeekOrigin.Begin);
					Class24.smethod_98(stream, (int)num10);
					break;
				case 1:
					Class24.smethod_98(stream, 25000571);
					Class24.smethod_98(stream, byte_2.Length);
					for (i = 0; i < byte_2.Length; i += array5.Length)
					{
						array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
						Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
						position = stream.Position;
						Class24.smethod_98(stream, 0);
						Class24.smethod_98(stream, array5.Length);
						@class = new Class17.Class18();
						Class24.smethod_45(@class, array5);
						while (!Class24.smethod_85(@class))
						{
							array6 = new byte[512];
							num = Class24.smethod_170(array6, @class);
							if (num <= 0)
							{
								break;
							}
							stream.Write(array6, 0, num);
						}
						Class24.smethod_166(@class);
						while (!Class24.smethod_13(@class))
						{
							array7 = new byte[512];
							num2 = Class24.smethod_170(array7, @class);
							if (num2 <= 0)
							{
								break;
							}
							stream.Write(array7, 0, num2);
						}
						position2 = stream.Position;
						stream.Position = position;
						Class24.smethod_98(stream, (int)Class24.smethod_52(@class));
						stream.Position = position2;
					}
					break;
				case 2:
					Class24.smethod_98(stream, 41777787);
					array3 = Class24.smethod_5(1, (byte[])null, (byte[])null, byte_2);
					cryptoTransform2 = Class24.smethod_189(byte_0, byte_1, bool_0: false);
					try
					{
						array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
						stream.Write(array4, 0, array4.Length);
					}
					finally
					{
						cryptoTransform2?.Dispose();
					}
					break;
				case 3:
					Class24.smethod_98(stream, 58555003);
					array = Class24.smethod_5(1, (byte[])null, (byte[])null, byte_2);
					cryptoTransform = Class24.smethod_84(byte_0, byte_1, bool_0: false);
					try
					{
						array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
						stream.Write(array2, 0, array2.Length);
					}
					finally
					{
						cryptoTransform?.Dispose();
					}
					break;
				}
				stream.Flush();
				stream.Close();
				array11 = stream.ToArray();
				return array11;
			}
			catch (Exception ex)
			{
				ex2 = ex;
				Class17.string_0 = "ERR 2003: " + ex2.Message;
				throw;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[37]
			{
				stream, class2, now, num3, array8, num4, num5, num6, num7, position3,
				bytes, array9, num8, array10, num9, num10, i, array5, position, @class,
				array6, num, array7, num2, position2, array3, cryptoTransform2, array4, array, cryptoTransform,
				array2, ex2, array11, byte_2, int_0, byte_1, byte_0
			});
			throw;
		}
	}

	static void smethod_6(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class24.smethod_24(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static Class35 smethod_7()
	{
		if (Class35.class35_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class35))
				{
					continue;
				}
				try
				{
					Class35.class35_0 = (Class35)Activator.CreateInstance(type, nonPublic: true);
					if (Class35.class35_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class35.class35_0;
	}

	static void smethod_8(Class17.Class19.Class20 class20_0, Class17.Class19.Class20 class20_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			num = -1;
			num2 = 0;
			while (num2 < class20_0.int_1)
			{
				num3 = 1;
				num4 = class20_0.byte_0[num2];
				if (num4 == 0)
				{
					num5 = 138;
					num6 = 3;
				}
				else
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						Class24.smethod_125(class20_1, num4);
						num3 = 0;
					}
				}
				num = num4;
				num2++;
				while (num2 < class20_0.int_1 && num == class20_0.byte_0[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					while (num3-- > 0)
					{
						Class24.smethod_125(class20_1, num);
					}
				}
				else if (num != 0)
				{
					Class24.smethod_125(class20_1, 16);
					Class24.smethod_148(class20_0.class19_0.class22_0, num3 - 3, 2);
				}
				else if (num3 <= 10)
				{
					Class24.smethod_125(class20_1, 17);
					Class24.smethod_148(class20_0.class19_0.class22_0, num3 - 3, 3);
				}
				else
				{
					Class24.smethod_125(class20_1, 18);
					Class24.smethod_148(class20_0.class19_0.class22_0, num3 - 11, 7);
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_70(exception_, (object)num5, (object)num6, (object)num3, (object)num, (object)num2, (object)num4, (object)class20_0, (object)class20_1);
			throw;
		}
	}

	static void smethod_9(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class24.smethod_24(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static Bitmap smethod_10(string string_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static string[] smethod_11(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					num = 6;
					return assembly_0.GetManifestResourceNames();
				}
				num = 5;
				num = 7;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)assembly_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static AppDomain smethod_12(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 9;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 24:
					num = 12;
					num2 = 2;
					break;
				default:
					num = 2;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 3;
				switch (num3)
				{
				default:
					num = 10;
					goto IL_0044;
				case 0:
					num = 11;
					goto IL_0055;
				case 1:
					num = 6;
					goto IL_004c;
				case 3:
					num = 10;
					goto IL_0044;
				case 4:
					num = 6;
					goto IL_004c;
				case 7:
					num = 11;
					goto IL_0055;
				case 5:
					goto IL_0059;
				case 2:
					num = 7;
					break;
				case 6:
					{
						num = 7;
						break;
					}
					IL_004c:
					num3 = 5;
					num = 3;
					goto IL_0059;
					IL_0055:
					num3 = 5;
					num = 3;
					goto IL_0059;
					IL_0044:
					num3 = 5;
					num = 3;
					goto IL_0059;
				}
				break;
				IL_0059:
				num = 9;
			}
			return Class24.smethod_58(820, 826);
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num3, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_13(Class17.Class18 class18_0)
	{
		try
		{
			if (class18_0.int_0 == 30)
			{
				return Class24.smethod_18(class18_0.class22_0);
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class18_0);
			throw;
		}
	}

	static void smethod_14(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 1;
			num2 = 3;
			num = 4;
			while (true)
			{
				num = 8;
				while (true)
				{
					int num3;
					switch (int_3 ^ int_2)
					{
					case 12:
						num = 6;
						num3 = 4;
						break;
					default:
						num = 9;
						num3 = 2;
						break;
					}
					num2 = num3;
					num = 4;
					switch (num2)
					{
					default:
						goto IL_002d;
					case 2:
						num = 3;
						num2 = 3;
						num = 4;
						break;
					case 3:
						break;
					case 0:
						num = 2;
						goto IL_005e;
					case 1:
						num = 2;
						goto IL_005e;
					case 4:
						num = 2;
						goto IL_005e;
					case 5:
						{
							num = 7;
							return;
						}
						IL_005e:
						Class24.smethod_88(stream_0, byte_0, int_0, int_1, 159, 173);
						return;
					}
					break;
					IL_002d:
					num = 8;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_123(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)stream_0, (object)byte_0, (object)int_0, (object)int_1, (object)int_2, (object)int_3);
			throw;
		}
	}

	static Assembly smethod_15(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					num = 7;
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
				num = 2;
				num = 0;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num, (object)byte_0, (object)byte_1, (object)evidence_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static int smethod_16(Class27.Struct9 struct9_0, Class27 class27_0)
	{
		string key = struct9_0.struct8_0.string_0.ToUpper();
		if (class27_0.dictionary_3.ContainsKey(key))
		{
			return class27_0.dictionary_3[key];
		}
		int count = class27_0.list_2.Count;
		class27_0.list_2.Add(struct9_0.struct8_0);
		class27_0.dictionary_3.Add(key, count);
		return count;
	}

	static void smethod_17()
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Type type = default(Type);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		try
		{
			num = 13;
			num2 = 1;
			num = 3;
			while (true)
			{
				num = 4;
				while (true)
				{
					num3 = 0;
					num2 = 3;
					num = 3;
					while (true)
					{
						num = 2;
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 4:
								num = 9;
								num4 = 0;
								break;
							case 3:
								num = 5;
								num4 = 0;
								break;
							case 2:
								num = 8;
								num4 = 0;
								break;
							case 1:
								num = 11;
								num4 = 5;
								break;
							case 0:
								num = 7;
								num4 = 5;
								break;
							default:
								num = 10;
								num4 = 5;
								break;
							}
							num2 = num4;
							num = 3;
							switch (num2)
							{
							case 7:
								break;
							case 2:
								num = 14;
								goto IL_007f;
							case 5:
								num = 14;
								goto IL_007f;
							case 6:
								num = 1;
								num3 = 3;
								num2 = 3;
								num = 3;
								goto end_IL_005b;
							case 3:
								goto end_IL_005b;
							default:
								goto end_IL_0097;
							case 1:
								goto end_IL_009d;
							case 0:
								num = 15;
								goto IL_00b1;
							case 4:
								{
									num = 15;
									goto IL_00b1;
								}
								IL_00b1:
								Class24.smethod_33((object)(type = Class24.smethod_86(typeof(Class5).TypeHandle, 202, 179)), 308, 278);
								try
								{
									num5 = 18;
									num6 = 5;
									num5 = 22;
									while (true)
									{
										num5 = 15;
										while (true)
										{
											num7 = 1;
											num6 = 2;
											num5 = 22;
											num5 = 4;
											while (true)
											{
												IL_01ff:
												num5 = 23;
												int num8 = 7;
												while (true)
												{
													IL_01f4:
													num6 = num8;
													num5 = 22;
													while (true)
													{
														int num9;
														switch (num6)
														{
														case 7:
														{
															num5 = 10;
															int num10;
															if (!Class5.bool_0)
															{
																num5 = 13;
																num10 = 8;
															}
															else
															{
																num5 = 17;
																num10 = 0;
															}
															num6 = num10;
															num5 = 22;
															continue;
														}
														case 0:
															num5 = 16;
															num9 = 4;
															goto IL_0157;
														case 3:
															num5 = 9;
															goto IL_019f;
														case 4:
															num5 = 6;
															goto IL_01a5;
														case 6:
															num5 = 7;
															goto IL_0175;
														case 8:
															num5 = 12;
															num9 = 2;
															goto IL_0157;
														case 9:
															num5 = 11;
															goto IL_016c;
														case 10:
															num5 = 11;
															goto IL_016c;
														case 2:
															num5 = 4;
															switch (num7)
															{
															default:
																num5 = 2;
																num8 = 7;
																goto IL_01f4;
															case 0:
																num5 = 20;
																num8 = 1;
																goto IL_01f4;
															case 2:
																num5 = 8;
																num8 = 9;
																goto IL_01f4;
															case 3:
																num5 = 1;
																num8 = 9;
																goto IL_01f4;
															case 4:
																num5 = 0;
																num8 = 1;
																goto IL_01f4;
															case 5:
																num5 = 19;
																num8 = 3;
																goto IL_01f4;
															case 1:
																break;
															}
															goto IL_01ff;
														case 5:
															goto end_IL_020a;
														case 1:
															{
																num5 = 14;
																goto end_IL_0219;
															}
															IL_016c:
															Class5.bool_0 = true;
															num5 = 7;
															goto IL_0175;
															IL_0175:
															Class24.smethod_177(Class24.smethod_58(816, 830), (ResolveEventHandler)Class24.smethod_185, 582, 576);
															goto IL_019f;
															IL_019f:
															num7 = 4;
															num5 = 6;
															goto IL_01a5;
															IL_01a5:
															num6 = 2;
															num5 = 22;
															goto case 2;
															IL_0157:
															num7 = num9;
															num6 = 2;
															num5 = 22;
															goto case 2;
														}
														break;
													}
													break;
												}
												break;
											}
											num5 = 15;
											continue;
											end_IL_020a:
											break;
										}
										continue;
										end_IL_0219:
										break;
									}
								}
								finally
								{
									Class24.smethod_33((object)type, 86, 117);
								}
								num11 = 14;
								num12 = 4;
								num11 = 13;
								while (true)
								{
									num11 = 0;
									while (true)
									{
										num13 = 5;
										num12 = 6;
										num11 = 13;
										while (true)
										{
											num11 = 15;
											while (true)
											{
												int num14;
												switch (num13)
												{
												case 5:
													num11 = 16;
													num14 = 2;
													break;
												case 4:
													num11 = 8;
													num14 = 2;
													break;
												case 3:
													num11 = 5;
													num14 = 2;
													break;
												case 2:
													num11 = 2;
													num14 = 2;
													break;
												case 1:
													num11 = 9;
													num14 = 0;
													break;
												case 0:
													num11 = 3;
													num14 = 5;
													break;
												default:
													num11 = 7;
													num14 = 2;
													break;
												}
												num12 = num14;
												num11 = 13;
												switch (num12)
												{
												case 7:
													break;
												case 0:
													num11 = 11;
													goto IL_02e0;
												case 1:
													num11 = 11;
													goto IL_02e0;
												case 2:
													num11 = 12;
													num13 = 0;
													num12 = 6;
													num11 = 13;
													goto end_IL_029f;
												case 3:
													num11 = 11;
													goto IL_02e0;
												case 6:
													goto end_IL_029f;
												default:
													goto end_IL_02ea;
												case 4:
													goto end_IL_02f3;
												case 5:
													{
														num11 = 6;
														return;
													}
													IL_02e0:
													num13 = 0;
													num12 = 6;
													num11 = 13;
													goto end_IL_029f;
												}
												num11 = 15;
												continue;
												end_IL_029f:
												break;
											}
											continue;
											end_IL_02ea:
											break;
										}
										num11 = 0;
										continue;
										end_IL_02f3:
										break;
									}
								}
								IL_007f:
								if (!Class5.bool_0)
								{
									num = 0;
									num2 = 6;
									num = 3;
									goto case 6;
								}
								return;
							}
							num = 2;
							continue;
							end_IL_005b:
							break;
						}
						continue;
						end_IL_0097:
						break;
					}
					num = 4;
					continue;
					end_IL_009d:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num15 = default(int);
			int num16 = default(int);
			Class24.smethod_24(exception_, new object[12]
			{
				type, num3, num7, num13, num2, num6, num12, num15, num, num5,
				num11, num16
			});
			throw;
		}
	}

	static bool smethod_18(Class17.Class22 class22_0)
	{
		try
		{
			return class22_0.int_1 == 0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class22_0);
			throw;
		}
	}

	static byte[] smethod_19(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 4;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 26:
					num = 11;
					num2 = 1;
					break;
				default:
					num = 7;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 3;
				switch (num3)
				{
				default:
					num = 0;
					goto IL_004d;
				case 3:
					num = 9;
					num3 = 2;
					num = 3;
					goto IL_0051;
				case 5:
					num = 0;
					goto IL_004d;
				case 6:
					num = 6;
					num3 = 2;
					num = 3;
					goto IL_0051;
				case 7:
					num = 0;
					goto IL_004d;
				case 2:
					goto IL_0051;
				case 0:
					num = 10;
					break;
				case 1:
					num = 10;
					break;
				case 4:
					{
						num = 10;
						break;
					}
					IL_004d:
					num3 = 2;
					num = 3;
					goto IL_0051;
				}
				break;
				IL_0051:
				num = 4;
			}
			return Class24.smethod_57(memoryStream_0, 165, 133);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)memoryStream_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_20(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class35.string_0 == "1") || !Class24.smethod_7().method_2((SecurityException)exception_0))
		{
			Class24.smethod_24(exception_0, object_0);
			Class24.smethod_7().method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_21(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class24.smethod_24(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static bool smethod_22(Class17.Class21 class21_0)
	{
		try
		{
			return class21_0.int_8 == class21_0.int_7;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class21_0);
			throw;
		}
	}

	static void smethod_23(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 2;
			num2 = 0;
			num = 5;
			while (true)
			{
				num = 7;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 97:
						num = 0;
						num3 = 3;
						break;
					default:
						num = 8;
						num3 = 5;
						break;
					}
					num2 = num3;
					num = 5;
					switch (num2)
					{
					default:
						goto IL_002d;
					case 1:
						num = 9;
						goto IL_0050;
					case 5:
						num = 9;
						goto IL_0050;
					case 0:
						break;
					case 2:
						num = 1;
						goto IL_0062;
					case 3:
						num = 1;
						goto IL_0062;
					case 4:
						{
							num = 1;
							goto IL_0062;
						}
						IL_0062:
						Class24.smethod_96(appDomain_0, string_0, object_0, 776, 839);
						return;
						IL_0050:
						num2 = 0;
						num = 5;
						break;
					}
					break;
					IL_002d:
					num = 7;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_26(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)appDomain_0, (object)string_0, object_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_24(Exception exception_0, object[] object_0)
	{
		int int_ = -1;
		int int_2 = -1;
		int num = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Length > 0)
					{
						num++;
					}
				}
			}
		}
		catch
		{
			num = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				int_ = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				int_2 = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(int_, object_0, int_2, num);
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

	static short smethod_25(int int_0)
	{
		try
		{
			return (short)((Class17.Class19.byte_0[int_0 & 0xF] << 12) | (Class17.Class19.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class17.Class19.byte_0[(int_0 >> 8) & 0xF] << 4) | Class17.Class19.byte_0[int_0 >> 12]);
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)int_0);
			throw;
		}
	}

	static void smethod_26(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class24.smethod_24(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static bool smethod_27(string string_0, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class24.smethod_136(eventArgs1_0.class27_0, string_0);
	}

	static void smethod_28(Class17.Class19 class19_0)
	{
		try
		{
			class19_0.int_1 = 0;
			class19_0.int_2 = 0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class19_0);
			throw;
		}
	}

	static byte[] smethod_29(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class25.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
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
					Class25.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
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
			Class25.string_0 = "ERR 2004: " + ex3.Message;
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

	[DllImport("kernel32.dll")]
	internal static extern void GetSystemInfo(ref Class38.Struct12 struct12_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_30(Class35 class35_0)
	{
		if (class35_0 != null)
		{
			Class35.class35_0 = class35_0;
			AppDomain.CurrentDomain.UnhandledException += class35_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class35_0.method_0);
		}
	}

	static int smethod_31(Class17.Class22 class22_0)
	{
		try
		{
			return class22_0.int_2;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class22_0);
			throw;
		}
	}

	static Assembly smethod_32(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 6;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 79:
					num = 12;
					num2 = 7;
					break;
				default:
					num = 5;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 3;
				switch (num3)
				{
				default:
					num = 0;
					goto IL_0038;
				case 2:
					num = 0;
					goto IL_0038;
				case 4:
					num = 10;
					num3 = 3;
					num = 3;
					goto case 3;
				case 5:
					num = 9;
					num3 = 3;
					num = 3;
					goto case 3;
				case 3:
					num = 6;
					continue;
				case 6:
					num = 6;
					continue;
				case 0:
					num = 11;
					break;
				case 1:
					num = 11;
					break;
				case 7:
					{
						num = 11;
						break;
					}
					IL_0038:
					num3 = 3;
					num = 3;
					goto case 3;
				}
				break;
			}
			return Class24.smethod_192(643, 739);
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num3, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_33(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 6;
			num2 = 4;
			num = 0;
			while (true)
			{
				num = 9;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 34:
						num = 1;
						num3 = 2;
						break;
					default:
						num = 8;
						num3 = 3;
						break;
					case 35:
						Monitor.Exit(object_0);
						return;
					}
					num2 = num3;
					num = 0;
					switch (num2)
					{
					default:
						num = 9;
						continue;
					case 0:
						num = 9;
						continue;
					case 1:
						num = 9;
						continue;
					case 5:
						num = 9;
						continue;
					case 3:
						num = 5;
						num2 = 4;
						num = 0;
						break;
					case 4:
						break;
					case 2:
						num = 7;
						Class24.smethod_120(object_0, 316, 356);
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_117(exception_, (object)num2, (object)num4, (object)num, (object)num5, object_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static Icon smethod_34()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	static void smethod_35(Class17.Class21 class21_0)
	{
		int i = default(int);
		int num = default(int);
		int j = default(int);
		int num2 = default(int);
		try
		{
			Array.Copy(class21_0.byte_0, 32768, class21_0.byte_0, 0, 32768);
			class21_0.int_1 -= 32768;
			class21_0.int_4 -= 32768;
			class21_0.int_3 -= 32768;
			for (i = 0; i < 32768; i++)
			{
				num = class21_0.short_0[i] & 0xFFFF;
				class21_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (j = 0; j < 32768; j++)
			{
				num2 = class21_0.short_1[j] & 0xFFFF;
				class21_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)i, (object)num, (object)j, (object)num2, (object)class21_0);
			throw;
		}
	}

	static void smethod_36(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 5;
			num2 = 2;
			num = 2;
			while (true)
			{
				num = 0;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 105:
						num = 8;
						num3 = 0;
						break;
					default:
						num = 3;
						num3 = 3;
						break;
					}
					num2 = num3;
					num = 2;
					switch (num2)
					{
					default:
						num = 0;
						continue;
					case 5:
						num = 0;
						continue;
					case 3:
						num = 1;
						goto IL_0051;
					case 4:
						num = 1;
						goto IL_0051;
					case 2:
						break;
					case 0:
						num = 9;
						goto IL_0061;
					case 1:
						{
							num = 9;
							goto IL_0061;
						}
						IL_0061:
						Class24.smethod_55(array_0, runtimeFieldHandle_0, 579, 619);
						return;
						IL_0051:
						num2 = 2;
						num = 2;
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_70(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)array_0, (object)runtimeFieldHandle_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_37(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		char[] char_ = default(char[]);
		int num3 = default(int);
		int num4 = default(int);
		string text = default(string);
		int num7 = default(int);
		int num6 = default(int);
		char[] array = default(char[]);
		char[] char_2 = default(char[]);
		int num8 = default(int);
		try
		{
			num = 5;
			while (true)
			{
				num2 = int_0 ^ 0x5F8D081D ^ int_1;
				char_ = Class2.char_1;
				num3 = char_[num2];
				num = 22;
				num4 = 4;
				num = 11;
				while (true)
				{
					num = 4;
					int num5;
					if ((text = Class2.string_0[num3]) == null)
					{
						num = 21;
						num5 = 0;
					}
					else
					{
						num = 15;
						num5 = 7;
					}
					num4 = num5;
					num = 11;
					while (true)
					{
						int num9;
						switch (num4)
						{
						case 13:
							num = 10;
							num7 = 1 + num7;
							num4 = 8;
							num = 11;
							goto case 8;
						case 8:
							num = 12;
							if (num7 >= num6)
							{
								num = 24;
								num9 = 10;
							}
							else
							{
								num = 14;
								num9 = 2;
							}
							goto IL_0039;
						case 11:
							num = 3;
							goto IL_0044;
						case 5:
							num = 0;
							num7 = 0;
							num4 = 8;
							num = 11;
							goto case 8;
						case 9:
							num = 9;
							array = new char[num6];
							num = 3;
							goto IL_0044;
						case 6:
							num = 3;
							goto IL_0044;
						case 2:
							num = 25;
							array[num7] = (char)(char_[num2 + num7] ^ char_2[(num7 + num3) % num8]);
							num = 13;
							num4 = 13;
							num = 11;
							goto case 13;
						case 1:
							num = 16;
							goto IL_0058;
						case 0:
							num = 20;
							num6 = char_[num2 + 1];
							num6 = (int)((uint)char_[num2 + 2] << 16) + num6;
							num = 17;
							num4 = 9;
							num = 11;
							goto case 9;
						case 4:
							break;
						default:
							num = 7;
							goto IL_0130;
						case 3:
							num = 7;
							goto IL_0130;
						case 12:
							goto end_IL_0116;
						case 7:
							num = 1;
							return text;
						case 10:
							{
								num = 19;
								text = new string(array);
								Class2.string_0[num3] = text;
								return text;
							}
							IL_0130:
							num4 = 12;
							num = 11;
							goto end_IL_0116;
							IL_0044:
							char_2 = Class2.char_0;
							num8 = char_2.Length;
							num2 += 3;
							num = 16;
							goto IL_0058;
							IL_0058:
							num4 = 5;
							num = 11;
							goto case 5;
						}
						break;
						IL_0039:
						num4 = num9;
						num = 11;
					}
					continue;
					end_IL_0116:
					break;
				}
				num = 5;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[13]
			{
				num2, num3, num6, char_, text, array, char_2, num8, num7, num4,
				num, int_0, int_1
			});
			throw;
		}
	}

	static void smethod_38(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static bool smethod_39(byte[] byte_0, Class26.Class30 class30_0, Class26 class26_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class24.smethod_71(byte_0);
		}
		catch (Exception)
		{
			Class24.smethod_67(class26_0, Enum0.const_0, Class17.string_0);
			return false;
		}
		byte[] array = Class24.smethod_29(byte_, "<RSAKeyValue><Modulus>tIVJVRm6tPRSO3G1BcGrNNgQyMA8I+s004q5SolBEHbW1J1dSg9oj7MS7PFKkAhXiLdjf7U6U7zrHaJEZlAGXFMn3hXq6cuE4io2iC7P46DPmo633MVZ7p6XVrQWaf9DQM9frL6InGxALDtU5bhNkaqlx8GgafEsdD4D60gXX9k=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class24.smethod_67(class26_0, Enum0.const_0, Class25.string_0);
			return false;
		}
		Class24.smethod_115(class26_0, Enum0.const_1);
		Class37 @class = new Class37("!970494ac-664a-a154-7202-adb8c9786e73");
		if (class26_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class26_0.iwebProxy_0;
		}
		Class26.Class28 class2 = new Class26.Class28(class26_0, array, @class, class30_0);
		Class24.smethod_78(@class, (Delegate2)class2.method_0);
		return class2.bool_0;
	}

	static void smethod_40(Class27 class27_0, Delegate0 delegate0_0)
	{
		Delegate0 @delegate = (Delegate0)class27_0.object_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_0);
			@delegate = Interlocked.CompareExchange(ref System.Runtime.CompilerServices.Unsafe.As<object, Delegate0>(ref class27_0.object_0), value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static string[] smethod_41(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 5;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 56:
					num = 9;
					num2 = 2;
					break;
				default:
					num = 0;
					num2 = 1;
					break;
				}
				num3 = num2;
				num = 8;
				switch (num3)
				{
				default:
					num = 11;
					goto IL_0042;
				case 1:
					num = 1;
					goto IL_0052;
				case 3:
					num = 2;
					goto IL_004a;
				case 5:
					num = 11;
					goto IL_0042;
				case 6:
					num = 2;
					goto IL_004a;
				case 7:
					num = 1;
					goto IL_0052;
				case 4:
					goto IL_0056;
				case 0:
					num = 6;
					break;
				case 2:
					{
						num = 6;
						break;
					}
					IL_004a:
					num3 = 4;
					num = 8;
					goto IL_0056;
					IL_0052:
					num3 = 4;
					num = 8;
					goto IL_0056;
					IL_0042:
					num3 = 4;
					num = 8;
					goto IL_0056;
				}
				break;
				IL_0056:
				num = 5;
			}
			return Class24.smethod_11(assembly_0, 595, 594);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)assembly_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_42(int int_0, Class17.Class19 class19_0)
	{
		int num = default(int);
		try
		{
			class19_0.short_0[class19_0.int_1] = 0;
			byte[] byte_ = class19_0.byte_1;
			num = class19_0.int_1++;
			byte_[num] = (byte)int_0;
			class19_0.class20_0.short_0[int_0]++;
			return Class24.smethod_114(class19_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)class19_0, (object)int_0);
			throw;
		}
	}

	static object smethod_43(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 11;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 49:
					num = 0;
					num2 = 3;
					break;
				default:
					num = 12;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 2;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_0051;
				case 0:
					num = 1;
					goto IL_0049;
				case 1:
					num = 11;
					continue;
				case 5:
					num = 5;
					num3 = 2;
					num = 2;
					goto case 2;
				case 6:
					num = 1;
					goto IL_0049;
				case 7:
					num = 6;
					goto IL_0051;
				case 2:
					num = 11;
					continue;
				case 3:
					num = 3;
					break;
				case 4:
					{
						num = 3;
						break;
					}
					IL_0049:
					num3 = 2;
					num = 2;
					goto case 2;
					IL_0051:
					num3 = 2;
					num = 2;
					goto case 2;
				}
				break;
			}
			return Class24.smethod_44(appDomain_0, string_0, 66, 18);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num3, (object)num, (object)appDomain_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static object smethod_44(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 5;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 80:
					num = 3;
					num2 = 2;
					break;
				default:
					num = 4;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 8;
				switch (num3)
				{
				default:
					num = 10;
					goto IL_0052;
				case 0:
					num = 12;
					num3 = 3;
					num = 8;
					goto case 3;
				case 1:
					num = 5;
					continue;
				case 5:
					num = 5;
					continue;
				case 6:
					num = 6;
					num3 = 3;
					num = 8;
					goto case 3;
				case 7:
					num = 10;
					goto IL_0052;
				case 3:
					num = 5;
					continue;
				case 2:
					num = 0;
					break;
				case 4:
					{
						num = 0;
						break;
					}
					IL_0052:
					num3 = 3;
					num = 8;
					goto case 3;
				}
				break;
			}
			return Class24.smethod_162(appDomain_0, string_0, 602, 571);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num3, (object)num, (object)appDomain_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_45(Class17.Class18 class18_0, byte[] byte_0)
	{
		try
		{
			Class24.smethod_153(byte_0, class18_0.class21_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_80(exception_, (object)class18_0, (object)byte_0);
			throw;
		}
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static void smethod_46(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 96:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_70(exception_, (object)num, (object)num2, (object)stream_0, (object)byte_0, (object)int_0, (object)int_1, (object)int_2, (object)int_3);
			throw;
		}
	}

	static Assembly smethod_47(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 12;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 25:
					num = 9;
					num2 = 5;
					break;
				default:
					num = 5;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 4;
				switch (num3)
				{
				default:
					num = 11;
					goto IL_004b;
				case 1:
					num = 2;
					goto IL_0042;
				case 2:
					num = 2;
					goto IL_0042;
				case 4:
					num = 2;
					goto IL_0042;
				case 6:
					num = 11;
					goto IL_004b;
				case 7:
					num = 8;
					num3 = 0;
					num = 4;
					goto IL_0057;
				case 0:
					goto IL_0057;
				case 3:
					num = 6;
					break;
				case 5:
					{
						num = 6;
						break;
					}
					IL_0042:
					num3 = 0;
					num = 4;
					goto IL_0057;
					IL_004b:
					num3 = 0;
					num = 4;
					goto IL_0057;
				}
				break;
				IL_0057:
				num = 12;
			}
			return Class24.smethod_15(byte_0, byte_1, evidence_0, 299, 263);
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num3, (object)num, (object)byte_0, (object)byte_1, (object)evidence_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_48(Class17.Class19.Class20 class20_0)
	{
		int[] array = default(int[]);
		int num = default(int);
		int i = default(int);
		int j = default(int);
		int num2 = default(int);
		try
		{
			array = new int[class20_0.int_3];
			num = 0;
			class20_0.short_1 = new short[class20_0.short_0.Length];
			for (i = 0; i < class20_0.int_3; i++)
			{
				array[i] = num;
				num += class20_0.int_2[i] << 15 - i;
			}
			for (j = 0; j < class20_0.int_1; j++)
			{
				num2 = class20_0.byte_0[j];
				if (num2 > 0)
				{
					class20_0.short_1[j] = Class24.smethod_25(array[num2 - 1]);
					array[num2 - 1] += 1 << 16 - num2;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)array, (object)num, (object)i, (object)j, (object)num2, (object)class20_0);
			throw;
		}
	}

	static bool smethod_49()
	{
		return Class24.smethod_188().byte_0 == 1;
	}

	static byte[] smethod_50(byte[] byte_0, byte[] byte_1)
	{
		checked
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				num = 3;
				while (true)
				{
					num2 = 7;
					num = 17;
					while (true)
					{
						num = 9;
						num3 = byte_0.Length * 2 + byte_1.Length;
						num = 33;
						num2 = 11;
						num = 17;
						while (true)
						{
							num = 5;
							num4 = 5;
							num2 = 14;
							num = 17;
							num = 15;
							while (true)
							{
								IL_0163:
								num = 28;
								int num5 = 9;
								while (true)
								{
									num2 = num5;
									num = 17;
									while (true)
									{
										int num6;
										switch (num2)
										{
										case 9:
										{
											num = 14;
											int num7;
											if (num3 < 0)
											{
												num = 18;
												num7 = 0;
											}
											else
											{
												num = 31;
												num7 = 15;
											}
											num2 = num7;
											num = 17;
											continue;
										}
										case 0:
											num = 16;
											num6 = 6;
											goto IL_00f3;
										case 5:
											break;
										case 8:
											num = 7;
											num3 += -1;
											num4 = 5;
											num = 12;
											goto IL_0098;
										case 10:
											num = 12;
											goto IL_0098;
										case 12:
											num = 6;
											goto IL_00e2;
										case 13:
											num = 24;
											byte_0[unchecked(num3 % byte_0.Length)] = (byte)unchecked(checked(unchecked(byte_0[num3 % byte_0.Length] ^ byte_1[num3 % byte_1.Length]) - unchecked((int)byte_0[checked(num3 + 1) % byte_0.Length]) + 256) % 256);
											num = 23;
											num2 = 1;
											num = 17;
											goto case 1;
										case 1:
											num = 6;
											goto IL_00e2;
										case 15:
											num = 11;
											num6 = 4;
											goto IL_00f3;
										case 14:
											goto IL_00fa;
										case 11:
											goto end_IL_015a;
										case 7:
											goto end_IL_016a;
										default:
											num = 19;
											goto IL_019f;
										case 4:
											num = 19;
											goto IL_019f;
										case 6:
											num = 19;
											goto IL_019f;
										case 2:
											num = 3;
											goto end_IL_0179;
										case 3:
											{
												num = 20;
												return byte_0;
											}
											IL_019f:
											num2 = 2;
											num = 17;
											goto case 2;
											IL_00e2:
											num4 = 2;
											num2 = 14;
											num = 17;
											num = 15;
											goto IL_0139;
											IL_0098:
											num2 = 14;
											num = 17;
											goto IL_00fa;
											IL_00f3:
											num4 = num6;
											num2 = 14;
											num = 17;
											goto IL_00fa;
										}
										break;
									}
									num = 27;
									num4 = 1;
									num2 = 14;
									num = 17;
									num = 15;
									goto IL_0133;
									IL_0133:
									num = 30;
									num5 = 7;
									continue;
									IL_012d:
									num = 21;
									num5 = 8;
									continue;
									IL_00fa:
									num = 15;
									switch (num4)
									{
									case 0:
										goto IL_012d;
									case 1:
										goto IL_0133;
									case 2:
										goto IL_0139;
									case 3:
										goto IL_013e;
									case 4:
										goto IL_0144;
									case 6:
										goto IL_014a;
									case 7:
										goto IL_0150;
									case 8:
										goto IL_0156;
									case 5:
										goto IL_0163;
									}
									num = 13;
									num5 = 5;
									continue;
									IL_0156:
									num = 29;
									num5 = 5;
									continue;
									IL_0150:
									num = 10;
									num5 = 1;
									continue;
									IL_014a:
									num = 26;
									num5 = 3;
									continue;
									IL_0144:
									num = 4;
									num5 = 13;
									continue;
									IL_013e:
									num = 2;
									num5 = 11;
									continue;
									IL_0139:
									num = 8;
									num5 = 8;
									continue;
									end_IL_015a:
									break;
								}
								break;
							}
							continue;
							end_IL_016a:
							break;
						}
						continue;
						end_IL_0179:
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				byte[] object_ = default(byte[]);
				Class24.smethod_117(exception_, (object)object_, (object)num3, (object)num4, (object)num2, (object)num, (object)byte_0, (object)byte_1);
				throw;
			}
		}
	}

	static void smethod_51(EventHandler eventHandler_0, Class27 class27_0)
	{
		EventHandler eventHandler = class27_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class27_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static long smethod_52(Class17.Class18 class18_0)
	{
		try
		{
			return class18_0.long_0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class18_0);
			throw;
		}
	}

	static byte[] smethod_53(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 3;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 3:
					num = 8;
					num2 = 0;
					break;
				default:
					num = 12;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 0;
					goto IL_004f;
				case 1:
					num = 6;
					goto IL_003b;
				case 2:
					num = 6;
					goto IL_003b;
				case 4:
					num = 4;
					num3 = 3;
					num = 1;
					goto IL_0053;
				case 5:
					num = 0;
					goto IL_004f;
				case 6:
					num = 0;
					goto IL_004f;
				case 3:
					goto IL_0053;
				case 0:
					num = 10;
					break;
				case 7:
					{
						num = 10;
						break;
					}
					IL_003b:
					num3 = 3;
					num = 1;
					goto IL_0053;
					IL_004f:
					num3 = 3;
					num = 1;
					goto IL_0053;
				}
				break;
				IL_0053:
				num = 3;
			}
			return Class24.smethod_128(encoding_0, string_0, 842, 784);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num3, (object)num, (object)encoding_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_54(Form0 form0_0)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)form0_0.panel_0).SuspendLayout();
		((Control)form0_0.panel_1).SuspendLayout();
		((Control)form0_0).SuspendLayout();
		Class24.smethod_112(Enum1.const_1, form0_0.control1_0);
		Class24.smethod_112(Enum1.const_1, form0_0.control1_1);
		((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.checkBox_0).set_Location(new Point(22, 98));
		((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
		((Control)form0_0.checkBox_0).set_TabIndex(13);
		((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
		form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_5);
		((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
		form0_0.label_0.set_FlatStyle((FlatStyle)3);
		((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)form0_0.label_0).set_Location(new Point(20, 124));
		((Control)form0_0.label_0).set_Size(new Size(381, 16));
		((Control)form0_0.label_0).set_Text(string.Format("Please tell {0} about this problem.", "[Unknown company]"));
		((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_0).set_Size(new Size(75, 24));
		((Control)form0_0.button_0).set_Location(new Point(400 - ((Control)form0_0.button_0).get_Width(), 205));
		((Control)form0_0.button_0).set_TabIndex(4);
		((Control)form0_0.button_0).set_Text("&Don't Send");
		((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_2);
		((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_1).set_Size(new Size(105, 24));
		((Control)form0_0.button_1).set_Location(new Point(((Control)form0_0.button_0).get_Left() - ((Control)form0_0.button_1).get_Width() - 6, 205));
		((Control)form0_0.button_1).set_TabIndex(3);
		((Control)form0_0.button_1).set_Text("&Send Error Report");
		((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_1);
		((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_6).set_Size(new Size(64, 24));
		((Control)form0_0.button_6).set_Location(new Point(((Control)form0_0.button_1).get_Left() - ((Control)form0_0.button_6).get_Width() - 6, 205));
		((Control)form0_0.button_6).set_TabIndex(14);
		((Control)form0_0.button_6).set_Text("De&bug");
		((Control)form0_0.button_6).set_Visible(false);
		((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
		((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
		form0_0.label_1.set_FlatStyle((FlatStyle)3);
		((Control)form0_0.label_1).set_Location(new Point(20, 140));
		((Control)form0_0.label_1).set_Size(new Size(381, 55));
		((Control)form0_0.label_1).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "[Unknown company]"));
		((Control)form0_0.class34_0).set_Anchor((AnchorStyles)13);
		((Control)form0_0.class34_0).set_Location(new Point(20, 69));
		((Control)form0_0.class34_0).set_Size(new Size(381, 13));
		((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_2).set_Size(new Size(80, 24));
		((Control)form0_0.button_2).set_Location(new Point(400 - ((Control)form0_0.button_2).get_Width(), 205));
		((Control)form0_0.button_2).set_TabIndex(7);
		((Control)form0_0.button_2).set_Text("&Cancel");
		((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_3);
		((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
		((Control)form0_0.button_3).set_Enabled(false);
		((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_3).set_Size(new Size(105, 24));
		((Control)form0_0.button_3).set_Location(new Point(((Control)form0_0.button_2).get_Left() - ((Control)form0_0.button_3).get_Width() - 6, 205));
		((Control)form0_0.button_3).set_TabIndex(6);
		((Control)form0_0.button_3).set_Text("&OK");
		((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_4);
		((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_4).set_Location(((Control)form0_0.button_3).get_Location());
		((Control)form0_0.button_4).set_Size(((Control)form0_0.button_3).get_Size());
		((Control)form0_0.button_4).set_TabIndex(5);
		((Control)form0_0.button_4).set_Text("&Retry");
		((Control)form0_0.button_4).set_Visible(false);
		((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_10);
		((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_5).set_Location(((Control)form0_0.button_3).get_Location());
		((Control)form0_0.button_5).set_Size(((Control)form0_0.button_3).get_Size());
		((Control)form0_0.button_5).set_TabIndex(5);
		((Control)form0_0.button_5).set_Text("Save Report");
		((Control)form0_0.button_5).set_Visible(false);
		((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_0);
		((Control)form0_0.control3_0).set_Location(new Point(87, 146));
		((Control)form0_0.control3_0).set_Visible(false);
		((Control)form0_0.control0_0).SetBounds(24, 72, 368, 16);
		((Control)form0_0.control0_1).SetBounds(24, 96, 368, 16);
		((Control)form0_0.control0_2).SetBounds(24, 120, 368, 16);
		((Control)form0_0.control0_3).SetBounds(24, 144, 368, 16);
		((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form0_0.control2_0).SetBounds(20, 444, 120, 32);
		((Control)form0_0.panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)form0_0.button_6,
			(Control)form0_0.checkBox_0,
			(Control)form0_0.label_0,
			(Control)form0_0.button_0,
			(Control)form0_0.button_1,
			(Control)form0_0.label_1,
			(Control)form0_0.class34_0,
			form0_0.control1_0
		});
		((Control)form0_0.panel_0).set_Size(new Size(413, 240));
		((Control)form0_0.panel_0).set_TabIndex(0);
		((Control)form0_0.panel_1).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)form0_0.button_2,
			(Control)form0_0.button_3,
			(Control)form0_0.button_4,
			(Control)form0_0.button_5,
			form0_0.control3_0,
			form0_0.control1_1,
			form0_0.control0_0,
			form0_0.control0_1,
			form0_0.control0_2,
			form0_0.control0_3
		});
		((Control)form0_0.panel_1).set_Size(new Size(413, 240));
		((Control)form0_0.panel_1).set_TabIndex(2);
		((Control)form0_0.panel_1).set_Visible(false);
		((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form0_0).set_ClientSize(new Size(434, 488));
		((Form)form0_0).set_ControlBox(false);
		((Control)form0_0).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			form0_0.control2_0,
			(Control)form0_0.panel_0,
			(Control)form0_0.panel_1
		});
		((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form0_0).set_ShowInTaskbar(false);
		((Form)form0_0).set_MinimizeBox(false);
		((Form)form0_0).set_MaximizeBox(false);
		((Form)form0_0).set_StartPosition((FormStartPosition)1);
		((Control)form0_0).set_Text("1234");
		if (((Control)form0_0).get_Text().Length == 0)
		{
			((Control)form0_0).set_Text("Error Reporting");
		}
		try
		{
			((Form)form0_0).set_TopMost(true);
		}
		catch
		{
		}
		((Control)form0_0.panel_0).ResumeLayout(false);
		((Control)form0_0.panel_1).ResumeLayout(false);
		((Control)form0_0).ResumeLayout(false);
		((Control)form0_0.button_4).BringToFront();
		((Control)form0_0.button_5).BringToFront();
		((Form)form0_0).set_Size(new Size(419, 264));
		((Control)form0_0.panel_1).set_Dock((DockStyle)5);
		((Control)form0_0.panel_0).set_Dock((DockStyle)5);
	}

	static void smethod_55(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 9;
			num2 = 4;
			num = 10;
			while (true)
			{
				num = 0;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 40:
						num = 8;
						num3 = 5;
						break;
					default:
						num = 5;
						num3 = 1;
						break;
					}
					num2 = num3;
					num = 10;
					switch (num2)
					{
					default:
						num = 0;
						continue;
					case 3:
						num = 0;
						continue;
					case 0:
						num = 4;
						goto IL_0054;
					case 1:
						num = 4;
						goto IL_0054;
					case 4:
						break;
					case 2:
						num = 2;
						return;
					case 5:
						{
							num = 1;
							Class24.smethod_179(array_0, runtimeFieldHandle_0, 660, 671);
							return;
						}
						IL_0054:
						num2 = 4;
						num = 10;
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_70(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)array_0, (object)runtimeFieldHandle_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_56(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 86:
					appDomain_0.ResourceResolve += resolveEventHandler_0;
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_9(exception_, (object)num, (object)num2, (object)appDomain_0, (object)resolveEventHandler_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static byte[] smethod_57(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 8;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 32:
					num = 3;
					num2 = 5;
					break;
				default:
					num = 11;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 5;
					goto IL_003f;
				case 0:
					num = 0;
					num3 = 4;
					num = 1;
					goto case 4;
				case 1:
					num = 5;
					goto IL_003f;
				case 2:
					num = 12;
					goto IL_004d;
				case 6:
					num = 12;
					goto IL_004d;
				case 4:
					num = 8;
					continue;
				case 7:
					num = 8;
					continue;
				case 3:
					num = 6;
					break;
				case 5:
					{
						num = 6;
						break;
					}
					IL_004d:
					num3 = 4;
					num = 1;
					goto case 4;
					IL_003f:
					num3 = 4;
					num = 1;
					goto case 4;
				}
				break;
			}
			return Class24.smethod_138(memoryStream_0, 351, 267);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)memoryStream_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static AppDomain smethod_58(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 12;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 14:
					num = 8;
					num2 = 4;
					break;
				default:
					num = 6;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 3;
				switch (num3)
				{
				default:
					num = 9;
					goto IL_003a;
				case 1:
					num = 9;
					goto IL_003a;
				case 2:
					num = 0;
					num3 = 0;
					num = 3;
					goto case 0;
				case 3:
					num = 12;
					continue;
				case 5:
					num = 2;
					num3 = 0;
					num = 3;
					goto case 0;
				case 0:
					num = 12;
					continue;
				case 7:
					num = 12;
					continue;
				case 4:
					num = 1;
					break;
				case 6:
					{
						num = 1;
						break;
					}
					IL_003a:
					num3 = 0;
					num = 3;
					goto case 0;
				}
				break;
			}
			return Class24.smethod_140(903, 934);
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num3, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static int smethod_59(Class17.Class19.Class20 class20_0)
	{
		int num = default(int);
		int i = default(int);
		try
		{
			num = 0;
			for (i = 0; i < class20_0.short_0.Length; i++)
			{
				num += class20_0.short_0[i] * class20_0.byte_0[i];
			}
			return num;
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)i, (object)class20_0);
			throw;
		}
	}

	static string smethod_60(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		char[] char_ = default(char[]);
		int num3 = default(int);
		int num4 = default(int);
		string text = default(string);
		char[] array = default(char[]);
		int num6 = default(int);
		char[] char_2 = default(char[]);
		int num8 = default(int);
		int num7 = default(int);
		try
		{
			num = 13;
			while (true)
			{
				num2 = int_0 ^ 0x15F4E4F4 ^ int_1;
				num = 18;
				while (true)
				{
					char_ = Class6.char_1;
					num3 = char_[num2];
					num4 = 2;
					num = 1;
					while (true)
					{
						IL_0108:
						num = 19;
						int num5;
						if ((text = Class6.string_0[num3]) == null)
						{
							num = 6;
							num5 = 8;
						}
						else
						{
							num = 20;
							num5 = 12;
						}
						num4 = num5;
						num = 1;
						while (true)
						{
							int num9;
							switch (num4)
							{
							case 13:
								num = 10;
								array = new char[num6];
								char_2 = Class6.char_0;
								num8 = char_2.Length;
								num2 += 3;
								num = 15;
								num4 = 9;
								num = 1;
								goto case 9;
							case 9:
								num = 3;
								num7 = 0;
								num4 = 11;
								num = 1;
								goto case 11;
							case 11:
								num = 22;
								if (num7 >= num6)
								{
									num = 7;
									num9 = 4;
								}
								else
								{
									num = 11;
									num9 = 10;
								}
								goto IL_005a;
							case 10:
								num = 5;
								array[num7] = (char)(char_[num2 + num7] ^ char_2[(num7 + num3) % num8]);
								num = 17;
								goto IL_007e;
							case 7:
								num = 16;
								num7 = 1 + num7;
								num4 = 11;
								num = 1;
								goto case 11;
							case 8:
								num = 24;
								num6 = char_[num2 + 1];
								num6 = (int)((uint)char_[num2 + 2] << 16) + num6;
								num = 0;
								num4 = 13;
								num = 1;
								goto case 13;
							case 0:
								num = 17;
								goto IL_007e;
							case 2:
								break;
							case 5:
								goto end_IL_00be;
							default:
								num = 9;
								goto IL_013b;
							case 3:
								num = 9;
								goto IL_013b;
							case 1:
								goto end_IL_011f;
							case 4:
								num = 12;
								text = new string(array);
								Class6.string_0[num3] = text;
								num = 8;
								goto IL_016c;
							case 6:
								num = 8;
								goto IL_016c;
							case 12:
								{
									num = 23;
									return text;
								}
								IL_016c:
								return text;
								IL_013b:
								num4 = 1;
								num = 1;
								goto end_IL_011f;
								IL_007e:
								num4 = 7;
								num = 1;
								goto case 7;
							}
							goto IL_0108;
							IL_005a:
							num4 = num9;
							num = 1;
							continue;
							end_IL_00be:
							break;
						}
						break;
					}
					num = 18;
					continue;
					end_IL_011f:
					break;
				}
				num = 13;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[13]
			{
				num2, num3, num6, char_, text, array, char_2, num8, num7, num4,
				num, int_0, int_1
			});
			throw;
		}
	}

	static void smethod_61(Control0 control0_0)
	{
		Class24.smethod_121(string.Empty, control0_0);
	}

	static string smethod_62()
	{
		return "Software\\Red Gate\\" + Class24.smethod_118();
	}

	static int smethod_63(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 87:
					num = 4;
					return stream_0.Read(byte_0, int_0, int_1);
				}
				num = 6;
				num = 7;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num, (object)stream_0, (object)byte_0, (object)int_0, (object)int_1, (object)int_2, (object)int_3);
			throw;
		}
	}

	static Assembly smethod_64(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 6;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 6:
					num = 2;
					num2 = 1;
					break;
				default:
					num = 5;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 11;
				switch (num3)
				{
				default:
					num = 4;
					goto IL_0047;
				case 4:
					num = 12;
					goto IL_003e;
				case 5:
					num = 12;
					goto IL_003e;
				case 6:
					num = 4;
					goto IL_0047;
				case 7:
					num = 3;
					num3 = 0;
					num = 11;
					goto IL_0055;
				case 0:
					goto IL_0055;
				case 1:
					num = 0;
					break;
				case 2:
					num = 0;
					break;
				case 3:
					{
						num = 0;
						break;
					}
					IL_003e:
					num3 = 0;
					num = 11;
					goto IL_0055;
					IL_0047:
					num3 = 0;
					num = 11;
					goto IL_0055;
				}
				break;
				IL_0055:
				num = 6;
			}
			return Class24.smethod_32(414, 465);
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num3, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_65(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class27_0.method_7();
	}

	static int smethod_66(Class27 class27_0, string string_0)
	{
		try
		{
			bool flag = class27_0.char_0[0] == '\u0001';
			if (string_0 != null && string_0.Length != 0 && (!flag || string_0.Length <= 4) && (flag || string_0[0] == '#'))
			{
				int num = 0;
				int num2 = string_0.Length - 1;
				while (true)
				{
					if (num2 >= 0 && (flag || num2 != 0))
					{
						char c = string_0[num2];
						bool flag2 = false;
						for (int i = 0; i < class27_0.char_0.Length; i++)
						{
							if (class27_0.char_0[i] == c)
							{
								num = num * class27_0.char_0.Length + i;
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							break;
						}
						num2--;
						continue;
					}
					return num;
				}
				return -1;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static void smethod_67(Class26 class26_0, Enum0 enum0_0, string string_0)
	{
		Class24.smethod_111(class26_0, enum0_0, string_0, string.Empty);
	}

	static Encoding smethod_68(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			num = 15;
			while (true)
			{
				num2 = 4;
				num = 21;
				while (true)
				{
					num = 12;
					int num3;
					switch (int_1 ^ int_0)
					{
					case 103:
						num = 22;
						num3 = 8;
						break;
					default:
						num = 8;
						num3 = 0;
						break;
					}
					num2 = num3;
					num = 21;
					while (true)
					{
						int num6;
						int num5;
						switch (num2)
						{
						case 11:
							num = 7;
							switch (num4)
							{
							default:
								num = 0;
								num6 = 10;
								goto IL_0071;
							case 0:
								num = 24;
								num6 = 5;
								goto IL_0071;
							case 1:
								num = 16;
								num6 = 10;
								goto IL_0071;
							case 2:
								num = 10;
								num6 = 9;
								goto IL_0071;
							case 3:
								num = 5;
								num6 = 9;
								goto IL_0071;
							case 4:
								break;
							case 5:
								num = 3;
								num6 = 1;
								goto IL_0071;
							case 6:
								num = 18;
								num6 = 5;
								goto IL_0071;
							case 7:
								num = 4;
								num6 = 1;
								goto IL_0071;
							}
							goto IL_005e;
						case 10:
							num = 19;
							num4 = 4;
							num2 = 11;
							num = 21;
							num = 7;
							goto IL_005e;
						case 9:
							num = 25;
							num4 = 4;
							num2 = 11;
							num = 21;
							num = 7;
							goto IL_005e;
						case 8:
							num = 2;
							num5 = 5;
							goto IL_0098;
						case 6:
							num = 9;
							goto IL_00a7;
						case 5:
							num = 13;
							goto IL_00ad;
						case 3:
							num = 13;
							goto IL_00ad;
						case 0:
							num = 9;
							goto IL_00a7;
						case 4:
							break;
						default:
							num = 17;
							goto IL_0123;
						case 7:
							num = 17;
							goto IL_0123;
						case 2:
							num = 15;
							goto end_IL_0107;
						case 12:
							num = 15;
							goto end_IL_0107;
						case 1:
							{
								num = 6;
								return Class24.smethod_75(606, 630);
							}
							IL_0123:
							num2 = 2;
							num = 21;
							goto case 2;
							IL_00ad:
							num4 = 4;
							num2 = 11;
							num = 21;
							num = 7;
							goto IL_005e;
							IL_00a7:
							num5 = 3;
							goto IL_0098;
							IL_0098:
							num4 = num5;
							num2 = 11;
							num = 21;
							goto case 11;
							IL_005e:
							num = 1;
							num6 = 4;
							goto IL_0071;
							IL_0071:
							num2 = num6;
							num = 21;
							continue;
						}
						break;
					}
					continue;
					end_IL_0107:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num4, (object)num2, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_69(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	static void smethod_70(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class24.smethod_24(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static byte[] smethod_71(byte[] byte_0)
	{
		try
		{
			return Class24.smethod_5(1, (byte[])null, (byte[])null, byte_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)byte_0);
			throw;
		}
	}

	static string smethod_72()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class24.smethod_62());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class24.smethod_90());
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

	static void smethod_73(Exception exception_0)
	{
		Class24.smethod_24(exception_0, new object[0]);
	}

	static void smethod_74(bool bool_0, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static Encoding smethod_75(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 3;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 40:
					num = 4;
					num2 = 5;
					break;
				default:
					num = 0;
					num2 = 2;
					break;
				}
				num3 = num2;
				num = 9;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_0045;
				case 0:
					num = 6;
					goto IL_0045;
				case 2:
					num = 7;
					num3 = 1;
					num = 9;
					goto IL_0053;
				case 3:
					num = 6;
					goto IL_0045;
				case 7:
					num = 8;
					num3 = 1;
					num = 9;
					goto IL_0053;
				case 1:
					goto IL_0053;
				case 4:
					num = 2;
					break;
				case 5:
					num = 2;
					break;
				case 6:
					{
						num = 2;
						break;
					}
					IL_0045:
					num3 = 1;
					num = 9;
					goto IL_0053;
				}
				break;
				IL_0053:
				num = 3;
			}
			return Class24.smethod_2(745, 649);
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num3, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_76(bool bool_0, int int_0, int int_1, Class17.Class19 class19_0, byte[] byte_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int i = default(int);
		int j = default(int);
		try
		{
			class19_0.class20_0.short_0[256]++;
			Class24.smethod_152(class19_0.class20_0);
			Class24.smethod_152(class19_0.class20_1);
			Class24.smethod_4(class19_0.class20_0, class19_0.class20_2);
			Class24.smethod_4(class19_0.class20_1, class19_0.class20_2);
			Class24.smethod_152(class19_0.class20_2);
			num = 4;
			for (num2 = 18; num2 > num; num2--)
			{
				if (class19_0.class20_2.byte_0[Class17.Class19.int_0[num2]] > 0)
				{
					num = num2 + 1;
				}
			}
			num3 = 14 + num * 3 + Class24.smethod_59(class19_0.class20_2) + Class24.smethod_59(class19_0.class20_0) + Class24.smethod_59(class19_0.class20_1) + class19_0.int_2;
			num4 = class19_0.int_2;
			for (i = 0; i < 286; i++)
			{
				num4 += class19_0.class20_0.short_0[i] * Class17.Class19.byte_2[i];
			}
			for (j = 0; j < 30; j++)
			{
				num4 += class19_0.class20_1.short_0[j] * Class17.Class19.byte_3[j];
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
			{
				Class24.smethod_150(byte_0, bool_0, int_1, class19_0, int_0);
			}
			else if (num3 == num4)
			{
				Class24.smethod_148(class19_0.class22_0, 2 + (bool_0 ? 1 : 0), 3);
				Class17.Class19.Class20 class20_ = class19_0.class20_0;
				short[] short_ = Class17.Class19.short_1;
				byte[] byte_ = Class17.Class19.byte_2;
				Class24.smethod_108(short_, byte_, class20_);
				class20_ = class19_0.class20_1;
				short_ = Class17.Class19.short_2;
				byte_ = Class17.Class19.byte_3;
				Class24.smethod_108(short_, byte_, class20_);
				Class24.smethod_81(class19_0);
				Class24.smethod_28(class19_0);
			}
			else
			{
				Class24.smethod_148(class19_0.class22_0, 4 + (bool_0 ? 1 : 0), 3);
				Class24.smethod_184(class19_0, num);
				Class24.smethod_81(class19_0);
				Class24.smethod_28(class19_0);
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[11]
			{
				num, num2, num3, num4, i, j, class19_0, byte_0, int_0, int_1,
				bool_0
			});
			throw;
		}
	}

	static Assembly smethod_77(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			num = 12;
			while (true)
			{
				num2 = 4;
				num = 0;
				while (true)
				{
					num = 6;
					int num3;
					switch (int_1 ^ int_0)
					{
					case 34:
						num = 17;
						num3 = 8;
						break;
					default:
						num = 4;
						num3 = 6;
						break;
					}
					num2 = num3;
					num = 0;
					while (true)
					{
						int num5;
						int num6;
						switch (num2)
						{
						case 10:
							num = 24;
							goto IL_0018;
						case 9:
							num = 24;
							goto IL_0018;
						case 8:
							num = 8;
							num5 = 7;
							goto IL_007d;
						case 7:
							num = 9;
							num4 = 3;
							num2 = 9;
							num = 0;
							goto case 9;
						case 6:
							num = 15;
							num5 = 1;
							goto IL_007d;
						case 5:
							num = 3;
							num4 = 3;
							num2 = 9;
							num = 0;
							goto case 9;
						case 3:
							num = 7;
							num4 = 3;
							num2 = 9;
							num = 0;
							goto case 9;
						case 4:
							break;
						default:
							num = 14;
							goto IL_0111;
						case 0:
							num = 14;
							goto IL_0111;
						case 1:
							num = 14;
							goto IL_0111;
						case 12:
							goto end_IL_00f1;
						case 2:
							num = 16;
							goto IL_0127;
						case 11:
							{
								num = 16;
								goto IL_0127;
							}
							IL_0127:
							return Class24.smethod_32(277, 346);
							IL_0111:
							num2 = 12;
							num = 0;
							goto end_IL_00f1;
							IL_007d:
							num4 = num5;
							num2 = 9;
							num = 0;
							goto case 9;
							IL_0018:
							switch (num4)
							{
							default:
								num = 21;
								num6 = 3;
								break;
							case 0:
								num = 2;
								num6 = 5;
								break;
							case 1:
								num = 11;
								num6 = 7;
								break;
							case 2:
								num = 18;
								num6 = 4;
								break;
							case 3:
								num = 25;
								num6 = 4;
								break;
							case 4:
								num = 22;
								num6 = 5;
								break;
							case 5:
								num = 26;
								num6 = 2;
								break;
							case 6:
								num = 5;
								num6 = 3;
								break;
							case 7:
								num = 10;
								num6 = 2;
								break;
							}
							goto IL_0070;
						}
						break;
						IL_0070:
						num2 = num6;
						num = 0;
					}
					continue;
					end_IL_00f1:
					break;
				}
				num = 12;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num4, (object)num2, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_78(Class37 class37_0, Delegate2 delegate2_0)
	{
		if (class37_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class37_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class37_0.iwebProxy_0);
				}
				class37_0.string_2 = uploadReportLoginService.GetServerURL(class37_0.string_1);
				if (class37_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class37_0.string_2 == "ditto")
				{
					class37_0.string_2 = Class37.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate2_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate2_0(class37_0.string_2.StartsWith("ERR") ? class37_0.string_2 : "OK");
	}

	static byte[] smethod_79(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			num = 3;
			while (true)
			{
				num2 = 7;
				num = 4;
				while (true)
				{
					num = 6;
					while (true)
					{
						int num3;
						switch (int_1 ^ int_0)
						{
						case 111:
							num = 11;
							num3 = 6;
							break;
						default:
							num = 10;
							num3 = 12;
							break;
						}
						num2 = num3;
						num = 4;
						while (true)
						{
							int num5;
							int num6;
							switch (num2)
							{
							case 12:
								num = 18;
								num5 = 0;
								goto IL_0018;
							case 10:
								num = 20;
								switch (num4)
								{
								default:
									num = 25;
									num6 = 3;
									goto IL_0079;
								case 0:
									num = 14;
									num6 = 2;
									goto IL_0079;
								case 1:
									num = 19;
									num6 = 1;
									goto IL_0079;
								case 2:
									break;
								case 3:
									num = 26;
									num6 = 2;
									goto IL_0079;
								case 4:
									num = 8;
									num6 = 1;
									goto IL_0079;
								case 5:
									num = 9;
									num6 = 0;
									goto IL_0079;
								case 6:
									num = 24;
									num6 = 3;
									goto IL_0079;
								case 7:
									num = 17;
									num6 = 1;
									goto IL_0079;
								}
								goto IL_0059;
							case 11:
								num = 15;
								goto IL_0081;
							case 9:
								num = 27;
								goto IL_008b;
							case 6:
								num = 21;
								num5 = 4;
								goto IL_0018;
							case 3:
								num = 2;
								num4 = 2;
								num = 15;
								goto IL_0081;
							case 2:
								num = 12;
								num4 = 2;
								num2 = 10;
								num = 4;
								num = 20;
								goto IL_0059;
							case 0:
								num = 27;
								goto IL_008b;
							case 5:
								goto end_IL_00bd;
							case 7:
								break;
							default:
								num = 7;
								goto IL_0122;
							case 8:
								num = 7;
								goto IL_0122;
							case 4:
								goto end_IL_0118;
							case 1:
								{
									num = 22;
									return Class24.smethod_53(encoding_0, string_0, 764, 767);
								}
								IL_0122:
								num2 = 4;
								num = 4;
								goto end_IL_0118;
								IL_008b:
								num4 = 2;
								num2 = 10;
								num = 4;
								num = 20;
								goto IL_0059;
								IL_0081:
								num2 = 10;
								num = 4;
								goto case 10;
								IL_0018:
								num4 = num5;
								num2 = 10;
								num = 4;
								goto case 10;
								IL_0059:
								num = 5;
								num6 = 7;
								goto IL_0079;
							}
							goto end_IL_0107;
							IL_0079:
							num2 = num6;
							num = 4;
							continue;
							end_IL_00bd:
							break;
						}
						num = 6;
						continue;
						end_IL_0107:
						break;
					}
					continue;
					end_IL_0118:
					break;
				}
				num = 3;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num4, (object)num2, (object)num, (object)encoding_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_80(Exception exception_0, object object_0, object object_1)
	{
		Class24.smethod_24(exception_0, new object[2] { object_0, object_1 });
	}

	static void smethod_81(Class17.Class19 class19_0)
	{
		int i = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			for (i = 0; i < class19_0.int_1; i++)
			{
				num = class19_0.byte_1[i] & 0xFF;
				num2 = class19_0.short_0[i];
				if (num2-- != 0)
				{
					num3 = Class24.smethod_161(num, class19_0);
					Class24.smethod_125(class19_0.class20_0, num3);
					num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						Class24.smethod_148(class19_0.class22_0, num & ((1 << num4) - 1), num4);
					}
					num5 = Class24.smethod_0(class19_0, num2);
					Class24.smethod_125(class19_0.class20_1, num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						Class24.smethod_148(class19_0.class22_0, num2 & ((1 << num4) - 1), num4);
					}
				}
				else
				{
					Class24.smethod_125(class19_0.class20_0, num);
				}
			}
			Class24.smethod_125(class19_0.class20_0, 256);
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)i, (object)num, (object)num2, (object)num3, (object)num4, (object)num5, (object)class19_0);
			throw;
		}
	}

	static string smethod_82(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 10;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 37:
					num = 1;
					num2 = 3;
					break;
				default:
					num = 6;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 12;
				switch (num3)
				{
				default:
					num = 8;
					goto IL_0053;
				case 1:
					num = 4;
					goto IL_004a;
				case 2:
					num = 0;
					num3 = 0;
					num = 12;
					goto IL_0058;
				case 5:
					num = 4;
					goto IL_004a;
				case 6:
					num = 4;
					goto IL_004a;
				case 7:
					num = 8;
					goto IL_0053;
				case 0:
					goto IL_0058;
				case 3:
					num = 2;
					break;
				case 4:
					{
						num = 2;
						break;
					}
					IL_004a:
					num3 = 0;
					num = 12;
					goto IL_0058;
					IL_0053:
					num3 = 0;
					num = 12;
					goto IL_0058;
				}
				break;
				IL_0058:
				num = 10;
			}
			return Class24.smethod_163(string_0, string_1, 658, 731);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num3, (object)num, (object)string_0, (object)string_1, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_83(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static ICryptoTransform smethod_84(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		try
		{
			symmetricAlgorithm = new RijndaelManaged();
			try
			{
				cryptoTransform = (bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0));
				return cryptoTransform;
			}
			finally
			{
				((IDisposable)symmetricAlgorithm)?.Dispose();
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)symmetricAlgorithm, (object)cryptoTransform, (object)byte_1, (object)byte_0, (object)bool_0);
			throw;
		}
	}

	static bool smethod_85(Class17.Class18 class18_0)
	{
		try
		{
			return Class24.smethod_22(class18_0.class21_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class18_0);
			throw;
		}
	}

	static Type smethod_86(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 6;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 121:
					num = 8;
					num2 = 2;
					break;
				default:
					num = 2;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 11;
				switch (num3)
				{
				default:
					num = 5;
					goto IL_004e;
				case 0:
					num = 4;
					num3 = 6;
					num = 11;
					goto IL_0053;
				case 4:
					num = 5;
					goto IL_004e;
				case 5:
					num = 1;
					num3 = 6;
					num = 11;
					goto IL_0053;
				case 7:
					num = 5;
					goto IL_004e;
				case 6:
					goto IL_0053;
				case 1:
					num = 10;
					break;
				case 2:
					num = 10;
					break;
				case 3:
					{
						num = 10;
						break;
					}
					IL_004e:
					num3 = 6;
					num = 11;
					goto IL_0053;
				}
				break;
				IL_0053:
				num = 6;
			}
			return Class24.smethod_103(runtimeTypeHandle_0, 485, 487);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)runtimeTypeHandle_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_87(Class35 class35_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = (Delegate1)class35_0.object_1;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref System.Runtime.CompilerServices.Unsafe.As<object, Delegate1>(ref class35_0.object_1), value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_88(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 2;
			num2 = 4;
			num = 0;
			while (true)
			{
				num = 8;
				while (true)
				{
					int num3;
					switch (int_3 ^ int_2)
					{
					case 50:
						num = 7;
						num3 = 1;
						break;
					default:
						num = 9;
						num3 = 5;
						break;
					}
					num2 = num3;
					num = 0;
					switch (num2)
					{
					default:
						num = 8;
						continue;
					case 0:
						num = 8;
						continue;
					case 3:
						num = 8;
						continue;
					case 5:
						num = 3;
						num2 = 4;
						num = 0;
						break;
					case 4:
						break;
					case 1:
						num = 5;
						goto IL_0062;
					case 2:
						{
							num = 5;
							goto IL_0062;
						}
						IL_0062:
						Class24.smethod_46(stream_0, byte_0, int_0, int_1, 869, 773);
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_123(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)stream_0, (object)byte_0, (object)int_0, (object)int_1, (object)int_2, (object)int_3);
			throw;
		}
	}

	static int smethod_89(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 5;
			while (true)
			{
				int num2;
				switch (int_3 ^ int_2)
				{
				case 72:
					num = 3;
					num2 = 6;
					break;
				default:
					num = 10;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 6;
				switch (num3)
				{
				default:
					num = 7;
					goto IL_0043;
				case 0:
					num = 4;
					num3 = 1;
					num = 6;
					goto IL_0050;
				case 2:
					num = 7;
					goto IL_0043;
				case 3:
					num = 7;
					goto IL_0043;
				case 5:
					num = 12;
					num3 = 1;
					num = 6;
					goto IL_0050;
				case 1:
					goto IL_0050;
				case 4:
					num = 8;
					break;
				case 6:
					num = 8;
					break;
				case 7:
					{
						num = 8;
						break;
					}
					IL_0043:
					num3 = 1;
					num = 6;
					goto IL_0050;
				}
				break;
				IL_0050:
				num = 5;
			}
			return Class24.smethod_63(stream_0, byte_0, int_0, int_1, 786, 837);
		}
		catch (Exception exception_)
		{
			Class24.smethod_70(exception_, (object)num3, (object)num, (object)stream_0, (object)byte_0, (object)int_0, (object)int_1, (object)int_2, (object)int_3);
			throw;
		}
	}

	static string smethod_90()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class24.smethod_118();
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class38.Struct10 struct10_0, int int_1);

	static void smethod_91(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class24.smethod_24(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static void smethod_92(Class17.Class21 class21_0)
	{
		int num = default(int);
		try
		{
			if (class21_0.int_4 >= 65274)
			{
				Class24.smethod_35(class21_0);
			}
			while (class21_0.int_5 < 262 && class21_0.int_7 < class21_0.int_8)
			{
				num = 65536 - class21_0.int_5 - class21_0.int_4;
				if (num > class21_0.int_8 - class21_0.int_7)
				{
					num = class21_0.int_8 - class21_0.int_7;
				}
				Array.Copy((Array)class21_0.object_0, class21_0.int_7, class21_0.byte_0, class21_0.int_4 + class21_0.int_5, num);
				class21_0.int_7 += num;
				class21_0.int_6 += num;
				class21_0.int_5 += num;
			}
			if (class21_0.int_5 >= 3)
			{
				Class24.smethod_187(class21_0);
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_80(exception_, (object)num, (object)class21_0);
			throw;
		}
	}

	static void smethod_93(int int_0, Class17.Class22 class22_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			byte[] byte_ = class22_0.byte_0;
			num = class22_0.int_1++;
			byte_[num] = (byte)int_0;
			byte[] byte_2 = class22_0.byte_0;
			num2 = class22_0.int_1++;
			byte_2[num2] = (byte)(int_0 >> 8);
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)num2, (object)class22_0, (object)int_0);
			throw;
		}
	}

	static void smethod_94(int[] int_0, Class17.Class19.Class20 class20_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int i = default(int);
		int[] array = default(int[]);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		try
		{
			class20_0.byte_0 = new byte[class20_0.short_0.Length];
			num = int_0.Length / 2;
			num2 = (num + 1) / 2;
			num3 = 0;
			for (i = 0; i < class20_0.int_3; i++)
			{
				class20_0.int_2[i] = 0;
			}
			array = new int[num];
			array[num - 1] = 0;
			for (num4 = num - 1; num4 >= 0; num4--)
			{
				if (int_0[2 * num4 + 1] != -1)
				{
					num5 = array[num4] + 1;
					if (num5 > class20_0.int_3)
					{
						num5 = class20_0.int_3;
						num3++;
					}
					num6 = (array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5));
				}
				else
				{
					num7 = array[num4];
					class20_0.int_2[num7 - 1]++;
					class20_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
				}
			}
			if (num3 == 0)
			{
				return;
			}
			num8 = class20_0.int_3 - 1;
			while (true)
			{
				if (class20_0.int_2[--num8] != 0)
				{
					do
					{
						class20_0.int_2[num8]--;
						class20_0.int_2[++num8]++;
						num3 -= 1 << class20_0.int_3 - 1 - num8;
					}
					while (num3 > 0 && num8 < class20_0.int_3 - 1);
					if (num3 <= 0)
					{
						break;
					}
				}
			}
			class20_0.int_2[class20_0.int_3 - 1] += num3;
			class20_0.int_2[class20_0.int_3 - 2] -= num3;
			num9 = 2 * num2;
			for (num10 = class20_0.int_3; num10 != 0; num10--)
			{
				num11 = class20_0.int_2[num10 - 1];
				while (num11 > 0)
				{
					num12 = 2 * int_0[num9++];
					if (int_0[num12 + 1] == -1)
					{
						class20_0.byte_0[int_0[num12]] = (byte)num10;
						num11--;
					}
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[16]
			{
				num, num2, num3, i, array, num4, num5, num7, num8, num9,
				num10, num11, num12, num6, class20_0, int_0
			});
			throw;
		}
	}

	static int smethod_95(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 1;
			while (true)
			{
				int num2;
				switch (int_3 ^ int_2)
				{
				case 74:
					num = 7;
					num2 = 1;
					break;
				default:
					num = 4;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 8;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_003c;
				case 0:
					num = 11;
					goto IL_0045;
				case 4:
					num = 6;
					goto IL_003c;
				case 5:
					num = 11;
					goto IL_0045;
				case 6:
					num = 2;
					goto IL_0051;
				case 7:
					num = 2;
					goto IL_0051;
				case 2:
					goto IL_0055;
				case 1:
					num = 5;
					break;
				case 3:
					{
						num = 5;
						break;
					}
					IL_0051:
					num3 = 2;
					num = 8;
					goto IL_0055;
					IL_0045:
					num3 = 2;
					num = 8;
					goto IL_0055;
					IL_003c:
					num3 = 2;
					num = 8;
					goto IL_0055;
				}
				break;
				IL_0055:
				num = 1;
			}
			return Class24.smethod_89(stream_0, byte_0, int_0, int_1, 356, 300);
		}
		catch (Exception exception_)
		{
			Class24.smethod_70(exception_, (object)num3, (object)num, (object)stream_0, (object)byte_0, (object)int_0, (object)int_1, (object)int_2, (object)int_3);
			throw;
		}
	}

	static void smethod_96(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					appDomain_0.SetData(string_0, object_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_117(exception_, (object)num, (object)num2, (object)appDomain_0, (object)string_0, object_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_97(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_98(Class17.Stream0 stream0_0, int int_0)
	{
		try
		{
			Class24.smethod_178(stream0_0, int_0);
			Class24.smethod_178(stream0_0, int_0 >> 16);
		}
		catch (Exception exception_)
		{
			Class24.smethod_80(exception_, (object)stream0_0, (object)int_0);
			throw;
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern short GetVersionEx(ref Class38.Struct11 struct11_0);

	static Evidence smethod_99(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 5;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 123:
					num = 6;
					num2 = 7;
					break;
				default:
					num = 1;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 10;
				switch (num3)
				{
				default:
					num = 9;
					goto IL_0042;
				case 0:
					num = 8;
					goto IL_0058;
				case 1:
					num = 4;
					goto IL_004f;
				case 2:
					num = 9;
					goto IL_0042;
				case 3:
					num = 5;
					break;
				case 4:
					num = 4;
					goto IL_004f;
				case 6:
					num = 8;
					goto IL_0058;
				case 5:
					num = 5;
					break;
				case 7:
					{
						num = 2;
						return Class24.smethod_160(assembly_0, 988, 939);
					}
					IL_004f:
					num3 = 5;
					num = 10;
					goto case 5;
					IL_0058:
					num3 = 5;
					num = 10;
					goto case 5;
					IL_0042:
					num3 = 5;
					num = 10;
					goto case 5;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)assembly_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_100(int int_0, Class17.Class19 class19_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			class19_0.short_0[class19_0.int_1] = (short)int_0;
			byte[] byte_ = class19_0.byte_1;
			num = class19_0.int_1++;
			byte_[num] = (byte)(int_1 - 3);
			num2 = Class24.smethod_161(int_1 - 3, class19_0);
			class19_0.class20_0.short_0[num2]++;
			if (num2 >= 265 && num2 < 285)
			{
				class19_0.int_2 += (num2 - 261) / 4;
			}
			num3 = Class24.smethod_0(class19_0, int_0 - 1);
			class19_0.class20_1.short_0[num3]++;
			if (num3 >= 4)
			{
				class19_0.int_2 += num3 / 2 - 1;
			}
			return Class24.smethod_114(class19_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num2, (object)num3, (object)num, (object)class19_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_101(IWebProxy iwebProxy_0, Class26 class26_0)
	{
		class26_0.iwebProxy_0 = iwebProxy_0;
	}

	static bool smethod_102(Class17.Class21 class21_0, int int_0)
	{
		int num = default(int);
		int num2 = default(int);
		short[] short_ = default(short[]);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte b = default(byte);
		byte b2 = default(byte);
		int num8 = default(int);
		try
		{
			num = 128;
			num2 = 128;
			short_ = class21_0.short_1;
			num3 = class21_0.int_4;
			num4 = class21_0.int_4 + class21_0.int_2;
			num5 = Math.Max(class21_0.int_2, 2);
			num6 = Math.Max(class21_0.int_4 - 32506, 0);
			num7 = class21_0.int_4 + 258 - 1;
			b = class21_0.byte_0[num4 - 1];
			b2 = class21_0.byte_0[num4];
			if (num5 >= 8)
			{
				num >>= 2;
			}
			if (num2 > class21_0.int_5)
			{
				num2 = class21_0.int_5;
			}
			do
			{
				if (class21_0.byte_0[int_0 + num5] != b2 || class21_0.byte_0[int_0 + num5 - 1] != b || class21_0.byte_0[int_0] != class21_0.byte_0[num3] || class21_0.byte_0[int_0 + 1] != class21_0.byte_0[num3 + 1])
				{
					continue;
				}
				num8 = int_0 + 2;
				num3 += 2;
				while (class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && class21_0.byte_0[++num3] == class21_0.byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					class21_0.int_1 = int_0;
					num4 = num3;
					num5 = num3 - class21_0.int_4;
					if (num5 >= num2)
					{
						break;
					}
					b = class21_0.byte_0[num4 - 1];
					b2 = class21_0.byte_0[num4];
				}
				num3 = class21_0.int_4;
			}
			while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num6 && --num != 0);
			class21_0.int_2 = Math.Min(num5, class21_0.int_5);
			return class21_0.int_2 >= 3;
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[13]
			{
				num, num2, short_, num3, num8, num4, num5, num6, num7, b,
				b2, class21_0, int_0
			});
			throw;
		}
	}

	static Type smethod_103(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					num = 3;
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
				num = 2;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)runtimeTypeHandle_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static object smethod_104(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 7;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 1:
					num = 9;
					num2 = 5;
					break;
				default:
					num = 3;
					num2 = 4;
					break;
				}
				num3 = num2;
				num = 10;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_004f;
				case 1:
					num = 7;
					continue;
				case 2:
					num = 0;
					num3 = 3;
					num = 10;
					goto case 3;
				case 4:
					num = 5;
					num3 = 3;
					num = 10;
					goto case 3;
				case 6:
					num = 6;
					goto IL_004f;
				case 3:
					num = 7;
					continue;
				case 0:
					num = 1;
					break;
				case 5:
					num = 1;
					break;
				case 7:
					{
						num = 1;
						break;
					}
					IL_004f:
					num3 = 3;
					num = 10;
					goto case 3;
				}
				break;
			}
			return Class24.smethod_126(resourceManager_0, string_0, 665, 713);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num3, (object)num, (object)resourceManager_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_105(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			num = 3;
			while (true)
			{
				num2 = 10;
				num = 9;
				while (true)
				{
					num = 25;
					int num3;
					switch (int_1 ^ int_0)
					{
					case 124:
						num = 17;
						num3 = 3;
						break;
					default:
						num = 2;
						num3 = 5;
						break;
					}
					num2 = num3;
					num = 9;
					while (true)
					{
						int num6;
						int num5;
						switch (num2)
						{
						case 11:
							num = 11;
							num4 = 5;
							num2 = 7;
							num = 9;
							num = 1;
							goto IL_0021;
						case 7:
							num = 1;
							switch (num4)
							{
							case 5:
								break;
							default:
								num = 16;
								num6 = 4;
								goto IL_0025;
							case 0:
								num = 24;
								num6 = 2;
								goto IL_0025;
							case 1:
								num = 12;
								num6 = 10;
								goto IL_0025;
							case 2:
								num = 4;
								num6 = 11;
								goto IL_0025;
							case 3:
								num = 6;
								num6 = 4;
								goto IL_0025;
							case 4:
								num = 20;
								num6 = 11;
								goto IL_0025;
							case 6:
								num = 18;
								num6 = 8;
								goto IL_0025;
							case 7:
								num = 14;
								num6 = 4;
								goto IL_0025;
							}
							goto IL_0021;
						case 6:
							num = 26;
							goto IL_008a;
						case 5:
							num = 7;
							num5 = 2;
							goto IL_0094;
						case 4:
							num = 10;
							num4 = 5;
							num = 26;
							goto IL_008a;
						case 3:
							num = 5;
							num5 = 6;
							goto IL_0094;
						case 2:
							num = 22;
							num4 = 5;
							num2 = 7;
							num = 9;
							num = 1;
							goto IL_0021;
						case 10:
							break;
						default:
							num = 21;
							goto IL_011c;
						case 9:
							num = 21;
							goto IL_011c;
						case 12:
							goto end_IL_0100;
						case 0:
							num = 8;
							goto IL_0136;
						case 1:
							num = 8;
							goto IL_0136;
						case 8:
							{
								num = 8;
								goto IL_0136;
							}
							IL_0136:
							return Class24.smethod_182(643, 716);
							IL_011c:
							num2 = 12;
							num = 9;
							goto end_IL_0100;
							IL_0094:
							num4 = num5;
							num2 = 7;
							num = 9;
							goto case 7;
							IL_008a:
							num2 = 7;
							num = 9;
							goto case 7;
							IL_0021:
							num = 0;
							num6 = 10;
							goto IL_0025;
						}
						break;
						IL_0025:
						num2 = num6;
						num = 9;
					}
					continue;
					end_IL_0100:
					break;
				}
				num = 3;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num4, (object)num2, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static object smethod_106(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			num = 16;
			while (true)
			{
				num2 = 9;
				num = 23;
				while (true)
				{
					num = 19;
					int num3;
					switch (int_1 ^ int_0)
					{
					case 38:
						num = 8;
						num3 = 11;
						break;
					default:
						num = 28;
						num3 = 4;
						break;
					}
					num2 = num3;
					num = 23;
					while (true)
					{
						int num5;
						int num6;
						switch (num2)
						{
						case 11:
							num = 17;
							num5 = 6;
							goto IL_001a;
						case 0:
							num = 24;
							switch (num4)
							{
							default:
								num = 12;
								num6 = 1;
								goto IL_0083;
							case 0:
								num = 14;
								num6 = 12;
								goto IL_0083;
							case 1:
								num = 11;
								num6 = 8;
								goto IL_0083;
							case 2:
								num = 4;
								num6 = 2;
								goto IL_0083;
							case 3:
								num = 22;
								num6 = 12;
								goto IL_0083;
							case 4:
								break;
							case 5:
								num = 21;
								num6 = 1;
								goto IL_0083;
							case 6:
								num = 27;
								num6 = 12;
								goto IL_0083;
							case 7:
								num = 13;
								num6 = 2;
								goto IL_0083;
							}
							goto IL_006b;
						case 10:
							num = 20;
							goto IL_001e;
						case 8:
							num = 2;
							goto IL_0090;
						case 7:
							num = 2;
							goto IL_0090;
						case 4:
							num = 18;
							num5 = 2;
							goto IL_001a;
						case 3:
							num = 10;
							goto IL_00ac;
						case 2:
							num = 1;
							num4 = 4;
							num = 10;
							goto IL_00ac;
						case 1:
							num = 6;
							num4 = 4;
							num2 = 0;
							num = 23;
							num = 24;
							goto IL_006b;
						case 9:
							break;
						default:
							num = 9;
							goto IL_012e;
						case 6:
							num = 9;
							goto IL_012e;
						case 5:
							goto end_IL_0112;
						case 12:
							{
								num = 0;
								return Class24.smethod_104(resourceManager_0, string_0, 997, 996);
							}
							IL_012e:
							num2 = 5;
							num = 23;
							goto end_IL_0112;
							IL_00ac:
							num2 = 0;
							num = 23;
							goto case 0;
							IL_0090:
							num4 = 4;
							num2 = 0;
							num = 23;
							num = 24;
							goto IL_006b;
							IL_001a:
							num4 = num5;
							num = 20;
							goto IL_001e;
							IL_001e:
							num2 = 0;
							num = 23;
							goto case 0;
							IL_006b:
							num = 15;
							num6 = 9;
							goto IL_0083;
						}
						break;
						IL_0083:
						num2 = num6;
						num = 23;
					}
					continue;
					end_IL_0112:
					break;
				}
				num = 16;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num4, (object)num2, (object)num, (object)resourceManager_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_107()
	{
		try
		{
			return GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_108(short[] short_0, byte[] byte_0, Class17.Class19.Class20 class20_0)
	{
		try
		{
			class20_0.short_1 = short_0;
			class20_0.byte_0 = byte_0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)class20_0, (object)short_0, (object)byte_0);
			throw;
		}
	}

	static string[] smethod_109(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 11;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 105:
					num = 3;
					num2 = 5;
					break;
				default:
					num = 1;
					num2 = 3;
					break;
				}
				num3 = num2;
				num = 5;
				switch (num3)
				{
				default:
					num = 2;
					goto IL_004b;
				case 1:
					num = 9;
					goto IL_0043;
				case 2:
					num = 10;
					goto IL_0054;
				case 3:
					num = 9;
					goto IL_0043;
				case 4:
					num = 2;
					goto IL_004b;
				case 6:
					num = 10;
					goto IL_0054;
				case 7:
					goto IL_0058;
				case 0:
					num = 8;
					break;
				case 5:
					{
						num = 8;
						break;
					}
					IL_0054:
					num3 = 7;
					num = 5;
					goto IL_0058;
					IL_0043:
					num3 = 7;
					num = 5;
					goto IL_0058;
					IL_004b:
					num3 = 7;
					num = 5;
					goto IL_0058;
				}
				break;
				IL_0058:
				num = 11;
			}
			return Class24.smethod_41(assembly_0, 54, 14);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)assembly_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_110(Class17.Class22 class22_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			if (class22_0.int_2 > 0)
			{
				byte[] byte_ = class22_0.byte_0;
				num = class22_0.int_1++;
				byte_[num] = (byte)class22_0.uint_0;
				if (class22_0.int_2 > 8)
				{
					byte[] byte_2 = class22_0.byte_0;
					num2 = class22_0.int_1++;
					byte_2[num2] = (byte)(class22_0.uint_0 >> 8);
				}
			}
			class22_0.uint_0 = 0u;
			class22_0.int_2 = 0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)num2, (object)class22_0);
			throw;
		}
	}

	static void smethod_111(Class26 class26_0, Enum0 enum0_0, string string_0, string string_1)
	{
		class26_0.delegate1_0?.Invoke(class26_0, new EventArgs3(enum0_0, string_0, string_1));
	}

	static void smethod_112(Enum1 enum1_0, Control1 control1_0)
	{
		if (control1_0.enum1_0 != enum1_0)
		{
			control1_0.enum1_0 = enum1_0;
			switch (control1_0.enum1_0)
			{
			default:
				control1_0.object_0 = null;
				break;
			case Enum1.const_1:
				control1_0.object_0 = Class24.smethod_10("error16");
				break;
			case Enum1.const_2:
				control1_0.object_0 = Class24.smethod_10("warning16");
				break;
			}
			((Control)control1_0).Refresh();
		}
	}

	static void smethod_113(Class35 class35_0, EventHandler eventHandler_0)
	{
		EventHandler eventHandler = (EventHandler)class35_0.object_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref System.Runtime.CompilerServices.Unsafe.As<object, EventHandler>(ref class35_0.object_0), value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static bool smethod_114(Class17.Class19 class19_0)
	{
		try
		{
			return class19_0.int_1 >= 16384;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class19_0);
			throw;
		}
	}

	static void smethod_115(Class26 class26_0, Enum0 enum0_0)
	{
		Class24.smethod_67(class26_0, enum0_0, string.Empty);
	}

	static string smethod_116(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		char[] char_ = default(char[]);
		int num4 = default(int);
		int num5 = default(int);
		int num11 = default(int);
		int num9 = default(int);
		string text = default(string);
		char[] array = default(char[]);
		char[] char_2 = default(char[]);
		int num10 = default(int);
		try
		{
			num = 24;
			while (true)
			{
				num2 = 23;
				num = 34;
				while (true)
				{
					num = 19;
					num3 = int_0 ^ 0x5F8D081D ^ int_1;
					char_ = Class5.char_1;
					num4 = char_[num3];
					num = 27;
					num2 = 9;
					num = 34;
					while (true)
					{
						num = 30;
						num5 = 9;
						num2 = 10;
						num = 34;
						num = 20;
						while (true)
						{
							IL_0276:
							num = 9;
							int num6 = 12;
							while (true)
							{
								num2 = num6;
								num = 34;
								while (true)
								{
									int num8;
									int num7;
									switch (num2)
									{
									case 24:
									{
										num = 41;
										int num13;
										if (num11 >= num9)
										{
											num = 0;
											num13 = 20;
										}
										else
										{
											num = 10;
											num13 = 13;
										}
										num2 = num13;
										num = 34;
										continue;
									}
									case 12:
									{
										num = 2;
										int num12;
										if ((text = Class5.string_0[num4]) != null)
										{
											num = 17;
											num12 = 16;
										}
										else
										{
											num = 36;
											num12 = 25;
										}
										num2 = num12;
										num = 34;
										continue;
									}
									case 1:
										num = 14;
										num11 = 1 + num11;
										num5 = 11;
										num = 8;
										goto IL_0100;
									case 4:
										num = 16;
										array[num11] = (char)(char_[num3 + num11] ^ char_2[(num11 + num4) % num10]);
										num = 1;
										num2 = 0;
										num = 34;
										goto case 0;
									case 0:
										num = 21;
										num5 = 13;
										num2 = 10;
										num = 34;
										num = 20;
										goto IL_0269;
									case 11:
										num = 8;
										goto IL_0100;
									case 13:
										num = 44;
										num8 = 1;
										goto IL_0180;
									case 14:
										break;
									case 16:
										num = 22;
										num7 = 4;
										goto IL_01cc;
									case 17:
										goto IL_012d;
									case 18:
										num = 18;
										num9 = char_[num3 + 1];
										num9 = (int)((uint)char_[num3 + 2] << 16) + num9;
										num = 15;
										num2 = 5;
										num = 34;
										goto case 5;
									case 5:
										num = 35;
										num5 = 7;
										num2 = 10;
										num = 34;
										num = 20;
										goto IL_0247;
									case 19:
										num = 25;
										goto IL_018c;
									case 20:
										num = 7;
										num8 = 12;
										goto IL_0180;
									case 22:
										num = 25;
										goto IL_018c;
									case 21:
										num = 11;
										char_2 = Class5.char_0;
										num10 = char_2.Length;
										num3 += 3;
										num = 45;
										num2 = 8;
										num = 34;
										goto case 8;
									case 8:
										num = 38;
										num5 = 2;
										num2 = 10;
										num = 34;
										num = 20;
										goto IL_0228;
									case 25:
										num = 47;
										num7 = 0;
										goto IL_01cc;
									case 10:
										goto IL_01d3;
									case 9:
										goto end_IL_026d;
									case 23:
										goto end_IL_027d;
									default:
										num = 5;
										goto IL_02bb;
									case 15:
										num = 5;
										goto IL_02bb;
									case 2:
										num = 24;
										goto end_IL_028e;
									case 3:
										num = 6;
										goto IL_02d1;
									case 6:
										num = 6;
										goto IL_02d1;
									case 7:
										{
											num = 48;
											return text;
										}
										IL_02d1:
										text = new string(array);
										Class5.string_0[num4] = text;
										return text;
										IL_02bb:
										num2 = 2;
										num = 34;
										goto case 2;
										IL_018c:
										array = new char[num9];
										num2 = 21;
										num = 34;
										goto case 21;
										IL_01cc:
										num5 = num7;
										num2 = 10;
										num = 34;
										goto IL_01d3;
										IL_0180:
										num5 = num8;
										num2 = 10;
										num = 34;
										goto IL_01d3;
										IL_0100:
										num2 = 10;
										num = 34;
										goto IL_01d3;
									}
									break;
								}
								num = 31;
								num5 = 8;
								num2 = 10;
								num = 34;
								num = 20;
								goto IL_024e;
								IL_0222:
								num = 33;
								num6 = 4;
								continue;
								IL_012d:
								num = 12;
								num11 = 0;
								num5 = 11;
								num2 = 10;
								num = 34;
								num = 20;
								goto IL_025c;
								IL_021b:
								num = 42;
								num6 = 18;
								continue;
								IL_01d3:
								num = 20;
								switch (num5)
								{
								case 0:
									goto IL_021b;
								case 1:
									goto IL_0222;
								case 2:
									goto IL_0228;
								case 3:
									goto IL_022e;
								case 4:
									goto IL_0235;
								case 5:
									goto IL_023b;
								case 6:
									goto IL_0240;
								case 7:
									goto IL_0247;
								case 8:
									goto IL_024e;
								case 10:
									goto IL_0255;
								case 11:
									goto IL_025c;
								case 12:
									goto IL_0263;
								case 13:
									goto IL_0269;
								case 9:
									goto IL_0276;
								}
								num = 52;
								num6 = 14;
								continue;
								IL_0269:
								num = 51;
								num6 = 1;
								continue;
								IL_0263:
								num = 40;
								num6 = 6;
								continue;
								IL_025c:
								num = 39;
								num6 = 24;
								continue;
								IL_0255:
								num = 32;
								num6 = 14;
								continue;
								IL_024e:
								num = 46;
								num6 = 23;
								continue;
								IL_0247:
								num = 49;
								num6 = 22;
								continue;
								IL_0240:
								num = 13;
								num6 = 21;
								continue;
								IL_023b:
								num = 4;
								num6 = 0;
								continue;
								IL_0235:
								num = 29;
								num6 = 7;
								continue;
								IL_022e:
								num = 23;
								num6 = 14;
								continue;
								IL_0228:
								num = 3;
								num6 = 17;
								continue;
								end_IL_026d:
								break;
							}
							break;
						}
						continue;
						end_IL_027d:
						break;
					}
					continue;
					end_IL_028e:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[14]
			{
				num3, num4, num9, char_, text, array, char_2, num10, num11, num5,
				num2, num, int_0, int_1
			});
			throw;
		}
	}

	static void smethod_117(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class24.smethod_24(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static string smethod_118()
	{
		return "SmartAssembly" + " " + Class24.smethod_175();
	}

	static Evidence smethod_119(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 3;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 42:
					num = 1;
					num2 = 4;
					break;
				default:
					num = 7;
					num2 = 0;
					break;
				}
				num3 = num2;
				num = 11;
				switch (num3)
				{
				default:
					num = 5;
					goto IL_0047;
				case 0:
					num = 9;
					num3 = 1;
					num = 11;
					goto IL_0056;
				case 2:
					num = 10;
					goto IL_0051;
				case 3:
					num = 5;
					goto IL_0047;
				case 7:
					num = 10;
					goto IL_0051;
				case 1:
					goto IL_0056;
				case 4:
					num = 2;
					break;
				case 5:
					num = 2;
					break;
				case 6:
					{
						num = 2;
						break;
					}
					IL_0051:
					num3 = 1;
					num = 11;
					goto IL_0056;
					IL_0047:
					num3 = 1;
					num = 11;
					goto IL_0056;
				}
				break;
				IL_0056:
				num = 3;
			}
			return Class24.smethod_99(assembly_0, 585, 562);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)assembly_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_120(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 88:
					Monitor.Enter(object_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_21(exception_, (object)num, (object)num2, object_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_121(string string_0, Control0 control0_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.object_0 = Class24.smethod_10((string_0.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static string smethod_122(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					num = 6;
					return resolveEventArgs_0.Name;
				}
				num = 0;
				num = 1;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)resolveEventArgs_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_123(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class24.smethod_24(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_124(ProcessStartInfo processStartInfo_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 6;
			num2 = 1;
			num = 8;
			while (true)
			{
				num = 1;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 7:
						num = 4;
						num3 = 0;
						break;
					default:
						num = 10;
						num3 = 3;
						break;
					}
					num2 = num3;
					num = 8;
					switch (num2)
					{
					default:
						goto IL_002d;
					case 3:
						num = 2;
						num2 = 1;
						num = 8;
						break;
					case 1:
						break;
					case 0:
						num = 0;
						goto IL_005b;
					case 2:
						num = 0;
						goto IL_005b;
					case 4:
						num = 0;
						goto IL_005b;
					case 5:
						{
							num = 7;
							return;
						}
						IL_005b:
						Class24.smethod_174(processStartInfo_0, string_0, 464, 501);
						return;
					}
					break;
					IL_002d:
					num = 1;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_70(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)processStartInfo_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_125(Class17.Class19.Class20 class20_0, int int_0)
	{
		try
		{
			Class24.smethod_148(class20_0.class19_0.class22_0, class20_0.short_1[int_0] & 0xFFFF, (int)class20_0.byte_0[int_0]);
		}
		catch (Exception exception_)
		{
			Class24.smethod_80(exception_, (object)class20_0, (object)int_0);
			throw;
		}
	}

	static object smethod_126(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 80:
					num = 5;
					return resourceManager_0.GetObject(string_0);
				}
				num = 0;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num, (object)resourceManager_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static Icon smethod_127()
	{
		try
		{
			return Class24.smethod_34();
		}
		catch (Exception)
		{
			return Class24.smethod_149("default");
		}
	}

	static byte[] smethod_128(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					num = 7;
					return encoding_0.GetBytes(string_0);
				}
				num = 2;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num, (object)encoding_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static int smethod_129(Class17.Class22 class22_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			if (class22_0.int_2 >= 8)
			{
				byte[] byte_ = class22_0.byte_0;
				num = class22_0.int_1++;
				byte_[num] = (byte)class22_0.uint_0;
				class22_0.uint_0 >>= 8;
				class22_0.int_2 -= 8;
			}
			if (int_1 > class22_0.int_1 - class22_0.int_0)
			{
				int_1 = class22_0.int_1 - class22_0.int_0;
				Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
				class22_0.int_0 = 0;
				class22_0.int_1 = 0;
			}
			else
			{
				Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
				class22_0.int_0 += int_1;
			}
			return int_1;
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num, (object)class22_0, (object)byte_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_130(Exception exception_0, object object_0)
	{
		Class24.smethod_24(exception_0, new object[1] { object_0 });
	}

	static int smethod_131(Font font_0, Graphics graphics_0, int int_0, string string_0)
	{
		Class38.Struct10 struct10_ = new Class38.Struct10(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct10_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct10_.int_3 - struct10_.int_1;
	}

	static void smethod_132(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.object_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static void smethod_133(EventArgs2 eventArgs2_0, bool bool_0)
	{
		eventArgs2_0.bool_0 = bool_0;
	}

	static void smethod_134(Form1 form1_0)
	{
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_1).set_Size(new Size(100, 24));
		((Control)form1_0.button_1).set_Location(new Point(408 - ((Control)form1_0.button_1).get_Width(), 188));
		((Control)form1_0.button_1).set_TabIndex(0);
		((Control)form1_0.button_1).set_Text("&Quit");
		((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
		((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_0).set_Size(new Size(100, 24));
		((Control)form1_0.button_0).set_Location(new Point(((Control)form1_0.button_1).get_Left() - ((Control)form1_0.button_0).get_Width() - 6, 188));
		((Control)form1_0.button_0).set_TabIndex(1);
		((Control)form1_0.button_0).set_Text("&Continue");
		((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
		((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form1_0.control2_0).SetBounds(6, 186, 120, 32);
		Class24.smethod_112(Enum1.const_2, form1_0.control1_0);
		((Control)form1_0.class34_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class34_0).set_Location(new Point(20, 72));
		((Control)form1_0.class34_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class34_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static void smethod_135(string string_0, string string_1, byte[] byte_0, Delegate2 delegate2_0, Class37 class37_0, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class37_0.string_2);
			if (class37_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class37_0.iwebProxy_0);
			}
			delegate2_0(reportingService.UploadReport2(class37_0.string_1, byte_0, string_0, string_2, string_1));
		}
		catch (Exception ex)
		{
			delegate2_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_136(Class27 class27_0, string string_0)
	{
		try
		{
			byte[] byte_ = class27_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class24.smethod_71(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class24.smethod_29(byte_2, "<RSAKeyValue><Modulus>tIVJVRm6tPRSO3G1BcGrNNgQyMA8I+s004q5SolBEHbW1J1dSg9oj7MS7PFKkAhXiLdjf7U6U7zrHaJEZlAGXFMn3hXq6cuE4io2iC7P46DPmo633MVZ7p6XVrQWaf9DQM9frL6InGxALDtU5bhNkaqlx8GgafEsdD4D60gXX9k=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{ED572A83-61B0-47F7-BC2D-38A950D9B848}");
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			return true;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static Assembly smethod_137()
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

	static byte[] smethod_138(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 84:
					num = 5;
					return memoryStream_0.ToArray();
				}
				num = 4;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)memoryStream_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_139(string string_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 24:
					File.WriteAllBytes(string_0, byte_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_9(exception_, (object)num, (object)num2, (object)string_0, (object)byte_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static AppDomain smethod_140(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 33:
					num = 2;
					return AppDomain.CurrentDomain;
				}
				num = 0;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_141(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.object_0 = Class24.smethod_10("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static string smethod_142(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					num = 7;
					return string_0 + string_1;
				}
				num = 4;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num, (object)string_0, (object)string_1, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_143(bool bool_0, Class17.Class21 class21_0, bool bool_1)
	{
		bool flag = default(bool);
		bool flag2 = default(bool);
		try
		{
			do
			{
				Class24.smethod_92(class21_0);
				flag = bool_0 && class21_0.int_7 == class21_0.int_8;
				flag2 = Class24.smethod_146(bool_1, flag, class21_0);
			}
			while (Class24.smethod_18(class21_0.class22_0) && flag2);
			return flag2;
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)flag2, (object)flag, (object)class21_0, (object)bool_0, (object)bool_1);
			throw;
		}
	}

	static void smethod_144(int int_0, byte[] byte_0, int int_1, Class17.Class22 class22_0)
	{
		try
		{
			Array.Copy(byte_0, int_1, class22_0.byte_0, class22_0.int_1, int_0);
			class22_0.int_1 += int_0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)class22_0, (object)byte_0, (object)int_1, (object)int_0);
			throw;
		}
	}

	static void smethod_145(Class27 class27_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class24.smethod_136(class27_0, tempFileName);
			string path = Class24.smethod_72();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class27_0.eventHandler_0 != null)
			{
				class27_0.eventHandler_0(class27_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			Class24.smethod_173(class27_0, new EventArgs0(exception_));
		}
	}

	static bool smethod_146(bool bool_0, bool bool_1, Class17.Class21 class21_0)
	{
		int int_ = default(int);
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		try
		{
			if (class21_0.int_5 < 262 && !bool_1)
			{
				return false;
			}
			Class17.Class19 class19_3;
			byte[] byte_;
			int int_4;
			do
			{
				if (class21_0.int_5 >= 262 || bool_1)
				{
					if (class21_0.int_5 != 0)
					{
						if (class21_0.int_4 >= 65274)
						{
							Class24.smethod_35(class21_0);
						}
						int_ = class21_0.int_1;
						num = class21_0.int_2;
						if (class21_0.int_5 >= 3)
						{
							num2 = Class24.smethod_167(class21_0);
							if (num2 != 0 && class21_0.int_4 - num2 <= 32506 && Class24.smethod_102(class21_0, num2) && class21_0.int_2 <= 5 && class21_0.int_2 == 3 && class21_0.int_4 - class21_0.int_1 > 4096)
							{
								class21_0.int_2 = 2;
							}
						}
						if (num >= 3 && class21_0.int_2 <= num)
						{
							Class17.Class19 class19_ = class21_0.class19_0;
							int int_2 = class21_0.int_4 - 1 - int_;
							Class24.smethod_100(int_2, class19_, num);
							num -= 2;
							do
							{
								class21_0.int_4++;
								class21_0.int_5--;
								if (class21_0.int_5 >= 3)
								{
									Class24.smethod_167(class21_0);
								}
							}
							while (--num > 0);
							class21_0.int_4++;
							class21_0.int_5--;
							class21_0.bool_0 = false;
							class21_0.int_2 = 2;
						}
						else
						{
							if (class21_0.bool_0)
							{
								Class17.Class19 class19_2 = class21_0.class19_0;
								int int_3 = class21_0.byte_0[class21_0.int_4 - 1] & 0xFF;
								Class24.smethod_42(int_3, class19_2);
							}
							class21_0.bool_0 = true;
							class21_0.int_4++;
							class21_0.int_5--;
						}
						continue;
					}
					if (class21_0.bool_0)
					{
						Class17.Class19 class19_2 = class21_0.class19_0;
						int int_3 = class21_0.byte_0[class21_0.int_4 - 1] & 0xFF;
						Class24.smethod_42(int_3, class19_2);
					}
					class21_0.bool_0 = false;
					class19_3 = class21_0.class19_0;
					byte_ = class21_0.byte_0;
					int_4 = class21_0.int_3;
					int int_5 = class21_0.int_4 - class21_0.int_3;
					Class24.smethod_76(bool_0, int_4, int_5, class19_3, byte_);
					class21_0.int_3 = class21_0.int_4;
					return false;
				}
				return true;
			}
			while (!Class24.smethod_114(class21_0.class19_0));
			num3 = class21_0.int_4 - class21_0.int_3;
			if (class21_0.bool_0)
			{
				num3--;
			}
			flag = bool_0 && class21_0.int_5 == 0 && !class21_0.bool_0;
			class19_3 = class21_0.class19_0;
			byte_ = class21_0.byte_0;
			int_4 = class21_0.int_3;
			Class24.smethod_76(flag, int_4, num3, class19_3, byte_);
			class21_0.int_3 += num3;
			return !flag;
		}
		catch (Exception exception_)
		{
			Class24.smethod_70(exception_, (object)int_, (object)num, (object)num2, (object)num3, (object)flag, (object)class21_0, (object)bool_1, (object)bool_0);
			throw;
		}
	}

	static string smethod_147(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int num)
			{
				return num.ToString("x");
			}
			if (object_0 is long num2)
			{
				return num2.ToString("x");
			}
			if (object_0 is short num3)
			{
				return num3.ToString("x");
			}
			if (object_0 is uint num4)
			{
				return num4.ToString("x");
			}
			if (object_0 is ulong num5)
			{
				return num5.ToString("x");
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString("x");
			}
			if (object_0 is byte b)
			{
				return b.ToString("x");
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString("x");
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString("x");
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_148(Class17.Class22 class22_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			class22_0.uint_0 |= (uint)(int_0 << class22_0.int_2);
			class22_0.int_2 += int_1;
			if (class22_0.int_2 >= 16)
			{
				byte[] byte_ = class22_0.byte_0;
				num = class22_0.int_1++;
				byte_[num] = (byte)class22_0.uint_0;
				byte[] byte_2 = class22_0.byte_0;
				num2 = class22_0.int_1++;
				byte_2[num2] = (byte)(class22_0.uint_0 >> 8);
				class22_0.uint_0 >>= 16;
				class22_0.int_2 -= 16;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num, (object)num2, (object)class22_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static Icon smethod_149(string string_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".ico");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_150(byte[] byte_0, bool bool_0, int int_0, Class17.Class19 class19_0, int int_1)
	{
		try
		{
			Class24.smethod_148(class19_0.class22_0, bool_0 ? 1 : 0, 3);
			Class24.smethod_110(class19_0.class22_0);
			Class24.smethod_93(int_0, class19_0.class22_0);
			Class24.smethod_93(~int_0, class19_0.class22_0);
			Class24.smethod_144(int_0, byte_0, int_1, class19_0.class22_0);
			Class24.smethod_28(class19_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)class19_0, (object)byte_0, (object)int_1, (object)int_0, (object)bool_0);
			throw;
		}
	}

	static ProcessStartInfo smethod_151(Process process_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 12;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 73:
					num = 1;
					num2 = 5;
					break;
				default:
					num = 6;
					num2 = 6;
					break;
				}
				num3 = num2;
				num = 3;
				switch (num3)
				{
				default:
					num = 9;
					goto IL_003a;
				case 1:
					num = 9;
					goto IL_003a;
				case 2:
					num = 11;
					goto IL_004d;
				case 3:
					num = 12;
					continue;
				case 4:
					num = 11;
					goto IL_004d;
				case 6:
					num = 0;
					num3 = 7;
					num = 3;
					goto case 7;
				case 7:
					num = 12;
					continue;
				case 0:
					num = 10;
					break;
				case 5:
					{
						num = 10;
						break;
					}
					IL_004d:
					num3 = 7;
					num = 3;
					goto case 7;
					IL_003a:
					num3 = 7;
					num = 3;
					goto case 7;
				}
				break;
			}
			return Class24.smethod_180(process_0, 98, 20);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)process_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_152(Class17.Class19.Class20 class20_0)
	{
		int num = default(int);
		int[] array = default(int[]);
		int num2 = default(int);
		int num3 = default(int);
		int i = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int[] array2 = default(int[]);
		int[] array3 = default(int[]);
		int num9 = default(int);
		int j = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		try
		{
			num = class20_0.short_0.Length;
			array = new int[num];
			num2 = 0;
			num3 = 0;
			for (i = 0; i < num; i++)
			{
				num4 = class20_0.short_0[i];
				if (num4 != 0)
				{
					num5 = num2++;
					while (num5 > 0 && class20_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
					{
						array[num5] = array[num6];
						num5 = num6;
					}
					array[num5] = i;
					num3 = i;
				}
			}
			while (num2 < 2)
			{
				num7 = ((num3 < 2) ? (++num3) : 0);
				array[num2++] = num7;
			}
			class20_0.int_1 = Math.Max(num3 + 1, class20_0.int_0);
			num8 = num2;
			array2 = new int[4 * num2 - 2];
			array3 = new int[2 * num2 - 1];
			num9 = num8;
			for (j = 0; j < num2; j++)
			{
				num10 = (array2[2 * j] = array[j]);
				array2[2 * j + 1] = -1;
				array3[j] = class20_0.short_0[num10] << 8;
				array[j] = j;
			}
			do
			{
				num11 = array[0];
				num12 = array[--num2];
				num13 = 0;
				for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				num15 = array3[num12];
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
				num16 = array[0];
				num12 = num9++;
				array2[2 * num12] = num11;
				array2[2 * num12 + 1] = num16;
				num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
				num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
				num13 = 0;
				for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
				{
					if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
					{
						num14++;
					}
					array[num13] = array[num14];
					num13 = num14;
				}
				while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
				{
					array[num14] = array[num13];
				}
				array[num14] = num12;
			}
			while (num2 > 1);
			Class24.smethod_94(array2, class20_0);
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[23]
			{
				num, array, num2, num3, i, num4, num5, num6, num7, num8,
				array2, array3, num9, j, num10, num11, num12, num13, num14, num15,
				num16, num17, class20_0
			});
			throw;
		}
	}

	static void smethod_153(byte[] byte_0, Class17.Class21 class21_0)
	{
		try
		{
			class21_0.object_0 = byte_0;
			class21_0.int_7 = 0;
			class21_0.int_8 = byte_0.Length;
		}
		catch (Exception exception_)
		{
			Class24.smethod_80(exception_, (object)class21_0, (object)byte_0);
			throw;
		}
	}

	static void smethod_154(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 8;
			num2 = 5;
			num = 2;
			while (true)
			{
				num = 1;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 118:
						num = 4;
						num3 = 3;
						break;
					default:
						num = 3;
						num3 = 0;
						break;
					case 119:
						Class24.smethod_96(appDomain_0, string_0, object_0, 922, 981);
						return;
					}
					num2 = num3;
					num = 2;
					switch (num2)
					{
					default:
						goto IL_002d;
					case 0:
						num = 10;
						num2 = 5;
						num = 2;
						break;
					case 5:
						break;
					case 1:
						num = 6;
						goto IL_0065;
					case 2:
						num = 0;
						return;
					case 3:
						num = 6;
						goto IL_0065;
					case 4:
						{
							num = 6;
							goto IL_0065;
						}
						IL_0065:
						Class24.smethod_23(appDomain_0, string_0, object_0, 0, 97);
						return;
					}
					break;
					IL_002d:
					num = 1;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_26(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)appDomain_0, (object)string_0, object_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static int smethod_155(string string_0, int int_0, Graphics graphics_0, Font font_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_156(Delegate1 delegate1_0, Class26 class26_0)
	{
		Delegate1 @delegate = class26_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class26_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static bool smethod_157(Process process_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 68:
					num = 2;
					return process_0.Start();
				}
				num = 0;
				num = 4;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)process_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static Assembly[] smethod_158(Class27 class27_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class24.smethod_137() };
		}
	}

	static bool smethod_159()
	{
		try
		{
			Class38.Struct12 struct12_ = default(Class38.Struct12);
			GetSystemInfo(ref struct12_);
			return struct12_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static Evidence smethod_160(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					num = 7;
					return assembly_0.get_Evidence();
				}
				num = 1;
				num = 3;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)assembly_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static int smethod_161(int int_0, Class17.Class19 class19_0)
	{
		int num = default(int);
		try
		{
			if (int_0 == 255)
			{
				return 285;
			}
			num = 257;
			while (int_0 >= 8)
			{
				num += 4;
				int_0 >>= 1;
			}
			return num + int_0;
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)class19_0, (object)int_0);
			throw;
		}
	}

	static object smethod_162(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 97:
					num = 5;
					return appDomain_0.GetData(string_0);
				}
				num = 1;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num, (object)appDomain_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_163(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 10;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 73:
					num = 8;
					num2 = 0;
					break;
				default:
					num = 2;
					num2 = 2;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_004a;
				case 1:
					num = 6;
					goto IL_004a;
				case 2:
					num = 11;
					num3 = 5;
					num = 1;
					goto IL_0057;
				case 3:
					num = 9;
					goto IL_0053;
				case 4:
					num = 6;
					goto IL_004a;
				case 6:
					num = 9;
					goto IL_0053;
				case 5:
					goto IL_0057;
				case 0:
					num = 3;
					break;
				case 7:
					{
						num = 3;
						break;
					}
					IL_0053:
					num3 = 5;
					num = 1;
					goto IL_0057;
					IL_004a:
					num3 = 5;
					num = 1;
					goto IL_0057;
				}
				break;
				IL_0057:
				num = 10;
			}
			return Class24.smethod_142(string_0, string_1, 849, 790);
		}
		catch (Exception exception_)
		{
			Class24.smethod_9(exception_, (object)num3, (object)num, (object)string_0, (object)string_1, (object)int_0, (object)int_1);
			throw;
		}
	}

	static bool smethod_164()
	{
		try
		{
			return Class13.smethod_0();
		}
		catch (Exception exception_)
		{
			Class24.smethod_73(exception_);
			throw;
		}
	}

	static void smethod_165(Class27 class27_0, Exception exception_0)
	{
		using (new Class39(class27_0.xmlTextWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class27_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class27_0.xmlTextWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class27_0.xmlTextWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class27_0.xmlTextWriter_0.WriteAttributeString("Method", text);
				class27_0.method_1(new Class31(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_166(Class17.Class18 class18_0)
	{
		try
		{
			class18_0.int_0 |= 12;
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class18_0);
			throw;
		}
	}

	static int smethod_167(Class17.Class21 class21_0)
	{
		int num = default(int);
		short num2 = default(short);
		try
		{
			num = ((class21_0.int_0 << 5) ^ class21_0.byte_0[class21_0.int_4 + 2]) & 0x7FFF;
			num2 = (class21_0.short_1[class21_0.int_4 & 0x7FFF] = class21_0.short_0[num]);
			class21_0.short_0[num] = (short)class21_0.int_4;
			class21_0.int_0 = num;
			return num2 & 0xFFFF;
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num2, (object)num, (object)class21_0);
			throw;
		}
	}

	static string smethod_168()
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

	static Assembly smethod_169(ResolveEventArgs resolveEventArgs_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, string string_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num6 = default(int);
		AppDomain appDomain = default(AppDomain);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		Assembly assembly = default(Assembly);
		string text = default(string);
		byte[] array = default(byte[]);
		int num8 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		DeflateStream deflateStream = default(DeflateStream);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		byte[] array2 = default(byte[]);
		int num15 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int num19 = default(int);
		int num23 = default(int);
		Assembly assembly2 = default(Assembly);
		int num24 = default(int);
		int num27 = default(int);
		string[] array3 = default(string[]);
		string text2 = default(string);
		try
		{
			num = 0;
			while (true)
			{
				num2 = 4;
				num = 14;
				while (true)
				{
					num = 8;
					if (int_0 > 0)
					{
						num = 12;
						num2 = 18;
						num = 14;
						while (true)
						{
							num = 28;
							num3 = 10;
							num = 46;
							while (true)
							{
								num2 = 15;
								num = 14;
								while (true)
								{
									num = 25;
									int num4;
									int num9;
									switch (num3)
									{
									case 13:
										num = 27;
										num4 = 14;
										goto IL_0252;
									case 2:
										goto IL_0141;
									case 9:
										goto IL_0186;
									case 11:
										num = 36;
										num4 = 4;
										goto IL_0252;
									case 3:
										goto IL_01e0;
									case 7:
										num = 31;
										num4 = 23;
										goto IL_0252;
									case 0:
										goto IL_023a;
									case 12:
										goto IL_024e;
									case 10:
										num = 1;
										num4 = 5;
										goto IL_0252;
									case 8:
										num = 52;
										num4 = 8;
										goto IL_0252;
									case 6:
										num = 2;
										num4 = 12;
										goto IL_0252;
									case 5:
										num = 48;
										num4 = 6;
										goto IL_0252;
									case 4:
										num = 16;
										num4 = 2;
										goto IL_0252;
									case 1:
										num = 35;
										num4 = 3;
										goto IL_0252;
									default:
										{
											num = 41;
											num4 = 12;
											goto IL_0252;
										}
										IL_0252:
										num2 = num4;
										num = 14;
										while (true)
										{
											int num5;
											switch (num2)
											{
											case 7:
											{
												num = 26;
												int num7;
												if (num6 >= int_0)
												{
													num = 20;
													num7 = 17;
												}
												else
												{
													num = 50;
													num7 = 10;
												}
												num2 = num7;
												num = 14;
												continue;
											}
											case 0:
												num = 11;
												goto IL_01a5;
											case 2:
												break;
											case 3:
												num = 49;
												appDomain = Class24.smethod_12(66, 90);
												dictionary = (Dictionary<string, string>)Class24.smethod_43(appDomain, string_0, 420, 405);
												num = 15;
												num2 = 24;
												num = 14;
												goto case 24;
											case 5:
												num = 13;
												assembly = Class24.smethod_64(494, 488);
												text = Class24.smethod_82(string_0, Class24.smethod_37(1603078171, 6), 650, 687);
												num = 23;
												num2 = 6;
												num = 14;
												goto case 6;
											case 6:
												num = 40;
												num3 = 2;
												num2 = 15;
												num = 14;
												num = 25;
												goto IL_0141;
											case 8:
												num = 37;
												array[num6] ^= (byte)((num6 + int_1) & 0xFF);
												num = 29;
												num2 = 1;
												num = 14;
												goto case 1;
											case 1:
												num = 51;
												num3 = 9;
												num2 = 15;
												num = 14;
												num = 25;
												goto IL_0186;
											case 11:
												num = 24;
												Class24.smethod_36((Array)array, runtimeFieldHandle_0, 648, 737);
												goto IL_01a5;
											case 12:
												goto IL_01b5;
											case 13:
												num = 43;
												num6++;
												num3 = 3;
												num2 = 15;
												num = 14;
												num = 25;
												goto IL_01e0;
											case 16:
												goto IL_01e6;
											case 21:
												num = 38;
												goto IL_0203;
											case 23:
												num = 38;
												goto IL_0203;
											case 9:
												num = 5;
												num3 = 0;
												num2 = 15;
												num = 14;
												num = 25;
												goto IL_023a;
											case 24:
												num = 3;
												num3 = 12;
												num2 = 15;
												num = 14;
												num = 25;
												goto IL_024e;
											case 10:
												num = 9;
												num5 = 8;
												goto IL_0266;
											case 17:
												num = 30;
												num5 = 13;
												goto IL_0266;
											case 15:
												goto end_IL_029d;
											case 20:
												goto end_IL_0299;
											case 18:
												goto end_IL_02df;
											case 4:
												goto end_IL_02e7;
											default:
												num = 45;
												goto IL_0308;
											case 22:
												num = 45;
												goto IL_0308;
											case 19:
												num = 0;
												goto end_IL_02f2;
											case 14:
												goto IL_0317;
												IL_0308:
												num2 = 19;
												num = 14;
												goto case 19;
												IL_0266:
												num3 = num5;
												num2 = 15;
												num = 14;
												goto end_IL_029d;
												IL_0203:
												dictionary = new Dictionary<string, string>();
												Class24.smethod_154(appDomain, string_0, (object)dictionary, 773, 883);
												array = new byte[int_0];
												num = 34;
												num2 = 9;
												num = 14;
												goto case 9;
												IL_01a5:
												num6 = 0;
												num3 = 3;
												num2 = 15;
												num = 14;
												num = 25;
												goto IL_01e0;
											}
											break;
										}
										num = 32;
										if (dictionary == null)
										{
											num = 44;
											num2 = 16;
											num = 14;
											goto IL_01e6;
										}
										goto IL_07e4;
										IL_08be:
										num8 = 43;
										num9 = 1;
										goto IL_08b3;
										IL_0317:
										num = 39;
										memoryStream = new MemoryStream();
										deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true);
										try
										{
											num10 = 12;
											num11 = 0;
											num10 = 1;
											while (true)
											{
												num10 = 6;
												while (true)
												{
													num12 = 1;
													num11 = 11;
													num10 = 1;
													num10 = 13;
													while (true)
													{
														IL_0470:
														num10 = 7;
														int num13 = 8;
														while (true)
														{
															num11 = num13;
															num10 = 1;
															while (true)
															{
																int num14;
																int num16;
																switch (num11)
																{
																case 9:
																	num10 = 21;
																	goto IL_0344;
																case 3:
																	num10 = 24;
																	Class24.smethod_14((Stream)memoryStream, array2, 0, num15, 570, 566);
																	goto IL_0344;
																case 5:
																	num10 = 5;
																	num14 = 3;
																	goto IL_03d7;
																case 6:
																	num10 = 18;
																	num14 = 0;
																	goto IL_03d7;
																case 8:
																	num10 = 16;
																	goto IL_03ec;
																case 10:
																	num10 = 16;
																	goto IL_03ec;
																case 11:
																	break;
																default:
																	goto end_IL_0466;
																case 2:
																	goto IL_047b;
																case 4:
																	goto IL_0480;
																case 0:
																	goto end_IL_0483;
																case 1:
																	num10 = 11;
																	goto end_IL_0493;
																case 7:
																	{
																		num10 = 11;
																		goto end_IL_0493;
																	}
																	IL_03ec:
																	array2 = new byte[1024];
																	num12 = 2;
																	num11 = 11;
																	num10 = 1;
																	num10 = 13;
																	goto IL_0440;
																	IL_03d7:
																	num12 = num14;
																	num11 = 11;
																	num10 = 1;
																	break;
																	IL_0344:
																	if ((num15 = Class24.smethod_95((Stream)deflateStream, array2, 0, array2.Length, 959, 1013)) <= 0)
																	{
																		num10 = 0;
																		num16 = 5;
																	}
																	else
																	{
																		num10 = 17;
																		num16 = 6;
																	}
																	num11 = num16;
																	num10 = 1;
																	continue;
																}
																break;
															}
															num10 = 13;
															switch (num12)
															{
															case 0:
																goto IL_0439;
															case 2:
																goto IL_0440;
															case 3:
																goto IL_0448;
															case 4:
																goto IL_044f;
															case 5:
																goto IL_0455;
															case 6:
																goto IL_045c;
															case 7:
																goto IL_0462;
															case 1:
																goto IL_0470;
															}
															num10 = 4;
															num13 = 8;
															continue;
															IL_0440:
															num10 = 14;
															num13 = 9;
															continue;
															IL_0439:
															num10 = 22;
															num13 = 3;
															continue;
															IL_0462:
															num10 = 3;
															num13 = 8;
															continue;
															IL_045c:
															num10 = 8;
															num13 = 7;
															continue;
															IL_0455:
															num10 = 23;
															num13 = 8;
															continue;
															IL_044f:
															num10 = 2;
															num13 = 8;
															continue;
															IL_0448:
															num10 = 20;
															num13 = 7;
															continue;
															end_IL_0466:
															break;
														}
														break;
													}
													num10 = 6;
													continue;
													IL_047b:
													num10 = 6;
													continue;
													IL_0480:
													num10 = 6;
													continue;
													end_IL_0483:
													break;
												}
												continue;
												end_IL_0493:
												break;
											}
										}
										finally
										{
											num17 = 19;
											num18 = 5;
											num17 = 14;
											while (true)
											{
												num17 = 13;
												while (true)
												{
													num19 = 6;
													num18 = 3;
													num17 = 14;
													while (true)
													{
														num17 = 0;
														while (true)
														{
															int num20;
															switch (num19)
															{
															case 6:
																num17 = 11;
																num20 = 9;
																break;
															case 5:
																num17 = 6;
																num20 = 6;
																break;
															case 4:
																num17 = 10;
																num20 = 7;
																break;
															case 3:
																num17 = 12;
																num20 = 9;
																break;
															case 2:
																num17 = 7;
																num20 = 9;
																break;
															case 1:
																num17 = 16;
																num20 = 6;
																break;
															case 0:
																num17 = 2;
																num20 = 7;
																break;
															default:
																num17 = 18;
																num20 = 9;
																break;
															}
															num18 = num20;
															num17 = 14;
															while (true)
															{
																int num21;
																switch (num18)
																{
																case 9:
																{
																	num17 = 15;
																	int num22;
																	if (deflateStream != null)
																	{
																		num17 = 21;
																		num22 = 2;
																	}
																	else
																	{
																		num17 = 3;
																		num22 = 8;
																	}
																	num18 = num22;
																	num17 = 14;
																	continue;
																}
																case 0:
																	break;
																case 2:
																	num17 = 1;
																	num21 = 0;
																	goto IL_057f;
																case 8:
																	num17 = 20;
																	num21 = 1;
																	goto IL_057f;
																case 3:
																	goto end_IL_054f;
																default:
																	goto end_IL_0588;
																case 10:
																	goto IL_0593;
																case 5:
																	goto end_IL_0597;
																case 1:
																	num17 = 17;
																	goto IL_05bf;
																case 4:
																	num17 = 17;
																	goto IL_05bf;
																case 6:
																	num17 = 9;
																	goto end_IL_05a3;
																case 7:
																	{
																		num17 = 17;
																		goto IL_05bf;
																	}
																	IL_05bf:
																	((IDisposable)deflateStream).Dispose();
																	goto end_IL_05a3;
																	IL_057f:
																	num19 = num21;
																	num18 = 3;
																	num17 = 14;
																	goto end_IL_054f;
																}
																break;
															}
															num17 = 0;
															continue;
															end_IL_054f:
															break;
														}
														continue;
														end_IL_0588:
														break;
													}
													num17 = 13;
													continue;
													IL_0593:
													num17 = 13;
													continue;
													end_IL_0597:
													break;
												}
												continue;
												end_IL_05a3:
												break;
											}
										}
										num8 = 36;
										num23 = 16;
										num8 = 30;
										goto IL_08e0;
										IL_089e:
										num8 = 45;
										num9 = 10;
										goto IL_08b3;
										IL_023a:
										num = 4;
										num4 = 11;
										goto IL_0252;
										IL_01b5:
										num = 6;
										num3 = 11;
										num2 = 15;
										num = 14;
										num = 25;
										goto case 11;
										IL_0186:
										num = 17;
										num4 = 13;
										goto IL_0252;
										IL_0141:
										num = 10;
										num4 = 3;
										goto IL_0252;
										IL_024e:
										num = 42;
										num4 = 2;
										goto IL_0252;
										IL_07e0:
										num8 = 47;
										goto IL_07e4;
										IL_0878:
										num8 = 28;
										num9 = 15;
										goto IL_08b3;
										IL_01e6:
										num = 47;
										num3 = 7;
										num2 = 15;
										num = 14;
										num = 25;
										goto case 7;
										IL_07e4:
										assembly2 = (Assembly)Class24.smethod_44(appDomain, text, 279, 327);
										num24 = 8;
										num8 = 6;
										goto IL_0804;
										IL_0804:
										num23 = 11;
										num8 = 30;
										goto IL_080c;
										IL_080c:
										num8 = 1;
										switch (num24)
										{
										case 0:
											goto IL_0855;
										case 1:
											goto IL_085c;
										case 2:
											goto IL_0864;
										case 3:
											goto IL_086b;
										case 4:
											goto IL_0872;
										case 5:
											goto IL_0878;
										case 6:
											goto IL_0880;
										case 7:
											goto IL_0887;
										case 8:
											goto IL_088e;
										case 9:
											goto IL_0896;
										case 11:
											goto IL_089e;
										case 12:
											goto IL_08a6;
										case 13:
											goto IL_08ae;
										case 10:
											goto IL_08be;
										}
										num8 = 11;
										num9 = 1;
										goto IL_08b3;
										IL_08ae:
										num8 = 13;
										num9 = 2;
										goto IL_08b3;
										IL_0896:
										num8 = 17;
										num9 = 22;
										goto IL_08b3;
										IL_088e:
										num8 = 24;
										num9 = 9;
										goto IL_08b3;
										IL_0887:
										num8 = 18;
										num9 = 5;
										goto IL_08b3;
										IL_0880:
										num8 = 40;
										num9 = 7;
										goto IL_08b3;
										IL_0872:
										num8 = 3;
										num9 = 0;
										goto IL_08b3;
										IL_086b:
										num8 = 19;
										num9 = 8;
										goto IL_08b3;
										IL_0864:
										num8 = 42;
										num9 = 8;
										goto IL_08b3;
										IL_085c:
										num8 = 14;
										num9 = 17;
										goto IL_08b3;
										IL_0855:
										num8 = 38;
										num9 = 1;
										goto IL_08b3;
										IL_01e0:
										num = 22;
										num4 = 7;
										goto IL_0252;
										IL_08b3:
										num23 = num9;
										num8 = 30;
										while (true)
										{
											int num26;
											int num25;
											switch (num23)
											{
											case 13:
											{
												num8 = 16;
												int num29;
												if (num27 >= array3.Length)
												{
													num8 = 32;
													num29 = 19;
												}
												else
												{
													num8 = 2;
													num29 = 6;
												}
												num23 = num29;
												num8 = 30;
												continue;
											}
											case 9:
											{
												num8 = 29;
												int num28;
												if (dictionary.ContainsKey(Class24.smethod_193(resolveEventArgs_0, 638, 520)))
												{
													num8 = 0;
													num28 = 18;
												}
												else
												{
													num8 = 9;
													num28 = 4;
												}
												num23 = num28;
												num8 = 30;
												continue;
											}
											case 1:
												num8 = 20;
												assembly2 = Class24.smethod_3(Class24.smethod_19(memoryStream, 426, 432), (byte[])null, Class24.smethod_119(assembly, 823, 797), 509, 441);
												num8 = 22;
												num23 = 12;
												num8 = 30;
												goto case 12;
											case 4:
												num8 = 4;
												num26 = 13;
												goto IL_079f;
											case 5:
												num8 = 7;
												text2 = array3[num27];
												dictionary[text2] = text2;
												goto IL_0780;
											case 6:
												num8 = 33;
												num25 = 7;
												goto IL_07af;
											case 7:
												num8 = 34;
												num24 = 8;
												num8 = 5;
												goto IL_07d6;
											case 8:
												num8 = 46;
												goto IL_0763;
											case 10:
												num8 = 27;
												num27 = 0;
												num24 = 12;
												num23 = 11;
												num8 = 30;
												num8 = 1;
												goto IL_08a6;
											case 12:
												num8 = 23;
												num24 = 5;
												num23 = 11;
												num8 = 30;
												num8 = 1;
												goto IL_0878;
											case 14:
												break;
											case 15:
												num8 = 39;
												Class24.smethod_154(appDomain, text, (object)assembly2, 57, 78);
												goto IL_0763;
											case 17:
												num8 = 10;
												goto IL_0780;
											case 18:
												num8 = 31;
												num26 = 4;
												goto IL_079f;
											case 19:
												num8 = 8;
												num25 = 6;
												goto IL_07af;
											case 20:
												num8 = 15;
												goto IL_07bf;
											case 21:
												num8 = 5;
												goto IL_07d6;
											case 22:
												goto IL_07e0;
											case 11:
												goto IL_080c;
											default:
												goto IL_08c5;
											case 3:
												goto IL_08cb;
											case 16:
												goto IL_08e0;
											case 0:
												num8 = 12;
												return assembly2;
											case 2:
												goto IL_08f3;
												IL_0763:
												array3 = Class24.smethod_109(assembly2, 659, 762);
												num8 = 15;
												goto IL_07bf;
												IL_07bf:
												num24 = 11;
												num23 = 11;
												num8 = 30;
												num8 = 1;
												goto IL_089e;
												IL_07d6:
												num23 = 11;
												num8 = 30;
												goto IL_080c;
												IL_07af:
												num24 = num25;
												num23 = 11;
												num8 = 30;
												goto IL_080c;
												IL_0780:
												num27++;
												num24 = 12;
												num23 = 11;
												num8 = 30;
												num8 = 1;
												goto IL_08a6;
												IL_079f:
												num24 = num26;
												num23 = 11;
												num8 = 30;
												goto IL_080c;
											}
											break;
										}
										num8 = 6;
										goto IL_0804;
										IL_08a6:
										num8 = 21;
										num9 = 13;
										goto IL_08b3;
										IL_08e0:
										num8 = 35;
										goto IL_08cf;
										IL_08cb:
										num8 = 35;
										goto IL_08cf;
										IL_08c5:
										num8 = 35;
										goto IL_08cf;
										IL_08cf:
										num24 = 10;
										num23 = 11;
										num8 = 30;
										num8 = 1;
										goto IL_08be;
										end_IL_029d:
										break;
									}
									continue;
									end_IL_0299:
									break;
								}
								num = 46;
								continue;
								end_IL_02df:
								break;
							}
							continue;
							end_IL_02e7:
							break;
						}
						continue;
					}
					goto IL_08f7;
					IL_08f3:
					num8 = 37;
					goto IL_08f7;
					IL_08f7:
					return null;
					continue;
					end_IL_02f2:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_24(exception_, new object[31]
			{
				assembly, text, appDomain, dictionary, assembly2, array, num6, memoryStream, deflateStream, array2,
				num15, text2, array3, num27, num3, num12, num19, num24, num2, num11,
				num18, num23, num, num10, num17, num8, resolveEventArgs_0, runtimeFieldHandle_0, int_0, string_0,
				int_1
			});
			throw;
		}
	}

	static int smethod_170(byte[] byte_0, Class17.Class18 class18_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			num = 0;
			num2 = byte_0.Length;
			num3 = num2;
			while (true)
			{
				num4 = Class24.smethod_129(class18_0.class22_0, byte_0, num, num2);
				num += num4;
				class18_0.long_0 += num4;
				num2 -= num4;
				if (num2 == 0 || class18_0.int_0 == 30)
				{
					break;
				}
				Class17.Class21 class21_ = class18_0.class21_0;
				bool bool_ = (class18_0.int_0 & 4) != 0;
				bool bool_2 = (class18_0.int_0 & 8) != 0;
				if (Class24.smethod_143(bool_, class21_, bool_2))
				{
					continue;
				}
				if (class18_0.int_0 != 16)
				{
					if (class18_0.int_0 == 20)
					{
						for (num5 = 8 + (-Class24.smethod_31(class18_0.class22_0) & 7); num5 > 0; num5 -= 10)
						{
							Class24.smethod_148(class18_0.class22_0, 2, 10);
						}
						class18_0.int_0 = 16;
					}
					else if (class18_0.int_0 == 28)
					{
						Class24.smethod_110(class18_0.class22_0);
						class18_0.int_0 = 30;
					}
					continue;
				}
				return num3 - num2;
			}
			return num3 - num2;
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num, (object)num2, (object)num3, (object)num4, (object)num5, (object)class18_0, (object)byte_0);
			throw;
		}
	}

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static string smethod_171()
	{
		return Class24.smethod_188().string_0;
	}

	static int smethod_172(int int_0, Font font_0, string string_0, Graphics graphics_0)
	{
		try
		{
			return Class24.smethod_131(font_0, graphics_0, int_0, string_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class24.smethod_155(string_0, int_0, graphics_0, font_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void smethod_173(Class27 class27_0, EventArgs0 eventArgs0_0)
	{
		((Delegate0)class27_0.object_0)?.Invoke((object)class27_0, eventArgs0_0);
	}

	static void smethod_174(ProcessStartInfo processStartInfo_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 37:
					num = 2;
					processStartInfo_0.FileName = string_0;
					return;
				}
				num = 3;
				num = 0;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_9(exception_, (object)num, (object)num2, (object)processStartInfo_0, (object)string_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static int smethod_175()
	{
		Version version = new Version("6.9.0.114");
		return version.Major;
	}

	static void smethod_176(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_177(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 10;
			num2 = 0;
			num = 9;
			while (true)
			{
				num = 7;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 6:
						num = 6;
						num3 = 3;
						break;
					default:
						num = 5;
						num3 = 4;
						break;
					}
					num2 = num3;
					num = 9;
					switch (num2)
					{
					default:
						goto IL_0030;
					case 4:
						num = 2;
						num2 = 0;
						num = 9;
						break;
					case 0:
						break;
					case 1:
						num = 3;
						goto IL_005e;
					case 2:
						num = 3;
						goto IL_005e;
					case 3:
						num = 3;
						goto IL_005e;
					case 5:
						{
							num = 1;
							return;
						}
						IL_005e:
						Class24.smethod_56(appDomain_0, resolveEventHandler_0, 523, 605);
						return;
					}
					break;
					IL_0030:
					num = 7;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_70(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)appDomain_0, (object)resolveEventHandler_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_178(Class17.Stream0 stream0_0, int int_0)
	{
		try
		{
			stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
			stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
		}
		catch (Exception exception_)
		{
			Class24.smethod_80(exception_, (object)stream0_0, (object)int_0);
			throw;
		}
	}

	static void smethod_179(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 11:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_9(exception_, (object)num, (object)num2, (object)array_0, (object)runtimeFieldHandle_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static ProcessStartInfo smethod_180(Process process_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					num = 1;
					return process_0.StartInfo;
				}
				num = 3;
				num = 0;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num, (object)process_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_181(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 50:
					num = 0;
					processStartInfo_0.WindowStyle = processWindowStyle_0;
					return;
				}
				num = 2;
				num = 5;
			}
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_9(exception_, (object)num, (object)num2, (object)processStartInfo_0, (object)processWindowStyle_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_182(int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 4;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 79:
					num = 6;
					num2 = 4;
					break;
				default:
					num = 11;
					num2 = 7;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 2;
					goto IL_004c;
				case 0:
					num = 4;
					break;
				case 2:
					num = 12;
					num3 = 1;
					num = 1;
					goto case 1;
				case 3:
					num = 3;
					goto IL_0054;
				case 5:
					num = 2;
					goto IL_004c;
				case 6:
					num = 2;
					goto IL_004c;
				case 7:
					num = 3;
					goto IL_0054;
				case 1:
					num = 4;
					break;
				case 4:
					{
						num = 0;
						return Class24.smethod_1(811, 773);
					}
					IL_0054:
					num3 = 1;
					num = 1;
					goto case 1;
					IL_004c:
					num3 = 1;
					num = 1;
					goto case 1;
				}
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_6(exception_, (object)num3, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_183(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
		try
		{
			num = 17;
			while (true)
			{
				num2 = 11;
				num = 9;
				while (true)
				{
					num = 26;
					int num3;
					switch (int_1 ^ int_0)
					{
					case 125:
						num = 25;
						num3 = 2;
						break;
					default:
						num = 20;
						num3 = 0;
						break;
					}
					num2 = num3;
					num = 9;
					while (true)
					{
						int num4;
						int num6;
						switch (num2)
						{
						case 12:
							num = 0;
							num5 = 1;
							num2 = 8;
							num = 9;
							goto case 8;
						case 8:
							num = 16;
							goto IL_0022;
						case 10:
							num = 6;
							goto IL_0081;
						case 9:
							num = 16;
							goto IL_0022;
						case 5:
							num = 14;
							num5 = 1;
							num2 = 8;
							num = 9;
							goto case 8;
						case 3:
							num = 24;
							goto IL_009e;
						case 2:
							num = 24;
							goto IL_009e;
						case 1:
							num = 6;
							goto IL_0081;
						case 0:
							num = 7;
							num4 = 6;
							goto IL_009f;
						case 11:
							break;
						default:
							num = 22;
							goto IL_0119;
						case 7:
							num = 22;
							goto IL_0119;
						case 6:
							goto end_IL_00fd;
						case 4:
							{
								num = 19;
								return Class24.smethod_163(string_0, string_1, 657, 728);
							}
							IL_0119:
							num2 = 6;
							num = 9;
							goto end_IL_00fd;
							IL_009e:
							num4 = 0;
							goto IL_009f;
							IL_009f:
							num5 = num4;
							num2 = 8;
							num = 9;
							goto case 8;
							IL_0081:
							num5 = 1;
							num2 = 8;
							num = 9;
							goto case 8;
							IL_0022:
							switch (num5)
							{
							default:
								num = 8;
								num6 = 5;
								break;
							case 0:
								num = 3;
								num6 = 4;
								break;
							case 1:
								num = 23;
								num6 = 11;
								break;
							case 2:
								num = 18;
								num6 = 1;
								break;
							case 3:
								num = 21;
								num6 = 4;
								break;
							case 4:
								num = 1;
								num6 = 12;
								break;
							case 5:
								num = 5;
								num6 = 5;
								break;
							case 6:
								num = 10;
								num6 = 1;
								break;
							case 7:
								num = 4;
								num6 = 4;
								break;
							}
							goto IL_0079;
						}
						break;
						IL_0079:
						num2 = num6;
						num = 9;
					}
					continue;
					end_IL_00fd:
					break;
				}
				num = 17;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_117(exception_, (object)num5, (object)num2, (object)num, (object)string_0, (object)string_1, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_184(Class17.Class19 class19_0, int int_0)
	{
		int i = default(int);
		try
		{
			Class24.smethod_48(class19_0.class20_2);
			Class24.smethod_48(class19_0.class20_0);
			Class24.smethod_48(class19_0.class20_1);
			Class24.smethod_148(class19_0.class22_0, class19_0.class20_0.int_1 - 257, 5);
			Class24.smethod_148(class19_0.class22_0, class19_0.class20_1.int_1 - 1, 5);
			Class24.smethod_148(class19_0.class22_0, int_0 - 4, 4);
			for (i = 0; i < int_0; i++)
			{
				Class24.smethod_148(class19_0.class22_0, (int)class19_0.class20_2.byte_0[Class17.Class19.int_0[i]], 3);
			}
			Class24.smethod_8(class19_0.class20_0, class19_0.class20_2);
			Class24.smethod_8(class19_0.class20_1, class19_0.class20_2);
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)i, (object)class19_0, (object)int_0);
			throw;
		}
	}

	static Assembly smethod_185(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int num = default(int);
		try
		{
			num = 1;
			return Class24.smethod_169(resolveEventArgs_0, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 64136, Class24.smethod_60(368370940, 8), 36);
		}
		catch (Exception exception_)
		{
			int num2 = default(int);
			Class24.smethod_6(exception_, (object)num2, (object)num, object_0, (object)resolveEventArgs_0);
			throw;
		}
	}

	static void smethod_186(string string_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 3;
			num2 = 1;
			num = 10;
			while (true)
			{
				num = 0;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 104:
						num = 8;
						num3 = 2;
						break;
					default:
						num = 5;
						num3 = 0;
						break;
					}
					num2 = num3;
					num = 10;
					switch (num2)
					{
					default:
						num = 0;
						continue;
					case 3:
						num = 0;
						continue;
					case 0:
						num = 7;
						goto IL_0053;
					case 5:
						num = 7;
						goto IL_0053;
					case 1:
						break;
					case 2:
						num = 6;
						Class24.smethod_139(string_0, byte_0, 365, 373);
						return;
					case 4:
						{
							num = 2;
							return;
						}
						IL_0053:
						num2 = 1;
						num = 10;
						break;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			int num4 = default(int);
			int num5 = default(int);
			Class24.smethod_70(exception_, (object)num2, (object)num4, (object)num, (object)num5, (object)string_0, (object)byte_0, (object)int_0, (object)int_1);
			throw;
		}
	}

	static void smethod_187(Class17.Class21 class21_0)
	{
		try
		{
			class21_0.int_0 = (class21_0.byte_0[class21_0.int_4] << 5) ^ class21_0.byte_0[class21_0.int_4 + 1];
		}
		catch (Exception exception_)
		{
			Class24.smethod_130(exception_, (object)class21_0);
			throw;
		}
	}

	static Class38.Struct11 smethod_188()
	{
		if (!Class38.bool_0)
		{
			Class38.struct11_0 = default(Class38.Struct11);
			try
			{
				Class38.struct11_0.int_0 = Marshal.SizeOf(typeof(Class38.Struct11));
				GetVersionEx(ref Class38.struct11_0);
				Class38.bool_0 = true;
			}
			catch
			{
			}
		}
		return Class38.struct11_0;
	}

	static ICryptoTransform smethod_189(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		try
		{
			dESCryptoServiceProvider = new DESCryptoServiceProvider();
			try
			{
				cryptoTransform = (bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0));
				return cryptoTransform;
			}
			finally
			{
				((IDisposable)dESCryptoServiceProvider)?.Dispose();
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)dESCryptoServiceProvider, (object)cryptoTransform, (object)byte_1, (object)byte_0, (object)bool_0);
			throw;
		}
	}

	static void smethod_190(IWebProxy iwebProxy_0, Class37 class37_0)
	{
		class37_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_191(Class34 class34_0)
	{
		try
		{
			Graphics val = ((Control)class34_0).CreateGraphics();
			try
			{
				string text = ((Control)class34_0).get_Text();
				Font font = ((Control)class34_0).get_Font();
				int width = ((Control)class34_0).get_Width();
				int num = Class24.smethod_172(width, font, text, val);
				if (num > 0)
				{
					((Control)class34_0).set_Height(num);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	static Assembly smethod_192(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 96:
					num = 0;
					return Assembly.GetExecutingAssembly();
				}
				num = 5;
				num = 6;
			}
		}
		catch (Exception exception_)
		{
			Class24.smethod_91(exception_, (object)num, (object)int_0, (object)int_1);
			throw;
		}
	}

	static string smethod_193(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 7;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 118:
					num = 8;
					num2 = 1;
					break;
				default:
					num = 2;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 9;
				switch (num3)
				{
				default:
					num = 4;
					goto IL_004c;
				case 3:
					num = 11;
					goto IL_0043;
				case 4:
					num = 11;
					goto IL_0043;
				case 5:
					num = 11;
					goto IL_0043;
				case 6:
					num = 4;
					goto IL_004c;
				case 7:
					num = 5;
					num3 = 0;
					num = 9;
					goto IL_005a;
				case 0:
					goto IL_005a;
				case 1:
					num = 10;
					break;
				case 2:
					{
						num = 10;
						break;
					}
					IL_0043:
					num3 = 0;
					num = 9;
					goto IL_005a;
					IL_004c:
					num3 = 0;
					num = 9;
					goto IL_005a;
				}
				break;
				IL_005a:
				num = 7;
			}
			return Class24.smethod_122(resolveEventArgs_0, 682, 749);
		}
		catch (Exception exception_)
		{
			Class24.smethod_21(exception_, (object)num3, (object)num, (object)resolveEventArgs_0, (object)int_0, (object)int_1);
			throw;
		}
	}
}
