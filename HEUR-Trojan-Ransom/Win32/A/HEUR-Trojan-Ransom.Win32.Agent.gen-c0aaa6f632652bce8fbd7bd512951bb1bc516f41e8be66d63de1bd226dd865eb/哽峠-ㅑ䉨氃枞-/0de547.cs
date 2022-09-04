using System.ComponentModel;
using System.Windows.Forms;
using 哽峠_2F23ㅑ䉨氃枞_222E.Properties;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _0de547 : Control
{
	private IContainer m__E000;

	internal static byte[] _E000()
	{
		return Resources._E002;
	}

	public _0de547()
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

	static _0de547()
	{
	}
}
