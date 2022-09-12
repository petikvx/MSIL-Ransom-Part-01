using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class Offer
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private TradeOfferState tradeOfferState_0;

	[CompilerGenerated]
	private List<CEconAsset> list_0;

	[CompilerGenerated]
	private List<CEconAsset> list_1;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private int int_5;

	[JsonProperty("tradeofferid")]
	public string TradeOfferId
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

	[JsonProperty("accountid_other")]
	public int AccountIdOther
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

	[JsonProperty("message")]
	public string Message
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

	[JsonProperty("expiration_time")]
	public int ExpirationTime
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

	[JsonProperty("trade_offer_state")]
	public TradeOfferState TradeOfferState
	{
		[CompilerGenerated]
		get
		{
			return tradeOfferState_0;
		}
		[CompilerGenerated]
		set
		{
			tradeOfferState_0 = value;
		}
	}

	[JsonProperty("items_to_give")]
	public List<CEconAsset> ItemsToGive
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

	[JsonProperty("items_to_receive")]
	public List<CEconAsset> ItemsToReceive
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

	[JsonProperty("is_our_offer")]
	public bool IsOurOffer
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

	[JsonProperty("time_created")]
	public int TimeCreated
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

	[JsonProperty("time_updated")]
	public int TimeUpdated
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	[JsonProperty("from_real_time_trade")]
	public bool FromRealTimeTrade
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

	[JsonProperty("escrow_end_date")]
	public int EscrowEndDate
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		set
		{
			int_4 = value;
		}
	}

	[JsonProperty("confirmation_method")]
	private int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_5;
		}
		[CompilerGenerated]
		set
		{
			int_5 = value;
		}
	}

	public TradeOfferConfirmationMethod ConfirmationMethod
	{
		get
		{
			return (TradeOfferConfirmationMethod)Int32_0;
		}
		set
		{
			Int32_0 = (int)value;
		}
	}

	public Offer()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
