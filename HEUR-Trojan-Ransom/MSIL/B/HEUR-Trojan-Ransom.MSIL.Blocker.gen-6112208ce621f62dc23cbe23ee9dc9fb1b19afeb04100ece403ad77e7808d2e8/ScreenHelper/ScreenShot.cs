using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ScreenHelper;

internal class ScreenShot
{
	private struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	private struct POINT
	{
		public int x;

		public int y;
	}

	private struct CURSORINFO
	{
		public int cbSize;

		public int flags;

		public IntPtr hCursor;

		public POINT ptScreenPos;
	}

	private struct ICONINFO
	{
		public bool fIcon;

		public int xHotspot;

		public int yHotspot;

		public IntPtr hbmMask;

		public IntPtr hbmColor;
	}

	private static Thread thread;

	private static bool started;

	public static event Frame NewFrame;

	public static Image Window(IntPtr handle)
	{
		IntPtr windowDC = GetWindowDC(handle);
		RECT rect = default(RECT);
		GetWindowRect(handle, ref rect);
		int nWidth = rect.right - rect.left;
		int nHeight = rect.bottom - rect.top;
		IntPtr hdc = CreateCompatibleDC(windowDC);
		IntPtr intPtr = CreateCompatibleBitmap(windowDC, nWidth, nHeight);
		IntPtr hgdiobj = SelectObject(hdc, intPtr);
		BitBlt(hdc, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376u);
		SelectObject(hdc, hgdiobj);
		DeleteDC(hdc);
		ReleaseDC(handle, windowDC);
		Bitmap result = Image.FromHbitmap(intPtr);
		DeleteObject(intPtr);
		return (Image)(object)result;
	}

	public static void Start(bool withCursor, int quality)
	{
		if (started)
		{
			return;
		}
		started = true;
		thread = new Thread((ThreadStart)delegate
		{
			while (started)
			{
				if (ScreenShot.NewFrame != null)
				{
					ScreenShot.NewFrame(Get(withCursor, quality));
				}
			}
		});
		thread.Start();
	}

	public static void Stop()
	{
		started = false;
		if (thread != null)
		{
			thread.Abort();
		}
	}

	public static void Save(string filename = null, bool withCursor = true, int quality = 80)
	{
		Get(withCursor, quality).Save(filename);
	}

	public static Image Get(bool withCursor = true, int quality = 80)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
			Graphics.FromImage((Image)(object)val).CopyFromScreen(Screen.get_PrimaryScreen().get_Bounds().X, Screen.get_PrimaryScreen().get_Bounds().Y, 0, 0, ((Image)val).get_Size(), (CopyPixelOperation)13369376);
			Bitmap val2 = val;
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo val3 = null;
			ImageCodecInfo[] array = imageEncoders;
			foreach (ImageCodecInfo val4 in array)
			{
				if (val4.get_MimeType() == "image/jpeg")
				{
					val3 = val4;
				}
			}
			EncoderParameters val5 = new EncoderParameters();
			val5.get_Param()[0] = new EncoderParameter(Encoder.Quality, (long)quality);
			((Image)val2).Save((Stream)memoryStream, val3, val5);
			((Image)val2).Dispose();
			Image val6 = Image.FromStream((Stream)memoryStream);
			if (withCursor)
			{
				int x = Cursor.get_Position().X;
				int y = Cursor.get_Position().Y;
				Bitmap val7 = CaptureCursor(ref x, ref y);
				Graphics.FromImage(val6).DrawImage((Image)(object)val7, x, y, ((Image)val7).get_Width(), ((Image)val7).get_Height());
			}
			GC.Collect();
			return val6;
		}
		catch
		{
			return null;
		}
	}

	[DllImport("user32.dll")]
	private static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

	[DllImport("user32.dll")]
	private static extern IntPtr CopyIcon(IntPtr hIcon);

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out CURSORINFO pci);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDesktopWindow();

	[DllImport("gdi32.dll", SetLastError = true)]
	private static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);

	[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

	[DllImport("gdi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

	[DllImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteObject([In] IntPtr hObject);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteDC(IntPtr hdc);

	[DllImport("user32.dll")]
	private static extern IntPtr GetWindowDC(IntPtr hWnd);

	[DllImport("user32.dll")]
	private static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[DllImport("user32.dll")]
	private static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

	[DllImport("gdi32.dll")]
	private static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

	private static Bitmap CaptureCursor(ref int x, ref int y)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		try
		{
			CURSORINFO pci = default(CURSORINFO);
			pci.cbSize = Marshal.SizeOf((object)pci);
			if (!GetCursorInfo(out pci))
			{
				return null;
			}
			if (pci.flags != 1)
			{
				return null;
			}
			IntPtr intPtr = CopyIcon(pci.hCursor);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			if (!GetIconInfo(intPtr, out var piconinfo))
			{
				return null;
			}
			x = pci.ptScreenPos.x - piconinfo.xHotspot;
			y = pci.ptScreenPos.y - piconinfo.yHotspot;
			Bitmap val = Image.FromHbitmap(piconinfo.hbmMask);
			try
			{
				if (((Image)val).get_Height() == ((Image)val).get_Width() * 2)
				{
					Bitmap val2 = new Bitmap(((Image)val).get_Width(), ((Image)val).get_Width());
					Graphics val3 = Graphics.FromHwnd(GetDesktopWindow());
					IntPtr hdc = val3.GetHdc();
					IntPtr intPtr2 = CreateCompatibleDC(hdc);
					IntPtr hgdiobj = SelectObject(intPtr2, val.GetHbitmap());
					Graphics val4 = Graphics.FromImage((Image)(object)val2);
					try
					{
						IntPtr hdc2 = val4.GetHdc();
						BitBlt(hdc2, 0, 0, 32, 32, intPtr2, 0, 32, 13369376u);
						BitBlt(hdc2, 0, 0, 32, 32, intPtr2, 0, 0, 6684742u);
						val4.ReleaseHdc(hdc2);
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
					DeleteObject(SelectObject(intPtr2, hgdiobj));
					DeleteDC(intPtr2);
					val3.ReleaseHdc(hdc);
					val2.MakeTransparent(Color.White);
					return val2;
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return Icon.FromHandle(intPtr).ToBitmap();
		}
		catch
		{
			return null;
		}
	}
}
