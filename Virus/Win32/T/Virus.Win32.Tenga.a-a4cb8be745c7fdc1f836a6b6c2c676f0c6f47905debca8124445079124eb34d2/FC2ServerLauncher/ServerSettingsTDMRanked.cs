using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[TypeConverter(typeof(TDMRankedPropertySortTypeConverter))]
[DefaultProperty("Name")]
public class ServerSettingsTDMRanked : ServerSettings
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

	[ReadOnly(true)]
	[Description("Password for players to join the game")]
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

	[Description("List of available maps")]
	[TypeConverter(typeof(StringListConverter))]
	[Category("\t\t\t\tGame")]
	[MapListEditor.Settings(true, "Choose Maps")]
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
	[ReadOnly(true)]
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

	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
	[Description("Maximum numbers of players in the game")]
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

	[Category("\t\t\tPlayers")]
	[TypeConverter(typeof(EnumWaitPlayerConverter))]
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
			return true;
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

	[Description("Enable friendly fire")]
	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
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
	[ReadOnly(true)]
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
	[Description("Score limit for a win")]
	[Category("\t\t\t\tGame")]
	[TypeConverter(typeof(EnumScoreLimitConverterTDM))]
	public EScoreLimitTDM ScoreLimit
	{
		get
		{
			return EScoreLimitTDM.Score100;
		}
		set
		{
			m_scoreLimit = ConvertToConsoleValue(value);
		}
	}

	[Description("Time of day when the match starts")]
	[ReadOnly(true)]
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

	[Category("\t\tUploading")]
	[ReadOnly(true)]
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

	[Category("\t\tUploading")]
	[TypeConverter(typeof(EnumUploadRateConverter))]
	[Description("Maximum combined upload rate used to upload custom maps, in KB/s.")]
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
