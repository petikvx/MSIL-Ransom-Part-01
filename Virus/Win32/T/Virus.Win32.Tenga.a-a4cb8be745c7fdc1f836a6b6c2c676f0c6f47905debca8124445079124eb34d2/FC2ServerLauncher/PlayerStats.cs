using System;
using System.ComponentModel;

namespace FC2ServerLauncher;

[TypeConverter(typeof(PlayerStatsSortTypeConverter))]
[DefaultProperty("Name")]
internal class PlayerStats
{
	public class PlayerStatsSortTypeConverter : TypeConverter
	{
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(PlayerStats), attributes);
			string[] names = new string[10] { "Name", "Kills", "Deaths", "TeamKills", "Suicides", "Revives", "Wins", "Losses", "Rank", "XP" };
			return properties.Sort(names);
		}
	}

	private string m_name;

	private int m_kills;

	private int m_deaths;

	private int m_teamKills;

	private int m_suicides;

	private int m_revives;

	private int m_wins;

	private int m_losses;

	private int m_xp;

	private int m_rank;

	[Category("Stats")]
	[ReadOnly(true)]
	[Description("Nickname")]
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

	[Category("Stats")]
	[Description("Number of kills")]
	[ReadOnly(true)]
	public int Kills
	{
		get
		{
			return m_kills;
		}
		set
		{
			m_kills = value;
		}
	}

	[Description("Number of deaths")]
	[Category("Stats")]
	[ReadOnly(true)]
	public int Deaths
	{
		get
		{
			return m_deaths;
		}
		set
		{
			m_deaths = value;
		}
	}

	[Description("Number of teamates killed")]
	[ReadOnly(true)]
	[Category("Stats")]
	public int TeamKills
	{
		get
		{
			return m_teamKills;
		}
		set
		{
			m_teamKills = value;
		}
	}

	[Category("Stats")]
	[ReadOnly(true)]
	[Description("Number of suicides")]
	public int Suicides
	{
		get
		{
			return m_suicides;
		}
		set
		{
			m_suicides = value;
		}
	}

	[ReadOnly(true)]
	[Category("Stats")]
	[Description("Number of revived allies")]
	public int Revives
	{
		get
		{
			return m_revives;
		}
		set
		{
			m_revives = value;
		}
	}

	[Category("Stats")]
	[Description("Number of wins")]
	[ReadOnly(true)]
	public int Wins
	{
		get
		{
			return m_wins;
		}
		set
		{
			m_wins = value;
		}
	}

	[ReadOnly(true)]
	[Category("Stats")]
	[Description("Number of losses")]
	public int Losses
	{
		get
		{
			return m_losses;
		}
		set
		{
			m_losses = value;
		}
	}

	[ReadOnly(true)]
	[Category("Stats")]
	[Description("Experience points")]
	public int XP
	{
		get
		{
			return m_xp;
		}
		set
		{
			m_xp = value;
		}
	}

	[Description("Current rank")]
	[ReadOnly(true)]
	[Category("Stats")]
	public int Rank
	{
		get
		{
			return m_rank;
		}
		set
		{
			m_rank = value;
		}
	}
}
