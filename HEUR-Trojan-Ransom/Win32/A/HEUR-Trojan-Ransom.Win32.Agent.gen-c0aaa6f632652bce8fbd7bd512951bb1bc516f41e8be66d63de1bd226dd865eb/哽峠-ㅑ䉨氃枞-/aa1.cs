using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class aa1 : Control
{
	internal delegate void 膤瘇ǌஐ蓷㪢();

	private IContainer m__E000;

	public aa1()
	{
		_E000();
	}

	protected override void 膤瘇ǌஐ蓷㪢(PaintEventArgs pe)
	{
		_E004._E000(this, pe);
	}

	protected override void 膤瘇ǌஐ蓷㪢(bool disposing)
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

	static aa1()
	{
	}
}
