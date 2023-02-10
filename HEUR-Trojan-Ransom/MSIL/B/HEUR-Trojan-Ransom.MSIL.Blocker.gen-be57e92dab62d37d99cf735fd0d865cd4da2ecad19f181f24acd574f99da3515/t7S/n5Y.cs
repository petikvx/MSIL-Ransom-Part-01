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
using g6CP;

namespace t7S;

[DesignerGenerated]
public class n5Y : Form
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
			EventHandler eventHandler = Zb73;
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
			EventHandler eventHandler = Lb65;
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
			EventHandler eventHandler = w5GX;
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
			EventHandler eventHandler = Jo41;
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

	public n5Y()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)w1CL);
		con = new OleDbConnection();
		Yw21();
	}

	[DebuggerNonUserCode]
	protected override void f9P(bool q4X)
	{
		try
		{
			if (q4X && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q4X);
		}
	}

	[DebuggerStepThrough]
	private void Yw21()
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

	private string Lk81(ref string Ww86)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(Ww86);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void w1CL(object Yw09, EventArgs s3YP)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void Xf01(object Bw58, EventArgs Nf2n)
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
	}

	private void z4Y1(object Mj1t, EventArgs Cf6c)
	{
		((Form)this).Close();
	}

	internal static byte[] Fn7q(int s3MC)
	{
		return x1HJ.a8GD(s3MC, checked(s3MC + 1 - 48));
	}

	private void Jo41(object z0JN, EventArgs z2HK)
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

	private void Lb65(object r1E2, EventArgs j8NZ)
	{
	}

	private void w5GX(object i7C8, EventArgs c2D6)
	{
	}

	internal static byte[] Ga64(int[] Dx03, int q2P7)
	{
		checked
		{
			byte[] array = new byte[q2P7 + 1];
			int num = Dx03.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Dx03[i];
			}
			return array;
		}
	}

	private void Zb73(object Ae4a, EventArgs x7K1)
	{
	}
}
