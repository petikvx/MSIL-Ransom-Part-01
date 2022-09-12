using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	internal virtual GroupBox GroupBox1
	{
		[CompilerGenerated]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = GroupBox1_Enter;
			GroupBox groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).remove_Enter(eventHandler);
			}
			_GroupBox1 = value;
			groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).add_Enter(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label3_Click;
			Label label = _Label3;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label30")]
	internal virtual Label Label30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label33")]
	internal virtual Label Label33
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Label5_Click;
			Label label = _Label5;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label5 = value;
			label = _Label5;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label35")]
	internal virtual Label Label35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label36")]
	internal virtual Label Label36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label37")]
	internal virtual Label Label37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label38")]
	internal virtual Label Label38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label39")]
	internal virtual Label Label39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label40")]
	internal virtual Label Label40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected O, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected O, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected O, but got Unknown
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected O, but got Unknown
		//IL_0e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected O, but got Unknown
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected O, but got Unknown
		//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Expected O, but got Unknown
		//IL_1004: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Expected O, but got Unknown
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ad: Expected O, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected O, but got Unknown
		//IL_11e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Expected O, but got Unknown
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_128a: Expected O, but got Unknown
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected O, but got Unknown
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Expected O, but got Unknown
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Expected O, but got Unknown
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_167a: Expected O, but got Unknown
		//IL_1713: Unknown result type (might be due to invalid IL or missing references)
		//IL_171d: Expected O, but got Unknown
		//IL_17b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c0: Expected O, but got Unknown
		//IL_1856: Unknown result type (might be due to invalid IL or missing references)
		//IL_1860: Expected O, but got Unknown
		//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1900: Expected O, but got Unknown
		//IL_1996: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a0: Expected O, but got Unknown
		//IL_1a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a40: Expected O, but got Unknown
		//IL_1ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae0: Expected O, but got Unknown
		//IL_1b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Expected O, but got Unknown
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9a: Expected O, but got Unknown
		//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3d: Expected O, but got Unknown
		//IL_1dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddf: Expected O, but got Unknown
		//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e76: Expected O, but got Unknown
		//IL_1eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef6: Expected O, but got Unknown
		//IL_1f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f95: Expected O, but got Unknown
		//IL_201e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2028: Expected O, but got Unknown
		//IL_20c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20cb: Expected O, but got Unknown
		//IL_214b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2155: Expected O, but got Unknown
		//IL_22eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		GroupBox1 = new GroupBox();
		Label40 = new Label();
		GroupBox3 = new GroupBox();
		Label23 = new Label();
		Label24 = new Label();
		Label25 = new Label();
		Label26 = new Label();
		Label27 = new Label();
		Label28 = new Label();
		Label29 = new Label();
		Label30 = new Label();
		Label31 = new Label();
		Label32 = new Label();
		Label33 = new Label();
		Label11 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		GroupBox2 = new GroupBox();
		Label22 = new Label();
		Label21 = new Label();
		Label20 = new Label();
		Label19 = new Label();
		Label18 = new Label();
		Label17 = new Label();
		Label16 = new Label();
		Label15 = new Label();
		Label14 = new Label();
		Label13 = new Label();
		Label12 = new Label();
		GroupBox4 = new GroupBox();
		Label34 = new Label();
		TextBox1 = new TextBox();
		Label35 = new Label();
		TextBox2 = new TextBox();
		Label36 = new Label();
		Label37 = new Label();
		Label38 = new Label();
		Label39 = new Label();
		Button1 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.ActiveBorder);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label40);
		((Control)GroupBox1).get_Controls().Add((Control)(object)GroupBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_ForeColor(Color.Transparent);
		((Control)GroupBox1).set_Location(new Point(12, 12));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(241, 201));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		Label40.set_AutoSize(true);
		((Control)Label40).set_BackColor(Color.Transparent);
		((Control)Label40).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label40).set_ForeColor(Color.Black);
		((Control)Label40).set_Location(new Point(6, 176));
		((Control)Label40).set_Name("Label40");
		((Control)Label40).set_Size(new Size(127, 16));
		((Control)Label40).set_TabIndex(20);
		Label40.set_Text("como Cartões e etc.");
		((Control)GroupBox3).set_BackColor(SystemColors.ActiveBorder);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label23);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label24);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label25);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label26);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label27);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label28);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label29);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label30);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label31);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label32);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label33);
		((Control)GroupBox3).set_Location(new Point(158, 306));
		((Control)GroupBox3).set_Name("GroupBox3");
		((Control)GroupBox3).set_Size(new Size(204, 90));
		((Control)GroupBox3).set_TabIndex(19);
		GroupBox3.set_TabStop(false);
		Label23.set_AutoSize(true);
		((Control)Label23).set_BackColor(Color.Transparent);
		((Control)Label23).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label23).set_ForeColor(Color.Black);
		((Control)Label23).set_Location(new Point(6, 176));
		((Control)Label23).set_Name("Label23");
		((Control)Label23).set_Size(new Size(143, 16));
		((Control)Label23).set_TabIndex(18);
		Label23.set_Text("livres de nossas mãos");
		Label24.set_AutoSize(true);
		((Control)Label24).set_BackColor(Color.Transparent);
		((Control)Label24).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label24).set_ForeColor(Color.Black);
		((Control)Label24).set_Location(new Point(6, 160));
		((Control)Label24).set_Name("Label24");
		((Control)Label24).set_Size(new Size(220, 16));
		((Control)Label24).set_TabIndex(18);
		Label24.set_Text("e você tera seus arquivos e senhas");
		Label25.set_AutoSize(true);
		((Control)Label25).set_BackColor(Color.Transparent);
		((Control)Label25).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label25).set_ForeColor(Color.Black);
		((Control)Label25).set_Location(new Point(6, 144));
		((Control)Label25).set_Name("Label25");
		((Control)Label25).set_Size(new Size(235, 16));
		((Control)Label25).set_TabIndex(17);
		Label25.set_Text("endereço, confirmaremos a transação");
		Label26.set_AutoSize(true);
		((Control)Label26).set_BackColor(Color.Transparent);
		((Control)Label26).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label26).set_ForeColor(Color.Black);
		((Control)Label26).set_Location(new Point(5, 128));
		((Control)Label26).set_Name("Label26");
		((Control)Label26).set_Size(new Size(191, 16));
		((Control)Label26).set_TabIndex(16);
		Label26.set_Text("após enviar os bitcoins para o ");
		Label27.set_AutoSize(true);
		((Control)Label27).set_BackColor(Color.Transparent);
		((Control)Label27).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label27).set_ForeColor(Color.Black);
		((Control)Label27).set_Location(new Point(5, 112));
		((Control)Label27).set_Name("Label27");
		((Control)Label27).set_Size(new Size(229, 16));
		((Control)Label27).set_TabIndex(15);
		Label27.set_Text("https://blockchain.info/wallet/#/signup");
		Label28.set_AutoSize(true);
		((Control)Label28).set_BackColor(Color.Transparent);
		((Control)Label28).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label28).set_ForeColor(Color.Black);
		((Control)Label28).set_Location(new Point(5, 96));
		((Control)Label28).set_Name("Label28");
		((Control)Label28).set_Size(new Size(239, 16));
		((Control)Label28).set_TabIndex(14);
		Label28.set_Text("comprar Bitcoins com dinheiro real em:");
		Label29.set_AutoSize(true);
		((Control)Label29).set_BackColor(Color.Transparent);
		((Control)Label29).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label29).set_ForeColor(Color.Black);
		((Control)Label29).set_Location(new Point(5, 80));
		((Control)Label29).set_Name("Label29");
		((Control)Label29).set_Size(new Size(206, 16));
		((Control)Label29).set_TabIndex(13);
		Label29.set_Text("para doar a quantia você precisa");
		Label30.set_AutoSize(true);
		((Control)Label30).set_BackColor(Color.Transparent);
		((Control)Label30).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label30).set_ForeColor(Color.Black);
		((Control)Label30).set_Location(new Point(6, 64));
		((Control)Label30).set_Name("Label30");
		((Control)Label30).set_Size(new Size(210, 16));
		((Control)Label30).set_TabIndex(12);
		Label30.set_Text("R$100,00 para o endereço abaixo");
		Label31.set_AutoSize(true);
		((Control)Label31).set_BackColor(Color.Transparent);
		((Control)Label31).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label31).set_ForeColor(Color.Black);
		((Control)Label31).set_Location(new Point(6, 48));
		((Control)Label31).set_Name("Label31");
		((Control)Label31).set_Size(new Size(195, 16));
		((Control)Label31).set_TabIndex(11);
		Label31.set_Text("de 0.05 Bitcoins que em Reais=");
		Label32.set_AutoSize(true);
		((Control)Label32).set_BackColor(Color.Transparent);
		((Control)Label32).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label32).set_ForeColor(Color.Black);
		((Control)Label32).set_Location(new Point(6, 32));
		((Control)Label32).set_Name("Label32");
		((Control)Label32).set_Size(new Size(207, 16));
		((Control)Label32).set_TabIndex(10);
		Label32.set_Text("Você precisara doar uma quantia");
		Label33.set_AutoSize(true);
		((Control)Label33).set_BackColor(Color.Transparent);
		((Control)Label33).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label33).set_ForeColor(Color.Black);
		((Control)Label33).set_Location(new Point(27, 16));
		((Control)Label33).set_Name("Label33");
		((Control)Label33).set_Size(new Size(95, 16));
		((Control)Label33).set_TabIndex(10);
		Label33.set_Text("O que fazer?");
		Label11.set_AutoSize(true);
		((Control)Label11).set_BackColor(Color.Transparent);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.Black);
		((Control)Label11).set_Location(new Point(6, 160));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(188, 16));
		((Control)Label11).set_TabIndex(9);
		Label11.set_Text("dentre outras coisas pessoais");
		Label10.set_AutoSize(true);
		((Control)Label10).set_BackColor(Color.Transparent);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.Black);
		((Control)Label10).set_Location(new Point(6, 144));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(201, 16));
		((Control)Label10).set_TabIndex(8);
		Label10.set_Text("senhas, documentos e arquivos ");
		Label9.set_AutoSize(true);
		((Control)Label9).set_BackColor(Color.Transparent);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.Black);
		((Control)Label9).set_Location(new Point(5, 128));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(236, 16));
		((Control)Label9).set_TabIndex(7);
		Label9.set_Text("nos temos todos seus dados inclusive");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Black);
		((Control)Label8).set_Location(new Point(4, 138));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(0, 16));
		((Control)Label8).set_TabIndex(6);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Black);
		((Control)Label7).set_Location(new Point(6, 112));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(234, 16));
		((Control)Label7).set_TabIndex(5);
		Label7.set_Text("praticamente impossivel de recuperar");
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Black);
		((Control)Label6).set_Location(new Point(6, 96));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(217, 16));
		((Control)Label6).set_TabIndex(4);
		Label6.set_Text(".locked e com a hash SHA256SUM");
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Black);
		((Control)Label5).set_Location(new Point(5, 80));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(224, 16));
		((Control)Label5).set_TabIndex(4);
		Label5.set_Text("todos arquivos estao com extensao ");
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Black);
		((Control)Label4).set_Location(new Point(6, 64));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(200, 16));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("e criptografados pela DeadSec ");
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Black);
		((Control)Label3).set_Location(new Point(6, 48));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(225, 16));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("e todos seus dados foram roubados");
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Black);
		((Control)Label2).set_Location(new Point(6, 32));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(209, 16));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Você foi vitma de um ransomware");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Black);
		((Control)Label1).set_Location(new Point(16, 16));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(147, 16));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Porque recebi isso?");
		((Control)GroupBox2).set_BackColor(SystemColors.ActiveBorder);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label22);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label21);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label20);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label19);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label18);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label17);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label16);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label15);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label14);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox2).set_ForeColor(Color.Transparent);
		((Control)GroupBox2).set_Location(new Point(271, 12));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(256, 201));
		((Control)GroupBox2).set_TabIndex(1);
		GroupBox2.set_TabStop(false);
		Label22.set_AutoSize(true);
		((Control)Label22).set_BackColor(Color.Transparent);
		((Control)Label22).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label22).set_ForeColor(Color.Black);
		((Control)Label22).set_Location(new Point(6, 176));
		((Control)Label22).set_Name("Label22");
		((Control)Label22).set_Size(new Size(220, 16));
		((Control)Label22).set_TabIndex(18);
		Label22.set_Text("e você tera seus arquivos e senhas");
		Label21.set_AutoSize(true);
		((Control)Label21).set_BackColor(Color.Transparent);
		((Control)Label21).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label21).set_ForeColor(Color.Black);
		((Control)Label21).set_Location(new Point(6, 160));
		((Control)Label21).set_Name("Label21");
		((Control)Label21).set_Size(new Size(251, 16));
		((Control)Label21).set_TabIndex(18);
		Label21.set_Text("e enviaremos uma chave para seu email");
		Label20.set_AutoSize(true);
		((Control)Label20).set_BackColor(Color.Transparent);
		((Control)Label20).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label20).set_ForeColor(Color.Black);
		((Control)Label20).set_Location(new Point(6, 144));
		((Control)Label20).set_Name("Label20");
		((Control)Label20).set_Size(new Size(235, 16));
		((Control)Label20).set_TabIndex(17);
		Label20.set_Text("endereço, confirmaremos a transação");
		Label19.set_AutoSize(true);
		((Control)Label19).set_BackColor(Color.Transparent);
		((Control)Label19).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label19).set_ForeColor(Color.Black);
		((Control)Label19).set_Location(new Point(5, 128));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Size(new Size(191, 16));
		((Control)Label19).set_TabIndex(16);
		Label19.set_Text("após enviar os bitcoins para o ");
		Label18.set_AutoSize(true);
		((Control)Label18).set_BackColor(Color.Transparent);
		((Control)Label18).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label18).set_ForeColor(Color.Black);
		((Control)Label18).set_Location(new Point(5, 112));
		((Control)Label18).set_Name("Label18");
		((Control)Label18).set_Size(new Size(218, 16));
		((Control)Label18).set_TabIndex(15);
		Label18.set_Text("https://www.mercadobitcoin.com.br/");
		Label17.set_AutoSize(true);
		((Control)Label17).set_BackColor(Color.Transparent);
		((Control)Label17).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label17).set_ForeColor(Color.Black);
		((Control)Label17).set_Location(new Point(5, 96));
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_Size(new Size(239, 16));
		((Control)Label17).set_TabIndex(14);
		Label17.set_Text("comprar Bitcoins com dinheiro real em:");
		Label16.set_AutoSize(true);
		((Control)Label16).set_BackColor(Color.Transparent);
		((Control)Label16).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label16).set_ForeColor(Color.Black);
		((Control)Label16).set_Location(new Point(5, 80));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(206, 16));
		((Control)Label16).set_TabIndex(13);
		Label16.set_Text("para doar a quantia você precisa");
		Label15.set_AutoSize(true);
		((Control)Label15).set_BackColor(Color.Transparent);
		((Control)Label15).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label15).set_ForeColor(Color.Black);
		((Control)Label15).set_Location(new Point(6, 64));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(214, 16));
		((Control)Label15).set_TabIndex(12);
		Label15.set_Text("R$100,00 para o Endereço abaixo,");
		Label14.set_AutoSize(true);
		((Control)Label14).set_BackColor(Color.Transparent);
		((Control)Label14).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_ForeColor(Color.Black);
		((Control)Label14).set_Location(new Point(6, 48));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(195, 16));
		((Control)Label14).set_TabIndex(11);
		Label14.set_Text("de 0.05 Bitcoins que em Reais=");
		Label13.set_AutoSize(true);
		((Control)Label13).set_BackColor(Color.Transparent);
		((Control)Label13).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_ForeColor(Color.Black);
		((Control)Label13).set_Location(new Point(6, 32));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(207, 16));
		((Control)Label13).set_TabIndex(10);
		Label13.set_Text("Você precisara doar uma quantia");
		Label12.set_AutoSize(true);
		((Control)Label12).set_BackColor(Color.Transparent);
		((Control)Label12).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_ForeColor(Color.Black);
		((Control)Label12).set_Location(new Point(48, 16));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(95, 16));
		((Control)Label12).set_TabIndex(10);
		Label12.set_Text("O que fazer?");
		((Control)GroupBox4).set_BackColor(Color.Red);
		((Control)GroupBox4).get_Controls().Add((Control)(object)Label34);
		((Control)GroupBox4).set_Location(new Point(9, 302));
		((Control)GroupBox4).set_Name("GroupBox4");
		((Control)GroupBox4).set_Size(new Size(518, 45));
		((Control)GroupBox4).set_TabIndex(2);
		GroupBox4.set_TabStop(false);
		Label34.set_AutoSize(true);
		((Control)Label34).set_BackColor(Color.Transparent);
		((Control)Label34).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label34).set_ForeColor(Color.Black);
		((Control)Label34).set_Location(new Point(5, 16));
		((Control)Label34).set_Name("Label34");
		((Control)Label34).set_Size(new Size(498, 16));
		((Control)Label34).set_TabIndex(20);
		Label34.set_Text("Caso nao envie a quantia em 1 Semana, vazaremos todos seus dados.");
		((TextBoxBase)TextBox1).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TextBox1).set_Location(new Point(244, 266));
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		((Control)TextBox1).set_Size(new Size(284, 21));
		((Control)TextBox1).set_TabIndex(3);
		TextBox1.set_Text("1Mx4Zgz5nYmFppSUS6TbF2SfVP4xfcghBu");
		Label35.set_AutoSize(true);
		((Control)Label35).set_BackColor(Color.Transparent);
		((Control)Label35).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label35).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label35).set_Location(new Point(150, 266));
		((Control)Label35).set_Name("Label35");
		((Control)Label35).set_Size(new Size(91, 20));
		((Control)Label35).set_TabIndex(4);
		Label35.set_Text("Endereço:");
		((TextBoxBase)TextBox2).set_BackColor(SystemColors.ScrollBar);
		((Control)TextBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TextBox2).set_Location(new Point(67, 266));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(84, 21));
		((Control)TextBox2).set_TabIndex(5);
		Label36.set_AutoSize(true);
		((Control)Label36).set_BackColor(Color.Transparent);
		((Control)Label36).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label36).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label36).set_Location(new Point(5, 266));
		((Control)Label36).set_Name("Label36");
		((Control)Label36).set_Size(new Size(64, 20));
		((Control)Label36).set_TabIndex(6);
		Label36.set_Text("Chave:");
		Label37.set_AutoSize(true);
		((Control)Label37).set_BackColor(Color.Teal);
		((Control)Label37).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label37).set_ForeColor(Color.Aqua);
		((Control)Label37).set_Location(new Point(196, 232));
		((Control)Label37).set_Name("Label37");
		((Control)Label37).set_Size(new Size(90, 20));
		((Control)Label37).set_TabIndex(7);
		Label37.set_Text("1 Semana");
		Label38.set_AutoSize(true);
		((Control)Label38).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label38).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label38).set_Location(new Point(15, 232));
		((Control)Label38).set_Name("Label38");
		((Control)Label38).set_Size(new Size(180, 20));
		((Control)Label38).set_TabIndex(7);
		Label38.set_Text("Você tem o prazo de:");
		Label39.set_AutoSize(true);
		((Control)Label39).set_BackColor(Color.Transparent);
		((Control)Label39).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label39).set_ForeColor(Color.Blue);
		((Control)Label39).set_Location(new Point(287, 232));
		((Control)Label39).set_Name("Label39");
		((Control)Label39).set_Size(new Size(229, 20));
		((Control)Label39).set_TabIndex(8);
		Label39.set_Text("thecracker0day@gmail.com");
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.Black);
		((Control)Button1).set_Location(new Point(128, 357));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(253, 32));
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Confirmar");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DarkCyan);
		((Form)this).set_ClientSize(new Size(538, 405));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label39);
		((Control)this).get_Controls().Add((Control)(object)Label38);
		((Control)this).get_Controls().Add((Control)(object)Label37);
		((Control)this).get_Controls().Add((Control)(object)Label36);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label35);
		((Control)this).get_Controls().Add((Control)(object)GroupBox4);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_ForeColor(SystemColors.ActiveCaption);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("DeadSec-Crypto v2.1");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox4).ResumeLayout(false);
		((Control)GroupBox4).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Label3_Click(object sender, EventArgs e)
	{
	}

	private void Label5_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Chave para Recuperação Inválida");
	}

	private void GroupBox1_Enter(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}
}
