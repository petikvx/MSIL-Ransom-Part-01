using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class BuyOffersResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private List<Offers> list_0;

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

	public string best_offer
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

	[JsonConverter(typeof(SingleValueArrayConverter<Offers>))]
	public List<Offers> offers
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

	public BuyOffersResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
