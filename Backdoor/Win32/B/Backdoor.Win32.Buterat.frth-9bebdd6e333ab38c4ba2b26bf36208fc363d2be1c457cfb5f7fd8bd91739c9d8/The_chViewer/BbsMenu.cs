#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace The_chViewer;

public class BbsMenu
{
	public static string CacheDir;

	private Thread _workerThread;

	public List<string> Categories { get; set; }

	public Dictionary<string, List<BbsBoard>> Boards { get; set; }

	public event Action<object, DownloadCompletedEventArgs> DownladCompleted;

	public BbsMenu()
	{
		Categories = new List<string>();
		Boards = new Dictionary<string, List<BbsBoard>>();
	}

	public void DownloadAsync()
	{
		_workerThread = new Thread((ThreadStart)delegate
		{
			Download();
			this.DownladCompleted(this, new DownloadCompletedEventArgs());
		});
		_workerThread.Start();
	}

	public void DownloadCancel()
	{
		if (_workerThread != null && _workerThread.ThreadState == System.Threading.ThreadState.Running)
		{
			_workerThread.Abort();
		}
	}

	public void Download()
	{
		Categories.Clear();
		string address = "http://menu.2ch.net/bbsmenu.html";
		string input = "";
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		using (WebClient webClient = new WebClient())
		{
			webClient.Headers.Add(HttpRequestHeader.UserAgent, GlobalConf.UserAgent);
			input = webClient.DownloadString(address);
		}
		stopwatch.Stop();
		Debug.WriteLine("BBS menu loaded: taken " + (double)stopwatch.ElapsedMilliseconds / 1000.0 + "sec.");
		string[] array = Regex.Split(input, "<B>(?<category>.+?)</B>");
		for (int i = 1; i < array.Count() - 1; i += 2)
		{
			string text = array[i];
			Categories.Add(text);
			string pattern = "<A HREF=http://(?<server>[a-zA-Z0-9]+?.2ch.net)/(?<dir>[a-zA-Z0-9]+?)/>(?<name>.+?)</A>";
			if (text == "BBSPINK")
			{
				pattern = "<A HREF=http://(?<server>[a-zA-Z0-9]+?.bbspink.com)/(?<dir>[a-zA-Z0-9]+?)/>(?<name>.+?)</A>";
			}
			MatchCollection matchCollection = Regex.Matches(array[i + 1], pattern);
			if (matchCollection.Count == 0)
			{
				continue;
			}
			List<BbsBoard> list = new List<BbsBoard>();
			foreach (Match item2 in matchCollection)
			{
				BbsBoard item = new BbsBoard
				{
					Name = item2.Groups["name"].Value,
					BoardDir = item2.Groups["dir"].Value,
					HostName = item2.Groups["server"].Value
				};
				list.Add(item);
			}
			Boards.Add(text, list);
		}
	}
}
