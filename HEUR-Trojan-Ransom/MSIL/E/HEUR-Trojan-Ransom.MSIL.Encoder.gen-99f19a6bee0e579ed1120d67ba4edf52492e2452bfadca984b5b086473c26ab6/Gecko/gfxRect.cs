using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class gfxRect
{
	public double X;

	public double Y;

	public double Width;

	public double Height;
}
