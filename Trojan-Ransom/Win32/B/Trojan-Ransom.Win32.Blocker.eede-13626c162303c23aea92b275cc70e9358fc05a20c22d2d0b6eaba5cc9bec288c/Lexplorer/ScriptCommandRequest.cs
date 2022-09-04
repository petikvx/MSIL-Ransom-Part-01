using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Lexplorer;

internal class ScriptCommandRequest : Class13
{
	private const string ATTRIBUTE_HEADER = "H";

	private const string ATTRIBUTE_RESULT = "R";

	private const string ATTRIBUTE_CONDITION = "CON";

	private const string ATTRIBUTE_CONDITION_TRUE = "T";

	private const string ATTRIBUTE_CONDITION_FALSE = "F";

	private const char DELIMITER_OPEN = '[';

	private const char DELIMITER_CLOSE = ']';

	private const string DELIMITER_CLOSE_EX = "  ]";

	private const string RESPONSE_MARKER = "{R}";

	public ScriptCommandRequest()
	{
		methodTable.Add("SEND", commandSend);
	}

	private string xmlEscapeToNormalCharacters(string source)
	{
		return source.Replace("&amp;", "&").Replace("&gt;", ">").Replace("&lt;", "<");
	}

	private bool commandSend(Class10 props, bool forced)
	{
		props.TryGetValue("H", out var value);
		props.TryGetValue("R", out var value2);
		props.TryGetValue("CON", out var value3);
		props.TryGetValue("T", out var value4);
		props.TryGetValue("F", out var value5);
		value = xmlEscapeToNormalCharacters(value);
		value2 = xmlEscapeToNormalCharacters(value2);
		value3 = xmlEscapeToNormalCharacters(value3);
		value4 = xmlEscapeToNormalCharacters(value4);
		value5 = xmlEscapeToNormalCharacters(value5);
		string text = SendScriptRequest(value);
		if (text == null)
		{
			Console.WriteLine("Failed to recieve response body");
			return false;
		}
		text = ParseResult(text, value2);
		if (CheckCondition(value3, text))
		{
			Console.WriteLine(SendScriptRequest(value4.Replace("{R}", text)));
			Console.WriteLine("Condition is TRUE");
		}
		else
		{
			Console.WriteLine(SendScriptRequest(value5.Replace("{R}", text)));
			Console.WriteLine("Condition is FALSE");
		}
		return true;
	}

	private string SendScriptRequest(string sourceScript)
	{
		Class10 properties = GetProperties(sourceScript);
		HttpWebRequest httpWebRequest = formRequest(properties);
		if (httpWebRequest == null)
		{
			Console.WriteLine("Failed to form web request");
			return null;
		}
		Console.WriteLine("Retrieving...");
		string value = string.Empty;
		if (properties.TryGetValue("body", out value))
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			httpWebRequest.ContentLength = bytes.Length;
			using Stream stream = httpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		string text = string.Empty;
		using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
		{
			text = streamReader.ReadToEnd();
			Console.WriteLine(text);
		}
		Console.WriteLine("Done");
		return text;
	}

	private string ParseResult(string source, string matcher)
	{
		int num = matcher.IndexOf('[');
		int num2 = matcher.IndexOf("  ]");
		if (num2 != -1 && num != -1)
		{
			string text = matcher.Substring(num + 1, num2 - num - 1);
			text = text.Replace("&gt;", ">").Replace("&lt;", "<");
			Regex regex = new Regex(text);
			Class10 properties = GetProperties(matcher.Substring(num2 + 1));
			string value = "";
			properties.TryGetValue("getAll", out value);
			if (value == "true")
			{
				properties.TryGetValue("splitby", out value);
			}
			string text2 = string.Empty;
			MatchCollection matchCollection = regex.Matches(source);
			{
				foreach (Match item in matchCollection)
				{
					if (item.Success)
					{
						text2 = ((item.Groups == null || item.Groups.Count <= 1) ? (text2 + item.Value + value) : (text2 + item.Groups[1].Value + value));
					}
				}
				return text2;
			}
		}
		return null;
	}

	private bool CheckCondition(string script, string data)
	{
		int num = script.IndexOf('[');
		int num2 = script.LastIndexOf(']');
		script = script.Substring(num + 1, num2 - num - 1);
		string[] array = script.Split();
		if (array.Length < 3)
		{
			Console.WriteLine($"Not enough tokens. Should be at least 3, found: {array.Length}");
			return false;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == "{R}")
			{
				array[i] = data;
			}
		}
		double result;
		double result2;
		switch (array[1])
		{
		case "==":
			return array[0] == array[2];
		case "!=":
			return array[0] != array[2];
		case ">=":
			if (!double.TryParse(array[0], out result))
			{
				return false;
			}
			if (!double.TryParse(array[2], out result2))
			{
				return false;
			}
			return result >= result2;
		case "<=":
			if (!double.TryParse(array[0], out result))
			{
				return false;
			}
			if (!double.TryParse(array[2], out result2))
			{
				return false;
			}
			return result <= result2;
		case "<":
			if (!double.TryParse(array[0], out result))
			{
				return false;
			}
			if (!double.TryParse(array[2], out result2))
			{
				return false;
			}
			return result < result2;
		case ">":
			if (!double.TryParse(array[0], out result))
			{
				return false;
			}
			if (!double.TryParse(array[2], out result2))
			{
				return false;
			}
			return result > result2;
		case "contains":
			return array[0].Contains(array[2]);
		case "!contains":
			return !array[0].Contains(array[2]);
		default:
			return false;
		}
	}

	private Class10 GetProperties(string sourceString)
	{
		Class10 @class = new Class10();
		int num = 0;
		int num2 = 0;
		num = sourceString.IndexOf('[', 0);
		for (num2 = sourceString.IndexOf(']', num); num2 != -1; num2 = sourceString.IndexOf(']', num))
		{
			string text = sourceString.Substring(num + 1, num2 - num - 1);
			text = text.Replace("&amp;", "&").Replace("&gt;", "<").Replace("&lt;", ">");
			int num3 = text.IndexOf(':');
			string key = text.Substring(0, num3);
			string text2 = text.Substring(num3 + 1);
			if (text2.StartsWith(" "))
			{
				text2 = text2.Substring(1);
			}
			@class.Add(key, text2);
			num = sourceString.IndexOf('[', num + 1);
			if (num == -1)
			{
				break;
			}
		}
		return @class;
	}

	private HttpWebRequest formRequest(Class10 headers)
	{
		string value = null;
		if (!headers.TryGetValue("url", out value))
		{
			Console.WriteLine("Failed to get url from header");
			return null;
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(value);
		Dictionary<string, string>.Enumerator enumerator = headers.GetEnumerator();
		while (enumerator.MoveNext())
		{
			try
			{
				switch (enumerator.Current.Key)
				{
				case "User-Agent":
					httpWebRequest.UserAgent = enumerator.Current.Value;
					break;
				case "Accept":
					httpWebRequest.Accept = enumerator.Current.Value;
					break;
				case "Referer":
					httpWebRequest.Referer = enumerator.Current.Value;
					break;
				case "Connection":
					httpWebRequest.KeepAlive = true;
					break;
				case "Content-Type":
					httpWebRequest.ContentType = enumerator.Current.Value;
					break;
				case "method":
					httpWebRequest.Method = enumerator.Current.Value;
					break;
				default:
					httpWebRequest.Headers.Add(enumerator.Current.Key, enumerator.Current.Value);
					break;
				case "url":
				case "Content-Length":
				case "body":
					break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(enumerator.Current.Key + " === " + enumerator.Current.Value);
				Console.WriteLine(ex.Message);
			}
		}
		return httpWebRequest;
	}

	public override string ToString()
	{
		return $"Command type: REQUEST, Method={base.ExecutionMethodName}";
	}
}
