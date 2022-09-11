using System;
using System.Linq;

namespace TrueCrypter.Ransomware.Core.Misc;

public class Utility
{
	public static byte[] StringToByteArray(string hex)
	{
		return (from x in Enumerable.Range(0, hex.Length)
			where x % 2 == 0
			select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
	}
}
