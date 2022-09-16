using _0xHMoo0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;
using _0xHSermo8s;
using _0xHWrathe6;

namespace _0xHC2randeros;

internal class _0xHC7loramine<ContainerType, ValueType> : _0xHSermo8s._0xHOv2rs22r<ContainerType>
{
	private delegate ValueType _0xHPoular3es(ref ContainerType container);

	private readonly _0xHRock7t7d._0xH0amplers<ValueType> _0xHTalip1t;

	private readonly _0xHPoular3es _0xHInoculation1;

	public _0xHC7loramine(_0xHCym8n8s property)
	{
		this.valueTypeInfo = (_0xHRock7t7d._0xH0amplers<ValueType>)property._0xHCa8toid;
		this.getter = (_0xHPoular3es)_0xHHy4ercriticisms._0xHM7dernized(typeof(_0xHPoular3es), property._0xHO7tkiss);
	}

	public unsafe override void _0xHVe4ation(_0xHFlag4llat4s _0xHCriceti4, ref ContainerType _0xH4lkynes)
	{
		ValueType val = ((_0xH4lkynes == null) ? default(ValueType) : this.getter(ref _0xH4lkynes));
		((_0xHRock7t7d._0xH0amplers<_003F>)(object)this.valueTypeInfo).WriteData(_0xHCriceti4, ref *(_003F*)(&val));
	}

	public override object _0xHPlace1an(ContainerType _0xH5urney)
	{
		return (_0xH5urney == null) ? default(ValueType) : this.getter(ref _0xH5urney);
	}
}
