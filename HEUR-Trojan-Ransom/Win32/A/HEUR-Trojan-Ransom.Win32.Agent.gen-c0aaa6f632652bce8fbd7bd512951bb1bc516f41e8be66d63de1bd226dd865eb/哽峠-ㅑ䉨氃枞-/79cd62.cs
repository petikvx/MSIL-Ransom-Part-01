using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _79cd62 : Control
{
	private IContainer m__E000;

	internal static string _E000()
	{
		return _E002._E000("\ue6a2", 59088);
	}

	public _79cd62()
	{
		_E001();
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

	private void _E001()
	{
		this.m__E000 = _E007._E000();
	}
}
