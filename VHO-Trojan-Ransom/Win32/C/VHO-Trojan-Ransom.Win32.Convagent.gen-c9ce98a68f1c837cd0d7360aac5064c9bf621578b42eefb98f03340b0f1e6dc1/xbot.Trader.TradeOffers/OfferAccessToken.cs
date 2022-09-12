using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class OfferAccessToken
{
	[CompilerGenerated]
	private string string_0;

	[JsonProperty("trade_offer_access_token")]
	public string TradeOfferAccessToken
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

	public OfferAccessToken()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
