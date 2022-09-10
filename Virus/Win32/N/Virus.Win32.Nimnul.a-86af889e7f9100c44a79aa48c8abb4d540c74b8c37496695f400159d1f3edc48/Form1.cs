using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	private Button _Button1;

	private Label _Label1;

	private Label _Label2;

	private Label _Label3;

	private TextBox _TextBox1;

	private TextBox _TextBox2;

	private TextBox _TextBox3;

	private Button _Button2;

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox3 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
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
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(207, 70);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(73, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Login");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 21);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(55, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Username");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(12, 47);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(53, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Password");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(37, 2);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(212, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Please login with your GzN info to continue.");
		TextBox textBox = TextBox1;
		location = new Point(73, 18);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(161, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(4);
		TextBox textBox3 = TextBox2;
		location = new Point(71, 44);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox2.set_PasswordChar('*');
		TextBox textBox4 = TextBox2;
		size = new Size(161, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(5);
		TextBox textBox5 = TextBox3;
		location = new Point(5, 73);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		((TextBoxBase)TextBox3).set_ReadOnly(true);
		TextBox textBox6 = TextBox3;
		size = new Size(196, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(7);
		TextBox3.set_TextAlign((HorizontalAlignment)2);
		Button button3 = Button2;
		location = new Point(207, 70);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(73, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(8);
		((ButtonBase)Button2).set_Text("Continue");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(281, 94);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("GamerzNeeds.net - WarRock Loader");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Conversions.ToBoolean(method_0(TextBox1.get_Text(), TextBox2.get_Text()));
	}

	public object method_0(string Username, string Password)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		Password = method_1(Password);
		bool flag = false;
		string text = "vb_login_username=" + Username + "&vb_login_password=&s=&do=login&vb_login_md5password=" + Password + "&vb_login_md5password_utf=" + Password;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.gamerzneeds.net/forums/login.php?do=login");
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.UserAgent = "-- vBulletin Vaidation  --";
			httpWebRequest.ContentLength = text.Length;
			StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
			streamWriter.Write(text);
			streamWriter.Flush();
			streamWriter.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string text2 = streamReader.ReadToEnd();
			if (text2.Contains("Thank you for logging in"))
			{
				flag = true;
				TextBox3.set_Text("Login Successful!");
				((TextBoxBase)TextBox3).set_ForeColor(Color.Green);
				Interaction.MsgBox((object)("Thank you for logging in, " + TextBox1.get_Text() + "!"), (MsgBoxStyle)64, (object)"Succeed!");
				((Control)Button1).set_Enabled(false);
				((Control)TextBox2).set_Enabled(false);
				((Control)TextBox1).set_Enabled(false);
				((Control)Button2).set_Visible(true);
				((Control)Button1).set_Visible(false);
			}
			else
			{
				Interaction.MsgBox((object)"[#0014]: Incorrect Username or Password!", (MsgBoxStyle)0, (object)null);
				flag = false;
				TextBox3.set_Text("Login Unsuccessful!");
				((TextBoxBase)TextBox3).set_ForeColor(Color.Red);
			}
			if (text2.Contains("You have used up your failed login quota"))
			{
				flag = false;
				Interaction.MsgBox((object)"[#0015]: You have used up your failed login quota! Please try again in 15 minutes!", (MsgBoxStyle)0, (object)null);
				TextBox3.set_Text("Retry in 15 Minutes..");
				((TextBoxBase)TextBox3).set_ForeColor(Color.Orange);
			}
			if (text2.Contains("You have been banned for the following reason"))
			{
				flag = false;
				Interaction.MsgBox((object)"[#0016]: You are banned and cannot use this loader.", (MsgBoxStyle)0, (object)null);
				TextBox3.set_Text("Found banned user!");
				((TextBoxBase)TextBox3).set_ForeColor(Color.Purple);
			}
			httpWebResponse.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "[#0012]: GamerzNeeds Login ERROR! Please try again later..", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public string method_1(string number)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		string text = string.Empty;
		byte[] bytes = aSCIIEncoding.GetBytes(number);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			text += b.ToString("x2");
		}
		return text;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)Class0.Forms.Form2_0).Show();
		((Control)this).Hide();
	}
}
