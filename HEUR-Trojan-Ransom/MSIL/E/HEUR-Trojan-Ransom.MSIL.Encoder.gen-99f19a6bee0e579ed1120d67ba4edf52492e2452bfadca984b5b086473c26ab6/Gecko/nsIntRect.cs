using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class nsIntRect
{
	public int X;

	public int Y;

	public int Width;

	public int Height;
}
