using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class QueryNormal
{
	private User m_use;

	private DateTime GetRealTime(long sTime)
	{
		DateTime dateTime = new DateTime(2009, 5, 9, 19, 49, 45);
		long num = sTime - 1241869785L;
		return dateTime.AddSeconds(num);
	}

	public QueryNormal(User use)
	{
		m_use = use;
	}

	public string GetSubStringChina(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 3;
				result = down.Substring(num, num2 - num - 4);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringNum(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 2;
				result = down.Substring(num, num2 - num - 3);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringNum3(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 2;
				result = down.Substring(num, num2 - num);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringChina2(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 3;
				result = down.Substring(num, num2 - num - 3);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringChina3(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 2;
				result = down.Substring(num, num2 - num - 3);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringChina4(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num + sStart.Length + 2);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 2;
				result = down.Substring(num, num2 - num - 2);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringChina5(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num + sStart.Length + 2);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 3;
				result = down.Substring(num, num2 - num - 1);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public string GetSubStringNum2(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
	{
		outstartIndex = 0;
		string result = "";
		try
		{
			int num = 0;
			int num2 = 0;
			num = down.IndexOf(sStart, instartIndex);
			if (num == -1)
			{
				return null;
			}
			num2 = down.IndexOf(sEnd, num);
			if (num != -1 && num2 != -1)
			{
				num += sStart.Length + 2;
				result = down.Substring(num, num2 - num - 2);
				outstartIndex = num2;
				return result;
			}
			return null;
		}
		catch
		{
			return result;
		}
	}

	public QQKjInfo ProQueryNormalKongJian(string sQQNum)
	{
		QQKjInfo qQKjInfo = new QQKjInfo();
		string text = m_use.m_hh.Get("http://users.qzone.qq.com/cgi-bin/user/cgi_userinfo_get_all?uin=" + sQQNum, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			int num = 0;
			int outstartIndex = 0;
			string text2 = null;
			text2 = GetSubStringChina(text, "nickname", "sex", 0, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.sQQName = StringChar.ChinaUnicodeToASCII2(text2);
			text2 = GetSubStringNum(text, "sex", "age", num, out outstartIndex);
			num = outstartIndex;
			if (text2 == "1")
			{
				qQKjInfo.sSex = "帅哥";
			}
			else if (text2 == "2")
			{
				qQKjInfo.sSex = "美女";
			}
			else
			{
				qQKjInfo.sSex = "外星人";
			}
			text2 = GetSubStringNum(text, "age", "birthday", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.sAge = text2;
			text2 = GetSubStringChina(text, "birthday", "isfullage", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.sBirthday = text2;
			text2 = GetSubStringNum(text, "bloodtype", "country", num, out outstartIndex);
			num = outstartIndex;
			switch (text2)
			{
			case "0":
				qQKjInfo.sBloodtype = "O型";
				break;
			case "1":
				qQKjInfo.sBloodtype = "A型";
				break;
			case "2":
				qQKjInfo.sBloodtype = "B型";
				break;
			case "3":
				qQKjInfo.sBloodtype = "AB型";
				break;
			default:
				qQKjInfo.sBloodtype = "未知：" + text2;
				break;
			}
			text2 = GetSubStringChina(text, "country", "province", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.scountry = text2;
			text2 = GetSubStringChina(text, "province", "city", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.sprovince = text2;
			text2 = GetSubStringChina(text, "city", "hco", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.scity = text2;
			text2 = GetSubStringChina(text, "hco", "hp", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.shco = text2;
			text2 = GetSubStringChina(text, "hp", "hc", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.shp = text2;
			text2 = GetSubStringChina(text, "hc", "marriage", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.shc = text2;
			text2 = GetSubStringNum(text, "marriage", "spacename", num, out outstartIndex);
			num = outstartIndex;
			switch (text2)
			{
			case "0":
				qQKjInfo.sMarriage = "保密";
				break;
			case "1":
				qQKjInfo.sMarriage = "未婚";
				break;
			case "2":
				qQKjInfo.sMarriage = "结婚";
				break;
			default:
				qQKjInfo.sMarriage = "未知：" + text2;
				break;
			}
			text2 = GetSubStringChina(text, "spacename", "desc", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.sSpacename = StringChar.ChinaUnicodeToASCII2(text2);
			text2 = GetSubStringChina(text, "desc", "signature", num, out outstartIndex);
			num = outstartIndex;
			qQKjInfo.sdesc = StringChar.ChinaUnicodeToASCII2(text2);
			return qQKjInfo;
		}
		return null;
	}

	public QQCsdrInfo ProQueryNormalCity(string sQQNum)
	{
		QQCsdrInfo qQCsdrInfo = new QQCsdrInfo();
		string text = m_use.m_hh.Get("http://cityapi.qzone.qq.com/json.php?mod=profile&act=qzoneprofile&callback=PortalCityProfileCallBack&uin=" + sQQNum, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			int num = 0;
			int outstartIndex = 0;
			string text2 = null;
			text2 = GetSubStringChina2(text, "nickname", "birthday", 0, out outstartIndex);
			if (text2 == null)
			{
				return null;
			}
			num = outstartIndex;
			qQCsdrInfo.sQQName = StringChar.ChinaUnicodeToASCII2(text2);
			text2 = GetSubStringChina2(text, "birthday", "age", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sBirthday = text2;
			text2 = GetSubStringChina2(text, "age", "city", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sAge = text2;
			text2 = GetSubStringChina2(text, "city", "cityCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.scity = text2;
			text2 = GetSubStringChina2(text, "sex", "sexCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sSex = text2;
			text2 = GetSubStringChina2(text, "astro", "astroCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sastro = text2;
			text2 = GetSubStringChina2(text, "bloodType", "bloodTypeCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sastro = text2;
			text2 = GetSubStringChina2(text, "height", "heightCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sheight = text2;
			text2 = GetSubStringChina2(text, "weight", "weightCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sweight = text2;
			text2 = GetSubStringChina2(text, "emotion", "emotionCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.semotion = text2;
			text2 = GetSubStringChina2(text, "education", "educationCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.seducation = text2;
			text2 = GetSubStringChina2(text, "job", "jobCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.sjob = text2;
			text2 = GetSubStringChina2(text, "longent", "longentCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.slongent = text2;
			text2 = GetSubStringChina2(text, "mCity", "mCityCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.smCity = text2;
			text2 = GetSubStringChina2(text, "mAge", "mAgeCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.smAge = text2;
			text2 = GetSubStringChina2(text, "mHeight", "mHeightCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.smHeight = text2;
			text2 = GetSubStringChina2(text, "mWeight", "mWeightCode", num, out outstartIndex);
			num = outstartIndex;
			qQCsdrInfo.smWeight = text2;
			return qQCsdrInfo;
		}
		return null;
	}

	public Collection<QQFwzjInfo> ProQueryFangWenZuJi1(string sQQNum)
	{
		Collection<QQFwzjInfo> collection = new Collection<QQFwzjInfo>();
		string text = m_use.m_hh.Get("http://users.qzone.qq.com/fcg-bin/cgi_access_self.fcg?type=4&uin=" + sQQNum, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				XmlNode documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					return null;
				}
				XmlNodeList xmlNodeList = documentElement.SelectNodes("visitorlist");
				if (xmlNodeList == null)
				{
					return collection;
				}
				for (int i = 0; i < xmlNodeList.Count; i++)
				{
					XmlNode xmlNode = xmlNodeList[i];
					if (xmlNode != null)
					{
						QQFwzjInfo qQFwzjInfo = new QQFwzjInfo();
						XmlNode xmlNode2 = xmlNode.SelectSingleNode("uin");
						if (xmlNode2 != null)
						{
							qQFwzjInfo.sQQNum = xmlNode2.InnerText;
						}
						XmlNode xmlNode3 = xmlNode.SelectSingleNode("spacename");
						if (xmlNode3 != null)
						{
							qQFwzjInfo.sQQName = StringChar.ChinaUnicodeToASCII2(xmlNode3.FirstChild!.Value);
							qQFwzjInfo.sQQName = StringChar.ReplaceAllHtml(qQFwzjInfo.sQQName);
						}
						collection.Add(qQFwzjInfo);
					}
				}
				return collection;
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	public Collection<QQFwzjInfo> ProQueryFangWenZuJi2(string sQQNum)
	{
		Collection<QQFwzjInfo> collection = new Collection<QQFwzjInfo>();
		string text = m_use.m_hh.Get("http://mall2.qzone.qq.com/prop/cgi-bin/cgi_use_prop?propid=2&uin=" + sQQNum, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			try
			{
				int instartIndex = 0;
				int outstartIndex = 0;
				string text2 = null;
				while (true)
				{
					QQFwzjInfo qQFwzjInfo = new QQFwzjInfo();
					text2 = GetSubStringChina3(text, "visiteduin", "nickname", instartIndex, out outstartIndex);
					if (text2 == null)
					{
						return collection;
					}
					if (text2.Length < 4)
					{
						break;
					}
					instartIndex = outstartIndex;
					qQFwzjInfo.sQQNum = text2;
					text2 = GetSubStringChina3(text, "nickname", "spacename", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					qQFwzjInfo.sQQName = StringChar.ChinaUnicodeToASCII2(text2);
					text2 = GetSubStringChina4(text, "spacename", "}", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					qQFwzjInfo.sQQKjName = StringChar.ChinaUnicodeToASCII2(text2);
					collection.Add(qQFwzjInfo);
				}
				return collection;
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	public Collection<QQMusicInfo> ProQueryMusic(string sQQNum)
	{
		Collection<QQMusicInfo> collection = new Collection<QQMusicInfo>();
		string text = m_use.m_hh.Get("http://qzone-music.qq.com/fcg-bin/fcgi_agent_zhenghe.fcg?TYPE=16&UIN=" + sQQNum, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				XmlNode documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					return null;
				}
				XmlNode xmlNode = documentElement.SelectSingleNode("minemusiclist");
				if (xmlNode == null)
				{
					return null;
				}
				XmlNodeList xmlNodeList = xmlNode.SelectNodes("minemusic");
				if (xmlNodeList == null)
				{
					return collection;
				}
				for (int i = 0; i < xmlNodeList.Count; i++)
				{
					XmlNode xmlNode2 = xmlNodeList[i];
					if (xmlNode2 != null)
					{
						QQMusicInfo qQMusicInfo = new QQMusicInfo();
						XmlNode xmlNode3 = xmlNode2.SelectSingleNode("xsinger_name");
						if (xmlNode3 != null)
						{
							qQMusicInfo.sName = StringChar.ChinaUnicodeToASCII2(xmlNode3.FirstChild!.Value);
						}
						XmlNode xmlNode4 = xmlNode2.SelectSingleNode("xsong_name");
						if (xmlNode4 != null)
						{
							qQMusicInfo.sMusicName = StringChar.ChinaUnicodeToASCII2(xmlNode4.FirstChild!.Value);
						}
						XmlNode xmlNode5 = xmlNode2.SelectSingleNode("xsong_url");
						if (xmlNode5 != null)
						{
							qQMusicInfo.sDown = StringChar.ChinaUnicodeToASCII2(xmlNode5.FirstChild!.Value);
						}
						collection.Add(qQMusicInfo);
					}
				}
				return collection;
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	public Collection<QQPhotoInfo> ProQueryPhoto(string sQQNum)
	{
		Collection<QQPhotoInfo> collection = new Collection<QQPhotoInfo>();
		try
		{
			string text = m_use.m_hh.Get("http://route.store.qq.com/GetRoute?UIN=" + sQQNum, Encoding.Default);
			if (text != null && !(text == string.Empty))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				XmlNode documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					return null;
				}
				string text2 = "";
				XmlNode xmlNode = documentElement.SelectSingleNode("p");
				if (xmlNode != null)
				{
					text2 = xmlNode.InnerText;
					string text3 = m_use.m_hh.Get("http://" + text2 + "/" + sQQNum + "/16", Encoding.Default);
					if (text3 != null && !(text3 == string.Empty))
					{
						XmlDocument xmlDocument2 = new XmlDocument();
						xmlDocument2.LoadXml(text3);
						documentElement = xmlDocument2.DocumentElement;
						if (documentElement == null)
						{
							return null;
						}
						XmlNodeList xmlNodeList = documentElement.SelectNodes("album");
						if (xmlNodeList != null)
						{
							for (int i = 0; i < xmlNodeList.Count; i++)
							{
								XmlNode xmlNode2 = xmlNodeList[i];
								if (xmlNode2 == null)
								{
									continue;
								}
								QQPhotoInfo qQPhotoInfo = new QQPhotoInfo();
								XmlNode xmlNode3 = xmlNode2.SelectSingleNode("name");
								if (xmlNode3 != null)
								{
									qQPhotoInfo.sName = StringChar.ChinaUnicodeToASCII2(xmlNode3.FirstChild!.Value);
									qQPhotoInfo.sName = StringChar.ReplaceAllHtml(xmlNode3.FirstChild!.Value);
								}
								XmlNode xmlNode4 = xmlNode2.SelectSingleNode("priv");
								if (xmlNode4 != null)
								{
									if (xmlNode4.InnerText == "1")
									{
										qQPhotoInfo.sShuXing = "公开";
									}
									else
									{
										qQPhotoInfo.sShuXing = "加锁";
									}
								}
								XmlNode xmlNode5 = xmlNode2.SelectSingleNode("total");
								if (xmlNode5 != null)
								{
									qQPhotoInfo.sNum = xmlNode5.InnerText;
								}
								XmlNode xmlNode6 = xmlNode2.SelectSingleNode("pre");
								if (xmlNode6 != null)
								{
									qQPhotoInfo.sHttpUrl = xmlNode6.InnerText;
								}
								XmlNode xmlNode7 = xmlNode2.SelectSingleNode("id");
								if (xmlNode7 != null)
								{
									qQPhotoInfo.sGuid = xmlNode7.InnerText;
								}
								collection.Add(qQPhotoInfo);
							}
							return collection;
						}
						return collection;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public Collection<string> ProQueryPicUrl(string sQQNum, string sGuid)
	{
		Collection<string> collection = new Collection<string>();
		try
		{
			string text = m_use.m_hh.Get("http://route.store.qq.com/GetRoute?UIN=" + sQQNum, Encoding.Default);
			if (text != null && !(text == string.Empty))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				XmlNode documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					return null;
				}
				string text2 = "";
				XmlNode xmlNode = documentElement.SelectSingleNode("s");
				if (xmlNode != null)
				{
					text2 = xmlNode.InnerText;
					string text3 = m_use.m_hh.Get("http://" + text2 + "/http_staload.cgi?" + sQQNum + "/" + sGuid, "http://static.photo.qq.com/proxy.html", Encoding.Default);
					if (text3 != null && !(text3 == string.Empty))
					{
						XmlDocument xmlDocument2 = new XmlDocument();
						xmlDocument2.LoadXml(text3);
						XmlNode documentElement2 = xmlDocument2.DocumentElement;
						if (documentElement2 == null)
						{
							return collection;
						}
						XmlNodeList xmlNodeList = documentElement2.SelectNodes("pic");
						if (xmlNodeList != null)
						{
							for (int i = 0; i < xmlNodeList.Count; i++)
							{
								XmlNode xmlNode2 = xmlNodeList[i];
								if (xmlNode2 != null)
								{
									string item = "";
									XmlNode xmlNode3 = xmlNode2.SelectSingleNode("url");
									if (xmlNode3 != null)
									{
										item = xmlNode3.InnerText;
									}
									collection.Add(item);
								}
							}
							return collection;
						}
						return collection;
					}
					return collection;
				}
				return null;
			}
			return null;
		}
		catch
		{
			return collection;
		}
	}

	public Collection<QQRiZhiInfo> ProQueryRiZhi(string sQQNum)
	{
		Collection<QQRiZhiInfo> collection = new Collection<QQRiZhiInfo>();
		int num = 0;
		try
		{
			while (true)
			{
				string text = m_use.m_hh.Get("http://b.qzone.qq.com/cgi-bin/blognew/blog_get_titlelist?direct=1&numperpage=100&uin=" + sQQNum + "&pos=" + num * 100, Encoding.Default);
				if (text != null && !(text == string.Empty))
				{
					int instartIndex = 0;
					int outstartIndex = 0;
					string text2 = null;
					int num2 = 0;
					while (true)
					{
						QQRiZhiInfo qQRiZhiInfo = new QQRiZhiInfo();
						text2 = GetSubStringNum(text, "blogid", "pubtime", instartIndex, out outstartIndex);
						if (text2 == null || text2 == "")
						{
							break;
						}
						instartIndex = outstartIndex;
						qQRiZhiInfo.sblogid = text2;
						text2 = GetSubStringNum(text, "pubtime", "replytime", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						qQRiZhiInfo.sFaBiaoTime = GetRealTime(StringChar.SToLong(text2)).ToString("yyyy-MM-dd HH:mm:ss");
						text2 = GetSubStringNum(text, "replynum", "effect", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						qQRiZhiInfo.sPingLun = text2;
						text2 = GetSubStringChina(text, "category", "title", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						qQRiZhiInfo.sFenLei = text2;
						text2 = GetSubStringChina5(text, "title", "}", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						qQRiZhiInfo.sTitle = StringChar.ReplaceAllHtml(text2);
						collection.Add(qQRiZhiInfo);
						num2++;
					}
					if (num2 >= 100)
					{
						num++;
						continue;
					}
					break;
				}
				return null;
			}
			return collection;
		}
		catch
		{
			return null;
		}
	}

	public string ProQueryLiuLanNum(string sQQNum, string sblogid)
	{
		string result = "";
		string text = m_use.m_hh.Get("http://b.qzone.qq.com/cgi-bin/blognew/blog_get_countlist?type=1&uin=" + sQQNum + "&blogids=" + sblogid, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			try
			{
				int outstartIndex = 0;
				string text2 = null;
				text2 = GetSubStringNum3(text, "read", "}", 0, out outstartIndex);
				result = text2;
				return result;
			}
			catch
			{
				return result;
			}
		}
		return result;
	}

	public void ProQueryZengJiaLiuLan(string sQQNum, string sblogid)
	{
		m_use.m_hh.Get("http://b.qzone.qq.com/cgi-bin/blognew/blog_get_data?direct=1&uin=" + sQQNum + "&blogid=" + sblogid, Encoding.Default);
	}

	public string ProQueryReadRz(string sQQNum, string sblogid)
	{
		string text = m_use.m_hh.Get("http://b.qzone.qq.com/cgi-bin/blognew/blog_get_data?direct=1&uin=" + sQQNum + "&blogid=" + sblogid, Encoding.Default);
		text = m_use.m_hh.Get("http://b.qzone.qq.com/cgi-bin/blognew/blog_output_data?uin=" + sQQNum + "&blogid=" + sblogid, Encoding.Default);
		int num = 0;
		string value = "id=\"paperPicArea\" style=\"display:none\" src=\"";
		string value2 = "<div";
		string value3 = "<!--v:3.2-->";
		int num2 = text.IndexOf(value, 0);
		num = num2;
		if (num2 != -1)
		{
			num2 = text.IndexOf(value2, num);
			if (num2 != -1)
			{
				int num3 = text.IndexOf(value3, num2);
				if (num3 != -1)
				{
					num = num3;
					string text2 = text.Substring(num2, num3 - num2 - 1);
					text = text2;
				}
			}
		}
		return text.Replace("src=\"/", "src=\"http://imgcache.qq.com/");
	}

	public void ProQQZoneSendContent(string sQQNum, string sblogid, string content)
	{
		m_use.m_hh.Post("http://b.qzone.qq.com/cgi-bin/blognew/blog_add_comment", "cb_autograph=1&property=GoRE&blogid=" + sblogid + "&uin=" + sQQNum + "&content=" + content);
	}

	public Collection<QQCityInfo> ProQueryCity(string province, string city, string sSex, string sAge, string page)
	{
		Collection<QQCityInfo> collection = new Collection<QQCityInfo>();
		string text = m_use.m_hh.Get("http://city.qzone.qq.com/json.php?mod=search&act=page&province=" + province + "&city=" + city + "&age=" + sAge + "&sex=" + sSex + "&page=" + page, Encoding.Default);
		if (text != null && !(text == string.Empty))
		{
			try
			{
				int instartIndex = 0;
				int outstartIndex = 0;
				string text2 = null;
				while (true)
				{
					QQCityInfo qQCityInfo = new QQCityInfo();
					text2 = GetSubStringChina2(text, "uin", "online", instartIndex, out outstartIndex);
					if (text2 == null)
					{
						break;
					}
					if (text2.Length < 4)
					{
						return collection;
					}
					instartIndex = outstartIndex;
					qQCityInfo.sQQNum = text2;
					text2 = GetSubStringChina2(text, "online", "birthday", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					qQCityInfo.sOnline = text2;
					text2 = GetSubStringChina2(text, "birthday", "nickname", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					qQCityInfo.sBirthday = text2;
					int num = text.IndexOf("city\\/", instartIndex);
					if (num == -1)
					{
						return null;
					}
					int num2 = text.IndexOf("\\/", num + 10);
					if (num == -1 || num2 == -1)
					{
						return null;
					}
					num += 6;
					text2 = text.Substring(num, num2 - num);
					instartIndex = num2;
					qQCityInfo.sID = text2;
					text2 = GetSubStringChina2(text, "sex", "yellow", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					if (text2 == "1")
					{
						qQCityInfo.sSex = "男";
					}
					else if (text2 == "0")
					{
						qQCityInfo.sSex = "女";
					}
					else
					{
						qQCityInfo.sSex = "外星人";
					}
					text2 = GetSubStringChina2(text, "emotion", "home", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					switch (text2)
					{
					case "0":
						qQCityInfo.semotion = "保密";
						break;
					case "1":
						qQCityInfo.semotion = "单身中";
						break;
					case "2":
						qQCityInfo.semotion = "恋爱中";
						break;
					case "3":
						qQCityInfo.semotion = "结婚了";
						break;
					default:
						qQCityInfo.semotion = "未知：" + text2;
						break;
					}
					text2 = GetSubStringChina2(text, "weight", "height", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					switch (text2)
					{
					case "0":
						qQCityInfo.smWeight = "";
						break;
					case "1":
						qQCityInfo.smWeight = "40kg以下";
						break;
					case "2":
						qQCityInfo.smWeight = "40-45kg";
						break;
					case "3":
						qQCityInfo.smWeight = "45-50kg";
						break;
					case "4":
						qQCityInfo.smWeight = "50-55kg";
						break;
					case "5":
						qQCityInfo.smWeight = "55-60kg";
						break;
					case "6":
						qQCityInfo.smWeight = "60-65kg";
						break;
					case "7":
						qQCityInfo.smWeight = "65-70kg";
						break;
					case "8":
						qQCityInfo.smWeight = "70-80kg";
						break;
					case "9":
						qQCityInfo.smWeight = "80kg以上";
						break;
					default:
						qQCityInfo.smWeight = "未知：" + text2;
						break;
					}
					text2 = GetSubStringChina2(text, "height", "albumID", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					if (text2 != "0")
					{
						qQCityInfo.smHeight = text2;
					}
					collection.Add(qQCityInfo);
				}
				return collection;
			}
			catch
			{
				return null;
			}
		}
		return null;
	}
}
