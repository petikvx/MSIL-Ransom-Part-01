using System.Runtime.CompilerServices;

namespace xClient.Core.Helper;

public static class CryptographyHelper
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool AreEqual(byte[] a1, byte[] a2)
	{
		bool result = true;
		for (int i = 0; i < a1.Length; i++)
		{
			if (a1[i] != a2[i])
			{
				result = false;
			}
		}
		return result;
	}
}
