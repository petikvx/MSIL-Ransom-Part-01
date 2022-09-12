using System;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class DeflaterEngine : DeflaterConstants
{
	private Adler32 IfPFmiMsiqpHWKiRMCSJeyrSLfyi;

	private int KRFegqJPdfrXYNvJYKggDgmAgNTK;

	private int SkegcKsBbMXneHbsONHrTWCGWevD;

	private int LTBrGonkgrpUNDzIvRbjzdTZpmpX;

	private short[] YYGCEWxlEhCkzcpnpCGKBGIezePZb;

	private DeflaterHuffman TvqIDxhpSZCpCaXAELVfdgFTxRlmA;

	private byte[] UGMAxZZrUlpHOvlnBCaeNgrrfJGl;

	private int uPgzrhqLVEZAjtcOqUQWRwnRTUfG;

	private int zcKheFsDcNpCPyRskhybCEBTtvjr;

	private int LQIAPVgSFmVbsSnXqpVmidKXGEMgA;

	private int bxQDrsdWimarptTEvbTDbRMolSOFb;

	private int LTYLrNanXOInYmXGwUSKIwOarfy;

	private int KCeiFjfeMPMqICchGiTtwPeDAmrqb;

	private int qQfJqQwJlpzXweCIoFWPEkpCNfzeb;

	private int zeBgcYvteNYbLlpiBUslmfWjdTpX;

	private int HduiQzgZhKacnMHFCJOubnhSPAqU;

	private DeflaterPending CuYexhYXycYPsNcAnazYdxbwUVJI;

	private short[] MInbfdHBBBZLOhMWzcqUxJfyUYIy;

	private bool UeaVqwYEvTeSVHsLHCCqGgBmscUeA;

	private DeflateStrategy CBWpdBVDlRgDFfSEQwwHofyqxlRN;

	private int mGyPuLpLUkHklNXQKOBXfBNqHxbdA;

	private const int GwZjodVKCSbpxARqytThBYAeZFHVA = 4096;

	private long lNsWZTpCMfiJLolqbFFEpXLtxjZV;

	private byte[] hFKtVmJVfLiWcGHRwKbIKFcZaWyt;

	public int Adler => (int)IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Value;

	public DeflateStrategy Strategy
	{
		get
		{
			return CBWpdBVDlRgDFfSEQwwHofyqxlRN;
		}
		set
		{
			CBWpdBVDlRgDFfSEQwwHofyqxlRN = value;
		}
	}

	public long TotalIn => lNsWZTpCMfiJLolqbFFEpXLtxjZV;

	public DeflaterEngine(DeflaterPending pending)
	{
		CuYexhYXycYPsNcAnazYdxbwUVJI = pending;
		TvqIDxhpSZCpCaXAELVfdgFTxRlmA = new DeflaterHuffman(pending);
		IfPFmiMsiqpHWKiRMCSJeyrSLfyi = new Adler32();
		hFKtVmJVfLiWcGHRwKbIKFcZaWyt = new byte[65536];
		YYGCEWxlEhCkzcpnpCGKBGIezePZb = new short[32768];
		MInbfdHBBBZLOhMWzcqUxJfyUYIy = new short[32768];
		mGyPuLpLUkHklNXQKOBXfBNqHxbdA = 1;
		KRFegqJPdfrXYNvJYKggDgmAgNTK = 1;
	}

	public bool Deflate(bool flush, bool finish)
	{
		bool flag;
		do
		{
			FillWindow();
			if (flush)
			{
			}
			bool flush2 = false;
			flag = SkegcKsBbMXneHbsONHrTWCGWevD switch
			{
				0 => tfBxylsSOxkuinvUTQHCokFFVeuX(flush2, finish), 
				1 => HvVILZeDqEasRcywBMsAygueHhoP(flush2, finish), 
				2 => aVkxlamuFZdpVdcSablJtyRtSRMu(flush2, finish), 
				_ => throw new InvalidOperationException("unknown compressionFunction"), 
			};
		}
		while (CuYexhYXycYPsNcAnazYdxbwUVJI.IsFlushed && flag);
		return flag;
	}

	private bool HvVILZeDqEasRcywBMsAygueHhoP(bool flush, bool finish)
	{
		if (!(bxQDrsdWimarptTEvbTDbRMolSOFb >= 262 || flush))
		{
			return false;
		}
		while (bxQDrsdWimarptTEvbTDbRMolSOFb >= 262 || flush)
		{
			if (bxQDrsdWimarptTEvbTDbRMolSOFb != 0)
			{
				if (mGyPuLpLUkHklNXQKOBXfBNqHxbdA > 65274)
				{
					BTdNLxdqNwIQWeigHNvCGNWckIjIA();
				}
				int num;
				if (bxQDrsdWimarptTEvbTDbRMolSOFb >= 3 && (num = ZwNcBqExzHOSHzblIujqxGuxtJnd()) != 0 && CBWpdBVDlRgDFfSEQwwHofyqxlRN != DeflateStrategy.HuffmanOnly && mGyPuLpLUkHklNXQKOBXfBNqHxbdA - num <= 32506 && bBodBaeRpHMHfmcvSgRJEhXeimzjA(num))
				{
					bool flag = TvqIDxhpSZCpCaXAELVfdgFTxRlmA.TallyDist(mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KCeiFjfeMPMqICchGiTtwPeDAmrqb, LTYLrNanXOInYmXGwUSKIwOarfy);
					bxQDrsdWimarptTEvbTDbRMolSOFb -= LTYLrNanXOInYmXGwUSKIwOarfy;
					if (LTYLrNanXOInYmXGwUSKIwOarfy <= zeBgcYvteNYbLlpiBUslmfWjdTpX && bxQDrsdWimarptTEvbTDbRMolSOFb >= 3)
					{
						while (--LTYLrNanXOInYmXGwUSKIwOarfy > 0)
						{
							mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
							ZwNcBqExzHOSHzblIujqxGuxtJnd();
						}
						mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
					}
					else
					{
						mGyPuLpLUkHklNXQKOBXfBNqHxbdA += LTYLrNanXOInYmXGwUSKIwOarfy;
						if (bxQDrsdWimarptTEvbTDbRMolSOFb >= 2)
						{
							vSLRRJTpMMeCvCDwazeZfpqpJkNUA();
						}
					}
					LTYLrNanXOInYmXGwUSKIwOarfy = 2;
					if (!flag)
					{
						continue;
					}
				}
				else
				{
					TvqIDxhpSZCpCaXAELVfdgFTxRlmA.TallyLit(hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA] & 0xFF);
					mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
					bxQDrsdWimarptTEvbTDbRMolSOFb--;
				}
				if (TvqIDxhpSZCpCaXAELVfdgFTxRlmA.IsFull())
				{
					bool flag2 = finish && bxQDrsdWimarptTEvbTDbRMolSOFb == 0;
					TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK, flag2);
					KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
					return !flag2;
				}
				continue;
			}
			TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK, finish);
			KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
			return false;
		}
		return true;
	}

	private bool aVkxlamuFZdpVdcSablJtyRtSRMu(bool flush, bool finish)
	{
		if (!(bxQDrsdWimarptTEvbTDbRMolSOFb >= 262 || flush))
		{
			return false;
		}
		while (bxQDrsdWimarptTEvbTDbRMolSOFb >= 262 || flush)
		{
			if (bxQDrsdWimarptTEvbTDbRMolSOFb != 0)
			{
				if (mGyPuLpLUkHklNXQKOBXfBNqHxbdA >= 65274)
				{
					BTdNLxdqNwIQWeigHNvCGNWckIjIA();
				}
				int kCeiFjfeMPMqICchGiTtwPeDAmrqb = KCeiFjfeMPMqICchGiTtwPeDAmrqb;
				int lTYLrNanXOInYmXGwUSKIwOarfy = LTYLrNanXOInYmXGwUSKIwOarfy;
				if (bxQDrsdWimarptTEvbTDbRMolSOFb >= 3)
				{
					int num = ZwNcBqExzHOSHzblIujqxGuxtJnd();
					if (CBWpdBVDlRgDFfSEQwwHofyqxlRN != DeflateStrategy.HuffmanOnly && num != 0 && mGyPuLpLUkHklNXQKOBXfBNqHxbdA - num <= 32506 && bBodBaeRpHMHfmcvSgRJEhXeimzjA(num) && LTYLrNanXOInYmXGwUSKIwOarfy <= 5 && (CBWpdBVDlRgDFfSEQwwHofyqxlRN == DeflateStrategy.Filtered || (LTYLrNanXOInYmXGwUSKIwOarfy == 3 && mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KCeiFjfeMPMqICchGiTtwPeDAmrqb > 4096)))
					{
						LTYLrNanXOInYmXGwUSKIwOarfy = 2;
					}
				}
				if (lTYLrNanXOInYmXGwUSKIwOarfy < 3 || LTYLrNanXOInYmXGwUSKIwOarfy > lTYLrNanXOInYmXGwUSKIwOarfy)
				{
					if (UeaVqwYEvTeSVHsLHCCqGgBmscUeA)
					{
						TvqIDxhpSZCpCaXAELVfdgFTxRlmA.TallyLit(hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA - 1] & 0xFF);
					}
					UeaVqwYEvTeSVHsLHCCqGgBmscUeA = true;
					mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
					bxQDrsdWimarptTEvbTDbRMolSOFb--;
				}
				else
				{
					TvqIDxhpSZCpCaXAELVfdgFTxRlmA.TallyDist(mGyPuLpLUkHklNXQKOBXfBNqHxbdA - 1 - kCeiFjfeMPMqICchGiTtwPeDAmrqb, lTYLrNanXOInYmXGwUSKIwOarfy);
					lTYLrNanXOInYmXGwUSKIwOarfy -= 2;
					do
					{
						mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
						bxQDrsdWimarptTEvbTDbRMolSOFb--;
						if (bxQDrsdWimarptTEvbTDbRMolSOFb >= 3)
						{
							ZwNcBqExzHOSHzblIujqxGuxtJnd();
						}
					}
					while (--lTYLrNanXOInYmXGwUSKIwOarfy > 0);
					mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
					bxQDrsdWimarptTEvbTDbRMolSOFb--;
					UeaVqwYEvTeSVHsLHCCqGgBmscUeA = false;
					LTYLrNanXOInYmXGwUSKIwOarfy = 2;
				}
				if (TvqIDxhpSZCpCaXAELVfdgFTxRlmA.IsFull())
				{
					int num2 = mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK;
					if (UeaVqwYEvTeSVHsLHCCqGgBmscUeA)
					{
						num2--;
					}
					bool flag = finish && bxQDrsdWimarptTEvbTDbRMolSOFb == 0 && !UeaVqwYEvTeSVHsLHCCqGgBmscUeA;
					TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, num2, flag);
					KRFegqJPdfrXYNvJYKggDgmAgNTK += num2;
					return !flag;
				}
				continue;
			}
			if (UeaVqwYEvTeSVHsLHCCqGgBmscUeA)
			{
				TvqIDxhpSZCpCaXAELVfdgFTxRlmA.TallyLit(hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA - 1] & 0xFF);
			}
			UeaVqwYEvTeSVHsLHCCqGgBmscUeA = false;
			TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK, finish);
			KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
			return false;
		}
		return true;
	}

	private bool tfBxylsSOxkuinvUTQHCokFFVeuX(bool flush, bool finish)
	{
		if (!flush && bxQDrsdWimarptTEvbTDbRMolSOFb == 0)
		{
			return false;
		}
		mGyPuLpLUkHklNXQKOBXfBNqHxbdA += bxQDrsdWimarptTEvbTDbRMolSOFb;
		bxQDrsdWimarptTEvbTDbRMolSOFb = 0;
		int num = mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK;
		if (num >= DeflaterConstants.MAX_BLOCK_SIZE || (KRFegqJPdfrXYNvJYKggDgmAgNTK < 32768 && num >= 32506) || flush)
		{
			bool flag = finish;
			if (num > DeflaterConstants.MAX_BLOCK_SIZE)
			{
				num = DeflaterConstants.MAX_BLOCK_SIZE;
				flag = false;
			}
			TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushStoredBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, num, flag);
			KRFegqJPdfrXYNvJYKggDgmAgNTK += num;
			return !flag;
		}
		return true;
	}

	public void FillWindow()
	{
		if (mGyPuLpLUkHklNXQKOBXfBNqHxbdA >= 65274)
		{
			BTdNLxdqNwIQWeigHNvCGNWckIjIA();
		}
		while (bxQDrsdWimarptTEvbTDbRMolSOFb < 262 && zcKheFsDcNpCPyRskhybCEBTtvjr < uPgzrhqLVEZAjtcOqUQWRwnRTUfG)
		{
			int num = 65536 - bxQDrsdWimarptTEvbTDbRMolSOFb - mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
			if (num > uPgzrhqLVEZAjtcOqUQWRwnRTUfG - zcKheFsDcNpCPyRskhybCEBTtvjr)
			{
				num = uPgzrhqLVEZAjtcOqUQWRwnRTUfG - zcKheFsDcNpCPyRskhybCEBTtvjr;
			}
			Array.Copy(UGMAxZZrUlpHOvlnBCaeNgrrfJGl, zcKheFsDcNpCPyRskhybCEBTtvjr, hFKtVmJVfLiWcGHRwKbIKFcZaWyt, mGyPuLpLUkHklNXQKOBXfBNqHxbdA + bxQDrsdWimarptTEvbTDbRMolSOFb, num);
			IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Update(UGMAxZZrUlpHOvlnBCaeNgrrfJGl, zcKheFsDcNpCPyRskhybCEBTtvjr, num);
			zcKheFsDcNpCPyRskhybCEBTtvjr += num;
			lNsWZTpCMfiJLolqbFFEpXLtxjZV += num;
			bxQDrsdWimarptTEvbTDbRMolSOFb += num;
		}
		if (bxQDrsdWimarptTEvbTDbRMolSOFb >= 3)
		{
			vSLRRJTpMMeCvCDwazeZfpqpJkNUA();
		}
	}

	private bool bBodBaeRpHMHfmcvSgRJEhXeimzjA(int curMatch)
	{
		int num = qQfJqQwJlpzXweCIoFWPEkpCNfzeb;
		int hduiQzgZhKacnMHFCJOubnhSPAqU = HduiQzgZhKacnMHFCJOubnhSPAqU;
		short[] mInbfdHBBBZLOhMWzcqUxJfyUYIy = MInbfdHBBBZLOhMWzcqUxJfyUYIy;
		int num2 = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
		int num3 = mGyPuLpLUkHklNXQKOBXfBNqHxbdA + LTYLrNanXOInYmXGwUSKIwOarfy;
		int num4 = Math.Max(LTYLrNanXOInYmXGwUSKIwOarfy, 2);
		int num5 = Math.Max(mGyPuLpLUkHklNXQKOBXfBNqHxbdA - 32506, 0);
		int num6 = mGyPuLpLUkHklNXQKOBXfBNqHxbdA + 258 - 1;
		byte b = hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num3 - 1];
		byte b2 = hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num3];
		if (num4 >= LTBrGonkgrpUNDzIvRbjzdTZpmpX)
		{
			num >>= 2;
		}
		if (hduiQzgZhKacnMHFCJOubnhSPAqU > bxQDrsdWimarptTEvbTDbRMolSOFb)
		{
			hduiQzgZhKacnMHFCJOubnhSPAqU = bxQDrsdWimarptTEvbTDbRMolSOFb;
		}
		do
		{
			if (hFKtVmJVfLiWcGHRwKbIKFcZaWyt[curMatch + num4] != b2 || hFKtVmJVfLiWcGHRwKbIKFcZaWyt[curMatch + num4 - 1] != b || hFKtVmJVfLiWcGHRwKbIKFcZaWyt[curMatch] != hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num2] || hFKtVmJVfLiWcGHRwKbIKFcZaWyt[curMatch + 1] != hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num2 + 1])
			{
				continue;
			}
			int num7 = curMatch + 2;
			num2 += 2;
			while (hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num2] == hFKtVmJVfLiWcGHRwKbIKFcZaWyt[++num7] && num2 < num6)
			{
			}
			if (num2 > num3)
			{
				KCeiFjfeMPMqICchGiTtwPeDAmrqb = curMatch;
				num3 = num2;
				num4 = num2 - mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
				if (num4 >= hduiQzgZhKacnMHFCJOubnhSPAqU)
				{
					break;
				}
				b = hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num3 - 1];
				b2 = hFKtVmJVfLiWcGHRwKbIKFcZaWyt[num3];
			}
			num2 = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
		}
		while ((curMatch = mInbfdHBBBZLOhMWzcqUxJfyUYIy[curMatch & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		LTYLrNanXOInYmXGwUSKIwOarfy = Math.Min(num4, bxQDrsdWimarptTEvbTDbRMolSOFb);
		return LTYLrNanXOInYmXGwUSKIwOarfy >= 3;
	}

	private int ZwNcBqExzHOSHzblIujqxGuxtJnd()
	{
		int num = ((LQIAPVgSFmVbsSnXqpVmidKXGEMgA << 5) ^ hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA + 2]) & 0x7FFF;
		short num2 = (MInbfdHBBBZLOhMWzcqUxJfyUYIy[mGyPuLpLUkHklNXQKOBXfBNqHxbdA & 0x7FFF] = YYGCEWxlEhCkzcpnpCGKBGIezePZb[num]);
		YYGCEWxlEhCkzcpnpCGKBGIezePZb[num] = (short)mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
		LQIAPVgSFmVbsSnXqpVmidKXGEMgA = num;
		return num2 & 0xFFFF;
	}

	public bool NeedsInput()
	{
		return uPgzrhqLVEZAjtcOqUQWRwnRTUfG == zcKheFsDcNpCPyRskhybCEBTtvjr;
	}

	public void Reset()
	{
		TvqIDxhpSZCpCaXAELVfdgFTxRlmA.Reset();
		IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Reset();
		mGyPuLpLUkHklNXQKOBXfBNqHxbdA = 1;
		KRFegqJPdfrXYNvJYKggDgmAgNTK = 1;
		bxQDrsdWimarptTEvbTDbRMolSOFb = 0;
		lNsWZTpCMfiJLolqbFFEpXLtxjZV = 0L;
		UeaVqwYEvTeSVHsLHCCqGgBmscUeA = false;
		LTYLrNanXOInYmXGwUSKIwOarfy = 2;
		for (int i = 0; i < 32768; i++)
		{
			YYGCEWxlEhCkzcpnpCGKBGIezePZb[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			MInbfdHBBBZLOhMWzcqUxJfyUYIy[j] = 0;
		}
	}

	public void ResetAdler()
	{
		IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Reset();
	}

	public void SetDictionary(byte[] buffer, int offset, int length)
	{
		IfPFmiMsiqpHWKiRMCSJeyrSLfyi.Update(buffer, offset, length);
		if (length >= 3)
		{
			if (length > 32506)
			{
				offset += length - 32506;
				length = 32506;
			}
			Array.Copy(buffer, offset, hFKtVmJVfLiWcGHRwKbIKFcZaWyt, mGyPuLpLUkHklNXQKOBXfBNqHxbdA, length);
			vSLRRJTpMMeCvCDwazeZfpqpJkNUA();
			length--;
			while (--length > 0)
			{
				ZwNcBqExzHOSHzblIujqxGuxtJnd();
				mGyPuLpLUkHklNXQKOBXfBNqHxbdA++;
			}
			mGyPuLpLUkHklNXQKOBXfBNqHxbdA += 2;
			KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
		}
	}

	public void SetInput(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count >= 0)
		{
			if (zcKheFsDcNpCPyRskhybCEBTtvjr >= uPgzrhqLVEZAjtcOqUQWRwnRTUfG)
			{
				int num = offset + count;
				if (offset > num || num > buffer.Length)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				UGMAxZZrUlpHOvlnBCaeNgrrfJGl = buffer;
				zcKheFsDcNpCPyRskhybCEBTtvjr = offset;
				uPgzrhqLVEZAjtcOqUQWRwnRTUfG = num;
				return;
			}
			throw new InvalidOperationException("Old input was not completely processed");
		}
		throw new ArgumentOutOfRangeException("count");
	}

	public void SetLevel(int level)
	{
		if (level < 0 || level > 9)
		{
			throw new ArgumentOutOfRangeException("level");
		}
		LTBrGonkgrpUNDzIvRbjzdTZpmpX = DeflaterConstants.GOOD_LENGTH[level];
		zeBgcYvteNYbLlpiBUslmfWjdTpX = DeflaterConstants.MAX_LAZY[level];
		HduiQzgZhKacnMHFCJOubnhSPAqU = DeflaterConstants.NICE_LENGTH[level];
		qQfJqQwJlpzXweCIoFWPEkpCNfzeb = DeflaterConstants.MAX_CHAIN[level];
		if (DeflaterConstants.COMPR_FUNC[level] == SkegcKsBbMXneHbsONHrTWCGWevD)
		{
			return;
		}
		switch (SkegcKsBbMXneHbsONHrTWCGWevD)
		{
		case 0:
			if (mGyPuLpLUkHklNXQKOBXfBNqHxbdA > KRFegqJPdfrXYNvJYKggDgmAgNTK)
			{
				TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushStoredBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK, lastBlock: false);
				KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
			}
			vSLRRJTpMMeCvCDwazeZfpqpJkNUA();
			break;
		case 1:
			if (mGyPuLpLUkHklNXQKOBXfBNqHxbdA > KRFegqJPdfrXYNvJYKggDgmAgNTK)
			{
				TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK, lastBlock: false);
				KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
			}
			break;
		case 2:
			if (UeaVqwYEvTeSVHsLHCCqGgBmscUeA)
			{
				TvqIDxhpSZCpCaXAELVfdgFTxRlmA.TallyLit(hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA - 1] & 0xFF);
			}
			if (mGyPuLpLUkHklNXQKOBXfBNqHxbdA > KRFegqJPdfrXYNvJYKggDgmAgNTK)
			{
				TvqIDxhpSZCpCaXAELVfdgFTxRlmA.FlushBlock(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, KRFegqJPdfrXYNvJYKggDgmAgNTK, mGyPuLpLUkHklNXQKOBXfBNqHxbdA - KRFegqJPdfrXYNvJYKggDgmAgNTK, lastBlock: false);
				KRFegqJPdfrXYNvJYKggDgmAgNTK = mGyPuLpLUkHklNXQKOBXfBNqHxbdA;
			}
			UeaVqwYEvTeSVHsLHCCqGgBmscUeA = false;
			LTYLrNanXOInYmXGwUSKIwOarfy = 2;
			break;
		}
		SkegcKsBbMXneHbsONHrTWCGWevD = DeflaterConstants.COMPR_FUNC[level];
	}

	private void BTdNLxdqNwIQWeigHNvCGNWckIjIA()
	{
		Array.Copy(hFKtVmJVfLiWcGHRwKbIKFcZaWyt, 32768, hFKtVmJVfLiWcGHRwKbIKFcZaWyt, 0, 32768);
		KCeiFjfeMPMqICchGiTtwPeDAmrqb -= 32768;
		mGyPuLpLUkHklNXQKOBXfBNqHxbdA -= 32768;
		KRFegqJPdfrXYNvJYKggDgmAgNTK -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = YYGCEWxlEhCkzcpnpCGKBGIezePZb[i] & 0xFFFF;
			YYGCEWxlEhCkzcpnpCGKBGIezePZb[i] = (short)((num >= 32768) ? ((short)(num - 32768)) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = MInbfdHBBBZLOhMWzcqUxJfyUYIy[j] & 0xFFFF;
			MInbfdHBBBZLOhMWzcqUxJfyUYIy[j] = (short)((num2 >= 32768) ? ((short)(num2 - 32768)) : 0);
		}
	}

	private void vSLRRJTpMMeCvCDwazeZfpqpJkNUA()
	{
		LQIAPVgSFmVbsSnXqpVmidKXGEMgA = (hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA] << 5) ^ hFKtVmJVfLiWcGHRwKbIKFcZaWyt[mGyPuLpLUkHklNXQKOBXfBNqHxbdA + 1];
	}
}
