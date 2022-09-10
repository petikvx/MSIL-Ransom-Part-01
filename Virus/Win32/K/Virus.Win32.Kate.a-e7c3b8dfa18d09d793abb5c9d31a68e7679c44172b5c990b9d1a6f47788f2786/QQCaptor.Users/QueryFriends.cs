using System.Collections.ObjectModel;
using QQCaptor.Tools;

namespace QQCaptor.Users;

internal class QueryFriends
{
	private User m_use;

	private string m_getAllInfo;

	public Collection<FriendInfo> m_friendInfoList = new Collection<FriendInfo>();

	public QueryFriends()
	{
	}

	public QueryFriends(User use)
	{
		m_use = use;
	}

	public bool QueryFriendsInfo()
	{
		m_use.LingQuJiangJin();
		string text = m_use.m_hh.Post("http://world.show.qq.com/cgi-bin/parker_user_friendpark", "");
		m_friendInfoList.Clear();
		m_getAllInfo = text;
		int startIndex = 0;
		string text2 = null;
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		while (true)
		{
			FriendInfo friendInfo = new FriendInfo();
			friendInfo.Id = num3++;
			num = text.IndexOf(" uin=", startIndex);
			if (num == -1)
			{
				break;
			}
			num2 = text.IndexOf(" cash=", num);
			if (num == -1 || num2 == -1)
			{
				break;
			}
			num += 6;
			startIndex = num2;
			text2 = text.Substring(num, num2 - num - 1);
			friendInfo.QQNum = text2.Trim();
			num = text.IndexOf(" cash=", startIndex);
			if (num == -1)
			{
				break;
			}
			num2 = text.IndexOf(" carprice=", num);
			if (num == -1 || num2 == -1)
			{
				break;
			}
			num += 7;
			startIndex = num2;
			text2 = (friendInfo.Cash = text.Substring(num, num2 - num - 1));
			num = text.IndexOf(" carprice=", startIndex);
			if (num == -1)
			{
				break;
			}
			num2 = text.IndexOf(" full=", num);
			if (num == -1 || num2 == -1)
			{
				break;
			}
			num += 11;
			startIndex = num2;
			text2 = (friendInfo.CarPrice = text.Substring(num, num2 - num - 1));
			num = text.IndexOf(" full=", startIndex);
			if (num == -1)
			{
				break;
			}
			num2 = text.IndexOf(" nick=", num);
			if (num == -1 || num2 == -1)
			{
				break;
			}
			num += 7;
			startIndex = num2;
			text2 = text.Substring(num, num2 - num - 1);
			friendInfo.full = StringChar.SToInt(text2);
			num = text.IndexOf(" nick=", startIndex);
			if (num == -1)
			{
				break;
			}
			num2 = text.IndexOf(" score=", num);
			if (num == -1 || num2 == -1)
			{
				break;
			}
			num += 7;
			startIndex = num2;
			text2 = text.Substring(num, num2 - num - 1);
			friendInfo.QQName = StringChar.ChinaUnicodeToASCII(text2);
			num = text.IndexOf(" isDirty=", startIndex);
			if (num == -1)
			{
				break;
			}
			num2 = text.IndexOf("</user>", num);
			if (num == -1 || num2 == -1)
			{
				break;
			}
			num += 10;
			startIndex = num2;
			text2 = text.Substring(num, num2 - num - 3);
			friendInfo.isDirty = StringChar.SToInt(text2);
			m_friendInfoList.Add(friendInfo);
		}
		return true;
	}

	public long GetCount()
	{
		return m_friendInfoList.Count;
	}

	public FriendInfo GetFriendInfo(int iIndex)
	{
		int num = 0;
		foreach (FriendInfo friendInfo in m_friendInfoList)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return friendInfo;
		}
		return null;
	}
}
