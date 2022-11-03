using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoRegedit : IPacket
{
	public string Text { get; set; }

	public DoRegedit()
	{
	}

	public DoRegedit(string text)
	{
		Text = text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
