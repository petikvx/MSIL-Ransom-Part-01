#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace The_chViewer;

public class BbsBoard
{
	public static string CacheDir;

	private Thread _workerThread;

	public string Name { get; set; }

	public string HostName { get; set; }

	public string BoardDir { get; set; }

	public List<BbsThread> Threads { get; set; }

	public event Action<object, DownloadCompletedEventArgs> DownladCompleted;

	public BbsBoard()
	{
		Threads = new List<BbsThread>();
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

	public override string ToString()
	{
		return $"{Name}:{HostName}/{BoardDir}";
	}

	public void Download()
	{
		Threads.Clear();
		string text = "";
		string text2 = "";
		text2 = ((!GlobalConf.UseBg20 || !HostName.EndsWith(".2ch.net")) ? $"http://{HostName}/{BoardDir}/subject.txt" : $"http://bg20.2ch.net/test/p.so/{HostName}/{BoardDir}/");
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		using (WebClient webClient = new WebClient())
		{
			webClient.Headers.Add(HttpRequestHeader.UserAgent, GlobalConf.UserAgent);
			text = webClient.DownloadString(text2);
		}
		stopwatch.Stop();
		Debug.WriteLine("subject.txt loaded: taken " + (double)stopwatch.ElapsedMilliseconds / 1000.0 + "sec.");
		string[] array = text.Split(new char[1] { '\n' });
		for (int i = 0; i < array.Length; i++)
		{
			Match match = Regex.Match(array[i], "(?<epoch>\\d+)\\.dat<>(?<name>.+)\\((?<resnum>\\d+)\\)", RegexOptions.Compiled);
			if (match.Success)
			{
				BbsThread item = new BbsThread
				{
					Epoch = long.Parse(match.Groups["epoch"].Value),
					Name = match.Groups["name"].Value,
					ResNum = int.Parse(match.Groups["resnum"].Value)
				};
				Threads.Add(item);
			}
		}
	}
}
