using System;

namespace NAudio.Wave.SampleProviders;

public sealed class SinPanStrategy : IPanStrategy
{
	private const float HalfPi = (float)Math.PI / 2f;

	public StereoSamplePair GetMultipliers(float pan)
	{
		float num = (0f - pan + 1f) / 2f;
		float left = (float)Math.Sin(num * ((float)Math.PI / 2f));
		float right = (float)Math.Cos(num * ((float)Math.PI / 2f));
		StereoSamplePair result = default(StereoSamplePair);
		result.Left = left;
		result.Right = right;
		return result;
	}
}
