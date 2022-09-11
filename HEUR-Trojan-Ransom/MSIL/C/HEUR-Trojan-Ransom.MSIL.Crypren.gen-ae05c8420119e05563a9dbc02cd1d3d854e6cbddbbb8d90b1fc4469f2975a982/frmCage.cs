using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using antlr;

[DesignerGenerated]
public class frmCage : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("\u0c44\u0c70ఝ\u0c04ఐ౾ఌఽ\u0c4d\u0c52")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ComboBox comboBox_0;

	[AccessedThroughProperty("\u0c44\u0c70ఝ\u0c04ఐ౾ఌఽ\u0c4d\u0c53")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("\u0c44\u0c70ఝ\u0c04ఐ౾ఌఽ\u0c4d\u0c54")]
	[CompilerGenerated]
	private TextBox textBox_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("\u0c44\u0c70ఝ\u0c04ఐ౾ఌఽ\u0c4d\u0c55")]
	private Label label_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("\u0c44\u0c70ఝ\u0c04ఐ౾ఌఽ\u0c4d\u0c56")]
	private Button button_0;

	[AccessedThroughProperty("\u0c44\u0c70ఝ\u0c04ఐ౾ఌఽ\u0c4d\u0c57")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox pictureBox_0;

	internal virtual ComboBox ComboBox_0
	{
		[CompilerGenerated]
		get
		{
			return comboBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_5;
			ComboBox val = comboBox_0;
			if (val != null || 1 == 0)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			comboBox_0 = value;
			val = comboBox_0;
			if (val != null || 1 == 0)
			{
				val.add_SelectedIndexChanged(eventHandler);
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
			button_0 = value;
		}
	}

	internal virtual PictureBox PictureBox_0
	{
		[CompilerGenerated]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			pictureBox_0 = value;
		}
	}

	public frmCage()
	{
		((Form)this).add_Load((EventHandler)frmCage_Load);
		Delegate20.smethod_0(this);
	}

	public void method_0()
	{
		Class26.smethod_0(7388755, this, null);
	}

	private void frmCage_Load(object sender, EventArgs e)
	{
		Class26.smethod_0(7381310, this, sender, e);
	}

	public object method_1(XDocument xdocument_0)
	{
		return Class26.smethod_0(7384764, this, xdocument_0);
	}

	public object method_2(UnmanagedMemoryAccessor unmanagedMemoryAccessor_0)
	{
		return Class26.smethod_0(7395175, this, unmanagedMemoryAccessor_0);
	}

	public object method_3(TabSizeMode tabSizeMode_0, ToolStripComboBox toolStripComboBox_0)
	{
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		File.Exists("C:\\1xqm4rfg.kjw");
		while (true)
		{
			int num = 12;
			int num2 = 11;
			while (true)
			{
				num2 ^= 0x67;
				while (true)
				{
					int num3 = Class40.smethod_2(60);
					int num4 = 3;
					while (true)
					{
						num4 ^= 0x60;
						while (true)
						{
							int num5 = 7;
							int num6 = 25;
							while (true)
							{
								num6 ^= 0x6A;
								int num7 = Class24.smethod_0(56);
								while (true)
								{
									switch (num7 ^ 0x6A)
									{
									case -102:
										break;
									default:
										num7 = Class24.smethod_0(56);
										continue;
									case -103:
										num6 = 27;
										num7 = -10;
										num7 = -100;
										goto end_IL_003e;
									case -100:
										goto end_IL_003e;
									case -101:
										while (true)
										{
											num7 = -15;
											num7 = -101;
										}
									}
									switch (num6)
									{
									case 113:
										goto IL_0072;
									case 114:
										goto IL_01bf;
									case 115:
										goto IL_01c5;
									case 112:
										goto end_IL_01d8;
									}
									num7 = Class40.smethod_2(58);
									continue;
									IL_01bf:
									num6 = 24;
									break;
									continue;
									end_IL_003e:
									break;
								}
								continue;
								IL_01c5:
								num5 ^= 0x60;
								num6 = 27;
								num7 = -10;
								num7 = -100;
								continue;
								IL_0072:
								switch (num5)
								{
								case 103:
									goto IL_0095;
								case 102:
									goto IL_01b1;
								case 104:
									goto IL_01ba;
								case 105:
									goto end_IL_01ed;
								}
								num6 = 26;
								continue;
								IL_01ba:
								num5 = 8;
								goto IL_01c5;
								IL_0095:
								switch (num4)
								{
								case 98:
									goto IL_00b7;
								case 99:
									goto IL_01aa;
								case 97:
									goto IL_01f6;
								case 96:
									goto end_IL_01fe;
								}
								num5 = 6;
								goto IL_01c5;
								IL_01f6:
								num4 = 1;
								goto end_IL_01ed;
								IL_00b7:
								switch (num3)
								{
								case -108:
									break;
								case -109:
									goto IL_0197;
								case -107:
									goto IL_01a6;
								default:
									goto IL_01fb;
								case -106:
									goto end_IL_0207;
								}
								switch (num2)
								{
								case 105:
									goto IL_00f9;
								case 108:
									goto IL_0190;
								case 107:
									goto IL_021b;
								case 106:
									goto end_IL_021f;
								}
								num3 = -10;
								goto IL_01aa;
								IL_01fb:
								num4 = 0;
								goto end_IL_01ed;
								IL_01a6:
								num3 = -16;
								goto IL_01aa;
								IL_01b1:
								num4 = 2;
								num5 = 9;
								goto IL_01c5;
								IL_021b:
								num2 = 12;
								goto end_IL_0207;
								IL_00f9:
								switch (num)
								{
								case 107:
									break;
								case 108:
									goto IL_0131;
								case 109:
									goto IL_0137;
								case 110:
									goto IL_013d;
								case 111:
									goto IL_0153;
								case 112:
									goto IL_0159;
								case 113:
									goto IL_015f;
								case 114:
									goto IL_0175;
								default:
									goto IL_0215;
								case 115:
									Guid.NewGuid();
									try
									{
										if ((!string.IsNullOrEmpty("inAxgtSSuCPrLqOgGhsmEnKuEKGRjyFHQojMOvBUdRxttswiovMnmCsvnLpTR")) ? true : false)
										{
											_ = Environment.Is64BitProcess;
										}
									}
									catch (Exception projectError)
									{
										ProjectData.SetProjectError(projectError);
										ProjectData.ClearProjectError();
									}
									try
									{
										if ((61 < Environment.TickCount) ? true : false)
										{
											_ = ((ServerComputer)new Computer()).get_FileSystem().get_Drives().Count;
										}
									}
									catch (Exception projectError2)
									{
										ProjectData.SetProjectError(projectError2);
										ProjectData.ClearProjectError();
									}
									return 2;
								}
								num = 8;
								goto IL_0190;
								IL_0215:
								num2 = 13;
								goto end_IL_0207;
								IL_0175:
								_ = new string[2] { "jlOnGOMixxMeQkUXkoU", "ndGPJNIfTWErGWlJcEm" };
								num = 11;
								goto IL_0190;
								IL_015f:
								decimal num8 = new decimal(370445583L);
								num = 10;
								goto IL_0190;
								IL_0159:
								num = 23;
								goto IL_0190;
								IL_0153:
								num = 9;
								goto IL_0190;
								IL_013d:
								decimal num9 = new decimal(6L);
								num = 22;
								goto IL_0190;
								IL_0137:
								num = 21;
								goto IL_0190;
								IL_0131:
								num = 20;
								goto IL_0190;
								IL_01aa:
								num3 ^= 0x65;
								goto IL_01b1;
								IL_0190:
								num ^= 0x67;
								goto IL_0197;
								IL_0197:
								num2 = 14;
								num3 = Class40.smethod_2(58);
								goto IL_01aa;
								continue;
								end_IL_01d8:
								break;
							}
							continue;
							end_IL_01ed:
							break;
						}
						continue;
						end_IL_01fe:
						break;
					}
					continue;
					end_IL_0207:
					break;
				}
				continue;
				end_IL_021f:
				break;
			}
		}
	}

	public void method_4()
	{
		Class26.smethod_0(7396578, this, null);
	}

	private void method_5(object sender, EventArgs e)
	{
		Class26.smethod_0(7395936, this, sender, e);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((((!disposing) ? true : false) || icontainer_0 == null) ? true : false)
			{
				return;
			}
			while (true)
			{
				int num = Class40.smethod_2(54);
				int num2 = 31;
				while (true)
				{
					num2 ^= 0x6F;
					while (true)
					{
						int num3 = 7;
						int num4 = 15;
						while (true)
						{
							num4 ^= 0x62;
							while (true)
							{
								int num5 = 1;
								int num6 = 1;
								while (true)
								{
									num6 ^= 0x6D;
									while (true)
									{
										int num7 = 15;
										int num8 = -11;
										while (true)
										{
											num8 ^= 0x60;
											while (true)
											{
												int num9 = Class24.smethod_0(53);
												int num10 = Class24.smethod_0(52);
												while (true)
												{
													switch (num10 ^ 0x60)
													{
													case -98:
														break;
													default:
														goto IL_002d;
													case -100:
														goto IL_003b;
													case -101:
														goto end_IL_01cb;
													case -99:
														while (true)
														{
															num10 = -3;
															num10 = -99;
														}
													}
													goto IL_0026;
													IL_003b:
													switch (num9)
													{
													case -102:
														break;
													case -100:
														goto IL_0060;
													case -101:
														goto IL_01b9;
													default:
														goto IL_01f1;
													case -99:
														goto end_IL_01f9;
													}
													num9 = -12;
													goto IL_0026;
													IL_01f1:
													num10 = -5;
													num10 = -101;
													break;
													IL_0060:
													switch (num8)
													{
													case -110:
														goto IL_0085;
													case -107:
														goto IL_01b2;
													case -108:
														goto IL_0213;
													case -109:
														goto end_IL_0217;
													}
													num9 = ANTLRPanicException.smethod_0(77);
													goto IL_0026;
													IL_0213:
													num8 = -12;
													goto end_IL_01f9;
													IL_0085:
													switch (num7)
													{
													case 97:
														break;
													case 99:
														goto IL_00ad;
													case 98:
														goto IL_01ac;
													default:
														goto IL_020d;
													case 100:
														goto end_IL_0220;
													}
													num7 = 13;
													goto IL_01b2;
													IL_020d:
													num8 = -13;
													goto end_IL_01f9;
													IL_00ad:
													switch (num6)
													{
													case 107:
														goto IL_00d0;
													case 108:
														goto IL_01a5;
													case 105:
														goto IL_022a;
													case 106:
														goto end_IL_0232;
													}
													num7 = 14;
													goto IL_01b2;
													IL_022a:
													num6 = 4;
													goto end_IL_0220;
													IL_00d0:
													switch (num5)
													{
													case 107:
														break;
													case 108:
														goto IL_0199;
													case 109:
														goto IL_01a2;
													default:
														goto IL_022f;
													case 110:
														goto end_IL_023b;
													}
													switch (num4)
													{
													case 108:
														goto IL_0111;
													case 109:
														goto IL_0194;
													case 107:
														goto IL_0243;
													case 106:
														goto end_IL_024c;
													}
													num5 = 6;
													goto IL_01a5;
													IL_022f:
													num6 = 7;
													goto end_IL_0220;
													IL_01a2:
													num5 = 7;
													goto IL_01a5;
													IL_01b9:
													num8 = Class24.smethod_0(53);
													num9 = -13;
													goto IL_0026;
													IL_0243:
													num4 = 9;
													goto end_IL_023b;
													IL_0111:
													switch (num3)
													{
													case 103:
														break;
													case 102:
														goto IL_018b;
													case 104:
														goto IL_0192;
													default:
														goto IL_0249;
													case 105:
														goto end_IL_0255;
													}
													switch (num2)
													{
													case 110:
														goto IL_014c;
													case 112:
														goto IL_0186;
													case 111:
														goto IL_0261;
													case 109:
														goto end_IL_0263;
													}
													num3 = 6;
													goto IL_0194;
													IL_0249:
													num4 = 8;
													goto end_IL_023b;
													IL_0192:
													num3 = 8;
													goto IL_0194;
													IL_01ac:
													num6 = 6;
													num7 = 8;
													goto IL_01b2;
													IL_0261:
													num2 = 0;
													goto end_IL_0255;
													IL_014c:
													switch (num)
													{
													case -107:
														break;
													case -106:
														goto IL_016e;
													case -105:
														goto IL_0173;
													default:
														goto IL_025d;
													case -104:
														return;
													}
													num = -1;
													goto IL_0186;
													IL_025d:
													num2 = 2;
													goto end_IL_0255;
													IL_0173:
													icontainer_0.Dispose();
													num = Class40.smethod_2(61);
													goto IL_0186;
													IL_016e:
													num = -14;
													goto IL_0186;
													IL_002d:
													num10 = Class40.smethod_2(61);
													continue;
													IL_0186:
													num ^= 0x6A;
													goto IL_018b;
													IL_018b:
													num2 = 1;
													num3 = 9;
													goto IL_0194;
													IL_0026:
													num9 ^= 0x6E;
													goto IL_002d;
													IL_0194:
													num3 ^= 0x60;
													goto IL_0199;
													IL_0199:
													num4 = 14;
													num5 = 4;
													goto IL_01a5;
													IL_01b2:
													num7 ^= 0x6C;
													goto IL_01b9;
													IL_01a5:
													num5 ^= 0x6A;
													goto IL_01ac;
													continue;
													end_IL_01cb:
													break;
												}
												continue;
												end_IL_01f9:
												break;
											}
											continue;
											end_IL_0217:
											break;
										}
										continue;
										end_IL_0220:
										break;
									}
									continue;
									end_IL_0232:
									break;
								}
								continue;
								end_IL_023b:
								break;
							}
							continue;
							end_IL_024c:
							break;
						}
						continue;
						end_IL_0255:
						break;
					}
					continue;
					end_IL_0263:
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
	private void method_6()
	{
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		while (true)
		{
			int num = 26;
			num = 123;
			while (true)
			{
				Delegate26.smethod_0(this, new ComboBox());
				Delegate27.smethod_0(this, new Label());
				Delegate28.smethod_0(this, new TextBox());
				num = 8;
				num = 105;
				while (true)
				{
					Delegate29.smethod_0(this, new Label());
					Delegate30.smethod_0(this, new Button());
					num = 12;
					num = 109;
					while (true)
					{
						Delegate31.smethod_0(this, new PictureBox());
						((ISupportInitialize)Delegate32.smethod_0(this)).BeginInit();
						((Control)this).SuspendLayout();
						num = 25;
						num = 120;
						while (true)
						{
							IL_0697:
							int num2 = ANTLRPanicException.smethod_0(77);
							while (true)
							{
								switch (num2 ^ 0x68)
								{
								case -99:
									((ListControl)Delegate21.smethod_0(this)).set_FormattingEnabled(true);
									num2 = -12;
									num2 = -100;
									goto case -100;
								case -100:
									num2 = -14;
									num2 = -102;
									goto case -102;
								case -102:
									Delegate21.smethod_0(this).get_Items().AddRange(new object[8] { "sense", "pleasure", "designer", "highlight", "concrete", "outside", "accept", "clear" });
									num2 = Class40.smethod_2(58);
									continue;
								case -101:
									num2 = -16;
									num2 = -104;
									goto case -104;
								case -104:
									num = 15;
									num2 = -10;
									num2 = -98;
									break;
								case -98:
									break;
								default:
									goto IL_0697;
								case -103:
									while (true)
									{
										num2 = -15;
										num2 = -103;
									}
								}
								break;
							}
							while (true)
							{
								num ^= 0x61;
								switch (num)
								{
								case 128:
									((Control)Delegate22.smethod_0(this)).set_Size(new Size(500, 22));
									((Control)Delegate22.smethod_0(this)).set_TabIndex(2);
									num = 13;
									num = 108;
									goto case 108;
								case 108:
									Delegate22.smethod_0(this).set_Text("piano");
									goto IL_016a;
								case 127:
									((Control)Delegate35.smethod_0(this)).set_TabIndex(4);
									((ButtonBase)Delegate35.smethod_0(this)).set_Text("coverage");
									((ButtonBase)Delegate35.smethod_0(this)).set_UseVisualStyleBackColor(true);
									num = 14;
									num = 111;
									goto case 111;
								case 111:
									Delegate32.smethod_0(this).set_Image((Image)(object)Delegate36.smethod_0());
									((Control)Delegate32.smethod_0(this)).set_Location(new Point(12, 106));
									num = 24;
									num = 121;
									((Control)Delegate32.smethod_0(this)).set_Name("PictureBox1");
									((Control)Delegate32.smethod_0(this)).set_Size(new Size(500, 421));
									Delegate32.smethod_0(this).set_SizeMode((PictureBoxSizeMode)3);
									num = 10;
									num = 107;
									goto case 107;
								case 107:
									Delegate32.smethod_0(this).set_TabIndex(5);
									Delegate32.smethod_0(this).set_TabStop(false);
									num = 19;
									num = 114;
									goto case 114;
								case 114:
									((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
									goto IL_02be;
								case 126:
									((Control)Delegate34.smethod_0(this)).set_TabIndex(3);
									goto IL_031d;
								case 125:
									Delegate33.smethod_0(this).set_AutoSize(true);
									goto IL_03fb;
								case 124:
									((Control)Delegate34.smethod_0(this)).set_Name("Label2");
									((Control)Delegate34.smethod_0(this)).set_Size(new Size(56, 17));
									num = 31;
									num = 126;
									goto case 126;
								case 121:
									((Control)Delegate32.smethod_0(this)).set_Name("PictureBox1");
									((Control)Delegate32.smethod_0(this)).set_Size(new Size(500, 421));
									Delegate32.smethod_0(this).set_SizeMode((PictureBoxSizeMode)3);
									num = 10;
									num = 107;
									goto case 107;
								case 119:
									((Control)Delegate21.smethod_0(this)).set_TabIndex(0);
									Delegate21.smethod_0(this).set_Text("inquiry");
									num = 28;
									num = 125;
									goto case 125;
								case 118:
									Delegate33.smethod_0(this).set_Text("regulation");
									((Control)Delegate22.smethod_0(this)).set_Location(new Point(12, 78));
									((Control)Delegate22.smethod_0(this)).set_Name("TextBox1");
									num = 225;
									num = 128;
									goto case 128;
								case 116:
									((Control)Delegate33.smethod_0(this)).set_Size(new Size(71, 17));
									((Control)Delegate33.smethod_0(this)).set_TabIndex(1);
									num = 23;
									num = 118;
									Delegate33.smethod_0(this).set_Text("regulation");
									((Control)Delegate22.smethod_0(this)).set_Location(new Point(12, 78));
									((Control)Delegate22.smethod_0(this)).set_Name("TextBox1");
									num = 225;
									num = 128;
									goto case 128;
								case 112:
									((Control)Delegate35.smethod_0(this)).set_Name("Button1");
									((Control)Delegate35.smethod_0(this)).set_Size(new Size(500, 38));
									num = 30;
									num = 127;
									goto case 127;
								case 110:
									break;
								case 120:
									goto end_IL_0623;
								case 109:
									goto end_IL_0697;
								case 105:
									goto end_IL_06a4;
								case 123:
									goto end_IL_06c8;
								default:
									goto end_IL_06e6;
								case 106:
									((Control)this).get_Controls().Add((Control)(object)Delegate34.smethod_0(this));
									((Control)this).get_Controls().Add((Control)(object)Delegate22.smethod_0(this));
									((Control)this).get_Controls().Add((Control)(object)Delegate33.smethod_0(this));
									num = 20;
									num = 117;
									goto case 117;
								case 113:
									((Control)this).get_Controls().Add((Control)(object)Delegate32.smethod_0(this));
									((Control)this).get_Controls().Add((Control)(object)Delegate35.smethod_0(this));
									num = 11;
									num = 106;
									((Control)this).get_Controls().Add((Control)(object)Delegate34.smethod_0(this));
									((Control)this).get_Controls().Add((Control)(object)Delegate22.smethod_0(this));
									((Control)this).get_Controls().Add((Control)(object)Delegate33.smethod_0(this));
									num = 20;
									num = 117;
									goto case 117;
								case 115:
									while (true)
									{
										num = 18;
										num = 115;
									}
								case 117:
									((Control)this).get_Controls().Add((Control)(object)Delegate21.smethod_0(this));
									((Control)this).set_Name("frmCage");
									num = 27;
									num = 122;
									goto case 122;
								case 122:
									((Form)this).set_Text("Sacred");
									((ISupportInitialize)Delegate32.smethod_0(this)).EndInit();
									((Control)this).ResumeLayout(false);
									num = 224;
									num = 129;
									goto case 129;
								case 129:
									((Control)this).PerformLayout();
									return;
								}
								((Control)Delegate21.smethod_0(this)).set_Location(new Point(12, 25));
								while (true)
								{
									int num3 = Class53.smethod_0(103);
									while (true)
									{
										switch (num3 ^ 0x6D)
										{
										case -94:
											num3 = -52;
											num3 = -95;
											goto case -95;
										case -95:
											((Control)Delegate21.smethod_0(this)).set_Name("ComboBox1");
											num3 = Class24.smethod_0(56);
											continue;
										case -99:
											num3 = -14;
											num3 = -97;
											goto case -97;
										case -97:
											((Control)Delegate21.smethod_0(this)).set_Size(new Size(500, 24));
											num3 = -13;
											num3 = -98;
											goto case -98;
										case -98:
											num = 22;
											num3 = -50;
											num3 = -93;
											goto end_IL_05ed;
										case -93:
											goto end_IL_05ed;
										case -96:
											while (true)
											{
												num3 = -51;
												num3 = -96;
											}
										}
										break;
									}
									continue;
									end_IL_05ed:
									break;
								}
								continue;
								IL_02be:
								while (true)
								{
									int num4 = Class24.smethod_0(52);
									while (true)
									{
										switch (num4 ^ 0x6C)
										{
										case -105:
											num4 = -6;
											num4 = -106;
											goto case -106;
										case -106:
											((Form)this).set_ClientSize(new Size(524, 583));
											num4 = Class15.smethod_0(74);
											continue;
										case -107:
											((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
											num4 = -5;
											num4 = -105;
											goto case -105;
										case -110:
											num4 = -7;
											num4 = -107;
											goto case -107;
										case -108:
											num = 16;
											num4 = -12;
											num4 = -104;
											goto end_IL_02be;
										case -104:
											goto end_IL_02be;
										case -109:
											while (true)
											{
												num4 = -1;
												num4 = -109;
											}
										}
										break;
									}
									continue;
									end_IL_02be:
									break;
								}
								continue;
								IL_016a:
								while (true)
								{
									int num5 = Class24.smethod_0(52);
									while (true)
									{
										switch (num5 ^ 0x64)
										{
										case -101:
											num5 = -14;
											num5 = -106;
											goto case -106;
										case -106:
											((Control)Delegate34.smethod_0(this)).set_Location(new Point(9, 5));
											num5 = Class40.smethod_2(61);
											continue;
										case -102:
											num5 = -13;
											num5 = -105;
											goto case -105;
										case -105:
											Delegate34.smethod_0(this).set_AutoSize(true);
											num5 = -1;
											num5 = -101;
											goto case -101;
										case -104:
											num = 29;
											num5 = -8;
											num5 = -100;
											goto end_IL_016a;
										case -100:
											goto end_IL_016a;
										case -103:
											while (true)
											{
												num5 = -3;
												num5 = -103;
											}
										}
										break;
									}
									continue;
									end_IL_016a:
									break;
								}
								continue;
								IL_03fb:
								while (true)
								{
									int num6 = Form0.smethod_0(109);
									while (true)
									{
										switch (num6 ^ 0x68)
										{
										case -95:
											((Control)Delegate33.smethod_0(this)).set_Location(new Point(9, 58));
											num6 = -12;
											num6 = -100;
											goto case -100;
										case -100:
											num6 = -9;
											num6 = -97;
											goto case -97;
										case -97:
											((Control)Delegate33.smethod_0(this)).set_Name("Label1");
											num6 = ANTLRPanicException.smethod_0(77);
											continue;
										case -96:
											num6 = -55;
											num6 = -95;
											goto case -95;
										case -99:
											num = 21;
											num6 = -54;
											num6 = -94;
											goto end_IL_03fb;
										case -94:
											goto end_IL_03fb;
										case -98:
											while (true)
											{
												num6 = -10;
												num6 = -98;
											}
										}
										break;
									}
									continue;
									end_IL_03fb:
									break;
								}
								continue;
								IL_031d:
								while (true)
								{
									int num7 = Form0.smethod_0(90);
									while (true)
									{
										switch (num7 ^ 0x6E)
										{
										case -91:
											num7 = Class53.smethod_0(108);
											continue;
										case -92:
											Delegate34.smethod_0(this).set_Text("happen");
											num7 = -52;
											num7 = -94;
											goto case -94;
										case -94:
											num7 = -51;
											num7 = -93;
											goto case -93;
										case -93:
											((Control)Delegate35.smethod_0(this)).set_Location(new Point(12, 533));
											num7 = -49;
											num7 = -95;
											goto case -95;
										case -95:
											num = 17;
											num7 = -56;
											num7 = -90;
											goto end_IL_031d;
										case -90:
											goto end_IL_031d;
										case -96:
											while (true)
											{
												num7 = -50;
												num7 = -96;
											}
										}
										break;
									}
									continue;
									end_IL_031d:
									break;
								}
								continue;
								end_IL_0623:
								break;
							}
							continue;
							end_IL_0697:
							break;
						}
						continue;
						end_IL_06a4:
						break;
					}
					continue;
					end_IL_06c8:
					break;
				}
				continue;
				end_IL_06e6:
				break;
			}
		}
	}
}
