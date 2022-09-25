namespace Stealer;

public interface IGcmMultiplier
{
	void Init(byte[] H);

	void MultiplyH(byte[] x);
}
