using System;

namespace SteamAuth;

public class Util
{
	public static long GetSystemUnixTime()
	{
		return (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
	}

	public static byte[] HexStringToByteArray(string hex)
	{
		int length = hex.Length;
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
		}
		return array;
	}

	public Util()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
