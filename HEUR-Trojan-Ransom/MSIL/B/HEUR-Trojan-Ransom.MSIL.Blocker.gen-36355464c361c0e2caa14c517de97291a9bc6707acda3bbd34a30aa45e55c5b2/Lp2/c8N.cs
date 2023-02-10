using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cf6;
using Hr60;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using k9X;
using t8C;

namespace Lp2;

[DesignerGenerated]
public class c8N : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("btnUpdat")]
	internal virtual Button btnUpdat
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
			EventHandler eventHandler = Gc2;
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtRecept
	{
		[CompilerGenerated]
		get
		{
			return _txtRecept;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m7A;
			EventHandler eventHandler2 = i7D;
			TextBox val = _txtRecept;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
			}
			_txtRecept = value;
			val = _txtRecept;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = c8P;
			Button button = _Button4;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBoxAmt")]
	internal virtual GroupBox GroupBoxAmt
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

	[field: AccessedThroughProperty("txtBalance")]
	internal virtual TextBox txtBalance
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

	internal virtual TextBox txtAmt
	{
		[CompilerGenerated]
		get
		{
			return _txtAmt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m1H;
			EventHandler eventHandler2 = w3A;
			EventHandler eventHandler3 = Tm1;
			TextBox val = _txtAmt;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
				((Control)val).remove_TextChanged(eventHandler3);
			}
			_txtAmt = value;
			val = _txtAmt;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
				((Control)val).add_TextChanged(eventHandler3);
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblChange")]
	internal virtual TextBox lblChange
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboStatus")]
	internal virtual Label cboStatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBoxInfo")]
	internal virtual GroupBox GroupBoxInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboTerm")]
	internal virtual ComboBox cboTerm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cboClass")]
	internal virtual ComboBox cboClass
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	internal virtual TextBox txtSurname
	{
		[CompilerGenerated]
		get
		{
			return _txtSurname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yw1;
			EventHandler eventHandler2 = Zo3;
			TextBox val = _txtSurname;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
			}
			_txtSurname = value;
			val = _txtSurname;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
			}
		}
	}

	internal virtual TextBox txtName
	{
		[CompilerGenerated]
		get
		{
			return _txtName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Kd5;
			EventHandler eventHandler2 = Ja5;
			TextBox val = _txtName;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
			}
			_txtName = value;
			val = _txtName;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
			}
		}
	}

	internal virtual TextBox txtReg
	{
		[CompilerGenerated]
		get
		{
			return _txtReg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mn8;
			EventHandler eventHandler2 = Ho0;
			TextBox val = _txtReg;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
			}
			_txtReg = value;
			val = _txtReg;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("Button5")]
	internal virtual Button Button5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Qy7;
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

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtSearch
	{
		[CompilerGenerated]
		get
		{
			return _txtSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k6T;
			EventHandler eventHandler2 = Se1;
			TextBox val = _txtSearch;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
				((Control)val).remove_Leave(eventHandler2);
			}
			_txtSearch = value;
			val = _txtSearch;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
				((Control)val).add_Leave(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("txtCashName")]
	internal virtual Label txtCashName
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

	[field: AccessedThroughProperty("txtfeeperTerm")]
	internal virtual TextBox txtfeeperTerm
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

	[field: AccessedThroughProperty("lblAmntPaid")]
	internal virtual TextBox lblAmntPaid
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public c8N()
	{
		((Form)this).add_Load((EventHandler)t3X);
		Dj3();
	}

	[DebuggerNonUserCode]
	protected override void z2H(bool Di4)
	{
		try
		{
			if (Di4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Di4);
		}
	}

	[DebuggerStepThrough]
	private void Dj3()
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
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected O, but got Unknown
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected O, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Expected O, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected O, but got Unknown
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_1142: Expected O, but got Unknown
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Expected O, but got Unknown
		//IL_12bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Expected O, but got Unknown
		//IL_14a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14aa: Expected O, but got Unknown
		//IL_1550: Unknown result type (might be due to invalid IL or missing references)
		//IL_155a: Expected O, but got Unknown
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1649: Expected O, but got Unknown
		//IL_1963: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Expected O, but got Unknown
		//IL_1a22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2c: Expected O, but got Unknown
		//IL_1ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aeb: Expected O, but got Unknown
		//IL_1b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Expected O, but got Unknown
		//IL_1c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c75: Expected O, but got Unknown
		//IL_1ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cab: Expected O, but got Unknown
		//IL_1d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d85: Expected O, but got Unknown
		//IL_1db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbb: Expected O, but got Unknown
		//IL_1e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e95: Expected O, but got Unknown
		//IL_1ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecb: Expected O, but got Unknown
		//IL_1f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa5: Expected O, but got Unknown
		//IL_1fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdb: Expected O, but got Unknown
		//IL_20e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f0: Expected O, but got Unknown
		//IL_2196: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a0: Expected O, but got Unknown
		//IL_2382: Unknown result type (might be due to invalid IL or missing references)
		//IL_238c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(c8N));
		Panel1 = new Panel();
		Label1 = new Label();
		Panel3 = new Panel();
		txtRecept = new TextBox();
		Button4 = new Button();
		Panel8 = new Panel();
		GroupBoxAmt = new GroupBox();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		Panel9 = new Panel();
		lblChange = new TextBox();
		Panel7 = new Panel();
		txtBalance = new TextBox();
		Panel6 = new Panel();
		txtAmt = new TextBox();
		cboStatus = new Label();
		GroupBoxInfo = new GroupBox();
		Label8 = new Label();
		txtfeeperTerm = new TextBox();
		Label6 = new Label();
		avatar = new Button();
		Panel10 = new Panel();
		txtSearch = new TextBox();
		cboTerm = new ComboBox();
		cboClass = new ComboBox();
		Panel4 = new Panel();
		Panel2 = new Panel();
		Panel5 = new Panel();
		txtSurname = new TextBox();
		txtName = new TextBox();
		txtReg = new TextBox();
		Button5 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button1 = new Button();
		btnUpdat = new Button();
		PictureBox1 = new PictureBox();
		txtCashName = new Label();
		lblAmntPaid = new TextBox();
		((Control)Panel1).SuspendLayout();
		((Control)GroupBoxAmt).SuspendLayout();
		((Control)GroupBoxInfo).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.FromArgb(128, 64, 0));
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).set_Dock((DockStyle)1);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(1043, 58));
		((Control)Panel1).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Verdana", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(12, 11));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(237, 32));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Administrative");
		((Control)Panel3).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_Location(new Point(187, 68));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(225, 2));
		((Control)Panel3).set_TabIndex(102);
		((TextBoxBase)txtRecept).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtRecept).set_BorderStyle((BorderStyle)0);
		((Control)txtRecept).set_Enabled(false);
		((Control)txtRecept).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtRecept).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtRecept).set_Location(new Point(229, 35));
		((Control)txtRecept).set_Name("txtRecept");
		((Control)txtRecept).set_Size(new Size(174, 25));
		((Control)txtRecept).set_TabIndex(99);
		txtRecept.set_Text("Receipt Number");
		((ButtonBase)Button4).set_BackColor(Color.Transparent);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button4).set_ForeColor(Color.Lime);
		((Control)Button4).set_Location(new Point(47, 436));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(217, 45));
		((Control)Button4).set_TabIndex(111);
		((ButtonBase)Button4).set_Text("Make Payment");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((Control)Panel8).set_BackColor(Color.FromArgb(255, 128, 0));
		((Control)Panel8).set_Location(new Point(749, 392));
		((Control)Panel8).set_Name("Panel8");
		((Control)Panel8).set_Size(new Size(5, 184));
		((Control)Panel8).set_TabIndex(112);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)Panel9);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)lblChange);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)Panel7);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)txtBalance);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)Panel6);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)txtAmt);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)txtRecept);
		((Control)GroupBoxAmt).get_Controls().Add((Control)(object)Panel3);
		((Control)GroupBoxAmt).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBoxAmt).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)GroupBoxAmt).set_Location(new Point(311, 381));
		((Control)GroupBoxAmt).set_Name("GroupBoxAmt");
		((Control)GroupBoxAmt).set_Size(new Size(418, 215));
		((Control)GroupBoxAmt).set_TabIndex(115);
		GroupBoxAmt.set_TabStop(false);
		GroupBoxAmt.set_Text("Amount To be paid");
		((TextBoxBase)TextBox1).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)0);
		((Control)TextBox1).set_Enabled(false);
		((Control)TextBox1).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)TextBox1).set_Location(new Point(33, 170));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(165, 25));
		((Control)TextBox1).set_TabIndex(111);
		TextBox1.set_Text("change");
		((TextBoxBase)TextBox2).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)0);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)TextBox2).set_Location(new Point(31, 125));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(165, 25));
		((Control)TextBox2).set_TabIndex(110);
		TextBox2.set_Text("Balance");
		((TextBoxBase)TextBox3).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)TextBox3).set_BorderStyle((BorderStyle)0);
		((Control)TextBox3).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)TextBox3).set_Location(new Point(32, 82));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(165, 25));
		((Control)TextBox3).set_TabIndex(109);
		TextBox3.set_Text("Fees Paid");
		((TextBoxBase)TextBox4).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)TextBox4).set_BorderStyle((BorderStyle)0);
		((Control)TextBox4).set_Enabled(false);
		((Control)TextBox4).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox4).set_ForeColor(SystemColors.ControlLightLight);
		((Control)TextBox4).set_Location(new Point(32, 37));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(174, 25));
		((Control)TextBox4).set_TabIndex(108);
		TextBox4.set_Text("Receipt Number");
		((Control)Panel9).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_Enabled(false);
		((Control)Panel9).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_Location(new Point(186, 202));
		((Control)Panel9).set_Name("Panel9");
		((Control)Panel9).set_Size(new Size(217, 2));
		((Control)Panel9).set_TabIndex(107);
		((TextBoxBase)lblChange).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)lblChange).set_BorderStyle((BorderStyle)0);
		((Control)lblChange).set_Enabled(false);
		((Control)lblChange).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)lblChange).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)lblChange).set_Location(new Point(230, 168));
		((Control)lblChange).set_Name("lblChange");
		((Control)lblChange).set_Size(new Size(165, 25));
		((Control)lblChange).set_TabIndex(106);
		lblChange.set_Text("change");
		((Control)Panel7).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_Enabled(false);
		((Control)Panel7).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_Location(new Point(184, 157));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(217, 2));
		((Control)Panel7).set_TabIndex(105);
		((TextBoxBase)txtBalance).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtBalance).set_BorderStyle((BorderStyle)0);
		((Control)txtBalance).set_Enabled(false);
		((Control)txtBalance).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtBalance).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtBalance).set_Location(new Point(228, 123));
		((Control)txtBalance).set_Name("txtBalance");
		((Control)txtBalance).set_Size(new Size(165, 25));
		((Control)txtBalance).set_TabIndex(104);
		txtBalance.set_Text("Balance");
		((Control)Panel6).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_Location(new Point(185, 114));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(217, 2));
		((Control)Panel6).set_TabIndex(103);
		((TextBoxBase)txtAmt).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtAmt).set_BorderStyle((BorderStyle)0);
		((Control)txtAmt).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtAmt).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtAmt).set_Location(new Point(229, 80));
		((Control)txtAmt).set_Name("txtAmt");
		((Control)txtAmt).set_Size(new Size(165, 25));
		((Control)txtAmt).set_TabIndex(102);
		txtAmt.set_Text("Fees Paid");
		cboStatus.set_AutoSize(true);
		((Control)cboStatus).set_Font(new Font("Verdana", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)cboStatus).set_ForeColor(Color.White);
		((Control)cboStatus).set_Location(new Point(241, 569));
		((Control)cboStatus).set_Name("cboStatus");
		((Control)cboStatus).set_Size(new Size(61, 18));
		((Control)cboStatus).set_TabIndex(1);
		cboStatus.set_Text("Status");
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)txtfeeperTerm);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)avatar);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)Panel10);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)txtSearch);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)cboTerm);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)cboClass);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)Panel4);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)Panel2);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)Panel5);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)txtSurname);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)txtName);
		((Control)GroupBoxInfo).get_Controls().Add((Control)(object)txtReg);
		((Control)GroupBoxInfo).set_Font(new Font("Modern No. 20", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBoxInfo).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)GroupBoxInfo).set_Location(new Point(8, 64));
		((Control)GroupBoxInfo).set_Name("GroupBoxInfo");
		((Control)GroupBoxInfo).set_Size(new Size(294, 361));
		((Control)GroupBoxInfo).set_TabIndex(116);
		GroupBoxInfo.set_TabStop(false);
		GroupBoxInfo.set_Text("Student Info");
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Black);
		((Control)Label8).set_Location(new Point(170, 79));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(21, 24));
		((Control)Label8).set_TabIndex(128);
		Label8.set_Text("$");
		((Control)Label8).set_Visible(false);
		((TextBoxBase)txtfeeperTerm).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtfeeperTerm).set_BorderStyle((BorderStyle)0);
		((Control)txtfeeperTerm).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtfeeperTerm).set_ForeColor(Color.Red);
		((Control)txtfeeperTerm).set_Location(new Point(150, 79));
		((Control)txtfeeperTerm).set_Name("txtfeeperTerm");
		((Control)txtfeeperTerm).set_Size(new Size(131, 24));
		((Control)txtfeeperTerm).set_TabIndex(126);
		txtfeeperTerm.set_Text("120");
		txtfeeperTerm.set_TextAlign((HorizontalAlignment)2);
		((Control)txtfeeperTerm).set_Visible(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)Label6).set_Location(new Point(19, 79));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(112, 24));
		((Control)Label6).set_TabIndex(127);
		Label6.set_Text("Fees/Term");
		((Control)Label6).set_Visible(false);
		((ButtonBase)avatar).set_BackColor(Color.FromArgb(30, 47, 68));
		((Control)avatar).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)avatar).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)avatar).set_FlatStyle((FlatStyle)0);
		((Control)avatar).set_Location(new Point(234, 30));
		((Control)avatar).set_Name("avatar");
		((Control)avatar).set_Size(new Size(45, 25));
		((Control)avatar).set_TabIndex(125);
		((ButtonBase)avatar).set_UseVisualStyleBackColor(false);
		((Control)Panel10).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_Location(new Point(12, 61));
		((Control)Panel10).set_Name("Panel10");
		((Control)Panel10).set_Size(new Size(257, 2));
		((Control)Panel10).set_TabIndex(124);
		((TextBoxBase)txtSearch).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtSearch).set_BorderStyle((BorderStyle)0);
		((Control)txtSearch).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtSearch).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtSearch).set_Location(new Point(13, 27));
		((Control)txtSearch).set_Name("txtSearch");
		((Control)txtSearch).set_Size(new Size(228, 26));
		((Control)txtSearch).set_TabIndex(123);
		txtSearch.set_Text("Search here....");
		cboTerm.set_BackColor(Color.FromArgb(30, 47, 68));
		cboTerm.set_FlatStyle((FlatStyle)1);
		((Control)cboTerm).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cboTerm.set_ForeColor(SystemColors.ControlDarkDark);
		((ListControl)cboTerm).set_FormattingEnabled(true);
		cboTerm.get_Items().AddRange(new object[3] { "First Term", "Second Term", "Third Term" });
		((Control)cboTerm).set_Location(new Point(9, 296));
		((Control)cboTerm).set_Name("cboTerm");
		((Control)cboTerm).set_Size(new Size(274, 33));
		((Control)cboTerm).set_TabIndex(122);
		cboTerm.set_Text("Choose Term");
		cboClass.set_BackColor(Color.FromArgb(30, 47, 68));
		cboClass.set_FlatStyle((FlatStyle)1);
		((Control)cboClass).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cboClass.set_ForeColor(SystemColors.ControlDarkDark);
		((ListControl)cboClass).set_FormattingEnabled(true);
		cboClass.get_Items().AddRange(new object[18]
		{
			"1 A", "1 B", "1 C", "2 A", "2 B", "2 C", "3 A", "3 B", "3 C", "4 A",
			"4 B", "4 C", "5 COMMERCIALS", "5 ARTS", "5 SCIENCES", "6 ARTS", "6 COMMERCIALS", "6 SCIENCES"
		});
		((Control)cboClass).set_Location(new Point(7, 255));
		((Control)cboClass).set_Name("cboClass");
		((Control)cboClass).set_Size(new Size(274, 33));
		((Control)cboClass).set_TabIndex(121);
		cboClass.set_Text("Choose class");
		((Control)Panel4).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel4).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel4).set_Location(new Point(6, 247));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(277, 2));
		((Control)Panel4).set_TabIndex(119);
		((Control)Panel2).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_Location(new Point(5, 162));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(277, 2));
		((Control)Panel2).set_TabIndex(116);
		((Control)Panel5).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel5).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel5).set_Location(new Point(6, 206));
		((Control)Panel5).set_Name("Panel5");
		((Control)Panel5).set_Size(new Size(277, 2));
		((Control)Panel5).set_TabIndex(120);
		((TextBoxBase)txtSurname).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtSurname).set_BorderStyle((BorderStyle)0);
		((Control)txtSurname).set_Enabled(false);
		((Control)txtSurname).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtSurname).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtSurname).set_Location(new Point(7, 213));
		((Control)txtSurname).set_Name("txtSurname");
		((Control)txtSurname).set_Size(new Size(275, 25));
		((Control)txtSurname).set_TabIndex(118);
		txtSurname.set_Text("Surname");
		((TextBoxBase)txtName).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtName).set_BorderStyle((BorderStyle)0);
		((Control)txtName).set_Enabled(false);
		((Control)txtName).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtName).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtName).set_Location(new Point(5, 173));
		((Control)txtName).set_Name("txtName");
		((Control)txtName).set_Size(new Size(279, 25));
		((Control)txtName).set_TabIndex(117);
		txtName.set_Text("Name");
		((TextBoxBase)txtReg).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtReg).set_BorderStyle((BorderStyle)0);
		((Control)txtReg).set_Enabled(false);
		((Control)txtReg).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtReg).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtReg).set_Location(new Point(6, 128));
		((Control)txtReg).set_Name("txtReg");
		((Control)txtReg).set_Size(new Size(275, 25));
		((Control)txtReg).set_TabIndex(115);
		txtReg.set_Text("Student ID");
		((ButtonBase)Button5).set_BackColor(Color.Transparent);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(2);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_ForeColor(Color.Red);
		((Control)Button5).set_Location(new Point(47, 487));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(217, 45));
		((Control)Button5).set_TabIndex(117);
		((ButtonBase)Button5).set_Text("Clear");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(Color.Transparent);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_ForeColor(Color.FromArgb(255, 108, 16));
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((ButtonBase)Button2).set_ImageAlign((ContentAlignment)16);
		((Control)Button2).set_Location(new Point(757, 480));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(272, 45));
		((Control)Button2).set_TabIndex(98);
		((ButtonBase)Button2).set_Text("        Examination Fees");
		((ButtonBase)Button2).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button3).set_BackColor(Color.Transparent);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_ForeColor(Color.FromArgb(255, 108, 16));
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((ButtonBase)Button3).set_ImageAlign((ContentAlignment)16);
		((Control)Button3).set_Location(new Point(757, 531));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(272, 45));
		((Control)Button3).set_TabIndex(97);
		((ButtonBase)Button3).set_Text("        Others");
		((ButtonBase)Button3).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(Color.Transparent);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.FromArgb(255, 108, 16));
		((ButtonBase)Button1).set_Image((Image)componentResourceManager.GetObject("Button1.Image"));
		((ButtonBase)Button1).set_ImageAlign((ContentAlignment)16);
		((Control)Button1).set_Location(new Point(757, 378));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(272, 45));
		((Control)Button1).set_TabIndex(96);
		((ButtonBase)Button1).set_Text("        View Payment List");
		((ButtonBase)Button1).set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)btnUpdat).set_BackColor(Color.Transparent);
		((ButtonBase)btnUpdat).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnUpdat).set_FlatStyle((FlatStyle)0);
		((Control)btnUpdat).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnUpdat).set_ForeColor(Color.FromArgb(255, 108, 16));
		((ButtonBase)btnUpdat).set_Image((Image)componentResourceManager.GetObject("btnUpdat.Image"));
		((ButtonBase)btnUpdat).set_ImageAlign((ContentAlignment)16);
		((Control)btnUpdat).set_Location(new Point(757, 429));
		((Control)btnUpdat).set_Name("btnUpdat");
		((Control)btnUpdat).set_Size(new Size(272, 45));
		((Control)btnUpdat).set_TabIndex(95);
		((ButtonBase)btnUpdat).set_Text("        View Arrears");
		((ButtonBase)btnUpdat).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnUpdat).set_UseVisualStyleBackColor(false);
		((Control)PictureBox1).set_Location(new Point(311, 59));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(726, 309));
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		txtCashName.set_AutoSize(true);
		((Control)txtCashName).set_Font(new Font("Verdana", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtCashName).set_ForeColor(Color.White);
		((Control)txtCashName).set_Location(new Point(28, 569));
		((Control)txtCashName).set_Name("txtCashName");
		((Control)txtCashName).set_Size(new Size(44, 18));
		((Control)txtCashName).set_TabIndex(118);
		txtCashName.set_Text("Role");
		((TextBoxBase)lblAmntPaid).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)lblAmntPaid).set_BorderStyle((BorderStyle)0);
		((Control)lblAmntPaid).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)lblAmntPaid).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)lblAmntPaid).set_Location(new Point(80, 541));
		((Control)lblAmntPaid).set_Name("lblAmntPaid");
		((Control)lblAmntPaid).set_Size(new Size(136, 24));
		((Control)lblAmntPaid).set_TabIndex(119);
		lblAmntPaid.set_Text("0");
		lblAmntPaid.set_TextAlign((HorizontalAlignment)2);
		((Control)lblAmntPaid).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(1043, 608));
		((Control)this).get_Controls().Add((Control)(object)lblAmntPaid);
		((Control)this).get_Controls().Add((Control)(object)txtCashName);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)cboStatus);
		((Control)this).get_Controls().Add((Control)(object)GroupBoxInfo);
		((Control)this).get_Controls().Add((Control)(object)GroupBoxAmt);
		((Control)this).get_Controls().Add((Control)(object)Panel8);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)btnUpdat);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("DashBoard");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)GroupBoxAmt).ResumeLayout(false);
		((Control)GroupBoxAmt).PerformLayout();
		((Control)GroupBoxInfo).ResumeLayout(false);
		((Control)GroupBoxInfo).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void k6T(object a6S, EventArgs q3K)
	{
		if (Operators.CompareString(txtSearch.get_Text(), "Search here....", false) == 0)
		{
			txtSearch.set_Text("");
			((TextBoxBase)txtSearch).set_ForeColor(Color.Gray);
		}
	}

	private void Se1(object Sj6, EventArgs s1C)
	{
		if (Operators.CompareString(txtSearch.get_Text(), "", false) == 0)
		{
			txtSearch.set_Text("Search here....");
			((TextBoxBase)txtSearch).set_ForeColor(Color.Gray);
		}
	}

	internal static void Zd9()
	{
		r6P.z3J(t0S8.mDic[t0S8.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}

	private void Mn8(object x1J, EventArgs s2S)
	{
		if (Operators.CompareString(txtReg.get_Text(), "Student ID", false) == 0)
		{
			txtReg.set_Text("");
			((TextBoxBase)txtReg).set_ForeColor(Color.White);
		}
	}

	private void Ho0(object Zx3, EventArgs y6A)
	{
		if (Operators.CompareString(txtReg.get_Text(), "", false) == 0)
		{
			txtReg.set_Text("Student ID");
			((TextBoxBase)txtReg).set_ForeColor(Color.White);
		}
	}

	private void Kd5(object Fi1, EventArgs At6)
	{
		if (Operators.CompareString(txtName.get_Text(), "Name", false) == 0)
		{
			txtName.set_Text("");
			((TextBoxBase)txtName).set_ForeColor(Color.White);
		}
	}

	private void Ja5(object Gw1, EventArgs Dj4)
	{
		if (Operators.CompareString(txtName.get_Text(), "", false) == 0)
		{
			txtName.set_Text("Name");
			((TextBoxBase)txtName).set_ForeColor(Color.Gray);
		}
	}

	private void Yw1(object j6T, EventArgs e0T)
	{
		if (Operators.CompareString(txtSurname.get_Text(), "Surname", false) == 0)
		{
			txtSurname.set_Text("");
			((TextBoxBase)txtSurname).set_ForeColor(Color.White);
		}
	}

	private void Zo3(object Tj4, EventArgs s4J)
	{
		if (Operators.CompareString(txtSurname.get_Text(), "", false) == 0)
		{
			txtSurname.set_Text("Surname");
			((TextBoxBase)txtSurname).set_ForeColor(Color.Gray);
		}
	}

	private void m7A(object s5Y, EventArgs Fa6)
	{
		if (Operators.CompareString(txtRecept.get_Text(), "Receipt Number", false) == 0)
		{
			txtRecept.set_Text("");
			((TextBoxBase)txtRecept).set_ForeColor(Color.Gray);
		}
	}

	private void i7D(object s2J, EventArgs Co8)
	{
		if (Operators.CompareString(txtRecept.get_Text(), "", false) == 0)
		{
			txtRecept.set_Text("Receipt Number");
			((TextBoxBase)txtRecept).set_ForeColor(Color.Gray);
		}
	}

	private void m1H(object Nq0, EventArgs z8B)
	{
		if (Operators.CompareString(txtAmt.get_Text(), "Fees Paid", false) == 0)
		{
			txtAmt.set_Text("");
			((TextBoxBase)txtAmt).set_ForeColor(Color.Gray);
		}
	}

	private void w3A(object j0M, EventArgs n3T)
	{
		if (Operators.CompareString(txtAmt.get_Text(), "", false) == 0)
		{
			txtAmt.set_Text("Fees Paid");
			((TextBoxBase)txtAmt).set_ForeColor(Color.Gray);
		}
	}

	private void t3X(object Ws5, EventArgs j8N)
	{
		((ContainerControl)this).set_ActiveControl((Control)(object)GroupBoxInfo);
		((ContainerControl)this).set_ActiveControl((Control)(object)GroupBoxAmt);
		Af4.d8E();
	}

	private void Tm1(object Ly6, EventArgs w6H)
	{
		txtBalance.set_Text(Conversions.ToString(Conversion.Val(txtfeeperTerm.get_Text()) - Conversion.Val(txtAmt.get_Text())));
		lblChange.set_Text(Conversions.ToString(Conversion.Val(txtAmt.get_Text()) - Conversion.Val(txtfeeperTerm.get_Text())));
		if (Conversion.Val(txtAmt.get_Text()) > 120.0)
		{
			lblAmntPaid.set_Text(Conversions.ToString(120));
		}
		else
		{
			lblAmntPaid.set_Text(txtAmt.get_Text());
		}
		if (Conversions.ToDouble(txtBalance.get_Text()) < 0.0)
		{
			txtBalance.set_Text(Conversions.ToString(0.0));
		}
		if (Conversions.ToDouble(lblChange.get_Text()) < 0.0)
		{
			lblChange.set_Text(Conversions.ToString(0.0));
		}
		if (Conversion.Val(lblAmntPaid.get_Text()) == 120.0)
		{
			cboStatus.set_Text("YES");
		}
		else if ((Conversion.Val(lblAmntPaid.get_Text()) >= 40.0) & (Conversion.Val(lblAmntPaid.get_Text()) <= 119.0))
		{
			cboStatus.set_Text("NO");
		}
	}

	internal static string Dp6(string Mo5)
	{
		Type type = (Type)t0S8.mDic[t0S8.T];
		return Conversions.ToString(type.InvokeMember(Mo5, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	private void c8P(object d4B, EventArgs q3G)
	{
		Af4.k1W();
	}

	private void Qy7(object m9S, EventArgs w7R)
	{
		Af4.Ep9();
	}

	private void Gc2(object Tf4, EventArgs y8X)
	{
		((Control)Ng2.Forms.Gross_Fees_Paid).Show();
		((Form)Ng2.Forms.Gross_Fees_Paid).set_Location(new Point(146, 114));
		((Control)Ng2.Forms.Home.PanelHide).set_Visible(true);
	}
}
