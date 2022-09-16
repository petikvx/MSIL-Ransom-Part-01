using System.Collections.Generic;
using System.Linq;

namespace _0xHAn5vulat5ry.PathAnalysis;

public class _0xHMarvelou1ne11 : _0xHD8et8t8ans
{
	private _0xHArboresce4ce _0xHCapariso5ed;

	public IEnumerable<string> _0xHSubgeneration0 { get; private set; }

	public override _0xHArboresce4ce _0xHAntic2lt => _0xHCapariso5ed;

	public _0xHMarvelou1ne11(int start, int end, IEnumerable<string> properties)
		: base(start, end)
	{
		_0xHSubgeneration0 = properties.ToList();
		_0xHCapariso5ed = new _0xHArboresce4ce(_0xH5heath.Property, string.Join(".", _0xHSubgeneration0));
	}
}
