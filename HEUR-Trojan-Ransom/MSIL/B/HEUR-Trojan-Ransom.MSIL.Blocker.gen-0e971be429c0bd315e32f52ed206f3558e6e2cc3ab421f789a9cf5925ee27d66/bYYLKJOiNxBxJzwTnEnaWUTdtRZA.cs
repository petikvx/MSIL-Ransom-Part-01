using System;
using System.Security.Cryptography;

internal class bYYLKJOiNxBxJzwTnEnaWUTdtRZA : ULJWGavsRRCHpEiMCPcDBqznojIo, IDisposable, ICryptoTransform
{
	public bool CanReuseTransform => true;

	public bool CanTransformMultipleBlocks => true;

	public int InputBlockSize => 1;

	public int OutputBlockSize => 1;

	internal bYYLKJOiNxBxJzwTnEnaWUTdtRZA(byte[] keyBlock)
	{
		YNNwLeDKXVsbAYJLQIHGZOdrdpwo(keyBlock);
	}

	public void Dispose()
	{
		QAUcQcqMSxkpfuvnEqzXciYpNlzb();
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		for (int i = inputOffset; i < inputOffset + inputCount; i++)
		{
			byte b = (byte)(inputBuffer[i] ^ ssxcYpgWnuDDhYdzSptsYBCfEihIb());
			outputBuffer[outputOffset++] = b;
			MXWIDLAObHTOsHJEiyGLqukPeAFs(b);
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
