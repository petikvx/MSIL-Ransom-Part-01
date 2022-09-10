using System;
using System.Drawing;
using Microsoft.DirectX.Direct3D;

public class D3DXFont : IDisposable
{
	protected Font systemFont;

	private Font drawingFont;

	public D3DXFont(Font f)
	{
		drawingFont = null;
		systemFont = f;
	}

	public D3DXFont(string strFontName)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		drawingFont = null;
		systemFont = new Font(strFontName, 12f);
	}

	public D3DXFont(string strFontName, FontStyle Style)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		drawingFont = null;
		systemFont = new Font(strFontName, 12f, Style);
	}

	public D3DXFont(string strFontName, FontStyle Style, int size)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		drawingFont = null;
		systemFont = new Font(strFontName, (float)size, Style);
	}

	public void InitializeDeviceObjects(Device dev)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		drawingFont = new Font(dev, systemFont);
	}

	public void BeginText()
	{
		if (drawingFont != null)
		{
			drawingFont.Begin();
		}
	}

	public void DrawText(int x, int y, int color, string strText)
	{
		if (drawingFont != null)
		{
			Rectangle rectangle = new Rectangle(x, y, 0, 0);
			drawingFont.DrawText(strText, rectangle, (DrawTextFormat)0, color);
		}
	}

	public void EndText()
	{
		if (drawingFont != null)
		{
			drawingFont.End();
		}
	}

	public void Dispose()
	{
		if (systemFont != null)
		{
			systemFont.Dispose();
		}
		systemFont = null;
	}
}
