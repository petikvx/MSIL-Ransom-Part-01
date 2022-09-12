using System;
using ICSharpCode.SharpZipLib.Checksums;

internal class NYXiJHJFKarnbvrHDjaarBimMwJG
{
	private uint[] zPCYOpLbOpBzkDXkABPuMVsPofsJA;

	protected void DpKtQTONKAKCvHfYHRdYQzfeGqip()
	{
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[0] = 0u;
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[1] = 0u;
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[2] = 0u;
	}

	protected void TaLzBLljFwToOpTcBYmxzvgyUKbj(byte[] keyData)
	{
		if (keyData == null)
		{
			throw new ArgumentNullException("keyData");
		}
		if (keyData.Length != 12)
		{
			throw new InvalidOperationException("Key length is not valid");
		}
		zPCYOpLbOpBzkDXkABPuMVsPofsJA = new uint[3];
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[0] = (uint)((keyData[3] << 24) | (keyData[2] << 16) | (keyData[1] << 8) | keyData[0]);
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[1] = (uint)((keyData[7] << 24) | (keyData[6] << 16) | (keyData[5] << 8) | keyData[4]);
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[2] = (uint)((keyData[11] << 24) | (keyData[10] << 16) | (keyData[9] << 8) | keyData[8]);
	}

	protected byte tdfwMNapdZbCfQKaXwtTxVScBFaE()
	{
		uint num = (zPCYOpLbOpBzkDXkABPuMVsPofsJA[2] & 0xFFFF) | 2;
		return (byte)(num * (num ^ 1) >> 8);
	}

	protected void JNUdneqmbeiuaggtdANwEYnSgnKp(byte byte_0)
	{
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[0] = Crc32.rMHzUuXnpZWTozvBrzTIEQrrTeoj(zPCYOpLbOpBzkDXkABPuMVsPofsJA[0], byte_0);
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[1] += (byte)zPCYOpLbOpBzkDXkABPuMVsPofsJA[0];
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[1] = zPCYOpLbOpBzkDXkABPuMVsPofsJA[1] * 134775813 + 1;
		zPCYOpLbOpBzkDXkABPuMVsPofsJA[2] = Crc32.rMHzUuXnpZWTozvBrzTIEQrrTeoj(zPCYOpLbOpBzkDXkABPuMVsPofsJA[2], (byte)(zPCYOpLbOpBzkDXkABPuMVsPofsJA[1] >> 24));
	}
}
