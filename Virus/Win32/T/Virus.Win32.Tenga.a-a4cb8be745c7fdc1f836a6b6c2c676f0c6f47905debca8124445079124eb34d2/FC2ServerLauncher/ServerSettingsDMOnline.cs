using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[DefaultProperty("Name")]
[TypeConverter(typeof(DMOnlinePropertySortTypeConverter))]
public class ServerSettingsDMOnline : ServerSettings
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

	[Description("Password for players to join the game")]
	[Category("\t\t\t\t\tServer Properties")]
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

	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(StringListConverter))]
	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
	[Description("List of available maps")]
	[MapListEditor.Settings(true, "Choose Maps")]
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

	[Description("Ranked server: Keep track of persistent stats. Only available for Online games.")]
	[Category("\t\t\t\t\tServer Properties")]
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

	[Description("Wait for players to declare they are ready before starting the match.")]
	[TypeConverter(typeof(EnumWaitPlayerConverter))]
	[Category("\t\t\tPlayers")]
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

	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
	[Description("Keep number of players balanced in each team")]
	public bool BalanceTeam
	{
		get
		{
			return false;
		}
		set
		{
			m_balanceTeam = value;
		}
	}

	[Category("\t\t\tPlayers")]
	[ReadOnly(true)]
	[Description("Enable players to change team")]
	public bool SwitchTeam
	{
		get
		{
			return false;
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

	[Category("\t\t\tPlayers")]
	[Description("Enable friendly fire")]
	[ReadOnly(true)]
	public bool FriendlyFire
	{
		get
		{
			return false;
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

	[TypeConverter(typeof(EnumTimeLimitConverter))]
	[Category("\t\t\t\tGame")]
	[Description("Time limit before match ends")]
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

	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(EnumScoreLimitConverterDM))]
	[Description("Score limit for a win")]
	public EScoreLimitDM ScoreLimit
	{
		get
		{
			return ConvertScoreDMFromConsoleValue(m_scoreLimit);
		}
		set
		{
			m_scoreLimit = ConvertToConsoleValue(value);
		}
	}

	[Category("\t\t\t\tGame")]
	[Description("Time of day when the match starts")]
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

	[Category("\t\tUploading")]
	[TypeConverter(typeof(EnumUploadRateConverter))]
	[Description("Maximum combined upload rate used to upload custom maps, in KB/s.")]
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
		return false;
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
