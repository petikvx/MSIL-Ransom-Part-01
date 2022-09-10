using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace FC2ServerLauncher;

[TypeConverter(typeof(CTFRankedPropertySortTypeConverter))]
[DefaultProperty("Name")]
public class ServerSettingsCTFRanked : ServerSettings
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

	[Description("Minimum numbers of players required to start a match")]
	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
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

	[Description("Keep number of players balanced in each team")]
	[Category("\t\t\tPlayers")]
	[ReadOnly(true)]
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

	[ReadOnly(true)]
	[Category("\t\t\tPlayers")]
	[Description("Enable friendly fire")]
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
	[TypeConverter(typeof(EnumTimeLimitConverter))]
	[Category("\t\t\t\tGame")]
	[Description("Time limit before match ends")]
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
	[TypeConverter(typeof(EnumScoreLimitConverterCTF))]
	[ReadOnly(true)]
	[Category("\t\t\t\tGame")]
	public EScoreLimitCTF ScoreLimit
	{
		get
		{
			return EScoreLimitCTF.Score5;
		}
		set
		{
			m_scoreLimit = ConvertToConsoleValue(value);
		}
	}

	[Category("\t\t\t\tGame")]
	[Description("Time of day when the match starts")]
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

	[ReadOnly(true)]
	[Description("Weather during the match")]
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

	[ReadOnly(true)]
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
		return true;
	}
}
