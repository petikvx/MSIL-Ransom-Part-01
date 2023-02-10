using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d6P;
using f5LX;
using g2H;
using k6YA;

namespace Cf4r;

[DesignerGenerated]
public class e5F0 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler eventHandler = Qe37;
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

	[field: AccessedThroughProperty("ProfileController1")]
	internal virtual k9EH ProfileController1
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

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Go5a;
			Button button = _Button6;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Button7")]
	internal virtual Button Button7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
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

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("PictureBox6")]
	internal virtual PictureBox PictureBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox7")]
	internal virtual PictureBox PictureBox7
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("PictureBox4")]
	internal virtual PictureBox PictureBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox5")]
	internal virtual PictureBox PictureBox5
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

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
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

	private virtual Button Button11
	{
		[CompilerGenerated]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t1S3;
			Button button = _Button11;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button11 = value;
			button = _Button11;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	private virtual Button Button10
	{
		[CompilerGenerated]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Kf0b;
			Button button = _Button10;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button10 = value;
			button = _Button10;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Button9")]
	private virtual Button Button9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private virtual Button Button8
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
			EventHandler eventHandler = Lf05;
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

	private virtual Button avatar
	{
		[CompilerGenerated]
		get
		{
			return _avatar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c5Y6;
			Button val = _avatar;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_avatar = value;
			val = _avatar;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public e5F0()
	{
		Kp5n();
	}

	[DebuggerNonUserCode]
	protected override void Bi68(bool t6T5)
	{
		try
		{
			if (t6T5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t6T5);
		}
	}

	[DebuggerStepThrough]
	private void Kp5n()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
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
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected O, but got Unknown
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected O, but got Unknown
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e14: Expected O, but got Unknown
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Expected O, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected O, but got Unknown
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Expected O, but got Unknown
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10eb: Expected O, but got Unknown
		//IL_1257: Unknown result type (might be due to invalid IL or missing references)
		//IL_1261: Expected O, but got Unknown
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected O, but got Unknown
		//IL_1387: Unknown result type (might be due to invalid IL or missing references)
		//IL_1391: Expected O, but got Unknown
		//IL_1724: Unknown result type (might be due to invalid IL or missing references)
		//IL_172e: Expected O, but got Unknown
		//IL_1751: Unknown result type (might be due to invalid IL or missing references)
		//IL_175b: Expected O, but got Unknown
		//IL_1816: Unknown result type (might be due to invalid IL or missing references)
		//IL_1820: Expected O, but got Unknown
		//IL_1843: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Expected O, but got Unknown
		//IL_1908: Unknown result type (might be due to invalid IL or missing references)
		//IL_1912: Expected O, but got Unknown
		//IL_1935: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected O, but got Unknown
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a03: Expected O, but got Unknown
		//IL_1a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a30: Expected O, but got Unknown
		//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af4: Expected O, but got Unknown
		//IL_1b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b21: Expected O, but got Unknown
		//IL_1bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be5: Expected O, but got Unknown
		//IL_1c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c12: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e5F0));
		Panel1 = new Panel();
		Panel4 = new Panel();
		ProfileController1 = new k9EH();
		Panel2 = new Panel();
		SplitContainer1 = new SplitContainer();
		Panel10 = new Panel();
		Button1 = new Button();
		Panel8 = new Panel();
		Panel6 = new Panel();
		Label10 = new Label();
		Panel5 = new Panel();
		Label11 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label8 = new Label();
		Label12 = new Label();
		Label5 = new Label();
		Panel9 = new Panel();
		Label9 = new Label();
		Label4 = new Label();
		Panel7 = new Panel();
		Panel3 = new Panel();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox1 = new PictureBox();
		Button6 = new Button();
		Button7 = new Button();
		Button3 = new Button();
		Button5 = new Button();
		Button4 = new Button();
		Button2 = new Button();
		Button11 = new Button();
		Button10 = new Button();
		Button9 = new Button();
		Button8 = new Button();
		avatar = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)SplitContainer1).BeginInit();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)Panel10).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.FromArgb(30, 47, 68));
		((Control)Panel1).get_Controls().Add((Control)(object)Button6);
		((Control)Panel1).get_Controls().Add((Control)(object)Button7);
		((Control)Panel1).get_Controls().Add((Control)(object)Button3);
		((Control)Panel1).get_Controls().Add((Control)(object)Button5);
		((Control)Panel1).get_Controls().Add((Control)(object)Button4);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel4);
		((Control)Panel1).get_Controls().Add((Control)(object)ProfileController1);
		((Control)Panel1).get_Controls().Add((Control)(object)Panel2);
		((Control)Panel1).set_Dock((DockStyle)3);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(200, 710));
		((Control)Panel1).set_TabIndex(0);
		((Control)Panel4).set_BackColor(Color.FromArgb(255, 128, 0));
		((Control)Panel4).set_Location(new Point(0, 241));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(236, 2));
		((Control)Panel4).set_TabIndex(3);
		((Control)ProfileController1).set_BackColor(Color.FromArgb(30, 47, 68));
		((Control)ProfileController1).set_Location(new Point(-4, 0));
		((Control)ProfileController1).set_Name("ProfileController1");
		((Control)ProfileController1).set_Size(new Size(204, 235));
		((Control)ProfileController1).set_TabIndex(2);
		((Control)Panel2).set_BackColor(Color.Silver);
		((Control)Panel2).set_Location(new Point(0, 200));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(200, 4));
		((Control)Panel2).set_TabIndex(1);
		SplitContainer1.set_Dock((DockStyle)5);
		((Control)SplitContainer1).set_Location(new Point(200, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		SplitContainer1.set_Orientation((Orientation)0);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)Panel10);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)Button1);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)PictureBox2);
		((Control)SplitContainer1.get_Panel2()).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel8);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel6);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label10);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel5);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label11);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label7);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)PictureBox6);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label6);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)PictureBox7);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label8);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label12);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label5);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel9);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)PictureBox4);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)PictureBox3);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)PictureBox5);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)PictureBox1);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label9);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label4);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel7);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Panel3);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label3);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label2);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)Label1);
		((Control)SplitContainer1).set_Size(new Size(1148, 710));
		SplitContainer1.set_SplitterDistance(529);
		((Control)SplitContainer1).set_TabIndex(1);
		((Control)Panel10).get_Controls().Add((Control)(object)Button11);
		((Control)Panel10).get_Controls().Add((Control)(object)Button10);
		((Control)Panel10).get_Controls().Add((Control)(object)Button9);
		((Control)Panel10).get_Controls().Add((Control)(object)Button8);
		((Control)Panel10).get_Controls().Add((Control)(object)avatar);
		((Control)Panel10).set_Location(new Point(954, 483));
		((Control)Panel10).set_Name("Panel10");
		((Control)Panel10).set_Size(new Size(191, 46));
		((Control)Panel10).set_TabIndex(2);
		((ButtonBase)Button1).set_BackColor(Color.DodgerBlue);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Century Gothic", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.White);
		((Control)Button1).set_Location(new Point(437, 239));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(237, 49));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("View More");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Panel8).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel8).set_Location(new Point(819, 56));
		((Control)Panel8).set_Name("Panel8");
		((Control)Panel8).set_Size(new Size(189, 3));
		((Control)Panel8).set_TabIndex(10);
		((Control)Panel6).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_Location(new Point(587, 54));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(189, 3));
		((Control)Panel6).set_TabIndex(10);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.Yellow);
		((Control)Label10).set_Location(new Point(919, 128));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(78, 17));
		((Control)Label10).set_TabIndex(15);
		Label10.set_Text("View more");
		((Control)Panel5).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel5).set_Location(new Point(348, 52));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(189, 3));
		((Control)Panel5).set_TabIndex(4);
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.Yellow);
		((Control)Label11).set_Location(new Point(829, 128));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(78, 17));
		((Control)Label11).set_TabIndex(14);
		Label11.set_Text("View more");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Yellow);
		((Control)Label7).set_Location(new Point(687, 126));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(78, 17));
		((Control)Label7).set_TabIndex(15);
		Label7.set_Text("View more");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Yellow);
		((Control)Label6).set_Location(new Point(448, 124));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(78, 17));
		((Control)Label6).set_TabIndex(8);
		Label6.set_Text("View more");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Yellow);
		((Control)Label8).set_Location(new Point(597, 126));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(78, 17));
		((Control)Label8).set_TabIndex(14);
		Label8.set_Text("View more");
		Label12.set_AutoSize(true);
		((Control)Label12).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_ForeColor(Color.White);
		((Control)Label12).set_Location(new Point(821, 23));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(193, 30));
		((Control)Label12).set_TabIndex(11);
		Label12.set_Text("Web Designing");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Century Gothic", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Yellow);
		((Control)Label5).set_Location(new Point(358, 124));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(78, 17));
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("View more");
		((Control)Panel9).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_Location(new Point(802, 21));
		((Control)Panel9).set_Name("Panel9");
		((Control)Panel9).set_Size(new Size(2, 148));
		((Control)Panel9).set_TabIndex(9);
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.White);
		((Control)Label9).set_Location(new Point(589, 21));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(207, 30));
		((Control)Label9).set_TabIndex(11);
		Label9.set_Text("Arts and Designs");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(350, 19));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(195, 30));
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("Health Services");
		((Control)Panel7).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_Location(new Point(570, 19));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(2, 148));
		((Control)Panel7).set_TabIndex(9);
		((Control)Panel3).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_Location(new Point(331, 17));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(2, 148));
		((Control)Panel3).set_TabIndex(3);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(31, 111));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(158, 30));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Bindura,  ZW");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(31, 62));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(140, 30));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("P . Bag 332");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Century Gothic", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(31, 19));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(276, 30));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Chipadze High School");
		((Control)PictureBox2).set_BackColor(Color.Silver);
		((Control)PictureBox2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)PictureBox2).set_Dock((DockStyle)5);
		((Control)PictureBox2).set_Location(new Point(0, 0));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(1148, 529));
		PictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox2.set_TabIndex(0);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox6).set_Location(new Point(917, 66));
		((Control)PictureBox6).set_Name("PictureBox6");
		((Control)PictureBox6).set_Size(new Size(82, 57));
		PictureBox6.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox6.set_TabIndex(13);
		PictureBox6.set_TabStop(false);
		((Control)PictureBox7).set_Location(new Point(826, 66));
		((Control)PictureBox7).set_Name("PictureBox7");
		((Control)PictureBox7).set_Size(new Size(82, 57));
		PictureBox7.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox7.set_TabIndex(12);
		PictureBox7.set_TabStop(false);
		((Control)PictureBox4).set_Location(new Point(685, 64));
		((Control)PictureBox4).set_Name("PictureBox4");
		((Control)PictureBox4).set_Size(new Size(82, 57));
		PictureBox4.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox4.set_TabIndex(13);
		PictureBox4.set_TabStop(false);
		((Control)PictureBox3).set_Location(new Point(446, 62));
		((Control)PictureBox3).set_Name("PictureBox3");
		((Control)PictureBox3).set_Size(new Size(82, 57));
		PictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox3.set_TabIndex(6);
		PictureBox3.set_TabStop(false);
		((Control)PictureBox5).set_Location(new Point(594, 64));
		((Control)PictureBox5).set_Name("PictureBox5");
		((Control)PictureBox5).set_Size(new Size(82, 57));
		PictureBox5.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox5.set_TabIndex(12);
		PictureBox5.set_TabStop(false);
		((Control)PictureBox1).set_Location(new Point(355, 62));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(82, 57));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button6).set_ForeColor(SystemColors.ButtonFace);
		((ButtonBase)Button6).set_Image((Image)componentResourceManager.GetObject("Button6.Image"));
		((ButtonBase)Button6).set_ImageAlign((ContentAlignment)16);
		((Control)Button6).set_Location(new Point(3, 517));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(194, 47));
		((Control)Button6).set_TabIndex(10);
		((ButtonBase)Button6).set_Text("            LOGOUT");
		((ButtonBase)Button6).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button7).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)0);
		((Control)Button7).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button7).set_ForeColor(SystemColors.ButtonFace);
		((ButtonBase)Button7).set_Image((Image)componentResourceManager.GetObject("Button7.Image"));
		((ButtonBase)Button7).set_ImageAlign((ContentAlignment)16);
		((Control)Button7).set_Location(new Point(3, 464));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(194, 47));
		((Control)Button7).set_TabIndex(9);
		((ButtonBase)Button7).set_Text("             SDC GALLARY");
		((ButtonBase)Button7).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_ForeColor(SystemColors.ButtonFace);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((ButtonBase)Button3).set_ImageAlign((ContentAlignment)16);
		((Control)Button3).set_Location(new Point(3, 420));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(194, 47));
		((Control)Button3).set_TabIndex(8);
		((ButtonBase)Button3).set_Text("            STUDENTS ");
		((ButtonBase)Button3).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_ForeColor(SystemColors.ButtonFace);
		((ButtonBase)Button5).set_Image((Image)componentResourceManager.GetObject("Button5.Image"));
		((ButtonBase)Button5).set_ImageAlign((ContentAlignment)16);
		((Control)Button5).set_Location(new Point(3, 367));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(194, 47));
		((Control)Button5).set_TabIndex(7);
		((ButtonBase)Button5).set_Text("             STAFF GALLARY");
		((ButtonBase)Button5).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button4).set_ForeColor(SystemColors.ButtonFace);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((ButtonBase)Button4).set_ImageAlign((ContentAlignment)16);
		((Control)Button4).set_Location(new Point(3, 314));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(194, 47));
		((Control)Button4).set_TabIndex(6);
		((ButtonBase)Button4).set_Text("            PRIZE GIVING");
		((ButtonBase)Button4).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Century Gothic", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(SystemColors.ButtonFace);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((ButtonBase)Button2).set_ImageAlign((ContentAlignment)16);
		((Control)Button2).set_Location(new Point(3, 261));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(194, 47));
		((Control)Button2).set_TabIndex(5);
		((ButtonBase)Button2).set_Text("             SPORTS DAYS");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button11).set_BackColor(Color.Transparent);
		((Control)Button11).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button11).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button11).set_FlatStyle((FlatStyle)0);
		((Control)Button11).set_Location(new Point(142, 11));
		((Control)Button11).set_Name("Button11");
		((Control)Button11).set_Size(new Size(45, 25));
		((Control)Button11).set_TabIndex(22);
		((ButtonBase)Button11).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button10).set_BackColor(Color.Transparent);
		((Control)Button10).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button10).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button10).set_FlatStyle((FlatStyle)0);
		((Control)Button10).set_Location(new Point(105, 11));
		((Control)Button10).set_Name("Button10");
		((Control)Button10).set_Size(new Size(45, 25));
		((Control)Button10).set_TabIndex(21);
		((ButtonBase)Button10).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button9).set_BackColor(Color.Transparent);
		((Control)Button9).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button9).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button9).set_FlatStyle((FlatStyle)0);
		((Control)Button9).set_Location(new Point(66, 11));
		((Control)Button9).set_Name("Button9");
		((Control)Button9).set_Size(new Size(45, 25));
		((Control)Button9).set_TabIndex(20);
		((ButtonBase)Button9).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button8).set_BackColor(Color.Transparent);
		((Control)Button8).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)Button8).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button8).set_FlatStyle((FlatStyle)0);
		((Control)Button8).set_Location(new Point(-4, 11));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(45, 25));
		((Control)Button8).set_TabIndex(19);
		((ButtonBase)Button8).set_UseVisualStyleBackColor(false);
		((ButtonBase)avatar).set_BackColor(Color.Transparent);
		((Control)avatar).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)avatar).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)avatar).set_FlatStyle((FlatStyle)0);
		((Control)avatar).set_Location(new Point(31, 11));
		((Control)avatar).set_Name("avatar");
		((Control)avatar).set_Size(new Size(45, 25));
		((Control)avatar).set_TabIndex(18);
		((ButtonBase)avatar).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(1348, 710));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Gallery");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Gallery");
		((Control)Panel1).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel2()).PerformLayout();
		((ISupportInitialize)SplitContainer1).EndInit();
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)Panel10).ResumeLayout(false);
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Qe37(object f8C6, EventArgs Lg36)
	{
		((Control)Gw5.Forms.Home).Show();
		((Control)this).Hide();
	}

	private void Go5a(object g4GQ, EventArgs j5Q6)
	{
		Application.Exit();
	}

	private void Lf05(object Hg79, EventArgs f1Z2)
	{
		t1J2.Mx3p();
	}

	internal static void Tn0z(string Qm38)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		p7E.Lq1s(Qm38);
	}

	private void c5Y6(object Yq34, EventArgs s8H1)
	{
		t1J2.Yy4e();
	}

	private void Kf0b(object Mw7y, EventArgs Ff18)
	{
		t1J2.s0ZJ();
	}

	private void t1S3(object f4KQ, EventArgs Bg67)
	{
		t1J2.j2K9();
	}
}
