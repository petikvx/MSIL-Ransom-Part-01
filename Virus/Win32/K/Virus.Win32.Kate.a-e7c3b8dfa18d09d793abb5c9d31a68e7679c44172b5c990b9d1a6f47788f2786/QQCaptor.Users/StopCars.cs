using System.Text;
using System.Web;
using System.Windows.Forms;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class StopCars
{
	private User m_use;

	public StopCars(User use)
	{
		m_use = use;
	}

	public string ProStopCars(string QQNum, string carid, string parkno, string words)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		string result = null;
		if (words != null && words != "")
		{
			Encoding encoding = Encoding.GetEncoding("UTF-8");
			words = HttpUtility.UrlEncode(words, encoding);
		}
		string url = "http://world.show.qq.com/cgi-bin/parker_user_pin?words=" + words + "&note=0&type=0&code=&parkno=" + parkno + "&opuin=" + QQNum + "&carid=" + carid + "&cmd=102";
		string text = m_use.m_hh.Get(url, null);
		string text2 = StringChar.ChinaUnicodeToASCII(text);
		int num = text2.IndexOf("繁忙", 0);
		if (num != -1)
		{
			ValidateCar validateCar = new ValidateCar();
			validateCar.SetUser(m_use);
			((Form)validateCar).ShowDialog();
			if (validateCar.m_bOK)
			{
				string sValidate = validateCar.m_sValidate;
				url = "http://world.show.qq.com/cgi-bin/parker_user_pin?words=" + words + "&note=0&type=0&code=" + sValidate + "&carid=" + carid + "&parkno=" + parkno + "&opuin=" + QQNum + "&cmd=102";
				text = m_use.m_hh.Get(url, null);
			}
		}
		string text3 = null;
		int num2 = 0;
		num = text.IndexOf(" code=", 0);
		if (num == -1)
		{
			return result;
		}
		int num3 = text.IndexOf(" message=", num);
		if (num != -1 && num3 != -1)
		{
			num += 7;
			num2 = num3;
			string text4 = text.Substring(num, num3 - num - 1);
			text3 = text4;
			if (text3 != "0")
			{
				new StringChar();
				num = text.IndexOf(" message=", num2);
				if (num == -1)
				{
					return result;
				}
				num3 = text.IndexOf("</QQHOME>", num);
				if (num == -1 || num3 == -1)
				{
					return result;
				}
				num += 10;
				num2 = num3;
				text4 = text.Substring(num, num3 - num - 3);
				result = StringChar.ChinaUnicodeToASCII(text4);
			}
			return result;
		}
		return result;
	}

	public string ProStopCarsJB(string QQNum, string carid, string parkno, string words)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		string result = null;
		if (words != null && words != "")
		{
			Encoding encoding = Encoding.GetEncoding("UTF-8");
			words = HttpUtility.UrlEncode(words, encoding);
		}
		string url = "http://world.show.qq.com/cgi-bin/parker_user_pin?words=" + words + "&note=0&type=0&code=&parkno=" + parkno + "&opuin=" + QQNum + "&carid=" + carid + "&cmd=102";
		string text = m_use.m_hh.Get(url, null);
		string text2 = StringChar.ChinaUnicodeToASCII(text);
		int num = text2.IndexOf("繁忙", 0);
		if (num != -1)
		{
			ValidateCar validateCar = new ValidateCar();
			validateCar.SetUser(m_use);
			((Form)validateCar).ShowDialog();
			if (validateCar.m_bOK)
			{
				string sValidate = validateCar.m_sValidate;
				url = "http://world.show.qq.com/cgi-bin/parker_user_pin?words=" + words + "&note=0&type=0&code=" + sValidate + "&carid=" + carid + "&parkno=" + parkno + "&opuin=" + QQNum + "&cmd=102";
				text = m_use.m_hh.Get(url, null);
			}
		}
		string text3 = null;
		int num2 = 0;
		num = text.IndexOf(" code=", 0);
		if (num == -1)
		{
			return result;
		}
		int num3 = text.IndexOf(" message=", num);
		if (num != -1 && num3 != -1)
		{
			num += 7;
			num2 = num3;
			string text4 = text.Substring(num, num3 - num - 1);
			text3 = text4;
			if (text3 != "0")
			{
				new StringChar();
				num = text.IndexOf(" message=", num2);
				if (num == -1)
				{
					return result;
				}
				num3 = text.IndexOf("</QQHOME>", num);
				if (num == -1 || num3 == -1)
				{
					return result;
				}
				num += 10;
				num2 = num3;
				text4 = text.Substring(num, num3 - num - 3);
				result = StringChar.ChinaUnicodeToASCII(text4);
			}
			return result;
		}
		return result;
	}
}
