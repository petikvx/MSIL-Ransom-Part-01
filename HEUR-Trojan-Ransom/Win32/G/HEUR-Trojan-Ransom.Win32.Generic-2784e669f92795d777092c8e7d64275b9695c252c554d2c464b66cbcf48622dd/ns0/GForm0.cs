using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DesignerGenerated]
public class GForm0 : Form
{
	private object object_0;

	private object object_1;

	private object object_2;

	private int int_0;

	private int int_1;

	private int int_2;

	private bool bool_0;

	private int int_3;

	private int int_4;

	private object object_3;

	private bool bool_1;

	private int int_5;

	private int int_6;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private int int_17;

	private object object_4;

	private object object_5;

	private object object_6;

	private object object_7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimerLoop")]
	[CompilerGenerated]
	private Timer timer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog saveFileDialog_0;

	[CompilerGenerated]
	[AccessedThroughProperty("OpenFileDialog1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OpenFileDialog openFileDialog_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Algorythm")]
	private ComboBox comboBox_0;

	[AccessedThroughProperty("RenderSpeed")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TrackBar trackBar_0;

	[CompilerGenerated]
	[AccessedThroughProperty("btn_Save")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[AccessedThroughProperty("btn_Load")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button button_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar progressBar_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn_SaveState")]
	private Button button_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn_LoadState")]
	[CompilerGenerated]
	private Button button_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("ShowGrid")]
	private CheckBox checkBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MapW")]
	[CompilerGenerated]
	private TrackBar trackBar_1;

	[AccessedThroughProperty("lbl_MapW")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("MapH")]
	private TrackBar trackBar_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lbl_MapH")]
	[CompilerGenerated]
	private Label label_1;

	[AccessedThroughProperty("Label1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label label_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("BottomPanel")]
	private Panel panel_0;

	internal virtual OpenFileDialog OpenFileDialog1
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

	internal virtual ComboBox Algorythm
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
			comboBox_0 = value;
		}
	}

	internal virtual TrackBar RenderSpeed
	{
		[CompilerGenerated]
		get
		{
			return trackBar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			trackBar_0 = value;
		}
	}

	internal virtual Button btn_Save
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
			smethod_5();
			if (smethod_4())
			{
				goto IL_0058;
			}
			goto IL_0078;
			IL_0078:
			Button val = default(Button);
			EventHandler object_ = default(EventHandler);
			smethod_150(val, object_);
			goto IL_006f;
			IL_006f:
			while (true)
			{
				IL_006f_2:
				button_0 = value;
				while (true)
				{
					val = button_0;
					if (!smethod_4())
					{
						return;
					}
					switch (5)
					{
					case 0:
					case 7:
						goto end_IL_0012;
					case 9:
						goto IL_0065;
					case 6:
						goto IL_006c;
					case 4:
						goto IL_006f_2;
					case 3:
					case 8:
						goto IL_0078;
					case 5:
						if (val == null)
						{
							return;
						}
						goto case 2;
					case 2:
						smethod_151(val, object_);
						return;
					case 10:
						return;
					}
					continue;
					end_IL_0012:
					break;
				}
				break;
			}
			goto IL_0058;
			IL_0065:
			val = button_0;
			goto IL_006c;
			IL_0058:
			object_ = method_14;
			goto IL_0065;
			IL_006c:
			if (val == null)
			{
				goto IL_006f;
			}
			goto IL_0078;
		}
	}

	internal virtual Button btn_Load
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
			Button val = default(Button);
			while (true)
			{
				EventHandler object_ = method_15;
				_ = 0;
				if (!smethod_4())
				{
					goto IL_007f;
				}
				goto IL_0019;
				IL_0019:
				val = button_1;
				goto IL_0020;
				IL_0020:
				if (val != null)
				{
					goto IL_0039;
				}
				goto IL_0040;
				IL_0040:
				button_1 = value;
				goto IL_0025;
				IL_0025:
				val = button_1;
				int num = 0;
				if (smethod_5())
				{
					goto IL_0039;
				}
				goto IL_0049;
				IL_0049:
				switch (num)
				{
				case 2:
					break;
				case 1:
				case 9:
					goto IL_0019;
				case 3:
					goto IL_0020;
				default:
					goto IL_0025;
				case 6:
					goto IL_0039;
				case 5:
					goto IL_0040;
				case 0:
					if (val == null)
					{
						return;
					}
					goto IL_007f;
				case 4:
				case 7:
					goto IL_007f;
				case 10:
					return;
				}
				continue;
				IL_007f:
				smethod_151(val, object_);
				num = 10;
				if (!smethod_4())
				{
					goto IL_0040;
				}
				goto IL_0049;
				IL_0039:
				smethod_150(val, object_);
				goto IL_0040;
			}
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[CompilerGenerated]
		get
		{
			return progressBar_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			progressBar_0 = value;
		}
	}

	internal virtual Button btn_SaveState
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
			EventHandler object_ = default(EventHandler);
			Button val = default(Button);
			if (!smethod_5())
			{
				switch (4)
				{
				case 4:
					object_ = method_16;
					goto case 1;
				case 1:
					val = button_2;
					goto case 7;
				case 7:
					if (val == null)
					{
						goto IL_0072;
					}
					smethod_5();
					if (smethod_4())
					{
						break;
					}
					goto IL_0080;
				case 2:
				case 3:
					break;
				case 9:
					goto IL_0072;
				default:
					goto IL_0079;
				case 0:
				case 6:
					goto IL_0080;
				case 5:
					goto IL_0083;
				case 10:
					return;
				}
			}
			smethod_150(val, object_);
			goto IL_0072;
			IL_0072:
			button_2 = value;
			goto IL_0079;
			IL_0083:
			smethod_151(val, object_);
			return;
			IL_0080:
			if (val == null)
			{
				return;
			}
			goto IL_0083;
			IL_0079:
			val = button_2;
			goto IL_0080;
		}
	}

	internal virtual Button btn_LoadState
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
			smethod_4();
			if (smethod_5())
			{
				int num = 8;
				if (!smethod_4())
				{
					goto IL_006c;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 4;
						if (smethod_4())
						{
							continue;
						}
						break;
					case 0:
					case 2:
						break;
					case 1:
					case 8:
						goto IL_006c;
					case 7:
						goto IL_0073;
					case 3:
						goto IL_0076;
					case 6:
						goto IL_007d;
					case 4:
						goto IL_0084;
					case 5:
						goto IL_008b;
					case 9:
						goto IL_008e;
					case 10:
						return;
					}
					break;
				}
			}
			EventHandler object_ = method_17;
			goto IL_006c;
			IL_0084:
			Button val = button_3;
			goto IL_008b;
			IL_008b:
			if (val == null)
			{
				return;
			}
			goto IL_008e;
			IL_008e:
			smethod_151(val, object_);
			return;
			IL_007d:
			button_3 = value;
			goto IL_0084;
			IL_006c:
			val = button_3;
			goto IL_0073;
			IL_0073:
			if (val != null)
			{
				goto IL_0076;
			}
			goto IL_007d;
			IL_0076:
			smethod_150(val, object_);
			goto IL_007d;
		}
	}

	internal virtual CheckBox ShowGrid
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
			checkBox_0 = value;
		}
	}

	internal virtual TrackBar MapW
	{
		[CompilerGenerated]
		get
		{
			return trackBar_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			trackBar_1 = value;
		}
	}

	internal virtual Label lbl_MapW
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

	internal virtual TrackBar MapH
	{
		[CompilerGenerated]
		get
		{
			return trackBar_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			trackBar_2 = value;
		}
	}

	internal virtual Label lbl_MapH
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

	internal virtual Label Label1
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

	internal virtual Panel BottomPanel
	{
		[CompilerGenerated]
		get
		{
			return panel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			panel_0 = value;
		}
	}

	public GForm0()
	{
		while (true)
		{
			smethod_0(this);
			while (true)
			{
				smethod_1(this, new EventHandler(method_0));
				while (true)
				{
					smethod_2(this, new EventHandler(method_6));
					int num = 12;
					if (smethod_4())
					{
						while (true)
						{
							switch (num)
							{
							case 31:
								int_10 = 0;
								goto case 11;
							case 11:
							case 19:
								int_11 = 0;
								num = 6;
								if (smethod_5())
								{
								}
								continue;
							case 30:
								int_3 = 175;
								goto case 22;
							case 22:
								int_4 = 100;
								goto case 10;
							case 10:
								bool_1 = true;
								goto case 17;
							case 17:
								int_5 = 0;
								goto case 13;
							case 13:
								int_6 = 0;
								goto case 4;
							case 4:
								bool_2 = false;
								goto case 5;
							case 5:
								bool_3 = false;
								smethod_5();
								if (!smethod_4())
								{
									goto case 11;
								}
								goto case 8;
							case 8:
							case 14:
								bool_4 = true;
								num = 29;
								if (!smethod_5())
								{
									continue;
								}
								goto case 15;
							case 15:
								int_13 = 1;
								goto case 27;
							case 27:
								int_14 = 1;
								num = 25;
								if (smethod_5())
								{
								}
								continue;
							case 29:
								int_7 = 8;
								goto default;
							default:
								int_8 = 8;
								goto case 18;
							case 18:
								int_9 = 0;
								goto case 31;
							case 25:
								int_15 = 0;
								num = 0;
								if (smethod_4())
								{
									continue;
								}
								goto case 0;
							case 12:
								int_0 = smethod_3().Second;
								goto case 2;
							case 2:
								int_1 = 0;
								goto case 7;
							case 7:
								int_2 = 0;
								goto case 3;
							case 3:
								bool_0 = true;
								goto case 30;
							case 6:
								int_12 = 0;
								goto case 15;
							case 20:
								break;
							case 26:
								goto end_IL_019d;
							case 9:
								goto end_IL_01c0;
							case 0:
								int_16 = 0;
								goto case 1;
							case 1:
								int_17 = 0;
								goto case 16;
							case 16:
								object_4 = "Default";
								goto case 23;
							case 23:
								object_5 = new bool[901, 901];
								goto case 24;
							case 24:
								object_6 = new int[901, 901];
								goto IL_0223;
							case 21:
								goto IL_0223;
							case 32:
								return;
							}
							break;
						}
						continue;
					}
					goto IL_0223;
					IL_0223:
					method_18();
					return;
					continue;
					end_IL_019d:
					break;
				}
				continue;
				end_IL_01c0:
				break;
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Thread object_ = new Thread(Class7.smethod_1);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_6(object_);
		}
	}

	public void method_1()
	{
		smethod_5();
		if (smethod_4())
		{
			goto IL_003d;
		}
		int num = 4;
		if (smethod_4())
		{
			goto IL_0051;
		}
		goto IL_00ba;
		IL_00b4:
		method_13();
		goto IL_00ba;
		IL_0051:
		bool flag = default(bool);
		switch (num)
		{
		case 6:
			flag = !bool_1;
			break;
		case 2:
		case 4:
			break;
		case 0:
		case 1:
			goto IL_003d;
		case 9:
			method_9();
			goto IL_0096;
		case 3:
			goto IL_0096;
		case 7:
			goto IL_009d;
		case 5:
			goto IL_00a7;
		default:
			goto IL_00ac;
		case 12:
			goto IL_00b4;
		case 8:
		case 10:
			goto IL_00ba;
		case 13:
			return;
		}
		goto IL_002c;
		IL_00ba:
		method_10();
		return;
		IL_00ac:
		method_12();
		goto IL_00ba;
		IL_003d:
		smethod_7();
		num = 6;
		if (smethod_5())
		{
			goto IL_002c;
		}
		goto IL_0051;
		IL_002c:
		if (flag)
		{
			num = 9;
			if (smethod_5())
			{
			}
			goto IL_0051;
		}
		goto IL_0096;
		IL_00a7:
		bool flag2 = default(bool);
		if (flag2)
		{
			goto IL_00b4;
		}
		goto IL_00ba;
		IL_0096:
		bool flag3 = bool_2;
		goto IL_009d;
		IL_009d:
		if (!flag3)
		{
			flag2 = bool_3;
			goto IL_00a7;
		}
		goto IL_00ac;
	}

	public void method_2()
	{
		checked
		{
			bool flag2 = default(bool);
			while (true)
			{
				bool_1 = true;
				while (true)
				{
					int_9 = 0;
					smethod_4();
					if (smethod_5())
					{
						goto IL_001d;
					}
					goto IL_00c4;
					IL_00c4:
					object_3 = new bool[901, 901];
					goto IL_00d9;
					IL_00d9:
					smethod_9(smethod_8(this), (int_3 + 3) * (int_4 + 3));
					goto IL_00f5;
					IL_00f5:
					smethod_10(smethod_8(this), bool_5: true);
					goto IL_0101;
					IL_0101:
					smethod_11(smethod_8(this), 0);
					goto IL_001d;
					IL_001d:
					while (true)
					{
						bool flag = int_9 <= int_3 + 2;
						if (smethod_4())
						{
							switch (8)
							{
							case 20:
								break;
							case 14:
							case 15:
							case 17:
								continue;
							case 8:
								if (flag)
								{
									int_10 = 0;
									goto case 3;
								}
								goto case 18;
							case 2:
							case 10:
								goto IL_00c4;
							case 16:
								goto IL_00d9;
							case 13:
								goto IL_00f5;
							case 7:
								goto IL_0101;
							case 23:
							{
								ProgressBar object_;
								smethod_11(object_ = (ProgressBar)smethod_8(this), smethod_14(object_) + 1);
								goto case 12;
							}
							case 12:
								int_10++;
								goto case 3;
							default:
								if (flag2)
								{
									smethod_12(object_3, int_9, int_10, bool_5: false);
									goto case 0;
								}
								goto case 1;
							case 0:
								smethod_13(object_6, int_9, int_10, 0);
								goto case 23;
							case 3:
							case 4:
								flag2 = int_10 <= int_4 + 2;
								goto default;
							case 1:
								int_9++;
								continue;
							case 5:
								goto end_IL_0006;
							case 18:
								int_11 = (int)smethod_15((double)int_3 / 2.0);
								goto case 6;
							case 6:
								int_12 = (int)smethod_15((double)int_4 / 2.0);
								goto case 11;
							case 11:
								smethod_10(smethod_8(this), bool_5: false);
								goto case 19;
							case 19:
								smethod_17(smethod_16(this), int_3);
								goto IL_01ff;
							case 24:
								goto IL_01ff;
							case 21:
								goto IL_0224;
							case 22:
								goto IL_0235;
							case 25:
								return;
							}
							break;
						}
						goto IL_01ff;
						IL_0235:
						smethod_21(smethod_23(this), smethod_20("Height(", smethod_19(int_4), ")"));
						return;
						IL_01ff:
						smethod_21(smethod_18(this), smethod_20("Width(", smethod_19(int_3), ")"));
						goto IL_0224;
						IL_0224:
						smethod_17(smethod_22(this), int_4);
						goto IL_0235;
					}
					continue;
					end_IL_0006:
					break;
				}
			}
		}
	}

	public void method_3()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		while (true)
		{
			object_0 = smethod_24(this);
			_ = 1;
			if (smethod_5())
			{
				break;
			}
			if (smethod_4())
			{
				switch (0)
				{
				case 4:
					continue;
				case 0:
				case 1:
					object_2 = (object)checked(new Bitmap(smethod_25(this) - 15, smethod_26(this) - 39 - smethod_28(smethod_27(this))));
					break;
				case 5:
					return;
				}
			}
			break;
		}
		object_1 = smethod_24(this);
	}

	public void method_4()
	{
		checked
		{
			while (true)
			{
				int_9 = 0;
				while (true)
				{
					bool flag = int_9 <= int_3 + 2;
					while (true)
					{
						if (!flag)
						{
							return;
						}
						int_10 = 0;
						while (true)
						{
							IL_00c0:
							bool flag2 = int_10 <= int_4 + 2;
							while (true)
							{
								_ = 1;
								int num;
								if (smethod_5())
								{
									num = 1;
									if (!smethod_4())
									{
										break;
									}
									goto IL_0083;
								}
								goto IL_004d;
								IL_0083:
								switch (num)
								{
								case 9:
									goto IL_002f;
								case 5:
								case 8:
									goto IL_004d;
								case 3:
								case 7:
									goto IL_00c0;
								case 0:
									goto end_IL_0012;
								case 1:
								case 6:
									goto IL_00e2;
								case 2:
								case 4:
									goto end_IL_00da;
								case 10:
									goto end_IL_00ef;
								case 11:
									return;
								}
								continue;
								IL_004d:
								if (flag2)
								{
									smethod_12(object_5, int_9, int_10, smethod_29(object_3, int_9, int_10));
									goto IL_002f;
								}
								goto IL_00e2;
								IL_00e2:
								int_9++;
								goto end_IL_00da;
								IL_002f:
								int_10++;
								num = 7;
								if (smethod_5())
								{
									return;
								}
								goto IL_0083;
								continue;
								end_IL_0012:
								break;
							}
							break;
						}
						continue;
						end_IL_00da:
						break;
					}
					continue;
					end_IL_00ef:
					break;
				}
			}
		}
	}

	public void method_5(string string_0)
	{
		int num = 12;
		if (!smethod_5())
		{
		}
		checked
		{
			bool flag2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				case 22:
					smethod_30(string_0, "WorldData", "MapY", smethod_19(int_17));
					goto case 9;
				case 9:
					smethod_30(string_0, "WorldData", "AlgToUse", object_4);
					goto case 16;
				case 16:
					smethod_9(smethod_8(this), (int_3 + 3) * (int_4 + 3));
					num = 15;
					if (smethod_4())
					{
						continue;
					}
					goto case 0;
				case 0:
					smethod_30(string_0, "WorldData", "H_Cubes", smethod_19(int_4));
					goto case 21;
				case 14:
					smethod_30(string_0, "WorldData", "yInterval", smethod_19(int_7));
					num = 6;
					if (smethod_4())
					{
						continue;
					}
					goto case 21;
				case 21:
					smethod_30(string_0, "WorldData", "xInterval", smethod_19(int_8));
					goto case 14;
				case 5:
				case 19:
					if (!flag2)
					{
						break;
					}
					int_10 = 0;
					goto case 2;
				case 2:
				case 7:
					flag = int_10 <= int_4 + 2;
					num = 10;
					if (!smethod_5())
					{
						continue;
					}
					goto case 18;
				case 18:
				{
					ProgressBar object_;
					smethod_11(object_ = (ProgressBar)smethod_8(this), smethod_14(object_) + 1);
					goto case 17;
				}
				case 17:
					int_10++;
					goto case 2;
				case 15:
					smethod_10(smethod_8(this), bool_5: true);
					goto case 3;
				case 3:
					smethod_11(smethod_8(this), 0);
					goto default;
				default:
					flag2 = int_9 <= int_3 + 2;
					_ = 0;
					if (!smethod_4())
					{
						break;
					}
					goto case 5;
				case 13:
					int_9++;
					goto default;
				case 12:
					int_9 = 0;
					goto case 4;
				case 4:
					smethod_30(string_0, "WorldData", "W_Cubes", smethod_19(int_3));
					goto case 0;
				case 10:
					if (flag)
					{
						smethod_30(string_0, smethod_20(smethod_19(int_9), "-", smethod_19(int_10)), "IsLive", ((bool[,])object_3)[int_9, int_10].ToString());
						goto case 18;
					}
					goto case 13;
				case 6:
					smethod_30(string_0, "WorldData", "MapX", smethod_19(int_16));
					goto case 22;
				case 8:
				case 20:
					break;
				case 23:
					return;
				}
				break;
			}
			smethod_10(smethod_8(this), bool_5: false);
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		Thread object_ = new Thread(Class7.smethod_14);
		for (int num = 0; num == 0; num = 1)
		{
			smethod_6(object_);
		}
	}

	public void method_7(string string_0)
	{
		checked
		{
			int num2 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int_9 = 0;
				while (true)
				{
					IL_02c1:
					int_3 = smethod_32(smethod_31(string_0, "WorldData", "W_Cubes", ""));
					while (true)
					{
						IL_029f:
						int_4 = smethod_32(smethod_31(string_0, "WorldData", "H_Cubes", ""));
						while (true)
						{
							IL_027d:
							int_8 = smethod_32(smethod_31(string_0, "WorldData", "xInterval", ""));
							while (true)
							{
								int_7 = smethod_32(smethod_31(string_0, "WorldData", "yInterval", ""));
								int num = 30;
								if (!smethod_4())
								{
									break;
								}
								while (true)
								{
									switch (num)
									{
									case 30:
										int_16 = smethod_32(smethod_31(string_0, "WorldData", "MapX", ""));
										num = 11;
										if (smethod_5())
										{
										}
										continue;
									case 28:
										smethod_10(smethod_8(this), bool_5: true);
										goto case 10;
									case 10:
										smethod_11(smethod_8(this), 0);
										goto case 6;
									case 6:
										num2 = 0;
										goto case 5;
									case 25:
										if (flag)
										{
											int_10 = 0;
											goto case 24;
										}
										goto case 31;
									case 3:
										if (flag2)
										{
											smethod_12(object_3, int_9, int_10, smethod_35(smethod_31(string_0, smethod_20(smethod_19(int_9), "-", smethod_19(int_10)), "IsLive", "")));
											goto case 7;
										}
										_ = 0;
										if (smethod_4())
										{
											goto case 8;
										}
										goto case 5;
									case 7:
										num2++;
										goto default;
									default:
									{
										ProgressBar object_;
										smethod_11(object_ = (ProgressBar)smethod_8(this), smethod_14(object_) + 1);
										num = 26;
										if (smethod_4())
										{
											continue;
										}
										goto case 24;
									}
									case 24:
									case 27:
										flag2 = int_10 <= int_4 + 2;
										goto case 3;
									case 8:
									case 20:
										int_9++;
										goto case 5;
									case 5:
									case 19:
									case 21:
										flag = int_9 <= int_3 + 2;
										goto case 25;
									case 26:
										int_10++;
										goto case 24;
									case 15:
										object_4 = smethod_31(string_0, "WorldData", "AlgToUse", "");
										goto case 9;
									case 9:
										smethod_34(smethod_33(this), object_4);
										goto case 2;
									case 2:
										smethod_9(smethod_8(this), (int_3 + 3) * (int_4 + 3));
										goto case 28;
									case 11:
										int_17 = smethod_32(smethod_31(string_0, "WorldData", "MapY", ""));
										num = 15;
										if (!smethod_5())
										{
											continue;
										}
										goto case 24;
									case 18:
										break;
									case 16:
										goto IL_027d;
									case 12:
										goto IL_029f;
									case 29:
										goto IL_02c1;
									case 1:
										goto end_IL_024c;
									case 31:
										int_11 = (int)smethod_15((double)int_3 / 2.0);
										goto case 17;
									case 17:
										int_12 = (int)smethod_15((double)int_4 / 2.0);
										goto case 4;
									case 4:
										smethod_17(smethod_16(this), int_3);
										goto case 23;
									case 23:
										smethod_21(smethod_18(this), smethod_20("Width(", smethod_19(int_3), ")"));
										goto case 13;
									case 13:
										smethod_17(smethod_22(this), int_4);
										goto case 14;
									case 14:
										smethod_21(smethod_23(this), smethod_20("Height(", smethod_19(int_4), ")"));
										goto case 22;
									case 22:
										smethod_10(smethod_8(this), bool_5: false);
										return;
									case 32:
										return;
									}
									break;
								}
								continue;
								end_IL_024c:
								break;
							}
							break;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public void method_8()
	{
		int num = 2;
		if (smethod_5())
		{
			goto IL_0021;
		}
		goto IL_00c8;
		IL_00c8:
		switch (num)
		{
		case 10:
			break;
		case 7:
			goto IL_0021;
		default:
			goto IL_003f;
		case 8:
			goto IL_0070;
		case 3:
		case 6:
			goto IL_007d;
		case 0:
		case 1:
		case 9:
			goto IL_0093;
		case 2:
			int_9 = 0;
			smethod_4();
			if (!smethod_5())
			{
				goto IL_0093;
			}
			goto IL_003f;
		case 11:
			return;
		}
		goto IL_0012;
		IL_0012:
		checked
		{
			int_9++;
			goto IL_0093;
		}
		IL_0093:
		bool flag = int_9 <= checked(int_3 + 2);
		goto IL_0021;
		IL_0021:
		if (!flag)
		{
			num = 11;
			if (smethod_4())
			{
				goto IL_00c8;
			}
		}
		else
		{
			int_10 = 0;
		}
		goto IL_007d;
		IL_003f:
		bool flag2 = default(bool);
		if (!flag2)
		{
			goto IL_0012;
		}
		smethod_12(object_3, int_9, int_10, smethod_29(object_5, int_9, int_10));
		goto IL_0070;
		IL_0070:
		checked
		{
			int_10++;
			goto IL_007d;
		}
		IL_007d:
		flag2 = int_10 <= checked(int_4 + 2);
		goto IL_003f;
	}

	public void method_9()
	{
		checked
		{
			bool flag60 = default(bool);
			bool flag27 = default(bool);
			bool flag10 = default(bool);
			bool flag41 = default(bool);
			bool flag19 = default(bool);
			bool flag47 = default(bool);
			bool flag49 = default(bool);
			bool flag58 = default(bool);
			bool flag62 = default(bool);
			bool flag65 = default(bool);
			bool flag68 = default(bool);
			bool flag71 = default(bool);
			bool flag75 = default(bool);
			bool flag77 = default(bool);
			bool flag22 = default(bool);
			bool flag12 = default(bool);
			bool flag53 = default(bool);
			bool flag87 = default(bool);
			bool flag88 = default(bool);
			bool flag89 = default(bool);
			bool flag13 = default(bool);
			bool flag36 = default(bool);
			bool flag20 = default(bool);
			bool flag25 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			bool flag94 = default(bool);
			bool flag95 = default(bool);
			bool flag48 = default(bool);
			bool flag92 = default(bool);
			bool flag93 = default(bool);
			bool flag78 = default(bool);
			bool flag90 = default(bool);
			bool flag91 = default(bool);
			bool flag45 = default(bool);
			bool flag33 = default(bool);
			bool flag85 = default(bool);
			bool flag86 = default(bool);
			bool flag29 = default(bool);
			bool flag84 = default(bool);
			bool flag59 = default(bool);
			bool flag61 = default(bool);
			bool flag63 = default(bool);
			bool flag64 = default(bool);
			bool flag66 = default(bool);
			bool flag67 = default(bool);
			bool flag69 = default(bool);
			bool flag70 = default(bool);
			bool flag72 = default(bool);
			bool flag73 = default(bool);
			bool flag74 = default(bool);
			bool flag4 = default(bool);
			bool flag76 = default(bool);
			bool flag38 = default(bool);
			bool flag82 = default(bool);
			bool flag83 = default(bool);
			bool flag79 = default(bool);
			bool flag80 = default(bool);
			bool flag81 = default(bool);
			bool flag = default(bool);
			bool flag50 = default(bool);
			bool flag55 = default(bool);
			bool flag56 = default(bool);
			bool flag57 = default(bool);
			bool flag54 = default(bool);
			bool flag7 = default(bool);
			bool flag52 = default(bool);
			bool flag51 = default(bool);
			bool flag40 = default(bool);
			bool flag31 = default(bool);
			bool flag21 = default(bool);
			bool flag24 = default(bool);
			bool flag42 = default(bool);
			bool flag5 = default(bool);
			bool flag14 = default(bool);
			bool flag44 = default(bool);
			bool flag46 = default(bool);
			bool flag43 = default(bool);
			bool flag3 = default(bool);
			bool flag39 = default(bool);
			bool flag37 = default(bool);
			bool flag18 = default(bool);
			bool flag34 = default(bool);
			bool flag35 = default(bool);
			bool flag15 = default(bool);
			bool flag26 = default(bool);
			bool flag28 = default(bool);
			bool flag30 = default(bool);
			bool flag32 = default(bool);
			bool flag23 = default(bool);
			bool flag2 = default(bool);
			bool flag17 = default(bool);
			bool flag16 = default(bool);
			bool flag11 = default(bool);
			bool flag6 = default(bool);
			bool flag96 = default(bool);
			bool flag97 = default(bool);
			bool flag98 = default(bool);
			bool flag99 = default(bool);
			while (true)
			{
				int_9 = 1;
				while (true)
				{
					IL_1a4a:
					bool[,] object_ = new bool[901, 901];
					int num = 275;
					if (smethod_5())
					{
						goto IL_01ca;
					}
					goto IL_15b8;
					IL_15b8:
					while (true)
					{
						switch (num)
						{
						case 288:
							if (flag60)
							{
								goto case 5;
							}
							flag27 = (int_15 == 3) | (int_15 == 4) | (int_15 == 6) | (int_15 == 7) | (int_15 == 8);
							goto case 16;
						case 5:
							flag10 = (int_15 == 3) | (int_15 == 6) | (int_15 == 7) | (int_15 == 8);
							goto case 64;
						case 64:
							if (flag10)
							{
								goto case 52;
							}
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 52:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 16:
							if (flag27)
							{
								num = 240;
								if (smethod_4())
								{
									continue;
								}
								goto case 278;
							}
							goto IL_01ca;
						case 278:
							if (flag41)
							{
								goto case 260;
							}
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 260:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 165:
							break;
						case 77:
							goto IL_00e9;
						case 180:
						case 275:
							goto IL_00f6;
						case 283:
							goto IL_010b;
						case 35:
						case 69:
							goto IL_0119;
						case 190:
							goto IL_0147;
						case 114:
							goto IL_0160;
						case 145:
							goto IL_0164;
						case 222:
							goto IL_016d;
						case 198:
							goto IL_017e;
						case 113:
							goto IL_01b3;
						case 50:
							goto IL_01b7;
						case 0:
						case 6:
						case 7:
						case 9:
						case 10:
						case 12:
						case 20:
						case 22:
						case 24:
						case 27:
						case 29:
						case 31:
						case 33:
						case 36:
						case 38:
						case 43:
						case 44:
						case 56:
						case 66:
						case 73:
						case 74:
						case 80:
						case 81:
						case 86:
						case 90:
						case 98:
						case 102:
						case 103:
						case 112:
						case 118:
						case 120:
						case 122:
						case 131:
						case 136:
						case 137:
						case 142:
						case 152:
						case 153:
						case 157:
						case 162:
						case 164:
						case 189:
						case 199:
						case 202:
						case 203:
						case 205:
						case 206:
						case 208:
						case 209:
						case 212:
						case 214:
						case 225:
						case 226:
						case 231:
						case 238:
						case 239:
						case 241:
						case 244:
						case 245:
						case 256:
						case 269:
						case 277:
						case 280:
						case 285:
						case 287:
							goto IL_01ca;
						case 286:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 284:
							if (flag19)
							{
								goto case 23;
							}
							goto case 17;
						case 23:
							int_15++;
							num = 17;
							if (smethod_4())
							{
								continue;
							}
							goto IL_01ca;
						case 17:
							flag47 = smethod_29(object_3, int_9, int_10 - 1);
							goto case 93;
						case 93:
							if (flag47)
							{
								goto case 232;
							}
							goto case 282;
						case 232:
							int_15++;
							goto case 282;
						case 282:
							flag49 = smethod_29(object_3, int_9 + 1, int_10 - 1);
							goto case 192;
						case 192:
							if (flag49)
							{
								goto case 99;
							}
							goto case 92;
						case 99:
							int_15++;
							goto case 92;
						case 92:
							flag58 = smethod_29(object_3, int_9 - 1, int_10);
							goto case 132;
						case 132:
							if (flag58)
							{
								num = 257;
								if (!smethod_5())
								{
									continue;
								}
								goto case 288;
							}
							goto case 72;
						case 72:
							flag62 = smethod_29(object_3, int_9 + 1, int_10);
							goto case 129;
						case 129:
							if (flag62)
							{
								goto case 159;
							}
							goto case 195;
						case 159:
							int_15++;
							goto case 195;
						case 195:
							flag65 = smethod_29(object_3, int_9 - 1, int_10 + 1);
							goto case 59;
						case 59:
							if (flag65)
							{
								goto case 273;
							}
							goto case 197;
						case 273:
							int_15++;
							goto case 197;
						case 197:
							flag68 = smethod_29(object_3, int_9, int_10 + 1);
							goto case 270;
						case 270:
							if (flag68)
							{
								goto case 233;
							}
							goto case 223;
						case 233:
							int_15++;
							goto case 223;
						case 223:
							flag71 = smethod_29(object_3, int_9 + 1, int_10 + 1);
							goto case 125;
						case 125:
							if (flag71)
							{
								goto case 168;
							}
							goto case 70;
						case 168:
							int_15++;
							num = 70;
							if (!smethod_5())
							{
								continue;
							}
							goto IL_01b3;
						case 70:
							flag75 = smethod_36(object_4, "Default", bool_5: false) == 0;
							goto case 65;
						case 65:
							if (flag75)
							{
								goto case 149;
							}
							flag77 = smethod_36(object_4, "Live Free or Die", bool_5: false) == 0;
							goto case 37;
						case 149:
							flag22 = smethod_29(object_3, int_9, int_10);
							num = 155;
							if (smethod_5())
							{
							}
							continue;
						case 37:
							if (flag77)
							{
								goto case 51;
							}
							flag12 = smethod_36(object_4, "Replicator", bool_5: false) == 0;
							goto case 108;
						case 51:
							flag53 = smethod_29(object_3, int_9, int_10);
							num = 237;
							if (smethod_4())
							{
								continue;
							}
							goto case 259;
						case 259:
							flag87 = smethod_29(object_3, int_9, int_10);
							goto case 140;
						case 140:
							if (flag87)
							{
								goto case 130;
							}
							flag88 = (int_15 == 3) | (int_15 == 4) | (int_15 == 5);
							goto case 94;
						case 130:
							flag89 = (int_15 == 4) | (int_15 == 5) | (int_15 == 6) | (int_15 == 7);
							goto case 220;
						case 220:
							if (!flag89)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 274;
						case 274:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 94:
							if (!flag88)
							{
								goto IL_01ca;
							}
							goto case 235;
						case 235:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 108:
							if (flag12)
							{
								num = 47;
								if (smethod_4())
								{
									continue;
								}
								goto IL_01ca;
							}
							flag13 = smethod_36(object_4, "Replicator 2", bool_5: false) == 0;
							num = 252;
							if (smethod_4())
							{
								continue;
							}
							goto IL_00f6;
						case 281:
							flag36 = (int_15 == 2) | (int_15 == 3) | (int_15 == 8);
							goto case 144;
						case 144:
							if (!flag36)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 228;
						case 228:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 279:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 276:
							flag20 = smethod_29(object_3, int_9, int_10);
							goto case 234;
						case 234:
							if (flag20)
							{
								goto case 279;
							}
							flag25 = int_15 == 2;
							goto case 216;
						case 216:
							if (!flag25)
							{
								goto IL_01ca;
							}
							goto case 242;
						case 242:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 272:
							flag19 = smethod_29(object_3, int_9 - 1, int_10 - 1);
							goto case 284;
						case 127:
							if (int_15 >= 1)
							{
								goto case 258;
							}
							goto IL_060a;
						case 258:
							if (int_15 <= 5)
							{
								num = 264;
								if (smethod_4())
								{
									continue;
								}
								goto case 271;
							}
							goto IL_060a;
						case 271:
							if (flag8)
							{
								goto case 127;
							}
							flag9 = int_15 == 3;
							goto case 263;
						case 263:
							if (flag9)
							{
								num = 247;
								if (smethod_5())
								{
								}
								continue;
							}
							goto IL_01ca;
						case 268:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 267:
							flag94 = int_15 == 0;
							goto case 148;
						case 148:
							if (flag94)
							{
								goto case 18;
							}
							flag95 = int_15 > 0;
							goto case 194;
						case 18:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 194:
							if (!flag95)
							{
								goto IL_01ca;
							}
							goto case 104;
						case 104:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 266:
							if (flag48)
							{
								num = 32;
								if (smethod_4())
								{
									continue;
								}
								goto IL_0119;
							}
							flag92 = int_15 == 3;
							goto case 87;
						case 87:
							if (flag92)
							{
								goto case 179;
							}
							flag93 = int_15 > 3;
							goto case 82;
						case 179:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 82:
							if (!flag93)
							{
								goto IL_01ca;
							}
							goto case 89;
						case 89:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 265:
							if (flag78)
							{
								goto case 21;
							}
							flag90 = (int_15 == 3) | (int_15 == 6) | (int_15 == 8);
							goto case 186;
						case 21:
							flag91 = (int_15 == 2) | (int_15 == 4) | (int_15 == 5);
							goto case 177;
						case 177:
							if (!flag91)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 217;
						case 217:
							smethod_12(object_, int_9, int_10, bool_5: true);
							num = 241;
							if (!smethod_5())
							{
								continue;
							}
							goto case 87;
						case 186:
							if (!flag90)
							{
								goto IL_01ca;
							}
							goto case 67;
						case 67:
							smethod_12(object_, int_9, int_10, bool_5: true);
							num = 153;
							if (smethod_4())
							{
								continue;
							}
							goto case 194;
						case 264:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 262:
							if (int_15 <= 8)
							{
								goto case 286;
							}
							goto IL_07f9;
						case 261:
							if (flag45)
							{
								num = 105;
								if (smethod_5())
								{
								}
								continue;
							}
							goto IL_01ca;
						case 257:
							int_15++;
							goto case 72;
						case 255:
							if (flag33)
							{
								goto case 30;
							}
							flag85 = (int_15 == 3) | (int_15 == 6) | (int_15 == 7) | (int_15 == 8);
							goto case 254;
						case 30:
							flag86 = (int_15 == 2) | (int_15 == 3) | (int_15 == 5) | (int_15 == 6) | (int_15 == 7) | (int_15 == 8);
							goto case 163;
						case 163:
							if (!flag86)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 84;
						case 84:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 254:
							if (!flag85)
							{
								goto IL_01ca;
							}
							goto case 184;
						case 184:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 253:
							if (flag29)
							{
								goto case 281;
							}
							flag84 = (int_15 == 3) | (int_15 == 5) | (int_15 == 7);
							goto case 170;
						case 170:
							if (!flag84)
							{
								goto IL_01ca;
							}
							goto case 111;
						case 111:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 252:
							if (!flag13)
							{
								flag59 = smethod_36(object_4, "Life Without Death", bool_5: false) == 0;
								goto case 246;
							}
							num = 106;
							if (smethod_4())
							{
								continue;
							}
							goto IL_01ca;
						case 246:
							if (!flag59)
							{
								flag61 = smethod_36(object_4, "Maze", bool_5: false) == 0;
								goto case 109;
							}
							goto case 166;
						case 109:
							if (!flag61)
							{
								flag63 = smethod_36(object_4, "Mazectric", bool_5: false) == 0;
								goto case 57;
							}
							goto case 85;
						case 57:
							if (flag63)
							{
								goto IL_0147;
							}
							flag64 = smethod_36(object_4, "2X2", bool_5: false) == 0;
							goto case 19;
						case 19:
							if (!flag64)
							{
								flag66 = smethod_36(object_4, "High Life", bool_5: false) == 0;
								goto case 134;
							}
							goto case 117;
						case 96:
						case 133:
							if (!flag67)
							{
								flag69 = smethod_36(object_4, "Day & Night", bool_5: false) == 0;
								goto default;
							}
							goto case 4;
						default:
							if (!flag69)
							{
								flag70 = smethod_36(object_4, "Seeds", bool_5: false) == 0;
								goto case 63;
							}
							goto case 42;
						case 63:
							if (flag70)
							{
								goto case 276;
							}
							flag72 = smethod_36(object_4, "Amoeba", bool_5: false) == 0;
							goto case 45;
						case 45:
							if (!flag72)
							{
								flag73 = smethod_36(object_4, "Assimilation", bool_5: false) == 0;
								goto case 215;
							}
							goto case 181;
						case 215:
							if (flag73)
							{
								goto case 259;
							}
							flag74 = smethod_36(object_4, "Coral", bool_5: false) == 0;
							goto case 174;
						case 174:
							if (!flag74)
							{
								flag4 = smethod_36(object_4, "34 Life", bool_5: false) == 0;
								num = 58;
								if (smethod_4())
								{
									continue;
								}
								goto case 235;
							}
							goto case 2;
						case 2:
							flag76 = smethod_29(object_3, int_9, int_10);
							goto case 88;
						case 88:
							if (!flag76)
							{
								flag38 = int_15 == 3;
								num = 178;
								if (smethod_4())
								{
									continue;
								}
								goto case 252;
							}
							goto case 41;
						case 134:
							if (flag66)
							{
								smethod_4();
								if (!smethod_5())
								{
									num = 173;
									if (smethod_4())
									{
										continue;
									}
									goto case 268;
								}
							}
							else
							{
								flag67 = smethod_36(object_4, "Move", bool_5: false) == 0;
							}
							goto case 96;
						case 166:
							flag82 = !smethod_29(object_3, int_9, int_10);
							goto case 196;
						case 196:
							if (!flag82)
							{
								goto IL_01ca;
							}
							goto case 115;
						case 115:
							flag83 = int_15 == 3;
							goto case 40;
						case 40:
							if (!flag83)
							{
								goto IL_01ca;
							}
							goto case 128;
						case 128:
							smethod_12(object_, int_9, int_10, bool_5: true);
							num = 22;
							if (smethod_5())
							{
							}
							continue;
						case 85:
							flag8 = smethod_29(object_3, int_9, int_10);
							goto case 271;
						case 117:
							flag79 = smethod_29(object_3, int_9, int_10);
							goto case 200;
						case 200:
							if (flag79)
							{
								goto case 219;
							}
							flag80 = (int_15 == 3) | (int_15 == 6);
							goto case 3;
						case 219:
							flag81 = (int_15 == 1) | (int_15 == 2) | (int_15 == 5);
							goto case 53;
						case 53:
							if (!flag81)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 8;
						case 8:
							smethod_12(object_, int_9, int_10, bool_5: true);
							num = 137;
							if (!smethod_5())
							{
								continue;
							}
							goto case 72;
						case 3:
							if (!flag80)
							{
								goto IL_01ca;
							}
							goto case 91;
						case 91:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 4:
							flag78 = smethod_29(object_3, int_9, int_10);
							num = 265;
							if (!smethod_5())
							{
								continue;
							}
							goto case 266;
						case 42:
							flag60 = smethod_29(object_3, int_9, int_10);
							goto case 288;
						case 181:
							flag = smethod_29(object_3, int_9, int_10);
							num = 13;
							if (!smethod_5())
							{
								continue;
							}
							goto IL_01ca;
						case 41:
							if (int_15 >= 4)
							{
								goto case 250;
							}
							goto IL_0ce7;
						case 250:
							if (int_15 <= 8)
							{
								goto case 46;
							}
							goto IL_0ce7;
						case 46:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 251:
							flag50 = smethod_29(object_3, int_9, int_10);
							num = 227;
							if (smethod_5())
							{
							}
							continue;
						case 249:
							if (int_15 >= 5)
							{
								goto case 262;
							}
							goto IL_07f9;
						case 248:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 247:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 243:
							flag55 = smethod_29(object_3, int_9, int_10);
							goto case 172;
						case 172:
							if (flag55)
							{
								goto case 171;
							}
							flag56 = (int_15 == 4) | (int_15 == 5) | (int_15 == 6) | (int_15 == 7) | (int_15 == 8);
							goto case 76;
						case 171:
							flag57 = (int_15 == 2) | (int_15 == 3) | (int_15 == 4) | (int_15 == 5);
							goto case 160;
						case 160:
							if (!flag57)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 124;
						case 124:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 76:
							if (!flag56)
							{
								goto IL_01ca;
							}
							goto case 141;
						case 141:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 240:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 237:
							if (flag53)
							{
								goto case 267;
							}
							flag54 = int_15 == 2;
							goto case 193;
						case 193:
							if (!flag54)
							{
								goto IL_01ca;
							}
							goto case 83;
						case 83:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 236:
							if (!flag7)
							{
								goto IL_01ca;
							}
							goto case 116;
						case 116:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 230:
							int_15++;
							goto case 75;
						case 75:
							flag52 = unchecked(int_15 % 2) != 0;
							goto case 167;
						case 167:
							if (!flag52)
							{
								goto IL_01ca;
							}
							goto case 150;
						case 150:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 229:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 227:
							if (flag50)
							{
								goto case 249;
							}
							flag51 = (int_15 == 3) | (int_15 == 5) | (int_15 == 6) | (int_15 == 7) | (int_15 == 8);
							goto case 175;
						case 175:
							if (!flag51)
							{
								goto IL_01ca;
							}
							goto case 11;
						case 11:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 221:
							if (!flag40)
							{
								goto IL_01ca;
							}
							goto case 135;
						case 135:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 218:
							if (!flag31)
							{
								flag21 = (int_15 == 2) | (int_15 == 3) | (int_15 == 4);
								num = 147;
								if (smethod_4())
								{
									continue;
								}
								goto IL_01ca;
							}
							goto case 248;
						case 213:
							if (!flag24)
							{
								flag48 = int_15 == 2;
								goto case 266;
							}
							goto case 95;
						case 95:
							smethod_12(object_, int_9, int_10, bool_5: false);
							num = 214;
							if (smethod_5())
							{
							}
							continue;
						case 211:
							if (!flag42)
							{
								goto IL_01ca;
							}
							goto case 25;
						case 25:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						case 210:
							if (flag5)
							{
								goto case 251;
							}
							flag14 = smethod_36(object_4, "Gnarl", bool_5: false) == 0;
							num = 100;
							if (smethod_4())
							{
								continue;
							}
							goto case 97;
						case 97:
							if (!flag44)
							{
								flag45 = (int_15 == 3) | (int_15 == 4) | (int_15 == 5);
								goto case 261;
							}
							goto case 121;
						case 121:
							flag46 = int_15 == 5;
							goto case 15;
						case 15:
							if (!flag46)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 101;
						case 101:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 207:
							flag44 = smethod_29(object_3, int_9, int_10);
							goto case 97;
						case 201:
							flag43 = int_15 == 1;
							goto case 161;
						case 161:
							if (!flag43)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								num = 20;
								if (!smethod_5())
								{
									continue;
								}
								goto case 17;
							}
							goto case 156;
						case 156:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 191:
							flag42 = unchecked(int_15 % 2) != 0;
							goto case 211;
						case 188:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 187:
							flag41 = (int_15 == 2) | (int_15 == 3);
							goto case 278;
						case 185:
							if (!flag3)
							{
								flag40 = unchecked(int_15 % 2) != 0;
								goto case 221;
							}
							goto case 191;
						case 182:
							flag39 = (int_15 == 3) | (int_15 == 4);
							goto case 110;
						case 110:
							if (!flag39)
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
								goto IL_01ca;
							}
							goto case 229;
						case 178:
							if (!flag38)
							{
								goto IL_01ca;
							}
							goto case 26;
						case 26:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 176:
							flag37 = smethod_29(object_3, int_9, int_10);
							goto case 61;
						case 61:
							if (!flag37)
							{
								flag18 = int_15 == 1;
								num = 119;
								if (smethod_4())
								{
									continue;
								}
								goto case 134;
							}
							goto case 201;
						case 123:
						case 173:
							flag34 = smethod_29(object_3, int_9, int_10);
							goto case 60;
						case 60:
							if (flag34)
							{
								goto case 187;
							}
							flag35 = (int_15 == 3) | (int_15 == 6);
							goto case 158;
						case 158:
							if (!flag35)
							{
								goto IL_01ca;
							}
							goto case 268;
						case 169:
							if (flag15)
							{
								goto case 207;
							}
							flag26 = smethod_36(object_4, "Pseudo life", bool_5: false) == 0;
							goto case 139;
						case 139:
							if (flag26)
							{
								goto case 71;
							}
							flag28 = smethod_36(object_4, "Serviettes", bool_5: false) == 0;
							goto case 49;
						case 71:
							flag29 = smethod_29(object_3, int_9, int_10);
							goto case 253;
						case 49:
							if (flag28)
							{
								goto case 154;
							}
							flag30 = smethod_36(object_4, "Stains", bool_5: false) == 0;
							goto case 34;
						case 154:
							flag31 = smethod_29(object_3, int_9, int_10);
							num = 218;
							if (smethod_5())
							{
							}
							continue;
						case 34:
							if (flag30)
							{
								goto case 146;
							}
							flag32 = smethod_36(object_4, "WalledCities", bool_5: false) == 0;
							goto case 138;
						case 146:
							flag33 = smethod_29(object_3, int_9, int_10);
							goto case 255;
						case 138:
							if (!flag32)
							{
								goto IL_01ca;
							}
							goto case 243;
						case 155:
							if (flag22)
							{
								goto case 48;
							}
							flag23 = int_15 == 3;
							goto case 151;
						case 48:
							flag24 = int_15 < 2;
							goto case 213;
						case 151:
							if (!flag23)
							{
								goto IL_01ca;
							}
							goto case 107;
						case 107:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 147:
							if (!flag21)
							{
								goto IL_01ca;
							}
							goto case 78;
						case 78:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 143:
							if (!flag2)
							{
								goto IL_01ca;
							}
							num = 55;
							if (smethod_4())
							{
								continue;
							}
							goto case 18;
						case 126:
							if (!flag17)
							{
								goto IL_01ca;
							}
							goto case 39;
						case 39:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 119:
							if (!flag18)
							{
								goto IL_01ca;
							}
							num = 68;
							if (smethod_4())
							{
								continue;
							}
							goto case 181;
						case 106:
							flag16 = smethod_29(object_3, int_9, int_10);
							goto case 54;
						case 54:
							if (flag16)
							{
								goto case 230;
							}
							flag17 = unchecked(int_15 % 2) != 0;
							goto case 126;
						case 105:
							smethod_12(object_, int_9, int_10, bool_5: true);
							num = 231;
							if (!smethod_5())
							{
								continue;
							}
							goto case 140;
						case 100:
							if (flag14)
							{
								goto case 176;
							}
							flag15 = smethod_36(object_4, "Long life", bool_5: false) == 0;
							goto case 169;
						case 79:
							flag11 = (int_15 == 1) | (int_15 == 3) | (int_15 == 5) | (int_15 == 8);
							goto case 62;
						case 62:
							if (flag11)
							{
								num = 188;
								if (!smethod_5())
								{
									continue;
								}
							}
							else
							{
								smethod_12(object_, int_9, int_10, bool_5: false);
							}
							goto IL_01ca;
						case 68:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 58:
							if (!flag4)
							{
								flag5 = smethod_36(object_4, "Diamoeba", bool_5: false) == 0;
								num = 210;
								if (smethod_4())
								{
									continue;
								}
								goto IL_01ca;
							}
							goto case 1;
						case 1:
							flag6 = smethod_29(object_3, int_9, int_10);
							goto case 28;
						case 28:
							if (!flag6)
							{
								flag7 = (int_15 == 3) | (int_15 == 4);
								goto case 236;
							}
							goto case 182;
						case 55:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 47:
							flag3 = smethod_29(object_3, int_9, int_10);
							goto case 185;
						case 32:
							smethod_12(object_, int_9, int_10, bool_5: true);
							goto IL_01ca;
						case 13:
							if (!flag)
							{
								flag2 = (int_15 == 3) | (int_15 == 5) | (int_15 == 7);
								goto case 143;
							}
							goto case 79;
						case 183:
							goto IL_1a4a;
						case 14:
							goto end_IL_1a4a;
						case 224:
							goto IL_1a78;
						case 289:
							return;
							IL_060a:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
							IL_0ce7:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
							IL_07f9:
							smethod_12(object_, int_9, int_10, bool_5: false);
							goto IL_01ca;
						}
						break;
					}
					goto IL_00e5;
					IL_01ca:
					int_10++;
					goto IL_0119;
					IL_0119:
					flag96 = int_10 <= int_4 - 1;
					goto IL_00e5;
					IL_00e5:
					if (!flag96)
					{
						goto IL_00e9;
					}
					int_15 = 0;
					num = 272;
					if (smethod_5())
					{
						goto IL_0147;
					}
					goto IL_15b8;
					IL_00e9:
					int_9++;
					goto IL_00f6;
					IL_00f6:
					flag97 = int_9 <= int_3 - 1;
					goto IL_010b;
					IL_010b:
					if (flag97)
					{
						int_10 = 1;
						goto IL_0119;
					}
					goto IL_1a78;
					IL_01b7:
					smethod_12(object_, int_9, int_10, bool_5: true);
					goto IL_01ca;
					IL_1a78:
					object_3 = object_;
					return;
					IL_01b3:
					if (flag98)
					{
						goto IL_01b7;
					}
					goto IL_01ca;
					IL_0147:
					flag99 = smethod_29(object_3, int_9, int_10);
					goto IL_0160;
					IL_0160:
					if (flag99)
					{
						goto IL_0164;
					}
					flag98 = int_15 == 3;
					goto IL_01b3;
					IL_0164:
					if (int_15 >= 1)
					{
						goto IL_016d;
					}
					goto IL_0193;
					IL_016d:
					if (int_15 <= 4)
					{
						goto IL_017e;
					}
					goto IL_0193;
					IL_017e:
					smethod_12(object_, int_9, int_10, bool_5: true);
					goto IL_01ca;
					IL_0193:
					smethod_12(object_, int_9, int_10, bool_5: false);
					goto IL_01ca;
					continue;
					end_IL_1a4a:
					break;
				}
			}
		}
	}

	private void method_10()
	{
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		checked
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			Pen val = default(Pen);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			bool flag10 = default(bool);
			while (true)
			{
				int_9 = 1;
				while (true)
				{
					int_13 = 0;
					while (true)
					{
						int_14 = 0;
						_ = 1;
						if (smethod_5())
						{
							goto IL_0546;
						}
						int num = 24;
						if (!smethod_4())
						{
							goto IL_01b5;
						}
						goto IL_032b;
						IL_04d1:
						flag = smethod_29(object_3, int_9, int_10);
						goto IL_045c;
						IL_032b:
						while (true)
						{
							switch (num)
							{
							case 22:
								break;
							case 45:
								goto IL_004c;
							case 8:
								goto IL_005f;
							case 39:
								goto IL_008c;
							case 35:
								goto IL_009d;
							case 23:
								goto IL_00bd;
							case 36:
								goto IL_00c4;
							case 43:
								goto IL_00ca;
							case 44:
								goto IL_00ea;
							case 38:
								goto IL_00f0;
							case 42:
								goto IL_014b;
							case 40:
								flag2 = smethod_42(smethod_41(this));
								num = 1;
								if (!smethod_5())
								{
									continue;
								}
								goto IL_0546;
							case 37:
								goto IL_01b5;
							case 33:
								goto IL_0201;
							case 4:
							case 25:
								goto IL_0210;
							case 31:
								goto IL_0225;
							case 26:
								goto IL_0246;
							case 29:
								if (!flag3)
								{
									smethod_56(object_0, smethod_57());
									num = 41;
									if (smethod_4())
									{
										continue;
									}
								}
								goto case 5;
							case 3:
							case 24:
								val = new Pen(smethod_37());
								goto case 21;
							case 21:
								smethod_38(val, 2f);
								goto case 0;
							case 0:
								smethod_40(object_0, (object)new SolidBrush(smethod_39()), int_16 + int_8, int_17 + int_7, int_8 * (int_3 - 1), int_7 * (int_4 - 1));
								goto IL_0210;
							case 18:
								flag3 = bool_1;
								goto case 29;
							case 15:
								smethod_54(object_1, object_2, 0, 0);
								num = 18;
								if (!smethod_5())
								{
									continue;
								}
								goto IL_00ea;
							default:
								num = 28;
								if (smethod_4())
								{
									continue;
								}
								goto end_IL_0566;
							case 34:
								goto IL_03f1;
							case 9:
								goto IL_03fd;
							case 10:
							case 11:
								goto IL_0404;
							case 30:
								goto IL_041b;
							case 6:
								goto IL_044b;
							case 27:
								goto IL_045c;
							case 2:
								goto IL_0465;
							case 28:
								goto IL_0486;
							case 13:
								goto IL_048a;
							case 12:
								goto IL_04d1;
							case 17:
								goto IL_04ef;
							case 1:
								if (flag2)
								{
									goto case 19;
								}
								goto IL_0546;
							case 19:
								smethod_44(object_0, smethod_43(), new Point(int_16 + int_8, int_14), new Point(int_16 + int_8 * int_3, int_14));
								goto IL_0546;
							case 20:
							case 32:
								goto IL_0546;
							case 7:
								goto end_IL_0006;
							case 16:
								goto end_IL_0566;
							case 5:
								smethod_56(object_0, smethod_55());
								goto case 14;
							case 14:
							case 41:
								method_11();
								return;
							case 46:
								return;
							}
							break;
						}
						continue;
						IL_01b5:
						smethod_44(object_0, smethod_43(), new Point(int_13, int_17 + int_7), new Point(int_13, int_17 + int_7 * int_4));
						goto IL_00bd;
						IL_0546:
						flag4 = bool_1;
						goto IL_04ef;
						IL_04ef:
						if (flag4)
						{
							goto IL_0465;
						}
						goto IL_04d1;
						IL_0465:
						flag5 = (int_10 == int_12) | (int_10 == int_12 + 1);
						goto IL_0486;
						IL_0486:
						if (flag5)
						{
							goto IL_048a;
						}
						goto IL_04d1;
						IL_048a:
						smethod_44(object_0, smethod_45(), new Point(int_16 + int_8, int_14), new Point(int_16 + int_8 * int_3, int_14));
						goto IL_04d1;
						IL_004c:
						if (!flag6)
						{
							goto IL_00bd;
						}
						num = 37;
						if (smethod_5())
						{
							goto IL_005f;
						}
						goto IL_032b;
						IL_045c:
						if (flag)
						{
							goto IL_041b;
						}
						goto IL_044b;
						IL_00bd:
						flag7 = bool_1;
						goto IL_00c4;
						IL_00c4:
						if (flag7)
						{
							goto IL_00ca;
						}
						goto IL_03fd;
						IL_00ca:
						flag8 = (int_9 == int_11) | (int_9 == int_11 + 1);
						goto IL_00ea;
						IL_00ea:
						if (flag8)
						{
							goto IL_00f0;
						}
						goto IL_03fd;
						IL_00f0:
						smethod_44(object_0, smethod_45(), new Point(int_13, int_17 + int_7), new Point(int_13, int_17 + int_7 * int_4));
						num = 9;
						if (smethod_5())
						{
						}
						goto IL_032b;
						IL_03fd:
						int_10 = 1;
						goto IL_0404;
						IL_0404:
						flag9 = int_10 <= int_4 - 1;
						goto IL_03f1;
						IL_03f1:
						if (flag9)
						{
							int_14 = int_17 + int_10 * int_7;
							num = 40;
							if (!smethod_5())
							{
								goto IL_032b;
							}
							goto IL_04d1;
						}
						goto IL_0201;
						IL_0201:
						int_9++;
						goto IL_0210;
						IL_0210:
						flag10 = int_9 <= int_3 - 1;
						goto IL_0225;
						IL_0225:
						if (!flag10)
						{
							goto IL_014b;
						}
						int_13 = int_16 + int_9 * int_8;
						goto IL_0246;
						IL_044b:
						int_10++;
						goto IL_0404;
						IL_0246:
						flag6 = smethod_42(smethod_41(this));
						goto IL_004c;
						IL_014b:
						smethod_48(object_0, val, int_16 + int_8, int_17 + int_7, int_8 * (int_3 - 1), int_7 * (int_4 - 1));
						goto IL_005f;
						IL_005f:
						smethod_52(object_0, smethod_19(int_2), smethod_49(this), smethod_50(), smethod_51(new Point(1, 1)));
						goto IL_008c;
						IL_008c:
						object_0 = smethod_53(object_2);
						goto IL_009d;
						IL_009d:
						object_1 = smethod_24(this);
						num = 15;
						if (smethod_5())
						{
						}
						goto IL_032b;
						IL_041b:
						smethod_47(object_0, smethod_46(), int_13 + 1, int_14 + 1, int_8 - 2, int_7 - 2);
						goto IL_044b;
						continue;
						end_IL_0006:
						break;
					}
					continue;
					end_IL_0566:
					break;
				}
			}
		}
	}

	private void method_11()
	{
		checked
		{
			while (true)
			{
				bool flag = int_0 == smethod_3().Second;
				smethod_4();
				if (!smethod_5())
				{
					if (smethod_5())
					{
						break;
					}
					switch (7)
					{
					case 6:
						break;
					case 1:
					case 7:
						if (flag)
						{
							goto case 5;
						}
						int_2 = int_1;
						goto IL_0080;
					case 5:
						int_1++;
						return;
					default:
						goto IL_0080;
					case 0:
						goto end_IL_0001;
					case 2:
					case 8:
						return;
					}
					continue;
				}
				goto IL_0080;
				IL_0080:
				int_1 = 0;
				break;
				continue;
				end_IL_0001:
				break;
			}
			int_0 = smethod_3().Second;
		}
	}

	public void method_12()
	{
		checked
		{
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int_9 = 1;
				while (true)
				{
					int_13 = 0;
					while (true)
					{
						int_14 = 0;
						while (true)
						{
							Rectangle rectangle = new Rectangle(int_5 - int_16, int_6 - int_17, 1, 1);
							while (true)
							{
								bool flag = int_9 <= int_3 - 1;
								while (true)
								{
									if (!flag)
									{
										return;
									}
									int_13 = int_9 * int_8;
									while (true)
									{
										int_10 = 1;
										while (true)
										{
											bool flag2 = int_10 <= int_4 - 1;
											while (true)
											{
												IL_0117:
												if (flag2)
												{
													int_14 = int_10 * int_7;
													while (true)
													{
														Rectangle rect = new Rectangle(int_13, int_14, int_8, int_7);
														int num = 17;
														if (!smethod_4())
														{
															break;
														}
														while (true)
														{
															switch (num)
															{
															case 9:
															case 18:
																if (flag3)
																{
																	goto default;
																}
																goto case 7;
															default:
																flag4 = !smethod_29(object_3, int_9, int_10);
																goto case 4;
															case 4:
																if (flag4)
																{
																	num = 16;
																	if (smethod_4())
																	{
																		continue;
																	}
																	goto case 16;
																}
																goto case 7;
															case 17:
																flag3 = rectangle.IntersectsWith(rect);
																_ = 0;
																if (smethod_4())
																{
																	goto case 9;
																}
																goto default;
															case 8:
																break;
															case 13:
																goto IL_0117;
															case 16:
																smethod_12(object_3, int_9, int_10, bool_5: true);
																goto case 7;
															case 7:
																int_10++;
																goto end_IL_00e7;
															case 2:
															case 11:
																goto end_IL_00e7;
															case 6:
																goto end_IL_014b;
															case 19:
																goto end_IL_0162;
															case 15:
																goto IL_0174;
															case 5:
															case 20:
																goto end_IL_016b;
															case 1:
																goto end_IL_0183;
															case 12:
																goto end_IL_019a;
															case 0:
																goto end_IL_01bf;
															case 3:
																goto end_IL_01c8;
															case 21:
																return;
															}
															break;
														}
														continue;
														end_IL_00e7:
														break;
													}
													break;
												}
												goto IL_0174;
												IL_0174:
												int_9++;
												goto end_IL_016b;
											}
											continue;
											end_IL_014b:
											break;
										}
										continue;
										end_IL_0162:
										break;
									}
									continue;
									end_IL_016b:
									break;
								}
								continue;
								end_IL_0183:
								break;
							}
							continue;
							end_IL_019a:
							break;
						}
						continue;
						end_IL_01bf:
						break;
					}
					continue;
					end_IL_01c8:
					break;
				}
			}
		}
	}

	public void method_13()
	{
		checked
		{
			while (true)
			{
				int_9 = 1;
				while (true)
				{
					int_13 = 0;
					while (true)
					{
						int_14 = 0;
						while (true)
						{
							Rectangle rectangle = new Rectangle(int_5 - int_16, int_6 - int_17, 1, 1);
							while (true)
							{
								bool flag = int_9 <= int_3 - 1;
								while (true)
								{
									IL_0180:
									if (!flag)
									{
										return;
									}
									int_13 = int_9 * int_8;
									while (true)
									{
										IL_0177:
										int_10 = 1;
										while (true)
										{
											IL_015f:
											bool flag2 = int_10 <= int_4 - 1;
											while (true)
											{
												IL_0147:
												if (flag2)
												{
													int_14 = int_10 * int_7;
													while (true)
													{
														IL_0126:
														Rectangle rect = new Rectangle(int_13, int_14, int_8, int_7);
														while (true)
														{
															IL_011b:
															bool flag3 = rectangle.IntersectsWith(rect);
															while (true)
															{
																IL_0116:
																if (flag3)
																{
																	while (true)
																	{
																		bool flag4 = smethod_29(object_3, int_9, int_10);
																		int num = 16;
																		if (!smethod_4())
																		{
																			break;
																		}
																		while (true)
																		{
																			switch (num)
																			{
																			case 8:
																				smethod_12(object_3, int_9, int_10, bool_5: false);
																				smethod_4();
																				if (smethod_5())
																				{
																					num = 2;
																					if (smethod_4())
																					{
																						continue;
																					}
																					goto case 16;
																				}
																				num = 17;
																				if (smethod_5())
																				{
																				}
																				continue;
																			case 16:
																				if (flag4)
																				{
																					goto case 8;
																				}
																				goto IL_0150;
																			default:
																				num = 10;
																				if (!smethod_5())
																				{
																					continue;
																				}
																				goto IL_0177;
																			case 10:
																				break;
																			case 14:
																				goto IL_0116;
																			case 19:
																				goto IL_011b;
																			case 0:
																				goto IL_0126;
																			case 2:
																			case 15:
																				goto IL_0147;
																			case 13:
																			case 17:
																				goto IL_0150;
																			case 6:
																			case 7:
																				goto IL_015f;
																			case 3:
																				goto IL_0177;
																			case 11:
																				goto IL_0180;
																			case 5:
																				goto IL_018c;
																			case 4:
																			case 18:
																				goto end_IL_00ed;
																			case 1:
																				goto end_IL_019b;
																			case 12:
																				goto end_IL_01b2;
																			case 9:
																				goto end_IL_01d7;
																			case 20:
																				goto end_IL_01e0;
																			case 21:
																				return;
																			}
																			break;
																		}
																		continue;
																		end_IL_00ed:
																		break;
																	}
																	break;
																}
																goto IL_0150;
																IL_0150:
																int_10++;
																goto IL_015f;
															}
															break;
														}
														break;
													}
													break;
												}
												goto IL_018c;
												IL_018c:
												int_9++;
												break;
											}
											break;
										}
										break;
									}
									break;
								}
								continue;
								end_IL_019b:
								break;
							}
							continue;
							end_IL_01b2:
							break;
						}
						continue;
						end_IL_01d7:
						break;
					}
					continue;
					end_IL_01e0:
					break;
				}
			}
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		smethod_59(smethod_58(this), "GOL Files (*.GOL*)|*.GOL");
		smethod_5();
		if (smethod_4())
		{
			smethod_60(smethod_58(this), ".GOL");
			smethod_61(smethod_58(this));
			string string_ = (string)smethod_62(smethod_58(this));
			method_5(string_);
		}
		smethod_63(this, null);
	}

	private void method_15(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		_ = 1;
		string text = default(string);
		bool flag = default(bool);
		if (!smethod_5())
		{
			while (true)
			{
				smethod_59(smethod_64(this), "GOL Files (*.GOL*)|*.GOL");
				while (true)
				{
					smethod_60(smethod_64(this), ".GOL");
					int num = 8;
					if (smethod_5())
					{
						goto IL_000e;
					}
					goto IL_0026;
					IL_0026:
					switch (num)
					{
					case 8:
						break;
					case 7:
						continue;
					case 0:
					case 3:
						goto end_IL_0059;
					case 9:
						text = (string)smethod_62(smethod_64(this));
						goto case 4;
					case 4:
						flag = smethod_65(text);
						goto end_IL_0078;
					default:
						goto end_IL_0078;
					case 2:
						goto IL_00a3;
					case 1:
						goto IL_00aa;
					case 10:
						return;
					}
					goto IL_000e;
					IL_000e:
					smethod_61(smethod_64(this));
					num = 9;
					if (!smethod_5())
					{
					}
					goto IL_0026;
					continue;
					end_IL_0059:
					break;
				}
				continue;
				end_IL_0078:
				break;
			}
		}
		if (flag)
		{
			goto IL_00a3;
		}
		goto IL_00aa;
		IL_00aa:
		smethod_63(this, null);
		return;
		IL_00a3:
		method_7(text);
		goto IL_00aa;
	}

	private void method_16(object sender, EventArgs e)
	{
		method_4();
		for (int num = 0; num == 0; num = 1)
		{
			smethod_63(this, null);
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		method_8();
		for (int num = 0; num == 0; num = 1)
		{
			smethod_63(this, null);
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			bool flag = disposing && object_7 != null;
			if (false || !flag)
			{
				return;
			}
			smethod_5();
			if (!smethod_4())
			{
				return;
			}
			if (smethod_4())
			{
				switch (2)
				{
				default:
					return;
				case 0:
				case 2:
					break;
				}
			}
			smethod_66(object_7);
		}
		finally
		{
			smethod_67(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_18()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected O, but got Unknown
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Expected O, but got Unknown
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected O, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e03: Expected O, but got Unknown
		//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Expected O, but got Unknown
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected O, but got Unknown
		//IL_0f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f57: Expected O, but got Unknown
		//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected O, but got Unknown
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Expected O, but got Unknown
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected O, but got Unknown
		int num = 115;
		if (!smethod_4())
		{
			goto IL_09be;
		}
		goto IL_105f;
		IL_105f:
		ComponentResourceManager object_ = default(ComponentResourceManager);
		while (true)
		{
			switch (num)
			{
			case 206:
				smethod_105(smethod_115(this), 1);
				goto case 39;
			case 39:
				smethod_106(smethod_115(this), bool_5: false);
				num = 110;
				if (!smethod_5())
				{
					continue;
				}
				break;
			case 104:
				break;
			case 69:
				goto IL_0049;
			case 166:
				goto IL_0066;
			case 32:
				goto IL_0076;
			case 172:
				goto IL_008d;
			case 151:
				goto IL_009d;
			case 205:
				smethod_122(smethod_115(this), bool_5: false);
				goto case 57;
			case 57:
				smethod_92(smethod_123(this), (AnchorStyles)6);
				goto case 165;
			case 165:
				smethod_116(smethod_123(this), smethod_93(64, 64, 64));
				num = 182;
				if (smethod_5())
				{
				}
				continue;
			case 204:
				smethod_87(smethod_22(this));
				goto case 38;
			case 38:
				smethod_88(smethod_27(this));
				goto case 191;
			case 191:
				smethod_89(this);
				goto case 51;
			case 51:
				smethod_91(smethod_90(this), 10);
				goto case 62;
			case 62:
				smethod_60(smethod_64(this), "OpenFileDialog1");
				goto case 129;
			case 129:
				smethod_92(smethod_33(this), (AnchorStyles)10);
				goto case 125;
			case 125:
				smethod_94(smethod_33(this), smethod_93(64, 64, 64));
				goto case 33;
			case 33:
				smethod_95(smethod_33(this), (object)new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				goto case 3;
			case 3:
				smethod_97(smethod_33(this), smethod_96());
				num = 37;
				if (smethod_4())
				{
					continue;
				}
				goto case 205;
			case 203:
				smethod_101(smethod_86(this), new Point(1034, 4));
				goto case 16;
			case 16:
				smethod_110(smethod_86(this), 200);
				goto case 2;
			case 2:
				smethod_111(smethod_86(this), 1);
				goto case 141;
			case 141:
				smethod_102(smethod_86(this), "RenderSpeed");
				goto case 13;
			case 13:
				smethod_112(smethod_86(this), (RightToLeft)1);
				goto case 31;
			case 31:
				smethod_103(smethod_86(this), new Size(192, 22));
				goto case 89;
			case 89:
				smethod_113(smethod_86(this), 10);
				goto case 194;
			case 194:
				smethod_105(smethod_86(this), 0);
				goto case 168;
			case 168:
				smethod_106(smethod_86(this), bool_5: false);
				goto case 42;
			case 42:
				smethod_114(smethod_86(this), 10);
				num = 94;
				if (!smethod_5())
				{
					continue;
				}
				goto case 62;
			case 202:
				smethod_134(smethod_133(smethod_27(this)), smethod_22(this));
				goto case 96;
			case 96:
				smethod_134(smethod_133(smethod_27(this)), smethod_18(this));
				num = 1;
				if (!smethod_5())
				{
					continue;
				}
				goto case 52;
			case 52:
				smethod_134(smethod_133(smethod_27(this)), smethod_8(this));
				goto case 197;
			case 17:
				smethod_134(smethod_133(smethod_27(this)), smethod_115(this));
				goto case 48;
			case 48:
				smethod_134(smethod_133(smethod_27(this)), smethod_86(this));
				goto case 14;
			case 14:
				smethod_134(smethod_133(smethod_27(this)), smethod_33(this));
				goto case 150;
			case 150:
				smethod_101(smethod_27(this), new Point(0, 809));
				goto case 200;
			case 200:
				smethod_102(smethod_27(this), "BottomPanel");
				goto case 63;
			case 63:
				smethod_103(smethod_27(this), new Size(1406, 30));
				goto case 117;
			case 117:
				smethod_105(smethod_27(this), 0);
				goto case 136;
			case 136:
				smethod_135(this, new SizeF(6f, 13f));
				goto case 91;
			case 91:
				smethod_136(this, (AutoScaleMode)1);
				goto case 149;
			case 149:
				smethod_137(this, new Size(1406, 840));
				goto case 64;
			case 64:
				smethod_134(smethod_138(this), smethod_27(this));
				goto case 177;
			case 177:
				smethod_140(this, (object)(Icon)smethod_139(object_, "$this.Icon"));
				goto case 130;
			case 130:
				smethod_141(this, new Size(1422, 878));
				num = 99;
				if (!smethod_5())
				{
					continue;
				}
				goto case 197;
			case 197:
				smethod_134(smethod_133(smethod_27(this)), smethod_123(this));
				goto case 17;
			case 201:
				smethod_76(this, (object)new ProgressBar());
				goto case 68;
			case 68:
				smethod_77(this, (object)new Button());
				num = 12;
				if (smethod_4())
				{
					continue;
				}
				goto case 174;
			case 174:
				smethod_105(smethod_23(this), 11);
				num = 46;
				if (smethod_4())
				{
					continue;
				}
				goto case 160;
			case 160:
				smethod_101(smethod_33(this), new Point(1232, 6));
				goto case 34;
			case 34:
				smethod_102(smethod_33(this), "Algorythm");
				goto case 192;
			case 192:
				smethod_103(smethod_33(this), new Size(171, 21));
				num = 105;
				if (!smethod_5())
				{
					continue;
				}
				goto case 5;
			case 5:
				smethod_70(this, (object)new SaveFileDialog());
				num = 85;
				if (smethod_5())
				{
				}
				continue;
			case 199:
				smethod_87(smethod_86(this));
				goto case 122;
			case 122:
				smethod_87(smethod_16(this));
				goto case 204;
			case 198:
				smethod_116(smethod_115(this), smethod_93(64, 64, 64));
				goto case 161;
			case 161:
				smethod_118(smethod_117(smethod_115(this)), 0);
				goto case 119;
			case 119:
				smethod_119(smethod_115(this), (FlatStyle)0);
				goto case 170;
			case 170:
				smethod_120(smethod_115(this), smethod_96());
				num = 184;
				if (smethod_4())
				{
					continue;
				}
				goto case 7;
			case 7:
				smethod_101(smethod_126(this), new Point(263, 4));
				goto case 175;
			case 175:
				smethod_102(smethod_126(this), "btn_LoadState");
				goto default;
			default:
				smethod_103(smethod_126(this), new Size(93, 23));
				goto case 43;
			case 43:
				smethod_105(smethod_126(this), 5);
				goto case 109;
			case 109:
				smethod_106(smethod_126(this), bool_5: false);
				goto case 53;
			case 53:
				smethod_121(smethod_126(this), "Load State (F2)");
				num = 20;
				if (smethod_4())
				{
					continue;
				}
				goto IL_055a;
			case 75:
				goto IL_055a;
			case 9:
				goto IL_0570;
			case 86:
				goto IL_0580;
			case 112:
				goto IL_058d;
			case 35:
				goto IL_059d;
			case 4:
				goto IL_05b9;
			case 111:
				goto IL_05c6;
			case 196:
				smethod_92(smethod_16(this), (AnchorStyles)6);
				goto case 80;
			case 80:
				smethod_108(smethod_16(this), bool_5: false);
				goto case 6;
			case 6:
				smethod_109(smethod_16(this), 100);
				goto case 45;
			case 45:
				smethod_101(smethod_16(this), new Point(513, 5));
				goto case 44;
			case 44:
				smethod_110(smethod_16(this), 800);
				goto case 28;
			case 28:
				smethod_111(smethod_16(this), 50);
				goto case 118;
			case 118:
				smethod_102(smethod_16(this), "MapW");
				goto case 121;
			case 121:
				smethod_112(smethod_16(this), (RightToLeft)0);
				goto case 41;
			case 41:
				smethod_128(smethod_16(this), bool_5: true);
				goto case 190;
			case 190:
				smethod_103(smethod_16(this), new Size(196, 22));
				num = 171;
				if (smethod_4())
				{
					continue;
				}
				goto case 173;
			case 173:
				smethod_109(smethod_86(this), 20);
				goto case 203;
			case 195:
				goto IL_0691;
			case 137:
				goto IL_06a1;
			case 126:
				goto IL_06b7;
			case 88:
				goto IL_06c7;
			case 107:
				goto IL_06db;
			case 59:
				goto IL_06e7;
			case 18:
				goto IL_0703;
			case 153:
				goto IL_0710;
			case 102:
				goto IL_0720;
			case 66:
				goto IL_072c;
			case 185:
				goto IL_0738;
			case 193:
				smethod_129(smethod_130(this), bool_5: true);
				goto case 138;
			case 138:
				smethod_95(smethod_130(this), (object)new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				goto case 156;
			case 156:
				smethod_120(smethod_130(this), smethod_96());
				goto case 180;
			case 180:
				smethod_101(smethod_130(this), new Point(985, 8));
				goto case 92;
			case 92:
				smethod_102(smethod_130(this), "Label1");
				goto case 134;
			case 134:
				smethod_103(smethod_130(this), new Size(43, 13));
				goto case 189;
			case 189:
				smethod_105(smethod_130(this), 12);
				goto case 179;
			case 179:
				smethod_21(smethod_130(this), "Speed");
				goto case 29;
			case 29:
				smethod_132(smethod_27(this), smethod_131());
				goto case 25;
			case 25:
				smethod_134(smethod_133(smethod_27(this)), smethod_130(this));
				goto case 181;
			case 181:
				smethod_134(smethod_133(smethod_27(this)), smethod_23(this));
				goto case 202;
			case 188:
				smethod_147(smethod_27(this), bool_5: false);
				num = 113;
				if (!smethod_5())
				{
					continue;
				}
				goto case 117;
			case 187:
				smethod_145(this, "Game Of Life - Dustin Harris");
				goto case 30;
			case 30:
				smethod_146(smethod_86(this));
				num = 24;
				if (smethod_4())
				{
					continue;
				}
				goto case 40;
			case 40:
				smethod_116(smethod_126(this), smethod_93(64, 64, 64));
				goto case 159;
			case 159:
				smethod_118(smethod_117(smethod_126(this)), 0);
				goto case 49;
			case 49:
				smethod_119(smethod_126(this), (FlatStyle)0);
				goto case 87;
			case 87:
				smethod_120(smethod_126(this), smethod_96());
				goto case 7;
			case 186:
				smethod_92(smethod_86(this), (AnchorStyles)6);
				goto case 10;
			case 10:
				smethod_108(smethod_86(this), bool_5: false);
				goto case 173;
			case 184:
				smethod_101(smethod_115(this), new Point(3, 4));
				goto case 143;
			case 143:
				smethod_102(smethod_115(this), "btn_Save");
				goto case 11;
			case 11:
				smethod_103(smethod_115(this), new Size(75, 23));
				goto case 206;
			case 183:
				smethod_106(smethod_123(this), bool_5: false);
				goto case 140;
			case 140:
				smethod_121(smethod_123(this), "Load");
				goto case 0;
			case 0:
				smethod_122(smethod_123(this), bool_5: false);
				goto case 178;
			case 178:
				smethod_92(smethod_8(this), (AnchorStyles)10);
				goto case 155;
			case 155:
				smethod_120(smethod_8(this), smethod_124());
				goto case 139;
			case 139:
				smethod_101(smethod_8(this), new Point(1265, 4));
				goto case 26;
			case 26:
				smethod_102(smethod_8(this), "ProgressBar1");
				goto case 108;
			case 108:
				smethod_103(smethod_8(this), new Size(141, 23));
				goto case 133;
			case 133:
				smethod_105(smethod_8(this), 3);
				goto case 76;
			case 76:
				smethod_10(smethod_8(this), bool_5: false);
				goto case 116;
			case 116:
				smethod_92(smethod_125(this), (AnchorStyles)6);
				goto case 65;
			case 65:
				smethod_116(smethod_125(this), smethod_93(64, 64, 64));
				goto IL_09be;
			case 145:
				goto IL_09be;
			case 154:
				goto IL_09cf;
			case 182:
				smethod_118(smethod_117(smethod_123(this)), 0);
				goto case 19;
			case 19:
				smethod_119(smethod_123(this), (FlatStyle)0);
				goto case 157;
			case 157:
				smethod_120(smethod_123(this), smethod_96());
				num = 120;
				if (smethod_4())
				{
					continue;
				}
				goto case 99;
			case 99:
				smethod_142(this, "Form1");
				goto case 135;
			case 135:
				smethod_143(this, 0.0);
				num = 74;
				if (smethod_4())
				{
					continue;
				}
				goto case 93;
			case 93:
				smethod_122(smethod_125(this), bool_5: false);
				goto case 67;
			case 67:
				smethod_92(smethod_126(this), (AnchorStyles)6);
				goto case 40;
			case 176:
				smethod_106(smethod_16(this), bool_5: false);
				num = 4;
				if (smethod_4())
				{
					continue;
				}
				goto case 20;
			case 20:
				smethod_122(smethod_126(this), bool_5: false);
				goto case 72;
			case 72:
				smethod_127(smethod_41(this), bool_5: true);
				goto case 142;
			case 142:
				smethod_120(smethod_41(this), smethod_96());
				goto case 106;
			case 106:
				smethod_101(smethod_41(this), new Point(362, 8));
				goto case 132;
			case 132:
				smethod_102(smethod_41(this), "ShowGrid");
				num = 70;
				if (smethod_4())
				{
					continue;
				}
				goto case 118;
			case 171:
				smethod_113(smethod_16(this), 20);
				goto case 124;
			case 124:
				smethod_105(smethod_16(this), 7);
				num = 176;
				if (!smethod_5())
				{
					continue;
				}
				goto case 176;
			case 169:
				smethod_101(smethod_23(this), new Point(713, 9));
				goto case 144;
			case 144:
				smethod_102(smethod_23(this), "lbl_MapH");
				goto case 95;
			case 95:
				smethod_103(smethod_23(this), new Size(59, 13));
				goto case 174;
			case 167:
				smethod_103(smethod_22(this), new Size(196, 22));
				goto case 55;
			case 55:
				smethod_113(smethod_22(this), 25);
				goto case 22;
			case 22:
				smethod_105(smethod_22(this), 10);
				goto case 97;
			case 97:
				smethod_106(smethod_22(this), bool_5: false);
				num = 50;
				if (smethod_4())
				{
					continue;
				}
				goto case 95;
			case 164:
				smethod_84(this, (object)new Label());
				goto case 147;
			case 147:
				smethod_85(this, (object)new Panel());
				goto case 199;
			case 163:
				smethod_122(smethod_41(this), bool_5: true);
				goto case 196;
			case 162:
				smethod_81(this, (object)new Label());
				num = 71;
				if (smethod_4())
				{
					continue;
				}
				goto case 74;
			case 74:
				smethod_144(this, bool_5: false);
				num = 187;
				if (!smethod_5())
				{
					continue;
				}
				goto default;
			case 158:
				smethod_146(smethod_22(this));
				goto case 188;
			case 148:
				smethod_121(smethod_125(this), "Save State (F1)");
				goto case 93;
			case 146:
				smethod_105(smethod_41(this), 6);
				goto case 84;
			case 84:
				smethod_106(smethod_41(this), bool_5: false);
				goto case 90;
			case 90:
				smethod_121(smethod_41(this), "Show Grid");
				goto case 163;
			case 36:
			case 131:
				smethod_105(smethod_33(this), 13);
				goto case 73;
			case 73:
				smethod_106(smethod_33(this), bool_5: false);
				goto case 58;
			case 58:
				smethod_107(smethod_33(this), "Default");
				goto case 186;
			case 128:
				smethod_134(smethod_133(smethod_27(this)), smethod_125(this));
				goto case 52;
			case 127:
				smethod_75(this, (object)new Button());
				goto case 201;
			case 123:
				smethod_102(smethod_123(this), "btn_Load");
				goto case 81;
			case 81:
				smethod_103(smethod_123(this), new Size(75, 23));
				num = 61;
				if (!smethod_5())
				{
					continue;
				}
				goto case 84;
			case 120:
				smethod_101(smethod_123(this), new Point(84, 4));
				goto case 123;
			case 115:
				object_7 = new Container();
				goto case 101;
			case 101:
				object_ = new ComponentResourceManager(smethod_68(typeof(GForm0).TypeHandle));
				goto case 8;
			case 8:
				smethod_69(this, (object)new Timer((IContainer)object_7));
				goto case 5;
			case 114:
				smethod_120(smethod_23(this), smethod_96());
				goto case 169;
			case 113:
				smethod_148(smethod_27(this));
				num = 98;
				if (smethod_4())
				{
					continue;
				}
				goto case 122;
			case 110:
				smethod_121(smethod_115(this), "Save");
				goto case 205;
			case 105:
				smethod_104(smethod_33(this), bool_5: true);
				smethod_5();
				if (smethod_4())
				{
					goto case 36;
				}
				goto default;
			case 100:
				smethod_92(smethod_115(this), (AnchorStyles)6);
				goto case 198;
			case 98:
				smethod_149(this, bool_5: false);
				num = 207;
				if (smethod_4())
				{
					continue;
				}
				goto case 44;
			case 94:
				smethod_17(smethod_86(this), 40);
				goto case 100;
			case 85:
				smethod_71(this, (object)new OpenFileDialog());
				goto case 82;
			case 82:
				smethod_72(this, (object)new ComboBox());
				goto case 27;
			case 27:
				smethod_73(this, (object)new TrackBar());
				goto case 23;
			case 23:
				smethod_74(this, (object)new Button());
				goto case 127;
			case 83:
				smethod_100(smethod_99(smethod_33(this)), new object[23]
				{
					"2X2", "34 Life", "Amoeba", "Assimilation", "Coral", "Day & Night", "Default", "Diamoeba", "Gnarl", "High Life",
					"Life Without Death", "Live Free or Die", "Long life", "Maze", "Mazectric", "Move", "Pseudo life", "Replicator", "Replicator 2", "Seeds",
					"Serviettes", "Stains", "WalledCities"
				});
				num = 160;
				if (smethod_4())
				{
					continue;
				}
				goto case 3;
			case 79:
				smethod_83(this, (object)new Label());
				goto case 164;
			case 78:
				smethod_95(smethod_23(this), (object)new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
				num = 114;
				if (smethod_5())
				{
				}
				continue;
			case 77:
				smethod_128(smethod_22(this), bool_5: true);
				goto case 167;
			case 71:
				smethod_82(this, (object)new TrackBar());
				goto case 79;
			case 70:
				smethod_103(smethod_41(this), new Size(75, 17));
				goto case 146;
			case 61:
				smethod_105(smethod_123(this), 2);
				goto case 183;
			case 60:
				smethod_80(this, (object)new TrackBar());
				goto case 162;
			case 56:
				smethod_134(smethod_133(smethod_27(this)), smethod_126(this));
				goto case 128;
			case 54:
				smethod_79(this, (object)new CheckBox());
				goto case 60;
			case 50:
				smethod_114(smethod_22(this), 50);
				goto case 21;
			case 21:
				smethod_17(smethod_22(this), 50);
				goto case 47;
			case 47:
				smethod_129(smethod_23(this), bool_5: true);
				goto case 78;
			case 46:
				smethod_21(smethod_23(this), "Height(0)");
				goto case 193;
			case 37:
				smethod_98(smethod_33(this), bool_5: true);
				goto case 83;
			case 24:
				smethod_146(smethod_16(this));
				goto case 158;
			case 15:
				smethod_134(smethod_133(smethod_27(this)), smethod_41(this));
				goto case 56;
			case 12:
				smethod_78(this, (object)new Button());
				goto case 54;
			case 1:
				smethod_134(smethod_133(smethod_27(this)), smethod_16(this));
				goto case 15;
			case 207:
				return;
			}
			break;
		}
		goto IL_003d;
		IL_0710:
		smethod_21(smethod_18(this), "Width(0)");
		goto IL_0720;
		IL_058d:
		smethod_102(smethod_22(this), "MapH");
		goto IL_059d;
		IL_055a:
		smethod_101(smethod_22(this), new Point(783, 5));
		goto IL_0570;
		IL_0703:
		smethod_105(smethod_18(this), 9);
		goto IL_0710;
		IL_0580:
		smethod_111(smethod_22(this), 50);
		goto IL_058d;
		IL_0076:
		smethod_101(smethod_18(this), new Point(443, 9));
		goto IL_008d;
		IL_05c6:
		smethod_17(smethod_16(this), 50);
		goto IL_003d;
		IL_0049:
		smethod_95(smethod_18(this), (object)new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		goto IL_0066;
		IL_059d:
		smethod_112(smethod_22(this), (RightToLeft)0);
		num = 77;
		if (smethod_5())
		{
			goto IL_05b9;
		}
		goto IL_105f;
		IL_05b9:
		smethod_114(smethod_16(this), 50);
		goto IL_05c6;
		IL_0066:
		smethod_120(smethod_18(this), smethod_96());
		goto IL_0076;
		IL_06c7:
		smethod_103(smethod_125(this), new Size(92, 23));
		goto IL_06db;
		IL_0720:
		smethod_92(smethod_22(this), (AnchorStyles)6);
		goto IL_072c;
		IL_008d:
		smethod_102(smethod_18(this), "lbl_MapW");
		goto IL_009d;
		IL_06e7:
		smethod_106(smethod_125(this), bool_5: false);
		num = 148;
		if (smethod_5())
		{
			goto IL_0703;
		}
		goto IL_105f;
		IL_0570:
		smethod_110(smethod_22(this), 800);
		goto IL_0580;
		IL_06a1:
		smethod_101(smethod_125(this), new Point(165, 4));
		goto IL_06b7;
		IL_0738:
		smethod_109(smethod_22(this), 100);
		goto IL_055a;
		IL_09cf:
		smethod_119(smethod_125(this), (FlatStyle)0);
		goto IL_0691;
		IL_0691:
		smethod_120(smethod_125(this), smethod_96());
		goto IL_06a1;
		IL_09be:
		smethod_118(smethod_117(smethod_125(this)), 0);
		goto IL_09cf;
		IL_06b7:
		smethod_102(smethod_125(this), "btn_SaveState");
		goto IL_06c7;
		IL_003d:
		smethod_129(smethod_18(this), bool_5: true);
		goto IL_0049;
		IL_072c:
		smethod_108(smethod_22(this), bool_5: false);
		goto IL_0738;
		IL_009d:
		smethod_103(smethod_18(this), new Size(55, 13));
		num = 18;
		if (smethod_5())
		{
		}
		goto IL_105f;
		IL_06db:
		smethod_105(smethod_125(this), 4);
		goto IL_06e7;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_1(Timer timer_1)
	{
		timer_0 = timer_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal virtual SaveFileDialog vmethod_2()
	{
		return saveFileDialog_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	internal virtual void vmethod_3(SaveFileDialog saveFileDialog_1)
	{
		saveFileDialog_0 = saveFileDialog_1;
	}

	internal static void smethod_0(object object_8)
	{
		((Form)object_8)._002Ector();
	}

	internal static void smethod_1(object object_8, object object_9)
	{
		((Form)object_8).add_Load((EventHandler)object_9);
	}

	internal static void smethod_2(object object_8, object object_9)
	{
		((Form)object_8).add_Shown((EventHandler)object_9);
	}

	internal static DateTime smethod_3()
	{
		return DateAndTime.get_TimeOfDay();
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static bool smethod_5()
	{
		return false;
	}

	internal static void smethod_6(object object_8)
	{
		((Thread)object_8).Start();
	}

	internal static void smethod_7()
	{
		Application.DoEvents();
	}

	internal static object smethod_8(object object_8)
	{
		return ((GForm0)object_8).ProgressBar1;
	}

	internal static void smethod_9(object object_8, int int_18)
	{
		((ProgressBar)object_8).set_Maximum(int_18);
	}

	internal static void smethod_10(object object_8, bool bool_5)
	{
		((Control)object_8).set_Visible(bool_5);
	}

	internal static void smethod_11(object object_8, int int_18)
	{
		((ProgressBar)object_8).set_Value(int_18);
	}

	internal static void smethod_12(object object_8, int int_18, int int_19, bool bool_5)
	{
		((bool[,])object_8)[int_18, int_19] = bool_5;
	}

	internal static void smethod_13(object object_8, int int_18, int int_19, int int_20)
	{
		((int[,])object_8)[int_18, int_19] = int_20;
	}

	internal static int smethod_14(object object_8)
	{
		return ((ProgressBar)object_8).get_Value();
	}

	internal static double smethod_15(double double_0)
	{
		return Math.Round(double_0);
	}

	internal static object smethod_16(object object_8)
	{
		return ((GForm0)object_8).MapW;
	}

	internal static void smethod_17(object object_8, int int_18)
	{
		((TrackBar)object_8).set_Value(int_18);
	}

	internal static object smethod_18(object object_8)
	{
		return ((GForm0)object_8).lbl_MapW;
	}

	internal static object smethod_19(int int_18)
	{
		return Conversions.ToString(int_18);
	}

	internal static object smethod_20(object object_8, object object_9, object object_10)
	{
		return (string?)object_8 + (string?)object_9 + (string?)object_10;
	}

	internal static void smethod_21(object object_8, object object_9)
	{
		((Label)object_8).set_Text((string)object_9);
	}

	internal static object smethod_22(object object_8)
	{
		return ((GForm0)object_8).MapH;
	}

	internal static object smethod_23(object object_8)
	{
		return ((GForm0)object_8).lbl_MapH;
	}

	internal static object smethod_24(object object_8)
	{
		return ((Control)object_8).CreateGraphics();
	}

	internal static int smethod_25(object object_8)
	{
		return ((Control)object_8).get_Width();
	}

	internal static int smethod_26(object object_8)
	{
		return ((Control)object_8).get_Height();
	}

	internal static object smethod_27(object object_8)
	{
		return ((GForm0)object_8).BottomPanel;
	}

	internal static int smethod_28(object object_8)
	{
		return ((Control)object_8).get_Height();
	}

	internal static bool smethod_29(object object_8, int int_18, int int_19)
	{
		return ((bool[,])object_8)[int_18, int_19];
	}

	internal static void smethod_30(object object_8, object object_9, object object_10, object object_11)
	{
		Class7.smethod_0(object_8, object_9, object_10, object_11);
	}

	internal static object smethod_31(object object_8, object object_9, object object_10, object object_11)
	{
		return Class7.smethod_2(object_8, object_9, object_10, object_11);
	}

	internal static int smethod_32(object object_8)
	{
		return Conversions.ToInteger((string)object_8);
	}

	internal static object smethod_33(object object_8)
	{
		return ((GForm0)object_8).Algorythm;
	}

	internal static void smethod_34(object object_8, object object_9)
	{
		((ComboBox)object_8).set_SelectedItem(object_9);
	}

	internal static bool smethod_35(object object_8)
	{
		return Conversions.ToBoolean((string)object_8);
	}

	internal static int smethod_36(object object_8, object object_9, bool bool_5)
	{
		return Operators.CompareString((string)object_8, (string)object_9, bool_5);
	}

	internal static Color smethod_37()
	{
		return Color.Blue;
	}

	internal static void smethod_38(object object_8, float float_0)
	{
		((Pen)object_8).set_Width(float_0);
	}

	internal static Color smethod_39()
	{
		return Color.Black;
	}

	internal static void smethod_40(object object_8, object object_9, int int_18, int int_19, int int_20, int int_21)
	{
		((Graphics)object_8).FillRectangle((Brush)object_9, int_18, int_19, int_20, int_21);
	}

	internal static object smethod_41(object object_8)
	{
		return ((GForm0)object_8).ShowGrid;
	}

	internal static bool smethod_42(object object_8)
	{
		return ((CheckBox)object_8).get_Checked();
	}

	internal static object smethod_43()
	{
		return Pens.get_DarkGray();
	}

	internal static void smethod_44(object object_8, object object_9, Point point_0, Point point_1)
	{
		((Graphics)object_8).DrawLine((Pen)object_9, point_0, point_1);
	}

	internal static object smethod_45()
	{
		return Pens.get_Blue();
	}

	internal static object smethod_46()
	{
		return Brushes.get_Green();
	}

	internal static void smethod_47(object object_8, object object_9, int int_18, int int_19, int int_20, int int_21)
	{
		((Graphics)object_8).FillEllipse((Brush)object_9, int_18, int_19, int_20, int_21);
	}

	internal static void smethod_48(object object_8, object object_9, int int_18, int int_19, int int_20, int int_21)
	{
		((Graphics)object_8).DrawRectangle((Pen)object_9, int_18, int_19, int_20, int_21);
	}

	internal static object smethod_49(object object_8)
	{
		return ((Control)object_8).get_Font();
	}

	internal static object smethod_50()
	{
		return Brushes.get_Red();
	}

	internal static PointF smethod_51(Point point_0)
	{
		return point_0;
	}

	internal static void smethod_52(object object_8, object object_9, object object_10, object object_11, PointF pointF_0)
	{
		((Graphics)object_8).DrawString((string)object_9, (Font)object_10, (Brush)object_11, pointF_0);
	}

	internal static object smethod_53(object object_8)
	{
		return Graphics.FromImage((Image)object_8);
	}

	internal static void smethod_54(object object_8, object object_9, int int_18, int int_19)
	{
		((Graphics)object_8).DrawImage((Image)object_9, int_18, int_19);
	}

	internal static Color smethod_55()
	{
		return Color.DarkRed;
	}

	internal static void smethod_56(object object_8, Color color_0)
	{
		((Graphics)object_8).Clear(color_0);
	}

	internal static Color smethod_57()
	{
		return Color.DarkGreen;
	}

	internal static object smethod_58(object object_8)
	{
		return ((GForm0)object_8).vmethod_2();
	}

	internal static void smethod_59(object object_8, object object_9)
	{
		((FileDialog)object_8).set_Filter((string)object_9);
	}

	internal static void smethod_60(object object_8, object object_9)
	{
		((FileDialog)object_8).set_FileName((string)object_9);
	}

	internal static DialogResult smethod_61(object object_8)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CommonDialog)object_8).ShowDialog();
	}

	internal static object smethod_62(object object_8)
	{
		return ((FileDialog)object_8).get_FileName();
	}

	internal static void smethod_63(object object_8, object object_9)
	{
		((ContainerControl)object_8).set_ActiveControl((Control)object_9);
	}

	internal static object smethod_64(object object_8)
	{
		return ((GForm0)object_8).OpenFileDialog1;
	}

	internal static bool smethod_65(object object_8)
	{
		return File.Exists((string?)object_8);
	}

	internal static void smethod_66(object object_8)
	{
		((IDisposable)object_8).Dispose();
	}

	internal static void smethod_67(object object_8, bool bool_5)
	{
		((Form)object_8).Dispose(bool_5);
	}

	internal static Type smethod_68(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void smethod_69(object object_8, object object_9)
	{
		((GForm0)object_8).vmethod_1((Timer)object_9);
	}

	internal static void smethod_70(object object_8, object object_9)
	{
		((GForm0)object_8).vmethod_3((SaveFileDialog)object_9);
	}

	internal static void smethod_71(object object_8, object object_9)
	{
		((GForm0)object_8).OpenFileDialog1 = (OpenFileDialog)object_9;
	}

	internal static void smethod_72(object object_8, object object_9)
	{
		((GForm0)object_8).Algorythm = (ComboBox)object_9;
	}

	internal static void smethod_73(object object_8, object object_9)
	{
		((GForm0)object_8).RenderSpeed = (TrackBar)object_9;
	}

	internal static void smethod_74(object object_8, object object_9)
	{
		((GForm0)object_8).btn_Save = (Button)object_9;
	}

	internal static void smethod_75(object object_8, object object_9)
	{
		((GForm0)object_8).btn_Load = (Button)object_9;
	}

	internal static void smethod_76(object object_8, object object_9)
	{
		((GForm0)object_8).ProgressBar1 = (ProgressBar)object_9;
	}

	internal static void smethod_77(object object_8, object object_9)
	{
		((GForm0)object_8).btn_SaveState = (Button)object_9;
	}

	internal static void smethod_78(object object_8, object object_9)
	{
		((GForm0)object_8).btn_LoadState = (Button)object_9;
	}

	internal static void smethod_79(object object_8, object object_9)
	{
		((GForm0)object_8).ShowGrid = (CheckBox)object_9;
	}

	internal static void smethod_80(object object_8, object object_9)
	{
		((GForm0)object_8).MapW = (TrackBar)object_9;
	}

	internal static void smethod_81(object object_8, object object_9)
	{
		((GForm0)object_8).lbl_MapW = (Label)object_9;
	}

	internal static void smethod_82(object object_8, object object_9)
	{
		((GForm0)object_8).MapH = (TrackBar)object_9;
	}

	internal static void smethod_83(object object_8, object object_9)
	{
		((GForm0)object_8).lbl_MapH = (Label)object_9;
	}

	internal static void smethod_84(object object_8, object object_9)
	{
		((GForm0)object_8).Label1 = (Label)object_9;
	}

	internal static void smethod_85(object object_8, object object_9)
	{
		((GForm0)object_8).BottomPanel = (Panel)object_9;
	}

	internal static object smethod_86(object object_8)
	{
		return ((GForm0)object_8).RenderSpeed;
	}

	internal static void smethod_87(object object_8)
	{
		((ISupportInitialize)object_8).BeginInit();
	}

	internal static void smethod_88(object object_8)
	{
		((Control)object_8).SuspendLayout();
	}

	internal static void smethod_89(object object_8)
	{
		((Control)object_8).SuspendLayout();
	}

	internal static object smethod_90(object object_8)
	{
		return ((GForm0)object_8).vmethod_0();
	}

	internal static void smethod_91(object object_8, int int_18)
	{
		((Timer)object_8).set_Interval(int_18);
	}

	internal static void smethod_92(object object_8, AnchorStyles anchorStyles_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_8).set_Anchor(anchorStyles_0);
	}

	internal static Color smethod_93(int int_18, int int_19, int int_20)
	{
		return Color.FromArgb(int_18, int_19, int_20);
	}

	internal static void smethod_94(object object_8, Color color_0)
	{
		((ComboBox)object_8).set_BackColor(color_0);
	}

	internal static void smethod_95(object object_8, object object_9)
	{
		((Control)object_8).set_Font((Font)object_9);
	}

	internal static Color smethod_96()
	{
		return Color.White;
	}

	internal static void smethod_97(object object_8, Color color_0)
	{
		((ComboBox)object_8).set_ForeColor(color_0);
	}

	internal static void smethod_98(object object_8, bool bool_5)
	{
		((ListControl)object_8).set_FormattingEnabled(bool_5);
	}

	internal static object smethod_99(object object_8)
	{
		return ((ComboBox)object_8).get_Items();
	}

	internal static void smethod_100(object object_8, object object_9)
	{
		((ObjectCollection)object_8).AddRange((object[])object_9);
	}

	internal static void smethod_101(object object_8, Point point_0)
	{
		((Control)object_8).set_Location(point_0);
	}

	internal static void smethod_102(object object_8, object object_9)
	{
		((Control)object_8).set_Name((string)object_9);
	}

	internal static void smethod_103(object object_8, Size size_0)
	{
		((Control)object_8).set_Size(size_0);
	}

	internal static void smethod_104(object object_8, bool bool_5)
	{
		((ComboBox)object_8).set_Sorted(bool_5);
	}

	internal static void smethod_105(object object_8, int int_18)
	{
		((Control)object_8).set_TabIndex(int_18);
	}

	internal static void smethod_106(object object_8, bool bool_5)
	{
		((Control)object_8).set_TabStop(bool_5);
	}

	internal static void smethod_107(object object_8, object object_9)
	{
		((ComboBox)object_8).set_Text((string)object_9);
	}

	internal static void smethod_108(object object_8, bool bool_5)
	{
		((TrackBar)object_8).set_AutoSize(bool_5);
	}

	internal static void smethod_109(object object_8, int int_18)
	{
		((TrackBar)object_8).set_LargeChange(int_18);
	}

	internal static void smethod_110(object object_8, int int_18)
	{
		((TrackBar)object_8).set_Maximum(int_18);
	}

	internal static void smethod_111(object object_8, int int_18)
	{
		((TrackBar)object_8).set_Minimum(int_18);
	}

	internal static void smethod_112(object object_8, RightToLeft rightToLeft_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_8).set_RightToLeft(rightToLeft_0);
	}

	internal static void smethod_113(object object_8, int int_18)
	{
		((TrackBar)object_8).set_SmallChange(int_18);
	}

	internal static void smethod_114(object object_8, int int_18)
	{
		((TrackBar)object_8).set_TickFrequency(int_18);
	}

	internal static object smethod_115(object object_8)
	{
		return ((GForm0)object_8).btn_Save;
	}

	internal static void smethod_116(object object_8, Color color_0)
	{
		((ButtonBase)object_8).set_BackColor(color_0);
	}

	internal static object smethod_117(object object_8)
	{
		return ((ButtonBase)object_8).get_FlatAppearance();
	}

	internal static void smethod_118(object object_8, int int_18)
	{
		((FlatButtonAppearance)object_8).set_BorderSize(int_18);
	}

	internal static void smethod_119(object object_8, FlatStyle flatStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)object_8).set_FlatStyle(flatStyle_0);
	}

	internal static void smethod_120(object object_8, Color color_0)
	{
		((Control)object_8).set_ForeColor(color_0);
	}

	internal static void smethod_121(object object_8, object object_9)
	{
		((ButtonBase)object_8).set_Text((string)object_9);
	}

	internal static void smethod_122(object object_8, bool bool_5)
	{
		((ButtonBase)object_8).set_UseVisualStyleBackColor(bool_5);
	}

	internal static object smethod_123(object object_8)
	{
		return ((GForm0)object_8).btn_Load;
	}

	internal static Color smethod_124()
	{
		return Color.Green;
	}

	internal static object smethod_125(object object_8)
	{
		return ((GForm0)object_8).btn_SaveState;
	}

	internal static object smethod_126(object object_8)
	{
		return ((GForm0)object_8).btn_LoadState;
	}

	internal static void smethod_127(object object_8, bool bool_5)
	{
		((ButtonBase)object_8).set_AutoSize(bool_5);
	}

	internal static void smethod_128(object object_8, bool bool_5)
	{
		((TrackBar)object_8).set_RightToLeftLayout(bool_5);
	}

	internal static void smethod_129(object object_8, bool bool_5)
	{
		((Label)object_8).set_AutoSize(bool_5);
	}

	internal static object smethod_130(object object_8)
	{
		return ((GForm0)object_8).Label1;
	}

	internal static Color smethod_131()
	{
		return SystemColors.ControlDarkDark;
	}

	internal static void smethod_132(object object_8, Color color_0)
	{
		((Control)object_8).set_BackColor(color_0);
	}

	internal static object smethod_133(object object_8)
	{
		return ((Control)object_8).get_Controls();
	}

	internal static void smethod_134(object object_8, object object_9)
	{
		((ControlCollection)object_8).Add((Control)object_9);
	}

	internal static void smethod_135(object object_8, SizeF sizeF_0)
	{
		((ContainerControl)object_8).set_AutoScaleDimensions(sizeF_0);
	}

	internal static void smethod_136(object object_8, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_8).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static void smethod_137(object object_8, Size size_0)
	{
		((Form)object_8).set_ClientSize(size_0);
	}

	internal static object smethod_138(object object_8)
	{
		return ((Control)object_8).get_Controls();
	}

	internal static object smethod_139(object object_8, object object_9)
	{
		return ((ResourceManager)object_8).GetObject((string)object_9);
	}

	internal static void smethod_140(object object_8, object object_9)
	{
		((Form)object_8).set_Icon((Icon)object_9);
	}

	internal static void smethod_141(object object_8, Size size_0)
	{
		((Form)object_8).set_MinimumSize(size_0);
	}

	internal static void smethod_142(object object_8, object object_9)
	{
		((Control)object_8).set_Name((string)object_9);
	}

	internal static void smethod_143(object object_8, double double_0)
	{
		((Form)object_8).set_Opacity(double_0);
	}

	internal static void smethod_144(object object_8, bool bool_5)
	{
		((Form)object_8).set_ShowInTaskbar(bool_5);
	}

	internal static void smethod_145(object object_8, object object_9)
	{
		((Form)object_8).set_Text((string)object_9);
	}

	internal static void smethod_146(object object_8)
	{
		((ISupportInitialize)object_8).EndInit();
	}

	internal static void smethod_147(object object_8, bool bool_5)
	{
		((Control)object_8).ResumeLayout(bool_5);
	}

	internal static void smethod_148(object object_8)
	{
		((Control)object_8).PerformLayout();
	}

	internal static void smethod_149(object object_8, bool bool_5)
	{
		((Control)object_8).ResumeLayout(bool_5);
	}

	internal static void smethod_150(object object_8, object object_9)
	{
		((Control)object_8).remove_Click((EventHandler)object_9);
	}

	internal static void smethod_151(object object_8, object object_9)
	{
		((Control)object_8).add_Click((EventHandler)object_9);
	}
}
