using System;

namespace White.Core.WindowsAPI;

public struct MouseInput
{
	private readonly int dx;

	private readonly int dy;

	private readonly int mouseData;

	private readonly int dwFlags;

	private readonly int time;

	private readonly IntPtr dwExtraInfo;

	public MouseInput(int dwFlags, IntPtr dwExtraInfo)
	{
		this.dwFlags = dwFlags;
		this.dwExtraInfo = dwExtraInfo;
		dx = 0;
		dy = 0;
		time = 0;
		mouseData = 0;
	}
}
