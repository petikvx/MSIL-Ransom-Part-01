using System.Runtime.InteropServices;

namespace Gecko;

[StructLayout(LayoutKind.Sequential)]
public class gfxMatrix
{
	public double xx;

	public double yx;

	public double xy;

	public double yy;

	public double x0;

	public double y0;
}
