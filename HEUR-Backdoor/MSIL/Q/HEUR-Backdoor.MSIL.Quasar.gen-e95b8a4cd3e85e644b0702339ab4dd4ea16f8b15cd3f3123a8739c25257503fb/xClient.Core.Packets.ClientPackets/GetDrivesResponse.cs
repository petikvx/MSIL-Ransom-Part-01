using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDrivesResponse : IPacket
{
	public string[] DriveDisplayName { get; set; }

	public string[] RootDirectory { get; set; }

	public GetDrivesResponse()
	{
	}

	public GetDrivesResponse(string[] driveDisplayName, string[] rootDirectory)
	{
		DriveDisplayName = driveDisplayName;
		RootDirectory = rootDirectory;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
