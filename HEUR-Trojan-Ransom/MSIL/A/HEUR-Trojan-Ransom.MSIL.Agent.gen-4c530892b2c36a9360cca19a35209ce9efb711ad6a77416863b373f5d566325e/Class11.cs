using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

internal class Class11
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Rectangle rectangle_0;

	public Rectangle Rectangle_0
	{
		[CompilerGenerated]
		get
		{
			return rectangle_0;
		}
		[CompilerGenerated]
		set
		{
			rectangle_0 = value;
		}
	}

	public int method_0()
	{
		return Rectangle_0.Location.X;
	}

	public int method_1()
	{
		return Rectangle_0.Location.X + Rectangle_0.Width;
	}

	public int method_2()
	{
		return Rectangle_0.Location.Y;
	}

	public int method_3()
	{
		return Rectangle_0.Location.Y + Rectangle_0.Height;
	}

	public bool method_4(Class11 class11_0)
	{
		return Rectangle_0.IntersectsWith(class11_0.Rectangle_0);
	}
}
