using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class Pkcs7Padding : IBlockCipherPadding
{
	public string PaddingName => "PKCS7";

	public void Init(SecureRandom random)
	{
	}

	public int AddPadding(byte[] input, int inOff)
	{
		byte b = (byte)(input.Length - inOff);
		while (inOff < input.Length)
		{
			input[inOff] = b;
			inOff++;
		}
		return b;
	}

	public int PadCount(byte[] input)
	{
		byte b = input[^1];
		int num = b;
		if (num >= 1 && num <= input.Length)
		{
			for (int i = 2; i <= num; i++)
			{
				if (input[^i] != b)
				{
					throw new InvalidCipherTextException("pad block corrupted");
				}
			}
			return num;
		}
		throw new InvalidCipherTextException("pad block corrupted");
	}
}
