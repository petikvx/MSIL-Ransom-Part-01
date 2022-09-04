using System;
using System.IO;
using System.Net;

namespace Lexplorer;

internal class Class4
{
	private const string RESPONSE_OK = "OK";

	private string _host;

	public Class4(string host)
	{
		_host = host;
	}

	public int Send(string data)
	{
		try
		{
			string text = Recieve(data);
			if (text == "OK")
			{
				return 0;
			}
			if (int.TryParse(text, out var result))
			{
				return result;
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	public string Recieve(string parameters)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_host + "?" + parameters);
		try
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string result = string.Empty;
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				result = streamReader.ReadToEnd();
			}
			httpWebResponse.Close();
			return result;
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}
}
