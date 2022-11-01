using System;
using System.IO;
using System.Net;
using System.Text;
using PenterWare.Utils;

namespace PenterWare.Network.Clients;

internal class HTTPClient : Client
{
	protected static int MAX_RETRY_ATTEMPTS = 5;

	protected static int LINGER_TIMEOUT_SECONDS = 5;

	public static string responseFromServer;

	public string url { get; set; }

	public HTTPClient(string serverIp, int serverPort)
		: base(serverIp, serverPort)
	{
		url = "http://" + serverIp + ":" + serverPort;
	}

	public override void InitConnection()
	{
	}

	public override int Send(string postData)
	{
		if (postData == null)
		{
			return 0;
		}
		bool flag = false;
		WebRequest webRequest = WebRequest.Create(url);
		webRequest.Method = "POST";
		byte[] bytes = Encoding.UTF8.GetBytes(postData);
		webRequest.ContentType = "application/x-www-form-urlencoded";
		webRequest.ContentLength = bytes.Length;
		Stream requestStream = webRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = webRequest.GetResponse();
		GeneralUtils.Log(((HttpWebResponse)response).StatusDescription);
		try
		{
			using (requestStream = response.GetResponseStream())
			{
				responseFromServer = new StreamReader(requestStream).ReadToEnd();
				response.Close();
			}
			flag = true;
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Error in HTTPClient : {arg}");
		}
		if (flag)
		{
			return 1;
		}
		return 0;
	}

	public override string Recieve(int timeoutMicroseconds = -1)
	{
		return responseFromServer;
	}

	public override void Close()
	{
	}
}
