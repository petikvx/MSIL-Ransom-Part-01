using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class HistoryItemHistory
{
	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private DateTime dateTime_0;

	public long l_price
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

	[JsonConverter(typeof(MicrosecondEpochConverter))]
	[JsonProperty(PropertyName = "l_time")]
	public DateTime l_time
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			dateTime_0 = value;
		}
	}

	public HistoryItemHistory()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
