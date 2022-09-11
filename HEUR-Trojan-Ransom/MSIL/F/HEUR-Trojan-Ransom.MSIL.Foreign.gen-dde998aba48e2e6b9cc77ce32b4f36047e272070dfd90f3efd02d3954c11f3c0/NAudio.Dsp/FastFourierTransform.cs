using System;

namespace NAudio.Dsp;

public static class FastFourierTransform
{
	public static void FFT(bool forward, int m, Complex[] data)
	{
		int num = 1;
		for (int i = 0; i < m; i++)
		{
			num *= 2;
		}
		int num2 = num >> 1;
		int num3 = 0;
		for (int i = 0; i < num - 1; i++)
		{
			if (i < num3)
			{
				float x = data[i].X;
				float y = data[i].Y;
				data[i].X = data[num3].X;
				data[i].Y = data[num3].Y;
				data[num3].X = x;
				data[num3].Y = y;
			}
			int num4;
			for (num4 = num2; num4 <= num3; num4 >>= 1)
			{
				num3 -= num4;
			}
			num3 += num4;
		}
		float num5 = -1f;
		float num6 = 0f;
		int num7 = 1;
		for (int j = 0; j < m; j++)
		{
			int num8 = num7;
			num7 <<= 1;
			float num9 = 1f;
			float num10 = 0f;
			for (num3 = 0; num3 < num8; num3++)
			{
				for (int i = num3; i < num; i += num7)
				{
					int num11 = i + num8;
					float num12 = num9 * data[num11].X - num10 * data[num11].Y;
					float num13 = num9 * data[num11].Y + num10 * data[num11].X;
					data[num11].X = data[i].X - num12;
					data[num11].Y = data[i].Y - num13;
					data[i].X += num12;
					data[i].Y += num13;
				}
				float num14 = num9 * num5 - num10 * num6;
				num10 = num9 * num6 + num10 * num5;
				num9 = num14;
			}
			num6 = (float)Math.Sqrt((1f - num5) / 2f);
			if (forward)
			{
				num6 = 0f - num6;
			}
			num5 = (float)Math.Sqrt((1f + num5) / 2f);
		}
		if (forward)
		{
			for (int i = 0; i < num; i++)
			{
				data[i].X /= num;
				data[i].Y /= num;
			}
		}
	}

	public static double HammingWindow(int n, int frameSize)
	{
		return 0.54 - 0.46 * Math.Cos(Math.PI * 2.0 * (double)n / (double)(frameSize - 1));
	}

	public static double HannWindow(int n, int frameSize)
	{
		return 0.5 * (1.0 - Math.Cos(Math.PI * 2.0 * (double)n / (double)(frameSize - 1)));
	}

	public static double BlackmannHarrisWindow(int n, int frameSize)
	{
		return 287.0 / 800.0 - 0.48829 * Math.Cos(Math.PI * 2.0 * (double)n / (double)(frameSize - 1)) + 0.14128 * Math.Cos(Math.PI * 4.0 * (double)n / (double)(frameSize - 1)) - 0.01168 * Math.Cos(Math.PI * 6.0 * (double)n / (double)(frameSize - 1));
	}
}
