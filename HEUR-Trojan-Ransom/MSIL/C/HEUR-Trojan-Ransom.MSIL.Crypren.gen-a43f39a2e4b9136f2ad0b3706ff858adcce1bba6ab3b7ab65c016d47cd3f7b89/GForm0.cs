using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[DesignerGenerated]
public class GForm0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("ᜮᜧ\u1734\u1739")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[AccessedThroughProperty("ᜮᜧ\u1734\u173a")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[AccessedThroughProperty("ᜮᜧ\u1734\u173b")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ\u1734\u173c")]
	private Label label_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ\u1734\u173d")]
	[CompilerGenerated]
	private TextBox textBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ\u1734\u173e")]
	[CompilerGenerated]
	private TextBox textBox_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ\u1734\u173f")]
	[CompilerGenerated]
	private TextBox textBox_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ᜵ᜠ")]
	[CompilerGenerated]
	private Label label_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ᜵ᜡ")]
	[CompilerGenerated]
	private Label label_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ᜵ᜢ")]
	[CompilerGenerated]
	private Label label_5;

	[AccessedThroughProperty("ᜮᜧ᜵ᜣ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button button_1;

	[AccessedThroughProperty("ᜮᜧ᜵ᜤ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GroupBox groupBox_0;

	[AccessedThroughProperty("ᜮᜧ᜵ᜥ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextBox textBox_3;

	[AccessedThroughProperty("ᜮᜧ᜵ᜦ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button button_2;

	[AccessedThroughProperty("ᜮᜧ᜵ᜧ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button button_3;

	[AccessedThroughProperty("ᜮᜧ᜵ᜨ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ᜮᜧ᜵ᜩ")]
	private GroupBox groupBox_1;

	[AccessedThroughProperty("ᜮᜧ᜵ᜪ")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CheckBox checkBox_0;

	internal virtual Button Button_0
	{
		[CompilerGenerated]
		get
		{
			return button_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_0;
			Button val = button_0;
			if (val != null || 1 == 0)
			{
				((Control)val).remove_Click(eventHandler);
			}
			button_0 = value;
			while (true)
			{
				int num = Class33.smethod_1(22);
				int num2 = Class40.smethod_1(9);
				while (true)
				{
					num2 ^= Class45.smethod_0(104);
					while (true)
					{
						int num3 = Class45.smethod_0(85);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(106))
							{
							case 48:
								break;
							case 47:
								goto IL_008c;
							case 46:
								num3 = 2;
								continue;
							default:
								goto end_IL_009d;
							case 49:
								goto end_IL_00c3;
							}
							switch (num2)
							{
							case -44:
								goto IL_004e;
							case -41:
								goto IL_0082;
							case -42:
								goto IL_00d3;
							case -43:
								goto end_IL_00d6;
							}
							num3 = 3;
							continue;
							IL_0082:
							num ^= Class45.smethod_0(107);
							goto IL_008c;
							IL_00d3:
							num2 = -8;
							goto end_IL_00c3;
							IL_004e:
							switch (num)
							{
							case -43:
								if (val != null)
								{
									goto IL_006f;
								}
								if (true)
								{
									return;
								}
								goto case -40;
							case -42:
								break;
							case -41:
								goto IL_0079;
							default:
								goto IL_00ce;
							case -40:
								((Control)val).add_Click(eventHandler);
								return;
							}
							num = -4;
							goto IL_0082;
							IL_00ce:
							num2 = -5;
							goto end_IL_00c3;
							IL_0079:
							val = button_0;
							num = -1;
							goto IL_0082;
							IL_008c:
							num2 = Class33.smethod_1(30);
							num3 = 29;
							continue;
							IL_006f:
							num = -14;
							goto IL_0082;
							continue;
							end_IL_009d:
							break;
						}
						continue;
						end_IL_00c3:
						break;
					}
					continue;
					end_IL_00d6:
					break;
				}
			}
		}
	}

	internal virtual Label Label_0
	{
		[CompilerGenerated]
		get
		{
			return label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_0 = value;
		}
	}

	internal virtual Label Label_1
	{
		[CompilerGenerated]
		get
		{
			return label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_1 = value;
		}
	}

	internal virtual Label Label_2
	{
		[CompilerGenerated]
		get
		{
			return label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_2 = value;
		}
	}

	internal virtual TextBox TextBox_0
	{
		[CompilerGenerated]
		get
		{
			return textBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			textBox_0 = value;
		}
	}

	internal virtual TextBox TextBox_1
	{
		[CompilerGenerated]
		get
		{
			return textBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			textBox_1 = value;
		}
	}

	internal virtual TextBox TextBox_2
	{
		[CompilerGenerated]
		get
		{
			return textBox_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			textBox_2 = value;
		}
	}

	internal virtual Label Label_3
	{
		[CompilerGenerated]
		get
		{
			return label_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_3 = value;
		}
	}

	internal virtual Label Label_4
	{
		[CompilerGenerated]
		get
		{
			return label_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_4 = value;
		}
	}

	internal virtual Label Label_5
	{
		[CompilerGenerated]
		get
		{
			return label_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_5 = value;
		}
	}

	internal virtual Button Button_1
	{
		[CompilerGenerated]
		get
		{
			return button_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_1;
			Button val = button_1;
			if (val != null || 1 == 0)
			{
				((Control)val).remove_Click(eventHandler);
			}
			button_1 = value;
			while (true)
			{
				int num = Class47.smethod_2(45);
				int num2 = -21;
				while (true)
				{
					num2 ^= Class45.smethod_0(102);
					while (true)
					{
						int num3 = Class45.smethod_0(13);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(77))
							{
							case 48:
								num3 = 23;
								continue;
							case 47:
								break;
							case 46:
								goto IL_0099;
							default:
								goto end_IL_00aa;
							case 49:
								goto end_IL_00d0;
							}
							switch (num2)
							{
							case -40:
								goto IL_0055;
							case -38:
								goto IL_008f;
							case -41:
								goto IL_00db;
							case -39:
								goto end_IL_00e8;
							}
							num3 = 9;
							continue;
							IL_008f:
							num ^= Class45.smethod_0(104);
							goto IL_0099;
							IL_00db:
							num2 = Class40.smethod_1(14);
							goto end_IL_00d0;
							IL_0055:
							switch (num)
							{
							case -40:
								if (val != null)
								{
									goto IL_0076;
								}
								if (true)
								{
									return;
								}
								goto case -37;
							case -39:
								break;
							case -38:
								goto IL_008c;
							default:
								goto IL_00e5;
							case -37:
								((Control)val).add_Click(eventHandler);
								return;
							}
							val = button_1;
							num = Class47.smethod_2(41);
							goto IL_008f;
							IL_00e5:
							num2 = -24;
							goto end_IL_00d0;
							IL_008c:
							num = -12;
							goto IL_008f;
							IL_0099:
							num2 = Class15.smethod_0(48);
							num3 = Class45.smethod_0(88);
							continue;
							IL_0076:
							num = -11;
							goto IL_008f;
							continue;
							end_IL_00aa:
							break;
						}
						continue;
						end_IL_00d0:
						break;
					}
					continue;
					end_IL_00e8:
					break;
				}
			}
		}
	}

	internal virtual GroupBox GroupBox_0
	{
		[CompilerGenerated]
		get
		{
			return groupBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			groupBox_0 = value;
		}
	}

	internal virtual TextBox TextBox_3
	{
		[CompilerGenerated]
		get
		{
			return textBox_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			textBox_3 = value;
		}
	}

	internal virtual Button Button_2
	{
		[CompilerGenerated]
		get
		{
			return button_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			Button val = button_2;
			if (val != null || 1 == 0)
			{
				((Control)val).remove_Click(eventHandler);
			}
			button_2 = value;
			while (true)
			{
				int num = Class45.smethod_0(85);
				int num2 = Class45.smethod_0(1);
				while (true)
				{
					num2 ^= Class45.smethod_0(104);
					while (true)
					{
						int num3 = Class45.smethod_0(85);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(104))
							{
							case 52:
								num3 = 26;
								continue;
							case 51:
								break;
							case 50:
								goto IL_0043;
							default:
								goto end_IL_00a5;
							case 53:
								goto end_IL_00cb;
							}
							goto IL_0036;
							IL_0043:
							switch (num2)
							{
							case 46:
								goto IL_0062;
							case 47:
								goto IL_0099;
							case 45:
								goto IL_00d6;
							case 44:
								goto end_IL_00dc;
							}
							num3 = 29;
							continue;
							IL_00d6:
							num2 = 3;
							goto end_IL_00cb;
							IL_0062:
							switch (num)
							{
							case 44:
								if (val != null)
								{
									goto IL_0080;
								}
								if (true)
								{
									return;
								}
								goto case 47;
							case 45:
								break;
							case 46:
								goto IL_008f;
							default:
								goto IL_00da;
							case 47:
								((Control)val).add_Click(eventHandler);
								return;
							}
							num = 31;
							goto IL_0099;
							IL_00da:
							num2 = 2;
							goto end_IL_00cb;
							IL_008f:
							val = button_2;
							num = 30;
							goto IL_0099;
							IL_0036:
							num2 = Class45.smethod_0(0);
							num3 = 27;
							continue;
							IL_0080:
							num = Class45.smethod_0(42);
							goto IL_0099;
							IL_0099:
							num ^= Class45.smethod_0(101);
							goto IL_0036;
							continue;
							end_IL_00a5:
							break;
						}
						continue;
						end_IL_00cb:
						break;
					}
					continue;
					end_IL_00dc:
					break;
				}
			}
		}
	}

	internal virtual Button Button_3
	{
		[CompilerGenerated]
		get
		{
			return button_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_3;
			Button val = button_3;
			if (val != null || 1 == 0)
			{
				((Control)val).remove_Click(eventHandler);
			}
			button_3 = value;
			while (true)
			{
				int num = Class45.smethod_0(42);
				int num2 = -2;
				while (true)
				{
					num2 ^= Class45.smethod_0(100);
					while (true)
					{
						int num3 = Class47.smethod_2(46);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(102))
							{
							case -47:
								break;
							case -48:
								goto IL_008e;
							case -49:
								num3 = -2;
								continue;
							default:
								goto end_IL_00a0;
							case -46:
								goto end_IL_00c6;
							}
							switch (num2)
							{
							case -49:
								goto IL_004f;
							case -47:
								goto IL_0084;
							case -48:
								goto IL_00d6;
							case -50:
								goto end_IL_00de;
							}
							num3 = -31;
							continue;
							IL_0084:
							num ^= Class45.smethod_0(102);
							goto IL_008e;
							IL_00d6:
							num2 = Class40.smethod_1(12);
							goto end_IL_00c6;
							IL_004f:
							switch (num)
							{
							case 43:
								if (val != null)
								{
									goto IL_0070;
								}
								if (true)
								{
									return;
								}
								goto case 46;
							case 44:
								break;
							case 45:
								goto IL_0081;
							default:
								goto IL_00d1;
							case 46:
								((Control)val).add_Click(eventHandler);
								return;
							}
							val = button_3;
							num = 26;
							goto IL_0084;
							IL_00d1:
							num2 = -31;
							goto end_IL_00c6;
							IL_0081:
							num = 28;
							goto IL_0084;
							IL_008e:
							num2 = Class47.smethod_2(46);
							num3 = -29;
							continue;
							IL_0070:
							num = 31;
							goto IL_0084;
							continue;
							end_IL_00a0:
							break;
						}
						continue;
						end_IL_00c6:
						break;
					}
					continue;
					end_IL_00de:
					break;
				}
			}
		}
	}

	internal virtual Label Label_6
	{
		[CompilerGenerated]
		get
		{
			return label_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_6 = value;
		}
	}

	internal virtual GroupBox GroupBox_1
	{
		[CompilerGenerated]
		get
		{
			return groupBox_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			groupBox_1 = value;
		}
	}

	internal virtual CheckBox CheckBox_0
	{
		[CompilerGenerated]
		get
		{
			return checkBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_4;
			CheckBox val = checkBox_0;
			if (val != null || 1 == 0)
			{
				val.remove_CheckedChanged(eventHandler);
			}
			checkBox_0 = value;
			while (true)
			{
				int num = Class45.smethod_0(1);
				int num2 = -14;
				while (true)
				{
					num2 ^= Class45.smethod_0(96);
					while (true)
					{
						int num3 = Class45.smethod_0(90);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(101))
							{
							case 46:
								break;
							case 45:
								num3 = 31;
								continue;
							case 44:
								goto IL_0044;
							default:
								goto end_IL_00a4;
							case 47:
								goto end_IL_00ca;
							}
							goto IL_0030;
							IL_0044:
							switch (num2)
							{
							case -39:
								goto IL_0063;
							case -38:
								goto IL_0098;
							case -41:
								goto IL_00d5;
							case -40:
								goto end_IL_00dc;
							}
							num3 = 28;
							continue;
							IL_00d5:
							num2 = -1;
							goto end_IL_00ca;
							IL_0063:
							switch (num)
							{
							case 45:
								if (val != null)
								{
									goto IL_0081;
								}
								if (true)
								{
									return;
								}
								goto case 48;
							case 46:
								break;
							case 47:
								goto IL_008f;
							default:
								goto IL_00d9;
							case 48:
								val.add_CheckedChanged(eventHandler);
								return;
							}
							num = Class45.smethod_0(0);
							goto IL_0098;
							IL_00d9:
							num2 = -16;
							goto end_IL_00ca;
							IL_008f:
							val = checkBox_0;
							num = 3;
							goto IL_0098;
							IL_0030:
							num2 = Class47.smethod_2(42);
							num3 = 29;
							continue;
							IL_0081:
							num = 30;
							goto IL_0098;
							IL_0098:
							num ^= Class45.smethod_0(104);
							goto IL_0030;
							continue;
							end_IL_00a4:
							break;
						}
						continue;
						end_IL_00ca:
						break;
					}
					continue;
					end_IL_00dc:
					break;
				}
			}
		}
	}

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
		Delegate37.smethod_0(this);
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between Unknown and I4
		List<string> list = default(List<string>);
		bool flag = default(bool);
		string text4 = default(string);
		string text3 = default(string);
		string text2 = default(string);
		Random random = default(Random);
		string text = default(string);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		string fileName17 = default(string);
		while (true)
		{
			int num = Class45.smethod_0(1);
			while (true)
			{
				switch (num ^ Class45.smethod_0(85))
				{
				case 44:
					list.Add(Class47.smethod_0("\uef4d\uef4b\uef48\uef19\uef1e\uef4a\uef48\uef48\uef1d\uef1d\uef4b\uef19\uef1f\uef1d\uef1a\uef4b\uef1d\uef43\uef48\uef1d\uef49\uef4a\uef1e\uef4c\uef4f\uef4a\uef42\uef4a\uef18\uef1d\uef4d\uef4c\uef4c\uef4b\uef1e\uef1a\uef4f\uef48\uef19\uef19", 61307));
					num = 52;
					continue;
				case 43:
					list.Add(Class47.smethod_0("\ue0ab\ue0ad\ue0fc\ue0a7\ue0a7\ue0f9\ue0aa\ue0fe\ue0a8\ue0fd\ue0a8\ue0aa\ue0fd\ue0fc\ue0a6\ue0ab\ue0ab\ue0fc\ue0ad\ue0a7\ue0a7\ue0fe\ue0a8\ue0ad\ue0ae\ue0aa\ue0ac\ue0a6\ue0ae\ue0fb\ue0fc\ue0a6\ue0fc\ue0a8\ue0ac\ue0fd\ue0a9\ue0fa\ue0a6\ue0f9", 57368));
					num = Class45.smethod_0(94);
					continue;
				case 42:
					if (flag)
					{
						num = 49;
						continue;
					}
					if (1 == 0)
					{
						goto case 45;
					}
					goto IL_01f8;
				case 41:
					text4 = Delegate39.smethod_0(this).get_Text();
					num = 62;
					continue;
				case 40:
					num = 0;
					continue;
				case 39:
					num = 55;
					continue;
				case 38:
					num = 6;
					continue;
				case 37:
					num = 56;
					continue;
				case 36:
					list.Add(Class47.smethod_0("\ue0ab\ue0ad\ue0fc\ue0a7\ue0a7\ue0f9\ue0aa\ue0fe\ue0a8\ue0fd\ue0a8\ue0aa\ue0fd\ue0fc\ue0a6\ue0ab\ue0ab\ue0fc\ue0ad\ue0a7\ue0a7\ue0fe\ue0a8\ue0ad\ue0ae\ue0aa\ue0ac\ue0a6\ue0ae\ue0fb\ue0fc\ue0a6\ue0fc\ue0a8\ue0ac\ue0fd\ue0a9\ue0fa\ue0a6\ue0f9", 57368));
					num = 61;
					continue;
				case 35:
					flag = (Directory.Exists(Delegate41.smethod_0(this).get_Text()) ? 1 : 0) == Class45.smethod_0(0);
					num = 54;
					continue;
				case 34:
					text3 = Delegate40.smethod_0(this).get_Text();
					num = 48;
					continue;
				case 33:
					num = 7;
					continue;
				case 32:
					num = 60;
					continue;
				case 31:
					text2 = Delegate38.smethod_0(this).get_Text();
					num = 53;
					continue;
				case 30:
					random = new Random();
					num = 3;
					continue;
				case 29:
					list = new List<string>();
					num = 2;
					continue;
				case 28:
					list.Add(Class47.smethod_0("\ueb45\ueb43\ueb44\ueb12\ueb10\ueb17\ueb12\ueb47\ueb41\ueb47\ueb45\ueb4e\ueb45\ueb42\ueb10\ueb42\ueb10\ueb4f\ueb42\ueb15\ueb43\ueb10\ueb10\ueb45\ueb15\ueb45\ueb13\ueb43\ueb13\ueb4f\ueb4f\ueb42\ueb41\ueb41\ueb45\ueb42\ueb41\ueb14\ueb4f\ueb43", 60246));
					num = 59;
					continue;
				case 27:
					list.Add(Class47.smethod_0("\ue9c2\ue9c3\ue9cb\ue9cf\ue99f\ue9c2\ue9c2\ue99e\ue9c3\ue9ce\ue999\ue999\ue99a\ue99d\ue99f\ue9cf\ue999\ue999\ue9ca\ue9ca\ue9c8\ue9ce\ue99a\ue9ca\ue9cb\ue9cf\ue9cf\ue9cc\ue9cc\ue9c8\ue999\ue9cf\ue99f\ue99d\ue9c2\ue99d\ue9ca\ue999\ue99a\ue9c8", 59891));
					num = 58;
					continue;
				case 26:
					text = list[random.Next(Class45.smethod_0(0), Class45.smethod_0(11))];
					num = 63;
					continue;
				case 45:
					{
						Directory.CreateDirectory(Delegate41.smethod_0(this).get_Text());
						goto IL_01f8;
					}
					IL_01f8:
					if (((Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) != Class45.smethod_0(0)) ? true : false) || (((int)MessageBox.Show(Class47.smethod_0("\uedae\ued98\ued82\uedd7\ued9f\ued96\ued81\ued92\uedd7\ued9b\ued92\ued91\ued83\uedd7\ued83\ued9f\ued92\uedd7\uedb2\uedb4\uedbe\uedb3\uedd7\ued9e\ued99\ued87\ued82\ued83\uedd7\ued91\ued9e\ued92\ued9b\ued93\uedd7\ued95\ued9b\ued96\ued99\ued9c\uedd9\uedd7\ueda3\ued9f\ued9e\ued84\uedd7\ued80\ued9e\ued9b\ued9b\uedd7\ued96\ued9b\ued9b\ued98\ued80\uedd7\ued8e\ued98\ued82\uedd7\ued83\ued98\uedd7\ued93\ued98\ued80\ued99\ued9b\ued98\ued96\ued93\uedd7\ued96\uedd7\ueda4\uedbf\ueda4\uedbf\uedd7\ued95\ued9b\ued98\ued95\uedd7\ued91\ued98\ued85\uedd7\ued96\uedd7\ued85\ued96\ued99\ued93\ued98\ued9a\uedd7\uedb2\uedb4\uedbe\uedb3\uedd9\uedfa\uedfd\uedfa\uedfd\uedbe\ued84\uedd7\ued83\ued9f\ued9e\ued84\uedd7\uedb8\uedbc\uedc8", 60773), Class47.smethod_0("\uedaa\uedac\ueda6\uedab", 60911), (MessageBoxButtons)Class45.smethod_0(11), (MessageBoxIcon)Class45.smethod_0(12)) != Class45.smethod_0(2)) ? true : false))
					{
						return;
					}
					Delegate42.smethod_0(Class45.smethod_3(1));
					while (true)
					{
						int num2 = Class40.smethod_1(9);
						int num3 = -1;
						while (true)
						{
							num3 ^= Class45.smethod_0(99);
							string text5;
							while (true)
							{
								int num4 = Class40.smethod_1(15);
								while (true)
								{
									switch (num4 ^ Class45.smethod_0(101))
									{
									case -43:
										break;
									case -45:
										goto IL_02ff;
									case -44:
										num4 = -26;
										continue;
									default:
										goto end_IL_0312;
									case -42:
										goto end_IL_0338;
									}
									switch (num3)
									{
									case -45:
										goto IL_029a;
									case -42:
										goto IL_02f3;
									case -44:
										goto IL_034e;
									case -43:
										goto end_IL_0352;
									}
									num4 = -31;
									continue;
									IL_02ff:
									num3 = Class33.smethod_1(30);
									num4 = -28;
									continue;
									IL_034e:
									num3 = -3;
									goto end_IL_0338;
									IL_029a:
									switch (num2)
									{
									case -39:
										break;
									case -38:
										goto IL_02cf;
									case -37:
										goto IL_02d4;
									case -36:
										goto IL_02da;
									default:
										goto IL_0343;
									case -35:
										goto IL_0377;
									}
									if (flag2)
									{
										num2 = Class33.smethod_1(29);
										goto IL_02f3;
									}
									if (1 == 0)
									{
										goto IL_0377;
									}
									if ((((uint)Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0)) & (Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array = new string[Class45.smethod_0(16)];
											array[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array[Class45.smethod_0(1)] = text2;
											array[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array[Class45.smethod_0(14)] = text4;
											array[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array[Class45.smethod_0(15)] = text3;
											array[Class45.smethod_0(2)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName, string.Concat(array));
										}
										else
										{
											string fileName2 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array2 = new string[Class45.smethod_0(16)];
											array2[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array2[Class45.smethod_0(1)] = text2;
											array2[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array2[Class45.smethod_0(14)] = text4;
											array2[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array2[Class45.smethod_0(15)] = text3;
											array2[Class45.smethod_0(2)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName2, string.Concat(array2));
										}
									}
									else if ((((uint)Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0)) & ((uint)Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName3 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array3 = new string[Class45.smethod_0(18)];
											array3[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array3[Class45.smethod_0(1)] = text2;
											array3[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array3[Class45.smethod_0(14)] = text4;
											array3[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array3[Class45.smethod_0(15)] = text3;
											array3[Class45.smethod_0(2)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array3[Class45.smethod_0(16)] = Delegate41.smethod_0(this).get_Text();
											array3[Class45.smethod_0(13)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName3, string.Concat(array3));
										}
										else
										{
											string fileName4 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array4 = new string[Class45.smethod_0(18)];
											array4[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array4[Class45.smethod_0(1)] = text2;
											array4[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array4[Class45.smethod_0(14)] = text4;
											array4[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array4[Class45.smethod_0(15)] = text3;
											array4[Class45.smethod_0(2)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array4[Class45.smethod_0(16)] = Delegate41.smethod_0(this).get_Text();
											array4[Class45.smethod_0(13)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName4, string.Concat(array4));
										}
									}
									else if (((Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0)) & (Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName5 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array5 = new string[Class45.smethod_0(15)];
											array5[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array5[Class45.smethod_0(1)] = text2;
											array5[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array5[Class45.smethod_0(14)] = text3;
											array5[Class45.smethod_0(11)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName5, string.Concat(array5));
										}
										else
										{
											string fileName6 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array6 = new string[Class45.smethod_0(15)];
											array6[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array6[Class45.smethod_0(1)] = text2;
											array6[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array6[Class45.smethod_0(14)] = text3;
											array6[Class45.smethod_0(11)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName6, string.Concat(array6));
										}
									}
									else if (((Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0)) & ((uint)Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName7 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array7 = new string[Class45.smethod_0(16)];
											array7[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array7[Class45.smethod_0(1)] = text2;
											array7[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array7[Class45.smethod_0(14)] = text3;
											array7[Class45.smethod_0(11)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array7[Class45.smethod_0(15)] = Delegate41.smethod_0(this).get_Text();
											array7[Class45.smethod_0(2)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName7, string.Concat(array7));
										}
										else
										{
											string fileName8 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array8 = new string[Class45.smethod_0(16)];
											array8[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array8[Class45.smethod_0(1)] = text2;
											array8[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array8[Class45.smethod_0(14)] = text3;
											array8[Class45.smethod_0(11)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array8[Class45.smethod_0(15)] = Delegate41.smethod_0(this).get_Text();
											array8[Class45.smethod_0(2)] = Class47.smethod_0("\ueacf\ueac2\ueac2\uea81\uea80\uea8c\uea8e\uea8c\uea87\uea8a", 60079);
											Process.Start(fileName8, string.Concat(array8));
										}
									}
									goto IL_1254;
									IL_0343:
									num3 = Class33.smethod_1(25);
									goto end_IL_0338;
									IL_02da:
									flag2 = (Delegate43.smethod_0(this).get_Checked() ? 1 : 0) == Class45.smethod_0(0);
									num2 = -6;
									goto IL_02f3;
									IL_02d4:
									num2 = -8;
									goto IL_02f3;
									IL_02cf:
									num2 = -1;
									goto IL_02f3;
									IL_0377:
									if ((((uint)Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0)) & (Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName9 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array9 = new string[Class45.smethod_0(13)];
											array9[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array9[Class45.smethod_0(1)] = text2;
											array9[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array9[Class45.smethod_0(14)] = text4;
											array9[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array9[Class45.smethod_0(15)] = text3;
											array9[Class45.smethod_0(2)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array9[Class45.smethod_0(16)] = text;
											Process.Start(fileName9, string.Concat(array9));
										}
										else
										{
											string fileName10 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array10 = new string[Class45.smethod_0(13)];
											array10[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array10[Class45.smethod_0(1)] = text2;
											array10[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array10[Class45.smethod_0(14)] = text4;
											array10[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array10[Class45.smethod_0(15)] = text3;
											array10[Class45.smethod_0(2)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array10[Class45.smethod_0(16)] = text;
											Process.Start(fileName10, string.Concat(array10));
										}
									}
									else if ((((uint)Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0)) & ((uint)Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName11 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array11 = new string[Class45.smethod_0(17)];
											array11[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array11[Class45.smethod_0(1)] = text2;
											array11[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array11[Class45.smethod_0(14)] = text4;
											array11[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array11[Class45.smethod_0(15)] = text3;
											array11[Class45.smethod_0(2)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array11[Class45.smethod_0(16)] = Delegate41.smethod_0(this).get_Text();
											array11[Class45.smethod_0(13)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array11[Class45.smethod_0(18)] = text;
											Process.Start(fileName11, string.Concat(array11));
										}
										else
										{
											string fileName12 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array12 = new string[Class45.smethod_0(17)];
											array12[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array12[Class45.smethod_0(1)] = text2;
											array12[Class45.smethod_0(9)] = Class47.smethod_0("\ue68c\ue681\ue6c9\ue68c", 58892);
											array12[Class45.smethod_0(14)] = text4;
											array12[Class45.smethod_0(11)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array12[Class45.smethod_0(15)] = text3;
											array12[Class45.smethod_0(2)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array12[Class45.smethod_0(16)] = Delegate41.smethod_0(this).get_Text();
											array12[Class45.smethod_0(13)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array12[Class45.smethod_0(18)] = text;
											Process.Start(fileName12, string.Concat(array12));
										}
									}
									else if (((Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0)) & (Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName13 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array13 = new string[Class45.smethod_0(2)];
											array13[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array13[Class45.smethod_0(1)] = text2;
											array13[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array13[Class45.smethod_0(14)] = text3;
											array13[Class45.smethod_0(11)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array13[Class45.smethod_0(15)] = text;
											Process.Start(fileName13, string.Concat(array13));
										}
										else
										{
											string fileName14 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array14 = new string[Class45.smethod_0(2)];
											array14[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array14[Class45.smethod_0(1)] = text2;
											array14[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array14[Class45.smethod_0(14)] = text3;
											array14[Class45.smethod_0(11)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array14[Class45.smethod_0(15)] = text;
											Process.Start(fileName14, string.Concat(array14));
										}
									}
									else if (((Operators.CompareString(Delegate39.smethod_0(this).get_Text(), "", (byte)Class45.smethod_0(0) != 0) == Class45.smethod_0(0)) & ((uint)Operators.CompareString(Delegate41.smethod_0(this).get_Text(), Application.get_StartupPath(), (byte)Class45.smethod_0(0) != 0) > (uint)Class45.smethod_0(0))) || 1 == 0)
									{
										if (((ServerComputer)Delegate44.smethod_0()).get_FileSystem().FileExists(Class47.smethod_0("\ue48b\ue48c\ue48c\ue49c\ue497\ue49a\ue49c\ue494\ue49a\ue48d\ue4d1\ue49a\ue487\ue49a", 58519)) || 1 == 0)
										{
											string fileName15 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array15 = new string[Class45.smethod_0(13)];
											array15[Class45.smethod_0(0)] = Class47.smethod_0("\uf880\uf8e4\uf88f\uf8db\uf8dc\uf8dc\uf8cc\uf8c7\uf8ca\uf8cc\uf8c4\uf8ca\uf8dd\uf881\uf8ca\uf8d7\uf8ca\uf88f\uf882\uf8cb\uf88f", 63649);
											array15[Class45.smethod_0(1)] = text2;
											array15[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array15[Class45.smethod_0(14)] = text3;
											array15[Class45.smethod_0(11)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array15[Class45.smethod_0(15)] = Delegate41.smethod_0(this).get_Text();
											array15[Class45.smethod_0(2)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array15[Class45.smethod_0(16)] = text;
											Process.Start(fileName15, string.Concat(array15));
										}
										else
										{
											string fileName16 = Class47.smethod_0("\uf4ba\uf4b4\uf4bd", 62665);
											string[] array16 = new string[Class45.smethod_0(13)];
											array16[Class45.smethod_0(0)] = Class47.smethod_0("\ue7f0\ue794\ue7ff\ue7ab\ue7ac\ue7ac\ue7bc\ue7b7\ue7ba\ue7bc\ue7b4\ue7ba\ue7ad\ue780\ue7a8\ue7b6\ue7b1\ue7bb\ue7b0\ue7a8\ue7ac\ue7f1\ue7ba\ue7a7\ue7ba\ue7ff\ue7f2\ue7bb\ue7ff", 59359);
											array16[Class45.smethod_0(1)] = text2;
											array16[Class45.smethod_0(9)] = Class47.smethod_0("\uedcc\uedc1\ued9f\uedcc\uedc1\ued85\uedcc", 60876);
											array16[Class45.smethod_0(14)] = text3;
											array16[Class45.smethod_0(11)] = Class47.smethod_0("\uf64e\uf643\uf643\uf61d\uf60f\uf618\uf60b\uf643\uf61e\uf60f\uf61a\uf606\uf64e", 62986);
											array16[Class45.smethod_0(15)] = Delegate41.smethod_0(this).get_Text();
											array16[Class45.smethod_0(2)] = Class47.smethod_0("\uf3db\uf3d6\uf3d6\uf39a\uf38b\uf395\uf394\uf395\uf398\uf39e\uf3db", 62411);
											array16[Class45.smethod_0(16)] = text;
											Process.Start(fileName16, string.Concat(array16));
										}
									}
									goto IL_1254;
									IL_1254:
									text5 = Delegate41.smethod_0(this).get_Text();
									goto IL_12cf;
									IL_02f3:
									num2 ^= Class45.smethod_0(98);
									goto IL_02ff;
									continue;
									end_IL_0312:
									break;
								}
								continue;
								end_IL_0338:
								break;
							}
							continue;
							IL_12cf:
							while (true)
							{
								int num5 = Class1.Class2.smethod_1(31);
								while (true)
								{
									switch (num5 ^ Class45.smethod_0(96))
									{
									case -37:
										num5 = -13;
										continue;
									case -38:
										if (flag3)
										{
											num5 = Class33.smethod_1(27);
											continue;
										}
										if (true)
										{
											Interaction.AppActivate(fileName17);
											return;
										}
										goto case -36;
									case -39:
										flag3 = Delegate45.smethod_0(null, fileName17) == (IntPtr)Class45.smethod_0(0);
										num5 = -14;
										continue;
									case -40:
										fileName17 = Path.GetFileName(text5);
										num5 = -15;
										continue;
									case -36:
										Process.Start(Class47.smethod_0("\uf1d3\uf1ce\uf1c6\uf1da\uf1d9\uf1c4\uf1d3\uf1c4\uf198\uf1d3\uf1ce\uf1d3", 61878), text5);
										return;
									}
									break;
								}
							}
							continue;
							end_IL_0352:
							break;
						}
					}
				}
				break;
			}
		}
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		Class26.smethod_0(4099547, this, sender, e);
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		DialogResult val = default(DialogResult);
		Class6 object_ = default(Class6);
		bool flag = default(bool);
		while (true)
		{
			int num = Class45.smethod_0(51);
			while (true)
			{
				switch (num ^ Class45.smethod_0(77))
				{
				case 48:
					num = 23;
					continue;
				case 47:
					val = Delegate47.smethod_0(object_, (IWin32Window)(object)this);
					num = 10;
					continue;
				case 46:
					if (flag)
					{
						num = 22;
						continue;
					}
					if (1 == 0)
					{
						goto case 49;
					}
					return;
				case 45:
					flag = (int)val == Class45.smethod_0(1);
					num = Class45.smethod_0(18);
					continue;
				case 44:
					object_ = Delegate46.smethod_0();
					num = 8;
					continue;
				case 49:
					while (true)
					{
						int num2 = Class45.smethod_0(14);
						int num3 = Class47.smethod_2(42);
						while (true)
						{
							num3 ^= Class45.smethod_0(105);
							while (true)
							{
								int num4 = Class33.smethod_1(22);
								int num5 = Class45.smethod_0(91);
								while (true)
								{
									switch (num5 ^ Class45.smethod_0(102))
									{
									case 43:
										break;
									default:
										goto IL_0088;
									case 42:
										goto IL_0096;
									case 41:
										num5 = 24;
										continue;
									case 40:
										goto end_IL_013a;
									}
									goto IL_007c;
									IL_0096:
									switch (num4)
									{
									case -46:
										goto IL_00b9;
									case -45:
										goto IL_00bf;
									case -47:
										goto IL_0124;
									case -44:
										goto end_IL_0165;
									}
									num5 = 25;
									continue;
									IL_00bf:
									switch (num3)
									{
									case -41:
										goto IL_00de;
									case -38:
										goto IL_0118;
									case -39:
										goto IL_017f;
									case -40:
										goto end_IL_0183;
									}
									num4 = -1;
									goto IL_007c;
									IL_017f:
									num3 = -14;
									goto end_IL_0165;
									IL_00de:
									switch (num2)
									{
									case 48:
										break;
									case 49:
										goto IL_00ff;
									case 50:
										goto IL_0115;
									default:
										goto IL_0179;
									case 51:
										return;
									}
									num2 = 1;
									goto IL_0118;
									IL_0179:
									num3 = -13;
									goto end_IL_0165;
									IL_0115:
									num2 = 0;
									goto IL_0118;
									IL_00ff:
									Delegate41.smethod_0(this).set_Text(Delegate48.smethod_0(object_));
									num2 = 2;
									goto IL_0118;
									IL_0088:
									num5 = Class45.smethod_0(87);
									continue;
									IL_0118:
									num2 ^= Class45.smethod_0(101);
									goto IL_0124;
									IL_0124:
									num3 = Class33.smethod_1(25);
									num4 = -6;
									goto IL_007c;
									IL_007c:
									num4 ^= Class45.smethod_0(104);
									goto IL_0088;
									IL_00b9:
									num4 = -4;
									goto IL_007c;
									continue;
									end_IL_013a:
									break;
								}
								continue;
								end_IL_0165:
								break;
							}
							continue;
							end_IL_0183:
							break;
						}
					}
				}
				break;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	public static void smethod_0(Bitmap bitmap_0, Bitmap bitmap_1, Bitmap bitmap_2)
	{
		Class26.smethod_0(4097779, null, bitmap_0, bitmap_1, bitmap_2);
	}

	private void method_2(object sender, EventArgs e)
	{
		string text = default(string);
		string fileName = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = Class47.smethod_2(45);
			while (true)
			{
				switch (num ^ Class45.smethod_0(106))
				{
				case -37:
					text = Delegate41.smethod_0(this).get_Text();
					num = -10;
					continue;
				case -38:
					fileName = Path.GetFileName(text);
					num = -5;
					continue;
				case -39:
					num = -11;
					continue;
				case -40:
					if (flag)
					{
						num = -16;
						continue;
					}
					if (1 == 0)
					{
						goto case -36;
					}
					Interaction.AppActivate(fileName);
					return;
				case -41:
					flag = Delegate45.smethod_0(null, fileName) == (IntPtr)Class45.smethod_0(0);
					num = Class33.smethod_1(27);
					continue;
				case -36:
					while (true)
					{
						int num2 = Class45.smethod_0(9);
						int num3 = 26;
						while (true)
						{
							num3 ^= Class45.smethod_0(99);
							while (true)
							{
								int num4 = Class47.smethod_2(45);
								int num5 = -5;
								while (true)
								{
									switch (num5 ^ Class45.smethod_0(104))
									{
									case -43:
										break;
									default:
										goto IL_009c;
									case -44:
										num5 = -6;
										continue;
									case -45:
										goto IL_00b3;
									case -46:
										goto end_IL_0167;
									}
									goto IL_0090;
									IL_00b3:
									switch (num4)
									{
									case -41:
										goto IL_00d6;
									case -40:
										goto IL_00dc;
									case -39:
										goto IL_0155;
									case -38:
										goto end_IL_0192;
									}
									num5 = -4;
									continue;
									IL_00dc:
									switch (num3)
									{
									case 50:
										goto IL_0101;
									case 51:
										goto IL_0149;
									case 48:
										goto IL_01a1;
									case 49:
										goto end_IL_01b0;
									}
									num4 = Class47.smethod_2(41);
									goto IL_0090;
									IL_01a1:
									num3 = Class45.smethod_0(82);
									goto end_IL_0192;
									IL_0101:
									switch (num2)
									{
									case 39:
										break;
									case 40:
										goto IL_012b;
									case 41:
										goto IL_0146;
									default:
										goto IL_01ac;
									case 42:
										return;
									}
									num2 = Class45.smethod_0(37);
									goto IL_0149;
									IL_01ac:
									num3 = 24;
									goto end_IL_0192;
									IL_0146:
									num2 = 0;
									goto IL_0149;
									IL_012b:
									Process.Start(Class47.smethod_0("\uf1d3\uf1ce\uf1c6\uf1da\uf1d9\uf1c4\uf1d3\uf1c4\uf198\uf1d3\uf1ce\uf1d3", 61878), text);
									num2 = 3;
									goto IL_0149;
									IL_009c:
									num5 = Class33.smethod_1(22);
									continue;
									IL_0149:
									num2 ^= Class45.smethod_0(107);
									goto IL_0155;
									IL_0155:
									num3 = Class45.smethod_0(87);
									num4 = -11;
									goto IL_0090;
									IL_0090:
									num4 ^= Class45.smethod_0(100);
									goto IL_009c;
									IL_00d6:
									num4 = -8;
									goto IL_0090;
									continue;
									end_IL_0167:
									break;
								}
								continue;
								end_IL_0192:
								break;
							}
							continue;
							end_IL_01b0:
							break;
						}
					}
				}
				break;
			}
		}
	}

	public static string[] smethod_1(byte[] byte_0)
	{
		return (string[])Class26.smethod_0(4097068, null, byte_0);
	}

	private void method_3(object sender, EventArgs e)
	{
		while (true)
		{
			int num = Class45.smethod_0(84);
			while (true)
			{
				switch (num ^ Class45.smethod_0(106))
				{
				case 52:
					Delegate41.smethod_0(this).set_Text(Application.get_StartupPath());
					num = 30;
					continue;
				case 51:
					num = 31;
					continue;
				case 50:
					num = Class45.smethod_0(82);
					continue;
				case 53:
					return;
				}
				break;
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if ((!Delegate43.smethod_0(this).get_Checked()) ? true : false)
		{
			return;
		}
		while (true)
		{
			int num = Class33.smethod_1(30);
			int num2 = -8;
			while (true)
			{
				switch (num2 ^ Class45.smethod_0(105))
				{
				case -45:
					num ^= Class45.smethod_0(106);
					goto default;
				default:
					num2 = Class40.smethod_1(9);
					continue;
				case -46:
					switch (num)
					{
					default:
						num2 = -5;
						continue;
					case -43:
						num = -7;
						break;
					case -42:
						MessageBox.Show(Class47.smethod_0("\uefb8\uef8a\uef8a\uef90\uef8a\uef8d\uef98\uef97\uef8d\uefd9\uef8e\uef90\uef95\uef95\uefd9\uef8d\uef9c\uef95\uef95\uefd9\uef8d\uef8a\uef8a\uef9a\uef91\uef9c\uef9a\uef92\uef9c\uef8b\uefd9\uef97\uef96\uef8d\uefd9\uef8d\uef96\uefd9\uef8c\uef8a\uef9c\uefd9\uef8d\uef91\uef9c\uefd9\uef8a\uef98\uef8f\uef9c\uef9d\uefd9\uef9a\uef98\uef9a\uef91\uef9c\uefd7\uefd9\uefad\uef91\uef90\uef8a\uefd9\uef8e\uef90\uef95\uef95\uefd9\uef8d\uef9c\uef95\uef95\uefd9\uef8d\uef8a\uef8a\uef9a\uef91\uef9c\uef9a\uef92\uef9c\uef8b\uefd9\uef8d\uef96\uefd9\uef90\uef9e\uef97\uef96\uef8b\uef9c\uefd9\uef8d\uef91\uef9c\uefd9\uef8a\uef98\uef8f\uef9c\uef9d\uefd9\uef9a\uef98\uef9a\uef91\uef9c\uefd9\uef9d\uef98\uef8d\uef98\uefd5\uefd9\uef98\uef97\uef9d\uefd9\uef8b\uef9c\uef9d\uef96\uef8e\uef97\uef95\uef96\uef98\uef9d\uefd9\uef8d\uef91\uef9c\uefd9\uef8b\uef9c\uef88\uef8c\uef90\uef8b\uef9c\uef9d\uefd9\uef9f\uef90\uef95\uef9c\uef8a\uefd7\uefd9\uefac\uef8a\uef9c\uefd9\uef8d\uef91\uef90\uef8a\uefd9\uef90\uef9f\uefd9\uef80\uef96\uef8c\uefd9\uef9c\uef97\uef9a\uef96\uef8c\uef97\uef8d\uef9c\uef8b\uefd9\uef8d\uef91\uef9c\uefd9\uef9f\uef98\uef90\uef95\uef9c\uef9d\uefd9\uef8d\uef96\uefd9\uef89\uef98\uef8b\uef8a\uef9c\uefd9\uef9c\uef8b\uef8b\uef96\uef8b\uefd7", 61257), Class47.smethod_0("\uf4b7\uf496\uf4d9\uf4ba\uf498\uf49a\uf491\uf49c", 62633), (MessageBoxButtons)Class45.smethod_0(0), (MessageBoxIcon)Class45.smethod_0(4));
						num = -5;
						break;
					case -41:
						num = Class33.smethod_1(27);
						break;
					case -40:
						return;
					}
					goto case -45;
				case -47:
					num2 = -6;
					continue;
				case -48:
					break;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (((((!disposing) ? true : false) ? Class45.smethod_0(0) : ((icontainer_0 != null) ? 1 : 0)) == 0) ? true : false)
			{
				return;
			}
			while (true)
			{
				int num = Class45.smethod_0(9);
				int num2 = -1;
				while (true)
				{
					num2 ^= Class45.smethod_0(106);
					while (true)
					{
						int num3 = Class40.smethod_1(11);
						int num4 = 7;
						while (true)
						{
							switch (num4 ^ Class45.smethod_0(101))
							{
							case 53:
								break;
							default:
								goto IL_0035;
							case 52:
								goto IL_0042;
							case 50:
								num4 = 0;
								continue;
							case 51:
								goto end_IL_00da;
							}
							goto IL_002b;
							IL_0042:
							switch (num3)
							{
							case -46:
								goto IL_0060;
							case -45:
								goto IL_0065;
							case -44:
								goto IL_00c2;
							case -43:
								goto end_IL_0105;
							}
							num4 = 1;
							continue;
							IL_0065:
							switch (num2)
							{
							case -48:
								goto IL_0083;
							case -45:
								goto IL_00b8;
							case -47:
								goto IL_0117;
							case -46:
								goto end_IL_011a;
							}
							num3 = -28;
							goto IL_002b;
							IL_0117:
							num2 = -3;
							goto end_IL_0105;
							IL_0083:
							switch (num)
							{
							case 40:
								break;
							case 41:
								goto IL_00a2;
							case 42:
								goto IL_00ab;
							default:
								goto IL_0112;
							case 43:
								return;
							}
							num = 3;
							goto IL_00b8;
							IL_0112:
							num2 = -2;
							goto end_IL_0105;
							IL_00ab:
							icontainer_0.Dispose();
							num = 0;
							goto IL_00b8;
							IL_00a2:
							num = Class45.smethod_0(1);
							goto IL_00b8;
							IL_0035:
							num4 = Class45.smethod_0(2);
							continue;
							IL_00b8:
							num ^= Class45.smethod_0(96);
							goto IL_00c2;
							IL_00c2:
							num2 = Class33.smethod_1(25);
							num3 = Class47.smethod_2(49);
							goto IL_002b;
							IL_002b:
							num3 ^= Class45.smethod_0(12);
							goto IL_0035;
							IL_0060:
							num3 = -30;
							goto IL_002b;
							continue;
							end_IL_00da:
							break;
						}
						continue;
						end_IL_0105:
						break;
					}
					continue;
					end_IL_011a:
					break;
				}
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_5()
	{
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aad: Expected O, but got Unknown
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected O, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected O, but got Unknown
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c8: Expected O, but got Unknown
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d3: Expected O, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10de: Expected O, but got Unknown
		//IL_10df: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected O, but got Unknown
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected O, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected O, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected O, but got Unknown
		while (true)
		{
			int num = Class33.smethod_1(25);
			while (true)
			{
				num ^= Class45.smethod_0(105);
				switch (num)
				{
				case -18:
					((Control)this).set_Name(Class47.smethod_0("\uf7b4\uf79d\uf780\uf79f\uf7c3", 63458));
					((Form)this).set_Opacity(Class45.smethod_3(6));
					((Form)this).set_ShowInTaskbar((byte)Class45.smethod_0(0) != 0);
					((Form)this).set_StartPosition((FormStartPosition)Class45.smethod_0(1));
					((Form)this).set_Text(Class47.smethod_0("\uf8a9\uf8ae\uf8ae\uf8dd\uf8be\uf895\uf898\uf89e\uf896\uf898\uf88f\uf8dd\uf8bc\uf88e\uf88e\uf894\uf88e\uf889\uf89c\uf893\uf889", 63645));
					((Form)this).set_TopMost((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate69.smethod_0(this)).ResumeLayout((byte)Class45.smethod_0(0) != 0);
					num = Class1.Class2.smethod_1(38);
					continue;
				case -19:
					((ButtonBase)Delegate43.smethod_0(this)).set_Text(Class47.smethod_0("\uf4b7\uf496\uf4d9\uf4ba\uf498\uf49a\uf491\uf49c", 62633));
					((ButtonBase)Delegate43.smethod_0(this)).set_UseVisualStyleBackColor((byte)Class45.smethod_0(1) != 0);
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(Class45.smethod_2(2), Class45.smethod_2(3)));
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)Class45.smethod_0(1));
					((Form)this).set_ClientSize(new Size(Class45.smethod_0(71), Class45.smethod_0(72)));
					((Control)this).get_Controls().Add((Control)(object)Delegate70.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate81.smethod_0(this));
					num = -53;
					continue;
				case -20:
					((Control)Delegate69.smethod_0(this)).set_Name(Class47.smethod_0("\uf3b1\uf384\uf399\uf383\uf386\uf3b4\uf399\uf38e\uf3c7", 62422));
					((Control)Delegate69.smethod_0(this)).set_Size(new Size(Class45.smethod_0(55), Class45.smethod_0(56)));
					((Control)Delegate69.smethod_0(this)).set_TabIndex(Class45.smethod_0(14));
					Delegate69.smethod_0(this).set_TabStop((byte)Class45.smethod_0(0) != 0);
					Delegate69.smethod_0(this).set_Text(Class47.smethod_0("\uf6a5\uf697\uf680\uf693\uf6d6\uf6ba\uf699\uf695\uf697\uf682\uf69f\uf699\uf698", 63222));
					((ButtonBase)Delegate79.smethod_0(this)).set_FlatStyle((FlatStyle)Class45.smethod_0(14));
					((Control)Delegate79.smethod_0(this)).set_Location(new Point(Class45.smethod_0(52), Class45.smethod_0(57)));
					num = -9;
					continue;
				case -21:
					((Control)Delegate40.smethod_0(this)).set_Size(new Size(Class45.smethod_0(43), Class45.smethod_0(44)));
					while (true)
					{
						int num5 = Class45.smethod_0(90);
						while (true)
						{
							switch (num5 ^ Class45.smethod_0(103))
							{
							case 60:
								num = -11;
								num5 = 16;
								continue;
							case 59:
								num5 = 27;
								continue;
							case 58:
								num5 = 24;
								continue;
							case 57:
								((Control)Delegate75.smethod_0(this)).set_Location(new Point(Class45.smethod_0(47), Class45.smethod_0(3)));
								num5 = 21;
								continue;
							case 56:
								num5 = 28;
								continue;
							case 55:
								((Control)Delegate40.smethod_0(this)).set_TabIndex(Class45.smethod_0(9));
								num5 = 22;
								continue;
							case 54:
								Delegate75.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
								num5 = 23;
								continue;
							case 53:
								((Control)Delegate75.smethod_0(this)).set_ForeColor(SystemColors.ControlDark);
								num5 = 25;
								continue;
							case 52:
								num5 = 20;
								continue;
							case 51:
								num5 = 26;
								continue;
							case 50:
								((Control)Delegate75.smethod_0(this)).set_Size(new Size(Class45.smethod_0(48), Class45.smethod_0(37)));
								num5 = 29;
								continue;
							case 49:
								((Control)Delegate75.smethod_0(this)).set_Name(Class47.smethod_0("\ue192\ue19f\ue19e\ue195\ue18f\ue192\ue19d\ue192\ue19e\ue189\ue1a4\ue197\ue199\ue197\ue1a4\ue1be\ue1a3", 57755));
								num5 = Class45.smethod_0(14);
								continue;
							case 48:
								num5 = 17;
								continue;
							case 47:
								num5 = 2;
								continue;
							case 46:
								num5 = 31;
								continue;
							case 61:
								goto end_IL_032e;
							}
							break;
						}
						continue;
						end_IL_032e:
						break;
					}
					continue;
				case -22:
					((Control)Delegate38.smethod_0(this)).set_TabIndex(Class45.smethod_0(0));
					while (true)
					{
						int num4 = Class15.smethod_0(47);
						while (true)
						{
							switch (num4 ^ Class45.smethod_0(12))
							{
							case -31:
								num4 = -47;
								continue;
							case -32:
								num4 = -27;
								continue;
							case -33:
								num4 = -29;
								continue;
							case -34:
								((Control)Delegate40.smethod_0(this)).set_Location(new Point(Class45.smethod_0(41), Class45.smethod_0(46)));
								num4 = Class47.smethod_2(50);
								continue;
							case -35:
								num4 = -22;
								continue;
							case -36:
								num4 = -18;
								continue;
							case -37:
								num4 = -28;
								continue;
							case -38:
								((Control)Delegate39.smethod_0(this)).set_Size(new Size(Class45.smethod_0(43), Class45.smethod_0(44)));
								num4 = -17;
								continue;
							case -39:
								num4 = -25;
								continue;
							case -40:
								num4 = -26;
								continue;
							case -41:
								num = -64;
								num4 = -46;
								continue;
							case -42:
								((Control)Delegate40.smethod_0(this)).set_Name(Class47.smethod_0("\uf1b6\uf1b0\uf1ac\uf189\uf1ba\uf1ad\uf180\uf1ab\uf1a7\uf1ab", 61918));
								num4 = -23;
								continue;
							case -43:
								((Control)Delegate39.smethod_0(this)).set_Name(Class47.smethod_0("\uf02a\uf02c\uf026\uf02b\uf030\uf01b\uf017\uf01b", 61537));
								num4 = -19;
								continue;
							case -44:
								((Control)Delegate39.smethod_0(this)).set_Location(new Point(Class45.smethod_0(41), Class45.smethod_0(45)));
								num4 = -48;
								continue;
							case -45:
								((Control)Delegate39.smethod_0(this)).set_TabIndex(Class45.smethod_0(1));
								num4 = -20;
								continue;
							case -30:
								goto end_IL_04ad;
							}
							break;
						}
						continue;
						end_IL_04ad:
						break;
					}
					continue;
				case -23:
					((Control)Delegate41.smethod_0(this)).set_Size(new Size(Class45.smethod_0(61), Class45.smethod_0(44)));
					while (true)
					{
						int num3 = Class45.smethod_0(15);
						while (true)
						{
							switch (num3 ^ Class45.smethod_0(105))
							{
							case 58:
								((Control)Delegate81.smethod_0(this)).set_Name(Class47.smethod_0("\ue8bb\ue896\ue895\ue892\ue89b\ue8c6", 59493));
								num3 = 24;
								continue;
							case 57:
								num3 = 19;
								continue;
							case 56:
								Delegate81.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
								num3 = 7;
								continue;
							case 55:
								num3 = 27;
								continue;
							case 54:
								num3 = 31;
								continue;
							case 53:
								((Control)Delegate81.smethod_0(this)).set_Size(new Size(Class45.smethod_0(64), Class45.smethod_0(37)));
								num3 = 28;
								continue;
							case 52:
								((Control)Delegate81.smethod_0(this)).set_Location(new Point(Class45.smethod_0(62), Class45.smethod_0(63)));
								num3 = 25;
								continue;
							case 51:
								num3 = 30;
								continue;
							case 50:
								num3 = 17;
								continue;
							case 49:
								((Control)Delegate81.smethod_0(this)).set_ForeColor(SystemColors.ControlDark);
								num3 = 29;
								continue;
							case 48:
								num = -14;
								num3 = 16;
								continue;
							case 47:
								((Control)Delegate41.smethod_0(this)).set_TabIndex(Class45.smethod_0(0));
								num3 = 18;
								continue;
							case 46:
								num3 = Class45.smethod_0(11);
								continue;
							case 45:
								num3 = 6;
								continue;
							case 44:
								num3 = 26;
								continue;
							case 59:
								goto end_IL_0613;
							}
							break;
						}
						continue;
						end_IL_0613:
						break;
					}
					continue;
				case -24:
					Delegate58.smethod_0(this, new Label());
					Delegate59.smethod_0(this, new Label());
					Delegate60.smethod_0(this, new Label());
					Delegate61.smethod_0(this, new Button());
					Delegate62.smethod_0(this, new GroupBox());
					Delegate63.smethod_0(this, new Button());
					Delegate64.smethod_0(this, new Button());
					num = -54;
					continue;
				case -25:
					((ButtonBase)Delegate78.smethod_0(this)).set_Text(Class47.smethod_0("\uf33d\uf30d\uf310\uf308\uf30c\uf31a\uf351\uf351\uf351", 62247));
					((ButtonBase)Delegate78.smethod_0(this)).set_UseVisualStyleBackColor((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate69.smethod_0(this)).get_Controls().Add((Control)(object)Delegate79.smethod_0(this));
					((Control)Delegate69.smethod_0(this)).get_Controls().Add((Control)(object)Delegate80.smethod_0(this));
					((Control)Delegate69.smethod_0(this)).get_Controls().Add((Control)(object)Delegate41.smethod_0(this));
					((Control)Delegate69.smethod_0(this)).get_Controls().Add((Control)(object)Delegate78.smethod_0(this));
					((Control)Delegate69.smethod_0(this)).set_Location(new Point(Class45.smethod_0(53), Class45.smethod_0(54)));
					num = -57;
					continue;
				case -26:
					Delegate70.smethod_0(this).set_TabStop((byte)Class45.smethod_0(0) != 0);
					Delegate70.smethod_0(this).set_Text(Class47.smethod_0("\uf420\uf41f\uf41b\uf406\uf400\uf401\uf41c\uf44f\uf440\uf440\uf44f\uf42e\uf40c\uf41b\uf406\uf400\uf401\uf41c", 62529));
					((ButtonBase)Delegate43.smethod_0(this)).set_AutoSize((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate43.smethod_0(this)).set_Location(new Point(Class45.smethod_0(60), Class45.smethod_0(69)));
					((Control)Delegate43.smethod_0(this)).set_Name(Class47.smethod_0("\uf1b5\uf194\uf1b8\uf19a\uf198\uf193\uf19e\uf1a4\uf198\uf193\uf199\uf183", 61915));
					((Control)Delegate43.smethod_0(this)).set_Size(new Size(Class45.smethod_0(70), Class45.smethod_0(60)));
					((Control)Delegate43.smethod_0(this)).set_TabIndex(Class45.smethod_0(0));
					num = -58;
					continue;
				case -27:
					((Control)Delegate80.smethod_0(this)).set_Name(Class47.smethod_0("\uf863\uf840\uf84c\uf860\uf85f\uf84a\uf841\uf870\uf84d\uf85b\uf841", 63521));
					((Control)Delegate80.smethod_0(this)).set_Size(new Size(Class45.smethod_0(33), Class45.smethod_0(34)));
					((Control)Delegate80.smethod_0(this)).set_TabIndex(Class45.smethod_0(9));
					((ButtonBase)Delegate80.smethod_0(this)).set_Text(Class47.smethod_0("\ue058\ue067\ue072\ue079", 57348));
					((ButtonBase)Delegate80.smethod_0(this)).set_UseVisualStyleBackColor((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate41.smethod_0(this)).set_Location(new Point(Class45.smethod_0(60), Class45.smethod_0(42)));
					((Control)Delegate41.smethod_0(this)).set_Name(Class47.smethod_0("\ue2a0\ue292\ue285\ue296\ue2bf\ue29c\ue290\ue2ac\ue287\ue28b\ue287", 58048));
					num = -62;
					continue;
				case -28:
					((Control)Delegate77.smethod_0(this)).set_TabIndex(Class45.smethod_0(51));
					Delegate77.smethod_0(this).set_Text(Class47.smethod_0("\uec33\uec0e\uec17\uec1b\uec06\uec1a\uec13\uec4c\uec56\uec47\uec46\uec58\uec47\uec58\uec47", 60518));
					((ButtonBase)Delegate78.smethod_0(this)).set_FlatStyle((FlatStyle)Class45.smethod_0(14));
					((Control)Delegate78.smethod_0(this)).set_Location(new Point(Class45.smethod_0(52), Class45.smethod_0(51)));
					((Control)Delegate78.smethod_0(this)).set_Name(Class47.smethod_0("\uf6f0\uf6c0\uf6dd\uf6c5\uf6c1\uf6d7\uf6ed\uf6d0\uf6c6\uf6dc", 63122));
					((Control)Delegate78.smethod_0(this)).set_Size(new Size(Class45.smethod_0(33), Class45.smethod_0(34)));
					((Control)Delegate78.smethod_0(this)).set_TabIndex(Class45.smethod_0(1));
					num = -52;
					continue;
				case -29:
					((Control)Delegate74.smethod_0(this)).set_Name(Class47.smethod_0("\uebbe\uebb8\ueba4\ueb81\uebb2\ueba5\ueb88\uebbb\uebb5\uebbb", 60229));
					((Control)Delegate74.smethod_0(this)).set_Size(new Size(Class45.smethod_0(38), Class45.smethod_0(37)));
					((Control)Delegate74.smethod_0(this)).set_TabIndex(Class45.smethod_0(14));
					Delegate74.smethod_0(this).set_Text(Class47.smethod_0("\uf89b\uf8bd\uf8a1\uf8d2\uf8a4\uf897\uf880\uf881\uf89b\uf89d\uf89c\uf8c8", 63730));
					((Control)Delegate38.smethod_0(this)).set_Location(new Point(Class45.smethod_0(41), Class45.smethod_0(42)));
					((Control)Delegate38.smethod_0(this)).set_Name(Class47.smethod_0("\uf697\uf69a\uf69b\uf690\uf68a\uf697\uf698\uf697\uf69b\uf68c\uf6a1\uf68a\uf686\uf68a", 63162));
					((Control)Delegate38.smethod_0(this)).set_Size(new Size(Class45.smethod_0(43), Class45.smethod_0(44)));
					num = -63;
					continue;
				case -30:
					((ButtonBase)Delegate71.smethod_0(this)).set_FlatStyle((FlatStyle)Class45.smethod_0(14));
					((Control)Delegate71.smethod_0(this)).set_Location(new Point(Class45.smethod_0(31), Class45.smethod_0(32)));
					((Control)Delegate71.smethod_0(this)).set_Name(Class47.smethod_0("\uec77\uec5a\uec4e\uec55\uec58\uec53\uec64\uec79\uec4f\uec55", 60451));
					((Control)Delegate71.smethod_0(this)).set_Size(new Size(Class45.smethod_0(33), Class45.smethod_0(34)));
					((Control)Delegate71.smethod_0(this)).set_TabIndex(Class45.smethod_0(11));
					((ButtonBase)Delegate71.smethod_0(this)).set_Text(Class47.smethod_0("\ue7b3\ue79e\ue78a\ue791\ue79c\ue797", 59271));
					((ButtonBase)Delegate71.smethod_0(this)).set_UseVisualStyleBackColor((byte)Class45.smethod_0(1) != 0);
					num = -10;
					continue;
				case -31:
					Delegate65.smethod_0(this, new TextBox());
					Delegate66.smethod_0(this, new Label());
					Delegate67.smethod_0(this, new GroupBox());
					Delegate68.smethod_0(this, new CheckBox());
					((Control)Delegate69.smethod_0(this)).SuspendLayout();
					((Control)Delegate70.smethod_0(this)).SuspendLayout();
					((Control)this).SuspendLayout();
					num = -55;
					continue;
				case -32:
					((Control)this).get_Controls().Add((Control)(object)Delegate69.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate77.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate76.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate75.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate40.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate39.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate38.smethod_0(this));
					num = -12;
					continue;
				case -33:
					((Control)this).get_Controls().Add((Control)(object)Delegate74.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate73.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate72.smethod_0(this));
					((Control)this).get_Controls().Add((Control)(object)Delegate71.smethod_0(this));
					((Form)this).set_FormBorderStyle((FormBorderStyle)Class45.smethod_0(1));
					((Form)this).set_MaximizeBox((byte)Class45.smethod_0(0) != 0);
					((Form)this).set_MinimumSize(new Size(Class45.smethod_0(73), Class45.smethod_0(74)));
					num = -59;
					continue;
				case -34:
					((Control)Delegate75.smethod_0(this)).set_TabIndex(Class45.smethod_0(18));
					Delegate75.smethod_0(this).set_Text(Class47.smethod_0("\uf8ea\uf8d7\uf8ce\uf8c2\uf8df\uf8c3\uf8ca\uf895\uf88f\uf8c6\uf8ff\uf8c7\uf8c0\uf8c1\uf8ca\uf898\uf883\uf89d", 63656));
					Delegate76.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate76.smethod_0(this)).set_ForeColor(SystemColors.ControlDark);
					((Control)Delegate76.smethod_0(this)).set_Location(new Point(Class45.smethod_0(47), Class45.smethod_0(38)));
					((Control)Delegate76.smethod_0(this)).set_Name(Class47.smethod_0("\ue9ba\ue9bc\ue9b6\ue9bb\ue9a0\ue993\ue99d\ue993\ue9a0\ue9ba\ue9a7", 59711));
					((Control)Delegate76.smethod_0(this)).set_Size(new Size(Class45.smethod_0(49), Class45.smethod_0(37)));
					num = -15;
					continue;
				case -35:
					Delegate72.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate72.smethod_0(this)).set_Location(new Point(Class45.smethod_0(35), Class45.smethod_0(3)));
					((Control)Delegate72.smethod_0(this)).set_Name(Class47.smethod_0("\uedba\ued98\ued93\ued92\ued9b\ueda8\ued9b\ued95\ued9b", 60789));
					((Control)Delegate72.smethod_0(this)).set_Size(new Size(Class45.smethod_0(36), Class45.smethod_0(37)));
					((Control)Delegate72.smethod_0(this)).set_TabIndex(Class45.smethod_0(1));
					Delegate72.smethod_0(this).set_Text(Class47.smethod_0("\ue932\ue910\ue91b\ue91a\ue913\ue95f\ue936\ue91b\ue91a\ue911\ue90b\ue916\ue919\ue916\ue91a\ue90d\ue945", 59703));
					Delegate73.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
					num = -13;
					continue;
				case -36:
					((Control)Delegate79.smethod_0(this)).set_Name(Class47.smethod_0("\uf824\uf805\uf802\uf83a\uf819\uf815\uf817\uf802\uf81f\uf819\uf818\uf829\uf814\uf802\uf818", 63558));
					((Control)Delegate79.smethod_0(this)).set_Size(new Size(Class45.smethod_0(58), Class45.smethod_0(34)));
					((Control)Delegate79.smethod_0(this)).set_TabIndex(Class45.smethod_0(14));
					((ButtonBase)Delegate79.smethod_0(this)).set_Text(Class47.smethod_0("\uedad\ued9a\ued8c\ued9a\ued8b\ueddf\ued8b\ued90\ueddf\uedbb\ued9a\ued99\ued9e\ued8a\ued93\ued8b", 60798));
					((ButtonBase)Delegate79.smethod_0(this)).set_UseVisualStyleBackColor((byte)Class45.smethod_0(1) != 0);
					((ButtonBase)Delegate80.smethod_0(this)).set_FlatStyle((FlatStyle)Class45.smethod_0(14));
					((Control)Delegate80.smethod_0(this)).set_Location(new Point(Class45.smethod_0(59), Class45.smethod_0(51)));
					num = -50;
					continue;
				case -37:
					num = -16;
					continue;
				case -38:
					((Control)Delegate76.smethod_0(this)).set_TabIndex(Class45.smethod_0(17));
					Delegate76.smethod_0(this).set_Text(Class47.smethod_0("\uedb2\ued8f\ued96\ued9a\ued87\ued9b\ued92\uedcd\uedd7\uedc6\uedb4\uedc2\uedc4\uedc7\uedc5\uedb4\uedc6\uedc7\uedb6\uedb4", 60773));
					Delegate77.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
					((Control)Delegate77.smethod_0(this)).set_ForeColor(SystemColors.ControlDark);
					((Control)Delegate77.smethod_0(this)).set_Location(new Point(Class45.smethod_0(47), Class45.smethod_0(40)));
					((Control)Delegate77.smethod_0(this)).set_Name(Class47.smethod_0("\uef9f\uef99\uef85\uefa0\uef93\uef84\uefa9\uef9a\uef94\uef9a\uefa9\uefb3\uefae", 61430));
					((Control)Delegate77.smethod_0(this)).set_Size(new Size(Class45.smethod_0(50), Class45.smethod_0(37)));
					num = -49;
					continue;
				case -39:
					((Control)Delegate81.smethod_0(this)).set_TabIndex(Class45.smethod_0(65));
					Delegate81.smethod_0(this).set_Text(Class47.smethod_0("\ue5ec\ue5d6\ue5d2\ue5de\ue5d3\ue5de\ue5cd\ue5c6\ue59f\ue5ec\ue5cb\ue5ca\ue5db\ue5d6\ue5d0\ue5cc", 58686));
					((Control)Delegate70.smethod_0(this)).get_Controls().Add((Control)(object)Delegate43.smethod_0(this));
					((Control)Delegate70.smethod_0(this)).set_Location(new Point(Class45.smethod_0(53), Class45.smethod_0(66)));
					((Control)Delegate70.smethod_0(this)).set_Name(Class47.smethod_0("\ue571\ue544\ue559\ue543\ue546\ue574\ue559\ue54e\ue504", 58662));
					((Control)Delegate70.smethod_0(this)).set_Size(new Size(Class45.smethod_0(55), Class45.smethod_0(67)));
					((Control)Delegate70.smethod_0(this)).set_TabIndex(Class45.smethod_0(68));
					num = -51;
					continue;
				case -40:
					((Control)Delegate73.smethod_0(this)).set_Location(new Point(Class45.smethod_0(35), Class45.smethod_0(38)));
					while (true)
					{
						int num2 = Class15.smethod_0(43);
						while (true)
						{
							switch (num2 ^ Class45.smethod_0(12))
							{
							case -30:
								num2 = -19;
								continue;
							case -31:
								num2 = -17;
								continue;
							case -32:
								((Control)Delegate73.smethod_0(this)).set_Size(new Size(Class45.smethod_0(39), Class45.smethod_0(37)));
								num2 = -27;
								continue;
							case -33:
								Delegate73.smethod_0(this).set_Text(Class47.smethod_0("\ue3fb\ue3da\ue3c9\ue3d6\ue3dc\ue3da\ue39f\ue3fa\ue3fc\ue3f6\ue3fb\ue385", 58174));
								num2 = -46;
								continue;
							case -34:
								num2 = -23;
								continue;
							case -35:
								Delegate74.smethod_0(this).set_AutoSize((byte)Class45.smethod_0(1) != 0);
								num2 = -18;
								continue;
							case -36:
								num2 = -24;
								continue;
							case -37:
								num2 = -22;
								continue;
							case -38:
								num = -56;
								num2 = -45;
								continue;
							case -39:
								((Control)Delegate74.smethod_0(this)).set_Location(new Point(Class45.smethod_0(35), Class45.smethod_0(40)));
								num2 = -21;
								continue;
							case -40:
								((Control)Delegate73.smethod_0(this)).set_Name(Class47.smethod_0("\uf5b3\uf5b5\uf5bf\uf5b2\uf5a9\uf59a\uf594\uf59a", 62918));
								num2 = -28;
								continue;
							case -41:
								num2 = Class40.smethod_1(15);
								continue;
							case -42:
								((Control)Delegate73.smethod_0(this)).set_TabIndex(Class45.smethod_0(9));
								num2 = -47;
								continue;
							case -43:
								num2 = -26;
								continue;
							case -44:
								num2 = -48;
								continue;
							case -29:
								goto end_IL_10b3;
							}
							break;
						}
						continue;
						end_IL_10b3:
						break;
					}
					continue;
				case -41:
					Delegate51.smethod_0(this, new Button());
					Delegate52.smethod_0(this, new Label());
					Delegate53.smethod_0(this, new Label());
					Delegate54.smethod_0(this, new Label());
					Delegate55.smethod_0(this, new TextBox());
					Delegate56.smethod_0(this, new TextBox());
					Delegate57.smethod_0(this, new TextBox());
					num = -61;
					continue;
				case -17:
					((Control)Delegate69.smethod_0(this)).PerformLayout();
					((Control)Delegate70.smethod_0(this)).ResumeLayout((byte)Class45.smethod_0(0) != 0);
					((Control)Delegate70.smethod_0(this)).PerformLayout();
					((Control)this).ResumeLayout((byte)Class45.smethod_0(0) != 0);
					((Control)this).PerformLayout();
					return;
				}
				break;
			}
		}
	}
}
