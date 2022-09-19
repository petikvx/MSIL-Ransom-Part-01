using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class DoShellExecuteResponse : GInterface4
{
	public string Output { get; set; }

	public bool IsError { get; private set; }

	public DoShellExecuteResponse()
	{
	}

	public DoShellExecuteResponse(string output, bool isError = false)
	{
		Output = output;
		IsError = isError;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
