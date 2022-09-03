using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Loader;

internal class Connection
{
	private void Gate(Uri Host)
	{
		_ = (HttpWebRequest)WebRequest.Create(Host);
	}

	public static string Command(string Host)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Host);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
		return streamReader.ReadToEnd();
	}

	private void Respond(Uri Host)
	{
		_ = (HttpWebRequest)WebRequest.Create(Host);
	}

	private void Sleep(int Time)
	{
		Thread.Sleep(Time);
	}
}
