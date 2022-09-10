using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[TypeConverter(typeof(VIPOnlinePropertySortTypeConverter))]
[DefaultProperty("Name")]
public class ServerSettingsVIPOnline : ServerSettings
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

	[TypeConverter(typeof(StringListConverter))]
	[MapListEditor.Settings(true, "Choose Maps")]
	[Description("List of available maps")]
	[Category("\t\t\t\tGame")]
	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
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

	[Category("\t\t\t\t\tServer Properties")]
	[Description("Enable Punk-Buster anti-cheat")]
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

	[Category("\t\t\tPlayers")]
	[Description("Enable friendly fire")]
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

	[Category("\t\t\t\tGame")]
	[Description("Time limit before match ends")]
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
	[ReadOnly(true)]
	[TypeConverter(typeof(EnumScoreLimitConverterVIP))]
	[Category("\t\t\t\tGame")]
	public EScoreLimitVIP ScoreLimit
	{
		get
		{
			return EScoreLimitVIP.Score1;
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

	[TypeConverter(typeof(EnumUploadRateConverter))]
	[Description("Maximum combined upload rate used to upload custom maps, in KB/s.")]
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
		return true;
	}

	public override bool IsVIP()
	{
		return true;
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
