using System;

namespace NAudio.Wave.SampleProviders;

public sealed class SignalGenerator : ISampleProvider
{
	private readonly WaveFormat waveFormat;

	private readonly Random random = new Random();

	private readonly double[] pinkNoiseBuffer = new double[7];

	private const double TwoPi = Math.PI * 2.0;

	private int nSample;

	private double phi;

	public WaveFormat WaveFormat => waveFormat;

	public double Frequency { get; set; }

	public double FrequencyLog => Math.Log(Frequency);

	public double FrequencyEnd { get; set; }

	public double FrequencyEndLog => Math.Log(FrequencyEnd);

	public double Gain { get; set; }

	public bool[] PhaseReverse { get; private set; }

	public SignalGeneratorType Type { get; set; }

	public double SweepLengthSecs { get; set; }

	public SignalGenerator()
		: this(44100, 2)
	{
	}

	public SignalGenerator(int sampleRate, int channel)
	{
		phi = 0.0;
		waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channel);
		Type = SignalGeneratorType.Sin;
		Frequency = 440.0;
		Gain = 1.0;
		PhaseReverse = new bool[channel];
		SweepLengthSecs = 2.0;
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = offset;
		for (int i = 0; i < count / waveFormat.Channels; i++)
		{
			double num2;
			switch (Type)
			{
			case SignalGeneratorType.Sin:
			{
				double num4 = Math.PI * 2.0 * Frequency / (double)waveFormat.SampleRate;
				num2 = Gain * Math.Sin((double)nSample * num4);
				nSample++;
				break;
			}
			case SignalGeneratorType.Square:
			{
				double num4 = 2.0 * Frequency / (double)waveFormat.SampleRate;
				double num7 = (double)nSample * num4 % 2.0 - 1.0;
				num2 = ((num7 > 0.0) ? Gain : (0.0 - Gain));
				nSample++;
				break;
			}
			case SignalGeneratorType.Triangle:
			{
				double num4 = 2.0 * Frequency / (double)waveFormat.SampleRate;
				double num7 = (double)nSample * num4 % 2.0;
				num2 = 2.0 * num7;
				if (num2 > 1.0)
				{
					num2 = 2.0 - num2;
				}
				if (num2 < -1.0)
				{
					num2 = -2.0 - num2;
				}
				num2 *= Gain;
				nSample++;
				break;
			}
			case SignalGeneratorType.SawTooth:
			{
				double num4 = 2.0 * Frequency / (double)waveFormat.SampleRate;
				double num7 = (double)nSample * num4 % 2.0 - 1.0;
				num2 = Gain * num7;
				nSample++;
				break;
			}
			case SignalGeneratorType.White:
				num2 = Gain * NextRandomTwo();
				break;
			case SignalGeneratorType.Pink:
			{
				double num5 = NextRandomTwo();
				pinkNoiseBuffer[0] = 0.99886 * pinkNoiseBuffer[0] + num5 * 0.0555179;
				pinkNoiseBuffer[1] = 0.99332 * pinkNoiseBuffer[1] + num5 * 0.0750759;
				pinkNoiseBuffer[2] = 0.969 * pinkNoiseBuffer[2] + num5 * 0.153852;
				pinkNoiseBuffer[3] = 0.8665 * pinkNoiseBuffer[3] + num5 * 0.3104856;
				pinkNoiseBuffer[4] = 0.55 * pinkNoiseBuffer[4] + num5 * 0.5329522;
				pinkNoiseBuffer[5] = -0.7616 * pinkNoiseBuffer[5] - num5 * 0.016898;
				double num6 = pinkNoiseBuffer[0] + pinkNoiseBuffer[1] + pinkNoiseBuffer[2] + pinkNoiseBuffer[3] + pinkNoiseBuffer[4] + pinkNoiseBuffer[5] + pinkNoiseBuffer[6] + num5 * 0.5362;
				pinkNoiseBuffer[6] = num5 * 0.115926;
				num2 = Gain * (num6 / 5.0);
				break;
			}
			case SignalGeneratorType.Sweep:
			{
				double num3 = Math.Exp(FrequencyLog + (double)nSample * (FrequencyEndLog - FrequencyLog) / (SweepLengthSecs * (double)waveFormat.SampleRate));
				double num4 = Math.PI * 2.0 * num3 / (double)waveFormat.SampleRate;
				phi += num4;
				num2 = Gain * Math.Sin(phi);
				nSample++;
				if ((double)nSample > SweepLengthSecs * (double)waveFormat.SampleRate)
				{
					nSample = 0;
					phi = 0.0;
				}
				break;
			}
			default:
				num2 = 0.0;
				break;
			}
			for (int j = 0; j < waveFormat.Channels; j++)
			{
				if (PhaseReverse[j])
				{
					buffer[num++] = (float)(0.0 - num2);
				}
				else
				{
					buffer[num++] = (float)num2;
				}
			}
		}
		return count;
	}

	private double NextRandomTwo()
	{
		return 2.0 * random.NextDouble() - 1.0;
	}
}
