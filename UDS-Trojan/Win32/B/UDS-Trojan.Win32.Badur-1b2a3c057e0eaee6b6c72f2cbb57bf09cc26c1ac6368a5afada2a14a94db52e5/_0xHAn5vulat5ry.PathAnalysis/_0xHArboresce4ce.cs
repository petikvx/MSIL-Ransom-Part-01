namespace _0xHAn5vulat5ry.PathAnalysis;

public class _0xHArboresce4ce
{
	public _0xH5heath _0xHLum5nar5a { get; private set; }

	public string _0xHShu00ering { get; private set; }

	public _0xHArboresce4ce(_0xH5heath pathType, string value)
	{
		_0xHLum5nar5a = pathType;
		_0xHShu00ering = value;
	}

	public override bool _0xHHy5scine(object _0xHPre2eds)
	{
		if (_0xHPre2eds == null)
		{
			return false;
		}
		if (!(_0xHPre2eds is _0xHArboresce4ce _0xHArboresce4ce2))
		{
			return false;
		}
		return _0xHArboresce4ce2._0xHLum5nar5a == _0xHLum5nar5a && _0xHArboresce4ce2._0xHShu00ering == _0xHShu00ering;
	}

	public override int _0xH7oots()
	{
		return _0xHShu00ering.GetHashCode() ^ _0xHLum5nar5a.GetHashCode();
	}
}
