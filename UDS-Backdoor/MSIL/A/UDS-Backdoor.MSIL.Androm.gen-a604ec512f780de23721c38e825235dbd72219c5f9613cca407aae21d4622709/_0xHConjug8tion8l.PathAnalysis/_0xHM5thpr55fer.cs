using System.Collections.Generic;
using System.Linq;

namespace _0xHConjug8tion8l.PathAnalysis;

public class _0xHM5thpr55fer : _0xHE6det6c
{
	private _0xHWheel6arrowing _0xHAcrolect3;

	public IEnumerable<string> _0xHRigi7ly { get; private set; }

	public override _0xHWheel6arrowing _0xHHy7ridoma => _0xHAcrolect3;

	public _0xHM5thpr55fer(int start, int end, IEnumerable<string> properties)
		: base(start, end)
	{
		_0xHRigi7ly = properties.ToList();
		_0xHAcrolect3 = new _0xHWheel6arrowing(_0xHFlocculato0.Property, string.Join(".", _0xHRigi7ly));
	}
}
