using _0xH6yplays;
using _0xHBot0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;

namespace _0xHSeismograp2y;

internal sealed class _0xHOverp6ck6ged<ElementType> : _0xHRock7t7d._0xH0amplers<ElementType[]>
{
	private readonly _0xHRock7t7d._0xH0amplers<ElementType> _0xHSprai4s;

	public _0xHOverp6ck6ged(_0xHRock7t7d._0xH0amplers<ElementType> elementInfo)
	{
		this.elementInfo = elementInfo;
	}

	public override void _0xHQua33rocen3o(_0xHSignalization1 _0xH8ppetence, string _0xHJive1s, _0xHGri22ery _0xHIro8ize)
	{
		_0xH8ppetence._0xH0nserfment();
		this.elementInfo._0xHMispa4ched(_0xH8ppetence, _0xHJive1s, _0xHIro8ize);
		_0xH8ppetence._0xHDi2re2pect();
	}

	public override void _0xHUns6ressed(_0xHFlag4llat4s _0xHSteamshi6, ref ElementType[] _0xHN3atnik)
	{
		int _0xHPica = _0xHSteamshi6._0xH0onrioting();
		int _0xHKa0sin = 0;
		if (_0xHN3atnik != null)
		{
			_0xHKa0sin = _0xHN3atnik.Length;
			for (int i = 0; i < _0xHN3atnik.Length; i = checked(i + 1))
			{
				this.elementInfo.WriteData(_0xHSteamshi6, ref _0xHN3atnik[i]);
			}
		}
		_0xHSteamshi6._0xHCo4triva4ces(_0xHPica, _0xHKa0sin);
	}

	public override object _0xHSowabl4(object _0xH2ravity)
	{
		ElementType[] array = (ElementType[])_0xH2ravity;
		object[] array2 = new object[array.Length];
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			array2[i] = this.elementInfo._0xHAm7nd7rs(array[i]);
		}
		return array2;
	}
}
