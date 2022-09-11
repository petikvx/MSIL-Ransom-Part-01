using System;

namespace NAudio.Dsp;

public sealed class SmbPitchShifter
{
	private static int MAX_FRAME_LENGTH = 16000;

	private float[] gInFIFO = new float[MAX_FRAME_LENGTH];

	private float[] gOutFIFO = new float[MAX_FRAME_LENGTH];

	private float[] gFFTworksp = new float[2 * MAX_FRAME_LENGTH];

	private float[] gLastPhase = new float[MAX_FRAME_LENGTH / 2 + 1];

	private float[] gSumPhase = new float[MAX_FRAME_LENGTH / 2 + 1];

	private float[] gOutputAccum = new float[2 * MAX_FRAME_LENGTH];

	private float[] gAnaFreq = new float[MAX_FRAME_LENGTH];

	private float[] gAnaMagn = new float[MAX_FRAME_LENGTH];

	private float[] gSynFreq = new float[MAX_FRAME_LENGTH];

	private float[] gSynMagn = new float[MAX_FRAME_LENGTH];

	private long gRover;

	public void PitchShift(float pitchShift, long numSampsToProcess, float sampleRate, float[] indata)
	{
		PitchShift(pitchShift, numSampsToProcess, 2048L, 10L, sampleRate, indata);
	}

	public void PitchShift(float pitchShift, long numSampsToProcess, long fftFrameSize, long osamp, float sampleRate, float[] indata)
	{
		long num = fftFrameSize / 2;
		long num2 = fftFrameSize / osamp;
		double num3 = (double)sampleRate / (double)fftFrameSize;
		double num4 = Math.PI * 2.0 * (double)num2 / (double)fftFrameSize;
		long num5 = fftFrameSize - num2;
		if (gRover == 0L)
		{
			gRover = num5;
		}
		for (long num6 = 0L; num6 < numSampsToProcess; num6++)
		{
			gInFIFO[gRover] = indata[num6];
			indata[num6] = gOutFIFO[gRover - num5];
			gRover++;
			if (gRover < fftFrameSize)
			{
				continue;
			}
			gRover = num5;
			for (long num7 = 0L; num7 < fftFrameSize; num7++)
			{
				double num8 = -0.5 * Math.Cos(Math.PI * 2.0 * (double)num7 / (double)fftFrameSize) + 0.5;
				gFFTworksp[2 * num7] = (float)((double)gInFIFO[num7] * num8);
				gFFTworksp[2 * num7 + 1] = 0f;
			}
			ShortTimeFourierTransform(gFFTworksp, fftFrameSize, -1L);
			for (long num7 = 0L; num7 <= num; num7++)
			{
				double num9 = gFFTworksp[2 * num7];
				double num10 = gFFTworksp[2 * num7 + 1];
				double num11 = 2.0 * Math.Sqrt(num9 * num9 + num10 * num10);
				double num12 = Math.Atan2(num10, num9);
				double num13 = num12 - (double)gLastPhase[num7];
				gLastPhase[num7] = (float)num12;
				num13 -= (double)num7 * num4;
				long num14 = (long)(num13 / Math.PI);
				num14 = ((num14 < 0) ? (num14 - (num14 & 1)) : (num14 + (num14 & 1)));
				num13 -= Math.PI * (double)num14;
				num13 = (double)osamp * num13 / (Math.PI * 2.0);
				num13 = (double)num7 * num3 + num13 * num3;
				gAnaMagn[num7] = (float)num11;
				gAnaFreq[num7] = (float)num13;
			}
			for (int i = 0; i < fftFrameSize; i++)
			{
				gSynMagn[i] = 0f;
				gSynFreq[i] = 0f;
			}
			for (long num7 = 0L; num7 <= num; num7++)
			{
				long num15 = (long)((float)num7 * pitchShift);
				if (num15 <= num)
				{
					gSynMagn[num15] += gAnaMagn[num7];
					gSynFreq[num15] = gAnaFreq[num7] * pitchShift;
				}
			}
			for (long num7 = 0L; num7 <= num; num7++)
			{
				double num11 = gSynMagn[num7];
				double num13 = gSynFreq[num7];
				num13 -= (double)num7 * num3;
				num13 /= num3;
				num13 = Math.PI * 2.0 * num13 / (double)osamp;
				num13 += (double)num7 * num4;
				gSumPhase[num7] += (float)num13;
				double num12 = gSumPhase[num7];
				gFFTworksp[2 * num7] = (float)(num11 * Math.Cos(num12));
				gFFTworksp[2 * num7 + 1] = (float)(num11 * Math.Sin(num12));
			}
			for (long num7 = fftFrameSize + 2; num7 < 2 * fftFrameSize; num7++)
			{
				gFFTworksp[num7] = 0f;
			}
			ShortTimeFourierTransform(gFFTworksp, fftFrameSize, 1L);
			for (long num7 = 0L; num7 < fftFrameSize; num7++)
			{
				double num8 = -0.5 * Math.Cos(Math.PI * 2.0 * (double)num7 / (double)fftFrameSize) + 0.5;
				gOutputAccum[num7] += (float)(2.0 * num8 * (double)gFFTworksp[2 * num7] / (double)(num * osamp));
			}
			for (long num7 = 0L; num7 < num2; num7++)
			{
				gOutFIFO[num7] = gOutputAccum[num7];
			}
			for (long num7 = 0L; num7 < fftFrameSize; num7++)
			{
				gOutputAccum[num7] = gOutputAccum[num7 + num2];
			}
			for (long num7 = 0L; num7 < num5; num7++)
			{
				gInFIFO[num7] = gInFIFO[num7 + num2];
			}
		}
	}

	public void ShortTimeFourierTransform(float[] fftBuffer, long fftFrameSize, long sign)
	{
		for (long num = 2L; num < 2 * fftFrameSize - 2; num += 2)
		{
			long num2 = 2L;
			long num3 = 0L;
			while (num2 < 2 * fftFrameSize)
			{
				if ((num & num2) != 0L)
				{
					num3++;
				}
				num3 <<= 1;
				num2 <<= 1;
			}
			if (num < num3)
			{
				float num4 = fftBuffer[num];
				fftBuffer[num] = fftBuffer[num3];
				fftBuffer[num3] = num4;
				num4 = fftBuffer[num + 1];
				fftBuffer[num + 1] = fftBuffer[num3 + 1];
				fftBuffer[num3 + 1] = num4;
			}
		}
		long num5 = (long)(Math.Log(fftFrameSize) / Math.Log(2.0) + 0.5);
		long num6 = 0L;
		long num7 = 2L;
		for (; num6 < num5; num6++)
		{
			num7 <<= 1;
			long num8 = num7 >> 1;
			float num9 = 1f;
			float num10 = 0f;
			float num11 = (float)Math.PI / (float)(num8 >> 1);
			float num12 = (float)Math.Cos(num11);
			float num13 = (float)((double)sign * Math.Sin(num11));
			for (long num3 = 0L; num3 < num8; num3 += 2)
			{
				float num14;
				for (long num = num3; num < 2 * fftFrameSize; num += num7)
				{
					num14 = fftBuffer[num + num8] * num9 - fftBuffer[num + num8 + 1] * num10;
					float num15 = fftBuffer[num + num8] * num10 + fftBuffer[num + num8 + 1] * num9;
					fftBuffer[num + num8] = fftBuffer[num] - num14;
					fftBuffer[num + num8 + 1] = fftBuffer[num + 1] - num15;
					fftBuffer[num] += num14;
					fftBuffer[num + 1] += num15;
				}
				num14 = num9 * num12 - num10 * num13;
				num10 = num9 * num13 + num10 * num12;
				num9 = num14;
			}
		}
	}
}
