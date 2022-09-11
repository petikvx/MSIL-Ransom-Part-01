using System.Drawing;

namespace White.Core.WindowsAPI;

public struct WindowPlacement
{
	public uint Length;

	public uint Flags;

	public uint ShowCMD;

	public Point MinmizedPosition;

	public Point MaximizedPosition;

	public Rectangle NormalPosition;
}
