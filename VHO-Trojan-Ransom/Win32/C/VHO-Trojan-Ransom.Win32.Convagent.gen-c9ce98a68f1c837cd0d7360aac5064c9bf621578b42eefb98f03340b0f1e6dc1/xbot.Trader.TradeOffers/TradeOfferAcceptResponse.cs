using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class TradeOfferAcceptResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public bool Accepted
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

	[JsonProperty("tradeid")]
	public string TradeId
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

	public TradeOfferAcceptResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		TradeId = string.Empty;
		TradeError = string.Empty;
	}
}
