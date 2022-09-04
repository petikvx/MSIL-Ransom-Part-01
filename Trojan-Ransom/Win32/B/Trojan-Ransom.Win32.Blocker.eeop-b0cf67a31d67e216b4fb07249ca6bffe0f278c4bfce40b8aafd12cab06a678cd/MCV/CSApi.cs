using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using e9a0jRW7WM0ZtAYBQW;

namespace MCV;

public class CSApi
{
	private static string euNbpBRhl(string string_0)
	{
		if (string_0 == null)
		{
			return "";
		}
		Encoding aSCII = Encoding.ASCII;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_0)
		{
			byte[] bytes = aSCII.GetBytes(new char[1] { c });
			for (int j = 0; j < bytes.Length; j++)
			{
				byte b = bytes[j];
				if ((b >= 48 && b < 58) || (b >= 65 && b < 91) || (b >= 97 && b < 123))
				{
					stringBuilder.Append(Encoding.ASCII.GetString(bytes, j, 1));
				}
				else
				{
					stringBuilder.Append('%' + $"{(int)b:X2}");
				}
			}
		}
		return stringBuilder.ToString();
	}

	private static string eVUvTAATV(string string_0, params string[] ps)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			httpWebRequest.Proxy = GlobalProxySelection.GetEmptyWebProxy();
			httpWebRequest.ServicePoint.ConnectionLimit = 1000;
			string text = "";
			for (int i = 0; i + 1 < ps.Length; i += 2)
			{
				string text2 = text;
				text = text2 + euNbpBRhl(ps[i]) + "=" + euNbpBRhl(ps[i + 1]) + "&";
			}
			if (text.EndsWith("&"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			byte[] bytes = Encoding.ASCII.GetBytes(text);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			WebResponse response = httpWebRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			response.Close();
			requestStream.Close();
			return result;
		}
		catch
		{
			return "";
		}
	}

	private static string ety1ZhuDr(string[] string_0, string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < string_0.Length; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(string_1);
			}
			stringBuilder.Append(string_0[i]);
		}
		return stringBuilder.ToString();
	}

	public static string Decode(string user, string password, out string task_id, string image_fn, string[] words, string letters)
	{
		task_id = "-1";
		WebClient webClient = new WebClient();
		byte[] inArray = webClient.DownloadData(image_fn);
		string text = Convert.ToBase64String(inArray);
		string input = eVUvTAATV("http://bypassconfident.com/api_submit.php", "user", user, "password", password, "file", text, "letters", letters, "words", ety1ZhuDr(words, "|"), "base64_code", "1");
		Match match = Regex.Match(input, "^\\s*OK\\s+(\\d+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		if (!match.Success)
		{
			return null;
		}
		task_id = match.Groups[1].Value;
		int num = 0;
		while (true)
		{
			if (num < 300)
			{
				input = eVUvTAATV("http://bypassconfident.com/api_get.php", "user", user, "password", password, "id", task_id);
				if (input != null)
				{
					input = input.Trim();
					if (!(input == "NOT_INPUT"))
					{
						break;
					}
					Thread.Sleep(2000);
					num++;
					continue;
				}
				return null;
			}
			return null;
		}
		match = Regex.Match(input, "^\\s*OK\\s*(.+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		if (!match.Success)
		{
			return null;
		}
		return match.Groups[1].Value.Trim();
	}

	public static void Feedback(string user, string password, string task_id, bool is_input_correct)
	{
		eVUvTAATV("http://bypassconfident.com/api_report.php", "user", user, "password", password, "id", task_id, "value", is_input_correct ? "1" : "0");
	}

	public static int Left(string user, string password)
	{
		string text = eVUvTAATV("http://bypassconfident.com/api_left.php", "user", user, "password", password);
		if (text == null)
		{
			return -1;
		}
		Match match = Regex.Match(text, "^\\s*OK\\s+([\\-\\d]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		if (!match.Success)
		{
			return -1;
		}
		return int.Parse(match.Groups[1].Value);
	}

	public static void Example()
	{
		string user = "demo";
		string password = "demo";
		string task_id = "-1";
		string image_fn = "captcha.png";
		string letters = "UBORDYJKG";
		string[] words = new string[4] { "toys and games", "outer space", "food", "cat" };
		Console.WriteLine("Decoding.");
		string arg = Decode(user, password, out task_id, image_fn, words, letters);
		Console.WriteLine("Decoded value is: {0}", arg);
		Console.WriteLine("Suppose we check it as right.");
		Feedback(user, password, task_id, is_input_correct: true);
		Console.WriteLine("OK.");
		Console.WriteLine("Left {0} credits on your account.", Left(user, password));
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}

	public CSApi()
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		base._002Ector();
	}
}
