using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class BuyCars
{
	private User m_use;

	public BuyCars(User use)
	{
		m_use = use;
	}

	public string ProChangeCars(string strCarCode, string carcolor, string carid)
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_newcar", "cmd=107&carno=" + strCarCode + "&carcolor=" + carcolor + "&carid=" + carid);
		string text3 = null;
		int num = 0;
		int num2 = text2.IndexOf(" code=", 0);
		if (num2 == -1)
		{
			return text;
		}
		int num3 = text2.IndexOf(" message=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 7;
			num = num3;
			string text4 = text2.Substring(num2, num3 - num2 - 1);
			text3 = text4;
			if (text3 != "0")
			{
				new StringChar();
				num2 = text2.IndexOf(" message=", num);
				if (num2 == -1)
				{
					return text;
				}
				num3 = text2.IndexOf(">", num2);
				if (num2 == -1 || num3 == -1)
				{
					return text;
				}
				num2 += 10;
				num = num3;
				text4 = text2.Substring(num2, num3 - num2 - 1);
				text = StringChar.ChinaUnicodeToASCII(text4);
				if (text == "" || text == null)
				{
					text = "你还没有登陆吧，大哥";
				}
			}
			return text;
		}
		return text;
	}

	public string ProChangeCarsJB(string strCarCode, string carcolor, string carid)
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_newcar", "cmd=107&carno=" + strCarCode + "&carcolor=" + carcolor + "&carid=" + carid);
		string text3 = null;
		int num = 0;
		int num2 = text2.IndexOf(" code=", 0);
		if (num2 == -1)
		{
			return text;
		}
		int num3 = text2.IndexOf(" message=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 7;
			num = num3;
			string text4 = text2.Substring(num2, num3 - num2 - 1);
			text3 = text4;
			if (text3 != "0")
			{
				new StringChar();
				num2 = text2.IndexOf(" message=", num);
				if (num2 == -1)
				{
					return text;
				}
				num3 = text2.IndexOf(">", num2);
				if (num2 == -1 || num3 == -1)
				{
					return text;
				}
				num2 += 10;
				num = num3;
				text4 = text2.Substring(num2, num3 - num2 - 1);
				text = StringChar.ChinaUnicodeToASCII(text4);
				if (text == "" || text == null)
				{
					text = "你还没有登陆吧，大哥";
				}
			}
			return text;
		}
		return text;
	}

	public string ProBuyCars(string strCarCode, string carcolor)
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_newcar", "cmd=105&carno=" + strCarCode + "&carcolor=" + carcolor);
		string text3 = null;
		int num = 0;
		int num2 = text2.IndexOf(" code=", 0);
		if (num2 == -1)
		{
			return text;
		}
		int num3 = text2.IndexOf(" message=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 7;
			num = num3;
			string text4 = text2.Substring(num2, num3 - num2 - 1);
			text3 = text4;
			if (text3 != "0")
			{
				new StringChar();
				num2 = text2.IndexOf(" message=", num);
				if (num2 == -1)
				{
					return text;
				}
				num3 = text2.IndexOf(">", num2);
				if (num2 == -1 || num3 == -1)
				{
					return text;
				}
				num2 += 10;
				num = num3;
				text4 = text2.Substring(num2, num3 - num2 - 1);
				text = StringChar.ChinaUnicodeToASCII(text4);
				if (text == "" || text == null)
				{
					text = "你还没有登陆吧，大哥";
				}
			}
			return text;
		}
		return text;
	}
}
