using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class ItemHistoryResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private long FuRgMyTqfy;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private long long_1;

	[CompilerGenerated]
	private List<HistoryItemHistory> list_0;

	public bool success
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

	public long min
	{
		[CompilerGenerated]
		get
		{
			return FuRgMyTqfy;
		}
		[CompilerGenerated]
		set
		{
			FuRgMyTqfy = value;
		}
	}

	public long average
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

	public long number
	{
		[CompilerGenerated]
		get
		{
			return long_1;
		}
		[CompilerGenerated]
		set
		{
			long_1 = value;
		}
	}

	[JsonConverter(typeof(SingleValueArrayConverter<HistoryItemHistory>))]
	public List<HistoryItemHistory> history
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public ItemHistoryResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
