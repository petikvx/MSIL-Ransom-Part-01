using System.Collections.ObjectModel;
using System.Windows.Forms;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class QueryCars
{
	private User m_use;

	private CarType ct = new CarType();

	private long m_iSelfMoney;

	private string m_getAllInfo;

	public Collection<CarInfo> m_carInfoList = new Collection<CarInfo>();

	public Collection<CarInfo> m_carInfoListJB = new Collection<CarInfo>();

	public QueryCars(User use)
	{
		m_use = use;
	}

	public bool QueryCarInfo(string sQQNum)
	{
		m_use.LingQuJiangJin();
		string text = m_use.m_hh.Get("http://world.show.qq.com/cgi-bin/parker_user_info?field=2|3|&uin=" + sQQNum, null);
		m_carInfoList.Clear();
		m_getAllInfo = text;
		int num = 0;
		string text2 = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 1;
		num2 = text.IndexOf(" cash=", 0);
		if (num2 == -1)
		{
			return false;
		}
		num3 = text.IndexOf(" score=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 7;
			num = num3;
			text2 = text.Substring(num2, num3 - num2 - 1);
			m_iSelfMoney = StringChar.SToLong(text2);
			num = num3;
			while (true)
			{
				CarInfo carInfo = new CarInfo();
				carInfo.Id = num4++;
				num2 = text.IndexOf("car carno=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" carid=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = (carInfo.CarName = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf(" carid=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" carcolor=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 8;
				num = num3;
				text2 = (carInfo.CarNum = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf(" carcolor=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" price=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.CarColor = ct.carColor[StringChar.SToLong(text2) - 1L];
				num2 = text.IndexOf(" price=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" moneyget=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 8;
				num = num3;
				text2 = (carInfo.CarPrice = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf(" moneyget=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" money=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.iTime = StringChar.SToInt(text2);
				num2 = text.IndexOf(" parklotno=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" cshow=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 12;
				num = num3;
				text2 = (carInfo.strParkNum = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf("parkuin=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" reportUin=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 9;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.QQNum = text2.Trim();
				num2 = text.IndexOf("reportUin=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(">", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.reportUin = StringChar.ChinaUnicodeToASCII(text2.Trim());
				m_carInfoList.Add(carInfo);
			}
			return true;
		}
		return false;
	}

	public bool QueryCarInfoJB(string sQQNum)
	{
		string text = m_use.m_hh.Get("http://world.show.qq.com/cgi-bin/parker_user_info?field=2|3|&uin=" + sQQNum, null);
		m_carInfoListJB.Clear();
		int num = 0;
		string text2 = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 1;
		num2 = text.IndexOf(" cash=", 0);
		if (num2 == -1)
		{
			return false;
		}
		num3 = text.IndexOf(" score=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 7;
			num = num3;
			text2 = text.Substring(num2, num3 - num2 - 1);
			m_iSelfMoney = StringChar.SToLong(text2);
			num = num3;
			while (true)
			{
				CarInfo carInfo = new CarInfo();
				carInfo.Id = num4++;
				num2 = text.IndexOf("car carno=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" carid=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = (carInfo.CarName = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf(" carid=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" carcolor=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 8;
				num = num3;
				text2 = (carInfo.CarNum = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf(" carcolor=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" price=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.CarColor = ct.carColor[StringChar.SToLong(text2) - 1L];
				num2 = text.IndexOf(" price=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" moneyget=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 8;
				num = num3;
				text2 = (carInfo.CarPrice = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf(" moneyget=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" money=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 11;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.iTime = StringChar.SToInt(text2);
				num2 = text.IndexOf(" parklotno=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" cshow=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 12;
				num = num3;
				text2 = (carInfo.strParkNum = text.Substring(num2, num3 - num2 - 1));
				num2 = text.IndexOf("parkuin=", num);
				if (num2 == -1)
				{
					break;
				}
				num3 = text.IndexOf(" reportUin=", num2);
				if (num2 == -1 || num3 == -1)
				{
					break;
				}
				num2 += 9;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				carInfo.QQNum = text2.Trim();
				m_carInfoListJB.Add(carInfo);
			}
			return true;
		}
		return false;
	}

	public bool QueryQQCarInfo(string sQQNum)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		string text = m_use.m_hh.Get("http://world.show.qq.com/cgi-bin/parker_user_info?field=2|3|&uin=" + sQQNum, null);
		m_carInfoList.Clear();
		m_getAllInfo = text;
		int num = 0;
		string text2 = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 1;
		num2 = text.IndexOf(" uin=", 0);
		if (num2 == -1)
		{
			Validate validate = new Validate();
			validate.SetUser(m_use, sQQNum);
			((Form)validate).ShowDialog();
			if (!validate.m_bOK)
			{
				return false;
			}
			num = 0;
			text = validate.m_sDown;
			num2 = text.IndexOf(" uin=", 0);
			if (num2 == -1)
			{
				return false;
			}
		}
		num3 = text.IndexOf("nick=", num2);
		if (num2 != -1 && num3 != -1)
		{
			num2 += 6;
			num = num3;
			text2 = text.Substring(num2, num3 - num2 - 2);
			if (sQQNum != text2)
			{
				m_iSelfMoney = 0L;
				return false;
			}
			num2 = text.IndexOf(" cash=", num);
			if (num2 == -1)
			{
				return false;
			}
			num3 = text.IndexOf(" score=", num2);
			if (num2 != -1 && num3 != -1)
			{
				num2 += 7;
				num = num3;
				text2 = text.Substring(num2, num3 - num2 - 1);
				m_iSelfMoney = StringChar.SToLong(text2);
				num = num3;
				while (true)
				{
					CarInfo carInfo = new CarInfo();
					carInfo.Id = num4++;
					num2 = text.IndexOf("car carno=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" carid=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 11;
					num = num3;
					text2 = (carInfo.CarName = text.Substring(num2, num3 - num2 - 1));
					num2 = text.IndexOf(" carid=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" carcolor=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 8;
					num = num3;
					text2 = (carInfo.CarNum = text.Substring(num2, num3 - num2 - 1));
					num2 = text.IndexOf(" carcolor=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" price=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 11;
					num = num3;
					text2 = text.Substring(num2, num3 - num2 - 1);
					carInfo.CarColor = ct.carColor[StringChar.SToLong(text2) - 1L];
					num2 = text.IndexOf(" price=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" moneyget=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 8;
					num = num3;
					text2 = (carInfo.CarPrice = text.Substring(num2, num3 - num2 - 1));
					num2 = text.IndexOf(" moneyget=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" money=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 11;
					num = num3;
					text2 = text.Substring(num2, num3 - num2 - 1);
					carInfo.iTime = StringChar.SToInt(text2);
					num2 = text.IndexOf(" parklotno=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" cshow=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 12;
					num = num3;
					text2 = (carInfo.strParkNum = text.Substring(num2, num3 - num2 - 1));
					num2 = text.IndexOf("parkuin=", num);
					if (num2 == -1)
					{
						break;
					}
					num3 = text.IndexOf(" reportUin=", num2);
					if (num2 == -1 || num3 == -1)
					{
						break;
					}
					num2 += 9;
					num = num3;
					text2 = text.Substring(num2, num3 - num2 - 1);
					carInfo.QQNum = text2.Trim();
					carInfo.QQName = GetNick(carInfo.QQNum);
					m_carInfoList.Add(carInfo);
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public string GetNick(string sQQNum)
	{
		if (sQQNum != null && sQQNum.Length < 4)
		{
			return "";
		}
		string text = "";
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNum;
		string text2 = m_use.m_hh.Get(url, null);
		if (!(text2 == string.Empty) && text2 != null)
		{
			int num = text2.IndexOf(" nick=", 0);
			if (num == -1)
			{
				return null;
			}
			int num2 = text2.IndexOf(" money=", num);
			if (num != -1 && num2 != -1)
			{
				num += 7;
				string strInput = text2.Substring(num, num2 - num - 1);
				return StringChar.ChinaUnicodeToASCII(strInput);
			}
			return null;
		}
		return null;
	}

	public string GetNickJB(string sQQNum)
	{
		if (sQQNum != null && sQQNum.Length < 4)
		{
			return "";
		}
		string text = "";
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + sQQNum;
		string text2 = m_use.m_hh.Get(url, null);
		if (!(text2 == string.Empty) && text2 != null)
		{
			int num = text2.IndexOf(" nick=", 0);
			if (num == -1)
			{
				return null;
			}
			int num2 = text2.IndexOf(" money=", num);
			if (num != -1 && num2 != -1)
			{
				num += 7;
				string strInput = text2.Substring(num, num2 - num - 1);
				return StringChar.ChinaUnicodeToASCII(strInput);
			}
			return null;
		}
		return null;
	}

	public long GetCount()
	{
		return m_carInfoList.Count;
	}

	public long GetCountJB()
	{
		return m_carInfoListJB.Count;
	}

	public long GetSelfMoney()
	{
		return m_iSelfMoney;
	}

	public CarInfo GetCarInfo(int iIndex)
	{
		int num = 0;
		foreach (CarInfo carInfo in m_carInfoList)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return carInfo;
		}
		return null;
	}

	public CarInfo GetCarInfoJB(int iIndex)
	{
		int num = 0;
		foreach (CarInfo item in m_carInfoListJB)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return item;
		}
		return null;
	}
}
