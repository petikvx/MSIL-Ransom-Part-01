using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class NewTradeOfferResponse
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

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

	[JsonProperty("strError")]
	public string TradeError
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

	public NewTradeOfferResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
