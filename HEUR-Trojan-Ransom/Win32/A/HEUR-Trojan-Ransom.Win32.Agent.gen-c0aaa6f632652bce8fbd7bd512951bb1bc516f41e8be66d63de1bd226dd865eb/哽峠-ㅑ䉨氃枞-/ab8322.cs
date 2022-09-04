using System.ComponentModel;
using System.Windows.Forms;

namespace 哽峠_2F23ㅑ䉨氃枞_222E;

public class ab8322 : Control
{
	internal static readonly byte[] _E000;

	private IContainer _E001;

	public ab8322()
	{
		_E000();
	}

	protected override void ᬎ䔮ἵ_4DF9ࣆ㟐(PaintEventArgs pe)
	{
		_E004._E000(this, pe);
	}

	protected override void ᬎ䔮ἵ_4DF9ࣆ㟐(bool disposing)
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

	static ab8322()
	{
		ab8322._E000 = _50b5._E000;
	}
}
