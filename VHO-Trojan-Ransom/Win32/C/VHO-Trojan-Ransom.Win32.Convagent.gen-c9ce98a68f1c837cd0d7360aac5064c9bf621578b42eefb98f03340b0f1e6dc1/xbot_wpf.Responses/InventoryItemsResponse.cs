using System.Runtime.CompilerServices;

namespace xbot_wpf.Responses;

public class InventoryItemsResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private long long_1;

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

	public bool updatingNow
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

	public long lastUpdate
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

	public long itemsInCache
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

	public InventoryItemsResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
