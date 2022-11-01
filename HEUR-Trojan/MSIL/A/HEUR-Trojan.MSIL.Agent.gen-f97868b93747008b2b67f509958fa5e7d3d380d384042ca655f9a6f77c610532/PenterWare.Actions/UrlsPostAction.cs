using System;
using System.Collections.Specialized;
using System.Net;
using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal class UrlsPostAction : SubAction<UrlPostResult>
{
	public static string Name = "UrlsPost";

	public override string ActionName => Name;

	protected override void Run()
	{
		foreach (string url in Policy.Urls)
		{
			UrlPostResult.UrlPosted urlPosted = new UrlPostResult.UrlPosted
			{
				Url = url
			};
			PostRandomData(urlPosted);
			base.Result.UrlsPosted.Add(urlPosted);
		}
	}

	private void PostRandomData(UrlPostResult.UrlPosted urlPosted)
	{
		bool success = false;
		try
		{
			Random random = new Random();
			byte[] array = new byte[128];
			random.NextBytes(array);
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			using WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text = "param1";
			nameValueCollection.Add(text, Convert.ToBase64String(array));
			urlPosted.Data = text + "=" + Convert.ToBase64String(array);
			success = webClient.UploadValues(urlPosted.Url, "POST", nameValueCollection).Length != 0;
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Error sending data to {urlPosted.Url}, {arg}");
		}
		urlPosted.Success = success;
	}
}
