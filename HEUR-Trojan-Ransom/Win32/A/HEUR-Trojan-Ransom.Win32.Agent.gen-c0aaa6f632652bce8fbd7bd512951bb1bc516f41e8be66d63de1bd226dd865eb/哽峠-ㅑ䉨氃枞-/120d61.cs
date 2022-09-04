using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _120d61 : Control
{
	internal static byte[] _E000 = ((_785c638.呶ᑕ㲞遣ⲓ㓾)_E013._E000(_E008._E000(typeof(_785c638.呶ᑕ㲞遣ⲓ㓾).TypeHandle), _E012._E000(), _E00C._E000(_E008._E000(typeof(Encoding).TypeHandle), _883._E000, new Type[1] { _E008._E000(typeof(string).TypeHandle) })))(bc7._E000);

	private IContainer _E001;

	public _120d61()
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
}
