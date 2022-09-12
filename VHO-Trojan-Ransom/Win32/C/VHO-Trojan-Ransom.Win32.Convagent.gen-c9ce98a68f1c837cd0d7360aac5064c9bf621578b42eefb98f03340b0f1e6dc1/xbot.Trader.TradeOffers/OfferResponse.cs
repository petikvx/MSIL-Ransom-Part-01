using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class OfferResponse
{
	[CompilerGenerated]
	private Offer offer_0;

	[CompilerGenerated]
	private List<AssetDescription> list_0;

	[JsonProperty("offer")]
	public Offer Offer
	{
		[CompilerGenerated]
		get
		{
			return offer_0;
		}
		[CompilerGenerated]
		set
		{
			offer_0 = value;
		}
	}

	[JsonProperty("descriptions")]
	public List<AssetDescription> Descriptions
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

	public OfferResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
