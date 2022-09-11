using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Codecs;

public sealed class G722Codec
{
	private static readonly int[] wl;

	private static readonly int[] rl42;

	private static readonly int[] ilb;

	private static readonly int[] wh;

	private static readonly int[] rh2;

	private static readonly int[] qm2;

	private static readonly int[] qm4;

	private static readonly int[] qm5;

	private static readonly int[] qm6;

	private static readonly int[] qmf_coeffs;

	private static readonly int[] q6;

	private static readonly int[] iln;

	private static readonly int[] ilp;

	private static readonly int[] ihn;

	private static readonly int[] ihp;

	[NonSerialized]
	internal static GetString _0018;

	private static short Saturate(int amp)
	{
		short num = (short)amp;
		if (amp == num)
		{
			return num;
		}
		if (amp > 32767)
		{
			return short.MaxValue;
		}
		return short.MinValue;
	}

	private static void Block4(G722CodecState s, int band, int d)
	{
		s.Band[band].d[0] = d;
		s.Band[band].r[0] = Saturate(s.Band[band].s + d);
		s.Band[band].p[0] = Saturate(s.Band[band].sz + d);
		for (int i = 0; i < 3; i++)
		{
			s.Band[band].sg[i] = s.Band[band].p[i] >> 15;
		}
		int num = Saturate(s.Band[band].a[1] << 2);
		int num2 = ((s.Band[band].sg[0] == s.Band[band].sg[1]) ? (-num) : num);
		if (num2 > 32767)
		{
			num2 = 32767;
		}
		int num3 = ((s.Band[band].sg[0] == s.Band[band].sg[2]) ? 128 : (-128));
		num3 += num2 >> 7;
		num3 += s.Band[band].a[2] * 32512 >> 15;
		if (num3 > 12288)
		{
			num3 = 12288;
		}
		else if (num3 < -12288)
		{
			num3 = -12288;
		}
		s.Band[band].ap[2] = num3;
		s.Band[band].sg[0] = s.Band[band].p[0] >> 15;
		s.Band[band].sg[1] = s.Band[band].p[1] >> 15;
		num = ((s.Band[band].sg[0] == s.Band[band].sg[1]) ? 192 : (-192));
		num2 = s.Band[band].a[1] * 32640 >> 15;
		s.Band[band].ap[1] = Saturate(num + num2);
		num3 = Saturate(15360 - s.Band[band].ap[2]);
		if (s.Band[band].ap[1] > num3)
		{
			s.Band[band].ap[1] = num3;
		}
		else if (s.Band[band].ap[1] < -num3)
		{
			s.Band[band].ap[1] = -num3;
		}
		num = ((d != 0) ? 128 : 0);
		s.Band[band].sg[0] = d >> 15;
		for (int i = 1; i < 7; i++)
		{
			s.Band[band].sg[i] = s.Band[band].d[i] >> 15;
			num2 = ((s.Band[band].sg[i] == s.Band[band].sg[0]) ? num : (-num));
			num3 = s.Band[band].b[i] * 32640 >> 15;
			s.Band[band].bp[i] = Saturate(num2 + num3);
		}
		for (int i = 6; i > 0; i--)
		{
			s.Band[band].d[i] = s.Band[band].d[i - 1];
			s.Band[band].b[i] = s.Band[band].bp[i];
		}
		for (int i = 2; i > 0; i--)
		{
			s.Band[band].r[i] = s.Band[band].r[i - 1];
			s.Band[band].p[i] = s.Band[band].p[i - 1];
			s.Band[band].a[i] = s.Band[band].ap[i];
		}
		num = Saturate(s.Band[band].r[1] + s.Band[band].r[1]);
		num = s.Band[band].a[1] * num >> 15;
		num2 = Saturate(s.Band[band].r[2] + s.Band[band].r[2]);
		num2 = s.Band[band].a[2] * num2 >> 15;
		s.Band[band].sp = Saturate(num + num2);
		s.Band[band].sz = 0;
		for (int i = 6; i > 0; i--)
		{
			num = Saturate(s.Band[band].d[i] + s.Band[band].d[i]);
			s.Band[band].sz += s.Band[band].b[i] * num >> 15;
		}
		s.Band[band].sz = Saturate(s.Band[band].sz);
		s.Band[band].s = Saturate(s.Band[band].sp + s.Band[band].sz);
	}

	public int Decode(G722CodecState state, short[] outputBuffer, byte[] inputG722Data, int inputLength)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		while (num2 < inputLength)
		{
			int num3;
			if (state.Packed)
			{
				if (state.InBits < state.BitsPerSample)
				{
					state.InBuffer |= (uint)(inputG722Data[num2++] << state.InBits);
					state.InBits += 8;
				}
				num3 = (int)state.InBuffer & ((1 << state.BitsPerSample) - 1);
				state.InBuffer >>= state.BitsPerSample;
				state.InBits -= state.BitsPerSample;
			}
			else
			{
				num3 = inputG722Data[num2++];
			}
			int num5;
			int num4;
			int num6;
			switch (state.BitsPerSample)
			{
			default:
				num4 = num3 & 0x3F;
				num5 = (num3 >> 6) & 3;
				num6 = qm6[num4];
				num4 >>= 2;
				break;
			case 7:
				num4 = num3 & 0x1F;
				num5 = (num3 >> 5) & 3;
				num6 = qm5[num4];
				num4 >>= 1;
				break;
			case 6:
				num4 = num3 & 0xF;
				num5 = (num3 >> 4) & 3;
				num6 = qm4[num4];
				break;
			}
			num6 = state.Band[0].det * num6 >> 15;
			int num7 = state.Band[0].s + num6;
			if (num7 > 16383)
			{
				num7 = 16383;
			}
			else if (num7 < -16384)
			{
				num7 = -16384;
			}
			num6 = qm4[num4];
			int d = state.Band[0].det * num6 >> 15;
			num6 = rl42[num4];
			num4 = state.Band[0].nb * 127 >> 7;
			num4 += wl[num6];
			if (num4 < 0)
			{
				num4 = 0;
			}
			else if (num4 > 18432)
			{
				num4 = 18432;
			}
			state.Band[0].nb = num4;
			num4 = (state.Band[0].nb >> 6) & 0x1F;
			num6 = 8 - (state.Band[0].nb >> 11);
			int num8 = ((num6 < 0) ? (ilb[num4] << -num6) : (ilb[num4] >> num6));
			state.Band[0].det = num8 << 2;
			Block4(state, 0, d);
			if (!state.EncodeFrom8000Hz)
			{
				num6 = qm2[num5];
				int num9 = state.Band[1].det * num6 >> 15;
				num = num9 + state.Band[1].s;
				if (num > 16383)
				{
					num = 16383;
				}
				else if (num < -16384)
				{
					num = -16384;
				}
				num6 = rh2[num5];
				num4 = state.Band[1].nb * 127 >> 7;
				num4 += wh[num6];
				if (num4 < 0)
				{
					num4 = 0;
				}
				else if (num4 > 22528)
				{
					num4 = 22528;
				}
				state.Band[1].nb = num4;
				num4 = (state.Band[1].nb >> 6) & 0x1F;
				num6 = 10 - (state.Band[1].nb >> 11);
				num8 = ((num6 < 0) ? (ilb[num4] << -num6) : (ilb[num4] >> num6));
				state.Band[1].det = num8 << 2;
				Block4(state, 1, num9);
			}
			if (state.ItuTestMode)
			{
				outputBuffer[result++] = (short)(num7 << 1);
				outputBuffer[result++] = (short)(num << 1);
				continue;
			}
			if (state.EncodeFrom8000Hz)
			{
				outputBuffer[result++] = (short)(num7 << 1);
				continue;
			}
			for (int i = 0; i < 22; i++)
			{
				state.QmfSignalHistory[i] = state.QmfSignalHistory[i + 2];
			}
			state.QmfSignalHistory[22] = num7 + num;
			state.QmfSignalHistory[23] = num7 - num;
			int num10 = 0;
			int num11 = 0;
			for (int i = 0; i < 12; i++)
			{
				num11 += state.QmfSignalHistory[2 * i] * qmf_coeffs[i];
				num10 += state.QmfSignalHistory[2 * i + 1] * qmf_coeffs[11 - i];
			}
			outputBuffer[result++] = (short)(num10 >> 11);
			outputBuffer[result++] = (short)(num11 >> 11);
		}
		return result;
	}

	public int Encode(G722CodecState state, byte[] outputBuffer, short[] inputBuffer, int inputBufferCount)
	{
		int result = 0;
		int num = 0;
		int num2 = 0;
		while (num2 < inputBufferCount)
		{
			int num3;
			int i;
			if (state.ItuTestMode)
			{
				num3 = (num = inputBuffer[num2++] >> 1);
			}
			else if (state.EncodeFrom8000Hz)
			{
				num3 = inputBuffer[num2++] >> 1;
			}
			else
			{
				for (i = 0; i < 22; i++)
				{
					state.QmfSignalHistory[i] = state.QmfSignalHistory[i + 2];
				}
				state.QmfSignalHistory[22] = inputBuffer[num2++];
				state.QmfSignalHistory[23] = inputBuffer[num2++];
				int num4 = 0;
				int num5 = 0;
				for (i = 0; i < 12; i++)
				{
					num5 += state.QmfSignalHistory[2 * i] * qmf_coeffs[i];
					num4 += state.QmfSignalHistory[2 * i + 1] * qmf_coeffs[11 - i];
				}
				num3 = num4 + num5 >> 14;
				num = num4 - num5 >> 14;
			}
			int num6 = Saturate(num3 - state.Band[0].s);
			int num7 = ((num6 >= 0) ? num6 : (-(num6 + 1)));
			int num8;
			for (i = 1; i < 30; i++)
			{
				num8 = q6[i] * state.Band[0].det >> 12;
				if (num7 < num8)
				{
					break;
				}
			}
			int num9 = ((num6 < 0) ? iln[i] : ilp[i]);
			int num10 = num9 >> 2;
			int num11 = qm4[num10];
			int d = state.Band[0].det * num11 >> 15;
			int num12 = rl42[num10];
			num7 = state.Band[0].nb * 127 >> 7;
			state.Band[0].nb = num7 + wl[num12];
			if (state.Band[0].nb < 0)
			{
				state.Band[0].nb = 0;
			}
			else if (state.Band[0].nb > 18432)
			{
				state.Band[0].nb = 18432;
			}
			num8 = (state.Band[0].nb >> 6) & 0x1F;
			num11 = 8 - (state.Band[0].nb >> 11);
			int num13 = ((num11 < 0) ? (ilb[num8] << -num11) : (ilb[num8] >> num11));
			state.Band[0].det = num13 << 2;
			Block4(state, 0, d);
			int num14;
			if (state.EncodeFrom8000Hz)
			{
				num14 = (0xC0 | num9) >> 8 - state.BitsPerSample;
			}
			else
			{
				int num15 = Saturate(num - state.Band[1].s);
				num7 = ((num15 >= 0) ? num15 : (-(num15 + 1)));
				num8 = 564 * state.Band[1].det >> 12;
				int num16 = ((num7 < num8) ? 1 : 2);
				int num17 = ((num15 < 0) ? ihn[num16] : ihp[num16]);
				num11 = qm2[num17];
				int d2 = state.Band[1].det * num11 >> 15;
				int num18 = rh2[num17];
				num7 = state.Band[1].nb * 127 >> 7;
				state.Band[1].nb = num7 + wh[num18];
				if (state.Band[1].nb < 0)
				{
					state.Band[1].nb = 0;
				}
				else if (state.Band[1].nb > 22528)
				{
					state.Band[1].nb = 22528;
				}
				num8 = (state.Band[1].nb >> 6) & 0x1F;
				num11 = 10 - (state.Band[1].nb >> 11);
				num13 = ((num11 < 0) ? (ilb[num8] << -num11) : (ilb[num8] >> num11));
				state.Band[1].det = num13 << 2;
				Block4(state, 1, d2);
				num14 = ((num17 << 6) | num9) >> 8 - state.BitsPerSample;
			}
			if (state.Packed)
			{
				state.OutBuffer |= (uint)(num14 << state.OutBits);
				state.OutBits += state.BitsPerSample;
				if (state.OutBits >= 8)
				{
					outputBuffer[result++] = (byte)(state.OutBuffer & 0xFFu);
					state.OutBits -= 8;
					state.OutBuffer >>= 8;
				}
			}
			else
			{
				outputBuffer[result++] = (byte)num14;
			}
		}
		return result;
	}

	static G722Codec()
	{
		Strings.CreateGetStringDelegate(typeof(G722Codec));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0018(107400316), _0018(107400279)).Replace(_0018(107400274), _0018(107400269)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0018(107400296)))
		{
			throw new SecurityException(_0018(107400239));
		}
		wl = new int[8] { -60, -30, 58, 172, 334, 538, 1198, 3042 };
		rl42 = new int[16]
		{
			0, 7, 6, 5, 4, 3, 2, 1, 7, 6,
			5, 4, 3, 2, 1, 0
		};
		ilb = new int[32]
		{
			2048, 2093, 2139, 2186, 2233, 2282, 2332, 2383, 2435, 2489,
			2543, 2599, 2656, 2714, 2774, 2834, 2896, 2960, 3025, 3091,
			3158, 3228, 3298, 3371, 3444, 3520, 3597, 3676, 3756, 3838,
			3922, 4008
		};
		wh = new int[3] { 0, -214, 798 };
		rh2 = new int[4] { 2, 1, 2, 1 };
		qm2 = new int[4] { -7408, -1616, 7408, 1616 };
		qm4 = new int[16]
		{
			0, -20456, -12896, -8968, -6288, -4240, -2584, -1200, 20456, 12896,
			8968, 6288, 4240, 2584, 1200, 0
		};
		qm5 = new int[32]
		{
			-280, -280, -23352, -17560, -14120, -11664, -9752, -8184, -6864, -5712,
			-4696, -3784, -2960, -2208, -1520, -880, 23352, 17560, 14120, 11664,
			9752, 8184, 6864, 5712, 4696, 3784, 2960, 2208, 1520, 880,
			280, -280
		};
		qm6 = new int[64]
		{
			-136, -136, -136, -136, -24808, -21904, -19008, -16704, -14984, -13512,
			-12280, -11192, -10232, -9360, -8576, -7856, -7192, -6576, -6000, -5456,
			-4944, -4464, -4008, -3576, -3168, -2776, -2400, -2032, -1688, -1360,
			-1040, -728, 24808, 21904, 19008, 16704, 14984, 13512, 12280, 11192,
			10232, 9360, 8576, 7856, 7192, 6576, 6000, 5456, 4944, 4464,
			4008, 3576, 3168, 2776, 2400, 2032, 1688, 1360, 1040, 728,
			432, 136, -432, -136
		};
		qmf_coeffs = new int[12]
		{
			3, -11, 12, 32, -210, 951, 3876, -805, 362, -156,
			53, -11
		};
		q6 = new int[32]
		{
			0, 35, 72, 110, 150, 190, 233, 276, 323, 370,
			422, 473, 530, 587, 650, 714, 786, 858, 940, 1023,
			1121, 1219, 1339, 1458, 1612, 1765, 1980, 2195, 2557, 2919,
			0, 0
		};
		iln = new int[32]
		{
			0, 63, 62, 31, 30, 29, 28, 27, 26, 25,
			24, 23, 22, 21, 20, 19, 18, 17, 16, 15,
			14, 13, 12, 11, 10, 9, 8, 7, 6, 5,
			4, 0
		};
		ilp = new int[32]
		{
			0, 61, 60, 59, 58, 57, 56, 55, 54, 53,
			52, 51, 50, 49, 48, 47, 46, 45, 44, 43,
			42, 41, 40, 39, 38, 37, 36, 35, 34, 33,
			32, 0
		};
		ihn = new int[3] { 0, 1, 0 };
		ihp = new int[3] { 0, 3, 2 };
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
