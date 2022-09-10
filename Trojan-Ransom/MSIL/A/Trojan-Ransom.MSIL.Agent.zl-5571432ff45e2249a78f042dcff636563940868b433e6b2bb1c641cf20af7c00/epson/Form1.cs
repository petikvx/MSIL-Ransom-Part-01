using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace epson;

public class Form1 : Form
{
	private IContainer components = null;

	private Button button1;

	private WebBrowser webBrowser1;

	private Button button2;

	private Button button3;

	private Button button4;

	private DateTimePicker dateTimePicker1;

	private Timer timer1;

	private WebBrowser webBrowser2;

	private Timer timer2;

	public Form1()
	{
		InitializeComponent();
		Console.WriteLine("Enter two integers \n");
		int num = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine("\n Before swapping i= {0} and k = {1}", num, num2);
		num ^= num2;
		num2 = num ^ num2;
		num ^= num2;
		Console.WriteLine("\n After swapping i= {0} and k = {1}", num, num2);
		Console.ReadLine();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		webBrowser1.Navigate("https://www.facebook.com/lechwalesa/");
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		webBrowser2.Navigate("https://kwejk.pl/losuj");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		components = new Container();
		button1 = new Button();
		webBrowser1 = new WebBrowser();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		dateTimePicker1 = new DateTimePicker();
		timer1 = new Timer(components);
		webBrowser2 = new WebBrowser();
		timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(107, 68));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(156, 126));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)webBrowser1).set_Location(new Point(319, 41));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(250, 250));
		((Control)webBrowser1).set_TabIndex(1);
		((Control)button2).set_Location(new Point(201, 22));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(134, 211));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(76, 267));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(222, 23));
		((Control)button4).set_TabIndex(4);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)dateTimePicker1).set_Location(new Point(98, 226));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 22));
		((Control)dateTimePicker1).set_TabIndex(5);
		timer1.set_Enabled(true);
		timer1.set_Interval(5000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)webBrowser2).set_Location(new Point(76, 41));
		((Control)webBrowser2).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser2).set_Name("webBrowser2");
		((Control)webBrowser2).set_Size(new Size(250, 250));
		((Control)webBrowser2).set_TabIndex(6);
		timer2.set_Enabled(true);
		timer2.set_Interval(5000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(676, 333));
		((Control)this).get_Controls().Add((Control)(object)webBrowser2);
		((Control)this).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
