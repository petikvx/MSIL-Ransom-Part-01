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
using Cm7;
using Gf25;
using Mg9;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace p6A;

[DesignerGenerated]
public class Kt4 : Form
{
	private IContainer components;

	private OleDbConnection con;

	private string Username;

	private string Password;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button2")]
	internal virtual Button Button2
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
			EventHandler eventHandler = Wx3;
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
			EventHandler eventHandler = Ld8;
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

	public Kt4()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)o5A);
		con = new OleDbConnection();
		Username = "staff";
		Ty0();
	}

	[DebuggerNonUserCode]
	protected override void n3C(bool Lm0)
	{
		try
		{
			if (Lm0 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lm0);
		}
	}

	[DebuggerStepThrough]
	private void Ty0()
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
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Kt4));
		Panel1 = new Panel();
		Button2 = new Button();
		Button1 = new Button();
		Button3 = new Button();
		Label5 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_Anchor((AnchorStyles)13);
		((Control)Panel1).set_BackColor(Color.Transparent);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label5);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel1).set_Location(new Point(312, 82));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(429, 303));
		((Control)Panel1).set_TabIndex(10);
		((Control)Button2).set_Location(new Point(180, 213));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(123, 37));
		((Control)Button2).set_TabIndex(16);
		((ButtonBase)Button2).set_Text("Close");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(30, 213));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(123, 37));
		((Control)Button1).set_TabIndex(15);
		((ButtonBase)Button1).set_Text("Login");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(374, 169));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(23, 23));
		((Control)Button3).set_TabIndex(10);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Location(new Point(27, 278));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(370, 17));
		((Control)Label5).set_TabIndex(9);
		Label5.set_Text("If you forgot your password , Please contact administrator");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 7.8f));
		((Control)Label4).set_Location(new Point(27, 55));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(98, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("STAFF LOGIN");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 7.8f));
		((Control)Label2).set_Location(new Point(27, 174));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(77, 17));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Password :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 7.8f));
		((Control)Label1).set_Location(new Point(27, 101));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(83, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("UserName :");
		((TextBoxBase)TextBox1).set_BackColor(Color.Azure);
		((Control)TextBox1).set_Location(new Point(113, 96));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(255, 22));
		((Control)TextBox1).set_TabIndex(2);
		((Control)TextBox2).set_Location(new Point(113, 169));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(255, 22));
		((Control)TextBox2).set_TabIndex(3);
		((Control)TextBox2).set_Tag((object)"");
		TextBox2.set_UseSystemPasswordChar(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Form21");
		((Form)this).set_Text("Staff Login");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string Rq5(ref string w6W)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(w6W);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private string r9A()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		try
		{
			con.Open();
			string text = "Select * From Password_DataBase where UserName like 'staff'";
			OleDbCommand val = new OleDbCommand(text, con);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				Console.WriteLine(val2.GetString(1));
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

	private void Wx3(object Hi0, EventArgs Cn5)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		Password = r9A();
		try
		{
			if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) & (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) & (Operators.CompareString(TextBox2.get_Text(), "", false) == 0))
			{
				Interaction.MsgBox((object)"You Have Not Entered Username And Password , please Fill The Details", (MsgBoxStyle)0, (object)null);
				return;
			}
			bool num = Operators.CompareString(Username, TextBox1.get_Text(), false) == 0;
			string password = Password;
			TextBox val;
			string w6W = (val = TextBox2).get_Text();
			string text = Rq5(ref w6W);
			val.set_Text(w6W);
			if (num & (Operators.CompareString(password, text, false) == 0))
			{
				((Control)Jy6g.Forms.Form12).Show();
				((Control)Jy6g.Forms.Form12.Button4).set_Visible(false);
				((Control)Jy6g.Forms.Form12.Button5).set_Visible(false);
				((Control)Jy6g.Forms.Form12.Button6).set_Visible(false);
				((Control)Jy6g.Forms.Form12.Button7).set_Visible(false);
				((Control)Jy6g.Forms.Form12.Button16).set_Visible(false);
				((Control)Jy6g.Forms.Form12.Button17).set_Visible(false);
				((Control)Jy6g.Forms.Form12.FlowLayoutPanel2).set_Enabled(false);
				((Form)this).Close();
			}
			else
			{
				Interaction.MsgBox((object)"Invalid Username / Password Of Admin", (MsgBoxStyle)16, (object)"Error");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Error");
			ProjectData.ClearProjectError();
		}
	}

	private void Ec7(object Gn5, EventArgs w2Q)
	{
		((Form)this).Close();
		((Control)Jy6g.Forms.Form1).Show();
	}

	internal static byte[] f1B(int k4Y)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return No1.Qn6(w2X.As3o(), k4Y);
	}

	private void Ld8(object k4K, EventArgs g4N)
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

	private void o5A(object Ja2, EventArgs s1R)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}
}
