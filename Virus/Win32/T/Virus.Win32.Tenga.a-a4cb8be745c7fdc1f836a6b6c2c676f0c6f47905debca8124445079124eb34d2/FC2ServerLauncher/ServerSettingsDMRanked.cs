using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[TypeConverter(typeof(DMRankedPropertySortTypeConverter))]
[DefaultProperty("Name")]
public class ServerSettingsDMRanked : ServerSettings
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
	[ReadOnly(true)]
	[Category("\t\t\t\t\tServer Properties")]
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

	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(StringListConverter))]
	[MapListEditor.Settings(true, "Choose Maps")]
	[Editor(typeof(MapListEditor), typeof(UITypeEditor))]
	[Description("List of available maps")]
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

	[ReadOnly(true)]
	[Category("\t\t\t\t\tServer Properties")]
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

	[Category("\t\t\tPlayers")]
	[Description("Maximum numbers of players in the game")]
	[ReadOnly(true)]
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
	[ReadOnly(true)]
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

	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
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

	[Description("Enable players to join when the match as started")]
	[Category("\t\t\tPlayers")]
	[ReadOnly(true)]
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

	[ReadOnly(true)]
	[Description("Enable friendly fire")]
	[Category("\t\t\tPlayers")]
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

	[Category("\t\t\t\tGame")]
	[Description("Game mode to play")]
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

	[ReadOnly(true)]
	[Description("Time limit before match ends")]
	[TypeConverter(typeof(EnumTimeLimitConverter))]
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

	[ReadOnly(true)]
	[Category("\t\t\t\tGame")]
	[Description("Score limit for a win")]
	[TypeConverter(typeof(EnumScoreLimitConverterDM))]
	public EScoreLimitDM ScoreLimit
	{
		get
		{
			return EScoreLimitDM.Score25;
		}
		set
		{
			m_scoreLimit = ConvertToConsoleValue(value);
		}
	}

	[ReadOnly(true)]
	[Description("Time of day when the match starts")]
	[Category("\t\t\t\tGame")]
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

	[Category("\t\t\t\tGame")]
	[Description("Weather during the match")]
	[ReadOnly(true)]
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
	[Category("\t\tUploading")]
	[Description("Enable uploading custom maps to players who don't have the map.")]
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

	[Description("Maximum combined upload rate used to upload custom maps, in KB/s.")]
	[ReadOnly(true)]
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
		return true;
	}

	public override bool IsRanked()
	{
		return true;
	}
}
