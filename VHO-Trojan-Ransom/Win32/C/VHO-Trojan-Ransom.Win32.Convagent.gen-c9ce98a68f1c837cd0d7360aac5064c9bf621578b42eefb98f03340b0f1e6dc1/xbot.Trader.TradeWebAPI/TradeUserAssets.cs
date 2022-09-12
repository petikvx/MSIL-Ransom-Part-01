using System;
using System.Runtime.CompilerServices;

namespace xbot.Trader.TradeWebAPI;

public class TradeUserAssets : IEquatable<TradeUserAssets>, IComparable<TradeUserAssets>
{
	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private ulong ulong_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	public long contextid
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		private set
		{
			long_0 = value;
		}
	}

	public ulong assetid
	{
		[CompilerGenerated]
		get
		{
			return ulong_0;
		}
		[CompilerGenerated]
		private set
		{
			ulong_0 = value;
		}
	}

	public int appid
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	public int amount
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		private set
		{
			int_1 = value;
		}
	}

	public TradeUserAssets(int appid, long contextid, ulong assetid, int amount = 1)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		this.appid = appid;
		this.contextid = contextid;
		this.assetid = assetid;
		this.amount = amount;
	}

	public bool Equals(TradeUserAssets other)
	{
		return CompareTo(other) == 0;
	}

	public override bool Equals(object other)
	{
		if (other is TradeUserAssets other2)
		{
			return Equals(other2);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return contextid.GetHashCode() ^ assetid.GetHashCode() ^ appid.GetHashCode() ^ amount.GetHashCode();
	}

	public int CompareTo(TradeUserAssets other)
	{
		if (appid != other.appid)
		{
			if (appid >= other.appid)
			{
				return 1;
			}
			return -1;
		}
		if (contextid != other.contextid)
		{
			if (contextid >= other.contextid)
			{
				return 1;
			}
			return -1;
		}
		if (assetid != other.assetid)
		{
			if (assetid >= other.assetid)
			{
				return 1;
			}
			return -1;
		}
		if (amount != other.amount)
		{
			if (amount >= other.amount)
			{
				return 1;
			}
			return -1;
		}
		return 0;
	}

	public override string ToString()
	{
		return $"id:{assetid}, appid:{appid}, contextid:{contextid}, amount:{amount}";
	}
}
