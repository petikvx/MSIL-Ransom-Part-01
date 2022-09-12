using System;
using System.Runtime.CompilerServices;

namespace xbot.Trader.TradeWebAPI;

public class TradeEvent : IEquatable<TradeEvent>
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private ulong ulong_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private ulong ulong_1;

	public string steamid
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public int action
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public ulong timestamp
	{
		[CompilerGenerated]
		get
		{
			return ulong_0;
		}
		[CompilerGenerated]
		set
		{
			ulong_0 = value;
		}
	}

	public int appid
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public string text
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public long contextid
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		set
		{
			long_0 = value;
		}
	}

	public ulong assetid
	{
		[CompilerGenerated]
		get
		{
			return ulong_1;
		}
		[CompilerGenerated]
		set
		{
			ulong_1 = value;
		}
	}

	public bool Equals(TradeEvent other)
	{
		if (steamid == other.steamid && action == other.action && timestamp == other.timestamp && appid == other.appid && text == other.text && contextid == other.contextid)
		{
			return assetid == other.assetid;
		}
		return false;
	}

	public TradeEvent()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
