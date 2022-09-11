using System;
using System.Security.Cryptography;

public sealed class GClass0 : IDisposable
{
	private GClass1 gclass1_0;

	public GClass0(GClass1 gclass1_1)
	{
		method_1(gclass1_1);
	}

	public GClass1 method_0()
	{
		return gclass1_0;
	}

	public void method_1(GClass1 gclass1_1)
	{
		gclass1_0 = gclass1_1;
	}

	public void Dispose()
	{
		GC.Collect();
		GC.SuppressFinalize(this);
	}

	public void method_2(ref byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				byte[] array = byte_0;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Key = byte_1;
				aesCryptoServiceProvider.IV = byte_2;
				aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				array = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV).TransformFinalBlock(array, 0, array.Length);
				byte_0 = array.smethod_3();
			}
			finally
			{
				((IDisposable)aesCryptoServiceProvider).Dispose();
			}
		}
		catch
		{
			Dispose();
		}
	}
}
