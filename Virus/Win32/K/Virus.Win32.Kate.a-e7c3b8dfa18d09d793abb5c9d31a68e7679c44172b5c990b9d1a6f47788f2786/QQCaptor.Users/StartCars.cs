using System;
using System.Windows.Forms;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class StartCars
{
	private User m_use;

	public string m_QQNumPark;

	public bool m_bPark1;

	public bool m_bPark2;

	public bool m_bPark3;

	public bool m_bPark4;

	public int carnum;

	public string m_QQNumParkJB;

	public bool m_bPark1JB;

	public bool m_bPark2JB;

	public bool m_bPark3JB;

	public bool m_bPark4JB;

	public int carnumJB;

	public StartCars(User use)
	{
		m_use = use;
	}

	public bool InitPark(string QQNumPark)
	{
		carnum = 0;
		m_QQNumPark = QQNumPark;
		Random random = new Random();
		string text = random.NextDouble().ToString();
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + QQNumPark + "&" + text;
		m_use.m_hh.Get(url, null);
		m_use.m_qp.QueryParkerInfo(QQNumPark, out m_bPark1, out m_bPark2, out m_bPark3, out m_bPark4);
		long num = m_use.m_qp.GetCount();
		for (int i = 0; i < num; i++)
		{
			ParkInfo parkInfo = m_use.m_qp.GetParkInfo(i);
			if (parkInfo.sQQNum == m_use.m_sQQnum)
			{
				carnum++;
			}
		}
		return true;
	}

	public bool IsFull()
	{
		if (!m_bPark2 && !m_bPark3 && !m_bPark4)
		{
			return true;
		}
		return false;
	}

	public bool IsAiXinCheWeiFull()
	{
		if (!m_bPark1)
		{
			return true;
		}
		return false;
	}

	public string ProStartCars(string carid, string parkno, out string outparkno)
	{
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		outparkno = null;
		string result = null;
		string text = null;
		string text2 = carnum.ToString();
		if (parkno == null)
		{
			if (m_bPark2)
			{
				parkno = "2";
			}
			else if (m_bPark3)
			{
				parkno = "3";
			}
			else
			{
				if (!m_bPark4)
				{
					return "发生未知错误：可能没有停车位了";
				}
				parkno = "4";
			}
		}
		outparkno = parkno;
		text = ((!(parkno == "1")) ? ("cmd=101&opuin=" + m_QQNumPark + "&carnum=" + text2 + "&parkno=" + parkno + "&carid=" + carid) : ("opuin=" + m_QQNumPark + "&cmd=101&carid=" + carid + "&parkno=1&carnum=" + text2));
		string text3 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_action", text);
		string text4 = StringChar.ChinaUnicodeToASCII(text3);
		int num = text4.IndexOf("繁忙", 0);
		if (num != -1)
		{
			ValidateCar validateCar = new ValidateCar();
			validateCar.SetUser(m_use);
			((Form)validateCar).ShowDialog();
			if (validateCar.m_bOK)
			{
				string sValidate = validateCar.m_sValidate;
				text = "carid=" + carid + "&parkno=" + parkno + "&opuin=" + m_QQNumPark + "&cmd=101&carnum=" + text2 + "&code=" + sValidate;
				text3 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_action", text);
			}
		}
		string text5 = null;
		int num2 = 0;
		num = text3.IndexOf(" code=", 0);
		if (num == -1)
		{
			return result;
		}
		int num3 = text3.IndexOf(" message=", num);
		if (num != -1 && num3 != -1)
		{
			num += 7;
			num2 = num3;
			string text6 = text3.Substring(num, num3 - num - 1);
			text5 = text6;
			if (text5 != "0")
			{
				new StringChar();
				num = text3.IndexOf(" message=", num2);
				if (num == -1)
				{
					return result;
				}
				num3 = text3.IndexOf(">", num);
				if (num == -1 || num3 == -1)
				{
					return result;
				}
				num += 10;
				num2 = num3;
				text6 = text3.Substring(num, num3 - num - 1);
				result = StringChar.ChinaUnicodeToASCII(text6);
			}
			else
			{
				if (parkno == "2")
				{
					m_bPark2 = false;
					carnum++;
				}
				if (parkno == "3")
				{
					m_bPark3 = false;
					carnum++;
				}
				if (parkno == "4")
				{
					m_bPark4 = false;
					carnum++;
				}
			}
			return result;
		}
		return result;
	}

	public bool InitParkJB(string QQNumPark)
	{
		carnumJB = 0;
		m_QQNumParkJB = QQNumPark;
		Random random = new Random();
		string text = random.NextDouble().ToString();
		string url = "http://world.show.qq.com/cgi-bin/parker_user_front?uin=" + QQNumPark + "&" + text;
		m_use.m_hh.Get(url, null);
		m_use.m_qp.QueryParkerInfoJB(QQNumPark, out m_bPark1JB, out m_bPark2JB, out m_bPark3JB, out m_bPark4JB);
		long num = m_use.m_qp.GetCountJB();
		for (int i = 0; i < num; i++)
		{
			ParkInfo parkInfoJB = m_use.m_qp.GetParkInfoJB(i);
			if (parkInfoJB.sQQNum == m_use.m_sQQnum)
			{
				carnumJB++;
			}
		}
		return true;
	}

	public bool IsFullJB()
	{
		if (!m_bPark2JB && !m_bPark3JB && !m_bPark4JB)
		{
			return true;
		}
		return false;
	}

	public string ProStartCarsJB(string carid, string strParkNo, out string outparkno)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		outparkno = null;
		string result = null;
		string text = null;
		string text2 = carnumJB.ToString();
		string text3 = null;
		if (m_bPark2JB)
		{
			text3 = "2";
		}
		else if (m_bPark3JB)
		{
			text3 = "3";
		}
		else
		{
			if (!m_bPark4JB)
			{
				return "发生未知错误";
			}
			text3 = "4";
		}
		if (strParkNo != null)
		{
			text3 = strParkNo;
		}
		outparkno = text3;
		text = "cmd=101&opuin=" + m_QQNumParkJB + "&carnum=" + text2 + "&parkno=" + text3 + "&carid=" + carid;
		string text4 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_action", text);
		string text5 = StringChar.ChinaUnicodeToASCII(text4);
		int num = text5.IndexOf("繁忙", 0);
		if (num != -1)
		{
			ValidateCar validateCar = new ValidateCar();
			validateCar.SetUser(m_use);
			((Form)validateCar).ShowDialog();
			if (validateCar.m_bOK)
			{
				string sValidate = validateCar.m_sValidate;
				text = "carid=" + carid + "&parkno=" + text3 + "&opuin=" + m_QQNumPark + "&cmd=101&carnum=" + text2 + "&code=" + sValidate;
				text4 = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_action", text);
			}
		}
		string text6 = null;
		int num2 = 0;
		num = text4.IndexOf(" code=", 0);
		if (num == -1)
		{
			return result;
		}
		int num3 = text4.IndexOf(" message=", num);
		if (num != -1 && num3 != -1)
		{
			num += 7;
			num2 = num3;
			string text7 = text4.Substring(num, num3 - num - 1);
			text6 = text7;
			if (text6 != "0")
			{
				new StringChar();
				num = text4.IndexOf(" message=", num2);
				if (num == -1)
				{
					return result;
				}
				num3 = text4.IndexOf(">", num);
				if (num == -1 || num3 == -1)
				{
					return result;
				}
				num += 10;
				num2 = num3;
				text7 = text4.Substring(num, num3 - num - 1);
				result = StringChar.ChinaUnicodeToASCII(text7);
			}
			else
			{
				if (text3 == "2")
				{
					m_bPark2JB = false;
					carnumJB++;
				}
				if (text3 == "3")
				{
					m_bPark3JB = false;
					carnumJB++;
				}
				if (text3 == "4")
				{
					m_bPark4JB = false;
					carnumJB++;
				}
			}
			return result;
		}
		return result;
	}
}
