using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class ApiResponse<T>
{
	[CompilerGenerated]
	private T gparam_0;

	[JsonProperty("response")]
	public T Response
	{
		[CompilerGenerated]
		get
		{
			return gparam_0;
		}
		[CompilerGenerated]
		set
		{
			gparam_0 = value;
		}
	}

	public ApiResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
