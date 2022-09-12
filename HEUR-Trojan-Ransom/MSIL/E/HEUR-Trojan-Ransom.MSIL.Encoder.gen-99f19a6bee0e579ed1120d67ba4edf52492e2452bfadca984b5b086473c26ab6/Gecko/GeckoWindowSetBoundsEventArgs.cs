using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gecko;

public class GeckoWindowSetBoundsEventArgs : EventArgs
{
	public readonly Rectangle Bounds;

	public readonly BoundsSpecified BoundsSpecified;

	public GeckoWindowSetBoundsEventArgs(Rectangle bounds, BoundsSpecified specified)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Bounds = bounds;
		BoundsSpecified = specified;
	}
}
