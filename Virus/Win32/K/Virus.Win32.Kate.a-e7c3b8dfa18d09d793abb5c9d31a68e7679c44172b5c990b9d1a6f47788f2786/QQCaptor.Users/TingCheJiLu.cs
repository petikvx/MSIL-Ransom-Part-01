using System.Text.RegularExpressions;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class TingCheJiLu
{
	private User m_use;

	public TingCheJiLu(User use)
	{
		m_use = use;
	}

	public string DeleteHtml(string html)
	{
		Regex regex = new Regex("<script[sS]+</script *>", RegexOptions.IgnoreCase);
		Regex regex2 = new Regex(" href *= *[sS]*script *:", RegexOptions.IgnoreCase);
		Regex regex3 = new Regex(" no[sS]*=", RegexOptions.IgnoreCase);
		Regex regex4 = new Regex("<iframe[sS]+</iframe *>", RegexOptions.IgnoreCase);
		Regex regex5 = new Regex("<frameset[sS]+</frameset *>", RegexOptions.IgnoreCase);
		Regex regex6 = new Regex("<img[^>]+>", RegexOptions.IgnoreCase);
		Regex regex7 = new Regex("</p>", RegexOptions.IgnoreCase);
		Regex regex8 = new Regex("<p>", RegexOptions.IgnoreCase);
		Regex regex9 = new Regex("<[^>]*>", RegexOptions.IgnoreCase);
		html = regex.Replace(html, "");
		html = regex2.Replace(html, "");
		html = regex3.Replace(html, " _disibledevent=");
		html = regex4.Replace(html, "");
		html = regex5.Replace(html, "");
		html = regex6.Replace(html, "");
		html = regex7.Replace(html, "");
		html = regex8.Replace(html, "");
		html = regex9.Replace(html, "");
		html = html.Replace(" ", "");
		html = html.Replace("</strong>", "");
		html = html.Replace("<strong>", "");
		return html;
	}

	public string WoCheZiJinKuang()
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_dynamic", "type=1&opuin=undefined");
		if (text2 != null && !(text2 == string.Empty))
		{
			int num = 0;
			int num2 = 0;
			num = text2.IndexOf("<content>", 0);
			if (num == -1)
			{
				return null;
			}
			num2 = text2.IndexOf("</content>", num);
			if (num != -1 && num2 != -1)
			{
				num += 9;
				string strInput = text2.Substring(num, num2 - num);
				text = StringChar.ChinaUnicodeToASCII(strInput);
				text = text.Replace("<p>", "<p>\r\n\r\n");
				return DeleteHtml(text);
			}
			return null;
		}
		return null;
	}

	public string WoCheWeiJinKuang()
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_dynamic", "type=2&opuin=undefined");
		if (text2 != null && !(text2 == string.Empty))
		{
			int num = 0;
			int num2 = 0;
			num = text2.IndexOf("<content>", 0);
			if (num == -1)
			{
				return null;
			}
			num2 = text2.IndexOf("</content>", num);
			if (num != -1 && num2 != -1)
			{
				num += 9;
				string strInput = text2.Substring(num, num2 - num);
				text = StringChar.ChinaUnicodeToASCII(strInput);
				text = text.Replace("<p>", "<p>\r\n\r\n");
				return DeleteHtml(text);
			}
			return null;
		}
		return null;
	}

	public string ChaKanHaoYouTingCheXin(string QQNum)
	{
		string text = null;
		string text2 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_dynamic", "type=0&opuin=" + QQNum);
		if (text2 != null && !(text2 == string.Empty))
		{
			int num = 0;
			int num2 = 0;
			num = text2.IndexOf("<content>", 0);
			if (num == -1)
			{
				return null;
			}
			num2 = text2.IndexOf("</content>", num);
			if (num != -1 && num2 != -1)
			{
				num += 9;
				string strInput = text2.Substring(num, num2 - num);
				text = StringChar.ChinaUnicodeToASCII(strInput);
				text = text.Replace("<p>", "<p>\r\n\r\n");
				return DeleteHtml(text);
			}
			return null;
		}
		return null;
	}
}
