using System;
using System.Security.Cryptography;

internal class wlYAjnegygJlvaIJeQFUmgHiQYWHc : NYXiJHJFKarnbvrHDjaarBimMwJG, IDisposable, ICryptoTransform
{
	public bool CanReuseTransform => true;

	public bool CanTransformMultipleBlocks => true;

	public int InputBlockSize => 1;

	public int OutputBlockSize => 1;

	internal wlYAjnegygJlvaIJeQFUmgHiQYWHc(byte[] keyBlock)
	{
		TaLzBLljFwToOpTcBYmxzvgyUKbj(keyBlock);
	}

	public void Dispose()
	{
		DpKtQTONKAKCvHfYHRdYQzfeGqip();
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		for (int i = inputOffset; i < inputOffset + inputCount; i++)
		{
			byte b = (byte)(inputBuffer[i] ^ tdfwMNapdZbCfQKaXwtTxVScBFaE());
			outputBuffer[outputOffset++] = b;
			JNUdneqmbeiuaggtdANwEYnSgnKp(b);
		}
		return inputCount;
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		byte[] array = new byte[inputCount];
		TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
		return array;
	}
}
