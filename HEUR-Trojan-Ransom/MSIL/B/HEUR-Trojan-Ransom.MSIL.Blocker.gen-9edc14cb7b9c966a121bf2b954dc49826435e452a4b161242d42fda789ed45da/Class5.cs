using System;
using System.Security.Cryptography;

internal sealed class Class5 : SymmetricAlgorithm, IDisposable, ICryptoTransform
{
	private Random random_0;

	public bool CanReuseTransform => true;

	public bool CanTransformMultipleBlocks => true;

	public int InputBlockSize => 16;

	public int OutputBlockSize => 16;

	public Class5()
	{
		random_0 = new Random(DateTime.Now.Millisecond);
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(128, 128, 0)
		};
		KeySize = 128;
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(128, 128, 0)
		};
		BlockSize = 128;
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		rgbKey.CopyTo(Key, 0);
		rgbIV.CopyTo(IV, 0);
		return this;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		rgbKey.CopyTo(Key, 0);
		rgbIV.CopyTo(IV, 0);
		return this;
	}

	public override void GenerateIV()
	{
		byte[] array = new byte[16];
		random_0.NextBytes(array);
		IV = array;
	}

	public override void GenerateKey()
	{
		byte[] array = new byte[16];
		random_0.NextBytes(array);
		Key = array;
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		int num = Key.Length;
		int num2 = IV.Length;
		for (int i = 0; i < inputCount; i++)
		{
			int num3 = IV[i % num2];
			outputBuffer[i + outputOffset] = (byte)(inputBuffer[i + inputOffset] ^ Key[num3 % num]);
		}
		return inputCount;
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		byte[] array = new byte[inputCount];
		TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
		return array;
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			24 => 12, 
			26 => 2, 
			14 => -2, 
			15 => 26, 
			16 => -16, 
			20 => 10, 
			_ => -1, 
		};
	}

	internal static int smethod_1(int int_0)
	{
		return int_0 switch
		{
			68 => 11, 
			69 => -122, 
			72 => -8, 
			73 => 122, 
			76 => -6, 
			_ => -1, 
		};
	}
}
