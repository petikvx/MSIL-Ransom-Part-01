using System;
using System.Security.Cryptography;

internal class ShIttzIlmvEjBjrbkaEvgiNheXXI : NYXiJHJFKarnbvrHDjaarBimMwJG, IDisposable, ICryptoTransform
{
	public bool CanReuseTransform => true;

	public bool CanTransformMultipleBlocks => true;

	public int InputBlockSize => 1;

	public int OutputBlockSize => 1;

	internal ShIttzIlmvEjBjrbkaEvgiNheXXI(byte[] keyBlock)
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
			byte byte_ = inputBuffer[i];
			outputBuffer[outputOffset++] = (byte)(inputBuffer[i] ^ tdfwMNapdZbCfQKaXwtTxVScBFaE());
			JNUdneqmbeiuaggtdANwEYnSgnKp(byte_);
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
