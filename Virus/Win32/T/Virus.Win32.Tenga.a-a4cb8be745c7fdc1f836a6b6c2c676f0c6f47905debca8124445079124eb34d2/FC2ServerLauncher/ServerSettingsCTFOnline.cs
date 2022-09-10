using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[TypeConverter(typeof(CTFOnlinePropertySortTypeConverter))]
[DefaultProperty("Name")]
public class ServerSettingsCTFOnline : ServerSettings
{
	[Category("\t\t\t\t\tServer Properties")]
	[Description("Name of the server as shown in the list of games")]
	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	[Category("\t\t\t\t\tServer Properties")]
	[Description("Password for players to join the game")]
	public string Password
	{
		get
		{
			return m_password;
		}
		set
		{
			m_password = value;
		}
	}

	[MapListEditor.Settings(true, "Choose Maps")]
	[Description("List of available maps")]
	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(StringListConverter))]
	[Category("\t\t\t\tGame")]
	public List<string> MapCycle
	{
		get
		{
			return m_mapCycle;
		}
		set
		{
			m_mapCycle = value;
		}
	}

	[Description("Type of server: LAN or Online")]
	[Category("\t\t\t\t\tServer Properties")]
	public ENetworkType NetworkType
	{
		get
		{
			return m_networkType;
		}
		set
		{
			m_networkType = value;
		}
	}

	[Category("\t\t\t\t\tServer Properties")]
	[Description("Ranked server: Keep track of persistent stats. Only available for Online games.")]
	public bool Ranked
	{
		get
		{
			return m_ranked;
		}
		set
		{
			m_ranked = value;
		}
	}

	[Description("Enable Punk-Buster anti-cheat")]
	[Category("\t\t\t\t\tServer Properties")]
	public bool PunkBuster
	{
		get
		{
			return m_punkBuster;
		}
		set
		{
			m_punkBuster = value;
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Minimum numbers of players required to start a match")]
	public int MinPlayers
	{
		get
		{
			return m_minPlayers;
		}
		set
		{
			if (value > 0 && value < 17)
			{
				m_minPlayers = value;
			}
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Maximum numbers of players in the game")]
	public int MaxPlayers
	{
		get
		{
			return m_maxPlayers;
		}
		set
		{
			if (value > 0 && value < 17)
			{
				m_maxPlayers = value;
			}
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Wait for players to declare they are ready before starting the match.")]
	[TypeConverter(typeof(EnumWaitPlayerConverter))]
	public EWaitReady WaitReady
	{
		get
		{
			return m_waitReady;
		}
		set
		{
			m_waitReady = value;
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Keep number of players balanced in each team")]
	public bool BalanceTeam
	{
		get
		{
			return m_balanceTeam;
		}
		set
		{
			m_balanceTeam = value;
		}
	}

	[Description("Enable players to change team")]
	[Category("\t\t\tPlayers")]
	public bool SwitchTeam
	{
		get
		{
			return m_teamSwap;
		}
		set
		{
			m_teamSwap = value;
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Enable players to join when the match as started")]
	public bool JoinInProgress
	{
		get
		{
			return m_joinInProgress;
		}
		set
		{
			m_joinInProgress = value;
		}
	}

	[Description("Enable friendly fire")]
	[Category("\t\t\tPlayers")]
	public bool FriendlyFire
	{
		get
		{
			return m_friendlyFire;
		}
		set
		{
			m_friendlyFire = value;
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Allow players to vote")]
	public bool AllowVoting
	{
		get
		{
			return m_allowVoting;
		}
		set
		{
			m_allowVoting = value;
		}
	}

	[Description("Game mode to play")]
	[Category("\t\t\t\tGame")]
	public EGameMode GameMode
	{
		get
		{
			return m_gameMode;
		}
		set
		{
			m_gameMode = value;
		}
	}

	[Description("Time limit before match ends")]
	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(EnumTimeLimitConverter))]
	public ETimeLimit TimeLimit
	{
		get
		{
			return m_timeLimit;
		}
		set
		{
			m_timeLimit = value;
		}
	}

	[Description("Score limit for a win")]
	[TypeConverter(typeof(EnumScoreLimitConverterCTF))]
	[Category("\t\t\t\tGame")]
	public EScoreLimitCTF ScoreLimit
	{
		get
		{
			return ConvertScoreCTFFromConsoleValue(m_scoreLimit);
		}
		set
		{
			m_scoreLimit = ConvertToConsoleValue(value);
		}
	}

	[Description("Time of day when the match starts")]
	[Category("\t\t\t\tGame")]
	public ETimeOfDay TimeOfDay
	{
		get
		{
			return m_timeOfDay;
		}
		set
		{
			m_timeOfDay = value;
		}
	}

	[Description("Weather during the match")]
	[Category("\t\t\t\tGame")]
	public EWeatherType WeatherType
	{
		get
		{
			return m_weatherType;
		}
		set
		{
			m_weatherType = value;
		}
	}

	[Category("\t\tUploading")]
	[Description("Enable uploading custom maps to players who don't have the map.")]
	public bool MapSharing
	{
		get
		{
			return m_mapSharing;
		}
		set
		{
			m_mapSharing = value;
		}
	}

	[Description("Maximum combined upload rate used to upload custom maps, in KB/s.")]
	[Category("\t\tUploading")]
	[TypeConverter(typeof(EnumUploadRateConverter))]
	public EUploadRate MaxUploadRate
	{
		get
		{
			return m_maxUploadRate;
		}
		set
		{
			m_maxUploadRate = value;
		}
	}

	public override bool IsTeam()
	{
		return true;
	}

	public override bool IsVIP()
	{
		return false;
	}

	public override bool IsOnline()
	{
		return true;
	}

	public override bool IsRanked()
	{
		return false;
	}
}
