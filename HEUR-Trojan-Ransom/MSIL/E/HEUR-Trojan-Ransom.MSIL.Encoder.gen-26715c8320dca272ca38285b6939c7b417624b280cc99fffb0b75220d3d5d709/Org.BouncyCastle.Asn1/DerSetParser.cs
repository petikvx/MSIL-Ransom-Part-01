namespace Org.BouncyCastle.Asn1;

public class DerSetParser : IAsn1Convertible, Asn1SetParser
{
	private readonly Asn1StreamParser _parser;

	internal DerSetParser(Asn1StreamParser parser)
	{
		_parser = parser;
	}

	public IAsn1Convertible ReadObject()
	{
		return _parser.ReadObject();
	}

	public Asn1Object ToAsn1Object()
	{
		return new DerSet(_parser.ReadVector(), needsSorting: false);
	}
}
