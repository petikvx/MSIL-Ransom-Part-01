using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class QueryQQ
{
	private DateTime m_nowxx;

	private HaoYouMaiMaiType ht = new HaoYouMaiMaiType();

	private string strReplace = "abcxyz";

	private User m_use;

	private FriendBuyInfo m_fb1;

	private FriendBuyInfo m_fb2;

	public Collection<SlaveInfo> m_SlaveList = new Collection<SlaveInfo>();

	public Collection<SlaveInfo> m_SlaveListDS = new Collection<SlaveInfo>();

	public QueryQQ(User use)
	{
		m_use = use;
	}

	public string GetSubStringChinaXX(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
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

	public string ProPK(string uin, string myslave, string beslave, string bemaster)
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_pkaction", "uin=" + uin + "&myslave=" + myslave + "&beslave=" + beslave + "&bemaster=" + bemaster + "&optype=done");
		if (text != null && !(text == string.Empty))
		{
			string text2 = "";
			int instartIndex = 0;
			int outstartIndex = 0;
			string text3 = null;
			try
			{
				if (text.IndexOf("\"code\":0") == -1)
				{
					text3 = GetSubStringChinaXX(text, "\"nick\"", "slave_n", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					if (text3 == null && text2.Length <= 1)
					{
						text3 = GetSubStringNum(text, "code", ",", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						if (text3 == null && text3.Length <= 0)
						{
							return "PK发生位置错误e";
						}
						switch (text3)
						{
						case "-94":
							return "你的奴隶今天已经PK过 1 次了";
						case "-93":
							return "对方的奴隶今天已经被PK过 2 次了";
						case "-87":
							return "你当前的现金不够悬赏";
						default:
							return "这2个奴隶不满足PK条件";
						case "-3":
						case "-92":
							return "这2个奴隶不能PK";
						}
					}
					return text3;
				}
				string text4 = "";
				string text5 = "";
				text3 = GetSubStringNum(text, "pkm_my", ",", instartIndex, out outstartIndex);
				instartIndex = outstartIndex;
				if (text3 != null || text2.Length > 1)
				{
					text4 = text3;
				}
				text3 = GetSubStringNum(text, "pkr", ",", instartIndex, out outstartIndex);
				instartIndex = outstartIndex;
				if (text3 != null || text2.Length > 1)
				{
					text5 = text3;
				}
				text4 = text4.Replace("-", "");
				if (text5 == "1")
				{
					return "PK胜利，赚取 " + text4 + "金";
				}
				if (text5 == "0")
				{
					return "PK失败，损失 " + text4 + "金";
				}
				return "PK发生位置错误s";
			}
			catch
			{
				return "PK发生异常";
			}
		}
		return null;
	}

	public string QueryQQPkFriend(string sQueryQQNum)
	{
		m_SlaveList.Clear();
		int instartIndex = 0;
		int outstartIndex = 0;
		string text = null;
		string result = "读取好友买卖数据错误，请重新刷新获取";
		string text2 = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_pkfriendslist?otype=json&uin=" + sQueryQQNum, null);
		try
		{
			if (text2 != null && text2.IndexOf("\"code\":0") == -1)
			{
				text = GetSubStringChinaXX(text2, "\"msg\"", "now", instartIndex, out outstartIndex);
				instartIndex = outstartIndex;
				if (text != null || text.Length >= 1)
				{
					result = text;
				}
				return result;
			}
			while (true)
			{
				SlaveInfo slaveInfo = new SlaveInfo();
				text = GetSubStringChinaXX(text2, "\"nick\"", "slave_n", instartIndex, out outstartIndex);
				instartIndex = outstartIndex;
				if (text != null && text.Length >= 1)
				{
					text = StringChar.ReplaceAllHtml(text);
					slaveInfo.sQQName = StringChar.ChinaUnicodeToASCII2(text);
					text = GetSubStringNum(text2, "slave_n", ",", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					if (text != null && text.Length >= 1)
					{
						slaveInfo.sHelot = text;
						text = GetSubStringNum(text2, "uin", "}", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						if (text != null && text.Length >= 1)
						{
							slaveInfo.sQQNum = text;
							m_SlaveList.Add(slaveInfo);
							continue;
						}
						break;
					}
					break;
				}
				break;
			}
		}
		catch
		{
			return null;
		}
		return null;
	}

	public string QueryQQMyPk(string sQueryQQNum)
	{
		m_SlaveList.Clear();
		int instartIndex = 0;
		int outstartIndex = 0;
		string text = null;
		string result = "读取好友买卖数据错误，请重新刷新获取";
		string text2 = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_pkslavelist?otype=json&uin=" + sQueryQQNum, null);
		try
		{
			if (text2 != null && text2.IndexOf("\"code\":0") == -1)
			{
				text = GetSubStringChinaXX(text2, "\"msg\"", "now", instartIndex, out outstartIndex);
				instartIndex = outstartIndex;
				if (text != null || text.Length >= 1)
				{
					result = text;
				}
				return result;
			}
			while (true)
			{
				SlaveInfo slaveInfo = new SlaveInfo();
				text = GetSubStringNum(text2, "exp", ",", instartIndex, out outstartIndex);
				instartIndex = outstartIndex;
				if (text != null && text.Length >= 1)
				{
					slaveInfo.sExp = text;
					text = GetSubStringNum(text2, "fail", ",", instartIndex, out outstartIndex);
					instartIndex = outstartIndex;
					if (text != null && text.Length >= 1)
					{
						slaveInfo.sFail = text;
						text = GetSubStringChinaXX(text2, "\"nick\"", "nickname", instartIndex, out outstartIndex);
						instartIndex = outstartIndex;
						if (text != null && text.Length >= 1)
						{
							slaveInfo.sQQName = text;
							text = GetSubStringNum(text2, "price", ",", instartIndex, out outstartIndex);
							instartIndex = outstartIndex;
							if (text != null && text.Length >= 1)
							{
								slaveInfo.sBuyMoney = text;
								text = GetSubStringNum(text2, "uin", ",", instartIndex, out outstartIndex);
								instartIndex = outstartIndex;
								if (text != null && text.Length >= 1)
								{
									slaveInfo.sQQNum = text;
									text = GetSubStringNum(text2, "win", "}", instartIndex, out outstartIndex);
									instartIndex = outstartIndex;
									if (text != null && text.Length >= 1)
									{
										slaveInfo.sWin = text;
										m_SlaveList.Add(slaveInfo);
										continue;
									}
									break;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				break;
			}
		}
		catch
		{
			return null;
		}
		return null;
	}

	public void QueryQQFriendPrice(string sQueryQQNum, out string sNick, out string sPrice)
	{
		sPrice = "";
		sNick = "";
		string text = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=xml&allinfo=1&uin=" + sQueryQQNum, null);
		m_nowxx = DateTime.Now;
		if (text != null && text.IndexOf("<root>") == -1)
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		text = text.Replace("<", "<" + strReplace);
		text = text.Replace("<" + strReplace + "?", "<?");
		text = text.Replace("<" + strReplace + "/", "</" + strReplace);
		xmlDocument.LoadXml(text);
		XmlNode documentElement = xmlDocument.DocumentElement;
		if (documentElement == null)
		{
			return;
		}
		m_fb1 = null;
		XmlNode xmlNode = documentElement.SelectSingleNode(strReplace + "owner");
		if (xmlNode == null)
		{
			return;
		}
		XmlNode xmlNode2 = xmlNode.SelectSingleNode(strReplace + "price");
		if (xmlNode2 != null)
		{
			sPrice = xmlNode2.InnerText;
			XmlNode xmlNode3 = xmlNode.SelectSingleNode(strReplace + "name");
			if (xmlNode3 != null)
			{
				sNick = xmlNode3.InnerText;
			}
		}
	}

	public string QueryQQBuyFriendForBuy(string sQueryQQNum)
	{
		m_SlaveList.Clear();
		string text = "读取好友买卖数据错误，请重新刷新获取";
		string text2 = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=xml&allinfo=1&uin=" + sQueryQQNum, null);
		m_nowxx = DateTime.Now;
		if (text2 != null && text2.IndexOf("<root>") == -1)
		{
			return "读取好友买卖数据错误：缺少根元素Root，请重新刷新获取" + text;
		}
		XmlDocument xmlDocument = new XmlDocument();
		text2 = text2.Replace("<", "<" + strReplace);
		text2 = text2.Replace("<" + strReplace + "?", "<?");
		text2 = text2.Replace("<" + strReplace + "/", "</" + strReplace);
		xmlDocument.LoadXml(text2);
		XmlNode documentElement = xmlDocument.DocumentElement;
		if (documentElement == null)
		{
			return text;
		}
		m_fb1 = null;
		XmlNode xmlNode = documentElement.SelectSingleNode(strReplace + "owner");
		if (xmlNode == null)
		{
			return text;
		}
		long iNowTime = 0L;
		XmlNode xmlNode2 = documentElement.SelectSingleNode(strReplace + "result");
		if (xmlNode2 != null)
		{
			iNowTime = StringChar.SToLong(xmlNode2.InnerText);
		}
		if (!ReadXml(xmlNode, iNowTime, out m_fb1))
		{
			return text;
		}
		m_fb2 = null;
		XmlNode xmlNode3 = documentElement.SelectSingleNode(strReplace + "master");
		if (xmlNode3 != null)
		{
			ReadXml(xmlNode3, iNowTime, out m_fb2);
		}
		return null;
	}

	public int GetSlaveCount(string sQueryQQNum)
	{
		string text = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=xml&allinfo=1&uin=" + sQueryQQNum, null);
		m_nowxx = DateTime.Now;
		if (text != null && text.IndexOf("<root>") == -1)
		{
			return -1;
		}
		XmlDocument xmlDocument = new XmlDocument();
		text = text.Replace("<", "<" + strReplace);
		text = text.Replace("<" + strReplace + "?", "<?");
		text = text.Replace("<" + strReplace + "/", "</" + strReplace);
		xmlDocument.LoadXml(text);
		XmlNode documentElement = xmlDocument.DocumentElement;
		if (documentElement == null)
		{
			return -1;
		}
		return documentElement.SelectNodes(strReplace + "slaves")?.Count ?? 0;
	}

	public string QueryQQSlave(string sQueryQQNum)
	{
		m_use.LingQuJiangJin();
		m_SlaveList.Clear();
		string text = "读取好友买卖数据错误，请重新刷新获取";
		string text2 = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=xml&allinfo=1&uin=" + sQueryQQNum, null);
		m_nowxx = DateTime.Now;
		if (text2 != null && text2.IndexOf("<root>") == -1)
		{
			return "读取好友买卖数据错误：缺少根元素Root，请重新刷新获取" + text;
		}
		XmlDocument xmlDocument = new XmlDocument();
		text2 = text2.Replace("<", "<" + strReplace);
		text2 = text2.Replace("<" + strReplace + "?", "<?");
		text2 = text2.Replace("<" + strReplace + "/", "</" + strReplace);
		xmlDocument.LoadXml(text2);
		XmlNode documentElement = xmlDocument.DocumentElement;
		if (documentElement == null)
		{
			return text;
		}
		long iNowTime = 0L;
		XmlNode xmlNode = documentElement.SelectSingleNode(strReplace + "result");
		if (xmlNode == null)
		{
			return "当前时间读取错误";
		}
		XmlNode xmlNode2 = xmlNode.SelectSingleNode(strReplace + "now");
		if (xmlNode2 != null)
		{
			iNowTime = StringChar.SToLong(xmlNode2.InnerText);
		}
		SlaveInfo si = null;
		XmlNodeList xmlNodeList = documentElement.SelectNodes(strReplace + "slaves");
		if (xmlNodeList != null)
		{
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				XmlNode xmlNode3 = xmlNodeList[i];
				if (xmlNode3 != null && ReadSlaveXml(xmlNode3, iNowTime, out si))
				{
					m_SlaveList.Add(si);
				}
			}
		}
		return null;
	}

	public string QueryQQBuyFriend(string sQueryQQNum)
	{
		m_use.LingQuJiangJin();
		m_SlaveList.Clear();
		string text = "读取好友买卖数据错误，请重新刷新获取";
		string text2 = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=xml&allinfo=1&uin=" + sQueryQQNum, null);
		m_nowxx = DateTime.Now;
		if (text2 != null && text2.IndexOf("<root>") == -1)
		{
			return "读取好友买卖数据错误：缺少根元素Root，请重新刷新获取" + text;
		}
		XmlDocument xmlDocument = new XmlDocument();
		text2 = text2.Replace("<", "<" + strReplace);
		text2 = text2.Replace("<" + strReplace + "?", "<?");
		text2 = text2.Replace("<" + strReplace + "/", "</" + strReplace);
		xmlDocument.LoadXml(text2);
		XmlNode documentElement = xmlDocument.DocumentElement;
		if (documentElement == null)
		{
			return text;
		}
		m_fb1 = null;
		XmlNode xmlNode = documentElement.SelectSingleNode(strReplace + "owner");
		if (xmlNode == null)
		{
			return text;
		}
		long iNowTime = 0L;
		XmlNode xmlNode2 = documentElement.SelectSingleNode(strReplace + "result");
		if (xmlNode2 == null)
		{
			return "当前时间读取错误";
		}
		XmlNode xmlNode3 = xmlNode2.SelectSingleNode(strReplace + "now");
		if (xmlNode3 != null)
		{
			iNowTime = StringChar.SToLong(xmlNode3.InnerText);
		}
		if (!ReadXml(xmlNode, iNowTime, out m_fb1))
		{
			return text;
		}
		m_fb2 = null;
		XmlNode xmlNode4 = documentElement.SelectSingleNode(strReplace + "master");
		if (xmlNode4 != null)
		{
			ReadXml(xmlNode4, iNowTime, out m_fb2);
		}
		SlaveInfo si = null;
		XmlNodeList xmlNodeList = documentElement.SelectNodes(strReplace + "slaves");
		if (xmlNodeList != null)
		{
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				XmlNode xmlNode5 = xmlNodeList[i];
				if (xmlNode5 != null && ReadSlaveXml(xmlNode5, iNowTime, out si))
				{
					m_SlaveList.Add(si);
				}
			}
		}
		return null;
	}

	public bool ReadXml(XmlNode node, long iNowTime, out FriendBuyInfo fb)
	{
		fb = new FriendBuyInfo();
		XmlNode xmlNode = node.SelectSingleNode(strReplace + "assets");
		if (xmlNode == null)
		{
			return false;
		}
		fb.sCapital = xmlNode.InnerText;
		XmlNode xmlNode2 = node.SelectSingleNode(strReplace + "cash");
		if (xmlNode2 == null)
		{
			return false;
		}
		fb.sMoney = xmlNode2.InnerText;
		XmlNode xmlNode3 = node.SelectSingleNode(strReplace + "name");
		if (xmlNode3 == null)
		{
			return false;
		}
		fb.sQQName = xmlNode3.InnerText;
		XmlNode xmlNode4 = node.SelectSingleNode(strReplace + "exp");
		if (xmlNode4 == null)
		{
			return false;
		}
		fb.sExp = xmlNode4.InnerText;
		XmlNode xmlNode5 = node.SelectSingleNode(strReplace + "nick");
		if (xmlNode5 == null)
		{
			return false;
		}
		fb.sCuohao = StringChar.ReplaceAllHtml(xmlNode5.InnerText);
		XmlNode xmlNode6 = node.SelectSingleNode(strReplace + "price");
		if (xmlNode6 == null)
		{
			return false;
		}
		fb.sBuyMoney = xmlNode6.InnerText;
		XmlNode xmlNode7 = node.SelectSingleNode(strReplace + "slaves");
		if (xmlNode7 == null)
		{
			return false;
		}
		fb.sHelot = xmlNode7.InnerText;
		XmlNode xmlNode8 = node.SelectSingleNode(strReplace + "buys");
		if (xmlNode8 == null)
		{
			return false;
		}
		fb.sBuyNum = xmlNode8.InnerText;
		XmlNode xmlNode9 = node.SelectSingleNode(strReplace + "uin");
		if (xmlNode9 == null)
		{
			return false;
		}
		fb.sQQNum = xmlNode9.InnerText.Trim();
		XmlNode xmlNode10 = node.SelectSingleNode(strReplace + "sex");
		if (xmlNode10 == null)
		{
			return false;
		}
		if (xmlNode10.InnerText == "1")
		{
			fb.sSex = "帅哥";
		}
		else if (xmlNode10.InnerText == "2")
		{
			fb.sSex = "美女";
		}
		else
		{
			fb.sSex = "外星人";
		}
		XmlNode xmlNode11 = node.SelectSingleNode(strReplace + "state");
		if (xmlNode11 == null)
		{
			return false;
		}
		XmlNode xmlNode12 = xmlNode11.SelectSingleNode(strReplace + "locktime");
		if (xmlNode12 != null && !(xmlNode12.InnerText == "0"))
		{
			fb.sStartTime = xmlNode12.InnerText;
			DateTime realTime = GetRealTime(iNowTime, StringChar.SToLong(fb.sStartTime));
			fb.sStartTime = realTime.ToString("yyyy-MM-dd HH:mm:ss");
			XmlNode xmlNode13 = xmlNode11.SelectSingleNode(strReplace + "locktype");
			if (xmlNode13 == null)
			{
				return false;
			}
			fb.sState = ht.GetState(xmlNode13.InnerText);
			XmlNode xmlNode14 = xmlNode11.SelectSingleNode(strReplace + "unlocktime");
			if (xmlNode14 == null)
			{
				return false;
			}
			realTime = realTime.AddHours(StringChar.SToLong(xmlNode14.InnerText));
			fb.sEndTime = realTime.ToString("yyyy-MM-dd HH:mm:ss");
			fb.dEndTime = realTime;
			return true;
		}
		return true;
	}

	public bool ReadSlaveXml(XmlNode node, long iNowTime, out SlaveInfo si)
	{
		si = new SlaveInfo();
		XmlNode xmlNode = node.SelectSingleNode(strReplace + "uin");
		if (xmlNode == null)
		{
			return false;
		}
		si.sQQNum = xmlNode.InnerText.Trim();
		XmlNode xmlNode2 = node.SelectSingleNode(strReplace + "name");
		if (xmlNode2 == null)
		{
			return false;
		}
		si.sQQName = xmlNode2.InnerText;
		XmlNode xmlNode3 = node.SelectSingleNode(strReplace + "exp");
		if (xmlNode3 == null)
		{
			return false;
		}
		si.sExp = xmlNode3.InnerText;
		XmlNode xmlNode4 = node.SelectSingleNode(strReplace + "nick");
		if (xmlNode4 == null)
		{
			return false;
		}
		si.sCuohao = StringChar.ReplaceAllHtml(xmlNode4.InnerText);
		XmlNode xmlNode5 = node.SelectSingleNode(strReplace + "price");
		if (xmlNode5 == null)
		{
			return false;
		}
		si.sBuyMoney = xmlNode5.InnerText;
		XmlNode xmlNode6 = node.SelectSingleNode(strReplace + "assets");
		if (xmlNode6 == null)
		{
			return false;
		}
		si.sCapital = xmlNode6.InnerText;
		XmlNode xmlNode7 = node.SelectSingleNode(strReplace + "cash");
		if (xmlNode7 == null)
		{
			return false;
		}
		si.sMoney = xmlNode7.InnerText;
		XmlNode xmlNode8 = node.SelectSingleNode(strReplace + "slaves");
		if (xmlNode8 == null)
		{
			return false;
		}
		si.sHelot = xmlNode8.InnerText;
		XmlNode xmlNode9 = node.SelectSingleNode(strReplace + "buys");
		if (xmlNode9 == null)
		{
			return false;
		}
		si.sBuyNum = xmlNode9.InnerText;
		XmlNode xmlNode10 = node.SelectSingleNode(strReplace + "sale_cost");
		if (xmlNode10 == null)
		{
			return false;
		}
		si.sBuyPrice = xmlNode10.InnerText;
		XmlNode xmlNode11 = node.SelectSingleNode(strReplace + "sale_time");
		if (xmlNode11 == null)
		{
			return false;
		}
		si.sBuyTime = xmlNode11.InnerText;
		DateTime realTime = GetRealTime(iNowTime, StringChar.SToLong(si.sBuyTime));
		si.sBuyTime = realTime.ToString("yyyy-MM-dd HH:mm:ss");
		si.dBuyTime = realTime;
		XmlNode xmlNode12 = node.SelectSingleNode(strReplace + "state");
		if (xmlNode12 == null)
		{
			return false;
		}
		XmlNode xmlNode13 = xmlNode12.SelectSingleNode(strReplace + "locktime");
		if (xmlNode13 != null && !(xmlNode13.InnerText == "0"))
		{
			si.sStartTime = xmlNode13.InnerText;
			realTime = GetRealTime(iNowTime, StringChar.SToLong(si.sStartTime));
			si.sStartTime = realTime.ToString("yyyy-MM-dd HH:mm:ss");
			XmlNode xmlNode14 = xmlNode12.SelectSingleNode(strReplace + "locktype");
			if (xmlNode14 == null)
			{
				return false;
			}
			si.sState = ht.GetState(xmlNode14.InnerText);
			XmlNode xmlNode15 = xmlNode12.SelectSingleNode(strReplace + "unlocktime");
			if (xmlNode15 == null)
			{
				return false;
			}
			realTime = realTime.AddHours(StringChar.SToLong(xmlNode15.InnerText));
			si.sEndTime = realTime.ToString("yyyy-MM-dd HH:mm:ss");
			si.dEndTime = realTime;
			return true;
		}
		return true;
	}

	public string QueryQQBuyFriendDS(string sQueryQQNum)
	{
		m_SlaveListDS.Clear();
		string result = "读取好友买卖数据错误，请重新刷新获取";
		string text = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=xml&allinfo=1&uin=" + sQueryQQNum, null);
		m_nowxx = DateTime.Now;
		if (text != null && text.IndexOf("<root>") == -1)
		{
			return "读取好友买卖数据错误：缺少根元素Root，请重新刷新获取";
		}
		XmlDocument xmlDocument = new XmlDocument();
		text = text.Replace("<", "<" + strReplace);
		text = text.Replace("<" + strReplace + "?", "<?");
		text = text.Replace("<" + strReplace + "/", "</" + strReplace);
		xmlDocument.LoadXml(text);
		XmlNode documentElement = xmlDocument.DocumentElement;
		if (documentElement == null)
		{
			return result;
		}
		SlaveInfo si = null;
		XmlNodeList xmlNodeList = documentElement.SelectNodes(strReplace + "slaves");
		if (xmlNodeList != null)
		{
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				XmlNode xmlNode = xmlNodeList[i];
				if (xmlNode != null && ReadSlaveXmlDS(xmlNode, 0L, out si))
				{
					m_SlaveListDS.Add(si);
				}
			}
		}
		return null;
	}

	public bool ReadSlaveXmlDS(XmlNode node, long iNowTime, out SlaveInfo si)
	{
		si = new SlaveInfo();
		XmlNode xmlNode = node.SelectSingleNode(strReplace + "uin");
		if (xmlNode == null)
		{
			return false;
		}
		si.sQQNum = xmlNode.InnerText.Trim();
		XmlNode xmlNode2 = node.SelectSingleNode(strReplace + "name");
		if (xmlNode2 == null)
		{
			return false;
		}
		si.sQQName = xmlNode2.InnerText;
		return true;
	}

	private DateTime GetRealTime(long now, long sTime)
	{
		long num = sTime - now;
		return m_nowxx.AddSeconds(num);
	}

	public Stream GetPic(string sQueryQQNum)
	{
		return m_use.m_hh.GetStream("http://qqspace-av.qq.com/" + sQueryQQNum + "/10/00");
	}

	public FriendBuyInfo GetMeFriendBuyInfo()
	{
		return m_fb1;
	}

	public FriendBuyInfo GetMasterFriendBuyInfo()
	{
		return m_fb2;
	}

	public long GetCount()
	{
		return m_SlaveList.Count;
	}

	public SlaveInfo GetSlaveInfo(int iIndex)
	{
		int num = 0;
		foreach (SlaveInfo slave in m_SlaveList)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return slave;
		}
		return null;
	}

	public long GetCountDS()
	{
		return m_SlaveListDS.Count;
	}

	public SlaveInfo GetSlaveInfoDS(int iIndex)
	{
		int num = 0;
		foreach (SlaveInfo slaveListD in m_SlaveListDS)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return slaveListD;
		}
		return null;
	}
}
