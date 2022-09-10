using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace QQCaptor.Tools;

internal class FilePro
{
	private SymmetricMethod sm = new SymmetricMethod();

	public static Collection<UserInfo> m_UserList = new Collection<UserInfo>();

	public static Collection<string> m_FriendList = new Collection<string>();

	private string m_sFilePath;

	private string m_strFriendDir;

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

	public void SetFilePath(string sFilePath)
	{
		m_sFilePath = sFilePath;
	}

	public int GetCount()
	{
		return m_UserList.Count;
	}

	public void DaoChuTxt(string sFilePath)
	{
		File.Delete(sFilePath);
		StreamWriter streamWriter = new StreamWriter(sFilePath, append: true);
		foreach (UserInfo user in m_UserList)
		{
			string qQNum = StringChar.GetQQNum(user.sQQNum);
			if (qQNum != null && qQNum != string.Empty)
			{
				string sQQPass = user.sQQPass;
				streamWriter.WriteLine(qQNum + "----" + sQQPass);
			}
		}
		streamWriter.Close();
	}

	public void ReadAll()
	{
		int num = 1;
		while (true)
		{
			string section = "User" + num++;
			string text = ReadIniData(section, "qq", "", m_sFilePath);
			if (text != null && text != string.Empty && text != "" && text.Length > 3)
			{
				string source = ReadIniData(section, "pass", "", m_sFilePath);
				UserInfo userInfo = new UserInfo();
				userInfo.sQQNum = text;
				userInfo.sQQPass = sm.Decrypto(source);
				m_UserList.Add(userInfo);
				continue;
			}
			break;
		}
	}

	public void AddUser(string sQQNumNick, string sQQPass)
	{
		int num = 1;
		string qQNum = StringChar.GetQQNum(sQQNumNick);
		foreach (UserInfo user in m_UserList)
		{
			if (!(StringChar.GetQQNum(user.sQQNum) == qQNum))
			{
				num++;
				continue;
			}
			if (user.sQQPass != sQQPass || sQQNumNick != user.sQQNum)
			{
				user.sQQNum = sQQNumNick;
				user.sQQPass = sQQPass;
				string section = "User" + num;
				WriteIniData(section, "qq", sQQNumNick, m_sFilePath);
				WriteIniData(section, "pass", sm.Encrypto(sQQPass), m_sFilePath);
			}
			return;
		}
		UserInfo userInfo = new UserInfo();
		userInfo.sQQNum = sQQNumNick;
		userInfo.sQQPass = sQQPass;
		m_UserList.Add(userInfo);
		string section2 = "User" + m_UserList.Count;
		WriteIniData(section2, "qq", sQQNumNick, m_sFilePath);
		WriteIniData(section2, "pass", sm.Encrypto(sQQPass), m_sFilePath);
	}

	public void DeleteUser(string sQQNum)
	{
		foreach (UserInfo user in m_UserList)
		{
			if (StringChar.GetQQNum(user.sQQNum) == StringChar.GetQQNum(sQQNum))
			{
				m_UserList.Remove(user);
				break;
			}
		}
		File.Delete(m_sFilePath);
		int num = 1;
		foreach (UserInfo user2 in m_UserList)
		{
			string section = "User" + num++;
			WriteIniData(section, "qq", user2.sQQNum, m_sFilePath);
			WriteIniData(section, "pass", sm.Encrypto(user2.sQQPass), m_sFilePath);
		}
	}

	public UserInfo GetUserInfo(string sQQNum)
	{
		foreach (UserInfo user in m_UserList)
		{
			if (user.sQQNum == sQQNum)
			{
				return user;
			}
		}
		return null;
	}

	public UserInfo GetUserInfo(int iIndex)
	{
		int num = 0;
		foreach (UserInfo user in m_UserList)
		{
			if (num != iIndex)
			{
				num++;
				continue;
			}
			return user;
		}
		return null;
	}

	public void WriteLog(string sLog, string sFilePath)
	{
		if (sFilePath != null)
		{
			StreamWriter streamWriter = new StreamWriter(sFilePath, append: true);
			streamWriter.Write(sLog);
			streamWriter.Flush();
			streamWriter.Close();
		}
	}

	public bool AddJunDaoUser(string sQQNumNick, string sQQPass)
	{
		string qQNum = StringChar.GetQQNum(sQQNumNick);
		foreach (UserInfo user in m_UserList)
		{
			if (StringChar.GetQQNum(user.sQQNum) == qQNum)
			{
				return false;
			}
		}
		UserInfo userInfo = new UserInfo();
		userInfo.sQQNum = sQQNumNick;
		userInfo.sQQPass = sQQPass;
		m_UserList.Add(userInfo);
		string section = "User" + m_UserList.Count;
		WriteIniData(section, "qq", sQQNumNick, m_sFilePath);
		WriteIniData(section, "pass", sm.Encrypto(sQQPass), m_sFilePath);
		return true;
	}

	public bool ReadJunDao(string sFilePath)
	{
		bool result = false;
		bool flag = false;
		StreamReader streamReader = new StreamReader(sFilePath, Encoding.Default);
		while (!streamReader.EndOfStream)
		{
			string text = streamReader.ReadLine();
			if (flag && text.IndexOf("[") != -1 && text.IndexOf("]") != -1)
			{
				break;
			}
			if (flag)
			{
				text = text.Replace("=", " [");
				text += "]";
				if (AddJunDaoUser(text, ""))
				{
					result = true;
				}
			}
			if (text.IndexOf("[昵称]") != -1)
			{
				flag = true;
			}
		}
		streamReader.Close();
		return result;
	}

	public void SetFriendDir(string strDir)
	{
		m_strFriendDir = strDir;
	}

	public void DeleteFriendFile(string strQQNum)
	{
		File.Delete(m_strFriendDir + strQQNum + ".ini");
	}

	public void AddFriend(string strQQNum, string strQQNumFriend)
	{
		int num = 0;
		while (true)
		{
			if (num < m_FriendList.Count)
			{
				string text = m_FriendList[num];
				if (!(text == strQQNumFriend))
				{
					num++;
					continue;
				}
				break;
			}
			File.AppendAllText(m_strFriendDir + strQQNum + ".ini", strQQNumFriend + "\r\n");
			break;
		}
	}

	public void ReadFriend(string strQQNum)
	{
		m_FriendList.Clear();
		if (File.Exists(m_strFriendDir + strQQNum + ".ini"))
		{
			StreamReader streamReader = new StreamReader(m_strFriendDir + strQQNum + ".ini", Encoding.Default);
			while (!streamReader.EndOfStream)
			{
				string item = streamReader.ReadLine();
				m_FriendList.Add(item);
			}
			streamReader.Close();
		}
	}

	public string ReadFriendToJiaoBen(string strQQNum)
	{
		m_FriendList.Clear();
		if (!File.Exists(m_strFriendDir + strQQNum + ".ini"))
		{
			return "";
		}
		string text = "";
		StreamReader streamReader = new StreamReader(m_strFriendDir + strQQNum + ".ini", Encoding.Default);
		while (!streamReader.EndOfStream)
		{
			string text2 = streamReader.ReadLine();
			text = (streamReader.EndOfStream ? (text + text2) : (text + text2 + ","));
		}
		streamReader.Close();
		return text;
	}

	public void ClearFriend()
	{
		m_FriendList.Clear();
	}

	public int GetFriendCount()
	{
		return m_FriendList.Count;
	}

	public string GetFriendByIndex(int iIndex)
	{
		if (iIndex < m_FriendList.Count)
		{
			return m_FriendList[iIndex];
		}
		return null;
	}

	public bool FindFriend(string strQQNumFriend)
	{
		foreach (string friend in m_FriendList)
		{
			if (friend == strQQNumFriend)
			{
				return true;
			}
		}
		return false;
	}

	public bool AddTxtUser(string sQQNumNick, string sQQPass)
	{
		sQQNumNick = sQQNumNick.Trim();
		sQQPass = sQQPass.Trim();
		string qQNum = StringChar.GetQQNum(sQQNumNick);
		foreach (UserInfo user in m_UserList)
		{
			if (StringChar.GetQQNum(user.sQQNum) == qQNum)
			{
				return false;
			}
		}
		UserInfo userInfo = new UserInfo();
		userInfo.sQQNum = sQQNumNick;
		userInfo.sQQPass = sQQPass;
		m_UserList.Add(userInfo);
		string section = "User" + m_UserList.Count;
		WriteIniData(section, "qq", sQQNumNick, m_sFilePath);
		WriteIniData(section, "pass", sm.Encrypto(sQQPass), m_sFilePath);
		return true;
	}

	public bool ReadTxt(string sFilePath)
	{
		bool result = false;
		try
		{
			StreamReader streamReader = new StreamReader(sFilePath, Encoding.Default);
			while (!streamReader.EndOfStream)
			{
				string text = streamReader.ReadLine();
				if (text == null || text.Length <= 1)
				{
					continue;
				}
				int num = text.IndexOf("----");
				if (num != -1)
				{
					string sQQNumNick = text.Substring(0, num);
					string sQQPass = text.Substring(num + 4, text.Length - num - 4);
					if (AddTxtUser(sQQNumNick, sQQPass))
					{
						result = true;
					}
					continue;
				}
				num = text.IndexOf(" ");
				if (num != -1)
				{
					string sQQNumNick2 = text.Substring(0, num);
					string sQQPass2 = text.Substring(num + 1, text.Length - num - 1);
					if (AddTxtUser(sQQNumNick2, sQQPass2))
					{
						result = true;
					}
				}
				else if (AddTxtUser(text, ""))
				{
					result = true;
				}
			}
			streamReader.Close();
			return result;
		}
		catch
		{
			return false;
		}
	}

	public Collection<DhUserInfo> ReadDhUserList(string strFilePath)
	{
		Collection<DhUserInfo> collection = new Collection<DhUserInfo>();
		int num = 1;
		while (true)
		{
			string section = "User" + num++;
			string text = ReadIniData(section, "Num", "", strFilePath);
			string sQQName = ReadIniData(section, "Name", "", strFilePath);
			if (text == null || !(text != string.Empty) || !(text != "") || text.Length <= 3)
			{
				break;
			}
			DhUserInfo dhUserInfo = new DhUserInfo();
			dhUserInfo.sQQNum = text;
			dhUserInfo.sQQName = sQQName;
			collection.Add(dhUserInfo);
		}
		return collection;
	}

	public void AddDhUser(string strFilePath, Collection<DhUserInfo> DhUserList, string sQQNum, string sQQName)
	{
		string section = "User" + DhUserList.Count;
		WriteIniData(section, "Num", sQQNum, strFilePath);
		WriteIniData(section, "Name", sQQName, strFilePath);
	}

	public void WriteDhUser(string strFilePath, Collection<DhUserInfo> DhUserList)
	{
		File.Delete(strFilePath);
		int num = 1;
		foreach (DhUserInfo DhUser in DhUserList)
		{
			string section = "User" + num++;
			WriteIniData(section, "Num", DhUser.sQQNum, strFilePath);
			WriteIniData(section, "Name", DhUser.sQQName, strFilePath);
		}
	}

	public Collection<JbUserInfo> ReadJbUserList(string strFilePath)
	{
		Collection<JbUserInfo> collection = new Collection<JbUserInfo>();
		int num = 1;
		while (true)
		{
			string section = "User" + num++;
			string text = ReadIniData(section, "Num", "", strFilePath);
			string sQQName = ReadIniData(section, "Name", "", strFilePath);
			string text2 = ReadIniData(section, "Cars", "", strFilePath);
			if (text == null || !(text != string.Empty) || !(text != "") || text.Length <= 3)
			{
				break;
			}
			JbUserInfo jbUserInfo = new JbUserInfo();
			jbUserInfo.sQQNum = text;
			jbUserInfo.sQQName = sQQName;
			jbUserInfo.sCars = text2;
			try
			{
				string text3 = "";
				int num2 = -1;
				string text4 = text2;
				while (text4.Length > 0)
				{
					num2 = text4.IndexOf(",", 0);
					if (num2 != -1)
					{
						text3 = text4.Substring(0, num2);
						jbUserInfo.m_sCarList.Add(text3);
						text4 = text4.Substring(num2 + 1, text4.Length - num2 - 1);
						continue;
					}
					text3 = text4;
					jbUserInfo.m_sCarList.Add(text3);
					break;
				}
			}
			catch
			{
			}
			collection.Add(jbUserInfo);
		}
		return collection;
	}

	public void AddJbUser(string strFilePath, Collection<JbUserInfo> JbUserList, string sQQNum, string sQQName, string sCars)
	{
		string section = "User" + JbUserList.Count;
		WriteIniData(section, "Num", sQQNum, strFilePath);
		WriteIniData(section, "Name", sQQName, strFilePath);
		WriteIniData(section, "Cars", sCars, strFilePath);
	}

	public void WriteJbUser(string strFilePath, Collection<JbUserInfo> JbUserList)
	{
		File.Delete(strFilePath);
		int num = 1;
		foreach (JbUserInfo JbUser in JbUserList)
		{
			string section = "User" + num++;
			WriteIniData(section, "Num", JbUser.sQQNum, strFilePath);
			WriteIniData(section, "Name", JbUser.sQQName, strFilePath);
			WriteIniData(section, "Cars", JbUser.sCars, strFilePath);
		}
	}
}
