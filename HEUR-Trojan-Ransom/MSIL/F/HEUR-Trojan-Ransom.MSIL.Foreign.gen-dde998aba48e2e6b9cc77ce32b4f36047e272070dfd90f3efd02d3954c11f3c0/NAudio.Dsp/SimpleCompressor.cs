using System;
using NAudio.Utils;

namespace NAudio.Dsp;

internal sealed class SimpleCompressor : AttRelEnvelope
{
	private double envdB;

	public double MakeUpGain { get; set; }

	public double Threshold { get; set; }

	public double Ratio { get; set; }

	public SimpleCompressor(double attackTime, double releaseTime, double sampleRate)
		: base(attackTime, releaseTime, sampleRate)
	{
		Threshold = 0.0;
		Ratio = 1.0;
		MakeUpGain = 0.0;
		envdB = 1E-25;
	}

	public SimpleCompressor()
		: base(10.0, 10.0, 44100.0)
	{
		Threshold = 0.0;
		Ratio = 1.0;
		MakeUpGain = 0.0;
		envdB = 1E-25;
	}

	public void InitRuntime()
	{
		envdB = 1E-25;
	}

	public void Process(ref double in1, ref double in2)
	{
		double val = Math.Abs(in1);
		double val2 = Math.Abs(in2);
		double num = Decibels.LinearToDecibels(Math.Max(val, val2) + 1E-25) - Threshold;
		if (num < 0.0)
		{
			num = 0.0;
		}
		num += 1E-25;
		Run(num, ref envdB);
		num = envdB - 1E-25;
		double dB = num * (Ratio - 1.0);
		dB = Decibels.DecibelsToLinear(dB) * Decibels.DecibelsToLinear(MakeUpGain);
		in1 *= dB;
		in2 *= dB;
	}
}
