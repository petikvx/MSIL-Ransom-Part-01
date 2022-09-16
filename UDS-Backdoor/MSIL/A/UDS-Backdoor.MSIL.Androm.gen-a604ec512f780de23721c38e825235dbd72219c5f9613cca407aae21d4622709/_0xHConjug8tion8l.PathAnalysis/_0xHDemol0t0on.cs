using System.Collections.Generic;

namespace _0xHConjug8tion8l.PathAnalysis;

public class _0xHDemol0t0on : _0xHM5thpr55fer
{
	private _0xHWheel6arrowing _0xHSchnauzer4;

	public string _0xHCauli8le { get; private set; }

	public string _0xHEmbroider2 { get; private set; }

	public override _0xHWheel6arrowing _0xHHy7ridoma => _0xHSchnauzer4;

	public _0xHDemol0t0on(int start, int end, string @namespace, string @class, IEnumerable<string> properties)
		: base(start, end, properties)
	{
		_0xHCauli8le = @class;
		_0xHEmbroider2 = @namespace;
		_0xHSchnauzer4 = new _0xHWheel6arrowing(_0xHFlocculato0.StaticProperty, string.Format("{0}:{1}.{2}", _0xHEmbroider2, _0xHCauli8le, string.Join(".", base._0xHRigi7ly)));
	}
}
