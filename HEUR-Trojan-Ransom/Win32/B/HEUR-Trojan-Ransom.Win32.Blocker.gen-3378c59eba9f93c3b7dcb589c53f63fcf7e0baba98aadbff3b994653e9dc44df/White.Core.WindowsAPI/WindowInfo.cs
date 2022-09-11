using System.Drawing;

namespace White.Core.WindowsAPI;

public struct WindowInfo
{
	public uint size;

	public Rectangle layout;

	public Rectangle clientLayout;

	public uint style;

	public uint exStyle;

	public uint activeStatus;

	public uint borderWidth;

	public uint borderHeight;

	public ushort atom;

	public ushort windowVersion;
}
