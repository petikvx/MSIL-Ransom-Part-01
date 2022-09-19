using System;
using System.Drawing;

public class GEventArgs4 : EventArgs
{
	private Bitmap bitmap_0;

	public Bitmap Frame => bitmap_0;

	public GEventArgs4(Bitmap frame)
	{
		bitmap_0 = frame;
	}
}
