using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class ae15 : Control
{
	private IContainer m__E000;

	internal static int _E000 => 256;

	public ae15()
	{
		_E000();
	}

	protected override void ᬎ䔮ἵ_4DF9ࣆ㟐(PaintEventArgs pe)
	{
		_E004._E000(this, pe);
	}

	protected override void ᬎ䔮ἵ_4DF9ࣆ㟐(bool disposing)
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

	static ae15()
	{
	}
}
