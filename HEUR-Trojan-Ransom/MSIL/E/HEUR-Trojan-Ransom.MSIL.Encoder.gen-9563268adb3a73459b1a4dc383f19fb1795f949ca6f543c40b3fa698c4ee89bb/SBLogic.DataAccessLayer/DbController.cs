using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using PinBot;
using SBLogic.LogicLayer;

namespace SBLogic.DataAccessLayer;

public class DbController
{
	private string direc = Environment.CurrentDirectory + "\\";

	private string groups = "App\\groups.txt";

	private string projects = "App\\projects.txt";

	private string accounts = "Accounts\\";

	private string posts = "App\\posts";

	private CHelperFunctions cHelper = new CHelperFunctions();

	public DbController()
	{
		if (!Directory.Exists(direc))
		{
			Directory.CreateDirectory(direc);
		}
		if (!Directory.Exists(direc + "App\\"))
		{
			Directory.CreateDirectory(direc + "App\\");
		}
		if (!Directory.Exists(direc + "App\\Logs"))
		{
			Directory.CreateDirectory(direc + "App\\Logs");
		}
		groups = direc + groups;
		projects = direc + projects;
		accounts = direc + accounts;
		posts = direc + posts;
	}

	public string GetActivePostCount()
	{
		string path = direc + "App\\Count.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllText(path);
	}

	public void WriteCount(string count)
	{
		string path = direc + "App\\Count.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public List<string> GetGroups()
	{
		try
		{
			if (!File.Exists(groups))
			{
				File.Create(groups).Close();
			}
			return File.ReadAllLines(groups).ToList();
		}
		catch (Exception)
		{
			try
			{
				return File.ReadAllLines(groups).ToList();
			}
			catch (Exception)
			{
			}
			return File.ReadAllLines(groups).ToList();
		}
	}

	public uint GetTimeInSeconds(DateTime dt)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
		return (uint)(dt - dateTime).TotalMilliseconds;
	}

	public void UpdateGroup(uint uIGroupId, string strGroupName)
	{
		string text = "";
		try
		{
			if (!File.Exists(groups))
			{
				File.Create(groups).Close();
			}
			string[] array = File.ReadAllLines(groups);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				string[] array3 = text2.Split(new char[1] { ';' });
				if (array3[0] == uIGroupId.ToString())
				{
					text = text + uIGroupId + ";" + strGroupName;
					for (int j = 2; j < array3.Length; j++)
					{
						text = text + ";" + array3[j].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
							.TrimEnd(new char[0]);
					}
					text += Environment.NewLine;
				}
				else
				{
					text = text + text2 + Environment.NewLine;
				}
			}
			File.WriteAllText(groups, text, Encoding.Default);
		}
		catch (Exception)
		{
			Thread.Sleep(5000);
			try
			{
				File.WriteAllText(groups, text, Encoding.Default);
			}
			catch
			{
			}
		}
	}

	public void UpdateGroupData(uint uIGroupId, string strGroupData)
	{
		string text = "";
		try
		{
			if (!File.Exists(groups))
			{
				File.Create(groups).Close();
			}
			string[] array = File.ReadAllLines(groups);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				string[] array3 = text2.Split(new char[1] { ';' });
				string[] array4 = strGroupData.Split(new char[1] { ';' });
				if (array3[0] == uIGroupId.ToString())
				{
					text += uIGroupId;
					for (int j = 1; j < array4.Length; j++)
					{
						text = text + ";" + array4[j].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
							.TrimEnd(new char[0]);
					}
					text += Environment.NewLine;
				}
				else
				{
					text = text + text2 + Environment.NewLine;
				}
			}
			File.WriteAllText(groups, text, Encoding.Default);
		}
		catch (Exception)
		{
			File.WriteAllText(groups, text, Encoding.Default);
		}
	}

	public void DeleteGroup(uint uIGroupId, string strGroupName)
	{
		try
		{
			if (!File.Exists(groups))
			{
				File.Create(groups).Close();
			}
			string text = "";
			string[] array = File.ReadAllLines(groups);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (!(text2.Split(new char[1] { ';' })[0] == uIGroupId.ToString()))
				{
					text = text + text2 + Environment.NewLine;
				}
			}
			File.WriteAllText(groups, text, Encoding.Default);
		}
		catch (Exception)
		{
		}
	}

	public uint GetGroupIdOfName(string p)
	{
		uint result = 0u;
		if (!File.Exists(groups))
		{
			File.Create(groups).Close();
		}
		string[] array = File.ReadAllLines(groups);
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.Split(new char[1] { ';' })[1] == p.ToString())
			{
				result = uint.Parse(text.Split(new char[1] { ';' })[0]);
			}
		}
		return result;
	}

	public string GetGroupDataOfName(string p)
	{
		if (!File.Exists(groups))
		{
			File.Create(groups).Close();
		}
		string[] array = File.ReadAllLines(groups);
		string[] array2 = array;
		int num = 0;
		string text;
		while (true)
		{
			if (num < array2.Length)
			{
				text = array2[num];
				if (text.Split(new char[1] { ';' })[1] == p.ToString())
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return text;
	}

	public string GetGroupNameOfId(string Id)
	{
		string result = "";
		if (!File.Exists(groups))
		{
			File.Create(groups).Close();
		}
		string[] array = File.ReadAllLines(groups);
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.Split(new char[1] { ';' })[0] == Id.ToString())
			{
				result = text.Split(new char[1] { ';' })[1];
			}
		}
		return result;
	}

	public void InsertNewGroup(uint iId, string strGroupName, string groupType)
	{
		if (!File.Exists(groups))
		{
			File.Create(groups).Close();
		}
		string contents = iId + ";" + strGroupName + ";" + groupType + Environment.NewLine;
		File.AppendAllText(groups, contents);
		if (!Directory.Exists(direc + "Accounts\\" + strGroupName))
		{
			Directory.CreateDirectory(direc + "Accounts\\" + strGroupName);
		}
	}

	public void InsertNewGroup(string strGroupName, string text)
	{
		try
		{
			if (!File.Exists(groups))
			{
				File.Create(groups).Close();
			}
			File.AppendAllText(groups, text);
			if (!Directory.Exists(direc + "Accounts\\" + strGroupName))
			{
				Directory.CreateDirectory(direc + "Accounts\\" + strGroupName);
			}
		}
		catch (Exception)
		{
		}
	}

	public void CopyFiles(string strGroupName, string file, string source)
	{
		if (!File.Exists(groups))
		{
			File.Create(groups).Close();
		}
		if (!Directory.Exists(direc + "Accounts\\" + strGroupName))
		{
			Directory.CreateDirectory(direc + "Accounts\\" + strGroupName);
		}
		File.Copy(source, direc + "Accounts\\" + strGroupName + "\\" + file, overwrite: true);
	}

	public void LogData(string strGroupName, string account, string source)
	{
		try
		{
			string text = direc + "Accounts\\" + strGroupName + "\\LoginLogs";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = account.Replace("@", "_").Replace(".", "_");
			text2 += ".html";
			File.WriteAllText(text + "\\" + text2, source);
		}
		catch (Exception)
		{
		}
	}

	public void AppendFiles(string strGroupName, string file, string source)
	{
		if (!File.Exists(groups))
		{
			File.Create(groups).Close();
		}
		if (!Directory.Exists(direc + "Accounts\\" + strGroupName))
		{
			Directory.CreateDirectory(direc + "Accounts\\" + strGroupName);
		}
		string text = "";
		if (File.Exists(source))
		{
			text = File.ReadAllText(source);
		}
		if (text != "")
		{
			File.AppendAllText(direc + "Accounts\\" + strGroupName + "\\" + file, Environment.NewLine + text);
		}
	}

	public List<string> GetProjects()
	{
		if (!File.Exists(projects))
		{
			File.Create(projects).Close();
		}
		return File.ReadAllLines(projects).ToList();
	}

	public string getLastRotatingIndex(string projectId)
	{
		string path = direc + "App\\rotate.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string text = File.ReadAllText(path);
		if (text.Contains(projectId))
		{
			return cHelper.GetStringBetween(text, projectId + "=", ";");
		}
		return "0";
	}

	public void RotatingLinks(string projectId, string index)
	{
		string path = direc + "App\\rotate.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string text = File.ReadAllText(path);
		if (text.Contains(projectId))
		{
			string stringBetween = cHelper.GetStringBetween(text, projectId + "=", ";");
			text = text.Replace(projectId + "=" + stringBetween + ";" + Environment.NewLine, projectId + "=" + index + ";" + Environment.NewLine);
			File.WriteAllText(path, text);
		}
		else
		{
			File.AppendAllText(path, projectId + "=" + index + ";" + Environment.NewLine);
		}
	}

	public void InsertAccValues(AccountDetail AccD, string strGroupName)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName))
			{
				Directory.CreateDirectory(accounts + strGroupName);
			}
			string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			if (AccD.BoardText == null)
			{
				AccD.BoardText = "";
			}
			if (AccD.AutoBoardText == null)
			{
				AccD.AutoBoardText = "";
			}
			if (AccD.UserAgent != null && AccD.UserAgent != "")
			{
				AccD.TestAccountStatus = AccD.UserAgent;
			}
			string contents = AccD.id + ";" + AccD.Checked.ToString() + ";" + AccD.TestAccountStatus.Replace(";", "??") + ";" + AccD.UserNameTemp + ";" + AccD.Password.Replace(";", "``") + ";" + AccD.TumblrUrl + ";" + AccD.PageAuth + ";" + AccD.TrustFlow + ";" + AccD.Notes + ";" + AccD.ProxyIP + ";" + AccD.ProxyPort + ";" + AccD.ProxyUsername + ";" + AccD.ProxyPassword + ";" + AccD.Cookies + ";" + AccD.FollowChecked.ToString() + ";" + AccD.UnfollowChecked.ToString() + ";" + AccD.RetweetChecked.ToString() + ";" + AccD.StartTime + ";" + AccD.EndTime + ";" + AccD.LikeChecked.ToString() + ";" + AccD.ShortenUrlChecked.ToString() + ";" + AccD.ShortenUrl + ";;;;;" + AccD.DateAdded + ";;" + AccD.BoardText + ";" + AccD.AutoBoardText + Environment.NewLine;
			File.AppendAllText(path, contents);
			AccD.TestAccountStatus = "";
		}
		catch (Exception)
		{
		}
	}

	public void RenameGroupName(string oldName, string newName)
	{
		string path = accounts + oldName + "\\account-" + oldName.Replace(' ', '_') + ".txt";
		if (File.Exists(path))
		{
			string contents = File.ReadAllText(path);
			File.Delete(path);
			path = accounts + newName + "\\account-" + newName.Replace(' ', '_') + ".txt";
			if ((accounts + oldName).ToLower() != (accounts + newName).ToLower())
			{
				Directory.Move(accounts + oldName, accounts + newName);
			}
			File.WriteAllText(path, contents);
		}
	}

	public void DeleteGroupData(string oldName)
	{
		string path = accounts + oldName + "\\account-" + oldName.Replace(' ', '_') + ".txt";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	public string[] GetAllAccsOfAGroup(string strGroupName)
	{
		strGroupName = strGroupName.Replace(' ', '_');
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\account-" + strGroupName + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllLines(path);
	}

	public string GetLikeCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\LikeUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetAutoFollowCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoFollowUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetFollowCount(string strGroupName)
	{
		int num = 0;
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\FollowUrls.txt";
		if (File.Exists(path))
		{
			num += (from line in File.ReadLines(path)
				where line != ""
				select line).Count();
		}
		path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\TempFollowUrls.txt";
		if (File.Exists(path))
		{
			num += (from line in File.ReadLines(path)
				where line != ""
				select line).Count();
		}
		return num.ToString();
	}

	public string GetAutoTweetUrlsCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoTweetUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetRetweetCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\RetweetUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetTweetCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\TweetUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetKeywordsCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoFollowKeywords.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetAutoTweetKeywordsCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoTweetUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetAutoSaveKeywordsCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoSavePinKeywords.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetAutoSaveUrlsCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoSavePinsUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetAutoPinUrlsCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\AutoPinsUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public string GetTweetRepliesCount(string strGroupName)
	{
		string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\ReplyUrls.txt";
		if (File.Exists(path))
		{
			return (from line in File.ReadLines(path)
				where line != ""
				select line).ToList().Count.ToString();
		}
		return "0";
	}

	public List<AccountDetail> GetAccsOfAGroup(string strGroupName, string type)
	{
		List<AccountDetail> list = new List<AccountDetail>();
		try
		{
			if (strGroupName != "All")
			{
				strGroupName = strGroupName.Replace(' ', '_');
				string path = accounts + "\\" + strGroupName.Replace('_', ' ') + "\\account-" + strGroupName + ".txt";
				if (!File.Exists(path))
				{
					File.Create(path).Close();
				}
				string[] array = File.ReadAllLines(path);
				string[] array2 = array;
				foreach (string text in array2)
				{
					AccountDetail accountDetail = new AccountDetail();
					string[] array3 = text.Split(new char[1] { ';' });
					if (array3.Length < 5)
					{
						continue;
					}
					for (int j = 0; j < array3.Length; j++)
					{
						array3[j] = array3[j].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
							.TrimEnd(new char[0]);
					}
					string[] array4 = new string[29];
					if (array3.Length >= 31)
					{
						for (int k = 0; k < array3.Length; k++)
						{
							if (k == 4)
							{
								array4[k] = array3[k].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
									.TrimEnd(new char[0]) + ";" + array3[k + 1].TrimStart(new char[0]).TrimEnd(new char[0]);
								k++;
							}
							else if (k < 4)
							{
								array4[k] = array3[k].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
									.TrimEnd(new char[0]);
							}
							else if (k > 5)
							{
								array4[k - 1] = array3[k].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
									.TrimEnd(new char[0]);
							}
						}
					}
					else
					{
						array4 = array3;
					}
					accountDetail.id = uint.Parse(array4[0]);
					accountDetail.Checked = Convert.ToBoolean(array4[1]);
					accountDetail.UserAgent = array4[2].Replace("??", ";");
					accountDetail.TestAccountStatus = "";
					accountDetail.UserNameTemp = array4[3];
					accountDetail.Password = array4[4].Replace("``", ";");
					accountDetail.TumblrUrl = array4[5];
					accountDetail.PageAuth = array4[6];
					accountDetail.GroupName = strGroupName.Replace('_', ' ');
					accountDetail.TrustFlow = array4[7];
					accountDetail.Notes = array4[8];
					accountDetail.ProxyIP = array4[9];
					accountDetail.ProxyPort = array4[10];
					accountDetail.ProxyUsername = array4[11];
					accountDetail.ProxyPassword = array4[12];
					if (array4.Length >= 14)
					{
						accountDetail.Cookies = array4[13];
					}
					if (array4.Length >= 19)
					{
						accountDetail.FollowChecked = bool.Parse(array4[14]);
						accountDetail.UnfollowChecked = bool.Parse(array4[15]);
						accountDetail.RetweetChecked = bool.Parse(array4[16]);
						accountDetail.StartTime = array4[17];
						accountDetail.EndTime = array4[18];
						if (array4.Length >= 20)
						{
							accountDetail.LikeChecked = bool.Parse(array4[19]);
						}
						else
						{
							accountDetail.LikeChecked = true;
						}
						if (array4.Length >= 22)
						{
							accountDetail.ShortenUrlChecked = bool.Parse(array4[20]);
							accountDetail.ShortenUrl = array4[21];
						}
						else
						{
							accountDetail.ShortenUrlChecked = false;
						}
						if (array4.Length >= 26)
						{
							accountDetail.PostsCount = array4[22].TrimEnd(new char[0]);
							accountDetail.LikesCount = array4[23].TrimEnd(new char[0]);
							accountDetail.FollowingCount = array4[24].TrimEnd(new char[0]);
							accountDetail.FollowersCount = array4[25].TrimEnd(new char[0]);
						}
						if (array4.Length >= 27)
						{
							accountDetail.DateAdded = array4[26].TrimStart(new char[0]).TrimEnd(new char[0]);
						}
						if (array4.Length >= 28)
						{
							accountDetail.OldStartTime = array4[27].TrimStart(new char[0]).TrimEnd(new char[0]);
						}
						if (array4.Length >= 29)
						{
							accountDetail.BoardText = array4[28].TrimStart(new char[0]).TrimEnd(new char[0]);
						}
						if (array4.Length >= 30)
						{
							accountDetail.AutoBoardText = array4[29].TrimStart(new char[0]).TrimEnd(new char[0]);
						}
					}
					list.Add(accountDetail);
				}
			}
			else if (File.Exists(groups))
			{
				string[] array5 = File.ReadAllLines(groups);
				string[] array6 = array5;
				foreach (string text2 in array6)
				{
					string text3 = text2.Split(new char[1] { ';' })[1];
					if (text2.Split(new char[1] { ';' }).Length <= 2 || !(text2.Split(new char[1] { ';' })[2] == type) || !File.Exists(accounts + text3 + "\\account-" + text3.Replace(' ', '_') + ".txt"))
					{
						continue;
					}
					string[] array7 = File.ReadAllLines(accounts + text3 + "\\account-" + text3.Replace(' ', '_') + ".txt");
					string[] array8 = array7;
					foreach (string text4 in array8)
					{
						AccountDetail accountDetail2 = new AccountDetail();
						string[] array9 = text4.Split(new char[1] { ';' });
						if (array9.Length < 5)
						{
							continue;
						}
						for (int n = 0; n < array9.Length; n++)
						{
							array9[n] = array9[n].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
								.TrimEnd(new char[0]);
						}
						accountDetail2.id = uint.Parse(array9[0]);
						accountDetail2.Checked = Convert.ToBoolean(array9[1]);
						accountDetail2.TestAccountStatus = "";
						accountDetail2.UserAgent = array9[2].Replace("??", ";");
						accountDetail2.UserNameTemp = array9[3];
						accountDetail2.Password = array9[4].Replace("``", ";");
						accountDetail2.TumblrUrl = array9[5];
						accountDetail2.PageAuth = array9[6];
						accountDetail2.GroupName = text3;
						accountDetail2.TrustFlow = array9[7];
						accountDetail2.Notes = array9[8];
						accountDetail2.ProxyIP = array9[9];
						accountDetail2.ProxyPort = array9[10];
						accountDetail2.ProxyUsername = array9[11];
						accountDetail2.ProxyPassword = array9[12];
						if (array9.Length >= 14)
						{
							accountDetail2.Cookies = array9[13];
						}
						if (array9.Length >= 19)
						{
							accountDetail2.FollowChecked = bool.Parse(array9[14]);
							accountDetail2.UnfollowChecked = bool.Parse(array9[15]);
							accountDetail2.RetweetChecked = bool.Parse(array9[16]);
							accountDetail2.StartTime = array9[17];
							accountDetail2.EndTime = array9[18];
							if (array9.Length >= 20)
							{
								accountDetail2.LikeChecked = bool.Parse(array9[19]);
							}
							else
							{
								accountDetail2.LikeChecked = true;
							}
							if (array9.Length >= 22)
							{
								accountDetail2.ShortenUrlChecked = bool.Parse(array9[20]);
								accountDetail2.ShortenUrl = array9[21];
							}
							else
							{
								accountDetail2.ShortenUrlChecked = false;
							}
							if (array9.Length >= 26)
							{
								accountDetail2.PostsCount = array9[22].TrimEnd(new char[0]);
								accountDetail2.LikesCount = array9[23].TrimEnd(new char[0]);
								accountDetail2.FollowingCount = array9[24].TrimEnd(new char[0]);
								accountDetail2.FollowersCount = array9[25].TrimEnd(new char[0]);
							}
							if (array9.Length >= 27)
							{
								accountDetail2.DateAdded = array9[26].TrimStart(new char[0]).TrimEnd(new char[0]);
							}
							if (array9.Length >= 28)
							{
								accountDetail2.OldStartTime = array9[27].TrimStart(new char[0]).TrimEnd(new char[0]);
							}
							if (array9.Length >= 29)
							{
								accountDetail2.BoardText = array9[28].TrimStart(new char[0]).TrimEnd(new char[0]);
							}
							if (array9.Length >= 30)
							{
								accountDetail2.AutoBoardText = array9[29].TrimStart(new char[0]).TrimEnd(new char[0]);
							}
						}
						list.Add(accountDetail2);
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public void UpdateAccValues(AccountDetail AccD, string strGroupName)
	{
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		string text = "";
		try
		{
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			if (AccD.UserAgent == null || AccD.UserAgent == "")
			{
				AccD.UserAgent = HtmlUserAgent.userAgent;
			}
			string text2 = AccD.id + ";" + AccD.Checked.ToString() + "; " + AccD.UserAgent.Replace(";", "??") + "; " + AccD.UserNameTemp + "; " + AccD.Password.Replace(";", "``") + "; " + AccD.TumblrUrl + "; " + AccD.PageAuth + "; " + AccD.TrustFlow + "; " + AccD.Notes + "; " + AccD.ProxyIP + "; " + AccD.ProxyPort + "; " + AccD.ProxyUsername + "; " + AccD.ProxyPassword;
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				string[] array3 = text3.Split(new char[1] { ';' });
				if (array3.Length <= 2)
				{
					continue;
				}
				if (uint.Parse(array3[0]) == AccD.id)
				{
					if (array3.Length >= 14 && (AccD.Cookies == null || AccD.Cookies == ""))
					{
						text2 = text2 + ";" + array3[13];
					}
					else if (array3.Length >= 14 && AccD.Cookies != null && AccD.Cookies != "")
					{
						text2 = text2 + ";" + AccD.Cookies;
					}
					if (AccD.ShortenUrl == null)
					{
						AccD.ShortenUrl = "";
					}
					if (AccD.LikesCount == null)
					{
						AccD.LikesCount = "0";
					}
					if (AccD.FollowersCount == null)
					{
						AccD.FollowersCount = "0";
					}
					if (AccD.FollowingCount == null)
					{
						AccD.FollowingCount = "0";
					}
					if (AccD.PostsCount == null)
					{
						AccD.PostsCount = "0";
					}
					if (AccD.OldStartTime == null || AccD.OldStartTime == "")
					{
						AccD.OldStartTime = "";
					}
					if (AccD.DateAdded == null || AccD.DateAdded == "")
					{
						AccD.DateAdded = DateTime.Now.Date.ToString("dd-MM-yyyy");
					}
					if (AccD.BoardText == null)
					{
						AccD.BoardText = "";
					}
					if (AccD.AutoBoardText == null)
					{
						AccD.AutoBoardText = "";
					}
					text2 = text2 + ";" + AccD.FollowChecked + ";" + AccD.UnfollowChecked + ";" + AccD.RetweetChecked + ";" + AccD.StartTime + ";" + AccD.EndTime + ";" + AccD.LikeChecked + ";" + AccD.ShortenUrlChecked + ";" + AccD.ShortenUrl.ToString() + ";" + AccD.PostsCount.ToString() + ";" + AccD.LikesCount.ToString() + ";" + AccD.FollowingCount + ";" + AccD.FollowersCount + ";" + AccD.DateAdded + ";" + AccD.OldStartTime + ";" + AccD.BoardText.ToString() + ";" + AccD.AutoBoardText.ToString();
					text = text + text2 + Environment.NewLine;
				}
				else
				{
					text = text + text3 + Environment.NewLine;
				}
			}
			string[] array4 = (from x in text.Split("\r\n".ToCharArray(), StringSplitOptions.None)
				where x != ""
				select x).ToArray();
			if (array4.Length == array.Length)
			{
				File.WriteAllText(path, text);
			}
		}
		catch (Exception ex)
		{
			Thread.Sleep(3000);
			try
			{
				if (text != "")
				{
					File.WriteAllText(path, text);
				}
				else
				{
					File.WriteAllText(accounts + strGroupName + "\\exceptions.txt", ex.ToString());
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public void EnableorDisable(string[] strTokz, string strGroupName, bool action)
	{
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		string text = "";
		try
		{
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			int num = 0;
			while (true)
			{
				if (num < array2.Length)
				{
					string text2 = array2[num];
					string[] array3 = text2.Split(new char[1] { ';' });
					if (array3.Length > 2)
					{
						if (uint.Parse(array3[0]) == uint.Parse(strTokz[0]))
						{
							if (bool.Parse(array3[1]) == action)
							{
								break;
							}
							array3[1] = action.ToString();
							string text3 = string.Join(";", array3);
							text = text + text3 + Environment.NewLine;
						}
						else
						{
							text = text + text2 + Environment.NewLine;
						}
					}
					num++;
					continue;
				}
				if (text != "")
				{
					File.WriteAllText(path, text);
				}
				break;
			}
		}
		catch (Exception)
		{
			Thread.Sleep(3000);
			try
			{
				File.WriteAllText(path, text);
			}
			catch (Exception)
			{
			}
		}
	}

	public void DeleteAccount(uint p, string strGroupName)
	{
		string text = "";
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		try
		{
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (!(text2 == ""))
				{
					string[] array3 = text2.Split(new char[1] { ';' });
					if (uint.Parse(array3[0]) != p)
					{
						text = text + text2 + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
			File.WriteAllText(path, text);
		}
	}

	public List<string> GetGroupsWithActiveAcc()
	{
		List<string> list = GetGroups();
		List<string> list2 = new List<string>();
		foreach (string item in list)
		{
			string path = accounts + item.Split(new char[1] { ';' })[1] + "\\account-" + item.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt";
			if (!File.Exists(path))
			{
				continue;
			}
			string[] array = File.ReadAllLines(path);
			int num = 0;
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split(new char[1] { ';' });
				if (array3.Length >= 2 && bool.Parse(array3[1]))
				{
					num++;
				}
			}
			list2.Add(item + ";" + num);
		}
		return list2;
	}

	public List<string> GetAlreadyFollowed(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-Followed.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllLines(path).ToList();
	}

	public string GetMaxFollowedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public string GetMaxFollowedTodayAuto(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoFollowedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public void UpdateMaxFollowedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateMaxFollowedTodayAuto(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoFollowedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public string GetMaxUnFollowedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-UnfollowedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public void UpdateMaxUnFollowedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-UnfollowedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public string GetMaxLikedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-LikedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public string GetMaxTweetedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-tweetedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public string GetMaxRepliedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-RepliedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public void UpdateMaxAutoFollowedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\-AutoFollowedCounts-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string text = File.ReadAllText(path);
		string stringBetween = cHelper.GetStringBetween(text, AccId + "=", ";");
		if (stringBetween != "")
		{
			int num = int.Parse(count) + int.Parse(stringBetween);
			text = text.Replace(AccId + "=" + stringBetween + ";", AccId + "=" + num + ";");
		}
		else
		{
			text = text + AccId + "=" + count + ";" + Environment.NewLine;
		}
		File.WriteAllText(path, text);
	}

	public string GetMaxAutoFollowedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\-AutoFollowedCounts-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string strText = File.ReadAllText(path);
		return cHelper.GetStringBetween(strText, AccId + "=", ";");
	}

	public string GetMaxRetweetedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-RetweetedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public string GetMaxAutoPinnedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoPinC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public string GetMaxAutoSavedToday(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoSaveC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		if (array.Length != 0)
		{
			return array[0];
		}
		return ";";
	}

	public void UpdateMaxLikedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-LikedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateMaxRetweetedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-RetweetedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateMaxAutoSavedPinToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoSaveC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateMaxAutoPinedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoPinC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateMaxTweetedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-tweetedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateMaxRepliedToday(string strGroupName, string AccId, string count)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-RepliedC-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, count);
	}

	public void UpdateFollowedHistory(string strGroupName, string AccId, string account)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		if (!Directory.Exists(accounts + strGroupName + "\\Used\\Followed\\"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Followed\\");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedHistory.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.AppendAllText(path, string.Concat(account, ";", DateTime.Now, Environment.NewLine));
		path = accounts + strGroupName + "\\Used\\Followed\\Followed.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.AppendAllText(path, account + Environment.NewLine);
	}

	public string[] GetFollowedHistory(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedHistory.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllLines(path);
	}

	public List<string> GetAlreadyRetweeted(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-Retweeted.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllLines(path).ToList();
	}

	public List<string> GetAlreadyLiked(string strGroupName, string AccId)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-Liked.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllLines(path).ToList();
	}

	public void UpdateAlreadyLiked(string strGroupName, string AccId, string liked)
	{
		if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
		{
			Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
		}
		string path = accounts + strGroupName + "\\Logs\\" + AccId + "-Liked.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.WriteAllText(path, liked + Environment.NewLine);
	}

	public List<string> GetToFollowAccounts(string strGroupName)
	{
		List<string> list = new List<string>();
		string text = accounts + strGroupName + "\\TempFollowUrls.txt";
		string path = accounts + strGroupName + "\\FollowUrls.txt";
		string text2 = accounts + strGroupName + "\\Temp_1.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		if (!File.Exists(text2))
		{
			File.Create(text2).Close();
		}
		list = File.ReadLines(path).ToList();
		if (list.Count <= 0)
		{
			if (!File.Exists(text))
			{
				File.Create(text).Close();
			}
			string text3 = "";
			using (StreamReader streamReader = File.OpenText(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text2);
				string text4 = "";
				int num = 0;
				while ((text4 = streamReader.ReadLine()) != null)
				{
					if (text4 != "" && num < 9999)
					{
						text3 = text3 + text4 + Environment.NewLine;
						num++;
					}
					else if (text4 != "" && num >= 9999)
					{
						streamWriter.WriteLine(text4);
					}
				}
			}
			File.WriteAllText(path, text3);
			try
			{
				File.Delete(text);
				File.Move(text2, text);
				File.Delete(text2);
			}
			catch (Exception)
			{
			}
			list = File.ReadLines(path).ToList();
		}
		return list;
	}

	public List<string> GetAutoFollowAKeywords(string strGroupName)
	{
		List<string> list = new List<string>();
		string path = accounts + strGroupName + "\\AutoFollowKeywords.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadLines(path).ToList();
	}

	public List<string> GetAutoSavePinAKeywords(string strGroupName)
	{
		List<string> list = new List<string>();
		string path = accounts + strGroupName + "\\AutoSavePinKeywords.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadLines(path).ToList();
	}

	public void UpdateAutoFollowUrls(string strGroupName, List<string> lstUrls)
	{
		try
		{
			string path = accounts + strGroupName + "\\AutoFollowUrls.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			string contents = string.Join(Environment.NewLine, lstUrls.ToArray());
			File.WriteAllText(path, contents);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateAutoSavePinUrls(string strGroupName, List<string> lstUrls)
	{
		try
		{
			string path = accounts + strGroupName + "\\AutoSavePinsUrls.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			string text = string.Join(Environment.NewLine, lstUrls.GetRange(0, lstUrls.Count / 2).ToArray());
			File.AppendAllText(path, Environment.NewLine + text);
			path = accounts + strGroupName + "\\AutoPinsUrls.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			text = string.Join(Environment.NewLine, lstUrls.GetRange(lstUrls.Count / 2 + 1, lstUrls.Count / 2 - 1).ToArray());
			File.AppendAllText(path, Environment.NewLine + text);
		}
		catch (Exception)
		{
		}
	}

	public List<string> GetToAutoFollowAccounts(string strGroupName)
	{
		List<string> list = new List<string>();
		string text = accounts + strGroupName + "\\TempAutoFollowUrls.txt";
		string path = accounts + strGroupName + "\\AutoFollowUrls.txt";
		string text2 = accounts + strGroupName + "\\Temp_2.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		if (!File.Exists(text2))
		{
			File.Create(text2).Close();
		}
		list = File.ReadLines(path).ToList();
		if (list.Count <= 0)
		{
			if (!File.Exists(text))
			{
				File.Create(text).Close();
			}
			string text3 = "";
			using (StreamReader streamReader = File.OpenText(text))
			{
				using StreamWriter streamWriter = new StreamWriter(text2);
				string text4 = "";
				int num = 0;
				while ((text4 = streamReader.ReadLine()) != null)
				{
					if (text4 != "" && num < 9999)
					{
						text3 = text3 + text4 + Environment.NewLine;
						num++;
					}
					else if (text4 != "" && num >= 9999)
					{
						streamWriter.WriteLine(text4);
					}
				}
			}
			File.WriteAllText(path, text3);
			try
			{
				File.Delete(text);
				File.Move(text2, text);
				File.Delete(text2);
			}
			catch (Exception)
			{
			}
			list = File.ReadLines(path).ToList();
		}
		return list;
	}

	public void UpdateKeyWordLike(string strGroupName, List<string> lstUrls)
	{
		try
		{
			string path = accounts + strGroupName + "\\LikeKwUrls_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllLines(path, lstUrls.ToList());
		}
		catch (Exception)
		{
		}
	}

	public List<string> GetActiveTwitterAccounts()
	{
		List<string> list = GetGroups();
		List<string> list2 = new List<string>();
		foreach (string item in list)
		{
			string path = accounts + item.Split(new char[1] { ';' })[1] + "\\account-" + item.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt";
			if (!File.Exists(path))
			{
				continue;
			}
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split(new char[1] { ';' });
				if (array3.Length >= 2 && bool.Parse(array3[1]))
				{
					list2.Add(item + "$" + text);
				}
			}
		}
		return list2;
	}

	public List<string> GetAccountsInTimeRange(string strGroupName)
	{
		List<string> list = new List<string>();
		string path = accounts + strGroupName.Split(new char[1] { ';' })[1] + "\\account-" + strGroupName.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt";
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!(text.Split(new char[1] { ';' })[17] != "") || !(text.Split(new char[1] { ';' })[18] != ""))
				{
					continue;
				}
				try
				{
					DateTime dateTime = DateTime.Parse(text.Split(new char[1] { ';' })[17]);
					DateTime dateTime2 = DateTime.Parse(text.Split(new char[1] { ';' })[18]);
					if (dateTime.TimeOfDay <= dateTime2.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime2.TimeOfDay && text.Split(new char[1] { ';' })[1].ToString() == "True")
					{
						list.Add(text);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return list;
	}

	public void DeleteFilesYesterday(string strGroupName)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
			}
			string[] files = Directory.GetFiles(accounts + strGroupName + "\\Logs");
			string[] array = files;
			foreach (string text in array)
			{
				try
				{
					if (text.EndsWith(DateTime.Now.Year + ".txt") && !text.Contains(DateTime.Now.Date.ToString("dd-MM-yyyy")))
					{
						File.Delete(text);
					}
				}
				catch (Exception)
				{
				}
			}
			if (!Directory.Exists(accounts + strGroupName))
			{
				Directory.CreateDirectory(accounts + strGroupName);
			}
			files = Directory.GetFiles(accounts + strGroupName);
			string[] array2 = files;
			foreach (string text2 in array2)
			{
				try
				{
					if (text2.EndsWith(DateTime.Now.Year + ".txt") && !text2.Contains(DateTime.Now.Date.ToString("dd-MM-yyyy")))
					{
						File.Delete(text2);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public List<string> GetActiveTwitterAccounts(string strGroupName)
	{
		List<string> list = new List<string>();
		string path = accounts + strGroupName.Split(new char[1] { ';' })[1] + "\\account-" + strGroupName.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt";
		if (File.Exists(path))
		{
			try
			{
				string[] array = File.ReadAllLines(path);
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = text.Split(new char[1] { ';' });
					if (array3.Length >= 2 && bool.Parse(array3[1]))
					{
						list.Add(strGroupName + "f5`0f" + text);
					}
				}
			}
			catch (Exception)
			{
				list.Clear();
				Thread.Sleep(9000);
				string[] array4 = File.ReadAllLines(path);
				string[] array5 = array4;
				foreach (string text2 in array5)
				{
					string[] array6 = text2.Split(new char[1] { ';' });
					if (array6.Length >= 2 && bool.Parse(array6[1]))
					{
						list.Add(strGroupName + "f5`0f" + text2);
					}
				}
			}
		}
		return list;
	}

	public List<string> GetAllAccountsOfGroup(string strGroupName)
	{
		List<string> list = new List<string>();
		string path = accounts + strGroupName.Split(new char[1] { ';' })[1] + "\\account-" + strGroupName.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt";
		if (File.Exists(path))
		{
			try
			{
				string[] array = File.ReadAllLines(path);
				string[] array2 = array;
				foreach (string text in array2)
				{
					string[] array3 = text.Split(new char[1] { ';' });
					if (array3.Length >= 2)
					{
						list.Add(strGroupName + "f5`0f" + text);
					}
				}
			}
			catch (Exception)
			{
				list.Clear();
				string[] array4 = File.ReadAllLines(path);
				string[] array5 = array4;
				foreach (string text2 in array5)
				{
					string[] array6 = text2.Split(new char[1] { ';' });
					if (array6.Length >= 2)
					{
						list.Add(strGroupName + "f5`0f" + text2);
					}
				}
			}
		}
		return list;
	}

	public uint InsertProject(string p1, string p2, string strMinTags, string strMaxTags, string urls, string type)
	{
		urls = urls.Replace("\r\n", "##");
		uint timeInSeconds = GetTimeInSeconds(DateTime.Now);
		string contents = timeInSeconds + ";" + p1 + ";" + p2 + ";" + strMinTags + ";" + strMaxTags + ";" + urls + ";" + type + Environment.NewLine;
		File.AppendAllText(projects, contents);
		return timeInSeconds;
	}

	public void UpdateCookies(string strGroupName, string uId, string cookies)
	{
		string text = "";
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		if (!File.Exists(path))
		{
			return;
		}
		string[] array = File.ReadAllLines(path);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split(new char[1] { ';' });
			if (array3[0] == uId)
			{
				if (array3.Length == 15)
				{
					array3[13] = cookies;
					string text3 = string.Join(";", array3);
					text = text + text3 + Environment.NewLine;
				}
				else
				{
					array3[13] = cookies;
					string text4 = string.Join(";", array3);
					text = text + text4 + Environment.NewLine;
				}
			}
			else
			{
				text = text + text2 + Environment.NewLine;
			}
		}
		File.WriteAllText(path, text);
	}

	public void UpdateUserAgent(string strGroupName, string uId, string useragent)
	{
		string text = "";
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		try
		{
			if (File.Exists(path))
			{
				string[] array = File.ReadAllLines(path);
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					string[] array3 = text2.Split(new char[1] { ';' });
					if (array3[0].ToString() == uId.ToString())
					{
						array3[2] = useragent.Replace(";", "??");
						string text3 = string.Join(";", array3);
						text = text + text3 + Environment.NewLine;
					}
					else
					{
						text = text + text2 + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
			try
			{
				Thread.Sleep(15000);
				File.WriteAllText(path, text);
			}
			catch
			{
			}
		}
	}

	public void UpdateBlogUrl(string strGroupName, string uId, string blogUrl)
	{
		string text = "";
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		if (!File.Exists(path))
		{
			return;
		}
		string[] array = File.ReadAllLines(path);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split(new char[1] { ';' });
			if (array3[0] == uId)
			{
				array3[5] = blogUrl;
				string text3 = string.Join(";", array3);
				text = text + text3 + Environment.NewLine;
			}
			else
			{
				text = text + text2 + Environment.NewLine;
			}
		}
		File.WriteAllText(path, text);
	}

	public string GetGroupType(string strGroupName)
	{
		string[] array = File.ReadAllLines(groups);
		string[] array2 = array;
		int num = 0;
		string[] array3;
		while (true)
		{
			if (num < array2.Length)
			{
				string text = array2[num];
				array3 = text.Split(new char[1] { ';' });
				if (array3[1] == strGroupName)
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return array3[2];
	}

	public List<string> GetSelectdAccountsOfGroup(string strGroupName)
	{
		List<string> list = new List<string>();
		string path = accounts + strGroupName + "\\account-" + strGroupName.Replace(' ', '_') + ".txt";
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!(text == ""))
				{
					string[] array3 = text.Split(new char[1] { ';' });
					if (array3[1] == "True")
					{
						list.Add(text);
					}
				}
			}
		}
		return list;
	}

	public string GetProjectIdOfName(string name)
	{
		string result = "";
		List<string> list = GetProjects();
		foreach (string item in list)
		{
			string[] array = item.Split(new char[1] { ';' });
			if (array[1] == name)
			{
				result = array[0];
				break;
			}
		}
		return result;
	}

	public List<string> GetUnPostedDataOfProject(string p)
	{
		string projectIdOfName = GetProjectIdOfName(p);
		List<string> list = new List<string>();
		string path = posts + "-" + projectIdOfName + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split(new char[1] { ';' });
			if (array3[5].ToString() != "Posted" || array3[6].ToString() == "Spinned")
			{
				list.Add(text);
			}
		}
		return list;
	}

	public List<string> GetUnPostedDataOfProject(string p, string type)
	{
		string projectIdOfName = GetProjectIdOfName(p);
		List<string> list = new List<string>();
		string path = posts + "-" + projectIdOfName + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split(new char[1] { ';' });
			if ((array3[5].ToString() != "Posted" || array3[6].ToString() == "Spinned") && ((array3[2] == "0" && type == "tp;") || (array3[2] == "1" && type == "ip;") || (array3[2] == "2" && type == "vp;")))
			{
				list.Add(text);
			}
		}
		return list;
	}

	public void ReplaceProjectData(string text, string projectId)
	{
		string path = posts + "-" + projectId + ".txt";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllText(path, text);
	}

	public string GetTotalBlogsCount()
	{
		try
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			if (File.Exists(groups))
			{
				string[] array = File.ReadAllLines(groups);
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Split(new char[1] { ';' }).Length < 3 || !File.Exists(accounts + text.Split(new char[1] { ';' })[1] + "\\account-" + text.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt"))
					{
						continue;
					}
					if (text.Split(new char[1] { ';' })[2] == "Tumblr")
					{
						string[] array3 = File.ReadAllLines(accounts + text.Split(new char[1] { ';' })[1] + "\\account-" + text.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt");
						num += array3.Count((string line) => !string.IsNullOrWhiteSpace(line));
						string text2 = "";
						bool flag = false;
						string[] array4 = array3;
						foreach (string text3 in array4)
						{
							string[] array5 = text3.Split(new char[1] { ';' });
							if (array5.Length >= 31)
							{
								flag = true;
								if (text3.Split(new char[1] { ';' })[18] != "" && text3.Split(new char[1] { ';' })[19] != "")
								{
									DateTime dateTime = DateTime.Parse(text3.Split(new char[1] { ';' })[18]);
									DateTime dateTime2 = DateTime.Parse(text3.Split(new char[1] { ';' })[19]);
									if (dateTime.TimeOfDay <= dateTime2.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime2.TimeOfDay && text3.Split(new char[1] { ';' })[1] != "" && text3.Split(new char[1] { ';' })[1] == "True")
									{
										num5++;
									}
								}
								string[] array6 = new string[28];
								for (int k = 0; k < array5.Length; k++)
								{
									if (k == 4)
									{
										array6[k] = array5[k].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
											.TrimEnd(new char[0]) + ";" + array5[k + 1].TrimStart(new char[0]).TrimEnd(new char[0]);
										k++;
									}
									else if (k < 4)
									{
										array6[k] = array5[k].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
											.TrimEnd(new char[0]);
									}
									else if (k > 5)
									{
										array6[k - 1] = array5[k].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
											.TrimEnd(new char[0]);
									}
								}
								for (int l = 0; l < array6.Length; l++)
								{
									if (l == 4)
									{
										array6[l] = array6[l].Replace(";", "``");
									}
								}
								string text4 = string.Join(";", array6);
								text2 = text2 + text4 + Environment.NewLine;
								continue;
							}
							try
							{
								if (text3.Split(new char[1] { ';' })[17] != "" && text3.Split(new char[1] { ';' })[18] != "")
								{
									DateTime dateTime3 = DateTime.Parse(text3.Split(new char[1] { ';' })[17]);
									DateTime dateTime4 = DateTime.Parse(text3.Split(new char[1] { ';' })[18]);
									if (dateTime3.TimeOfDay <= dateTime4.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime3.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime4.TimeOfDay && text3.Split(new char[1] { ';' })[1] != "" && text3.Split(new char[1] { ';' })[1] == "True")
									{
										num5++;
									}
								}
							}
							catch (Exception)
							{
							}
							text2 = text2 + text3 + Environment.NewLine;
						}
						if (flag)
						{
							File.WriteAllText(accounts + text.Split(new char[1] { ';' })[1] + "\\account-" + text.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt", text2);
						}
					}
					if (text.Split(new char[1] { ';' })[2] == "Twitter")
					{
						string[] array7 = File.ReadAllLines(accounts + text.Split(new char[1] { ';' })[1] + "\\account-" + text.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt");
						num2 += array7.Count((string line) => !string.IsNullOrWhiteSpace(line));
						string text5 = "";
						bool flag2 = false;
						string[] array8 = array7;
						foreach (string text6 in array8)
						{
							string[] array9 = text6.Split(new char[1] { ';' });
							if (array9.Length >= 31)
							{
								flag2 = true;
								if (text6.Split(new char[1] { ';' })[18] != "" && text6.Split(new char[1] { ';' })[19] != "")
								{
									DateTime dateTime5 = DateTime.Parse(text6.Split(new char[1] { ';' })[18]);
									DateTime dateTime6 = DateTime.Parse(text6.Split(new char[1] { ';' })[19]);
									if (dateTime5.TimeOfDay <= dateTime6.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime5.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime6.TimeOfDay && text6.Split(new char[1] { ';' })[1] != "" && text6.Split(new char[1] { ';' })[1] == "True")
									{
										num6++;
									}
								}
								string[] array10 = new string[28];
								for (int n = 0; n < array9.Length; n++)
								{
									if (n == 4)
									{
										array10[n] = array9[n].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
											.TrimEnd(new char[0]) + ";" + array9[n + 1].TrimStart(new char[0]).TrimEnd(new char[0]);
										n++;
									}
									else if (n < 4)
									{
										array10[n] = array9[n].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
											.TrimEnd(new char[0]);
									}
									else if (n > 5)
									{
										array10[n - 1] = array9[n].TrimStart(new char[1] { '"' }).TrimStart(new char[0]).TrimEnd(new char[1] { '"' })
											.TrimEnd(new char[0]);
									}
								}
								for (int num9 = 0; num9 < array10.Length; num9++)
								{
									if (num9 == 4)
									{
										array10[num9] = array10[num9].Replace(";", "``");
									}
								}
								string text7 = string.Join(";", array10);
								text5 = text5 + text7 + Environment.NewLine;
								continue;
							}
							if (text6.Split(new char[1] { ';' })[17] != "" && text6.Split(new char[1] { ';' })[18] != "")
							{
								try
								{
									DateTime dateTime7 = DateTime.Parse(text6.Split(new char[1] { ';' })[17]);
									DateTime dateTime8 = DateTime.Parse(text6.Split(new char[1] { ';' })[18]);
									if (dateTime7.TimeOfDay <= dateTime8.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime7.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime8.TimeOfDay && text6.Split(new char[1] { ';' })[1] != "" && text6.Split(new char[1] { ';' })[1] == "True")
									{
										num6++;
									}
								}
								catch (Exception)
								{
								}
							}
							text5 = text5 + text6 + Environment.NewLine;
						}
						if (flag2)
						{
						}
					}
					if (text.Split(new char[1] { ';' })[2] == "Pinterest")
					{
						string[] array11 = File.ReadAllLines(accounts + text.Split(new char[1] { ';' })[1] + "\\account-" + text.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt");
						num3 += array11.Count((string line) => !string.IsNullOrWhiteSpace(line));
						string[] array12 = array11;
						foreach (string text8 in array12)
						{
							string[] array13 = text8.Split(new char[1] { ';' });
							if (array13.Length >= 31)
							{
								if (!(text8.Split(new char[1] { ';' })[18] != "") || !(text8.Split(new char[1] { ';' })[19] != ""))
								{
									continue;
								}
								try
								{
									DateTime dateTime9 = DateTime.Parse(text8.Split(new char[1] { ';' })[18]);
									DateTime dateTime10 = DateTime.Parse(text8.Split(new char[1] { ';' })[19]);
									if (dateTime9.TimeOfDay <= dateTime10.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime9.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime10.TimeOfDay && text8.Split(new char[1] { ';' })[1] != "" && text8.Split(new char[1] { ';' })[1] == "True")
									{
										num7++;
									}
								}
								catch (Exception)
								{
								}
							}
							else
							{
								if (!(text8.Split(new char[1] { ';' })[17] != "") || !(text8.Split(new char[1] { ';' })[18] != ""))
								{
									continue;
								}
								try
								{
									DateTime dateTime11 = DateTime.Parse(text8.Split(new char[1] { ';' })[17]);
									DateTime dateTime12 = DateTime.Parse(text8.Split(new char[1] { ';' })[18]);
									if (dateTime11.TimeOfDay <= dateTime12.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime11.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime12.TimeOfDay && text8.Split(new char[1] { ';' })[1] != "" && text8.Split(new char[1] { ';' })[1] == "True")
									{
										num7++;
									}
								}
								catch (Exception)
								{
								}
							}
						}
					}
					if (!(text.Split(new char[1] { ';' })[2] == "Instagram"))
					{
						continue;
					}
					string[] array14 = File.ReadAllLines(accounts + text.Split(new char[1] { ';' })[1] + "\\account-" + text.Split(new char[1] { ';' })[1].Replace(' ', '_') + ".txt");
					num4 += array14.Count((string line) => !string.IsNullOrWhiteSpace(line));
					string[] array15 = array14;
					foreach (string text9 in array15)
					{
						string[] array16 = text9.Split(new char[1] { ';' });
						if (array16.Length >= 31)
						{
							if (!(text9.Split(new char[1] { ';' })[18] != "") || !(text9.Split(new char[1] { ';' })[19] != ""))
							{
								continue;
							}
							try
							{
								DateTime dateTime13 = DateTime.Parse(text9.Split(new char[1] { ';' })[18]);
								DateTime dateTime14 = DateTime.Parse(text9.Split(new char[1] { ';' })[19]);
								if (dateTime13.TimeOfDay <= dateTime14.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime13.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime14.TimeOfDay && text9.Split(new char[1] { ';' })[1] != "" && text9.Split(new char[1] { ';' })[1] == "True")
								{
									num8++;
								}
							}
							catch (Exception)
							{
							}
						}
						else
						{
							if (!(text9.Split(new char[1] { ';' })[17] != "") || !(text9.Split(new char[1] { ';' })[18] != ""))
							{
								continue;
							}
							try
							{
								DateTime dateTime15 = DateTime.Parse(text9.Split(new char[1] { ';' })[17]);
								DateTime dateTime16 = DateTime.Parse(text9.Split(new char[1] { ';' })[18]);
								if (dateTime15.TimeOfDay <= dateTime16.TimeOfDay && DateTime.Now.TimeOfDay >= dateTime15.TimeOfDay && DateTime.Now.TimeOfDay <= dateTime16.TimeOfDay && text9.Split(new char[1] { ';' })[1] != "" && text9.Split(new char[1] { ';' })[1] == "True")
								{
									num8++;
								}
							}
							catch (Exception)
							{
							}
						}
					}
				}
				return num5 + " of " + num + ";" + num6 + " of " + num2 + ";" + num7 + " of " + num3 + ";" + num8 + " of " + num4;
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public string GetUserAgent()
	{
		try
		{
			if (File.Exists("useragents.txt"))
			{
				string[] array = File.ReadAllLines("useragents.txt");
				Random random = new Random();
				int num = random.Next(0, array.Length - 1);
				return array[num].Replace(";", "$");
			}
		}
		catch (Exception)
		{
		}
		return "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36".Replace(";", "$");
	}

	public string GetPostsCount(int type, string projectId)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string path = posts + "-" + projectId + ".txt";
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (!text.Contains("Posted"))
				{
					string[] array3 = text.Split(new char[1] { ';' });
					if (array3[2] == "0")
					{
						num++;
					}
					if (array3[2] == "1")
					{
						num2++;
					}
					if (array3[2] == "2")
					{
						num3++;
					}
				}
				else if (text.Contains("Spinned"))
				{
					string[] array4 = text.Split(new char[1] { ';' });
					if (array4[3] == "0")
					{
						num++;
					}
					if (array4[3] == "1")
					{
						num2++;
					}
					if (array4[3] == "2")
					{
						num3++;
					}
				}
			}
			return num + ";" + num2 + ";" + num3;
		}
		return "0;0;0";
	}

	public List<string> GetAllPostOfProject(uint uiProjectId)
	{
		List<string> list = new List<string>();
		string path = posts + "-" + uiProjectId + ".txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		list.AddRange(File.ReadAllLines(path));
		return list;
	}

	public void UpdateProject(uint p1, string p2, string p3, string strMinCount, string strMaxCount, string urls)
	{
		if (!File.Exists(projects))
		{
			return;
		}
		string text = "";
		string[] array = File.ReadAllLines(projects);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split(new char[1] { ';' });
			if (array3[0] == p1.ToString())
			{
				array3[1] = p2;
				array3[2] = p3;
				array3[3] = strMinCount;
				array3[4] = strMaxCount;
				if (urls != "")
				{
					urls = urls.Replace("\r\n", "##");
				}
				array3[5] = urls;
				text = text + string.Join(";", array3) + Environment.NewLine;
			}
			else
			{
				text = text + text2 + Environment.NewLine;
			}
		}
		File.WriteAllText(projects, text);
	}

	public string[] GetAllReports()
	{
		string path = direc + "App\\Report.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		return File.ReadAllLines(path);
	}

	public void InsertPostedReport(string text)
	{
		string path = direc + "App\\Report.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		File.AppendAllText(path, text + Environment.NewLine);
	}

	public void DeleteReports(List<string> lstPostId)
	{
		string path = direc + "App\\Report.txt";
		if (!File.Exists(path))
		{
			File.Create(path).Close();
		}
		string[] array = File.ReadAllLines(path);
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split(new char[1] { ';' });
			if (!lstPostId.Contains(array3[0]))
			{
				text = text + text2 + Environment.NewLine;
			}
		}
		File.WriteAllText(path, text);
	}

	public bool isFileExist(string strGroupName, string accountId, string thread)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\logs\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\logs\\");
			}
			if (File.Exists(accounts + strGroupName + "\\logs\\" + accountId + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"))
			{
				return true;
			}
			File.WriteAllText(accounts + strGroupName + "\\logs\\" + accountId + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", thread);
			return false;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public void DeleteFile(string strGroupName, string accountId)
	{
		try
		{
			File.Delete(accounts + strGroupName + "\\logs\\" + accountId + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt");
		}
		catch (Exception)
		{
			Thread.Sleep(3000);
			File.Delete(accounts + strGroupName + "\\logs\\" + accountId + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt");
		}
	}

	public void MoveFailedTweets(string strGroupName, string accountId, string tweetUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Failed\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Failed\\");
			}
			string path = accounts + strGroupName + "\\Used\\Failed\\Failed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, tweetUrl);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateAutoFollowUrlll(string strGroupName, string AccId, string strAlreadyUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Followed\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Followed\\");
			}
			string path = accounts + strGroupName + "\\Used\\Followed\\Followed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
			path = accounts + strGroupName + "\\AutoFollowUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strAlreadyUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateFollowUrlll(string strGroupName, string AccId, string strAlreadyUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Followed\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Followed\\");
			}
			string path = accounts + strGroupName + "\\Used\\Followed\\Followed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
			path = accounts + strGroupName + "\\FollowUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strAlreadyUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateFollowedUrl(string strGroupName, string AccId, string strAlreadyUrl)
	{
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedHistory.txt";
			string[] array = strAlreadyUrl.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
			string text = "";
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				text = string.Concat(text, text2, ";", DateTime.Now, Environment.NewLine);
			}
			File.AppendAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateLikeUrl(string strGroupName, string AccId, string account, bool UseUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Liked\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Liked\\");
			}
			string path = accounts + strGroupName + "\\Used\\Liked\\Liked.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, account + Environment.NewLine);
			path = accounts + strGroupName + "\\LikeUrls.txt";
			if (!UseUrl)
			{
				path = accounts + strGroupName + "\\LikeKwUrls_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
			}
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !account.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateUnfollowedUrl(string strGroupName, string AccId, string account)
	{
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedHistory.txt";
			string[] array = File.ReadAllLines(path);
			string text = "";
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (!account.Contains(text2.Split(new char[1] { ';' })[0]))
				{
					text = text + text2 + Environment.NewLine;
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public string GetLastAutoTweetsDate(string strGroupName, string AccId)
	{
		string text = "";
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoTweeted.txt";
			if (File.Exists(path))
			{
				text = File.ReadAllLines(path)[0];
				text = cHelper.GetStringBetween(text, "Date:", ";");
			}
		}
		catch (Exception)
		{
		}
		return text;
	}

	public string GetLastAutoUnFollowedDate(string strGroupName, string AccId)
	{
		string text = "";
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoUnFollowed.txt";
			if (File.Exists(path))
			{
				text = File.ReadAllLines(path)[0];
				text = cHelper.GetStringBetween(text, "Date:", ";");
			}
		}
		catch (Exception)
		{
		}
		return text;
	}

	public List<string> GetLastAutoUnFollowedList(string strGroupName, string AccId)
	{
		List<string> list = new List<string>();
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoUnFollowed.txt";
			if (File.Exists(path))
			{
				string[] source = File.ReadAllLines(path);
				list.AddRange(source.ToList());
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public void UpdateAutoUnFollowedDate(string strGroupName, string data, string AccId)
	{
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoUnFollowed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
				File.WriteAllText(path, "Date:" + DateTime.Now.ToString() + ";" + Environment.NewLine);
			}
		}
		catch (Exception)
		{
		}
	}

	public void UpdateAutoUnFollowed(string strGroupName, string data, string AccId)
	{
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoUnFollowed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
				File.WriteAllText(path, "Date:" + DateTime.Now.ToString() + ";" + Environment.NewLine);
			}
			else
			{
				string strText = File.ReadAllLines(path)[0];
				if (DateTime.Parse(cHelper.GetStringBetween(strText, "Date:", ";")).Date != DateTime.Today)
				{
					File.Delete(path);
					File.Create(path).Close();
					File.WriteAllText(path, "Date:" + DateTime.Now.ToString() + ";");
				}
			}
			File.AppendAllText(path, data);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateAutoTweeted(string strGroupName, string data, string AccId)
	{
		try
		{
			string path = accounts + strGroupName + "\\Logs\\" + AccId + "-AutoTweeted.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
				File.WriteAllText(path, "Date:" + DateTime.Now.ToString() + ";" + Environment.NewLine);
			}
			else
			{
				string strText = File.ReadAllLines(path)[0];
				if (DateTime.Parse(cHelper.GetStringBetween(strText, "Date:", ";")).Date != DateTime.Today)
				{
					File.Delete(path);
					File.Create(path).Close();
					File.WriteAllText(path, "Date:" + DateTime.Now.ToString() + ";");
				}
			}
			File.AppendAllText(path, data);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateReplyTweetUrl(string strGroupName, string AccId, string strUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\tweet\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\tweet\\");
			}
			string path = accounts + strGroupName + "\\Used\\tweet\\Replytweet.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strUrl + Environment.NewLine);
			path = accounts + strGroupName + "\\ReplyUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					string value = strUrl.Split(new string[1] { "f5`0f" }, StringSplitOptions.None)[0];
					string text2 = item.Replace("\"\"", "``");
					text2 = text2.Replace("\"", string.Empty);
					text2 = text2.Replace("``", "\"");
					if (text2 != "" && !text2.Contains(value))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateAutoRetweetUrl(string strGroupName, string AccId, string strUrl, bool UseUrls)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Retweet\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Retweet\\");
			}
			string path = accounts + strGroupName + "\\Used\\Retweet\\Retweet.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strUrl + Environment.NewLine);
			path = accounts + strGroupName + "\\AutoSavePinsUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateAutCreatePinUrl(string strGroupName, string AccId, string strUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Pins\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Pins\\");
			}
			string path = accounts + strGroupName + "\\Used\\Pins\\AutoPins.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strUrl + Environment.NewLine);
			path = accounts + strGroupName + "\\AutoPinsUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateRetweetUrl(string strGroupName, string AccId, string strUrl, bool UseUrls)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Retweet\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Retweet\\");
			}
			string path = accounts + strGroupName + "\\Used\\Retweet\\Retweet.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strUrl + Environment.NewLine);
			path = ((!UseUrls) ? (accounts + strGroupName + "\\RetweetKwUrls_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt") : (accounts + strGroupName + "\\RetweetUrls.txt"));
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateRetweetdUrl(string strGroupName, string AccId, string strAlreadyUrl, string strRetweetedUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Retweet\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Retweet\\");
			}
			string path = accounts + strGroupName + "\\Used\\Retweet\\Retweet.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
			path = accounts + strGroupName + "\\RetweetUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strAlreadyUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
			if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
			}
			path = accounts + strGroupName + "\\Logs\\" + AccId + "-Retweeted.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateLikedUrl(string strGroupName, string AccId, string strAlreadyUrl, string strRetweetedUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Liked\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Liked\\");
			}
			string path = accounts + strGroupName + "\\Used\\Liked\\Liked.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
			path = accounts + strGroupName + "\\LikeUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strAlreadyUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
			if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
			}
			path = accounts + strGroupName + "\\Logs\\" + AccId + "-Liked.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
		}
		catch (Exception)
		{
		}
	}

	public void UpdateFollowedUrl(string strGroupName, string AccId, string strAlreadyUrl, string strFollowedUrl)
	{
		try
		{
			if (!Directory.Exists(accounts + strGroupName + "\\Used\\Followed\\"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Used\\Followed\\");
			}
			string path = accounts + strGroupName + "\\Used\\Followed\\Followed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
			path = accounts + strGroupName + "\\FollowUrls.txt";
			List<string> list = new List<string>();
			list = File.ReadAllLines(path).ToList();
			string text = "";
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					if (item != "" && !strAlreadyUrl.Contains(item))
					{
						text = text + item + Environment.NewLine;
					}
				}
			}
			File.WriteAllText(path, text);
			if (!Directory.Exists(accounts + strGroupName + "\\Logs"))
			{
				Directory.CreateDirectory(accounts + strGroupName + "\\Logs");
			}
			path = accounts + strGroupName + "\\Logs\\" + AccId + "-Followed.txt";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			File.AppendAllText(path, strAlreadyUrl);
			path = accounts + strGroupName + "\\Logs\\" + AccId + "-FollowedHistory.txt";
			string[] array = strAlreadyUrl.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
			string text2 = "";
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				text2 = string.Concat(text2, text3, ";", DateTime.Now, Environment.NewLine);
			}
			File.AppendAllText(path, text2);
		}
		catch (Exception)
		{
		}
	}
}
