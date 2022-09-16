using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData;

[DesignerGenerated]
public class mainRunner : Form
{
	private IContainer components;

	internal virtual Timer webserverCheckTimer
	{
		[CompilerGenerated]
		get
		{
			return _webserverCheckTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = WebserverCheckTimer_Tick;
			Timer val = _webserverCheckTimer;
			if (val != null)
			{
				mainRunner.smethod_13(val, eventHandler_);
			}
			_webserverCheckTimer = value;
			val = _webserverCheckTimer;
			if (val != null)
			{
				mainRunner.smethod_14(val, eventHandler_);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				mainRunner.smethod_13(timer, eventHandler_);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				mainRunner.smethod_14(timer, eventHandler_);
			}
		}
	}

	public mainRunner()
	{
		mainRunner.smethod_0((Form)(object)this, (EventHandler)MainRunner_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				mainRunner.smethod_1((IDisposable)components);
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
		components = mainRunner.smethod_2();
		webserverCheckTimer = mainRunner.smethod_3(components);
		Timer1 = mainRunner.smethod_3(components);
		mainRunner.smethod_4((Control)(object)this);
		mainRunner.smethod_5(webserverCheckTimer, bool_0: true);
		mainRunner.smethod_6(webserverCheckTimer, 15000);
		mainRunner.smethod_5(Timer1, bool_0: true);
		mainRunner.smethod_7((ContainerControl)(object)this, new SizeF(6f, 13f));
		mainRunner.smethod_8((ContainerControl)(object)this, (AutoScaleMode)1);
		mainRunner.smethod_9((Form)(object)this, new Size(254, 147));
		mainRunner.smethod_10((Control)(object)this, "mainRunner");
		mainRunner.smethod_11((Form)(object)this, "mainRunner");
		mainRunner.smethod_12((Control)(object)this, bool_0: false);
	}

	private void MainRunner_Load(object sender, EventArgs e)
	{
		runningWSCheck();
	}

	public void runningWSCheck()
	{
		Dictionary<string, string> dictionary = serverCommunicate.currentStatusfromServer();
		if (!mainRunner.smethod_15(dictionary["allowLogin"]))
		{
			mainRunner.smethod_16(webserverCheckTimer);
			Form1 dial = new Form1();
			serverCommunicate.showAlert(dial);
		}
	}

	private void WebserverCheckTimer_Tick(object sender, EventArgs e)
	{
		runningWSCheck();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		mainRunner.smethod_17((Control)(object)this);
		mainRunner.smethod_16(Timer1);
	}

	static void smethod_0(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_2()
	{
		return new Container();
	}

	static Timer smethod_3(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static void smethod_4(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_5(Timer timer_0, bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
	}

	static void smethod_6(Timer timer_0, int int_0)
	{
		timer_0.set_Interval(int_0);
	}

	static void smethod_7(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_8(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_9(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static void smethod_10(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_11(Form form_0, string string_0)
	{
		form_0.set_Text(string_0);
	}

	static void smethod_12(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_13(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.remove_Tick(eventHandler_0);
	}

	static void smethod_14(Timer timer_0, EventHandler eventHandler_0)
	{
		timer_0.add_Tick(eventHandler_0);
	}

	static bool smethod_15(string string_0)
	{
		return Conversions.ToBoolean(string_0);
	}

	static void smethod_16(Timer timer_0)
	{
		timer_0.Stop();
	}

	static void smethod_17(Control control_0)
	{
		control_0.Hide();
	}
}
