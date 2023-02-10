using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using t8C;

namespace c1F9;

[DesignerGenerated]
public class Xd8b : Form
{
	private IContainer components;

	private object crrYera;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("lblAmt")]
	internal virtual Label lblAmt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblphone")]
	internal virtual Label lblphone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAcady")]
	internal virtual Label lblAcady
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblClass")]
	internal virtual Label lblClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGnder")]
	internal virtual Label lblGnder
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSurn")]
	internal virtual Label lblSurn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblFname")]
	internal virtual Label lblFname
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

	[field: AccessedThroughProperty("Panel15")]
	internal virtual Panel Panel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k6C5;
			Button button = _Button7;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button6")]
	internal virtual Button Button6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xm32;
			Button button = _Button8;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblReg")]
	internal virtual Label lblReg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Xd8b()
	{
		((Form)this).add_Load((EventHandler)a3GT);
		crrYera = DateTime.Now.ToString("yyyy");
		Bk95();
	}

	[DebuggerNonUserCode]
	protected override void Fw24(bool Dy9p)
	{
		try
		{
			if (Dy9p && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Dy9p);
		}
	}

	[DebuggerStepThrough]
	private void Bk95()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected O, but got Unknown
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected O, but got Unknown
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected O, but got Unknown
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected O, but got Unknown
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Expected O, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected O, but got Unknown
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected O, but got Unknown
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected O, but got Unknown
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Expected O, but got Unknown
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected O, but got Unknown
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Expected O, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Expected O, but got Unknown
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_137d: Expected O, but got Unknown
		//IL_1444: Unknown result type (might be due to invalid IL or missing references)
		//IL_144e: Expected O, but got Unknown
		//IL_157f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1589: Expected O, but got Unknown
		//IL_15ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b6: Expected O, but got Unknown
		//IL_1685: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Expected O, but got Unknown
		//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bc: Expected O, but got Unknown
		//IL_178c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1796: Expected O, but got Unknown
		//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c3: Expected O, but got Unknown
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		//IL_189b: Expected O, but got Unknown
		//IL_1940: Unknown result type (might be due to invalid IL or missing references)
		//IL_194a: Expected O, but got Unknown
		//IL_19ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Xd8b));
		Panel1 = new Panel();
		Label9 = new Label();
		Panel2 = new Panel();
		Label8 = new Label();
		Panel3 = new Panel();
		Panel4 = new Panel();
		Panel5 = new Panel();
		Panel6 = new Panel();
		Panel7 = new Panel();
		Panel8 = new Panel();
		Panel9 = new Panel();
		Panel10 = new Panel();
		Panel11 = new Panel();
		Panel12 = new Panel();
		Panel13 = new Panel();
		Panel14 = new Panel();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		lblAmt = new Label();
		lblphone = new Label();
		lblAcady = new Label();
		lblClass = new Label();
		lblGnder = new Label();
		lblSurn = new Label();
		lblFname = new Label();
		Panel15 = new Panel();
		Button7 = new Button();
		Button4 = new Button();
		Button2 = new Button();
		Button1 = new Button();
		PictureBox1 = new PictureBox();
		Button3 = new Button();
		Button5 = new Button();
		Button6 = new Button();
		Button8 = new Button();
		Label11 = new Label();
		lblReg = new Label();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel7).SuspendLayout();
		((Control)Panel15).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.Navy);
		((Control)Panel1).get_Controls().Add((Control)(object)Button8);
		((Control)Panel1).get_Controls().Add((Control)(object)Label9);
		((Control)Panel1).set_Dock((DockStyle)1);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(953, 47));
		((Control)Panel1).set_TabIndex(0);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(18, 9));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(147, 22));
		((Control)Label9).set_TabIndex(19);
		Label9.set_Text("Student Profile");
		((Control)Panel2).set_BackColor(Color.Navy);
		((Control)Panel2).get_Controls().Add((Control)(object)Label8);
		((Control)Panel2).set_Location(new Point(286, 62));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(659, 51));
		((Control)Panel2).set_TabIndex(2);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.White);
		((Control)Label8).set_Location(new Point(27, 14));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(193, 22));
		((Control)Label8).set_TabIndex(18);
		Label8.set_Text("Student Information");
		((Control)Panel3).set_BackColor(Color.DimGray);
		((Control)Panel3).set_Location(new Point(286, 109));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(2, 369));
		((Control)Panel3).set_TabIndex(3);
		((Control)Panel4).set_BackColor(Color.Gray);
		((Control)Panel4).set_Location(new Point(941, 107));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(2, 369));
		((Control)Panel4).set_TabIndex(4);
		((Control)Panel5).set_BackColor(Color.DimGray);
		((Control)Panel5).set_Location(new Point(291, 158));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(648, 2));
		((Control)Panel5).set_TabIndex(4);
		((Control)Panel6).set_BackColor(Color.DimGray);
		((Control)Panel6).get_Controls().Add((Control)(object)Panel7);
		((Control)Panel6).set_Location(new Point(286, 211));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(648, 2));
		((Control)Panel6).set_TabIndex(5);
		((Control)Panel7).get_Controls().Add((Control)(object)Panel8);
		((Control)Panel7).set_Location(new Point(0, 0));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(655, 2));
		((Control)Panel7).set_TabIndex(5);
		((Control)Panel8).set_Location(new Point(8, 0));
		((Control)Panel8).set_Name("Panel8");
		((Control)Panel8).set_Size(new Size(655, 2));
		((Control)Panel8).set_TabIndex(6);
		((Control)Panel9).set_BackColor(Color.DimGray);
		((Control)Panel9).set_Location(new Point(293, 264));
		((Control)Panel9).set_Name("Panel9");
		((Control)Panel9).set_Size(new Size(648, 2));
		((Control)Panel9).set_TabIndex(5);
		((Control)Panel10).set_BackColor(Color.DimGray);
		((Control)Panel10).set_Location(new Point(293, 317));
		((Control)Panel10).set_Name("Panel10");
		((Control)Panel10).set_Size(new Size(648, 2));
		((Control)Panel10).set_TabIndex(6);
		((Control)Panel11).set_BackColor(Color.DimGray);
		((Control)Panel11).set_Location(new Point(293, 370));
		((Control)Panel11).set_Name("Panel11");
		((Control)Panel11).set_Size(new Size(648, 2));
		((Control)Panel11).set_TabIndex(7);
		((Control)Panel12).set_BackColor(Color.DimGray);
		((Control)Panel12).set_Location(new Point(292, 421));
		((Control)Panel12).set_Name("Panel12");
		((Control)Panel12).set_Size(new Size(648, 2));
		((Control)Panel12).set_TabIndex(8);
		((Control)Panel13).set_BackColor(Color.DimGray);
		((Control)Panel13).set_Location(new Point(293, 479));
		((Control)Panel13).set_Name("Panel13");
		((Control)Panel13).set_Size(new Size(648, 2));
		((Control)Panel13).set_TabIndex(9);
		((Control)Panel14).set_BackColor(Color.DimGray);
		((Control)Panel14).set_Location(new Point(627, 119));
		((Control)Panel14).set_Name("Panel14");
		((Control)Panel14).set_Size(new Size(2, 359));
		((Control)Panel14).set_TabIndex(10);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(341, 124));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(109, 22));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("First Name");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(341, 176));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(107, 22));
		((Control)Label2).set_TabIndex(12);
		Label2.set_Text("Last Name");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(341, 225));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(79, 22));
		((Control)Label3).set_TabIndex(13);
		Label3.set_Text("Gender");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(341, 279));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(62, 22));
		((Control)Label4).set_TabIndex(14);
		Label4.set_Text("Class");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(341, 336));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(148, 22));
		((Control)Label5).set_TabIndex(15);
		Label5.set_Text("Academic Year");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(341, 386));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(148, 22));
		((Control)Label6).set_TabIndex(16);
		Label6.set_Text("Phone Number");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(341, 436));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(101, 22));
		((Control)Label7).set_TabIndex(17);
		Label7.set_Text("Fess Paid");
		lblAmt.set_AutoSize(true);
		((Control)lblAmt).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblAmt).set_Location(new Point(692, 436));
		((Control)lblAmt).set_Name("lblAmt");
		((Control)lblAmt).set_Size(new Size(70, 22));
		((Control)lblAmt).set_TabIndex(24);
		lblAmt.set_Text("$96.00");
		lblphone.set_AutoSize(true);
		((Control)lblphone).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblphone).set_Location(new Point(692, 386));
		((Control)lblphone).set_Name("lblphone");
		((Control)lblphone).set_Size(new Size(120, 22));
		((Control)lblphone).set_TabIndex(23);
		lblphone.set_Text("0774068446");
		lblAcady.set_AutoSize(true);
		((Control)lblAcady).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblAcady).set_Location(new Point(692, 336));
		((Control)lblAcady).set_Name("lblAcady");
		((Control)lblAcady).set_Size(new Size(54, 22));
		((Control)lblAcady).set_TabIndex(22);
		lblAcady.set_Text("2019");
		lblClass.set_AutoSize(true);
		((Control)lblClass).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblClass).set_Location(new Point(692, 279));
		((Control)lblClass).set_Name("lblClass");
		((Control)lblClass).set_Size(new Size(77, 22));
		((Control)lblClass).set_TabIndex(21);
		lblClass.set_Text("6 ARTS");
		lblGnder.set_AutoSize(true);
		((Control)lblGnder).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblGnder).set_Location(new Point(692, 225));
		((Control)lblGnder).set_Name("lblGnder");
		((Control)lblGnder).set_Size(new Size(77, 22));
		((Control)lblGnder).set_TabIndex(20);
		lblGnder.set_Text("Female");
		lblSurn.set_AutoSize(true);
		((Control)lblSurn).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblSurn).set_Location(new Point(692, 176));
		((Control)lblSurn).set_Name("lblSurn");
		((Control)lblSurn).set_Size(new Size(70, 22));
		((Control)lblSurn).set_TabIndex(19);
		lblSurn.set_Text("Gwara");
		lblFname.set_AutoSize(true);
		((Control)lblFname).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblFname).set_Location(new Point(692, 124));
		((Control)lblFname).set_Name("lblFname");
		((Control)lblFname).set_Size(new Size(68, 22));
		((Control)lblFname).set_TabIndex(18);
		lblFname.set_Text("Mercy");
		((Control)Panel15).set_BackColor(Color.DodgerBlue);
		((Control)Panel15).get_Controls().Add((Control)(object)Button7);
		((Control)Panel15).get_Controls().Add((Control)(object)Button4);
		((Control)Panel15).get_Controls().Add((Control)(object)Button2);
		((Control)Panel15).get_Controls().Add((Control)(object)Button1);
		((Control)Panel15).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Panel15).set_Location(new Point(20, 311));
		((Control)Panel15).set_Name("Panel15");
		((Control)Panel15).set_Size(new Size(260, 278));
		((Control)Panel15).set_TabIndex(19);
		((ButtonBase)Button7).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)0);
		((Control)Button7).set_ForeColor(Color.White);
		((ButtonBase)Button7).set_Image((Image)componentResourceManager.GetObject("Button7.Image"));
		((ButtonBase)Button7).set_ImageAlign((ContentAlignment)16);
		((Control)Button7).set_Location(new Point(12, 180));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(247, 47));
		((Control)Button7).set_TabIndex(6);
		((ButtonBase)Button7).set_Text("            Back<<");
		((ButtonBase)Button7).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_ForeColor(Color.White);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((ButtonBase)Button4).set_ImageAlign((ContentAlignment)16);
		((Control)Button4).set_Location(new Point(11, 114));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(247, 47));
		((Control)Button4).set_TabIndex(2);
		((ButtonBase)Button4).set_Text("            Subjects");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_ForeColor(Color.White);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((ButtonBase)Button2).set_ImageAlign((ContentAlignment)16);
		((Control)Button2).set_Location(new Point(11, 62));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(247, 47));
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("            View Results");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_ForeColor(Color.White);
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		((ButtonBase)Button1).set_ImageAlign((ContentAlignment)16);
		((Control)Button1).set_Location(new Point(12, 13));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(247, 47));
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("            Dashboard");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)PictureBox1).set_Location(new Point(22, 61));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(258, 250));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(1);
		PictureBox1.set_TabStop(false);
		((ButtonBase)Button3).set_BackColor(Color.Teal);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_ForeColor(Color.White);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((ButtonBase)Button3).set_ImageAlign((ContentAlignment)16);
		((Control)Button3).set_Location(new Point(319, 542));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(165, 47));
		((Control)Button3).set_TabIndex(7);
		((ButtonBase)Button3).set_Text("            Make Payment");
		((ButtonBase)Button3).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button5).set_BackColor(Color.Teal);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_ForeColor(Color.White);
		((ButtonBase)Button5).set_Image((Image)componentResourceManager.GetObject("Button5.Image"));
		((ButtonBase)Button5).set_ImageAlign((ContentAlignment)16);
		((Control)Button5).set_Location(new Point(508, 542));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(165, 47));
		((Control)Button5).set_TabIndex(26);
		((ButtonBase)Button5).set_Text("            Clear Arrears");
		((ButtonBase)Button5).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button6).set_BackColor(Color.Teal);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button6).set_ForeColor(Color.White);
		((ButtonBase)Button6).set_Image((Image)componentResourceManager.GetObject("Button6.Image"));
		((ButtonBase)Button6).set_ImageAlign((ContentAlignment)16);
		((Control)Button6).set_Location(new Point(705, 542));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(165, 47));
		((Control)Button6).set_TabIndex(27);
		((ButtonBase)Button6).set_Text("            Upload Results");
		((ButtonBase)Button6).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button6).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button8).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button8).set_FlatStyle((FlatStyle)0);
		((Control)Button8).set_ForeColor(Color.White);
		((ButtonBase)Button8).set_Image((Image)componentResourceManager.GetObject("Button8.Image"));
		((ButtonBase)Button8).set_ImageAlign((ContentAlignment)16);
		((Control)Button8).set_Location(new Point(844, 3));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(101, 41));
		((Control)Button8).set_TabIndex(7);
		((ButtonBase)Button8).set_Text("            Back<<");
		((ButtonBase)Button8).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(313, 502));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(277, 22));
		((Control)Label11).set_TabIndex(28);
		Label11.set_Text("Student Registration Number");
		lblReg.set_AutoSize(true);
		((Control)lblReg).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblReg).set_ForeColor(Color.Green);
		((Control)lblReg).set_Location(new Point(692, 502));
		((Control)lblReg).set_Name("lblReg");
		((Control)lblReg).set_Size(new Size(120, 22));
		((Control)lblReg).set_TabIndex(29);
		lblReg.set_Text("0774068446");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(953, 597));
		((Control)this).get_Controls().Add((Control)(object)lblReg);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Panel13);
		((Control)this).get_Controls().Add((Control)(object)Panel12);
		((Control)this).get_Controls().Add((Control)(object)Panel11);
		((Control)this).get_Controls().Add((Control)(object)Panel10);
		((Control)this).get_Controls().Add((Control)(object)Panel9);
		((Control)this).get_Controls().Add((Control)(object)Panel6);
		((Control)this).get_Controls().Add((Control)(object)Panel5);
		((Control)this).get_Controls().Add((Control)(object)Panel15);
		((Control)this).get_Controls().Add((Control)(object)lblAmt);
		((Control)this).get_Controls().Add((Control)(object)lblphone);
		((Control)this).get_Controls().Add((Control)(object)lblAcady);
		((Control)this).get_Controls().Add((Control)(object)lblClass);
		((Control)this).get_Controls().Add((Control)(object)lblGnder);
		((Control)this).get_Controls().Add((Control)(object)lblSurn);
		((Control)this).get_Controls().Add((Control)(object)lblFname);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Panel14);
		((Control)this).get_Controls().Add((Control)(object)Panel4);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Student_Profile");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Student_Profile");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel7).ResumeLayout(false);
		((Control)Panel15).ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void k6C5(object Cc83, EventArgs n1CZ)
	{
		((Control)Ng2.Forms.StudentList).Show();
		((Control)this).Hide();
	}

	internal static byte[] b0NF(int[] z1L4, int k3TJ)
	{
		checked
		{
			byte[] array = new byte[k3TJ + 1];
			int num = z1L4.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)z1L4[i];
			}
			return array;
		}
	}

	private void Xm32(object w3N7, EventArgs Do79)
	{
		((Control)Ng2.Forms.StudentList).Show();
		((Control)this).Hide();
	}

	internal static byte[] c8T2(int w1L3, int w1D5)
	{
		if (w1L3 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[w1D5 + 1];
			for (int i = 0; i <= w1D5; i++)
			{
				int num = w1L3 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return b0NF(array, w1D5);
		}
	}

	private void a3GT(object y2XL, EventArgs z0MF)
	{
		lblAcady.set_Text(Conversions.ToString(crrYera));
	}
}
