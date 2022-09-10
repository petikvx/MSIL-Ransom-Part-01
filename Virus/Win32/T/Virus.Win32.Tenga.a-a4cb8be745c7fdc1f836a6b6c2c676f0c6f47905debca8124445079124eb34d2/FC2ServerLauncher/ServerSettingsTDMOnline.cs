using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[DefaultProperty("Name")]
[TypeConverter(typeof(TDMOnlinePropertySortTypeConverter))]
public class ServerSettingsTDMOnline : ServerSettings
{
	[Description("Name of the server as shown in the list of games")]
	[Category("\t\t\t\t\tServer Properties")]
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

	[Description("List of available maps")]
	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
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

	[TypeConverter(typeof(EnumWaitPlayerConverter))]
	[Category("\t\t\tPlayers")]
	[Description("Wait for players to declare they are ready before starting the match.")]
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

	[Category("\t\t\tPlayers")]
	[Description("Enable players to change team")]
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
	[Description("Score limit for a win")]
	[TypeConverter(typeof(EnumScoreLimitConverterTDM))]
	public EScoreLimitTDM ScoreLimit
	{
		get
		{
			return ConvertScoreTDMFromConsoleValue(m_scoreLimit);
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

	[Category("\t\t\t\tGame")]
	[Description("Weather during the match")]
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

	[TypeConverter(typeof(EnumUploadRateConverter))]
	[Category("\t\tUploading")]
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
