using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class GetMySellOffersResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private List<GetMySellOffersOffers> list_0;

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

	[JsonConverter(typeof(SingleValueArrayConverter<GetMySellOffersOffers>))]
	public List<GetMySellOffersOffers> offers
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

	public GetMySellOffersResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
