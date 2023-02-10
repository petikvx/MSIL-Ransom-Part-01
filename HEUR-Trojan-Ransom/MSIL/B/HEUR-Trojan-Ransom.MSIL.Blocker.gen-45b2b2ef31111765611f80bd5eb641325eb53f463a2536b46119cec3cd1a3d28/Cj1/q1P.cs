using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Ga80;
using Microsoft.VisualBasic.CompilerServices;

namespace Cj1;

[DesignerGenerated]
public class q1P : Form
{
	private IContainer components;

	private OleDbConnection con;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = r1B4;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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
			EventHandler eventHandler = y7D6;
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = x7RM;
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
			EventHandler eventHandler = Lo71;
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
			EventHandler eventHandler = Fz91;
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public q1P()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Cq0x);
		con = new OleDbConnection();
		k1D();
	}

	[DebuggerNonUserCode]
	protected override void Gf1(bool a7W)
	{
		try
		{
			if (a7W && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a7W);
		}
	}

	[DebuggerStepThrough]
	private void k1D()
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
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(q1P));
		Label1 = new Label();
		TextBox1 = new TextBox();
		Label2 = new Label();
		TextBox2 = new TextBox();
		Label3 = new Label();
		TextBox3 = new TextBox();
		Button1 = new Button();
		Label4 = new Label();
		Button3 = new Button();
		Button2 = new Button();
		Button4 = new Button();
		ComboBox1 = new ComboBox();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(29, 60));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(137, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Enter Old Password:");
		((Control)TextBox1).set_Location(new Point(207, 60));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(142, 22));
		((Control)TextBox1).set_TabIndex(1);
		TextBox1.set_UseSystemPasswordChar(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(29, 88));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(142, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Enter New Password:");
		((Control)TextBox2).set_Location(new Point(207, 88));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(142, 22));
		((Control)TextBox2).set_TabIndex(3);
		TextBox2.set_UseSystemPasswordChar(true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(29, 116));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(86, 17));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Enter Again:");
		((Control)TextBox3).set_Location(new Point(207, 116));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(142, 22));
		((Control)TextBox3).set_TabIndex(5);
		TextBox3.set_UseSystemPasswordChar(true);
		((Control)Button1).set_Location(new Point(135, 155));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(98, 28));
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_Text("SUBMIT");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(29, 29));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(73, 17));
		((Control)Label4).set_TabIndex(8);
		Label4.set_Text("Username");
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(355, 60));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(23, 23));
		((Control)Button3).set_TabIndex(11);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((Control)Button2).set_Location(new Point(355, 88));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(23, 22));
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(355, 115));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(23, 23));
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[3] { "admin", "staff", "pharmacist" });
		((Control)ComboBox1).set_Location(new Point(207, 26));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(142, 24));
		((Control)ComboBox1).set_TabIndex(14);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(386, 195));
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Form24");
		((Form)this).set_Text("Change Admin Password");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string No4w(ref string e1YR)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(e1YR);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void Cq0x(object Co25, EventArgs s2P1)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		ComboBox1.set_Text("admin");
		con.set_ConnectionString(connectionString);
		string e1YR = "staff";
		Console.WriteLine(No4w(ref e1YR));
	}

	private string Yq6n()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		try
		{
			con.Open();
			string text = "Select * From Password_DataBase where UserName like '" + ComboBox1.get_Text() + "'";
			OleDbCommand val = new OleDbCommand(text, con);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				result = val2.GetString(1);
			}
			val2.Close();
			((Component)(object)val).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			con.Close();
		}
		return result;
	}

	private void y7D6(object Sd26, EventArgs Cf29)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		string text = Yq6n();
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Any field can't be empty");
			return;
		}
		con.Open();
		TextBox val;
		string e1YR = (val = TextBox2).get_Text();
		string text2 = No4w(ref e1YR);
		val.set_Text(e1YR);
		string text3 = text2;
		e1YR = (val = TextBox1).get_Text();
		string text4 = No4w(ref e1YR);
		val.set_Text(e1YR);
		if (Operators.CompareString(text4, text, false) != 0)
		{
			MessageBox.Show("Wrong Old Password");
			((TextBoxBase)TextBox1).Clear();
			((TextBoxBase)TextBox2).Clear();
			((TextBoxBase)TextBox3).Clear();
		}
		else if (Operators.CompareString(TextBox2.get_Text(), TextBox3.get_Text(), false) != 0)
		{
			MessageBox.Show("New password entered wrong");
			((TextBoxBase)TextBox2).Clear();
			((TextBoxBase)TextBox3).Clear();
		}
		else
		{
			OleDbCommand val2 = new OleDbCommand("UPDATE Password_DataBase SET Admin_Password ='" + text3 + "'  where ( UserName Like '" + ComboBox1.get_Text() + "' )", con);
			MessageBox.Show("Successfully changed password");
			val2.ExecuteNonQuery();
			((Component)(object)val2).Dispose();
		}
		con.Close();
		((Form)this).Close();
	}

	private void r1B4(object Ap79, EventArgs Qk0d)
	{
	}

	private void x7RM(object Bm38, EventArgs St9q)
	{
		if (TextBox1.get_UseSystemPasswordChar())
		{
			TextBox1.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox1.set_UseSystemPasswordChar(true);
		}
	}

	internal static void f0SP()
	{
		string[] m6DA = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = t4P2.e2XT(m6DA, 0, 3);
		string value2 = t4P2.e2XT(m6DA, 4, 7);
		t4P2.mDic.Add(t4P2.tName, value);
		t4P2.mDic.Add(t4P2.mName, value2);
	}

	private void Lo71(object Ni2o, EventArgs r7QW)
	{
		if (TextBox2.get_UseSystemPasswordChar())
		{
			TextBox2.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox2.set_UseSystemPasswordChar(true);
		}
	}

	private void Fz91(object Rg8m, EventArgs Zz21)
	{
		if (TextBox3.get_UseSystemPasswordChar())
		{
			TextBox3.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox3.set_UseSystemPasswordChar(true);
		}
	}
}
