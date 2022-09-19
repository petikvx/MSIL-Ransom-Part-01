using System;
using System.Collections.Generic;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetPasswordsResponse : GInterface4
{
	public List<string> Passwords { get; set; }

	public GetPasswordsResponse()
	{
	}

	public GetPasswordsResponse(List<string> data)
	{
		Passwords = data;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
