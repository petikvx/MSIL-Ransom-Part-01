using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot_wpf.Responses;

public class GetInvResponse
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private List<GetInvData> list_0;

	public bool ok
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

	[JsonConverter(typeof(SingleValueArrayConverter<GetInvData>))]
	public List<GetInvData> data
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

	public GetInvResponse()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
