using System;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

internal class MRDrLLWIBILNBVEdFnBrGlUQdOYp
{
	private static readonly int[] jnvxNnCMbYEmEcVmlsKuDpvBErPo = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	private byte[] cctAKfGtJqqcTDTzannyDvQzIRAgB;

	private const int SEotRaqrxnFDiaGagskzfoIQzZICA = 3;

	private int ETSbSmkoADMxwQtUXRQPoEUQWHXOA;

	private const int hiBoCUjGHFGDkcdSrAOVhiAUBzOEA = 2;

	private InflaterHuffmanTree MrqUZgFxQWnCEyNsorEOovGzQLHb;

	private int pqagpyLvmyGZmKLbyRLdIxwdzsWc;

	private const int SxdbVNWdryBOszgHgGsqkGTNnnYT = 1;

	private int HwALclJnmKEhvJkyEQoZKjdhqbRWA;

	private int dOvLMdEnpwinlAusVqzbBezROZEo;

	private byte tVqzilQjclVarkoJzJbToXrzFkUy;

	private const int GMLruZmJPgzaKAfVqQbrqpwPeEBA = 4;

	private byte[] tdeXYZLUHYZJnnamDDfBpXcZunUe;

	private int vEZRhLlQxQreZUDTFOpzuYUtqNDt;

	private const int LMghuuqiCPEYQjCaPPfCXJfCbBYW = 0;

	private int IUaiPypAyJprEbBfufyZPnRGIEHt;

	private static readonly int[] ypXdtgfHmILIWKZuhiaJPDbqwqSC = new int[3] { 2, 3, 7 };

	private static readonly int[] bJKavPUpallMyaONUXuVWeuQrZCg = new int[3] { 3, 3, 11 };

	private const int QzqzvOmBbbTuyfUFyGimMYLWOcAb = 5;

	private int cLeBsdGnRXNANKPZhEuCduAhdhNWB;

	public InflaterHuffmanTree ORqzdXygKbMmgZJdIoxijpyEphYL()
	{
		byte[] array = new byte[pqagpyLvmyGZmKLbyRLdIxwdzsWc];
		Array.Copy(tdeXYZLUHYZJnnamDDfBpXcZunUe, vEZRhLlQxQreZUDTFOpzuYUtqNDt, array, 0, pqagpyLvmyGZmKLbyRLdIxwdzsWc);
		return new InflaterHuffmanTree(array);
	}

	public InflaterHuffmanTree QtNMfvzDosYspEBuPLyIgjgMWGSf()
	{
		byte[] array = new byte[vEZRhLlQxQreZUDTFOpzuYUtqNDt];
		Array.Copy(tdeXYZLUHYZJnnamDDfBpXcZunUe, 0, array, 0, vEZRhLlQxQreZUDTFOpzuYUtqNDt);
		return new InflaterHuffmanTree(array);
	}

	public bool zbaWQsUFePKHcHJPiERAQKKLzQEQ(StreamManipulator input)
	{
		while (true)
		{
			switch (IUaiPypAyJprEbBfufyZPnRGIEHt)
			{
			case 5:
			{
				int bitCount = ypXdtgfHmILIWKZuhiaJPDbqwqSC[cLeBsdGnRXNANKPZhEuCduAhdhNWB];
				int num = input.PeekBits(bitCount);
				if (num >= 0)
				{
					input.DropBits(bitCount);
					num += bJKavPUpallMyaONUXuVWeuQrZCg[cLeBsdGnRXNANKPZhEuCduAhdhNWB];
					if (dOvLMdEnpwinlAusVqzbBezROZEo + num <= HwALclJnmKEhvJkyEQoZKjdhqbRWA)
					{
						while (num-- > 0)
						{
							tdeXYZLUHYZJnnamDDfBpXcZunUe[dOvLMdEnpwinlAusVqzbBezROZEo++] = tVqzilQjclVarkoJzJbToXrzFkUy;
						}
						if (dOvLMdEnpwinlAusVqzbBezROZEo == HwALclJnmKEhvJkyEQoZKjdhqbRWA)
						{
							return true;
						}
						goto IL_00a8;
					}
					throw new SharpZipBaseException();
				}
				return false;
			}
			case 4:
			{
				int symbol;
				while (((symbol = MrqUZgFxQWnCEyNsorEOovGzQLHb.GetSymbol(input)) & -16) == 0)
				{
					tdeXYZLUHYZJnnamDDfBpXcZunUe[dOvLMdEnpwinlAusVqzbBezROZEo++] = (tVqzilQjclVarkoJzJbToXrzFkUy = (byte)symbol);
					if (dOvLMdEnpwinlAusVqzbBezROZEo == HwALclJnmKEhvJkyEQoZKjdhqbRWA)
					{
						return true;
					}
				}
				if (symbol >= 0)
				{
					if (symbol < 17)
					{
						if (dOvLMdEnpwinlAusVqzbBezROZEo == 0)
						{
							throw new SharpZipBaseException();
						}
					}
					else
					{
						tVqzilQjclVarkoJzJbToXrzFkUy = 0;
					}
					cLeBsdGnRXNANKPZhEuCduAhdhNWB = symbol - 16;
					IUaiPypAyJprEbBfufyZPnRGIEHt = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (dOvLMdEnpwinlAusVqzbBezROZEo < ETSbSmkoADMxwQtUXRQPoEUQWHXOA)
				{
					int num2 = input.PeekBits(3);
					if (num2 >= 0)
					{
						input.DropBits(3);
						cctAKfGtJqqcTDTzannyDvQzIRAgB[jnvxNnCMbYEmEcVmlsKuDpvBErPo[dOvLMdEnpwinlAusVqzbBezROZEo]] = (byte)num2;
						dOvLMdEnpwinlAusVqzbBezROZEo++;
						continue;
					}
					return false;
				}
				MrqUZgFxQWnCEyNsorEOovGzQLHb = new InflaterHuffmanTree(cctAKfGtJqqcTDTzannyDvQzIRAgB);
				cctAKfGtJqqcTDTzannyDvQzIRAgB = null;
				dOvLMdEnpwinlAusVqzbBezROZEo = 0;
				IUaiPypAyJprEbBfufyZPnRGIEHt = 4;
				goto case 4;
			case 2:
				ETSbSmkoADMxwQtUXRQPoEUQWHXOA = input.PeekBits(4);
				if (ETSbSmkoADMxwQtUXRQPoEUQWHXOA >= 0)
				{
					ETSbSmkoADMxwQtUXRQPoEUQWHXOA += 4;
					input.DropBits(4);
					cctAKfGtJqqcTDTzannyDvQzIRAgB = new byte[19];
					dOvLMdEnpwinlAusVqzbBezROZEo = 0;
					IUaiPypAyJprEbBfufyZPnRGIEHt = 3;
					goto case 3;
				}
				return false;
			case 1:
				pqagpyLvmyGZmKLbyRLdIxwdzsWc = input.PeekBits(5);
				if (pqagpyLvmyGZmKLbyRLdIxwdzsWc >= 0)
				{
					pqagpyLvmyGZmKLbyRLdIxwdzsWc++;
					input.DropBits(5);
					HwALclJnmKEhvJkyEQoZKjdhqbRWA = vEZRhLlQxQreZUDTFOpzuYUtqNDt + pqagpyLvmyGZmKLbyRLdIxwdzsWc;
					tdeXYZLUHYZJnnamDDfBpXcZunUe = new byte[HwALclJnmKEhvJkyEQoZKjdhqbRWA];
					IUaiPypAyJprEbBfufyZPnRGIEHt = 2;
					goto case 2;
				}
				return false;
			case 0:
				vEZRhLlQxQreZUDTFOpzuYUtqNDt = input.PeekBits(5);
				if (vEZRhLlQxQreZUDTFOpzuYUtqNDt >= 0)
				{
					vEZRhLlQxQreZUDTFOpzuYUtqNDt += 257;
					input.DropBits(5);
					IUaiPypAyJprEbBfufyZPnRGIEHt = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_00a8:
			IUaiPypAyJprEbBfufyZPnRGIEHt = 4;
		}
	}
}
