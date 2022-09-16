using System.Reflection;
using _0xHMoo0ers;
using _0xHOppor4unis4;
using _0xHOxidasi7;
using _0xHSermo8s;

namespace _0xHReemph4sized;

internal class _0xHGra2ciz2s<ContainerType> : _0xHSermo8s._0xHOv2rs22r<ContainerType>
{
	private readonly _0xHMit1genic _0xHSou3e;

	private readonly MethodInfo _0xHHarke6;

	public _0xHGra2ciz2s(_0xHCym8n8s property)
	{
		this.getterInfo = property._0xHO7tkiss;
		this.typeInfo = property._0xHCa8toid;
	}

	public override void _0xHRecle1ns(_0xHFlag4llat4s _0xHUnders3udies, ref ContainerType _0xHRiprappe0)
	{
		object _0xHCeda8y = ((_0xHRiprappe0 == null) ? null : this.getterInfo.Invoke(_0xHRiprappe0, null));
		this.typeInfo._0xHInosin1s(_0xHUnders3udies, _0xHCeda8y);
	}

	public override object _0xHSp2kenards(ContainerType _0xHBru7)
	{
		if (_0xHBru7 != null)
		{
			return this.getterInfo.Invoke(_0xHBru7, null);
		}
		return null;
	}
}
