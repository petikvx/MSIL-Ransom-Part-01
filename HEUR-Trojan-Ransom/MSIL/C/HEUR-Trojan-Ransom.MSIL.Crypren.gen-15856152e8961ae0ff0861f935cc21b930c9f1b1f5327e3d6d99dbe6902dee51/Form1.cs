using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form1 : Form
{
	private Bitmap bitmap_0;

	private Color color_0;

	private Color color_1;

	private Stack stack_0;

	private int int_0;

	private Color[] color_2;

	private IContainer icontainer_0;

	[AccessedThroughProperty("எ\u0bd1\u0bcd\u0be4ஸஎ\u0bbf\u0bc0௯ஏ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private MenuStrip menuStrip_0;

	[CompilerGenerated]
	[AccessedThroughProperty("எ\u0bd1\u0bcd\u0be4ஸஎ\u0bbf\u0bc0௯ஐ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem toolStripMenuItem_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("எ\u0bd1\u0bcd\u0be4ஸஎ\u0bbf\u0bc0௯\u0b91")]
	private ToolStripMenuItem toolStripMenuItem_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("எ\u0bd1\u0bcd\u0be4ஸஎ\u0bbf\u0bc0௯ஒ")]
	private OpenFileDialog openFileDialog_0;

	internal virtual MenuStrip MenuStrip_0
	{
		[CompilerGenerated]
		get
		{
			return menuStrip_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			menuStrip_0 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem_0
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			toolStripMenuItem_0 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem_1
	{
		[CompilerGenerated]
		get
		{
			return toolStripMenuItem_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = method_2;
			ToolStripMenuItem val = toolStripMenuItem_1;
			if (val != null || 1 == 0)
			{
				((ToolStripItem)val).remove_Click(eventHandler);
			}
			toolStripMenuItem_1 = value;
			val = toolStripMenuItem_1;
			if (val != null || 1 == 0)
			{
				((ToolStripItem)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog_0
	{
		[CompilerGenerated]
		get
		{
			return openFileDialog_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler cancelEventHandler = method_3;
			OpenFileDialog val = openFileDialog_0;
			if (val != null || 1 == 0)
			{
				((FileDialog)val).remove_FileOk(cancelEventHandler);
			}
			openFileDialog_0 = value;
			val = openFileDialog_0;
			if (val != null || 1 == 0)
			{
				((FileDialog)val).add_FileOk(cancelEventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		while (true)
		{
			int num = 6;
			int num2 = -3;
			while (true)
			{
				num2 ^= 0x48;
				while (true)
				{
					int num3 = 3;
					int num4 = 15;
					while (true)
					{
						num4 ^= 0x46;
						int num5 = 2;
						int num6 = -6;
						num6 = -76;
						while (true)
						{
							IL_01f6:
							num5 ^= 0x46;
							num6 = Class8.smethod_0(38);
							while (true)
							{
								switch (num6 ^ 0x4E)
								{
								default:
									num6 = Class8.smethod_0(38);
									continue;
								case -78:
									break;
								case -77:
									goto IL_01eb;
								case -76:
									goto IL_01f6;
								case -79:
									while (true)
									{
										num6 = -1;
										num6 = -79;
									}
								}
								break;
							}
							switch (num5)
							{
							case 68:
								goto IL_005e;
							case 69:
								goto IL_01df;
							case 70:
								goto IL_01e6;
							case 71:
								goto end_IL_01f6;
							}
							num6 = -3;
							num6 = -77;
							goto IL_01eb;
							IL_01da:
							num3 ^= 0x4B;
							goto IL_01df;
							IL_01df:
							num4 = 0;
							num5 = 1;
							continue;
							IL_01e6:
							num5 = 0;
							continue;
							IL_005e:
							switch (num4)
							{
							case 70:
								goto IL_007f;
							case 73:
								goto IL_01da;
							case 72:
								goto IL_020f;
							case 71:
								goto end_IL_0212;
							}
							num5 = 3;
							continue;
							IL_020f:
							num4 = 14;
							break;
							IL_007f:
							switch (num3)
							{
							case 70:
								break;
							case 72:
								goto IL_00a5;
							case 71:
								goto IL_01d0;
							default:
								goto IL_020b;
							case 73:
								goto end_IL_0224;
							}
							num3 = 13;
							goto IL_01da;
							IL_020b:
							num4 = 1;
							break;
							IL_00a5:
							switch (num2)
							{
							case -76:
								goto IL_00c6;
							case -75:
								goto IL_01cb;
							case -77:
								goto IL_022b;
							case -78:
								goto end_IL_0238;
							}
							num3 = 12;
							goto IL_01da;
							IL_022b:
							num2 = -5;
							goto end_IL_0224;
							IL_00c6:
							switch (num)
							{
							case 70:
								break;
							case 71:
								goto IL_0118;
							case 72:
								goto IL_012a;
							case 73:
								goto IL_0132;
							case 74:
								goto IL_0147;
							case 75:
								goto IL_015d;
							case 76:
								goto IL_0162;
							case 77:
								goto IL_0172;
							case 78:
								goto IL_0176;
							case 79:
								goto IL_0182;
							case 80:
								goto IL_0191;
							case 81:
								goto IL_019c;
							case 82:
								goto IL_01b2;
							case 83:
								goto IL_01b7;
							default:
								goto IL_0230;
							case 84:
								return;
							}
							num = 10;
							goto IL_01cb;
							IL_0230:
							num2 = Class8.smethod_0(48);
							goto end_IL_0224;
							IL_01b7:
							((Control)this).add_Paint(new PaintEventHandler(Form1_Paint));
							num = 7;
							goto IL_01cb;
							IL_01b2:
							num = 24;
							goto IL_01cb;
							IL_019c:
							((Control)this).add_MouseUp(new MouseEventHandler(Form1_MouseUp));
							num = 1;
							goto IL_01cb;
							IL_0191:
							Delegate20.smethod_0(this);
							num = 30;
							goto IL_01cb;
							IL_0182:
							stack_0 = new Stack();
							num = 2;
							goto IL_01cb;
							IL_0176:
							int_0 = 48;
							num = 5;
							goto IL_01cb;
							IL_0172:
							num = 0;
							goto IL_01cb;
							IL_0162:
							color_0 = Color.Red;
							num = 11;
							goto IL_01cb;
							IL_015d:
							num = 29;
							goto IL_01cb;
							IL_0147:
							((Form)this).add_Load((EventHandler)Form1_Load);
							num = 4;
							goto IL_01cb;
							IL_0132:
							color_2 = new Color[20];
							num = 28;
							goto IL_01cb;
							IL_012a:
							num = 31;
							goto IL_01cb;
							IL_0118:
							color_1 = Color.Black;
							num = 3;
							goto IL_01cb;
							IL_01eb:
							num5 = 2;
							num6 = -6;
							num6 = -76;
							continue;
							IL_01cb:
							num ^= 0x4C;
							goto IL_01d0;
							IL_01d0:
							num2 = Class8.smethod_0(38);
							num3 = 2;
							goto IL_01da;
							continue;
							end_IL_01f6:
							break;
						}
						continue;
						end_IL_0212:
						break;
					}
					continue;
					end_IL_0224:
					break;
				}
				continue;
				end_IL_0238:
				break;
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Class51.smethod_0(6492508, this, sender, e);
	}

	public static void smethod_0()
	{
		Class51.smethod_0(6495136, null, null);
	}

	private void Form1_Paint(object sender, PaintEventArgs e)
	{
		Class51.smethod_0(6488847, this, sender, e);
	}

	public object method_0(int int_1, int int_2, byte[] byte_0, int int_3)
	{
		object result = default(object);
		while (true)
		{
			int num = Class8.smethod_0(47);
			int num2 = Class8.smethod_0(53);
			while (true)
			{
				num2 ^= 0x50;
				while (true)
				{
					int num3 = Class10.smethod_0(85);
					int num4 = -6;
					while (true)
					{
						num4 ^= 0x55;
						while (true)
						{
							int num5 = Class8.smethod_0(41);
							int num6 = 3;
							while (true)
							{
								num6 ^= 0x54;
								while (true)
								{
									int num7 = Class8.smethod_0(50);
									int num8 = 15;
									while (true)
									{
										num8 ^= 0x58;
										int num9 = Class8.smethod_0(38);
										int num10 = -23;
										num10 = -79;
										while (true)
										{
											IL_021d:
											num9 ^= 0x56;
											while (true)
											{
												num10 = GEventArgs2.smethod_0(46);
												while (true)
												{
													switch (num10 ^ 0x58)
													{
													case -82:
														num10 = GEventArgs2.smethod_0(49);
														continue;
													case -81:
														goto end_IL_0030;
													case -80:
														goto IL_020c;
													case -79:
														goto IL_021d;
													}
													break;
												}
												continue;
												end_IL_0030:
												break;
											}
											switch (num9)
											{
											case -86:
												goto IL_0062;
											case -87:
												goto IL_01fc;
											case -85:
												goto IL_0206;
											case -84:
												goto end_IL_021d;
											}
											num10 = -24;
											num10 = -80;
											goto IL_020c;
											IL_01d2:
											num4 = Class8.smethod_0(47);
											num5 = -2;
											goto IL_01df;
											IL_01fc:
											num8 = 13;
											num9 = -6;
											continue;
											IL_0206:
											num9 = -3;
											continue;
											IL_0062:
											switch (num8)
											{
											case 85:
												goto IL_008a;
											case 87:
												goto IL_01f5;
											case 86:
												goto IL_022f;
											case 84:
												goto end_IL_0233;
											}
											num9 = Class8.smethod_0(39);
											continue;
											IL_022f:
											num8 = 14;
											break;
											IL_008a:
											switch (num7)
											{
											case -79:
												break;
											case -78:
												goto IL_01e8;
											case -77:
												goto IL_01ee;
											default:
												goto IL_0229;
											case -76:
												goto end_IL_024d;
											}
											switch (num6)
											{
											case 84:
												goto IL_00d1;
											case 87:
												goto IL_01df;
											case 85:
												goto IL_0261;
											case 86:
												goto end_IL_0264;
											}
											num7 = Class10.smethod_0(84);
											goto IL_01f5;
											IL_0229:
											num8 = 12;
											break;
											IL_01e8:
											num7 = -27;
											goto IL_01f5;
											IL_01ee:
											num6 = 0;
											num7 = -29;
											goto IL_01f5;
											IL_0261:
											num6 = 1;
											goto end_IL_024d;
											IL_00d1:
											switch (num5)
											{
											case -89:
												break;
											case -87:
												goto IL_00fe;
											case -88:
												goto IL_01d2;
											default:
												goto IL_025c;
											case -86:
												goto end_IL_026d;
											}
											num5 = Class8.smethod_0(58);
											goto IL_01df;
											IL_025c:
											num6 = 2;
											goto end_IL_024d;
											IL_00fe:
											switch (num4)
											{
											case -82:
												goto IL_0121;
											case -81:
												goto IL_01cd;
											case -83:
												goto IL_027b;
											case -84:
												goto end_IL_028a;
											}
											num5 = -4;
											goto IL_01df;
											IL_027b:
											num4 = -8;
											goto end_IL_026d;
											IL_0121:
											switch (num3)
											{
											case -82:
												break;
											case -81:
												goto IL_0147;
											case -83:
												goto IL_01c2;
											default:
												goto IL_0281;
											case -80:
												goto end_IL_0293;
											}
											num3 = -32;
											goto IL_01cd;
											IL_0281:
											num4 = Class8.smethod_0(57);
											goto end_IL_026d;
											IL_0147:
											switch (num2)
											{
											case -79:
												goto IL_016a;
											case -78:
												goto IL_01bd;
											case -80:
												goto IL_02a1;
											case -81:
												goto end_IL_02a8;
											}
											num3 = GEventArgs2.smethod_1(68);
											goto IL_01cd;
											IL_02a1:
											num2 = -32;
											goto end_IL_0293;
											IL_016a:
											switch (num)
											{
											case -84:
												break;
											case -83:
												goto IL_01ba;
											default:
												goto IL_02a6;
											case -82:
											case -81:
												return result;
											}
											result = checked(Color.FromArgb(byte_0[int_2 * int_3 + int_1 * 3 + 2], byte_0[int_2 * int_3 + int_1 * 3 + 1], byte_0[int_2 * int_3 + int_1 * 3]));
											num = -7;
											goto IL_01bd;
											IL_02a6:
											num2 = -1;
											goto end_IL_0293;
											IL_01ba:
											num = -6;
											goto IL_01bd;
											IL_020c:
											num9 = Class8.smethod_0(38);
											num10 = -23;
											num10 = -79;
											continue;
											IL_01bd:
											num ^= 0x57;
											goto IL_01c2;
											IL_01c2:
											num2 = Class10.smethod_0(85);
											num3 = -2;
											goto IL_01cd;
											IL_01f5:
											num7 ^= 0x57;
											goto IL_01fc;
											IL_01df:
											num5 ^= 0x54;
											goto IL_01ee;
											IL_01cd:
											num3 ^= 0x4E;
											goto IL_01d2;
											continue;
											end_IL_021d:
											break;
										}
										continue;
										end_IL_0233:
										break;
									}
									continue;
									end_IL_024d:
									break;
								}
								continue;
								end_IL_0264:
								break;
							}
							continue;
							end_IL_026d:
							break;
						}
						continue;
						end_IL_028a:
						break;
					}
					continue;
					end_IL_0293:
					break;
				}
				continue;
				end_IL_02a8:
				break;
			}
		}
	}

	private void method_1(int int_1, int int_2, Color color_3)
	{
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		if (color_3.ToArgb() == color_0.ToArgb() || 1 == 0)
		{
			return;
		}
		checked
		{
			byte[] array = default(byte[]);
			int stride = default(int);
			BitmapData val = default(BitmapData);
			IntPtr scan = default(IntPtr);
			int num10 = default(int);
			Rectangle rectangle = default(Rectangle);
			while (true)
			{
				int num = 1;
				int num2 = 12;
				while (true)
				{
					num2 ^= 0x54;
					while (true)
					{
						int num3 = 24;
						int num4 = -28;
						while (true)
						{
							num4 ^= 0x4F;
							while (true)
							{
								int num5 = Class10.smethod_0(85);
								int num6 = 1;
								while (true)
								{
									num6 ^= 0x58;
									int num7 = Class8.smethod_0(48);
									while (true)
									{
										switch (num7 ^ 0x53)
										{
										case -87:
											break;
										default:
											num7 = Class8.smethod_0(48);
											continue;
										case -86:
											num6 = 15;
											num7 = -8;
											num7 = -85;
											goto end_IL_0052;
										case -85:
											goto end_IL_0052;
										case -88:
											while (true)
											{
												num7 = -5;
												num7 = -88;
											}
										}
										switch (num6)
										{
										case 87:
											goto IL_0075;
										case 88:
											goto IL_023d;
										case 89:
											goto IL_0242;
										case 86:
											goto end_IL_0263;
										}
										num7 = Class8.smethod_0(57);
										continue;
										IL_023d:
										num6 = 0;
										break;
										continue;
										end_IL_0052:
										break;
									}
									continue;
									IL_0228:
									num4 = Class8.smethod_0(51);
									num5 = -25;
									goto IL_0242;
									IL_0075:
									switch (num5)
									{
									case -78:
										goto IL_0098;
									case -79:
										goto IL_0228;
									case -77:
										goto IL_0237;
									case -76:
										goto end_IL_0278;
									}
									num6 = 14;
									continue;
									IL_0237:
									num5 = -32;
									goto IL_0242;
									IL_0098:
									switch (num4)
									{
									case -88:
										goto IL_00bb;
									case -85:
										goto IL_0221;
									case -87:
										goto IL_028c;
									case -86:
										goto end_IL_0290;
									}
									num5 = -30;
									goto IL_0242;
									IL_028c:
									num4 = -26;
									goto end_IL_0278;
									IL_00bb:
									switch (num3)
									{
									case 78:
										break;
									case 79:
										goto IL_00e3;
									case 80:
										goto IL_021b;
									default:
										goto IL_0286;
									case 81:
										goto end_IL_0299;
									}
									num3 = 25;
									goto IL_0221;
									IL_0286:
									num4 = -27;
									goto end_IL_0278;
									IL_00e3:
									switch (num2)
									{
									case 86:
										goto IL_0105;
									case 88:
										goto IL_0214;
									case 85:
										goto IL_02a3;
									case 87:
										goto end_IL_02ab;
									}
									num3 = 7;
									goto IL_0221;
									IL_02a3:
									num2 = 1;
									goto end_IL_0299;
									IL_0105:
									switch (num)
									{
									case 83:
										break;
									case 84:
										goto IL_014d;
									case 85:
										goto IL_0162;
									case 86:
										goto IL_018a;
									case 87:
										goto IL_01a7;
									case 88:
										goto IL_01c4;
									case 89:
										goto IL_01ca;
									case 90:
										goto IL_01d0;
									case 91:
										goto IL_01df;
									case 92:
										goto IL_01fd;
									case 93:
										goto IL_0209;
									default:
										goto IL_02a8;
									case 94:
										while (stack_0.Count > 0)
										{
											object objectValue = RuntimeHelpers.GetObjectValue(stack_0.Pop());
											int_1 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null));
											int_2 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null));
											object obj = Delegate25.smethod_0(this, int_1, int_2, array, stride);
											if ((((obj != null) ? ((Color)obj) : default(Color)).ToArgb() != color_3.ToArgb()) ? true : false)
											{
												continue;
											}
											int num8 = int_1;
											int num9 = int_1;
											object obj2 = Delegate25.smethod_0(this, num8, int_2, array, stride);
											Color color = ((obj2 != null) ? ((Color)obj2) : default(Color));
											while (((num8 > 0) & (color.ToArgb() == color_3.ToArgb())) ? true : false)
											{
												num8--;
												object obj3 = Delegate25.smethod_0(this, num8, int_2, array, stride);
												color = ((obj3 != null) ? ((Color)obj3) : default(Color));
											}
											object obj4 = Delegate25.smethod_0(this, num9, int_2, array, stride);
											color = ((obj4 != null) ? ((Color)obj4) : default(Color));
											while (((num9 < ((Image)bitmap_0).get_Width() - 1) & (color.ToArgb() == color_3.ToArgb())) ? true : false)
											{
												num9++;
												object obj5 = Delegate25.smethod_0(this, num9, int_2, array, stride);
												color = ((obj5 != null) ? ((Color)obj5) : default(Color));
											}
											int_1 = num8 + 1;
											while ((int_1 < num9) ? true : false)
											{
												array[int_2 * val.get_Stride() + int_1 * 3 + 2] = color_0.R;
												array[int_2 * val.get_Stride() + int_1 * 3 + 1] = color_0.G;
												array[int_2 * val.get_Stride() + int_1 * 3] = color_0.B;
												if (int_2 - 1 > 0 || 1 == 0)
												{
													object obj6 = Delegate25.smethod_0(this, int_1, int_2 - 1, array, stride);
													if (((obj6 != null) ? ((Color)obj6) : default(Color)).ToArgb() == color_3.ToArgb() || 1 == 0)
													{
														stack_0.Push(new Point(int_1, int_2 - 1));
													}
												}
												if (int_2 + 2 < ((Image)bitmap_0).get_Height() || 1 == 0)
												{
													object obj7 = Delegate25.smethod_0(this, int_1, int_2 + 1, array, stride);
													if (((obj7 != null) ? ((Color)obj7) : default(Color)).ToArgb() == color_3.ToArgb() || 1 == 0)
													{
														stack_0.Push(new Point(int_1, int_2 + 1));
													}
												}
												int_1++;
											}
										}
										Marshal.Copy(array, 0, scan, num10);
										bitmap_0.UnlockBits(val);
										return;
									}
									num = 9;
									goto IL_0214;
									IL_02a8:
									num2 = 3;
									goto end_IL_0299;
									IL_0209:
									stride = val.get_Stride();
									num = 3;
									goto IL_0214;
									IL_01fd:
									scan = val.get_Scan0();
									num = 2;
									goto IL_0214;
									IL_01df:
									val = bitmap_0.LockBits(rectangle, (ImageLockMode)3, ((Image)bitmap_0).get_PixelFormat());
									num = 8;
									goto IL_0214;
									IL_01d0:
									Marshal.Copy(scan, array, 0, num10);
									num = 7;
									goto IL_0214;
									IL_01ca:
									num = 10;
									goto IL_0214;
									IL_01c4:
									num = 12;
									goto IL_0214;
									IL_01a7:
									stack_0.Push(new Point(int_1, int_2));
									num = 13;
									goto IL_0214;
									IL_018a:
									num10 = Math.Abs(val.get_Stride()) * ((Image)bitmap_0).get_Height();
									num = 0;
									goto IL_0214;
									IL_0162:
									rectangle = new Rectangle(0, 0, ((Image)bitmap_0).get_Width(), ((Image)bitmap_0).get_Height());
									num = 15;
									goto IL_0214;
									IL_014d:
									array = new byte[num10 - 1 + 1];
									num = 14;
									goto IL_0214;
									IL_0221:
									num3 ^= 0x57;
									goto IL_0228;
									IL_0214:
									num ^= 0x54;
									goto IL_021b;
									IL_021b:
									num2 = 2;
									num3 = 6;
									goto IL_0221;
									IL_0242:
									num5 ^= 0x53;
									num6 = 15;
									num7 = -8;
									num7 = -85;
									continue;
									end_IL_0263:
									break;
								}
								continue;
								end_IL_0278:
								break;
							}
							continue;
							end_IL_0290:
							break;
						}
						continue;
						end_IL_0299:
						break;
					}
					continue;
					end_IL_02ab:
					break;
				}
			}
		}
	}

	private void Form1_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		checked
		{
			int x = default(int);
			int num9 = default(int);
			bool flag = default(bool);
			Graphics val2 = default(Graphics);
			while (true)
			{
				int num = GEventArgs2.smethod_1(52);
				int num2 = 29;
				while (true)
				{
					num2 ^= 0x4D;
					while (true)
					{
						int num3 = GEventArgs2.smethod_1(56);
						int num4 = 31;
						while (true)
						{
							num4 ^= 0x4F;
							while (true)
							{
								int num5 = 30;
								int num6 = 24;
								while (true)
								{
									num6 ^= 0x4E;
									int num7 = 3;
									int num8 = -7;
									num8 = -74;
									while (true)
									{
										num7 ^= 0x51;
										while (true)
										{
											num8 = Class8.smethod_0(38);
											while (true)
											{
												switch (num8 ^ 0x4F)
												{
												case -77:
													break;
												default:
													goto end_IL_0029;
												case -75:
													num7 = 3;
													num8 = -7;
													num8 = -74;
													goto end_IL_004a;
												case -74:
													goto end_IL_004a;
												case -76:
													while (true)
													{
														num8 = -5;
														num8 = -76;
													}
												}
												switch (num7)
												{
												case 82:
													goto IL_0055;
												case 83:
													goto IL_01da;
												case 84:
													goto IL_01e3;
												case 85:
													goto end_IL_01f3;
												}
												num8 = Class8.smethod_0(48);
												continue;
												IL_01e3:
												num7 = 5;
												goto end_IL_004a;
												continue;
												end_IL_0029:
												break;
											}
											continue;
											end_IL_004a:
											break;
										}
										continue;
										IL_01da:
										num6 = 26;
										num7 = 4;
										continue;
										IL_0055:
										switch (num6)
										{
										case 84:
											goto IL_0077;
										case 86:
											goto IL_01d3;
										case 83:
											goto IL_01ff;
										case 85:
											goto end_IL_0209;
										}
										num7 = 2;
										continue;
										IL_01ff:
										num6 = 29;
										break;
										IL_0077:
										switch (num5)
										{
										case 81:
											break;
										case 83:
											goto IL_009f;
										case 82:
											goto IL_01cc;
										default:
											goto IL_0205;
										case 84:
											goto end_IL_021d;
										}
										num5 = 28;
										goto IL_01d3;
										IL_0205:
										num6 = 27;
										break;
										IL_009f:
										switch (num4)
										{
										case 77:
											goto IL_00c2;
										case 80:
											goto IL_01c5;
										case 78:
											goto IL_022c;
										case 79:
											goto end_IL_022f;
										}
										num5 = 31;
										goto IL_01d3;
										IL_022c:
										num4 = 1;
										goto end_IL_021d;
										IL_00c2:
										switch (num3)
										{
										case -77:
											break;
										case -76:
											goto IL_01b8;
										case -75:
											goto IL_01be;
										default:
											goto IL_0227;
										case -74:
											goto end_IL_0238;
										}
										switch (num2)
										{
										case 79:
											goto IL_0104;
										case 80:
											goto IL_01af;
										case 78:
											goto IL_0247;
										case 77:
											goto end_IL_024f;
										}
										num3 = -19;
										goto IL_01c5;
										IL_0227:
										num4 = 0;
										goto end_IL_021d;
										IL_01b8:
										num3 = -20;
										goto IL_01c5;
										IL_01af:
										num ^= 0x59;
										goto IL_01be;
										IL_0247:
										num2 = 3;
										goto end_IL_0238;
										IL_0104:
										switch (num)
										{
										case -84:
											break;
										case -83:
											goto IL_013c;
										case -82:
											goto IL_0174;
										case -81:
											goto IL_0180;
										case -80:
											goto IL_0199;
										case -79:
											goto IL_01ab;
										default:
											goto IL_024c;
										case -78:
											goto IL_0270;
										}
										((Control)this).CreateGraphics();
										num = -12;
										goto IL_01af;
										IL_024c:
										num2 = 0;
										goto end_IL_0238;
										IL_01ab:
										num = -24;
										goto IL_01af;
										IL_0199:
										x = e.get_X();
										num = GEventArgs2.smethod_0(49);
										goto IL_01af;
										IL_0180:
										num9 = e.get_Y() - ((Control)Delegate24.smethod_0(this)).get_Height();
										num = -11;
										goto IL_01af;
										IL_0174:
										if (flag)
										{
											num = -21;
											goto IL_01af;
										}
										if (true)
										{
											if (((x < ((Image)bitmap_0).get_Width()) & (num9 < ((Image)bitmap_0).get_Height())) || 1 == 0)
											{
												Color pixel = bitmap_0.GetPixel(x, num9);
												if (pixel.ToArgb() != Color.Black.ToArgb() || 1 == 0)
												{
													Delegate26.smethod_0(this, x, num9, pixel);
													((Control)this).Invalidate();
												}
											}
											return;
										}
										goto IL_0270;
										IL_01c5:
										num3 ^= 0x58;
										goto IL_01cc;
										IL_01cc:
										num4 = 2;
										num5 = 25;
										goto IL_01d3;
										IL_01be:
										num2 = 2;
										num3 = -18;
										goto IL_01c5;
										IL_01d3:
										num5 ^= 0x4D;
										goto IL_01da;
										IL_013c:
										flag = (x > ((Image)bitmap_0).get_Width()) & ((double)num9 < (double)int_0 * ((double)color_2.Count() / 2.0));
										num = -9;
										goto IL_01af;
										continue;
										end_IL_01f3:
										break;
									}
									continue;
									end_IL_0209:
									break;
								}
								continue;
								end_IL_021d:
								break;
							}
							continue;
							end_IL_022f:
							break;
						}
						continue;
						end_IL_0238:
						break;
					}
					continue;
					IL_0270:
					Bitmap val = new Bitmap(1, 1);
					int num10;
					while (true)
					{
						num10 = GEventArgs2.smethod_1(52);
						switch (num10 ^ 0x58)
						{
						default:
							continue;
						case -79:
							val2 = Graphics.FromImage((Image)(object)val);
							num10 = -20;
							num10 = -76;
							goto case -76;
						case -78:
							while (true)
							{
								num10 = -22;
								num10 = -78;
							}
						case -76:
							val2.CopyFromScreen(((Control)this).PointToScreen(e.get_Location()), Point.Empty, ((Image)val).get_Size());
							num10 = -11;
							num10 = -83;
							goto case -83;
						case -83:
							num10 = -24;
							num10 = -80;
							goto case -80;
						case -80:
							color_0 = val.GetPixel(0, 0);
							num10 = -21;
							num10 = -77;
							goto case -77;
						case -77:
							((Control)this).Invalidate(new Rectangle(((Image)bitmap_0).get_Width(), ((Control)Delegate24.smethod_0(this)).get_Height(), int_0 * 2, (int)Math.Round((double)(int_0 * color_2.Count()) / 2.0)));
							num10 = -9;
							num10 = -81;
							goto case -81;
						case -81:
							num10 = -10;
							num10 = -82;
							break;
						case -82:
							break;
						case -75:
							return;
						}
						break;
					}
					num10 = -19;
					num10 = -75;
					return;
					continue;
					end_IL_024f:
					break;
				}
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)Delegate27.smethod_0(this)).ShowDialog();
	}

	private void method_3(object sender, CancelEventArgs e)
	{
		Class51.smethod_0(6490349, this, sender, e);
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
				int num = 0;
				int num2 = -3;
				while (true)
				{
					num2 ^= 0x53;
					while (true)
					{
						int num3 = Class10.smethod_0(84);
						int num4 = 6;
						while (true)
						{
							num4 ^= 0x56;
							while (true)
							{
								int num5 = Class8.smethod_0(38);
								int num6 = Class8.smethod_0(51);
								while (true)
								{
									num6 ^= 0x55;
									int num7 = Class8.smethod_0(37);
									int num8 = -26;
									num8 = -80;
									while (true)
									{
										num7 ^= 0x58;
										num8 = GEventArgs2.smethod_0(43);
										while (true)
										{
											switch (num8 ^ 0x56)
											{
											case -82:
												break;
											default:
												num8 = GEventArgs2.smethod_0(43);
												continue;
											case -81:
												num7 = Class8.smethod_0(37);
												num8 = -26;
												num8 = -80;
												goto end_IL_0054;
											case -80:
												goto end_IL_0054;
											case -83:
												while (true)
												{
													num8 = -5;
													num8 = -83;
												}
											}
											switch (num7)
											{
											case -89:
												goto IL_0077;
											case -88:
												goto IL_007f;
											case -87:
												goto IL_018b;
											case -86:
												goto end_IL_01ab;
											}
											num8 = Class8.smethod_0(57);
											continue;
											IL_0077:
											num7 = -1;
											break;
											continue;
											end_IL_0054:
											break;
										}
										continue;
										IL_0172:
										num3 ^= 0x4F;
										goto IL_0177;
										IL_007f:
										switch (num6)
										{
										case -79:
											goto IL_00a2;
										case -78:
											goto IL_0184;
										case -80:
											goto IL_01c0;
										case -81:
											goto end_IL_01ca;
										}
										num7 = -15;
										continue;
										IL_01c0:
										num6 = -27;
										break;
										IL_00a2:
										switch (num5)
										{
										case -87:
											break;
										case -86:
											goto IL_00c9;
										case -85:
											goto IL_0177;
										default:
											goto IL_01c6;
										case -84:
											goto end_IL_01e4;
										}
										num5 = -1;
										goto IL_0184;
										IL_01c6:
										num6 = -6;
										break;
										IL_00c9:
										switch (num4)
										{
										case 79:
											goto IL_00ec;
										case 80:
											goto IL_0172;
										case 77:
											goto IL_01f8;
										case 78:
											goto end_IL_0202;
										}
										num5 = -3;
										goto IL_0184;
										IL_01f8:
										num4 = 27;
										goto end_IL_01e4;
										IL_00ec:
										switch (num3)
										{
										case -85:
											break;
										case -84:
											goto IL_0162;
										case -83:
											goto IL_016f;
										default:
											goto IL_01fe;
										case -82:
											goto end_IL_020b;
										}
										switch (num2)
										{
										case -83:
											goto IL_0128;
										case -82:
											goto IL_015d;
										case -85:
											goto IL_0218;
										case -84:
											goto end_IL_021f;
										}
										num3 = -29;
										goto IL_0172;
										IL_01fe:
										num4 = 24;
										goto end_IL_01e4;
										IL_016f:
										num3 = -30;
										goto IL_0172;
										IL_0184:
										num5 ^= 0x56;
										goto IL_018b;
										IL_0218:
										num2 = -8;
										goto end_IL_020b;
										IL_0128:
										switch (num)
										{
										case 86:
											break;
										case 87:
											goto IL_014b;
										case 88:
											goto IL_014f;
										default:
											goto IL_021d;
										case 89:
											return;
										}
										num = 14;
										goto IL_015d;
										IL_021d:
										num2 = -1;
										goto end_IL_020b;
										IL_014f:
										icontainer_0.Dispose();
										num = 15;
										goto IL_015d;
										IL_014b:
										num = 1;
										goto IL_015d;
										IL_0177:
										num4 = 25;
										num5 = Class8.smethod_0(48);
										goto IL_0184;
										IL_015d:
										num ^= 0x58;
										goto IL_0162;
										IL_0162:
										num2 = Class8.smethod_0(42);
										num3 = -31;
										goto IL_0172;
										IL_018b:
										num6 = Class10.smethod_0(84);
										num7 = -14;
										continue;
										end_IL_01ab:
										break;
									}
									continue;
									end_IL_01ca:
									break;
								}
								continue;
								end_IL_01e4:
								break;
							}
							continue;
							end_IL_0202:
							break;
						}
						continue;
						end_IL_020b:
						break;
					}
					continue;
					end_IL_021f:
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
	private void method_4()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		while (true)
		{
			int num = Class8.smethod_0(42);
			while (true)
			{
				num ^= 0x4F;
				switch (num)
				{
				case -61:
					Delegate31.smethod_0(this, new OpenFileDialog());
					((Control)Delegate24.smethod_0(this)).SuspendLayout();
					num = GEventArgs2.smethod_0(40);
					continue;
				case -62:
					Delegate30.smethod_0(this, new ToolStripMenuItem());
					num = -116;
					num = -61;
					goto case -61;
				case -66:
					((Control)Delegate24.smethod_0(this)).set_Text("MenuStrip1");
					num = -5;
					num = -76;
					((ToolStripDropDownItem)Delegate32.smethod_0(this)).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Delegate33.smethod_0(this) });
					((ToolStripItem)Delegate32.smethod_0(this)).set_Name("FileToolStripMenuItem");
					num = -1;
					num = -80;
					goto case -80;
				case -80:
					while (true)
					{
						int num4 = GEventArgs2.smethod_1(68);
						while (true)
						{
							switch (num4 ^ 0x4F)
							{
							case -84:
								((ToolStripItem)Delegate32.smethod_0(this)).set_Size(new Size(37, 20));
								num4 = -27;
								num4 = -86;
								goto case -86;
							case -86:
								num4 = Class8.smethod_0(50);
								continue;
							case -87:
								num = -16;
								num4 = -30;
								num4 = -83;
								goto end_IL_00d2;
							case -83:
								goto end_IL_00d2;
							case -85:
								while (true)
								{
									num4 = -28;
									num4 = -85;
								}
							}
							break;
						}
						continue;
						end_IL_00d2:
						break;
					}
					continue;
				case -68:
					((ToolStrip)Delegate24.smethod_0(this)).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Delegate32.smethod_0(this) });
					while (true)
					{
						int num3 = Class8.smethod_0(50);
						while (true)
						{
							switch (num3 ^ 0x52)
							{
							case -76:
								num3 = -32;
								num3 = -78;
								goto case -78;
							case -78:
								((Control)Delegate24.smethod_0(this)).set_Location(new Point(0, 0));
								num3 = -31;
								num3 = -77;
								goto case -77;
							case -77:
								num = -8;
								num3 = Class8.smethod_0(51);
								continue;
							case -75:
								goto end_IL_0159;
							case -79:
								while (true)
								{
									num3 = -29;
									num3 = -79;
								}
							}
							break;
						}
						continue;
						end_IL_0159:
						break;
					}
					continue;
				case -70:
					((Control)this).SuspendLayout();
					num = -13;
					num = -68;
					goto case -68;
				case -73:
					((Control)Delegate24.smethod_0(this)).set_Name("MenuStrip1");
					num = -6;
					num = -75;
					goto case -75;
				case -75:
					((Control)Delegate24.smethod_0(this)).set_Size(new Size(284, 24));
					while (true)
					{
						int num2 = Class8.smethod_0(41);
						while (true)
						{
							switch (num2 ^ 0x51)
							{
							case -81:
								num = -15;
								num2 = Class10.smethod_0(85);
								continue;
							case -83:
								((Control)Delegate24.smethod_0(this)).set_TabIndex(0);
								num2 = -2;
								num2 = -81;
								goto case -81;
							case -84:
								num2 = -4;
								num2 = -83;
								goto case -83;
							case -80:
								goto end_IL_01ee;
							case -82:
								while (true)
								{
									num2 = -1;
									num2 = -82;
								}
							}
							break;
						}
						continue;
						end_IL_01ee:
						break;
					}
					continue;
				case -76:
					((ToolStripDropDownItem)Delegate32.smethod_0(this)).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Delegate33.smethod_0(this) });
					((ToolStripItem)Delegate32.smethod_0(this)).set_Name("FileToolStripMenuItem");
					num = -1;
					num = -80;
					goto case -80;
				case -79:
					Delegate28.smethod_0(this, new MenuStrip());
					Delegate29.smethod_0(this, new ToolStripMenuItem());
					num = -115;
					num = -62;
					goto case -62;
				case -77:
					((Control)this).set_DoubleBuffered(true);
					((Form)this).set_MainMenuStrip(Delegate24.smethod_0(this));
					num = -12;
					num = -69;
					goto case -69;
				case -72:
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					((Form)this).set_ClientSize(new Size(284, 261));
					num = -31;
					num = -82;
					goto case -82;
				case -67:
					while (true)
					{
						num = -14;
						num = -67;
					}
				case -65:
					((ToolStripItem)Delegate32.smethod_0(this)).set_Text("File");
					((ToolStripItem)Delegate33.smethod_0(this)).set_Name("OpenToolStripMenuItem");
					num = -10;
					num = -71;
					goto case -71;
				case -71:
					((ToolStripItem)Delegate33.smethod_0(this)).set_Size(new Size(152, 22));
					num = -114;
					num = -63;
					goto case -63;
				case -63:
					((ToolStripItem)Delegate33.smethod_0(this)).set_Text("Open...");
					((FileDialog)Delegate27.smethod_0(this)).set_Filter("24-bit Bitmap (*.bmp)|*.bmp");
					num = -3;
					num = -78;
					goto case -78;
				case -78:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					num = -9;
					num = -72;
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					((Form)this).set_ClientSize(new Size(284, 261));
					num = -31;
					num = -82;
					goto case -82;
				case -82:
					((Control)this).get_Controls().Add((Control)(object)Delegate24.smethod_0(this));
					num = -4;
					num = -77;
					((Control)this).set_DoubleBuffered(true);
					((Form)this).set_MainMenuStrip(Delegate24.smethod_0(this));
					num = -12;
					num = -69;
					goto case -69;
				case -69:
					((Control)this).set_Name("Form1");
					num = -113;
					num = -64;
					goto case -64;
				case -64:
					((Form)this).set_Text("Form1");
					((Control)Delegate24.smethod_0(this)).ResumeLayout(false);
					num = -7;
					num = -74;
					goto case -74;
				case -74:
					((Control)Delegate24.smethod_0(this)).PerformLayout();
					num = -32;
					num = -81;
					goto case -81;
				case -81:
					((Control)this).ResumeLayout(false);
					((Control)this).PerformLayout();
					num = -117;
					num = -60;
					return;
				case -60:
					return;
				}
				break;
			}
		}
	}
}
