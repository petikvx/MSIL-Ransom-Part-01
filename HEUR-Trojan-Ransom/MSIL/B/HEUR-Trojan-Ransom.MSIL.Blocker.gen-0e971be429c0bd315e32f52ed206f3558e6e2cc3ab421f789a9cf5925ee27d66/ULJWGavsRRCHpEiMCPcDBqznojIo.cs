using System;
using ICSharpCode.SharpZipLib.Checksums;

internal class ULJWGavsRRCHpEiMCPcDBqznojIo
{
	private uint[] wvAaoYjbQGNxmquBVSCFzanScEty;

	protected void QAUcQcqMSxkpfuvnEqzXciYpNlzb()
	{
		wvAaoYjbQGNxmquBVSCFzanScEty[0] = 0u;
		wvAaoYjbQGNxmquBVSCFzanScEty[1] = 0u;
		wvAaoYjbQGNxmquBVSCFzanScEty[2] = 0u;
	}

	protected void YNNwLeDKXVsbAYJLQIHGZOdrdpwo(byte[] keyData)
	{
		if (keyData == null)
		{
			throw new ArgumentNullException("keyData");
		}
		if (keyData.Length != 12)
		{
			throw new InvalidOperationException("Key length is not valid");
		}
		wvAaoYjbQGNxmquBVSCFzanScEty = new uint[3];
		wvAaoYjbQGNxmquBVSCFzanScEty[0] = (uint)((keyData[3] << 24) | (keyData[2] << 16) | (keyData[1] << 8) | keyData[0]);
		wvAaoYjbQGNxmquBVSCFzanScEty[1] = (uint)((keyData[7] << 24) | (keyData[6] << 16) | (keyData[5] << 8) | keyData[4]);
		wvAaoYjbQGNxmquBVSCFzanScEty[2] = (uint)((keyData[11] << 24) | (keyData[10] << 16) | (keyData[9] << 8) | keyData[8]);
	}

	protected byte ssxcYpgWnuDDhYdzSptsYBCfEihIb()
	{
		uint num = (wvAaoYjbQGNxmquBVSCFzanScEty[2] & 0xFFFFu) | 2u;
		return (byte)(num * (num ^ 1) >> 8);
	}

	protected void MXWIDLAObHTOsHJEiyGLqukPeAFs(byte byte_0)
	{
		wvAaoYjbQGNxmquBVSCFzanScEty[0] = Crc32.eYHsRRzcjaMiiOysgfqpigqkpizq(wvAaoYjbQGNxmquBVSCFzanScEty[0], byte_0);
		wvAaoYjbQGNxmquBVSCFzanScEty[1] += (byte)wvAaoYjbQGNxmquBVSCFzanScEty[0];
		wvAaoYjbQGNxmquBVSCFzanScEty[1] = wvAaoYjbQGNxmquBVSCFzanScEty[1] * 134775813 + 1;
		wvAaoYjbQGNxmquBVSCFzanScEty[2] = Crc32.eYHsRRzcjaMiiOysgfqpigqkpizq(wvAaoYjbQGNxmquBVSCFzanScEty[2], (byte)(wvAaoYjbQGNxmquBVSCFzanScEty[1] >> 24));
	}
}
