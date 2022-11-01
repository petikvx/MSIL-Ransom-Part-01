using System.IO;
using System.Net;

namespace YullySpoofer;

public class IP
{
	public static string Grab()
	{
		string requestUriString = "https://api.ipify.org/";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		System.IO.Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}
}
