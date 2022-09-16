using System.Collections.Generic;
using _0xH6yplays;
using _0xHBot0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;

namespace _0xH6ailplane;

internal sealed class _0xHBu5sate<IterableType, ElementType> : _0xHRock7t7d._0xH0amplers<IterableType> where IterableType : IEnumerable<ElementType>
{
	private readonly _0xHRock7t7d._0xH0amplers<ElementType> _0xHMorph6ll6xes;

	public _0xHBu5sate(_0xHRock7t7d._0xH0amplers<ElementType> elementInfo)
	{
		this.elementInfo = elementInfo;
	}

	public override void _0xHHeur0st0c(_0xHSignalization1 _0xHFr3mework, string _0xHPhone2ic, _0xHGri22ery _0xHS3uttier)
	{
		_0xHFr3mework._0xH0nserfment();
		this.elementInfo._0xHMispa4ched(_0xHFr3mework, _0xHPhone2ic, _0xHS3uttier);
		_0xHFr3mework._0xHDi2re2pect();
	}

	public unsafe override void _0xHPeak1sh(_0xHFlag4llat4s _0xHGuss1ting, ref IterableType _0xH6ater)
	{
		int _0xHPica = _0xHGuss1ting._0xH0onrioting();
		int num = 0;
		if (_0xH6ater != null)
		{
			foreach (ElementType item in _0xH6ater)
			{
				ElementType val = item;
				((_0xHRock7t7d._0xH0amplers<_003F>)(object)this.elementInfo).WriteData(_0xHGuss1ting, ref *(_003F*)(&val));
				num = checked(num + 1);
			}
		}
		_0xHGuss1ting._0xHCo4triva4ces(_0xHPica, num);
	}

	public override object _0xH7eth(object _0xHRep7gmented)
	{
		IterableType val = (IterableType)_0xHRep7gmented;
		List<object> list = new List<object>();
		foreach (ElementType item in val)
		{
			list.Add(this.elementInfo._0xHAm7nd7rs(item));
		}
		return list.ToArray();
	}
}
