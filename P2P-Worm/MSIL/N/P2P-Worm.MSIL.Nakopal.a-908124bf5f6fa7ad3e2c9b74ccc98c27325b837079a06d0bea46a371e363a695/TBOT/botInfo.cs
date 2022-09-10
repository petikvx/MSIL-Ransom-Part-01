using System;
using System.Globalization;
using System.Net;

namespace TBOT;

internal class botInfo
{
	public enum codeType
	{
		Short,
		Full
	}

	public static string randID()
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUV0123456789";
		string text2 = "";
		Random random = new Random();
		for (int i = 0; i < 6; i++)
		{
			text2 += text[random.Next(text.Length)];
		}
		return text2;
	}

	public static string getOS()
	{
		string text = Environment.OSVersion.Version.ToString();
		if (text.StartsWith("6.1"))
		{
			return "WIN7";
		}
		if (text.StartsWith("6"))
		{
			return "VIS";
		}
		if (text.StartsWith("5.1"))
		{
			return "XP";
		}
		if (text.StartsWith("5"))
		{
			return "2000";
		}
		if (text.StartsWith("4.9"))
		{
			return "ME";
		}
		if (text.StartsWith("4.1"))
		{
			return "98";
		}
		return "UNKN";
	}

	public static string getIP()
	{
		try
		{
			WebClient webClient = new WebClient();
			return webClient.DownloadString("http://whatismyip.com/automation/n09230945.asp");
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string countryCode(codeType type)
	{
		RegionInfo currentRegion = RegionInfo.CurrentRegion;
		if (type == codeType.Full)
		{
			return currentRegion.EnglishName;
		}
		return currentRegion.ThreeLetterISORegionName;
	}
}
