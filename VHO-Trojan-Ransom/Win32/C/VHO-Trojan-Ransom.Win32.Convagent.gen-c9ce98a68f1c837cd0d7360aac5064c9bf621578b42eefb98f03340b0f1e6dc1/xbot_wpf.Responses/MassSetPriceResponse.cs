using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace xbot_wpf.Responses;

public class MassSetPriceResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private List<MassSetPriceResponseItems> list_0;

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

	public List<MassSetPriceResponseItems> items
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

	public MassSetPriceResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
