using System;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

internal class RZBhemojFtizJixMGLGAqfPHOzTp
{
	private static readonly int[] mtrbsCshzhAvOJWNePXNdLaQMsIj = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	private byte[] pofySOLjDFCnRsOQqmFNTaFJIyHn;

	private const int XKyrrDKtGSjTcrToxluIIRWXwPIc = 3;

	private int VKgKXOaMcJPsQOzOGPwySBDfcOt;

	private const int aCDWUtVjDqewmXBjsPUqXGHVEYFT = 2;

	private InflaterHuffmanTree LGsfgafvlzDFCAFeApsvQKotstSwb;

	private int mDaBQFAjdPVeoEpczKKWaoqsuGxiA;

	private const int NRhXJkaajVabagEarpvHTIUCIKDEA = 1;

	private int MJKWhUrNwzNBdVNFDjpgJckseGKX;

	private int yctsBImRvXVwxzGHEoZUtliKoFTj;

	private byte eicKJQwkeSAEjFteiwHiSgcwhBJX;

	private const int XMCeBNAIBaKJkcbQKOLCQKmbnHJFd = 4;

	private byte[] grsWfkvmAvblfAAJUIYugFUJKVTlb;

	private int gtBTiwXkzjEzZhiuYwiAABSqsCUe;

	private const int CBsaEHMDWsSkMQkZYaidCpiPxiPIA = 0;

	private int LlcDOZFNqyDRAHCCbndwFtARpdUbb;

	private static readonly int[] xIBSPVHtFpGxUpqckpherqKjZZNK = new int[3] { 2, 3, 7 };

	private static readonly int[] mVKsOkmBsWuRqHCsZOUcsJpHbALT = new int[3] { 3, 3, 11 };

	private const int XUsePKiUFSLlsWWdtdDHYsBUdprNA = 5;

	private int dodYIsFHwCkPaeobovjREFtwSYtB;

	public InflaterHuffmanTree NxcRJcIKKAKiosUCHetBXldXWVDG()
	{
		byte[] array = new byte[mDaBQFAjdPVeoEpczKKWaoqsuGxiA];
		Array.Copy(grsWfkvmAvblfAAJUIYugFUJKVTlb, gtBTiwXkzjEzZhiuYwiAABSqsCUe, array, 0, mDaBQFAjdPVeoEpczKKWaoqsuGxiA);
		return new InflaterHuffmanTree(array);
	}

	public InflaterHuffmanTree FhPxuEZniFEojjUmScQpOKqHkxDU()
	{
		byte[] array = new byte[gtBTiwXkzjEzZhiuYwiAABSqsCUe];
		Array.Copy(grsWfkvmAvblfAAJUIYugFUJKVTlb, 0, array, 0, gtBTiwXkzjEzZhiuYwiAABSqsCUe);
		return new InflaterHuffmanTree(array);
	}

	public bool kTsqkBqwcoBtisrixuKpwDHQYxLQ(StreamManipulator input)
	{
		while (true)
		{
			switch (LlcDOZFNqyDRAHCCbndwFtARpdUbb)
			{
			case 5:
			{
				int bitCount = xIBSPVHtFpGxUpqckpherqKjZZNK[dodYIsFHwCkPaeobovjREFtwSYtB];
				int num = input.PeekBits(bitCount);
				if (num >= 0)
				{
					input.DropBits(bitCount);
					num += mVKsOkmBsWuRqHCsZOUcsJpHbALT[dodYIsFHwCkPaeobovjREFtwSYtB];
					if (yctsBImRvXVwxzGHEoZUtliKoFTj + num <= MJKWhUrNwzNBdVNFDjpgJckseGKX)
					{
						while (num-- > 0)
						{
							grsWfkvmAvblfAAJUIYugFUJKVTlb[yctsBImRvXVwxzGHEoZUtliKoFTj++] = eicKJQwkeSAEjFteiwHiSgcwhBJX;
						}
						if (yctsBImRvXVwxzGHEoZUtliKoFTj == MJKWhUrNwzNBdVNFDjpgJckseGKX)
						{
							return true;
						}
						goto IL_008f;
					}
					throw new SharpZipBaseException();
				}
				return false;
			}
			case 4:
			{
				int symbol;
				while (((symbol = LGsfgafvlzDFCAFeApsvQKotstSwb.GetSymbol(input)) & -16) == 0)
				{
					grsWfkvmAvblfAAJUIYugFUJKVTlb[yctsBImRvXVwxzGHEoZUtliKoFTj++] = (eicKJQwkeSAEjFteiwHiSgcwhBJX = (byte)symbol);
					if (yctsBImRvXVwxzGHEoZUtliKoFTj == MJKWhUrNwzNBdVNFDjpgJckseGKX)
					{
						return true;
					}
				}
				if (symbol >= 0)
				{
					if (symbol < 17)
					{
						if (yctsBImRvXVwxzGHEoZUtliKoFTj == 0)
						{
							throw new SharpZipBaseException();
						}
					}
					else
					{
						eicKJQwkeSAEjFteiwHiSgcwhBJX = 0;
					}
					dodYIsFHwCkPaeobovjREFtwSYtB = symbol - 16;
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (yctsBImRvXVwxzGHEoZUtliKoFTj < VKgKXOaMcJPsQOzOGPwySBDfcOt)
				{
					int num2 = input.PeekBits(3);
					if (num2 >= 0)
					{
						input.DropBits(3);
						pofySOLjDFCnRsOQqmFNTaFJIyHn[mtrbsCshzhAvOJWNePXNdLaQMsIj[yctsBImRvXVwxzGHEoZUtliKoFTj]] = (byte)num2;
						yctsBImRvXVwxzGHEoZUtliKoFTj++;
						continue;
					}
					return false;
				}
				LGsfgafvlzDFCAFeApsvQKotstSwb = new InflaterHuffmanTree(pofySOLjDFCnRsOQqmFNTaFJIyHn);
				pofySOLjDFCnRsOQqmFNTaFJIyHn = null;
				yctsBImRvXVwxzGHEoZUtliKoFTj = 0;
				LlcDOZFNqyDRAHCCbndwFtARpdUbb = 4;
				goto case 4;
			case 2:
				VKgKXOaMcJPsQOzOGPwySBDfcOt = input.PeekBits(4);
				if (VKgKXOaMcJPsQOzOGPwySBDfcOt >= 0)
				{
					VKgKXOaMcJPsQOzOGPwySBDfcOt += 4;
					input.DropBits(4);
					pofySOLjDFCnRsOQqmFNTaFJIyHn = new byte[19];
					yctsBImRvXVwxzGHEoZUtliKoFTj = 0;
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 3;
					goto case 3;
				}
				return false;
			case 1:
				mDaBQFAjdPVeoEpczKKWaoqsuGxiA = input.PeekBits(5);
				if (mDaBQFAjdPVeoEpczKKWaoqsuGxiA >= 0)
				{
					mDaBQFAjdPVeoEpczKKWaoqsuGxiA++;
					input.DropBits(5);
					MJKWhUrNwzNBdVNFDjpgJckseGKX = gtBTiwXkzjEzZhiuYwiAABSqsCUe + mDaBQFAjdPVeoEpczKKWaoqsuGxiA;
					grsWfkvmAvblfAAJUIYugFUJKVTlb = new byte[MJKWhUrNwzNBdVNFDjpgJckseGKX];
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 2;
					goto case 2;
				}
				return false;
			case 0:
				gtBTiwXkzjEzZhiuYwiAABSqsCUe = input.PeekBits(5);
				if (gtBTiwXkzjEzZhiuYwiAABSqsCUe >= 0)
				{
					gtBTiwXkzjEzZhiuYwiAABSqsCUe += 257;
					input.DropBits(5);
					LlcDOZFNqyDRAHCCbndwFtARpdUbb = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_008f:
			LlcDOZFNqyDRAHCCbndwFtARpdUbb = 4;
		}
	}
}
