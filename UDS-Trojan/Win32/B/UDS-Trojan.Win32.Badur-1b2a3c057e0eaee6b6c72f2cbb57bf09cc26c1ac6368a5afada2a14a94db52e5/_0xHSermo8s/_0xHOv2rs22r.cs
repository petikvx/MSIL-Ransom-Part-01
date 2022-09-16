using System;
using _0xHDefe0si0g;
using _0xHMoo0ers;
using _0xHOppor4unis4;
using _0xHReemph4sized;
using _0xHWrathe6;

namespace _0xHSermo8s;

internal abstract class _0xHOv2rs22r<ContainerType>
{
	public abstract void _0xHGanev2(_0xHFlag4llat4s _0xHS7uirmy, ref ContainerType _0xHOverki66ed);

	public abstract object _0xHShoa8est(ContainerType _0xHPen6a6hle6es);

	public static _0xHSermo8s._0xHOv2rs22r<ContainerType> _0xH4iggest(_0xHCym8n8s _0xHE1ollient)
	{
		Type returnType = _0xHE1ollient._0xHO7tkiss.ReturnType;
		if (!_0xHHy4ercriticisms._0xHN8wi8(typeof(ContainerType)))
		{
			if (returnType == typeof(int))
			{
				return new _0xHDefe0si0g._0xHSeptette4<ContainerType, int>(_0xHE1ollient);
			}
			if (returnType == typeof(long))
			{
				return new _0xHDefe0si0g._0xHSeptette4<ContainerType, long>(_0xHE1ollient);
			}
			if (returnType == typeof(string))
			{
				return new _0xHDefe0si0g._0xHSeptette4<ContainerType, string>(_0xHE1ollient);
			}
		}
		return new _0xHReemph4sized._0xHGra2ciz2s<ContainerType>(_0xHE1ollient);
	}
}
