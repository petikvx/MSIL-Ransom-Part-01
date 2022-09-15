namespace Org.BouncyCastle.Crypto.Operators;

internal class RsaPkcs1WrapperProvider : WrapperProvider
{
	internal RsaPkcs1WrapperProvider()
	{
	}

	object WrapperProvider.CreateWrapper(bool forWrapping, ICipherParameters parameters)
	{
		return new RsaPkcs1Wrapper(forWrapping, parameters);
	}
}
