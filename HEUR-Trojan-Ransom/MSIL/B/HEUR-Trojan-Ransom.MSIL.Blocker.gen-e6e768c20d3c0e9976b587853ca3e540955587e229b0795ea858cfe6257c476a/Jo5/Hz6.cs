using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ha9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using i5WJ;
using k2R;

namespace Jo5;

[DesignerGenerated]
public class Hz6 : Form
{
	private IContainer components;

	private byte[] Photos1;

	private SqlDataReader dr;

	private string str1;

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
			EventHandler eventHandler = q6S;
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
			EventHandler eventHandler = Tz4;
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

	[field: AccessedThroughProperty("TextBox10")]
	internal virtual TextBox TextBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = t8M;
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
			EventHandler eventHandler = Gs2;
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
			EventHandler eventHandler = x6F;
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

	[field: AccessedThroughProperty("TextBox9")]
	internal virtual TextBox TextBox9
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
			EventHandler eventHandler = Tb2;
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
			EventHandler eventHandler = Sw9;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Rs2;
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
			EventHandler eventHandler = Nj9;
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
			EventHandler eventHandler = g0C;
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
			EventHandler eventHandler = Tn4;
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = g0Z;
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
			EventHandler eventHandler = r6H;
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Cw9;
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
			EventHandler eventHandler = Tr3;
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

	[field: AccessedThroughProperty("OpenFileDialog1")]
	internal virtual OpenFileDialog OpenFileDialog1
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
			EventHandler eventHandler = Sq2;
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

	[field: AccessedThroughProperty("TextBox11")]
	internal virtual TextBox TextBox11
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

	public Hz6()
	{
		((Form)this).add_Load((EventHandler)Sd2);
		d5K();
	}

	[DebuggerNonUserCode]
	protected override void a3Q(bool g4F)
	{
		try
		{
			if (g4F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g4F);
		}
	}

	[DebuggerStepThrough]
	private void d5K()
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
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected O, but got Unknown
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected O, but got Unknown
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected O, but got Unknown
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected O, but got Unknown
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eca: Expected O, but got Unknown
		//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected O, but got Unknown
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Expected O, but got Unknown
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Expected O, but got Unknown
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected O, but got Unknown
		//IL_118e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1198: Expected O, but got Unknown
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected O, but got Unknown
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Hz6));
		Button7 = new Button();
		Button6 = new Button();
		TextBox10 = new TextBox();
		Label12 = new Label();
		Button3 = new Button();
		Button5 = new Button();
		TextBox9 = new TextBox();
		Button2 = new Button();
		Label11 = new Label();
		TextBox8 = new TextBox();
		GroupBox1 = new GroupBox();
		TextBox11 = new TextBox();
		Label13 = new Label();
		ComboBox2 = new ComboBox();
		Label10 = new Label();
		TextBox4 = new TextBox();
		Label9 = new Label();
		TextBox5 = new TextBox();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		PictureBox1 = new PictureBox();
		TextBox2 = new TextBox();
		Label3 = new Label();
		TextBox1 = new TextBox();
		Label2 = new Label();
		DateTimePicker1 = new DateTimePicker();
		ComboBox1 = new ComboBox();
		TextBox6 = new TextBox();
		TextBox7 = new TextBox();
		TextBox3 = new TextBox();
		Label1 = new Label();
		OpenFileDialog1 = new OpenFileDialog();
		Panel1 = new Panel();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Button7).set_BackColor(Color.White);
		Button7.set_DialogResult((DialogResult)2);
		((ButtonBase)Button7).get_FlatAppearance().set_BorderColor(Color.FromArgb(255, 128, 128));
		((ButtonBase)Button7).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button7).get_FlatAppearance().set_MouseOverBackColor(Color.WhiteSmoke);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)0);
		((Control)Button7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button7).set_Location(new Point(285, 292));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(98, 29));
		((Control)Button7).set_TabIndex(27);
		((ButtonBase)Button7).set_Text("Clear");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button6).set_BackColor(Color.White);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button6).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button6).get_FlatAppearance().set_MouseOverBackColor(Color.PaleTurquoise);
		((ButtonBase)Button6).set_FlatStyle((FlatStyle)0);
		((Control)Button6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button6).set_Location(new Point(29, 292));
		((Control)Button6).set_Name("Button6");
		((Control)Button6).set_Size(new Size(98, 29));
		((Control)Button6).set_TabIndex(26);
		((ButtonBase)Button6).set_Text("Search");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(false);
		((Control)TextBox10).set_Location(new Point(454, 247));
		TextBox10.set_Multiline(true);
		((Control)TextBox10).set_Name("TextBox10");
		((Control)TextBox10).set_Size(new Size(294, 30));
		((Control)TextBox10).set_TabIndex(25);
		((Control)Label12).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_Location(new Point(365, 250));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(87, 27));
		((Control)Label12).set_TabIndex(24);
		Label12.set_Text("Doc. Attach");
		Label12.set_TextAlign((ContentAlignment)16);
		((ButtonBase)Button3).set_BackColor(Color.White);
		Button3.set_DialogResult((DialogResult)2);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button3).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button3).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 192, 128));
		((ButtonBase)Button3).set_FlatStyle((FlatStyle)0);
		((Control)Button3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button3).set_Location(new Point(415, 292));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(98, 29));
		((Control)Button3).set_TabIndex(20);
		((ButtonBase)Button3).set_Text("Cancel");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button5).set_BackColor(Color.White);
		((ButtonBase)Button5).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Location(new Point(609, 166));
		((Control)Button5).set_Name("Button5");
		((Control)Button5).set_Size(new Size(139, 29));
		((Control)Button5).set_TabIndex(22);
		((ButtonBase)Button5).set_Text("Upload Image");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		((Control)TextBox9).set_Location(new Point(119, 213));
		TextBox9.set_Multiline(true);
		((Control)TextBox9).set_Name("TextBox9");
		((Control)TextBox9).set_Size(new Size(221, 27));
		((Control)TextBox9).set_TabIndex(23);
		((ButtonBase)Button2).set_BackColor(Color.White);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderColor(Color.LightSkyBlue);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button2).get_FlatAppearance().set_MouseOverBackColor(Color.White);
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button2).set_Location(new Point(156, 292));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(98, 29));
		((Control)Button2).set_TabIndex(19);
		((ButtonBase)Button2).set_Text("Update");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Control)Label11).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(2, 213));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(125, 27));
		((Control)Label11).set_TabIndex(22);
		Label11.set_Text("Parent Ph. No. ");
		Label11.set_TextAlign((ContentAlignment)16);
		((Control)TextBox8).set_Location(new Point(119, 250));
		TextBox8.set_Multiline(true);
		((Control)TextBox8).set_Name("TextBox8");
		((Control)TextBox8).set_Size(new Size(221, 27));
		((Control)TextBox8).set_TabIndex(21);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label13);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label12);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label11);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label10);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label9);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label7);
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
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(0, 57));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(764, 338));
		((Control)GroupBox1).set_TabIndex(20);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Student Information");
		((Control)TextBox11).set_Location(new Point(454, 172));
		TextBox11.set_Multiline(true);
		((Control)TextBox11).set_Name("TextBox11");
		((Control)TextBox11).set_Size(new Size(128, 30));
		((Control)TextBox11).set_TabIndex(30);
		((Control)Label13).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label13).set_Location(new Point(365, 172));
		((Control)Label13).set_Name("Label13");
		((Control)Label13).set_Size(new Size(87, 29));
		((Control)Label13).set_TabIndex(29);
		Label13.set_Text("Class");
		Label13.set_TextAlign((ContentAlignment)16);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		((Control)ComboBox2).set_Location(new Point(454, 26));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(128, 24));
		((Control)ComboBox2).set_TabIndex(28);
		((Control)Label10).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(2, 247));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(111, 27));
		((Control)Label10).set_TabIndex(20);
		Label10.set_Text("Course ");
		Label10.set_TextAlign((ContentAlignment)16);
		((Control)TextBox4).set_Location(new Point(454, 210));
		TextBox4.set_Multiline(true);
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(294, 30));
		((Control)TextBox4).set_TabIndex(19);
		((Control)Label9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(365, 210));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(87, 29));
		((Control)Label9).set_TabIndex(18);
		Label9.set_Text("E-mail Id ");
		Label9.set_TextAlign((ContentAlignment)16);
		((Control)TextBox5).set_Location(new Point(119, 175));
		TextBox5.set_Multiline(true);
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(221, 27));
		((Control)TextBox5).set_TabIndex(14);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(2, 175));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(111, 27));
		((Control)Label8).set_TabIndex(13);
		Label8.set_Text("Mobile No. ");
		Label8.set_TextAlign((ContentAlignment)16);
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(365, 140));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(87, 24));
		((Control)Label7).set_TabIndex(11);
		Label7.set_Text("Gender");
		Label7.set_TextAlign((ContentAlignment)16);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(365, 24));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(60, 30));
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("PRN ");
		Label6.set_TextAlign((ContentAlignment)16);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(606, 9));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(142, 28));
		((Control)Label5).set_TabIndex(7);
		Label5.set_Text("Image :-");
		Label5.set_TextAlign((ContentAlignment)32);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(2, 139));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(111, 22));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Date Of Birth ");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(606, 40));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(142, 125));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		((Control)TextBox2).set_Location(new Point(119, 65));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(463, 61));
		((Control)TextBox2).set_TabIndex(4);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(2, 65));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(85, 27));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Address ");
		((Control)TextBox1).set_Location(new Point(119, 26));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(221, 28));
		((Control)TextBox1).set_TabIndex(2);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(2, 26));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(90, 28));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Name ");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)DateTimePicker1).set_AllowDrop(true);
		DateTimePicker1.set_CustomFormat("");
		DateTimePicker1.set_Format((DateTimePickerFormat)8);
		((Control)DateTimePicker1).set_Location(new Point(119, 139));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(121, 22));
		((Control)DateTimePicker1).set_TabIndex(8);
		DateTimePicker1.set_Value(new DateTime(2015, 3, 5, 0, 0, 0, 0));
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[2] { "Male", "Female" });
		((Control)ComboBox1).set_Location(new Point(454, 140));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(128, 24));
		((Control)ComboBox1).set_TabIndex(17);
		((Control)TextBox6).set_Location(new Point(119, 139));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(121, 22));
		((Control)TextBox6).set_TabIndex(15);
		((Control)TextBox7).set_Location(new Point(454, 142));
		((Control)TextBox7).set_Name("TextBox7");
		((Control)TextBox7).set_Size(new Size(128, 22));
		((Control)TextBox7).set_TabIndex(16);
		((Control)TextBox3).set_Location(new Point(454, 28));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(128, 22));
		((Control)TextBox3).set_TabIndex(10);
		((Control)Label1).set_BackColor(Color.LightSkyBlue);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(0, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(779, 48));
		((Control)Label1).set_TabIndex(19);
		Label1.set_Text("INFORMATION FORM");
		Label1.set_TextAlign((ContentAlignment)32);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((Control)Panel1).set_Location(new Point(0, 0));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(764, 48));
		((Control)Panel1).set_TabIndex(18);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_ClientSize(new Size(771, 401));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(781, 434));
		((Form)this).set_MinimumSize(new Size(781, 434));
		((Control)this).set_Name("AddmisionForm1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("AddmisionForm1");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void Sd2(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		y5S.ds.Clear();
		y5S.y6M();
		y5S.cn.Open();
		y5S.str = "select * from InformationForm";
		y5S.cmd = new SqlCommand(y5S.str, y5S.cn);
		y5S.da.set_SelectCommand(y5S.cmd);
		((DbDataAdapter)(object)y5S.da).Fill(y5S.ds, "InformationForm");
		checked
		{
			int num = y5S.ds.Tables["InformationForm"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox2.get_Items().Add((object)y5S.ds.Tables["InformationForm"]!.Rows[i][2].ToString());
			}
			y5S.cn.Close();
		}
	}

	private void Gq1(object sender, EventArgs e)
	{
	}

	private void r6H(object sender, EventArgs e)
	{
	}

	private void Tn4(object sender, EventArgs e)
	{
	}

	private void Cw9(object sender, EventArgs e)
	{
	}

	private void g0C(object sender, EventArgs e)
	{
	}

	private void Nj9(object sender, EventArgs e)
	{
	}

	private void Rs2(object sender, EventArgs e)
	{
	}

	private void Sw9(object sender, EventArgs e)
	{
	}

	private void t8M(object sender, EventArgs e)
	{
	}

	private void Tr3(object sender, EventArgs e)
	{
	}

	private void Tz4(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				((Control)DateTimePicker1).set_Visible(false);
				((Control)ComboBox1).set_Visible(false);
				int num = 0;
				y5S.cn.Open();
				y5S.str = "select * from InformationForm ";
				y5S.cmd = new SqlCommand(y5S.str, y5S.cn);
				y5S.da.set_SelectCommand(y5S.cmd);
				((DbDataAdapter)(object)y5S.da).Fill(y5S.ds, "InformationForm");
				int num2 = y5S.ds.Tables["InformationForm"]!.Rows.Count - 1;
				int num3 = num2;
				for (num = 0; num <= num3; num++)
				{
					if (Operators.CompareString(TextBox3.get_Text(), y5S.ds.Tables["InformationForm"]!.Rows[num][2].ToString(), false) == 0)
					{
						TextBox1.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][0].ToString());
						TextBox2.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][1].ToString());
						TextBox3.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][2].ToString());
						TextBox4.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][3].ToString());
						TextBox5.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][4].ToString());
						TextBox6.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][5].ToString());
						TextBox7.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][6].ToString());
						TextBox8.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][7].ToString());
						TextBox9.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][8].ToString());
						TextBox10.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][9].ToString());
						TextBox11.set_Text(y5S.ds.Tables["InformationForm"]!.Rows[num][10].ToString());
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Insert PRN First.", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			try
			{
				y5S.cmd = new SqlCommand();
				y5S.cmd.set_CommandText(("select image from Photos where prn = " + TextBox3.get_Text()) ?? "");
				y5S.cmd.get_Parameters().AddWithValue("@prn", (object)TextBox3.get_Text());
				if (y5S.cn.get_State() == ConnectionState.Closed)
				{
					y5S.cn.Open();
				}
				y5S.cmd.set_Connection(y5S.cn);
				dr = y5S.cmd.ExecuteReader();
				if (dr.Read())
				{
					Photos1 = (byte[])dr.get_Item(0);
					PictureBox1.Load("photo.jpg");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			finally
			{
				y5S.cn.Close();
				dr.Close();
			}
		}
	}

	public void g2W()
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
		((Control)PictureBox1).Refresh();
		ComboBox2.ResetText();
		ComboBox1.ResetText();
	}

	private void x6F(object sender, EventArgs e)
	{
		((Control)Qk2o.Forms.SearchForm).Show();
		Qk2o.Forms.SearchForm.TextBox1.set_Text(TextBox3.get_Text());
		Qk2o.Forms.SearchForm.TextBox2.set_Text(TextBox1.get_Text());
		Qk2o.Forms.SearchForm.TextBox3.set_Text(TextBox8.get_Text());
		Qk2o.Forms.SearchForm.PictureBox1.set_Image(PictureBox1.get_Image());
	}

	private void g0Z(object sender, EventArgs e)
	{
	}

	private void Gs2(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static string[] Pn7()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Yw0.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void Tb2(object sender, EventArgs e)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			y5S.cn.Open();
			y5S.str = " update InformationForm set name = '" + TextBox1.get_Text() + "', address = '" + TextBox2.get_Text() + "', email = '" + TextBox4.get_Text() + "', sphno = " + TextBox5.get_Text() + " , dob = " + Conversions.ToString(DateTimePicker1.get_Value()) + " , gender = '" + ComboBox1.get_Text() + "' , course = '" + TextBox8.get_Text() + "' , pphno = " + TextBox9.get_Text() + " , docatach = '" + TextBox10.get_Text() + "',class = '" + TextBox11.get_Text() + "' where prn = " + TextBox3.get_Text() + " ";
			y5S.cmd = new SqlCommand(y5S.str, y5S.cn);
			y5S.da.set_UpdateCommand(y5S.cmd);
			y5S.da.get_UpdateCommand().ExecuteNonQuery();
			y5S.cn.Close();
			Interaction.MsgBox((object)"Record Updated.", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Enter PRN first.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void q6S(object sender, EventArgs e)
	{
		((Control)DateTimePicker1).set_Visible(false);
		((Control)ComboBox1).set_Visible(false);
		g2W();
	}

	internal static Type Ri8(Assembly St0)
	{
		return St0.GetExportedTypes()[27];
	}

	private void Sq2(object sender, EventArgs e)
	{
		TextBox3.set_Text(ComboBox2.get_Text());
	}
}
