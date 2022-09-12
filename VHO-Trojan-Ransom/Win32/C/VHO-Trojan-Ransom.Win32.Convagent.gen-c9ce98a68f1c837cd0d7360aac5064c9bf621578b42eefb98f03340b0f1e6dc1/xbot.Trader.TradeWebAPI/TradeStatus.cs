using System.Runtime.CompilerServices;

namespace xbot.Trader.TradeWebAPI;

public class TradeStatus
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private TradeUserObj tradeUserObj_0;

	[CompilerGenerated]
	private TradeUserObj tradeUserObj_1;

	[CompilerGenerated]
	private TradeEvent[] tradeEvent_0;

	public string error
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

	public bool newversion
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool success
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public string tradeid
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

	public long trade_status
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

	public int version
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

	public int logpos
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

	public TradeUserObj me
	{
		[CompilerGenerated]
		get
		{
			return tradeUserObj_0;
		}
		[CompilerGenerated]
		set
		{
			tradeUserObj_0 = value;
		}
	}

	public TradeUserObj them
	{
		[CompilerGenerated]
		get
		{
			return tradeUserObj_1;
		}
		[CompilerGenerated]
		set
		{
			tradeUserObj_1 = value;
		}
	}

	public TradeEvent[] events
	{
		[CompilerGenerated]
		get
		{
			return tradeEvent_0;
		}
		[CompilerGenerated]
		set
		{
			tradeEvent_0 = value;
		}
	}

	public TradeEvent GetLastEvent()
	{
		if (events != null && events.Length != 0)
		{
			return events[events.Length - 1];
		}
		return null;
	}

	public TradeEvent[] GetAllEvents()
	{
		if (events == null)
		{
			return new TradeEvent[0];
		}
		return events;
	}

	public TradeStatus()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
