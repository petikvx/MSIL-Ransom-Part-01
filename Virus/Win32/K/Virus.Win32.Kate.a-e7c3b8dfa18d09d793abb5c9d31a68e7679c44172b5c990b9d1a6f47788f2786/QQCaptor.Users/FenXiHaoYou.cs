using System.Collections.ObjectModel;
using System.Text;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class FenXiHaoYou
{
	private User m_use;

	public Collection<AllFriendInfo> m_FriendList = new Collection<AllFriendInfo>();

	public FenXiHaoYou(User use)
	{
		m_use = use;
	}

	public string ProFenXiHaoYou()
	{
		m_FriendList.Clear();
		string text = m_use.m_hh.Get("http://show.qq.com/cgi-bin/qqshow_user_friendgroup", null);
		if (text != null && !(text == string.Empty))
		{
			int startIndex = 0;
			string text2 = null;
			int num = 0;
			int num2 = 0;
			string sQQGroup = null;
			try
			{
				while (true)
				{
					bool flag = false;
					AllFriendInfo allFriendInfo = new AllFriendInfo();
					num = text.IndexOf("group name=", startIndex);
					if (num != -1)
					{
						int num3 = text.IndexOf("friend uin=", startIndex);
						if (num3 == -1 || num3 >= num)
						{
							num2 = text.IndexOf("num=", num);
							if (num != -1 && num2 != -1)
							{
								num += 12;
								startIndex = num2;
								text2 = text.Substring(num, num2 - num - 2);
								if (text2 != null && text2 != string.Empty)
								{
									flag = true;
									sQQGroup = StringChar.ChinaUnicodeToASCII(text2);
								}
							}
						}
					}
					if (!flag)
					{
						num = text.IndexOf("friend uin=", startIndex);
						if (num == -1)
						{
							break;
						}
						num2 = text.IndexOf(" name=", num);
						if (num == -1 || num2 == -1)
						{
							break;
						}
						num += 12;
						startIndex = num2;
						text2 = (allFriendInfo.sQQNum = text.Substring(num, num2 - num - 1));
						num = text.IndexOf(" name=", startIndex);
						if (num == -1)
						{
							break;
						}
						num2 = text.IndexOf(">", num);
						if (num == -1 || num2 == -1)
						{
							break;
						}
						num += 7;
						startIndex = num2;
						text2 = text.Substring(num, num2 - num - 1);
						allFriendInfo.sQQName = StringChar.ChinaUnicodeToASCII(text2);
						allFriendInfo.sQQGroup = sQQGroup;
						m_FriendList.Add(allFriendInfo);
					}
				}
				if (m_FriendList.Count > 0)
				{
					text = m_use.m_hh.Get("http://ic.qzone.qq.com/cgi-bin/feeds/get_remarks_cgi?uin=" + m_use.m_sQQnum, Encoding.Default);
					if (text == null || text == string.Empty)
					{
						return null;
					}
					foreach (AllFriendInfo friend in m_FriendList)
					{
						num = text.IndexOf("\"" + friend.sQQNum + "\"", 0);
						if (num != -1)
						{
							num2 = text.IndexOf(",", num);
							if (num2 != -1)
							{
								num += friend.sQQNum.Length + 4;
								startIndex = num2;
								text2 = (friend.sQQNick = text.Substring(num, num2 - num - 1));
							}
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}
		return null;
	}

	public string ProFenXiHaoYouGuanXi(string strQQNum, User use)
	{
		string text = use.m_hh.Post("http://show.qq.com/cgi-bin/qqshow_noname_info", "uin=" + strQQNum + "&friend=1");
		if (text != null && !(text == string.Empty))
		{
			string result = "正常";
			long num = text.IndexOf("xfriend=\"0\"", 0);
			if (num > -1L)
			{
				result = "你不是TA的好友";
			}
			return result;
		}
		return "-";
	}
}
