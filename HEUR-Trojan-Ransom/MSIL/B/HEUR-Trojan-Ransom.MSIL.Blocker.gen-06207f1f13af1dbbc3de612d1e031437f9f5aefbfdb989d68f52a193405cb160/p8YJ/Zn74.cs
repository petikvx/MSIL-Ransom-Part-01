using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d2RH;
using g2H;

namespace p8YJ;

[DesignerGenerated]
public class Zn74 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbClass")]
	internal virtual ComboBox cmbClass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmbGender")]
	internal virtual ComboBox cmbGender
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b5H;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = r1G;
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

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
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

	internal virtual TextBox txtNational
	{
		[CompilerGenerated]
		get
		{
			return _txtNational;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = x2Q;
			KeyEventHandler val = new KeyEventHandler(t3P);
			EventHandler eventHandler2 = w7P;
			TextBox val2 = _txtNational;
			if (val2 != null)
			{
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_KeyUp(val);
				((TextBoxBase)val2).remove_Click(eventHandler2);
			}
			_txtNational = value;
			val2 = _txtNational;
			if (val2 != null)
			{
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_KeyUp(val);
				((TextBoxBase)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
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

	internal virtual TextBox txtGuid
	{
		[CompilerGenerated]
		get
		{
			return _txtGuid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = Br4;
			KeyEventHandler val = new KeyEventHandler(Pi5);
			EventHandler eventHandler2 = Dx6;
			TextBox val2 = _txtGuid;
			if (val2 != null)
			{
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_KeyUp(val);
				((TextBoxBase)val2).remove_Click(eventHandler2);
			}
			_txtGuid = value;
			val2 = _txtGuid;
			if (val2 != null)
			{
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_KeyUp(val);
				((TextBoxBase)val2).add_Click(eventHandler2);
			}
		}
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

	internal virtual TextBox txtPhone
	{
		[CompilerGenerated]
		get
		{
			return _txtPhone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = j5R;
			KeyEventHandler val = new KeyEventHandler(Tm7);
			EventHandler eventHandler2 = Qw5;
			TextBox val2 = _txtPhone;
			if (val2 != null)
			{
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_KeyUp(val);
				((TextBoxBase)val2).remove_Click(eventHandler2);
			}
			_txtPhone = value;
			val2 = _txtPhone;
			if (val2 != null)
			{
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_KeyUp(val);
				((TextBoxBase)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtFname
	{
		[CompilerGenerated]
		get
		{
			return _txtFname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = Fg2;
			KeyEventHandler val = new KeyEventHandler(d7C);
			EventHandler eventHandler2 = y8T;
			TextBox val2 = _txtFname;
			if (val2 != null)
			{
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_KeyUp(val);
				((TextBoxBase)val2).remove_Click(eventHandler2);
			}
			_txtFname = value;
			val2 = _txtFname;
			if (val2 != null)
			{
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_KeyUp(val);
				((TextBoxBase)val2).add_Click(eventHandler2);
			}
		}
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
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			EventHandler eventHandler = j1K;
			KeyEventHandler val = new KeyEventHandler(y4F);
			EventHandler eventHandler2 = Lp7;
			TextBox val2 = _txtSurname;
			if (val2 != null)
			{
				((Control)val2).remove_MouseLeave(eventHandler);
				((Control)val2).remove_KeyUp(val);
				((TextBoxBase)val2).remove_Click(eventHandler2);
			}
			_txtSurname = value;
			val2 = _txtSurname;
			if (val2 != null)
			{
				((Control)val2).add_MouseLeave(eventHandler);
				((Control)val2).add_KeyUp(val);
				((TextBoxBase)val2).add_Click(eventHandler2);
			}
		}
	}

	[field: AccessedThroughProperty("txtReg")]
	internal virtual TextBox txtReg
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("DOBPick")]
	internal virtual DateTimePicker DOBPick
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

	[field: AccessedThroughProperty("txtAddress")]
	internal virtual TextBox txtAddress
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

	public Zn74()
	{
		((Form)this).add_Load((EventHandler)m7K);
		Dm7();
	}

	[DebuggerNonUserCode]
	protected override void a0B4(bool m5E9)
	{
		try
		{
			if (m5E9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m5E9);
		}
	}

	[DebuggerStepThrough]
	private void Dm7()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected O, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected O, but got Unknown
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected O, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected O, but got Unknown
		//IL_0f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f57: Expected O, but got Unknown
		//IL_100d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected O, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_114d: Expected O, but got Unknown
		//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f8: Expected O, but got Unknown
		//IL_1284: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Expected O, but got Unknown
		//IL_132c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1336: Expected O, but got Unknown
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13de: Expected O, but got Unknown
		//IL_147c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Expected O, but got Unknown
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_152e: Expected O, but got Unknown
		//IL_15cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d6: Expected O, but got Unknown
		//IL_1674: Unknown result type (might be due to invalid IL or missing references)
		//IL_167e: Expected O, but got Unknown
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_173e: Expected O, but got Unknown
		//IL_1883: Unknown result type (might be due to invalid IL or missing references)
		//IL_188d: Expected O, but got Unknown
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_191b: Expected O, but got Unknown
		Panel1 = new Panel();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		cmbClass = new ComboBox();
		cmbGender = new ComboBox();
		Button2 = new Button();
		Button1 = new Button();
		Panel11 = new Panel();
		Panel10 = new Panel();
		txtNational = new TextBox();
		Panel9 = new Panel();
		Panel8 = new Panel();
		txtGuid = new TextBox();
		Panel6 = new Panel();
		Panel7 = new Panel();
		txtPhone = new TextBox();
		Panel4 = new Panel();
		txtFname = new TextBox();
		Panel2 = new Panel();
		Panel3 = new Panel();
		txtSurname = new TextBox();
		txtReg = new TextBox();
		Label10 = new Label();
		Label11 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		DOBPick = new DateTimePicker();
		Panel12 = new Panel();
		txtAddress = new TextBox();
		Label13 = new Label();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel1).set_Dock((DockStyle)1);
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(738, 67));
		((Control)Panel1).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Bauhaus 93", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(96, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(220, 54));
		((Control)Label1).set_TabIndex(18);
		Label1.set_Text("SIMS APP");
		((Control)PictureBox2).set_BackgroundImageLayout((ImageLayout)4);
		((Control)PictureBox2).set_Location(new Point(12, 6));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(103, 58));
		PictureBox2.set_TabIndex(17);
		PictureBox2.set_TabStop(false);
		cmbClass.set_BackColor(Color.FromArgb(30, 47, 68));
		cmbClass.set_FlatStyle((FlatStyle)1);
		((Control)cmbClass).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cmbClass.set_ForeColor(SystemColors.Info);
		((ListControl)cmbClass).set_FormattingEnabled(true);
		cmbClass.get_Items().AddRange(new object[18]
		{
			"1 A", "1 B", "1 C", "2 A", "2 B", "2 C", "3 A", "3 B", "3 C", "4 A",
			"4 B", "4 C", "5 COMS", "5 ARTS", "5 SCIENCES", "6 ARTS", "6 COMS", "6 SCIENCES"
		});
		((Control)cmbClass).set_Location(new Point(425, 340));
		((Control)cmbClass).set_Name("cmbClass");
		((Control)cmbClass).set_Size(new Size(221, 33));
		((Control)cmbClass).set_TabIndex(64);
		cmbClass.set_Text("Choose class");
		cmbGender.set_BackColor(Color.FromArgb(30, 47, 68));
		cmbGender.set_FlatStyle((FlatStyle)1);
		((Control)cmbGender).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		cmbGender.set_ForeColor(SystemColors.Info);
		((ListControl)cmbGender).set_FormattingEnabled(true);
		cmbGender.get_Items().AddRange(new object[2] { "Male", "Female" });
		((Control)cmbGender).set_Location(new Point(425, 251));
		((Control)cmbGender).set_Name("cmbGender");
		((Control)cmbGender).set_Size(new Size(221, 33));
		((Control)cmbGender).set_TabIndex(63);
		cmbGender.set_Text("Select Gender");
		((ButtonBase)Button2).set_BackColor(Color.Red);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_Location(new Point(486, 564));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(180, 45));
		((Control)Button2).set_TabIndex(62);
		((ButtonBase)Button2).set_Text("Close");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(Color.FromArgb(255, 108, 16));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(253, 564));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(216, 45));
		((Control)Button1).set_TabIndex(61);
		((ButtonBase)Button1).set_Text("Enroll Me");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Panel11).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel11).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel11).set_Location(new Point(254, 287));
		((Control)Panel11).set_Name("Panel11");
		((Control)Panel11).set_Size(new Size(393, 2));
		((Control)Panel11).set_TabIndex(60);
		((Control)Panel10).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel10).set_Location(new Point(257, 332));
		((Control)Panel10).set_Name("Panel10");
		((Control)Panel10).set_Size(new Size(393, 2));
		((Control)Panel10).set_TabIndex(59);
		((TextBoxBase)txtNational).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtNational).set_BorderStyle((BorderStyle)0);
		((Control)txtNational).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtNational).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtNational).set_Location(new Point(301, 299));
		((Control)txtNational).set_Name("txtNational");
		((Control)txtNational).set_Size(new Size(353, 26));
		((Control)txtNational).set_TabIndex(56);
		txtNational.set_Text("Enter Nationality");
		((Control)Panel9).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel9).set_Location(new Point(253, 374));
		((Control)Panel9).set_Name("Panel9");
		((Control)Panel9).set_Size(new Size(393, 2));
		((Control)Panel9).set_TabIndex(58);
		((Control)Panel8).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel8).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel8).set_Location(new Point(254, 417));
		((Control)Panel8).set_Name("Panel8");
		((Control)Panel8).set_Size(new Size(393, 2));
		((Control)Panel8).set_TabIndex(57);
		((TextBoxBase)txtGuid).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtGuid).set_BorderStyle((BorderStyle)0);
		((Control)txtGuid).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtGuid).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtGuid).set_Location(new Point(298, 384));
		((Control)txtGuid).set_Name("txtGuid");
		((Control)txtGuid).set_Size(new Size(353, 26));
		((Control)txtGuid).set_TabIndex(55);
		txtGuid.set_Text("Enter Guidence");
		((Control)Panel6).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel6).set_Location(new Point(255, 456));
		((Control)Panel6).set_Name("Panel6");
		((Control)Panel6).set_Size(new Size(393, 2));
		((Control)Panel6).set_TabIndex(51);
		((Control)Panel7).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel7).set_Location(new Point(254, 239));
		((Control)Panel7).set_Name("Panel7");
		((Control)Panel7).set_Size(new Size(393, 2));
		((Control)Panel7).set_TabIndex(53);
		((TextBoxBase)txtPhone).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtPhone).set_BorderStyle((BorderStyle)0);
		((Control)txtPhone).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtPhone).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtPhone).set_Location(new Point(298, 422));
		((Control)txtPhone).set_Name("txtPhone");
		((Control)txtPhone).set_Size(new Size(349, 26));
		((Control)txtPhone).set_TabIndex(50);
		txtPhone.set_Text("Enter Phone Number");
		((Control)Panel4).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel4).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel4).set_Location(new Point(258, 198));
		((Control)Panel4).set_Name("Panel4");
		((Control)Panel4).set_Size(new Size(393, 2));
		((Control)Panel4).set_TabIndex(48);
		((TextBoxBase)txtFname).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtFname).set_BorderStyle((BorderStyle)0);
		((Control)txtFname).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtFname).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtFname).set_Location(new Point(301, 164));
		((Control)txtFname).set_Name("txtFname");
		((Control)txtFname).set_Size(new Size(349, 26));
		((Control)txtFname).set_TabIndex(47);
		txtFname.set_Text("Enter Name");
		((Control)Panel2).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_Location(new Point(254, 156));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(393, 2));
		((Control)Panel2).set_TabIndex(45);
		((Control)Panel3).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_Location(new Point(255, 115));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(393, 2));
		((Control)Panel3).set_TabIndex(46);
		((TextBoxBase)txtSurname).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtSurname).set_BorderStyle((BorderStyle)0);
		((Control)txtSurname).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtSurname).set_ForeColor(SystemColors.ControlDarkDark);
		((Control)txtSurname).set_Location(new Point(297, 122));
		((Control)txtSurname).set_Name("txtSurname");
		((Control)txtSurname).set_Size(new Size(349, 26));
		((Control)txtSurname).set_TabIndex(44);
		txtSurname.set_Text("Enter Surname");
		((TextBoxBase)txtReg).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtReg).set_BorderStyle((BorderStyle)0);
		((Control)txtReg).set_Enabled(false);
		((Control)txtReg).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtReg).set_ForeColor(SystemColors.ScrollBar);
		((Control)txtReg).set_Location(new Point(299, 82));
		((Control)txtReg).set_Name("txtReg");
		((Control)txtReg).set_Size(new Size(353, 26));
		((Control)txtReg).set_TabIndex(43);
		Label10.set_AutoSize(true);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label10).set_Location(new Point(68, 436));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(152, 24));
		((Control)Label10).set_TabIndex(41);
		Label10.set_Text("Phone Number");
		Label11.set_AutoSize(true);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label11).set_Location(new Point(68, 396));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(161, 24));
		((Control)Label11).set_TabIndex(40);
		Label11.set_Text("Guidance Name");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label6).set_Location(new Point(84, 420));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(0, 24));
		((Control)Label6).set_TabIndex(39);
		Label7.set_AutoSize(true);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label7).set_Location(new Point(68, 353));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(60, 24));
		((Control)Label7).set_TabIndex(38);
		Label7.set_Text("Class");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label8).set_Location(new Point(68, 313));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(106, 24));
		((Control)Label8).set_TabIndex(37);
		Label8.set_Text("Nationality");
		Label9.set_AutoSize(true);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label9).set_Location(new Point(68, 270));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(80, 24));
		((Control)Label9).set_TabIndex(36);
		Label9.set_Text("Gender");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label4).set_Location(new Point(68, 224));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(123, 24));
		((Control)Label4).set_TabIndex(35);
		Label4.set_Text("Date of Birth");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label5).set_Location(new Point(68, 181));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(111, 24));
		((Control)Label5).set_TabIndex(34);
		Label5.set_Text("First Name");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label3).set_Location(new Point(68, 141));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(94, 24));
		((Control)Label3).set_TabIndex(33);
		Label3.set_Text("Surname");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label2).set_Location(new Point(68, 98));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(106, 24));
		((Control)Label2).set_TabIndex(32);
		Label2.set_Text("Student ID");
		DOBPick.set_CalendarForeColor(SystemColors.ButtonFace);
		DOBPick.set_CalendarMonthBackground(Color.FromArgb(30, 47, 68));
		((Control)DOBPick).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		DOBPick.set_Format((DateTimePickerFormat)2);
		((Control)DOBPick).set_Location(new Point(425, 206));
		((Control)DOBPick).set_Name("DOBPick");
		((Control)DOBPick).set_Size(new Size(221, 29));
		((Control)DOBPick).set_TabIndex(66);
		DOBPick.set_Value(new DateTime(2019, 1, 31, 0, 0, 0, 0));
		((Control)Panel12).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel12).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel12).set_Location(new Point(253, 504));
		((Control)Panel12).set_Name("Panel12");
		((Control)Panel12).set_Size(new Size(393, 2));
		((Control)Panel12).set_TabIndex(54);
		((TextBoxBase)txtAddress).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtAddress).set_BorderStyle((BorderStyle)0);
		((Control)txtAddress).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtAddress).set_ForeColor(SystemColors.ScrollBar);
		((Control)txtAddress).set_Location(new Point(296, 470));
		((Control)txtAddress).set_Name("txtAddress");
		((Control)txtAddress).set_Size(new Size(349, 26));
		((Control)txtAddress).set_TabIndex(53);
		Label13.set_AutoSize(true);
		((Control)Label13).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Label13).set_Location(new Point(66, 484));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(87, 24));
		((Control)Label13).set_TabIndex(52);
		Label13.set_Text("Address");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(738, 638));
		((Control)this).get_Controls().Add((Control)(object)Panel12);
		((Control)this).get_Controls().Add((Control)(object)txtAddress);
		((Control)this).get_Controls().Add((Control)(object)DOBPick);
		((Control)this).get_Controls().Add((Control)(object)Label13);
		((Control)this).get_Controls().Add((Control)(object)cmbClass);
		((Control)this).get_Controls().Add((Control)(object)cmbGender);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Panel11);
		((Control)this).get_Controls().Add((Control)(object)Panel10);
		((Control)this).get_Controls().Add((Control)(object)txtNational);
		((Control)this).get_Controls().Add((Control)(object)Panel9);
		((Control)this).get_Controls().Add((Control)(object)Panel8);
		((Control)this).get_Controls().Add((Control)(object)txtGuid);
		((Control)this).get_Controls().Add((Control)(object)Panel6);
		((Control)this).get_Controls().Add((Control)(object)Panel7);
		((Control)this).get_Controls().Add((Control)(object)txtPhone);
		((Control)this).get_Controls().Add((Control)(object)Panel4);
		((Control)this).get_Controls().Add((Control)(object)txtFname);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)txtSurname);
		((Control)this).get_Controls().Add((Control)(object)txtReg);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Stundentform");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Stundentform");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void b5H(object Lx9, EventArgs Qd8)
	{
		((Control)this).Hide();
		((Control)Gw5.Forms.Home.MenuBarMid).Show();
	}

	private void m7K(object z6T, EventArgs i3L)
	{
		k6FD.e9DW();
	}

	private void j1K(object Ee8, EventArgs Tx1)
	{
		k6FD.g7CF();
	}

	private void Fg2(object Sf8, EventArgs b9A)
	{
		k6FD.Sn9p();
	}

	private void x2Q(object Ta9, EventArgs m8M)
	{
		k6FD.Hd7r();
	}

	private void Br4(object q5E, EventArgs f2G)
	{
		k6FD.Cb0a();
	}

	private void j5R(object r6J, EventArgs z1K)
	{
		k6FD.En2g();
	}

	private void y4F(object c2Z, KeyEventArgs c6N)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (char.IsNumber(Strings.ChrW((int)c6N.get_KeyCode())))
		{
			Interaction.MsgBox((object)"Please only letters for Surname", (MsgBoxStyle)16, (object)null);
			txtSurname.set_Text("");
		}
	}

	private void d7C(object Xz0, KeyEventArgs p4K)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (char.IsNumber(Strings.ChrW((int)p4K.get_KeyCode())))
		{
			Interaction.MsgBox((object)"Please only letters for Name", (MsgBoxStyle)16, (object)null);
			txtFname.set_Text("");
		}
	}

	private void t3P(object d6S, KeyEventArgs Hd5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (char.IsNumber(Strings.ChrW((int)Hd5.get_KeyCode())))
		{
			Interaction.MsgBox((object)"Please only letters are needed for Nationality", (MsgBoxStyle)16, (object)null);
			txtNational.set_Text("");
		}
	}

	private void Pi5(object i8Z, KeyEventArgs e9Q)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (char.IsNumber(Strings.ChrW((int)e9Q.get_KeyCode())))
		{
			Interaction.MsgBox((object)"Please only letters are needed for Guidance", (MsgBoxStyle)16, (object)null);
			txtGuid.set_Text("");
		}
	}

	private void Tm7(object En6, KeyEventArgs n2Z)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (!char.IsNumber(Strings.ChrW((int)n2Z.get_KeyCode())))
		{
			Interaction.MsgBox((object)"Please only numbers are allowed her 0123456789", (MsgBoxStyle)16, (object)null);
			txtPhone.set_Text("");
		}
	}

	internal static bool f7Q()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string ct in array2)
				{
					if (!f5J(ct))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}

	private void r1G(object c8W, EventArgs i0H)
	{
		k6FD.c3P9();
	}

	private void Lp7(object Rt8, EventArgs Sw3)
	{
		k6FD.Ae5z();
	}

	private void y8T(object r0B, EventArgs a5C)
	{
		k6FD.Cs81();
	}

	private void w7P(object b2K, EventArgs Tj0)
	{
		k6FD.Ag2k();
	}

	private void Dx6(object Po0, EventArgs b1X)
	{
		k6FD.z9MX();
	}

	internal static bool f5J(string Ct7)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Ct7);
			WebResponse response = webRequest.GetResponse();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private void Qw5(object Dc2, EventArgs r0W)
	{
		k6FD.Nf8o();
	}
}
