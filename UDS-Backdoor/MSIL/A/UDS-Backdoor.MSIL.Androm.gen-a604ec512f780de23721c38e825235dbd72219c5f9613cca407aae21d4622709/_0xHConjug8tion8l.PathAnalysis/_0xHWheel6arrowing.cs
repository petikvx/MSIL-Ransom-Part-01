namespace _0xHConjug8tion8l.PathAnalysis;

public class _0xHWheel6arrowing
{
	public _0xHFlocculato0 _0xHA3oid { get; private set; }

	public string _0xHCl7ssic { get; private set; }

	public _0xHWheel6arrowing(_0xHFlocculato0 pathType, string value)
	{
		_0xHA3oid = pathType;
		_0xHCl7ssic = value;
	}

	public override bool _0xHComprehe1di1g(object _0xHHand4ists)
	{
		if (_0xHHand4ists == null)
		{
			return false;
		}
		if (!(_0xHHand4ists is _0xHWheel6arrowing _0xHWheel6arrowing2))
		{
			return false;
		}
		return _0xHWheel6arrowing2._0xHA3oid == _0xHA3oid && _0xHWheel6arrowing2._0xHCl7ssic == _0xHCl7ssic;
	}

	public override int _0xHAng2lar()
	{
		return _0xHCl7ssic.GetHashCode() ^ _0xHA3oid.GetHashCode();
	}
}
