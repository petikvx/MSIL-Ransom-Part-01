using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _152 : Control
{
	internal static Type _E000 = _E010._E000(_E00F._E000(_E00E._E000(), _7f46._E000()), ab44._E000);

	private IContainer _E001;

	public _152()
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
