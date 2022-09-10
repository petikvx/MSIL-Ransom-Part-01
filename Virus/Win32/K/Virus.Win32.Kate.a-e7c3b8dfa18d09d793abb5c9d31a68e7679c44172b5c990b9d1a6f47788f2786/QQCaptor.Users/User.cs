using System.IO;
using System.Text;
using System.Web;
using System.Xml;
using Helper;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class User
{
	public string m_sQQnum;

	public string m_sQQnick;

	public string m_sQQpass;

	public HttpHelper m_hh = new HttpHelper();

	public QueryPark m_qp;

	public QueryCars m_qc;

	public QueryFriends m_qf;

	public StopCars m_spc;

	public StartCars m_stc;

	public BuyCars m_bc;

	public QueryQQ m_qqq;

	public QueryNormal m_qn;

	public JuBao m_jb;

	public HaoYouMaiMai m_hymm;

	public FenXiHaoYou m_fxhy;

	public TingCheJiLu m_tcj;

	public bool m_bQcw;

	public bool m_bHymm;

	public Stream GetValidate()
	{
		return m_hh.GetStream("http://ptlogin2.qq.com/getimage?aid=15000101");
	}

	public Stream GetValidate2()
	{
		return m_hh.GetStream("http://ptlogin2.qq.com/getimage?aid=10000101");
	}

	public Stream GetAddFriend()
	{
		return m_hh.GetStream("http://ptlogin2.qq.com/getimage");
	}

	public Stream GetCityImage(string sID)
	{
		return m_hh.GetStream("http://daren4.store.qq.com/city/" + sID + "/1/2");
	}

	public Stream GetPhoto(string sUrl)
	{
		return m_hh.GetStream(sUrl);
	}

	public bool Login(string sQQPass, string sValidate, out string message, bool bQcw, bool bHymm)
	{
		message = null;
		string newPasswordEncypted = QQMD5.GetNewPasswordEncypted(sQQPass, sValidate);
		string content = "u=" + m_sQQnum + "&p=" + newPasswordEncypted + "&verifycode=" + sValidate + "&aid=15000101&u1=http%3A%2F%2Fphp.qzone.qq.com%2Findex.php%3Fmod%3Dportal%26act%3Dlogin&fp=loginerroralert&h=1&ptredirect=1&ptlang=0&from_ui=1&dumy=\0";
		string text = m_hh.Post("http://ptlogin2.qq.com/login", content);
		if (text.IndexOf("如果未能自动跳转") != -1)
		{
			m_qp = new QueryPark(this);
			m_qc = new QueryCars(this);
			m_qf = new QueryFriends(this);
			m_spc = new StopCars(this);
			m_stc = new StartCars(this);
			m_bc = new BuyCars(this);
			m_qqq = new QueryQQ(this);
			m_qn = new QueryNormal(this);
			m_jb = new JuBao(this);
			m_hymm = new HaoYouMaiMai(this);
			m_fxhy = new FenXiHaoYou(this);
			m_tcj = new TingCheJiLu(this);
			if (bQcw)
			{
				m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_login", "cmd=104&carid=0");
				m_bQcw = true;
			}
			if (bHymm)
			{
				m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=json&allinfo=1&uin=" + m_sQQnum, null);
				m_bHymm = true;
			}
			return true;
		}
		if (text.IndexOf("帐号不正确") != -1)
		{
			message = "您输入的帐号不正确，请重试！";
		}
		else if (text.IndexOf("密码有误") != -1)
		{
			message = "您输入的密码有误，请重试！";
		}
		else if (text.IndexOf("验证码有误") != -1)
		{
			message = "您输入的验证码有误，如果你确认你没输入错误，那就是腾讯启用IP限制了，我草腾讯他大爷，可以重新拨号连接改IP，再尝试！";
		}
		else if (text.IndexOf("系统繁忙") != -1)
		{
			message = "系统繁忙，请稍后重试，我草腾讯他大爷！";
		}
		else if (text.IndexOf("激活") != -1)
		{
			message = "你的QQ账号需要激活，注意：这是腾讯返回的信息！";
		}
		else
		{
			message = "我草，连接腾讯服务器失败，我草腾讯他大爷，请重新登录\r\n" + text;
		}
		return false;
	}

	public bool LoginAuto(string sQQPass, string sValidate, out string message, bool bQcw, bool bHymm)
	{
		message = null;
		string text = "9ECAEF0E39EB3A6D75CDF85FB8613A90B04610980B72BA74C390CBD4696ADFCB";
		m_hh.Get("http://ptlogin2.qq.com/jump?ptlang=2052&clientkey=" + text + "&clientuin=" + m_sQQnum + "&u1=http%3A%2F%2Fuser.qzone.qq.com%2F" + m_sQQnum + "%2Finfocenter", null);
		m_qp = new QueryPark(this);
		m_qc = new QueryCars(this);
		m_qf = new QueryFriends(this);
		m_spc = new StopCars(this);
		m_stc = new StartCars(this);
		m_bc = new BuyCars(this);
		m_qqq = new QueryQQ(this);
		m_qn = new QueryNormal(this);
		m_jb = new JuBao(this);
		m_hymm = new HaoYouMaiMai(this);
		m_fxhy = new FenXiHaoYou(this);
		m_tcj = new TingCheJiLu(this);
		if (bQcw)
		{
			m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_login", "cmd=104&carid=0");
			m_bQcw = true;
		}
		if (bHymm)
		{
			m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=json&allinfo=1&uin=" + m_sQQnum, null);
			m_bHymm = true;
		}
		return true;
	}

	public string GetQQNick(bool bHttpGet)
	{
		if (bHttpGet)
		{
			m_sQQnick = m_qp.GetQQNick(m_sQQnum);
		}
		return m_sQQnick;
	}

	public void SetQQNick(string sQQnick)
	{
		m_sQQnick = sQQnick;
	}

	public void LingQuJiangJin()
	{
		if (!m_bQcw)
		{
			m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_login", "cmd=104&carid=0");
			m_bQcw = true;
		}
		if (!m_bHymm)
		{
			m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=json&allinfo=1&uin=" + m_sQQnum, null);
			m_bHymm = true;
		}
	}

	public void LoginQcw()
	{
		m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_login", "cmd=104&carid=0");
	}

	public void LoginHymm()
	{
		m_hh.Get("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_space?otype=json&allinfo=1&uin=" + m_sQQnum, null);
	}

	public void LoginHymmMyk()
	{
		m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_card", "uin=" + m_sQQnum + "&optype=done");
	}

	public void ProMgy(string sDhQQNum)
	{
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0903_send", "rosetype=36&frienduin=" + sDhQQNum);
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0903_send", "rosetype=37&frienduin=" + sDhQQNum);
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0903_begin_play", "type=5&kind=5");
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0903_play", "i=0");
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0903_play", "i=0");
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0903_dig_pet", "i=0");
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/rosary0904_get_freeseed", "i=0");
	}

	public void ProHt(string sDhQQNum)
	{
		m_hh.Post("http://flower.qzone.qq.com/fcg-bin/cgi_plant", "fl=1&act=rain&uin=" + sDhQQNum);
		m_hh.Post("http://flower.qzone.qq.com/fcg-bin/cgi_plant", "fl=1&act=love&uin=" + sDhQQNum);
		m_hh.Post("http://flower.qzone.qq.com/fcg-bin/cgi_plant", "fl=1&act=sun&uin=" + sDhQQNum);
		m_hh.Post("http://flower.qzone.qq.com/fcg-bin/cgi_plant", "fl=1&act=nutri&uin=" + sDhQQNum);
	}

	public void ProXhmg(string sDhQQNum)
	{
		m_hh.Post("http://show.qq.com/cgi-bin/qqshow_user_reg", "item=0");
		m_hh.Post("http://show.qq.com/cgi-bin/qqshow_flower_freeget", "msg=&signature=&Recvuin=" + sDhQQNum);
	}

	public void ProBblykd()
	{
		m_hh.Post("http://minigamecgi.qq.com/cgi-bin/astrology_pet_free", "");
	}

	public void ProKtht()
	{
		string str = "QQ捕快";
		Encoding encoding = Encoding.GetEncoding("GB2312");
		str = HttpUtility.UrlEncode(str, encoding);
		m_hh.Post("http://base.qzone.qq.com/cgi-bin/qzapp/userapp_addone.cgi", "appid=348&uin=" + m_sQQnum);
		m_hh.Post("http://flower.qzone.qq.com/fcg-bin/fcg_get_user_flowerinfo", "fl=1" + m_sQQnum);
		m_hh.Post("http://flower.qzone.qq.com/cgi-bin/cgi_add_flower", "save=1&fid=38536&fname=" + str + "&opt=add&posx=940&posy=263&type=0");
	}

	public void ProKtqcw()
	{
		m_hh.Post("http://base.qzone.qq.com/cgi-bin/qzapp/userapp_addone.cgi", "appid=347&uin=" + m_sQQnum);
		m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_register?uin=NaN", "uin=NaN");
	}

	public void ProKthymm()
	{
		m_hh.Post("http://base.qzone.qq.com/cgi-bin/qzapp/userapp_addone.cgi", "appid=345&uin=" + m_sQQnum);
		m_hh.Post("http://sns.qzone.qq.com/cgi-bin/friendsale/frisale_cgi_init", "uin=" + m_sQQnum);
	}

	public void QQKongJian(string sDhQQNum, out string sVisitcount, out string sDayvisit)
	{
		sVisitcount = null;
		sDayvisit = null;
		string text = m_hh.Get("http://g.qzone.qq.com/fcg-bin/cgi_emotion_list.fcg?uin=" + sDhQQNum, null);
		if (text != null && !(text == string.Empty))
		{
			int num = 0;
			int outstartIndex = 0;
			sVisitcount = GetSubStringNum2(text, "visitcount", "dayvisit", 0, out outstartIndex);
			num = outstartIndex;
			sDayvisit = GetSubStringNum2(text, "dayvisit", "spacemark", num, out outstartIndex);
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

	public string GetNickSelf()
	{
		string result = "";
		string text = m_hh.Get("http://my.qq.com/my_login_info.php", null);
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
				XmlNode xmlNode = documentElement.SelectSingleNode("span");
				if (xmlNode == null)
				{
					return "";
				}
				result = xmlNode.InnerText;
				return result;
			}
			catch
			{
				return result;
			}
		}
		return result;
	}
}
