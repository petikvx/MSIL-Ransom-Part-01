using System.Threading;

namespace IntelliLock.Licensing;

[Attribute1(Exclude = true, ApplyToMembers = true, StripAfterObfuscation = true)]
internal class DataSignHelper
{
	internal static byte[] decrypted;

	public static bool VerifySignature(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0007, IL_0015, IL_001c, IL_0038, IL_0046
		//IL_0009: Expected O, but got Unknown
		bool flag = false;
		try
		{
			/*Error near IL_0002: Invalid metadata token*/;
		}
		finally
		{
			if (flag)
			{
				object obj = default(object);
				Monitor.Exit(obj);
			}
		}
	}

	public static byte[] DecryptData(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0012, IL_0020, IL_0027, IL_0043, IL_004f
		//IL_0014: Expected O, but got Unknown
		decrypted = new byte[0];
		bool flag = false;
		try
		{
			/*Error near IL_000d: Invalid metadata token*/;
		}
		finally
		{
			if (flag)
			{
				object obj = default(object);
				Monitor.Exit(obj);
			}
		}
	}

	static DataSignHelper()
	{
		decrypted = new byte[0];
	}
}
