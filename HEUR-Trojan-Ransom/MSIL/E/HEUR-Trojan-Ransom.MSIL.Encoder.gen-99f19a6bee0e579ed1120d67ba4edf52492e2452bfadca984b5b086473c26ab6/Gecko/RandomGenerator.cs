using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko;

public static class RandomGenerator
{
	private static ComPtr<nsIRandomGenerator> _randomGenerator;

	static RandomGenerator()
	{
		_randomGenerator = Xpcom.GetService2<nsIRandomGenerator>("@mozilla.org/security/random-generator;1");
	}

	public static byte[] GenerateRandomBytes(int count)
	{
		byte[] array = new byte[count];
		_randomGenerator.Instance.GenerateRandomBytes((uint)count, out var aBuffer);
		Marshal.Copy(aBuffer, array, 0, count);
		Xpcom.free(aBuffer);
		return array;
	}
}
