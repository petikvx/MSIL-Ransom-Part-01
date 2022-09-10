using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[TypeConverter(typeof(VIPRankedPropertySortTypeConverter))]
[DefaultProperty("Name")]
public class ServerSettingsVIPRanked : ServerSettings
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

	[Category("\t\t\t\t\tServer Properties")]
	[ReadOnly(true)]
	[Description("Password for players to join the game")]
	public string Password
	{
		get
		{
			return "";
		}
		set
		{
			m_password = value;
		}
	}

	[TypeConverter(typeof(StringListConverter))]
	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
	[MapListEditor.Settings(true, "Choose Maps")]
	[Description("List of available maps")]
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

	[Category("\t\t\t\t\tServer Properties")]
	[ReadOnly(true)]
	[Description("Enable Punk-Buster anti-cheat")]
	public bool PunkBuster
	{
		get
		{
			return true;
		}
		set
		{
			m_punkBuster = value;
		}
	}

	[Category("\t\t\tPlayers")]
	[Description("Minimum numbers of players required to start a match")]
	[ReadOnly(true)]
	public int MinPlayers
	{
		get
		{
			return 1;
		}
		set
		{
			if (value > 0 && value < 17)
			{
				m_minPlayers = value;
			}
		}
	}

	[Description("Maximum numbers of players in the game")]
	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
	public int MaxPlayers
	{
		get
		{
			return 16;
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
	[Description("Wait for players to declare they are ready before starting the match.")]
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
	[Description("Keep number of players balanced in each team")]
	[Category("\t\t\tPlayers")]
	public bool BalanceTeam
	{
		get
		{
			return true;
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

	[Description("Enable players to join when the match as started")]
	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
	public bool JoinInProgress
	{
		get
		{
			return false;
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
			return true;
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

	[Description("Time limit before match ends")]
	[TypeConverter(typeof(EnumTimeLimitConverter))]
	[ReadOnly(true)]
	[Category("\t\t\t\tGame")]
	public ETimeLimit TimeLimit
	{
		get
		{
			return ETimeLimit.Time15;
		}
		set
		{
			m_timeLimit = value;
		}
	}

	[Description("Score limit for a win")]
	[ReadOnly(true)]
	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(EnumScoreLimitConverterVIP))]
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

	[Description("Time of day when the match starts")]
	[Category("\t\t\t\tGame")]
	[ReadOnly(true)]
	public ETimeOfDay TimeOfDay
	{
		get
		{
			return ETimeOfDay.MapDefault;
		}
		set
		{
			m_timeOfDay = value;
		}
	}

	[Description("Weather during the match")]
	[ReadOnly(true)]
	[Category("\t\t\t\tGame")]
	public EWeatherType WeatherType
	{
		get
		{
			return EWeatherType.Dynamic;
		}
		set
		{
			m_weatherType = value;
		}
	}

	[ReadOnly(true)]
	[Description("Enable uploading custom maps to players who don't have the map.")]
	[Category("\t\tUploading")]
	public bool MapSharing
	{
		get
		{
			return false;
		}
		set
		{
			m_mapSharing = value;
		}
	}

	[TypeConverter(typeof(EnumUploadRateConverter))]
	[Description("Maximum combined upload rate used to upload custom maps, in KB/s.")]
	[Category("\t\tUploading")]
	[ReadOnly(true)]
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
		return true;
	}
}
