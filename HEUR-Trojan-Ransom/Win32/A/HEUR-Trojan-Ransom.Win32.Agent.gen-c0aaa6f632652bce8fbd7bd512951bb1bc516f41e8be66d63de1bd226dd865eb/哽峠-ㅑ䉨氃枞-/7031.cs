using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _7031 : Control
{
	internal static readonly a63.呶ᑕ㲞遣ⲓ㓾 _E000;

	private IContainer _E001;

	public _7031()
	{
		_E000();
	}

	protected override void 呶ᑕ㲞遣ⲓ㓾(PaintEventArgs pe)
	{
		_E004._E000(this, pe);
	}

	protected override void 呶ᑕ㲞遣ⲓ㓾(bool disposing)
	{
		if (disposing && _E001 != null)
		{
			_E005._E000(_E001);
		}
		_E006._E000(this, disposing);
	}

	private void _E000()
	{
		_E001 = _E007._E000();
	}

	static _7031()
	{
		_7031._E000 = (a63.呶ᑕ㲞遣ⲓ㓾)_E00A._E000(_E008._E000(typeof(a63.呶ᑕ㲞遣ⲓ㓾).TypeHandle), _E00C._E000(_E008._E000(typeof(Convert).TypeHandle), _3f97412._E000, new Type[1] { _E008._E000(typeof(int).TypeHandle) }));
	}
}
