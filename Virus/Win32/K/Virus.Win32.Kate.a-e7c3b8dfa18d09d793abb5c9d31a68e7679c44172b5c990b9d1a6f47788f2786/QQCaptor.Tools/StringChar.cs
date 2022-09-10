using System;
using System.Text;

namespace QQCaptor.Tools;

internal class StringChar
{
	internal static string UrlEncode(string url)
	{
		byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(url);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < bytes.Length; i++)
		{
			if (bytes[i] < 128)
			{
				stringBuilder.Append((char)bytes[i]);
				continue;
			}
			stringBuilder.Append("%" + bytes[i++].ToString("x").PadLeft(2, '0'));
			stringBuilder.Append("%" + bytes[i].ToString("x").PadLeft(2, '0'));
		}
		return stringBuilder.ToString();
	}

	internal static string ChinaUnicodeToASCII(string strInput)
	{
		string text = null;
		string text2 = strInput;
		int num = -1;
		int num2 = -1;
		while (true)
		{
			num = text2.IndexOf("&#x", 0);
			num2 = text2.IndexOf(";", 0);
			if (num != -1)
			{
				if (num > 0)
				{
					int length = text2.Length;
					string text3 = text2.Substring(0, num);
					text += text3;
					text2 = text2.Substring(num, length - num);
					continue;
				}
				int length2 = text2.Length;
				int num3 = num2 - num - 3;
				if (num3 <= 0)
				{
					break;
				}
				string value = text2.Substring(num + 3, num3);
				int num4 = Convert.ToInt32(value, 16);
				string text4 = "" + (char)num4;
				text += text4;
				text2 = text2.Substring(num2 + 1, length2 - num2 - 1);
				continue;
			}
			text += text2;
			break;
		}
		return text;
	}

	internal static string ChinaUnicodeToASCII2(string strInput)
	{
		string text = null;
		string text2 = strInput;
		int num = -1;
		int num2 = -1;
		while (true)
		{
			num = text2.IndexOf("&#", 0);
			num2 = text2.IndexOf(";", 0);
			if (num != -1)
			{
				if (num > 0)
				{
					int length = text2.Length;
					string text3 = text2.Substring(0, num);
					text += text3;
					text2 = text2.Substring(num, length - num);
					continue;
				}
				int length2 = text2.Length;
				int num3 = num2 - num - 2;
				if (num3 <= 0)
				{
					break;
				}
				string s = text2.Substring(num + 2, num3);
				int num4 = int.Parse(s);
				string text4 = "" + (char)num4;
				text += text4;
				text2 = text2.Substring(num2 + 1, length2 - num2 - 1);
				continue;
			}
			text += text2;
			break;
		}
		return text;
	}

	internal static string GetStringTime(int iTime)
	{
		string text = null;
		if (iTime < 60)
		{
			return text + iTime + " 分钟";
		}
		int num = iTime / 60;
		int num2 = iTime % 60;
		string text2 = text;
		return text2 + num + " 小时 " + num2 + " 分钟";
	}

	internal static string GetQQNum(string sQQNumNick)
	{
		sQQNumNick = sQQNumNick.Trim();
		string text = sQQNumNick;
		int num = sQQNumNick.IndexOf("[");
		if (num > 0)
		{
			text = sQQNumNick.Substring(0, num - 1);
			text = text.Trim();
		}
		else
		{
			string text2 = "";
			foreach (char c in sQQNumNick)
			{
				if (c >= '0' && c <= '9')
				{
					text2 += c;
					continue;
				}
				return text2.Trim();
			}
		}
		return text.Trim();
	}

	internal static string GetQQNick(string sQQNumNick)
	{
		sQQNumNick = sQQNumNick.Trim();
		string result = "";
		try
		{
			int num = sQQNumNick.IndexOf("[");
			if (num > 0)
			{
				if (sQQNumNick.Length - num - 2 > 0)
				{
					result = sQQNumNick.Substring(num + 1, sQQNumNick.Length - num - 2);
					return result.Trim();
				}
				return result;
			}
			return result;
		}
		catch
		{
			return "";
		}
	}

	internal static long SToLong(string sString)
	{
		if (sString != null && !(sString == "") && !(sString == string.Empty))
		{
			try
			{
				return long.Parse(sString);
			}
			catch
			{
				return 0L;
			}
		}
		return 0L;
	}

	internal static int SToInt(string sString)
	{
		if (sString != null && !(sString == "") && !(sString == string.Empty))
		{
			try
			{
				return int.Parse(sString);
			}
			catch
			{
				return 0;
			}
		}
		return 0;
	}

	internal static string ReplaceAllHtml(string str)
	{
		str = str.Replace("&lt;", "<");
		str = str.Replace("&gt;", ">");
		str = str.Replace("&amp;", "&");
		str = str.Replace("&quot;", "\"");
		str = str.Replace("&reg;", "®");
		str = str.Replace("&copy;", "©");
		str = str.Replace("&trade;", "™");
		str = str.Replace("&ensp;", " ");
		str = str.Replace("&emsp;", " ");
		str = str.Replace("&nbsp;", " ");
		return str;
	}
}
