using System;
using System.Collections.ObjectModel;

namespace QQCaptor.Tools;

public class JiaoBenInfo
{
	public string sQQNum;

	public string sQQName;

	public string sTime = "";

	public string sTieTiaoCheWei = "";

	public string sHuiTing = "0";

	public string sGuoDu = "";

	public string sTingCheShunXu = "";

	public string sYuanDi = "0";

	public string sTingCheChang = "";

	public string sTingCheYanShi = "";

	public Collection<CheZiInfo> m_CheZiInfoList = new Collection<CheZiInfo>();

	public Collection<DateTime> m_TimeList = new Collection<DateTime>();

	public Collection<string> m_sTieTiaoList = new Collection<string>();

	public Collection<string> m_sTingCheShunXuList = new Collection<string>();

	public Collection<string> m_sTingCheChangList = new Collection<string>();

	public Collection<JbUserInfo> m_RunJbUserList = new Collection<JbUserInfo>();

	public JiaoBenInfo()
	{
		for (int i = 0; i < 10; i++)
		{
			CheZiInfo item = new CheZiInfo();
			m_CheZiInfoList.Add(item);
		}
	}
}
