using SharpDX.Mathematics.Interop;

namespace Orcus.Commands.RemoteDesktop.Capture.DesktopDuplication;

public static class RawRectangleExtensions
{
	public static int GetWidth(this RawRectangle rawRectangle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return rawRectangle.Right - rawRectangle.Left;
	}

	public static int GetHeight(this RawRectangle rawRectangle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return rawRectangle.Bottom - rawRectangle.Top;
	}
}
