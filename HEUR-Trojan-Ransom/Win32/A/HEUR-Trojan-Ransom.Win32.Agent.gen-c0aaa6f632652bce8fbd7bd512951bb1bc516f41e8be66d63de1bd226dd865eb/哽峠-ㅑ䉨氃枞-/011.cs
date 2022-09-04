using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class _011 : Control
{
	private IContainer m__E000;

	internal static string _E000 => _E000();

	private static string _E000()
	{
		return ab44._E000;
	}

	public _011()
	{
		_E001();
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

	private void _E001()
	{
		this.m__E000 = _E007._E000();
	}

	static _011()
	{
	}
}
