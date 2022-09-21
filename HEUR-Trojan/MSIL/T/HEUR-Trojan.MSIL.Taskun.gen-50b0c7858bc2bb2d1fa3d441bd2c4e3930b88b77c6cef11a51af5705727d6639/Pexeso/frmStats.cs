using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pexeso.My;

namespace Pexeso;

[DesignerGenerated]
public class frmStats : Form
{
	private IContainer components;

	internal virtual Button cmdBack
	{
		[CompilerGenerated]
		get
		{
			return _cmdBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdBack_Click;
			Button val = _cmdBack;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_cmdBack = value;
			val = _cmdBack;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("panBottom")]
	internal virtual Panel panBottom
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

	[field: AccessedThroughProperty("panEasy")]
	internal virtual Panel panEasy
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblEasyNumber")]
	internal virtual Label lblEasyNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panEasyTitle")]
	internal virtual Panel panEasyTitle
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl1")]
	internal virtual Label lbl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl2")]
	internal virtual Label lbl2
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
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

	[field: AccessedThroughProperty("lbl3")]
	internal virtual Label lbl3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl4")]
	internal virtual Label lbl4
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

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
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

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl5")]
	internal virtual Label lbl5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl6")]
	internal virtual Label lbl6
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

	internal virtual Button cmdReset
	{
		[CompilerGenerated]
		get
		{
			return _cmdReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdReset_Click;
			Button val = _cmdReset;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_cmdReset = value;
			val = _cmdReset;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public frmStats()
	{
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
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected O, but got Unknown
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Expected O, but got Unknown
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected O, but got Unknown
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected O, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1086: Expected O, but got Unknown
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Expected O, but got Unknown
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Expected O, but got Unknown
		//IL_1212: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1357: Expected O, but got Unknown
		//IL_1378: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e: Unknown result type (might be due to invalid IL or missing references)
		//IL_157f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1589: Expected O, but got Unknown
		//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1639: Unknown result type (might be due to invalid IL or missing references)
		//IL_1643: Expected O, but got Unknown
		//IL_1663: Unknown result type (might be due to invalid IL or missing references)
		//IL_1687: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ff: Expected O, but got Unknown
		//IL_171b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1801: Unknown result type (might be due to invalid IL or missing references)
		//IL_1865: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected O, but got Unknown
		//IL_188c: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1916: Unknown result type (might be due to invalid IL or missing references)
		//IL_1920: Expected O, but got Unknown
		//IL_1940: Unknown result type (might be due to invalid IL or missing references)
		//IL_1965: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19df: Expected O, but got Unknown
		//IL_19fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b30: Expected O, but got Unknown
		//IL_1b35: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmStats));
		cmdBack = new Button();
		Label2 = new Label();
		Label4 = new Label();
		Label1 = new Label();
		Label3 = new Label();
		Panel1 = new Panel();
		Panel2 = new Panel();
		Label5 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Panel4 = new Panel();
		lbl3 = new Label();
		lbl4 = new Label();
		Label13 = new Label();
		Panel3 = new Panel();
		Panel6 = new Panel();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Panel7 = new Panel();
		lbl5 = new Label();
		lbl6 = new Label();
		Label19 = new Label();
		panBottom = new Panel();
		cmdReset = new Button();
		Panel5 = new Panel();
		panEasyTitle = new Panel();
		Label7 = new Label();
		Label8 = new Label();
		Label6 = new Label();
		panEasy = new Panel();
		lbl1 = new Label();
		lbl2 = new Label();
		lblEasyNumber = new Label();
		((Control)Panel1).SuspendLayout();
		((Control)Panel2).SuspendLayout();
		((Control)Panel4).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((Control)Panel6).SuspendLayout();
		((Control)Panel7).SuspendLayout();
		((Control)panBottom).SuspendLayout();
		((Control)Panel5).SuspendLayout();
		((Control)panEasyTitle).SuspendLayout();
		((Control)panEasy).SuspendLayout();
		((Control)this).SuspendLayout();
		cmdBack.set_DialogResult((DialogResult)2);
		((Control)cmdBack).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cmdBack).set_Location(new Point(101, 72));
		((Control)cmdBack).set_Margin(new Padding(8, 7, 8, 7));
		((Control)cmdBack).set_Name("cmdBack");
		((Control)cmdBack).set_Size(new Size(427, 95));
		((Control)cmdBack).set_TabIndex(4);
		((ButtonBase)cmdBack).set_Text("Back to menu");
		((ButtonBase)cmdBack).set_UseVisualStyleBackColor(true);
		((Control)Label2).set_BackColor(SystemColors.Control);
		((Control)Label2).set_Dock((DockStyle)1);
		((Control)Label2).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_Location(new Point(0, 0));
		((Control)Label2).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(1851, 143));
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("Leaderboards");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Dock((DockStyle)1);
		((Control)Label4).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label4).set_Location(new Point(0, 0));
		((Control)Label4).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(629, 160));
		((Control)Label4).set_TabIndex(10);
		Label4.set_Text("Easy");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)Label1).set_Dock((DockStyle)1);
		((Control)Label1).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label1).set_Location(new Point(0, 0));
		((Control)Label1).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(593, 160));
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Normal");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label3).set_Dock((DockStyle)1);
		((Control)Label3).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label3).set_Location(new Point(0, 0));
		((Control)Label3).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(629, 160));
		((Control)Label3).set_TabIndex(12);
		Label3.set_Text("Hard");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)Panel1).set_BackColor(SystemColors.Control);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Dock((DockStyle)5);
		((Control)Panel1).set_Location(new Point(629, 143));
		((Control)Panel1).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(593, 745));
		((Control)Panel1).set_TabIndex(13);
		((Control)Panel2).set_BackColor(Color.FromArgb(224, 224, 224));
		Panel2.set_BorderStyle((BorderStyle)1);
		((Control)Panel2).get_Controls().Add((Control)(object)Label5);
		((Control)Panel2).get_Controls().Add((Control)(object)Label9);
		((Control)Panel2).get_Controls().Add((Control)(object)Label10);
		((Control)Panel2).set_Location(new Point(0, 148));
		((Control)Panel2).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(589, 95));
		((Control)Panel2).set_TabIndex(18);
		((Control)Label5).set_Dock((DockStyle)5);
		((Control)Label5).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label5).set_Location(new Point(88, 0));
		((Control)Label5).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Padding(new Padding(24, 0, 0, 0));
		((Control)Label5).set_Size(new Size(347, 93));
		((Control)Label5).set_TabIndex(15);
		Label5.set_Text("Name");
		Label5.set_TextAlign((ContentAlignment)16);
		((Control)Label9).set_Dock((DockStyle)4);
		((Control)Label9).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label9).set_Location(new Point(435, 0));
		((Control)Label9).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Padding(new Padding(8, 0, 0, 0));
		((Control)Label9).set_Size(new Size(152, 93));
		((Control)Label9).set_TabIndex(16);
		Label9.set_Text("Time");
		Label9.set_TextAlign((ContentAlignment)16);
		((Control)Label10).set_Dock((DockStyle)3);
		((Control)Label10).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label10).set_Location(new Point(0, 0));
		((Control)Label10).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(88, 93));
		((Control)Label10).set_TabIndex(14);
		Label10.set_Text("Nr.");
		Label10.set_TextAlign((ContentAlignment)64);
		((Control)Panel4).set_BackColor(Color.FromArgb(192, 192, 255));
		Panel4.set_BorderStyle((BorderStyle)1);
		((Control)Panel4).get_Controls().Add((Control)(object)lbl3);
		((Control)Panel4).get_Controls().Add((Control)(object)lbl4);
		((Control)Panel4).get_Controls().Add((Control)(object)Label13);
		((Control)Panel4).set_Location(new Point(0, 250));
		((Control)Panel4).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(589, 477));
		((Control)Panel4).set_TabIndex(17);
		((Control)lbl3).set_Dock((DockStyle)5);
		((Control)lbl3).set_Font(new Font("Consolas", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl3).set_Location(new Point(88, 0));
		((Control)lbl3).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Padding(new Padding(24, 10, 0, 0));
		((Control)lbl3).set_Size(new Size(336, 475));
		((Control)lbl3).set_TabIndex(16);
		lbl3.set_Text("user1\r\nuser2\r\nuser3\r\nuser4\r\nuser5\r\nuser6\r\nuser7\r\nuser8\r\nuser9\r\nuser10");
		((Control)lbl4).set_Dock((DockStyle)4);
		((Control)lbl4).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl4).set_Location(new Point(424, 0));
		((Control)lbl4).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lbl4).set_Name("lbl4");
		((Control)lbl4).set_Padding(new Padding(0, 10, 0, 0));
		((Control)lbl4).set_Size(new Size(163, 475));
		((Control)lbl4).set_TabIndex(15);
		lbl4.set_Text("00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10");
		lbl4.set_TextAlign((ContentAlignment)2);
		((Control)Label13).set_Dock((DockStyle)3);
		((Control)Label13).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label13).set_Location(new Point(0, 0));
		((Control)Label13).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Padding(new Padding(0, 10, 0, 0));
		((Control)Label13).set_Size(new Size(88, 475));
		((Control)Label13).set_TabIndex(14);
		Label13.set_Text("1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.");
		Label13.set_TextAlign((ContentAlignment)4);
		((Control)Panel3).set_BackColor(SystemColors.Control);
		((Control)Panel3).get_Controls().Add((Control)(object)Panel6);
		((Control)Panel3).get_Controls().Add((Control)(object)Panel7);
		((Control)Panel3).get_Controls().Add((Control)(object)Label3);
		((Control)Panel3).set_Dock((DockStyle)4);
		((Control)Panel3).set_Location(new Point(1222, 143));
		((Control)Panel3).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(629, 745));
		((Control)Panel3).set_TabIndex(14);
		((Control)Panel6).set_BackColor(Color.FromArgb(224, 224, 224));
		Panel6.set_BorderStyle((BorderStyle)1);
		((Control)Panel6).get_Controls().Add((Control)(object)Label14);
		((Control)Panel6).get_Controls().Add((Control)(object)Label15);
		((Control)Panel6).get_Controls().Add((Control)(object)Label16);
		((Control)Panel6).set_Location(new Point(19, 148));
		((Control)Panel6).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(589, 95));
		((Control)Panel6).set_TabIndex(18);
		((Control)Label14).set_Dock((DockStyle)5);
		((Control)Label14).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label14).set_Location(new Point(88, 0));
		((Control)Label14).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Padding(new Padding(24, 0, 0, 0));
		((Control)Label14).set_Size(new Size(347, 93));
		((Control)Label14).set_TabIndex(15);
		Label14.set_Text("Name");
		Label14.set_TextAlign((ContentAlignment)16);
		((Control)Label15).set_Dock((DockStyle)4);
		((Control)Label15).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label15).set_Location(new Point(435, 0));
		((Control)Label15).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Padding(new Padding(8, 0, 0, 0));
		((Control)Label15).set_Size(new Size(152, 93));
		((Control)Label15).set_TabIndex(16);
		Label15.set_Text("Time");
		Label15.set_TextAlign((ContentAlignment)16);
		((Control)Label16).set_Dock((DockStyle)3);
		((Control)Label16).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label16).set_Location(new Point(0, 0));
		((Control)Label16).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(88, 93));
		((Control)Label16).set_TabIndex(14);
		Label16.set_Text("Nr.");
		Label16.set_TextAlign((ContentAlignment)64);
		((Control)Panel7).set_BackColor(Color.FromArgb(255, 192, 192));
		Panel7.set_BorderStyle((BorderStyle)1);
		((Control)Panel7).get_Controls().Add((Control)(object)lbl5);
		((Control)Panel7).get_Controls().Add((Control)(object)lbl6);
		((Control)Panel7).get_Controls().Add((Control)(object)Label19);
		((Control)Panel7).set_Location(new Point(19, 250));
		((Control)Panel7).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(589, 477));
		((Control)Panel7).set_TabIndex(17);
		((Control)lbl5).set_Dock((DockStyle)5);
		((Control)lbl5).set_Font(new Font("Consolas", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl5).set_Location(new Point(88, 0));
		((Control)lbl5).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lbl5).set_Name("lbl5");
		((Control)lbl5).set_Padding(new Padding(24, 10, 0, 0));
		((Control)lbl5).set_Size(new Size(336, 475));
		((Control)lbl5).set_TabIndex(16);
		lbl5.set_Text("user1\r\nuser2\r\nuser3\r\nuser4\r\nuser5\r\nuser6\r\nuser7\r\nuser8\r\nuser9\r\nuser10");
		((Control)lbl6).set_Dock((DockStyle)4);
		((Control)lbl6).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl6).set_Location(new Point(424, 0));
		((Control)lbl6).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lbl6).set_Name("lbl6");
		((Control)lbl6).set_Padding(new Padding(0, 10, 0, 0));
		((Control)lbl6).set_Size(new Size(163, 475));
		((Control)lbl6).set_TabIndex(15);
		lbl6.set_Text("00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10");
		lbl6.set_TextAlign((ContentAlignment)2);
		((Control)Label19).set_Dock((DockStyle)3);
		((Control)Label19).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label19).set_Location(new Point(0, 0));
		((Control)Label19).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label19).set_Name("Label19");
		((Control)Label19).set_Padding(new Padding(0, 10, 0, 0));
		((Control)Label19).set_Size(new Size(88, 475));
		((Control)Label19).set_TabIndex(14);
		Label19.set_Text("1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.");
		Label19.set_TextAlign((ContentAlignment)4);
		((Control)panBottom).set_BackColor(SystemColors.Control);
		((Control)panBottom).get_Controls().Add((Control)(object)cmdReset);
		((Control)panBottom).get_Controls().Add((Control)(object)cmdBack);
		((Control)panBottom).set_Dock((DockStyle)2);
		((Control)panBottom).set_Location(new Point(0, 888));
		((Control)panBottom).set_Margin(new Padding(8, 7, 8, 7));
		((Control)panBottom).set_Name("panBottom");
		((Control)panBottom).set_Size(new Size(1851, 238));
		((Control)panBottom).set_TabIndex(15);
		cmdReset.set_DialogResult((DialogResult)2);
		((Control)cmdReset).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cmdReset).set_Location(new Point(1280, 72));
		((Control)cmdReset).set_Margin(new Padding(8, 7, 8, 7));
		((Control)cmdReset).set_Name("cmdReset");
		((Control)cmdReset).set_Size(new Size(515, 95));
		((Control)cmdReset).set_TabIndex(5);
		((ButtonBase)cmdReset).set_Text("Reset leaderboard");
		((ButtonBase)cmdReset).set_UseVisualStyleBackColor(true);
		((Control)Panel5).set_BackColor(SystemColors.Control);
		((Control)Panel5).get_Controls().Add((Control)(object)panEasyTitle);
		((Control)Panel5).get_Controls().Add((Control)(object)panEasy);
		((Control)Panel5).get_Controls().Add((Control)(object)Label4);
		((Control)Panel5).set_Dock((DockStyle)3);
		((Control)Panel5).set_Location(new Point(0, 143));
		((Control)Panel5).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(629, 745));
		((Control)Panel5).set_TabIndex(16);
		((Control)panEasyTitle).set_BackColor(Color.FromArgb(224, 224, 224));
		panEasyTitle.set_BorderStyle((BorderStyle)1);
		((Control)panEasyTitle).get_Controls().Add((Control)(object)Label7);
		((Control)panEasyTitle).get_Controls().Add((Control)(object)Label8);
		((Control)panEasyTitle).get_Controls().Add((Control)(object)Label6);
		((Control)panEasyTitle).set_Location(new Point(19, 148));
		((Control)panEasyTitle).set_Margin(new Padding(8, 7, 8, 7));
		((Control)panEasyTitle).set_Name("panEasyTitle");
		((Control)panEasyTitle).set_Size(new Size(589, 95));
		((Control)panEasyTitle).set_TabIndex(15);
		((Control)Label7).set_Dock((DockStyle)5);
		((Control)Label7).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label7).set_Location(new Point(88, 0));
		((Control)Label7).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Padding(new Padding(24, 0, 0, 0));
		((Control)Label7).set_Size(new Size(347, 93));
		((Control)Label7).set_TabIndex(15);
		Label7.set_Text("Name");
		Label7.set_TextAlign((ContentAlignment)16);
		((Control)Label8).set_Dock((DockStyle)4);
		((Control)Label8).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label8).set_Location(new Point(435, 0));
		((Control)Label8).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Padding(new Padding(8, 0, 0, 0));
		((Control)Label8).set_Size(new Size(152, 93));
		((Control)Label8).set_TabIndex(16);
		Label8.set_Text("Time");
		Label8.set_TextAlign((ContentAlignment)16);
		((Control)Label6).set_Dock((DockStyle)3);
		((Control)Label6).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label6).set_Location(new Point(0, 0));
		((Control)Label6).set_Margin(new Padding(8, 0, 8, 0));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(88, 93));
		((Control)Label6).set_TabIndex(14);
		Label6.set_Text("Nr.");
		Label6.set_TextAlign((ContentAlignment)64);
		((Control)panEasy).set_BackColor(Color.FromArgb(192, 255, 192));
		panEasy.set_BorderStyle((BorderStyle)1);
		((Control)panEasy).get_Controls().Add((Control)(object)lbl1);
		((Control)panEasy).get_Controls().Add((Control)(object)lbl2);
		((Control)panEasy).get_Controls().Add((Control)(object)lblEasyNumber);
		((Control)panEasy).set_Location(new Point(19, 250));
		((Control)panEasy).set_Margin(new Padding(8, 7, 8, 7));
		((Control)panEasy).set_Name("panEasy");
		((Control)panEasy).set_Size(new Size(589, 477));
		((Control)panEasy).set_TabIndex(11);
		((Control)lbl1).set_Dock((DockStyle)5);
		((Control)lbl1).set_Font(new Font("Consolas", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_Location(new Point(88, 0));
		((Control)lbl1).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Padding(new Padding(24, 10, 0, 0));
		((Control)lbl1).set_Size(new Size(336, 475));
		((Control)lbl1).set_TabIndex(16);
		lbl1.set_Text("user1\r\nuser2\r\nuser3\r\nuser4\r\nuser5\r\nuser6\r\nuser7\r\n123456789012\r\nWWWWWWWWWWWW\r\nuser10");
		((Control)lbl2).set_Dock((DockStyle)4);
		((Control)lbl2).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl2).set_Location(new Point(424, 0));
		((Control)lbl2).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Padding(new Padding(0, 10, 0, 0));
		((Control)lbl2).set_Size(new Size(163, 475));
		((Control)lbl2).set_TabIndex(15);
		lbl2.set_Text("00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10\r\n00:10");
		lbl2.set_TextAlign((ContentAlignment)2);
		((Control)lblEasyNumber).set_Dock((DockStyle)3);
		((Control)lblEasyNumber).set_Font(new Font("Cambria", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblEasyNumber).set_Location(new Point(0, 0));
		((Control)lblEasyNumber).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lblEasyNumber).set_Name("lblEasyNumber");
		((Control)lblEasyNumber).set_Padding(new Padding(0, 10, 0, 0));
		((Control)lblEasyNumber).set_Size(new Size(88, 475));
		((Control)lblEasyNumber).set_TabIndex(14);
		lblEasyNumber.set_Text("1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.");
		lblEasyNumber.set_TextAlign((ContentAlignment)4);
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdBack);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		((Form)this).set_CancelButton((IButtonControl)(object)cmdBack);
		((Form)this).set_ClientSize(new Size(1851, 1126));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel5);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)panBottom);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(8, 7, 8, 7));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmStats");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Stats");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel4).ResumeLayout(false);
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel6).ResumeLayout(false);
		((Control)Panel7).ResumeLayout(false);
		((Control)panBottom).ResumeLayout(false);
		((Control)Panel5).ResumeLayout(false);
		((Control)panEasyTitle).ResumeLayout(false);
		((Control)panEasy).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void cmdBack_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.frmMainMenu).Show();
	}

	public void InitializeLeaderboard()
	{
		int num = 1;
		checked
		{
			do
			{
				object[] array = Strings.Split(Conversions.ToString(((ApplicationSettingsBase)MySettingsProperty.Settings).get_Item("L" + Conversions.ToString(num))), ";", -1, (CompareMethod)0);
				((Control)this).get_Controls().Find("lbl" + Conversions.ToString(num), true)[0].set_Text("");
				int num2 = array.Count() - 1;
				for (int i = 0; i <= num2; i++)
				{
					object obj = ((i != array.Count() - 1) ? "\r\n" : null);
					Control val;
					(val = ((Control)this).get_Controls().Find("lbl" + Conversions.ToString(num), true)[0]).set_Text(Conversions.ToString(Operators.AddObject((object)val.get_Text(), Operators.ConcatenateObject(array[i], obj))));
				}
				num++;
			}
			while (num <= 6);
		}
	}

	private void cmdReset_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)"Do you really want to reset leaderboard?", (MsgBoxStyle)36, (object)"Leaderboard reset") != 6)
		{
			return;
		}
		int num = 1;
		while (true)
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("L" + Conversions.ToString(num), (object)"Player1;Player2;Player3;Player4;Player5;Player6;Player7;Player8;Player9;Player10");
			while (true)
			{
				num = checked(num + 1);
				if (num <= 6)
				{
					switch (num)
					{
					case 2:
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("L" + Conversions.ToString(num), (object)"00:15;00:20;00:25;00:30;00:35;00:40;00:45;00:50;00:55;01:00");
						continue;
					case 4:
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("L" + Conversions.ToString(num), (object)"01:10;01:15;01:20;01:25;01:30;01:35;01:40;01:45;01:50;01:55");
						continue;
					case 6:
						((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("L" + Conversions.ToString(num), (object)"02:00;02:10;02:20;02:30;02:40;02:50;03:00;04:10;04:20;04:30");
						continue;
					default:
						continue;
					case 1:
					case 3:
					case 5:
						break;
					}
					break;
				}
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				InitializeLeaderboard();
				return;
			}
		}
	}
}
