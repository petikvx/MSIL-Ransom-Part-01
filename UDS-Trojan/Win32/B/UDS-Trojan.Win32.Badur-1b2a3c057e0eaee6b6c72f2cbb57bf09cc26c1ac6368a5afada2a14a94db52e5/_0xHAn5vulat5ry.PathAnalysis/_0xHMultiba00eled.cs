using System.Collections.Generic;

namespace _0xHAn5vulat5ry.PathAnalysis;

public class _0xHMultiba00eled : _0xHMarvelou1ne11
{
	private _0xHArboresce4ce _0xHApo5trophize;

	public string _0xHGeodetic7 { get; private set; }

	public string _0xHTorp2d { get; private set; }

	public override _0xHArboresce4ce _0xHAntic2lt => _0xHApo5trophize;

	public _0xHMultiba00eled(int start, int end, string @namespace, string @class, IEnumerable<string> properties)
		: base(start, end, properties)
	{
		_0xHGeodetic7 = @class;
		_0xHTorp2d = @namespace;
		_0xHApo5trophize = new _0xHArboresce4ce(_0xH5heath.StaticProperty, string.Format("{0}:{1}.{2}", _0xHTorp2d, _0xHGeodetic7, string.Join(".", base._0xHSubgeneration0)));
	}
}
