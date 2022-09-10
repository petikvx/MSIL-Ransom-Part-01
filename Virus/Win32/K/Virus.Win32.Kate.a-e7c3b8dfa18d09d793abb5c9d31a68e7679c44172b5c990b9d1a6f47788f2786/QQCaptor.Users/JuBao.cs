using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class JuBao
{
	private User m_use;

	public JuBao(User use)
	{
		m_use = use;
	}

	public string ProJuBao(string sQQnum, string strParkQQ, string parkno, string carid)
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_report", "opuin=" + sQQnum + "&cmd=103&uin=" + strParkQQ + "&carid=" + carid + "&parkno=" + parkno);
		if (text2 != null && !(text2 == string.Empty))
		{
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
					if (text == null || text == string.Empty || text == "")
					{
						text = "未知错误：Code = " + text3.ToString();
					}
				}
				return text;
			}
			return text;
		}
		return "发送举报命令无效";
	}
}
