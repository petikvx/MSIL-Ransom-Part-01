using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Le41;
using Microsoft.VisualBasic.CompilerServices;

namespace d6X;

[DesignerGenerated]
public class Kr2 : Form
{
	private IContainer components;

	private OleDbConnection con;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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
			EventHandler eventHandler = j8D;
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
			EventHandler eventHandler = n3P;
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
			EventHandler eventHandler = Ap9;
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
			EventHandler eventHandler = Cf0;
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
			EventHandler eventHandler = x8L;
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

	public Kr2()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Aq2);
		con = new OleDbConnection();
		w4J();
	}

	[DebuggerNonUserCode]
	protected override void b0B(bool m8F)
	{
		try
		{
			if (m8F && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m8F);
		}
	}

	[DebuggerStepThrough]
	private void w4J()
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
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Kr2));
		GroupBox1 = new GroupBox();
		Button1 = new Button();
		Button4 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		TextBox4 = new TextBox();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).set_Location(new Point(26, 34));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(333, 205));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Doctor");
		((Control)Button1).set_Location(new Point(114, 157));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(98, 28));
		((Control)Button1).set_TabIndex(20);
		((ButtonBase)Button1).set_Text("SUBMIT");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(303, 118));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(23, 23));
		((Control)Button4).set_TabIndex(19);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((Control)Button2).set_Location(new Point(303, 91));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(23, 22));
		((Control)Button2).set_TabIndex(18);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(303, 63));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(23, 23));
		((Control)Button3).set_TabIndex(17);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)TextBox4).set_Enabled(false);
		((Control)TextBox4).set_Location(new Point(155, 32));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(142, 22));
		((Control)TextBox4).set_TabIndex(16);
		((Control)TextBox3).set_Location(new Point(155, 119));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(142, 22));
		((Control)TextBox3).set_TabIndex(15);
		TextBox3.set_UseSystemPasswordChar(true);
		((Control)TextBox2).set_Location(new Point(155, 91));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(142, 22));
		((Control)TextBox2).set_TabIndex(14);
		TextBox2.set_UseSystemPasswordChar(true);
		((Control)TextBox1).set_Location(new Point(155, 63));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(142, 22));
		((Control)TextBox1).set_TabIndex(13);
		TextBox1.set_UseSystemPasswordChar(true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(16, 32));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(73, 17));
		((Control)Label4).set_TabIndex(12);
		Label4.set_Text("Username");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(16, 119));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(86, 17));
		((Control)Label3).set_TabIndex(11);
		Label3.set_Text("Enter Again:");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(16, 91));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(142, 17));
		((Control)Label2).set_TabIndex(10);
		Label2.set_Text("Enter New Password:");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(16, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(137, 17));
		((Control)Label1).set_TabIndex(9);
		Label1.set_Text("Enter Old Password:");
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(391, 266));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form26");
		((Form)this).set_Text("Change Password");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string Yn6(ref string y7S)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(y7S);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void Aq2(object Ht2, EventArgs So4)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private string e8L(string g2Z, string e2J)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		try
		{
			con.Open();
			string text = "Select * From " + g2Z + " where UserName like '" + e2J + "'";
			OleDbCommand val = new OleDbCommand(text, con);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				result = ((Operators.CompareString(g2Z, "Doctor_DataBase", false) != 0) ? val2.GetString(5) : val2.GetString(8));
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

	private void x8L(object a3G, EventArgs e4P)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Operators.CompareString(GroupBox1.get_Text(), "Doctor", false) != 0) ? "Patient_DataBase" : "Doctor_DataBase");
		try
		{
			string text2 = e8L(text, TextBox4.get_Text());
			if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0))
			{
				MessageBox.Show("Any field can't be empty");
				return;
			}
			con.Open();
			TextBox val;
			string y7S = (val = TextBox2).get_Text();
			string text3 = Yn6(ref y7S);
			val.set_Text(y7S);
			string text4 = text3;
			y7S = (val = TextBox1).get_Text();
			string text5 = Yn6(ref y7S);
			val.set_Text(y7S);
			if (Operators.CompareString(text5, text2, false) != 0)
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
				OleDbCommand val2 = new OleDbCommand("UPDATE " + text + " SET Password_Doc ='" + text4 + "'", con);
				MessageBox.Show("Successfully changed password");
				val2.ExecuteNonQuery();
				((Component)(object)val2).Dispose();
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
		((Form)this).Close();
	}

	private void j8D(object s0T, EventArgs i8J)
	{
	}

	private void Cf0(object b0L, EventArgs Ns4)
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

	internal static string[] Zf3()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)w7FK.mDic["Ann"]).GetManifestResourceNames();
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

	private void Ap9(object Fm3, EventArgs w6B)
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

	private void n3P(object Pq3, EventArgs g9X)
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
