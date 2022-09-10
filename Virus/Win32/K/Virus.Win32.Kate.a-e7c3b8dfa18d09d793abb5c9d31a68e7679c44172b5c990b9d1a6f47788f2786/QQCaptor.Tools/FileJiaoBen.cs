using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace QQCaptor.Tools;

internal class FileJiaoBen
{
	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

	[DllImport("kernel32")]
	private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

	public string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		GetPrivateProfileString(Section, Key, NoText, stringBuilder, 1024, iniFilePath);
		return stringBuilder.ToString();
	}

	public bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
	{
		long num = WritePrivateProfileString(Section, Key, Value, iniFilePath);
		if (num == 0L)
		{
			return false;
		}
		return true;
	}

	public bool FindPark(JiaoBenInfo jbinfo, string sPark)
	{
		foreach (string sTieTiao in jbinfo.m_sTieTiaoList)
		{
			if (sTieTiao == sPark)
			{
				return true;
			}
		}
		return false;
	}

	public bool GetTimeByString(string strTime, out DateTime dt)
	{
		dt = default(DateTime);
		int num = strTime.IndexOf(":", 0);
		if (num != -1)
		{
			string text = strTime.Substring(0, num);
			string text2 = strTime.Substring(num + 1, strTime.Length - num - 1);
			if (text.Length >= 1 && text2.Length >= 1)
			{
				dt = new DateTime(2000, 1, 1, int.Parse(text), int.Parse(text2), 0);
				return true;
			}
			return false;
		}
		return false;
	}

	public bool GetChuFa(JiaoBenInfo jbinfo, DateTime now)
	{
		foreach (DateTime time in jbinfo.m_TimeList)
		{
			if (now.Hour == time.Hour && now.Minute == time.Minute)
			{
				return true;
			}
		}
		return false;
	}

	public JiaoBenInfo ReadJiaoBen(string strFilePath, string sQQNum, string sQQName)
	{
		if (!File.Exists(strFilePath))
		{
			return null;
		}
		JiaoBenInfo jiaoBenInfo = null;
		try
		{
			jiaoBenInfo = new JiaoBenInfo();
			jiaoBenInfo.sQQNum = sQQNum;
			jiaoBenInfo.sQQName = sQQName;
			jiaoBenInfo.sTime = ReadIniData("属性", "触发时间", "", strFilePath);
			jiaoBenInfo.sTieTiaoCheWei = ReadIniData("属性", "贴条", "", strFilePath);
			jiaoBenInfo.sHuiTing = ReadIniData("属性", "被贴车辆自动回停", "", strFilePath);
			jiaoBenInfo.sGuoDu = ReadIniData("属性", "过渡停车场", "", strFilePath);
			jiaoBenInfo.sTingCheShunXu = ReadIniData("属性", "执行顺序", "", strFilePath);
			jiaoBenInfo.sYuanDi = ReadIniData("属性", "原地停车", "", strFilePath);
			jiaoBenInfo.sTingCheChang = ReadIniData("属性", "停车场", "", strFilePath);
			jiaoBenInfo.sTingCheYanShi = ReadIniData("属性", "停车延时", "", strFilePath);
			jiaoBenInfo.sTime = jiaoBenInfo.sTime.Replace("，", ",");
			jiaoBenInfo.sTime = jiaoBenInfo.sTime.Replace("：", ":");
			jiaoBenInfo.sTieTiaoCheWei = jiaoBenInfo.sTieTiaoCheWei.Replace("，", ",");
			jiaoBenInfo.sTingCheShunXu = jiaoBenInfo.sTingCheShunXu.Replace("，", ",");
			jiaoBenInfo.sTingCheChang = jiaoBenInfo.sTingCheChang.Replace("，", ",");
			for (int i = 0; i < 10; i++)
			{
				string section = (i + 1).ToString();
				jiaoBenInfo.m_CheZiInfoList[i].sTingChe = ReadIniData(section, "停车", "", strFilePath);
				jiaoBenInfo.m_CheZiInfoList[i].sHuanChe = ReadIniData(section, "换车", "", strFilePath);
				jiaoBenInfo.m_CheZiInfoList[i].sCarCode = ReadIniData(section, "新车", "", strFilePath);
				jiaoBenInfo.m_CheZiInfoList[i].sColor = ReadIniData(section, "颜色", "", strFilePath);
			}
			string text = "";
			string text2 = jiaoBenInfo.sTime;
			int num = -1;
			while (text2.Length > 1)
			{
				num = text2.IndexOf(",", 0);
				if (num != -1)
				{
					text = text2.Substring(0, num);
					DateTime dt = default(DateTime);
					if (GetTimeByString(text, out dt))
					{
						jiaoBenInfo.m_TimeList.Add(dt);
					}
					text2 = text2.Substring(num + 1, text2.Length - num - 1);
					continue;
				}
				text = text2;
				DateTime dt2 = default(DateTime);
				if (GetTimeByString(text, out dt2))
				{
					jiaoBenInfo.m_TimeList.Add(dt2);
				}
				break;
			}
			text = "";
			num = -1;
			string text3 = jiaoBenInfo.sTieTiaoCheWei;
			while (text3.Length > 0)
			{
				num = text3.IndexOf(",", 0);
				if (num != -1)
				{
					text = text3.Substring(0, num);
					jiaoBenInfo.m_sTieTiaoList.Add(text);
					text3 = text3.Substring(num + 1, text3.Length - num - 1);
					continue;
				}
				text = text3;
				jiaoBenInfo.m_sTieTiaoList.Add(text);
				break;
			}
			text = "";
			num = -1;
			string text4 = jiaoBenInfo.sTingCheShunXu;
			while (text4.Length > 0)
			{
				num = text4.IndexOf(",", 0);
				if (num != -1)
				{
					text = text4.Substring(0, num);
					jiaoBenInfo.m_sTingCheShunXuList.Add(text);
					text4 = text4.Substring(num + 1, text4.Length - num - 1);
					continue;
				}
				text = text4;
				jiaoBenInfo.m_sTingCheShunXuList.Add(text);
				break;
			}
			text = "";
			num = -1;
			string text5 = jiaoBenInfo.sTingCheChang;
			while (text5.Length > 0)
			{
				num = text5.IndexOf(",", 0);
				if (num != -1)
				{
					text = text5.Substring(0, num);
					jiaoBenInfo.m_sTingCheChangList.Add(text);
					text5 = text5.Substring(num + 1, text5.Length - num - 1);
					continue;
				}
				text = text5;
				jiaoBenInfo.m_sTingCheChangList.Add(text);
				return jiaoBenInfo;
			}
			return jiaoBenInfo;
		}
		catch
		{
			return jiaoBenInfo;
		}
	}

	public void WriteJiaoBen(JiaoBenInfo jbinfo, string strFilePath)
	{
		try
		{
			File.Delete(strFilePath);
			WriteIniData("属性", "触发时间", jbinfo.sTime, strFilePath);
			WriteIniData("属性", "贴条", jbinfo.sTieTiaoCheWei, strFilePath);
			WriteIniData("属性", "被贴车辆自动回停", jbinfo.sHuiTing, strFilePath);
			WriteIniData("属性", "过渡停车场", jbinfo.sGuoDu, strFilePath);
			WriteIniData("属性", "执行顺序", jbinfo.sTingCheShunXu, strFilePath);
			WriteIniData("属性", "原地停车", jbinfo.sYuanDi, strFilePath);
			WriteIniData("属性", "停车场", jbinfo.sTingCheChang, strFilePath);
			WriteIniData("属性", "停车延时", jbinfo.sTingCheYanShi, strFilePath);
			for (int i = 0; i < 10; i++)
			{
				string section = (i + 1).ToString();
				WriteIniData(section, "停车", jbinfo.m_CheZiInfoList[i].sTingChe, strFilePath);
				WriteIniData(section, "换车", jbinfo.m_CheZiInfoList[i].sHuanChe, strFilePath);
				WriteIniData(section, "新车", jbinfo.m_CheZiInfoList[i].sCarCode, strFilePath);
				WriteIniData(section, "颜色", jbinfo.m_CheZiInfoList[i].sColor, strFilePath);
			}
		}
		catch
		{
		}
	}
}
