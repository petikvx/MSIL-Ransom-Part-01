using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[DefaultProperty("Name")]
[TypeConverter(typeof(DMPropertySortTypeConverter))]
public class ServerSettingsDM : ServerSettings
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

	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
	[Description("List of available maps")]
	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(StringListConverter))]
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

	[Category("\t\t\t\t\tServer Properties")]
	[Description("Type of server: LAN or Online")]
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
	[ReadOnly(true)]
	[Category("\t\t\t\t\tServer Properties")]
	public bool Ranked
	{
		get
		{
			return false;
		}
		set
		{
			m_ranked = value;
		}
	}

	[ReadOnly(true)]
	[Description("Enable Punk-Buster anti-cheat")]
	[Category("\t\t\t\t\tServer Properties")]
	public bool PunkBuster
	{
		get
		{
			return false;
		}
		set
		{
			m_punkBuster = value;
		}
	}

	[Description("Minimum numbers of players required to start a match")]
	[Category("\t\t\tPlayers")]
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

	[Description("Keep number of players balanced in each team")]
	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
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

	[Description("Enable players to change team")]
	[Category("\t\t\tPlayers")]
	[ReadOnly(true)]
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

	[Description("Enable players to join when the match as started")]
	[Category("\t\t\tPlayers")]
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

	[Description("Allow players to vote")]
	[Category("\t\t\tPlayers")]
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
	[Description("Time limit before match ends")]
	[Category("\t\t\t\tGame")]
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
	[TypeConverter(typeof(EnumScoreLimitConverterDM))]
	[Category("\t\t\t\tGame")]
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

	[Description("Enable uploading custom maps to players who don't have the map.")]
	[Category("\t\tUploading")]
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
	[TypeConverter(typeof(EnumUploadRateConverter))]
	[Category("\t\tUploading")]
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
		return false;
	}

	public override bool IsRanked()
	{
		return false;
	}
}
