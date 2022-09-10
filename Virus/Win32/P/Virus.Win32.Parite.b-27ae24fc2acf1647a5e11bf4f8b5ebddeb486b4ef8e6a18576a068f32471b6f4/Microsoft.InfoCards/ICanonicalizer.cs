namespace Microsoft.InfoCards;

internal interface ICanonicalizer
{
	bool CanCanonicalize(object obj);

	byte[] Canonicalize(object obj);
}
