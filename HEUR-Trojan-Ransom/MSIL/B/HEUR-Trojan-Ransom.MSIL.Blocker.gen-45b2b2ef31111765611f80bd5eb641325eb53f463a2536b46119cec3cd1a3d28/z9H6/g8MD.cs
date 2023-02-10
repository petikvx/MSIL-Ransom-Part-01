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
using Microsoft.VisualBasic.CompilerServices;
using b7KT;

namespace z9H6;

[DesignerGenerated]
public class g8MD : Form
{
	private IContainer components;

	private OleDbConnection con;

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
			EventHandler eventHandler = Pz6b;
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
			EventHandler eventHandler = Ng40;
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

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
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
			EventHandler eventHandler = k9DL;
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
			EventHandler eventHandler = Mo02;
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

	public g8MD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)a2L8);
		con = new OleDbConnection();
		Tg95();
	}

	[DebuggerNonUserCode]
	protected override void w8RS(bool Wi07)
	{
		try
		{
			if (Wi07 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wi07);
		}
	}

	[DebuggerStepThrough]
	private void Tg95()
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
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		GroupBox1 = new GroupBox();
		TextBox4 = new TextBox();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Button3 = new Button();
		Button2 = new Button();
		Button1 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.Control);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Location(new Point(35, 32));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(610, 224));
		((Control)GroupBox1).set_TabIndex(22);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Pharmacist information:");
		((Control)TextBox4).set_Location(new Point(123, 169));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(452, 22));
		((Control)TextBox4).set_TabIndex(16);
		((Control)TextBox3).set_Location(new Point(123, 129));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(452, 22));
		((Control)TextBox3).set_TabIndex(15);
		((Control)TextBox2).set_Location(new Point(123, 86));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(452, 22));
		((Control)TextBox2).set_TabIndex(14);
		((Control)TextBox1).set_Location(new Point(123, 43));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(452, 22));
		((Control)TextBox1).set_TabIndex(13);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.Control);
		((Control)Label5).set_Location(new Point(60, 172));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(53, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Phone:");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.Control);
		((Control)Label4).set_Location(new Point(51, 129));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(64, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Address:");
		Label4.set_TextAlign((ContentAlignment)32);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.Control);
		((Control)Label3).set_Location(new Point(68, 86));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(46, 17));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Email:");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.Control);
		((Control)Label2).set_Location(new Point(64, 43));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Name:");
		Label2.set_TextAlign((ContentAlignment)32);
		((Control)Button3).set_Location(new Point(522, 288));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(123, 37));
		((Control)Button3).set_TabIndex(25);
		((ButtonBase)Button3).set_Text("Close");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Location(new Point(158, 288));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(125, 37));
		((Control)Button2).set_TabIndex(24);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(35, 288));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(115, 37));
		((Control)Button1).set_TabIndex(23);
		((ButtonBase)Button1).set_Text("Add");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(670, 339));
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form18");
		((Form)this).set_Text("Add Pharmacist");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string g3AQ(ref string o8NP)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(o8NP);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void a2L8(object Qz76, EventArgs f7Z2)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void k0A1(object Ec0t, EventArgs k4J3)
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
	}

	private void d1E7(object Mg4s, EventArgs Sf92)
	{
		((Form)this).Close();
	}

	internal static byte[] Ex64(int f1L6)
	{
		return Dm4y.t5P7(f1L6, checked(f1L6 + 1 - 48));
	}

	private void Mo02(object b8B2, EventArgs q6R9)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		con.Open();
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox4.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Can't leave any field empty", "Empty Field");
		}
		if ((TextBox4.get_Text().Length != 10) | TextBox4.get_Text().Contains(",") | TextBox4.get_Text().Contains(".") | TextBox4.get_Text().Contains("(") | TextBox4.get_Text().Contains("-") | TextBox4.get_Text().Contains(" ") | !Versioned.IsNumeric((object)TextBox4.get_Text()) | TextBox4.get_Text().Contains("+"))
		{
			MessageBox.Show("Enter valid 10-digit mobile number without +91 or 0 in the beginning", "Invalid Input");
			return;
		}
		string text = "Insert into Pharmacist_DataBase([Phar_Name],[Email],[Phone],[Address]) Values(?,?,?,?)";
		OleDbCommand val = new OleDbCommand(text, con);
		val.get_Parameters().Add(new OleDbParameter("Phar_Name", (object)TextBox1.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Email", (object)TextBox2.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Phone", (object)TextBox4.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Address", (object)TextBox3.get_Text()));
		try
		{
			val.ExecuteNonQuery();
			val.set_CommandText("SELECT @@IDENTITY");
			MessageBox.Show("ID" + val.ExecuteScalar().ToString(), "Successfully Added");
			try
			{
				string text2 = TextBox2.get_Text();
				SmtpClient smtpClient = new SmtpClient();
				MailMessage mailMessage = new MailMessage();
				smtpClient.UseDefaultCredentials = false;
				smtpClient.Credentials = new NetworkCredential("softwarelab20192@gmail.com", "software2019");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Host = "smtp.gmail.com";
				mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("softwarelab20192@gmail.com");
				mailMessage.To.Add(text2);
				mailMessage.Subject = "Patient SignUp@IITG Hospital";
				mailMessage.IsBodyHtml = true;
				mailMessage.Body = "Name:" + TextBox1.get_Text() + "\r\nSuccessfully Added\r\nRegards\r\nI-CARE Hospital";
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
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			MessageBox.Show(ex4.Message);
			ProjectData.ClearProjectError();
		}
		con.Close();
	}

	private void Ng40(object Ty97, EventArgs m7JF)
	{
	}

	private void k9DL(object St7y, EventArgs t1F5)
	{
	}

	internal static byte[] t6H1(int[] e0E9, int f5L3)
	{
		checked
		{
			byte[] array = new byte[f5L3 + 1];
			int num = e0E9.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)e0E9[i];
			}
			return array;
		}
	}

	private void Pz6b(object Gw49, EventArgs Ec12)
	{
	}
}
