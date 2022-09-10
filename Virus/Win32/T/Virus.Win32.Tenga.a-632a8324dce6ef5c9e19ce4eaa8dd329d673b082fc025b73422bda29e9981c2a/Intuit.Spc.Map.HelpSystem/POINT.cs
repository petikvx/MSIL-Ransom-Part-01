using System.Runtime.InteropServices;

namespace Intuit.Spc.Map.HelpSystem;

[ComVisible(false)]
public struct POINT
{
	public int X;

	public int Y;

	public POINT(int x, int y)
	{
		X = x;
		Y = y;
	}
}
