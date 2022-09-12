using System;
using System.Drawing;
using System.IO;

namespace Gecko;

public class ImageCreator
{
	private IGeckoWebBrowser m_browser;

	public ImageCreator(IGeckoWebBrowser browser)
	{
		m_browser = browser;
	}

	[Obsolete("Use CanvasGetPngImage", false)]
	public Bitmap CanvasGetBitmap(uint width, uint height)
	{
		return CanvasGetBitmap(0u, 0u, width, height);
	}

	[Obsolete("Use CanvasGetPngImage", false)]
	public Bitmap CanvasGetBitmap(uint xOffset, uint yOffset, uint width, uint height)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		byte[] buffer = CanvasGetPngImage(xOffset, yOffset, width, height);
		return (Bitmap)Image.FromStream((Stream)new MemoryStream(buffer));
	}

	public byte[] CanvasGetPngImage(uint xOffset, uint yOffset, uint width, uint height)
	{
		if (width == 0)
		{
			throw new ArgumentException("width");
		}
		if (height == 0)
		{
			throw new ArgumentException("height");
		}
		return Xpcom.ChromeContext.DrawWindow(m_browser.Window.DomWindow, xOffset, yOffset, width, height);
	}

	public byte[] CanvasGetPngImage(uint width, uint height)
	{
		return CanvasGetPngImage(0u, 0u, width, height);
	}
}
