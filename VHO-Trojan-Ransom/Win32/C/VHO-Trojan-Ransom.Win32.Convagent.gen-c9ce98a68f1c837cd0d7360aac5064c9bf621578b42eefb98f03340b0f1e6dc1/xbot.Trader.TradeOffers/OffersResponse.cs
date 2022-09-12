using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class OffersResponse
{
	[CompilerGenerated]
	private List<Offer> list_0;

	[CompilerGenerated]
	private List<Offer> list_1;

	[CompilerGenerated]
	private List<AssetDescription> list_2;

	[JsonProperty("trade_offers_sent")]
	public List<Offer> TradeOffersSent
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

	[JsonProperty("trade_offers_received")]
	public List<Offer> TradeOffersReceived
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

	[JsonProperty("descriptions")]
	public List<AssetDescription> Descriptions
	{
		[CompilerGenerated]
		get
		{
			return list_2;
		}
		[CompilerGenerated]
		set
		{
			list_2 = value;
		}
	}

	public IEnumerable<Offer> AllOffers
	{
		get
		{
			if (TradeOffersSent == null)
			{
				return TradeOffersReceived;
			}
			if (TradeOffersReceived != null)
			{
				return TradeOffersSent.Union(TradeOffersReceived);
			}
			return TradeOffersSent;
		}
	}

	public OffersResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
