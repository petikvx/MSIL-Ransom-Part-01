using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace xbot.Trader.TradeWebAPI;

public class TradeUserObj
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private dynamic object_0;

	public int ready
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

	public int confirmed
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

	public int sec_since_touch
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public bool connection_pending
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

	public dynamic assets
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
		[CompilerGenerated]
		set
		{
			object_0 = value;
		}
	}

	public TradeUserAssets[] GetAssets()
	{
		List<TradeUserAssets> list = new List<TradeUserAssets>();
		if (assets.GetType() == typeof(JArray))
		{
			foreach (dynamic asset in assets)
			{
				list.Add(new TradeUserAssets((int)asset.appid, (long)asset.contextid, (ulong)asset.assetid, (int)asset.amount));
			}
		}
		else if (assets.GetType() == typeof(JObject))
		{
			foreach (object asset2 in assets)
			{
				dynamic value = ((JProperty)(dynamic)asset2).get_Value();
				list.Add(new TradeUserAssets((int)value.appid, (long)value.contextid, (ulong)value.assetid, (int)value.amount));
			}
		}
		return list.ToArray();
	}

	public TradeUserObj()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
