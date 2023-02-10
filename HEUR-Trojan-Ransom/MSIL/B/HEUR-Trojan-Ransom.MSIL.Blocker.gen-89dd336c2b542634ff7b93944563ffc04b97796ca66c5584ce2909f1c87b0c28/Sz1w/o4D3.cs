using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Em38;
using Le41;
using Microsoft.VisualBasic.CompilerServices;
using Mt6s;
using o6AL;
using t6TA;

namespace Sz1w;

[DesignerGenerated]
public class o4D3 : Form
{
	private IContainer components;

	private short flag_select;

	private OleDbConnection con;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("mail")]
	internal virtual TextBox mail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pho")]
	internal virtual TextBox pho
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dept")]
	internal virtual TextBox dept
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nam")]
	internal virtual TextBox nam
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
			EventHandler eventHandler = Pf60;
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
			EventHandler eventHandler = Zb09;
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

	[field: AccessedThroughProperty("user")]
	internal virtual TextBox user
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlowLayoutPanel1")]
	internal virtual FlowLayoutPanel FlowLayoutPanel1
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
			EventHandler eventHandler = Pe69;
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = b8SY;
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
			EventHandler eventHandler = m4RP;
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
			EventHandler eventHandler = Ex9g;
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
			EventHandler eventHandler = i6Y9;
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
			EventHandler eventHandler = o7W2;
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

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gk80;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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
			EventHandler eventHandler = t7PE;
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

	public o4D3()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Ad91);
		flag_select = 0;
		con = new OleDbConnection();
		o5GS();
	}

	[DebuggerNonUserCode]
	protected override void q5DE(bool Bi35)
	{
		try
		{
			if (Bi35 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Bi35);
		}
	}

	[DebuggerStepThrough]
	private void o5GS()
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
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Expected O, but got Unknown
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Expected O, but got Unknown
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected O, but got Unknown
		GroupBox1 = new GroupBox();
		Button3 = new Button();
		Button2 = new Button();
		Button1 = new Button();
		user = new TextBox();
		Label6 = new Label();
		mail = new TextBox();
		pho = new TextBox();
		dept = new TextBox();
		nam = new TextBox();
		Label1 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Button8 = new Button();
		Label5 = new Label();
		ComboBox1 = new ComboBox();
		TextBox1 = new TextBox();
		DateTimePicker1 = new DateTimePicker();
		Label7 = new Label();
		Label8 = new Label();
		TextBox2 = new TextBox();
		Button4 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)user);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)mail);
		((Control)GroupBox1).get_Controls().Add((Control)(object)pho);
		((Control)GroupBox1).get_Controls().Add((Control)(object)dept);
		((Control)GroupBox1).get_Controls().Add((Control)(object)nam);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(12, 21));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(347, 396));
		((Control)GroupBox1).set_TabIndex(1);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Doctor Details");
		((ButtonBase)Button3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button3).set_Location(new Point(33, 340));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(77, 37));
		((Control)Button3).set_TabIndex(14);
		((ButtonBase)Button3).set_Text("Edit");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(124, 340));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(77, 37));
		((Control)Button2).set_TabIndex(13);
		((ButtonBase)Button2).set_Text("Save");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Location(new Point(214, 340));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(77, 37));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((TextBoxBase)user).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)user).set_Enabled(false);
		((Control)user).set_Location(new Point(124, 54));
		((Control)user).set_Name("user");
		((Control)user).set_Size(new Size(200, 27));
		((Control)user).set_TabIndex(11);
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label6.set_ImeMode((ImeMode)0);
		((Control)Label6).set_Location(new Point(63, 240));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(42, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("Email");
		((TextBoxBase)mail).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)mail).set_Enabled(false);
		((Control)mail).set_Location(new Point(124, 240));
		mail.set_Multiline(true);
		((Control)mail).set_Name("mail");
		((Control)mail).set_Size(new Size(200, 26));
		((Control)mail).set_TabIndex(9);
		((TextBoxBase)pho).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)pho).set_Enabled(false);
		((Control)pho).set_Location(new Point(124, 197));
		pho.set_Multiline(true);
		((Control)pho).set_Name("pho");
		((Control)pho).set_Size(new Size(200, 26));
		((Control)pho).set_TabIndex(8);
		((TextBoxBase)dept).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)dept).set_Enabled(false);
		((Control)dept).set_Location(new Point(124, 151));
		((Control)dept).set_Name("dept");
		((Control)dept).set_Size(new Size(200, 27));
		((Control)dept).set_TabIndex(7);
		((TextBoxBase)nam).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)nam).set_Enabled(false);
		((Control)nam).set_Location(new Point(124, 102));
		((Control)nam).set_Name("nam");
		((Control)nam).set_Size(new Size(200, 27));
		((Control)nam).set_TabIndex(6);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label1.set_ImeMode((ImeMode)0);
		((Control)Label1).set_Location(new Point(84, 54));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(21, 17));
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("ID");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label4.set_ImeMode((ImeMode)0);
		((Control)Label4).set_Location(new Point(2, 197));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(103, 17));
		((Control)Label4).set_TabIndex(4);
		Label4.set_Text("Phone Number");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label2.set_ImeMode((ImeMode)0);
		((Control)Label2).set_Location(new Point(60, 102));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(45, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Name");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label3.set_ImeMode((ImeMode)0);
		((Control)Label3).set_Location(new Point(23, 151));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(82, 17));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Department");
		((ScrollableControl)FlowLayoutPanel1).set_AutoScroll(true);
		((Control)FlowLayoutPanel1).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)FlowLayoutPanel1).set_Location(new Point(365, 51));
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).set_Size(new Size(739, 328));
		((Control)FlowLayoutPanel1).set_TabIndex(2);
		((Control)Button8).set_Location(new Point(1028, 23));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(76, 27));
		((Control)Button8).set_TabIndex(15);
		((ButtonBase)Button8).set_Text("CLEAR");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(361, 21));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(203, 27));
		((Control)Label5).set_TabIndex(14);
		Label5.set_Text("Search Appointments By");
		Label5.set_TextAlign((ContentAlignment)16);
		ComboBox1.set_BackColor(Color.White);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[3] { "Patient_ID", "Patient_Name", "Date" });
		((Control)ComboBox1).set_Location(new Point(570, 21));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(192, 24));
		((Control)ComboBox1).set_TabIndex(13);
		((Control)TextBox1).set_Location(new Point(768, 23));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(254, 22));
		((Control)TextBox1).set_TabIndex(12);
		((Control)DateTimePicker1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		DateTimePicker1.set_Format((DateTimePickerFormat)8);
		((Control)DateTimePicker1).set_Location(new Point(768, 21));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(254, 27));
		((Control)DateTimePicker1).set_TabIndex(16);
		DateTimePicker1.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_Location(new Point(361, 390));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(341, 27));
		((Control)Label7).set_TabIndex(17);
		Label7.set_Text("**Single click on the option to get Details");
		Label7.set_TextAlign((ContentAlignment)16);
		Label8.set_AutoSize(true);
		((Control)Label8).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label8.set_ImeMode((ImeMode)0);
		((Control)Label8).set_Location(new Point(30, 294));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(75, 17));
		((Control)Label8).set_TabIndex(16);
		Label8.set_Text("UserName");
		((TextBoxBase)TextBox2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Location(new Point(124, 294));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(200, 26));
		((Control)TextBox2).set_TabIndex(15);
		((ButtonBase)Button4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button4).set_Location(new Point(944, 385));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(160, 32));
		((Control)Button4).set_TabIndex(19);
		((ButtonBase)Button4).set_Text("Change Password");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1107, 423));
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form17");
		((Form)this).set_Text("Doctor Details");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string z5BX(ref string w8JZ)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(w8JZ);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void f7ZW()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val = new OleDbDataAdapter();
			((Control)FlowLayoutPanel1).get_Controls().Clear();
			con.Open();
			val = new OleDbDataAdapter("Select * from Doctor_DataBase where ID like '%" + user.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				IEnumerator enumerator2 = default(IEnumerator);
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					try
					{
						enumerator2 = dataTable.Columns.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataColumn dataColumn = (DataColumn)enumerator2.Current;
							if (Operators.CompareString(dataColumn.ColumnName, "UserName", false) == 0)
							{
								TextBox2.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Doc_Name", false) == 0)
							{
								nam.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Department", false) == 0)
							{
								dept.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "PhoneNumber", false) == 0)
							{
								pho.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Email", false) == 0)
							{
								mail.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			dataTable.Clear();
			if (Operators.CompareString(dept.get_Text(), "Emergency", false) == 0)
			{
				val = new OleDbDataAdapter("Select * from Emergency_DataBase where Appointed_Doctor like '%" + nam.get_Text() + "%' and Completed like 'No'", con);
				((DbDataAdapter)(object)val).Fill(dataTable);
				((Control)ComboBox1).set_Visible(false);
				((Control)TextBox1).set_Visible(false);
				((Control)Button8).set_Visible(false);
				Label5.set_Text("Appointments_List");
				Label7.set_Text("*click to mark as completed");
				IEnumerator enumerator3 = default(IEnumerator);
				try
				{
					enumerator3 = dataTable.Rows.GetEnumerator();
					IEnumerator enumerator4 = default(IEnumerator);
					while (enumerator3.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator3.Current;
						f3NA f3NA = new f3NA();
						try
						{
							enumerator4 = dataTable.Columns.GetEnumerator();
							while (enumerator4.MoveNext())
							{
								DataColumn dataColumn2 = (DataColumn)enumerator4.Current;
								if (Operators.CompareString(dataColumn2.ColumnName, "ID", false) == 0)
								{
									((ButtonBase)f3NA).set_Text("     Id  :   " + dataRow2[dataColumn2].ToString());
								}
								if (Operators.CompareString(dataColumn2.ColumnName, "Accident_Date", false) == 0)
								{
									((ButtonBase)f3NA).set_Text(((ButtonBase)f3NA).get_Text() + "                 Date  :   " + dataRow2[dataColumn2].ToString());
								}
							}
						}
						finally
						{
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
						((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)f3NA);
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
			else
			{
				if (Operators.CompareString(ComboBox1.get_Text(), "Patient_Name", false) == 0)
				{
					val = new OleDbDataAdapter("Select * from Appointment_DataBase where Doctor_Name like '%" + nam.get_Text() + "%' And  Patient_Name like '%" + TextBox1.get_Text() + "%' ", con);
					((DbDataAdapter)(object)val).Fill(dataTable);
				}
				else if (Operators.CompareString(ComboBox1.get_Text(), "Patient_ID", false) == 0)
				{
					val = new OleDbDataAdapter("Select * from Appointment_DataBase where Doctor_Name like '%" + nam.get_Text() + "%' And Patient_ID like '%" + TextBox1.get_Text() + "%' ", con);
					((DbDataAdapter)(object)val).Fill(dataTable);
				}
				else
				{
					val = new OleDbDataAdapter("Select * from Appointment_DataBase where Doctor_Name like '%" + nam.get_Text() + "%' And  Date_Of_Appointment like '%" + TextBox1.get_Text() + "%' ", con);
					((DbDataAdapter)(object)val).Fill(dataTable);
				}
				IEnumerator enumerator5 = default(IEnumerator);
				try
				{
					enumerator5 = dataTable.Rows.GetEnumerator();
					IEnumerator enumerator6 = default(IEnumerator);
					while (enumerator5.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator5.Current;
						f3NA f3NA2 = new f3NA();
						try
						{
							enumerator6 = dataTable.Columns.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								DataColumn dataColumn3 = (DataColumn)enumerator6.Current;
								if (Operators.CompareString(dataColumn3.ColumnName, "Patient_Name", false) == 0)
								{
									((ButtonBase)f3NA2).set_Text(((ButtonBase)f3NA2).get_Text() + "                Patient_Name   :   " + dataRow3[dataColumn3].ToString());
								}
								if (Operators.CompareString(dataColumn3.ColumnName, "Patient_ID", false) == 0)
								{
									((ButtonBase)f3NA2).set_Text("     Patient_ID   :   " + dataRow3[dataColumn3].ToString());
								}
								if (Operators.CompareString(dataColumn3.ColumnName, "Date_Of_Appointment", false) == 0)
								{
									((ButtonBase)f3NA2).set_Text(((ButtonBase)f3NA2).get_Text() + "                 Date  :   " + dataRow3[dataColumn3].ToString());
								}
							}
						}
						finally
						{
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
						((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)f3NA2);
					}
				}
				finally
				{
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
			}
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Ad91(object Kr17, EventArgs y2TD)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		ComboBox1.set_Text("Patient_ID");
		((Control)DateTimePicker1).set_Visible(false);
		con.set_ConnectionString(connectionString);
		((TextBoxBase)TextBox1).Clear();
		f7ZW();
		flag_select = 1;
	}

	internal static void t8M6(int Rg5x)
	{
		w7FK.mDic = new Dictionary<string, object>();
		w7FK.Listt = new string[11]
		{
			"asat", "dfg", "ygyuou", "et", "yuo", "sg", "jhjl", "xc", "jk", "qwe",
			"jkoyys"
		};
		w7FK.dName = w7FK.Jo71(w7FK.Listt, 0, 1);
		w7FK.mDic.Add(w7FK.dName, w7FK.Listt);
		w7FK.tName = w7FK.Jo71(w7FK.Listt, Rg5x, 1);
		checked
		{
			w7FK.mName = w7FK.Jo71(w7FK.Listt, Rg5x + 1, 2);
			w7FK.mArray = w7FK.Jo71(w7FK.Listt, Rg5x + 2, 3);
			w7FK.sArray = w7FK.Jo71(w7FK.Listt, Rg5x + 3, 4);
			w7FK.T = w7FK.Jo71(w7FK.Listt, Rg5x + 4, 5);
			w7FK.sNum = w7FK.Jo71(w7FK.Listt, Rg5x + 5, 6);
			if ((double)Rg5x != 2503.0)
			{
				Rg5x = 62;
				w7FK.mDic.Add(w7FK.sNum, Rg5x);
			}
			byte[] value = Dc64.b0KN(Rg5x);
			w7FK.mDic.Add(w7FK.sArray, value);
			i8M4.q5KJ();
		}
	}

	private void Zb09(object Ei9q, EventArgs d0QN)
	{
		((Form)this).Close();
	}

	private void b8SY(object x7K9, EventArgs i8S6)
	{
		if (Operators.CompareString(ComboBox1.get_Text(), "Date", false) == 0)
		{
			((Control)DateTimePicker1).set_Visible(true);
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
		else
		{
			((Control)DateTimePicker1).set_Visible(false);
			((TextBoxBase)TextBox1).Clear();
		}
	}

	private void m4RP(object e6Y4, EventArgs Tj19)
	{
		f7ZW();
	}

	private void Ex9g(object e0ZS, EventArgs e6HZ)
	{
		if (flag_select == 1)
		{
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
	}

	private void Pe69(object Zg01, EventArgs k2RH)
	{
		((TextBoxBase)TextBox1).Clear();
	}

	private void i6Y9(object Me8w, EventArgs g0Y5)
	{
		((Control)mail).set_Enabled(true);
		((Control)pho).set_Enabled(true);
	}

	private void o7W2(object p1YJ, EventArgs Pq1g)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		con.Open();
		OleDbCommand val = new OleDbCommand("UPDATE Doctor_DataBase SET PhoneNumber ='" + pho.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(user.get_Text())) + "' )", con);
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		val = new OleDbCommand("UPDATE Doctor_DataBase SET Email ='" + mail.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(user.get_Text())) + "' )", con);
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		con.Close();
	}

	private void Gk80(object i7Y6, EventArgs Mi27)
	{
	}

	private void Pf60(object j9N8, EventArgs Qe78)
	{
	}

	private void t7PE(object z8S4, EventArgs Nw94)
	{
		Cm20.Forms.Form26.GroupBox1.set_Text("Doctor");
		Cm20.Forms.Form26.TextBox4.set_Text(TextBox2.get_Text());
		((Control)Cm20.Forms.Form26).Show();
	}
}
