using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace InstagramApiSharp.Logger;

public class DebugLogger : IInstaLogger
{
	private readonly LogLevel _logLevel;

	public DebugLogger(LogLevel loglevel)
	{
		_logLevel = loglevel;
	}

	public void LogRequest(HttpRequestMessage request)
	{
		if (_logLevel >= LogLevel.Request)
		{
			WriteSeprator();
			Write($"Request: {request.Method} {request.RequestUri}");
			WriteHeaders(request.Headers);
			WriteProperties(request.Properties);
			if (request.Method == HttpMethod.Post)
			{
				WriteRequestContent(request.Content);
			}
		}
	}

	public void LogRequest(Uri uri)
	{
		if (_logLevel >= LogLevel.Request)
		{
			Write($"Request: {uri}");
		}
	}

	public void LogResponse(HttpResponseMessage response)
	{
		if (_logLevel >= LogLevel.Response)
		{
			Write($"Response: {response.RequestMessage!.Method} {response.RequestMessage!.RequestUri} [{response.StatusCode}]");
			WriteContent(response.Content, Formatting.None);
		}
	}

	public void LogException(Exception ex)
	{
		if (_logLevel >= LogLevel.Exceptions)
		{
			Console.WriteLine($"Exception: {ex}");
			Console.WriteLine("Stacktrace: " + ex.StackTrace);
		}
	}

	public void LogInfo(string info)
	{
		if (_logLevel >= LogLevel.Info)
		{
			Write("Info:" + Environment.NewLine + info);
		}
	}

	private void WriteHeaders(HttpHeaders headers)
	{
		if (headers == null || !headers.Any())
		{
			return;
		}
		Write("Headers:");
		foreach (KeyValuePair<string, IEnumerable<string>> header in headers)
		{
			Write(header.Key + ":" + JsonConvert.SerializeObject(header.Value));
		}
	}

	private void WriteProperties(IDictionary<string, object> properties)
	{
		if (properties != null && properties.Count != 0)
		{
			Write("Properties:\n" + JsonConvert.SerializeObject(properties, Formatting.Indented));
		}
	}

	private async void WriteContent(HttpContent content, Formatting formatting, int maxLength = 0)
	{
		Write("Content:");
		string text = await content.ReadAsStringAsync();
		if (formatting == Formatting.Indented)
		{
			text = FormatJson(text);
		}
		text = (text.Contains("<!DOCTYPE html>") ? "got html content!" : text);
		if (text.Length > maxLength && maxLength != 0)
		{
			text = text.Substring(0, maxLength);
		}
		Write(text);
	}

	private async void WriteRequestContent(HttpContent content, int maxLength = 0)
	{
		Write("Content:");
		string text = await content.ReadAsStringAsync();
		if (text.Length > maxLength && maxLength != 0)
		{
			text = text.Substring(0, maxLength);
		}
		Write(WebUtility.UrlDecode(text));
	}

	private void WriteSeprator()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 100; i++)
		{
			stringBuilder.Append("-");
		}
		Write(stringBuilder.ToString());
	}

	private string FormatJson(string json)
	{
		dynamic val = JsonConvert.DeserializeObject(json);
		return JsonConvert.SerializeObject(val, Formatting.Indented);
	}

	private void Write(string message)
	{
		Console.WriteLine(DateTime.Now.ToString() + ":\t" + message);
	}
}
