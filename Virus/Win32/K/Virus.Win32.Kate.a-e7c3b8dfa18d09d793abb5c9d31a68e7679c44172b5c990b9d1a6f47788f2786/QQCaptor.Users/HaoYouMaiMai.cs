using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Web;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class HaoYouMaiMai
{
	private User m_use;

	public Collection<MaiDeQiInfo> m_MaiDeQiList = new Collection<MaiDeQiInfo>();

	private DateTime GetRealTime(long sTime)
	{
		DateTime dateTime = new DateTime(2009, 5, 9, 19, 49, 45);
		long num = sTime - 1241869785L;
		return dateTime.AddSeconds(num);
	}

	public HaoYouMaiMai(User use)
	{
		m_use = use;
	}

	public string GetSubStringName(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
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

	public string GetSubStringName2(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
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

	public string GetSubStringMoney(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
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

	public string GetSubStringMessage(string down, string sStart, string sEnd, int instartIndex, out int outstartIndex)
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

	public string QueryMaiDeQiFriend()
	{
		m_use.LingQuJiangJin();
		m_MaiDeQiList.Clear();
		string text = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_buyfriendlist?uin=" + m_use.m_sQQnum, null);
		if (text != null && !(text == string.Empty))
		{
			int instartIndex = 0;
			int outstartIndex = 0;
			string text2 = null;
			while (true)
			{
				MaiDeQiInfo maiDeQiInfo = new MaiDeQiInfo();
				text2 = GetSubStringName(text, "nick", "price", instartIndex, out outstartIndex);
				if (text2 == null)
				{
					break;
				}
				instartIndex = outstartIndex;
				maiDeQiInfo.sQQName = text2;
				text2 = GetSubStringMoney(text, "price", "uin", instartIndex, out outstartIndex);
				if (text2 == null)
				{
					break;
				}
				instartIndex = outstartIndex;
				maiDeQiInfo.sBuyMoney = text2;
				text2 = GetSubStringNum(text, "uin", "}", instartIndex, out outstartIndex);
				if (text2 == null)
				{
					break;
				}
				instartIndex = outstartIndex;
				maiDeQiInfo.sQQNum = text2;
				m_MaiDeQiList.Add(maiDeQiInfo);
			}
			return null;
		}
		return null;
	}

	public long GetCount()
	{
		return m_MaiDeQiList.Count;
	}

	public MaiDeQiInfo GetMaiDeQiInfo(int iIndex)
	{
		if (iIndex < m_MaiDeQiList.Count)
		{
			return m_MaiDeQiList[iIndex];
		}
		return null;
	}

	public string GetErroeMessage(string strDown)
	{
		int instartIndex = 0;
		int outstartIndex = 0;
		string text = null;
		text = GetSubStringMoney(strDown, "code", "msg", 0, out outstartIndex);
		if (text == null)
		{
			text = GetSubStringMoney(strDown, "code", "now", instartIndex, out outstartIndex);
			if (text == null)
			{
				return "我草，未知错误";
			}
		}
		instartIndex = outstartIndex;
		string text2 = text;
		if (text2 != "0")
		{
			text = GetSubStringName(strDown, "msg", "now", instartIndex, out outstartIndex);
			if (text == null)
			{
				text = GetSubStringMessage(strDown, "msg", "}", instartIndex, out outstartIndex);
			}
			if (text == null)
			{
				text = " ";
			}
			instartIndex = outstartIndex;
			string text3 = text;
			if (text3.Length < 2)
			{
				text3 = ((text2 == "-122") ? "大哥，你的钱不够吧" : ((text2 == "-91") ? "不好意思，腾讯更新了，你不能直接使用高级的折磨和安抚的方式" : ((text2 == "-112") ? "我草，你的主人你也敢买" : (text2 switch
				{
					"-127" => "我草，他已经是你的奴隶了", 
					"-112" => "我草，你连自己也想买", 
					"-126" => "我考，不是你的好友也想买啊", 
					"-2" => "草腾讯他大爷，服务器老出错", 
					"-12" => "草腾讯他大爷，服务器老出错", 
					"-125" => "TA今天已经被买卖2次了吧，不可以再买", 
					"-115" => "我草，还不是奴隶吧", 
					"-116" => "我草，你已经使用过一次命运卡", 
					"-124" => "TA刚赎过身，三天之内就算你有钱也不让你让买", 
					"-119" => "哈哈，今天你已经使用过了，不要太贪了，明天再来吧", 
					"-123" => "我草，TA估计正在工作中，你等着吧", 
					"-120" => "哈哈，你使用外挂吧，居然给我发送非法值，你档次不够撒", 
					"-117" => "我汗，购买奴隶2天内不让打折，腾讯也真够狠的", 
					"-97" => "我草，依照系统指示，您暂时无法折磨和安抚，请不要做无谓的抵抗[一个小时之内无法折磨和安抚]", 
					_ => "草腾讯他大爷，未知错误，错误码Code=" + text2, 
				}))));
			}
			return text3;
		}
		return null;
	}

	public string ProBuyFriend(string strQQNum, string strNick)
	{
		Encoding encoding = Encoding.GetEncoding("UTF-8");
		strNick = HttpUtility.UrlEncode(strNick, encoding);
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_slave_buy", "uin=" + m_use.m_sQQnum + "&slaveuin=" + strQQNum + "&nickname=" + strNick + "&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ClearNick()
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_clear_nick", "uin=" + m_use.m_sQQnum);
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProShuShen()
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_redeem", "uin=" + m_use.m_sQQnum + "&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProMinYunKa()
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_card", "uin=" + m_use.m_sQQnum + "&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProZheMo(string strQQNum, string strAid)
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_action_w", "uin=" + m_use.m_sQQnum + "&beuin=" + strQQNum + "&aid=" + strAid + "&type=1&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProAnFu(string strQQNum, string strAid)
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_action_w", "uin=" + m_use.m_sQQnum + "&beuin=" + strQQNum + "&aid=" + strAid + "&type=2&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProQingAn(string strQQNum, string strAid)
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_action_w", "uin=" + m_use.m_sQQnum + "&beuin=" + strQQNum + "&aid=" + strAid + "&type=3&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProDaZhe(string strQQNum, string discount)
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_discount", "uin=" + m_use.m_sQQnum + "&slaveuin=" + strQQNum + "&discount=" + discount + "&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string ProShiFang(string strQQNum)
	{
		string text = m_use.m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_slave_release", "uin=" + m_use.m_sQQnum + "&slaveuin=" + strQQNum + "&optype=done");
		if (text != null && !(text == string.Empty))
		{
			return GetErroeMessage(text);
		}
		return null;
	}

	public string QueryInfo()
	{
		string text = m_use.m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_getUserFeeds?uin=" + m_use.m_sQQnum + "&leo=0.5619047903822751", null);
		if (text != null && !(text == string.Empty))
		{
			string text2 = "";
			try
			{
				int num = 0;
				int outstartIndex = 0;
				string text3 = null;
				while (true)
				{
					int num2 = text.IndexOf("data", num);
					int num3 = text.IndexOf("data", num2 + 4);
					string text4 = "";
					string text5 = GetSubStringNum(text, "inc", "}", num, out outstartIndex);
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text5 = "";
					}
					string text6 = GetSubStringNum(text, "inc", ",", num, out outstartIndex);
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text6 = "";
					}
					if (text5 != null && text5.Length > 1 && text5.Length < 5)
					{
						text4 = text5;
					}
					else if (text6 != null && text6.Length > 1 && text6.Length < 5)
					{
						text4 = text6;
					}
					text3 = GetSubStringNum(text, "co", ",", num, out outstartIndex);
					string text7 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text7 = "";
					}
					text3 = GetSubStringNum(text, "cp", "},", num, out outstartIndex);
					string text8 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text8 = "";
					}
					text3 = GetSubStringNum(text, "ci", ",", num, out outstartIndex);
					string text9 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text9 = "";
					}
					text3 = GetSubStringNum(text, "dp", ",", num, out outstartIndex);
					string text10 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text10 = "";
					}
					text3 = GetSubStringNum(text, "ds", ",", num, out outstartIndex);
					string text11 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text11 = "";
					}
					int outstartIndex2 = 0;
					string text12 = "";
					text3 = GetSubStringName2(text, "ni", "\",\"", num, out outstartIndex);
					string subStringName = GetSubStringName2(text, "ni", "\"}", num, out outstartIndex2);
					if (subStringName != null && outstartIndex2 < outstartIndex)
					{
						text12 = subStringName;
						if (num2 != -1 && num3 != -1 && outstartIndex2 > num3)
						{
							text12 = "";
						}
					}
					else
					{
						text12 = text3;
						if (num2 != -1 && num3 != -1 && outstartIndex > num3)
						{
							text12 = "";
						}
					}
					text3 = GetSubStringNum(text, "sin", ",", num, out outstartIndex);
					string text13 = text3;
					text3 = GetSubStringName2(text, "sn", "\",\"", num, out outstartIndex);
					string text14 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text14 = "";
					}
					text3 = GetSubStringNum(text, "inp", ",", num, out outstartIndex);
					string text15 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text15 = "";
					}
					text3 = GetSubStringNum(text, "lt", ",", num, out outstartIndex);
					string text16 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text16 = "";
					}
					text3 = GetSubStringNum(text, "min", ",", num, out outstartIndex);
					string text17 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text17 = "";
					}
					text3 = GetSubStringName2(text, "mn", "\",\"", num, out outstartIndex);
					string text18 = text3;
					if (num2 != -1 && num3 != -1 && outstartIndex > num3)
					{
						text18 = "";
					}
					text3 = GetSubStringName2(text, "si", "\",\"", num, out outstartIndex);
					if (num2 == -1 || num3 != -1)
					{
					}
					text3 = GetSubStringNum2(text, "subtype", "time", num, out outstartIndex);
					if (text3 == null)
					{
						break;
					}
					if (!(text3 == ""))
					{
						num = outstartIndex;
						string text19 = text3;
						text3 = GetSubStringNum2(text, "time", "type", num, out outstartIndex);
						num = outstartIndex;
						string text20 = "【" + GetRealTime(StringChar.SToLong(text3)).ToString("yyyy-MM-dd HH:mm:ss】");
						text3 = GetSubStringNum(text, "type", "}", num, out outstartIndex);
						num = outstartIndex;
						string text21 = text3;
						text2 += text20;
						switch (text21)
						{
						case "1028":
							text2 += "我【登录】了好友买卖，获得100金";
							break;
						case "8":
							if (text19 != null && text19 == "0")
							{
								string text33 = text2;
								text2 = text33 + "我花" + text7 + "金买了【" + text14 + "】，起了个绰号叫【" + text12 + "】";
							}
							else if (text19 != null && text19 == "1")
							{
								string text34 = text2;
								text2 = text34 + "我被【" + text18 + "】花" + text7 + "金买了，起了个绰号叫【" + text12 + "】";
							}
							else if (text19 != null && text19 == "2")
							{
								string text35 = text2;
								text2 = text35 + "【" + text18 + "】花" + text7 + "金从我手里抢走了【" + text14 + "】，起了个绰号叫【" + text12 + "】，我从中受益" + text4 + "金";
							}
							else if (text19 != null && text19 == "3")
							{
								string text36 = text2;
								text2 = text36 + "我从【" + text18 + "】手里抢走了【" + text14 + "】，起了个绰号叫【" + text12 + "】，我花掉了" + text7 + "金";
							}
							break;
						case "1026":
							if (text19 != null && text19 == "1")
							{
								string text30 = text2;
								text2 = text30 + "我花了" + text7 + "金从【" + text18 + "】那里赎身了";
							}
							else
							{
								string text31 = text2;
								text2 = text31 + "【" + text14 + "】花了" + text7 + "金从我手里赎身了";
							}
							break;
						case "1025":
							text2 = text2 + "【" + text14 + "】被我释放了，获得了自由身";
							break;
						case "1024":
						{
							string text32 = text2;
							text2 = text32 + "【" + text14 + "】被我打" + text11 + "折处理，身价降到" + text10 + "金";
							break;
						}
						default:
							if (text19 != null && text19 == "1")
							{
								if (text17 != null && text17.Length > 1)
								{
									string text22 = text2;
									text2 = text22 + "【" + text18 + "】对我进行了安抚，我一感动，就给了他" + text17 + "金的小费";
								}
								else if (text15 != null && text15.Length > 1)
								{
									string text23 = text2;
									text2 = text23 + "【" + text18 + "】对我进行了折磨，我一口气干了" + text16 + "小时，每小时给他赚了" + text15 + "金";
								}
								else if (text7 != null && text7.Length > 1)
								{
									string text24 = text2;
									text2 = text24 + "【" + text18 + "】对我进行了折磨，他倒霉亏了" + text7 + "金";
								}
								else if (text13 != null)
								{
									string text25 = text2;
									text2 = text25 + "我对主人【" + text18 + "】进行了讨好，主人一感动，就给了我" + text13 + "金的小费";
								}
							}
							else if (text19 != null && text19 == "0")
							{
								if (text17 != null && text17.Length > 1)
								{
									string text26 = text2;
									text2 = text26 + "【" + text14 + "】被我进行了安抚，他一感动，他就给了我" + text17 + "金的小费";
								}
								else if (text8 != null && text8.Length > 1)
								{
									text2 = text2 + "我使用了命运卡，身价涨了" + text8 + "金";
								}
								else if (text9 != null && text9.Length > 1)
								{
									text2 = text2 + "我使用了命运卡，现金涨了" + text9 + "金";
								}
								else if (text15 != null && text15.Length > 1)
								{
									string text27 = text2;
									text2 = text27 + "【" + text14 + "】被我进行了折磨，他一口气干了" + text16 + "小时，每小时给我赚了" + text15 + "金";
								}
								else if (text7 != null && text7.Length > 1)
								{
									string text28 = text2;
									text2 = text28 + "【" + text14 + "】被我进行了折磨，我倒霉亏了" + text7 + "金";
								}
								else if (text4 != null && text4.Length > 1)
								{
									text2 = text2 + "由于本人长的太帅，系统奖励了我" + text4 + "金";
								}
								else if (text13 != null)
								{
									string text29 = text2;
									text2 = text29 + "【" + text14 + "】对我进行了讨好，我一感动，我就给了他" + text13 + "金的小费";
								}
							}
							else
							{
								text2 += "未知信息，最好去网页看看是什么类型信息，再请把这个告诉捕快作者改进";
							}
							break;
						}
						text2 += "\r\n";
						continue;
					}
					return text2;
				}
				return text2;
			}
			catch
			{
				return text2;
			}
		}
		return null;
	}
}
