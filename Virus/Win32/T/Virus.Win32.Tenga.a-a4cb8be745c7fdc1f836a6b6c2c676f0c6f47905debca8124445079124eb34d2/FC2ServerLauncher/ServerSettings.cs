using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace FC2ServerLauncher;

public abstract class ServerSettings
{
	public string m_name;

	public string m_password;

	public List<string> m_mapCycle = new List<string>();

	public ENetworkType m_networkType;

	public bool m_ranked;

	public bool m_punkBuster;

	public int m_minPlayers;

	public int m_maxPlayers;

	public EWaitReady m_waitReady;

	public bool m_balanceTeam;

	public bool m_teamSwap;

	public bool m_joinInProgress;

	public bool m_friendlyFire;

	public bool m_allowVoting;

	public EGameMode m_gameMode;

	public ETimeLimit m_timeLimit;

	public int m_scoreLimit;

	public ETimeOfDay m_timeOfDay;

	public EWeatherType m_weatherType;

	public bool m_mapSharing;

	public EUploadRate m_maxUploadRate;

	public static string[] PropertySortOrder = new string[21]
	{
		"Name", "Password", "NetworkType", "Ranked", "PunkBuster", "GameMode", "MapCycle", "TimeLimit", "ScoreLimit", "TimeOfDay",
		"WeatherType", "MinPlayers", "MaxPlayers", "WaitReady", "BalanceTeam", "SwitchTeam", "JoinInProgress", "FriendlyFire", "AllowVoting", "MapSharing",
		"MaxUploadRate"
	};

	public abstract bool IsTeam();

	public abstract bool IsVIP();

	public abstract bool IsOnline();

	public abstract bool IsRanked();

	public void CopyFrom(ServerSettings other)
	{
		m_name = other.m_name;
		m_password = other.m_password;
		m_mapCycle.Clear();
		foreach (string item in other.m_mapCycle)
		{
			m_mapCycle.Add(item);
		}
		m_networkType = other.m_networkType;
		m_ranked = other.m_ranked;
		m_punkBuster = other.m_punkBuster;
		m_minPlayers = other.m_minPlayers;
		m_maxPlayers = other.m_maxPlayers;
		m_waitReady = other.m_waitReady;
		m_balanceTeam = other.m_balanceTeam;
		m_teamSwap = other.m_teamSwap;
		m_joinInProgress = other.m_joinInProgress;
		m_gameMode = other.m_gameMode;
		m_timeLimit = other.m_timeLimit;
		m_scoreLimit = other.m_scoreLimit;
		m_friendlyFire = other.m_friendlyFire;
		m_allowVoting = other.m_allowVoting;
		m_timeOfDay = other.m_timeOfDay;
		m_weatherType = other.m_weatherType;
		m_mapSharing = other.m_mapSharing;
		m_maxUploadRate = other.m_maxUploadRate;
	}

	public void SetDefault()
	{
		m_name = "Far Cry® 2 Server";
		m_password = "";
		m_mapCycle.Clear();
		m_mapCycle.Add("Dirty Work");
		m_networkType = ENetworkType.LAN;
		m_ranked = false;
		m_punkBuster = false;
		m_minPlayers = 1;
		m_maxPlayers = 16;
		m_waitReady = EWaitReady.Wait50;
		m_balanceTeam = false;
		m_teamSwap = true;
		m_joinInProgress = true;
		m_gameMode = EGameMode.Deathmatch;
		m_timeLimit = ETimeLimit.Time15;
		m_scoreLimit = 25;
		m_friendlyFire = false;
		m_allowVoting = true;
		m_timeOfDay = ETimeOfDay.MapDefault;
		m_weatherType = EWeatherType.Dynamic;
		m_mapSharing = true;
		m_maxUploadRate = EUploadRate.Unlimited;
	}

	public void SaveToXml(ref XmlDocument xmldoc)
	{
		XmlNode newChild = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
		xmldoc.AppendChild(newChild);
		XmlElement newChild2 = xmldoc.CreateElement("", "ServerSettings", "");
		XmlNode xmlNode = xmldoc.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "ServerProperties", "");
		XmlNode xmlNode2 = xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Name", "");
		XmlAttribute xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_name;
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode2.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Password", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_password;
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode2.AppendChild(newChild2);
		if (m_mapCycle.Count > 0)
		{
			newChild2 = xmldoc.CreateElement("", "MapCycle", "");
			XmlNode xmlNode3 = xmlNode2.AppendChild(newChild2);
			foreach (string item in m_mapCycle)
			{
				newChild2 = xmldoc.CreateElement("", "Map", "");
				xmlAttribute = xmldoc.CreateAttribute("", "value", "");
				xmlAttribute.Value = item;
				newChild2.Attributes.Append(xmlAttribute);
				xmlNode3.AppendChild(newChild2);
			}
		}
		newChild2 = xmldoc.CreateElement("", "NetworkType", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_networkType.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode2.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Ranked", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_ranked.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode2.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Punkbuster", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_punkBuster.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode2.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Game", "");
		XmlNode xmlNode4 = xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "GameMode", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_gameMode.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode4.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "TimeLimit", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_timeLimit.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode4.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "ScoreLimit", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_scoreLimit.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode4.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "TimeOfDay", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_timeOfDay.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode4.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "WeatherType", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_weatherType.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode4.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Players", "");
		XmlNode xmlNode5 = xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "MinPlayers", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_minPlayers.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "MaxPlayers", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_maxPlayers.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "WaitReady", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = ConvertToConsoleValue(m_waitReady).ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "BalanceTeams", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_balanceTeam.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "AllowTeamSwap", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_teamSwap.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "JoinInProgress", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_joinInProgress.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "FriendlyFire", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_friendlyFire.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "AllowVoting", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_allowVoting.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode5.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "Uploading", "");
		XmlNode xmlNode6 = xmlNode.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "MapSharing", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_mapSharing.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode6.AppendChild(newChild2);
		newChild2 = xmldoc.CreateElement("", "MaxUploadRate", "");
		xmlAttribute = xmldoc.CreateAttribute("", "value", "");
		xmlAttribute.Value = m_maxUploadRate.ToString();
		newChild2.Attributes.Append(xmlAttribute);
		xmlNode6.AppendChild(newChild2);
	}

	public void LoadFromXml(XmlNode xmldoc)
	{
		if (xmldoc == null)
		{
			throw new ArgumentNullException("xmldoc");
		}
		foreach (XmlNode childNode in xmldoc.ChildNodes)
		{
			if (!(childNode.Name == "ServerSettings"))
			{
				continue;
			}
			XmlNode xmlNode2 = childNode;
			foreach (XmlNode item in xmlNode2)
			{
				if (item.Name == "ServerProperties")
				{
					XmlNode xmlNode4 = item;
					foreach (XmlNode item2 in xmlNode4)
					{
						if (item2.Name == "Name")
						{
							m_name = item2.Attributes!.GetNamedItem("value")!.Value;
						}
						else if (item2.Name == "Password")
						{
							m_password = item2.Attributes!.GetNamedItem("value")!.Value;
						}
						else if (item2.Name == "MapCycle")
						{
							m_mapCycle.Clear();
							XmlNode xmlNode6 = item2;
							foreach (XmlNode item3 in xmlNode6)
							{
								if (item3.Name == "Map")
								{
									m_mapCycle.Add(item3.Attributes!.GetNamedItem("value")!.Value);
								}
							}
						}
						else if (item2.Name == "NetworkType")
						{
							string value = item2.Attributes!.GetNamedItem("value")!.Value;
							m_networkType = (ENetworkType)Enum.Parse(typeof(ENetworkType), value);
						}
						else if (item2.Name == "Ranked")
						{
							string value = item2.Attributes!.GetNamedItem("value")!.Value;
							m_ranked = bool.Parse(value);
						}
						else if (item2.Name == "Punkbuster")
						{
							m_punkBuster = bool.Parse(item2.Attributes!.GetNamedItem("value")!.Value);
						}
					}
				}
				else if (item.Name == "Game")
				{
					XmlNode xmlNode8 = item;
					foreach (XmlNode item4 in xmlNode8)
					{
						if (item4.Name == "GameMode")
						{
							string value = item4.Attributes!.GetNamedItem("value")!.Value;
							m_gameMode = (EGameMode)Enum.Parse(typeof(EGameMode), value);
						}
						else if (item4.Name == "TimeLimit")
						{
							string value = item4.Attributes!.GetNamedItem("value")!.Value;
							m_timeLimit = (ETimeLimit)Enum.Parse(typeof(ETimeLimit), value);
						}
						else if (item4.Name == "ScoreLimit")
						{
							m_scoreLimit = int.Parse(item4.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item4.Name == "TimeOfDay")
						{
							string value = item4.Attributes!.GetNamedItem("value")!.Value;
							m_timeOfDay = (ETimeOfDay)Enum.Parse(typeof(ETimeOfDay), value);
						}
						else if (item4.Name == "WeatherType")
						{
							string value = item4.Attributes!.GetNamedItem("value")!.Value;
							m_weatherType = (EWeatherType)Enum.Parse(typeof(EWeatherType), value);
						}
					}
				}
				else if (item.Name == "Players")
				{
					XmlNode xmlNode10 = item;
					foreach (XmlNode item5 in xmlNode10)
					{
						if (item5.Name == "MinPlayers")
						{
							m_minPlayers = int.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item5.Name == "MaxPlayers")
						{
							m_maxPlayers = int.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item5.Name == "WaitReady")
						{
							int value2 = int.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
							m_waitReady = ConvertWaitReadyFromConsoleValue(value2);
						}
						else if (item5.Name == "BalanceTeams")
						{
							m_balanceTeam = bool.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item5.Name == "AllowTeamSwap")
						{
							m_teamSwap = bool.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item5.Name == "JoinInProgress")
						{
							m_joinInProgress = bool.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item5.Name == "FriendlyFire")
						{
							m_friendlyFire = bool.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item5.Name == "AllowVoting")
						{
							m_allowVoting = bool.Parse(item5.Attributes!.GetNamedItem("value")!.Value);
						}
					}
				}
				else
				{
					if (!(item.Name == "Uploading"))
					{
						continue;
					}
					XmlNode xmlNode12 = item;
					foreach (XmlNode item6 in xmlNode12)
					{
						if (item6.Name == "MapSharing")
						{
							m_mapSharing = bool.Parse(item6.Attributes!.GetNamedItem("value")!.Value);
						}
						else if (item6.Name == "MaxUploadRate")
						{
							string value = item6.Attributes!.GetNamedItem("value")!.Value;
							m_maxUploadRate = (EUploadRate)Enum.Parse(typeof(EUploadRate), value);
						}
					}
				}
			}
		}
	}

	public void WriteConsoleBatchFile()
	{
		string path = CUtils.GetFarCry2PersonalServerFolder() + "\\server.cfg";
		TextWriter textWriter = new StreamWriter(path);
		string text = "SetSetting";
		string value = text + " server_name " + m_name;
		textWriter.WriteLine(value);
		string text2 = m_password;
		if (IsRanked())
		{
			text2 = "";
		}
		value = text + " password " + Game.GetCRCFromString(text2);
		textWriter.WriteLine(value);
		value = text + " server_type 1";
		textWriter.WriteLine(value);
		int num = 25;
		string text3 = "DM";
		switch (m_gameMode)
		{
		case EGameMode.Deathmatch:
			text3 = "DM";
			num = 25;
			break;
		case EGameMode.TeamDeathmatch:
			text3 = "TDM";
			num = 100;
			break;
		case EGameMode.CaptureTheDiamond:
			text3 = "CTF";
			num = 5;
			break;
		case EGameMode.Uprising:
			text3 = "VIP";
			num = 1;
			break;
		}
		if (m_mapCycle.Count > 0)
		{
			string text4 = "";
			string text5 = "";
			bool flag = true;
			foreach (string item in m_mapCycle)
			{
				string text6 = item;
				if (MainForm.Maps.TryGetValue(item, out var value2))
				{
					text6 = value2.Name;
				}
				else
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(CUtils.GetFarCry2PersonalUserMapsFolder());
					FileInfo[] files = directoryInfo.GetFiles(item + "*", SearchOption.AllDirectories);
					if (files.Length > 0)
					{
						text6 = files[0].FullName.Remove(0, CUtils.GetFarCry2PersonalFolder().Length + 1);
					}
				}
				if (!flag)
				{
					text4 += ";";
					text5 += ";";
				}
				text4 += text6;
				text5 += text3;
				flag = false;
			}
			value = text + " map_cycle " + text4;
			textWriter.WriteLine(value);
			value = text + " gamemode_cycle " + text5;
			textWriter.WriteLine(value);
		}
		value = text + " network_type " + ConvertToConsoleValue(m_networkType);
		textWriter.WriteLine(value);
		int num2 = ConvertToConsoleValue(m_punkBuster);
		if (!IsOnline())
		{
			num2 = 0;
		}
		else if (IsRanked())
		{
			num2 = 1;
		}
		value = text + " match_pb_enabled " + num2;
		textWriter.WriteLine(value);
		int num3 = m_minPlayers;
		if (IsRanked())
		{
			num3 = 1;
		}
		value = text + " minplayers " + num3;
		textWriter.WriteLine(value);
		int num4 = m_maxPlayers;
		if (IsRanked())
		{
			num4 = 16;
		}
		value = text + " maxplayers " + num4;
		textWriter.WriteLine(value);
		value = text + " waitready " + ConvertToConsoleValue(m_waitReady);
		textWriter.WriteLine(value);
		if (IsTeam())
		{
			int num5 = ConvertToConsoleValue(m_balanceTeam);
			if (IsRanked())
			{
				num5 = 1;
			}
			value = text + " teambalance " + num5;
			textWriter.WriteLine(value);
			value = text + " teamswap " + ConvertToConsoleValue(m_teamSwap);
			textWriter.WriteLine(value);
			int num6 = ConvertToConsoleValue(m_friendlyFire);
			if (IsRanked())
			{
				num6 = 1;
			}
			value = text + " friendly_fire " + num6;
			textWriter.WriteLine(value);
		}
		int num7 = ConvertToConsoleValue(m_joinInProgress);
		if (IsRanked())
		{
			num7 = 0;
		}
		value = text + " joinprogress " + num7;
		textWriter.WriteLine(value);
		value = text + " allow_voting " + ConvertToConsoleValue(m_allowVoting);
		textWriter.WriteLine(value);
		int num8 = ConvertToConsoleValue(m_timeLimit);
		if (IsRanked())
		{
			num8 = 900;
		}
		value = text + " inroundtime " + num8;
		textWriter.WriteLine(value);
		if (IsVIP())
		{
			num = 1;
		}
		else if (!IsRanked())
		{
			num = m_scoreLimit;
		}
		value = text + " max_score " + num;
		textWriter.WriteLine(value);
		int num9 = ConvertToConsoleValue(m_timeOfDay);
		if (IsRanked())
		{
			num9 = -2;
		}
		value = text + " time_of_day " + num9;
		textWriter.WriteLine(value);
		int num10 = ConvertToConsoleValue(m_weatherType);
		if (IsRanked())
		{
			num10 = -1;
		}
		value = text + " weather_type " + num10;
		textWriter.WriteLine(value);
		int num11 = ConvertToConsoleValue(m_mapSharing);
		if (IsRanked())
		{
			num11 = 0;
		}
		value = text + " map_sharing " + num11;
		textWriter.WriteLine(value);
		value = text + " max_upload_rate " + ConvertToConsoleValue(m_maxUploadRate);
		textWriter.WriteLine(value);
		textWriter.Close();
	}

	public string ConvertToConsoleValue(EGameMode gameMode)
	{
		return gameMode switch
		{
			EGameMode.Deathmatch => "FCXDeathmatch", 
			EGameMode.TeamDeathmatch => "FCXTeamDeathmatch", 
			EGameMode.CaptureTheDiamond => "FCXCTF", 
			EGameMode.Uprising => "VIP", 
			_ => "FCXDeathmatch", 
		};
	}

	public int ConvertToConsoleValue(ENetworkType networkType)
	{
		return networkType switch
		{
			ENetworkType.LAN => 0, 
			ENetworkType.Online => 1, 
			_ => 0, 
		};
	}

	public int ConvertToConsoleValue(bool value)
	{
		if (value)
		{
			return 1;
		}
		return 0;
	}

	public int ConvertToConsoleValue(EWaitReady value)
	{
		return value switch
		{
			EWaitReady.WaitNone => 0, 
			EWaitReady.Wait50 => 51, 
			EWaitReady.WaitAll => 100, 
			_ => 0, 
		};
	}

	public int ConvertToConsoleValue(ETimeOfDay value)
	{
		return value switch
		{
			ETimeOfDay.MapDefault => -2, 
			ETimeOfDay.Random => -1, 
			ETimeOfDay.Dawn => 6, 
			ETimeOfDay.Midday => 11, 
			ETimeOfDay.Dusk => 21, 
			ETimeOfDay.Night => 23, 
			_ => -2, 
		};
	}

	public int ConvertToConsoleValue(EWeatherType value)
	{
		return value switch
		{
			EWeatherType.Dynamic => -1, 
			EWeatherType.Clear => 0, 
			EWeatherType.Windy => 25, 
			EWeatherType.Varied => 50, 
			EWeatherType.Overcast => 75, 
			EWeatherType.Stormy => 100, 
			EWeatherType.MapDefault => -2, 
			_ => -1, 
		};
	}

	public int ConvertToConsoleValue(ETimeLimit value)
	{
		return value switch
		{
			ETimeLimit.Infinite => 0, 
			ETimeLimit.Time5 => 300, 
			ETimeLimit.Time10 => 600, 
			ETimeLimit.Time15 => 900, 
			ETimeLimit.Time20 => 1200, 
			ETimeLimit.Time25 => 1500, 
			ETimeLimit.Time30 => 1800, 
			ETimeLimit.Time60 => 3600, 
			_ => 0, 
		};
	}

	public int ConvertToConsoleValue(EScoreLimitDM value)
	{
		return value switch
		{
			EScoreLimitDM.None => 0, 
			EScoreLimitDM.Score5 => 5, 
			EScoreLimitDM.Score10 => 10, 
			EScoreLimitDM.Score15 => 15, 
			EScoreLimitDM.Score20 => 20, 
			EScoreLimitDM.Score25 => 25, 
			EScoreLimitDM.Score30 => 30, 
			EScoreLimitDM.Score40 => 40, 
			EScoreLimitDM.Score50 => 50, 
			EScoreLimitDM.Score100 => 100, 
			_ => 25, 
		};
	}

	public int ConvertToConsoleValue(EScoreLimitTDM value)
	{
		return value switch
		{
			EScoreLimitTDM.None => 0, 
			EScoreLimitTDM.Score5 => 5, 
			EScoreLimitTDM.Score10 => 10, 
			EScoreLimitTDM.Score15 => 15, 
			EScoreLimitTDM.Score20 => 20, 
			EScoreLimitTDM.Score25 => 25, 
			EScoreLimitTDM.Score30 => 30, 
			EScoreLimitTDM.Score40 => 40, 
			EScoreLimitTDM.Score50 => 50, 
			EScoreLimitTDM.Score100 => 100, 
			EScoreLimitTDM.Score200 => 200, 
			_ => 100, 
		};
	}

	public int ConvertToConsoleValue(EScoreLimitCTF value)
	{
		return value switch
		{
			EScoreLimitCTF.None => 0, 
			EScoreLimitCTF.Score3 => 3, 
			EScoreLimitCTF.Score5 => 5, 
			EScoreLimitCTF.Score10 => 10, 
			EScoreLimitCTF.Score20 => 20, 
			EScoreLimitCTF.Score30 => 30, 
			EScoreLimitCTF.Score40 => 40, 
			EScoreLimitCTF.Score50 => 50, 
			EScoreLimitCTF.Score100 => 100, 
			_ => 5, 
		};
	}

	public int ConvertToConsoleValue(EScoreLimitVIP value)
	{
		return value switch
		{
			EScoreLimitVIP.None => 0, 
			EScoreLimitVIP.Score1 => 1, 
			_ => 1, 
		};
	}

	public int ConvertToConsoleValue(EUploadRate value)
	{
		return value switch
		{
			EUploadRate.Unlimited => 0, 
			EUploadRate.Kbps20 => 20, 
			EUploadRate.Kbps40 => 40, 
			EUploadRate.Kbps80 => 80, 
			EUploadRate.Kbps160 => 160, 
			EUploadRate.Kbps320 => 320, 
			_ => 0, 
		};
	}

	public EWaitReady ConvertWaitReadyFromConsoleValue(int value)
	{
		if (value <= 0)
		{
			return EWaitReady.WaitNone;
		}
		if (value > 25 && value <= 51)
		{
			return EWaitReady.Wait50;
		}
		return EWaitReady.WaitAll;
	}

	public EScoreLimitDM ConvertScoreDMFromConsoleValue(int value)
	{
		return value switch
		{
			0 => EScoreLimitDM.None, 
			5 => EScoreLimitDM.Score5, 
			10 => EScoreLimitDM.Score10, 
			15 => EScoreLimitDM.Score15, 
			20 => EScoreLimitDM.Score20, 
			25 => EScoreLimitDM.Score25, 
			30 => EScoreLimitDM.Score30, 
			40 => EScoreLimitDM.Score40, 
			50 => EScoreLimitDM.Score50, 
			100 => EScoreLimitDM.Score100, 
			_ => EScoreLimitDM.Score25, 
		};
	}

	public EScoreLimitTDM ConvertScoreTDMFromConsoleValue(int value)
	{
		return value switch
		{
			0 => EScoreLimitTDM.None, 
			5 => EScoreLimitTDM.Score5, 
			10 => EScoreLimitTDM.Score10, 
			15 => EScoreLimitTDM.Score15, 
			20 => EScoreLimitTDM.Score20, 
			25 => EScoreLimitTDM.Score25, 
			30 => EScoreLimitTDM.Score30, 
			40 => EScoreLimitTDM.Score40, 
			50 => EScoreLimitTDM.Score50, 
			100 => EScoreLimitTDM.Score100, 
			200 => EScoreLimitTDM.Score200, 
			_ => EScoreLimitTDM.Score100, 
		};
	}

	public EScoreLimitCTF ConvertScoreCTFFromConsoleValue(int value)
	{
		return value switch
		{
			0 => EScoreLimitCTF.None, 
			3 => EScoreLimitCTF.Score3, 
			5 => EScoreLimitCTF.Score5, 
			10 => EScoreLimitCTF.Score10, 
			20 => EScoreLimitCTF.Score20, 
			30 => EScoreLimitCTF.Score30, 
			40 => EScoreLimitCTF.Score40, 
			50 => EScoreLimitCTF.Score50, 
			100 => EScoreLimitCTF.Score100, 
			_ => EScoreLimitCTF.Score5, 
		};
	}

	public EScoreLimitVIP ConvertScoreVIPFromConsoleValue(int value)
	{
		return value switch
		{
			0 => EScoreLimitVIP.None, 
			1 => EScoreLimitVIP.Score1, 
			_ => EScoreLimitVIP.Score1, 
		};
	}
}
