using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using n4YR;
using w3X6;

namespace Wf5;

[DesignerGenerated]
public class d5A : Form
{
	private IContainer components;

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
			EventHandler eventHandler = a1RL;
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
			EventHandler eventHandler = b3K9;
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

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = b0FR;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = e0A4;
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

	internal virtual TextBox TextBox4
	{
		[CompilerGenerated]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z6X7;
			TextBox textBox = _TextBox4;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox4 = value;
			textBox = _TextBox4;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label4
	{
		[CompilerGenerated]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = z9Y0;
			Label label = _Label4;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label4 = value;
			label = _Label4;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox3
	{
		[CompilerGenerated]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s0WS;
			TextBox textBox = _TextBox3;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox3 = value;
			textBox = _TextBox3;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gc78;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
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
			EventHandler eventHandler = g7FN;
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
			EventHandler eventHandler = Em4a;
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
			EventHandler eventHandler = p5K8;
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
			EventHandler eventHandler = o3M6;
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
			EventHandler eventHandler = Ta7d;
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
			EventHandler eventHandler = n1ET;
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

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r5HT;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
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
			EventHandler eventHandler = i8RW;
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
			EventHandler eventHandler = r3T6;
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

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = y9DK;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public d5A()
	{
		((Form)this).add_Load((EventHandler)Wa3t);
		Na2g();
	}

	[DebuggerNonUserCode]
	protected override void y3N(bool f3N)
	{
		try
		{
			if (f3N && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f3N);
		}
	}

	[DebuggerStepThrough]
	private void Na2g()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected O, but got Unknown
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		Button7 = new Button();
		TextBox6 = new TextBox();
		Label6 = new Label();
		Label5 = new Label();
		TextBox4 = new TextBox();
		Label4 = new Label();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		Button1 = new Button();
		GroupBox1 = new GroupBox();
		Button2 = new Button();
		Button4 = new Button();
		TextBox5 = new TextBox();
		Label3 = new Label();
		TextBox1 = new TextBox();
		Label2 = new Label();
		Label1 = new Label();
		ComboBox1 = new ComboBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Button7).set_BackColor(Color.Transparent);
		Button7.set_DialogResult((DialogResult)2);
		((ButtonBase)Button7).get_FlatAppearance().set_BorderColor(Color.FromArgb(0, 192, 192));
		((ButtonBase)Button7).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button7).set_FlatStyle((FlatStyle)0);
		((Control)Button7).set_Location(new Point(145, 192));
		((Control)Button7).set_Margin(new Padding(4));
		((Control)Button7).set_Name("Button7");
		((Control)Button7).set_Size(new Size(94, 32));
		((Control)Button7).set_TabIndex(29);
		((ButtonBase)Button7).set_Text("Update");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(false);
		((Control)TextBox6).set_Location(new Point(482, 139));
		((Control)TextBox6).set_Margin(new Padding(4));
		TextBox6.set_Multiline(true);
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(188, 29));
		((Control)TextBox6).set_TabIndex(28);
		((Control)Label6).set_Location(new Point(364, 138));
		((Control)Label6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(118, 36));
		((Control)Label6).set_TabIndex(27);
		Label6.set_Text("Max. Student");
		Label6.set_TextAlign((ContentAlignment)16);
		((Control)Label5).set_Location(new Point(364, 98));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(118, 36));
		((Control)Label5).set_TabIndex(25);
		Label5.set_Text("Total Subjects");
		Label5.set_TextAlign((ContentAlignment)16);
		((Control)TextBox4).set_Location(new Point(166, 140));
		((Control)TextBox4).set_Margin(new Padding(4));
		TextBox4.set_Multiline(true);
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(177, 29));
		((Control)TextBox4).set_TabIndex(24);
		((Control)Label4).set_Location(new Point(22, 139));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(136, 36));
		((Control)Label4).set_TabIndex(23);
		Label4.set_Text("Total Semesters");
		Label4.set_TextAlign((ContentAlignment)16);
		((Control)TextBox3).set_Location(new Point(166, 98));
		((Control)TextBox3).set_Margin(new Padding(4));
		TextBox3.set_Multiline(true);
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(177, 29));
		((Control)TextBox3).set_TabIndex(11);
		((Control)TextBox2).set_Location(new Point(166, 56));
		((Control)TextBox2).set_Margin(new Padding(4));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(504, 29));
		((Control)TextBox2).set_TabIndex(4);
		((ButtonBase)Button1).set_BackColor(Color.Transparent);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderColor(Color.Teal);
		((ButtonBase)Button1).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Location(new Point(25, 192));
		((Control)Button1).set_Margin(new Padding(4));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(94, 32));
		((Control)Button1).set_TabIndex(18);
		((ButtonBase)Button1).set_Text("Search");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button7);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Location(new Point(5, 3));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(679, 245));
		((Control)GroupBox1).set_TabIndex(26);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Course Info.");
		((ButtonBase)Button2).set_BackColor(Color.Transparent);
		Button2.set_DialogResult((DialogResult)2);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Button2).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(255, 224, 192));
		((ButtonBase)Button2).set_FlatStyle((FlatStyle)0);
		((Control)Button2).set_Location(new Point(388, 192));
		((Control)Button2).set_Margin(new Padding(4));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(94, 32));
		((Control)Button2).set_TabIndex(19);
		((ButtonBase)Button2).set_Text("Cancel");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button4).set_BackColor(Color.Transparent);
		((ButtonBase)Button4).get_FlatAppearance().set_BorderColor(Color.FromArgb(255, 128, 0));
		((ButtonBase)Button4).get_FlatAppearance().set_BorderSize(3);
		((ButtonBase)Button4).set_FlatStyle((FlatStyle)0);
		((Control)Button4).set_Location(new Point(266, 192));
		((Control)Button4).set_Margin(new Padding(4));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(94, 32));
		((Control)Button4).set_TabIndex(21);
		((ButtonBase)Button4).set_Text("Clear");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((Control)TextBox5).set_Location(new Point(482, 98));
		((Control)TextBox5).set_Margin(new Padding(4));
		TextBox5.set_Multiline(true);
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(188, 29));
		((Control)TextBox5).set_TabIndex(26);
		((Control)Label3).set_Location(new Point(22, 97));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(136, 36));
		((Control)Label3).set_TabIndex(22);
		Label3.set_Text("Course Duration");
		Label3.set_TextAlign((ContentAlignment)16);
		((Control)TextBox1).set_Location(new Point(166, 17));
		((Control)TextBox1).set_Margin(new Padding(4));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(177, 29));
		((Control)TextBox1).set_TabIndex(3);
		((Control)TextBox1).set_Visible(false);
		((Control)Label2).set_Location(new Point(22, 16));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(136, 36));
		((Control)Label2).set_TabIndex(17);
		Label2.set_Text("Course ID");
		Label2.set_TextAlign((ContentAlignment)16);
		((Control)Label1).set_Location(new Point(22, 56));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(136, 36));
		((Control)Label1).set_TabIndex(16);
		Label1.set_Text("Course Name");
		Label1.set_TextAlign((ContentAlignment)16);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(166, 20));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(177, 24));
		((Control)ComboBox1).set_TabIndex(30);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_ClientSize(new Size(688, 250));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Course1");
		((Form)this).set_Text("Course Detail");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void p5K8(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void o3M6(object sender, EventArgs e)
	{
		Dc23();
	}

	public void Dc23()
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox6).Clear();
		ComboBox1.ResetText();
	}

	private void Wa3t(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		Ns49.ds.Clear();
		Ns49.Cj7g();
		Ns49.cn.Open();
		Ns49.str = "select * from InformationForm";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Course");
		Ns49.cn.Close();
		Ns49.cn.Open();
		Ns49.str = "select * from Course";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Course");
		checked
		{
			int num = Ns49.ds.Tables["Course"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox1.get_Items().Add((object)Ns49.ds.Tables["Course"]!.Rows[i][0].ToString());
			}
			Ns49.cn.Close();
		}
	}

	private void g7FN(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		if (Ns49.cn.get_State() == ConnectionState.Open)
		{
			Ns49.cn.Close();
		}
		int num = 0;
		Ns49.cn.Open();
		Ns49.str = "select * from Course ";
		Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
		Ns49.da.set_SelectCommand(Ns49.cmd);
		((DbDataAdapter)(object)Ns49.da).Fill(Ns49.ds, "Course");
		checked
		{
			int num2 = Ns49.ds.Tables["Course"]!.Rows.Count - 1;
			int num3 = num2;
			for (num = 0; num <= num3; num++)
			{
				if (Operators.CompareString(TextBox1.get_Text(), Ns49.ds.Tables["Course"]!.Rows[num][0].ToString(), false) == 0)
				{
					TextBox1.set_Text(Ns49.ds.Tables["Course"]!.Rows[num][0].ToString());
					TextBox2.set_Text(Ns49.ds.Tables["Course"]!.Rows[num][1].ToString());
					TextBox3.set_Text(Ns49.ds.Tables["Course"]!.Rows[num][2].ToString());
					TextBox4.set_Text(Ns49.ds.Tables["Course"]!.Rows[num][3].ToString());
					TextBox5.set_Text(Ns49.ds.Tables["Course"]!.Rows[num][4].ToString());
					TextBox6.set_Text(Ns49.ds.Tables["Course"]!.Rows[num][5].ToString());
				}
			}
		}
	}

	private void a1RL(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Ns49.cn.Open();
			Ns49.str = " update Course set course_name = '" + TextBox2.get_Text() + "', course_duration = " + TextBox3.get_Text() + ", total_semester = " + TextBox4.get_Text() + ", total_subjects = " + TextBox5.get_Text() + ", max_students = " + TextBox6.get_Text() + " where SubjectID = " + TextBox1.get_Text() + " ";
			Ns49.cmd = new SqlCommand(Ns49.str, Ns49.cn);
			Ns49.da.set_UpdateCommand(Ns49.cmd);
			Ns49.da.get_UpdateCommand().ExecuteNonQuery();
			Ns49.cn.Close();
			Interaction.MsgBox((object)"Record Updated.", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Enter Course ID first.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void z6X7(object sender, EventArgs e)
	{
	}

	private void e0A4(object sender, EventArgs e)
	{
	}

	private void Ta7d(object sender, EventArgs e)
	{
	}

	private void b0FR(object sender, EventArgs e)
	{
	}

	private void b3K9(object sender, EventArgs e)
	{
	}

	private void Em4a(object sender, EventArgs e)
	{
	}

	private void s0WS(object sender, EventArgs e)
	{
	}

	private void r3T6(object sender, EventArgs e)
	{
	}

	private void r5HT(object sender, EventArgs e)
	{
	}

	private void Gc78(object sender, EventArgs e)
	{
	}

	internal static byte[] m7BC(string[] Mj6k, int Mp07)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Mj6k.Length - 1 + 1];
				int num = Mj6k.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Mj6k[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)b1D7.mDic["bee"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "stdinfo", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void i8RW(object sender, EventArgs e)
	{
	}

	private void Xx31(object sender, EventArgs e)
	{
	}

	private void n1ET(object sender, EventArgs e)
	{
	}

	private void z9Y0(object sender, EventArgs e)
	{
	}

	private void y9DK(object sender, EventArgs e)
	{
		TextBox1.set_Text(ComboBox1.get_Text());
	}
}
