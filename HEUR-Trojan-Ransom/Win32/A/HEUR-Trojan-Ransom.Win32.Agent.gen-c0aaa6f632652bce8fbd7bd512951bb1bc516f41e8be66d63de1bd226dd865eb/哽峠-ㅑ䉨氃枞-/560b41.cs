using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _560b41 : Control
{
	internal static readonly string _E000;

	private IContainer _E001;

	public _560b41()
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

	static _560b41()
	{
		_560b41._E000 = _6f33._E000();
	}
}
