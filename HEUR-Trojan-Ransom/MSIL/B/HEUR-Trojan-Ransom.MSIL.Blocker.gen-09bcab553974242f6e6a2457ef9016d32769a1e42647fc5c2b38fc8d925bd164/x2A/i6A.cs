using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace x2A;

[DesignerGenerated]
public class i6A : Form
{
	private IContainer components;

	private OleDbConnection con;

	internal virtual Button Close_Form
	{
		[CompilerGenerated]
		get
		{
			return _Close_Form;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Cn2;
			Button close_Form = _Close_Form;
			if (close_Form != null)
			{
				((Control)close_Form).remove_Click(eventHandler);
			}
			_Close_Form = value;
			close_Form = _Close_Form;
			if (close_Form != null)
			{
				((Control)close_Form).add_Click(eventHandler);
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
			EventHandler eventHandler = Nz6;
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

	internal virtual Button Add
	{
		[CompilerGenerated]
		get
		{
			return _Add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t3T;
			Button add = _Add;
			if (add != null)
			{
				((Control)add).remove_Click(eventHandler);
			}
			_Add = value;
			add = _Add;
			if (add != null)
			{
				((Control)add).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
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
			EventHandler eventHandler = Hj6;
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

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox7")]
	internal virtual TextBox TextBox7
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
			EventHandler eventHandler = Xs3;
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
			EventHandler eventHandler = En9;
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	public i6A()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Sr0);
		con = new OleDbConnection();
		b0B();
	}

	[DebuggerNonUserCode]
	protected override void Ex7(bool Ab7)
	{
		try
		{
			if (Ab7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ab7);
		}
	}

	[DebuggerStepThrough]
	private void b0B()
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(i6A));
		Close_Form = new Button();
		Button2 = new Button();
		Add = new Button();
		GroupBox2 = new GroupBox();
		Button4 = new Button();
		TextBox5 = new TextBox();
		TextBox7 = new TextBox();
		Label7 = new Label();
		Label8 = new Label();
		GroupBox1 = new GroupBox();
		TextBox6 = new TextBox();
		Label1 = new Label();
		TextBox4 = new TextBox();
		TextBox1 = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		DateTimePicker1 = new DateTimePicker();
		ComboBox1 = new ComboBox();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Close_Form).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Close_Form).set_Location(new Point(412, 428));
		((Control)Close_Form).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Close_Form).set_Name("Close_Form");
		((Control)Close_Form).set_Size(new Size(106, 45));
		((Control)Close_Form).set_TabIndex(33);
		((ButtonBase)Close_Form).set_Text("Close");
		((ButtonBase)Close_Form).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(108, 428));
		((Control)Button2).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(104, 45));
		((Control)Button2).set_TabIndex(32);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Add).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Add).set_Location(new Point(8, 428));
		((Control)Add).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Add).set_Name("Add");
		((Control)Add).set_Size(new Size(91, 45));
		((Control)Add).set_TabIndex(31);
		((ButtonBase)Add).set_Text("Add");
		((ButtonBase)Add).set_UseVisualStyleBackColor(false);
		((Control)GroupBox2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox2).set_Location(new Point(8, 284));
		((Control)GroupBox2).set_Margin(new Padding(3, 4, 3, 4));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Padding(new Padding(3, 4, 3, 4));
		((Control)GroupBox2).set_Size(new Size(510, 136));
		((Control)GroupBox2).set_TabIndex(30);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Account Information");
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(459, 86));
		((Control)Button4).set_Margin(new Padding(3, 4, 3, 4));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(28, 28));
		((Control)Button4).set_TabIndex(23);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)TextBox5).set_Location(new Point(136, 41));
		((Control)TextBox5).set_Margin(new Padding(3, 4, 3, 4));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(317, 22));
		((Control)TextBox5).set_TabIndex(22);
		((Control)TextBox7).set_Location(new Point(136, 89));
		((Control)TextBox7).set_Margin(new Padding(3, 4, 3, 4));
		((Control)TextBox7).set_Name("TextBox7");
		((Control)TextBox7).set_Size(new Size(317, 22));
		((Control)TextBox7).set_TabIndex(21);
		TextBox7.set_UseSystemPasswordChar(true);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label7).set_Location(new Point(44, 96));
		((Control)Label7).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(73, 17));
		((Control)Label7).set_TabIndex(20);
		Label7.set_Text("Password:");
		Label7.set_TextAlign((ContentAlignment)32);
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label8).set_Location(new Point(36, 45));
		((Control)Label8).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(79, 17));
		((Control)Label8).set_TabIndex(19);
		Label8.set_Text("UserName:");
		Label8.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Location(new Point(8, 12));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(510, 264));
		((Control)GroupBox1).set_TabIndex(29);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Patient information:");
		((Control)TextBox6).set_Location(new Point(133, 231));
		((Control)TextBox6).set_Margin(new Padding(3, 4, 3, 4));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(317, 22));
		((Control)TextBox6).set_TabIndex(18);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label1).set_Location(new Point(62, 231));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(46, 17));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("Email:");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)TextBox4).set_Location(new Point(133, 183));
		((Control)TextBox4).set_Margin(new Padding(3, 4, 3, 4));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(317, 22));
		((Control)TextBox4).set_TabIndex(16);
		((Control)TextBox1).set_Location(new Point(133, 34));
		((Control)TextBox1).set_Margin(new Padding(3, 4, 3, 4));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(317, 22));
		((Control)TextBox1).set_TabIndex(13);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label5).set_Location(new Point(55, 183));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(53, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Phone:");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label4).set_Location(new Point(52, 134));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(56, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Gender");
		Label4.set_TextAlign((ContentAlignment)32);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label3).set_Location(new Point(70, 82));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(38, 17));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("DOB");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label2).set_Location(new Point(68, 34));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Name:");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)DateTimePicker1).set_Location(new Point(133, 82));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(317, 22));
		((Control)DateTimePicker1).set_TabIndex(19);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[3] { "Male", "Female", "Other" });
		((Control)ComboBox1).set_Location(new Point(133, 131));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(317, 24));
		((Control)ComboBox1).set_TabIndex(20);
		((Form)this).set_AcceptButton((IButtonControl)(object)Add);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(536, 482));
		((Control)this).get_Controls().Add((Control)(object)Close_Form);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Add);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form20");
		((Form)this).set_Text("Form20");
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string So8(ref string Ac8)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(Ac8);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void Nz6(object Yc2, EventArgs f5P)
	{
		((TextBoxBase)TextBox1).Clear();
		DateTimePicker1.set_Value(DateAndTime.get_Now().Date);
		ComboBox1.set_Text("");
		((TextBoxBase)TextBox4).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox7).Clear();
	}

	private void Cn2(object c1M, EventArgs Le2)
	{
		((Form)this).Close();
	}

	private void t3T(object Hf6, EventArgs Bz5)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				TextBox1.set_Text(TextBox1.get_Text().Trim());
				if ((Operators.CompareString(ComboBox1.get_Text(), "", false) == 0) | (Operators.CompareString(DateTimePicker1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox4.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox5.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox6.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox7.get_Text(), "", false) == 0))
				{
					MessageBox.Show("Can't leave any field empty", "Empty Field");
					return;
				}
				string text = TextBox1.get_Text();
				if (text.Length > 50)
				{
					MessageBox.Show("Name can't be more than 50 characters long", "Too long name");
					return;
				}
				int num = text.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Console.WriteLine(text[i]);
					if (!(((Strings.Asc(text[i]) >= 65) & (Strings.Asc(text[i]) <= 90)) | ((Strings.Asc(text[i]) >= 97) & (Strings.Asc(text[i]) <= 122))))
					{
						if (i >= text.Length - 1)
						{
							MessageBox.Show("Patient Name can not contain digit or any special characters", "Not valid name");
							return;
						}
						if ((Operators.CompareString(Conversions.ToString(text[i]), " ", false) == 0) & (Operators.CompareString(Conversions.ToString(text[i + 1]), " ", false) == 0))
						{
							MessageBox.Show("Patient Name can not contain multiple spaces in between", "Not valid name");
							return;
						}
					}
				}
				if ((TextBox4.get_Text().Length != 10) | TextBox4.get_Text().Contains(",") | TextBox4.get_Text().Contains(".") | TextBox4.get_Text().Contains("(") | TextBox4.get_Text().Contains("-") | TextBox4.get_Text().Contains(" ") | !Versioned.IsNumeric((object)TextBox4.get_Text()) | TextBox4.get_Text().Contains("+"))
				{
					MessageBox.Show("Enter valid 10-digit mobile number without +91 or 0 in the beginning", "Invalid Input");
					return;
				}
				con.Open();
				string text2 = TextBox5.get_Text();
				string text3 = TextBox7.get_Text();
				string text4 = "";
				text4 = "Select * From Patient_DataBase Where UserName = '" + text2 + "' ";
				OleDbCommand val = new OleDbCommand(text4, con);
				OleDbDataReader val2 = val.ExecuteReader();
				int num2 = 0;
				while (val2.Read())
				{
					num2++;
				}
				val2.Close();
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				if (num2 >= 1)
				{
					MessageBox.Show("Username Already Exist");
					((TextBoxBase)TextBox5).Clear();
					con.Close();
					return;
				}
				string text5 = "Insert into Patient_DataBase([Name],[DOB],[Gender],[UserName],[Password_Doc],[Phone_Number],[Email]) Values(?,?,?,?,?,?,?)";
				OleDbCommand val3 = new OleDbCommand(text5, con);
				val3.get_Parameters().Add(new OleDbParameter("Name", (object)TextBox1.get_Text()));
				val3.get_Parameters().Add(new OleDbParameter("DOB", (object)DateTimePicker1.get_Text()));
				val3.get_Parameters().Add(new OleDbParameter("Gender", (object)ComboBox1.get_Text()));
				val3.get_Parameters().Add(new OleDbParameter("UserName", (object)TextBox5.get_Text()));
				OleDbParameterCollection parameters = val3.get_Parameters();
				TextBox val4;
				string Ac = (val4 = TextBox7).get_Text();
				string text6 = So8(ref Ac);
				val4.set_Text(Ac);
				parameters.Add(new OleDbParameter("Password_Doc", (object)text6));
				val3.get_Parameters().Add(new OleDbParameter("Phone_Number", (object)TextBox4.get_Text()));
				val3.get_Parameters().Add(new OleDbParameter("Email", (object)TextBox6.get_Text()));
				val3.ExecuteNonQuery();
				val3.set_CommandText("SELECT @@IDENTITY");
				NewLateBinding.LateCall((object)null, typeof(MessageBox), "Show", new object[2]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ID:", val3.ExecuteScalar()), (object)"\r\n"),
					"Added Successfully"
				}, (string[])null, (Type[])null, (bool[])null, true);
				try
				{
					string text7 = TextBox6.get_Text();
					SmtpClient smtpClient = new SmtpClient();
					MailMessage mailMessage = new MailMessage();
					smtpClient.UseDefaultCredentials = false;
					smtpClient.Credentials = new NetworkCredential("softwarelab20192@gmail.com", "software2019");
					smtpClient.Port = 587;
					smtpClient.EnableSsl = true;
					smtpClient.Host = "smtp.gmail.com";
					mailMessage = new MailMessage();
					mailMessage.From = new MailAddress("softwarelab20192@gmail.com");
					mailMessage.To.Add(text7);
					mailMessage.Subject = "Patient SignUp@IITG Hospital";
					mailMessage.IsBodyHtml = true;
					mailMessage.Body = "Name:" + TextBox1.get_Text() + "\r\nDOB:" + DateTimePicker1.get_Text() + "Gender" + ComboBox1.get_Text() + "\r\nUserName" + TextBox5.get_Text() + "\r\nPhone_Number" + TextBox4.get_Text() + "\r\nEmail" + TextBox6.get_Text() + "\r\nWe will always be by your side\r\nRegards\r\nI-CARE Hospital";
					smtpClient.Send(mailMessage);
					MessageBox.Show("Successfully sent confirmation email");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show(ex2.Message);
					ProjectData.ClearProjectError();
				}
				((Component)(object)val3).Dispose();
				con.Close();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show(ex4.Message);
				ProjectData.ClearProjectError();
			}
			((Form)this).Close();
		}
	}

	private void Hj6(object t9Y, EventArgs Py1)
	{
		if (TextBox7.get_UseSystemPasswordChar())
		{
			TextBox7.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox7.set_UseSystemPasswordChar(true);
		}
	}

	internal static byte Ci2(byte m1Y, byte[] Ds3, int Pt0, int g2E)
	{
		m1Y = (byte)(m1Y ^ checked((byte)(Ds3[unchecked(g2E % Ds3.Length)] ^ ((g2E + unchecked(Pt0 % Ds3.Length)) & Pt0))));
		return m1Y;
	}

	private void Sr0(object x0B, EventArgs z9W)
	{
		DateTimePicker1.set_Value(DateAndTime.get_Now().Date);
		DateTimePicker1.set_MinDate(DateAndTime.get_Now().Date.AddYears(-130));
		DateTimePicker1.set_MaxDate(DateAndTime.get_Now().Date);
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void Xs3(object Lx3, EventArgs a3G)
	{
	}

	private void En9(object f6E, EventArgs Dp9)
	{
	}
}
