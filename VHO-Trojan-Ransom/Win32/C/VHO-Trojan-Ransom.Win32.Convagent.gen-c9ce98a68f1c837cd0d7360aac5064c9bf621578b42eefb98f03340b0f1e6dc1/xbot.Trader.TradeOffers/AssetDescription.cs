using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class AssetDescription
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private List<Description> list_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private List<OwnerAction> list_1;

	[CompilerGenerated]
	private string string_5;

	[CompilerGenerated]
	private string string_6;

	[CompilerGenerated]
	private string string_7;

	[CompilerGenerated]
	private string string_8;

	[CompilerGenerated]
	private string string_9;

	[JsonProperty("appid")]
	public int AppId
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

	[JsonProperty("classid")]
	public string ClassId
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

	[JsonProperty("instanceid")]
	public string InstanceId
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

	[JsonProperty("currency")]
	public bool IsCurrency
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

	[JsonProperty("background_color")]
	public string BackgroundColor
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	[JsonProperty("icon_url")]
	public string IconUrl
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	[JsonProperty("icon_url_large")]
	public string IconUrlLarge
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	[JsonProperty("descriptions")]
	public List<Description> Descriptions
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

	[JsonProperty("tradable")]
	public bool IsTradable
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

	[JsonProperty("owner_actions")]
	public List<OwnerAction> OwnerActions
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
		[CompilerGenerated]
		set
		{
			list_1 = value;
		}
	}

	[JsonProperty("name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	[JsonProperty("name_color")]
	public string NameColor
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
		[CompilerGenerated]
		set
		{
			string_6 = value;
		}
	}

	[JsonProperty("type")]
	public string Type
	{
		[CompilerGenerated]
		get
		{
			return string_7;
		}
		[CompilerGenerated]
		set
		{
			string_7 = value;
		}
	}

	[JsonProperty("market_name")]
	public string MarketName
	{
		[CompilerGenerated]
		get
		{
			return string_8;
		}
		[CompilerGenerated]
		set
		{
			string_8 = value;
		}
	}

	[JsonProperty("market_hash_name")]
	public string MarketHashName
	{
		[CompilerGenerated]
		get
		{
			return string_9;
		}
		[CompilerGenerated]
		set
		{
			string_9 = value;
		}
	}

	public AssetDescription()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
