using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class ParallelHash : IDigest, IXof
{
	private static readonly byte[] N_PARALLEL_HASH = Strings.ToByteArray("ParallelHash");

	private readonly CShakeDigest cshake;

	private readonly CShakeDigest compressor;

	private readonly int bitLength;

	private readonly int outputLength;

	private readonly int B;

	private readonly byte[] buffer;

	private readonly byte[] compressorBuffer;

	private bool firstOutput;

	private int nCount;

	private int bufOff;

	public virtual string AlgorithmName => "ParallelHash" + cshake.AlgorithmName.Substring(6);

	public ParallelHash(int bitLength, byte[] S, int B)
		: this(bitLength, S, B, bitLength * 2)
	{
	}

	public ParallelHash(int bitLength, byte[] S, int B, int outputSize)
	{
		cshake = new CShakeDigest(bitLength, N_PARALLEL_HASH, S);
		compressor = new CShakeDigest(bitLength, new byte[0], new byte[0]);
		this.bitLength = bitLength;
		this.B = B;
		outputLength = (outputSize + 7) / 8;
		buffer = new byte[B];
		compressorBuffer = new byte[bitLength * 2 / 8];
		Reset();
	}

	public ParallelHash(ParallelHash source)
	{
		cshake = new CShakeDigest(source.cshake);
		compressor = new CShakeDigest(source.compressor);
		bitLength = source.bitLength;
		B = source.B;
		outputLength = source.outputLength;
		buffer = Arrays.Clone(source.buffer);
		compressorBuffer = Arrays.Clone(source.compressorBuffer);
	}

	public virtual int GetByteLength()
	{
		return cshake.GetByteLength();
	}

	public virtual int GetDigestSize()
	{
		return outputLength;
	}

	public virtual void Update(byte b)
	{
		buffer[bufOff++] = b;
		if (bufOff == buffer.Length)
		{
			compress();
		}
	}

	public virtual void BlockUpdate(byte[] inBuf, int inOff, int len)
	{
		len = System.Math.Max(0, len);
		int i = 0;
		if (bufOff != 0)
		{
			while (i < len && bufOff != buffer.Length)
			{
				buffer[bufOff++] = inBuf[inOff + i++];
			}
			if (bufOff == buffer.Length)
			{
				compress();
			}
		}
		if (i < len)
		{
			for (; len - i > B; i += B)
			{
				compress(inBuf, inOff + i, B);
			}
		}
		while (i < len)
		{
			Update(inBuf[inOff + i++]);
		}
	}

	private void compress()
	{
		compress(buffer, 0, bufOff);
		bufOff = 0;
	}

	private void compress(byte[] buf, int offSet, int len)
	{
		compressor.BlockUpdate(buf, offSet, len);
		compressor.DoFinal(compressorBuffer, 0, compressorBuffer.Length);
		cshake.BlockUpdate(compressorBuffer, 0, compressorBuffer.Length);
		nCount++;
	}

	private void wrapUp(int outputSize)
	{
		if (bufOff != 0)
		{
			compress();
		}
		byte[] array = XofUtilities.RightEncode(nCount);
		byte[] array2 = XofUtilities.RightEncode(outputSize * 8);
		cshake.BlockUpdate(array, 0, array.Length);
		cshake.BlockUpdate(array2, 0, array2.Length);
		firstOutput = false;
	}

	public virtual int DoFinal(byte[] outBuf, int outOff)
	{
		if (firstOutput)
		{
			wrapUp(outputLength);
		}
		int result = cshake.DoFinal(outBuf, outOff, GetDigestSize());
		Reset();
		return result;
	}

	public virtual int DoFinal(byte[] outBuf, int outOff, int outLen)
	{
		if (firstOutput)
		{
			wrapUp(outputLength);
		}
		int result = cshake.DoFinal(outBuf, outOff, outLen);
		Reset();
		return result;
	}

	public virtual int DoOutput(byte[] outBuf, int outOff, int outLen)
	{
		if (firstOutput)
		{
			wrapUp(0);
		}
		return cshake.DoOutput(outBuf, outOff, outLen);
	}

	public virtual void Reset()
	{
		cshake.Reset();
		Arrays.Clear(buffer);
		byte[] array = XofUtilities.LeftEncode(B);
		cshake.BlockUpdate(array, 0, array.Length);
		nCount = 0;
		bufOff = 0;
		firstOutput = true;
	}
}
