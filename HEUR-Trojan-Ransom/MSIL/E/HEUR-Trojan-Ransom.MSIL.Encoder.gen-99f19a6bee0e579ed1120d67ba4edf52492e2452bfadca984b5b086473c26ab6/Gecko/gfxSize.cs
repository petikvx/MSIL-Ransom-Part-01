using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class gfxSize
{
	public double Width;

	public double Height;
}
