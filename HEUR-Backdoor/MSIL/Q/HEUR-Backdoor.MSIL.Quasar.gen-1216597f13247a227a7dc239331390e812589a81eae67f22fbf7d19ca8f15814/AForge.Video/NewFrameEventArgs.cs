using System;
using System.Drawing;

namespace AForge.Video;

public class NewFrameEventArgs : EventArgs
{
	private Bitmap frame;

	public Bitmap Frame => frame;

	public NewFrameEventArgs(Bitmap frame)
	{
		this.frame = frame;
	}
}
