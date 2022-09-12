using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class OrderLogResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private List<OrderLog> list_0;

	public bool Success
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

	[JsonConverter(typeof(SingleValueArrayConverter<OrderLog>))]
	public List<OrderLog> Log
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

	public OrderLogResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
