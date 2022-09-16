using _0xHMoo0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;
using _0xHSermo8s;
using _0xHWrathe6;

namespace _0xHDefe0si0g;

internal class _0xHSeptette4<ContainerType, ValueType> : _0xHSermo8s._0xHOv2rs22r<ContainerType>
{
	private delegate ValueType _0xHPrepo33e33e3(ContainerType container);

	private readonly _0xHRock7t7d._0xH0amplers<ValueType> _0xHH0rbac0ous;

	private readonly _0xHPrepo33e33e3 _0xH7hoosier;

	public _0xHSeptette4(_0xHCym8n8s property)
	{
		this.valueTypeInfo = (_0xHRock7t7d._0xH0amplers<ValueType>)property._0xHCa8toid;
		this.getter = (_0xHPrepo33e33e3)_0xHHy4ercriticisms._0xHM7dernized(typeof(_0xHPrepo33e33e3), property._0xHO7tkiss);
	}

	public unsafe override void _0xH0appers(_0xHFlag4llat4s _0xHSensori3l, ref ContainerType _0xHMudfl5w)
	{
		ValueType val = ((_0xHMudfl5w == null) ? default(ValueType) : this.getter(_0xHMudfl5w));
		((_0xHRock7t7d._0xH0amplers<_003F>)(object)this.valueTypeInfo).WriteData(_0xHSensori3l, ref *(_003F*)(&val));
	}

	public override object _0xHOrp2ne(ContainerType _0xH6hrank)
	{
		return (_0xH6hrank == null) ? default(ValueType) : this.getter(_0xH6hrank);
	}
}
