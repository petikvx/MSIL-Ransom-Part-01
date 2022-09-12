using System.Security.Cryptography;

namespace ns0;

internal class Class8
{
	private const int int_0 = 32;

	public byte[] method_0()
	{
		byte[] array = new byte[Class9.smethod_0(652)];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = Delegate236.smethod_0();
		try
		{
			for (int i = Class9.smethod_0(656); i < Class9.smethod_0(664); i += Class9.smethod_0(660))
			{
				Delegate124.smethod_0(rNGCryptoServiceProvider, array);
			}
			return array;
		}
		finally
		{
			if (rNGCryptoServiceProvider != null)
			{
				Delegate191.smethod_0(rNGCryptoServiceProvider);
			}
		}
	}
}
