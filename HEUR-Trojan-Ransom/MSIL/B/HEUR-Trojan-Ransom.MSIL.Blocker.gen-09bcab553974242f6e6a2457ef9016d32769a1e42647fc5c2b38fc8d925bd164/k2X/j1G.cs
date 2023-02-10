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
using Gf25;
using Microsoft.VisualBasic.CompilerServices;

namespace k2X;

[DesignerGenerated]
public class j1G : Form
{
	private IContainer components;

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
			EventHandler eventHandler = Ck2y;
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
			EventHandler eventHandler = e4C;
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
			EventHandler eventHandler = g8G;
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

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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
			EventHandler eventHandler = Pa6x;
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
			EventHandler eventHandler = An47;
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

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	public j1G()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Hr5);
		con = new OleDbConnection();
		Dk6();
	}

	[DebuggerNonUserCode]
	protected override void e5Z(bool Za1)
	{
		try
		{
			if (Za1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Za1);
		}
	}

	[DebuggerStepThrough]
	private void Dk6()
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
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected O, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(j1G));
		GroupBox1 = new GroupBox();
		TextBox6 = new TextBox();
		Label1 = new Label();
		ComboBox1 = new ComboBox();
		TextBox4 = new TextBox();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		GroupBox2 = new GroupBox();
		Button4 = new Button();
		TextBox5 = new TextBox();
		TextBox7 = new TextBox();
		Label7 = new Label();
		Label8 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Location(new Point(22, 25));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(610, 303));
		((Control)GroupBox1).set_TabIndex(2);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Doctor information:");
		((Control)TextBox6).set_Location(new Point(125, 258));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(452, 22));
		((Control)TextBox6).set_TabIndex(23);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(70, 265));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(276, 34));
		((Control)Label1).set_TabIndex(22);
		Label1.set_Text("OPD:\r\n(Enter in format Sunday,Monday,Tuesday)");
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[14]
		{
			"Cardiology", "Ear nose and throat (ENT)", "Emergency", "Gastroenterology", "General surgery", "Gynaecology", "Haematology", "Maternity departments", "Neurology", "Oncology",
			"Ophthalmology", "Orthopaedics", "Physiotherapy", "Urology"
		});
		((Control)ComboBox1).set_Location(new Point(125, 213));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(452, 24));
		((Control)ComboBox1).set_TabIndex(19);
		((Control)TextBox4).set_Location(new Point(125, 166));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(452, 22));
		((Control)TextBox4).set_TabIndex(16);
		((Control)TextBox3).set_Location(new Point(125, 126));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(452, 22));
		((Control)TextBox3).set_TabIndex(15);
		((Control)TextBox2).set_Location(new Point(125, 83));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(452, 22));
		((Control)TextBox2).set_TabIndex(14);
		((Control)TextBox1).set_Location(new Point(125, 40));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(452, 22));
		((Control)TextBox1).set_TabIndex(13);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label6).set_Location(new Point(30, 213));
		((Control)Label6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(86, 17));
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("Department:");
		Label6.set_TextAlign((ContentAlignment)32);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label5).set_Location(new Point(62, 169));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(53, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Phone:");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label4).set_Location(new Point(53, 126));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(64, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Address:");
		Label4.set_TextAlign((ContentAlignment)32);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label3).set_Location(new Point(70, 83));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(46, 17));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Email:");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label2).set_Location(new Point(66, 40));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Name:");
		Label2.set_TextAlign((ContentAlignment)32);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Location(new Point(22, 466));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(115, 37));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Add");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(143, 466));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(125, 37));
		((Control)Button2).set_TabIndex(13);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button3).set_Location(new Point(509, 466));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(123, 37));
		((Control)Button3).set_TabIndex(14);
		((ButtonBase)Button3).set_Text("Close");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((Control)GroupBox2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox2).set_Location(new Point(22, 335));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(610, 113));
		((Control)GroupBox2).set_TabIndex(24);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Account Information");
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(578, 73));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(25, 23));
		((Control)Button4).set_TabIndex(23);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)TextBox5).set_Location(new Point(123, 34));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(452, 22));
		((Control)TextBox5).set_TabIndex(22);
		((Control)TextBox7).set_Location(new Point(123, 73));
		((Control)TextBox7).set_Name("TextBox7");
		((Control)TextBox7).set_Size(new Size(452, 22));
		((Control)TextBox7).set_TabIndex(21);
		TextBox7.set_UseSystemPasswordChar(true);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label7).set_Location(new Point(39, 78));
		((Control)Label7).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(73, 17));
		((Control)Label7).set_TabIndex(20);
		Label7.set_Text("Password:");
		Label7.set_TextAlign((ContentAlignment)32);
		Label8.set_AutoSize(true);
		((Control)Label8).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label8).set_Location(new Point(33, 37));
		((Control)Label8).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(79, 17));
		((Control)Label8).set_TabIndex(19);
		Label8.set_Text("UserName:");
		Label8.set_TextAlign((ContentAlignment)32);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(644, 505));
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form14");
		((Form)this).set_Text("Add Doctor");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string q1X(ref string Zt0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(Zt0);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void e4C(object Da8, EventArgs Hm9)
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
		((Control)ComboBox1).get_Controls().Clear();
		((TextBoxBase)TextBox6).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox7).Clear();
	}

	private void g8G(object e8T, EventArgs Tj1)
	{
		((Control)Jy6g.Forms.Form12).set_Enabled(true);
		((Form)this).Close();
	}

	private void Hr5(object p5P, EventArgs Cb6)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void Ck2y(object z6YX, EventArgs i3QW)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(ComboBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox4.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox5.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox7.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Can't leave any field empty", "Empty Field");
			return;
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(ComboBox1.get_SelectedItem(), (object)"Emergency", false), (object)(Operators.CompareString(TextBox6.get_Text(), "", false) == 0))))
		{
			MessageBox.Show("Can't leave any field empty", "Empty Field");
			return;
		}
		if ((TextBox4.get_Text().Length != 10) | TextBox4.get_Text().Contains(",") | TextBox4.get_Text().Contains(".") | TextBox4.get_Text().Contains("(") | TextBox4.get_Text().Contains("-") | TextBox4.get_Text().Contains(" ") | !Versioned.IsNumeric((object)TextBox4.get_Text()) | TextBox4.get_Text().Contains("+"))
		{
			MessageBox.Show("Enter valid 10-digit mobile number without +91 or 0 in the beginning", "Invalid Input");
			return;
		}
		con.Open();
		string text = "Insert into Doctor_DataBase([Doc_Name],[Email],[PhoneNumber],[Department],[Address],[UserName],[Password_Doc],[OPD]) Values(?,?,?,?,?,?,?,?)";
		OleDbCommand val = new OleDbCommand(text, con);
		val.get_Parameters().Add(new OleDbParameter("Doc_Name", (object)TextBox1.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Email", (object)TextBox2.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("PhoneNumber", (object)TextBox4.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Department", (object)ComboBox1.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Address", (object)TextBox3.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("UserName", (object)TextBox5.get_Text()));
		OleDbParameterCollection parameters = val.get_Parameters();
		TextBox val2;
		string Zt = (val2 = TextBox7).get_Text();
		string text2 = q1X(ref Zt);
		val2.set_Text(Zt);
		parameters.Add(new OleDbParameter("Password_Doc", (object)text2));
		val.get_Parameters().Add(new OleDbParameter("OPD", (object)TextBox6.get_Text()));
		try
		{
			val.ExecuteNonQuery();
			val.set_CommandText("SELECT @@IDENTITY");
			MessageBox.Show("ID" + val.ExecuteScalar().ToString(), "Successfully Added");
			try
			{
				string text3 = TextBox2.get_Text();
				SmtpClient smtpClient = new SmtpClient();
				MailMessage mailMessage = new MailMessage();
				smtpClient.UseDefaultCredentials = false;
				smtpClient.Credentials = new NetworkCredential("softwarelab20192@gmail.com", "software2019");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Host = "smtp.gmail.com";
				mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("softwarelab20192@gmail.com");
				mailMessage.To.Add(text3);
				mailMessage.Subject = "Patient SignUp@IITG Hospital";
				mailMessage.IsBodyHtml = true;
				mailMessage.Body = "Name:" + TextBox1.get_Text() + "\r\nUserName" + TextBox5.get_Text() + "\r\nRegards\r\nI-CARE Hospital";
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
			((Component)(object)val).Dispose();
			((TextBoxBase)TextBox1).Clear();
			((TextBoxBase)TextBox2).Clear();
			((TextBoxBase)TextBox3).Clear();
			((TextBoxBase)TextBox4).Clear();
			((Control)ComboBox1).get_Controls().Clear();
			((TextBoxBase)TextBox5).Clear();
			((TextBoxBase)TextBox7).Clear();
			((TextBoxBase)TextBox6).Clear();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			MessageBox.Show(ex4.Message);
			ProjectData.ClearProjectError();
		}
		con.Close();
		((Form)this).Close();
	}

	private void An47(object p4MJ, EventArgs y4P5)
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

	private void Pa6x(object Eg51, EventArgs Sc07)
	{
		if (Operators.ConditionalCompareObjectEqual(ComboBox1.get_SelectedItem(), (object)"Emergency", false))
		{
			TextBox6.set_Text("");
			((Control)TextBox6).set_Enabled(false);
		}
		else
		{
			((Control)TextBox6).set_Enabled(true);
		}
	}
}
