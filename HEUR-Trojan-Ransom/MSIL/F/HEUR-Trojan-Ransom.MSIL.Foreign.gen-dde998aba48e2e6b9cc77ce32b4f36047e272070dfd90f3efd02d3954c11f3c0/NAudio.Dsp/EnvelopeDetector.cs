using System;

namespace NAudio.Dsp;

internal sealed class EnvelopeDetector
{
	private double sampleRate;

	private double ms;

	private double coeff;

	public double TimeConstant
	{
		get
		{
			return ms;
		}
		set
		{
			ms = value;
			SetCoef();
		}
	}

	public double SampleRate
	{
		get
		{
			return sampleRate;
		}
		set
		{
			sampleRate = value;
			SetCoef();
		}
	}

	public EnvelopeDetector()
		: this(1.0, 44100.0)
	{
	}

	public EnvelopeDetector(double ms, double sampleRate)
	{
		this.sampleRate = sampleRate;
		this.ms = ms;
		SetCoef();
	}

	public void Run(double inValue, ref double state)
	{
		state = inValue + coeff * (state - inValue);
	}

	private void SetCoef()
	{
		coeff = Math.Exp(-1.0 / (0.001 * ms * sampleRate));
	}
}
