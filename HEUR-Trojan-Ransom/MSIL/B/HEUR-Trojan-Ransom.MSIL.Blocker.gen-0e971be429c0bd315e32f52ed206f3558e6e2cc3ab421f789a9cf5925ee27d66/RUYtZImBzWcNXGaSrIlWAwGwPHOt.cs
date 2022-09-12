using System;
using System.Security.Cryptography;

internal class RUYtZImBzWcNXGaSrIlWAwGwPHOt : ULJWGavsRRCHpEiMCPcDBqznojIo, IDisposable, ICryptoTransform
{
	public bool CanReuseTransform => true;

	public bool CanTransformMultipleBlocks => true;

	public int InputBlockSize => 1;

	public int OutputBlockSize => 1;

	internal RUYtZImBzWcNXGaSrIlWAwGwPHOt(byte[] keyBlock)
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
			byte byte_ = inputBuffer[i];
			outputBuffer[outputOffset++] = (byte)(inputBuffer[i] ^ ssxcYpgWnuDDhYdzSptsYBCfEihIb());
			MXWIDLAObHTOsHJEiyGLqukPeAFs(byte_);
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
