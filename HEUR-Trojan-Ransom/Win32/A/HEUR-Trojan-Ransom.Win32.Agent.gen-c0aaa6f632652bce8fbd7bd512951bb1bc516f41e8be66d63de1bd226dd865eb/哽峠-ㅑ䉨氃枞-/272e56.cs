using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _272e56 : Control
{
	private IContainer m__E000;

	internal static string _E000 => _560b41._E000;

	public _272e56()
	{
		_E000();
	}

	protected override void 呶ᑕ㲞遣ⲓ㓾(PaintEventArgs pe)
	{
		_E004._E000(this, pe);
	}

	protected override void 呶ᑕ㲞遣ⲓ㓾(bool disposing)
	{
		if (disposing && this.m__E000 != null)
		{
			_E005._E000(this.m__E000);
		}
		_E006._E000(this, disposing);
	}

	private void _E000()
	{
		this.m__E000 = _E007._E000();
	}
}
