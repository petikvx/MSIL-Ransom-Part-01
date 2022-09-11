namespace NAudio.Wave.SampleProviders;

public sealed class StereoBalanceStrategy : IPanStrategy
{
	public StereoSamplePair GetMultipliers(float pan)
	{
		float left = ((pan <= 0f) ? 1f : ((1f - pan) / 2f));
		float right = ((pan >= 0f) ? 1f : ((pan + 1f) / 2f));
		StereoSamplePair result = default(StereoSamplePair);
		result.Left = left;
		result.Right = right;
		return result;
	}
}
