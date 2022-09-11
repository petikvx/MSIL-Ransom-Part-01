namespace NAudio.Wave.SampleProviders;

public interface IPanStrategy
{
	StereoSamplePair GetMultipliers(float pan);
}
