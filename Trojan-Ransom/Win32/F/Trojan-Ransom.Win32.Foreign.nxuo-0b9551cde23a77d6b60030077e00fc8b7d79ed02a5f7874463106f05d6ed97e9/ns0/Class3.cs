using System.Security.Cryptography;

namespace ns0;

internal class Class3
{
	private SymmetricAlgorithm symmetricAlgorithm_0 = Rijndael.Create();

	public byte[] Byte_0
	{
		set
		{
			symmetricAlgorithm_0.Key = value;
		}
	}

	public byte[] Byte_1
	{
		set
		{
			symmetricAlgorithm_0.IV = value;
		}
	}

	public byte[] method_0(byte[] byte_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor().TransformFinalBlock(byte_0, 0, byte_0.Length);
	}
}
